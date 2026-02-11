using System;
using boardgames.data;
using dwd.core.prefabs.prefabProvider;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace boardgames.dataRenderers
{
	// Token: 0x0200014C RID: 332
	public class FriendsListInviteRenderer : VersionedSubscriber<FriendsInviteData>
	{
		// Token: 0x06000F10 RID: 3856 RVA: 0x0004D98C File Offset: 0x0004BB8C
		// Note: this type is marked as 'beforefieldinit'.
		static FriendsListInviteRenderer()
		{
			Il2CppClassPointerStore<FriendsListInviteRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.dataRenderers", "FriendsListInviteRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendsListInviteRenderer>.NativeClassPtr);
			FriendsListInviteRenderer.NativeFieldInfoPtr_providerInstantiator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsListInviteRenderer>.NativeClassPtr, "providerInstantiator");
			FriendsListInviteRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListInviteRenderer>.NativeClassPtr, 100665480);
			FriendsListInviteRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsListInviteRenderer>.NativeClassPtr, 100665481);
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x0004D9F8 File Offset: 0x0004BBF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512835, XrefRangeEnd = 512983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendsListInviteRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x0004DA34 File Offset: 0x0004BC34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512983, XrefRangeEnd = 512986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FriendsListInviteRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendsListInviteRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsListInviteRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x000093D4 File Offset: 0x000075D4
		public FriendsListInviteRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000F14 RID: 3860 RVA: 0x0004DA70 File Offset: 0x0004BC70
		// (set) Token: 0x06000F15 RID: 3861 RVA: 0x000093DD File Offset: 0x000075DD
		public unsafe ProviderInstantiator providerInstantiator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListInviteRenderer.NativeFieldInfoPtr_providerInstantiator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProviderInstantiator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsListInviteRenderer.NativeFieldInfoPtr_providerInstantiator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000949 RID: 2377
		private static readonly IntPtr NativeFieldInfoPtr_providerInstantiator;

		// Token: 0x0400094A RID: 2378
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400094B RID: 2379
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200036A RID: 874
		[ObfuscatedName("boardgames.dataRenderers.FriendsListInviteRenderer+<>O")]
		public static class __O : Object
		{
			// Token: 0x06002937 RID: 10551 RVA: 0x00015475 File Offset: 0x00013675
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<FriendsListInviteRenderer.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FriendsListInviteRenderer>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendsListInviteRenderer.__O>.NativeClassPtr);
				FriendsListInviteRenderer.__O.NativeFieldInfoPtr__0___Compare = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsListInviteRenderer.__O>.NativeClassPtr, "<0>__Compare");
			}

			// Token: 0x06002938 RID: 10552 RVA: 0x000154A9 File Offset: 0x000136A9
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B96 RID: 2966
			// (get) Token: 0x06002939 RID: 10553 RVA: 0x000A3E9C File Offset: 0x000A209C
			// (set) Token: 0x0600293A RID: 10554 RVA: 0x000154B2 File Offset: 0x000136B2
			public unsafe static Comparison<NamedComposition> _0___Compare
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FriendsListInviteRenderer.__O.NativeFieldInfoPtr__0___Compare, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<NamedComposition>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FriendsListInviteRenderer.__O.NativeFieldInfoPtr__0___Compare, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040019C6 RID: 6598
			private static readonly IntPtr NativeFieldInfoPtr__0___Compare;
		}
	}
}
