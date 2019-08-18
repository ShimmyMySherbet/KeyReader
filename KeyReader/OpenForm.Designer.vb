<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpenForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OpenForm))
        Me.LockedPanel = New System.Windows.Forms.Panel()
        Me.TxtEntryPass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UnlockedPanel = New System.Windows.Forms.Panel()
        Me.LblShowPass = New System.Windows.Forms.Label()
        Me.PBHidePass = New System.Windows.Forms.PictureBox()
        Me.BtnCopyKey = New System.Windows.Forms.Button()
        Me.txtAsPlainText = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PbUnlocked = New System.Windows.Forms.PictureBox()
        Me.CopyTick = New System.Windows.Forms.Timer(Me.components)
        Me.LockedPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UnlockedPanel.SuspendLayout()
        CType(Me.PBHidePass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbUnlocked, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LockedPanel
        '
        Me.LockedPanel.Controls.Add(Me.TxtEntryPass)
        Me.LockedPanel.Controls.Add(Me.Label4)
        Me.LockedPanel.Controls.Add(Me.Label3)
        Me.LockedPanel.Controls.Add(Me.PictureBox1)
        Me.LockedPanel.Location = New System.Drawing.Point(0, 0)
        Me.LockedPanel.Name = "LockedPanel"
        Me.LockedPanel.Size = New System.Drawing.Size(333, 135)
        Me.LockedPanel.TabIndex = 4
        '
        'TxtEntryPass
        '
        Me.TxtEntryPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEntryPass.Location = New System.Drawing.Point(110, 73)
        Me.TxtEntryPass.Multiline = True
        Me.TxtEntryPass.Name = "TxtEntryPass"
        Me.TxtEntryPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtEntryPass.Size = New System.Drawing.Size(189, 24)
        Me.TxtEntryPass.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(124, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Enter password to continue."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(125, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 24)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Key Encrypted."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.KeyReader.My.Resources.Resources.Locked
        Me.PictureBox1.Location = New System.Drawing.Point(3, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(97, 85)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'UnlockedPanel
        '
        Me.UnlockedPanel.Controls.Add(Me.LblShowPass)
        Me.UnlockedPanel.Controls.Add(Me.PBHidePass)
        Me.UnlockedPanel.Controls.Add(Me.BtnCopyKey)
        Me.UnlockedPanel.Controls.Add(Me.txtAsPlainText)
        Me.UnlockedPanel.Controls.Add(Me.Label6)
        Me.UnlockedPanel.Controls.Add(Me.PbUnlocked)
        Me.UnlockedPanel.Location = New System.Drawing.Point(3, 174)
        Me.UnlockedPanel.Name = "UnlockedPanel"
        Me.UnlockedPanel.Size = New System.Drawing.Size(333, 135)
        Me.UnlockedPanel.TabIndex = 5
        '
        'LblShowPass
        '
        Me.LblShowPass.AutoSize = True
        Me.LblShowPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblShowPass.Location = New System.Drawing.Point(139, 60)
        Me.LblShowPass.Name = "LblShowPass"
        Me.LblShowPass.Size = New System.Drawing.Size(117, 16)
        Me.LblShowPass.TabIndex = 6
        Me.LblShowPass.Text = "Click to reveal key"
        '
        'PBHidePass
        '
        Me.PBHidePass.Location = New System.Drawing.Point(109, 59)
        Me.PBHidePass.Name = "PBHidePass"
        Me.PBHidePass.Size = New System.Drawing.Size(190, 20)
        Me.PBHidePass.TabIndex = 5
        Me.PBHidePass.TabStop = False
        '
        'BtnCopyKey
        '
        Me.BtnCopyKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCopyKey.Location = New System.Drawing.Point(106, 87)
        Me.BtnCopyKey.Name = "BtnCopyKey"
        Me.BtnCopyKey.Size = New System.Drawing.Size(129, 27)
        Me.BtnCopyKey.TabIndex = 4
        Me.BtnCopyKey.Text = "Copy to Clipboard"
        Me.BtnCopyKey.UseVisualStyleBackColor = True
        '
        'txtAsPlainText
        '
        Me.txtAsPlainText.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsPlainText.Location = New System.Drawing.Point(110, 57)
        Me.txtAsPlainText.Name = "txtAsPlainText"
        Me.txtAsPlainText.ReadOnly = True
        Me.txtAsPlainText.Size = New System.Drawing.Size(189, 24)
        Me.txtAsPlainText.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(125, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 24)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Key Decrypted."
        '
        'PbUnlocked
        '
        Me.PbUnlocked.Image = Global.KeyReader.My.Resources.Resources.Unlocked
        Me.PbUnlocked.Location = New System.Drawing.Point(3, 12)
        Me.PbUnlocked.Name = "PbUnlocked"
        Me.PbUnlocked.Size = New System.Drawing.Size(97, 85)
        Me.PbUnlocked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbUnlocked.TabIndex = 0
        Me.PbUnlocked.TabStop = False
        '
        'CopyTick
        '
        Me.CopyTick.Interval = 2000
        '
        'OpenForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 346)
        Me.Controls.Add(Me.UnlockedPanel)
        Me.Controls.Add(Me.LockedPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "OpenForm"
        Me.Text = "Key Manager"
        Me.LockedPanel.ResumeLayout(False)
        Me.LockedPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UnlockedPanel.ResumeLayout(False)
        Me.UnlockedPanel.PerformLayout()
        CType(Me.PBHidePass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbUnlocked, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LockedPanel As Panel
    Friend WithEvents TxtEntryPass As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents UnlockedPanel As Panel
    Friend WithEvents BtnCopyKey As Button
    Friend WithEvents txtAsPlainText As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PbUnlocked As PictureBox
    Friend WithEvents LblShowPass As Label
    Friend WithEvents PBHidePass As PictureBox
    Friend WithEvents CopyTick As Timer
End Class
