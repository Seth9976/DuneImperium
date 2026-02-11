using System;
using Canis.json.events;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Networking.lobby
{
	// Token: 0x02000099 RID: 153
	public class LeaveLobbyGame : NetworkMessageEvent
	{
		// Token: 0x06000512 RID: 1298 RVA: 0x00013A24 File Offset: 0x00011C24
		// Note: this type is marked as 'beforefieldinit'.
		static LeaveLobbyGame()
		{
			Il2CppClassPointerStore<LeaveLobbyGame>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.lobby", "LeaveLobbyGame");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaveLobbyGame>.NativeClassPtr);
			LeaveLobbyGame.NativeFieldInfoPtr_GameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaveLobbyGame>.NativeClassPtr, "GameID");
			LeaveLobbyGame.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaveLobbyGame>.NativeClassPtr, 100663628);
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00013A7C File Offset: 0x00011C7C
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LeaveLobbyGame()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaveLobbyGame>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaveLobbyGame.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x0000518F File Offset: 0x0000338F
		public LeaveLobbyGame(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x00013AB8 File Offset: 0x00011CB8
		// (set) Token: 0x06000516 RID: 1302 RVA: 0x00005198 File Offset: 0x00003398
		public unsafe GameID GameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaveLobbyGame.NativeFieldInfoPtr_GameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaveLobbyGame.NativeFieldInfoPtr_GameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeFieldInfoPtr_GameID;

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
