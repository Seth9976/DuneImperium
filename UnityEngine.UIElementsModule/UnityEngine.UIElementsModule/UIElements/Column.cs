using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000073 RID: 115
	public class Column : Object
	{
		// Token: 0x06000ABD RID: 2749 RVA: 0x00042C24 File Offset: 0x00040E24
		// Note: this type is marked as 'beforefieldinit'.
		static Column()
		{
			Il2CppClassPointerStore<Column>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "Column");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Column>.NativeClassPtr);
			Column.NativeFieldInfoPtr_k_InvalidTemplateError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Column>.NativeClassPtr, "k_InvalidTemplateError");
			Column.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Column>.NativeClassPtr, "m_Name");
			Column.NativeFieldInfoPtr_m_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Column>.NativeClassPtr, "m_Title");
			Column.NativeFieldInfoPtr_m_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Column>.NativeClassPtr, "m_Icon");
			Column.NativeFieldInfoPtr_m_Visible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Column>.NativeClassPtr, "m_Visible");
			Column.NativeFieldInfoPtr_m_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Column>.NativeClassPtr, "m_Width");
			Column.NativeFieldInfoPtr_m_MinWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Column>.NativeClassPtr, "m_MinWidth");
			Column.NativeFieldInfoPtr_m_MaxWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Column>.NativeClassPtr, "m_MaxWidth");
			Column.NativeFieldInfoPtr_m_DesiredWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Column>.NativeClassPtr, "m_DesiredWidth");
			Column.NativeFieldInfoPtr_m_Stretchable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Column>.NativeClassPtr, "m_Stretchable");
			Column.NativeFieldInfoPtr_m_Sortable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Column>.NativeClassPtr, "m_Sortable");
			Column.NativeFieldInfoPtr_m_Optional = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Column>.NativeClassPtr, "m_Optional");
			Column.NativeFieldInfoPtr_m_Resizable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Column>.NativeClassPtr, "m_Resizable");
			Column.NativeFieldInfoPtr_m_MakeHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Column>.NativeClassPtr, "m_MakeHeader");
			Column.NativeFieldInfoPtr_m_BindHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Column>.NativeClassPtr, "m_BindHeader");
			Column.NativeFieldInfoPtr_m_UnbindHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Column>.NativeClassPtr, "m_UnbindHeader");
			Column.NativeFieldInfoPtr_m_DestroyHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Column>.NativeClassPtr, "m_DestroyHeader");
			Column.NativeFieldInfoPtr_m_MakeCell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Column>.NativeClassPtr, "m_MakeCell");
			Column.NativeFieldInfoPtr_m_BindCell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Column>.NativeClassPtr, "m_BindCell");
			Column.NativeFieldInfoPtr_m_UnbindCellItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Column>.NativeClassPtr, "m_UnbindCellItem");
			Column.NativeFieldInfoPtr__destroyCell_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Column>.NativeClassPtr, "<destroyCell>k__BackingField");
			Column.NativeFieldInfoPtr__collection_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Column>.NativeClassPtr, "<collection>k__BackingField");
			Column.NativeFieldInfoPtr_changed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Column>.NativeClassPtr, "changed");
			Column.NativeFieldInfoPtr_resized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Column>.NativeClassPtr, "resized");
			Column.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664854);
			Column.NativeMethodInfoPtr_set_name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664855);
			Column.NativeMethodInfoPtr_get_title_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664856);
			Column.NativeMethodInfoPtr_set_title_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664857);
			Column.NativeMethodInfoPtr_get_icon_Public_get_Background_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664858);
			Column.NativeMethodInfoPtr_get_index_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664859);
			Column.NativeMethodInfoPtr_get_displayIndex_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664860);
			Column.NativeMethodInfoPtr_get_visibleIndex_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664861);
			Column.NativeMethodInfoPtr_get_visible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664862);
			Column.NativeMethodInfoPtr_set_visible_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664863);
			Column.NativeMethodInfoPtr_get_width_Public_get_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664864);
			Column.NativeMethodInfoPtr_set_width_Public_set_Void_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664865);
			Column.NativeMethodInfoPtr_get_minWidth_Public_get_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664866);
			Column.NativeMethodInfoPtr_set_minWidth_Public_set_Void_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664867);
			Column.NativeMethodInfoPtr_get_maxWidth_Public_get_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664868);
			Column.NativeMethodInfoPtr_set_maxWidth_Public_set_Void_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664869);
			Column.NativeMethodInfoPtr_get_desiredWidth_Internal_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664870);
			Column.NativeMethodInfoPtr_set_desiredWidth_Internal_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664871);
			Column.NativeMethodInfoPtr_get_sortable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664872);
			Column.NativeMethodInfoPtr_set_sortable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664873);
			Column.NativeMethodInfoPtr_get_stretchable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664874);
			Column.NativeMethodInfoPtr_set_stretchable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664875);
			Column.NativeMethodInfoPtr_get_optional_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664876);
			Column.NativeMethodInfoPtr_set_optional_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664877);
			Column.NativeMethodInfoPtr_get_resizable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664878);
			Column.NativeMethodInfoPtr_set_resizable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664879);
			Column.NativeMethodInfoPtr_get_makeHeader_Public_get_Func_1_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664880);
			Column.NativeMethodInfoPtr_set_makeHeader_Public_set_Void_Func_1_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664881);
			Column.NativeMethodInfoPtr_get_bindHeader_Public_get_Action_1_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664882);
			Column.NativeMethodInfoPtr_get_unbindHeader_Public_get_Action_1_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664883);
			Column.NativeMethodInfoPtr_get_destroyHeader_Public_get_Action_1_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664884);
			Column.NativeMethodInfoPtr_get_makeCell_Public_get_Func_1_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664885);
			Column.NativeMethodInfoPtr_set_makeCell_Public_set_Void_Func_1_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664886);
			Column.NativeMethodInfoPtr_get_bindCell_Public_get_Action_2_VisualElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664887);
			Column.NativeMethodInfoPtr_get_unbindCell_Public_get_Action_2_VisualElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664888);
			Column.NativeMethodInfoPtr_get_destroyCell_Public_get_Action_1_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664889);
			Column.NativeMethodInfoPtr_get_collection_Public_get_Columns_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664890);
			Column.NativeMethodInfoPtr_set_collection_Internal_set_Void_Columns_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664891);
			Column.NativeMethodInfoPtr_add_changed_Internal_add_Void_Action_2_Column_ColumnDataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664892);
			Column.NativeMethodInfoPtr_remove_changed_Internal_rem_Void_Action_2_Column_ColumnDataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664893);
			Column.NativeMethodInfoPtr_add_resized_Internal_add_Void_Action_1_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664894);
			Column.NativeMethodInfoPtr_remove_resized_Internal_rem_Void_Action_1_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664895);
			Column.NativeMethodInfoPtr_NotifyChange_Private_Void_ColumnDataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664896);
			Column.NativeMethodInfoPtr_GetWidth_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664897);
			Column.NativeMethodInfoPtr_GetMaxWidth_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664898);
			Column.NativeMethodInfoPtr_GetMinWidth_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664899);
			Column.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column>.NativeClassPtr, 100664900);
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000ABE RID: 2750 RVA: 0x000431E0 File Offset: 0x000413E0
		// (set) Token: 0x06000ABF RID: 2751 RVA: 0x00043218 File Offset: 0x00041418
		public unsafe string name
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 300236, RefRangeEnd = 300237, XrefRangeStart = 300234, XrefRangeEnd = 300236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_set_name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x0004325C File Offset: 0x0004145C
		// (set) Token: 0x06000AC1 RID: 2753 RVA: 0x00043294 File Offset: 0x00041494
		public unsafe string title
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_get_title_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 300239, RefRangeEnd = 300240, XrefRangeStart = 300237, XrefRangeEnd = 300239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_set_title_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x000432D8 File Offset: 0x000414D8
		// (set) Token: 0x06000B1E RID: 2846 RVA: 0x000441B4 File Offset: 0x000423B4
		public unsafe Background icon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_get_icon_Public_get_Background_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Background(intPtr);
			}
			set
			{
				bool flag = this.m_Icon == value;
				if (!flag)
				{
					this.m_Icon = value;
					this.NotifyChange(ColumnDataType.Icon);
				}
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x00043310 File Offset: 0x00041510
		public unsafe int index
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 300244, RefRangeEnd = 300248, XrefRangeStart = 300240, XrefRangeEnd = 300244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_get_index_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x0004334C File Offset: 0x0004154C
		public unsafe int displayIndex
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 300255, RefRangeEnd = 300260, XrefRangeStart = 300248, XrefRangeEnd = 300255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_get_displayIndex_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x00043388 File Offset: 0x00041588
		public unsafe int visibleIndex
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 300267, RefRangeEnd = 300272, XrefRangeStart = 300260, XrefRangeEnd = 300267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_get_visibleIndex_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000AC6 RID: 2758 RVA: 0x000433C4 File Offset: 0x000415C4
		// (set) Token: 0x06000AC7 RID: 2759 RVA: 0x00043400 File Offset: 0x00041600
		public unsafe bool visible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_get_visible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 300272, RefRangeEnd = 300275, XrefRangeStart = 300272, XrefRangeEnd = 300272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_set_visible_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000AC8 RID: 2760 RVA: 0x00043440 File Offset: 0x00041640
		// (set) Token: 0x06000AC9 RID: 2761 RVA: 0x0004347C File Offset: 0x0004167C
		public unsafe Length width
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_get_width_Public_get_Length_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 300276, RefRangeEnd = 300278, XrefRangeStart = 300275, XrefRangeEnd = 300276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_set_width_Public_set_Void_Length_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000ACA RID: 2762 RVA: 0x000434BC File Offset: 0x000416BC
		// (set) Token: 0x06000ACB RID: 2763 RVA: 0x000434F8 File Offset: 0x000416F8
		public unsafe Length minWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_get_minWidth_Public_get_Length_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 300279, RefRangeEnd = 300280, XrefRangeStart = 300278, XrefRangeEnd = 300279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_set_minWidth_Public_set_Void_Length_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000ACC RID: 2764 RVA: 0x00043538 File Offset: 0x00041738
		// (set) Token: 0x06000ACD RID: 2765 RVA: 0x00043574 File Offset: 0x00041774
		public unsafe Length maxWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_get_maxWidth_Public_get_Length_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 300281, RefRangeEnd = 300282, XrefRangeStart = 300280, XrefRangeEnd = 300281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_set_maxWidth_Public_set_Void_Length_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000ACE RID: 2766 RVA: 0x000435B4 File Offset: 0x000417B4
		// (set) Token: 0x06000ACF RID: 2767 RVA: 0x000435F0 File Offset: 0x000417F0
		public unsafe float desiredWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_get_desiredWidth_Internal_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 300282, RefRangeEnd = 300283, XrefRangeStart = 300282, XrefRangeEnd = 300282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_set_desiredWidth_Internal_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000AD0 RID: 2768 RVA: 0x00043630 File Offset: 0x00041830
		// (set) Token: 0x06000AD1 RID: 2769 RVA: 0x0004366C File Offset: 0x0004186C
		public unsafe bool sortable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_get_sortable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 300283, RefRangeEnd = 300284, XrefRangeStart = 300283, XrefRangeEnd = 300283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_set_sortable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000AD2 RID: 2770 RVA: 0x000436AC File Offset: 0x000418AC
		// (set) Token: 0x06000AD3 RID: 2771 RVA: 0x000436E8 File Offset: 0x000418E8
		public unsafe bool stretchable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_get_stretchable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 300284, RefRangeEnd = 300285, XrefRangeStart = 300284, XrefRangeEnd = 300284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_set_stretchable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000AD4 RID: 2772 RVA: 0x00043728 File Offset: 0x00041928
		// (set) Token: 0x06000AD5 RID: 2773 RVA: 0x00043764 File Offset: 0x00041964
		public unsafe bool optional
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_get_optional_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 300285, RefRangeEnd = 300286, XrefRangeStart = 300285, XrefRangeEnd = 300285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_set_optional_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000AD6 RID: 2774 RVA: 0x000437A4 File Offset: 0x000419A4
		// (set) Token: 0x06000AD7 RID: 2775 RVA: 0x000437E0 File Offset: 0x000419E0
		public unsafe bool resizable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_get_resizable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 300286, RefRangeEnd = 300287, XrefRangeStart = 300286, XrefRangeEnd = 300286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_set_resizable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000AD8 RID: 2776 RVA: 0x00043820 File Offset: 0x00041A20
		// (set) Token: 0x06000AD9 RID: 2777 RVA: 0x00043860 File Offset: 0x00041A60
		public unsafe Func<VisualElement> makeHeader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_get_makeHeader_Public_get_Func_1_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<VisualElement>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 300289, RefRangeEnd = 300290, XrefRangeStart = 300287, XrefRangeEnd = 300289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_set_makeHeader_Public_set_Void_Func_1_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000ADA RID: 2778 RVA: 0x000438A4 File Offset: 0x00041AA4
		// (set) Token: 0x06000B1F RID: 2847 RVA: 0x000441E4 File Offset: 0x000423E4
		public unsafe Action<VisualElement> bindHeader
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_get_bindHeader_Public_get_Action_1_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<VisualElement>>(intPtr3) : null;
			}
			set
			{
				bool flag = this.m_BindHeader == value;
				if (!flag)
				{
					this.m_BindHeader = value;
					this.NotifyChange(ColumnDataType.HeaderTemplate);
				}
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000ADB RID: 2779 RVA: 0x000438E4 File Offset: 0x00041AE4
		// (set) Token: 0x06000B20 RID: 2848 RVA: 0x00044214 File Offset: 0x00042414
		public unsafe Action<VisualElement> unbindHeader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_get_unbindHeader_Public_get_Action_1_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<VisualElement>>(intPtr3) : null;
			}
			set
			{
				bool flag = this.m_UnbindHeader == value;
				if (!flag)
				{
					this.m_UnbindHeader = value;
					this.NotifyChange(ColumnDataType.HeaderTemplate);
				}
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000ADC RID: 2780 RVA: 0x00043924 File Offset: 0x00041B24
		// (set) Token: 0x06000B21 RID: 2849 RVA: 0x00044244 File Offset: 0x00042444
		public unsafe Action<VisualElement> destroyHeader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_get_destroyHeader_Public_get_Action_1_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<VisualElement>>(intPtr3) : null;
			}
			set
			{
				bool flag = this.m_DestroyHeader == value;
				if (!flag)
				{
					this.m_DestroyHeader = value;
					this.NotifyChange(ColumnDataType.HeaderTemplate);
				}
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000ADD RID: 2781 RVA: 0x00043964 File Offset: 0x00041B64
		// (set) Token: 0x06000ADE RID: 2782 RVA: 0x000439A4 File Offset: 0x00041BA4
		public unsafe Func<VisualElement> makeCell
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_get_makeCell_Public_get_Func_1_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<VisualElement>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 300292, RefRangeEnd = 300293, XrefRangeStart = 300290, XrefRangeEnd = 300292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_set_makeCell_Public_set_Void_Func_1_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x000439E8 File Offset: 0x00041BE8
		// (set) Token: 0x06000B22 RID: 2850 RVA: 0x00044274 File Offset: 0x00042474
		public unsafe Action<VisualElement, int> bindCell
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_get_bindCell_Public_get_Action_2_VisualElement_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<VisualElement, int>>(intPtr3) : null;
			}
			set
			{
				bool flag = this.m_BindCell == value;
				if (!flag)
				{
					this.m_BindCell = value;
					this.NotifyChange(ColumnDataType.CellTemplate);
				}
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x00043A28 File Offset: 0x00041C28
		// (set) Token: 0x06000B23 RID: 2851 RVA: 0x000442A4 File Offset: 0x000424A4
		public unsafe Action<VisualElement, int> unbindCell
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_get_unbindCell_Public_get_Action_2_VisualElement_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<VisualElement, int>>(intPtr3) : null;
			}
			set
			{
				bool flag = this.m_UnbindCellItem == value;
				if (!flag)
				{
					this.m_UnbindCellItem = value;
					this.NotifyChange(ColumnDataType.CellTemplate);
				}
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000AE1 RID: 2785 RVA: 0x00043A68 File Offset: 0x00041C68
		// (set) Token: 0x06000B24 RID: 2852 RVA: 0x000060FB File Offset: 0x000042FB
		public unsafe Action<VisualElement> destroyCell
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_get_destroyCell_Public_get_Action_1_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<VisualElement>>(intPtr3) : null;
			}
			set
			{
				this._destroyCell_k__BackingField = value;
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x00043AA8 File Offset: 0x00041CA8
		// (set) Token: 0x06000AE3 RID: 2787 RVA: 0x00043AE8 File Offset: 0x00041CE8
		public unsafe Columns collection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_get_collection_Public_get_Columns_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Columns>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_set_collection_Internal_set_Void_Columns_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x00043B2C File Offset: 0x00041D2C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 300298, RefRangeEnd = 300302, XrefRangeStart = 300293, XrefRangeEnd = 300298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_changed(Action<Column, ColumnDataType> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_add_changed_Internal_add_Void_Action_2_Column_ColumnDataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x00043B70 File Offset: 0x00041D70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 300307, RefRangeEnd = 300309, XrefRangeStart = 300302, XrefRangeEnd = 300307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_changed(Action<Column, ColumnDataType> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_remove_changed_Internal_rem_Void_Action_2_Column_ColumnDataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x00043BB4 File Offset: 0x00041DB4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 300314, RefRangeEnd = 300318, XrefRangeStart = 300309, XrefRangeEnd = 300314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_resized(Action<Column> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_add_resized_Internal_add_Void_Action_1_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x00043BF8 File Offset: 0x00041DF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 300323, RefRangeEnd = 300325, XrefRangeStart = 300318, XrefRangeEnd = 300323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_resized(Action<Column> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_remove_resized_Internal_rem_Void_Action_1_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x00043C3C File Offset: 0x00041E3C
		[CallerCount(0)]
		public unsafe void NotifyChange(ColumnDataType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_NotifyChange_Private_Void_ColumnDataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x00043C7C File Offset: 0x00041E7C
		[CallerCount(0)]
		public unsafe float GetWidth(float layoutWidth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref layoutWidth;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_GetWidth_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x00043CC8 File Offset: 0x00041EC8
		[CallerCount(0)]
		public unsafe float GetMaxWidth(float layoutWidth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref layoutWidth;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_GetMaxWidth_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x00043D14 File Offset: 0x00041F14
		[CallerCount(0)]
		public unsafe float GetMinWidth(float layoutWidth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref layoutWidth;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr_GetMinWidth_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x00043D60 File Offset: 0x00041F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300325, XrefRangeEnd = 300329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Column()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Column>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x00005E2C File Offset: 0x0000402C
		public Column(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000AEE RID: 2798 RVA: 0x00043D9C File Offset: 0x00041F9C
		// (set) Token: 0x06000AEF RID: 2799 RVA: 0x00005E35 File Offset: 0x00004035
		public unsafe static string k_InvalidTemplateError
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Column.NativeFieldInfoPtr_k_InvalidTemplateError, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Column.NativeFieldInfoPtr_k_InvalidTemplateError, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000AF0 RID: 2800 RVA: 0x00043DBC File Offset: 0x00041FBC
		// (set) Token: 0x06000AF1 RID: 2801 RVA: 0x00005E47 File Offset: 0x00004047
		public unsafe string m_Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr_m_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr_m_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000AF2 RID: 2802 RVA: 0x00043DE4 File Offset: 0x00041FE4
		// (set) Token: 0x06000AF3 RID: 2803 RVA: 0x00005E66 File Offset: 0x00004066
		public unsafe string m_Title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr_m_Title);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr_m_Title), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000AF4 RID: 2804 RVA: 0x00043E0C File Offset: 0x0004200C
		// (set) Token: 0x06000AF5 RID: 2805 RVA: 0x00005E85 File Offset: 0x00004085
		public Background m_Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr_m_Icon);
				return new Background(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Background>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr_m_Icon), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Background>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000AF6 RID: 2806 RVA: 0x00043E3C File Offset: 0x0004203C
		// (set) Token: 0x06000AF7 RID: 2807 RVA: 0x00005EB3 File Offset: 0x000040B3
		public unsafe bool m_Visible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr_m_Visible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr_m_Visible)) = value;
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000AF8 RID: 2808 RVA: 0x00043E64 File Offset: 0x00042064
		// (set) Token: 0x06000AF9 RID: 2809 RVA: 0x00005ECE File Offset: 0x000040CE
		public unsafe Length m_Width
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr_m_Width);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr_m_Width)) = value;
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000AFA RID: 2810 RVA: 0x00043E8C File Offset: 0x0004208C
		// (set) Token: 0x06000AFB RID: 2811 RVA: 0x00005EE9 File Offset: 0x000040E9
		public unsafe Length m_MinWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr_m_MinWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr_m_MinWidth)) = value;
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000AFC RID: 2812 RVA: 0x00043EB4 File Offset: 0x000420B4
		// (set) Token: 0x06000AFD RID: 2813 RVA: 0x00005F04 File Offset: 0x00004104
		public unsafe Length m_MaxWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr_m_MaxWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr_m_MaxWidth)) = value;
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000AFE RID: 2814 RVA: 0x00043EDC File Offset: 0x000420DC
		// (set) Token: 0x06000AFF RID: 2815 RVA: 0x00005F1F File Offset: 0x0000411F
		public unsafe float m_DesiredWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr_m_DesiredWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr_m_DesiredWidth)) = value;
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000B00 RID: 2816 RVA: 0x00043F04 File Offset: 0x00042104
		// (set) Token: 0x06000B01 RID: 2817 RVA: 0x00005F3A File Offset: 0x0000413A
		public unsafe bool m_Stretchable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr_m_Stretchable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr_m_Stretchable)) = value;
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000B02 RID: 2818 RVA: 0x00043F2C File Offset: 0x0004212C
		// (set) Token: 0x06000B03 RID: 2819 RVA: 0x00005F55 File Offset: 0x00004155
		public unsafe bool m_Sortable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr_m_Sortable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr_m_Sortable)) = value;
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000B04 RID: 2820 RVA: 0x00043F54 File Offset: 0x00042154
		// (set) Token: 0x06000B05 RID: 2821 RVA: 0x00005F70 File Offset: 0x00004170
		public unsafe bool m_Optional
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr_m_Optional);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr_m_Optional)) = value;
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000B06 RID: 2822 RVA: 0x00043F7C File Offset: 0x0004217C
		// (set) Token: 0x06000B07 RID: 2823 RVA: 0x00005F8B File Offset: 0x0000418B
		public unsafe bool m_Resizable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr_m_Resizable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr_m_Resizable)) = value;
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000B08 RID: 2824 RVA: 0x00043FA4 File Offset: 0x000421A4
		// (set) Token: 0x06000B09 RID: 2825 RVA: 0x00005FA6 File Offset: 0x000041A6
		public unsafe Func<VisualElement> m_MakeHeader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr_m_MakeHeader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<VisualElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr_m_MakeHeader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000B0A RID: 2826 RVA: 0x00043FD4 File Offset: 0x000421D4
		// (set) Token: 0x06000B0B RID: 2827 RVA: 0x00005FC5 File Offset: 0x000041C5
		public unsafe Action<VisualElement> m_BindHeader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr_m_BindHeader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<VisualElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr_m_BindHeader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000B0C RID: 2828 RVA: 0x00044004 File Offset: 0x00042204
		// (set) Token: 0x06000B0D RID: 2829 RVA: 0x00005FE4 File Offset: 0x000041E4
		public unsafe Action<VisualElement> m_UnbindHeader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr_m_UnbindHeader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<VisualElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr_m_UnbindHeader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000B0E RID: 2830 RVA: 0x00044034 File Offset: 0x00042234
		// (set) Token: 0x06000B0F RID: 2831 RVA: 0x00006003 File Offset: 0x00004203
		public unsafe Action<VisualElement> m_DestroyHeader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr_m_DestroyHeader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<VisualElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr_m_DestroyHeader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000B10 RID: 2832 RVA: 0x00044064 File Offset: 0x00042264
		// (set) Token: 0x06000B11 RID: 2833 RVA: 0x00006022 File Offset: 0x00004222
		public unsafe Func<VisualElement> m_MakeCell
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr_m_MakeCell);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<VisualElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr_m_MakeCell), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000B12 RID: 2834 RVA: 0x00044094 File Offset: 0x00042294
		// (set) Token: 0x06000B13 RID: 2835 RVA: 0x00006041 File Offset: 0x00004241
		public unsafe Action<VisualElement, int> m_BindCell
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr_m_BindCell);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<VisualElement, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr_m_BindCell), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000B14 RID: 2836 RVA: 0x000440C4 File Offset: 0x000422C4
		// (set) Token: 0x06000B15 RID: 2837 RVA: 0x00006060 File Offset: 0x00004260
		public unsafe Action<VisualElement, int> m_UnbindCellItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr_m_UnbindCellItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<VisualElement, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr_m_UnbindCellItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000B16 RID: 2838 RVA: 0x000440F4 File Offset: 0x000422F4
		// (set) Token: 0x06000B17 RID: 2839 RVA: 0x0000607F File Offset: 0x0000427F
		public unsafe Action<VisualElement> _destroyCell_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr__destroyCell_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<VisualElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr__destroyCell_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000B18 RID: 2840 RVA: 0x00044124 File Offset: 0x00042324
		// (set) Token: 0x06000B19 RID: 2841 RVA: 0x0000609E File Offset: 0x0000429E
		public unsafe Columns _collection_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr__collection_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Columns>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr__collection_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000B1A RID: 2842 RVA: 0x00044154 File Offset: 0x00042354
		// (set) Token: 0x06000B1B RID: 2843 RVA: 0x000060BD File Offset: 0x000042BD
		public unsafe Action<Column, ColumnDataType> changed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr_changed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Column, ColumnDataType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr_changed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000B1C RID: 2844 RVA: 0x00044184 File Offset: 0x00042384
		// (set) Token: 0x06000B1D RID: 2845 RVA: 0x000060DC File Offset: 0x000042DC
		public unsafe Action<Column> resized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr_resized);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Column>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.NativeFieldInfoPtr_resized), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000772 RID: 1906
		private static readonly IntPtr NativeFieldInfoPtr_k_InvalidTemplateError;

		// Token: 0x04000773 RID: 1907
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x04000774 RID: 1908
		private static readonly IntPtr NativeFieldInfoPtr_m_Title;

		// Token: 0x04000775 RID: 1909
		private static readonly IntPtr NativeFieldInfoPtr_m_Icon;

		// Token: 0x04000776 RID: 1910
		private static readonly IntPtr NativeFieldInfoPtr_m_Visible;

		// Token: 0x04000777 RID: 1911
		private static readonly IntPtr NativeFieldInfoPtr_m_Width;

		// Token: 0x04000778 RID: 1912
		private static readonly IntPtr NativeFieldInfoPtr_m_MinWidth;

		// Token: 0x04000779 RID: 1913
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxWidth;

		// Token: 0x0400077A RID: 1914
		private static readonly IntPtr NativeFieldInfoPtr_m_DesiredWidth;

		// Token: 0x0400077B RID: 1915
		private static readonly IntPtr NativeFieldInfoPtr_m_Stretchable;

		// Token: 0x0400077C RID: 1916
		private static readonly IntPtr NativeFieldInfoPtr_m_Sortable;

		// Token: 0x0400077D RID: 1917
		private static readonly IntPtr NativeFieldInfoPtr_m_Optional;

		// Token: 0x0400077E RID: 1918
		private static readonly IntPtr NativeFieldInfoPtr_m_Resizable;

		// Token: 0x0400077F RID: 1919
		private static readonly IntPtr NativeFieldInfoPtr_m_MakeHeader;

		// Token: 0x04000780 RID: 1920
		private static readonly IntPtr NativeFieldInfoPtr_m_BindHeader;

		// Token: 0x04000781 RID: 1921
		private static readonly IntPtr NativeFieldInfoPtr_m_UnbindHeader;

		// Token: 0x04000782 RID: 1922
		private static readonly IntPtr NativeFieldInfoPtr_m_DestroyHeader;

		// Token: 0x04000783 RID: 1923
		private static readonly IntPtr NativeFieldInfoPtr_m_MakeCell;

		// Token: 0x04000784 RID: 1924
		private static readonly IntPtr NativeFieldInfoPtr_m_BindCell;

		// Token: 0x04000785 RID: 1925
		private static readonly IntPtr NativeFieldInfoPtr_m_UnbindCellItem;

		// Token: 0x04000786 RID: 1926
		private static readonly IntPtr NativeFieldInfoPtr__destroyCell_k__BackingField;

		// Token: 0x04000787 RID: 1927
		private static readonly IntPtr NativeFieldInfoPtr__collection_k__BackingField;

		// Token: 0x04000788 RID: 1928
		private static readonly IntPtr NativeFieldInfoPtr_changed;

		// Token: 0x04000789 RID: 1929
		private static readonly IntPtr NativeFieldInfoPtr_resized;

		// Token: 0x0400078A RID: 1930
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

		// Token: 0x0400078B RID: 1931
		private static readonly IntPtr NativeMethodInfoPtr_set_name_Public_set_Void_String_0;

		// Token: 0x0400078C RID: 1932
		private static readonly IntPtr NativeMethodInfoPtr_get_title_Public_get_String_0;

		// Token: 0x0400078D RID: 1933
		private static readonly IntPtr NativeMethodInfoPtr_set_title_Public_set_Void_String_0;

		// Token: 0x0400078E RID: 1934
		private static readonly IntPtr NativeMethodInfoPtr_get_icon_Public_get_Background_0;

		// Token: 0x0400078F RID: 1935
		private static readonly IntPtr NativeMethodInfoPtr_get_index_Internal_get_Int32_0;

		// Token: 0x04000790 RID: 1936
		private static readonly IntPtr NativeMethodInfoPtr_get_displayIndex_Internal_get_Int32_0;

		// Token: 0x04000791 RID: 1937
		private static readonly IntPtr NativeMethodInfoPtr_get_visibleIndex_Internal_get_Int32_0;

		// Token: 0x04000792 RID: 1938
		private static readonly IntPtr NativeMethodInfoPtr_get_visible_Public_get_Boolean_0;

		// Token: 0x04000793 RID: 1939
		private static readonly IntPtr NativeMethodInfoPtr_set_visible_Public_set_Void_Boolean_0;

		// Token: 0x04000794 RID: 1940
		private static readonly IntPtr NativeMethodInfoPtr_get_width_Public_get_Length_0;

		// Token: 0x04000795 RID: 1941
		private static readonly IntPtr NativeMethodInfoPtr_set_width_Public_set_Void_Length_0;

		// Token: 0x04000796 RID: 1942
		private static readonly IntPtr NativeMethodInfoPtr_get_minWidth_Public_get_Length_0;

		// Token: 0x04000797 RID: 1943
		private static readonly IntPtr NativeMethodInfoPtr_set_minWidth_Public_set_Void_Length_0;

		// Token: 0x04000798 RID: 1944
		private static readonly IntPtr NativeMethodInfoPtr_get_maxWidth_Public_get_Length_0;

		// Token: 0x04000799 RID: 1945
		private static readonly IntPtr NativeMethodInfoPtr_set_maxWidth_Public_set_Void_Length_0;

		// Token: 0x0400079A RID: 1946
		private static readonly IntPtr NativeMethodInfoPtr_get_desiredWidth_Internal_get_Single_0;

		// Token: 0x0400079B RID: 1947
		private static readonly IntPtr NativeMethodInfoPtr_set_desiredWidth_Internal_set_Void_Single_0;

		// Token: 0x0400079C RID: 1948
		private static readonly IntPtr NativeMethodInfoPtr_get_sortable_Public_get_Boolean_0;

		// Token: 0x0400079D RID: 1949
		private static readonly IntPtr NativeMethodInfoPtr_set_sortable_Public_set_Void_Boolean_0;

		// Token: 0x0400079E RID: 1950
		private static readonly IntPtr NativeMethodInfoPtr_get_stretchable_Public_get_Boolean_0;

		// Token: 0x0400079F RID: 1951
		private static readonly IntPtr NativeMethodInfoPtr_set_stretchable_Public_set_Void_Boolean_0;

		// Token: 0x040007A0 RID: 1952
		private static readonly IntPtr NativeMethodInfoPtr_get_optional_Public_get_Boolean_0;

		// Token: 0x040007A1 RID: 1953
		private static readonly IntPtr NativeMethodInfoPtr_set_optional_Public_set_Void_Boolean_0;

		// Token: 0x040007A2 RID: 1954
		private static readonly IntPtr NativeMethodInfoPtr_get_resizable_Public_get_Boolean_0;

		// Token: 0x040007A3 RID: 1955
		private static readonly IntPtr NativeMethodInfoPtr_set_resizable_Public_set_Void_Boolean_0;

		// Token: 0x040007A4 RID: 1956
		private static readonly IntPtr NativeMethodInfoPtr_get_makeHeader_Public_get_Func_1_VisualElement_0;

		// Token: 0x040007A5 RID: 1957
		private static readonly IntPtr NativeMethodInfoPtr_set_makeHeader_Public_set_Void_Func_1_VisualElement_0;

		// Token: 0x040007A6 RID: 1958
		private static readonly IntPtr NativeMethodInfoPtr_get_bindHeader_Public_get_Action_1_VisualElement_0;

		// Token: 0x040007A7 RID: 1959
		private static readonly IntPtr NativeMethodInfoPtr_get_unbindHeader_Public_get_Action_1_VisualElement_0;

		// Token: 0x040007A8 RID: 1960
		private static readonly IntPtr NativeMethodInfoPtr_get_destroyHeader_Public_get_Action_1_VisualElement_0;

		// Token: 0x040007A9 RID: 1961
		private static readonly IntPtr NativeMethodInfoPtr_get_makeCell_Public_get_Func_1_VisualElement_0;

		// Token: 0x040007AA RID: 1962
		private static readonly IntPtr NativeMethodInfoPtr_set_makeCell_Public_set_Void_Func_1_VisualElement_0;

		// Token: 0x040007AB RID: 1963
		private static readonly IntPtr NativeMethodInfoPtr_get_bindCell_Public_get_Action_2_VisualElement_Int32_0;

		// Token: 0x040007AC RID: 1964
		private static readonly IntPtr NativeMethodInfoPtr_get_unbindCell_Public_get_Action_2_VisualElement_Int32_0;

		// Token: 0x040007AD RID: 1965
		private static readonly IntPtr NativeMethodInfoPtr_get_destroyCell_Public_get_Action_1_VisualElement_0;

		// Token: 0x040007AE RID: 1966
		private static readonly IntPtr NativeMethodInfoPtr_get_collection_Public_get_Columns_0;

		// Token: 0x040007AF RID: 1967
		private static readonly IntPtr NativeMethodInfoPtr_set_collection_Internal_set_Void_Columns_0;

		// Token: 0x040007B0 RID: 1968
		private static readonly IntPtr NativeMethodInfoPtr_add_changed_Internal_add_Void_Action_2_Column_ColumnDataType_0;

		// Token: 0x040007B1 RID: 1969
		private static readonly IntPtr NativeMethodInfoPtr_remove_changed_Internal_rem_Void_Action_2_Column_ColumnDataType_0;

		// Token: 0x040007B2 RID: 1970
		private static readonly IntPtr NativeMethodInfoPtr_add_resized_Internal_add_Void_Action_1_Column_0;

		// Token: 0x040007B3 RID: 1971
		private static readonly IntPtr NativeMethodInfoPtr_remove_resized_Internal_rem_Void_Action_1_Column_0;

		// Token: 0x040007B4 RID: 1972
		private static readonly IntPtr NativeMethodInfoPtr_NotifyChange_Private_Void_ColumnDataType_0;

		// Token: 0x040007B5 RID: 1973
		private static readonly IntPtr NativeMethodInfoPtr_GetWidth_Internal_Single_Single_0;

		// Token: 0x040007B6 RID: 1974
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxWidth_Internal_Single_Single_0;

		// Token: 0x040007B7 RID: 1975
		private static readonly IntPtr NativeMethodInfoPtr_GetMinWidth_Internal_Single_Single_0;

		// Token: 0x040007B8 RID: 1976
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040007B9 RID: 1977
		public const float kDefaultMinWidth = 35f;

		// Token: 0x02000399 RID: 921
		public class UxmlObjectFactory<T> : UxmlObjectFactory<T, Column.UxmlObjectTraits<T>> where T : Column, new()
		{
			// Token: 0x06003894 RID: 14484 RVA: 0x000E6D40 File Offset: 0x000E4F40
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlObjectFactory()
			{
				Il2CppClassPointerStore<Column.UxmlObjectFactory<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Column>.NativeClassPtr, "UxmlObjectFactory`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Column.UxmlObjectFactory<T>>.NativeClassPtr);
				Column.UxmlObjectFactory<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column.UxmlObjectFactory<T>>.NativeClassPtr, 100664902);
			}

			// Token: 0x06003895 RID: 14485 RVA: 0x000E6DBC File Offset: 0x000E4FBC
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 300055, RefRangeEnd = 300059, XrefRangeStart = 300043, XrefRangeEnd = 300055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlObjectFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Column.UxmlObjectFactory<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.UxmlObjectFactory<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003896 RID: 14486 RVA: 0x0001792D File Offset: 0x00015B2D
			public UxmlObjectFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002831 RID: 10289
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200039A RID: 922
		public class UxmlObjectTraits<T> : UnityEngine.UIElements.UxmlObjectTraits<T> where T : Column
		{
			// Token: 0x06003897 RID: 14487 RVA: 0x000E6DF8 File Offset: 0x000E4FF8
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlObjectTraits()
			{
				Il2CppClassPointerStore<Column.UxmlObjectTraits<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Column>.NativeClassPtr, "UxmlObjectTraits`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Column.UxmlObjectTraits<T>>.NativeClassPtr);
				Column.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Column.UxmlObjectTraits<T>>.NativeClassPtr, "m_Name");
				Column.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Column.UxmlObjectTraits<T>>.NativeClassPtr, "m_Text");
				Column.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_Visible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Column.UxmlObjectTraits<T>>.NativeClassPtr, "m_Visible");
				Column.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Column.UxmlObjectTraits<T>>.NativeClassPtr, "m_Width");
				Column.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_MinWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Column.UxmlObjectTraits<T>>.NativeClassPtr, "m_MinWidth");
				Column.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_MaxWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Column.UxmlObjectTraits<T>>.NativeClassPtr, "m_MaxWidth");
				Column.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_Stretch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Column.UxmlObjectTraits<T>>.NativeClassPtr, "m_Stretch");
				Column.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_Sortable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Column.UxmlObjectTraits<T>>.NativeClassPtr, "m_Sortable");
				Column.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_Optional = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Column.UxmlObjectTraits<T>>.NativeClassPtr, "m_Optional");
				Column.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_Resizable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Column.UxmlObjectTraits<T>>.NativeClassPtr, "m_Resizable");
				Column.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_HeaderTemplateId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Column.UxmlObjectTraits<T>>.NativeClassPtr, "m_HeaderTemplateId");
				Column.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_CellTemplateId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Column.UxmlObjectTraits<T>>.NativeClassPtr, "m_CellTemplateId");
				Column.UxmlObjectTraits<T>.NativeMethodInfoPtr_ParseLength_Private_Static_Length_String_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column.UxmlObjectTraits<T>>.NativeClassPtr, 100664903);
				Column.UxmlObjectTraits<T>.NativeMethodInfoPtr_Init_Public_Virtual_Void_byref_T_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column.UxmlObjectTraits<T>>.NativeClassPtr, 100664904);
				Column.UxmlObjectTraits<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column.UxmlObjectTraits<T>>.NativeClassPtr, 100664905);
			}

			// Token: 0x06003898 RID: 14488 RVA: 0x000E6F8C File Offset: 0x000E518C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300083, XrefRangeEnd = 300103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Length ParseLength(string str, Length defaultValue)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.UxmlObjectTraits<T>.NativeMethodInfoPtr_ParseLength_Private_Static_Length_String_Length_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003899 RID: 14489 RVA: 0x000E6FDC File Offset: 0x000E51DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300103, XrefRangeEnd = 300145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Init(ref T obj, IUxmlAttributes bag, CreationContext cc)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					intPtr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					ptr2 = &intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bag);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cc));
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Column.UxmlObjectTraits<T>.NativeMethodInfoPtr_Init_Public_Virtual_Void_byref_T_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				obj = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			}

			// Token: 0x0600389A RID: 14490 RVA: 0x000E706C File Offset: 0x000E526C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300145, XrefRangeEnd = 300234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlObjectTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Column.UxmlObjectTraits<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.UxmlObjectTraits<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600389B RID: 14491 RVA: 0x00017936 File Offset: 0x00015B36
			public UxmlObjectTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700116C RID: 4460
			// (get) Token: 0x0600389C RID: 14492 RVA: 0x000E70A8 File Offset: 0x000E52A8
			// (set) Token: 0x0600389D RID: 14493 RVA: 0x0001793F File Offset: 0x00015B3F
			public unsafe UxmlStringAttributeDescription m_Name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_Name);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlStringAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_Name), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700116D RID: 4461
			// (get) Token: 0x0600389E RID: 14494 RVA: 0x000E70D8 File Offset: 0x000E52D8
			// (set) Token: 0x0600389F RID: 14495 RVA: 0x0001795E File Offset: 0x00015B5E
			public unsafe UxmlStringAttributeDescription m_Text
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_Text);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlStringAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_Text), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700116E RID: 4462
			// (get) Token: 0x060038A0 RID: 14496 RVA: 0x000E7108 File Offset: 0x000E5308
			// (set) Token: 0x060038A1 RID: 14497 RVA: 0x0001797D File Offset: 0x00015B7D
			public unsafe UxmlBoolAttributeDescription m_Visible
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_Visible);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlBoolAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_Visible), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700116F RID: 4463
			// (get) Token: 0x060038A2 RID: 14498 RVA: 0x000E7138 File Offset: 0x000E5338
			// (set) Token: 0x060038A3 RID: 14499 RVA: 0x0001799C File Offset: 0x00015B9C
			public unsafe UxmlStringAttributeDescription m_Width
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_Width);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlStringAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_Width), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001170 RID: 4464
			// (get) Token: 0x060038A4 RID: 14500 RVA: 0x000E7168 File Offset: 0x000E5368
			// (set) Token: 0x060038A5 RID: 14501 RVA: 0x000179BB File Offset: 0x00015BBB
			public unsafe UxmlStringAttributeDescription m_MinWidth
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_MinWidth);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlStringAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_MinWidth), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001171 RID: 4465
			// (get) Token: 0x060038A6 RID: 14502 RVA: 0x000E7198 File Offset: 0x000E5398
			// (set) Token: 0x060038A7 RID: 14503 RVA: 0x000179DA File Offset: 0x00015BDA
			public unsafe UxmlStringAttributeDescription m_MaxWidth
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_MaxWidth);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlStringAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_MaxWidth), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001172 RID: 4466
			// (get) Token: 0x060038A8 RID: 14504 RVA: 0x000E71C8 File Offset: 0x000E53C8
			// (set) Token: 0x060038A9 RID: 14505 RVA: 0x000179F9 File Offset: 0x00015BF9
			public unsafe UxmlBoolAttributeDescription m_Stretch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_Stretch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlBoolAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_Stretch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001173 RID: 4467
			// (get) Token: 0x060038AA RID: 14506 RVA: 0x000E71F8 File Offset: 0x000E53F8
			// (set) Token: 0x060038AB RID: 14507 RVA: 0x00017A18 File Offset: 0x00015C18
			public unsafe UxmlBoolAttributeDescription m_Sortable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_Sortable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlBoolAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_Sortable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001174 RID: 4468
			// (get) Token: 0x060038AC RID: 14508 RVA: 0x000E7228 File Offset: 0x000E5428
			// (set) Token: 0x060038AD RID: 14509 RVA: 0x00017A37 File Offset: 0x00015C37
			public unsafe UxmlBoolAttributeDescription m_Optional
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_Optional);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlBoolAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_Optional), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001175 RID: 4469
			// (get) Token: 0x060038AE RID: 14510 RVA: 0x000E7258 File Offset: 0x000E5458
			// (set) Token: 0x060038AF RID: 14511 RVA: 0x00017A56 File Offset: 0x00015C56
			public unsafe UxmlBoolAttributeDescription m_Resizable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_Resizable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlBoolAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_Resizable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001176 RID: 4470
			// (get) Token: 0x060038B0 RID: 14512 RVA: 0x000E7288 File Offset: 0x000E5488
			// (set) Token: 0x060038B1 RID: 14513 RVA: 0x00017A75 File Offset: 0x00015C75
			public unsafe UxmlStringAttributeDescription m_HeaderTemplateId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_HeaderTemplateId);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlStringAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_HeaderTemplateId), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001177 RID: 4471
			// (get) Token: 0x060038B2 RID: 14514 RVA: 0x000E72B8 File Offset: 0x000E54B8
			// (set) Token: 0x060038B3 RID: 14515 RVA: 0x00017A94 File Offset: 0x00015C94
			public unsafe UxmlStringAttributeDescription m_CellTemplateId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_CellTemplateId);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlStringAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_CellTemplateId), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002832 RID: 10290
			private static readonly IntPtr NativeFieldInfoPtr_m_Name;

			// Token: 0x04002833 RID: 10291
			private static readonly IntPtr NativeFieldInfoPtr_m_Text;

			// Token: 0x04002834 RID: 10292
			private static readonly IntPtr NativeFieldInfoPtr_m_Visible;

			// Token: 0x04002835 RID: 10293
			private static readonly IntPtr NativeFieldInfoPtr_m_Width;

			// Token: 0x04002836 RID: 10294
			private static readonly IntPtr NativeFieldInfoPtr_m_MinWidth;

			// Token: 0x04002837 RID: 10295
			private static readonly IntPtr NativeFieldInfoPtr_m_MaxWidth;

			// Token: 0x04002838 RID: 10296
			private static readonly IntPtr NativeFieldInfoPtr_m_Stretch;

			// Token: 0x04002839 RID: 10297
			private static readonly IntPtr NativeFieldInfoPtr_m_Sortable;

			// Token: 0x0400283A RID: 10298
			private static readonly IntPtr NativeFieldInfoPtr_m_Optional;

			// Token: 0x0400283B RID: 10299
			private static readonly IntPtr NativeFieldInfoPtr_m_Resizable;

			// Token: 0x0400283C RID: 10300
			private static readonly IntPtr NativeFieldInfoPtr_m_HeaderTemplateId;

			// Token: 0x0400283D RID: 10301
			private static readonly IntPtr NativeFieldInfoPtr_m_CellTemplateId;

			// Token: 0x0400283E RID: 10302
			private static readonly IntPtr NativeMethodInfoPtr_ParseLength_Private_Static_Length_String_Length_0;

			// Token: 0x0400283F RID: 10303
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_byref_T_IUxmlAttributes_CreationContext_0;

			// Token: 0x04002840 RID: 10304
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0200058A RID: 1418
			[ObfuscatedName("UnityEngine.UIElements.Column+UxmlObjectTraits`1+<>c__DisplayClass15_0")]
			public sealed class __c__DisplayClass15_0 : Object
			{
				// Token: 0x060042AB RID: 17067 RVA: 0x00105594 File Offset: 0x00103794
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass15_0()
				{
					Il2CppClassPointerStore<Column.UxmlObjectTraits<T>.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Column.UxmlObjectTraits<T>>.NativeClassPtr, "<>c__DisplayClass15_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Column.UxmlObjectTraits<T>.__c__DisplayClass15_0>.NativeClassPtr);
					Column.UxmlObjectTraits<T>.__c__DisplayClass15_0.NativeFieldInfoPtr_asset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Column.UxmlObjectTraits<T>.__c__DisplayClass15_0>.NativeClassPtr, "asset");
					Column.UxmlObjectTraits<T>.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column.UxmlObjectTraits<T>.__c__DisplayClass15_0>.NativeClassPtr, 100664906);
					Column.UxmlObjectTraits<T>.__c__DisplayClass15_0.NativeMethodInfoPtr__Init_b__0_Internal_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column.UxmlObjectTraits<T>.__c__DisplayClass15_0>.NativeClassPtr, 100664907);
				}

				// Token: 0x060042AC RID: 17068 RVA: 0x00105638 File Offset: 0x00103838
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass15_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Column.UxmlObjectTraits<T>.__c__DisplayClass15_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.UxmlObjectTraits<T>.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060042AD RID: 17069 RVA: 0x00105674 File Offset: 0x00103874
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300059, XrefRangeEnd = 300071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe VisualElement _Init_b__0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.UxmlObjectTraits<T>.__c__DisplayClass15_0.NativeMethodInfoPtr__Init_b__0_Internal_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
				}

				// Token: 0x060042AE RID: 17070 RVA: 0x0001C788 File Offset: 0x0001A988
				public __c__DisplayClass15_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170013F3 RID: 5107
				// (get) Token: 0x060042AF RID: 17071 RVA: 0x001056B4 File Offset: 0x001038B4
				// (set) Token: 0x060042B0 RID: 17072 RVA: 0x0001C791 File Offset: 0x0001A991
				public unsafe VisualTreeAsset asset
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.UxmlObjectTraits<T>.__c__DisplayClass15_0.NativeFieldInfoPtr_asset);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualTreeAsset>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.UxmlObjectTraits<T>.__c__DisplayClass15_0.NativeFieldInfoPtr_asset), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04002EB2 RID: 11954
				private static readonly IntPtr NativeFieldInfoPtr_asset;

				// Token: 0x04002EB3 RID: 11955
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04002EB4 RID: 11956
				private static readonly IntPtr NativeMethodInfoPtr__Init_b__0_Internal_VisualElement_0;
			}

			// Token: 0x0200058B RID: 1419
			[ObfuscatedName("UnityEngine.UIElements.Column+UxmlObjectTraits`1+<>c__DisplayClass15_1")]
			public sealed class __c__DisplayClass15_1 : Object
			{
				// Token: 0x060042B1 RID: 17073 RVA: 0x001056E4 File Offset: 0x001038E4
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass15_1()
				{
					Il2CppClassPointerStore<Column.UxmlObjectTraits<T>.__c__DisplayClass15_1>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Column.UxmlObjectTraits<T>>.NativeClassPtr, "<>c__DisplayClass15_1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Column.UxmlObjectTraits<T>.__c__DisplayClass15_1>.NativeClassPtr);
					Column.UxmlObjectTraits<T>.__c__DisplayClass15_1.NativeFieldInfoPtr_asset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Column.UxmlObjectTraits<T>.__c__DisplayClass15_1>.NativeClassPtr, "asset");
					Column.UxmlObjectTraits<T>.__c__DisplayClass15_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column.UxmlObjectTraits<T>.__c__DisplayClass15_1>.NativeClassPtr, 100664908);
					Column.UxmlObjectTraits<T>.__c__DisplayClass15_1.NativeMethodInfoPtr__Init_b__1_Internal_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Column.UxmlObjectTraits<T>.__c__DisplayClass15_1>.NativeClassPtr, 100664909);
				}

				// Token: 0x060042B2 RID: 17074 RVA: 0x00105788 File Offset: 0x00103988
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass15_1()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Column.UxmlObjectTraits<T>.__c__DisplayClass15_1>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.UxmlObjectTraits<T>.__c__DisplayClass15_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060042B3 RID: 17075 RVA: 0x001057C4 File Offset: 0x001039C4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300071, XrefRangeEnd = 300083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe VisualElement _Init_b__1()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Column.UxmlObjectTraits<T>.__c__DisplayClass15_1.NativeMethodInfoPtr__Init_b__1_Internal_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
				}

				// Token: 0x060042B4 RID: 17076 RVA: 0x0001C7B0 File Offset: 0x0001A9B0
				public __c__DisplayClass15_1(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170013F4 RID: 5108
				// (get) Token: 0x060042B5 RID: 17077 RVA: 0x00105804 File Offset: 0x00103A04
				// (set) Token: 0x060042B6 RID: 17078 RVA: 0x0001C7B9 File Offset: 0x0001A9B9
				public unsafe VisualTreeAsset asset
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.UxmlObjectTraits<T>.__c__DisplayClass15_1.NativeFieldInfoPtr_asset);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualTreeAsset>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Column.UxmlObjectTraits<T>.__c__DisplayClass15_1.NativeFieldInfoPtr_asset), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04002EB5 RID: 11957
				private static readonly IntPtr NativeFieldInfoPtr_asset;

				// Token: 0x04002EB6 RID: 11958
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04002EB7 RID: 11959
				private static readonly IntPtr NativeMethodInfoPtr__Init_b__1_Internal_VisualElement_0;
			}
		}
	}
}
