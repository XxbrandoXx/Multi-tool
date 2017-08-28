'--------Author : XxbrandoXx--------------------'
'--------THANKS TO PUT ME IN YOUR CREDITS-------'
'--------IF YOU USE ANY PARTS OF MY CODE--------'
'--------FOR EDUCATIVE PURPOSES ONLY------------'
'I won't translate my tool in English as it's very easy to use it.
Imports System.Net
Public Class Form1
#Region "Declaration variables globales"
    Public applicationName As String = Application.ProductName
    Public applicationPath As String = Application.ExecutablePath
#End Region 'OK

    '--------REGION DES BOUTONS--------'

#Region "Bouton Tuer un processus"
    Private Sub BT_tuer_le_processus_Click(sender As Object, e As EventArgs) Handles BT_tuer_le_processus.Click
        Tuer_un_processus(TXT_processus_a_tuer.Text)
    End Sub
#End Region 'OK
#Region "Bouton Envoi du mail"
    Private Sub BT_Envoi_Du_Mail_Click(sender As Object, e As EventArgs) Handles BT_Envoi_Du_Mail.Click
        Try
            Envoi_du_mail(adresse_mail_envoi:=TXT_adresse_mail_envoi.Text,
                          password:=TXT_password_adresse_mail_envoi.Text,
                          adresse_mail_destinataire:=TXT_adresse_mail_destinataire.Text,
                          port:=NUD_port_SMTP.Value,
                          serveur_smtp:=TXT_serveur_SMTP.Text)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
#End Region 'OK
#Region "Boutons StartUP"
    Private Sub BT_StartUP_system_Click(sender As Object, e As EventArgs) Handles BT_StartUP_system.Click
        CreerStartUp_System()
    End Sub
    Private Sub BT_Enlever_StartUP_system_Click(sender As Object, e As EventArgs) Handles BT_Enlever_StartUP_system.Click
        SupprimerStartUp_System()
    End Sub
    Private Sub BT_StartUP_user_Click(sender As Object, e As EventArgs) Handles BT_StartUP_user.Click
        CreerStartUp_user()
    End Sub
    Private Sub BT_Enlever_StartUP_user_Click(sender As Object, e As EventArgs) Handles BT_Enlever_StartUP_user.Click
        SupprimerStartUp_user()
    End Sub
#End Region 'OK
#Region "Bouton chercher executable"
    Private Sub BT_chercher_executable_Click(sender As Object, e As EventArgs) Handles BT_chercher_executable.Click
        OpenFileDialog_executable.Filter = "Exe Files|*.exe" 'Ajoute un filtre pour les executable uniquement
        OpenFileDialog_executable.FileName = "" 'Supprime le "filename" de l'OpenFileDialog
        OpenFileDialog_executable.ShowDialog() 'Montre l'OpenFileDialog à l'utilisateur
        If OpenFileDialog_executable.FileName = "" Then  'Si l'utilisateur ne choisit rien alors
            MsgBox("Tu dois séléctionner un fichier !", MsgBoxStyle.Critical, "Selectionne un fichier !") 'Montre un message demandant de choisir un fichier
        Else
            BT_pump_fichier_exe.Enabled = True 'Autorise l'utilisateur à pumper son fichier
            TXT_Path_fichier_a_pump.Text = OpenFileDialog_executable.FileName 'Remplace la textbox avec le répertoire de l'executable
        End If
    End Sub
