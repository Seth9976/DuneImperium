using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000194 RID: 404
	public sealed class XdrValidator : BaseValidator
	{
		// Token: 0x060022DE RID: 8926 RVA: 0x000A6A10 File Offset: 0x000A4C10
		// Note: this type is marked as 'beforefieldinit'.
		static XdrValidator()
		{
			Il2CppClassPointerStore<XdrValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XdrValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XdrValidator>.NativeClassPtr);
			XdrValidator.NativeFieldInfoPtr_validationStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrValidator>.NativeClassPtr, "validationStack");
			XdrValidator.NativeFieldInfoPtr_attPresence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrValidator>.NativeClassPtr, "attPresence");
			XdrValidator.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrValidator>.NativeClassPtr, "name");
			XdrValidator.NativeFieldInfoPtr_nsManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrValidator>.NativeClassPtr, "nsManager");
			XdrValidator.NativeFieldInfoPtr_isProcessContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrValidator>.NativeClassPtr, "isProcessContents");
			XdrValidator.NativeFieldInfoPtr_IDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrValidator>.NativeClassPtr, "IDs");
			XdrValidator.NativeFieldInfoPtr_idRefListHead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrValidator>.NativeClassPtr, "idRefListHead");
			XdrValidator.NativeFieldInfoPtr_inlineSchemaParser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XdrValidator>.NativeClassPtr, "inlineSchemaParser");
			XdrValidator.NativeMethodInfoPtr__ctor_Internal_Void_BaseValidator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrValidator>.NativeClassPtr, 100668365);
			XdrValidator.NativeMethodInfoPtr__ctor_Internal_Void_XmlValidatingReaderImpl_XmlSchemaCollection_IValidationEventHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrValidator>.NativeClassPtr, 100668366);
			XdrValidator.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrValidator>.NativeClassPtr, 100668367);
			XdrValidator.NativeMethodInfoPtr_Validate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrValidator>.NativeClassPtr, 100668368);
			XdrValidator.NativeMethodInfoPtr_ValidateElement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrValidator>.NativeClassPtr, 100668369);
			XdrValidator.NativeMethodInfoPtr_ValidateChildElement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrValidator>.NativeClassPtr, 100668370);
			XdrValidator.NativeMethodInfoPtr_get_IsInlineSchemaStarted_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrValidator>.NativeClassPtr, 100668371);
			XdrValidator.NativeMethodInfoPtr_ProcessInlineSchema_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrValidator>.NativeClassPtr, 100668372);
			XdrValidator.NativeMethodInfoPtr_ProcessElement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrValidator>.NativeClassPtr, 100668373);
			XdrValidator.NativeMethodInfoPtr_ValidateEndElement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrValidator>.NativeClassPtr, 100668374);
			XdrValidator.NativeMethodInfoPtr_ThoroughGetElementDecl_Private_SchemaElementDecl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrValidator>.NativeClassPtr, 100668375);
			XdrValidator.NativeMethodInfoPtr_ValidateStartElement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrValidator>.NativeClassPtr, 100668376);
			XdrValidator.NativeMethodInfoPtr_ValidateEndStartElement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrValidator>.NativeClassPtr, 100668377);
			XdrValidator.NativeMethodInfoPtr_LoadSchemaFromLocation_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrValidator>.NativeClassPtr, 100668378);
			XdrValidator.NativeMethodInfoPtr_LoadSchema_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrValidator>.NativeClassPtr, 100668379);
			XdrValidator.NativeMethodInfoPtr_get_HasSchema_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrValidator>.NativeClassPtr, 100668380);
			XdrValidator.NativeMethodInfoPtr_get_PreserveWhitespace_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrValidator>.NativeClassPtr, 100668381);
			XdrValidator.NativeMethodInfoPtr_ProcessTokenizedType_Private_Void_XmlTokenizedType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrValidator>.NativeClassPtr, 100668382);
			XdrValidator.NativeMethodInfoPtr_CompleteValidation_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrValidator>.NativeClassPtr, 100668383);
			XdrValidator.NativeMethodInfoPtr_CheckValue_Private_Void_String_SchemaAttDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrValidator>.NativeClassPtr, 100668384);
			XdrValidator.NativeMethodInfoPtr_CheckDefaultValue_Public_Static_Void_String_SchemaAttDef_SchemaInfo_XmlNamespaceManager_XmlNameTable_Object_ValidationEventHandler_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrValidator>.NativeClassPtr, 100668385);
			XdrValidator.NativeMethodInfoPtr_AddID_Internal_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrValidator>.NativeClassPtr, 100668386);
			XdrValidator.NativeMethodInfoPtr_FindId_Public_Virtual_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrValidator>.NativeClassPtr, 100668387);
			XdrValidator.NativeMethodInfoPtr_Push_Private_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrValidator>.NativeClassPtr, 100668388);
			XdrValidator.NativeMethodInfoPtr_Pop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrValidator>.NativeClassPtr, 100668389);
			XdrValidator.NativeMethodInfoPtr_CheckForwardRefs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrValidator>.NativeClassPtr, 100668390);
			XdrValidator.NativeMethodInfoPtr_QualifiedName_Private_XmlQualifiedName_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XdrValidator>.NativeClassPtr, 100668391);
		}

		// Token: 0x060022DF RID: 8927 RVA: 0x000A6CFC File Offset: 0x000A4EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409921, XrefRangeEnd = 409928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XdrValidator(BaseValidator validator)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XdrValidator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(validator);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrValidator.NativeMethodInfoPtr__ctor_Internal_Void_BaseValidator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022E0 RID: 8928 RVA: 0x000A6D48 File Offset: 0x000A4F48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 409935, RefRangeEnd = 409936, XrefRangeStart = 409928, XrefRangeEnd = 409935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XdrValidator(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XdrValidator>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrValidator.NativeMethodInfoPtr__ctor_Internal_Void_XmlValidatingReaderImpl_XmlSchemaCollection_IValidationEventHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022E1 RID: 8929 RVA: 0x000A6DB8 File Offset: 0x000A4FB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 409969, RefRangeEnd = 409971, XrefRangeStart = 409936, XrefRangeEnd = 409969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrValidator.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022E2 RID: 8930 RVA: 0x000A6DEC File Offset: 0x000A4FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409971, XrefRangeEnd = 409977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Validate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrValidator.NativeMethodInfoPtr_Validate_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022E3 RID: 8931 RVA: 0x000A6E20 File Offset: 0x000A5020
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 409996, RefRangeEnd = 409997, XrefRangeStart = 409977, XrefRangeEnd = 409996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrValidator.NativeMethodInfoPtr_ValidateElement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022E4 RID: 8932 RVA: 0x000A6E54 File Offset: 0x000A5054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 409997, XrefRangeEnd = 410002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateChildElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrValidator.NativeMethodInfoPtr_ValidateChildElement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x060022E5 RID: 8933 RVA: 0x000A6E88 File Offset: 0x000A5088
		public unsafe bool IsInlineSchemaStarted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrValidator.NativeMethodInfoPtr_get_IsInlineSchemaStarted_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060022E6 RID: 8934 RVA: 0x000A6EC4 File Offset: 0x000A50C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 410027, RefRangeEnd = 410028, XrefRangeStart = 410002, XrefRangeEnd = 410027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessInlineSchema()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrValidator.NativeMethodInfoPtr_ProcessInlineSchema_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022E7 RID: 8935 RVA: 0x000A6EF8 File Offset: 0x000A50F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410028, XrefRangeEnd = 410033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrValidator.NativeMethodInfoPtr_ProcessElement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022E8 RID: 8936 RVA: 0x000A6F2C File Offset: 0x000A512C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 410051, RefRangeEnd = 410053, XrefRangeStart = 410033, XrefRangeEnd = 410051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateEndElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrValidator.NativeMethodInfoPtr_ValidateEndElement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022E9 RID: 8937 RVA: 0x000A6F60 File Offset: 0x000A5160
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 410081, RefRangeEnd = 410082, XrefRangeStart = 410053, XrefRangeEnd = 410081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaElementDecl ThoroughGetElementDecl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrValidator.NativeMethodInfoPtr_ThoroughGetElementDecl_Private_SchemaElementDecl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr3) : null;
		}

		// Token: 0x060022EA RID: 8938 RVA: 0x000A6FA0 File Offset: 0x000A51A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 410100, RefRangeEnd = 410101, XrefRangeStart = 410082, XrefRangeEnd = 410100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateStartElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrValidator.NativeMethodInfoPtr_ValidateStartElement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022EB RID: 8939 RVA: 0x000A6FD4 File Offset: 0x000A51D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 410122, RefRangeEnd = 410123, XrefRangeStart = 410101, XrefRangeEnd = 410122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateEndStartElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrValidator.NativeMethodInfoPtr_ValidateEndStartElement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022EC RID: 8940 RVA: 0x000A7008 File Offset: 0x000A5208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410123, XrefRangeEnd = 410170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadSchemaFromLocation(string uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrValidator.NativeMethodInfoPtr_LoadSchemaFromLocation_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022ED RID: 8941 RVA: 0x000A704C File Offset: 0x000A524C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 410180, RefRangeEnd = 410182, XrefRangeStart = 410170, XrefRangeEnd = 410180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadSchema(string uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrValidator.NativeMethodInfoPtr_LoadSchema_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x060022EE RID: 8942 RVA: 0x000A7090 File Offset: 0x000A5290
		public unsafe bool HasSchema
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrValidator.NativeMethodInfoPtr_get_HasSchema_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x060022EF RID: 8943 RVA: 0x000A70CC File Offset: 0x000A52CC
		public unsafe override bool PreserveWhitespace
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrValidator.NativeMethodInfoPtr_get_PreserveWhitespace_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060022F0 RID: 8944 RVA: 0x000A7108 File Offset: 0x000A5308
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 410200, RefRangeEnd = 410202, XrefRangeStart = 410182, XrefRangeEnd = 410200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrValidator.NativeMethodInfoPtr_ProcessTokenizedType_Private_Void_XmlTokenizedType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022F1 RID: 8945 RVA: 0x000A7158 File Offset: 0x000A5358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410202, XrefRangeEnd = 410215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CompleteValidation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrValidator.NativeMethodInfoPtr_CompleteValidation_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022F2 RID: 8946 RVA: 0x000A718C File Offset: 0x000A538C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 410262, RefRangeEnd = 410264, XrefRangeStart = 410215, XrefRangeEnd = 410262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrValidator.NativeMethodInfoPtr_CheckValue_Private_Void_String_SchemaAttDef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022F3 RID: 8947 RVA: 0x000A71E0 File Offset: 0x000A53E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 410297, RefRangeEnd = 410298, XrefRangeStart = 410264, XrefRangeEnd = 410297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckDefaultValue(string value, SchemaAttDef attdef, SchemaInfo sinfo, XmlNamespaceManager nsManager, XmlNameTable NameTable, Object sender, ValidationEventHandler eventhandler, string baseUri, int lineNo, int linePos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attdef);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sinfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsManager);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(NameTable);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventhandler);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseUri);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNo;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrValidator.NativeMethodInfoPtr_CheckDefaultValue_Public_Static_Void_String_SchemaAttDef_SchemaInfo_XmlNamespaceManager_XmlNameTable_Object_ValidationEventHandler_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022F4 RID: 8948 RVA: 0x000A72B8 File Offset: 0x000A54B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410298, XrefRangeEnd = 410304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrValidator.NativeMethodInfoPtr_AddID_Internal_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022F5 RID: 8949 RVA: 0x000A730C File Offset: 0x000A550C
		[CallerCount(0)]
		public unsafe override Object FindId(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrValidator.NativeMethodInfoPtr_FindId_Public_Virtual_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060022F6 RID: 8950 RVA: 0x000A735C File Offset: 0x000A555C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 410321, RefRangeEnd = 410323, XrefRangeStart = 410304, XrefRangeEnd = 410321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Push(XmlQualifiedName elementName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrValidator.NativeMethodInfoPtr_Push_Private_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022F7 RID: 8951 RVA: 0x000A73A0 File Offset: 0x000A55A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410323, XrefRangeEnd = 410330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrValidator.NativeMethodInfoPtr_Pop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022F8 RID: 8952 RVA: 0x000A73D4 File Offset: 0x000A55D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410330, XrefRangeEnd = 410340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckForwardRefs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrValidator.NativeMethodInfoPtr_CheckForwardRefs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022F9 RID: 8953 RVA: 0x000A7408 File Offset: 0x000A5608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 410340, XrefRangeEnd = 410346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlQualifiedName QualifiedName(string name, string ns)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XdrValidator.NativeMethodInfoPtr_QualifiedName_Private_XmlQualifiedName_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
		}

		// Token: 0x060022FA RID: 8954 RVA: 0x0000ECA5 File Offset: 0x0000CEA5
		public XdrValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x060022FB RID: 8955 RVA: 0x000A746C File Offset: 0x000A566C
		// (set) Token: 0x060022FC RID: 8956 RVA: 0x0000ECAE File Offset: 0x0000CEAE
		public unsafe HWStack validationStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrValidator.NativeFieldInfoPtr_validationStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HWStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrValidator.NativeFieldInfoPtr_validationStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x060022FD RID: 8957 RVA: 0x000A749C File Offset: 0x000A569C
		// (set) Token: 0x060022FE RID: 8958 RVA: 0x0000ECCD File Offset: 0x0000CECD
		public unsafe Hashtable attPresence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrValidator.NativeFieldInfoPtr_attPresence);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrValidator.NativeFieldInfoPtr_attPresence), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x060022FF RID: 8959 RVA: 0x000A74CC File Offset: 0x000A56CC
		// (set) Token: 0x06002300 RID: 8960 RVA: 0x0000ECEC File Offset: 0x0000CEEC
		public unsafe XmlQualifiedName name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrValidator.NativeFieldInfoPtr_name);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrValidator.NativeFieldInfoPtr_name), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x06002301 RID: 8961 RVA: 0x000A74FC File Offset: 0x000A56FC
		// (set) Token: 0x06002302 RID: 8962 RVA: 0x0000ED0B File Offset: 0x0000CF0B
		public unsafe XmlNamespaceManager nsManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrValidator.NativeFieldInfoPtr_nsManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNamespaceManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrValidator.NativeFieldInfoPtr_nsManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x06002303 RID: 8963 RVA: 0x000A752C File Offset: 0x000A572C
		// (set) Token: 0x06002304 RID: 8964 RVA: 0x0000ED2A File Offset: 0x0000CF2A
		public unsafe bool isProcessContents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrValidator.NativeFieldInfoPtr_isProcessContents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrValidator.NativeFieldInfoPtr_isProcessContents)) = value;
			}
		}

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x06002305 RID: 8965 RVA: 0x000A7554 File Offset: 0x000A5754
		// (set) Token: 0x06002306 RID: 8966 RVA: 0x0000ED45 File Offset: 0x0000CF45
		public unsafe Hashtable IDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrValidator.NativeFieldInfoPtr_IDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrValidator.NativeFieldInfoPtr_IDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x06002307 RID: 8967 RVA: 0x000A7584 File Offset: 0x000A5784
		// (set) Token: 0x06002308 RID: 8968 RVA: 0x0000ED64 File Offset: 0x0000CF64
		public unsafe IdRefNode idRefListHead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrValidator.NativeFieldInfoPtr_idRefListHead);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IdRefNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrValidator.NativeFieldInfoPtr_idRefListHead), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x06002309 RID: 8969 RVA: 0x000A75B4 File Offset: 0x000A57B4
		// (set) Token: 0x0600230A RID: 8970 RVA: 0x0000ED83 File Offset: 0x0000CF83
		public unsafe Parser inlineSchemaParser
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrValidator.NativeFieldInfoPtr_inlineSchemaParser);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Parser>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XdrValidator.NativeFieldInfoPtr_inlineSchemaParser), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A5A RID: 6746
		private static readonly IntPtr NativeFieldInfoPtr_validationStack;

		// Token: 0x04001A5B RID: 6747
		private static readonly IntPtr NativeFieldInfoPtr_attPresence;

		// Token: 0x04001A5C RID: 6748
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04001A5D RID: 6749
		private static readonly IntPtr NativeFieldInfoPtr_nsManager;

		// Token: 0x04001A5E RID: 6750
		private static readonly IntPtr NativeFieldInfoPtr_isProcessContents;

		// Token: 0x04001A5F RID: 6751
		private static readonly IntPtr NativeFieldInfoPtr_IDs;

		// Token: 0x04001A60 RID: 6752
		private static readonly IntPtr NativeFieldInfoPtr_idRefListHead;

		// Token: 0x04001A61 RID: 6753
		private static readonly IntPtr NativeFieldInfoPtr_inlineSchemaParser;

		// Token: 0x04001A62 RID: 6754
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BaseValidator_0;

		// Token: 0x04001A63 RID: 6755
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlValidatingReaderImpl_XmlSchemaCollection_IValidationEventHandling_0;

		// Token: 0x04001A64 RID: 6756
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x04001A65 RID: 6757
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Public_Virtual_Void_0;

		// Token: 0x04001A66 RID: 6758
		private static readonly IntPtr NativeMethodInfoPtr_ValidateElement_Private_Void_0;

		// Token: 0x04001A67 RID: 6759
		private static readonly IntPtr NativeMethodInfoPtr_ValidateChildElement_Private_Void_0;

		// Token: 0x04001A68 RID: 6760
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInlineSchemaStarted_Private_get_Boolean_0;

		// Token: 0x04001A69 RID: 6761
		private static readonly IntPtr NativeMethodInfoPtr_ProcessInlineSchema_Private_Void_0;

		// Token: 0x04001A6A RID: 6762
		private static readonly IntPtr NativeMethodInfoPtr_ProcessElement_Private_Void_0;

		// Token: 0x04001A6B RID: 6763
		private static readonly IntPtr NativeMethodInfoPtr_ValidateEndElement_Private_Void_0;

		// Token: 0x04001A6C RID: 6764
		private static readonly IntPtr NativeMethodInfoPtr_ThoroughGetElementDecl_Private_SchemaElementDecl_0;

		// Token: 0x04001A6D RID: 6765
		private static readonly IntPtr NativeMethodInfoPtr_ValidateStartElement_Private_Void_0;

		// Token: 0x04001A6E RID: 6766
		private static readonly IntPtr NativeMethodInfoPtr_ValidateEndStartElement_Private_Void_0;

		// Token: 0x04001A6F RID: 6767
		private static readonly IntPtr NativeMethodInfoPtr_LoadSchemaFromLocation_Private_Void_String_0;

		// Token: 0x04001A70 RID: 6768
		private static readonly IntPtr NativeMethodInfoPtr_LoadSchema_Private_Void_String_0;

		// Token: 0x04001A71 RID: 6769
		private static readonly IntPtr NativeMethodInfoPtr_get_HasSchema_Private_get_Boolean_0;

		// Token: 0x04001A72 RID: 6770
		private static readonly IntPtr NativeMethodInfoPtr_get_PreserveWhitespace_Public_Virtual_get_Boolean_0;

		// Token: 0x04001A73 RID: 6771
		private static readonly IntPtr NativeMethodInfoPtr_ProcessTokenizedType_Private_Void_XmlTokenizedType_String_0;

		// Token: 0x04001A74 RID: 6772
		private static readonly IntPtr NativeMethodInfoPtr_CompleteValidation_Public_Virtual_Void_0;

		// Token: 0x04001A75 RID: 6773
		private static readonly IntPtr NativeMethodInfoPtr_CheckValue_Private_Void_String_SchemaAttDef_0;

		// Token: 0x04001A76 RID: 6774
		private static readonly IntPtr NativeMethodInfoPtr_CheckDefaultValue_Public_Static_Void_String_SchemaAttDef_SchemaInfo_XmlNamespaceManager_XmlNameTable_Object_ValidationEventHandler_String_Int32_Int32_0;

		// Token: 0x04001A77 RID: 6775
		private static readonly IntPtr NativeMethodInfoPtr_AddID_Internal_Void_String_Object_0;

		// Token: 0x04001A78 RID: 6776
		private static readonly IntPtr NativeMethodInfoPtr_FindId_Public_Virtual_Object_String_0;

		// Token: 0x04001A79 RID: 6777
		private static readonly IntPtr NativeMethodInfoPtr_Push_Private_Void_XmlQualifiedName_0;

		// Token: 0x04001A7A RID: 6778
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Private_Void_0;

		// Token: 0x04001A7B RID: 6779
		private static readonly IntPtr NativeMethodInfoPtr_CheckForwardRefs_Private_Void_0;

		// Token: 0x04001A7C RID: 6780
		private static readonly IntPtr NativeMethodInfoPtr_QualifiedName_Private_XmlQualifiedName_String_String_0;
	}
}
