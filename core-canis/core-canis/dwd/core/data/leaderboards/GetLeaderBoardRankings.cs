using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.data.leaderboards
{
	// Token: 0x020001D3 RID: 467
	public class GetLeaderBoardRankings : Object
	{
		// Token: 0x060019D2 RID: 6610 RVA: 0x0007AAD4 File Offset: 0x00078CD4
		// Note: this type is marked as 'beforefieldinit'.
		static GetLeaderBoardRankings()
		{
			Il2CppClassPointerStore<GetLeaderBoardRankings>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.data.leaderboards", "GetLeaderBoardRankings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetLeaderBoardRankings>.NativeClassPtr);
			GetLeaderBoardRankings.NativeFieldInfoPtr_BoardNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetLeaderBoardRankings>.NativeClassPtr, "BoardNames");
			GetLeaderBoardRankings.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetLeaderBoardRankings>.NativeClassPtr, "Count");
			GetLeaderBoardRankings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetLeaderBoardRankings>.NativeClassPtr, 100667398);
		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x0007AB40 File Offset: 0x00078D40
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetLeaderBoardRankings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetLeaderBoardRankings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetLeaderBoardRankings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019D4 RID: 6612 RVA: 0x0000B414 File Offset: 0x00009614
		public GetLeaderBoardRankings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x060019D5 RID: 6613 RVA: 0x0007AB7C File Offset: 0x00078D7C
		// (set) Token: 0x060019D6 RID: 6614 RVA: 0x0000B41D File Offset: 0x0000961D
		public unsafe List<string> BoardNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetLeaderBoardRankings.NativeFieldInfoPtr_BoardNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetLeaderBoardRankings.NativeFieldInfoPtr_BoardNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x060019D7 RID: 6615 RVA: 0x0007ABAC File Offset: 0x00078DAC
		// (set) Token: 0x060019D8 RID: 6616 RVA: 0x0000B43C File Offset: 0x0000963C
		public unsafe int Count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetLeaderBoardRankings.NativeFieldInfoPtr_Count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetLeaderBoardRankings.NativeFieldInfoPtr_Count)) = value;
			}
		}

		// Token: 0x04001223 RID: 4643
		private static readonly IntPtr NativeFieldInfoPtr_BoardNames;

		// Token: 0x04001224 RID: 4644
		private static readonly IntPtr NativeFieldInfoPtr_Count;

		// Token: 0x04001225 RID: 4645
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
