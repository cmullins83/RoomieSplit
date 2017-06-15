Imports System
Imports System.Xml
Public Class Client
    Public Bills As String
    Private Sub Client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'check if file RoomieSplit2.xml is existant
        If (IO.File.Exists("RoomieSplit2.xml")) Then

            'create a new xmltextreader object
            'this is the object that we will loop and will be used to read the xml file
            Dim document As XmlReader = New XmlTextReader("RoomieSplit2.xml")

            'loop through the xml file
            While (document.Read())

                Dim type = document.NodeType



                'if node type was element
                If (type = XmlNodeType.Element) Then

                    'if the loop found a Bill tag
                    If (document.Name = Bills) Then

                        Label1.Text = "Bills"

                    End If

                    'if the loop found a Bill tag
                    If (document.Name = "Bill") Then

                        TextBox1.Text = document.ReadInnerXml.ToString()

                    End If

                    'if the loop found a Amount tag
                    If (document.Name = "Amount") Then

                        TextBox2.Text = document.ReadInnerXml.ToString()

                    End If

                End If

            End While

        Else

            MessageBox.Show("The filename you selected was not found.")
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If (IO.File.Exists("RoomieSplit2.xml")) Then

            'create a new xmltextreader object
            'this is the object that we will loop and will be used to read the xml file
            Dim document As XmlReader = New XmlTextReader("RoomieSplit2.xml")

            'loop through the xml file
            While (document.Read())

                Dim type = document.NodeType



                'if node type was element
                If (type = XmlNodeType.Element) Then

                    'if the loop found a Bill tag
                    If (document.Name = Bills) Then

                        Label1.Text = "Bills"

                    End If

                    'if the loop found a Bill tag
                    If (document.Name = "Bill") Then

                        TextBox1.Text = document.ReadInnerXml.ToString()

                    End If

                    'if the loop found a Amount tag
                    If (document.Name = "Amount") Then

                        TextBox2.Text = document.ReadInnerXml.ToString()

                    End If
                Else
                    TextBox1.Text = ""
                    TextBox2.Text = ""


                End If

            End While

        Else

            MessageBox.Show("The filename you selected was not found.")
        End If
    End Sub
End Class