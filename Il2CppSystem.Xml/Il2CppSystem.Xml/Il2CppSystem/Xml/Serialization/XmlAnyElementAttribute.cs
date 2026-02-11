using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000C8 RID: 200
	public class XmlAnyElementAttribute : Attribute
	{
		// Token: 0x06001333 RID: 4915 RVA: 0x00069FA4 File Offset: 0x000681A4
		// Note: this type is marked as 'beforefieldinit'.
		static XmlAnyElementAttribute()
		{
			Il2CppClassPointerStore<XmlAnyElementAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlAnyElementAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlAnyElementAttribute>.NativeClassPtr);
			XmlAnyElementAttribute.NativeFieldInfoPtr_elementName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAnyElementAttribute>.NativeClassPtr, "elementName");
			XmlAnyElementAttribute.NativeFieldInfoPtr_ns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAnyElementAttribute>.NativeClassPtr, "ns");
			XmlAnyElementAttribute.NativeFieldInfoPtr_order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAnyElementAttribute>.NativeClassPtr, "order");
			XmlAnyElementAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyElementAttribute>.NativeClassPtr, 100666412);
			XmlAnyElementAttribute.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyElementAttribute>.NativeClassPtr, 100666413);
			XmlAnyElementAttribute.NativeMethodInfoPtr_get_Namespace_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyElementAttribute>.NativeClassPtr, 100666414);
			XmlAnyElementAttribute.NativeMethodInfoPtr_get_Order_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyElementAttribute>.NativeClassPtr, 100666415);
			XmlAnyElementAttribute.NativeMethodInfoPtr_AddKeyHash_Internal_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyElementAttribute>.NativeClassPtr, 100666416);
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x0006A074 File Offset: 0x00068274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385090, XrefRangeEnd = 385091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAnyElementAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAnyElementAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAnyElementAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06001335 RID: 4917 RVA: 0x0006A0B0 File Offset: 0x000682B0
		public unsafe string Name
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 385092, RefRangeEnd = 385094, XrefRangeStart = 385091, XrefRangeEnd = 385092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAnyElementAttribute.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06001336 RID: 4918 RVA: 0x0006A0E8 File Offset: 0x000682E8
		public unsafe string Namespace
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAnyElementAttribute.NativeMethodInfoPtr_get_Namespace_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06001337 RID: 4919 RVA: 0x0006A120 File Offset: 0x00068320
		public unsafe int Order
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAnyElementAttribute.NativeMethodInfoPtr_get_Order_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x0006A15C File Offset: 0x0006835C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 385121, RefRangeEnd = 385122, XrefRangeStart = 385094, XrefRangeEnd = 385121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddKeyHash(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAnyElementAttribute.NativeMethodInfoPtr_AddKeyHash_Internal_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x00008288 File Offset: 0x00006488
		public XmlAnyElementAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x0600133A RID: 4922 RVA: 0x0006A1A0 File Offset: 0x000683A0
		// (set) Token: 0x0600133B RID: 4923 RVA: 0x00008291 File Offset: 0x00006491
		public unsafe string elementName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAnyElementAttribute.NativeFieldInfoPtr_elementName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAnyElementAttribute.NativeFieldInfoPtr_elementName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x0600133C RID: 4924 RVA: 0x0006A1C8 File Offset: 0x000683C8
		// (set) Token: 0x0600133D RID: 4925 RVA: 0x000082B0 File Offset: 0x000064B0
		public unsafe string ns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAnyElementAttribute.NativeFieldInfoPtr_ns);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAnyElementAttribute.NativeFieldInfoPtr_ns), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x0600133E RID: 4926 RVA: 0x0006A1F0 File Offset: 0x000683F0
		// (set) Token: 0x0600133F RID: 4927 RVA: 0x000082CF File Offset: 0x000064CF
		public unsafe int order
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAnyElementAttribute.NativeFieldInfoPtr_order);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAnyElementAttribute.NativeFieldInfoPtr_order)) = value;
			}
		}

		// Token: 0x04000F8E RID: 3982
		private static readonly IntPtr NativeFieldInfoPtr_elementName;

		// Token: 0x04000F8F RID: 3983
		private static readonly IntPtr NativeFieldInfoPtr_ns;

		// Token: 0x04000F90 RID: 3984
		private static readonly IntPtr NativeFieldInfoPtr_order;

		// Token: 0x04000F91 RID: 3985
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000F92 RID: 3986
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04000F93 RID: 3987
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespace_Public_get_String_0;

		// Token: 0x04000F94 RID: 3988
		private static readonly IntPtr NativeMethodInfoPtr_get_Order_Public_get_Int32_0;

		// Token: 0x04000F95 RID: 3989
		private static readonly IntPtr NativeMethodInfoPtr_AddKeyHash_Internal_Void_StringBuilder_0;
	}
}
