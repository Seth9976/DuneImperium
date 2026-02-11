using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000144 RID: 324
	[StructLayout(2)]
	public struct UserStatsUnloaded_t
	{
		// Token: 0x060011B1 RID: 4529 RVA: 0x000633DC File Offset: 0x000615DC
		// Note: this type is marked as 'beforefieldinit'.
		static UserStatsUnloaded_t()
		{
			Il2CppClassPointerStore<UserStatsUnloaded_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "UserStatsUnloaded_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserStatsUnloaded_t>.NativeClassPtr);
			UserStatsUnloaded_t.NativeFieldInfoPtr_SteamIDUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserStatsUnloaded_t>.NativeClassPtr, "SteamIDUser");
			UserStatsUnloaded_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserStatsUnloaded_t>.NativeClassPtr, "_datasize");
			UserStatsUnloaded_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserStatsUnloaded_t>.NativeClassPtr, 100667041);
			UserStatsUnloaded_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserStatsUnloaded_t>.NativeClassPtr, 100667042);
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x060011B2 RID: 4530 RVA: 0x0006345C File Offset: 0x0006165C
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950578, XrefRangeEnd = 950582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserStatsUnloaded_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x060011B3 RID: 4531 RVA: 0x0006348C File Offset: 0x0006168C
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserStatsUnloaded_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x0000544F File Offset: 0x0000364F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UserStatsUnloaded_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x060011B5 RID: 4533 RVA: 0x000634BC File Offset: 0x000616BC
		// (set) Token: 0x060011B6 RID: 4534 RVA: 0x00005461 File Offset: 0x00003661
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UserStatsUnloaded_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UserStatsUnloaded_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040017EF RID: 6127
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDUser;

		// Token: 0x040017F0 RID: 6128
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040017F1 RID: 6129
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040017F2 RID: 6130
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040017F3 RID: 6131
		[FieldOffset(0)]
		public ulong SteamIDUser;
	}
}
