﻿'Zachary Christensen
'RCET 2265
'Fall 2023
'Say My Name Again
'https://github.com/Minidude140/SayMyNameAgain.git


Option Explicit On
Option Strict On

Module SayMyNameAgain

    Sub Main()
        'TODO 
        '[~]Modify so that only select users get a reply
        '[~]Identify user "Emily"
        '[~]Identify user "Joe"
        '[~]Remark on users case sensitivity 
        '[]Idenity if the user has my name
        '[]Add loop and Quit functionality

        Dim name As String

        'Console asks user for thier name
        Console.WriteLine("Hello, What is your name?")

        'console sets variable "name" to user input
        name = Console.ReadLine()

        'Determine response here
        Select Case name
            'User Emily
            Case = "Emily"
                Console.WriteLine("Why Hello, Emily." & vbLf & "Have a great day." & vbLf)

            'User Joe 
            Case = "Joe"
                Console.WriteLine("Good to see you again, Joe." & vbLf)

            'Someone didn't use Caps
            Case = "emily"
                Console.WriteLine("You should try and capitalize that E, miss Emily!" & vbLf)
            Case = "joe"
                Console.WriteLine("Come on Joe, capitalize that J!" & vbLf)

                'User Access Denied
            Case Else
                Console.WriteLine($"Sorry, no one by the name: {name} is allowed access." & vbLf)
        End Select

        'console prompts user to close program
        Console.WriteLine("Please push enter to quit program.")
        Console.Read()

    End Sub

End Module
