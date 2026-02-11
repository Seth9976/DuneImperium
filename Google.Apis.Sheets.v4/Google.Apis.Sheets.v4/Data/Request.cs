using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x02000099 RID: 153
	public class Request : Object
	{
		// Token: 0x06000BAA RID: 2986 RVA: 0x0003765C File Offset: 0x0003585C
		// Note: this type is marked as 'beforefieldinit'.
		static Request()
		{
			Il2CppClassPointerStore<Request>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "Request");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Request>.NativeClassPtr);
			Request.NativeFieldInfoPtr__AddBanding_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<AddBanding>k__BackingField");
			Request.NativeFieldInfoPtr__AddChart_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<AddChart>k__BackingField");
			Request.NativeFieldInfoPtr__AddConditionalFormatRule_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<AddConditionalFormatRule>k__BackingField");
			Request.NativeFieldInfoPtr__AddDimensionGroup_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<AddDimensionGroup>k__BackingField");
			Request.NativeFieldInfoPtr__AddFilterView_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<AddFilterView>k__BackingField");
			Request.NativeFieldInfoPtr__AddNamedRange_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<AddNamedRange>k__BackingField");
			Request.NativeFieldInfoPtr__AddProtectedRange_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<AddProtectedRange>k__BackingField");
			Request.NativeFieldInfoPtr__AddSheet_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<AddSheet>k__BackingField");
			Request.NativeFieldInfoPtr__AddSlicer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<AddSlicer>k__BackingField");
			Request.NativeFieldInfoPtr__AppendCells_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<AppendCells>k__BackingField");
			Request.NativeFieldInfoPtr__AppendDimension_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<AppendDimension>k__BackingField");
			Request.NativeFieldInfoPtr__AutoFill_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<AutoFill>k__BackingField");
			Request.NativeFieldInfoPtr__AutoResizeDimensions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<AutoResizeDimensions>k__BackingField");
			Request.NativeFieldInfoPtr__ClearBasicFilter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<ClearBasicFilter>k__BackingField");
			Request.NativeFieldInfoPtr__CopyPaste_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<CopyPaste>k__BackingField");
			Request.NativeFieldInfoPtr__CreateDeveloperMetadata_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<CreateDeveloperMetadata>k__BackingField");
			Request.NativeFieldInfoPtr__CutPaste_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<CutPaste>k__BackingField");
			Request.NativeFieldInfoPtr__DeleteBanding_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<DeleteBanding>k__BackingField");
			Request.NativeFieldInfoPtr__DeleteConditionalFormatRule_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<DeleteConditionalFormatRule>k__BackingField");
			Request.NativeFieldInfoPtr__DeleteDeveloperMetadata_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<DeleteDeveloperMetadata>k__BackingField");
			Request.NativeFieldInfoPtr__DeleteDimension_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<DeleteDimension>k__BackingField");
			Request.NativeFieldInfoPtr__DeleteDimensionGroup_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<DeleteDimensionGroup>k__BackingField");
			Request.NativeFieldInfoPtr__DeleteDuplicates_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<DeleteDuplicates>k__BackingField");
			Request.NativeFieldInfoPtr__DeleteEmbeddedObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<DeleteEmbeddedObject>k__BackingField");
			Request.NativeFieldInfoPtr__DeleteFilterView_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<DeleteFilterView>k__BackingField");
			Request.NativeFieldInfoPtr__DeleteNamedRange_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<DeleteNamedRange>k__BackingField");
			Request.NativeFieldInfoPtr__DeleteProtectedRange_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<DeleteProtectedRange>k__BackingField");
			Request.NativeFieldInfoPtr__DeleteRange_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<DeleteRange>k__BackingField");
			Request.NativeFieldInfoPtr__DeleteSheet_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<DeleteSheet>k__BackingField");
			Request.NativeFieldInfoPtr__DuplicateFilterView_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<DuplicateFilterView>k__BackingField");
			Request.NativeFieldInfoPtr__DuplicateSheet_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<DuplicateSheet>k__BackingField");
			Request.NativeFieldInfoPtr__FindReplace_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<FindReplace>k__BackingField");
			Request.NativeFieldInfoPtr__InsertDimension_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<InsertDimension>k__BackingField");
			Request.NativeFieldInfoPtr__InsertRange_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<InsertRange>k__BackingField");
			Request.NativeFieldInfoPtr__MergeCells_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<MergeCells>k__BackingField");
			Request.NativeFieldInfoPtr__MoveDimension_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<MoveDimension>k__BackingField");
			Request.NativeFieldInfoPtr__PasteData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<PasteData>k__BackingField");
			Request.NativeFieldInfoPtr__RandomizeRange_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<RandomizeRange>k__BackingField");
			Request.NativeFieldInfoPtr__RepeatCell_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<RepeatCell>k__BackingField");
			Request.NativeFieldInfoPtr__SetBasicFilter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<SetBasicFilter>k__BackingField");
			Request.NativeFieldInfoPtr__SetDataValidation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<SetDataValidation>k__BackingField");
			Request.NativeFieldInfoPtr__SortRange_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<SortRange>k__BackingField");
			Request.NativeFieldInfoPtr__TextToColumns_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<TextToColumns>k__BackingField");
			Request.NativeFieldInfoPtr__TrimWhitespace_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<TrimWhitespace>k__BackingField");
			Request.NativeFieldInfoPtr__UnmergeCells_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<UnmergeCells>k__BackingField");
			Request.NativeFieldInfoPtr__UpdateBanding_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<UpdateBanding>k__BackingField");
			Request.NativeFieldInfoPtr__UpdateBorders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<UpdateBorders>k__BackingField");
			Request.NativeFieldInfoPtr__UpdateCells_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<UpdateCells>k__BackingField");
			Request.NativeFieldInfoPtr__UpdateChartSpec_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<UpdateChartSpec>k__BackingField");
			Request.NativeFieldInfoPtr__UpdateConditionalFormatRule_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<UpdateConditionalFormatRule>k__BackingField");
			Request.NativeFieldInfoPtr__UpdateDeveloperMetadata_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<UpdateDeveloperMetadata>k__BackingField");
			Request.NativeFieldInfoPtr__UpdateDimensionGroup_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<UpdateDimensionGroup>k__BackingField");
			Request.NativeFieldInfoPtr__UpdateDimensionProperties_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<UpdateDimensionProperties>k__BackingField");
			Request.NativeFieldInfoPtr__UpdateEmbeddedObjectPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<UpdateEmbeddedObjectPosition>k__BackingField");
			Request.NativeFieldInfoPtr__UpdateFilterView_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<UpdateFilterView>k__BackingField");
			Request.NativeFieldInfoPtr__UpdateNamedRange_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<UpdateNamedRange>k__BackingField");
			Request.NativeFieldInfoPtr__UpdateProtectedRange_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<UpdateProtectedRange>k__BackingField");
			Request.NativeFieldInfoPtr__UpdateSheetProperties_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<UpdateSheetProperties>k__BackingField");
			Request.NativeFieldInfoPtr__UpdateSlicerSpec_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<UpdateSlicerSpec>k__BackingField");
			Request.NativeFieldInfoPtr__UpdateSpreadsheetProperties_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<UpdateSpreadsheetProperties>k__BackingField");
			Request.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Request>.NativeClassPtr, "<ETag>k__BackingField");
			Request.NativeMethodInfoPtr_get_AddBanding_Public_Virtual_New_get_AddBandingRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664937);
			Request.NativeMethodInfoPtr_set_AddBanding_Public_Virtual_New_set_Void_AddBandingRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664938);
			Request.NativeMethodInfoPtr_get_AddChart_Public_Virtual_New_get_AddChartRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664939);
			Request.NativeMethodInfoPtr_set_AddChart_Public_Virtual_New_set_Void_AddChartRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664940);
			Request.NativeMethodInfoPtr_get_AddConditionalFormatRule_Public_Virtual_New_get_AddConditionalFormatRuleRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664941);
			Request.NativeMethodInfoPtr_set_AddConditionalFormatRule_Public_Virtual_New_set_Void_AddConditionalFormatRuleRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664942);
			Request.NativeMethodInfoPtr_get_AddDimensionGroup_Public_Virtual_New_get_AddDimensionGroupRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664943);
			Request.NativeMethodInfoPtr_set_AddDimensionGroup_Public_Virtual_New_set_Void_AddDimensionGroupRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664944);
			Request.NativeMethodInfoPtr_get_AddFilterView_Public_Virtual_New_get_AddFilterViewRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664945);
			Request.NativeMethodInfoPtr_set_AddFilterView_Public_Virtual_New_set_Void_AddFilterViewRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664946);
			Request.NativeMethodInfoPtr_get_AddNamedRange_Public_Virtual_New_get_AddNamedRangeRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664947);
			Request.NativeMethodInfoPtr_set_AddNamedRange_Public_Virtual_New_set_Void_AddNamedRangeRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664948);
			Request.NativeMethodInfoPtr_get_AddProtectedRange_Public_Virtual_New_get_AddProtectedRangeRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664949);
			Request.NativeMethodInfoPtr_set_AddProtectedRange_Public_Virtual_New_set_Void_AddProtectedRangeRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664950);
			Request.NativeMethodInfoPtr_get_AddSheet_Public_Virtual_New_get_AddSheetRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664951);
			Request.NativeMethodInfoPtr_set_AddSheet_Public_Virtual_New_set_Void_AddSheetRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664952);
			Request.NativeMethodInfoPtr_get_AddSlicer_Public_Virtual_New_get_AddSlicerRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664953);
			Request.NativeMethodInfoPtr_set_AddSlicer_Public_Virtual_New_set_Void_AddSlicerRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664954);
			Request.NativeMethodInfoPtr_get_AppendCells_Public_Virtual_New_get_AppendCellsRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664955);
			Request.NativeMethodInfoPtr_set_AppendCells_Public_Virtual_New_set_Void_AppendCellsRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664956);
			Request.NativeMethodInfoPtr_get_AppendDimension_Public_Virtual_New_get_AppendDimensionRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664957);
			Request.NativeMethodInfoPtr_set_AppendDimension_Public_Virtual_New_set_Void_AppendDimensionRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664958);
			Request.NativeMethodInfoPtr_get_AutoFill_Public_Virtual_New_get_AutoFillRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664959);
			Request.NativeMethodInfoPtr_set_AutoFill_Public_Virtual_New_set_Void_AutoFillRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664960);
			Request.NativeMethodInfoPtr_get_AutoResizeDimensions_Public_Virtual_New_get_AutoResizeDimensionsRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664961);
			Request.NativeMethodInfoPtr_set_AutoResizeDimensions_Public_Virtual_New_set_Void_AutoResizeDimensionsRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664962);
			Request.NativeMethodInfoPtr_get_ClearBasicFilter_Public_Virtual_New_get_ClearBasicFilterRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664963);
			Request.NativeMethodInfoPtr_set_ClearBasicFilter_Public_Virtual_New_set_Void_ClearBasicFilterRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664964);
			Request.NativeMethodInfoPtr_get_CopyPaste_Public_Virtual_New_get_CopyPasteRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664965);
			Request.NativeMethodInfoPtr_set_CopyPaste_Public_Virtual_New_set_Void_CopyPasteRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664966);
			Request.NativeMethodInfoPtr_get_CreateDeveloperMetadata_Public_Virtual_New_get_CreateDeveloperMetadataRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664967);
			Request.NativeMethodInfoPtr_set_CreateDeveloperMetadata_Public_Virtual_New_set_Void_CreateDeveloperMetadataRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664968);
			Request.NativeMethodInfoPtr_get_CutPaste_Public_Virtual_New_get_CutPasteRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664969);
			Request.NativeMethodInfoPtr_set_CutPaste_Public_Virtual_New_set_Void_CutPasteRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664970);
			Request.NativeMethodInfoPtr_get_DeleteBanding_Public_Virtual_New_get_DeleteBandingRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664971);
			Request.NativeMethodInfoPtr_set_DeleteBanding_Public_Virtual_New_set_Void_DeleteBandingRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664972);
			Request.NativeMethodInfoPtr_get_DeleteConditionalFormatRule_Public_Virtual_New_get_DeleteConditionalFormatRuleRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664973);
			Request.NativeMethodInfoPtr_set_DeleteConditionalFormatRule_Public_Virtual_New_set_Void_DeleteConditionalFormatRuleRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664974);
			Request.NativeMethodInfoPtr_get_DeleteDeveloperMetadata_Public_Virtual_New_get_DeleteDeveloperMetadataRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664975);
			Request.NativeMethodInfoPtr_set_DeleteDeveloperMetadata_Public_Virtual_New_set_Void_DeleteDeveloperMetadataRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664976);
			Request.NativeMethodInfoPtr_get_DeleteDimension_Public_Virtual_New_get_DeleteDimensionRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664977);
			Request.NativeMethodInfoPtr_set_DeleteDimension_Public_Virtual_New_set_Void_DeleteDimensionRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664978);
			Request.NativeMethodInfoPtr_get_DeleteDimensionGroup_Public_Virtual_New_get_DeleteDimensionGroupRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664979);
			Request.NativeMethodInfoPtr_set_DeleteDimensionGroup_Public_Virtual_New_set_Void_DeleteDimensionGroupRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664980);
			Request.NativeMethodInfoPtr_get_DeleteDuplicates_Public_Virtual_New_get_DeleteDuplicatesRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664981);
			Request.NativeMethodInfoPtr_set_DeleteDuplicates_Public_Virtual_New_set_Void_DeleteDuplicatesRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664982);
			Request.NativeMethodInfoPtr_get_DeleteEmbeddedObject_Public_Virtual_New_get_DeleteEmbeddedObjectRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664983);
			Request.NativeMethodInfoPtr_set_DeleteEmbeddedObject_Public_Virtual_New_set_Void_DeleteEmbeddedObjectRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664984);
			Request.NativeMethodInfoPtr_get_DeleteFilterView_Public_Virtual_New_get_DeleteFilterViewRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664985);
			Request.NativeMethodInfoPtr_set_DeleteFilterView_Public_Virtual_New_set_Void_DeleteFilterViewRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664986);
			Request.NativeMethodInfoPtr_get_DeleteNamedRange_Public_Virtual_New_get_DeleteNamedRangeRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664987);
			Request.NativeMethodInfoPtr_set_DeleteNamedRange_Public_Virtual_New_set_Void_DeleteNamedRangeRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664988);
			Request.NativeMethodInfoPtr_get_DeleteProtectedRange_Public_Virtual_New_get_DeleteProtectedRangeRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664989);
			Request.NativeMethodInfoPtr_set_DeleteProtectedRange_Public_Virtual_New_set_Void_DeleteProtectedRangeRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664990);
			Request.NativeMethodInfoPtr_get_DeleteRange_Public_Virtual_New_get_DeleteRangeRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664991);
			Request.NativeMethodInfoPtr_set_DeleteRange_Public_Virtual_New_set_Void_DeleteRangeRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664992);
			Request.NativeMethodInfoPtr_get_DeleteSheet_Public_Virtual_New_get_DeleteSheetRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664993);
			Request.NativeMethodInfoPtr_set_DeleteSheet_Public_Virtual_New_set_Void_DeleteSheetRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664994);
			Request.NativeMethodInfoPtr_get_DuplicateFilterView_Public_Virtual_New_get_DuplicateFilterViewRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664995);
			Request.NativeMethodInfoPtr_set_DuplicateFilterView_Public_Virtual_New_set_Void_DuplicateFilterViewRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664996);
			Request.NativeMethodInfoPtr_get_DuplicateSheet_Public_Virtual_New_get_DuplicateSheetRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664997);
			Request.NativeMethodInfoPtr_set_DuplicateSheet_Public_Virtual_New_set_Void_DuplicateSheetRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664998);
			Request.NativeMethodInfoPtr_get_FindReplace_Public_Virtual_New_get_FindReplaceRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100664999);
			Request.NativeMethodInfoPtr_set_FindReplace_Public_Virtual_New_set_Void_FindReplaceRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665000);
			Request.NativeMethodInfoPtr_get_InsertDimension_Public_Virtual_New_get_InsertDimensionRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665001);
			Request.NativeMethodInfoPtr_set_InsertDimension_Public_Virtual_New_set_Void_InsertDimensionRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665002);
			Request.NativeMethodInfoPtr_get_InsertRange_Public_Virtual_New_get_InsertRangeRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665003);
			Request.NativeMethodInfoPtr_set_InsertRange_Public_Virtual_New_set_Void_InsertRangeRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665004);
			Request.NativeMethodInfoPtr_get_MergeCells_Public_Virtual_New_get_MergeCellsRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665005);
			Request.NativeMethodInfoPtr_set_MergeCells_Public_Virtual_New_set_Void_MergeCellsRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665006);
			Request.NativeMethodInfoPtr_get_MoveDimension_Public_Virtual_New_get_MoveDimensionRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665007);
			Request.NativeMethodInfoPtr_set_MoveDimension_Public_Virtual_New_set_Void_MoveDimensionRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665008);
			Request.NativeMethodInfoPtr_get_PasteData_Public_Virtual_New_get_PasteDataRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665009);
			Request.NativeMethodInfoPtr_set_PasteData_Public_Virtual_New_set_Void_PasteDataRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665010);
			Request.NativeMethodInfoPtr_get_RandomizeRange_Public_Virtual_New_get_RandomizeRangeRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665011);
			Request.NativeMethodInfoPtr_set_RandomizeRange_Public_Virtual_New_set_Void_RandomizeRangeRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665012);
			Request.NativeMethodInfoPtr_get_RepeatCell_Public_Virtual_New_get_RepeatCellRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665013);
			Request.NativeMethodInfoPtr_set_RepeatCell_Public_Virtual_New_set_Void_RepeatCellRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665014);
			Request.NativeMethodInfoPtr_get_SetBasicFilter_Public_Virtual_New_get_SetBasicFilterRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665015);
			Request.NativeMethodInfoPtr_set_SetBasicFilter_Public_Virtual_New_set_Void_SetBasicFilterRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665016);
			Request.NativeMethodInfoPtr_get_SetDataValidation_Public_Virtual_New_get_SetDataValidationRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665017);
			Request.NativeMethodInfoPtr_set_SetDataValidation_Public_Virtual_New_set_Void_SetDataValidationRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665018);
			Request.NativeMethodInfoPtr_get_SortRange_Public_Virtual_New_get_SortRangeRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665019);
			Request.NativeMethodInfoPtr_set_SortRange_Public_Virtual_New_set_Void_SortRangeRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665020);
			Request.NativeMethodInfoPtr_get_TextToColumns_Public_Virtual_New_get_TextToColumnsRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665021);
			Request.NativeMethodInfoPtr_set_TextToColumns_Public_Virtual_New_set_Void_TextToColumnsRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665022);
			Request.NativeMethodInfoPtr_get_TrimWhitespace_Public_Virtual_New_get_TrimWhitespaceRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665023);
			Request.NativeMethodInfoPtr_set_TrimWhitespace_Public_Virtual_New_set_Void_TrimWhitespaceRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665024);
			Request.NativeMethodInfoPtr_get_UnmergeCells_Public_Virtual_New_get_UnmergeCellsRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665025);
			Request.NativeMethodInfoPtr_set_UnmergeCells_Public_Virtual_New_set_Void_UnmergeCellsRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665026);
			Request.NativeMethodInfoPtr_get_UpdateBanding_Public_Virtual_New_get_UpdateBandingRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665027);
			Request.NativeMethodInfoPtr_set_UpdateBanding_Public_Virtual_New_set_Void_UpdateBandingRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665028);
			Request.NativeMethodInfoPtr_get_UpdateBorders_Public_Virtual_New_get_UpdateBordersRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665029);
			Request.NativeMethodInfoPtr_set_UpdateBorders_Public_Virtual_New_set_Void_UpdateBordersRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665030);
			Request.NativeMethodInfoPtr_get_UpdateCells_Public_Virtual_New_get_UpdateCellsRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665031);
			Request.NativeMethodInfoPtr_set_UpdateCells_Public_Virtual_New_set_Void_UpdateCellsRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665032);
			Request.NativeMethodInfoPtr_get_UpdateChartSpec_Public_Virtual_New_get_UpdateChartSpecRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665033);
			Request.NativeMethodInfoPtr_set_UpdateChartSpec_Public_Virtual_New_set_Void_UpdateChartSpecRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665034);
			Request.NativeMethodInfoPtr_get_UpdateConditionalFormatRule_Public_Virtual_New_get_UpdateConditionalFormatRuleRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665035);
			Request.NativeMethodInfoPtr_set_UpdateConditionalFormatRule_Public_Virtual_New_set_Void_UpdateConditionalFormatRuleRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665036);
			Request.NativeMethodInfoPtr_get_UpdateDeveloperMetadata_Public_Virtual_New_get_UpdateDeveloperMetadataRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665037);
			Request.NativeMethodInfoPtr_set_UpdateDeveloperMetadata_Public_Virtual_New_set_Void_UpdateDeveloperMetadataRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665038);
			Request.NativeMethodInfoPtr_get_UpdateDimensionGroup_Public_Virtual_New_get_UpdateDimensionGroupRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665039);
			Request.NativeMethodInfoPtr_set_UpdateDimensionGroup_Public_Virtual_New_set_Void_UpdateDimensionGroupRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665040);
			Request.NativeMethodInfoPtr_get_UpdateDimensionProperties_Public_Virtual_New_get_UpdateDimensionPropertiesRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665041);
			Request.NativeMethodInfoPtr_set_UpdateDimensionProperties_Public_Virtual_New_set_Void_UpdateDimensionPropertiesRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665042);
			Request.NativeMethodInfoPtr_get_UpdateEmbeddedObjectPosition_Public_Virtual_New_get_UpdateEmbeddedObjectPositionRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665043);
			Request.NativeMethodInfoPtr_set_UpdateEmbeddedObjectPosition_Public_Virtual_New_set_Void_UpdateEmbeddedObjectPositionRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665044);
			Request.NativeMethodInfoPtr_get_UpdateFilterView_Public_Virtual_New_get_UpdateFilterViewRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665045);
			Request.NativeMethodInfoPtr_set_UpdateFilterView_Public_Virtual_New_set_Void_UpdateFilterViewRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665046);
			Request.NativeMethodInfoPtr_get_UpdateNamedRange_Public_Virtual_New_get_UpdateNamedRangeRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665047);
			Request.NativeMethodInfoPtr_set_UpdateNamedRange_Public_Virtual_New_set_Void_UpdateNamedRangeRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665048);
			Request.NativeMethodInfoPtr_get_UpdateProtectedRange_Public_Virtual_New_get_UpdateProtectedRangeRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665049);
			Request.NativeMethodInfoPtr_set_UpdateProtectedRange_Public_Virtual_New_set_Void_UpdateProtectedRangeRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665050);
			Request.NativeMethodInfoPtr_get_UpdateSheetProperties_Public_Virtual_New_get_UpdateSheetPropertiesRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665051);
			Request.NativeMethodInfoPtr_set_UpdateSheetProperties_Public_Virtual_New_set_Void_UpdateSheetPropertiesRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665052);
			Request.NativeMethodInfoPtr_get_UpdateSlicerSpec_Public_Virtual_New_get_UpdateSlicerSpecRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665053);
			Request.NativeMethodInfoPtr_set_UpdateSlicerSpec_Public_Virtual_New_set_Void_UpdateSlicerSpecRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665054);
			Request.NativeMethodInfoPtr_get_UpdateSpreadsheetProperties_Public_Virtual_New_get_UpdateSpreadsheetPropertiesRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665055);
			Request.NativeMethodInfoPtr_set_UpdateSpreadsheetProperties_Public_Virtual_New_set_Void_UpdateSpreadsheetPropertiesRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665056);
			Request.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665057);
			Request.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665058);
			Request.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Request>.NativeClassPtr, 100665059);
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06000BAB RID: 2987 RVA: 0x000384EC File Offset: 0x000366EC
		// (set) Token: 0x06000BAC RID: 2988 RVA: 0x00038538 File Offset: 0x00036738
		public unsafe virtual AddBandingRequest AddBanding
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_AddBanding_Public_Virtual_New_get_AddBandingRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AddBandingRequest>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_AddBanding_Public_Virtual_New_set_Void_AddBandingRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06000BAD RID: 2989 RVA: 0x00038588 File Offset: 0x00036788
		// (set) Token: 0x06000BAE RID: 2990 RVA: 0x000385D4 File Offset: 0x000367D4
		public unsafe virtual AddChartRequest AddChart
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_AddChart_Public_Virtual_New_get_AddChartRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AddChartRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_AddChart_Public_Virtual_New_set_Void_AddChartRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06000BAF RID: 2991 RVA: 0x00038624 File Offset: 0x00036824
		// (set) Token: 0x06000BB0 RID: 2992 RVA: 0x00038670 File Offset: 0x00036870
		public unsafe virtual AddConditionalFormatRuleRequest AddConditionalFormatRule
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_AddConditionalFormatRule_Public_Virtual_New_get_AddConditionalFormatRuleRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AddConditionalFormatRuleRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_AddConditionalFormatRule_Public_Virtual_New_set_Void_AddConditionalFormatRuleRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06000BB1 RID: 2993 RVA: 0x000386C0 File Offset: 0x000368C0
		// (set) Token: 0x06000BB2 RID: 2994 RVA: 0x0003870C File Offset: 0x0003690C
		public unsafe virtual AddDimensionGroupRequest AddDimensionGroup
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_AddDimensionGroup_Public_Virtual_New_get_AddDimensionGroupRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AddDimensionGroupRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_AddDimensionGroup_Public_Virtual_New_set_Void_AddDimensionGroupRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06000BB3 RID: 2995 RVA: 0x0003875C File Offset: 0x0003695C
		// (set) Token: 0x06000BB4 RID: 2996 RVA: 0x000387A8 File Offset: 0x000369A8
		public unsafe virtual AddFilterViewRequest AddFilterView
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_AddFilterView_Public_Virtual_New_get_AddFilterViewRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AddFilterViewRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_AddFilterView_Public_Virtual_New_set_Void_AddFilterViewRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06000BB5 RID: 2997 RVA: 0x000387F8 File Offset: 0x000369F8
		// (set) Token: 0x06000BB6 RID: 2998 RVA: 0x00038844 File Offset: 0x00036A44
		public unsafe virtual AddNamedRangeRequest AddNamedRange
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_AddNamedRange_Public_Virtual_New_get_AddNamedRangeRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AddNamedRangeRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_AddNamedRange_Public_Virtual_New_set_Void_AddNamedRangeRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06000BB7 RID: 2999 RVA: 0x00038894 File Offset: 0x00036A94
		// (set) Token: 0x06000BB8 RID: 3000 RVA: 0x000388E0 File Offset: 0x00036AE0
		public unsafe virtual AddProtectedRangeRequest AddProtectedRange
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_AddProtectedRange_Public_Virtual_New_get_AddProtectedRangeRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AddProtectedRangeRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_AddProtectedRange_Public_Virtual_New_set_Void_AddProtectedRangeRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06000BB9 RID: 3001 RVA: 0x00038930 File Offset: 0x00036B30
		// (set) Token: 0x06000BBA RID: 3002 RVA: 0x0003897C File Offset: 0x00036B7C
		public unsafe virtual AddSheetRequest AddSheet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_AddSheet_Public_Virtual_New_get_AddSheetRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AddSheetRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_AddSheet_Public_Virtual_New_set_Void_AddSheetRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06000BBB RID: 3003 RVA: 0x000389CC File Offset: 0x00036BCC
		// (set) Token: 0x06000BBC RID: 3004 RVA: 0x00038A18 File Offset: 0x00036C18
		public unsafe virtual AddSlicerRequest AddSlicer
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_AddSlicer_Public_Virtual_New_get_AddSlicerRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AddSlicerRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_AddSlicer_Public_Virtual_New_set_Void_AddSlicerRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06000BBD RID: 3005 RVA: 0x00038A68 File Offset: 0x00036C68
		// (set) Token: 0x06000BBE RID: 3006 RVA: 0x00038AB4 File Offset: 0x00036CB4
		public unsafe virtual AppendCellsRequest AppendCells
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_AppendCells_Public_Virtual_New_get_AppendCellsRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AppendCellsRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_AppendCells_Public_Virtual_New_set_Void_AppendCellsRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06000BBF RID: 3007 RVA: 0x00038B04 File Offset: 0x00036D04
		// (set) Token: 0x06000BC0 RID: 3008 RVA: 0x00038B50 File Offset: 0x00036D50
		public unsafe virtual AppendDimensionRequest AppendDimension
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_AppendDimension_Public_Virtual_New_get_AppendDimensionRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AppendDimensionRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_AppendDimension_Public_Virtual_New_set_Void_AppendDimensionRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06000BC1 RID: 3009 RVA: 0x00038BA0 File Offset: 0x00036DA0
		// (set) Token: 0x06000BC2 RID: 3010 RVA: 0x00038BEC File Offset: 0x00036DEC
		public unsafe virtual AutoFillRequest AutoFill
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_AutoFill_Public_Virtual_New_get_AutoFillRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AutoFillRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_AutoFill_Public_Virtual_New_set_Void_AutoFillRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06000BC3 RID: 3011 RVA: 0x00038C3C File Offset: 0x00036E3C
		// (set) Token: 0x06000BC4 RID: 3012 RVA: 0x00038C88 File Offset: 0x00036E88
		public unsafe virtual AutoResizeDimensionsRequest AutoResizeDimensions
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_AutoResizeDimensions_Public_Virtual_New_get_AutoResizeDimensionsRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AutoResizeDimensionsRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_AutoResizeDimensions_Public_Virtual_New_set_Void_AutoResizeDimensionsRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06000BC5 RID: 3013 RVA: 0x00038CD8 File Offset: 0x00036ED8
		// (set) Token: 0x06000BC6 RID: 3014 RVA: 0x00038D24 File Offset: 0x00036F24
		public unsafe virtual ClearBasicFilterRequest ClearBasicFilter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_ClearBasicFilter_Public_Virtual_New_get_ClearBasicFilterRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClearBasicFilterRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_ClearBasicFilter_Public_Virtual_New_set_Void_ClearBasicFilterRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06000BC7 RID: 3015 RVA: 0x00038D74 File Offset: 0x00036F74
		// (set) Token: 0x06000BC8 RID: 3016 RVA: 0x00038DC0 File Offset: 0x00036FC0
		public unsafe virtual CopyPasteRequest CopyPaste
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_CopyPaste_Public_Virtual_New_get_CopyPasteRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CopyPasteRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_CopyPaste_Public_Virtual_New_set_Void_CopyPasteRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06000BC9 RID: 3017 RVA: 0x00038E10 File Offset: 0x00037010
		// (set) Token: 0x06000BCA RID: 3018 RVA: 0x00038E5C File Offset: 0x0003705C
		public unsafe virtual CreateDeveloperMetadataRequest CreateDeveloperMetadata
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_CreateDeveloperMetadata_Public_Virtual_New_get_CreateDeveloperMetadataRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CreateDeveloperMetadataRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_CreateDeveloperMetadata_Public_Virtual_New_set_Void_CreateDeveloperMetadataRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06000BCB RID: 3019 RVA: 0x00038EAC File Offset: 0x000370AC
		// (set) Token: 0x06000BCC RID: 3020 RVA: 0x00038EF8 File Offset: 0x000370F8
		public unsafe virtual CutPasteRequest CutPaste
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_CutPaste_Public_Virtual_New_get_CutPasteRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CutPasteRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_CutPaste_Public_Virtual_New_set_Void_CutPasteRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06000BCD RID: 3021 RVA: 0x00038F48 File Offset: 0x00037148
		// (set) Token: 0x06000BCE RID: 3022 RVA: 0x00038F94 File Offset: 0x00037194
		public unsafe virtual DeleteBandingRequest DeleteBanding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_DeleteBanding_Public_Virtual_New_get_DeleteBandingRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeleteBandingRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_DeleteBanding_Public_Virtual_New_set_Void_DeleteBandingRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06000BCF RID: 3023 RVA: 0x00038FE4 File Offset: 0x000371E4
		// (set) Token: 0x06000BD0 RID: 3024 RVA: 0x00039030 File Offset: 0x00037230
		public unsafe virtual DeleteConditionalFormatRuleRequest DeleteConditionalFormatRule
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_DeleteConditionalFormatRule_Public_Virtual_New_get_DeleteConditionalFormatRuleRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeleteConditionalFormatRuleRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_DeleteConditionalFormatRule_Public_Virtual_New_set_Void_DeleteConditionalFormatRuleRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06000BD1 RID: 3025 RVA: 0x00039080 File Offset: 0x00037280
		// (set) Token: 0x06000BD2 RID: 3026 RVA: 0x000390CC File Offset: 0x000372CC
		public unsafe virtual DeleteDeveloperMetadataRequest DeleteDeveloperMetadata
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_DeleteDeveloperMetadata_Public_Virtual_New_get_DeleteDeveloperMetadataRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeleteDeveloperMetadataRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_DeleteDeveloperMetadata_Public_Virtual_New_set_Void_DeleteDeveloperMetadataRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06000BD3 RID: 3027 RVA: 0x0003911C File Offset: 0x0003731C
		// (set) Token: 0x06000BD4 RID: 3028 RVA: 0x00039168 File Offset: 0x00037368
		public unsafe virtual DeleteDimensionRequest DeleteDimension
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_DeleteDimension_Public_Virtual_New_get_DeleteDimensionRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeleteDimensionRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_DeleteDimension_Public_Virtual_New_set_Void_DeleteDimensionRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06000BD5 RID: 3029 RVA: 0x000391B8 File Offset: 0x000373B8
		// (set) Token: 0x06000BD6 RID: 3030 RVA: 0x00039204 File Offset: 0x00037404
		public unsafe virtual DeleteDimensionGroupRequest DeleteDimensionGroup
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_DeleteDimensionGroup_Public_Virtual_New_get_DeleteDimensionGroupRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeleteDimensionGroupRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_DeleteDimensionGroup_Public_Virtual_New_set_Void_DeleteDimensionGroupRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06000BD7 RID: 3031 RVA: 0x00039254 File Offset: 0x00037454
		// (set) Token: 0x06000BD8 RID: 3032 RVA: 0x000392A0 File Offset: 0x000374A0
		public unsafe virtual DeleteDuplicatesRequest DeleteDuplicates
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_DeleteDuplicates_Public_Virtual_New_get_DeleteDuplicatesRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeleteDuplicatesRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_DeleteDuplicates_Public_Virtual_New_set_Void_DeleteDuplicatesRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06000BD9 RID: 3033 RVA: 0x000392F0 File Offset: 0x000374F0
		// (set) Token: 0x06000BDA RID: 3034 RVA: 0x0003933C File Offset: 0x0003753C
		public unsafe virtual DeleteEmbeddedObjectRequest DeleteEmbeddedObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_DeleteEmbeddedObject_Public_Virtual_New_get_DeleteEmbeddedObjectRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeleteEmbeddedObjectRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_DeleteEmbeddedObject_Public_Virtual_New_set_Void_DeleteEmbeddedObjectRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06000BDB RID: 3035 RVA: 0x0003938C File Offset: 0x0003758C
		// (set) Token: 0x06000BDC RID: 3036 RVA: 0x000393D8 File Offset: 0x000375D8
		public unsafe virtual DeleteFilterViewRequest DeleteFilterView
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_DeleteFilterView_Public_Virtual_New_get_DeleteFilterViewRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeleteFilterViewRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_DeleteFilterView_Public_Virtual_New_set_Void_DeleteFilterViewRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06000BDD RID: 3037 RVA: 0x00039428 File Offset: 0x00037628
		// (set) Token: 0x06000BDE RID: 3038 RVA: 0x00039474 File Offset: 0x00037674
		public unsafe virtual DeleteNamedRangeRequest DeleteNamedRange
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 39587, RefRangeEnd = 39588, XrefRangeStart = 39587, XrefRangeEnd = 39588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_DeleteNamedRange_Public_Virtual_New_get_DeleteNamedRangeRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeleteNamedRangeRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_DeleteNamedRange_Public_Virtual_New_set_Void_DeleteNamedRangeRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06000BDF RID: 3039 RVA: 0x000394C4 File Offset: 0x000376C4
		// (set) Token: 0x06000BE0 RID: 3040 RVA: 0x00039510 File Offset: 0x00037710
		public unsafe virtual DeleteProtectedRangeRequest DeleteProtectedRange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_DeleteProtectedRange_Public_Virtual_New_get_DeleteProtectedRangeRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeleteProtectedRangeRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_DeleteProtectedRange_Public_Virtual_New_set_Void_DeleteProtectedRangeRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06000BE1 RID: 3041 RVA: 0x00039560 File Offset: 0x00037760
		// (set) Token: 0x06000BE2 RID: 3042 RVA: 0x000395AC File Offset: 0x000377AC
		public unsafe virtual DeleteRangeRequest DeleteRange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_DeleteRange_Public_Virtual_New_get_DeleteRangeRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeleteRangeRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_DeleteRange_Public_Virtual_New_set_Void_DeleteRangeRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06000BE3 RID: 3043 RVA: 0x000395FC File Offset: 0x000377FC
		// (set) Token: 0x06000BE4 RID: 3044 RVA: 0x00039648 File Offset: 0x00037848
		public unsafe virtual DeleteSheetRequest DeleteSheet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_DeleteSheet_Public_Virtual_New_get_DeleteSheetRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeleteSheetRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_DeleteSheet_Public_Virtual_New_set_Void_DeleteSheetRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06000BE5 RID: 3045 RVA: 0x00039698 File Offset: 0x00037898
		// (set) Token: 0x06000BE6 RID: 3046 RVA: 0x000396E4 File Offset: 0x000378E4
		public unsafe virtual DuplicateFilterViewRequest DuplicateFilterView
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_DuplicateFilterView_Public_Virtual_New_get_DuplicateFilterViewRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DuplicateFilterViewRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_DuplicateFilterView_Public_Virtual_New_set_Void_DuplicateFilterViewRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06000BE7 RID: 3047 RVA: 0x00039734 File Offset: 0x00037934
		// (set) Token: 0x06000BE8 RID: 3048 RVA: 0x00039780 File Offset: 0x00037980
		public unsafe virtual DuplicateSheetRequest DuplicateSheet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_DuplicateSheet_Public_Virtual_New_get_DuplicateSheetRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DuplicateSheetRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_DuplicateSheet_Public_Virtual_New_set_Void_DuplicateSheetRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06000BE9 RID: 3049 RVA: 0x000397D0 File Offset: 0x000379D0
		// (set) Token: 0x06000BEA RID: 3050 RVA: 0x0003981C File Offset: 0x00037A1C
		public unsafe virtual FindReplaceRequest FindReplace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_FindReplace_Public_Virtual_New_get_FindReplaceRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FindReplaceRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_FindReplace_Public_Virtual_New_set_Void_FindReplaceRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06000BEB RID: 3051 RVA: 0x0003986C File Offset: 0x00037A6C
		// (set) Token: 0x06000BEC RID: 3052 RVA: 0x000398B8 File Offset: 0x00037AB8
		public unsafe virtual InsertDimensionRequest InsertDimension
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_InsertDimension_Public_Virtual_New_get_InsertDimensionRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InsertDimensionRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_InsertDimension_Public_Virtual_New_set_Void_InsertDimensionRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06000BED RID: 3053 RVA: 0x00039908 File Offset: 0x00037B08
		// (set) Token: 0x06000BEE RID: 3054 RVA: 0x00039954 File Offset: 0x00037B54
		public unsafe virtual InsertRangeRequest InsertRange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_InsertRange_Public_Virtual_New_get_InsertRangeRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InsertRangeRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_InsertRange_Public_Virtual_New_set_Void_InsertRangeRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06000BEF RID: 3055 RVA: 0x000399A4 File Offset: 0x00037BA4
		// (set) Token: 0x06000BF0 RID: 3056 RVA: 0x000399F0 File Offset: 0x00037BF0
		public unsafe virtual MergeCellsRequest MergeCells
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_MergeCells_Public_Virtual_New_get_MergeCellsRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MergeCellsRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_MergeCells_Public_Virtual_New_set_Void_MergeCellsRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06000BF1 RID: 3057 RVA: 0x00039A40 File Offset: 0x00037C40
		// (set) Token: 0x06000BF2 RID: 3058 RVA: 0x00039A8C File Offset: 0x00037C8C
		public unsafe virtual MoveDimensionRequest MoveDimension
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_MoveDimension_Public_Virtual_New_get_MoveDimensionRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MoveDimensionRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_MoveDimension_Public_Virtual_New_set_Void_MoveDimensionRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06000BF3 RID: 3059 RVA: 0x00039ADC File Offset: 0x00037CDC
		// (set) Token: 0x06000BF4 RID: 3060 RVA: 0x00039B28 File Offset: 0x00037D28
		public unsafe virtual PasteDataRequest PasteData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_PasteData_Public_Virtual_New_get_PasteDataRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PasteDataRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_PasteData_Public_Virtual_New_set_Void_PasteDataRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06000BF5 RID: 3061 RVA: 0x00039B78 File Offset: 0x00037D78
		// (set) Token: 0x06000BF6 RID: 3062 RVA: 0x00039BC4 File Offset: 0x00037DC4
		public unsafe virtual RandomizeRangeRequest RandomizeRange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_RandomizeRange_Public_Virtual_New_get_RandomizeRangeRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RandomizeRangeRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_RandomizeRange_Public_Virtual_New_set_Void_RandomizeRangeRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06000BF7 RID: 3063 RVA: 0x00039C14 File Offset: 0x00037E14
		// (set) Token: 0x06000BF8 RID: 3064 RVA: 0x00039C60 File Offset: 0x00037E60
		public unsafe virtual RepeatCellRequest RepeatCell
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_RepeatCell_Public_Virtual_New_get_RepeatCellRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RepeatCellRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_RepeatCell_Public_Virtual_New_set_Void_RepeatCellRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06000BF9 RID: 3065 RVA: 0x00039CB0 File Offset: 0x00037EB0
		// (set) Token: 0x06000BFA RID: 3066 RVA: 0x00039CFC File Offset: 0x00037EFC
		public unsafe virtual SetBasicFilterRequest SetBasicFilter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_SetBasicFilter_Public_Virtual_New_get_SetBasicFilterRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SetBasicFilterRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118923, XrefRangeEnd = 1118924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_SetBasicFilter_Public_Virtual_New_set_Void_SetBasicFilterRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06000BFB RID: 3067 RVA: 0x00039D4C File Offset: 0x00037F4C
		// (set) Token: 0x06000BFC RID: 3068 RVA: 0x00039D98 File Offset: 0x00037F98
		public unsafe virtual SetDataValidationRequest SetDataValidation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_SetDataValidation_Public_Virtual_New_get_SetDataValidationRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SetDataValidationRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118924, XrefRangeEnd = 1118925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_SetDataValidation_Public_Virtual_New_set_Void_SetDataValidationRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06000BFD RID: 3069 RVA: 0x00039DE8 File Offset: 0x00037FE8
		// (set) Token: 0x06000BFE RID: 3070 RVA: 0x00039E34 File Offset: 0x00038034
		public unsafe virtual SortRangeRequest SortRange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_SortRange_Public_Virtual_New_get_SortRangeRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortRangeRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_SortRange_Public_Virtual_New_set_Void_SortRangeRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06000BFF RID: 3071 RVA: 0x00039E84 File Offset: 0x00038084
		// (set) Token: 0x06000C00 RID: 3072 RVA: 0x00039ED0 File Offset: 0x000380D0
		public unsafe virtual TextToColumnsRequest TextToColumns
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_TextToColumns_Public_Virtual_New_get_TextToColumnsRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextToColumnsRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_TextToColumns_Public_Virtual_New_set_Void_TextToColumnsRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06000C01 RID: 3073 RVA: 0x00039F20 File Offset: 0x00038120
		// (set) Token: 0x06000C02 RID: 3074 RVA: 0x00039F6C File Offset: 0x0003816C
		public unsafe virtual TrimWhitespaceRequest TrimWhitespace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_TrimWhitespace_Public_Virtual_New_get_TrimWhitespaceRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrimWhitespaceRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_TrimWhitespace_Public_Virtual_New_set_Void_TrimWhitespaceRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06000C03 RID: 3075 RVA: 0x00039FBC File Offset: 0x000381BC
		// (set) Token: 0x06000C04 RID: 3076 RVA: 0x0003A008 File Offset: 0x00038208
		public unsafe virtual UnmergeCellsRequest UnmergeCells
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_UnmergeCells_Public_Virtual_New_get_UnmergeCellsRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnmergeCellsRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_UnmergeCells_Public_Virtual_New_set_Void_UnmergeCellsRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06000C05 RID: 3077 RVA: 0x0003A058 File Offset: 0x00038258
		// (set) Token: 0x06000C06 RID: 3078 RVA: 0x0003A0A4 File Offset: 0x000382A4
		public unsafe virtual UpdateBandingRequest UpdateBanding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_UpdateBanding_Public_Virtual_New_get_UpdateBandingRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UpdateBandingRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_UpdateBanding_Public_Virtual_New_set_Void_UpdateBandingRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06000C07 RID: 3079 RVA: 0x0003A0F4 File Offset: 0x000382F4
		// (set) Token: 0x06000C08 RID: 3080 RVA: 0x0003A140 File Offset: 0x00038340
		public unsafe virtual UpdateBordersRequest UpdateBorders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_UpdateBorders_Public_Virtual_New_get_UpdateBordersRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UpdateBordersRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_UpdateBorders_Public_Virtual_New_set_Void_UpdateBordersRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06000C09 RID: 3081 RVA: 0x0003A190 File Offset: 0x00038390
		// (set) Token: 0x06000C0A RID: 3082 RVA: 0x0003A1DC File Offset: 0x000383DC
		public unsafe virtual UpdateCellsRequest UpdateCells
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_UpdateCells_Public_Virtual_New_get_UpdateCellsRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UpdateCellsRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_UpdateCells_Public_Virtual_New_set_Void_UpdateCellsRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06000C0B RID: 3083 RVA: 0x0003A22C File Offset: 0x0003842C
		// (set) Token: 0x06000C0C RID: 3084 RVA: 0x0003A278 File Offset: 0x00038478
		public unsafe virtual UpdateChartSpecRequest UpdateChartSpec
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_UpdateChartSpec_Public_Virtual_New_get_UpdateChartSpecRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UpdateChartSpecRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118925, XrefRangeEnd = 1118926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_UpdateChartSpec_Public_Virtual_New_set_Void_UpdateChartSpecRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06000C0D RID: 3085 RVA: 0x0003A2C8 File Offset: 0x000384C8
		// (set) Token: 0x06000C0E RID: 3086 RVA: 0x0003A314 File Offset: 0x00038514
		public unsafe virtual UpdateConditionalFormatRuleRequest UpdateConditionalFormatRule
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_UpdateConditionalFormatRule_Public_Virtual_New_get_UpdateConditionalFormatRuleRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UpdateConditionalFormatRuleRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_UpdateConditionalFormatRule_Public_Virtual_New_set_Void_UpdateConditionalFormatRuleRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06000C0F RID: 3087 RVA: 0x0003A364 File Offset: 0x00038564
		// (set) Token: 0x06000C10 RID: 3088 RVA: 0x0003A3B0 File Offset: 0x000385B0
		public unsafe virtual UpdateDeveloperMetadataRequest UpdateDeveloperMetadata
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_UpdateDeveloperMetadata_Public_Virtual_New_get_UpdateDeveloperMetadataRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UpdateDeveloperMetadataRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118926, XrefRangeEnd = 1118927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_UpdateDeveloperMetadata_Public_Virtual_New_set_Void_UpdateDeveloperMetadataRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06000C11 RID: 3089 RVA: 0x0003A400 File Offset: 0x00038600
		// (set) Token: 0x06000C12 RID: 3090 RVA: 0x0003A44C File Offset: 0x0003864C
		public unsafe virtual UpdateDimensionGroupRequest UpdateDimensionGroup
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_UpdateDimensionGroup_Public_Virtual_New_get_UpdateDimensionGroupRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UpdateDimensionGroupRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118927, XrefRangeEnd = 1118928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_UpdateDimensionGroup_Public_Virtual_New_set_Void_UpdateDimensionGroupRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06000C13 RID: 3091 RVA: 0x0003A49C File Offset: 0x0003869C
		// (set) Token: 0x06000C14 RID: 3092 RVA: 0x0003A4E8 File Offset: 0x000386E8
		public unsafe virtual UpdateDimensionPropertiesRequest UpdateDimensionProperties
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_UpdateDimensionProperties_Public_Virtual_New_get_UpdateDimensionPropertiesRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UpdateDimensionPropertiesRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118928, XrefRangeEnd = 1118929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_UpdateDimensionProperties_Public_Virtual_New_set_Void_UpdateDimensionPropertiesRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06000C15 RID: 3093 RVA: 0x0003A538 File Offset: 0x00038738
		// (set) Token: 0x06000C16 RID: 3094 RVA: 0x0003A584 File Offset: 0x00038784
		public unsafe virtual UpdateEmbeddedObjectPositionRequest UpdateEmbeddedObjectPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_UpdateEmbeddedObjectPosition_Public_Virtual_New_get_UpdateEmbeddedObjectPositionRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UpdateEmbeddedObjectPositionRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_UpdateEmbeddedObjectPosition_Public_Virtual_New_set_Void_UpdateEmbeddedObjectPositionRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06000C17 RID: 3095 RVA: 0x0003A5D4 File Offset: 0x000387D4
		// (set) Token: 0x06000C18 RID: 3096 RVA: 0x0003A620 File Offset: 0x00038820
		public unsafe virtual UpdateFilterViewRequest UpdateFilterView
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_UpdateFilterView_Public_Virtual_New_get_UpdateFilterViewRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UpdateFilterViewRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_UpdateFilterView_Public_Virtual_New_set_Void_UpdateFilterViewRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06000C19 RID: 3097 RVA: 0x0003A670 File Offset: 0x00038870
		// (set) Token: 0x06000C1A RID: 3098 RVA: 0x0003A6BC File Offset: 0x000388BC
		public unsafe virtual UpdateNamedRangeRequest UpdateNamedRange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_UpdateNamedRange_Public_Virtual_New_get_UpdateNamedRangeRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UpdateNamedRangeRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118929, XrefRangeEnd = 1118930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_UpdateNamedRange_Public_Virtual_New_set_Void_UpdateNamedRangeRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06000C1B RID: 3099 RVA: 0x0003A70C File Offset: 0x0003890C
		// (set) Token: 0x06000C1C RID: 3100 RVA: 0x0003A758 File Offset: 0x00038958
		public unsafe virtual UpdateProtectedRangeRequest UpdateProtectedRange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_UpdateProtectedRange_Public_Virtual_New_get_UpdateProtectedRangeRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UpdateProtectedRangeRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118930, XrefRangeEnd = 1118931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_UpdateProtectedRange_Public_Virtual_New_set_Void_UpdateProtectedRangeRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06000C1D RID: 3101 RVA: 0x0003A7A8 File Offset: 0x000389A8
		// (set) Token: 0x06000C1E RID: 3102 RVA: 0x0003A7F4 File Offset: 0x000389F4
		public unsafe virtual UpdateSheetPropertiesRequest UpdateSheetProperties
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_UpdateSheetProperties_Public_Virtual_New_get_UpdateSheetPropertiesRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UpdateSheetPropertiesRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118931, XrefRangeEnd = 1118932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_UpdateSheetProperties_Public_Virtual_New_set_Void_UpdateSheetPropertiesRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06000C1F RID: 3103 RVA: 0x0003A844 File Offset: 0x00038A44
		// (set) Token: 0x06000C20 RID: 3104 RVA: 0x0003A890 File Offset: 0x00038A90
		public unsafe virtual UpdateSlicerSpecRequest UpdateSlicerSpec
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_UpdateSlicerSpec_Public_Virtual_New_get_UpdateSlicerSpecRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UpdateSlicerSpecRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118932, XrefRangeEnd = 1118933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_UpdateSlicerSpec_Public_Virtual_New_set_Void_UpdateSlicerSpecRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06000C21 RID: 3105 RVA: 0x0003A8E0 File Offset: 0x00038AE0
		// (set) Token: 0x06000C22 RID: 3106 RVA: 0x0003A92C File Offset: 0x00038B2C
		public unsafe virtual UpdateSpreadsheetPropertiesRequest UpdateSpreadsheetProperties
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_UpdateSpreadsheetProperties_Public_Virtual_New_get_UpdateSpreadsheetPropertiesRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UpdateSpreadsheetPropertiesRequest>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118933, XrefRangeEnd = 1118965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_UpdateSpreadsheetProperties_Public_Virtual_New_set_Void_UpdateSpreadsheetPropertiesRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06000C23 RID: 3107 RVA: 0x0003A97C File Offset: 0x00038B7C
		// (set) Token: 0x06000C24 RID: 3108 RVA: 0x0003A9C0 File Offset: 0x00038BC0
		public unsafe virtual string ETag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118965, XrefRangeEnd = 1118966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Request.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x0003AA10 File Offset: 0x00038C10
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Request()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Request>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Request.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x000079D7 File Offset: 0x00005BD7
		public Request(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06000C27 RID: 3111 RVA: 0x0003AA4C File Offset: 0x00038C4C
		// (set) Token: 0x06000C28 RID: 3112 RVA: 0x000079E0 File Offset: 0x00005BE0
		public unsafe AddBandingRequest _AddBanding_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__AddBanding_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddBandingRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__AddBanding_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06000C29 RID: 3113 RVA: 0x0003AA7C File Offset: 0x00038C7C
		// (set) Token: 0x06000C2A RID: 3114 RVA: 0x000079FF File Offset: 0x00005BFF
		public unsafe AddChartRequest _AddChart_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__AddChart_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddChartRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__AddChart_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06000C2B RID: 3115 RVA: 0x0003AAAC File Offset: 0x00038CAC
		// (set) Token: 0x06000C2C RID: 3116 RVA: 0x00007A1E File Offset: 0x00005C1E
		public unsafe AddConditionalFormatRuleRequest _AddConditionalFormatRule_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__AddConditionalFormatRule_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddConditionalFormatRuleRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__AddConditionalFormatRule_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06000C2D RID: 3117 RVA: 0x0003AADC File Offset: 0x00038CDC
		// (set) Token: 0x06000C2E RID: 3118 RVA: 0x00007A3D File Offset: 0x00005C3D
		public unsafe AddDimensionGroupRequest _AddDimensionGroup_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__AddDimensionGroup_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddDimensionGroupRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__AddDimensionGroup_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06000C2F RID: 3119 RVA: 0x0003AB0C File Offset: 0x00038D0C
		// (set) Token: 0x06000C30 RID: 3120 RVA: 0x00007A5C File Offset: 0x00005C5C
		public unsafe AddFilterViewRequest _AddFilterView_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__AddFilterView_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddFilterViewRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__AddFilterView_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06000C31 RID: 3121 RVA: 0x0003AB3C File Offset: 0x00038D3C
		// (set) Token: 0x06000C32 RID: 3122 RVA: 0x00007A7B File Offset: 0x00005C7B
		public unsafe AddNamedRangeRequest _AddNamedRange_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__AddNamedRange_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddNamedRangeRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__AddNamedRange_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06000C33 RID: 3123 RVA: 0x0003AB6C File Offset: 0x00038D6C
		// (set) Token: 0x06000C34 RID: 3124 RVA: 0x00007A9A File Offset: 0x00005C9A
		public unsafe AddProtectedRangeRequest _AddProtectedRange_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__AddProtectedRange_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddProtectedRangeRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__AddProtectedRange_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06000C35 RID: 3125 RVA: 0x0003AB9C File Offset: 0x00038D9C
		// (set) Token: 0x06000C36 RID: 3126 RVA: 0x00007AB9 File Offset: 0x00005CB9
		public unsafe AddSheetRequest _AddSheet_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__AddSheet_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddSheetRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__AddSheet_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06000C37 RID: 3127 RVA: 0x0003ABCC File Offset: 0x00038DCC
		// (set) Token: 0x06000C38 RID: 3128 RVA: 0x00007AD8 File Offset: 0x00005CD8
		public unsafe AddSlicerRequest _AddSlicer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__AddSlicer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddSlicerRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__AddSlicer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06000C39 RID: 3129 RVA: 0x0003ABFC File Offset: 0x00038DFC
		// (set) Token: 0x06000C3A RID: 3130 RVA: 0x00007AF7 File Offset: 0x00005CF7
		public unsafe AppendCellsRequest _AppendCells_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__AppendCells_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AppendCellsRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__AppendCells_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06000C3B RID: 3131 RVA: 0x0003AC2C File Offset: 0x00038E2C
		// (set) Token: 0x06000C3C RID: 3132 RVA: 0x00007B16 File Offset: 0x00005D16
		public unsafe AppendDimensionRequest _AppendDimension_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__AppendDimension_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AppendDimensionRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__AppendDimension_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06000C3D RID: 3133 RVA: 0x0003AC5C File Offset: 0x00038E5C
		// (set) Token: 0x06000C3E RID: 3134 RVA: 0x00007B35 File Offset: 0x00005D35
		public unsafe AutoFillRequest _AutoFill_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__AutoFill_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AutoFillRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__AutoFill_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06000C3F RID: 3135 RVA: 0x0003AC8C File Offset: 0x00038E8C
		// (set) Token: 0x06000C40 RID: 3136 RVA: 0x00007B54 File Offset: 0x00005D54
		public unsafe AutoResizeDimensionsRequest _AutoResizeDimensions_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__AutoResizeDimensions_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AutoResizeDimensionsRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__AutoResizeDimensions_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06000C41 RID: 3137 RVA: 0x0003ACBC File Offset: 0x00038EBC
		// (set) Token: 0x06000C42 RID: 3138 RVA: 0x00007B73 File Offset: 0x00005D73
		public unsafe ClearBasicFilterRequest _ClearBasicFilter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__ClearBasicFilter_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClearBasicFilterRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__ClearBasicFilter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06000C43 RID: 3139 RVA: 0x0003ACEC File Offset: 0x00038EEC
		// (set) Token: 0x06000C44 RID: 3140 RVA: 0x00007B92 File Offset: 0x00005D92
		public unsafe CopyPasteRequest _CopyPaste_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__CopyPaste_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CopyPasteRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__CopyPaste_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06000C45 RID: 3141 RVA: 0x0003AD1C File Offset: 0x00038F1C
		// (set) Token: 0x06000C46 RID: 3142 RVA: 0x00007BB1 File Offset: 0x00005DB1
		public unsafe CreateDeveloperMetadataRequest _CreateDeveloperMetadata_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__CreateDeveloperMetadata_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CreateDeveloperMetadataRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__CreateDeveloperMetadata_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06000C47 RID: 3143 RVA: 0x0003AD4C File Offset: 0x00038F4C
		// (set) Token: 0x06000C48 RID: 3144 RVA: 0x00007BD0 File Offset: 0x00005DD0
		public unsafe CutPasteRequest _CutPaste_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__CutPaste_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CutPasteRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__CutPaste_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06000C49 RID: 3145 RVA: 0x0003AD7C File Offset: 0x00038F7C
		// (set) Token: 0x06000C4A RID: 3146 RVA: 0x00007BEF File Offset: 0x00005DEF
		public unsafe DeleteBandingRequest _DeleteBanding_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__DeleteBanding_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeleteBandingRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__DeleteBanding_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06000C4B RID: 3147 RVA: 0x0003ADAC File Offset: 0x00038FAC
		// (set) Token: 0x06000C4C RID: 3148 RVA: 0x00007C0E File Offset: 0x00005E0E
		public unsafe DeleteConditionalFormatRuleRequest _DeleteConditionalFormatRule_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__DeleteConditionalFormatRule_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeleteConditionalFormatRuleRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__DeleteConditionalFormatRule_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06000C4D RID: 3149 RVA: 0x0003ADDC File Offset: 0x00038FDC
		// (set) Token: 0x06000C4E RID: 3150 RVA: 0x00007C2D File Offset: 0x00005E2D
		public unsafe DeleteDeveloperMetadataRequest _DeleteDeveloperMetadata_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__DeleteDeveloperMetadata_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeleteDeveloperMetadataRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__DeleteDeveloperMetadata_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06000C4F RID: 3151 RVA: 0x0003AE0C File Offset: 0x0003900C
		// (set) Token: 0x06000C50 RID: 3152 RVA: 0x00007C4C File Offset: 0x00005E4C
		public unsafe DeleteDimensionRequest _DeleteDimension_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__DeleteDimension_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeleteDimensionRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__DeleteDimension_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06000C51 RID: 3153 RVA: 0x0003AE3C File Offset: 0x0003903C
		// (set) Token: 0x06000C52 RID: 3154 RVA: 0x00007C6B File Offset: 0x00005E6B
		public unsafe DeleteDimensionGroupRequest _DeleteDimensionGroup_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__DeleteDimensionGroup_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeleteDimensionGroupRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__DeleteDimensionGroup_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06000C53 RID: 3155 RVA: 0x0003AE6C File Offset: 0x0003906C
		// (set) Token: 0x06000C54 RID: 3156 RVA: 0x00007C8A File Offset: 0x00005E8A
		public unsafe DeleteDuplicatesRequest _DeleteDuplicates_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__DeleteDuplicates_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeleteDuplicatesRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__DeleteDuplicates_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06000C55 RID: 3157 RVA: 0x0003AE9C File Offset: 0x0003909C
		// (set) Token: 0x06000C56 RID: 3158 RVA: 0x00007CA9 File Offset: 0x00005EA9
		public unsafe DeleteEmbeddedObjectRequest _DeleteEmbeddedObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__DeleteEmbeddedObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeleteEmbeddedObjectRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__DeleteEmbeddedObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06000C57 RID: 3159 RVA: 0x0003AECC File Offset: 0x000390CC
		// (set) Token: 0x06000C58 RID: 3160 RVA: 0x00007CC8 File Offset: 0x00005EC8
		public unsafe DeleteFilterViewRequest _DeleteFilterView_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__DeleteFilterView_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeleteFilterViewRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__DeleteFilterView_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06000C59 RID: 3161 RVA: 0x0003AEFC File Offset: 0x000390FC
		// (set) Token: 0x06000C5A RID: 3162 RVA: 0x00007CE7 File Offset: 0x00005EE7
		public unsafe DeleteNamedRangeRequest _DeleteNamedRange_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__DeleteNamedRange_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeleteNamedRangeRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__DeleteNamedRange_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06000C5B RID: 3163 RVA: 0x0003AF2C File Offset: 0x0003912C
		// (set) Token: 0x06000C5C RID: 3164 RVA: 0x00007D06 File Offset: 0x00005F06
		public unsafe DeleteProtectedRangeRequest _DeleteProtectedRange_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__DeleteProtectedRange_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeleteProtectedRangeRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__DeleteProtectedRange_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06000C5D RID: 3165 RVA: 0x0003AF5C File Offset: 0x0003915C
		// (set) Token: 0x06000C5E RID: 3166 RVA: 0x00007D25 File Offset: 0x00005F25
		public unsafe DeleteRangeRequest _DeleteRange_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__DeleteRange_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeleteRangeRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__DeleteRange_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06000C5F RID: 3167 RVA: 0x0003AF8C File Offset: 0x0003918C
		// (set) Token: 0x06000C60 RID: 3168 RVA: 0x00007D44 File Offset: 0x00005F44
		public unsafe DeleteSheetRequest _DeleteSheet_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__DeleteSheet_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeleteSheetRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__DeleteSheet_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06000C61 RID: 3169 RVA: 0x0003AFBC File Offset: 0x000391BC
		// (set) Token: 0x06000C62 RID: 3170 RVA: 0x00007D63 File Offset: 0x00005F63
		public unsafe DuplicateFilterViewRequest _DuplicateFilterView_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__DuplicateFilterView_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DuplicateFilterViewRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__DuplicateFilterView_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06000C63 RID: 3171 RVA: 0x0003AFEC File Offset: 0x000391EC
		// (set) Token: 0x06000C64 RID: 3172 RVA: 0x00007D82 File Offset: 0x00005F82
		public unsafe DuplicateSheetRequest _DuplicateSheet_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__DuplicateSheet_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DuplicateSheetRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__DuplicateSheet_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06000C65 RID: 3173 RVA: 0x0003B01C File Offset: 0x0003921C
		// (set) Token: 0x06000C66 RID: 3174 RVA: 0x00007DA1 File Offset: 0x00005FA1
		public unsafe FindReplaceRequest _FindReplace_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__FindReplace_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FindReplaceRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__FindReplace_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06000C67 RID: 3175 RVA: 0x0003B04C File Offset: 0x0003924C
		// (set) Token: 0x06000C68 RID: 3176 RVA: 0x00007DC0 File Offset: 0x00005FC0
		public unsafe InsertDimensionRequest _InsertDimension_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__InsertDimension_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InsertDimensionRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__InsertDimension_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06000C69 RID: 3177 RVA: 0x0003B07C File Offset: 0x0003927C
		// (set) Token: 0x06000C6A RID: 3178 RVA: 0x00007DDF File Offset: 0x00005FDF
		public unsafe InsertRangeRequest _InsertRange_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__InsertRange_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InsertRangeRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__InsertRange_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06000C6B RID: 3179 RVA: 0x0003B0AC File Offset: 0x000392AC
		// (set) Token: 0x06000C6C RID: 3180 RVA: 0x00007DFE File Offset: 0x00005FFE
		public unsafe MergeCellsRequest _MergeCells_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__MergeCells_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MergeCellsRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__MergeCells_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06000C6D RID: 3181 RVA: 0x0003B0DC File Offset: 0x000392DC
		// (set) Token: 0x06000C6E RID: 3182 RVA: 0x00007E1D File Offset: 0x0000601D
		public unsafe MoveDimensionRequest _MoveDimension_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__MoveDimension_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveDimensionRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__MoveDimension_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06000C6F RID: 3183 RVA: 0x0003B10C File Offset: 0x0003930C
		// (set) Token: 0x06000C70 RID: 3184 RVA: 0x00007E3C File Offset: 0x0000603C
		public unsafe PasteDataRequest _PasteData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__PasteData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PasteDataRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__PasteData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06000C71 RID: 3185 RVA: 0x0003B13C File Offset: 0x0003933C
		// (set) Token: 0x06000C72 RID: 3186 RVA: 0x00007E5B File Offset: 0x0000605B
		public unsafe RandomizeRangeRequest _RandomizeRange_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__RandomizeRange_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RandomizeRangeRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__RandomizeRange_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06000C73 RID: 3187 RVA: 0x0003B16C File Offset: 0x0003936C
		// (set) Token: 0x06000C74 RID: 3188 RVA: 0x00007E7A File Offset: 0x0000607A
		public unsafe RepeatCellRequest _RepeatCell_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__RepeatCell_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RepeatCellRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__RepeatCell_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06000C75 RID: 3189 RVA: 0x0003B19C File Offset: 0x0003939C
		// (set) Token: 0x06000C76 RID: 3190 RVA: 0x00007E99 File Offset: 0x00006099
		public unsafe SetBasicFilterRequest _SetBasicFilter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__SetBasicFilter_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetBasicFilterRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__SetBasicFilter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06000C77 RID: 3191 RVA: 0x0003B1CC File Offset: 0x000393CC
		// (set) Token: 0x06000C78 RID: 3192 RVA: 0x00007EB8 File Offset: 0x000060B8
		public unsafe SetDataValidationRequest _SetDataValidation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__SetDataValidation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetDataValidationRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__SetDataValidation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06000C79 RID: 3193 RVA: 0x0003B1FC File Offset: 0x000393FC
		// (set) Token: 0x06000C7A RID: 3194 RVA: 0x00007ED7 File Offset: 0x000060D7
		public unsafe SortRangeRequest _SortRange_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__SortRange_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortRangeRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__SortRange_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06000C7B RID: 3195 RVA: 0x0003B22C File Offset: 0x0003942C
		// (set) Token: 0x06000C7C RID: 3196 RVA: 0x00007EF6 File Offset: 0x000060F6
		public unsafe TextToColumnsRequest _TextToColumns_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__TextToColumns_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextToColumnsRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__TextToColumns_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06000C7D RID: 3197 RVA: 0x0003B25C File Offset: 0x0003945C
		// (set) Token: 0x06000C7E RID: 3198 RVA: 0x00007F15 File Offset: 0x00006115
		public unsafe TrimWhitespaceRequest _TrimWhitespace_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__TrimWhitespace_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrimWhitespaceRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__TrimWhitespace_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06000C7F RID: 3199 RVA: 0x0003B28C File Offset: 0x0003948C
		// (set) Token: 0x06000C80 RID: 3200 RVA: 0x00007F34 File Offset: 0x00006134
		public unsafe UnmergeCellsRequest _UnmergeCells_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__UnmergeCells_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnmergeCellsRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__UnmergeCells_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06000C81 RID: 3201 RVA: 0x0003B2BC File Offset: 0x000394BC
		// (set) Token: 0x06000C82 RID: 3202 RVA: 0x00007F53 File Offset: 0x00006153
		public unsafe UpdateBandingRequest _UpdateBanding_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__UpdateBanding_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpdateBandingRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__UpdateBanding_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06000C83 RID: 3203 RVA: 0x0003B2EC File Offset: 0x000394EC
		// (set) Token: 0x06000C84 RID: 3204 RVA: 0x00007F72 File Offset: 0x00006172
		public unsafe UpdateBordersRequest _UpdateBorders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__UpdateBorders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpdateBordersRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__UpdateBorders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06000C85 RID: 3205 RVA: 0x0003B31C File Offset: 0x0003951C
		// (set) Token: 0x06000C86 RID: 3206 RVA: 0x00007F91 File Offset: 0x00006191
		public unsafe UpdateCellsRequest _UpdateCells_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__UpdateCells_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpdateCellsRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__UpdateCells_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06000C87 RID: 3207 RVA: 0x0003B34C File Offset: 0x0003954C
		// (set) Token: 0x06000C88 RID: 3208 RVA: 0x00007FB0 File Offset: 0x000061B0
		public unsafe UpdateChartSpecRequest _UpdateChartSpec_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__UpdateChartSpec_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpdateChartSpecRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__UpdateChartSpec_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06000C89 RID: 3209 RVA: 0x0003B37C File Offset: 0x0003957C
		// (set) Token: 0x06000C8A RID: 3210 RVA: 0x00007FCF File Offset: 0x000061CF
		public unsafe UpdateConditionalFormatRuleRequest _UpdateConditionalFormatRule_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__UpdateConditionalFormatRule_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpdateConditionalFormatRuleRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__UpdateConditionalFormatRule_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06000C8B RID: 3211 RVA: 0x0003B3AC File Offset: 0x000395AC
		// (set) Token: 0x06000C8C RID: 3212 RVA: 0x00007FEE File Offset: 0x000061EE
		public unsafe UpdateDeveloperMetadataRequest _UpdateDeveloperMetadata_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__UpdateDeveloperMetadata_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpdateDeveloperMetadataRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__UpdateDeveloperMetadata_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06000C8D RID: 3213 RVA: 0x0003B3DC File Offset: 0x000395DC
		// (set) Token: 0x06000C8E RID: 3214 RVA: 0x0000800D File Offset: 0x0000620D
		public unsafe UpdateDimensionGroupRequest _UpdateDimensionGroup_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__UpdateDimensionGroup_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpdateDimensionGroupRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__UpdateDimensionGroup_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06000C8F RID: 3215 RVA: 0x0003B40C File Offset: 0x0003960C
		// (set) Token: 0x06000C90 RID: 3216 RVA: 0x0000802C File Offset: 0x0000622C
		public unsafe UpdateDimensionPropertiesRequest _UpdateDimensionProperties_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__UpdateDimensionProperties_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpdateDimensionPropertiesRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__UpdateDimensionProperties_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06000C91 RID: 3217 RVA: 0x0003B43C File Offset: 0x0003963C
		// (set) Token: 0x06000C92 RID: 3218 RVA: 0x0000804B File Offset: 0x0000624B
		public unsafe UpdateEmbeddedObjectPositionRequest _UpdateEmbeddedObjectPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__UpdateEmbeddedObjectPosition_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpdateEmbeddedObjectPositionRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__UpdateEmbeddedObjectPosition_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06000C93 RID: 3219 RVA: 0x0003B46C File Offset: 0x0003966C
		// (set) Token: 0x06000C94 RID: 3220 RVA: 0x0000806A File Offset: 0x0000626A
		public unsafe UpdateFilterViewRequest _UpdateFilterView_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__UpdateFilterView_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpdateFilterViewRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__UpdateFilterView_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06000C95 RID: 3221 RVA: 0x0003B49C File Offset: 0x0003969C
		// (set) Token: 0x06000C96 RID: 3222 RVA: 0x00008089 File Offset: 0x00006289
		public unsafe UpdateNamedRangeRequest _UpdateNamedRange_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__UpdateNamedRange_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpdateNamedRangeRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__UpdateNamedRange_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06000C97 RID: 3223 RVA: 0x0003B4CC File Offset: 0x000396CC
		// (set) Token: 0x06000C98 RID: 3224 RVA: 0x000080A8 File Offset: 0x000062A8
		public unsafe UpdateProtectedRangeRequest _UpdateProtectedRange_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__UpdateProtectedRange_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpdateProtectedRangeRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__UpdateProtectedRange_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06000C99 RID: 3225 RVA: 0x0003B4FC File Offset: 0x000396FC
		// (set) Token: 0x06000C9A RID: 3226 RVA: 0x000080C7 File Offset: 0x000062C7
		public unsafe UpdateSheetPropertiesRequest _UpdateSheetProperties_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__UpdateSheetProperties_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpdateSheetPropertiesRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__UpdateSheetProperties_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06000C9B RID: 3227 RVA: 0x0003B52C File Offset: 0x0003972C
		// (set) Token: 0x06000C9C RID: 3228 RVA: 0x000080E6 File Offset: 0x000062E6
		public unsafe UpdateSlicerSpecRequest _UpdateSlicerSpec_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__UpdateSlicerSpec_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpdateSlicerSpecRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__UpdateSlicerSpec_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06000C9D RID: 3229 RVA: 0x0003B55C File Offset: 0x0003975C
		// (set) Token: 0x06000C9E RID: 3230 RVA: 0x00008105 File Offset: 0x00006305
		public unsafe UpdateSpreadsheetPropertiesRequest _UpdateSpreadsheetProperties_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__UpdateSpreadsheetProperties_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpdateSpreadsheetPropertiesRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__UpdateSpreadsheetProperties_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06000C9F RID: 3231 RVA: 0x0003B58C File Offset: 0x0003978C
		// (set) Token: 0x06000CA0 RID: 3232 RVA: 0x00008124 File Offset: 0x00006324
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Request.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000803 RID: 2051
		private static readonly IntPtr NativeFieldInfoPtr__AddBanding_k__BackingField;

		// Token: 0x04000804 RID: 2052
		private static readonly IntPtr NativeFieldInfoPtr__AddChart_k__BackingField;

		// Token: 0x04000805 RID: 2053
		private static readonly IntPtr NativeFieldInfoPtr__AddConditionalFormatRule_k__BackingField;

		// Token: 0x04000806 RID: 2054
		private static readonly IntPtr NativeFieldInfoPtr__AddDimensionGroup_k__BackingField;

		// Token: 0x04000807 RID: 2055
		private static readonly IntPtr NativeFieldInfoPtr__AddFilterView_k__BackingField;

		// Token: 0x04000808 RID: 2056
		private static readonly IntPtr NativeFieldInfoPtr__AddNamedRange_k__BackingField;

		// Token: 0x04000809 RID: 2057
		private static readonly IntPtr NativeFieldInfoPtr__AddProtectedRange_k__BackingField;

		// Token: 0x0400080A RID: 2058
		private static readonly IntPtr NativeFieldInfoPtr__AddSheet_k__BackingField;

		// Token: 0x0400080B RID: 2059
		private static readonly IntPtr NativeFieldInfoPtr__AddSlicer_k__BackingField;

		// Token: 0x0400080C RID: 2060
		private static readonly IntPtr NativeFieldInfoPtr__AppendCells_k__BackingField;

		// Token: 0x0400080D RID: 2061
		private static readonly IntPtr NativeFieldInfoPtr__AppendDimension_k__BackingField;

		// Token: 0x0400080E RID: 2062
		private static readonly IntPtr NativeFieldInfoPtr__AutoFill_k__BackingField;

		// Token: 0x0400080F RID: 2063
		private static readonly IntPtr NativeFieldInfoPtr__AutoResizeDimensions_k__BackingField;

		// Token: 0x04000810 RID: 2064
		private static readonly IntPtr NativeFieldInfoPtr__ClearBasicFilter_k__BackingField;

		// Token: 0x04000811 RID: 2065
		private static readonly IntPtr NativeFieldInfoPtr__CopyPaste_k__BackingField;

		// Token: 0x04000812 RID: 2066
		private static readonly IntPtr NativeFieldInfoPtr__CreateDeveloperMetadata_k__BackingField;

		// Token: 0x04000813 RID: 2067
		private static readonly IntPtr NativeFieldInfoPtr__CutPaste_k__BackingField;

		// Token: 0x04000814 RID: 2068
		private static readonly IntPtr NativeFieldInfoPtr__DeleteBanding_k__BackingField;

		// Token: 0x04000815 RID: 2069
		private static readonly IntPtr NativeFieldInfoPtr__DeleteConditionalFormatRule_k__BackingField;

		// Token: 0x04000816 RID: 2070
		private static readonly IntPtr NativeFieldInfoPtr__DeleteDeveloperMetadata_k__BackingField;

		// Token: 0x04000817 RID: 2071
		private static readonly IntPtr NativeFieldInfoPtr__DeleteDimension_k__BackingField;

		// Token: 0x04000818 RID: 2072
		private static readonly IntPtr NativeFieldInfoPtr__DeleteDimensionGroup_k__BackingField;

		// Token: 0x04000819 RID: 2073
		private static readonly IntPtr NativeFieldInfoPtr__DeleteDuplicates_k__BackingField;

		// Token: 0x0400081A RID: 2074
		private static readonly IntPtr NativeFieldInfoPtr__DeleteEmbeddedObject_k__BackingField;

		// Token: 0x0400081B RID: 2075
		private static readonly IntPtr NativeFieldInfoPtr__DeleteFilterView_k__BackingField;

		// Token: 0x0400081C RID: 2076
		private static readonly IntPtr NativeFieldInfoPtr__DeleteNamedRange_k__BackingField;

		// Token: 0x0400081D RID: 2077
		private static readonly IntPtr NativeFieldInfoPtr__DeleteProtectedRange_k__BackingField;

		// Token: 0x0400081E RID: 2078
		private static readonly IntPtr NativeFieldInfoPtr__DeleteRange_k__BackingField;

		// Token: 0x0400081F RID: 2079
		private static readonly IntPtr NativeFieldInfoPtr__DeleteSheet_k__BackingField;

		// Token: 0x04000820 RID: 2080
		private static readonly IntPtr NativeFieldInfoPtr__DuplicateFilterView_k__BackingField;

		// Token: 0x04000821 RID: 2081
		private static readonly IntPtr NativeFieldInfoPtr__DuplicateSheet_k__BackingField;

		// Token: 0x04000822 RID: 2082
		private static readonly IntPtr NativeFieldInfoPtr__FindReplace_k__BackingField;

		// Token: 0x04000823 RID: 2083
		private static readonly IntPtr NativeFieldInfoPtr__InsertDimension_k__BackingField;

		// Token: 0x04000824 RID: 2084
		private static readonly IntPtr NativeFieldInfoPtr__InsertRange_k__BackingField;

		// Token: 0x04000825 RID: 2085
		private static readonly IntPtr NativeFieldInfoPtr__MergeCells_k__BackingField;

		// Token: 0x04000826 RID: 2086
		private static readonly IntPtr NativeFieldInfoPtr__MoveDimension_k__BackingField;

		// Token: 0x04000827 RID: 2087
		private static readonly IntPtr NativeFieldInfoPtr__PasteData_k__BackingField;

		// Token: 0x04000828 RID: 2088
		private static readonly IntPtr NativeFieldInfoPtr__RandomizeRange_k__BackingField;

		// Token: 0x04000829 RID: 2089
		private static readonly IntPtr NativeFieldInfoPtr__RepeatCell_k__BackingField;

		// Token: 0x0400082A RID: 2090
		private static readonly IntPtr NativeFieldInfoPtr__SetBasicFilter_k__BackingField;

		// Token: 0x0400082B RID: 2091
		private static readonly IntPtr NativeFieldInfoPtr__SetDataValidation_k__BackingField;

		// Token: 0x0400082C RID: 2092
		private static readonly IntPtr NativeFieldInfoPtr__SortRange_k__BackingField;

		// Token: 0x0400082D RID: 2093
		private static readonly IntPtr NativeFieldInfoPtr__TextToColumns_k__BackingField;

		// Token: 0x0400082E RID: 2094
		private static readonly IntPtr NativeFieldInfoPtr__TrimWhitespace_k__BackingField;

		// Token: 0x0400082F RID: 2095
		private static readonly IntPtr NativeFieldInfoPtr__UnmergeCells_k__BackingField;

		// Token: 0x04000830 RID: 2096
		private static readonly IntPtr NativeFieldInfoPtr__UpdateBanding_k__BackingField;

		// Token: 0x04000831 RID: 2097
		private static readonly IntPtr NativeFieldInfoPtr__UpdateBorders_k__BackingField;

		// Token: 0x04000832 RID: 2098
		private static readonly IntPtr NativeFieldInfoPtr__UpdateCells_k__BackingField;

		// Token: 0x04000833 RID: 2099
		private static readonly IntPtr NativeFieldInfoPtr__UpdateChartSpec_k__BackingField;

		// Token: 0x04000834 RID: 2100
		private static readonly IntPtr NativeFieldInfoPtr__UpdateConditionalFormatRule_k__BackingField;

		// Token: 0x04000835 RID: 2101
		private static readonly IntPtr NativeFieldInfoPtr__UpdateDeveloperMetadata_k__BackingField;

		// Token: 0x04000836 RID: 2102
		private static readonly IntPtr NativeFieldInfoPtr__UpdateDimensionGroup_k__BackingField;

		// Token: 0x04000837 RID: 2103
		private static readonly IntPtr NativeFieldInfoPtr__UpdateDimensionProperties_k__BackingField;

		// Token: 0x04000838 RID: 2104
		private static readonly IntPtr NativeFieldInfoPtr__UpdateEmbeddedObjectPosition_k__BackingField;

		// Token: 0x04000839 RID: 2105
		private static readonly IntPtr NativeFieldInfoPtr__UpdateFilterView_k__BackingField;

		// Token: 0x0400083A RID: 2106
		private static readonly IntPtr NativeFieldInfoPtr__UpdateNamedRange_k__BackingField;

		// Token: 0x0400083B RID: 2107
		private static readonly IntPtr NativeFieldInfoPtr__UpdateProtectedRange_k__BackingField;

		// Token: 0x0400083C RID: 2108
		private static readonly IntPtr NativeFieldInfoPtr__UpdateSheetProperties_k__BackingField;

		// Token: 0x0400083D RID: 2109
		private static readonly IntPtr NativeFieldInfoPtr__UpdateSlicerSpec_k__BackingField;

		// Token: 0x0400083E RID: 2110
		private static readonly IntPtr NativeFieldInfoPtr__UpdateSpreadsheetProperties_k__BackingField;

		// Token: 0x0400083F RID: 2111
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000840 RID: 2112
		private static readonly IntPtr NativeMethodInfoPtr_get_AddBanding_Public_Virtual_New_get_AddBandingRequest_0;

		// Token: 0x04000841 RID: 2113
		private static readonly IntPtr NativeMethodInfoPtr_set_AddBanding_Public_Virtual_New_set_Void_AddBandingRequest_0;

		// Token: 0x04000842 RID: 2114
		private static readonly IntPtr NativeMethodInfoPtr_get_AddChart_Public_Virtual_New_get_AddChartRequest_0;

		// Token: 0x04000843 RID: 2115
		private static readonly IntPtr NativeMethodInfoPtr_set_AddChart_Public_Virtual_New_set_Void_AddChartRequest_0;

		// Token: 0x04000844 RID: 2116
		private static readonly IntPtr NativeMethodInfoPtr_get_AddConditionalFormatRule_Public_Virtual_New_get_AddConditionalFormatRuleRequest_0;

		// Token: 0x04000845 RID: 2117
		private static readonly IntPtr NativeMethodInfoPtr_set_AddConditionalFormatRule_Public_Virtual_New_set_Void_AddConditionalFormatRuleRequest_0;

		// Token: 0x04000846 RID: 2118
		private static readonly IntPtr NativeMethodInfoPtr_get_AddDimensionGroup_Public_Virtual_New_get_AddDimensionGroupRequest_0;

		// Token: 0x04000847 RID: 2119
		private static readonly IntPtr NativeMethodInfoPtr_set_AddDimensionGroup_Public_Virtual_New_set_Void_AddDimensionGroupRequest_0;

		// Token: 0x04000848 RID: 2120
		private static readonly IntPtr NativeMethodInfoPtr_get_AddFilterView_Public_Virtual_New_get_AddFilterViewRequest_0;

		// Token: 0x04000849 RID: 2121
		private static readonly IntPtr NativeMethodInfoPtr_set_AddFilterView_Public_Virtual_New_set_Void_AddFilterViewRequest_0;

		// Token: 0x0400084A RID: 2122
		private static readonly IntPtr NativeMethodInfoPtr_get_AddNamedRange_Public_Virtual_New_get_AddNamedRangeRequest_0;

		// Token: 0x0400084B RID: 2123
		private static readonly IntPtr NativeMethodInfoPtr_set_AddNamedRange_Public_Virtual_New_set_Void_AddNamedRangeRequest_0;

		// Token: 0x0400084C RID: 2124
		private static readonly IntPtr NativeMethodInfoPtr_get_AddProtectedRange_Public_Virtual_New_get_AddProtectedRangeRequest_0;

		// Token: 0x0400084D RID: 2125
		private static readonly IntPtr NativeMethodInfoPtr_set_AddProtectedRange_Public_Virtual_New_set_Void_AddProtectedRangeRequest_0;

		// Token: 0x0400084E RID: 2126
		private static readonly IntPtr NativeMethodInfoPtr_get_AddSheet_Public_Virtual_New_get_AddSheetRequest_0;

		// Token: 0x0400084F RID: 2127
		private static readonly IntPtr NativeMethodInfoPtr_set_AddSheet_Public_Virtual_New_set_Void_AddSheetRequest_0;

		// Token: 0x04000850 RID: 2128
		private static readonly IntPtr NativeMethodInfoPtr_get_AddSlicer_Public_Virtual_New_get_AddSlicerRequest_0;

		// Token: 0x04000851 RID: 2129
		private static readonly IntPtr NativeMethodInfoPtr_set_AddSlicer_Public_Virtual_New_set_Void_AddSlicerRequest_0;

		// Token: 0x04000852 RID: 2130
		private static readonly IntPtr NativeMethodInfoPtr_get_AppendCells_Public_Virtual_New_get_AppendCellsRequest_0;

		// Token: 0x04000853 RID: 2131
		private static readonly IntPtr NativeMethodInfoPtr_set_AppendCells_Public_Virtual_New_set_Void_AppendCellsRequest_0;

		// Token: 0x04000854 RID: 2132
		private static readonly IntPtr NativeMethodInfoPtr_get_AppendDimension_Public_Virtual_New_get_AppendDimensionRequest_0;

		// Token: 0x04000855 RID: 2133
		private static readonly IntPtr NativeMethodInfoPtr_set_AppendDimension_Public_Virtual_New_set_Void_AppendDimensionRequest_0;

		// Token: 0x04000856 RID: 2134
		private static readonly IntPtr NativeMethodInfoPtr_get_AutoFill_Public_Virtual_New_get_AutoFillRequest_0;

		// Token: 0x04000857 RID: 2135
		private static readonly IntPtr NativeMethodInfoPtr_set_AutoFill_Public_Virtual_New_set_Void_AutoFillRequest_0;

		// Token: 0x04000858 RID: 2136
		private static readonly IntPtr NativeMethodInfoPtr_get_AutoResizeDimensions_Public_Virtual_New_get_AutoResizeDimensionsRequest_0;

		// Token: 0x04000859 RID: 2137
		private static readonly IntPtr NativeMethodInfoPtr_set_AutoResizeDimensions_Public_Virtual_New_set_Void_AutoResizeDimensionsRequest_0;

		// Token: 0x0400085A RID: 2138
		private static readonly IntPtr NativeMethodInfoPtr_get_ClearBasicFilter_Public_Virtual_New_get_ClearBasicFilterRequest_0;

		// Token: 0x0400085B RID: 2139
		private static readonly IntPtr NativeMethodInfoPtr_set_ClearBasicFilter_Public_Virtual_New_set_Void_ClearBasicFilterRequest_0;

		// Token: 0x0400085C RID: 2140
		private static readonly IntPtr NativeMethodInfoPtr_get_CopyPaste_Public_Virtual_New_get_CopyPasteRequest_0;

		// Token: 0x0400085D RID: 2141
		private static readonly IntPtr NativeMethodInfoPtr_set_CopyPaste_Public_Virtual_New_set_Void_CopyPasteRequest_0;

		// Token: 0x0400085E RID: 2142
		private static readonly IntPtr NativeMethodInfoPtr_get_CreateDeveloperMetadata_Public_Virtual_New_get_CreateDeveloperMetadataRequest_0;

		// Token: 0x0400085F RID: 2143
		private static readonly IntPtr NativeMethodInfoPtr_set_CreateDeveloperMetadata_Public_Virtual_New_set_Void_CreateDeveloperMetadataRequest_0;

		// Token: 0x04000860 RID: 2144
		private static readonly IntPtr NativeMethodInfoPtr_get_CutPaste_Public_Virtual_New_get_CutPasteRequest_0;

		// Token: 0x04000861 RID: 2145
		private static readonly IntPtr NativeMethodInfoPtr_set_CutPaste_Public_Virtual_New_set_Void_CutPasteRequest_0;

		// Token: 0x04000862 RID: 2146
		private static readonly IntPtr NativeMethodInfoPtr_get_DeleteBanding_Public_Virtual_New_get_DeleteBandingRequest_0;

		// Token: 0x04000863 RID: 2147
		private static readonly IntPtr NativeMethodInfoPtr_set_DeleteBanding_Public_Virtual_New_set_Void_DeleteBandingRequest_0;

		// Token: 0x04000864 RID: 2148
		private static readonly IntPtr NativeMethodInfoPtr_get_DeleteConditionalFormatRule_Public_Virtual_New_get_DeleteConditionalFormatRuleRequest_0;

		// Token: 0x04000865 RID: 2149
		private static readonly IntPtr NativeMethodInfoPtr_set_DeleteConditionalFormatRule_Public_Virtual_New_set_Void_DeleteConditionalFormatRuleRequest_0;

		// Token: 0x04000866 RID: 2150
		private static readonly IntPtr NativeMethodInfoPtr_get_DeleteDeveloperMetadata_Public_Virtual_New_get_DeleteDeveloperMetadataRequest_0;

		// Token: 0x04000867 RID: 2151
		private static readonly IntPtr NativeMethodInfoPtr_set_DeleteDeveloperMetadata_Public_Virtual_New_set_Void_DeleteDeveloperMetadataRequest_0;

		// Token: 0x04000868 RID: 2152
		private static readonly IntPtr NativeMethodInfoPtr_get_DeleteDimension_Public_Virtual_New_get_DeleteDimensionRequest_0;

		// Token: 0x04000869 RID: 2153
		private static readonly IntPtr NativeMethodInfoPtr_set_DeleteDimension_Public_Virtual_New_set_Void_DeleteDimensionRequest_0;

		// Token: 0x0400086A RID: 2154
		private static readonly IntPtr NativeMethodInfoPtr_get_DeleteDimensionGroup_Public_Virtual_New_get_DeleteDimensionGroupRequest_0;

		// Token: 0x0400086B RID: 2155
		private static readonly IntPtr NativeMethodInfoPtr_set_DeleteDimensionGroup_Public_Virtual_New_set_Void_DeleteDimensionGroupRequest_0;

		// Token: 0x0400086C RID: 2156
		private static readonly IntPtr NativeMethodInfoPtr_get_DeleteDuplicates_Public_Virtual_New_get_DeleteDuplicatesRequest_0;

		// Token: 0x0400086D RID: 2157
		private static readonly IntPtr NativeMethodInfoPtr_set_DeleteDuplicates_Public_Virtual_New_set_Void_DeleteDuplicatesRequest_0;

		// Token: 0x0400086E RID: 2158
		private static readonly IntPtr NativeMethodInfoPtr_get_DeleteEmbeddedObject_Public_Virtual_New_get_DeleteEmbeddedObjectRequest_0;

		// Token: 0x0400086F RID: 2159
		private static readonly IntPtr NativeMethodInfoPtr_set_DeleteEmbeddedObject_Public_Virtual_New_set_Void_DeleteEmbeddedObjectRequest_0;

		// Token: 0x04000870 RID: 2160
		private static readonly IntPtr NativeMethodInfoPtr_get_DeleteFilterView_Public_Virtual_New_get_DeleteFilterViewRequest_0;

		// Token: 0x04000871 RID: 2161
		private static readonly IntPtr NativeMethodInfoPtr_set_DeleteFilterView_Public_Virtual_New_set_Void_DeleteFilterViewRequest_0;

		// Token: 0x04000872 RID: 2162
		private static readonly IntPtr NativeMethodInfoPtr_get_DeleteNamedRange_Public_Virtual_New_get_DeleteNamedRangeRequest_0;

		// Token: 0x04000873 RID: 2163
		private static readonly IntPtr NativeMethodInfoPtr_set_DeleteNamedRange_Public_Virtual_New_set_Void_DeleteNamedRangeRequest_0;

		// Token: 0x04000874 RID: 2164
		private static readonly IntPtr NativeMethodInfoPtr_get_DeleteProtectedRange_Public_Virtual_New_get_DeleteProtectedRangeRequest_0;

		// Token: 0x04000875 RID: 2165
		private static readonly IntPtr NativeMethodInfoPtr_set_DeleteProtectedRange_Public_Virtual_New_set_Void_DeleteProtectedRangeRequest_0;

		// Token: 0x04000876 RID: 2166
		private static readonly IntPtr NativeMethodInfoPtr_get_DeleteRange_Public_Virtual_New_get_DeleteRangeRequest_0;

		// Token: 0x04000877 RID: 2167
		private static readonly IntPtr NativeMethodInfoPtr_set_DeleteRange_Public_Virtual_New_set_Void_DeleteRangeRequest_0;

		// Token: 0x04000878 RID: 2168
		private static readonly IntPtr NativeMethodInfoPtr_get_DeleteSheet_Public_Virtual_New_get_DeleteSheetRequest_0;

		// Token: 0x04000879 RID: 2169
		private static readonly IntPtr NativeMethodInfoPtr_set_DeleteSheet_Public_Virtual_New_set_Void_DeleteSheetRequest_0;

		// Token: 0x0400087A RID: 2170
		private static readonly IntPtr NativeMethodInfoPtr_get_DuplicateFilterView_Public_Virtual_New_get_DuplicateFilterViewRequest_0;

		// Token: 0x0400087B RID: 2171
		private static readonly IntPtr NativeMethodInfoPtr_set_DuplicateFilterView_Public_Virtual_New_set_Void_DuplicateFilterViewRequest_0;

		// Token: 0x0400087C RID: 2172
		private static readonly IntPtr NativeMethodInfoPtr_get_DuplicateSheet_Public_Virtual_New_get_DuplicateSheetRequest_0;

		// Token: 0x0400087D RID: 2173
		private static readonly IntPtr NativeMethodInfoPtr_set_DuplicateSheet_Public_Virtual_New_set_Void_DuplicateSheetRequest_0;

		// Token: 0x0400087E RID: 2174
		private static readonly IntPtr NativeMethodInfoPtr_get_FindReplace_Public_Virtual_New_get_FindReplaceRequest_0;

		// Token: 0x0400087F RID: 2175
		private static readonly IntPtr NativeMethodInfoPtr_set_FindReplace_Public_Virtual_New_set_Void_FindReplaceRequest_0;

		// Token: 0x04000880 RID: 2176
		private static readonly IntPtr NativeMethodInfoPtr_get_InsertDimension_Public_Virtual_New_get_InsertDimensionRequest_0;

		// Token: 0x04000881 RID: 2177
		private static readonly IntPtr NativeMethodInfoPtr_set_InsertDimension_Public_Virtual_New_set_Void_InsertDimensionRequest_0;

		// Token: 0x04000882 RID: 2178
		private static readonly IntPtr NativeMethodInfoPtr_get_InsertRange_Public_Virtual_New_get_InsertRangeRequest_0;

		// Token: 0x04000883 RID: 2179
		private static readonly IntPtr NativeMethodInfoPtr_set_InsertRange_Public_Virtual_New_set_Void_InsertRangeRequest_0;

		// Token: 0x04000884 RID: 2180
		private static readonly IntPtr NativeMethodInfoPtr_get_MergeCells_Public_Virtual_New_get_MergeCellsRequest_0;

		// Token: 0x04000885 RID: 2181
		private static readonly IntPtr NativeMethodInfoPtr_set_MergeCells_Public_Virtual_New_set_Void_MergeCellsRequest_0;

		// Token: 0x04000886 RID: 2182
		private static readonly IntPtr NativeMethodInfoPtr_get_MoveDimension_Public_Virtual_New_get_MoveDimensionRequest_0;

		// Token: 0x04000887 RID: 2183
		private static readonly IntPtr NativeMethodInfoPtr_set_MoveDimension_Public_Virtual_New_set_Void_MoveDimensionRequest_0;

		// Token: 0x04000888 RID: 2184
		private static readonly IntPtr NativeMethodInfoPtr_get_PasteData_Public_Virtual_New_get_PasteDataRequest_0;

		// Token: 0x04000889 RID: 2185
		private static readonly IntPtr NativeMethodInfoPtr_set_PasteData_Public_Virtual_New_set_Void_PasteDataRequest_0;

		// Token: 0x0400088A RID: 2186
		private static readonly IntPtr NativeMethodInfoPtr_get_RandomizeRange_Public_Virtual_New_get_RandomizeRangeRequest_0;

		// Token: 0x0400088B RID: 2187
		private static readonly IntPtr NativeMethodInfoPtr_set_RandomizeRange_Public_Virtual_New_set_Void_RandomizeRangeRequest_0;

		// Token: 0x0400088C RID: 2188
		private static readonly IntPtr NativeMethodInfoPtr_get_RepeatCell_Public_Virtual_New_get_RepeatCellRequest_0;

		// Token: 0x0400088D RID: 2189
		private static readonly IntPtr NativeMethodInfoPtr_set_RepeatCell_Public_Virtual_New_set_Void_RepeatCellRequest_0;

		// Token: 0x0400088E RID: 2190
		private static readonly IntPtr NativeMethodInfoPtr_get_SetBasicFilter_Public_Virtual_New_get_SetBasicFilterRequest_0;

		// Token: 0x0400088F RID: 2191
		private static readonly IntPtr NativeMethodInfoPtr_set_SetBasicFilter_Public_Virtual_New_set_Void_SetBasicFilterRequest_0;

		// Token: 0x04000890 RID: 2192
		private static readonly IntPtr NativeMethodInfoPtr_get_SetDataValidation_Public_Virtual_New_get_SetDataValidationRequest_0;

		// Token: 0x04000891 RID: 2193
		private static readonly IntPtr NativeMethodInfoPtr_set_SetDataValidation_Public_Virtual_New_set_Void_SetDataValidationRequest_0;

		// Token: 0x04000892 RID: 2194
		private static readonly IntPtr NativeMethodInfoPtr_get_SortRange_Public_Virtual_New_get_SortRangeRequest_0;

		// Token: 0x04000893 RID: 2195
		private static readonly IntPtr NativeMethodInfoPtr_set_SortRange_Public_Virtual_New_set_Void_SortRangeRequest_0;

		// Token: 0x04000894 RID: 2196
		private static readonly IntPtr NativeMethodInfoPtr_get_TextToColumns_Public_Virtual_New_get_TextToColumnsRequest_0;

		// Token: 0x04000895 RID: 2197
		private static readonly IntPtr NativeMethodInfoPtr_set_TextToColumns_Public_Virtual_New_set_Void_TextToColumnsRequest_0;

		// Token: 0x04000896 RID: 2198
		private static readonly IntPtr NativeMethodInfoPtr_get_TrimWhitespace_Public_Virtual_New_get_TrimWhitespaceRequest_0;

		// Token: 0x04000897 RID: 2199
		private static readonly IntPtr NativeMethodInfoPtr_set_TrimWhitespace_Public_Virtual_New_set_Void_TrimWhitespaceRequest_0;

		// Token: 0x04000898 RID: 2200
		private static readonly IntPtr NativeMethodInfoPtr_get_UnmergeCells_Public_Virtual_New_get_UnmergeCellsRequest_0;

		// Token: 0x04000899 RID: 2201
		private static readonly IntPtr NativeMethodInfoPtr_set_UnmergeCells_Public_Virtual_New_set_Void_UnmergeCellsRequest_0;

		// Token: 0x0400089A RID: 2202
		private static readonly IntPtr NativeMethodInfoPtr_get_UpdateBanding_Public_Virtual_New_get_UpdateBandingRequest_0;

		// Token: 0x0400089B RID: 2203
		private static readonly IntPtr NativeMethodInfoPtr_set_UpdateBanding_Public_Virtual_New_set_Void_UpdateBandingRequest_0;

		// Token: 0x0400089C RID: 2204
		private static readonly IntPtr NativeMethodInfoPtr_get_UpdateBorders_Public_Virtual_New_get_UpdateBordersRequest_0;

		// Token: 0x0400089D RID: 2205
		private static readonly IntPtr NativeMethodInfoPtr_set_UpdateBorders_Public_Virtual_New_set_Void_UpdateBordersRequest_0;

		// Token: 0x0400089E RID: 2206
		private static readonly IntPtr NativeMethodInfoPtr_get_UpdateCells_Public_Virtual_New_get_UpdateCellsRequest_0;

		// Token: 0x0400089F RID: 2207
		private static readonly IntPtr NativeMethodInfoPtr_set_UpdateCells_Public_Virtual_New_set_Void_UpdateCellsRequest_0;

		// Token: 0x040008A0 RID: 2208
		private static readonly IntPtr NativeMethodInfoPtr_get_UpdateChartSpec_Public_Virtual_New_get_UpdateChartSpecRequest_0;

		// Token: 0x040008A1 RID: 2209
		private static readonly IntPtr NativeMethodInfoPtr_set_UpdateChartSpec_Public_Virtual_New_set_Void_UpdateChartSpecRequest_0;

		// Token: 0x040008A2 RID: 2210
		private static readonly IntPtr NativeMethodInfoPtr_get_UpdateConditionalFormatRule_Public_Virtual_New_get_UpdateConditionalFormatRuleRequest_0;

		// Token: 0x040008A3 RID: 2211
		private static readonly IntPtr NativeMethodInfoPtr_set_UpdateConditionalFormatRule_Public_Virtual_New_set_Void_UpdateConditionalFormatRuleRequest_0;

		// Token: 0x040008A4 RID: 2212
		private static readonly IntPtr NativeMethodInfoPtr_get_UpdateDeveloperMetadata_Public_Virtual_New_get_UpdateDeveloperMetadataRequest_0;

		// Token: 0x040008A5 RID: 2213
		private static readonly IntPtr NativeMethodInfoPtr_set_UpdateDeveloperMetadata_Public_Virtual_New_set_Void_UpdateDeveloperMetadataRequest_0;

		// Token: 0x040008A6 RID: 2214
		private static readonly IntPtr NativeMethodInfoPtr_get_UpdateDimensionGroup_Public_Virtual_New_get_UpdateDimensionGroupRequest_0;

		// Token: 0x040008A7 RID: 2215
		private static readonly IntPtr NativeMethodInfoPtr_set_UpdateDimensionGroup_Public_Virtual_New_set_Void_UpdateDimensionGroupRequest_0;

		// Token: 0x040008A8 RID: 2216
		private static readonly IntPtr NativeMethodInfoPtr_get_UpdateDimensionProperties_Public_Virtual_New_get_UpdateDimensionPropertiesRequest_0;

		// Token: 0x040008A9 RID: 2217
		private static readonly IntPtr NativeMethodInfoPtr_set_UpdateDimensionProperties_Public_Virtual_New_set_Void_UpdateDimensionPropertiesRequest_0;

		// Token: 0x040008AA RID: 2218
		private static readonly IntPtr NativeMethodInfoPtr_get_UpdateEmbeddedObjectPosition_Public_Virtual_New_get_UpdateEmbeddedObjectPositionRequest_0;

		// Token: 0x040008AB RID: 2219
		private static readonly IntPtr NativeMethodInfoPtr_set_UpdateEmbeddedObjectPosition_Public_Virtual_New_set_Void_UpdateEmbeddedObjectPositionRequest_0;

		// Token: 0x040008AC RID: 2220
		private static readonly IntPtr NativeMethodInfoPtr_get_UpdateFilterView_Public_Virtual_New_get_UpdateFilterViewRequest_0;

		// Token: 0x040008AD RID: 2221
		private static readonly IntPtr NativeMethodInfoPtr_set_UpdateFilterView_Public_Virtual_New_set_Void_UpdateFilterViewRequest_0;

		// Token: 0x040008AE RID: 2222
		private static readonly IntPtr NativeMethodInfoPtr_get_UpdateNamedRange_Public_Virtual_New_get_UpdateNamedRangeRequest_0;

		// Token: 0x040008AF RID: 2223
		private static readonly IntPtr NativeMethodInfoPtr_set_UpdateNamedRange_Public_Virtual_New_set_Void_UpdateNamedRangeRequest_0;

		// Token: 0x040008B0 RID: 2224
		private static readonly IntPtr NativeMethodInfoPtr_get_UpdateProtectedRange_Public_Virtual_New_get_UpdateProtectedRangeRequest_0;

		// Token: 0x040008B1 RID: 2225
		private static readonly IntPtr NativeMethodInfoPtr_set_UpdateProtectedRange_Public_Virtual_New_set_Void_UpdateProtectedRangeRequest_0;

		// Token: 0x040008B2 RID: 2226
		private static readonly IntPtr NativeMethodInfoPtr_get_UpdateSheetProperties_Public_Virtual_New_get_UpdateSheetPropertiesRequest_0;

		// Token: 0x040008B3 RID: 2227
		private static readonly IntPtr NativeMethodInfoPtr_set_UpdateSheetProperties_Public_Virtual_New_set_Void_UpdateSheetPropertiesRequest_0;

		// Token: 0x040008B4 RID: 2228
		private static readonly IntPtr NativeMethodInfoPtr_get_UpdateSlicerSpec_Public_Virtual_New_get_UpdateSlicerSpecRequest_0;

		// Token: 0x040008B5 RID: 2229
		private static readonly IntPtr NativeMethodInfoPtr_set_UpdateSlicerSpec_Public_Virtual_New_set_Void_UpdateSlicerSpecRequest_0;

		// Token: 0x040008B6 RID: 2230
		private static readonly IntPtr NativeMethodInfoPtr_get_UpdateSpreadsheetProperties_Public_Virtual_New_get_UpdateSpreadsheetPropertiesRequest_0;

		// Token: 0x040008B7 RID: 2231
		private static readonly IntPtr NativeMethodInfoPtr_set_UpdateSpreadsheetProperties_Public_Virtual_New_set_Void_UpdateSpreadsheetPropertiesRequest_0;

		// Token: 0x040008B8 RID: 2232
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x040008B9 RID: 2233
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x040008BA RID: 2234
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
