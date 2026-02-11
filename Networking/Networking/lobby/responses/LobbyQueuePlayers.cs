using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Networking.lobby.responses
{
	// Token: 0x020000A8 RID: 168
	public class LobbyQueuePlayers : NetworkMessageEvent
	{
		// Token: 0x06000575 RID: 1397 RVA: 0x0001486C File Offset: 0x00012A6C
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyQueuePlayers()
		{
			Il2CppClassPointerStore<LobbyQueuePlayers>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.lobby.responses", "LobbyQueuePlayers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyQueuePlayers>.NativeClassPtr);
			LobbyQueuePlayers.NativeFieldInfoPtr_Players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyQueuePlayers>.NativeClassPtr, "Players");
			LobbyQueuePlayers.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyQueuePlayers>.NativeClassPtr, 100663643);
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x000148C4 File Offset: 0x00012AC4
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LobbyQueuePlayers()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyQueuePlayers>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyQueuePlayers.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00005588 File Offset: 0x00003788
		public LobbyQueuePlayers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000578 RID: 1400 RVA: 0x00014900 File Offset: 0x00012B00
		// (set) Token: 0x06000579 RID: 1401 RVA: 0x00005591 File Offset: 0x00003791
		public unsafe List<LobbyQueuePlayer> Players
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyQueuePlayers.NativeFieldInfoPtr_Players);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LobbyQueuePlayer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyQueuePlayers.NativeFieldInfoPtr_Players), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002E5 RID: 741
		private static readonly IntPtr NativeFieldInfoPtr_Players;

		// Token: 0x040002E6 RID: 742
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
