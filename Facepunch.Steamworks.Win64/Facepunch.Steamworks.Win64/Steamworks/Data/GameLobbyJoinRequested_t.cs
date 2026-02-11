using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020000F2 RID: 242
	[StructLayout(2)]
	public struct GameLobbyJoinRequested_t
	{
		// Token: 0x06000F1D RID: 3869 RVA: 0x0005C4D4 File Offset: 0x0005A6D4
		// Note: this type is marked as 'beforefieldinit'.
		static GameLobbyJoinRequested_t()
		{
			Il2CppClassPointerStore<GameLobbyJoinRequested_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "GameLobbyJoinRequested_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameLobbyJoinRequested_t>.NativeClassPtr);
			GameLobbyJoinRequested_t.NativeFieldInfoPtr_SteamIDLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLobbyJoinRequested_t>.NativeClassPtr, "SteamIDLobby");
			GameLobbyJoinRequested_t.NativeFieldInfoPtr_SteamIDFriend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLobbyJoinRequested_t>.NativeClassPtr, "SteamIDFriend");
			GameLobbyJoinRequested_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLobbyJoinRequested_t>.NativeClassPtr, "_datasize");
			GameLobbyJoinRequested_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLobbyJoinRequested_t>.NativeClassPtr, 100666784);
			GameLobbyJoinRequested_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLobbyJoinRequested_t>.NativeClassPtr, 100666785);
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000F1E RID: 3870 RVA: 0x0005C568 File Offset: 0x0005A768
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950201, XrefRangeEnd = 950205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLobbyJoinRequested_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000F1F RID: 3871 RVA: 0x0005C598 File Offset: 0x0005A798
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLobbyJoinRequested_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x000041B2 File Offset: 0x000023B2
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameLobbyJoinRequested_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000F21 RID: 3873 RVA: 0x0005C5C8 File Offset: 0x0005A7C8
		// (set) Token: 0x06000F22 RID: 3874 RVA: 0x000041C4 File Offset: 0x000023C4
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GameLobbyJoinRequested_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameLobbyJoinRequested_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001546 RID: 5446
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDLobby;

		// Token: 0x04001547 RID: 5447
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDFriend;

		// Token: 0x04001548 RID: 5448
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001549 RID: 5449
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400154A RID: 5450
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x0400154B RID: 5451
		[FieldOffset(0)]
		public ulong SteamIDLobby;

		// Token: 0x0400154C RID: 5452
		[FieldOffset(8)]
		public ulong SteamIDFriend;
	}
}
