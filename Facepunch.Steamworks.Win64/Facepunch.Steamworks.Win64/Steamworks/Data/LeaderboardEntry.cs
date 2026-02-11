using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000201 RID: 513
	public sealed class LeaderboardEntry : ValueType
	{
		// Token: 0x06001991 RID: 6545 RVA: 0x0007BB18 File Offset: 0x00079D18
		// Note: this type is marked as 'beforefieldinit'.
		static LeaderboardEntry()
		{
			Il2CppClassPointerStore<LeaderboardEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "LeaderboardEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderboardEntry>.NativeClassPtr);
			LeaderboardEntry.NativeFieldInfoPtr_User = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardEntry>.NativeClassPtr, "User");
			LeaderboardEntry.NativeFieldInfoPtr_GlobalRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardEntry>.NativeClassPtr, "GlobalRank");
			LeaderboardEntry.NativeFieldInfoPtr_Score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardEntry>.NativeClassPtr, "Score");
			LeaderboardEntry.NativeFieldInfoPtr_Details = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardEntry>.NativeClassPtr, "Details");
			LeaderboardEntry.NativeMethodInfoPtr_From_Internal_Static_LeaderboardEntry_LeaderboardEntry_t_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardEntry>.NativeClassPtr, 100667963);
		}

		// Token: 0x06001992 RID: 6546 RVA: 0x0007BBAC File Offset: 0x00079DAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 952396, RefRangeEnd = 952397, XrefRangeStart = 952387, XrefRangeEnd = 952396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LeaderboardEntry From(LeaderboardEntry_t e, Il2CppStructArray<int> detailsBuffer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref e;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(detailsBuffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardEntry.NativeMethodInfoPtr_From_Internal_Static_LeaderboardEntry_LeaderboardEntry_t_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new LeaderboardEntry(intPtr);
		}

		// Token: 0x06001993 RID: 6547 RVA: 0x000084F3 File Offset: 0x000066F3
		public LeaderboardEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001994 RID: 6548 RVA: 0x000084FC File Offset: 0x000066FC
		public LeaderboardEntry()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaderboardEntry>.NativeClassPtr))
		{
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06001995 RID: 6549 RVA: 0x0007BBF8 File Offset: 0x00079DF8
		// (set) Token: 0x06001996 RID: 6550 RVA: 0x0000850E File Offset: 0x0000670E
		public unsafe Friend User
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardEntry.NativeFieldInfoPtr_User);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardEntry.NativeFieldInfoPtr_User)) = value;
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06001997 RID: 6551 RVA: 0x0007BC20 File Offset: 0x00079E20
		// (set) Token: 0x06001998 RID: 6552 RVA: 0x00008529 File Offset: 0x00006729
		public unsafe int GlobalRank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardEntry.NativeFieldInfoPtr_GlobalRank);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardEntry.NativeFieldInfoPtr_GlobalRank)) = value;
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06001999 RID: 6553 RVA: 0x0007BC48 File Offset: 0x00079E48
		// (set) Token: 0x0600199A RID: 6554 RVA: 0x00008544 File Offset: 0x00006744
		public unsafe int Score
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardEntry.NativeFieldInfoPtr_Score);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardEntry.NativeFieldInfoPtr_Score)) = value;
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x0600199B RID: 6555 RVA: 0x0007BC70 File Offset: 0x00079E70
		// (set) Token: 0x0600199C RID: 6556 RVA: 0x0000855F File Offset: 0x0000675F
		public unsafe Il2CppStructArray<int> Details
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardEntry.NativeFieldInfoPtr_Details);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardEntry.NativeFieldInfoPtr_Details), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001ECB RID: 7883
		private static readonly IntPtr NativeFieldInfoPtr_User;

		// Token: 0x04001ECC RID: 7884
		private static readonly IntPtr NativeFieldInfoPtr_GlobalRank;

		// Token: 0x04001ECD RID: 7885
		private static readonly IntPtr NativeFieldInfoPtr_Score;

		// Token: 0x04001ECE RID: 7886
		private static readonly IntPtr NativeFieldInfoPtr_Details;

		// Token: 0x04001ECF RID: 7887
		private static readonly IntPtr NativeMethodInfoPtr_From_Internal_Static_LeaderboardEntry_LeaderboardEntry_t_Il2CppStructArray_1_Int32_0;
	}
}
