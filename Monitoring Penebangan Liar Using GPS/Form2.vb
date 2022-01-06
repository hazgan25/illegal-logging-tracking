Imports System
Imports System.IO.Ports
Imports GMap.NET
Imports GMap.NET.WindowsForms
Imports GMap.NET.MapProviders



Public Class Form2
    Private copter_lat1, copter_lon1 As Double
    Private copter_lat2, copter_lon2 As Double
    Private WithEvents copter_marker1 As Markers.GMarkerGoogle
    Private WithEvents copter_marker2 As Markers.GMarkerGoogle
    Private WithEvents marker1 As Markers.GMarkerGoogle
    Private WithEvents marker2 As Markers.GMarkerGoogle
    Private WithEvents copter_layer As GMapOverlay
    Private Property points As List(Of PointLatLng)


    Dim lat, longt As String
    Dim lat2, longt2 As String
    Dim Clat, Clongt As Double
    Dim Clat2, Clongt2 As Double

    Dim flag_masuk As Integer
    Dim flag_first As Integer
    Dim flag_terima As Integer
    Dim getar1 As Double
    Dim suara1 As Double
    Dim getar2 As Double
    Dim suara2 As Double
    Dim nilai_lat1 As Double
    Dim nilai_long1 As Double
    Dim nilai_lat2 As Double
    Dim nilai_long2 As Double
    Dim nilai_getar1 As Double
    Dim nilai_suara1 As Double
    Dim nilai_getar2 As Double
    Dim nilai_suara2 As Double
    Dim id_pohon As Double
    Dim s As String
    Dim sp() As String
    Dim sep As String

    Dim comPORT As String


    Private Sub Connect_Button_Click(sender As Object, e As EventArgs) Handles Connect_Button.Click
        If (Connect_Button.Text = "Connect") Then
            If (comPORT <> "") Then
                SerialPort_data.Close()
                SerialPort_data.PortName = comPORT
                SerialPort_data.BaudRate = 9600
                SerialPort_data.DataBits = 8
                SerialPort_data.Parity = Parity.None
                SerialPort_data.StopBits = StopBits.One
                SerialPort_data.Handshake = Handshake.None
                SerialPort_data.Encoding = System.Text.Encoding.Default
                SerialPort_data.ReadTimeout = 10000

                SerialPort_data.Open()
                Connect_Button.Text = "Dis-connect"
                Timer_jam.Enabled = True
                flag_masuk = 1
                Status_ArduinoLBL.Text = "Status Arduino : ON"
                cmbComPort.Enabled = False
            Else
                MsgBox("Masukan Port Arduinonya Terlebih Dahulu")
            End If
        Else
            SerialPort_data.Close()
            Connect_Button.Text = "Connect"
            Timer_jam.Enabled = False
            flag_masuk = 0
            Status_ArduinoLBL.Text = "Status Arduino : OFF"
            cmbComPort.Enabled = True
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sep = ","
        flag_terima = 0
        flag_first = 0
        flag_masuk = 0
        copter_lat1 = -6.1476383
        copter_lon1 = 106.80386
        copter_lat2 = -6.1476383
        copter_lon2 = 106.80386
        myMap.DragButton = Windows.Forms.MouseButtons.Left
        myMap.MinZoom = 5 'set minimal zoom map sebesar 5
        myMap.MaxZoom = 20 'set maksimal zoom sebesar 20
        myMap.Zoom = 19 'set level zoom pertama kali sebesar 17
        myMap.Position = New PointLatLng(copter_lat1, copter_lon1)
        myMap.Position = New PointLatLng(copter_lat2, copter_lon2)
        myMap.MapProvider = MapProviders.GMapProviders.GoogleMap
        myMap.Manager.Mode = AccessMode.ServerAndCache

        GMapProviders.GoogleMap.ApiKey = ""
        copter_marker1 = New Markers.GMarkerGoogle(New PointLatLng(copter_lat1, copter_lon1), Markers.GMarkerGoogleType.green_dot)
        copter_marker2 = New Markers.GMarkerGoogle(New PointLatLng(copter_lat2, copter_lon2), Markers.GMarkerGoogleType.blue_dot)

        copter_layer = New GMapOverlay()
        myMap.Overlays.Add(copter_layer)
        copter_layer.Markers.Add(copter_marker1)
        copter_layer.Markers.Add(copter_marker2)

        comPORT = ""
        For Each sp As String In My.Computer.Ports.SerialPortNames
            cmbComPort.Items.Add(sp)
        Next

        LabelTanggalLBL.Text = Today
        LabelJam.Text = TimeOfDay

    End Sub
    Private Sub update_map()
        copter_marker1.Position = New PointLatLng(copter_lat1, copter_lon1)
        copter_marker2.Position = New PointLatLng(copter_lat2, copter_lon2)
        myMap.UpdateMarkerLocalPosition(copter_marker1)
        myMap.UpdateMarkerLocalPosition(copter_marker2)

        If id_pohon = 1 Then
            IdA.Text = "ID A : " + id_pohon.ToString()
            SenSurA.Text = "Sensor Suara : " + nilai_suara1.ToString()
            SenGetA.Text = "Sensor Getar : " + nilai_getar1.ToString()
            lblInfoLatA.Text = "Latitude :" + CStr(copter_lat1)
            lblInfoLongA.Text = "Longitude : " + CStr(copter_lon1)
        End If

        If id_pohon = 2 Then
            IdB.Text = "ID B : " + id_pohon.ToString()
            SenSurB.Text = "Sensor Suara : " + nilai_suara2.ToString()
            SenGetB.Text = "Sensor Getar : " + nilai_getar2.ToString()

            lblInfoLatB.Text = "Latitude :" + CStr(copter_lat2)
            lblInfoLongB.Text = "Longitude : " + CStr(copter_lon2)
        End If

    End Sub

    Public Sub New()

        InitializeComponent()
        points = New List(Of PointLatLng)()

    End Sub

    Private Sub Timer_jam_Tick(sender As Object, e As EventArgs) Handles Timer_jam.Tick
        LabelTanggalLBL.Text = Today
        LabelJam.Text = TimeOfDay
        ZoomLevel.Text = "Zoom Level : " + CStr(myMap.Zoom)

        If flag_masuk = 1 Then
            If flag_terima = 1 Then
                flag_terima = 0
                copter_lat1 = nilai_lat1
                copter_lon1 = nilai_long1
                getar1 = nilai_getar1
                suara1 = nilai_suara1
                copter_lat2 = nilai_lat2
                copter_lon2 = nilai_long2
                getar2 = nilai_getar2
                suara2 = nilai_suara2
                update_map()

                ''sensor suara 1
                If suara1 >= 200 Then
                    KondisiPohon1.Text = "Danger"
                    KondisiPohon1.BackColor = Color.Red
                End If
                If suara1 < 200 Then
                    KondisiPohon1.Text = "Safe"
                    KondisiPohon1.BackColor = Color.Green
                End If
                ''sensor getar 1
                If getar1 >= 500 Then
                    KondisiPohon1.Text = "Danger"
                    KondisiPohon1.BackColor = Color.Red
                End If
                If getar1 < 500 Then
                    KondisiPohon1.Text = "Safe"
                    KondisiPohon1.BackColor = Color.Green
                End If

                'sensor suara 2
                If suara2 >= 200 Then
                    KondisiPohon2.Text = "Danger"
                    KondisiPohon2.BackColor = Color.Red
                End If
                If suara2 < 200 Then
                    KondisiPohon2.Text = "Safe"
                    KondisiPohon2.BackColor = Color.Green
                End If

                'sensor getar 2
                If getar2 >= 500 Then
                    KondisiPohon2.Text = "Danger"
                    KondisiPohon2.BackColor = Color.Red
                End If
                If getar2 < 500 Then
                    KondisiPohon2.Text = "Safe"
                    KondisiPohon2.BackColor = Color.Green
                End If

                If flag_first = 0 Then
                    flag_first = 1

                End If

            End If
        End If
    End Sub

    Private Sub SerialPort_data_DataReceived(ByVal sender As System.Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort_data.DataReceived
        Dim str As String
        str = SerialPort_data.ReadLine()
        s = str
        sp = s.Split(",")
        id_pohon = Val(sp(0))
        If id_pohon = 1 Then
            nilai_getar1 = Val(sp(1))
            nilai_suara1 = Val(sp(2))
            nilai_lat1 = Val(sp(3))
            nilai_long1 = Val(sp(4))
        End If
        If id_pohon = 2 Then
            nilai_getar2 = Val(sp(1))
            nilai_suara2 = Val(sp(2))
            nilai_lat2 = Val(sp(3))
            nilai_long2 = Val(sp(4))
        End If

        flag_terima = 1
    End Sub

    Private Sub cmbComPort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbComPort.SelectedIndexChanged
        If (cmbComPort.SelectedItem <> "") Then
            comPORT = cmbComPort.SelectedItem
        End If
    End Sub

    Private Sub btnClearList_Click(sender As Object, e As EventArgs)
        points.Clear()
        If (myMap.Overlays.Count > 0) Then
            myMap.Overlays.RemoveAt(0)
            myMap.Refresh()
        End If
    End Sub

    Private Sub btnAddPoint_Click(sender As Object, e As EventArgs)
        points.Add(New PointLatLng(Clat, Clongt))
        points.Add(New PointLatLng(Clat2, Clongt2))
    End Sub

    Private Sub Logout_Button_Click(sender As Object, e As EventArgs) Handles Logout_Button.Click
        'Logout
        If MsgBox("Anda Yakin Ingin Logout?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo) <> Windows.Forms.DialogResult.Yes Then
        Else
            Form1.Show()
            Me.Hide()
            MsgBox("Anda Berhasil Logout!")
            Me.Close()
        End If
    End Sub

End Class
