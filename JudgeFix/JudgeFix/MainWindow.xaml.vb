
Class MainWindow
    Private Sub b_minimize_Click(sender As Object, e As RoutedEventArgs) Handles b_minimize.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub b_minimize_Copy_Click(sender As Object, e As RoutedEventArgs) Handles b_minimize_Copy.Click
        If Me.WindowState = WindowState.Normal Then
            Me.WindowState = WindowState.Maximized
        Else
            Me.WindowState = WindowState.Normal
        End If
    End Sub

    Private Sub b_close_Click(sender As Object, e As RoutedEventArgs) Handles b_close.Click
        Me.Close()
    End Sub

#Region "Controls"

#End Region

#Region "Information Flow"

#End Region

#Region "SQL"

#End Region

End Class
