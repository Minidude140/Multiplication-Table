'Zachary Christensen
'RCET 2265
'Fall 2023
'Multiplication Table
'https://github.com/Minidude140/Multiplication-Table.git


Option Explicit On
Option Strict On

'TODO
'[~]Ask user for size of multiplication table
'[~]Try-Catch input for integer
'[~]Main loop and quit functionality
'[]Create Array at desired size
'[]Populate Array with multiplied data
'[]Write to the console the table with proper formated rows and columns
Module MultiplicationTable
    Dim exitFlag As Boolean = False
    Dim userInput As String
    Dim tableSize As Integer

    Sub Main()
        Do While exitFlag = False
            Console.WriteLine("Enter the size of multiplication table desired" & vbLf & "(PLease enter a whole number or press 'Q' to quit)")
            userInput = Console.ReadLine()
            Try
                tableSize = CInt(userInput)
                'CreateTable() should go here
                Console.WriteLine(tableSize & vbLf)
            Catch ex As Exception
                If userInput = "Q" Or userInput = "q" Then
                    'Quit if 'Q' or 'q'
                    exitFlag = True
                Else
                    'any input that doesn't convert or not q
                    Console.WriteLine("Please enter a whole number or 'Q' to quit." & vbLf)
                End If
            End Try
        Loop
    End Sub



End Module
