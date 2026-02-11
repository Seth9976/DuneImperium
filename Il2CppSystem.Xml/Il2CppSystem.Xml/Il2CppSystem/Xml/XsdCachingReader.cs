using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000059 RID: 89
	[DefaultMember("Item")]
	public class XsdCachingReader : XmlReader
	{
		// Token: 0x06000A61 RID: 2657 RVA: 0x00043058 File Offset: 0x00041258
		// Note: this type is marked as 'beforefieldinit'.
		static XsdCachingReader()
		{
			Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XsdCachingReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr);
			XsdCachingReader.NativeFieldInfoPtr_coreReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, "coreReader");
			XsdCachingReader.NativeFieldInfoPtr_coreReaderNameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, "coreReaderNameTable");
			XsdCachingReader.NativeFieldInfoPtr_contentEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, "contentEvents");
			XsdCachingReader.NativeFieldInfoPtr_attributeEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, "attributeEvents");
			XsdCachingReader.NativeFieldInfoPtr_cachedNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, "cachedNode");
			XsdCachingReader.NativeFieldInfoPtr_cacheState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, "cacheState");
			XsdCachingReader.NativeFieldInfoPtr_contentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, "contentIndex");
			XsdCachingReader.NativeFieldInfoPtr_attributeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, "attributeCount");
			XsdCachingReader.NativeFieldInfoPtr_returnOriginalStringValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, "returnOriginalStringValues");
			XsdCachingReader.NativeFieldInfoPtr_cacheHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, "cacheHandler");
			XsdCachingReader.NativeFieldInfoPtr_currentAttrIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, "currentAttrIndex");
			XsdCachingReader.NativeFieldInfoPtr_currentContentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, "currentContentIndex");
			XsdCachingReader.NativeFieldInfoPtr_readAhead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, "readAhead");
			XsdCachingReader.NativeFieldInfoPtr_lineInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, "lineInfo");
			XsdCachingReader.NativeFieldInfoPtr_textNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, "textNode");
			XsdCachingReader.NativeMethodInfoPtr__ctor_Internal_Void_XmlReader_IXmlLineInfo_CachingEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665030);
			XsdCachingReader.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665031);
			XsdCachingReader.NativeMethodInfoPtr_Reset_Internal_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665032);
			XsdCachingReader.NativeMethodInfoPtr_get_Settings_Public_Virtual_get_XmlReaderSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665033);
			XsdCachingReader.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665034);
			XsdCachingReader.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665035);
			XsdCachingReader.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665036);
			XsdCachingReader.NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665037);
			XsdCachingReader.NativeMethodInfoPtr_get_Prefix_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665038);
			XsdCachingReader.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665039);
			XsdCachingReader.NativeMethodInfoPtr_get_Depth_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665040);
			XsdCachingReader.NativeMethodInfoPtr_get_BaseURI_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665041);
			XsdCachingReader.NativeMethodInfoPtr_get_IsEmptyElement_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665042);
			XsdCachingReader.NativeMethodInfoPtr_get_IsDefault_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665043);
			XsdCachingReader.NativeMethodInfoPtr_get_QuoteChar_Public_Virtual_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665044);
			XsdCachingReader.NativeMethodInfoPtr_get_XmlSpace_Public_Virtual_get_XmlSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665045);
			XsdCachingReader.NativeMethodInfoPtr_get_XmlLang_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665046);
			XsdCachingReader.NativeMethodInfoPtr_get_AttributeCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665047);
			XsdCachingReader.NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665048);
			XsdCachingReader.NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665049);
			XsdCachingReader.NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665050);
			XsdCachingReader.NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665051);
			XsdCachingReader.NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665052);
			XsdCachingReader.NativeMethodInfoPtr_MoveToFirstAttribute_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665053);
			XsdCachingReader.NativeMethodInfoPtr_MoveToNextAttribute_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665054);
			XsdCachingReader.NativeMethodInfoPtr_MoveToElement_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665055);
			XsdCachingReader.NativeMethodInfoPtr_Read_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665056);
			XsdCachingReader.NativeMethodInfoPtr_RecordTextNode_Internal_ValidatingReaderNodeData_String_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665057);
			XsdCachingReader.NativeMethodInfoPtr_SwitchTextNodeAndEndElement_Internal_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665058);
			XsdCachingReader.NativeMethodInfoPtr_RecordEndElementNode_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665059);
			XsdCachingReader.NativeMethodInfoPtr_get_EOF_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665060);
			XsdCachingReader.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665061);
			XsdCachingReader.NativeMethodInfoPtr_get_ReadState_Public_Virtual_get_ReadState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665062);
			XsdCachingReader.NativeMethodInfoPtr_Skip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665063);
			XsdCachingReader.NativeMethodInfoPtr_get_NameTable_Public_Virtual_get_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665064);
			XsdCachingReader.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665065);
			XsdCachingReader.NativeMethodInfoPtr_ResolveEntity_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665066);
			XsdCachingReader.NativeMethodInfoPtr_ReadAttributeValue_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665067);
			XsdCachingReader.NativeMethodInfoPtr_System_Xml_IXmlLineInfo_HasLineInfo_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665068);
			XsdCachingReader.NativeMethodInfoPtr_System_Xml_IXmlLineInfo_get_LineNumber_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665069);
			XsdCachingReader.NativeMethodInfoPtr_System_Xml_IXmlLineInfo_get_LinePosition_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665070);
			XsdCachingReader.NativeMethodInfoPtr_SetToReplayMode_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665071);
			XsdCachingReader.NativeMethodInfoPtr_GetCoreReader_Internal_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665072);
			XsdCachingReader.NativeMethodInfoPtr_GetLineInfo_Internal_IXmlLineInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665073);
			XsdCachingReader.NativeMethodInfoPtr_ClearAttributesInfo_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665074);
			XsdCachingReader.NativeMethodInfoPtr_AddAttribute_Private_ValidatingReaderNodeData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665075);
			XsdCachingReader.NativeMethodInfoPtr_AddContent_Private_ValidatingReaderNodeData_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665076);
			XsdCachingReader.NativeMethodInfoPtr_RecordAttributes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665077);
			XsdCachingReader.NativeMethodInfoPtr_GetAttributeIndexWithoutPrefix_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665078);
			XsdCachingReader.NativeMethodInfoPtr_GetAttributeIndexWithPrefix_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665079);
			XsdCachingReader.NativeMethodInfoPtr_CreateDummyTextNode_Private_ValidatingReaderNodeData_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr, 100665080);
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x000435B0 File Offset: 0x000417B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372722, XrefRangeEnd = 372737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XsdCachingReader(XmlReader reader, IXmlLineInfo lineInfo, CachingEventHandler handlerMethod)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XsdCachingReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lineInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handlerMethod);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdCachingReader.NativeMethodInfoPtr__ctor_Internal_Void_XmlReader_IXmlLineInfo_CachingEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x00043620 File Offset: 0x00041820
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 372743, RefRangeEnd = 372747, XrefRangeStart = 372737, XrefRangeEnd = 372743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdCachingReader.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x00043654 File Offset: 0x00041854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372747, XrefRangeEnd = 372749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset(XmlReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdCachingReader.NativeMethodInfoPtr_Reset_Internal_Void_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000A65 RID: 2661 RVA: 0x00043698 File Offset: 0x00041898
		public unsafe override XmlReaderSettings Settings
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372749, XrefRangeEnd = 372750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdCachingReader.NativeMethodInfoPtr_get_Settings_Public_Virtual_get_XmlReaderSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlReaderSettings>(intPtr3) : null;
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000A66 RID: 2662 RVA: 0x000436E4 File Offset: 0x000418E4
		public unsafe override XmlNodeType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdCachingReader.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000A67 RID: 2663 RVA: 0x0004372C File Offset: 0x0004192C
		public unsafe override string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372750, XrefRangeEnd = 372752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdCachingReader.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000A68 RID: 2664 RVA: 0x00043770 File Offset: 0x00041970
		public unsafe override string LocalName
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 372752, RefRangeEnd = 372755, XrefRangeStart = 372752, XrefRangeEnd = 372752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdCachingReader.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000A69 RID: 2665 RVA: 0x000437B4 File Offset: 0x000419B4
		public unsafe override string NamespaceURI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdCachingReader.NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000A6A RID: 2666 RVA: 0x000437F8 File Offset: 0x000419F8
		public unsafe override string Prefix
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdCachingReader.NativeMethodInfoPtr_get_Prefix_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x0004383C File Offset: 0x00041A3C
		public unsafe override string Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdCachingReader.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000A6C RID: 2668 RVA: 0x00043880 File Offset: 0x00041A80
		public unsafe override int Depth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdCachingReader.NativeMethodInfoPtr_get_Depth_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000A6D RID: 2669 RVA: 0x000438C8 File Offset: 0x00041AC8
		public unsafe override string BaseURI
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdCachingReader.NativeMethodInfoPtr_get_BaseURI_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000A6E RID: 2670 RVA: 0x0004390C File Offset: 0x00041B0C
		public unsafe override bool IsEmptyElement
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdCachingReader.NativeMethodInfoPtr_get_IsEmptyElement_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000A6F RID: 2671 RVA: 0x00043954 File Offset: 0x00041B54
		public unsafe override bool IsDefault
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdCachingReader.NativeMethodInfoPtr_get_IsDefault_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000A70 RID: 2672 RVA: 0x0004399C File Offset: 0x00041B9C
		public unsafe override char QuoteChar
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdCachingReader.NativeMethodInfoPtr_get_QuoteChar_Public_Virtual_get_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000A71 RID: 2673 RVA: 0x000439E4 File Offset: 0x00041BE4
		public unsafe override XmlSpace XmlSpace
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdCachingReader.NativeMethodInfoPtr_get_XmlSpace_Public_Virtual_get_XmlSpace_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000A72 RID: 2674 RVA: 0x00043A2C File Offset: 0x00041C2C
		public unsafe override string XmlLang
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdCachingReader.NativeMethodInfoPtr_get_XmlLang_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000A73 RID: 2675 RVA: 0x00043A70 File Offset: 0x00041C70
		public unsafe override int AttributeCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdCachingReader.NativeMethodInfoPtr_get_AttributeCount_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x00043AB8 File Offset: 0x00041CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372755, XrefRangeEnd = 372759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetAttribute(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdCachingReader.NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x00043B0C File Offset: 0x00041D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372759, XrefRangeEnd = 372764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetAttribute(string name, string namespaceURI)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdCachingReader.NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x00043B74 File Offset: 0x00041D74
		[CallerCount(0)]
		public unsafe override string GetAttribute(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdCachingReader.NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x00043BC4 File Offset: 0x00041DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372764, XrefRangeEnd = 372768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MoveToAttribute(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdCachingReader.NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x00043C1C File Offset: 0x00041E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372768, XrefRangeEnd = 372777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MoveToAttribute(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdCachingReader.NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x00043C68 File Offset: 0x00041E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372777, XrefRangeEnd = 372778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MoveToFirstAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdCachingReader.NativeMethodInfoPtr_MoveToFirstAttribute_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x00043CB0 File Offset: 0x00041EB0
		[CallerCount(0)]
		public unsafe override bool MoveToNextAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdCachingReader.NativeMethodInfoPtr_MoveToNextAttribute_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x00043CF8 File Offset: 0x00041EF8
		[CallerCount(0)]
		public unsafe override bool MoveToElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdCachingReader.NativeMethodInfoPtr_MoveToElement_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x00043D40 File Offset: 0x00041F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372778, XrefRangeEnd = 372779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Read()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdCachingReader.NativeMethodInfoPtr_Read_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x00043D88 File Offset: 0x00041F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372779, XrefRangeEnd = 372782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidatingReaderNodeData RecordTextNode(string textValue, string originalStringValue, int depth, int lineNo, int linePos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(textValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(originalStringValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNo;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdCachingReader.NativeMethodInfoPtr_RecordTextNode_Internal_ValidatingReaderNodeData_String_String_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ValidatingReaderNodeData>(intPtr3) : null;
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x00043E14 File Offset: 0x00042014
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 372795, RefRangeEnd = 372797, XrefRangeStart = 372782, XrefRangeEnd = 372795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwitchTextNodeAndEndElement(string textValue, string originalStringValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(textValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(originalStringValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdCachingReader.NativeMethodInfoPtr_SwitchTextNodeAndEndElement_Internal_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x00043E68 File Offset: 0x00042068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372797, XrefRangeEnd = 372803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordEndElementNode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdCachingReader.NativeMethodInfoPtr_RecordEndElementNode_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000A80 RID: 2688 RVA: 0x00043E9C File Offset: 0x0004209C
		public unsafe override bool EOF
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdCachingReader.NativeMethodInfoPtr_get_EOF_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x00043EE4 File Offset: 0x000420E4
		[CallerCount(0)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdCachingReader.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000A82 RID: 2690 RVA: 0x00043F20 File Offset: 0x00042120
		public unsafe override ReadState ReadState
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdCachingReader.NativeMethodInfoPtr_get_ReadState_Public_Virtual_get_ReadState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x00043F68 File Offset: 0x00042168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372803, XrefRangeEnd = 372804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Skip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdCachingReader.NativeMethodInfoPtr_Skip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000A84 RID: 2692 RVA: 0x00043FA4 File Offset: 0x000421A4
		public unsafe override XmlNameTable NameTable
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdCachingReader.NativeMethodInfoPtr_get_NameTable_Public_Virtual_get_XmlNameTable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr3) : null;
			}
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x00043FF0 File Offset: 0x000421F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string LookupNamespace(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdCachingReader.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x00044044 File Offset: 0x00042244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372804, XrefRangeEnd = 372809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ResolveEntity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdCachingReader.NativeMethodInfoPtr_ResolveEntity_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x00044080 File Offset: 0x00042280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372809, XrefRangeEnd = 372816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadAttributeValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XsdCachingReader.NativeMethodInfoPtr_ReadAttributeValue_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x000440C8 File Offset: 0x000422C8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool System_Xml_IXmlLineInfo_HasLineInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdCachingReader.NativeMethodInfoPtr_System_Xml_IXmlLineInfo_HasLineInfo_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x00044104 File Offset: 0x00042304
		public unsafe virtual int System.Xml.IXmlLineInfo.LineNumber
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdCachingReader.NativeMethodInfoPtr_System_Xml_IXmlLineInfo_get_LineNumber_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000A8A RID: 2698 RVA: 0x00044140 File Offset: 0x00042340
		public unsafe virtual int System.Xml.IXmlLineInfo.LinePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdCachingReader.NativeMethodInfoPtr_System_Xml_IXmlLineInfo_get_LinePosition_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x0004417C File Offset: 0x0004237C
		[CallerCount(0)]
		public unsafe void SetToReplayMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdCachingReader.NativeMethodInfoPtr_SetToReplayMode_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x000441B0 File Offset: 0x000423B0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlReader GetCoreReader()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdCachingReader.NativeMethodInfoPtr_GetCoreReader_Internal_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlReader>(intPtr3) : null;
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x000441F0 File Offset: 0x000423F0
		[CallerCount(0)]
		public unsafe IXmlLineInfo GetLineInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdCachingReader.NativeMethodInfoPtr_GetLineInfo_Internal_IXmlLineInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlLineInfo>(intPtr3) : null;
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x00044230 File Offset: 0x00042430
		[CallerCount(0)]
		public unsafe void ClearAttributesInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdCachingReader.NativeMethodInfoPtr_ClearAttributesInfo_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x00044264 File Offset: 0x00042464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372816, XrefRangeEnd = 372827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidatingReaderNodeData AddAttribute(int attIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref attIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdCachingReader.NativeMethodInfoPtr_AddAttribute_Private_ValidatingReaderNodeData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ValidatingReaderNodeData>(intPtr3) : null;
			}
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x000442B0 File Offset: 0x000424B0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 372838, RefRangeEnd = 372842, XrefRangeStart = 372827, XrefRangeEnd = 372838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidatingReaderNodeData AddContent(XmlNodeType nodeType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodeType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdCachingReader.NativeMethodInfoPtr_AddContent_Private_ValidatingReaderNodeData_XmlNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ValidatingReaderNodeData>(intPtr3) : null;
			}
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x000442FC File Offset: 0x000424FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 372858, RefRangeEnd = 372859, XrefRangeStart = 372842, XrefRangeEnd = 372858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdCachingReader.NativeMethodInfoPtr_RecordAttributes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x00044330 File Offset: 0x00042530
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 372860, RefRangeEnd = 372862, XrefRangeStart = 372859, XrefRangeEnd = 372860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetAttributeIndexWithoutPrefix(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdCachingReader.NativeMethodInfoPtr_GetAttributeIndexWithoutPrefix_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x00044380 File Offset: 0x00042580
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 372864, RefRangeEnd = 372866, XrefRangeStart = 372862, XrefRangeEnd = 372864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetAttributeIndexWithPrefix(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdCachingReader.NativeMethodInfoPtr_GetAttributeIndexWithPrefix_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x000443D0 File Offset: 0x000425D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372866, XrefRangeEnd = 372872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(attributeValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XsdCachingReader.NativeMethodInfoPtr_CreateDummyTextNode_Private_ValidatingReaderNodeData_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ValidatingReaderNodeData>(intPtr3) : null;
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x0000567E File Offset: 0x0000387E
		public XsdCachingReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000A96 RID: 2710 RVA: 0x00044430 File Offset: 0x00042630
		// (set) Token: 0x06000A97 RID: 2711 RVA: 0x00005687 File Offset: 0x00003887
		public unsafe XmlReader coreReader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdCachingReader.NativeFieldInfoPtr_coreReader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdCachingReader.NativeFieldInfoPtr_coreReader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000A98 RID: 2712 RVA: 0x00044460 File Offset: 0x00042660
		// (set) Token: 0x06000A99 RID: 2713 RVA: 0x000056A6 File Offset: 0x000038A6
		public unsafe XmlNameTable coreReaderNameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdCachingReader.NativeFieldInfoPtr_coreReaderNameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdCachingReader.NativeFieldInfoPtr_coreReaderNameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000A9A RID: 2714 RVA: 0x00044490 File Offset: 0x00042690
		// (set) Token: 0x06000A9B RID: 2715 RVA: 0x000056C5 File Offset: 0x000038C5
		public unsafe Il2CppReferenceArray<ValidatingReaderNodeData> contentEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdCachingReader.NativeFieldInfoPtr_contentEvents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ValidatingReaderNodeData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdCachingReader.NativeFieldInfoPtr_contentEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000A9C RID: 2716 RVA: 0x000444C0 File Offset: 0x000426C0
		// (set) Token: 0x06000A9D RID: 2717 RVA: 0x000056E4 File Offset: 0x000038E4
		public unsafe Il2CppReferenceArray<ValidatingReaderNodeData> attributeEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdCachingReader.NativeFieldInfoPtr_attributeEvents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ValidatingReaderNodeData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdCachingReader.NativeFieldInfoPtr_attributeEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000A9E RID: 2718 RVA: 0x000444F0 File Offset: 0x000426F0
		// (set) Token: 0x06000A9F RID: 2719 RVA: 0x00005703 File Offset: 0x00003903
		public unsafe ValidatingReaderNodeData cachedNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdCachingReader.NativeFieldInfoPtr_cachedNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidatingReaderNodeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdCachingReader.NativeFieldInfoPtr_cachedNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000AA0 RID: 2720 RVA: 0x00044520 File Offset: 0x00042720
		// (set) Token: 0x06000AA1 RID: 2721 RVA: 0x00005722 File Offset: 0x00003922
		public unsafe XsdCachingReader.CachingReaderState cacheState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdCachingReader.NativeFieldInfoPtr_cacheState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdCachingReader.NativeFieldInfoPtr_cacheState)) = value;
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000AA2 RID: 2722 RVA: 0x00044548 File Offset: 0x00042748
		// (set) Token: 0x06000AA3 RID: 2723 RVA: 0x0000573D File Offset: 0x0000393D
		public unsafe int contentIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdCachingReader.NativeFieldInfoPtr_contentIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdCachingReader.NativeFieldInfoPtr_contentIndex)) = value;
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000AA4 RID: 2724 RVA: 0x00044570 File Offset: 0x00042770
		// (set) Token: 0x06000AA5 RID: 2725 RVA: 0x00005758 File Offset: 0x00003958
		public unsafe int attributeCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdCachingReader.NativeFieldInfoPtr_attributeCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdCachingReader.NativeFieldInfoPtr_attributeCount)) = value;
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000AA6 RID: 2726 RVA: 0x00044598 File Offset: 0x00042798
		// (set) Token: 0x06000AA7 RID: 2727 RVA: 0x00005773 File Offset: 0x00003973
		public unsafe bool returnOriginalStringValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdCachingReader.NativeFieldInfoPtr_returnOriginalStringValues);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdCachingReader.NativeFieldInfoPtr_returnOriginalStringValues)) = value;
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000AA8 RID: 2728 RVA: 0x000445C0 File Offset: 0x000427C0
		// (set) Token: 0x06000AA9 RID: 2729 RVA: 0x0000578E File Offset: 0x0000398E
		public unsafe CachingEventHandler cacheHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdCachingReader.NativeFieldInfoPtr_cacheHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CachingEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdCachingReader.NativeFieldInfoPtr_cacheHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000AAA RID: 2730 RVA: 0x000445F0 File Offset: 0x000427F0
		// (set) Token: 0x06000AAB RID: 2731 RVA: 0x000057AD File Offset: 0x000039AD
		public unsafe int currentAttrIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdCachingReader.NativeFieldInfoPtr_currentAttrIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdCachingReader.NativeFieldInfoPtr_currentAttrIndex)) = value;
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000AAC RID: 2732 RVA: 0x00044618 File Offset: 0x00042818
		// (set) Token: 0x06000AAD RID: 2733 RVA: 0x000057C8 File Offset: 0x000039C8
		public unsafe int currentContentIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdCachingReader.NativeFieldInfoPtr_currentContentIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdCachingReader.NativeFieldInfoPtr_currentContentIndex)) = value;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000AAE RID: 2734 RVA: 0x00044640 File Offset: 0x00042840
		// (set) Token: 0x06000AAF RID: 2735 RVA: 0x000057E3 File Offset: 0x000039E3
		public unsafe bool readAhead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdCachingReader.NativeFieldInfoPtr_readAhead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdCachingReader.NativeFieldInfoPtr_readAhead)) = value;
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000AB0 RID: 2736 RVA: 0x00044668 File Offset: 0x00042868
		// (set) Token: 0x06000AB1 RID: 2737 RVA: 0x000057FE File Offset: 0x000039FE
		public unsafe IXmlLineInfo lineInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdCachingReader.NativeFieldInfoPtr_lineInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IXmlLineInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdCachingReader.NativeFieldInfoPtr_lineInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000AB2 RID: 2738 RVA: 0x00044698 File Offset: 0x00042898
		// (set) Token: 0x06000AB3 RID: 2739 RVA: 0x0000581D File Offset: 0x00003A1D
		public unsafe ValidatingReaderNodeData textNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdCachingReader.NativeFieldInfoPtr_textNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidatingReaderNodeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XsdCachingReader.NativeFieldInfoPtr_textNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400089C RID: 2204
		private static readonly IntPtr NativeFieldInfoPtr_coreReader;

		// Token: 0x0400089D RID: 2205
		private static readonly IntPtr NativeFieldInfoPtr_coreReaderNameTable;

		// Token: 0x0400089E RID: 2206
		private static readonly IntPtr NativeFieldInfoPtr_contentEvents;

		// Token: 0x0400089F RID: 2207
		private static readonly IntPtr NativeFieldInfoPtr_attributeEvents;

		// Token: 0x040008A0 RID: 2208
		private static readonly IntPtr NativeFieldInfoPtr_cachedNode;

		// Token: 0x040008A1 RID: 2209
		private static readonly IntPtr NativeFieldInfoPtr_cacheState;

		// Token: 0x040008A2 RID: 2210
		private static readonly IntPtr NativeFieldInfoPtr_contentIndex;

		// Token: 0x040008A3 RID: 2211
		private static readonly IntPtr NativeFieldInfoPtr_attributeCount;

		// Token: 0x040008A4 RID: 2212
		private static readonly IntPtr NativeFieldInfoPtr_returnOriginalStringValues;

		// Token: 0x040008A5 RID: 2213
		private static readonly IntPtr NativeFieldInfoPtr_cacheHandler;

		// Token: 0x040008A6 RID: 2214
		private static readonly IntPtr NativeFieldInfoPtr_currentAttrIndex;

		// Token: 0x040008A7 RID: 2215
		private static readonly IntPtr NativeFieldInfoPtr_currentContentIndex;

		// Token: 0x040008A8 RID: 2216
		private static readonly IntPtr NativeFieldInfoPtr_readAhead;

		// Token: 0x040008A9 RID: 2217
		private static readonly IntPtr NativeFieldInfoPtr_lineInfo;

		// Token: 0x040008AA RID: 2218
		private static readonly IntPtr NativeFieldInfoPtr_textNode;

		// Token: 0x040008AB RID: 2219
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlReader_IXmlLineInfo_CachingEventHandler_0;

		// Token: 0x040008AC RID: 2220
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x040008AD RID: 2221
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Void_XmlReader_0;

		// Token: 0x040008AE RID: 2222
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings_Public_Virtual_get_XmlReaderSettings_0;

		// Token: 0x040008AF RID: 2223
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0;

		// Token: 0x040008B0 RID: 2224
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x040008B1 RID: 2225
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0;

		// Token: 0x040008B2 RID: 2226
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_get_String_0;

		// Token: 0x040008B3 RID: 2227
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Public_Virtual_get_String_0;

		// Token: 0x040008B4 RID: 2228
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0;

		// Token: 0x040008B5 RID: 2229
		private static readonly IntPtr NativeMethodInfoPtr_get_Depth_Public_Virtual_get_Int32_0;

		// Token: 0x040008B6 RID: 2230
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseURI_Public_Virtual_get_String_0;

		// Token: 0x040008B7 RID: 2231
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEmptyElement_Public_Virtual_get_Boolean_0;

		// Token: 0x040008B8 RID: 2232
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDefault_Public_Virtual_get_Boolean_0;

		// Token: 0x040008B9 RID: 2233
		private static readonly IntPtr NativeMethodInfoPtr_get_QuoteChar_Public_Virtual_get_Char_0;

		// Token: 0x040008BA RID: 2234
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlSpace_Public_Virtual_get_XmlSpace_0;

		// Token: 0x040008BB RID: 2235
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlLang_Public_Virtual_get_String_0;

		// Token: 0x040008BC RID: 2236
		private static readonly IntPtr NativeMethodInfoPtr_get_AttributeCount_Public_Virtual_get_Int32_0;

		// Token: 0x040008BD RID: 2237
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_String_0;

		// Token: 0x040008BE RID: 2238
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_String_String_0;

		// Token: 0x040008BF RID: 2239
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_String_Int32_0;

		// Token: 0x040008C0 RID: 2240
		private static readonly IntPtr NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Boolean_String_0;

		// Token: 0x040008C1 RID: 2241
		private static readonly IntPtr NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Void_Int32_0;

		// Token: 0x040008C2 RID: 2242
		private static readonly IntPtr NativeMethodInfoPtr_MoveToFirstAttribute_Public_Virtual_Boolean_0;

		// Token: 0x040008C3 RID: 2243
		private static readonly IntPtr NativeMethodInfoPtr_MoveToNextAttribute_Public_Virtual_Boolean_0;

		// Token: 0x040008C4 RID: 2244
		private static readonly IntPtr NativeMethodInfoPtr_MoveToElement_Public_Virtual_Boolean_0;

		// Token: 0x040008C5 RID: 2245
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Boolean_0;

		// Token: 0x040008C6 RID: 2246
		private static readonly IntPtr NativeMethodInfoPtr_RecordTextNode_Internal_ValidatingReaderNodeData_String_String_Int32_Int32_Int32_0;

		// Token: 0x040008C7 RID: 2247
		private static readonly IntPtr NativeMethodInfoPtr_SwitchTextNodeAndEndElement_Internal_Void_String_String_0;

		// Token: 0x040008C8 RID: 2248
		private static readonly IntPtr NativeMethodInfoPtr_RecordEndElementNode_Internal_Void_0;

		// Token: 0x040008C9 RID: 2249
		private static readonly IntPtr NativeMethodInfoPtr_get_EOF_Public_Virtual_get_Boolean_0;

		// Token: 0x040008CA RID: 2250
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x040008CB RID: 2251
		private static readonly IntPtr NativeMethodInfoPtr_get_ReadState_Public_Virtual_get_ReadState_0;

		// Token: 0x040008CC RID: 2252
		private static readonly IntPtr NativeMethodInfoPtr_Skip_Public_Virtual_Void_0;

		// Token: 0x040008CD RID: 2253
		private static readonly IntPtr NativeMethodInfoPtr_get_NameTable_Public_Virtual_get_XmlNameTable_0;

		// Token: 0x040008CE RID: 2254
		private static readonly IntPtr NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0;

		// Token: 0x040008CF RID: 2255
		private static readonly IntPtr NativeMethodInfoPtr_ResolveEntity_Public_Virtual_Void_0;

		// Token: 0x040008D0 RID: 2256
		private static readonly IntPtr NativeMethodInfoPtr_ReadAttributeValue_Public_Virtual_Boolean_0;

		// Token: 0x040008D1 RID: 2257
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IXmlLineInfo_HasLineInfo_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040008D2 RID: 2258
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IXmlLineInfo_get_LineNumber_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x040008D3 RID: 2259
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IXmlLineInfo_get_LinePosition_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x040008D4 RID: 2260
		private static readonly IntPtr NativeMethodInfoPtr_SetToReplayMode_Internal_Void_0;

		// Token: 0x040008D5 RID: 2261
		private static readonly IntPtr NativeMethodInfoPtr_GetCoreReader_Internal_XmlReader_0;

		// Token: 0x040008D6 RID: 2262
		private static readonly IntPtr NativeMethodInfoPtr_GetLineInfo_Internal_IXmlLineInfo_0;

		// Token: 0x040008D7 RID: 2263
		private static readonly IntPtr NativeMethodInfoPtr_ClearAttributesInfo_Private_Void_0;

		// Token: 0x040008D8 RID: 2264
		private static readonly IntPtr NativeMethodInfoPtr_AddAttribute_Private_ValidatingReaderNodeData_Int32_0;

		// Token: 0x040008D9 RID: 2265
		private static readonly IntPtr NativeMethodInfoPtr_AddContent_Private_ValidatingReaderNodeData_XmlNodeType_0;

		// Token: 0x040008DA RID: 2266
		private static readonly IntPtr NativeMethodInfoPtr_RecordAttributes_Private_Void_0;

		// Token: 0x040008DB RID: 2267
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributeIndexWithoutPrefix_Private_Int32_String_0;

		// Token: 0x040008DC RID: 2268
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributeIndexWithPrefix_Private_Int32_String_0;

		// Token: 0x040008DD RID: 2269
		private static readonly IntPtr NativeMethodInfoPtr_CreateDummyTextNode_Private_ValidatingReaderNodeData_String_Int32_0;

		// Token: 0x0200023A RID: 570
		public enum CachingReaderState
		{
			// Token: 0x04002541 RID: 9537
			None,
			// Token: 0x04002542 RID: 9538
			Init,
			// Token: 0x04002543 RID: 9539
			Record,
			// Token: 0x04002544 RID: 9540
			Replay,
			// Token: 0x04002545 RID: 9541
			ReaderClosed,
			// Token: 0x04002546 RID: 9542
			Error
		}
	}
}
