using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Xml.XPath;

namespace MS.Internal.Xml.Cache
{
	// Token: 0x0200020A RID: 522
	public sealed class XPathNode : ValueType
	{
		// Token: 0x06002DE4 RID: 11748 RVA: 0x000D2B98 File Offset: 0x000D0D98
		// Note: this type is marked as 'beforefieldinit'.
		static XPathNode()
		{
			Il2CppClassPointerStore<XPathNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "MS.Internal.Xml.Cache", "XPathNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XPathNode>.NativeClassPtr);
			XPathNode.NativeFieldInfoPtr__info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, "_info");
			XPathNode.NativeFieldInfoPtr__idxSibling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, "_idxSibling");
			XPathNode.NativeFieldInfoPtr__idxParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, "_idxParent");
			XPathNode.NativeFieldInfoPtr__idxSimilar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, "_idxSimilar");
			XPathNode.NativeFieldInfoPtr__posOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, "_posOffset");
			XPathNode.NativeFieldInfoPtr__props = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, "_props");
			XPathNode.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, "_value");
			XPathNode.NativeMethodInfoPtr_get_NodeType_Public_get_XPathNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100669920);
			XPathNode.NativeMethodInfoPtr_get_Prefix_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100669921);
			XPathNode.NativeMethodInfoPtr_get_LocalName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100669922);
			XPathNode.NativeMethodInfoPtr_get_NamespaceUri_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100669923);
			XPathNode.NativeMethodInfoPtr_get_Document_Public_get_XPathDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100669924);
			XPathNode.NativeMethodInfoPtr_get_LineNumber_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100669925);
			XPathNode.NativeMethodInfoPtr_get_LinePosition_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100669926);
			XPathNode.NativeMethodInfoPtr_get_CollapsedLinePosition_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100669927);
			XPathNode.NativeMethodInfoPtr_get_PageInfo_Public_get_XPathNodePageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100669928);
			XPathNode.NativeMethodInfoPtr_GetParent_Public_Int32_byref_Il2CppReferenceArray_1_XPathNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100669929);
			XPathNode.NativeMethodInfoPtr_GetSibling_Public_Int32_byref_Il2CppReferenceArray_1_XPathNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100669930);
			XPathNode.NativeMethodInfoPtr_get_IsXmlNamespaceNode_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100669931);
			XPathNode.NativeMethodInfoPtr_get_HasSibling_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100669932);
			XPathNode.NativeMethodInfoPtr_get_HasCollapsedText_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100669933);
			XPathNode.NativeMethodInfoPtr_get_IsText_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100669934);
			XPathNode.NativeMethodInfoPtr_get_HasNamespaceDecls_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100669935);
			XPathNode.NativeMethodInfoPtr_get_Value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100669936);
		}

		// Token: 0x17000F58 RID: 3928
		// (get) Token: 0x06002DE5 RID: 11749 RVA: 0x000D2DA8 File Offset: 0x000D0FA8
		public unsafe XPathNodeType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_get_NodeType_Public_get_XPathNodeType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F59 RID: 3929
		// (get) Token: 0x06002DE6 RID: 11750 RVA: 0x000D2DEC File Offset: 0x000D0FEC
		public unsafe string Prefix
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_get_Prefix_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000F5A RID: 3930
		// (get) Token: 0x06002DE7 RID: 11751 RVA: 0x000D2E28 File Offset: 0x000D1028
		public unsafe string LocalName
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 426614, RefRangeEnd = 426617, XrefRangeStart = 426614, XrefRangeEnd = 426614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_get_LocalName_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000F5B RID: 3931
		// (get) Token: 0x06002DE8 RID: 11752 RVA: 0x000D2E64 File Offset: 0x000D1064
		public unsafe string NamespaceUri
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_get_NamespaceUri_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000F5C RID: 3932
		// (get) Token: 0x06002DE9 RID: 11753 RVA: 0x000D2EA0 File Offset: 0x000D10A0
		public unsafe XPathDocument Document
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_get_Document_Public_get_XPathDocument_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XPathDocument>(intPtr3) : null;
			}
		}

		// Token: 0x17000F5D RID: 3933
		// (get) Token: 0x06002DEA RID: 11754 RVA: 0x000D2EE4 File Offset: 0x000D10E4
		public unsafe int LineNumber
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_get_LineNumber_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F5E RID: 3934
		// (get) Token: 0x06002DEB RID: 11755 RVA: 0x000D2F28 File Offset: 0x000D1128
		public unsafe int LinePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_get_LinePosition_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F5F RID: 3935
		// (get) Token: 0x06002DEC RID: 11756 RVA: 0x000D2F6C File Offset: 0x000D116C
		public unsafe int CollapsedLinePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_get_CollapsedLinePosition_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F60 RID: 3936
		// (get) Token: 0x06002DED RID: 11757 RVA: 0x000D2FB0 File Offset: 0x000D11B0
		public unsafe XPathNodePageInfo PageInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_get_PageInfo_Public_get_XPathNodePageInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XPathNodePageInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06002DEE RID: 11758 RVA: 0x000D2FF4 File Offset: 0x000D11F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426617, XrefRangeEnd = 426618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetParent(out Il2CppReferenceArray<XPathNode> pageNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_GetParent_Public_Int32_byref_Il2CppReferenceArray_1_XPathNode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				pageNode = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<XPathNode>(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06002DEF RID: 11759 RVA: 0x000D3058 File Offset: 0x000D1258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426618, XrefRangeEnd = 426619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetSibling(out Il2CppReferenceArray<XPathNode> pageNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_GetSibling_Public_Int32_byref_Il2CppReferenceArray_1_XPathNode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				pageNode = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<XPathNode>(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x17000F61 RID: 3937
		// (get) Token: 0x06002DF0 RID: 11760 RVA: 0x000D30BC File Offset: 0x000D12BC
		public unsafe bool IsXmlNamespaceNode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 426622, RefRangeEnd = 426623, XrefRangeStart = 426619, XrefRangeEnd = 426622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_get_IsXmlNamespaceNode_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F62 RID: 3938
		// (get) Token: 0x06002DF1 RID: 11761 RVA: 0x000D3100 File Offset: 0x000D1300
		public unsafe bool HasSibling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_get_HasSibling_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F63 RID: 3939
		// (get) Token: 0x06002DF2 RID: 11762 RVA: 0x000D3144 File Offset: 0x000D1344
		public unsafe bool HasCollapsedText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_get_HasCollapsedText_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F64 RID: 3940
		// (get) Token: 0x06002DF3 RID: 11763 RVA: 0x000D3188 File Offset: 0x000D1388
		public unsafe bool IsText
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426623, XrefRangeEnd = 426627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_get_IsText_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F65 RID: 3941
		// (get) Token: 0x06002DF4 RID: 11764 RVA: 0x000D31CC File Offset: 0x000D13CC
		public unsafe bool HasNamespaceDecls
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_get_HasNamespaceDecls_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F66 RID: 3942
		// (get) Token: 0x06002DF5 RID: 11765 RVA: 0x000D3210 File Offset: 0x000D1410
		public unsafe string Value
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_get_Value_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002DF6 RID: 11766 RVA: 0x00012EA2 File Offset: 0x000110A2
		public XPathNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002DF7 RID: 11767 RVA: 0x00012EAB File Offset: 0x000110AB
		public XPathNode()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XPathNode>.NativeClassPtr))
		{
		}

		// Token: 0x17000F51 RID: 3921
		// (get) Token: 0x06002DF8 RID: 11768 RVA: 0x000D324C File Offset: 0x000D144C
		// (set) Token: 0x06002DF9 RID: 11769 RVA: 0x00012EBD File Offset: 0x000110BD
		public unsafe XPathNodeInfoAtom _info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNode.NativeFieldInfoPtr__info);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XPathNodeInfoAtom>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNode.NativeFieldInfoPtr__info), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F52 RID: 3922
		// (get) Token: 0x06002DFA RID: 11770 RVA: 0x000D327C File Offset: 0x000D147C
		// (set) Token: 0x06002DFB RID: 11771 RVA: 0x00012EDC File Offset: 0x000110DC
		public unsafe ushort _idxSibling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNode.NativeFieldInfoPtr__idxSibling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNode.NativeFieldInfoPtr__idxSibling)) = value;
			}
		}

		// Token: 0x17000F53 RID: 3923
		// (get) Token: 0x06002DFC RID: 11772 RVA: 0x000D32A4 File Offset: 0x000D14A4
		// (set) Token: 0x06002DFD RID: 11773 RVA: 0x00012EF7 File Offset: 0x000110F7
		public unsafe ushort _idxParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNode.NativeFieldInfoPtr__idxParent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNode.NativeFieldInfoPtr__idxParent)) = value;
			}
		}

		// Token: 0x17000F54 RID: 3924
		// (get) Token: 0x06002DFE RID: 11774 RVA: 0x000D32CC File Offset: 0x000D14CC
		// (set) Token: 0x06002DFF RID: 11775 RVA: 0x00012F12 File Offset: 0x00011112
		public unsafe ushort _idxSimilar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNode.NativeFieldInfoPtr__idxSimilar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNode.NativeFieldInfoPtr__idxSimilar)) = value;
			}
		}

		// Token: 0x17000F55 RID: 3925
		// (get) Token: 0x06002E00 RID: 11776 RVA: 0x000D32F4 File Offset: 0x000D14F4
		// (set) Token: 0x06002E01 RID: 11777 RVA: 0x00012F2D File Offset: 0x0001112D
		public unsafe ushort _posOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNode.NativeFieldInfoPtr__posOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNode.NativeFieldInfoPtr__posOffset)) = value;
			}
		}

		// Token: 0x17000F56 RID: 3926
		// (get) Token: 0x06002E02 RID: 11778 RVA: 0x000D331C File Offset: 0x000D151C
		// (set) Token: 0x06002E03 RID: 11779 RVA: 0x00012F48 File Offset: 0x00011148
		public unsafe uint _props
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNode.NativeFieldInfoPtr__props);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNode.NativeFieldInfoPtr__props)) = value;
			}
		}

		// Token: 0x17000F57 RID: 3927
		// (get) Token: 0x06002E04 RID: 11780 RVA: 0x000D3344 File Offset: 0x000D1544
		// (set) Token: 0x06002E05 RID: 11781 RVA: 0x00012F63 File Offset: 0x00011163
		public unsafe string _value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNode.NativeFieldInfoPtr__value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNode.NativeFieldInfoPtr__value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040022F8 RID: 8952
		private static readonly IntPtr NativeFieldInfoPtr__info;

		// Token: 0x040022F9 RID: 8953
		private static readonly IntPtr NativeFieldInfoPtr__idxSibling;

		// Token: 0x040022FA RID: 8954
		private static readonly IntPtr NativeFieldInfoPtr__idxParent;

		// Token: 0x040022FB RID: 8955
		private static readonly IntPtr NativeFieldInfoPtr__idxSimilar;

		// Token: 0x040022FC RID: 8956
		private static readonly IntPtr NativeFieldInfoPtr__posOffset;

		// Token: 0x040022FD RID: 8957
		private static readonly IntPtr NativeFieldInfoPtr__props;

		// Token: 0x040022FE RID: 8958
		private static readonly IntPtr NativeFieldInfoPtr__value;

		// Token: 0x040022FF RID: 8959
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_get_XPathNodeType_0;

		// Token: 0x04002300 RID: 8960
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Public_get_String_0;

		// Token: 0x04002301 RID: 8961
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_get_String_0;

		// Token: 0x04002302 RID: 8962
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceUri_Public_get_String_0;

		// Token: 0x04002303 RID: 8963
		private static readonly IntPtr NativeMethodInfoPtr_get_Document_Public_get_XPathDocument_0;

		// Token: 0x04002304 RID: 8964
		private static readonly IntPtr NativeMethodInfoPtr_get_LineNumber_Public_get_Int32_0;

		// Token: 0x04002305 RID: 8965
		private static readonly IntPtr NativeMethodInfoPtr_get_LinePosition_Public_get_Int32_0;

		// Token: 0x04002306 RID: 8966
		private static readonly IntPtr NativeMethodInfoPtr_get_CollapsedLinePosition_Public_get_Int32_0;

		// Token: 0x04002307 RID: 8967
		private static readonly IntPtr NativeMethodInfoPtr_get_PageInfo_Public_get_XPathNodePageInfo_0;

		// Token: 0x04002308 RID: 8968
		private static readonly IntPtr NativeMethodInfoPtr_GetParent_Public_Int32_byref_Il2CppReferenceArray_1_XPathNode_0;

		// Token: 0x04002309 RID: 8969
		private static readonly IntPtr NativeMethodInfoPtr_GetSibling_Public_Int32_byref_Il2CppReferenceArray_1_XPathNode_0;

		// Token: 0x0400230A RID: 8970
		private static readonly IntPtr NativeMethodInfoPtr_get_IsXmlNamespaceNode_Public_get_Boolean_0;

		// Token: 0x0400230B RID: 8971
		private static readonly IntPtr NativeMethodInfoPtr_get_HasSibling_Public_get_Boolean_0;

		// Token: 0x0400230C RID: 8972
		private static readonly IntPtr NativeMethodInfoPtr_get_HasCollapsedText_Public_get_Boolean_0;

		// Token: 0x0400230D RID: 8973
		private static readonly IntPtr NativeMethodInfoPtr_get_IsText_Public_get_Boolean_0;

		// Token: 0x0400230E RID: 8974
		private static readonly IntPtr NativeMethodInfoPtr_get_HasNamespaceDecls_Public_get_Boolean_0;

		// Token: 0x0400230F RID: 8975
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_String_0;
	}
}
