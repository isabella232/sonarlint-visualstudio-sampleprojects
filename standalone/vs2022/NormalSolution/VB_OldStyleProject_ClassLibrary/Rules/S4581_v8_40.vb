Public Class S4581_v8_40

    Public Sub Foo()
        Dim G1 As New Guid        ' Noncompliant - what's the intent?
        Dim G2 As Guid = Nothing  ' Noncompliant
    End Sub

    Public Sub Foo(Bytes As Byte())
        Dim G1 As Guid = Guid.Empty
        Dim G2 As Guid = Guid.NewGuid()
        Dim G3 As Guid = New Guid(Bytes)
    End Sub

End Class
