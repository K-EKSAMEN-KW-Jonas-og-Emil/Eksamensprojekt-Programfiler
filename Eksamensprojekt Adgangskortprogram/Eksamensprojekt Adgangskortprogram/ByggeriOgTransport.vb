Public Class ByggeriOgTransport
    Private Sub But_Tilbage_ByggeriOgTransport_Click(sender As Object, e As EventArgs) Handles But_Tilbage_ByggeriOgTransport.Click
        Me.Hide()
        AdgangskortSide.Show()
        ClearLists()
    End Sub
    Public Sub ClearLists()
        LBox_Byggeri.Items.Clear()
        LBox_Transport.Items.Clear()
    End Sub
    Private Sub ByggeriOgTransport_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub
End Class