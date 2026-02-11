using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001FD RID: 509
	public sealed class XsdValidator : BaseValidator
	{
		// Token: 0x06002CB3 RID: 11443 RVA: 0x000CE6CC File Offset: 0x000CC8CC
		// Note: this type is marked as 'beforefieldinit'.
		static XsdValidator()
		{
			Il2CppClassPointerStore<XsdValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XsdValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr);
			XsdValidator.NativeFieldInfoPtr_startIDConstraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, "startIDConstraint");
			XsdValidator.NativeFieldInfoPtr_validationStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, "validationStack");
			XsdValidator.NativeFieldInfoPtr_attPresence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, "attPresence");
			XsdValidator.NativeFieldInfoPtr_nsManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, "nsManager");
			XsdValidator.NativeFieldInfoPtr_bManageNamespaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, "bManageNamespaces");
			XsdValidator.NativeFieldInfoPtr_IDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, "IDs");
			XsdValidator.NativeFieldInfoPtr_idRefListHead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, "idRefListHead");
			XsdValidator.NativeFieldInfoPtr_inlineSchemaParser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, "inlineSchemaParser");
			XsdValidator.NativeFieldInfoPtr_processContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, "processContents");
			XsdValidator.NativeFieldInfoPtr_dtCDATA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, "dtCDATA");
			XsdValidator.NativeFieldInfoPtr_dtQName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, "dtQName");
			XsdValidator.NativeFieldInfoPtr_dtStringArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, "dtStringArray");
			XsdValidator.NativeFieldInfoPtr_NsXmlNs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, "NsXmlNs");
			XsdValidator.NativeFieldInfoPtr_NsXs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, "NsXs");
			XsdValidator.NativeFieldInfoPtr_NsXsi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, "NsXsi");
			XsdValidator.NativeFieldInfoPtr_XsiType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, "XsiType");
			XsdValidator.NativeFieldInfoPtr_XsiNil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, "XsiNil");
			XsdValidator.NativeFieldInfoPtr_XsiSchemaLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, "XsiSchemaLocation");
			XsdValidator.NativeFieldInfoPtr_XsiNoNamespaceSchemaLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, "XsiNoNamespaceSchemaLocation");
			XsdValidator.NativeFieldInfoPtr_XsdSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, "XsdSchema");
			XsdValidator.NativeMethodInfoPtr__ctor_Internal_Void_BaseValidator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669772);
			XsdValidator.NativeMethodInfoPtr__ctor_Internal_Void_XmlValidatingReaderImpl_XmlSchemaCollection_IValidationEventHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669773);
			XsdValidator.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669774);
			XsdValidator.NativeMethodInfoPtr_Validate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669775);
			XsdValidator.NativeMethodInfoPtr_CompleteValidation_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669776);
			XsdValidator.NativeMethodInfoPtr_get_IsInlineSchemaStarted_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669777);
			XsdValidator.NativeMethodInfoPtr_ProcessInlineSchema_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669778);
			XsdValidator.NativeMethodInfoPtr_ValidateElement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669779);
			XsdValidator.NativeMethodInfoPtr_ValidateChildElement_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669780);
			XsdValidator.NativeMethodInfoPtr_ProcessElement_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669781);
			XsdValidator.NativeMethodInfoPtr_ProcessXsiAttributes_Private_Void_byref_XmlQualifiedName_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669782);
			XsdValidator.NativeMethodInfoPtr_ValidateEndElement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669783);
			XsdValidator.NativeMethodInfoPtr_FastGetElementDecl_Private_SchemaElementDecl_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669784);
			XsdValidator.NativeMethodInfoPtr_ThoroughGetElementDecl_Private_SchemaElementDecl_SchemaElementDecl_XmlQualifiedName_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669785);
			XsdValidator.NativeMethodInfoPtr_ValidateStartElement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669786);
			XsdValidator.NativeMethodInfoPtr_ValidateEndStartElement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669787);
			XsdValidator.NativeMethodInfoPtr_LoadSchemaFromLocation_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669788);
			XsdValidator.NativeMethodInfoPtr_LoadSchema_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669789);
			XsdValidator.NativeMethodInfoPtr_get_HasSchema_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669790);
			XsdValidator.NativeMethodInfoPtr_get_PreserveWhitespace_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669791);
			XsdValidator.NativeMethodInfoPtr_ProcessTokenizedType_Private_Void_XmlTokenizedType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669792);
			XsdValidator.NativeMethodInfoPtr_CheckValue_Private_Void_String_SchemaAttDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669793);
			XsdValidator.NativeMethodInfoPtr_AddID_Internal_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669794);
			XsdValidator.NativeMethodInfoPtr_FindId_Public_Virtual_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669795);
			XsdValidator.NativeMethodInfoPtr_IsXSDRoot_Public_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669796);
			XsdValidator.NativeMethodInfoPtr_Push_Private_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669797);
			XsdValidator.NativeMethodInfoPtr_Pop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669798);
			XsdValidator.NativeMethodInfoPtr_CheckForwardRefs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669799);
			XsdValidator.NativeMethodInfoPtr_ValidateStartElementIdentityConstraints_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669800);
			XsdValidator.NativeMethodInfoPtr_get_HasIdentityConstraints_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669801);
			XsdValidator.NativeMethodInfoPtr_AddIdentityConstraints_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669802);
			XsdValidator.NativeMethodInfoPtr_ElementIdentityConstraints_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669803);
			XsdValidator.NativeMethodInfoPtr_AttributeIdentityConstraints_Private_Void_String_String_Object_String_SchemaAttDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669804);
			XsdValidator.NativeMethodInfoPtr_UnWrapUnion_Private_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669805);
			XsdValidator.NativeMethodInfoPtr_EndElementIdentityConstraints_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr, 100669806);
		}

		// Token: 0x06002CB4 RID: 11444 RVA: 0x000CEB48 File Offset: 0x000CCD48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 424892, RefRangeEnd = 424893, XrefRangeStart = 424890, XrefRangeEnd = 424892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XsdValidator(BaseValidator validator)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(validator);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr__ctor_Internal_Void_BaseValidator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CB5 RID: 11445 RVA: 0x000CEB94 File Offset: 0x000CCD94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 424895, RefRangeEnd = 424896, XrefRangeStart = 424893, XrefRangeEnd = 424895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XsdValidator(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XsdValidator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaCollection);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventHandling);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr__ctor_Internal_Void_XmlValidatingReaderImpl_XmlSchemaCollection_IValidationEventHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CB6 RID: 11446 RVA: 0x000CEC04 File Offset: 0x000CCE04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 424952, RefRangeEnd = 424954, XrefRangeStart = 424896, XrefRangeEnd = 424952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CB7 RID: 11447 RVA: 0x000CEC38 File Offset: 0x000CCE38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424954, XrefRangeEnd = 424960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Validate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_Validate_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CB8 RID: 11448 RVA: 0x000CEC6C File Offset: 0x000CCE6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424960, XrefRangeEnd = 424970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CompleteValidation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_CompleteValidation_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000EF1 RID: 3825
		// (get) Token: 0x06002CB9 RID: 11449 RVA: 0x000CECA0 File Offset: 0x000CCEA0
		public unsafe bool IsInlineSchemaStarted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_get_IsInlineSchemaStarted_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CBA RID: 11450 RVA: 0x000CECDC File Offset: 0x000CCEDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 424993, RefRangeEnd = 424995, XrefRangeStart = 424970, XrefRangeEnd = 424993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessInlineSchema()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_ProcessInlineSchema_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CBB RID: 11451 RVA: 0x000CED10 File Offset: 0x000CCF10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 425010, RefRangeEnd = 425011, XrefRangeStart = 424995, XrefRangeEnd = 425010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_ValidateElement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CBC RID: 11452 RVA: 0x000CED44 File Offset: 0x000CCF44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 425020, RefRangeEnd = 425021, XrefRangeStart = 425011, XrefRangeEnd = 425020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ValidateChildElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_ValidateChildElement_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002CBD RID: 11453 RVA: 0x000CED84 File Offset: 0x000CCF84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 425035, RefRangeEnd = 425036, XrefRangeStart = 425021, XrefRangeEnd = 425035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessElement(Object particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_ProcessElement_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CBE RID: 11454 RVA: 0x000CEDC8 File Offset: 0x000CCFC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 425100, RefRangeEnd = 425101, XrefRangeStart = 425036, XrefRangeEnd = 425100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessXsiAttributes(out XmlQualifiedName xsiType, out string xsiNil)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_ProcessXsiAttributes_Private_Void_byref_XmlQualifiedName_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			xsiType = ((intPtr5 == 0) ? null : new XmlQualifiedName(intPtr5));
			xsiNil = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06002CBF RID: 11455 RVA: 0x000CEE34 File Offset: 0x000CD034
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 425116, RefRangeEnd = 425118, XrefRangeStart = 425101, XrefRangeEnd = 425116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateEndElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_ValidateEndElement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CC0 RID: 11456 RVA: 0x000CEE68 File Offset: 0x000CD068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425118, XrefRangeEnd = 425121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaElementDecl FastGetElementDecl(Object particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_FastGetElementDecl_Private_SchemaElementDecl_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr3) : null;
			}
		}

		// Token: 0x06002CC1 RID: 11457 RVA: 0x000CEEB8 File Offset: 0x000CD0B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425121, XrefRangeEnd = 425179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaElementDecl ThoroughGetElementDecl(SchemaElementDecl elementDecl, XmlQualifiedName xsiType, string xsiNil)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementDecl);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xsiType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xsiNil);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_ThoroughGetElementDecl_Private_SchemaElementDecl_SchemaElementDecl_XmlQualifiedName_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr3) : null;
		}

		// Token: 0x06002CC2 RID: 11458 RVA: 0x000CEF2C File Offset: 0x000CD12C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 425213, RefRangeEnd = 425214, XrefRangeStart = 425179, XrefRangeEnd = 425213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateStartElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_ValidateStartElement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CC3 RID: 11459 RVA: 0x000CEF60 File Offset: 0x000CD160
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 425239, RefRangeEnd = 425240, XrefRangeStart = 425214, XrefRangeEnd = 425239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateEndStartElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_ValidateEndStartElement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CC4 RID: 11460 RVA: 0x000CEF94 File Offset: 0x000CD194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425240, XrefRangeEnd = 425279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadSchemaFromLocation(string uri, string url)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(url);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_LoadSchemaFromLocation_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CC5 RID: 11461 RVA: 0x000CEFE8 File Offset: 0x000CD1E8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 425285, RefRangeEnd = 425290, XrefRangeStart = 425279, XrefRangeEnd = 425285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadSchema(string uri, string url)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(url);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_LoadSchema_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000EF2 RID: 3826
		// (get) Token: 0x06002CC6 RID: 11462 RVA: 0x000CF03C File Offset: 0x000CD23C
		public unsafe bool HasSchema
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_get_HasSchema_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000EF3 RID: 3827
		// (get) Token: 0x06002CC7 RID: 11463 RVA: 0x000CF078 File Offset: 0x000CD278
		public unsafe override bool PreserveWhitespace
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_get_PreserveWhitespace_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CC8 RID: 11464 RVA: 0x000CF0B4 File Offset: 0x000CD2B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 425308, RefRangeEnd = 425310, XrefRangeStart = 425290, XrefRangeEnd = 425308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessTokenizedType(XmlTokenizedType ttype, string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ttype;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_ProcessTokenizedType_Private_Void_XmlTokenizedType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CC9 RID: 11465 RVA: 0x000CF104 File Offset: 0x000CD304
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 425346, RefRangeEnd = 425348, XrefRangeStart = 425310, XrefRangeEnd = 425346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckValue(string value, SchemaAttDef attdef)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attdef);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_CheckValue_Private_Void_String_SchemaAttDef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CCA RID: 11466 RVA: 0x000CF158 File Offset: 0x000CD358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425348, XrefRangeEnd = 425354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddID(string name, Object node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(node);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_AddID_Internal_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CCB RID: 11467 RVA: 0x000CF1AC File Offset: 0x000CD3AC
		[CallerCount(0)]
		public unsafe override Object FindId(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_FindId_Public_Virtual_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002CCC RID: 11468 RVA: 0x000CF1FC File Offset: 0x000CD3FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425354, XrefRangeEnd = 425355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsXSDRoot(string localName, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_IsXSDRoot_Public_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002CCD RID: 11469 RVA: 0x000CF25C File Offset: 0x000CD45C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 425372, RefRangeEnd = 425374, XrefRangeStart = 425355, XrefRangeEnd = 425372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Push(XmlQualifiedName elementName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_Push_Private_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CCE RID: 11470 RVA: 0x000CF2A0 File Offset: 0x000CD4A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425374, XrefRangeEnd = 425381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_Pop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CCF RID: 11471 RVA: 0x000CF2D4 File Offset: 0x000CD4D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckForwardRefs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_CheckForwardRefs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CD0 RID: 11472 RVA: 0x000CF308 File Offset: 0x000CD508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425381, XrefRangeEnd = 425383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateStartElementIdentityConstraints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_ValidateStartElementIdentityConstraints_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000EF4 RID: 3828
		// (get) Token: 0x06002CD1 RID: 11473 RVA: 0x000CF33C File Offset: 0x000CD53C
		public unsafe bool HasIdentityConstraints
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_get_HasIdentityConstraints_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CD2 RID: 11474 RVA: 0x000CF378 File Offset: 0x000CD578
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 425419, RefRangeEnd = 425421, XrefRangeStart = 425383, XrefRangeEnd = 425419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddIdentityConstraints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_AddIdentityConstraints_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CD3 RID: 11475 RVA: 0x000CF3AC File Offset: 0x000CD5AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 425438, RefRangeEnd = 425440, XrefRangeStart = 425421, XrefRangeEnd = 425438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ElementIdentityConstraints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_ElementIdentityConstraints_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CD4 RID: 11476 RVA: 0x000CF3E0 File Offset: 0x000CD5E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 425461, RefRangeEnd = 425463, XrefRangeStart = 425440, XrefRangeEnd = 425461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AttributeIdentityConstraints(string name, string ns, Object obj, string sobj, SchemaAttDef attdef)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sobj);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attdef);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_AttributeIdentityConstraints_Private_Void_String_String_Object_String_SchemaAttDef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CD5 RID: 11477 RVA: 0x000CF46C File Offset: 0x000CD66C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 425466, RefRangeEnd = 425468, XrefRangeStart = 425463, XrefRangeEnd = 425466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object UnWrapUnion(Object typedValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typedValue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_UnWrapUnion_Private_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002CD6 RID: 11478 RVA: 0x000CF4BC File Offset: 0x000CD6BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 425547, RefRangeEnd = 425548, XrefRangeStart = 425468, XrefRangeEnd = 425547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndElementIdentityConstraints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdValidator.NativeMethodInfoPtr_EndElementIdentityConstraints_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CD7 RID: 11479 RVA: 0x000126B8 File Offset: 0x000108B8
		public XsdValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EDD RID: 3805
		// (get) Token: 0x06002CD8 RID: 11480 RVA: 0x000CF4F0 File Offset: 0x000CD6F0
		// (set) Token: 0x06002CD9 RID: 11481 RVA: 0x000126C1 File Offset: 0x000108C1
		public unsafe int startIDConstraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_startIDConstraint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_startIDConstraint)) = value;
			}
		}

		// Token: 0x17000EDE RID: 3806
		// (get) Token: 0x06002CDA RID: 11482 RVA: 0x000CF518 File Offset: 0x000CD718
		// (set) Token: 0x06002CDB RID: 11483 RVA: 0x000126DC File Offset: 0x000108DC
		public unsafe HWStack validationStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_validationStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HWStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_validationStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EDF RID: 3807
		// (get) Token: 0x06002CDC RID: 11484 RVA: 0x000CF548 File Offset: 0x000CD748
		// (set) Token: 0x06002CDD RID: 11485 RVA: 0x000126FB File Offset: 0x000108FB
		public unsafe Hashtable attPresence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_attPresence);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_attPresence), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE0 RID: 3808
		// (get) Token: 0x06002CDE RID: 11486 RVA: 0x000CF578 File Offset: 0x000CD778
		// (set) Token: 0x06002CDF RID: 11487 RVA: 0x0001271A File Offset: 0x0001091A
		public unsafe XmlNamespaceManager nsManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_nsManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNamespaceManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_nsManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE1 RID: 3809
		// (get) Token: 0x06002CE0 RID: 11488 RVA: 0x000CF5A8 File Offset: 0x000CD7A8
		// (set) Token: 0x06002CE1 RID: 11489 RVA: 0x00012739 File Offset: 0x00010939
		public unsafe bool bManageNamespaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_bManageNamespaces);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_bManageNamespaces)) = value;
			}
		}

		// Token: 0x17000EE2 RID: 3810
		// (get) Token: 0x06002CE2 RID: 11490 RVA: 0x000CF5D0 File Offset: 0x000CD7D0
		// (set) Token: 0x06002CE3 RID: 11491 RVA: 0x00012754 File Offset: 0x00010954
		public unsafe Hashtable IDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_IDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_IDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE3 RID: 3811
		// (get) Token: 0x06002CE4 RID: 11492 RVA: 0x000CF600 File Offset: 0x000CD800
		// (set) Token: 0x06002CE5 RID: 11493 RVA: 0x00012773 File Offset: 0x00010973
		public unsafe IdRefNode idRefListHead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_idRefListHead);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IdRefNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_idRefListHead), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE4 RID: 3812
		// (get) Token: 0x06002CE6 RID: 11494 RVA: 0x000CF630 File Offset: 0x000CD830
		// (set) Token: 0x06002CE7 RID: 11495 RVA: 0x00012792 File Offset: 0x00010992
		public unsafe Parser inlineSchemaParser
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_inlineSchemaParser);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Parser>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_inlineSchemaParser), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE5 RID: 3813
		// (get) Token: 0x06002CE8 RID: 11496 RVA: 0x000CF660 File Offset: 0x000CD860
		// (set) Token: 0x06002CE9 RID: 11497 RVA: 0x000127B1 File Offset: 0x000109B1
		public unsafe XmlSchemaContentProcessing processContents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_processContents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_processContents)) = value;
			}
		}

		// Token: 0x17000EE6 RID: 3814
		// (get) Token: 0x06002CEA RID: 11498 RVA: 0x000CF688 File Offset: 0x000CD888
		// (set) Token: 0x06002CEB RID: 11499 RVA: 0x000127CC File Offset: 0x000109CC
		public unsafe static XmlSchemaDatatype dtCDATA
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdValidator.NativeFieldInfoPtr_dtCDATA, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdValidator.NativeFieldInfoPtr_dtCDATA, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE7 RID: 3815
		// (get) Token: 0x06002CEC RID: 11500 RVA: 0x000CF6B0 File Offset: 0x000CD8B0
		// (set) Token: 0x06002CED RID: 11501 RVA: 0x000127DE File Offset: 0x000109DE
		public unsafe static XmlSchemaDatatype dtQName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdValidator.NativeFieldInfoPtr_dtQName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdValidator.NativeFieldInfoPtr_dtQName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE8 RID: 3816
		// (get) Token: 0x06002CEE RID: 11502 RVA: 0x000CF6D8 File Offset: 0x000CD8D8
		// (set) Token: 0x06002CEF RID: 11503 RVA: 0x000127F0 File Offset: 0x000109F0
		public unsafe static XmlSchemaDatatype dtStringArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XsdValidator.NativeFieldInfoPtr_dtStringArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XsdValidator.NativeFieldInfoPtr_dtStringArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE9 RID: 3817
		// (get) Token: 0x06002CF0 RID: 11504 RVA: 0x000CF700 File Offset: 0x000CD900
		// (set) Token: 0x06002CF1 RID: 11505 RVA: 0x00012802 File Offset: 0x00010A02
		public unsafe string NsXmlNs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_NsXmlNs);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_NsXmlNs), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EEA RID: 3818
		// (get) Token: 0x06002CF2 RID: 11506 RVA: 0x000CF728 File Offset: 0x000CD928
		// (set) Token: 0x06002CF3 RID: 11507 RVA: 0x00012821 File Offset: 0x00010A21
		public unsafe string NsXs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_NsXs);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_NsXs), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EEB RID: 3819
		// (get) Token: 0x06002CF4 RID: 11508 RVA: 0x000CF750 File Offset: 0x000CD950
		// (set) Token: 0x06002CF5 RID: 11509 RVA: 0x00012840 File Offset: 0x00010A40
		public unsafe string NsXsi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_NsXsi);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_NsXsi), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EEC RID: 3820
		// (get) Token: 0x06002CF6 RID: 11510 RVA: 0x000CF778 File Offset: 0x000CD978
		// (set) Token: 0x06002CF7 RID: 11511 RVA: 0x0001285F File Offset: 0x00010A5F
		public unsafe string XsiType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_XsiType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_XsiType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EED RID: 3821
		// (get) Token: 0x06002CF8 RID: 11512 RVA: 0x000CF7A0 File Offset: 0x000CD9A0
		// (set) Token: 0x06002CF9 RID: 11513 RVA: 0x0001287E File Offset: 0x00010A7E
		public unsafe string XsiNil
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_XsiNil);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_XsiNil), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EEE RID: 3822
		// (get) Token: 0x06002CFA RID: 11514 RVA: 0x000CF7C8 File Offset: 0x000CD9C8
		// (set) Token: 0x06002CFB RID: 11515 RVA: 0x0001289D File Offset: 0x00010A9D
		public unsafe string XsiSchemaLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_XsiSchemaLocation);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_XsiSchemaLocation), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EEF RID: 3823
		// (get) Token: 0x06002CFC RID: 11516 RVA: 0x000CF7F0 File Offset: 0x000CD9F0
		// (set) Token: 0x06002CFD RID: 11517 RVA: 0x000128BC File Offset: 0x00010ABC
		public unsafe string XsiNoNamespaceSchemaLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_XsiNoNamespaceSchemaLocation);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_XsiNoNamespaceSchemaLocation), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EF0 RID: 3824
		// (get) Token: 0x06002CFE RID: 11518 RVA: 0x000CF818 File Offset: 0x000CDA18
		// (set) Token: 0x06002CFF RID: 11519 RVA: 0x000128DB File Offset: 0x00010ADB
		public unsafe string XsdSchema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_XsdSchema);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdValidator.NativeFieldInfoPtr_XsdSchema), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002227 RID: 8743
		private static readonly IntPtr NativeFieldInfoPtr_startIDConstraint;

		// Token: 0x04002228 RID: 8744
		private static readonly IntPtr NativeFieldInfoPtr_validationStack;

		// Token: 0x04002229 RID: 8745
		private static readonly IntPtr NativeFieldInfoPtr_attPresence;

		// Token: 0x0400222A RID: 8746
		private static readonly IntPtr NativeFieldInfoPtr_nsManager;

		// Token: 0x0400222B RID: 8747
		private static readonly IntPtr NativeFieldInfoPtr_bManageNamespaces;

		// Token: 0x0400222C RID: 8748
		private static readonly IntPtr NativeFieldInfoPtr_IDs;

		// Token: 0x0400222D RID: 8749
		private static readonly IntPtr NativeFieldInfoPtr_idRefListHead;

		// Token: 0x0400222E RID: 8750
		private static readonly IntPtr NativeFieldInfoPtr_inlineSchemaParser;

		// Token: 0x0400222F RID: 8751
		private static readonly IntPtr NativeFieldInfoPtr_processContents;

		// Token: 0x04002230 RID: 8752
		private static readonly IntPtr NativeFieldInfoPtr_dtCDATA;

		// Token: 0x04002231 RID: 8753
		private static readonly IntPtr NativeFieldInfoPtr_dtQName;

		// Token: 0x04002232 RID: 8754
		private static readonly IntPtr NativeFieldInfoPtr_dtStringArray;

		// Token: 0x04002233 RID: 8755
		private static readonly IntPtr NativeFieldInfoPtr_NsXmlNs;

		// Token: 0x04002234 RID: 8756
		private static readonly IntPtr NativeFieldInfoPtr_NsXs;

		// Token: 0x04002235 RID: 8757
		private static readonly IntPtr NativeFieldInfoPtr_NsXsi;

		// Token: 0x04002236 RID: 8758
		private static readonly IntPtr NativeFieldInfoPtr_XsiType;

		// Token: 0x04002237 RID: 8759
		private static readonly IntPtr NativeFieldInfoPtr_XsiNil;

		// Token: 0x04002238 RID: 8760
		private static readonly IntPtr NativeFieldInfoPtr_XsiSchemaLocation;

		// Token: 0x04002239 RID: 8761
		private static readonly IntPtr NativeFieldInfoPtr_XsiNoNamespaceSchemaLocation;

		// Token: 0x0400223A RID: 8762
		private static readonly IntPtr NativeFieldInfoPtr_XsdSchema;

		// Token: 0x0400223B RID: 8763
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BaseValidator_0;

		// Token: 0x0400223C RID: 8764
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlValidatingReaderImpl_XmlSchemaCollection_IValidationEventHandling_0;

		// Token: 0x0400223D RID: 8765
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x0400223E RID: 8766
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Public_Virtual_Void_0;

		// Token: 0x0400223F RID: 8767
		private static readonly IntPtr NativeMethodInfoPtr_CompleteValidation_Public_Virtual_Void_0;

		// Token: 0x04002240 RID: 8768
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInlineSchemaStarted_Private_get_Boolean_0;

		// Token: 0x04002241 RID: 8769
		private static readonly IntPtr NativeMethodInfoPtr_ProcessInlineSchema_Private_Void_0;

		// Token: 0x04002242 RID: 8770
		private static readonly IntPtr NativeMethodInfoPtr_ValidateElement_Private_Void_0;

		// Token: 0x04002243 RID: 8771
		private static readonly IntPtr NativeMethodInfoPtr_ValidateChildElement_Private_Object_0;

		// Token: 0x04002244 RID: 8772
		private static readonly IntPtr NativeMethodInfoPtr_ProcessElement_Private_Void_Object_0;

		// Token: 0x04002245 RID: 8773
		private static readonly IntPtr NativeMethodInfoPtr_ProcessXsiAttributes_Private_Void_byref_XmlQualifiedName_byref_String_0;

		// Token: 0x04002246 RID: 8774
		private static readonly IntPtr NativeMethodInfoPtr_ValidateEndElement_Private_Void_0;

		// Token: 0x04002247 RID: 8775
		private static readonly IntPtr NativeMethodInfoPtr_FastGetElementDecl_Private_SchemaElementDecl_Object_0;

		// Token: 0x04002248 RID: 8776
		private static readonly IntPtr NativeMethodInfoPtr_ThoroughGetElementDecl_Private_SchemaElementDecl_SchemaElementDecl_XmlQualifiedName_String_0;

		// Token: 0x04002249 RID: 8777
		private static readonly IntPtr NativeMethodInfoPtr_ValidateStartElement_Private_Void_0;

		// Token: 0x0400224A RID: 8778
		private static readonly IntPtr NativeMethodInfoPtr_ValidateEndStartElement_Private_Void_0;

		// Token: 0x0400224B RID: 8779
		private static readonly IntPtr NativeMethodInfoPtr_LoadSchemaFromLocation_Private_Void_String_String_0;

		// Token: 0x0400224C RID: 8780
		private static readonly IntPtr NativeMethodInfoPtr_LoadSchema_Private_Void_String_String_0;

		// Token: 0x0400224D RID: 8781
		private static readonly IntPtr NativeMethodInfoPtr_get_HasSchema_Private_get_Boolean_0;

		// Token: 0x0400224E RID: 8782
		private static readonly IntPtr NativeMethodInfoPtr_get_PreserveWhitespace_Public_Virtual_get_Boolean_0;

		// Token: 0x0400224F RID: 8783
		private static readonly IntPtr NativeMethodInfoPtr_ProcessTokenizedType_Private_Void_XmlTokenizedType_String_0;

		// Token: 0x04002250 RID: 8784
		private static readonly IntPtr NativeMethodInfoPtr_CheckValue_Private_Void_String_SchemaAttDef_0;

		// Token: 0x04002251 RID: 8785
		private static readonly IntPtr NativeMethodInfoPtr_AddID_Internal_Void_String_Object_0;

		// Token: 0x04002252 RID: 8786
		private static readonly IntPtr NativeMethodInfoPtr_FindId_Public_Virtual_Object_String_0;

		// Token: 0x04002253 RID: 8787
		private static readonly IntPtr NativeMethodInfoPtr_IsXSDRoot_Public_Boolean_String_String_0;

		// Token: 0x04002254 RID: 8788
		private static readonly IntPtr NativeMethodInfoPtr_Push_Private_Void_XmlQualifiedName_0;

		// Token: 0x04002255 RID: 8789
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Private_Void_0;

		// Token: 0x04002256 RID: 8790
		private static readonly IntPtr NativeMethodInfoPtr_CheckForwardRefs_Private_Void_0;

		// Token: 0x04002257 RID: 8791
		private static readonly IntPtr NativeMethodInfoPtr_ValidateStartElementIdentityConstraints_Private_Void_0;

		// Token: 0x04002258 RID: 8792
		private static readonly IntPtr NativeMethodInfoPtr_get_HasIdentityConstraints_Private_get_Boolean_0;

		// Token: 0x04002259 RID: 8793
		private static readonly IntPtr NativeMethodInfoPtr_AddIdentityConstraints_Private_Void_0;

		// Token: 0x0400225A RID: 8794
		private static readonly IntPtr NativeMethodInfoPtr_ElementIdentityConstraints_Private_Void_0;

		// Token: 0x0400225B RID: 8795
		private static readonly IntPtr NativeMethodInfoPtr_AttributeIdentityConstraints_Private_Void_String_String_Object_String_SchemaAttDef_0;

		// Token: 0x0400225C RID: 8796
		private static readonly IntPtr NativeMethodInfoPtr_UnWrapUnion_Private_Object_Object_0;

		// Token: 0x0400225D RID: 8797
		private static readonly IntPtr NativeMethodInfoPtr_EndElementIdentityConstraints_Private_Void_0;
	}
}
