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
            Console.WriteLine("Enter the size of multiplication table desired" & vbLf & "(Enter a whole number or press 'Q' to quit)")
            userInput = Console.ReadLine()
            Console.WriteLine()
            Try
                tableSize = CInt(userInput)
                'Limits tableSize to Max of 12x12 and a Min of 1x1
                If tableSize > 12 Then
                    Console.WriteLine("I'm sorry that is too big to calculate right now. Try a 12x12 table." & vbLf)
                ElseIf tableSize < 1 Then
                    Console.WriteLine("I'm sorry that is too small!  Try at least a 1x1 table." & vbLf)
                Else
                    CreateTable(tableSize)
                    Console.WriteLine()
                End If
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

    Sub CreateTable(tableSize As Integer)
        Console.WriteLine(tableSize & vbLf)
        Dim multiplicationTable((tableSize - 1), (tableSize - 1)) As Integer
        Dim currentValue As String

        'Populate multiplicationTable() array
        For row = multiplicationTable.GetLowerBound(0) To multiplicationTable.GetUpperBound(0)
            For column = multiplicationTable.GetLowerBound(1) To multiplicationTable.GetUpperBound(1)
                multiplicationTable(row, column) = (column + 1) * (row + 1)
            Next
        Next
        'Write array contents to the console
        'duplicate tableSize * 6 for each pad space and the two character of " |"
        Console.WriteLine(StrDup((tableSize * 6), "-"))
        For row = multiplicationTable.GetLowerBound(0) To multiplicationTable.GetUpperBound(0)
            Console.Write("|")
            For column = multiplicationTable.GetLowerBound(1) To multiplicationTable.GetUpperBound(1)
                currentValue = CStr(multiplicationTable(row, column))
                Console.Write(currentValue.PadLeft(4) & " |")
            Next
            Console.WriteLine()
        Next
        'duplicate tableSize * 6 for each pad space and the two character of " |"
        Console.WriteLine(StrDup((tableSize * 6), "-"))

    End Sub


End Module
