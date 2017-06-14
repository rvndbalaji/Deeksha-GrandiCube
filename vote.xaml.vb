Public Class vote
    Dim w(50) As Integer
    Dim c As Integer





    Private Sub cand_Laded(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Closing
        Dim rootWindow As MainWindow = TryCast(Application.Current.MainWindow, MainWindow)
        rootWindow.WindowState = Windows.WindowState.Normal
        My.Settings.Save()
    End Sub



    Private Sub vote_Loed(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded






        vote.grp.Visibility = Windows.Visibility.Hidden
        vote.img.Visibility = Windows.Visibility.Hidden
        vote.submit.Visibility = Windows.Visibility.Hidden

        Me.Activate()



        'Assigning Variables

        w(1) = My.Settings.c1
        w(2) = My.Settings.c2
        w(3) = My.Settings.c3
        w(4) = My.Settings.c4
        w(5) = My.Settings.c5
        w(6) = My.Settings.c6
        w(7) = My.Settings.c7
        w(8) = My.Settings.c8
        w(9) = My.Settings.c9
        w(10) = My.Settings.c10

        w(11) = My.Settings.c11
        w(12) = My.Settings.c12
        w(13) = My.Settings.c13
        w(14) = My.Settings.c14
        w(15) = My.Settings.c15
        w(16) = My.Settings.c16
        w(17) = My.Settings.c17
        w(18) = My.Settings.c18
        w(19) = My.Settings.c19
        w(20) = My.Settings.c20

        w(21) = My.Settings.c1
        w(22) = My.Settings.c22
        w(23) = My.Settings.c23
        w(24) = My.Settings.c24
        w(25) = My.Settings.c25
        w(26) = My.Settings.c26
        w(27) = My.Settings.c27
        w(28) = My.Settings.c28
        w(29) = My.Settings.c29
        w(30) = My.Settings.c30

        w(31) = My.Settings.c31
        w(32) = My.Settings.c32
        w(33) = My.Settings.c33
        w(34) = My.Settings.c34
        w(35) = My.Settings.c35
        w(36) = My.Settings.c36
        w(37) = My.Settings.c37
        w(38) = My.Settings.c38
        w(39) = My.Settings.c39
        w(40) = My.Settings.c40
        w(41) = My.Settings.c41
        w(42) = My.Settings.c42
        w(43) = My.Settings.c43
        w(44) = My.Settings.c44
        w(45) = My.Settings.c45


        q1.Content = My.Settings.q1
        q2.Content = My.Settings.q2
        q3.Content = My.Settings.q3
        q4.Content = My.Settings.q4
        q5.Content = My.Settings.q5
        q6.Content = My.Settings.q6
        q7.Content = My.Settings.q7
        q8.Content = My.Settings.q8
        q9.Content = My.Settings.q9
        q10.Content = My.Settings.q10

        q11.Content = My.Settings.q11
        q12.Content = My.Settings.q12
        q13.Content = My.Settings.q13
        q14.Content = My.Settings.q14
        q15.Content = My.Settings.q15
        q16.Content = My.Settings.q16
        q17.Content = My.Settings.q17
        q18.Content = My.Settings.q18
        q19.Content = My.Settings.q19
        q20.Content = My.Settings.q20

        q21.Content = My.Settings.q21
        q22.Content = My.Settings.q22
        q23.Content = My.Settings.q23
        q24.Content = My.Settings.q24
        q25.Content = My.Settings.q25
        q26.Content = My.Settings.q26
        q27.Content = My.Settings.q27
        q28.Content = My.Settings.q28
        q29.Content = My.Settings.q29
        q30.Content = My.Settings.q30

        q31.Content = My.Settings.q31
        q32.Content = My.Settings.q32
        q33.Content = My.Settings.q33
        q34.Content = My.Settings.q34
        q35.Content = My.Settings.q35
        q36.Content = My.Settings.q36
        q37.Content = My.Settings.q37
        q38.Content = My.Settings.q38
        q39.Content = My.Settings.q39
        q40.Content = My.Settings.q40
        q41.Content = My.Settings.q41
        q42.Content = My.Settings.q42
        q43.Content = My.Settings.q43
        q44.Content = My.Settings.q44
        q45.Content = My.Settings.q45
       




        If q1.Content = Nothing Then
            q1.Visibility = Windows.Visibility.Hidden
        End If


        If q2.Content = Nothing Then
            q2.Visibility = Windows.Visibility.Hidden
        End If


        If q3.Content = Nothing Then
            q3.Visibility = Windows.Visibility.Hidden
        End If


        If q4.Content = Nothing Then
            q4.Visibility = Windows.Visibility.Hidden
        End If


        If q5.Content = Nothing Then
            q5.Visibility = Windows.Visibility.Hidden
        End If


        If q6.Content = Nothing Then
            q6.Visibility = Windows.Visibility.Hidden
        End If


        If q7.Content = Nothing Then
            q7.Visibility = Windows.Visibility.Hidden
        End If

        If q8.Content = Nothing Then
            q8.Visibility = Windows.Visibility.Hidden
        End If

        If q9.Content = Nothing Then
            q9.Visibility = Windows.Visibility.Hidden
        End If

        If q10.Content = Nothing Then
            q10.Visibility = Windows.Visibility.Hidden
        End If

        If q11.Content = Nothing Then
            q11.Visibility = Windows.Visibility.Hidden
        End If

        If q12.Content = Nothing Then
            q12.Visibility = Windows.Visibility.Hidden
        End If

        If q13.Content = Nothing Then
            q13.Visibility = Windows.Visibility.Hidden
        End If

        If q14.Content = Nothing Then
            q14.Visibility = Windows.Visibility.Hidden
        End If

        If q15.Content = Nothing Then
            q15.Visibility = Windows.Visibility.Hidden
        End If

        If q16.Content = Nothing Then
            q16.Visibility = Windows.Visibility.Hidden
        End If

        If q17.Content = Nothing Then
            q17.Visibility = Windows.Visibility.Hidden
        End If


        If q18.Content = Nothing Then
            q18.Visibility = Windows.Visibility.Hidden
        End If


        If q19.Content = Nothing Then
            q19.Visibility = Windows.Visibility.Hidden
        End If


        If q20.Content = Nothing Then
            q20.Visibility = Windows.Visibility.Hidden
        End If


        If q21.Content = Nothing Then
            q21.Visibility = Windows.Visibility.Hidden
        End If


        If q22.Content = Nothing Then
            q22.Visibility = Windows.Visibility.Hidden
        End If


        If q23.Content = Nothing Then
            q23.Visibility = Windows.Visibility.Hidden
        End If


        If q24.Content = Nothing Then
            q24.Visibility = Windows.Visibility.Hidden
        End If


        If q25.Content = Nothing Then
            q25.Visibility = Windows.Visibility.Hidden
        End If


        If q26.Content = Nothing Then
            q26.Visibility = Windows.Visibility.Hidden
        End If


        If q27.Content = Nothing Then
            q27.Visibility = Windows.Visibility.Hidden
        End If


        If q28.Content = Nothing Then
            q28.Visibility = Windows.Visibility.Hidden
        End If


        If q29.Content = Nothing Then
            q29.Visibility = Windows.Visibility.Hidden
        End If


        If q30.Content = Nothing Then
            q30.Visibility = Windows.Visibility.Hidden
        End If


        If q31.Content = Nothing Then
            q31.Visibility = Windows.Visibility.Hidden
        End If


        If q32.Content = Nothing Then
            q32.Visibility = Windows.Visibility.Hidden
        End If


        If q33.Content = Nothing Then
            q33.Visibility = Windows.Visibility.Hidden
        End If


        If q34.Content = Nothing Then
            q34.Visibility = Windows.Visibility.Hidden
        End If


        If q35.Content = Nothing Then
            q35.Visibility = Windows.Visibility.Hidden
        End If

        If q36.Content = Nothing Then
            q36.Visibility = Windows.Visibility.Hidden
        End If

        If q37.Content = Nothing Then
            q37.Visibility = Windows.Visibility.Hidden
        End If

        If q38.Content = Nothing Then
            q38.Visibility = Windows.Visibility.Hidden
        End If

        If q39.Content = Nothing Then
            q39.Visibility = Windows.Visibility.Hidden
        End If

        If q40.Content = Nothing Then
            q40.Visibility = Windows.Visibility.Hidden
        End If

        If q41.Content = Nothing Then
            q41.Visibility = Windows.Visibility.Hidden
        End If


        If q42.Content = Nothing Then
            q42.Visibility = Windows.Visibility.Hidden
        End If

        If q43.Content = Nothing Then
            q43.Visibility = Windows.Visibility.Hidden
        End If

        If q44.Content = Nothing Then
            q44.Visibility = Windows.Visibility.Hidden
        End If

        If q45.Content = Nothing Then
            q45.Visibility = Windows.Visibility.Hidden
        End If


        vote.grp.Visibility = Windows.Visibility.Visible
        vote.img.Visibility = Windows.Visibility.Visible
        vote.submit.Visibility = Windows.Visibility.Visible
        count.Text = My.Settings.count
        c = My.Settings.count
    End Sub

    Private Sub submit_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles submit.Click

        'Voting begins here.......

        If q1.IsChecked = True Then
            w(1) = w(1) + 1         'Vote increments here
            My.Settings.c1 = w(1)
            q1.IsChecked = False

            c = c + 1

        ElseIf q2.IsChecked = True Then
            w(2) = w(2) + 1
            My.Settings.c2 = w(2)
            q2.IsChecked = False
            c = c + 1
        ElseIf q3.IsChecked = True Then
            w(3) = w(3) + 1
            My.Settings.c3 = w(3)
            q3.IsChecked = False
            c = c + 1
        ElseIf q4.IsChecked = True Then
            w(4) = w(4) + 1
            My.Settings.c4 = w(4)
            q4.IsChecked = False
            c = c + 1
        ElseIf q5.IsChecked = True Then
            w(5) = w(5) + 1
            My.Settings.c5 = w(5)
            q5.IsChecked = False
            c = c + 1
        ElseIf q6.IsChecked = True Then
            w(6) = w(6) + 1
            My.Settings.c6 = w(6)
            q6.IsChecked = False
            c = c + 1
        ElseIf q7.IsChecked = True Then
            w(7) = w(7) + 1
            My.Settings.c7 = w(7)
            q7.IsChecked = False
            c = c + 1
        ElseIf q8.IsChecked = True Then
            w(8) = w(8) + 1
            My.Settings.c8 = w(8)
            q8.IsChecked = False
            c = c + 1
        ElseIf q9.IsChecked = True Then
            w(9) = w(9) + 1
            My.Settings.c9 = w(9)
            q9.IsChecked = False
            c = c + 1
        ElseIf q10.IsChecked = True Then
            w(10) = w(10) + 1
            My.Settings.c10 = w(10)
            q10.IsChecked = False
            c = c + 1
        ElseIf q11.IsChecked = True Then
            w(11) = w(11) + 1
            My.Settings.c11 = w(11)
            q11.IsChecked = False
            c = c + 1
        ElseIf q12.IsChecked = True Then
            w(12) = w(12) + 1
            My.Settings.c12 = w(12)
            q12.IsChecked = False
            c = c + 1
        ElseIf q13.IsChecked = True Then
            w(13) = w(13) + 1
            My.Settings.c13 = w(13)
            q13.IsChecked = False
            c = c + 1
        ElseIf q14.IsChecked = True Then
            w(14) = w(14) + 1
            My.Settings.c14 = w(14)
            q14.IsChecked = False
            c = c + 1
        ElseIf q15.IsChecked = True Then
            w(15) = w(15) + 1
            My.Settings.c15 = w(15)
            q15.IsChecked = False
            c = c + 1
        ElseIf q16.IsChecked = True Then
            w(16) = w(16) + 1
            My.Settings.c16 = w(16)
            q16.IsChecked = False
            c = c + 1
        ElseIf q17.IsChecked = True Then
            w(17) = w(17) + 1
            My.Settings.c17 = w(17)
            q17.IsChecked = False
            c = c + 1
        ElseIf q18.IsChecked = True Then
            w(18) = w(18) + 1
            My.Settings.c18 = w(18)
            q18.IsChecked = False
            c = c + 1
        ElseIf q19.IsChecked = True Then
            w(19) = w(19) + 1
            My.Settings.c19 = w(19)
            q19.IsChecked = False
            c = c + 1
        ElseIf q20.IsChecked = True Then
            w(20) = w(20) + 1
            My.Settings.c20 = w(20)
            q20.IsChecked = False
            c = c + 1
        ElseIf q21.IsChecked = True Then
            w(21) = w(21) + 1
            My.Settings.c21 = w(21)
            q21.IsChecked = False
            c = c + 1
        ElseIf q22.IsChecked = True Then
            w(22) = w(22) + 1
            My.Settings.c22 = w(22)
            q22.IsChecked = False
            c = c + 1
        ElseIf q23.IsChecked = True Then
            w(23) = w(23) + 1
            My.Settings.c23 = w(23)
            q23.IsChecked = False
            c = c + 1
        ElseIf q24.IsChecked = True Then
            w(24) = w(24) + 1
            My.Settings.c24 = w(24)
            q24.IsChecked = False
            c = c + 1
        ElseIf q25.IsChecked = True Then
            w(25) = w(25) + 1
            My.Settings.c25 = w(25)
            q25.IsChecked = False
            c = c + 1
        ElseIf q26.IsChecked = True Then
            w(26) = w(26) + 1
            My.Settings.c26 = w(26)
            q26.IsChecked = False
            c = c + 1
        ElseIf q27.IsChecked = True Then
            w(27) = w(27) + 1
            My.Settings.c27 = w(27)
            q27.IsChecked = False
            c = c + 1
        ElseIf q28.IsChecked = True Then
            w(28) = w(28) + 1
            My.Settings.c28 = w(28)
            q28.IsChecked = False
            c = c + 1
        ElseIf q29.IsChecked = True Then
            w(29) = w(29) + 1
            My.Settings.c29 = w(29)
            q29.IsChecked = False
            c = c + 1
        ElseIf q30.IsChecked = True Then
            w(30) = w(30) + 1
            My.Settings.c30 = w(30)
            q30.IsChecked = False
            c = c + 1
        ElseIf q31.IsChecked = True Then
            w(31) = w(31) + 1
            My.Settings.c31 = w(31)
            q31.IsChecked = False
            c = c + 1
        ElseIf q32.IsChecked = True Then
            w(32) = w(32) + 1
            My.Settings.c32 = w(32)
            q32.IsChecked = False
            c = c + 1
        ElseIf q33.IsChecked = True Then
            w(33) = w(33) + 1
            My.Settings.c33 = w(33)
            q33.IsChecked = False
            c = c + 1
        ElseIf q34.IsChecked = True Then
            w(34) = w(34) + 1
            My.Settings.c34 = w(34)
            q34.IsChecked = False
            c = c + 1
        ElseIf q35.IsChecked = True Then
            w(35) = w(35) + 1
            My.Settings.c35 = w(35)
            q35.IsChecked = False
            c = c + 1
        ElseIf q36.IsChecked = True Then
            w(36) = w(36) + 1
            My.Settings.c36 = w(36)
            q36.IsChecked = False
            c = c + 1
        ElseIf q37.IsChecked = True Then
            w(37) = w(37) + 1
            My.Settings.c37 = (37)
            q37.IsChecked = False
            c = c + 1
        ElseIf q38.IsChecked = True Then
            w(38) = w(38) + 1
            My.Settings.c38 = w(38)
            q38.IsChecked = False
            c = c + 1
        ElseIf q39.IsChecked = True Then
            w(39) = w(39) + 1
            My.Settings.c39 = w(39)
            q39.IsChecked = False
            c = c + 1
        ElseIf q40.IsChecked = True Then
            w(40) = w(40) + 1
            My.Settings.c40 = w(40)
            q40.IsChecked = False
            c = c + 1

        ElseIf q41.IsChecked = True Then
            w(41) = w(41) + 1
            My.Settings.c41 = w(41)
            q41.IsChecked = False
            c = c + 1

        ElseIf q42.IsChecked = True Then
            w(42) = w(42) + 1
            My.Settings.c42 = w(42)
            q42.IsChecked = False
            c = c + 1

        ElseIf q43.IsChecked = True Then
            w(43) = w(43) + 1
            My.Settings.c43 = w(43)
            q43.IsChecked = False
            c = c + 1

        ElseIf q44.IsChecked = True Then
            w(44) = w(44) + 1
            My.Settings.c44 = w(44)
            q44.IsChecked = False
            c = c + 1

        ElseIf q45.IsChecked = True Then
            w(45) = w(45) + 1
            My.Settings.c45 = w(45)
            q45.IsChecked = False
            c = c + 1

       

        Else
            Me.Opacity = 0.3
            MessageBox.Show("Please select an exhibit to vote!", "Invalid Selection", MessageBoxButton.OK, MessageBoxImage.Warning)
            Me.Opacity = 1

            GoTo Label
        End If


        vote.grp.Visibility = Windows.Visibility.Hidden
        vote.img.Visibility = Windows.Visibility.Hidden
        vote.submit.Visibility = Windows.Visibility.Hidden
        Me.Opacity = 0.3
        MessageBox.Show("You just voted for what you thought was the best! :D Thank You", "Vote Casted", MessageBoxButton.OK, MessageBoxImage.Information)
        Me.Opacity = 1

        count.Text = c
        My.Settings.count = c
        My.Settings.Save()
        vote.grp.Visibility = Windows.Visibility.Visible
        vote.img.Visibility = Windows.Visibility.Visible
        vote.submit.Visibility = Windows.Visibility.Visible
Label:



        count.Text = c
        My.Settings.count = c
        My.Settings.Save()
    End Sub

   
    Private Sub q1_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q1.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q1.Foreground = fg
    End Sub

    Private Sub q1_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q1.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q1.Foreground = fg
    End Sub

    Private Sub q2_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q2.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q2.Foreground = fg
    End Sub

    Private Sub q2_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q2.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q2.Foreground = fg
    End Sub

    Private Sub q3_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q3.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q3.Foreground = fg
    End Sub

    Private Sub q3_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q3.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q3.Foreground = fg
    End Sub

    Private Sub q4_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q4.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q4.Foreground = fg
    End Sub

    Private Sub q4_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q4.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q4.Foreground = fg
    End Sub

    Private Sub q5_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q5.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q5.Foreground = fg
    End Sub

    Private Sub q5_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q5.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q5.Foreground = fg
    End Sub

    Private Sub q6_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q6.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q6.Foreground = fg
    End Sub

    Private Sub q6_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q6.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q6.Foreground = fg
    End Sub

    Private Sub q7_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q7.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q7.Foreground = fg
    End Sub

    Private Sub q7_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q7.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q7.Foreground = fg
    End Sub



    Private Sub q8_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q8.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q8.Foreground = fg
    End Sub

    Private Sub q8_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q8.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q8.Foreground = fg
    End Sub

    Private Sub q9_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q9.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q9.Foreground = fg
    End Sub

    Private Sub q9_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q9.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q9.Foreground = fg
    End Sub

    Private Sub q10_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q10.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q10.Foreground = fg
    End Sub

    Private Sub q10_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q10.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q10.Foreground = fg
    End Sub

    Private Sub q11_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q11.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q11.Foreground = fg
    End Sub

    Private Sub q11_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q11.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q11.Foreground = fg
    End Sub

    Private Sub q12_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q12.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q12.Foreground = fg
    End Sub

    Private Sub q12_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q12.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q12.Foreground = fg
    End Sub

    Private Sub q13_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q13.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q13.Foreground = fg
    End Sub

    Private Sub q13_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q13.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q13.Foreground = fg
    End Sub

    Private Sub q14_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q14.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q14.Foreground = fg
    End Sub

    Private Sub q14_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q14.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q14.Foreground = fg
    End Sub

    Private Sub q15_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q15.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q15.Foreground = fg
    End Sub

    Private Sub q15_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q15.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q15.Foreground = fg
    End Sub

    Private Sub q16_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q16.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q16.Foreground = fg
    End Sub

    Private Sub q16_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q16.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q16.Foreground = fg
    End Sub

    Private Sub q17_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q17.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q17.Foreground = fg
    End Sub

    Private Sub q17_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q17.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q17.Foreground = fg
    End Sub

    Private Sub q18_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q18.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q18.Foreground = fg
    End Sub

    Private Sub q18_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q18.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q18.Foreground = fg
    End Sub

    Private Sub q19_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q19.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q19.Foreground = fg
    End Sub

    Private Sub q19_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q19.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q19.Foreground = fg
    End Sub

    Private Sub q20_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q20.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q20.Foreground = fg
    End Sub

    Private Sub q20_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q20.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q20.Foreground = fg
    End Sub





    Private Sub q21_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q21.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q21.Foreground = fg
    End Sub

    Private Sub q21_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q21.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q21.Foreground = fg
    End Sub


    Private Sub q22_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q22.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q22.Foreground = fg
    End Sub

    Private Sub q22_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q22.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q22.Foreground = fg
    End Sub


    Private Sub q23_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q23.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q23.Foreground = fg
    End Sub

    Private Sub q23_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q23.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q23.Foreground = fg
    End Sub


    Private Sub q24_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q24.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q24.Foreground = fg
    End Sub

    Private Sub q24_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q24.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q24.Foreground = fg
    End Sub


    Private Sub q25_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q25.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q25.Foreground = fg
    End Sub

    Private Sub q25_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q25.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q25.Foreground = fg
    End Sub


    Private Sub q26_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q26.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q26.Foreground = fg
    End Sub

    Private Sub q26_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q26.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q26.Foreground = fg
    End Sub


    Private Sub q27_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q27.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q27.Foreground = fg
    End Sub

    Private Sub q27_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q27.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q27.Foreground = fg
    End Sub


    Private Sub q28_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q28.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q28.Foreground = fg
    End Sub

    Private Sub q28_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q28.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q28.Foreground = fg
    End Sub


    Private Sub q29_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q29.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q29.Foreground = fg
    End Sub

    Private Sub q29_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q29.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q29.Foreground = fg
    End Sub


    Private Sub q30_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q30.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q30.Foreground = fg
    End Sub

    Private Sub q30_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q30.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q30.Foreground = fg
    End Sub


    Private Sub q31_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q31.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q31.Foreground = fg
    End Sub

    Private Sub q31_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q31.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q31.Foreground = fg
    End Sub


    Private Sub q32_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q32.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q32.Foreground = fg
    End Sub

    Private Sub q32_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q32.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q32.Foreground = fg
    End Sub


    Private Sub q33_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q33.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q33.Foreground = fg
    End Sub

    Private Sub q33_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q33.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q33.Foreground = fg
    End Sub


    Private Sub q34_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q34.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q34.Foreground = fg
    End Sub

    Private Sub q34_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q34.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q34.Foreground = fg
    End Sub


    Private Sub q35_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q35.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q35.Foreground = fg
    End Sub

    Private Sub q35_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q35.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q35.Foreground = fg
    End Sub


    Private Sub q36_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q36.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q36.Foreground = fg
    End Sub

    Private Sub q36_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q36.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q36.Foreground = fg
    End Sub


    Private Sub q37_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q37.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q37.Foreground = fg
    End Sub

    Private Sub q37_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q37.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q37.Foreground = fg
    End Sub


    Private Sub q38_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q38.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q38.Foreground = fg
    End Sub

    Private Sub q38_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q38.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q38.Foreground = fg
    End Sub


    Private Sub q39_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q39.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q39.Foreground = fg
    End Sub

    Private Sub q39_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q39.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q39.Foreground = fg
    End Sub


    Private Sub q40_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q40.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q40.Foreground = fg
    End Sub

    Private Sub q40_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q40.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q40.Foreground = fg
    End Sub


    Private Sub q41_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q41.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q41.Foreground = fg
    End Sub

    Private Sub q41_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q41.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q41.Foreground = fg
    End Sub


    Private Sub q42_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q42.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q42.Foreground = fg
    End Sub

    Private Sub q42_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q42.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q42.Foreground = fg
    End Sub


    Private Sub q43_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q43.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q43.Foreground = fg
    End Sub

    Private Sub q43_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q43.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q43.Foreground = fg
    End Sub


    Private Sub q44_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q44.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q44.Foreground = fg
    End Sub

    Private Sub q44_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q44.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q44.Foreground = fg
    End Sub


    Private Sub q45_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q45.Checked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(225, 0, 0, 225)
        q45.Foreground = fg
    End Sub

    Private Sub q45_Cd(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles q45.Unchecked
        Dim fg As New SolidColorBrush
        fg.Color = Color.FromArgb(255, 0, 0, 0)
        q45.Foreground = fg
    End Sub
End Class