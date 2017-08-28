<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BT_Enlever_StartUP_user = New System.Windows.Forms.Button()
        Me.BT_StartUP_user = New System.Windows.Forms.Button()
        Me.BT_Enlever_StartUP_system = New System.Windows.Forms.Button()
        Me.BT_StartUP_system = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BT_Envoi_Du_Mail = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.NUD_port_SMTP = New System.Windows.Forms.NumericUpDown()
        Me.TXT_serveur_SMTP = New System.Windows.Forms.TextBox()
        Me.LB_Port_SMTP = New System.Windows.Forms.Label()
        Me.LB_nom_serveur_SMTP = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TXT_adresse_mail_destinataire = New System.Windows.Forms.TextBox()
        Me.LB_adresse_mail_destinataire = New System.Windows.Forms.Label()
        Me.TXT_password_adresse_mail_envoi = New System.Windows.Forms.TextBox()
        Me.TXT_adresse_mail_envoi = New System.Windows.Forms.TextBox()
        Me.LB_Password_Adresse_Mail_Envoi = New System.Windows.Forms.Label()
        Me.LB_Adresse_Mail_Envoi = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.BT_tuer_le_processus = New System.Windows.Forms.Button()
        Me.TXT_processus_a_tuer = New System.Windows.Forms.TextBox()
        Me.LB_nom_processus_a_tuer = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.BT_pump_fichier_exe = New System.Windows.Forms.Button()
        Me.GB_options_extra = New System.Windows.Forms.GroupBox()
        Me.RB_Yottaoctet = New System.Windows.Forms.RadioButton()
        Me.RB_Zettaoctet = New System.Windows.Forms.RadioButton()
        Me.RB_Exaoctet = New System.Windows.Forms.RadioButton()
        Me.RB_Pétaoctet = New System.Windows.Forms.RadioButton()
        Me.NUD_options_extra = New System.Windows.Forms.NumericUpDown()
        Me.RB_options_extra = New System.Windows.Forms.RadioButton()
        Me.RB_options_normales = New System.Windows.Forms.RadioButton()
        Me.GB_options_normales = New System.Windows.Forms.GroupBox()
        Me.RB_Teraoctet = New System.Windows.Forms.RadioButton()
        Me.RB_Gigaoctet = New System.Windows.Forms.RadioButton()
        Me.RB_Megaoctet = New System.Windows.Forms.RadioButton()
        Me.RB_Kilooctet = New System.Windows.Forms.RadioButton()
        Me.RB_octet = New System.Windows.Forms.RadioButton()
        Me.NUD_options_normales = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BT_chercher_executable = New System.Windows.Forms.Button()
        Me.TXT_Path_fichier_a_pump = New System.Windows.Forms.TextBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.LB_ip_publique = New System.Windows.Forms.Label()
        Me.BT_actualiser_IP = New System.Windows.Forms.Button()
        Me.LB_IP_public = New System.Windows.Forms.Label()
        Me.LB_IP_locale = New System.Windows.Forms.Label()
        Me.LB_IP_local = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.BT_verifier_hash = New System.Windows.Forms.Button()
        Me.LB_hash_a_verifier = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LB_SHA_256 = New System.Windows.Forms.Label()
        Me.LB_SHA_1 = New System.Windows.Forms.Label()
        Me.LB_MD5 = New System.Windows.Forms.Label()
        Me.TXT_hash_SHA_256 = New System.Windows.Forms.TextBox()
        Me.TXT_hash_SHA_1 = New System.Windows.Forms.TextBox()
        Me.TXT_hash_MD5 = New System.Windows.Forms.TextBox()
        Me.BT_chercher_fichier_hash = New System.Windows.Forms.Button()
        Me.TXT_path_fichier_hash = New System.Windows.Forms.TextBox()
        Me.LB_fichier_hash = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_path_sauvegarde_clefs_wifi = New System.Windows.Forms.TextBox()
        Me.BT_dump_clefs_wifi = New System.Windows.Forms.Button()
        Me.OpenFileDialog_executable = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog_executable = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.NUD_port_SMTP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GB_options_extra.SuspendLayout()
        CType(Me.NUD_options_extra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_options_normales.SuspendLayout()
        CType(Me.NUD_options_normales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BT_Enlever_StartUP_user)
        Me.GroupBox1.Controls.Add(Me.BT_StartUP_user)
        Me.GroupBox1.Controls.Add(Me.BT_Enlever_StartUP_system)
        Me.GroupBox1.Controls.Add(Me.BT_StartUP_system)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 75)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "StartUP"
        '
        'BT_Enlever_StartUP_user
        '
        Me.BT_Enlever_StartUP_user.Location = New System.Drawing.Point(112, 45)
        Me.BT_Enlever_StartUP_user.Name = "BT_Enlever_StartUP_user"
        Me.BT_Enlever_StartUP_user.Size = New System.Drawing.Size(75, 23)
        Me.BT_Enlever_StartUP_user.TabIndex = 3
        Me.BT_Enlever_StartUP_user.Text = "Enlever"
        Me.BT_Enlever_StartUP_user.UseVisualStyleBackColor = True
        '
        'BT_StartUP_user
        '
        Me.BT_StartUP_user.Location = New System.Drawing.Point(6, 45)
        Me.BT_StartUP_user.Name = "BT_StartUP_user"
        Me.BT_StartUP_user.Size = New System.Drawing.Size(100, 23)
        Me.BT_StartUP_user.TabIndex = 2
        Me.BT_StartUP_user.Text = "StartUP user"
        Me.BT_StartUP_user.UseVisualStyleBackColor = True
        '
        'BT_Enlever_StartUP_system
        '
        Me.BT_Enlever_StartUP_system.Location = New System.Drawing.Point(112, 16)
        Me.BT_Enlever_StartUP_system.Name = "BT_Enlever_StartUP_system"
        Me.BT_Enlever_StartUP_system.Size = New System.Drawing.Size(75, 23)
        Me.BT_Enlever_StartUP_system.TabIndex = 1
        Me.BT_Enlever_StartUP_system.Text = "Enlever "
        Me.BT_Enlever_StartUP_system.UseVisualStyleBackColor = True
        '
        'BT_StartUP_system
        '
        Me.BT_StartUP_system.Location = New System.Drawing.Point(6, 16)
        Me.BT_StartUP_system.Name = "BT_StartUP_system"
        Me.BT_StartUP_system.Size = New System.Drawing.Size(100, 23)
        Me.BT_StartUP_system.TabIndex = 0
        Me.BT_StartUP_system.Text = "StartUP system"
        Me.BT_StartUP_system.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(571, 253)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(563, 227)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "StartUP"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.BT_Envoi_Du_Mail)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(563, 227)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Envoi mail"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'BT_Envoi_Du_Mail
        '
        Me.BT_Envoi_Du_Mail.Location = New System.Drawing.Point(355, 48)
        Me.BT_Envoi_Du_Mail.Name = "BT_Envoi_Du_Mail"
        Me.BT_Envoi_Du_Mail.Size = New System.Drawing.Size(202, 72)
        Me.BT_Envoi_Du_Mail.TabIndex = 5
        Me.BT_Envoi_Du_Mail.Text = "Envoi du mail"
        Me.BT_Envoi_Du_Mail.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.NUD_port_SMTP)
        Me.GroupBox3.Controls.Add(Me.TXT_serveur_SMTP)
        Me.GroupBox3.Controls.Add(Me.LB_Port_SMTP)
        Me.GroupBox3.Controls.Add(Me.LB_nom_serveur_SMTP)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 102)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(343, 69)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Serveur SMTP"
        '
        'NUD_port_SMTP
        '
        Me.NUD_port_SMTP.Location = New System.Drawing.Point(133, 39)
        Me.NUD_port_SMTP.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.NUD_port_SMTP.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUD_port_SMTP.Name = "NUD_port_SMTP"
        Me.NUD_port_SMTP.Size = New System.Drawing.Size(141, 20)
        Me.NUD_port_SMTP.TabIndex = 3
        Me.NUD_port_SMTP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NUD_port_SMTP.ThousandsSeparator = True
        Me.NUD_port_SMTP.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'TXT_serveur_SMTP
        '
        Me.TXT_serveur_SMTP.Location = New System.Drawing.Point(133, 13)
        Me.TXT_serveur_SMTP.Name = "TXT_serveur_SMTP"
        Me.TXT_serveur_SMTP.Size = New System.Drawing.Size(141, 20)
        Me.TXT_serveur_SMTP.TabIndex = 2
        '
        'LB_Port_SMTP
        '
        Me.LB_Port_SMTP.AutoSize = True
        Me.LB_Port_SMTP.Location = New System.Drawing.Point(62, 41)
        Me.LB_Port_SMTP.Name = "LB_Port_SMTP"
        Me.LB_Port_SMTP.Size = New System.Drawing.Size(65, 13)
        Me.LB_Port_SMTP.TabIndex = 1
        Me.LB_Port_SMTP.Text = "Port SMTP :"
        '
        'LB_nom_serveur_SMTP
        '
        Me.LB_nom_serveur_SMTP.AutoSize = True
        Me.LB_nom_serveur_SMTP.Location = New System.Drawing.Point(6, 16)
        Me.LB_nom_serveur_SMTP.Name = "LB_nom_serveur_SMTP"
        Me.LB_nom_serveur_SMTP.Size = New System.Drawing.Size(121, 13)
        Me.LB_nom_serveur_SMTP.TabIndex = 0
        Me.LB_nom_serveur_SMTP.Text = "Nom du serveur SMTP :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TXT_adresse_mail_destinataire)
        Me.GroupBox2.Controls.Add(Me.LB_adresse_mail_destinataire)
        Me.GroupBox2.Controls.Add(Me.TXT_password_adresse_mail_envoi)
        Me.GroupBox2.Controls.Add(Me.TXT_adresse_mail_envoi)
        Me.GroupBox2.Controls.Add(Me.LB_Password_Adresse_Mail_Envoi)
        Me.GroupBox2.Controls.Add(Me.LB_Adresse_Mail_Envoi)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(343, 90)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Login"
        '
        'TXT_adresse_mail_destinataire
        '
        Me.TXT_adresse_mail_destinataire.Location = New System.Drawing.Point(161, 65)
        Me.TXT_adresse_mail_destinataire.Name = "TXT_adresse_mail_destinataire"
        Me.TXT_adresse_mail_destinataire.Size = New System.Drawing.Size(176, 20)
        Me.TXT_adresse_mail_destinataire.TabIndex = 5
        '
        'LB_adresse_mail_destinataire
        '
        Me.LB_adresse_mail_destinataire.AutoSize = True
        Me.LB_adresse_mail_destinataire.Location = New System.Drawing.Point(6, 68)
        Me.LB_adresse_mail_destinataire.Name = "LB_adresse_mail_destinataire"
        Me.LB_adresse_mail_destinataire.Size = New System.Drawing.Size(129, 13)
        Me.LB_adresse_mail_destinataire.TabIndex = 4
        Me.LB_adresse_mail_destinataire.Text = "Adresse mail destinataire :"
        '
        'TXT_password_adresse_mail_envoi
        '
        Me.TXT_password_adresse_mail_envoi.Location = New System.Drawing.Point(161, 39)
        Me.TXT_password_adresse_mail_envoi.Name = "TXT_password_adresse_mail_envoi"
        Me.TXT_password_adresse_mail_envoi.Size = New System.Drawing.Size(176, 20)
        Me.TXT_password_adresse_mail_envoi.TabIndex = 3
        '
        'TXT_adresse_mail_envoi
        '
        Me.TXT_adresse_mail_envoi.Location = New System.Drawing.Point(161, 13)
        Me.TXT_adresse_mail_envoi.Name = "TXT_adresse_mail_envoi"
        Me.TXT_adresse_mail_envoi.Size = New System.Drawing.Size(176, 20)
        Me.TXT_adresse_mail_envoi.TabIndex = 2
        '
        'LB_Password_Adresse_Mail_Envoi
        '
        Me.LB_Password_Adresse_Mail_Envoi.AutoSize = True
        Me.LB_Password_Adresse_Mail_Envoi.Location = New System.Drawing.Point(6, 42)
        Me.LB_Password_Adresse_Mail_Envoi.Name = "LB_Password_Adresse_Mail_Envoi"
        Me.LB_Password_Adresse_Mail_Envoi.Size = New System.Drawing.Size(149, 13)
        Me.LB_Password_Adresse_Mail_Envoi.TabIndex = 1
        Me.LB_Password_Adresse_Mail_Envoi.Text = "Password adresse mail envoi :"
        '
        'LB_Adresse_Mail_Envoi
        '
        Me.LB_Adresse_Mail_Envoi.AutoSize = True
        Me.LB_Adresse_Mail_Envoi.Location = New System.Drawing.Point(6, 16)
        Me.LB_Adresse_Mail_Envoi.Name = "LB_Adresse_Mail_Envoi"
        Me.LB_Adresse_Mail_Envoi.Size = New System.Drawing.Size(101, 13)
        Me.LB_Adresse_Mail_Envoi.TabIndex = 0
        Me.LB_Adresse_Mail_Envoi.Text = "Adresse mail envoi :"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.BT_tuer_le_processus)
        Me.TabPage3.Controls.Add(Me.TXT_processus_a_tuer)
        Me.TabPage3.Controls.Add(Me.LB_nom_processus_a_tuer)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(563, 227)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Processus"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'BT_tuer_le_processus
        '
        Me.BT_tuer_le_processus.Location = New System.Drawing.Point(3, 39)
        Me.BT_tuer_le_processus.Name = "BT_tuer_le_processus"
        Me.BT_tuer_le_processus.Size = New System.Drawing.Size(207, 23)
        Me.BT_tuer_le_processus.TabIndex = 2
        Me.BT_tuer_le_processus.Text = "Tuer le processus"
        Me.BT_tuer_le_processus.UseVisualStyleBackColor = True
        '
        'TXT_processus_a_tuer
        '
        Me.TXT_processus_a_tuer.Location = New System.Drawing.Point(110, 13)
        Me.TXT_processus_a_tuer.Name = "TXT_processus_a_tuer"
        Me.TXT_processus_a_tuer.Size = New System.Drawing.Size(100, 20)
        Me.TXT_processus_a_tuer.TabIndex = 1
        Me.TXT_processus_a_tuer.Text = "firefox"
        Me.TXT_processus_a_tuer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LB_nom_processus_a_tuer
        '
        Me.LB_nom_processus_a_tuer.AutoSize = True
        Me.LB_nom_processus_a_tuer.Location = New System.Drawing.Point(3, 16)
        Me.LB_nom_processus_a_tuer.Name = "LB_nom_processus_a_tuer"
        Me.LB_nom_processus_a_tuer.Size = New System.Drawing.Size(101, 13)
        Me.LB_nom_processus_a_tuer.TabIndex = 0
        Me.LB_nom_processus_a_tuer.Text = "Nom du processus :"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.BT_pump_fichier_exe)
        Me.TabPage4.Controls.Add(Me.GB_options_extra)
        Me.TabPage4.Controls.Add(Me.RB_options_extra)
        Me.TabPage4.Controls.Add(Me.RB_options_normales)
        Me.TabPage4.Controls.Add(Me.GB_options_normales)
        Me.TabPage4.Controls.Add(Me.GroupBox4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(563, 227)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "File Pumper"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'BT_pump_fichier_exe
        '
        Me.BT_pump_fichier_exe.Location = New System.Drawing.Point(3, 194)
        Me.BT_pump_fichier_exe.Name = "BT_pump_fichier_exe"
        Me.BT_pump_fichier_exe.Size = New System.Drawing.Size(557, 23)
        Me.BT_pump_fichier_exe.TabIndex = 2
        Me.BT_pump_fichier_exe.Text = "Pumper le fichier executable"
        Me.BT_pump_fichier_exe.UseVisualStyleBackColor = True
        '
        'GB_options_extra
        '
        Me.GB_options_extra.Controls.Add(Me.RB_Yottaoctet)
        Me.GB_options_extra.Controls.Add(Me.RB_Zettaoctet)
        Me.GB_options_extra.Controls.Add(Me.RB_Exaoctet)
        Me.GB_options_extra.Controls.Add(Me.RB_Pétaoctet)
        Me.GB_options_extra.Controls.Add(Me.NUD_options_extra)
        Me.GB_options_extra.Enabled = False
        Me.GB_options_extra.Location = New System.Drawing.Point(3, 137)
        Me.GB_options_extra.Name = "GB_options_extra"
        Me.GB_options_extra.Size = New System.Drawing.Size(557, 51)
        Me.GB_options_extra.TabIndex = 7
        Me.GB_options_extra.TabStop = False
        Me.GB_options_extra.Text = "Options extra"
        '
        'RB_Yottaoctet
        '
        Me.RB_Yottaoctet.AutoSize = True
        Me.RB_Yottaoctet.Location = New System.Drawing.Point(297, 19)
        Me.RB_Yottaoctet.Name = "RB_Yottaoctet"
        Me.RB_Yottaoctet.Size = New System.Drawing.Size(74, 17)
        Me.RB_Yottaoctet.TabIndex = 4
        Me.RB_Yottaoctet.TabStop = True
        Me.RB_Yottaoctet.Text = "Yottaoctet"
        Me.RB_Yottaoctet.UseVisualStyleBackColor = True
        '
        'RB_Zettaoctet
        '
        Me.RB_Zettaoctet.AutoSize = True
        Me.RB_Zettaoctet.Location = New System.Drawing.Point(217, 19)
        Me.RB_Zettaoctet.Name = "RB_Zettaoctet"
        Me.RB_Zettaoctet.Size = New System.Drawing.Size(74, 17)
        Me.RB_Zettaoctet.TabIndex = 3
        Me.RB_Zettaoctet.TabStop = True
        Me.RB_Zettaoctet.Text = "Zettaoctet"
        Me.RB_Zettaoctet.UseVisualStyleBackColor = True
        '
        'RB_Exaoctet
        '
        Me.RB_Exaoctet.AutoSize = True
        Me.RB_Exaoctet.Location = New System.Drawing.Point(144, 19)
        Me.RB_Exaoctet.Name = "RB_Exaoctet"
        Me.RB_Exaoctet.Size = New System.Drawing.Size(67, 17)
        Me.RB_Exaoctet.TabIndex = 2
        Me.RB_Exaoctet.TabStop = True
        Me.RB_Exaoctet.Text = "Exaoctet"
        Me.RB_Exaoctet.UseVisualStyleBackColor = True
        '
        'RB_Pétaoctet
        '
        Me.RB_Pétaoctet.AutoSize = True
        Me.RB_Pétaoctet.Location = New System.Drawing.Point(67, 19)
        Me.RB_Pétaoctet.Name = "RB_Pétaoctet"
        Me.RB_Pétaoctet.Size = New System.Drawing.Size(71, 17)
        Me.RB_Pétaoctet.TabIndex = 1
        Me.RB_Pétaoctet.TabStop = True
        Me.RB_Pétaoctet.Text = "Pétaoctet"
        Me.RB_Pétaoctet.UseVisualStyleBackColor = True
        '
        'NUD_options_extra
        '
        Me.NUD_options_extra.Location = New System.Drawing.Point(6, 19)
        Me.NUD_options_extra.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.NUD_options_extra.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUD_options_extra.Name = "NUD_options_extra"
        Me.NUD_options_extra.Size = New System.Drawing.Size(55, 20)
        Me.NUD_options_extra.TabIndex = 0
        Me.NUD_options_extra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NUD_options_extra.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'RB_options_extra
        '
        Me.RB_options_extra.AutoSize = True
        Me.RB_options_extra.Location = New System.Drawing.Point(169, 57)
        Me.RB_options_extra.Name = "RB_options_extra"
        Me.RB_options_extra.Size = New System.Drawing.Size(135, 17)
        Me.RB_options_extra.TabIndex = 6
        Me.RB_options_extra.Text = "Utiliser les options extra"
        Me.RB_options_extra.UseVisualStyleBackColor = True
        '
        'RB_options_normales
        '
        Me.RB_options_normales.AutoSize = True
        Me.RB_options_normales.Location = New System.Drawing.Point(9, 57)
        Me.RB_options_normales.Name = "RB_options_normales"
        Me.RB_options_normales.Size = New System.Drawing.Size(154, 17)
        Me.RB_options_normales.TabIndex = 5
        Me.RB_options_normales.Text = "Utiliser les options normales"
        Me.RB_options_normales.UseVisualStyleBackColor = True
        '
        'GB_options_normales
        '
        Me.GB_options_normales.Controls.Add(Me.RB_Teraoctet)
        Me.GB_options_normales.Controls.Add(Me.RB_Gigaoctet)
        Me.GB_options_normales.Controls.Add(Me.RB_Megaoctet)
        Me.GB_options_normales.Controls.Add(Me.RB_Kilooctet)
        Me.GB_options_normales.Controls.Add(Me.RB_octet)
        Me.GB_options_normales.Controls.Add(Me.NUD_options_normales)
        Me.GB_options_normales.Enabled = False
        Me.GB_options_normales.Location = New System.Drawing.Point(3, 80)
        Me.GB_options_normales.Name = "GB_options_normales"
        Me.GB_options_normales.Size = New System.Drawing.Size(557, 51)
        Me.GB_options_normales.TabIndex = 2
        Me.GB_options_normales.TabStop = False
        Me.GB_options_normales.Text = "Options normales"
        '
        'RB_Teraoctet
        '
        Me.RB_Teraoctet.AutoSize = True
        Me.RB_Teraoctet.Location = New System.Drawing.Point(353, 19)
        Me.RB_Teraoctet.Name = "RB_Teraoctet"
        Me.RB_Teraoctet.Size = New System.Drawing.Size(71, 17)
        Me.RB_Teraoctet.TabIndex = 5
        Me.RB_Teraoctet.TabStop = True
        Me.RB_Teraoctet.Text = "Teraoctet"
        Me.RB_Teraoctet.UseVisualStyleBackColor = True
        '
        'RB_Gigaoctet
        '
        Me.RB_Gigaoctet.AutoSize = True
        Me.RB_Gigaoctet.Location = New System.Drawing.Point(276, 19)
        Me.RB_Gigaoctet.Name = "RB_Gigaoctet"
        Me.RB_Gigaoctet.Size = New System.Drawing.Size(71, 17)
        Me.RB_Gigaoctet.TabIndex = 4
        Me.RB_Gigaoctet.TabStop = True
        Me.RB_Gigaoctet.Text = "Gigaoctet"
        Me.RB_Gigaoctet.UseVisualStyleBackColor = True
        '
        'RB_Megaoctet
        '
        Me.RB_Megaoctet.AutoSize = True
        Me.RB_Megaoctet.Location = New System.Drawing.Point(194, 19)
        Me.RB_Megaoctet.Name = "RB_Megaoctet"
        Me.RB_Megaoctet.Size = New System.Drawing.Size(76, 17)
        Me.RB_Megaoctet.TabIndex = 3
        Me.RB_Megaoctet.TabStop = True
        Me.RB_Megaoctet.Text = "Megaoctet"
        Me.RB_Megaoctet.UseVisualStyleBackColor = True
        '
        'RB_Kilooctet
        '
        Me.RB_Kilooctet.AutoSize = True
        Me.RB_Kilooctet.Location = New System.Drawing.Point(122, 19)
        Me.RB_Kilooctet.Name = "RB_Kilooctet"
        Me.RB_Kilooctet.Size = New System.Drawing.Size(66, 17)
        Me.RB_Kilooctet.TabIndex = 2
        Me.RB_Kilooctet.TabStop = True
        Me.RB_Kilooctet.Text = "Kilooctet"
        Me.RB_Kilooctet.UseVisualStyleBackColor = True
        '
        'RB_octet
        '
        Me.RB_octet.AutoSize = True
        Me.RB_octet.Location = New System.Drawing.Point(67, 19)
        Me.RB_octet.Name = "RB_octet"
        Me.RB_octet.Size = New System.Drawing.Size(49, 17)
        Me.RB_octet.TabIndex = 1
        Me.RB_octet.TabStop = True
        Me.RB_octet.Text = "octet"
        Me.RB_octet.UseVisualStyleBackColor = True
        '
        'NUD_options_normales
        '
        Me.NUD_options_normales.Location = New System.Drawing.Point(6, 19)
        Me.NUD_options_normales.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.NUD_options_normales.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUD_options_normales.Name = "NUD_options_normales"
        Me.NUD_options_normales.Size = New System.Drawing.Size(55, 20)
        Me.NUD_options_normales.TabIndex = 0
        Me.NUD_options_normales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NUD_options_normales.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BT_chercher_executable)
        Me.GroupBox4.Controls.Add(Me.TXT_Path_fichier_a_pump)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(557, 48)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "File"
        '
        'BT_chercher_executable
        '
        Me.BT_chercher_executable.Location = New System.Drawing.Point(422, 17)
        Me.BT_chercher_executable.Name = "BT_chercher_executable"
        Me.BT_chercher_executable.Size = New System.Drawing.Size(129, 23)
        Me.BT_chercher_executable.TabIndex = 1
        Me.BT_chercher_executable.Text = "Chercher l'executable"
        Me.BT_chercher_executable.UseVisualStyleBackColor = True
        '
        'TXT_Path_fichier_a_pump
        '
        Me.TXT_Path_fichier_a_pump.Location = New System.Drawing.Point(6, 19)
        Me.TXT_Path_fichier_a_pump.Name = "TXT_Path_fichier_a_pump"
        Me.TXT_Path_fichier_a_pump.ReadOnly = True
        Me.TXT_Path_fichier_a_pump.Size = New System.Drawing.Size(410, 20)
        Me.TXT_Path_fichier_a_pump.TabIndex = 0
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.GroupBox7)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(563, 227)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "IP adress"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.LB_ip_publique)
        Me.GroupBox7.Controls.Add(Me.BT_actualiser_IP)
        Me.GroupBox7.Controls.Add(Me.LB_IP_public)
        Me.GroupBox7.Controls.Add(Me.LB_IP_locale)
        Me.GroupBox7.Controls.Add(Me.LB_IP_local)
        Me.GroupBox7.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(174, 84)
        Me.GroupBox7.TabIndex = 5
        Me.GroupBox7.TabStop = False
        '
        'LB_ip_publique
        '
        Me.LB_ip_publique.AutoSize = True
        Me.LB_ip_publique.Location = New System.Drawing.Point(6, 16)
        Me.LB_ip_publique.Name = "LB_ip_publique"
        Me.LB_ip_publique.Size = New System.Drawing.Size(57, 13)
        Me.LB_ip_publique.TabIndex = 0
        Me.LB_ip_publique.Text = "IP public : "
        '
        'BT_actualiser_IP
        '
        Me.BT_actualiser_IP.Location = New System.Drawing.Point(6, 54)
        Me.BT_actualiser_IP.Name = "BT_actualiser_IP"
        Me.BT_actualiser_IP.Size = New System.Drawing.Size(162, 23)
        Me.BT_actualiser_IP.TabIndex = 4
        Me.BT_actualiser_IP.Text = "Actualiser les IP"
        Me.BT_actualiser_IP.UseVisualStyleBackColor = True
        '
        'LB_IP_public
        '
        Me.LB_IP_public.AutoSize = True
        Me.LB_IP_public.Location = New System.Drawing.Point(69, 16)
        Me.LB_IP_public.Name = "LB_IP_public"
        Me.LB_IP_public.Size = New System.Drawing.Size(0, 13)
        Me.LB_IP_public.TabIndex = 1
        '
        'LB_IP_locale
        '
        Me.LB_IP_locale.AutoSize = True
        Me.LB_IP_locale.Location = New System.Drawing.Point(69, 38)
        Me.LB_IP_locale.Name = "LB_IP_locale"
        Me.LB_IP_locale.Size = New System.Drawing.Size(0, 13)
        Me.LB_IP_locale.TabIndex = 3
        '
        'LB_IP_local
        '
        Me.LB_IP_local.AutoSize = True
        Me.LB_IP_local.Location = New System.Drawing.Point(6, 38)
        Me.LB_IP_local.Name = "LB_IP_local"
        Me.LB_IP_local.Size = New System.Drawing.Size(57, 13)
        Me.LB_IP_local.TabIndex = 2
        Me.LB_IP_local.Text = "IP locale : "
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.GroupBox6)
        Me.TabPage5.Controls.Add(Me.GroupBox5)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(563, 227)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Autre"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.BT_verifier_hash)
        Me.GroupBox6.Controls.Add(Me.LB_hash_a_verifier)
        Me.GroupBox6.Controls.Add(Me.TextBox1)
        Me.GroupBox6.Controls.Add(Me.LB_SHA_256)
        Me.GroupBox6.Controls.Add(Me.LB_SHA_1)
        Me.GroupBox6.Controls.Add(Me.LB_MD5)
        Me.GroupBox6.Controls.Add(Me.TXT_hash_SHA_256)
        Me.GroupBox6.Controls.Add(Me.TXT_hash_SHA_1)
        Me.GroupBox6.Controls.Add(Me.TXT_hash_MD5)
        Me.GroupBox6.Controls.Add(Me.BT_chercher_fichier_hash)
        Me.GroupBox6.Controls.Add(Me.TXT_path_fichier_hash)
        Me.GroupBox6.Controls.Add(Me.LB_fichier_hash)
        Me.GroupBox6.Enabled = False
        Me.GroupBox6.Location = New System.Drawing.Point(3, 83)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(460, 141)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Récupérateur de HASH (Coming Soon)"
        '
        'BT_verifier_hash
        '
        Me.BT_verifier_hash.Location = New System.Drawing.Point(379, 114)
        Me.BT_verifier_hash.Name = "BT_verifier_hash"
        Me.BT_verifier_hash.Size = New System.Drawing.Size(75, 23)
        Me.BT_verifier_hash.TabIndex = 11
        Me.BT_verifier_hash.Text = "Vérifier"
        Me.BT_verifier_hash.UseVisualStyleBackColor = True
        '
        'LB_hash_a_verifier
        '
        Me.LB_hash_a_verifier.AutoSize = True
        Me.LB_hash_a_verifier.Location = New System.Drawing.Point(25, 120)
        Me.LB_hash_a_verifier.Name = "LB_hash_a_verifier"
        Me.LB_hash_a_verifier.Size = New System.Drawing.Size(38, 13)
        Me.LB_hash_a_verifier.TabIndex = 10
        Me.LB_hash_a_verifier.Text = "Hash :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(69, 117)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(304, 20)
        Me.TextBox1.TabIndex = 9
        '
        'LB_SHA_256
        '
        Me.LB_SHA_256.AutoSize = True
        Me.LB_SHA_256.Location = New System.Drawing.Point(7, 94)
        Me.LB_SHA_256.Name = "LB_SHA_256"
        Me.LB_SHA_256.Size = New System.Drawing.Size(56, 13)
        Me.LB_SHA_256.TabIndex = 8
        Me.LB_SHA_256.Text = "SHA-256 :"
        '
        'LB_SHA_1
        '
        Me.LB_SHA_1.AutoSize = True
        Me.LB_SHA_1.Location = New System.Drawing.Point(19, 68)
        Me.LB_SHA_1.Name = "LB_SHA_1"
        Me.LB_SHA_1.Size = New System.Drawing.Size(44, 13)
        Me.LB_SHA_1.TabIndex = 7
        Me.LB_SHA_1.Text = "SHA-1 :"
        '
        'LB_MD5
        '
        Me.LB_MD5.AutoSize = True
        Me.LB_MD5.Location = New System.Drawing.Point(27, 42)
        Me.LB_MD5.Name = "LB_MD5"
        Me.LB_MD5.Size = New System.Drawing.Size(36, 13)
        Me.LB_MD5.TabIndex = 6
        Me.LB_MD5.Text = "MD5 :"
        '
        'TXT_hash_SHA_256
        '
        Me.TXT_hash_SHA_256.Location = New System.Drawing.Point(69, 91)
        Me.TXT_hash_SHA_256.Name = "TXT_hash_SHA_256"
        Me.TXT_hash_SHA_256.ReadOnly = True
        Me.TXT_hash_SHA_256.Size = New System.Drawing.Size(304, 20)
        Me.TXT_hash_SHA_256.TabIndex = 5
        '
        'TXT_hash_SHA_1
        '
        Me.TXT_hash_SHA_1.Location = New System.Drawing.Point(69, 65)
        Me.TXT_hash_SHA_1.Name = "TXT_hash_SHA_1"
        Me.TXT_hash_SHA_1.ReadOnly = True
        Me.TXT_hash_SHA_1.Size = New System.Drawing.Size(304, 20)
        Me.TXT_hash_SHA_1.TabIndex = 4
        '
        'TXT_hash_MD5
        '
        Me.TXT_hash_MD5.Location = New System.Drawing.Point(69, 39)
        Me.TXT_hash_MD5.Name = "TXT_hash_MD5"
        Me.TXT_hash_MD5.ReadOnly = True
        Me.TXT_hash_MD5.Size = New System.Drawing.Size(304, 20)
        Me.TXT_hash_MD5.TabIndex = 3
        '
        'BT_chercher_fichier_hash
        '
        Me.BT_chercher_fichier_hash.Location = New System.Drawing.Point(379, 11)
        Me.BT_chercher_fichier_hash.Name = "BT_chercher_fichier_hash"
        Me.BT_chercher_fichier_hash.Size = New System.Drawing.Size(75, 23)
        Me.BT_chercher_fichier_hash.TabIndex = 2
        Me.BT_chercher_fichier_hash.Text = "Chercher"
        Me.BT_chercher_fichier_hash.UseVisualStyleBackColor = True
        '
        'TXT_path_fichier_hash
        '
        Me.TXT_path_fichier_hash.Location = New System.Drawing.Point(69, 13)
        Me.TXT_path_fichier_hash.Name = "TXT_path_fichier_hash"
        Me.TXT_path_fichier_hash.ReadOnly = True
        Me.TXT_path_fichier_hash.Size = New System.Drawing.Size(304, 20)
        Me.TXT_path_fichier_hash.TabIndex = 1
        '
        'LB_fichier_hash
        '
        Me.LB_fichier_hash.AutoSize = True
        Me.LB_fichier_hash.Location = New System.Drawing.Point(16, 16)
        Me.LB_fichier_hash.Name = "LB_fichier_hash"
        Me.LB_fichier_hash.Size = New System.Drawing.Size(47, 13)
        Me.LB_fichier_hash.TabIndex = 0
        Me.LB_fichier_hash.Text = "Fichier : "
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.TXT_path_sauvegarde_clefs_wifi)
        Me.GroupBox5.Controls.Add(Me.BT_dump_clefs_wifi)
        Me.GroupBox5.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(460, 74)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Récupérer clef wifi ( nécessite Administrateur )"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Emplacement sauvegarde :"
        '
        'TXT_path_sauvegarde_clefs_wifi
        '
        Me.TXT_path_sauvegarde_clefs_wifi.Location = New System.Drawing.Point(148, 13)
        Me.TXT_path_sauvegarde_clefs_wifi.Name = "TXT_path_sauvegarde_clefs_wifi"
        Me.TXT_path_sauvegarde_clefs_wifi.ReadOnly = True
        Me.TXT_path_sauvegarde_clefs_wifi.Size = New System.Drawing.Size(306, 20)
        Me.TXT_path_sauvegarde_clefs_wifi.TabIndex = 3
        '
        'BT_dump_clefs_wifi
        '
        Me.BT_dump_clefs_wifi.Location = New System.Drawing.Point(6, 42)
        Me.BT_dump_clefs_wifi.Name = "BT_dump_clefs_wifi"
        Me.BT_dump_clefs_wifi.Size = New System.Drawing.Size(448, 23)
        Me.BT_dump_clefs_wifi.TabIndex = 2
        Me.BT_dump_clefs_wifi.Text = "Dump clefs wifi "
        Me.BT_dump_clefs_wifi.UseVisualStyleBackColor = True
        '
        'OpenFileDialog_executable
        '
        Me.OpenFileDialog_executable.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 266)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Multi tool"
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.NUD_port_SMTP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.GB_options_extra.ResumeLayout(False)
        Me.GB_options_extra.PerformLayout()
        CType(Me.NUD_options_extra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_options_normales.ResumeLayout(False)
        Me.GB_options_normales.PerformLayout()
        CType(Me.NUD_options_normales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BT_Enlever_StartUP_user As Button
    Friend WithEvents BT_StartUP_user As Button
    Friend WithEvents BT_Enlever_StartUP_system As Button
    Friend WithEvents BT_StartUP_system As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LB_Password_Adresse_Mail_Envoi As Label
    Friend WithEvents LB_Adresse_Mail_Envoi As Label
    Friend WithEvents TXT_password_adresse_mail_envoi As TextBox
    Friend WithEvents TXT_adresse_mail_envoi As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents NUD_port_SMTP As NumericUpDown
    Friend WithEvents TXT_serveur_SMTP As TextBox
    Friend WithEvents LB_Port_SMTP As Label
    Friend WithEvents LB_nom_serveur_SMTP As Label
    Friend WithEvents TXT_adresse_mail_destinataire As TextBox
    Friend WithEvents LB_adresse_mail_destinataire As Label
    Friend WithEvents BT_Envoi_Du_Mail As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TXT_processus_a_tuer As TextBox
    Friend WithEvents LB_nom_processus_a_tuer As Label
    Friend WithEvents BT_tuer_le_processus As Button
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BT_chercher_executable As Button
    Friend WithEvents TXT_Path_fichier_a_pump As TextBox
    Friend WithEvents GB_options_normales As GroupBox
    Friend WithEvents NUD_options_normales As NumericUpDown
    Friend WithEvents RB_octet As RadioButton
    Friend WithEvents RB_Teraoctet As RadioButton
    Friend WithEvents RB_Gigaoctet As RadioButton
    Friend WithEvents RB_Megaoctet As RadioButton
    Friend WithEvents RB_Kilooctet As RadioButton
    Friend WithEvents RB_options_extra As RadioButton
    Friend WithEvents RB_options_normales As RadioButton
    Friend WithEvents GB_options_extra As GroupBox
    Friend WithEvents NUD_options_extra As NumericUpDown
    Friend WithEvents RB_Yottaoctet As RadioButton
    Friend WithEvents RB_Zettaoctet As RadioButton
    Friend WithEvents RB_Exaoctet As RadioButton
    Friend WithEvents RB_Pétaoctet As RadioButton
    Friend WithEvents OpenFileDialog_executable As OpenFileDialog
    Friend WithEvents SaveFileDialog_executable As SaveFileDialog
    Friend WithEvents BT_pump_fichier_exe As Button
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents BT_dump_clefs_wifi As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_path_sauvegarde_clefs_wifi As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents LB_fichier_hash As Label
    Friend WithEvents BT_chercher_fichier_hash As Button
    Friend WithEvents TXT_path_fichier_hash As TextBox
    Friend WithEvents TXT_hash_SHA_256 As TextBox
    Friend WithEvents TXT_hash_SHA_1 As TextBox
    Friend WithEvents TXT_hash_MD5 As TextBox
    Friend WithEvents LB_MD5 As Label
    Friend WithEvents LB_SHA_1 As Label
    Friend WithEvents LB_SHA_256 As Label
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents BT_actualiser_IP As Button
    Friend WithEvents LB_IP_locale As Label
    Friend WithEvents LB_IP_local As Label
    Friend WithEvents LB_IP_public As Label
    Friend WithEvents LB_ip_publique As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents LB_hash_a_verifier As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BT_verifier_hash As Button
End Class
