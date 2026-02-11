using System;
using Canis.attributes;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace dwd.core.data.composition
{
	// Token: 0x020001D9 RID: 473
	public class AttributesData : AttributeDataComponent
	{
		// Token: 0x06001A0B RID: 6667 RVA: 0x0007B74C File Offset: 0x0007994C
		// Note: this type is marked as 'beforefieldinit'.
		static AttributesData()
		{
			Il2CppClassPointerStore<AttributesData>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.data.composition", "AttributesData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributesData>.NativeClassPtr);
			AttributesData.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributesData>.NativeClassPtr, "attributes");
			AttributesData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributesData>.NativeClassPtr, 100667421);
			AttributesData.NativeMethodInfoPtr__ctor_Public_Void_MutableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributesData>.NativeClassPtr, 100667422);
			AttributesData.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributesData>.NativeClassPtr, 100667423);
			AttributesData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributesData>.NativeClassPtr, 100667424);
			AttributesData.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributesData>.NativeClassPtr, 100667425);
			AttributesData.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_Nullable_1_Int32_AttributeDefinition_1_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributesData>.NativeClassPtr, 100667426);
			AttributesData.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_Nullable_1_Single_AttributeDefinition_1_Nullable_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributesData>.NativeClassPtr, 100667427);
			AttributesData.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_String_AttributeDefinition_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributesData>.NativeClassPtr, 100667428);
			AttributesData.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_Il2CppStringArray_AttributeDefinition_1_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributesData>.NativeClassPtr, 100667429);
			AttributesData.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_LocalizableText_AttributeDefinition_1_LocalizableText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributesData>.NativeClassPtr, 100667430);
			AttributesData.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_Nullable_1_Boolean_AttributeDefinition_1_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributesData>.NativeClassPtr, 100667431);
			AttributesData.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_V_AttributeDefinition_1_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributesData>.NativeClassPtr, 100667432);
			AttributesData.NativeMethodInfoPtr_SetAttribute_Public_Void_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributesData>.NativeClassPtr, 100667433);
			AttributesData.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_1_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributesData>.NativeClassPtr, 100667434);
			AttributesData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributesData>.NativeClassPtr, 100667435);
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x0007B8BC File Offset: 0x00079ABC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 882229, RefRangeEnd = 882231, XrefRangeStart = 882222, XrefRangeEnd = 882229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributesData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributesData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributesData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x0007B8F8 File Offset: 0x00079AF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 765260, RefRangeEnd = 765261, XrefRangeStart = 765260, XrefRangeEnd = 765261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributesData(MutableAttributes attributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributesData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributesData.NativeMethodInfoPtr__ctor_Public_Void_MutableAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x0007B944 File Offset: 0x00079B44
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 882238, RefRangeEnd = 882243, XrefRangeStart = 882231, XrefRangeEnd = 882238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributesData(IEnumerable<IAttribute> attributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributesData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributesData.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x06001A0F RID: 6671 RVA: 0x0007B990 File Offset: 0x00079B90
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 882243, XrefRangeEnd = 882247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributesData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A10 RID: 6672 RVA: 0x0007B9D8 File Offset: 0x00079BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 882247, XrefRangeEnd = 882253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ReadOnlyAttribute GetAttribute(int key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributesData.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x06001A11 RID: 6673 RVA: 0x0007BA30 File Offset: 0x00079C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 882253, XrefRangeEnd = 882261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ReadOnlyAttribute<Nullable<int>> GetAttribute(AttributeDefinition<Nullable<int>> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributesData.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_Nullable_1_Int32_AttributeDefinition_1_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<Nullable<int>>>(intPtr3) : null;
			}
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x0007BA8C File Offset: 0x00079C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 882261, XrefRangeEnd = 882269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ReadOnlyAttribute<Nullable<float>> GetAttribute(AttributeDefinition<Nullable<float>> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributesData.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_Nullable_1_Single_AttributeDefinition_1_Nullable_1_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<Nullable<float>>>(intPtr3) : null;
			}
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x0007BAE8 File Offset: 0x00079CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 882269, XrefRangeEnd = 882277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ReadOnlyAttribute<string> GetAttribute(AttributeDefinition<string> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributesData.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_String_AttributeDefinition_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<string>>(intPtr3) : null;
			}
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x0007BB44 File Offset: 0x00079D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 882277, XrefRangeEnd = 882285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ReadOnlyAttribute<Il2CppStringArray> GetAttribute(AttributeDefinition<Il2CppStringArray> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributesData.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_Il2CppStringArray_AttributeDefinition_1_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<Il2CppStringArray>>(intPtr3) : null;
			}
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x0007BBA0 File Offset: 0x00079DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 882285, XrefRangeEnd = 882293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ReadOnlyAttribute<LocalizableText> GetAttribute(AttributeDefinition<LocalizableText> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributesData.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_LocalizableText_AttributeDefinition_1_LocalizableText_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<LocalizableText>>(intPtr3) : null;
			}
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x0007BBFC File Offset: 0x00079DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 882293, XrefRangeEnd = 882301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ReadOnlyAttribute<Nullable<bool>> GetAttribute(AttributeDefinition<Nullable<bool>> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributesData.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_Nullable_1_Boolean_AttributeDefinition_1_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<Nullable<bool>>>(intPtr3) : null;
			}
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x0007BC58 File Offset: 0x00079E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 882301, XrefRangeEnd = 882329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ReadOnlyAttribute<V> GetAttribute<V>(AttributeDefinition<V> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributesData.MethodInfoStoreGeneric_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_V_AttributeDefinition_1_V_0<V>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<V>>(intPtr3) : null;
			}
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x0007BCB4 File Offset: 0x00079EB4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 882330, RefRangeEnd = 882335, XrefRangeStart = 882329, XrefRangeEnd = 882330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAttribute(IAttribute updatedAttribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(updatedAttribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributesData.NativeMethodInfoPtr_SetAttribute_Public_Void_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A19 RID: 6681 RVA: 0x0007BCF8 File Offset: 0x00079EF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 882335, XrefRangeEnd = 882337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator<IAttribute> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributesData.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_1_IAttribute_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<IAttribute>>(intPtr3) : null;
		}

		// Token: 0x06001A1A RID: 6682 RVA: 0x0007BD44 File Offset: 0x00079F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 882337, XrefRangeEnd = 882341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributesData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A1B RID: 6683 RVA: 0x0000B593 File Offset: 0x00009793
		public AttributesData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x06001A1C RID: 6684 RVA: 0x0007BD88 File Offset: 0x00079F88
		// (set) Token: 0x06001A1D RID: 6685 RVA: 0x0000B59C File Offset: 0x0000979C
		public unsafe MutableAttributes attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributesData.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MutableAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributesData.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001245 RID: 4677
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x04001246 RID: 4678
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001247 RID: 4679
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MutableAttributes_0;

		// Token: 0x04001248 RID: 4680
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_IAttribute_0;

		// Token: 0x04001249 RID: 4681
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

		// Token: 0x0400124A RID: 4682
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_Int32_0;

		// Token: 0x0400124B RID: 4683
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_Nullable_1_Int32_AttributeDefinition_1_Nullable_1_Int32_0;

		// Token: 0x0400124C RID: 4684
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_Nullable_1_Single_AttributeDefinition_1_Nullable_1_Single_0;

		// Token: 0x0400124D RID: 4685
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_String_AttributeDefinition_1_String_0;

		// Token: 0x0400124E RID: 4686
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_Il2CppStringArray_AttributeDefinition_1_Il2CppStringArray_0;

		// Token: 0x0400124F RID: 4687
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_LocalizableText_AttributeDefinition_1_LocalizableText_0;

		// Token: 0x04001250 RID: 4688
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_Nullable_1_Boolean_AttributeDefinition_1_Nullable_1_Boolean_0;

		// Token: 0x04001251 RID: 4689
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_V_AttributeDefinition_1_V_0;

		// Token: 0x04001252 RID: 4690
		private static readonly IntPtr NativeMethodInfoPtr_SetAttribute_Public_Void_IAttribute_0;

		// Token: 0x04001253 RID: 4691
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_1_IAttribute_0;

		// Token: 0x04001254 RID: 4692
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0200036A RID: 874
		private sealed class MethodInfoStoreGeneric_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_V_AttributeDefinition_1_V_0<V>
		{
			// Token: 0x04001AF5 RID: 6901
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AttributesData.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_V_AttributeDefinition_1_V_0, Il2CppClassPointerStore<AttributesData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr)) }))));
		}
	}
}
