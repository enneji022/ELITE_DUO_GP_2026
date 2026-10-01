<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnNewDay = New System.Windows.Forms.Button()
        Me.btnHouseWater = New System.Windows.Forms.Button()
        Me.btnUseBorehole = New System.Windows.Forms.Button()
        Me.btnHouseProfile = New System.Windows.Forms.Button()
        Me.btnInit = New System.Windows.Forms.Button()
        Me.lblBoreholes = New System.Windows.Forms.Label()
        Me.lblHouseholds = New System.Windows.Forms.Label()
        Me.txtHouseholds = New System.Windows.Forms.TextBox()
        Me.txtBoreholes = New System.Windows.Forms.TextBox()
        Me.txtWaterSources = New System.Windows.Forms.TextBox()
        Me.lblWaterSources = New System.Windows.Forms.Label()
        Me.txtHouse = New System.Windows.Forms.TextBox()
        Me.lblHouse = New System.Windows.Forms.Label()
        Me.txtMaxTapUsage = New System.Windows.Forms.TextBox()
        Me.lblTapMax = New System.Windows.Forms.Label()
        Me.txtDamMax = New System.Windows.Forms.TextBox()
        Me.lblDamMax = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnNewDay
        '
        Me.btnNewDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewDay.Location = New System.Drawing.Point(13, 509)
        Me.btnNewDay.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnNewDay.Name = "btnNewDay"
        Me.btnNewDay.Size = New System.Drawing.Size(327, 52)
        Me.btnNewDay.TabIndex = 0
        Me.btnNewDay.Text = "New Day"
        Me.btnNewDay.UseVisualStyleBackColor = True
        '
        'btnHouseWater
        '
        Me.btnHouseWater.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHouseWater.Location = New System.Drawing.Point(18, 191)
        Me.btnHouseWater.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnHouseWater.Name = "btnHouseWater"
        Me.btnHouseWater.Size = New System.Drawing.Size(327, 52)
        Me.btnHouseWater.TabIndex = 1
        Me.btnHouseWater.Text = "Use InHouse Water"
        Me.btnHouseWater.UseVisualStyleBackColor = True
        '
        'btnUseBorehole
        '
        Me.btnUseBorehole.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUseBorehole.Location = New System.Drawing.Point(13, 297)
        Me.btnUseBorehole.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUseBorehole.Name = "btnUseBorehole"
        Me.btnUseBorehole.Size = New System.Drawing.Size(327, 52)
        Me.btnUseBorehole.TabIndex = 2
        Me.btnUseBorehole.Text = "Use Borehole Water"
        Me.btnUseBorehole.UseVisualStyleBackColor = True
        '
        'btnHouseProfile
        '
        Me.btnHouseProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHouseProfile.Location = New System.Drawing.Point(13, 403)
        Me.btnHouseProfile.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnHouseProfile.Name = "btnHouseProfile"
        Me.btnHouseProfile.Size = New System.Drawing.Size(327, 52)
        Me.btnHouseProfile.TabIndex = 3
        Me.btnHouseProfile.Text = "Display Household Profile"
        Me.btnHouseProfile.UseVisualStyleBackColor = True
        '
        'btnInit
        '
        Me.btnInit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInit.Location = New System.Drawing.Point(1007, 53)
        Me.btnInit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnInit.Name = "btnInit"
        Me.btnInit.Size = New System.Drawing.Size(203, 80)
        Me.btnInit.TabIndex = 4
        Me.btnInit.Text = "Initialise Program"
        Me.btnInit.UseVisualStyleBackColor = True
        '
        'lblBoreholes
        '
        Me.lblBoreholes.AutoSize = True
        Me.lblBoreholes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBoreholes.Location = New System.Drawing.Point(287, 53)
        Me.lblBoreholes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBoreholes.Name = "lblBoreholes"
        Me.lblBoreholes.Size = New System.Drawing.Size(214, 25)
        Me.lblBoreholes.TabIndex = 6
        Me.lblBoreholes.Text = "Number of Boreholes"
        '
        'lblHouseholds
        '
        Me.lblHouseholds.AutoSize = True
        Me.lblHouseholds.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHouseholds.Location = New System.Drawing.Point(13, 53)
        Me.lblHouseholds.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHouseholds.Name = "lblHouseholds"
        Me.lblHouseholds.Size = New System.Drawing.Size(228, 25)
        Me.lblHouseholds.TabIndex = 7
        Me.lblHouseholds.Text = "Number of households"
        '
        'txtHouseholds
        '
        Me.txtHouseholds.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHouseholds.Location = New System.Drawing.Point(18, 86)
        Me.txtHouseholds.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtHouseholds.Name = "txtHouseholds"
        Me.txtHouseholds.Size = New System.Drawing.Size(223, 30)
        Me.txtHouseholds.TabIndex = 8
        '
        'txtBoreholes
        '
        Me.txtBoreholes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoreholes.Location = New System.Drawing.Point(292, 86)
        Me.txtBoreholes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBoreholes.Name = "txtBoreholes"
        Me.txtBoreholes.Size = New System.Drawing.Size(209, 30)
        Me.txtBoreholes.TabIndex = 10
        '
        'txtWaterSources
        '
        Me.txtWaterSources.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWaterSources.Location = New System.Drawing.Point(452, 234)
        Me.txtWaterSources.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtWaterSources.Multiline = True
        Me.txtWaterSources.Name = "txtWaterSources"
        Me.txtWaterSources.Size = New System.Drawing.Size(276, 329)
        Me.txtWaterSources.TabIndex = 11
        '
        'lblWaterSources
        '
        Me.lblWaterSources.AutoSize = True
        Me.lblWaterSources.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWaterSources.Location = New System.Drawing.Point(447, 191)
        Me.lblWaterSources.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWaterSources.Name = "lblWaterSources"
        Me.lblWaterSources.Size = New System.Drawing.Size(281, 25)
        Me.lblWaterSources.TabIndex = 12
        Me.lblWaterSources.Text = "Dam and Borehole Statuses"
        '
        'txtHouse
        '
        Me.txtHouse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHouse.Location = New System.Drawing.Point(864, 234)
        Me.txtHouse.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtHouse.Multiline = True
        Me.txtHouse.Name = "txtHouse"
        Me.txtHouse.Size = New System.Drawing.Size(276, 329)
        Me.txtHouse.TabIndex = 13
        '
        'lblHouse
        '
        Me.lblHouse.AutoSize = True
        Me.lblHouse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHouse.Location = New System.Drawing.Point(859, 191)
        Me.lblHouse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHouse.Name = "lblHouse"
        Me.lblHouse.Size = New System.Drawing.Size(182, 25)
        Me.lblHouse.TabIndex = 14
        Me.lblHouse.Text = "Household Profile"
        '
        'txtMaxTapUsage
        '
        Me.txtMaxTapUsage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaxTapUsage.Location = New System.Drawing.Point(552, 86)
        Me.txtMaxTapUsage.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMaxTapUsage.Name = "txtMaxTapUsage"
        Me.txtMaxTapUsage.Size = New System.Drawing.Size(142, 30)
        Me.txtMaxTapUsage.TabIndex = 15
        '
        'lblTapMax
        '
        Me.lblTapMax.AutoSize = True
        Me.lblTapMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTapMax.Location = New System.Drawing.Point(740, 53)
        Me.lblTapMax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTapMax.Name = "lblTapMax"
        Me.lblTapMax.Size = New System.Drawing.Size(216, 25)
        Me.lblTapMax.TabIndex = 16
        Me.lblTapMax.Text = "Maximum Tap Usage"
        '
        'txtDamMax
        '
        Me.txtDamMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDamMax.Location = New System.Drawing.Point(745, 86)
        Me.txtDamMax.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDamMax.Name = "txtDamMax"
        Me.txtDamMax.Size = New System.Drawing.Size(211, 30)
        Me.txtDamMax.TabIndex = 17
        '
        'lblDamMax
        '
        Me.lblDamMax.AutoSize = True
        Me.lblDamMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDamMax.Location = New System.Drawing.Point(547, 53)
        Me.lblDamMax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDamMax.Name = "lblDamMax"
        Me.lblDamMax.Size = New System.Drawing.Size(147, 25)
        Me.lblDamMax.TabIndex = 18
        Me.lblDamMax.Text = "Dam Capacity"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(447, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(333, 29)
        Me.lblTitle.TabIndex = 19
        Me.lblTitle.Text = "WATER AND SANITATION "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1226, 608)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblDamMax)
        Me.Controls.Add(Me.txtDamMax)
        Me.Controls.Add(Me.lblTapMax)
        Me.Controls.Add(Me.txtMaxTapUsage)
        Me.Controls.Add(Me.lblHouse)
        Me.Controls.Add(Me.txtHouse)
        Me.Controls.Add(Me.lblWaterSources)
        Me.Controls.Add(Me.txtWaterSources)
        Me.Controls.Add(Me.txtBoreholes)
        Me.Controls.Add(Me.txtHouseholds)
        Me.Controls.Add(Me.lblHouseholds)
        Me.Controls.Add(Me.lblBoreholes)
        Me.Controls.Add(Me.btnInit)
        Me.Controls.Add(Me.btnHouseProfile)
        Me.Controls.Add(Me.btnUseBorehole)
        Me.Controls.Add(Me.btnHouseWater)
        Me.Controls.Add(Me.btnNewDay)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNewDay As Button
    Friend WithEvents btnHouseWater As Button
    Friend WithEvents btnUseBorehole As Button
    Friend WithEvents btnHouseProfile As Button
    Friend WithEvents btnInit As Button
    Friend WithEvents lblBoreholes As Label
    Friend WithEvents lblHouseholds As Label
    Friend WithEvents txtHouseholds As TextBox
    Friend WithEvents txtBoreholes As TextBox
    Friend WithEvents txtWaterSources As TextBox
    Friend WithEvents lblWaterSources As Label
    Friend WithEvents txtHouse As TextBox
    Friend WithEvents lblHouse As Label
    Friend WithEvents txtMaxTapUsage As TextBox
    Friend WithEvents lblTapMax As Label
    Friend WithEvents txtDamMax As TextBox
    Friend WithEvents lblDamMax As Label
    Friend WithEvents lblTitle As Label
End Class
