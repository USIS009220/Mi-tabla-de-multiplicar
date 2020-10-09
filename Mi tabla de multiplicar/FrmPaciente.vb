Public Class FrmPaciente
    Dim objConexion As New db_conexion()
    Dim dataTable As New DataTable
    Private Sub FrmPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obtenerDatos()

    End Sub

    Sub obtenerDatos()
        dataTable = objConexion.obtenerDatos().Tables("Paciente")

        mostrarDatos()
    End Sub

    Sub mostrarDatos()
        MessageBox.Show("Nombre: " + dataTable.Rows(0).ItemArray(1).ToString())
    End Sub
End Class