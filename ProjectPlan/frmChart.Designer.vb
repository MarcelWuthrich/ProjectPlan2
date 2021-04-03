<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChart
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataPoint1 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0R, 10.0R)
        Dim DataPoint2 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(1.0R, 20.0R)
        Dim DataPoint3 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(2.0R, 25.0R)
        Dim DataPoint4 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(3.0R, 15.0R)
        Dim DataPoint5 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(4.0R, 21.0R)
        Dim DataPoint6 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(5.0R, 25.0R)
        Dim DataPoint7 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(6.0R, 15.0R)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChart))
        Me.btcFermer = New System.Windows.Forms.Button()
        Me.myChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.myChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btcFermer
        '
        Me.btcFermer.Location = New System.Drawing.Point(599, 30)
        Me.btcFermer.Name = "btcFermer"
        Me.btcFermer.Size = New System.Drawing.Size(75, 23)
        Me.btcFermer.TabIndex = 7
        Me.btcFermer.Text = "Fermer"
        Me.btcFermer.UseVisualStyleBackColor = True
        '
        'myChart
        '
        Me.myChart.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea1.AxisX.Maximum = 10.0R
        ChartArea1.AxisX.Minimum = 0R
        ChartArea1.AxisY.Maximum = 30.0R
        ChartArea1.AxisY.Minimum = 0R
        ChartArea1.Name = "ChartArea1"
        Me.myChart.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.myChart.Legends.Add(Legend1)
        Me.myChart.Location = New System.Drawing.Point(29, 78)
        Me.myChart.Name = "myChart"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Legend = "Legend1"
        Series1.Name = "mySeries1"
        DataPoint1.Label = ""
        DataPoint1.LegendText = "test"
        Series1.Points.Add(DataPoint1)
        Series1.Points.Add(DataPoint2)
        Series1.Points.Add(DataPoint3)
        Series1.Points.Add(DataPoint4)
        Series1.Points.Add(DataPoint5)
        Series1.Points.Add(DataPoint6)
        Series1.Points.Add(DataPoint7)
        Me.myChart.Series.Add(Series1)
        Me.myChart.Size = New System.Drawing.Size(902, 555)
        Me.myChart.TabIndex = 8
        Me.myChart.Text = "Chart1"
        '
        'frmChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 645)
        Me.Controls.Add(Me.myChart)
        Me.Controls.Add(Me.btcFermer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmChart"
        Me.Text = "Chart graphique"
        CType(Me.myChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btcFermer As Button
    Friend WithEvents myChart As DataVisualization.Charting.Chart
End Class
