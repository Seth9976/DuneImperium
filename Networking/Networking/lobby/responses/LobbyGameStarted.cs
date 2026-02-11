using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Networking.game;

namespace Networking.lobby.responses
{
	// Token: 0x020000A3 RID: 163
	public class LobbyGameStarted : NetworkMessageEvent
	{
		// Token: 0x06000556 RID: 1366 RVA: 0x000143D4 File Offset: 0x000125D4
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyGameStarted()
		{
			Il2CppClassPointerStore<LobbyGameStarted>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.lobby.responses", "LobbyGameStarted");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyGameStarted>.NativeClassPtr);
			LobbyGameStarted.NativeFieldInfoPtr_GameSession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyGameStarted>.NativeClassPtr, "GameSession");
			LobbyGameStarted.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyGameStarted>.NativeClassPtr, 100663638);
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x0001442C File Offset: 0x0001262C
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LobbyGameStarted()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyGameStarted>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyGameStarted.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00005463 File Offset: 0x00003663
		public LobbyGameStarted(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000559 RID: 1369 RVA: 0x00014468 File Offset: 0x00012668
		// (set) Token: 0x0600055A RID: 1370 RVA: 0x0000546C File Offset: 0x0000366C
		public unsafe DWDGameSession GameSession
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyGameStarted.NativeFieldInfoPtr_GameSession);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DWDGameSession>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyGameStarted.NativeFieldInfoPtr_GameSession), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeFieldInfoPtr_GameSession;

		// Token: 0x040002D9 RID: 729
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
