using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.data
{
	// Token: 0x02000143 RID: 323
	public class LeaderboardScoreData : DataComponent
	{
		// Token: 0x06001097 RID: 4247 RVA: 0x000440F8 File Offset: 0x000422F8
		// Note: this type is marked as 'beforefieldinit'.
		static LeaderboardScoreData()
		{
			Il2CppClassPointerStore<LeaderboardScoreData>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.data", "LeaderboardScoreData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderboardScoreData>.NativeClassPtr);
			LeaderboardScoreData.NativeFieldInfoPtr_Rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardScoreData>.NativeClassPtr, "Rank");
			LeaderboardScoreData.NativeFieldInfoPtr_Points = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardScoreData>.NativeClassPtr, "Points");
			LeaderboardScoreData.NativeFieldInfoPtr_IsLocalPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardScoreData>.NativeClassPtr, "IsLocalPlayer");
			LeaderboardScoreData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardScoreData>.NativeClassPtr, 100665725);
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x00044178 File Offset: 0x00042378
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 999404, RefRangeEnd = 999405, XrefRangeStart = 999403, XrefRangeEnd = 999404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LeaderboardScoreData(int rank, int points, bool isLocalPlayer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaderboardScoreData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rank;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref points;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isLocalPlayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaderboardScoreData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x00009B0B File Offset: 0x00007D0B
		public LeaderboardScoreData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x0600109A RID: 4250 RVA: 0x000441DC File Offset: 0x000423DC
		// (set) Token: 0x0600109B RID: 4251 RVA: 0x00009B14 File Offset: 0x00007D14
		public unsafe int Rank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardScoreData.NativeFieldInfoPtr_Rank);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardScoreData.NativeFieldInfoPtr_Rank)) = value;
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x0600109C RID: 4252 RVA: 0x00044204 File Offset: 0x00042404
		// (set) Token: 0x0600109D RID: 4253 RVA: 0x00009B2F File Offset: 0x00007D2F
		public unsafe int Points
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardScoreData.NativeFieldInfoPtr_Points);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardScoreData.NativeFieldInfoPtr_Points)) = value;
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x0600109E RID: 4254 RVA: 0x0004422C File Offset: 0x0004242C
		// (set) Token: 0x0600109F RID: 4255 RVA: 0x00009B4A File Offset: 0x00007D4A
		public unsafe bool IsLocalPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardScoreData.NativeFieldInfoPtr_IsLocalPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaderboardScoreData.NativeFieldInfoPtr_IsLocalPlayer)) = value;
			}
		}

		// Token: 0x04000A1E RID: 2590
		private static readonly IntPtr NativeFieldInfoPtr_Rank;

		// Token: 0x04000A1F RID: 2591
		private static readonly IntPtr NativeFieldInfoPtr_Points;

		// Token: 0x04000A20 RID: 2592
		private static readonly IntPtr NativeFieldInfoPtr_IsLocalPlayer;

		// Token: 0x04000A21 RID: 2593
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_0;
	}
}
