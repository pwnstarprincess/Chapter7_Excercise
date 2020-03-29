'Jennifer Pezzulo
'March 28, 2020
'Module 3 Assignment 2 Chapter 7 Exercise Problem 5 (Textese Translation)

Imports Microsoft.VisualBasic.FileIO
Imports System.Text.RegularExpressions
Public Class Form1

    'Sub routine for handling buton click
    'I do like the idea of just having the text translation handled when EnglishBox.TextChanged insetad
    'but the program assignment parameters call for a button click
    Private Sub TranslateButton_Click(sender As Object, e As EventArgs) Handles TranslateButton.Click

        'If English sentence has input data
        If Not String.IsNullOrEmpty(EnglishBox.Text) Then

            'create dictionary to hold the text file values.  Ignore the case
            Dim dictionaryValue As New Dictionary(Of String, String)(System.StringComparer.OrdinalIgnoreCase)

            'Read in comma delimited defintion file.  Store the Definitions in release or debug folder
            Dim fileReader As New TextFieldParser("Textese.txt") With {
                .Delimiters = New String() {","},
                .TextFieldType = FieldType.Delimited
            }

            'Keep reading until the end of the file
            While fileReader.EndOfData = False
                Dim fields = fileReader.ReadFields()
                If Not String.IsNullOrEmpty(fields(0)) Then
                    'checking if key exists in the dictionary and adds it if it does not
                    If dictionaryValue.ContainsKey(fields(0)) Then
                        dictionaryValue(fields(0)) = fields(1)
                    Else
                        dictionaryValue.Add(fields(0), fields(1))
                    End If
                End If
            End While

            'split english input into a list of words.  Using regex to filter out punctuation
            'So that punctuation does not create a "false-translation"
            Dim words As List(Of String)
            words = Regex.Replace(EnglishBox.Text, "[!;:,.\""?]+", String.Empty).Split(" ").ToList()
            Dim translatedText As String
            translatedText = ""
            'loop through all the words
            For Each item In words
                'substitute the matching textese words if applicable
                If dictionaryValue.ContainsKey(item) Then
                    translatedText += dictionaryValue(item) + " "
                Else
                    translatedText += item + " "
                End If
            Next

            'Show the results in the textese output box
            TexteseBox.Text = translatedText
            'Show warning dialouge if no input data present
        Else
            MessageBox.Show("Please Enter Text in the English Sentence Box", "Missing Input",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.RightAlign
            )
        End If

    End Sub
End Class
