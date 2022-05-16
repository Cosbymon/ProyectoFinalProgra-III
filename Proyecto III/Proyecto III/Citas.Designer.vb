<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Citas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Citas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.CalendarioCitas = New System.Windows.Forms.DateTimePicker()
        Me.regresar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBuscadorCitas = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NombreCitas = New System.Windows.Forms.TextBox()
        Me.TelefonoCitas = New System.Windows.Forms.TextBox()
        Me.MotivoCitas = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(319, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Citas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(49, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(49, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(57, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Motivo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(49, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "No. Telefono"
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(277, 356)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(71, 57)
        Me.Button2.TabIndex = 10
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(189, 356)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(71, 57)
        Me.Button3.TabIndex = 11
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Location = New System.Drawing.Point(91, 356)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(71, 57)
        Me.Button4.TabIndex = 12
        Me.Button4.UseVisualStyleBackColor = True
        '
        'CalendarioCitas
        '
        Me.CalendarioCitas.Location = New System.Drawing.Point(205, 187)
        Me.CalendarioCitas.Name = "CalendarioCitas"
        Me.CalendarioCitas.Size = New System.Drawing.Size(235, 23)
        Me.CalendarioCitas.TabIndex = 13
        '
        'regresar
        '
        Me.regresar.BackgroundImage = CType(resources.GetObject("regresar.BackgroundImage"), System.Drawing.Image)
        Me.regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.regresar.Location = New System.Drawing.Point(365, 356)
        Me.regresar.Name = "regresar"
        Me.regresar.Size = New System.Drawing.Size(75, 57)
        Me.regresar.TabIndex = 14
        Me.regresar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(455, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(475, 394)
        Me.DataGridView1.TabIndex = 15
        '
        'TextBuscadorCitas
        '
        Me.TextBuscadorCitas.Location = New System.Drawing.Point(222, 419)
        Me.TextBuscadorCitas.Name = "TextBuscadorCitas"
        Me.TextBuscadorCitas.Size = New System.Drawing.Size(235, 23)
        Me.TextBuscadorCitas.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(148, 427)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 15)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Buscador"
        '
        'NombreCitas
        '
        Me.NombreCitas.Location = New System.Drawing.Point(205, 99)
        Me.NombreCitas.Name = "NombreCitas"
        Me.NombreCitas.Size = New System.Drawing.Size(224, 23)
        Me.NombreCitas.TabIndex = 18
        '
        'TelefonoCitas
        '
        Me.TelefonoCitas.Location = New System.Drawing.Point(205, 143)
        Me.TelefonoCitas.Name = "TelefonoCitas"
        Me.TelefonoCitas.Size = New System.Drawing.Size(224, 23)
        Me.TelefonoCitas.TabIndex = 19
        '
        'MotivoCitas
        '
        Me.MotivoCitas.Location = New System.Drawing.Point(205, 233)
        Me.MotivoCitas.Name = "MotivoCitas"
        Me.MotivoCitas.Size = New System.Drawing.Size(224, 23)
        Me.MotivoCitas.TabIndex = 20
        '
        'Citas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(957, 491)
        Me.Controls.Add(Me.MotivoCitas)
        Me.Controls.Add(Me.TelefonoCitas)
        Me.Controls.Add(Me.NombreCitas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBuscadorCitas)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.regresar)
        Me.Controls.Add(Me.CalendarioCitas)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "Citas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextNomCitas As TextBox
    Friend WithEvents TextMotCitas As TextBox
    Friend WithEvents TextTelCitas As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents CalendarioCitas As DateTimePicker
    Friend WithEvents regresar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBuscadorCitas As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents NombreCitas As TextBox
    Friend WithEvents TelefonoCitas As TextBox
    Friend WithEvents MotivoCitas As TextBox
End Class
