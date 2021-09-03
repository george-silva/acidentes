Imports ESRI.ArcGIS.esriSystem
Imports ESRI.ArcGIS.Controls
Imports ESRI.ArcGIS.DataSourcesFile
Imports ESRI.ArcGIS.DataSourcesGDB
Imports ESRI.ArcGIS.Display
Imports ESRI.ArcGIS.ArcMapUI
Imports ESRI.ArcGIS.Geodatabase
Imports ESRI.ArcGIS.Geometry
Imports ESRI.ArcGIS.Carto


Module ArcGisModule
    Public Sub FixedPan(ByVal AxMap As ESRI.ArcGIS.Controls.AxMapControl, ByVal PanX As Integer, ByVal PanY As Integer)
        Dim pEnvelope As New ESRI.ArcGIS.Geometry.Envelope
        pEnvelope = AxMap.Extent
        pEnvelope.Offset(PanX, PanY)
        AxMap.ActiveView.Extent = pEnvelope
        AxMap.Refresh()
    End Sub
    Public Sub FixedZoom(ByVal AxMap As ESRI.ArcGIS.Controls.AxMapControl, ByVal Zoom As Double)
        'Valor de Zoom deve ser double. menor que 1 para zoom in maior que 1 para zoom out
        Dim pEnvelope As New ESRI.ArcGIS.Geometry.Envelope
        pEnvelope = AxMap.Extent
        pEnvelope.Expand(Zoom, Zoom, True)
        AxMap.ActiveView.Extent = pEnvelope
        AxMap.Refresh()
    End Sub
    Public Sub CalculatePanByScale()

    End Sub
    Public Sub CalculateZoomByScale()

    End Sub
    Public Sub FindFeatures(ByVal LayerIndex As Integer, ByVal FieldName As String, ByVal SqlQuery As String)

        Dim pMap As IMap
        pMap = CadastroAcidenteForm.AxMap.Map

        Dim TreeView As TreeView
        TreeView = CadastroAcidenteForm.DisplayResults
        TreeView.Nodes.Clear()
        TreeView.Nodes.Insert(0, "Resultados encontrados: ")

        Dim pFeatureLayer As IFeatureLayer
        Dim pFeatureClass As IFeatureClass
        Dim pFeature As IFeature
        'variaveis de feicao

        Dim pQuery As IQueryFilter
        pQuery = New QueryFilter

        Dim pCursor As IFeatureCursor

        Dim i As Integer
        'indice usado para o treeview
        i = 1

        pFeatureLayer = pMap.Layer(LayerIndex)
        pFeatureClass = pFeatureLayer.FeatureClass

        pQuery.WhereClause = FieldName + " LIKE '" + SqlQuery + "%'"

        pCursor = pFeatureClass.Search(pQuery, False)

        pFeature = pCursor.NextFeature

        If pFeature IsNot Nothing Then
            ZoomFeature(pFeature.OID, LayerIndex, 2500)
            While Not pFeature Is Nothing
                'MessageBox.Show("feicao " + pFeature.Value(0).ToString + " - " + pFeature.Value(6).ToString)
                DisplayResults(pFeature, TreeView, i)
                pFeature = pCursor.NextFeature()
                i = i + 1
            End While

            CadastroAcidenteForm.DisplayResults.ExpandAll()
            pFeature = Nothing
            pCursor = Nothing

        Else

            MessageBox.Show("Não foi possível encontrar um logradouro com este nome.", "Erro")
            Exit Sub

        End If
    End Sub
    Public Sub ZoomFeature(ByVal pFeatureID As Long, ByVal LayerIndex As Integer, ByVal Scale As Integer)

        Dim pMap As IMap
        Dim pFeatureLayer As IFeatureLayer
        Dim pFeatureClass As IFeatureClass
        Dim pfeature As IFeature

        pMap = CadastroAcidenteForm.AxMap.Map

        pFeatureLayer = pMap.Layer(LayerIndex)
        pFeatureClass = pFeatureLayer.FeatureClass
        pfeature = pFeatureClass.GetFeature(pFeatureID)

        Dim pEnvelope As IEnvelope
        pEnvelope = New Envelope
        pEnvelope = pfeature.Extent

        CadastroAcidenteForm.AxMap.ActiveView.Extent = pEnvelope
        pMap.MapScale = Scale
        CadastroAcidenteForm.AxMap.ActiveView.Refresh()

        'pdisplay.

    End Sub
    Public Sub DisplayResults(ByVal pfeature As IFeature, ByVal FeatureList As TreeView, ByVal index As Integer)
        Dim Node As New TreeNode
        Node.Name = pfeature.OID.ToString
        Node.Text = pfeature.OID.ToString + " - " + pfeature.Value(2).ToString '+" ENTRE " + pfeature.Value(14).ToString + " E " + pfeature.Value(15).ToString
        FeatureList.Nodes(0).Nodes.Insert(index, Node)
    End Sub

End Module
