using System;
using dwd.core.platform.providers;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Events;

namespace lib.canis.boardgames.src.notifications
{
	// Token: 0x02000039 RID: 57
	public class FriendInvitationResponder : PlatformDataResponder
	{
		// Token: 0x06000257 RID: 599 RVA: 0x00018748 File Offset: 0x00016948
		// Note: this type is marked as 'beforefieldinit'.
		static FriendInvitationResponder()
		{
			Il2CppClassPointerStore<FriendInvitationResponder>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lib.canis.boardgames.src.notifications", "FriendInvitationResponder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendInvitationResponder>.NativeClassPtr);
			FriendInvitationResponder.NativeFieldInfoPtr_OnReceivedInvitesChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendInvitationResponder>.NativeClassPtr, "OnReceivedInvitesChanged");
			FriendInvitationResponder.NativeMethodInfoPtr_get_Data_Protected_Virtual_get_PlatformData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendInvitationResponder>.NativeClassPtr, 100663726);
			FriendInvitationResponder.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendInvitationResponder>.NativeClassPtr, 100663727);
			FriendInvitationResponder.NativeMethodInfoPtr_platformDataDirtied_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendInvitationResponder>.NativeClassPtr, 100663728);
			FriendInvitationResponder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendInvitationResponder>.NativeClassPtr, 100663729);
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000258 RID: 600 RVA: 0x000187DC File Offset: 0x000169DC
		public unsafe override PlatformData Data
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendInvitationResponder.NativeMethodInfoPtr_get_Data_Protected_Virtual_get_PlatformData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlatformData>(intPtr3) : null;
			}
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00018828 File Offset: 0x00016A28
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendInvitationResponder.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0001885C File Offset: 0x00016A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984804, XrefRangeEnd = 984811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void platformDataDirtied()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendInvitationResponder.NativeMethodInfoPtr_platformDataDirtied_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00018898 File Offset: 0x00016A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984811, XrefRangeEnd = 984819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FriendInvitationResponder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendInvitationResponder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendInvitationResponder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00003041 File Offset: 0x00001241
		public FriendInvitationResponder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600025D RID: 605 RVA: 0x000188D4 File Offset: 0x00016AD4
		// (set) Token: 0x0600025E RID: 606 RVA: 0x0000304A File Offset: 0x0000124A
		public unsafe UnityEvent<bool> OnReceivedInvitesChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendInvitationResponder.NativeFieldInfoPtr_OnReceivedInvitesChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendInvitationResponder.NativeFieldInfoPtr_OnReceivedInvitesChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeFieldInfoPtr_OnReceivedInvitesChanged;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Protected_Virtual_get_PlatformData_0;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeMethodInfoPtr_platformDataDirtied_Protected_Virtual_Void_0;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
