<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Logout_Button = New System.Windows.Forms.Button()
        Me.Connect_Button = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LabelJam = New System.Windows.Forms.Label()
        Me.LabelTanggalLBL = New System.Windows.Forms.Label()
        Me.JamLBL = New System.Windows.Forms.Label()
        Me.TanggalLBL = New System.Windows.Forms.Label()
        Me.ComportLBL = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Status_ArduinoLBL = New System.Windows.Forms.Label()
        Me.statusPohonA = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbComPort = New System.Windows.Forms.ComboBox()
        Me.IdA = New System.Windows.Forms.Label()
        Me.SenSurA = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.KondisiPohon1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.KondisiPohon2 = New System.Windows.Forms.TextBox()
        Me.SenGetA = New System.Windows.Forms.Label()
        Me.lblInfoLatA = New System.Windows.Forms.Label()
        Me.lblInfoLongA = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.IdB = New System.Windows.Forms.Label()
        Me.SenSurB = New System.Windows.Forms.Label()
        Me.SenGetB = New System.Windows.Forms.Label()
        Me.lblInfoLatB = New System.Windows.Forms.Label()
        Me.lblInfoLongB = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.myMap = New GMap.NET.WindowsForms.GMapControl()
        Me.ZoomLevel = New System.Windows.Forms.Label()
        Me.Timer_jam = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort_data = New System.IO.Ports.SerialPort(Me.components)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Logout_Button
        '
        Me.Logout_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logout_Button.Location = New System.Drawing.Point(1263, 12)
        Me.Logout_Button.Name = "Logout_Button"
        Me.Logout_Button.Size = New System.Drawing.Size(75, 23)
        Me.Logout_Button.TabIndex = 1
        Me.Logout_Button.Text = "Logout"
        Me.Logout_Button.UseVisualStyleBackColor = True
        '
        'Connect_Button
        '
        Me.Connect_Button.Location = New System.Drawing.Point(165, 8)
        Me.Connect_Button.Name = "Connect_Button"
        Me.Connect_Button.Size = New System.Drawing.Size(75, 23)
        Me.Connect_Button.TabIndex = 4
        Me.Connect_Button.Text = "Connect"
        Me.Connect_Button.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Monitoring_Penebangan_Liar_Using_GPS.My.Resources.Resources.sidebar
        Me.PictureBox2.Location = New System.Drawing.Point(-1, 45)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(223, 686)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'LabelJam
        '
        Me.LabelJam.AutoSize = True
        Me.LabelJam.BackColor = System.Drawing.Color.Transparent
        Me.LabelJam.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.LabelJam.Image = Global.Monitoring_Penebangan_Liar_Using_GPS.My.Resources.Resources.header
        Me.LabelJam.Location = New System.Drawing.Point(1158, 17)
        Me.LabelJam.Name = "LabelJam"
        Me.LabelJam.Size = New System.Drawing.Size(49, 13)
        Me.LabelJam.TabIndex = 8
        Me.LabelJam.Text = "Labeljam"
        '
        'LabelTanggalLBL
        '
        Me.LabelTanggalLBL.AutoSize = True
        Me.LabelTanggalLBL.BackColor = System.Drawing.Color.Transparent
        Me.LabelTanggalLBL.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.LabelTanggalLBL.Image = Global.Monitoring_Penebangan_Liar_Using_GPS.My.Resources.Resources.header
        Me.LabelTanggalLBL.Location = New System.Drawing.Point(1046, 17)
        Me.LabelTanggalLBL.Name = "LabelTanggalLBL"
        Me.LabelTanggalLBL.Size = New System.Drawing.Size(68, 13)
        Me.LabelTanggalLBL.TabIndex = 7
        Me.LabelTanggalLBL.Text = "Labeltanngal"
        '
        'JamLBL
        '
        Me.JamLBL.AutoSize = True
        Me.JamLBL.BackColor = System.Drawing.Color.Transparent
        Me.JamLBL.ForeColor = System.Drawing.Color.Transparent
        Me.JamLBL.Image = Global.Monitoring_Penebangan_Liar_Using_GPS.My.Resources.Resources.header
        Me.JamLBL.Location = New System.Drawing.Point(1120, 17)
        Me.JamLBL.Name = "JamLBL"
        Me.JamLBL.Size = New System.Drawing.Size(32, 13)
        Me.JamLBL.TabIndex = 6
        Me.JamLBL.Text = "Jam :"
        '
        'TanggalLBL
        '
        Me.TanggalLBL.AutoSize = True
        Me.TanggalLBL.BackColor = System.Drawing.Color.Transparent
        Me.TanggalLBL.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.TanggalLBL.Image = Global.Monitoring_Penebangan_Liar_Using_GPS.My.Resources.Resources.header
        Me.TanggalLBL.Location = New System.Drawing.Point(988, 17)
        Me.TanggalLBL.Name = "TanggalLBL"
        Me.TanggalLBL.Size = New System.Drawing.Size(52, 13)
        Me.TanggalLBL.TabIndex = 5
        Me.TanggalLBL.Text = "Tanggal :"
        '
        'ComportLBL
        '
        Me.ComportLBL.AutoSize = True
        Me.ComportLBL.BackColor = System.Drawing.Color.Transparent
        Me.ComportLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComportLBL.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ComportLBL.Image = Global.Monitoring_Penebangan_Liar_Using_GPS.My.Resources.Resources.header
        Me.ComportLBL.Location = New System.Drawing.Point(-1, 11)
        Me.ComportLBL.Name = "ComportLBL"
        Me.ComportLBL.Size = New System.Drawing.Size(83, 20)
        Me.ComportLBL.TabIndex = 2
        Me.ComportLBL.Text = "Com Port"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Monitoring_Penebangan_Liar_Using_GPS.My.Resources.Resources.header
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1361, 47)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Status_ArduinoLBL
        '
        Me.Status_ArduinoLBL.AutoSize = True
        Me.Status_ArduinoLBL.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Status_ArduinoLBL.Image = Global.Monitoring_Penebangan_Liar_Using_GPS.My.Resources.Resources.header
        Me.Status_ArduinoLBL.Location = New System.Drawing.Point(477, 17)
        Me.Status_ArduinoLBL.Name = "Status_ArduinoLBL"
        Me.Status_ArduinoLBL.Size = New System.Drawing.Size(105, 13)
        Me.Status_ArduinoLBL.TabIndex = 26
        Me.Status_ArduinoLBL.Text = "Status Arduino : OFF"
        '
        'statusPohonA
        '
        Me.statusPohonA.AutoSize = True
        Me.statusPohonA.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusPohonA.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.statusPohonA.Image = Global.Monitoring_Penebangan_Liar_Using_GPS.My.Resources.Resources.sidebar
        Me.statusPohonA.Location = New System.Drawing.Point(-1, 184)
        Me.statusPohonA.Name = "statusPohonA"
        Me.statusPohonA.Size = New System.Drawing.Size(223, 24)
        Me.statusPohonA.TabIndex = 27
        Me.statusPohonA.Text = "Keterangan Status Pohon"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Image = Global.Monitoring_Penebangan_Liar_Using_GPS.My.Resources.Resources.sidebar
        Me.Label2.Location = New System.Drawing.Point(-1, 236)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 20)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Info Pohon A"
        '
        'cmbComPort
        '
        Me.cmbComPort.BackColor = System.Drawing.Color.LightGray
        Me.cmbComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbComPort.DropDownWidth = 71
        Me.cmbComPort.FormattingEnabled = True
        Me.cmbComPort.Location = New System.Drawing.Point(88, 10)
        Me.cmbComPort.Name = "cmbComPort"
        Me.cmbComPort.Size = New System.Drawing.Size(71, 21)
        Me.cmbComPort.TabIndex = 88
        '
        'IdA
        '
        Me.IdA.AutoSize = True
        Me.IdA.ForeColor = System.Drawing.Color.White
        Me.IdA.Image = Global.Monitoring_Penebangan_Liar_Using_GPS.My.Resources.Resources.sidebar
        Me.IdA.Location = New System.Drawing.Point(13, 256)
        Me.IdA.Name = "IdA"
        Me.IdA.Size = New System.Drawing.Size(40, 13)
        Me.IdA.TabIndex = 93
        Me.IdA.Text = "ID A : -"
        '
        'SenSurA
        '
        Me.SenSurA.AutoSize = True
        Me.SenSurA.ForeColor = System.Drawing.Color.White
        Me.SenSurA.Image = Global.Monitoring_Penebangan_Liar_Using_GPS.My.Resources.Resources.sidebar
        Me.SenSurA.Location = New System.Drawing.Point(13, 269)
        Me.SenSurA.Name = "SenSurA"
        Me.SenSurA.Size = New System.Drawing.Size(83, 13)
        Me.SenSurA.TabIndex = 94
        Me.SenSurA.Text = "Sensor Suara : -"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Image = Global.Monitoring_Penebangan_Liar_Using_GPS.My.Resources.Resources.sidebar
        Me.Label1.Location = New System.Drawing.Point(39, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 24)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "Kondisi Pohon"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Image = Global.Monitoring_Penebangan_Liar_Using_GPS.My.Resources.Resources.sidebar
        Me.Label3.Location = New System.Drawing.Point(0, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "Pohon A"
        '
        'KondisiPohon1
        '
        Me.KondisiPohon1.ForeColor = System.Drawing.Color.White
        Me.KondisiPohon1.Location = New System.Drawing.Point(8, 124)
        Me.KondisiPohon1.Name = "KondisiPohon1"
        Me.KondisiPohon1.Size = New System.Drawing.Size(49, 20)
        Me.KondisiPohon1.TabIndex = 97
        Me.KondisiPohon1.Text = "Out Of Track"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Image = Global.Monitoring_Penebangan_Liar_Using_GPS.My.Resources.Resources.sidebar
        Me.Label4.Location = New System.Drawing.Point(152, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "Pohon B"
        '
        'KondisiPohon2
        '
        Me.KondisiPohon2.ForeColor = System.Drawing.Color.White
        Me.KondisiPohon2.Location = New System.Drawing.Point(165, 124)
        Me.KondisiPohon2.Name = "KondisiPohon2"
        Me.KondisiPohon2.Size = New System.Drawing.Size(49, 20)
        Me.KondisiPohon2.TabIndex = 99
        Me.KondisiPohon2.Text = "Out Of Track"
        '
        'SenGetA
        '
        Me.SenGetA.AutoSize = True
        Me.SenGetA.ForeColor = System.Drawing.Color.White
        Me.SenGetA.Image = Global.Monitoring_Penebangan_Liar_Using_GPS.My.Resources.Resources.sidebar
        Me.SenGetA.Location = New System.Drawing.Point(13, 282)
        Me.SenGetA.Name = "SenGetA"
        Me.SenGetA.Size = New System.Drawing.Size(81, 13)
        Me.SenGetA.TabIndex = 100
        Me.SenGetA.Text = "Sensor Getar : -"
        '
        'lblInfoLatA
        '
        Me.lblInfoLatA.AutoSize = True
        Me.lblInfoLatA.ForeColor = System.Drawing.Color.White
        Me.lblInfoLatA.Image = Global.Monitoring_Penebangan_Liar_Using_GPS.My.Resources.Resources.sidebar
        Me.lblInfoLatA.Location = New System.Drawing.Point(13, 295)
        Me.lblInfoLatA.Name = "lblInfoLatA"
        Me.lblInfoLatA.Size = New System.Drawing.Size(57, 13)
        Me.lblInfoLatA.TabIndex = 101
        Me.lblInfoLatA.Text = "Latitude : -"
        '
        'lblInfoLongA
        '
        Me.lblInfoLongA.AutoSize = True
        Me.lblInfoLongA.ForeColor = System.Drawing.Color.White
        Me.lblInfoLongA.Image = Global.Monitoring_Penebangan_Liar_Using_GPS.My.Resources.Resources.sidebar
        Me.lblInfoLongA.Location = New System.Drawing.Point(13, 308)
        Me.lblInfoLongA.Name = "lblInfoLongA"
        Me.lblInfoLongA.Size = New System.Drawing.Size(66, 13)
        Me.lblInfoLongA.TabIndex = 102
        Me.lblInfoLongA.Text = "Longitude : -"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Image = Global.Monitoring_Penebangan_Liar_Using_GPS.My.Resources.Resources.sidebar
        Me.Label5.Location = New System.Drawing.Point(-1, 364)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 20)
        Me.Label5.TabIndex = 103
        Me.Label5.Text = "Info Pohon B"
        '
        'IdB
        '
        Me.IdB.AutoSize = True
        Me.IdB.ForeColor = System.Drawing.Color.White
        Me.IdB.Image = Global.Monitoring_Penebangan_Liar_Using_GPS.My.Resources.Resources.sidebar
        Me.IdB.Location = New System.Drawing.Point(13, 384)
        Me.IdB.Name = "IdB"
        Me.IdB.Size = New System.Drawing.Size(40, 13)
        Me.IdB.TabIndex = 104
        Me.IdB.Text = "ID B : -"
        '
        'SenSurB
        '
        Me.SenSurB.AutoSize = True
        Me.SenSurB.ForeColor = System.Drawing.Color.White
        Me.SenSurB.Image = Global.Monitoring_Penebangan_Liar_Using_GPS.My.Resources.Resources.sidebar
        Me.SenSurB.Location = New System.Drawing.Point(13, 397)
        Me.SenSurB.Name = "SenSurB"
        Me.SenSurB.Size = New System.Drawing.Size(83, 13)
        Me.SenSurB.TabIndex = 105
        Me.SenSurB.Text = "Sensor Suara : -"
        '
        'SenGetB
        '
        Me.SenGetB.AutoSize = True
        Me.SenGetB.ForeColor = System.Drawing.Color.White
        Me.SenGetB.Image = Global.Monitoring_Penebangan_Liar_Using_GPS.My.Resources.Resources.sidebar
        Me.SenGetB.Location = New System.Drawing.Point(12, 410)
        Me.SenGetB.Name = "SenGetB"
        Me.SenGetB.Size = New System.Drawing.Size(81, 13)
        Me.SenGetB.TabIndex = 106
        Me.SenGetB.Text = "Sensor Getar : -"
        '
        'lblInfoLatB
        '
        Me.lblInfoLatB.AutoSize = True
        Me.lblInfoLatB.ForeColor = System.Drawing.Color.White
        Me.lblInfoLatB.Image = Global.Monitoring_Penebangan_Liar_Using_GPS.My.Resources.Resources.sidebar
        Me.lblInfoLatB.Location = New System.Drawing.Point(12, 423)
        Me.lblInfoLatB.Name = "lblInfoLatB"
        Me.lblInfoLatB.Size = New System.Drawing.Size(57, 13)
        Me.lblInfoLatB.TabIndex = 107
        Me.lblInfoLatB.Text = "Latitude : -"
        '
        'lblInfoLongB
        '
        Me.lblInfoLongB.AutoSize = True
        Me.lblInfoLongB.ForeColor = System.Drawing.Color.White
        Me.lblInfoLongB.Image = Global.Monitoring_Penebangan_Liar_Using_GPS.My.Resources.Resources.sidebar
        Me.lblInfoLongB.Location = New System.Drawing.Point(13, 436)
        Me.lblInfoLongB.Name = "lblInfoLongB"
        Me.lblInfoLongB.Size = New System.Drawing.Size(66, 13)
        Me.lblInfoLongB.TabIndex = 108
        Me.lblInfoLongB.Text = "Longitude : -"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label6.Image = Global.Monitoring_Penebangan_Liar_Using_GPS.My.Resources.Resources.sidebar
        Me.Label6.Location = New System.Drawing.Point(4, 513)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(213, 24)
        Me.Label6.TabIndex = 109
        Me.Label6.Text = "Keterangan Pointer Map"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Image = Global.Monitoring_Penebangan_Liar_Using_GPS.My.Resources.Resources.sidebar
        Me.Label7.Location = New System.Drawing.Point(4, 549)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(172, 20)
        Me.Label7.TabIndex = 110
        Me.Label7.Text = "Pointer Pohon A : Hijau"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Image = Global.Monitoring_Penebangan_Liar_Using_GPS.My.Resources.Resources.sidebar
        Me.Label8.Location = New System.Drawing.Point(4, 581)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(164, 20)
        Me.Label8.TabIndex = 111
        Me.Label8.Text = "Pointer Pohon B : Biru"
        '
        'myMap
        '
        Me.myMap.Bearing = 0!
        Me.myMap.CanDragMap = True
        Me.myMap.EmptyTileColor = System.Drawing.Color.Navy
        Me.myMap.GrayScaleMode = False
        Me.myMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow
        Me.myMap.LevelsKeepInMemmory = 5
        Me.myMap.Location = New System.Drawing.Point(228, 53)
        Me.myMap.MarkersEnabled = True
        Me.myMap.MaxZoom = 2
        Me.myMap.MinZoom = 2
        Me.myMap.MouseWheelZoomEnabled = True
        Me.myMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter
        Me.myMap.Name = "myMap"
        Me.myMap.NegativeMode = False
        Me.myMap.PolygonsEnabled = True
        Me.myMap.RetryLoadTile = 0
        Me.myMap.RoutesEnabled = True
        Me.myMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.[Integer]
        Me.myMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.myMap.ShowTileGridLines = False
        Me.myMap.Size = New System.Drawing.Size(1132, 670)
        Me.myMap.TabIndex = 112
        Me.myMap.Zoom = 0R
        '
        'ZoomLevel
        '
        Me.ZoomLevel.AutoSize = True
        Me.ZoomLevel.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ZoomLevel.Image = Global.Monitoring_Penebangan_Liar_Using_GPS.My.Resources.Resources.header
        Me.ZoomLevel.Location = New System.Drawing.Point(806, 17)
        Me.ZoomLevel.Name = "ZoomLevel"
        Me.ZoomLevel.Size = New System.Drawing.Size(75, 13)
        Me.ZoomLevel.TabIndex = 113
        Me.ZoomLevel.Text = "Zoom Level : -"
        '
        'Timer_jam
        '
        '
        'SerialPort_data
        '
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1358, 719)
        Me.Controls.Add(Me.ZoomLevel)
        Me.Controls.Add(Me.myMap)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblInfoLongB)
        Me.Controls.Add(Me.lblInfoLatB)
        Me.Controls.Add(Me.SenGetB)
        Me.Controls.Add(Me.SenSurB)
        Me.Controls.Add(Me.IdB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblInfoLongA)
        Me.Controls.Add(Me.lblInfoLatA)
        Me.Controls.Add(Me.SenGetA)
        Me.Controls.Add(Me.KondisiPohon2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.KondisiPohon1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SenSurA)
        Me.Controls.Add(Me.IdA)
        Me.Controls.Add(Me.cmbComPort)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.statusPohonA)
        Me.Controls.Add(Me.Status_ArduinoLBL)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LabelJam)
        Me.Controls.Add(Me.LabelTanggalLBL)
        Me.Controls.Add(Me.JamLBL)
        Me.Controls.Add(Me.TanggalLBL)
        Me.Controls.Add(Me.Connect_Button)
        Me.Controls.Add(Me.ComportLBL)
        Me.Controls.Add(Me.Logout_Button)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Monitoring Penebangan Liar (Halaman Utama)"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Logout_Button As Button
    Friend WithEvents ComportLBL As Label
    Friend WithEvents Connect_Button As Button
    Friend WithEvents TanggalLBL As Label
    Friend WithEvents JamLBL As Label
    Friend WithEvents LabelTanggalLBL As Label
    Friend WithEvents LabelJam As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Status_ArduinoLBL As Label
    Friend WithEvents statusPohonA As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbComPort As ComboBox
    Friend WithEvents IdA As Label
    Friend WithEvents SenSurA As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents KondisiPohon1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents KondisiPohon2 As TextBox
    Friend WithEvents SenGetA As Label
    Friend WithEvents lblInfoLatA As Label
    Friend WithEvents lblInfoLongA As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents IdB As Label
    Friend WithEvents SenSurB As Label
    Friend WithEvents SenGetB As Label
    Friend WithEvents lblInfoLatB As Label
    Friend WithEvents lblInfoLongB As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents myMap As GMap.NET.WindowsForms.GMapControl
    Friend WithEvents ZoomLevel As Label
    Friend WithEvents Timer_jam As Timer
    Friend WithEvents SerialPort_data As IO.Ports.SerialPort
End Class
