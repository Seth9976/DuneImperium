using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000146 RID: 326
	[StructLayout(2)]
	public struct GlobalAchievementPercentagesReady_t
	{
		// Token: 0x060011C7 RID: 4551 RVA: 0x00063730 File Offset: 0x00061930
		// Note: this type is marked as 'beforefieldinit'.
		static GlobalAchievementPercentagesReady_t()
		{
			Il2CppClassPointerStore<GlobalAchievementPercentagesReady_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "GlobalAchievementPercentagesReady_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalAchievementPercentagesReady_t>.NativeClassPtr);
			GlobalAchievementPercentagesReady_t.NativeFieldInfoPtr_GameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAchievementPercentagesReady_t>.NativeClassPtr, "GameID");
			GlobalAchievementPercentagesReady_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAchievementPercentagesReady_t>.NativeClassPtr, "Result");
			GlobalAchievementPercentagesReady_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAchievementPercentagesReady_t>.NativeClassPtr, "_datasize");
			GlobalAchievementPercentagesReady_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAchievementPercentagesReady_t>.NativeClassPtr, 100667048);
			GlobalAchievementPercentagesReady_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalAchievementPercentagesReady_t>.NativeClassPtr, 100667049);
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x060011C8 RID: 4552 RVA: 0x000637C4 File Offset: 0x000619C4
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950591, XrefRangeEnd = 950595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAchievementPercentagesReady_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x060011C9 RID: 4553 RVA: 0x000637F4 File Offset: 0x000619F4
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalAchievementPercentagesReady_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x00005508 File Offset: 0x00003708
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalAchievementPercentagesReady_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x060011CB RID: 4555 RVA: 0x00063824 File Offset: 0x00061A24
		// (set) Token: 0x060011CC RID: 4556 RVA: 0x0000551A File Offset: 0x0000371A
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GlobalAchievementPercentagesReady_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GlobalAchievementPercentagesReady_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040017FC RID: 6140
		private static readonly IntPtr NativeFieldInfoPtr_GameID;

		// Token: 0x040017FD RID: 6141
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x040017FE RID: 6142
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040017FF RID: 6143
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001800 RID: 6144
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001801 RID: 6145
		[FieldOffset(0)]
		public ulong GameID;

		// Token: 0x04001802 RID: 6146
		[FieldOffset(8)]
		public Result Result;
	}
}
