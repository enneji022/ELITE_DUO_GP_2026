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
        Me.lblDams = New System.Windows.Forms.Label()
        Me.lblBoreholes = New System.Windows.Forms.Label()
        Me.lblHouseholds = New System.Windows.Forms.Label()
        Me.txtHouseholds = New System.Windows.Forms.TextBox()
        Me.txtDams = New System.Windows.Forms.TextBox()
        Me.txtBoreholes = New System.Windows.Forms.TextBox()
        Me.txtWaterSources = New System.Windows.Forms.TextBox()
        Me.lblWaterSources = New System.Windows.Forms.Label()
        Me.txtHouse = New System.Windows.Forms.TextBox()
        Me.lblHouse = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnNewDay
        '
        Me.btnNewDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewDay.Location = New System.Drawing.Point(554, 295)
        Me.btnNewDay.Name = "btnNewDay"
        Me.btnNewDay.Size = New System.Drawing.Size(218, 34)
        Me.btnNewDay.TabIndex = 0
        Me.btnNewDay.Text = "New Day"
        Me.btnNewDay.UseVisualStyleBackColor = True
        '
        'btnHouseWater
        '
        Me.btnHouseWater.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHouseWater.Location = New System.Drawing.Point(554, 143)
        Me.btnHouseWater.Name = "btnHouseWater"
        Me.btnHouseWater.Size = New System.Drawing.Size(218, 34)
        Me.btnHouseWater.TabIndex = 1
        Me.btnHouseWater.Text = "Use InHouse Water"
        Me.btnHouseWater.UseVisualStyleBackColor = True
        '
        'btnUseBorehole
        '
        Me.btnUseBorehole.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUseBorehole.Location = New System.Drawing.Point(554, 221)
        Me.btnUseBorehole.Name = "btnUseBorehole"
        Me.btnUseBorehole.Size = New System.Drawing.Size(218, 34)
        Me.btnUseBorehole.TabIndex = 2
        Me.btnUseBorehole.Text = "Use Borehole Water"
        Me.btnUseBorehole.UseVisualStyleBackColor = True
        '
        'btnHouseProfile
        '
        Me.btnHouseProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHouseProfile.Location = New System.Drawing.Point(281, 86)
        Me.btnHouseProfile.Name = "btnHouseProfile"
        Me.btnHouseProfile.Size = New System.Drawing.Size(218, 34)
        Me.btnHouseProfile.TabIndex = 3
        Me.btnHouseProfile.Text = "Display Household Profile"
        Me.btnHouseProfile.UseVisualStyleBackColor = True
        '
        'btnInit
        '
        Me.btnInit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInit.Location = New System.Drawing.Point(623, 12)
        Me.btnInit.Name = "btnInit"
        Me.btnInit.Size = New System.Drawing.Size(165, 41)
        Me.btnInit.TabIndex = 4
        Me.btnInit.Text = "Initialise Program"
        Me.btnInit.UseVisualStyleBackColor = True
        '
        'lblDams
        '
        Me.lblDams.AutoSize = True
        Me.lblDams.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDams.Location = New System.Drawing.Point(246, 12)
        Me.lblDams.Name = "lblDams"
        Me.lblDams.Size = New System.Drawing.Size(123, 16)
        Me.lblDams.TabIndex = 5
        Me.lblDams.Text = "Number of Dams"
        '
        'lblBoreholes
        '
        Me.lblBoreholes.AutoSize = True
        Me.lblBoreholes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBoreholes.Location = New System.Drawing.Point(426, 12)
        Me.lblBoreholes.Name = "lblBoreholes"
        Me.lblBoreholes.Size = New System.Drawing.Size(154, 16)
        Me.lblBoreholes.TabIndex = 6
        Me.lblBoreholes.Text = "Number of Boreholes"
        '
        'lblHouseholds
        '
        Me.lblHouseholds.AutoSize = True
        Me.lblHouseholds.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHouseholds.Location = New System.Drawing.Point(26, 12)
        Me.lblHouseholds.Name = "lblHouseholds"
        Me.lblHouseholds.Size = New System.Drawing.Size(163, 16)
        Me.lblHouseholds.TabIndex = 7
        Me.lblHouseholds.Text = "Number of households"
        '
        'txtHouseholds
        '
        Me.txtHouseholds.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHouseholds.Location = New System.Drawing.Point(29, 31)
        Me.txtHouseholds.Name = "txtHouseholds"
        Me.txtHouseholds.Size = New System.Drawing.Size(165, 22)
        Me.txtHouseholds.TabIndex = 8
        '
        'txtDams
        '
        Me.txtDams.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDams.Location = New System.Drawing.Point(249, 31)
        Me.txtDams.Name = "txtDams"
        Me.txtDams.Size = New System.Drawing.Size(130, 22)
        Me.txtDams.TabIndex = 9
        '
        'txtBoreholes
        '
        Me.txtBoreholes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoreholes.Location = New System.Drawing.Point(429, 31)
        Me.txtBoreholes.Name = "txtBoreholes"
        Me.txtBoreholes.Size = New System.Drawing.Size(158, 22)
        Me.txtBoreholes.TabIndex = 10
        '
        'txtWaterSources
        '
        Me.txtWaterSources.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWaterSources.Location = New System.Drawing.Point(24, 114)
        Me.txtWaterSources.Multiline = True
        Me.txtWaterSources.Name = "txtWaterSources"
        Me.txtWaterSources.Size = New System.Drawing.Size(206, 215)
        Me.txtWaterSources.TabIndex = 11
        '
        'lblWaterSources
        '
        Me.lblWaterSources.AutoSize = True
        Me.lblWaterSources.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWaterSources.Location = New System.Drawing.Point(26, 86)
        Me.lblWaterSources.Name = "lblWaterSources"
        Me.lblWaterSources.Size = New System.Drawing.Size(209, 16)
        Me.lblWaterSources.TabIndex = 12
        Me.lblWaterSources.Text = "Dams and Borehole Statuses"
        '
        'txtHouse
        '
        Me.txtHouse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHouse.Location = New System.Drawing.Point(281, 143)
        Me.txtHouse.Multiline = True
        Me.txtHouse.Name = "txtHouse"
        Me.txtHouse.Size = New System.Drawing.Size(206, 186)
        Me.txtHouse.TabIndex = 13
        '
        'lblHouse
        '
        Me.lblHouse.AutoSize = True
        Me.lblHouse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHouse.Location = New System.Drawing.Point(278, 124)
        Me.lblHouse.Name = "lblHouse"
        Me.lblHouse.Size = New System.Drawing.Size(132, 16)
        Me.lblHouse.TabIndex = 14
        Me.lblHouse.Text = "Household Profile"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblHouse)
        Me.Controls.Add(Me.txtHouse)
        Me.Controls.Add(Me.lblWaterSources)
        Me.Controls.Add(Me.txtWaterSources)
        Me.Controls.Add(Me.txtBoreholes)
        Me.Controls.Add(Me.txtDams)
        Me.Controls.Add(Me.txtHouseholds)
        Me.Controls.Add(Me.lblHouseholds)
        Me.Controls.Add(Me.lblBoreholes)
        Me.Controls.Add(Me.lblDams)
        Me.Controls.Add(Me.btnInit)
        Me.Controls.Add(Me.btnHouseProfile)
        Me.Controls.Add(Me.btnUseBorehole)
        Me.Controls.Add(Me.btnHouseWater)
        Me.Controls.Add(Me.btnNewDay)
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
    Friend WithEvents lblDams As Label
    Friend WithEvents lblBoreholes As Label
    Friend WithEvents lblHouseholds As Label
    Friend WithEvents txtHouseholds As TextBox
    Friend WithEvents txtDams As TextBox
    Friend WithEvents txtBoreholes As TextBox
    Friend WithEvents txtWaterSources As TextBox
    Friend WithEvents lblWaterSources As Label
    Friend WithEvents txtHouse As TextBox
    Friend WithEvents lblHouse As Label
End Class
