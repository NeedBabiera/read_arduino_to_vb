Imports System.Windows.Forms

Public Class Form1
    Dim member As New DatabaseClass
    Dim setup As New SetupClass

    Dim myPort As String = ""
    Dim readData As String = ""
    Dim strArr() As String
    Dim count As Integer
    Dim tempFahrenheit As Decimal
    Dim turbVal As Integer
    Dim phValue As Decimal
    Dim isEdit As Boolean = False
    Dim dateTimeVal As Date

    Dim tempDesc As String = ""
    Dim turbDesc As String = ""
    Dim phValDesc As String = ""

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PortSetup()
        dateTime.Start()
        DGV_WaterData.AutoGenerateColumns = False
        DGV_WaterData.DataSource = member.getdata("TB_WaterMonitoring")
    End Sub

    Sub PortSetup()

        Dim portAvailable As String() = System.IO.Ports.SerialPort.GetPortNames
        Dim portConnected As String
        For Each portConnected In portAvailable
            myPort = portConnected
        Next
        Try
            With SerialPort1
                .PortName = myPort
                .BaudRate = 9600
                .Parity = IO.Ports.Parity.None
                .DataBits = 8
                .StopBits = IO.Ports.StopBits.One
                .Handshake = IO.Ports.Handshake.None
                .RtsEnable = True
                .ReceivedBytesThreshold = 1
                .NewLine = vbCr
                .ReadTimeout = 1000
                .Open()
            End With

            If SerialPort1.IsOpen Then
                Me.Text = "Device Connected on: " & myPort
            End If
        Catch ex As Exception
            Me.Text = "No Device Found"
            MsgBox(ex.ToString)
        End Try

    End Sub

    Sub Monitoring()
        readData = SerialPort1.ReadExisting()

        If readData <> "" Then
            If readData.Chars(0) = "X" Then
                splitString(readData)
            End If
        End If

    End Sub

    Sub splitString(ByVal dataSplit As String)
        strArr = dataSplit.Split(";")

        Try
            tempFahrenheit = Decimal.Parse(strArr(1))
            turbVal = Integer.Parse(strArr(2))
            phValue = Decimal.Parse(strArr(3))
            With member

                .clearItems()
                .setColumn("temp_read")
                .setColumn("phlev_read")
                .setColumn("turb_read")
                .setColumn("temp_desc")
                .setColumn("phlev_desc")
                .setColumn("turb_desc")
                .setColumn("date_read")
                .setColumn("is_clean")

                .setValues(tempFahrenheit)
                .setValues(phValue)
                .setValues(turbVal)
                .setValues(getTempDesc(tempFahrenheit))
                .setValues(getPHvalDesc(phValue))
                .setValues(getTurbDsc(turbVal))
                .setValues(dateTimeVal)
                If phValue < 7 And turbVal > 50 Then
                    .setValues(0)
                Else
                    .setValues(1)
                End If

                .AddRecord("TB_WaterMonitoring")

            End With

            DGV_WaterData.DataSource = member.getdata("TB_WaterMonitoring")

        Catch ex As Exception
            Console.WriteLine(ex)
        End Try

    End Sub

    Function getTempDesc(ByVal tempVal As Decimal) As String

        Dim tempValDesc As String = ""

        If tempVal <= 78 Then
            tempValDesc = "LOW"
        ElseIf tempVal >= 78 And tempVal <= 89 Then
            tempValDesc = "NORMAL"
        ElseIf tempVal >= 90 Then
            tempValDesc = "HIGH"
        End If

        Return tempValDesc
    End Function

    Function getTurbDsc(ByVal turbVal As Integer) As String

        Dim turbValDesc As String = ""

        If turbVal < 20 Then
            turbValDesc = "CLEAR"
        ElseIf turbVal > 20 And turbVal < 50 Then
            turbValDesc = "CLOUDY"
        ElseIf turbVal > 50 Then
            turbValDesc = "DIRTY"
        End If

        Return turbValDesc
    End Function

    Function getPHvalDesc(ByVal phLevVal As Decimal) As String

        Dim phLevDesc As String = ""

        If phLevVal > 7 Then
            phLevDesc = "ALKALANITY"
        ElseIf phLevVal <= 7 And phLevVal >= 7.6 Then
            phLevDesc = "SAFE"
        ElseIf phLevVal <= 7.7 Then
            phLevDesc = "HIGH_ACIDITY"
        End If

        Return phLevDesc
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Monitoring()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim result As DialogResult = MessageBox.Show("Start reading data from arduino?", "CONFIRMATION", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Timer1.Start()
        End If

    End Sub

    Private Sub dateTime_Tick(sender As Object, e As EventArgs) Handles dateTime.Tick
        ' txtDateTime.Text = Date.Now.ToString("MMMM dd,yyyy ") & Date.Now.ToString("HH:mm:ss")
        dateTimeVal = Date.Now.ToString("MMMM dd,yyyy HH:mm:ss")
        txtDateTime.Text = dateTimeVal
    End Sub
End Class
