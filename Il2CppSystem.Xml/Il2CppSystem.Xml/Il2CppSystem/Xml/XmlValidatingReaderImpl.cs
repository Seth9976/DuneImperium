using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000051 RID: 81
	public sealed class XmlValidatingReaderImpl : XmlReader
	{
		// Token: 0x06000915 RID: 2325 RVA: 0x0003DB1C File Offset: 0x0003BD1C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlValidatingReaderImpl()
		{
			Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlValidatingReaderImpl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr);
			XmlValidatingReaderImpl.NativeFieldInfoPtr_coreReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, "coreReader");
			XmlValidatingReaderImpl.NativeFieldInfoPtr_coreReaderImpl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, "coreReaderImpl");
			XmlValidatingReaderImpl.NativeFieldInfoPtr_coreReaderNSResolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, "coreReaderNSResolver");
			XmlValidatingReaderImpl.NativeFieldInfoPtr_validationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, "validationType");
			XmlValidatingReaderImpl.NativeFieldInfoPtr_validator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, "validator");
			XmlValidatingReaderImpl.NativeFieldInfoPtr_schemaCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, "schemaCollection");
			XmlValidatingReaderImpl.NativeFieldInfoPtr_processIdentityConstraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, "processIdentityConstraints");
			XmlValidatingReaderImpl.NativeFieldInfoPtr_parsingFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, "parsingFunction");
			XmlValidatingReaderImpl.NativeFieldInfoPtr_eventHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, "eventHandling");
			XmlValidatingReaderImpl.NativeFieldInfoPtr_parserContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, "parserContext");
			XmlValidatingReaderImpl.NativeFieldInfoPtr_readBinaryHelper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, "readBinaryHelper");
			XmlValidatingReaderImpl.NativeFieldInfoPtr_outerReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, "outerReader");
			XmlValidatingReaderImpl.NativeFieldInfoPtr_s_tempResolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, "s_tempResolver");
			XmlValidatingReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_XmlReader_ValidationEventHandler_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664805);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_get_Settings_Public_Virtual_get_XmlReaderSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664806);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664807);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664808);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664809);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664810);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_get_Prefix_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664811);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664812);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_get_Depth_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664813);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_get_BaseURI_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664814);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_get_IsEmptyElement_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664815);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_get_IsDefault_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664816);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_get_QuoteChar_Public_Virtual_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664817);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_get_XmlSpace_Public_Virtual_get_XmlSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664818);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_get_XmlLang_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664819);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_get_ReadState_Public_Virtual_get_ReadState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664820);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_get_EOF_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664821);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_get_NameTable_Public_Virtual_get_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664822);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_get_AttributeCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664823);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664824);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664825);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664826);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664827);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664828);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_MoveToFirstAttribute_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664829);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_MoveToNextAttribute_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664830);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_MoveToElement_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664831);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_Read_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664832);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664833);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664834);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_ReadAttributeValue_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664835);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_get_CanResolveEntity_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664836);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_ResolveEntity_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664837);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_MoveOffEntityReference_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664838);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_ReadString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664839);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_HasLineInfo_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664840);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_get_LineNumber_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664841);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_get_LinePosition_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664842);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_GetNamespacesInScope_Private_Virtual_Final_New_IDictionary_2_String_String_XmlNamespaceScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664843);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupNamespace_Private_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664844);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupPrefix_Private_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664845);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_GetNamespacesInScope_Internal_IDictionary_2_String_String_XmlNamespaceScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664846);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_LookupPrefix_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664847);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_get_ValidationType_Internal_get_ValidationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664848);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_get_Schemas_Internal_get_XmlSchemaCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664849);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_get_Namespaces_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664850);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_ParseDtdFromParserContext_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664851);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_ValidateDtd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664852);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_ResolveEntityInternally_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664853);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_SetupValidation_Private_Void_ValidationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664854);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_GetResolver_Private_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664855);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_ProcessCoreReaderEvent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664856);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_get_Validator_Internal_get_BaseValidator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664857);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_set_Validator_Internal_set_Void_BaseValidator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664858);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_get_NamespaceManager_Internal_Virtual_get_XmlNamespaceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664859);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_get_StandAlone_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664860);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_set_SchemaTypeObject_Internal_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664861);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_get_TypedValueObject_Internal_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664862);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_set_TypedValueObject_Internal_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664863);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_AddDefaultAttribute_Internal_Boolean_SchemaAttDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664864);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_get_DtdInfo_Internal_Virtual_get_IDtdInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664865);
			XmlValidatingReaderImpl.NativeMethodInfoPtr_ValidateDefaultAttributeOnUse_Internal_Void_IDtdDefaultAttributeInfo_XmlTextReaderImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, 100664866);
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x0003E128 File Offset: 0x0003C328
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 371457, RefRangeEnd = 371459, XrefRangeStart = 371379, XrefRangeEnd = 371457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlValidatingReaderImpl(XmlReader reader, ValidationEventHandler settingsEventHandler, bool processIdentityConstraints)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settingsEventHandler);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref processIdentityConstraints;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_XmlReader_ValidationEventHandler_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000917 RID: 2327 RVA: 0x0003E194 File Offset: 0x0003C394
		public unsafe override XmlReaderSettings Settings
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371459, XrefRangeEnd = 371467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_get_Settings_Public_Virtual_get_XmlReaderSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlReaderSettings>(intPtr3) : null;
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000918 RID: 2328 RVA: 0x0003E1D4 File Offset: 0x0003C3D4
		public unsafe override XmlNodeType NodeType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000919 RID: 2329 RVA: 0x0003E210 File Offset: 0x0003C410
		public unsafe override string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x0600091A RID: 2330 RVA: 0x0003E248 File Offset: 0x0003C448
		public unsafe override string LocalName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x0600091B RID: 2331 RVA: 0x0003E280 File Offset: 0x0003C480
		public unsafe override string NamespaceURI
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 367110, RefRangeEnd = 367113, XrefRangeStart = 367110, XrefRangeEnd = 367113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x0600091C RID: 2332 RVA: 0x0003E2B8 File Offset: 0x0003C4B8
		public unsafe override string Prefix
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_get_Prefix_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x0600091D RID: 2333 RVA: 0x0003E2F0 File Offset: 0x0003C4F0
		public unsafe override string Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x0600091E RID: 2334 RVA: 0x0003E328 File Offset: 0x0003C528
		public unsafe override int Depth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_get_Depth_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x0600091F RID: 2335 RVA: 0x0003E364 File Offset: 0x0003C564
		public unsafe override string BaseURI
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_get_BaseURI_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000920 RID: 2336 RVA: 0x0003E39C File Offset: 0x0003C59C
		public unsafe override bool IsEmptyElement
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_get_IsEmptyElement_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000921 RID: 2337 RVA: 0x0003E3D8 File Offset: 0x0003C5D8
		public unsafe override bool IsDefault
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_get_IsDefault_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000922 RID: 2338 RVA: 0x0003E414 File Offset: 0x0003C614
		public unsafe override char QuoteChar
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_get_QuoteChar_Public_Virtual_get_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000923 RID: 2339 RVA: 0x0003E450 File Offset: 0x0003C650
		public unsafe override XmlSpace XmlSpace
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_get_XmlSpace_Public_Virtual_get_XmlSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000924 RID: 2340 RVA: 0x0003E48C File Offset: 0x0003C68C
		public unsafe override string XmlLang
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_get_XmlLang_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000925 RID: 2341 RVA: 0x0003E4C4 File Offset: 0x0003C6C4
		public unsafe override ReadState ReadState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_get_ReadState_Public_Virtual_get_ReadState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000926 RID: 2342 RVA: 0x0003E500 File Offset: 0x0003C700
		public unsafe override bool EOF
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_get_EOF_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000927 RID: 2343 RVA: 0x0003E53C File Offset: 0x0003C73C
		public unsafe override XmlNameTable NameTable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_get_NameTable_Public_Virtual_get_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr3) : null;
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000928 RID: 2344 RVA: 0x0003E57C File Offset: 0x0003C77C
		public unsafe override int AttributeCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_get_AttributeCount_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x0003E5B8 File Offset: 0x0003C7B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetAttribute(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x0003E600 File Offset: 0x0003C800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetAttribute(string localName, string namespaceURI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceURI);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x0003E65C File Offset: 0x0003C85C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetAttribute(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x0003E6A0 File Offset: 0x0003C8A0
		[CallerCount(0)]
		public unsafe override bool MoveToAttribute(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x0003E6F0 File Offset: 0x0003C8F0
		[CallerCount(0)]
		public unsafe override void MoveToAttribute(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x0003E730 File Offset: 0x0003C930
		[CallerCount(0)]
		public unsafe override bool MoveToFirstAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_MoveToFirstAttribute_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x0003E76C File Offset: 0x0003C96C
		[CallerCount(0)]
		public unsafe override bool MoveToNextAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_MoveToNextAttribute_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x0003E7A8 File Offset: 0x0003C9A8
		[CallerCount(0)]
		public unsafe override bool MoveToElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_MoveToElement_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x0003E7E4 File Offset: 0x0003C9E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371467, XrefRangeEnd = 371483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Read()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_Read_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x0003E820 File Offset: 0x0003CA20
		[CallerCount(0)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_Close_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x0003E854 File Offset: 0x0003CA54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371483, XrefRangeEnd = 371484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string LookupNamespace(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x0003E89C File Offset: 0x0003CA9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371484, XrefRangeEnd = 371485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadAttributeValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_ReadAttributeValue_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000935 RID: 2357 RVA: 0x0003E8D8 File Offset: 0x0003CAD8
		public unsafe override bool CanResolveEntity
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_get_CanResolveEntity_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x0003E914 File Offset: 0x0003CB14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371485, XrefRangeEnd = 371486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ResolveEntity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_ResolveEntity_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x0003E948 File Offset: 0x0003CB48
		[CallerCount(0)]
		public unsafe void MoveOffEntityReference()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_MoveOffEntityReference_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x0003E97C File Offset: 0x0003CB7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371486, XrefRangeEnd = 371495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ReadString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_ReadString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x0003E9B4 File Offset: 0x0003CBB4
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasLineInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_HasLineInfo_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x0600093A RID: 2362 RVA: 0x0003E9F0 File Offset: 0x0003CBF0
		public unsafe int LineNumber
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371495, XrefRangeEnd = 371505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_get_LineNumber_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x0600093B RID: 2363 RVA: 0x0003EA2C File Offset: 0x0003CC2C
		public unsafe int LinePosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371505, XrefRangeEnd = 371515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_get_LinePosition_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x0003EA68 File Offset: 0x0003CC68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371515, XrefRangeEnd = 371520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IDictionary<string, string> System_Xml_IXmlNamespaceResolver_GetNamespacesInScope(XmlNamespaceScope scope)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scope;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_GetNamespacesInScope_Private_Virtual_Final_New_IDictionary_2_String_String_XmlNamespaceScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, string>>(intPtr3) : null;
			}
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x0003EAB4 File Offset: 0x0003CCB4
		[CallerCount(0)]
		public unsafe string System_Xml_IXmlNamespaceResolver_LookupNamespace(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupNamespace_Private_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x0003EAFC File Offset: 0x0003CCFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371520, XrefRangeEnd = 371524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string System_Xml_IXmlNamespaceResolver_LookupPrefix(string namespaceName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(namespaceName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupPrefix_Private_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x0003EB44 File Offset: 0x0003CD44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scope;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_GetNamespacesInScope_Internal_IDictionary_2_String_String_XmlNamespaceScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, string>>(intPtr3) : null;
			}
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x0003EB90 File Offset: 0x0003CD90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string LookupPrefix(string namespaceName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(namespaceName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_LookupPrefix_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x0003EBD8 File Offset: 0x0003CDD8
		public unsafe ValidationType ValidationType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_get_ValidationType_Internal_get_ValidationType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000942 RID: 2370 RVA: 0x0003EC14 File Offset: 0x0003CE14
		public unsafe XmlSchemaCollection Schemas
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_get_Schemas_Internal_get_XmlSchemaCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaCollection>(intPtr3) : null;
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000943 RID: 2371 RVA: 0x0003EC54 File Offset: 0x0003CE54
		public unsafe bool Namespaces
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_get_Namespaces_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x0003EC90 File Offset: 0x0003CE90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371524, XrefRangeEnd = 371534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseDtdFromParserContext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_ParseDtdFromParserContext_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x0003ECC4 File Offset: 0x0003CEC4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 371534, RefRangeEnd = 371537, XrefRangeStart = 371534, XrefRangeEnd = 371534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateDtd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_ValidateDtd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x0003ECF8 File Offset: 0x0003CEF8
		[CallerCount(0)]
		public unsafe void ResolveEntityInternally()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_ResolveEntityInternally_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x0003ED2C File Offset: 0x0003CF2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371549, RefRangeEnd = 371550, XrefRangeStart = 371537, XrefRangeEnd = 371549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupValidation(ValidationType valType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref valType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_SetupValidation_Private_Void_ValidationType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x0003ED6C File Offset: 0x0003CF6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 371562, RefRangeEnd = 371564, XrefRangeStart = 371550, XrefRangeEnd = 371562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlResolver GetResolver()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_GetResolver_Private_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr3) : null;
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x0003EDAC File Offset: 0x0003CFAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 371570, RefRangeEnd = 371571, XrefRangeStart = 371564, XrefRangeEnd = 371570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessCoreReaderEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_ProcessCoreReaderEvent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x0600094A RID: 2378 RVA: 0x0003EDE0 File Offset: 0x0003CFE0
		// (set) Token: 0x0600094B RID: 2379 RVA: 0x0003EE20 File Offset: 0x0003D020
		public unsafe BaseValidator Validator
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_get_Validator_Internal_get_BaseValidator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseValidator>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_set_Validator_Internal_set_Void_BaseValidator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x0600094C RID: 2380 RVA: 0x0003EE64 File Offset: 0x0003D064
		public unsafe override XmlNamespaceManager NamespaceManager
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371571, XrefRangeEnd = 371572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_get_NamespaceManager_Internal_Virtual_get_XmlNamespaceManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNamespaceManager>(intPtr3) : null;
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x0600094D RID: 2381 RVA: 0x0003EEA4 File Offset: 0x0003D0A4
		public unsafe bool StandAlone
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 371572, RefRangeEnd = 371577, XrefRangeStart = 371572, XrefRangeEnd = 371572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_get_StandAlone_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002DF RID: 735
		// (set) Token: 0x0600094E RID: 2382 RVA: 0x0003EEE0 File Offset: 0x0003D0E0
		public unsafe Object SchemaTypeObject
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 371579, RefRangeEnd = 371590, XrefRangeStart = 371577, XrefRangeEnd = 371579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_set_SchemaTypeObject_Internal_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x0600094F RID: 2383 RVA: 0x0003EF24 File Offset: 0x0003D124
		// (set) Token: 0x06000950 RID: 2384 RVA: 0x0003EF64 File Offset: 0x0003D164
		public unsafe Object TypedValueObject
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 371592, RefRangeEnd = 371595, XrefRangeStart = 371590, XrefRangeEnd = 371592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_get_TypedValueObject_Internal_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 371597, RefRangeEnd = 371607, XrefRangeStart = 371595, XrefRangeEnd = 371597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_set_TypedValueObject_Internal_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x0003EFA8 File Offset: 0x0003D1A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 371609, RefRangeEnd = 371611, XrefRangeStart = 371607, XrefRangeEnd = 371609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddDefaultAttribute(SchemaAttDef attdef)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attdef);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_AddDefaultAttribute_Internal_Boolean_SchemaAttDef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000952 RID: 2386 RVA: 0x0003EFF8 File Offset: 0x0003D1F8
		public unsafe override IDtdInfo DtdInfo
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371611, XrefRangeEnd = 371612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_get_DtdInfo_Internal_Virtual_get_IDtdInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDtdInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x0003F038 File Offset: 0x0003D238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371612, XrefRangeEnd = 371621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateDefaultAttributeOnUse(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(defaultAttribute);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coreReader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.NativeMethodInfoPtr_ValidateDefaultAttributeOnUse_Internal_Void_IDtdDefaultAttributeInfo_XmlTextReaderImpl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x00004EF8 File Offset: 0x000030F8
		public XmlValidatingReaderImpl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000955 RID: 2389 RVA: 0x0003F08C File Offset: 0x0003D28C
		// (set) Token: 0x06000956 RID: 2390 RVA: 0x00004F01 File Offset: 0x00003101
		public unsafe XmlReader coreReader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlValidatingReaderImpl.NativeFieldInfoPtr_coreReader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlValidatingReaderImpl.NativeFieldInfoPtr_coreReader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000957 RID: 2391 RVA: 0x0003F0BC File Offset: 0x0003D2BC
		// (set) Token: 0x06000958 RID: 2392 RVA: 0x00004F20 File Offset: 0x00003120
		public unsafe XmlTextReaderImpl coreReaderImpl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlValidatingReaderImpl.NativeFieldInfoPtr_coreReaderImpl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlValidatingReaderImpl.NativeFieldInfoPtr_coreReaderImpl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000959 RID: 2393 RVA: 0x0003F0EC File Offset: 0x0003D2EC
		// (set) Token: 0x0600095A RID: 2394 RVA: 0x00004F3F File Offset: 0x0000313F
		public unsafe IXmlNamespaceResolver coreReaderNSResolver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlValidatingReaderImpl.NativeFieldInfoPtr_coreReaderNSResolver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IXmlNamespaceResolver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlValidatingReaderImpl.NativeFieldInfoPtr_coreReaderNSResolver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x0600095B RID: 2395 RVA: 0x0003F11C File Offset: 0x0003D31C
		// (set) Token: 0x0600095C RID: 2396 RVA: 0x00004F5E File Offset: 0x0000315E
		public unsafe ValidationType validationType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlValidatingReaderImpl.NativeFieldInfoPtr_validationType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlValidatingReaderImpl.NativeFieldInfoPtr_validationType)) = value;
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x0600095D RID: 2397 RVA: 0x0003F144 File Offset: 0x0003D344
		// (set) Token: 0x0600095E RID: 2398 RVA: 0x00004F79 File Offset: 0x00003179
		public unsafe BaseValidator validator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlValidatingReaderImpl.NativeFieldInfoPtr_validator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseValidator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlValidatingReaderImpl.NativeFieldInfoPtr_validator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x0600095F RID: 2399 RVA: 0x0003F174 File Offset: 0x0003D374
		// (set) Token: 0x06000960 RID: 2400 RVA: 0x00004F98 File Offset: 0x00003198
		public unsafe XmlSchemaCollection schemaCollection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlValidatingReaderImpl.NativeFieldInfoPtr_schemaCollection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlValidatingReaderImpl.NativeFieldInfoPtr_schemaCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000961 RID: 2401 RVA: 0x0003F1A4 File Offset: 0x0003D3A4
		// (set) Token: 0x06000962 RID: 2402 RVA: 0x00004FB7 File Offset: 0x000031B7
		public unsafe bool processIdentityConstraints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlValidatingReaderImpl.NativeFieldInfoPtr_processIdentityConstraints);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlValidatingReaderImpl.NativeFieldInfoPtr_processIdentityConstraints)) = value;
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000963 RID: 2403 RVA: 0x0003F1CC File Offset: 0x0003D3CC
		// (set) Token: 0x06000964 RID: 2404 RVA: 0x00004FD2 File Offset: 0x000031D2
		public unsafe XmlValidatingReaderImpl.ParsingFunction parsingFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlValidatingReaderImpl.NativeFieldInfoPtr_parsingFunction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlValidatingReaderImpl.NativeFieldInfoPtr_parsingFunction)) = value;
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000965 RID: 2405 RVA: 0x0003F1F4 File Offset: 0x0003D3F4
		// (set) Token: 0x06000966 RID: 2406 RVA: 0x00004FED File Offset: 0x000031ED
		public unsafe XmlValidatingReaderImpl.ValidationEventHandling eventHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlValidatingReaderImpl.NativeFieldInfoPtr_eventHandling);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlValidatingReaderImpl.ValidationEventHandling>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlValidatingReaderImpl.NativeFieldInfoPtr_eventHandling), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000967 RID: 2407 RVA: 0x0003F224 File Offset: 0x0003D424
		// (set) Token: 0x06000968 RID: 2408 RVA: 0x0000500C File Offset: 0x0000320C
		public unsafe XmlParserContext parserContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlValidatingReaderImpl.NativeFieldInfoPtr_parserContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlParserContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlValidatingReaderImpl.NativeFieldInfoPtr_parserContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000969 RID: 2409 RVA: 0x0003F254 File Offset: 0x0003D454
		// (set) Token: 0x0600096A RID: 2410 RVA: 0x0000502B File Offset: 0x0000322B
		public unsafe ReadContentAsBinaryHelper readBinaryHelper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlValidatingReaderImpl.NativeFieldInfoPtr_readBinaryHelper);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadContentAsBinaryHelper>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlValidatingReaderImpl.NativeFieldInfoPtr_readBinaryHelper), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x0600096B RID: 2411 RVA: 0x0003F284 File Offset: 0x0003D484
		// (set) Token: 0x0600096C RID: 2412 RVA: 0x0000504A File Offset: 0x0000324A
		public unsafe XmlReader outerReader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlValidatingReaderImpl.NativeFieldInfoPtr_outerReader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlValidatingReaderImpl.NativeFieldInfoPtr_outerReader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x0600096D RID: 2413 RVA: 0x0003F2B4 File Offset: 0x0003D4B4
		// (set) Token: 0x0600096E RID: 2414 RVA: 0x00005069 File Offset: 0x00003269
		public unsafe static XmlResolver s_tempResolver
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlValidatingReaderImpl.NativeFieldInfoPtr_s_tempResolver, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlValidatingReaderImpl.NativeFieldInfoPtr_s_tempResolver, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000786 RID: 1926
		private static readonly IntPtr NativeFieldInfoPtr_coreReader;

		// Token: 0x04000787 RID: 1927
		private static readonly IntPtr NativeFieldInfoPtr_coreReaderImpl;

		// Token: 0x04000788 RID: 1928
		private static readonly IntPtr NativeFieldInfoPtr_coreReaderNSResolver;

		// Token: 0x04000789 RID: 1929
		private static readonly IntPtr NativeFieldInfoPtr_validationType;

		// Token: 0x0400078A RID: 1930
		private static readonly IntPtr NativeFieldInfoPtr_validator;

		// Token: 0x0400078B RID: 1931
		private static readonly IntPtr NativeFieldInfoPtr_schemaCollection;

		// Token: 0x0400078C RID: 1932
		private static readonly IntPtr NativeFieldInfoPtr_processIdentityConstraints;

		// Token: 0x0400078D RID: 1933
		private static readonly IntPtr NativeFieldInfoPtr_parsingFunction;

		// Token: 0x0400078E RID: 1934
		private static readonly IntPtr NativeFieldInfoPtr_eventHandling;

		// Token: 0x0400078F RID: 1935
		private static readonly IntPtr NativeFieldInfoPtr_parserContext;

		// Token: 0x04000790 RID: 1936
		private static readonly IntPtr NativeFieldInfoPtr_readBinaryHelper;

		// Token: 0x04000791 RID: 1937
		private static readonly IntPtr NativeFieldInfoPtr_outerReader;

		// Token: 0x04000792 RID: 1938
		private static readonly IntPtr NativeFieldInfoPtr_s_tempResolver;

		// Token: 0x04000793 RID: 1939
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlReader_ValidationEventHandler_Boolean_0;

		// Token: 0x04000794 RID: 1940
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings_Public_Virtual_get_XmlReaderSettings_0;

		// Token: 0x04000795 RID: 1941
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0;

		// Token: 0x04000796 RID: 1942
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x04000797 RID: 1943
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0;

		// Token: 0x04000798 RID: 1944
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_get_String_0;

		// Token: 0x04000799 RID: 1945
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Public_Virtual_get_String_0;

		// Token: 0x0400079A RID: 1946
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0;

		// Token: 0x0400079B RID: 1947
		private static readonly IntPtr NativeMethodInfoPtr_get_Depth_Public_Virtual_get_Int32_0;

		// Token: 0x0400079C RID: 1948
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseURI_Public_Virtual_get_String_0;

		// Token: 0x0400079D RID: 1949
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEmptyElement_Public_Virtual_get_Boolean_0;

		// Token: 0x0400079E RID: 1950
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDefault_Public_Virtual_get_Boolean_0;

		// Token: 0x0400079F RID: 1951
		private static readonly IntPtr NativeMethodInfoPtr_get_QuoteChar_Public_Virtual_get_Char_0;

		// Token: 0x040007A0 RID: 1952
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlSpace_Public_Virtual_get_XmlSpace_0;

		// Token: 0x040007A1 RID: 1953
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlLang_Public_Virtual_get_String_0;

		// Token: 0x040007A2 RID: 1954
		private static readonly IntPtr NativeMethodInfoPtr_get_ReadState_Public_Virtual_get_ReadState_0;

		// Token: 0x040007A3 RID: 1955
		private static readonly IntPtr NativeMethodInfoPtr_get_EOF_Public_Virtual_get_Boolean_0;

		// Token: 0x040007A4 RID: 1956
		private static readonly IntPtr NativeMethodInfoPtr_get_NameTable_Public_Virtual_get_XmlNameTable_0;

		// Token: 0x040007A5 RID: 1957
		private static readonly IntPtr NativeMethodInfoPtr_get_AttributeCount_Public_Virtual_get_Int32_0;

		// Token: 0x040007A6 RID: 1958
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_String_0;

		// Token: 0x040007A7 RID: 1959
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_String_String_0;

		// Token: 0x040007A8 RID: 1960
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_Int32_0;

		// Token: 0x040007A9 RID: 1961
		private static readonly IntPtr NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Boolean_String_0;

		// Token: 0x040007AA RID: 1962
		private static readonly IntPtr NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Void_Int32_0;

		// Token: 0x040007AB RID: 1963
		private static readonly IntPtr NativeMethodInfoPtr_MoveToFirstAttribute_Public_Virtual_Boolean_0;

		// Token: 0x040007AC RID: 1964
		private static readonly IntPtr NativeMethodInfoPtr_MoveToNextAttribute_Public_Virtual_Boolean_0;

		// Token: 0x040007AD RID: 1965
		private static readonly IntPtr NativeMethodInfoPtr_MoveToElement_Public_Virtual_Boolean_0;

		// Token: 0x040007AE RID: 1966
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Boolean_0;

		// Token: 0x040007AF RID: 1967
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x040007B0 RID: 1968
		private static readonly IntPtr NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0;

		// Token: 0x040007B1 RID: 1969
		private static readonly IntPtr NativeMethodInfoPtr_ReadAttributeValue_Public_Virtual_Boolean_0;

		// Token: 0x040007B2 RID: 1970
		private static readonly IntPtr NativeMethodInfoPtr_get_CanResolveEntity_Public_Virtual_get_Boolean_0;

		// Token: 0x040007B3 RID: 1971
		private static readonly IntPtr NativeMethodInfoPtr_ResolveEntity_Public_Virtual_Void_0;

		// Token: 0x040007B4 RID: 1972
		private static readonly IntPtr NativeMethodInfoPtr_MoveOffEntityReference_Internal_Void_0;

		// Token: 0x040007B5 RID: 1973
		private static readonly IntPtr NativeMethodInfoPtr_ReadString_Public_Virtual_String_0;

		// Token: 0x040007B6 RID: 1974
		private static readonly IntPtr NativeMethodInfoPtr_HasLineInfo_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x040007B7 RID: 1975
		private static readonly IntPtr NativeMethodInfoPtr_get_LineNumber_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040007B8 RID: 1976
		private static readonly IntPtr NativeMethodInfoPtr_get_LinePosition_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040007B9 RID: 1977
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_GetNamespacesInScope_Private_Virtual_Final_New_IDictionary_2_String_String_XmlNamespaceScope_0;

		// Token: 0x040007BA RID: 1978
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupNamespace_Private_Virtual_Final_New_String_String_0;

		// Token: 0x040007BB RID: 1979
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupPrefix_Private_Virtual_Final_New_String_String_0;

		// Token: 0x040007BC RID: 1980
		private static readonly IntPtr NativeMethodInfoPtr_GetNamespacesInScope_Internal_IDictionary_2_String_String_XmlNamespaceScope_0;

		// Token: 0x040007BD RID: 1981
		private static readonly IntPtr NativeMethodInfoPtr_LookupPrefix_Internal_String_String_0;

		// Token: 0x040007BE RID: 1982
		private static readonly IntPtr NativeMethodInfoPtr_get_ValidationType_Internal_get_ValidationType_0;

		// Token: 0x040007BF RID: 1983
		private static readonly IntPtr NativeMethodInfoPtr_get_Schemas_Internal_get_XmlSchemaCollection_0;

		// Token: 0x040007C0 RID: 1984
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespaces_Internal_get_Boolean_0;

		// Token: 0x040007C1 RID: 1985
		private static readonly IntPtr NativeMethodInfoPtr_ParseDtdFromParserContext_Private_Void_0;

		// Token: 0x040007C2 RID: 1986
		private static readonly IntPtr NativeMethodInfoPtr_ValidateDtd_Private_Void_0;

		// Token: 0x040007C3 RID: 1987
		private static readonly IntPtr NativeMethodInfoPtr_ResolveEntityInternally_Private_Void_0;

		// Token: 0x040007C4 RID: 1988
		private static readonly IntPtr NativeMethodInfoPtr_SetupValidation_Private_Void_ValidationType_0;

		// Token: 0x040007C5 RID: 1989
		private static readonly IntPtr NativeMethodInfoPtr_GetResolver_Private_XmlResolver_0;

		// Token: 0x040007C6 RID: 1990
		private static readonly IntPtr NativeMethodInfoPtr_ProcessCoreReaderEvent_Private_Void_0;

		// Token: 0x040007C7 RID: 1991
		private static readonly IntPtr NativeMethodInfoPtr_get_Validator_Internal_get_BaseValidator_0;

		// Token: 0x040007C8 RID: 1992
		private static readonly IntPtr NativeMethodInfoPtr_set_Validator_Internal_set_Void_BaseValidator_0;

		// Token: 0x040007C9 RID: 1993
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceManager_Internal_Virtual_get_XmlNamespaceManager_0;

		// Token: 0x040007CA RID: 1994
		private static readonly IntPtr NativeMethodInfoPtr_get_StandAlone_Internal_get_Boolean_0;

		// Token: 0x040007CB RID: 1995
		private static readonly IntPtr NativeMethodInfoPtr_set_SchemaTypeObject_Internal_set_Void_Object_0;

		// Token: 0x040007CC RID: 1996
		private static readonly IntPtr NativeMethodInfoPtr_get_TypedValueObject_Internal_get_Object_0;

		// Token: 0x040007CD RID: 1997
		private static readonly IntPtr NativeMethodInfoPtr_set_TypedValueObject_Internal_set_Void_Object_0;

		// Token: 0x040007CE RID: 1998
		private static readonly IntPtr NativeMethodInfoPtr_AddDefaultAttribute_Internal_Boolean_SchemaAttDef_0;

		// Token: 0x040007CF RID: 1999
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdInfo_Internal_Virtual_get_IDtdInfo_0;

		// Token: 0x040007D0 RID: 2000
		private static readonly IntPtr NativeMethodInfoPtr_ValidateDefaultAttributeOnUse_Internal_Void_IDtdDefaultAttributeInfo_XmlTextReaderImpl_0;

		// Token: 0x0200022F RID: 559
		public enum ParsingFunction
		{
			// Token: 0x040024C6 RID: 9414
			Read,
			// Token: 0x040024C7 RID: 9415
			Init,
			// Token: 0x040024C8 RID: 9416
			ParseDtdFromContext,
			// Token: 0x040024C9 RID: 9417
			ResolveEntityInternally,
			// Token: 0x040024CA RID: 9418
			InReadBinaryContent,
			// Token: 0x040024CB RID: 9419
			ReaderClosed,
			// Token: 0x040024CC RID: 9420
			Error,
			// Token: 0x040024CD RID: 9421
			None
		}

		// Token: 0x02000230 RID: 560
		public class ValidationEventHandling : Object
		{
			// Token: 0x06003004 RID: 12292 RVA: 0x000D901C File Offset: 0x000D721C
			// Note: this type is marked as 'beforefieldinit'.
			static ValidationEventHandling()
			{
				Il2CppClassPointerStore<XmlValidatingReaderImpl.ValidationEventHandling>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlValidatingReaderImpl>.NativeClassPtr, "ValidationEventHandling");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlValidatingReaderImpl.ValidationEventHandling>.NativeClassPtr);
				XmlValidatingReaderImpl.ValidationEventHandling.NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlValidatingReaderImpl.ValidationEventHandling>.NativeClassPtr, "reader");
				XmlValidatingReaderImpl.ValidationEventHandling.NativeFieldInfoPtr_eventHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlValidatingReaderImpl.ValidationEventHandling>.NativeClassPtr, "eventHandler");
				XmlValidatingReaderImpl.ValidationEventHandling.NativeMethodInfoPtr__ctor_Internal_Void_XmlValidatingReaderImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl.ValidationEventHandling>.NativeClassPtr, 100664867);
				XmlValidatingReaderImpl.ValidationEventHandling.NativeMethodInfoPtr_System_Xml_IValidationEventHandling_get_EventHandler_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl.ValidationEventHandling>.NativeClassPtr, 100664868);
				XmlValidatingReaderImpl.ValidationEventHandling.NativeMethodInfoPtr_System_Xml_IValidationEventHandling_SendEvent_Private_Virtual_Final_New_Void_Exception_XmlSeverityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl.ValidationEventHandling>.NativeClassPtr, 100664869);
				XmlValidatingReaderImpl.ValidationEventHandling.NativeMethodInfoPtr_AddHandler_Internal_Void_ValidationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlValidatingReaderImpl.ValidationEventHandling>.NativeClassPtr, 100664870);
			}

			// Token: 0x06003005 RID: 12293 RVA: 0x000D90C0 File Offset: 0x000D72C0
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValidationEventHandling(XmlValidatingReaderImpl reader)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlValidatingReaderImpl.ValidationEventHandling>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.ValidationEventHandling.NativeMethodInfoPtr__ctor_Internal_Void_XmlValidatingReaderImpl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17001031 RID: 4145
			// (get) Token: 0x06003006 RID: 12294 RVA: 0x000D910C File Offset: 0x000D730C
			public unsafe virtual Object System.Xml.IValidationEventHandling.EventHandler
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.ValidationEventHandling.NativeMethodInfoPtr_System_Xml_IValidationEventHandling_get_EventHandler_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003007 RID: 12295 RVA: 0x000D914C File Offset: 0x000D734C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371364, XrefRangeEnd = 371371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Xml_IValidationEventHandling_SendEvent(Exception exception, XmlSeverityType severity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref severity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.ValidationEventHandling.NativeMethodInfoPtr_System_Xml_IValidationEventHandling_SendEvent_Private_Virtual_Final_New_Void_Exception_XmlSeverityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003008 RID: 12296 RVA: 0x000D919C File Offset: 0x000D739C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371371, XrefRangeEnd = 371379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void AddHandler(ValidationEventHandler handler)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlValidatingReaderImpl.ValidationEventHandling.NativeMethodInfoPtr_AddHandler_Internal_Void_ValidationEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003009 RID: 12297 RVA: 0x0001411B File Offset: 0x0001231B
			public ValidationEventHandling(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700102F RID: 4143
			// (get) Token: 0x0600300A RID: 12298 RVA: 0x000D91E0 File Offset: 0x000D73E0
			// (set) Token: 0x0600300B RID: 12299 RVA: 0x00014124 File Offset: 0x00012324
			public unsafe XmlValidatingReaderImpl reader
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlValidatingReaderImpl.ValidationEventHandling.NativeFieldInfoPtr_reader);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlValidatingReaderImpl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlValidatingReaderImpl.ValidationEventHandling.NativeFieldInfoPtr_reader), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001030 RID: 4144
			// (get) Token: 0x0600300C RID: 12300 RVA: 0x000D9210 File Offset: 0x000D7410
			// (set) Token: 0x0600300D RID: 12301 RVA: 0x00014143 File Offset: 0x00012343
			public unsafe ValidationEventHandler eventHandler
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlValidatingReaderImpl.ValidationEventHandling.NativeFieldInfoPtr_eventHandler);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidationEventHandler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlValidatingReaderImpl.ValidationEventHandling.NativeFieldInfoPtr_eventHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040024CE RID: 9422
			private static readonly IntPtr NativeFieldInfoPtr_reader;

			// Token: 0x040024CF RID: 9423
			private static readonly IntPtr NativeFieldInfoPtr_eventHandler;

			// Token: 0x040024D0 RID: 9424
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlValidatingReaderImpl_0;

			// Token: 0x040024D1 RID: 9425
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IValidationEventHandling_get_EventHandler_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040024D2 RID: 9426
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IValidationEventHandling_SendEvent_Private_Virtual_Final_New_Void_Exception_XmlSeverityType_0;

			// Token: 0x040024D3 RID: 9427
			private static readonly IntPtr NativeMethodInfoPtr_AddHandler_Internal_Void_ValidationEventHandler_0;
		}
	}
}
