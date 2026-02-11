using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x0200016A RID: 362
	public sealed class SteamUGCRequestUGCDetailsResult_t : ValueType
	{
		// Token: 0x060012C0 RID: 4800 RVA: 0x00065FCC File Offset: 0x000641CC
		// Note: this type is marked as 'beforefieldinit'.
		static SteamUGCRequestUGCDetailsResult_t()
		{
			Il2CppClassPointerStore<SteamUGCRequestUGCDetailsResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SteamUGCRequestUGCDetailsResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUGCRequestUGCDetailsResult_t>.NativeClassPtr);
			SteamUGCRequestUGCDetailsResult_t.NativeFieldInfoPtr_Details = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCRequestUGCDetailsResult_t>.NativeClassPtr, "Details");
			SteamUGCRequestUGCDetailsResult_t.NativeFieldInfoPtr_CachedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCRequestUGCDetailsResult_t>.NativeClassPtr, "CachedData");
			SteamUGCRequestUGCDetailsResult_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCRequestUGCDetailsResult_t>.NativeClassPtr, "_datasize");
			SteamUGCRequestUGCDetailsResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGCRequestUGCDetailsResult_t>.NativeClassPtr, 100667158);
			SteamUGCRequestUGCDetailsResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGCRequestUGCDetailsResult_t>.NativeClassPtr, 100667159);
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x060012C1 RID: 4801 RVA: 0x00066060 File Offset: 0x00064260
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950743, XrefRangeEnd = 950747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGCRequestUGCDetailsResult_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x060012C2 RID: 4802 RVA: 0x000660A4 File Offset: 0x000642A4
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGCRequestUGCDetailsResult_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x00005B29 File Offset: 0x00003D29
		public SteamUGCRequestUGCDetailsResult_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x00005B32 File Offset: 0x00003D32
		public SteamUGCRequestUGCDetailsResult_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamUGCRequestUGCDetailsResult_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x060012C5 RID: 4805 RVA: 0x000660E8 File Offset: 0x000642E8
		// (set) Token: 0x060012C6 RID: 4806 RVA: 0x00005B44 File Offset: 0x00003D44
		public SteamUGCDetails_t Details
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCRequestUGCDetailsResult_t.NativeFieldInfoPtr_Details);
				return new SteamUGCDetails_t(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCRequestUGCDetailsResult_t.NativeFieldInfoPtr_Details), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x060012C7 RID: 4807 RVA: 0x00066118 File Offset: 0x00064318
		// (set) Token: 0x060012C8 RID: 4808 RVA: 0x00005B72 File Offset: 0x00003D72
		public unsafe bool CachedData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCRequestUGCDetailsResult_t.NativeFieldInfoPtr_CachedData);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCRequestUGCDetailsResult_t.NativeFieldInfoPtr_CachedData)) = value;
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x060012C9 RID: 4809 RVA: 0x00066140 File Offset: 0x00064340
		// (set) Token: 0x060012CA RID: 4810 RVA: 0x00005B8D File Offset: 0x00003D8D
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamUGCRequestUGCDetailsResult_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamUGCRequestUGCDetailsResult_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040018D2 RID: 6354
		private static readonly IntPtr NativeFieldInfoPtr_Details;

		// Token: 0x040018D3 RID: 6355
		private static readonly IntPtr NativeFieldInfoPtr_CachedData;

		// Token: 0x040018D4 RID: 6356
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040018D5 RID: 6357
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040018D6 RID: 6358
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}
