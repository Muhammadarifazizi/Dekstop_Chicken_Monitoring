Public Interface IEmployeRepository
    Inherits IGenericRepository(Of Periode)
    'Other Methode
    Function GetByKandangId() As IEnumerable(Of Periode)

End Interface
