using System;
using Canis.utils.ids;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using worm.canis.networking;

namespace worm.match.data
{
	// Token: 0x0200018D RID: 397
	public class WormGameResultsPlayerData : GameResultsPlayerData
	{
		// Token: 0x060011C6 RID: 4550 RVA: 0x0004DCB4 File Offset: 0x0004BEB4
		// Note: this type is marked as 'beforefieldinit'.
		static WormGameResultsPlayerData()
		{
			Il2CppClassPointerStore<WormGameResultsPlayerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.data", "WormGameResultsPlayerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormGameResultsPlayerData>.NativeClassPtr);
			WormGameResultsPlayerData.NativeFieldInfoPtr_Rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsPlayerData>.NativeClassPtr, "Rank");
			WormGameResultsPlayerData.NativeFieldInfoPtr_Score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsPlayerData>.NativeClassPtr, "Score");
			WormGameResultsPlayerData.NativeFieldInfoPtr_Spice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsPlayerData>.NativeClassPtr, "Spice");
			WormGameResultsPlayerData.NativeFieldInfoPtr_Water = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsPlayerData>.NativeClassPtr, "Water");
			WormGameResultsPlayerData.NativeFieldInfoPtr_Solari = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsPlayerData>.NativeClassPtr, "Solari");
			WormGameResultsPlayerData.NativeFieldInfoPtr_GarrisonTroops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsPlayerData>.NativeClassPtr, "GarrisonTroops");
			WormGameResultsPlayerData.NativeFieldInfoPtr_LeaderArchID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsPlayerData>.NativeClassPtr, "LeaderArchID");
			WormGameResultsPlayerData.NativeFieldInfoPtr_SkirmishScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsPlayerData>.NativeClassPtr, "SkirmishScore");
			WormGameResultsPlayerData.NativeFieldInfoPtr_ChaumurkyTechTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameResultsPlayerData>.NativeClassPtr, "ChaumurkyTechTile");
			WormGameResultsPlayerData.NativeMethodInfoPtr__ctor_Public_Void_Int32_WormGameResultsEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGameResultsPlayerData>.NativeClassPtr, 100665748);
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x0004DDAC File Offset: 0x0004BFAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 711568, RefRangeEnd = 711569, XrefRangeStart = 711561, XrefRangeEnd = 711568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormGameResultsPlayerData(int rank, WormGameResultsEntry gameResultsEntry)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormGameResultsPlayerData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rank;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameResultsEntry);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGameResultsPlayerData.NativeMethodInfoPtr__ctor_Public_Void_Int32_WormGameResultsEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x0000B45E File Offset: 0x0000965E
		public WormGameResultsPlayerData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x060011C9 RID: 4553 RVA: 0x0004DE08 File Offset: 0x0004C008
		// (set) Token: 0x060011CA RID: 4554 RVA: 0x0000B467 File Offset: 0x00009667
		public unsafe int Rank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsPlayerData.NativeFieldInfoPtr_Rank);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsPlayerData.NativeFieldInfoPtr_Rank)) = value;
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x060011CB RID: 4555 RVA: 0x0004DE30 File Offset: 0x0004C030
		// (set) Token: 0x060011CC RID: 4556 RVA: 0x0000B482 File Offset: 0x00009682
		public unsafe int Score
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsPlayerData.NativeFieldInfoPtr_Score);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsPlayerData.NativeFieldInfoPtr_Score)) = value;
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x060011CD RID: 4557 RVA: 0x0004DE58 File Offset: 0x0004C058
		// (set) Token: 0x060011CE RID: 4558 RVA: 0x0000B49D File Offset: 0x0000969D
		public unsafe int Spice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsPlayerData.NativeFieldInfoPtr_Spice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsPlayerData.NativeFieldInfoPtr_Spice)) = value;
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x060011CF RID: 4559 RVA: 0x0004DE80 File Offset: 0x0004C080
		// (set) Token: 0x060011D0 RID: 4560 RVA: 0x0000B4B8 File Offset: 0x000096B8
		public unsafe int Water
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsPlayerData.NativeFieldInfoPtr_Water);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsPlayerData.NativeFieldInfoPtr_Water)) = value;
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x060011D1 RID: 4561 RVA: 0x0004DEA8 File Offset: 0x0004C0A8
		// (set) Token: 0x060011D2 RID: 4562 RVA: 0x0000B4D3 File Offset: 0x000096D3
		public unsafe int Solari
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsPlayerData.NativeFieldInfoPtr_Solari);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsPlayerData.NativeFieldInfoPtr_Solari)) = value;
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x060011D3 RID: 4563 RVA: 0x0004DED0 File Offset: 0x0004C0D0
		// (set) Token: 0x060011D4 RID: 4564 RVA: 0x0000B4EE File Offset: 0x000096EE
		public unsafe int GarrisonTroops
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsPlayerData.NativeFieldInfoPtr_GarrisonTroops);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsPlayerData.NativeFieldInfoPtr_GarrisonTroops)) = value;
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x060011D5 RID: 4565 RVA: 0x0004DEF8 File Offset: 0x0004C0F8
		// (set) Token: 0x060011D6 RID: 4566 RVA: 0x0000B509 File Offset: 0x00009709
		public unsafe ArchetypeID LeaderArchID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsPlayerData.NativeFieldInfoPtr_LeaderArchID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsPlayerData.NativeFieldInfoPtr_LeaderArchID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x060011D7 RID: 4567 RVA: 0x0004DF28 File Offset: 0x0004C128
		// (set) Token: 0x060011D8 RID: 4568 RVA: 0x0000B528 File Offset: 0x00009728
		public unsafe Dictionary<LocalizableTextVariables, int> SkirmishScore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsPlayerData.NativeFieldInfoPtr_SkirmishScore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<LocalizableTextVariables, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsPlayerData.NativeFieldInfoPtr_SkirmishScore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x060011D9 RID: 4569 RVA: 0x0004DF58 File Offset: 0x0004C158
		// (set) Token: 0x060011DA RID: 4570 RVA: 0x0000B547 File Offset: 0x00009747
		public unsafe bool ChaumurkyTechTile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsPlayerData.NativeFieldInfoPtr_ChaumurkyTechTile);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGameResultsPlayerData.NativeFieldInfoPtr_ChaumurkyTechTile)) = value;
			}
		}

		// Token: 0x04000A43 RID: 2627
		private static readonly IntPtr NativeFieldInfoPtr_Rank;

		// Token: 0x04000A44 RID: 2628
		private static readonly IntPtr NativeFieldInfoPtr_Score;

		// Token: 0x04000A45 RID: 2629
		private static readonly IntPtr NativeFieldInfoPtr_Spice;

		// Token: 0x04000A46 RID: 2630
		private static readonly IntPtr NativeFieldInfoPtr_Water;

		// Token: 0x04000A47 RID: 2631
		private static readonly IntPtr NativeFieldInfoPtr_Solari;

		// Token: 0x04000A48 RID: 2632
		private static readonly IntPtr NativeFieldInfoPtr_GarrisonTroops;

		// Token: 0x04000A49 RID: 2633
		private static readonly IntPtr NativeFieldInfoPtr_LeaderArchID;

		// Token: 0x04000A4A RID: 2634
		private static readonly IntPtr NativeFieldInfoPtr_SkirmishScore;

		// Token: 0x04000A4B RID: 2635
		private static readonly IntPtr NativeFieldInfoPtr_ChaumurkyTechTile;

		// Token: 0x04000A4C RID: 2636
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_WormGameResultsEntry_0;
	}
}
