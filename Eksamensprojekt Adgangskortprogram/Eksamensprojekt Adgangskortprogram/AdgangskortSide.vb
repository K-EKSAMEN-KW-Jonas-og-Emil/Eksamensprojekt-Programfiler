Public Class AdgangskortSide
    Dim BioC As Boolean = False
    Dim BioB As Boolean = False
    Dim DaA As Boolean = False
    Dim EnC As Boolean = False
    Dim EnB As Boolean = False
    Dim EnA As Boolean = False
    Dim FyC As Boolean = False
    Dim FyB As Boolean = False
    Dim FyA As Boolean = False
    Dim IhB As Boolean = False
    Dim InfC As Boolean = False
    Dim InfB As Boolean = False
    Dim KeC As Boolean = False
    Dim KeB As Boolean = False
    Dim KeA As Boolean = False
    Dim KitC As Boolean = False
    Dim KitA As Boolean = False
    Dim MaC As Boolean = False
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
            BioC = True
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
            EnC = True
            EnB = True
            EnA = False
        ElseIf DD_Engelsk.Text = "Engelsk A" Then
            EnA = True
            EnB = True
            EnC = True
        ElseIf DD_Engelsk.Text = " " Then
            EnA = False
            EnB = False
            EnC = False
        End If
    End Sub

    Private Sub DD_Fysik_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DD_Fysik.SelectedIndexChanged
        If DD_Fysik.Text = "Fysik B" Then
            FyC = True
            FyB = True
            FyA = False
        ElseIf DD_Fysik.Text = "Fysik A" Then
            FyA = True
            FyB = True
            FyC = True
        ElseIf DD_Engelsk.Text = " " Then
            FyA = False
            FyB = False
            FyC = False
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
            InfC = True
        ElseIf DD_Informatik.Text = " " Then
            InfC = False
            InfB = False
        End If
    End Sub

    Private Sub DD_Kemi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DD_Kemi.SelectedIndexChanged
        If DD_Kemi.Text = "Kemi B" Then
            KeC = True
            KeB = True
            KeA = False
        ElseIf DD_Kemi.Text = "Kemi A" Then
            KeA = True
            KeB = True
            KeC = True
        ElseIf DD_Kemi.Text = " " Then
            KeC = False
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
            KitC = True
        ElseIf DD_Kommunikation_IT.Text = " " Then
            KitC = False
            KitA = False
        End If
    End Sub

    Private Sub DD_Matematik_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DD_Matematik.SelectedIndexChanged
        If DD_Matematik.Text = "Matematik B" Then
            MaC = True
            MaB = True
            MaA = False
        ElseIf DD_Matematik.Text = "Matematik A" Then
            MaA = True
            MaB = True
            MaC = True
        ElseIf DD_Matematik.Text = " " Then
            MaB = False
            MaA = False
            MaC = False
        End If
    End Sub

    Private Sub DD_Samfundsfag_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DD_Samfundsfag.SelectedIndexChanged
        If DD_Samfundsfag.Text = "Samfundsfag C" Then
            SamfC = True
            SamfB = False
        ElseIf DD_Samfundsfag.Text = "Samfundsfag B" Then
            SamfB = True
            SamfC = True
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
        Arkitektur()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UddannelsesUpdate()
    End Sub

    Private Sub Arkitektur()
        ByggeriOgTransport.LBox_Byggeri.Items.Add("Arkitekt")
        ByggeriOgTransport.LBox_Byggeri.Items.Add("Byggekoordinator")
        If DaA = True And MaA = True And EnB = True Then
            ByggeriOgTransport.LBox_Byggeri.Items.Add("Diplomingeniør - Bygning")
            ByggeriOgTransport.LBox_Byggeri.Items.Add("Diplomingeniør - Bygningsdesign")
            ByggeriOgTransport.LBox_Byggeri.Items.Add("Energi")
            ByggeriOgTransport.LBox_Byggeri.Items.Add("Landinspektørvidenskab")
            If FyB = True And KeC = True Then
                ByggeriOgTransport.LBox_Byggeri.Items.Add("Arkitektur og Design")
                ByggeriOgTransport.LBox_Byggeri.Items.Add("By-, Energi- og Miljøplanlægning")
                ByggeriOgTransport.LBox_Byggeri.Items.Add("Byggeri")
                ByggeriOgTransport.LBox_Byggeri.Items.Add("Byggeri og anlæg")
                ByggeriOgTransport.LBox_Byggeri.Items.Add("Byggeteknologi")
                ByggeriOgTransport.LBox_Byggeri.Items.Add("Bygningsdesign")
                ByggeriOgTransport.LBox_Byggeri.Items.Add("Landskabsarkitektur")
            End If
        End If

        If MaC = True Then
            ByggeriOgTransport.LBox_Byggeri.Items.Add("Bygningskonstruktør")
        End If

        If MaC = True And EnC = True Then
            ByggeriOgTransport.LBox_Byggeri.Items.Add("Designteknologi")
        End If

        If MaC = True And FyC = True Then
            ByggeriOgTransport.LBox_Byggeri.Items.Add("EnergiTeknolog")
        End If

    End Sub
End Class