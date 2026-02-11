using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001A5 RID: 421
	public class XmlSchemaComplexContent : XmlSchemaContentModel
	{
		// Token: 0x060024A4 RID: 9380 RVA: 0x000AD6E0 File Offset: 0x000AB8E0
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaComplexContent()
		{
			Il2CppClassPointerStore<XmlSchemaComplexContent>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaComplexContent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaComplexContent>.NativeClassPtr);
			XmlSchemaComplexContent.NativeFieldInfoPtr_content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexContent>.NativeClassPtr, "content");
			XmlSchemaComplexContent.NativeFieldInfoPtr_isMixed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexContent>.NativeClassPtr, "isMixed");
			XmlSchemaComplexContent.NativeFieldInfoPtr_hasMixedAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexContent>.NativeClassPtr, "hasMixedAttribute");
			XmlSchemaComplexContent.NativeMethodInfoPtr_get_IsMixed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexContent>.NativeClassPtr, 100668606);
			XmlSchemaComplexContent.NativeMethodInfoPtr_set_IsMixed_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexContent>.NativeClassPtr, 100668607);
			XmlSchemaComplexContent.NativeMethodInfoPtr_get_Content_Public_Virtual_get_XmlSchemaContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexContent>.NativeClassPtr, 100668608);
			XmlSchemaComplexContent.NativeMethodInfoPtr_set_Content_Public_Virtual_set_Void_XmlSchemaContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexContent>.NativeClassPtr, 100668609);
			XmlSchemaComplexContent.NativeMethodInfoPtr_get_HasMixedAttribute_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexContent>.NativeClassPtr, 100668610);
			XmlSchemaComplexContent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexContent>.NativeClassPtr, 100668611);
		}

		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x060024A5 RID: 9381 RVA: 0x000AD7C4 File Offset: 0x000AB9C4
		// (set) Token: 0x060024A6 RID: 9382 RVA: 0x000AD800 File Offset: 0x000ABA00
		public unsafe bool IsMixed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexContent.NativeMethodInfoPtr_get_IsMixed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 411246, RefRangeEnd = 411249, XrefRangeStart = 411246, XrefRangeEnd = 411246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexContent.NativeMethodInfoPtr_set_IsMixed_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x060024A7 RID: 9383 RVA: 0x000AD840 File Offset: 0x000ABA40
		// (set) Token: 0x060024A8 RID: 9384 RVA: 0x000AD88C File Offset: 0x000ABA8C
		public unsafe override XmlSchemaContent Content
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaComplexContent.NativeMethodInfoPtr_get_Content_Public_Virtual_get_XmlSchemaContent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaContent>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaComplexContent.NativeMethodInfoPtr_set_Content_Public_Virtual_set_Void_XmlSchemaContent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x060024A9 RID: 9385 RVA: 0x000AD8DC File Offset: 0x000ABADC
		public unsafe bool HasMixedAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexContent.NativeMethodInfoPtr_get_HasMixedAttribute_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060024AA RID: 9386 RVA: 0x000AD918 File Offset: 0x000ABB18
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaComplexContent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaComplexContent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexContent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024AB RID: 9387 RVA: 0x0000F7F9 File Offset: 0x0000D9F9
		public XmlSchemaComplexContent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x060024AC RID: 9388 RVA: 0x000AD954 File Offset: 0x000ABB54
		// (set) Token: 0x060024AD RID: 9389 RVA: 0x0000F802 File Offset: 0x0000DA02
		public unsafe XmlSchemaContent content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexContent.NativeFieldInfoPtr_content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexContent.NativeFieldInfoPtr_content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x060024AE RID: 9390 RVA: 0x000AD984 File Offset: 0x000ABB84
		// (set) Token: 0x060024AF RID: 9391 RVA: 0x0000F821 File Offset: 0x0000DA21
		public unsafe bool isMixed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexContent.NativeFieldInfoPtr_isMixed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexContent.NativeFieldInfoPtr_isMixed)) = value;
			}
		}

		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x060024B0 RID: 9392 RVA: 0x000AD9AC File Offset: 0x000ABBAC
		// (set) Token: 0x060024B1 RID: 9393 RVA: 0x0000F83C File Offset: 0x0000DA3C
		public unsafe bool hasMixedAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexContent.NativeFieldInfoPtr_hasMixedAttribute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexContent.NativeFieldInfoPtr_hasMixedAttribute)) = value;
			}
		}

		// Token: 0x04001BA2 RID: 7074
		private static readonly IntPtr NativeFieldInfoPtr_content;

		// Token: 0x04001BA3 RID: 7075
		private static readonly IntPtr NativeFieldInfoPtr_isMixed;

		// Token: 0x04001BA4 RID: 7076
		private static readonly IntPtr NativeFieldInfoPtr_hasMixedAttribute;

		// Token: 0x04001BA5 RID: 7077
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMixed_Public_get_Boolean_0;

		// Token: 0x04001BA6 RID: 7078
		private static readonly IntPtr NativeMethodInfoPtr_set_IsMixed_Public_set_Void_Boolean_0;

		// Token: 0x04001BA7 RID: 7079
		private static readonly IntPtr NativeMethodInfoPtr_get_Content_Public_Virtual_get_XmlSchemaContent_0;

		// Token: 0x04001BA8 RID: 7080
		private static readonly IntPtr NativeMethodInfoPtr_set_Content_Public_Virtual_set_Void_XmlSchemaContent_0;

		// Token: 0x04001BA9 RID: 7081
		private static readonly IntPtr NativeMethodInfoPtr_get_HasMixedAttribute_Internal_get_Boolean_0;

		// Token: 0x04001BAA RID: 7082
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
