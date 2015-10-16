Module Module1

    Sub Main()
        Console.WriteLine("請輸入數字:")
        Dim size As Integer = Val(Console.ReadLine())
        Dim i As Integer = 0
        Dim numberArray(size) As Integer

        Do
            numberArray(i) = Val(Console.ReadLine())
            i = i + 1
        Loop While (i < size)

        Console.WriteLine("Max ={0}", GetMax(numberArray))
        Console.WriteLine("Min ={0}", GetMin(numberArray))

        For j As Integer = 0 To UBound(numberArray)
            Console.Write(numberArray(j).ToString() + "")
        Next
        For b As Integer = 1 To LBound(numberArray)
            Console.Write(numberArray(b).ToString() + "")
        Next

        Console.ReadLine()
    End Sub
    Private Function GetMax(ByVal ParamArray x() As Integer) As Integer

        Dim max As Integer = x(0)

        For i As Integer = 0 To UBound(x)
            If (x(i) > max) Then
                max = x(i)
            End If
        Next

        Return max

    End Function
    Private Function GetMin(ByVal ParamArray x() As Integer) As Integer

        Dim min As Integer = x(0)

        For i As Integer = 0 To LBound(x)
            If (x(i) < min) Then
                min = x(i)
            End If
        Next

        Return min

    End Function
End Module
