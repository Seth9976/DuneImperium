using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000063 RID: 99
	public class XmlChildNodes : XmlNodeList
	{
		// Token: 0x06000BDB RID: 3035 RVA: 0x000493C4 File Offset: 0x000475C4
		// Note: this type is marked as 'beforefieldinit'.
		static XmlChildNodes()
		{
			Il2CppClassPointerStore<XmlChildNodes>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlChildNodes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlChildNodes>.NativeClassPtr);
			XmlChildNodes.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlChildNodes>.NativeClassPtr, "container");
			XmlChildNodes.NativeMethodInfoPtr__ctor_Public_Void_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlChildNodes>.NativeClassPtr, 100665247);
			XmlChildNodes.NativeMethodInfoPtr_Item_Public_Virtual_XmlNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlChildNodes>.NativeClassPtr, 100665248);
			XmlChildNodes.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlChildNodes>.NativeClassPtr, 100665249);
			XmlChildNodes.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlChildNodes>.NativeClassPtr, 100665250);
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x00049458 File Offset: 0x00047658
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlChildNodes(XmlNode container)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlChildNodes>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlChildNodes.NativeMethodInfoPtr__ctor_Public_Void_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x000494A4 File Offset: 0x000476A4
		[CallerCount(0)]
		public unsafe override XmlNode Item(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlChildNodes.NativeMethodInfoPtr_Item_Public_Virtual_XmlNode_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000BDE RID: 3038 RVA: 0x000494FC File Offset: 0x000476FC
		public unsafe override int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlChildNodes.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x00049544 File Offset: 0x00047744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373627, XrefRangeEnd = 373634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlChildNodes.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x00005F14 File Offset: 0x00004114
		public XmlChildNodes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000BE1 RID: 3041 RVA: 0x00049590 File Offset: 0x00047790
		// (set) Token: 0x06000BE2 RID: 3042 RVA: 0x00005F1D File Offset: 0x0000411D
		public unsafe XmlNode container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlChildNodes.NativeFieldInfoPtr_container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlChildNodes.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009BA RID: 2490
		private static readonly IntPtr NativeFieldInfoPtr_container;

		// Token: 0x040009BB RID: 2491
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNode_0;

		// Token: 0x040009BC RID: 2492
		private static readonly IntPtr NativeMethodInfoPtr_Item_Public_Virtual_XmlNode_Int32_0;

		// Token: 0x040009BD RID: 2493
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0;

		// Token: 0x040009BE RID: 2494
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_0;
	}
}
