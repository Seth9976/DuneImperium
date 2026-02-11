using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Xml;

namespace Il2CppSystem.Data
{
	// Token: 0x02000086 RID: 134
	public sealed class NewDiffgramGen : Object
	{
		// Token: 0x06000CE1 RID: 3297 RVA: 0x00040DA4 File Offset: 0x0003EFA4
		// Note: this type is marked as 'beforefieldinit'.
		static NewDiffgramGen()
		{
			Il2CppClassPointerStore<NewDiffgramGen>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "NewDiffgramGen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewDiffgramGen>.NativeClassPtr);
			NewDiffgramGen.NativeFieldInfoPtr__doc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewDiffgramGen>.NativeClassPtr, "_doc");
			NewDiffgramGen.NativeFieldInfoPtr__ds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewDiffgramGen>.NativeClassPtr, "_ds");
			NewDiffgramGen.NativeFieldInfoPtr__dt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewDiffgramGen>.NativeClassPtr, "_dt");
			NewDiffgramGen.NativeFieldInfoPtr__xmlw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewDiffgramGen>.NativeClassPtr, "_xmlw");
			NewDiffgramGen.NativeFieldInfoPtr__fBefore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewDiffgramGen>.NativeClassPtr, "_fBefore");
			NewDiffgramGen.NativeFieldInfoPtr__fErrors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewDiffgramGen>.NativeClassPtr, "_fErrors");
			NewDiffgramGen.NativeFieldInfoPtr__rowsOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewDiffgramGen>.NativeClassPtr, "_rowsOrder");
			NewDiffgramGen.NativeFieldInfoPtr__tables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewDiffgramGen>.NativeClassPtr, "_tables");
			NewDiffgramGen.NativeFieldInfoPtr__writeHierarchy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewDiffgramGen>.NativeClassPtr, "_writeHierarchy");
			NewDiffgramGen.NativeMethodInfoPtr__ctor_Internal_Void_DataSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewDiffgramGen>.NativeClassPtr, 100665398);
			NewDiffgramGen.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewDiffgramGen>.NativeClassPtr, 100665399);
			NewDiffgramGen.NativeMethodInfoPtr_CreateTableHierarchy_Private_Void_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewDiffgramGen>.NativeClassPtr, 100665400);
			NewDiffgramGen.NativeMethodInfoPtr_DoAssignments_Private_Void_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewDiffgramGen>.NativeClassPtr, 100665401);
			NewDiffgramGen.NativeMethodInfoPtr_EmptyData_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewDiffgramGen>.NativeClassPtr, 100665402);
			NewDiffgramGen.NativeMethodInfoPtr_Save_Internal_Void_XmlWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewDiffgramGen>.NativeClassPtr, 100665403);
			NewDiffgramGen.NativeMethodInfoPtr_Save_Internal_Void_XmlWriter_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewDiffgramGen>.NativeClassPtr, 100665404);
			NewDiffgramGen.NativeMethodInfoPtr_GenerateTable_Private_Void_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewDiffgramGen>.NativeClassPtr, 100665405);
			NewDiffgramGen.NativeMethodInfoPtr_GenerateTableErrors_Private_Void_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewDiffgramGen>.NativeClassPtr, 100665406);
			NewDiffgramGen.NativeMethodInfoPtr_GenerateRow_Private_Void_DataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewDiffgramGen>.NativeClassPtr, 100665407);
			NewDiffgramGen.NativeMethodInfoPtr_GenerateColumn_Private_Void_DataRow_DataColumn_DataRowVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewDiffgramGen>.NativeClassPtr, 100665408);
			NewDiffgramGen.NativeMethodInfoPtr_QualifiedName_Internal_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewDiffgramGen>.NativeClassPtr, 100665409);
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x00040F78 File Offset: 0x0003F178
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 914203, RefRangeEnd = 914204, XrefRangeStart = 914186, XrefRangeEnd = 914203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NewDiffgramGen(DataSet ds)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewDiffgramGen>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ds);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewDiffgramGen.NativeMethodInfoPtr__ctor_Internal_Void_DataSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x00040FC4 File Offset: 0x0003F1C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 914220, RefRangeEnd = 914222, XrefRangeStart = 914204, XrefRangeEnd = 914220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NewDiffgramGen(DataTable dt, bool writeHierarchy)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewDiffgramGen>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeHierarchy;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewDiffgramGen.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x00041020 File Offset: 0x0003F220
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 914241, RefRangeEnd = 914243, XrefRangeStart = 914222, XrefRangeEnd = 914241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateTableHierarchy(DataTable dt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewDiffgramGen.NativeMethodInfoPtr_CreateTableHierarchy_Private_Void_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x00041064 File Offset: 0x0003F264
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 914257, RefRangeEnd = 914259, XrefRangeStart = 914243, XrefRangeEnd = 914257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoAssignments(ArrayList tables)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tables);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewDiffgramGen.NativeMethodInfoPtr_DoAssignments_Private_Void_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x000410A8 File Offset: 0x0003F2A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 914259, XrefRangeEnd = 914262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool EmptyData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewDiffgramGen.NativeMethodInfoPtr_EmptyData_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x000410E4 File Offset: 0x0003F2E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 914263, RefRangeEnd = 914264, XrefRangeStart = 914262, XrefRangeEnd = 914263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Save(XmlWriter xmlw)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlw);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewDiffgramGen.NativeMethodInfoPtr_Save_Internal_Void_XmlWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x00041128 File Offset: 0x0003F328
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 914314, RefRangeEnd = 914317, XrefRangeStart = 914264, XrefRangeEnd = 914314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Save(XmlWriter xmlw, DataTable table)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlw);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(table);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewDiffgramGen.NativeMethodInfoPtr_Save_Internal_Void_XmlWriter_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x0004117C File Offset: 0x0003F37C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 914317, XrefRangeEnd = 914319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateTable(DataTable table)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewDiffgramGen.NativeMethodInfoPtr_GenerateTable_Private_Void_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x000411C0 File Offset: 0x0003F3C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 914382, RefRangeEnd = 914384, XrefRangeStart = 914319, XrefRangeEnd = 914382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateTableErrors(DataTable table)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewDiffgramGen.NativeMethodInfoPtr_GenerateTableErrors_Private_Void_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x00041204 File Offset: 0x0003F404
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 914447, RefRangeEnd = 914450, XrefRangeStart = 914384, XrefRangeEnd = 914447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateRow(DataRow row)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewDiffgramGen.NativeMethodInfoPtr_GenerateRow_Private_Void_DataRow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x00041248 File Offset: 0x0003F448
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 914487, RefRangeEnd = 914489, XrefRangeStart = 914450, XrefRangeEnd = 914487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateColumn(DataRow row, DataColumn col, DataRowVersion version)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(col);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref version;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewDiffgramGen.NativeMethodInfoPtr_GenerateColumn_Private_Void_DataRow_DataColumn_DataRowVersion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x000412AC File Offset: 0x0003F4AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 914489, XrefRangeEnd = 914490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string QualifiedName(string prefix, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewDiffgramGen.NativeMethodInfoPtr_QualifiedName_Internal_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x0000614E File Offset: 0x0000434E
		public NewDiffgramGen(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000CEF RID: 3311 RVA: 0x000412FC File Offset: 0x0003F4FC
		// (set) Token: 0x06000CF0 RID: 3312 RVA: 0x00006157 File Offset: 0x00004357
		public unsafe XmlDocument _doc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewDiffgramGen.NativeFieldInfoPtr__doc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlDocument>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewDiffgramGen.NativeFieldInfoPtr__doc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000CF1 RID: 3313 RVA: 0x0004132C File Offset: 0x0003F52C
		// (set) Token: 0x06000CF2 RID: 3314 RVA: 0x00006176 File Offset: 0x00004376
		public unsafe DataSet _ds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewDiffgramGen.NativeFieldInfoPtr__ds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewDiffgramGen.NativeFieldInfoPtr__ds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000CF3 RID: 3315 RVA: 0x0004135C File Offset: 0x0003F55C
		// (set) Token: 0x06000CF4 RID: 3316 RVA: 0x00006195 File Offset: 0x00004395
		public unsafe DataTable _dt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewDiffgramGen.NativeFieldInfoPtr__dt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewDiffgramGen.NativeFieldInfoPtr__dt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000CF5 RID: 3317 RVA: 0x0004138C File Offset: 0x0003F58C
		// (set) Token: 0x06000CF6 RID: 3318 RVA: 0x000061B4 File Offset: 0x000043B4
		public unsafe XmlWriter _xmlw
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewDiffgramGen.NativeFieldInfoPtr__xmlw);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewDiffgramGen.NativeFieldInfoPtr__xmlw), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000CF7 RID: 3319 RVA: 0x000413BC File Offset: 0x0003F5BC
		// (set) Token: 0x06000CF8 RID: 3320 RVA: 0x000061D3 File Offset: 0x000043D3
		public unsafe bool _fBefore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewDiffgramGen.NativeFieldInfoPtr__fBefore);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewDiffgramGen.NativeFieldInfoPtr__fBefore)) = value;
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000CF9 RID: 3321 RVA: 0x000413E4 File Offset: 0x0003F5E4
		// (set) Token: 0x06000CFA RID: 3322 RVA: 0x000061EE File Offset: 0x000043EE
		public unsafe bool _fErrors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewDiffgramGen.NativeFieldInfoPtr__fErrors);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewDiffgramGen.NativeFieldInfoPtr__fErrors)) = value;
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000CFB RID: 3323 RVA: 0x0004140C File Offset: 0x0003F60C
		// (set) Token: 0x06000CFC RID: 3324 RVA: 0x00006209 File Offset: 0x00004409
		public unsafe Hashtable _rowsOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewDiffgramGen.NativeFieldInfoPtr__rowsOrder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewDiffgramGen.NativeFieldInfoPtr__rowsOrder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000CFD RID: 3325 RVA: 0x0004143C File Offset: 0x0003F63C
		// (set) Token: 0x06000CFE RID: 3326 RVA: 0x00006228 File Offset: 0x00004428
		public unsafe ArrayList _tables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewDiffgramGen.NativeFieldInfoPtr__tables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewDiffgramGen.NativeFieldInfoPtr__tables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000CFF RID: 3327 RVA: 0x0004146C File Offset: 0x0003F66C
		// (set) Token: 0x06000D00 RID: 3328 RVA: 0x00006247 File Offset: 0x00004447
		public unsafe bool _writeHierarchy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewDiffgramGen.NativeFieldInfoPtr__writeHierarchy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewDiffgramGen.NativeFieldInfoPtr__writeHierarchy)) = value;
			}
		}

		// Token: 0x04000AAE RID: 2734
		private static readonly IntPtr NativeFieldInfoPtr__doc;

		// Token: 0x04000AAF RID: 2735
		private static readonly IntPtr NativeFieldInfoPtr__ds;

		// Token: 0x04000AB0 RID: 2736
		private static readonly IntPtr NativeFieldInfoPtr__dt;

		// Token: 0x04000AB1 RID: 2737
		private static readonly IntPtr NativeFieldInfoPtr__xmlw;

		// Token: 0x04000AB2 RID: 2738
		private static readonly IntPtr NativeFieldInfoPtr__fBefore;

		// Token: 0x04000AB3 RID: 2739
		private static readonly IntPtr NativeFieldInfoPtr__fErrors;

		// Token: 0x04000AB4 RID: 2740
		private static readonly IntPtr NativeFieldInfoPtr__rowsOrder;

		// Token: 0x04000AB5 RID: 2741
		private static readonly IntPtr NativeFieldInfoPtr__tables;

		// Token: 0x04000AB6 RID: 2742
		private static readonly IntPtr NativeFieldInfoPtr__writeHierarchy;

		// Token: 0x04000AB7 RID: 2743
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DataSet_0;

		// Token: 0x04000AB8 RID: 2744
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DataTable_Boolean_0;

		// Token: 0x04000AB9 RID: 2745
		private static readonly IntPtr NativeMethodInfoPtr_CreateTableHierarchy_Private_Void_DataTable_0;

		// Token: 0x04000ABA RID: 2746
		private static readonly IntPtr NativeMethodInfoPtr_DoAssignments_Private_Void_ArrayList_0;

		// Token: 0x04000ABB RID: 2747
		private static readonly IntPtr NativeMethodInfoPtr_EmptyData_Private_Boolean_0;

		// Token: 0x04000ABC RID: 2748
		private static readonly IntPtr NativeMethodInfoPtr_Save_Internal_Void_XmlWriter_0;

		// Token: 0x04000ABD RID: 2749
		private static readonly IntPtr NativeMethodInfoPtr_Save_Internal_Void_XmlWriter_DataTable_0;

		// Token: 0x04000ABE RID: 2750
		private static readonly IntPtr NativeMethodInfoPtr_GenerateTable_Private_Void_DataTable_0;

		// Token: 0x04000ABF RID: 2751
		private static readonly IntPtr NativeMethodInfoPtr_GenerateTableErrors_Private_Void_DataTable_0;

		// Token: 0x04000AC0 RID: 2752
		private static readonly IntPtr NativeMethodInfoPtr_GenerateRow_Private_Void_DataRow_0;

		// Token: 0x04000AC1 RID: 2753
		private static readonly IntPtr NativeMethodInfoPtr_GenerateColumn_Private_Void_DataRow_DataColumn_DataRowVersion_0;

		// Token: 0x04000AC2 RID: 2754
		private static readonly IntPtr NativeMethodInfoPtr_QualifiedName_Internal_Static_String_String_String_0;
	}
}
