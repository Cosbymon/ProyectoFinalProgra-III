<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FichaNiños
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FichaNiños))
        Me.NombreCliente = New System.Windows.Forms.TextBox()
        Me.Edad = New System.Windows.Forms.TextBox()
        Me.Sexo = New System.Windows.Forms.TextBox()
        Me.Encargado = New System.Windows.Forms.TextBox()
        Me.DPI = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Direccion = New System.Windows.Forms.TextBox()
        Me.Profesion = New System.Windows.Forms.TextBox()
        Me.Telefono = New System.Windows.Forms.TextBox()
        Me.DentistaDoc = New System.Windows.Forms.TextBox()
        Me.Motivo = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridViewNiños = New System.Windows.Forms.DataGridView()
        Me.BuscadorNiños = New System.Windows.Forms.TextBox()
        Me.Buscador = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TomaMedicamento = New System.Windows.Forms.TextBox()
        Me.Alergias = New System.Windows.Forms.TextBox()
        Me.Diabetes = New System.Windows.Forms.TextBox()
        Me.Presion = New System.Windows.Forms.TextBox()
        Me.Embarazo = New System.Windows.Forms.TextBox()
        Me.Cirugias = New System.Windows.Forms.TextBox()
        Me.Accidentes = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Dolor = New System.Windows.Forms.TextBox()
        Me.Habitos = New System.Windows.Forms.TextBox()
        Me.Ulceras = New System.Windows.Forms.TextBox()
        Me.Sangrado = New System.Windows.Forms.TextBox()
        Me.Extracciones = New System.Windows.Forms.TextBox()
        Me.Cepilla = New System.Windows.Forms.TextBox()
        Me.HiloDental = New System.Windows.Forms.TextBox()
        Me.ProAnestecia = New System.Windows.Forms.TextBox()
        CType(Me.DataGridViewNiños, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreCliente
        '
        Me.NombreCliente.Location = New System.Drawing.Point(158, 37)
        Me.NombreCliente.Name = "NombreCliente"
        Me.NombreCliente.Size = New System.Drawing.Size(430, 23)
        Me.NombreCliente.TabIndex = 0
        '
        'Edad
        '
        Me.Edad.Location = New System.Drawing.Point(158, 84)
        Me.Edad.Name = "Edad"
        Me.Edad.Size = New System.Drawing.Size(213, 23)
        Me.Edad.TabIndex = 0
        '
        'Sexo
        '
        Me.Sexo.Location = New System.Drawing.Point(488, 84)
        Me.Sexo.Name = "Sexo"
        Me.Sexo.Size = New System.Drawing.Size(100, 23)
        Me.Sexo.TabIndex = 0
        '
        'Encargado
        '
        Me.Encargado.Location = New System.Drawing.Point(158, 127)
        Me.Encargado.Name = "Encargado"
        Me.Encargado.Size = New System.Drawing.Size(213, 23)
        Me.Encargado.TabIndex = 0
        '
        'DPI
        '
        Me.DPI.Location = New System.Drawing.Point(488, 127)
        Me.DPI.Name = "DPI"
        Me.DPI.Size = New System.Drawing.Size(100, 23)
        Me.DPI.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre del Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Edad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(410, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Sexo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(12, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Encargado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(410, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 21)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "DPI"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(12, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 21)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Direccion"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(12, 237)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 21)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Ocupacion"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(12, 284)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 21)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Telefono"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(12, 322)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 21)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Dentista"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(12, 366)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(151, 21)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Motivo de consulta"
        '
        'Direccion
        '
        Me.Direccion.Location = New System.Drawing.Point(158, 188)
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Size = New System.Drawing.Size(430, 23)
        Me.Direccion.TabIndex = 11
        '
        'Profesion
        '
        Me.Profesion.Location = New System.Drawing.Point(158, 234)
        Me.Profesion.Name = "Profesion"
        Me.Profesion.Size = New System.Drawing.Size(430, 23)
        Me.Profesion.TabIndex = 12
        '
        'Telefono
        '
        Me.Telefono.Location = New System.Drawing.Point(158, 281)
        Me.Telefono.Name = "Telefono"
        Me.Telefono.Size = New System.Drawing.Size(430, 23)
        Me.Telefono.TabIndex = 13
        '
        'DentistaDoc
        '
        Me.DentistaDoc.Location = New System.Drawing.Point(158, 319)
        Me.DentistaDoc.Name = "DentistaDoc"
        Me.DentistaDoc.Size = New System.Drawing.Size(430, 23)
        Me.DentistaDoc.TabIndex = 14
        '
        'Motivo
        '
        Me.Motivo.Location = New System.Drawing.Point(158, 363)
        Me.Motivo.Name = "Motivo"
        Me.Motivo.Size = New System.Drawing.Size(430, 23)
        Me.Motivo.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(12, 668)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 65)
        Me.Button1.TabIndex = 16
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridViewNiños
        '
        Me.DataGridViewNiños.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewNiños.Location = New System.Drawing.Point(632, 74)
        Me.DataGridViewNiños.Name = "DataGridViewNiños"
        Me.DataGridViewNiños.RowTemplate.Height = 25
        Me.DataGridViewNiños.Size = New System.Drawing.Size(422, 252)
        Me.DataGridViewNiños.TabIndex = 17
        '
        'BuscadorNiños
        '
        Me.BuscadorNiños.Location = New System.Drawing.Point(703, 34)
        Me.BuscadorNiños.Name = "BuscadorNiños"
        Me.BuscadorNiños.Size = New System.Drawing.Size(269, 23)
        Me.BuscadorNiños.TabIndex = 18
        '
        'Buscador
        '
        Me.Buscador.AutoSize = True
        Me.Buscador.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Buscador.Location = New System.Drawing.Point(619, 35)
        Me.Buscador.Name = "Buscador"
        Me.Buscador.Size = New System.Drawing.Size(78, 21)
        Me.Buscador.TabIndex = 19
        Me.Buscador.Text = "Buscador"
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(105, 668)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 64)
        Me.Button2.TabIndex = 20
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(186, 667)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(73, 65)
        Me.Button3.TabIndex = 21
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(32, 389)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(957, 15)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "---------------------------------------------------------------------------------" &
    "--------------------------------------------------------------------------------" &
    "-----------------------------"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(12, 404)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(125, 21)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Historia Medica"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label13.Location = New System.Drawing.Point(12, 434)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(292, 21)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Toma axtualmente algun medicamento"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label14.Location = New System.Drawing.Point(12, 466)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 21)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Alergias"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label15.Location = New System.Drawing.Point(12, 499)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(74, 21)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Diabetes"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label16.Location = New System.Drawing.Point(12, 531)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(122, 21)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Presion Arterial"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label17.Location = New System.Drawing.Point(12, 562)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(138, 21)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Embarazo (Mujer)"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label18.Location = New System.Drawing.Point(12, 596)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(68, 21)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "Cirugias"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label19.Location = New System.Drawing.Point(12, 628)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(91, 21)
        Me.Label19.TabIndex = 30
        Me.Label19.Text = "Accidentes"
        '
        'TomaMedicamento
        '
        Me.TomaMedicamento.Location = New System.Drawing.Point(310, 434)
        Me.TomaMedicamento.Name = "TomaMedicamento"
        Me.TomaMedicamento.Size = New System.Drawing.Size(92, 23)
        Me.TomaMedicamento.TabIndex = 31
        '
        'Alergias
        '
        Me.Alergias.Location = New System.Drawing.Point(310, 468)
        Me.Alergias.Name = "Alergias"
        Me.Alergias.Size = New System.Drawing.Size(92, 23)
        Me.Alergias.TabIndex = 32
        '
        'Diabetes
        '
        Me.Diabetes.Location = New System.Drawing.Point(310, 501)
        Me.Diabetes.Name = "Diabetes"
        Me.Diabetes.Size = New System.Drawing.Size(92, 23)
        Me.Diabetes.TabIndex = 33
        '
        'Presion
        '
        Me.Presion.Location = New System.Drawing.Point(310, 533)
        Me.Presion.Name = "Presion"
        Me.Presion.Size = New System.Drawing.Size(92, 23)
        Me.Presion.TabIndex = 34
        '
        'Embarazo
        '
        Me.Embarazo.Location = New System.Drawing.Point(310, 564)
        Me.Embarazo.Name = "Embarazo"
        Me.Embarazo.Size = New System.Drawing.Size(92, 23)
        Me.Embarazo.TabIndex = 35
        '
        'Cirugias
        '
        Me.Cirugias.Location = New System.Drawing.Point(310, 598)
        Me.Cirugias.Name = "Cirugias"
        Me.Cirugias.Size = New System.Drawing.Size(92, 23)
        Me.Cirugias.TabIndex = 36
        '
        'Accidentes
        '
        Me.Accidentes.Location = New System.Drawing.Point(310, 630)
        Me.Accidentes.Name = "Accidentes"
        Me.Accidentes.Size = New System.Drawing.Size(92, 23)
        Me.Accidentes.TabIndex = 37
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label20.Location = New System.Drawing.Point(477, 404)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(172, 21)
        Me.Label20.TabIndex = 38
        Me.Label20.Text = "Historia Odontologica"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label21.Location = New System.Drawing.Point(477, 436)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(146, 21)
        Me.Label21.TabIndex = 39
        Me.Label21.Text = "Dolor/Sensibilidad"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label22.Location = New System.Drawing.Point(477, 466)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(214, 84)
        Me.Label22.TabIndex = 40
        Me.Label22.Text = "Habitos(Chupeteo de dedo," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Comerse las uñas," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cortar hilo con los dientes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Morder" &
    "se el labio )" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label24.Location = New System.Drawing.Point(762, 582)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(0, 21)
        Me.Label24.TabIndex = 42
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label25.Location = New System.Drawing.Point(477, 562)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(145, 21)
        Me.Label25.TabIndex = 43
        Me.Label25.Text = "Ulceras en la boca "
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label26.Location = New System.Drawing.Point(477, 596)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(152, 21)
        Me.Label26.TabIndex = 44
        Me.Label26.Text = "Sangrado de encias"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label27.Location = New System.Drawing.Point(477, 628)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(196, 21)
        Me.Label27.TabIndex = 45
        Me.Label27.Text = "Extracciones complicadas"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label23.Location = New System.Drawing.Point(477, 658)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(225, 21)
        Me.Label23.TabIndex = 46
        Me.Label23.Text = "Cuantas veces se cepilla al dia"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label28.Location = New System.Drawing.Point(477, 688)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(120, 21)
        Me.Label28.TabIndex = 47
        Me.Label28.Text = "Usa Hilo dental"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label29.Location = New System.Drawing.Point(477, 715)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(283, 21)
        Me.Label29.TabIndex = 48
        Me.Label29.Text = "Ha tenido problemas con la anestecia"
        '
        'Dolor
        '
        Me.Dolor.Location = New System.Drawing.Point(801, 438)
        Me.Dolor.Name = "Dolor"
        Me.Dolor.Size = New System.Drawing.Size(100, 23)
        Me.Dolor.TabIndex = 49
        '
        'Habitos
        '
        Me.Habitos.Location = New System.Drawing.Point(801, 497)
        Me.Habitos.Name = "Habitos"
        Me.Habitos.Size = New System.Drawing.Size(100, 23)
        Me.Habitos.TabIndex = 50
        '
        'Ulceras
        '
        Me.Ulceras.Location = New System.Drawing.Point(801, 564)
        Me.Ulceras.Name = "Ulceras"
        Me.Ulceras.Size = New System.Drawing.Size(100, 23)
        Me.Ulceras.TabIndex = 51
        '
        'Sangrado
        '
        Me.Sangrado.Location = New System.Drawing.Point(801, 598)
        Me.Sangrado.Name = "Sangrado"
        Me.Sangrado.Size = New System.Drawing.Size(100, 23)
        Me.Sangrado.TabIndex = 52
        '
        'Extracciones
        '
        Me.Extracciones.Location = New System.Drawing.Point(801, 630)
        Me.Extracciones.Name = "Extracciones"
        Me.Extracciones.Size = New System.Drawing.Size(100, 23)
        Me.Extracciones.TabIndex = 53
        '
        'Cepilla
        '
        Me.Cepilla.Location = New System.Drawing.Point(801, 656)
        Me.Cepilla.Name = "Cepilla"
        Me.Cepilla.Size = New System.Drawing.Size(100, 23)
        Me.Cepilla.TabIndex = 54
        '
        'HiloDental
        '
        Me.HiloDental.Location = New System.Drawing.Point(801, 685)
        Me.HiloDental.Name = "HiloDental"
        Me.HiloDental.Size = New System.Drawing.Size(100, 23)
        Me.HiloDental.TabIndex = 55
        '
        'ProAnestecia
        '
        Me.ProAnestecia.Location = New System.Drawing.Point(801, 717)
        Me.ProAnestecia.Name = "ProAnestecia"
        Me.ProAnestecia.Size = New System.Drawing.Size(100, 23)
        Me.ProAnestecia.TabIndex = 56
        '
        'FichaNiños
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1097, 745)
        Me.Controls.Add(Me.ProAnestecia)
        Me.Controls.Add(Me.HiloDental)
        Me.Controls.Add(Me.Cepilla)
        Me.Controls.Add(Me.Extracciones)
        Me.Controls.Add(Me.Sangrado)
        Me.Controls.Add(Me.Ulceras)
        Me.Controls.Add(Me.Habitos)
        Me.Controls.Add(Me.Dolor)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Accidentes)
        Me.Controls.Add(Me.Cirugias)
        Me.Controls.Add(Me.Embarazo)
        Me.Controls.Add(Me.Presion)
        Me.Controls.Add(Me.Diabetes)
        Me.Controls.Add(Me.Alergias)
        Me.Controls.Add(Me.TomaMedicamento)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Buscador)
        Me.Controls.Add(Me.BuscadorNiños)
        Me.Controls.Add(Me.DataGridViewNiños)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Motivo)
        Me.Controls.Add(Me.DentistaDoc)
        Me.Controls.Add(Me.Telefono)
        Me.Controls.Add(Me.Profesion)
        Me.Controls.Add(Me.Direccion)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DPI)
        Me.Controls.Add(Me.Encargado)
        Me.Controls.Add(Me.Sexo)
        Me.Controls.Add(Me.Edad)
        Me.Controls.Add(Me.NombreCliente)
        Me.Name = "FichaNiños"
        Me.Text = "Form1"
        CType(Me.DataGridViewNiños, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NombreCliente As TextBox
    Friend WithEvents Edad As TextBox
    Friend WithEvents Sexo As TextBox
    Friend WithEvents Encargado As TextBox
    Friend WithEvents DPI As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Direccion As TextBox
    Friend WithEvents Profesion As TextBox
    Friend WithEvents Telefono As TextBox
    Friend WithEvents DentistaDoc As TextBox
    Friend WithEvents Motivo As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridViewNiños As DataGridView
    Friend WithEvents BuscadorNiños As TextBox
    Friend WithEvents Buscador As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents TomaMedicamento As TextBox
    Friend WithEvents Alergias As TextBox
    Friend WithEvents Diabetes As TextBox
    Friend WithEvents Presion As TextBox
    Friend WithEvents Embarazo As TextBox
    Friend WithEvents Cirugias As TextBox
    Friend WithEvents Accidentes As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Dolor As TextBox
    Friend WithEvents Habitos As TextBox
    Friend WithEvents Ulceras As TextBox
    Friend WithEvents Sangrado As TextBox
    Friend WithEvents Extracciones As TextBox
    Friend WithEvents Cepilla As TextBox
    Friend WithEvents HiloDental As TextBox
    Friend WithEvents ProAnestecia As TextBox
End Class
