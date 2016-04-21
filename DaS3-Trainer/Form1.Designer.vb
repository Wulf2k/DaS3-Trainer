<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tabs = New System.Windows.Forms.TabControl()
        Me.tabStats = New System.Windows.Forms.TabPage()
        Me.txtZPos = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtYPos = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtXPos = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.chkMale = New System.Windows.Forms.CheckBox()
        Me.chkEmbered = New System.Windows.Forms.CheckBox()
        Me.txtCovenant = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtDeaths = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtTimePlayed = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.hsLLeg = New System.Windows.Forms.HScrollBar()
        Me.hsLArm = New System.Windows.Forms.HScrollBar()
        Me.hsRLeg = New System.Windows.Forms.HScrollBar()
        Me.hsRArm = New System.Windows.Forms.HScrollBar()
        Me.hsHips = New System.Windows.Forms.HScrollBar()
        Me.hsChest = New System.Windows.Forms.HScrollBar()
        Me.hsHead = New System.Windows.Forms.HScrollBar()
        Me.chkHideMap = New System.Windows.Forms.CheckBox()
        Me.txtSoulLevel = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtVitality = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtLuck = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFaith = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtIntelligence = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDexterity = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtStrength = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEndurance = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAttunement = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtVigor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSoulMemory = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSouls = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMaxStam = New System.Windows.Forms.TextBox()
        Me.txtCurrStam = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMaxFp = New System.Windows.Forms.TextBox()
        Me.txtCurrFp = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMaxHp = New System.Windows.Forms.TextBox()
        Me.txtCurrHp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTimesSuccessful = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtTimesSummoned = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.tabs.SuspendLayout()
        Me.tabStats.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabs
        '
        Me.tabs.Controls.Add(Me.tabStats)
        Me.tabs.Location = New System.Drawing.Point(13, 13)
        Me.tabs.Name = "tabs"
        Me.tabs.SelectedIndex = 0
        Me.tabs.Size = New System.Drawing.Size(527, 476)
        Me.tabs.TabIndex = 0
        '
        'tabStats
        '
        Me.tabStats.Controls.Add(Me.txtTimesSuccessful)
        Me.tabStats.Controls.Add(Me.Label22)
        Me.tabStats.Controls.Add(Me.txtTimesSummoned)
        Me.tabStats.Controls.Add(Me.Label23)
        Me.tabStats.Controls.Add(Me.txtZPos)
        Me.tabStats.Controls.Add(Me.Label19)
        Me.tabStats.Controls.Add(Me.txtYPos)
        Me.tabStats.Controls.Add(Me.Label20)
        Me.tabStats.Controls.Add(Me.txtXPos)
        Me.tabStats.Controls.Add(Me.Label21)
        Me.tabStats.Controls.Add(Me.chkMale)
        Me.tabStats.Controls.Add(Me.chkEmbered)
        Me.tabStats.Controls.Add(Me.txtCovenant)
        Me.tabStats.Controls.Add(Me.Label18)
        Me.tabStats.Controls.Add(Me.txtDeaths)
        Me.tabStats.Controls.Add(Me.Label16)
        Me.tabStats.Controls.Add(Me.txtTimePlayed)
        Me.tabStats.Controls.Add(Me.Label17)
        Me.tabStats.Controls.Add(Me.lblVersion)
        Me.tabStats.Controls.Add(Me.hsLLeg)
        Me.tabStats.Controls.Add(Me.hsLArm)
        Me.tabStats.Controls.Add(Me.hsRLeg)
        Me.tabStats.Controls.Add(Me.hsRArm)
        Me.tabStats.Controls.Add(Me.hsHips)
        Me.tabStats.Controls.Add(Me.hsChest)
        Me.tabStats.Controls.Add(Me.hsHead)
        Me.tabStats.Controls.Add(Me.chkHideMap)
        Me.tabStats.Controls.Add(Me.txtSoulLevel)
        Me.tabStats.Controls.Add(Me.Label15)
        Me.tabStats.Controls.Add(Me.txtVitality)
        Me.tabStats.Controls.Add(Me.Label14)
        Me.tabStats.Controls.Add(Me.txtLuck)
        Me.tabStats.Controls.Add(Me.Label10)
        Me.tabStats.Controls.Add(Me.txtFaith)
        Me.tabStats.Controls.Add(Me.Label11)
        Me.tabStats.Controls.Add(Me.txtIntelligence)
        Me.tabStats.Controls.Add(Me.Label12)
        Me.tabStats.Controls.Add(Me.txtDexterity)
        Me.tabStats.Controls.Add(Me.Label13)
        Me.tabStats.Controls.Add(Me.txtStrength)
        Me.tabStats.Controls.Add(Me.Label8)
        Me.tabStats.Controls.Add(Me.txtEndurance)
        Me.tabStats.Controls.Add(Me.Label9)
        Me.tabStats.Controls.Add(Me.txtAttunement)
        Me.tabStats.Controls.Add(Me.Label7)
        Me.tabStats.Controls.Add(Me.txtVigor)
        Me.tabStats.Controls.Add(Me.Label6)
        Me.tabStats.Controls.Add(Me.txtSoulMemory)
        Me.tabStats.Controls.Add(Me.Label5)
        Me.tabStats.Controls.Add(Me.txtSouls)
        Me.tabStats.Controls.Add(Me.Label4)
        Me.tabStats.Controls.Add(Me.txtMaxStam)
        Me.tabStats.Controls.Add(Me.txtCurrStam)
        Me.tabStats.Controls.Add(Me.Label3)
        Me.tabStats.Controls.Add(Me.txtMaxFp)
        Me.tabStats.Controls.Add(Me.txtCurrFp)
        Me.tabStats.Controls.Add(Me.Label2)
        Me.tabStats.Controls.Add(Me.txtMaxHp)
        Me.tabStats.Controls.Add(Me.txtCurrHp)
        Me.tabStats.Controls.Add(Me.Label1)
        Me.tabStats.Location = New System.Drawing.Point(4, 22)
        Me.tabStats.Name = "tabStats"
        Me.tabStats.Padding = New System.Windows.Forms.Padding(3)
        Me.tabStats.Size = New System.Drawing.Size(519, 450)
        Me.tabStats.TabIndex = 0
        Me.tabStats.Text = "Stats"
        Me.tabStats.UseVisualStyleBackColor = True
        '
        'txtZPos
        '
        Me.txtZPos.Location = New System.Drawing.Point(77, 401)
        Me.txtZPos.Name = "txtZPos"
        Me.txtZPos.Size = New System.Drawing.Size(57, 20)
        Me.txtZPos.TabIndex = 55
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(36, 404)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(35, 13)
        Me.Label19.TabIndex = 54
        Me.Label19.Text = "Z Pos"
        '
        'txtYPos
        '
        Me.txtYPos.Location = New System.Drawing.Point(77, 380)
        Me.txtYPos.Name = "txtYPos"
        Me.txtYPos.Size = New System.Drawing.Size(57, 20)
        Me.txtYPos.TabIndex = 53
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(36, 383)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(35, 13)
        Me.Label20.TabIndex = 52
        Me.Label20.Text = "Y Pos"
        '
        'txtXPos
        '
        Me.txtXPos.Location = New System.Drawing.Point(77, 359)
        Me.txtXPos.Name = "txtXPos"
        Me.txtXPos.Size = New System.Drawing.Size(57, 20)
        Me.txtXPos.TabIndex = 51
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(36, 362)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(35, 13)
        Me.Label21.TabIndex = 50
        Me.Label21.Text = "X Pos"
        '
        'chkMale
        '
        Me.chkMale.AutoSize = True
        Me.chkMale.Location = New System.Drawing.Point(391, 141)
        Me.chkMale.Name = "chkMale"
        Me.chkMale.Size = New System.Drawing.Size(49, 17)
        Me.chkMale.TabIndex = 49
        Me.chkMale.Text = "Male"
        Me.chkMale.UseVisualStyleBackColor = True
        '
        'chkEmbered
        '
        Me.chkEmbered.AutoSize = True
        Me.chkEmbered.Location = New System.Drawing.Point(391, 120)
        Me.chkEmbered.Name = "chkEmbered"
        Me.chkEmbered.Size = New System.Drawing.Size(68, 17)
        Me.chkEmbered.TabIndex = 48
        Me.chkEmbered.Text = "Embered"
        Me.chkEmbered.UseVisualStyleBackColor = True
        '
        'txtCovenant
        '
        Me.txtCovenant.Location = New System.Drawing.Point(231, 265)
        Me.txtCovenant.Name = "txtCovenant"
        Me.txtCovenant.Size = New System.Drawing.Size(127, 20)
        Me.txtCovenant.TabIndex = 47
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(172, 268)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(53, 13)
        Me.Label18.TabIndex = 46
        Me.Label18.Text = "Covenant"
        '
        'txtDeaths
        '
        Me.txtDeaths.Location = New System.Drawing.Point(231, 202)
        Me.txtDeaths.Name = "txtDeaths"
        Me.txtDeaths.Size = New System.Drawing.Size(57, 20)
        Me.txtDeaths.TabIndex = 45
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(184, 205)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(41, 13)
        Me.Label16.TabIndex = 44
        Me.Label16.Text = "Deaths"
        '
        'txtTimePlayed
        '
        Me.txtTimePlayed.Location = New System.Drawing.Point(231, 223)
        Me.txtTimePlayed.Name = "txtTimePlayed"
        Me.txtTimePlayed.Size = New System.Drawing.Size(99, 20)
        Me.txtTimePlayed.TabIndex = 43
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(160, 226)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 13)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "Time Played"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(437, 428)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(76, 13)
        Me.lblVersion.TabIndex = 41
        Me.lblVersion.Text = "2016-04-18-22"
        '
        'hsLLeg
        '
        Me.hsLLeg.Location = New System.Drawing.Point(231, 69)
        Me.hsLLeg.Name = "hsLLeg"
        Me.hsLLeg.Size = New System.Drawing.Size(80, 17)
        Me.hsLLeg.TabIndex = 40
        Me.hsLLeg.Value = 50
        '
        'hsLArm
        '
        Me.hsLArm.Location = New System.Drawing.Point(231, 35)
        Me.hsLArm.Name = "hsLArm"
        Me.hsLArm.Size = New System.Drawing.Size(80, 17)
        Me.hsLArm.TabIndex = 39
        Me.hsLArm.Value = 50
        '
        'hsRLeg
        '
        Me.hsRLeg.Location = New System.Drawing.Point(391, 69)
        Me.hsRLeg.Name = "hsRLeg"
        Me.hsRLeg.Size = New System.Drawing.Size(80, 17)
        Me.hsRLeg.TabIndex = 38
        Me.hsRLeg.Value = 50
        '
        'hsRArm
        '
        Me.hsRArm.Location = New System.Drawing.Point(391, 35)
        Me.hsRArm.Name = "hsRArm"
        Me.hsRArm.Size = New System.Drawing.Size(80, 17)
        Me.hsRArm.TabIndex = 37
        Me.hsRArm.Value = 50
        '
        'hsHips
        '
        Me.hsHips.Location = New System.Drawing.Point(311, 52)
        Me.hsHips.Name = "hsHips"
        Me.hsHips.Size = New System.Drawing.Size(80, 17)
        Me.hsHips.TabIndex = 36
        Me.hsHips.Value = 50
        '
        'hsChest
        '
        Me.hsChest.Location = New System.Drawing.Point(311, 35)
        Me.hsChest.Name = "hsChest"
        Me.hsChest.Size = New System.Drawing.Size(80, 17)
        Me.hsChest.TabIndex = 35
        Me.hsChest.Value = 50
        '
        'hsHead
        '
        Me.hsHead.Location = New System.Drawing.Point(311, 18)
        Me.hsHead.Name = "hsHead"
        Me.hsHead.Size = New System.Drawing.Size(80, 17)
        Me.hsHead.TabIndex = 34
        Me.hsHead.Value = 50
        '
        'chkHideMap
        '
        Me.chkHideMap.AutoSize = True
        Me.chkHideMap.Location = New System.Drawing.Point(13, 427)
        Me.chkHideMap.Name = "chkHideMap"
        Me.chkHideMap.Size = New System.Drawing.Size(103, 17)
        Me.chkHideMap.TabIndex = 33
        Me.chkHideMap.Text = "Don't Draw Map"
        Me.chkHideMap.UseVisualStyleBackColor = True
        '
        'txtSoulLevel
        '
        Me.txtSoulLevel.Location = New System.Drawing.Point(231, 118)
        Me.txtSoulLevel.Name = "txtSoulLevel"
        Me.txtSoulLevel.Size = New System.Drawing.Size(57, 20)
        Me.txtSoulLevel.TabIndex = 32
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(168, 121)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 13)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Soul Level"
        '
        'txtVitality
        '
        Me.txtVitality.Location = New System.Drawing.Point(77, 265)
        Me.txtVitality.Name = "txtVitality"
        Me.txtVitality.Size = New System.Drawing.Size(57, 20)
        Me.txtVitality.TabIndex = 30
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(34, 268)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 13)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Vitality"
        '
        'txtLuck
        '
        Me.txtLuck.Location = New System.Drawing.Point(77, 244)
        Me.txtLuck.Name = "txtLuck"
        Me.txtLuck.Size = New System.Drawing.Size(57, 20)
        Me.txtLuck.TabIndex = 28
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(40, 247)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Luck"
        '
        'txtFaith
        '
        Me.txtFaith.Location = New System.Drawing.Point(77, 223)
        Me.txtFaith.Name = "txtFaith"
        Me.txtFaith.Size = New System.Drawing.Size(57, 20)
        Me.txtFaith.TabIndex = 26
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(41, 226)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 13)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Faith"
        '
        'txtIntelligence
        '
        Me.txtIntelligence.Location = New System.Drawing.Point(77, 202)
        Me.txtIntelligence.Name = "txtIntelligence"
        Me.txtIntelligence.Size = New System.Drawing.Size(57, 20)
        Me.txtIntelligence.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 205)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Intelligence"
        '
        'txtDexterity
        '
        Me.txtDexterity.Location = New System.Drawing.Point(77, 181)
        Me.txtDexterity.Name = "txtDexterity"
        Me.txtDexterity.Size = New System.Drawing.Size(57, 20)
        Me.txtDexterity.TabIndex = 22
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(23, 184)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Dexterity"
        '
        'txtStrength
        '
        Me.txtStrength.Location = New System.Drawing.Point(77, 160)
        Me.txtStrength.Name = "txtStrength"
        Me.txtStrength.Size = New System.Drawing.Size(57, 20)
        Me.txtStrength.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Strength"
        '
        'txtEndurance
        '
        Me.txtEndurance.Location = New System.Drawing.Point(77, 139)
        Me.txtEndurance.Name = "txtEndurance"
        Me.txtEndurance.Size = New System.Drawing.Size(57, 20)
        Me.txtEndurance.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 142)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Endurance"
        '
        'txtAttunement
        '
        Me.txtAttunement.Location = New System.Drawing.Point(77, 118)
        Me.txtAttunement.Name = "txtAttunement"
        Me.txtAttunement.Size = New System.Drawing.Size(57, 20)
        Me.txtAttunement.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Attunement"
        '
        'txtVigor
        '
        Me.txtVigor.Location = New System.Drawing.Point(77, 97)
        Me.txtVigor.Name = "txtVigor"
        Me.txtVigor.Size = New System.Drawing.Size(57, 20)
        Me.txtVigor.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Vigor"
        '
        'txtSoulMemory
        '
        Me.txtSoulMemory.Location = New System.Drawing.Point(231, 160)
        Me.txtSoulMemory.Name = "txtSoulMemory"
        Me.txtSoulMemory.Size = New System.Drawing.Size(99, 20)
        Me.txtSoulMemory.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(157, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Soul Memory"
        '
        'txtSouls
        '
        Me.txtSouls.Location = New System.Drawing.Point(231, 139)
        Me.txtSouls.Name = "txtSouls"
        Me.txtSouls.Size = New System.Drawing.Size(99, 20)
        Me.txtSouls.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(192, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Souls"
        '
        'txtMaxStam
        '
        Me.txtMaxStam.Location = New System.Drawing.Point(140, 57)
        Me.txtMaxStam.Name = "txtMaxStam"
        Me.txtMaxStam.Size = New System.Drawing.Size(57, 20)
        Me.txtMaxStam.TabIndex = 8
        '
        'txtCurrStam
        '
        Me.txtCurrStam.Location = New System.Drawing.Point(77, 57)
        Me.txtCurrStam.Name = "txtCurrStam"
        Me.txtCurrStam.Size = New System.Drawing.Size(57, 20)
        Me.txtCurrStam.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Stamina"
        '
        'txtMaxFp
        '
        Me.txtMaxFp.Location = New System.Drawing.Point(140, 36)
        Me.txtMaxFp.Name = "txtMaxFp"
        Me.txtMaxFp.Size = New System.Drawing.Size(57, 20)
        Me.txtMaxFp.TabIndex = 5
        '
        'txtCurrFp
        '
        Me.txtCurrFp.Location = New System.Drawing.Point(77, 36)
        Me.txtCurrFp.Name = "txtCurrFp"
        Me.txtCurrFp.Size = New System.Drawing.Size(57, 20)
        Me.txtCurrFp.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "FP"
        '
        'txtMaxHp
        '
        Me.txtMaxHp.Location = New System.Drawing.Point(140, 15)
        Me.txtMaxHp.Name = "txtMaxHp"
        Me.txtMaxHp.Size = New System.Drawing.Size(57, 20)
        Me.txtMaxHp.TabIndex = 2
        '
        'txtCurrHp
        '
        Me.txtCurrHp.Location = New System.Drawing.Point(77, 15)
        Me.txtCurrHp.Name = "txtCurrHp"
        Me.txtCurrHp.Size = New System.Drawing.Size(57, 20)
        Me.txtCurrHp.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "HP"
        '
        'txtTimesSuccessful
        '
        Me.txtTimesSuccessful.Location = New System.Drawing.Point(273, 401)
        Me.txtTimesSuccessful.Name = "txtTimesSuccessful"
        Me.txtTimesSuccessful.Size = New System.Drawing.Size(57, 20)
        Me.txtTimesSuccessful.TabIndex = 59
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(163, 404)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(104, 13)
        Me.Label22.TabIndex = 58
        Me.Label22.Text = "Success as summon"
        '
        'txtTimesSummoned
        '
        Me.txtTimesSummoned.Location = New System.Drawing.Point(273, 380)
        Me.txtTimesSummoned.Name = "txtTimesSummoned"
        Me.txtTimesSummoned.Size = New System.Drawing.Size(57, 20)
        Me.txtTimesSummoned.TabIndex = 57
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(199, 383)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(68, 13)
        Me.Label23.TabIndex = 56
        Me.Label23.Text = "MP Sessions"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 501)
        Me.Controls.Add(Me.tabs)
        Me.Name = "Form1"
        Me.Text = "Wulf's Dark Souls 3 Trainer"
        Me.tabs.ResumeLayout(False)
        Me.tabStats.ResumeLayout(False)
        Me.tabStats.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabs As TabControl
    Friend WithEvents tabStats As TabPage
    Friend WithEvents txtMaxStam As TextBox
    Friend WithEvents txtCurrStam As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMaxFp As TextBox
    Friend WithEvents txtCurrFp As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMaxHp As TextBox
    Friend WithEvents txtCurrHp As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSouls As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtVitality As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtLuck As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtFaith As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtIntelligence As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtDexterity As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtStrength As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEndurance As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtAttunement As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtVigor As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSoulMemory As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSoulLevel As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents chkHideMap As CheckBox
    Friend WithEvents hsLLeg As HScrollBar
    Friend WithEvents hsLArm As HScrollBar
    Friend WithEvents hsRLeg As HScrollBar
    Friend WithEvents hsRArm As HScrollBar
    Friend WithEvents hsHips As HScrollBar
    Friend WithEvents hsChest As HScrollBar
    Friend WithEvents hsHead As HScrollBar
    Friend WithEvents lblVersion As Label
    Friend WithEvents txtDeaths As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtTimePlayed As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtCovenant As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents chkMale As CheckBox
    Friend WithEvents chkEmbered As CheckBox
    Friend WithEvents txtZPos As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtYPos As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtXPos As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtTimesSuccessful As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtTimesSummoned As TextBox
    Friend WithEvents Label23 As Label
End Class
