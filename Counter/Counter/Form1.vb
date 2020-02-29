Public Class Form1

    Public counter As Integer = -1
    Private Sub offLights()
        led1.BackColor = Color.LightGray
        led2.BackColor = Color.LightGray
        led3.BackColor = Color.LightGray
        led4.BackColor = Color.LightGray
        led5.BackColor = Color.LightGray
        led6.BackColor = Color.LightGray
        led7.BackColor = Color.LightGray
        led8.BackColor = Color.LightGray
        led9.BackColor = Color.LightGray
        led10.BackColor = Color.LightGray
        led11.BackColor = Color.LightGray
        led12.BackColor = Color.LightGray
        led13.BackColor = Color.LightGray
        led14.BackColor = Color.LightGray
        led15.BackColor = Color.LightGray
        led16.BackColor = Color.LightGray
        led17.BackColor = Color.LightGray
        led18.BackColor = Color.LightGray
        led19.BackColor = Color.LightGray
        led20.BackColor = Color.LightGray
        led21.BackColor = Color.LightGray
        led22.BackColor = Color.LightGray
        led23.BackColor = Color.LightGray
        led24.BackColor = Color.LightGray
        led25.BackColor = Color.LightGray
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer.Start()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        counter += 1

        If counter > 9 Then
            counter = 0
        End If

        If counter = 0 Then
            offLights()
            led2.BackColor = Color.Red
            led3.BackColor = Color.Red
            led4.BackColor = Color.Red
            led6.BackColor = Color.Red
            led7.BackColor = Color.Red
            led9.BackColor = Color.Red
            led10.BackColor = Color.Red
            led11.BackColor = Color.Red
            led12.BackColor = Color.Red
            led14.BackColor = Color.Red
            led15.BackColor = Color.Red
            led16.BackColor = Color.Red
            led17.BackColor = Color.Red
            led19.BackColor = Color.Red
            led20.BackColor = Color.Red
            led22.BackColor = Color.Red
            led23.BackColor = Color.Red
            led24.BackColor = Color.Red

        End If

        If counter = 1 Then
            offLights()
            led3.BackColor = Color.Red
            led4.BackColor = Color.Red
            led7.BackColor = Color.Red
            led8.BackColor = Color.Red
            led9.BackColor = Color.Red
            led13.BackColor = Color.Red
            led14.BackColor = Color.Red
            led18.BackColor = Color.Red
            led19.BackColor = Color.Red
            led22.BackColor = Color.Red
            led23.BackColor = Color.Red
            led24.BackColor = Color.Red
            led25.BackColor = Color.Red

        End If

        If counter = 2 Then
            offLights()
            led2.BackColor = Color.Red
            led3.BackColor = Color.Red
            led4.BackColor = Color.Red
            led6.BackColor = Color.Red
            led9.BackColor = Color.Red
            led10.BackColor = Color.Red
            led13.BackColor = Color.Red
            led14.BackColor = Color.Red
            led17.BackColor = Color.Red
            led18.BackColor = Color.Red
            led21.BackColor = Color.Red
            led22.BackColor = Color.Red
            led23.BackColor = Color.Red
            led24.BackColor = Color.Red
            led25.BackColor = Color.Red
        End If

        If counter = 3 Then
            offLights()
            led1.BackColor = Color.Red
            led2.BackColor = Color.Red
            led3.BackColor = Color.Red
            led4.BackColor = Color.Red
            led9.BackColor = Color.Red
            led10.BackColor = Color.Red
            led12.BackColor = Color.Red
            led13.BackColor = Color.Red
            led14.BackColor = Color.Red
            led19.BackColor = Color.Red
            led20.BackColor = Color.Red
            led21.BackColor = Color.Red
            led22.BackColor = Color.Red
            led23.BackColor = Color.Red
            led24.BackColor = Color.Red
        End If

        If counter = 4 Then
            offLights()
            led1.BackColor = Color.Red
            led2.BackColor = Color.Red
            led4.BackColor = Color.Red
            led5.BackColor = Color.Red
            led6.BackColor = Color.Red
            led7.BackColor = Color.Red
            led9.BackColor = Color.Red
            led10.BackColor = Color.Red
            led12.BackColor = Color.Red
            led13.BackColor = Color.Red
            led14.BackColor = Color.Red
            led15.BackColor = Color.Red
            led19.BackColor = Color.Red
            led20.BackColor = Color.Red
            led24.BackColor = Color.Red
            led25.BackColor = Color.Red
        End If

        If counter = 5 Then
            offLights()
            led1.BackColor = Color.Red
            led2.BackColor = Color.Red
            led3.BackColor = Color.Red
            led4.BackColor = Color.Red
            led5.BackColor = Color.Red
            led6.BackColor = Color.Red
            led7.BackColor = Color.Red
            led11.BackColor = Color.Red
            led12.BackColor = Color.Red
            led13.BackColor = Color.Red
            led14.BackColor = Color.Red
            led15.BackColor = Color.Red
            led19.BackColor = Color.Red
            led20.BackColor = Color.Red
            led21.BackColor = Color.Red
            led22.BackColor = Color.Red
            led23.BackColor = Color.Red
            led24.BackColor = Color.Red
            led25.BackColor = Color.Red
        End If

        If counter = 6 Then
            offLights()
            led1.BackColor = Color.Red
            led2.BackColor = Color.Red
            led3.BackColor = Color.Red
            led4.BackColor = Color.Red
            led5.BackColor = Color.Red
            led6.BackColor = Color.Red
            led7.BackColor = Color.Red
            led11.BackColor = Color.Red
            led12.BackColor = Color.Red
            led13.BackColor = Color.Red
            led14.BackColor = Color.Red
            led15.BackColor = Color.Red
            led16.BackColor = Color.Red
            led17.BackColor = Color.Red
            led20.BackColor = Color.Red
            led21.BackColor = Color.Red
            led22.BackColor = Color.Red
            led23.BackColor = Color.Red
            led24.BackColor = Color.Red
            led25.BackColor = Color.Red
        End If

        If counter = 7 Then
            offLights()
            led1.BackColor = Color.Red
            led2.BackColor = Color.Red
            led3.BackColor = Color.Red
            led4.BackColor = Color.Red
            led5.BackColor = Color.Red
            led9.BackColor = Color.Red
            led10.BackColor = Color.Red
            led14.BackColor = Color.Red
            led15.BackColor = Color.Red
            led19.BackColor = Color.Red
            led20.BackColor = Color.Red
            led24.BackColor = Color.Red
            led25.BackColor = Color.Red
        End If

        If counter = 8 Then
            offLights()
            led2.BackColor = Color.Red
            led3.BackColor = Color.Red
            led4.BackColor = Color.Red
            led6.BackColor = Color.Red
            led7.BackColor = Color.Red
            led9.BackColor = Color.Red
            led10.BackColor = Color.Red
            led12.BackColor = Color.Red
            led13.BackColor = Color.Red
            led14.BackColor = Color.Red
            led16.BackColor = Color.Red
            led17.BackColor = Color.Red
            led19.BackColor = Color.Red
            led20.BackColor = Color.Red
            led22.BackColor = Color.Red
            led23.BackColor = Color.Red
            led24.BackColor = Color.Red
        End If

        If counter = 9 Then
            offLights()
            led2.BackColor = Color.Red
            led3.BackColor = Color.Red
            led4.BackColor = Color.Red
            led6.BackColor = Color.Red
            led7.BackColor = Color.Red
            led9.BackColor = Color.Red
            led10.BackColor = Color.Red
            led12.BackColor = Color.Red
            led13.BackColor = Color.Red
            led14.BackColor = Color.Red
            led15.BackColor = Color.Red
            led19.BackColor = Color.Red
            led20.BackColor = Color.Red
            led22.BackColor = Color.Red
            led23.BackColor = Color.Red
            led24.BackColor = Color.Red
        End If


    End Sub

    Private Sub stopbutton_Click(sender As Object, e As EventArgs) Handles stopbutton.Click
        Timer.Stop()

    End Sub

    Private Sub contbuttn_Click(sender As Object, e As EventArgs) Handles contbuttn.Click
        Timer.Start()

    End Sub
End Class
