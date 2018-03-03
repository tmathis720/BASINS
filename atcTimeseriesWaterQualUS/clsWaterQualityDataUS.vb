﻿Imports atcData
Imports atcUtility

Public Class clsWQDUSColumns
    Public Shared colOrganizationIdentifier As Integer = -1
    Public Shared colOrganizationFormalName As Integer = -1
    Public Shared colActivityIdentifier As Integer = -1
    Public Shared colActivityTypeCode As Integer = -1
    Public Shared colActivityMediaName As Integer = -1
    Public Shared colActivityMediaSubdivisionName As Integer = -1
    Public Shared colActivityStartDate As Integer = -1
    Public Shared colActivityStartTime As Integer = -1
    Public Shared colActivityStartTimeZoneCode As Integer = -1
    Public Shared colActivityEndDate As Integer = -1
    Public Shared colActivityEndTime As Integer = -1
    Public Shared colActivityEndTimeZoneCode As Integer = -1
    Public Shared colActivityDepthHeightMeasureValue As Integer = -1
    Public Shared colActivityDepthHeightMeasureUnitCode As Integer = -1
    Public Shared colActivityDepthAltitudeReferencePointText As Integer = -1
    Public Shared colActivityTopDepthHeightMeasureValue As Integer = -1
    Public Shared colActivityTopDepthHeightMeasureUnitCode As Integer = -1
    Public Shared colActivityBottomDepthHeightMeasureValue As Integer = -1
    Public Shared colActivityBottomDepthHeightMeasureUnitCode As Integer = -1
    Public Shared colProjectIdentifier As Integer = -1
    Public Shared colActivityConductingOrganizationText As Integer = -1
    Public Shared colMonitoringLocationIdentifier As Integer = -1
    Public Shared colActivityCommentText As Integer = -1
    Public Shared colSampleAquifer As Integer = -1
    Public Shared colHydrologicCondition As Integer = -1
    Public Shared colHydrologicEvent As Integer = -1
    Public Shared colSampleCollectionMethodIdentifier As Integer = -1
    Public Shared colSampleCollectionMethodIdentifierContext As Integer = -1
    Public Shared colSampleCollectionMethodName As Integer = -1
    Public Shared colSampleCollectionEquipmentName As Integer = -1
    Public Shared colResultDetectionConditionText As Integer = -1
    Public Shared colCharacteristicName As Integer = -1
    Public Shared colResultSampleFractionText As Integer = -1
    Public Shared colResultMeasureValue As Integer = -1
    Public Shared colResultMeasureUnitCode As Integer = -1
    Public Shared colMeasureQualifierCode As Integer = -1
    Public Shared colResultStatusIdentifier As Integer = -1
    Public Shared colStatisticalBaseCode As Integer = -1
    Public Shared colResultValueTypeName As Integer = -1
    Public Shared colResultWeightBasisText As Integer = -1
    Public Shared colResultTimeBasisText As Integer = -1
    Public Shared colResultTemperatureBasisText As Integer = -1
    Public Shared colResultParticleSizeBasisText As Integer = -1
    Public Shared colPrecisionValue As Integer = -1
    Public Shared colResultCommentText As Integer = -1
    Public Shared colUSGSPCode As Integer = -1
    Public Shared colResultDepthHeightMeasureValue As Integer = -1
    Public Shared colResultDepthHeightMeasureUnitCode As Integer = -1
    Public Shared colResultDepthAltitudeReferencePointText As Integer = -1
    Public Shared colSubjectTaxonomicName As Integer = -1
    Public Shared colSampleTissueAnatomyName As Integer = -1
    Public Shared colResultAnalyticalMethodIdentifier As Integer = -1
    Public Shared colResultAnalyticalMethodIdentifierContext As Integer = -1
    Public Shared colResultAnalyticalMethodName As Integer = -1
    Public Shared colMethodDescriptionText As Integer = -1
    Public Shared colLaboratoryName As Integer = -1
    Public Shared colAnalysisStartDate As Integer = -1
    Public Shared colResultLaboratoryCommentText As Integer = -1
    Public Shared colDetectionQuantitationLimitTypeName As Integer = -1
    Public Shared colDetectionQuantitationLimitMeasureValue As Integer = -1
    Public Shared colDetectionQuantitationLimitMeasureUnitCode As Integer = -1
    Public Shared colPreparationStartDate As Integer = -1
    Public Shared colProviderName As Integer = -1

    Public Shared Function SetColumns(ByVal aRecord() As String) As Boolean
        If aRecord Is Nothing OrElse aRecord.Length = 0 Then
            Return False
        End If
        For I As Integer = 0 To aRecord.Length - 1
            If aRecord(I).StartsWith("OrganizationIdentifier") Then colOrganizationIdentifier = I
            If aRecord(I).StartsWith("OrganizationFormalName") Then colOrganizationFormalName = I
            If aRecord(I).StartsWith("ActivityIdentifier") Then colActivityIdentifier = I
            If aRecord(I).StartsWith("ActivityTypeCode") Then colActivityTypeCode = I
            If aRecord(I).StartsWith("ActivityMediaName") Then colActivityMediaName = I
            If aRecord(I).StartsWith("ActivityMediaSubdivisionName") Then colActivityMediaSubdivisionName = I
            If aRecord(I).StartsWith("ActivityStartDate") Then colActivityStartDate = I
            If aRecord(I).StartsWith("ActivityStartTime/Time") Then colActivityStartTime = I
            If aRecord(I).StartsWith("ActivityStartTime/TimeZoneCode") Then colActivityStartTimeZoneCode = I
            If aRecord(I).StartsWith("ActivityEndDate") Then colActivityEndDate = I
            If aRecord(I).StartsWith("ActivityEndTime/Time") Then colActivityEndTime = I
            If aRecord(I).StartsWith("ActivityEndTime/TimeZoneCode") Then colActivityEndTimeZoneCode = I
            If aRecord(I).StartsWith("ActivityDepthHeightMeasure/MeasureValue") Then colActivityDepthHeightMeasureValue = I
            If aRecord(I).StartsWith("ActivityDepthHeightMeasure/MeasureUnitCode") Then colActivityDepthHeightMeasureUnitCode = I
            If aRecord(I).StartsWith("ActivityDepthAltitudeReferencePointText") Then colActivityDepthAltitudeReferencePointText = I
            If aRecord(I).StartsWith("ActivityTopDepthHeightMeasure/MeasureValue") Then colActivityTopDepthHeightMeasureValue = I
            If aRecord(I).StartsWith("ActivityTopDepthHeightMeasure/MeasureUnitCode") Then colActivityTopDepthHeightMeasureUnitCode = I
            If aRecord(I).StartsWith("ActivityBottomDepthHeightMeasure/MeasureValue") Then colActivityBottomDepthHeightMeasureValue = I
            If aRecord(I).StartsWith("ActivityBottomDepthHeightMeasure/MeasureUnitCode") Then colActivityBottomDepthHeightMeasureUnitCode = I
            If aRecord(I).StartsWith("ProjectIdentifier") Then colProjectIdentifier = I
            If aRecord(I).StartsWith("ActivityConductingOrganizationText") Then colActivityConductingOrganizationText = I
            If aRecord(I).StartsWith("MonitoringLocationIdentifier") Then colMonitoringLocationIdentifier = I
            If aRecord(I).StartsWith("ActivityCommentText") Then colActivityCommentText = I
            If aRecord(I).StartsWith("SampleAquifer") Then colSampleAquifer = I
            If aRecord(I).StartsWith("HydrologicCondition") Then colHydrologicCondition = I
            If aRecord(I).StartsWith("HydrologicEvent") Then colHydrologicEvent = I
            If aRecord(I).StartsWith("SampleCollectionMethod/MethodIdentifier") Then colSampleCollectionMethodIdentifier = I
            If aRecord(I).StartsWith("SampleCollectionMethod/MethodIdentifierContext") Then colSampleCollectionMethodIdentifierContext = I
            If aRecord(I).StartsWith("SampleCollectionMethod/MethodName") Then colSampleCollectionMethodName = I
            If aRecord(I).StartsWith("SampleCollectionEquipmentName") Then colSampleCollectionEquipmentName = I
            If aRecord(I).StartsWith("ResultDetectionConditionText") Then colResultDetectionConditionText = I
            If aRecord(I).StartsWith("CharacteristicName") Then colCharacteristicName = I
            If aRecord(I).StartsWith("ResultSampleFractionText") Then colResultSampleFractionText = I
            If aRecord(I).StartsWith("ResultMeasureValue") Then colResultMeasureValue = I
            If aRecord(I).StartsWith("ResultMeasure/MeasureUnitCode") Then colResultMeasureUnitCode = I
            If aRecord(I).StartsWith("MeasureQualifierCode") Then colMeasureQualifierCode = I
            If aRecord(I).StartsWith("ResultStatusIdentifier") Then colResultStatusIdentifier = I
            If aRecord(I).StartsWith("StatisticalBaseCode") Then colStatisticalBaseCode = I
            If aRecord(I).StartsWith("ResultValueTypeName") Then colResultValueTypeName = I
            If aRecord(I).StartsWith("ResultWeightBasisText") Then colResultWeightBasisText = I
            If aRecord(I).StartsWith("ResultTimeBasisText") Then colResultTimeBasisText = I
            If aRecord(I).StartsWith("ResultTemperatureBasisText") Then colResultTemperatureBasisText = I
            If aRecord(I).StartsWith("ResultParticleSizeBasisText") Then colResultParticleSizeBasisText = I
            If aRecord(I).StartsWith("PrecisionValue") Then colPrecisionValue = I
            If aRecord(I).StartsWith("ResultCommentText") Then colResultCommentText = I
            If aRecord(I).StartsWith("USGSPCode") Then colUSGSPCode = I
            If aRecord(I).StartsWith("ResultDepthHeightMeasure/MeasureValue") Then colResultDepthHeightMeasureValue = I
            If aRecord(I).StartsWith("ResultDepthHeightMeasure/MeasureUnitCode") Then colResultDepthHeightMeasureUnitCode = I
            If aRecord(I).StartsWith("ResultDepthAltitudeReferencePointText") Then colResultDepthAltitudeReferencePointText = I
            If aRecord(I).StartsWith("SubjectTaxonomicName") Then colSubjectTaxonomicName = I
            If aRecord(I).StartsWith("SampleTissueAnatomyName") Then colSampleTissueAnatomyName = I
            If aRecord(I).StartsWith("ResultAnalyticalMethod/MethodIdentifier") Then colResultAnalyticalMethodIdentifier = I
            If aRecord(I).StartsWith("ResultAnalyticalMethod/MethodIdentifierContext") Then colResultAnalyticalMethodIdentifierContext = I
            If aRecord(I).StartsWith("ResultAnalyticalMethod/MethodName") Then colResultAnalyticalMethodName = I
            If aRecord(I).StartsWith("MethodDescriptionText") Then colMethodDescriptionText = I
            If aRecord(I).StartsWith("LaboratoryName") Then colLaboratoryName = I
            If aRecord(I).StartsWith("AnalysisStartDate") Then colAnalysisStartDate = I
            If aRecord(I).StartsWith("ResultLaboratoryCommentText") Then colResultLaboratoryCommentText = I
            If aRecord(I).StartsWith("DetectionQuantitationLimitTypeName") Then colDetectionQuantitationLimitTypeName = I
            If aRecord(I).StartsWith("DetectionQuantitationLimitMeasure/MeasureValue") Then colDetectionQuantitationLimitMeasureValue = I
            If aRecord(I).StartsWith("DetectionQuantitationLimitMeasure/MeasureUnitCode") Then colDetectionQuantitationLimitMeasureUnitCode = I
            If aRecord(I).StartsWith("PreparationStartDate") Then colPreparationStartDate = I
            If aRecord(I).StartsWith("ProviderName") Then colProviderName = I
        Next
        Return IsValidColumns()
    End Function

    Public Shared Function IsValidColumns() As Boolean
        If colOrganizationIdentifier < 0 Then Return False
        If colOrganizationFormalName < 0 Then Return False
        If colActivityIdentifier < 0 Then Return False
        If colActivityTypeCode < 0 Then Return False
        If colActivityMediaName < 0 Then Return False
        If colActivityMediaSubdivisionName < 0 Then Return False
        If colActivityStartDate < 0 Then Return False
        If colActivityStartTime < 0 Then Return False
        If colActivityStartTimeZoneCode < 0 Then Return False
        If colActivityEndDate < 0 Then Return False
        If colActivityEndTime < 0 Then Return False
        If colActivityEndTimeZoneCode < 0 Then Return False
        If colActivityDepthHeightMeasureValue < 0 Then Return False
        If colActivityDepthHeightMeasureUnitCode < 0 Then Return False
        If colActivityDepthAltitudeReferencePointText < 0 Then Return False
        If colActivityTopDepthHeightMeasureValue < 0 Then Return False
        If colActivityTopDepthHeightMeasureUnitCode < 0 Then Return False
        If colActivityBottomDepthHeightMeasureValue < 0 Then Return False
        If colActivityBottomDepthHeightMeasureUnitCode < 0 Then Return False
        If colProjectIdentifier < 0 Then Return False
        If colActivityConductingOrganizationText < 0 Then Return False
        If colMonitoringLocationIdentifier < 0 Then Return False
        If colActivityCommentText < 0 Then Return False
        If colSampleAquifer < 0 Then Return False
        If colHydrologicCondition < 0 Then Return False
        If colHydrologicEvent < 0 Then Return False
        If colSampleCollectionMethodIdentifier < 0 Then Return False
        If colSampleCollectionMethodIdentifierContext < 0 Then Return False
        If colSampleCollectionMethodName < 0 Then Return False
        If colSampleCollectionEquipmentName < 0 Then Return False
        If colResultDetectionConditionText < 0 Then Return False
        If colCharacteristicName < 0 Then Return False
        If colResultSampleFractionText < 0 Then Return False
        If colResultMeasureValue < 0 Then Return False
        If colResultMeasureUnitCode < 0 Then Return False
        If colMeasureQualifierCode < 0 Then Return False
        If colResultStatusIdentifier < 0 Then Return False
        If colStatisticalBaseCode < 0 Then Return False
        If colResultValueTypeName < 0 Then Return False
        If colResultWeightBasisText < 0 Then Return False
        If colResultTimeBasisText < 0 Then Return False
        If colResultTemperatureBasisText < 0 Then Return False
        If colResultParticleSizeBasisText < 0 Then Return False
        If colPrecisionValue < 0 Then Return False
        If colResultCommentText < 0 Then Return False
        If colUSGSPCode < 0 Then Return False
        If colResultDepthHeightMeasureValue < 0 Then Return False
        If colResultDepthHeightMeasureUnitCode < 0 Then Return False
        If colResultDepthAltitudeReferencePointText < 0 Then Return False
        If colSubjectTaxonomicName < 0 Then Return False
        If colSampleTissueAnatomyName < 0 Then Return False
        If colResultAnalyticalMethodIdentifier < 0 Then Return False
        If colResultAnalyticalMethodIdentifierContext < 0 Then Return False
        If colResultAnalyticalMethodName < 0 Then Return False
        If colMethodDescriptionText < 0 Then Return False
        If colLaboratoryName < 0 Then Return False
        If colAnalysisStartDate < 0 Then Return False
        If colResultLaboratoryCommentText < 0 Then Return False
        If colDetectionQuantitationLimitTypeName < 0 Then Return False
        If colDetectionQuantitationLimitMeasureValue < 0 Then Return False
        If colDetectionQuantitationLimitMeasureUnitCode < 0 Then Return False
        If colPreparationStartDate < 0 Then Return False
        If colProviderName < 0 Then Return False
        Return True
    End Function
