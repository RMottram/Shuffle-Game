'these are system events declared at the begining of the form 
Imports System.Globalization
Imports System.Threading
Imports System.ComponentModel
Imports System.Data.OleDb

Public Class ShuffleGame

    Public Count As Integer
    Public myValue As Object
    Private gtype As String = ""

    Public cheat As String = "password"

    Public nme1 As String
    Public nme2 As String
    Public nme3 As String
    Public nme4 As String
    Public nme5 As String
    Public tme1 As String
    Public tme2 As String
    Public tme3 As String
    Public tme4 As String
    Public tme5 As String

    Public img1 As Image = My.Resources.minion_01
    Public img2 As Image = My.Resources.minion_02
    Public img3 As Image = My.Resources.minion_03
    Public img4 As Image = My.Resources.minion_04
    Public img5 As Image = My.Resources.minion_05
    Public img6 As Image = My.Resources.minion_06
    Public img7 As Image = My.Resources.minion_07
    Public img8 As Image = My.Resources.minion_08
    Public img9 As Image = My.Resources.minion_09
    Public img10 As Image = My.Resources.minion_10
    Public img11 As Image = My.Resources.minion_11
    Public img12 As Image = My.Resources.minion_12
    Public img13 As Image = My.Resources.minion_13
    Public img14 As Image = My.Resources.minion_14
    Public img15 As Image = My.Resources.minion_15

    Dim message_flash As String

    Public timeEnd As DateTime 'calculating end time
    Public timeDiff As TimeSpan ' difference between start and end times

    Public Const dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=..\..\..\Score.accdb"

   Private Sub Scores()

        Dim intMaxUsers As Integer = 0

        '   Declare variables for opening the HighScores table from the database
        Dim connScDetails As New OleDb.OleDbConnection
        Dim daScDetails As New OleDb.OleDbDataAdapter
        Dim sqlScDetails As String = "SELECT * FROM HighScores"
        Dim dsScDetails As New DataSet

        connScDetails.ConnectionString = dbProvider
        connScDetails.Open()
        daScDetails = New OleDb.OleDbDataAdapter(sqlScDetails, connScDetails)
        daScDetails.Fill(dsScDetails, "HighScores")

        lblScNam1.Text = dsScDetails.Tables("HighScores").Rows(0).Item(1)
        lblScTime1.Text = dsScDetails.Tables("HighScores").Rows(0).Item(3)
        ' lblScClicks.Text = dsScDetails.Tables("HighScores").Rows(0).Item(2)
        lblScNam2.Text = dsScDetails.Tables("HighScores").Rows(1).Item(1)
        lblScTime2.Text = dsScDetails.Tables("HighScores").Rows(1).Item(3)
        lblScNam3.Text = dsScDetails.Tables("HighScores").Rows(2).Item(1)
        lblScTime3.Text = dsScDetails.Tables("HighScores").Rows(2).Item(3)
        lblScNam4.Text = dsScDetails.Tables("HighScores").Rows(3).Item(1)
        lblScTime4.Text = dsScDetails.Tables("HighScores").Rows(3).Item(3)
        lblScNam5.Text = dsScDetails.Tables("HighScores").Rows(4).Item(1)
        lblScTime5.Text = dsScDetails.Tables("HighScores").Rows(4).Item(3)

        connScDetails.Close()


    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'this code calls on the checkbutton routine defined in Module1 as well as checks the adjacent buttons next to this button (button1)
        'the buttons are 2 and 5

        CheckButton(Button1, Button2)
        CheckButton(Button1, Button5)
        'this calls on the checksmoved routine in Module1, it checks if all buttons are correct
        ChecksMoved()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CheckButton(Button2, Button1)
        CheckButton(Button2, Button3)
        CheckButton(Button2, Button6)
        ChecksMoved()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CheckButton(Button3, Button2)
        CheckButton(Button3, Button7)
        CheckButton(Button3, Button4)
        ChecksMoved()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        CheckButton(Button4, Button3)
        CheckButton(Button4, Button8)
        ChecksMoved()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CheckButton(Button5, Button1)
        CheckButton(Button5, Button6)
        CheckButton(Button5, Button9)
        ChecksMoved()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        CheckButton(Button6, Button2)
        CheckButton(Button6, Button5)
        CheckButton(Button6, Button7)
        CheckButton(Button6, Button10)
        ChecksMoved()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        CheckButton(Button7, Button3)
        CheckButton(Button7, Button6)
        CheckButton(Button7, Button8)
        CheckButton(Button7, Button11)
        ChecksMoved()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        CheckButton(Button8, Button4)
        CheckButton(Button8, Button7)
        CheckButton(Button8, Button12)
        ChecksMoved()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        CheckButton(Button9, Button5)
        CheckButton(Button9, Button10)
        CheckButton(Button9, Button13)
        ChecksMoved()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        CheckButton(Button10, Button6)
        CheckButton(Button10, Button9)
        CheckButton(Button10, Button11)
        CheckButton(Button10, Button14)
        ChecksMoved()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        CheckButton(Button11, Button7)
        CheckButton(Button11, Button10)
        CheckButton(Button11, Button12)
        CheckButton(Button11, Button15)
        ChecksMoved()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        CheckButton(Button12, Button8)
        CheckButton(Button12, Button11)
        CheckButton(Button12, Button16)
        ChecksMoved()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        CheckButton(Button13, Button9)
        CheckButton(Button13, Button14)
        ChecksMoved()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        CheckButton(Button14, Button10)
        CheckButton(Button14, Button13)
        CheckButton(Button14, Button15)
        ChecksMoved()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        CheckButton(Button15, Button11)
        CheckButton(Button15, Button14)
        CheckButton(Button15, Button16)
        ChecksMoved()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        CheckButton(Button16, Button12)
        CheckButton(Button16, Button15)
        ChecksMoved()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim x = MsgBox("Are you sure you want to exit?", vbOKCancel + vbQuestion)
        If (x = Windows.Forms.DialogResult.OK) Then
            Application.Exit()
        Else
        End If

    End Sub

    Private Sub LettersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LettersToolStripMenuItem.Click
        gtype = "letter"
        Button1.Image = Nothing
        Button2.Image = Nothing
        Button3.Image = Nothing
        Button4.Image = Nothing
        Button5.Image = Nothing
        Button6.Image = Nothing
        Button7.Image = Nothing
        Button8.Image = Nothing
        Button9.Image = Nothing
        Button10.Image = Nothing
        Button11.Image = Nothing
        Button12.Image = Nothing
        Button13.Image = Nothing
        Button14.Image = Nothing
        Button15.Image = Nothing
        Button16.Image = Nothing

        lbl5.Visible = False

        'from menu strip this will select the letters game
        ResetL()
        'reset click counter to 0
        Me.Count = 0
        'empty label counter 
        lblClicks.Text = ""
        'change the form name
        Me.Text = "Letters Puzzle"

        btnResetP.Visible = False
        btnResetN.Visible = False
        btnResetL.Visible = True

        'hides the picture box and lable on this game mode
        Label4.Visible = False
        PictureBox1.Visible = False

        timeEnd = DateTime.Now
        Dim minute As Double = System.Convert.ToDouble(0) 'minutes
        Dim second As Double = System.Convert.ToDouble(0) 'seconds

        timeEnd = timeEnd.AddMinutes(0) 'add minutes
        timeEnd = timeEnd.AddSeconds(0) 'add seconds

        tmrLoop.Start()

        If Button1.Text = "A" And Button2.Text = "B" And Button3.Text = "C" And Button4.Text = "D" And Button5.Text = "E" And Button6.Text = "F" And Button7.Text = "G" And
            Button8.Text = "H" And Button9.Text = "I" And Button10.Text = "J" And Button11.Text = "K" And Button12.Text = "L" And Button13.Text = "M" And
            Button14.Text = "N" And Button15.Text = "O" And Button16.Text = "" Then
            Scores()

            nme1 = lblScNam1.Text
            nme2 = lblScNam2.Text
            nme3 = lblScNam3.Text
            nme4 = lblScNam4.Text
            nme5 = lblScNam5.Text
            tme1 = lblScTime1.Text
            tme2 = lblScTime2.Text
            tme3 = lblScTime3.Text
            tme4 = lblScTime4.Text
            tme5 = lblScTime5.Text

        End If

    End Sub

    Private Sub NumbersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NumbersToolStripMenuItem.Click
        gtype = "number"
        Button1.Image = Nothing
        Button2.Image = Nothing
        Button3.Image = Nothing
        Button4.Image = Nothing
        Button5.Image = Nothing
        Button6.Image = Nothing
        Button7.Image = Nothing
        Button8.Image = Nothing
        Button9.Image = Nothing
        Button10.Image = Nothing
        Button11.Image = Nothing
        Button12.Image = Nothing
        Button13.Image = Nothing
        Button14.Image = Nothing
        Button15.Image = Nothing
        Button16.Image = Nothing

        lbl5.Visible = False

        'from menu strip this will select the numbers game
        ResetN()
        'reset click counter to 0
        Me.Count = 0
        'empty label counter 
        lblClicks.Text = ""
        'change the form name
        Me.Text = "Numbers Puzzle"

        btnResetP.Visible = False
        btnResetN.Visible = True
        btnResetL.Visible = False

        'hides the picture box and lable on this game mode
        Label4.Visible = False
        PictureBox1.Visible = False

        timeEnd = DateTime.Now
        Dim minute As Double = System.Convert.ToDouble(0) 'minutes
        Dim second As Double = System.Convert.ToDouble(0) 'seconds

        timeEnd = timeEnd.AddMinutes(minute) 'add minutes
        timeEnd = timeEnd.AddSeconds(second) 'add seconds



        If Button1.Text = "1" And Button2.Text = "2" And Button3.Text = "3" And Button4.Text = "4" And Button5.Text = "5" And Button6.Text = "6" And
            Button7.Text = "7" And Button8.Text = "8" And Button9.Text = "9" And Button10.Text = "10" And Button11.Text = "11" And
            Button12.Text = "12" And Button13.Text = "13" And Button14.Text = "14" And Button15.Text = "15" And
            Button16.Text = "" Then
            Scores()

            nme1 = lblScNam1.Text
            nme2 = lblScNam2.Text
            nme3 = lblScNam3.Text
            nme4 = lblScNam4.Text
            nme5 = lblScNam5.Text
            tme1 = lblScTime1.Text
            tme2 = lblScTime2.Text
            tme3 = lblScTime3.Text
            tme4 = lblScTime4.Text
            tme5 = lblScTime5.Text

        End If
        tmrLoop.Start()


    End Sub

    Private Sub PictureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PictureToolStripMenuItem.Click
        gtype = "picture"
        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""
        Button10.Text = ""
        Button11.Text = ""
        Button12.Text = ""
        Button13.Text = ""
        Button14.Text = ""
        Button15.Text = ""
        Button16.Text = ""

        lbl5.Visible = False

        If Button1.Image Is My.Resources.minion_01 And Button2.Image Is My.Resources.minion_02 And Button3.Image Is My.Resources.minion_03 And Button4.Image Is My.Resources.minion_04 And
            Button5.Image Is My.Resources.minion_05 And Button6.Image Is My.Resources.minion_06 And Button7.Image Is My.Resources.minion_07 And Button8.Image Is My.Resources.minion_08 And
            Button9.Image Is My.Resources.minion_09 And Button10.Image Is My.Resources.minion_10 And Button11.Image Is My.Resources.minion_11 And Button12.Image Is My.Resources.minion_12 And
            Button13.Image Is My.Resources.minion_13 And Button14.Image Is My.Resources.minion_14 And Button15.Image Is My.Resources.minion_15 And Button16.Text Is Nothing Then
            Scores()

            nme1 = lblScNam1.Text
            nme2 = lblScNam2.Text
            nme3 = lblScNam3.Text
            nme4 = lblScNam4.Text
            nme5 = lblScNam5.Text
            tme1 = lblScTime1.Text
            tme2 = lblScTime2.Text
            tme3 = lblScTime3.Text
            tme4 = lblScTime4.Text
            tme5 = lblScTime5.Text

        End If

        'from menu strip this will select the picture game
        ResetP()
        'reset click counter to 0
        Me.Count = 0
        'empty label counter 
        lblClicks.Text = ""
        'change the form name
        Me.Text = "Picture Puzzle"

        btnResetP.Visible = True
        btnResetN.Visible = False
        btnResetL.Visible = False

        'shows the picture box and label for this game mode
        Label4.Visible = True
        PictureBox1.Visible = True

        timeEnd = DateTime.Now
        Dim minute As Double = System.Convert.ToDouble(0) 'minutes
        Dim second As Double = System.Convert.ToDouble(0) 'seconds

        timeEnd = timeEnd.AddMinutes(minute) 'add minutes
        timeEnd = timeEnd.AddSeconds(second) 'add seconds

        tmrLoop.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lblTimer.Text = "Game Over!"
        If Timer1.Tag = True Then
            lblTimer.ForeColor = Color.Black
            lblTimer.BackColor = Color.Red
            Timer1.Tag = False
        Else
            lblTimer.ForeColor = Color.Red
            lblTimer.BackColor = Color.Black
            Timer1.Tag = True
        End If

    End Sub

    Private Sub ShuffleGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '1000 - 1 second
        Timer1.Interval = 1000
        Timer1.Enabled = False

        btnResetP.Visible = False
        btnResetN.Visible = False
        btnResetL.Visible = False

        lbl5.Visible = True


        Scores()
    End Sub
    Private Sub tmrCountdown_Tick(sender As Object, e As EventArgs) Handles tmrCountdown.Tick

        lblTimer.Text = Val(lblTimer.Text + 1)
        If lblTimer.Text = 0 Then
            message_flash = lblTimer.Text
            Timer1.Enabled = True
            lblTimer.Text = "Time left"
            tmrCountdown.Enabled = False
        End If

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        'cheat button that will set numbers in the correct order. (Testing Purposes)
        Button1.Text = "1"
        Button2.Text = "2"
        Button3.Text = "3"
        Button4.Text = "4"
        Button5.Text = "5"
        Button6.Text = "6"
        Button7.Text = "7"
        Button8.Text = "8"
        Button9.Text = "9"
        Button10.Text = "10"
        Button11.Text = "11"
        Button12.Text = "12"
        Button13.Text = "13"
        Button14.Text = "14"
        Button15.Text = "15"
        Button16.Text = ""

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        'cheat button that will set picture in the correct order. (Testing Purposes)
        Button1.Image = img1
        Button2.Image = img2
        Button3.Image = img3
        Button4.Image = img4
        Button5.Image = img5
        Button6.Image = img6
        Button7.Image = img7
        Button8.Image = img8
        Button9.Image = img9
        Button10.Image = img10
        Button11.Image = img11
        Button12.Image = img12
        Button13.Image = img13
        Button14.Image = img14
        Button15.Image = img15
        Button16.Text = ""

    End Sub


    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        'cheat button that will set letters in the correct order. (Testing Purposes)
        Button1.Text = "A"
        Button2.Text = "B"
        Button3.Text = "C"
        Button4.Text = "D"
        Button5.Text = "E"
        Button6.Text = "F"
        Button7.Text = "G"
        Button8.Text = "H"
        Button9.Text = "I"
        Button10.Text = "J"
        Button11.Text = "K"
        Button12.Text = "L"
        Button13.Text = "M"
        Button14.Text = "N"
        Button15.Text = "O"
        Button16.Text = ""

    End Sub
    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click

        HelpScreen.Show()
        Me.Hide()

    End Sub
    Private Sub LightGreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightGreenToolStripMenuItem.Click

        Me.BackColor = Color.LightGreen

    End Sub
    Private Sub GreyScaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyScaleToolStripMenuItem.Click
        Me.BackColor = Color.LightGray

    End Sub


    Private Sub PurpleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click

        Me.BackColor = Color.MediumPurple

    End Sub
    Private Sub LightBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightBlueToolStripMenuItem.Click

        Me.BackColor = Color.LightBlue

    End Sub


    Private Sub GreenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GreenToolStripMenuItem1.Click

        Me.BackColor = Color.Green

    End Sub

    Private Sub BlueToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BlueToolStripMenuItem1.Click

        Me.BackColor = Color.DodgerBlue

    End Sub

    Private Sub tmrLoop_Tick(sender As Object, e As EventArgs) Handles tmrLoop.Tick

        Dim strFinalOutput As String 'output string

        timeDiff = timeEnd - DateTime.Now

        'calculate differences between start and end
        Dim output As TimeSpan = New TimeSpan(timeDiff.Hours, timeDiff.Minutes, timeDiff.Seconds)

        strFinalOutput = output.ToString().Substring(1) 'concatenates time

        lblTime.Text = strFinalOutput

        If (timeDiff.Ticks < 1) Then 'if time i 1 minute

        End If

        ' If (timeDiff.Ticks < 0) Then 'if time is up
        'Timer1.Enabled = True
        '  tmrLoop.Stop()
        '  MessageBox.Show("Time UP!")
        '  If vbOK Then
        'Timer1.Enabled = False
        '  lblTime.ForeColor = Color.Black
        ' lblTime.BackColor = Color.White
        '  lblTime.Text = ""
        ' End If
        '  End If
    End Sub

    Private Sub btnResetL_Click(sender As Object, e As EventArgs) Handles btnResetL.Click

        'from menu strip this will select the letters game
        ResetL()
        'reset click counter to 0
        Me.Count = 0
        'empty label counter 
        lblClicks.Text = ""
        'change the form name
        Me.Text = "Letters Puzzle"

        btnResetP.Visible = False
        btnResetN.Visible = False
        btnResetL.Visible = True

        'hides the picture box and lable on this game mode
        Label4.Visible = False
        PictureBox1.Visible = False

        tmrCountdown.Enabled = False
        Timer1.Enabled = False
        lblTimer.Text = ""
        lblTimer.ForeColor = Color.Black
        lblTimer.BackColor = Color.White

        tmrCountdown.Enabled = False
        Timer1.Enabled = False
        lblTimer.Text = ""
        lblTimer.ForeColor = Color.Black
        lblTimer.BackColor = Color.White

        timeEnd = DateTime.Now
        Dim minute As Double = System.Convert.ToDouble(0) 'minutes
        Dim second As Double = System.Convert.ToDouble(0) 'seconds

        timeEnd = timeEnd.AddMinutes(minute) 'add minutes
        timeEnd = timeEnd.AddSeconds(second) 'add seconds

        tmrLoop.Start()


    End Sub

    Private Sub btnResetN_Click(sender As Object, e As EventArgs) Handles btnResetN.Click

        'from menu strip this will select the numbers game
        ResetN()
        'reset click counter to 0
        Me.Count = 0
        'empty label counter 
        lblClicks.Text = ""
        'change the form name
        Me.Text = "Numbers Puzzle"

        btnResetP.Visible = False
        btnResetN.Visible = True
        btnResetL.Visible = False

        'hides the picture box and lable on this game mode
        Label4.Visible = False
        PictureBox1.Visible = False

        tmrCountdown.Enabled = False
        Timer1.Enabled = False
        lblTimer.Text = ""
        lblTimer.ForeColor = Color.Black
        lblTimer.BackColor = Color.White

        timeEnd = DateTime.Now
        Dim minute As Double = System.Convert.ToDouble(0) 'minutes
        Dim second As Double = System.Convert.ToDouble(0) 'seconds

        timeEnd = timeEnd.AddMinutes(minute) 'add minutes
        timeEnd = timeEnd.AddSeconds(second) 'add seconds

        tmrLoop.Start()

      

    End Sub

    Private Sub btnResetP_Click(sender As Object, e As EventArgs) Handles btnResetP.Click

        'from menu strip this will select the picture game
        ResetP()
        'reset click counter to 0
        Me.Count = 0
        'empty label counter 
        lblClicks.Text = ""
        'change the form name
        Me.Text = "Picture Puzzle"

        btnResetP.Visible = True
        btnResetN.Visible = False
        btnResetL.Visible = False

        'shows the picture box and label for this game mode
        Label4.Visible = True
        PictureBox1.Visible = True

        tmrCountdown.Enabled = False
        Timer1.Enabled = False
        lblTimer.Text = ""
        lblTimer.ForeColor = Color.Black
        lblTimer.BackColor = Color.White

        timeEnd = DateTime.Now
        Dim minute As Double = System.Convert.ToDouble(3) 'minutes
        Dim second As Double = System.Convert.ToDouble(0) 'seconds

        timeEnd = timeEnd.AddMinutes(minute) 'add minutes
        timeEnd = timeEnd.AddSeconds(second) 'add seconds

        tmrLoop.Start()

    End Sub

    Private Sub btn20_Click(sender As Object, e As EventArgs) Handles btn20.Click

        timeEnd = DateTime.Now
        Dim minute As Double = System.Convert.ToDouble(0) 'minutes
        Dim second As Double = System.Convert.ToDouble(0) 'seconds

        timeEnd = timeEnd.AddMinutes(0) 'add minutes
        timeEnd = timeEnd.AddSeconds(0) 'add seconds

        tmrLoop.Start()

    End Sub

    Private Sub btn21_Click(sender As Object, e As EventArgs) Handles btn21.Click

        nme1 = lblScNam1.Text
        nme2 = lblScNam2.Text
        nme3 = lblScNam3.Text
        nme4 = lblScNam4.Text
        nme5 = lblScNam5.Text
        tme1 = lblScTime1.Text
        tme2 = lblScTime2.Text
        tme3 = lblScTime3.Text
        tme4 = lblScTime4.Text
        tme5 = lblScTime5.Text

        Dim connScDetails As New OleDb.OleDbConnection
        Dim daScDetails As New OleDb.OleDbDataAdapter
        Dim sqlScDetails As String = "SELECT * FROM HighScores"
        Dim dsScDetails As New DataSet

        tmrLoop.Enabled = False
        connScDetails.ConnectionString = dbProvider
        connScDetails.Open()
        daScDetails = New OleDb.OleDbDataAdapter(sqlScDetails, connScDetails)
        daScDetails.Fill(dsScDetails, "HighScores")

        Dim cb As New OleDb.OleDbCommandBuilder(daScDetails)
        Dim inc As Integer = 0
        Dim nme As String

        nme = txtName.Text
        ' MsgBox(lblTime.Text)

        'first place
        If (lblTime.Text <= lblScTime1.Text) Then
            dsScDetails.Tables("HighScores").Rows(0).Item(1) = txtName.Text
            dsScDetails.Tables("HighScores").Rows(0).Item(3) = lblTime.Text
            ' dsScDetails.Tables("HighScores").Rows(0).Item(2) = lblClick.Text

            dsScDetails.Tables("HighScores").Rows(1).Item(1) = nme1
            dsScDetails.Tables("HighScores").Rows(1).Item(3) = tme1

            dsScDetails.Tables("HighScores").Rows(2).Item(1) = nme2
            dsScDetails.Tables("HighScores").Rows(2).Item(3) = tme2

            dsScDetails.Tables("HighScores").Rows(3).Item(1) = nme3
            dsScDetails.Tables("HighScores").Rows(3).Item(3) = tme3

            dsScDetails.Tables("HighScores").Rows(4).Item(1) = nme4
            dsScDetails.Tables("HighScores").Rows(4).Item(3) = tme4

            daScDetails.Update(dsScDetails, "HighScores")
            MsgBox("Well done" & " " & [nme] & " " & "You are in First place!")

            'second place
        ElseIf (lblTime.Text >= lblScTime1.Text) And (lblTime.Text <= lblScTime2.Text) Then

            dsScDetails.Tables("HighScores").Rows(1).Item(1) = txtName.Text
            dsScDetails.Tables("HighScores").Rows(1).Item(3) = lblTime.Text
            ' dsScDetails.Tables("HighScores").Rows(1).Item(2) = lblClick.Text

            dsScDetails.Tables("HighScores").Rows(2).Item(1) = nme2
            dsScDetails.Tables("HighScores").Rows(2).Item(3) = tme2

            dsScDetails.Tables("HighScores").Rows(3).Item(1) = nme3
            dsScDetails.Tables("HighScores").Rows(3).Item(3) = tme3

            dsScDetails.Tables("HighScores").Rows(4).Item(1) = nme4
            dsScDetails.Tables("HighScores").Rows(4).Item(3) = tme4

            daScDetails.Update(dsScDetails, "HighScores")
            MsgBox("Well done" & " " & [nme] & " " & "You are in Second place!")

            'third place
        ElseIf (lblTime.Text >= lblScTime2.Text) And (lblTime.Text <= lblScTime3.Text) Then

            dsScDetails.Tables("HighScores").Rows(2).Item(1) = txtName.Text
            dsScDetails.Tables("HighScores").Rows(2).Item(3) = lblTime.Text
            ' dsScDetails.Tables("HighScores").Rows(2).Item(2) = lblClick.Text

            dsScDetails.Tables("HighScores").Rows(3).Item(1) = nme3
            dsScDetails.Tables("HighScores").Rows(3).Item(3) = tme3

            dsScDetails.Tables("HighScores").Rows(4).Item(1) = nme3
            dsScDetails.Tables("HighScores").Rows(4).Item(3) = tme3

            daScDetails.Update(dsScDetails, "HighScores")
            MsgBox("Well done" & " " & [nme] & " " & "You are in Third place!")

            'fourth place
        ElseIf (lblTime.Text >= lblScTime3.Text) And (lblTime.Text <= lblScTime4.Text) Then

            dsScDetails.Tables("HighScores").Rows(3).Item(1) = txtName.Text
            dsScDetails.Tables("HighScores").Rows(3).Item(3) = lblTime.Text
            ' dsScDetails.Tables("HighScores").Rows(3).Item(2) = lblClick.Text

            dsScDetails.Tables("HighScores").Rows(4).Item(1) = nme4
            dsScDetails.Tables("HighScores").Rows(4).Item(3) = tme4

            daScDetails.Update(dsScDetails, "HighScores")
            MsgBox("Well done" & " " & [nme] & " " & "You are in Fourth place!")

            'fith place
        ElseIf (lblTime.Text >= lblScTime4.Text) And (lblTime.Text <= lblScTime5.Text) Then

            dsScDetails.Tables("HighScores").Rows(4).Item(1) = txtName.Text
            dsScDetails.Tables("HighScores").Rows(4).Item(3) = lblTime.Text
            ' dsScDetails.Tables("HighScores").Rows(4).Item(2) = lblClick.Text

            daScDetails.Update(dsScDetails, "HighScores")
            MsgBox("Well done" & " " & [nme] & " " & "You are in Fifth place!")

        Else
            MsgBox("Sorry you haven't made the leader board!  Try again")
        End If
        connScDetails.Close()
        ' MessageBox.Show("Data updated")
        Scores()

    End Sub

    Private Sub txtCheat_TextChanged(sender As Object, e As EventArgs) Handles txtCheat.TextChanged

        If txtCheat.Text = cheat Then
            Button17.Visible = True
            Button18.Visible = True
            Button19.Visible = True
            ' btn20.Visible = True
            'btn21.Visible = True
            txtCheat.Visible = False
        End If

    End Sub

    Private Sub btnCheatHide_Click(sender As Object, e As EventArgs) Handles btnCheatHide.Click

        If txtCheat.Text = cheat Then
            Button17.Visible = False
            Button18.Visible = False
            Button19.Visible = False
            'btn20.Visible = True
            'btn21.Visible = True
            txtCheat.Visible = True
            btnCheatHide.Visible = False
        End If

    End Sub

   
End Class