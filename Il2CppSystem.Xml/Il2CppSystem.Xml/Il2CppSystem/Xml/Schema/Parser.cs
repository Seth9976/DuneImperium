using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200017D RID: 381
	public sealed class Parser : Object
	{
		// Token: 0x06001E15 RID: 7701 RVA: 0x00094F88 File Offset: 0x00093188
		// Note: this type is marked as 'beforefieldinit'.
		static Parser()
		{
			Il2CppClassPointerStore<Parser>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Parser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Parser>.NativeClassPtr);
			Parser.NativeFieldInfoPtr_schemaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "schemaType");
			Parser.NativeFieldInfoPtr_nameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "nameTable");
			Parser.NativeFieldInfoPtr_schemaNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "schemaNames");
			Parser.NativeFieldInfoPtr_eventHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "eventHandler");
			Parser.NativeFieldInfoPtr_namespaceManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "namespaceManager");
			Parser.NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "reader");
			Parser.NativeFieldInfoPtr_positionInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "positionInfo");
			Parser.NativeFieldInfoPtr_isProcessNamespaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "isProcessNamespaces");
			Parser.NativeFieldInfoPtr_schemaXmlDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "schemaXmlDepth");
			Parser.NativeFieldInfoPtr_markupDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "markupDepth");
			Parser.NativeFieldInfoPtr_builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "builder");
			Parser.NativeFieldInfoPtr_schema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "schema");
			Parser.NativeFieldInfoPtr_xdrSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "xdrSchema");
			Parser.NativeFieldInfoPtr_xmlResolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "xmlResolver");
			Parser.NativeFieldInfoPtr_dummyDocument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "dummyDocument");
			Parser.NativeFieldInfoPtr_processMarkup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "processMarkup");
			Parser.NativeFieldInfoPtr_parentNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "parentNode");
			Parser.NativeFieldInfoPtr_annotationNSManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "annotationNSManager");
			Parser.NativeFieldInfoPtr_xmlns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "xmlns");
			Parser.NativeFieldInfoPtr_xmlCharType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "xmlCharType");
			Parser.NativeMethodInfoPtr__ctor_Public_Void_SchemaType_XmlNameTable_SchemaNames_ValidationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100667828);
			Parser.NativeMethodInfoPtr_Parse_Public_SchemaType_XmlReader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100667829);
			Parser.NativeMethodInfoPtr_StartParsing_Public_Void_XmlReader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100667830);
			Parser.NativeMethodInfoPtr_CheckSchemaRoot_Private_Boolean_SchemaType_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100667831);
			Parser.NativeMethodInfoPtr_FinishParsing_Public_SchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100667832);
			Parser.NativeMethodInfoPtr_get_XmlSchema_Public_get_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100667833);
			Parser.NativeMethodInfoPtr_set_XmlResolver_Internal_set_Void_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100667834);
			Parser.NativeMethodInfoPtr_get_XdrSchema_Public_get_SchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100667835);
			Parser.NativeMethodInfoPtr_ParseReaderNode_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100667836);
			Parser.NativeMethodInfoPtr_ProcessAppInfoDocMarkup_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100667837);
			Parser.NativeMethodInfoPtr_LoadElementNode_Private_XmlElement_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100667838);
			Parser.NativeMethodInfoPtr_CreateXmlNsAttribute_Private_XmlAttribute_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100667839);
			Parser.NativeMethodInfoPtr_LoadAttributeNode_Private_XmlAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100667840);
			Parser.NativeMethodInfoPtr_LoadEntityReferenceInAttribute_Private_XmlEntityReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100667841);
		}

		// Token: 0x06001E16 RID: 7702 RVA: 0x00095260 File Offset: 0x00093460
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 397718, RefRangeEnd = 397728, XrefRangeStart = 397705, XrefRangeEnd = 397718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Parser(SchemaType schemaType, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Parser>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref schemaType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaNames);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventHandler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr__ctor_Public_Void_SchemaType_XmlNameTable_SchemaNames_ValidationEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E17 RID: 7703 RVA: 0x000952E0 File Offset: 0x000934E0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 397730, RefRangeEnd = 397736, XrefRangeStart = 397728, XrefRangeEnd = 397730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaType Parse(XmlReader reader, string targetNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_Parse_Public_SchemaType_XmlReader_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x00095340 File Offset: 0x00093540
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 397769, RefRangeEnd = 397774, XrefRangeStart = 397736, XrefRangeEnd = 397769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartParsing(XmlReader reader, string targetNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_StartParsing_Public_Void_XmlReader_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x00095394 File Offset: 0x00093594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397774, XrefRangeEnd = 397782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckSchemaRoot(SchemaType rootType, out string code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rootType;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_CheckSchemaRoot_Private_Boolean_SchemaType_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			code = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001E1A RID: 7706 RVA: 0x000953F8 File Offset: 0x000935F8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaType FinishParsing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_FinishParsing_Public_SchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06001E1B RID: 7707 RVA: 0x00095434 File Offset: 0x00093634
		public unsafe XmlSchema XmlSchema
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_get_XmlSchema_Public_get_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
			}
		}

		// Token: 0x17000A08 RID: 2568
		// (set) Token: 0x06001E1C RID: 7708 RVA: 0x00095474 File Offset: 0x00093674
		public unsafe XmlResolver XmlResolver
		{
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_set_XmlResolver_Internal_set_Void_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x06001E1D RID: 7709 RVA: 0x000954B8 File Offset: 0x000936B8
		public unsafe SchemaInfo XdrSchema
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_get_XdrSchema_Public_get_SchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x000954F8 File Offset: 0x000936F8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 397794, RefRangeEnd = 397801, XrefRangeStart = 397782, XrefRangeEnd = 397794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseReaderNode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_ParseReaderNode_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x00095534 File Offset: 0x00093734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397801, XrefRangeEnd = 397802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessAppInfoDocMarkup(bool root)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref root;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_ProcessAppInfoDocMarkup_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x00095574 File Offset: 0x00093774
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 397816, RefRangeEnd = 397817, XrefRangeStart = 397802, XrefRangeEnd = 397816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlElement LoadElementNode(bool root)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref root;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_LoadElementNode_Private_XmlElement_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlElement>(intPtr3) : null;
			}
		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x000955C0 File Offset: 0x000937C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 397822, RefRangeEnd = 397823, XrefRangeStart = 397817, XrefRangeEnd = 397822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAttribute CreateXmlNsAttribute(string prefix, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_CreateXmlNsAttribute_Private_XmlAttribute_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAttribute>(intPtr3) : null;
		}

		// Token: 0x06001E22 RID: 7714 RVA: 0x00095624 File Offset: 0x00093824
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 397826, RefRangeEnd = 397827, XrefRangeStart = 397823, XrefRangeEnd = 397826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAttribute LoadAttributeNode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_LoadAttributeNode_Private_XmlAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAttribute>(intPtr3) : null;
		}

		// Token: 0x06001E23 RID: 7715 RVA: 0x00095664 File Offset: 0x00093864
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 397832, RefRangeEnd = 397834, XrefRangeStart = 397827, XrefRangeEnd = 397832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlEntityReference LoadEntityReferenceInAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_LoadEntityReferenceInAttribute_Private_XmlEntityReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlEntityReference>(intPtr3) : null;
		}

		// Token: 0x06001E24 RID: 7716 RVA: 0x0000C510 File Offset: 0x0000A710
		public Parser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x06001E25 RID: 7717 RVA: 0x000956A4 File Offset: 0x000938A4
		// (set) Token: 0x06001E26 RID: 7718 RVA: 0x0000C519 File Offset: 0x0000A719
		public unsafe SchemaType schemaType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_schemaType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_schemaType)) = value;
			}
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x06001E27 RID: 7719 RVA: 0x000956CC File Offset: 0x000938CC
		// (set) Token: 0x06001E28 RID: 7720 RVA: 0x0000C534 File Offset: 0x0000A734
		public unsafe XmlNameTable nameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_nameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_nameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x06001E29 RID: 7721 RVA: 0x000956FC File Offset: 0x000938FC
		// (set) Token: 0x06001E2A RID: 7722 RVA: 0x0000C553 File Offset: 0x0000A753
		public unsafe SchemaNames schemaNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_schemaNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaNames>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_schemaNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x06001E2B RID: 7723 RVA: 0x0009572C File Offset: 0x0009392C
		// (set) Token: 0x06001E2C RID: 7724 RVA: 0x0000C572 File Offset: 0x0000A772
		public unsafe ValidationEventHandler eventHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_eventHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidationEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_eventHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x06001E2D RID: 7725 RVA: 0x0009575C File Offset: 0x0009395C
		// (set) Token: 0x06001E2E RID: 7726 RVA: 0x0000C591 File Offset: 0x0000A791
		public unsafe XmlNamespaceManager namespaceManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_namespaceManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNamespaceManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_namespaceManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x06001E2F RID: 7727 RVA: 0x0009578C File Offset: 0x0009398C
		// (set) Token: 0x06001E30 RID: 7728 RVA: 0x0000C5B0 File Offset: 0x0000A7B0
		public unsafe XmlReader reader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_reader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_reader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06001E31 RID: 7729 RVA: 0x000957BC File Offset: 0x000939BC
		// (set) Token: 0x06001E32 RID: 7730 RVA: 0x0000C5CF File Offset: 0x0000A7CF
		public unsafe PositionInfo positionInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_positionInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PositionInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_positionInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x06001E33 RID: 7731 RVA: 0x000957EC File Offset: 0x000939EC
		// (set) Token: 0x06001E34 RID: 7732 RVA: 0x0000C5EE File Offset: 0x0000A7EE
		public unsafe bool isProcessNamespaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_isProcessNamespaces);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_isProcessNamespaces)) = value;
			}
		}

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x06001E35 RID: 7733 RVA: 0x00095814 File Offset: 0x00093A14
		// (set) Token: 0x06001E36 RID: 7734 RVA: 0x0000C609 File Offset: 0x0000A809
		public unsafe int schemaXmlDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_schemaXmlDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_schemaXmlDepth)) = value;
			}
		}

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x06001E37 RID: 7735 RVA: 0x0009583C File Offset: 0x00093A3C
		// (set) Token: 0x06001E38 RID: 7736 RVA: 0x0000C624 File Offset: 0x0000A824
		public unsafe int markupDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_markupDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_markupDepth)) = value;
			}
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x06001E39 RID: 7737 RVA: 0x00095864 File Offset: 0x00093A64
		// (set) Token: 0x06001E3A RID: 7738 RVA: 0x0000C63F File Offset: 0x0000A83F
		public unsafe SchemaBuilder builder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_builder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_builder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x06001E3B RID: 7739 RVA: 0x00095894 File Offset: 0x00093A94
		// (set) Token: 0x06001E3C RID: 7740 RVA: 0x0000C65E File Offset: 0x0000A85E
		public unsafe XmlSchema schema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_schema);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_schema), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x06001E3D RID: 7741 RVA: 0x000958C4 File Offset: 0x00093AC4
		// (set) Token: 0x06001E3E RID: 7742 RVA: 0x0000C67D File Offset: 0x0000A87D
		public unsafe SchemaInfo xdrSchema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_xdrSchema);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_xdrSchema), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x06001E3F RID: 7743 RVA: 0x000958F4 File Offset: 0x00093AF4
		// (set) Token: 0x06001E40 RID: 7744 RVA: 0x0000C69C File Offset: 0x0000A89C
		public unsafe XmlResolver xmlResolver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_xmlResolver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_xmlResolver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x06001E41 RID: 7745 RVA: 0x00095924 File Offset: 0x00093B24
		// (set) Token: 0x06001E42 RID: 7746 RVA: 0x0000C6BB File Offset: 0x0000A8BB
		public unsafe XmlDocument dummyDocument
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_dummyDocument);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlDocument>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_dummyDocument), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x06001E43 RID: 7747 RVA: 0x00095954 File Offset: 0x00093B54
		// (set) Token: 0x06001E44 RID: 7748 RVA: 0x0000C6DA File Offset: 0x0000A8DA
		public unsafe bool processMarkup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_processMarkup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_processMarkup)) = value;
			}
		}

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x06001E45 RID: 7749 RVA: 0x0009597C File Offset: 0x00093B7C
		// (set) Token: 0x06001E46 RID: 7750 RVA: 0x0000C6F5 File Offset: 0x0000A8F5
		public unsafe XmlNode parentNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_parentNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_parentNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x06001E47 RID: 7751 RVA: 0x000959AC File Offset: 0x00093BAC
		// (set) Token: 0x06001E48 RID: 7752 RVA: 0x0000C714 File Offset: 0x0000A914
		public unsafe XmlNamespaceManager annotationNSManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_annotationNSManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNamespaceManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_annotationNSManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x06001E49 RID: 7753 RVA: 0x000959DC File Offset: 0x00093BDC
		// (set) Token: 0x06001E4A RID: 7754 RVA: 0x0000C733 File Offset: 0x0000A933
		public unsafe string xmlns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_xmlns);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_xmlns), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x06001E4B RID: 7755 RVA: 0x00095A04 File Offset: 0x00093C04
		// (set) Token: 0x06001E4C RID: 7756 RVA: 0x0000C752 File Offset: 0x0000A952
		public XmlCharType xmlCharType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_xmlCharType);
				return new XmlCharType(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_xmlCharType), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040016EC RID: 5868
		private static readonly IntPtr NativeFieldInfoPtr_schemaType;

		// Token: 0x040016ED RID: 5869
		private static readonly IntPtr NativeFieldInfoPtr_nameTable;

		// Token: 0x040016EE RID: 5870
		private static readonly IntPtr NativeFieldInfoPtr_schemaNames;

		// Token: 0x040016EF RID: 5871
		private static readonly IntPtr NativeFieldInfoPtr_eventHandler;

		// Token: 0x040016F0 RID: 5872
		private static readonly IntPtr NativeFieldInfoPtr_namespaceManager;

		// Token: 0x040016F1 RID: 5873
		private static readonly IntPtr NativeFieldInfoPtr_reader;

		// Token: 0x040016F2 RID: 5874
		private static readonly IntPtr NativeFieldInfoPtr_positionInfo;

		// Token: 0x040016F3 RID: 5875
		private static readonly IntPtr NativeFieldInfoPtr_isProcessNamespaces;

		// Token: 0x040016F4 RID: 5876
		private static readonly IntPtr NativeFieldInfoPtr_schemaXmlDepth;

		// Token: 0x040016F5 RID: 5877
		private static readonly IntPtr NativeFieldInfoPtr_markupDepth;

		// Token: 0x040016F6 RID: 5878
		private static readonly IntPtr NativeFieldInfoPtr_builder;

		// Token: 0x040016F7 RID: 5879
		private static readonly IntPtr NativeFieldInfoPtr_schema;

		// Token: 0x040016F8 RID: 5880
		private static readonly IntPtr NativeFieldInfoPtr_xdrSchema;

		// Token: 0x040016F9 RID: 5881
		private static readonly IntPtr NativeFieldInfoPtr_xmlResolver;

		// Token: 0x040016FA RID: 5882
		private static readonly IntPtr NativeFieldInfoPtr_dummyDocument;

		// Token: 0x040016FB RID: 5883
		private static readonly IntPtr NativeFieldInfoPtr_processMarkup;

		// Token: 0x040016FC RID: 5884
		private static readonly IntPtr NativeFieldInfoPtr_parentNode;

		// Token: 0x040016FD RID: 5885
		private static readonly IntPtr NativeFieldInfoPtr_annotationNSManager;

		// Token: 0x040016FE RID: 5886
		private static readonly IntPtr NativeFieldInfoPtr_xmlns;

		// Token: 0x040016FF RID: 5887
		private static readonly IntPtr NativeFieldInfoPtr_xmlCharType;

		// Token: 0x04001700 RID: 5888
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SchemaType_XmlNameTable_SchemaNames_ValidationEventHandler_0;

		// Token: 0x04001701 RID: 5889
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_SchemaType_XmlReader_String_0;

		// Token: 0x04001702 RID: 5890
		private static readonly IntPtr NativeMethodInfoPtr_StartParsing_Public_Void_XmlReader_String_0;

		// Token: 0x04001703 RID: 5891
		private static readonly IntPtr NativeMethodInfoPtr_CheckSchemaRoot_Private_Boolean_SchemaType_byref_String_0;

		// Token: 0x04001704 RID: 5892
		private static readonly IntPtr NativeMethodInfoPtr_FinishParsing_Public_SchemaType_0;

		// Token: 0x04001705 RID: 5893
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlSchema_Public_get_XmlSchema_0;

		// Token: 0x04001706 RID: 5894
		private static readonly IntPtr NativeMethodInfoPtr_set_XmlResolver_Internal_set_Void_XmlResolver_0;

		// Token: 0x04001707 RID: 5895
		private static readonly IntPtr NativeMethodInfoPtr_get_XdrSchema_Public_get_SchemaInfo_0;

		// Token: 0x04001708 RID: 5896
		private static readonly IntPtr NativeMethodInfoPtr_ParseReaderNode_Public_Boolean_0;

		// Token: 0x04001709 RID: 5897
		private static readonly IntPtr NativeMethodInfoPtr_ProcessAppInfoDocMarkup_Private_Void_Boolean_0;

		// Token: 0x0400170A RID: 5898
		private static readonly IntPtr NativeMethodInfoPtr_LoadElementNode_Private_XmlElement_Boolean_0;

		// Token: 0x0400170B RID: 5899
		private static readonly IntPtr NativeMethodInfoPtr_CreateXmlNsAttribute_Private_XmlAttribute_String_String_0;

		// Token: 0x0400170C RID: 5900
		private static readonly IntPtr NativeMethodInfoPtr_LoadAttributeNode_Private_XmlAttribute_0;

		// Token: 0x0400170D RID: 5901
		private static readonly IntPtr NativeMethodInfoPtr_LoadEntityReferenceInAttribute_Private_XmlEntityReference_0;
	}
}
