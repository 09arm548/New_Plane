Public Class frmMain
    Dim strSeat(9, 3) As String
    Dim intFull As Integer
    Dim strStandby(5) As String

    Private Sub btnMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMap.Click

        Dim n As Integer
        Dim c As Integer

        'build array
        For i As Integer = 0 To 9
            strSeat(n, 0) = c
            n = n + 1
            c = c + 1
        Next
        n = 0
        For i As Integer = 0 To 9
            strSeat(n, 1) = c
            n = n + 1
            c = c + 1
        Next
        n = 0
        For i As Integer = 0 To 9
            strSeat(n, 2) = c
            n = n + 1
            c = c + 1
        Next
        n = 0
        For i As Integer = 0 To 9
            strSeat(n, 3) = c
            n = n + 1
            c = c + 1
        Next

        'shows map
        lstMap.Items.Clear()

        'Select Case txtSeatNum.Text
        '    Case 0 To 9
        '        assignSeat()
        'End Select
        'Select Case txtSeatNum.Text
        '    Case 10 To 19
        '        assignSeat1()
        'End Select
        'Select Case txtSeatNum.Text
        '    Case 20 To 29
        '        assignSeat2()
        'End Select
        'Select Case txtSeatNum.Text
        '    Case 30 To 39
        '        assignSeat3()
        'End Select
        For i As Integer = 0 To 9
            lstMap.Items.Add(strSeat(i, 0) & "          " & strSeat(i, 1) & "                 " & strSeat(i, 2) & "           " & strSeat(i, 3))
        Next

    End Sub

    Sub assignSeat()
        If txtSeatNum.Text = 0 Then
            strSeat(0, 0) = txtName.Text
            'intFull = intFull + 1
        ElseIf txtSeatNum.Text = 1 Then
            strSeat(1, 0) = txtName.Text
            'intFull = intFull + 1
        ElseIf txtSeatNum.Text = 2 Then
            strSeat(2, 0) = txtName.Text
            'intFull = intFull + 1
        ElseIf txtSeatNum.Text = 3 Then
            strSeat(3, 0) = txtName.Text
            'intFull = intFull + 1
        ElseIf txtSeatNum.Text = 4 Then
            strSeat(4, 0) = txtName.Text
            'intFull = intFull + 1
        ElseIf txtSeatNum.Text = 5 Then
            strSeat(5, 0) = txtName.Text
            'intFull = intFull + 1
        ElseIf txtSeatNum.Text = 6 Then
            strSeat(6, 0) = txtName.Text
            'intFull = intFull + 1
        ElseIf txtSeatNum.Text = 7 Then
            strSeat(7, 0) = txtName.Text
            'intFull = intFull + 1
        ElseIf txtSeatNum.Text = 8 Then
            strSeat(8, 0) = txtName.Text
            'intFull = intFull + 1
        ElseIf txtSeatNum.Text = 9 Then
            strSeat(9, 0) = txtName.Text
            'intFull = intFull + 1
        End If
    End Sub

    Sub assignSeat1()
        If txtSeatNum.Text = 10 Then
            strSeat(0, 1) = txtName.Text
            intFull = intFull + 1
        ElseIf txtSeatNum.Text = 11 Then
            strSeat(1, 1) = txtName.Text
            intFull = intFull + 1
        ElseIf txtSeatNum.Text = 12 Then
            strSeat(2, 1) = txtName.Text
            intFull = intFull + 1
        ElseIf txtSeatNum.Text = 13 Then
            strSeat(3, 1) = txtName.Text
            intFull = intFull + 1
        ElseIf txtSeatNum.Text = 14 Then
            strSeat(4, 1) = txtName.Text
            intFull = intFull + 1
        ElseIf txtSeatNum.Text = 15 Then
            strSeat(5, 1) = txtName.Text
            intFull = intFull + 1
        ElseIf txtSeatNum.Text = 16 Then
            strSeat(6, 1) = txtName.Text
            intFull = intFull + 1
        ElseIf txtSeatNum.Text = 17 Then
            strSeat(7, 1) = txtName.Text
            intFull = intFull + 1
        ElseIf txtSeatNum.Text = 18 Then
            strSeat(8, 1) = txtName.Text
            intFull = intFull + 1
        ElseIf txtSeatNum.Text = 19 Then
            strSeat(9, 1) = txtName.Text
            intFull = intFull + 1
        End If
    End Sub

    Sub assignSeat2()
        If txtSeatNum.Text = 20 Then
            strSeat(0, 2) = txtName.Text
            intFull = intFull + 1
        ElseIf txtSeatNum.Text = 21 Then
            strSeat(1, 2) = txtName.Text
            intFull = intFull + 1
        ElseIf txtSeatNum.Text = 22 Then
            strSeat(2, 2) = txtName.Text
            intFull = intFull + 1
        ElseIf txtSeatNum.Text = 23 Then
            strSeat(3, 2) = txtName.Text
            intFull = intFull + 1
        ElseIf txtSeatNum.Text = 24 Then
            strSeat(4, 2) = txtName.Text
            intFull = intFull + 1
        ElseIf txtSeatNum.Text = 25 Then
            strSeat(5, 2) = txtName.Text
            intFull = intFull + 1
        ElseIf txtSeatNum.Text = 26 Then
            strSeat(6, 2) = txtName.Text
            intFull = intFull + 1
        ElseIf txtSeatNum.Text = 27 Then
            strSeat(7, 2) = txtName.Text
            intFull = intFull + 1
        ElseIf txtSeatNum.Text = 28 Then
            strSeat(8, 2) = txtName.Text
            intFull = intFull + 1
        ElseIf txtSeatNum.Text = 29 Then
            strSeat(9, 2) = txtName.Text
            intFull = intFull + 1
        End If
    End Sub

    Sub assignSeat3()

        If txtSeatNum.Text = 30 Then
            strSeat(0, 3) = txtName.Text
            intFull = intFull + 1
        ElseIf txtSeatNum.Text = 31 Then
            strSeat(1, 3) = txtName.Text
            intFull = intFull + 1
        ElseIf txtSeatNum.Text = 32 Then
            strSeat(2, 3) = txtName.Text
            intFull = intFull + 1
        ElseIf txtSeatNum.Text = 33 Then
            strSeat(3, 3) = txtName.Text
            intFull = intFull + 1
        ElseIf txtSeatNum.Text = 34 Then
            strSeat(4, 3) = txtName.Text
            intFull = intFull + 1
        ElseIf txtSeatNum.Text = 35 Then
            strSeat(5, 3) = txtName.Text
            intFull = intFull + 1
        ElseIf txtSeatNum.Text = 36 Then
            strSeat(6, 3) = txtName.Text
            intFull = intFull + 1
        ElseIf txtSeatNum.Text = 37 Then
            strSeat(7, 3) = txtName.Text
            intFull = intFull + 1
        ElseIf txtSeatNum.Text = 38 Then
            strSeat(8, 3) = txtName.Text
            intFull = intFull + 1
        ElseIf txtSeatNum.Text = 39 Then
            strSeat(9, 3) = txtName.Text
            intFull = intFull + 1
        End If
    End Sub

    Sub bookSeat()

        lstMap.Items.Clear()
        Select Case txtSeatNum.Text
            Case 0 To 9
                assignSeat()
        End Select
        Select Case txtSeatNum.Text
            Case 10 To 19
                assignSeat1()
        End Select
        Select Case txtSeatNum.Text
            Case 20 To 29
                assignSeat2()
        End Select
        Select Case txtSeatNum.Text
            Case 30 To 39
                assignSeat3()
        End Select
        For i As Integer = 0 To 9
            lstMap.Items.Add(strSeat(i, 0) & "          " & strSeat(i, 1) & "                 " & strSeat(i, 2) & "           " & strSeat(i, 3))
        Next
    End Sub

    Sub Standby()
        If intFull = 3 Then
            strStandby(0) = txtName.Text
            lstStandby.Items.Add(strStandby(0))
            intFull = intFull + 1
        ElseIf intFull = 4 Then
            strStandby(1) = txtName.Text
            lstStandby.Items.Add(strStandby(1))
            intFull += 1
        ElseIf intFull = 5 Then
            strStandby(2) = txtName.Text
            lstStandby.Items.Add(strStandby(2))
            intFull += 1
        ElseIf intFull = 6 Then
            strStandby(3) = txtName.Text
            lstStandby.Items.Add(strStandby(3))
            intFull += 1
        End If

    End Sub

    Private Sub btnBookSeat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBookSeat.Click
        'intFull = intFull + 1
        If intFull >= 3 Then 'this means full
            Standby()
            'intFull = 3
        Else
            bookSeat()
        End If
        TextBox1.Text = intFull
    End Sub

    Sub cancelSeat()
        MessageBox.Show("lkkj")
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        TextBox1.Text = intFull

        If intFull >= 4 Then
            txtName.Text = strStandby(0)
            lstStandby.Items.Remove(strStandby(0))
            bookSeat()
            strStandby(0) = strStandby(1)
        Else
            txtName.Text = txtSeatNum.Text
            bookSeat()
            'If intFull = 5 Then
            '    txtName.Text = strStandby(1)
            '    lstStandby.Items.Remove(strStandby(1))
            '    bookSeat()
            '    If intFull = 6 Then
            '        txtName.Text = strStandby(2)
            '        lstStandby.Items.Remove(strStandby(2))
            '        bookSeat()
            '        If intFull = 7 Then
            '            txtName.Text = strStandby(3)
            '            lstStandby.Items.Remove(strStandby(3))
            '            bookSeat()
        End If
        '    End If
        'End If
        'End If
    End Sub
End Class
