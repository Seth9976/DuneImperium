using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000076 RID: 118
	public class Columns : Object
	{
		// Token: 0x06000B7E RID: 2942 RVA: 0x0004599C File Offset: 0x00043B9C
		// Note: this type is marked as 'beforefieldinit'.
		static Columns()
		{
			Il2CppClassPointerStore<Columns>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "Columns");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Columns>.NativeClassPtr);
			Columns.NativeFieldInfoPtr_m_Columns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Columns>.NativeClassPtr, "m_Columns");
			Columns.NativeFieldInfoPtr_m_DisplayColumns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Columns>.NativeClassPtr, "m_DisplayColumns");
			Columns.NativeFieldInfoPtr_m_VisibleColumns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Columns>.NativeClassPtr, "m_VisibleColumns");
			Columns.NativeFieldInfoPtr_m_VisibleColumnsDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Columns>.NativeClassPtr, "m_VisibleColumnsDirty");
			Columns.NativeFieldInfoPtr_m_StretchMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Columns>.NativeClassPtr, "m_StretchMode");
			Columns.NativeFieldInfoPtr_m_Reorderable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Columns>.NativeClassPtr, "m_Reorderable");
			Columns.NativeFieldInfoPtr_m_Resizable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Columns>.NativeClassPtr, "m_Resizable");
			Columns.NativeFieldInfoPtr_m_ResizePreview = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Columns>.NativeClassPtr, "m_ResizePreview");
			Columns.NativeFieldInfoPtr_m_PrimaryColumnName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Columns>.NativeClassPtr, "m_PrimaryColumnName");
			Columns.NativeFieldInfoPtr_changed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Columns>.NativeClassPtr, "changed");
			Columns.NativeFieldInfoPtr_columnAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Columns>.NativeClassPtr, "columnAdded");
			Columns.NativeFieldInfoPtr_columnRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Columns>.NativeClassPtr, "columnRemoved");
			Columns.NativeFieldInfoPtr_columnChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Columns>.NativeClassPtr, "columnChanged");
			Columns.NativeFieldInfoPtr_columnResized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Columns>.NativeClassPtr, "columnResized");
			Columns.NativeFieldInfoPtr_columnReordered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Columns>.NativeClassPtr, "columnReordered");
			Columns.NativeMethodInfoPtr_get_primaryColumnName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664956);
			Columns.NativeMethodInfoPtr_set_primaryColumnName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664957);
			Columns.NativeMethodInfoPtr_get_reorderable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664958);
			Columns.NativeMethodInfoPtr_set_reorderable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664959);
			Columns.NativeMethodInfoPtr_get_resizable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664960);
			Columns.NativeMethodInfoPtr_set_resizable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664961);
			Columns.NativeMethodInfoPtr_get_resizePreview_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664962);
			Columns.NativeMethodInfoPtr_set_resizePreview_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664963);
			Columns.NativeMethodInfoPtr_get_displayList_Internal_get_IEnumerable_1_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664964);
			Columns.NativeMethodInfoPtr_get_visibleList_Internal_get_IEnumerable_1_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664965);
			Columns.NativeMethodInfoPtr_add_changed_Internal_add_Void_Action_1_ColumnsDataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664966);
			Columns.NativeMethodInfoPtr_remove_changed_Internal_rem_Void_Action_1_ColumnsDataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664967);
			Columns.NativeMethodInfoPtr_get_stretchMode_Public_get_StretchMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664968);
			Columns.NativeMethodInfoPtr_set_stretchMode_Public_set_Void_StretchMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664969);
			Columns.NativeMethodInfoPtr_add_columnAdded_Internal_add_Void_Action_2_Column_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664970);
			Columns.NativeMethodInfoPtr_remove_columnAdded_Internal_rem_Void_Action_2_Column_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664971);
			Columns.NativeMethodInfoPtr_add_columnRemoved_Internal_add_Void_Action_1_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664972);
			Columns.NativeMethodInfoPtr_remove_columnRemoved_Internal_rem_Void_Action_1_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664973);
			Columns.NativeMethodInfoPtr_add_columnChanged_Internal_add_Void_Action_2_Column_ColumnDataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664974);
			Columns.NativeMethodInfoPtr_remove_columnChanged_Internal_rem_Void_Action_2_Column_ColumnDataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664975);
			Columns.NativeMethodInfoPtr_add_columnResized_Internal_add_Void_Action_1_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664976);
			Columns.NativeMethodInfoPtr_remove_columnResized_Internal_rem_Void_Action_1_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664977);
			Columns.NativeMethodInfoPtr_add_columnReordered_Internal_add_Void_Action_3_Column_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664978);
			Columns.NativeMethodInfoPtr_remove_columnReordered_Internal_rem_Void_Action_3_Column_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664979);
			Columns.NativeMethodInfoPtr_IsPrimary_Public_Boolean_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664980);
			Columns.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664981);
			Columns.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664982);
			Columns.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664983);
			Columns.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664984);
			Columns.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664985);
			Columns.NativeMethodInfoPtr_Contains_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664986);
			Columns.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_Column_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664987);
			Columns.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664988);
			Columns.NativeMethodInfoPtr_OnColumnChanged_Private_Void_Column_ColumnDataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664989);
			Columns.NativeMethodInfoPtr_OnColumnResized_Private_Void_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664990);
			Columns.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664991);
			Columns.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664992);
			Columns.NativeMethodInfoPtr_IndexOf_Public_Int32_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664993);
			Columns.NativeMethodInfoPtr_Insert_Public_Void_Int32_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664994);
			Columns.NativeMethodInfoPtr_get_Item_Public_get_Column_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664995);
			Columns.NativeMethodInfoPtr_get_Item_Public_get_Column_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664996);
			Columns.NativeMethodInfoPtr_ReorderDisplay_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664997);
			Columns.NativeMethodInfoPtr_InitOrderColumns_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664998);
			Columns.NativeMethodInfoPtr_DirtyVisibleColumns_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100664999);
			Columns.NativeMethodInfoPtr_UpdateVisibleColumns_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100665000);
			Columns.NativeMethodInfoPtr_NotifyChange_Private_Void_ColumnsDataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100665001);
			Columns.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns>.NativeClassPtr, 100665002);
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000B7F RID: 2943 RVA: 0x00045EA4 File Offset: 0x000440A4
		// (set) Token: 0x06000B80 RID: 2944 RVA: 0x00045EDC File Offset: 0x000440DC
		public unsafe string primaryColumnName
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_get_primaryColumnName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 301321, RefRangeEnd = 301322, XrefRangeStart = 301319, XrefRangeEnd = 301321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_set_primaryColumnName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000B81 RID: 2945 RVA: 0x00045F20 File Offset: 0x00044120
		// (set) Token: 0x06000B82 RID: 2946 RVA: 0x00045F5C File Offset: 0x0004415C
		public unsafe bool reorderable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_get_reorderable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 301322, RefRangeEnd = 301323, XrefRangeStart = 301322, XrefRangeEnd = 301322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_set_reorderable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000B83 RID: 2947 RVA: 0x00045F9C File Offset: 0x0004419C
		// (set) Token: 0x06000B84 RID: 2948 RVA: 0x00045FD8 File Offset: 0x000441D8
		public unsafe bool resizable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_get_resizable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 301323, RefRangeEnd = 301324, XrefRangeStart = 301323, XrefRangeEnd = 301323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_set_resizable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000B85 RID: 2949 RVA: 0x00046018 File Offset: 0x00044218
		// (set) Token: 0x06000B86 RID: 2950 RVA: 0x00046054 File Offset: 0x00044254
		public unsafe bool resizePreview
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_get_resizePreview_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 301324, RefRangeEnd = 301325, XrefRangeStart = 301324, XrefRangeEnd = 301324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_set_resizePreview_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000B87 RID: 2951 RVA: 0x00046094 File Offset: 0x00044294
		public unsafe IEnumerable<Column> displayList
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 301326, RefRangeEnd = 301327, XrefRangeStart = 301325, XrefRangeEnd = 301326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_get_displayList_Internal_get_IEnumerable_1_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Column>>(intPtr3) : null;
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000B88 RID: 2952 RVA: 0x000460D4 File Offset: 0x000442D4
		public unsafe IEnumerable<Column> visibleList
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 301328, RefRangeEnd = 301341, XrefRangeStart = 301327, XrefRangeEnd = 301328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_get_visibleList_Internal_get_IEnumerable_1_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Column>>(intPtr3) : null;
			}
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x00046114 File Offset: 0x00044314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301341, XrefRangeEnd = 301346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_changed(Action<ColumnsDataType> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_add_changed_Internal_add_Void_Action_1_ColumnsDataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x00046158 File Offset: 0x00044358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301346, XrefRangeEnd = 301351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_changed(Action<ColumnsDataType> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_remove_changed_Internal_rem_Void_Action_1_ColumnsDataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000B8B RID: 2955 RVA: 0x0004619C File Offset: 0x0004439C
		// (set) Token: 0x06000B8C RID: 2956 RVA: 0x000461D8 File Offset: 0x000443D8
		public unsafe Columns.StretchMode stretchMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_get_stretchMode_Public_get_StretchMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 301351, RefRangeEnd = 301352, XrefRangeStart = 301351, XrefRangeEnd = 301351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_set_stretchMode_Public_set_Void_StretchMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x00046218 File Offset: 0x00044418
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 301357, RefRangeEnd = 301360, XrefRangeStart = 301352, XrefRangeEnd = 301357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_columnAdded(Action<Column, int> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_add_columnAdded_Internal_add_Void_Action_2_Column_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x0004625C File Offset: 0x0004445C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 301365, RefRangeEnd = 301366, XrefRangeStart = 301360, XrefRangeEnd = 301365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_columnAdded(Action<Column, int> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_remove_columnAdded_Internal_rem_Void_Action_2_Column_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x000462A0 File Offset: 0x000444A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 301371, RefRangeEnd = 301374, XrefRangeStart = 301366, XrefRangeEnd = 301371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_columnRemoved(Action<Column> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_add_columnRemoved_Internal_add_Void_Action_1_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x000462E4 File Offset: 0x000444E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 301379, RefRangeEnd = 301380, XrefRangeStart = 301374, XrefRangeEnd = 301379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_columnRemoved(Action<Column> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_remove_columnRemoved_Internal_rem_Void_Action_1_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x00046328 File Offset: 0x00044528
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 301385, RefRangeEnd = 301386, XrefRangeStart = 301380, XrefRangeEnd = 301385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_columnChanged(Action<Column, ColumnDataType> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_add_columnChanged_Internal_add_Void_Action_2_Column_ColumnDataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x0004636C File Offset: 0x0004456C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 301391, RefRangeEnd = 301392, XrefRangeStart = 301386, XrefRangeEnd = 301391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_columnChanged(Action<Column, ColumnDataType> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_remove_columnChanged_Internal_rem_Void_Action_2_Column_ColumnDataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x000463B0 File Offset: 0x000445B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 301397, RefRangeEnd = 301398, XrefRangeStart = 301392, XrefRangeEnd = 301397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_columnResized(Action<Column> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_add_columnResized_Internal_add_Void_Action_1_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x000463F4 File Offset: 0x000445F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 301403, RefRangeEnd = 301404, XrefRangeStart = 301398, XrefRangeEnd = 301403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_columnResized(Action<Column> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_remove_columnResized_Internal_rem_Void_Action_1_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x00046438 File Offset: 0x00044638
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 301409, RefRangeEnd = 301412, XrefRangeStart = 301404, XrefRangeEnd = 301409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_columnReordered(Action<Column, int, int> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_add_columnReordered_Internal_add_Void_Action_3_Column_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x0004647C File Offset: 0x0004467C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 301417, RefRangeEnd = 301418, XrefRangeStart = 301412, XrefRangeEnd = 301417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_columnReordered(Action<Column, int, int> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_remove_columnReordered_Internal_rem_Void_Action_3_Column_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x000464C0 File Offset: 0x000446C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 301419, RefRangeEnd = 301421, XrefRangeStart = 301418, XrefRangeEnd = 301419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPrimary(Column column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_IsPrimary_Public_Boolean_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x00046510 File Offset: 0x00044710
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 301425, RefRangeEnd = 301426, XrefRangeStart = 301421, XrefRangeEnd = 301425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<Column> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Column>>(intPtr3) : null;
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x00046550 File Offset: 0x00044750
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 301425, RefRangeEnd = 301426, XrefRangeStart = 301425, XrefRangeEnd = 301426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x00046590 File Offset: 0x00044790
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 301431, RefRangeEnd = 301432, XrefRangeStart = 301426, XrefRangeEnd = 301431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(Column item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x000465D4 File Offset: 0x000447D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301432, XrefRangeEnd = 301445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x00046608 File Offset: 0x00044808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301445, XrefRangeEnd = 301449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Contains(Column item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x00046658 File Offset: 0x00044858
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 301468, RefRangeEnd = 301469, XrefRangeStart = 301449, XrefRangeEnd = 301468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_Contains_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x000466A8 File Offset: 0x000448A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301469, XrefRangeEnd = 301474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Il2CppReferenceArray<Column> array, int arrayIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_Column_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x000466F8 File Offset: 0x000448F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 301482, RefRangeEnd = 301484, XrefRangeStart = 301474, XrefRangeEnd = 301482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Remove(Column column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x00046748 File Offset: 0x00044948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301484, XrefRangeEnd = 301486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_OnColumnChanged_Private_Void_Column_ColumnDataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x00046798 File Offset: 0x00044998
		[CallerCount(0)]
		public unsafe void OnColumnResized(Column column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_OnColumnResized_Private_Void_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000BA2 RID: 2978 RVA: 0x000467DC File Offset: 0x000449DC
		public unsafe virtual int Count
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 301490, RefRangeEnd = 301492, XrefRangeStart = 301486, XrefRangeEnd = 301490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000BA3 RID: 2979 RVA: 0x00046818 File Offset: 0x00044A18
		public unsafe virtual bool IsReadOnly
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301492, XrefRangeEnd = 301496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x00046854 File Offset: 0x00044A54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301496, XrefRangeEnd = 301501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(Column column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_IndexOf_Public_Int32_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x000468A4 File Offset: 0x00044AA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 301524, RefRangeEnd = 301525, XrefRangeStart = 301501, XrefRangeEnd = 301524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Insert(int index, Column column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(column);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_Insert_Public_Void_Int32_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700038B RID: 907
		public unsafe Column this[int index]
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 301529, RefRangeEnd = 301531, XrefRangeStart = 301525, XrefRangeEnd = 301529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_get_Item_Public_get_Column_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Column>(intPtr3) : null;
				}
			}
		}

		// Token: 0x1700038C RID: 908
		public unsafe Column this[string name]
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 301550, RefRangeEnd = 301552, XrefRangeStart = 301531, XrefRangeEnd = 301550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_get_Item_Public_get_Column_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Column>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x00046990 File Offset: 0x00044B90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 301564, RefRangeEnd = 301566, XrefRangeStart = 301552, XrefRangeEnd = 301564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReorderDisplay(int from, int to)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_ReorderDisplay_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x000469DC File Offset: 0x00044BDC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 301573, RefRangeEnd = 301577, XrefRangeStart = 301566, XrefRangeEnd = 301573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitOrderColumns()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_InitOrderColumns_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x00046A10 File Offset: 0x00044C10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 301579, RefRangeEnd = 301580, XrefRangeStart = 301577, XrefRangeEnd = 301579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DirtyVisibleColumns()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_DirtyVisibleColumns_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x00046A44 File Offset: 0x00044C44
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 301612, RefRangeEnd = 301621, XrefRangeStart = 301580, XrefRangeEnd = 301612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVisibleColumns()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_UpdateVisibleColumns_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x00046A78 File Offset: 0x00044C78
		[CallerCount(0)]
		public unsafe void NotifyChange(ColumnsDataType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr_NotifyChange_Private_Void_ColumnsDataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x00046AB8 File Offset: 0x00044CB8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 301629, RefRangeEnd = 301633, XrefRangeStart = 301621, XrefRangeEnd = 301629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Columns()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Columns>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x0000638F File Offset: 0x0000458F
		public Columns(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000BAF RID: 2991 RVA: 0x00046AF4 File Offset: 0x00044CF4
		// (set) Token: 0x06000BB0 RID: 2992 RVA: 0x00006398 File Offset: 0x00004598
		public unsafe IList<Column> m_Columns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Columns.NativeFieldInfoPtr_m_Columns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<Column>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Columns.NativeFieldInfoPtr_m_Columns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000BB1 RID: 2993 RVA: 0x00046B24 File Offset: 0x00044D24
		// (set) Token: 0x06000BB2 RID: 2994 RVA: 0x000063B7 File Offset: 0x000045B7
		public unsafe List<Column> m_DisplayColumns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Columns.NativeFieldInfoPtr_m_DisplayColumns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Column>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Columns.NativeFieldInfoPtr_m_DisplayColumns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000BB3 RID: 2995 RVA: 0x00046B54 File Offset: 0x00044D54
		// (set) Token: 0x06000BB4 RID: 2996 RVA: 0x000063D6 File Offset: 0x000045D6
		public unsafe List<Column> m_VisibleColumns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Columns.NativeFieldInfoPtr_m_VisibleColumns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Column>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Columns.NativeFieldInfoPtr_m_VisibleColumns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000BB5 RID: 2997 RVA: 0x00046B84 File Offset: 0x00044D84
		// (set) Token: 0x06000BB6 RID: 2998 RVA: 0x000063F5 File Offset: 0x000045F5
		public unsafe bool m_VisibleColumnsDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Columns.NativeFieldInfoPtr_m_VisibleColumnsDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Columns.NativeFieldInfoPtr_m_VisibleColumnsDirty)) = value;
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000BB7 RID: 2999 RVA: 0x00046BAC File Offset: 0x00044DAC
		// (set) Token: 0x06000BB8 RID: 3000 RVA: 0x00006410 File Offset: 0x00004610
		public unsafe Columns.StretchMode m_StretchMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Columns.NativeFieldInfoPtr_m_StretchMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Columns.NativeFieldInfoPtr_m_StretchMode)) = value;
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000BB9 RID: 3001 RVA: 0x00046BD4 File Offset: 0x00044DD4
		// (set) Token: 0x06000BBA RID: 3002 RVA: 0x0000642B File Offset: 0x0000462B
		public unsafe bool m_Reorderable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Columns.NativeFieldInfoPtr_m_Reorderable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Columns.NativeFieldInfoPtr_m_Reorderable)) = value;
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000BBB RID: 3003 RVA: 0x00046BFC File Offset: 0x00044DFC
		// (set) Token: 0x06000BBC RID: 3004 RVA: 0x00006446 File Offset: 0x00004646
		public unsafe bool m_Resizable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Columns.NativeFieldInfoPtr_m_Resizable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Columns.NativeFieldInfoPtr_m_Resizable)) = value;
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000BBD RID: 3005 RVA: 0x00046C24 File Offset: 0x00044E24
		// (set) Token: 0x06000BBE RID: 3006 RVA: 0x00006461 File Offset: 0x00004661
		public unsafe bool m_ResizePreview
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Columns.NativeFieldInfoPtr_m_ResizePreview);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Columns.NativeFieldInfoPtr_m_ResizePreview)) = value;
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000BBF RID: 3007 RVA: 0x00046C4C File Offset: 0x00044E4C
		// (set) Token: 0x06000BC0 RID: 3008 RVA: 0x0000647C File Offset: 0x0000467C
		public unsafe string m_PrimaryColumnName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Columns.NativeFieldInfoPtr_m_PrimaryColumnName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Columns.NativeFieldInfoPtr_m_PrimaryColumnName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000BC1 RID: 3009 RVA: 0x00046C74 File Offset: 0x00044E74
		// (set) Token: 0x06000BC2 RID: 3010 RVA: 0x0000649B File Offset: 0x0000469B
		public unsafe Action<ColumnsDataType> changed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Columns.NativeFieldInfoPtr_changed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ColumnsDataType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Columns.NativeFieldInfoPtr_changed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000BC3 RID: 3011 RVA: 0x00046CA4 File Offset: 0x00044EA4
		// (set) Token: 0x06000BC4 RID: 3012 RVA: 0x000064BA File Offset: 0x000046BA
		public unsafe Action<Column, int> columnAdded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Columns.NativeFieldInfoPtr_columnAdded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Column, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Columns.NativeFieldInfoPtr_columnAdded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000BC5 RID: 3013 RVA: 0x00046CD4 File Offset: 0x00044ED4
		// (set) Token: 0x06000BC6 RID: 3014 RVA: 0x000064D9 File Offset: 0x000046D9
		public unsafe Action<Column> columnRemoved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Columns.NativeFieldInfoPtr_columnRemoved);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Column>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Columns.NativeFieldInfoPtr_columnRemoved), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000BC7 RID: 3015 RVA: 0x00046D04 File Offset: 0x00044F04
		// (set) Token: 0x06000BC8 RID: 3016 RVA: 0x000064F8 File Offset: 0x000046F8
		public unsafe Action<Column, ColumnDataType> columnChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Columns.NativeFieldInfoPtr_columnChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Column, ColumnDataType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Columns.NativeFieldInfoPtr_columnChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000BC9 RID: 3017 RVA: 0x00046D34 File Offset: 0x00044F34
		// (set) Token: 0x06000BCA RID: 3018 RVA: 0x00006517 File Offset: 0x00004717
		public unsafe Action<Column> columnResized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Columns.NativeFieldInfoPtr_columnResized);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Column>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Columns.NativeFieldInfoPtr_columnResized), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000BCB RID: 3019 RVA: 0x00046D64 File Offset: 0x00044F64
		// (set) Token: 0x06000BCC RID: 3020 RVA: 0x00006536 File Offset: 0x00004736
		public unsafe Action<Column, int, int> columnReordered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Columns.NativeFieldInfoPtr_columnReordered);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Column, int, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Columns.NativeFieldInfoPtr_columnReordered), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000BCD RID: 3021 RVA: 0x00006555 File Offset: 0x00004755
		public IList<Column> columns
		{
			get
			{
				return this.m_Columns;
			}
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x0000655D File Offset: 0x0000475D
		public void RemoveAt(int index)
		{
			this.Remove(this.m_Columns[index]);
		}

		// Token: 0x04000800 RID: 2048
		private static readonly IntPtr NativeFieldInfoPtr_m_Columns;

		// Token: 0x04000801 RID: 2049
		private static readonly IntPtr NativeFieldInfoPtr_m_DisplayColumns;

		// Token: 0x04000802 RID: 2050
		private static readonly IntPtr NativeFieldInfoPtr_m_VisibleColumns;

		// Token: 0x04000803 RID: 2051
		private static readonly IntPtr NativeFieldInfoPtr_m_VisibleColumnsDirty;

		// Token: 0x04000804 RID: 2052
		private static readonly IntPtr NativeFieldInfoPtr_m_StretchMode;

		// Token: 0x04000805 RID: 2053
		private static readonly IntPtr NativeFieldInfoPtr_m_Reorderable;

		// Token: 0x04000806 RID: 2054
		private static readonly IntPtr NativeFieldInfoPtr_m_Resizable;

		// Token: 0x04000807 RID: 2055
		private static readonly IntPtr NativeFieldInfoPtr_m_ResizePreview;

		// Token: 0x04000808 RID: 2056
		private static readonly IntPtr NativeFieldInfoPtr_m_PrimaryColumnName;

		// Token: 0x04000809 RID: 2057
		private static readonly IntPtr NativeFieldInfoPtr_changed;

		// Token: 0x0400080A RID: 2058
		private static readonly IntPtr NativeFieldInfoPtr_columnAdded;

		// Token: 0x0400080B RID: 2059
		private static readonly IntPtr NativeFieldInfoPtr_columnRemoved;

		// Token: 0x0400080C RID: 2060
		private static readonly IntPtr NativeFieldInfoPtr_columnChanged;

		// Token: 0x0400080D RID: 2061
		private static readonly IntPtr NativeFieldInfoPtr_columnResized;

		// Token: 0x0400080E RID: 2062
		private static readonly IntPtr NativeFieldInfoPtr_columnReordered;

		// Token: 0x0400080F RID: 2063
		private static readonly IntPtr NativeMethodInfoPtr_get_primaryColumnName_Public_get_String_0;

		// Token: 0x04000810 RID: 2064
		private static readonly IntPtr NativeMethodInfoPtr_set_primaryColumnName_Public_set_Void_String_0;

		// Token: 0x04000811 RID: 2065
		private static readonly IntPtr NativeMethodInfoPtr_get_reorderable_Public_get_Boolean_0;

		// Token: 0x04000812 RID: 2066
		private static readonly IntPtr NativeMethodInfoPtr_set_reorderable_Public_set_Void_Boolean_0;

		// Token: 0x04000813 RID: 2067
		private static readonly IntPtr NativeMethodInfoPtr_get_resizable_Public_get_Boolean_0;

		// Token: 0x04000814 RID: 2068
		private static readonly IntPtr NativeMethodInfoPtr_set_resizable_Public_set_Void_Boolean_0;

		// Token: 0x04000815 RID: 2069
		private static readonly IntPtr NativeMethodInfoPtr_get_resizePreview_Public_get_Boolean_0;

		// Token: 0x04000816 RID: 2070
		private static readonly IntPtr NativeMethodInfoPtr_set_resizePreview_Public_set_Void_Boolean_0;

		// Token: 0x04000817 RID: 2071
		private static readonly IntPtr NativeMethodInfoPtr_get_displayList_Internal_get_IEnumerable_1_Column_0;

		// Token: 0x04000818 RID: 2072
		private static readonly IntPtr NativeMethodInfoPtr_get_visibleList_Internal_get_IEnumerable_1_Column_0;

		// Token: 0x04000819 RID: 2073
		private static readonly IntPtr NativeMethodInfoPtr_add_changed_Internal_add_Void_Action_1_ColumnsDataType_0;

		// Token: 0x0400081A RID: 2074
		private static readonly IntPtr NativeMethodInfoPtr_remove_changed_Internal_rem_Void_Action_1_ColumnsDataType_0;

		// Token: 0x0400081B RID: 2075
		private static readonly IntPtr NativeMethodInfoPtr_get_stretchMode_Public_get_StretchMode_0;

		// Token: 0x0400081C RID: 2076
		private static readonly IntPtr NativeMethodInfoPtr_set_stretchMode_Public_set_Void_StretchMode_0;

		// Token: 0x0400081D RID: 2077
		private static readonly IntPtr NativeMethodInfoPtr_add_columnAdded_Internal_add_Void_Action_2_Column_Int32_0;

		// Token: 0x0400081E RID: 2078
		private static readonly IntPtr NativeMethodInfoPtr_remove_columnAdded_Internal_rem_Void_Action_2_Column_Int32_0;

		// Token: 0x0400081F RID: 2079
		private static readonly IntPtr NativeMethodInfoPtr_add_columnRemoved_Internal_add_Void_Action_1_Column_0;

		// Token: 0x04000820 RID: 2080
		private static readonly IntPtr NativeMethodInfoPtr_remove_columnRemoved_Internal_rem_Void_Action_1_Column_0;

		// Token: 0x04000821 RID: 2081
		private static readonly IntPtr NativeMethodInfoPtr_add_columnChanged_Internal_add_Void_Action_2_Column_ColumnDataType_0;

		// Token: 0x04000822 RID: 2082
		private static readonly IntPtr NativeMethodInfoPtr_remove_columnChanged_Internal_rem_Void_Action_2_Column_ColumnDataType_0;

		// Token: 0x04000823 RID: 2083
		private static readonly IntPtr NativeMethodInfoPtr_add_columnResized_Internal_add_Void_Action_1_Column_0;

		// Token: 0x04000824 RID: 2084
		private static readonly IntPtr NativeMethodInfoPtr_remove_columnResized_Internal_rem_Void_Action_1_Column_0;

		// Token: 0x04000825 RID: 2085
		private static readonly IntPtr NativeMethodInfoPtr_add_columnReordered_Internal_add_Void_Action_3_Column_Int32_Int32_0;

		// Token: 0x04000826 RID: 2086
		private static readonly IntPtr NativeMethodInfoPtr_remove_columnReordered_Internal_rem_Void_Action_3_Column_Int32_Int32_0;

		// Token: 0x04000827 RID: 2087
		private static readonly IntPtr NativeMethodInfoPtr_IsPrimary_Public_Boolean_Column_0;

		// Token: 0x04000828 RID: 2088
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_Column_0;

		// Token: 0x04000829 RID: 2089
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x0400082A RID: 2090
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Column_0;

		// Token: 0x0400082B RID: 2091
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400082C RID: 2092
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Column_0;

		// Token: 0x0400082D RID: 2093
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_String_0;

		// Token: 0x0400082E RID: 2094
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_Column_Int32_0;

		// Token: 0x0400082F RID: 2095
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_Column_0;

		// Token: 0x04000830 RID: 2096
		private static readonly IntPtr NativeMethodInfoPtr_OnColumnChanged_Private_Void_Column_ColumnDataType_0;

		// Token: 0x04000831 RID: 2097
		private static readonly IntPtr NativeMethodInfoPtr_OnColumnResized_Private_Void_Column_0;

		// Token: 0x04000832 RID: 2098
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000833 RID: 2099
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000834 RID: 2100
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_Column_0;

		// Token: 0x04000835 RID: 2101
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Void_Int32_Column_0;

		// Token: 0x04000836 RID: 2102
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Column_Int32_0;

		// Token: 0x04000837 RID: 2103
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Column_String_0;

		// Token: 0x04000838 RID: 2104
		private static readonly IntPtr NativeMethodInfoPtr_ReorderDisplay_Public_Void_Int32_Int32_0;

		// Token: 0x04000839 RID: 2105
		private static readonly IntPtr NativeMethodInfoPtr_InitOrderColumns_Private_Void_0;

		// Token: 0x0400083A RID: 2106
		private static readonly IntPtr NativeMethodInfoPtr_DirtyVisibleColumns_Private_Void_0;

		// Token: 0x0400083B RID: 2107
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisibleColumns_Private_Void_0;

		// Token: 0x0400083C RID: 2108
		private static readonly IntPtr NativeMethodInfoPtr_NotifyChange_Private_Void_ColumnsDataType_0;

		// Token: 0x0400083D RID: 2109
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200039F RID: 927
		public enum StretchMode
		{
			// Token: 0x0400284A RID: 10314
			Grow,
			// Token: 0x0400284B RID: 10315
			GrowAndFill
		}

		// Token: 0x020003A0 RID: 928
		public class UxmlObjectFactory<T> : UxmlObjectFactory<T, Columns.UxmlObjectTraits<T>> where T : Columns, new()
		{
			// Token: 0x060038C4 RID: 14532 RVA: 0x000E7590 File Offset: 0x000E5790
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlObjectFactory()
			{
				Il2CppClassPointerStore<Columns.UxmlObjectFactory<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Columns>.NativeClassPtr, "UxmlObjectFactory`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Columns.UxmlObjectFactory<T>>.NativeClassPtr);
				Columns.UxmlObjectFactory<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns.UxmlObjectFactory<T>>.NativeClassPtr, 100665003);
			}

			// Token: 0x060038C5 RID: 14533 RVA: 0x000E760C File Offset: 0x000E580C
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 300055, RefRangeEnd = 300059, XrefRangeStart = 300055, XrefRangeEnd = 300059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlObjectFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Columns.UxmlObjectFactory<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.UxmlObjectFactory<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060038C6 RID: 14534 RVA: 0x00017B39 File Offset: 0x00015D39
			public UxmlObjectFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400284C RID: 10316
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020003A1 RID: 929
		public class UxmlObjectTraits<T> : UnityEngine.UIElements.UxmlObjectTraits<T> where T : Columns
		{
			// Token: 0x060038C7 RID: 14535 RVA: 0x000E7648 File Offset: 0x000E5848
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlObjectTraits()
			{
				Il2CppClassPointerStore<Columns.UxmlObjectTraits<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Columns>.NativeClassPtr, "UxmlObjectTraits`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Columns.UxmlObjectTraits<T>>.NativeClassPtr);
				Columns.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_PrimaryColumnName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Columns.UxmlObjectTraits<T>>.NativeClassPtr, "m_PrimaryColumnName");
				Columns.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_StretchMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Columns.UxmlObjectTraits<T>>.NativeClassPtr, "m_StretchMode");
				Columns.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_Reorderable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Columns.UxmlObjectTraits<T>>.NativeClassPtr, "m_Reorderable");
				Columns.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_Resizable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Columns.UxmlObjectTraits<T>>.NativeClassPtr, "m_Resizable");
				Columns.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_ResizePreview = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Columns.UxmlObjectTraits<T>>.NativeClassPtr, "m_ResizePreview");
				Columns.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_Columns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Columns.UxmlObjectTraits<T>>.NativeClassPtr, "m_Columns");
				Columns.UxmlObjectTraits<T>.NativeMethodInfoPtr_Init_Public_Virtual_Void_byref_T_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns.UxmlObjectTraits<T>>.NativeClassPtr, 100665004);
				Columns.UxmlObjectTraits<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns.UxmlObjectTraits<T>>.NativeClassPtr, 100665005);
			}

			// Token: 0x060038C8 RID: 14536 RVA: 0x000E7750 File Offset: 0x000E5950
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301249, XrefRangeEnd = 301269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Columns.UxmlObjectTraits<T>.NativeMethodInfoPtr_Init_Public_Virtual_Void_byref_T_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				obj = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			}

			// Token: 0x060038C9 RID: 14537 RVA: 0x000E77E0 File Offset: 0x000E59E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 301269, XrefRangeEnd = 301319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlObjectTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Columns.UxmlObjectTraits<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.UxmlObjectTraits<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060038CA RID: 14538 RVA: 0x00017B42 File Offset: 0x00015D42
			public UxmlObjectTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700117C RID: 4476
			// (get) Token: 0x060038CB RID: 14539 RVA: 0x000E781C File Offset: 0x000E5A1C
			// (set) Token: 0x060038CC RID: 14540 RVA: 0x00017B4B File Offset: 0x00015D4B
			public unsafe UxmlStringAttributeDescription m_PrimaryColumnName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Columns.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_PrimaryColumnName);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlStringAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Columns.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_PrimaryColumnName), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700117D RID: 4477
			// (get) Token: 0x060038CD RID: 14541 RVA: 0x000E784C File Offset: 0x000E5A4C
			// (set) Token: 0x060038CE RID: 14542 RVA: 0x00017B6A File Offset: 0x00015D6A
			public unsafe UxmlEnumAttributeDescription<Columns.StretchMode> m_StretchMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Columns.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_StretchMode);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlEnumAttributeDescription<Columns.StretchMode>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Columns.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_StretchMode), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700117E RID: 4478
			// (get) Token: 0x060038CF RID: 14543 RVA: 0x000E787C File Offset: 0x000E5A7C
			// (set) Token: 0x060038D0 RID: 14544 RVA: 0x00017B89 File Offset: 0x00015D89
			public unsafe UxmlBoolAttributeDescription m_Reorderable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Columns.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_Reorderable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlBoolAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Columns.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_Reorderable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700117F RID: 4479
			// (get) Token: 0x060038D1 RID: 14545 RVA: 0x000E78AC File Offset: 0x000E5AAC
			// (set) Token: 0x060038D2 RID: 14546 RVA: 0x00017BA8 File Offset: 0x00015DA8
			public unsafe UxmlBoolAttributeDescription m_Resizable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Columns.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_Resizable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlBoolAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Columns.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_Resizable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001180 RID: 4480
			// (get) Token: 0x060038D3 RID: 14547 RVA: 0x000E78DC File Offset: 0x000E5ADC
			// (set) Token: 0x060038D4 RID: 14548 RVA: 0x00017BC7 File Offset: 0x00015DC7
			public unsafe UxmlBoolAttributeDescription m_ResizePreview
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Columns.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_ResizePreview);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlBoolAttributeDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Columns.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_ResizePreview), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001181 RID: 4481
			// (get) Token: 0x060038D5 RID: 14549 RVA: 0x000E790C File Offset: 0x000E5B0C
			// (set) Token: 0x060038D6 RID: 14550 RVA: 0x00017BE6 File Offset: 0x00015DE6
			public unsafe UxmlObjectListAttributeDescription<Column> m_Columns
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Columns.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_Columns);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlObjectListAttributeDescription<Column>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Columns.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_Columns), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400284D RID: 10317
			private static readonly IntPtr NativeFieldInfoPtr_m_PrimaryColumnName;

			// Token: 0x0400284E RID: 10318
			private static readonly IntPtr NativeFieldInfoPtr_m_StretchMode;

			// Token: 0x0400284F RID: 10319
			private static readonly IntPtr NativeFieldInfoPtr_m_Reorderable;

			// Token: 0x04002850 RID: 10320
			private static readonly IntPtr NativeFieldInfoPtr_m_Resizable;

			// Token: 0x04002851 RID: 10321
			private static readonly IntPtr NativeFieldInfoPtr_m_ResizePreview;

			// Token: 0x04002852 RID: 10322
			private static readonly IntPtr NativeFieldInfoPtr_m_Columns;

			// Token: 0x04002853 RID: 10323
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_byref_T_IUxmlAttributes_CreationContext_0;

			// Token: 0x04002854 RID: 10324
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020003A2 RID: 930
		[ObfuscatedName("UnityEngine.UIElements.Columns+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060038D7 RID: 14551 RVA: 0x000E793C File Offset: 0x000E5B3C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Columns.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Columns>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Columns.__c>.NativeClassPtr);
				Columns.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Columns.__c>.NativeClassPtr, "<>9");
				Columns.__c.NativeFieldInfoPtr___9__76_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Columns.__c>.NativeClassPtr, "<>9__76_0");
				Columns.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns.__c>.NativeClassPtr, 100665007);
				Columns.__c.NativeMethodInfoPtr__UpdateVisibleColumns_b__76_0_Internal_Boolean_Column_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Columns.__c>.NativeClassPtr, 100665008);
			}

			// Token: 0x060038D8 RID: 14552 RVA: 0x000E79B8 File Offset: 0x000E5BB8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Columns.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060038D9 RID: 14553 RVA: 0x000E79F4 File Offset: 0x000E5BF4
			[CallerCount(0)]
			public unsafe bool _UpdateVisibleColumns_b__76_0(Column c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Columns.__c.NativeMethodInfoPtr__UpdateVisibleColumns_b__76_0_Internal_Boolean_Column_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060038DA RID: 14554 RVA: 0x00017C05 File Offset: 0x00015E05
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001182 RID: 4482
			// (get) Token: 0x060038DB RID: 14555 RVA: 0x000E7A44 File Offset: 0x000E5C44
			// (set) Token: 0x060038DC RID: 14556 RVA: 0x00017C0E File Offset: 0x00015E0E
			public unsafe static Columns.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Columns.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Columns.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Columns.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001183 RID: 4483
			// (get) Token: 0x060038DD RID: 14557 RVA: 0x000E7A6C File Offset: 0x000E5C6C
			// (set) Token: 0x060038DE RID: 14558 RVA: 0x00017C20 File Offset: 0x00015E20
			public unsafe static Predicate<Column> __9__76_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Columns.__c.NativeFieldInfoPtr___9__76_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Column>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Columns.__c.NativeFieldInfoPtr___9__76_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002855 RID: 10325
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002856 RID: 10326
			private static readonly IntPtr NativeFieldInfoPtr___9__76_0;

			// Token: 0x04002857 RID: 10327
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002858 RID: 10328
			private static readonly IntPtr NativeMethodInfoPtr__UpdateVisibleColumns_b__76_0_Internal_Boolean_Column_0;
		}

		// Token: 0x020003A3 RID: 931
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
