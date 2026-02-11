using System;
using dwd.core.data.composition;
using dwd.core.pooling;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dwd.core.prefabs.prefabProvider
{
	// Token: 0x0200010E RID: 270
	public class PooledPrefabProvider : MonoBehaviour
	{
		// Token: 0x06000F62 RID: 3938 RVA: 0x00050DA4 File Offset: 0x0004EFA4
		// Note: this type is marked as 'beforefieldinit'.
		static PooledPrefabProvider()
		{
			Il2CppClassPointerStore<PooledPrefabProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.prefabs.prefabProvider", "PooledPrefabProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PooledPrefabProvider>.NativeClassPtr);
			PooledPrefabProvider.NativeFieldInfoPtr_instanceToPoolMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PooledPrefabProvider>.NativeClassPtr, "instanceToPoolMap");
			PooledPrefabProvider.NativeMethodInfoPtr_GetPrefabInstanceForData_Public_SubscriptionProvider_DataComposition_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PooledPrefabProvider>.NativeClassPtr, 100665538);
			PooledPrefabProvider.NativeMethodInfoPtr_ReleasePrefabInstance_Public_Void_SubscriptionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PooledPrefabProvider>.NativeClassPtr, 100665539);
			PooledPrefabProvider.NativeMethodInfoPtr_getPrefabPoolForData_Protected_Abstract_Virtual_New_PrefabPool_1_SubscriptionProvider_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PooledPrefabProvider>.NativeClassPtr, 100665540);
			PooledPrefabProvider.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PooledPrefabProvider>.NativeClassPtr, 100665541);
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x00050E38 File Offset: 0x0004F038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868222, XrefRangeEnd = 868236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SubscriptionProvider GetPrefabInstanceForData(DataComposition data, Transform parentTransform = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentTransform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PooledPrefabProvider.NativeMethodInfoPtr_GetPrefabInstanceForData_Public_SubscriptionProvider_DataComposition_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr3) : null;
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x00050E9C File Offset: 0x0004F09C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 868252, RefRangeEnd = 868254, XrefRangeStart = 868236, XrefRangeEnd = 868252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleasePrefabInstance(SubscriptionProvider instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PooledPrefabProvider.NativeMethodInfoPtr_ReleasePrefabInstance_Public_Void_SubscriptionProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x00050EE0 File Offset: 0x0004F0E0
		[CallerCount(0)]
		public unsafe virtual PrefabPool<SubscriptionProvider> getPrefabPoolForData(DataComposition data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PooledPrefabProvider.NativeMethodInfoPtr_getPrefabPoolForData_Protected_Abstract_Virtual_New_PrefabPool_1_SubscriptionProvider_DataComposition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PrefabPool<SubscriptionProvider>>(intPtr3) : null;
			}
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x00050F3C File Offset: 0x0004F13C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868254, XrefRangeEnd = 868262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PooledPrefabProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PooledPrefabProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PooledPrefabProvider.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x00007325 File Offset: 0x00005525
		public PooledPrefabProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000F68 RID: 3944 RVA: 0x00050F78 File Offset: 0x0004F178
		// (set) Token: 0x06000F69 RID: 3945 RVA: 0x0000732E File Offset: 0x0000552E
		public unsafe Dictionary<SubscriptionProvider, PrefabPool<SubscriptionProvider>> instanceToPoolMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PooledPrefabProvider.NativeFieldInfoPtr_instanceToPoolMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<SubscriptionProvider, PrefabPool<SubscriptionProvider>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PooledPrefabProvider.NativeFieldInfoPtr_instanceToPoolMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B02 RID: 2818
		private static readonly IntPtr NativeFieldInfoPtr_instanceToPoolMap;

		// Token: 0x04000B03 RID: 2819
		private static readonly IntPtr NativeMethodInfoPtr_GetPrefabInstanceForData_Public_SubscriptionProvider_DataComposition_Transform_0;

		// Token: 0x04000B04 RID: 2820
		private static readonly IntPtr NativeMethodInfoPtr_ReleasePrefabInstance_Public_Void_SubscriptionProvider_0;

		// Token: 0x04000B05 RID: 2821
		private static readonly IntPtr NativeMethodInfoPtr_getPrefabPoolForData_Protected_Abstract_Virtual_New_PrefabPool_1_SubscriptionProvider_DataComposition_0;

		// Token: 0x04000B06 RID: 2822
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
