using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020000F9 RID: 249
	[StructLayout(2)]
	public struct GameConnectedChatLeave_t
	{
		// Token: 0x06000F4D RID: 3917 RVA: 0x0005CD64 File Offset: 0x0005AF64
		// Note: this type is marked as 'beforefieldinit'.
		static GameConnectedChatLeave_t()
		{
			Il2CppClassPointerStore<GameConnectedChatLeave_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "GameConnectedChatLeave_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameConnectedChatLeave_t>.NativeClassPtr);
			GameConnectedChatLeave_t.NativeFieldInfoPtr_SteamIDClanChat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedChatLeave_t>.NativeClassPtr, "SteamIDClanChat");
			GameConnectedChatLeave_t.NativeFieldInfoPtr_SteamIDUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedChatLeave_t>.NativeClassPtr, "SteamIDUser");
			GameConnectedChatLeave_t.NativeFieldInfoPtr_Kicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedChatLeave_t>.NativeClassPtr, "Kicked");
			GameConnectedChatLeave_t.NativeFieldInfoPtr_Dropped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedChatLeave_t>.NativeClassPtr, "Dropped");
			GameConnectedChatLeave_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedChatLeave_t>.NativeClassPtr, "_datasize");
			GameConnectedChatLeave_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConnectedChatLeave_t>.NativeClassPtr, 100666806);
			GameConnectedChatLeave_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConnectedChatLeave_t>.NativeClassPtr, 100666807);
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000F4E RID: 3918 RVA: 0x0005CE20 File Offset: 0x0005B020
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950234, XrefRangeEnd = 950238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameConnectedChatLeave_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000F4F RID: 3919 RVA: 0x0005CE50 File Offset: 0x0005B050
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameConnectedChatLeave_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x000042D5 File Offset: 0x000024D5
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameConnectedChatLeave_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000F51 RID: 3921 RVA: 0x0005CE80 File Offset: 0x0005B080
		// (set) Token: 0x06000F52 RID: 3922 RVA: 0x000042E7 File Offset: 0x000024E7
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GameConnectedChatLeave_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameConnectedChatLeave_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x0400157E RID: 5502
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDClanChat;

		// Token: 0x0400157F RID: 5503
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDUser;

		// Token: 0x04001580 RID: 5504
		private static readonly IntPtr NativeFieldInfoPtr_Kicked;

		// Token: 0x04001581 RID: 5505
		private static readonly IntPtr NativeFieldInfoPtr_Dropped;

		// Token: 0x04001582 RID: 5506
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001583 RID: 5507
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001584 RID: 5508
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001585 RID: 5509
		[FieldOffset(0)]
		public ulong SteamIDClanChat;

		// Token: 0x04001586 RID: 5510
		[FieldOffset(8)]
		public ulong SteamIDUser;

		// Token: 0x04001587 RID: 5511
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool Kicked;

		// Token: 0x04001588 RID: 5512
		[FieldOffset(17)]
		[MarshalAs(4)]
		public bool Dropped;
	}
}
