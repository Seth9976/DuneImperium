using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Xml;

namespace Il2CppSystem.Data
{
	// Token: 0x02000082 RID: 130
	public sealed class XmlToDatasetMap : Object
	{
		// Token: 0x06000C73 RID: 3187 RVA: 0x0003EB58 File Offset: 0x0003CD58
		// Note: this type is marked as 'beforefieldinit'.
		static XmlToDatasetMap()
		{
			Il2CppClassPointerStore<XmlToDatasetMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "XmlToDatasetMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlToDatasetMap>.NativeClassPtr);
			XmlToDatasetMap.NativeFieldInfoPtr__tableSchemaMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlToDatasetMap>.NativeClassPtr, "_tableSchemaMap");
			XmlToDatasetMap.NativeFieldInfoPtr__lastTableSchemaInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlToDatasetMap>.NativeClassPtr, "_lastTableSchemaInfo");
			XmlToDatasetMap.NativeMethodInfoPtr__ctor_Public_Void_DataSet_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlToDatasetMap>.NativeClassPtr, 100665321);
			XmlToDatasetMap.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_DataSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlToDatasetMap>.NativeClassPtr, 100665322);
			XmlToDatasetMap.NativeMethodInfoPtr__ctor_Public_Void_DataTable_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlToDatasetMap>.NativeClassPtr, 100665323);
			XmlToDatasetMap.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlToDatasetMap>.NativeClassPtr, 100665324);
			XmlToDatasetMap.NativeMethodInfoPtr_IsMappedColumn_Internal_Static_Boolean_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlToDatasetMap>.NativeClassPtr, 100665325);
			XmlToDatasetMap.NativeMethodInfoPtr_AddTableSchema_Private_TableSchemaInfo_DataTable_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlToDatasetMap>.NativeClassPtr, 100665326);
			XmlToDatasetMap.NativeMethodInfoPtr_AddTableSchema_Private_TableSchemaInfo_XmlNameTable_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlToDatasetMap>.NativeClassPtr, 100665327);
			XmlToDatasetMap.NativeMethodInfoPtr_AddColumnSchema_Private_Boolean_DataColumn_XmlNameTable_XmlNodeIdHashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlToDatasetMap>.NativeClassPtr, 100665328);
			XmlToDatasetMap.NativeMethodInfoPtr_AddColumnSchema_Private_Boolean_XmlNameTable_DataColumn_XmlNodeIdHashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlToDatasetMap>.NativeClassPtr, 100665329);
			XmlToDatasetMap.NativeMethodInfoPtr_BuildIdentityMap_Private_Void_DataSet_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlToDatasetMap>.NativeClassPtr, 100665330);
			XmlToDatasetMap.NativeMethodInfoPtr_BuildIdentityMap_Private_Void_XmlNameTable_DataSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlToDatasetMap>.NativeClassPtr, 100665331);
			XmlToDatasetMap.NativeMethodInfoPtr_BuildIdentityMap_Private_Void_DataTable_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlToDatasetMap>.NativeClassPtr, 100665332);
			XmlToDatasetMap.NativeMethodInfoPtr_BuildIdentityMap_Private_Void_XmlNameTable_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlToDatasetMap>.NativeClassPtr, 100665333);
			XmlToDatasetMap.NativeMethodInfoPtr_GetSelfAndDescendants_Private_ArrayList_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlToDatasetMap>.NativeClassPtr, 100665334);
			XmlToDatasetMap.NativeMethodInfoPtr_GetColumnSchema_Public_Object_XmlNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlToDatasetMap>.NativeClassPtr, 100665335);
			XmlToDatasetMap.NativeMethodInfoPtr_GetColumnSchema_Public_Object_DataTable_XmlReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlToDatasetMap>.NativeClassPtr, 100665336);
			XmlToDatasetMap.NativeMethodInfoPtr_GetSchemaForNode_Public_Object_XmlNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlToDatasetMap>.NativeClassPtr, 100665337);
			XmlToDatasetMap.NativeMethodInfoPtr_GetTableForNode_Public_DataTable_XmlReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlToDatasetMap>.NativeClassPtr, 100665338);
			XmlToDatasetMap.NativeMethodInfoPtr_HandleSpecialColumn_Private_Void_DataColumn_XmlNameTable_XmlNodeIdHashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlToDatasetMap>.NativeClassPtr, 100665339);
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x0003ED2C File Offset: 0x0003CF2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 911908, XrefRangeEnd = 911910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlToDatasetMap(DataSet dataSet, XmlNameTable nameTable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlToDatasetMap>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataSet);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlToDatasetMap.NativeMethodInfoPtr__ctor_Public_Void_DataSet_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x0003ED8C File Offset: 0x0003CF8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 911912, RefRangeEnd = 911913, XrefRangeStart = 911910, XrefRangeEnd = 911912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlToDatasetMap(XmlNameTable nameTable, DataSet dataSet)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlToDatasetMap>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dataSet);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlToDatasetMap.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_DataSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x0003EDEC File Offset: 0x0003CFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 911913, XrefRangeEnd = 911915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlToDatasetMap(DataTable dataTable, XmlNameTable nameTable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlToDatasetMap>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataTable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlToDatasetMap.NativeMethodInfoPtr__ctor_Public_Void_DataTable_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x0003EE4C File Offset: 0x0003D04C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 911917, RefRangeEnd = 911918, XrefRangeStart = 911915, XrefRangeEnd = 911917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlToDatasetMap(XmlNameTable nameTable, DataTable dataTable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlToDatasetMap>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dataTable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlToDatasetMap.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x0003EEAC File Offset: 0x0003D0AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 911918, RefRangeEnd = 911919, XrefRangeStart = 911918, XrefRangeEnd = 911918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsMappedColumn(DataColumn c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlToDatasetMap.NativeMethodInfoPtr_IsMappedColumn_Internal_Static_Boolean_DataColumn_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x0003EEF0 File Offset: 0x0003D0F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 911931, RefRangeEnd = 911933, XrefRangeStart = 911919, XrefRangeEnd = 911931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlToDatasetMap.TableSchemaInfo AddTableSchema(DataTable table, XmlNameTable nameTable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlToDatasetMap.NativeMethodInfoPtr_AddTableSchema_Private_TableSchemaInfo_DataTable_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlToDatasetMap.TableSchemaInfo>(intPtr3) : null;
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x0003EF54 File Offset: 0x0003D154
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 911949, RefRangeEnd = 911951, XrefRangeStart = 911933, XrefRangeEnd = 911949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlToDatasetMap.TableSchemaInfo AddTableSchema(XmlNameTable nameTable, DataTable table)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(table);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlToDatasetMap.NativeMethodInfoPtr_AddTableSchema_Private_TableSchemaInfo_XmlNameTable_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlToDatasetMap.TableSchemaInfo>(intPtr3) : null;
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x0003EFB8 File Offset: 0x0003D1B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 911963, RefRangeEnd = 911965, XrefRangeStart = 911951, XrefRangeEnd = 911963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddColumnSchema(DataColumn col, XmlNameTable nameTable, XmlToDatasetMap.XmlNodeIdHashtable columns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(col);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(columns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlToDatasetMap.NativeMethodInfoPtr_AddColumnSchema_Private_Boolean_DataColumn_XmlNameTable_XmlNodeIdHashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x0003F02C File Offset: 0x0003D22C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 911984, RefRangeEnd = 911986, XrefRangeStart = 911965, XrefRangeEnd = 911984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddColumnSchema(XmlNameTable nameTable, DataColumn col, XmlToDatasetMap.XmlNodeIdHashtable columns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(col);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(columns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlToDatasetMap.NativeMethodInfoPtr_AddColumnSchema_Private_Boolean_XmlNameTable_DataColumn_XmlNodeIdHashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x0003F0A0 File Offset: 0x0003D2A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 912019, RefRangeEnd = 912021, XrefRangeStart = 911986, XrefRangeEnd = 912019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildIdentityMap(DataSet dataSet, XmlNameTable nameTable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataSet);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlToDatasetMap.NativeMethodInfoPtr_BuildIdentityMap_Private_Void_DataSet_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x0003F0F4 File Offset: 0x0003D2F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 912076, RefRangeEnd = 912078, XrefRangeStart = 912021, XrefRangeEnd = 912076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildIdentityMap(XmlNameTable nameTable, DataSet dataSet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dataSet);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlToDatasetMap.NativeMethodInfoPtr_BuildIdentityMap_Private_Void_XmlNameTable_DataSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x0003F148 File Offset: 0x0003D348
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 912102, RefRangeEnd = 912104, XrefRangeStart = 912078, XrefRangeEnd = 912102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildIdentityMap(DataTable dataTable, XmlNameTable nameTable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataTable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlToDatasetMap.NativeMethodInfoPtr_BuildIdentityMap_Private_Void_DataTable_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x0003F19C File Offset: 0x0003D39C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 912159, RefRangeEnd = 912161, XrefRangeStart = 912104, XrefRangeEnd = 912159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildIdentityMap(XmlNameTable nameTable, DataTable dataTable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dataTable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlToDatasetMap.NativeMethodInfoPtr_BuildIdentityMap_Private_Void_XmlNameTable_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x0003F1F0 File Offset: 0x0003D3F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 912181, RefRangeEnd = 912182, XrefRangeStart = 912161, XrefRangeEnd = 912181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrayList GetSelfAndDescendants(DataTable dt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlToDatasetMap.NativeMethodInfoPtr_GetSelfAndDescendants_Private_ArrayList_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x0003F240 File Offset: 0x0003D440
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 912191, RefRangeEnd = 912195, XrefRangeStart = 912182, XrefRangeEnd = 912191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetColumnSchema(XmlNode node, bool fIgnoreNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fIgnoreNamespace;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlToDatasetMap.NativeMethodInfoPtr_GetColumnSchema_Public_Object_XmlNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x0003F2A0 File Offset: 0x0003D4A0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 912205, RefRangeEnd = 912209, XrefRangeStart = 912195, XrefRangeEnd = 912205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetColumnSchema(DataTable table, XmlReader dataReader, bool fIgnoreNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dataReader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fIgnoreNamespace;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlToDatasetMap.NativeMethodInfoPtr_GetColumnSchema_Public_Object_DataTable_XmlReader_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x0003F310 File Offset: 0x0003D510
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 912214, RefRangeEnd = 912218, XrefRangeStart = 912209, XrefRangeEnd = 912214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetSchemaForNode(XmlNode node, bool fIgnoreNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fIgnoreNamespace;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlToDatasetMap.NativeMethodInfoPtr_GetSchemaForNode_Public_Object_XmlNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x0003F370 File Offset: 0x0003D570
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 912224, RefRangeEnd = 912227, XrefRangeStart = 912218, XrefRangeEnd = 912224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataTable GetTableForNode(XmlReader node, bool fIgnoreNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fIgnoreNamespace;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlToDatasetMap.NativeMethodInfoPtr_GetTableForNode_Public_DataTable_XmlReader_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr3) : null;
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x0003F3D0 File Offset: 0x0003D5D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 912242, RefRangeEnd = 912244, XrefRangeStart = 912227, XrefRangeEnd = 912242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleSpecialColumn(DataColumn col, XmlNameTable nameTable, XmlToDatasetMap.XmlNodeIdHashtable columns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(col);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(columns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlToDatasetMap.NativeMethodInfoPtr_HandleSpecialColumn_Private_Void_DataColumn_XmlNameTable_XmlNodeIdHashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x00005EF7 File Offset: 0x000040F7
		public XmlToDatasetMap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000C88 RID: 3208 RVA: 0x0003F438 File Offset: 0x0003D638
		// (set) Token: 0x06000C89 RID: 3209 RVA: 0x00005F00 File Offset: 0x00004100
		public unsafe XmlToDatasetMap.XmlNodeIdHashtable _tableSchemaMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlToDatasetMap.NativeFieldInfoPtr__tableSchemaMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlToDatasetMap.XmlNodeIdHashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlToDatasetMap.NativeFieldInfoPtr__tableSchemaMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000C8A RID: 3210 RVA: 0x0003F468 File Offset: 0x0003D668
		// (set) Token: 0x06000C8B RID: 3211 RVA: 0x00005F1F File Offset: 0x0000411F
		public unsafe XmlToDatasetMap.TableSchemaInfo _lastTableSchemaInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlToDatasetMap.NativeFieldInfoPtr__lastTableSchemaInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlToDatasetMap.TableSchemaInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlToDatasetMap.NativeFieldInfoPtr__lastTableSchemaInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A4D RID: 2637
		private static readonly IntPtr NativeFieldInfoPtr__tableSchemaMap;

		// Token: 0x04000A4E RID: 2638
		private static readonly IntPtr NativeFieldInfoPtr__lastTableSchemaInfo;

		// Token: 0x04000A4F RID: 2639
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataSet_XmlNameTable_0;

		// Token: 0x04000A50 RID: 2640
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_DataSet_0;

		// Token: 0x04000A51 RID: 2641
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataTable_XmlNameTable_0;

		// Token: 0x04000A52 RID: 2642
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_DataTable_0;

		// Token: 0x04000A53 RID: 2643
		private static readonly IntPtr NativeMethodInfoPtr_IsMappedColumn_Internal_Static_Boolean_DataColumn_0;

		// Token: 0x04000A54 RID: 2644
		private static readonly IntPtr NativeMethodInfoPtr_AddTableSchema_Private_TableSchemaInfo_DataTable_XmlNameTable_0;

		// Token: 0x04000A55 RID: 2645
		private static readonly IntPtr NativeMethodInfoPtr_AddTableSchema_Private_TableSchemaInfo_XmlNameTable_DataTable_0;

		// Token: 0x04000A56 RID: 2646
		private static readonly IntPtr NativeMethodInfoPtr_AddColumnSchema_Private_Boolean_DataColumn_XmlNameTable_XmlNodeIdHashtable_0;

		// Token: 0x04000A57 RID: 2647
		private static readonly IntPtr NativeMethodInfoPtr_AddColumnSchema_Private_Boolean_XmlNameTable_DataColumn_XmlNodeIdHashtable_0;

		// Token: 0x04000A58 RID: 2648
		private static readonly IntPtr NativeMethodInfoPtr_BuildIdentityMap_Private_Void_DataSet_XmlNameTable_0;

		// Token: 0x04000A59 RID: 2649
		private static readonly IntPtr NativeMethodInfoPtr_BuildIdentityMap_Private_Void_XmlNameTable_DataSet_0;

		// Token: 0x04000A5A RID: 2650
		private static readonly IntPtr NativeMethodInfoPtr_BuildIdentityMap_Private_Void_DataTable_XmlNameTable_0;

		// Token: 0x04000A5B RID: 2651
		private static readonly IntPtr NativeMethodInfoPtr_BuildIdentityMap_Private_Void_XmlNameTable_DataTable_0;

		// Token: 0x04000A5C RID: 2652
		private static readonly IntPtr NativeMethodInfoPtr_GetSelfAndDescendants_Private_ArrayList_DataTable_0;

		// Token: 0x04000A5D RID: 2653
		private static readonly IntPtr NativeMethodInfoPtr_GetColumnSchema_Public_Object_XmlNode_Boolean_0;

		// Token: 0x04000A5E RID: 2654
		private static readonly IntPtr NativeMethodInfoPtr_GetColumnSchema_Public_Object_DataTable_XmlReader_Boolean_0;

		// Token: 0x04000A5F RID: 2655
		private static readonly IntPtr NativeMethodInfoPtr_GetSchemaForNode_Public_Object_XmlNode_Boolean_0;

		// Token: 0x04000A60 RID: 2656
		private static readonly IntPtr NativeMethodInfoPtr_GetTableForNode_Public_DataTable_XmlReader_Boolean_0;

		// Token: 0x04000A61 RID: 2657
		private static readonly IntPtr NativeMethodInfoPtr_HandleSpecialColumn_Private_Void_DataColumn_XmlNameTable_XmlNodeIdHashtable_0;

		// Token: 0x020000F1 RID: 241
		public sealed class XmlNodeIdentety : Object
		{
			// Token: 0x06001526 RID: 5414 RVA: 0x0006435C File Offset: 0x0006255C
			// Note: this type is marked as 'beforefieldinit'.
			static XmlNodeIdentety()
			{
				Il2CppClassPointerStore<XmlToDatasetMap.XmlNodeIdentety>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlToDatasetMap>.NativeClassPtr, "XmlNodeIdentety");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlToDatasetMap.XmlNodeIdentety>.NativeClassPtr);
				XmlToDatasetMap.XmlNodeIdentety.NativeFieldInfoPtr_LocalName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlToDatasetMap.XmlNodeIdentety>.NativeClassPtr, "LocalName");
				XmlToDatasetMap.XmlNodeIdentety.NativeFieldInfoPtr_NamespaceURI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlToDatasetMap.XmlNodeIdentety>.NativeClassPtr, "NamespaceURI");
				XmlToDatasetMap.XmlNodeIdentety.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlToDatasetMap.XmlNodeIdentety>.NativeClassPtr, 100665340);
				XmlToDatasetMap.XmlNodeIdentety.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlToDatasetMap.XmlNodeIdentety>.NativeClassPtr, 100665341);
				XmlToDatasetMap.XmlNodeIdentety.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlToDatasetMap.XmlNodeIdentety>.NativeClassPtr, 100665342);
			}

			// Token: 0x06001527 RID: 5415 RVA: 0x000643EC File Offset: 0x000625EC
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XmlNodeIdentety(string localName, string namespaceURI)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlToDatasetMap.XmlNodeIdentety>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceURI);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlToDatasetMap.XmlNodeIdentety.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001528 RID: 5416 RVA: 0x0006444C File Offset: 0x0006264C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetHashCode()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlToDatasetMap.XmlNodeIdentety.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001529 RID: 5417 RVA: 0x00064488 File Offset: 0x00062688
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 911850, XrefRangeEnd = 911853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Equals(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlToDatasetMap.XmlNodeIdentety.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600152A RID: 5418 RVA: 0x0000807A File Offset: 0x0000627A
			public XmlNodeIdentety(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170004D3 RID: 1235
			// (get) Token: 0x0600152B RID: 5419 RVA: 0x000644D8 File Offset: 0x000626D8
			// (set) Token: 0x0600152C RID: 5420 RVA: 0x00008083 File Offset: 0x00006283
			public unsafe string LocalName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlToDatasetMap.XmlNodeIdentety.NativeFieldInfoPtr_LocalName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlToDatasetMap.XmlNodeIdentety.NativeFieldInfoPtr_LocalName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170004D4 RID: 1236
			// (get) Token: 0x0600152D RID: 5421 RVA: 0x00064500 File Offset: 0x00062700
			// (set) Token: 0x0600152E RID: 5422 RVA: 0x000080A2 File Offset: 0x000062A2
			public unsafe string NamespaceURI
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlToDatasetMap.XmlNodeIdentety.NativeFieldInfoPtr_NamespaceURI);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlToDatasetMap.XmlNodeIdentety.NativeFieldInfoPtr_NamespaceURI), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04001187 RID: 4487
			private static readonly IntPtr NativeFieldInfoPtr_LocalName;

			// Token: 0x04001188 RID: 4488
			private static readonly IntPtr NativeFieldInfoPtr_NamespaceURI;

			// Token: 0x04001189 RID: 4489
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

			// Token: 0x0400118A RID: 4490
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

			// Token: 0x0400118B RID: 4491
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
		}

		// Token: 0x020000F2 RID: 242
		public sealed class XmlNodeIdHashtable : Hashtable
		{
			// Token: 0x0600152F RID: 5423 RVA: 0x00064528 File Offset: 0x00062728
			// Note: this type is marked as 'beforefieldinit'.
			static XmlNodeIdHashtable()
			{
				Il2CppClassPointerStore<XmlToDatasetMap.XmlNodeIdHashtable>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlToDatasetMap>.NativeClassPtr, "XmlNodeIdHashtable");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlToDatasetMap.XmlNodeIdHashtable>.NativeClassPtr);
				XmlToDatasetMap.XmlNodeIdHashtable.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlToDatasetMap.XmlNodeIdHashtable>.NativeClassPtr, "_id");
				XmlToDatasetMap.XmlNodeIdHashtable.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlToDatasetMap.XmlNodeIdHashtable>.NativeClassPtr, 100665343);
				XmlToDatasetMap.XmlNodeIdHashtable.NativeMethodInfoPtr_get_Item_Public_get_Object_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlToDatasetMap.XmlNodeIdHashtable>.NativeClassPtr, 100665344);
				XmlToDatasetMap.XmlNodeIdHashtable.NativeMethodInfoPtr_get_Item_Public_get_Object_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlToDatasetMap.XmlNodeIdHashtable>.NativeClassPtr, 100665345);
				XmlToDatasetMap.XmlNodeIdHashtable.NativeMethodInfoPtr_get_Item_Public_get_Object_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlToDatasetMap.XmlNodeIdHashtable>.NativeClassPtr, 100665346);
				XmlToDatasetMap.XmlNodeIdHashtable.NativeMethodInfoPtr_get_Item_Public_get_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlToDatasetMap.XmlNodeIdHashtable>.NativeClassPtr, 100665347);
			}

			// Token: 0x06001530 RID: 5424 RVA: 0x000645CC File Offset: 0x000627CC
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 911861, RefRangeEnd = 911865, XrefRangeStart = 911853, XrefRangeEnd = 911861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XmlNodeIdHashtable(int capacity)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlToDatasetMap.XmlNodeIdHashtable>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref capacity;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlToDatasetMap.XmlNodeIdHashtable.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170004D6 RID: 1238
			public unsafe Object this[XmlNode node]
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 911868, RefRangeEnd = 911871, XrefRangeStart = 911865, XrefRangeEnd = 911868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlToDatasetMap.XmlNodeIdHashtable.NativeMethodInfoPtr_get_Item_Public_get_Object_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}
			}

			// Token: 0x170004D7 RID: 1239
			public unsafe Object this[XmlReader dataReader]
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 911874, RefRangeEnd = 911876, XrefRangeStart = 911871, XrefRangeEnd = 911874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataReader);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlToDatasetMap.XmlNodeIdHashtable.NativeMethodInfoPtr_get_Item_Public_get_Object_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}
			}

			// Token: 0x170004D8 RID: 1240
			public unsafe Object this[DataTable table]
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 911881, RefRangeEnd = 911882, XrefRangeStart = 911876, XrefRangeEnd = 911881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlToDatasetMap.XmlNodeIdHashtable.NativeMethodInfoPtr_get_Item_Public_get_Object_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}
			}

			// Token: 0x170004D9 RID: 1241
			public unsafe Object this[string name]
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 911887, RefRangeEnd = 911891, XrefRangeStart = 911882, XrefRangeEnd = 911887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlToDatasetMap.XmlNodeIdHashtable.NativeMethodInfoPtr_get_Item_Public_get_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}
			}

			// Token: 0x06001535 RID: 5429 RVA: 0x000080C1 File Offset: 0x000062C1
			public XmlNodeIdHashtable(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170004D5 RID: 1237
			// (get) Token: 0x06001536 RID: 5430 RVA: 0x00064754 File Offset: 0x00062954
			// (set) Token: 0x06001537 RID: 5431 RVA: 0x000080CA File Offset: 0x000062CA
			public unsafe XmlToDatasetMap.XmlNodeIdentety _id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlToDatasetMap.XmlNodeIdHashtable.NativeFieldInfoPtr__id);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlToDatasetMap.XmlNodeIdentety>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlToDatasetMap.XmlNodeIdHashtable.NativeFieldInfoPtr__id), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400118C RID: 4492
			private static readonly IntPtr NativeFieldInfoPtr__id;

			// Token: 0x0400118D RID: 4493
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400118E RID: 4494
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Object_XmlNode_0;

			// Token: 0x0400118F RID: 4495
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Object_XmlReader_0;

			// Token: 0x04001190 RID: 4496
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Object_DataTable_0;

			// Token: 0x04001191 RID: 4497
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Object_String_0;
		}

		// Token: 0x020000F3 RID: 243
		public sealed class TableSchemaInfo : Object
		{
			// Token: 0x06001538 RID: 5432 RVA: 0x00064784 File Offset: 0x00062984
			// Note: this type is marked as 'beforefieldinit'.
			static TableSchemaInfo()
			{
				Il2CppClassPointerStore<XmlToDatasetMap.TableSchemaInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlToDatasetMap>.NativeClassPtr, "TableSchemaInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlToDatasetMap.TableSchemaInfo>.NativeClassPtr);
				XmlToDatasetMap.TableSchemaInfo.NativeFieldInfoPtr_TableSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlToDatasetMap.TableSchemaInfo>.NativeClassPtr, "TableSchema");
				XmlToDatasetMap.TableSchemaInfo.NativeFieldInfoPtr_ColumnsSchemaMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlToDatasetMap.TableSchemaInfo>.NativeClassPtr, "ColumnsSchemaMap");
				XmlToDatasetMap.TableSchemaInfo.NativeMethodInfoPtr__ctor_Public_Void_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlToDatasetMap.TableSchemaInfo>.NativeClassPtr, 100665348);
			}

			// Token: 0x06001539 RID: 5433 RVA: 0x000647EC File Offset: 0x000629EC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 911906, RefRangeEnd = 911908, XrefRangeStart = 911891, XrefRangeEnd = 911906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TableSchemaInfo(DataTable tableSchema)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlToDatasetMap.TableSchemaInfo>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(tableSchema);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlToDatasetMap.TableSchemaInfo.NativeMethodInfoPtr__ctor_Public_Void_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600153A RID: 5434 RVA: 0x000080E9 File Offset: 0x000062E9
			public TableSchemaInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170004DA RID: 1242
			// (get) Token: 0x0600153B RID: 5435 RVA: 0x00064838 File Offset: 0x00062A38
			// (set) Token: 0x0600153C RID: 5436 RVA: 0x000080F2 File Offset: 0x000062F2
			public unsafe DataTable TableSchema
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlToDatasetMap.TableSchemaInfo.NativeFieldInfoPtr_TableSchema);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlToDatasetMap.TableSchemaInfo.NativeFieldInfoPtr_TableSchema), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170004DB RID: 1243
			// (get) Token: 0x0600153D RID: 5437 RVA: 0x00064868 File Offset: 0x00062A68
			// (set) Token: 0x0600153E RID: 5438 RVA: 0x00008111 File Offset: 0x00006311
			public unsafe XmlToDatasetMap.XmlNodeIdHashtable ColumnsSchemaMap
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlToDatasetMap.TableSchemaInfo.NativeFieldInfoPtr_ColumnsSchemaMap);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlToDatasetMap.XmlNodeIdHashtable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlToDatasetMap.TableSchemaInfo.NativeFieldInfoPtr_ColumnsSchemaMap), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001192 RID: 4498
			private static readonly IntPtr NativeFieldInfoPtr_TableSchema;

			// Token: 0x04001193 RID: 4499
			private static readonly IntPtr NativeFieldInfoPtr_ColumnsSchemaMap;

			// Token: 0x04001194 RID: 4500
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataTable_0;
		}
	}
}
