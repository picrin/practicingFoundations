' Implement minValueRecursive using techniques from examples below

Imports System.Collections
Public Module Module1

  ' This function takes an array of integers, and the value to search for,
  ' and returns THE INDEX of the first element in the array,
  ' whose value equals the searched for. If no value is found, it returns -1.
  ' For example:
  ' let array be 1 2 4 3
  ' let index be searchFirstOccurrence(array, 4)
  ' index is equal to 2.
  ' You DO NOT need to modify this example
  Function searchFirstOccurrence(ByRef arr As ArrayList, ByVal toSearch As Integer) as Integer
    Dim i as Integer
    For i = 0 To arr.Count - 1
      If arr(i) = toSearch
        Return i
      End If
    Next
    Return -1
  End Function

  ' This function takes an array of integers and returns THE INDEX
  ' of the smallest element. For example:
  ' let array be 2 -1 1 3
  ' let minIndex be minValue(array)
  ' minIndex is equal to 1
  ' You DO NOT need to modify this example
  Function minValue(ByRef arr As ArrayList) As Integer
    Dim currentMin As Integer
    Dim currentMinValue as Integer
    currentMin = 0
    currentMinValue = arr(0)
    Dim j as Integer
    For j = 0 To arr.Count - 1
      If arr(j) < currentMinValue
        currentMinValue = arr(j)
        currentMin = j
      End If
    Next
    Return currentMin
  End Function 

  ' This function does EXACTLY the same thing as searchFirstOccurrence.
  ' Read the description of searchFirstOccurrence.
  ' You DO NOT need to modify this example
  Function searchFirstOccurrenceRecursive(ByRef arr As ArrayList, ByVal toSearch as Integer) As Integer
    Return searchFirstOccurrenceRecursiveInner(arr, toSearch, 0)
  End Function
  
  ' This is a helper function. In your solution you can use a helper function as well.
  ' You DO NOT need to modify this example
  Function searchFirstOccurrenceRecursiveInner(ByRef arr As ArrayList, ByVal toSearch as Integer, currentPosition as Integer) as Integer
    If currentPosition > arr.Count - 1
      Return -1
    End If
    If arr(currentPosition) = toSearch
      Return currentPosition
    End If
    Return searchFirstOccurrenceRecursiveInner(arr, toSearch, currentPosition + 1)
  End Function

  ' Apply the knowledge you have gained from the previous 3 examples to implement minValueRecursive.
  ' You are NOT allowed to use for loops, but you HAVE TO use recursion.
  ' You can use a helper function.
  Function minValueRecursive(ByRef arr As ArrayList) As Integer

    '
    ' Write your code here.
    '

  End Function

  ' You don't have to do anything below this point

  Function compare(ByRef arr1 as ArrayList, ByRef arr2 as ArrayList) as Boolean
    If arr1.Count <> arr2.Count 
      Console.Write("arrays have different length. arr1 ")
      Console.Write(arr1.Count)
      Console.Write(" arr 2 ")
      Console.WriteLine(arr2.Count)
      Return False
    End If
    Dim i as Integer
    For i = 0 To arr1.Count - 1
      If arr1(i) <> arr2(i)
        Console.Write("wrong value at index ")
        Console.WriteLine(i)
        Return False
      End If
    Next
    Return True
  End Function

  Delegate Function TakeArray(ByRef arr As ArrayList) As Integer

  Sub testMinValueIter(ByRef fun As TakeArray)
    Dim arr1 As ArrayList = New ArrayList(New Integer() {2, -1, 1, 3})
    Dim arr2 As ArrayList = New ArrayList(New Integer() {2, -1, 1, 3})
    Dim arr3 As ArrayList = New ArrayList(New Integer() {3, 4, 5, 2, 3}) 

    Dim errorMessage As String = "error in MinValue(Recursive). Unexpected "
    
    Dim minIndex As Integer
    minIndex = fun.Invoke(arr1)
    
    If not compare(arr1, arr2)
      Console.WriteLine(errorMessage + "array comparison.")
    End If

    If minIndex <> 1
      Console.WriteLine(errorMessage + Cstr(minIndex))
    End If
    
    minIndex = fun.Invoke(arr3)
    
    If minIndex <> 3
      Console.WriteLine(errorMessage + Cstr(minIndex))
    End If

  End Sub 

  Delegate Function TakeArrayInt(ByRef arr As ArrayList, ByVal toSearch As Integer) As Integer

  Sub testSearchFirstOccurrence(ByRef fun As TakeArrayInt)
    Dim arr1 As ArrayList = New ArrayList(New Integer() {2, -1, 2, 3})
    Dim arr2 As ArrayList = New ArrayList(New Integer() {2, -1, 2, 3})
    Dim arr3 As ArrayList = New ArrayList(New Integer() {3, 4, 5, 2, 3}) 

    Dim errorMessage As String = "error in searchFirstOccurrence(Recursive). Unexpected "
    
    Dim i As Integer
    i = fun.Invoke(arr1, 2)

    If Not compare(arr1, arr2)
      Console.WriteLine(errorMessage + "array comparison.")
    End If

    If i <> 0
      Console.WriteLine(errorMessage + Cstr(i))
    End If

    i = fun.Invoke(arr3, 2)

    If i <> 3
      Console.WriteLine(errorMessage + Cstr(i))
    End If

    i = fun.Invoke(arr3, 17)

    If i <> -1
      Console.WriteLine(errorMessage + Cstr(i))
    End If

  End Sub 

  Sub Main()
    Dim f1 as TakeArray
    f1 = AddressOf minValue
    testMinValueIter(f1)
    f1 = AddressOf minValueRecursive
    testMinValueIter(f1)
    Dim f2 As TakeArrayInt
    f2 = AddressOf searchFirstOccurrence
    testSearchFirstOccurrence(f2)
    f2 = AddressOf searchFirstOccurrenceRecursive
    testSearchFirstOccurrence(f2)
    Console.WriteLine("bye")
    Console.ReadLine()
  End Sub

End Module

