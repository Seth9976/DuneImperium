using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dbgclient.data
{
	// Token: 0x020000D2 RID: 210
	[Serializable]
	public class MatchStats : Object
	{
		// Token: 0x060008E3 RID: 2275 RVA: 0x0003965C File Offset: 0x0003785C
		// Note: this type is marked as 'beforefieldinit'.
		static MatchStats()
		{
			Il2CppClassPointerStore<MatchStats>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.data", "MatchStats");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchStats>.NativeClassPtr);
			MatchStats.NativeFieldInfoPtr_Stats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStats>.NativeClassPtr, "Stats");
			MatchStats.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStats>.NativeClassPtr, 100664574);
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x000396B4 File Offset: 0x000378B4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchStats()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchStats>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStats.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x000062BB File Offset: 0x000044BB
		public MatchStats(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x060008E6 RID: 2278 RVA: 0x000396F0 File Offset: 0x000378F0
		// (set) Token: 0x060008E7 RID: 2279 RVA: 0x000062C4 File Offset: 0x000044C4
		public unsafe Dictionary<string, MatchEntryList> Stats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStats.NativeFieldInfoPtr_Stats);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, MatchEntryList>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStats.NativeFieldInfoPtr_Stats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400056A RID: 1386
		private static readonly IntPtr NativeFieldInfoPtr_Stats;

		// Token: 0x0400056B RID: 1387
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
