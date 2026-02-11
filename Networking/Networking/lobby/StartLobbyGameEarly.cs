using System;
using Canis.json.events;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Networking.lobby
{
	// Token: 0x0200009C RID: 156
	public class StartLobbyGameEarly : NetworkMessageEvent
	{
		// Token: 0x06000527 RID: 1319 RVA: 0x00013D3C File Offset: 0x00011F3C
		// Note: this type is marked as 'beforefieldinit'.
		static StartLobbyGameEarly()
		{
			Il2CppClassPointerStore<StartLobbyGameEarly>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.lobby", "StartLobbyGameEarly");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartLobbyGameEarly>.NativeClassPtr);
			StartLobbyGameEarly.NativeFieldInfoPtr_GameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLobbyGameEarly>.NativeClassPtr, "GameID");
			StartLobbyGameEarly.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLobbyGameEarly>.NativeClassPtr, 100663631);
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00013D94 File Offset: 0x00011F94
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StartLobbyGameEarly()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartLobbyGameEarly>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLobbyGameEarly.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00005264 File Offset: 0x00003464
		public StartLobbyGameEarly(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x00013DD0 File Offset: 0x00011FD0
		// (set) Token: 0x0600052B RID: 1323 RVA: 0x0000526D File Offset: 0x0000346D
		public unsafe GameID GameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLobbyGameEarly.NativeFieldInfoPtr_GameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLobbyGameEarly.NativeFieldInfoPtr_GameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002C4 RID: 708
		private static readonly IntPtr NativeFieldInfoPtr_GameID;

		// Token: 0x040002C5 RID: 709
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
