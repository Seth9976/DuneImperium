using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000198 RID: 408
	[StructLayout(2)]
	public struct SteamInventoryEligiblePromoItemDefIDs_t
	{
		// Token: 0x06001462 RID: 5218 RVA: 0x0006A0D4 File Offset: 0x000682D4
		// Note: this type is marked as 'beforefieldinit'.
		static SteamInventoryEligiblePromoItemDefIDs_t()
		{
			Il2CppClassPointerStore<SteamInventoryEligiblePromoItemDefIDs_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SteamInventoryEligiblePromoItemDefIDs_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInventoryEligiblePromoItemDefIDs_t>.NativeClassPtr);
			SteamInventoryEligiblePromoItemDefIDs_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryEligiblePromoItemDefIDs_t>.NativeClassPtr, "Result");
			SteamInventoryEligiblePromoItemDefIDs_t.NativeFieldInfoPtr_SteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryEligiblePromoItemDefIDs_t>.NativeClassPtr, "SteamID");
			SteamInventoryEligiblePromoItemDefIDs_t.NativeFieldInfoPtr_UmEligiblePromoItemDefs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryEligiblePromoItemDefIDs_t>.NativeClassPtr, "UmEligiblePromoItemDefs");
			SteamInventoryEligiblePromoItemDefIDs_t.NativeFieldInfoPtr_CachedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryEligiblePromoItemDefIDs_t>.NativeClassPtr, "CachedData");
			SteamInventoryEligiblePromoItemDefIDs_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryEligiblePromoItemDefIDs_t>.NativeClassPtr, "_datasize");
			SteamInventoryEligiblePromoItemDefIDs_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryEligiblePromoItemDefIDs_t>.NativeClassPtr, 100667296);
			SteamInventoryEligiblePromoItemDefIDs_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryEligiblePromoItemDefIDs_t>.NativeClassPtr, 100667297);
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06001463 RID: 5219 RVA: 0x0006A190 File Offset: 0x00068390
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950931, XrefRangeEnd = 950935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryEligiblePromoItemDefIDs_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06001464 RID: 5220 RVA: 0x0006A1C0 File Offset: 0x000683C0
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryEligiblePromoItemDefIDs_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x00006885 File Offset: 0x00004A85
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamInventoryEligiblePromoItemDefIDs_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06001466 RID: 5222 RVA: 0x0006A1F0 File Offset: 0x000683F0
		// (set) Token: 0x06001467 RID: 5223 RVA: 0x00006897 File Offset: 0x00004A97
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamInventoryEligiblePromoItemDefIDs_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamInventoryEligiblePromoItemDefIDs_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001A35 RID: 6709
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x04001A36 RID: 6710
		private static readonly IntPtr NativeFieldInfoPtr_SteamID;

		// Token: 0x04001A37 RID: 6711
		private static readonly IntPtr NativeFieldInfoPtr_UmEligiblePromoItemDefs;

		// Token: 0x04001A38 RID: 6712
		private static readonly IntPtr NativeFieldInfoPtr_CachedData;

		// Token: 0x04001A39 RID: 6713
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x04001A3A RID: 6714
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001A3B RID: 6715
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x04001A3C RID: 6716
		[FieldOffset(0)]
		public Result Result;

		// Token: 0x04001A3D RID: 6717
		[FieldOffset(4)]
		public ulong SteamID;

		// Token: 0x04001A3E RID: 6718
		[FieldOffset(12)]
		public int UmEligiblePromoItemDefs;

		// Token: 0x04001A3F RID: 6719
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool CachedData;
	}
}
