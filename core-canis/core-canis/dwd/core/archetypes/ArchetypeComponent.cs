using System;
using Canis.attributes;
using Canis.utils.ids;
using Canis.utils.localization;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace dwd.core.archetypes
{
	// Token: 0x02000214 RID: 532
	public class ArchetypeComponent : AttributeDataComponent
	{
		// Token: 0x06001D22 RID: 7458 RVA: 0x00086FB4 File Offset: 0x000851B4
		// Note: this type is marked as 'beforefieldinit'.
		static ArchetypeComponent()
		{
			Il2CppClassPointerStore<ArchetypeComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.archetypes", "ArchetypeComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArchetypeComponent>.NativeClassPtr);
			ArchetypeComponent.NativeFieldInfoPtr_ArchetypeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeComponent>.NativeClassPtr, "ArchetypeID");
			ArchetypeComponent.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeComponent>.NativeClassPtr, "attributes");
			ArchetypeComponent.NativeMethodInfoPtr__ctor_Public_Void_ArchetypeID_MutableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeComponent>.NativeClassPtr, 100667984);
			ArchetypeComponent.NativeMethodInfoPtr_Clone_Public_Virtual_DataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeComponent>.NativeClassPtr, 100667985);
			ArchetypeComponent.NativeMethodInfoPtr_UpdateAttributes_Public_Void_ReadOnlyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeComponent>.NativeClassPtr, 100667986);
			ArchetypeComponent.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeComponent>.NativeClassPtr, 100667987);
			ArchetypeComponent.NativeMethodInfoPtr_op_Implicit_Public_Static_DataComposition_ArchetypeComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeComponent>.NativeClassPtr, 100667988);
			ArchetypeComponent.NativeMethodInfoPtr_op_Implicit_Public_Static_ReadOnlyAttributes_ArchetypeComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeComponent>.NativeClassPtr, 100667989);
			ArchetypeComponent.NativeMethodInfoPtr_GetAttribute_Public_Virtual_Final_ReadOnlyAttribute_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeComponent>.NativeClassPtr, 100667990);
			ArchetypeComponent.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_Nullable_1_Int32_AttributeDefinition_1_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeComponent>.NativeClassPtr, 100667991);
			ArchetypeComponent.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_Nullable_1_Single_AttributeDefinition_1_Nullable_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeComponent>.NativeClassPtr, 100667992);
			ArchetypeComponent.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_String_AttributeDefinition_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeComponent>.NativeClassPtr, 100667993);
			ArchetypeComponent.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_Il2CppStringArray_AttributeDefinition_1_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeComponent>.NativeClassPtr, 100667994);
			ArchetypeComponent.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_LocalizableText_AttributeDefinition_1_LocalizableText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeComponent>.NativeClassPtr, 100667995);
			ArchetypeComponent.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_Nullable_1_Boolean_AttributeDefinition_1_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeComponent>.NativeClassPtr, 100667996);
			ArchetypeComponent.NativeMethodInfoPtr_GetAttribute_Public_Virtual_Final_ReadOnlyAttribute_1_V_AttributeDefinition_1_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeComponent>.NativeClassPtr, 100667997);
			ArchetypeComponent.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_IEnumerator_1_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeComponent>.NativeClassPtr, 100667998);
			ArchetypeComponent.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeComponent>.NativeClassPtr, 100667999);
			ArchetypeComponent.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeComponent>.NativeClassPtr, 100668000);
		}

		// Token: 0x06001D23 RID: 7459 RVA: 0x00087160 File Offset: 0x00085360
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 504845, RefRangeEnd = 504850, XrefRangeStart = 504845, XrefRangeEnd = 504850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArchetypeComponent(ArchetypeID archetypeID, MutableAttributes attrs)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArchetypeComponent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(archetypeID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attrs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeComponent.NativeMethodInfoPtr__ctor_Public_Void_ArchetypeID_MutableAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D24 RID: 7460 RVA: 0x000871C0 File Offset: 0x000853C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886151, XrefRangeEnd = 886157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DataComponent Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArchetypeComponent.NativeMethodInfoPtr_Clone_Public_Virtual_DataComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComponent>(intPtr3) : null;
		}

		// Token: 0x06001D25 RID: 7461 RVA: 0x0008720C File Offset: 0x0008540C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886157, XrefRangeEnd = 886159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAttributes(ReadOnlyAttributes attrs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeComponent.NativeMethodInfoPtr_UpdateAttributes_Public_Void_ReadOnlyAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D26 RID: 7462 RVA: 0x00087250 File Offset: 0x00085450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886159, XrefRangeEnd = 886160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeComponent.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D27 RID: 7463 RVA: 0x00087284 File Offset: 0x00085484
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 870911, RefRangeEnd = 870914, XrefRangeStart = 870911, XrefRangeEnd = 870914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator DataComposition(ArchetypeComponent archetype)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(archetype);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeComponent.NativeMethodInfoPtr_op_Implicit_Public_Static_DataComposition_ArchetypeComponent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
			}
		}

		// Token: 0x06001D28 RID: 7464 RVA: 0x000872C8 File Offset: 0x000854C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 886161, RefRangeEnd = 886162, XrefRangeStart = 886160, XrefRangeEnd = 886161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ReadOnlyAttributes(ArchetypeComponent archetype)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(archetype);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeComponent.NativeMethodInfoPtr_op_Implicit_Public_Static_ReadOnlyAttributes_ArchetypeComponent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x06001D29 RID: 7465 RVA: 0x0008730C File Offset: 0x0008550C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886162, XrefRangeEnd = 886167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ReadOnlyAttribute GetAttribute(int key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeComponent.NativeMethodInfoPtr_GetAttribute_Public_Virtual_Final_ReadOnlyAttribute_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x06001D2A RID: 7466 RVA: 0x00087358 File Offset: 0x00085558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886167, XrefRangeEnd = 886172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ReadOnlyAttribute<Nullable<int>> GetAttribute(AttributeDefinition<Nullable<int>> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArchetypeComponent.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_Nullable_1_Int32_AttributeDefinition_1_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<Nullable<int>>>(intPtr3) : null;
			}
		}

		// Token: 0x06001D2B RID: 7467 RVA: 0x000873B4 File Offset: 0x000855B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886172, XrefRangeEnd = 886177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ReadOnlyAttribute<Nullable<float>> GetAttribute(AttributeDefinition<Nullable<float>> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArchetypeComponent.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_Nullable_1_Single_AttributeDefinition_1_Nullable_1_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<Nullable<float>>>(intPtr3) : null;
			}
		}

		// Token: 0x06001D2C RID: 7468 RVA: 0x00087410 File Offset: 0x00085610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886177, XrefRangeEnd = 886182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ReadOnlyAttribute<string> GetAttribute(AttributeDefinition<string> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArchetypeComponent.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_String_AttributeDefinition_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<string>>(intPtr3) : null;
			}
		}

		// Token: 0x06001D2D RID: 7469 RVA: 0x0008746C File Offset: 0x0008566C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886182, XrefRangeEnd = 886187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ReadOnlyAttribute<Il2CppStringArray> GetAttribute(AttributeDefinition<Il2CppStringArray> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArchetypeComponent.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_Il2CppStringArray_AttributeDefinition_1_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<Il2CppStringArray>>(intPtr3) : null;
			}
		}

		// Token: 0x06001D2E RID: 7470 RVA: 0x000874C8 File Offset: 0x000856C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886187, XrefRangeEnd = 886192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ReadOnlyAttribute<LocalizableText> GetAttribute(AttributeDefinition<LocalizableText> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArchetypeComponent.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_LocalizableText_AttributeDefinition_1_LocalizableText_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<LocalizableText>>(intPtr3) : null;
			}
		}

		// Token: 0x06001D2F RID: 7471 RVA: 0x00087524 File Offset: 0x00085724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886192, XrefRangeEnd = 886197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ReadOnlyAttribute<Nullable<bool>> GetAttribute(AttributeDefinition<Nullable<bool>> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArchetypeComponent.NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_Nullable_1_Boolean_AttributeDefinition_1_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<Nullable<bool>>>(intPtr3) : null;
			}
		}

		// Token: 0x06001D30 RID: 7472 RVA: 0x00087580 File Offset: 0x00085780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886197, XrefRangeEnd = 886212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ReadOnlyAttribute<V> GetAttribute<V>(AttributeDefinition<V> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeComponent.MethodInfoStoreGeneric_GetAttribute_Public_Virtual_Final_ReadOnlyAttribute_1_V_AttributeDefinition_1_V_0<V>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<V>>(intPtr3) : null;
			}
		}

		// Token: 0x06001D31 RID: 7473 RVA: 0x000875D0 File Offset: 0x000857D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886212, XrefRangeEnd = 886214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator<IAttribute> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArchetypeComponent.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_IEnumerator_1_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<IAttribute>>(intPtr3) : null;
		}

		// Token: 0x06001D32 RID: 7474 RVA: 0x00087610 File Offset: 0x00085810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886214, XrefRangeEnd = 886218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArchetypeComponent.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x06001D33 RID: 7475 RVA: 0x00087654 File Offset: 0x00085854
		public unsafe override ulong Version
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArchetypeComponent.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D34 RID: 7476 RVA: 0x0000C702 File Offset: 0x0000A902
		public ArchetypeComponent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x06001D35 RID: 7477 RVA: 0x0008769C File Offset: 0x0008589C
		// (set) Token: 0x06001D36 RID: 7478 RVA: 0x0000C70B File Offset: 0x0000A90B
		public unsafe ArchetypeID ArchetypeID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeComponent.NativeFieldInfoPtr_ArchetypeID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeComponent.NativeFieldInfoPtr_ArchetypeID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x06001D37 RID: 7479 RVA: 0x000876CC File Offset: 0x000858CC
		// (set) Token: 0x06001D38 RID: 7480 RVA: 0x0000C72A File Offset: 0x0000A92A
		public unsafe MutableAttributes attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeComponent.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MutableAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArchetypeComponent.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001467 RID: 5223
		private static readonly IntPtr NativeFieldInfoPtr_ArchetypeID;

		// Token: 0x04001468 RID: 5224
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x04001469 RID: 5225
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ArchetypeID_MutableAttributes_0;

		// Token: 0x0400146A RID: 5226
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_DataComponent_0;

		// Token: 0x0400146B RID: 5227
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAttributes_Public_Void_ReadOnlyAttributes_0;

		// Token: 0x0400146C RID: 5228
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x0400146D RID: 5229
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_DataComposition_ArchetypeComponent_0;

		// Token: 0x0400146E RID: 5230
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ReadOnlyAttributes_ArchetypeComponent_0;

		// Token: 0x0400146F RID: 5231
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_Final_ReadOnlyAttribute_Int32_0;

		// Token: 0x04001470 RID: 5232
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_Nullable_1_Int32_AttributeDefinition_1_Nullable_1_Int32_0;

		// Token: 0x04001471 RID: 5233
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_Nullable_1_Single_AttributeDefinition_1_Nullable_1_Single_0;

		// Token: 0x04001472 RID: 5234
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_String_AttributeDefinition_1_String_0;

		// Token: 0x04001473 RID: 5235
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_Il2CppStringArray_AttributeDefinition_1_Il2CppStringArray_0;

		// Token: 0x04001474 RID: 5236
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_LocalizableText_AttributeDefinition_1_LocalizableText_0;

		// Token: 0x04001475 RID: 5237
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_ReadOnlyAttribute_1_Nullable_1_Boolean_AttributeDefinition_1_Nullable_1_Boolean_0;

		// Token: 0x04001476 RID: 5238
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_Final_ReadOnlyAttribute_1_V_AttributeDefinition_1_V_0;

		// Token: 0x04001477 RID: 5239
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_IEnumerator_1_IAttribute_0;

		// Token: 0x04001478 RID: 5240
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001479 RID: 5241
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

		// Token: 0x020003A1 RID: 929
		private sealed class MethodInfoStoreGeneric_GetAttribute_Public_Virtual_Final_ReadOnlyAttribute_1_V_AttributeDefinition_1_V_0<V>
		{
			// Token: 0x04001C00 RID: 7168
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ArchetypeComponent.NativeMethodInfoPtr_GetAttribute_Public_Virtual_Final_ReadOnlyAttribute_1_V_AttributeDefinition_1_V_0, Il2CppClassPointerStore<ArchetypeComponent>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr)) }))));
		}
	}
}
