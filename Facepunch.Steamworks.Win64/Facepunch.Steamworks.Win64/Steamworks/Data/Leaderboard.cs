using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;

namespace Steamworks.Data
{
	// Token: 0x02000200 RID: 512
	[StructLayout(2)]
	public struct Leaderboard
	{
		// Token: 0x0600197E RID: 6526 RVA: 0x0007B618 File Offset: 0x00079818
		// Note: this type is marked as 'beforefieldinit'.
		static Leaderboard()
		{
			Il2CppClassPointerStore<Leaderboard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "Leaderboard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Leaderboard>.NativeClassPtr);
			Leaderboard.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard>.NativeClassPtr, "Id");
			Leaderboard.NativeFieldInfoPtr_detailsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard>.NativeClassPtr, "detailsBuffer");
			Leaderboard.NativeFieldInfoPtr_noDetails = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard>.NativeClassPtr, "noDetails");
			Leaderboard.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Leaderboard>.NativeClassPtr, 100667931);
			Leaderboard.NativeMethodInfoPtr_get_Sort_Public_get_LeaderboardSort_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Leaderboard>.NativeClassPtr, 100667932);
			Leaderboard.NativeMethodInfoPtr_get_Display_Public_get_LeaderboardDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Leaderboard>.NativeClassPtr, 100667933);
			Leaderboard.NativeMethodInfoPtr_get_EntryCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Leaderboard>.NativeClassPtr, 100667934);
			Leaderboard.NativeMethodInfoPtr_ReplaceScore_Public_Task_1_Nullable_1_LeaderboardUpdate_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Leaderboard>.NativeClassPtr, 100667935);
			Leaderboard.NativeMethodInfoPtr_SubmitScoreAsync_Public_Task_1_Nullable_1_LeaderboardUpdate_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Leaderboard>.NativeClassPtr, 100667936);
			Leaderboard.NativeMethodInfoPtr_AttachUgc_Public_Task_1_Result_Ugc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Leaderboard>.NativeClassPtr, 100667937);
			Leaderboard.NativeMethodInfoPtr_GetScoresForUsersAsync_Public_Task_1_Il2CppReferenceArray_1_LeaderboardEntry_Il2CppStructArray_1_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Leaderboard>.NativeClassPtr, 100667938);
			Leaderboard.NativeMethodInfoPtr_GetScoresAsync_Public_Task_1_Il2CppReferenceArray_1_LeaderboardEntry_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Leaderboard>.NativeClassPtr, 100667939);
			Leaderboard.NativeMethodInfoPtr_GetScoresAroundUserAsync_Public_Task_1_Il2CppReferenceArray_1_LeaderboardEntry_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Leaderboard>.NativeClassPtr, 100667940);
			Leaderboard.NativeMethodInfoPtr_GetScoresFromFriendsAsync_Public_Task_1_Il2CppReferenceArray_1_LeaderboardEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Leaderboard>.NativeClassPtr, 100667941);
			Leaderboard.NativeMethodInfoPtr_LeaderboardResultToEntries_Internal_Task_1_Il2CppReferenceArray_1_LeaderboardEntry_LeaderboardScoresDownloaded_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Leaderboard>.NativeClassPtr, 100667942);
			Leaderboard.NativeMethodInfoPtr_WaitForUserNames_Internal_Static_Task_Il2CppReferenceArray_1_LeaderboardEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Leaderboard>.NativeClassPtr, 100667943);
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x0600197F RID: 6527 RVA: 0x0007B788 File Offset: 0x00079988
		public unsafe string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952254, XrefRangeEnd = 952257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Leaderboard.NativeMethodInfoPtr_get_Name_Public_get_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06001980 RID: 6528 RVA: 0x0007B7B4 File Offset: 0x000799B4
		public unsafe LeaderboardSort Sort
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952257, XrefRangeEnd = 952260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Leaderboard.NativeMethodInfoPtr_get_Sort_Public_get_LeaderboardSort_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06001981 RID: 6529 RVA: 0x0007B7E4 File Offset: 0x000799E4
		public unsafe LeaderboardDisplay Display
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952260, XrefRangeEnd = 952263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Leaderboard.NativeMethodInfoPtr_get_Display_Public_get_LeaderboardDisplay_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06001982 RID: 6530 RVA: 0x0007B814 File Offset: 0x00079A14
		public unsafe int EntryCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952263, XrefRangeEnd = 952266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Leaderboard.NativeMethodInfoPtr_get_EntryCount_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001983 RID: 6531 RVA: 0x0007B844 File Offset: 0x00079A44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952266, XrefRangeEnd = 952280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Nullable<LeaderboardUpdate>> ReplaceScore(int score, Il2CppStructArray<int> details = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref score;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(details);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Leaderboard.NativeMethodInfoPtr_ReplaceScore_Public_Task_1_Nullable_1_LeaderboardUpdate_Int32_Il2CppStructArray_1_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<LeaderboardUpdate>>>(intPtr3) : null;
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x0007B898 File Offset: 0x00079A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952280, XrefRangeEnd = 952294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Nullable<LeaderboardUpdate>> SubmitScoreAsync(int score, Il2CppStructArray<int> details = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref score;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(details);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Leaderboard.NativeMethodInfoPtr_SubmitScoreAsync_Public_Task_1_Nullable_1_LeaderboardUpdate_Int32_Il2CppStructArray_1_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<LeaderboardUpdate>>>(intPtr3) : null;
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x0007B8EC File Offset: 0x00079AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952294, XrefRangeEnd = 952307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Result> AttachUgc(Ugc file)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref file;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Leaderboard.NativeMethodInfoPtr_AttachUgc_Public_Task_1_Result_Ugc_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Result>>(intPtr3) : null;
			}
		}

		// Token: 0x06001986 RID: 6534 RVA: 0x0007B92C File Offset: 0x00079B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952307, XrefRangeEnd = 952321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Il2CppReferenceArray<LeaderboardEntry>> GetScoresForUsersAsync(Il2CppStructArray<SteamId> users)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(users);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Leaderboard.NativeMethodInfoPtr_GetScoresForUsersAsync_Public_Task_1_Il2CppReferenceArray_1_LeaderboardEntry_Il2CppStructArray_1_SteamId_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Il2CppReferenceArray<LeaderboardEntry>>>(intPtr3) : null;
			}
		}

		// Token: 0x06001987 RID: 6535 RVA: 0x0007B970 File Offset: 0x00079B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952321, XrefRangeEnd = 952334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Il2CppReferenceArray<LeaderboardEntry>> GetScoresAsync(int count, int offset = 1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Leaderboard.NativeMethodInfoPtr_GetScoresAsync_Public_Task_1_Il2CppReferenceArray_1_LeaderboardEntry_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Il2CppReferenceArray<LeaderboardEntry>>>(intPtr3) : null;
		}

		// Token: 0x06001988 RID: 6536 RVA: 0x0007B9C0 File Offset: 0x00079BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952334, XrefRangeEnd = 952347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Il2CppReferenceArray<LeaderboardEntry>> GetScoresAroundUserAsync(int start = -10, int end = 10)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Leaderboard.NativeMethodInfoPtr_GetScoresAroundUserAsync_Public_Task_1_Il2CppReferenceArray_1_LeaderboardEntry_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Il2CppReferenceArray<LeaderboardEntry>>>(intPtr3) : null;
		}

		// Token: 0x06001989 RID: 6537 RVA: 0x0007BA10 File Offset: 0x00079C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952347, XrefRangeEnd = 952360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Il2CppReferenceArray<LeaderboardEntry>> GetScoresFromFriendsAsync()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Leaderboard.NativeMethodInfoPtr_GetScoresFromFriendsAsync_Public_Task_1_Il2CppReferenceArray_1_LeaderboardEntry_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Il2CppReferenceArray<LeaderboardEntry>>>(intPtr3) : null;
		}

		// Token: 0x0600198A RID: 6538 RVA: 0x0007BA44 File Offset: 0x00079C44
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 952373, RefRangeEnd = 952377, XrefRangeStart = 952360, XrefRangeEnd = 952373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Il2CppReferenceArray<LeaderboardEntry>> LeaderboardResultToEntries(LeaderboardScoresDownloaded_t r)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref r;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Leaderboard.NativeMethodInfoPtr_LeaderboardResultToEntries_Internal_Task_1_Il2CppReferenceArray_1_LeaderboardEntry_LeaderboardScoresDownloaded_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Il2CppReferenceArray<LeaderboardEntry>>>(intPtr3) : null;
			}
		}

		// Token: 0x0600198B RID: 6539 RVA: 0x0007BA84 File Offset: 0x00079C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952377, XrefRangeEnd = 952387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task WaitForUserNames(Il2CppReferenceArray<LeaderboardEntry> entries)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entries);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Leaderboard.NativeMethodInfoPtr_WaitForUserNames_Internal_Static_Task_Il2CppReferenceArray_1_LeaderboardEntry_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x0600198C RID: 6540 RVA: 0x000084BD File Offset: 0x000066BD
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Leaderboard>.NativeClassPtr, ref this));
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x0600198D RID: 6541 RVA: 0x0007BAC8 File Offset: 0x00079CC8
		// (set) Token: 0x0600198E RID: 6542 RVA: 0x000084CF File Offset: 0x000066CF
		public unsafe static Il2CppStructArray<int> detailsBuffer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Leaderboard.NativeFieldInfoPtr_detailsBuffer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Leaderboard.NativeFieldInfoPtr_detailsBuffer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x0600198F RID: 6543 RVA: 0x0007BAF0 File Offset: 0x00079CF0
		// (set) Token: 0x06001990 RID: 6544 RVA: 0x000084E1 File Offset: 0x000066E1
		public unsafe static Il2CppStructArray<int> noDetails
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Leaderboard.NativeFieldInfoPtr_noDetails, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Leaderboard.NativeFieldInfoPtr_noDetails, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001EBA RID: 7866
		private static readonly IntPtr NativeFieldInfoPtr_Id;

		// Token: 0x04001EBB RID: 7867
		private static readonly IntPtr NativeFieldInfoPtr_detailsBuffer;

		// Token: 0x04001EBC RID: 7868
		private static readonly IntPtr NativeFieldInfoPtr_noDetails;

		// Token: 0x04001EBD RID: 7869
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04001EBE RID: 7870
		private static readonly IntPtr NativeMethodInfoPtr_get_Sort_Public_get_LeaderboardSort_0;

		// Token: 0x04001EBF RID: 7871
		private static readonly IntPtr NativeMethodInfoPtr_get_Display_Public_get_LeaderboardDisplay_0;

		// Token: 0x04001EC0 RID: 7872
		private static readonly IntPtr NativeMethodInfoPtr_get_EntryCount_Public_get_Int32_0;

		// Token: 0x04001EC1 RID: 7873
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceScore_Public_Task_1_Nullable_1_LeaderboardUpdate_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x04001EC2 RID: 7874
		private static readonly IntPtr NativeMethodInfoPtr_SubmitScoreAsync_Public_Task_1_Nullable_1_LeaderboardUpdate_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x04001EC3 RID: 7875
		private static readonly IntPtr NativeMethodInfoPtr_AttachUgc_Public_Task_1_Result_Ugc_0;

		// Token: 0x04001EC4 RID: 7876
		private static readonly IntPtr NativeMethodInfoPtr_GetScoresForUsersAsync_Public_Task_1_Il2CppReferenceArray_1_LeaderboardEntry_Il2CppStructArray_1_SteamId_0;

		// Token: 0x04001EC5 RID: 7877
		private static readonly IntPtr NativeMethodInfoPtr_GetScoresAsync_Public_Task_1_Il2CppReferenceArray_1_LeaderboardEntry_Int32_Int32_0;

		// Token: 0x04001EC6 RID: 7878
		private static readonly IntPtr NativeMethodInfoPtr_GetScoresAroundUserAsync_Public_Task_1_Il2CppReferenceArray_1_LeaderboardEntry_Int32_Int32_0;

		// Token: 0x04001EC7 RID: 7879
		private static readonly IntPtr NativeMethodInfoPtr_GetScoresFromFriendsAsync_Public_Task_1_Il2CppReferenceArray_1_LeaderboardEntry_0;

		// Token: 0x04001EC8 RID: 7880
		private static readonly IntPtr NativeMethodInfoPtr_LeaderboardResultToEntries_Internal_Task_1_Il2CppReferenceArray_1_LeaderboardEntry_LeaderboardScoresDownloaded_t_0;

		// Token: 0x04001EC9 RID: 7881
		private static readonly IntPtr NativeMethodInfoPtr_WaitForUserNames_Internal_Static_Task_Il2CppReferenceArray_1_LeaderboardEntry_0;

		// Token: 0x04001ECA RID: 7882
		[FieldOffset(0)]
		public SteamLeaderboard_t Id;

		// Token: 0x020002A2 RID: 674
		[ObfuscatedName("Steamworks.Data.Leaderboard+<AttachUgc>d__13")]
		public sealed class _AttachUgc_d__13 : ValueType
		{
			// Token: 0x0600221A RID: 8730 RVA: 0x00092DB0 File Offset: 0x00090FB0
			// Note: this type is marked as 'beforefieldinit'.
			static _AttachUgc_d__13()
			{
				Il2CppClassPointerStore<Leaderboard._AttachUgc_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Leaderboard>.NativeClassPtr, "<AttachUgc>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Leaderboard._AttachUgc_d__13>.NativeClassPtr);
				Leaderboard._AttachUgc_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._AttachUgc_d__13>.NativeClassPtr, "<>1__state");
				Leaderboard._AttachUgc_d__13.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._AttachUgc_d__13>.NativeClassPtr, "<>t__builder");
				Leaderboard._AttachUgc_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._AttachUgc_d__13>.NativeClassPtr, "<>4__this");
				Leaderboard._AttachUgc_d__13.NativeFieldInfoPtr_file = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._AttachUgc_d__13>.NativeClassPtr, "file");
				Leaderboard._AttachUgc_d__13.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._AttachUgc_d__13>.NativeClassPtr, "<>u__1");
				Leaderboard._AttachUgc_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Leaderboard._AttachUgc_d__13>.NativeClassPtr, 100667945);
				Leaderboard._AttachUgc_d__13.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Leaderboard._AttachUgc_d__13>.NativeClassPtr, 100667946);
			}

			// Token: 0x0600221B RID: 8731 RVA: 0x00092E68 File Offset: 0x00091068
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951856, XrefRangeEnd = 951880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Leaderboard._AttachUgc_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600221C RID: 8732 RVA: 0x00092EA0 File Offset: 0x000910A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951880, XrefRangeEnd = 951886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Leaderboard._AttachUgc_d__13.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600221D RID: 8733 RVA: 0x0000DC6E File Offset: 0x0000BE6E
			public _AttachUgc_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600221E RID: 8734 RVA: 0x0000DC77 File Offset: 0x0000BE77
			public _AttachUgc_d__13()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Leaderboard._AttachUgc_d__13>.NativeClassPtr))
			{
			}

			// Token: 0x170008E7 RID: 2279
			// (get) Token: 0x0600221F RID: 8735 RVA: 0x00092EE8 File Offset: 0x000910E8
			// (set) Token: 0x06002220 RID: 8736 RVA: 0x0000DC89 File Offset: 0x0000BE89
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._AttachUgc_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._AttachUgc_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008E8 RID: 2280
			// (get) Token: 0x06002221 RID: 8737 RVA: 0x00092F10 File Offset: 0x00091110
			// (set) Token: 0x06002222 RID: 8738 RVA: 0x0000DCA4 File Offset: 0x0000BEA4
			public AsyncTaskMethodBuilder<Result> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._AttachUgc_d__13.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Result>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Result>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._AttachUgc_d__13.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Result>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008E9 RID: 2281
			// (get) Token: 0x06002223 RID: 8739 RVA: 0x00092F40 File Offset: 0x00091140
			// (set) Token: 0x06002224 RID: 8740 RVA: 0x0000DCD2 File Offset: 0x0000BED2
			public unsafe Leaderboard __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._AttachUgc_d__13.NativeFieldInfoPtr___4__this);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._AttachUgc_d__13.NativeFieldInfoPtr___4__this)) = value;
				}
			}

			// Token: 0x170008EA RID: 2282
			// (get) Token: 0x06002225 RID: 8741 RVA: 0x00092F68 File Offset: 0x00091168
			// (set) Token: 0x06002226 RID: 8742 RVA: 0x0000DCED File Offset: 0x0000BEED
			public unsafe Ugc file
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._AttachUgc_d__13.NativeFieldInfoPtr_file);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._AttachUgc_d__13.NativeFieldInfoPtr_file)) = value;
				}
			}

			// Token: 0x170008EB RID: 2283
			// (get) Token: 0x06002227 RID: 8743 RVA: 0x00092F90 File Offset: 0x00091190
			// (set) Token: 0x06002228 RID: 8744 RVA: 0x0000DD08 File Offset: 0x0000BF08
			public CallResult<LeaderboardUGCSet_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._AttachUgc_d__13.NativeFieldInfoPtr___u__1);
					return new CallResult<LeaderboardUGCSet_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<LeaderboardUGCSet_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._AttachUgc_d__13.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<LeaderboardUGCSet_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040023B6 RID: 9142
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040023B7 RID: 9143
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040023B8 RID: 9144
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040023B9 RID: 9145
			private static readonly IntPtr NativeFieldInfoPtr_file;

			// Token: 0x040023BA RID: 9146
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040023BB RID: 9147
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040023BC RID: 9148
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020002A3 RID: 675
		[ObfuscatedName("Steamworks.Data.Leaderboard+<GetScoresAroundUserAsync>d__16")]
		public sealed class _GetScoresAroundUserAsync_d__16 : ValueType
		{
			// Token: 0x06002229 RID: 8745 RVA: 0x00092FC0 File Offset: 0x000911C0
			// Note: this type is marked as 'beforefieldinit'.
			static _GetScoresAroundUserAsync_d__16()
			{
				Il2CppClassPointerStore<Leaderboard._GetScoresAroundUserAsync_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Leaderboard>.NativeClassPtr, "<GetScoresAroundUserAsync>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Leaderboard._GetScoresAroundUserAsync_d__16>.NativeClassPtr);
				Leaderboard._GetScoresAroundUserAsync_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._GetScoresAroundUserAsync_d__16>.NativeClassPtr, "<>1__state");
				Leaderboard._GetScoresAroundUserAsync_d__16.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._GetScoresAroundUserAsync_d__16>.NativeClassPtr, "<>t__builder");
				Leaderboard._GetScoresAroundUserAsync_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._GetScoresAroundUserAsync_d__16>.NativeClassPtr, "<>4__this");
				Leaderboard._GetScoresAroundUserAsync_d__16.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._GetScoresAroundUserAsync_d__16>.NativeClassPtr, "start");
				Leaderboard._GetScoresAroundUserAsync_d__16.NativeFieldInfoPtr_end = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._GetScoresAroundUserAsync_d__16>.NativeClassPtr, "end");
				Leaderboard._GetScoresAroundUserAsync_d__16.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._GetScoresAroundUserAsync_d__16>.NativeClassPtr, "<>u__1");
				Leaderboard._GetScoresAroundUserAsync_d__16.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._GetScoresAroundUserAsync_d__16>.NativeClassPtr, "<>u__2");
				Leaderboard._GetScoresAroundUserAsync_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Leaderboard._GetScoresAroundUserAsync_d__16>.NativeClassPtr, 100667947);
				Leaderboard._GetScoresAroundUserAsync_d__16.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Leaderboard._GetScoresAroundUserAsync_d__16>.NativeClassPtr, 100667948);
			}

			// Token: 0x0600222A RID: 8746 RVA: 0x000930A0 File Offset: 0x000912A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951886, XrefRangeEnd = 951931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Leaderboard._GetScoresAroundUserAsync_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600222B RID: 8747 RVA: 0x000930D8 File Offset: 0x000912D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951931, XrefRangeEnd = 951937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Leaderboard._GetScoresAroundUserAsync_d__16.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600222C RID: 8748 RVA: 0x0000DD36 File Offset: 0x0000BF36
			public _GetScoresAroundUserAsync_d__16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600222D RID: 8749 RVA: 0x0000DD3F File Offset: 0x0000BF3F
			public _GetScoresAroundUserAsync_d__16()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Leaderboard._GetScoresAroundUserAsync_d__16>.NativeClassPtr))
			{
			}

			// Token: 0x170008EC RID: 2284
			// (get) Token: 0x0600222E RID: 8750 RVA: 0x00093120 File Offset: 0x00091320
			// (set) Token: 0x0600222F RID: 8751 RVA: 0x0000DD51 File Offset: 0x0000BF51
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresAroundUserAsync_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresAroundUserAsync_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008ED RID: 2285
			// (get) Token: 0x06002230 RID: 8752 RVA: 0x00093148 File Offset: 0x00091348
			// (set) Token: 0x06002231 RID: 8753 RVA: 0x0000DD6C File Offset: 0x0000BF6C
			public AsyncTaskMethodBuilder<Il2CppReferenceArray<LeaderboardEntry>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresAroundUserAsync_d__16.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Il2CppReferenceArray<LeaderboardEntry>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppReferenceArray<LeaderboardEntry>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresAroundUserAsync_d__16.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppReferenceArray<LeaderboardEntry>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008EE RID: 2286
			// (get) Token: 0x06002232 RID: 8754 RVA: 0x00093178 File Offset: 0x00091378
			// (set) Token: 0x06002233 RID: 8755 RVA: 0x0000DD9A File Offset: 0x0000BF9A
			public unsafe Leaderboard __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresAroundUserAsync_d__16.NativeFieldInfoPtr___4__this);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresAroundUserAsync_d__16.NativeFieldInfoPtr___4__this)) = value;
				}
			}

			// Token: 0x170008EF RID: 2287
			// (get) Token: 0x06002234 RID: 8756 RVA: 0x000931A0 File Offset: 0x000913A0
			// (set) Token: 0x06002235 RID: 8757 RVA: 0x0000DDB5 File Offset: 0x0000BFB5
			public unsafe int start
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresAroundUserAsync_d__16.NativeFieldInfoPtr_start);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresAroundUserAsync_d__16.NativeFieldInfoPtr_start)) = value;
				}
			}

			// Token: 0x170008F0 RID: 2288
			// (get) Token: 0x06002236 RID: 8758 RVA: 0x000931C8 File Offset: 0x000913C8
			// (set) Token: 0x06002237 RID: 8759 RVA: 0x0000DDD0 File Offset: 0x0000BFD0
			public unsafe int end
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresAroundUserAsync_d__16.NativeFieldInfoPtr_end);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresAroundUserAsync_d__16.NativeFieldInfoPtr_end)) = value;
				}
			}

			// Token: 0x170008F1 RID: 2289
			// (get) Token: 0x06002238 RID: 8760 RVA: 0x000931F0 File Offset: 0x000913F0
			// (set) Token: 0x06002239 RID: 8761 RVA: 0x0000DDEB File Offset: 0x0000BFEB
			public CallResult<LeaderboardScoresDownloaded_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresAroundUserAsync_d__16.NativeFieldInfoPtr___u__1);
					return new CallResult<LeaderboardScoresDownloaded_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<LeaderboardScoresDownloaded_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresAroundUserAsync_d__16.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<LeaderboardScoresDownloaded_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008F2 RID: 2290
			// (get) Token: 0x0600223A RID: 8762 RVA: 0x00093220 File Offset: 0x00091420
			// (set) Token: 0x0600223B RID: 8763 RVA: 0x0000DE19 File Offset: 0x0000C019
			public TaskAwaiter<Il2CppReferenceArray<LeaderboardEntry>> __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresAroundUserAsync_d__16.NativeFieldInfoPtr___u__2);
					return new TaskAwaiter<Il2CppReferenceArray<LeaderboardEntry>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Il2CppReferenceArray<LeaderboardEntry>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresAroundUserAsync_d__16.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Il2CppReferenceArray<LeaderboardEntry>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040023BD RID: 9149
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040023BE RID: 9150
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040023BF RID: 9151
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040023C0 RID: 9152
			private static readonly IntPtr NativeFieldInfoPtr_start;

			// Token: 0x040023C1 RID: 9153
			private static readonly IntPtr NativeFieldInfoPtr_end;

			// Token: 0x040023C2 RID: 9154
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040023C3 RID: 9155
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040023C4 RID: 9156
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040023C5 RID: 9157
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020002A4 RID: 676
		[ObfuscatedName("Steamworks.Data.Leaderboard+<GetScoresAsync>d__15")]
		public sealed class _GetScoresAsync_d__15 : ValueType
		{
			// Token: 0x0600223C RID: 8764 RVA: 0x00093250 File Offset: 0x00091450
			// Note: this type is marked as 'beforefieldinit'.
			static _GetScoresAsync_d__15()
			{
				Il2CppClassPointerStore<Leaderboard._GetScoresAsync_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Leaderboard>.NativeClassPtr, "<GetScoresAsync>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Leaderboard._GetScoresAsync_d__15>.NativeClassPtr);
				Leaderboard._GetScoresAsync_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._GetScoresAsync_d__15>.NativeClassPtr, "<>1__state");
				Leaderboard._GetScoresAsync_d__15.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._GetScoresAsync_d__15>.NativeClassPtr, "<>t__builder");
				Leaderboard._GetScoresAsync_d__15.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._GetScoresAsync_d__15>.NativeClassPtr, "offset");
				Leaderboard._GetScoresAsync_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._GetScoresAsync_d__15>.NativeClassPtr, "<>4__this");
				Leaderboard._GetScoresAsync_d__15.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._GetScoresAsync_d__15>.NativeClassPtr, "count");
				Leaderboard._GetScoresAsync_d__15.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._GetScoresAsync_d__15>.NativeClassPtr, "<>u__1");
				Leaderboard._GetScoresAsync_d__15.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._GetScoresAsync_d__15>.NativeClassPtr, "<>u__2");
				Leaderboard._GetScoresAsync_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Leaderboard._GetScoresAsync_d__15>.NativeClassPtr, 100667949);
				Leaderboard._GetScoresAsync_d__15.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Leaderboard._GetScoresAsync_d__15>.NativeClassPtr, 100667950);
			}

			// Token: 0x0600223D RID: 8765 RVA: 0x00093330 File Offset: 0x00091530
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951937, XrefRangeEnd = 951982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Leaderboard._GetScoresAsync_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600223E RID: 8766 RVA: 0x00093368 File Offset: 0x00091568
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951982, XrefRangeEnd = 951988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Leaderboard._GetScoresAsync_d__15.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600223F RID: 8767 RVA: 0x0000DE47 File Offset: 0x0000C047
			public _GetScoresAsync_d__15(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002240 RID: 8768 RVA: 0x0000DE50 File Offset: 0x0000C050
			public _GetScoresAsync_d__15()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Leaderboard._GetScoresAsync_d__15>.NativeClassPtr))
			{
			}

			// Token: 0x170008F3 RID: 2291
			// (get) Token: 0x06002241 RID: 8769 RVA: 0x000933B0 File Offset: 0x000915B0
			// (set) Token: 0x06002242 RID: 8770 RVA: 0x0000DE62 File Offset: 0x0000C062
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresAsync_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresAsync_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008F4 RID: 2292
			// (get) Token: 0x06002243 RID: 8771 RVA: 0x000933D8 File Offset: 0x000915D8
			// (set) Token: 0x06002244 RID: 8772 RVA: 0x0000DE7D File Offset: 0x0000C07D
			public AsyncTaskMethodBuilder<Il2CppReferenceArray<LeaderboardEntry>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresAsync_d__15.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Il2CppReferenceArray<LeaderboardEntry>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppReferenceArray<LeaderboardEntry>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresAsync_d__15.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppReferenceArray<LeaderboardEntry>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008F5 RID: 2293
			// (get) Token: 0x06002245 RID: 8773 RVA: 0x00093408 File Offset: 0x00091608
			// (set) Token: 0x06002246 RID: 8774 RVA: 0x0000DEAB File Offset: 0x0000C0AB
			public unsafe int offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresAsync_d__15.NativeFieldInfoPtr_offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresAsync_d__15.NativeFieldInfoPtr_offset)) = value;
				}
			}

			// Token: 0x170008F6 RID: 2294
			// (get) Token: 0x06002247 RID: 8775 RVA: 0x00093430 File Offset: 0x00091630
			// (set) Token: 0x06002248 RID: 8776 RVA: 0x0000DEC6 File Offset: 0x0000C0C6
			public unsafe Leaderboard __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresAsync_d__15.NativeFieldInfoPtr___4__this);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresAsync_d__15.NativeFieldInfoPtr___4__this)) = value;
				}
			}

			// Token: 0x170008F7 RID: 2295
			// (get) Token: 0x06002249 RID: 8777 RVA: 0x00093458 File Offset: 0x00091658
			// (set) Token: 0x0600224A RID: 8778 RVA: 0x0000DEE1 File Offset: 0x0000C0E1
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresAsync_d__15.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresAsync_d__15.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x170008F8 RID: 2296
			// (get) Token: 0x0600224B RID: 8779 RVA: 0x00093480 File Offset: 0x00091680
			// (set) Token: 0x0600224C RID: 8780 RVA: 0x0000DEFC File Offset: 0x0000C0FC
			public CallResult<LeaderboardScoresDownloaded_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresAsync_d__15.NativeFieldInfoPtr___u__1);
					return new CallResult<LeaderboardScoresDownloaded_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<LeaderboardScoresDownloaded_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresAsync_d__15.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<LeaderboardScoresDownloaded_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008F9 RID: 2297
			// (get) Token: 0x0600224D RID: 8781 RVA: 0x000934B0 File Offset: 0x000916B0
			// (set) Token: 0x0600224E RID: 8782 RVA: 0x0000DF2A File Offset: 0x0000C12A
			public TaskAwaiter<Il2CppReferenceArray<LeaderboardEntry>> __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresAsync_d__15.NativeFieldInfoPtr___u__2);
					return new TaskAwaiter<Il2CppReferenceArray<LeaderboardEntry>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Il2CppReferenceArray<LeaderboardEntry>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresAsync_d__15.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Il2CppReferenceArray<LeaderboardEntry>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040023C6 RID: 9158
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040023C7 RID: 9159
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040023C8 RID: 9160
			private static readonly IntPtr NativeFieldInfoPtr_offset;

			// Token: 0x040023C9 RID: 9161
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040023CA RID: 9162
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x040023CB RID: 9163
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040023CC RID: 9164
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040023CD RID: 9165
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040023CE RID: 9166
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020002A5 RID: 677
		[ObfuscatedName("Steamworks.Data.Leaderboard+<GetScoresForUsersAsync>d__14")]
		public sealed class _GetScoresForUsersAsync_d__14 : ValueType
		{
			// Token: 0x0600224F RID: 8783 RVA: 0x000934E0 File Offset: 0x000916E0
			// Note: this type is marked as 'beforefieldinit'.
			static _GetScoresForUsersAsync_d__14()
			{
				Il2CppClassPointerStore<Leaderboard._GetScoresForUsersAsync_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Leaderboard>.NativeClassPtr, "<GetScoresForUsersAsync>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Leaderboard._GetScoresForUsersAsync_d__14>.NativeClassPtr);
				Leaderboard._GetScoresForUsersAsync_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._GetScoresForUsersAsync_d__14>.NativeClassPtr, "<>1__state");
				Leaderboard._GetScoresForUsersAsync_d__14.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._GetScoresForUsersAsync_d__14>.NativeClassPtr, "<>t__builder");
				Leaderboard._GetScoresForUsersAsync_d__14.NativeFieldInfoPtr_users = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._GetScoresForUsersAsync_d__14>.NativeClassPtr, "users");
				Leaderboard._GetScoresForUsersAsync_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._GetScoresForUsersAsync_d__14>.NativeClassPtr, "<>4__this");
				Leaderboard._GetScoresForUsersAsync_d__14.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._GetScoresForUsersAsync_d__14>.NativeClassPtr, "<>u__1");
				Leaderboard._GetScoresForUsersAsync_d__14.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._GetScoresForUsersAsync_d__14>.NativeClassPtr, "<>u__2");
				Leaderboard._GetScoresForUsersAsync_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Leaderboard._GetScoresForUsersAsync_d__14>.NativeClassPtr, 100667951);
				Leaderboard._GetScoresForUsersAsync_d__14.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Leaderboard._GetScoresForUsersAsync_d__14>.NativeClassPtr, 100667952);
			}

			// Token: 0x06002250 RID: 8784 RVA: 0x000935AC File Offset: 0x000917AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951988, XrefRangeEnd = 952040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Leaderboard._GetScoresForUsersAsync_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002251 RID: 8785 RVA: 0x000935E4 File Offset: 0x000917E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952040, XrefRangeEnd = 952046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Leaderboard._GetScoresForUsersAsync_d__14.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002252 RID: 8786 RVA: 0x0000DF58 File Offset: 0x0000C158
			public _GetScoresForUsersAsync_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002253 RID: 8787 RVA: 0x0000DF61 File Offset: 0x0000C161
			public _GetScoresForUsersAsync_d__14()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Leaderboard._GetScoresForUsersAsync_d__14>.NativeClassPtr))
			{
			}

			// Token: 0x170008FA RID: 2298
			// (get) Token: 0x06002254 RID: 8788 RVA: 0x0009362C File Offset: 0x0009182C
			// (set) Token: 0x06002255 RID: 8789 RVA: 0x0000DF73 File Offset: 0x0000C173
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresForUsersAsync_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresForUsersAsync_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008FB RID: 2299
			// (get) Token: 0x06002256 RID: 8790 RVA: 0x00093654 File Offset: 0x00091854
			// (set) Token: 0x06002257 RID: 8791 RVA: 0x0000DF8E File Offset: 0x0000C18E
			public AsyncTaskMethodBuilder<Il2CppReferenceArray<LeaderboardEntry>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresForUsersAsync_d__14.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Il2CppReferenceArray<LeaderboardEntry>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppReferenceArray<LeaderboardEntry>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresForUsersAsync_d__14.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppReferenceArray<LeaderboardEntry>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008FC RID: 2300
			// (get) Token: 0x06002258 RID: 8792 RVA: 0x00093684 File Offset: 0x00091884
			// (set) Token: 0x06002259 RID: 8793 RVA: 0x0000DFBC File Offset: 0x0000C1BC
			public unsafe Il2CppStructArray<SteamId> users
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresForUsersAsync_d__14.NativeFieldInfoPtr_users);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<SteamId>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresForUsersAsync_d__14.NativeFieldInfoPtr_users), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008FD RID: 2301
			// (get) Token: 0x0600225A RID: 8794 RVA: 0x000936B4 File Offset: 0x000918B4
			// (set) Token: 0x0600225B RID: 8795 RVA: 0x0000DFDB File Offset: 0x0000C1DB
			public unsafe Leaderboard __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresForUsersAsync_d__14.NativeFieldInfoPtr___4__this);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresForUsersAsync_d__14.NativeFieldInfoPtr___4__this)) = value;
				}
			}

			// Token: 0x170008FE RID: 2302
			// (get) Token: 0x0600225C RID: 8796 RVA: 0x000936DC File Offset: 0x000918DC
			// (set) Token: 0x0600225D RID: 8797 RVA: 0x0000DFF6 File Offset: 0x0000C1F6
			public CallResult<LeaderboardScoresDownloaded_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresForUsersAsync_d__14.NativeFieldInfoPtr___u__1);
					return new CallResult<LeaderboardScoresDownloaded_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<LeaderboardScoresDownloaded_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresForUsersAsync_d__14.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<LeaderboardScoresDownloaded_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008FF RID: 2303
			// (get) Token: 0x0600225E RID: 8798 RVA: 0x0009370C File Offset: 0x0009190C
			// (set) Token: 0x0600225F RID: 8799 RVA: 0x0000E024 File Offset: 0x0000C224
			public TaskAwaiter<Il2CppReferenceArray<LeaderboardEntry>> __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresForUsersAsync_d__14.NativeFieldInfoPtr___u__2);
					return new TaskAwaiter<Il2CppReferenceArray<LeaderboardEntry>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Il2CppReferenceArray<LeaderboardEntry>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresForUsersAsync_d__14.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Il2CppReferenceArray<LeaderboardEntry>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040023CF RID: 9167
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040023D0 RID: 9168
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040023D1 RID: 9169
			private static readonly IntPtr NativeFieldInfoPtr_users;

			// Token: 0x040023D2 RID: 9170
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040023D3 RID: 9171
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040023D4 RID: 9172
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040023D5 RID: 9173
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040023D6 RID: 9174
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020002A6 RID: 678
		[ObfuscatedName("Steamworks.Data.Leaderboard+<GetScoresFromFriendsAsync>d__17")]
		public sealed class _GetScoresFromFriendsAsync_d__17 : ValueType
		{
			// Token: 0x06002260 RID: 8800 RVA: 0x0009373C File Offset: 0x0009193C
			// Note: this type is marked as 'beforefieldinit'.
			static _GetScoresFromFriendsAsync_d__17()
			{
				Il2CppClassPointerStore<Leaderboard._GetScoresFromFriendsAsync_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Leaderboard>.NativeClassPtr, "<GetScoresFromFriendsAsync>d__17");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Leaderboard._GetScoresFromFriendsAsync_d__17>.NativeClassPtr);
				Leaderboard._GetScoresFromFriendsAsync_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._GetScoresFromFriendsAsync_d__17>.NativeClassPtr, "<>1__state");
				Leaderboard._GetScoresFromFriendsAsync_d__17.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._GetScoresFromFriendsAsync_d__17>.NativeClassPtr, "<>t__builder");
				Leaderboard._GetScoresFromFriendsAsync_d__17.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._GetScoresFromFriendsAsync_d__17>.NativeClassPtr, "<>4__this");
				Leaderboard._GetScoresFromFriendsAsync_d__17.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._GetScoresFromFriendsAsync_d__17>.NativeClassPtr, "<>u__1");
				Leaderboard._GetScoresFromFriendsAsync_d__17.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._GetScoresFromFriendsAsync_d__17>.NativeClassPtr, "<>u__2");
				Leaderboard._GetScoresFromFriendsAsync_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Leaderboard._GetScoresFromFriendsAsync_d__17>.NativeClassPtr, 100667953);
				Leaderboard._GetScoresFromFriendsAsync_d__17.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Leaderboard._GetScoresFromFriendsAsync_d__17>.NativeClassPtr, 100667954);
			}

			// Token: 0x06002261 RID: 8801 RVA: 0x000937F4 File Offset: 0x000919F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952046, XrefRangeEnd = 952091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Leaderboard._GetScoresFromFriendsAsync_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002262 RID: 8802 RVA: 0x0009382C File Offset: 0x00091A2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952091, XrefRangeEnd = 952097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Leaderboard._GetScoresFromFriendsAsync_d__17.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002263 RID: 8803 RVA: 0x0000E052 File Offset: 0x0000C252
			public _GetScoresFromFriendsAsync_d__17(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002264 RID: 8804 RVA: 0x0000E05B File Offset: 0x0000C25B
			public _GetScoresFromFriendsAsync_d__17()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Leaderboard._GetScoresFromFriendsAsync_d__17>.NativeClassPtr))
			{
			}

			// Token: 0x17000900 RID: 2304
			// (get) Token: 0x06002265 RID: 8805 RVA: 0x00093874 File Offset: 0x00091A74
			// (set) Token: 0x06002266 RID: 8806 RVA: 0x0000E06D File Offset: 0x0000C26D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresFromFriendsAsync_d__17.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresFromFriendsAsync_d__17.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000901 RID: 2305
			// (get) Token: 0x06002267 RID: 8807 RVA: 0x0009389C File Offset: 0x00091A9C
			// (set) Token: 0x06002268 RID: 8808 RVA: 0x0000E088 File Offset: 0x0000C288
			public AsyncTaskMethodBuilder<Il2CppReferenceArray<LeaderboardEntry>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresFromFriendsAsync_d__17.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Il2CppReferenceArray<LeaderboardEntry>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppReferenceArray<LeaderboardEntry>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresFromFriendsAsync_d__17.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppReferenceArray<LeaderboardEntry>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000902 RID: 2306
			// (get) Token: 0x06002269 RID: 8809 RVA: 0x000938CC File Offset: 0x00091ACC
			// (set) Token: 0x0600226A RID: 8810 RVA: 0x0000E0B6 File Offset: 0x0000C2B6
			public unsafe Leaderboard __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresFromFriendsAsync_d__17.NativeFieldInfoPtr___4__this);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresFromFriendsAsync_d__17.NativeFieldInfoPtr___4__this)) = value;
				}
			}

			// Token: 0x17000903 RID: 2307
			// (get) Token: 0x0600226B RID: 8811 RVA: 0x000938F4 File Offset: 0x00091AF4
			// (set) Token: 0x0600226C RID: 8812 RVA: 0x0000E0D1 File Offset: 0x0000C2D1
			public CallResult<LeaderboardScoresDownloaded_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresFromFriendsAsync_d__17.NativeFieldInfoPtr___u__1);
					return new CallResult<LeaderboardScoresDownloaded_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<LeaderboardScoresDownloaded_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresFromFriendsAsync_d__17.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<LeaderboardScoresDownloaded_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000904 RID: 2308
			// (get) Token: 0x0600226D RID: 8813 RVA: 0x00093924 File Offset: 0x00091B24
			// (set) Token: 0x0600226E RID: 8814 RVA: 0x0000E0FF File Offset: 0x0000C2FF
			public TaskAwaiter<Il2CppReferenceArray<LeaderboardEntry>> __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresFromFriendsAsync_d__17.NativeFieldInfoPtr___u__2);
					return new TaskAwaiter<Il2CppReferenceArray<LeaderboardEntry>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Il2CppReferenceArray<LeaderboardEntry>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._GetScoresFromFriendsAsync_d__17.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Il2CppReferenceArray<LeaderboardEntry>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040023D7 RID: 9175
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040023D8 RID: 9176
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040023D9 RID: 9177
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040023DA RID: 9178
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040023DB RID: 9179
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040023DC RID: 9180
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040023DD RID: 9181
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020002A7 RID: 679
		[ObfuscatedName("Steamworks.Data.Leaderboard+<LeaderboardResultToEntries>d__18")]
		public sealed class _LeaderboardResultToEntries_d__18 : ValueType
		{
			// Token: 0x0600226F RID: 8815 RVA: 0x00093954 File Offset: 0x00091B54
			// Note: this type is marked as 'beforefieldinit'.
			static _LeaderboardResultToEntries_d__18()
			{
				Il2CppClassPointerStore<Leaderboard._LeaderboardResultToEntries_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Leaderboard>.NativeClassPtr, "<LeaderboardResultToEntries>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Leaderboard._LeaderboardResultToEntries_d__18>.NativeClassPtr);
				Leaderboard._LeaderboardResultToEntries_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._LeaderboardResultToEntries_d__18>.NativeClassPtr, "<>1__state");
				Leaderboard._LeaderboardResultToEntries_d__18.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._LeaderboardResultToEntries_d__18>.NativeClassPtr, "<>t__builder");
				Leaderboard._LeaderboardResultToEntries_d__18.NativeFieldInfoPtr_r = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._LeaderboardResultToEntries_d__18>.NativeClassPtr, "r");
				Leaderboard._LeaderboardResultToEntries_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._LeaderboardResultToEntries_d__18>.NativeClassPtr, "<>4__this");
				Leaderboard._LeaderboardResultToEntries_d__18.NativeFieldInfoPtr__output_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._LeaderboardResultToEntries_d__18>.NativeClassPtr, "<output>5__2");
				Leaderboard._LeaderboardResultToEntries_d__18.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._LeaderboardResultToEntries_d__18>.NativeClassPtr, "<>u__1");
				Leaderboard._LeaderboardResultToEntries_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Leaderboard._LeaderboardResultToEntries_d__18>.NativeClassPtr, 100667955);
				Leaderboard._LeaderboardResultToEntries_d__18.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Leaderboard._LeaderboardResultToEntries_d__18>.NativeClassPtr, 100667956);
			}

			// Token: 0x06002270 RID: 8816 RVA: 0x00093A20 File Offset: 0x00091C20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952097, XrefRangeEnd = 952145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Leaderboard._LeaderboardResultToEntries_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002271 RID: 8817 RVA: 0x00093A58 File Offset: 0x00091C58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952145, XrefRangeEnd = 952151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Leaderboard._LeaderboardResultToEntries_d__18.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002272 RID: 8818 RVA: 0x0000E12D File Offset: 0x0000C32D
			public _LeaderboardResultToEntries_d__18(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002273 RID: 8819 RVA: 0x0000E136 File Offset: 0x0000C336
			public _LeaderboardResultToEntries_d__18()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Leaderboard._LeaderboardResultToEntries_d__18>.NativeClassPtr))
			{
			}

			// Token: 0x17000905 RID: 2309
			// (get) Token: 0x06002274 RID: 8820 RVA: 0x00093AA0 File Offset: 0x00091CA0
			// (set) Token: 0x06002275 RID: 8821 RVA: 0x0000E148 File Offset: 0x0000C348
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._LeaderboardResultToEntries_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._LeaderboardResultToEntries_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000906 RID: 2310
			// (get) Token: 0x06002276 RID: 8822 RVA: 0x00093AC8 File Offset: 0x00091CC8
			// (set) Token: 0x06002277 RID: 8823 RVA: 0x0000E163 File Offset: 0x0000C363
			public AsyncTaskMethodBuilder<Il2CppReferenceArray<LeaderboardEntry>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._LeaderboardResultToEntries_d__18.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Il2CppReferenceArray<LeaderboardEntry>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppReferenceArray<LeaderboardEntry>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._LeaderboardResultToEntries_d__18.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppReferenceArray<LeaderboardEntry>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000907 RID: 2311
			// (get) Token: 0x06002278 RID: 8824 RVA: 0x00093AF8 File Offset: 0x00091CF8
			// (set) Token: 0x06002279 RID: 8825 RVA: 0x0000E191 File Offset: 0x0000C391
			public unsafe LeaderboardScoresDownloaded_t r
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._LeaderboardResultToEntries_d__18.NativeFieldInfoPtr_r);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._LeaderboardResultToEntries_d__18.NativeFieldInfoPtr_r)) = value;
				}
			}

			// Token: 0x17000908 RID: 2312
			// (get) Token: 0x0600227A RID: 8826 RVA: 0x00093B20 File Offset: 0x00091D20
			// (set) Token: 0x0600227B RID: 8827 RVA: 0x0000E1AC File Offset: 0x0000C3AC
			public unsafe Leaderboard __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._LeaderboardResultToEntries_d__18.NativeFieldInfoPtr___4__this);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._LeaderboardResultToEntries_d__18.NativeFieldInfoPtr___4__this)) = value;
				}
			}

			// Token: 0x17000909 RID: 2313
			// (get) Token: 0x0600227C RID: 8828 RVA: 0x00093B48 File Offset: 0x00091D48
			// (set) Token: 0x0600227D RID: 8829 RVA: 0x0000E1C7 File Offset: 0x0000C3C7
			public unsafe Il2CppReferenceArray<LeaderboardEntry> _output_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._LeaderboardResultToEntries_d__18.NativeFieldInfoPtr__output_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LeaderboardEntry>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._LeaderboardResultToEntries_d__18.NativeFieldInfoPtr__output_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700090A RID: 2314
			// (get) Token: 0x0600227E RID: 8830 RVA: 0x00093B78 File Offset: 0x00091D78
			// (set) Token: 0x0600227F RID: 8831 RVA: 0x0000E1E6 File Offset: 0x0000C3E6
			public TaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._LeaderboardResultToEntries_d__18.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._LeaderboardResultToEntries_d__18.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040023DE RID: 9182
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040023DF RID: 9183
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040023E0 RID: 9184
			private static readonly IntPtr NativeFieldInfoPtr_r;

			// Token: 0x040023E1 RID: 9185
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040023E2 RID: 9186
			private static readonly IntPtr NativeFieldInfoPtr__output_5__2;

			// Token: 0x040023E3 RID: 9187
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040023E4 RID: 9188
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040023E5 RID: 9189
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020002A8 RID: 680
		[ObfuscatedName("Steamworks.Data.Leaderboard+<ReplaceScore>d__11")]
		public sealed class _ReplaceScore_d__11 : ValueType
		{
			// Token: 0x06002280 RID: 8832 RVA: 0x00093BA8 File Offset: 0x00091DA8
			// Note: this type is marked as 'beforefieldinit'.
			static _ReplaceScore_d__11()
			{
				Il2CppClassPointerStore<Leaderboard._ReplaceScore_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Leaderboard>.NativeClassPtr, "<ReplaceScore>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Leaderboard._ReplaceScore_d__11>.NativeClassPtr);
				Leaderboard._ReplaceScore_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._ReplaceScore_d__11>.NativeClassPtr, "<>1__state");
				Leaderboard._ReplaceScore_d__11.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._ReplaceScore_d__11>.NativeClassPtr, "<>t__builder");
				Leaderboard._ReplaceScore_d__11.NativeFieldInfoPtr_details = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._ReplaceScore_d__11>.NativeClassPtr, "details");
				Leaderboard._ReplaceScore_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._ReplaceScore_d__11>.NativeClassPtr, "<>4__this");
				Leaderboard._ReplaceScore_d__11.NativeFieldInfoPtr_score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._ReplaceScore_d__11>.NativeClassPtr, "score");
				Leaderboard._ReplaceScore_d__11.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._ReplaceScore_d__11>.NativeClassPtr, "<>u__1");
				Leaderboard._ReplaceScore_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Leaderboard._ReplaceScore_d__11>.NativeClassPtr, 100667957);
				Leaderboard._ReplaceScore_d__11.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Leaderboard._ReplaceScore_d__11>.NativeClassPtr, 100667958);
			}

			// Token: 0x06002281 RID: 8833 RVA: 0x00093C74 File Offset: 0x00091E74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952151, XrefRangeEnd = 952183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Leaderboard._ReplaceScore_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002282 RID: 8834 RVA: 0x00093CAC File Offset: 0x00091EAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952183, XrefRangeEnd = 952189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Leaderboard._ReplaceScore_d__11.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002283 RID: 8835 RVA: 0x0000E214 File Offset: 0x0000C414
			public _ReplaceScore_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002284 RID: 8836 RVA: 0x0000E21D File Offset: 0x0000C41D
			public _ReplaceScore_d__11()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Leaderboard._ReplaceScore_d__11>.NativeClassPtr))
			{
			}

			// Token: 0x1700090B RID: 2315
			// (get) Token: 0x06002285 RID: 8837 RVA: 0x00093CF4 File Offset: 0x00091EF4
			// (set) Token: 0x06002286 RID: 8838 RVA: 0x0000E22F File Offset: 0x0000C42F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._ReplaceScore_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._ReplaceScore_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700090C RID: 2316
			// (get) Token: 0x06002287 RID: 8839 RVA: 0x00093D1C File Offset: 0x00091F1C
			// (set) Token: 0x06002288 RID: 8840 RVA: 0x0000E24A File Offset: 0x0000C44A
			public AsyncTaskMethodBuilder<Nullable<LeaderboardUpdate>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._ReplaceScore_d__11.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Nullable<LeaderboardUpdate>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<LeaderboardUpdate>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._ReplaceScore_d__11.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<LeaderboardUpdate>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700090D RID: 2317
			// (get) Token: 0x06002289 RID: 8841 RVA: 0x00093D4C File Offset: 0x00091F4C
			// (set) Token: 0x0600228A RID: 8842 RVA: 0x0000E278 File Offset: 0x0000C478
			public unsafe Il2CppStructArray<int> details
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._ReplaceScore_d__11.NativeFieldInfoPtr_details);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._ReplaceScore_d__11.NativeFieldInfoPtr_details), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700090E RID: 2318
			// (get) Token: 0x0600228B RID: 8843 RVA: 0x00093D7C File Offset: 0x00091F7C
			// (set) Token: 0x0600228C RID: 8844 RVA: 0x0000E297 File Offset: 0x0000C497
			public unsafe Leaderboard __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._ReplaceScore_d__11.NativeFieldInfoPtr___4__this);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._ReplaceScore_d__11.NativeFieldInfoPtr___4__this)) = value;
				}
			}

			// Token: 0x1700090F RID: 2319
			// (get) Token: 0x0600228D RID: 8845 RVA: 0x00093DA4 File Offset: 0x00091FA4
			// (set) Token: 0x0600228E RID: 8846 RVA: 0x0000E2B2 File Offset: 0x0000C4B2
			public unsafe int score
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._ReplaceScore_d__11.NativeFieldInfoPtr_score);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._ReplaceScore_d__11.NativeFieldInfoPtr_score)) = value;
				}
			}

			// Token: 0x17000910 RID: 2320
			// (get) Token: 0x0600228F RID: 8847 RVA: 0x00093DCC File Offset: 0x00091FCC
			// (set) Token: 0x06002290 RID: 8848 RVA: 0x0000E2CD File Offset: 0x0000C4CD
			public CallResult<LeaderboardScoreUploaded_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._ReplaceScore_d__11.NativeFieldInfoPtr___u__1);
					return new CallResult<LeaderboardScoreUploaded_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<LeaderboardScoreUploaded_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._ReplaceScore_d__11.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<LeaderboardScoreUploaded_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040023E6 RID: 9190
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040023E7 RID: 9191
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040023E8 RID: 9192
			private static readonly IntPtr NativeFieldInfoPtr_details;

			// Token: 0x040023E9 RID: 9193
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040023EA RID: 9194
			private static readonly IntPtr NativeFieldInfoPtr_score;

			// Token: 0x040023EB RID: 9195
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040023EC RID: 9196
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040023ED RID: 9197
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020002A9 RID: 681
		[ObfuscatedName("Steamworks.Data.Leaderboard+<SubmitScoreAsync>d__12")]
		public sealed class _SubmitScoreAsync_d__12 : ValueType
		{
			// Token: 0x06002291 RID: 8849 RVA: 0x00093DFC File Offset: 0x00091FFC
			// Note: this type is marked as 'beforefieldinit'.
			static _SubmitScoreAsync_d__12()
			{
				Il2CppClassPointerStore<Leaderboard._SubmitScoreAsync_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Leaderboard>.NativeClassPtr, "<SubmitScoreAsync>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Leaderboard._SubmitScoreAsync_d__12>.NativeClassPtr);
				Leaderboard._SubmitScoreAsync_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._SubmitScoreAsync_d__12>.NativeClassPtr, "<>1__state");
				Leaderboard._SubmitScoreAsync_d__12.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._SubmitScoreAsync_d__12>.NativeClassPtr, "<>t__builder");
				Leaderboard._SubmitScoreAsync_d__12.NativeFieldInfoPtr_details = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._SubmitScoreAsync_d__12>.NativeClassPtr, "details");
				Leaderboard._SubmitScoreAsync_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._SubmitScoreAsync_d__12>.NativeClassPtr, "<>4__this");
				Leaderboard._SubmitScoreAsync_d__12.NativeFieldInfoPtr_score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._SubmitScoreAsync_d__12>.NativeClassPtr, "score");
				Leaderboard._SubmitScoreAsync_d__12.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._SubmitScoreAsync_d__12>.NativeClassPtr, "<>u__1");
				Leaderboard._SubmitScoreAsync_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Leaderboard._SubmitScoreAsync_d__12>.NativeClassPtr, 100667959);
				Leaderboard._SubmitScoreAsync_d__12.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Leaderboard._SubmitScoreAsync_d__12>.NativeClassPtr, 100667960);
			}

			// Token: 0x06002292 RID: 8850 RVA: 0x00093EC8 File Offset: 0x000920C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952189, XrefRangeEnd = 952221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Leaderboard._SubmitScoreAsync_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002293 RID: 8851 RVA: 0x00093F00 File Offset: 0x00092100
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952221, XrefRangeEnd = 952227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Leaderboard._SubmitScoreAsync_d__12.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002294 RID: 8852 RVA: 0x0000E2FB File Offset: 0x0000C4FB
			public _SubmitScoreAsync_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002295 RID: 8853 RVA: 0x0000E304 File Offset: 0x0000C504
			public _SubmitScoreAsync_d__12()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Leaderboard._SubmitScoreAsync_d__12>.NativeClassPtr))
			{
			}

			// Token: 0x17000911 RID: 2321
			// (get) Token: 0x06002296 RID: 8854 RVA: 0x00093F48 File Offset: 0x00092148
			// (set) Token: 0x06002297 RID: 8855 RVA: 0x0000E316 File Offset: 0x0000C516
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._SubmitScoreAsync_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._SubmitScoreAsync_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000912 RID: 2322
			// (get) Token: 0x06002298 RID: 8856 RVA: 0x00093F70 File Offset: 0x00092170
			// (set) Token: 0x06002299 RID: 8857 RVA: 0x0000E331 File Offset: 0x0000C531
			public AsyncTaskMethodBuilder<Nullable<LeaderboardUpdate>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._SubmitScoreAsync_d__12.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Nullable<LeaderboardUpdate>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<LeaderboardUpdate>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._SubmitScoreAsync_d__12.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<LeaderboardUpdate>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000913 RID: 2323
			// (get) Token: 0x0600229A RID: 8858 RVA: 0x00093FA0 File Offset: 0x000921A0
			// (set) Token: 0x0600229B RID: 8859 RVA: 0x0000E35F File Offset: 0x0000C55F
			public unsafe Il2CppStructArray<int> details
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._SubmitScoreAsync_d__12.NativeFieldInfoPtr_details);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._SubmitScoreAsync_d__12.NativeFieldInfoPtr_details), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000914 RID: 2324
			// (get) Token: 0x0600229C RID: 8860 RVA: 0x00093FD0 File Offset: 0x000921D0
			// (set) Token: 0x0600229D RID: 8861 RVA: 0x0000E37E File Offset: 0x0000C57E
			public unsafe Leaderboard __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._SubmitScoreAsync_d__12.NativeFieldInfoPtr___4__this);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._SubmitScoreAsync_d__12.NativeFieldInfoPtr___4__this)) = value;
				}
			}

			// Token: 0x17000915 RID: 2325
			// (get) Token: 0x0600229E RID: 8862 RVA: 0x00093FF8 File Offset: 0x000921F8
			// (set) Token: 0x0600229F RID: 8863 RVA: 0x0000E399 File Offset: 0x0000C599
			public unsafe int score
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._SubmitScoreAsync_d__12.NativeFieldInfoPtr_score);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._SubmitScoreAsync_d__12.NativeFieldInfoPtr_score)) = value;
				}
			}

			// Token: 0x17000916 RID: 2326
			// (get) Token: 0x060022A0 RID: 8864 RVA: 0x00094020 File Offset: 0x00092220
			// (set) Token: 0x060022A1 RID: 8865 RVA: 0x0000E3B4 File Offset: 0x0000C5B4
			public CallResult<LeaderboardScoreUploaded_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._SubmitScoreAsync_d__12.NativeFieldInfoPtr___u__1);
					return new CallResult<LeaderboardScoreUploaded_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<LeaderboardScoreUploaded_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._SubmitScoreAsync_d__12.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<LeaderboardScoreUploaded_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040023EE RID: 9198
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040023EF RID: 9199
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040023F0 RID: 9200
			private static readonly IntPtr NativeFieldInfoPtr_details;

			// Token: 0x040023F1 RID: 9201
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040023F2 RID: 9202
			private static readonly IntPtr NativeFieldInfoPtr_score;

			// Token: 0x040023F3 RID: 9203
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040023F4 RID: 9204
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040023F5 RID: 9205
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020002AA RID: 682
		[ObfuscatedName("Steamworks.Data.Leaderboard+<WaitForUserNames>d__19")]
		public sealed class _WaitForUserNames_d__19 : ValueType
		{
			// Token: 0x060022A2 RID: 8866 RVA: 0x00094050 File Offset: 0x00092250
			// Note: this type is marked as 'beforefieldinit'.
			static _WaitForUserNames_d__19()
			{
				Il2CppClassPointerStore<Leaderboard._WaitForUserNames_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Leaderboard>.NativeClassPtr, "<WaitForUserNames>d__19");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Leaderboard._WaitForUserNames_d__19>.NativeClassPtr);
				Leaderboard._WaitForUserNames_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._WaitForUserNames_d__19>.NativeClassPtr, "<>1__state");
				Leaderboard._WaitForUserNames_d__19.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._WaitForUserNames_d__19>.NativeClassPtr, "<>t__builder");
				Leaderboard._WaitForUserNames_d__19.NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._WaitForUserNames_d__19>.NativeClassPtr, "entries");
				Leaderboard._WaitForUserNames_d__19.NativeFieldInfoPtr__gotAll_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._WaitForUserNames_d__19>.NativeClassPtr, "<gotAll>5__2");
				Leaderboard._WaitForUserNames_d__19.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Leaderboard._WaitForUserNames_d__19>.NativeClassPtr, "<>u__1");
				Leaderboard._WaitForUserNames_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Leaderboard._WaitForUserNames_d__19>.NativeClassPtr, 100667961);
				Leaderboard._WaitForUserNames_d__19.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Leaderboard._WaitForUserNames_d__19>.NativeClassPtr, 100667962);
			}

			// Token: 0x060022A3 RID: 8867 RVA: 0x00094108 File Offset: 0x00092308
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952227, XrefRangeEnd = 952250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Leaderboard._WaitForUserNames_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022A4 RID: 8868 RVA: 0x00094140 File Offset: 0x00092340
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952250, XrefRangeEnd = 952254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Leaderboard._WaitForUserNames_d__19.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060022A5 RID: 8869 RVA: 0x0000E3E2 File Offset: 0x0000C5E2
			public _WaitForUserNames_d__19(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060022A6 RID: 8870 RVA: 0x0000E3EB File Offset: 0x0000C5EB
			public _WaitForUserNames_d__19()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Leaderboard._WaitForUserNames_d__19>.NativeClassPtr))
			{
			}

			// Token: 0x17000917 RID: 2327
			// (get) Token: 0x060022A7 RID: 8871 RVA: 0x00094188 File Offset: 0x00092388
			// (set) Token: 0x060022A8 RID: 8872 RVA: 0x0000E3FD File Offset: 0x0000C5FD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._WaitForUserNames_d__19.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._WaitForUserNames_d__19.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000918 RID: 2328
			// (get) Token: 0x060022A9 RID: 8873 RVA: 0x000941B0 File Offset: 0x000923B0
			// (set) Token: 0x060022AA RID: 8874 RVA: 0x0000E418 File Offset: 0x0000C618
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._WaitForUserNames_d__19.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._WaitForUserNames_d__19.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000919 RID: 2329
			// (get) Token: 0x060022AB RID: 8875 RVA: 0x000941E0 File Offset: 0x000923E0
			// (set) Token: 0x060022AC RID: 8876 RVA: 0x0000E446 File Offset: 0x0000C646
			public unsafe Il2CppReferenceArray<LeaderboardEntry> entries
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._WaitForUserNames_d__19.NativeFieldInfoPtr_entries);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LeaderboardEntry>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._WaitForUserNames_d__19.NativeFieldInfoPtr_entries), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700091A RID: 2330
			// (get) Token: 0x060022AD RID: 8877 RVA: 0x00094210 File Offset: 0x00092410
			// (set) Token: 0x060022AE RID: 8878 RVA: 0x0000E465 File Offset: 0x0000C665
			public unsafe bool _gotAll_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._WaitForUserNames_d__19.NativeFieldInfoPtr__gotAll_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._WaitForUserNames_d__19.NativeFieldInfoPtr__gotAll_5__2)) = value;
				}
			}

			// Token: 0x1700091B RID: 2331
			// (get) Token: 0x060022AF RID: 8879 RVA: 0x00094238 File Offset: 0x00092438
			// (set) Token: 0x060022B0 RID: 8880 RVA: 0x0000E480 File Offset: 0x0000C680
			public TaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._WaitForUserNames_d__19.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Leaderboard._WaitForUserNames_d__19.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040023F6 RID: 9206
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040023F7 RID: 9207
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040023F8 RID: 9208
			private static readonly IntPtr NativeFieldInfoPtr_entries;

			// Token: 0x040023F9 RID: 9209
			private static readonly IntPtr NativeFieldInfoPtr__gotAll_5__2;

			// Token: 0x040023FA RID: 9210
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040023FB RID: 9211
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040023FC RID: 9212
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
