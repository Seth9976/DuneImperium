using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001F6 RID: 502
	public class XmlAnyListConverter : XmlListConverter
	{
		// Token: 0x06002AC5 RID: 10949 RVA: 0x000C7AAC File Offset: 0x000C5CAC
		// Note: this type is marked as 'beforefieldinit'.
		static XmlAnyListConverter()
		{
			Il2CppClassPointerStore<XmlAnyListConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlAnyListConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlAnyListConverter>.NativeClassPtr);
			XmlAnyListConverter.NativeFieldInfoPtr_ItemList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAnyListConverter>.NativeClassPtr, "ItemList");
			XmlAnyListConverter.NativeFieldInfoPtr_AnyAtomicList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAnyListConverter>.NativeClassPtr, "AnyAtomicList");
			XmlAnyListConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlBaseConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyListConverter>.NativeClassPtr, 100669546);
			XmlAnyListConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAnyListConverter>.NativeClassPtr, 100669547);
		}

		// Token: 0x06002AC6 RID: 10950 RVA: 0x000C7B2C File Offset: 0x000C5D2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 422299, RefRangeEnd = 422300, XrefRangeStart = 422294, XrefRangeEnd = 422299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAnyListConverter(XmlBaseConverter atomicConverter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAnyListConverter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(atomicConverter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAnyListConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlBaseConverter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AC7 RID: 10951 RVA: 0x000C7B78 File Offset: 0x000C5D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422300, XrefRangeEnd = 422375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ChangeType(Object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAnyListConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002AC8 RID: 10952 RVA: 0x00011A42 File Offset: 0x0000FC42
		public XmlAnyListConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E3B RID: 3643
		// (get) Token: 0x06002AC9 RID: 10953 RVA: 0x000C7BF8 File Offset: 0x000C5DF8
		// (set) Token: 0x06002ACA RID: 10954 RVA: 0x00011A4B File Offset: 0x0000FC4B
		public unsafe static XmlValueConverter ItemList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlAnyListConverter.NativeFieldInfoPtr_ItemList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlValueConverter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlAnyListConverter.NativeFieldInfoPtr_ItemList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E3C RID: 3644
		// (get) Token: 0x06002ACB RID: 10955 RVA: 0x000C7C20 File Offset: 0x000C5E20
		// (set) Token: 0x06002ACC RID: 10956 RVA: 0x00011A5D File Offset: 0x0000FC5D
		public unsafe static XmlValueConverter AnyAtomicList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlAnyListConverter.NativeFieldInfoPtr_AnyAtomicList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlValueConverter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlAnyListConverter.NativeFieldInfoPtr_AnyAtomicList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040020B2 RID: 8370
		private static readonly IntPtr NativeFieldInfoPtr_ItemList;

		// Token: 0x040020B3 RID: 8371
		private static readonly IntPtr NativeFieldInfoPtr_AnyAtomicList;

		// Token: 0x040020B4 RID: 8372
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_XmlBaseConverter_0;

		// Token: 0x040020B5 RID: 8373
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_IXmlNamespaceResolver_0;
	}
}
