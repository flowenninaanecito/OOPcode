<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReg
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCPass = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtUname = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnReg = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 11.89565!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(81, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FULL NAME:"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Arial Narrow", 11.89565!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(81, 118)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(294, 29)
        Me.txtName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 13.77391!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(80, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(246, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "REGISTRATION FORM"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Arial Narrow", 11.89565!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(81, 214)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(294, 29)
        Me.txtAddress.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 11.89565!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(81, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ADDRESS:"
        '
        'txtContact
        '
        Me.txtContact.Font = New System.Drawing.Font("Arial Narrow", 11.89565!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(81, 306)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(294, 29)
        Me.txtContact.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 11.89565!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(81, 269)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 23)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "CONTACT NUMBER:"
        '
        'txtCPass
        '
        Me.txtCPass.Font = New System.Drawing.Font("Arial Narrow", 11.89565!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCPass.Location = New System.Drawing.Point(81, 583)
        Me.txtCPass.Name = "txtCPass"
        Me.txtCPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCPass.Size = New System.Drawing.Size(294, 29)
        Me.txtCPass.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 11.89565!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(81, 546)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 23)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "CONFIRM PASSWORD:"
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Arial Narrow", 11.89565!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(81, 491)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(294, 29)
        Me.txtPass.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 11.89565!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(81, 454)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 23)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "PASSWORD:"
        '
        'txtUname
        '
        Me.txtUname.Font = New System.Drawing.Font("Arial Narrow", 11.89565!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUname.Location = New System.Drawing.Point(81, 395)
        Me.txtUname.Name = "txtUname"
        Me.txtUname.Size = New System.Drawing.Size(294, 29)
        Me.txtUname.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 11.89565!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(81, 358)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 23)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "USERNAME:"
        '
        'btnReg
        '
        Me.btnReg.BackColor = System.Drawing.Color.ForestGreen
        Me.btnReg.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnReg.Location = New System.Drawing.Point(81, 637)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(123, 38)
        Me.btnReg.TabIndex = 13
        Me.btnReg.Text = "REGISTER"
        Me.btnReg.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Brown
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancel.Location = New System.Drawing.Point(252, 637)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(123, 38)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'frmReg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 726)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnReg)
        Me.Controls.Add(Me.txtCPass)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtUname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmReg"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtContact As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCPass As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtUname As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnReg As Button
    Friend WithEvents btnCancel As Button
End Class
