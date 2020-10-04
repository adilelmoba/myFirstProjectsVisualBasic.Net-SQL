<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loginForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.panelBg = New System.Windows.Forms.Panel()
        Me.slogan = New System.Windows.Forms.Label()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ZToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtUser = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtUser2 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.panelBg.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelBg
        '
        Me.panelBg.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.panelBg.Controls.Add(Me.slogan)
        Me.panelBg.Controls.Add(Me.Logo)
        Me.panelBg.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelBg.Location = New System.Drawing.Point(0, 0)
        Me.panelBg.Name = "panelBg"
        Me.panelBg.Size = New System.Drawing.Size(417, 500)
        Me.panelBg.TabIndex = 1
        '
        'slogan
        '
        Me.slogan.AutoSize = True
        Me.slogan.BackColor = System.Drawing.Color.Transparent
        Me.slogan.Font = New System.Drawing.Font("SF Pro Display", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slogan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.slogan.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.slogan.Location = New System.Drawing.Point(87, 306)
        Me.slogan.Name = "slogan"
        Me.slogan.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.slogan.Size = New System.Drawing.Size(242, 21)
        Me.slogan.TabIndex = 1
        Me.slogan.Text = "!Le parcous des professionnels"
        Me.slogan.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Logo
        '
        Me.Logo.BackgroundImage = Global.LoginFormStudent.My.Resources.Resources.logoIISGA2
        Me.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Logo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Logo.InitialImage = Nothing
        Me.Logo.Location = New System.Drawing.Point(75, 136)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(266, 153)
        Me.Logo.TabIndex = 0
        Me.Logo.TabStop = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(80, 26)
        '
        'ZToolStripMenuItem
        '
        Me.ZToolStripMenuItem.Name = "ZToolStripMenuItem"
        Me.ZToolStripMenuItem.Size = New System.Drawing.Size(79, 22)
        Me.ZToolStripMenuItem.Text = "z"
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.Color.White
        Me.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUser.Font = New System.Drawing.Font("SF Pro Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.txtUser.HintForeColor = System.Drawing.Color.Silver
        Me.txtUser.HintText = "Entrez votre Email"
        Me.txtUser.isPassword = False
        Me.txtUser.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.txtUser.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txtUser.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.txtUser.LineThickness = 2
        Me.txtUser.Location = New System.Drawing.Point(474, 177)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(336, 41)
        Me.txtUser.TabIndex = 6
        Me.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtUser2
        '
        Me.txtUser2.BackColor = System.Drawing.Color.White
        Me.txtUser2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUser2.Font = New System.Drawing.Font("SF Pro Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.txtUser2.HintForeColor = System.Drawing.Color.Silver
        Me.txtUser2.HintText = "Entrez votre Mot de passe"
        Me.txtUser2.isPassword = False
        Me.txtUser2.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.txtUser2.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txtUser2.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.txtUser2.LineThickness = 2
        Me.txtUser2.Location = New System.Drawing.Point(474, 248)
        Me.txtUser2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUser2.Name = "txtUser2"
        Me.txtUser2.Size = New System.Drawing.Size(336, 41)
        Me.txtUser2.TabIndex = 7
        Me.txtUser2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Button
        '
        Me.Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button.Font = New System.Drawing.Font("SF Pro Display", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button.ForeColor = System.Drawing.Color.White
        Me.Button.Location = New System.Drawing.Point(474, 355)
        Me.Button.Name = "Button"
        Me.Button.Size = New System.Drawing.Size(336, 47)
        Me.Button.TabIndex = 8
        Me.Button.Text = "Se Connecter"
        Me.Button.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("SF Pro Display", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(474, 62)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(198, 42)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = ",Bonjour chér Etudiant(e)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "!Connectez-vous"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("SF Pro Display", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(474, 408)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(336, 46)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Ou Bien, Enregistrer-Vous"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("SF Pro Display", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(698, 298)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 14)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Mot de passe oublié?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.LoginFormStudent.My.Resources.Resources.icons8_password_50
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(781, 248)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(29, 30)
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.WaitOnLoad = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LoginFormStudent.My.Resources.Resources.icons8_user_male_30__1_
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(781, 177)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(29, 30)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.WaitOnLoad = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.LoginFormStudent.My.Resources.Resources.icons8_close_window_48
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Location = New System.Drawing.Point(823, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(27, 26)
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'loginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(850, 500)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button)
        Me.Controls.Add(Me.txtUser2)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.panelBg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "loginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.panelBg.ResumeLayout(False)
        Me.panelBg.PerformLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panelBg As Panel
    Friend WithEvents Logo As PictureBox
    Friend WithEvents slogan As Label

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles slogan.Click

    End Sub
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents ZToolStripMenuItem As ToolStripMenuItem

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents txtUser As Bunifu.Framework.UI.BunifuMaterialTextbox

    Private Sub txtUser_OnValueChanged(sender As Object, e As EventArgs) Handles txtUser.OnValueChanged

    End Sub

    Friend WithEvents txtUser2 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Button As Button

    Private Sub Button_SystemColorsChanged(sender As Object, e As EventArgs) Handles Button.MouseEnter
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button.Click
        Me.Hide()
        Dim Form2 As New Form2
        Form2.Show()
    End Sub

    Private Sub Button_BackColorChanged(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents Label1 As Label

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Friend WithEvents Button1 As Button

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub txtUser2_OnValueChanged(sender As Object, e As EventArgs) Handles txtUser2.OnValueChanged

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub
End Class
