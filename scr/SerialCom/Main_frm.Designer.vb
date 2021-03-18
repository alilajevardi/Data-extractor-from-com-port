<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main_frm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_frm))
        Me.InitBtn = New System.Windows.Forms.Button()
        Me.PortBox = New System.Windows.Forms.ComboBox()
        Me.SendTxt = New System.Windows.Forms.RichTextBox()
        Me.RecTxt = New System.Windows.Forms.RichTextBox()
        Me.SendLbl = New System.Windows.Forms.Label()
        Me.ReceiveLbl = New System.Windows.Forms.Label()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.BudBox = New System.Windows.Forms.ComboBox()
        Me.SavBtn = New System.Windows.Forms.Button()
        Me.ActBox = New System.Windows.Forms.ComboBox()
        Me.DescTxt = New System.Windows.Forms.RichTextBox()
        Me.ParamBox = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ParamLbl = New System.Windows.Forms.Label()
        Me.ActLbl = New System.Windows.Forms.Label()
        Me.DescriptLbl = New System.Windows.Forms.Label()
        Me.ComLbL = New System.Windows.Forms.Label()
        Me.BaudLbl = New System.Windows.Forms.Label()
        Me.SendBtn = New System.Windows.Forms.Button()
        Me.HistBox = New System.Windows.Forms.ComboBox()
        Me.HistLbl = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InitBtn
        '
        Me.InitBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.InitBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InitBtn.Location = New System.Drawing.Point(139, 37)
        Me.InitBtn.Name = "InitBtn"
        Me.InitBtn.Size = New System.Drawing.Size(82, 32)
        Me.InitBtn.TabIndex = 0
        Me.InitBtn.Text = "Initialisation"
        Me.InitBtn.UseVisualStyleBackColor = True
        '
        'PortBox
        '
        Me.PortBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PortBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PortBox.FormattingEnabled = True
        Me.PortBox.Location = New System.Drawing.Point(12, 22)
        Me.PortBox.Name = "PortBox"
        Me.PortBox.Size = New System.Drawing.Size(121, 24)
        Me.PortBox.TabIndex = 3
        '
        'SendTxt
        '
        Me.SendTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SendTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SendTxt.Location = New System.Drawing.Point(12, 297)
        Me.SendTxt.Multiline = False
        Me.SendTxt.Name = "SendTxt"
        Me.SendTxt.Size = New System.Drawing.Size(178, 26)
        Me.SendTxt.TabIndex = 4
        Me.SendTxt.Text = ""
        '
        'RecTxt
        '
        Me.RecTxt.AutoWordSelection = True
        Me.RecTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RecTxt.DetectUrls = False
        Me.RecTxt.Enabled = False
        Me.RecTxt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecTxt.Location = New System.Drawing.Point(268, 27)
        Me.RecTxt.Name = "RecTxt"
        Me.RecTxt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.RecTxt.Size = New System.Drawing.Size(353, 342)
        Me.RecTxt.TabIndex = 5
        Me.RecTxt.Text = ""
        '
        'SendLbl
        '
        Me.SendLbl.AutoSize = True
        Me.SendLbl.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SendLbl.Font = New System.Drawing.Font("Calisto MT", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SendLbl.Location = New System.Drawing.Point(11, 277)
        Me.SendLbl.Name = "SendLbl"
        Me.SendLbl.Size = New System.Drawing.Size(117, 21)
        Me.SendLbl.TabIndex = 6
        Me.SendLbl.Text = "Command to send"
        Me.SendLbl.UseCompatibleTextRendering = True
        '
        'ReceiveLbl
        '
        Me.ReceiveLbl.AutoSize = True
        Me.ReceiveLbl.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ReceiveLbl.Font = New System.Drawing.Font("Calisto MT", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReceiveLbl.Location = New System.Drawing.Point(265, 6)
        Me.ReceiveLbl.Name = "ReceiveLbl"
        Me.ReceiveLbl.Size = New System.Drawing.Size(91, 18)
        Me.ReceiveLbl.TabIndex = 7
        Me.ReceiveLbl.Text = "Received data"
        '
        'closeBtn
        '
        Me.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.closeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBtn.Location = New System.Drawing.Point(12, 159)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(211, 32)
        Me.closeBtn.TabIndex = 8
        Me.closeBtn.Text = "Close"
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        '
        'BudBox
        '
        Me.BudBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BudBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BudBox.FormattingEnabled = True
        Me.BudBox.Items.AddRange(New Object() {"9600", "38400", "57600", "115200"})
        Me.BudBox.Location = New System.Drawing.Point(12, 64)
        Me.BudBox.Name = "BudBox"
        Me.BudBox.Size = New System.Drawing.Size(121, 24)
        Me.BudBox.TabIndex = 9
        '
        'SavBtn
        '
        Me.SavBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SavBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SavBtn.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.SavBtn.Location = New System.Drawing.Point(12, 111)
        Me.SavBtn.Name = "SavBtn"
        Me.SavBtn.Size = New System.Drawing.Size(211, 32)
        Me.SavBtn.TabIndex = 10
        Me.SavBtn.Text = "Start saving data"
        Me.SavBtn.UseVisualStyleBackColor = True
        '
        'ActBox
        '
        Me.ActBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ActBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActBox.FormattingEnabled = True
        Me.ActBox.Items.AddRange(New Object() {"CTRL+A", "CTRL+D", "CTRL+E", "CTRL+F", "CTRL+I", "CTRL+K", "CTRL+R", "CTRL+S", "CTRL+T", "CTRL+X"})
        Me.ActBox.Location = New System.Drawing.Point(148, 243)
        Me.ActBox.Name = "ActBox"
        Me.ActBox.Size = New System.Drawing.Size(103, 24)
        Me.ActBox.TabIndex = 11
        '
        'DescTxt
        '
        Me.DescTxt.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.DescTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescTxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.DescTxt.Location = New System.Drawing.Point(12, 394)
        Me.DescTxt.Name = "DescTxt"
        Me.DescTxt.Size = New System.Drawing.Size(419, 87)
        Me.DescTxt.TabIndex = 12
        Me.DescTxt.TabStop = False
        Me.DescTxt.Text = ""
        '
        'ParamBox
        '
        Me.ParamBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ParamBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ParamBox.FormattingEnabled = True
        Me.ParamBox.Items.AddRange(New Object() {"AE", "AO", "AS", "CC", "CT", "DF", "DS", "HL", "ID", "LL", "MU", "PS", "SL", "SM", "SN", "ST", "SV", "TU", "UN"})
        Me.ParamBox.Location = New System.Drawing.Point(12, 243)
        Me.ParamBox.Name = "ParamBox"
        Me.ParamBox.Size = New System.Drawing.Size(121, 24)
        Me.ParamBox.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(511, 426)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.InitialImage = CType(resources.GetObject("PictureBox2.InitialImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(435, 416)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(68, 65)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'ParamLbl
        '
        Me.ParamLbl.AutoSize = True
        Me.ParamLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ParamLbl.Location = New System.Drawing.Point(9, 225)
        Me.ParamLbl.Name = "ParamLbl"
        Me.ParamLbl.Size = New System.Drawing.Size(126, 15)
        Me.ParamLbl.TabIndex = 15
        Me.ParamLbl.Text = "Parameter Command"
        '
        'ActLbl
        '
        Me.ActLbl.AutoSize = True
        Me.ActLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActLbl.Location = New System.Drawing.Point(145, 225)
        Me.ActLbl.Name = "ActLbl"
        Me.ActLbl.Size = New System.Drawing.Size(101, 15)
        Me.ActLbl.TabIndex = 16
        Me.ActLbl.Text = "Action Command"
        '
        'DescriptLbl
        '
        Me.DescriptLbl.AutoSize = True
        Me.DescriptLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptLbl.Location = New System.Drawing.Point(9, 375)
        Me.DescriptLbl.Name = "DescriptLbl"
        Me.DescriptLbl.Size = New System.Drawing.Size(75, 15)
        Me.DescriptLbl.TabIndex = 17
        Me.DescriptLbl.Text = "Descriptions"
        '
        'ComLbL
        '
        Me.ComLbL.AutoSize = True
        Me.ComLbL.Location = New System.Drawing.Point(9, 6)
        Me.ComLbL.Name = "ComLbL"
        Me.ComLbL.Size = New System.Drawing.Size(52, 13)
        Me.ComLbL.TabIndex = 18
        Me.ComLbL.Text = "COM port"
        '
        'BaudLbl
        '
        Me.BaudLbl.AutoSize = True
        Me.BaudLbl.Location = New System.Drawing.Point(9, 48)
        Me.BaudLbl.Name = "BaudLbl"
        Me.BaudLbl.Size = New System.Drawing.Size(53, 13)
        Me.BaudLbl.TabIndex = 19
        Me.BaudLbl.Text = "Baud rate"
        Me.BaudLbl.UseWaitCursor = True
        '
        'SendBtn
        '
        Me.SendBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SendBtn.Location = New System.Drawing.Point(196, 297)
        Me.SendBtn.Name = "SendBtn"
        Me.SendBtn.Size = New System.Drawing.Size(55, 27)
        Me.SendBtn.TabIndex = 20
        Me.SendBtn.Text = "Send"
        Me.SendBtn.UseVisualStyleBackColor = True
        '
        'HistBox
        '
        Me.HistBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HistBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.HistBox.FormattingEnabled = True
        Me.HistBox.Location = New System.Drawing.Point(12, 348)
        Me.HistBox.Name = "HistBox"
        Me.HistBox.Size = New System.Drawing.Size(146, 21)
        Me.HistBox.TabIndex = 21
        '
        'HistLbl
        '
        Me.HistLbl.AutoSize = True
        Me.HistLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HistLbl.Location = New System.Drawing.Point(9, 332)
        Me.HistLbl.Name = "HistLbl"
        Me.HistLbl.Size = New System.Drawing.Size(146, 15)
        Me.HistLbl.TabIndex = 22
        Me.HistLbl.Text = "History of sent parameter "
        '
        'Main_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(631, 486)
        Me.Controls.Add(Me.HistLbl)
        Me.Controls.Add(Me.HistBox)
        Me.Controls.Add(Me.SendBtn)
        Me.Controls.Add(Me.BaudLbl)
        Me.Controls.Add(Me.ComLbL)
        Me.Controls.Add(Me.DescriptLbl)
        Me.Controls.Add(Me.ActLbl)
        Me.Controls.Add(Me.ParamLbl)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DescTxt)
        Me.Controls.Add(Me.ParamBox)
        Me.Controls.Add(Me.ActBox)
        Me.Controls.Add(Me.SavBtn)
        Me.Controls.Add(Me.BudBox)
        Me.Controls.Add(Me.closeBtn)
        Me.Controls.Add(Me.ReceiveLbl)
        Me.Controls.Add(Me.SendLbl)
        Me.Controls.Add(Me.RecTxt)
        Me.Controls.Add(Me.SendTxt)
        Me.Controls.Add(Me.PortBox)
        Me.Controls.Add(Me.InitBtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main_frm"
        Me.Text = "Telstra Swinburne RF Lab - Luxtron 812 Controller"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InitBtn As System.Windows.Forms.Button
    Friend WithEvents PortBox As System.Windows.Forms.ComboBox
    Friend WithEvents SendTxt As System.Windows.Forms.RichTextBox
    Friend WithEvents RecTxt As System.Windows.Forms.RichTextBox
    Friend WithEvents SendLbl As System.Windows.Forms.Label
    Friend WithEvents ReceiveLbl As System.Windows.Forms.Label
    Friend WithEvents closeBtn As System.Windows.Forms.Button
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents BudBox As System.Windows.Forms.ComboBox
    Friend WithEvents SavBtn As System.Windows.Forms.Button
    Friend WithEvents ActBox As System.Windows.Forms.ComboBox
    Friend WithEvents DescTxt As System.Windows.Forms.RichTextBox
    Friend WithEvents ParamBox As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ParamLbl As Label
    Friend WithEvents ActLbl As Label
    Friend WithEvents DescriptLbl As Label
    Friend WithEvents ComLbL As Label
    Friend WithEvents BaudLbl As Label
    Friend WithEvents SendBtn As Button
    Friend WithEvents HistBox As ComboBox
    Friend WithEvents HistLbl As Label
End Class
