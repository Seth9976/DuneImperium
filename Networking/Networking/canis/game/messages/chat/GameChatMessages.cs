using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Canis.game.messages.chat
{
	// Token: 0x02000016 RID: 22
	public class GameChatMessages : NetworkMessageEvent
	{
		// Token: 0x060000B7 RID: 183 RVA: 0x00007E44 File Offset: 0x00006044
		// Note: this type is marked as 'beforefieldinit'.
		static GameChatMessages()
		{
			Il2CppClassPointerStore<GameChatMessages>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.game.messages.chat", "GameChatMessages");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameChatMessages>.NativeClassPtr);
			GameChatMessages.NativeFieldInfoPtr_Messages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameChatMessages>.NativeClassPtr, "Messages");
			GameChatMessages.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameChatMessages>.NativeClassPtr, 100663333);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00007E9C File Offset: 0x0000609C
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameChatMessages()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameChatMessages>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameChatMessages.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000027C3 File Offset: 0x000009C3
		public GameChatMessages(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00007ED8 File Offset: 0x000060D8
		// (set) Token: 0x060000BB RID: 187 RVA: 0x000027CC File Offset: 0x000009CC
		public unsafe List<GameChatMessage> Messages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameChatMessages.NativeFieldInfoPtr_Messages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameChatMessage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameChatMessages.NativeFieldInfoPtr_Messages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeFieldInfoPtr_Messages;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
