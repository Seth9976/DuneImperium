using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000147 RID: 327
	[StructLayout(2)]
	public struct LeaderboardUGCSet_t
	{
		// Token: 0x060011CD RID: 4557 RVA: 0x00063840 File Offset: 0x00061A40
		// Note: this type is marked as 'beforefieldinit'.
		static LeaderboardUGCSet_t()
		{
			Il2CppClassPointerStore<LeaderboardUGCSet_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "LeaderboardUGCSet_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderboardUGCSet_t>.NativeClassPtr);
			LeaderboardUGCSet_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardUGCSet_t>.NativeClassPtr, "Result");
			LeaderboardUGCSet_t.NativeFieldInfoPtr_SteamLeaderboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardUGCSet_t>.NativeClassPtr, "SteamLeaderboard");
			LeaderboardUGCSet_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardUGCSet_t>.NativeClassPtr, "_datasize");
			LeaderboardUGCSet_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardUGCSet_t>.NativeClassPtr, 100667051);
			LeaderboardUGCSet_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardUGCSet_t>.NativeClassPtr, 100667052);
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x060011CE RID: 4558 RVA: 0x000638D4 File Offset: 0x00061AD4
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950595, XrefRangeEnd = 950599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardUGCSet_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x060011CF RID: 4559 RVA: 0x00063904 File Offset: 0x00061B04
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardUGCSet_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x00005528 File Offset: 0x00003728
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LeaderboardUGCSet_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x060011D1 RID: 4561 RVA: 0x00063934 File Offset: 0x00061B34
		// (set) Token: 0x060011D2 RID: 4562 RVA: 0x0000553A File Offset: 0x0000373A
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LeaderboardUGCSet_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LeaderboardUGCSet_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001803 RID: 6147
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x04001804 RID: 6148
		private static readonly IntPtr NativeFieldInfoPtr_SteamLeaderboard;

		// Token: 0x04001805 RID: 6149
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001806 RID: 6150
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001807 RID: 6151
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001808 RID: 6152
		[FieldOffset(0)]
		public Result Result;

		// Token: 0x04001809 RID: 6153
		[FieldOffset(8)]
		public ulong SteamLeaderboard;
	}
}
