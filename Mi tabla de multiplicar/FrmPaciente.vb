Public Class FrmPaciente
    Dim objConexion As New db_conexion()
    Dim dataTable As New DataTable
    Dim Posicion As Integer
    Private Sub FrmPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Posicion = 0
        obtenerDatos()

    End Sub

    Sub obtenerDatos()
        dataTable = objConexion.obtenerDatos().Tables("Paciente")

        mostrarDatos()
    End Sub

    Sub mostrarDatos()

        txtCodigoPaciente.Text = dataTable.Rows(Posicion).ItemArray(1).ToString()
        txtNombrePaciente.Text = dataTable.Rows(Posicion).ItemArray(2).ToString()
        txtApellidoPaciente.Text = dataTable.Rows(Posicion).ItemArray(3).ToString()
        txtNacimientoPaciente.Text = dataTable.Rows(Posicion).ItemArray(4).ToString()
        txtEdadPaciente.Text = dataTable.Rows(Posicion).ItemArray(5).ToString()
        txtSexoPaciente.Text = dataTable.Rows(Posicion).ItemArray(6).ToString()
        txtDuiPaciente.Text = dataTable.Rows(Posicion).ItemArray(7).ToString()
        txtSangrePaciente.Text = dataTable.Rows(Posicion).ItemArray(8).ToString()
        txtEmailPaciente.Text = dataTable.Rows(Posicion).ItemArray(9).ToString()
        txtDireccionPaciente.Text = dataTable.Rows(Posicion).ItemArray(10).ToString()
        txtAlergicoPaciente.Text = dataTable.Rows(Posicion).ItemArray(11).ToString()
        txtExamenesPaciente.Text = dataTable.Rows(Posicion).ItemArray(12).ToString()

        lblRegistrosPaciente.Text = Posicion + 1 & "  de  " & dataTable.Rows.Count

    End Sub

    Private Sub btnPrimeroCliente_Click(sender As Object, e As EventArgs) Handles btnPrimeroCliente.Click
        Posicion = 0
        mostrarDatos()
    End Sub

    Private Sub btnSiguienteCliente_Click(sender As Object, e As EventArgs) Handles btnSiguienteCliente.Click
        If Posicion < dataTable.Rows.Count - 1 Then
            Posicion += 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro.", "Registro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnAnteriorCliente_Click(sender As Object, e As EventArgs) Handles btnAnteriorCliente.Click
        If Posicion > 0 Then
            Posicion -= 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro.", "Registro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnUltimoCliente_Click(sender As Object, e As EventArgs) Handles btnUltimoCliente.Click
        Posicion = dataTable.Rows.Count - 1
        mostrarDatos()
    End Sub

    Private Sub btnAgregarPaciente_Click(sender As Object, e As EventArgs) Handles btnAgregarPaciente.Click
        If btnAgregarPaciente.Text = "Nuevo" Then 'Nuevo
            btnAgregarPaciente.Text = "Guardar"
            btnModificarPaciente.Text = "Cancelar"

        Else

            btnAgregarPaciente.Text = "Nuevo"
            btnModificarPaciente.Text = "Modificar"
        End If
    End Sub
    Private Sub HabDescontroles(ByVal estado As Boolean)
        grbDatos.Enabled = Not estado
        grbNavegacion.Enabled = estado
        btnEliminarPaciente.Enabled = estado
        btnBuscarPaciente.Enabled = estado
    End Sub

    Private Sub btnModificarPaciente_Click(sender As Object, e As EventArgs) Handles btnModificarPaciente.Click
        If btnModificarPaciente.Text = "Modificar" Then 'Modificar
            btnAgregarPaciente.Text = "Guardar"
            btnModificarPaciente.Text = "Cancelar"

        Else

            btnAgregarPaciente.Text = "Nuevo"
            btnModificarPaciente.Text = "Modificar"
        End If
    End Sub
End Class