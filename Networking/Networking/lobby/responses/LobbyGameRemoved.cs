using System;
using Canis.json.events;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Networking.lobby.responses
{
	// Token: 0x020000A2 RID: 162
	public class LobbyGameRemoved : NetworkMessageEvent
	{
		// Token: 0x06000551 RID: 1361 RVA: 0x00014310 File Offset: 0x00012510
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyGameRemoved()
		{
			Il2CppClassPointerStore<LobbyGameRemoved>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.lobby.responses", "LobbyGameRemoved");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyGameRemoved>.NativeClassPtr);
			LobbyGameRemoved.NativeFieldInfoPtr_GameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyGameRemoved>.NativeClassPtr, "GameID");
			LobbyGameRemoved.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyGameRemoved>.NativeClassPtr, 100663637);
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00014368 File Offset: 0x00012568
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LobbyGameRemoved()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyGameRemoved>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyGameRemoved.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x0000543B File Offset: 0x0000363B
		public LobbyGameRemoved(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000554 RID: 1364 RVA: 0x000143A4 File Offset: 0x000125A4
		// (set) Token: 0x06000555 RID: 1365 RVA: 0x00005444 File Offset: 0x00003644
		public unsafe GameID GameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyGameRemoved.NativeFieldInfoPtr_GameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyGameRemoved.NativeFieldInfoPtr_GameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002D6 RID: 726
		private static readonly IntPtr NativeFieldInfoPtr_GameID;

		// Token: 0x040002D7 RID: 727
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
