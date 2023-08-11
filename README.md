# facebook-messenger
Facebook Messenger that is simply a web browser that opens "facebook.com/messages". This allows Drag and Drop of images, for people who the Windows Version just shows up as an icon instead.
![facebook-messenger-website-standalone-webview21-](https://github.com/LockMan007/facebook-messenger/assets/13595927/23aa34ec-49da-4cdc-9218-438f569cd368)

https://www.virustotal.com/gui/file/3a2606137e25f2be096d09c08fc214711f08603291f00f379fa682e340bf09b2/
(for reasons unknown)
2 security vendors and no sandboxes flagged this file as malicious
3a2606137e25f2be096d09c08fc214711f08603291f00f379fa682e340bf09b2
Messenger-Facebook.exe
Cynet: Malicious (score: 100)
SecureAge: Malicious

My comment, explaining what this is, what it does, and the source code:
https://www.virustotal.com/gui/file/3a2606137e25f2be096d09c08fc214711f08603291f00f379fa682e340bf09b2/community

If you believe this is malicious, copy the source code and make your own witht he code below:

Public Class Form1

    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await WebView21.EnsureCoreWebView2Async()
        WebView21.CoreWebView2.Navigate("https://www.facebook.com/messages")
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        WebView21.Height = Me.Height - 41
        WebView21.Width = Me.Width - 18
    End Sub
    
End Class
