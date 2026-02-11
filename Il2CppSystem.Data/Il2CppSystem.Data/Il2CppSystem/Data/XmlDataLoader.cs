using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Xml;

namespace Il2CppSystem.Data
{
	// Token: 0x02000080 RID: 128
	public sealed class XmlDataLoader : Object
	{
		// Token: 0x06000C23 RID: 3107 RVA: 0x0003D980 File Offset: 0x0003BB80
		// Note: this type is marked as 'beforefieldinit'.
		static XmlDataLoader()
		{
			Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "XmlDataLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr);
			XmlDataLoader.NativeFieldInfoPtr__dataSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, "_dataSet");
			XmlDataLoader.NativeFieldInfoPtr__nodeToSchemaMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, "_nodeToSchemaMap");
			XmlDataLoader.NativeFieldInfoPtr__nodeToRowMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, "_nodeToRowMap");
			XmlDataLoader.NativeFieldInfoPtr__childRowsStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, "_childRowsStack");
			XmlDataLoader.NativeFieldInfoPtr__htableExcludedNS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, "_htableExcludedNS");
			XmlDataLoader.NativeFieldInfoPtr__fIsXdr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, "_fIsXdr");
			XmlDataLoader.NativeFieldInfoPtr__isDiffgram = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, "_isDiffgram");
			XmlDataLoader.NativeFieldInfoPtr__topMostNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, "_topMostNode");
			XmlDataLoader.NativeFieldInfoPtr__ignoreSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, "_ignoreSchema");
			XmlDataLoader.NativeFieldInfoPtr__dataTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, "_dataTable");
			XmlDataLoader.NativeFieldInfoPtr__isTableLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, "_isTableLevel");
			XmlDataLoader.NativeFieldInfoPtr__fromInference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, "_fromInference");
			XmlDataLoader.NativeFieldInfoPtr__dataReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, "_dataReader");
			XmlDataLoader.NativeFieldInfoPtr__XSD_XMLNS_NS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, "_XSD_XMLNS_NS");
			XmlDataLoader.NativeFieldInfoPtr__XDR_SCHEMA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, "_XDR_SCHEMA");
			XmlDataLoader.NativeFieldInfoPtr__XDRNS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, "_XDRNS");
			XmlDataLoader.NativeFieldInfoPtr__SQL_SYNC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, "_SQL_SYNC");
			XmlDataLoader.NativeFieldInfoPtr__UPDGNS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, "_UPDGNS");
			XmlDataLoader.NativeFieldInfoPtr__XSD_SCHEMA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, "_XSD_SCHEMA");
			XmlDataLoader.NativeFieldInfoPtr__XSDNS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, "_XSDNS");
			XmlDataLoader.NativeFieldInfoPtr__DFFNS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, "_DFFNS");
			XmlDataLoader.NativeFieldInfoPtr__MSDNS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, "_MSDNS");
			XmlDataLoader.NativeFieldInfoPtr__DIFFID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, "_DIFFID");
			XmlDataLoader.NativeFieldInfoPtr__HASCHANGES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, "_HASCHANGES");
			XmlDataLoader.NativeFieldInfoPtr__ROWORDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, "_ROWORDER");
			XmlDataLoader.NativeMethodInfoPtr__ctor_Internal_Void_DataSet_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, 100665293);
			XmlDataLoader.NativeMethodInfoPtr__ctor_Internal_Void_DataSet_Boolean_XmlElement_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, 100665294);
			XmlDataLoader.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, 100665295);
			XmlDataLoader.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_Boolean_XmlElement_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, 100665296);
			XmlDataLoader.NativeMethodInfoPtr_get_FromInference_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, 100665297);
			XmlDataLoader.NativeMethodInfoPtr_set_FromInference_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, 100665298);
			XmlDataLoader.NativeMethodInfoPtr_AttachRows_Private_Void_DataRow_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, 100665299);
			XmlDataLoader.NativeMethodInfoPtr_CountNonNSAttributes_Private_Int32_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, 100665300);
			XmlDataLoader.NativeMethodInfoPtr_GetValueForTextOnlyColums_Private_String_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, 100665301);
			XmlDataLoader.NativeMethodInfoPtr_GetInitialTextFromNodes_Private_String_byref_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, 100665302);
			XmlDataLoader.NativeMethodInfoPtr_GetTextOnlyColumn_Private_DataColumn_DataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, 100665303);
			XmlDataLoader.NativeMethodInfoPtr_GetRowFromElement_Internal_DataRow_XmlElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, 100665304);
			XmlDataLoader.NativeMethodInfoPtr_FColumnElement_Internal_Boolean_XmlElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, 100665305);
			XmlDataLoader.NativeMethodInfoPtr_FExcludedNamespace_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, 100665306);
			XmlDataLoader.NativeMethodInfoPtr_FIgnoreNamespace_Private_Boolean_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, 100665307);
			XmlDataLoader.NativeMethodInfoPtr_FIgnoreNamespace_Private_Boolean_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, 100665308);
			XmlDataLoader.NativeMethodInfoPtr_IsTextLikeNode_Internal_Boolean_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, 100665309);
			XmlDataLoader.NativeMethodInfoPtr_IsTextOnly_Internal_Boolean_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, 100665310);
			XmlDataLoader.NativeMethodInfoPtr_LoadData_Internal_Void_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, 100665311);
			XmlDataLoader.NativeMethodInfoPtr_LoadRowData_Private_Void_DataRow_XmlElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, 100665312);
			XmlDataLoader.NativeMethodInfoPtr_LoadRows_Private_Void_DataRow_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, 100665313);
			XmlDataLoader.NativeMethodInfoPtr_SetRowValueFromXmlText_Private_Void_DataRow_DataColumn_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, 100665314);
			XmlDataLoader.NativeMethodInfoPtr_InitNameTable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, 100665315);
			XmlDataLoader.NativeMethodInfoPtr_LoadData_Internal_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, 100665316);
			XmlDataLoader.NativeMethodInfoPtr_LoadTopMostTable_Private_Void_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, 100665317);
			XmlDataLoader.NativeMethodInfoPtr_LoadTable_Private_Void_DataTable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, 100665318);
			XmlDataLoader.NativeMethodInfoPtr_LoadColumn_Private_Void_DataColumn_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, 100665319);
			XmlDataLoader.NativeMethodInfoPtr_ProcessXsdSchema_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr, 100665320);
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x0003DDD4 File Offset: 0x0003BFD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 911146, RefRangeEnd = 911147, XrefRangeStart = 911139, XrefRangeEnd = 911146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlDataLoader(DataSet dataset, bool IsXdr, bool ignoreSchema)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref IsXdr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreSchema;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDataLoader.NativeMethodInfoPtr__ctor_Internal_Void_DataSet_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x0003DE3C File Offset: 0x0003C03C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 911160, RefRangeEnd = 911164, XrefRangeStart = 911147, XrefRangeEnd = 911160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlDataLoader(DataSet dataset, bool IsXdr, XmlElement topNode, bool ignoreSchema)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref IsXdr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(topNode);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreSchema;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDataLoader.NativeMethodInfoPtr__ctor_Internal_Void_DataSet_Boolean_XmlElement_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x0003DEB8 File Offset: 0x0003C0B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 911172, RefRangeEnd = 911173, XrefRangeStart = 911164, XrefRangeEnd = 911172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlDataLoader(DataTable datatable, bool IsXdr, bool ignoreSchema)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(datatable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref IsXdr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreSchema;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDataLoader.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x0003DF20 File Offset: 0x0003C120
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 911187, RefRangeEnd = 911189, XrefRangeStart = 911173, XrefRangeEnd = 911187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlDataLoader(DataTable datatable, bool IsXdr, XmlElement topNode, bool ignoreSchema)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlDataLoader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(datatable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref IsXdr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(topNode);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreSchema;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDataLoader.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_Boolean_XmlElement_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000C28 RID: 3112 RVA: 0x0003DF9C File Offset: 0x0003C19C
		// (set) Token: 0x06000C29 RID: 3113 RVA: 0x0003DFD8 File Offset: 0x0003C1D8
		public unsafe bool FromInference
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDataLoader.NativeMethodInfoPtr_get_FromInference_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDataLoader.NativeMethodInfoPtr_set_FromInference_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x0003E018 File Offset: 0x0003C218
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 911198, RefRangeEnd = 911201, XrefRangeStart = 911189, XrefRangeEnd = 911198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AttachRows(DataRow parentRow, XmlNode parentElement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentRow);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentElement);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDataLoader.NativeMethodInfoPtr_AttachRows_Private_Void_DataRow_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x0003E06C File Offset: 0x0003C26C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 911209, RefRangeEnd = 911210, XrefRangeStart = 911201, XrefRangeEnd = 911209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CountNonNSAttributes(XmlNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDataLoader.NativeMethodInfoPtr_CountNonNSAttributes_Private_Int32_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x0003E0BC File Offset: 0x0003C2BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 911220, RefRangeEnd = 911222, XrefRangeStart = 911210, XrefRangeEnd = 911220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetValueForTextOnlyColums(XmlNode n)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(n);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDataLoader.NativeMethodInfoPtr_GetValueForTextOnlyColums_Private_String_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x0003E104 File Offset: 0x0003C304
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 911235, RefRangeEnd = 911237, XrefRangeStart = 911222, XrefRangeEnd = 911235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetInitialTextFromNodes(ref XmlNode n)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(n);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XmlDataLoader.NativeMethodInfoPtr_GetInitialTextFromNodes_Private_String_byref_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				n = ((intPtr4 == 0) ? null : new XmlNode(intPtr4));
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x0003E164 File Offset: 0x0003C364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 911237, XrefRangeEnd = 911238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataColumn GetTextOnlyColumn(DataRow row)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDataLoader.NativeMethodInfoPtr_GetTextOnlyColumn_Private_DataColumn_DataRow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataColumn>(intPtr3) : null;
			}
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x0003E1B4 File Offset: 0x0003C3B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 911240, RefRangeEnd = 911242, XrefRangeStart = 911238, XrefRangeEnd = 911240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataRow GetRowFromElement(XmlElement e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDataLoader.NativeMethodInfoPtr_GetRowFromElement_Internal_DataRow_XmlElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataRow>(intPtr3) : null;
			}
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x0003E204 File Offset: 0x0003C404
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 911247, RefRangeEnd = 911249, XrefRangeStart = 911242, XrefRangeEnd = 911247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FColumnElement(XmlElement e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDataLoader.NativeMethodInfoPtr_FColumnElement_Internal_Boolean_XmlElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x0003E254 File Offset: 0x0003C454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 911249, XrefRangeEnd = 911252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FExcludedNamespace(string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ns);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDataLoader.NativeMethodInfoPtr_FExcludedNamespace_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x0003E2A4 File Offset: 0x0003C4A4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 911257, RefRangeEnd = 911265, XrefRangeStart = 911252, XrefRangeEnd = 911257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FIgnoreNamespace(XmlNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDataLoader.NativeMethodInfoPtr_FIgnoreNamespace_Private_Boolean_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x0003E2F4 File Offset: 0x0003C4F4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 911268, RefRangeEnd = 911274, XrefRangeStart = 911265, XrefRangeEnd = 911268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FIgnoreNamespace(XmlReader node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDataLoader.NativeMethodInfoPtr_FIgnoreNamespace_Private_Boolean_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x0003E344 File Offset: 0x0003C544
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 911274, RefRangeEnd = 911275, XrefRangeStart = 911274, XrefRangeEnd = 911274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTextLikeNode(XmlNodeType n)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref n;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDataLoader.NativeMethodInfoPtr_IsTextLikeNode_Internal_Boolean_XmlNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x0003E390 File Offset: 0x0003C590
		[CallerCount(0)]
		public unsafe bool IsTextOnly(DataColumn c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDataLoader.NativeMethodInfoPtr_IsTextOnly_Internal_Boolean_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x0003E3E0 File Offset: 0x0003C5E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 911306, RefRangeEnd = 911309, XrefRangeStart = 911275, XrefRangeEnd = 911306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadData(XmlDocument xdoc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xdoc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDataLoader.NativeMethodInfoPtr_LoadData_Internal_Void_XmlDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x0003E424 File Offset: 0x0003C624
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 911414, RefRangeEnd = 911416, XrefRangeStart = 911309, XrefRangeEnd = 911414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadRowData(DataRow row, XmlElement rowElement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rowElement);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDataLoader.NativeMethodInfoPtr_LoadRowData_Private_Void_DataRow_XmlElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x0003E478 File Offset: 0x0003C678
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 911447, RefRangeEnd = 911449, XrefRangeStart = 911416, XrefRangeEnd = 911447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadRows(DataRow parentRow, XmlNode parentElement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentRow);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentElement);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDataLoader.NativeMethodInfoPtr_LoadRows_Private_Void_DataRow_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x0003E4CC File Offset: 0x0003C6CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 911449, XrefRangeEnd = 911452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRowValueFromXmlText(DataRow row, DataColumn col, string xmlText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(col);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xmlText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDataLoader.NativeMethodInfoPtr_SetRowValueFromXmlText_Private_Void_DataRow_DataColumn_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x0003E534 File Offset: 0x0003C734
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 911489, RefRangeEnd = 911490, XrefRangeStart = 911452, XrefRangeEnd = 911489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitNameTable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDataLoader.NativeMethodInfoPtr_InitNameTable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x0003E568 File Offset: 0x0003C768
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 911524, RefRangeEnd = 911529, XrefRangeStart = 911490, XrefRangeEnd = 911524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadData(XmlReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDataLoader.NativeMethodInfoPtr_LoadData_Internal_Void_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x0003E5AC File Offset: 0x0003C7AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 911590, RefRangeEnd = 911591, XrefRangeStart = 911529, XrefRangeEnd = 911590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadTopMostTable(DataTable table)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDataLoader.NativeMethodInfoPtr_LoadTopMostTable_Private_Void_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x0003E5F0 File Offset: 0x0003C7F0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 911723, RefRangeEnd = 911727, XrefRangeStart = 911591, XrefRangeEnd = 911723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadTable(DataTable table, bool isNested)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNested;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDataLoader.NativeMethodInfoPtr_LoadTable_Private_Void_DataTable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x0003E640 File Offset: 0x0003C840
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 911831, RefRangeEnd = 911834, XrefRangeStart = 911727, XrefRangeEnd = 911831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadColumn(DataColumn column, Il2CppReferenceArray<Object> foundColumns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(foundColumns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDataLoader.NativeMethodInfoPtr_LoadColumn_Private_Void_DataColumn_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x0003E694 File Offset: 0x0003C894
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 911846, RefRangeEnd = 911850, XrefRangeStart = 911834, XrefRangeEnd = 911846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ProcessXsdSchema()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDataLoader.NativeMethodInfoPtr_ProcessXsdSchema_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x00005BFB File Offset: 0x00003DFB
		public XmlDataLoader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000C41 RID: 3137 RVA: 0x0003E6D0 File Offset: 0x0003C8D0
		// (set) Token: 0x06000C42 RID: 3138 RVA: 0x00005C04 File Offset: 0x00003E04
		public unsafe DataSet _dataSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__dataSet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__dataSet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000C43 RID: 3139 RVA: 0x0003E700 File Offset: 0x0003C900
		// (set) Token: 0x06000C44 RID: 3140 RVA: 0x00005C23 File Offset: 0x00003E23
		public unsafe XmlToDatasetMap _nodeToSchemaMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__nodeToSchemaMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlToDatasetMap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__nodeToSchemaMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000C45 RID: 3141 RVA: 0x0003E730 File Offset: 0x0003C930
		// (set) Token: 0x06000C46 RID: 3142 RVA: 0x00005C42 File Offset: 0x00003E42
		public unsafe Hashtable _nodeToRowMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__nodeToRowMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__nodeToRowMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000C47 RID: 3143 RVA: 0x0003E760 File Offset: 0x0003C960
		// (set) Token: 0x06000C48 RID: 3144 RVA: 0x00005C61 File Offset: 0x00003E61
		public unsafe Stack _childRowsStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__childRowsStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__childRowsStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000C49 RID: 3145 RVA: 0x0003E790 File Offset: 0x0003C990
		// (set) Token: 0x06000C4A RID: 3146 RVA: 0x00005C80 File Offset: 0x00003E80
		public unsafe Hashtable _htableExcludedNS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__htableExcludedNS);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__htableExcludedNS), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000C4B RID: 3147 RVA: 0x0003E7C0 File Offset: 0x0003C9C0
		// (set) Token: 0x06000C4C RID: 3148 RVA: 0x00005C9F File Offset: 0x00003E9F
		public unsafe bool _fIsXdr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__fIsXdr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__fIsXdr)) = value;
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000C4D RID: 3149 RVA: 0x0003E7E8 File Offset: 0x0003C9E8
		// (set) Token: 0x06000C4E RID: 3150 RVA: 0x00005CBA File Offset: 0x00003EBA
		public unsafe bool _isDiffgram
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__isDiffgram);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__isDiffgram)) = value;
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000C4F RID: 3151 RVA: 0x0003E810 File Offset: 0x0003CA10
		// (set) Token: 0x06000C50 RID: 3152 RVA: 0x00005CD5 File Offset: 0x00003ED5
		public unsafe XmlElement _topMostNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__topMostNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__topMostNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000C51 RID: 3153 RVA: 0x0003E840 File Offset: 0x0003CA40
		// (set) Token: 0x06000C52 RID: 3154 RVA: 0x00005CF4 File Offset: 0x00003EF4
		public unsafe bool _ignoreSchema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__ignoreSchema);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__ignoreSchema)) = value;
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000C53 RID: 3155 RVA: 0x0003E868 File Offset: 0x0003CA68
		// (set) Token: 0x06000C54 RID: 3156 RVA: 0x00005D0F File Offset: 0x00003F0F
		public unsafe DataTable _dataTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__dataTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__dataTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000C55 RID: 3157 RVA: 0x0003E898 File Offset: 0x0003CA98
		// (set) Token: 0x06000C56 RID: 3158 RVA: 0x00005D2E File Offset: 0x00003F2E
		public unsafe bool _isTableLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__isTableLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__isTableLevel)) = value;
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000C57 RID: 3159 RVA: 0x0003E8C0 File Offset: 0x0003CAC0
		// (set) Token: 0x06000C58 RID: 3160 RVA: 0x00005D49 File Offset: 0x00003F49
		public unsafe bool _fromInference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__fromInference);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__fromInference)) = value;
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000C59 RID: 3161 RVA: 0x0003E8E8 File Offset: 0x0003CAE8
		// (set) Token: 0x06000C5A RID: 3162 RVA: 0x00005D64 File Offset: 0x00003F64
		public unsafe XmlReader _dataReader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__dataReader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__dataReader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000C5B RID: 3163 RVA: 0x0003E918 File Offset: 0x0003CB18
		// (set) Token: 0x06000C5C RID: 3164 RVA: 0x00005D83 File Offset: 0x00003F83
		public unsafe Object _XSD_XMLNS_NS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__XSD_XMLNS_NS);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__XSD_XMLNS_NS), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000C5D RID: 3165 RVA: 0x0003E948 File Offset: 0x0003CB48
		// (set) Token: 0x06000C5E RID: 3166 RVA: 0x00005DA2 File Offset: 0x00003FA2
		public unsafe Object _XDR_SCHEMA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__XDR_SCHEMA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__XDR_SCHEMA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000C5F RID: 3167 RVA: 0x0003E978 File Offset: 0x0003CB78
		// (set) Token: 0x06000C60 RID: 3168 RVA: 0x00005DC1 File Offset: 0x00003FC1
		public unsafe Object _XDRNS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__XDRNS);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__XDRNS), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000C61 RID: 3169 RVA: 0x0003E9A8 File Offset: 0x0003CBA8
		// (set) Token: 0x06000C62 RID: 3170 RVA: 0x00005DE0 File Offset: 0x00003FE0
		public unsafe Object _SQL_SYNC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__SQL_SYNC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__SQL_SYNC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000C63 RID: 3171 RVA: 0x0003E9D8 File Offset: 0x0003CBD8
		// (set) Token: 0x06000C64 RID: 3172 RVA: 0x00005DFF File Offset: 0x00003FFF
		public unsafe Object _UPDGNS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__UPDGNS);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__UPDGNS), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000C65 RID: 3173 RVA: 0x0003EA08 File Offset: 0x0003CC08
		// (set) Token: 0x06000C66 RID: 3174 RVA: 0x00005E1E File Offset: 0x0000401E
		public unsafe Object _XSD_SCHEMA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__XSD_SCHEMA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__XSD_SCHEMA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000C67 RID: 3175 RVA: 0x0003EA38 File Offset: 0x0003CC38
		// (set) Token: 0x06000C68 RID: 3176 RVA: 0x00005E3D File Offset: 0x0000403D
		public unsafe Object _XSDNS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__XSDNS);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__XSDNS), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000C69 RID: 3177 RVA: 0x0003EA68 File Offset: 0x0003CC68
		// (set) Token: 0x06000C6A RID: 3178 RVA: 0x00005E5C File Offset: 0x0000405C
		public unsafe Object _DFFNS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__DFFNS);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__DFFNS), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000C6B RID: 3179 RVA: 0x0003EA98 File Offset: 0x0003CC98
		// (set) Token: 0x06000C6C RID: 3180 RVA: 0x00005E7B File Offset: 0x0000407B
		public unsafe Object _MSDNS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__MSDNS);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__MSDNS), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000C6D RID: 3181 RVA: 0x0003EAC8 File Offset: 0x0003CCC8
		// (set) Token: 0x06000C6E RID: 3182 RVA: 0x00005E9A File Offset: 0x0000409A
		public unsafe Object _DIFFID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__DIFFID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__DIFFID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000C6F RID: 3183 RVA: 0x0003EAF8 File Offset: 0x0003CCF8
		// (set) Token: 0x06000C70 RID: 3184 RVA: 0x00005EB9 File Offset: 0x000040B9
		public unsafe Object _HASCHANGES
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__HASCHANGES);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__HASCHANGES), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000C71 RID: 3185 RVA: 0x0003EB28 File Offset: 0x0003CD28
		// (set) Token: 0x06000C72 RID: 3186 RVA: 0x00005ED8 File Offset: 0x000040D8
		public unsafe Object _ROWORDER
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__ROWORDER);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDataLoader.NativeFieldInfoPtr__ROWORDER), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A10 RID: 2576
		private static readonly IntPtr NativeFieldInfoPtr__dataSet;

		// Token: 0x04000A11 RID: 2577
		private static readonly IntPtr NativeFieldInfoPtr__nodeToSchemaMap;

		// Token: 0x04000A12 RID: 2578
		private static readonly IntPtr NativeFieldInfoPtr__nodeToRowMap;

		// Token: 0x04000A13 RID: 2579
		private static readonly IntPtr NativeFieldInfoPtr__childRowsStack;

		// Token: 0x04000A14 RID: 2580
		private static readonly IntPtr NativeFieldInfoPtr__htableExcludedNS;

		// Token: 0x04000A15 RID: 2581
		private static readonly IntPtr NativeFieldInfoPtr__fIsXdr;

		// Token: 0x04000A16 RID: 2582
		private static readonly IntPtr NativeFieldInfoPtr__isDiffgram;

		// Token: 0x04000A17 RID: 2583
		private static readonly IntPtr NativeFieldInfoPtr__topMostNode;

		// Token: 0x04000A18 RID: 2584
		private static readonly IntPtr NativeFieldInfoPtr__ignoreSchema;

		// Token: 0x04000A19 RID: 2585
		private static readonly IntPtr NativeFieldInfoPtr__dataTable;

		// Token: 0x04000A1A RID: 2586
		private static readonly IntPtr NativeFieldInfoPtr__isTableLevel;

		// Token: 0x04000A1B RID: 2587
		private static readonly IntPtr NativeFieldInfoPtr__fromInference;

		// Token: 0x04000A1C RID: 2588
		private static readonly IntPtr NativeFieldInfoPtr__dataReader;

		// Token: 0x04000A1D RID: 2589
		private static readonly IntPtr NativeFieldInfoPtr__XSD_XMLNS_NS;

		// Token: 0x04000A1E RID: 2590
		private static readonly IntPtr NativeFieldInfoPtr__XDR_SCHEMA;

		// Token: 0x04000A1F RID: 2591
		private static readonly IntPtr NativeFieldInfoPtr__XDRNS;

		// Token: 0x04000A20 RID: 2592
		private static readonly IntPtr NativeFieldInfoPtr__SQL_SYNC;

		// Token: 0x04000A21 RID: 2593
		private static readonly IntPtr NativeFieldInfoPtr__UPDGNS;

		// Token: 0x04000A22 RID: 2594
		private static readonly IntPtr NativeFieldInfoPtr__XSD_SCHEMA;

		// Token: 0x04000A23 RID: 2595
		private static readonly IntPtr NativeFieldInfoPtr__XSDNS;

		// Token: 0x04000A24 RID: 2596
		private static readonly IntPtr NativeFieldInfoPtr__DFFNS;

		// Token: 0x04000A25 RID: 2597
		private static readonly IntPtr NativeFieldInfoPtr__MSDNS;

		// Token: 0x04000A26 RID: 2598
		private static readonly IntPtr NativeFieldInfoPtr__DIFFID;

		// Token: 0x04000A27 RID: 2599
		private static readonly IntPtr NativeFieldInfoPtr__HASCHANGES;

		// Token: 0x04000A28 RID: 2600
		private static readonly IntPtr NativeFieldInfoPtr__ROWORDER;

		// Token: 0x04000A29 RID: 2601
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DataSet_Boolean_Boolean_0;

		// Token: 0x04000A2A RID: 2602
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DataSet_Boolean_XmlElement_Boolean_0;

		// Token: 0x04000A2B RID: 2603
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DataTable_Boolean_Boolean_0;

		// Token: 0x04000A2C RID: 2604
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DataTable_Boolean_XmlElement_Boolean_0;

		// Token: 0x04000A2D RID: 2605
		private static readonly IntPtr NativeMethodInfoPtr_get_FromInference_Internal_get_Boolean_0;

		// Token: 0x04000A2E RID: 2606
		private static readonly IntPtr NativeMethodInfoPtr_set_FromInference_Internal_set_Void_Boolean_0;

		// Token: 0x04000A2F RID: 2607
		private static readonly IntPtr NativeMethodInfoPtr_AttachRows_Private_Void_DataRow_XmlNode_0;

		// Token: 0x04000A30 RID: 2608
		private static readonly IntPtr NativeMethodInfoPtr_CountNonNSAttributes_Private_Int32_XmlNode_0;

		// Token: 0x04000A31 RID: 2609
		private static readonly IntPtr NativeMethodInfoPtr_GetValueForTextOnlyColums_Private_String_XmlNode_0;

		// Token: 0x04000A32 RID: 2610
		private static readonly IntPtr NativeMethodInfoPtr_GetInitialTextFromNodes_Private_String_byref_XmlNode_0;

		// Token: 0x04000A33 RID: 2611
		private static readonly IntPtr NativeMethodInfoPtr_GetTextOnlyColumn_Private_DataColumn_DataRow_0;

		// Token: 0x04000A34 RID: 2612
		private static readonly IntPtr NativeMethodInfoPtr_GetRowFromElement_Internal_DataRow_XmlElement_0;

		// Token: 0x04000A35 RID: 2613
		private static readonly IntPtr NativeMethodInfoPtr_FColumnElement_Internal_Boolean_XmlElement_0;

		// Token: 0x04000A36 RID: 2614
		private static readonly IntPtr NativeMethodInfoPtr_FExcludedNamespace_Private_Boolean_String_0;

		// Token: 0x04000A37 RID: 2615
		private static readonly IntPtr NativeMethodInfoPtr_FIgnoreNamespace_Private_Boolean_XmlNode_0;

		// Token: 0x04000A38 RID: 2616
		private static readonly IntPtr NativeMethodInfoPtr_FIgnoreNamespace_Private_Boolean_XmlReader_0;

		// Token: 0x04000A39 RID: 2617
		private static readonly IntPtr NativeMethodInfoPtr_IsTextLikeNode_Internal_Boolean_XmlNodeType_0;

		// Token: 0x04000A3A RID: 2618
		private static readonly IntPtr NativeMethodInfoPtr_IsTextOnly_Internal_Boolean_DataColumn_0;

		// Token: 0x04000A3B RID: 2619
		private static readonly IntPtr NativeMethodInfoPtr_LoadData_Internal_Void_XmlDocument_0;

		// Token: 0x04000A3C RID: 2620
		private static readonly IntPtr NativeMethodInfoPtr_LoadRowData_Private_Void_DataRow_XmlElement_0;

		// Token: 0x04000A3D RID: 2621
		private static readonly IntPtr NativeMethodInfoPtr_LoadRows_Private_Void_DataRow_XmlNode_0;

		// Token: 0x04000A3E RID: 2622
		private static readonly IntPtr NativeMethodInfoPtr_SetRowValueFromXmlText_Private_Void_DataRow_DataColumn_String_0;

		// Token: 0x04000A3F RID: 2623
		private static readonly IntPtr NativeMethodInfoPtr_InitNameTable_Private_Void_0;

		// Token: 0x04000A40 RID: 2624
		private static readonly IntPtr NativeMethodInfoPtr_LoadData_Internal_Void_XmlReader_0;

		// Token: 0x04000A41 RID: 2625
		private static readonly IntPtr NativeMethodInfoPtr_LoadTopMostTable_Private_Void_DataTable_0;

		// Token: 0x04000A42 RID: 2626
		private static readonly IntPtr NativeMethodInfoPtr_LoadTable_Private_Void_DataTable_Boolean_0;

		// Token: 0x04000A43 RID: 2627
		private static readonly IntPtr NativeMethodInfoPtr_LoadColumn_Private_Void_DataColumn_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000A44 RID: 2628
		private static readonly IntPtr NativeMethodInfoPtr_ProcessXsdSchema_Private_Boolean_0;
	}
}
