using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000047 RID: 71
	public sealed class XmlReaderSettings : Object
	{
		// Token: 0x0600059C RID: 1436 RVA: 0x0002E6AC File Offset: 0x0002C8AC
		// Note: this type is marked as 'beforefieldinit'.
		static XmlReaderSettings()
		{
			Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlReaderSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr);
			XmlReaderSettings.NativeFieldInfoPtr_useAsync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "useAsync");
			XmlReaderSettings.NativeFieldInfoPtr_nameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "nameTable");
			XmlReaderSettings.NativeFieldInfoPtr_xmlResolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "xmlResolver");
			XmlReaderSettings.NativeFieldInfoPtr_lineNumberOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "lineNumberOffset");
			XmlReaderSettings.NativeFieldInfoPtr_linePositionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "linePositionOffset");
			XmlReaderSettings.NativeFieldInfoPtr_conformanceLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "conformanceLevel");
			XmlReaderSettings.NativeFieldInfoPtr_checkCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "checkCharacters");
			XmlReaderSettings.NativeFieldInfoPtr_maxCharactersInDocument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "maxCharactersInDocument");
			XmlReaderSettings.NativeFieldInfoPtr_maxCharactersFromEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "maxCharactersFromEntities");
			XmlReaderSettings.NativeFieldInfoPtr_ignoreWhitespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "ignoreWhitespace");
			XmlReaderSettings.NativeFieldInfoPtr_ignorePIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "ignorePIs");
			XmlReaderSettings.NativeFieldInfoPtr_ignoreComments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "ignoreComments");
			XmlReaderSettings.NativeFieldInfoPtr_dtdProcessing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "dtdProcessing");
			XmlReaderSettings.NativeFieldInfoPtr_validationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "validationType");
			XmlReaderSettings.NativeFieldInfoPtr_validationFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "validationFlags");
			XmlReaderSettings.NativeFieldInfoPtr_schemas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "schemas");
			XmlReaderSettings.NativeFieldInfoPtr_valEventHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "valEventHandler");
			XmlReaderSettings.NativeFieldInfoPtr_closeInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "closeInput");
			XmlReaderSettings.NativeFieldInfoPtr_isReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "isReadOnly");
			XmlReaderSettings.NativeFieldInfoPtr__IsXmlResolverSet_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "<IsXmlResolverSet>k__BackingField");
			XmlReaderSettings.NativeFieldInfoPtr_s_enableLegacyXmlSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, "s_enableLegacyXmlSettings");
			XmlReaderSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664174);
			XmlReaderSettings.NativeMethodInfoPtr_get_Async_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664175);
			XmlReaderSettings.NativeMethodInfoPtr_set_Async_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664176);
			XmlReaderSettings.NativeMethodInfoPtr_get_NameTable_Public_get_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664177);
			XmlReaderSettings.NativeMethodInfoPtr_set_NameTable_Public_set_Void_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664178);
			XmlReaderSettings.NativeMethodInfoPtr_get_IsXmlResolverSet_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664179);
			XmlReaderSettings.NativeMethodInfoPtr_set_IsXmlResolverSet_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664180);
			XmlReaderSettings.NativeMethodInfoPtr_set_XmlResolver_Public_set_Void_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664181);
			XmlReaderSettings.NativeMethodInfoPtr_GetXmlResolver_Internal_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664182);
			XmlReaderSettings.NativeMethodInfoPtr_GetXmlResolver_CheckConfig_Internal_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664183);
			XmlReaderSettings.NativeMethodInfoPtr_get_LineNumberOffset_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664184);
			XmlReaderSettings.NativeMethodInfoPtr_set_LineNumberOffset_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664185);
			XmlReaderSettings.NativeMethodInfoPtr_get_LinePositionOffset_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664186);
			XmlReaderSettings.NativeMethodInfoPtr_set_LinePositionOffset_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664187);
			XmlReaderSettings.NativeMethodInfoPtr_get_ConformanceLevel_Public_get_ConformanceLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664188);
			XmlReaderSettings.NativeMethodInfoPtr_set_ConformanceLevel_Public_set_Void_ConformanceLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664189);
			XmlReaderSettings.NativeMethodInfoPtr_get_CheckCharacters_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664190);
			XmlReaderSettings.NativeMethodInfoPtr_set_CheckCharacters_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664191);
			XmlReaderSettings.NativeMethodInfoPtr_get_MaxCharactersInDocument_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664192);
			XmlReaderSettings.NativeMethodInfoPtr_set_MaxCharactersInDocument_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664193);
			XmlReaderSettings.NativeMethodInfoPtr_get_MaxCharactersFromEntities_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664194);
			XmlReaderSettings.NativeMethodInfoPtr_set_MaxCharactersFromEntities_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664195);
			XmlReaderSettings.NativeMethodInfoPtr_get_IgnoreWhitespace_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664196);
			XmlReaderSettings.NativeMethodInfoPtr_set_IgnoreWhitespace_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664197);
			XmlReaderSettings.NativeMethodInfoPtr_get_IgnoreProcessingInstructions_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664198);
			XmlReaderSettings.NativeMethodInfoPtr_set_IgnoreProcessingInstructions_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664199);
			XmlReaderSettings.NativeMethodInfoPtr_get_IgnoreComments_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664200);
			XmlReaderSettings.NativeMethodInfoPtr_set_IgnoreComments_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664201);
			XmlReaderSettings.NativeMethodInfoPtr_get_DtdProcessing_Public_get_DtdProcessing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664202);
			XmlReaderSettings.NativeMethodInfoPtr_set_DtdProcessing_Public_set_Void_DtdProcessing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664203);
			XmlReaderSettings.NativeMethodInfoPtr_get_CloseInput_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664204);
			XmlReaderSettings.NativeMethodInfoPtr_set_CloseInput_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664205);
			XmlReaderSettings.NativeMethodInfoPtr_get_ValidationType_Public_get_ValidationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664206);
			XmlReaderSettings.NativeMethodInfoPtr_set_ValidationType_Public_set_Void_ValidationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664207);
			XmlReaderSettings.NativeMethodInfoPtr_get_ValidationFlags_Public_get_XmlSchemaValidationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664208);
			XmlReaderSettings.NativeMethodInfoPtr_set_ValidationFlags_Public_set_Void_XmlSchemaValidationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664209);
			XmlReaderSettings.NativeMethodInfoPtr_get_Schemas_Public_get_XmlSchemaSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664210);
			XmlReaderSettings.NativeMethodInfoPtr_set_Schemas_Public_set_Void_XmlSchemaSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664211);
			XmlReaderSettings.NativeMethodInfoPtr_Clone_Public_XmlReaderSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664212);
			XmlReaderSettings.NativeMethodInfoPtr_GetEventHandler_Internal_ValidationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664213);
			XmlReaderSettings.NativeMethodInfoPtr_CreateReader_Internal_XmlReader_Stream_Uri_String_XmlParserContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664214);
			XmlReaderSettings.NativeMethodInfoPtr_CreateReader_Internal_XmlReader_TextReader_String_XmlParserContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664215);
			XmlReaderSettings.NativeMethodInfoPtr_set_ReadOnly_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664216);
			XmlReaderSettings.NativeMethodInfoPtr_CheckReadOnly_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664217);
			XmlReaderSettings.NativeMethodInfoPtr_Initialize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664218);
			XmlReaderSettings.NativeMethodInfoPtr_Initialize_Private_Void_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664219);
			XmlReaderSettings.NativeMethodInfoPtr_CreateDefaultResolver_Private_Static_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664220);
			XmlReaderSettings.NativeMethodInfoPtr_AddValidation_Internal_XmlReader_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664221);
			XmlReaderSettings.NativeMethodInfoPtr_CreateDtdValidatingReader_Private_XmlValidatingReaderImpl_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664222);
			XmlReaderSettings.NativeMethodInfoPtr_EnableLegacyXmlSettings_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr, 100664223);
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x0002EC68 File Offset: 0x0002CE68
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 366599, RefRangeEnd = 366610, XrefRangeStart = 366589, XrefRangeEnd = 366599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlReaderSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlReaderSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x0600059E RID: 1438 RVA: 0x0002ECA4 File Offset: 0x0002CEA4
		// (set) Token: 0x0600059F RID: 1439 RVA: 0x0002ECE0 File Offset: 0x0002CEE0
		public unsafe bool Async
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_get_Async_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366610, XrefRangeEnd = 366613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_Async_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060005A0 RID: 1440 RVA: 0x0002ED20 File Offset: 0x0002CF20
		// (set) Token: 0x060005A1 RID: 1441 RVA: 0x0002ED60 File Offset: 0x0002CF60
		public unsafe XmlNameTable NameTable
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_get_NameTable_Public_get_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 366617, RefRangeEnd = 366621, XrefRangeStart = 366613, XrefRangeEnd = 366617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_NameTable_Public_set_Void_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x0002EDA4 File Offset: 0x0002CFA4
		// (set) Token: 0x060005A3 RID: 1443 RVA: 0x0002EDE0 File Offset: 0x0002CFE0
		public unsafe bool IsXmlResolverSet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_get_IsXmlResolverSet_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_IsXmlResolverSet_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001AA RID: 426
		// (set) Token: 0x060005A4 RID: 1444 RVA: 0x0002EE20 File Offset: 0x0002D020
		public unsafe XmlResolver XmlResolver
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 366625, RefRangeEnd = 366632, XrefRangeStart = 366621, XrefRangeEnd = 366625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_XmlResolver_Public_set_Void_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x0002EE64 File Offset: 0x0002D064
		[CallerCount(0)]
		public unsafe XmlResolver GetXmlResolver()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_GetXmlResolver_Internal_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr3) : null;
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x0002EEA4 File Offset: 0x0002D0A4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 366633, RefRangeEnd = 366637, XrefRangeStart = 366632, XrefRangeEnd = 366633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlResolver GetXmlResolver_CheckConfig()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_GetXmlResolver_CheckConfig_Internal_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr3) : null;
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x0002EEE4 File Offset: 0x0002D0E4
		// (set) Token: 0x060005A8 RID: 1448 RVA: 0x0002EF20 File Offset: 0x0002D120
		public unsafe int LineNumberOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_get_LineNumberOffset_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 366640, RefRangeEnd = 366641, XrefRangeStart = 366637, XrefRangeEnd = 366640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_LineNumberOffset_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x0002EF60 File Offset: 0x0002D160
		// (set) Token: 0x060005AA RID: 1450 RVA: 0x0002EF9C File Offset: 0x0002D19C
		public unsafe int LinePositionOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_get_LinePositionOffset_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 366644, RefRangeEnd = 366645, XrefRangeStart = 366641, XrefRangeEnd = 366644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_LinePositionOffset_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x0002EFDC File Offset: 0x0002D1DC
		// (set) Token: 0x060005AC RID: 1452 RVA: 0x0002F018 File Offset: 0x0002D218
		public unsafe ConformanceLevel ConformanceLevel
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_get_ConformanceLevel_Public_get_ConformanceLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 366648, RefRangeEnd = 366653, XrefRangeStart = 366645, XrefRangeEnd = 366648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_ConformanceLevel_Public_set_Void_ConformanceLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060005AD RID: 1453 RVA: 0x0002F058 File Offset: 0x0002D258
		// (set) Token: 0x060005AE RID: 1454 RVA: 0x0002F094 File Offset: 0x0002D294
		public unsafe bool CheckCharacters
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_get_CheckCharacters_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 366656, RefRangeEnd = 366658, XrefRangeStart = 366653, XrefRangeEnd = 366656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_CheckCharacters_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x0002F0D4 File Offset: 0x0002D2D4
		// (set) Token: 0x060005B0 RID: 1456 RVA: 0x0002F110 File Offset: 0x0002D310
		public unsafe long MaxCharactersInDocument
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_get_MaxCharactersInDocument_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 366661, RefRangeEnd = 366662, XrefRangeStart = 366658, XrefRangeEnd = 366661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_MaxCharactersInDocument_Public_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x0002F150 File Offset: 0x0002D350
		// (set) Token: 0x060005B2 RID: 1458 RVA: 0x0002F18C File Offset: 0x0002D38C
		public unsafe long MaxCharactersFromEntities
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_get_MaxCharactersFromEntities_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 366665, RefRangeEnd = 366666, XrefRangeStart = 366662, XrefRangeEnd = 366665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_MaxCharactersFromEntities_Public_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x0002F1CC File Offset: 0x0002D3CC
		// (set) Token: 0x060005B4 RID: 1460 RVA: 0x0002F208 File Offset: 0x0002D408
		public unsafe bool IgnoreWhitespace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_get_IgnoreWhitespace_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 366669, RefRangeEnd = 366671, XrefRangeStart = 366666, XrefRangeEnd = 366669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_IgnoreWhitespace_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x0002F248 File Offset: 0x0002D448
		// (set) Token: 0x060005B6 RID: 1462 RVA: 0x0002F284 File Offset: 0x0002D484
		public unsafe bool IgnoreProcessingInstructions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_get_IgnoreProcessingInstructions_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 366674, RefRangeEnd = 366676, XrefRangeStart = 366671, XrefRangeEnd = 366674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_IgnoreProcessingInstructions_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x0002F2C4 File Offset: 0x0002D4C4
		// (set) Token: 0x060005B8 RID: 1464 RVA: 0x0002F300 File Offset: 0x0002D500
		public unsafe bool IgnoreComments
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_get_IgnoreComments_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 366679, RefRangeEnd = 366681, XrefRangeStart = 366676, XrefRangeEnd = 366679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_IgnoreComments_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x0002F340 File Offset: 0x0002D540
		// (set) Token: 0x060005BA RID: 1466 RVA: 0x0002F37C File Offset: 0x0002D57C
		public unsafe DtdProcessing DtdProcessing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_get_DtdProcessing_Public_get_DtdProcessing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 366684, RefRangeEnd = 366689, XrefRangeStart = 366681, XrefRangeEnd = 366684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_DtdProcessing_Public_set_Void_DtdProcessing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x060005BB RID: 1467 RVA: 0x0002F3BC File Offset: 0x0002D5BC
		// (set) Token: 0x060005BC RID: 1468 RVA: 0x0002F3F8 File Offset: 0x0002D5F8
		public unsafe bool CloseInput
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_get_CloseInput_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 366692, RefRangeEnd = 366697, XrefRangeStart = 366689, XrefRangeEnd = 366692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_CloseInput_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060005BD RID: 1469 RVA: 0x0002F438 File Offset: 0x0002D638
		// (set) Token: 0x060005BE RID: 1470 RVA: 0x0002F474 File Offset: 0x0002D674
		public unsafe ValidationType ValidationType
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 318242, RefRangeEnd = 318245, XrefRangeStart = 318242, XrefRangeEnd = 318245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_get_ValidationType_Public_get_ValidationType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 366700, RefRangeEnd = 366702, XrefRangeStart = 366697, XrefRangeEnd = 366700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_ValidationType_Public_set_Void_ValidationType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x060005BF RID: 1471 RVA: 0x0002F4B4 File Offset: 0x0002D6B4
		// (set) Token: 0x060005C0 RID: 1472 RVA: 0x0002F4F0 File Offset: 0x0002D6F0
		public unsafe XmlSchemaValidationFlags ValidationFlags
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 357464, RefRangeEnd = 357469, XrefRangeStart = 357464, XrefRangeEnd = 357469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_get_ValidationFlags_Public_get_XmlSchemaValidationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 366705, RefRangeEnd = 366707, XrefRangeStart = 366702, XrefRangeEnd = 366705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_ValidationFlags_Public_set_Void_XmlSchemaValidationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x0002F530 File Offset: 0x0002D730
		// (set) Token: 0x060005C2 RID: 1474 RVA: 0x0002F570 File Offset: 0x0002D770
		public unsafe XmlSchemaSet Schemas
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 366712, RefRangeEnd = 366714, XrefRangeStart = 366707, XrefRangeEnd = 366712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_get_Schemas_Public_get_XmlSchemaSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSet>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 366718, RefRangeEnd = 366719, XrefRangeStart = 366714, XrefRangeEnd = 366718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_Schemas_Public_set_Void_XmlSchemaSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x0002F5B4 File Offset: 0x0002D7B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 366722, RefRangeEnd = 366724, XrefRangeStart = 366719, XrefRangeEnd = 366722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlReaderSettings Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_Clone_Public_XmlReaderSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlReaderSettings>(intPtr3) : null;
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x0002F5F4 File Offset: 0x0002D7F4
		[CallerCount(0)]
		public unsafe ValidationEventHandler GetEventHandler()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_GetEventHandler_Internal_ValidationEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ValidationEventHandler>(intPtr3) : null;
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x0002F634 File Offset: 0x0002D834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366724, XrefRangeEnd = 366737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlReader CreateReader(Stream input, Uri baseUri, string baseUriString, XmlParserContext inputContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseUriString);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inputContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_CreateReader_Internal_XmlReader_Stream_Uri_String_XmlParserContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlReader>(intPtr3) : null;
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x0002F6BC File Offset: 0x0002D8BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366737, XrefRangeEnd = 366745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlReader CreateReader(TextReader input, string baseUriString, XmlParserContext inputContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseUriString);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inputContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_CreateReader_Internal_XmlReader_TextReader_String_XmlParserContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlReader>(intPtr3) : null;
		}

		// Token: 0x170001B9 RID: 441
		// (set) Token: 0x060005C7 RID: 1479 RVA: 0x0002F730 File Offset: 0x0002D930
		public unsafe bool ReadOnly
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_set_ReadOnly_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x0002F770 File Offset: 0x0002D970
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 366745, RefRangeEnd = 366763, XrefRangeStart = 366745, XrefRangeEnd = 366745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckReadOnly(string propertyName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_CheckReadOnly_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x0002F7B4 File Offset: 0x0002D9B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366763, XrefRangeEnd = 366772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_Initialize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x0002F7E8 File Offset: 0x0002D9E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366772, XrefRangeEnd = 366781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(XmlResolver resolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resolver);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_Initialize_Private_Void_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x0002F82C File Offset: 0x0002DA2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366781, XrefRangeEnd = 366785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlResolver CreateDefaultResolver()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_CreateDefaultResolver_Private_Static_XmlResolver_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr3) : null;
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x0002F860 File Offset: 0x0002DA60
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 366802, RefRangeEnd = 366807, XrefRangeStart = 366785, XrefRangeEnd = 366802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlReader AddValidation(XmlReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_AddValidation_Internal_XmlReader_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlReader>(intPtr3) : null;
			}
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x0002F8B0 File Offset: 0x0002DAB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 366807, XrefRangeEnd = 366811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlValidatingReaderImpl CreateDtdValidatingReader(XmlReader baseReader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseReader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_CreateDtdValidatingReader_Private_XmlValidatingReaderImpl_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlValidatingReaderImpl>(intPtr3) : null;
			}
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x0002F900 File Offset: 0x0002DB00
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 366823, RefRangeEnd = 366830, XrefRangeStart = 366811, XrefRangeEnd = 366823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EnableLegacyXmlSettings()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlReaderSettings.NativeMethodInfoPtr_EnableLegacyXmlSettings_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00003C88 File Offset: 0x00001E88
		public XmlReaderSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060005D0 RID: 1488 RVA: 0x0002F930 File Offset: 0x0002DB30
		// (set) Token: 0x060005D1 RID: 1489 RVA: 0x00003C91 File Offset: 0x00001E91
		public unsafe bool useAsync
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_useAsync);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_useAsync)) = value;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060005D2 RID: 1490 RVA: 0x0002F958 File Offset: 0x0002DB58
		// (set) Token: 0x060005D3 RID: 1491 RVA: 0x00003CAC File Offset: 0x00001EAC
		public unsafe XmlNameTable nameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_nameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_nameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060005D4 RID: 1492 RVA: 0x0002F988 File Offset: 0x0002DB88
		// (set) Token: 0x060005D5 RID: 1493 RVA: 0x00003CCB File Offset: 0x00001ECB
		public unsafe XmlResolver xmlResolver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_xmlResolver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_xmlResolver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060005D6 RID: 1494 RVA: 0x0002F9B8 File Offset: 0x0002DBB8
		// (set) Token: 0x060005D7 RID: 1495 RVA: 0x00003CEA File Offset: 0x00001EEA
		public unsafe int lineNumberOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_lineNumberOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_lineNumberOffset)) = value;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060005D8 RID: 1496 RVA: 0x0002F9E0 File Offset: 0x0002DBE0
		// (set) Token: 0x060005D9 RID: 1497 RVA: 0x00003D05 File Offset: 0x00001F05
		public unsafe int linePositionOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_linePositionOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_linePositionOffset)) = value;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060005DA RID: 1498 RVA: 0x0002FA08 File Offset: 0x0002DC08
		// (set) Token: 0x060005DB RID: 1499 RVA: 0x00003D20 File Offset: 0x00001F20
		public unsafe ConformanceLevel conformanceLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_conformanceLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_conformanceLevel)) = value;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060005DC RID: 1500 RVA: 0x0002FA30 File Offset: 0x0002DC30
		// (set) Token: 0x060005DD RID: 1501 RVA: 0x00003D3B File Offset: 0x00001F3B
		public unsafe bool checkCharacters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_checkCharacters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_checkCharacters)) = value;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060005DE RID: 1502 RVA: 0x0002FA58 File Offset: 0x0002DC58
		// (set) Token: 0x060005DF RID: 1503 RVA: 0x00003D56 File Offset: 0x00001F56
		public unsafe long maxCharactersInDocument
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_maxCharactersInDocument);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_maxCharactersInDocument)) = value;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060005E0 RID: 1504 RVA: 0x0002FA80 File Offset: 0x0002DC80
		// (set) Token: 0x060005E1 RID: 1505 RVA: 0x00003D71 File Offset: 0x00001F71
		public unsafe long maxCharactersFromEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_maxCharactersFromEntities);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_maxCharactersFromEntities)) = value;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060005E2 RID: 1506 RVA: 0x0002FAA8 File Offset: 0x0002DCA8
		// (set) Token: 0x060005E3 RID: 1507 RVA: 0x00003D8C File Offset: 0x00001F8C
		public unsafe bool ignoreWhitespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_ignoreWhitespace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_ignoreWhitespace)) = value;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060005E4 RID: 1508 RVA: 0x0002FAD0 File Offset: 0x0002DCD0
		// (set) Token: 0x060005E5 RID: 1509 RVA: 0x00003DA7 File Offset: 0x00001FA7
		public unsafe bool ignorePIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_ignorePIs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_ignorePIs)) = value;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060005E6 RID: 1510 RVA: 0x0002FAF8 File Offset: 0x0002DCF8
		// (set) Token: 0x060005E7 RID: 1511 RVA: 0x00003DC2 File Offset: 0x00001FC2
		public unsafe bool ignoreComments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_ignoreComments);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_ignoreComments)) = value;
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x0002FB20 File Offset: 0x0002DD20
		// (set) Token: 0x060005E9 RID: 1513 RVA: 0x00003DDD File Offset: 0x00001FDD
		public unsafe DtdProcessing dtdProcessing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_dtdProcessing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_dtdProcessing)) = value;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060005EA RID: 1514 RVA: 0x0002FB48 File Offset: 0x0002DD48
		// (set) Token: 0x060005EB RID: 1515 RVA: 0x00003DF8 File Offset: 0x00001FF8
		public unsafe ValidationType validationType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_validationType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_validationType)) = value;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060005EC RID: 1516 RVA: 0x0002FB70 File Offset: 0x0002DD70
		// (set) Token: 0x060005ED RID: 1517 RVA: 0x00003E13 File Offset: 0x00002013
		public unsafe XmlSchemaValidationFlags validationFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_validationFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_validationFlags)) = value;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060005EE RID: 1518 RVA: 0x0002FB98 File Offset: 0x0002DD98
		// (set) Token: 0x060005EF RID: 1519 RVA: 0x00003E2E File Offset: 0x0000202E
		public unsafe XmlSchemaSet schemas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_schemas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_schemas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060005F0 RID: 1520 RVA: 0x0002FBC8 File Offset: 0x0002DDC8
		// (set) Token: 0x060005F1 RID: 1521 RVA: 0x00003E4D File Offset: 0x0000204D
		public unsafe ValidationEventHandler valEventHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_valEventHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidationEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_valEventHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x0002FBF8 File Offset: 0x0002DDF8
		// (set) Token: 0x060005F3 RID: 1523 RVA: 0x00003E6C File Offset: 0x0000206C
		public unsafe bool closeInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_closeInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_closeInput)) = value;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060005F4 RID: 1524 RVA: 0x0002FC20 File Offset: 0x0002DE20
		// (set) Token: 0x060005F5 RID: 1525 RVA: 0x00003E87 File Offset: 0x00002087
		public unsafe bool isReadOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_isReadOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr_isReadOnly)) = value;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060005F6 RID: 1526 RVA: 0x0002FC48 File Offset: 0x0002DE48
		// (set) Token: 0x060005F7 RID: 1527 RVA: 0x00003EA2 File Offset: 0x000020A2
		public unsafe bool _IsXmlResolverSet_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr__IsXmlResolverSet_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlReaderSettings.NativeFieldInfoPtr__IsXmlResolverSet_k__BackingField)) = value;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060005F8 RID: 1528 RVA: 0x0002FC70 File Offset: 0x0002DE70
		// (set) Token: 0x060005F9 RID: 1529 RVA: 0x00003EBD File Offset: 0x000020BD
		public unsafe static Nullable<bool> s_enableLegacyXmlSettings
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(XmlReaderSettings.NativeFieldInfoPtr_s_enableLegacyXmlSettings, intPtr);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlReaderSettings.NativeFieldInfoPtr_s_enableLegacyXmlSettings, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x040004B9 RID: 1209
		private static readonly IntPtr NativeFieldInfoPtr_useAsync;

		// Token: 0x040004BA RID: 1210
		private static readonly IntPtr NativeFieldInfoPtr_nameTable;

		// Token: 0x040004BB RID: 1211
		private static readonly IntPtr NativeFieldInfoPtr_xmlResolver;

		// Token: 0x040004BC RID: 1212
		private static readonly IntPtr NativeFieldInfoPtr_lineNumberOffset;

		// Token: 0x040004BD RID: 1213
		private static readonly IntPtr NativeFieldInfoPtr_linePositionOffset;

		// Token: 0x040004BE RID: 1214
		private static readonly IntPtr NativeFieldInfoPtr_conformanceLevel;

		// Token: 0x040004BF RID: 1215
		private static readonly IntPtr NativeFieldInfoPtr_checkCharacters;

		// Token: 0x040004C0 RID: 1216
		private static readonly IntPtr NativeFieldInfoPtr_maxCharactersInDocument;

		// Token: 0x040004C1 RID: 1217
		private static readonly IntPtr NativeFieldInfoPtr_maxCharactersFromEntities;

		// Token: 0x040004C2 RID: 1218
		private static readonly IntPtr NativeFieldInfoPtr_ignoreWhitespace;

		// Token: 0x040004C3 RID: 1219
		private static readonly IntPtr NativeFieldInfoPtr_ignorePIs;

		// Token: 0x040004C4 RID: 1220
		private static readonly IntPtr NativeFieldInfoPtr_ignoreComments;

		// Token: 0x040004C5 RID: 1221
		private static readonly IntPtr NativeFieldInfoPtr_dtdProcessing;

		// Token: 0x040004C6 RID: 1222
		private static readonly IntPtr NativeFieldInfoPtr_validationType;

		// Token: 0x040004C7 RID: 1223
		private static readonly IntPtr NativeFieldInfoPtr_validationFlags;

		// Token: 0x040004C8 RID: 1224
		private static readonly IntPtr NativeFieldInfoPtr_schemas;

		// Token: 0x040004C9 RID: 1225
		private static readonly IntPtr NativeFieldInfoPtr_valEventHandler;

		// Token: 0x040004CA RID: 1226
		private static readonly IntPtr NativeFieldInfoPtr_closeInput;

		// Token: 0x040004CB RID: 1227
		private static readonly IntPtr NativeFieldInfoPtr_isReadOnly;

		// Token: 0x040004CC RID: 1228
		private static readonly IntPtr NativeFieldInfoPtr__IsXmlResolverSet_k__BackingField;

		// Token: 0x040004CD RID: 1229
		private static readonly IntPtr NativeFieldInfoPtr_s_enableLegacyXmlSettings;

		// Token: 0x040004CE RID: 1230
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040004CF RID: 1231
		private static readonly IntPtr NativeMethodInfoPtr_get_Async_Public_get_Boolean_0;

		// Token: 0x040004D0 RID: 1232
		private static readonly IntPtr NativeMethodInfoPtr_set_Async_Public_set_Void_Boolean_0;

		// Token: 0x040004D1 RID: 1233
		private static readonly IntPtr NativeMethodInfoPtr_get_NameTable_Public_get_XmlNameTable_0;

		// Token: 0x040004D2 RID: 1234
		private static readonly IntPtr NativeMethodInfoPtr_set_NameTable_Public_set_Void_XmlNameTable_0;

		// Token: 0x040004D3 RID: 1235
		private static readonly IntPtr NativeMethodInfoPtr_get_IsXmlResolverSet_Internal_get_Boolean_0;

		// Token: 0x040004D4 RID: 1236
		private static readonly IntPtr NativeMethodInfoPtr_set_IsXmlResolverSet_Internal_set_Void_Boolean_0;

		// Token: 0x040004D5 RID: 1237
		private static readonly IntPtr NativeMethodInfoPtr_set_XmlResolver_Public_set_Void_XmlResolver_0;

		// Token: 0x040004D6 RID: 1238
		private static readonly IntPtr NativeMethodInfoPtr_GetXmlResolver_Internal_XmlResolver_0;

		// Token: 0x040004D7 RID: 1239
		private static readonly IntPtr NativeMethodInfoPtr_GetXmlResolver_CheckConfig_Internal_XmlResolver_0;

		// Token: 0x040004D8 RID: 1240
		private static readonly IntPtr NativeMethodInfoPtr_get_LineNumberOffset_Public_get_Int32_0;

		// Token: 0x040004D9 RID: 1241
		private static readonly IntPtr NativeMethodInfoPtr_set_LineNumberOffset_Public_set_Void_Int32_0;

		// Token: 0x040004DA RID: 1242
		private static readonly IntPtr NativeMethodInfoPtr_get_LinePositionOffset_Public_get_Int32_0;

		// Token: 0x040004DB RID: 1243
		private static readonly IntPtr NativeMethodInfoPtr_set_LinePositionOffset_Public_set_Void_Int32_0;

		// Token: 0x040004DC RID: 1244
		private static readonly IntPtr NativeMethodInfoPtr_get_ConformanceLevel_Public_get_ConformanceLevel_0;

		// Token: 0x040004DD RID: 1245
		private static readonly IntPtr NativeMethodInfoPtr_set_ConformanceLevel_Public_set_Void_ConformanceLevel_0;

		// Token: 0x040004DE RID: 1246
		private static readonly IntPtr NativeMethodInfoPtr_get_CheckCharacters_Public_get_Boolean_0;

		// Token: 0x040004DF RID: 1247
		private static readonly IntPtr NativeMethodInfoPtr_set_CheckCharacters_Public_set_Void_Boolean_0;

		// Token: 0x040004E0 RID: 1248
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxCharactersInDocument_Public_get_Int64_0;

		// Token: 0x040004E1 RID: 1249
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxCharactersInDocument_Public_set_Void_Int64_0;

		// Token: 0x040004E2 RID: 1250
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxCharactersFromEntities_Public_get_Int64_0;

		// Token: 0x040004E3 RID: 1251
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxCharactersFromEntities_Public_set_Void_Int64_0;

		// Token: 0x040004E4 RID: 1252
		private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreWhitespace_Public_get_Boolean_0;

		// Token: 0x040004E5 RID: 1253
		private static readonly IntPtr NativeMethodInfoPtr_set_IgnoreWhitespace_Public_set_Void_Boolean_0;

		// Token: 0x040004E6 RID: 1254
		private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreProcessingInstructions_Public_get_Boolean_0;

		// Token: 0x040004E7 RID: 1255
		private static readonly IntPtr NativeMethodInfoPtr_set_IgnoreProcessingInstructions_Public_set_Void_Boolean_0;

		// Token: 0x040004E8 RID: 1256
		private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreComments_Public_get_Boolean_0;

		// Token: 0x040004E9 RID: 1257
		private static readonly IntPtr NativeMethodInfoPtr_set_IgnoreComments_Public_set_Void_Boolean_0;

		// Token: 0x040004EA RID: 1258
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdProcessing_Public_get_DtdProcessing_0;

		// Token: 0x040004EB RID: 1259
		private static readonly IntPtr NativeMethodInfoPtr_set_DtdProcessing_Public_set_Void_DtdProcessing_0;

		// Token: 0x040004EC RID: 1260
		private static readonly IntPtr NativeMethodInfoPtr_get_CloseInput_Public_get_Boolean_0;

		// Token: 0x040004ED RID: 1261
		private static readonly IntPtr NativeMethodInfoPtr_set_CloseInput_Public_set_Void_Boolean_0;

		// Token: 0x040004EE RID: 1262
		private static readonly IntPtr NativeMethodInfoPtr_get_ValidationType_Public_get_ValidationType_0;

		// Token: 0x040004EF RID: 1263
		private static readonly IntPtr NativeMethodInfoPtr_set_ValidationType_Public_set_Void_ValidationType_0;

		// Token: 0x040004F0 RID: 1264
		private static readonly IntPtr NativeMethodInfoPtr_get_ValidationFlags_Public_get_XmlSchemaValidationFlags_0;

		// Token: 0x040004F1 RID: 1265
		private static readonly IntPtr NativeMethodInfoPtr_set_ValidationFlags_Public_set_Void_XmlSchemaValidationFlags_0;

		// Token: 0x040004F2 RID: 1266
		private static readonly IntPtr NativeMethodInfoPtr_get_Schemas_Public_get_XmlSchemaSet_0;

		// Token: 0x040004F3 RID: 1267
		private static readonly IntPtr NativeMethodInfoPtr_set_Schemas_Public_set_Void_XmlSchemaSet_0;

		// Token: 0x040004F4 RID: 1268
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_XmlReaderSettings_0;

		// Token: 0x040004F5 RID: 1269
		private static readonly IntPtr NativeMethodInfoPtr_GetEventHandler_Internal_ValidationEventHandler_0;

		// Token: 0x040004F6 RID: 1270
		private static readonly IntPtr NativeMethodInfoPtr_CreateReader_Internal_XmlReader_Stream_Uri_String_XmlParserContext_0;

		// Token: 0x040004F7 RID: 1271
		private static readonly IntPtr NativeMethodInfoPtr_CreateReader_Internal_XmlReader_TextReader_String_XmlParserContext_0;

		// Token: 0x040004F8 RID: 1272
		private static readonly IntPtr NativeMethodInfoPtr_set_ReadOnly_Internal_set_Void_Boolean_0;

		// Token: 0x040004F9 RID: 1273
		private static readonly IntPtr NativeMethodInfoPtr_CheckReadOnly_Private_Void_String_0;

		// Token: 0x040004FA RID: 1274
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_0;

		// Token: 0x040004FB RID: 1275
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_XmlResolver_0;

		// Token: 0x040004FC RID: 1276
		private static readonly IntPtr NativeMethodInfoPtr_CreateDefaultResolver_Private_Static_XmlResolver_0;

		// Token: 0x040004FD RID: 1277
		private static readonly IntPtr NativeMethodInfoPtr_AddValidation_Internal_XmlReader_XmlReader_0;

		// Token: 0x040004FE RID: 1278
		private static readonly IntPtr NativeMethodInfoPtr_CreateDtdValidatingReader_Private_XmlValidatingReaderImpl_XmlReader_0;

		// Token: 0x040004FF RID: 1279
		private static readonly IntPtr NativeMethodInfoPtr_EnableLegacyXmlSettings_Internal_Static_Boolean_0;
	}
}
