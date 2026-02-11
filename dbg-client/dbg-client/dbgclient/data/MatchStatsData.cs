using System;
using System.Runtime.InteropServices;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dbgclient.data
{
	// Token: 0x020000D5 RID: 213
	public class MatchStatsData : Object
	{
		// Token: 0x060008F9 RID: 2297 RVA: 0x00039980 File Offset: 0x00037B80
		// Note: this type is marked as 'beforefieldinit'.
		static MatchStatsData()
		{
			Il2CppClassPointerStore<MatchStatsData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.data", "MatchStatsData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchStatsData>.NativeClassPtr);
			MatchStatsData.NativeFieldInfoPtr_AccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStatsData>.NativeClassPtr, "AccountID");
			MatchStatsData.NativeFieldInfoPtr_MatchStatsList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStatsData>.NativeClassPtr, "MatchStatsList");
			MatchStatsData.NativeMethodInfoPtr__ctor_Public_Void_AccountID_List_1_MatchStatsEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsData>.NativeClassPtr, 100664578);
			MatchStatsData.NativeMethodInfoPtr_GetTotalMatches_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsData>.NativeClassPtr, 100664579);
			MatchStatsData.NativeMethodInfoPtr_GetTotalMatches_Public_Int32_List_1_StatsFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsData>.NativeClassPtr, 100664580);
			MatchStatsData.NativeMethodInfoPtr_TryGetWinPercentage_Public_Boolean_List_1_StatsFilter_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsData>.NativeClassPtr, 100664581);
			MatchStatsData.NativeMethodInfoPtr_TryGetWinTotal_Public_Boolean_List_1_StatsFilter_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsData>.NativeClassPtr, 100664582);
			MatchStatsData.NativeMethodInfoPtr_TryGetMax_Public_Boolean_String_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsData>.NativeClassPtr, 100664583);
			MatchStatsData.NativeMethodInfoPtr_TryGetMax_Public_Boolean_String_List_1_StatsFilter_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsData>.NativeClassPtr, 100664584);
			MatchStatsData.NativeMethodInfoPtr_TryGetTotal_Public_Boolean_String_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsData>.NativeClassPtr, 100664585);
			MatchStatsData.NativeMethodInfoPtr_TryGetTotal_Public_Boolean_String_List_1_StatsFilter_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsData>.NativeClassPtr, 100664586);
			MatchStatsData.NativeMethodInfoPtr_TryGetAverage_Public_Boolean_String_String_List_1_StatsFilter_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsData>.NativeClassPtr, 100664587);
			MatchStatsData.NativeMethodInfoPtr_TryGetAverage_Public_Boolean_String_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsData>.NativeClassPtr, 100664588);
			MatchStatsData.NativeMethodInfoPtr_TryGetAverage_Public_Boolean_String_List_1_StatsFilter_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsData>.NativeClassPtr, 100664589);
			MatchStatsData.NativeMethodInfoPtr_TryGetSumDivisor_Public_Boolean_String_String_List_1_StatsFilter_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsData>.NativeClassPtr, 100664590);
			MatchStatsData.NativeMethodInfoPtr_TryGetSumDivisor_Public_Boolean_String_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsData>.NativeClassPtr, 100664591);
			MatchStatsData.NativeMethodInfoPtr_TryGetSumDivisor_Public_Boolean_String_List_1_StatsFilter_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsData>.NativeClassPtr, 100664592);
			MatchStatsData.NativeMethodInfoPtr_GetMaxTotal_Public_Boolean_List_1_StatsFilter_byref_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsData>.NativeClassPtr, 100664593);
			MatchStatsData.NativeMethodInfoPtr_FilteredMatchStats_Private_IEnumerable_1_MatchStatsEntry_List_1_StatsFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsData>.NativeClassPtr, 100664594);
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x00039B2C File Offset: 0x00037D2C
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchStatsData(AccountID accountID, List<MatchStatsEntry> matchStatsList)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchStatsData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(matchStatsList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsData.NativeMethodInfoPtr__ctor_Public_Void_AccountID_List_1_MatchStatsEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x00039B8C File Offset: 0x00037D8C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 504934, RefRangeEnd = 504938, XrefRangeStart = 504916, XrefRangeEnd = 504934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTotalMatches()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsData.NativeMethodInfoPtr_GetTotalMatches_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x00039BC8 File Offset: 0x00037DC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 504960, RefRangeEnd = 504961, XrefRangeStart = 504938, XrefRangeEnd = 504960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTotalMatches(List<StatsFilter> filter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(filter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsData.NativeMethodInfoPtr_GetTotalMatches_Public_Int32_List_1_StatsFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x00039C18 File Offset: 0x00037E18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504961, XrefRangeEnd = 504999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetWinPercentage(List<StatsFilter> filter, out float winPercentage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(filter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &winPercentage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsData.NativeMethodInfoPtr_TryGetWinPercentage_Public_Boolean_List_1_StatsFilter_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x00039C74 File Offset: 0x00037E74
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 505021, RefRangeEnd = 505025, XrefRangeStart = 504999, XrefRangeEnd = 505021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetWinTotal(List<StatsFilter> filter, out float winTotal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(filter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &winTotal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsData.NativeMethodInfoPtr_TryGetWinTotal_Public_Boolean_List_1_StatsFilter_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x00039CD0 File Offset: 0x00037ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505025, XrefRangeEnd = 505026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetMax(string category, out float total)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(category);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &total;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsData.NativeMethodInfoPtr_TryGetMax_Public_Boolean_String_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x00039D2C File Offset: 0x00037F2C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 505047, RefRangeEnd = 505050, XrefRangeStart = 505026, XrefRangeEnd = 505047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetMax(string category, List<StatsFilter> filter, out float max)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(category);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsData.NativeMethodInfoPtr_TryGetMax_Public_Boolean_String_List_1_StatsFilter_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x00039D9C File Offset: 0x00037F9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 505051, RefRangeEnd = 505053, XrefRangeStart = 505050, XrefRangeEnd = 505051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetTotal(string category, out float total)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(category);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &total;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsData.NativeMethodInfoPtr_TryGetTotal_Public_Boolean_String_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x00039DF8 File Offset: 0x00037FF8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 505074, RefRangeEnd = 505080, XrefRangeStart = 505053, XrefRangeEnd = 505074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetTotal(string category, List<StatsFilter> filter, out float total)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(category);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &total;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsData.NativeMethodInfoPtr_TryGetTotal_Public_Boolean_String_List_1_StatsFilter_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x00039E68 File Offset: 0x00038068
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 505081, RefRangeEnd = 505083, XrefRangeStart = 505080, XrefRangeEnd = 505081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetAverage(string category, string divisorCategory, List<StatsFilter> filter, out float average)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(category);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(divisorCategory);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &average;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsData.NativeMethodInfoPtr_TryGetAverage_Public_Boolean_String_String_List_1_StatsFilter_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x00039EE8 File Offset: 0x000380E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505083, XrefRangeEnd = 505084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetAverage(string category, out float average)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(category);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &average;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsData.NativeMethodInfoPtr_TryGetAverage_Public_Boolean_String_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x00039F44 File Offset: 0x00038144
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 505085, RefRangeEnd = 505087, XrefRangeStart = 505084, XrefRangeEnd = 505085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetAverage(string category, List<StatsFilter> filter, out float average)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(category);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &average;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsData.NativeMethodInfoPtr_TryGetAverage_Public_Boolean_String_List_1_StatsFilter_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x00039FB4 File Offset: 0x000381B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 505110, RefRangeEnd = 505113, XrefRangeStart = 505087, XrefRangeEnd = 505110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetSumDivisor(string category, string divisorCategory, List<StatsFilter> filter, out float sum, out float divisor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(category);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(divisorCategory);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &sum;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &divisor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsData.NativeMethodInfoPtr_TryGetSumDivisor_Public_Boolean_String_String_List_1_StatsFilter_byref_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x0003A044 File Offset: 0x00038244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505113, XrefRangeEnd = 505114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetSumDivisor(string category, out float sum, out float divisor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(category);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &sum;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &divisor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsData.NativeMethodInfoPtr_TryGetSumDivisor_Public_Boolean_String_byref_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x0003A0B0 File Offset: 0x000382B0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 505135, RefRangeEnd = 505140, XrefRangeStart = 505114, XrefRangeEnd = 505135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetSumDivisor(string category, List<StatsFilter> filter, out float sum, out float divisor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(category);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &sum;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &divisor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsData.NativeMethodInfoPtr_TryGetSumDivisor_Public_Boolean_String_List_1_StatsFilter_byref_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x0003A12C File Offset: 0x0003832C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 505147, RefRangeEnd = 505151, XrefRangeStart = 505140, XrefRangeEnd = 505147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetMaxTotal(List<StatsFilter> filter, out string category, [Optional] Il2CppStringArray categories)
		{
			if (categories == null)
			{
				categories = new Il2CppStringArray(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(filter);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(categories);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MatchStatsData.NativeMethodInfoPtr_GetMaxTotal_Public_Boolean_List_1_StatsFilter_byref_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			category = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x0003A1B4 File Offset: 0x000383B4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 505168, RefRangeEnd = 505175, XrefRangeStart = 505151, XrefRangeEnd = 505168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<MatchStatsEntry> FilteredMatchStats(List<StatsFilter> filters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(filters);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsData.NativeMethodInfoPtr_FilteredMatchStats_Private_IEnumerable_1_MatchStatsEntry_List_1_StatsFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<MatchStatsEntry>>(intPtr3) : null;
			}
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x000063C1 File Offset: 0x000045C1
		public bool GetMaxTotal(List<StatsFilter> filter, out string category, params string[] categories)
		{
			return this.GetMaxTotal(filter, out category, new Il2CppStringArray(categories));
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x000063D1 File Offset: 0x000045D1
		public MatchStatsData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x0600090D RID: 2317 RVA: 0x0003A204 File Offset: 0x00038404
		// (set) Token: 0x0600090E RID: 2318 RVA: 0x000063DA File Offset: 0x000045DA
		public unsafe AccountID AccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsData.NativeFieldInfoPtr_AccountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsData.NativeFieldInfoPtr_AccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x0600090F RID: 2319 RVA: 0x0003A234 File Offset: 0x00038434
		// (set) Token: 0x06000910 RID: 2320 RVA: 0x000063F9 File Offset: 0x000045F9
		public unsafe List<MatchStatsEntry> MatchStatsList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsData.NativeFieldInfoPtr_MatchStatsList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MatchStatsEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsData.NativeFieldInfoPtr_MatchStatsList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000574 RID: 1396
		private static readonly IntPtr NativeFieldInfoPtr_AccountID;

		// Token: 0x04000575 RID: 1397
		private static readonly IntPtr NativeFieldInfoPtr_MatchStatsList;

		// Token: 0x04000576 RID: 1398
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AccountID_List_1_MatchStatsEntry_0;

		// Token: 0x04000577 RID: 1399
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalMatches_Public_Int32_0;

		// Token: 0x04000578 RID: 1400
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalMatches_Public_Int32_List_1_StatsFilter_0;

		// Token: 0x04000579 RID: 1401
		private static readonly IntPtr NativeMethodInfoPtr_TryGetWinPercentage_Public_Boolean_List_1_StatsFilter_byref_Single_0;

		// Token: 0x0400057A RID: 1402
		private static readonly IntPtr NativeMethodInfoPtr_TryGetWinTotal_Public_Boolean_List_1_StatsFilter_byref_Single_0;

		// Token: 0x0400057B RID: 1403
		private static readonly IntPtr NativeMethodInfoPtr_TryGetMax_Public_Boolean_String_byref_Single_0;

		// Token: 0x0400057C RID: 1404
		private static readonly IntPtr NativeMethodInfoPtr_TryGetMax_Public_Boolean_String_List_1_StatsFilter_byref_Single_0;

		// Token: 0x0400057D RID: 1405
		private static readonly IntPtr NativeMethodInfoPtr_TryGetTotal_Public_Boolean_String_byref_Single_0;

		// Token: 0x0400057E RID: 1406
		private static readonly IntPtr NativeMethodInfoPtr_TryGetTotal_Public_Boolean_String_List_1_StatsFilter_byref_Single_0;

		// Token: 0x0400057F RID: 1407
		private static readonly IntPtr NativeMethodInfoPtr_TryGetAverage_Public_Boolean_String_String_List_1_StatsFilter_byref_Single_0;

		// Token: 0x04000580 RID: 1408
		private static readonly IntPtr NativeMethodInfoPtr_TryGetAverage_Public_Boolean_String_byref_Single_0;

		// Token: 0x04000581 RID: 1409
		private static readonly IntPtr NativeMethodInfoPtr_TryGetAverage_Public_Boolean_String_List_1_StatsFilter_byref_Single_0;

		// Token: 0x04000582 RID: 1410
		private static readonly IntPtr NativeMethodInfoPtr_TryGetSumDivisor_Public_Boolean_String_String_List_1_StatsFilter_byref_Single_byref_Single_0;

		// Token: 0x04000583 RID: 1411
		private static readonly IntPtr NativeMethodInfoPtr_TryGetSumDivisor_Public_Boolean_String_byref_Single_byref_Single_0;

		// Token: 0x04000584 RID: 1412
		private static readonly IntPtr NativeMethodInfoPtr_TryGetSumDivisor_Public_Boolean_String_List_1_StatsFilter_byref_Single_byref_Single_0;

		// Token: 0x04000585 RID: 1413
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxTotal_Public_Boolean_List_1_StatsFilter_byref_String_Il2CppStringArray_0;

		// Token: 0x04000586 RID: 1414
		private static readonly IntPtr NativeMethodInfoPtr_FilteredMatchStats_Private_IEnumerable_1_MatchStatsEntry_List_1_StatsFilter_0;

		// Token: 0x02000324 RID: 804
		[ObfuscatedName("dbgclient.data.MatchStatsData+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060025ED RID: 9709 RVA: 0x00099EF0 File Offset: 0x000980F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MatchStatsData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MatchStatsData>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchStatsData.__c>.NativeClassPtr);
				MatchStatsData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStatsData.__c>.NativeClassPtr, "<>9");
				MatchStatsData.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStatsData.__c>.NativeClassPtr, "<>9__3_0");
				MatchStatsData.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStatsData.__c>.NativeClassPtr, "<>9__4_0");
				MatchStatsData.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStatsData.__c>.NativeClassPtr, "<>9__5_0");
				MatchStatsData.__c.NativeFieldInfoPtr___9__5_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStatsData.__c>.NativeClassPtr, "<>9__5_1");
				MatchStatsData.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStatsData.__c>.NativeClassPtr, "<>9__6_0");
				MatchStatsData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsData.__c>.NativeClassPtr, 100664596);
				MatchStatsData.__c.NativeMethodInfoPtr__GetTotalMatches_b__3_0_Internal_Int32_MatchStatsEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsData.__c>.NativeClassPtr, 100664597);
				MatchStatsData.__c.NativeMethodInfoPtr__GetTotalMatches_b__4_0_Internal_Int32_MatchStatsEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsData.__c>.NativeClassPtr, 100664598);
				MatchStatsData.__c.NativeMethodInfoPtr__TryGetWinPercentage_b__5_0_Internal_Int32_MatchStatsEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsData.__c>.NativeClassPtr, 100664599);
				MatchStatsData.__c.NativeMethodInfoPtr__TryGetWinPercentage_b__5_1_Internal_Int32_MatchStatsEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsData.__c>.NativeClassPtr, 100664600);
				MatchStatsData.__c.NativeMethodInfoPtr__TryGetWinTotal_b__6_0_Internal_Int32_MatchStatsEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsData.__c>.NativeClassPtr, 100664601);
			}

			// Token: 0x060025EE RID: 9710 RVA: 0x0009A00C File Offset: 0x0009820C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchStatsData.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060025EF RID: 9711 RVA: 0x0009A048 File Offset: 0x00098248
			[CallerCount(0)]
			public unsafe int _GetTotalMatches_b__3_0(MatchStatsEntry e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsData.__c.NativeMethodInfoPtr__GetTotalMatches_b__3_0_Internal_Int32_MatchStatsEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060025F0 RID: 9712 RVA: 0x0009A098 File Offset: 0x00098298
			[CallerCount(0)]
			public unsafe int _GetTotalMatches_b__4_0(MatchStatsEntry e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsData.__c.NativeMethodInfoPtr__GetTotalMatches_b__4_0_Internal_Int32_MatchStatsEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060025F1 RID: 9713 RVA: 0x0009A0E8 File Offset: 0x000982E8
			[CallerCount(0)]
			public unsafe int _TryGetWinPercentage_b__5_0(MatchStatsEntry e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsData.__c.NativeMethodInfoPtr__TryGetWinPercentage_b__5_0_Internal_Int32_MatchStatsEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060025F2 RID: 9714 RVA: 0x0009A138 File Offset: 0x00098338
			[CallerCount(0)]
			public unsafe int _TryGetWinPercentage_b__5_1(MatchStatsEntry e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsData.__c.NativeMethodInfoPtr__TryGetWinPercentage_b__5_1_Internal_Int32_MatchStatsEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060025F3 RID: 9715 RVA: 0x0009A188 File Offset: 0x00098388
			[CallerCount(0)]
			public unsafe int _TryGetWinTotal_b__6_0(MatchStatsEntry e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsData.__c.NativeMethodInfoPtr__TryGetWinTotal_b__6_0_Internal_Int32_MatchStatsEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060025F4 RID: 9716 RVA: 0x00013AFE File Offset: 0x00011CFE
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A77 RID: 2679
			// (get) Token: 0x060025F5 RID: 9717 RVA: 0x0009A1D8 File Offset: 0x000983D8
			// (set) Token: 0x060025F6 RID: 9718 RVA: 0x00013B07 File Offset: 0x00011D07
			public unsafe static MatchStatsData.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MatchStatsData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MatchStatsData.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MatchStatsData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A78 RID: 2680
			// (get) Token: 0x060025F7 RID: 9719 RVA: 0x0009A200 File Offset: 0x00098400
			// (set) Token: 0x060025F8 RID: 9720 RVA: 0x00013B19 File Offset: 0x00011D19
			public unsafe static Func<MatchStatsEntry, int> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MatchStatsData.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MatchStatsEntry, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MatchStatsData.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A79 RID: 2681
			// (get) Token: 0x060025F9 RID: 9721 RVA: 0x0009A228 File Offset: 0x00098428
			// (set) Token: 0x060025FA RID: 9722 RVA: 0x00013B2B File Offset: 0x00011D2B
			public unsafe static Func<MatchStatsEntry, int> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MatchStatsData.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MatchStatsEntry, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MatchStatsData.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A7A RID: 2682
			// (get) Token: 0x060025FB RID: 9723 RVA: 0x0009A250 File Offset: 0x00098450
			// (set) Token: 0x060025FC RID: 9724 RVA: 0x00013B3D File Offset: 0x00011D3D
			public unsafe static Func<MatchStatsEntry, int> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MatchStatsData.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MatchStatsEntry, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MatchStatsData.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A7B RID: 2683
			// (get) Token: 0x060025FD RID: 9725 RVA: 0x0009A278 File Offset: 0x00098478
			// (set) Token: 0x060025FE RID: 9726 RVA: 0x00013B4F File Offset: 0x00011D4F
			public unsafe static Func<MatchStatsEntry, int> __9__5_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MatchStatsData.__c.NativeFieldInfoPtr___9__5_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MatchStatsEntry, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MatchStatsData.__c.NativeFieldInfoPtr___9__5_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A7C RID: 2684
			// (get) Token: 0x060025FF RID: 9727 RVA: 0x0009A2A0 File Offset: 0x000984A0
			// (set) Token: 0x06002600 RID: 9728 RVA: 0x00013B61 File Offset: 0x00011D61
			public unsafe static Func<MatchStatsEntry, int> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MatchStatsData.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MatchStatsEntry, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MatchStatsData.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017C9 RID: 6089
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040017CA RID: 6090
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x040017CB RID: 6091
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x040017CC RID: 6092
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x040017CD RID: 6093
			private static readonly IntPtr NativeFieldInfoPtr___9__5_1;

			// Token: 0x040017CE RID: 6094
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x040017CF RID: 6095
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040017D0 RID: 6096
			private static readonly IntPtr NativeMethodInfoPtr__GetTotalMatches_b__3_0_Internal_Int32_MatchStatsEntry_0;

			// Token: 0x040017D1 RID: 6097
			private static readonly IntPtr NativeMethodInfoPtr__GetTotalMatches_b__4_0_Internal_Int32_MatchStatsEntry_0;

			// Token: 0x040017D2 RID: 6098
			private static readonly IntPtr NativeMethodInfoPtr__TryGetWinPercentage_b__5_0_Internal_Int32_MatchStatsEntry_0;

			// Token: 0x040017D3 RID: 6099
			private static readonly IntPtr NativeMethodInfoPtr__TryGetWinPercentage_b__5_1_Internal_Int32_MatchStatsEntry_0;

			// Token: 0x040017D4 RID: 6100
			private static readonly IntPtr NativeMethodInfoPtr__TryGetWinTotal_b__6_0_Internal_Int32_MatchStatsEntry_0;
		}
	}
}
