Public Class RPG_Dice
    Sub New()
        Console.Title = "RPG Dice"
        Randomize()
        RB = New List(Of String)
    End Sub
    Protected Overrides Sub Finalize()
        RB = Nothing
    End Sub

    Private RC As Integer = 1 'roll count
    Private RB As List(Of String) 'roll buffer
    Private UI As Integer 'user's input

    Public Sub ResetConsole()
        Console.Clear()
    End Sub

    Public Sub OutputRollBuffer()
        Console.Write("Roll buffer: ")

        Dim i As String
        For Each i In RB
            Console.Write(i)
        Next i

        If RB.Count = 0 Then
            Console.Write("No dice have been rolled.")
        End If


    End Sub

    Public Sub Instructions()
        Console.WriteLine()
        Console.WriteLine("Please type")
        Console.WriteLine("[a] for a d4")
        Console.WriteLine("[b] for a d6")
        Console.WriteLine("[c] for a d8")
        Console.WriteLine("[d] for a d10")
        Console.WriteLine("[e] for a d12")
        Console.WriteLine("[f] for a d20")
        Console.WriteLine("[g] to clear the roll buffer")
        Console.WriteLine("[h] to end app")
    End Sub

    Public Sub GetUserInput()
        UI = Console.ReadKey(True).Key
    End Sub

    Public Function DiceRoll() As Boolean
        Select Case UI
            Case 65 'a
                GenerateRoll(4)
            Case 66 'b
                GenerateRoll(6)
            Case 67 'c
                GenerateRoll(8)
            Case 68 'd
                GenerateRoll(10)
            Case 69 'e
                GenerateRoll(12)
            Case 70 'f
                GenerateRoll(20)
            Case 71 'g
                RC = 1
                RB.Clear()
                Console.WriteLine("Dice roll buffer is clear.")
                Threading.Thread.Sleep(1000)
            Case 72 'h
                Console.WriteLine("Thank you for using this app.")
                Threading.Thread.Sleep(1000)
                Return False
            Case Else
                Console.WriteLine("Invalid input.")
                Threading.Thread.Sleep(800)
        End Select

        Return True
    End Function

    Private Sub GenerateRoll(a As Integer)
        Dim randNumber As Integer
        Dim i As Integer
        Dim consoleRow As Integer
        For i = 0 To 9
            consoleRow = Console.CursorTop
            randNumber = CInt(Int(a * Rnd() + 1))
            Console.WriteLine(randNumber & " ")
            Console.CursorTop = consoleRow
            Threading.Thread.Sleep(100 * (i + 1))
        Next i
        RB.Add("Roll" & RC & "-d" & a & "-" & randNumber & " ")
        RC += 1
    End Sub

End Class
