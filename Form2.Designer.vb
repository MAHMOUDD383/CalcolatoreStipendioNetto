<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form2
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form2))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.lbLCDF = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtRAL = New System.Windows.Forms.TextBox()
        Me.lblTotImposte = New System.Windows.Forms.Label()
        Me.TxtCDF = New System.Windows.Forms.TextBox()
        Me.lblCOMUNE = New System.Windows.Forms.Label()
        Me.lblRAL = New System.Windows.Forms.Label()
        Me.CmbCOMUNI = New System.Windows.Forms.ComboBox()
        Me.BtnCALCOLA = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIRPEFCOMUNALE = New System.Windows.Forms.TextBox()
        Me.txtIRPEFREGIONALE = New System.Windows.Forms.TextBox()
        Me.txtNETTOMENSILE = New System.Windows.Forms.TextBox()
        Me.txtNETTOANNUALE = New System.Windows.Forms.TextBox()
        Me.txtINPS = New System.Windows.Forms.TextBox()
        Me.TxtTotImposte = New System.Windows.Forms.TextBox()
        Me.BtnCALCOLONUOVO = New System.Windows.Forms.Button()
        Me.btnESCI = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'lbLCDF
        '
        Me.lbLCDF.AutoSize = True
        Me.lbLCDF.BackColor = System.Drawing.Color.Blue
        Me.lbLCDF.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLCDF.ForeColor = System.Drawing.Color.White
        Me.lbLCDF.Location = New System.Drawing.Point(517, 49)
        Me.lbLCDF.Name = "lbLCDF"
        Me.lbLCDF.Size = New System.Drawing.Size(183, 19)
        Me.lbLCDF.TabIndex = 4
        Me.lbLCDF.Text = "INSERISCI CODICE FISCALE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(325, 401)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "INPS CALCOLATA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(325, 495)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 19)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "IRPEF COMUNALE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(325, 575)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 19)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "IRPEF REGIONALE"
        '
        'TxtRAL
        '
        Me.TxtRAL.Location = New System.Drawing.Point(503, 170)
        Me.TxtRAL.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtRAL.Name = "TxtRAL"
        Me.TxtRAL.Size = New System.Drawing.Size(209, 25)
        Me.TxtRAL.TabIndex = 21
        '
        'lblTotImposte
        '
        Me.lblTotImposte.AutoSize = True
        Me.lblTotImposte.Location = New System.Drawing.Point(787, 401)
        Me.lblTotImposte.Name = "lblTotImposte"
        Me.lblTotImposte.Size = New System.Drawing.Size(124, 19)
        Me.lblTotImposte.TabIndex = 20
        Me.lblTotImposte.Text = "TOTALE IMPOSTE"
        '
        'TxtCDF
        '
        Me.TxtCDF.Location = New System.Drawing.Point(503, 84)
        Me.TxtCDF.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtCDF.Name = "TxtCDF"
        Me.TxtCDF.Size = New System.Drawing.Size(209, 25)
        Me.TxtCDF.TabIndex = 0
        '
        'lblCOMUNE
        '
        Me.lblCOMUNE.AutoSize = True
        Me.lblCOMUNE.BackColor = System.Drawing.Color.Blue
        Me.lblCOMUNE.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCOMUNE.ForeColor = System.Drawing.Color.White
        Me.lblCOMUNE.Location = New System.Drawing.Point(530, 211)
        Me.lblCOMUNE.Name = "lblCOMUNE"
        Me.lblCOMUNE.Size = New System.Drawing.Size(147, 19)
        Me.lblCOMUNE.TabIndex = 5
        Me.lblCOMUNE.Text = "SELEZIONA COMUNE"
        '
        'lblRAL
        '
        Me.lblRAL.AutoSize = True
        Me.lblRAL.BackColor = System.Drawing.Color.Blue
        Me.lblRAL.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRAL.ForeColor = System.Drawing.SystemColors.Info
        Me.lblRAL.Location = New System.Drawing.Point(552, 128)
        Me.lblRAL.Name = "lblRAL"
        Me.lblRAL.Size = New System.Drawing.Size(103, 19)
        Me.lblRAL.TabIndex = 6
        Me.lblRAL.Text = "INSERISCI RAL"
        '
        'CmbCOMUNI
        '
        Me.CmbCOMUNI.BackColor = System.Drawing.Color.Silver
        Me.CmbCOMUNI.FormattingEnabled = True
        Me.CmbCOMUNI.Location = New System.Drawing.Point(503, 251)
        Me.CmbCOMUNI.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CmbCOMUNI.Name = "CmbCOMUNI"
        Me.CmbCOMUNI.Size = New System.Drawing.Size(209, 27)
        Me.CmbCOMUNI.TabIndex = 8
        '
        'BtnCALCOLA
        '
        Me.BtnCALCOLA.BackColor = System.Drawing.Color.Blue
        Me.BtnCALCOLA.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCALCOLA.ForeColor = System.Drawing.Color.White
        Me.BtnCALCOLA.Location = New System.Drawing.Point(503, 309)
        Me.BtnCALCOLA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnCALCOLA.Name = "BtnCALCOLA"
        Me.BtnCALCOLA.Size = New System.Drawing.Size(209, 71)
        Me.BtnCALCOLA.TabIndex = 9
        Me.BtnCALCOLA.Text = "CALCOLA"
        Me.BtnCALCOLA.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(790, 495)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 19)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "NETTO MENSILE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(787, 575)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 19)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "NETTO ANNUALE"
        '
        'txtIRPEFCOMUNALE
        '
        Me.txtIRPEFCOMUNALE.Location = New System.Drawing.Point(309, 534)
        Me.txtIRPEFCOMUNALE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtIRPEFCOMUNALE.Name = "txtIRPEFCOMUNALE"
        Me.txtIRPEFCOMUNALE.Size = New System.Drawing.Size(162, 25)
        Me.txtIRPEFCOMUNALE.TabIndex = 14
        '
        'txtIRPEFREGIONALE
        '
        Me.txtIRPEFREGIONALE.Location = New System.Drawing.Point(309, 608)
        Me.txtIRPEFREGIONALE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtIRPEFREGIONALE.Name = "txtIRPEFREGIONALE"
        Me.txtIRPEFREGIONALE.Size = New System.Drawing.Size(162, 25)
        Me.txtIRPEFREGIONALE.TabIndex = 15
        '
        'txtNETTOMENSILE
        '
        Me.txtNETTOMENSILE.Location = New System.Drawing.Point(765, 534)
        Me.txtNETTOMENSILE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNETTOMENSILE.Name = "txtNETTOMENSILE"
        Me.txtNETTOMENSILE.Size = New System.Drawing.Size(173, 25)
        Me.txtNETTOMENSILE.TabIndex = 16
        '
        'txtNETTOANNUALE
        '
        Me.txtNETTOANNUALE.Location = New System.Drawing.Point(765, 608)
        Me.txtNETTOANNUALE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNETTOANNUALE.Name = "txtNETTOANNUALE"
        Me.txtNETTOANNUALE.Size = New System.Drawing.Size(173, 25)
        Me.txtNETTOANNUALE.TabIndex = 17
        '
        'txtINPS
        '
        Me.txtINPS.Location = New System.Drawing.Point(309, 444)
        Me.txtINPS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtINPS.Name = "txtINPS"
        Me.txtINPS.Size = New System.Drawing.Size(162, 25)
        Me.txtINPS.TabIndex = 18
        '
        'TxtTotImposte
        '
        Me.TxtTotImposte.Location = New System.Drawing.Point(765, 444)
        Me.TxtTotImposte.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtTotImposte.Name = "TxtTotImposte"
        Me.TxtTotImposte.Size = New System.Drawing.Size(173, 25)
        Me.TxtTotImposte.TabIndex = 19
        '
        'BtnCALCOLONUOVO
        '
        Me.BtnCALCOLONUOVO.BackColor = System.Drawing.Color.Blue
        Me.BtnCALCOLONUOVO.ForeColor = System.Drawing.Color.White
        Me.BtnCALCOLONUOVO.Location = New System.Drawing.Point(503, 639)
        Me.BtnCALCOLONUOVO.Name = "BtnCALCOLONUOVO"
        Me.BtnCALCOLONUOVO.Size = New System.Drawing.Size(222, 51)
        Me.BtnCALCOLONUOVO.TabIndex = 22
        Me.BtnCALCOLONUOVO.Text = "NUOVO CALCOLO"
        Me.BtnCALCOLONUOVO.UseVisualStyleBackColor = False
        '
        'btnESCI
        '
        Me.btnESCI.Location = New System.Drawing.Point(988, 676)
        Me.btnESCI.Name = "btnESCI"
        Me.btnESCI.Size = New System.Drawing.Size(131, 43)
        Me.btnESCI.TabIndex = 23
        Me.btnESCI.Text = "ESCI"
        Me.btnESCI.UseVisualStyleBackColor = True
        '
        'form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1131, 783)
        Me.Controls.Add(Me.btnESCI)
        Me.Controls.Add(Me.BtnCALCOLONUOVO)
        Me.Controls.Add(Me.TxtRAL)
        Me.Controls.Add(Me.lblTotImposte)
        Me.Controls.Add(Me.TxtTotImposte)
        Me.Controls.Add(Me.txtINPS)
        Me.Controls.Add(Me.txtNETTOANNUALE)
        Me.Controls.Add(Me.txtNETTOMENSILE)
        Me.Controls.Add(Me.txtIRPEFREGIONALE)
        Me.Controls.Add(Me.txtIRPEFCOMUNALE)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnCALCOLA)
        Me.Controls.Add(Me.CmbCOMUNI)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblRAL)
        Me.Controls.Add(Me.lblCOMUNE)
        Me.Controls.Add(Me.lbLCDF)
        Me.Controls.Add(Me.TxtCDF)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents lbLCDF As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtRAL As TextBox
    Friend WithEvents lblTotImposte As Label
    Friend WithEvents TxtCDF As TextBox
    Friend WithEvents lblCOMUNE As Label
    Friend WithEvents lblRAL As Label
    Friend WithEvents CmbCOMUNI As ComboBox
    Friend WithEvents BtnCALCOLA As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtIRPEFCOMUNALE As TextBox
    Friend WithEvents txtIRPEFREGIONALE As TextBox
    Friend WithEvents txtNETTOMENSILE As TextBox
    Friend WithEvents txtNETTOANNUALE As TextBox
    Friend WithEvents txtINPS As TextBox
    Friend WithEvents TxtTotImposte As TextBox
    Friend WithEvents BtnCALCOLONUOVO As Button
    Friend WithEvents btnESCI As Button
End Class
