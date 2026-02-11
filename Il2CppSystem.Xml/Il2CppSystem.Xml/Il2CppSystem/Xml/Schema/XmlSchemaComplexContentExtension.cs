using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001A6 RID: 422
	public class XmlSchemaComplexContentExtension : XmlSchemaContent
	{
		// Token: 0x060024B2 RID: 9394 RVA: 0x000AD9D4 File Offset: 0x000ABBD4
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaComplexContentExtension()
		{
			Il2CppClassPointerStore<XmlSchemaComplexContentExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaComplexContentExtension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaComplexContentExtension>.NativeClassPtr);
			XmlSchemaComplexContentExtension.NativeFieldInfoPtr_particle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexContentExtension>.NativeClassPtr, "particle");
			XmlSchemaComplexContentExtension.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexContentExtension>.NativeClassPtr, "attributes");
			XmlSchemaComplexContentExtension.NativeFieldInfoPtr_anyAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexContentExtension>.NativeClassPtr, "anyAttribute");
			XmlSchemaComplexContentExtension.NativeFieldInfoPtr_baseTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexContentExtension>.NativeClassPtr, "baseTypeName");
			XmlSchemaComplexContentExtension.NativeMethodInfoPtr_get_BaseTypeName_Public_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexContentExtension>.NativeClassPtr, 100668612);
			XmlSchemaComplexContentExtension.NativeMethodInfoPtr_set_BaseTypeName_Public_set_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexContentExtension>.NativeClassPtr, 100668613);
			XmlSchemaComplexContentExtension.NativeMethodInfoPtr_get_Particle_Public_get_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexContentExtension>.NativeClassPtr, 100668614);
			XmlSchemaComplexContentExtension.NativeMethodInfoPtr_set_Particle_Public_set_Void_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexContentExtension>.NativeClassPtr, 100668615);
			XmlSchemaComplexContentExtension.NativeMethodInfoPtr_get_Attributes_Public_get_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexContentExtension>.NativeClassPtr, 100668616);
			XmlSchemaComplexContentExtension.NativeMethodInfoPtr_get_AnyAttribute_Public_get_XmlSchemaAnyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexContentExtension>.NativeClassPtr, 100668617);
			XmlSchemaComplexContentExtension.NativeMethodInfoPtr_set_AnyAttribute_Public_set_Void_XmlSchemaAnyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexContentExtension>.NativeClassPtr, 100668618);
			XmlSchemaComplexContentExtension.NativeMethodInfoPtr_SetAttributes_Internal_Void_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexContentExtension>.NativeClassPtr, 100668619);
			XmlSchemaComplexContentExtension.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexContentExtension>.NativeClassPtr, 100668620);
		}

		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x060024B3 RID: 9395 RVA: 0x000ADB08 File Offset: 0x000ABD08
		// (set) Token: 0x060024B4 RID: 9396 RVA: 0x000ADB48 File Offset: 0x000ABD48
		public unsafe XmlQualifiedName BaseTypeName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexContentExtension.NativeMethodInfoPtr_get_BaseTypeName_Public_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 411258, RefRangeEnd = 411259, XrefRangeStart = 411249, XrefRangeEnd = 411258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexContentExtension.NativeMethodInfoPtr_set_BaseTypeName_Public_set_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x060024B5 RID: 9397 RVA: 0x000ADB8C File Offset: 0x000ABD8C
		// (set) Token: 0x060024B6 RID: 9398 RVA: 0x000ADBCC File Offset: 0x000ABDCC
		public unsafe XmlSchemaParticle Particle
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexContentExtension.NativeMethodInfoPtr_get_Particle_Public_get_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexContentExtension.NativeMethodInfoPtr_set_Particle_Public_set_Void_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x060024B7 RID: 9399 RVA: 0x000ADC10 File Offset: 0x000ABE10
		public unsafe XmlSchemaObjectCollection Attributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexContentExtension.NativeMethodInfoPtr_get_Attributes_Public_get_XmlSchemaObjectCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x060024B8 RID: 9400 RVA: 0x000ADC50 File Offset: 0x000ABE50
		// (set) Token: 0x060024B9 RID: 9401 RVA: 0x000ADC90 File Offset: 0x000ABE90
		public unsafe XmlSchemaAnyAttribute AnyAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexContentExtension.NativeMethodInfoPtr_get_AnyAttribute_Public_get_XmlSchemaAnyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexContentExtension.NativeMethodInfoPtr_set_AnyAttribute_Public_set_Void_XmlSchemaAnyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060024BA RID: 9402 RVA: 0x000ADCD4 File Offset: 0x000ABED4
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexContentExtension.NativeMethodInfoPtr_SetAttributes_Internal_Void_XmlSchemaObjectCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024BB RID: 9403 RVA: 0x000ADD18 File Offset: 0x000ABF18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 411270, RefRangeEnd = 411271, XrefRangeStart = 411259, XrefRangeEnd = 411270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaComplexContentExtension()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaComplexContentExtension>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexContentExtension.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024BC RID: 9404 RVA: 0x0000F857 File Offset: 0x0000DA57
		public XmlSchemaComplexContentExtension(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x060024BD RID: 9405 RVA: 0x000ADD54 File Offset: 0x000ABF54
		// (set) Token: 0x060024BE RID: 9406 RVA: 0x0000F860 File Offset: 0x0000DA60
		public unsafe XmlSchemaParticle particle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexContentExtension.NativeFieldInfoPtr_particle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexContentExtension.NativeFieldInfoPtr_particle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x060024BF RID: 9407 RVA: 0x000ADD84 File Offset: 0x000ABF84
		// (set) Token: 0x060024C0 RID: 9408 RVA: 0x0000F87F File Offset: 0x0000DA7F
		public unsafe XmlSchemaObjectCollection attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexContentExtension.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexContentExtension.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x060024C1 RID: 9409 RVA: 0x000ADDB4 File Offset: 0x000ABFB4
		// (set) Token: 0x060024C2 RID: 9410 RVA: 0x0000F89E File Offset: 0x0000DA9E
		public unsafe XmlSchemaAnyAttribute anyAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexContentExtension.NativeFieldInfoPtr_anyAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaAnyAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexContentExtension.NativeFieldInfoPtr_anyAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x060024C3 RID: 9411 RVA: 0x000ADDE4 File Offset: 0x000ABFE4
		// (set) Token: 0x060024C4 RID: 9412 RVA: 0x0000F8BD File Offset: 0x0000DABD
		public unsafe XmlQualifiedName baseTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexContentExtension.NativeFieldInfoPtr_baseTypeName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexContentExtension.NativeFieldInfoPtr_baseTypeName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001BAB RID: 7083
		private static readonly IntPtr NativeFieldInfoPtr_particle;

		// Token: 0x04001BAC RID: 7084
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x04001BAD RID: 7085
		private static readonly IntPtr NativeFieldInfoPtr_anyAttribute;

		// Token: 0x04001BAE RID: 7086
		private static readonly IntPtr NativeFieldInfoPtr_baseTypeName;

		// Token: 0x04001BAF RID: 7087
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseTypeName_Public_get_XmlQualifiedName_0;

		// Token: 0x04001BB0 RID: 7088
		private static readonly IntPtr NativeMethodInfoPtr_set_BaseTypeName_Public_set_Void_XmlQualifiedName_0;

		// Token: 0x04001BB1 RID: 7089
		private static readonly IntPtr NativeMethodInfoPtr_get_Particle_Public_get_XmlSchemaParticle_0;

		// Token: 0x04001BB2 RID: 7090
		private static readonly IntPtr NativeMethodInfoPtr_set_Particle_Public_set_Void_XmlSchemaParticle_0;

		// Token: 0x04001BB3 RID: 7091
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_get_XmlSchemaObjectCollection_0;

		// Token: 0x04001BB4 RID: 7092
		private static readonly IntPtr NativeMethodInfoPtr_get_AnyAttribute_Public_get_XmlSchemaAnyAttribute_0;

		// Token: 0x04001BB5 RID: 7093
		private static readonly IntPtr NativeMethodInfoPtr_set_AnyAttribute_Public_set_Void_XmlSchemaAnyAttribute_0;

		// Token: 0x04001BB6 RID: 7094
		private static readonly IntPtr NativeMethodInfoPtr_SetAttributes_Internal_Void_XmlSchemaObjectCollection_0;

		// Token: 0x04001BB7 RID: 7095
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
