using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200006F RID: 111
	public class XmlLoader : Object
	{
		// Token: 0x06000D71 RID: 3441 RVA: 0x00050678 File Offset: 0x0004E878
		// Note: this type is marked as 'beforefieldinit'.
		static XmlLoader()
		{
			Il2CppClassPointerStore<XmlLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr);
			XmlLoader.NativeFieldInfoPtr_doc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, "doc");
			XmlLoader.NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, "reader");
			XmlLoader.NativeFieldInfoPtr_preserveWhitespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, "preserveWhitespace");
			XmlLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665488);
			XmlLoader.NativeMethodInfoPtr_Load_Internal_Void_XmlDocument_XmlReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665489);
			XmlLoader.NativeMethodInfoPtr_LoadDocSequence_Private_Void_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665490);
			XmlLoader.NativeMethodInfoPtr_ReadCurrentNode_Internal_XmlNode_XmlDocument_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665491);
			XmlLoader.NativeMethodInfoPtr_LoadNode_Private_XmlNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665492);
			XmlLoader.NativeMethodInfoPtr_LoadAttributeNode_Private_XmlAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665493);
			XmlLoader.NativeMethodInfoPtr_LoadDefaultAttribute_Private_XmlAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665494);
			XmlLoader.NativeMethodInfoPtr_LoadAttributeValue_Private_Void_XmlNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665495);
			XmlLoader.NativeMethodInfoPtr_LoadEntityReferenceNode_Private_XmlEntityReference_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665496);
			XmlLoader.NativeMethodInfoPtr_LoadDeclarationNode_Private_XmlDeclaration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665497);
			XmlLoader.NativeMethodInfoPtr_LoadDocumentTypeNode_Private_XmlDocumentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665498);
			XmlLoader.NativeMethodInfoPtr_LoadNodeDirect_Private_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665499);
			XmlLoader.NativeMethodInfoPtr_LoadAttributeNodeDirect_Private_XmlAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665500);
			XmlLoader.NativeMethodInfoPtr_ParseDocumentType_Internal_Void_XmlDocumentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665501);
			XmlLoader.NativeMethodInfoPtr_ParseDocumentType_Private_Void_XmlDocumentType_Boolean_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665502);
			XmlLoader.NativeMethodInfoPtr_LoadDocumentType_Private_Void_IDtdInfo_XmlDocumentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665503);
			XmlLoader.NativeMethodInfoPtr_GetContext_Private_XmlParserContext_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665504);
			XmlLoader.NativeMethodInfoPtr_ParsePartialContent_Internal_XmlNamespaceManager_XmlNode_String_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665505);
			XmlLoader.NativeMethodInfoPtr_LoadInnerXmlElement_Internal_Void_XmlElement_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665506);
			XmlLoader.NativeMethodInfoPtr_LoadInnerXmlAttribute_Internal_Void_XmlAttribute_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665507);
			XmlLoader.NativeMethodInfoPtr_RemoveDuplicateNamespace_Private_Void_XmlElement_XmlNamespaceManager_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665508);
			XmlLoader.NativeMethodInfoPtr_EntitizeName_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665509);
			XmlLoader.NativeMethodInfoPtr_ExpandEntity_Internal_Void_XmlEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665510);
			XmlLoader.NativeMethodInfoPtr_ExpandEntityReference_Internal_Void_XmlEntityReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665511);
			XmlLoader.NativeMethodInfoPtr_CreateInnerXmlReader_Private_XmlReader_String_XmlNodeType_XmlParserContext_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665512);
			XmlLoader.NativeMethodInfoPtr_ParseXmlDeclarationValue_Internal_Static_Void_String_byref_String_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665513);
			XmlLoader.NativeMethodInfoPtr_UnexpectedNodeType_Internal_Static_Exception_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100665514);
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x00050900 File Offset: 0x0004EB00
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlLoader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x0005093C File Offset: 0x0004EB3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 374657, RefRangeEnd = 374658, XrefRangeStart = 374640, XrefRangeEnd = 374657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(XmlDocument doc, XmlReader reader, bool preserveWhitespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(doc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preserveWhitespace;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_Load_Internal_Void_XmlDocument_XmlReader_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x000509A0 File Offset: 0x0004EBA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374658, XrefRangeEnd = 374659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadDocSequence(XmlDocument parentDoc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentDoc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_LoadDocSequence_Private_Void_XmlDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x000509E4 File Offset: 0x0004EBE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 374661, RefRangeEnd = 374662, XrefRangeStart = 374659, XrefRangeEnd = 374661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNode ReadCurrentNode(XmlDocument doc, XmlReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(doc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_ReadCurrentNode_Internal_XmlNode_XmlDocument_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x00050A48 File Offset: 0x0004EC48
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 374682, RefRangeEnd = 374686, XrefRangeStart = 374662, XrefRangeEnd = 374682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNode LoadNode(bool skipOverWhitespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref skipOverWhitespace;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_LoadNode_Private_XmlNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x00050A94 File Offset: 0x0004EC94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 374693, RefRangeEnd = 374695, XrefRangeStart = 374686, XrefRangeEnd = 374693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAttribute LoadAttributeNode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_LoadAttributeNode_Private_XmlAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAttribute>(intPtr3) : null;
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x00050AD4 File Offset: 0x0004ECD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374695, XrefRangeEnd = 374703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAttribute LoadDefaultAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_LoadDefaultAttribute_Private_XmlAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAttribute>(intPtr3) : null;
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x00050B14 File Offset: 0x0004ED14
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 374722, RefRangeEnd = 374727, XrefRangeStart = 374703, XrefRangeEnd = 374722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadAttributeValue(XmlNode parent, bool direct)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direct;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_LoadAttributeValue_Private_Void_XmlNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x00050B64 File Offset: 0x0004ED64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 374738, RefRangeEnd = 374740, XrefRangeStart = 374727, XrefRangeEnd = 374738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlEntityReference LoadEntityReferenceNode(bool direct)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref direct;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_LoadEntityReferenceNode_Private_XmlEntityReference_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlEntityReference>(intPtr3) : null;
			}
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x00050BB0 File Offset: 0x0004EDB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374740, XrefRangeEnd = 374753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlDeclaration LoadDeclarationNode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_LoadDeclarationNode_Private_XmlDeclaration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlDeclaration>(intPtr3) : null;
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x00050BF0 File Offset: 0x0004EDF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 374765, RefRangeEnd = 374766, XrefRangeStart = 374753, XrefRangeEnd = 374765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlDocumentType LoadDocumentTypeNode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_LoadDocumentTypeNode_Private_XmlDocumentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlDocumentType>(intPtr3) : null;
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x00050C30 File Offset: 0x0004EE30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 374811, RefRangeEnd = 374813, XrefRangeStart = 374766, XrefRangeEnd = 374811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNode LoadNodeDirect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_LoadNodeDirect_Private_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x00050C70 File Offset: 0x0004EE70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 374820, RefRangeEnd = 374822, XrefRangeStart = 374813, XrefRangeEnd = 374820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAttribute LoadAttributeNodeDirect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_LoadAttributeNodeDirect_Private_XmlAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAttribute>(intPtr3) : null;
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x00050CB0 File Offset: 0x0004EEB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374822, XrefRangeEnd = 374823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseDocumentType(XmlDocumentType dtNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dtNode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_ParseDocumentType_Internal_Void_XmlDocumentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x00050CF4 File Offset: 0x0004EEF4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 374852, RefRangeEnd = 374856, XrefRangeStart = 374823, XrefRangeEnd = 374852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseDocumentType(XmlDocumentType dtNode, bool bUseResolver, XmlResolver resolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dtNode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bUseResolver;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_ParseDocumentType_Private_Void_XmlDocumentType_Boolean_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x00050D58 File Offset: 0x0004EF58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 374984, RefRangeEnd = 374986, XrefRangeStart = 374856, XrefRangeEnd = 374984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadDocumentType(IDtdInfo dtdInfo, XmlDocumentType dtNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dtdInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtNode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_LoadDocumentType_Private_Void_IDtdInfo_XmlDocumentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x00050DAC File Offset: 0x0004EFAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 375034, RefRangeEnd = 375035, XrefRangeStart = 374986, XrefRangeEnd = 375034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlParserContext GetContext(XmlNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_GetContext_Private_XmlParserContext_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlParserContext>(intPtr3) : null;
			}
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x00050DFC File Offset: 0x0004EFFC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 375044, RefRangeEnd = 375051, XrefRangeStart = 375035, XrefRangeEnd = 375044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNamespaceManager ParsePartialContent(XmlNode parentNode, string innerxmltext, XmlNodeType nt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentNode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(innerxmltext);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_ParsePartialContent_Internal_XmlNamespaceManager_XmlNode_String_XmlNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNamespaceManager>(intPtr3) : null;
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x00050E6C File Offset: 0x0004F06C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375051, XrefRangeEnd = 375053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadInnerXmlElement(XmlElement node, string innerxmltext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(innerxmltext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_LoadInnerXmlElement_Internal_Void_XmlElement_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x00050EC0 File Offset: 0x0004F0C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375053, XrefRangeEnd = 375054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadInnerXmlAttribute(XmlAttribute node, string innerxmltext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(innerxmltext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_LoadInnerXmlAttribute_Internal_Void_XmlAttribute_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x00050F14 File Offset: 0x0004F114
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 375065, RefRangeEnd = 375068, XrefRangeStart = 375054, XrefRangeEnd = 375065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveDuplicateNamespace(XmlElement elem, XmlNamespaceManager mgr, bool fCheckElemAttrs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mgr);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fCheckElemAttrs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_RemoveDuplicateNamespace_Private_Void_XmlElement_XmlNamespaceManager_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x00050F78 File Offset: 0x0004F178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375068, XrefRangeEnd = 375073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string EntitizeName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_EntitizeName_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x00050FC0 File Offset: 0x0004F1C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375073, XrefRangeEnd = 375079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExpandEntity(XmlEntity ent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_ExpandEntity_Internal_Void_XmlEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x00051004 File Offset: 0x0004F204
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 375097, RefRangeEnd = 375098, XrefRangeStart = 375079, XrefRangeEnd = 375097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExpandEntityReference(XmlEntityReference eref)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eref);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_ExpandEntityReference_Internal_Void_XmlEntityReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x00051048 File Offset: 0x0004F248
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 375119, RefRangeEnd = 375120, XrefRangeStart = 375098, XrefRangeEnd = 375119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlReader CreateInnerXmlReader(string xmlFragment, XmlNodeType nt, XmlParserContext context, XmlDocument doc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xmlFragment);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nt;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(doc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_CreateInnerXmlReader_Private_XmlReader_String_XmlNodeType_XmlParserContext_XmlDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlReader>(intPtr3) : null;
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x000510CC File Offset: 0x0004F2CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 375137, RefRangeEnd = 375139, XrefRangeStart = 375120, XrefRangeEnd = 375137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ParseXmlDeclarationValue(string strValue, out string version, out string encoding, out string standalone)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strValue);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_ParseXmlDeclarationValue_Internal_Static_Void_String_byref_String_byref_String_byref_String_0, 0, (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			version = IL2CPP.Il2CppStringToManaged(intPtr);
			encoding = IL2CPP.Il2CppStringToManaged(intPtr2);
			standalone = IL2CPP.Il2CppStringToManaged(intPtr3);
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x00051154 File Offset: 0x0004F354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375139, XrefRangeEnd = 375154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception UnexpectedNodeType(XmlNodeType nodetype)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodetype;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_UnexpectedNodeType_Internal_Static_Exception_XmlNodeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x000067D7 File Offset: 0x000049D7
		public XmlLoader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06000D8E RID: 3470 RVA: 0x00051194 File Offset: 0x0004F394
		// (set) Token: 0x06000D8F RID: 3471 RVA: 0x000067E0 File Offset: 0x000049E0
		public unsafe XmlDocument doc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlLoader.NativeFieldInfoPtr_doc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlDocument>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlLoader.NativeFieldInfoPtr_doc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06000D90 RID: 3472 RVA: 0x000511C4 File Offset: 0x0004F3C4
		// (set) Token: 0x06000D91 RID: 3473 RVA: 0x000067FF File Offset: 0x000049FF
		public unsafe XmlReader reader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlLoader.NativeFieldInfoPtr_reader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlLoader.NativeFieldInfoPtr_reader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000D92 RID: 3474 RVA: 0x000511F4 File Offset: 0x0004F3F4
		// (set) Token: 0x06000D93 RID: 3475 RVA: 0x0000681E File Offset: 0x00004A1E
		public unsafe bool preserveWhitespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlLoader.NativeFieldInfoPtr_preserveWhitespace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlLoader.NativeFieldInfoPtr_preserveWhitespace)) = value;
			}
		}

		// Token: 0x04000AF6 RID: 2806
		private static readonly IntPtr NativeFieldInfoPtr_doc;

		// Token: 0x04000AF7 RID: 2807
		private static readonly IntPtr NativeFieldInfoPtr_reader;

		// Token: 0x04000AF8 RID: 2808
		private static readonly IntPtr NativeFieldInfoPtr_preserveWhitespace;

		// Token: 0x04000AF9 RID: 2809
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000AFA RID: 2810
		private static readonly IntPtr NativeMethodInfoPtr_Load_Internal_Void_XmlDocument_XmlReader_Boolean_0;

		// Token: 0x04000AFB RID: 2811
		private static readonly IntPtr NativeMethodInfoPtr_LoadDocSequence_Private_Void_XmlDocument_0;

		// Token: 0x04000AFC RID: 2812
		private static readonly IntPtr NativeMethodInfoPtr_ReadCurrentNode_Internal_XmlNode_XmlDocument_XmlReader_0;

		// Token: 0x04000AFD RID: 2813
		private static readonly IntPtr NativeMethodInfoPtr_LoadNode_Private_XmlNode_Boolean_0;

		// Token: 0x04000AFE RID: 2814
		private static readonly IntPtr NativeMethodInfoPtr_LoadAttributeNode_Private_XmlAttribute_0;

		// Token: 0x04000AFF RID: 2815
		private static readonly IntPtr NativeMethodInfoPtr_LoadDefaultAttribute_Private_XmlAttribute_0;

		// Token: 0x04000B00 RID: 2816
		private static readonly IntPtr NativeMethodInfoPtr_LoadAttributeValue_Private_Void_XmlNode_Boolean_0;

		// Token: 0x04000B01 RID: 2817
		private static readonly IntPtr NativeMethodInfoPtr_LoadEntityReferenceNode_Private_XmlEntityReference_Boolean_0;

		// Token: 0x04000B02 RID: 2818
		private static readonly IntPtr NativeMethodInfoPtr_LoadDeclarationNode_Private_XmlDeclaration_0;

		// Token: 0x04000B03 RID: 2819
		private static readonly IntPtr NativeMethodInfoPtr_LoadDocumentTypeNode_Private_XmlDocumentType_0;

		// Token: 0x04000B04 RID: 2820
		private static readonly IntPtr NativeMethodInfoPtr_LoadNodeDirect_Private_XmlNode_0;

		// Token: 0x04000B05 RID: 2821
		private static readonly IntPtr NativeMethodInfoPtr_LoadAttributeNodeDirect_Private_XmlAttribute_0;

		// Token: 0x04000B06 RID: 2822
		private static readonly IntPtr NativeMethodInfoPtr_ParseDocumentType_Internal_Void_XmlDocumentType_0;

		// Token: 0x04000B07 RID: 2823
		private static readonly IntPtr NativeMethodInfoPtr_ParseDocumentType_Private_Void_XmlDocumentType_Boolean_XmlResolver_0;

		// Token: 0x04000B08 RID: 2824
		private static readonly IntPtr NativeMethodInfoPtr_LoadDocumentType_Private_Void_IDtdInfo_XmlDocumentType_0;

		// Token: 0x04000B09 RID: 2825
		private static readonly IntPtr NativeMethodInfoPtr_GetContext_Private_XmlParserContext_XmlNode_0;

		// Token: 0x04000B0A RID: 2826
		private static readonly IntPtr NativeMethodInfoPtr_ParsePartialContent_Internal_XmlNamespaceManager_XmlNode_String_XmlNodeType_0;

		// Token: 0x04000B0B RID: 2827
		private static readonly IntPtr NativeMethodInfoPtr_LoadInnerXmlElement_Internal_Void_XmlElement_String_0;

		// Token: 0x04000B0C RID: 2828
		private static readonly IntPtr NativeMethodInfoPtr_LoadInnerXmlAttribute_Internal_Void_XmlAttribute_String_0;

		// Token: 0x04000B0D RID: 2829
		private static readonly IntPtr NativeMethodInfoPtr_RemoveDuplicateNamespace_Private_Void_XmlElement_XmlNamespaceManager_Boolean_0;

		// Token: 0x04000B0E RID: 2830
		private static readonly IntPtr NativeMethodInfoPtr_EntitizeName_Private_String_String_0;

		// Token: 0x04000B0F RID: 2831
		private static readonly IntPtr NativeMethodInfoPtr_ExpandEntity_Internal_Void_XmlEntity_0;

		// Token: 0x04000B10 RID: 2832
		private static readonly IntPtr NativeMethodInfoPtr_ExpandEntityReference_Internal_Void_XmlEntityReference_0;

		// Token: 0x04000B11 RID: 2833
		private static readonly IntPtr NativeMethodInfoPtr_CreateInnerXmlReader_Private_XmlReader_String_XmlNodeType_XmlParserContext_XmlDocument_0;

		// Token: 0x04000B12 RID: 2834
		private static readonly IntPtr NativeMethodInfoPtr_ParseXmlDeclarationValue_Internal_Static_Void_String_byref_String_byref_String_byref_String_0;

		// Token: 0x04000B13 RID: 2835
		private static readonly IntPtr NativeMethodInfoPtr_UnexpectedNodeType_Internal_Static_Exception_XmlNodeType_0;
	}
}
