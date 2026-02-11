using System;
using Canis.json.events;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Networking.lobby.responses
{
	// Token: 0x020000A1 RID: 161
	public class LobbyGamePlayerMetadataUpdated : NetworkMessageEvent
	{
		// Token: 0x06000548 RID: 1352 RVA: 0x000141C4 File Offset: 0x000123C4
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyGamePlayerMetadataUpdated()
		{
			Il2CppClassPointerStore<LobbyGamePlayerMetadataUpdated>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.lobby.responses", "LobbyGamePlayerMetadataUpdated");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyGamePlayerMetadataUpdated>.NativeClassPtr);
			LobbyGamePlayerMetadataUpdated.NativeFieldInfoPtr_GameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyGamePlayerMetadataUpdated>.NativeClassPtr, "GameID");
			LobbyGamePlayerMetadataUpdated.NativeFieldInfoPtr_AccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyGamePlayerMetadataUpdated>.NativeClassPtr, "AccountID");
			LobbyGamePlayerMetadataUpdated.NativeFieldInfoPtr_Metadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyGamePlayerMetadataUpdated>.NativeClassPtr, "Metadata");
			LobbyGamePlayerMetadataUpdated.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyGamePlayerMetadataUpdated>.NativeClassPtr, 100663636);
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00014244 File Offset: 0x00012444
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LobbyGamePlayerMetadataUpdated()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyGamePlayerMetadataUpdated>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyGamePlayerMetadataUpdated.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x000053D5 File Offset: 0x000035D5
		public LobbyGamePlayerMetadataUpdated(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x00014280 File Offset: 0x00012480
		// (set) Token: 0x0600054C RID: 1356 RVA: 0x000053DE File Offset: 0x000035DE
		public unsafe GameID GameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyGamePlayerMetadataUpdated.NativeFieldInfoPtr_GameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyGamePlayerMetadataUpdated.NativeFieldInfoPtr_GameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x000142B0 File Offset: 0x000124B0
		// (set) Token: 0x0600054E RID: 1358 RVA: 0x000053FD File Offset: 0x000035FD
		public unsafe AccountID AccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyGamePlayerMetadataUpdated.NativeFieldInfoPtr_AccountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyGamePlayerMetadataUpdated.NativeFieldInfoPtr_AccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x000142E0 File Offset: 0x000124E0
		// (set) Token: 0x06000550 RID: 1360 RVA: 0x0000541C File Offset: 0x0000361C
		public unsafe Dictionary<string, string> Metadata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyGamePlayerMetadataUpdated.NativeFieldInfoPtr_Metadata);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyGamePlayerMetadataUpdated.NativeFieldInfoPtr_Metadata), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002D2 RID: 722
		private static readonly IntPtr NativeFieldInfoPtr_GameID;

		// Token: 0x040002D3 RID: 723
		private static readonly IntPtr NativeFieldInfoPtr_AccountID;

		// Token: 0x040002D4 RID: 724
		private static readonly IntPtr NativeFieldInfoPtr_Metadata;

		// Token: 0x040002D5 RID: 725
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
