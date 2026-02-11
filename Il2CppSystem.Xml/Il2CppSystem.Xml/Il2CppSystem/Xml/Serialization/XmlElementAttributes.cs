using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000D3 RID: 211
	public class XmlElementAttributes : CollectionBase
	{
		// Token: 0x060013EF RID: 5103 RVA: 0x0006C634 File Offset: 0x0006A834
		// Note: this type is marked as 'beforefieldinit'.
		static XmlElementAttributes()
		{
			Il2CppClassPointerStore<XmlElementAttributes>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlElementAttributes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlElementAttributes>.NativeClassPtr);
			XmlElementAttributes.NativeMethodInfoPtr_get_Item_Public_get_XmlElementAttribute_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElementAttributes>.NativeClassPtr, 100666489);
			XmlElementAttributes.NativeMethodInfoPtr_Add_Public_Int32_XmlElementAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElementAttributes>.NativeClassPtr, 100666490);
			XmlElementAttributes.NativeMethodInfoPtr_AddKeyHash_Internal_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElementAttributes>.NativeClassPtr, 100666491);
			XmlElementAttributes.NativeMethodInfoPtr_get_Order_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElementAttributes>.NativeClassPtr, 100666492);
			XmlElementAttributes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElementAttributes>.NativeClassPtr, 100666493);
		}

		// Token: 0x17000675 RID: 1653
		public unsafe XmlElementAttribute this[int index]
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 385773, RefRangeEnd = 385775, XrefRangeStart = 385767, XrefRangeEnd = 385773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlElementAttributes.NativeMethodInfoPtr_get_Item_Public_get_XmlElementAttribute_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlElementAttribute>(intPtr3) : null;
				}
			}
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x0006C714 File Offset: 0x0006A914
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 385780, RefRangeEnd = 385781, XrefRangeStart = 385775, XrefRangeEnd = 385780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Add(XmlElementAttribute attribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlElementAttributes.NativeMethodInfoPtr_Add_Public_Int32_XmlElementAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x0006C764 File Offset: 0x0006A964
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 385804, RefRangeEnd = 385805, XrefRangeStart = 385781, XrefRangeEnd = 385804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddKeyHash(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlElementAttributes.NativeMethodInfoPtr_AddKeyHash_Internal_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x060013F3 RID: 5107 RVA: 0x0006C7A8 File Offset: 0x0006A9A8
		public unsafe int Order
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 385815, RefRangeEnd = 385816, XrefRangeStart = 385805, XrefRangeEnd = 385815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlElementAttributes.NativeMethodInfoPtr_get_Order_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x0006C7E4 File Offset: 0x0006A9E4
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 385162, RefRangeEnd = 385185, XrefRangeStart = 385162, XrefRangeEnd = 385185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlElementAttributes()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlElementAttributes>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlElementAttributes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x00008819 File Offset: 0x00006A19
		public XmlElementAttributes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001007 RID: 4103
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_XmlElementAttribute_Int32_0;

		// Token: 0x04001008 RID: 4104
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Int32_XmlElementAttribute_0;

		// Token: 0x04001009 RID: 4105
		private static readonly IntPtr NativeMethodInfoPtr_AddKeyHash_Internal_Void_StringBuilder_0;

		// Token: 0x0400100A RID: 4106
		private static readonly IntPtr NativeMethodInfoPtr_get_Order_Internal_get_Int32_0;

		// Token: 0x0400100B RID: 4107
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
