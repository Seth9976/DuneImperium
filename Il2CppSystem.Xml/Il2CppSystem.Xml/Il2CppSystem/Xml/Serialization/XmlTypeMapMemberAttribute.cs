using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000F2 RID: 242
	public class XmlTypeMapMemberAttribute : XmlTypeMapMember
	{
		// Token: 0x0600165A RID: 5722 RVA: 0x00076B10 File Offset: 0x00074D10
		// Note: this type is marked as 'beforefieldinit'.
		static XmlTypeMapMemberAttribute()
		{
			Il2CppClassPointerStore<XmlTypeMapMemberAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlTypeMapMemberAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTypeMapMemberAttribute>.NativeClassPtr);
			XmlTypeMapMemberAttribute.NativeFieldInfoPtr__attributeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapMemberAttribute>.NativeClassPtr, "_attributeName");
			XmlTypeMapMemberAttribute.NativeFieldInfoPtr__namespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapMemberAttribute>.NativeClassPtr, "_namespace");
			XmlTypeMapMemberAttribute.NativeFieldInfoPtr__form = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapMemberAttribute>.NativeClassPtr, "_form");
			XmlTypeMapMemberAttribute.NativeFieldInfoPtr__mappedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapMemberAttribute>.NativeClassPtr, "_mappedType");
			XmlTypeMapMemberAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberAttribute>.NativeClassPtr, 100666849);
			XmlTypeMapMemberAttribute.NativeMethodInfoPtr_get_AttributeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberAttribute>.NativeClassPtr, 100666850);
			XmlTypeMapMemberAttribute.NativeMethodInfoPtr_set_AttributeName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberAttribute>.NativeClassPtr, 100666851);
			XmlTypeMapMemberAttribute.NativeMethodInfoPtr_get_Namespace_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberAttribute>.NativeClassPtr, 100666852);
			XmlTypeMapMemberAttribute.NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberAttribute>.NativeClassPtr, 100666853);
			XmlTypeMapMemberAttribute.NativeMethodInfoPtr_set_Form_Public_set_Void_XmlSchemaForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberAttribute>.NativeClassPtr, 100666854);
			XmlTypeMapMemberAttribute.NativeMethodInfoPtr_get_MappedType_Public_get_XmlTypeMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberAttribute>.NativeClassPtr, 100666855);
			XmlTypeMapMemberAttribute.NativeMethodInfoPtr_set_MappedType_Public_set_Void_XmlTypeMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapMemberAttribute>.NativeClassPtr, 100666856);
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x00076C30 File Offset: 0x00074E30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 389799, RefRangeEnd = 389800, XrefRangeStart = 389794, XrefRangeEnd = 389799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapMemberAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTypeMapMemberAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x0600165C RID: 5724 RVA: 0x00076C6C File Offset: 0x00074E6C
		// (set) Token: 0x0600165D RID: 5725 RVA: 0x00076CA4 File Offset: 0x00074EA4
		public unsafe string AttributeName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberAttribute.NativeMethodInfoPtr_get_AttributeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberAttribute.NativeMethodInfoPtr_set_AttributeName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x0600165E RID: 5726 RVA: 0x00076CE8 File Offset: 0x00074EE8
		// (set) Token: 0x0600165F RID: 5727 RVA: 0x00076D20 File Offset: 0x00074F20
		public unsafe string Namespace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberAttribute.NativeMethodInfoPtr_get_Namespace_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberAttribute.NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000720 RID: 1824
		// (set) Token: 0x06001660 RID: 5728 RVA: 0x00076D64 File Offset: 0x00074F64
		public unsafe XmlSchemaForm Form
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 337738, RefRangeEnd = 337747, XrefRangeStart = 337738, XrefRangeEnd = 337747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberAttribute.NativeMethodInfoPtr_set_Form_Public_set_Void_XmlSchemaForm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x06001661 RID: 5729 RVA: 0x00076DA4 File Offset: 0x00074FA4
		// (set) Token: 0x06001662 RID: 5730 RVA: 0x00076DE4 File Offset: 0x00074FE4
		public unsafe XmlTypeMapping MappedType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberAttribute.NativeMethodInfoPtr_get_MappedType_Public_get_XmlTypeMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapMemberAttribute.NativeMethodInfoPtr_set_MappedType_Public_set_Void_XmlTypeMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x0000977B File Offset: 0x0000797B
		public XmlTypeMapMemberAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x06001664 RID: 5732 RVA: 0x00076E28 File Offset: 0x00075028
		// (set) Token: 0x06001665 RID: 5733 RVA: 0x00009784 File Offset: 0x00007984
		public unsafe string _attributeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMemberAttribute.NativeFieldInfoPtr__attributeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMemberAttribute.NativeFieldInfoPtr__attributeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x06001666 RID: 5734 RVA: 0x00076E50 File Offset: 0x00075050
		// (set) Token: 0x06001667 RID: 5735 RVA: 0x000097A3 File Offset: 0x000079A3
		public unsafe string _namespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMemberAttribute.NativeFieldInfoPtr__namespace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMemberAttribute.NativeFieldInfoPtr__namespace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x06001668 RID: 5736 RVA: 0x00076E78 File Offset: 0x00075078
		// (set) Token: 0x06001669 RID: 5737 RVA: 0x000097C2 File Offset: 0x000079C2
		public unsafe XmlSchemaForm _form
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMemberAttribute.NativeFieldInfoPtr__form);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMemberAttribute.NativeFieldInfoPtr__form)) = value;
			}
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x0600166A RID: 5738 RVA: 0x00076EA0 File Offset: 0x000750A0
		// (set) Token: 0x0600166B RID: 5739 RVA: 0x000097DD File Offset: 0x000079DD
		public unsafe XmlTypeMapping _mappedType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMemberAttribute.NativeFieldInfoPtr__mappedType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapMemberAttribute.NativeFieldInfoPtr__mappedType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011C0 RID: 4544
		private static readonly IntPtr NativeFieldInfoPtr__attributeName;

		// Token: 0x040011C1 RID: 4545
		private static readonly IntPtr NativeFieldInfoPtr__namespace;

		// Token: 0x040011C2 RID: 4546
		private static readonly IntPtr NativeFieldInfoPtr__form;

		// Token: 0x040011C3 RID: 4547
		private static readonly IntPtr NativeFieldInfoPtr__mappedType;

		// Token: 0x040011C4 RID: 4548
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040011C5 RID: 4549
		private static readonly IntPtr NativeMethodInfoPtr_get_AttributeName_Public_get_String_0;

		// Token: 0x040011C6 RID: 4550
		private static readonly IntPtr NativeMethodInfoPtr_set_AttributeName_Public_set_Void_String_0;

		// Token: 0x040011C7 RID: 4551
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespace_Public_get_String_0;

		// Token: 0x040011C8 RID: 4552
		private static readonly IntPtr NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0;

		// Token: 0x040011C9 RID: 4553
		private static readonly IntPtr NativeMethodInfoPtr_set_Form_Public_set_Void_XmlSchemaForm_0;

		// Token: 0x040011CA RID: 4554
		private static readonly IntPtr NativeMethodInfoPtr_get_MappedType_Public_get_XmlTypeMapping_0;

		// Token: 0x040011CB RID: 4555
		private static readonly IntPtr NativeMethodInfoPtr_set_MappedType_Public_set_Void_XmlTypeMapping_0;
	}
}
