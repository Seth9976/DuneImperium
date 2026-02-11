using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001DA RID: 474
	public class XmlSchemaSimpleType : XmlSchemaType
	{
		// Token: 0x060027DD RID: 10205 RVA: 0x000B9BA0 File Offset: 0x000B7DA0
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaSimpleType()
		{
			Il2CppClassPointerStore<XmlSchemaSimpleType>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaSimpleType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaSimpleType>.NativeClassPtr);
			XmlSchemaSimpleType.NativeFieldInfoPtr_content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSimpleType>.NativeClassPtr, "content");
			XmlSchemaSimpleType.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleType>.NativeClassPtr, 100669065);
			XmlSchemaSimpleType.NativeMethodInfoPtr_get_Content_Public_get_XmlSchemaSimpleTypeContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleType>.NativeClassPtr, 100669066);
			XmlSchemaSimpleType.NativeMethodInfoPtr_set_Content_Public_set_Void_XmlSchemaSimpleTypeContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleType>.NativeClassPtr, 100669067);
			XmlSchemaSimpleType.NativeMethodInfoPtr_Clone_Internal_Virtual_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleType>.NativeClassPtr, 100669068);
		}

		// Token: 0x060027DE RID: 10206 RVA: 0x000B9C34 File Offset: 0x000B7E34
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 414595, RefRangeEnd = 414599, XrefRangeStart = 414588, XrefRangeEnd = 414595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaSimpleType()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaSimpleType>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleType.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000DA2 RID: 3490
		// (get) Token: 0x060027DF RID: 10207 RVA: 0x000B9C70 File Offset: 0x000B7E70
		// (set) Token: 0x060027E0 RID: 10208 RVA: 0x000B9CB0 File Offset: 0x000B7EB0
		public unsafe XmlSchemaSimpleTypeContent Content
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleType.NativeMethodInfoPtr_get_Content_Public_get_XmlSchemaSimpleTypeContent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleTypeContent>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleType.NativeMethodInfoPtr_set_Content_Public_set_Void_XmlSchemaSimpleTypeContent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060027E1 RID: 10209 RVA: 0x000B9CF4 File Offset: 0x000B7EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414599, XrefRangeEnd = 414606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XmlSchemaObject Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaSimpleType.NativeMethodInfoPtr_Clone_Internal_Virtual_XmlSchemaObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObject>(intPtr3) : null;
		}

		// Token: 0x060027E2 RID: 10210 RVA: 0x00010E03 File Offset: 0x0000F003
		public XmlSchemaSimpleType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DA1 RID: 3489
		// (get) Token: 0x060027E3 RID: 10211 RVA: 0x000B9D40 File Offset: 0x000B7F40
		// (set) Token: 0x060027E4 RID: 10212 RVA: 0x00010E0C File Offset: 0x0000F00C
		public unsafe XmlSchemaSimpleTypeContent content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleType.NativeFieldInfoPtr_content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleTypeContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleType.NativeFieldInfoPtr_content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001E0F RID: 7695
		private static readonly IntPtr NativeFieldInfoPtr_content;

		// Token: 0x04001E10 RID: 7696
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E11 RID: 7697
		private static readonly IntPtr NativeMethodInfoPtr_get_Content_Public_get_XmlSchemaSimpleTypeContent_0;

		// Token: 0x04001E12 RID: 7698
		private static readonly IntPtr NativeMethodInfoPtr_set_Content_Public_set_Void_XmlSchemaSimpleTypeContent_0;

		// Token: 0x04001E13 RID: 7699
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Internal_Virtual_XmlSchemaObject_0;
	}
}
