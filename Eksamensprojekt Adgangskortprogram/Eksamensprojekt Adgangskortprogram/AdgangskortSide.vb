Public Class AdgangskortSide
    Dim BioC As Boolean = False
    Dim BioB As Boolean = False
    Dim DaA As Boolean = False
    Dim EnB As Boolean = False
    Dim EnA As Boolean = False
    Dim FyB As Boolean = False
    Dim FyA As Boolean = False
    Dim IhB As Boolean = False
    Dim InfC As Boolean = False
    Dim InfB As Boolean = False
    Dim KeB As Boolean = False
    Dim KeA As Boolean = False
    Dim KitC As Boolean = False
    Dim KitA As Boolean = False
    Dim MaB As Boolean = False
    Dim MaA As Boolean = False
    Dim SamfC As Boolean = False
    Dim SamfB As Boolean = False


    Private Sub DD_Biologi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DD_Biologi.SelectedIndexChanged
        If DD_Biologi.Text = "Biologi C" Then
            BioC = True
            BioB = False
        ElseIf DD_Biologi.Text = "Biologi B" Then
            BioB = True
            BioC = False
        ElseIf DD_Biologi.Text = " " Then
            BioC = False
            BioB = False
        End If

    End Sub

    Private Sub DD_Dansk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DD_Dansk.SelectedIndexChanged
        If DD_Dansk.Text = "Dansk A" Then
            DaA = True
        Else
            DaA = False
        End If
    End Sub

    Private Sub DD_Engelsk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DD_Engelsk.SelectedIndexChanged
        If DD_Engelsk.Text = "Engelsk B" Then
            EnB = True
            EnA = False
        ElseIf DD_Engelsk.Text = "Engelsk A" Then
            EnA = True
            EnB = False
        ElseIf DD_Engelsk.Text = " " Then
            EnA = False
            EnB = False
        End If
    End Sub

    Private Sub DD_Fysik_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DD_Fysik.SelectedIndexChanged
        If DD_Fysik.Text = "Fysik B" Then
            FyB = True
            FyA = False
        ElseIf DD_Fysik.Text = "Fysik A" Then
            FyA = True
            FyB = False
        ElseIf DD_Engelsk.Text = " " Then
            FyA = False
            FyB = False
        End If
    End Sub

    Private Sub DD_Idehistorie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DD_Idehistorie.SelectedIndexChanged
        If DD_Idehistorie.Text = "Idéhistorie" Then
            IhB = True
        Else
            IhB = False
        End If
    End Sub

    Private Sub DD_Informatik_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DD_Informatik.SelectedIndexChanged
        If DD_Informatik.Text = "Informatik C" Then
            InfC = True
            InfB = False
        ElseIf DD_Informatik.Text = "Informatik B" Then
            InfB = True
            InfC = False
        ElseIf DD_Informatik.Text = " " Then
            InfC = False
            InfB = False
        End If
    End Sub

    Private Sub DD_Kemi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DD_Kemi.SelectedIndexChanged
        If DD_Kemi.Text = "Kemi B" Then
            KeB = True
            KeA = False
        ElseIf DD_Kemi.Text = "Kemi A" Then
            KeA = True
            KeB = False
        ElseIf DD_Kemi.Text = " " Then
            KeB = False
            KeA = False
        End If
    End Sub

    Private Sub DD_Kommunikation_IT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DD_Kommunikation_IT.SelectedIndexChanged
        If DD_Kommunikation_IT.Text = "Kommunikation/IT C" Then
            KitC = True
            KitA = False
        ElseIf DD_Kommunikation_IT.Text = "Kommunikation/IT A" Then
            KitA = True
            KitC = False
        ElseIf DD_Kommunikation_IT.Text = " " Then
            KitC = False
            KitA = False
        End If
    End Sub

    Private Sub DD_Matematik_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DD_Matematik.SelectedIndexChanged
        If DD_Matematik.Text = "Matematik B" Then
            MaB = True
            MaA = False
        ElseIf DD_Matematik.Text = "Matematik A" Then
            MaA = True
            MaB = False
        ElseIf DD_Matematik.Text = " " Then
            MaB = False
            MaA = False
        End If
    End Sub

    Private Sub DD_Samfundsfag_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DD_Samfundsfag.SelectedIndexChanged
        If DD_Samfundsfag.Text = "Samfundsfag C" Then
            SamfC = True
            SamfB = False
        ElseIf DD_Samfundsfag.Text = "Samfundsfag B" Then
            SamfB = True
            SamfC = False
        ElseIf DD_Samfundsfag.Text = " " Then
            SamfC = False
            SamfB = False
        End If
    End Sub

    Private Sub AK_PBox_Byggeri_Click(sender As Object, e As EventArgs) Handles AK_PBox_Byggeri.Click
        Skiftside()
    End Sub

    Private Sub AK_Lbl_Byggeri_Transport_Click(sender As Object, e As EventArgs) Handles AK_Lbl_Byggeri_Transport.Click
        Skiftside()
    End Sub

    Private Sub Skiftside()
        ByggeriOgTransport.Show()
    End Sub

    Private Sub UddannelsesUpdate()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UddannelsesUpdate()
    End Sub

    Private Sub Arkitekt()
        ByggeriOgTransport.LBox_Byggeri.Items.Add("Arkitekt")
    End Sub

    Private Sub By_Energi_Miljoeplanlaegning()

    End Sub
End Class