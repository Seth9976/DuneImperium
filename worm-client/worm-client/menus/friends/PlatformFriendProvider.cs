using System;
using dwd.core.data.composition;
using dwd.core.prefabs.prefabProvider;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm_client.menus.friends
{
	// Token: 0x0200002F RID: 47
	public class PlatformFriendProvider : PrefabProvider
	{
		// Token: 0x0600020A RID: 522 RVA: 0x0001F5AC File Offset: 0x0001D7AC
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformFriendProvider()
		{
			Il2CppClassPointerStore<PlatformFriendProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm_client.menus.friends", "PlatformFriendProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformFriendProvider>.NativeClassPtr);
			PlatformFriendProvider.NativeFieldInfoPtr__BasicPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformFriendProvider>.NativeClassPtr, "_BasicPrefab");
			PlatformFriendProvider.NativeFieldInfoPtr__FederatedPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformFriendProvider>.NativeClassPtr, "_FederatedPrefab");
			PlatformFriendProvider.NativeMethodInfoPtr_GetPrefabForData_Public_Virtual_SubscriptionProvider_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformFriendProvider>.NativeClassPtr, 100663663);
			PlatformFriendProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformFriendProvider>.NativeClassPtr, 100663664);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0001F62C File Offset: 0x0001D82C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689878, XrefRangeEnd = 689881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SubscriptionProvider GetPrefabForData(DataComposition data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformFriendProvider.NativeMethodInfoPtr_GetPrefabForData_Public_Virtual_SubscriptionProvider_DataComposition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr3) : null;
			}
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0001F688 File Offset: 0x0001D888
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformFriendProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformFriendProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformFriendProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002F14 File Offset: 0x00001114
		public PlatformFriendProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600020E RID: 526 RVA: 0x0001F6C4 File Offset: 0x0001D8C4
		// (set) Token: 0x0600020F RID: 527 RVA: 0x00002F1D File Offset: 0x0000111D
		public unsafe SubscriptionProvider _BasicPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformFriendProvider.NativeFieldInfoPtr__BasicPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformFriendProvider.NativeFieldInfoPtr__BasicPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000210 RID: 528 RVA: 0x0001F6F4 File Offset: 0x0001D8F4
		// (set) Token: 0x06000211 RID: 529 RVA: 0x00002F3C File Offset: 0x0000113C
		public unsafe SubscriptionProvider _FederatedPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformFriendProvider.NativeFieldInfoPtr__FederatedPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformFriendProvider.NativeFieldInfoPtr__FederatedPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeFieldInfoPtr__BasicPrefab;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeFieldInfoPtr__FederatedPrefab;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr_GetPrefabForData_Public_Virtual_SubscriptionProvider_DataComposition_0;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
