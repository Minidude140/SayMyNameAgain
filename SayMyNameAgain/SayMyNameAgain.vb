'Zachary Christensen
'RCET 2265
'Fall 2023
'Say My Name Again
'https://github.com/Minidude140/SayMyNameAgain.git


Option Explicit On
Option Strict On

Module SayMyNameAgain

    Sub Main()

        Dim name As String

        'Console asks user for thier name
        Console.WriteLine("Hello, What is your name?")

        'console sets variable "name" to user input and returns a promt
        name = Console.ReadLine()
        Console.WriteLine($"Hello, {name}.")

        'console prompts user to close program
        Console.WriteLine("Please push enter to quit program.")
        Console.Read()

    End Sub

End Module
