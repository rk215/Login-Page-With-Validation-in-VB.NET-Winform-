<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lbuser = New System.Windows.Forms.Label()
        Me.lbPass = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.lbShowPass = New System.Windows.Forms.Label()
        Me.UserLeftCharacter = New System.Windows.Forms.Label()
        Me.PassLeftCharacter = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(3, Byte))
        Me.Label1.Location = New System.Drawing.Point(198, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Name : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(3, Byte))
        Me.Label2.Location = New System.Drawing.Point(198, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password  :  "
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(3, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Button1.Location = New System.Drawing.Point(311, 396)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 63)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "LOGIN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(3, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Button2.Location = New System.Drawing.Point(488, 396)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(135, 63)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "CANCEL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(3, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(347, 133)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(276, 35)
        Me.TextBox1.TabIndex = 0
        '
        'lbuser
        '
        Me.lbuser.AutoSize = True
        Me.lbuser.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(3, Byte))
        Me.lbuser.ForeColor = System.Drawing.Color.Red
        Me.lbuser.Location = New System.Drawing.Point(368, 184)
        Me.lbuser.Name = "lbuser"
        Me.lbuser.Size = New System.Drawing.Size(0, 23)
        Me.lbuser.TabIndex = 7
        '
        'lbPass
        '
        Me.lbPass.AutoSize = True
        Me.lbPass.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(3, Byte))
        Me.lbPass.ForeColor = System.Drawing.Color.Red
        Me.lbPass.Location = New System.Drawing.Point(368, 283)
        Me.lbPass.Name = "lbPass"
        Me.lbPass.Size = New System.Drawing.Size(0, 23)
        Me.lbPass.TabIndex = 8
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(3, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(202, 309)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(178, 27)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "Show Password "
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'lbShowPass
        '
        Me.lbShowPass.AutoSize = True
        Me.lbShowPass.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(3, Byte))
        Me.lbShowPass.Location = New System.Drawing.Point(403, 309)
        Me.lbShowPass.Name = "lbShowPass"
        Me.lbShowPass.Size = New System.Drawing.Size(0, 23)
        Me.lbShowPass.TabIndex = 10
        Me.lbShowPass.Visible = False
        '
        'UserLeftCharacter
        '
        Me.UserLeftCharacter.AutoSize = True
        Me.UserLeftCharacter.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(3, Byte))
        Me.UserLeftCharacter.ForeColor = System.Drawing.Color.Red
        Me.UserLeftCharacter.Location = New System.Drawing.Point(644, 131)
        Me.UserLeftCharacter.Name = "UserLeftCharacter"
        Me.UserLeftCharacter.Size = New System.Drawing.Size(0, 23)
        Me.UserLeftCharacter.TabIndex = 11
        '
        'PassLeftCharacter
        '
        Me.PassLeftCharacter.AutoSize = True
        Me.PassLeftCharacter.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(3, Byte))
        Me.PassLeftCharacter.ForeColor = System.Drawing.Color.Red
        Me.PassLeftCharacter.Location = New System.Drawing.Point(644, 235)
        Me.PassLeftCharacter.Name = "PassLeftCharacter"
        Me.PassLeftCharacter.Size = New System.Drawing.Size(0, 23)
        Me.PassLeftCharacter.TabIndex = 12
        Me.PassLeftCharacter.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(3, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label3.Location = New System.Drawing.Point(382, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 36)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Login Page"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(3, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(347, 231)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(276, 35)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.UseSystemPasswordChar = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1035, 466)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PassLeftCharacter)
        Me.Controls.Add(Me.UserLeftCharacter)
        Me.Controls.Add(Me.lbShowPass)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.lbPass)
        Me.Controls.Add(Me.lbuser)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lbuser As System.Windows.Forms.Label
    Friend WithEvents lbPass As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents lbShowPass As System.Windows.Forms.Label
    Friend WithEvents UserLeftCharacter As System.Windows.Forms.Label
    Friend WithEvents PassLeftCharacter As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
End Class
