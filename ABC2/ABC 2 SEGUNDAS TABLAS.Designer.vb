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
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.txtTransmision = New System.Windows.Forms.TextBox()
        Me.txtCuerpo = New System.Windows.Forms.TextBox()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.txtInterior = New System.Windows.Forms.TextBox()
        Me.txtKilometraje = New System.Windows.Forms.TextBox()
        Me.txtIdUsuarioCrea = New System.Windows.Forms.TextBox()
        Me.txtIdUsuarioModifica = New System.Windows.Forms.TextBox()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.chkEstatus = New System.Windows.Forms.CheckBox()
        Me.DataGridViewTipoCarro = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewTipoCarro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(12, 12)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(100, 22)
        Me.txtTipo.TabIndex = 0
        '
        'txtTransmision
        '
        Me.txtTransmision.Location = New System.Drawing.Point(12, 40)
        Me.txtTransmision.Name = "txtTransmision"
        Me.txtTransmision.Size = New System.Drawing.Size(100, 22)
        Me.txtTransmision.TabIndex = 1
        '
        'txtCuerpo
        '
        Me.txtCuerpo.Location = New System.Drawing.Point(12, 68)
        Me.txtCuerpo.Name = "txtCuerpo"
        Me.txtCuerpo.Size = New System.Drawing.Size(100, 22)
        Me.txtCuerpo.TabIndex = 2
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(12, 106)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(100, 22)
        Me.txtColor.TabIndex = 3
        '
        'txtInterior
        '
        Me.txtInterior.Location = New System.Drawing.Point(12, 145)
        Me.txtInterior.Name = "txtInterior"
        Me.txtInterior.Size = New System.Drawing.Size(100, 22)
        Me.txtInterior.TabIndex = 4
        '
        'txtKilometraje
        '
        Me.txtKilometraje.Location = New System.Drawing.Point(12, 182)
        Me.txtKilometraje.Name = "txtKilometraje"
        Me.txtKilometraje.Size = New System.Drawing.Size(100, 22)
        Me.txtKilometraje.TabIndex = 5
        '
        'txtIdUsuarioCrea
        '
        Me.txtIdUsuarioCrea.Location = New System.Drawing.Point(12, 222)
        Me.txtIdUsuarioCrea.Name = "txtIdUsuarioCrea"
        Me.txtIdUsuarioCrea.Size = New System.Drawing.Size(100, 22)
        Me.txtIdUsuarioCrea.TabIndex = 6
        '
        'txtIdUsuarioModifica
        '
        Me.txtIdUsuarioModifica.Location = New System.Drawing.Point(12, 267)
        Me.txtIdUsuarioModifica.Name = "txtIdUsuarioModifica"
        Me.txtIdUsuarioModifica.Size = New System.Drawing.Size(100, 22)
        Me.txtIdUsuarioModifica.TabIndex = 7
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(345, 12)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(97, 50)
        Me.btnInsertar.TabIndex = 8
        Me.btnInsertar.Text = "Insertar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(473, 12)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(97, 50)
        Me.btnEliminar.TabIndex = 9
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(597, 12)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(97, 50)
        Me.btnActualizar.TabIndex = 10
        Me.btnActualizar.Text = "Act"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'chkEstatus
        '
        Me.chkEstatus.AutoSize = True
        Me.chkEstatus.Location = New System.Drawing.Point(13, 318)
        Me.chkEstatus.Name = "chkEstatus"
        Me.chkEstatus.Size = New System.Drawing.Size(97, 20)
        Me.chkEstatus.TabIndex = 11
        Me.chkEstatus.Text = "CheckBox1"
        Me.chkEstatus.UseVisualStyleBackColor = True
        '
        'DataGridViewTipoCarro
        '
        Me.DataGridViewTipoCarro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTipoCarro.Location = New System.Drawing.Point(233, 135)
        Me.DataGridViewTipoCarro.Name = "DataGridViewTipoCarro"
        Me.DataGridViewTipoCarro.RowHeadersWidth = 51
        Me.DataGridViewTipoCarro.RowTemplate.Height = 24
        Me.DataGridViewTipoCarro.Size = New System.Drawing.Size(555, 303)
        Me.DataGridViewTipoCarro.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(119, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Tipo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(119, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Transmision"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(119, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Cuerpo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(119, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Color"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(119, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 16)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Interior"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(119, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 16)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Km"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(119, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 16)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "UsuarioCrea"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(119, 273)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 16)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Usuario Modifica"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridViewTipoCarro)
        Me.Controls.Add(Me.chkEstatus)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnInsertar)
        Me.Controls.Add(Me.txtIdUsuarioModifica)
        Me.Controls.Add(Me.txtIdUsuarioCrea)
        Me.Controls.Add(Me.txtKilometraje)
        Me.Controls.Add(Me.txtInterior)
        Me.Controls.Add(Me.txtColor)
        Me.Controls.Add(Me.txtCuerpo)
        Me.Controls.Add(Me.txtTransmision)
        Me.Controls.Add(Me.txtTipo)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridViewTipoCarro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTipo As TextBox
    Friend WithEvents txtTransmision As TextBox
    Friend WithEvents txtCuerpo As TextBox
    Friend WithEvents txtColor As TextBox
    Friend WithEvents txtInterior As TextBox
    Friend WithEvents txtKilometraje As TextBox
    Friend WithEvents txtIdUsuarioCrea As TextBox
    Friend WithEvents txtIdUsuarioModifica As TextBox
    Friend WithEvents btnInsertar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents chkEstatus As CheckBox
    Friend WithEvents DataGridViewTipoCarro As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
