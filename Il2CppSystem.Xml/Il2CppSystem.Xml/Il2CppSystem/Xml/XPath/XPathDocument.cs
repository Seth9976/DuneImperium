using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using MS.Internal.Xml.Cache;

namespace Il2CppSystem.Xml.XPath
{
	// Token: 0x020000AA RID: 170
	public class XPathDocument : Object
	{
		// Token: 0x060011EF RID: 4591 RVA: 0x00065540 File Offset: 0x00063740
		// Note: this type is marked as 'beforefieldinit'.
		static XPathDocument()
		{
			Il2CppClassPointerStore<XPathDocument>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.XPath", "XPathDocument");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XPathDocument>.NativeClassPtr);
			XPathDocument.NativeFieldInfoPtr_pageXmlNmsp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathDocument>.NativeClassPtr, "pageXmlNmsp");
			XPathDocument.NativeFieldInfoPtr_idxXmlNmsp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathDocument>.NativeClassPtr, "idxXmlNmsp");
			XPathDocument.NativeFieldInfoPtr_nameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathDocument>.NativeClassPtr, "nameTable");
			XPathDocument.NativeFieldInfoPtr_hasLineInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathDocument>.NativeClassPtr, "hasLineInfo");
			XPathDocument.NativeFieldInfoPtr_mapNmsp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathDocument>.NativeClassPtr, "mapNmsp");
			XPathDocument.NativeMethodInfoPtr_get_NameTable_Internal_get_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathDocument>.NativeClassPtr, 100666265);
			XPathDocument.NativeMethodInfoPtr_get_HasLineInfo_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathDocument>.NativeClassPtr, 100666266);
			XPathDocument.NativeMethodInfoPtr_GetXmlNamespaceNode_Internal_Int32_byref_Il2CppReferenceArray_1_XPathNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathDocument>.NativeClassPtr, 100666267);
			XPathDocument.NativeMethodInfoPtr_LookupNamespaces_Internal_Int32_Il2CppReferenceArray_1_XPathNode_Int32_byref_Il2CppReferenceArray_1_XPathNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathDocument>.NativeClassPtr, 100666268);
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x060011F0 RID: 4592 RVA: 0x00065624 File Offset: 0x00063824
		public unsafe XmlNameTable NameTable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathDocument.NativeMethodInfoPtr_get_NameTable_Internal_get_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr3) : null;
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x060011F1 RID: 4593 RVA: 0x00065664 File Offset: 0x00063864
		public unsafe bool HasLineInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathDocument.NativeMethodInfoPtr_get_HasLineInfo_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x000656A0 File Offset: 0x000638A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 383278, RefRangeEnd = 383279, XrefRangeStart = 383277, XrefRangeEnd = 383278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetXmlNamespaceNode(out Il2CppReferenceArray<XPathNode> pageXmlNmsp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XPathDocument.NativeMethodInfoPtr_GetXmlNamespaceNode_Internal_Int32_byref_Il2CppReferenceArray_1_XPathNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				pageXmlNmsp = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<XPathNode>(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060011F3 RID: 4595 RVA: 0x00065700 File Offset: 0x00063900
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 383289, RefRangeEnd = 383290, XrefRangeStart = 383279, XrefRangeEnd = 383289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LookupNamespaces(Il2CppReferenceArray<XPathNode> pageElem, int idxElem, out Il2CppReferenceArray<XPathNode> pageNmsp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pageElem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idxElem;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XPathDocument.NativeMethodInfoPtr_LookupNamespaces_Internal_Int32_Il2CppReferenceArray_1_XPathNode_Int32_byref_Il2CppReferenceArray_1_XPathNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			pageNmsp = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<XPathNode>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x00007A63 File Offset: 0x00005C63
		public XPathDocument(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x060011F5 RID: 4597 RVA: 0x00065780 File Offset: 0x00063980
		// (set) Token: 0x060011F6 RID: 4598 RVA: 0x00007A6C File Offset: 0x00005C6C
		public unsafe Il2CppReferenceArray<XPathNode> pageXmlNmsp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathDocument.NativeFieldInfoPtr_pageXmlNmsp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XPathNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathDocument.NativeFieldInfoPtr_pageXmlNmsp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x060011F7 RID: 4599 RVA: 0x000657B0 File Offset: 0x000639B0
		// (set) Token: 0x060011F8 RID: 4600 RVA: 0x00007A8B File Offset: 0x00005C8B
		public unsafe int idxXmlNmsp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathDocument.NativeFieldInfoPtr_idxXmlNmsp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathDocument.NativeFieldInfoPtr_idxXmlNmsp)) = value;
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x060011F9 RID: 4601 RVA: 0x000657D8 File Offset: 0x000639D8
		// (set) Token: 0x060011FA RID: 4602 RVA: 0x00007AA6 File Offset: 0x00005CA6
		public unsafe XmlNameTable nameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathDocument.NativeFieldInfoPtr_nameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathDocument.NativeFieldInfoPtr_nameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x060011FB RID: 4603 RVA: 0x00065808 File Offset: 0x00063A08
		// (set) Token: 0x060011FC RID: 4604 RVA: 0x00007AC5 File Offset: 0x00005CC5
		public unsafe bool hasLineInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathDocument.NativeFieldInfoPtr_hasLineInfo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathDocument.NativeFieldInfoPtr_hasLineInfo)) = value;
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x060011FD RID: 4605 RVA: 0x00065830 File Offset: 0x00063A30
		// (set) Token: 0x060011FE RID: 4606 RVA: 0x00007AE0 File Offset: 0x00005CE0
		public unsafe Dictionary<XPathNodeRef, XPathNodeRef> mapNmsp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathDocument.NativeFieldInfoPtr_mapNmsp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<XPathNodeRef, XPathNodeRef>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathDocument.NativeFieldInfoPtr_mapNmsp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EA5 RID: 3749
		private static readonly IntPtr NativeFieldInfoPtr_pageXmlNmsp;

		// Token: 0x04000EA6 RID: 3750
		private static readonly IntPtr NativeFieldInfoPtr_idxXmlNmsp;

		// Token: 0x04000EA7 RID: 3751
		private static readonly IntPtr NativeFieldInfoPtr_nameTable;

		// Token: 0x04000EA8 RID: 3752
		private static readonly IntPtr NativeFieldInfoPtr_hasLineInfo;

		// Token: 0x04000EA9 RID: 3753
		private static readonly IntPtr NativeFieldInfoPtr_mapNmsp;

		// Token: 0x04000EAA RID: 3754
		private static readonly IntPtr NativeMethodInfoPtr_get_NameTable_Internal_get_XmlNameTable_0;

		// Token: 0x04000EAB RID: 3755
		private static readonly IntPtr NativeMethodInfoPtr_get_HasLineInfo_Internal_get_Boolean_0;

		// Token: 0x04000EAC RID: 3756
		private static readonly IntPtr NativeMethodInfoPtr_GetXmlNamespaceNode_Internal_Int32_byref_Il2CppReferenceArray_1_XPathNode_0;

		// Token: 0x04000EAD RID: 3757
		private static readonly IntPtr NativeMethodInfoPtr_LookupNamespaces_Internal_Int32_Il2CppReferenceArray_1_XPathNode_Int32_byref_Il2CppReferenceArray_1_XPathNode_0;
	}
}
