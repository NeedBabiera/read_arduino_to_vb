Public Class Form1
    Dim myPort As String = ""
    Dim readData As String = ""
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PortSetup()

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

        txtData.Text = readData


    End Sub



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Monitoring()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()

    End Sub
End Class
