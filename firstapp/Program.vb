Imports System
Imports System.IO


Module Program

    Public num1 As Integer
    Public num2 As Integer
    Public answer As Integer


    Sub Main(args As String())
        'c++     fstream fio= fio.open("sample.txt",    ios::out | ios::in); 
        ' Dim f1 As FileStream = New FileStream("sample.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        Dim userdata As StreamWriter
        userdata = File.CreateText("test.txt")
        userdata.WriteLine("wai yan htoo 23")
        userdata.Close()
        Console.WriteLine("end file write data process")
        Console.ReadKey()
        Dim data As StreamReader = New StreamReader("test.txt")
        Dim d As String
        d = data.ReadLine()
        While (d <> Nothing)
            Console.WriteLine(d)
            d = data.ReadLine()
        End While

        ' For i = 0 To 20
        ' f1.WriteByte(CByte(i))
        ' Next i
        ' f1.Position = 0

        'For i = 0 To 20
        'Console.Write("{0} ", f1.ReadByte())
        'Next i
        'f1.Close()
        'Console.ReadKey()



        'dsfsfsfsa
        'fdsfsfsf
        'fdsfdsf
        Dim X As Int32 'declare variable as int data type'

        For X = 1 To 10 Step 1
            Console.WriteLine(X)
        Next


        Dim l As Int32
        l = 10

        Console.WriteLine("Type a number and press Enter")
        'num1 = Integer.TryParse(Console.ReadLine())'
        Console.WriteLine("Type another number to add to it and press Enter")
        num2 = Console.ReadLine()
        answer = num1 + num2
        Console.WriteLine("The answer is " & answer)
        Console.ReadLine()

        'output'
        Console.WriteLine(vbCrLf + "Hello World!")
        'input'
        Dim name = Console.ReadLine()
        'take current date from system'
        Dim currentDate = DateTime.Now
        'output                            enter name        m,d,y                 time   '
        Console.WriteLine($"{vbCrLf}Hello, {name}, on {currentDate:d} at {currentDate:t}!")
        Console.Write(vbCrLf + "Press any key to exit... ")
        Console.ReadKey(True)
    End Sub

End Module
