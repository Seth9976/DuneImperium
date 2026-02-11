using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MS.Internal.Xml.Cache
{
	// Token: 0x0200020D RID: 525
	public sealed class XPathNodePageInfo : Object
	{
		// Token: 0x06002E19 RID: 11801 RVA: 0x000D38D0 File Offset: 0x000D1AD0
		// Note: this type is marked as 'beforefieldinit'.
		static XPathNodePageInfo()
		{
			Il2CppClassPointerStore<XPathNodePageInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "MS.Internal.Xml.Cache", "XPathNodePageInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XPathNodePageInfo>.NativeClassPtr);
			XPathNodePageInfo.NativeFieldInfoPtr__pageNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNodePageInfo>.NativeClassPtr, "_pageNum");
			XPathNodePageInfo.NativeFieldInfoPtr__nodeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNodePageInfo>.NativeClassPtr, "_nodeCount");
			XPathNodePageInfo.NativeFieldInfoPtr__pageNext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNodePageInfo>.NativeClassPtr, "_pageNext");
			XPathNodePageInfo.NativeMethodInfoPtr_get_PageNumber_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodePageInfo>.NativeClassPtr, 100669947);
			XPathNodePageInfo.NativeMethodInfoPtr_get_NodeCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodePageInfo>.NativeClassPtr, 100669948);
			XPathNodePageInfo.NativeMethodInfoPtr_get_NextPage_Public_get_Il2CppReferenceArray_1_XPathNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodePageInfo>.NativeClassPtr, 100669949);
		}

		// Token: 0x17000F6E RID: 3950
		// (get) Token: 0x06002E1A RID: 11802 RVA: 0x000D3978 File Offset: 0x000D1B78
		public unsafe int PageNumber
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodePageInfo.NativeMethodInfoPtr_get_PageNumber_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F6F RID: 3951
		// (get) Token: 0x06002E1B RID: 11803 RVA: 0x000D39B4 File Offset: 0x000D1BB4
		public unsafe int NodeCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodePageInfo.NativeMethodInfoPtr_get_NodeCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F70 RID: 3952
		// (get) Token: 0x06002E1C RID: 11804 RVA: 0x000D39F0 File Offset: 0x000D1BF0
		public unsafe Il2CppReferenceArray<XPathNode> NextPage
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodePageInfo.NativeMethodInfoPtr_get_NextPage_Public_get_Il2CppReferenceArray_1_XPathNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XPathNode>>(intPtr3) : null;
			}
		}

		// Token: 0x06002E1D RID: 11805 RVA: 0x00012FE0 File Offset: 0x000111E0
		public XPathNodePageInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F6B RID: 3947
		// (get) Token: 0x06002E1E RID: 11806 RVA: 0x000D3A30 File Offset: 0x000D1C30
		// (set) Token: 0x06002E1F RID: 11807 RVA: 0x00012FE9 File Offset: 0x000111E9
		public unsafe int _pageNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodePageInfo.NativeFieldInfoPtr__pageNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodePageInfo.NativeFieldInfoPtr__pageNum)) = value;
			}
		}

		// Token: 0x17000F6C RID: 3948
		// (get) Token: 0x06002E20 RID: 11808 RVA: 0x000D3A58 File Offset: 0x000D1C58
		// (set) Token: 0x06002E21 RID: 11809 RVA: 0x00013004 File Offset: 0x00011204
		public unsafe int _nodeCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodePageInfo.NativeFieldInfoPtr__nodeCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodePageInfo.NativeFieldInfoPtr__nodeCount)) = value;
			}
		}

		// Token: 0x17000F6D RID: 3949
		// (get) Token: 0x06002E22 RID: 11810 RVA: 0x000D3A80 File Offset: 0x000D1C80
		// (set) Token: 0x06002E23 RID: 11811 RVA: 0x0001301F File Offset: 0x0001121F
		public unsafe Il2CppReferenceArray<XPathNode> _pageNext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodePageInfo.NativeFieldInfoPtr__pageNext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XPathNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodePageInfo.NativeFieldInfoPtr__pageNext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400231C RID: 8988
		private static readonly IntPtr NativeFieldInfoPtr__pageNum;

		// Token: 0x0400231D RID: 8989
		private static readonly IntPtr NativeFieldInfoPtr__nodeCount;

		// Token: 0x0400231E RID: 8990
		private static readonly IntPtr NativeFieldInfoPtr__pageNext;

		// Token: 0x0400231F RID: 8991
		private static readonly IntPtr NativeMethodInfoPtr_get_PageNumber_Public_get_Int32_0;

		// Token: 0x04002320 RID: 8992
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeCount_Public_get_Int32_0;

		// Token: 0x04002321 RID: 8993
		private static readonly IntPtr NativeMethodInfoPtr_get_NextPage_Public_get_Il2CppReferenceArray_1_XPathNode_0;
	}
}
