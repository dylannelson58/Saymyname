Option Explicit On
Option Strict On

'Dylan Nelson
'RCET0265
'Spring 2021
'Say My Name
'https://github.com/

Module Saymyname

    Sub Main()

        Dim userInput As String

        Console.WriteLine("Hello, what is your name?")

        userInput = Console.ReadLine

        Console.WriteLine("Hi, " & userInput & ". Nice to meet you!")

        Console.Read()
    End Sub

End Module