End Class

Public Class clsWaterQualityDataUSRecord
    Public OrganizationIdentifier As String = ""
    Public OrganizationFormalName As String = ""
    Public ActivityIdentifier As String = ""
    Public ActivityTypeCode As String = ""
    Public ActivityMediaName As String = ""
    Public ActivityMediaSubdivisionName As String = ""
    Public ActivityStartDate As String = ""
    Public ActivityStartTime As String = ""
    Public ActivityStartTimeZoneCode As String = ""
    Public ActivityEndDate As String = ""
    Public ActivityEndTime As String = ""
    Public ActivityEndTimeZoneCode As String = ""
    Public ActivityDepthHeightMeasureValue As String = ""
    Public ActivityDepthHeightMeasureUnitCode As String = ""
    Public ActivityDepthAltitudeReferencePointText As String = ""
    Public ActivityTopDepthHeightMeasureValue As String = ""
    Public ActivityTopDepthHeightMeasureUnitCode As String = ""
    Public ActivityBottomDepthHeightMeasureValue As String = ""
    Public ActivityBottomDepthHeightMeasureUnitCode As String = ""
    Public ProjectIdentifier As String = ""
    Public ActivityConductingOrganizationText As String = ""
    Public MonitoringLocationIdentifier As String = ""
    Public ActivityCommentText As String = ""
    Public SampleAquifer As String = ""
    Public HydrologicCondition As String = ""
    Public HydrologicEvent As String = ""
    Public SampleCollectionMethodIdentifier As String = ""
    Public SampleCollectionMethodIdentifierContext As String = ""
    Public SampleCollectionMethodName As String = ""
    Public SampleCollectionEquipmentName As String = ""
    Public ResultDetectionConditionText As String = ""
    Public CharacteristicName As String = ""
    Public ResultSampleFractionText As String = ""
    Public ResultMeasureValue As String = ""
    Public ResultMeasureUnitCode As String = ""
    Public MeasureQualifierCode As String = ""
    Public ResultStatusIdentifier As String = ""
    Public StatisticalBaseCode As String = ""
    Public ResultValueTypeName As String = ""
    Public ResultWeightBasisText As String = ""
    Public ResultTimeBasisText As String = ""
    Public ResultTemperatureBasisText As String = ""
    Public ResultParticleSizeBasisText As String = ""
    Public PrecisionValue As String = ""
    Public ResultCommentText As String = ""
    Public USGSPCode As String = ""
    Public ResultDepthHeightMeasureValue As String = ""
    Public ResultDepthHeightMeasureUnitCode As String = ""
    Public ResultDepthAltitudeReferencePointText As String = ""
    Public SubjectTaxonomicName As String = ""
    Public SampleTissueAnatomyName As String = ""
    Public ResultAnalyticalMethodIdentifier As String = ""
    Public ResultAnalyticalMethodIdentifierContext As String = ""
    Public ResultAnalyticalMethodName As String = ""
    Public MethodDescriptionText As String = ""
    Public LaboratoryName As String = ""
    Public AnalysisStartDate As String = ""
    Public ResultLaboratoryCommentText As String = ""
    Public DetectionQuantitationLimitTypeName As String = ""
    Public DetectionQuantitationLimitMeasureValue As String = ""
    Public DetectionQuantitationLimitMeasureUnitCode As String = ""
    Public PreparationStartDate As String = ""
    Public ProviderName As String = ""
    Public Sub New(ByVal aRecord() As String)
        OrganizationIdentifier = aRecord(clsWQDUSColumns.colOrganizationIdentifier)
        OrganizationFormalName = aRecord(clsWQDUSColumns.colOrganizationFormalName)
        ActivityIdentifier = aRecord(clsWQDUSColumns.colActivityIdentifier)
        ActivityTypeCode = aRecord(clsWQDUSColumns.colActivityTypeCode)
        ActivityMediaName = aRecord(clsWQDUSColumns.colActivityMediaName)
        ActivityMediaSubdivisionName = aRecord(clsWQDUSColumns.colActivityMediaSubdivisionName)
        ActivityStartDate = aRecord(clsWQDUSColumns.colActivityStartDate)
        ActivityStartTime = aRecord(clsWQDUSColumns.colActivityStartTime)
        ActivityStartTimeZoneCode = aRecord(clsWQDUSColumns.colActivityStartTimeZoneCode)
        ActivityEndDate = aRecord(clsWQDUSColumns.colActivityEndDate)
        ActivityEndTime = aRecord(clsWQDUSColumns.colActivityEndTime)
        ActivityEndTimeZoneCode = aRecord(clsWQDUSColumns.colActivityEndTimeZoneCode)
        ActivityDepthHeightMeasureValue = aRecord(clsWQDUSColumns.colActivityDepthHeightMeasureValue)
        ActivityDepthHeightMeasureUnitCode = aRecord(clsWQDUSColumns.colActivityDepthHeightMeasureUnitCode)
        ActivityDepthAltitudeReferencePointText = aRecord(clsWQDUSColumns.colActivityDepthAltitudeReferencePointText)
        ActivityTopDepthHeightMeasureValue = aRecord(clsWQDUSColumns.colActivityTopDepthHeightMeasureValue)
        ActivityTopDepthHeightMeasureUnitCode = aRecord(clsWQDUSColumns.colActivityTopDepthHeightMeasureUnitCode)
        ActivityBottomDepthHeightMeasureValue = aRecord(clsWQDUSColumns.colActivityBottomDepthHeightMeasureValue)
        ActivityBottomDepthHeightMeasureUnitCode = aRecord(clsWQDUSColumns.colActivityBottomDepthHeightMeasureUnitCode)
        ProjectIdentifier = aRecord(clsWQDUSColumns.colProjectIdentifier)
        ActivityConductingOrganizationText = aRecord(clsWQDUSColumns.colActivityConductingOrganizationText)
        MonitoringLocationIdentifier = aRecord(clsWQDUSColumns.colMonitoringLocationIdentifier)
        ActivityCommentText = aRecord(clsWQDUSColumns.colActivityCommentText)
        SampleAquifer = aRecord(clsWQDUSColumns.colSampleAquifer)
        HydrologicCondition = aRecord(clsWQDUSColumns.colHydrologicCondition)
        HydrologicEvent = aRecord(clsWQDUSColumns.colHydrologicEvent)
        SampleCollectionMethodIdentifier = aRecord(clsWQDUSColumns.colSampleCollectionMethodIdentifier)
        SampleCollectionMethodIdentifierContext = aRecord(clsWQDUSColumns.colSampleCollectionMethodIdentifierContext)
        SampleCollectionMethodName = aRecord(clsWQDUSColumns.colSampleCollectionMethodName)
        SampleCollectionEquipmentName = aRecord(clsWQDUSColumns.colSampleCollectionEquipmentName)
        ResultDetectionConditionText = aRecord(clsWQDUSColumns.colResultDetectionConditionText)
        CharacteristicName = aRecord(clsWQDUSColumns.colCharacteristicName)
        ResultSampleFractionText = aRecord(clsWQDUSColumns.colResultSampleFractionText)
        ResultMeasureValue = aRecord(clsWQDUSColumns.colResultMeasureValue)
        ResultMeasureUnitCode = aRecord(clsWQDUSColumns.colResultMeasureUnitCode)
        MeasureQualifierCode = aRecord(clsWQDUSColumns.colMeasureQualifierCode)
        ResultStatusIdentifier = aRecord(clsWQDUSColumns.colResultStatusIdentifier)
        StatisticalBaseCode = aRecord(clsWQDUSColumns.colStatisticalBaseCode)
        ResultValueTypeName = aRecord(clsWQDUSColumns.colResultValueTypeName)
        ResultWeightBasisText = aRecord(clsWQDUSColumns.colResultWeightBasisText)
        ResultTimeBasisText = aRecord(clsWQDUSColumns.colResultTimeBasisText)
        ResultTemperatureBasisText = aRecord(clsWQDUSColumns.colResultTemperatureBasisText)
        ResultParticleSizeBasisText = aRecord(clsWQDUSColumns.colResultParticleSizeBasisText)
        PrecisionValue = aRecord(clsWQDUSColumns.colPrecisionValue)
        ResultCommentText = aRecord(clsWQDUSColumns.colResultCommentText)
        USGSPCode = aRecord(clsWQDUSColumns.colUSGSPCode)
        ResultDepthHeightMeasureValue = aRecord(clsWQDUSColumns.colResultDepthHeightMeasureValue)
        ResultDepthHeightMeasureUnitCode = aRecord(clsWQDUSColumns.colResultDepthHeightMeasureUnitCode)
        ResultDepthAltitudeReferencePointText = aRecord(clsWQDUSColumns.colResultDepthAltitudeReferencePointText)
        SubjectTaxonomicName = aRecord(clsWQDUSColumns.colSubjectTaxonomicName)
        SampleTissueAnatomyName = aRecord(clsWQDUSColumns.colSampleTissueAnatomyName)
        ResultAnalyticalMethodIdentifier = aRecord(clsWQDUSColumns.colResultAnalyticalMethodIdentifier)
        ResultAnalyticalMethodIdentifierContext = aRecord(clsWQDUSColumns.colResultAnalyticalMethodIdentifierContext)
        ResultAnalyticalMethodName = aRecord(clsWQDUSColumns.colResultAnalyticalMethodName)
        MethodDescriptionText = aRecord(clsWQDUSColumns.colMethodDescriptionText)
        LaboratoryName = aRecord(clsWQDUSColumns.colLaboratoryName)
        AnalysisStartDate = aRecord(clsWQDUSColumns.colAnalysisStartDate)
        ResultLaboratoryCommentText = aRecord(clsWQDUSColumns.colResultLaboratoryCommentText)
        DetectionQuantitationLimitTypeName = aRecord(clsWQDUSColumns.colDetectionQuantitationLimitTypeName)
        DetectionQuantitationLimitMeasureValue = aRecord(clsWQDUSColumns.colDetectionQuantitationLimitMeasureValue)
        DetectionQuantitationLimitMeasureUnitCode = aRecord(clsWQDUSColumns.colDetectionQuantitationLimitMeasureUnitCode)
        PreparationStartDate = aRecord(clsWQDUSColumns.colPreparationStartDate)
        ProviderName = aRecord(clsWQDUSColumns.colProviderName)
    End Sub
