<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraReport1
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CustomJsonSource1 As DevExpress.DataAccess.Json.CustomJsonSource = New DevExpress.DataAccess.Json.CustomJsonSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
        Dim JsonSchemaNode1 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("root", True)
        Dim JsonSchemaNode2 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("Customers", True, DevExpress.DataAccess.Json.JsonNodeType.Array)
        Dim JsonSchemaNode3 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("Id", True, DevExpress.DataAccess.Json.JsonNodeType.[Property], GetType(String))
        Dim JsonSchemaNode4 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("CompanyName", True, DevExpress.DataAccess.Json.JsonNodeType.[Property], GetType(String))
        Dim JsonSchemaNode5 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("ContactName", True, DevExpress.DataAccess.Json.JsonNodeType.[Property], GetType(String))
        Dim JsonSchemaNode6 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("ContactTitle", True, DevExpress.DataAccess.Json.JsonNodeType.[Property], GetType(String))
        Dim JsonSchemaNode7 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("Address", True, DevExpress.DataAccess.Json.JsonNodeType.[Property], GetType(String))
        Dim JsonSchemaNode8 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("City", True, DevExpress.DataAccess.Json.JsonNodeType.[Property], GetType(String))
        Dim JsonSchemaNode9 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("PostalCode", True, DevExpress.DataAccess.Json.JsonNodeType.[Property], GetType(String))
        Dim JsonSchemaNode10 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("Country", True, DevExpress.DataAccess.Json.JsonNodeType.[Property], GetType(String))
        Dim JsonSchemaNode11 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("Phone", True, DevExpress.DataAccess.Json.JsonNodeType.[Property], GetType(String))
        Dim JsonSchemaNode12 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("Fax", True, DevExpress.DataAccess.Json.JsonNodeType.[Property], GetType(String))
        Dim JsonSchemaNode13 As DevExpress.DataAccess.Json.JsonSchemaNode = New DevExpress.DataAccess.Json.JsonSchemaNode("Region", True, DevExpress.DataAccess.Json.JsonNodeType.[Property], GetType(String))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.line1 = New DevExpress.XtraReports.UI.XRLine()
        Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.jsonDataSource1 = New DevExpress.DataAccess.Json.JsonDataSource(Me.components)
        Me.Component11 = New Component1()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.line1, Me.xrLabel2, Me.xrLabel1})
        Me.Detail.HeightF = 100.1061!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'line1
        '
        Me.line1.LocationFloat = New DevExpress.Utils.PointFloat(3.125002!, 98.10608!)
        Me.line1.Name = "line1"
        Me.line1.SizeF = New System.Drawing.SizeF(646.875!, 2.0!)
        '
        'xrLabel2
        '
        Me.xrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "CustomFormatFunction('Address: ""{0}"".', [Address])")})
        Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 70.91669!)
        Me.xrLabel2.Multiline = True
        Me.xrLabel2.Name = "xrLabel2"
        Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel2.SizeF = New System.Drawing.SizeF(303.125!, 27.18939!)
        Me.xrLabel2.Text = "xrLabel2"
        '
        'xrLabel1
        '
        Me.xrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CompanyName]+NewLineConstant()+[ContactName]")})
        Me.xrLabel1.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.xrLabel1.Multiline = True
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel1.SizeF = New System.Drawing.SizeF(650.0!, 70.91669!)
        Me.xrLabel1.StylePriority.UseFont = False
        Me.xrLabel1.StylePriority.UseTextAlignment = False
        Me.xrLabel1.Text = "xrLabel1"
        Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'TopMargin
        '
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'jsonDataSource1
        '
        CustomJsonSource1.Json = resources.GetString("CustomJsonSource1.Json")
        Me.jsonDataSource1.JsonSource = CustomJsonSource1
        Me.jsonDataSource1.Name = "jsonDataSource1"
        JsonSchemaNode2.Nodes.Add(JsonSchemaNode3)
        JsonSchemaNode2.Nodes.Add(JsonSchemaNode4)
        JsonSchemaNode2.Nodes.Add(JsonSchemaNode5)
        JsonSchemaNode2.Nodes.Add(JsonSchemaNode6)
        JsonSchemaNode2.Nodes.Add(JsonSchemaNode7)
        JsonSchemaNode2.Nodes.Add(JsonSchemaNode8)
        JsonSchemaNode2.Nodes.Add(JsonSchemaNode9)
        JsonSchemaNode2.Nodes.Add(JsonSchemaNode10)
        JsonSchemaNode2.Nodes.Add(JsonSchemaNode11)
        JsonSchemaNode2.Nodes.Add(JsonSchemaNode12)
        JsonSchemaNode2.Nodes.Add(JsonSchemaNode13)
        JsonSchemaNode1.Nodes.Add(JsonSchemaNode2)
        Me.jsonDataSource1.Schema = JsonSchemaNode1
        '
        'XtraReport1
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.jsonDataSource1})
        Me.DataMember = "Customers"
        Me.DataSource = Me.jsonDataSource1
        Me.Version = "21.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents line1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents xrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents jsonDataSource1 As DevExpress.DataAccess.Json.JsonDataSource
    Friend WithEvents Component11 As Component1
End Class
