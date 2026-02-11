using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001D9 RID: 473
	public class XmlSchemaSimpleContentRestriction : XmlSchemaContent
	{
		// Token: 0x060027C7 RID: 10183 RVA: 0x000B96C8 File Offset: 0x000B78C8
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaSimpleContentRestriction()
		{
			Il2CppClassPointerStore<XmlSchemaSimpleContentRestriction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaSimpleContentRestriction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaSimpleContentRestriction>.NativeClassPtr);
			XmlSchemaSimpleContentRestriction.NativeFieldInfoPtr_baseTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSimpleContentRestriction>.NativeClassPtr, "baseTypeName");
			XmlSchemaSimpleContentRestriction.NativeFieldInfoPtr_baseType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSimpleContentRestriction>.NativeClassPtr, "baseType");
			XmlSchemaSimpleContentRestriction.NativeFieldInfoPtr_facets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSimpleContentRestriction>.NativeClassPtr, "facets");
			XmlSchemaSimpleContentRestriction.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSimpleContentRestriction>.NativeClassPtr, "attributes");
			XmlSchemaSimpleContentRestriction.NativeFieldInfoPtr_anyAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSimpleContentRestriction>.NativeClassPtr, "anyAttribute");
			XmlSchemaSimpleContentRestriction.NativeMethodInfoPtr_get_BaseTypeName_Public_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleContentRestriction>.NativeClassPtr, 100669055);
			XmlSchemaSimpleContentRestriction.NativeMethodInfoPtr_set_BaseTypeName_Public_set_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleContentRestriction>.NativeClassPtr, 100669056);
			XmlSchemaSimpleContentRestriction.NativeMethodInfoPtr_get_BaseType_Public_get_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleContentRestriction>.NativeClassPtr, 100669057);
			XmlSchemaSimpleContentRestriction.NativeMethodInfoPtr_set_BaseType_Public_set_Void_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleContentRestriction>.NativeClassPtr, 100669058);
			XmlSchemaSimpleContentRestriction.NativeMethodInfoPtr_get_Facets_Public_get_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleContentRestriction>.NativeClassPtr, 100669059);
			XmlSchemaSimpleContentRestriction.NativeMethodInfoPtr_get_Attributes_Public_get_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleContentRestriction>.NativeClassPtr, 100669060);
			XmlSchemaSimpleContentRestriction.NativeMethodInfoPtr_get_AnyAttribute_Public_get_XmlSchemaAnyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleContentRestriction>.NativeClassPtr, 100669061);
			XmlSchemaSimpleContentRestriction.NativeMethodInfoPtr_set_AnyAttribute_Public_set_Void_XmlSchemaAnyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleContentRestriction>.NativeClassPtr, 100669062);
			XmlSchemaSimpleContentRestriction.NativeMethodInfoPtr_SetAttributes_Internal_Void_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleContentRestriction>.NativeClassPtr, 100669063);
			XmlSchemaSimpleContentRestriction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleContentRestriction>.NativeClassPtr, 100669064);
		}

		// Token: 0x17000D9C RID: 3484
		// (get) Token: 0x060027C8 RID: 10184 RVA: 0x000B9824 File Offset: 0x000B7A24
		// (set) Token: 0x060027C9 RID: 10185 RVA: 0x000B9864 File Offset: 0x000B7A64
		public unsafe XmlQualifiedName BaseTypeName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleContentRestriction.NativeMethodInfoPtr_get_BaseTypeName_Public_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 414570, RefRangeEnd = 414572, XrefRangeStart = 414561, XrefRangeEnd = 414570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleContentRestriction.NativeMethodInfoPtr_set_BaseTypeName_Public_set_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D9D RID: 3485
		// (get) Token: 0x060027CA RID: 10186 RVA: 0x000B98A8 File Offset: 0x000B7AA8
		// (set) Token: 0x060027CB RID: 10187 RVA: 0x000B98E8 File Offset: 0x000B7AE8
		public unsafe XmlSchemaSimpleType BaseType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleContentRestriction.NativeMethodInfoPtr_get_BaseType_Public_get_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleContentRestriction.NativeMethodInfoPtr_set_BaseType_Public_set_Void_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D9E RID: 3486
		// (get) Token: 0x060027CC RID: 10188 RVA: 0x000B992C File Offset: 0x000B7B2C
		public unsafe XmlSchemaObjectCollection Facets
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleContentRestriction.NativeMethodInfoPtr_get_Facets_Public_get_XmlSchemaObjectCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000D9F RID: 3487
		// (get) Token: 0x060027CD RID: 10189 RVA: 0x000B996C File Offset: 0x000B7B6C
		public unsafe XmlSchemaObjectCollection Attributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleContentRestriction.NativeMethodInfoPtr_get_Attributes_Public_get_XmlSchemaObjectCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000DA0 RID: 3488
		// (get) Token: 0x060027CE RID: 10190 RVA: 0x000B99AC File Offset: 0x000B7BAC
		// (set) Token: 0x060027CF RID: 10191 RVA: 0x000B99EC File Offset: 0x000B7BEC
		public unsafe XmlSchemaAnyAttribute AnyAttribute
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleContentRestriction.NativeMethodInfoPtr_get_AnyAttribute_Public_get_XmlSchemaAnyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaAnyAttribute>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleContentRestriction.NativeMethodInfoPtr_set_AnyAttribute_Public_set_Void_XmlSchemaAnyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060027D0 RID: 10192 RVA: 0x000B9A30 File Offset: 0x000B7C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAttributes(XmlSchemaObjectCollection newAttributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newAttributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleContentRestriction.NativeMethodInfoPtr_SetAttributes_Internal_Void_XmlSchemaObjectCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060027D1 RID: 10193 RVA: 0x000B9A74 File Offset: 0x000B7C74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 414587, RefRangeEnd = 414588, XrefRangeStart = 414572, XrefRangeEnd = 414587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaSimpleContentRestriction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaSimpleContentRestriction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleContentRestriction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027D2 RID: 10194 RVA: 0x00010D5F File Offset: 0x0000EF5F
		public XmlSchemaSimpleContentRestriction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D97 RID: 3479
		// (get) Token: 0x060027D3 RID: 10195 RVA: 0x000B9AB0 File Offset: 0x000B7CB0
		// (set) Token: 0x060027D4 RID: 10196 RVA: 0x00010D68 File Offset: 0x0000EF68
		public unsafe XmlQualifiedName baseTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleContentRestriction.NativeFieldInfoPtr_baseTypeName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleContentRestriction.NativeFieldInfoPtr_baseTypeName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D98 RID: 3480
		// (get) Token: 0x060027D5 RID: 10197 RVA: 0x000B9AE0 File Offset: 0x000B7CE0
		// (set) Token: 0x060027D6 RID: 10198 RVA: 0x00010D87 File Offset: 0x0000EF87
		public unsafe XmlSchemaSimpleType baseType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleContentRestriction.NativeFieldInfoPtr_baseType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleContentRestriction.NativeFieldInfoPtr_baseType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D99 RID: 3481
		// (get) Token: 0x060027D7 RID: 10199 RVA: 0x000B9B10 File Offset: 0x000B7D10
		// (set) Token: 0x060027D8 RID: 10200 RVA: 0x00010DA6 File Offset: 0x0000EFA6
		public unsafe XmlSchemaObjectCollection facets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleContentRestriction.NativeFieldInfoPtr_facets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleContentRestriction.NativeFieldInfoPtr_facets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D9A RID: 3482
		// (get) Token: 0x060027D9 RID: 10201 RVA: 0x000B9B40 File Offset: 0x000B7D40
		// (set) Token: 0x060027DA RID: 10202 RVA: 0x00010DC5 File Offset: 0x0000EFC5
		public unsafe XmlSchemaObjectCollection attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleContentRestriction.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleContentRestriction.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D9B RID: 3483
		// (get) Token: 0x060027DB RID: 10203 RVA: 0x000B9B70 File Offset: 0x000B7D70
		// (set) Token: 0x060027DC RID: 10204 RVA: 0x00010DE4 File Offset: 0x0000EFE4
		public unsafe XmlSchemaAnyAttribute anyAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleContentRestriction.NativeFieldInfoPtr_anyAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaAnyAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleContentRestriction.NativeFieldInfoPtr_anyAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001E00 RID: 7680
		private static readonly IntPtr NativeFieldInfoPtr_baseTypeName;

		// Token: 0x04001E01 RID: 7681
		private static readonly IntPtr NativeFieldInfoPtr_baseType;

		// Token: 0x04001E02 RID: 7682
		private static readonly IntPtr NativeFieldInfoPtr_facets;

		// Token: 0x04001E03 RID: 7683
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x04001E04 RID: 7684
		private static readonly IntPtr NativeFieldInfoPtr_anyAttribute;

		// Token: 0x04001E05 RID: 7685
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseTypeName_Public_get_XmlQualifiedName_0;

		// Token: 0x04001E06 RID: 7686
		private static readonly IntPtr NativeMethodInfoPtr_set_BaseTypeName_Public_set_Void_XmlQualifiedName_0;

		// Token: 0x04001E07 RID: 7687
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseType_Public_get_XmlSchemaSimpleType_0;

		// Token: 0x04001E08 RID: 7688
		private static readonly IntPtr NativeMethodInfoPtr_set_BaseType_Public_set_Void_XmlSchemaSimpleType_0;

		// Token: 0x04001E09 RID: 7689
		private static readonly IntPtr NativeMethodInfoPtr_get_Facets_Public_get_XmlSchemaObjectCollection_0;

		// Token: 0x04001E0A RID: 7690
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_get_XmlSchemaObjectCollection_0;

		// Token: 0x04001E0B RID: 7691
		private static readonly IntPtr NativeMethodInfoPtr_get_AnyAttribute_Public_get_XmlSchemaAnyAttribute_0;

		// Token: 0x04001E0C RID: 7692
		private static readonly IntPtr NativeMethodInfoPtr_set_AnyAttribute_Public_set_Void_XmlSchemaAnyAttribute_0;

		// Token: 0x04001E0D RID: 7693
		private static readonly IntPtr NativeMethodInfoPtr_SetAttributes_Internal_Void_XmlSchemaObjectCollection_0;

		// Token: 0x04001E0E RID: 7694
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
