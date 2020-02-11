Module Module1
    Sub Name()
        Console.WriteLine("Name?")
        Dim name As String
        name = Console.ReadLine
        Console.WriteLine("Hello" & name)
        Console.ReadLine()
    End Sub
    Sub Main()
        Dim numberchoice As (Char, Integer)
        Console.WriteLine("Your options are:")
        Console.WriteLine("(1)Binary Search")
        Console.WriteLine("(2)Linear Search")
        Console.WriteLine("(3)Bubble Sort")
        Console.WriteLine("(4)Merge Sort")
        Console.WriteLine("(5)Hardware instructor")
        Console.WriteLine("(6)Software instructor")
        Console.WriteLine("(7)Data amount converter")
        Console.WriteLine("(8)Quit")
        numberchoice = Console.ReadLine
        If numberchoice = 1 Then
            Binary()
        ElseIf numberchoice = 2 Then
            Linear()
        ElseIf numberchoice = 3 Then
            Bubble()
        ElseIf numberchoice = 4 Then
            Merge()
        ElseIf numberchoice = 5 Then
            HI()
        ElseIf numberchoice = 6 Then
            SI()
        ElseIf numberchoice = 7 Then
            DAC()
        ElseIf numberchoice = 8 Then
            End
        Else
            ER()
        End If
        Console.ReadLine()
    End Sub
    Sub Bubble()
        Console.ReadLine()
    End Sub
    Sub Merge()
        Dim input As Integer
        Dim valid As String
        Dim inputlength As Integer
        Dim start As String
        Dim firstdivisionleft As Integer
        Dim Left(firstdivisionleft) As Integer
        valid = False
        Console.WriteLine("Enter a 8 digit number to merge sort.")
        While valid = False
            input = Console.ReadLine
            inputlength = Len(input)
            If Len(input) = Len(8) Then
                Console.WriteLine("8 valid numbers are entered.")
                valid = True
            Else
                Console.WriteLine("Please enter 8 valid numbers.")
                valid = False
            End If
        End While
        Console.WriteLine("Start Merge?")
        start = Console.ReadLine
        If start = "yes" Then
            Console.WriteLine("Beginning...")
        Else
            End
        End If
        Left(firstdivisionleft) = Left(1 And 2 And 3 And 4)
        firstdivisionleft = Left(firstdivisionleft)
        Console.WriteLine(firstdivisionleft)
        Console.ReadLine()
    End Sub
    Sub Binary()
        Console.WriteLine("Please enter space seperated values.")
        Dim input As String = Console.ReadLine
        Dim list() As Integer = input.Split(" "c).Select(Function(n) Integer.Parse(n))
        'BinarySearch(list)
    End Sub
    Sub BinarySearch() '(ByVal list() As Integer)

        'BinarySearch(newList)'
    End Sub
    Sub Linear()

    End Sub
    Sub HI()

    End Sub
    Sub SI()

    End Sub
    Sub DAC()

    End Sub
    Sub ER()
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("Please enter a valid option.")
        Return
    End Sub

End Module
