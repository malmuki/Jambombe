<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCombat
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCombat))
        Me.AxWMPSoundSelectionEffect = New AxWMPLib.AxWindowsMediaPlayer()
        Me.picMonstre1 = New System.Windows.Forms.PictureBox()
        Me.picA1 = New System.Windows.Forms.PictureBox()
        Me.lblCourrir = New System.Windows.Forms.Label()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.picMain = New System.Windows.Forms.PictureBox()
        Me.lblDefense = New System.Windows.Forms.Label()
        Me.lblAttaque = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.picBackgroundSelection = New System.Windows.Forms.PictureBox()
        Me.picBackground = New System.Windows.Forms.PictureBox()
        Me.tmrAttaque = New System.Windows.Forms.Timer(Me.components)
        Me.picA2 = New System.Windows.Forms.PictureBox()
        Me.picA3 = New System.Windows.Forms.PictureBox()
        Me.picA4 = New System.Windows.Forms.PictureBox()
        Me.picA5 = New System.Windows.Forms.PictureBox()
        Me.picA6 = New System.Windows.Forms.PictureBox()
        Me.picA7 = New System.Windows.Forms.PictureBox()
        Me.picMonstre2 = New System.Windows.Forms.PictureBox()
        Me.tmrTour = New System.Windows.Forms.Timer(Me.components)
        Me.lblHeroHP = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tmrMonstre1Atk = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMonstre1Tour = New System.Windows.Forms.Timer(Me.components)
        Me.AxWMPSoundEffect = New AxWMPLib.AxWindowsMediaPlayer()
        Me.picATBTop = New System.Windows.Forms.PictureBox()
        Me.picATBMove = New System.Windows.Forms.PictureBox()
        Me.picATBBottom = New System.Windows.Forms.PictureBox()
        Me.picATBRight = New System.Windows.Forms.PictureBox()
        Me.picATBLeft = New System.Windows.Forms.PictureBox()
        Me.lblPause = New System.Windows.Forms.Label()
        Me.pnlExp = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblOk = New System.Windows.Forms.Label()
        Me.lblExperienceTitre = New System.Windows.Forms.Label()
        Me.tmrCombat = New System.Windows.Forms.Timer(Me.components)
        Me.lblExpGain = New System.Windows.Forms.Label()
        Me.lblHeroDmg = New System.Windows.Forms.Label()
        Me.lblMnstrDmg = New System.Windows.Forms.Label()
        CType(Me.AxWMPSoundSelectionEffect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMonstre1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picA1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBackgroundSelection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picA2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picA3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picA4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picA5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picA6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picA7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMonstre2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWMPSoundEffect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picATBTop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picATBMove, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picATBBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picATBRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picATBLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlExp.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxWMPSoundSelectionEffect
        '
        Me.AxWMPSoundSelectionEffect.Enabled = True
        Me.AxWMPSoundSelectionEffect.Location = New System.Drawing.Point(546, 26)
        Me.AxWMPSoundSelectionEffect.Name = "AxWMPSoundSelectionEffect"
        Me.AxWMPSoundSelectionEffect.OcxState = CType(resources.GetObject("AxWMPSoundSelectionEffect.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWMPSoundSelectionEffect.Size = New System.Drawing.Size(78, 54)
        Me.AxWMPSoundSelectionEffect.TabIndex = 18
        Me.AxWMPSoundSelectionEffect.Visible = False
        '
        'picMonstre1
        '
        Me.picMonstre1.BackColor = System.Drawing.Color.Transparent
        Me.picMonstre1.Image = Global.XNADrawingTest.My.Resources.Resources.asludge
        Me.picMonstre1.Location = New System.Drawing.Point(155, 155)
        Me.picMonstre1.Name = "picMonstre1"
        Me.picMonstre1.Size = New System.Drawing.Size(89, 88)
        Me.picMonstre1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMonstre1.TabIndex = 22
        Me.picMonstre1.TabStop = False
        '
        'picA1
        '
        Me.picA1.BackColor = System.Drawing.Color.Transparent
        Me.picA1.Image = Global.XNADrawingTest.My.Resources.Resources.attack1
        Me.picA1.Location = New System.Drawing.Point(632, 275)
        Me.picA1.Name = "picA1"
        Me.picA1.Size = New System.Drawing.Size(50, 74)
        Me.picA1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picA1.TabIndex = 23
        Me.picA1.TabStop = False
        '
        'lblCourrir
        '
        Me.lblCourrir.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.lblCourrir.Enabled = False
        Me.lblCourrir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourrir.ForeColor = System.Drawing.Color.White
        Me.lblCourrir.Location = New System.Drawing.Point(266, 551)
        Me.lblCourrir.Name = "lblCourrir"
        Me.lblCourrir.Size = New System.Drawing.Size(78, 24)
        Me.lblCourrir.TabIndex = 26
        Me.lblCourrir.Text = "Courrir"
        '
        'lblItem
        '
        Me.lblItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.lblItem.Enabled = False
        Me.lblItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItem.ForeColor = System.Drawing.Color.White
        Me.lblItem.Location = New System.Drawing.Point(266, 527)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(78, 24)
        Me.lblItem.TabIndex = 25
        Me.lblItem.Text = "Item"
        '
        'picMain
        '
        Me.picMain.Image = Global.XNADrawingTest.My.Resources.Resources.Main
        Me.picMain.Location = New System.Drawing.Point(224, 479)
        Me.picMain.Name = "picMain"
        Me.picMain.Size = New System.Drawing.Size(36, 24)
        Me.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMain.TabIndex = 27
        Me.picMain.TabStop = False
        Me.picMain.Visible = False
        '
        'lblDefense
        '
        Me.lblDefense.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.lblDefense.Enabled = False
        Me.lblDefense.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDefense.ForeColor = System.Drawing.Color.White
        Me.lblDefense.Location = New System.Drawing.Point(266, 503)
        Me.lblDefense.Name = "lblDefense"
        Me.lblDefense.Size = New System.Drawing.Size(78, 24)
        Me.lblDefense.TabIndex = 24
        Me.lblDefense.Text = "Défense"
        '
        'lblAttaque
        '
        Me.lblAttaque.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.lblAttaque.Enabled = False
        Me.lblAttaque.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAttaque.ForeColor = System.Drawing.Color.White
        Me.lblAttaque.Location = New System.Drawing.Point(266, 479)
        Me.lblAttaque.Name = "lblAttaque"
        Me.lblAttaque.Size = New System.Drawing.Size(78, 24)
        Me.lblAttaque.TabIndex = 21
        Me.lblAttaque.Text = "Attaque"
        '
        'lblNom
        '
        Me.lblNom.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.lblNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.ForeColor = System.Drawing.Color.White
        Me.lblNom.Location = New System.Drawing.Point(34, 479)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(116, 24)
        Me.lblNom.TabIndex = 28
        Me.lblNom.Text = "Nick"
        '
        'picBackgroundSelection
        '
        Me.picBackgroundSelection.Image = Global.XNADrawingTest.My.Resources.Resources.contour1
        Me.picBackgroundSelection.Location = New System.Drawing.Point(0, 450)
        Me.picBackgroundSelection.Name = "picBackgroundSelection"
        Me.picBackgroundSelection.Size = New System.Drawing.Size(800, 150)
        Me.picBackgroundSelection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBackgroundSelection.TabIndex = 29
        Me.picBackgroundSelection.TabStop = False
        '
        'picBackground
        '
        Me.picBackground.BackColor = System.Drawing.Color.Transparent
        Me.picBackground.Image = Global.XNADrawingTest.My.Resources.Resources.fight2
        Me.picBackground.Location = New System.Drawing.Point(-2, -2)
        Me.picBackground.Name = "picBackground"
        Me.picBackground.Size = New System.Drawing.Size(45, 68)
        Me.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBackground.TabIndex = 30
        Me.picBackground.TabStop = False
        '
        'tmrAttaque
        '
        '
        'picA2
        '
        Me.picA2.BackColor = System.Drawing.Color.Transparent
        Me.picA2.Image = Global.XNADrawingTest.My.Resources.Resources.attack2
        Me.picA2.Location = New System.Drawing.Point(632, 293)
        Me.picA2.Name = "picA2"
        Me.picA2.Size = New System.Drawing.Size(76, 56)
        Me.picA2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picA2.TabIndex = 31
        Me.picA2.TabStop = False
        Me.picA2.Visible = False
        '
        'picA3
        '
        Me.picA3.BackColor = System.Drawing.Color.Transparent
        Me.picA3.Image = Global.XNADrawingTest.My.Resources.Resources.attack3
        Me.picA3.Location = New System.Drawing.Point(632, 293)
        Me.picA3.Name = "picA3"
        Me.picA3.Size = New System.Drawing.Size(66, 56)
        Me.picA3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picA3.TabIndex = 32
        Me.picA3.TabStop = False
        Me.picA3.Visible = False
        '
        'picA4
        '
        Me.picA4.BackColor = System.Drawing.Color.Transparent
        Me.picA4.Image = Global.XNADrawingTest.My.Resources.Resources.attack4
        Me.picA4.Location = New System.Drawing.Point(456, 240)
        Me.picA4.Name = "picA4"
        Me.picA4.Size = New System.Drawing.Size(76, 64)
        Me.picA4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picA4.TabIndex = 33
        Me.picA4.TabStop = False
        Me.picA4.Visible = False
        '
        'picA5
        '
        Me.picA5.BackColor = System.Drawing.Color.Transparent
        Me.picA5.Image = Global.XNADrawingTest.My.Resources.Resources.attack5
        Me.picA5.Location = New System.Drawing.Point(282, 161)
        Me.picA5.Name = "picA5"
        Me.picA5.Size = New System.Drawing.Size(52, 64)
        Me.picA5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picA5.TabIndex = 34
        Me.picA5.TabStop = False
        Me.picA5.Visible = False
        '
        'picA6
        '
        Me.picA6.BackColor = System.Drawing.Color.Transparent
        Me.picA6.Image = Global.XNADrawingTest.My.Resources.Resources.attack6
        Me.picA6.Location = New System.Drawing.Point(244, 129)
        Me.picA6.Name = "picA6"
        Me.picA6.Size = New System.Drawing.Size(90, 96)
        Me.picA6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picA6.TabIndex = 35
        Me.picA6.TabStop = False
        Me.picA6.Visible = False
        '
        'picA7
        '
        Me.picA7.BackColor = System.Drawing.Color.Transparent
        Me.picA7.Image = Global.XNADrawingTest.My.Resources.Resources.attack7
        Me.picA7.Location = New System.Drawing.Point(244, 129)
        Me.picA7.Name = "picA7"
        Me.picA7.Size = New System.Drawing.Size(90, 96)
        Me.picA7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picA7.TabIndex = 36
        Me.picA7.TabStop = False
        Me.picA7.Visible = False
        '
        'picMonstre2
        '
        Me.picMonstre2.BackColor = System.Drawing.Color.Transparent
        Me.picMonstre2.Image = Global.XNADrawingTest.My.Resources.Resources.ggonghed
        Me.picMonstre2.Location = New System.Drawing.Point(156, 240)
        Me.picMonstre2.Name = "picMonstre2"
        Me.picMonstre2.Size = New System.Drawing.Size(73, 98)
        Me.picMonstre2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMonstre2.TabIndex = 37
        Me.picMonstre2.TabStop = False
        Me.picMonstre2.Visible = False
        '
        'tmrTour
        '
        Me.tmrTour.Enabled = True
        Me.tmrTour.Interval = 20
        '
        'lblHeroHP
        '
        Me.lblHeroHP.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.lblHeroHP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeroHP.ForeColor = System.Drawing.Color.White
        Me.lblHeroHP.Location = New System.Drawing.Point(441, 503)
        Me.lblHeroHP.Name = "lblHeroHP"
        Me.lblHeroHP.Size = New System.Drawing.Size(111, 24)
        Me.lblHeroHP.TabIndex = 38
        Me.lblHeroHP.Text = "3000/3000"
        Me.lblHeroHP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(441, 479)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 24)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Point de Vie"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tmrMonstre1Atk
        '
        Me.tmrMonstre1Atk.Interval = 150
        '
        'tmrMonstre1Tour
        '
        Me.tmrMonstre1Tour.Interval = 1200
        '
        'AxWMPSoundEffect
        '
        Me.AxWMPSoundEffect.Enabled = True
        Me.AxWMPSoundEffect.Location = New System.Drawing.Point(629, 26)
        Me.AxWMPSoundEffect.Name = "AxWMPSoundEffect"
        Me.AxWMPSoundEffect.OcxState = CType(resources.GetObject("AxWMPSoundEffect.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWMPSoundEffect.Size = New System.Drawing.Size(78, 54)
        Me.AxWMPSoundEffect.TabIndex = 41
        Me.AxWMPSoundEffect.Visible = False
        '
        'picATBTop
        '
        Me.picATBTop.Image = Global.XNADrawingTest.My.Resources.Resources.contourATBhaut
        Me.picATBTop.Location = New System.Drawing.Point(610, 479)
        Me.picATBTop.Name = "picATBTop"
        Me.picATBTop.Size = New System.Drawing.Size(138, 8)
        Me.picATBTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picATBTop.TabIndex = 42
        Me.picATBTop.TabStop = False
        '
        'picATBMove
        '
        Me.picATBMove.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.picATBMove.Location = New System.Drawing.Point(616, 487)
        Me.picATBMove.Name = "picATBMove"
        Me.picATBMove.Size = New System.Drawing.Size(0, 14)
        Me.picATBMove.TabIndex = 43
        Me.picATBMove.TabStop = False
        '
        'picATBBottom
        '
        Me.picATBBottom.Image = Global.XNADrawingTest.My.Resources.Resources.contourATBbas
        Me.picATBBottom.Location = New System.Drawing.Point(610, 501)
        Me.picATBBottom.Name = "picATBBottom"
        Me.picATBBottom.Size = New System.Drawing.Size(138, 8)
        Me.picATBBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picATBBottom.TabIndex = 44
        Me.picATBBottom.TabStop = False
        '
        'picATBRight
        '
        Me.picATBRight.Image = Global.XNADrawingTest.My.Resources.Resources.contourATBdroit
        Me.picATBRight.Location = New System.Drawing.Point(747, 479)
        Me.picATBRight.Name = "picATBRight"
        Me.picATBRight.Size = New System.Drawing.Size(6, 30)
        Me.picATBRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picATBRight.TabIndex = 45
        Me.picATBRight.TabStop = False
        '
        'picATBLeft
        '
        Me.picATBLeft.Image = Global.XNADrawingTest.My.Resources.Resources.contourATBgauche
        Me.picATBLeft.Location = New System.Drawing.Point(610, 479)
        Me.picATBLeft.Name = "picATBLeft"
        Me.picATBLeft.Size = New System.Drawing.Size(6, 30)
        Me.picATBLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picATBLeft.TabIndex = 46
        Me.picATBLeft.TabStop = False
        '
        'lblPause
        '
        Me.lblPause.BackColor = System.Drawing.Color.Transparent
        Me.lblPause.Enabled = False
        Me.lblPause.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPause.ForeColor = System.Drawing.Color.White
        Me.lblPause.Location = New System.Drawing.Point(350, 200)
        Me.lblPause.Name = "lblPause"
        Me.lblPause.Size = New System.Drawing.Size(100, 50)
        Me.lblPause.TabIndex = 47
        Me.lblPause.Text = "Pause"
        Me.lblPause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPause.Visible = False
        '
        'pnlExp
        '
        Me.pnlExp.BackgroundImage = Global.XNADrawingTest.My.Resources.Resources.border
        Me.pnlExp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlExp.Controls.Add(Me.lblExpGain)
        Me.pnlExp.Controls.Add(Me.PictureBox1)
        Me.pnlExp.Controls.Add(Me.lblOk)
        Me.pnlExp.Controls.Add(Me.lblExperienceTitre)
        Me.pnlExp.Location = New System.Drawing.Point(0, 0)
        Me.pnlExp.Name = "pnlExp"
        Me.pnlExp.Size = New System.Drawing.Size(800, 600)
        Me.pnlExp.TabIndex = 48
        Me.pnlExp.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.XNADrawingTest.My.Resources.Resources.Main
        Me.PictureBox1.Location = New System.Drawing.Point(648, 530)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'lblOk
        '
        Me.lblOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.lblOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblOk.Location = New System.Drawing.Point(690, 523)
        Me.lblOk.Name = "lblOk"
        Me.lblOk.Size = New System.Drawing.Size(51, 31)
        Me.lblOk.TabIndex = 23
        Me.lblOk.Text = "OK"
        Me.lblOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblOk.UseCompatibleTextRendering = True
        '
        'lblExperienceTitre
        '
        Me.lblExperienceTitre.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.lblExperienceTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExperienceTitre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblExperienceTitre.Location = New System.Drawing.Point(13, 26)
        Me.lblExperienceTitre.Name = "lblExperienceTitre"
        Me.lblExperienceTitre.Size = New System.Drawing.Size(102, 24)
        Me.lblExperienceTitre.TabIndex = 22
        Me.lblExperienceTitre.Text = "Expérience:"
        Me.lblExperienceTitre.UseCompatibleTextRendering = True
        '
        'tmrCombat
        '
        Me.tmrCombat.Enabled = True
        Me.tmrCombat.Interval = 1
        '
        'lblExpGain
        '
        Me.lblExpGain.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.lblExpGain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpGain.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblExpGain.Location = New System.Drawing.Point(121, 26)
        Me.lblExpGain.Name = "lblExpGain"
        Me.lblExpGain.Size = New System.Drawing.Size(102, 24)
        Me.lblExpGain.TabIndex = 29
        Me.lblExpGain.Text = "10"
        Me.lblExpGain.UseCompatibleTextRendering = True
        '
        'lblHeroDmg
        '
        Me.lblHeroDmg.BackColor = System.Drawing.Color.Transparent
        Me.lblHeroDmg.Enabled = False
        Me.lblHeroDmg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeroDmg.ForeColor = System.Drawing.Color.White
        Me.lblHeroDmg.Location = New System.Drawing.Point(160, 128)
        Me.lblHeroDmg.Name = "lblHeroDmg"
        Me.lblHeroDmg.Size = New System.Drawing.Size(78, 24)
        Me.lblHeroDmg.TabIndex = 49
        '
        'lblMnstrDmg
        '
        Me.lblMnstrDmg.BackColor = System.Drawing.Color.Transparent
        Me.lblMnstrDmg.Enabled = False
        Me.lblMnstrDmg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMnstrDmg.ForeColor = System.Drawing.Color.White
        Me.lblMnstrDmg.Location = New System.Drawing.Point(625, 240)
        Me.lblMnstrDmg.Name = "lblMnstrDmg"
        Me.lblMnstrDmg.Size = New System.Drawing.Size(78, 24)
        Me.lblMnstrDmg.TabIndex = 50
        '
        'frmCombat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BackgroundImage = Global.XNADrawingTest.My.Resources.Resources.fight2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.pnlExp)
        Me.Controls.Add(Me.lblMnstrDmg)
        Me.Controls.Add(Me.lblHeroDmg)
        Me.Controls.Add(Me.lblPause)
        Me.Controls.Add(Me.picATBLeft)
        Me.Controls.Add(Me.picATBRight)
        Me.Controls.Add(Me.picATBBottom)
        Me.Controls.Add(Me.picATBMove)
        Me.Controls.Add(Me.picATBTop)
        Me.Controls.Add(Me.AxWMPSoundEffect)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblHeroHP)
        Me.Controls.Add(Me.picMonstre2)
        Me.Controls.Add(Me.picA7)
        Me.Controls.Add(Me.picA6)
        Me.Controls.Add(Me.picA5)
        Me.Controls.Add(Me.picA4)
        Me.Controls.Add(Me.picA3)
        Me.Controls.Add(Me.picA2)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.lblAttaque)
        Me.Controls.Add(Me.lblDefense)
        Me.Controls.Add(Me.picA1)
        Me.Controls.Add(Me.picMain)
        Me.Controls.Add(Me.picMonstre1)
        Me.Controls.Add(Me.lblItem)
        Me.Controls.Add(Me.AxWMPSoundSelectionEffect)
        Me.Controls.Add(Me.lblCourrir)
        Me.Controls.Add(Me.picBackgroundSelection)
        Me.Controls.Add(Me.picBackground)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "frmCombat"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jam Bombe"
        CType(Me.AxWMPSoundSelectionEffect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMonstre1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picA1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBackgroundSelection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picA2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picA3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picA4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picA5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picA6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picA7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMonstre2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWMPSoundEffect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picATBTop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picATBMove, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picATBBottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picATBRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picATBLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlExp.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AxWMPSoundSelectionEffect As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents picMonstre1 As System.Windows.Forms.PictureBox
    Friend WithEvents picA1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblCourrir As System.Windows.Forms.Label
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents picMain As System.Windows.Forms.PictureBox
    Friend WithEvents lblDefense As System.Windows.Forms.Label
    Friend WithEvents lblAttaque As System.Windows.Forms.Label
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents picBackgroundSelection As System.Windows.Forms.PictureBox
    Friend WithEvents picBackground As System.Windows.Forms.PictureBox
    Friend WithEvents tmrAttaque As System.Windows.Forms.Timer
    Friend WithEvents picA2 As System.Windows.Forms.PictureBox
    Friend WithEvents picA3 As System.Windows.Forms.PictureBox
    Friend WithEvents picA4 As System.Windows.Forms.PictureBox
    Friend WithEvents picA5 As System.Windows.Forms.PictureBox
    Friend WithEvents picA6 As System.Windows.Forms.PictureBox
    Friend WithEvents picA7 As System.Windows.Forms.PictureBox
    Friend WithEvents picMonstre2 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrTour As System.Windows.Forms.Timer
    Friend WithEvents lblHeroHP As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tmrMonstre1Atk As System.Windows.Forms.Timer
    Friend WithEvents tmrMonstre1Tour As System.Windows.Forms.Timer
    Friend WithEvents AxWMPSoundEffect As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents picATBTop As System.Windows.Forms.PictureBox
    Friend WithEvents picATBMove As System.Windows.Forms.PictureBox
    Friend WithEvents picATBBottom As System.Windows.Forms.PictureBox
    Friend WithEvents picATBRight As System.Windows.Forms.PictureBox
    Friend WithEvents picATBLeft As System.Windows.Forms.PictureBox
    Friend WithEvents lblPause As System.Windows.Forms.Label
    Friend WithEvents pnlExp As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblOk As System.Windows.Forms.Label
    Friend WithEvents lblExperienceTitre As System.Windows.Forms.Label
    Friend WithEvents tmrCombat As System.Windows.Forms.Timer
    Friend WithEvents lblExpGain As System.Windows.Forms.Label
    Friend WithEvents lblHeroDmg As System.Windows.Forms.Label
    Friend WithEvents lblMnstrDmg As System.Windows.Forms.Label
End Class
