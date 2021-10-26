<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistrasiAdmin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrasiAdmin))
        Me.ListPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.LogoutButton = New Guna.UI2.WinForms.Guna2Button()
        Me.RegistrasiAdminButton = New Guna.UI2.WinForms.Guna2Button()
        Me.RegistrasiUserButton = New Guna.UI2.WinForms.Guna2Button()
        Me.UploadJadwalButton = New Guna.UI2.WinForms.Guna2Button()
        Me.UserProfileButton = New Guna.UI2.WinForms.Guna2Button()
        Me.DashboardButton = New Guna.UI2.WinForms.Guna2Button()
        Me.JudulPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.JudulLabel = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.UpperContentPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.ContentPanelBg = New Guna.UI2.WinForms.Guna2Panel()
        Me.Inboxbutton = New Guna.UI2.WinForms.Guna2Button()
        Me.InboxPanel = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Inboxlabel = New System.Windows.Forms.Label()
        Me.Data5 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Data4 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Data3 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Data2 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Data1 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.ProdiCombo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.RankCombo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Username = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TambahAdmin = New Guna.UI2.WinForms.Guna2Button()
        Me.Password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Email = New Guna.UI2.WinForms.Guna2TextBox()
        Me.NIMNRPTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.NamaLengkapTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TambahDataAdmin = New System.Windows.Forms.Label()
        Me.UserPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.UserLabel = New System.Windows.Forms.Label()
        Me.UserPhoto = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.TitleBarPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.ControlPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.MinimazeControlBox = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.CloseControlBox = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ContentPanel = New System.Windows.Forms.Panel()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.ListPanel.SuspendLayout()
        Me.JudulPanel.SuspendLayout()
        Me.UpperContentPanel.SuspendLayout()
        Me.ContentPanelBg.SuspendLayout()
        Me.InboxPanel.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserPanel.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.TitleBarPanel.SuspendLayout()
        Me.ControlPanel.SuspendLayout()
        Me.ContentPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListPanel
        '
        Me.ListPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ListPanel.Controls.Add(Me.LogoutButton)
        Me.ListPanel.Controls.Add(Me.RegistrasiAdminButton)
        Me.ListPanel.Controls.Add(Me.RegistrasiUserButton)
        Me.ListPanel.Controls.Add(Me.UploadJadwalButton)
        Me.ListPanel.Controls.Add(Me.UserProfileButton)
        Me.ListPanel.Controls.Add(Me.DashboardButton)
        Me.ListPanel.Controls.Add(Me.JudulPanel)
        Me.ListPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.ListPanel.Location = New System.Drawing.Point(0, 0)
        Me.ListPanel.Name = "ListPanel"
        Me.ListPanel.ShadowDecoration.Parent = Me.ListPanel
        Me.ListPanel.Size = New System.Drawing.Size(441, 1024)
        Me.ListPanel.TabIndex = 9
        '
        'LogoutButton
        '
        Me.LogoutButton.BorderRadius = 30
        Me.LogoutButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.LogoutButton.CheckedState.Parent = Me.LogoutButton
        Me.LogoutButton.CustomImages.Parent = Me.LogoutButton
        Me.LogoutButton.DisabledState.Parent = Me.LogoutButton
        Me.LogoutButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.LogoutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.LogoutButton.HoverState.Parent = Me.LogoutButton
        Me.LogoutButton.Image = CType(resources.GetObject("LogoutButton.Image"), System.Drawing.Image)
        Me.LogoutButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.LogoutButton.ImageSize = New System.Drawing.Size(40, 40)
        Me.LogoutButton.Location = New System.Drawing.Point(130, 880)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.ShadowDecoration.Parent = Me.LogoutButton
        Me.LogoutButton.Size = New System.Drawing.Size(143, 59)
        Me.LogoutButton.TabIndex = 7
        Me.LogoutButton.Text = "Logout"
        Me.LogoutButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RegistrasiAdminButton
        '
        Me.RegistrasiAdminButton.BorderRadius = 30
        Me.RegistrasiAdminButton.Checked = True
        Me.RegistrasiAdminButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.RegistrasiAdminButton.CheckedState.Parent = Me.RegistrasiAdminButton
        Me.RegistrasiAdminButton.CustomImages.Parent = Me.RegistrasiAdminButton
        Me.RegistrasiAdminButton.DisabledState.Parent = Me.RegistrasiAdminButton
        Me.RegistrasiAdminButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.RegistrasiAdminButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!)
        Me.RegistrasiAdminButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.RegistrasiAdminButton.HoverState.Parent = Me.RegistrasiAdminButton
        Me.RegistrasiAdminButton.Image = Global.MyDu.My.Resources.Resources.admin__1_
        Me.RegistrasiAdminButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.RegistrasiAdminButton.ImageOffset = New System.Drawing.Point(60, 0)
        Me.RegistrasiAdminButton.ImageSize = New System.Drawing.Size(40, 40)
        Me.RegistrasiAdminButton.Location = New System.Drawing.Point(12, 609)
        Me.RegistrasiAdminButton.Name = "RegistrasiAdminButton"
        Me.RegistrasiAdminButton.ShadowDecoration.Parent = Me.RegistrasiAdminButton
        Me.RegistrasiAdminButton.Size = New System.Drawing.Size(423, 87)
        Me.RegistrasiAdminButton.TabIndex = 5
        Me.RegistrasiAdminButton.Text = "Registrasi Admin"
        Me.RegistrasiAdminButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.RegistrasiAdminButton.TextOffset = New System.Drawing.Point(75, 0)
        '
        'RegistrasiUserButton
        '
        Me.RegistrasiUserButton.BorderRadius = 30
        Me.RegistrasiUserButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.RegistrasiUserButton.CheckedState.Parent = Me.RegistrasiUserButton
        Me.RegistrasiUserButton.CustomImages.Parent = Me.RegistrasiUserButton
        Me.RegistrasiUserButton.DisabledState.Parent = Me.RegistrasiUserButton
        Me.RegistrasiUserButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.RegistrasiUserButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!)
        Me.RegistrasiUserButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.RegistrasiUserButton.HoverState.Parent = Me.RegistrasiUserButton
        Me.RegistrasiUserButton.Image = Global.MyDu.My.Resources.Resources.edit__1_
        Me.RegistrasiUserButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.RegistrasiUserButton.ImageOffset = New System.Drawing.Point(60, 0)
        Me.RegistrasiUserButton.ImageSize = New System.Drawing.Size(40, 40)
        Me.RegistrasiUserButton.Location = New System.Drawing.Point(12, 516)
        Me.RegistrasiUserButton.Name = "RegistrasiUserButton"
        Me.RegistrasiUserButton.PressedColor = System.Drawing.Color.Azure
        Me.RegistrasiUserButton.ShadowDecoration.Parent = Me.RegistrasiUserButton
        Me.RegistrasiUserButton.Size = New System.Drawing.Size(423, 87)
        Me.RegistrasiUserButton.TabIndex = 4
        Me.RegistrasiUserButton.Text = "Registrasi User"
        Me.RegistrasiUserButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.RegistrasiUserButton.TextOffset = New System.Drawing.Point(75, 0)
        '
        'UploadJadwalButton
        '
        Me.UploadJadwalButton.BorderRadius = 30
        Me.UploadJadwalButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.UploadJadwalButton.CheckedState.Parent = Me.UploadJadwalButton
        Me.UploadJadwalButton.CustomImages.Parent = Me.UploadJadwalButton
        Me.UploadJadwalButton.DisabledState.Parent = Me.UploadJadwalButton
        Me.UploadJadwalButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.UploadJadwalButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!)
        Me.UploadJadwalButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.UploadJadwalButton.HoverState.Parent = Me.UploadJadwalButton
        Me.UploadJadwalButton.Image = CType(resources.GetObject("UploadJadwalButton.Image"), System.Drawing.Image)
        Me.UploadJadwalButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.UploadJadwalButton.ImageOffset = New System.Drawing.Point(60, 0)
        Me.UploadJadwalButton.ImageSize = New System.Drawing.Size(40, 40)
        Me.UploadJadwalButton.Location = New System.Drawing.Point(12, 423)
        Me.UploadJadwalButton.Name = "UploadJadwalButton"
        Me.UploadJadwalButton.ShadowDecoration.Parent = Me.UploadJadwalButton
        Me.UploadJadwalButton.Size = New System.Drawing.Size(423, 87)
        Me.UploadJadwalButton.TabIndex = 3
        Me.UploadJadwalButton.Text = "Upload Jadwal"
        Me.UploadJadwalButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.UploadJadwalButton.TextOffset = New System.Drawing.Point(75, 0)
        '
        'UserProfileButton
        '
        Me.UserProfileButton.BorderRadius = 30
        Me.UserProfileButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.UserProfileButton.CheckedState.Image = Global.MyDu.My.Resources.Resources.user__3_
        Me.UserProfileButton.CheckedState.Parent = Me.UserProfileButton
        Me.UserProfileButton.CustomImages.Parent = Me.UserProfileButton
        Me.UserProfileButton.DisabledState.Parent = Me.UserProfileButton
        Me.UserProfileButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.UserProfileButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!)
        Me.UserProfileButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.UserProfileButton.HoverState.Parent = Me.UserProfileButton
        Me.UserProfileButton.Image = CType(resources.GetObject("UserProfileButton.Image"), System.Drawing.Image)
        Me.UserProfileButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.UserProfileButton.ImageOffset = New System.Drawing.Point(60, 0)
        Me.UserProfileButton.ImageSize = New System.Drawing.Size(40, 40)
        Me.UserProfileButton.Location = New System.Drawing.Point(12, 330)
        Me.UserProfileButton.Name = "UserProfileButton"
        Me.UserProfileButton.ShadowDecoration.Parent = Me.UserProfileButton
        Me.UserProfileButton.Size = New System.Drawing.Size(423, 87)
        Me.UserProfileButton.TabIndex = 2
        Me.UserProfileButton.Text = "User Profile"
        Me.UserProfileButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.UserProfileButton.TextOffset = New System.Drawing.Point(75, 0)
        '
        'DashboardButton
        '
        Me.DashboardButton.BorderRadius = 30
        Me.DashboardButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.DashboardButton.CheckedState.Parent = Me.DashboardButton
        Me.DashboardButton.CustomImages.Parent = Me.DashboardButton
        Me.DashboardButton.DisabledState.Parent = Me.DashboardButton
        Me.DashboardButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.DashboardButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!)
        Me.DashboardButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.DashboardButton.HoverState.Parent = Me.DashboardButton
        Me.DashboardButton.Image = CType(resources.GetObject("DashboardButton.Image"), System.Drawing.Image)
        Me.DashboardButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.DashboardButton.ImageOffset = New System.Drawing.Point(60, 0)
        Me.DashboardButton.ImageSize = New System.Drawing.Size(40, 40)
        Me.DashboardButton.Location = New System.Drawing.Point(12, 237)
        Me.DashboardButton.Name = "DashboardButton"
        Me.DashboardButton.ShadowDecoration.Parent = Me.DashboardButton
        Me.DashboardButton.Size = New System.Drawing.Size(423, 87)
        Me.DashboardButton.TabIndex = 1
        Me.DashboardButton.Text = "Dashboard"
        Me.DashboardButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.DashboardButton.TextOffset = New System.Drawing.Point(75, 0)
        '
        'JudulPanel
        '
        Me.JudulPanel.Controls.Add(Me.JudulLabel)
        Me.JudulPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.JudulPanel.Location = New System.Drawing.Point(0, 0)
        Me.JudulPanel.Name = "JudulPanel"
        Me.JudulPanel.ShadowDecoration.Parent = Me.JudulPanel
        Me.JudulPanel.Size = New System.Drawing.Size(441, 178)
        Me.JudulPanel.TabIndex = 0
        '
        'JudulLabel
        '
        Me.JudulLabel.AutoSize = True
        Me.JudulLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold)
        Me.JudulLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.JudulLabel.Location = New System.Drawing.Point(137, 53)
        Me.JudulLabel.Name = "JudulLabel"
        Me.JudulLabel.Size = New System.Drawing.Size(162, 55)
        Me.JudulLabel.TabIndex = 2
        Me.JudulLabel.Text = "myDU"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'UpperContentPanel
        '
        Me.UpperContentPanel.Controls.Add(Me.ContentPanelBg)
        Me.UpperContentPanel.Controls.Add(Me.UserPanel)
        Me.UpperContentPanel.Controls.Add(Me.TitleBarPanel)
        Me.UpperContentPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.UpperContentPanel.Location = New System.Drawing.Point(0, 0)
        Me.UpperContentPanel.Name = "UpperContentPanel"
        Me.UpperContentPanel.ShadowDecoration.Parent = Me.UpperContentPanel
        Me.UpperContentPanel.Size = New System.Drawing.Size(999, 983)
        Me.UpperContentPanel.TabIndex = 1
        '
        'ContentPanelBg
        '
        Me.ContentPanelBg.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ContentPanelBg.BorderColor = System.Drawing.Color.Black
        Me.ContentPanelBg.BorderRadius = 10
        Me.ContentPanelBg.BorderThickness = 1
        Me.ContentPanelBg.Controls.Add(Me.Inboxbutton)
        Me.ContentPanelBg.Controls.Add(Me.InboxPanel)
        Me.ContentPanelBg.Controls.Add(Me.ProdiCombo)
        Me.ContentPanelBg.Controls.Add(Me.RankCombo)
        Me.ContentPanelBg.Controls.Add(Me.Username)
        Me.ContentPanelBg.Controls.Add(Me.TambahAdmin)
        Me.ContentPanelBg.Controls.Add(Me.Password)
        Me.ContentPanelBg.Controls.Add(Me.Email)
        Me.ContentPanelBg.Controls.Add(Me.NIMNRPTextBox)
        Me.ContentPanelBg.Controls.Add(Me.NamaLengkapTextBox)
        Me.ContentPanelBg.Controls.Add(Me.TambahDataAdmin)
        Me.ContentPanelBg.Location = New System.Drawing.Point(44, 201)
        Me.ContentPanelBg.Name = "ContentPanelBg"
        Me.ContentPanelBg.ShadowDecoration.Parent = Me.ContentPanelBg
        Me.ContentPanelBg.Size = New System.Drawing.Size(925, 768)
        Me.ContentPanelBg.TabIndex = 10
        '
        'Inboxbutton
        '
        Me.Inboxbutton.BorderRadius = 10
        Me.Inboxbutton.CheckedState.Parent = Me.Inboxbutton
        Me.Inboxbutton.CustomImages.Parent = Me.Inboxbutton
        Me.Inboxbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Inboxbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Inboxbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Inboxbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Inboxbutton.DisabledState.Parent = Me.Inboxbutton
        Me.Inboxbutton.FillColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Inboxbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Inboxbutton.ForeColor = System.Drawing.Color.White
        Me.Inboxbutton.HoverState.Parent = Me.Inboxbutton
        Me.Inboxbutton.Location = New System.Drawing.Point(371, 36)
        Me.Inboxbutton.Name = "Inboxbutton"
        Me.Inboxbutton.ShadowDecoration.Parent = Me.Inboxbutton
        Me.Inboxbutton.Size = New System.Drawing.Size(105, 45)
        Me.Inboxbutton.TabIndex = 29
        Me.Inboxbutton.Text = "Inbox"
        '
        'InboxPanel
        '
        Me.InboxPanel.BackColor = System.Drawing.Color.Transparent
        Me.InboxPanel.BorderRadius = 15
        Me.InboxPanel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.InboxPanel.Controls.Add(Me.NumericUpDown1)
        Me.InboxPanel.Controls.Add(Me.Guna2Button2)
        Me.InboxPanel.Controls.Add(Me.Guna2Button1)
        Me.InboxPanel.Controls.Add(Me.Label1)
        Me.InboxPanel.Controls.Add(Me.Inboxlabel)
        Me.InboxPanel.Controls.Add(Me.Data5)
        Me.InboxPanel.Controls.Add(Me.Data4)
        Me.InboxPanel.Controls.Add(Me.Data3)
        Me.InboxPanel.Controls.Add(Me.Data2)
        Me.InboxPanel.Controls.Add(Me.Data1)
        Me.InboxPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.InboxPanel.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.InboxPanel.Location = New System.Drawing.Point(534, 36)
        Me.InboxPanel.Name = "InboxPanel"
        Me.InboxPanel.ShadowDecoration.Parent = Me.InboxPanel
        Me.InboxPanel.Size = New System.Drawing.Size(349, 639)
        Me.InboxPanel.TabIndex = 28
        Me.InboxPanel.Visible = False
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.NumericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NumericUpDown1.Location = New System.Drawing.Point(172, 441)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(73, 36)
        Me.NumericUpDown1.TabIndex = 19
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Guna2Button2
        '
        Me.Guna2Button2.BorderRadius = 10
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.DisabledState.Parent = Me.Guna2Button2
        Me.Guna2Button2.FillColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Location = New System.Drawing.Point(189, 506)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(131, 88)
        Me.Guna2Button2.TabIndex = 18
        Me.Guna2Button2.Text = "Delete"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderRadius = 10
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.DisabledState.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(33, 506)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(131, 88)
        Me.Guna2Button1.TabIndex = 17
        Me.Guna2Button1.Text = "Deploy"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(91, 450)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Page"
        '
        'Inboxlabel
        '
        Me.Inboxlabel.AutoSize = True
        Me.Inboxlabel.BackColor = System.Drawing.Color.Transparent
        Me.Inboxlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Inboxlabel.ForeColor = System.Drawing.Color.White
        Me.Inboxlabel.Location = New System.Drawing.Point(35, 32)
        Me.Inboxlabel.Name = "Inboxlabel"
        Me.Inboxlabel.Size = New System.Drawing.Size(99, 37)
        Me.Inboxlabel.TabIndex = 6
        Me.Inboxlabel.Text = "Inbox"
        '
        'Data5
        '
        Me.Data5.AutoSize = True
        Me.Data5.BackColor = System.Drawing.Color.Transparent
        Me.Data5.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Data5.CheckedState.BorderThickness = 0
        Me.Data5.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Data5.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Data5.CheckedState.InnerOffset = -4
        Me.Data5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Data5.Location = New System.Drawing.Point(42, 365)
        Me.Data5.Name = "Data5"
        Me.Data5.Size = New System.Drawing.Size(14, 13)
        Me.Data5.TabIndex = 5
        Me.Data5.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Data5.UncheckedState.BorderThickness = 2
        Me.Data5.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Data5.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.Data5.UseVisualStyleBackColor = False
        '
        'Data4
        '
        Me.Data4.AutoSize = True
        Me.Data4.BackColor = System.Drawing.Color.Transparent
        Me.Data4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Data4.CheckedState.BorderThickness = 0
        Me.Data4.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Data4.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Data4.CheckedState.InnerOffset = -4
        Me.Data4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Data4.Location = New System.Drawing.Point(42, 318)
        Me.Data4.Name = "Data4"
        Me.Data4.Size = New System.Drawing.Size(14, 13)
        Me.Data4.TabIndex = 4
        Me.Data4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Data4.UncheckedState.BorderThickness = 2
        Me.Data4.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Data4.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.Data4.UseVisualStyleBackColor = False
        '
        'Data3
        '
        Me.Data3.AutoSize = True
        Me.Data3.BackColor = System.Drawing.Color.Transparent
        Me.Data3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Data3.CheckedState.BorderThickness = 0
        Me.Data3.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Data3.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Data3.CheckedState.InnerOffset = -4
        Me.Data3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Data3.Location = New System.Drawing.Point(42, 271)
        Me.Data3.Name = "Data3"
        Me.Data3.Size = New System.Drawing.Size(14, 13)
        Me.Data3.TabIndex = 3
        Me.Data3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Data3.UncheckedState.BorderThickness = 2
        Me.Data3.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Data3.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.Data3.UseVisualStyleBackColor = False
        '
        'Data2
        '
        Me.Data2.AutoSize = True
        Me.Data2.BackColor = System.Drawing.Color.Transparent
        Me.Data2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Data2.CheckedState.BorderThickness = 0
        Me.Data2.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Data2.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Data2.CheckedState.InnerOffset = -4
        Me.Data2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Data2.Location = New System.Drawing.Point(42, 224)
        Me.Data2.Name = "Data2"
        Me.Data2.Size = New System.Drawing.Size(14, 13)
        Me.Data2.TabIndex = 2
        Me.Data2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Data2.UncheckedState.BorderThickness = 2
        Me.Data2.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Data2.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.Data2.UseVisualStyleBackColor = False
        '
        'Data1
        '
        Me.Data1.AutoSize = True
        Me.Data1.BackColor = System.Drawing.Color.Transparent
        Me.Data1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Data1.CheckedState.BorderThickness = 0
        Me.Data1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Data1.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Data1.CheckedState.InnerOffset = -4
        Me.Data1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Data1.Location = New System.Drawing.Point(42, 177)
        Me.Data1.Name = "Data1"
        Me.Data1.Size = New System.Drawing.Size(14, 13)
        Me.Data1.TabIndex = 1
        Me.Data1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Data1.UncheckedState.BorderThickness = 2
        Me.Data1.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Data1.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.Data1.UseVisualStyleBackColor = False
        '
        'ProdiCombo
        '
        Me.ProdiCombo.BackColor = System.Drawing.Color.Transparent
        Me.ProdiCombo.BorderRadius = 10
        Me.ProdiCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ProdiCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ProdiCombo.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProdiCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProdiCombo.FocusedState.Parent = Me.ProdiCombo
        Me.ProdiCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.ProdiCombo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.ProdiCombo.HoverState.Parent = Me.ProdiCombo
        Me.ProdiCombo.ItemHeight = 49
        Me.ProdiCombo.ItemsAppearance.Parent = Me.ProdiCombo
        Me.ProdiCombo.Location = New System.Drawing.Point(80, 510)
        Me.ProdiCombo.Name = "ProdiCombo"
        Me.ProdiCombo.ShadowDecoration.Parent = Me.ProdiCombo
        Me.ProdiCombo.Size = New System.Drawing.Size(396, 55)
        Me.ProdiCombo.TabIndex = 19
        '
        'RankCombo
        '
        Me.RankCombo.BackColor = System.Drawing.Color.Transparent
        Me.RankCombo.BorderRadius = 10
        Me.RankCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.RankCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RankCombo.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RankCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RankCombo.FocusedState.Parent = Me.RankCombo
        Me.RankCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.RankCombo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.RankCombo.HoverState.Parent = Me.RankCombo
        Me.RankCombo.ItemHeight = 49
        Me.RankCombo.ItemsAppearance.Parent = Me.RankCombo
        Me.RankCombo.Location = New System.Drawing.Point(80, 440)
        Me.RankCombo.Name = "RankCombo"
        Me.RankCombo.ShadowDecoration.Parent = Me.RankCombo
        Me.RankCombo.Size = New System.Drawing.Size(396, 55)
        Me.RankCombo.TabIndex = 18
        '
        'Username
        '
        Me.Username.BorderRadius = 10
        Me.Username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Username.DefaultText = ""
        Me.Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Username.DisabledState.Parent = Me.Username
        Me.Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Username.FocusedState.Parent = Me.Username
        Me.Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Username.HoverState.Parent = Me.Username
        Me.Username.Location = New System.Drawing.Point(80, 301)
        Me.Username.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Username.Name = "Username"
        Me.Username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Username.PlaceholderText = "Username"
        Me.Username.SelectedText = ""
        Me.Username.ShadowDecoration.Parent = Me.Username
        Me.Username.Size = New System.Drawing.Size(396, 55)
        Me.Username.TabIndex = 17
        Me.Username.TextOffset = New System.Drawing.Point(20, 0)
        '
        'TambahAdmin
        '
        Me.TambahAdmin.BorderRadius = 10
        Me.TambahAdmin.CheckedState.Parent = Me.TambahAdmin
        Me.TambahAdmin.CustomImages.Parent = Me.TambahAdmin
        Me.TambahAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.TambahAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.TambahAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.TambahAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.TambahAdmin.DisabledState.Parent = Me.TambahAdmin
        Me.TambahAdmin.FillColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TambahAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.TambahAdmin.ForeColor = System.Drawing.Color.White
        Me.TambahAdmin.HoverState.Parent = Me.TambahAdmin
        Me.TambahAdmin.Location = New System.Drawing.Point(80, 628)
        Me.TambahAdmin.Name = "TambahAdmin"
        Me.TambahAdmin.ShadowDecoration.Parent = Me.TambahAdmin
        Me.TambahAdmin.Size = New System.Drawing.Size(396, 55)
        Me.TambahAdmin.TabIndex = 16
        Me.TambahAdmin.Text = "Add Admin"
        '
        'Password
        '
        Me.Password.BorderRadius = 10
        Me.Password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Password.DefaultText = ""
        Me.Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Password.DisabledState.Parent = Me.Password
        Me.Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Password.FocusedState.Parent = Me.Password
        Me.Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Password.HoverState.Parent = Me.Password
        Me.Password.Location = New System.Drawing.Point(80, 368)
        Me.Password.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Password.PlaceholderText = "Password"
        Me.Password.SelectedText = ""
        Me.Password.ShadowDecoration.Parent = Me.Password
        Me.Password.Size = New System.Drawing.Size(396, 55)
        Me.Password.TabIndex = 15
        Me.Password.TextOffset = New System.Drawing.Point(20, 0)
        Me.Password.UseSystemPasswordChar = True
        '
        'Email
        '
        Me.Email.BorderRadius = 10
        Me.Email.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Email.DefaultText = ""
        Me.Email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Email.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Email.DisabledState.Parent = Me.Email
        Me.Email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Email.FocusedState.Parent = Me.Email
        Me.Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Email.ForeColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Email.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Email.HoverState.Parent = Me.Email
        Me.Email.Location = New System.Drawing.Point(80, 234)
        Me.Email.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Email.Name = "Email"
        Me.Email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Email.PlaceholderText = "Email"
        Me.Email.SelectedText = ""
        Me.Email.ShadowDecoration.Parent = Me.Email
        Me.Email.Size = New System.Drawing.Size(396, 55)
        Me.Email.TabIndex = 14
        Me.Email.TextOffset = New System.Drawing.Point(20, 0)
        '
        'NIMNRPTextBox
        '
        Me.NIMNRPTextBox.BorderRadius = 10
        Me.NIMNRPTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NIMNRPTextBox.DefaultText = ""
        Me.NIMNRPTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.NIMNRPTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.NIMNRPTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NIMNRPTextBox.DisabledState.Parent = Me.NIMNRPTextBox
        Me.NIMNRPTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NIMNRPTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NIMNRPTextBox.FocusedState.Parent = Me.NIMNRPTextBox
        Me.NIMNRPTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.NIMNRPTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.NIMNRPTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NIMNRPTextBox.HoverState.Parent = Me.NIMNRPTextBox
        Me.NIMNRPTextBox.Location = New System.Drawing.Point(80, 167)
        Me.NIMNRPTextBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.NIMNRPTextBox.Name = "NIMNRPTextBox"
        Me.NIMNRPTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NIMNRPTextBox.PlaceholderText = "NIM/NRP"
        Me.NIMNRPTextBox.SelectedText = ""
        Me.NIMNRPTextBox.ShadowDecoration.Parent = Me.NIMNRPTextBox
        Me.NIMNRPTextBox.Size = New System.Drawing.Size(396, 55)
        Me.NIMNRPTextBox.TabIndex = 10
        Me.NIMNRPTextBox.TextOffset = New System.Drawing.Point(20, 0)
        '
        'NamaLengkapTextBox
        '
        Me.NamaLengkapTextBox.BorderRadius = 10
        Me.NamaLengkapTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NamaLengkapTextBox.DefaultText = ""
        Me.NamaLengkapTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.NamaLengkapTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.NamaLengkapTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NamaLengkapTextBox.DisabledState.Parent = Me.NamaLengkapTextBox
        Me.NamaLengkapTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NamaLengkapTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NamaLengkapTextBox.FocusedState.Parent = Me.NamaLengkapTextBox
        Me.NamaLengkapTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.NamaLengkapTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.NamaLengkapTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NamaLengkapTextBox.HoverState.Parent = Me.NamaLengkapTextBox
        Me.NamaLengkapTextBox.Location = New System.Drawing.Point(80, 100)
        Me.NamaLengkapTextBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.NamaLengkapTextBox.Name = "NamaLengkapTextBox"
        Me.NamaLengkapTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NamaLengkapTextBox.PlaceholderText = "Nama Lengkap"
        Me.NamaLengkapTextBox.SelectedText = ""
        Me.NamaLengkapTextBox.ShadowDecoration.Parent = Me.NamaLengkapTextBox
        Me.NamaLengkapTextBox.Size = New System.Drawing.Size(396, 55)
        Me.NamaLengkapTextBox.TabIndex = 9
        Me.NamaLengkapTextBox.TextOffset = New System.Drawing.Point(20, 0)
        '
        'TambahDataAdmin
        '
        Me.TambahDataAdmin.AutoSize = True
        Me.TambahDataAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold)
        Me.TambahDataAdmin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.TambahDataAdmin.Location = New System.Drawing.Point(31, 13)
        Me.TambahDataAdmin.Name = "TambahDataAdmin"
        Me.TambahDataAdmin.Size = New System.Drawing.Size(301, 36)
        Me.TambahDataAdmin.TabIndex = 8
        Me.TambahDataAdmin.Text = "Tambah Data Admin"
        '
        'UserPanel
        '
        Me.UserPanel.Controls.Add(Me.Guna2Panel1)
        Me.UserPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.UserPanel.Location = New System.Drawing.Point(0, 47)
        Me.UserPanel.Name = "UserPanel"
        Me.UserPanel.ShadowDecoration.Parent = Me.UserPanel
        Me.UserPanel.Size = New System.Drawing.Size(999, 100)
        Me.UserPanel.TabIndex = 0
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.UserLabel)
        Me.Guna2Panel1.Controls.Add(Me.UserPhoto)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(999, 100)
        Me.Guna2Panel1.TabIndex = 1
        '
        'UserLabel
        '
        Me.UserLabel.AutoSize = True
        Me.UserLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserLabel.ForeColor = System.Drawing.Color.Black
        Me.UserLabel.Location = New System.Drawing.Point(833, 35)
        Me.UserLabel.Name = "UserLabel"
        Me.UserLabel.Size = New System.Drawing.Size(136, 24)
        Me.UserLabel.TabIndex = 3
        Me.UserLabel.Text = "Emirul Mukmin"
        '
        'UserPhoto
        '
        Me.UserPhoto.CheckedState.ImageSize = New System.Drawing.Size(60, 60)
        Me.UserPhoto.CheckedState.Parent = Me.UserPhoto
        Me.UserPhoto.HoverState.ImageSize = New System.Drawing.Size(60, 60)
        Me.UserPhoto.HoverState.Parent = Me.UserPhoto
        Me.UserPhoto.Image = CType(resources.GetObject("UserPhoto.Image"), System.Drawing.Image)
        Me.UserPhoto.ImageOffset = New System.Drawing.Point(0, 0)
        Me.UserPhoto.ImageRotate = 0!
        Me.UserPhoto.ImageSize = New System.Drawing.Size(60, 60)
        Me.UserPhoto.Location = New System.Drawing.Point(754, 15)
        Me.UserPhoto.Name = "UserPhoto"
        Me.UserPhoto.PressedState.Parent = Me.UserPhoto
        Me.UserPhoto.ShadowDecoration.Parent = Me.UserPhoto
        Me.UserPhoto.Size = New System.Drawing.Size(73, 67)
        Me.UserPhoto.TabIndex = 0
        '
        'TitleBarPanel
        '
        Me.TitleBarPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.TitleBarPanel.Controls.Add(Me.ControlPanel)
        Me.TitleBarPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleBarPanel.Location = New System.Drawing.Point(0, 0)
        Me.TitleBarPanel.Name = "TitleBarPanel"
        Me.TitleBarPanel.ShadowDecoration.Parent = Me.TitleBarPanel
        Me.TitleBarPanel.Size = New System.Drawing.Size(999, 47)
        Me.TitleBarPanel.TabIndex = 7
        '
        'ControlPanel
        '
        Me.ControlPanel.Controls.Add(Me.MinimazeControlBox)
        Me.ControlPanel.Controls.Add(Me.CloseControlBox)
        Me.ControlPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.ControlPanel.Location = New System.Drawing.Point(799, 0)
        Me.ControlPanel.Name = "ControlPanel"
        Me.ControlPanel.ShadowDecoration.Parent = Me.ControlPanel
        Me.ControlPanel.Size = New System.Drawing.Size(200, 47)
        Me.ControlPanel.TabIndex = 0
        '
        'MinimazeControlBox
        '
        Me.MinimazeControlBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MinimazeControlBox.BorderRadius = 20
        Me.MinimazeControlBox.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.MinimazeControlBox.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.MinimazeControlBox.HoverState.Parent = Me.MinimazeControlBox
        Me.MinimazeControlBox.IconColor = System.Drawing.Color.Olive
        Me.MinimazeControlBox.Location = New System.Drawing.Point(110, 3)
        Me.MinimazeControlBox.Name = "MinimazeControlBox"
        Me.MinimazeControlBox.ShadowDecoration.Parent = Me.MinimazeControlBox
        Me.MinimazeControlBox.Size = New System.Drawing.Size(36, 38)
        Me.MinimazeControlBox.TabIndex = 1
        '
        'CloseControlBox
        '
        Me.CloseControlBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseControlBox.BorderRadius = 20
        Me.CloseControlBox.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.CloseControlBox.HoverState.Parent = Me.CloseControlBox
        Me.CloseControlBox.IconColor = System.Drawing.Color.Red
        Me.CloseControlBox.Location = New System.Drawing.Point(152, 3)
        Me.CloseControlBox.Name = "CloseControlBox"
        Me.CloseControlBox.ShadowDecoration.Parent = Me.CloseControlBox
        Me.CloseControlBox.Size = New System.Drawing.Size(36, 38)
        Me.CloseControlBox.TabIndex = 0
        '
        'ContentPanel
        '
        Me.ContentPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ContentPanel.Controls.Add(Me.UpperContentPanel)
        Me.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContentPanel.Location = New System.Drawing.Point(441, 0)
        Me.ContentPanel.Name = "ContentPanel"
        Me.ContentPanel.Size = New System.Drawing.Size(999, 1024)
        Me.ContentPanel.TabIndex = 10
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HOR_NEGATIVE
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'RegistrasiAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1440, 1024)
        Me.Controls.Add(Me.ContentPanel)
        Me.Controls.Add(Me.ListPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegistrasiAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegistrasiAdmin"
        Me.ListPanel.ResumeLayout(False)
        Me.JudulPanel.ResumeLayout(False)
        Me.JudulPanel.PerformLayout()
        Me.UpperContentPanel.ResumeLayout(False)
        Me.ContentPanelBg.ResumeLayout(False)
        Me.ContentPanelBg.PerformLayout()
        Me.InboxPanel.ResumeLayout(False)
        Me.InboxPanel.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UserPanel.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.TitleBarPanel.ResumeLayout(False)
        Me.ControlPanel.ResumeLayout(False)
        Me.ContentPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LogoutButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents RegistrasiAdminButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents RegistrasiUserButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents UploadJadwalButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents UserProfileButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DashboardButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents JudulPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents JudulLabel As Label
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents ContentPanel As Panel
    Friend WithEvents UpperContentPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents UserPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TitleBarPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ControlPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents MinimazeControlBox As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents CloseControlBox As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents ContentPanelBg As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TambahAdmin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Email As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents NIMNRPTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents NamaLengkapTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TambahDataAdmin As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents UserLabel As Label
    Friend WithEvents UserPhoto As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ProdiCombo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents RankCombo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents InboxPanel As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Inboxlabel As Label
    Friend WithEvents Data5 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Data4 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Data3 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Data2 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Data1 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Inboxbutton As Guna.UI2.WinForms.Guna2Button
End Class
