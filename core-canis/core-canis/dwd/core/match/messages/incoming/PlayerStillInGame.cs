using System;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.match.messages.incoming
{
	// Token: 0x02000163 RID: 355
	public class PlayerStillInGame : GameMessage
	{
		// Token: 0x060014CA RID: 5322 RVA: 0x0000930D File Offset: 0x0000750D
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerStillInGame()
		{
			Il2CppClassPointerStore<PlayerStillInGame>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.messages.incoming", "PlayerStillInGame");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerStillInGame>.NativeClassPtr);
			PlayerStillInGame.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStillInGame>.NativeClassPtr, 100666426);
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x0006778C File Offset: 0x0006598C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 542958, RefRangeEnd = 542962, XrefRangeStart = 542958, XrefRangeEnd = 542962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerStillInGame()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerStillInGame>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerStillInGame.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x00009346 File Offset: 0x00007546
		public PlayerStillInGame(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EDD RID: 3805
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
