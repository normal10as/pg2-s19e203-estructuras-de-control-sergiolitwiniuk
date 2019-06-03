Imports System

Module Program
    Sub Main(args As String())
        Dim numero1 As Short
        Dim numero2 As Short
        Dim numero3 As Short

        Console.WriteLine("ingrese 3 numeros ")
        numero1 = Console.ReadLine()
        numero2 = Console.ReadLine()
        numero3 = Console.ReadLine()

        If numero1 < numero2 Then
            If numero1 < numero3 Then
                Console.WriteLine("el numero " & numero1 & " es menor ")
            Else
                Console.WriteLine("el numero " & numero3 & " es menor ")
            End If
        ElseIf numero2 < numero1 Then
            If numero2 < numero3 Then
                Console.WriteLine("el numero " & numero2 & " es menor ")
            Else
                Console.WriteLine("el numero " & numero3 & " es menor ")
            End If
        End If

    End Sub
End Module
