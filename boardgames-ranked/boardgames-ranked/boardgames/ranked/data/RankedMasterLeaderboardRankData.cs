using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace boardgames.ranked.data
{
	// Token: 0x02000033 RID: 51
	public class RankedMasterLeaderboardRankData : DataComponent
	{
		// Token: 0x060001CA RID: 458 RVA: 0x000087F0 File Offset: 0x000069F0
		// Note: this type is marked as 'beforefieldinit'.
		static RankedMasterLeaderboardRankData()
		{
			Il2CppClassPointerStore<RankedMasterLeaderboardRankData>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.data", "RankedMasterLeaderboardRankData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedMasterLeaderboardRankData>.NativeClassPtr);
			RankedMasterLeaderboardRankData.NativeFieldInfoPtr__Rank_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedMasterLeaderboardRankData>.NativeClassPtr, "<Rank>k__BackingField");
			RankedMasterLeaderboardRankData.NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedMasterLeaderboardRankData>.NativeClassPtr, 100663455);
			RankedMasterLeaderboardRankData.NativeMethodInfoPtr_get_Rank_Public_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedMasterLeaderboardRankData>.NativeClassPtr, 100663456);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0000885C File Offset: 0x00006A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225869, XrefRangeEnd = 1225870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankedMasterLeaderboardRankData(Nullable<int> rank)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedMasterLeaderboardRankData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rank));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedMasterLeaderboardRankData.NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001CC RID: 460 RVA: 0x000088AC File Offset: 0x00006AAC
		public unsafe Nullable<int> Rank
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedMasterLeaderboardRankData.NativeMethodInfoPtr_get_Rank_Public_get_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00003071 File Offset: 0x00001271
		public RankedMasterLeaderboardRankData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001CE RID: 462 RVA: 0x000088E4 File Offset: 0x00006AE4
		// (set) Token: 0x060001CF RID: 463 RVA: 0x0000307A File Offset: 0x0000127A
		public Nullable<int> _Rank_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedMasterLeaderboardRankData.NativeFieldInfoPtr__Rank_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedMasterLeaderboardRankData.NativeFieldInfoPtr__Rank_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeFieldInfoPtr__Rank_k__BackingField;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_Int32_0;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeMethodInfoPtr_get_Rank_Public_get_Nullable_1_Int32_0;
	}
}
