using System;
using Canis.attributes;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace dwd.core.data.composition
{
	// Token: 0x020001D8 RID: 472
	public class AttributeDataComponent : DataComponent
	{
		// Token: 0x060019FB RID: 6651 RVA: 0x0007B17C File Offset: 0x0007937C
		// Note: this type is marked as 'beforefieldinit'.
		static AttributeDataComponent()
		{
			Il2CppClassPointerStore<AttributeDataComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.data.composition", "AttributeDataComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeDataComponent>.NativeClassPtr);
			AttributeDataComponent.NativeMethodInfoPtr_GetAttribute_Public_Abstract_Virtual_New_ReadOnlyAttribute_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataComponent>.NativeClassPtr, 100667407);
			AttributeDataComponent.NativeMethodInfoPtr_GetAttribute_Public_Abstract_Virtual_New_ReadOnlyAttribute_1_Nullable_1_Int32_AttributeDefinition_1_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataComponent>.NativeClassPtr, 100667408);
			AttributeDataComponent.NativeMethodInfoPtr_GetAttribute_Public_Abstract_Virtual_New_ReadOnlyAttribute_1_Nullable_1_Single_AttributeDefinition_1_Nullable_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataComponent>.NativeClassPtr, 100667409);
			AttributeDataComponent.NativeMethodInfoPtr_GetAttribute_Public_Abstract_Virtual_New_ReadOnlyAttribute_1_String_AttributeDefinition_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataComponent>.NativeClassPtr, 100667410);
			AttributeDataComponent.NativeMethodInfoPtr_GetAttribute_Public_Abstract_Virtual_New_ReadOnlyAttribute_1_Il2CppStringArray_AttributeDefinition_1_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataComponent>.NativeClassPtr, 100667411);
			AttributeDataComponent.NativeMethodInfoPtr_GetAttribute_Public_Abstract_Virtual_New_ReadOnlyAttribute_1_LocalizableText_AttributeDefinition_1_LocalizableText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataComponent>.NativeClassPtr, 100667412);
			AttributeDataComponent.NativeMethodInfoPtr_GetAttribute_Public_Abstract_Virtual_New_ReadOnlyAttribute_1_Nullable_1_Boolean_AttributeDefinition_1_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataComponent>.NativeClassPtr, 100667413);
			AttributeDataComponent.NativeMethodInfoPtr_GetAttribute_Public_Abstract_Virtual_New_ReadOnlyAttribute_1_V_AttributeDefinition_1_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataComponent>.NativeClassPtr, 100667414);
			AttributeDataComponent.NativeMethodInfoPtr_GetEnumerator_Public_Abstract_Virtual_New_IEnumerator_1_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataComponent>.NativeClassPtr, 100667415);
			AttributeDataComponent.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataComponent>.NativeClassPtr, 100667416);
			AttributeDataComponent.NativeMethodInfoPtr_Canis_attributes_IHasAttributes_GetAttribute_Private_Virtual_Final_New_IAttribute_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataComponent>.NativeClassPtr, 100667417);
			AttributeDataComponent.NativeMethodInfoPtr_Canis_attributes_IHasAttributes_GetAttribute_Private_Virtual_Final_New_IAttribute_1_V_AttributeDefinition_1_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataComponent>.NativeClassPtr, 100667418);
			AttributeDataComponent.NativeMethodInfoPtr_get_Version_Public_Abstract_Virtual_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataComponent>.NativeClassPtr, 100667419);
			AttributeDataComponent.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataComponent>.NativeClassPtr, 100667420);
		}

		// Token: 0x060019FC RID: 6652 RVA: 0x0007B2C4 File Offset: 0x000794C4
		[CallerCount(0)]
		public unsafe virtual ReadOnlyAttribute GetAttribute(int key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributeDataComponent.NativeMethodInfoPtr_GetAttribute_Public_Abstract_Virtual_New_ReadOnlyAttribute_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x060019FD RID: 6653 RVA: 0x0007B31C File Offset: 0x0007951C
		[CallerCount(0)]
		public unsafe virtual ReadOnlyAttribute<Nullable<int>> GetAttribute(AttributeDefinition<Nullable<int>> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributeDataComponent.NativeMethodInfoPtr_GetAttribute_Public_Abstract_Virtual_New_ReadOnlyAttribute_1_Nullable_1_Int32_AttributeDefinition_1_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<Nullable<int>>>(intPtr3) : null;
			}
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x0007B378 File Offset: 0x00079578
		[CallerCount(0)]
		public unsafe virtual ReadOnlyAttribute<Nullable<float>> GetAttribute(AttributeDefinition<Nullable<float>> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributeDataComponent.NativeMethodInfoPtr_GetAttribute_Public_Abstract_Virtual_New_ReadOnlyAttribute_1_Nullable_1_Single_AttributeDefinition_1_Nullable_1_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<Nullable<float>>>(intPtr3) : null;
			}
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x0007B3D4 File Offset: 0x000795D4
		[CallerCount(0)]
		public unsafe virtual ReadOnlyAttribute<string> GetAttribute(AttributeDefinition<string> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributeDataComponent.NativeMethodInfoPtr_GetAttribute_Public_Abstract_Virtual_New_ReadOnlyAttribute_1_String_AttributeDefinition_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<string>>(intPtr3) : null;
			}
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x0007B430 File Offset: 0x00079630
		[CallerCount(0)]
		public unsafe virtual ReadOnlyAttribute<Il2CppStringArray> GetAttribute(AttributeDefinition<Il2CppStringArray> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributeDataComponent.NativeMethodInfoPtr_GetAttribute_Public_Abstract_Virtual_New_ReadOnlyAttribute_1_Il2CppStringArray_AttributeDefinition_1_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<Il2CppStringArray>>(intPtr3) : null;
			}
		}

		// Token: 0x06001A01 RID: 6657 RVA: 0x0007B48C File Offset: 0x0007968C
		[CallerCount(0)]
		public unsafe virtual ReadOnlyAttribute<LocalizableText> GetAttribute(AttributeDefinition<LocalizableText> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributeDataComponent.NativeMethodInfoPtr_GetAttribute_Public_Abstract_Virtual_New_ReadOnlyAttribute_1_LocalizableText_AttributeDefinition_1_LocalizableText_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<LocalizableText>>(intPtr3) : null;
			}
		}

		// Token: 0x06001A02 RID: 6658 RVA: 0x0007B4E8 File Offset: 0x000796E8
		[CallerCount(0)]
		public unsafe virtual ReadOnlyAttribute<Nullable<bool>> GetAttribute(AttributeDefinition<Nullable<bool>> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributeDataComponent.NativeMethodInfoPtr_GetAttribute_Public_Abstract_Virtual_New_ReadOnlyAttribute_1_Nullable_1_Boolean_AttributeDefinition_1_Nullable_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<Nullable<bool>>>(intPtr3) : null;
			}
		}

		// Token: 0x06001A03 RID: 6659 RVA: 0x0007B544 File Offset: 0x00079744
		[CallerCount(0)]
		public unsafe virtual ReadOnlyAttribute<V> GetAttribute<V>(AttributeDefinition<V> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributeDataComponent.MethodInfoStoreGeneric_GetAttribute_Public_Abstract_Virtual_New_ReadOnlyAttribute_1_V_AttributeDefinition_1_V_0<V>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<V>>(intPtr3) : null;
			}
		}

		// Token: 0x06001A04 RID: 6660 RVA: 0x0007B5A0 File Offset: 0x000797A0
		[CallerCount(0)]
		public unsafe virtual IEnumerator<IAttribute> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributeDataComponent.NativeMethodInfoPtr_GetEnumerator_Public_Abstract_Virtual_New_IEnumerator_1_IAttribute_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<IAttribute>>(intPtr3) : null;
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x0007B5EC File Offset: 0x000797EC
		[CallerCount(0)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeDataComponent.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x0007B62C File Offset: 0x0007982C
		[CallerCount(0)]
		public unsafe virtual IAttribute Canis_attributes_IHasAttributes_GetAttribute(int key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeDataComponent.NativeMethodInfoPtr_Canis_attributes_IHasAttributes_GetAttribute_Private_Virtual_Final_New_IAttribute_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x0007B678 File Offset: 0x00079878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 881925, XrefRangeEnd = 881927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IAttribute<V> Canis_attributes_IHasAttributes_GetAttribute<V>(AttributeDefinition<V> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeDataComponent.MethodInfoStoreGeneric_Canis_attributes_IHasAttributes_GetAttribute_Private_Virtual_Final_New_IAttribute_1_V_AttributeDefinition_1_V_0<V>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute<V>>(intPtr3) : null;
			}
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x06001A08 RID: 6664 RVA: 0x0007B6C8 File Offset: 0x000798C8
		public unsafe virtual ulong Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributeDataComponent.NativeMethodInfoPtr_get_Version_Public_Abstract_Virtual_New_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x0007B710 File Offset: 0x00079910
		[CallerCount(293)]
		[CachedScanResults(RefRangeStart = 881929, RefRangeEnd = 882222, XrefRangeStart = 881927, XrefRangeEnd = 881929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributeDataComponent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeDataComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeDataComponent.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x0000B58A File Offset: 0x0000978A
		public AttributeDataComponent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001237 RID: 4663
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Abstract_Virtual_New_ReadOnlyAttribute_Int32_0;

		// Token: 0x04001238 RID: 4664
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Abstract_Virtual_New_ReadOnlyAttribute_1_Nullable_1_Int32_AttributeDefinition_1_Nullable_1_Int32_0;

		// Token: 0x04001239 RID: 4665
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Abstract_Virtual_New_ReadOnlyAttribute_1_Nullable_1_Single_AttributeDefinition_1_Nullable_1_Single_0;

		// Token: 0x0400123A RID: 4666
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Abstract_Virtual_New_ReadOnlyAttribute_1_String_AttributeDefinition_1_String_0;

		// Token: 0x0400123B RID: 4667
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Abstract_Virtual_New_ReadOnlyAttribute_1_Il2CppStringArray_AttributeDefinition_1_Il2CppStringArray_0;

		// Token: 0x0400123C RID: 4668
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Abstract_Virtual_New_ReadOnlyAttribute_1_LocalizableText_AttributeDefinition_1_LocalizableText_0;

		// Token: 0x0400123D RID: 4669
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Abstract_Virtual_New_ReadOnlyAttribute_1_Nullable_1_Boolean_AttributeDefinition_1_Nullable_1_Boolean_0;

		// Token: 0x0400123E RID: 4670
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Abstract_Virtual_New_ReadOnlyAttribute_1_V_AttributeDefinition_1_V_0;

		// Token: 0x0400123F RID: 4671
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Abstract_Virtual_New_IEnumerator_1_IAttribute_0;

		// Token: 0x04001240 RID: 4672
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04001241 RID: 4673
		private static readonly IntPtr NativeMethodInfoPtr_Canis_attributes_IHasAttributes_GetAttribute_Private_Virtual_Final_New_IAttribute_Int32_0;

		// Token: 0x04001242 RID: 4674
		private static readonly IntPtr NativeMethodInfoPtr_Canis_attributes_IHasAttributes_GetAttribute_Private_Virtual_Final_New_IAttribute_1_V_AttributeDefinition_1_V_0;

		// Token: 0x04001243 RID: 4675
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Abstract_Virtual_New_get_UInt64_0;

		// Token: 0x04001244 RID: 4676
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000368 RID: 872
		private sealed class MethodInfoStoreGeneric_GetAttribute_Public_Abstract_Virtual_New_ReadOnlyAttribute_1_V_AttributeDefinition_1_V_0<V>
		{
			// Token: 0x04001AF3 RID: 6899
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AttributeDataComponent.NativeMethodInfoPtr_GetAttribute_Public_Abstract_Virtual_New_ReadOnlyAttribute_1_V_AttributeDefinition_1_V_0, Il2CppClassPointerStore<AttributeDataComponent>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr)) }))));
		}

		// Token: 0x02000369 RID: 873
		private sealed class MethodInfoStoreGeneric_Canis_attributes_IHasAttributes_GetAttribute_Private_Virtual_Final_New_IAttribute_1_V_AttributeDefinition_1_V_0<V>
		{
			// Token: 0x04001AF4 RID: 6900
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AttributeDataComponent.NativeMethodInfoPtr_Canis_attributes_IHasAttributes_GetAttribute_Private_Virtual_Final_New_IAttribute_1_V_AttributeDefinition_1_V_0, Il2CppClassPointerStore<AttributeDataComponent>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr)) }))));
		}
	}
}