End Class

Public Class clsWQDUSLocations
    Public Locations As New Dictionary(Of String, clsWQDUSLocation)()
    Public ReadOnly Property GetUniqueConstituentList() As List(Of String)
        Get
            Dim lst As New List(Of String)()
            For Each loc As clsWQDUSLocation In Locations.Values
                For Each cons As clsWQDUSConstituent In loc.Constituents.Values
                    For Each ldata_unit As String In cons.RecordGroup.Keys
                        If Not lst.Contains(cons.Name & "-" & ldata_unit) Then
                            lst.Add(cons.Name & "-" & ldata_unit)
                        End If
                    Next
                Next
            Next
            Return lst
        End Get
    End Property

    Public ReadOnly Property ContainsKey(ByVal aKey As String) As Boolean
        Get
            Return Locations.ContainsKey(aKey)
        End Get
    End Property
    Public ReadOnly Property Count() As Integer
        Get
            Return Locations.Count
        End Get
    End Property
    Public ReadOnly Property Keys() As List(Of String)
        Get
            Return Locations.Keys.ToList()
        End Get
    End Property
    Public ReadOnly Property Values() As List(Of clsWQDUSLocation)
        Get
            Return Locations.Values.ToList()
        End Get
    End Property
    Public ReadOnly Property Item(ByVal aLoc As String) As clsWQDUSLocation
        Get
            Return Locations.Item(aLoc)
        End Get
    End Property
    Public Function Add(ByVal aLocID As String, ByVal aLoc As clsWQDUSLocation) As Boolean
        Try
            Locations.Add(aLocID, aLoc)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
