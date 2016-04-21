Imports System.Runtime.InteropServices
Imports System.Threading

Public Class Form1

    Private WithEvents refTimer As New System.Windows.Forms.Timer()


    Private Declare Function OpenProcess Lib "kernel32.dll" (ByVal dwDesiredAcess As UInt32, ByVal bInheritHandle As Boolean, ByVal dwProcessId As Int32) As IntPtr
    Private Declare Function ReadProcessMemory Lib "kernel32" (ByVal hProcess As IntPtr, ByVal lpBaseAddress As IntPtr, ByVal lpBuffer() As Byte, ByVal iSize As Integer, ByRef lpNumberOfBytesRead As Integer) As Boolean
    Private Declare Function WriteProcessMemory Lib "kernel32" (ByVal hProcess As IntPtr, ByVal lpBaseAddress As IntPtr, ByVal lpBuffer() As Byte, ByVal iSize As Integer, ByVal lpNumberOfBytesWritten As Integer) As Boolean
    Private Declare Function CloseHandle Lib "kernel32.dll" (ByVal hObject As IntPtr) As Boolean
    Private Declare Function VirtualAllocEx Lib "kernel32.dll" (ByVal hProcess As IntPtr, ByVal lpAddress As IntPtr, ByVal dwSize As IntPtr, ByVal flAllocationType As Integer, ByVal flProtect As Integer) As IntPtr
    Private Declare Function CreateRemoteThread Lib "kernel32" (ByVal hProcess As Integer, ByVal lpThreadAttributes As Integer, ByVal dwStackSize As Integer, ByVal lpStartAddress As Integer, ByVal lpParameter As Integer, ByVal dwCreationFlags As Integer, ByRef lpThreadId As Integer) As Integer

    Public Const PROCESS_VM_READ = &H10
    Public Const TH32CS_SNAPPROCESS = &H2
    Public Const MEM_COMMIT = 4096
    Public Const PAGE_READWRITE = 4
    Public Const PROCESS_CREATE_THREAD = (&H2)
    Public Const PROCESS_VM_OPERATION = (&H8)
    Public Const PROCESS_VM_WRITE = (&H20)
    Public Const PROCESS_ALL_ACCESS = &H1F0FFF

    Private _targetProcess As Process = Nothing 'to keep track of it. not used yet.
    Private _targetProcessHandle As IntPtr = IntPtr.Zero 'Used for ReadProcessMemory

    Private DS3membase As Int64

    Dim cllHsbars() As HScrollBar


    Public Function ReadInt8(ByVal addr As IntPtr) As SByte
        Dim _rtnBytes(0) As Byte
        ReadProcessMemory(_targetProcessHandle, addr, _rtnBytes, 1, vbNull)
        Return _rtnBytes(0)
    End Function
    Public Function ReadInt16(ByVal addr As IntPtr) As Int16
        Dim _rtnBytes(1) As Byte
        ReadProcessMemory(_targetProcessHandle, addr, _rtnBytes, 2, vbNull)
        Return BitConverter.ToInt16(_rtnBytes, 0)
    End Function
    Public Function ReadInt32(ByVal addr As IntPtr) As Int32
        Dim _rtnBytes(3) As Byte
        ReadProcessMemory(_targetProcessHandle, addr, _rtnBytes, 4, vbNull)

        Return BitConverter.ToInt32(_rtnBytes, 0)
    End Function
    Public Function ReadInt64(ByVal addr As IntPtr) As Int64
        Dim _rtnBytes(7) As Byte
        ReadProcessMemory(_targetProcessHandle, addr, _rtnBytes, 8, vbNull)
        Return BitConverter.ToInt64(_rtnBytes, 0)
    End Function
    Public Function ReadUInt16(ByVal addr As IntPtr) As UInt16
        Dim _rtnBytes(1) As Byte
        ReadProcessMemory(_targetProcessHandle, addr, _rtnBytes, 2, vbNull)
        Return BitConverter.ToUInt16(_rtnBytes, 0)
    End Function
    Public Function ReadUInt32(ByVal addr As IntPtr) As UInt32
        Dim _rtnBytes(3) As Byte
        ReadProcessMemory(_targetProcessHandle, addr, _rtnBytes, 4, vbNull)
        Return BitConverter.ToUInt32(_rtnBytes, 0)
    End Function
    Public Function ReadUInt64(ByVal addr As IntPtr) As UInt64
        Dim _rtnBytes(7) As Byte
        ReadProcessMemory(_targetProcessHandle, addr, _rtnBytes, 8, vbNull)
        Return BitConverter.ToUInt64(_rtnBytes, 0)
    End Function
    Public Function ReadFloat(ByVal addr As IntPtr) As Single
        Dim _rtnBytes(3) As Byte
        ReadProcessMemory(_targetProcessHandle, addr, _rtnBytes, 4, vbNull)
        Return BitConverter.ToSingle(_rtnBytes, 0)
    End Function
    Public Function ReadDouble(ByVal addr As IntPtr) As Double
        Dim _rtnBytes(7) As Byte
        ReadProcessMemory(_targetProcessHandle, addr, _rtnBytes, 8, vbNull)
        Return BitConverter.ToDouble(_rtnBytes, 0)
    End Function
    Public Function ReadIntPtr(ByVal addr As IntPtr) As IntPtr
        Dim _rtnBytes(IntPtr.Size - 1) As Byte
        ReadProcessMemory(_targetProcessHandle, addr, _rtnBytes, IntPtr.Size, Nothing)
        If IntPtr.Size = 4 Then
            Return New IntPtr(BitConverter.ToUInt32(_rtnBytes, 0))
        Else
            Return New IntPtr(BitConverter.ToInt64(_rtnBytes, 0))
        End If
    End Function
    Public Function ReadBytes(ByVal addr As IntPtr, ByVal size As Int32) As Byte()
        Dim _rtnBytes(size - 1) As Byte
        ReadProcessMemory(_targetProcessHandle, addr, _rtnBytes, size, vbNull)
        Return _rtnBytes
    End Function
    Private Function ReadAsciiStr(ByVal addr As UInteger) As String
        Dim Str As String = ""
        Dim cont As Boolean = True
        Dim loc As Integer = 0

        Dim bytes(&H10) As Byte

        ReadProcessMemory(_targetProcessHandle, addr, bytes, &H10, vbNull)

        While (cont And loc < &H10)
            If bytes(loc) > 0 Then

                Str = Str + Convert.ToChar(bytes(loc))

                loc += 1
            Else
                cont = False
            End If
        End While

        Return Str
    End Function
    Private Function ReadUnicodeStr(ByVal addr As UInteger) As String
        Dim Str As String = ""
        Dim cont As Boolean = True
        Dim loc As Integer = 0

        Dim bytes(&H20) As Byte


        ReadProcessMemory(_targetProcessHandle, addr, bytes, &H20, vbNull)

        While (cont And loc < &H20)
            If bytes(loc) > 0 Then

                Str = Str + Convert.ToChar(bytes(loc))

                loc += 2
            Else
                cont = False
            End If
        End While

        Return Str
    End Function

    Public Sub WriteInt8(ByVal addr As IntPtr, val As SByte)
        WriteProcessMemory(_targetProcessHandle, addr, {CByte(val)}, 1, Nothing)
    End Sub
    Public Sub WriteInt32(ByVal addr As IntPtr, val As Int32)
        WriteProcessMemory(_targetProcessHandle, addr, BitConverter.GetBytes(val), 4, Nothing)
    End Sub
    Public Sub WriteInt64(ByVal addr As IntPtr, val As Int64)
        WriteProcessMemory(_targetProcessHandle, addr, BitConverter.GetBytes(val), 8, Nothing)
    End Sub
    Public Sub WriteUInt32(ByVal addr As IntPtr, val As UInt32)
        WriteProcessMemory(_targetProcessHandle, addr, BitConverter.GetBytes(val), 4, Nothing)
    End Sub
    Public Sub WriteFloat(ByVal addr As IntPtr, val As Single)
        WriteProcessMemory(_targetProcessHandle, addr, BitConverter.GetBytes(val), 4, Nothing)
    End Sub
    Public Sub WriteBytes(ByVal addr As IntPtr, val As Byte())
        WriteProcessMemory(_targetProcessHandle, addr, val, val.Length, Nothing)
    End Sub
    Public Sub WriteAsciiStr(addr As UInteger, str As String)
        WriteProcessMemory(_targetProcessHandle, addr, System.Text.Encoding.ASCII.GetBytes(str), str.Length, Nothing)
    End Sub



    Public Function TryAttachToProcess(ByVal windowCaption As String) As Boolean
        Dim _allProcesses() As Process = Process.GetProcesses
        For Each pp As Process In _allProcesses
            'If pp.MainWindowTitle.ToLower.Equals(windowCaption.ToLower) Then
            If pp.ProcessName.ToLower.Equals(windowCaption.ToLower) Then
                'found it! proceed.
                Return TryAttachToProcess(pp)
            End If
        Next
        MessageBox.Show("Unable to find process '" & windowCaption & "'." & vbCrLf & " Is it running?")
        Return False
    End Function
    Public Function TryAttachToProcess(ByVal proc As Process) As Boolean
        If _targetProcessHandle = IntPtr.Zero Then 'not already attached
            _targetProcess = proc
            _targetProcessHandle = OpenProcess(PROCESS_ALL_ACCESS, False, _targetProcess.Id)
            If _targetProcessHandle = 0 Then
                TryAttachToProcess = False
                MessageBox.Show("OpenProcess() FAIL! Are you Administrator??")
            Else
                'if we get here, all connected and ready to use ReadProcessMemory()
                DS3membase = _targetProcess.Modules(0).BaseAddress
                TryAttachToProcess = True
                'MessageBox.Show("OpenProcess() OK")
            End If
        Else
            MessageBox.Show("Already attached! (Please Detach first?)")
            TryAttachToProcess = False
        End If
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim delay = 10

        refTimer = New System.Windows.Forms.Timer
        refTimer.Interval = delay
        refTimer.Enabled = True
        refTimer.Start()

        TryAttachToProcess("darksoulsiii")

        initClls()

    End Sub

    Private Sub initClls()
        cllHsbars = {hsHead, hsChest, hsHips, hsRArm, hsRLeg, hsLArm, hsLLeg}
    End Sub
    Private Sub refTimer_Tick() Handles refTimer.Tick
        Select Case tabs.SelectedIndex
            Case 0
                refstats()
        End Select

    End Sub

    Private Sub refstats()
        Dim charptr1 = ReadInt64(DS3membase + &H4491F50)
        charptr1 = ReadInt64(charptr1 + &H18)
        charptr1 = ReadInt64(charptr1 + &H7D8)
        charptr1 = ReadInt64(charptr1 + &H400)

        Dim gamestats = ReadInt64(DS3membase + &H469BDF8)
        Dim gamestats2 = ReadInt64(gamestats + &H10)
        Dim charptr2 = ReadInt64(gamestats + &H10)

        Dim charmapptr = ReadInt64(DS3membase + &H4491F50)
        charmapptr = ReadInt64(charmapptr + &H28)

        If Not txtCurrHp.Focused Then txtCurrHp.Text = ReadInt32(gamestats2 + &H18)
        If Not txtMaxHp.Focused Then txtMaxHp.Text = ReadInt32(gamestats2 + &H1C)
        If Not txtCurrFp.Focused Then txtCurrFp.Text = ReadInt32(gamestats2 + &H24)
        If Not txtMaxFp.Focused Then txtMaxFp.Text = ReadInt32(gamestats2 + &H28)
        If Not txtCurrStam.Focused Then txtCurrStam.Text = ReadInt32(gamestats2 + &H34)
        If Not txtMaxStam.Focused Then txtMaxStam.Text = ReadInt32(gamestats2 + &H38)

        If Not txtVigor.Focused Then txtVigor.Text = ReadInt32(charptr2 + &H44)
        If Not txtAttunement.Focused Then txtAttunement.Text = ReadInt32(charptr2 + &H48)
        If Not txtEndurance.Focused Then txtEndurance.Text = ReadInt32(charptr2 + &H4C)
        If Not txtStrength.Focused Then txtStrength.Text = ReadInt32(charptr2 + &H50)
        If Not txtDexterity.Focused Then txtDexterity.Text = ReadInt32(charptr2 + &H54)
        If Not txtIntelligence.Focused Then txtIntelligence.Text = ReadInt32(charptr2 + &H58)
        If Not txtFaith.Focused Then txtFaith.Text = ReadInt32(charptr2 + &H5C)
        If Not txtLuck.Focused Then txtLuck.Text = ReadInt32(charptr2 + &H60)
        If Not txtVitality.Focused Then txtVitality.Text = ReadInt32(charptr2 + &H6C)

        If Not txtSoulLevel.Focused Then txtSoulLevel.Text = ReadInt32(charptr2 + &H70)
        If Not txtSouls.Focused Then txtSouls.Text = ReadInt32(charptr2 + &H74)
        If Not txtSoulMemory.Focused Then txtSoulMemory.Text = ReadInt32(charptr2 + &H78)

        If Not txtDeaths.Focused Then txtDeaths.Text = ReadInt32(gamestats + &H90)

        If Not txtTimePlayed.Focused Then
            Dim played As TimeSpan
            played = TimeSpan.FromMilliseconds(ReadInt32(gamestats + &H9C))
            txtTimePlayed.Text = played.ToString("g")
        End If

        If Not txtCovenant.Focused Then
            Dim cov = ReadInt8(charptr2 + &HF7)
            Select Case cov
                Case 0
                    txtCovenant.Text = "None"
                Case 2
                    txtCovenant.Text = "Warrior of Sunlight"
                Case 3
                    txtCovenant.Text = "Mound-Makers"
                Case 5
                    txtCovenant.Text = "Rosaria's Fingers"
                Case 6
                    txtCovenant.Text = "Watchdogs of Farron"
                Case 7
                    txtCovenant.Text = "Aldrich Faithful"
                Case 8
                    txtCovenant.Text = "Way of Blue"
                Case 9
                    txtCovenant.Text = "Blue Sentinels"
            End Select
        End If


        chkMale.Checked = (ReadInt8(charptr2 + &HAA) = 1)
        chkEmbered.Checked = (ReadInt8(charptr2 + &H100) = 1)
        chkHideMap.Checked = (ReadInt8(ReadInt64(DS3membase + &H48A6D20) + &H4E26) = 1)

        If Not txtXPos.Focused Then txtXPos.Text = Math.Round(ReadFloat(charmapptr + &H80), 1)
        If Not txtYPos.Focused Then txtYPos.Text = Math.Round(ReadFloat(charmapptr + &H84), 1)
        If Not txtZPos.Focused Then txtZPos.Text = Math.Round(ReadFloat(charmapptr + &H88), 1)


        If Not txtTimesSummoned.Focused Then txtTimesSummoned.Text = ReadInt32(gamestats2 + &HB4)
        If Not txtTimesSuccessful.Focused Then txtTimesSuccessful.Text = ReadInt32(gamestats2 + &HB8)

    End Sub

    Private Function limitFloat(ByVal val As Single, ByVal min As Single, ByVal max As Single)
        If val > max Then val = max
        If val < min Then val = min
        Return val
    End Function

    Private Sub chkHideMap_CheckedChanged(sender As Object, e As EventArgs) Handles chkHideMap.CheckedChanged
        Dim tmpptr = ReadInt64(DS3membase + &H48A6D20)

        If chkHideMap.Checked Then
            WriteInt8(tmpptr + &H4E26, 1)
        Else
            WriteInt8(tmpptr + &H4E26, 0)
        End If
    End Sub

    Private Sub hsHead_Scroll(sender As Object, e As ScrollEventArgs) Handles hsHead.Scroll, hsChest.Scroll,
            hsHips.Scroll, hsRArm.Scroll, hsRLeg.Scroll, hsLArm.Scroll, hsLLeg.Scroll
        Dim idx As Integer = Array.IndexOf(cllHsbars, sender)

        Dim charptr2 = ReadInt64(DS3membase + &H469BDF8)
        charptr2 = ReadInt64(charptr2 + &H10)

        Dim val = (sender.value - 50) / 10

        WriteFloat(charptr2 + &H3B0 + (idx * 4), val)

    End Sub
End Class