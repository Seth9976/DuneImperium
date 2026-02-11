using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Xml;

namespace Il2CppSystem.Data
{
	// Token: 0x0200007A RID: 122
	public sealed class XDRSchema : XMLSchema
	{
		// Token: 0x06000B7B RID: 2939 RVA: 0x0003AAF8 File Offset: 0x00038CF8
		// Note: this type is marked as 'beforefieldinit'.
		static XDRSchema()
		{
			Il2CppClassPointerStore<XDRSchema>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "XDRSchema");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XDRSchema>.NativeClassPtr);
			XDRSchema.NativeFieldInfoPtr__schemaName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XDRSchema>.NativeClassPtr, "_schemaName");
			XDRSchema.NativeFieldInfoPtr__schemaUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XDRSchema>.NativeClassPtr, "_schemaUri");
			XDRSchema.NativeFieldInfoPtr__schemaRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XDRSchema>.NativeClassPtr, "_schemaRoot");
			XDRSchema.NativeFieldInfoPtr__ds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XDRSchema>.NativeClassPtr, "_ds");
			XDRSchema.NativeFieldInfoPtr_s_colonArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XDRSchema>.NativeClassPtr, "s_colonArray");
			XDRSchema.NativeFieldInfoPtr_s_mapNameTypeXdr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XDRSchema>.NativeClassPtr, "s_mapNameTypeXdr");
			XDRSchema.NativeFieldInfoPtr_s_enumerationNameType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XDRSchema>.NativeClassPtr, "s_enumerationNameType");
			XDRSchema.NativeMethodInfoPtr__ctor_Internal_Void_DataSet_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDRSchema>.NativeClassPtr, 100665197);
			XDRSchema.NativeMethodInfoPtr_LoadSchema_Internal_Void_XmlElement_DataSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDRSchema>.NativeClassPtr, 100665198);
			XDRSchema.NativeMethodInfoPtr_FindTypeNode_Internal_XmlElement_XmlElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDRSchema>.NativeClassPtr, 100665199);
			XDRSchema.NativeMethodInfoPtr_IsTextOnlyContent_Internal_Boolean_XmlElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDRSchema>.NativeClassPtr, 100665200);
			XDRSchema.NativeMethodInfoPtr_IsXDRField_Internal_Boolean_XmlElement_XmlElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDRSchema>.NativeClassPtr, 100665201);
			XDRSchema.NativeMethodInfoPtr_HandleTable_Internal_DataTable_XmlElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDRSchema>.NativeClassPtr, 100665202);
			XDRSchema.NativeMethodInfoPtr_FindNameType_Private_Static_NameType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDRSchema>.NativeClassPtr, 100665203);
			XDRSchema.NativeMethodInfoPtr_ParseDataType_Private_Type_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDRSchema>.NativeClassPtr, 100665204);
			XDRSchema.NativeMethodInfoPtr_GetInstanceName_Internal_String_XmlElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDRSchema>.NativeClassPtr, 100665205);
			XDRSchema.NativeMethodInfoPtr_HandleColumn_Internal_Void_XmlElement_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDRSchema>.NativeClassPtr, 100665206);
			XDRSchema.NativeMethodInfoPtr_GetMinMax_Internal_Void_XmlElement_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDRSchema>.NativeClassPtr, 100665207);
			XDRSchema.NativeMethodInfoPtr_GetMinMax_Internal_Void_XmlElement_Boolean_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDRSchema>.NativeClassPtr, 100665208);
			XDRSchema.NativeMethodInfoPtr_HandleTypeNode_Internal_Void_XmlElement_DataTable_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDRSchema>.NativeClassPtr, 100665209);
			XDRSchema.NativeMethodInfoPtr_InstantiateTable_Internal_DataTable_DataSet_XmlElement_XmlElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDRSchema>.NativeClassPtr, 100665210);
			XDRSchema.NativeMethodInfoPtr_InstantiateSimpleTable_Internal_DataTable_DataSet_XmlElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDRSchema>.NativeClassPtr, 100665211);
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x0003ACE0 File Offset: 0x00038EE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 907884, RefRangeEnd = 907885, XrefRangeStart = 907876, XrefRangeEnd = 907884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XDRSchema(DataSet ds, bool fInline)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XDRSchema>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ds);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fInline;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDRSchema.NativeMethodInfoPtr__ctor_Internal_Void_DataSet_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x0003AD3C File Offset: 0x00038F3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 907913, RefRangeEnd = 907914, XrefRangeStart = 907885, XrefRangeEnd = 907913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadSchema(XmlElement schemaRoot, DataSet ds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaRoot);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ds);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDRSchema.NativeMethodInfoPtr_LoadSchema_Internal_Void_XmlElement_DataSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x0003AD90 File Offset: 0x00038F90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 907926, RefRangeEnd = 907928, XrefRangeStart = 907914, XrefRangeEnd = 907926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlElement FindTypeNode(XmlElement node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDRSchema.NativeMethodInfoPtr_FindTypeNode_Internal_XmlElement_XmlElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlElement>(intPtr3) : null;
			}
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x0003ADE0 File Offset: 0x00038FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 907928, XrefRangeEnd = 907947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTextOnlyContent(XmlElement node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDRSchema.NativeMethodInfoPtr_IsTextOnlyContent_Internal_Boolean_XmlElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x0003AE30 File Offset: 0x00039030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 907947, XrefRangeEnd = 907985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsXDRField(XmlElement node, XmlElement typeNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDRSchema.NativeMethodInfoPtr_IsXDRField_Internal_Boolean_XmlElement_XmlElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x0003AE90 File Offset: 0x00039090
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 908002, RefRangeEnd = 908004, XrefRangeStart = 907985, XrefRangeEnd = 908002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataTable HandleTable(XmlElement node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDRSchema.NativeMethodInfoPtr_HandleTable_Internal_DataTable_XmlElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr3) : null;
			}
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x0003AEE0 File Offset: 0x000390E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 908012, RefRangeEnd = 908014, XrefRangeStart = 908004, XrefRangeEnd = 908012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XDRSchema.NameType FindNameType(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDRSchema.NativeMethodInfoPtr_FindNameType_Private_Static_NameType_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XDRSchema.NameType>(intPtr3) : null;
			}
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x0003AF24 File Offset: 0x00039124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 908014, XrefRangeEnd = 908023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type ParseDataType(string dt, string dtValues)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(dt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dtValues);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDRSchema.NativeMethodInfoPtr_ParseDataType_Private_Type_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x0003AF88 File Offset: 0x00039188
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 908042, RefRangeEnd = 908045, XrefRangeStart = 908023, XrefRangeEnd = 908042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetInstanceName(XmlElement node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDRSchema.NativeMethodInfoPtr_GetInstanceName_Internal_String_XmlElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x0003AFD0 File Offset: 0x000391D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 908186, RefRangeEnd = 908188, XrefRangeStart = 908045, XrefRangeEnd = 908186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleColumn(XmlElement node, DataTable table)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(table);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDRSchema.NativeMethodInfoPtr_HandleColumn_Internal_Void_XmlElement_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x0003B024 File Offset: 0x00039224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 908188, XrefRangeEnd = 908189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetMinMax(XmlElement elNode, ref int minOccurs, ref int maxOccurs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elNode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &minOccurs;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &maxOccurs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDRSchema.NativeMethodInfoPtr_GetMinMax_Internal_Void_XmlElement_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x0003B084 File Offset: 0x00039284
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 908221, RefRangeEnd = 908226, XrefRangeStart = 908189, XrefRangeEnd = 908221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetMinMax(XmlElement elNode, bool isAttribute, ref int minOccurs, ref int maxOccurs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elNode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAttribute;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &minOccurs;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &maxOccurs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDRSchema.NativeMethodInfoPtr_GetMinMax_Internal_Void_XmlElement_Boolean_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x0003B0F4 File Offset: 0x000392F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 908245, RefRangeEnd = 908246, XrefRangeStart = 908226, XrefRangeEnd = 908245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleTypeNode(XmlElement typeNode, DataTable table, ArrayList tableChildren)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeNode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(table);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tableChildren);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDRSchema.NativeMethodInfoPtr_HandleTypeNode_Internal_Void_XmlElement_DataTable_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x0003B15C File Offset: 0x0003935C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 908246, XrefRangeEnd = 908299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataTable InstantiateTable(DataSet dataSet, XmlElement node, XmlElement typeNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataSet);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(node);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDRSchema.NativeMethodInfoPtr_InstantiateTable_Internal_DataTable_DataSet_XmlElement_XmlElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr3) : null;
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x0003B1D0 File Offset: 0x000393D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 908324, RefRangeEnd = 908325, XrefRangeStart = 908299, XrefRangeEnd = 908324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataTable InstantiateSimpleTable(DataSet dataSet, XmlElement node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataSet);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(node);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDRSchema.NativeMethodInfoPtr_InstantiateSimpleTable_Internal_DataTable_DataSet_XmlElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr3) : null;
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x000057FE File Offset: 0x000039FE
		public XDRSchema(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000B8C RID: 2956 RVA: 0x0003B234 File Offset: 0x00039434
		// (set) Token: 0x06000B8D RID: 2957 RVA: 0x00005807 File Offset: 0x00003A07
		public unsafe string _schemaName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XDRSchema.NativeFieldInfoPtr__schemaName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XDRSchema.NativeFieldInfoPtr__schemaName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000B8E RID: 2958 RVA: 0x0003B25C File Offset: 0x0003945C
		// (set) Token: 0x06000B8F RID: 2959 RVA: 0x00005826 File Offset: 0x00003A26
		public unsafe string _schemaUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XDRSchema.NativeFieldInfoPtr__schemaUri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XDRSchema.NativeFieldInfoPtr__schemaUri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000B90 RID: 2960 RVA: 0x0003B284 File Offset: 0x00039484
		// (set) Token: 0x06000B91 RID: 2961 RVA: 0x00005845 File Offset: 0x00003A45
		public unsafe XmlElement _schemaRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XDRSchema.NativeFieldInfoPtr__schemaRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XDRSchema.NativeFieldInfoPtr__schemaRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000B92 RID: 2962 RVA: 0x0003B2B4 File Offset: 0x000394B4
		// (set) Token: 0x06000B93 RID: 2963 RVA: 0x00005864 File Offset: 0x00003A64
		public unsafe DataSet _ds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XDRSchema.NativeFieldInfoPtr__ds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XDRSchema.NativeFieldInfoPtr__ds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000B94 RID: 2964 RVA: 0x0003B2E4 File Offset: 0x000394E4
		// (set) Token: 0x06000B95 RID: 2965 RVA: 0x00005883 File Offset: 0x00003A83
		public unsafe static Il2CppStructArray<char> s_colonArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XDRSchema.NativeFieldInfoPtr_s_colonArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XDRSchema.NativeFieldInfoPtr_s_colonArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000B96 RID: 2966 RVA: 0x0003B30C File Offset: 0x0003950C
		// (set) Token: 0x06000B97 RID: 2967 RVA: 0x00005895 File Offset: 0x00003A95
		public unsafe static Il2CppReferenceArray<XDRSchema.NameType> s_mapNameTypeXdr
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XDRSchema.NativeFieldInfoPtr_s_mapNameTypeXdr, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XDRSchema.NameType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XDRSchema.NativeFieldInfoPtr_s_mapNameTypeXdr, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000B98 RID: 2968 RVA: 0x0003B334 File Offset: 0x00039534
		// (set) Token: 0x06000B99 RID: 2969 RVA: 0x000058A7 File Offset: 0x00003AA7
		public unsafe static XDRSchema.NameType s_enumerationNameType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XDRSchema.NativeFieldInfoPtr_s_enumerationNameType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XDRSchema.NameType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XDRSchema.NativeFieldInfoPtr_s_enumerationNameType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000995 RID: 2453
		private static readonly IntPtr NativeFieldInfoPtr__schemaName;

		// Token: 0x04000996 RID: 2454
		private static readonly IntPtr NativeFieldInfoPtr__schemaUri;

		// Token: 0x04000997 RID: 2455
		private static readonly IntPtr NativeFieldInfoPtr__schemaRoot;

		// Token: 0x04000998 RID: 2456
		private static readonly IntPtr NativeFieldInfoPtr__ds;

		// Token: 0x04000999 RID: 2457
		private static readonly IntPtr NativeFieldInfoPtr_s_colonArray;

		// Token: 0x0400099A RID: 2458
		private static readonly IntPtr NativeFieldInfoPtr_s_mapNameTypeXdr;

		// Token: 0x0400099B RID: 2459
		private static readonly IntPtr NativeFieldInfoPtr_s_enumerationNameType;

		// Token: 0x0400099C RID: 2460
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DataSet_Boolean_0;

		// Token: 0x0400099D RID: 2461
		private static readonly IntPtr NativeMethodInfoPtr_LoadSchema_Internal_Void_XmlElement_DataSet_0;

		// Token: 0x0400099E RID: 2462
		private static readonly IntPtr NativeMethodInfoPtr_FindTypeNode_Internal_XmlElement_XmlElement_0;

		// Token: 0x0400099F RID: 2463
		private static readonly IntPtr NativeMethodInfoPtr_IsTextOnlyContent_Internal_Boolean_XmlElement_0;

		// Token: 0x040009A0 RID: 2464
		private static readonly IntPtr NativeMethodInfoPtr_IsXDRField_Internal_Boolean_XmlElement_XmlElement_0;

		// Token: 0x040009A1 RID: 2465
		private static readonly IntPtr NativeMethodInfoPtr_HandleTable_Internal_DataTable_XmlElement_0;

		// Token: 0x040009A2 RID: 2466
		private static readonly IntPtr NativeMethodInfoPtr_FindNameType_Private_Static_NameType_String_0;

		// Token: 0x040009A3 RID: 2467
		private static readonly IntPtr NativeMethodInfoPtr_ParseDataType_Private_Type_String_String_0;

		// Token: 0x040009A4 RID: 2468
		private static readonly IntPtr NativeMethodInfoPtr_GetInstanceName_Internal_String_XmlElement_0;

		// Token: 0x040009A5 RID: 2469
		private static readonly IntPtr NativeMethodInfoPtr_HandleColumn_Internal_Void_XmlElement_DataTable_0;

		// Token: 0x040009A6 RID: 2470
		private static readonly IntPtr NativeMethodInfoPtr_GetMinMax_Internal_Void_XmlElement_byref_Int32_byref_Int32_0;

		// Token: 0x040009A7 RID: 2471
		private static readonly IntPtr NativeMethodInfoPtr_GetMinMax_Internal_Void_XmlElement_Boolean_byref_Int32_byref_Int32_0;

		// Token: 0x040009A8 RID: 2472
		private static readonly IntPtr NativeMethodInfoPtr_HandleTypeNode_Internal_Void_XmlElement_DataTable_ArrayList_0;

		// Token: 0x040009A9 RID: 2473
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateTable_Internal_DataTable_DataSet_XmlElement_XmlElement_0;

		// Token: 0x040009AA RID: 2474
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateSimpleTable_Internal_DataTable_DataSet_XmlElement_0;

		// Token: 0x020000EF RID: 239
		public sealed class NameType : Object
		{
			// Token: 0x06001516 RID: 5398 RVA: 0x00064054 File Offset: 0x00062254
			// Note: this type is marked as 'beforefieldinit'.
			static NameType()
			{
				Il2CppClassPointerStore<XDRSchema.NameType>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XDRSchema>.NativeClassPtr, "NameType");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XDRSchema.NameType>.NativeClassPtr);
				XDRSchema.NameType.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XDRSchema.NameType>.NativeClassPtr, "name");
				XDRSchema.NameType.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XDRSchema.NameType>.NativeClassPtr, "type");
				XDRSchema.NameType.NativeMethodInfoPtr__ctor_Public_Void_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDRSchema.NameType>.NativeClassPtr, 100665213);
				XDRSchema.NameType.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDRSchema.NameType>.NativeClassPtr, 100665214);
			}

			// Token: 0x06001517 RID: 5399 RVA: 0x000640D0 File Offset: 0x000622D0
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NameType(string n, Type t)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XDRSchema.NameType>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(n);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDRSchema.NameType.NativeMethodInfoPtr__ctor_Public_Void_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001518 RID: 5400 RVA: 0x00064130 File Offset: 0x00062330
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 907872, XrefRangeEnd = 907876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int CompareTo(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDRSchema.NameType.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001519 RID: 5401 RVA: 0x00007FEC File Offset: 0x000061EC
			public NameType(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170004CF RID: 1231
			// (get) Token: 0x0600151A RID: 5402 RVA: 0x00064180 File Offset: 0x00062380
			// (set) Token: 0x0600151B RID: 5403 RVA: 0x00007FF5 File Offset: 0x000061F5
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XDRSchema.NameType.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XDRSchema.NameType.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170004D0 RID: 1232
			// (get) Token: 0x0600151C RID: 5404 RVA: 0x000641A8 File Offset: 0x000623A8
			// (set) Token: 0x0600151D RID: 5405 RVA: 0x00008014 File Offset: 0x00006214
			public unsafe Type type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XDRSchema.NameType.NativeFieldInfoPtr_type);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XDRSchema.NameType.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400117F RID: 4479
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04001180 RID: 4480
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x04001181 RID: 4481
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Type_0;

			// Token: 0x04001182 RID: 4482
			private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;
		}
	}
}
