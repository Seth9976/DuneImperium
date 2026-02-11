using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200013D RID: 317
	[StructLayout(2)]
	public struct UserStatsReceived_t
	{
		// Token: 0x0600117B RID: 4475 RVA: 0x00062A70 File Offset: 0x00060C70
		// Note: this type is marked as 'beforefieldinit'.
		static UserStatsReceived_t()
		{
			Il2CppClassPointerStore<UserStatsReceived_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "UserStatsReceived_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserStatsReceived_t>.NativeClassPtr);
			UserStatsReceived_t.NativeFieldInfoPtr_GameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserStatsReceived_t>.NativeClassPtr, "GameID");
			UserStatsReceived_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserStatsReceived_t>.NativeClassPtr, "Result");
			UserStatsReceived_t.NativeFieldInfoPtr_SteamIDUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserStatsReceived_t>.NativeClassPtr, "SteamIDUser");
			UserStatsReceived_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserStatsReceived_t>.NativeClassPtr, "_datasize");
			UserStatsReceived_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserStatsReceived_t>.NativeClassPtr, 100667019);
			UserStatsReceived_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserStatsReceived_t>.NativeClassPtr, 100667020);
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x0600117C RID: 4476 RVA: 0x00062B18 File Offset: 0x00060D18
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950545, XrefRangeEnd = 950549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserStatsReceived_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x0600117D RID: 4477 RVA: 0x00062B48 File Offset: 0x00060D48
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserStatsReceived_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x000052DB File Offset: 0x000034DB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UserStatsReceived_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x0600117F RID: 4479 RVA: 0x00062B78 File Offset: 0x00060D78
		// (set) Token: 0x06001180 RID: 4480 RVA: 0x000052ED File Offset: 0x000034ED
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UserStatsReceived_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UserStatsReceived_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040017B0 RID: 6064
		private static readonly IntPtr NativeFieldInfoPtr_GameID;

		// Token: 0x040017B1 RID: 6065
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x040017B2 RID: 6066
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDUser;

		// Token: 0x040017B3 RID: 6067
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040017B4 RID: 6068
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040017B5 RID: 6069
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040017B6 RID: 6070
		[FieldOffset(0)]
		public ulong GameID;

		// Token: 0x040017B7 RID: 6071
		[FieldOffset(8)]
		public Result Result;

		// Token: 0x040017B8 RID: 6072
		[FieldOffset(12)]
		public ulong SteamIDUser;
	}
}
