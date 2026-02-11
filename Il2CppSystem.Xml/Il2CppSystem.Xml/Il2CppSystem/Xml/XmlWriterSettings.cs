using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000058 RID: 88
	public sealed class XmlWriterSettings : Object
	{
		// Token: 0x06000A0D RID: 2573 RVA: 0x00041F3C File Offset: 0x0004013C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlWriterSettings()
		{
			Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlWriterSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr);
			XmlWriterSettings.NativeFieldInfoPtr_useAsync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "useAsync");
			XmlWriterSettings.NativeFieldInfoPtr_encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "encoding");
			XmlWriterSettings.NativeFieldInfoPtr_omitXmlDecl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "omitXmlDecl");
			XmlWriterSettings.NativeFieldInfoPtr_newLineHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "newLineHandling");
			XmlWriterSettings.NativeFieldInfoPtr_newLineChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "newLineChars");
			XmlWriterSettings.NativeFieldInfoPtr_indent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "indent");
			XmlWriterSettings.NativeFieldInfoPtr_indentChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "indentChars");
			XmlWriterSettings.NativeFieldInfoPtr_newLineOnAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "newLineOnAttributes");
			XmlWriterSettings.NativeFieldInfoPtr_closeOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "closeOutput");
			XmlWriterSettings.NativeFieldInfoPtr_namespaceHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "namespaceHandling");
			XmlWriterSettings.NativeFieldInfoPtr_conformanceLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "conformanceLevel");
			XmlWriterSettings.NativeFieldInfoPtr_checkCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "checkCharacters");
			XmlWriterSettings.NativeFieldInfoPtr_writeEndDocumentOnClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "writeEndDocumentOnClose");
			XmlWriterSettings.NativeFieldInfoPtr_outputMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "outputMethod");
			XmlWriterSettings.NativeFieldInfoPtr_cdataSections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "cdataSections");
			XmlWriterSettings.NativeFieldInfoPtr_doNotEscapeUriAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "doNotEscapeUriAttributes");
			XmlWriterSettings.NativeFieldInfoPtr_mergeCDataSections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "mergeCDataSections");
			XmlWriterSettings.NativeFieldInfoPtr_mediaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "mediaType");
			XmlWriterSettings.NativeFieldInfoPtr_docTypeSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "docTypeSystem");
			XmlWriterSettings.NativeFieldInfoPtr_docTypePublic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "docTypePublic");
			XmlWriterSettings.NativeFieldInfoPtr_standalone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "standalone");
			XmlWriterSettings.NativeFieldInfoPtr_autoXmlDecl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "autoXmlDecl");
			XmlWriterSettings.NativeFieldInfoPtr_isReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, "isReadOnly");
			XmlWriterSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100664994);
			XmlWriterSettings.NativeMethodInfoPtr_get_Async_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100664995);
			XmlWriterSettings.NativeMethodInfoPtr_get_Encoding_Public_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100664996);
			XmlWriterSettings.NativeMethodInfoPtr_get_OmitXmlDeclaration_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100664997);
			XmlWriterSettings.NativeMethodInfoPtr_set_OmitXmlDeclaration_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100664998);
			XmlWriterSettings.NativeMethodInfoPtr_get_NewLineHandling_Public_get_NewLineHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100664999);
			XmlWriterSettings.NativeMethodInfoPtr_get_NewLineChars_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100665000);
			XmlWriterSettings.NativeMethodInfoPtr_get_Indent_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100665001);
			XmlWriterSettings.NativeMethodInfoPtr_set_Indent_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100665002);
			XmlWriterSettings.NativeMethodInfoPtr_get_IndentChars_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100665003);
			XmlWriterSettings.NativeMethodInfoPtr_get_NewLineOnAttributes_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100665004);
			XmlWriterSettings.NativeMethodInfoPtr_get_CloseOutput_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100665005);
			XmlWriterSettings.NativeMethodInfoPtr_get_ConformanceLevel_Public_get_ConformanceLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100665006);
			XmlWriterSettings.NativeMethodInfoPtr_set_ConformanceLevel_Public_set_Void_ConformanceLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100665007);
			XmlWriterSettings.NativeMethodInfoPtr_get_CheckCharacters_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100665008);
			XmlWriterSettings.NativeMethodInfoPtr_get_NamespaceHandling_Public_get_NamespaceHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100665009);
			XmlWriterSettings.NativeMethodInfoPtr_set_NamespaceHandling_Public_set_Void_NamespaceHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100665010);
			XmlWriterSettings.NativeMethodInfoPtr_get_WriteEndDocumentOnClose_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100665011);
			XmlWriterSettings.NativeMethodInfoPtr_get_OutputMethod_Public_get_XmlOutputMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100665012);
			XmlWriterSettings.NativeMethodInfoPtr_set_OutputMethod_Internal_set_Void_XmlOutputMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100665013);
			XmlWriterSettings.NativeMethodInfoPtr_Clone_Public_XmlWriterSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100665014);
			XmlWriterSettings.NativeMethodInfoPtr_get_CDataSectionElements_Internal_get_List_1_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100665015);
			XmlWriterSettings.NativeMethodInfoPtr_get_DoNotEscapeUriAttributes_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100665016);
			XmlWriterSettings.NativeMethodInfoPtr_get_MergeCDataSections_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100665017);
			XmlWriterSettings.NativeMethodInfoPtr_get_MediaType_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100665018);
			XmlWriterSettings.NativeMethodInfoPtr_get_DocTypeSystem_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100665019);
			XmlWriterSettings.NativeMethodInfoPtr_get_DocTypePublic_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100665020);
			XmlWriterSettings.NativeMethodInfoPtr_get_Standalone_Internal_get_XmlStandalone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100665021);
			XmlWriterSettings.NativeMethodInfoPtr_get_AutoXmlDeclaration_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100665022);
			XmlWriterSettings.NativeMethodInfoPtr_get_IndentInternal_Internal_get_TriState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100665023);
			XmlWriterSettings.NativeMethodInfoPtr_get_IsQuerySpecific_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100665024);
			XmlWriterSettings.NativeMethodInfoPtr_CreateWriter_Internal_XmlWriter_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100665025);
			XmlWriterSettings.NativeMethodInfoPtr_CreateWriter_Internal_XmlWriter_TextWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100665026);
			XmlWriterSettings.NativeMethodInfoPtr_set_ReadOnly_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100665027);
			XmlWriterSettings.NativeMethodInfoPtr_CheckReadOnly_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100665028);
			XmlWriterSettings.NativeMethodInfoPtr_Initialize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr, 100665029);
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x00042408 File Offset: 0x00040608
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 372617, RefRangeEnd = 372621, XrefRangeStart = 372596, XrefRangeEnd = 372617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlWriterSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlWriterSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x00042444 File Offset: 0x00040644
		public unsafe bool Async
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_Async_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000A10 RID: 2576 RVA: 0x00042480 File Offset: 0x00040680
		public unsafe Encoding Encoding
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_Encoding_Public_get_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x000424C0 File Offset: 0x000406C0
		// (set) Token: 0x06000A12 RID: 2578 RVA: 0x000424FC File Offset: 0x000406FC
		public unsafe bool OmitXmlDeclaration
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_OmitXmlDeclaration_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 372624, RefRangeEnd = 372625, XrefRangeStart = 372621, XrefRangeEnd = 372624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_set_OmitXmlDeclaration_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x0004253C File Offset: 0x0004073C
		public unsafe NewLineHandling NewLineHandling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_NewLineHandling_Public_get_NewLineHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000A14 RID: 2580 RVA: 0x00042578 File Offset: 0x00040778
		public unsafe string NewLineChars
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_NewLineChars_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x000425B0 File Offset: 0x000407B0
		// (set) Token: 0x06000A16 RID: 2582 RVA: 0x000425EC File Offset: 0x000407EC
		public unsafe bool Indent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_Indent_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 372628, RefRangeEnd = 372630, XrefRangeStart = 372625, XrefRangeEnd = 372628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_set_Indent_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x0004262C File Offset: 0x0004082C
		public unsafe string IndentChars
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_IndentChars_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000A18 RID: 2584 RVA: 0x00042664 File Offset: 0x00040864
		public unsafe bool NewLineOnAttributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_NewLineOnAttributes_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x000426A0 File Offset: 0x000408A0
		public unsafe bool CloseOutput
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_CloseOutput_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000A1A RID: 2586 RVA: 0x000426DC File Offset: 0x000408DC
		// (set) Token: 0x06000A1B RID: 2587 RVA: 0x00042718 File Offset: 0x00040918
		public unsafe ConformanceLevel ConformanceLevel
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 366305, RefRangeEnd = 366308, XrefRangeStart = 366305, XrefRangeEnd = 366308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_ConformanceLevel_Public_get_ConformanceLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 372633, RefRangeEnd = 372635, XrefRangeStart = 372630, XrefRangeEnd = 372633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_set_ConformanceLevel_Public_set_Void_ConformanceLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000A1C RID: 2588 RVA: 0x00042758 File Offset: 0x00040958
		public unsafe bool CheckCharacters
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_CheckCharacters_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000A1D RID: 2589 RVA: 0x00042794 File Offset: 0x00040994
		// (set) Token: 0x06000A1E RID: 2590 RVA: 0x000427D0 File Offset: 0x000409D0
		public unsafe NamespaceHandling NamespaceHandling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_NamespaceHandling_Public_get_NamespaceHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 372638, RefRangeEnd = 372639, XrefRangeStart = 372635, XrefRangeEnd = 372638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_set_NamespaceHandling_Public_set_Void_NamespaceHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000A1F RID: 2591 RVA: 0x00042810 File Offset: 0x00040A10
		public unsafe bool WriteEndDocumentOnClose
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_WriteEndDocumentOnClose_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000A20 RID: 2592 RVA: 0x0004284C File Offset: 0x00040A4C
		// (set) Token: 0x06000A21 RID: 2593 RVA: 0x00042888 File Offset: 0x00040A88
		public unsafe XmlOutputMethod OutputMethod
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 318242, RefRangeEnd = 318245, XrefRangeStart = 318242, XrefRangeEnd = 318245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_OutputMethod_Public_get_XmlOutputMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_set_OutputMethod_Internal_set_Void_XmlOutputMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x000428C8 File Offset: 0x00040AC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 372649, RefRangeEnd = 372650, XrefRangeStart = 372639, XrefRangeEnd = 372649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlWriterSettings Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_Clone_Public_XmlWriterSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlWriterSettings>(intPtr3) : null;
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000A23 RID: 2595 RVA: 0x00042908 File Offset: 0x00040B08
		public unsafe List<XmlQualifiedName> CDataSectionElements
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_CDataSectionElements_Internal_get_List_1_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<XmlQualifiedName>>(intPtr3) : null;
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000A24 RID: 2596 RVA: 0x00042948 File Offset: 0x00040B48
		public unsafe bool DoNotEscapeUriAttributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_DoNotEscapeUriAttributes_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000A25 RID: 2597 RVA: 0x00042984 File Offset: 0x00040B84
		public unsafe bool MergeCDataSections
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_MergeCDataSections_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000A26 RID: 2598 RVA: 0x000429C0 File Offset: 0x00040BC0
		public unsafe string MediaType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_MediaType_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000A27 RID: 2599 RVA: 0x000429F8 File Offset: 0x00040BF8
		public unsafe string DocTypeSystem
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_DocTypeSystem_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x00042A30 File Offset: 0x00040C30
		public unsafe string DocTypePublic
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_DocTypePublic_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x00042A68 File Offset: 0x00040C68
		public unsafe XmlStandalone Standalone
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_Standalone_Internal_get_XmlStandalone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000A2A RID: 2602 RVA: 0x00042AA4 File Offset: 0x00040CA4
		public unsafe bool AutoXmlDeclaration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_AutoXmlDeclaration_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000A2B RID: 2603 RVA: 0x00042AE0 File Offset: 0x00040CE0
		public unsafe TriState IndentInternal
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_IndentInternal_Internal_get_TriState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x00042B1C File Offset: 0x00040D1C
		public unsafe bool IsQuerySpecific
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372650, XrefRangeEnd = 372651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_get_IsQuerySpecific_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x00042B58 File Offset: 0x00040D58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 372693, RefRangeEnd = 372694, XrefRangeStart = 372651, XrefRangeEnd = 372693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlWriter CreateWriter(Stream output)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(output);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_CreateWriter_Internal_XmlWriter_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlWriter>(intPtr3) : null;
			}
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x00042BA8 File Offset: 0x00040DA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 372704, RefRangeEnd = 372705, XrefRangeStart = 372694, XrefRangeEnd = 372704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlWriter CreateWriter(TextWriter output)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(output);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_CreateWriter_Internal_XmlWriter_TextWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlWriter>(intPtr3) : null;
			}
		}

		// Token: 0x17000336 RID: 822
		// (set) Token: 0x06000A2F RID: 2607 RVA: 0x00042BF8 File Offset: 0x00040DF8
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_set_ReadOnly_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x00042C38 File Offset: 0x00040E38
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 372705, RefRangeEnd = 372709, XrefRangeStart = 372705, XrefRangeEnd = 372705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckReadOnly(string propertyName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_CheckReadOnly_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x00042C7C File Offset: 0x00040E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372709, XrefRangeEnd = 372722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlWriterSettings.NativeMethodInfoPtr_Initialize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x000053EC File Offset: 0x000035EC
		public XmlWriterSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000A33 RID: 2611 RVA: 0x00042CB0 File Offset: 0x00040EB0
		// (set) Token: 0x06000A34 RID: 2612 RVA: 0x000053F5 File Offset: 0x000035F5
		public unsafe bool useAsync
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_useAsync);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_useAsync)) = value;
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x00042CD8 File Offset: 0x00040ED8
		// (set) Token: 0x06000A36 RID: 2614 RVA: 0x00005410 File Offset: 0x00003610
		public unsafe Encoding encoding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_encoding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_encoding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x00042D08 File Offset: 0x00040F08
		// (set) Token: 0x06000A38 RID: 2616 RVA: 0x0000542F File Offset: 0x0000362F
		public unsafe bool omitXmlDecl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_omitXmlDecl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_omitXmlDecl)) = value;
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000A39 RID: 2617 RVA: 0x00042D30 File Offset: 0x00040F30
		// (set) Token: 0x06000A3A RID: 2618 RVA: 0x0000544A File Offset: 0x0000364A
		public unsafe NewLineHandling newLineHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_newLineHandling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_newLineHandling)) = value;
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000A3B RID: 2619 RVA: 0x00042D58 File Offset: 0x00040F58
		// (set) Token: 0x06000A3C RID: 2620 RVA: 0x00005465 File Offset: 0x00003665
		public unsafe string newLineChars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_newLineChars);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_newLineChars), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x00042D80 File Offset: 0x00040F80
		// (set) Token: 0x06000A3E RID: 2622 RVA: 0x00005484 File Offset: 0x00003684
		public unsafe TriState indent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_indent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_indent)) = value;
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x00042DA8 File Offset: 0x00040FA8
		// (set) Token: 0x06000A40 RID: 2624 RVA: 0x0000549F File Offset: 0x0000369F
		public unsafe string indentChars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_indentChars);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_indentChars), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x00042DD0 File Offset: 0x00040FD0
		// (set) Token: 0x06000A42 RID: 2626 RVA: 0x000054BE File Offset: 0x000036BE
		public unsafe bool newLineOnAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_newLineOnAttributes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_newLineOnAttributes)) = value;
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000A43 RID: 2627 RVA: 0x00042DF8 File Offset: 0x00040FF8
		// (set) Token: 0x06000A44 RID: 2628 RVA: 0x000054D9 File Offset: 0x000036D9
		public unsafe bool closeOutput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_closeOutput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_closeOutput)) = value;
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000A45 RID: 2629 RVA: 0x00042E20 File Offset: 0x00041020
		// (set) Token: 0x06000A46 RID: 2630 RVA: 0x000054F4 File Offset: 0x000036F4
		public unsafe NamespaceHandling namespaceHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_namespaceHandling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_namespaceHandling)) = value;
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000A47 RID: 2631 RVA: 0x00042E48 File Offset: 0x00041048
		// (set) Token: 0x06000A48 RID: 2632 RVA: 0x0000550F File Offset: 0x0000370F
		public unsafe ConformanceLevel conformanceLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_conformanceLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_conformanceLevel)) = value;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000A49 RID: 2633 RVA: 0x00042E70 File Offset: 0x00041070
		// (set) Token: 0x06000A4A RID: 2634 RVA: 0x0000552A File Offset: 0x0000372A
		public unsafe bool checkCharacters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_checkCharacters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_checkCharacters)) = value;
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000A4B RID: 2635 RVA: 0x00042E98 File Offset: 0x00041098
		// (set) Token: 0x06000A4C RID: 2636 RVA: 0x00005545 File Offset: 0x00003745
		public unsafe bool writeEndDocumentOnClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_writeEndDocumentOnClose);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_writeEndDocumentOnClose)) = value;
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000A4D RID: 2637 RVA: 0x00042EC0 File Offset: 0x000410C0
		// (set) Token: 0x06000A4E RID: 2638 RVA: 0x00005560 File Offset: 0x00003760
		public unsafe XmlOutputMethod outputMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_outputMethod);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_outputMethod)) = value;
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000A4F RID: 2639 RVA: 0x00042EE8 File Offset: 0x000410E8
		// (set) Token: 0x06000A50 RID: 2640 RVA: 0x0000557B File Offset: 0x0000377B
		public unsafe List<XmlQualifiedName> cdataSections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_cdataSections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<XmlQualifiedName>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_cdataSections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000A51 RID: 2641 RVA: 0x00042F18 File Offset: 0x00041118
		// (set) Token: 0x06000A52 RID: 2642 RVA: 0x0000559A File Offset: 0x0000379A
		public unsafe bool doNotEscapeUriAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_doNotEscapeUriAttributes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_doNotEscapeUriAttributes)) = value;
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000A53 RID: 2643 RVA: 0x00042F40 File Offset: 0x00041140
		// (set) Token: 0x06000A54 RID: 2644 RVA: 0x000055B5 File Offset: 0x000037B5
		public unsafe bool mergeCDataSections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_mergeCDataSections);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_mergeCDataSections)) = value;
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000A55 RID: 2645 RVA: 0x00042F68 File Offset: 0x00041168
		// (set) Token: 0x06000A56 RID: 2646 RVA: 0x000055D0 File Offset: 0x000037D0
		public unsafe string mediaType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_mediaType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_mediaType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000A57 RID: 2647 RVA: 0x00042F90 File Offset: 0x00041190
		// (set) Token: 0x06000A58 RID: 2648 RVA: 0x000055EF File Offset: 0x000037EF
		public unsafe string docTypeSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_docTypeSystem);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_docTypeSystem), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000A59 RID: 2649 RVA: 0x00042FB8 File Offset: 0x000411B8
		// (set) Token: 0x06000A5A RID: 2650 RVA: 0x0000560E File Offset: 0x0000380E
		public unsafe string docTypePublic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_docTypePublic);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_docTypePublic), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000A5B RID: 2651 RVA: 0x00042FE0 File Offset: 0x000411E0
		// (set) Token: 0x06000A5C RID: 2652 RVA: 0x0000562D File Offset: 0x0000382D
		public unsafe XmlStandalone standalone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_standalone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_standalone)) = value;
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000A5D RID: 2653 RVA: 0x00043008 File Offset: 0x00041208
		// (set) Token: 0x06000A5E RID: 2654 RVA: 0x00005648 File Offset: 0x00003848
		public unsafe bool autoXmlDecl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_autoXmlDecl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_autoXmlDecl)) = value;
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000A5F RID: 2655 RVA: 0x00043030 File Offset: 0x00041230
		// (set) Token: 0x06000A60 RID: 2656 RVA: 0x00005663 File Offset: 0x00003863
		public unsafe bool isReadOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_isReadOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlWriterSettings.NativeFieldInfoPtr_isReadOnly)) = value;
			}
		}

		// Token: 0x04000861 RID: 2145
		private static readonly IntPtr NativeFieldInfoPtr_useAsync;

		// Token: 0x04000862 RID: 2146
		private static readonly IntPtr NativeFieldInfoPtr_encoding;

		// Token: 0x04000863 RID: 2147
		private static readonly IntPtr NativeFieldInfoPtr_omitXmlDecl;

		// Token: 0x04000864 RID: 2148
		private static readonly IntPtr NativeFieldInfoPtr_newLineHandling;

		// Token: 0x04000865 RID: 2149
		private static readonly IntPtr NativeFieldInfoPtr_newLineChars;

		// Token: 0x04000866 RID: 2150
		private static readonly IntPtr NativeFieldInfoPtr_indent;

		// Token: 0x04000867 RID: 2151
		private static readonly IntPtr NativeFieldInfoPtr_indentChars;

		// Token: 0x04000868 RID: 2152
		private static readonly IntPtr NativeFieldInfoPtr_newLineOnAttributes;

		// Token: 0x04000869 RID: 2153
		private static readonly IntPtr NativeFieldInfoPtr_closeOutput;

		// Token: 0x0400086A RID: 2154
		private static readonly IntPtr NativeFieldInfoPtr_namespaceHandling;

		// Token: 0x0400086B RID: 2155
		private static readonly IntPtr NativeFieldInfoPtr_conformanceLevel;

		// Token: 0x0400086C RID: 2156
		private static readonly IntPtr NativeFieldInfoPtr_checkCharacters;

		// Token: 0x0400086D RID: 2157
		private static readonly IntPtr NativeFieldInfoPtr_writeEndDocumentOnClose;

		// Token: 0x0400086E RID: 2158
		private static readonly IntPtr NativeFieldInfoPtr_outputMethod;

		// Token: 0x0400086F RID: 2159
		private static readonly IntPtr NativeFieldInfoPtr_cdataSections;

		// Token: 0x04000870 RID: 2160
		private static readonly IntPtr NativeFieldInfoPtr_doNotEscapeUriAttributes;

		// Token: 0x04000871 RID: 2161
		private static readonly IntPtr NativeFieldInfoPtr_mergeCDataSections;

		// Token: 0x04000872 RID: 2162
		private static readonly IntPtr NativeFieldInfoPtr_mediaType;

		// Token: 0x04000873 RID: 2163
		private static readonly IntPtr NativeFieldInfoPtr_docTypeSystem;

		// Token: 0x04000874 RID: 2164
		private static readonly IntPtr NativeFieldInfoPtr_docTypePublic;

		// Token: 0x04000875 RID: 2165
		private static readonly IntPtr NativeFieldInfoPtr_standalone;

		// Token: 0x04000876 RID: 2166
		private static readonly IntPtr NativeFieldInfoPtr_autoXmlDecl;

		// Token: 0x04000877 RID: 2167
		private static readonly IntPtr NativeFieldInfoPtr_isReadOnly;

		// Token: 0x04000878 RID: 2168
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000879 RID: 2169
		private static readonly IntPtr NativeMethodInfoPtr_get_Async_Public_get_Boolean_0;

		// Token: 0x0400087A RID: 2170
		private static readonly IntPtr NativeMethodInfoPtr_get_Encoding_Public_get_Encoding_0;

		// Token: 0x0400087B RID: 2171
		private static readonly IntPtr NativeMethodInfoPtr_get_OmitXmlDeclaration_Public_get_Boolean_0;

		// Token: 0x0400087C RID: 2172
		private static readonly IntPtr NativeMethodInfoPtr_set_OmitXmlDeclaration_Public_set_Void_Boolean_0;

		// Token: 0x0400087D RID: 2173
		private static readonly IntPtr NativeMethodInfoPtr_get_NewLineHandling_Public_get_NewLineHandling_0;

		// Token: 0x0400087E RID: 2174
		private static readonly IntPtr NativeMethodInfoPtr_get_NewLineChars_Public_get_String_0;

		// Token: 0x0400087F RID: 2175
		private static readonly IntPtr NativeMethodInfoPtr_get_Indent_Public_get_Boolean_0;

		// Token: 0x04000880 RID: 2176
		private static readonly IntPtr NativeMethodInfoPtr_set_Indent_Public_set_Void_Boolean_0;

		// Token: 0x04000881 RID: 2177
		private static readonly IntPtr NativeMethodInfoPtr_get_IndentChars_Public_get_String_0;

		// Token: 0x04000882 RID: 2178
		private static readonly IntPtr NativeMethodInfoPtr_get_NewLineOnAttributes_Public_get_Boolean_0;

		// Token: 0x04000883 RID: 2179
		private static readonly IntPtr NativeMethodInfoPtr_get_CloseOutput_Public_get_Boolean_0;

		// Token: 0x04000884 RID: 2180
		private static readonly IntPtr NativeMethodInfoPtr_get_ConformanceLevel_Public_get_ConformanceLevel_0;

		// Token: 0x04000885 RID: 2181
		private static readonly IntPtr NativeMethodInfoPtr_set_ConformanceLevel_Public_set_Void_ConformanceLevel_0;

		// Token: 0x04000886 RID: 2182
		private static readonly IntPtr NativeMethodInfoPtr_get_CheckCharacters_Public_get_Boolean_0;

		// Token: 0x04000887 RID: 2183
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceHandling_Public_get_NamespaceHandling_0;

		// Token: 0x04000888 RID: 2184
		private static readonly IntPtr NativeMethodInfoPtr_set_NamespaceHandling_Public_set_Void_NamespaceHandling_0;

		// Token: 0x04000889 RID: 2185
		private static readonly IntPtr NativeMethodInfoPtr_get_WriteEndDocumentOnClose_Public_get_Boolean_0;

		// Token: 0x0400088A RID: 2186
		private static readonly IntPtr NativeMethodInfoPtr_get_OutputMethod_Public_get_XmlOutputMethod_0;

		// Token: 0x0400088B RID: 2187
		private static readonly IntPtr NativeMethodInfoPtr_set_OutputMethod_Internal_set_Void_XmlOutputMethod_0;

		// Token: 0x0400088C RID: 2188
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_XmlWriterSettings_0;

		// Token: 0x0400088D RID: 2189
		private static readonly IntPtr NativeMethodInfoPtr_get_CDataSectionElements_Internal_get_List_1_XmlQualifiedName_0;

		// Token: 0x0400088E RID: 2190
		private static readonly IntPtr NativeMethodInfoPtr_get_DoNotEscapeUriAttributes_Public_get_Boolean_0;

		// Token: 0x0400088F RID: 2191
		private static readonly IntPtr NativeMethodInfoPtr_get_MergeCDataSections_Internal_get_Boolean_0;

		// Token: 0x04000890 RID: 2192
		private static readonly IntPtr NativeMethodInfoPtr_get_MediaType_Internal_get_String_0;

		// Token: 0x04000891 RID: 2193
		private static readonly IntPtr NativeMethodInfoPtr_get_DocTypeSystem_Internal_get_String_0;

		// Token: 0x04000892 RID: 2194
		private static readonly IntPtr NativeMethodInfoPtr_get_DocTypePublic_Internal_get_String_0;

		// Token: 0x04000893 RID: 2195
		private static readonly IntPtr NativeMethodInfoPtr_get_Standalone_Internal_get_XmlStandalone_0;

		// Token: 0x04000894 RID: 2196
		private static readonly IntPtr NativeMethodInfoPtr_get_AutoXmlDeclaration_Internal_get_Boolean_0;

		// Token: 0x04000895 RID: 2197
		private static readonly IntPtr NativeMethodInfoPtr_get_IndentInternal_Internal_get_TriState_0;

		// Token: 0x04000896 RID: 2198
		private static readonly IntPtr NativeMethodInfoPtr_get_IsQuerySpecific_Internal_get_Boolean_0;

		// Token: 0x04000897 RID: 2199
		private static readonly IntPtr NativeMethodInfoPtr_CreateWriter_Internal_XmlWriter_Stream_0;

		// Token: 0x04000898 RID: 2200
		private static readonly IntPtr NativeMethodInfoPtr_CreateWriter_Internal_XmlWriter_TextWriter_0;

		// Token: 0x04000899 RID: 2201
		private static readonly IntPtr NativeMethodInfoPtr_set_ReadOnly_Internal_set_Void_Boolean_0;

		// Token: 0x0400089A RID: 2202
		private static readonly IntPtr NativeMethodInfoPtr_CheckReadOnly_Private_Void_String_0;

		// Token: 0x0400089B RID: 2203
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_0;
	}
}
