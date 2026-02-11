using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001A7 RID: 423
	public class XmlSchemaComplexContentRestriction : XmlSchemaContent
	{
		// Token: 0x060024C5 RID: 9413 RVA: 0x000ADE14 File Offset: 0x000AC014
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaComplexContentRestriction()
		{
			Il2CppClassPointerStore<XmlSchemaComplexContentRestriction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaComplexContentRestriction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaComplexContentRestriction>.NativeClassPtr);
			XmlSchemaComplexContentRestriction.NativeFieldInfoPtr_particle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexContentRestriction>.NativeClassPtr, "particle");
			XmlSchemaComplexContentRestriction.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexContentRestriction>.NativeClassPtr, "attributes");
			XmlSchemaComplexContentRestriction.NativeFieldInfoPtr_anyAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexContentRestriction>.NativeClassPtr, "anyAttribute");
			XmlSchemaComplexContentRestriction.NativeFieldInfoPtr_baseTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexContentRestriction>.NativeClassPtr, "baseTypeName");
			XmlSchemaComplexContentRestriction.NativeMethodInfoPtr_get_BaseTypeName_Public_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexContentRestriction>.NativeClassPtr, 100668621);
			XmlSchemaComplexContentRestriction.NativeMethodInfoPtr_set_BaseTypeName_Public_set_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexContentRestriction>.NativeClassPtr, 100668622);
			XmlSchemaComplexContentRestriction.NativeMethodInfoPtr_get_Particle_Public_get_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexContentRestriction>.NativeClassPtr, 100668623);
			XmlSchemaComplexContentRestriction.NativeMethodInfoPtr_set_Particle_Public_set_Void_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexContentRestriction>.NativeClassPtr, 100668624);
			XmlSchemaComplexContentRestriction.NativeMethodInfoPtr_get_Attributes_Public_get_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexContentRestriction>.NativeClassPtr, 100668625);
			XmlSchemaComplexContentRestriction.NativeMethodInfoPtr_get_AnyAttribute_Public_get_XmlSchemaAnyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexContentRestriction>.NativeClassPtr, 100668626);
			XmlSchemaComplexContentRestriction.NativeMethodInfoPtr_set_AnyAttribute_Public_set_Void_XmlSchemaAnyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexContentRestriction>.NativeClassPtr, 100668627);
			XmlSchemaComplexContentRestriction.NativeMethodInfoPtr_SetAttributes_Internal_Void_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexContentRestriction>.NativeClassPtr, 100668628);
			XmlSchemaComplexContentRestriction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexContentRestriction>.NativeClassPtr, 100668629);
		}

		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x060024C6 RID: 9414 RVA: 0x000ADF48 File Offset: 0x000AC148
		// (set) Token: 0x060024C7 RID: 9415 RVA: 0x000ADF88 File Offset: 0x000AC188
		public unsafe XmlQualifiedName BaseTypeName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexContentRestriction.NativeMethodInfoPtr_get_BaseTypeName_Public_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 411280, RefRangeEnd = 411281, XrefRangeStart = 411271, XrefRangeEnd = 411280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexContentRestriction.NativeMethodInfoPtr_set_BaseTypeName_Public_set_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x060024C8 RID: 9416 RVA: 0x000ADFCC File Offset: 0x000AC1CC
		// (set) Token: 0x060024C9 RID: 9417 RVA: 0x000AE00C File Offset: 0x000AC20C
		public unsafe XmlSchemaParticle Particle
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexContentRestriction.NativeMethodInfoPtr_get_Particle_Public_get_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexContentRestriction.NativeMethodInfoPtr_set_Particle_Public_set_Void_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x060024CA RID: 9418 RVA: 0x000AE050 File Offset: 0x000AC250
		public unsafe XmlSchemaObjectCollection Attributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexContentRestriction.NativeMethodInfoPtr_get_Attributes_Public_get_XmlSchemaObjectCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x060024CB RID: 9419 RVA: 0x000AE090 File Offset: 0x000AC290
		// (set) Token: 0x060024CC RID: 9420 RVA: 0x000AE0D0 File Offset: 0x000AC2D0
		public unsafe XmlSchemaAnyAttribute AnyAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexContentRestriction.NativeMethodInfoPtr_get_AnyAttribute_Public_get_XmlSchemaAnyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexContentRestriction.NativeMethodInfoPtr_set_AnyAttribute_Public_set_Void_XmlSchemaAnyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060024CD RID: 9421 RVA: 0x000AE114 File Offset: 0x000AC314
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexContentRestriction.NativeMethodInfoPtr_SetAttributes_Internal_Void_XmlSchemaObjectCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024CE RID: 9422 RVA: 0x000AE158 File Offset: 0x000AC358
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 411292, RefRangeEnd = 411293, XrefRangeStart = 411281, XrefRangeEnd = 411292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaComplexContentRestriction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaComplexContentRestriction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexContentRestriction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024CF RID: 9423 RVA: 0x0000F8DC File Offset: 0x0000DADC
		public XmlSchemaComplexContentRestriction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x060024D0 RID: 9424 RVA: 0x000AE194 File Offset: 0x000AC394
		// (set) Token: 0x060024D1 RID: 9425 RVA: 0x0000F8E5 File Offset: 0x0000DAE5
		public unsafe XmlSchemaParticle particle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexContentRestriction.NativeFieldInfoPtr_particle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexContentRestriction.NativeFieldInfoPtr_particle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x060024D2 RID: 9426 RVA: 0x000AE1C4 File Offset: 0x000AC3C4
		// (set) Token: 0x060024D3 RID: 9427 RVA: 0x0000F904 File Offset: 0x0000DB04
		public unsafe XmlSchemaObjectCollection attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexContentRestriction.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexContentRestriction.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x060024D4 RID: 9428 RVA: 0x000AE1F4 File Offset: 0x000AC3F4
		// (set) Token: 0x060024D5 RID: 9429 RVA: 0x0000F923 File Offset: 0x0000DB23
		public unsafe XmlSchemaAnyAttribute anyAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexContentRestriction.NativeFieldInfoPtr_anyAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaAnyAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexContentRestriction.NativeFieldInfoPtr_anyAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x060024D6 RID: 9430 RVA: 0x000AE224 File Offset: 0x000AC424
		// (set) Token: 0x060024D7 RID: 9431 RVA: 0x0000F942 File Offset: 0x0000DB42
		public unsafe XmlQualifiedName baseTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexContentRestriction.NativeFieldInfoPtr_baseTypeName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexContentRestriction.NativeFieldInfoPtr_baseTypeName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001BB8 RID: 7096
		private static readonly IntPtr NativeFieldInfoPtr_particle;

		// Token: 0x04001BB9 RID: 7097
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x04001BBA RID: 7098
		private static readonly IntPtr NativeFieldInfoPtr_anyAttribute;

		// Token: 0x04001BBB RID: 7099
		private static readonly IntPtr NativeFieldInfoPtr_baseTypeName;

		// Token: 0x04001BBC RID: 7100
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseTypeName_Public_get_XmlQualifiedName_0;

		// Token: 0x04001BBD RID: 7101
		private static readonly IntPtr NativeMethodInfoPtr_set_BaseTypeName_Public_set_Void_XmlQualifiedName_0;

		// Token: 0x04001BBE RID: 7102
		private static readonly IntPtr NativeMethodInfoPtr_get_Particle_Public_get_XmlSchemaParticle_0;

		// Token: 0x04001BBF RID: 7103
		private static readonly IntPtr NativeMethodInfoPtr_set_Particle_Public_set_Void_XmlSchemaParticle_0;

		// Token: 0x04001BC0 RID: 7104
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_get_XmlSchemaObjectCollection_0;

		// Token: 0x04001BC1 RID: 7105
		private static readonly IntPtr NativeMethodInfoPtr_get_AnyAttribute_Public_get_XmlSchemaAnyAttribute_0;

		// Token: 0x04001BC2 RID: 7106
		private static readonly IntPtr NativeMethodInfoPtr_set_AnyAttribute_Public_set_Void_XmlSchemaAnyAttribute_0;

		// Token: 0x04001BC3 RID: 7107
		private static readonly IntPtr NativeMethodInfoPtr_SetAttributes_Internal_Void_XmlSchemaObjectCollection_0;

		// Token: 0x04001BC4 RID: 7108
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
