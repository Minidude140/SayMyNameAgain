'Zachary Christensen
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
        '[~]Idenity if the user has my name
        '[~]Add loop and Quit functionality
        '[~]Add console clear when repeating program

        Dim name As String
        Dim exitFlag As Boolean = False
        Dim cont As String

        Do
            'Console asks user for thier name
            Console.WriteLine("Hello, What is your name?")

            'console sets variable "name" to user input
            name = Console.ReadLine()
            Console.WriteLine()

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

            'User has my name
                Case = "Zac", "zac", "Zachary", "zachary"
                    Console.WriteLine("Hmmm..." & vbLf & "That is my creator's name, but YOU are NOT my creator." & vbLf)

            'Super Secret Entrance 
                Case = "Jedi Master Christensen"
                    Console.WriteLine("Ahhh yes. Hello Master." & vbLf & "Welcome back." & vbLf)

                    'User Access Denied
                Case Else
                    Console.WriteLine($"Sorry, no one by the name: {name} is allowed access." & vbLf)
            End Select

            'Ask user if they want to quit or continue
            Console.WriteLine("Continue?" & vbLf & "(Press Q to quit)" & vbLf)
            cont = Console.ReadLine()

            'Idenity exit loop or not
            If cont = ("Q") Or cont = ("q") Then
                exitFlag = True
            Else
                exitFlag = False
                Console.Clear()
            End If

        Loop Until exitFlag = True

        'Final Pause before exit could remove
        Console.Read()

    End Sub

End Module
