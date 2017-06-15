Imports System
Imports System.Xml


Public Class Admin
    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs) Handles BindingSource1.CurrentChanged

    End Sub
    Public billDate As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'test the date variable
        billDate = MonthCalendar1.SelectionStart

        'first let's check if there is a file MyXML.xml into our application folder
        'if there wasn't a file something like that, then let's create a new one.



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        billDate = MonthCalendar1.SelectionStart
        Label1.Text = billDate
        IO.File.Delete("RoomieSplit2.xml")
        If IO.File.Exists("RoomieSplit2.xml") = False Then

            'declare our xmlwritersettings object
            Dim settings As New XmlWriterSettings()

            'lets tell to our xmlwritersettings that it must use indention for our xml
            settings.Indent = True

            'lets create the MyXML.xml document, the first parameter was the Path/filename of xml file
            ' the second parameter was our xml settings
            Dim XmlWrt As XmlWriter = XmlWriter.Create("RoomieSplit2.xml", settings)

            With XmlWrt

                ' Write the Xml declaration.
                .WriteStartDocument()

                ' Write a comment.
                .WriteComment("Working on the Date")

                ' Write the root element.
                .WriteStartElement("Bills")

                ' Start our first person.
                '.WriteStartElement("Person")

                ' The person nodes.

                .WriteStartElement("Bill")
                .WriteString(ComboBox1.Text)
                .WriteEndElement()

                .WriteStartElement("Amount")
                .WriteString(TextBox1.Text)
                .WriteEndElement()


                ' The end of this person.
                .WriteEndElement()

                ' Close the XmlTextWriter.
                .WriteEndDocument()
                .Close()

            End With

            Client.Show()
        End If

    End Sub
End Class
