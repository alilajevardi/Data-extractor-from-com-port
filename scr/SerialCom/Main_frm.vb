Imports System
Imports System.Threading
Imports System.IO
Imports System.IO.Ports
Imports System.ComponentModel


Public Class Main_frm
    '------------------------------------------------
    Dim myPort As Array
    Delegate Sub SetTextCallback(ByVal [text] As String)

    Dim sw As StreamWriter = Nothing
    'Dim fs As FileStream = Nothing
    Dim sav As Integer = 0
    Dim send_idx As Integer = -1


    Private Sub Main_frm_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If (e.Modifiers = Keys.Control) Then
            'e.KeyCode = Keys.B AndAlso
            MsgBox(e.KeyValue.ToString)
            SerialPort1.WriteLine(12)
        End If
    End Sub




    '------------------------------------------------
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        myPort = IO.Ports.SerialPort.GetPortNames()
        PortBox.Items.AddRange(myPort)

        If PortBox.Items.Count > 0 Then
            PortBox.Text = PortBox.Items.Item(0)
        End If

        BudBox.Text = BudBox.Items.Item(0)

        'SavBtn.Enabled = False
        SendBtn.Enabled = False
        HistBox.Enabled = False

        ActBox.Enabled = False
        ParamBox.Enabled = False

        Me.KeyPreview = True

        Me.RecTxt.Text = "Time | Channel#:,  T,  Unit" & vbCrLf

        Me.DescTxt.ForeColor = Color.Red
        Me.DescTxt.Text = "Select proper COM port and baud rate then click Intilisation button to start"


    End Sub
    '------------------------------------------------
    '------------------------------------------------
    Private Sub InitBtn_Click(sender As System.Object, e As System.EventArgs) Handles InitBtn.Click
        SerialPort1.Close()
        SerialPort1.PortName = PortBox.Text
        SerialPort1.BaudRate = BudBox.Text
        SerialPort1.Open()
        InitBtn.Enabled = False
        'ActBtn.Enabled = True
        'ParamBtn.Enabled = True
        closeBtn.Enabled = True
        RecTxt.Enabled = True
        ActBox.Enabled = True
        ParamBox.Enabled = True

        Me.DescTxt.ForeColor = SystemColors.WindowText
        DescTxt.Text = ""

    End Sub
    '------------------------------------------------


    Private Sub closeBtn_Click(sender As System.Object, e As System.EventArgs) Handles closeBtn.Click

        If (sw IsNot Nothing) Then
            'Dim result As DialogResult = MessageBox.Show("Data have not been saved. Do you want to proceed?", "Warning", MessageBoxButtons.YesNo)
            'If result = DialogResult.No Then
            '    Return
            'End If
            sw.Close()
        End If
        SerialPort1.Close()
        InitBtn.Enabled = True

        closeBtn.Enabled = False
        Me.Close()

    End Sub

    Private Sub SerialPort1_DataReceived(sender As System.Object, e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        'ReceivedText(SerialPort1.ReadExisting())
        ReceivedText(SerialPort1.ReadLine())
    End Sub

    Private Sub ReceivedText(ByVal [text] As String) 'input from ReadExisting
        Dim strdata As String = ""
        If Me.RecTxt.InvokeRequired Then
            Dim x As New SetTextCallback(AddressOf ReceivedText)
            Me.Invoke(x, New Object() {(text)})
        Else
            'Me.RecTxt.Text &= DateAndTime.TimeString.ToString & ":"
            strdata = [text].ToString
            'Me.RecTxt.Text &= strdata 'append text
            Me.RecTxt.AppendText(DateAndTime.TimeString.ToString & " | " & strdata)
            Me.RecTxt.SelectionStart = Me.RecTxt.Text.Length
            Me.RecTxt.ScrollToCaret()
            Me.RecTxt.Refresh()

        End If

        If sav = 1 Then
            If strdata IsNot "" Then
                strdata = strdata.Replace(" ", ",")
                strdata = strdata.Replace(",,,", ",")
                strdata = strdata.Replace(",,", ",")
                sw.Write(DateAndTime.TimeString.ToString & ",| " & strdata)
                sw.Flush()
            End If

        End If
    End Sub



    'Private Sub ActBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActBtn.Click

    '    Dim Buffer(1) As Byte

    '    If ActBox.SelectedIndex > -1 Then
    '        Select Case ActBox.SelectedItem.ToString
    '            Case "CTRL+A"
    '                Buffer(0) = &H1
    '            Case "CTRL+D"
    '                Buffer(0) = &H4
    '            Case "CTRL+E"
    '                Buffer(0) = &H5
    '            Case "CTRL+F"
    '                Buffer(0) = &H6
    '            Case "CTRL+I"
    '                Buffer(0) = &H9
    '            Case "CTRL+K"
    '                Buffer(0) = &HB
    '            Case "CTRL+Q"
    '                Buffer(0) = &H11
    '            Case "CTRL+R"
    '                Buffer(0) = &H12
    '            Case "CTRL+T"
    '                Buffer(0) = &H14
    '            Case "CTRL+S"
    '                Buffer(0) = &H13
    '            Case "CTRL+X"
    '                Buffer(0) = &H18
    '        End Select
    '        SerialPort1.Write(Chr(Buffer(0)) + vbCr)
    '        ActBox.SelectedIndex = -1
    '    End If

    '    ParamBtn.Enabled = False
    '    ActBtn.Enabled = False
    '    SendTxt.Text = ""
    '    DescTxt.Text = ""


    'End Sub

    'Private Sub ParamBtn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ParamBtn.Click

    '    SerialPort1.Write(Chr(27) + SendTxt.Text + vbCr)

    '    ParamBox.SelectedIndex = -1
    '    SendTxt.Text = ""
    '    DescTxt.Text = ""

    '    ParamBtn.Enabled = False
    '    ActBtn.Enabled = False

    'End Sub





    Private Sub SavBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SavBtn.Click



        Dim saveFileDialog1 As New SaveFileDialog()
        Dim Path1 As String
        Dim myStream As Stream

        Path1 = Directory.GetCurrentDirectory().ToString



        saveFileDialog1.Filter = "CSV Files (*.csv)|*.csv"
        saveFileDialog1.InitialDirectory = Path1
        saveFileDialog1.RestoreDirectory = True
        saveFileDialog1.FileName = System.DateTime.Now.ToString("yyyyMMdd_HHmmss") & "_T_data"

        If saveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            myStream = saveFileDialog1.OpenFile()
            myStream.Close()
            Path1 = saveFileDialog1.FileName
            sw = My.Computer.FileSystem.OpenTextFileWriter(Path1, True)
        End If
        sw.WriteLine("@@@ Start to log temperature @@@")
        sw.WriteLine("Time,| ,Channel#, T_data, Unit")
        'sw.Write(Me.RecTxt.Text)
        sw.Flush()


        'Dim strFile As String = saveFileDialog1.FileName.ToString 'Path1 & "\T_data" & ".csv"
        'sw = File.AppendText(strFile)
        'sw.WriteLine("Time" & "," & "Date" & "," & "Data" + vbCrLf)

        'If (Not File.Exists(strFile)) Then
        '    Try
        '        fs = File.Create(strFile)
        '        sw = File.AppendText(strFile)
        '        sw.WriteLine("Start to log temperature")

        '    Catch ex As Exception
        '        MsgBox(strFile)
        '        MsgBox(ex.ToString)
        '        End
        '    End Try
        'Else
        '    sw = File.AppendText(strFile)
        '    sw.WriteLine("Time" & "," & "Date" & "," & "Data")

        'End If
        sav = 1




    End Sub





    Private Sub ParamBox_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ParamBox.SelectionChangeCommitted
        Dim description As String


        If ParamBox.SelectedIndex > -1 Then
            Select Case ParamBox.SelectedItem.ToString
                Case "AE"
                    description = "Enable/Disable Analog Outputs" & Environment.NewLine & "AE = ENABLED | DISABLED"
                Case "AO"
                    description = "Set Analog-Output Temperature Offset Factor in degrees" & Environment.NewLine & "AO = -30 oC"
                Case "AS"
                    description = "Set Analog-Output Temperature Scaling Factor in degrees"
                Case "CC"
                    description = "Enable/Disable Application of Calibration Factors in degrees" & Environment.NewLine & "CC = ENABLED | DISABLED"
                Case "CT"
                    description = "Set Calibration Temperature for Auto-Calibration Function in degrees" & Environment.NewLine & "CT = 50.00"
                Case "DF"
                    description = "Set Serial Data Output Format" & Environment.NewLine & "DF = FULL | ABBR"
                Case "DS"
                    description = "Capture User Data Sequence"
                Case "HL"
                    description = "Set High Temperature Limit (obsolete, no longer supported)"
                Case "ID"
                    description = "Get the Device Info"
                Case "LL"
                    description = "Set Low Temperature Limit (obsolete, no longer supported)"
                Case "MU"
                    description = "Set Interval Between Temperature Measurement Reports" & Environment.NewLine & "1/MU = reporting frequency. Continuous 'C' mode reporting sets the reporting interval to the minimum practical value (4Hz). If 2 channels are active MU=C would yield 250mS * 2 = 0.5 S. Intervals: 0.25 - 600 S or 1 - 10 M."
                Case "PS"
                    description = "Set List of Active Channels" & Environment.NewLine & "PS = 1,2"
                Case "SL"
                    description = "Report LED Light Source Intensity Level" & Environment.NewLine & "SL = 1: 1.81 %     2: 2.66 %"
                Case "SM"
                    description = "Set Number of Samples to be Retained Per Measurement" & Environment.NewLine & "The number of samples per second per channel is 4Hz divided by the number of active channels."
                Case "SN"
                    description = "Report Device's Serial Number"
                Case "ST"
                    description = "Select Startup Mode" & Environment.NewLine & "ST = ENABLED | DISABLED --> Standard mode | Standby mode" & Environment.NewLine & "Standard mode: reporting starts automatically | Standby mode: reporting must be started manually"
                Case "SV"
                    description = "Save Current User Parameters and Calibration Factors" & Environment.NewLine & "The SV command is used to copy the currently active user parameter values and input-channel calibration factors to nonvolatile (NvRam) storage for use in subsequent sessions." & Environment.NewLine & "!!!! Important for Calibration !!!!"
                Case "TU"
                    description = "Reports the Currently Selected Look-up Table"
                Case "UN"
                    description = "Specify Output Units of Measure" & Environment.NewLine & "UN = CELSIUS | KELVIN | FAHRENHEIT"
            End Select
            DescTxt.Text = description
            SendTxt.Text = ParamBox.SelectedItem.ToString & " ?"

        End If
        ActBox.SelectedIndex = -1
        send_idx = 1   ' 1 = Parameter Command
        SendBtn.Enabled = True

    End Sub

    Private Sub ActBox_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ActBox.SelectionChangeCommitted
        Dim description As String


        If ActBox.SelectedIndex > -1 Then
            Select Case ActBox.SelectedItem.ToString
                Case "CTRL+A"
                    description = "Abort calibration sequence in progress"
                Case "CTRL+D"
                    description = "Disable remote control of temperature reporting"
                Case "CTRL+E"
                    description = "Enable remote control of temperature reporting"
                Case "CTRL+F"
                    description = "Flush the measurement buffer"
                Case "CTRL+I"
                    description = "Begin data sampling"
                Case "CTRL+K"
                    description = "Begin auto-calibration sequence"
                Case "CTRL+Q"
                    description = "Report the most recent measurement / enable serial output"
                Case "CTRL+R"
                    description = "Start standard run mode"
                Case "CTRL+T"
                    description = "Enter standby mode"
                Case "CTRL+S"
                    description = "Disable serial data output"
                Case "CTRL+X"
                    description = "Reset the instrument"
            End Select
            SendTxt.Text = ActBox.SelectedItem.ToString
            DescTxt.Text = description
        End If
        ParamBox.SelectedIndex = -1
        send_idx = 2   ' 2 = Action Command
        SendBtn.Enabled = True

    End Sub


    Private Sub PortBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PortBox.SelectedIndexChanged
        InitBtn.Enabled = True
    End Sub

    Private Sub Main_frm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If (sw IsNot Nothing) Then
            sw.Close()
        End If
    End Sub

    Private Sub SendBtn_Click(sender As Object, e As EventArgs) Handles SendBtn.Click
        If send_idx > -1 Then
            HistBox.Enabled = True
            Select Case send_idx
                Case 1  ' Send the parameter command specified in Command to send textbox
                    SerialPort1.Write(Chr(27) + SendTxt.Text + vbCr)
                    ParamBox.SelectedIndex = -1

                Case 2  ' Send the action command specified in Command to send textbox
                    Dim Buffer(1) As Byte
                    If ActBox.SelectedIndex > -1 Then
                        Select Case ActBox.SelectedItem.ToString
                            Case "CTRL+A"
                                Buffer(0) = &H1
                            Case "CTRL+D"
                                Buffer(0) = &H4
                            Case "CTRL+E"
                                Buffer(0) = &H5
                            Case "CTRL+F"
                                Buffer(0) = &H6
                            Case "CTRL+I"
                                Buffer(0) = &H9
                            Case "CTRL+K"
                                Buffer(0) = &HB
                            Case "CTRL+Q"
                                Buffer(0) = &H11
                            Case "CTRL+R"
                                Buffer(0) = &H12
                            Case "CTRL+T"
                                Buffer(0) = &H14
                            Case "CTRL+S"
                                Buffer(0) = &H13
                            Case "CTRL+X"
                                Buffer(0) = &H18
                        End Select
                        SerialPort1.Write(Chr(Buffer(0)) + vbCr)
                        ActBox.SelectedIndex = -1
                    End If

            End Select
            HistBox.Items.Add(SendTxt.Text)
            HistBox.SelectedIndex = -1
            SendTxt.Text = ""
            DescTxt.Text = ""
            SendBtn.Enabled = False
        End If
    End Sub

    Private Sub HistBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles HistBox.SelectedIndexChanged

        SendTxt.Text = HistBox.SelectedItem



        Dim FindAction As Integer = SendTxt.Text.IndexOf("CTRL+")
  
        If FindAction <> -1 Then
            ActBox.SelectedItem = SendTxt.Text
            ActBox_SelectionChangeCommitted(sender, e)
        Else
            send_idx = 1
            SendBtn.Enabled = True
        End If


    End Sub
End Class