﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Template
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Template))
        Me.ContentPanel = New System.Windows.Forms.Panel()
        Me.UpperContentPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.UserPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.UserLabel = New System.Windows.Forms.Label()
        Me.UserPhoto = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse3 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse5 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.MinimazeControlBox = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.CloseControlBox = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ControlPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.TitleBarPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.JudulPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.JudulLabel = New System.Windows.Forms.Label()
        Me.ListPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.LogoutButton = New Guna.UI2.WinForms.Guna2Button()
        Me.RegistrasiAdminButton = New Guna.UI2.WinForms.Guna2Button()
        Me.RegistrasiUserButton = New Guna.UI2.WinForms.Guna2Button()
        Me.UploadJadwalButton = New Guna.UI2.WinForms.Guna2Button()
        Me.UserProfileButton = New Guna.UI2.WinForms.Guna2Button()
        Me.DashboardButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Elipse4 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse6 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.ContentPanel.SuspendLayout()
        Me.UserPanel.SuspendLayout()
        Me.ControlPanel.SuspendLayout()
        Me.TitleBarPanel.SuspendLayout()
        Me.JudulPanel.SuspendLayout()
        Me.ListPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContentPanel
        '
        Me.ContentPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ContentPanel.Controls.Add(Me.UpperContentPanel)
        Me.ContentPanel.Controls.Add(Me.UserPanel)
        Me.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContentPanel.Location = New System.Drawing.Point(441, 47)
        Me.ContentPanel.Name = "ContentPanel"
        Me.ContentPanel.Size = New System.Drawing.Size(999, 977)
        Me.ContentPanel.TabIndex = 5
        '
        'UpperContentPanel
        '
        Me.UpperContentPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.UpperContentPanel.Location = New System.Drawing.Point(0, 100)
        Me.UpperContentPanel.Name = "UpperContentPanel"
        Me.UpperContentPanel.ShadowDecoration.Parent = Me.UpperContentPanel
        Me.UpperContentPanel.Size = New System.Drawing.Size(999, 343)
        Me.UpperContentPanel.TabIndex = 1
        '
        'UserPanel
        '
        Me.UserPanel.Controls.Add(Me.UserLabel)
        Me.UserPanel.Controls.Add(Me.UserPhoto)
        Me.UserPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.UserPanel.Location = New System.Drawing.Point(0, 0)
        Me.UserPanel.Name = "UserPanel"
        Me.UserPanel.ShadowDecoration.Parent = Me.UserPanel
        Me.UserPanel.Size = New System.Drawing.Size(999, 100)
        Me.UserPanel.TabIndex = 0
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
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 10
        '
        'Guna2Elipse3
        '
        Me.Guna2Elipse3.BorderRadius = 10
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
        'TitleBarPanel
        '
        Me.TitleBarPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.TitleBarPanel.Controls.Add(Me.ControlPanel)
        Me.TitleBarPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleBarPanel.Location = New System.Drawing.Point(441, 0)
        Me.TitleBarPanel.Name = "TitleBarPanel"
        Me.TitleBarPanel.ShadowDecoration.Parent = Me.TitleBarPanel
        Me.TitleBarPanel.Size = New System.Drawing.Size(999, 47)
        Me.TitleBarPanel.TabIndex = 4
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
        Me.JudulLabel.Size = New System.Drawing.Size(159, 60)
        Me.JudulLabel.TabIndex = 2
        Me.JudulLabel.Text = "myDU"
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
        Me.ListPanel.TabIndex = 3
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
        Me.RegistrasiAdminButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
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
        Me.RegistrasiUserButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
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
        Me.UploadJadwalButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
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
        Me.UserProfileButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
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
        Me.DashboardButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.DashboardButton.Checked = True
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
        'Guna2Elipse4
        '
        Me.Guna2Elipse4.BorderRadius = 10
        '
        'Guna2Elipse6
        '
        Me.Guna2Elipse6.TargetControl = Me
        '
        'Template
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1440, 1024)
        Me.Controls.Add(Me.ContentPanel)
        Me.Controls.Add(Me.TitleBarPanel)
        Me.Controls.Add(Me.ListPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Template"
        Me.Text = "Form1"
        Me.ContentPanel.ResumeLayout(False)
        Me.UserPanel.ResumeLayout(False)
        Me.UserPanel.PerformLayout()
        Me.ControlPanel.ResumeLayout(False)
        Me.TitleBarPanel.ResumeLayout(False)
        Me.JudulPanel.ResumeLayout(False)
        Me.JudulPanel.PerformLayout()
        Me.ListPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContentPanel As Panel
    Friend WithEvents UserPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents UserLabel As Label
    Friend WithEvents UserPhoto As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse3 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse5 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents MinimazeControlBox As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents CloseControlBox As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents ControlPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TitleBarPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents JudulPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents JudulLabel As Label
    Friend WithEvents DashboardButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ListPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LogoutButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents RegistrasiAdminButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents RegistrasiUserButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents UploadJadwalButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents UserProfileButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Elipse4 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse6 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents UpperContentPanel As Guna.UI2.WinForms.Guna2Panel
End Class
