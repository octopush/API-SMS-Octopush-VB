Public Class configFile







    Public DOMAIN As String = "http://www.octopush-dm.com"
    Public PORT As Integer = 80
    Public PATH_SMS As String = "/api/sms"
    Public PATH_BALANCE As String = "/api/balance"
    Public SMS_TYPE_QUALITE_STANDARD As String = "xxx"
    Public SMS_TYPE_QUALITE_PRO As String = "FR"
    Public SMS_MODE_INSTANTANE As Integer = 1
    Public SMS_MODE_DIFFERE As Integer = 2
    Public SMS_REQUEST_MODE_SIMULATION As String = "simu"
    Public SMS_REQUEST_MODE_REEL As String = "real"


    Public user_login As String = "************@********"

    Public api_key As String = "****************"

    ' Public sms_text As String = "Message ˆ envoyer"
    Public sms_text As String = "test"
    Public sms_recipients() As String = {"+33612345678", "+33687654321"}


    Public recipients_first_names() As String = {"", ""}
    Public recipients_last_names() As String = {"", ""}
    Public sms_fields_1() As String = {"", ""}
    Public sms_fields_2() As String = {"", ""}
    Public sms_fields_3() As String = {"", ""}

    Public sms_type As String = SMS_TYPE_QUALITE_STANDARD
    ' Public sms_mode As Integer = SMS_MODE_INSTANTANE
    Public sms_mode As String = 1
    Public simulation_mode As String = SMS_REQUEST_MODE_SIMULATION
    Public sms_d As String = "17"
    Public sms_m As String = "12"
    Public sms_h As String = "17"
    Public sms_i As String = "8"
    Public sms_y As String = "2013"

    Public sms_sender As String = "Octopush"
    Public sms_ticket
    Public request_mode As String = SMS_REQUEST_MODE_REEL






    

   

   
   

    
   
    

End Class
