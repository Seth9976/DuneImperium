using System;
using Canis.json.events;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Networking.game;

namespace Networking.lobby.responses
{
	// Token: 0x020000A7 RID: 167
	public class LobbyLeft : NetworkMessageEvent
	{
		// Token: 0x0600056C RID: 1388 RVA: 0x00014720 File Offset: 0x00012920
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyLeft()
		{
			Il2CppClassPointerStore<LobbyLeft>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.lobby.responses", "LobbyLeft");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyLeft>.NativeClassPtr);
			LobbyLeft.NativeFieldInfoPtr_GameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyLeft>.NativeClassPtr, "GameID");
			LobbyLeft.NativeFieldInfoPtr_Account = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyLeft>.NativeClassPtr, "Account");
			LobbyLeft.NativeFieldInfoPtr_GameSession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyLeft>.NativeClassPtr, "GameSession");
			LobbyLeft.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyLeft>.NativeClassPtr, 100663642);
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x000147A0 File Offset: 0x000129A0
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LobbyLeft()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyLeft>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyLeft.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00005522 File Offset: 0x00003722
		public LobbyLeft(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x000147DC File Offset: 0x000129DC
		// (set) Token: 0x06000570 RID: 1392 RVA: 0x0000552B File Offset: 0x0000372B
		public unsafe GameID GameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyLeft.NativeFieldInfoPtr_GameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyLeft.NativeFieldInfoPtr_GameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x0001480C File Offset: 0x00012A0C
		// (set) Token: 0x06000572 RID: 1394 RVA: 0x0000554A File Offset: 0x0000374A
		public unsafe AccountIDUsername Account
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyLeft.NativeFieldInfoPtr_Account);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountIDUsername>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyLeft.NativeFieldInfoPtr_Account), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x0001483C File Offset: 0x00012A3C
		// (set) Token: 0x06000574 RID: 1396 RVA: 0x00005569 File Offset: 0x00003769
		public unsafe DWDPendingGameMetadata GameSession
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyLeft.NativeFieldInfoPtr_GameSession);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DWDPendingGameMetadata>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyLeft.NativeFieldInfoPtr_GameSession), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeFieldInfoPtr_GameID;

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeFieldInfoPtr_Account;

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeFieldInfoPtr_GameSession;

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
