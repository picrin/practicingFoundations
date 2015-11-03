Imports System
Imports System.Collections


'
' You will have to write test cases on your own. You should write the test case before attempting the solution
' 
Public Module PractisingFoundations

  ' This subroutine takes two arrays: elements1 and elements2, as well as a valid elements1 index, and a valid elements2 index (valid means within bounds). Your task is to swap the two values pointed to by the indices, so that for example, if we start with the following cases:
  ' e1 is initially (1, 8, 2, 1)
  ' e2 is initially (9, 3, 4)
  ' i1 is initially 1
  ' i2 is initially 0
  ' swap(e1, e2, i1, i2)
  ' e1 is now (1, 9, 2, 1)
  ' e2 is now (8, 3, 4)
  ' i1 does not change
  ' i2 does not change
  Sub swap2(ByRef elements1 as ArrayList, ByRef elements2 as ArrayList, ByVal elements1Index as Integer, ByVal elements2Index as Integer)
    '
    ' your code goes here. If you can't solve for about 1 hour, raise an issue at https://github.com/picrin/practicingFoundations
    '
  end Sub

  ' This subroutine takes an array of elements. Swap element of the index 0 with an element of the last index.
  ' For example
  ' anArray is initially (8, 2, 4)
  ' swapFirstLast(anArray)
  ' anArray is now (4, 2, 8)
  Sub swapFirstLast(ByRef anArray)
    '
    ' your code goes here. If you can't solve for about 1 hour, raise an issue at https://github.com/picrin/practicingFoundations
    '
  end Sub 

  ' This subroutine takes 2 arrays: a1 and a2. You should swap elements of a1 with elements of a2 for all even indices 0, 2, 4, 6, ...
  ' Be careful to not exceed the size of either of the arrays!
  ' Example:
  ' a1 is initially (0, 4, 8, 3, 7)
  ' a2 is initially (8, 9, 11, 4, 13, 27, 30).
  ' swapAllEven(a1, a2)
  ' a1 is now (8, 4, 11, 3, 13)
  ' a2 is now (0, 9, 8, 4, 7, 27, 30)
  Sub swapAllEven(ByRef a1 as ArrayList, ByRef a2 as ArrayList)

  end Sub

  ' This subroutine takes an array of elements. Put element of index 1 in place of element of index 0, element of index 2 in place of element of index 1 and so on. Put element of index 0 in place of element of the last index. For example:
  ' anArray is initially (4, 8, 9, 3)
  ' rotate(anArray)
  ' anArray is now (8, 9, 3, 4)
  Sub rotateLeft (ByRef anArray as ArrayList)
    '
    ' your code goes here. If you can't solve for about 1 hour, raise an issue at https://github.com/picrin/practicingFoundations
    '
  end Sub

  ' Implement an algorithm similar to bubble sort (don't assume it's a sorting algorithm, it may be, or it may be not!, for all you know it's an algorithm), but where check-and-swap indices are not (0, 1), (1, 2), (2, 3), (3, 4), ..., but are actually (0, 2), (1, 3), (2, 4), ...
  ' This is an example execution of the algorithm. If an index is replaced with X, the swap will happen, if it replaced with -, the swap won't happen:
  '
  ' -- pass 1 --  | -- pass 2 --  | -- pass 3 --  | -- pass 4 -- 
  '               |               |               |
  ' X  1  X  3  4 | X  1  X  3  4 | -  1  -  3  4 | -  1  -  3  4 
  ' 7  8  4  2  1 | 4  2  1  8  7 | 1  2  4  8  7 | 1  2  4  8  7
  '               |               |               |
  ' 0  X  2  X  4 | 0  -  2  -  4 | 0  -  2  -  4 | 0  -  2  -  4 
  ' 4  8  7  2  1 | 1  2  4  8  7 | 1  2  4  8  7 | 1  2  4  8  7
  '               |               |               |
  ' 0  1  X  3  X | 0  1  -  3  - | 0  1  -  3  - | 0  1  -  3  - 
  ' 4  2  7  8  1 | 1  2  4  8  7 | 1  2  4  8  7 | 1  2  4  8  7
  '
  ' is bigStepBubbling a sorting algorithm? If not, how can it be turned into a sorting algorithm? If yes, what's your evidence?
  Sub bigStepBubbling (ByRef anArray as ArrayList)
    '
    ' your code goes here. If you can't solve for about 1 hour, raise an issue at https://github.com/picrin/practicingFoundations
    '
  end Sub

  ' Implement a single pass of bubble sort, but from right to left, and only between leftIndex and rightIndex. For example (minus - means check & no swap, cross X means check & swap)
  ' anArray is initially (4, 8, 7, 3, 10)
  ' leftIndex is initially 1
  ' rightIndex is initially 4
  ' bubblingDown(anArray, leftIndex, rightIndex)
  ' -- pass 1 -- 
  '
  ' 0  1  2  -  -
  ' 4  8  7  3  10
  ' 
  ' 0  1  X  X  4
  ' 4  8  7  3  10
  '
  ' 0  X  X  3  4
  ' 4  8  3  7  10
  ' 
  ' 0  1  2  3  4
  ' 4  3  8  7  10
  '
  ' anArray is now (4, 3, 8, 7, 10)
  ' leftIndex remains unchanged
  ' rightIndex remains unchanged
  Sub bubblingDown (ByRef anArray as ArrayList, ByVal leftIndex as Integer, ByVal rightIndex as Integer)
    '
    ' your code goes here. If you can't solve for about 1 hour, raise an issue at https://github.com/picrin/practicingFoundations
    '
  end Sub

  ' This function is a building block for InsertionSort. parameter anArray is ALREADY SORTED between fromIndex and (toIndex - 1). HOWEVER, toIndex is possibly out of place. Find the correct index to keep this element at, and return it.
  ' Example:
  ' newPosition is initially empty
  ' anArray is initially (0, 3, 4, 2, 5)
  ' newPosition = findCorrectPosition(anArray, 0, 3)
  ' We notice that the correct position for element at index 3, which has a value of 2, is index 1
  ' newPosition is now 1.
  Function findCorrectPosition (ByRef anArray as ArrayList, ByVal fromIndex as Integer, ByVal toIndex as Integer) as Integer
    '
    ' your code goes here. If you can't solve for about 1 hour, raise an issue at https://github.com/picrin/practicingFoundations
    '
  end Function
  
  ' This subroutine starts fromIndex and moves everything one up. The value at fromIndex moves to fromIndex. Example:
  ' a1 is initally (0, 3, 4, 8, 5)
  ' left is 2, right is 4
  ' rotateRight(a1, left, right)
  ' a1 is now (0, 3, 5, 4, 8)
  Sub rotateRight (ByRef anArray as ArrayList, ByVal fromIndex as Integer, ByVal toIndex as Integer)
    '
    ' your code goes here. If you can't solve for about 1 hour, raise an issue at https://github.com/picrin/practicingFoundations
    '
  end Sub


  ' Combine rotateRight with findCorrectPosition to implement insertionSort
  Sub insertionSort (ByRef anArray as ArrayList)
    '
    ' your code goes here. If you can't solve for about 1 hour, raise an issue at https://github.com/picrin/practicingFoundations
    '
  end Sub

  ' Implemented a sorting algorithm of your own design. As building blocks you can use shifting, rotating, big-step bubbling, bubblingDown, whatever comes to your mind. If you come up with some building blocks outside of the ones which you've already implemented implement them as separate functions/ subroutines. Try to make your sort as different as you can imagine from any sorting algorithm already in existance. 
  Sub putYourNameHereSort (ByRef anArray as ArrayList)
    '
    ' your code goes here. If you can't solve for about 1 hour, raise an issue at https://github.com/picrin/practicingFoundations
    '
  end Sub

  Sub arrayAssertionError(ByVal testedFunctionName as String, ByRef actual as ArrayList, expected as Integer())
     Console.Write("Error in the implementation of the ")
     Console.Write(testedFunctionName)
     Console.Write(" function. Elements should be ")
     printElements(new ArrayList(expected))
     Console.Write("but are " )
     printElements(actual)
     Console.WriteLine("") 
  end Sub
  
  Sub intAssertionError(ByVal testedFunctionName as String, actual as Integer, expected as Integer)
     Console.Write("Error in the implementation of the ")
     Console.Write(testedFunctionName)
     Console.Write(" function. I expected " )
     Console.Write(expected)
     Console.Write(" but I got " )
     Console.Write(actual)
     Console.WriteLine("")
  end Sub

  Sub printElements(ByVal elems as Object )
    Dim index as Integer = 0
    Console.Write("{")
    For index = 0 To elems.Count - 2
      Console.Write(elems(index))
      Console.Write(", ")
    Next
    Console.Write(elems(elems.Count - 1))
    Console.Write("} ")
  end Sub

  Sub testSwap2SameSize()

    Dim e1 as ArrayList =  new ArrayList(new Integer() {1, 8, 2, 1})
    Dim e2 as ArrayList =  new ArrayList(new Integer() {9, 3, 4})
    swap2(e1, e2, 1, 0)
    if e1(1) <> 9
        intAssertionError("swap2", 9, e1(1))
    end if
    if e2(0) <> 8
        intAssertionError("swap2", 8, e2(0))
    end if
 
  end Sub

  Sub testSwap2DifferentSize()
    Console.WriteLine("implement the test case testSwap2DifferentSize()")
  end Sub


  Sub Main()
    testSwap2SameSize()
    testSwap2DifferentSize()
    Console.ReadLine()
  end Sub

end Module
