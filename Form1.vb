Imports Microsoft.Web.WebView2.Core

Public Class Form1

    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebView21.Top = 1
        WebView21.Left = 1

        Await WebView21.EnsureCoreWebView2Async() ' Ensure that the WebView2 control is properly initialized
        ToolStripStatusLabel1.Text = "initialized"

        WebView21.Source = New Uri("https://www.facebook.com/messages")

        ' Attach relevant events
        AddHandler WebView21.CoreWebView2.NavigationStarting, AddressOf WebViewNavigationStarting
        AddHandler WebView21.CoreWebView2.NavigationCompleted, AddressOf WebViewNavigationCompleted
    End Sub

    Private Sub WebViewNavigationStarting(sender As Object, e As CoreWebView2NavigationStartingEventArgs)
        'Update ToolStripStatusLabel for navigation starting
        ToolStripStatusLabel1.Text = "Loading..."
    End Sub

    Private Sub WebViewNavigationCompleted(sender As Object, e As CoreWebView2NavigationCompletedEventArgs)
        If e.IsSuccess Then
            ' Update ToolStripStatusLabel for navigation completed to show the current URL
            ToolStripStatusLabel1.Text = WebView21.Source.AbsoluteUri
        Else
            '      ' Update ToolStripStatusLabel for navigation error
            ToolStripStatusLabel1.Text = $"Navigation Failed. Error Code: {e.WebErrorStatus}"
            MsgBox($"Navigation Failed. Error Code: {e.WebErrorStatus}")
            ' Alternatively: ToolStripStatusLabel1.Text = e.WebErrorStatus.ToString()
        End If
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        WebView21.Height = Me.Height - 64 '41
        WebView21.Width = Me.Width - 18
    End Sub

End Class
