using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Networking.lobby.responses
{
	// Token: 0x0200009E RID: 158
	public class GameLobbyAuthenticated : NetworkMessageEvent
	{
		// Token: 0x06000533 RID: 1331 RVA: 0x000052D3 File Offset: 0x000034D3
		// Note: this type is marked as 'beforefieldinit'.
		static GameLobbyAuthenticated()
		{
			Il2CppClassPointerStore<GameLobbyAuthenticated>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.lobby.responses", "GameLobbyAuthenticated");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameLobbyAuthenticated>.NativeClassPtr);
			GameLobbyAuthenticated.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLobbyAuthenticated>.NativeClassPtr, 100663633);
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00013F08 File Offset: 0x00012108
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameLobbyAuthenticated()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameLobbyAuthenticated>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLobbyAuthenticated.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x0000530C File Offset: 0x0000350C
		public GameLobbyAuthenticated(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