''' <summary>
''' A location group of records of different constituents and time/value pairs 
''' </summary>
Public Class clsWQDUSLocation
    Public Location As String = ""
    Public Constituents As New Dictionary(Of String, clsWQDUSConstituent)()
    Public Sub New(ByVal aLoc As String)
        Location = aLoc
    End Sub
    Public ReadOnly Property DataKeys() As List(Of String)
        Get
            Dim lst As New List(Of String)()
            For Each lcon As clsWQDUSConstituent In Constituents.Values
                lst.AddRange(lcon.DataKeys())
            Next
            Return lst
        End Get
    End Property
    Public Sub AddData(ByVal aRecord() As String)
        Dim lname As String = aRecord(clsWQDUSColumns.colCharacteristicName)
        Dim lunit As String = aRecord(clsWQDUSColumns.colResultMeasureUnitCode)

        'For I As Integer = 0 To aRecord.Length - 1
        '    If aRecord(I) = "Nitrate as N" Then
        '        Dim lfound As String = "Found"
        '    End If
        'Next

        If Not String.IsNullOrEmpty(lname) AndAlso lname.ToLower() = "nitrate as n" Then
            lname = "Nitrate"
            aRecord(clsWQDUSColumns.colCharacteristicName) = lname
            If lunit = "mg/l" Then
                lunit = "mg/l as N"
                aRecord(clsWQDUSColumns.colResultMeasureUnitCode) = lunit
            End If
        End If
        If Not Constituents.ContainsKey(lname) Then
            Constituents.Add(lname, New clsWQDUSConstituent(lname))
        End If
        Constituents.Item(lname).AddData(aRecord)
    End Sub
End Class

Public Class clsWQDUSConstituent
    Public Selected As Boolean = False
    Public Name As String = ""
    ' unit -> records of data points
    Public RecordGroup As New Dictionary(Of String, List(Of clsWQDUSDataPoint))()
    Public ReadOnly Property Unit() As String
        Get
            If RecordGroup.Count = 0 Then
                Return ""
            Else
                Return RecordGroup(0).Item(0).Unit
            End If
            Return ""
        End Get
    End Property
    Public ReadOnly Property Units() As List(Of String)
        Get
            Return RecordGroup.Keys().ToList()
        End Get
    End Property
    Public ReadOnly Property DataKeys() As List(Of String)
        Get
            Dim lst As New List(Of String)()
            For Each lunit As String In RecordGroup.Keys()
                lst.Add(Name & "-" & lunit)
            Next
            Return lst
        End Get
    End Property
    Public Sub New(ByVal aName As String)
        Name = aName
    End Sub
    Public Function AddData(ByVal aRecord() As String) As Boolean
        Dim lFoundValue As Boolean = False
        Dim lDataPoint As New clsWQDUSDataPoint()
        With lDataPoint
            .sDate = aRecord(clsWQDUSColumns.colActivityStartDate)
            .sTime = aRecord(clsWQDUSColumns.colActivityStartTime)
            If Not String.IsNullOrEmpty(aRecord(clsWQDUSColumns.colResultMeasureValue)) Then
                .Value = aRecord(clsWQDUSColumns.colResultMeasureValue)
                .Unit = aRecord(clsWQDUSColumns.colResultMeasureUnitCode)
                lFoundValue = True
            ElseIf Not String.IsNullOrEmpty(aRecord(clsWQDUSColumns.colResultDepthHeightMeasureValue)) Then
                .Value = aRecord(clsWQDUSColumns.colResultDepthHeightMeasureValue)
                .Unit = aRecord(clsWQDUSColumns.colResultDepthHeightMeasureUnitCode)
                lFoundValue = True
            ElseIf Not String.IsNullOrEmpty(aRecord(clsWQDUSColumns.colDetectionQuantitationLimitMeasureValue)) Then
                .Value = aRecord(clsWQDUSColumns.colDetectionQuantitationLimitMeasureValue)
                .Unit = aRecord(clsWQDUSColumns.colDetectionQuantitationLimitMeasureUnitCode)
                lFoundValue = True
            End If
            .Attrib = aRecord(clsWQDUSColumns.colMeasureQualifierCode)
            If String.IsNullOrEmpty(.Attrib) Then
                .Attrib = aRecord(clsWQDUSColumns.colResultStatusIdentifier)
            End If
            .Resulttype = aRecord(clsWQDUSColumns.colResultValueTypeName)
            If lFoundValue Then
                If Not RecordGroup.ContainsKey(.Unit) Then
                    RecordGroup.Add(.Unit, New List(Of clsWQDUSDataPoint)())
                End If
            End If
        End With
        If lFoundValue Then
            RecordGroup.Item(lDataPoint.Unit).Add(lDataPoint)
        End If
        Return lFoundValue
    End Function
End Class

Public Class clsWQDUSDataPoint
    Public sDate As String
    Public sTime As String
    Public Value As String
    Public Unit As String
    Public Attrib As String
    Public Resulttype As String
    Public atcDataTime As Double = -1
    Public vbDataTime As DateTime
    Public Selected As Boolean = False
    Public Function SetDataTime() As Boolean
        Try
            Dim ldates(5) As Integer
            If DateTime.TryParse(sDate & "," & sTime, vbDataTime) Then
                ldates(0) = vbDataTime.Year
                ldates(1) = vbDataTime.Month
                ldates(2) = vbDataTime.Day
                ldates(3) = vbDataTime.Hour
                ldates(4) = vbDataTime.Minute
                ldates(5) = vbDataTime.Second
            ElseIf DateTime.TryParse(sDate, vbDataTime) Then
                ldates(0) = vbDataTime.Year
                ldates(1) = vbDataTime.Month
                ldates(2) = vbDataTime.Day
                ldates(3) = 24
            End If
            atcDataTime = Date2J(ldates)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
End Class

