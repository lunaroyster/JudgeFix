
Class MainWindow


#Region "Controls"

    Private Sub b_minimize_Click(sender As Object, e As RoutedEventArgs) Handles b_minimize.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub b_minimize_Copy_Click(sender As Object, e As RoutedEventArgs) Handles b_minimize_Copy.Click
        switchWindowState()
    End Sub

    Private Sub b_close_Click(sender As Object, e As RoutedEventArgs) Handles b_close.Click
        Me.Close()
    End Sub

    Private Sub switchWindowState()
        If Me.WindowState = WindowState.Normal Then
            Me.WindowState = WindowState.Maximized
        Else
            Me.WindowState = WindowState.Normal
        End If
    End Sub

#End Region

#Region "Information Flow"

#End Region

#Region "SQL"

#End Region

End Class
