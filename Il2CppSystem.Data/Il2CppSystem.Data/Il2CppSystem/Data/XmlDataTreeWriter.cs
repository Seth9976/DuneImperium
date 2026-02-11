using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Xml;

namespace Il2CppSystem.Data
{
	// Token: 0x02000087 RID: 135
	public sealed class XmlDataTreeWriter : Object
	{
		// Token: 0x06000D01 RID: 3329 RVA: 0x00041494 File Offset: 0x0003F694
		// Note: this type is marked as 'beforefieldinit'.
		static XmlDataTreeWriter()
		{
			Il2CppClassPointerStore<XmlDataTreeWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "XmlDataTreeWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlDataTreeWriter>.NativeClassPtr);
			XmlDataTreeWriter.NativeFieldInfoPtr__xmlw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDataTreeWriter>.NativeClassPtr, "_xmlw");
			XmlDataTreeWriter.NativeFieldInfoPtr__ds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDataTreeWriter>.NativeClassPtr, "_ds");
			XmlDataTreeWriter.NativeFieldInfoPtr__dt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDataTreeWriter>.NativeClassPtr, "_dt");
			XmlDataTreeWriter.NativeFieldInfoPtr__dTables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDataTreeWriter>.NativeClassPtr, "_dTables");
			XmlDataTreeWriter.NativeFieldInfoPtr__topLevelTables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDataTreeWriter>.NativeClassPtr, "_topLevelTables");
			XmlDataTreeWriter.NativeFieldInfoPtr__fFromTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDataTreeWriter>.NativeClassPtr, "_fFromTable");
			XmlDataTreeWriter.NativeFieldInfoPtr__isDiffgram = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDataTreeWriter>.NativeClassPtr, "_isDiffgram");
			XmlDataTreeWriter.NativeFieldInfoPtr__rowsOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDataTreeWriter>.NativeClassPtr, "_rowsOrder");
			XmlDataTreeWriter.NativeFieldInfoPtr__writeHierarchy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDataTreeWriter>.NativeClassPtr, "_writeHierarchy");
			XmlDataTreeWriter.NativeMethodInfoPtr__ctor_Internal_Void_DataSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDataTreeWriter>.NativeClassPtr, 100665410);
			XmlDataTreeWriter.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDataTreeWriter>.NativeClassPtr, 100665411);
			XmlDataTreeWriter.NativeMethodInfoPtr_CreateToplevelTables_Private_Il2CppReferenceArray_1_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDataTreeWriter>.NativeClassPtr, 100665412);
			XmlDataTreeWriter.NativeMethodInfoPtr_CreateTablesHierarchy_Private_Void_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDataTreeWriter>.NativeClassPtr, 100665413);
			XmlDataTreeWriter.NativeMethodInfoPtr_RowHasErrors_Internal_Static_Boolean_DataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDataTreeWriter>.NativeClassPtr, 100665414);
			XmlDataTreeWriter.NativeMethodInfoPtr_SaveDiffgramData_Internal_Void_XmlWriter_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDataTreeWriter>.NativeClassPtr, 100665415);
			XmlDataTreeWriter.NativeMethodInfoPtr_Save_Internal_Void_XmlWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDataTreeWriter>.NativeClassPtr, 100665416);
			XmlDataTreeWriter.NativeMethodInfoPtr_GetNestedChildRelations_Private_ArrayList_DataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDataTreeWriter>.NativeClassPtr, 100665417);
			XmlDataTreeWriter.NativeMethodInfoPtr_XmlDataRowWriter_Internal_Void_DataRow_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDataTreeWriter>.NativeClassPtr, 100665418);
			XmlDataTreeWriter.NativeMethodInfoPtr_PreserveSpace_Internal_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDataTreeWriter>.NativeClassPtr, 100665419);
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x00041640 File Offset: 0x0003F840
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 914516, RefRangeEnd = 914518, XrefRangeStart = 914490, XrefRangeEnd = 914516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlDataTreeWriter(DataSet ds)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlDataTreeWriter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ds);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDataTreeWriter.NativeMethodInfoPtr__ctor_Internal_Void_DataSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x0004168C File Offset: 0x0003F88C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 914545, RefRangeEnd = 914548, XrefRangeStart = 914518, XrefRangeEnd = 914545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlDataTreeWriter(DataTable dt, bool writeHierarchy)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlDataTreeWriter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeHierarchy;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDataTreeWriter.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x000416E8 File Offset: 0x0003F8E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 914564, RefRangeEnd = 914565, XrefRangeStart = 914548, XrefRangeEnd = 914564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<DataTable> CreateToplevelTables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDataTreeWriter.NativeMethodInfoPtr_CreateToplevelTables_Private_Il2CppReferenceArray_1_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataTable>>(intPtr3) : null;
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x00041728 File Offset: 0x0003F928
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 914584, RefRangeEnd = 914586, XrefRangeStart = 914565, XrefRangeEnd = 914584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateTablesHierarchy(DataTable dt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDataTreeWriter.NativeMethodInfoPtr_CreateTablesHierarchy_Private_Void_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x0004176C File Offset: 0x0003F96C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 914590, RefRangeEnd = 914592, XrefRangeStart = 914586, XrefRangeEnd = 914590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RowHasErrors(DataRow row)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDataTreeWriter.NativeMethodInfoPtr_RowHasErrors_Internal_Static_Boolean_DataRow_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x000417B0 File Offset: 0x0003F9B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 914638, RefRangeEnd = 914639, XrefRangeStart = 914592, XrefRangeEnd = 914638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveDiffgramData(XmlWriter xw, Hashtable rowsOrder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xw);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rowsOrder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDataTreeWriter.NativeMethodInfoPtr_SaveDiffgramData_Internal_Void_XmlWriter_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x00041804 File Offset: 0x0003FA04
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 914704, RefRangeEnd = 914707, XrefRangeStart = 914639, XrefRangeEnd = 914704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Save(XmlWriter xw, bool writeSchema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xw);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeSchema;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDataTreeWriter.NativeMethodInfoPtr_Save_Internal_Void_XmlWriter_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x00041854 File Offset: 0x0003FA54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 914729, RefRangeEnd = 914730, XrefRangeStart = 914707, XrefRangeEnd = 914729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrayList GetNestedChildRelations(DataRow row)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDataTreeWriter.NativeMethodInfoPtr_GetNestedChildRelations_Private_ArrayList_DataRow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x000418A4 File Offset: 0x0003FAA4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 915004, RefRangeEnd = 915007, XrefRangeStart = 914730, XrefRangeEnd = 915004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void XmlDataRowWriter(DataRow row, string encodedTableName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(encodedTableName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDataTreeWriter.NativeMethodInfoPtr_XmlDataRowWriter_Internal_Void_DataRow_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x000418F8 File Offset: 0x0003FAF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 915012, RefRangeEnd = 915013, XrefRangeStart = 915007, XrefRangeEnd = 915012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool PreserveSpace(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDataTreeWriter.NativeMethodInfoPtr_PreserveSpace_Internal_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x00006262 File Offset: 0x00004462
		public XmlDataTreeWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000D0D RID: 3341 RVA: 0x0004193C File Offset: 0x0003FB3C
		// (set) Token: 0x06000D0E RID: 3342 RVA: 0x0000626B File Offset: 0x0000446B
		public unsafe XmlWriter _xmlw
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataTreeWriter.NativeFieldInfoPtr__xmlw);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataTreeWriter.NativeFieldInfoPtr__xmlw), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000D0F RID: 3343 RVA: 0x0004196C File Offset: 0x0003FB6C
		// (set) Token: 0x06000D10 RID: 3344 RVA: 0x0000628A File Offset: 0x0000448A
		public unsafe DataSet _ds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataTreeWriter.NativeFieldInfoPtr__ds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataTreeWriter.NativeFieldInfoPtr__ds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000D11 RID: 3345 RVA: 0x0004199C File Offset: 0x0003FB9C
		// (set) Token: 0x06000D12 RID: 3346 RVA: 0x000062A9 File Offset: 0x000044A9
		public unsafe DataTable _dt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataTreeWriter.NativeFieldInfoPtr__dt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataTreeWriter.NativeFieldInfoPtr__dt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000D13 RID: 3347 RVA: 0x000419CC File Offset: 0x0003FBCC
		// (set) Token: 0x06000D14 RID: 3348 RVA: 0x000062C8 File Offset: 0x000044C8
		public unsafe ArrayList _dTables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataTreeWriter.NativeFieldInfoPtr__dTables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataTreeWriter.NativeFieldInfoPtr__dTables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000D15 RID: 3349 RVA: 0x000419FC File Offset: 0x0003FBFC
		// (set) Token: 0x06000D16 RID: 3350 RVA: 0x000062E7 File Offset: 0x000044E7
		public unsafe Il2CppReferenceArray<DataTable> _topLevelTables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataTreeWriter.NativeFieldInfoPtr__topLevelTables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataTable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataTreeWriter.NativeFieldInfoPtr__topLevelTables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000D17 RID: 3351 RVA: 0x00041A2C File Offset: 0x0003FC2C
		// (set) Token: 0x06000D18 RID: 3352 RVA: 0x00006306 File Offset: 0x00004506
		public unsafe bool _fFromTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataTreeWriter.NativeFieldInfoPtr__fFromTable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataTreeWriter.NativeFieldInfoPtr__fFromTable)) = value;
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000D19 RID: 3353 RVA: 0x00041A54 File Offset: 0x0003FC54
		// (set) Token: 0x06000D1A RID: 3354 RVA: 0x00006321 File Offset: 0x00004521
		public unsafe bool _isDiffgram
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataTreeWriter.NativeFieldInfoPtr__isDiffgram);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataTreeWriter.NativeFieldInfoPtr__isDiffgram)) = value;
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000D1B RID: 3355 RVA: 0x00041A7C File Offset: 0x0003FC7C
		// (set) Token: 0x06000D1C RID: 3356 RVA: 0x0000633C File Offset: 0x0000453C
		public unsafe Hashtable _rowsOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataTreeWriter.NativeFieldInfoPtr__rowsOrder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataTreeWriter.NativeFieldInfoPtr__rowsOrder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000D1D RID: 3357 RVA: 0x00041AAC File Offset: 0x0003FCAC
		// (set) Token: 0x06000D1E RID: 3358 RVA: 0x0000635B File Offset: 0x0000455B
		public unsafe bool _writeHierarchy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataTreeWriter.NativeFieldInfoPtr__writeHierarchy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataTreeWriter.NativeFieldInfoPtr__writeHierarchy)) = value;
			}
		}

		// Token: 0x04000AC3 RID: 2755
		private static readonly IntPtr NativeFieldInfoPtr__xmlw;

		// Token: 0x04000AC4 RID: 2756
		private static readonly IntPtr NativeFieldInfoPtr__ds;

		// Token: 0x04000AC5 RID: 2757
		private static readonly IntPtr NativeFieldInfoPtr__dt;

		// Token: 0x04000AC6 RID: 2758
		private static readonly IntPtr NativeFieldInfoPtr__dTables;

		// Token: 0x04000AC7 RID: 2759
		private static readonly IntPtr NativeFieldInfoPtr__topLevelTables;

		// Token: 0x04000AC8 RID: 2760
		private static readonly IntPtr NativeFieldInfoPtr__fFromTable;

		// Token: 0x04000AC9 RID: 2761
		private static readonly IntPtr NativeFieldInfoPtr__isDiffgram;

		// Token: 0x04000ACA RID: 2762
		private static readonly IntPtr NativeFieldInfoPtr__rowsOrder;

		// Token: 0x04000ACB RID: 2763
		private static readonly IntPtr NativeFieldInfoPtr__writeHierarchy;

		// Token: 0x04000ACC RID: 2764
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DataSet_0;

		// Token: 0x04000ACD RID: 2765
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DataTable_Boolean_0;

		// Token: 0x04000ACE RID: 2766
		private static readonly IntPtr NativeMethodInfoPtr_CreateToplevelTables_Private_Il2CppReferenceArray_1_DataTable_0;

		// Token: 0x04000ACF RID: 2767
		private static readonly IntPtr NativeMethodInfoPtr_CreateTablesHierarchy_Private_Void_DataTable_0;

		// Token: 0x04000AD0 RID: 2768
		private static readonly IntPtr NativeMethodInfoPtr_RowHasErrors_Internal_Static_Boolean_DataRow_0;

		// Token: 0x04000AD1 RID: 2769
		private static readonly IntPtr NativeMethodInfoPtr_SaveDiffgramData_Internal_Void_XmlWriter_Hashtable_0;

		// Token: 0x04000AD2 RID: 2770
		private static readonly IntPtr NativeMethodInfoPtr_Save_Internal_Void_XmlWriter_Boolean_0;

		// Token: 0x04000AD3 RID: 2771
		private static readonly IntPtr NativeMethodInfoPtr_GetNestedChildRelations_Private_ArrayList_DataRow_0;

		// Token: 0x04000AD4 RID: 2772
		private static readonly IntPtr NativeMethodInfoPtr_XmlDataRowWriter_Internal_Void_DataRow_String_0;

		// Token: 0x04000AD5 RID: 2773
		private static readonly IntPtr NativeMethodInfoPtr_PreserveSpace_Internal_Static_Boolean_Object_0;
	}
}
