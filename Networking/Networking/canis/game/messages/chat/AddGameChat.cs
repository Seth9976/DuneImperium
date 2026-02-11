using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.game.messages.chat
{
	// Token: 0x02000013 RID: 19
	public class AddGameChat : NetworkMessageEvent
	{
		// Token: 0x0600009F RID: 159 RVA: 0x00007AA8 File Offset: 0x00005CA8
		// Note: this type is marked as 'beforefieldinit'.
		static AddGameChat()
		{
			Il2CppClassPointerStore<AddGameChat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.game.messages.chat", "AddGameChat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddGameChat>.NativeClassPtr);
			AddGameChat.NativeFieldInfoPtr_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddGameChat>.NativeClassPtr, "Message");
			AddGameChat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddGameChat>.NativeClassPtr, 100663329);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00007B00 File Offset: 0x00005D00
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddGameChat()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddGameChat>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddGameChat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000026D3 File Offset: 0x000008D3
		public AddGameChat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00007B3C File Offset: 0x00005D3C
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x000026DC File Offset: 0x000008DC
		public unsafe GameChatMessage Message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddGameChat.NativeFieldInfoPtr_Message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameChatMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddGameChat.NativeFieldInfoPtr_Message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeFieldInfoPtr_Message;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
