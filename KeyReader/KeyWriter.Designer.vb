<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KeyWriter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KeyWriter))
        Me.CBEncrypt = New System.Windows.Forms.CheckBox()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtpassResubmittion = New System.Windows.Forms.TextBox()
        Me.TxtKey = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.SaveKeyDialog = New System.Windows.Forms.SaveFileDialog()
        Me.Closer = New System.Windows.Forms.Timer(Me.components)
        Me.PbEnc = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ErrorPMain = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BtnToggleKey = New System.Windows.Forms.Button()
        CType(Me.PbEnc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorPMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CBEncrypt
        '
        Me.CBEncrypt.AutoSize = True
        Me.CBEncrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CBEncrypt.Location = New System.Drawing.Point(15, 28)
        Me.CBEncrypt.Name = "CBEncrypt"
        Me.CBEncrypt.Size = New System.Drawing.Size(83, 17)
        Me.CBEncrypt.TabIndex = 1
        Me.CBEncrypt.Text = "Encrypt Key"
        Me.CBEncrypt.UseVisualStyleBackColor = True
        '
        'TxtPass
        '
        Me.TxtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtPass.Location = New System.Drawing.Point(15, 63)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPass.Size = New System.Drawing.Size(100, 20)
        Me.TxtPass.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(12, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(12, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Confirm Password:"
        '
        'TxtpassResubmittion
        '
        Me.TxtpassResubmittion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtpassResubmittion.Location = New System.Drawing.Point(15, 104)
        Me.TxtpassResubmittion.Name = "TxtpassResubmittion"
        Me.TxtpassResubmittion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtpassResubmittion.Size = New System.Drawing.Size(100, 20)
        Me.TxtpassResubmittion.TabIndex = 4
        '
        'TxtKey
        '
        Me.TxtKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtKey.Location = New System.Drawing.Point(128, 44)
        Me.TxtKey.Name = "TxtKey"
        Me.TxtKey.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtKey.Size = New System.Drawing.Size(144, 20)
        Me.TxtKey.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(132, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Key Content:"
        '
        'BtnCreate
        '
        Me.BtnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnCreate.Location = New System.Drawing.Point(197, 104)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(75, 23)
        Me.BtnCreate.TabIndex = 8
        Me.BtnCreate.Text = "Create Key"
        Me.BtnCreate.UseVisualStyleBackColor = True
        '
        'SaveKeyDialog
        '
        Me.SaveKeyDialog.DefaultExt = "key"
        Me.SaveKeyDialog.Filter = "Key Files|*.key"
        Me.SaveKeyDialog.Title = "Save key file."
        '
        'Closer
        '
        Me.Closer.Interval = 200
        '
        'PbEnc
        '
        Me.PbEnc.Image = Global.KeyReader.My.Resources.Resources.Key
        Me.PbEnc.Location = New System.Drawing.Point(2, 9)
        Me.PbEnc.Name = "PbEnc"
        Me.PbEnc.Size = New System.Drawing.Size(134, 129)
        Me.PbEnc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbEnc.TabIndex = 11
        Me.PbEnc.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnToggleKey)
        Me.GroupBox1.Controls.Add(Me.CBEncrypt)
        Me.GroupBox1.Controls.Add(Me.TxtPass)
        Me.GroupBox1.Controls.Add(Me.BtnCreate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtpassResubmittion)
        Me.GroupBox1.Controls.Add(Me.TxtKey)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(143, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 137)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Create a new key"
        '
        'ErrorPMain
        '
        Me.ErrorPMain.ContainerControl = Me
        '
        'BtnToggleKey
        '
        Me.BtnToggleKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnToggleKey.Location = New System.Drawing.Point(196, 71)
        Me.BtnToggleKey.Name = "BtnToggleKey"
        Me.BtnToggleKey.Size = New System.Drawing.Size(75, 23)
        Me.BtnToggleKey.TabIndex = 9
        Me.BtnToggleKey.Text = "Show Key"
        Me.BtnToggleKey.UseVisualStyleBackColor = True
        '
        'KeyWriter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 143)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PbEnc)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "KeyWriter"
        Me.Text = "Create Key"
        CType(Me.PbEnc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorPMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CBEncrypt As CheckBox
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtpassResubmittion As TextBox
    Friend WithEvents TxtKey As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnCreate As Button
    Friend WithEvents SaveKeyDialog As SaveFileDialog
    Friend WithEvents Closer As Timer
    Friend WithEvents PbEnc As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ErrorPMain As ErrorProvider
    Friend WithEvents BtnToggleKey As Button
End Class
