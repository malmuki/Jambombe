<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIntro
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIntro))
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.lblQuitter = New System.Windows.Forms.Label()
        Me.lblOptions = New System.Windows.Forms.Label()
        Me.lblCommencer = New System.Windows.Forms.Label()
        Me.pnlOptions = New System.Windows.Forms.Panel()
        Me.trbVolume = New System.Windows.Forms.TrackBar()
        Me.lblVolValue = New System.Windows.Forms.Label()
        Me.lblVolume = New System.Windows.Forms.Label()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblValSaut = New System.Windows.Forms.Label()
        Me.lblSaut = New System.Windows.Forms.Label()
        Me.lblBinding = New System.Windows.Forms.Label()
        Me.lblValDroit = New System.Windows.Forms.Label()
        Me.lblValGauche = New System.Windows.Forms.Label()
        Me.lblValBas = New System.Windows.Forms.Label()
        Me.lblDroit = New System.Windows.Forms.Label()
        Me.lblGauche = New System.Windows.Forms.Label()
        Me.lblBas = New System.Windows.Forms.Label()
        Me.lblValHaut = New System.Windows.Forms.Label()
        Me.lblHaut = New System.Windows.Forms.Label()
        Me.lblControles = New System.Windows.Forms.Label()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.lblResUp = New System.Windows.Forms.Label()
        Me.lblResDown = New System.Windows.Forms.Label()
        Me.lblResCurrent = New System.Windows.Forms.Label()
        Me.lblRes = New System.Windows.Forms.Label()
        Me.lblIntro = New System.Windows.Forms.Label()
        Me.tmrIntro = New System.Windows.Forms.Timer(Me.components)
        Me.lbltitre = New System.Windows.Forms.Label()
        Me.AxWMPMusic = New AxWMPLib.AxWindowsMediaPlayer()
        Me.pnlMenu.SuspendLayout()
        Me.pnlOptions.SuspendLayout()
        CType(Me.trbVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWMPMusic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.Black
        Me.pnlMenu.Controls.Add(Me.lblQuitter)
        Me.pnlMenu.Controls.Add(Me.lblOptions)
        Me.pnlMenu.Controls.Add(Me.lblCommencer)
        Me.pnlMenu.Location = New System.Drawing.Point(18, 130)
        Me.pnlMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(750, 400)
        Me.pnlMenu.TabIndex = 0
        Me.pnlMenu.Visible = False
        '
        'lblQuitter
        '
        Me.lblQuitter.BackColor = System.Drawing.Color.Black
        Me.lblQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuitter.ForeColor = System.Drawing.Color.White
        Me.lblQuitter.Location = New System.Drawing.Point(260, 280)
        Me.lblQuitter.Name = "lblQuitter"
        Me.lblQuitter.Size = New System.Drawing.Size(230, 80)
        Me.lblQuitter.TabIndex = 2
        Me.lblQuitter.Text = "Quitter"
        Me.lblQuitter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOptions
        '
        Me.lblOptions.BackColor = System.Drawing.Color.Black
        Me.lblOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOptions.ForeColor = System.Drawing.Color.White
        Me.lblOptions.Location = New System.Drawing.Point(260, 200)
        Me.lblOptions.Name = "lblOptions"
        Me.lblOptions.Size = New System.Drawing.Size(230, 80)
        Me.lblOptions.TabIndex = 1
        Me.lblOptions.Text = "Options"
        Me.lblOptions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCommencer
        '
        Me.lblCommencer.BackColor = System.Drawing.Color.Black
        Me.lblCommencer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommencer.ForeColor = System.Drawing.Color.White
        Me.lblCommencer.Location = New System.Drawing.Point(260, 120)
        Me.lblCommencer.Name = "lblCommencer"
        Me.lblCommencer.Size = New System.Drawing.Size(230, 80)
        Me.lblCommencer.TabIndex = 0
        Me.lblCommencer.Text = "Commencer"
        Me.lblCommencer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlOptions
        '
        Me.pnlOptions.BackColor = System.Drawing.Color.Black
        Me.pnlOptions.Controls.Add(Me.trbVolume)
        Me.pnlOptions.Controls.Add(Me.lblVolValue)
        Me.pnlOptions.Controls.Add(Me.lblVolume)
        Me.pnlOptions.Controls.Add(Me.btnRetour)
        Me.pnlOptions.Controls.Add(Me.btnReset)
        Me.pnlOptions.Controls.Add(Me.lblValSaut)
        Me.pnlOptions.Controls.Add(Me.lblSaut)
        Me.pnlOptions.Controls.Add(Me.lblBinding)
        Me.pnlOptions.Controls.Add(Me.lblValDroit)
        Me.pnlOptions.Controls.Add(Me.lblValGauche)
        Me.pnlOptions.Controls.Add(Me.lblValBas)
        Me.pnlOptions.Controls.Add(Me.lblDroit)
        Me.pnlOptions.Controls.Add(Me.lblGauche)
        Me.pnlOptions.Controls.Add(Me.lblBas)
        Me.pnlOptions.Controls.Add(Me.lblValHaut)
        Me.pnlOptions.Controls.Add(Me.lblHaut)
        Me.pnlOptions.Controls.Add(Me.lblControles)
        Me.pnlOptions.Controls.Add(Me.btnAccept)
        Me.pnlOptions.Controls.Add(Me.lblResUp)
        Me.pnlOptions.Controls.Add(Me.lblResDown)
        Me.pnlOptions.Controls.Add(Me.lblResCurrent)
        Me.pnlOptions.Controls.Add(Me.lblRes)
        Me.pnlOptions.Location = New System.Drawing.Point(18, 130)
        Me.pnlOptions.Name = "pnlOptions"
        Me.pnlOptions.Size = New System.Drawing.Size(750, 400)
        Me.pnlOptions.TabIndex = 1
        Me.pnlOptions.Visible = False
        '
        'trbVolume
        '
        Me.trbVolume.Location = New System.Drawing.Point(323, 100)
        Me.trbVolume.Maximum = 100
        Me.trbVolume.Name = "trbVolume"
        Me.trbVolume.Size = New System.Drawing.Size(82, 45)
        Me.trbVolume.TabIndex = 21
        Me.trbVolume.TickStyle = System.Windows.Forms.TickStyle.None
        Me.trbVolume.Value = 100
        '
        'lblVolValue
        '
        Me.lblVolValue.BackColor = System.Drawing.Color.Black
        Me.lblVolValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVolValue.ForeColor = System.Drawing.Color.White
        Me.lblVolValue.Location = New System.Drawing.Point(480, 95)
        Me.lblVolValue.Name = "lblVolValue"
        Me.lblVolValue.Size = New System.Drawing.Size(117, 20)
        Me.lblVolValue.TabIndex = 20
        Me.lblVolValue.Text = "100 %"
        Me.lblVolValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVolume
        '
        Me.lblVolume.BackColor = System.Drawing.Color.Black
        Me.lblVolume.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVolume.ForeColor = System.Drawing.Color.White
        Me.lblVolume.Location = New System.Drawing.Point(140, 95)
        Me.lblVolume.Name = "lblVolume"
        Me.lblVolume.Size = New System.Drawing.Size(100, 20)
        Me.lblVolume.TabIndex = 19
        Me.lblVolume.Text = "Volume:"
        Me.lblVolume.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnRetour
        '
        Me.btnRetour.BackColor = System.Drawing.Color.Black
        Me.btnRetour.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetour.ForeColor = System.Drawing.Color.White
        Me.btnRetour.Location = New System.Drawing.Point(432, 368)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(103, 29)
        Me.btnRetour.TabIndex = 18
        Me.btnRetour.Text = "Retour"
        Me.btnRetour.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Black
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(323, 368)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(103, 29)
        Me.btnReset.TabIndex = 17
        Me.btnReset.Text = "Réinitialiser"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'lblValSaut
        '
        Me.lblValSaut.BackColor = System.Drawing.Color.Black
        Me.lblValSaut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValSaut.ForeColor = System.Drawing.Color.White
        Me.lblValSaut.Location = New System.Drawing.Point(480, 234)
        Me.lblValSaut.Name = "lblValSaut"
        Me.lblValSaut.Size = New System.Drawing.Size(117, 20)
        Me.lblValSaut.TabIndex = 16
        Me.lblValSaut.Text = "Espace"
        Me.lblValSaut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSaut
        '
        Me.lblSaut.BackColor = System.Drawing.Color.Black
        Me.lblSaut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaut.ForeColor = System.Drawing.Color.White
        Me.lblSaut.Location = New System.Drawing.Point(319, 234)
        Me.lblSaut.Name = "lblSaut"
        Me.lblSaut.Size = New System.Drawing.Size(86, 20)
        Me.lblSaut.TabIndex = 15
        Me.lblSaut.Text = "Saut"
        Me.lblSaut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBinding
        '
        Me.lblBinding.BackColor = System.Drawing.Color.Black
        Me.lblBinding.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBinding.ForeColor = System.Drawing.Color.White
        Me.lblBinding.Location = New System.Drawing.Point(223, 280)
        Me.lblBinding.Name = "lblBinding"
        Me.lblBinding.Size = New System.Drawing.Size(299, 19)
        Me.lblBinding.TabIndex = 14
        Me.lblBinding.Text = "Appuyez sur une touche"
        Me.lblBinding.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblBinding.Visible = False
        '
        'lblValDroit
        '
        Me.lblValDroit.BackColor = System.Drawing.Color.Black
        Me.lblValDroit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValDroit.ForeColor = System.Drawing.Color.White
        Me.lblValDroit.Location = New System.Drawing.Point(480, 210)
        Me.lblValDroit.Name = "lblValDroit"
        Me.lblValDroit.Size = New System.Drawing.Size(117, 20)
        Me.lblValDroit.TabIndex = 13
        Me.lblValDroit.Text = "D"
        Me.lblValDroit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblValGauche
        '
        Me.lblValGauche.BackColor = System.Drawing.Color.Black
        Me.lblValGauche.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValGauche.ForeColor = System.Drawing.Color.White
        Me.lblValGauche.Location = New System.Drawing.Point(480, 190)
        Me.lblValGauche.Name = "lblValGauche"
        Me.lblValGauche.Size = New System.Drawing.Size(117, 20)
        Me.lblValGauche.TabIndex = 12
        Me.lblValGauche.Text = "A"
        Me.lblValGauche.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblValBas
        '
        Me.lblValBas.BackColor = System.Drawing.Color.Black
        Me.lblValBas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValBas.ForeColor = System.Drawing.Color.White
        Me.lblValBas.Location = New System.Drawing.Point(480, 169)
        Me.lblValBas.Name = "lblValBas"
        Me.lblValBas.Size = New System.Drawing.Size(117, 20)
        Me.lblValBas.TabIndex = 11
        Me.lblValBas.Text = "S"
        Me.lblValBas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDroit
        '
        Me.lblDroit.BackColor = System.Drawing.Color.Black
        Me.lblDroit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDroit.ForeColor = System.Drawing.Color.White
        Me.lblDroit.Location = New System.Drawing.Point(319, 210)
        Me.lblDroit.Name = "lblDroit"
        Me.lblDroit.Size = New System.Drawing.Size(86, 20)
        Me.lblDroit.TabIndex = 10
        Me.lblDroit.Text = "Droite"
        Me.lblDroit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGauche
        '
        Me.lblGauche.BackColor = System.Drawing.Color.Black
        Me.lblGauche.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGauche.ForeColor = System.Drawing.Color.White
        Me.lblGauche.Location = New System.Drawing.Point(319, 190)
        Me.lblGauche.Name = "lblGauche"
        Me.lblGauche.Size = New System.Drawing.Size(86, 20)
        Me.lblGauche.TabIndex = 9
        Me.lblGauche.Text = "Gauche"
        Me.lblGauche.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBas
        '
        Me.lblBas.BackColor = System.Drawing.Color.Black
        Me.lblBas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBas.ForeColor = System.Drawing.Color.White
        Me.lblBas.Location = New System.Drawing.Point(319, 170)
        Me.lblBas.Name = "lblBas"
        Me.lblBas.Size = New System.Drawing.Size(86, 20)
        Me.lblBas.TabIndex = 8
        Me.lblBas.Text = "Bas"
        Me.lblBas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblValHaut
        '
        Me.lblValHaut.BackColor = System.Drawing.Color.Black
        Me.lblValHaut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValHaut.ForeColor = System.Drawing.Color.White
        Me.lblValHaut.Location = New System.Drawing.Point(480, 150)
        Me.lblValHaut.Name = "lblValHaut"
        Me.lblValHaut.Size = New System.Drawing.Size(117, 20)
        Me.lblValHaut.TabIndex = 7
        Me.lblValHaut.Text = "W"
        Me.lblValHaut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHaut
        '
        Me.lblHaut.BackColor = System.Drawing.Color.Black
        Me.lblHaut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHaut.ForeColor = System.Drawing.Color.White
        Me.lblHaut.Location = New System.Drawing.Point(319, 150)
        Me.lblHaut.Name = "lblHaut"
        Me.lblHaut.Size = New System.Drawing.Size(86, 20)
        Me.lblHaut.TabIndex = 6
        Me.lblHaut.Text = "Haut"
        Me.lblHaut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblControles
        '
        Me.lblControles.BackColor = System.Drawing.Color.Black
        Me.lblControles.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblControles.ForeColor = System.Drawing.Color.White
        Me.lblControles.Location = New System.Drawing.Point(140, 150)
        Me.lblControles.Name = "lblControles"
        Me.lblControles.Size = New System.Drawing.Size(100, 20)
        Me.lblControles.TabIndex = 5
        Me.lblControles.Text = "Contrôles:"
        Me.lblControles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAccept
        '
        Me.btnAccept.BackColor = System.Drawing.Color.Black
        Me.btnAccept.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccept.ForeColor = System.Drawing.Color.White
        Me.btnAccept.Location = New System.Drawing.Point(214, 368)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(103, 29)
        Me.btnAccept.TabIndex = 4
        Me.btnAccept.Text = "Accepter"
        Me.btnAccept.UseVisualStyleBackColor = False
        '
        'lblResUp
        '
        Me.lblResUp.AutoSize = True
        Me.lblResUp.BackColor = System.Drawing.Color.Black
        Me.lblResUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResUp.ForeColor = System.Drawing.Color.White
        Me.lblResUp.Location = New System.Drawing.Point(603, 40)
        Me.lblResUp.Name = "lblResUp"
        Me.lblResUp.Size = New System.Drawing.Size(19, 20)
        Me.lblResUp.TabIndex = 3
        Me.lblResUp.Text = ">"
        Me.lblResUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblResDown
        '
        Me.lblResDown.AutoSize = True
        Me.lblResDown.BackColor = System.Drawing.Color.Black
        Me.lblResDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResDown.ForeColor = System.Drawing.Color.White
        Me.lblResDown.Location = New System.Drawing.Point(455, 40)
        Me.lblResDown.Name = "lblResDown"
        Me.lblResDown.Size = New System.Drawing.Size(19, 20)
        Me.lblResDown.TabIndex = 2
        Me.lblResDown.Text = "<"
        Me.lblResDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblResCurrent
        '
        Me.lblResCurrent.BackColor = System.Drawing.Color.Black
        Me.lblResCurrent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResCurrent.ForeColor = System.Drawing.Color.White
        Me.lblResCurrent.Location = New System.Drawing.Point(480, 40)
        Me.lblResCurrent.Name = "lblResCurrent"
        Me.lblResCurrent.Size = New System.Drawing.Size(117, 20)
        Me.lblResCurrent.TabIndex = 1
        Me.lblResCurrent.Text = "800 x 600"
        Me.lblResCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRes
        '
        Me.lblRes.AutoSize = True
        Me.lblRes.BackColor = System.Drawing.Color.Black
        Me.lblRes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRes.ForeColor = System.Drawing.Color.White
        Me.lblRes.Location = New System.Drawing.Point(140, 40)
        Me.lblRes.Name = "lblRes"
        Me.lblRes.Size = New System.Drawing.Size(100, 20)
        Me.lblRes.TabIndex = 0
        Me.lblRes.Text = "Résolution:"
        '
        'lblIntro
        '
        Me.lblIntro.BackColor = System.Drawing.Color.Black
        Me.lblIntro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntro.ForeColor = System.Drawing.Color.White
        Me.lblIntro.Location = New System.Drawing.Point(319, 56)
        Me.lblIntro.Name = "lblIntro"
        Me.lblIntro.Size = New System.Drawing.Size(160, 50)
        Me.lblIntro.TabIndex = 15
        Me.lblIntro.Text = "Appuyez sur une touche"
        Me.lblIntro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrIntro
        '
        Me.tmrIntro.Enabled = True
        Me.tmrIntro.Interval = 1
        '
        'lbltitre
        '
        Me.lbltitre.BackColor = System.Drawing.Color.Black
        Me.lbltitre.Font = New System.Drawing.Font("Harrington", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitre.ForeColor = System.Drawing.Color.White
        Me.lbltitre.Location = New System.Drawing.Point(132, 6)
        Me.lbltitre.Name = "lbltitre"
        Me.lbltitre.Size = New System.Drawing.Size(524, 100)
        Me.lbltitre.TabIndex = 16
        Me.lbltitre.Text = "Jam Bombe"
        Me.lbltitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AxWMPMusic
        '
        Me.AxWMPMusic.Enabled = True
        Me.AxWMPMusic.Location = New System.Drawing.Point(689, 51)
        Me.AxWMPMusic.Name = "AxWMPMusic"
        Me.AxWMPMusic.OcxState = CType(resources.GetObject("AxWMPMusic.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWMPMusic.Size = New System.Drawing.Size(78, 54)
        Me.AxWMPMusic.TabIndex = 17
        Me.AxWMPMusic.Visible = False
        '
        'frmIntro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.AxWMPMusic)
        Me.Controls.Add(Me.lbltitre)
        Me.Controls.Add(Me.lblIntro)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.pnlOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmIntro"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jam Bombe"
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlOptions.ResumeLayout(False)
        Me.pnlOptions.PerformLayout()
        CType(Me.trbVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWMPMusic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlMenu As System.Windows.Forms.Panel
    Friend WithEvents lblQuitter As System.Windows.Forms.Label
    Friend WithEvents lblOptions As System.Windows.Forms.Label
    Friend WithEvents lblCommencer As System.Windows.Forms.Label
    Friend WithEvents pnlOptions As System.Windows.Forms.Panel
    Friend WithEvents lblResUp As System.Windows.Forms.Label
    Friend WithEvents lblResDown As System.Windows.Forms.Label
    Friend WithEvents lblResCurrent As System.Windows.Forms.Label
    Friend WithEvents lblRes As System.Windows.Forms.Label
    Friend WithEvents btnAccept As System.Windows.Forms.Button
    Friend WithEvents lblValDroit As System.Windows.Forms.Label
    Friend WithEvents lblValGauche As System.Windows.Forms.Label
    Friend WithEvents lblValBas As System.Windows.Forms.Label
    Friend WithEvents lblDroit As System.Windows.Forms.Label
    Friend WithEvents lblGauche As System.Windows.Forms.Label
    Friend WithEvents lblBas As System.Windows.Forms.Label
    Friend WithEvents lblValHaut As System.Windows.Forms.Label
    Friend WithEvents lblHaut As System.Windows.Forms.Label
    Friend WithEvents lblControles As System.Windows.Forms.Label
    Friend WithEvents lblBinding As System.Windows.Forms.Label
    Friend WithEvents lblIntro As System.Windows.Forms.Label
    Friend WithEvents tmrIntro As System.Windows.Forms.Timer
    Friend WithEvents lbltitre As System.Windows.Forms.Label
    Friend WithEvents lblValSaut As System.Windows.Forms.Label
    Friend WithEvents lblSaut As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnRetour As System.Windows.Forms.Button
    Friend WithEvents trbVolume As System.Windows.Forms.TrackBar
    Friend WithEvents lblVolValue As System.Windows.Forms.Label
    Friend WithEvents lblVolume As System.Windows.Forms.Label
    Friend WithEvents AxWMPMusic As AxWMPLib.AxWindowsMediaPlayer

End Class
