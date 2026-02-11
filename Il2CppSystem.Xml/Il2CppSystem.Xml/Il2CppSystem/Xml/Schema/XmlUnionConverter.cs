using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001F8 RID: 504
	public class XmlUnionConverter : XmlBaseConverter
	{
		// Token: 0x06002ADD RID: 10973 RVA: 0x000C8208 File Offset: 0x000C6408
		// Note: this type is marked as 'beforefieldinit'.
		static XmlUnionConverter()
		{
			Il2CppClassPointerStore<XmlUnionConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlUnionConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlUnionConverter>.NativeClassPtr);
			XmlUnionConverter.NativeFieldInfoPtr_converters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUnionConverter>.NativeClassPtr, "converters");
			XmlUnionConverter.NativeFieldInfoPtr_hasAtomicMember = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUnionConverter>.NativeClassPtr, "hasAtomicMember");
			XmlUnionConverter.NativeFieldInfoPtr_hasListMember = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlUnionConverter>.NativeClassPtr, "hasListMember");
			XmlUnionConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUnionConverter>.NativeClassPtr, 100669561);
			XmlUnionConverter.NativeMethodInfoPtr_Create_Public_Static_XmlValueConverter_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUnionConverter>.NativeClassPtr, 100669562);
			XmlUnionConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlUnionConverter>.NativeClassPtr, 100669563);
		}

		// Token: 0x06002ADE RID: 10974 RVA: 0x000C82B0 File Offset: 0x000C64B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 422859, RefRangeEnd = 422860, XrefRangeStart = 422841, XrefRangeEnd = 422859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlUnionConverter(XmlSchemaType schemaType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlUnionConverter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUnionConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002ADF RID: 10975 RVA: 0x000C82FC File Offset: 0x000C64FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 422864, RefRangeEnd = 422865, XrefRangeStart = 422860, XrefRangeEnd = 422864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlValueConverter Create(XmlSchemaType schemaType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlUnionConverter.NativeMethodInfoPtr_Create_Public_Static_XmlValueConverter_XmlSchemaType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlValueConverter>(intPtr3) : null;
			}
		}

		// Token: 0x06002AE0 RID: 10976 RVA: 0x000C8340 File Offset: 0x000C6540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422865, XrefRangeEnd = 422883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlUnionConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002AE1 RID: 10977 RVA: 0x00011A97 File Offset: 0x0000FC97
		public XmlUnionConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E3E RID: 3646
		// (get) Token: 0x06002AE2 RID: 10978 RVA: 0x000C83C0 File Offset: 0x000C65C0
		// (set) Token: 0x06002AE3 RID: 10979 RVA: 0x00011AA0 File Offset: 0x0000FCA0
		public unsafe Il2CppReferenceArray<XmlValueConverter> converters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUnionConverter.NativeFieldInfoPtr_converters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlValueConverter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUnionConverter.NativeFieldInfoPtr_converters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E3F RID: 3647
		// (get) Token: 0x06002AE4 RID: 10980 RVA: 0x000C83F0 File Offset: 0x000C65F0
		// (set) Token: 0x06002AE5 RID: 10981 RVA: 0x00011ABF File Offset: 0x0000FCBF
		public unsafe bool hasAtomicMember
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUnionConverter.NativeFieldInfoPtr_hasAtomicMember);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUnionConverter.NativeFieldInfoPtr_hasAtomicMember)) = value;
			}
		}

		// Token: 0x17000E40 RID: 3648
		// (get) Token: 0x06002AE6 RID: 10982 RVA: 0x000C8418 File Offset: 0x000C6618
		// (set) Token: 0x06002AE7 RID: 10983 RVA: 0x00011ADA File Offset: 0x0000FCDA
		public unsafe bool hasListMember
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUnionConverter.NativeFieldInfoPtr_hasListMember);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlUnionConverter.NativeFieldInfoPtr_hasListMember)) = value;
			}
		}

		// Token: 0x040020C3 RID: 8387
		private static readonly IntPtr NativeFieldInfoPtr_converters;

		// Token: 0x040020C4 RID: 8388
		private static readonly IntPtr NativeFieldInfoPtr_hasAtomicMember;

		// Token: 0x040020C5 RID: 8389
		private static readonly IntPtr NativeFieldInfoPtr_hasListMember;

		// Token: 0x040020C6 RID: 8390
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_XmlSchemaType_0;

		// Token: 0x040020C7 RID: 8391
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_XmlValueConverter_XmlSchemaType_0;

		// Token: 0x040020C8 RID: 8392
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_IXmlNamespaceResolver_0;
	}
}
