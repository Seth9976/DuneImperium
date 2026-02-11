using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020000E2 RID: 226
	[StructLayout(2)]
	public struct SteamServerConnectFailure_t
	{
		// Token: 0x06000EAE RID: 3758 RVA: 0x0005B0E4 File Offset: 0x000592E4
		// Note: this type is marked as 'beforefieldinit'.
		static SteamServerConnectFailure_t()
		{
			Il2CppClassPointerStore<SteamServerConnectFailure_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SteamServerConnectFailure_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamServerConnectFailure_t>.NativeClassPtr);
			SteamServerConnectFailure_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServerConnectFailure_t>.NativeClassPtr, "Result");
			SteamServerConnectFailure_t.NativeFieldInfoPtr_StillRetrying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServerConnectFailure_t>.NativeClassPtr, "StillRetrying");
			SteamServerConnectFailure_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServerConnectFailure_t>.NativeClassPtr, "_datasize");
			SteamServerConnectFailure_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServerConnectFailure_t>.NativeClassPtr, 100666732);
			SteamServerConnectFailure_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamServerConnectFailure_t>.NativeClassPtr, 100666733);
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000EAF RID: 3759 RVA: 0x0005B178 File Offset: 0x00059378
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950117, XrefRangeEnd = 950121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServerConnectFailure_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000EB0 RID: 3760 RVA: 0x0005B1A8 File Offset: 0x000593A8
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamServerConnectFailure_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x00003F1B File Offset: 0x0000211B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamServerConnectFailure_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000EB2 RID: 3762 RVA: 0x0005B1D8 File Offset: 0x000593D8
		// (set) Token: 0x06000EB3 RID: 3763 RVA: 0x00003F2D File Offset: 0x0000212D
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamServerConnectFailure_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamServerConnectFailure_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040014CA RID: 5322
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x040014CB RID: 5323
		private static readonly IntPtr NativeFieldInfoPtr_StillRetrying;

		// Token: 0x040014CC RID: 5324
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040014CD RID: 5325
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040014CE RID: 5326
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x040014CF RID: 5327
		[FieldOffset(0)]
		public Result Result;

		// Token: 0x040014D0 RID: 5328
		[FieldOffset(4)]
		[MarshalAs(4)]
		public bool StillRetrying;
	}
}
