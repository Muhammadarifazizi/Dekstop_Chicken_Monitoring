Public Interface IGenericLog(Of Entity As Class)
    Function GetAll() As IEnumerable(Of Entity)
    Function Add(entity As Entity) As Integer
End Interface
