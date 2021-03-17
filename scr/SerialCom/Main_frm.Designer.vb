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
        Me.ActBtn = New System.Windows.Forms.Button()
        Me.PortBox = New System.Windows.Forms.ComboBox()
        Me.SendTxt = New System.Windows.Forms.RichTextBox()
        Me.RecTxt = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.BudBox = New System.Windows.Forms.ComboBox()
        Me.ParamBtn = New System.Windows.Forms.Button()
        Me.SavBtn = New System.Windows.Forms.Button()
        Me.ActBox = New System.Windows.Forms.ComboBox()
        Me.DescTxt = New System.Windows.Forms.RichTextBox()
        Me.ParamBox = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InitBtn
        '
        Me.InitBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InitBtn.Location = New System.Drawing.Point(543, 60)
        Me.InitBtn.Name = "InitBtn"
        Me.InitBtn.Size = New System.Drawing.Size(91, 32)
        Me.InitBtn.TabIndex = 0
        Me.InitBtn.Text = "Init"
        Me.InitBtn.UseVisualStyleBackColor = True
        '
        'ActBtn
        '
        Me.ActBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActBtn.Location = New System.Drawing.Point(543, 300)
        Me.ActBtn.Name = "ActBtn"
        Me.ActBtn.Size = New System.Drawing.Size(91, 43)
        Me.ActBtn.TabIndex = 1
        Me.ActBtn.Text = "Send Action Command"
        Me.ActBtn.UseVisualStyleBackColor = True
        '
        'PortBox
        '
        Me.PortBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PortBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.PortBox.FormattingEnabled = True
        Me.PortBox.Location = New System.Drawing.Point(416, 45)
        Me.PortBox.Name = "PortBox"
        Me.PortBox.Size = New System.Drawing.Size(121, 28)
        Me.PortBox.TabIndex = 3
        '
        'SendTxt
        '
        Me.SendTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SendTxt.Location = New System.Drawing.Point(17, 30)
        Me.SendTxt.Name = "SendTxt"
        Me.SendTxt.Size = New System.Drawing.Size(373, 43)
        Me.SendTxt.TabIndex = 4
        Me.SendTxt.Text = ""
        '
        'RecTxt
        '
        Me.RecTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RecTxt.Location = New System.Drawing.Point(17, 101)
        Me.RecTxt.Name = "RecTxt"
        Me.RecTxt.Size = New System.Drawing.Size(373, 420)
        Me.RecTxt.TabIndex = 5
        Me.RecTxt.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(17, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Send"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(17, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Recieve"
        '
        'closeBtn
        '
        Me.closeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBtn.Location = New System.Drawing.Point(416, 450)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(218, 32)
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
        Me.BudBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BudBox.FormattingEnabled = True
        Me.BudBox.Items.AddRange(New Object() {"9600", "38400", "57600", "115200"})
        Me.BudBox.Location = New System.Drawing.Point(416, 88)
        Me.BudBox.Name = "BudBox"
        Me.BudBox.Size = New System.Drawing.Size(121, 28)
        Me.BudBox.TabIndex = 9
        '
        'ParamBtn
        '
        Me.ParamBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ParamBtn.Location = New System.Drawing.Point(543, 192)
        Me.ParamBtn.Name = "ParamBtn"
        Me.ParamBtn.Size = New System.Drawing.Size(91, 60)
        Me.ParamBtn.TabIndex = 1
        Me.ParamBtn.Text = "Send Parameter Command"
        Me.ParamBtn.UseVisualStyleBackColor = True
        '
        'SavBtn
        '
        Me.SavBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SavBtn.Location = New System.Drawing.Point(416, 395)
        Me.SavBtn.Name = "SavBtn"
        Me.SavBtn.Size = New System.Drawing.Size(218, 32)
        Me.SavBtn.TabIndex = 10
        Me.SavBtn.Text = "Start saving data"
        Me.SavBtn.UseVisualStyleBackColor = True
        '
        'ActBox
        '
        Me.ActBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ActBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ActBox.FormattingEnabled = True
        Me.ActBox.Items.AddRange(New Object() {"CTRL+A", "CTRL+D", "CTRL+E", "CTRL+F", "CTRL+I", "CTRL+K", "CTRL+R", "CTRL+S", "CTRL+T", "CTRL+X"})
        Me.ActBox.Location = New System.Drawing.Point(416, 307)
        Me.ActBox.Name = "ActBox"
        Me.ActBox.Size = New System.Drawing.Size(121, 28)
        Me.ActBox.TabIndex = 11
        '
        'DescTxt
        '
        Me.DescTxt.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.DescTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescTxt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.DescTxt.Location = New System.Drawing.Point(17, 527)
        Me.DescTxt.Name = "DescTxt"
        Me.DescTxt.Size = New System.Drawing.Size(373, 90)
        Me.DescTxt.TabIndex = 12
        Me.DescTxt.TabStop = False
        Me.DescTxt.Text = ""
        '
        'ParamBox
        '
        Me.ParamBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ParamBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ParamBox.FormattingEnabled = True
        Me.ParamBox.Items.AddRange(New Object() {"AE", "AO", "AS", "CC", "CT", "DF", "DS", "HL", "ID", "LL", "MU", "PS", "SL", "SM", "SN", "ST", "SV", "TU", "UN"})
        Me.ParamBox.Location = New System.Drawing.Point(416, 208)
        Me.ParamBox.Name = "ParamBox"
        Me.ParamBox.Size = New System.Drawing.Size(121, 28)
        Me.ParamBox.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(511, 545)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(123, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.InitialImage = CType(resources.GetObject("PictureBox2.InitialImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(416, 545)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(68, 72)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'Main_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(647, 622)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DescTxt)
        Me.Controls.Add(Me.ParamBox)
        Me.Controls.Add(Me.ActBox)
        Me.Controls.Add(Me.SavBtn)
        Me.Controls.Add(Me.BudBox)
        Me.Controls.Add(Me.closeBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RecTxt)
        Me.Controls.Add(Me.SendTxt)
        Me.Controls.Add(Me.PortBox)
        Me.Controls.Add(Me.ParamBtn)
        Me.Controls.Add(Me.ActBtn)
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
    Friend WithEvents ActBtn As System.Windows.Forms.Button
    Friend WithEvents PortBox As System.Windows.Forms.ComboBox
    Friend WithEvents SendTxt As System.Windows.Forms.RichTextBox
    Friend WithEvents RecTxt As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents closeBtn As System.Windows.Forms.Button
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents BudBox As System.Windows.Forms.ComboBox
    Friend WithEvents ParamBtn As System.Windows.Forms.Button
    Friend WithEvents SavBtn As System.Windows.Forms.Button
    Friend WithEvents ActBox As System.Windows.Forms.ComboBox
    Friend WithEvents DescTxt As System.Windows.Forms.RichTextBox
    Friend WithEvents ParamBox As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
