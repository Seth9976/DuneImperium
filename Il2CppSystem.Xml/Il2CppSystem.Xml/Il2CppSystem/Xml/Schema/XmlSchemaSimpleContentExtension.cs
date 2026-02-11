using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001D8 RID: 472
	public class XmlSchemaSimpleContentExtension : XmlSchemaContent
	{
		// Token: 0x060027B8 RID: 10168 RVA: 0x000B9378 File Offset: 0x000B7578
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaSimpleContentExtension()
		{
			Il2CppClassPointerStore<XmlSchemaSimpleContentExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaSimpleContentExtension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaSimpleContentExtension>.NativeClassPtr);
			XmlSchemaSimpleContentExtension.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSimpleContentExtension>.NativeClassPtr, "attributes");
			XmlSchemaSimpleContentExtension.NativeFieldInfoPtr_anyAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSimpleContentExtension>.NativeClassPtr, "anyAttribute");
			XmlSchemaSimpleContentExtension.NativeFieldInfoPtr_baseTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaSimpleContentExtension>.NativeClassPtr, "baseTypeName");
			XmlSchemaSimpleContentExtension.NativeMethodInfoPtr_get_BaseTypeName_Public_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleContentExtension>.NativeClassPtr, 100669048);
			XmlSchemaSimpleContentExtension.NativeMethodInfoPtr_set_BaseTypeName_Public_set_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleContentExtension>.NativeClassPtr, 100669049);
			XmlSchemaSimpleContentExtension.NativeMethodInfoPtr_get_Attributes_Public_get_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleContentExtension>.NativeClassPtr, 100669050);
			XmlSchemaSimpleContentExtension.NativeMethodInfoPtr_get_AnyAttribute_Public_get_XmlSchemaAnyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleContentExtension>.NativeClassPtr, 100669051);
			XmlSchemaSimpleContentExtension.NativeMethodInfoPtr_set_AnyAttribute_Public_set_Void_XmlSchemaAnyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleContentExtension>.NativeClassPtr, 100669052);
			XmlSchemaSimpleContentExtension.NativeMethodInfoPtr_SetAttributes_Internal_Void_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleContentExtension>.NativeClassPtr, 100669053);
			XmlSchemaSimpleContentExtension.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaSimpleContentExtension>.NativeClassPtr, 100669054);
		}

		// Token: 0x17000D94 RID: 3476
		// (get) Token: 0x060027B9 RID: 10169 RVA: 0x000B9470 File Offset: 0x000B7670
		// (set) Token: 0x060027BA RID: 10170 RVA: 0x000B94B0 File Offset: 0x000B76B0
		public unsafe XmlQualifiedName BaseTypeName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleContentExtension.NativeMethodInfoPtr_get_BaseTypeName_Public_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 414538, RefRangeEnd = 414546, XrefRangeStart = 414529, XrefRangeEnd = 414538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleContentExtension.NativeMethodInfoPtr_set_BaseTypeName_Public_set_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D95 RID: 3477
		// (get) Token: 0x060027BB RID: 10171 RVA: 0x000B94F4 File Offset: 0x000B76F4
		public unsafe XmlSchemaObjectCollection Attributes
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleContentExtension.NativeMethodInfoPtr_get_Attributes_Public_get_XmlSchemaObjectCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000D96 RID: 3478
		// (get) Token: 0x060027BC RID: 10172 RVA: 0x000B9534 File Offset: 0x000B7734
		// (set) Token: 0x060027BD RID: 10173 RVA: 0x000B9574 File Offset: 0x000B7774
		public unsafe XmlSchemaAnyAttribute AnyAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleContentExtension.NativeMethodInfoPtr_get_AnyAttribute_Public_get_XmlSchemaAnyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleContentExtension.NativeMethodInfoPtr_set_AnyAttribute_Public_set_Void_XmlSchemaAnyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060027BE RID: 10174 RVA: 0x000B95B8 File Offset: 0x000B77B8
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleContentExtension.NativeMethodInfoPtr_SetAttributes_Internal_Void_XmlSchemaObjectCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060027BF RID: 10175 RVA: 0x000B95FC File Offset: 0x000B77FC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 414557, RefRangeEnd = 414561, XrefRangeStart = 414546, XrefRangeEnd = 414557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaSimpleContentExtension()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaSimpleContentExtension>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaSimpleContentExtension.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027C0 RID: 10176 RVA: 0x00010CF9 File Offset: 0x0000EEF9
		public XmlSchemaSimpleContentExtension(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D91 RID: 3473
		// (get) Token: 0x060027C1 RID: 10177 RVA: 0x000B9638 File Offset: 0x000B7838
		// (set) Token: 0x060027C2 RID: 10178 RVA: 0x00010D02 File Offset: 0x0000EF02
		public unsafe XmlSchemaObjectCollection attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleContentExtension.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleContentExtension.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D92 RID: 3474
		// (get) Token: 0x060027C3 RID: 10179 RVA: 0x000B9668 File Offset: 0x000B7868
		// (set) Token: 0x060027C4 RID: 10180 RVA: 0x00010D21 File Offset: 0x0000EF21
		public unsafe XmlSchemaAnyAttribute anyAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleContentExtension.NativeFieldInfoPtr_anyAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaAnyAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleContentExtension.NativeFieldInfoPtr_anyAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D93 RID: 3475
		// (get) Token: 0x060027C5 RID: 10181 RVA: 0x000B9698 File Offset: 0x000B7898
		// (set) Token: 0x060027C6 RID: 10182 RVA: 0x00010D40 File Offset: 0x0000EF40
		public unsafe XmlQualifiedName baseTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleContentExtension.NativeFieldInfoPtr_baseTypeName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaSimpleContentExtension.NativeFieldInfoPtr_baseTypeName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001DF6 RID: 7670
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x04001DF7 RID: 7671
		private static readonly IntPtr NativeFieldInfoPtr_anyAttribute;

		// Token: 0x04001DF8 RID: 7672
		private static readonly IntPtr NativeFieldInfoPtr_baseTypeName;

		// Token: 0x04001DF9 RID: 7673
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseTypeName_Public_get_XmlQualifiedName_0;

		// Token: 0x04001DFA RID: 7674
		private static readonly IntPtr NativeMethodInfoPtr_set_BaseTypeName_Public_set_Void_XmlQualifiedName_0;

		// Token: 0x04001DFB RID: 7675
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_get_XmlSchemaObjectCollection_0;

		// Token: 0x04001DFC RID: 7676
		private static readonly IntPtr NativeMethodInfoPtr_get_AnyAttribute_Public_get_XmlSchemaAnyAttribute_0;

		// Token: 0x04001DFD RID: 7677
		private static readonly IntPtr NativeMethodInfoPtr_set_AnyAttribute_Public_set_Void_XmlSchemaAnyAttribute_0;

		// Token: 0x04001DFE RID: 7678
		private static readonly IntPtr NativeMethodInfoPtr_SetAttributes_Internal_Void_XmlSchemaObjectCollection_0;

		// Token: 0x04001DFF RID: 7679
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
