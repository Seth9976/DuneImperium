using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020000FB RID: 251
	[StructLayout(2)]
	public struct JoinClanChatRoomCompletionResult_t
	{
		// Token: 0x06000F59 RID: 3929 RVA: 0x0005CF98 File Offset: 0x0005B198
		// Note: this type is marked as 'beforefieldinit'.
		static JoinClanChatRoomCompletionResult_t()
		{
			Il2CppClassPointerStore<JoinClanChatRoomCompletionResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "JoinClanChatRoomCompletionResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JoinClanChatRoomCompletionResult_t>.NativeClassPtr);
			JoinClanChatRoomCompletionResult_t.NativeFieldInfoPtr_SteamIDClanChat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinClanChatRoomCompletionResult_t>.NativeClassPtr, "SteamIDClanChat");
			JoinClanChatRoomCompletionResult_t.NativeFieldInfoPtr_ChatRoomEnterResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinClanChatRoomCompletionResult_t>.NativeClassPtr, "ChatRoomEnterResponse");
			JoinClanChatRoomCompletionResult_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinClanChatRoomCompletionResult_t>.NativeClassPtr, "_datasize");
			JoinClanChatRoomCompletionResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinClanChatRoomCompletionResult_t>.NativeClassPtr, 100666812);
			JoinClanChatRoomCompletionResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinClanChatRoomCompletionResult_t>.NativeClassPtr, 100666813);
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000F5A RID: 3930 RVA: 0x0005D02C File Offset: 0x0005B22C
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950242, XrefRangeEnd = 950246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoinClanChatRoomCompletionResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000F5B RID: 3931 RVA: 0x0005D05C File Offset: 0x0005B25C
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoinClanChatRoomCompletionResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x00004315 File Offset: 0x00002515
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JoinClanChatRoomCompletionResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000F5D RID: 3933 RVA: 0x0005D08C File Offset: 0x0005B28C
		// (set) Token: 0x06000F5E RID: 3934 RVA: 0x00004327 File Offset: 0x00002527
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(JoinClanChatRoomCompletionResult_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JoinClanChatRoomCompletionResult_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x0400158E RID: 5518
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDClanChat;

		// Token: 0x0400158F RID: 5519
		private static readonly IntPtr NativeFieldInfoPtr_ChatRoomEnterResponse;

		// Token: 0x04001590 RID: 5520
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001591 RID: 5521
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001592 RID: 5522
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001593 RID: 5523
		[FieldOffset(0)]
		public ulong SteamIDClanChat;

		// Token: 0x04001594 RID: 5524
		[FieldOffset(8)]
		public RoomEnter ChatRoomEnterResponse;
	}
}
