Imports System

Module Program
    Sub Main()
        Dim postIts As New List(Of String)
        Dim choix As String = ""

        Do
            Console.Clear()
            Console.WriteLine("=== Mini Gestionnaire de Post-it ===")
            Console.WriteLine("1. Ajouter un Post-it")
            Console.WriteLine("2. Voir tous les Post-its")
            Console.WriteLine("3. Supprimer un Post-it")
            Console.WriteLine("4. Quitter")
            Console.Write("Choisis une option: ")
            choix = Console.ReadLine()

            Select Case choix
                Case "1"
                    AjouterPostIt(postIts)
                Case "2"
                    AfficherPostIts(postIts)
                Case "3"
                    SupprimerPostIt(postIts)
                Case "4"
                    Console.WriteLine("Au revoir!")
                Case Else
                    Console.WriteLine("Option invalide!")
            End Select

            If choix <> "4" Then
                Console.WriteLine("Appuie sur une touche pour continuer...")
                Console.ReadKey()
            End If
        Loop While choix <> "4"
    End Sub

    Sub AjouterPostIt(ByRef postIts As List(Of String))
        Console.Write("Écris ton Post-it: ")
        Dim note As String = Console.ReadLine()
        postIts.Add(note)
        Console.WriteLine("Post-it ajouté!")
    End Sub

    Sub AfficherPostIts(postIts As List(Of String))
        Console.WriteLine("=== Tes Post-its ===")
        If postIts.Count = 0 Then
            Console.WriteLine("Aucun Post-it pour le moment.")
        Else
            For i As Integer = 0 To postIts.Count - 1
                Console.WriteLine($"{i + 1}. {postIts(i)}")
            Next
        End If
    End Sub

    Sub SupprimerPostIt(ByRef postIts As List(Of String))
        AfficherPostIts(postIts)
        If postIts.Count > 0 Then
            Console.Write("Numéro du Post-it à supprimer: ")
            Try
                Dim num As Integer = Convert.ToInt32(Console.ReadLine())
                If num >= 1 And num <= postIts.Count Then
                    postIts.RemoveAt(num - 1)
                    Console.WriteLine("Post-it supprimé!")
                Else
                    Console.WriteLine("Numéro invalide!")
                End If
            Catch ex As Exception
                Console.WriteLine("Erreur: saisie invalide.")
            End Try
        End If
    End Sub
End Module
