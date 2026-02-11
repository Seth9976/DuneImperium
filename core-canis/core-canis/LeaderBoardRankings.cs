using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

// Token: 0x0200001B RID: 27
public class LeaderBoardRankings : NetworkMessageEvent
{
	// Token: 0x060002DF RID: 735 RVA: 0x0001DA00 File Offset: 0x0001BC00
	// Note: this type is marked as 'beforefieldinit'.
	static LeaderBoardRankings()
	{
		Il2CppClassPointerStore<LeaderBoardRankings>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "LeaderBoardRankings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderBoardRankings>.NativeClassPtr);
		LeaderBoardRankings.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderBoardRankings>.NativeClassPtr, "Entries");
		LeaderBoardRankings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderBoardRankings>.NativeClassPtr, 100663674);
	}

	// Token: 0x060002E0 RID: 736 RVA: 0x0001DA58 File Offset: 0x0001BC58
	[CallerCount(114)]
	[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LeaderBoardRankings()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaderBoardRankings>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderBoardRankings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060002E1 RID: 737 RVA: 0x000033D8 File Offset: 0x000015D8
	public LeaderBoardRankings(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170000E9 RID: 233
	// (get) Token: 0x060002E2 RID: 738 RVA: 0x0001DA94 File Offset: 0x0001BC94
	// (set) Token: 0x060002E3 RID: 739 RVA: 0x000033E1 File Offset: 0x000015E1
	public unsafe Dictionary<string, Il2CppReferenceArray<LeaderBoardEntry>> Entries
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderBoardRankings.NativeFieldInfoPtr_Entries);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppReferenceArray<LeaderBoardEntry>>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderBoardRankings.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000211 RID: 529
	private static readonly IntPtr NativeFieldInfoPtr_Entries;

	// Token: 0x04000212 RID: 530
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
