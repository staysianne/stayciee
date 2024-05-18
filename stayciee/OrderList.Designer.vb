<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ORDERlist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ORDERlist))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txtname = New System.Windows.Forms.TextBox()
        Me.Txtorder = New System.Windows.Forms.TextBox()
        Me.Txtquantity = New System.Windows.Forms.TextBox()
        Me.Txtdatetime = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Btnadd = New System.Windows.Forms.Button()
        Me.DBtable = New System.Windows.Forms.DataGridView()
        Me.Btnsave = New System.Windows.Forms.Button()
        CType(Me.DBtable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(930, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Order List"
        '
        'Label2
        '
        Me.Label2.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(122, 175)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(124, 226)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 29)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Order"
        '
        'Label4
        '
        Me.Label4.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(100, 287)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 29)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Quantity"
        '
        'Label5
        '
        Me.Label5.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(137, 341)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 29)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Date"
        '
        'Txtname
        '
        Me.Txtname.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup
        Me.Txtname.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtname.Location = New System.Drawing.Point(241, 179)
        Me.Txtname.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtname.Name = "Txtname"
        Me.Txtname.Size = New System.Drawing.Size(248, 34)
        Me.Txtname.TabIndex = 6
        '
        'Txtorder
        '
        Me.Txtorder.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup
        Me.Txtorder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtorder.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtorder.Location = New System.Drawing.Point(241, 230)
        Me.Txtorder.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtorder.Name = "Txtorder"
        Me.Txtorder.Size = New System.Drawing.Size(248, 34)
        Me.Txtorder.TabIndex = 7
        '
        'Txtquantity
        '
        Me.Txtquantity.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup
        Me.Txtquantity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtquantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtquantity.Location = New System.Drawing.Point(241, 282)
        Me.Txtquantity.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtquantity.Name = "Txtquantity"
        Me.Txtquantity.Size = New System.Drawing.Size(248, 34)
        Me.Txtquantity.TabIndex = 8
        '
        'Txtdatetime
        '
        Me.Txtdatetime.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup
        Me.Txtdatetime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtdatetime.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Txtdatetime.Location = New System.Drawing.Point(241, 336)
        Me.Txtdatetime.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtdatetime.Name = "Txtdatetime"
        Me.Txtdatetime.Size = New System.Drawing.Size(248, 34)
        Me.Txtdatetime.TabIndex = 9
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Btnadd
        '
        Me.Btnadd.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup
        Me.Btnadd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Btnadd.Location = New System.Drawing.Point(241, 388)
        Me.Btnadd.Margin = New System.Windows.Forms.Padding(4)
        Me.Btnadd.Name = "Btnadd"
        Me.Btnadd.Size = New System.Drawing.Size(100, 42)
        Me.Btnadd.TabIndex = 10
        Me.Btnadd.Text = "Add"
        Me.Btnadd.UseVisualStyleBackColor = True
        '
        'DBtable
        '
        Me.DBtable.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem
        Me.DBtable.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DBtable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DBtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DBtable.Location = New System.Drawing.Point(556, 108)
        Me.DBtable.Margin = New System.Windows.Forms.Padding(4)
        Me.DBtable.Name = "DBtable"
        Me.DBtable.RowHeadersWidth = 51
        Me.DBtable.Size = New System.Drawing.Size(922, 651)
        Me.DBtable.TabIndex = 11
        '
        'Btnsave
        '
        Me.Btnsave.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup
        Me.Btnsave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Btnsave.Location = New System.Drawing.Point(391, 388)
        Me.Btnsave.Margin = New System.Windows.Forms.Padding(4)
        Me.Btnsave.Name = "Btnsave"
        Me.Btnsave.Size = New System.Drawing.Size(100, 42)
        Me.Btnsave.TabIndex = 12
        Me.Btnsave.Text = "Save"
        Me.Btnsave.UseVisualStyleBackColor = True
        '
        'ORDERlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1668, 791)
        Me.Controls.Add(Me.Btnsave)
        Me.Controls.Add(Me.DBtable)
        Me.Controls.Add(Me.Btnadd)
        Me.Controls.Add(Me.Txtdatetime)
        Me.Controls.Add(Me.Txtquantity)
        Me.Controls.Add(Me.Txtorder)
        Me.Controls.Add(Me.Txtname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Chocolate
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ORDERlist"
        Me.Text = "ORDERlist"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DBtable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Txtname As TextBox
    Friend WithEvents Txtorder As TextBox
    Friend WithEvents Txtquantity As TextBox
    Friend WithEvents Txtdatetime As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Btnadd As Button
    Friend WithEvents DBtable As DataGridView
    Friend WithEvents Btnsave As Button
End Class
