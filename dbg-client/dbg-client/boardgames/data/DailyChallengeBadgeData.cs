using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.data
{
	// Token: 0x02000184 RID: 388
	public class DailyChallengeBadgeData : DataComponent
	{
		// Token: 0x060010EF RID: 4335 RVA: 0x00053040 File Offset: 0x00051240
		// Note: this type is marked as 'beforefieldinit'.
		static DailyChallengeBadgeData()
		{
			Il2CppClassPointerStore<DailyChallengeBadgeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.data", "DailyChallengeBadgeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyChallengeBadgeData>.NativeClassPtr);
			DailyChallengeBadgeData.NativeFieldInfoPtr_Badge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeBadgeData>.NativeClassPtr, "Badge");
			DailyChallengeBadgeData.NativeFieldInfoPtr_Rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeBadgeData>.NativeClassPtr, "Rank");
			DailyChallengeBadgeData.NativeFieldInfoPtr_Date = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeBadgeData>.NativeClassPtr, "Date");
			DailyChallengeBadgeData.NativeFieldInfoPtr_Difficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeBadgeData>.NativeClassPtr, "Difficulty");
			DailyChallengeBadgeData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeBadgeData>.NativeClassPtr, 100665662);
			DailyChallengeBadgeData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeBadgeData>.NativeClassPtr, 100665663);
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x000530E8 File Offset: 0x000512E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 514343, RefRangeEnd = 514344, XrefRangeStart = 514341, XrefRangeEnd = 514343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DailyChallengeBadgeData(string badge, int rank, long date, int difficulty)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyChallengeBadgeData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(badge);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rank;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref date;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref difficulty;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeBadgeData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int64_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x00053160 File Offset: 0x00051360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514344, XrefRangeEnd = 514350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailyChallengeBadgeData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x0000A2A6 File Offset: 0x000084A6
		public DailyChallengeBadgeData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x060010F3 RID: 4339 RVA: 0x000531A4 File Offset: 0x000513A4
		// (set) Token: 0x060010F4 RID: 4340 RVA: 0x0000A2AF File Offset: 0x000084AF
		public unsafe string Badge
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeBadgeData.NativeFieldInfoPtr_Badge);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeBadgeData.NativeFieldInfoPtr_Badge), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x060010F5 RID: 4341 RVA: 0x000531CC File Offset: 0x000513CC
		// (set) Token: 0x060010F6 RID: 4342 RVA: 0x0000A2CE File Offset: 0x000084CE
		public unsafe int Rank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeBadgeData.NativeFieldInfoPtr_Rank);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeBadgeData.NativeFieldInfoPtr_Rank)) = value;
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x060010F7 RID: 4343 RVA: 0x000531F4 File Offset: 0x000513F4
		// (set) Token: 0x060010F8 RID: 4344 RVA: 0x0000A2E9 File Offset: 0x000084E9
		public unsafe long Date
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeBadgeData.NativeFieldInfoPtr_Date);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeBadgeData.NativeFieldInfoPtr_Date)) = value;
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x060010F9 RID: 4345 RVA: 0x0005321C File Offset: 0x0005141C
		// (set) Token: 0x060010FA RID: 4346 RVA: 0x0000A304 File Offset: 0x00008504
		public unsafe int Difficulty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeBadgeData.NativeFieldInfoPtr_Difficulty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeBadgeData.NativeFieldInfoPtr_Difficulty)) = value;
			}
		}

		// Token: 0x04000A4C RID: 2636
		private static readonly IntPtr NativeFieldInfoPtr_Badge;

		// Token: 0x04000A4D RID: 2637
		private static readonly IntPtr NativeFieldInfoPtr_Rank;

		// Token: 0x04000A4E RID: 2638
		private static readonly IntPtr NativeFieldInfoPtr_Date;

		// Token: 0x04000A4F RID: 2639
		private static readonly IntPtr NativeFieldInfoPtr_Difficulty;

		// Token: 0x04000A50 RID: 2640
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int64_Int32_0;

		// Token: 0x04000A51 RID: 2641
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
