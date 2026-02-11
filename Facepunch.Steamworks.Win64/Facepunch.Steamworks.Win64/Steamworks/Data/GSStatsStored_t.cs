using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001B0 RID: 432
	[StructLayout(2)]
	public struct GSStatsStored_t
	{
		// Token: 0x0600152C RID: 5420 RVA: 0x0006C23C File Offset: 0x0006A43C
		// Note: this type is marked as 'beforefieldinit'.
		static GSStatsStored_t()
		{
			Il2CppClassPointerStore<GSStatsStored_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "GSStatsStored_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GSStatsStored_t>.NativeClassPtr);
			GSStatsStored_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSStatsStored_t>.NativeClassPtr, "Result");
			GSStatsStored_t.NativeFieldInfoPtr_SteamIDUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSStatsStored_t>.NativeClassPtr, "SteamIDUser");
			GSStatsStored_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSStatsStored_t>.NativeClassPtr, "_datasize");
			GSStatsStored_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GSStatsStored_t>.NativeClassPtr, 100667374);
			GSStatsStored_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GSStatsStored_t>.NativeClassPtr, 100667375);
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x0600152D RID: 5421 RVA: 0x0006C2D0 File Offset: 0x0006A4D0
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951052, XrefRangeEnd = 951056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GSStatsStored_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x0600152E RID: 5422 RVA: 0x0006C300 File Offset: 0x0006A500
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GSStatsStored_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x00006E5D File Offset: 0x0000505D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GSStatsStored_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06001530 RID: 5424 RVA: 0x0006C330 File Offset: 0x0006A530
		// (set) Token: 0x06001531 RID: 5425 RVA: 0x00006E6F File Offset: 0x0000506F
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GSStatsStored_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GSStatsStored_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001AE9 RID: 6889
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x04001AEA RID: 6890
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDUser;

		// Token: 0x04001AEB RID: 6891
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001AEC RID: 6892
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001AED RID: 6893
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001AEE RID: 6894
		[FieldOffset(0)]
		public Result Result;

		// Token: 0x04001AEF RID: 6895
		[FieldOffset(4)]
		public ulong SteamIDUser;
	}
}
