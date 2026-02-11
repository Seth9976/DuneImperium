using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.game.messages.chat
{
	// Token: 0x02000014 RID: 20
	public class GameChatAdded : NetworkMessageEvent
	{
		// Token: 0x060000A4 RID: 164 RVA: 0x00007B6C File Offset: 0x00005D6C
		// Note: this type is marked as 'beforefieldinit'.
		static GameChatAdded()
		{
			Il2CppClassPointerStore<GameChatAdded>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.game.messages.chat", "GameChatAdded");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameChatAdded>.NativeClassPtr);
			GameChatAdded.NativeFieldInfoPtr_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameChatAdded>.NativeClassPtr, "Message");
			GameChatAdded.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameChatAdded>.NativeClassPtr, 100663330);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00007BC4 File Offset: 0x00005DC4
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameChatAdded()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameChatAdded>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameChatAdded.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000026FB File Offset: 0x000008FB
		public GameChatAdded(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00007C00 File Offset: 0x00005E00
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x00002704 File Offset: 0x00000904
		public unsafe GameChatMessage Message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameChatAdded.NativeFieldInfoPtr_Message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameChatMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameChatAdded.NativeFieldInfoPtr_Message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeFieldInfoPtr_Message;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
