using System;
using dbgclient.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace dwd.canis.dbg_client.data
{
	// Token: 0x02000076 RID: 118
	[Serializable]
	public class OwnerWinnerStatsFilter : StatsFilter
	{
		// Token: 0x06000467 RID: 1127 RVA: 0x0002B4E4 File Offset: 0x000296E4
		// Note: this type is marked as 'beforefieldinit'.
		static OwnerWinnerStatsFilter()
		{
			Il2CppClassPointerStore<OwnerWinnerStatsFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.dbg_client.data", "OwnerWinnerStatsFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OwnerWinnerStatsFilter>.NativeClassPtr);
			OwnerWinnerStatsFilter.NativeFieldInfoPtr_wins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OwnerWinnerStatsFilter>.NativeClassPtr, "wins");
			OwnerWinnerStatsFilter.NativeFieldInfoPtr_currentAccount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OwnerWinnerStatsFilter>.NativeClassPtr, "currentAccount");
			OwnerWinnerStatsFilter.NativeMethodInfoPtr_Filter_Public_Virtual_IEnumerable_1_MatchStatsEntry_IEnumerable_1_MatchStatsEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OwnerWinnerStatsFilter>.NativeClassPtr, 100663948);
			OwnerWinnerStatsFilter.NativeMethodInfoPtr_GetAccountData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OwnerWinnerStatsFilter>.NativeClassPtr, 100663949);
			OwnerWinnerStatsFilter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OwnerWinnerStatsFilter>.NativeClassPtr, 100663950);
			OwnerWinnerStatsFilter.NativeMethodInfoPtr__Filter_b__2_0_Private_Boolean_MatchStatsEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OwnerWinnerStatsFilter>.NativeClassPtr, 100663951);
			OwnerWinnerStatsFilter.NativeMethodInfoPtr__Filter_b__2_1_Private_Boolean_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OwnerWinnerStatsFilter>.NativeClassPtr, 100663952);
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x0002B5A0 File Offset: 0x000297A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500638, XrefRangeEnd = 500653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<MatchStatsEntry> Filter(IEnumerable<MatchStatsEntry> entries)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entries);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OwnerWinnerStatsFilter.NativeMethodInfoPtr_Filter_Public_Virtual_IEnumerable_1_MatchStatsEntry_IEnumerable_1_MatchStatsEntry_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<MatchStatsEntry>>(intPtr3) : null;
			}
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x0002B5FC File Offset: 0x000297FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500653, XrefRangeEnd = 500659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetAccountData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OwnerWinnerStatsFilter.NativeMethodInfoPtr_GetAccountData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x0002B630 File Offset: 0x00029830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OwnerWinnerStatsFilter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OwnerWinnerStatsFilter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OwnerWinnerStatsFilter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x0002B66C File Offset: 0x0002986C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500659, XrefRangeEnd = 500669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe bool _Filter_b__2_0(MatchStatsEntry e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OwnerWinnerStatsFilter.NativeMethodInfoPtr__Filter_b__2_0_Private_Boolean_MatchStatsEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x0002B6BC File Offset: 0x000298BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500669, XrefRangeEnd = 500674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Filter_b__2_1(KeyValuePair<string, string> x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OwnerWinnerStatsFilter.NativeMethodInfoPtr__Filter_b__2_1_Private_Boolean_KeyValuePair_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00003FBE File Offset: 0x000021BE
		public OwnerWinnerStatsFilter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x0002B710 File Offset: 0x00029910
		// (set) Token: 0x0600046F RID: 1135 RVA: 0x00003FC7 File Offset: 0x000021C7
		public unsafe bool wins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OwnerWinnerStatsFilter.NativeFieldInfoPtr_wins);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OwnerWinnerStatsFilter.NativeFieldInfoPtr_wins)) = value;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x0002B738 File Offset: 0x00029938
		// (set) Token: 0x06000471 RID: 1137 RVA: 0x00003FE2 File Offset: 0x000021E2
		public unsafe string currentAccount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OwnerWinnerStatsFilter.NativeFieldInfoPtr_currentAccount);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OwnerWinnerStatsFilter.NativeFieldInfoPtr_currentAccount), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeFieldInfoPtr_wins;

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeFieldInfoPtr_currentAccount;

		// Token: 0x040002A3 RID: 675
		private static readonly IntPtr NativeMethodInfoPtr_Filter_Public_Virtual_IEnumerable_1_MatchStatsEntry_IEnumerable_1_MatchStatsEntry_0;

		// Token: 0x040002A4 RID: 676
		private static readonly IntPtr NativeMethodInfoPtr_GetAccountData_Private_Void_0;

		// Token: 0x040002A5 RID: 677
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040002A6 RID: 678
		private static readonly IntPtr NativeMethodInfoPtr__Filter_b__2_0_Private_Boolean_MatchStatsEntry_0;

		// Token: 0x040002A7 RID: 679
		private static readonly IntPtr NativeMethodInfoPtr__Filter_b__2_1_Private_Boolean_KeyValuePair_2_String_String_0;
	}
}
