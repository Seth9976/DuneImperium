using System;
using dwd.core.data.composition;
using dwd.core.pooling;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.core.prefabs.prefabProvider
{
	// Token: 0x0200010F RID: 271
	public class PooledSinglePrefabProvider : PooledPrefabProvider
	{
		// Token: 0x06000F6A RID: 3946 RVA: 0x00050FA8 File Offset: 0x0004F1A8
		// Note: this type is marked as 'beforefieldinit'.
		static PooledSinglePrefabProvider()
		{
			Il2CppClassPointerStore<PooledSinglePrefabProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.prefabs.prefabProvider", "PooledSinglePrefabProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PooledSinglePrefabProvider>.NativeClassPtr);
			PooledSinglePrefabProvider.NativeFieldInfoPtr_prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PooledSinglePrefabProvider>.NativeClassPtr, "prefab");
			PooledSinglePrefabProvider.NativeFieldInfoPtr_maxPoolSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PooledSinglePrefabProvider>.NativeClassPtr, "maxPoolSize");
			PooledSinglePrefabProvider.NativeFieldInfoPtr_initialPoolSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PooledSinglePrefabProvider>.NativeClassPtr, "initialPoolSize");
			PooledSinglePrefabProvider.NativeFieldInfoPtr_defaultInstanceParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PooledSinglePrefabProvider>.NativeClassPtr, "defaultInstanceParent");
			PooledSinglePrefabProvider.NativeFieldInfoPtr_prefabPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PooledSinglePrefabProvider>.NativeClassPtr, "prefabPool");
			PooledSinglePrefabProvider.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PooledSinglePrefabProvider>.NativeClassPtr, 100665542);
			PooledSinglePrefabProvider.NativeMethodInfoPtr_getPrefabPoolForData_Protected_Virtual_PrefabPool_1_SubscriptionProvider_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PooledSinglePrefabProvider>.NativeClassPtr, 100665543);
			PooledSinglePrefabProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PooledSinglePrefabProvider>.NativeClassPtr, 100665544);
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x00051078 File Offset: 0x0004F278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868262, XrefRangeEnd = 868275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PooledSinglePrefabProvider.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x000510AC File Offset: 0x0004F2AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override PrefabPool<SubscriptionProvider> getPrefabPoolForData(DataComposition data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PooledSinglePrefabProvider.NativeMethodInfoPtr_getPrefabPoolForData_Protected_Virtual_PrefabPool_1_SubscriptionProvider_DataComposition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PrefabPool<SubscriptionProvider>>(intPtr3) : null;
			}
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x00051108 File Offset: 0x0004F308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PooledSinglePrefabProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PooledSinglePrefabProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PooledSinglePrefabProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x0000734D File Offset: 0x0000554D
		public PooledSinglePrefabProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000F6F RID: 3951 RVA: 0x00051144 File Offset: 0x0004F344
		// (set) Token: 0x06000F70 RID: 3952 RVA: 0x00007356 File Offset: 0x00005556
		public unsafe SubscriptionProvider prefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PooledSinglePrefabProvider.NativeFieldInfoPtr_prefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PooledSinglePrefabProvider.NativeFieldInfoPtr_prefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000F71 RID: 3953 RVA: 0x00051174 File Offset: 0x0004F374
		// (set) Token: 0x06000F72 RID: 3954 RVA: 0x00007375 File Offset: 0x00005575
		public unsafe int maxPoolSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PooledSinglePrefabProvider.NativeFieldInfoPtr_maxPoolSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PooledSinglePrefabProvider.NativeFieldInfoPtr_maxPoolSize)) = value;
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000F73 RID: 3955 RVA: 0x0005119C File Offset: 0x0004F39C
		// (set) Token: 0x06000F74 RID: 3956 RVA: 0x00007390 File Offset: 0x00005590
		public unsafe int initialPoolSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PooledSinglePrefabProvider.NativeFieldInfoPtr_initialPoolSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PooledSinglePrefabProvider.NativeFieldInfoPtr_initialPoolSize)) = value;
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000F75 RID: 3957 RVA: 0x000511C4 File Offset: 0x0004F3C4
		// (set) Token: 0x06000F76 RID: 3958 RVA: 0x000073AB File Offset: 0x000055AB
		public unsafe Transform defaultInstanceParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PooledSinglePrefabProvider.NativeFieldInfoPtr_defaultInstanceParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PooledSinglePrefabProvider.NativeFieldInfoPtr_defaultInstanceParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000F77 RID: 3959 RVA: 0x000511F4 File Offset: 0x0004F3F4
		// (set) Token: 0x06000F78 RID: 3960 RVA: 0x000073CA File Offset: 0x000055CA
		public unsafe PrefabPool<SubscriptionProvider> prefabPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PooledSinglePrefabProvider.NativeFieldInfoPtr_prefabPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefabPool<SubscriptionProvider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PooledSinglePrefabProvider.NativeFieldInfoPtr_prefabPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B07 RID: 2823
		private static readonly IntPtr NativeFieldInfoPtr_prefab;

		// Token: 0x04000B08 RID: 2824
		private static readonly IntPtr NativeFieldInfoPtr_maxPoolSize;

		// Token: 0x04000B09 RID: 2825
		private static readonly IntPtr NativeFieldInfoPtr_initialPoolSize;

		// Token: 0x04000B0A RID: 2826
		private static readonly IntPtr NativeFieldInfoPtr_defaultInstanceParent;

		// Token: 0x04000B0B RID: 2827
		private static readonly IntPtr NativeFieldInfoPtr_prefabPool;

		// Token: 0x04000B0C RID: 2828
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000B0D RID: 2829
		private static readonly IntPtr NativeMethodInfoPtr_getPrefabPoolForData_Protected_Virtual_PrefabPool_1_SubscriptionProvider_DataComposition_0;

		// Token: 0x04000B0E RID: 2830
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
