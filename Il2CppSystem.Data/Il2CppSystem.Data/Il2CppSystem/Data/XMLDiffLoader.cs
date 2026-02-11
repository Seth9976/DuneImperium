using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Xml;

namespace Il2CppSystem.Data
{
	// Token: 0x0200007B RID: 123
	public sealed class XMLDiffLoader : Object
	{
		// Token: 0x06000B9A RID: 2970 RVA: 0x0003B35C File Offset: 0x0003955C
		// Note: this type is marked as 'beforefieldinit'.
		static XMLDiffLoader()
		{
			Il2CppClassPointerStore<XMLDiffLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "XMLDiffLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XMLDiffLoader>.NativeClassPtr);
			XMLDiffLoader.NativeFieldInfoPtr__tables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XMLDiffLoader>.NativeClassPtr, "_tables");
			XMLDiffLoader.NativeFieldInfoPtr__dataSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XMLDiffLoader>.NativeClassPtr, "_dataSet");
			XMLDiffLoader.NativeFieldInfoPtr__dataTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XMLDiffLoader>.NativeClassPtr, "_dataTable");
			XMLDiffLoader.NativeMethodInfoPtr_LoadDiffGram_Internal_Void_DataSet_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XMLDiffLoader>.NativeClassPtr, 100665215);
			XMLDiffLoader.NativeMethodInfoPtr_CreateTablesHierarchy_Private_Void_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XMLDiffLoader>.NativeClassPtr, 100665216);
			XMLDiffLoader.NativeMethodInfoPtr_LoadDiffGram_Internal_Void_DataTable_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XMLDiffLoader>.NativeClassPtr, 100665217);
			XMLDiffLoader.NativeMethodInfoPtr_ProcessDiffs_Internal_Void_DataSet_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XMLDiffLoader>.NativeClassPtr, 100665218);
			XMLDiffLoader.NativeMethodInfoPtr_ProcessDiffs_Internal_Void_ArrayList_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XMLDiffLoader>.NativeClassPtr, 100665219);
			XMLDiffLoader.NativeMethodInfoPtr_ProcessErrors_Internal_Void_DataSet_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XMLDiffLoader>.NativeClassPtr, 100665220);
			XMLDiffLoader.NativeMethodInfoPtr_ProcessErrors_Internal_Void_ArrayList_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XMLDiffLoader>.NativeClassPtr, 100665221);
			XMLDiffLoader.NativeMethodInfoPtr_GetTable_Private_DataTable_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XMLDiffLoader>.NativeClassPtr, 100665222);
			XMLDiffLoader.NativeMethodInfoPtr_ReadOldRowData_Private_Int32_DataSet_byref_DataTable_byref_Int32_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XMLDiffLoader>.NativeClassPtr, 100665223);
			XMLDiffLoader.NativeMethodInfoPtr_SkipWhitespaces_Internal_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XMLDiffLoader>.NativeClassPtr, 100665224);
			XMLDiffLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XMLDiffLoader>.NativeClassPtr, 100665225);
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x0003B4A4 File Offset: 0x000396A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 908342, RefRangeEnd = 908343, XrefRangeStart = 908325, XrefRangeEnd = 908342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadDiffGram(DataSet ds, XmlReader dataTextReader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ds);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dataTextReader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XMLDiffLoader.NativeMethodInfoPtr_LoadDiffGram_Internal_Void_DataSet_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x0003B4F8 File Offset: 0x000396F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 908362, RefRangeEnd = 908364, XrefRangeStart = 908343, XrefRangeEnd = 908362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateTablesHierarchy(DataTable dt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XMLDiffLoader.NativeMethodInfoPtr_CreateTablesHierarchy_Private_Void_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x0003B53C File Offset: 0x0003973C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 908387, RefRangeEnd = 908388, XrefRangeStart = 908364, XrefRangeEnd = 908387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadDiffGram(DataTable dt, XmlReader dataTextReader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dataTextReader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XMLDiffLoader.NativeMethodInfoPtr_LoadDiffGram_Internal_Void_DataTable_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x0003B590 File Offset: 0x00039790
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 908411, RefRangeEnd = 908412, XrefRangeStart = 908388, XrefRangeEnd = 908411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessDiffs(DataSet ds, XmlReader ssync)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ds);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ssync);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XMLDiffLoader.NativeMethodInfoPtr_ProcessDiffs_Internal_Void_DataSet_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x0003B5E4 File Offset: 0x000397E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 908434, RefRangeEnd = 908435, XrefRangeStart = 908412, XrefRangeEnd = 908434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessDiffs(ArrayList tableList, XmlReader ssync)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tableList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ssync);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XMLDiffLoader.NativeMethodInfoPtr_ProcessDiffs_Internal_Void_ArrayList_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x0003B638 File Offset: 0x00039838
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 908460, RefRangeEnd = 908461, XrefRangeStart = 908435, XrefRangeEnd = 908460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessErrors(DataSet ds, XmlReader ssync)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ds);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ssync);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XMLDiffLoader.NativeMethodInfoPtr_ProcessErrors_Internal_Void_DataSet_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x0003B68C File Offset: 0x0003988C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 908493, RefRangeEnd = 908494, XrefRangeStart = 908461, XrefRangeEnd = 908493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessErrors(ArrayList dt, XmlReader ssync)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ssync);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XMLDiffLoader.NativeMethodInfoPtr_ProcessErrors_Internal_Void_ArrayList_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x0003B6E0 File Offset: 0x000398E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 908500, RefRangeEnd = 908502, XrefRangeStart = 908494, XrefRangeEnd = 908500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataTable GetTable(string tableName, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tableName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XMLDiffLoader.NativeMethodInfoPtr_GetTable_Private_DataTable_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr3) : null;
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x0003B744 File Offset: 0x00039944
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 908629, RefRangeEnd = 908631, XrefRangeStart = 908502, XrefRangeEnd = 908629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReadOldRowData(DataSet ds, ref DataTable table, ref int pos, XmlReader row)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ds);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(table);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pos;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(row);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XMLDiffLoader.NativeMethodInfoPtr_ReadOldRowData_Private_Int32_DataSet_byref_DataTable_byref_Int32_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			table = ((intPtr4 == 0) ? null : new DataTable(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x0003B7DC File Offset: 0x000399DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 908631, XrefRangeEnd = 908632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkipWhitespaces(XmlReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XMLDiffLoader.NativeMethodInfoPtr_SkipWhitespaces_Internal_Void_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x0003B820 File Offset: 0x00039A20
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XMLDiffLoader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XMLDiffLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XMLDiffLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x000058B9 File Offset: 0x00003AB9
		public XMLDiffLoader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000BA7 RID: 2983 RVA: 0x0003B85C File Offset: 0x00039A5C
		// (set) Token: 0x06000BA8 RID: 2984 RVA: 0x000058C2 File Offset: 0x00003AC2
		public unsafe ArrayList _tables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XMLDiffLoader.NativeFieldInfoPtr__tables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XMLDiffLoader.NativeFieldInfoPtr__tables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000BA9 RID: 2985 RVA: 0x0003B88C File Offset: 0x00039A8C
		// (set) Token: 0x06000BAA RID: 2986 RVA: 0x000058E1 File Offset: 0x00003AE1
		public unsafe DataSet _dataSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XMLDiffLoader.NativeFieldInfoPtr__dataSet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XMLDiffLoader.NativeFieldInfoPtr__dataSet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000BAB RID: 2987 RVA: 0x0003B8BC File Offset: 0x00039ABC
		// (set) Token: 0x06000BAC RID: 2988 RVA: 0x00005900 File Offset: 0x00003B00
		public unsafe DataTable _dataTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XMLDiffLoader.NativeFieldInfoPtr__dataTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XMLDiffLoader.NativeFieldInfoPtr__dataTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009AB RID: 2475
		private static readonly IntPtr NativeFieldInfoPtr__tables;

		// Token: 0x040009AC RID: 2476
		private static readonly IntPtr NativeFieldInfoPtr__dataSet;

		// Token: 0x040009AD RID: 2477
		private static readonly IntPtr NativeFieldInfoPtr__dataTable;

		// Token: 0x040009AE RID: 2478
		private static readonly IntPtr NativeMethodInfoPtr_LoadDiffGram_Internal_Void_DataSet_XmlReader_0;

		// Token: 0x040009AF RID: 2479
		private static readonly IntPtr NativeMethodInfoPtr_CreateTablesHierarchy_Private_Void_DataTable_0;

		// Token: 0x040009B0 RID: 2480
		private static readonly IntPtr NativeMethodInfoPtr_LoadDiffGram_Internal_Void_DataTable_XmlReader_0;

		// Token: 0x040009B1 RID: 2481
		private static readonly IntPtr NativeMethodInfoPtr_ProcessDiffs_Internal_Void_DataSet_XmlReader_0;

		// Token: 0x040009B2 RID: 2482
		private static readonly IntPtr NativeMethodInfoPtr_ProcessDiffs_Internal_Void_ArrayList_XmlReader_0;

		// Token: 0x040009B3 RID: 2483
		private static readonly IntPtr NativeMethodInfoPtr_ProcessErrors_Internal_Void_DataSet_XmlReader_0;

		// Token: 0x040009B4 RID: 2484
		private static readonly IntPtr NativeMethodInfoPtr_ProcessErrors_Internal_Void_ArrayList_XmlReader_0;

		// Token: 0x040009B5 RID: 2485
		private static readonly IntPtr NativeMethodInfoPtr_GetTable_Private_DataTable_String_String_0;

		// Token: 0x040009B6 RID: 2486
		private static readonly IntPtr NativeMethodInfoPtr_ReadOldRowData_Private_Int32_DataSet_byref_DataTable_byref_Int32_XmlReader_0;

		// Token: 0x040009B7 RID: 2487
		private static readonly IntPtr NativeMethodInfoPtr_SkipWhitespaces_Internal_Void_XmlReader_0;

		// Token: 0x040009B8 RID: 2488
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
