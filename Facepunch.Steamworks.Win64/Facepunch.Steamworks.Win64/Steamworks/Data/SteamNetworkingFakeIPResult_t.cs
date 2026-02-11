using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001B2 RID: 434
	public sealed class SteamNetworkingFakeIPResult_t : ValueType
	{
		// Token: 0x06001538 RID: 5432 RVA: 0x0006C448 File Offset: 0x0006A648
		// Note: this type is marked as 'beforefieldinit'.
		static SteamNetworkingFakeIPResult_t()
		{
			Il2CppClassPointerStore<SteamNetworkingFakeIPResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SteamNetworkingFakeIPResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamNetworkingFakeIPResult_t>.NativeClassPtr);
			SteamNetworkingFakeIPResult_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingFakeIPResult_t>.NativeClassPtr, "Result");
			SteamNetworkingFakeIPResult_t.NativeFieldInfoPtr_Dentity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingFakeIPResult_t>.NativeClassPtr, "Dentity");
			SteamNetworkingFakeIPResult_t.NativeFieldInfoPtr_IP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingFakeIPResult_t>.NativeClassPtr, "IP");
			SteamNetworkingFakeIPResult_t.NativeFieldInfoPtr_Ports = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingFakeIPResult_t>.NativeClassPtr, "Ports");
			SteamNetworkingFakeIPResult_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingFakeIPResult_t>.NativeClassPtr, "_datasize");
			SteamNetworkingFakeIPResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingFakeIPResult_t>.NativeClassPtr, 100667380);
			SteamNetworkingFakeIPResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingFakeIPResult_t>.NativeClassPtr, 100667381);
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06001539 RID: 5433 RVA: 0x0006C504 File Offset: 0x0006A704
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951060, XrefRangeEnd = 951064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingFakeIPResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x0600153A RID: 5434 RVA: 0x0006C548 File Offset: 0x0006A748
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingFakeIPResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x00006E9D File Offset: 0x0000509D
		public SteamNetworkingFakeIPResult_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x00006EA6 File Offset: 0x000050A6
		public SteamNetworkingFakeIPResult_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamNetworkingFakeIPResult_t>.NativeClassPtr))
		{
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x0600153D RID: 5437 RVA: 0x0006C58C File Offset: 0x0006A78C
		// (set) Token: 0x0600153E RID: 5438 RVA: 0x00006EB8 File Offset: 0x000050B8
		public unsafe Result Result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingFakeIPResult_t.NativeFieldInfoPtr_Result);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingFakeIPResult_t.NativeFieldInfoPtr_Result)) = value;
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x0600153F RID: 5439 RVA: 0x0006C5B4 File Offset: 0x0006A7B4
		// (set) Token: 0x06001540 RID: 5440 RVA: 0x00006ED3 File Offset: 0x000050D3
		public unsafe NetIdentity Dentity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingFakeIPResult_t.NativeFieldInfoPtr_Dentity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingFakeIPResult_t.NativeFieldInfoPtr_Dentity)) = value;
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06001541 RID: 5441 RVA: 0x0006C5DC File Offset: 0x0006A7DC
		// (set) Token: 0x06001542 RID: 5442 RVA: 0x00006EEE File Offset: 0x000050EE
		public unsafe uint IP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingFakeIPResult_t.NativeFieldInfoPtr_IP);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingFakeIPResult_t.NativeFieldInfoPtr_IP)) = value;
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06001543 RID: 5443 RVA: 0x0006C604 File Offset: 0x0006A804
		// (set) Token: 0x06001544 RID: 5444 RVA: 0x00006F09 File Offset: 0x00005109
		public unsafe Il2CppStructArray<ushort> Ports
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingFakeIPResult_t.NativeFieldInfoPtr_Ports);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ushort>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingFakeIPResult_t.NativeFieldInfoPtr_Ports), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06001545 RID: 5445 RVA: 0x0006C634 File Offset: 0x0006A834
		// (set) Token: 0x06001546 RID: 5446 RVA: 0x00006F28 File Offset: 0x00005128
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamNetworkingFakeIPResult_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamNetworkingFakeIPResult_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001AF5 RID: 6901
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x04001AF6 RID: 6902
		private static readonly IntPtr NativeFieldInfoPtr_Dentity;

		// Token: 0x04001AF7 RID: 6903
		private static readonly IntPtr NativeFieldInfoPtr_IP;

		// Token: 0x04001AF8 RID: 6904
		private static readonly IntPtr NativeFieldInfoPtr_Ports;

		// Token: 0x04001AF9 RID: 6905
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001AFA RID: 6906
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001AFB RID: 6907
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}
