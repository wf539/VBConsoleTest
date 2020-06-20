Imports System
Imports System.IO

Module Program
    Sub Main(args As String())
        Console.WriteLine()
        Console.WriteLine("Enter the file to find or 'Q' to Quit")

        Dim strInput As String = ""
        Do Until strInput = "Q"
            strInput = UCase(Console.ReadLine())
            If Not File.Exists(strInput) Then
                Console.WriteLine("File does not exist: Test failed")
            Else
                Console.WriteLine("File exists: Test passed")
            End If
            Console.WriteLine("Enter the file to find or 'Q' to Quit")
        Loop
    End Sub
End Module
