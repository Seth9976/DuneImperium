using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200011A RID: 282
	[StructLayout(2)]
	public struct RequestPlayersForGameResultCallback_t
	{
		// Token: 0x06001020 RID: 4128 RVA: 0x0005F32C File Offset: 0x0005D52C
		// Note: this type is marked as 'beforefieldinit'.
		static RequestPlayersForGameResultCallback_t()
		{
			Il2CppClassPointerStore<RequestPlayersForGameResultCallback_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "RequestPlayersForGameResultCallback_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestPlayersForGameResultCallback_t>.NativeClassPtr);
			RequestPlayersForGameResultCallback_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPlayersForGameResultCallback_t>.NativeClassPtr, "Result");
			RequestPlayersForGameResultCallback_t.NativeFieldInfoPtr_LSearchID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPlayersForGameResultCallback_t>.NativeClassPtr, "LSearchID");
			RequestPlayersForGameResultCallback_t.NativeFieldInfoPtr_SteamIDPlayerFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPlayersForGameResultCallback_t>.NativeClassPtr, "SteamIDPlayerFound");
			RequestPlayersForGameResultCallback_t.NativeFieldInfoPtr_SteamIDLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPlayersForGameResultCallback_t>.NativeClassPtr, "SteamIDLobby");
			RequestPlayersForGameResultCallback_t.NativeFieldInfoPtr_PlayerAcceptState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPlayersForGameResultCallback_t>.NativeClassPtr, "PlayerAcceptState");
			RequestPlayersForGameResultCallback_t.NativeFieldInfoPtr_PlayerIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPlayersForGameResultCallback_t>.NativeClassPtr, "PlayerIndex");
			RequestPlayersForGameResultCallback_t.NativeFieldInfoPtr_TotalPlayersFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPlayersForGameResultCallback_t>.NativeClassPtr, "TotalPlayersFound");
			RequestPlayersForGameResultCallback_t.NativeFieldInfoPtr_TotalPlayersAcceptedGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPlayersForGameResultCallback_t>.NativeClassPtr, "TotalPlayersAcceptedGame");
			RequestPlayersForGameResultCallback_t.NativeFieldInfoPtr_SuggestedTeamIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPlayersForGameResultCallback_t>.NativeClassPtr, "SuggestedTeamIndex");
			RequestPlayersForGameResultCallback_t.NativeFieldInfoPtr_LUniqueGameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPlayersForGameResultCallback_t>.NativeClassPtr, "LUniqueGameID");
			RequestPlayersForGameResultCallback_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPlayersForGameResultCallback_t>.NativeClassPtr, "_datasize");
			RequestPlayersForGameResultCallback_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestPlayersForGameResultCallback_t>.NativeClassPtr, 100666906);
			RequestPlayersForGameResultCallback_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestPlayersForGameResultCallback_t>.NativeClassPtr, 100666907);
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06001021 RID: 4129 RVA: 0x0005F460 File Offset: 0x0005D660
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950371, XrefRangeEnd = 950375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestPlayersForGameResultCallback_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06001022 RID: 4130 RVA: 0x0005F490 File Offset: 0x0005D690
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestPlayersForGameResultCallback_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x00004796 File Offset: 0x00002996
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RequestPlayersForGameResultCallback_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06001024 RID: 4132 RVA: 0x0005F4C0 File Offset: 0x0005D6C0
		// (set) Token: 0x06001025 RID: 4133 RVA: 0x000047A8 File Offset: 0x000029A8
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RequestPlayersForGameResultCallback_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RequestPlayersForGameResultCallback_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001681 RID: 5761
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x04001682 RID: 5762
		private static readonly IntPtr NativeFieldInfoPtr_LSearchID;

		// Token: 0x04001683 RID: 5763
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDPlayerFound;

		// Token: 0x04001684 RID: 5764
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDLobby;

		// Token: 0x04001685 RID: 5765
		private static readonly IntPtr NativeFieldInfoPtr_PlayerAcceptState;

		// Token: 0x04001686 RID: 5766
		private static readonly IntPtr NativeFieldInfoPtr_PlayerIndex;

		// Token: 0x04001687 RID: 5767
		private static readonly IntPtr NativeFieldInfoPtr_TotalPlayersFound;

		// Token: 0x04001688 RID: 5768
		private static readonly IntPtr NativeFieldInfoPtr_TotalPlayersAcceptedGame;

		// Token: 0x04001689 RID: 5769
		private static readonly IntPtr NativeFieldInfoPtr_SuggestedTeamIndex;

		// Token: 0x0400168A RID: 5770
		private static readonly IntPtr NativeFieldInfoPtr_LUniqueGameID;

		// Token: 0x0400168B RID: 5771
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x0400168C RID: 5772
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400168D RID: 5773
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x0400168E RID: 5774
		[FieldOffset(0)]
		public Result Result;

		// Token: 0x0400168F RID: 5775
		[FieldOffset(4)]
		public ulong LSearchID;

		// Token: 0x04001690 RID: 5776
		[FieldOffset(12)]
		public ulong SteamIDPlayerFound;

		// Token: 0x04001691 RID: 5777
		[FieldOffset(20)]
		public ulong SteamIDLobby;

		// Token: 0x04001692 RID: 5778
		[FieldOffset(28)]
		public RequestPlayersForGameResultCallback_t.PlayerAcceptState_t PlayerAcceptState;

		// Token: 0x04001693 RID: 5779
		[FieldOffset(32)]
		public int PlayerIndex;

		// Token: 0x04001694 RID: 5780
		[FieldOffset(36)]
		public int TotalPlayersFound;

		// Token: 0x04001695 RID: 5781
		[FieldOffset(40)]
		public int TotalPlayersAcceptedGame;

		// Token: 0x04001696 RID: 5782
		[FieldOffset(44)]
		public int SuggestedTeamIndex;

		// Token: 0x04001697 RID: 5783
		[FieldOffset(48)]
		public ulong LUniqueGameID;

		// Token: 0x0200029C RID: 668
		public enum PlayerAcceptState_t
		{
			// Token: 0x0400238F RID: 9103
			Unknown,
			// Token: 0x04002390 RID: 9104
			PlayerAccepted,
			// Token: 0x04002391 RID: 9105
			PlayerDeclined
		}
	}
}
