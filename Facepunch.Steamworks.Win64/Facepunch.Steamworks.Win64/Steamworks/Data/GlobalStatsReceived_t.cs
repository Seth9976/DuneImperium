using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000148 RID: 328
	[StructLayout(2)]
	public struct GlobalStatsReceived_t
	{
		// Token: 0x060011D3 RID: 4563 RVA: 0x00063950 File Offset: 0x00061B50
		// Note: this type is marked as 'beforefieldinit'.
		static GlobalStatsReceived_t()
		{
			Il2CppClassPointerStore<GlobalStatsReceived_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "GlobalStatsReceived_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalStatsReceived_t>.NativeClassPtr);
			GlobalStatsReceived_t.NativeFieldInfoPtr_GameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalStatsReceived_t>.NativeClassPtr, "GameID");
			GlobalStatsReceived_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalStatsReceived_t>.NativeClassPtr, "Result");
			GlobalStatsReceived_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalStatsReceived_t>.NativeClassPtr, "_datasize");
			GlobalStatsReceived_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalStatsReceived_t>.NativeClassPtr, 100667054);
			GlobalStatsReceived_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalStatsReceived_t>.NativeClassPtr, 100667055);
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x060011D4 RID: 4564 RVA: 0x000639E4 File Offset: 0x00061BE4
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950599, XrefRangeEnd = 950603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalStatsReceived_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x060011D5 RID: 4565 RVA: 0x00063A14 File Offset: 0x00061C14
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalStatsReceived_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x00005548 File Offset: 0x00003748
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalStatsReceived_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x060011D7 RID: 4567 RVA: 0x00063A44 File Offset: 0x00061C44
		// (set) Token: 0x060011D8 RID: 4568 RVA: 0x0000555A File Offset: 0x0000375A
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GlobalStatsReceived_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GlobalStatsReceived_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x0400180A RID: 6154
		private static readonly IntPtr NativeFieldInfoPtr_GameID;

		// Token: 0x0400180B RID: 6155
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x0400180C RID: 6156
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x0400180D RID: 6157
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400180E RID: 6158
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x0400180F RID: 6159
		[FieldOffset(0)]
		public ulong GameID;

		// Token: 0x04001810 RID: 6160
		[FieldOffset(8)]
		public Result Result;
	}
}
