using System;
using Canis;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using worm.canis.data.enums;

namespace worm.canis.match
{
	// Token: 0x02000018 RID: 24
	[Serializable]
	public class WormMatchInitData : MatchInitData
	{
		// Token: 0x060001BD RID: 445 RVA: 0x0006FE84 File Offset: 0x0006E084
		// Note: this type is marked as 'beforefieldinit'.
		static WormMatchInitData()
		{
			Il2CppClassPointerStore<WormMatchInitData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.match", "WormMatchInitData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormMatchInitData>.NativeClassPtr);
			WormMatchInitData.NativeFieldInfoPtr_ScenarioName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchInitData>.NativeClassPtr, "ScenarioName");
			WormMatchInitData.NativeFieldInfoPtr_forceGameOver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchInitData>.NativeClassPtr, "forceGameOver");
			WormMatchInitData.NativeFieldInfoPtr_wormPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchInitData>.NativeClassPtr, "wormPlayers");
			WormMatchInitData.NativeFieldInfoPtr_GamesToWin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchInitData>.NativeClassPtr, "GamesToWin");
			WormMatchInitData.NativeFieldInfoPtr_EndgameTriggerScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchInitData>.NativeClassPtr, "EndgameTriggerScore");
			WormMatchInitData.NativeFieldInfoPtr_ReserveDeck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchInitData>.NativeClassPtr, "ReserveDeck");
			WormMatchInitData.NativeFieldInfoPtr_LeaderAssignmentMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchInitData>.NativeClassPtr, "LeaderAssignmentMode");
			WormMatchInitData.NativeFieldInfoPtr_RuleModAbilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchInitData>.NativeClassPtr, "RuleModAbilities");
			WormMatchInitData.NativeFieldInfoPtr_Sets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchInitData>.NativeClassPtr, "Sets");
			WormMatchInitData.NativeFieldInfoPtr_GoTo11Gamemode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchInitData>.NativeClassPtr, "GoTo11Gamemode");
			WormMatchInitData.NativeFieldInfoPtr_EventID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchInitData>.NativeClassPtr, "EventID");
			WormMatchInitData.NativeFieldInfoPtr_RoundID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchInitData>.NativeClassPtr, "RoundID");
			WormMatchInitData.NativeFieldInfoPtr_MatchSoloOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchInitData>.NativeClassPtr, "MatchSoloOptions");
			WormMatchInitData.NativeFieldInfoPtr_DraftDecks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatchInitData>.NativeClassPtr, "DraftDecks");
			WormMatchInitData.NativeMethodInfoPtr_get_players_Public_Virtual_get_List_1_PlayerMatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatchInitData>.NativeClassPtr, 100663783);
			WormMatchInitData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatchInitData>.NativeClassPtr, 100663784);
			WormMatchInitData.NativeMethodInfoPtr__ctor_Public_Void_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatchInitData>.NativeClassPtr, 100663785);
			WormMatchInitData.NativeMethodInfoPtr__ctor_Public_Void_WormMatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatchInitData>.NativeClassPtr, 100663786);
			WormMatchInitData.NativeMethodInfoPtr_Clone_Public_Virtual_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatchInitData>.NativeClassPtr, 100663787);
			WormMatchInitData.NativeMethodInfoPtr_AddPlayer_Public_Virtual_Void_PlayerMatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatchInitData>.NativeClassPtr, 100663788);
			WormMatchInitData.NativeMethodInfoPtr_AddEmptyPlayer_Public_Virtual_PlayerMatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatchInitData>.NativeClassPtr, 100663789);
			WormMatchInitData.NativeMethodInfoPtr_RemovePlayer_Public_Virtual_Void_PlayerMatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatchInitData>.NativeClassPtr, 100663790);
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001BE RID: 446 RVA: 0x0007006C File Offset: 0x0006E26C
		public unsafe override List<PlayerMatchInitData> players
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31661, XrefRangeEnd = 31667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatchInitData.NativeMethodInfoPtr_get_players_Public_Virtual_get_List_1_PlayerMatchInitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<PlayerMatchInitData>>(intPtr3) : null;
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000700B8 File Offset: 0x0006E2B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31667, XrefRangeEnd = 31688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormMatchInitData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormMatchInitData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatchInitData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x000700F4 File Offset: 0x0006E2F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31688, XrefRangeEnd = 31709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormMatchInitData(GameID gID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormMatchInitData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatchInitData.NativeMethodInfoPtr__ctor_Public_Void_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00070140 File Offset: 0x0006E340
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 31768, RefRangeEnd = 31769, XrefRangeStart = 31709, XrefRangeEnd = 31768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormMatchInitData(WormMatchInitData other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormMatchInitData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatchInitData.NativeMethodInfoPtr__ctor_Public_Void_WormMatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0007018C File Offset: 0x0006E38C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31769, XrefRangeEnd = 31773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MatchInitData Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatchInitData.NativeMethodInfoPtr_Clone_Public_Virtual_MatchInitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MatchInitData>(intPtr3) : null;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000701D8 File Offset: 0x0006E3D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31773, XrefRangeEnd = 31783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AddPlayer(PlayerMatchInitData p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatchInitData.NativeMethodInfoPtr_AddPlayer_Public_Virtual_Void_PlayerMatchInitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00070228 File Offset: 0x0006E428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31783, XrefRangeEnd = 31790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override PlayerMatchInitData AddEmptyPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatchInitData.NativeMethodInfoPtr_AddEmptyPlayer_Public_Virtual_PlayerMatchInitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerMatchInitData>(intPtr3) : null;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00070274 File Offset: 0x0006E474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31790, XrefRangeEnd = 31796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RemovePlayer(PlayerMatchInitData p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatchInitData.NativeMethodInfoPtr_RemovePlayer_Public_Virtual_Void_PlayerMatchInitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00002C9D File Offset: 0x00000E9D
		public WormMatchInitData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x000702C4 File Offset: 0x0006E4C4
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x00002CA6 File Offset: 0x00000EA6
		public unsafe string ScenarioName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchInitData.NativeFieldInfoPtr_ScenarioName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchInitData.NativeFieldInfoPtr_ScenarioName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x000702EC File Offset: 0x0006E4EC
		// (set) Token: 0x060001CA RID: 458 RVA: 0x00002CC5 File Offset: 0x00000EC5
		public unsafe bool forceGameOver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchInitData.NativeFieldInfoPtr_forceGameOver);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchInitData.NativeFieldInfoPtr_forceGameOver)) = value;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001CB RID: 459 RVA: 0x00070314 File Offset: 0x0006E514
		// (set) Token: 0x060001CC RID: 460 RVA: 0x00002CE0 File Offset: 0x00000EE0
		public unsafe List<WormPlayerMatchInitData> wormPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchInitData.NativeFieldInfoPtr_wormPlayers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormPlayerMatchInitData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchInitData.NativeFieldInfoPtr_wormPlayers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001CD RID: 461 RVA: 0x00070344 File Offset: 0x0006E544
		// (set) Token: 0x060001CE RID: 462 RVA: 0x00002CFF File Offset: 0x00000EFF
		public unsafe int GamesToWin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchInitData.NativeFieldInfoPtr_GamesToWin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchInitData.NativeFieldInfoPtr_GamesToWin)) = value;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001CF RID: 463 RVA: 0x0007036C File Offset: 0x0006E56C
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x00002D1A File Offset: 0x00000F1A
		public unsafe int EndgameTriggerScore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchInitData.NativeFieldInfoPtr_EndgameTriggerScore);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchInitData.NativeFieldInfoPtr_EndgameTriggerScore)) = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x00070394 File Offset: 0x0006E594
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x00002D35 File Offset: 0x00000F35
		public unsafe List<ArchetypeID> ReserveDeck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchInitData.NativeFieldInfoPtr_ReserveDeck);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchInitData.NativeFieldInfoPtr_ReserveDeck), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x000703C4 File Offset: 0x0006E5C4
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x00002D54 File Offset: 0x00000F54
		public unsafe LeaderAssignmentMode LeaderAssignmentMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchInitData.NativeFieldInfoPtr_LeaderAssignmentMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchInitData.NativeFieldInfoPtr_LeaderAssignmentMode)) = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x000703EC File Offset: 0x0006E5EC
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x00002D6F File Offset: 0x00000F6F
		public unsafe List<AbilityID> RuleModAbilities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchInitData.NativeFieldInfoPtr_RuleModAbilities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AbilityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchInitData.NativeFieldInfoPtr_RuleModAbilities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x0007041C File Offset: 0x0006E61C
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x00002D8E File Offset: 0x00000F8E
		public unsafe List<Set> Sets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchInitData.NativeFieldInfoPtr_Sets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Set>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchInitData.NativeFieldInfoPtr_Sets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x0007044C File Offset: 0x0006E64C
		// (set) Token: 0x060001DA RID: 474 RVA: 0x00002DAD File Offset: 0x00000FAD
		public unsafe bool GoTo11Gamemode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchInitData.NativeFieldInfoPtr_GoTo11Gamemode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchInitData.NativeFieldInfoPtr_GoTo11Gamemode)) = value;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001DB RID: 475 RVA: 0x00070474 File Offset: 0x0006E674
		// (set) Token: 0x060001DC RID: 476 RVA: 0x00002DC8 File Offset: 0x00000FC8
		public unsafe EventID EventID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchInitData.NativeFieldInfoPtr_EventID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchInitData.NativeFieldInfoPtr_EventID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001DD RID: 477 RVA: 0x000704A4 File Offset: 0x0006E6A4
		// (set) Token: 0x060001DE RID: 478 RVA: 0x00002DE7 File Offset: 0x00000FE7
		public unsafe RoundID RoundID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchInitData.NativeFieldInfoPtr_RoundID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoundID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchInitData.NativeFieldInfoPtr_RoundID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001DF RID: 479 RVA: 0x000704D4 File Offset: 0x0006E6D4
		// (set) Token: 0x060001E0 RID: 480 RVA: 0x00002E06 File Offset: 0x00001006
		public unsafe WormMatchSoloOptions MatchSoloOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchInitData.NativeFieldInfoPtr_MatchSoloOptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatchSoloOptions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchInitData.NativeFieldInfoPtr_MatchSoloOptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x00070504 File Offset: 0x0006E704
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x00002E25 File Offset: 0x00001025
		public unsafe bool DraftDecks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchInitData.NativeFieldInfoPtr_DraftDecks);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatchInitData.NativeFieldInfoPtr_DraftDecks)) = value;
			}
		}

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeFieldInfoPtr_ScenarioName;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeFieldInfoPtr_forceGameOver;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeFieldInfoPtr_wormPlayers;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeFieldInfoPtr_GamesToWin;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeFieldInfoPtr_EndgameTriggerScore;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeFieldInfoPtr_ReserveDeck;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeFieldInfoPtr_LeaderAssignmentMode;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeFieldInfoPtr_RuleModAbilities;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeFieldInfoPtr_Sets;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeFieldInfoPtr_GoTo11Gamemode;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeFieldInfoPtr_EventID;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeFieldInfoPtr_RoundID;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeFieldInfoPtr_MatchSoloOptions;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeFieldInfoPtr_DraftDecks;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr_get_players_Public_Virtual_get_List_1_PlayerMatchInitData_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameID_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatchInitData_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_MatchInitData_0;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr_AddPlayer_Public_Virtual_Void_PlayerMatchInitData_0;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr_AddEmptyPlayer_Public_Virtual_PlayerMatchInitData_0;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr_RemovePlayer_Public_Virtual_Void_PlayerMatchInitData_0;
	}
}
