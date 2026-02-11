using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000140 RID: 320
	[StructLayout(2)]
	public struct LeaderboardFindResult_t
	{
		// Token: 0x06001199 RID: 4505 RVA: 0x00062F38 File Offset: 0x00061138
		// Note: this type is marked as 'beforefieldinit'.
		static LeaderboardFindResult_t()
		{
			Il2CppClassPointerStore<LeaderboardFindResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "LeaderboardFindResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderboardFindResult_t>.NativeClassPtr);
			LeaderboardFindResult_t.NativeFieldInfoPtr_SteamLeaderboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardFindResult_t>.NativeClassPtr, "SteamLeaderboard");
			LeaderboardFindResult_t.NativeFieldInfoPtr_LeaderboardFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardFindResult_t>.NativeClassPtr, "LeaderboardFound");
			LeaderboardFindResult_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardFindResult_t>.NativeClassPtr, "_datasize");
			LeaderboardFindResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardFindResult_t>.NativeClassPtr, 100667029);
			LeaderboardFindResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardFindResult_t>.NativeClassPtr, 100667030);
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x0600119A RID: 4506 RVA: 0x00062FCC File Offset: 0x000611CC
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950562, XrefRangeEnd = 950566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardFindResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x0600119B RID: 4507 RVA: 0x00062FFC File Offset: 0x000611FC
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardFindResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x000053CF File Offset: 0x000035CF
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LeaderboardFindResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x0600119D RID: 4509 RVA: 0x0006302C File Offset: 0x0006122C
		// (set) Token: 0x0600119E RID: 4510 RVA: 0x000053E1 File Offset: 0x000035E1
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LeaderboardFindResult_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LeaderboardFindResult_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040017C9 RID: 6089
		private static readonly IntPtr NativeFieldInfoPtr_SteamLeaderboard;

		// Token: 0x040017CA RID: 6090
		private static readonly IntPtr NativeFieldInfoPtr_LeaderboardFound;

		// Token: 0x040017CB RID: 6091
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040017CC RID: 6092
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040017CD RID: 6093
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040017CE RID: 6094
		[FieldOffset(0)]
		public ulong SteamLeaderboard;

		// Token: 0x040017CF RID: 6095
		[FieldOffset(8)]
		public byte LeaderboardFound;
	}
}
