using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace dwd.core.input.compositeModule
{
	// Token: 0x02000083 RID: 131
	public sealed class StrategySearchStringAttribute : PropertyAttribute
	{
		// Token: 0x0600057F RID: 1407 RVA: 0x00018444 File Offset: 0x00016644
		// Note: this type is marked as 'beforefieldinit'.
		static StrategySearchStringAttribute()
		{
			Il2CppClassPointerStore<StrategySearchStringAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.compositeModule", "StrategySearchStringAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StrategySearchStringAttribute>.NativeClassPtr);
			StrategySearchStringAttribute.NativeFieldInfoPtr__StrategyType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrategySearchStringAttribute>.NativeClassPtr, "<StrategyType>k__BackingField");
			StrategySearchStringAttribute.NativeMethodInfoPtr_get_StrategyType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrategySearchStringAttribute>.NativeClassPtr, 100663979);
			StrategySearchStringAttribute.NativeMethodInfoPtr_set_StrategyType_Private_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrategySearchStringAttribute>.NativeClassPtr, 100663980);
			StrategySearchStringAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrategySearchStringAttribute>.NativeClassPtr, 100663981);
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000580 RID: 1408 RVA: 0x000184C4 File Offset: 0x000166C4
		// (set) Token: 0x06000581 RID: 1409 RVA: 0x00018504 File Offset: 0x00016704
		public unsafe Type StrategyType
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StrategySearchStringAttribute.NativeMethodInfoPtr_get_StrategyType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StrategySearchStringAttribute.NativeMethodInfoPtr_set_StrategyType_Private_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00018548 File Offset: 0x00016748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124375, XrefRangeEnd = 1124391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StrategySearchStringAttribute(Type strategyType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StrategySearchStringAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(strategyType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StrategySearchStringAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00005056 File Offset: 0x00003256
		public StrategySearchStringAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000584 RID: 1412 RVA: 0x00018594 File Offset: 0x00016794
		// (set) Token: 0x06000585 RID: 1413 RVA: 0x0000505F File Offset: 0x0000325F
		public unsafe Type _StrategyType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrategySearchStringAttribute.NativeFieldInfoPtr__StrategyType_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrategySearchStringAttribute.NativeFieldInfoPtr__StrategyType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000350 RID: 848
		private static readonly IntPtr NativeFieldInfoPtr__StrategyType_k__BackingField;

		// Token: 0x04000351 RID: 849
		private static readonly IntPtr NativeMethodInfoPtr_get_StrategyType_Public_get_Type_0;

		// Token: 0x04000352 RID: 850
		private static readonly IntPtr NativeMethodInfoPtr_set_StrategyType_Private_set_Void_Type_0;

		// Token: 0x04000353 RID: 851
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
	}
}
