using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MS.Internal.Xml.Cache
{
	// Token: 0x0200020B RID: 523
	public sealed class XPathNodeRef : ValueType
	{
		// Token: 0x06002E06 RID: 11782 RVA: 0x000D336C File Offset: 0x000D156C
		// Note: this type is marked as 'beforefieldinit'.
		static XPathNodeRef()
		{
			Il2CppClassPointerStore<XPathNodeRef>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "MS.Internal.Xml.Cache", "XPathNodeRef");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XPathNodeRef>.NativeClassPtr);
			XPathNodeRef.NativeFieldInfoPtr__page = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNodeRef>.NativeClassPtr, "_page");
			XPathNodeRef.NativeFieldInfoPtr__idx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNodeRef>.NativeClassPtr, "_idx");
			XPathNodeRef.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_XPathNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeRef>.NativeClassPtr, 100669937);
			XPathNodeRef.NativeMethodInfoPtr_get_Page_Public_get_Il2CppReferenceArray_1_XPathNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeRef>.NativeClassPtr, 100669938);
			XPathNodeRef.NativeMethodInfoPtr_get_Index_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeRef>.NativeClassPtr, 100669939);
			XPathNodeRef.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeRef>.NativeClassPtr, 100669940);
		}

		// Token: 0x06002E07 RID: 11783 RVA: 0x000D3414 File Offset: 0x000D1614
		[CallerCount(40)]
		[CachedScanResults(RefRangeStart = 336243, RefRangeEnd = 336283, XrefRangeStart = 336243, XrefRangeEnd = 336283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XPathNodeRef(Il2CppReferenceArray<XPathNode> page, int idx)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XPathNodeRef>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(page);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodeRef.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_XPathNode_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000F69 RID: 3945
		// (get) Token: 0x06002E08 RID: 11784 RVA: 0x000D3474 File Offset: 0x000D1674
		public unsafe Il2CppReferenceArray<XPathNode> Page
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodeRef.NativeMethodInfoPtr_get_Page_Public_get_Il2CppReferenceArray_1_XPathNode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XPathNode>>(intPtr3) : null;
			}
		}

		// Token: 0x17000F6A RID: 3946
		// (get) Token: 0x06002E09 RID: 11785 RVA: 0x000D34B8 File Offset: 0x000D16B8
		public unsafe int Index
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodeRef.NativeMethodInfoPtr_get_Index_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002E0A RID: 11786 RVA: 0x000D34FC File Offset: 0x000D16FC
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodeRef.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002E0B RID: 11787 RVA: 0x00012F82 File Offset: 0x00011182
		public XPathNodeRef(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002E0C RID: 11788 RVA: 0x00012F8B File Offset: 0x0001118B
		public XPathNodeRef()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XPathNodeRef>.NativeClassPtr))
		{
		}

		// Token: 0x17000F67 RID: 3943
		// (get) Token: 0x06002E0D RID: 11789 RVA: 0x000D3540 File Offset: 0x000D1740
		// (set) Token: 0x06002E0E RID: 11790 RVA: 0x00012F9D File Offset: 0x0001119D
		public unsafe Il2CppReferenceArray<XPathNode> _page
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeRef.NativeFieldInfoPtr__page);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XPathNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeRef.NativeFieldInfoPtr__page), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F68 RID: 3944
		// (get) Token: 0x06002E0F RID: 11791 RVA: 0x000D3570 File Offset: 0x000D1770
		// (set) Token: 0x06002E10 RID: 11792 RVA: 0x00012FBC File Offset: 0x000111BC
		public unsafe int _idx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeRef.NativeFieldInfoPtr__idx);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeRef.NativeFieldInfoPtr__idx)) = value;
			}
		}

		// Token: 0x04002310 RID: 8976
		private static readonly IntPtr NativeFieldInfoPtr__page;

		// Token: 0x04002311 RID: 8977
		private static readonly IntPtr NativeFieldInfoPtr__idx;

		// Token: 0x04002312 RID: 8978
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_XPathNode_Int32_0;

		// Token: 0x04002313 RID: 8979
		private static readonly IntPtr NativeMethodInfoPtr_get_Page_Public_get_Il2CppReferenceArray_1_XPathNode_0;

		// Token: 0x04002314 RID: 8980
		private static readonly IntPtr NativeMethodInfoPtr_get_Index_Public_get_Int32_0;

		// Token: 0x04002315 RID: 8981
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
