using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000C9 RID: 201
	public class XmlAnyElementAttributes : CollectionBase
	{
		// Token: 0x06001340 RID: 4928 RVA: 0x0006A218 File Offset: 0x00068418
		// Note: this type is marked as 'beforefieldinit'.
		static XmlAnyElementAttributes()
		{
			Il2CppClassPointerStore<XmlAnyElementAttributes>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlAnyElementAttributes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlAnyElementAttributes>.NativeClassPtr);
			XmlAnyElementAttributes.NativeMethodInfoPtr_get_Item_Public_get_XmlAnyElementAttribute_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyElementAttributes>.NativeClassPtr, 100666417);
			XmlAnyElementAttributes.NativeMethodInfoPtr_Add_Public_Int32_XmlAnyElementAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyElementAttributes>.NativeClassPtr, 100666418);
			XmlAnyElementAttributes.NativeMethodInfoPtr_AddKeyHash_Internal_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyElementAttributes>.NativeClassPtr, 100666419);
			XmlAnyElementAttributes.NativeMethodInfoPtr_get_Order_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyElementAttributes>.NativeClassPtr, 100666420);
			XmlAnyElementAttributes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyElementAttributes>.NativeClassPtr, 100666421);
		}

		// Token: 0x1700061E RID: 1566
		public unsafe XmlAnyElementAttribute this[int index]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385122, XrefRangeEnd = 385128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAnyElementAttributes.NativeMethodInfoPtr_get_Item_Public_get_XmlAnyElementAttribute_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAnyElementAttribute>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x0006A2F8 File Offset: 0x000684F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 385134, RefRangeEnd = 385135, XrefRangeStart = 385128, XrefRangeEnd = 385134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Add(XmlAnyElementAttribute attribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAnyElementAttributes.NativeMethodInfoPtr_Add_Public_Int32_XmlAnyElementAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x0006A348 File Offset: 0x00068548
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 385149, RefRangeEnd = 385150, XrefRangeStart = 385135, XrefRangeEnd = 385149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddKeyHash(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAnyElementAttributes.NativeMethodInfoPtr_AddKeyHash_Internal_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06001344 RID: 4932 RVA: 0x0006A38C File Offset: 0x0006858C
		public unsafe int Order
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 385160, RefRangeEnd = 385161, XrefRangeStart = 385150, XrefRangeEnd = 385160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAnyElementAttributes.NativeMethodInfoPtr_get_Order_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x0006A3C8 File Offset: 0x000685C8
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 385162, RefRangeEnd = 385185, XrefRangeStart = 385161, XrefRangeEnd = 385162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAnyElementAttributes()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAnyElementAttributes>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAnyElementAttributes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x000082EA File Offset: 0x000064EA
		public XmlAnyElementAttributes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F96 RID: 3990
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_XmlAnyElementAttribute_Int32_0;

		// Token: 0x04000F97 RID: 3991
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Int32_XmlAnyElementAttribute_0;

		// Token: 0x04000F98 RID: 3992
		private static readonly IntPtr NativeMethodInfoPtr_AddKeyHash_Internal_Void_StringBuilder_0;

		// Token: 0x04000F99 RID: 3993
		private static readonly IntPtr NativeMethodInfoPtr_get_Order_Internal_get_Int32_0;

		// Token: 0x04000F9A RID: 3994
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
