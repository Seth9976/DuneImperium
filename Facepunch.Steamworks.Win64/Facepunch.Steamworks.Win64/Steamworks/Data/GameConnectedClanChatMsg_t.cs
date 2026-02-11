using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020000F7 RID: 247
	[StructLayout(2)]
	public struct GameConnectedClanChatMsg_t
	{
		// Token: 0x06000F41 RID: 3905 RVA: 0x0005CB30 File Offset: 0x0005AD30
		// Note: this type is marked as 'beforefieldinit'.
		static GameConnectedClanChatMsg_t()
		{
			Il2CppClassPointerStore<GameConnectedClanChatMsg_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "GameConnectedClanChatMsg_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameConnectedClanChatMsg_t>.NativeClassPtr);
			GameConnectedClanChatMsg_t.NativeFieldInfoPtr_SteamIDClanChat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedClanChatMsg_t>.NativeClassPtr, "SteamIDClanChat");
			GameConnectedClanChatMsg_t.NativeFieldInfoPtr_SteamIDUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedClanChatMsg_t>.NativeClassPtr, "SteamIDUser");
			GameConnectedClanChatMsg_t.NativeFieldInfoPtr_MessageID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedClanChatMsg_t>.NativeClassPtr, "MessageID");
			GameConnectedClanChatMsg_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedClanChatMsg_t>.NativeClassPtr, "_datasize");
			GameConnectedClanChatMsg_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConnectedClanChatMsg_t>.NativeClassPtr, 100666800);
			GameConnectedClanChatMsg_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConnectedClanChatMsg_t>.NativeClassPtr, 100666801);
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000F42 RID: 3906 RVA: 0x0005CBD8 File Offset: 0x0005ADD8
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950226, XrefRangeEnd = 950230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameConnectedClanChatMsg_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000F43 RID: 3907 RVA: 0x0005CC08 File Offset: 0x0005AE08
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameConnectedClanChatMsg_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x00004295 File Offset: 0x00002495
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameConnectedClanChatMsg_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000F45 RID: 3909 RVA: 0x0005CC38 File Offset: 0x0005AE38
		// (set) Token: 0x06000F46 RID: 3910 RVA: 0x000042A7 File Offset: 0x000024A7
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GameConnectedClanChatMsg_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameConnectedClanChatMsg_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x0400156E RID: 5486
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDClanChat;

		// Token: 0x0400156F RID: 5487
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDUser;

		// Token: 0x04001570 RID: 5488
		private static readonly IntPtr NativeFieldInfoPtr_MessageID;

		// Token: 0x04001571 RID: 5489
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001572 RID: 5490
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001573 RID: 5491
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001574 RID: 5492
		[FieldOffset(0)]
		public ulong SteamIDClanChat;

		// Token: 0x04001575 RID: 5493
		[FieldOffset(8)]
		public ulong SteamIDUser;

		// Token: 0x04001576 RID: 5494
		[FieldOffset(16)]
		public int MessageID;
	}
}
