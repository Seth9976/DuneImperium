using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Networking.lobby.responses
{
	// Token: 0x020000AA RID: 170
	public class LobbyUserRegistered : NetworkMessageEvent
	{
		// Token: 0x06000586 RID: 1414 RVA: 0x00005631 File Offset: 0x00003831
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyUserRegistered()
		{
			Il2CppClassPointerStore<LobbyUserRegistered>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.lobby.responses", "LobbyUserRegistered");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyUserRegistered>.NativeClassPtr);
			LobbyUserRegistered.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyUserRegistered>.NativeClassPtr, 100663646);
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x00014B08 File Offset: 0x00012D08
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LobbyUserRegistered()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyUserRegistered>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyUserRegistered.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x0000566A File Offset: 0x0000386A
		public LobbyUserRegistered(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002ED RID: 749
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
