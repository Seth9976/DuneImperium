using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001A4 RID: 420
	public sealed class SteamRelayNetworkStatus_t : ValueType
	{
		// Token: 0x060014C8 RID: 5320 RVA: 0x0006B118 File Offset: 0x00069318
		// Note: this type is marked as 'beforefieldinit'.
		static SteamRelayNetworkStatus_t()
		{
			Il2CppClassPointerStore<SteamRelayNetworkStatus_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SteamRelayNetworkStatus_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamRelayNetworkStatus_t>.NativeClassPtr);
			SteamRelayNetworkStatus_t.NativeFieldInfoPtr_Avail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamRelayNetworkStatus_t>.NativeClassPtr, "Avail");
			SteamRelayNetworkStatus_t.NativeFieldInfoPtr_PingMeasurementInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamRelayNetworkStatus_t>.NativeClassPtr, "PingMeasurementInProgress");
			SteamRelayNetworkStatus_t.NativeFieldInfoPtr_AvailNetworkConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamRelayNetworkStatus_t>.NativeClassPtr, "AvailNetworkConfig");
			SteamRelayNetworkStatus_t.NativeFieldInfoPtr_AvailAnyRelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamRelayNetworkStatus_t>.NativeClassPtr, "AvailAnyRelay");
			SteamRelayNetworkStatus_t.NativeFieldInfoPtr_DebugMsg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamRelayNetworkStatus_t>.NativeClassPtr, "DebugMsg");
			SteamRelayNetworkStatus_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamRelayNetworkStatus_t>.NativeClassPtr, "_datasize");
			SteamRelayNetworkStatus_t.NativeMethodInfoPtr_DebugMsgUTF8_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRelayNetworkStatus_t>.NativeClassPtr, 100667335);
			SteamRelayNetworkStatus_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRelayNetworkStatus_t>.NativeClassPtr, 100667336);
			SteamRelayNetworkStatus_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRelayNetworkStatus_t>.NativeClassPtr, 100667337);
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x0006B1FC File Offset: 0x000693FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950992, XrefRangeEnd = 950996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string DebugMsgUTF8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRelayNetworkStatus_t.NativeMethodInfoPtr_DebugMsgUTF8_Internal_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x060014CA RID: 5322 RVA: 0x0006B238 File Offset: 0x00069438
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950996, XrefRangeEnd = 951000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRelayNetworkStatus_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x060014CB RID: 5323 RVA: 0x0006B27C File Offset: 0x0006947C
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRelayNetworkStatus_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x00006B8D File Offset: 0x00004D8D
		public SteamRelayNetworkStatus_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x00006B96 File Offset: 0x00004D96
		public SteamRelayNetworkStatus_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamRelayNetworkStatus_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x060014CE RID: 5326 RVA: 0x0006B2C0 File Offset: 0x000694C0
		// (set) Token: 0x060014CF RID: 5327 RVA: 0x00006BA8 File Offset: 0x00004DA8
		public unsafe SteamNetworkingAvailability Avail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamRelayNetworkStatus_t.NativeFieldInfoPtr_Avail);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamRelayNetworkStatus_t.NativeFieldInfoPtr_Avail)) = value;
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x060014D0 RID: 5328 RVA: 0x0006B2E8 File Offset: 0x000694E8
		// (set) Token: 0x060014D1 RID: 5329 RVA: 0x00006BC3 File Offset: 0x00004DC3
		public unsafe int PingMeasurementInProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamRelayNetworkStatus_t.NativeFieldInfoPtr_PingMeasurementInProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamRelayNetworkStatus_t.NativeFieldInfoPtr_PingMeasurementInProgress)) = value;
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x060014D2 RID: 5330 RVA: 0x0006B310 File Offset: 0x00069510
		// (set) Token: 0x060014D3 RID: 5331 RVA: 0x00006BDE File Offset: 0x00004DDE
		public unsafe SteamNetworkingAvailability AvailNetworkConfig
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamRelayNetworkStatus_t.NativeFieldInfoPtr_AvailNetworkConfig);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamRelayNetworkStatus_t.NativeFieldInfoPtr_AvailNetworkConfig)) = value;
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x060014D4 RID: 5332 RVA: 0x0006B338 File Offset: 0x00069538
		// (set) Token: 0x060014D5 RID: 5333 RVA: 0x00006BF9 File Offset: 0x00004DF9
		public unsafe SteamNetworkingAvailability AvailAnyRelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamRelayNetworkStatus_t.NativeFieldInfoPtr_AvailAnyRelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamRelayNetworkStatus_t.NativeFieldInfoPtr_AvailAnyRelay)) = value;
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x060014D6 RID: 5334 RVA: 0x0006B360 File Offset: 0x00069560
		// (set) Token: 0x060014D7 RID: 5335 RVA: 0x00006C14 File Offset: 0x00004E14
		public unsafe Il2CppStructArray<byte> DebugMsg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamRelayNetworkStatus_t.NativeFieldInfoPtr_DebugMsg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamRelayNetworkStatus_t.NativeFieldInfoPtr_DebugMsg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x060014D8 RID: 5336 RVA: 0x0006B390 File Offset: 0x00069590
		// (set) Token: 0x060014D9 RID: 5337 RVA: 0x00006C33 File Offset: 0x00004E33
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamRelayNetworkStatus_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamRelayNetworkStatus_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001A7F RID: 6783
		private static readonly IntPtr NativeFieldInfoPtr_Avail;

		// Token: 0x04001A80 RID: 6784
		private static readonly IntPtr NativeFieldInfoPtr_PingMeasurementInProgress;

		// Token: 0x04001A81 RID: 6785
		private static readonly IntPtr NativeFieldInfoPtr_AvailNetworkConfig;

		// Token: 0x04001A82 RID: 6786
		private static readonly IntPtr NativeFieldInfoPtr_AvailAnyRelay;

		// Token: 0x04001A83 RID: 6787
		private static readonly IntPtr NativeFieldInfoPtr_DebugMsg;

		// Token: 0x04001A84 RID: 6788
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001A85 RID: 6789
		private static readonly IntPtr NativeMethodInfoPtr_DebugMsgUTF8_Internal_String_0;

		// Token: 0x04001A86 RID: 6790
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001A87 RID: 6791
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}
