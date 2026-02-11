using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.game.messages.connection
{
	// Token: 0x02000012 RID: 18
	public class PlayerDisconnected : Object
	{
		// Token: 0x0600009C RID: 156 RVA: 0x00002691 File Offset: 0x00000891
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerDisconnected()
		{
			Il2CppClassPointerStore<PlayerDisconnected>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.game.messages.connection", "PlayerDisconnected");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerDisconnected>.NativeClassPtr);
			PlayerDisconnected.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisconnected>.NativeClassPtr, 100663328);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00007A6C File Offset: 0x00005C6C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerDisconnected()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerDisconnected>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisconnected.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000026CA File Offset: 0x000008CA
		public PlayerDisconnected(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
