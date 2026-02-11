using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace dbgclient.data
{
	// Token: 0x020000D3 RID: 211
	[Serializable]
	public class MatchEntryList : List<MatchStatsEntry>
	{
		// Token: 0x060008E8 RID: 2280 RVA: 0x000062E3 File Offset: 0x000044E3
		// Note: this type is marked as 'beforefieldinit'.
		static MatchEntryList()
		{
			Il2CppClassPointerStore<MatchEntryList>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.data", "MatchEntryList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchEntryList>.NativeClassPtr);
			MatchEntryList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchEntryList>.NativeClassPtr, 100664575);
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x00039720 File Offset: 0x00037920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504884, XrefRangeEnd = 504890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchEntryList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchEntryList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchEntryList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x0000631C File Offset: 0x0000451C
		public MatchEntryList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400056C RID: 1388
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
