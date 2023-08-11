Public Class Form1
    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await WebView21.EnsureCoreWebView2Async() ' Ensure that the WebView2 control is properly initialized
        WebView21.CoreWebView2.Navigate("https://www.facebook.com/messages") ' Navigate to Facebook.com/messages
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        WebView21.Height = Me.Height - 41 ' Resize WebView2 webbrowser height when you resize the window.
        WebView21.Width = Me.Width - 18 ' same for width. Also subtracting some to give a 1 pixel border.
    End Sub
End Class
