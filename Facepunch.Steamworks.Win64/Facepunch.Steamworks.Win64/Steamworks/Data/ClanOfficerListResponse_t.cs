using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020000F4 RID: 244
	[StructLayout(2)]
	public struct ClanOfficerListResponse_t
	{
		// Token: 0x06000F29 RID: 3881 RVA: 0x0005C71C File Offset: 0x0005A91C
		// Note: this type is marked as 'beforefieldinit'.
		static ClanOfficerListResponse_t()
		{
			Il2CppClassPointerStore<ClanOfficerListResponse_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "ClanOfficerListResponse_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClanOfficerListResponse_t>.NativeClassPtr);
			ClanOfficerListResponse_t.NativeFieldInfoPtr_SteamIDClan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanOfficerListResponse_t>.NativeClassPtr, "SteamIDClan");
			ClanOfficerListResponse_t.NativeFieldInfoPtr_COfficers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanOfficerListResponse_t>.NativeClassPtr, "COfficers");
			ClanOfficerListResponse_t.NativeFieldInfoPtr_Success = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanOfficerListResponse_t>.NativeClassPtr, "Success");
			ClanOfficerListResponse_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanOfficerListResponse_t>.NativeClassPtr, "_datasize");
			ClanOfficerListResponse_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanOfficerListResponse_t>.NativeClassPtr, 100666790);
			ClanOfficerListResponse_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanOfficerListResponse_t>.NativeClassPtr, 100666791);
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000F2A RID: 3882 RVA: 0x0005C7C4 File Offset: 0x0005A9C4
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950209, XrefRangeEnd = 950213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClanOfficerListResponse_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000F2B RID: 3883 RVA: 0x0005C7F4 File Offset: 0x0005A9F4
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClanOfficerListResponse_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x000041F2 File Offset: 0x000023F2
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClanOfficerListResponse_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000F2D RID: 3885 RVA: 0x0005C824 File Offset: 0x0005AA24
		// (set) Token: 0x06000F2E RID: 3886 RVA: 0x00004204 File Offset: 0x00002404
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ClanOfficerListResponse_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClanOfficerListResponse_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x04001558 RID: 5464
		private static readonly IntPtr NativeFieldInfoPtr_SteamIDClan;

		// Token: 0x04001559 RID: 5465
		private static readonly IntPtr NativeFieldInfoPtr_COfficers;

		// Token: 0x0400155A RID: 5466
		private static readonly IntPtr NativeFieldInfoPtr_Success;

		// Token: 0x0400155B RID: 5467
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x0400155C RID: 5468
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400155D RID: 5469
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;

		// Token: 0x0400155E RID: 5470
		[FieldOffset(0)]
		public ulong SteamIDClan;

		// Token: 0x0400155F RID: 5471
		[FieldOffset(8)]
		public int COfficers;

		// Token: 0x04001560 RID: 5472
		[FieldOffset(12)]
		public byte Success;
	}
}
