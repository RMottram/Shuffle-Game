Module Module1
    Public Const dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=..\..\..\Score.accdb"

   

    Sub CheckButton(ByRef Butt1 As Button, ByRef Butt2 As Button)
        'this routine is used by any form it is called on, it is used to check the adjacent buttons refered to on the selected code
        'this is statement checks to see if the form is visible (active)
        If ShuffleGame.Visible = True Then
            'if it is then it checks if butt2 is empty
            If Butt2.Text = "" Then
                ' if butt2 is empty, it will populate it with the text from butt1
                Butt2.Text = Butt1.Text
                'butt1 will then be cleared
                Butt1.Text = ""
            End If
        End If
        If ShuffleGame.Visible = True Then
            If Butt2.Image Is Nothing Then
                Butt2.Image = Butt1.Image
                Butt1.Image = Nothing
            End If
        End If
    End Sub

    Sub ChecksMoved()
        'this routine will look at all the buttons on the form to see if all the numbers are in the correct order
        If ShuffleGame.Button1.Text = "1" And ShuffleGame.Button2.Text = "2" And ShuffleGame.Button3.Text = "3" And ShuffleGame.Button4.Text = "4" And
        ShuffleGame.Button5.Text = "5" And ShuffleGame.Button6.Text = "6" And ShuffleGame.Button7.Text = "7" And ShuffleGame.Button8.Text = "8" And
        ShuffleGame.Button9.Text = "9" And ShuffleGame.Button10.Text = "10" And ShuffleGame.Button11.Text = "11" And ShuffleGame.Button12.Text = "12" And
        ShuffleGame.Button13.Text = "13" And ShuffleGame.Button14.Text = "14" And ShuffleGame.Button15.Text = "15" Then

            'if in correct order a message box appears stating you have won the game and in how many clicks (ShuffleGame.Count)
            ShuffleGame.nme1 = ShuffleGame.lblScNam1.Text
            ShuffleGame.nme2 = ShuffleGame.lblScNam2.Text
            ShuffleGame.nme3 = ShuffleGame.lblScNam3.Text
            ShuffleGame.nme4 = ShuffleGame.lblScNam4.Text
            ShuffleGame.nme5 = ShuffleGame.lblScNam5.Text
            ShuffleGame.tme1 = ShuffleGame.lblScTime1.Text
            ShuffleGame.tme2 = ShuffleGame.lblScTime2.Text
            ShuffleGame.tme3 = ShuffleGame.lblScTime3.Text
            ShuffleGame.tme4 = ShuffleGame.lblScTime4.Text
            ShuffleGame.tme5 = ShuffleGame.lblScTime5.Text

            Dim connScDetails As New OleDb.OleDbConnection
            Dim daScDetails As New OleDb.OleDbDataAdapter
            Dim sqlScDetails As String = "SELECT * FROM HighScores"
            Dim dsScDetails As New DataSet

            ShuffleGame.tmrLoop.Enabled = False
            connScDetails.ConnectionString = dbProvider
            connScDetails.Open()
            daScDetails = New OleDb.OleDbDataAdapter(sqlScDetails, connScDetails)
            daScDetails.Fill(dsScDetails, "HighScores")

            Dim cb As New OleDb.OleDbCommandBuilder(daScDetails)
            Dim inc As Integer = 0
            Dim nme As String

            nme = ShuffleGame.txtName.Text
            ' MsgBox(lblTime.Text)

            'first place
            If (ShuffleGame.lblTime.Text <= ShuffleGame.lblScTime1.Text) Then
                dsScDetails.Tables("HighScores").Rows(0).Item(1) = ShuffleGame.txtName.Text
                dsScDetails.Tables("HighScores").Rows(0).Item(3) = ShuffleGame.lblTime.Text
                ' dsScDetails.Tables("HighScores").Rows(0).Item(2) = lblClick.Text

                dsScDetails.Tables("HighScores").Rows(1).Item(1) = ShuffleGame.nme1
                dsScDetails.Tables("HighScores").Rows(1).Item(3) = ShuffleGame.tme1

                dsScDetails.Tables("HighScores").Rows(2).Item(1) = ShuffleGame.nme2
                dsScDetails.Tables("HighScores").Rows(2).Item(3) = ShuffleGame.tme2

                dsScDetails.Tables("HighScores").Rows(3).Item(1) = ShuffleGame.nme3
                dsScDetails.Tables("HighScores").Rows(3).Item(3) = ShuffleGame.tme3

                dsScDetails.Tables("HighScores").Rows(4).Item(1) = ShuffleGame.nme4
                dsScDetails.Tables("HighScores").Rows(4).Item(3) = ShuffleGame.tme4

                daScDetails.Update(dsScDetails, "HighScores")
                MsgBox("Well done" & " " & [nme] & " " & "You are in First place!")

                'second place
            ElseIf (ShuffleGame.lblTime.Text >= ShuffleGame.lblScTime1.Text) And (ShuffleGame.lblTime.Text <= ShuffleGame.lblScTime2.Text) Then

                dsScDetails.Tables("HighScores").Rows(1).Item(1) = ShuffleGame.txtName.Text
                dsScDetails.Tables("HighScores").Rows(1).Item(3) = ShuffleGame.lblTime.Text
                ' dsScDetails.Tables("HighScores").Rows(1).Item(2) = lblClick.Text

                dsScDetails.Tables("HighScores").Rows(2).Item(1) = ShuffleGame.nme2
                dsScDetails.Tables("HighScores").Rows(2).Item(3) = ShuffleGame.tme2

                dsScDetails.Tables("HighScores").Rows(3).Item(1) = ShuffleGame.nme3
                dsScDetails.Tables("HighScores").Rows(3).Item(3) = ShuffleGame.tme3

                dsScDetails.Tables("HighScores").Rows(4).Item(1) = ShuffleGame.nme4
                dsScDetails.Tables("HighScores").Rows(4).Item(3) = ShuffleGame.tme4

                daScDetails.Update(dsScDetails, "HighScores")
                MsgBox("Well done" & " " & [nme] & " " & "You are in Second place!")

                'third place
            ElseIf (ShuffleGame.lblTime.Text >= ShuffleGame.lblScTime2.Text) And (ShuffleGame.lblTime.Text <= ShuffleGame.lblScTime3.Text) Then

                dsScDetails.Tables("HighScores").Rows(2).Item(1) = ShuffleGame.txtName.Text
                dsScDetails.Tables("HighScores").Rows(2).Item(3) = ShuffleGame.lblTime.Text
                ' dsScDetails.Tables("HighScores").Rows(2).Item(2) = lblClick.Text

                dsScDetails.Tables("HighScores").Rows(3).Item(1) = ShuffleGame.nme3
                dsScDetails.Tables("HighScores").Rows(3).Item(3) = ShuffleGame.tme3

                dsScDetails.Tables("HighScores").Rows(4).Item(1) = ShuffleGame.nme3
                dsScDetails.Tables("HighScores").Rows(4).Item(3) = ShuffleGame.tme3

                daScDetails.Update(dsScDetails, "HighScores")
                MsgBox("Well done" & " " & [nme] & " " & "You are in Third place!")

                'fourth place
            ElseIf (ShuffleGame.lblTime.Text >= ShuffleGame.lblScTime3.Text) And (ShuffleGame.lblTime.Text <= ShuffleGame.lblScTime4.Text) Then

                dsScDetails.Tables("HighScores").Rows(3).Item(1) = ShuffleGame.txtName.Text
                dsScDetails.Tables("HighScores").Rows(3).Item(3) = ShuffleGame.lblTime.Text
                ' dsScDetails.Tables("HighScores").Rows(3).Item(2) = lblClick.Text

                dsScDetails.Tables("HighScores").Rows(4).Item(1) = ShuffleGame.nme4
                dsScDetails.Tables("HighScores").Rows(4).Item(3) = ShuffleGame.tme4

                daScDetails.Update(dsScDetails, "HighScores")
                MsgBox("Well done" & " " & [nme] & " " & "You are in Fourth place!")

                'fith place
            ElseIf (ShuffleGame.lblTime.Text >= ShuffleGame.lblScTime4.Text) And (ShuffleGame.lblTime.Text <= ShuffleGame.lblScTime5.Text) Then

                dsScDetails.Tables("HighScores").Rows(4).Item(1) = ShuffleGame.txtName.Text
                dsScDetails.Tables("HighScores").Rows(4).Item(3) = ShuffleGame.lblTime.Text
                ' dsScDetails.Tables("HighScores").Rows(4).Item(2) = lblClick.Text

                daScDetails.Update(dsScDetails, "HighScores")
                MsgBox("Well done" & " " & [nme] & " " & "You are in Fifth place!")

            Else
                MsgBox("Sorry you haven't made the leader board!  Try again")
            End If
            connScDetails.Close()
            ' MessageBox.Show("Data updated")
            Scores()

            If Windows.Forms.DialogResult.OK Then
                ShuffleGame.Count = 0 - 1
            End If
        End If



        'this routine will look at all the buttons on the form to see if all the letters are in the correct order
        If ShuffleGame.Button1.Text = "A" And ShuffleGame.Button2.Text = "B" And ShuffleGame.Button3.Text = "C" And ShuffleGame.Button4.Text = "D" And
        ShuffleGame.Button5.Text = "E" And ShuffleGame.Button6.Text = "F" And ShuffleGame.Button7.Text = "G" And ShuffleGame.Button8.Text = "H" And
        ShuffleGame.Button9.Text = "I" And ShuffleGame.Button10.Text = "J" And ShuffleGame.Button11.Text = "K" And ShuffleGame.Button12.Text = "L" And
        ShuffleGame.Button13.Text = "M" And ShuffleGame.Button14.Text = "N" And ShuffleGame.Button15.Text = "O" Then
            'if in correct order a message box appears stating you have won the game and in how many clicks (ShuffleGame.Count)
            ShuffleGame.nme1 = ShuffleGame.lblScNam1.Text
            ShuffleGame.nme2 = ShuffleGame.lblScNam2.Text
            ShuffleGame.nme3 = ShuffleGame.lblScNam3.Text
            ShuffleGame.nme4 = ShuffleGame.lblScNam4.Text
            ShuffleGame.nme5 = ShuffleGame.lblScNam5.Text
            ShuffleGame.tme1 = ShuffleGame.lblScTime1.Text
            ShuffleGame.tme2 = ShuffleGame.lblScTime2.Text
            ShuffleGame.tme3 = ShuffleGame.lblScTime3.Text
            ShuffleGame.tme4 = ShuffleGame.lblScTime4.Text
            ShuffleGame.tme5 = ShuffleGame.lblScTime5.Text

            Dim connScDetails As New OleDb.OleDbConnection
            Dim daScDetails As New OleDb.OleDbDataAdapter
            Dim sqlScDetails As String = "SELECT * FROM HighScores"
            Dim dsScDetails As New DataSet

            ShuffleGame.tmrLoop.Enabled = False
            connScDetails.ConnectionString = dbProvider
            connScDetails.Open()
            daScDetails = New OleDb.OleDbDataAdapter(sqlScDetails, connScDetails)
            daScDetails.Fill(dsScDetails, "HighScores")

            Dim cb As New OleDb.OleDbCommandBuilder(daScDetails)
            Dim inc As Integer = 0
            Dim nme As String

            nme = ShuffleGame.txtName.Text
            ' MsgBox(lblTime.Text)

            'first place
            If (ShuffleGame.lblTime.Text <= ShuffleGame.lblScTime1.Text) Then
                dsScDetails.Tables("HighScores").Rows(0).Item(1) = ShuffleGame.txtName.Text
                dsScDetails.Tables("HighScores").Rows(0).Item(3) = ShuffleGame.lblTime.Text
                ' dsScDetails.Tables("HighScores").Rows(0).Item(2) = lblClick.Text

                dsScDetails.Tables("HighScores").Rows(1).Item(1) = ShuffleGame.nme1
                dsScDetails.Tables("HighScores").Rows(1).Item(3) = ShuffleGame.tme1

                dsScDetails.Tables("HighScores").Rows(2).Item(1) = ShuffleGame.nme2
                dsScDetails.Tables("HighScores").Rows(2).Item(3) = ShuffleGame.tme2

                dsScDetails.Tables("HighScores").Rows(3).Item(1) = ShuffleGame.nme3
                dsScDetails.Tables("HighScores").Rows(3).Item(3) = ShuffleGame.tme3

                dsScDetails.Tables("HighScores").Rows(4).Item(1) = ShuffleGame.nme4
                dsScDetails.Tables("HighScores").Rows(4).Item(3) = ShuffleGame.tme4

                daScDetails.Update(dsScDetails, "HighScores")
                MsgBox("Well done" & " " & [nme] & " " & "You are in First place!")

                'second place
            ElseIf (ShuffleGame.lblTime.Text >= ShuffleGame.lblScTime1.Text) And (ShuffleGame.lblTime.Text <= ShuffleGame.lblScTime2.Text) Then

                dsScDetails.Tables("HighScores").Rows(1).Item(1) = ShuffleGame.txtName.Text
                dsScDetails.Tables("HighScores").Rows(1).Item(3) = ShuffleGame.lblTime.Text
                ' dsScDetails.Tables("HighScores").Rows(1).Item(2) = lblClick.Text

                dsScDetails.Tables("HighScores").Rows(2).Item(1) = ShuffleGame.nme2
                dsScDetails.Tables("HighScores").Rows(2).Item(3) = ShuffleGame.tme2

                dsScDetails.Tables("HighScores").Rows(3).Item(1) = ShuffleGame.nme3
                dsScDetails.Tables("HighScores").Rows(3).Item(3) = ShuffleGame.tme3

                dsScDetails.Tables("HighScores").Rows(4).Item(1) = ShuffleGame.nme4
                dsScDetails.Tables("HighScores").Rows(4).Item(3) = ShuffleGame.tme4

                daScDetails.Update(dsScDetails, "HighScores")
                MsgBox("Well done" & " " & [nme] & " " & "You are in Second place!")

                'third place
            ElseIf (ShuffleGame.lblTime.Text >= ShuffleGame.lblScTime2.Text) And (ShuffleGame.lblTime.Text <= ShuffleGame.lblScTime3.Text) Then

                dsScDetails.Tables("HighScores").Rows(2).Item(1) = ShuffleGame.txtName.Text
                dsScDetails.Tables("HighScores").Rows(2).Item(3) = ShuffleGame.lblTime.Text
                ' dsScDetails.Tables("HighScores").Rows(2).Item(2) = lblClick.Text

                dsScDetails.Tables("HighScores").Rows(3).Item(1) = ShuffleGame.nme3
                dsScDetails.Tables("HighScores").Rows(3).Item(3) = ShuffleGame.tme3

                dsScDetails.Tables("HighScores").Rows(4).Item(1) = ShuffleGame.nme3
                dsScDetails.Tables("HighScores").Rows(4).Item(3) = ShuffleGame.tme3

                daScDetails.Update(dsScDetails, "HighScores")
                MsgBox("Well done" & " " & [nme] & " " & "You are in Third place!")

                'fourth place
            ElseIf (ShuffleGame.lblTime.Text >= ShuffleGame.lblScTime3.Text) And (ShuffleGame.lblTime.Text <= ShuffleGame.lblScTime4.Text) Then

                dsScDetails.Tables("HighScores").Rows(3).Item(1) = ShuffleGame.txtName.Text
                dsScDetails.Tables("HighScores").Rows(3).Item(3) = ShuffleGame.lblTime.Text
                ' dsScDetails.Tables("HighScores").Rows(3).Item(2) = lblClick.Text

                dsScDetails.Tables("HighScores").Rows(4).Item(1) = ShuffleGame.nme4
                dsScDetails.Tables("HighScores").Rows(4).Item(3) = ShuffleGame.tme4

                daScDetails.Update(dsScDetails, "HighScores")
                MsgBox("Well done" & " " & [nme] & " " & "You are in Fourth place!")

                'fith place
            ElseIf (ShuffleGame.lblTime.Text >= ShuffleGame.lblScTime4.Text) And (ShuffleGame.lblTime.Text <= ShuffleGame.lblScTime5.Text) Then

                dsScDetails.Tables("HighScores").Rows(4).Item(1) = ShuffleGame.txtName.Text
                dsScDetails.Tables("HighScores").Rows(4).Item(3) = ShuffleGame.lblTime.Text
                ' dsScDetails.Tables("HighScores").Rows(4).Item(2) = lblClick.Text

                daScDetails.Update(dsScDetails, "HighScores")
                MsgBox("Well done" & " " & [nme] & " " & "You are in Fifth place!")

            Else
                MsgBox("Sorry you haven't made the leader board!  Try again")
            End If
            connScDetails.Close()
            ' MessageBox.Show("Data updated")
            Scores()

            If Windows.Forms.DialogResult.OK Then
                ShuffleGame.Count = 0 - 1
            End If
        End If


        'this routine will look at all the buttons on the form to see if all the letters are in the correct order
        
        If ShuffleGame.Button1.Image Is ShuffleGame.img1 And ShuffleGame.Button2.Image Is ShuffleGame.img2 And ShuffleGame.Button3.Image Is ShuffleGame.img3 And
            ShuffleGame.Button4.Image Is ShuffleGame.img4 And ShuffleGame.Button5.Image Is ShuffleGame.img5 And ShuffleGame.Button6.Image Is ShuffleGame.img6 And
            ShuffleGame.Button7.Image Is ShuffleGame.img7 And ShuffleGame.Button8.Image Is ShuffleGame.img8 And ShuffleGame.Button9.Image Is ShuffleGame.img9 And
            ShuffleGame.Button10.Image Is ShuffleGame.img10 And ShuffleGame.Button11.Image Is ShuffleGame.img11 And ShuffleGame.Button12.Image Is ShuffleGame.img12 And
            ShuffleGame.Button13.Image Is ShuffleGame.img13 And ShuffleGame.Button14.Image Is ShuffleGame.img14 And ShuffleGame.Button15.Image Is ShuffleGame.img15 Then

            'if in correct order a message box appears stating you have won the game and in how many clicks (ShuffleGame.Count)
            ShuffleGame.nme1 = ShuffleGame.lblScNam1.Text
            ShuffleGame.nme2 = ShuffleGame.lblScNam2.Text
            ShuffleGame.nme3 = ShuffleGame.lblScNam3.Text
            ShuffleGame.nme4 = ShuffleGame.lblScNam4.Text
            ShuffleGame.nme5 = ShuffleGame.lblScNam5.Text
            ShuffleGame.tme1 = ShuffleGame.lblScTime1.Text
            ShuffleGame.tme2 = ShuffleGame.lblScTime2.Text
            ShuffleGame.tme3 = ShuffleGame.lblScTime3.Text
            ShuffleGame.tme4 = ShuffleGame.lblScTime4.Text
            ShuffleGame.tme5 = ShuffleGame.lblScTime5.Text

            Dim connScDetails As New OleDb.OleDbConnection
            Dim daScDetails As New OleDb.OleDbDataAdapter
            Dim sqlScDetails As String = "SELECT * FROM HighScores"
            Dim dsScDetails As New DataSet

            ShuffleGame.tmrLoop.Enabled = False
            connScDetails.ConnectionString = dbProvider
            connScDetails.Open()
            daScDetails = New OleDb.OleDbDataAdapter(sqlScDetails, connScDetails)
            daScDetails.Fill(dsScDetails, "HighScores")

            Dim cb As New OleDb.OleDbCommandBuilder(daScDetails)
            Dim inc As Integer = 0
            Dim nme As String

            nme = ShuffleGame.txtName.Text
            ' MsgBox(lblTime.Text)

            'first place
            If (ShuffleGame.lblTime.Text <= ShuffleGame.lblScTime1.Text) Then
                dsScDetails.Tables("HighScores").Rows(0).Item(1) = ShuffleGame.txtName.Text
                dsScDetails.Tables("HighScores").Rows(0).Item(3) = ShuffleGame.lblTime.Text
                ' dsScDetails.Tables("HighScores").Rows(0).Item(2) = lblClick.Text

                dsScDetails.Tables("HighScores").Rows(1).Item(1) = ShuffleGame.nme1
                dsScDetails.Tables("HighScores").Rows(1).Item(3) = ShuffleGame.tme1

                dsScDetails.Tables("HighScores").Rows(2).Item(1) = ShuffleGame.nme2
                dsScDetails.Tables("HighScores").Rows(2).Item(3) = ShuffleGame.tme2

                dsScDetails.Tables("HighScores").Rows(3).Item(1) = ShuffleGame.nme3
                dsScDetails.Tables("HighScores").Rows(3).Item(3) = ShuffleGame.tme3

                dsScDetails.Tables("HighScores").Rows(4).Item(1) = ShuffleGame.nme4
                dsScDetails.Tables("HighScores").Rows(4).Item(3) = ShuffleGame.tme4

                daScDetails.Update(dsScDetails, "HighScores")
                MsgBox("Well done" & " " & [nme] & " " & "You are in First place!")

                'second place
            ElseIf (ShuffleGame.lblTime.Text >= ShuffleGame.lblScTime1.Text) And (ShuffleGame.lblTime.Text <= ShuffleGame.lblScTime2.Text) Then

                dsScDetails.Tables("HighScores").Rows(1).Item(1) = ShuffleGame.txtName.Text
                dsScDetails.Tables("HighScores").Rows(1).Item(3) = ShuffleGame.lblTime.Text
                ' dsScDetails.Tables("HighScores").Rows(1).Item(2) = lblClick.Text

                dsScDetails.Tables("HighScores").Rows(2).Item(1) = ShuffleGame.nme2
                dsScDetails.Tables("HighScores").Rows(2).Item(3) = ShuffleGame.tme2

                dsScDetails.Tables("HighScores").Rows(3).Item(1) = ShuffleGame.nme3
                dsScDetails.Tables("HighScores").Rows(3).Item(3) = ShuffleGame.tme3

                dsScDetails.Tables("HighScores").Rows(4).Item(1) = ShuffleGame.nme4
                dsScDetails.Tables("HighScores").Rows(4).Item(3) = ShuffleGame.tme4

                daScDetails.Update(dsScDetails, "HighScores")
                MsgBox("Well done" & " " & [nme] & " " & "You are in Second place!")

                'third place
            ElseIf (ShuffleGame.lblTime.Text >= ShuffleGame.lblScTime2.Text) And (ShuffleGame.lblTime.Text <= ShuffleGame.lblScTime3.Text) Then

                dsScDetails.Tables("HighScores").Rows(2).Item(1) = ShuffleGame.txtName.Text
                dsScDetails.Tables("HighScores").Rows(2).Item(3) = ShuffleGame.lblTime.Text
                ' dsScDetails.Tables("HighScores").Rows(2).Item(2) = lblClick.Text

                dsScDetails.Tables("HighScores").Rows(3).Item(1) = ShuffleGame.nme3
                dsScDetails.Tables("HighScores").Rows(3).Item(3) = ShuffleGame.tme3

                dsScDetails.Tables("HighScores").Rows(4).Item(1) = ShuffleGame.nme3
                dsScDetails.Tables("HighScores").Rows(4).Item(3) = ShuffleGame.tme3

                daScDetails.Update(dsScDetails, "HighScores")
                MsgBox("Well done" & " " & [nme] & " " & "You are in Third place!")

                'fourth place
            ElseIf (ShuffleGame.lblTime.Text >= ShuffleGame.lblScTime3.Text) And (ShuffleGame.lblTime.Text <= ShuffleGame.lblScTime4.Text) Then

                dsScDetails.Tables("HighScores").Rows(3).Item(1) = ShuffleGame.txtName.Text
                dsScDetails.Tables("HighScores").Rows(3).Item(3) = ShuffleGame.lblTime.Text
                ' dsScDetails.Tables("HighScores").Rows(3).Item(2) = lblClick.Text

                dsScDetails.Tables("HighScores").Rows(4).Item(1) = ShuffleGame.nme4
                dsScDetails.Tables("HighScores").Rows(4).Item(3) = ShuffleGame.tme4

                daScDetails.Update(dsScDetails, "HighScores")
                MsgBox("Well done" & " " & [nme] & " " & "You are in Fourth place!")

                'fith place
            ElseIf (ShuffleGame.lblTime.Text >= ShuffleGame.lblScTime4.Text) And (ShuffleGame.lblTime.Text <= ShuffleGame.lblScTime5.Text) Then

                dsScDetails.Tables("HighScores").Rows(4).Item(1) = ShuffleGame.txtName.Text
                dsScDetails.Tables("HighScores").Rows(4).Item(3) = ShuffleGame.lblTime.Text
                ' dsScDetails.Tables("HighScores").Rows(4).Item(2) = lblClick.Text

                daScDetails.Update(dsScDetails, "HighScores")
                MsgBox("Well done" & " " & [nme] & " " & "You are in Fifth place!")

            Else
                MsgBox("Sorry you haven't made the leader board!  Try again")
            End If
            connScDetails.Close()
            'MessageBox.Show("Data updated")
            Scores()

            If Windows.Forms.DialogResult.OK Then
                ShuffleGame.Count = 0 - 1
            End If
        End If






        'check to see if ShuffleGame is active
        If ShuffleGame.Visible = True Then
            'if active then start counting mouse clicks
            ShuffleGame.Count = ShuffleGame.Count + 1
            'populate click label with number of clicks completed
            ShuffleGame.lblClicks.Text = ShuffleGame.Count & " click(s)"
        End If

    End Sub

    'this sub resets the number game
    Sub ResetN()
        'this routine will define numbers for the buttons and randomly assign them two variables declared
        Dim a(15), i, j, RN As Integer 'an array of 15 numbers and 3 other variables (i, j and RN) all being integers
        Dim flag As Boolean 'true or false

        flag = False
        i = 1 'set the variable to 1
        a(j) = 1 'set the variable j in array (a) to 1

        Do While i <= 15 'creates a do loop for i and continue while i is less than 15
            Randomize()

            RN = CInt(Int((15 * Rnd()) + 1)) 'RN is a variable which is made equal to an integer up to 15 then randomized

            For j = 1 To i 'this sets the variable j from 1 to 15 (i)
                If (a(j) = RN) Then 'if variables a and j equal RN then set boolean variable
                    flag = True
                    Exit For 'end loop
                End If

            Next 'next statement
            If flag = True Then
                flag = False
            Else
                a(i) = RN
                i = i + 1
            End If
        Loop 'loop the for statement until 15th number in array has been reached

        'code sets all buttons to a number which is held in (a) array. 1 - 15
        ShuffleGame.Button1.Text = a(1)
        ShuffleGame.Button2.Text = a(2)
        ShuffleGame.Button3.Text = a(3)
        ShuffleGame.Button4.Text = a(4)
        ShuffleGame.Button5.Text = a(5)
        ShuffleGame.Button6.Text = a(6)
        ShuffleGame.Button7.Text = a(7)
        ShuffleGame.Button8.Text = a(8)
        ShuffleGame.Button9.Text = a(9)
        ShuffleGame.Button10.Text = a(10)
        ShuffleGame.Button11.Text = a(11)
        ShuffleGame.Button12.Text = a(12)
        ShuffleGame.Button13.Text = a(13)
        ShuffleGame.Button14.Text = a(14)
        ShuffleGame.Button15.Text = a(15)
        ShuffleGame.Button16.Text = "" 'button16 will be set to clear
    End Sub

    Sub ResetL()
        'resets the letters game
        Dim a(15), i, j, RN As Integer
        Dim flag As Boolean
        Dim myText(15) As String

        flag = False
        i = 1
        a(j) = 1

        Do While i <= 15
            Randomize()
            RN = CInt(Int((15 * Rnd()) + 1))

            For j = 1 To i
                If (a(j) = RN) Then
                    flag = True
                    Exit For
                End If
            Next

            If flag = True Then
                flag = False
            Else
                a(i) = RN
                i = i + 1
            End If
        Loop

        myText(1) = "A"
        myText(2) = "B"
        myText(3) = "C"
        myText(4) = "D"
        myText(5) = "E"
        myText(6) = "F"
        myText(7) = "G"
        myText(8) = "H"
        myText(9) = "I"
        myText(10) = "J"
        myText(11) = "K"
        myText(12) = "L"
        myText(13) = "M"
        myText(14) = "N"
        myText(15) = "O"

        ShuffleGame.Button1.Text = myText(a(1))
        ShuffleGame.Button2.Text = myText(a(2))
        ShuffleGame.Button3.Text = myText(a(3))
        ShuffleGame.Button4.Text = myText(a(4))
        ShuffleGame.Button5.Text = myText(a(5))
        ShuffleGame.Button6.Text = myText(a(6))
        ShuffleGame.Button7.Text = myText(a(7))
        ShuffleGame.Button8.Text = myText(a(8))
        ShuffleGame.Button9.Text = myText(a(9))
        ShuffleGame.Button10.Text = myText(a(10))
        ShuffleGame.Button11.Text = myText(a(11))
        ShuffleGame.Button12.Text = myText(a(12))
        ShuffleGame.Button13.Text = myText(a(13))
        ShuffleGame.Button14.Text = myText(a(14))
        ShuffleGame.Button15.Text = myText(a(15))
        ShuffleGame.Button16.Text = ""

    End Sub

    Sub ResetP()
        'resets the picture game
        Dim a(15), i, j, RN As Integer
        Dim flag As Boolean
        Dim myImage(15) As Image

        flag = False
        i = 1
        a(j) = 1

        Do While i <= 15
            Randomize()
            RN = CInt(Int((15 * Rnd()) + 1))

            For j = 1 To i
                If (a(j) = RN) Then
                    flag = True
                    Exit For
                End If
            Next

            If flag = True Then
                flag = False
            Else
                a(i) = RN
                i = i + 1
            End If
        Loop

        myImage(1) = ShuffleGame.img1
        myImage(2) = ShuffleGame.img2
        myImage(3) = ShuffleGame.img3
        myImage(4) = ShuffleGame.img4
        myImage(5) = ShuffleGame.img5
        myImage(6) = ShuffleGame.img6
        myImage(7) = ShuffleGame.img7
        myImage(8) = ShuffleGame.img8
        myImage(9) = ShuffleGame.img9
        myImage(10) = ShuffleGame.img10
        myImage(11) = ShuffleGame.img11
        myImage(12) = ShuffleGame.img12
        myImage(13) = ShuffleGame.img13
        myImage(14) = ShuffleGame.img14
        myImage(15) = ShuffleGame.img15

        ShuffleGame.Button1.Image = myImage(a(1))
        ShuffleGame.Button2.Image = myImage(a(2))
        ShuffleGame.Button3.Image = myImage(a(3))
        ShuffleGame.Button4.Image = myImage(a(4))
        ShuffleGame.Button5.Image = myImage(a(5))
        ShuffleGame.Button6.Image = myImage(a(6))
        ShuffleGame.Button7.Image = myImage(a(7))
        ShuffleGame.Button8.Image = myImage(a(8))
        ShuffleGame.Button9.Image = myImage(a(9))
        ShuffleGame.Button10.Image = myImage(a(10))
        ShuffleGame.Button11.Image = myImage(a(11))
        ShuffleGame.Button12.Image = myImage(a(12))
        ShuffleGame.Button13.Image = myImage(a(13))
        ShuffleGame.Button14.Image = myImage(a(14))
        ShuffleGame.Button15.Image = myImage(a(15))
        ShuffleGame.Button16.Image = Nothing
    End Sub

    Sub Scores()

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

        ShuffleGame.lblScNam1.Text = dsScDetails.Tables("HighScores").Rows(0).Item(1)
        ShuffleGame.lblScTime1.Text = dsScDetails.Tables("HighScores").Rows(0).Item(3)
        ' lblScClicks.Text = dsScDetails.Tables("HighScores").Rows(0).Item(2)
        ShuffleGame.lblScNam2.Text = dsScDetails.Tables("HighScores").Rows(1).Item(1)
        ShuffleGame.lblScTime2.Text = dsScDetails.Tables("HighScores").Rows(1).Item(3)
        ShuffleGame.lblScNam3.Text = dsScDetails.Tables("HighScores").Rows(2).Item(1)
        ShuffleGame.lblScTime3.Text = dsScDetails.Tables("HighScores").Rows(2).Item(3)
        ShuffleGame.lblScNam4.Text = dsScDetails.Tables("HighScores").Rows(3).Item(1)
        ShuffleGame.lblScTime4.Text = dsScDetails.Tables("HighScores").Rows(3).Item(3)
        ShuffleGame.lblScNam5.Text = dsScDetails.Tables("HighScores").Rows(4).Item(1)
        ShuffleGame.lblScTime5.Text = dsScDetails.Tables("HighScores").Rows(4).Item(3)

        connScDetails.Close()


    End Sub



End Module
