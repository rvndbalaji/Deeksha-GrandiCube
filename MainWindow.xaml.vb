Class MainWindow 

    Private Sub edit_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles edit.Click
        Me.Opacity = 0.4
        Dim cont As New cont
        cont.Show()
        cont.Activate()
        Me.Opacity = 1
    End Sub

    Private Sub begin_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles begin.Click
        Me.WindowState = Windows.WindowState.Minimized
        Dim vote As New vote
        vote.Show()
    End Sub

    Private Sub res_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles res.Click
       
        Me.Opacity = 0.4
        Dim cred As New cred
        cred.ShowDialog()
        cred.Activate()
        Me.Opacity = 1
     
    End Sub

    Private Sub img_ImageFailed(ByVal sender As System.Object, ByVal e As EventArgs) Handles img.MouseUp
        Me.Opacity = 0.4
        Dim win As New win
        win.Show()
        win.Activate()
        Me.Opacity = 1
    End Sub

   
    Private Sub img_ImageFailed_1(ByVal sender As System.Object, ByVal e As EventArgs) Handles img.MouseEnter
        img.Opacity = 1
    End Sub

    Private Sub img_Id_1(ByVal sender As System.Object, ByVal e As EventArgs) Handles img.MouseLeave
        img.Opacity = 0.7
    End Sub


    Private Sub main_Loaded(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = True
        Me.Opacity = 0.4
        If MessageBox.Show("Are you sure you want to quit?" & vbNewLine & "The counters will be saved and you can still resume voting... ", "Exit Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question) = MessageBoxResult.Yes Then
            My.Settings.Save()
            End

        Else : Me.Opacity = 1

        End If
    End Sub
End Class
