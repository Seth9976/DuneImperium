using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dbgclient.data
{
	// Token: 0x020000D6 RID: 214
	[Serializable]
	public class StatsFilter : Object
	{
		// Token: 0x06000911 RID: 2321 RVA: 0x0003A264 File Offset: 0x00038464
		// Note: this type is marked as 'beforefieldinit'.
		static StatsFilter()
		{
			Il2CppClassPointerStore<StatsFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.data", "StatsFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatsFilter>.NativeClassPtr);
			StatsFilter.NativeFieldInfoPtr_exclude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsFilter>.NativeClassPtr, "exclude");
			StatsFilter.NativeFieldInfoPtr_filter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsFilter>.NativeClassPtr, "filter");
			StatsFilter.NativeMethodInfoPtr_Filter_Public_Virtual_New_IEnumerable_1_MatchStatsEntry_IEnumerable_1_MatchStatsEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsFilter>.NativeClassPtr, 100664602);
			StatsFilter.NativeMethodInfoPtr_Equals_Public_Boolean_StatsFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsFilter>.NativeClassPtr, 100664603);
			StatsFilter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsFilter>.NativeClassPtr, 100664604);
			StatsFilter.NativeMethodInfoPtr__Filter_b__2_0_Private_Boolean_MatchStatsEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsFilter>.NativeClassPtr, 100664605);
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x0003A30C File Offset: 0x0003850C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505175, XrefRangeEnd = 505184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<MatchStatsEntry> Filter(IEnumerable<MatchStatsEntry> entries)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entries);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StatsFilter.NativeMethodInfoPtr_Filter_Public_Virtual_New_IEnumerable_1_MatchStatsEntry_IEnumerable_1_MatchStatsEntry_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<MatchStatsEntry>>(intPtr3) : null;
			}
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x0003A368 File Offset: 0x00038568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505184, XrefRangeEnd = 505186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(StatsFilter other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatsFilter.NativeMethodInfoPtr_Equals_Public_Boolean_StatsFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x0003A3B8 File Offset: 0x000385B8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StatsFilter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatsFilter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatsFilter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x0003A3F4 File Offset: 0x000385F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505186, XrefRangeEnd = 505192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Filter_b__2_0(MatchStatsEntry e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatsFilter.NativeMethodInfoPtr__Filter_b__2_0_Private_Boolean_MatchStatsEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x00006418 File Offset: 0x00004618
		public StatsFilter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000917 RID: 2327 RVA: 0x0003A444 File Offset: 0x00038644
		// (set) Token: 0x06000918 RID: 2328 RVA: 0x00006421 File Offset: 0x00004621
		public unsafe bool exclude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatsFilter.NativeFieldInfoPtr_exclude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatsFilter.NativeFieldInfoPtr_exclude)) = value;
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000919 RID: 2329 RVA: 0x0003A46C File Offset: 0x0003866C
		// (set) Token: 0x0600091A RID: 2330 RVA: 0x0000643C File Offset: 0x0000463C
		public StringValuePair filter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatsFilter.NativeFieldInfoPtr_filter);
				return new StringValuePair(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StringValuePair>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatsFilter.NativeFieldInfoPtr_filter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StringValuePair>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000587 RID: 1415
		private static readonly IntPtr NativeFieldInfoPtr_exclude;

		// Token: 0x04000588 RID: 1416
		private static readonly IntPtr NativeFieldInfoPtr_filter;

		// Token: 0x04000589 RID: 1417
		private static readonly IntPtr NativeMethodInfoPtr_Filter_Public_Virtual_New_IEnumerable_1_MatchStatsEntry_IEnumerable_1_MatchStatsEntry_0;

		// Token: 0x0400058A RID: 1418
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_StatsFilter_0;

		// Token: 0x0400058B RID: 1419
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400058C RID: 1420
		private static readonly IntPtr NativeMethodInfoPtr__Filter_b__2_0_Private_Boolean_MatchStatsEntry_0;
	}
}
