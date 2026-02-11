using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Canis.game.messages.chat
{
	// Token: 0x02000017 RID: 23
	public class GetGameChat : NetworkMessageEvent
	{
		// Token: 0x060000BC RID: 188 RVA: 0x000027EB File Offset: 0x000009EB
		// Note: this type is marked as 'beforefieldinit'.
		static GetGameChat()
		{
			Il2CppClassPointerStore<GetGameChat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.game.messages.chat", "GetGameChat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetGameChat>.NativeClassPtr);
			GetGameChat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetGameChat>.NativeClassPtr, 100663334);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00007F08 File Offset: 0x00006108
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetGameChat()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetGameChat>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetGameChat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002824 File Offset: 0x00000A24
		public GetGameChat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
