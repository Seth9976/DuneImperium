using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace dwd.core.loader.caching
{
	// Token: 0x02000183 RID: 387
	public class AssetCacheProvider : MonoBehaviour
	{
		// Token: 0x060015F4 RID: 5620 RVA: 0x0006C524 File Offset: 0x0006A724
		// Note: this type is marked as 'beforefieldinit'.
		static AssetCacheProvider()
		{
			Il2CppClassPointerStore<AssetCacheProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.loader.caching", "AssetCacheProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetCacheProvider>.NativeClassPtr);
			AssetCacheProvider.NativeFieldInfoPtr_requesters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetCacheProvider>.NativeClassPtr, "requesters");
			AssetCacheProvider.NativeFieldInfoPtr_PoolSizeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetCacheProvider>.NativeClassPtr, "PoolSizeMax");
			AssetCacheProvider.NativeFieldInfoPtr_PoolSizeCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetCacheProvider>.NativeClassPtr, "PoolSizeCapacity");
			AssetCacheProvider.NativeFieldInfoPtr_PoolCacheMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetCacheProvider>.NativeClassPtr, "PoolCacheMax");
			AssetCacheProvider.NativeFieldInfoPtr_PoolCacheCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetCacheProvider>.NativeClassPtr, "PoolCacheCapacity");
			AssetCacheProvider.NativeFieldInfoPtr_showRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetCacheProvider>.NativeClassPtr, "showRequests");
			AssetCacheProvider.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetCacheProvider>.NativeClassPtr, 100666659);
			AssetCacheProvider.NativeMethodInfoPtr_GetReference_Public_IAssetReference_1_T_IReferenceTracker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetCacheProvider>.NativeClassPtr, 100666660);
			AssetCacheProvider.NativeMethodInfoPtr_GetSpriteReference_Public_ISpriteReference_IReferenceTracker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetCacheProvider>.NativeClassPtr, 100666661);
			AssetCacheProvider.NativeMethodInfoPtr_GetSpriteAtlasReference_Public_ISpriteReference_IReferenceTracker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetCacheProvider>.NativeClassPtr, 100666662);
			AssetCacheProvider.NativeMethodInfoPtr_GetSingleSpriteReference_Public_ISpriteReference_IReferenceTracker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetCacheProvider>.NativeClassPtr, 100666663);
			AssetCacheProvider.NativeMethodInfoPtr_GetPrefabReference_Public_IAssetReference_1_T_Transform_Boolean_IReferenceTracker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetCacheProvider>.NativeClassPtr, 100666664);
			AssetCacheProvider.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetCacheProvider>.NativeClassPtr, 100666665);
			AssetCacheProvider.NativeMethodInfoPtr_RequesterData_Public_IEnumerable_1_IAssetReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetCacheProvider>.NativeClassPtr, 100666666);
			AssetCacheProvider.NativeMethodInfoPtr_Cleanup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetCacheProvider>.NativeClassPtr, 100666667);
			AssetCacheProvider.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetCacheProvider>.NativeClassPtr, 100666668);
			AssetCacheProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetCacheProvider>.NativeClassPtr, 100666669);
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x0006C6A8 File Offset: 0x0006A8A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878043, XrefRangeEnd = 878056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetCacheProvider.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x0006C6DC File Offset: 0x0006A8DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 878065, RefRangeEnd = 878067, XrefRangeStart = 878056, XrefRangeEnd = 878065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAssetReference<T> GetReference<T>(IReferenceTracker source) where T : global::UnityEngine.Object
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetCacheProvider.MethodInfoStoreGeneric_GetReference_Public_IAssetReference_1_T_IReferenceTracker_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAssetReference<T>>(intPtr3) : null;
			}
		}

		// Token: 0x060015F7 RID: 5623 RVA: 0x0006C72C File Offset: 0x0006A92C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 878074, RefRangeEnd = 878076, XrefRangeStart = 878067, XrefRangeEnd = 878074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISpriteReference GetSpriteReference(IReferenceTracker source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetCacheProvider.NativeMethodInfoPtr_GetSpriteReference_Public_ISpriteReference_IReferenceTracker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISpriteReference>(intPtr3) : null;
			}
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x0006C77C File Offset: 0x0006A97C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 878083, RefRangeEnd = 878085, XrefRangeStart = 878076, XrefRangeEnd = 878083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISpriteReference GetSpriteAtlasReference(IReferenceTracker source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetCacheProvider.NativeMethodInfoPtr_GetSpriteAtlasReference_Public_ISpriteReference_IReferenceTracker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISpriteReference>(intPtr3) : null;
			}
		}

		// Token: 0x060015F9 RID: 5625 RVA: 0x0006C7CC File Offset: 0x0006A9CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 878092, RefRangeEnd = 878094, XrefRangeStart = 878085, XrefRangeEnd = 878092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISpriteReference GetSingleSpriteReference(IReferenceTracker source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetCacheProvider.NativeMethodInfoPtr_GetSingleSpriteReference_Public_ISpriteReference_IReferenceTracker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISpriteReference>(intPtr3) : null;
			}
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x0006C81C File Offset: 0x0006AA1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 878103, RefRangeEnd = 878105, XrefRangeStart = 878094, XrefRangeEnd = 878103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAssetReference<T> GetPrefabReference<T>(Transform transform, bool worldSpace, IReferenceTracker refTracker) where T : global::UnityEngine.Object
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldSpace;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(refTracker);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetCacheProvider.MethodInfoStoreGeneric_GetPrefabReference_Public_IAssetReference_1_T_Transform_Boolean_IReferenceTracker_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAssetReference<T>>(intPtr3) : null;
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x0006C88C File Offset: 0x0006AA8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878105, XrefRangeEnd = 878120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetCacheProvider.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x0006C8C0 File Offset: 0x0006AAC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878120, XrefRangeEnd = 878126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<IAssetReference> RequesterData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetCacheProvider.NativeMethodInfoPtr_RequesterData_Public_IEnumerable_1_IAssetReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAssetReference>>(intPtr3) : null;
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x0006C900 File Offset: 0x0006AB00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 878146, RefRangeEnd = 878147, XrefRangeStart = 878126, XrefRangeEnd = 878146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetCacheProvider.NativeMethodInfoPtr_Cleanup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x0006C934 File Offset: 0x0006AB34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878147, XrefRangeEnd = 878148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetCacheProvider.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x0006C968 File Offset: 0x0006AB68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878148, XrefRangeEnd = 878156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetCacheProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetCacheProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetCacheProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x0000996D File Offset: 0x00007B6D
		public AssetCacheProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06001601 RID: 5633 RVA: 0x0006C9A4 File Offset: 0x0006ABA4
		// (set) Token: 0x06001602 RID: 5634 RVA: 0x00009976 File Offset: 0x00007B76
		public unsafe List<IDisposableAssetReference> requesters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetCacheProvider.NativeFieldInfoPtr_requesters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IDisposableAssetReference>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetCacheProvider.NativeFieldInfoPtr_requesters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06001603 RID: 5635 RVA: 0x0006C9D4 File Offset: 0x0006ABD4
		// (set) Token: 0x06001604 RID: 5636 RVA: 0x00009995 File Offset: 0x00007B95
		public unsafe int PoolSizeMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetCacheProvider.NativeFieldInfoPtr_PoolSizeMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetCacheProvider.NativeFieldInfoPtr_PoolSizeMax)) = value;
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06001605 RID: 5637 RVA: 0x0006C9FC File Offset: 0x0006ABFC
		// (set) Token: 0x06001606 RID: 5638 RVA: 0x000099B0 File Offset: 0x00007BB0
		public unsafe int PoolSizeCapacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetCacheProvider.NativeFieldInfoPtr_PoolSizeCapacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetCacheProvider.NativeFieldInfoPtr_PoolSizeCapacity)) = value;
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06001607 RID: 5639 RVA: 0x0006CA24 File Offset: 0x0006AC24
		// (set) Token: 0x06001608 RID: 5640 RVA: 0x000099CB File Offset: 0x00007BCB
		public unsafe int PoolCacheMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetCacheProvider.NativeFieldInfoPtr_PoolCacheMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetCacheProvider.NativeFieldInfoPtr_PoolCacheMax)) = value;
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06001609 RID: 5641 RVA: 0x0006CA4C File Offset: 0x0006AC4C
		// (set) Token: 0x0600160A RID: 5642 RVA: 0x000099E6 File Offset: 0x00007BE6
		public unsafe int PoolCacheCapacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetCacheProvider.NativeFieldInfoPtr_PoolCacheCapacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetCacheProvider.NativeFieldInfoPtr_PoolCacheCapacity)) = value;
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x0600160B RID: 5643 RVA: 0x0006CA74 File Offset: 0x0006AC74
		// (set) Token: 0x0600160C RID: 5644 RVA: 0x00009A01 File Offset: 0x00007C01
		public unsafe bool showRequests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetCacheProvider.NativeFieldInfoPtr_showRequests);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetCacheProvider.NativeFieldInfoPtr_showRequests)) = value;
			}
		}

		// Token: 0x04000F9C RID: 3996
		private static readonly IntPtr NativeFieldInfoPtr_requesters;

		// Token: 0x04000F9D RID: 3997
		private static readonly IntPtr NativeFieldInfoPtr_PoolSizeMax;

		// Token: 0x04000F9E RID: 3998
		private static readonly IntPtr NativeFieldInfoPtr_PoolSizeCapacity;

		// Token: 0x04000F9F RID: 3999
		private static readonly IntPtr NativeFieldInfoPtr_PoolCacheMax;

		// Token: 0x04000FA0 RID: 4000
		private static readonly IntPtr NativeFieldInfoPtr_PoolCacheCapacity;

		// Token: 0x04000FA1 RID: 4001
		private static readonly IntPtr NativeFieldInfoPtr_showRequests;

		// Token: 0x04000FA2 RID: 4002
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000FA3 RID: 4003
		private static readonly IntPtr NativeMethodInfoPtr_GetReference_Public_IAssetReference_1_T_IReferenceTracker_0;

		// Token: 0x04000FA4 RID: 4004
		private static readonly IntPtr NativeMethodInfoPtr_GetSpriteReference_Public_ISpriteReference_IReferenceTracker_0;

		// Token: 0x04000FA5 RID: 4005
		private static readonly IntPtr NativeMethodInfoPtr_GetSpriteAtlasReference_Public_ISpriteReference_IReferenceTracker_0;

		// Token: 0x04000FA6 RID: 4006
		private static readonly IntPtr NativeMethodInfoPtr_GetSingleSpriteReference_Public_ISpriteReference_IReferenceTracker_0;

		// Token: 0x04000FA7 RID: 4007
		private static readonly IntPtr NativeMethodInfoPtr_GetPrefabReference_Public_IAssetReference_1_T_Transform_Boolean_IReferenceTracker_0;

		// Token: 0x04000FA8 RID: 4008
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04000FA9 RID: 4009
		private static readonly IntPtr NativeMethodInfoPtr_RequesterData_Public_IEnumerable_1_IAssetReference_0;

		// Token: 0x04000FAA RID: 4010
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Private_Void_0;

		// Token: 0x04000FAB RID: 4011
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000FAC RID: 4012
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000321 RID: 801
		[ObfuscatedName("dwd.core.loader.caching.AssetCacheProvider+<RequesterData>d__13")]
		public sealed class _RequesterData_d__13 : global::Il2CppSystem.Object
		{
			// Token: 0x0600247D RID: 9341 RVA: 0x0009E118 File Offset: 0x0009C318
			// Note: this type is marked as 'beforefieldinit'.
			static _RequesterData_d__13()
			{
				Il2CppClassPointerStore<AssetCacheProvider._RequesterData_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetCacheProvider>.NativeClassPtr, "<RequesterData>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetCacheProvider._RequesterData_d__13>.NativeClassPtr);
				AssetCacheProvider._RequesterData_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetCacheProvider._RequesterData_d__13>.NativeClassPtr, "<>1__state");
				AssetCacheProvider._RequesterData_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetCacheProvider._RequesterData_d__13>.NativeClassPtr, "<>2__current");
				AssetCacheProvider._RequesterData_d__13.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetCacheProvider._RequesterData_d__13>.NativeClassPtr, "<>l__initialThreadId");
				AssetCacheProvider._RequesterData_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetCacheProvider._RequesterData_d__13>.NativeClassPtr, "<>4__this");
				AssetCacheProvider._RequesterData_d__13.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetCacheProvider._RequesterData_d__13>.NativeClassPtr, "<>7__wrap1");
				AssetCacheProvider._RequesterData_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetCacheProvider._RequesterData_d__13>.NativeClassPtr, 100666670);
				AssetCacheProvider._RequesterData_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetCacheProvider._RequesterData_d__13>.NativeClassPtr, 100666671);
				AssetCacheProvider._RequesterData_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetCacheProvider._RequesterData_d__13>.NativeClassPtr, 100666672);
				AssetCacheProvider._RequesterData_d__13.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetCacheProvider._RequesterData_d__13>.NativeClassPtr, 100666673);
				AssetCacheProvider._RequesterData_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_dwd_core_loader_caching_IAssetReference__get_Current_Private_Virtual_Final_New_get_IAssetReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetCacheProvider._RequesterData_d__13>.NativeClassPtr, 100666674);
				AssetCacheProvider._RequesterData_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetCacheProvider._RequesterData_d__13>.NativeClassPtr, 100666675);
				AssetCacheProvider._RequesterData_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetCacheProvider._RequesterData_d__13>.NativeClassPtr, 100666676);
				AssetCacheProvider._RequesterData_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_dwd_core_loader_caching_IAssetReference__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IAssetReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetCacheProvider._RequesterData_d__13>.NativeClassPtr, 100666677);
				AssetCacheProvider._RequesterData_d__13.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetCacheProvider._RequesterData_d__13>.NativeClassPtr, 100666678);
			}

			// Token: 0x0600247E RID: 9342 RVA: 0x0009E25C File Offset: 0x0009C45C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RequesterData_d__13(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetCacheProvider._RequesterData_d__13>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetCacheProvider._RequesterData_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600247F RID: 9343 RVA: 0x0009E2A4 File Offset: 0x0009C4A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878012, XrefRangeEnd = 878017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetCacheProvider._RequesterData_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002480 RID: 9344 RVA: 0x0009E2D8 File Offset: 0x0009C4D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878017, XrefRangeEnd = 878033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetCacheProvider._RequesterData_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002481 RID: 9345 RVA: 0x0009E314 File Offset: 0x0009C514
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878033, XrefRangeEnd = 878036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetCacheProvider._RequesterData_d__13.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A20 RID: 2592
			// (get) Token: 0x06002482 RID: 9346 RVA: 0x0009E348 File Offset: 0x0009C548
			public unsafe IAssetReference System.Collections.Generic.IEnumerator<dwd.core.loader.caching.IAssetReference>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetCacheProvider._RequesterData_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_dwd_core_loader_caching_IAssetReference__get_Current_Private_Virtual_Final_New_get_IAssetReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAssetReference>(intPtr3) : null;
				}
			}

			// Token: 0x06002483 RID: 9347 RVA: 0x0009E388 File Offset: 0x0009C588
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878036, XrefRangeEnd = 878041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetCacheProvider._RequesterData_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A21 RID: 2593
			// (get) Token: 0x06002484 RID: 9348 RVA: 0x0009E3BC File Offset: 0x0009C5BC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetCacheProvider._RequesterData_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002485 RID: 9349 RVA: 0x0009E3FC File Offset: 0x0009C5FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878041, XrefRangeEnd = 878043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<IAssetReference> System_Collections_Generic_IEnumerable_dwd_core_loader_caching_IAssetReference__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetCacheProvider._RequesterData_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_dwd_core_loader_caching_IAssetReference__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IAssetReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<IAssetReference>>(intPtr3) : null;
			}

			// Token: 0x06002486 RID: 9350 RVA: 0x0009E43C File Offset: 0x0009C63C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetCacheProvider._RequesterData_d__13.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002487 RID: 9351 RVA: 0x000105AC File Offset: 0x0000E7AC
			public _RequesterData_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A1B RID: 2587
			// (get) Token: 0x06002488 RID: 9352 RVA: 0x0009E47C File Offset: 0x0009C67C
			// (set) Token: 0x06002489 RID: 9353 RVA: 0x000105B5 File Offset: 0x0000E7B5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetCacheProvider._RequesterData_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetCacheProvider._RequesterData_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A1C RID: 2588
			// (get) Token: 0x0600248A RID: 9354 RVA: 0x0009E4A4 File Offset: 0x0009C6A4
			// (set) Token: 0x0600248B RID: 9355 RVA: 0x000105D0 File Offset: 0x0000E7D0
			public unsafe IAssetReference __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetCacheProvider._RequesterData_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAssetReference>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetCacheProvider._RequesterData_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A1D RID: 2589
			// (get) Token: 0x0600248C RID: 9356 RVA: 0x0009E4D4 File Offset: 0x0009C6D4
			// (set) Token: 0x0600248D RID: 9357 RVA: 0x000105EF File Offset: 0x0000E7EF
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetCacheProvider._RequesterData_d__13.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetCacheProvider._RequesterData_d__13.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000A1E RID: 2590
			// (get) Token: 0x0600248E RID: 9358 RVA: 0x0009E4FC File Offset: 0x0009C6FC
			// (set) Token: 0x0600248F RID: 9359 RVA: 0x0001060A File Offset: 0x0000E80A
			public unsafe AssetCacheProvider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetCacheProvider._RequesterData_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetCacheProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetCacheProvider._RequesterData_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A1F RID: 2591
			// (get) Token: 0x06002490 RID: 9360 RVA: 0x0009E52C File Offset: 0x0009C72C
			// (set) Token: 0x06002491 RID: 9361 RVA: 0x00010629 File Offset: 0x0000E829
			public List<IDisposableAssetReference>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetCacheProvider._RequesterData_d__13.NativeFieldInfoPtr___7__wrap1);
					return new List<IDisposableAssetReference>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<IDisposableAssetReference>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetCacheProvider._RequesterData_d__13.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<IDisposableAssetReference>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040018DA RID: 6362
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040018DB RID: 6363
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040018DC RID: 6364
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040018DD RID: 6365
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040018DE RID: 6366
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040018DF RID: 6367
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040018E0 RID: 6368
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040018E1 RID: 6369
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040018E2 RID: 6370
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040018E3 RID: 6371
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_dwd_core_loader_caching_IAssetReference__get_Current_Private_Virtual_Final_New_get_IAssetReference_0;

			// Token: 0x040018E4 RID: 6372
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040018E5 RID: 6373
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040018E6 RID: 6374
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_dwd_core_loader_caching_IAssetReference__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IAssetReference_0;

			// Token: 0x040018E7 RID: 6375
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000322 RID: 802
		private sealed class MethodInfoStoreGeneric_GetReference_Public_IAssetReference_1_T_IReferenceTracker_0<T>
		{
			// Token: 0x040018E8 RID: 6376
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AssetCacheProvider.NativeMethodInfoPtr_GetReference_Public_IAssetReference_1_T_IReferenceTracker_0, Il2CppClassPointerStore<AssetCacheProvider>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000323 RID: 803
		private sealed class MethodInfoStoreGeneric_GetPrefabReference_Public_IAssetReference_1_T_Transform_Boolean_IReferenceTracker_0<T>
		{
			// Token: 0x040018E9 RID: 6377
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AssetCacheProvider.NativeMethodInfoPtr_GetPrefabReference_Public_IAssetReference_1_T_Transform_Boolean_IReferenceTracker_0, Il2CppClassPointerStore<AssetCacheProvider>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
