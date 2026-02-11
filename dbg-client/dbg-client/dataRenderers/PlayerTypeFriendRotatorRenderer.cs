using System;
using boardgames.data;
using boardgames.menus;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dbg_client.dataRenderers
{
	// Token: 0x0200003F RID: 63
	public class PlayerTypeFriendRotatorRenderer : VersionedSubscriber<PlayerTypeData>
	{
		// Token: 0x06000278 RID: 632 RVA: 0x000256BC File Offset: 0x000238BC
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerTypeFriendRotatorRenderer()
		{
			Il2CppClassPointerStore<PlayerTypeFriendRotatorRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbg_client.dataRenderers", "PlayerTypeFriendRotatorRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerTypeFriendRotatorRenderer>.NativeClassPtr);
			PlayerTypeFriendRotatorRenderer.NativeFieldInfoPtr_FriendsRotator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTypeFriendRotatorRenderer>.NativeClassPtr, "FriendsRotator");
			PlayerTypeFriendRotatorRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTypeFriendRotatorRenderer>.NativeClassPtr, 100663697);
			PlayerTypeFriendRotatorRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTypeFriendRotatorRenderer>.NativeClassPtr, 100663698);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00025728 File Offset: 0x00023928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498856, XrefRangeEnd = 498863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerTypeFriendRotatorRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00025764 File Offset: 0x00023964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498863, XrefRangeEnd = 498866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerTypeFriendRotatorRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerTypeFriendRotatorRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTypeFriendRotatorRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00003113 File Offset: 0x00001313
		public PlayerTypeFriendRotatorRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600027C RID: 636 RVA: 0x000257A0 File Offset: 0x000239A0
		// (set) Token: 0x0600027D RID: 637 RVA: 0x0000311C File Offset: 0x0000131C
		public unsafe OnlineFriendsRotator FriendsRotator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTypeFriendRotatorRenderer.NativeFieldInfoPtr_FriendsRotator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OnlineFriendsRotator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTypeFriendRotatorRenderer.NativeFieldInfoPtr_FriendsRotator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeFieldInfoPtr_FriendsRotator;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
