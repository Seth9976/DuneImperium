using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace lotus
{
	// Token: 0x020000AE RID: 174
	public class ChatUtil : Object
	{
		// Token: 0x0600087B RID: 2171 RVA: 0x0002BE3C File Offset: 0x0002A03C
		// Note: this type is marked as 'beforefieldinit'.
		static ChatUtil()
		{
			Il2CppClassPointerStore<ChatUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "ChatUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChatUtil>.NativeClassPtr);
			ChatUtil.NativeMethodInfoPtr_IsChatMessage_Public_Static_Boolean_ClientChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatUtil>.NativeClassPtr, 100664625);
			ChatUtil.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatUtil>.NativeClassPtr, 100664626);
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x0002BE94 File Offset: 0x0002A094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991616, XrefRangeEnd = 991622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsChatMessage(ClientChatMessage chatMessage)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chatMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatUtil.NativeMethodInfoPtr_IsChatMessage_Public_Static_Boolean_ClientChatMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x0002BED8 File Offset: 0x0002A0D8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChatUtil()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChatUtil>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatUtil.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00005DAB File Offset: 0x00003FAB
		public ChatUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000530 RID: 1328
		private static readonly IntPtr NativeMethodInfoPtr_IsChatMessage_Public_Static_Boolean_ClientChatMessage_0;

		// Token: 0x04000531 RID: 1329
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
