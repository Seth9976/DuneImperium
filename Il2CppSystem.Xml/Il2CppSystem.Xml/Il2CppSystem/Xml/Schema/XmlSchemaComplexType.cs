using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001A8 RID: 424
	public class XmlSchemaComplexType : XmlSchemaType
	{
		// Token: 0x060024D8 RID: 9432 RVA: 0x000AE254 File Offset: 0x000AC454
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaComplexType()
		{
			Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaComplexType");
			XmlSchemaComplexType.NativeFieldInfoPtr_block = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, "block");
			XmlSchemaComplexType.NativeFieldInfoPtr_contentModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, "contentModel");
			XmlSchemaComplexType.NativeFieldInfoPtr_particle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, "particle");
			XmlSchemaComplexType.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, "attributes");
			XmlSchemaComplexType.NativeFieldInfoPtr_anyAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, "anyAttribute");
			XmlSchemaComplexType.NativeFieldInfoPtr_contentTypeParticle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, "contentTypeParticle");
			XmlSchemaComplexType.NativeFieldInfoPtr_blockResolved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, "blockResolved");
			XmlSchemaComplexType.NativeFieldInfoPtr_localElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, "localElements");
			XmlSchemaComplexType.NativeFieldInfoPtr_attributeUses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, "attributeUses");
			XmlSchemaComplexType.NativeFieldInfoPtr_attributeWildcard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, "attributeWildcard");
			XmlSchemaComplexType.NativeFieldInfoPtr_anyTypeLax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, "anyTypeLax");
			XmlSchemaComplexType.NativeFieldInfoPtr_anyTypeSkip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, "anyTypeSkip");
			XmlSchemaComplexType.NativeFieldInfoPtr_untypedAnyType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, "untypedAnyType");
			XmlSchemaComplexType.NativeFieldInfoPtr_pvFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, "pvFlags");
			XmlSchemaComplexType.NativeMethodInfoPtr_CreateAnyType_Private_Static_XmlSchemaComplexType_XmlSchemaContentProcessing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668631);
			XmlSchemaComplexType.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668632);
			XmlSchemaComplexType.NativeMethodInfoPtr_get_AnyType_Internal_Static_get_XmlSchemaComplexType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668633);
			XmlSchemaComplexType.NativeMethodInfoPtr_get_UntypedAnyType_Internal_Static_get_XmlSchemaComplexType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668634);
			XmlSchemaComplexType.NativeMethodInfoPtr_get_AnyTypeContentValidator_Internal_Static_get_ContentValidator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668635);
			XmlSchemaComplexType.NativeMethodInfoPtr_get_IsAbstract_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668636);
			XmlSchemaComplexType.NativeMethodInfoPtr_set_IsAbstract_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668637);
			XmlSchemaComplexType.NativeMethodInfoPtr_get_Block_Public_get_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668638);
			XmlSchemaComplexType.NativeMethodInfoPtr_set_Block_Public_set_Void_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668639);
			XmlSchemaComplexType.NativeMethodInfoPtr_get_IsMixed_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668640);
			XmlSchemaComplexType.NativeMethodInfoPtr_set_IsMixed_Public_Virtual_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668641);
			XmlSchemaComplexType.NativeMethodInfoPtr_get_ContentModel_Public_get_XmlSchemaContentModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668642);
			XmlSchemaComplexType.NativeMethodInfoPtr_set_ContentModel_Public_set_Void_XmlSchemaContentModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668643);
			XmlSchemaComplexType.NativeMethodInfoPtr_get_Particle_Public_get_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668644);
			XmlSchemaComplexType.NativeMethodInfoPtr_set_Particle_Public_set_Void_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668645);
			XmlSchemaComplexType.NativeMethodInfoPtr_get_Attributes_Public_get_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668646);
			XmlSchemaComplexType.NativeMethodInfoPtr_get_AnyAttribute_Public_get_XmlSchemaAnyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668647);
			XmlSchemaComplexType.NativeMethodInfoPtr_set_AnyAttribute_Public_set_Void_XmlSchemaAnyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668648);
			XmlSchemaComplexType.NativeMethodInfoPtr_get_ContentType_Public_get_XmlSchemaContentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668649);
			XmlSchemaComplexType.NativeMethodInfoPtr_get_ContentTypeParticle_Public_get_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668650);
			XmlSchemaComplexType.NativeMethodInfoPtr_get_BlockResolved_Public_get_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668651);
			XmlSchemaComplexType.NativeMethodInfoPtr_get_AttributeUses_Public_get_XmlSchemaObjectTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668652);
			XmlSchemaComplexType.NativeMethodInfoPtr_get_AttributeWildcard_Public_get_XmlSchemaAnyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668653);
			XmlSchemaComplexType.NativeMethodInfoPtr_get_LocalElements_Internal_get_XmlSchemaObjectTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668654);
			XmlSchemaComplexType.NativeMethodInfoPtr_SetContentTypeParticle_Internal_Void_XmlSchemaParticle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668655);
			XmlSchemaComplexType.NativeMethodInfoPtr_SetBlockResolved_Internal_Void_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668656);
			XmlSchemaComplexType.NativeMethodInfoPtr_SetAttributeWildcard_Internal_Void_XmlSchemaAnyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668657);
			XmlSchemaComplexType.NativeMethodInfoPtr_set_HasWildCard_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668658);
			XmlSchemaComplexType.NativeMethodInfoPtr_SetAttributes_Internal_Void_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668659);
			XmlSchemaComplexType.NativeMethodInfoPtr_ContainsIdAttribute_Internal_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668660);
			XmlSchemaComplexType.NativeMethodInfoPtr_Clone_Internal_Virtual_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668661);
			XmlSchemaComplexType.NativeMethodInfoPtr_Clone_Internal_XmlSchemaObject_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668662);
			XmlSchemaComplexType.NativeMethodInfoPtr_ClearCompiledState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668663);
			XmlSchemaComplexType.NativeMethodInfoPtr_CloneAttributes_Internal_Static_XmlSchemaObjectCollection_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668664);
			XmlSchemaComplexType.NativeMethodInfoPtr_CloneGroupBaseParticles_Private_Static_XmlSchemaObjectCollection_XmlSchemaObjectCollection_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668665);
			XmlSchemaComplexType.NativeMethodInfoPtr_CloneParticle_Internal_Static_XmlSchemaParticle_XmlSchemaParticle_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668666);
			XmlSchemaComplexType.NativeMethodInfoPtr_GetResolvedElementForm_Private_Static_XmlSchemaForm_XmlSchema_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668667);
			XmlSchemaComplexType.NativeMethodInfoPtr_HasParticleRef_Internal_Static_Boolean_XmlSchemaParticle_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668668);
			XmlSchemaComplexType.NativeMethodInfoPtr_HasAttributeQNameRef_Internal_Static_Boolean_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr, 100668669);
		}

		// Token: 0x060024D9 RID: 9433 RVA: 0x000AE6A0 File Offset: 0x000AC8A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 411293, XrefRangeEnd = 411367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSchemaComplexType CreateAnyType(XmlSchemaContentProcessing processContents)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref processContents;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_CreateAnyType_Private_Static_XmlSchemaComplexType_XmlSchemaContentProcessing_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaComplexType>(intPtr3) : null;
			}
		}

		// Token: 0x060024DA RID: 9434 RVA: 0x000AE6E0 File Offset: 0x000AC8E0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 411373, RefRangeEnd = 411379, XrefRangeStart = 411367, XrefRangeEnd = 411373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaComplexType()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaComplexType>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x060024DB RID: 9435 RVA: 0x000AE71C File Offset: 0x000AC91C
		public unsafe static XmlSchemaComplexType AnyType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 411379, XrefRangeEnd = 411383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_get_AnyType_Internal_Static_get_XmlSchemaComplexType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaComplexType>(intPtr3) : null;
			}
		}

		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x060024DC RID: 9436 RVA: 0x000AE750 File Offset: 0x000AC950
		public unsafe static XmlSchemaComplexType UntypedAnyType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 411383, XrefRangeEnd = 411387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_get_UntypedAnyType_Internal_Static_get_XmlSchemaComplexType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaComplexType>(intPtr3) : null;
			}
		}

		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x060024DD RID: 9437 RVA: 0x000AE784 File Offset: 0x000AC984
		public unsafe static ContentValidator AnyTypeContentValidator
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 411387, XrefRangeEnd = 411392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_get_AnyTypeContentValidator_Internal_Static_get_ContentValidator_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContentValidator>(intPtr3) : null;
			}
		}

		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x060024DE RID: 9438 RVA: 0x000AE7B8 File Offset: 0x000AC9B8
		// (set) Token: 0x060024DF RID: 9439 RVA: 0x000AE7F4 File Offset: 0x000AC9F4
		public unsafe bool IsAbstract
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 411392, RefRangeEnd = 411397, XrefRangeStart = 411392, XrefRangeEnd = 411392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_get_IsAbstract_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 411397, RefRangeEnd = 411398, XrefRangeStart = 411397, XrefRangeEnd = 411397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_set_IsAbstract_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x060024E0 RID: 9440 RVA: 0x000AE834 File Offset: 0x000ACA34
		// (set) Token: 0x060024E1 RID: 9441 RVA: 0x000AE870 File Offset: 0x000ACA70
		public unsafe XmlSchemaDerivationMethod Block
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_get_Block_Public_get_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_set_Block_Public_set_Void_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x060024E2 RID: 9442 RVA: 0x000AE8B0 File Offset: 0x000ACAB0
		// (set) Token: 0x060024E3 RID: 9443 RVA: 0x000AE8F8 File Offset: 0x000ACAF8
		public unsafe override bool IsMixed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaComplexType.NativeMethodInfoPtr_get_IsMixed_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaComplexType.NativeMethodInfoPtr_set_IsMixed_Public_Virtual_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x060024E4 RID: 9444 RVA: 0x000AE944 File Offset: 0x000ACB44
		// (set) Token: 0x060024E5 RID: 9445 RVA: 0x000AE984 File Offset: 0x000ACB84
		public unsafe XmlSchemaContentModel ContentModel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_get_ContentModel_Public_get_XmlSchemaContentModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaContentModel>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_set_ContentModel_Public_set_Void_XmlSchemaContentModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x060024E6 RID: 9446 RVA: 0x000AE9C8 File Offset: 0x000ACBC8
		// (set) Token: 0x060024E7 RID: 9447 RVA: 0x000AEA08 File Offset: 0x000ACC08
		public unsafe XmlSchemaParticle Particle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_get_Particle_Public_get_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_set_Particle_Public_set_Void_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x060024E8 RID: 9448 RVA: 0x000AEA4C File Offset: 0x000ACC4C
		public unsafe XmlSchemaObjectCollection Attributes
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 411403, RefRangeEnd = 411424, XrefRangeStart = 411398, XrefRangeEnd = 411403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_get_Attributes_Public_get_XmlSchemaObjectCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x060024E9 RID: 9449 RVA: 0x000AEA8C File Offset: 0x000ACC8C
		// (set) Token: 0x060024EA RID: 9450 RVA: 0x000AEACC File Offset: 0x000ACCCC
		public unsafe XmlSchemaAnyAttribute AnyAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_get_AnyAttribute_Public_get_XmlSchemaAnyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_set_AnyAttribute_Public_set_Void_XmlSchemaAnyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x060024EB RID: 9451 RVA: 0x000AEB10 File Offset: 0x000ACD10
		public unsafe XmlSchemaContentType ContentType
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 311826, RefRangeEnd = 311839, XrefRangeStart = 311826, XrefRangeEnd = 311839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_get_ContentType_Public_get_XmlSchemaContentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x060024EC RID: 9452 RVA: 0x000AEB4C File Offset: 0x000ACD4C
		public unsafe XmlSchemaParticle ContentTypeParticle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_get_ContentTypeParticle_Public_get_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr3) : null;
			}
		}

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x060024ED RID: 9453 RVA: 0x000AEB8C File Offset: 0x000ACD8C
		public unsafe XmlSchemaDerivationMethod BlockResolved
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_get_BlockResolved_Public_get_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x060024EE RID: 9454 RVA: 0x000AEBC8 File Offset: 0x000ACDC8
		public unsafe XmlSchemaObjectTable AttributeUses
		{
			[CallerCount(32)]
			[CachedScanResults(RefRangeStart = 411429, RefRangeEnd = 411461, XrefRangeStart = 411424, XrefRangeEnd = 411429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_get_AttributeUses_Public_get_XmlSchemaObjectTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr3) : null;
			}
		}

		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x060024EF RID: 9455 RVA: 0x000AEC08 File Offset: 0x000ACE08
		public unsafe XmlSchemaAnyAttribute AttributeWildcard
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_get_AttributeWildcard_Public_get_XmlSchemaAnyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaAnyAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x060024F0 RID: 9456 RVA: 0x000AEC48 File Offset: 0x000ACE48
		public unsafe XmlSchemaObjectTable LocalElements
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 411466, RefRangeEnd = 411473, XrefRangeStart = 411461, XrefRangeEnd = 411466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_get_LocalElements_Internal_get_XmlSchemaObjectTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr3) : null;
			}
		}

		// Token: 0x060024F1 RID: 9457 RVA: 0x000AEC88 File Offset: 0x000ACE88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetContentTypeParticle(XmlSchemaParticle value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_SetContentTypeParticle_Internal_Void_XmlSchemaParticle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024F2 RID: 9458 RVA: 0x000AECCC File Offset: 0x000ACECC
		[CallerCount(0)]
		public unsafe void SetBlockResolved(XmlSchemaDerivationMethod value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_SetBlockResolved_Internal_Void_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024F3 RID: 9459 RVA: 0x000AED0C File Offset: 0x000ACF0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAttributeWildcard(XmlSchemaAnyAttribute value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_SetAttributeWildcard_Internal_Void_XmlSchemaAnyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C9C RID: 3228
		// (set) Token: 0x060024F4 RID: 9460 RVA: 0x000AED50 File Offset: 0x000ACF50
		public unsafe bool HasWildCard
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 411473, RefRangeEnd = 411474, XrefRangeStart = 411473, XrefRangeEnd = 411473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_set_HasWildCard_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060024F5 RID: 9461 RVA: 0x000AED90 File Offset: 0x000ACF90
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_SetAttributes_Internal_Void_XmlSchemaObjectCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024F6 RID: 9462 RVA: 0x000AEDD4 File Offset: 0x000ACFD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 411499, RefRangeEnd = 411501, XrefRangeStart = 411474, XrefRangeEnd = 411499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsIdAttribute(bool findAll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref findAll;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_ContainsIdAttribute_Internal_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060024F7 RID: 9463 RVA: 0x000AEE20 File Offset: 0x000AD020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 411501, XrefRangeEnd = 411502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XmlSchemaObject Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaComplexType.NativeMethodInfoPtr_Clone_Internal_Virtual_XmlSchemaObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObject>(intPtr3) : null;
		}

		// Token: 0x060024F8 RID: 9464 RVA: 0x000AEE6C File Offset: 0x000AD06C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 411596, RefRangeEnd = 411599, XrefRangeStart = 411502, XrefRangeEnd = 411596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaObject Clone(XmlSchema parentSchema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentSchema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_Clone_Internal_XmlSchemaObject_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObject>(intPtr3) : null;
			}
		}

		// Token: 0x060024F9 RID: 9465 RVA: 0x000AEEBC File Offset: 0x000AD0BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 411599, XrefRangeEnd = 411607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearCompiledState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_ClearCompiledState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024FA RID: 9466 RVA: 0x000AEEF0 File Offset: 0x000AD0F0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 411613, RefRangeEnd = 411619, XrefRangeStart = 411607, XrefRangeEnd = 411613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSchemaObjectCollection CloneAttributes(XmlSchemaObjectCollection attributes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_CloneAttributes_Internal_Static_XmlSchemaObjectCollection_XmlSchemaObjectCollection_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr3) : null;
			}
		}

		// Token: 0x060024FB RID: 9467 RVA: 0x000AEF34 File Offset: 0x000AD134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 411619, XrefRangeEnd = 411628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSchemaObjectCollection CloneGroupBaseParticles(XmlSchemaObjectCollection groupBaseParticles, XmlSchema parentSchema)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(groupBaseParticles);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentSchema);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_CloneGroupBaseParticles_Private_Static_XmlSchemaObjectCollection_XmlSchemaObjectCollection_XmlSchema_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr3) : null;
		}

		// Token: 0x060024FC RID: 9468 RVA: 0x000AEF8C File Offset: 0x000AD18C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 411645, RefRangeEnd = 411649, XrefRangeStart = 411628, XrefRangeEnd = 411645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSchemaParticle CloneParticle(XmlSchemaParticle particle, XmlSchema parentSchema)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentSchema);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_CloneParticle_Internal_Static_XmlSchemaParticle_XmlSchemaParticle_XmlSchema_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr3) : null;
		}

		// Token: 0x060024FD RID: 9469 RVA: 0x000AEFE4 File Offset: 0x000AD1E4
		[CallerCount(0)]
		public unsafe static XmlSchemaForm GetResolvedElementForm(XmlSchema parentSchema, XmlSchemaElement element)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentSchema);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(element);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_GetResolvedElementForm_Private_Static_XmlSchemaForm_XmlSchema_XmlSchemaElement_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024FE RID: 9470 RVA: 0x000AF038 File Offset: 0x000AD238
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 411657, RefRangeEnd = 411661, XrefRangeStart = 411649, XrefRangeEnd = 411657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasParticleRef(XmlSchemaParticle particle, XmlSchema parentSchema)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentSchema);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_HasParticleRef_Internal_Static_Boolean_XmlSchemaParticle_XmlSchema_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024FF RID: 9471 RVA: 0x000AF08C File Offset: 0x000AD28C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 411670, RefRangeEnd = 411672, XrefRangeStart = 411661, XrefRangeEnd = 411670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasAttributeQNameRef(XmlSchemaObjectCollection attributes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaComplexType.NativeMethodInfoPtr_HasAttributeQNameRef_Internal_Static_Boolean_XmlSchemaObjectCollection_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002500 RID: 9472 RVA: 0x0000F961 File Offset: 0x0000DB61
		public XmlSchemaComplexType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C7E RID: 3198
		// (get) Token: 0x06002501 RID: 9473 RVA: 0x000AF0D0 File Offset: 0x000AD2D0
		// (set) Token: 0x06002502 RID: 9474 RVA: 0x0000F96A File Offset: 0x0000DB6A
		public unsafe XmlSchemaDerivationMethod block
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_block);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_block)) = value;
			}
		}

		// Token: 0x17000C7F RID: 3199
		// (get) Token: 0x06002503 RID: 9475 RVA: 0x000AF0F8 File Offset: 0x000AD2F8
		// (set) Token: 0x06002504 RID: 9476 RVA: 0x0000F985 File Offset: 0x0000DB85
		public unsafe XmlSchemaContentModel contentModel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_contentModel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaContentModel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_contentModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C80 RID: 3200
		// (get) Token: 0x06002505 RID: 9477 RVA: 0x000AF128 File Offset: 0x000AD328
		// (set) Token: 0x06002506 RID: 9478 RVA: 0x0000F9A4 File Offset: 0x0000DBA4
		public unsafe XmlSchemaParticle particle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_particle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_particle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x06002507 RID: 9479 RVA: 0x000AF158 File Offset: 0x000AD358
		// (set) Token: 0x06002508 RID: 9480 RVA: 0x0000F9C3 File Offset: 0x0000DBC3
		public unsafe XmlSchemaObjectCollection attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x06002509 RID: 9481 RVA: 0x000AF188 File Offset: 0x000AD388
		// (set) Token: 0x0600250A RID: 9482 RVA: 0x0000F9E2 File Offset: 0x0000DBE2
		public unsafe XmlSchemaAnyAttribute anyAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_anyAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaAnyAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_anyAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x0600250B RID: 9483 RVA: 0x000AF1B8 File Offset: 0x000AD3B8
		// (set) Token: 0x0600250C RID: 9484 RVA: 0x0000FA01 File Offset: 0x0000DC01
		public unsafe XmlSchemaParticle contentTypeParticle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_contentTypeParticle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaParticle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_contentTypeParticle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x0600250D RID: 9485 RVA: 0x000AF1E8 File Offset: 0x000AD3E8
		// (set) Token: 0x0600250E RID: 9486 RVA: 0x0000FA20 File Offset: 0x0000DC20
		public unsafe XmlSchemaDerivationMethod blockResolved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_blockResolved);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_blockResolved)) = value;
			}
		}

		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x0600250F RID: 9487 RVA: 0x000AF210 File Offset: 0x000AD410
		// (set) Token: 0x06002510 RID: 9488 RVA: 0x0000FA3B File Offset: 0x0000DC3B
		public unsafe XmlSchemaObjectTable localElements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_localElements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_localElements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x06002511 RID: 9489 RVA: 0x000AF240 File Offset: 0x000AD440
		// (set) Token: 0x06002512 RID: 9490 RVA: 0x0000FA5A File Offset: 0x0000DC5A
		public unsafe XmlSchemaObjectTable attributeUses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_attributeUses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_attributeUses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x06002513 RID: 9491 RVA: 0x000AF270 File Offset: 0x000AD470
		// (set) Token: 0x06002514 RID: 9492 RVA: 0x0000FA79 File Offset: 0x0000DC79
		public unsafe XmlSchemaAnyAttribute attributeWildcard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_attributeWildcard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaAnyAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_attributeWildcard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x06002515 RID: 9493 RVA: 0x000AF2A0 File Offset: 0x000AD4A0
		// (set) Token: 0x06002516 RID: 9494 RVA: 0x0000FA98 File Offset: 0x0000DC98
		public unsafe static XmlSchemaComplexType anyTypeLax
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaComplexType.NativeFieldInfoPtr_anyTypeLax, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaComplexType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaComplexType.NativeFieldInfoPtr_anyTypeLax, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x06002517 RID: 9495 RVA: 0x000AF2C8 File Offset: 0x000AD4C8
		// (set) Token: 0x06002518 RID: 9496 RVA: 0x0000FAAA File Offset: 0x0000DCAA
		public unsafe static XmlSchemaComplexType anyTypeSkip
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaComplexType.NativeFieldInfoPtr_anyTypeSkip, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaComplexType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaComplexType.NativeFieldInfoPtr_anyTypeSkip, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x06002519 RID: 9497 RVA: 0x000AF2F0 File Offset: 0x000AD4F0
		// (set) Token: 0x0600251A RID: 9498 RVA: 0x0000FABC File Offset: 0x0000DCBC
		public unsafe static XmlSchemaComplexType untypedAnyType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaComplexType.NativeFieldInfoPtr_untypedAnyType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaComplexType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaComplexType.NativeFieldInfoPtr_untypedAnyType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x0600251B RID: 9499 RVA: 0x000AF318 File Offset: 0x000AD518
		// (set) Token: 0x0600251C RID: 9500 RVA: 0x0000FACE File Offset: 0x0000DCCE
		public unsafe byte pvFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_pvFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaComplexType.NativeFieldInfoPtr_pvFlags)) = value;
			}
		}

		// Token: 0x04001BC5 RID: 7109
		private static readonly IntPtr NativeFieldInfoPtr_block;

		// Token: 0x04001BC6 RID: 7110
		private static readonly IntPtr NativeFieldInfoPtr_contentModel;

		// Token: 0x04001BC7 RID: 7111
		private static readonly IntPtr NativeFieldInfoPtr_particle;

		// Token: 0x04001BC8 RID: 7112
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x04001BC9 RID: 7113
		private static readonly IntPtr NativeFieldInfoPtr_anyAttribute;

		// Token: 0x04001BCA RID: 7114
		private static readonly IntPtr NativeFieldInfoPtr_contentTypeParticle;

		// Token: 0x04001BCB RID: 7115
		private static readonly IntPtr NativeFieldInfoPtr_blockResolved;

		// Token: 0x04001BCC RID: 7116
		private static readonly IntPtr NativeFieldInfoPtr_localElements;

		// Token: 0x04001BCD RID: 7117
		private static readonly IntPtr NativeFieldInfoPtr_attributeUses;

		// Token: 0x04001BCE RID: 7118
		private static readonly IntPtr NativeFieldInfoPtr_attributeWildcard;

		// Token: 0x04001BCF RID: 7119
		private static readonly IntPtr NativeFieldInfoPtr_anyTypeLax;

		// Token: 0x04001BD0 RID: 7120
		private static readonly IntPtr NativeFieldInfoPtr_anyTypeSkip;

		// Token: 0x04001BD1 RID: 7121
		private static readonly IntPtr NativeFieldInfoPtr_untypedAnyType;

		// Token: 0x04001BD2 RID: 7122
		private static readonly IntPtr NativeFieldInfoPtr_pvFlags;

		// Token: 0x04001BD3 RID: 7123
		private static readonly IntPtr NativeMethodInfoPtr_CreateAnyType_Private_Static_XmlSchemaComplexType_XmlSchemaContentProcessing_0;

		// Token: 0x04001BD4 RID: 7124
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001BD5 RID: 7125
		private static readonly IntPtr NativeMethodInfoPtr_get_AnyType_Internal_Static_get_XmlSchemaComplexType_0;

		// Token: 0x04001BD6 RID: 7126
		private static readonly IntPtr NativeMethodInfoPtr_get_UntypedAnyType_Internal_Static_get_XmlSchemaComplexType_0;

		// Token: 0x04001BD7 RID: 7127
		private static readonly IntPtr NativeMethodInfoPtr_get_AnyTypeContentValidator_Internal_Static_get_ContentValidator_0;

		// Token: 0x04001BD8 RID: 7128
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAbstract_Public_get_Boolean_0;

		// Token: 0x04001BD9 RID: 7129
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAbstract_Public_set_Void_Boolean_0;

		// Token: 0x04001BDA RID: 7130
		private static readonly IntPtr NativeMethodInfoPtr_get_Block_Public_get_XmlSchemaDerivationMethod_0;

		// Token: 0x04001BDB RID: 7131
		private static readonly IntPtr NativeMethodInfoPtr_set_Block_Public_set_Void_XmlSchemaDerivationMethod_0;

		// Token: 0x04001BDC RID: 7132
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMixed_Public_Virtual_get_Boolean_0;

		// Token: 0x04001BDD RID: 7133
		private static readonly IntPtr NativeMethodInfoPtr_set_IsMixed_Public_Virtual_set_Void_Boolean_0;

		// Token: 0x04001BDE RID: 7134
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentModel_Public_get_XmlSchemaContentModel_0;

		// Token: 0x04001BDF RID: 7135
		private static readonly IntPtr NativeMethodInfoPtr_set_ContentModel_Public_set_Void_XmlSchemaContentModel_0;

		// Token: 0x04001BE0 RID: 7136
		private static readonly IntPtr NativeMethodInfoPtr_get_Particle_Public_get_XmlSchemaParticle_0;

		// Token: 0x04001BE1 RID: 7137
		private static readonly IntPtr NativeMethodInfoPtr_set_Particle_Public_set_Void_XmlSchemaParticle_0;

		// Token: 0x04001BE2 RID: 7138
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_get_XmlSchemaObjectCollection_0;

		// Token: 0x04001BE3 RID: 7139
		private static readonly IntPtr NativeMethodInfoPtr_get_AnyAttribute_Public_get_XmlSchemaAnyAttribute_0;

		// Token: 0x04001BE4 RID: 7140
		private static readonly IntPtr NativeMethodInfoPtr_set_AnyAttribute_Public_set_Void_XmlSchemaAnyAttribute_0;

		// Token: 0x04001BE5 RID: 7141
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentType_Public_get_XmlSchemaContentType_0;

		// Token: 0x04001BE6 RID: 7142
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentTypeParticle_Public_get_XmlSchemaParticle_0;

		// Token: 0x04001BE7 RID: 7143
		private static readonly IntPtr NativeMethodInfoPtr_get_BlockResolved_Public_get_XmlSchemaDerivationMethod_0;

		// Token: 0x04001BE8 RID: 7144
		private static readonly IntPtr NativeMethodInfoPtr_get_AttributeUses_Public_get_XmlSchemaObjectTable_0;

		// Token: 0x04001BE9 RID: 7145
		private static readonly IntPtr NativeMethodInfoPtr_get_AttributeWildcard_Public_get_XmlSchemaAnyAttribute_0;

		// Token: 0x04001BEA RID: 7146
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalElements_Internal_get_XmlSchemaObjectTable_0;

		// Token: 0x04001BEB RID: 7147
		private static readonly IntPtr NativeMethodInfoPtr_SetContentTypeParticle_Internal_Void_XmlSchemaParticle_0;

		// Token: 0x04001BEC RID: 7148
		private static readonly IntPtr NativeMethodInfoPtr_SetBlockResolved_Internal_Void_XmlSchemaDerivationMethod_0;

		// Token: 0x04001BED RID: 7149
		private static readonly IntPtr NativeMethodInfoPtr_SetAttributeWildcard_Internal_Void_XmlSchemaAnyAttribute_0;

		// Token: 0x04001BEE RID: 7150
		private static readonly IntPtr NativeMethodInfoPtr_set_HasWildCard_Internal_set_Void_Boolean_0;

		// Token: 0x04001BEF RID: 7151
		private static readonly IntPtr NativeMethodInfoPtr_SetAttributes_Internal_Void_XmlSchemaObjectCollection_0;

		// Token: 0x04001BF0 RID: 7152
		private static readonly IntPtr NativeMethodInfoPtr_ContainsIdAttribute_Internal_Boolean_Boolean_0;

		// Token: 0x04001BF1 RID: 7153
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Internal_Virtual_XmlSchemaObject_0;

		// Token: 0x04001BF2 RID: 7154
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Internal_XmlSchemaObject_XmlSchema_0;

		// Token: 0x04001BF3 RID: 7155
		private static readonly IntPtr NativeMethodInfoPtr_ClearCompiledState_Private_Void_0;

		// Token: 0x04001BF4 RID: 7156
		private static readonly IntPtr NativeMethodInfoPtr_CloneAttributes_Internal_Static_XmlSchemaObjectCollection_XmlSchemaObjectCollection_0;

		// Token: 0x04001BF5 RID: 7157
		private static readonly IntPtr NativeMethodInfoPtr_CloneGroupBaseParticles_Private_Static_XmlSchemaObjectCollection_XmlSchemaObjectCollection_XmlSchema_0;

		// Token: 0x04001BF6 RID: 7158
		private static readonly IntPtr NativeMethodInfoPtr_CloneParticle_Internal_Static_XmlSchemaParticle_XmlSchemaParticle_XmlSchema_0;

		// Token: 0x04001BF7 RID: 7159
		private static readonly IntPtr NativeMethodInfoPtr_GetResolvedElementForm_Private_Static_XmlSchemaForm_XmlSchema_XmlSchemaElement_0;

		// Token: 0x04001BF8 RID: 7160
		private static readonly IntPtr NativeMethodInfoPtr_HasParticleRef_Internal_Static_Boolean_XmlSchemaParticle_XmlSchema_0;

		// Token: 0x04001BF9 RID: 7161
		private static readonly IntPtr NativeMethodInfoPtr_HasAttributeQNameRef_Internal_Static_Boolean_XmlSchemaObjectCollection_0;
	}
}
