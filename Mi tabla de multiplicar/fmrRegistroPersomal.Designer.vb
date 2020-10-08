<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmrRegistroPersomal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grdDatosEmpleados = New System.Windows.Forms.GroupBox()
        Me.lblHorarioEmpleado = New System.Windows.Forms.Label()
        Me.txtHorarioEmpleado = New System.Windows.Forms.TextBox()
        Me.lblCargoEmpleado = New System.Windows.Forms.Label()
        Me.txtEmailEmpleado = New System.Windows.Forms.TextBox()
        Me.lblEmailEmpleado = New System.Windows.Forms.Label()
        Me.txtTelefonoEmpleado = New System.Windows.Forms.TextBox()
        Me.lblTelefonoEmpleado = New System.Windows.Forms.Label()
        Me.txtCargoEmpleado = New System.Windows.Forms.TextBox()
        Me.txtDireccionEmpleado = New System.Windows.Forms.TextBox()
        Me.lblDirecionEmpleado = New System.Windows.Forms.Label()
        Me.txtNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.lblNombreEmpleado = New System.Windows.Forms.Label()
        Me.txtCodigoEmpleado = New System.Windows.Forms.TextBox()
        Me.lblCodigoEmpleado = New System.Windows.Forms.Label()
        Me.grdNave = New System.Windows.Forms.GroupBox()
        Me.lblRegistroEmpleado = New System.Windows.Forms.Label()
        Me.btnSiguienteEmpleado = New System.Windows.Forms.Button()
        Me.btnUltimoEmpleado = New System.Windows.Forms.Button()
        Me.btnAnteriorEmpleado = New System.Windows.Forms.Button()
        Me.btnPrimerEmpleado = New System.Windows.Forms.Button()
        Me.grdEdicion = New System.Windows.Forms.GroupBox()
        Me.btnEliminarEmpleado = New System.Windows.Forms.Button()
        Me.btnModificarEmpleado = New System.Windows.Forms.Button()
        Me.btnAgregarEmpleado = New System.Windows.Forms.Button()
        Me.btnBuscarEmpleado = New System.Windows.Forms.Button()
        Me.grdDatosEmpleados.SuspendLayout()
        Me.grdNave.SuspendLayout()
        Me.grdEdicion.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdDatosEmpleados
        '
        Me.grdDatosEmpleados.Controls.Add(Me.lblHorarioEmpleado)
        Me.grdDatosEmpleados.Controls.Add(Me.txtHorarioEmpleado)
        Me.grdDatosEmpleados.Controls.Add(Me.lblCargoEmpleado)
        Me.grdDatosEmpleados.Controls.Add(Me.txtEmailEmpleado)
        Me.grdDatosEmpleados.Controls.Add(Me.lblEmailEmpleado)
        Me.grdDatosEmpleados.Controls.Add(Me.txtTelefonoEmpleado)
        Me.grdDatosEmpleados.Controls.Add(Me.lblTelefonoEmpleado)
        Me.grdDatosEmpleados.Controls.Add(Me.txtCargoEmpleado)
        Me.grdDatosEmpleados.Controls.Add(Me.txtDireccionEmpleado)
        Me.grdDatosEmpleados.Controls.Add(Me.lblDirecionEmpleado)
        Me.grdDatosEmpleados.Controls.Add(Me.txtNombreEmpleado)
        Me.grdDatosEmpleados.Controls.Add(Me.lblNombreEmpleado)
        Me.grdDatosEmpleados.Controls.Add(Me.txtCodigoEmpleado)
        Me.grdDatosEmpleados.Controls.Add(Me.lblCodigoEmpleado)
        Me.grdDatosEmpleados.Location = New System.Drawing.Point(12, 12)
        Me.grdDatosEmpleados.Name = "grdDatosEmpleados"
        Me.grdDatosEmpleados.Size = New System.Drawing.Size(604, 378)
        Me.grdDatosEmpleados.TabIndex = 12
        Me.grdDatosEmpleados.TabStop = False
        Me.grdDatosEmpleados.Text = "Datos Empleados "
        '
        'lblHorarioEmpleado
        '
        Me.lblHorarioEmpleado.AutoSize = True
        Me.lblHorarioEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHorarioEmpleado.Location = New System.Drawing.Point(41, 326)
        Me.lblHorarioEmpleado.Name = "lblHorarioEmpleado"
        Me.lblHorarioEmpleado.Size = New System.Drawing.Size(73, 15)
        Me.lblHorarioEmpleado.TabIndex = 13
        Me.lblHorarioEmpleado.Text = "HORARIO:"
        '
        'txtHorarioEmpleado
        '
        Me.txtHorarioEmpleado.Location = New System.Drawing.Point(114, 325)
        Me.txtHorarioEmpleado.Multiline = True
        Me.txtHorarioEmpleado.Name = "txtHorarioEmpleado"
        Me.txtHorarioEmpleado.Size = New System.Drawing.Size(212, 31)
        Me.txtHorarioEmpleado.TabIndex = 12
        '
        'lblCargoEmpleado
        '
        Me.lblCargoEmpleado.AutoSize = True
        Me.lblCargoEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCargoEmpleado.Location = New System.Drawing.Point(56, 290)
        Me.lblCargoEmpleado.Name = "lblCargoEmpleado"
        Me.lblCargoEmpleado.Size = New System.Drawing.Size(58, 15)
        Me.lblCargoEmpleado.TabIndex = 11
        Me.lblCargoEmpleado.Text = "CARGO:"
        '
        'txtEmailEmpleado
        '
        Me.txtEmailEmpleado.Location = New System.Drawing.Point(114, 248)
        Me.txtEmailEmpleado.Name = "txtEmailEmpleado"
        Me.txtEmailEmpleado.Size = New System.Drawing.Size(254, 20)
        Me.txtEmailEmpleado.TabIndex = 10
        '
        'lblEmailEmpleado
        '
        Me.lblEmailEmpleado.AutoSize = True
        Me.lblEmailEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailEmpleado.Location = New System.Drawing.Point(56, 248)
        Me.lblEmailEmpleado.Name = "lblEmailEmpleado"
        Me.lblEmailEmpleado.Size = New System.Drawing.Size(52, 15)
        Me.lblEmailEmpleado.TabIndex = 9
        Me.lblEmailEmpleado.Text = "EMAIL:"
        '
        'txtTelefonoEmpleado
        '
        Me.txtTelefonoEmpleado.Location = New System.Drawing.Point(114, 212)
        Me.txtTelefonoEmpleado.Name = "txtTelefonoEmpleado"
        Me.txtTelefonoEmpleado.Size = New System.Drawing.Size(143, 20)
        Me.txtTelefonoEmpleado.TabIndex = 8
        '
        'lblTelefonoEmpleado
        '
        Me.lblTelefonoEmpleado.AutoSize = True
        Me.lblTelefonoEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoEmpleado.Location = New System.Drawing.Point(25, 212)
        Me.lblTelefonoEmpleado.Name = "lblTelefonoEmpleado"
        Me.lblTelefonoEmpleado.Size = New System.Drawing.Size(83, 15)
        Me.lblTelefonoEmpleado.TabIndex = 7
        Me.lblTelefonoEmpleado.Text = "TELEFONO:"
        '
        'txtCargoEmpleado
        '
        Me.txtCargoEmpleado.Location = New System.Drawing.Point(114, 290)
        Me.txtCargoEmpleado.Name = "txtCargoEmpleado"
        Me.txtCargoEmpleado.Size = New System.Drawing.Size(212, 20)
        Me.txtCargoEmpleado.TabIndex = 6
        '
        'txtDireccionEmpleado
        '
        Me.txtDireccionEmpleado.Location = New System.Drawing.Point(114, 120)
        Me.txtDireccionEmpleado.Multiline = True
        Me.txtDireccionEmpleado.Name = "txtDireccionEmpleado"
        Me.txtDireccionEmpleado.Size = New System.Drawing.Size(287, 81)
        Me.txtDireccionEmpleado.TabIndex = 5
        '
        'lblDirecionEmpleado
        '
        Me.lblDirecionEmpleado.AutoSize = True
        Me.lblDirecionEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirecionEmpleado.Location = New System.Drawing.Point(22, 121)
        Me.lblDirecionEmpleado.Name = "lblDirecionEmpleado"
        Me.lblDirecionEmpleado.Size = New System.Drawing.Size(86, 15)
        Me.lblDirecionEmpleado.TabIndex = 4
        Me.lblDirecionEmpleado.Text = "DIRECCION:"
        '
        'txtNombreEmpleado
        '
        Me.txtNombreEmpleado.Location = New System.Drawing.Point(114, 75)
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        Me.txtNombreEmpleado.Size = New System.Drawing.Size(338, 20)
        Me.txtNombreEmpleado.TabIndex = 3
        '
        'lblNombreEmpleado
        '
        Me.lblNombreEmpleado.AutoSize = True
        Me.lblNombreEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreEmpleado.Location = New System.Drawing.Point(37, 75)
        Me.lblNombreEmpleado.Name = "lblNombreEmpleado"
        Me.lblNombreEmpleado.Size = New System.Drawing.Size(71, 15)
        Me.lblNombreEmpleado.TabIndex = 2
        Me.lblNombreEmpleado.Text = "NOMBRE:"
        '
        'txtCodigoEmpleado
        '
        Me.txtCodigoEmpleado.Location = New System.Drawing.Point(114, 32)
        Me.txtCodigoEmpleado.Name = "txtCodigoEmpleado"
        Me.txtCodigoEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigoEmpleado.TabIndex = 1
        '
        'lblCodigoEmpleado
        '
        Me.lblCodigoEmpleado.AutoSize = True
        Me.lblCodigoEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoEmpleado.Location = New System.Drawing.Point(37, 32)
        Me.lblCodigoEmpleado.Name = "lblCodigoEmpleado"
        Me.lblCodigoEmpleado.Size = New System.Drawing.Size(64, 15)
        Me.lblCodigoEmpleado.TabIndex = 0
        Me.lblCodigoEmpleado.Text = "CODIGO:"
        '
        'grdNave
        '
        Me.grdNave.Controls.Add(Me.lblRegistroEmpleado)
        Me.grdNave.Controls.Add(Me.btnSiguienteEmpleado)
        Me.grdNave.Controls.Add(Me.btnUltimoEmpleado)
        Me.grdNave.Controls.Add(Me.btnAnteriorEmpleado)
        Me.grdNave.Controls.Add(Me.btnPrimerEmpleado)
        Me.grdNave.Location = New System.Drawing.Point(12, 396)
        Me.grdNave.Name = "grdNave"
        Me.grdNave.Size = New System.Drawing.Size(340, 104)
        Me.grdNave.TabIndex = 13
        Me.grdNave.TabStop = False
        Me.grdNave.Text = "Navegar "
        '
        'lblRegistroEmpleado
        '
        Me.lblRegistroEmpleado.AutoSize = True
        Me.lblRegistroEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistroEmpleado.Location = New System.Drawing.Point(148, 44)
        Me.lblRegistroEmpleado.Name = "lblRegistroEmpleado"
        Me.lblRegistroEmpleado.Size = New System.Drawing.Size(48, 18)
        Me.lblRegistroEmpleado.TabIndex = 4
        Me.lblRegistroEmpleado.Text = "1 de n"
        '
        'btnSiguienteEmpleado
        '
        Me.btnSiguienteEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguienteEmpleado.Location = New System.Drawing.Point(239, 36)
        Me.btnSiguienteEmpleado.Name = "btnSiguienteEmpleado"
        Me.btnSiguienteEmpleado.Size = New System.Drawing.Size(48, 34)
        Me.btnSiguienteEmpleado.TabIndex = 3
        Me.btnSiguienteEmpleado.Text = ">"
        Me.btnSiguienteEmpleado.UseVisualStyleBackColor = True
        '
        'btnUltimoEmpleado
        '
        Me.btnUltimoEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimoEmpleado.Location = New System.Drawing.Point(286, 36)
        Me.btnUltimoEmpleado.Name = "btnUltimoEmpleado"
        Me.btnUltimoEmpleado.Size = New System.Drawing.Size(48, 34)
        Me.btnUltimoEmpleado.TabIndex = 2
        Me.btnUltimoEmpleado.Text = ">|"
        Me.btnUltimoEmpleado.UseVisualStyleBackColor = True
        '
        'btnAnteriorEmpleado
        '
        Me.btnAnteriorEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorEmpleado.Location = New System.Drawing.Point(53, 36)
        Me.btnAnteriorEmpleado.Name = "btnAnteriorEmpleado"
        Me.btnAnteriorEmpleado.Size = New System.Drawing.Size(48, 34)
        Me.btnAnteriorEmpleado.TabIndex = 1
        Me.btnAnteriorEmpleado.Text = "<"
        Me.btnAnteriorEmpleado.UseVisualStyleBackColor = True
        '
        'btnPrimerEmpleado
        '
        Me.btnPrimerEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimerEmpleado.Location = New System.Drawing.Point(6, 36)
        Me.btnPrimerEmpleado.Name = "btnPrimerEmpleado"
        Me.btnPrimerEmpleado.Size = New System.Drawing.Size(48, 34)
        Me.btnPrimerEmpleado.TabIndex = 0
        Me.btnPrimerEmpleado.Text = "|<"
        Me.btnPrimerEmpleado.UseVisualStyleBackColor = True
        '
        'grdEdicion
        '
        Me.grdEdicion.Controls.Add(Me.btnBuscarEmpleado)
        Me.grdEdicion.Controls.Add(Me.btnEliminarEmpleado)
        Me.grdEdicion.Controls.Add(Me.btnModificarEmpleado)
        Me.grdEdicion.Controls.Add(Me.btnAgregarEmpleado)
        Me.grdEdicion.Location = New System.Drawing.Point(358, 396)
        Me.grdEdicion.Name = "grdEdicion"
        Me.grdEdicion.Size = New System.Drawing.Size(258, 113)
        Me.grdEdicion.TabIndex = 14
        Me.grdEdicion.TabStop = False
        Me.grdEdicion.Text = "Editar "
        '
        'btnEliminarEmpleado
        '
        Me.btnEliminarEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarEmpleado.Location = New System.Drawing.Point(130, 36)
        Me.btnEliminarEmpleado.Name = "btnEliminarEmpleado"
        Me.btnEliminarEmpleado.Size = New System.Drawing.Size(70, 34)
        Me.btnEliminarEmpleado.TabIndex = 6
        Me.btnEliminarEmpleado.Text = "Eliminar"
        Me.btnEliminarEmpleado.UseVisualStyleBackColor = True
        '
        'btnModificarEmpleado
        '
        Me.btnModificarEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarEmpleado.Location = New System.Drawing.Point(56, 36)
        Me.btnModificarEmpleado.Name = "btnModificarEmpleado"
        Me.btnModificarEmpleado.Size = New System.Drawing.Size(77, 34)
        Me.btnModificarEmpleado.TabIndex = 5
        Me.btnModificarEmpleado.Text = "Modificar "
        Me.btnModificarEmpleado.UseVisualStyleBackColor = True
        '
        'btnAgregarEmpleado
        '
        Me.btnAgregarEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarEmpleado.Location = New System.Drawing.Point(6, 36)
        Me.btnAgregarEmpleado.Name = "btnAgregarEmpleado"
        Me.btnAgregarEmpleado.Size = New System.Drawing.Size(56, 34)
        Me.btnAgregarEmpleado.TabIndex = 4
        Me.btnAgregarEmpleado.Text = "Nuevo "
        Me.btnAgregarEmpleado.UseVisualStyleBackColor = True
        '
        'btnBuscarEmpleado
        '
        Me.btnBuscarEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarEmpleado.Location = New System.Drawing.Point(195, 36)
        Me.btnBuscarEmpleado.Name = "btnBuscarEmpleado"
        Me.btnBuscarEmpleado.Size = New System.Drawing.Size(63, 34)
        Me.btnBuscarEmpleado.TabIndex = 7
        Me.btnBuscarEmpleado.Text = "Buscar  "
        Me.btnBuscarEmpleado.UseVisualStyleBackColor = True
        '
        'fmrRegistroPersomal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 513)
        Me.Controls.Add(Me.grdEdicion)
        Me.Controls.Add(Me.grdNave)
        Me.Controls.Add(Me.grdDatosEmpleados)
        Me.Name = "fmrRegistroPersomal"
        Me.Text = "Registro de Personal "
        Me.grdDatosEmpleados.ResumeLayout(False)
        Me.grdDatosEmpleados.PerformLayout()
        Me.grdNave.ResumeLayout(False)
        Me.grdNave.PerformLayout()
        Me.grdEdicion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdDatosEmpleados As GroupBox
    Friend WithEvents txtCodigoEmpleado As TextBox
    Friend WithEvents lblCodigoEmpleado As Label
    Friend WithEvents grdNave As GroupBox
    Friend WithEvents grdEdicion As GroupBox
    Friend WithEvents txtNombreEmpleado As TextBox
    Friend WithEvents lblNombreEmpleado As Label
    Friend WithEvents txtDireccionEmpleado As TextBox
    Friend WithEvents lblDirecionEmpleado As Label
    Friend WithEvents txtTelefonoEmpleado As TextBox
    Friend WithEvents lblTelefonoEmpleado As Label
    Friend WithEvents txtCargoEmpleado As TextBox
    Friend WithEvents txtEmailEmpleado As TextBox
    Friend WithEvents lblEmailEmpleado As Label
    Friend WithEvents lblCargoEmpleado As Label
    Friend WithEvents lblHorarioEmpleado As Label
    Friend WithEvents txtHorarioEmpleado As TextBox
    Friend WithEvents btnPrimerEmpleado As Button
    Friend WithEvents btnAnteriorEmpleado As Button
    Friend WithEvents btnSiguienteEmpleado As Button
    Friend WithEvents btnUltimoEmpleado As Button
    Friend WithEvents lblRegistroEmpleado As Label
    Friend WithEvents btnAgregarEmpleado As Button
    Friend WithEvents btnEliminarEmpleado As Button
    Friend WithEvents btnModificarEmpleado As Button
    Friend WithEvents btnBuscarEmpleado As Button
End Class