#End Region 'OK
#Region "Bouton pump l'executable"
    Private Sub BT_pump_fichier_exe_Click(sender As Object, e As EventArgs) Handles BT_pump_fichier_exe.Click
        Try
            SaveFileDialog_executable.Filter = "Exe Files|*.exe" 'Ajoute un filtre pour les executable uniquement
            SaveFileDialog_executable.FileName = "" 'Supprime le "filename" de la SaveFileDialog
            SaveFileDialog_executable.ShowDialog() 'Montre la SaveFileDialog à l'utilisateur
            If SaveFileDialog_executable.FileName = "" Then 'Si l'utilisateur n'a rien choisi,
                MsgBox("Tu dois choisir l'endroit où enregistrer ton fichier !", MsgBoxStyle.Critical, "Répértoire manquant")
            End If
            IO.File.Copy(TXT_Path_fichier_a_pump.Text, SaveFileDialog_executable.FileName)
            'Copie le fichier source à l'emplacement voulu
            If RB_octet.Checked Then
                Call Code_file_pumper.Octet() 'On appelle la fonction dans la classe Code_file_pumper
            End If
            If RB_Kilooctet.Checked Then
                Call Code_file_pumper.Kilooctet() 'On appelle la fonction dans la classe Code_file_pumper
            End If
            If RB_Megaoctet.Checked Then
                Call Code_file_pumper.Megaoctet() 'On appelle la fonction dans la classe Code_file_pumper
            End If
            If RB_Gigaoctet.Checked Then
                Call Code_file_pumper.Gigaoctet() 'On appelle la fonction dans la classe Code_file_pumper
            End If
            If RB_Pétaoctet.Checked Then
                Call Code_file_pumper.pétaoctet() 'On appelle la fonction dans la classe Code_file_pumper
            End If
            If RB_Exaoctet.Checked Then
                Call Code_file_pumper.exaoctet() 'On appelle la fonction dans la classe Code_file_pumper
            End If
            If RB_Zettaoctet.Checked Then
                Call Code_file_pumper.zettaoctet() 'On appelle la fonction dans la classe Code_file_pumper
            End If
            If RB_Yottaoctet.Checked Then
                Call Code_file_pumper.Yottaoctet() 'On appelle la fonction dans la classe Code_file_pumper
            End If
            Dim filetopump = IO.File.OpenWrite(SaveFileDialog_executable.FileName)
            'Déclare filetopump = ouvre le fichier qu'on a sauvegardé en lecture/écriture
            Dim size = filetopump.Seek(0, IO.SeekOrigin.[End])
            If RB_options_normales.Checked = True Then
                While size < Code_file_pumper.FileSize_options_normales 'Tant que la taille du fichier est inférieure à la taille voulue alors
                    filetopump.WriteByte(0) 'On écrit des bytes dans le fichier qu'on a sauvegardé
                    size += 1 ' s'écrit aussi size = size + 1 
                End While 'Fin de la boucle
            Else
                While size < Code_file_pumper.FileSize_extra_options 'Tant que la taille du fichier est inférieure à la taille voulue alors
                    filetopump.WriteByte(0) 'On écrit des bytes dans le fichier qu'on a sauvegardé
                    size = size + 1 ' s'écrit aussi size = size += 1 
                End While 'Fin de la boucle
            End If
            filetopump.Close() 'On ferme le fichier qu'on a sauvegardé
            MsgBox("Votre fichier à bien été pumpé !") 'On indique que l'application a bien fonctionné

        Catch ex As Exception
            MsgBox(ex.Message) 'Si il y a une erreur, ça affiche le message d'erreur
        End Try
    End Sub
