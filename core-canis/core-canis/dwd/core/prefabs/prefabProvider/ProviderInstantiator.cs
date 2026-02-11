using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace dwd.core.prefabs.prefabProvider
{
	// Token: 0x02000111 RID: 273
	public class ProviderInstantiator : VersionedViewOfDataCompositions
	{
		// Token: 0x06000F7D RID: 3965 RVA: 0x00051314 File Offset: 0x0004F514
		// Note: this type is marked as 'beforefieldinit'.
		static ProviderInstantiator()
		{
			Il2CppClassPointerStore<ProviderInstantiator>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.prefabs.prefabProvider", "ProviderInstantiator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProviderInstantiator>.NativeClassPtr);
			ProviderInstantiator.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderInstantiator>.NativeClassPtr, "items");
			ProviderInstantiator.NativeFieldInfoPtr_oldItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderInstantiator>.NativeClassPtr, "oldItems");
			ProviderInstantiator.NativeFieldInfoPtr_newItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderInstantiator>.NativeClassPtr, "newItems");
			ProviderInstantiator.NativeFieldInfoPtr_missingItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderInstantiator>.NativeClassPtr, "missingItems");
			ProviderInstantiator.NativeFieldInfoPtr_prefabProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderInstantiator>.NativeClassPtr, "prefabProvider");
			ProviderInstantiator.NativeFieldInfoPtr_pooledPrefabProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderInstantiator>.NativeClassPtr, "pooledPrefabProvider");
			ProviderInstantiator.NativeFieldInfoPtr_BasicPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderInstantiator>.NativeClassPtr, "BasicPrefab");
			ProviderInstantiator.NativeFieldInfoPtr_zeroOutItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderInstantiator>.NativeClassPtr, "zeroOutItem");
			ProviderInstantiator.NativeFieldInfoPtr_siblingIndexOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderInstantiator>.NativeClassPtr, "siblingIndexOffset");
			ProviderInstantiator.NativeFieldInfoPtr_numberOfInstantiationsPerFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderInstantiator>.NativeClassPtr, "numberOfInstantiationsPerFrame");
			ProviderInstantiator.NativeFieldInfoPtr_onInstantiateComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderInstantiator>.NativeClassPtr, "onInstantiateComplete");
			ProviderInstantiator.NativeMethodInfoPtr_get_OnInstantiateComplete_Public_get_UnityEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderInstantiator>.NativeClassPtr, 100665547);
			ProviderInstantiator.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderInstantiator>.NativeClassPtr, 100665548);
			ProviderInstantiator.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderInstantiator>.NativeClassPtr, 100665549);
			ProviderInstantiator.NativeMethodInfoPtr_CreateItems_Private_IEnumerator_List_1_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderInstantiator>.NativeClassPtr, 100665550);
			ProviderInstantiator.NativeMethodInfoPtr_GetPrefabForData_Public_SubscriptionProvider_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderInstantiator>.NativeClassPtr, 100665551);
			ProviderInstantiator.NativeMethodInfoPtr_getRendererInstance_Private_SubscriptionProvider_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderInstantiator>.NativeClassPtr, 100665552);
			ProviderInstantiator.NativeMethodInfoPtr_releaseRendererInstance_Private_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderInstantiator>.NativeClassPtr, 100665553);
			ProviderInstantiator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderInstantiator>.NativeClassPtr, 100665554);
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000F7E RID: 3966 RVA: 0x000514C0 File Offset: 0x0004F6C0
		public unsafe UnityEvent OnInstantiateComplete
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderInstantiator.NativeMethodInfoPtr_get_OnInstantiateComplete_Public_get_UnityEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr3) : null;
			}
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x00051500 File Offset: 0x0004F700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868352, XrefRangeEnd = 868360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderInstantiator.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x00051534 File Offset: 0x0004F734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868360, XrefRangeEnd = 868432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProviderInstantiator.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x00051570 File Offset: 0x0004F770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868432, XrefRangeEnd = 868438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CreateItems(List<DataComposition> newItems)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newItems);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderInstantiator.NativeMethodInfoPtr_CreateItems_Private_IEnumerator_List_1_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x000515C0 File Offset: 0x0004F7C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 868442, RefRangeEnd = 868443, XrefRangeStart = 868438, XrefRangeEnd = 868442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SubscriptionProvider GetPrefabForData(DataComposition data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderInstantiator.NativeMethodInfoPtr_GetPrefabForData_Public_SubscriptionProvider_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr3) : null;
			}
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x00051610 File Offset: 0x0004F810
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 868493, RefRangeEnd = 868494, XrefRangeStart = 868443, XrefRangeEnd = 868493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SubscriptionProvider getRendererInstance(DataComposition data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderInstantiator.NativeMethodInfoPtr_getRendererInstance_Private_SubscriptionProvider_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr3) : null;
			}
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x00051660 File Offset: 0x0004F860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868494, XrefRangeEnd = 868513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void releaseRendererInstance(DataComposition data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderInstantiator.NativeMethodInfoPtr_releaseRendererInstance_Private_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x000516A4 File Offset: 0x0004F8A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868513, XrefRangeEnd = 868542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProviderInstantiator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProviderInstantiator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderInstantiator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x000073F2 File Offset: 0x000055F2
		public ProviderInstantiator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000F87 RID: 3975 RVA: 0x000516E0 File Offset: 0x0004F8E0
		// (set) Token: 0x06000F88 RID: 3976 RVA: 0x000073FB File Offset: 0x000055FB
		public unsafe Dictionary<DataComposition, SubscriptionProvider> items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderInstantiator.NativeFieldInfoPtr_items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<DataComposition, SubscriptionProvider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderInstantiator.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000F89 RID: 3977 RVA: 0x00051710 File Offset: 0x0004F910
		// (set) Token: 0x06000F8A RID: 3978 RVA: 0x0000741A File Offset: 0x0000561A
		public unsafe HashSet<DataComposition> oldItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderInstantiator.NativeFieldInfoPtr_oldItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<DataComposition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderInstantiator.NativeFieldInfoPtr_oldItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000F8B RID: 3979 RVA: 0x00051740 File Offset: 0x0004F940
		// (set) Token: 0x06000F8C RID: 3980 RVA: 0x00007439 File Offset: 0x00005639
		public unsafe List<DataComposition> newItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderInstantiator.NativeFieldInfoPtr_newItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DataComposition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderInstantiator.NativeFieldInfoPtr_newItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000F8D RID: 3981 RVA: 0x00051770 File Offset: 0x0004F970
		// (set) Token: 0x06000F8E RID: 3982 RVA: 0x00007458 File Offset: 0x00005658
		public unsafe HashSet<DataComposition> missingItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderInstantiator.NativeFieldInfoPtr_missingItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<DataComposition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderInstantiator.NativeFieldInfoPtr_missingItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000F8F RID: 3983 RVA: 0x000517A0 File Offset: 0x0004F9A0
		// (set) Token: 0x06000F90 RID: 3984 RVA: 0x00007477 File Offset: 0x00005677
		public unsafe PrefabProvider prefabProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderInstantiator.NativeFieldInfoPtr_prefabProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefabProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderInstantiator.NativeFieldInfoPtr_prefabProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000F91 RID: 3985 RVA: 0x000517D0 File Offset: 0x0004F9D0
		// (set) Token: 0x06000F92 RID: 3986 RVA: 0x00007496 File Offset: 0x00005696
		public unsafe PooledPrefabProvider pooledPrefabProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderInstantiator.NativeFieldInfoPtr_pooledPrefabProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PooledPrefabProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderInstantiator.NativeFieldInfoPtr_pooledPrefabProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000F93 RID: 3987 RVA: 0x00051800 File Offset: 0x0004FA00
		// (set) Token: 0x06000F94 RID: 3988 RVA: 0x000074B5 File Offset: 0x000056B5
		public unsafe SubscriptionProvider BasicPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderInstantiator.NativeFieldInfoPtr_BasicPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderInstantiator.NativeFieldInfoPtr_BasicPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000F95 RID: 3989 RVA: 0x00051830 File Offset: 0x0004FA30
		// (set) Token: 0x06000F96 RID: 3990 RVA: 0x000074D4 File Offset: 0x000056D4
		public unsafe bool zeroOutItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderInstantiator.NativeFieldInfoPtr_zeroOutItem);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderInstantiator.NativeFieldInfoPtr_zeroOutItem)) = value;
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000F97 RID: 3991 RVA: 0x00051858 File Offset: 0x0004FA58
		// (set) Token: 0x06000F98 RID: 3992 RVA: 0x000074EF File Offset: 0x000056EF
		public unsafe int siblingIndexOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderInstantiator.NativeFieldInfoPtr_siblingIndexOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderInstantiator.NativeFieldInfoPtr_siblingIndexOffset)) = value;
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000F99 RID: 3993 RVA: 0x00051880 File Offset: 0x0004FA80
		// (set) Token: 0x06000F9A RID: 3994 RVA: 0x0000750A File Offset: 0x0000570A
		public unsafe int numberOfInstantiationsPerFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderInstantiator.NativeFieldInfoPtr_numberOfInstantiationsPerFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderInstantiator.NativeFieldInfoPtr_numberOfInstantiationsPerFrame)) = value;
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000F9B RID: 3995 RVA: 0x000518A8 File Offset: 0x0004FAA8
		// (set) Token: 0x06000F9C RID: 3996 RVA: 0x00007525 File Offset: 0x00005725
		public unsafe UnityEvent onInstantiateComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderInstantiator.NativeFieldInfoPtr_onInstantiateComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderInstantiator.NativeFieldInfoPtr_onInstantiateComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B11 RID: 2833
		private static readonly IntPtr NativeFieldInfoPtr_items;

		// Token: 0x04000B12 RID: 2834
		private static readonly IntPtr NativeFieldInfoPtr_oldItems;

		// Token: 0x04000B13 RID: 2835
		private static readonly IntPtr NativeFieldInfoPtr_newItems;

		// Token: 0x04000B14 RID: 2836
		private static readonly IntPtr NativeFieldInfoPtr_missingItems;

		// Token: 0x04000B15 RID: 2837
		private static readonly IntPtr NativeFieldInfoPtr_prefabProvider;

		// Token: 0x04000B16 RID: 2838
		private static readonly IntPtr NativeFieldInfoPtr_pooledPrefabProvider;

		// Token: 0x04000B17 RID: 2839
		private static readonly IntPtr NativeFieldInfoPtr_BasicPrefab;

		// Token: 0x04000B18 RID: 2840
		private static readonly IntPtr NativeFieldInfoPtr_zeroOutItem;

		// Token: 0x04000B19 RID: 2841
		private static readonly IntPtr NativeFieldInfoPtr_siblingIndexOffset;

		// Token: 0x04000B1A RID: 2842
		private static readonly IntPtr NativeFieldInfoPtr_numberOfInstantiationsPerFrame;

		// Token: 0x04000B1B RID: 2843
		private static readonly IntPtr NativeFieldInfoPtr_onInstantiateComplete;

		// Token: 0x04000B1C RID: 2844
		private static readonly IntPtr NativeMethodInfoPtr_get_OnInstantiateComplete_Public_get_UnityEvent_0;

		// Token: 0x04000B1D RID: 2845
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000B1E RID: 2846
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000B1F RID: 2847
		private static readonly IntPtr NativeMethodInfoPtr_CreateItems_Private_IEnumerator_List_1_DataComposition_0;

		// Token: 0x04000B20 RID: 2848
		private static readonly IntPtr NativeMethodInfoPtr_GetPrefabForData_Public_SubscriptionProvider_DataComposition_0;

		// Token: 0x04000B21 RID: 2849
		private static readonly IntPtr NativeMethodInfoPtr_getRendererInstance_Private_SubscriptionProvider_DataComposition_0;

		// Token: 0x04000B22 RID: 2850
		private static readonly IntPtr NativeMethodInfoPtr_releaseRendererInstance_Private_Void_DataComposition_0;

		// Token: 0x04000B23 RID: 2851
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002C0 RID: 704
		[ObfuscatedName("dwd.core.prefabs.prefabProvider.ProviderInstantiator+<CreateItems>d__15")]
		public sealed class _CreateItems_d__15 : Object
		{
			// Token: 0x060020DE RID: 8414 RVA: 0x00093F60 File Offset: 0x00092160
			// Note: this type is marked as 'beforefieldinit'.
			static _CreateItems_d__15()
			{
				Il2CppClassPointerStore<ProviderInstantiator._CreateItems_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProviderInstantiator>.NativeClassPtr, "<CreateItems>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProviderInstantiator._CreateItems_d__15>.NativeClassPtr);
				ProviderInstantiator._CreateItems_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderInstantiator._CreateItems_d__15>.NativeClassPtr, "<>1__state");
				ProviderInstantiator._CreateItems_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderInstantiator._CreateItems_d__15>.NativeClassPtr, "<>2__current");
				ProviderInstantiator._CreateItems_d__15.NativeFieldInfoPtr_newItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderInstantiator._CreateItems_d__15>.NativeClassPtr, "newItems");
				ProviderInstantiator._CreateItems_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderInstantiator._CreateItems_d__15>.NativeClassPtr, "<>4__this");
				ProviderInstantiator._CreateItems_d__15.NativeFieldInfoPtr__instantiationIndex_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderInstantiator._CreateItems_d__15>.NativeClassPtr, "<instantiationIndex>5__2");
				ProviderInstantiator._CreateItems_d__15.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProviderInstantiator._CreateItems_d__15>.NativeClassPtr, "<>7__wrap2");
				ProviderInstantiator._CreateItems_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderInstantiator._CreateItems_d__15>.NativeClassPtr, 100665555);
				ProviderInstantiator._CreateItems_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderInstantiator._CreateItems_d__15>.NativeClassPtr, 100665556);
				ProviderInstantiator._CreateItems_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderInstantiator._CreateItems_d__15>.NativeClassPtr, 100665557);
				ProviderInstantiator._CreateItems_d__15.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderInstantiator._CreateItems_d__15>.NativeClassPtr, 100665558);
				ProviderInstantiator._CreateItems_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderInstantiator._CreateItems_d__15>.NativeClassPtr, 100665559);
				ProviderInstantiator._CreateItems_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderInstantiator._CreateItems_d__15>.NativeClassPtr, 100665560);
				ProviderInstantiator._CreateItems_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProviderInstantiator._CreateItems_d__15>.NativeClassPtr, 100665561);
			}

			// Token: 0x060020DF RID: 8415 RVA: 0x00094090 File Offset: 0x00092290
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CreateItems_d__15(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProviderInstantiator._CreateItems_d__15>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderInstantiator._CreateItems_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060020E0 RID: 8416 RVA: 0x000940D8 File Offset: 0x000922D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868275, XrefRangeEnd = 868280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderInstantiator._CreateItems_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020E1 RID: 8417 RVA: 0x0009410C File Offset: 0x0009230C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868280, XrefRangeEnd = 868344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderInstantiator._CreateItems_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060020E2 RID: 8418 RVA: 0x00094148 File Offset: 0x00092348
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868344, XrefRangeEnd = 868347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderInstantiator._CreateItems_d__15.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170008F8 RID: 2296
			// (get) Token: 0x060020E3 RID: 8419 RVA: 0x0009417C File Offset: 0x0009237C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderInstantiator._CreateItems_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060020E4 RID: 8420 RVA: 0x000941BC File Offset: 0x000923BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868347, XrefRangeEnd = 868352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderInstantiator._CreateItems_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170008F9 RID: 2297
			// (get) Token: 0x060020E5 RID: 8421 RVA: 0x000941F0 File Offset: 0x000923F0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProviderInstantiator._CreateItems_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060020E6 RID: 8422 RVA: 0x0000E09F File Offset: 0x0000C29F
			public _CreateItems_d__15(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008F2 RID: 2290
			// (get) Token: 0x060020E7 RID: 8423 RVA: 0x00094230 File Offset: 0x00092430
			// (set) Token: 0x060020E8 RID: 8424 RVA: 0x0000E0A8 File Offset: 0x0000C2A8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderInstantiator._CreateItems_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderInstantiator._CreateItems_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008F3 RID: 2291
			// (get) Token: 0x060020E9 RID: 8425 RVA: 0x00094258 File Offset: 0x00092458
			// (set) Token: 0x060020EA RID: 8426 RVA: 0x0000E0C3 File Offset: 0x0000C2C3
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderInstantiator._CreateItems_d__15.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderInstantiator._CreateItems_d__15.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008F4 RID: 2292
			// (get) Token: 0x060020EB RID: 8427 RVA: 0x00094288 File Offset: 0x00092488
			// (set) Token: 0x060020EC RID: 8428 RVA: 0x0000E0E2 File Offset: 0x0000C2E2
			public unsafe List<DataComposition> newItems
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderInstantiator._CreateItems_d__15.NativeFieldInfoPtr_newItems);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DataComposition>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderInstantiator._CreateItems_d__15.NativeFieldInfoPtr_newItems), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008F5 RID: 2293
			// (get) Token: 0x060020ED RID: 8429 RVA: 0x000942B8 File Offset: 0x000924B8
			// (set) Token: 0x060020EE RID: 8430 RVA: 0x0000E101 File Offset: 0x0000C301
			public unsafe ProviderInstantiator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderInstantiator._CreateItems_d__15.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProviderInstantiator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderInstantiator._CreateItems_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008F6 RID: 2294
			// (get) Token: 0x060020EF RID: 8431 RVA: 0x000942E8 File Offset: 0x000924E8
			// (set) Token: 0x060020F0 RID: 8432 RVA: 0x0000E120 File Offset: 0x0000C320
			public unsafe int _instantiationIndex_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderInstantiator._CreateItems_d__15.NativeFieldInfoPtr__instantiationIndex_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderInstantiator._CreateItems_d__15.NativeFieldInfoPtr__instantiationIndex_5__2)) = value;
				}
			}

			// Token: 0x170008F7 RID: 2295
			// (get) Token: 0x060020F1 RID: 8433 RVA: 0x00094310 File Offset: 0x00092510
			// (set) Token: 0x060020F2 RID: 8434 RVA: 0x0000E13B File Offset: 0x0000C33B
			public List<DataComposition>.Enumerator __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderInstantiator._CreateItems_d__15.NativeFieldInfoPtr___7__wrap2);
					return new List<DataComposition>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<DataComposition>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProviderInstantiator._CreateItems_d__15.NativeFieldInfoPtr___7__wrap2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<DataComposition>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040016D5 RID: 5845
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040016D6 RID: 5846
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040016D7 RID: 5847
			private static readonly IntPtr NativeFieldInfoPtr_newItems;

			// Token: 0x040016D8 RID: 5848
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040016D9 RID: 5849
			private static readonly IntPtr NativeFieldInfoPtr__instantiationIndex_5__2;

			// Token: 0x040016DA RID: 5850
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x040016DB RID: 5851
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040016DC RID: 5852
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016DD RID: 5853
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040016DE RID: 5854
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040016DF RID: 5855
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040016E0 RID: 5856
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016E1 RID: 5857
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
