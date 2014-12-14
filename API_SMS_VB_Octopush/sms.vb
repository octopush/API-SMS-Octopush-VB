

Imports System.Text
Imports System.IO
Imports System.Net

Public Class SMS

    



    Private user_login As String
    Private api_key As String
    Private sms_text As String

    Private sms_recipients() As String

    Private recipients_first_names() As String
    Private recipients_last_names() As String
    Private sms_fields_1() As String
    Private sms_fields_2() As String
    Private sms_fields_3() As String
    Private sms_mode As String
    Private sms_type As String
    Private sms_d As String
    Private sms_m As String
    Private sms_h As String
    Private sms_i As String
    Private sms_y As String
    Private sms_sender As String
    Private request_mode As String
    Private sms_ticket As String
    Private simulation_mode
    Public Sub New()

        sms_d = Weekday(Now)
        sms_m = Month(Now)

        sms_h = Hour(Now)
        sms_i = Minute(Now)

        sms_y = Year(Now)

    End Sub


    Public Function send(DOMAIN As String, path_sms As String, PORT As Integer) As String

        Dim data As New Hashtable
        '  Try
        data.Add("user_login", user_login)
        data.Add("api_key", api_key)
        data.Add("sms_text", sms_text)
        data.Add("sms_recipients", String.Join(",", sms_recipients))
        data.Add("recipients_first_names", String.Join(",", recipients_first_names))
        data.Add("recipients_last_names", String.Join(",", recipients_last_names))
        data.Add("sms_fields_1", String.Join(",", sms_fields_1))
        data.Add("sms_fields_2", String.Join(",", sms_fields_2))
        data.Add("sms_fields_3", String.Join(",", sms_fields_3))
        data.Add("sms_mode", sms_mode)
        data.Add("sms_type", sms_type)
        data.Add("sms_sender", sms_sender)
        data.Add("request_mode", request_mode)



        data.Add("sms_d", sms_d)
        data.Add("sms_m", sms_m)
        data.Add("sms_h", sms_h)
        data.Add("sms_i", sms_i)
        data.Add("sms_y", sms_y)



        Return _httpRequest(DOMAIN, path_sms, PORT, data)

        '   Catch
        '      Console.WriteLine("Error.")
        '  End Try
    End Function
    Public Function getBalance(DOMAIN As String, path_BALANCE As String, PORT As Integer) As String


        Dim data1 As New Hashtable

        data1.Add("user_login", user_login)
        data1.Add("api_key", api_key)

        Return _httpRequest(DOMAIN, PATH_BALANCE, PORT, data1)
    End Function

    Private Function _httpRequest(DOMAIN As String, path As String, PORT As Integer, A_fields As Hashtable) As String
        Dim ssl = DOMAIN + path
        Dim my_requst As String = ""
        For Each Item In A_fields
            my_requst += Item.Key + "=" + Item.value + "&"


        Next
        my_requst = my_requst.TrimEnd(my_requst, "&")

        Dim request As System.Net.WebRequest = System.Net.WebRequest.Create(ssl)
        request.Method = "post"
        Dim postData = my_requst
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
        request.ContentType = "application/x-www-form-urlencoded"
        request.ContentLength = byteArray.Length
        Dim dataStream As Stream = request.GetRequestStream()
        dataStream.Write(byteArray, 0, byteArray.Length)
        dataStream.Close()
        Dim response As WebResponse = request.GetResponse()
        dataStream = response.GetResponseStream()
        Dim reader As New StreamReader(dataStream)
        Dim responseFromServer As String = reader.ReadToEnd()
        reader.Close()
        dataStream.Close()
        response.Close()
        Return (responseFromServer)


    End Function

    Public Sub set_user_login(user_login1 As String)

        Me.user_login = user_login1
    End Sub

    Public Sub set_api_key(api_key1 As String)

        Me.api_key = api_key1
    End Sub

    Public Sub set_sms_text(sms_text1 As String)

        Me.sms_text = sms_text1
    End Sub

    Public Sub set_sms_type(sms_type1 As String)

        Me.sms_type = sms_type1
    End Sub

    Public Sub set_sms_recipients(sms_recipients1() As String)

        Me.sms_recipients = sms_recipients1

    End Sub

    Public Sub set_recipients_first_names(first_names())

        Me.recipients_first_names = first_names
    End Sub

    Public Sub set_recipients_last_names(last_names() As String)

        Me.recipients_last_names = last_names
    End Sub

    Public Sub set_sms_fields_1(sms_fields_1_a() As String)

        Me.sms_fields_1 = sms_fields_1_a
    End Sub

    Public Sub set_sms_fields_2(sms_fields_2_a() As String)

        Me.sms_fields_2 = sms_fields_2_a
    End Sub

    Public Sub set_sms_fields_3(sms_fields_3_a() As String)

        Me.sms_fields_3 = sms_fields_3_a
    End Sub

    Public Sub set_sms_mode(sms_mode_a As String)

        Me.sms_mode = sms_mode_a
    End Sub

    Public Sub set_sms_sender(sms_sender2_a As String)

        Me.sms_sender = sms_sender2_a
    End Sub

    Public Sub set_date(y, m, d, h, i)

        Me.sms_y = y
        Me.sms_d = d
        Me.sms_m = m
        Me.sms_h = h
        Me.sms_i = i
    End Sub

    Public Sub set_simulation_mode(SIMULATION As String)

        Me.simulation_mode = SIMULATION
    End Sub

    Public Sub set_sms_ticket(sms_ticket_a)

        Me.sms_ticket = sms_ticket_a
    End Sub

    Sub set_request_mode(simulation_mode As String)
        Me.request_mode = simulation_mode
    End Sub

End Class