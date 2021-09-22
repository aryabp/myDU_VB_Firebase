<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrasiAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
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
        Me.TambahAdmin = New Guna.UI2.WinForms.Guna2Button()
        Me.Password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Email = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CariJabatan = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CariProdiSatuan = New Guna.UI2.WinForms.Guna2TextBox()
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
        Me.ListPanel.SuspendLayout()
        Me.JudulPanel.SuspendLayout()
        Me.UpperContentPanel.SuspendLayout()
        Me.ContentPanelBg.SuspendLayout()
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
        Me.LogoutButton.Font = New System.Drawing.Font("Ubuntu", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.RegistrasiAdminButton.Font = New System.Drawing.Font("Ubuntu", 21.75!)
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
        Me.RegistrasiUserButton.Font = New System.Drawing.Font("Ubuntu", 21.75!)
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
        Me.UploadJadwalButton.Font = New System.Drawing.Font("Ubuntu", 21.75!)
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
        Me.UserProfileButton.Font = New System.Drawing.Font("Ubuntu", 22.0!)
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
        Me.DashboardButton.Font = New System.Drawing.Font("Ubuntu", 21.75!)
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
        Me.JudulLabel.Font = New System.Drawing.Font("Ubuntu", 36.0!, System.Drawing.FontStyle.Bold)
        Me.JudulLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.JudulLabel.Location = New System.Drawing.Point(137, 53)
        Me.JudulLabel.Name = "JudulLabel"
        Me.JudulLabel.Size = New System.Drawing.Size(160, 56)
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
        Me.ContentPanelBg.Controls.Add(Me.TambahAdmin)
        Me.ContentPanelBg.Controls.Add(Me.Password)
        Me.ContentPanelBg.Controls.Add(Me.Email)
        Me.ContentPanelBg.Controls.Add(Me.CariJabatan)
        Me.ContentPanelBg.Controls.Add(Me.CariProdiSatuan)
        Me.ContentPanelBg.Controls.Add(Me.NIMNRPTextBox)
        Me.ContentPanelBg.Controls.Add(Me.NamaLengkapTextBox)
        Me.ContentPanelBg.Controls.Add(Me.TambahDataAdmin)
        Me.ContentPanelBg.Location = New System.Drawing.Point(44, 201)
        Me.ContentPanelBg.Name = "ContentPanelBg"
        Me.ContentPanelBg.ShadowDecoration.Parent = Me.ContentPanelBg
        Me.ContentPanelBg.Size = New System.Drawing.Size(925, 768)
        Me.ContentPanelBg.TabIndex = 10
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
        Me.TambahAdmin.Font = New System.Drawing.Font("Ubuntu", 18.0!)
        Me.TambahAdmin.ForeColor = System.Drawing.Color.White
        Me.TambahAdmin.HoverState.Parent = Me.TambahAdmin
        Me.TambahAdmin.Location = New System.Drawing.Point(80, 596)
        Me.TambahAdmin.Name = "TambahAdmin"
        Me.TambahAdmin.ShadowDecoration.Parent = Me.TambahAdmin
        Me.TambahAdmin.Size = New System.Drawing.Size(396, 55)
        Me.TambahAdmin.TabIndex = 16
        Me.TambahAdmin.Text = "Tambah Admin"
        '
        'Password
        '
        Me.Password.BorderRadius = 10
        Me.Password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Password.DefaultText = "Password"
        Me.Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Password.DisabledState.Parent = Me.Password
        Me.Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Password.FocusedState.Parent = Me.Password
        Me.Password.Font = New System.Drawing.Font("Ubuntu", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Password.HoverState.Parent = Me.Password
        Me.Password.Location = New System.Drawing.Point(80, 516)
        Me.Password.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Password.PlaceholderText = ""
        Me.Password.SelectedText = ""
        Me.Password.SelectionStart = 8
        Me.Password.ShadowDecoration.Parent = Me.Password
        Me.Password.Size = New System.Drawing.Size(396, 55)
        Me.Password.TabIndex = 15
        Me.Password.TextOffset = New System.Drawing.Point(20, 0)
        '
        'Email
        '
        Me.Email.BorderRadius = 10
        Me.Email.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Email.DefaultText = "Email"
        Me.Email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Email.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Email.DisabledState.Parent = Me.Email
        Me.Email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Email.FocusedState.Parent = Me.Email
        Me.Email.Font = New System.Drawing.Font("Ubuntu", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.ForeColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.Email.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Email.HoverState.Parent = Me.Email
        Me.Email.Location = New System.Drawing.Point(80, 441)
        Me.Email.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Email.Name = "Email"
        Me.Email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Email.PlaceholderText = ""
        Me.Email.SelectedText = ""
        Me.Email.SelectionStart = 5
        Me.Email.ShadowDecoration.Parent = Me.Email
        Me.Email.Size = New System.Drawing.Size(396, 55)
        Me.Email.TabIndex = 14
        Me.Email.TextOffset = New System.Drawing.Point(20, 0)
        '
        'CariJabatan
        '
        Me.CariJabatan.BorderRadius = 10
        Me.CariJabatan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CariJabatan.DefaultText = "Cari Jabatan"
        Me.CariJabatan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CariJabatan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CariJabatan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CariJabatan.DisabledState.Parent = Me.CariJabatan
        Me.CariJabatan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CariJabatan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CariJabatan.FocusedState.Parent = Me.CariJabatan
        Me.CariJabatan.Font = New System.Drawing.Font("Ubuntu", 18.0!)
        Me.CariJabatan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.CariJabatan.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CariJabatan.HoverState.Parent = Me.CariJabatan
        Me.CariJabatan.IconLeft = Global.MyDu.My.Resources.Resources.magnifyingglass
        Me.CariJabatan.IconLeftOffset = New System.Drawing.Point(20, 0)
        Me.CariJabatan.Location = New System.Drawing.Point(80, 358)
        Me.CariJabatan.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.CariJabatan.Name = "CariJabatan"
        Me.CariJabatan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CariJabatan.PlaceholderText = ""
        Me.CariJabatan.SelectedText = ""
        Me.CariJabatan.SelectionStart = 12
        Me.CariJabatan.ShadowDecoration.Parent = Me.CariJabatan
        Me.CariJabatan.Size = New System.Drawing.Size(396, 55)
        Me.CariJabatan.TabIndex = 17
        Me.CariJabatan.TextOffset = New System.Drawing.Point(1, 0)
        '
        'CariProdiSatuan
        '
        Me.CariProdiSatuan.BorderRadius = 10
        Me.CariProdiSatuan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CariProdiSatuan.DefaultText = "Cari Prodi atau Satuan"
        Me.CariProdiSatuan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CariProdiSatuan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CariProdiSatuan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CariProdiSatuan.DisabledState.Parent = Me.CariProdiSatuan
        Me.CariProdiSatuan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CariProdiSatuan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CariProdiSatuan.FocusedState.Parent = Me.CariProdiSatuan
        Me.CariProdiSatuan.Font = New System.Drawing.Font("Ubuntu", 18.0!)
        Me.CariProdiSatuan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.CariProdiSatuan.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CariProdiSatuan.HoverState.Parent = Me.CariProdiSatuan
        Me.CariProdiSatuan.IconLeft = Global.MyDu.My.Resources.Resources.magnifyingglass
        Me.CariProdiSatuan.IconLeftOffset = New System.Drawing.Point(20, 0)
        Me.CariProdiSatuan.Location = New System.Drawing.Point(80, 273)
        Me.CariProdiSatuan.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.CariProdiSatuan.Name = "CariProdiSatuan"
        Me.CariProdiSatuan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CariProdiSatuan.PlaceholderText = ""
        Me.CariProdiSatuan.SelectedText = ""
        Me.CariProdiSatuan.SelectionStart = 22
        Me.CariProdiSatuan.ShadowDecoration.Parent = Me.CariProdiSatuan
        Me.CariProdiSatuan.Size = New System.Drawing.Size(396, 55)
        Me.CariProdiSatuan.TabIndex = 11
        Me.CariProdiSatuan.TextOffset = New System.Drawing.Point(1, 0)
        '
        'NIMNRPTextBox
        '
        Me.NIMNRPTextBox.BorderRadius = 10
        Me.NIMNRPTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NIMNRPTextBox.DefaultText = "NIM/NRP"
        Me.NIMNRPTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.NIMNRPTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.NIMNRPTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NIMNRPTextBox.DisabledState.Parent = Me.NIMNRPTextBox
        Me.NIMNRPTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NIMNRPTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NIMNRPTextBox.FocusedState.Parent = Me.NIMNRPTextBox
        Me.NIMNRPTextBox.Font = New System.Drawing.Font("Ubuntu", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NIMNRPTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.NIMNRPTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NIMNRPTextBox.HoverState.Parent = Me.NIMNRPTextBox
        Me.NIMNRPTextBox.Location = New System.Drawing.Point(80, 192)
        Me.NIMNRPTextBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.NIMNRPTextBox.Name = "NIMNRPTextBox"
        Me.NIMNRPTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NIMNRPTextBox.PlaceholderText = ""
        Me.NIMNRPTextBox.SelectedText = ""
        Me.NIMNRPTextBox.SelectionStart = 7
        Me.NIMNRPTextBox.ShadowDecoration.Parent = Me.NIMNRPTextBox
        Me.NIMNRPTextBox.Size = New System.Drawing.Size(396, 55)
        Me.NIMNRPTextBox.TabIndex = 10
        Me.NIMNRPTextBox.TextOffset = New System.Drawing.Point(20, 0)
        '
        'NamaLengkapTextBox
        '
        Me.NamaLengkapTextBox.BorderRadius = 10
        Me.NamaLengkapTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NamaLengkapTextBox.DefaultText = "Nama Lengkap"
        Me.NamaLengkapTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.NamaLengkapTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.NamaLengkapTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NamaLengkapTextBox.DisabledState.Parent = Me.NamaLengkapTextBox
        Me.NamaLengkapTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NamaLengkapTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NamaLengkapTextBox.FocusedState.Parent = Me.NamaLengkapTextBox
        Me.NamaLengkapTextBox.Font = New System.Drawing.Font("Ubuntu", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamaLengkapTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.NamaLengkapTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NamaLengkapTextBox.HoverState.Parent = Me.NamaLengkapTextBox
        Me.NamaLengkapTextBox.Location = New System.Drawing.Point(80, 116)
        Me.NamaLengkapTextBox.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.NamaLengkapTextBox.Name = "NamaLengkapTextBox"
        Me.NamaLengkapTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NamaLengkapTextBox.PlaceholderText = ""
        Me.NamaLengkapTextBox.SelectedText = ""
        Me.NamaLengkapTextBox.SelectionStart = 12
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
        Me.UserLabel.Font = New System.Drawing.Font("Ubuntu", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        'RegistrasiAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1440, 1024)
        Me.Controls.Add(Me.ContentPanel)
        Me.Controls.Add(Me.ListPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegistrasiAdmin"
        Me.Text = "RegistrasiAdmin"
        Me.ListPanel.ResumeLayout(False)
        Me.JudulPanel.ResumeLayout(False)
        Me.JudulPanel.PerformLayout()
        Me.UpperContentPanel.ResumeLayout(False)
        Me.ContentPanelBg.ResumeLayout(False)
        Me.ContentPanelBg.PerformLayout()
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
    Friend WithEvents CariProdiSatuan As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents NIMNRPTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents NamaLengkapTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TambahDataAdmin As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents UserLabel As Label
    Friend WithEvents UserPhoto As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents CariJabatan As Guna.UI2.WinForms.Guna2TextBox
End Class