#End Region 'OK
#Region "Bouton dump clef wifi"
    Private Sub BT_dump_clefs_wifi_Click(sender As Object, e As EventArgs) Handles BT_dump_clefs_wifi.Click
        Dim user As String = Environment.UserName
        Dim path_copier_clefs_wifi = IO.Directory.CreateDirectory("C:\Users\" & user & "\Dump_clefs_wifi")
        TXT_path_sauvegarde_clefs_wifi.Text = "C:\Users\" & user & "\Dump_clefs_wifi"
        Dim path_clefs_wifi As String = "C:\ProgramData\Microsoft\Wlansvc\Profiles\Interfaces\"
        Dim dossiers() As String = IO.Directory.GetDirectories(path_clefs_wifi)
        Dim taille_tableau As Integer = dossiers.Length
        Dim n = 0
        Dim m = 0
        While n <> taille_tableau
            Dim fichiers() As String = IO.Directory.GetFiles(dossiers(n))
            Dim nombre_fichiers As Integer = fichiers.Length
            While m <> nombre_fichiers
                IO.File.Copy(fichiers(m), "C:\Users\" & user & "\Dump_clefs_wifi\fichier_" & m & ".xml", True)
                m = m + 1
            End While
            n = n + 1
        End While
        MsgBox("Dump effectué !")
    End Sub
#End Region
#Region "Bouton actualiser les IP"
    Private Sub BT_actualiser_IP_Click(sender As Object, e As EventArgs) Handles BT_actualiser_IP.Click
        LB_IP_locale.Text = Get_IP_locale()
        LB_IP_public.Text = Get_IP_public()
    End Sub
#End Region

    '------FIN REGION DES BOUTONS------'
#Region "Radio Buttons"
    Private Sub RB_options_normales_CheckedChanged(sender As Object, e As EventArgs) Handles RB_options_normales.CheckedChanged
        If RB_options_normales.Checked = True Then
            If TXT_Path_fichier_a_pump.Text = "" Then
                MsgBox("Veuillez choisir un fichier", MsgBoxStyle.Information, "Information")
                RB_options_normales.Checked = False
            Else
                GB_options_normales.Enabled = True 'Autorise l'utilisateur à choisir ses options normales
                GB_options_extra.Enabled = False
            End If
        End If
    End Sub
    Private Sub RB_options_extra_CheckedChanged(sender As Object, e As EventArgs) Handles RB_options_extra.CheckedChanged
        If RB_options_extra.Checked = True Then
            If TXT_Path_fichier_a_pump.Text = "" Then
                MsgBox("Veuillez choisir un fichier", MsgBoxStyle.Information, "Information")
                RB_options_extra.Checked = False
            Else
                GB_options_extra.Enabled = True 'Autorise l'utilisateur à choisir ses options extra
                GB_options_normales.Enabled = False
            End If
        End If
    End Sub
#End Region 'OK
    '------REGION DES FONCTIONS--------'

#Region "Fonctions"
    Public Function Tuer_un_processus(ByVal nomduprocessus As String) As Process
        Try
            Dim Mes_Procesus() As Process
            Dim processus_a_tuer As Process
            Mes_Procesus = Process.GetProcessesByName(nomduprocessus)
            For Each processus_a_tuer In Mes_Procesus
                processus_a_tuer.CloseMainWindow()
            Next
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Function 'OK
    Public Function Get_IP_locale()
        Dim strHostName As String
        Dim strIPAddress As String
        strHostName = Net.Dns.GetHostName()
        strIPAddress = Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Return strIPAddress
    End Function
    Public Function Get_IP_public()
        Dim client As New WebClient()
        Return client.DownloadString("https://api.ipify.org")
    End Function
#End Region

    '-----FIN REGION DES FONCTIONS-----'
    '----------REGION DES SUBS---------'

#Region "Subs"
#Region "Sub Envoi du mail"
    Private Sub Envoi_du_mail(ByVal adresse_mail_envoi As String, ByVal password As String, ByVal adresse_mail_destinataire As String, ByVal port As Double, ByVal serveur_smtp As String)
        'rajouter "Byval path_piece_jointe As String" pour mettre une pièce jointe avec le mail.
        'Ne pas oublier d'ajouter l'argument en modifiant le bouton d'envoi
        Dim client As New Net.Mail.SmtpClient
        Dim message As New Net.Mail.MailMessage
        client.Credentials = New Net.NetworkCredential(adresse_mail_envoi, password)

        Try

            client.Port = port 'définition du port 
            client.Host = serveur_smtp 'définition du serveur smtp
            client.EnableSsl = True
            message.From = New Net.Mail.MailAddress(adresse_mail_envoi)
            message.To.Add(adresse_mail_destinataire)
            '------------AJOUT DE PIECE(S) JOINTES
            'Dim item As New Net.Mail.Attachment(path_piece_jointe)
            'message.Attachments.Add(item) 'ajout de la pièce jointe au message
            '-------------------------------------

            message.Subject = "TEST"
            message.Body = "TEST"

            client.Send(message) 'envoi du mail
        Catch ex As Exception
            'TODO traiter les erreurs
        End Try
    End Sub
#End Region
#Region "Sub registre session actuelle"
    Private Sub CreerStartUp_user()
        Dim regKey As Microsoft.Win32.RegistryKey
        regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
        regKey.SetValue(applicationName, """" & applicationPath & """")
        regKey.Close()
    End Sub
    Private Sub SupprimerStartUp_user()
        Dim regKey As Microsoft.Win32.RegistryKey
        regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
        regKey.DeleteValue(applicationName, False)
        regKey.Close()
    End Sub

#End Region
#Region "Subs registre systeme"
    Private Sub CreerStartUp_System()
        Dim regKey As Microsoft.Win32.RegistryKey
        regKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
        regKey.SetValue(applicationName, """" & applicationPath & """")
        regKey.Close()
    End Sub
    Private Sub SupprimerStartUp_System()
        Dim regKey As Microsoft.Win32.RegistryKey
        regKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
        regKey.DeleteValue(applicationName, False)
        regKey.Close()
    End Sub
#End Region
#End Region

    '-------FIN REGION DES SUBS--------'
End Class
