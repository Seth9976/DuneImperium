using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Networking.game;

namespace Networking.lobby.responses
{
	// Token: 0x020000A4 RID: 164
	public class LobbyGameUpdated : NetworkMessageEvent
	{
		// Token: 0x0600055B RID: 1371 RVA: 0x00014498 File Offset: 0x00012698
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyGameUpdated()
		{
			Il2CppClassPointerStore<LobbyGameUpdated>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.lobby.responses", "LobbyGameUpdated");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyGameUpdated>.NativeClassPtr);
			LobbyGameUpdated.NativeFieldInfoPtr_GameSession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyGameUpdated>.NativeClassPtr, "GameSession");
			LobbyGameUpdated.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyGameUpdated>.NativeClassPtr, 100663639);
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x000144F0 File Offset: 0x000126F0
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LobbyGameUpdated()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyGameUpdated>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyGameUpdated.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x0000548B File Offset: 0x0000368B
		public LobbyGameUpdated(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x0600055E RID: 1374 RVA: 0x0001452C File Offset: 0x0001272C
		// (set) Token: 0x0600055F RID: 1375 RVA: 0x00005494 File Offset: 0x00003694
		public unsafe DWDPendingGameMetadata GameSession
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyGameUpdated.NativeFieldInfoPtr_GameSession);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DWDPendingGameMetadata>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyGameUpdated.NativeFieldInfoPtr_GameSession), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeFieldInfoPtr_GameSession;

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
