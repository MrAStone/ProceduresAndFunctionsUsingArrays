Module Module1

    Sub Main()
        'arrays passed as parameters need to be of the same data type as the parameter
        'declared in the subroutines
        Dim stringArray As String() = {"A", "B", "C", "D"}
        printStringArray(stringArray) ' passes the stringArray as a parameter
        Dim intArray As Integer() = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
        printIntegerArray(intArray) ' passes the integerArray as a parameter
        Dim twoDStringArray As String(,) = {{"A", "B", "C"}, {"D", "E", "F"}, {"G", "H", "I"}}
        printTwoDArray(twoDStringArray) ' passes the 2D array as a parameter

    End Sub
    Sub printStringArray(arrayToPrint() As String) 'takes single array parameter of strings
        For i = 0 To arrayToPrint.Length - 1
            Console.WriteLine(arrayToPrint(i))
        Next
    End Sub
    Sub printIntegerArray(arrayToPrint() As Integer) 'takes single array parameter of integers
        For i = 0 To arrayToPrint.Length - 1
            Console.WriteLine(arrayToPrint(i))
        Next
    End Sub
    Sub printTwoDArray(arrayToPrint(,) As String) ' takes a 2D array (,) as a parameter and must be of strings
        For firstD = 0 To arrayToPrint.GetUpperBound(0)
            For SecondD = 0 To arrayToPrint.GetUpperBound(1)
                Console.Write($"{arrayToPrint(firstD, SecondD)} ") 'prints value with a space
            Next
            Console.WriteLine() ' moves onto the next line
        Next
    End Sub
End Module
