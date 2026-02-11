using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Xml.XPath;

namespace MS.Internal.Xml.Cache
{
	// Token: 0x0200020E RID: 526
	public sealed class XPathNodeInfoAtom : Object
	{
		// Token: 0x06002E24 RID: 11812 RVA: 0x000D3AB0 File Offset: 0x000D1CB0
		// Note: this type is marked as 'beforefieldinit'.
		static XPathNodeInfoAtom()
		{
			Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "MS.Internal.Xml.Cache", "XPathNodeInfoAtom");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr);
			XPathNodeInfoAtom.NativeFieldInfoPtr__localName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, "_localName");
			XPathNodeInfoAtom.NativeFieldInfoPtr__namespaceUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, "_namespaceUri");
			XPathNodeInfoAtom.NativeFieldInfoPtr__prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, "_prefix");
			XPathNodeInfoAtom.NativeFieldInfoPtr__pageParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, "_pageParent");
			XPathNodeInfoAtom.NativeFieldInfoPtr__pageSibling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, "_pageSibling");
			XPathNodeInfoAtom.NativeFieldInfoPtr__doc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, "_doc");
			XPathNodeInfoAtom.NativeFieldInfoPtr__lineNumBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, "_lineNumBase");
			XPathNodeInfoAtom.NativeFieldInfoPtr__linePosBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, "_linePosBase");
			XPathNodeInfoAtom.NativeFieldInfoPtr__pageInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, "_pageInfo");
			XPathNodeInfoAtom.NativeMethodInfoPtr_get_PageInfo_Public_get_XPathNodePageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, 100669950);
			XPathNodeInfoAtom.NativeMethodInfoPtr_get_LocalName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, 100669951);
			XPathNodeInfoAtom.NativeMethodInfoPtr_get_NamespaceUri_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, 100669952);
			XPathNodeInfoAtom.NativeMethodInfoPtr_get_Prefix_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, 100669953);
			XPathNodeInfoAtom.NativeMethodInfoPtr_get_SiblingPage_Public_get_Il2CppReferenceArray_1_XPathNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, 100669954);
			XPathNodeInfoAtom.NativeMethodInfoPtr_get_ParentPage_Public_get_Il2CppReferenceArray_1_XPathNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, 100669955);
			XPathNodeInfoAtom.NativeMethodInfoPtr_get_Document_Public_get_XPathDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, 100669956);
			XPathNodeInfoAtom.NativeMethodInfoPtr_get_LineNumberBase_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, 100669957);
			XPathNodeInfoAtom.NativeMethodInfoPtr_get_LinePositionBase_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, 100669958);
		}

		// Token: 0x17000F7A RID: 3962
		// (get) Token: 0x06002E25 RID: 11813 RVA: 0x000D3C48 File Offset: 0x000D1E48
		public unsafe XPathNodePageInfo PageInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodeInfoAtom.NativeMethodInfoPtr_get_PageInfo_Public_get_XPathNodePageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XPathNodePageInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000F7B RID: 3963
		// (get) Token: 0x06002E26 RID: 11814 RVA: 0x000D3C88 File Offset: 0x000D1E88
		public unsafe string LocalName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodeInfoAtom.NativeMethodInfoPtr_get_LocalName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000F7C RID: 3964
		// (get) Token: 0x06002E27 RID: 11815 RVA: 0x000D3CC0 File Offset: 0x000D1EC0
		public unsafe string NamespaceUri
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodeInfoAtom.NativeMethodInfoPtr_get_NamespaceUri_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000F7D RID: 3965
		// (get) Token: 0x06002E28 RID: 11816 RVA: 0x000D3CF8 File Offset: 0x000D1EF8
		public unsafe string Prefix
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodeInfoAtom.NativeMethodInfoPtr_get_Prefix_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000F7E RID: 3966
		// (get) Token: 0x06002E29 RID: 11817 RVA: 0x000D3D30 File Offset: 0x000D1F30
		public unsafe Il2CppReferenceArray<XPathNode> SiblingPage
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodeInfoAtom.NativeMethodInfoPtr_get_SiblingPage_Public_get_Il2CppReferenceArray_1_XPathNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XPathNode>>(intPtr3) : null;
			}
		}

		// Token: 0x17000F7F RID: 3967
		// (get) Token: 0x06002E2A RID: 11818 RVA: 0x000D3D70 File Offset: 0x000D1F70
		public unsafe Il2CppReferenceArray<XPathNode> ParentPage
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodeInfoAtom.NativeMethodInfoPtr_get_ParentPage_Public_get_Il2CppReferenceArray_1_XPathNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XPathNode>>(intPtr3) : null;
			}
		}

		// Token: 0x17000F80 RID: 3968
		// (get) Token: 0x06002E2B RID: 11819 RVA: 0x000D3DB0 File Offset: 0x000D1FB0
		public unsafe XPathDocument Document
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodeInfoAtom.NativeMethodInfoPtr_get_Document_Public_get_XPathDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XPathDocument>(intPtr3) : null;
			}
		}

		// Token: 0x17000F81 RID: 3969
		// (get) Token: 0x06002E2C RID: 11820 RVA: 0x000D3DF0 File Offset: 0x000D1FF0
		public unsafe int LineNumberBase
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodeInfoAtom.NativeMethodInfoPtr_get_LineNumberBase_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F82 RID: 3970
		// (get) Token: 0x06002E2D RID: 11821 RVA: 0x000D3E2C File Offset: 0x000D202C
		public unsafe int LinePositionBase
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodeInfoAtom.NativeMethodInfoPtr_get_LinePositionBase_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002E2E RID: 11822 RVA: 0x0001303E File Offset: 0x0001123E
		public XPathNodeInfoAtom(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F71 RID: 3953
		// (get) Token: 0x06002E2F RID: 11823 RVA: 0x000D3E68 File Offset: 0x000D2068
		// (set) Token: 0x06002E30 RID: 11824 RVA: 0x00013047 File Offset: 0x00011247
		public unsafe string _localName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr__localName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr__localName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F72 RID: 3954
		// (get) Token: 0x06002E31 RID: 11825 RVA: 0x000D3E90 File Offset: 0x000D2090
		// (set) Token: 0x06002E32 RID: 11826 RVA: 0x00013066 File Offset: 0x00011266
		public unsafe string _namespaceUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr__namespaceUri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr__namespaceUri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F73 RID: 3955
		// (get) Token: 0x06002E33 RID: 11827 RVA: 0x000D3EB8 File Offset: 0x000D20B8
		// (set) Token: 0x06002E34 RID: 11828 RVA: 0x00013085 File Offset: 0x00011285
		public unsafe string _prefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr__prefix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr__prefix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F74 RID: 3956
		// (get) Token: 0x06002E35 RID: 11829 RVA: 0x000D3EE0 File Offset: 0x000D20E0
		// (set) Token: 0x06002E36 RID: 11830 RVA: 0x000130A4 File Offset: 0x000112A4
		public unsafe Il2CppReferenceArray<XPathNode> _pageParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr__pageParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XPathNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr__pageParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F75 RID: 3957
		// (get) Token: 0x06002E37 RID: 11831 RVA: 0x000D3F10 File Offset: 0x000D2110
		// (set) Token: 0x06002E38 RID: 11832 RVA: 0x000130C3 File Offset: 0x000112C3
		public unsafe Il2CppReferenceArray<XPathNode> _pageSibling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr__pageSibling);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XPathNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr__pageSibling), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F76 RID: 3958
		// (get) Token: 0x06002E39 RID: 11833 RVA: 0x000D3F40 File Offset: 0x000D2140
		// (set) Token: 0x06002E3A RID: 11834 RVA: 0x000130E2 File Offset: 0x000112E2
		public unsafe XPathDocument _doc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr__doc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XPathDocument>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr__doc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F77 RID: 3959
		// (get) Token: 0x06002E3B RID: 11835 RVA: 0x000D3F70 File Offset: 0x000D2170
		// (set) Token: 0x06002E3C RID: 11836 RVA: 0x00013101 File Offset: 0x00011301
		public unsafe int _lineNumBase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr__lineNumBase);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr__lineNumBase)) = value;
			}
		}

		// Token: 0x17000F78 RID: 3960
		// (get) Token: 0x06002E3D RID: 11837 RVA: 0x000D3F98 File Offset: 0x000D2198
		// (set) Token: 0x06002E3E RID: 11838 RVA: 0x0001311C File Offset: 0x0001131C
		public unsafe int _linePosBase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr__linePosBase);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr__linePosBase)) = value;
			}
		}

		// Token: 0x17000F79 RID: 3961
		// (get) Token: 0x06002E3F RID: 11839 RVA: 0x000D3FC0 File Offset: 0x000D21C0
		// (set) Token: 0x06002E40 RID: 11840 RVA: 0x00013137 File Offset: 0x00011337
		public unsafe XPathNodePageInfo _pageInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr__pageInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XPathNodePageInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr__pageInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002322 RID: 8994
		private static readonly IntPtr NativeFieldInfoPtr__localName;

		// Token: 0x04002323 RID: 8995
		private static readonly IntPtr NativeFieldInfoPtr__namespaceUri;

		// Token: 0x04002324 RID: 8996
		private static readonly IntPtr NativeFieldInfoPtr__prefix;

		// Token: 0x04002325 RID: 8997
		private static readonly IntPtr NativeFieldInfoPtr__pageParent;

		// Token: 0x04002326 RID: 8998
		private static readonly IntPtr NativeFieldInfoPtr__pageSibling;

		// Token: 0x04002327 RID: 8999
		private static readonly IntPtr NativeFieldInfoPtr__doc;

		// Token: 0x04002328 RID: 9000
		private static readonly IntPtr NativeFieldInfoPtr__lineNumBase;

		// Token: 0x04002329 RID: 9001
		private static readonly IntPtr NativeFieldInfoPtr__linePosBase;

		// Token: 0x0400232A RID: 9002
		private static readonly IntPtr NativeFieldInfoPtr__pageInfo;

		// Token: 0x0400232B RID: 9003
		private static readonly IntPtr NativeMethodInfoPtr_get_PageInfo_Public_get_XPathNodePageInfo_0;

		// Token: 0x0400232C RID: 9004
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_get_String_0;

		// Token: 0x0400232D RID: 9005
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceUri_Public_get_String_0;

		// Token: 0x0400232E RID: 9006
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Public_get_String_0;

		// Token: 0x0400232F RID: 9007
		private static readonly IntPtr NativeMethodInfoPtr_get_SiblingPage_Public_get_Il2CppReferenceArray_1_XPathNode_0;

		// Token: 0x04002330 RID: 9008
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentPage_Public_get_Il2CppReferenceArray_1_XPathNode_0;

		// Token: 0x04002331 RID: 9009
		private static readonly IntPtr NativeMethodInfoPtr_get_Document_Public_get_XPathDocument_0;

		// Token: 0x04002332 RID: 9010
		private static readonly IntPtr NativeMethodInfoPtr_get_LineNumberBase_Public_get_Int32_0;

		// Token: 0x04002333 RID: 9011
		private static readonly IntPtr NativeMethodInfoPtr_get_LinePositionBase_Public_get_Int32_0;
	}
}
