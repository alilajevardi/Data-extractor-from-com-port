Imports System
Imports System.Threading
Imports System.IO
Imports System.IO.Ports
Imports System.ComponentModel


Public Class Form1
    '------------------------------------------------
    Dim myPort As Array
    Delegate Sub SetTextCallback(ByVal [text] As String)

    Dim sw As StreamWriter
    Dim fs As FileStream = Nothing
    Dim sav As Integer = 0

    Private Sub Form1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If (e.Modifiers = Keys.Control) Then
            'e.KeyCode = Keys.B AndAlso
            MsgBox(e.KeyValue.ToString)
            SerialPort1.WriteLine(12)
        End If
    End Sub


    

    '------------------------------------------------
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        myPort = IO.Ports.SerialPort.GetPortNames()
        ComboBox1.Items.AddRange(myPort)

        If ComboBox1.Items.Count > 0 Then
            ComboBox1.Text = ComboBox1.Items.Item(0)
        End If

        ComboBox2.Text = ComboBox2.Items.Item(0)

        Button2.Enabled = False
        Button3.Enabled = False

        Me.KeyPreview = True


    End Sub
    '------------------------------------------------
    '------------------------------------------------
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        SerialPort1.Close()
        SerialPort1.PortName = ComboBox1.Text
        SerialPort1.BaudRate = ComboBox2.Text
        SerialPort1.Open()
        Button1.Enabled = False
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True

    End Sub
    '------------------------------------------------
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click



        Dim Buffer(1) As Byte


        'MsgBox(ComboBox3.SelectedIndex.ToString)
        If ComboBox3.SelectedIndex > -1 Then
            Select Case ComboBox3.SelectedItem.ToString
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
            ComboBox3.SelectedIndex = -1
        End If








    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        SerialPort1.Close()
        Button1.Enabled = True
        Button2.Enabled = False
        Button4.Enabled = False
        End
    End Sub

    Private Sub SerialPort1_DataReceived(sender As System.Object, e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        ReceivedText(SerialPort1.ReadExisting())
    End Sub

    Private Sub ReceivedText(ByVal [text] As String) 'input from ReadExisting
        If Me.RichTextBox2.InvokeRequired Then
            Dim x As New SetTextCallback(AddressOf ReceivedText)
            Me.Invoke(x, New Object() {(text)})
        Else
            Me.RichTextBox2.Text &= [text] 'append text
        End If
        If sav = 1 Then
            sw.WriteLine("Time" & "," & DateAndTime.TimeString.ToString & "," & [text].ToString)
        End If
    End Sub





    Private Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click

        SerialPort1.Write(Chr(27) + RichTextBox1.Text + vbCr)

    End Sub




   
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Dim Path1 As String
        Path1 = My.Computer.FileSystem.SpecialDirectories.MyDocuments.ToString

        Dim strFile As String = Path1 & "\TempData_" & ".csv"


        If (Not File.Exists(strFile)) Then
            Try
                fs = File.Create(strFile)
                sw = File.AppendText(strFile)
                sw.WriteLine("Start temp Log")

            Catch ex As Exception
                MsgBox(strFile)
                MsgBox(ex.ToString)
                End
            End Try
        Else
            sw = File.AppendText(strFile)
            sw.WriteLine("Time" & "," & "Date" & "," & "Data")

        End If
        sav = 1

    End Sub



   

    Private Sub ComboBox4_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectionChangeCommitted
        Dim description As String


        If ComboBox4.SelectedIndex > -1 Then
            Select Case ComboBox4.SelectedItem.ToString
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
                Case "LL"
                    description = "Set Low Temperature Limit (obsolete, no longer supported)"
                Case "MU"
                    description = "Set Interval Between Temperature Measurement Reports" & Environment.NewLine & "1/MU = reporting frequency. Continuous 'C' mode reporting sets the reporting interval to the minimum practical value (4Hz). If 2 channels are active MU=C would yield 250mS * 2 = 0.5 S. Intervals: 0.25 - 600 S or 1 - 10 M."
                Case "PS"
                    description = "Specify Active-Input List" & Environment.NewLine & "PS = 1,2"
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
            RichTextBox3.Text = description
            RichTextBox1.Text = ComboBox4.SelectedItem.ToString & " ?"

        End If
        ComboBox3.SelectedIndex = -1
    End Sub

    Private Sub ComboBox3_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectionChangeCommitted
        Dim description As String


        If ComboBox3.SelectedIndex > -1 Then
            Select Case ComboBox3.SelectedItem.ToString
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
            RichTextBox1.Text = ComboBox3.SelectedItem.ToString
            RichTextBox3.Text = description
        End If
        ComboBox4.SelectedIndex = -1
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Button1.Enabled = True
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class
