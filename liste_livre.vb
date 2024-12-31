Public Class liste_livre
    Private Sub liste_livre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AfficherLivre(lst_isbn, lst_titre, lst_auteur)
    End Sub

    Private Sub btn_afficher_Click(sender As Object, e As EventArgs) Handles btn_afficher.Click
        Form5.Show()
    End Sub
End Class