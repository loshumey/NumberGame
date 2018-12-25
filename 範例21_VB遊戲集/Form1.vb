Public Class Form1


    Private Sub 結束ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 結束ToolStripMenuItem.Click
        End

    End Sub

   
    Private Sub 終極密碼_Click(sender As System.Object, e As System.EventArgs) Handles 終極密碼.Click
        Label1.Visible = True
        mylist.Visible = True
        LabelOut.Visible = True
        Pic.Visible = True

        mylist.Items.Clear()
        LabelOut.Text = Nothing
        Pic.Image = Nothing

        '---電腦的標準答案--------
        Randomize()
        Dim ans As Integer
        Dim user_ans As Integer = 0
        Dim tot As Integer = 0
        ans = Int(Rnd() * 101)
        'mylist.Items.Add(ans)

        '----開始猜答案-------
        Do
            user_ans = Val(InputBox("請輸入你的答案"))
            tot = tot + 1
            If user_ans > ans Then
                mylist.Items.Add(user_ans & "-->太大了")
            ElseIf user_ans < ans Then
                mylist.Items.Add(user_ans & "-->太小了")
            Else
                mylist.Items.Add(user_ans & "-->標準答案")
            End If
        Loop Until user_ans = ans

        Select Case tot
            Case 1 To 3
                LabelOut.Text = "總共猜了" & tot & "次，太厲害了"
                Pic.Image = ImageList1.Images(0)
            Case 4 To 7
                LabelOut.Text = "總共猜了" & tot & "次，還可以喔"
                Pic.Image = ImageList1.Images(1)
            Case Else
                LabelOut.Text = "總共猜了" & tot & "次，該補腦囉"
                Pic.Image = ImageList1.Images(2)
        End Select

        Dim bmp As Bitmap
        bmp = Pic.Image
        bmp.MakeTransparent(Color.White)   'Color白色的部份透明 

        'bmp.Save("Result.bmp")
        'Pic.ImageLocation = "Result.bmp"

    End Sub


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label1.Visible = False
        mylist.Visible = False
        LabelOut.Visible = False
        Pic.Visible = False
    End Sub

    Private Sub 幾A幾BToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 幾A幾BToolStripMenuItem.Click
        Label1.Visible = True
        mylist.Visible = True
        LabelOut.Visible = True
        Pic.Visible = True

        mylist.Items.Clear()
        LabelOut.Text = Nothing
        Pic.Image = Nothing

        '---電腦的標準答案--------
        Randomize()
        Dim ans As String
        Dim user_ans As String = ""
        Dim A, B As Integer
        Dim tot As Integer = 0
        ans = c_ans()
        mylist.Items.Add(ans)


        '----開始猜答案-------
        Do
            user_ans = InputBox("請輸入你的答案")
            tot = tot + 1
            A = cmp_ansA(user_ans, ans)
            B = cmp_ansB(user_ans, ans)

            mylist.Items.Add(user_ans & "-->" & A & "A" & B & "B")
        Loop Until user_ans = ans

        Select Case tot
            Case 1 To 7
                LabelOut.Text = "總共猜了" & tot & "次，太厲害了"
                Pic.Image = ImageList1.Images(0)
            Case 8 To 15
                LabelOut.Text = "總共猜了" & tot & "次，還可以喔"
                Pic.Image = ImageList1.Images(1)
            Case Else
                LabelOut.Text = "總共猜了" & tot & "次，該補腦囉"
                Pic.Image = ImageList1.Images(2)
        End Select

        Dim bmp As Bitmap
        bmp = Pic.Image
        bmp.MakeTransparent(Color.White)   'Color白色的部份透明 
    End Sub

    '====產生標準答案=====
    Function c_ans() As String
        Randomize()
        Dim x As Integer
        Dim ans As String = ""
        For i = 1 To 4
            x = Int(Rnd() * 10)
            If InStr(ans, Trim(Str(x))) = 0 Then
                ans = ans & x
            Else
                i = i - 1
            End If
        Next
        Return ans
    End Function

    '====比對答案？A=====
    Function cmp_ansA(x, y) As String
        Dim a As Integer = 0
        For i = 0 To 3
            If x(i) = y(i) Then
                a = a + 1
            End If
        Next
        Return (a)
    End Function

    '====比對答案？B=====
    Function cmp_ansB(x, y) As String
        Dim b As Integer = 0
        For i = 0 To 3
            If x(i) <> y(i) And InStr(y, x(i)) > 0 Then
                b = b + 1
            End If
        Next
        Return (b)
    End Function

End Class
