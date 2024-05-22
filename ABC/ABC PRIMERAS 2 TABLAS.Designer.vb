<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.txtDistribuidor = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtFechaVenta = New System.Windows.Forms.TextBox()
        Me.txtIdUsuarioModifica = New System.Windows.Forms.TextBox()
        Me.txtIdUsuarioCrea = New System.Windows.Forms.TextBox()
        Me.chkEstatus = New System.Windows.Forms.CheckBox()
        Me.DataGridViewVendedor = New System.Windows.Forms.DataGridView()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.Distribuidor = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewVendedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDistribuidor
        '
        Me.txtDistribuidor.Location = New System.Drawing.Point(12, 12)
        Me.txtDistribuidor.Name = "txtDistribuidor"
        Me.txtDistribuidor.Size = New System.Drawing.Size(238, 22)
        Me.txtDistribuidor.TabIndex = 0
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(12, 58)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(238, 22)
        Me.txtPrecio.TabIndex = 1
        '
        'txtFechaVenta
        '
        Me.txtFechaVenta.Location = New System.Drawing.Point(12, 110)
        Me.txtFechaVenta.Name = "txtFechaVenta"
        Me.txtFechaVenta.Size = New System.Drawing.Size(238, 22)
        Me.txtFechaVenta.TabIndex = 2
        '
        'txtIdUsuarioModifica
        '
        Me.txtIdUsuarioModifica.Location = New System.Drawing.Point(12, 163)
        Me.txtIdUsuarioModifica.Name = "txtIdUsuarioModifica"
        Me.txtIdUsuarioModifica.Size = New System.Drawing.Size(238, 22)
        Me.txtIdUsuarioModifica.TabIndex = 3
        '
        'txtIdUsuarioCrea
        '
        Me.txtIdUsuarioCrea.Location = New System.Drawing.Point(12, 214)
        Me.txtIdUsuarioCrea.Name = "txtIdUsuarioCrea"
        Me.txtIdUsuarioCrea.Size = New System.Drawing.Size(238, 22)
        Me.txtIdUsuarioCrea.TabIndex = 4
        '
        'chkEstatus
        '
        Me.chkEstatus.AutoSize = True
        Me.chkEstatus.Location = New System.Drawing.Point(22, 261)
        Me.chkEstatus.Name = "chkEstatus"
        Me.chkEstatus.Size = New System.Drawing.Size(97, 20)
        Me.chkEstatus.TabIndex = 5
        Me.chkEstatus.Text = "CheckBox1"
        Me.chkEstatus.UseVisualStyleBackColor = True
        '
        'DataGridViewVendedor
        '
        Me.DataGridViewVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewVendedor.Location = New System.Drawing.Point(125, 250)
        Me.DataGridViewVendedor.Name = "DataGridViewVendedor"
        Me.DataGridViewVendedor.RowHeadersWidth = 51
        Me.DataGridViewVendedor.RowTemplate.Height = 24
        Me.DataGridViewVendedor.Size = New System.Drawing.Size(739, 206)
        Me.DataGridViewVendedor.TabIndex = 6
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(440, 26)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(112, 54)
        Me.btnInsertar.TabIndex = 7
        Me.btnInsertar.Text = "insertar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(558, 26)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(112, 54)
        Me.btnEliminar.TabIndex = 8
        Me.btnEliminar.Text = "eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(676, 26)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(112, 54)
        Me.btnActualizar.TabIndex = 9
        Me.btnActualizar.Text = "act"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'Distribuidor
        '
        Me.Distribuidor.AutoSize = True
        Me.Distribuidor.Location = New System.Drawing.Point(269, 13)
        Me.Distribuidor.Name = "Distribuidor"
        Me.Distribuidor.Size = New System.Drawing.Size(75, 16)
        Me.Distribuidor.TabIndex = 10
        Me.Distribuidor.Text = "Distribuidor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(269, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Precio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(272, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "FechaVenta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(275, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "UsuarioModifica"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(272, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "UsuarioCrea"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 465)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Distribuidor)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnInsertar)
        Me.Controls.Add(Me.DataGridViewVendedor)
        Me.Controls.Add(Me.chkEstatus)
        Me.Controls.Add(Me.txtIdUsuarioCrea)
        Me.Controls.Add(Me.txtIdUsuarioModifica)
        Me.Controls.Add(Me.txtFechaVenta)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtDistribuidor)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridViewVendedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDistribuidor As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtFechaVenta As TextBox
    Friend WithEvents txtIdUsuarioModifica As TextBox
    Friend WithEvents txtIdUsuarioCrea As TextBox
    Friend WithEvents chkEstatus As CheckBox
    Friend WithEvents DataGridViewVendedor As DataGridView
    Friend WithEvents btnInsertar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents Distribuidor As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
