Module Module1

    Sub Main()

        Dim QueueArray(9) As String
        Dim headpointer As Integer = 0
        Dim tailpointer As Integer = 0
        Dim nooofitems As Integer = 0
        Dim userinput As String

        For x = 0 To 10
            Console.WriteLine("enter a string")
            userinput = Console.ReadLine()
            If enqueue(QueueArray, headpointer, tailpointer, nooofitems, userinput) = True Then
                Console.WriteLine("successfull bruh")

            Else
                Console.WriteLine("unsuccessfullll bruh")

            End If

        Next

        Console.WriteLine(dequeue(QueueArray, headpointer, tailpointer, nooofitems))
        Console.WriteLine(dequeue(QueueArray, headpointer, tailpointer, nooofitems))


        Console.ReadLine()
    End Sub

    Function enqueue(ByRef queuearray() As String, ByRef headpointer As Integer, ByRef TailPointer As Integer, ByRef NumberItems As Integer,
            DataToAdd As String) As Boolean

        If NumberItems = 10 Then
            Return False
        End If

        queuearray(TailPointer) = DataToAdd
        If TailPointer >= 9 Then
            TailPointer = 0
        Else
            TailPointer = TailPointer + 1
        End If

        NumberItems = NumberItems + 1

        Return True

    End Function

    Function dequeue(ByRef queuearray() As String, ByRef headpointer As Integer, ByRef TailPointer As Integer, ByRef NumberItems As Integer) As String


        If NumberItems = 0 Then
            Return "false"
        Else
            Dim returnvalue = queuearray(headpointer)
            headpointer = headpointer + 1

            If headpointer >= 9 Then
                headpointer = 0

            End If

            NumberItems = NumberItems - 1

            Return returnvalue

        End If

    End Function


End Module
