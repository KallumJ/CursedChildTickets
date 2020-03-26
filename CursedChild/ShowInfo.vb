Public Class ShowInfo

    'Declare variables
    Dim images(8) As Bitmap
    Dim pos As Integer = 0

    Private Sub ShowInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Populate synopsis textbox
        txtSynopsis.Text = "Based on an original new story by J.K. Rowling, Jack Thorne and John Tiffany, Harry Potter and the Cursed Child, a new play by Jack Thorne received its world premiere in London’s West End at the Palace Theatre in summer 2016.

The critically acclaimed production is the most awarded West End play in the history of the Olivier Awards, winning a record-breaking nine awards including Best New Play and Best Director in 2017.

Jamie Ballard, Michelle Gayle and Thomas Aldridge lead the cast as Harry, Hermione and Ron, as part of a 42 strong Company.

Written by BAFTA, Tony and Olivier award-winner Jack Thorne and directed by Olivier and Tony award winner John Tiffany, Harry Potter and the Cursed Child is the eighth story in the Harry Potter series and the first official Harry Potter story to be presented on stage, bringing together some of the most exciting talent working in the theatre today.

It was always difficult being Harry Potter and it isn’t much easier now that he is an overworked employee of the Ministry of Magic, a husband and father of three school-age children.

While Harry grapples with a past that refuses to stay where it belongs, his youngest son Albus must struggle with the weight of a family legacy he never wanted. As past and present fuse ominously, both father and son learn the uncomfortable truth: sometimes, darkness comes from unexpected places.

Harry Potter and the Cursed Child is directed by John Tiffany with movement by Steven Hoggett, set by Christine Jones, costumes by Katrina Lindsay, music & arrangements by Imogen Heap, lighting by Neil Austin, sound by Gareth Fry, illusions & magic by Jamie Harrison, music supervision & arrangements by Martin Lowe and casting by Julia Horan CDG.

Harry Potter and the Cursed Child is produced by Sonia Friedman Productions, Colin Callender and Harry Potter Theatrical Productions."

        'Autoplay video on form load
        AxWindowsMediaPlayer1.uiMode = "none"
        AxWindowsMediaPlayer1.URL = "D:\Subjects\Computer Science\A2 Computer Science\Unit 5\Implementation\CursedChildTickets\CursedChild\Resources\Trailer.mp4"
        AxWindowsMediaPlayer1.settings.setMode("loop", True)
        AxWindowsMediaPlayer1.settings.mute = True

        'Create slideshow array
        images(0) = My.Resources.slideshow0
        images(1) = My.Resources.slideshow1
        images(2) = My.Resources.slideshow2
        images(3) = My.Resources.slideshow3
        images(4) = My.Resources.slideshow4
        images(5) = My.Resources.slideshow5
        images(6) = My.Resources.slideshow6
        images(7) = My.Resources.slideshow7
        picSlideshow.Image = Nothing

    End Sub

    Private Sub btnForward_Click(sender As Object, e As EventArgs) Handles btnForward.Click
        'Cycle forwards through the slideshow
        pos = pos + 1

        'If the position is greater than the length of the images array then
        If pos < images.Length - 1 Then
            picSlideshow.BackgroundImage = images(pos)
        Else
            'Stop changing the position
            pos = images.Length - 2
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Cycle backwards through the slideshow
        pos = pos - 1

        'If the position is greater than or equal to 0 then
        If pos >= 0 Then
            'Display image in that position
            picSlideshow.BackgroundImage = images(pos)
        Else
            'Stop changing the position
            pos = 0
        End If

    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        'Return to the main menu
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub ShowInfo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Close the application
        Application.Exit()
    End Sub
End Class