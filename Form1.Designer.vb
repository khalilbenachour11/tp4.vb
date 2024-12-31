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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txt_isbn = New TextBox()
        txt_titre = New TextBox()
        txt_auteur = New TextBox()
        btn_ajouter = New Button()
        btn_afficher = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Navy
        Label1.Font = New Font("Arial Black", 10.8F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(40, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 26)
        Label1.TabIndex = 0
        Label1.Text = "num"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Navy
        Label2.Font = New Font("Arial Black", 10.8F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(40, 122)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 26)
        Label2.TabIndex = 1
        Label2.Text = "titre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Navy
        Label3.Font = New Font("Arial Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(40, 217)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 26)
        Label3.TabIndex = 2
        Label3.Text = "auteur"
        ' 
        ' txt_isbn
        ' 
        txt_isbn.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txt_isbn.Location = New Point(166, 44)
        txt_isbn.Name = "txt_isbn"
        txt_isbn.Size = New Size(125, 27)
        txt_isbn.TabIndex = 3
        ' 
        ' txt_titre
        ' 
        txt_titre.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txt_titre.Location = New Point(166, 123)
        txt_titre.Name = "txt_titre"
        txt_titre.Size = New Size(125, 27)
        txt_titre.TabIndex = 4
        ' 
        ' txt_auteur
        ' 
        txt_auteur.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txt_auteur.Location = New Point(166, 218)
        txt_auteur.Name = "txt_auteur"
        txt_auteur.Size = New Size(125, 27)
        txt_auteur.TabIndex = 5
        ' 
        ' btn_ajouter
        ' 
        btn_ajouter.BackColor = Color.Maroon
        btn_ajouter.Font = New Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_ajouter.Location = New Point(40, 322)
        btn_ajouter.Name = "btn_ajouter"
        btn_ajouter.Size = New Size(94, 47)
        btn_ajouter.TabIndex = 6
        btn_ajouter.Text = "ajouter"
        btn_ajouter.UseVisualStyleBackColor = False
        ' 
        ' btn_afficher
        ' 
        btn_afficher.BackColor = Color.Maroon
        btn_afficher.Font = New Font("Arial", 10.8F, FontStyle.Bold)
        btn_afficher.Location = New Point(197, 322)
        btn_afficher.Name = "btn_afficher"
        btn_afficher.Size = New Size(94, 47)
        btn_afficher.TabIndex = 7
        btn_afficher.Text = "afficher"
        btn_afficher.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gray
        ClientSize = New Size(455, 450)
        Controls.Add(btn_afficher)
        Controls.Add(btn_ajouter)
        Controls.Add(txt_auteur)
        Controls.Add(txt_titre)
        Controls.Add(txt_isbn)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_isbn As TextBox
    Friend WithEvents txt_titre As TextBox
    Friend WithEvents txt_auteur As TextBox
    Friend WithEvents btn_ajouter As Button
    Friend WithEvents btn_afficher As Button

End Class
