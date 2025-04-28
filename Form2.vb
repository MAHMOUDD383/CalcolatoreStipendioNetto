Public Class form2
    Dim aliquoteComuni As New Dictionary(Of String, Double) From {
         {"Milano", 0.008},
    {"Bergamo", 0.008},
    {"Treviglio", 0.008},
    {"Brescia", 0.008},
    {"Monza", 0.008},
    {"Como", 0.007},
    {"Varese", 0.007},
    {"Pavia", 0.007},
    {"Cremona", 0.007},
    {"Calvenzano<.", 0.007},
    {"Caravaggio", 0.008},
    {"Lecco", 0.007},
    {"Mantova", 0.007},
    {"Sondrio", 0.008},
    {"Lodi", 0.007},
    {"Vigevano", 0.008},
    {"Cinisello Balsamo", 0.008},
    {"Sesto San Giovanni", 0.008},
    {"Rho", 0.008},
    {"Busto Arsizio", 0.008},
    {"Cernusco sul Naviglio", 0.008},
    {"Desio", 0.008},
    {"Legnano", 0.008},
    {"Rozzano", 0.008},
    {"Gallarate", 0.008},
    {"Abbiategrasso", 0.008},
    {"Segrate", 0.008},
    {"Cologno Monzese", 0.008},
    {"Paderno Dugnano", 0.008},
    {"San Giuliano Milanese", 0.008},
    {"Vimercate", 0.008},
    {"Melegnano", 0.008},
    {"Cassano d'Adda", 0.008},
    {"Trezzano sul Naviglio", 0.008},
    {"Corsico", 0.008},
    {"Paullo", 0.008},
    {"Pioltello", 0.008},
    {"Rovato", 0.008},
    {"Lissone", 0.008},
    {"Carate Brianza", 0.008},
    {"Giussano", 0.008},
    {"Melzo", 0.008},
    {"Senago", 0.008},
    {"Cusano Milanino", 0.008},
    {"Cuggiono", 0.008},
    {"Parabiago", 0.008},
    {"Arese", 0.008},
    {"Magenta", 0.008},
    {"Cassina de' Pecchi", 0.008},
    {"Cesano Maderno", 0.008},
    {"Saronno", 0.008}
}
    Private Sub form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each comune As String In aliquoteComuni.Keys
            CmbCOMUNI.Items.Add(comune)
        Next
    End Sub

    ' Aliquote costanti
    Const ALIQUOTA_INPS As Double = 0.0924
    Const ALIQUOTA_IRPEF_REGIONALE As Double = 0.0158
    Private Sub BtnCALCOLA_Click(sender As Object, e As EventArgs) Handles BtnCALCOLA.Click
        Dim codiceFiscale As String = TxtCDF.Text
        Dim ral As Double

        ' Controllo se RAL è un numero
        If Not Double.TryParse(TxtRAL.Text, ral) Then
            MessageBox.Show("Inserisci una RAL valida!")
            Exit Sub
        End If

        ' Prendo il comune selezionato
        Dim comuneScelto As String = CmbCOMUNI.SelectedItem

        ' Controllo se è stato selezionato un comune
        If String.IsNullOrEmpty(comuneScelto) Then
            MessageBox.Show("Seleziona un comune!")
            Exit Sub
        End If

        ' Prendo l'aliquota del comune
        Dim aliquotaComunale As Double = aliquoteComuni(comuneScelto)

        ' Calcoli delle tasse
        Dim inpsCalcolata As Double = ral * ALIQUOTA_INPS
        Dim irpefRegionaleCalcolata As Double = ral * ALIQUOTA_IRPEF_REGIONALE
        Dim irpefComunaleCalcolata As Double = ral * aliquotaComunale

        ' Calcolo totale imposte e netti
        Dim totaleImposte As Double = inpsCalcolata + irpefRegionaleCalcolata + irpefComunaleCalcolata
        Dim nettoAnnuale As Double = ral - totaleImposte
        Dim nettoMensile As Double = nettoAnnuale / 12

        ' Visualizzo i risultati
        txtINPS.Text = inpsCalcolata.ToString("C2")
        txtIRPEFREGIONALE.Text = irpefRegionaleCalcolata.ToString("C2")
        txtIRPEFCOMUNALE.Text = irpefComunaleCalcolata.ToString("C2")
        TxtTotImposte.Text = totaleImposte.ToString("C2")
        txtNETTOANNUALE.Text = nettoAnnuale.ToString("C2")
        txtNETTOMENSILE.Text = nettoMensile.ToString("C2")
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnCALCOLONUOVO.Click
        ' Svuota i campi di input
        TxtCDF.Clear()
        TxtRAL.Clear()
        CmbCOMUNI.SelectedIndex = -1

        ' Svuota i campi di output
        txtINPS.Clear()
        txtIRPEFREGIONALE.Clear()
        txtIRPEFCOMUNALE.Clear()
        TxtTotImposte.Clear()
        txtNETTOANNUALE.Clear()
        txtNETTOMENSILE.Clear()
    End Sub

    Private Sub btnESCI_Click(sender As Object, e As EventArgs) Handles btnESCI.Click
        End
    End Sub
End Class
