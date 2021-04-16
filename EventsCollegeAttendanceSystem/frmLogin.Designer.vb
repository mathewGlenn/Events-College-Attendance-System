<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.label1 = New System.Windows.Forms.Label()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblmessage = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.btn_Submit = New System.Windows.Forms.Button()
        Me.chkpasswordVisibility = New System.Windows.Forms.CheckBox()
        Me.txt_Password = New System.Windows.Forms.TextBox()
        Me.txt_Username = New System.Windows.Forms.TextBox()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(192, 12)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(177, 32)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Admin Login"
        '
        'pictureBox3
        '
        Me.pictureBox3.BackColor = System.Drawing.Color.White
        Me.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pictureBox3.Image = CType(resources.GetObject("pictureBox3.Image"), System.Drawing.Image)
        Me.pictureBox3.Location = New System.Drawing.Point(405, 87)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(29, 27)
        Me.pictureBox3.TabIndex = 23
        Me.pictureBox3.TabStop = False
        '
        'pictureBox2
        '
        Me.pictureBox2.BackColor = System.Drawing.Color.White
        Me.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image)
        Me.pictureBox2.Location = New System.Drawing.Point(405, 137)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(29, 27)
        Me.pictureBox2.TabIndex = 22
        Me.pictureBox2.TabStop = False
        '
        'lblmessage
        '
        Me.lblmessage.AutoSize = True
        Me.lblmessage.BackColor = System.Drawing.Color.Transparent
        Me.lblmessage.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblmessage.Location = New System.Drawing.Point(-1, 78)
        Me.lblmessage.Name = "lblmessage"
        Me.lblmessage.Size = New System.Drawing.Size(0, 17)
        Me.lblmessage.TabIndex = 21
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.ForeColor = System.Drawing.Color.SlateGray
        Me.panel1.Location = New System.Drawing.Point(-41, -3)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(553, 55)
        Me.panel1.TabIndex = 20
        '
        'btn_Submit
        '
        Me.btn_Submit.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btn_Submit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Submit.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_Submit.FlatAppearance.BorderSize = 0
        Me.btn_Submit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSlateGray
        Me.btn_Submit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray
        Me.btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Submit.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Submit.ForeColor = System.Drawing.Color.White
        Me.btn_Submit.Location = New System.Drawing.Point(25, 205)
        Me.btn_Submit.Name = "btn_Submit"
        Me.btn_Submit.Size = New System.Drawing.Size(418, 38)
        Me.btn_Submit.TabIndex = 19
        Me.btn_Submit.Text = "login"
        Me.btn_Submit.UseVisualStyleBackColor = False
        '
        'chkpasswordVisibility
        '
        Me.chkpasswordVisibility.AutoSize = True
        Me.chkpasswordVisibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkpasswordVisibility.Location = New System.Drawing.Point(25, 177)
        Me.chkpasswordVisibility.Name = "chkpasswordVisibility"
        Me.chkpasswordVisibility.Size = New System.Drawing.Size(99, 17)
        Me.chkpasswordVisibility.TabIndex = 24
        Me.chkpasswordVisibility.Text = "Show Password"
        Me.chkpasswordVisibility.UseVisualStyleBackColor = True
        '
        'txt_Password
        '
        Me.txt_Password.BackColor = System.Drawing.Color.White
        Me.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Password.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Password.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txt_Password.Location = New System.Drawing.Point(25, 130)
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.Size = New System.Drawing.Size(418, 41)
        Me.txt_Password.TabIndex = 18
        Me.txt_Password.UseSystemPasswordChar = True
        '
        'txt_Username
        '
        Me.txt_Username.BackColor = System.Drawing.Color.White
        Me.txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Username.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Username.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txt_Username.Location = New System.Drawing.Point(25, 80)
        Me.txt_Username.Name = "txt_Username"
        Me.txt_Username.ShortcutsEnabled = False
        Me.txt_Username.Size = New System.Drawing.Size(418, 41)
        Me.txt_Username.TabIndex = 17
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(470, 265)
        Me.Controls.Add(Me.chkpasswordVisibility)
        Me.Controls.Add(Me.pictureBox3)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.lblmessage)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.txt_Password)
        Me.Controls.Add(Me.btn_Submit)
        Me.Controls.Add(Me.txt_Username)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents pictureBox3 As System.Windows.Forms.PictureBox
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents lblmessage As System.Windows.Forms.Label
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents btn_Submit As System.Windows.Forms.Button
    Friend WithEvents chkpasswordVisibility As System.Windows.Forms.CheckBox
    Private WithEvents txt_Password As System.Windows.Forms.TextBox
    Private WithEvents txt_Username As System.Windows.Forms.TextBox
End Class
