Imports System.IO
Imports Microsoft.Win32
Imports System.Drawing
Public Class win

    Private Sub Window_Loaded(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded

        q1.Text = My.Settings.q1
        q2.Text = My.Settings.q2
        q3.Text = My.Settings.q3
        q4.Text = My.Settings.q4
        q5.Text = My.Settings.q5
        q6.Text = My.Settings.q6
        q7.Text = My.Settings.q7
        q8.Text = My.Settings.q8
        q9.Text = My.Settings.q9
        q10.Text = My.Settings.q10

        q11.Text = My.Settings.q11
        q12.Text = My.Settings.q12
        q13.Text = My.Settings.q13
        q14.Text = My.Settings.q14
        q15.Text = My.Settings.q15
        q16.Text = My.Settings.q16
        q17.Text = My.Settings.q17
        q18.Text = My.Settings.q18
        q19.Text = My.Settings.q19
        q20.Text = My.Settings.q20

        q21.Text = My.Settings.q21
        q22.Text = My.Settings.q22
        q23.Text = My.Settings.q23
        q24.Text = My.Settings.q24
        q25.Text = My.Settings.q25
        q26.Text = My.Settings.q26
        q27.Text = My.Settings.q27
        q28.Text = My.Settings.q28
        q29.Text = My.Settings.q29
        q30.Text = My.Settings.q30

        q31.Text = My.Settings.q31
        q32.Text = My.Settings.q32
        q33.Text = My.Settings.q33
        q34.Text = My.Settings.q34
        q35.Text = My.Settings.q35
        q36.Text = My.Settings.q36
        q37.Text = My.Settings.q37
        q38.Text = My.Settings.q38
        q39.Text = My.Settings.q39
        q40.Text = My.Settings.q40
        q41.Text = My.Settings.q41
        q42.Text = My.Settings.q42
        q43.Text = My.Settings.q43
        q44.Text = My.Settings.q44
        q45.Text = My.Settings.q45

        c1.Text = My.Settings.c1
        c2.Text = My.Settings.c2
        c3.Text = My.Settings.c3
        c4.Text = My.Settings.c4
        c5.Text = My.Settings.c5
        c6.Text = My.Settings.c6
        c7.Text = My.Settings.c7
        c8.Text = My.Settings.c8
        c9.Text = My.Settings.c9
        c10.Text = My.Settings.c10

        c11.Text = My.Settings.c11
        c12.Text = My.Settings.c12
        c13.Text = My.Settings.c13
        c14.Text = My.Settings.c14
        c15.Text = My.Settings.c15
        c16.Text = My.Settings.c16
        c17.Text = My.Settings.c17
        c18.Text = My.Settings.c18
        c19.Text = My.Settings.c19
        c20.Text = My.Settings.c20

        c21.Text = My.Settings.c21
        c22.Text = My.Settings.c22
        c23.Text = My.Settings.c23
        c24.Text = My.Settings.c24
        c25.Text = My.Settings.c25
        c26.Text = My.Settings.c26
        c27.Text = My.Settings.c27
        c28.Text = My.Settings.c28
        c29.Text = My.Settings.c29
        c30.Text = My.Settings.c30

        c31.Text = My.Settings.c31
        c32.Text = My.Settings.c32
        c33.Text = My.Settings.c33
        c34.Text = My.Settings.c34
        c35.Text = My.Settings.c35
        c36.Text = My.Settings.c36
        c37.Text = My.Settings.c37
        c38.Text = My.Settings.c38
        c39.Text = My.Settings.c39
        c40.Text = My.Settings.c40
        c41.Text = My.Settings.c41
        c42.Text = My.Settings.c42
        c43.Text = My.Settings.c43
        c44.Text = My.Settings.c44
        c45.Text = My.Settings.c45


        '_____________________________________________________________

        If q1.Text = Nothing Then
            q1.Visibility = Windows.Visibility.Hidden
            c1.Visibility = Windows.Visibility.Hidden
        End If


        If q2.Text = Nothing Then
            q2.Visibility = Windows.Visibility.Hidden
            c2.Visibility = Windows.Visibility.Hidden
        End If


        If q3.Text = Nothing Then
            q3.Visibility = Windows.Visibility.Hidden
            c3.Visibility = Windows.Visibility.Hidden
        End If


        If q4.Text = Nothing Then
            q4.Visibility = Windows.Visibility.Hidden
            c4.Visibility = Windows.Visibility.Hidden
        End If


        If q5.Text = Nothing Then
            q5.Visibility = Windows.Visibility.Hidden
            c5.Visibility = Windows.Visibility.Hidden
        End If


        If q6.Text = Nothing Then
            q6.Visibility = Windows.Visibility.Hidden
            c6.Visibility = Windows.Visibility.Hidden
        End If


        If q7.Text = Nothing Then
            q7.Visibility = Windows.Visibility.Hidden
            c7.Visibility = Windows.Visibility.Hidden
        End If

        If q8.Text = Nothing Then
            q8.Visibility = Windows.Visibility.Hidden
            c8.Visibility = Windows.Visibility.Hidden

        End If

        If q9.Text = Nothing Then
            q9.Visibility = Windows.Visibility.Hidden
            c9.Visibility = Windows.Visibility.Hidden
        End If

        If q10.Text = Nothing Then
            q10.Visibility = Windows.Visibility.Hidden
            c10.Visibility = Windows.Visibility.Hidden
        End If

        If q11.Text = Nothing Then
            q11.Visibility = Windows.Visibility.Hidden
            c11.Visibility = Windows.Visibility.Hidden
        End If

        If q12.Text = Nothing Then
            q12.Visibility = Windows.Visibility.Hidden
            c12.Visibility = Windows.Visibility.Hidden
        End If

        If q13.Text = Nothing Then
            q13.Visibility = Windows.Visibility.Hidden
            c13.Visibility = Windows.Visibility.Hidden
        End If

        If q14.Text = Nothing Then
            q14.Visibility = Windows.Visibility.Hidden
            c14.Visibility = Windows.Visibility.Hidden
        End If

        If q15.Text = Nothing Then
            q15.Visibility = Windows.Visibility.Hidden
            c15.Visibility = Windows.Visibility.Hidden
        End If

        If q16.Text = Nothing Then
            q16.Visibility = Windows.Visibility.Hidden
            c16.Visibility = Windows.Visibility.Hidden
        End If

        If q17.Text = Nothing Then
            q17.Visibility = Windows.Visibility.Hidden
            c17.Visibility = Windows.Visibility.Hidden
        End If

        If q18.Text = Nothing Then
            q18.Visibility = Windows.Visibility.Hidden
            c18.Visibility = Windows.Visibility.Hidden
        End If


        If q19.Text = Nothing Then
            q19.Visibility = Windows.Visibility.Hidden
            c19.Visibility = Windows.Visibility.Hidden
        End If


        If q20.Text = Nothing Then
            q20.Visibility = Windows.Visibility.Hidden
            c20.Visibility = Windows.Visibility.Hidden
        End If


        If q21.Text = Nothing Then
            q21.Visibility = Windows.Visibility.Hidden
            c21.Visibility = Windows.Visibility.Hidden
        End If


        If q22.Text = Nothing Then
            q22.Visibility = Windows.Visibility.Hidden
            c22.Visibility = Windows.Visibility.Hidden
        End If


        If q23.Text = Nothing Then
            q23.Visibility = Windows.Visibility.Hidden
            c23.Visibility = Windows.Visibility.Hidden
        End If


        If q24.Text = Nothing Then
            q24.Visibility = Windows.Visibility.Hidden
            c24.Visibility = Windows.Visibility.Hidden
        End If


        If q25.Text = Nothing Then
            q25.Visibility = Windows.Visibility.Hidden
            c25.Visibility = Windows.Visibility.Hidden
        End If


        If q26.Text = Nothing Then
            q26.Visibility = Windows.Visibility.Hidden
            c26.Visibility = Windows.Visibility.Hidden
        End If


        If q27.Text = Nothing Then
            q27.Visibility = Windows.Visibility.Hidden
            c27.Visibility = Windows.Visibility.Hidden
        End If


        If q28.Text = Nothing Then
            q28.Visibility = Windows.Visibility.Hidden
            c28.Visibility = Windows.Visibility.Hidden
        End If


        If q29.Text = Nothing Then
            q29.Visibility = Windows.Visibility.Hidden
            c29.Visibility = Windows.Visibility.Hidden
        End If


        If q30.Text = Nothing Then
            q30.Visibility = Windows.Visibility.Hidden
            c30.Visibility = Windows.Visibility.Hidden
        End If


        If q31.Text = Nothing Then
            q31.Visibility = Windows.Visibility.Hidden
            c31.Visibility = Windows.Visibility.Hidden
        End If


        If q32.Text = Nothing Then
            q32.Visibility = Windows.Visibility.Hidden
            c32.Visibility = Windows.Visibility.Hidden
        End If


        If q33.Text = Nothing Then
            q33.Visibility = Windows.Visibility.Hidden
            c33.Visibility = Windows.Visibility.Hidden
        End If


        If q34.Text = Nothing Then
            q34.Visibility = Windows.Visibility.Hidden
            c34.Visibility = Windows.Visibility.Hidden
        End If


        If q35.Text = Nothing Then
            q35.Visibility = Windows.Visibility.Hidden
            c35.Visibility = Windows.Visibility.Hidden
        End If

        If q36.Text = Nothing Then
            q36.Visibility = Windows.Visibility.Hidden
            c36.Visibility = Windows.Visibility.Hidden
        End If

        If q37.Text = Nothing Then
            q37.Visibility = Windows.Visibility.Hidden
            c37.Visibility = Windows.Visibility.Hidden
        End If

        If q38.Text = Nothing Then
            q38.Visibility = Windows.Visibility.Hidden
            c38.Visibility = Windows.Visibility.Hidden
        End If

        If q39.Text = Nothing Then
            q39.Visibility = Windows.Visibility.Hidden
            c39.Visibility = Windows.Visibility.Hidden
        End If

        If q40.Text = Nothing Then
            q40.Visibility = Windows.Visibility.Hidden
            c40.Visibility = Windows.Visibility.Hidden
        End If

        If q41.Text = Nothing Then
            q41.Visibility = Windows.Visibility.Hidden
            c41.Visibility = Windows.Visibility.Hidden
        End If


        If q42.Text = Nothing Then
            q42.Visibility = Windows.Visibility.Hidden
            c42.Visibility = Windows.Visibility.Hidden
        End If

        If q43.Text = Nothing Then
            q43.Visibility = Windows.Visibility.Hidden
            c43.Visibility = Windows.Visibility.Hidden
        End If

        If q44.Text = Nothing Then
            q44.Visibility = Windows.Visibility.Hidden
            c44.Visibility = Windows.Visibility.Hidden
        End If

        If q45.Text = Nothing Then
            q45.Visibility = Windows.Visibility.Hidden
            c45.Visibility = Windows.Visibility.Hidden
        End If

        '______________________________________________________

    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles save.Click
        Dim graph As Graphics = Nothing
        Dim p As New SaveFileDialog
        Dim path As String
        Dim rpath As String
        Try
            Dim bmp As New Bitmap(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
            graph = Graphics.FromImage(bmp)
            graph.CopyFromScreen(0, 0, 0, 0, bmp.Size)

            If p.ShowDialog = False Then

            Else
                path = p.FileName
                rpath = path & ".jpg"
                Dim i As Integer

                For i = 0 To 1


                    If My.Computer.FileSystem.FileExists(path) = True Then

                        My.Computer.FileSystem.DeleteFile(path)

                    Else

                        bmp.Save(rpath)
                        i = 2
                    End If


                Next i

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub reset_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles reset.Click

        Me.Opacity = 0.4
        If MessageBox.Show("This will reset the number of votes. Are you sure you want to reset the counter?", "Reset Names & Counter", MessageBoxButton.YesNo, MessageBoxImage.Question) = vbYes Then




            Dim vote As New vote
            vote.count.Text = 0
            My.Settings.count = vote.count.Text
            c1.Text = 0
            c2.Text = 0
            c3.Text = 0
            c4.Text = 0
            c5.Text = 0
            c6.Text = 0
            c7.Text = 0
            c8.Text = 0
            c9.Text = 0
            c10.Text = 0

            c11.Text = 0
            c12.Text = 0
            c13.Text = 0
            c14.Text = 0
            c15.Text = 0
            c16.Text = 0
            c17.Text = 0
            c18.Text = 0
            c19.Text = 0
            c20.Text = 0

            c21.Text = 0
            c22.Text = 0
            c23.Text = 0
            c24.Text = 0
            c25.Text = 0
            c26.Text = 0
            c27.Text = 0
            c28.Text = 0
            c29.Text = 0
            c30.Text = 0

            c31.Text = 0
            c32.Text = 0
            c33.Text = 0
            c34.Text = 0
            c35.Text = 0
            c36.Text = 0
            c37.Text = 0
            c38.Text = 0
            c39.Text = 0
            c40.Text = 0
            c41.Text = 0
            c42.Text = 0
            c43.Text = 0
            c44.Text = 0
            c45.Text = 0



            q1.Text = My.Settings.q1
            q2.Text = My.Settings.q2
            q3.Text = My.Settings.q3
            q4.Text = My.Settings.q4
            q5.Text = My.Settings.q5
            q6.Text = My.Settings.q6
            q7.Text = My.Settings.q7
            q8.Text = My.Settings.q8
            q9.Text = My.Settings.q9
            q10.Text = My.Settings.q10

            q11.Text = My.Settings.q11
            q12.Text = My.Settings.q12
            q13.Text = My.Settings.q13
            q14.Text = My.Settings.q14
            q15.Text = My.Settings.q15
            q16.Text = My.Settings.q16
            q17.Text = My.Settings.q17
            q18.Text = My.Settings.q18
            q19.Text = My.Settings.q19
            q20.Text = My.Settings.q20

            q21.Text = My.Settings.q21
            q22.Text = My.Settings.q22
            q23.Text = My.Settings.q23
            q24.Text = My.Settings.q24
            q25.Text = My.Settings.q25
            q26.Text = My.Settings.q26
            q27.Text = My.Settings.q27
            q28.Text = My.Settings.q28
            q29.Text = My.Settings.q29
            q30.Text = My.Settings.q30

            q31.Text = My.Settings.q31
            q32.Text = My.Settings.q32
            q33.Text = My.Settings.q33
            q34.Text = My.Settings.q34
            q35.Text = My.Settings.q35
            q36.Text = My.Settings.q36
            q37.Text = My.Settings.q37
            q38.Text = My.Settings.q38
            q39.Text = My.Settings.q39
            q40.Text = My.Settings.q40
            q41.Text = My.Settings.q41
            q42.Text = My.Settings.q42
            q43.Text = My.Settings.q43
            q44.Text = My.Settings.q44
            q45.Text = My.Settings.q45


            My.Settings.c1 = 0
            My.Settings.c2 = 0
            My.Settings.c3 = 0
            My.Settings.c4 = 0
            My.Settings.c5 = 0
            My.Settings.c6 = 0
            My.Settings.c7 = 0
            My.Settings.c8 = 0
            My.Settings.c9 = 0
            My.Settings.c10 = 0
            My.Settings.c11 = 0
            My.Settings.c12 = 0
            My.Settings.c13 = 0
            My.Settings.c14 = 0
            My.Settings.c15 = 0
            My.Settings.c16 = 0
            My.Settings.c17 = 0
            My.Settings.c18 = 0
            My.Settings.c19 = 0
            My.Settings.c20 = 0
            My.Settings.c21 = 0
            My.Settings.c22 = 0
            My.Settings.c23 = 0
            My.Settings.c24 = 0
            My.Settings.c25 = 0
            My.Settings.c26 = 0
            My.Settings.c27 = 0
            My.Settings.c28 = 0
            My.Settings.c29 = 0
            My.Settings.c30 = 0
            My.Settings.c31 = 0
            My.Settings.c32 = 0
            My.Settings.c33 = 0
            My.Settings.c34 = 0
            My.Settings.c35 = 0
            My.Settings.c36 = 0
            My.Settings.c37 = 0
            My.Settings.c38 = 0
            My.Settings.c39 = 0
            My.Settings.c40 = 0
            My.Settings.c41 = 0
            My.Settings.c42 = 0
            My.Settings.c43 = 0
            My.Settings.c44 = 0
            My.Settings.c45 = 0
            My.Settings.Save()
            MessageBox.Show("The Counters have been reset", "Reset successful", MessageBoxButton.OK, MessageBoxImage.Information)
        End If
        Me.Opacity = 1
    End Sub


End Class
