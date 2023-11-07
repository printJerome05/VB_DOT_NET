Imports System
Imports Person
Imports Class1
Imports Module1
Module Program

    Const pie As Double = 3.14

    Enum Colors
        red = 1
        green = 2
        blue = 3
    End Enum

    Enum State
        walk = 1
        run = 2
        sit = 3
    End Enum



    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Console.Write("Enter Name:")
        Dim fname As String = Console.ReadLine()

        Console.WriteLine("Your name is " + fname)
        Console.WriteLine("Your name is {2}", fname, "jerome", "mara")


        Dim name As String
        Dim num As Integer = 1
        Dim i As Integer

        ' Count
        For i = 0 To 10
            Console.WriteLine("Counting: {0}", i)
        Next

        ' reverse
        For i = 10 To 0
            Console.WriteLine("Reverse: {0}", i)
        Next


        ' Count input
        Dim StartNumber As Integer
        Console.WriteLine("Enter first number to Count Asceding")
        Console.Write("Starting Number: ")
        StartNumber = Console.ReadLine()
        Console.Write("End Number Count: ")
        Dim EndNumber As Integer = Console.ReadLine()

        For i = StartNumber To EndNumber
            Console.WriteLine("Counting Asc: " & i)
        Next

        For i = EndNumber To StartNumber Step -1
            Console.WriteLine("Counting Desc: " & i)
        Next





        name = "jerome"
        If name.Equals("Jerome") Then
            Console.WriteLine("Welcome Admin")
        Else
            Console.WriteLine("Welcome User")
        End If

        If num = 2 Then
            Console.WriteLine("Equals 2")
        Else
            Console.WriteLine("Error")
        End If

        Console.WriteLine(Colors.red)
        Console.WriteLine(Colors.blue)


        Dim x As Integer = 1
        Dim y As Integer = 2



        Console.WriteLine(Person.add(x, y))
        Console.WriteLine(Person.add(10, 20))


        Dim letter As Char = "B"

        Select Case letter
            Case "A"
                Console.WriteLine("Hello")
            Case "B"
                Console.WriteLine("Hello World")
            Case Else
                Console.WriteLine("Not Found")
        End Select


        Dim num1 As Integer
        Dim num2 As Integer

        Console.WriteLine("MINUS")
        Console.Write("Enter Number 1:")
        num1 = Console.ReadLine()
        Console.Write("Enter Number 2:")
        num2 = Console.ReadLine()

        Dim sum As Integer = num1 - num2

        Console.WriteLine(sum)

        Dim answer As Boolean = False
        Dim answerto As Char


        Do
            Console.WriteLine("Do you want to continue")
            Console.WriteLine("Y for Yes / N for No")
            answerto = Console.ReadLine()

            Select Case answerto
                Case "Y"
                    Console.WriteLine("Continuing the loop")
                    answer = False

                Case "N"
                    Console.WriteLine("Exiting the loop")
                    answer = True
                    Exit Select

                Case Else
                    Console.WriteLine("Wrong Input")
                    answer = False

            End Select


        Loop While (answer = False)
        Dim array As Integer
        Dim numberArray() As Integer = {1, 2, 3, 4, 5, 6}


        Console.WriteLine(numberArray(5))

        ' TO PRINT ARRRAY
        ' NEED TO DEFINE THE each 
        For Each array In numberArray
            Console.WriteLine(array)
        Next

        ' FOR LOOP
        For a = 0 To 20
            Console.WriteLine(a)
        Next

        ' FOR LOOP WITH THEN
        For x = 10 To 100 Step 10
            Console.WriteLine("1: {0}", x)
        Next

        Dim names() As String = {"Jerome", "Marco", "Mara", "Oruga"}
        Dim names1 As String

        For Each names1 In names
            Console.WriteLine(names1)

        Next

        For a = 0 To names.Length - 1
            Console.WriteLine(names(a))
        Next

        ' FUNCTION
        Multiply(10, 10)

        'SUB
        Divide(100, 10)


        ' odd and even
        For a = 0 To 100 Step 2
            Console.WriteLine("Odd: " & a)

        Next

        For a = 1 To 100 Step 2
            Console.WriteLine("Even: {0}", a)

        Next

        Dim respond As Boolean = False
        Dim number As Integer

        Do
            Dim choice As String
            number = number + 1
            Console.WriteLine("Y for continue N for Stop")
            Console.WriteLine("{0}. Select Y / N for looping", number)
            choice = Console.ReadLine()

            Select Case choice
                Case "Y"
                    Console.WriteLine("Continue Looping")
                Case "N"
                    respond = True
                Case Else
                    Console.WriteLine("Invalid Input")
            End Select
        Loop While (respond = False)


        Dim numbers12() As Integer = {1, 2, 4, 54, 56, 6, 7}
        Dim numbersarray As Integer

        For Each numbersarray In numbers12
            Console.WriteLine(numbersarray)
        Next

        For a = 0 To numbers12.Length - 1
            Console.WriteLine(numbers12(a))
        Next

        Console.WriteLine("Add 3 Function return" & Add(1, 2, 3))


        Dim numberGenerated As Integer = 12
        If numberGenerated = 2 Then
            Console.WriteLine("Not Equals")
        ElseIf numberGenerated = 1 Then
            Console.WriteLine("Number is Equals")
        Else
            Console.WriteLine("Error")
        End If

        Console.WriteLine(State.run)


#Const Fullname = "Jerome123"

#If Fullname = "Jerome" Then
        Console.WriteLine("Welcome admin")
#Else
        Console.WriteLine("Welcome User")
#End If


        Console.ReadKey()

    End Sub

    Function Multiply(ByVal x As Integer, ByVal y As Integer)
        Dim product As Integer = x * y
        Console.WriteLine("Multiply: {0}", product)

    End Function

    ' same as function
    Sub Divide(ByVal x As Integer, ByVal y As Integer)
        Dim result As Integer = x / y
        Console.WriteLine("Minus Result: {0}", result)

    End Sub

    Function Add(ByVal x As Integer, ByVal y As Integer)
        Return x + y
    End Function

    Function Add(ByVal x As Integer, ByVal y As Integer, ByVal z As Integer)
        Return x + y + z
    End Function
End Module

Module Person

    Function add(ByVal x As Integer, ByVal y As Integer)
        Return x + y
    End Function





End Module
