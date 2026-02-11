using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Canis.skirmishScripts
{
	// Token: 0x0200004B RID: 75
	public class SkirmishInfo : NetworkMessageEvent
	{
		// Token: 0x060004A4 RID: 1188 RVA: 0x0002BBEC File Offset: 0x00029DEC
		// Note: this type is marked as 'beforefieldinit'.
		static SkirmishInfo()
		{
			Il2CppClassPointerStore<SkirmishInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.skirmishScripts", "SkirmishInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkirmishInfo>.NativeClassPtr);
			SkirmishInfo.NativeFieldInfoPtr_StartTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishInfo>.NativeClassPtr, "StartTimestamp");
			SkirmishInfo.NativeFieldInfoPtr_EndTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishInfo>.NativeClassPtr, "EndTimestamp");
			SkirmishInfo.NativeFieldInfoPtr_CloseTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishInfo>.NativeClassPtr, "CloseTimestamp");
			SkirmishInfo.NativeFieldInfoPtr_RemainingTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishInfo>.NativeClassPtr, "RemainingTime");
			SkirmishInfo.NativeFieldInfoPtr_RemainingOpenTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishInfo>.NativeClassPtr, "RemainingOpenTime");
			SkirmishInfo.NativeFieldInfoPtr_SeasonStartTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishInfo>.NativeClassPtr, "SeasonStartTimestamp");
			SkirmishInfo.NativeFieldInfoPtr_SeasonEndTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishInfo>.NativeClassPtr, "SeasonEndTimestamp");
			SkirmishInfo.NativeFieldInfoPtr_NextStartTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishInfo>.NativeClassPtr, "NextStartTimestamp");
			SkirmishInfo.NativeFieldInfoPtr_AttemptsMade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishInfo>.NativeClassPtr, "AttemptsMade");
			SkirmishInfo.NativeFieldInfoPtr_MaxAttempts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishInfo>.NativeClassPtr, "MaxAttempts");
			SkirmishInfo.NativeFieldInfoPtr_HasSavedGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishInfo>.NativeClassPtr, "HasSavedGame");
			SkirmishInfo.NativeFieldInfoPtr_SavedGameStartTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishInfo>.NativeClassPtr, "SavedGameStartTimestamp");
			SkirmishInfo.NativeFieldInfoPtr_Season = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishInfo>.NativeClassPtr, "Season");
			SkirmishInfo.NativeFieldInfoPtr_Game = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishInfo>.NativeClassPtr, "Game");
			SkirmishInfo.NativeFieldInfoPtr_Play = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishInfo>.NativeClassPtr, "Play");
			SkirmishInfo.NativeFieldInfoPtr_Open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishInfo>.NativeClassPtr, "Open");
			SkirmishInfo.NativeFieldInfoPtr_GameKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishInfo>.NativeClassPtr, "GameKey");
			SkirmishInfo.NativeFieldInfoPtr_SavedGameKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishInfo>.NativeClassPtr, "SavedGameKey");
			SkirmishInfo.NativeFieldInfoPtr_ScoreMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishInfo>.NativeClassPtr, "ScoreMap");
			SkirmishInfo.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishInfo>.NativeClassPtr, 100664269);
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x0002BDAC File Offset: 0x00029FAC
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkirmishInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkirmishInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishInfo.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00004029 File Offset: 0x00002229
		public SkirmishInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x0002BDE8 File Offset: 0x00029FE8
		// (set) Token: 0x060004A8 RID: 1192 RVA: 0x00004032 File Offset: 0x00002232
		public unsafe long StartTimestamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishInfo.NativeFieldInfoPtr_StartTimestamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishInfo.NativeFieldInfoPtr_StartTimestamp)) = value;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x0002BE10 File Offset: 0x0002A010
		// (set) Token: 0x060004AA RID: 1194 RVA: 0x0000404D File Offset: 0x0000224D
		public unsafe long EndTimestamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishInfo.NativeFieldInfoPtr_EndTimestamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishInfo.NativeFieldInfoPtr_EndTimestamp)) = value;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x0002BE38 File Offset: 0x0002A038
		// (set) Token: 0x060004AC RID: 1196 RVA: 0x00004068 File Offset: 0x00002268
		public unsafe long CloseTimestamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishInfo.NativeFieldInfoPtr_CloseTimestamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishInfo.NativeFieldInfoPtr_CloseTimestamp)) = value;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x0002BE60 File Offset: 0x0002A060
		// (set) Token: 0x060004AE RID: 1198 RVA: 0x00004083 File Offset: 0x00002283
		public unsafe double RemainingTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishInfo.NativeFieldInfoPtr_RemainingTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishInfo.NativeFieldInfoPtr_RemainingTime)) = value;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x0002BE88 File Offset: 0x0002A088
		// (set) Token: 0x060004B0 RID: 1200 RVA: 0x0000409E File Offset: 0x0000229E
		public unsafe double RemainingOpenTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishInfo.NativeFieldInfoPtr_RemainingOpenTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishInfo.NativeFieldInfoPtr_RemainingOpenTime)) = value;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060004B1 RID: 1201 RVA: 0x0002BEB0 File Offset: 0x0002A0B0
		// (set) Token: 0x060004B2 RID: 1202 RVA: 0x000040B9 File Offset: 0x000022B9
		public unsafe long SeasonStartTimestamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishInfo.NativeFieldInfoPtr_SeasonStartTimestamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishInfo.NativeFieldInfoPtr_SeasonStartTimestamp)) = value;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x0002BED8 File Offset: 0x0002A0D8
		// (set) Token: 0x060004B4 RID: 1204 RVA: 0x000040D4 File Offset: 0x000022D4
		public unsafe long SeasonEndTimestamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishInfo.NativeFieldInfoPtr_SeasonEndTimestamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishInfo.NativeFieldInfoPtr_SeasonEndTimestamp)) = value;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060004B5 RID: 1205 RVA: 0x0002BF00 File Offset: 0x0002A100
		// (set) Token: 0x060004B6 RID: 1206 RVA: 0x000040EF File Offset: 0x000022EF
		public unsafe long NextStartTimestamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishInfo.NativeFieldInfoPtr_NextStartTimestamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishInfo.NativeFieldInfoPtr_NextStartTimestamp)) = value;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x0002BF28 File Offset: 0x0002A128
		// (set) Token: 0x060004B8 RID: 1208 RVA: 0x0000410A File Offset: 0x0000230A
		public unsafe int AttemptsMade
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishInfo.NativeFieldInfoPtr_AttemptsMade);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishInfo.NativeFieldInfoPtr_AttemptsMade)) = value;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x0002BF50 File Offset: 0x0002A150
		// (set) Token: 0x060004BA RID: 1210 RVA: 0x00004125 File Offset: 0x00002325
		public unsafe int MaxAttempts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishInfo.NativeFieldInfoPtr_MaxAttempts);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishInfo.NativeFieldInfoPtr_MaxAttempts)) = value;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x0002BF78 File Offset: 0x0002A178
		// (set) Token: 0x060004BC RID: 1212 RVA: 0x00004140 File Offset: 0x00002340
		public unsafe bool HasSavedGame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishInfo.NativeFieldInfoPtr_HasSavedGame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishInfo.NativeFieldInfoPtr_HasSavedGame)) = value;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x0002BFA0 File Offset: 0x0002A1A0
		// (set) Token: 0x060004BE RID: 1214 RVA: 0x0000415B File Offset: 0x0000235B
		public unsafe long SavedGameStartTimestamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishInfo.NativeFieldInfoPtr_SavedGameStartTimestamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishInfo.NativeFieldInfoPtr_SavedGameStartTimestamp)) = value;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x0002BFC8 File Offset: 0x0002A1C8
		// (set) Token: 0x060004C0 RID: 1216 RVA: 0x00004176 File Offset: 0x00002376
		public unsafe int Season
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishInfo.NativeFieldInfoPtr_Season);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishInfo.NativeFieldInfoPtr_Season)) = value;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x0002BFF0 File Offset: 0x0002A1F0
		// (set) Token: 0x060004C2 RID: 1218 RVA: 0x00004191 File Offset: 0x00002391
		public unsafe int Game
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishInfo.NativeFieldInfoPtr_Game);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishInfo.NativeFieldInfoPtr_Game)) = value;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x0002C018 File Offset: 0x0002A218
		// (set) Token: 0x060004C4 RID: 1220 RVA: 0x000041AC File Offset: 0x000023AC
		public unsafe bool Play
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishInfo.NativeFieldInfoPtr_Play);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishInfo.NativeFieldInfoPtr_Play)) = value;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x0002C040 File Offset: 0x0002A240
		// (set) Token: 0x060004C6 RID: 1222 RVA: 0x000041C7 File Offset: 0x000023C7
		public unsafe bool Open
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishInfo.NativeFieldInfoPtr_Open);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishInfo.NativeFieldInfoPtr_Open)) = value;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x0002C068 File Offset: 0x0002A268
		// (set) Token: 0x060004C8 RID: 1224 RVA: 0x000041E2 File Offset: 0x000023E2
		public unsafe int GameKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishInfo.NativeFieldInfoPtr_GameKey);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishInfo.NativeFieldInfoPtr_GameKey)) = value;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060004C9 RID: 1225 RVA: 0x0002C090 File Offset: 0x0002A290
		// (set) Token: 0x060004CA RID: 1226 RVA: 0x000041FD File Offset: 0x000023FD
		public unsafe int SavedGameKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishInfo.NativeFieldInfoPtr_SavedGameKey);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishInfo.NativeFieldInfoPtr_SavedGameKey)) = value;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060004CB RID: 1227 RVA: 0x0002C0B8 File Offset: 0x0002A2B8
		// (set) Token: 0x060004CC RID: 1228 RVA: 0x00004218 File Offset: 0x00002418
		public unsafe Dictionary<string, int> ScoreMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishInfo.NativeFieldInfoPtr_ScoreMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishInfo.NativeFieldInfoPtr_ScoreMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002FE RID: 766
		private static readonly IntPtr NativeFieldInfoPtr_StartTimestamp;

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeFieldInfoPtr_EndTimestamp;

		// Token: 0x04000300 RID: 768
		private static readonly IntPtr NativeFieldInfoPtr_CloseTimestamp;

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeFieldInfoPtr_RemainingTime;

		// Token: 0x04000302 RID: 770
		private static readonly IntPtr NativeFieldInfoPtr_RemainingOpenTime;

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeFieldInfoPtr_SeasonStartTimestamp;

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeFieldInfoPtr_SeasonEndTimestamp;

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeFieldInfoPtr_NextStartTimestamp;

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeFieldInfoPtr_AttemptsMade;

		// Token: 0x04000307 RID: 775
		private static readonly IntPtr NativeFieldInfoPtr_MaxAttempts;

		// Token: 0x04000308 RID: 776
		private static readonly IntPtr NativeFieldInfoPtr_HasSavedGame;

		// Token: 0x04000309 RID: 777
		private static readonly IntPtr NativeFieldInfoPtr_SavedGameStartTimestamp;

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeFieldInfoPtr_Season;

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeFieldInfoPtr_Game;

		// Token: 0x0400030C RID: 780
		private static readonly IntPtr NativeFieldInfoPtr_Play;

		// Token: 0x0400030D RID: 781
		private static readonly IntPtr NativeFieldInfoPtr_Open;

		// Token: 0x0400030E RID: 782
		private static readonly IntPtr NativeFieldInfoPtr_GameKey;

		// Token: 0x0400030F RID: 783
		private static readonly IntPtr NativeFieldInfoPtr_SavedGameKey;

		// Token: 0x04000310 RID: 784
		private static readonly IntPtr NativeFieldInfoPtr_ScoreMap;

		// Token: 0x04000311 RID: 785
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
