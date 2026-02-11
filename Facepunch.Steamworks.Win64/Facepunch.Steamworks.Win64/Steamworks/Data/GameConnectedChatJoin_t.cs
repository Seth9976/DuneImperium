using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020000F8 RID: 248
	[StructLayout(2)]
	public struct GameConnectedChatJoin_t
	{
		// Token: 0x06000F47 RID: 3911 RVA: 0x0005CC54 File Offset: 0x0005AE54
		// Note: this type is marked as 'beforefieldinit'.
		static GameConnectedChatJoin_t()
		{
			Il2CppClassPointerStore<GameConnectedChatJoin_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "GameConnectedChatJoin_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameConnectedChatJoin_t>.NativeClassPtr);
			GameConnectedChatJoin_t.NativeFieldInfoPtr_SteamIDClanChat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedChatJoin_t>.NativeClassPtr, "SteamIDClanChat");
			GameConnectedChatJoin_t.NativeFieldInfoPtr_SteamIDUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedChatJoin_t>.NativeClassPtr, "SteamIDUser");
			GameConnectedChatJoin_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedChatJoin_t>.NativeClassPtr, "_datasize");
			GameConnectedChatJoin_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConnectedChatJoin_t>.NativeClassPtr, 100666803);
			GameConnectedChatJoin_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameConnectedChatJoin_t>.NativeClassPtr, 100666804);
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000F48 RID: 3912 RVA: 0x0005CCE8 File Offset: 0x0005AEE8
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950230, XrefRangeEnd = 950234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameConnectedChatJoin_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000F49 RID: 3913 RVA: 0x0005CD18 File Offset: 0x0005AF18
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameConnectedChatJoin_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x000042B5 File Offset: 0x000024B5
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameConnectedChatJoin_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000F4B RID: 3915 RVA: 0x0005CD48 File Offset: 0x0005AF48
		// (set) Token: 0x06000F4C RID: 3916 RVA: 0x000042C7 File Offset: 0x000024C7
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GameConnectedChatJoin_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameConnectedChatJoin_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001577 RID: 5495
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDClanChat;

		// Token: 0x04001578 RID: 5496
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDUser;

		// Token: 0x04001579 RID: 5497
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x0400157A RID: 5498
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400157B RID: 5499
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x0400157C RID: 5500
		[FieldOffset(0)]
		public ulong SteamIDClanChat;

		// Token: 0x0400157D RID: 5501
		[FieldOffset(8)]
		public ulong SteamIDUser;
	}
}
