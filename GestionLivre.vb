Module GestionLivre
    Public Structure Livre
        Dim ISBN As Integer
        Dim Titre As String
        Dim Auteur As String
    End Structure

    Public Bibliotheque(300) As Livre
    Dim Nb As Integer = 0
    Private Function LivreExiste(l As Livre) As Boolean
        For i As Integer = 0 To Nb - 1
            If Bibliotheque(i).ISBN = l.ISBN Then
                Return True
            End If
        Next
        Return False
    End Function

    Function AjouterLivre(l As Livre) As Boolean
        If String.IsNullOrWhiteSpace(l.ISBN) Then
            MessageBox.Show("Veuillez remplir le champ ISBN.")
            Return False
        End If
        If l.ISBN.ToString().Length <> 8 OrElse Not IsNumeric(l.ISBN) Then
            MsgBox("L'ISBN doit être un nombre de 8 chiffres.")
            Return False
        End If
        If String.IsNullOrWhiteSpace(l.Titre) Then
            MsgBox("Le titre ne peut pas être vide.")
            Return False
        End If
        If String.IsNullOrWhiteSpace(l.Auteur) Then
            MsgBox("L'auteur ne peut pas être vide.")
            Return False
        End If
        If LivreExiste(l) Then
            MsgBox("Le livre avec cet ISBN existe déjà.")
            Return False
        End If
        If Nb < Bibliotheque.Length Then
            Bibliotheque(Nb) = l
            Nb += 1
            Return True
        Else
            MsgBox("La bibliothèque est pleine.")
            Return False
        End If
    End Function
    Sub AfficherLivre(l1 As ListBox, l2 As ListBox, l3 As ListBox)
        l1.Items.Clear()
        l2.Items.Clear()
        l3.Items.Clear()

        For i As Integer = 0 To Nb - 1
            l1.Items.Add(Bibliotheque(i).ISBN)
            l2.Items.Add(Bibliotheque(i).Titre)
            l3.Items.Add(Bibliotheque(i).Auteur)
        Next
    End Sub


    Sub afficher2_Livre(dgv_Livre As DataGridView)
        For i As Integer = 0 To Nb - 1
            Dim Livre As Livre = Bibliotheque(i)
            dgv_Livre.Rows.Add(Livre.ISBN, Livre.Titre, Livre.Auteur)
        Next
    End Sub

End Module