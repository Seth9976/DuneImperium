using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020000FF RID: 255
	public sealed class FriendsEnumerateFollowingList_t : ValueType
	{
		// Token: 0x06000F71 RID: 3953 RVA: 0x0005D400 File Offset: 0x0005B600
		// Note: this type is marked as 'beforefieldinit'.
		static FriendsEnumerateFollowingList_t()
		{
			Il2CppClassPointerStore<FriendsEnumerateFollowingList_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "FriendsEnumerateFollowingList_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendsEnumerateFollowingList_t>.NativeClassPtr);
			FriendsEnumerateFollowingList_t.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsEnumerateFollowingList_t>.NativeClassPtr, "Result");
			FriendsEnumerateFollowingList_t.NativeFieldInfoPtr_GSteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsEnumerateFollowingList_t>.NativeClassPtr, "GSteamID");
			FriendsEnumerateFollowingList_t.NativeFieldInfoPtr_ResultsReturned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsEnumerateFollowingList_t>.NativeClassPtr, "ResultsReturned");
			FriendsEnumerateFollowingList_t.NativeFieldInfoPtr_TotalResultCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsEnumerateFollowingList_t>.NativeClassPtr, "TotalResultCount");
			FriendsEnumerateFollowingList_t.NativeFieldInfoPtr__datasize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsEnumerateFollowingList_t>.NativeClassPtr, "_datasize");
			FriendsEnumerateFollowingList_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsEnumerateFollowingList_t>.NativeClassPtr, 100666824);
			FriendsEnumerateFollowingList_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsEnumerateFollowingList_t>.NativeClassPtr, 100666825);
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000F72 RID: 3954 RVA: 0x0005D4BC File Offset: 0x0005B6BC
		public unsafe int DataSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 950258, XrefRangeEnd = 950262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsEnumerateFollowingList_t.NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000F73 RID: 3955 RVA: 0x0005D500 File Offset: 0x0005B700
		public unsafe CallbackType CallbackType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsEnumerateFollowingList_t.NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x00004395 File Offset: 0x00002595
		public FriendsEnumerateFollowingList_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x0000439E File Offset: 0x0000259E
		public FriendsEnumerateFollowingList_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendsEnumerateFollowingList_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000F76 RID: 3958 RVA: 0x0005D544 File Offset: 0x0005B744
		// (set) Token: 0x06000F77 RID: 3959 RVA: 0x000043B0 File Offset: 0x000025B0
		public unsafe Result Result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsEnumerateFollowingList_t.NativeFieldInfoPtr_Result);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsEnumerateFollowingList_t.NativeFieldInfoPtr_Result)) = value;
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000F78 RID: 3960 RVA: 0x0005D56C File Offset: 0x0005B76C
		// (set) Token: 0x06000F79 RID: 3961 RVA: 0x000043CB File Offset: 0x000025CB
		public unsafe Il2CppStructArray<ulong> GSteamID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsEnumerateFollowingList_t.NativeFieldInfoPtr_GSteamID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ulong>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsEnumerateFollowingList_t.NativeFieldInfoPtr_GSteamID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000F7A RID: 3962 RVA: 0x0005D59C File Offset: 0x0005B79C
		// (set) Token: 0x06000F7B RID: 3963 RVA: 0x000043EA File Offset: 0x000025EA
		public unsafe int ResultsReturned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsEnumerateFollowingList_t.NativeFieldInfoPtr_ResultsReturned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsEnumerateFollowingList_t.NativeFieldInfoPtr_ResultsReturned)) = value;
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000F7C RID: 3964 RVA: 0x0005D5C4 File Offset: 0x0005B7C4
		// (set) Token: 0x06000F7D RID: 3965 RVA: 0x00004405 File Offset: 0x00002605
		public unsafe int TotalResultCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsEnumerateFollowingList_t.NativeFieldInfoPtr_TotalResultCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsEnumerateFollowingList_t.NativeFieldInfoPtr_TotalResultCount)) = value;
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000F7E RID: 3966 RVA: 0x0005D5EC File Offset: 0x0005B7EC
		// (set) Token: 0x06000F7F RID: 3967 RVA: 0x00004420 File Offset: 0x00002620
		public unsafe static int _datasize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FriendsEnumerateFollowingList_t.NativeFieldInfoPtr__datasize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FriendsEnumerateFollowingList_t.NativeFieldInfoPtr__datasize, (void*)(&value));
			}
		}

		// Token: 0x040015AE RID: 5550
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x040015AF RID: 5551
		private static readonly IntPtr NativeFieldInfoPtr_GSteamID;

		// Token: 0x040015B0 RID: 5552
		private static readonly IntPtr NativeFieldInfoPtr_ResultsReturned;

		// Token: 0x040015B1 RID: 5553
		private static readonly IntPtr NativeFieldInfoPtr_TotalResultCount;

		// Token: 0x040015B2 RID: 5554
		private static readonly IntPtr NativeFieldInfoPtr__datasize;

		// Token: 0x040015B3 RID: 5555
		private static readonly IntPtr NativeMethodInfoPtr_get_DataSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040015B4 RID: 5556
		private static readonly IntPtr NativeMethodInfoPtr_get_CallbackType_Public_Virtual_Final_New_get_CallbackType_0;
	}
}
