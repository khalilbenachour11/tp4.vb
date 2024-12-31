<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class liste_livre
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
        lst_isbn = New ListBox()
        lst_titre = New ListBox()
        lst_auteur = New ListBox()
        btn_afficher = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' lst_isbn
        ' 
        lst_isbn.BackColor = Color.Teal
        lst_isbn.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        lst_isbn.ForeColor = Color.Black
        lst_isbn.FormattingEnabled = True
        lst_isbn.ItemHeight = 25
        lst_isbn.Location = New Point(124, 133)
        lst_isbn.Name = "lst_isbn"
        lst_isbn.Size = New Size(150, 254)
        lst_isbn.TabIndex = 0
        lst_isbn.TabStop = False
        ' 
        ' lst_titre
        ' 
        lst_titre.BackColor = Color.Teal
        lst_titre.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        lst_titre.ForeColor = Color.Black
        lst_titre.FormattingEnabled = True
        lst_titre.ItemHeight = 25
        lst_titre.Location = New Point(329, 133)
        lst_titre.Name = "lst_titre"
        lst_titre.Size = New Size(150, 254)
        lst_titre.TabIndex = 1
        lst_titre.TabStop = False
        ' 
        ' lst_auteur
        ' 
        lst_auteur.BackColor = Color.Teal
        lst_auteur.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold)
        lst_auteur.ForeColor = Color.Black
        lst_auteur.FormattingEnabled = True
        lst_auteur.ItemHeight = 25
        lst_auteur.Location = New Point(553, 133)
        lst_auteur.Name = "lst_auteur"
        lst_auteur.Size = New Size(150, 254)
        lst_auteur.TabIndex = 2
        lst_auteur.TabStop = False
        ' 
        ' btn_afficher
        ' 
        btn_afficher.BackColor = Color.Teal
        btn_afficher.Font = New Font("Arial Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_afficher.ForeColor = Color.Black
        btn_afficher.Location = New Point(329, 435)
        btn_afficher.Name = "btn_afficher"
        btn_afficher.Size = New Size(150, 50)
        btn_afficher.TabIndex = 3
        btn_afficher.TabStop = False
        btn_afficher.Text = "afficher"
        btn_afficher.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Black", 12F, FontStyle.Bold)
        Label1.ForeColor = Color.Navy
        Label1.Location = New Point(161, 91)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 28)
        Label1.TabIndex = 5
        Label1.Text = "ISBN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Black", 12F, FontStyle.Bold)
        Label2.ForeColor = Color.Navy
        Label2.Location = New Point(371, 91)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 28)
        Label2.TabIndex = 6
        Label2.Text = "Titre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Black", 12F, FontStyle.Bold)
        Label3.ForeColor = Color.Navy
        Label3.Location = New Point(581, 91)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 28)
        Label3.TabIndex = 7
        Label3.Text = "Auteur"
        ' 
        ' liste_livre
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gray
        ClientSize = New Size(871, 518)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btn_afficher)
        Controls.Add(lst_auteur)
        Controls.Add(lst_titre)
        Controls.Add(lst_isbn)
        Name = "liste_livre"
        Text = "liste_livre"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lst_isbn As ListBox
    Friend WithEvents lst_titre As ListBox
    Friend WithEvents lst_auteur As ListBox
    Friend WithEvents btn_afficher As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
