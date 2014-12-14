Imports System.Xml

Module campagne

    Sub Main()

        Dim config As configFile = New configFile()
        Dim sms As SMS = New SMS()


        sms.set_sms_ticket(config.sms_ticket)
        sms.set_recipients_first_names(config.recipients_first_names)
        sms.set_recipients_last_names(config.recipients_last_names)
        sms.set_sms_fields_1(config.sms_fields_1)
        sms.set_sms_fields_2(config.sms_fields_2)
        sms.set_sms_fields_3(config.sms_fields_3)

        'sms.set_simulation_mode(config.simulation_mode)
        'sms.set_request_mode(config.SMS_REQUEST_MODE_SIMULATION)

        sms.set_user_login(config.user_login)
        sms.set_api_key(config.api_key)
        sms.set_sms_mode(config.sms_mode)
        sms.set_sms_text(config.sms_text)
        sms.set_sms_recipients(config.sms_recipients)
        sms.set_sms_type(config.sms_type)
        sms.set_sms_sender(config.sms_sender)

        If (config.sms_mode = config.SMS_MODE_DIFFERE) Then
            sms.set_date(config.sms_y, config.sms_m, config.sms_d, config.sms_h, config.sms_i)
        End If

        '  Console.WriteLine(sms.send(config.DOMAIN, config.PATH_SMS, config.PORT))
        Dim xml As String = sms.send(config.DOMAIN, config.PATH_SMS, config.PORT)


        Dim xmlDoc As New XmlDocument
        Dim productNodes As XmlNodeList
      

        xmlDoc.LoadXml(xml)

        productNodes = xmlDoc.GetElementsByTagName("octopush")
        If ((productNodes.Item(0).FirstChild.InnerText) = "000") Then
            Console.WriteLine("massage has sent!")

        Else : Console.WriteLine("massage has faild")
        End If

      


    End Sub

End Module
