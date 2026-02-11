using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001B1 RID: 433
	[StructLayout(2)]
	public struct GSStatsUnloaded_t
	{
		// Token: 0x06001532 RID: 5426 RVA: 0x0006C34C File Offset: 0x0006A54C
		// Note: this type is marked as 'beforefieldinit'.
		static GSStatsUnloaded_t()
		{
			Il2CppClassPointerStore<GSStatsUnloaded_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "GSStatsUnloaded_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GSStatsUnloaded_t>.NativeClassPtr);
			GSStatsUnloaded_t.NativeFieldInfoPtr_SteamIDUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSStatsUnloaded_t>.NativeClassPtr, "SteamIDUser");
			GSStatsUnloaded_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSStatsUnloaded_t>.NativeClassPtr, "_datasize");
			GSStatsUnloaded_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GSStatsUnloaded_t>.NativeClassPtr, 100667377);
			GSStatsUnloaded_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GSStatsUnloaded_t>.NativeClassPtr, 100667378);
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06001533 RID: 5427 RVA: 0x0006C3CC File Offset: 0x0006A5CC
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951056, XrefRangeEnd = 951060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GSStatsUnloaded_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06001534 RID: 5428 RVA: 0x0006C3FC File Offset: 0x0006A5FC
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GSStatsUnloaded_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x00006E7D File Offset: 0x0000507D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GSStatsUnloaded_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06001536 RID: 5430 RVA: 0x0006C42C File Offset: 0x0006A62C
		// (set) Token: 0x06001537 RID: 5431 RVA: 0x00006E8F File Offset: 0x0000508F
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GSStatsUnloaded_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GSStatsUnloaded_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001AF0 RID: 6896
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDUser;

		// Token: 0x04001AF1 RID: 6897
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001AF2 RID: 6898
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001AF3 RID: 6899
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001AF4 RID: 6900
		[FieldOffset(0)]
		public ulong SteamIDUser;
	}
}
