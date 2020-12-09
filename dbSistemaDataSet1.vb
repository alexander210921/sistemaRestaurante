Partial Class dbSistemaDataSet1
    Partial Public Class productoDataTable
        Private Sub productoDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.id_productoColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

        Private Sub productoDataTable_productoRowChanging(sender As Object, e As productoRowChangeEvent) Handles Me.productoRowChanging

        End Sub

    End Class
End Class

Namespace dbSistemaDataSet1TableAdapters
    Partial Public Class PagosTableAdapter
    End Class

    Partial Public Class clienteTableAdapter
    End Class

    Partial Public Class productoTableAdapter
    End Class
End Namespace
