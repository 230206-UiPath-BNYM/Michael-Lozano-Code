Imports System

Module Program
    Sub Main(args As String())
        dim fruitsArray() as String = {"apple","orange","pear"}
        Console.WriteLine(fruitsArray(1))
        dim carList as New List(of String)
        carList.add("Honda")
        carList.add("Mercedes-Benz")
        Console.WriteLine(carList(1))
        dim gradeDict as New dictionary(of String, Integer)
        gradeDict.add("Marielle",100)
        gradeDict.add("Halbert", 86)
        For Each entry As KeyValuePair(of String, Integer) in gradeDict
            Console.WriteLine(entry.Key & " earned a " & entry.Value)
        Next
    End Sub
End Module
