using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000077 RID: 119
	public class XmlNodeReaderNavigator : Object
	{
		// Token: 0x06000E40 RID: 3648 RVA: 0x000545C0 File Offset: 0x000527C0
		// Note: this type is marked as 'beforefieldinit'.
		static XmlNodeReaderNavigator()
		{
			Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlNodeReaderNavigator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr);
			XmlNodeReaderNavigator.NativeFieldInfoPtr_curNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, "curNode");
			XmlNodeReaderNavigator.NativeFieldInfoPtr_elemNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, "elemNode");
			XmlNodeReaderNavigator.NativeFieldInfoPtr_logNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, "logNode");
			XmlNodeReaderNavigator.NativeFieldInfoPtr_attrIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, "attrIndex");
			XmlNodeReaderNavigator.NativeFieldInfoPtr_logAttrIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, "logAttrIndex");
			XmlNodeReaderNavigator.NativeFieldInfoPtr_nameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, "nameTable");
			XmlNodeReaderNavigator.NativeFieldInfoPtr_doc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, "doc");
			XmlNodeReaderNavigator.NativeFieldInfoPtr_nAttrInd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, "nAttrInd");
			XmlNodeReaderNavigator.NativeFieldInfoPtr_nDeclarationAttrCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, "nDeclarationAttrCount");
			XmlNodeReaderNavigator.NativeFieldInfoPtr_nDocTypeAttrCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, "nDocTypeAttrCount");
			XmlNodeReaderNavigator.NativeFieldInfoPtr_nLogLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, "nLogLevel");
			XmlNodeReaderNavigator.NativeFieldInfoPtr_nLogAttrInd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, "nLogAttrInd");
			XmlNodeReaderNavigator.NativeFieldInfoPtr_bLogOnAttrVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, "bLogOnAttrVal");
			XmlNodeReaderNavigator.NativeFieldInfoPtr_bCreatedOnAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, "bCreatedOnAttribute");
			XmlNodeReaderNavigator.NativeFieldInfoPtr_decNodeAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, "decNodeAttributes");
			XmlNodeReaderNavigator.NativeFieldInfoPtr_docTypeNodeAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, "docTypeNodeAttributes");
			XmlNodeReaderNavigator.NativeFieldInfoPtr_bOnAttrVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, "bOnAttrVal");
			XmlNodeReaderNavigator.NativeMethodInfoPtr__ctor_Public_Void_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665640);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_get_NodeType_Public_get_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665641);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_get_NamespaceURI_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665642);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665643);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_get_LocalName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665644);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_get_CreatedOnAttribute_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665645);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_IsLocalNameEmpty_Private_Boolean_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665646);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_get_Prefix_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665647);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_get_Value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665648);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_get_BaseURI_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665649);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_get_XmlSpace_Public_get_XmlSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665650);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_get_XmlLang_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665651);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_get_IsEmptyElement_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665652);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_get_IsDefault_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665653);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_get_SchemaInfo_Public_get_IXmlSchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665654);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_get_NameTable_Public_get_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665655);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_get_AttributeCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665656);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_CheckIndexCondition_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665657);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_InitDecAttr_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665658);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_GetDeclarationAttr_Public_String_XmlDeclaration_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665659);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_GetDeclarationAttr_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665660);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_GetDecAttrInd_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665661);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_InitDocTypeAttr_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665662);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_GetDocumentTypeAttr_Public_String_XmlDocumentType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665663);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_GetDocumentTypeAttr_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665664);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_GetDocTypeAttrInd_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665665);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_GetAttributeFromElement_Private_String_XmlElement_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665666);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_GetAttribute_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665667);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_GetAttributeFromElement_Private_String_XmlElement_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665668);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_GetAttribute_Public_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665669);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_GetAttribute_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665670);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_LogMove_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665671);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_RollBackMove_Public_Void_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665672);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_get_IsOnDeclOrDocType_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665673);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_ResetToAttribute_Public_Void_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665674);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_ResetMove_Public_Void_byref_Int32_byref_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665675);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_MoveToAttribute_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665676);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_MoveToAttributeFromElement_Private_Boolean_XmlElement_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665677);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_MoveToAttribute_Public_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665678);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_MoveToAttribute_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665679);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_MoveToNextAttribute_Public_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665680);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_MoveToParent_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665681);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_MoveToFirstChild_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665682);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_MoveToNextSibling_Private_Boolean_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665683);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_MoveToNext_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665684);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_MoveToElement_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665685);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_LookupNamespace_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665686);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_DefaultLookupNamespace_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665687);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_LookupPrefix_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665688);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_GetNamespacesInScope_Internal_IDictionary_2_String_String_XmlNamespaceScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665689);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_ReadAttributeValue_Public_Boolean_byref_Int32_byref_Boolean_byref_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665690);
			XmlNodeReaderNavigator.NativeMethodInfoPtr_get_Document_Public_get_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, 100665691);
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x00054B54 File Offset: 0x00052D54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 375669, RefRangeEnd = 375670, XrefRangeStart = 375635, XrefRangeEnd = 375669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNodeReaderNavigator(XmlNode node)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr__ctor_Public_Void_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000E42 RID: 3650 RVA: 0x00054BA0 File Offset: 0x00052DA0
		public unsafe XmlNodeType NodeType
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 375670, RefRangeEnd = 375672, XrefRangeStart = 375670, XrefRangeEnd = 375670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_get_NodeType_Public_get_XmlNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000E43 RID: 3651 RVA: 0x00054BDC File Offset: 0x00052DDC
		public unsafe string NamespaceURI
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375672, XrefRangeEnd = 375673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_get_NamespaceURI_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000E44 RID: 3652 RVA: 0x00054C14 File Offset: 0x00052E14
		public unsafe string Name
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 375674, RefRangeEnd = 375675, XrefRangeStart = 375673, XrefRangeEnd = 375674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000E45 RID: 3653 RVA: 0x00054C4C File Offset: 0x00052E4C
		public unsafe string LocalName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375675, XrefRangeEnd = 375677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_get_LocalName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000E46 RID: 3654 RVA: 0x00054C84 File Offset: 0x00052E84
		public unsafe bool CreatedOnAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_get_CreatedOnAttribute_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x00054CC0 File Offset: 0x00052EC0
		[CallerCount(0)]
		public unsafe bool IsLocalNameEmpty(XmlNodeType nt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_IsLocalNameEmpty_Private_Boolean_XmlNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06000E48 RID: 3656 RVA: 0x00054D0C File Offset: 0x00052F0C
		public unsafe string Prefix
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_get_Prefix_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06000E49 RID: 3657 RVA: 0x00054D44 File Offset: 0x00052F44
		public unsafe string Value
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 375699, RefRangeEnd = 375700, XrefRangeStart = 375677, XrefRangeEnd = 375699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_get_Value_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06000E4A RID: 3658 RVA: 0x00054D7C File Offset: 0x00052F7C
		public unsafe string BaseURI
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375700, XrefRangeEnd = 375701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_get_BaseURI_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06000E4B RID: 3659 RVA: 0x00054DB4 File Offset: 0x00052FB4
		public unsafe XmlSpace XmlSpace
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375701, XrefRangeEnd = 375702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_get_XmlSpace_Public_get_XmlSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06000E4C RID: 3660 RVA: 0x00054DF0 File Offset: 0x00052FF0
		public unsafe string XmlLang
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375702, XrefRangeEnd = 375703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_get_XmlLang_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06000E4D RID: 3661 RVA: 0x00054E28 File Offset: 0x00053028
		public unsafe bool IsEmptyElement
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 375704, RefRangeEnd = 375706, XrefRangeStart = 375703, XrefRangeEnd = 375704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_get_IsEmptyElement_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06000E4E RID: 3662 RVA: 0x00054E64 File Offset: 0x00053064
		public unsafe bool IsDefault
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375706, XrefRangeEnd = 375707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_get_IsDefault_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06000E4F RID: 3663 RVA: 0x00054EA0 File Offset: 0x000530A0
		public unsafe IXmlSchemaInfo SchemaInfo
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 375708, RefRangeEnd = 375709, XrefRangeStart = 375707, XrefRangeEnd = 375708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_get_SchemaInfo_Public_get_IXmlSchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlSchemaInfo>(intPtr3) : null;
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06000E50 RID: 3664 RVA: 0x00054EE0 File Offset: 0x000530E0
		public unsafe XmlNameTable NameTable
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_get_NameTable_Public_get_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr3) : null;
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06000E51 RID: 3665 RVA: 0x00054F20 File Offset: 0x00053120
		public unsafe int AttributeCount
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 375711, RefRangeEnd = 375713, XrefRangeStart = 375709, XrefRangeEnd = 375711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_get_AttributeCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x00054F5C File Offset: 0x0005315C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 375714, RefRangeEnd = 375716, XrefRangeStart = 375713, XrefRangeEnd = 375714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckIndexCondition(int attributeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref attributeIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_CheckIndexCondition_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x00054F9C File Offset: 0x0005319C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 375734, RefRangeEnd = 375739, XrefRangeStart = 375716, XrefRangeEnd = 375734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitDecAttr()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_InitDecAttr_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x00054FD0 File Offset: 0x000531D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375739, XrefRangeEnd = 375748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetDeclarationAttr(XmlDeclaration decl, string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(decl);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_GetDeclarationAttr_Public_String_XmlDeclaration_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E55 RID: 3669 RVA: 0x0005502C File Offset: 0x0005322C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375748, XrefRangeEnd = 375749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetDeclarationAttr(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_GetDeclarationAttr_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x00055070 File Offset: 0x00053270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375749, XrefRangeEnd = 375751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetDecAttrInd(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_GetDecAttrInd_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x000550C0 File Offset: 0x000532C0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 375761, RefRangeEnd = 375766, XrefRangeStart = 375751, XrefRangeEnd = 375761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitDocTypeAttr()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_InitDocTypeAttr_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x000550F4 File Offset: 0x000532F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375766, XrefRangeEnd = 375772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetDocumentTypeAttr(XmlDocumentType docType, string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(docType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_GetDocumentTypeAttr_Public_String_XmlDocumentType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x00055150 File Offset: 0x00053350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375772, XrefRangeEnd = 375773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetDocumentTypeAttr(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_GetDocumentTypeAttr_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x00055194 File Offset: 0x00053394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375773, XrefRangeEnd = 375775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetDocTypeAttrInd(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_GetDocTypeAttrInd_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x000551E4 File Offset: 0x000533E4
		[CallerCount(0)]
		public unsafe string GetAttributeFromElement(XmlElement elem, string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_GetAttributeFromElement_Private_String_XmlElement_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x00055240 File Offset: 0x00053440
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 375786, RefRangeEnd = 375787, XrefRangeStart = 375775, XrefRangeEnd = 375786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetAttribute(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_GetAttribute_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x00055288 File Offset: 0x00053488
		[CallerCount(0)]
		public unsafe string GetAttributeFromElement(XmlElement elem, string name, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_GetAttributeFromElement_Private_String_XmlElement_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E5E RID: 3678 RVA: 0x000552F4 File Offset: 0x000534F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 375798, RefRangeEnd = 375799, XrefRangeStart = 375787, XrefRangeEnd = 375798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetAttribute(string name, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_GetAttribute_Public_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x00055350 File Offset: 0x00053550
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 375802, RefRangeEnd = 375803, XrefRangeStart = 375799, XrefRangeEnd = 375802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetAttribute(int attributeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref attributeIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_GetAttribute_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x00055394 File Offset: 0x00053594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375803, XrefRangeEnd = 375804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogMove(int level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref level;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_LogMove_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x000553D4 File Offset: 0x000535D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375804, XrefRangeEnd = 375805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RollBackMove(ref int level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &level;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_RollBackMove_Public_Void_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06000E62 RID: 3682 RVA: 0x00055414 File Offset: 0x00053614
		public unsafe bool IsOnDeclOrDocType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_get_IsOnDeclOrDocType_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x00055450 File Offset: 0x00053650
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 375807, RefRangeEnd = 375809, XrefRangeStart = 375805, XrefRangeEnd = 375807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetToAttribute(ref int level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &level;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_ResetToAttribute_Public_Void_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x00055490 File Offset: 0x00053690
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 375816, RefRangeEnd = 375821, XrefRangeStart = 375809, XrefRangeEnd = 375816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetMove(ref int level, ref XmlNodeType nt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &level;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &nt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_ResetMove_Public_Void_byref_Int32_byref_XmlNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x000554DC File Offset: 0x000536DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375821, XrefRangeEnd = 375824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveToAttribute(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_MoveToAttribute_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x0005552C File Offset: 0x0005372C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375824, XrefRangeEnd = 375828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveToAttributeFromElement(XmlElement elem, string name, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_MoveToAttributeFromElement_Private_Boolean_XmlElement_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x000555A0 File Offset: 0x000537A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 375831, RefRangeEnd = 375833, XrefRangeStart = 375828, XrefRangeEnd = 375831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveToAttribute(string name, string namespaceURI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceURI);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_MoveToAttribute_Public_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x00055600 File Offset: 0x00053800
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 375835, RefRangeEnd = 375836, XrefRangeStart = 375833, XrefRangeEnd = 375835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveToAttribute(int attributeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref attributeIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_MoveToAttribute_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x00055640 File Offset: 0x00053840
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 375839, RefRangeEnd = 375840, XrefRangeStart = 375836, XrefRangeEnd = 375839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveToNextAttribute(ref int level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &level;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_MoveToNextAttribute_Public_Boolean_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x0005568C File Offset: 0x0005388C
		[CallerCount(0)]
		public unsafe bool MoveToParent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_MoveToParent_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x000556C8 File Offset: 0x000538C8
		[CallerCount(0)]
		public unsafe bool MoveToFirstChild()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_MoveToFirstChild_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x00055704 File Offset: 0x00053904
		[CallerCount(0)]
		public unsafe bool MoveToNextSibling(XmlNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_MoveToNextSibling_Private_Boolean_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x00055754 File Offset: 0x00053954
		[CallerCount(0)]
		public unsafe bool MoveToNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_MoveToNext_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x00055790 File Offset: 0x00053990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375840, XrefRangeEnd = 375841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveToElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_MoveToElement_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x000557CC File Offset: 0x000539CC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 375861, RefRangeEnd = 375865, XrefRangeStart = 375841, XrefRangeEnd = 375861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string LookupNamespace(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_LookupNamespace_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x00055814 File Offset: 0x00053A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375865, XrefRangeEnd = 375879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string DefaultLookupNamespace(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_DefaultLookupNamespace_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x0005585C File Offset: 0x00053A5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 375909, RefRangeEnd = 375910, XrefRangeStart = 375879, XrefRangeEnd = 375909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string LookupPrefix(string namespaceName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(namespaceName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_LookupPrefix_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x000558A4 File Offset: 0x00053AA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 375959, RefRangeEnd = 375960, XrefRangeStart = 375910, XrefRangeEnd = 375959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scope;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_GetNamespacesInScope_Internal_IDictionary_2_String_String_XmlNamespaceScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, string>>(intPtr3) : null;
			}
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x000558F0 File Offset: 0x00053AF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 375969, RefRangeEnd = 375970, XrefRangeStart = 375960, XrefRangeEnd = 375969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReadAttributeValue(ref int level, ref bool bResolveEntity, ref XmlNodeType nt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &level;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bResolveEntity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &nt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_ReadAttributeValue_Public_Boolean_byref_Int32_byref_Boolean_byref_XmlNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06000E74 RID: 3700 RVA: 0x00055958 File Offset: 0x00053B58
		public unsafe XmlDocument Document
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.NativeMethodInfoPtr_get_Document_Public_get_XmlDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlDocument>(intPtr3) : null;
			}
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x00006B0E File Offset: 0x00004D0E
		public XmlNodeReaderNavigator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06000E76 RID: 3702 RVA: 0x00055998 File Offset: 0x00053B98
		// (set) Token: 0x06000E77 RID: 3703 RVA: 0x00006B17 File Offset: 0x00004D17
		public unsafe XmlNode curNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeReaderNavigator.NativeFieldInfoPtr_curNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeReaderNavigator.NativeFieldInfoPtr_curNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06000E78 RID: 3704 RVA: 0x000559C8 File Offset: 0x00053BC8
		// (set) Token: 0x06000E79 RID: 3705 RVA: 0x00006B36 File Offset: 0x00004D36
		public unsafe XmlNode elemNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeReaderNavigator.NativeFieldInfoPtr_elemNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeReaderNavigator.NativeFieldInfoPtr_elemNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06000E7A RID: 3706 RVA: 0x000559F8 File Offset: 0x00053BF8
		// (set) Token: 0x06000E7B RID: 3707 RVA: 0x00006B55 File Offset: 0x00004D55
		public unsafe XmlNode logNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeReaderNavigator.NativeFieldInfoPtr_logNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeReaderNavigator.NativeFieldInfoPtr_logNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06000E7C RID: 3708 RVA: 0x00055A28 File Offset: 0x00053C28
		// (set) Token: 0x06000E7D RID: 3709 RVA: 0x00006B74 File Offset: 0x00004D74
		public unsafe int attrIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeReaderNavigator.NativeFieldInfoPtr_attrIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeReaderNavigator.NativeFieldInfoPtr_attrIndex)) = value;
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06000E7E RID: 3710 RVA: 0x00055A50 File Offset: 0x00053C50
		// (set) Token: 0x06000E7F RID: 3711 RVA: 0x00006B8F File Offset: 0x00004D8F
		public unsafe int logAttrIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeReaderNavigator.NativeFieldInfoPtr_logAttrIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeReaderNavigator.NativeFieldInfoPtr_logAttrIndex)) = value;
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06000E80 RID: 3712 RVA: 0x00055A78 File Offset: 0x00053C78
		// (set) Token: 0x06000E81 RID: 3713 RVA: 0x00006BAA File Offset: 0x00004DAA
		public unsafe XmlNameTable nameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeReaderNavigator.NativeFieldInfoPtr_nameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeReaderNavigator.NativeFieldInfoPtr_nameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06000E82 RID: 3714 RVA: 0x00055AA8 File Offset: 0x00053CA8
		// (set) Token: 0x06000E83 RID: 3715 RVA: 0x00006BC9 File Offset: 0x00004DC9
		public unsafe XmlDocument doc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeReaderNavigator.NativeFieldInfoPtr_doc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlDocument>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeReaderNavigator.NativeFieldInfoPtr_doc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000E84 RID: 3716 RVA: 0x00055AD8 File Offset: 0x00053CD8
		// (set) Token: 0x06000E85 RID: 3717 RVA: 0x00006BE8 File Offset: 0x00004DE8
		public unsafe int nAttrInd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeReaderNavigator.NativeFieldInfoPtr_nAttrInd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeReaderNavigator.NativeFieldInfoPtr_nAttrInd)) = value;
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000E86 RID: 3718 RVA: 0x00055B00 File Offset: 0x00053D00
		// (set) Token: 0x06000E87 RID: 3719 RVA: 0x00006C03 File Offset: 0x00004E03
		public unsafe int nDeclarationAttrCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeReaderNavigator.NativeFieldInfoPtr_nDeclarationAttrCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeReaderNavigator.NativeFieldInfoPtr_nDeclarationAttrCount)) = value;
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000E88 RID: 3720 RVA: 0x00055B28 File Offset: 0x00053D28
		// (set) Token: 0x06000E89 RID: 3721 RVA: 0x00006C1E File Offset: 0x00004E1E
		public unsafe int nDocTypeAttrCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeReaderNavigator.NativeFieldInfoPtr_nDocTypeAttrCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeReaderNavigator.NativeFieldInfoPtr_nDocTypeAttrCount)) = value;
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000E8A RID: 3722 RVA: 0x00055B50 File Offset: 0x00053D50
		// (set) Token: 0x06000E8B RID: 3723 RVA: 0x00006C39 File Offset: 0x00004E39
		public unsafe int nLogLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeReaderNavigator.NativeFieldInfoPtr_nLogLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeReaderNavigator.NativeFieldInfoPtr_nLogLevel)) = value;
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000E8C RID: 3724 RVA: 0x00055B78 File Offset: 0x00053D78
		// (set) Token: 0x06000E8D RID: 3725 RVA: 0x00006C54 File Offset: 0x00004E54
		public unsafe int nLogAttrInd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeReaderNavigator.NativeFieldInfoPtr_nLogAttrInd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeReaderNavigator.NativeFieldInfoPtr_nLogAttrInd)) = value;
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000E8E RID: 3726 RVA: 0x00055BA0 File Offset: 0x00053DA0
		// (set) Token: 0x06000E8F RID: 3727 RVA: 0x00006C6F File Offset: 0x00004E6F
		public unsafe bool bLogOnAttrVal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeReaderNavigator.NativeFieldInfoPtr_bLogOnAttrVal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeReaderNavigator.NativeFieldInfoPtr_bLogOnAttrVal)) = value;
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000E90 RID: 3728 RVA: 0x00055BC8 File Offset: 0x00053DC8
		// (set) Token: 0x06000E91 RID: 3729 RVA: 0x00006C8A File Offset: 0x00004E8A
		public unsafe bool bCreatedOnAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeReaderNavigator.NativeFieldInfoPtr_bCreatedOnAttribute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeReaderNavigator.NativeFieldInfoPtr_bCreatedOnAttribute)) = value;
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000E92 RID: 3730 RVA: 0x00055BF0 File Offset: 0x00053DF0
		// (set) Token: 0x06000E93 RID: 3731 RVA: 0x00006CA5 File Offset: 0x00004EA5
		public unsafe Il2CppReferenceArray<XmlNodeReaderNavigator.VirtualAttribute> decNodeAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeReaderNavigator.NativeFieldInfoPtr_decNodeAttributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlNodeReaderNavigator.VirtualAttribute>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeReaderNavigator.NativeFieldInfoPtr_decNodeAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000E94 RID: 3732 RVA: 0x00055C20 File Offset: 0x00053E20
		// (set) Token: 0x06000E95 RID: 3733 RVA: 0x00006CC4 File Offset: 0x00004EC4
		public unsafe Il2CppReferenceArray<XmlNodeReaderNavigator.VirtualAttribute> docTypeNodeAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeReaderNavigator.NativeFieldInfoPtr_docTypeNodeAttributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlNodeReaderNavigator.VirtualAttribute>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeReaderNavigator.NativeFieldInfoPtr_docTypeNodeAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000E96 RID: 3734 RVA: 0x00055C50 File Offset: 0x00053E50
		// (set) Token: 0x06000E97 RID: 3735 RVA: 0x00006CE3 File Offset: 0x00004EE3
		public unsafe bool bOnAttrVal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeReaderNavigator.NativeFieldInfoPtr_bOnAttrVal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeReaderNavigator.NativeFieldInfoPtr_bOnAttrVal)) = value;
			}
		}

		// Token: 0x04000B9B RID: 2971
		private static readonly IntPtr NativeFieldInfoPtr_curNode;

		// Token: 0x04000B9C RID: 2972
		private static readonly IntPtr NativeFieldInfoPtr_elemNode;

		// Token: 0x04000B9D RID: 2973
		private static readonly IntPtr NativeFieldInfoPtr_logNode;

		// Token: 0x04000B9E RID: 2974
		private static readonly IntPtr NativeFieldInfoPtr_attrIndex;

		// Token: 0x04000B9F RID: 2975
		private static readonly IntPtr NativeFieldInfoPtr_logAttrIndex;

		// Token: 0x04000BA0 RID: 2976
		private static readonly IntPtr NativeFieldInfoPtr_nameTable;

		// Token: 0x04000BA1 RID: 2977
		private static readonly IntPtr NativeFieldInfoPtr_doc;

		// Token: 0x04000BA2 RID: 2978
		private static readonly IntPtr NativeFieldInfoPtr_nAttrInd;

		// Token: 0x04000BA3 RID: 2979
		private static readonly IntPtr NativeFieldInfoPtr_nDeclarationAttrCount;

		// Token: 0x04000BA4 RID: 2980
		private static readonly IntPtr NativeFieldInfoPtr_nDocTypeAttrCount;

		// Token: 0x04000BA5 RID: 2981
		private static readonly IntPtr NativeFieldInfoPtr_nLogLevel;

		// Token: 0x04000BA6 RID: 2982
		private static readonly IntPtr NativeFieldInfoPtr_nLogAttrInd;

		// Token: 0x04000BA7 RID: 2983
		private static readonly IntPtr NativeFieldInfoPtr_bLogOnAttrVal;

		// Token: 0x04000BA8 RID: 2984
		private static readonly IntPtr NativeFieldInfoPtr_bCreatedOnAttribute;

		// Token: 0x04000BA9 RID: 2985
		private static readonly IntPtr NativeFieldInfoPtr_decNodeAttributes;

		// Token: 0x04000BAA RID: 2986
		private static readonly IntPtr NativeFieldInfoPtr_docTypeNodeAttributes;

		// Token: 0x04000BAB RID: 2987
		private static readonly IntPtr NativeFieldInfoPtr_bOnAttrVal;

		// Token: 0x04000BAC RID: 2988
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNode_0;

		// Token: 0x04000BAD RID: 2989
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_get_XmlNodeType_0;

		// Token: 0x04000BAE RID: 2990
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceURI_Public_get_String_0;

		// Token: 0x04000BAF RID: 2991
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04000BB0 RID: 2992
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_get_String_0;

		// Token: 0x04000BB1 RID: 2993
		private static readonly IntPtr NativeMethodInfoPtr_get_CreatedOnAttribute_Internal_get_Boolean_0;

		// Token: 0x04000BB2 RID: 2994
		private static readonly IntPtr NativeMethodInfoPtr_IsLocalNameEmpty_Private_Boolean_XmlNodeType_0;

		// Token: 0x04000BB3 RID: 2995
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Public_get_String_0;

		// Token: 0x04000BB4 RID: 2996
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_String_0;

		// Token: 0x04000BB5 RID: 2997
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseURI_Public_get_String_0;

		// Token: 0x04000BB6 RID: 2998
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlSpace_Public_get_XmlSpace_0;

		// Token: 0x04000BB7 RID: 2999
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlLang_Public_get_String_0;

		// Token: 0x04000BB8 RID: 3000
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEmptyElement_Public_get_Boolean_0;

		// Token: 0x04000BB9 RID: 3001
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDefault_Public_get_Boolean_0;

		// Token: 0x04000BBA RID: 3002
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaInfo_Public_get_IXmlSchemaInfo_0;

		// Token: 0x04000BBB RID: 3003
		private static readonly IntPtr NativeMethodInfoPtr_get_NameTable_Public_get_XmlNameTable_0;

		// Token: 0x04000BBC RID: 3004
		private static readonly IntPtr NativeMethodInfoPtr_get_AttributeCount_Public_get_Int32_0;

		// Token: 0x04000BBD RID: 3005
		private static readonly IntPtr NativeMethodInfoPtr_CheckIndexCondition_Private_Void_Int32_0;

		// Token: 0x04000BBE RID: 3006
		private static readonly IntPtr NativeMethodInfoPtr_InitDecAttr_Private_Void_0;

		// Token: 0x04000BBF RID: 3007
		private static readonly IntPtr NativeMethodInfoPtr_GetDeclarationAttr_Public_String_XmlDeclaration_String_0;

		// Token: 0x04000BC0 RID: 3008
		private static readonly IntPtr NativeMethodInfoPtr_GetDeclarationAttr_Public_String_Int32_0;

		// Token: 0x04000BC1 RID: 3009
		private static readonly IntPtr NativeMethodInfoPtr_GetDecAttrInd_Public_Int32_String_0;

		// Token: 0x04000BC2 RID: 3010
		private static readonly IntPtr NativeMethodInfoPtr_InitDocTypeAttr_Private_Void_0;

		// Token: 0x04000BC3 RID: 3011
		private static readonly IntPtr NativeMethodInfoPtr_GetDocumentTypeAttr_Public_String_XmlDocumentType_String_0;

		// Token: 0x04000BC4 RID: 3012
		private static readonly IntPtr NativeMethodInfoPtr_GetDocumentTypeAttr_Public_String_Int32_0;

		// Token: 0x04000BC5 RID: 3013
		private static readonly IntPtr NativeMethodInfoPtr_GetDocTypeAttrInd_Public_Int32_String_0;

		// Token: 0x04000BC6 RID: 3014
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributeFromElement_Private_String_XmlElement_String_0;

		// Token: 0x04000BC7 RID: 3015
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_String_String_0;

		// Token: 0x04000BC8 RID: 3016
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributeFromElement_Private_String_XmlElement_String_String_0;

		// Token: 0x04000BC9 RID: 3017
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_String_String_String_0;

		// Token: 0x04000BCA RID: 3018
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_String_Int32_0;

		// Token: 0x04000BCB RID: 3019
		private static readonly IntPtr NativeMethodInfoPtr_LogMove_Public_Void_Int32_0;

		// Token: 0x04000BCC RID: 3020
		private static readonly IntPtr NativeMethodInfoPtr_RollBackMove_Public_Void_byref_Int32_0;

		// Token: 0x04000BCD RID: 3021
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOnDeclOrDocType_Private_get_Boolean_0;

		// Token: 0x04000BCE RID: 3022
		private static readonly IntPtr NativeMethodInfoPtr_ResetToAttribute_Public_Void_byref_Int32_0;

		// Token: 0x04000BCF RID: 3023
		private static readonly IntPtr NativeMethodInfoPtr_ResetMove_Public_Void_byref_Int32_byref_XmlNodeType_0;

		// Token: 0x04000BD0 RID: 3024
		private static readonly IntPtr NativeMethodInfoPtr_MoveToAttribute_Public_Boolean_String_0;

		// Token: 0x04000BD1 RID: 3025
		private static readonly IntPtr NativeMethodInfoPtr_MoveToAttributeFromElement_Private_Boolean_XmlElement_String_String_0;

		// Token: 0x04000BD2 RID: 3026
		private static readonly IntPtr NativeMethodInfoPtr_MoveToAttribute_Public_Boolean_String_String_0;

		// Token: 0x04000BD3 RID: 3027
		private static readonly IntPtr NativeMethodInfoPtr_MoveToAttribute_Public_Void_Int32_0;

		// Token: 0x04000BD4 RID: 3028
		private static readonly IntPtr NativeMethodInfoPtr_MoveToNextAttribute_Public_Boolean_byref_Int32_0;

		// Token: 0x04000BD5 RID: 3029
		private static readonly IntPtr NativeMethodInfoPtr_MoveToParent_Public_Boolean_0;

		// Token: 0x04000BD6 RID: 3030
		private static readonly IntPtr NativeMethodInfoPtr_MoveToFirstChild_Public_Boolean_0;

		// Token: 0x04000BD7 RID: 3031
		private static readonly IntPtr NativeMethodInfoPtr_MoveToNextSibling_Private_Boolean_XmlNode_0;

		// Token: 0x04000BD8 RID: 3032
		private static readonly IntPtr NativeMethodInfoPtr_MoveToNext_Public_Boolean_0;

		// Token: 0x04000BD9 RID: 3033
		private static readonly IntPtr NativeMethodInfoPtr_MoveToElement_Public_Boolean_0;

		// Token: 0x04000BDA RID: 3034
		private static readonly IntPtr NativeMethodInfoPtr_LookupNamespace_Public_String_String_0;

		// Token: 0x04000BDB RID: 3035
		private static readonly IntPtr NativeMethodInfoPtr_DefaultLookupNamespace_Internal_String_String_0;

		// Token: 0x04000BDC RID: 3036
		private static readonly IntPtr NativeMethodInfoPtr_LookupPrefix_Internal_String_String_0;

		// Token: 0x04000BDD RID: 3037
		private static readonly IntPtr NativeMethodInfoPtr_GetNamespacesInScope_Internal_IDictionary_2_String_String_XmlNamespaceScope_0;

		// Token: 0x04000BDE RID: 3038
		private static readonly IntPtr NativeMethodInfoPtr_ReadAttributeValue_Public_Boolean_byref_Int32_byref_Boolean_byref_XmlNodeType_0;

		// Token: 0x04000BDF RID: 3039
		private static readonly IntPtr NativeMethodInfoPtr_get_Document_Public_get_XmlDocument_0;

		// Token: 0x0200023D RID: 573
		public sealed class VirtualAttribute : ValueType
		{
			// Token: 0x06003069 RID: 12393 RVA: 0x000DA4C8 File Offset: 0x000D86C8
			// Note: this type is marked as 'beforefieldinit'.
			static VirtualAttribute()
			{
				Il2CppClassPointerStore<XmlNodeReaderNavigator.VirtualAttribute>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlNodeReaderNavigator>.NativeClassPtr, "VirtualAttribute");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlNodeReaderNavigator.VirtualAttribute>.NativeClassPtr);
				XmlNodeReaderNavigator.VirtualAttribute.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeReaderNavigator.VirtualAttribute>.NativeClassPtr, "name");
				XmlNodeReaderNavigator.VirtualAttribute.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNodeReaderNavigator.VirtualAttribute>.NativeClassPtr, "value");
				XmlNodeReaderNavigator.VirtualAttribute.NativeMethodInfoPtr__ctor_Internal_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNodeReaderNavigator.VirtualAttribute>.NativeClassPtr, 100665692);
			}

			// Token: 0x0600306A RID: 12394 RVA: 0x000DA530 File Offset: 0x000D8730
			[CallerCount(238)]
			[CachedScanResults(RefRangeStart = 342357, RefRangeEnd = 342595, XrefRangeStart = 342357, XrefRangeEnd = 342595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VirtualAttribute(string name, string value)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlNodeReaderNavigator.VirtualAttribute>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNodeReaderNavigator.VirtualAttribute.NativeMethodInfoPtr__ctor_Internal_Void_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600306B RID: 12395 RVA: 0x0001444F File Offset: 0x0001264F
			public VirtualAttribute(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600306C RID: 12396 RVA: 0x00014458 File Offset: 0x00012658
			public VirtualAttribute()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlNodeReaderNavigator.VirtualAttribute>.NativeClassPtr))
			{
			}

			// Token: 0x1700104A RID: 4170
			// (get) Token: 0x0600306D RID: 12397 RVA: 0x000DA594 File Offset: 0x000D8794
			// (set) Token: 0x0600306E RID: 12398 RVA: 0x0001446A File Offset: 0x0001266A
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeReaderNavigator.VirtualAttribute.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeReaderNavigator.VirtualAttribute.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700104B RID: 4171
			// (get) Token: 0x0600306F RID: 12399 RVA: 0x000DA5BC File Offset: 0x000D87BC
			// (set) Token: 0x06003070 RID: 12400 RVA: 0x00014489 File Offset: 0x00012689
			public unsafe string value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeReaderNavigator.VirtualAttribute.NativeFieldInfoPtr_value);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNodeReaderNavigator.VirtualAttribute.NativeFieldInfoPtr_value), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400255C RID: 9564
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x0400255D RID: 9565
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x0400255E RID: 9566
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_0;
		}
	}
}
