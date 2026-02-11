using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dbgclient.data
{
	// Token: 0x020000D4 RID: 212
	[Serializable]
	public class MatchStatsEntry : Object
	{
		// Token: 0x060008EB RID: 2283 RVA: 0x0003975C File Offset: 0x0003795C
		// Note: this type is marked as 'beforefieldinit'.
		static MatchStatsEntry()
		{
			Il2CppClassPointerStore<MatchStatsEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.data", "MatchStatsEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchStatsEntry>.NativeClassPtr);
			MatchStatsEntry.NativeFieldInfoPtr_Matches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStatsEntry>.NativeClassPtr, "Matches");
			MatchStatsEntry.NativeFieldInfoPtr_Wins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStatsEntry>.NativeClassPtr, "Wins");
			MatchStatsEntry.NativeFieldInfoPtr_Sum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStatsEntry>.NativeClassPtr, "Sum");
			MatchStatsEntry.NativeFieldInfoPtr_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStatsEntry>.NativeClassPtr, "Max");
			MatchStatsEntry.NativeFieldInfoPtr_Filters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStatsEntry>.NativeClassPtr, "Filters");
			MatchStatsEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsEntry>.NativeClassPtr, 100664576);
			MatchStatsEntry.NativeMethodInfoPtr__ctor_Public_Void_MatchStatsEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsEntry>.NativeClassPtr, 100664577);
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x00039818 File Offset: 0x00037A18
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchStatsEntry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchStatsEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00039854 File Offset: 0x00037A54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504890, XrefRangeEnd = 504916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchStatsEntry(MatchStatsEntry other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchStatsEntry>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsEntry.NativeMethodInfoPtr__ctor_Public_Void_MatchStatsEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x00006325 File Offset: 0x00004525
		public MatchStatsEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x060008EF RID: 2287 RVA: 0x000398A0 File Offset: 0x00037AA0
		// (set) Token: 0x060008F0 RID: 2288 RVA: 0x0000632E File Offset: 0x0000452E
		public unsafe int Matches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsEntry.NativeFieldInfoPtr_Matches);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsEntry.NativeFieldInfoPtr_Matches)) = value;
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x060008F1 RID: 2289 RVA: 0x000398C8 File Offset: 0x00037AC8
		// (set) Token: 0x060008F2 RID: 2290 RVA: 0x00006349 File Offset: 0x00004549
		public unsafe int Wins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsEntry.NativeFieldInfoPtr_Wins);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsEntry.NativeFieldInfoPtr_Wins)) = value;
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x060008F3 RID: 2291 RVA: 0x000398F0 File Offset: 0x00037AF0
		// (set) Token: 0x060008F4 RID: 2292 RVA: 0x00006364 File Offset: 0x00004564
		public unsafe Dictionary<string, int> Sum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsEntry.NativeFieldInfoPtr_Sum);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsEntry.NativeFieldInfoPtr_Sum), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x060008F5 RID: 2293 RVA: 0x00039920 File Offset: 0x00037B20
		// (set) Token: 0x060008F6 RID: 2294 RVA: 0x00006383 File Offset: 0x00004583
		public unsafe Dictionary<string, int> Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsEntry.NativeFieldInfoPtr_Max);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsEntry.NativeFieldInfoPtr_Max), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x060008F7 RID: 2295 RVA: 0x00039950 File Offset: 0x00037B50
		// (set) Token: 0x060008F8 RID: 2296 RVA: 0x000063A2 File Offset: 0x000045A2
		public unsafe Dictionary<string, string> Filters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsEntry.NativeFieldInfoPtr_Filters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsEntry.NativeFieldInfoPtr_Filters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400056D RID: 1389
		private static readonly IntPtr NativeFieldInfoPtr_Matches;

		// Token: 0x0400056E RID: 1390
		private static readonly IntPtr NativeFieldInfoPtr_Wins;

		// Token: 0x0400056F RID: 1391
		private static readonly IntPtr NativeFieldInfoPtr_Sum;

		// Token: 0x04000570 RID: 1392
		private static readonly IntPtr NativeFieldInfoPtr_Max;

		// Token: 0x04000571 RID: 1393
		private static readonly IntPtr NativeFieldInfoPtr_Filters;

		// Token: 0x04000572 RID: 1394
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000573 RID: 1395
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MatchStatsEntry_0;
	}
}
