<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCommencer
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
        Me.pnlCommencer = New System.Windows.Forms.Panel()
        Me.cmbDimension = New System.Windows.Forms.ComboBox()
        Me.lblDimension = New System.Windows.Forms.Label()
        Me.btnDemarer = New System.Windows.Forms.Button()
        Me.LblClasse = New System.Windows.Forms.Label()
        Me.lsbClasse = New System.Windows.Forms.ListBox()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.txtnom = New System.Windows.Forms.TextBox()
        Me.pnlCommencer.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCommencer
        '
        Me.pnlCommencer.AccessibleName = ""
        Me.pnlCommencer.Controls.Add(Me.cmbDimension)
        Me.pnlCommencer.Controls.Add(Me.lblDimension)
        Me.pnlCommencer.Controls.Add(Me.btnDemarer)
        Me.pnlCommencer.Controls.Add(Me.LblClasse)
        Me.pnlCommencer.Controls.Add(Me.lsbClasse)
        Me.pnlCommencer.Controls.Add(Me.lblNom)
        Me.pnlCommencer.Controls.Add(Me.txtnom)
        Me.pnlCommencer.Location = New System.Drawing.Point(50, 49)
        Me.pnlCommencer.Name = "pnlCommencer"
        Me.pnlCommencer.Size = New System.Drawing.Size(424, 352)
        Me.pnlCommencer.TabIndex = 0
        '
        'cmbDimension
        '
        Me.cmbDimension.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbDimension.FormattingEnabled = True
        Me.cmbDimension.Items.AddRange(New Object() {"25x50"})
        Me.cmbDimension.Location = New System.Drawing.Point(229, 162)
        Me.cmbDimension.Name = "cmbDimension"
        Me.cmbDimension.Size = New System.Drawing.Size(121, 21)
        Me.cmbDimension.TabIndex = 6
        Me.cmbDimension.Text = "25x50"
        '
        'lblDimension
        '
        Me.lblDimension.AutoSize = True
        Me.lblDimension.ForeColor = System.Drawing.Color.White
        Me.lblDimension.Location = New System.Drawing.Point(11, 165)
        Me.lblDimension.Name = "lblDimension"
        Me.lblDimension.Size = New System.Drawing.Size(184, 13)
        Me.lblDimension.TabIndex = 5
        Me.lblDimension.Text = "Avec un monde de quelle dimension?"
        '
        'btnDemarer
        '
        Me.btnDemarer.ForeColor = System.Drawing.Color.White
        Me.btnDemarer.Location = New System.Drawing.Point(164, 295)
        Me.btnDemarer.Name = "btnDemarer"
        Me.btnDemarer.Size = New System.Drawing.Size(75, 23)
        Me.btnDemarer.TabIndex = 4
        Me.btnDemarer.Text = "Commencer"
        Me.btnDemarer.UseVisualStyleBackColor = True
        '
        'LblClasse
        '
        Me.LblClasse.AutoSize = True
        Me.LblClasse.ForeColor = System.Drawing.Color.White
        Me.LblClasse.Location = New System.Drawing.Point(12, 103)
        Me.LblClasse.Name = "LblClasse"
        Me.LblClasse.Size = New System.Drawing.Size(183, 13)
        Me.LblClasse.TabIndex = 3
        Me.LblClasse.Text = "Quelle profession voulez vous avoir ?"
        '
        'lsbClasse
        '
        Me.lsbClasse.FormattingEnabled = True
        Me.lsbClasse.Items.AddRange(New Object() {"Guerrier", "Mage", "Rogue"})
        Me.lsbClasse.Location = New System.Drawing.Point(229, 90)
        Me.lsbClasse.Name = "lsbClasse"
        Me.lsbClasse.Size = New System.Drawing.Size(100, 43)
        Me.lsbClasse.TabIndex = 2
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.ForeColor = System.Drawing.Color.White
        Me.lblNom.Location = New System.Drawing.Point(20, 40)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(175, 13)
        Me.lblNom.TabIndex = 1
        Me.lblNom.Text = "Entrez le nom de votre personnage:"
        '
        'txtnom
        '
        Me.txtnom.Location = New System.Drawing.Point(229, 40)
        Me.txtnom.Name = "txtnom"
        Me.txtnom.Size = New System.Drawing.Size(100, 20)
        Me.txtnom.TabIndex = 0
        '
        'frmCommencer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(519, 442)
        Me.Controls.Add(Me.pnlCommencer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCommencer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Commencer"
        Me.pnlCommencer.ResumeLayout(False)
        Me.pnlCommencer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lsbClasse As System.Windows.Forms.ListBox
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents txtnom As System.Windows.Forms.TextBox
    Friend WithEvents pnlCommencer As System.Windows.Forms.Panel
    Friend WithEvents LblClasse As System.Windows.Forms.Label
    Friend WithEvents btnDemarer As System.Windows.Forms.Button
    Friend WithEvents lblDimension As System.Windows.Forms.Label
    Friend WithEvents cmbDimension As System.Windows.Forms.ComboBox
End Class
