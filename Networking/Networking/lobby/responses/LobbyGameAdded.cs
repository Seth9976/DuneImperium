using System;
using Canis.json.events;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Networking.game;

namespace Networking.lobby.responses
{
	// Token: 0x0200009F RID: 159
	public class LobbyGameAdded : NetworkMessageEvent
	{
		// Token: 0x06000536 RID: 1334 RVA: 0x00013F44 File Offset: 0x00012144
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyGameAdded()
		{
			Il2CppClassPointerStore<LobbyGameAdded>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.lobby.responses", "LobbyGameAdded");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyGameAdded>.NativeClassPtr);
			LobbyGameAdded.NativeFieldInfoPtr_GameSession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyGameAdded>.NativeClassPtr, "GameSession");
			LobbyGameAdded.NativeFieldInfoPtr_Account = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyGameAdded>.NativeClassPtr, "Account");
			LobbyGameAdded.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyGameAdded>.NativeClassPtr, 100663634);
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x00013FB0 File Offset: 0x000121B0
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LobbyGameAdded()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyGameAdded>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyGameAdded.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x00005315 File Offset: 0x00003515
		public LobbyGameAdded(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x00013FEC File Offset: 0x000121EC
		// (set) Token: 0x0600053A RID: 1338 RVA: 0x0000531E File Offset: 0x0000351E
		public unsafe DWDPendingGameMetadata GameSession
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyGameAdded.NativeFieldInfoPtr_GameSession);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DWDPendingGameMetadata>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyGameAdded.NativeFieldInfoPtr_GameSession), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x0001401C File Offset: 0x0001221C
		// (set) Token: 0x0600053C RID: 1340 RVA: 0x0000533D File Offset: 0x0000353D
		public unsafe AccountIDUsernameMetadata Account
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyGameAdded.NativeFieldInfoPtr_Account);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountIDUsernameMetadata>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyGameAdded.NativeFieldInfoPtr_Account), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002CA RID: 714
		private static readonly IntPtr NativeFieldInfoPtr_GameSession;

		// Token: 0x040002CB RID: 715
		private static readonly IntPtr NativeFieldInfoPtr_Account;

		// Token: 0x040002CC RID: 716
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
