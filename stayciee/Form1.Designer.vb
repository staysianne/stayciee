<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginpage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginpage))
        Me.Labelusername = New System.Windows.Forms.Label()
        Me.Labelpassword = New System.Windows.Forms.Label()
        Me.LabelLOGIN = New System.Windows.Forms.Label()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.Btnlogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Labelusername
        '
        Me.Labelusername.AutoSize = True
        Me.Labelusername.BackColor = System.Drawing.Color.Transparent
        Me.Labelusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelusername.ForeColor = System.Drawing.Color.White
        Me.Labelusername.Location = New System.Drawing.Point(119, 461)
        Me.Labelusername.Name = "Labelusername"
        Me.Labelusername.Size = New System.Drawing.Size(159, 32)
        Me.Labelusername.TabIndex = 0
        Me.Labelusername.Text = "Username: "
        '
        'Labelpassword
        '
        Me.Labelpassword.AutoSize = True
        Me.Labelpassword.BackColor = System.Drawing.Color.Transparent
        Me.Labelpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Labelpassword.ForeColor = System.Drawing.Color.White
        Me.Labelpassword.Location = New System.Drawing.Point(119, 553)
        Me.Labelpassword.Name = "Labelpassword"
        Me.Labelpassword.Size = New System.Drawing.Size(149, 31)
        Me.Labelpassword.TabIndex = 1
        Me.Labelpassword.Text = "Password: "
        '
        'LabelLOGIN
        '
        Me.LabelLOGIN.AutoSize = True
        Me.LabelLOGIN.BackColor = System.Drawing.Color.Transparent
        Me.LabelLOGIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLOGIN.ForeColor = System.Drawing.Color.White
        Me.LabelLOGIN.Location = New System.Drawing.Point(381, 330)
        Me.LabelLOGIN.Name = "LabelLOGIN"
        Me.LabelLOGIN.Size = New System.Drawing.Size(175, 54)
        Me.LabelLOGIN.TabIndex = 2
        Me.LabelLOGIN.Text = "LOGIN"
        '
        'TxtUsername
        '
        Me.TxtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.TxtUsername.Location = New System.Drawing.Point(327, 468)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(326, 38)
        Me.TxtUsername.TabIndex = 3
        '
        'TxtPassword
        '
        Me.TxtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.TxtPassword.Location = New System.Drawing.Point(327, 535)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(326, 38)
        Me.TxtPassword.TabIndex = 4
        '
        'Btnlogin
        '
        Me.Btnlogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Btnlogin.Location = New System.Drawing.Point(390, 623)
        Me.Btnlogin.Name = "Btnlogin"
        Me.Btnlogin.Size = New System.Drawing.Size(147, 48)
        Me.Btnlogin.TabIndex = 5
        Me.Btnlogin.Text = "Login"
        Me.Btnlogin.UseVisualStyleBackColor = True
        '
        'loginpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.stayciee.My.Resources.Resources.Screenshot_2024_05_13_190522
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1786, 775)
        Me.Controls.Add(Me.Btnlogin)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.LabelLOGIN)
        Me.Controls.Add(Me.Labelpassword)
        Me.Controls.Add(Me.Labelusername)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "loginpage"
        Me.Text = "Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Labelusername As Label
    Friend WithEvents Labelpassword As Label
    Friend WithEvents LabelLOGIN As Label
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents Btnlogin As Button
End Class
