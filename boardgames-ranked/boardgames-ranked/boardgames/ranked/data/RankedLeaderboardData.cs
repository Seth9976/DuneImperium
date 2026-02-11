using System;
using boardgames.ranked.networking.responses;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace boardgames.ranked.data
{
	// Token: 0x02000031 RID: 49
	public class RankedLeaderboardData : DataComponent
	{
		// Token: 0x060001BE RID: 446 RVA: 0x000085A0 File Offset: 0x000067A0
		// Note: this type is marked as 'beforefieldinit'.
		static RankedLeaderboardData()
		{
			Il2CppClassPointerStore<RankedLeaderboardData>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.data", "RankedLeaderboardData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedLeaderboardData>.NativeClassPtr);
			RankedLeaderboardData.NativeFieldInfoPtr__Entries_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedLeaderboardData>.NativeClassPtr, "<Entries>k__BackingField");
			RankedLeaderboardData.NativeMethodInfoPtr__ctor_Public_Void_IReadOnlyList_1_RankedLeaderboardEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedLeaderboardData>.NativeClassPtr, 100663451);
			RankedLeaderboardData.NativeMethodInfoPtr_get_Entries_Public_get_IReadOnlyList_1_RankedLeaderboardEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedLeaderboardData>.NativeClassPtr, 100663452);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000860C File Offset: 0x0000680C
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 495240, RefRangeEnd = 495283, XrefRangeStart = 495240, XrefRangeEnd = 495283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankedLeaderboardData(IReadOnlyList<RankedLeaderboardEntry> entries)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedLeaderboardData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entries);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedLeaderboardData.NativeMethodInfoPtr__ctor_Public_Void_IReadOnlyList_1_RankedLeaderboardEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x00008658 File Offset: 0x00006858
		public unsafe IReadOnlyList<RankedLeaderboardEntry> Entries
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedLeaderboardData.NativeMethodInfoPtr_get_Entries_Public_get_IReadOnlyList_1_RankedLeaderboardEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<RankedLeaderboardEntry>>(intPtr3) : null;
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00003021 File Offset: 0x00001221
		public RankedLeaderboardData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x00008698 File Offset: 0x00006898
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x0000302A File Offset: 0x0000122A
		public unsafe IReadOnlyList<RankedLeaderboardEntry> _Entries_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedLeaderboardData.NativeFieldInfoPtr__Entries_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<RankedLeaderboardEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedLeaderboardData.NativeFieldInfoPtr__Entries_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeFieldInfoPtr__Entries_k__BackingField;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IReadOnlyList_1_RankedLeaderboardEntry_0;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeMethodInfoPtr_get_Entries_Public_get_IReadOnlyList_1_RankedLeaderboardEntry_0;
	}
}
