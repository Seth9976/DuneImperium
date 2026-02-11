using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.prefabs.prefabProvider
{
	// Token: 0x0200010D RID: 269
	public sealed class AlternatingPrefabProvider : PrefabProvider
	{
		// Token: 0x06000F58 RID: 3928 RVA: 0x00050BFC File Offset: 0x0004EDFC
		// Note: this type is marked as 'beforefieldinit'.
		static AlternatingPrefabProvider()
		{
			Il2CppClassPointerStore<AlternatingPrefabProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.prefabs.prefabProvider", "AlternatingPrefabProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AlternatingPrefabProvider>.NativeClassPtr);
			AlternatingPrefabProvider.NativeFieldInfoPtr_firstPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlternatingPrefabProvider>.NativeClassPtr, "firstPrefab");
			AlternatingPrefabProvider.NativeFieldInfoPtr_secondPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlternatingPrefabProvider>.NativeClassPtr, "secondPrefab");
			AlternatingPrefabProvider.NativeFieldInfoPtr_firstPrefabLast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlternatingPrefabProvider>.NativeClassPtr, "firstPrefabLast");
			AlternatingPrefabProvider.NativeMethodInfoPtr_GetPrefabForData_Public_Virtual_SubscriptionProvider_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlternatingPrefabProvider>.NativeClassPtr, 100665536);
			AlternatingPrefabProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlternatingPrefabProvider>.NativeClassPtr, 100665537);
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x00050C90 File Offset: 0x0004EE90
		[CallerCount(0)]
		public unsafe override SubscriptionProvider GetPrefabForData(DataComposition data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AlternatingPrefabProvider.NativeMethodInfoPtr_GetPrefabForData_Public_Virtual_SubscriptionProvider_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr3) : null;
			}
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x00050CE0 File Offset: 0x0004EEE0
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AlternatingPrefabProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AlternatingPrefabProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AlternatingPrefabProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x000072C3 File Offset: 0x000054C3
		public AlternatingPrefabProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000F5C RID: 3932 RVA: 0x00050D1C File Offset: 0x0004EF1C
		// (set) Token: 0x06000F5D RID: 3933 RVA: 0x000072CC File Offset: 0x000054CC
		public unsafe SubscriptionProvider firstPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlternatingPrefabProvider.NativeFieldInfoPtr_firstPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlternatingPrefabProvider.NativeFieldInfoPtr_firstPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000F5E RID: 3934 RVA: 0x00050D4C File Offset: 0x0004EF4C
		// (set) Token: 0x06000F5F RID: 3935 RVA: 0x000072EB File Offset: 0x000054EB
		public unsafe SubscriptionProvider secondPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlternatingPrefabProvider.NativeFieldInfoPtr_secondPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlternatingPrefabProvider.NativeFieldInfoPtr_secondPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000F60 RID: 3936 RVA: 0x00050D7C File Offset: 0x0004EF7C
		// (set) Token: 0x06000F61 RID: 3937 RVA: 0x0000730A File Offset: 0x0000550A
		public unsafe bool firstPrefabLast
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlternatingPrefabProvider.NativeFieldInfoPtr_firstPrefabLast);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AlternatingPrefabProvider.NativeFieldInfoPtr_firstPrefabLast)) = value;
			}
		}

		// Token: 0x04000AFD RID: 2813
		private static readonly IntPtr NativeFieldInfoPtr_firstPrefab;

		// Token: 0x04000AFE RID: 2814
		private static readonly IntPtr NativeFieldInfoPtr_secondPrefab;

		// Token: 0x04000AFF RID: 2815
		private static readonly IntPtr NativeFieldInfoPtr_firstPrefabLast;

		// Token: 0x04000B00 RID: 2816
		private static readonly IntPtr NativeMethodInfoPtr_GetPrefabForData_Public_Virtual_SubscriptionProvider_DataComposition_0;

		// Token: 0x04000B01 RID: 2817
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
