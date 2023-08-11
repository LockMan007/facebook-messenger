Public Class Form1

    ''Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ''End Sub

    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensure that the WebView2 control is properly initialized
        Await WebView21.EnsureCoreWebView2Async()
        ' Navigate to Facebook.com/messages
        WebView21.CoreWebView2.Navigate("https://www.facebook.com/messages")
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        WebView21.Height = Me.Height - 41
        WebView21.Width = Me.Width - 18
    End Sub
End Class
