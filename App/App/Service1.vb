Public Class Service1

    Protected Overrides Sub OnStart(ByVal args() As String)
        ' Add code here to start your service. This method should set things
        ' in motion so your service can do its work.
        EnableT()
    End Sub

    Protected Overrides Sub OnStop()
        ' Add code here to perform any tear-down necessary to stop your service.
        DisableT()
    End Sub

    Private Sub DisableT()
        T.Enabled = False
    End Sub

    Private Sub EnableT()
        T.Enabled = True
    End Sub

End Class
