using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020000ED RID: 237
	[StructLayout(2)]
	public struct MarketEligibilityResponse_t
	{
		// Token: 0x06000EF8 RID: 3832 RVA: 0x0005BDBC File Offset: 0x00059FBC
		// Note: this type is marked as 'beforefieldinit'.
		static MarketEligibilityResponse_t()
		{
			Il2CppClassPointerStore<MarketEligibilityResponse_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "MarketEligibilityResponse_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MarketEligibilityResponse_t>.NativeClassPtr);
			MarketEligibilityResponse_t.NativeFieldInfoPtr_Allowed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarketEligibilityResponse_t>.NativeClassPtr, "Allowed");
			MarketEligibilityResponse_t.NativeFieldInfoPtr_NotAllowedReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarketEligibilityResponse_t>.NativeClassPtr, "NotAllowedReason");
			MarketEligibilityResponse_t.NativeFieldInfoPtr_TAllowedAtTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarketEligibilityResponse_t>.NativeClassPtr, "TAllowedAtTime");
			MarketEligibilityResponse_t.NativeFieldInfoPtr_CdaySteamGuardRequiredDays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarketEligibilityResponse_t>.NativeClassPtr, "CdaySteamGuardRequiredDays");
			MarketEligibilityResponse_t.NativeFieldInfoPtr_CdayNewDeviceCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarketEligibilityResponse_t>.NativeClassPtr, "CdayNewDeviceCooldown");
			MarketEligibilityResponse_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarketEligibilityResponse_t>.NativeClassPtr, "_datasize");
			MarketEligibilityResponse_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarketEligibilityResponse_t>.NativeClassPtr, 100666767);
			MarketEligibilityResponse_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarketEligibilityResponse_t>.NativeClassPtr, 100666768);
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000EF9 RID: 3833 RVA: 0x0005BE8C File Offset: 0x0005A08C
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950171, XrefRangeEnd = 950175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarketEligibilityResponse_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000EFA RID: 3834 RVA: 0x0005BEBC File Offset: 0x0005A0BC
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarketEligibilityResponse_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x000040CB File Offset: 0x000022CB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MarketEligibilityResponse_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000EFC RID: 3836 RVA: 0x0005BEEC File Offset: 0x0005A0EC
		// (set) Token: 0x06000EFD RID: 3837 RVA: 0x000040DD File Offset: 0x000022DD
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MarketEligibilityResponse_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MarketEligibilityResponse_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001513 RID: 5395
		private static readonly IntPtr NativeFieldInfoPtr_Allowed;

		// Token: 0x04001514 RID: 5396
		private static readonly IntPtr NativeFieldInfoPtr_NotAllowedReason;

		// Token: 0x04001515 RID: 5397
		private static readonly IntPtr NativeFieldInfoPtr_TAllowedAtTime;

		// Token: 0x04001516 RID: 5398
		private static readonly IntPtr NativeFieldInfoPtr_CdaySteamGuardRequiredDays;

		// Token: 0x04001517 RID: 5399
		private static readonly IntPtr NativeFieldInfoPtr_CdayNewDeviceCooldown;

		// Token: 0x04001518 RID: 5400
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001519 RID: 5401
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400151A RID: 5402
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x0400151B RID: 5403
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool Allowed;

		// Token: 0x0400151C RID: 5404
		[FieldOffset(4)]
		public MarketNotAllowedReasonFlags NotAllowedReason;

		// Token: 0x0400151D RID: 5405
		[FieldOffset(8)]
		public uint TAllowedAtTime;

		// Token: 0x0400151E RID: 5406
		[FieldOffset(12)]
		public int CdaySteamGuardRequiredDays;

		// Token: 0x0400151F RID: 5407
		[FieldOffset(16)]
		public int CdayNewDeviceCooldown;
	}
}
