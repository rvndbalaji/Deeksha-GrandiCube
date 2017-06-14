Public Class cont

    Private Sub cont_Loaded(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Closed

        Dim rootWindow As MainWindow = TryCast(Application.Current.MainWindow, MainWindow)
        rootWindow.WindowState = Windows.WindowState.Normal

    End Sub
    Private Sub subm_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles save.MouseEnter
        sv.Opacity = 1
    End Sub

    Private Sub submtlick(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles save.MouseLeave
        sv.Opacity = 0.6
    End Sub

    Private Sub slicfk(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles sv.MouseEnter
        sv.Opacity = 1
    End Sub

    Private Sub subck(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles sv.MouseLeave
        sv.Opacity = 0.6
    End Sub

    Private Sub submit_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles clear.MouseEnter
        clr.Opacity = 1
    End Sub

    Private Sub submitlick(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles clear.MouseLeave
        clr.Opacity = 0.6
    End Sub

    Private Sub slick(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles clr.MouseEnter
        clr.Opacity = 1
    End Sub

    Private Sub submick(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles clr.MouseLeave
        clr.Opacity = 0.6
    End Sub

    Private Sub contoaded(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded

        Me.Opacity = 0
        Me.Activate()
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
        

        Me.Opacity = 1

    End Sub



    Private Sub clear_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles clear.Click
        Me.Opacity = 0.4
        If MessageBox.Show("Are you sure you want to clear all the names in the list?", "Clear Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question) = vbNo Then

        Else
            q1.Clear()
            q2.Clear()
            q3.Clear()
            q4.Clear()
            q5.Clear()
            q6.Clear()
            q7.Clear()
            q8.Clear()
            q9.Clear()
            q10.Clear()

            q11.Clear()
            q12.Clear()
            q13.Clear()
            q14.Clear()
            q15.Clear()
            q16.Clear()
            q17.Clear()
            q18.Clear()
            q19.Clear()
            q20.Clear()

            q21.Clear()
            q22.Clear()
            q23.Clear()
            q24.Clear()
            q25.Clear()
            q26.Clear()
            q27.Clear()
            q28.Clear()
            q29.Clear()
            q30.Clear()
            q31.Clear()
            q32.Clear()
            q33.Clear()
            q34.Clear()
            q35.Clear()
            q36.Clear()
            q37.Clear()
            q38.Clear()
            q39.Clear()
            q40.Clear()
            q41.Clear()
            q42.Clear()
            q43.Clear()
            q44.Clear()
            q45.Clear()
           

            My.Settings.q1 = q1.Text
            My.Settings.q2 = q2.Text
            My.Settings.q3 = q3.Text
            My.Settings.q4 = q4.Text
            My.Settings.q5 = q5.Text
            My.Settings.q6 = q6.Text
            My.Settings.q7 = q7.Text
            My.Settings.q8 = q8.Text
            My.Settings.q9 = q9.Text
            My.Settings.q10 = q10.Text

            My.Settings.q11 = q11.Text
            My.Settings.q12 = q12.Text
            My.Settings.q13 = q13.Text
            My.Settings.q14 = q14.Text
            My.Settings.q15 = q15.Text
            My.Settings.q16 = q16.Text
            My.Settings.q17 = q17.Text
            My.Settings.q18 = q18.Text
            My.Settings.q19 = q19.Text
            My.Settings.q20 = q20.Text

            My.Settings.q21 = q21.Text
            My.Settings.q22 = q22.Text
            My.Settings.q23 = q23.Text
            My.Settings.q24 = q24.Text
            My.Settings.q25 = q25.Text
            My.Settings.q26 = q26.Text
            My.Settings.q27 = q27.Text
            My.Settings.q28 = q28.Text
            My.Settings.q29 = q29.Text
            My.Settings.q30 = q30.Text

            My.Settings.q31 = q31.Text
            My.Settings.q32 = q32.Text
            My.Settings.q33 = q33.Text
            My.Settings.q34 = q34.Text
            My.Settings.q35 = q35.Text
            My.Settings.q36 = q36.Text
            My.Settings.q37 = q37.Text
            My.Settings.q38 = q38.Text
            My.Settings.q39 = q39.Text
            My.Settings.q40 = q40.Text
            My.Settings.q41 = q41.Text
            My.Settings.q42 = q42.Text
            My.Settings.q43 = q43.Text
            My.Settings.q44 = q44.Text
            My.Settings.q45 = q45.Text
            

           

            '______________________________________________

            My.Settings.Save()
            My.Settings.Reload()

        End If
        Me.Opacity = 1
    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles save.Click


        My.Settings.q1 = q1.Text
        My.Settings.q2 = q2.Text
        My.Settings.q3 = q3.Text
        My.Settings.q4 = q4.Text
        My.Settings.q5 = q5.Text
        My.Settings.q6 = q6.Text
        My.Settings.q7 = q7.Text
        My.Settings.q8 = q8.Text
        My.Settings.q9 = q9.Text
        My.Settings.q10 = q10.Text

        My.Settings.q11 = q11.Text
        My.Settings.q12 = q12.Text
        My.Settings.q13 = q13.Text
        My.Settings.q14 = q14.Text
        My.Settings.q15 = q15.Text
        My.Settings.q16 = q16.Text
        My.Settings.q17 = q17.Text
        My.Settings.q18 = q18.Text
        My.Settings.q19 = q19.Text
        My.Settings.q20 = q20.Text

        My.Settings.q21 = q21.Text
        My.Settings.q22 = q22.Text
        My.Settings.q23 = q23.Text
        My.Settings.q24 = q24.Text
        My.Settings.q25 = q25.Text
        My.Settings.q26 = q26.Text
        My.Settings.q27 = q27.Text
        My.Settings.q28 = q28.Text
        My.Settings.q29 = q29.Text
        My.Settings.q30 = q30.Text

        My.Settings.q31 = q31.Text
        My.Settings.q32 = q32.Text
        My.Settings.q33 = q33.Text
        My.Settings.q34 = q34.Text
        My.Settings.q35 = q35.Text
        My.Settings.q36 = q36.Text
        My.Settings.q37 = q37.Text
        My.Settings.q38 = q38.Text
        My.Settings.q39 = q39.Text
        My.Settings.q40 = q40.Text
        My.Settings.q41 = q41.Text

        My.Settings.q42 = q42.Text
        My.Settings.q43 = q43.Text
        My.Settings.q44 = q44.Text
        My.Settings.q45 = q45.Text
       

       
        '____________________________________________________________
        My.Settings.Save()
        My.Settings.Reload()

        Me.Opacity = 0.4
        MessageBox.Show("Contestants' list has been saved!", "Saved", MessageBoxButton.OK, MessageBoxImage.Information)
        Me.Opacity = 1


    End Sub

   
End Class
