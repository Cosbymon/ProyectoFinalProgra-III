<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuario))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextNombre = New System.Windows.Forms.TextBox()
        Me.TextUsuario = New System.Windows.Forms.TextBox()
        Me.TextContraseña = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBuscar = New System.Windows.Forms.Button()
        Me.TexttipoUser = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBusqueda = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(299, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(61, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre Completo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(61, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Usuario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(61, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Contraseña"
        '
        'TextNombre
        '
        Me.TextNombre.Cursor = System.Windows.Forms.Cursors.SizeNESW
        Me.TextNombre.Location = New System.Drawing.Point(242, 85)
        Me.TextNombre.Name = "TextNombre"
        Me.TextNombre.Size = New System.Drawing.Size(273, 23)
        Me.TextNombre.TabIndex = 5
        '
        'TextUsuario
        '
        Me.TextUsuario.Location = New System.Drawing.Point(241, 114)
        Me.TextUsuario.Name = "TextUsuario"
        Me.TextUsuario.Size = New System.Drawing.Size(273, 23)
        Me.TextUsuario.TabIndex = 6
        '
        'TextContraseña
        '
        Me.TextContraseña.Location = New System.Drawing.Point(240, 143)
        Me.TextContraseña.Name = "TextContraseña"
        Me.TextContraseña.Size = New System.Drawing.Size(274, 23)
        Me.TextContraseña.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(66, 493)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 67)
        Me.Button1.TabIndex = 9
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btneditar
        '
        Me.btneditar.BackgroundImage = CType(resources.GetObject("btneditar.BackgroundImage"), System.Drawing.Image)
        Me.btneditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btneditar.Location = New System.Drawing.Point(580, 161)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(71, 69)
        Me.btneditar.TabIndex = 10
        Me.btneditar.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(580, 319)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 70)
        Me.Button3.TabIndex = 11
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Location = New System.Drawing.Point(361, 493)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 70)
        Me.Button4.TabIndex = 12
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Location = New System.Drawing.Point(261, 493)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 70)
        Me.Button5.TabIndex = 13
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBuscar
        '
        Me.TextBuscar.BackgroundImage = CType(resources.GetObject("TextBuscar.BackgroundImage"), System.Drawing.Image)
        Me.TextBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TextBuscar.Location = New System.Drawing.Point(165, 493)
        Me.TextBuscar.Name = "TextBuscar"
        Me.TextBuscar.Size = New System.Drawing.Size(67, 66)
        Me.TextBuscar.TabIndex = 14
        Me.TextBuscar.UseVisualStyleBackColor = True
        '
        'TexttipoUser
        '
        Me.TexttipoUser.Location = New System.Drawing.Point(239, 178)
        Me.TexttipoUser.Name = "TexttipoUser"
        Me.TexttipoUser.Size = New System.Drawing.Size(275, 23)
        Me.TexttipoUser.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(61, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 20)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Tipo de Usuario"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(61, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 20)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Buscardor"
        '
        'TextBusqueda
        '
        Me.TextBusqueda.Location = New System.Drawing.Point(239, 207)
        Me.TextBusqueda.Name = "TextBusqueda"
        Me.TextBusqueda.Size = New System.Drawing.Size(275, 23)
        Me.TextBusqueda.TabIndex = 19
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(66, 257)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(449, 222)
        Me.DataGridView1.TabIndex = 20
        '
        'Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(679, 618)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBusqueda)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TexttipoUser)
        Me.Controls.Add(Me.TextBuscar)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btneditar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextContraseña)
        Me.Controls.Add(Me.TextUsuario)
        Me.Controls.Add(Me.TextNombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Usuario"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextNombre As TextBox
    Friend WithEvents TextUsuario As TextBox
    Friend WithEvents TextContraseña As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btneditar As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBuscar As Button
    Friend WithEvents TexttipoUser As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBusqueda As TextBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
