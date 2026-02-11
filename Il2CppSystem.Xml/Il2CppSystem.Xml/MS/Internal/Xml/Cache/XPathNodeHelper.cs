using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace MS.Internal.Xml.Cache
{
	// Token: 0x0200020C RID: 524
	public class XPathNodeHelper : Object
	{
		// Token: 0x06002E11 RID: 11793 RVA: 0x000D3598 File Offset: 0x000D1798
		// Note: this type is marked as 'beforefieldinit'.
		static XPathNodeHelper()
		{
			Il2CppClassPointerStore<XPathNodeHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "MS.Internal.Xml.Cache", "XPathNodeHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XPathNodeHelper>.NativeClassPtr);
			XPathNodeHelper.NativeMethodInfoPtr_GetLocalNamespaces_Public_Static_Int32_Il2CppReferenceArray_1_XPathNode_Int32_byref_Il2CppReferenceArray_1_XPathNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeHelper>.NativeClassPtr, 100669941);
			XPathNodeHelper.NativeMethodInfoPtr_GetInScopeNamespaces_Public_Static_Int32_Il2CppReferenceArray_1_XPathNode_Int32_byref_Il2CppReferenceArray_1_XPathNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeHelper>.NativeClassPtr, 100669942);
			XPathNodeHelper.NativeMethodInfoPtr_GetParent_Public_Static_Boolean_byref_Il2CppReferenceArray_1_XPathNode_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeHelper>.NativeClassPtr, 100669943);
			XPathNodeHelper.NativeMethodInfoPtr_GetLocation_Public_Static_Int32_Il2CppReferenceArray_1_XPathNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeHelper>.NativeClassPtr, 100669944);
			XPathNodeHelper.NativeMethodInfoPtr_GetTextFollowing_Public_Static_Boolean_byref_Il2CppReferenceArray_1_XPathNode_byref_Int32_Il2CppReferenceArray_1_XPathNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeHelper>.NativeClassPtr, 100669945);
			XPathNodeHelper.NativeMethodInfoPtr_GetNonDescendant_Public_Static_Boolean_byref_Il2CppReferenceArray_1_XPathNode_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeHelper>.NativeClassPtr, 100669946);
		}

		// Token: 0x06002E12 RID: 11794 RVA: 0x000D3640 File Offset: 0x000D1840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426627, XrefRangeEnd = 426628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetLocalNamespaces(Il2CppReferenceArray<XPathNode> pageElem, int idxElem, out Il2CppReferenceArray<XPathNode> pageNmsp)
		{
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XPathNodeHelper.NativeMethodInfoPtr_GetLocalNamespaces_Public_Static_Int32_Il2CppReferenceArray_1_XPathNode_Int32_byref_Il2CppReferenceArray_1_XPathNode_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			pageNmsp = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<XPathNode>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002E13 RID: 11795 RVA: 0x000D36B4 File Offset: 0x000D18B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426628, XrefRangeEnd = 426629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetInScopeNamespaces(Il2CppReferenceArray<XPathNode> pageElem, int idxElem, out Il2CppReferenceArray<XPathNode> pageNmsp)
		{
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XPathNodeHelper.NativeMethodInfoPtr_GetInScopeNamespaces_Public_Static_Int32_Il2CppReferenceArray_1_XPathNode_Int32_byref_Il2CppReferenceArray_1_XPathNode_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			pageNmsp = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<XPathNode>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002E14 RID: 11796 RVA: 0x000D3728 File Offset: 0x000D1928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426629, XrefRangeEnd = 426630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetParent(ref Il2CppReferenceArray<XPathNode> pageNode, ref int idxNode)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(pageNode);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &idxNode;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XPathNodeHelper.NativeMethodInfoPtr_GetParent_Public_Static_Boolean_byref_Il2CppReferenceArray_1_XPathNode_byref_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			pageNode = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<XPathNode>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002E15 RID: 11797 RVA: 0x000D3790 File Offset: 0x000D1990
		[CallerCount(0)]
		public unsafe static int GetLocation(Il2CppReferenceArray<XPathNode> pageNode, int idxNode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pageNode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idxNode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodeHelper.NativeMethodInfoPtr_GetLocation_Public_Static_Int32_Il2CppReferenceArray_1_XPathNode_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002E16 RID: 11798 RVA: 0x000D37E0 File Offset: 0x000D19E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 426635, RefRangeEnd = 426637, XrefRangeStart = 426630, XrefRangeEnd = 426635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetTextFollowing(ref Il2CppReferenceArray<XPathNode> pageCurrent, ref int idxCurrent, Il2CppReferenceArray<XPathNode> pageEnd, int idxEnd)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(pageCurrent);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &idxCurrent;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pageEnd);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idxEnd;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XPathNodeHelper.NativeMethodInfoPtr_GetTextFollowing_Public_Static_Boolean_byref_Il2CppReferenceArray_1_XPathNode_byref_Int32_Il2CppReferenceArray_1_XPathNode_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			pageCurrent = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<XPathNode>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002E17 RID: 11799 RVA: 0x000D3868 File Offset: 0x000D1A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426637, XrefRangeEnd = 426639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetNonDescendant(ref Il2CppReferenceArray<XPathNode> pageNode, ref int idxNode)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(pageNode);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &idxNode;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XPathNodeHelper.NativeMethodInfoPtr_GetNonDescendant_Public_Static_Boolean_byref_Il2CppReferenceArray_1_XPathNode_byref_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			pageNode = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<XPathNode>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002E18 RID: 11800 RVA: 0x00012FD7 File Offset: 0x000111D7
		public XPathNodeHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002316 RID: 8982
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalNamespaces_Public_Static_Int32_Il2CppReferenceArray_1_XPathNode_Int32_byref_Il2CppReferenceArray_1_XPathNode_0;

		// Token: 0x04002317 RID: 8983
		private static readonly IntPtr NativeMethodInfoPtr_GetInScopeNamespaces_Public_Static_Int32_Il2CppReferenceArray_1_XPathNode_Int32_byref_Il2CppReferenceArray_1_XPathNode_0;

		// Token: 0x04002318 RID: 8984
		private static readonly IntPtr NativeMethodInfoPtr_GetParent_Public_Static_Boolean_byref_Il2CppReferenceArray_1_XPathNode_byref_Int32_0;

		// Token: 0x04002319 RID: 8985
		private static readonly IntPtr NativeMethodInfoPtr_GetLocation_Public_Static_Int32_Il2CppReferenceArray_1_XPathNode_Int32_0;

		// Token: 0x0400231A RID: 8986
		private static readonly IntPtr NativeMethodInfoPtr_GetTextFollowing_Public_Static_Boolean_byref_Il2CppReferenceArray_1_XPathNode_byref_Int32_Il2CppReferenceArray_1_XPathNode_Int32_0;

		// Token: 0x0400231B RID: 8987
		private static readonly IntPtr NativeMethodInfoPtr_GetNonDescendant_Public_Static_Boolean_byref_Il2CppReferenceArray_1_XPathNode_byref_Int32_0;
	}
}
