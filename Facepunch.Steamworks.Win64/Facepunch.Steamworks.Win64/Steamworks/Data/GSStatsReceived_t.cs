using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001AF RID: 431
	[StructLayout(2)]
	public struct GSStatsReceived_t
	{
		// Token: 0x06001526 RID: 5414 RVA: 0x0006C12C File Offset: 0x0006A32C
		// Note: this type is marked as 'beforefieldinit'.
		static GSStatsReceived_t()
		{
			Il2CppClassPointerStore<GSStatsReceived_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "GSStatsReceived_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GSStatsReceived_t>.NativeClassPtr);
			GSStatsReceived_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSStatsReceived_t>.NativeClassPtr, "Result");
			GSStatsReceived_t.NativeFieldInfoPtr_SteamIDUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSStatsReceived_t>.NativeClassPtr, "SteamIDUser");
			GSStatsReceived_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSStatsReceived_t>.NativeClassPtr, "_datasize");
			GSStatsReceived_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GSStatsReceived_t>.NativeClassPtr, 100667371);
			GSStatsReceived_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GSStatsReceived_t>.NativeClassPtr, 100667372);
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06001527 RID: 5415 RVA: 0x0006C1C0 File Offset: 0x0006A3C0
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951048, XrefRangeEnd = 951052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GSStatsReceived_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06001528 RID: 5416 RVA: 0x0006C1F0 File Offset: 0x0006A3F0
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GSStatsReceived_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x00006E3D File Offset: 0x0000503D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GSStatsReceived_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x0600152A RID: 5418 RVA: 0x0006C220 File Offset: 0x0006A420
		// (set) Token: 0x0600152B RID: 5419 RVA: 0x00006E4F File Offset: 0x0000504F
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GSStatsReceived_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GSStatsReceived_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001AE2 RID: 6882
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x04001AE3 RID: 6883
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDUser;

		// Token: 0x04001AE4 RID: 6884
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001AE5 RID: 6885
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001AE6 RID: 6886
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001AE7 RID: 6887
		[FieldOffset(0)]
		public Result Result;

		// Token: 0x04001AE8 RID: 6888
		[FieldOffset(4)]
		public ulong SteamIDUser;
	}
}
