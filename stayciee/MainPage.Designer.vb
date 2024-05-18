<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainPage))
        Me.Paneltop = New System.Windows.Forms.Panel()
        Me.Panelside = New System.Windows.Forms.Panel()
        Me.Btnorder = New System.Windows.Forms.Button()
        Me.BtnStats = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.Btnlog = New System.Windows.Forms.Button()
        Me.Mainpanel = New System.Windows.Forms.Panel()
        Me.Panelside.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Paneltop
        '
        Me.Paneltop.BackgroundImage = Global.stayciee.My.Resources.Resources.header
        Me.Paneltop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Paneltop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Paneltop.Dock = System.Windows.Forms.DockStyle.Top
        Me.Paneltop.Location = New System.Drawing.Point(0, 0)
        Me.Paneltop.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Paneltop.Name = "Paneltop"
        Me.Paneltop.Size = New System.Drawing.Size(1816, 116)
        Me.Paneltop.TabIndex = 0
        '
        'Panelside
        '
        Me.Panelside.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panelside.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panelside.Controls.Add(Me.Btnorder)
        Me.Panelside.Controls.Add(Me.BtnStats)
        Me.Panelside.Controls.Add(Me.PictureBox1)
        Me.Panelside.Controls.Add(Me.btnlogout)
        Me.Panelside.Controls.Add(Me.Btnlog)
        Me.Panelside.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panelside.Location = New System.Drawing.Point(0, 116)
        Me.Panelside.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panelside.Name = "Panelside"
        Me.Panelside.Size = New System.Drawing.Size(390, 639)
        Me.Panelside.TabIndex = 1
        '
        'Btnorder
        '
        Me.Btnorder.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Bold)
        Me.Btnorder.Image = Global.stayciee.My.Resources.Resources.icons8_purchase_order_50
        Me.Btnorder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnorder.Location = New System.Drawing.Point(21, 199)
        Me.Btnorder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btnorder.Name = "Btnorder"
        Me.Btnorder.Size = New System.Drawing.Size(324, 103)
        Me.Btnorder.TabIndex = 0
        Me.Btnorder.Text = "    Order List"
        Me.Btnorder.UseVisualStyleBackColor = True
        '
        'BtnStats
        '
        Me.BtnStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStats.Image = Global.stayciee.My.Resources.Resources.icons8_food_delivery_48
        Me.BtnStats.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnStats.Location = New System.Drawing.Point(21, 330)
        Me.BtnStats.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnStats.Name = "BtnStats"
        Me.BtnStats.Size = New System.Drawing.Size(324, 103)
        Me.BtnStats.TabIndex = 1
        Me.BtnStats.Text = "        Delivery Status"
        Me.BtnStats.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.stayciee.My.Resources.Resources.icon
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(58, 14)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(267, 160)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnlogout
        '
        Me.btnlogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlogout.Location = New System.Drawing.Point(58, 605)
        Me.btnlogout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(245, 43)
        Me.btnlogout.TabIndex = 3
        Me.btnlogout.Text = "Logout"
        Me.btnlogout.UseVisualStyleBackColor = True
        '
        'Btnlog
        '
        Me.Btnlog.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnlog.Image = Global.stayciee.My.Resources.Resources.icons8_sales_64
        Me.Btnlog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnlog.Location = New System.Drawing.Point(21, 471)
        Me.Btnlog.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btnlog.Name = "Btnlog"
        Me.Btnlog.Size = New System.Drawing.Size(324, 103)
        Me.Btnlog.TabIndex = 2
        Me.Btnlog.Text = "       Sales Log"
        Me.Btnlog.UseVisualStyleBackColor = True
        '
        'Mainpanel
        '
        Me.Mainpanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Mainpanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Mainpanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Mainpanel.Location = New System.Drawing.Point(390, 116)
        Me.Mainpanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Mainpanel.Name = "Mainpanel"
        Me.Mainpanel.Size = New System.Drawing.Size(1426, 639)
        Me.Mainpanel.TabIndex = 2
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1816, 755)
        Me.Controls.Add(Me.Mainpanel)
        Me.Controls.Add(Me.Panelside)
        Me.Controls.Add(Me.Paneltop)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MainPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainPage"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panelside.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Paneltop As Panel
    Friend WithEvents Panelside As Panel
    Friend WithEvents Mainpanel As Panel
    Friend WithEvents Btnorder As Button
    Friend WithEvents btnlogout As Button
    Friend WithEvents Btnlog As Button
    Friend WithEvents BtnStats As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
