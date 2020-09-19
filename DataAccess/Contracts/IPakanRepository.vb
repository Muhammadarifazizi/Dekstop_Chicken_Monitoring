Public Interface IPakanRepository
    Inherits IGenericRepository(Of Pakan)

    'other methode
    Function getByKandangId() As IEnumerable(Of Pakan)

End Interface
