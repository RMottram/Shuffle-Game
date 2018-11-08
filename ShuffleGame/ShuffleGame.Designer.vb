<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShuffleGame
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblClicks = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GameModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NumbersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LettersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColourThemeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LightGreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreyScaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LightBlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlueToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCountdown = New System.Windows.Forms.Timer(Me.components)
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.tmrLoop = New System.Windows.Forms.Timer(Me.components)
        Me.btnResetL = New System.Windows.Forms.Button()
        Me.btnResetP = New System.Windows.Forms.Button()
        Me.btnResetN = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lblScNam1 = New System.Windows.Forms.Label()
        Me.lblScTime1 = New System.Windows.Forms.Label()
        Me.lblScNam2 = New System.Windows.Forms.Label()
        Me.lblScTime2 = New System.Windows.Forms.Label()
        Me.lblScNam3 = New System.Windows.Forms.Label()
        Me.lblScTime3 = New System.Windows.Forms.Label()
        Me.lblScNam4 = New System.Windows.Forms.Label()
        Me.lblScTime4 = New System.Windows.Forms.Label()
        Me.lblScNam5 = New System.Windows.Forms.Label()
        Me.lblScTime5 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn20 = New System.Windows.Forms.Button()
        Me.btn21 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCheat = New System.Windows.Forms.TextBox()
        Me.btnCheatHide = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(194, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(522, 79)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Shuffle Game"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(696, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 28)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Number of Clicks"
        '
        'lblClicks
        '
        Me.lblClicks.BackColor = System.Drawing.Color.White
        Me.lblClicks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblClicks.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClicks.Location = New System.Drawing.Point(699, 196)
        Me.lblClicks.Name = "lblClicks"
        Me.lblClicks.Size = New System.Drawing.Size(207, 42)
        Me.lblClicks.TabIndex = 2
        Me.lblClicks.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.GameModeToolStripMenuItem, Me.ColourThemeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1331, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'GameModeToolStripMenuItem
        '
        Me.GameModeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PictureToolStripMenuItem, Me.NumbersToolStripMenuItem, Me.LettersToolStripMenuItem})
        Me.GameModeToolStripMenuItem.Name = "GameModeToolStripMenuItem"
        Me.GameModeToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.GameModeToolStripMenuItem.Text = "Game Mode"
        '
        'PictureToolStripMenuItem
        '
        Me.PictureToolStripMenuItem.Name = "PictureToolStripMenuItem"
        Me.PictureToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.PictureToolStripMenuItem.Text = "Picture"
        '
        'NumbersToolStripMenuItem
        '
        Me.NumbersToolStripMenuItem.Name = "NumbersToolStripMenuItem"
        Me.NumbersToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.NumbersToolStripMenuItem.Text = "Numbers"
        '
        'LettersToolStripMenuItem
        '
        Me.LettersToolStripMenuItem.Name = "LettersToolStripMenuItem"
        Me.LettersToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.LettersToolStripMenuItem.Text = "Letters"
        '
        'ColourThemeToolStripMenuItem
        '
        Me.ColourThemeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GreenToolStripMenuItem, Me.GreyScaleToolStripMenuItem, Me.BlueToolStripMenuItem, Me.RedToolStripMenuItem})
        Me.ColourThemeToolStripMenuItem.Name = "ColourThemeToolStripMenuItem"
        Me.ColourThemeToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ColourThemeToolStripMenuItem.Text = "Colour Theme"
        '
        'GreenToolStripMenuItem
        '
        Me.GreenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LightGreenToolStripMenuItem, Me.GreenToolStripMenuItem1})
        Me.GreenToolStripMenuItem.Name = "GreenToolStripMenuItem"
        Me.GreenToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.GreenToolStripMenuItem.Text = "Green"
        '
        'LightGreenToolStripMenuItem
        '
        Me.LightGreenToolStripMenuItem.Name = "LightGreenToolStripMenuItem"
        Me.LightGreenToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.LightGreenToolStripMenuItem.Text = "Light Green"
        '
        'GreenToolStripMenuItem1
        '
        Me.GreenToolStripMenuItem1.Name = "GreenToolStripMenuItem1"
        Me.GreenToolStripMenuItem1.Size = New System.Drawing.Size(135, 22)
        Me.GreenToolStripMenuItem1.Text = "Green"
        '
        'GreyScaleToolStripMenuItem
        '
        Me.GreyScaleToolStripMenuItem.Name = "GreyScaleToolStripMenuItem"
        Me.GreyScaleToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.GreyScaleToolStripMenuItem.Text = "Grey Scale"
        '
        'BlueToolStripMenuItem
        '
        Me.BlueToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LightBlueToolStripMenuItem, Me.BlueToolStripMenuItem1})
        Me.BlueToolStripMenuItem.Name = "BlueToolStripMenuItem"
        Me.BlueToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.BlueToolStripMenuItem.Text = "Blue"
        '
        'LightBlueToolStripMenuItem
        '
        Me.LightBlueToolStripMenuItem.Name = "LightBlueToolStripMenuItem"
        Me.LightBlueToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.LightBlueToolStripMenuItem.Text = "Light Blue"
        '
        'BlueToolStripMenuItem1
        '
        Me.BlueToolStripMenuItem1.Name = "BlueToolStripMenuItem1"
        Me.BlueToolStripMenuItem1.Size = New System.Drawing.Size(127, 22)
        Me.BlueToolStripMenuItem1.Text = "Blue"
        '
        'RedToolStripMenuItem
        '
        Me.RedToolStripMenuItem.Name = "RedToolStripMenuItem"
        Me.RedToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.RedToolStripMenuItem.Text = "Purple"
        '
        'Button17
        '
        Me.Button17.Location = New System.Drawing.Point(12, 495)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(69, 59)
        Me.Button17.TabIndex = 4
        Me.Button17.Text = "Numberx"
        Me.Button17.UseVisualStyleBackColor = True
        Me.Button17.Visible = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(963, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(280, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Can You Make This?"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label4.UseMnemonic = False
        Me.Label4.Visible = False
        '
        'lblTimer
        '
        Me.lblTimer.BackColor = System.Drawing.Color.Transparent
        Me.lblTimer.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(699, 327)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(207, 28)
        Me.lblTimer.TabIndex = 2
        Me.lblTimer.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'tmrCountdown
        '
        Me.tmrCountdown.Interval = 1000
        '
        'Button18
        '
        Me.Button18.Location = New System.Drawing.Point(12, 560)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(69, 59)
        Me.Button18.TabIndex = 4
        Me.Button18.Text = "Picturex"
        Me.Button18.UseVisualStyleBackColor = True
        Me.Button18.Visible = False
        '
        'Button19
        '
        Me.Button19.Location = New System.Drawing.Point(12, 625)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(69, 59)
        Me.Button19.TabIndex = 4
        Me.Button19.Text = "Lettersx"
        Me.Button19.UseVisualStyleBackColor = True
        Me.Button19.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(769, 299)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Time"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSalmon
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(11, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 90)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightSalmon
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(101, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 90)
        Me.Button2.TabIndex = 2
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightSalmon
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(191, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 90)
        Me.Button3.TabIndex = 2
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LightSalmon
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(281, 16)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(90, 90)
        Me.Button4.TabIndex = 2
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.LightSalmon
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(11, 105)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(90, 90)
        Me.Button5.TabIndex = 2
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.LightSalmon
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Location = New System.Drawing.Point(101, 105)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(90, 90)
        Me.Button6.TabIndex = 2
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.LightSalmon
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Black
        Me.Button7.Location = New System.Drawing.Point(191, 105)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(90, 90)
        Me.Button7.TabIndex = 2
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.LightSalmon
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.Black
        Me.Button8.Location = New System.Drawing.Point(281, 105)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(90, 90)
        Me.Button8.TabIndex = 2
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.LightSalmon
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button9.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.Black
        Me.Button9.Location = New System.Drawing.Point(12, 194)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(90, 90)
        Me.Button9.TabIndex = 2
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.LightSalmon
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button10.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.Black
        Me.Button10.Location = New System.Drawing.Point(102, 194)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(90, 90)
        Me.Button10.TabIndex = 2
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.LightSalmon
        Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button11.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.Black
        Me.Button11.Location = New System.Drawing.Point(191, 194)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(90, 90)
        Me.Button11.TabIndex = 2
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.LightSalmon
        Me.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button12.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.ForeColor = System.Drawing.Color.Black
        Me.Button12.Location = New System.Drawing.Point(281, 194)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(90, 90)
        Me.Button12.TabIndex = 2
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.LightSalmon
        Me.Button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button13.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.ForeColor = System.Drawing.Color.Black
        Me.Button13.Location = New System.Drawing.Point(12, 283)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(90, 90)
        Me.Button13.TabIndex = 2
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.LightSalmon
        Me.Button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button14.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.ForeColor = System.Drawing.Color.Black
        Me.Button14.Location = New System.Drawing.Point(102, 283)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(90, 90)
        Me.Button14.TabIndex = 2
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.LightSalmon
        Me.Button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button15.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button15.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.ForeColor = System.Drawing.Color.Black
        Me.Button15.Location = New System.Drawing.Point(191, 283)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(90, 90)
        Me.Button15.TabIndex = 2
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.LightSalmon
        Me.Button16.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button16.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.ForeColor = System.Drawing.Color.Black
        Me.Button16.Location = New System.Drawing.Point(281, 283)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(90, 90)
        Me.Button16.TabIndex = 2
        Me.Button16.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button16)
        Me.GroupBox1.Controls.Add(Me.Button15)
        Me.GroupBox1.Controls.Add(Me.Button14)
        Me.GroupBox1.Controls.Add(Me.Button13)
        Me.GroupBox1.Controls.Add(Me.Button12)
        Me.GroupBox1.Controls.Add(Me.Button11)
        Me.GroupBox1.Controls.Add(Me.Button10)
        Me.GroupBox1.Controls.Add(Me.Button9)
        Me.GroupBox1.Controls.Add(Me.Button8)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Location = New System.Drawing.Point(264, 159)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Size = New System.Drawing.Size(383, 382)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(699, 379)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(207, 36)
        Me.lblTime.TabIndex = 8
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tmrLoop
        '
        Me.tmrLoop.Interval = 1000
        '
        'btnResetL
        '
        Me.btnResetL.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetL.Location = New System.Drawing.Point(748, 460)
        Me.btnResetL.Name = "btnResetL"
        Me.btnResetL.Size = New System.Drawing.Size(108, 29)
        Me.btnResetL.TabIndex = 9
        Me.btnResetL.Text = "Reset"
        Me.btnResetL.UseVisualStyleBackColor = True
        '
        'btnResetP
        '
        Me.btnResetP.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetP.Location = New System.Drawing.Point(748, 460)
        Me.btnResetP.Name = "btnResetP"
        Me.btnResetP.Size = New System.Drawing.Size(108, 29)
        Me.btnResetP.TabIndex = 10
        Me.btnResetP.Text = "Reset"
        Me.btnResetP.UseVisualStyleBackColor = True
        '
        'btnResetN
        '
        Me.btnResetN.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetN.Location = New System.Drawing.Point(748, 460)
        Me.btnResetN.Name = "btnResetN"
        Me.btnResetN.Size = New System.Drawing.Size(108, 29)
        Me.btnResetN.TabIndex = 11
        Me.btnResetN.Text = "Reset"
        Me.btnResetN.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.ShuffleGame.My.Resources.Resources.minion
        Me.PictureBox1.Location = New System.Drawing.Point(952, 196)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(302, 302)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'lbl5
        '
        Me.lbl5.BackColor = System.Drawing.Color.Transparent
        Me.lbl5.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.Location = New System.Drawing.Point(952, 252)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(302, 190)
        Me.lbl5.TabIndex = 12
        Me.lbl5.Text = "To Start game, select a puzzle type from the Game Mode menu at the top of the scr" & _
    "een."
        Me.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScNam1
        '
        Me.lblScNam1.BackColor = System.Drawing.Color.Transparent
        Me.lblScNam1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScNam1.Location = New System.Drawing.Point(67, 20)
        Me.lblScNam1.Name = "lblScNam1"
        Me.lblScNam1.Size = New System.Drawing.Size(100, 23)
        Me.lblScNam1.TabIndex = 13
        Me.lblScNam1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScTime1
        '
        Me.lblScTime1.BackColor = System.Drawing.Color.Transparent
        Me.lblScTime1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScTime1.Location = New System.Drawing.Point(173, 20)
        Me.lblScTime1.Name = "lblScTime1"
        Me.lblScTime1.Size = New System.Drawing.Size(100, 23)
        Me.lblScTime1.TabIndex = 13
        Me.lblScTime1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScNam2
        '
        Me.lblScNam2.BackColor = System.Drawing.Color.Transparent
        Me.lblScNam2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScNam2.Location = New System.Drawing.Point(67, 50)
        Me.lblScNam2.Name = "lblScNam2"
        Me.lblScNam2.Size = New System.Drawing.Size(100, 23)
        Me.lblScNam2.TabIndex = 13
        Me.lblScNam2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScTime2
        '
        Me.lblScTime2.BackColor = System.Drawing.Color.Transparent
        Me.lblScTime2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScTime2.Location = New System.Drawing.Point(173, 50)
        Me.lblScTime2.Name = "lblScTime2"
        Me.lblScTime2.Size = New System.Drawing.Size(100, 23)
        Me.lblScTime2.TabIndex = 13
        Me.lblScTime2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScNam3
        '
        Me.lblScNam3.BackColor = System.Drawing.Color.Transparent
        Me.lblScNam3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScNam3.Location = New System.Drawing.Point(67, 79)
        Me.lblScNam3.Name = "lblScNam3"
        Me.lblScNam3.Size = New System.Drawing.Size(100, 23)
        Me.lblScNam3.TabIndex = 13
        Me.lblScNam3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScTime3
        '
        Me.lblScTime3.BackColor = System.Drawing.Color.Transparent
        Me.lblScTime3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScTime3.Location = New System.Drawing.Point(173, 79)
        Me.lblScTime3.Name = "lblScTime3"
        Me.lblScTime3.Size = New System.Drawing.Size(100, 23)
        Me.lblScTime3.TabIndex = 13
        Me.lblScTime3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScNam4
        '
        Me.lblScNam4.BackColor = System.Drawing.Color.Transparent
        Me.lblScNam4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScNam4.Location = New System.Drawing.Point(67, 110)
        Me.lblScNam4.Name = "lblScNam4"
        Me.lblScNam4.Size = New System.Drawing.Size(100, 23)
        Me.lblScNam4.TabIndex = 13
        Me.lblScNam4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScTime4
        '
        Me.lblScTime4.BackColor = System.Drawing.Color.Transparent
        Me.lblScTime4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScTime4.Location = New System.Drawing.Point(173, 110)
        Me.lblScTime4.Name = "lblScTime4"
        Me.lblScTime4.Size = New System.Drawing.Size(100, 23)
        Me.lblScTime4.TabIndex = 13
        Me.lblScTime4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScNam5
        '
        Me.lblScNam5.BackColor = System.Drawing.Color.Transparent
        Me.lblScNam5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScNam5.Location = New System.Drawing.Point(67, 141)
        Me.lblScNam5.Name = "lblScNam5"
        Me.lblScNam5.Size = New System.Drawing.Size(100, 23)
        Me.lblScNam5.TabIndex = 13
        Me.lblScNam5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScTime5
        '
        Me.lblScTime5.BackColor = System.Drawing.Color.Transparent
        Me.lblScTime5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScTime5.Location = New System.Drawing.Point(173, 141)
        Me.lblScTime5.Name = "lblScTime5"
        Me.lblScTime5.Size = New System.Drawing.Size(100, 23)
        Me.lblScTime5.TabIndex = 13
        Me.lblScTime5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(48, 182)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(132, 20)
        Me.txtName.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(55, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Enter Name Here"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 23)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "1st"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 23)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "2nd"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(25, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 23)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "3rd"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(21, 107)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 23)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "4th"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(25, 141)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 23)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "5th"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn20
        '
        Me.btn20.Location = New System.Drawing.Point(276, 599)
        Me.btn20.Name = "btn20"
        Me.btn20.Size = New System.Drawing.Size(145, 49)
        Me.btn20.TabIndex = 17
        Me.btn20.Text = "Button20"
        Me.btn20.UseVisualStyleBackColor = True
        '
        'btn21
        '
        Me.btn21.Location = New System.Drawing.Point(490, 599)
        Me.btn21.Name = "btn21"
        Me.btn21.Size = New System.Drawing.Size(145, 49)
        Me.btn21.TabIndex = 17
        Me.btn21.Text = "Button21"
        Me.btn21.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblScTime5)
        Me.GroupBox2.Controls.Add(Me.lblScTime4)
        Me.GroupBox2.Controls.Add(Me.lblScTime3)
        Me.GroupBox2.Controls.Add(Me.lblScTime2)
        Me.GroupBox2.Controls.Add(Me.lblScTime1)
        Me.GroupBox2.Controls.Add(Me.lblScNam5)
        Me.GroupBox2.Controls.Add(Me.lblScNam4)
        Me.GroupBox2.Controls.Add(Me.lblScNam3)
        Me.GroupBox2.Controls.Add(Me.lblScNam2)
        Me.GroupBox2.Controls.Add(Me.lblScNam1)
        Me.GroupBox2.Location = New System.Drawing.Point(653, 505)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(298, 179)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        '
        'txtCheat
        '
        Me.txtCheat.Location = New System.Drawing.Point(12, 745)
        Me.txtCheat.Name = "txtCheat"
        Me.txtCheat.Size = New System.Drawing.Size(101, 20)
        Me.txtCheat.TabIndex = 19
        '
        'btnCheatHide
        '
        Me.btnCheatHide.Location = New System.Drawing.Point(119, 740)
        Me.btnCheatHide.Name = "btnCheatHide"
        Me.btnCheatHide.Size = New System.Drawing.Size(78, 29)
        Me.btnCheatHide.TabIndex = 20
        Me.btnCheatHide.Text = "Hide Cheats"
        Me.btnCheatHide.UseVisualStyleBackColor = True
        '
        'Button20
        '
        Me.Button20.Location = New System.Drawing.Point(760, 44)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(125, 47)
        Me.Button20.TabIndex = 21
        Me.Button20.Text = "Button20"
        Me.Button20.UseVisualStyleBackColor = True
        '
        'ShuffleGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1331, 777)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button20)
        Me.Controls.Add(Me.btnCheatHide)
        Me.Controls.Add(Me.txtCheat)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn21)
        Me.Controls.Add(Me.btn20)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.btnResetN)
        Me.Controls.Add(Me.btnResetP)
        Me.Controls.Add(Me.btnResetL)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button19)
        Me.Controls.Add(Me.Button18)
        Me.Controls.Add(Me.Button17)
        Me.Controls.Add(Me.lblClicks)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ShuffleGame"
        Me.Text = "ShuffleGame"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblClicks As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GameModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NumbersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LettersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents ColourThemeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GreenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTimer As System.Windows.Forms.Label
    Friend WithEvents tmrCountdown As System.Windows.Forms.Timer
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents Button19 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GreyScaleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BlueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LightBlueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LightGreenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GreenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlueToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents tmrLoop As System.Windows.Forms.Timer
    Friend WithEvents btnResetL As System.Windows.Forms.Button
    Friend WithEvents btnResetP As System.Windows.Forms.Button
    Friend WithEvents btnResetN As System.Windows.Forms.Button
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents lblScNam1 As System.Windows.Forms.Label
    Friend WithEvents lblScTime1 As System.Windows.Forms.Label
    Friend WithEvents lblScNam2 As System.Windows.Forms.Label
    Friend WithEvents lblScTime2 As System.Windows.Forms.Label
    Friend WithEvents lblScNam3 As System.Windows.Forms.Label
    Friend WithEvents lblScTime3 As System.Windows.Forms.Label
    Friend WithEvents lblScNam4 As System.Windows.Forms.Label
    Friend WithEvents lblScTime4 As System.Windows.Forms.Label
    Friend WithEvents lblScNam5 As System.Windows.Forms.Label
    Friend WithEvents lblScTime5 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btn20 As System.Windows.Forms.Button
    Friend WithEvents btn21 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCheat As System.Windows.Forms.TextBox
    Friend WithEvents btnCheatHide As System.Windows.Forms.Button
    Friend WithEvents Button20 As System.Windows.Forms.Button

End Class
