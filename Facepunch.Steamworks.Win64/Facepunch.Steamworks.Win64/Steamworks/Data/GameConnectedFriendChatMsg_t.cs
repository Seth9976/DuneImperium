using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020000FC RID: 252
	[StructLayout(2)]
	public struct GameConnectedFriendChatMsg_t
	{
		// Token: 0x06000F5F RID: 3935 RVA: 0x0005D0A8 File Offset: 0x0005B2A8
		// Note: this type is marked as 'beforefieldinit'.
		static GameConnectedFriendChatMsg_t()
		{
			Il2CppClassPointerStore<GameConnectedFriendChatMsg_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "GameConnectedFriendChatMsg_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameConnectedFriendChatMsg_t>.NativeClassPtr);
			GameConnectedFriendChatMsg_t.NativeFieldInfoPtr_SteamIDUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedFriendChatMsg_t>.NativeClassPtr, "SteamIDUser");
			GameConnectedFriendChatMsg_t.NativeFieldInfoPtr_MessageID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedFriendChatMsg_t>.NativeClassPtr, "MessageID");
			GameConnectedFriendChatMsg_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedFriendChatMsg_t>.NativeClassPtr, "_datasize");
			GameConnectedFriendChatMsg_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConnectedFriendChatMsg_t>.NativeClassPtr, 100666815);
			GameConnectedFriendChatMsg_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConnectedFriendChatMsg_t>.NativeClassPtr, 100666816);
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000F60 RID: 3936 RVA: 0x0005D13C File Offset: 0x0005B33C
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950246, XrefRangeEnd = 950250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameConnectedFriendChatMsg_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000F61 RID: 3937 RVA: 0x0005D16C File Offset: 0x0005B36C
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameConnectedFriendChatMsg_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x00004335 File Offset: 0x00002535
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameConnectedFriendChatMsg_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000F63 RID: 3939 RVA: 0x0005D19C File Offset: 0x0005B39C
		// (set) Token: 0x06000F64 RID: 3940 RVA: 0x00004347 File Offset: 0x00002547
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GameConnectedFriendChatMsg_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameConnectedFriendChatMsg_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001595 RID: 5525
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDUser;

		// Token: 0x04001596 RID: 5526
		private static readonly IntPtr NativeFieldInfoPtr_MessageID;

		// Token: 0x04001597 RID: 5527
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001598 RID: 5528
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001599 RID: 5529
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x0400159A RID: 5530
		[FieldOffset(0)]
		public ulong SteamIDUser;

		// Token: 0x0400159B RID: 5531
		[FieldOffset(8)]
		public int MessageID;
	}
}
