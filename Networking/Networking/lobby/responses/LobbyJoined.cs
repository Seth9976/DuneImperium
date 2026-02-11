using System;
using Canis.json.events;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Networking.game;

namespace Networking.lobby.responses
{
	// Token: 0x020000A5 RID: 165
	public class LobbyJoined : NetworkMessageEvent
	{
		// Token: 0x06000560 RID: 1376 RVA: 0x0001455C File Offset: 0x0001275C
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyJoined()
		{
			Il2CppClassPointerStore<LobbyJoined>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.lobby.responses", "LobbyJoined");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyJoined>.NativeClassPtr);
			LobbyJoined.NativeFieldInfoPtr_GameSession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyJoined>.NativeClassPtr, "GameSession");
			LobbyJoined.NativeFieldInfoPtr_Account = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyJoined>.NativeClassPtr, "Account");
			LobbyJoined.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyJoined>.NativeClassPtr, 100663640);
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x000145C8 File Offset: 0x000127C8
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LobbyJoined()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyJoined>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyJoined.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x000054B3 File Offset: 0x000036B3
		public LobbyJoined(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x00014604 File Offset: 0x00012804
		// (set) Token: 0x06000564 RID: 1380 RVA: 0x000054BC File Offset: 0x000036BC
		public unsafe DWDPendingGameMetadata GameSession
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyJoined.NativeFieldInfoPtr_GameSession);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DWDPendingGameMetadata>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyJoined.NativeFieldInfoPtr_GameSession), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000565 RID: 1381 RVA: 0x00014634 File Offset: 0x00012834
		// (set) Token: 0x06000566 RID: 1382 RVA: 0x000054DB File Offset: 0x000036DB
		public unsafe AccountIDUsernameMetadata Account
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyJoined.NativeFieldInfoPtr_Account);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountIDUsernameMetadata>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyJoined.NativeFieldInfoPtr_Account), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeFieldInfoPtr_GameSession;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeFieldInfoPtr_Account;

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
