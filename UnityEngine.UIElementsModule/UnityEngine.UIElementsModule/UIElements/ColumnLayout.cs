using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000074 RID: 116
	public class ColumnLayout : Object
	{
		// Token: 0x06000B25 RID: 2853 RVA: 0x000442D4 File Offset: 0x000424D4
		// Note: this type is marked as 'beforefieldinit'.
		static ColumnLayout()
		{
			Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ColumnLayout");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr);
			ColumnLayout.NativeFieldInfoPtr_m_StretchableColumns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, "m_StretchableColumns");
			ColumnLayout.NativeFieldInfoPtr_m_FixedColumns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, "m_FixedColumns");
			ColumnLayout.NativeFieldInfoPtr_m_RelativeWidthColumns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, "m_RelativeWidthColumns");
			ColumnLayout.NativeFieldInfoPtr_m_MixedWidthColumns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, "m_MixedWidthColumns");
			ColumnLayout.NativeFieldInfoPtr_m_Columns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, "m_Columns");
			ColumnLayout.NativeFieldInfoPtr_m_ColumnsWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, "m_ColumnsWidth");
			ColumnLayout.NativeFieldInfoPtr_m_ColumnsWidthDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, "m_ColumnsWidthDirty");
			ColumnLayout.NativeFieldInfoPtr_m_MaxColumnsWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, "m_MaxColumnsWidth");
			ColumnLayout.NativeFieldInfoPtr_m_MinColumnsWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, "m_MinColumnsWidth");
			ColumnLayout.NativeFieldInfoPtr_m_IsDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, "m_IsDirty");
			ColumnLayout.NativeFieldInfoPtr_m_PreviousWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, "m_PreviousWidth");
			ColumnLayout.NativeFieldInfoPtr_m_LayoutWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, "m_LayoutWidth");
			ColumnLayout.NativeFieldInfoPtr_m_DragResizeInPreviewMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, "m_DragResizeInPreviewMode");
			ColumnLayout.NativeFieldInfoPtr_m_DragResizing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, "m_DragResizing");
			ColumnLayout.NativeFieldInfoPtr_m_DragStartPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, "m_DragStartPos");
			ColumnLayout.NativeFieldInfoPtr_m_DragLastPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, "m_DragLastPos");
			ColumnLayout.NativeFieldInfoPtr_m_DragInitialColumnWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, "m_DragInitialColumnWidth");
			ColumnLayout.NativeFieldInfoPtr_m_DragStretchableColumns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, "m_DragStretchableColumns");
			ColumnLayout.NativeFieldInfoPtr_m_DragRelativeColumns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, "m_DragRelativeColumns");
			ColumnLayout.NativeFieldInfoPtr_m_DragFixedColumns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, "m_DragFixedColumns");
			ColumnLayout.NativeFieldInfoPtr_m_PreviewDesiredWidths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, "m_PreviewDesiredWidths");
			ColumnLayout.NativeFieldInfoPtr_layoutRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, "layoutRequested");
			ColumnLayout.NativeMethodInfoPtr_get_columns_Public_get_Columns_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, 100664910);
			ColumnLayout.NativeMethodInfoPtr_get_columnsWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, 100664911);
			ColumnLayout.NativeMethodInfoPtr_get_layoutWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, 100664912);
			ColumnLayout.NativeMethodInfoPtr_get_minColumnsWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, 100664913);
			ColumnLayout.NativeMethodInfoPtr_get_maxColumnsWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, 100664914);
			ColumnLayout.NativeMethodInfoPtr_get_hasStretchableColumns_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, 100664915);
			ColumnLayout.NativeMethodInfoPtr_get_hasRelativeWidthColumns_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, 100664916);
			ColumnLayout.NativeMethodInfoPtr_add_layoutRequested_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, 100664917);
			ColumnLayout.NativeMethodInfoPtr_remove_layoutRequested_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, 100664918);
			ColumnLayout.NativeMethodInfoPtr__ctor_Public_Void_Columns_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, 100664919);
			ColumnLayout.NativeMethodInfoPtr_Dirty_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, 100664920);
			ColumnLayout.NativeMethodInfoPtr_OnColumnAdded_Private_Void_Column_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, 100664921);
			ColumnLayout.NativeMethodInfoPtr_OnColumnRemoved_Private_Void_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, 100664922);
			ColumnLayout.NativeMethodInfoPtr_OnColumnReordered_Private_Void_Column_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, 100664923);
			ColumnLayout.NativeMethodInfoPtr_RequiresLayoutUpdate_Private_Boolean_ColumnDataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, 100664924);
			ColumnLayout.NativeMethodInfoPtr_OnColumnChanged_Private_Void_Column_ColumnDataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, 100664925);
			ColumnLayout.NativeMethodInfoPtr_OnColumnResized_Private_Void_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, 100664926);
			ColumnLayout.NativeMethodInfoPtr_IsClamped_Private_Static_Boolean_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, 100664927);
			ColumnLayout.NativeMethodInfoPtr_DoLayout_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, 100664928);
			ColumnLayout.NativeMethodInfoPtr_StretchResizeColumns_Public_Void_List_1_Column_List_1_Column_List_1_Column_byref_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, 100664929);
			ColumnLayout.NativeMethodInfoPtr_DistributeOverflow_Private_Void_List_1_Column_List_1_Column_List_1_Column_byref_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, 100664930);
			ColumnLayout.NativeMethodInfoPtr_DistributeExcess_Private_Void_List_1_Column_List_1_Column_List_1_Column_byref_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, 100664931);
			ColumnLayout.NativeMethodInfoPtr_RecomputeToMaxWidthProportionally_Private_Single_List_1_Column_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, 100664932);
			ColumnLayout.NativeMethodInfoPtr_RecomputeToMinWidthProportionally_Private_Single_List_1_Column_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, 100664933);
			ColumnLayout.NativeMethodInfoPtr_RecomputeToDesiredWidth_Private_Single_List_1_Column_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, 100664934);
			ColumnLayout.NativeMethodInfoPtr_RecomputeToDesiredWidth_Private_Single_Column_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, 100664935);
			ColumnLayout.NativeMethodInfoPtr_RecomputeToMinWidth_Private_Single_List_1_Column_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, 100664936);
			ColumnLayout.NativeMethodInfoPtr_RecomputeToMaxWidth_Private_Single_List_1_Column_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, 100664937);
			ColumnLayout.NativeMethodInfoPtr_ResizeToFit_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, 100664938);
			ColumnLayout.NativeMethodInfoPtr_ResizeColumn_Private_Void_Column_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, 100664939);
			ColumnLayout.NativeMethodInfoPtr_BeginDragResize_Internal_Void_Column_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, 100664940);
			ColumnLayout.NativeMethodInfoPtr_GetDesiredPosition_Public_Single_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, 100664941);
			ColumnLayout.NativeMethodInfoPtr_GetDesiredWidth_Public_Single_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, 100664942);
			ColumnLayout.NativeMethodInfoPtr_DragResize_Public_Void_Column_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, 100664943);
			ColumnLayout.NativeMethodInfoPtr_EndDragResize_Internal_Void_Column_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, 100664944);
			ColumnLayout.NativeMethodInfoPtr_UpdateCache_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, 100664945);
			ColumnLayout.NativeMethodInfoPtr_UpdateMinAndMaxColumnsWidth_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, 100664946);
			ColumnLayout.NativeMethodInfoPtr_ClearCache_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, 100664947);
			ColumnLayout.NativeMethodInfoPtr__DoLayout_b__49_0_Private_Int32_Column_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, 100664948);
			ColumnLayout.NativeMethodInfoPtr__DoLayout_b__49_1_Private_Int32_Column_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, 100664949);
			ColumnLayout.NativeMethodInfoPtr__RecomputeToMaxWidthProportionally_b__53_0_Private_Int32_Column_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, 100664950);
			ColumnLayout.NativeMethodInfoPtr__RecomputeToMinWidthProportionally_b__54_0_Private_Int32_Column_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, 100664951);
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000B26 RID: 2854 RVA: 0x00044804 File Offset: 0x00042A04
		public unsafe Columns columns
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.NativeMethodInfoPtr_get_columns_Public_get_Columns_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Columns>(intPtr3) : null;
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000B27 RID: 2855 RVA: 0x00044844 File Offset: 0x00042A44
		public unsafe float columnsWidth
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 300354, RefRangeEnd = 300359, XrefRangeStart = 300336, XrefRangeEnd = 300354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.NativeMethodInfoPtr_get_columnsWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000B28 RID: 2856 RVA: 0x00044880 File Offset: 0x00042A80
		public unsafe float layoutWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.NativeMethodInfoPtr_get_layoutWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000B29 RID: 2857 RVA: 0x000448BC File Offset: 0x00042ABC
		public unsafe float minColumnsWidth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 300359, RefRangeEnd = 300360, XrefRangeStart = 300359, XrefRangeEnd = 300359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.NativeMethodInfoPtr_get_minColumnsWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000B2A RID: 2858 RVA: 0x000448F8 File Offset: 0x00042AF8
		public unsafe float maxColumnsWidth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 300360, RefRangeEnd = 300361, XrefRangeStart = 300360, XrefRangeEnd = 300360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.NativeMethodInfoPtr_get_maxColumnsWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000B2B RID: 2859 RVA: 0x00044934 File Offset: 0x00042B34
		public unsafe bool hasStretchableColumns
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300361, XrefRangeEnd = 300362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.NativeMethodInfoPtr_get_hasStretchableColumns_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000B2C RID: 2860 RVA: 0x00044970 File Offset: 0x00042B70
		public unsafe bool hasRelativeWidthColumns
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300362, XrefRangeEnd = 300363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.NativeMethodInfoPtr_get_hasRelativeWidthColumns_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x000449AC File Offset: 0x00042BAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 300367, RefRangeEnd = 300368, XrefRangeStart = 300363, XrefRangeEnd = 300367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_layoutRequested(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.NativeMethodInfoPtr_add_layoutRequested_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x000449F0 File Offset: 0x00042BF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 300372, RefRangeEnd = 300373, XrefRangeStart = 300368, XrefRangeEnd = 300372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_layoutRequested(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.NativeMethodInfoPtr_remove_layoutRequested_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x00044A34 File Offset: 0x00042C34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 300456, RefRangeEnd = 300457, XrefRangeStart = 300373, XrefRangeEnd = 300456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColumnLayout(Columns columns)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(columns);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.NativeMethodInfoPtr__ctor_Public_Void_Columns_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x00044A80 File Offset: 0x00042C80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 300458, RefRangeEnd = 300459, XrefRangeStart = 300457, XrefRangeEnd = 300458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.NativeMethodInfoPtr_Dirty_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x00044AB4 File Offset: 0x00042CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300459, XrefRangeEnd = 300474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnColumnAdded(Column column, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.NativeMethodInfoPtr_OnColumnAdded_Private_Void_Column_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x00044B04 File Offset: 0x00042D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300474, XrefRangeEnd = 300489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnColumnRemoved(Column column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.NativeMethodInfoPtr_OnColumnRemoved_Private_Void_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x00044B48 File Offset: 0x00042D48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 300458, RefRangeEnd = 300459, XrefRangeStart = 300458, XrefRangeEnd = 300459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnColumnReordered(Column column, int from, int to)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref from;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.NativeMethodInfoPtr_OnColumnReordered_Private_Void_Column_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x00044BA8 File Offset: 0x00042DA8
		[CallerCount(0)]
		public unsafe bool RequiresLayoutUpdate(ColumnDataType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.NativeMethodInfoPtr_RequiresLayoutUpdate_Private_Boolean_ColumnDataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x00044BF4 File Offset: 0x00042DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300489, XrefRangeEnd = 300491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnColumnChanged(Column column, ColumnDataType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.NativeMethodInfoPtr_OnColumnChanged_Private_Void_Column_ColumnDataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x00044C44 File Offset: 0x00042E44
		[CallerCount(0)]
		public unsafe void OnColumnResized(Column column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.NativeMethodInfoPtr_OnColumnResized_Private_Void_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x00044C88 File Offset: 0x00042E88
		[CallerCount(0)]
		public unsafe static bool IsClamped(float value, float min, float max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.NativeMethodInfoPtr_IsClamped_Private_Static_Boolean_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x00044CE4 File Offset: 0x00042EE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 300651, RefRangeEnd = 300653, XrefRangeStart = 300491, XrefRangeEnd = 300651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoLayout(float width)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.NativeMethodInfoPtr_DoLayout_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x00044D24 File Offset: 0x00042F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300653, XrefRangeEnd = 300655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StretchResizeColumns(List<Column> stretchableColumns, List<Column> fixedColumns, List<Column> relativeWidthColumns, ref float delta, bool resizeToFit, bool dragResize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stretchableColumns);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fixedColumns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(relativeWidthColumns);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &delta;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resizeToFit;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dragResize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.NativeMethodInfoPtr_StretchResizeColumns_Public_Void_List_1_Column_List_1_Column_List_1_Column_byref_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x00044DB8 File Offset: 0x00042FB8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 300680, RefRangeEnd = 300685, XrefRangeStart = 300655, XrefRangeEnd = 300680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DistributeOverflow(List<Column> stretchableColumns, List<Column> fixedColumns, List<Column> relativeWidthColumns, ref float delta, bool resizeToFit, bool dragResize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stretchableColumns);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fixedColumns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(relativeWidthColumns);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &delta;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resizeToFit;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dragResize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.NativeMethodInfoPtr_DistributeOverflow_Private_Void_List_1_Column_List_1_Column_List_1_Column_byref_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x00044E4C File Offset: 0x0004304C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 300717, RefRangeEnd = 300722, XrefRangeStart = 300685, XrefRangeEnd = 300717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DistributeExcess(List<Column> stretchableColumns, List<Column> fixedColumns, List<Column> relativeWidthColumns, ref float delta, bool resizeToFit, bool dragResize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stretchableColumns);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fixedColumns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(relativeWidthColumns);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &delta;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resizeToFit;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dragResize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.NativeMethodInfoPtr_DistributeExcess_Private_Void_List_1_Column_List_1_Column_List_1_Column_byref_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x00044EE0 File Offset: 0x000430E0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 300784, RefRangeEnd = 300790, XrefRangeStart = 300722, XrefRangeEnd = 300784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float RecomputeToMaxWidthProportionally(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(columns);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distributedDelta;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setDesiredWidthOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.NativeMethodInfoPtr_RecomputeToMaxWidthProportionally_Private_Single_List_1_Column_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x00044F4C File Offset: 0x0004314C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 300846, RefRangeEnd = 300850, XrefRangeStart = 300790, XrefRangeEnd = 300846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float RecomputeToMinWidthProportionally(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(columns);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distributedDelta;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setDesiredWidthOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.NativeMethodInfoPtr_RecomputeToMinWidthProportionally_Private_Single_List_1_Column_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x00044FB8 File Offset: 0x000431B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300850, XrefRangeEnd = 300859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float RecomputeToDesiredWidth(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly, bool distributeOverflow)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(columns);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distributedDelta;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setDesiredWidthOnly;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distributeOverflow;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.NativeMethodInfoPtr_RecomputeToDesiredWidth_Private_Single_List_1_Column_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x00045030 File Offset: 0x00043230
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 300886, RefRangeEnd = 300894, XrefRangeStart = 300859, XrefRangeEnd = 300886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float RecomputeToDesiredWidth(Column column, float distributedDelta, bool setDesiredWidthOnly, bool distributeOverflow)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distributedDelta;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setDesiredWidthOnly;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distributeOverflow;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.NativeMethodInfoPtr_RecomputeToDesiredWidth_Private_Single_Column_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x000450A8 File Offset: 0x000432A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 300912, RefRangeEnd = 300915, XrefRangeStart = 300894, XrefRangeEnd = 300912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float RecomputeToMinWidth(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(columns);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distributedDelta;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setDesiredWidthOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.NativeMethodInfoPtr_RecomputeToMinWidth_Private_Single_List_1_Column_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x00045114 File Offset: 0x00043314
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 300934, RefRangeEnd = 300936, XrefRangeStart = 300915, XrefRangeEnd = 300934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float RecomputeToMaxWidth(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(columns);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distributedDelta;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setDesiredWidthOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.NativeMethodInfoPtr_RecomputeToMaxWidth_Private_Single_List_1_Column_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x00045180 File Offset: 0x00043380
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 301022, RefRangeEnd = 301024, XrefRangeStart = 300936, XrefRangeEnd = 301022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResizeToFit(float width)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.NativeMethodInfoPtr_ResizeToFit_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x000451C0 File Offset: 0x000433C0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 301029, RefRangeEnd = 301038, XrefRangeStart = 301024, XrefRangeEnd = 301029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResizeColumn(Column column, float width, bool setDesiredWidthOnly = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setDesiredWidthOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.NativeMethodInfoPtr_ResizeColumn_Private_Void_Column_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x00045220 File Offset: 0x00043420
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 301069, RefRangeEnd = 301071, XrefRangeStart = 301038, XrefRangeEnd = 301069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginDragResize(Column column, float pos, bool previewMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref previewMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.NativeMethodInfoPtr_BeginDragResize_Internal_Void_Column_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x00045280 File Offset: 0x00043480
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 301084, RefRangeEnd = 301087, XrefRangeStart = 301071, XrefRangeEnd = 301084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetDesiredPosition(Column column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.NativeMethodInfoPtr_GetDesiredPosition_Public_Single_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x000452D0 File Offset: 0x000434D0
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 301093, RefRangeEnd = 301119, XrefRangeStart = 301087, XrefRangeEnd = 301093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetDesiredWidth(Column c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.NativeMethodInfoPtr_GetDesiredWidth_Public_Single_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x00045320 File Offset: 0x00043520
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 301153, RefRangeEnd = 301155, XrefRangeStart = 301119, XrefRangeEnd = 301153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DragResize(Column column, float pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.NativeMethodInfoPtr_DragResize_Public_Void_Column_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x00045370 File Offset: 0x00043570
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 301180, RefRangeEnd = 301183, XrefRangeStart = 301155, XrefRangeEnd = 301180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndDragResize(Column column, bool cancelled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cancelled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.NativeMethodInfoPtr_EndDragResize_Internal_Void_Column_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x000453C0 File Offset: 0x000435C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 301215, RefRangeEnd = 301217, XrefRangeStart = 301183, XrefRangeEnd = 301215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCache()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.NativeMethodInfoPtr_UpdateCache_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x000453F4 File Offset: 0x000435F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 301235, RefRangeEnd = 301236, XrefRangeStart = 301217, XrefRangeEnd = 301235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMinAndMaxColumnsWidth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.NativeMethodInfoPtr_UpdateMinAndMaxColumnsWidth_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x00045428 File Offset: 0x00043628
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 301240, RefRangeEnd = 301247, XrefRangeStart = 301236, XrefRangeEnd = 301240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearCache()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.NativeMethodInfoPtr_ClearCache_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x0004545C File Offset: 0x0004365C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301247, XrefRangeEnd = 301248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _DoLayout_b__49_0(Column c1, Column c2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.NativeMethodInfoPtr__DoLayout_b__49_0_Private_Int32_Column_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x000454BC File Offset: 0x000436BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _DoLayout_b__49_1(Column c1, Column c2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.NativeMethodInfoPtr__DoLayout_b__49_1_Private_Int32_Column_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x0004551C File Offset: 0x0004371C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _RecomputeToMaxWidthProportionally_b__53_0(Column c1, Column c2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.NativeMethodInfoPtr__RecomputeToMaxWidthProportionally_b__53_0_Private_Int32_Column_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x0004557C File Offset: 0x0004377C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301248, XrefRangeEnd = 301249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _RecomputeToMinWidthProportionally_b__54_0(Column c1, Column c2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.NativeMethodInfoPtr__RecomputeToMinWidthProportionally_b__54_0_Private_Int32_Column_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x00006104 File Offset: 0x00004304
		public ColumnLayout(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000B51 RID: 2897 RVA: 0x000455DC File Offset: 0x000437DC
		// (set) Token: 0x06000B52 RID: 2898 RVA: 0x0000610D File Offset: 0x0000430D
		public unsafe List<Column> m_StretchableColumns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_m_StretchableColumns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Column>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_m_StretchableColumns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000B53 RID: 2899 RVA: 0x0004560C File Offset: 0x0004380C
		// (set) Token: 0x06000B54 RID: 2900 RVA: 0x0000612C File Offset: 0x0000432C
		public unsafe List<Column> m_FixedColumns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_m_FixedColumns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Column>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_m_FixedColumns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000B55 RID: 2901 RVA: 0x0004563C File Offset: 0x0004383C
		// (set) Token: 0x06000B56 RID: 2902 RVA: 0x0000614B File Offset: 0x0000434B
		public unsafe List<Column> m_RelativeWidthColumns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_m_RelativeWidthColumns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Column>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_m_RelativeWidthColumns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000B57 RID: 2903 RVA: 0x0004566C File Offset: 0x0004386C
		// (set) Token: 0x06000B58 RID: 2904 RVA: 0x0000616A File Offset: 0x0000436A
		public unsafe List<Column> m_MixedWidthColumns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_m_MixedWidthColumns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Column>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_m_MixedWidthColumns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000B59 RID: 2905 RVA: 0x0004569C File Offset: 0x0004389C
		// (set) Token: 0x06000B5A RID: 2906 RVA: 0x00006189 File Offset: 0x00004389
		public unsafe Columns m_Columns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_m_Columns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Columns>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_m_Columns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000B5B RID: 2907 RVA: 0x000456CC File Offset: 0x000438CC
		// (set) Token: 0x06000B5C RID: 2908 RVA: 0x000061A8 File Offset: 0x000043A8
		public unsafe float m_ColumnsWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_m_ColumnsWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_m_ColumnsWidth)) = value;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000B5D RID: 2909 RVA: 0x000456F4 File Offset: 0x000438F4
		// (set) Token: 0x06000B5E RID: 2910 RVA: 0x000061C3 File Offset: 0x000043C3
		public unsafe bool m_ColumnsWidthDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_m_ColumnsWidthDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_m_ColumnsWidthDirty)) = value;
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000B5F RID: 2911 RVA: 0x0004571C File Offset: 0x0004391C
		// (set) Token: 0x06000B60 RID: 2912 RVA: 0x000061DE File Offset: 0x000043DE
		public unsafe float m_MaxColumnsWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_m_MaxColumnsWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_m_MaxColumnsWidth)) = value;
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000B61 RID: 2913 RVA: 0x00045744 File Offset: 0x00043944
		// (set) Token: 0x06000B62 RID: 2914 RVA: 0x000061F9 File Offset: 0x000043F9
		public unsafe float m_MinColumnsWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_m_MinColumnsWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_m_MinColumnsWidth)) = value;
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000B63 RID: 2915 RVA: 0x0004576C File Offset: 0x0004396C
		// (set) Token: 0x06000B64 RID: 2916 RVA: 0x00006214 File Offset: 0x00004414
		public unsafe bool m_IsDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_m_IsDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_m_IsDirty)) = value;
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000B65 RID: 2917 RVA: 0x00045794 File Offset: 0x00043994
		// (set) Token: 0x06000B66 RID: 2918 RVA: 0x0000622F File Offset: 0x0000442F
		public unsafe float m_PreviousWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_m_PreviousWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_m_PreviousWidth)) = value;
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000B67 RID: 2919 RVA: 0x000457BC File Offset: 0x000439BC
		// (set) Token: 0x06000B68 RID: 2920 RVA: 0x0000624A File Offset: 0x0000444A
		public unsafe float m_LayoutWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_m_LayoutWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_m_LayoutWidth)) = value;
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000B69 RID: 2921 RVA: 0x000457E4 File Offset: 0x000439E4
		// (set) Token: 0x06000B6A RID: 2922 RVA: 0x00006265 File Offset: 0x00004465
		public unsafe bool m_DragResizeInPreviewMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_m_DragResizeInPreviewMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_m_DragResizeInPreviewMode)) = value;
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000B6B RID: 2923 RVA: 0x0004580C File Offset: 0x00043A0C
		// (set) Token: 0x06000B6C RID: 2924 RVA: 0x00006280 File Offset: 0x00004480
		public unsafe bool m_DragResizing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_m_DragResizing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_m_DragResizing)) = value;
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000B6D RID: 2925 RVA: 0x00045834 File Offset: 0x00043A34
		// (set) Token: 0x06000B6E RID: 2926 RVA: 0x0000629B File Offset: 0x0000449B
		public unsafe float m_DragStartPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_m_DragStartPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_m_DragStartPos)) = value;
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000B6F RID: 2927 RVA: 0x0004585C File Offset: 0x00043A5C
		// (set) Token: 0x06000B70 RID: 2928 RVA: 0x000062B6 File Offset: 0x000044B6
		public unsafe float m_DragLastPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_m_DragLastPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_m_DragLastPos)) = value;
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000B71 RID: 2929 RVA: 0x00045884 File Offset: 0x00043A84
		// (set) Token: 0x06000B72 RID: 2930 RVA: 0x000062D1 File Offset: 0x000044D1
		public unsafe float m_DragInitialColumnWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_m_DragInitialColumnWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_m_DragInitialColumnWidth)) = value;
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000B73 RID: 2931 RVA: 0x000458AC File Offset: 0x00043AAC
		// (set) Token: 0x06000B74 RID: 2932 RVA: 0x000062EC File Offset: 0x000044EC
		public unsafe List<Column> m_DragStretchableColumns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_m_DragStretchableColumns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Column>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_m_DragStretchableColumns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000B75 RID: 2933 RVA: 0x000458DC File Offset: 0x00043ADC
		// (set) Token: 0x06000B76 RID: 2934 RVA: 0x0000630B File Offset: 0x0000450B
		public unsafe List<Column> m_DragRelativeColumns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_m_DragRelativeColumns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Column>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_m_DragRelativeColumns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000B77 RID: 2935 RVA: 0x0004590C File Offset: 0x00043B0C
		// (set) Token: 0x06000B78 RID: 2936 RVA: 0x0000632A File Offset: 0x0000452A
		public unsafe List<Column> m_DragFixedColumns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_m_DragFixedColumns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Column>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_m_DragFixedColumns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000B79 RID: 2937 RVA: 0x0004593C File Offset: 0x00043B3C
		// (set) Token: 0x06000B7A RID: 2938 RVA: 0x00006349 File Offset: 0x00004549
		public unsafe Dictionary<Column, float> m_PreviewDesiredWidths
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_m_PreviewDesiredWidths);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Column, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_m_PreviewDesiredWidths), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000B7B RID: 2939 RVA: 0x0004596C File Offset: 0x00043B6C
		// (set) Token: 0x06000B7C RID: 2940 RVA: 0x00006368 File Offset: 0x00004568
		public unsafe Action layoutRequested
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_layoutRequested);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.NativeFieldInfoPtr_layoutRequested), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000B7D RID: 2941 RVA: 0x00006387 File Offset: 0x00004587
		public bool isDirty
		{
			get
			{
				return this.m_IsDirty;
			}
		}

		// Token: 0x040007BA RID: 1978
		private static readonly IntPtr NativeFieldInfoPtr_m_StretchableColumns;

		// Token: 0x040007BB RID: 1979
		private static readonly IntPtr NativeFieldInfoPtr_m_FixedColumns;

		// Token: 0x040007BC RID: 1980
		private static readonly IntPtr NativeFieldInfoPtr_m_RelativeWidthColumns;

		// Token: 0x040007BD RID: 1981
		private static readonly IntPtr NativeFieldInfoPtr_m_MixedWidthColumns;

		// Token: 0x040007BE RID: 1982
		private static readonly IntPtr NativeFieldInfoPtr_m_Columns;

		// Token: 0x040007BF RID: 1983
		private static readonly IntPtr NativeFieldInfoPtr_m_ColumnsWidth;

		// Token: 0x040007C0 RID: 1984
		private static readonly IntPtr NativeFieldInfoPtr_m_ColumnsWidthDirty;

		// Token: 0x040007C1 RID: 1985
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxColumnsWidth;

		// Token: 0x040007C2 RID: 1986
		private static readonly IntPtr NativeFieldInfoPtr_m_MinColumnsWidth;

		// Token: 0x040007C3 RID: 1987
		private static readonly IntPtr NativeFieldInfoPtr_m_IsDirty;

		// Token: 0x040007C4 RID: 1988
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviousWidth;

		// Token: 0x040007C5 RID: 1989
		private static readonly IntPtr NativeFieldInfoPtr_m_LayoutWidth;

		// Token: 0x040007C6 RID: 1990
		private static readonly IntPtr NativeFieldInfoPtr_m_DragResizeInPreviewMode;

		// Token: 0x040007C7 RID: 1991
		private static readonly IntPtr NativeFieldInfoPtr_m_DragResizing;

		// Token: 0x040007C8 RID: 1992
		private static readonly IntPtr NativeFieldInfoPtr_m_DragStartPos;

		// Token: 0x040007C9 RID: 1993
		private static readonly IntPtr NativeFieldInfoPtr_m_DragLastPos;

		// Token: 0x040007CA RID: 1994
		private static readonly IntPtr NativeFieldInfoPtr_m_DragInitialColumnWidth;

		// Token: 0x040007CB RID: 1995
		private static readonly IntPtr NativeFieldInfoPtr_m_DragStretchableColumns;

		// Token: 0x040007CC RID: 1996
		private static readonly IntPtr NativeFieldInfoPtr_m_DragRelativeColumns;

		// Token: 0x040007CD RID: 1997
		private static readonly IntPtr NativeFieldInfoPtr_m_DragFixedColumns;

		// Token: 0x040007CE RID: 1998
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviewDesiredWidths;

		// Token: 0x040007CF RID: 1999
		private static readonly IntPtr NativeFieldInfoPtr_layoutRequested;

		// Token: 0x040007D0 RID: 2000
		private static readonly IntPtr NativeMethodInfoPtr_get_columns_Public_get_Columns_0;

		// Token: 0x040007D1 RID: 2001
		private static readonly IntPtr NativeMethodInfoPtr_get_columnsWidth_Public_get_Single_0;

		// Token: 0x040007D2 RID: 2002
		private static readonly IntPtr NativeMethodInfoPtr_get_layoutWidth_Public_get_Single_0;

		// Token: 0x040007D3 RID: 2003
		private static readonly IntPtr NativeMethodInfoPtr_get_minColumnsWidth_Public_get_Single_0;

		// Token: 0x040007D4 RID: 2004
		private static readonly IntPtr NativeMethodInfoPtr_get_maxColumnsWidth_Public_get_Single_0;

		// Token: 0x040007D5 RID: 2005
		private static readonly IntPtr NativeMethodInfoPtr_get_hasStretchableColumns_Public_get_Boolean_0;

		// Token: 0x040007D6 RID: 2006
		private static readonly IntPtr NativeMethodInfoPtr_get_hasRelativeWidthColumns_Public_get_Boolean_0;

		// Token: 0x040007D7 RID: 2007
		private static readonly IntPtr NativeMethodInfoPtr_add_layoutRequested_Public_add_Void_Action_0;

		// Token: 0x040007D8 RID: 2008
		private static readonly IntPtr NativeMethodInfoPtr_remove_layoutRequested_Public_rem_Void_Action_0;

		// Token: 0x040007D9 RID: 2009
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Columns_0;

		// Token: 0x040007DA RID: 2010
		private static readonly IntPtr NativeMethodInfoPtr_Dirty_Public_Void_0;

		// Token: 0x040007DB RID: 2011
		private static readonly IntPtr NativeMethodInfoPtr_OnColumnAdded_Private_Void_Column_Int32_0;

		// Token: 0x040007DC RID: 2012
		private static readonly IntPtr NativeMethodInfoPtr_OnColumnRemoved_Private_Void_Column_0;

		// Token: 0x040007DD RID: 2013
		private static readonly IntPtr NativeMethodInfoPtr_OnColumnReordered_Private_Void_Column_Int32_Int32_0;

		// Token: 0x040007DE RID: 2014
		private static readonly IntPtr NativeMethodInfoPtr_RequiresLayoutUpdate_Private_Boolean_ColumnDataType_0;

		// Token: 0x040007DF RID: 2015
		private static readonly IntPtr NativeMethodInfoPtr_OnColumnChanged_Private_Void_Column_ColumnDataType_0;

		// Token: 0x040007E0 RID: 2016
		private static readonly IntPtr NativeMethodInfoPtr_OnColumnResized_Private_Void_Column_0;

		// Token: 0x040007E1 RID: 2017
		private static readonly IntPtr NativeMethodInfoPtr_IsClamped_Private_Static_Boolean_Single_Single_Single_0;

		// Token: 0x040007E2 RID: 2018
		private static readonly IntPtr NativeMethodInfoPtr_DoLayout_Public_Void_Single_0;

		// Token: 0x040007E3 RID: 2019
		private static readonly IntPtr NativeMethodInfoPtr_StretchResizeColumns_Public_Void_List_1_Column_List_1_Column_List_1_Column_byref_Single_Boolean_Boolean_0;

		// Token: 0x040007E4 RID: 2020
		private static readonly IntPtr NativeMethodInfoPtr_DistributeOverflow_Private_Void_List_1_Column_List_1_Column_List_1_Column_byref_Single_Boolean_Boolean_0;

		// Token: 0x040007E5 RID: 2021
		private static readonly IntPtr NativeMethodInfoPtr_DistributeExcess_Private_Void_List_1_Column_List_1_Column_List_1_Column_byref_Single_Boolean_Boolean_0;

		// Token: 0x040007E6 RID: 2022
		private static readonly IntPtr NativeMethodInfoPtr_RecomputeToMaxWidthProportionally_Private_Single_List_1_Column_Single_Boolean_0;

		// Token: 0x040007E7 RID: 2023
		private static readonly IntPtr NativeMethodInfoPtr_RecomputeToMinWidthProportionally_Private_Single_List_1_Column_Single_Boolean_0;

		// Token: 0x040007E8 RID: 2024
		private static readonly IntPtr NativeMethodInfoPtr_RecomputeToDesiredWidth_Private_Single_List_1_Column_Single_Boolean_Boolean_0;

		// Token: 0x040007E9 RID: 2025
		private static readonly IntPtr NativeMethodInfoPtr_RecomputeToDesiredWidth_Private_Single_Column_Single_Boolean_Boolean_0;

		// Token: 0x040007EA RID: 2026
		private static readonly IntPtr NativeMethodInfoPtr_RecomputeToMinWidth_Private_Single_List_1_Column_Single_Boolean_0;

		// Token: 0x040007EB RID: 2027
		private static readonly IntPtr NativeMethodInfoPtr_RecomputeToMaxWidth_Private_Single_List_1_Column_Single_Boolean_0;

		// Token: 0x040007EC RID: 2028
		private static readonly IntPtr NativeMethodInfoPtr_ResizeToFit_Public_Void_Single_0;

		// Token: 0x040007ED RID: 2029
		private static readonly IntPtr NativeMethodInfoPtr_ResizeColumn_Private_Void_Column_Single_Boolean_0;

		// Token: 0x040007EE RID: 2030
		private static readonly IntPtr NativeMethodInfoPtr_BeginDragResize_Internal_Void_Column_Single_Boolean_0;

		// Token: 0x040007EF RID: 2031
		private static readonly IntPtr NativeMethodInfoPtr_GetDesiredPosition_Public_Single_Column_0;

		// Token: 0x040007F0 RID: 2032
		private static readonly IntPtr NativeMethodInfoPtr_GetDesiredWidth_Public_Single_Column_0;

		// Token: 0x040007F1 RID: 2033
		private static readonly IntPtr NativeMethodInfoPtr_DragResize_Public_Void_Column_Single_0;

		// Token: 0x040007F2 RID: 2034
		private static readonly IntPtr NativeMethodInfoPtr_EndDragResize_Internal_Void_Column_Boolean_0;

		// Token: 0x040007F3 RID: 2035
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCache_Private_Void_0;

		// Token: 0x040007F4 RID: 2036
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMinAndMaxColumnsWidth_Private_Void_0;

		// Token: 0x040007F5 RID: 2037
		private static readonly IntPtr NativeMethodInfoPtr_ClearCache_Private_Void_0;

		// Token: 0x040007F6 RID: 2038
		private static readonly IntPtr NativeMethodInfoPtr__DoLayout_b__49_0_Private_Int32_Column_Column_0;

		// Token: 0x040007F7 RID: 2039
		private static readonly IntPtr NativeMethodInfoPtr__DoLayout_b__49_1_Private_Int32_Column_Column_0;

		// Token: 0x040007F8 RID: 2040
		private static readonly IntPtr NativeMethodInfoPtr__RecomputeToMaxWidthProportionally_b__53_0_Private_Int32_Column_Column_0;

		// Token: 0x040007F9 RID: 2041
		private static readonly IntPtr NativeMethodInfoPtr__RecomputeToMinWidthProportionally_b__54_0_Private_Int32_Column_Column_0;

		// Token: 0x0200039B RID: 923
		[ObfuscatedName("UnityEngine.UIElements.ColumnLayout+<>c__DisplayClass53_0")]
		public sealed class __c__DisplayClass53_0 : Object
		{
			// Token: 0x060038B4 RID: 14516 RVA: 0x000E72E8 File Offset: 0x000E54E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass53_0()
			{
				Il2CppClassPointerStore<ColumnLayout.__c__DisplayClass53_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, "<>c__DisplayClass53_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColumnLayout.__c__DisplayClass53_0>.NativeClassPtr);
				ColumnLayout.__c__DisplayClass53_0.NativeFieldInfoPtr_totalColumnWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnLayout.__c__DisplayClass53_0>.NativeClassPtr, "totalColumnWidth");
				ColumnLayout.__c__DisplayClass53_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnLayout.__c__DisplayClass53_0>.NativeClassPtr, "<>4__this");
				ColumnLayout.__c__DisplayClass53_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout.__c__DisplayClass53_0>.NativeClassPtr, 100664952);
				ColumnLayout.__c__DisplayClass53_0.NativeMethodInfoPtr__RecomputeToMaxWidthProportionally_b__1_Internal_Void_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout.__c__DisplayClass53_0>.NativeClassPtr, 100664953);
			}

			// Token: 0x060038B5 RID: 14517 RVA: 0x000E7364 File Offset: 0x000E5564
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass53_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColumnLayout.__c__DisplayClass53_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.__c__DisplayClass53_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060038B6 RID: 14518 RVA: 0x000E73A0 File Offset: 0x000E55A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300329, XrefRangeEnd = 300336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RecomputeToMaxWidthProportionally_b__1(Column c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.__c__DisplayClass53_0.NativeMethodInfoPtr__RecomputeToMaxWidthProportionally_b__1_Internal_Void_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060038B7 RID: 14519 RVA: 0x00017AB3 File Offset: 0x00015CB3
			public __c__DisplayClass53_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001178 RID: 4472
			// (get) Token: 0x060038B8 RID: 14520 RVA: 0x000E73E4 File Offset: 0x000E55E4
			// (set) Token: 0x060038B9 RID: 14521 RVA: 0x00017ABC File Offset: 0x00015CBC
			public unsafe float totalColumnWidth
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.__c__DisplayClass53_0.NativeFieldInfoPtr_totalColumnWidth);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.__c__DisplayClass53_0.NativeFieldInfoPtr_totalColumnWidth)) = value;
				}
			}

			// Token: 0x17001179 RID: 4473
			// (get) Token: 0x060038BA RID: 14522 RVA: 0x000E740C File Offset: 0x000E560C
			// (set) Token: 0x060038BB RID: 14523 RVA: 0x00017AD7 File Offset: 0x00015CD7
			public unsafe ColumnLayout __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.__c__DisplayClass53_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColumnLayout>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.__c__DisplayClass53_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002841 RID: 10305
			private static readonly IntPtr NativeFieldInfoPtr_totalColumnWidth;

			// Token: 0x04002842 RID: 10306
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002843 RID: 10307
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002844 RID: 10308
			private static readonly IntPtr NativeMethodInfoPtr__RecomputeToMaxWidthProportionally_b__1_Internal_Void_Column_0;
		}

		// Token: 0x0200039C RID: 924
		[ObfuscatedName("UnityEngine.UIElements.ColumnLayout+<>c__DisplayClass54_0")]
		public sealed class __c__DisplayClass54_0 : Object
		{
			// Token: 0x060038BC RID: 14524 RVA: 0x000E743C File Offset: 0x000E563C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass54_0()
			{
				Il2CppClassPointerStore<ColumnLayout.__c__DisplayClass54_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColumnLayout>.NativeClassPtr, "<>c__DisplayClass54_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColumnLayout.__c__DisplayClass54_0>.NativeClassPtr);
				ColumnLayout.__c__DisplayClass54_0.NativeFieldInfoPtr_totalColumnsWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnLayout.__c__DisplayClass54_0>.NativeClassPtr, "totalColumnsWidth");
				ColumnLayout.__c__DisplayClass54_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColumnLayout.__c__DisplayClass54_0>.NativeClassPtr, "<>4__this");
				ColumnLayout.__c__DisplayClass54_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout.__c__DisplayClass54_0>.NativeClassPtr, 100664954);
				ColumnLayout.__c__DisplayClass54_0.NativeMethodInfoPtr__RecomputeToMinWidthProportionally_b__1_Internal_Void_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColumnLayout.__c__DisplayClass54_0>.NativeClassPtr, 100664955);
			}

			// Token: 0x060038BD RID: 14525 RVA: 0x000E74B8 File Offset: 0x000E56B8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass54_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColumnLayout.__c__DisplayClass54_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.__c__DisplayClass54_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060038BE RID: 14526 RVA: 0x000E74F4 File Offset: 0x000E56F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RecomputeToMinWidthProportionally_b__1(Column c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColumnLayout.__c__DisplayClass54_0.NativeMethodInfoPtr__RecomputeToMinWidthProportionally_b__1_Internal_Void_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060038BF RID: 14527 RVA: 0x00017AF6 File Offset: 0x00015CF6
			public __c__DisplayClass54_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700117A RID: 4474
			// (get) Token: 0x060038C0 RID: 14528 RVA: 0x000E7538 File Offset: 0x000E5738
			// (set) Token: 0x060038C1 RID: 14529 RVA: 0x00017AFF File Offset: 0x00015CFF
			public unsafe float totalColumnsWidth
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.__c__DisplayClass54_0.NativeFieldInfoPtr_totalColumnsWidth);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.__c__DisplayClass54_0.NativeFieldInfoPtr_totalColumnsWidth)) = value;
				}
			}

			// Token: 0x1700117B RID: 4475
			// (get) Token: 0x060038C2 RID: 14530 RVA: 0x000E7560 File Offset: 0x000E5760
			// (set) Token: 0x060038C3 RID: 14531 RVA: 0x00017B1A File Offset: 0x00015D1A
			public unsafe ColumnLayout __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.__c__DisplayClass54_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColumnLayout>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColumnLayout.__c__DisplayClass54_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002845 RID: 10309
			private static readonly IntPtr NativeFieldInfoPtr_totalColumnsWidth;

			// Token: 0x04002846 RID: 10310
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002847 RID: 10311
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002848 RID: 10312
			private static readonly IntPtr NativeMethodInfoPtr__RecomputeToMinWidthProportionally_b__1_Internal_Void_Column_0;
		}

		// Token: 0x0200039D RID: 925
		public sealed class <>c__DisplayClass53_0
		{
		}

		// Token: 0x0200039E RID: 926
		public sealed class <>c__DisplayClass54_0
		{
		}
	}
}
