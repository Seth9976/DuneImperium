using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Networking.lobby;

namespace worm.networking
{
	// Token: 0x02000063 RID: 99
	public class RegisterEventUser : RegisterLobbyUser
	{
		// Token: 0x060003CF RID: 975 RVA: 0x00003AFF File Offset: 0x00001CFF
		// Note: this type is marked as 'beforefieldinit'.
		static RegisterEventUser()
		{
			Il2CppClassPointerStore<RegisterEventUser>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.networking", "RegisterEventUser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterEventUser>.NativeClassPtr);
			RegisterEventUser.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventUser>.NativeClassPtr, 100663920);
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00024ED4 File Offset: 0x000230D4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 542958, RefRangeEnd = 542962, XrefRangeStart = 542958, XrefRangeEnd = 542962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegisterEventUser()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegisterEventUser>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegisterEventUser.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00003B38 File Offset: 0x00001D38
		public RegisterEventUser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
