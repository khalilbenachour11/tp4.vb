Public Class Form1

    Private Sub btn_ajouter_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        If String.IsNullOrWhiteSpace(txt_isbn.Text) And String.IsNullOrWhiteSpace(txt_titre.Text) And String.IsNullOrWhiteSpace(txt_auteur.Text) Then
            MessageBox.Show("Veuillez remplir les champs.")

        End If
        Dim l As Livre
        l.ISBN = txt_isbn.Text
        l.Titre = txt_titre.Text
        l.Auteur = txt_auteur.Text
        If AjouterLivre(l) Then
            MessageBox.Show("Ajout du livre avec succès")
            txt_isbn.Clear()
            txt_titre.Clear()
            txt_auteur.Clear()
        End If
    End Sub

    Private Sub btn_afficher_Click(sender As Object, e As EventArgs) Handles btn_afficher.Click
        liste_livre.Show()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class