Imports System

Module Estructuras_Control_Flujo
    Sub Main(args As String())
        Dim numero1 As Short
        Dim numero2 As Short

        Console.WriteLine("Ingrese un numero: ")
        numero1 = Console.ReadLine()
        Console.WriteLine("ingrese un numero: ")
        numero2 = Console.ReadLine()

        If numero1 > numero2 Then
            Console.WriteLine("El numero " & numero1 & " es mayor ")
        ElseIf numero1 < numero2 Then
            Console.WriteLine("El numero " & numero2 & " es mayor ")
        Else
            Console.WriteLine("Los numeros son iguales, por lo tanto ninguno es mayor ")
        End If

    End Sub
End Module
