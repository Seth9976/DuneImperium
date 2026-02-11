using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001DD RID: 477
	public class XmlSchemaSimpleTypeRestriction : XmlSchemaSimpleTypeContent
	{
		// Token: 0x060027F8 RID: 10232 RVA: 0x000BA15C File Offset: 0x000B835C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaSimpleTypeRestriction()
		{
			Il2CppClassPointerStore<XmlSchemaSimpleTypeRestriction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaSimpleTypeRestriction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaSimpleTypeRestriction>.NativeClassPtr);
			XmlSchemaSimpleTypeRestriction.NativeFieldInfoPtr_baseTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSimpleTypeRestriction>.NativeClassPtr, "baseTypeName");
			XmlSchemaSimpleTypeRestriction.NativeFieldInfoPtr_baseType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSimpleTypeRestriction>.NativeClassPtr, "baseType");
			XmlSchemaSimpleTypeRestriction.NativeFieldInfoPtr_facets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSimpleTypeRestriction>.NativeClassPtr, "facets");
			XmlSchemaSimpleTypeRestriction.NativeMethodInfoPtr_get_BaseTypeName_Public_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleTypeRestriction>.NativeClassPtr, 100669078);
			XmlSchemaSimpleTypeRestriction.NativeMethodInfoPtr_set_BaseTypeName_Public_set_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleTypeRestriction>.NativeClassPtr, 100669079);
			XmlSchemaSimpleTypeRestriction.NativeMethodInfoPtr_get_BaseType_Public_get_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleTypeRestriction>.NativeClassPtr, 100669080);
			XmlSchemaSimpleTypeRestriction.NativeMethodInfoPtr_set_BaseType_Public_set_Void_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleTypeRestriction>.NativeClassPtr, 100669081);
			XmlSchemaSimpleTypeRestriction.NativeMethodInfoPtr_get_Facets_Public_get_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleTypeRestriction>.NativeClassPtr, 100669082);
			XmlSchemaSimpleTypeRestriction.NativeMethodInfoPtr_Clone_Internal_Virtual_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleTypeRestriction>.NativeClassPtr, 100669083);
			XmlSchemaSimpleTypeRestriction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleTypeRestriction>.NativeClassPtr, 100669084);
		}

		// Token: 0x17000DAC RID: 3500
		// (get) Token: 0x060027F9 RID: 10233 RVA: 0x000BA254 File Offset: 0x000B8454
		// (set) Token: 0x060027FA RID: 10234 RVA: 0x000BA294 File Offset: 0x000B8494
		public unsafe XmlQualifiedName BaseTypeName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleTypeRestriction.NativeMethodInfoPtr_get_BaseTypeName_Public_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 414645, RefRangeEnd = 414648, XrefRangeStart = 414636, XrefRangeEnd = 414645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleTypeRestriction.NativeMethodInfoPtr_set_BaseTypeName_Public_set_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000DAD RID: 3501
		// (get) Token: 0x060027FB RID: 10235 RVA: 0x000BA2D8 File Offset: 0x000B84D8
		// (set) Token: 0x060027FC RID: 10236 RVA: 0x000BA318 File Offset: 0x000B8518
		public unsafe XmlSchemaSimpleType BaseType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleTypeRestriction.NativeMethodInfoPtr_get_BaseType_Public_get_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleTypeRestriction.NativeMethodInfoPtr_set_BaseType_Public_set_Void_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000DAE RID: 3502
		// (get) Token: 0x060027FD RID: 10237 RVA: 0x000BA35C File Offset: 0x000B855C
		public unsafe XmlSchemaObjectCollection Facets
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleTypeRestriction.NativeMethodInfoPtr_get_Facets_Public_get_XmlSchemaObjectCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr3) : null;
			}
		}

		// Token: 0x060027FE RID: 10238 RVA: 0x000BA39C File Offset: 0x000B859C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414648, XrefRangeEnd = 414660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XmlSchemaObject Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaSimpleTypeRestriction.NativeMethodInfoPtr_Clone_Internal_Virtual_XmlSchemaObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObject>(intPtr3) : null;
		}

		// Token: 0x060027FF RID: 10239 RVA: 0x000BA3E8 File Offset: 0x000B85E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 414671, RefRangeEnd = 414674, XrefRangeStart = 414660, XrefRangeEnd = 414671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaSimpleTypeRestriction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaSimpleTypeRestriction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleTypeRestriction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002800 RID: 10240 RVA: 0x00010ED3 File Offset: 0x0000F0D3
		public XmlSchemaSimpleTypeRestriction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DA9 RID: 3497
		// (get) Token: 0x06002801 RID: 10241 RVA: 0x000BA424 File Offset: 0x000B8624
		// (set) Token: 0x06002802 RID: 10242 RVA: 0x00010EDC File Offset: 0x0000F0DC
		public unsafe XmlQualifiedName baseTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleTypeRestriction.NativeFieldInfoPtr_baseTypeName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleTypeRestriction.NativeFieldInfoPtr_baseTypeName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DAA RID: 3498
		// (get) Token: 0x06002803 RID: 10243 RVA: 0x000BA454 File Offset: 0x000B8654
		// (set) Token: 0x06002804 RID: 10244 RVA: 0x00010EFB File Offset: 0x0000F0FB
		public unsafe XmlSchemaSimpleType baseType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleTypeRestriction.NativeFieldInfoPtr_baseType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleTypeRestriction.NativeFieldInfoPtr_baseType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DAB RID: 3499
		// (get) Token: 0x06002805 RID: 10245 RVA: 0x000BA484 File Offset: 0x000B8684
		// (set) Token: 0x06002806 RID: 10246 RVA: 0x00010F1A File Offset: 0x0000F11A
		public unsafe XmlSchemaObjectCollection facets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleTypeRestriction.NativeFieldInfoPtr_facets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleTypeRestriction.NativeFieldInfoPtr_facets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001E20 RID: 7712
		private static readonly IntPtr NativeFieldInfoPtr_baseTypeName;

		// Token: 0x04001E21 RID: 7713
		private static readonly IntPtr NativeFieldInfoPtr_baseType;

		// Token: 0x04001E22 RID: 7714
		private static readonly IntPtr NativeFieldInfoPtr_facets;

		// Token: 0x04001E23 RID: 7715
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseTypeName_Public_get_XmlQualifiedName_0;

		// Token: 0x04001E24 RID: 7716
		private static readonly IntPtr NativeMethodInfoPtr_set_BaseTypeName_Public_set_Void_XmlQualifiedName_0;

		// Token: 0x04001E25 RID: 7717
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseType_Public_get_XmlSchemaSimpleType_0;

		// Token: 0x04001E26 RID: 7718
		private static readonly IntPtr NativeMethodInfoPtr_set_BaseType_Public_set_Void_XmlSchemaSimpleType_0;

		// Token: 0x04001E27 RID: 7719
		private static readonly IntPtr NativeMethodInfoPtr_get_Facets_Public_get_XmlSchemaObjectCollection_0;

		// Token: 0x04001E28 RID: 7720
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Internal_Virtual_XmlSchemaObject_0;

		// Token: 0x04001E29 RID: 7721
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
