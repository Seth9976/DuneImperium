using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Networking.lobby;

namespace boardgames.ranked.networking
{
	// Token: 0x0200000C RID: 12
	public class RegisterRankedUser : RegisterLobbyUser
	{
		// Token: 0x0600003B RID: 59 RVA: 0x00002262 File Offset: 0x00000462
		// Note: this type is marked as 'beforefieldinit'.
		static RegisterRankedUser()
		{
			Il2CppClassPointerStore<RegisterRankedUser>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.networking", "RegisterRankedUser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterRankedUser>.NativeClassPtr);
			RegisterRankedUser.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterRankedUser>.NativeClassPtr, 100663318);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000042E0 File Offset: 0x000024E0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 542958, RefRangeEnd = 542962, XrefRangeStart = 542958, XrefRangeEnd = 542962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegisterRankedUser()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegisterRankedUser>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterRankedUser.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000229B File Offset: 0x0000049B
		public RegisterRankedUser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
