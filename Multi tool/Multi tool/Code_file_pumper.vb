'Idée d'amélioration : Faire le travail dans un BackgroundWorker (ou une form invisible) afin que la fenêtre n'affiche pas "L'application ne répond pas"
Public Class Code_file_pumper
    Public Shared FileSize_options_normales As Double = Val(Form1.NUD_options_normales.Value) 'Trouve la taille que nous voulons dans la Form1 // GB options
    Public Shared FileSize_extra_options As Double = Val(Form1.NUD_options_extra.Value) 'Trouve la taille que nous voulons dans la Form1 // GB extra options
    Public Shared multiplierzettaoctet As String = "1180591620717411303424" 'On est obligés de faire comme ça, sinon il y a une erreur de dépassement de capacité // Merci à FyR0z pour cette solution ! 
    Public Shared multiplieryottaoctet As String = "1208925819614629174706176" 'On est obligés de faire comme ça, sinon il y a une erreur de dépassement de capacité // Merci à FyR0z pour cette solution !

    Public Shared Sub Octet()
        FileSize_options_normales = FileSize_options_normales * 1
    End Sub
    Public Shared Sub Kilooctet()
        FileSize_options_normales = FileSize_options_normales * 1000
    End Sub
    Public Shared Sub Megaoctet()
        FileSize_options_normales = FileSize_options_normales * 1000000
    End Sub
    Public Shared Sub Gigaoctet()
        FileSize_options_normales = FileSize_options_normales * 1000000000
    End Sub
    Public Shared Sub Teraoctet()
        FileSize_options_normales = FileSize_options_normales * 1099511627776
    End Sub
    Public Shared Sub Pétaoctet()
        FileSize_extra_options = FileSize_extra_options * 1125899906842624
    End Sub
    Public Shared Sub Exaoctet()
        FileSize_extra_options = FileSize_extra_options * 1152921504606846976
    End Sub
    Public Shared Sub Zettaoctet()
        FileSize_extra_options = FileSize_extra_options * CInt(multiplierzettaoctet)
    End Sub
    Public Shared Sub Yottaoctet()
        FileSize_extra_options = FileSize_extra_options * CInt(multiplieryottaoctet)
    End Sub
End Class