using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000109 RID: 265
	public class BaseValidator : Object
	{
		// Token: 0x060017C9 RID: 6089 RVA: 0x0007BF70 File Offset: 0x0007A170
		// Note: this type is marked as 'beforefieldinit'.
		static BaseValidator()
		{
			Il2CppClassPointerStore<BaseValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "BaseValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr);
			BaseValidator.NativeFieldInfoPtr_schemaCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, "schemaCollection");
			BaseValidator.NativeFieldInfoPtr_eventHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, "eventHandling");
			BaseValidator.NativeFieldInfoPtr_nameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, "nameTable");
			BaseValidator.NativeFieldInfoPtr_schemaNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, "schemaNames");
			BaseValidator.NativeFieldInfoPtr_positionInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, "positionInfo");
			BaseValidator.NativeFieldInfoPtr_xmlResolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, "xmlResolver");
			BaseValidator.NativeFieldInfoPtr_baseUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, "baseUri");
			BaseValidator.NativeFieldInfoPtr_schemaInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, "schemaInfo");
			BaseValidator.NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, "reader");
			BaseValidator.NativeFieldInfoPtr_elementName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, "elementName");
			BaseValidator.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, "context");
			BaseValidator.NativeFieldInfoPtr_textValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, "textValue");
			BaseValidator.NativeFieldInfoPtr_textString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, "textString");
			BaseValidator.NativeFieldInfoPtr_hasSibling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, "hasSibling");
			BaseValidator.NativeFieldInfoPtr_checkDatatype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, "checkDatatype");
			BaseValidator.NativeMethodInfoPtr__ctor_Public_Void_BaseValidator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100667015);
			BaseValidator.NativeMethodInfoPtr__ctor_Public_Void_XmlValidatingReaderImpl_XmlSchemaCollection_IValidationEventHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100667016);
			BaseValidator.NativeMethodInfoPtr_get_Reader_Public_get_XmlValidatingReaderImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100667017);
			BaseValidator.NativeMethodInfoPtr_get_SchemaCollection_Public_get_XmlSchemaCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100667018);
			BaseValidator.NativeMethodInfoPtr_get_NameTable_Public_get_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100667019);
			BaseValidator.NativeMethodInfoPtr_get_SchemaNames_Public_get_SchemaNames_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100667020);
			BaseValidator.NativeMethodInfoPtr_get_PositionInfo_Public_get_PositionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100667021);
			BaseValidator.NativeMethodInfoPtr_get_XmlResolver_Public_get_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100667022);
			BaseValidator.NativeMethodInfoPtr_set_XmlResolver_Public_set_Void_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100667023);
			BaseValidator.NativeMethodInfoPtr_get_BaseUri_Public_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100667024);
			BaseValidator.NativeMethodInfoPtr_set_BaseUri_Public_set_Void_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100667025);
			BaseValidator.NativeMethodInfoPtr_get_EventHandler_Public_get_ValidationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100667026);
			BaseValidator.NativeMethodInfoPtr_get_SchemaInfo_Public_get_SchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100667027);
			BaseValidator.NativeMethodInfoPtr_set_DtdInfo_Public_set_Void_IDtdInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100667028);
			BaseValidator.NativeMethodInfoPtr_get_PreserveWhitespace_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100667029);
			BaseValidator.NativeMethodInfoPtr_Validate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100667030);
			BaseValidator.NativeMethodInfoPtr_CompleteValidation_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100667031);
			BaseValidator.NativeMethodInfoPtr_FindId_Public_Virtual_New_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100667032);
			BaseValidator.NativeMethodInfoPtr_ValidateText_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100667033);
			BaseValidator.NativeMethodInfoPtr_ValidateWhitespace_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100667034);
			BaseValidator.NativeMethodInfoPtr_SaveTextValue_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100667035);
			BaseValidator.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100667036);
			BaseValidator.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100667037);
			BaseValidator.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100667038);
			BaseValidator.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_XmlSchemaException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100667039);
			BaseValidator.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_String_XmlSeverityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100667040);
			BaseValidator.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_Il2CppStringArray_XmlSeverityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100667041);
			BaseValidator.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_XmlSchemaException_XmlSeverityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100667042);
			BaseValidator.NativeMethodInfoPtr_ProcessEntity_Protected_Static_Void_SchemaInfo_String_Object_ValidationEventHandler_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100667043);
			BaseValidator.NativeMethodInfoPtr_ProcessEntity_Protected_Static_Void_SchemaInfo_String_IValidationEventHandling_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100667044);
			BaseValidator.NativeMethodInfoPtr_CreateInstance_Public_Static_BaseValidator_ValidationType_XmlValidatingReaderImpl_XmlSchemaCollection_IValidationEventHandling_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr, 100667045);
		}

		// Token: 0x060017CA RID: 6090 RVA: 0x0007C338 File Offset: 0x0007A538
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 391373, RefRangeEnd = 391375, XrefRangeStart = 391362, XrefRangeEnd = 391373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseValidator(BaseValidator other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr__ctor_Public_Void_BaseValidator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017CB RID: 6091 RVA: 0x0007C384 File Offset: 0x0007A584
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 391388, RefRangeEnd = 391394, XrefRangeStart = 391375, XrefRangeEnd = 391388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseValidator(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseValidator>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr__ctor_Public_Void_XmlValidatingReaderImpl_XmlSchemaCollection_IValidationEventHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x060017CC RID: 6092 RVA: 0x0007C3F4 File Offset: 0x0007A5F4
		public unsafe XmlValidatingReaderImpl Reader
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_get_Reader_Public_get_XmlValidatingReaderImpl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlValidatingReaderImpl>(intPtr3) : null;
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x060017CD RID: 6093 RVA: 0x0007C434 File Offset: 0x0007A634
		public unsafe XmlSchemaCollection SchemaCollection
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_get_SchemaCollection_Public_get_XmlSchemaCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaCollection>(intPtr3) : null;
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x060017CE RID: 6094 RVA: 0x0007C474 File Offset: 0x0007A674
		public unsafe XmlNameTable NameTable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_get_NameTable_Public_get_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr3) : null;
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x060017CF RID: 6095 RVA: 0x0007C4B4 File Offset: 0x0007A6B4
		public unsafe SchemaNames SchemaNames
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 391401, RefRangeEnd = 391418, XrefRangeStart = 391394, XrefRangeEnd = 391401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_get_SchemaNames_Public_get_SchemaNames_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaNames>(intPtr3) : null;
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x060017D0 RID: 6096 RVA: 0x0007C4F4 File Offset: 0x0007A6F4
		public unsafe PositionInfo PositionInfo
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_get_PositionInfo_Public_get_PositionInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PositionInfo>(intPtr3) : null;
			}
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x060017D1 RID: 6097 RVA: 0x0007C534 File Offset: 0x0007A734
		// (set) Token: 0x060017D2 RID: 6098 RVA: 0x0007C574 File Offset: 0x0007A774
		public unsafe XmlResolver XmlResolver
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_get_XmlResolver_Public_get_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_set_XmlResolver_Public_set_Void_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x060017D3 RID: 6099 RVA: 0x0007C5B8 File Offset: 0x0007A7B8
		// (set) Token: 0x060017D4 RID: 6100 RVA: 0x0007C5F8 File Offset: 0x0007A7F8
		public unsafe Uri BaseUri
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_get_BaseUri_Public_get_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_set_BaseUri_Public_set_Void_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x060017D5 RID: 6101 RVA: 0x0007C63C File Offset: 0x0007A83C
		public unsafe ValidationEventHandler EventHandler
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 391423, RefRangeEnd = 391445, XrefRangeStart = 391418, XrefRangeEnd = 391423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_get_EventHandler_Public_get_ValidationEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ValidationEventHandler>(intPtr3) : null;
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x060017D6 RID: 6102 RVA: 0x0007C67C File Offset: 0x0007A87C
		public unsafe SchemaInfo SchemaInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_get_SchemaInfo_Public_get_SchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaInfo>(intPtr3) : null;
			}
		}

		// Token: 0x170007BE RID: 1982
		// (set) Token: 0x060017D7 RID: 6103 RVA: 0x0007C6BC File Offset: 0x0007A8BC
		public unsafe IDtdInfo DtdInfo
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391445, XrefRangeEnd = 391457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_set_DtdInfo_Public_set_Void_IDtdInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x060017D8 RID: 6104 RVA: 0x0007C700 File Offset: 0x0007A900
		public unsafe virtual bool PreserveWhitespace
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseValidator.NativeMethodInfoPtr_get_PreserveWhitespace_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017D9 RID: 6105 RVA: 0x0007C748 File Offset: 0x0007A948
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Validate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseValidator.NativeMethodInfoPtr_Validate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017DA RID: 6106 RVA: 0x0007C784 File Offset: 0x0007A984
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CompleteValidation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseValidator.NativeMethodInfoPtr_CompleteValidation_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017DB RID: 6107 RVA: 0x0007C7C0 File Offset: 0x0007A9C0
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object FindId(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseValidator.NativeMethodInfoPtr_FindId_Public_Virtual_New_Object_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060017DC RID: 6108 RVA: 0x0007C81C File Offset: 0x0007AA1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 391488, RefRangeEnd = 391490, XrefRangeStart = 391457, XrefRangeEnd = 391488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_ValidateText_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017DD RID: 6109 RVA: 0x0007C850 File Offset: 0x0007AA50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 391503, RefRangeEnd = 391505, XrefRangeStart = 391490, XrefRangeEnd = 391503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateWhitespace()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_ValidateWhitespace_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017DE RID: 6110 RVA: 0x0007C884 File Offset: 0x0007AA84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 391509, RefRangeEnd = 391511, XrefRangeStart = 391505, XrefRangeEnd = 391509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveTextValue(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_SaveTextValue_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017DF RID: 6111 RVA: 0x0007C8C8 File Offset: 0x0007AAC8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 391514, RefRangeEnd = 391520, XrefRangeStart = 391511, XrefRangeEnd = 391514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(string code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017E0 RID: 6112 RVA: 0x0007C90C File Offset: 0x0007AB0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 391526, RefRangeEnd = 391527, XrefRangeStart = 391520, XrefRangeEnd = 391526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(string code, Il2CppStringArray args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x0007C960 File Offset: 0x0007AB60
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 391533, RefRangeEnd = 391563, XrefRangeStart = 391527, XrefRangeEnd = 391533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(string code, string arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017E2 RID: 6114 RVA: 0x0007C9B4 File Offset: 0x0007ABB4
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 391566, RefRangeEnd = 391583, XrefRangeStart = 391563, XrefRangeEnd = 391566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(XmlSchemaException e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_XmlSchemaException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017E3 RID: 6115 RVA: 0x0007C9F8 File Offset: 0x0007ABF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 391589, RefRangeEnd = 391591, XrefRangeStart = 391583, XrefRangeEnd = 391589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(string code, string msg, XmlSeverityType severity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(msg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref severity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_String_XmlSeverityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017E4 RID: 6116 RVA: 0x0007CA5C File Offset: 0x0007AC5C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 391597, RefRangeEnd = 391602, XrefRangeStart = 391591, XrefRangeEnd = 391597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(string code, Il2CppStringArray args, XmlSeverityType severity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref severity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_Il2CppStringArray_XmlSeverityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017E5 RID: 6117 RVA: 0x0007CAC0 File Offset: 0x0007ACC0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 391606, RefRangeEnd = 391609, XrefRangeStart = 391602, XrefRangeEnd = 391606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref severity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_SendValidationEvent_Protected_Void_XmlSchemaException_XmlSeverityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017E6 RID: 6118 RVA: 0x0007CB10 File Offset: 0x0007AD10
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 391633, RefRangeEnd = 391638, XrefRangeStart = 391609, XrefRangeEnd = 391633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ProcessEntity(SchemaInfo sinfo, string name, Object sender, ValidationEventHandler eventhandler, string baseUri, int lineNumber, int linePosition)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sinfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventhandler);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseUri);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNumber;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_ProcessEntity_Protected_Static_Void_SchemaInfo_String_Object_ValidationEventHandler_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017E7 RID: 6119 RVA: 0x0007CBAC File Offset: 0x0007ADAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 391659, RefRangeEnd = 391661, XrefRangeStart = 391638, XrefRangeEnd = 391659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ProcessEntity(SchemaInfo sinfo, string name, IValidationEventHandling eventHandling, string baseUriStr, int lineNumber, int linePosition)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sinfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventHandling);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseUriStr);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNumber;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_ProcessEntity_Protected_Static_Void_SchemaInfo_String_IValidationEventHandling_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017E8 RID: 6120 RVA: 0x0007CC34 File Offset: 0x0007AE34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 391691, RefRangeEnd = 391692, XrefRangeStart = 391661, XrefRangeEnd = 391691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BaseValidator CreateInstance(ValidationType valType, XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling, bool processIdentityConstraints)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref valType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaCollection);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventHandling);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref processIdentityConstraints;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseValidator.NativeMethodInfoPtr_CreateInstance_Public_Static_BaseValidator_ValidationType_XmlValidatingReaderImpl_XmlSchemaCollection_IValidationEventHandling_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseValidator>(intPtr3) : null;
		}

		// Token: 0x060017E9 RID: 6121 RVA: 0x0000A253 File Offset: 0x00008453
		public BaseValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x060017EA RID: 6122 RVA: 0x0007CCB8 File Offset: 0x0007AEB8
		// (set) Token: 0x060017EB RID: 6123 RVA: 0x0000A25C File Offset: 0x0000845C
		public unsafe XmlSchemaCollection schemaCollection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_schemaCollection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_schemaCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x060017EC RID: 6124 RVA: 0x0007CCE8 File Offset: 0x0007AEE8
		// (set) Token: 0x060017ED RID: 6125 RVA: 0x0000A27B File Offset: 0x0000847B
		public unsafe IValidationEventHandling eventHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_eventHandling);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IValidationEventHandling>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_eventHandling), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x060017EE RID: 6126 RVA: 0x0007CD18 File Offset: 0x0007AF18
		// (set) Token: 0x060017EF RID: 6127 RVA: 0x0000A29A File Offset: 0x0000849A
		public unsafe XmlNameTable nameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_nameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_nameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x060017F0 RID: 6128 RVA: 0x0007CD48 File Offset: 0x0007AF48
		// (set) Token: 0x060017F1 RID: 6129 RVA: 0x0000A2B9 File Offset: 0x000084B9
		public unsafe SchemaNames schemaNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_schemaNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaNames>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_schemaNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x060017F2 RID: 6130 RVA: 0x0007CD78 File Offset: 0x0007AF78
		// (set) Token: 0x060017F3 RID: 6131 RVA: 0x0000A2D8 File Offset: 0x000084D8
		public unsafe PositionInfo positionInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_positionInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PositionInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_positionInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x060017F4 RID: 6132 RVA: 0x0007CDA8 File Offset: 0x0007AFA8
		// (set) Token: 0x060017F5 RID: 6133 RVA: 0x0000A2F7 File Offset: 0x000084F7
		public unsafe XmlResolver xmlResolver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_xmlResolver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_xmlResolver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x060017F6 RID: 6134 RVA: 0x0007CDD8 File Offset: 0x0007AFD8
		// (set) Token: 0x060017F7 RID: 6135 RVA: 0x0000A316 File Offset: 0x00008516
		public unsafe Uri baseUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_baseUri);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_baseUri), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x060017F8 RID: 6136 RVA: 0x0007CE08 File Offset: 0x0007B008
		// (set) Token: 0x060017F9 RID: 6137 RVA: 0x0000A335 File Offset: 0x00008535
		public unsafe SchemaInfo schemaInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_schemaInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_schemaInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x060017FA RID: 6138 RVA: 0x0007CE38 File Offset: 0x0007B038
		// (set) Token: 0x060017FB RID: 6139 RVA: 0x0000A354 File Offset: 0x00008554
		public unsafe XmlValidatingReaderImpl reader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_reader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlValidatingReaderImpl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_reader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x060017FC RID: 6140 RVA: 0x0007CE68 File Offset: 0x0007B068
		// (set) Token: 0x060017FD RID: 6141 RVA: 0x0000A373 File Offset: 0x00008573
		public unsafe XmlQualifiedName elementName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_elementName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_elementName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x060017FE RID: 6142 RVA: 0x0007CE98 File Offset: 0x0007B098
		// (set) Token: 0x060017FF RID: 6143 RVA: 0x0000A392 File Offset: 0x00008592
		public unsafe ValidationState context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_context);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidationState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06001800 RID: 6144 RVA: 0x0007CEC8 File Offset: 0x0007B0C8
		// (set) Token: 0x06001801 RID: 6145 RVA: 0x0000A3B1 File Offset: 0x000085B1
		public unsafe StringBuilder textValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_textValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_textValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06001802 RID: 6146 RVA: 0x0007CEF8 File Offset: 0x0007B0F8
		// (set) Token: 0x06001803 RID: 6147 RVA: 0x0000A3D0 File Offset: 0x000085D0
		public unsafe string textString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_textString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_textString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06001804 RID: 6148 RVA: 0x0007CF20 File Offset: 0x0007B120
		// (set) Token: 0x06001805 RID: 6149 RVA: 0x0000A3EF File Offset: 0x000085EF
		public unsafe bool hasSibling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_hasSibling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_hasSibling)) = value;
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06001806 RID: 6150 RVA: 0x0007CF48 File Offset: 0x0007B148
		// (set) Token: 0x06001807 RID: 6151 RVA: 0x0000A40A File Offset: 0x0000860A
		public unsafe bool checkDatatype
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_checkDatatype);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseValidator.NativeFieldInfoPtr_checkDatatype)) = value;
			}
		}

		// Token: 0x040012B1 RID: 4785
		private static readonly IntPtr NativeFieldInfoPtr_schemaCollection;

		// Token: 0x040012B2 RID: 4786
		private static readonly IntPtr NativeFieldInfoPtr_eventHandling;

		// Token: 0x040012B3 RID: 4787
		private static readonly IntPtr NativeFieldInfoPtr_nameTable;

		// Token: 0x040012B4 RID: 4788
		private static readonly IntPtr NativeFieldInfoPtr_schemaNames;

		// Token: 0x040012B5 RID: 4789
		private static readonly IntPtr NativeFieldInfoPtr_positionInfo;

		// Token: 0x040012B6 RID: 4790
		private static readonly IntPtr NativeFieldInfoPtr_xmlResolver;

		// Token: 0x040012B7 RID: 4791
		private static readonly IntPtr NativeFieldInfoPtr_baseUri;

		// Token: 0x040012B8 RID: 4792
		private static readonly IntPtr NativeFieldInfoPtr_schemaInfo;

		// Token: 0x040012B9 RID: 4793
		private static readonly IntPtr NativeFieldInfoPtr_reader;

		// Token: 0x040012BA RID: 4794
		private static readonly IntPtr NativeFieldInfoPtr_elementName;

		// Token: 0x040012BB RID: 4795
		private static readonly IntPtr NativeFieldInfoPtr_context;

		// Token: 0x040012BC RID: 4796
		private static readonly IntPtr NativeFieldInfoPtr_textValue;

		// Token: 0x040012BD RID: 4797
		private static readonly IntPtr NativeFieldInfoPtr_textString;

		// Token: 0x040012BE RID: 4798
		private static readonly IntPtr NativeFieldInfoPtr_hasSibling;

		// Token: 0x040012BF RID: 4799
		private static readonly IntPtr NativeFieldInfoPtr_checkDatatype;

		// Token: 0x040012C0 RID: 4800
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BaseValidator_0;

		// Token: 0x040012C1 RID: 4801
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlValidatingReaderImpl_XmlSchemaCollection_IValidationEventHandling_0;

		// Token: 0x040012C2 RID: 4802
		private static readonly IntPtr NativeMethodInfoPtr_get_Reader_Public_get_XmlValidatingReaderImpl_0;

		// Token: 0x040012C3 RID: 4803
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaCollection_Public_get_XmlSchemaCollection_0;

		// Token: 0x040012C4 RID: 4804
		private static readonly IntPtr NativeMethodInfoPtr_get_NameTable_Public_get_XmlNameTable_0;

		// Token: 0x040012C5 RID: 4805
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaNames_Public_get_SchemaNames_0;

		// Token: 0x040012C6 RID: 4806
		private static readonly IntPtr NativeMethodInfoPtr_get_PositionInfo_Public_get_PositionInfo_0;

		// Token: 0x040012C7 RID: 4807
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlResolver_Public_get_XmlResolver_0;

		// Token: 0x040012C8 RID: 4808
		private static readonly IntPtr NativeMethodInfoPtr_set_XmlResolver_Public_set_Void_XmlResolver_0;

		// Token: 0x040012C9 RID: 4809
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseUri_Public_get_Uri_0;

		// Token: 0x040012CA RID: 4810
		private static readonly IntPtr NativeMethodInfoPtr_set_BaseUri_Public_set_Void_Uri_0;

		// Token: 0x040012CB RID: 4811
		private static readonly IntPtr NativeMethodInfoPtr_get_EventHandler_Public_get_ValidationEventHandler_0;

		// Token: 0x040012CC RID: 4812
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaInfo_Public_get_SchemaInfo_0;

		// Token: 0x040012CD RID: 4813
		private static readonly IntPtr NativeMethodInfoPtr_set_DtdInfo_Public_set_Void_IDtdInfo_0;

		// Token: 0x040012CE RID: 4814
		private static readonly IntPtr NativeMethodInfoPtr_get_PreserveWhitespace_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040012CF RID: 4815
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Public_Virtual_New_Void_0;

		// Token: 0x040012D0 RID: 4816
		private static readonly IntPtr NativeMethodInfoPtr_CompleteValidation_Public_Virtual_New_Void_0;

		// Token: 0x040012D1 RID: 4817
		private static readonly IntPtr NativeMethodInfoPtr_FindId_Public_Virtual_New_Object_String_0;

		// Token: 0x040012D2 RID: 4818
		private static readonly IntPtr NativeMethodInfoPtr_ValidateText_Public_Void_0;

		// Token: 0x040012D3 RID: 4819
		private static readonly IntPtr NativeMethodInfoPtr_ValidateWhitespace_Public_Void_0;

		// Token: 0x040012D4 RID: 4820
		private static readonly IntPtr NativeMethodInfoPtr_SaveTextValue_Private_Void_String_0;

		// Token: 0x040012D5 RID: 4821
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_0;

		// Token: 0x040012D6 RID: 4822
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_Il2CppStringArray_0;

		// Token: 0x040012D7 RID: 4823
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_String_0;

		// Token: 0x040012D8 RID: 4824
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Protected_Void_XmlSchemaException_0;

		// Token: 0x040012D9 RID: 4825
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_String_XmlSeverityType_0;

		// Token: 0x040012DA RID: 4826
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Protected_Void_String_Il2CppStringArray_XmlSeverityType_0;

		// Token: 0x040012DB RID: 4827
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Protected_Void_XmlSchemaException_XmlSeverityType_0;

		// Token: 0x040012DC RID: 4828
		private static readonly IntPtr NativeMethodInfoPtr_ProcessEntity_Protected_Static_Void_SchemaInfo_String_Object_ValidationEventHandler_String_Int32_Int32_0;

		// Token: 0x040012DD RID: 4829
		private static readonly IntPtr NativeMethodInfoPtr_ProcessEntity_Protected_Static_Void_SchemaInfo_String_IValidationEventHandling_String_Int32_Int32_0;

		// Token: 0x040012DE RID: 4830
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_BaseValidator_ValidationType_XmlValidatingReaderImpl_XmlSchemaCollection_IValidationEventHandling_Boolean_0;
	}
}
