using System;
using canis.Networking.game.messages;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dbgclient.data
{
	// Token: 0x020000D1 RID: 209
	public class MatchHistoryData : DataComponent
	{
		// Token: 0x060008DE RID: 2270 RVA: 0x00039588 File Offset: 0x00037788
		// Note: this type is marked as 'beforefieldinit'.
		static MatchHistoryData()
		{
			Il2CppClassPointerStore<MatchHistoryData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.data", "MatchHistoryData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchHistoryData>.NativeClassPtr);
			MatchHistoryData.NativeFieldInfoPtr_MatchHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchHistoryData>.NativeClassPtr, "MatchHistory");
			MatchHistoryData.NativeMethodInfoPtr__ctor_Public_Void_MatchHistoryEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchHistoryData>.NativeClassPtr, 100664573);
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x000395E0 File Offset: 0x000377E0
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 495240, RefRangeEnd = 495283, XrefRangeStart = 495240, XrefRangeEnd = 495283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchHistoryData(MatchHistoryEntry matchHistoryEntry)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchHistoryData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matchHistoryEntry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchHistoryData.NativeMethodInfoPtr__ctor_Public_Void_MatchHistoryEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x00006293 File Offset: 0x00004493
		public MatchHistoryData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x060008E1 RID: 2273 RVA: 0x0003962C File Offset: 0x0003782C
		// (set) Token: 0x060008E2 RID: 2274 RVA: 0x0000629C File Offset: 0x0000449C
		public unsafe MatchHistoryEntry MatchHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryData.NativeFieldInfoPtr_MatchHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MatchHistoryEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchHistoryData.NativeFieldInfoPtr_MatchHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000568 RID: 1384
		private static readonly IntPtr NativeFieldInfoPtr_MatchHistory;

		// Token: 0x04000569 RID: 1385
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MatchHistoryEntry_0;
	}
}
