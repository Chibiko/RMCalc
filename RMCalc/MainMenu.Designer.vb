<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Actions = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownloadMissingFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.InteriorPrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StandsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LightBoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GlowingLabelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Actions, Me.SettingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(970, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Actions
        '
        Me.Actions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateToolStripMenuItem, Me.ToolStripSeparator3, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ToolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.Actions.Name = "Actions"
        Me.Actions.Size = New System.Drawing.Size(59, 20)
        Me.Actions.Text = "Actions"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckUpdatesToolStripMenuItem, Me.DownloadMissingFilesToolStripMenuItem, Me.ToolStripSeparator1, Me.AboutToolStripMenuItem1})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'CheckUpdatesToolStripMenuItem
        '
        Me.CheckUpdatesToolStripMenuItem.Name = "CheckUpdatesToolStripMenuItem"
        Me.CheckUpdatesToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.CheckUpdatesToolStripMenuItem.Text = "Check Updates"
        '
        'DownloadMissingFilesToolStripMenuItem
        '
        Me.DownloadMissingFilesToolStripMenuItem.Name = "DownloadMissingFilesToolStripMenuItem"
        Me.DownloadMissingFilesToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.DownloadMissingFilesToolStripMenuItem.Text = "Download Missing Files"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(195, 6)
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(198, 22)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'CreateToolStripMenuItem
        '
        Me.CreateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InteriorPrintToolStripMenuItem, Me.StandsToolStripMenuItem, Me.LightBoxToolStripMenuItem, Me.GlowingLabelToolStripMenuItem})
        Me.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem"
        Me.CreateToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CreateToolStripMenuItem.Text = "Create"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(149, 6)
        '
        'InteriorPrintToolStripMenuItem
        '
        Me.InteriorPrintToolStripMenuItem.Name = "InteriorPrintToolStripMenuItem"
        Me.InteriorPrintToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.InteriorPrintToolStripMenuItem.Text = "Interior Print"
        '
        'StandsToolStripMenuItem
        '
        Me.StandsToolStripMenuItem.Name = "StandsToolStripMenuItem"
        Me.StandsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.StandsToolStripMenuItem.Text = "Stands"
        '
        'LightBoxToolStripMenuItem
        '
        Me.LightBoxToolStripMenuItem.Name = "LightBoxToolStripMenuItem"
        Me.LightBoxToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LightBoxToolStripMenuItem.Text = "Light Box"
        '
        'GlowingLabelToolStripMenuItem
        '
        Me.GlowingLabelToolStripMenuItem.Name = "GlowingLabelToolStripMenuItem"
        Me.GlowingLabelToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GlowingLabelToolStripMenuItem.Text = "Glowing Label"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 621)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainMenu"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Actions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckUpdatesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DownloadMissingFilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InteriorPrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StandsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LightBoxToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GlowingLabelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
