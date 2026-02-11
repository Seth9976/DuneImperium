using System;
using Canis;
using Canis.actions;
using Canis.context;
using Canis.entities;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.abilities;
using worm.canis.abilities.ActivatedAbilities;
using worm.canis.abilities.PlayAbilities;
using worm.canis.data.enums;

namespace worm.canis.entities
{
	// Token: 0x02000033 RID: 51
	public class WormPlaymat : WormEntity
	{
		// Token: 0x06000461 RID: 1121 RVA: 0x0007B4B4 File Offset: 0x000796B4
		// Note: this type is marked as 'beforefieldinit'.
		static WormPlaymat()
		{
			Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.entities", "WormPlaymat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr);
			WormPlaymat.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, "match");
			WormPlaymat.NativeFieldInfoPtr_LogStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, "LogStack");
			WormPlaymat.NativeFieldInfoPtr_UndoStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, "UndoStack");
			WormPlaymat.NativeFieldInfoPtr_Undo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, "Undo");
			WormPlaymat.NativeFieldInfoPtr_abilitiesContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, "abilitiesContainer");
			WormPlaymat.NativeFieldInfoPtr__ActiveAbilityStack_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, "<ActiveAbilityStack>k__BackingField");
			WormPlaymat.NativeFieldInfoPtr__Board_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, "<Board>k__BackingField");
			WormPlaymat.NativeFieldInfoPtr__IntrigueDeck_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, "<IntrigueDeck>k__BackingField");
			WormPlaymat.NativeFieldInfoPtr__IntrigueDiscard_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, "<IntrigueDiscard>k__BackingField");
			WormPlaymat.NativeFieldInfoPtr__ImperiumDeck_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, "<ImperiumDeck>k__BackingField");
			WormPlaymat.NativeFieldInfoPtr__ImperiumRow_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, "<ImperiumRow>k__BackingField");
			WormPlaymat.NativeFieldInfoPtr__HelenaReserve_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, "<HelenaReserve>k__BackingField");
			WormPlaymat.NativeFieldInfoPtr__ReserveRow_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, "<ReserveRow>k__BackingField");
			WormPlaymat.NativeFieldInfoPtr__Trash_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, "<Trash>k__BackingField");
			WormPlaymat.NativeFieldInfoPtr__Box_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, "<Box>k__BackingField");
			WormPlaymat.NativeFieldInfoPtr__HagalDeck_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, "<HagalDeck>k__BackingField");
			WormPlaymat.NativeFieldInfoPtr__HagalDiscard_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, "<HagalDiscard>k__BackingField");
			WormPlaymat.NativeFieldInfoPtr__TleilaxuDeck_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, "<TleilaxuDeck>k__BackingField");
			WormPlaymat.NativeFieldInfoPtr__TleilaxuRow_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, "<TleilaxuRow>k__BackingField");
			WormPlaymat.NativeMethodInfoPtr_get_ActiveAbilityStack_Public_get_WormEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664408);
			WormPlaymat.NativeMethodInfoPtr_set_ActiveAbilityStack_Public_set_Void_WormEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664409);
			WormPlaymat.NativeMethodInfoPtr_get_Board_Public_get_WormBoard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664410);
			WormPlaymat.NativeMethodInfoPtr_set_Board_Public_set_Void_WormBoard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664411);
			WormPlaymat.NativeMethodInfoPtr_get_IntrigueDeck_Public_get_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664412);
			WormPlaymat.NativeMethodInfoPtr_set_IntrigueDeck_Public_set_Void_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664413);
			WormPlaymat.NativeMethodInfoPtr_get_IntrigueDiscard_Public_get_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664414);
			WormPlaymat.NativeMethodInfoPtr_set_IntrigueDiscard_Public_set_Void_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664415);
			WormPlaymat.NativeMethodInfoPtr_get_ImperiumDeck_Public_get_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664416);
			WormPlaymat.NativeMethodInfoPtr_set_ImperiumDeck_Public_set_Void_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664417);
			WormPlaymat.NativeMethodInfoPtr_get_ImperiumRow_Public_get_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664418);
			WormPlaymat.NativeMethodInfoPtr_set_ImperiumRow_Public_set_Void_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664419);
			WormPlaymat.NativeMethodInfoPtr_get_HelenaReserve_Public_get_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664420);
			WormPlaymat.NativeMethodInfoPtr_set_HelenaReserve_Public_set_Void_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664421);
			WormPlaymat.NativeMethodInfoPtr_get_ReserveRow_Public_get_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664422);
			WormPlaymat.NativeMethodInfoPtr_set_ReserveRow_Public_set_Void_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664423);
			WormPlaymat.NativeMethodInfoPtr_get_Trash_Public_get_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664424);
			WormPlaymat.NativeMethodInfoPtr_set_Trash_Public_set_Void_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664425);
			WormPlaymat.NativeMethodInfoPtr_get_Box_Public_get_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664426);
			WormPlaymat.NativeMethodInfoPtr_set_Box_Public_set_Void_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664427);
			WormPlaymat.NativeMethodInfoPtr_get_HagalDeck_Public_get_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664428);
			WormPlaymat.NativeMethodInfoPtr_set_HagalDeck_Public_set_Void_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664429);
			WormPlaymat.NativeMethodInfoPtr_get_HagalDiscard_Public_get_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664430);
			WormPlaymat.NativeMethodInfoPtr_set_HagalDiscard_Public_set_Void_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664431);
			WormPlaymat.NativeMethodInfoPtr_get_TleilaxuDeck_Public_get_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664432);
			WormPlaymat.NativeMethodInfoPtr_set_TleilaxuDeck_Public_set_Void_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664433);
			WormPlaymat.NativeMethodInfoPtr_get_TleilaxuRow_Public_get_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664434);
			WormPlaymat.NativeMethodInfoPtr_set_TleilaxuRow_Public_set_Void_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664435);
			WormPlaymat.NativeMethodInfoPtr__ctor_Public_Void_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664436);
			WormPlaymat.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664437);
			WormPlaymat.NativeMethodInfoPtr_get_BaseAbilities_Public_Virtual_Final_New_get_IEnumerable_1_AbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664438);
			WormPlaymat.NativeMethodInfoPtr_get_AbilitiesContainer_Public_Virtual_Final_New_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664439);
			WormPlaymat.NativeMethodInfoPtr_get_Abilities_Public_Virtual_Final_New_get_IEnumerable_1_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664440);
			WormPlaymat.NativeMethodInfoPtr_InitializeAttrs_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664441);
			WormPlaymat.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664442);
			WormPlaymat.NativeMethodInfoPtr_SetSerializedChildAbilities_Public_Virtual_Final_New_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664443);
			WormPlaymat.NativeMethodInfoPtr_SetSerializedChildAbilities_Public_Void_WormEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664444);
			WormPlaymat.NativeMethodInfoPtr_AddChildAbility_Public_Virtual_Final_New_IEnumerable_1_Action_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664445);
			WormPlaymat.NativeMethodInfoPtr_CurrentRound_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664446);
			WormPlaymat.NativeMethodInfoPtr_CurrentPhase_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664447);
			WormPlaymat.NativeMethodInfoPtr_SetCurrentPhase_Public_Action_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664448);
			WormPlaymat.NativeMethodInfoPtr_GetUsablePrePlayerTurnAbilities_Public_IEnumerable_1_AbilityDefinitionForGame_1_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664449);
			WormPlaymat.NativeMethodInfoPtr_GetAllDeferredAbilities_Public_IEnumerable_1_AbilityDefinitionForGame_1_WormMatch_WormPlayer_PlayerTurnTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664450);
			WormPlaymat.NativeMethodInfoPtr_GetUsableDeferredAbilities_Public_IEnumerable_1_AbilityDefinitionForGame_1_WormMatch_WormPlayer_PlayerTurnTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664451);
			WormPlaymat.NativeMethodInfoPtr_GetUsableUnloadAbilities_Public_IEnumerable_1_AbilityDefinitionForGame_1_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664452);
			WormPlaymat.NativeMethodInfoPtr_GetHagalAbilities_Public_IEnumerable_1_AbilityDefinitionForGame_1_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664453);
			WormPlaymat.NativeMethodInfoPtr_GetCustomTimingAbilities_Private_IEnumerable_1_AbilityDefinitionForGame_1_WormMatch_WormPlayer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664454);
			WormPlaymat.NativeMethodInfoPtr_GetUsableDelayedAbilities_Public_IEnumerable_1_DeferredAbility_WormPlayer_PlayerTurnTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664455);
			WormPlaymat.NativeMethodInfoPtr_GetUsableIntrigueAbilities_Public_IEnumerable_1_PlayAbility_WormPlayer_IntrigueTypes_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664456);
			WormPlaymat.NativeMethodInfoPtr_IsDoneWithActiveAgentArea_Public_Boolean_WormPlayer_PlayerTurnTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664457);
			WormPlaymat.NativeMethodInfoPtr_UpdateConditionaEndgameVP_Public_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, 100664458);
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x0007BA5C File Offset: 0x00079C5C
		// (set) Token: 0x06000463 RID: 1123 RVA: 0x0007BA9C File Offset: 0x00079C9C
		public unsafe WormEntity ActiveAbilityStack
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_get_ActiveAbilityStack_Public_get_WormEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormEntity>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_set_ActiveAbilityStack_Public_set_Void_WormEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x0007BAE0 File Offset: 0x00079CE0
		// (set) Token: 0x06000465 RID: 1125 RVA: 0x0007BB20 File Offset: 0x00079D20
		public unsafe WormBoard Board
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_get_Board_Public_get_WormBoard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormBoard>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_set_Board_Public_set_Void_WormBoard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x0007BB64 File Offset: 0x00079D64
		// (set) Token: 0x06000467 RID: 1127 RVA: 0x0007BBA4 File Offset: 0x00079DA4
		public unsafe WormPlayArea IntrigueDeck
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_get_IntrigueDeck_Public_get_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_set_IntrigueDeck_Public_set_Void_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x0007BBE8 File Offset: 0x00079DE8
		// (set) Token: 0x06000469 RID: 1129 RVA: 0x0007BC28 File Offset: 0x00079E28
		public unsafe WormPlayArea IntrigueDiscard
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_get_IntrigueDiscard_Public_get_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_set_IntrigueDiscard_Public_set_Void_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x0007BC6C File Offset: 0x00079E6C
		// (set) Token: 0x0600046B RID: 1131 RVA: 0x0007BCAC File Offset: 0x00079EAC
		public unsafe WormPlayArea ImperiumDeck
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_get_ImperiumDeck_Public_get_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_set_ImperiumDeck_Public_set_Void_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x0007BCF0 File Offset: 0x00079EF0
		// (set) Token: 0x0600046D RID: 1133 RVA: 0x0007BD30 File Offset: 0x00079F30
		public unsafe WormPlayArea ImperiumRow
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_get_ImperiumRow_Public_get_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_set_ImperiumRow_Public_set_Void_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x0007BD74 File Offset: 0x00079F74
		// (set) Token: 0x0600046F RID: 1135 RVA: 0x0007BDB4 File Offset: 0x00079FB4
		public unsafe WormPlayArea HelenaReserve
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_get_HelenaReserve_Public_get_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_set_HelenaReserve_Public_set_Void_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x0007BDF8 File Offset: 0x00079FF8
		// (set) Token: 0x06000471 RID: 1137 RVA: 0x0007BE38 File Offset: 0x0007A038
		public unsafe WormPlayArea ReserveRow
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_get_ReserveRow_Public_get_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_set_ReserveRow_Public_set_Void_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x0007BE7C File Offset: 0x0007A07C
		// (set) Token: 0x06000473 RID: 1139 RVA: 0x0007BEBC File Offset: 0x0007A0BC
		public unsafe WormPlayArea Trash
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_get_Trash_Public_get_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_set_Trash_Public_set_Void_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x0007BF00 File Offset: 0x0007A100
		// (set) Token: 0x06000475 RID: 1141 RVA: 0x0007BF40 File Offset: 0x0007A140
		public unsafe WormPlayArea Box
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 39587, RefRangeEnd = 39588, XrefRangeStart = 39587, XrefRangeEnd = 39588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_get_Box_Public_get_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_set_Box_Public_set_Void_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x0007BF84 File Offset: 0x0007A184
		// (set) Token: 0x06000477 RID: 1143 RVA: 0x0007BFC4 File Offset: 0x0007A1C4
		public unsafe WormPlayArea HagalDeck
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_get_HagalDeck_Public_get_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_set_HagalDeck_Public_set_Void_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x0007C008 File Offset: 0x0007A208
		// (set) Token: 0x06000479 RID: 1145 RVA: 0x0007C048 File Offset: 0x0007A248
		public unsafe WormPlayArea HagalDiscard
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_get_HagalDiscard_Public_get_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_set_HagalDiscard_Public_set_Void_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x0007C08C File Offset: 0x0007A28C
		// (set) Token: 0x0600047B RID: 1147 RVA: 0x0007C0CC File Offset: 0x0007A2CC
		public unsafe WormPlayArea TleilaxuDeck
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_get_TleilaxuDeck_Public_get_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_set_TleilaxuDeck_Public_set_Void_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x0007C110 File Offset: 0x0007A310
		// (set) Token: 0x0600047D RID: 1149 RVA: 0x0007C150 File Offset: 0x0007A350
		public unsafe WormPlayArea TleilaxuRow
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_get_TleilaxuRow_Public_get_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43949, XrefRangeEnd = 43950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_set_TleilaxuRow_Public_set_Void_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x0007C194 File Offset: 0x0007A394
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 44192, RefRangeEnd = 44193, XrefRangeStart = 43950, XrefRangeEnd = 44192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlaymat(Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr__ctor_Public_Void_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x0007C1E0 File Offset: 0x0007A3E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 44396, RefRangeEnd = 44397, XrefRangeStart = 44193, XrefRangeEnd = 44396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlaymat(SerializedEntity se, Match match, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x0007C250 File Offset: 0x0007A450
		public unsafe virtual IEnumerable<AbilityDefinition> BaseAbilities
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 44401, RefRangeEnd = 44410, XrefRangeStart = 44397, XrefRangeEnd = 44401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_get_BaseAbilities_Public_Virtual_Final_New_get_IEnumerable_1_AbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AbilityDefinition>>(intPtr3) : null;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000481 RID: 1153 RVA: 0x0007C290 File Offset: 0x0007A490
		public unsafe virtual Entity AbilitiesContainer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_get_AbilitiesContainer_Public_Virtual_Final_New_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x0007C2D0 File Offset: 0x0007A4D0
		public unsafe virtual IEnumerable<WormAbilityDefinition> Abilities
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 44401, RefRangeEnd = 44410, XrefRangeStart = 44401, XrefRangeEnd = 44410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_get_Abilities_Public_Virtual_Final_New_get_IEnumerable_1_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormAbilityDefinition>>(intPtr3) : null;
			}
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x0007C310 File Offset: 0x0007A510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44410, XrefRangeEnd = 44425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeAttrs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPlaymat.NativeMethodInfoPtr_InitializeAttrs_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x0007C34C File Offset: 0x0007A54C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 44482, RefRangeEnd = 44483, XrefRangeStart = 44425, XrefRangeEnd = 44482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x0007C380 File Offset: 0x0007A580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44483, XrefRangeEnd = 44487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetSerializedChildAbilities(Entity serializedAbilitiesEntity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializedAbilitiesEntity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_SetSerializedChildAbilities_Public_Virtual_Final_New_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x0007C3C4 File Offset: 0x0007A5C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSerializedChildAbilities(WormEntity serializedAbilitiesEntity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializedAbilitiesEntity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_SetSerializedChildAbilities_Public_Void_WormEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x0007C408 File Offset: 0x0007A608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44487, XrefRangeEnd = 44494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<global::Canis.actions.Action> AddChildAbility(WormAbilityDefinition wormAbilityDefinition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormAbilityDefinition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_AddChildAbility_Public_Virtual_Final_New_IEnumerable_1_Action_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x0007C458 File Offset: 0x0007A658
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 44501, RefRangeEnd = 44519, XrefRangeStart = 44494, XrefRangeEnd = 44501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CurrentRound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_CurrentRound_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x0007C494 File Offset: 0x0007A694
		[CallerCount(0)]
		public unsafe int CurrentPhase()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_CurrentPhase_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x0007C4D0 File Offset: 0x0007A6D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44519, XrefRangeEnd = 44523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe global::Canis.actions.Action SetCurrentPhase(int phase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref phase;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_SetCurrentPhase_Public_Action_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
			}
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x0007C51C File Offset: 0x0007A71C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 44660, RefRangeEnd = 44661, XrefRangeStart = 44523, XrefRangeEnd = 44660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<AbilityDefinitionForGame<WormMatch>> GetUsablePrePlayerTurnAbilities(WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_GetUsablePrePlayerTurnAbilities_Public_IEnumerable_1_AbilityDefinitionForGame_1_WormMatch_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AbilityDefinitionForGame<WormMatch>>>(intPtr3) : null;
			}
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x0007C56C File Offset: 0x0007A76C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 44844, RefRangeEnd = 44847, XrefRangeStart = 44661, XrefRangeEnd = 44844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<AbilityDefinitionForGame<WormMatch>> GetAllDeferredAbilities(WormPlayer player, PlayerTurnTypes turnType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref turnType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_GetAllDeferredAbilities_Public_IEnumerable_1_AbilityDefinitionForGame_1_WormMatch_WormPlayer_PlayerTurnTypes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AbilityDefinitionForGame<WormMatch>>>(intPtr3) : null;
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x0007C5CC File Offset: 0x0007A7CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 45059, RefRangeEnd = 45062, XrefRangeStart = 44847, XrefRangeEnd = 45059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<AbilityDefinitionForGame<WormMatch>> GetUsableDeferredAbilities(WormPlayer player, PlayerTurnTypes turnType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref turnType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_GetUsableDeferredAbilities_Public_IEnumerable_1_AbilityDefinitionForGame_1_WormMatch_WormPlayer_PlayerTurnTypes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AbilityDefinitionForGame<WormMatch>>>(intPtr3) : null;
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x0007C62C File Offset: 0x0007A82C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 45063, RefRangeEnd = 45064, XrefRangeStart = 45062, XrefRangeEnd = 45063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<AbilityDefinitionForGame<WormMatch>> GetUsableUnloadAbilities(WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_GetUsableUnloadAbilities_Public_IEnumerable_1_AbilityDefinitionForGame_1_WormMatch_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AbilityDefinitionForGame<WormMatch>>>(intPtr3) : null;
			}
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x0007C67C File Offset: 0x0007A87C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 45065, RefRangeEnd = 45066, XrefRangeStart = 45064, XrefRangeEnd = 45065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<AbilityDefinitionForGame<WormMatch>> GetHagalAbilities(WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_GetHagalAbilities_Public_IEnumerable_1_AbilityDefinitionForGame_1_WormMatch_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AbilityDefinitionForGame<WormMatch>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x0007C6CC File Offset: 0x0007A8CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 45183, RefRangeEnd = 45185, XrefRangeStart = 45066, XrefRangeEnd = 45183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<AbilityDefinitionForGame<WormMatch>> GetCustomTimingAbilities(WormPlayer player, bool isHagal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isHagal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_GetCustomTimingAbilities_Private_IEnumerable_1_AbilityDefinitionForGame_1_WormMatch_WormPlayer_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AbilityDefinitionForGame<WormMatch>>>(intPtr3) : null;
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x0007C72C File Offset: 0x0007A92C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 45235, RefRangeEnd = 45236, XrefRangeStart = 45185, XrefRangeEnd = 45235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<DeferredAbility> GetUsableDelayedAbilities(WormPlayer player, PlayerTurnTypes turnType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref turnType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_GetUsableDelayedAbilities_Public_IEnumerable_1_DeferredAbility_WormPlayer_PlayerTurnTypes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<DeferredAbility>>(intPtr3) : null;
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x0007C78C File Offset: 0x0007A98C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 45283, RefRangeEnd = 45287, XrefRangeStart = 45236, XrefRangeEnd = 45283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<PlayAbility> GetUsableIntrigueAbilities(WormPlayer player, IntrigueTypes intrigueType, Context paramContext = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref intrigueType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_GetUsableIntrigueAbilities_Public_IEnumerable_1_PlayAbility_WormPlayer_IntrigueTypes_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayAbility>>(intPtr3) : null;
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x0007C7FC File Offset: 0x0007A9FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 45351, RefRangeEnd = 45352, XrefRangeStart = 45287, XrefRangeEnd = 45351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsDoneWithActiveAgentArea(WormPlayer player, PlayerTurnTypes turnType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref turnType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_IsDoneWithActiveAgentArea_Public_Boolean_WormPlayer_PlayerTurnTypes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x0007C858 File Offset: 0x0007AA58
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 45358, RefRangeEnd = 45361, XrefRangeStart = 45352, XrefRangeEnd = 45358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> UpdateConditionaEndgameVP()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.NativeMethodInfoPtr_UpdateConditionaEndgameVP_Public_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00003A49 File Offset: 0x00001C49
		public WormPlaymat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x0007C898 File Offset: 0x0007AA98
		// (set) Token: 0x06000497 RID: 1175 RVA: 0x00003A52 File Offset: 0x00001C52
		public unsafe WormMatch match
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.NativeFieldInfoPtr_match);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x0007C8C8 File Offset: 0x0007AAC8
		// (set) Token: 0x06000499 RID: 1177 RVA: 0x00003A71 File Offset: 0x00001C71
		public unsafe LogStack LogStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.NativeFieldInfoPtr_LogStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LogStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.NativeFieldInfoPtr_LogStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x0007C8F8 File Offset: 0x0007AAF8
		// (set) Token: 0x0600049B RID: 1179 RVA: 0x00003A90 File Offset: 0x00001C90
		public unsafe Entity UndoStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.NativeFieldInfoPtr_UndoStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.NativeFieldInfoPtr_UndoStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x0007C928 File Offset: 0x0007AB28
		// (set) Token: 0x0600049D RID: 1181 RVA: 0x00003AAF File Offset: 0x00001CAF
		public unsafe UndoAbility<WormMatch> Undo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.NativeFieldInfoPtr_Undo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoAbility<WormMatch>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.NativeFieldInfoPtr_Undo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x0007C958 File Offset: 0x0007AB58
		// (set) Token: 0x0600049F RID: 1183 RVA: 0x00003ACE File Offset: 0x00001CCE
		public unsafe WormEntity abilitiesContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.NativeFieldInfoPtr_abilitiesContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.NativeFieldInfoPtr_abilitiesContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x0007C988 File Offset: 0x0007AB88
		// (set) Token: 0x060004A1 RID: 1185 RVA: 0x00003AED File Offset: 0x00001CED
		public unsafe WormEntity _ActiveAbilityStack_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.NativeFieldInfoPtr__ActiveAbilityStack_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.NativeFieldInfoPtr__ActiveAbilityStack_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x0007C9B8 File Offset: 0x0007ABB8
		// (set) Token: 0x060004A3 RID: 1187 RVA: 0x00003B0C File Offset: 0x00001D0C
		public unsafe WormBoard _Board_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.NativeFieldInfoPtr__Board_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormBoard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.NativeFieldInfoPtr__Board_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060004A4 RID: 1188 RVA: 0x0007C9E8 File Offset: 0x0007ABE8
		// (set) Token: 0x060004A5 RID: 1189 RVA: 0x00003B2B File Offset: 0x00001D2B
		public unsafe WormPlayArea _IntrigueDeck_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.NativeFieldInfoPtr__IntrigueDeck_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.NativeFieldInfoPtr__IntrigueDeck_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x0007CA18 File Offset: 0x0007AC18
		// (set) Token: 0x060004A7 RID: 1191 RVA: 0x00003B4A File Offset: 0x00001D4A
		public unsafe WormPlayArea _IntrigueDiscard_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.NativeFieldInfoPtr__IntrigueDiscard_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.NativeFieldInfoPtr__IntrigueDiscard_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x0007CA48 File Offset: 0x0007AC48
		// (set) Token: 0x060004A9 RID: 1193 RVA: 0x00003B69 File Offset: 0x00001D69
		public unsafe WormPlayArea _ImperiumDeck_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.NativeFieldInfoPtr__ImperiumDeck_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.NativeFieldInfoPtr__ImperiumDeck_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x0007CA78 File Offset: 0x0007AC78
		// (set) Token: 0x060004AB RID: 1195 RVA: 0x00003B88 File Offset: 0x00001D88
		public unsafe WormPlayArea _ImperiumRow_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.NativeFieldInfoPtr__ImperiumRow_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.NativeFieldInfoPtr__ImperiumRow_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x0007CAA8 File Offset: 0x0007ACA8
		// (set) Token: 0x060004AD RID: 1197 RVA: 0x00003BA7 File Offset: 0x00001DA7
		public unsafe WormPlayArea _HelenaReserve_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.NativeFieldInfoPtr__HelenaReserve_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.NativeFieldInfoPtr__HelenaReserve_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x0007CAD8 File Offset: 0x0007ACD8
		// (set) Token: 0x060004AF RID: 1199 RVA: 0x00003BC6 File Offset: 0x00001DC6
		public unsafe WormPlayArea _ReserveRow_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.NativeFieldInfoPtr__ReserveRow_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.NativeFieldInfoPtr__ReserveRow_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x0007CB08 File Offset: 0x0007AD08
		// (set) Token: 0x060004B1 RID: 1201 RVA: 0x00003BE5 File Offset: 0x00001DE5
		public unsafe WormPlayArea _Trash_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.NativeFieldInfoPtr__Trash_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.NativeFieldInfoPtr__Trash_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x0007CB38 File Offset: 0x0007AD38
		// (set) Token: 0x060004B3 RID: 1203 RVA: 0x00003C04 File Offset: 0x00001E04
		public unsafe WormPlayArea _Box_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.NativeFieldInfoPtr__Box_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.NativeFieldInfoPtr__Box_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x0007CB68 File Offset: 0x0007AD68
		// (set) Token: 0x060004B5 RID: 1205 RVA: 0x00003C23 File Offset: 0x00001E23
		public unsafe WormPlayArea _HagalDeck_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.NativeFieldInfoPtr__HagalDeck_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.NativeFieldInfoPtr__HagalDeck_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x0007CB98 File Offset: 0x0007AD98
		// (set) Token: 0x060004B7 RID: 1207 RVA: 0x00003C42 File Offset: 0x00001E42
		public unsafe WormPlayArea _HagalDiscard_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.NativeFieldInfoPtr__HagalDiscard_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.NativeFieldInfoPtr__HagalDiscard_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x0007CBC8 File Offset: 0x0007ADC8
		// (set) Token: 0x060004B9 RID: 1209 RVA: 0x00003C61 File Offset: 0x00001E61
		public unsafe WormPlayArea _TleilaxuDeck_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.NativeFieldInfoPtr__TleilaxuDeck_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.NativeFieldInfoPtr__TleilaxuDeck_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060004BA RID: 1210 RVA: 0x0007CBF8 File Offset: 0x0007ADF8
		// (set) Token: 0x060004BB RID: 1211 RVA: 0x00003C80 File Offset: 0x00001E80
		public unsafe WormPlayArea _TleilaxuRow_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.NativeFieldInfoPtr__TleilaxuRow_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.NativeFieldInfoPtr__TleilaxuRow_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000333 RID: 819
		private static readonly IntPtr NativeFieldInfoPtr_match;

		// Token: 0x04000334 RID: 820
		private static readonly IntPtr NativeFieldInfoPtr_LogStack;

		// Token: 0x04000335 RID: 821
		private static readonly IntPtr NativeFieldInfoPtr_UndoStack;

		// Token: 0x04000336 RID: 822
		private static readonly IntPtr NativeFieldInfoPtr_Undo;

		// Token: 0x04000337 RID: 823
		private static readonly IntPtr NativeFieldInfoPtr_abilitiesContainer;

		// Token: 0x04000338 RID: 824
		private static readonly IntPtr NativeFieldInfoPtr__ActiveAbilityStack_k__BackingField;

		// Token: 0x04000339 RID: 825
		private static readonly IntPtr NativeFieldInfoPtr__Board_k__BackingField;

		// Token: 0x0400033A RID: 826
		private static readonly IntPtr NativeFieldInfoPtr__IntrigueDeck_k__BackingField;

		// Token: 0x0400033B RID: 827
		private static readonly IntPtr NativeFieldInfoPtr__IntrigueDiscard_k__BackingField;

		// Token: 0x0400033C RID: 828
		private static readonly IntPtr NativeFieldInfoPtr__ImperiumDeck_k__BackingField;

		// Token: 0x0400033D RID: 829
		private static readonly IntPtr NativeFieldInfoPtr__ImperiumRow_k__BackingField;

		// Token: 0x0400033E RID: 830
		private static readonly IntPtr NativeFieldInfoPtr__HelenaReserve_k__BackingField;

		// Token: 0x0400033F RID: 831
		private static readonly IntPtr NativeFieldInfoPtr__ReserveRow_k__BackingField;

		// Token: 0x04000340 RID: 832
		private static readonly IntPtr NativeFieldInfoPtr__Trash_k__BackingField;

		// Token: 0x04000341 RID: 833
		private static readonly IntPtr NativeFieldInfoPtr__Box_k__BackingField;

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeFieldInfoPtr__HagalDeck_k__BackingField;

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeFieldInfoPtr__HagalDiscard_k__BackingField;

		// Token: 0x04000344 RID: 836
		private static readonly IntPtr NativeFieldInfoPtr__TleilaxuDeck_k__BackingField;

		// Token: 0x04000345 RID: 837
		private static readonly IntPtr NativeFieldInfoPtr__TleilaxuRow_k__BackingField;

		// Token: 0x04000346 RID: 838
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveAbilityStack_Public_get_WormEntity_0;

		// Token: 0x04000347 RID: 839
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveAbilityStack_Public_set_Void_WormEntity_0;

		// Token: 0x04000348 RID: 840
		private static readonly IntPtr NativeMethodInfoPtr_get_Board_Public_get_WormBoard_0;

		// Token: 0x04000349 RID: 841
		private static readonly IntPtr NativeMethodInfoPtr_set_Board_Public_set_Void_WormBoard_0;

		// Token: 0x0400034A RID: 842
		private static readonly IntPtr NativeMethodInfoPtr_get_IntrigueDeck_Public_get_WormPlayArea_0;

		// Token: 0x0400034B RID: 843
		private static readonly IntPtr NativeMethodInfoPtr_set_IntrigueDeck_Public_set_Void_WormPlayArea_0;

		// Token: 0x0400034C RID: 844
		private static readonly IntPtr NativeMethodInfoPtr_get_IntrigueDiscard_Public_get_WormPlayArea_0;

		// Token: 0x0400034D RID: 845
		private static readonly IntPtr NativeMethodInfoPtr_set_IntrigueDiscard_Public_set_Void_WormPlayArea_0;

		// Token: 0x0400034E RID: 846
		private static readonly IntPtr NativeMethodInfoPtr_get_ImperiumDeck_Public_get_WormPlayArea_0;

		// Token: 0x0400034F RID: 847
		private static readonly IntPtr NativeMethodInfoPtr_set_ImperiumDeck_Public_set_Void_WormPlayArea_0;

		// Token: 0x04000350 RID: 848
		private static readonly IntPtr NativeMethodInfoPtr_get_ImperiumRow_Public_get_WormPlayArea_0;

		// Token: 0x04000351 RID: 849
		private static readonly IntPtr NativeMethodInfoPtr_set_ImperiumRow_Public_set_Void_WormPlayArea_0;

		// Token: 0x04000352 RID: 850
		private static readonly IntPtr NativeMethodInfoPtr_get_HelenaReserve_Public_get_WormPlayArea_0;

		// Token: 0x04000353 RID: 851
		private static readonly IntPtr NativeMethodInfoPtr_set_HelenaReserve_Public_set_Void_WormPlayArea_0;

		// Token: 0x04000354 RID: 852
		private static readonly IntPtr NativeMethodInfoPtr_get_ReserveRow_Public_get_WormPlayArea_0;

		// Token: 0x04000355 RID: 853
		private static readonly IntPtr NativeMethodInfoPtr_set_ReserveRow_Public_set_Void_WormPlayArea_0;

		// Token: 0x04000356 RID: 854
		private static readonly IntPtr NativeMethodInfoPtr_get_Trash_Public_get_WormPlayArea_0;

		// Token: 0x04000357 RID: 855
		private static readonly IntPtr NativeMethodInfoPtr_set_Trash_Public_set_Void_WormPlayArea_0;

		// Token: 0x04000358 RID: 856
		private static readonly IntPtr NativeMethodInfoPtr_get_Box_Public_get_WormPlayArea_0;

		// Token: 0x04000359 RID: 857
		private static readonly IntPtr NativeMethodInfoPtr_set_Box_Public_set_Void_WormPlayArea_0;

		// Token: 0x0400035A RID: 858
		private static readonly IntPtr NativeMethodInfoPtr_get_HagalDeck_Public_get_WormPlayArea_0;

		// Token: 0x0400035B RID: 859
		private static readonly IntPtr NativeMethodInfoPtr_set_HagalDeck_Public_set_Void_WormPlayArea_0;

		// Token: 0x0400035C RID: 860
		private static readonly IntPtr NativeMethodInfoPtr_get_HagalDiscard_Public_get_WormPlayArea_0;

		// Token: 0x0400035D RID: 861
		private static readonly IntPtr NativeMethodInfoPtr_set_HagalDiscard_Public_set_Void_WormPlayArea_0;

		// Token: 0x0400035E RID: 862
		private static readonly IntPtr NativeMethodInfoPtr_get_TleilaxuDeck_Public_get_WormPlayArea_0;

		// Token: 0x0400035F RID: 863
		private static readonly IntPtr NativeMethodInfoPtr_set_TleilaxuDeck_Public_set_Void_WormPlayArea_0;

		// Token: 0x04000360 RID: 864
		private static readonly IntPtr NativeMethodInfoPtr_get_TleilaxuRow_Public_get_WormPlayArea_0;

		// Token: 0x04000361 RID: 865
		private static readonly IntPtr NativeMethodInfoPtr_set_TleilaxuRow_Public_set_Void_WormPlayArea_0;

		// Token: 0x04000362 RID: 866
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_0;

		// Token: 0x04000363 RID: 867
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0;

		// Token: 0x04000364 RID: 868
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseAbilities_Public_Virtual_Final_New_get_IEnumerable_1_AbilityDefinition_0;

		// Token: 0x04000365 RID: 869
		private static readonly IntPtr NativeMethodInfoPtr_get_AbilitiesContainer_Public_Virtual_Final_New_get_Entity_0;

		// Token: 0x04000366 RID: 870
		private static readonly IntPtr NativeMethodInfoPtr_get_Abilities_Public_Virtual_Final_New_get_IEnumerable_1_WormAbilityDefinition_0;

		// Token: 0x04000367 RID: 871
		private static readonly IntPtr NativeMethodInfoPtr_InitializeAttrs_Public_Virtual_Void_0;

		// Token: 0x04000368 RID: 872
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

		// Token: 0x04000369 RID: 873
		private static readonly IntPtr NativeMethodInfoPtr_SetSerializedChildAbilities_Public_Virtual_Final_New_Void_Entity_0;

		// Token: 0x0400036A RID: 874
		private static readonly IntPtr NativeMethodInfoPtr_SetSerializedChildAbilities_Public_Void_WormEntity_0;

		// Token: 0x0400036B RID: 875
		private static readonly IntPtr NativeMethodInfoPtr_AddChildAbility_Public_Virtual_Final_New_IEnumerable_1_Action_WormAbilityDefinition_0;

		// Token: 0x0400036C RID: 876
		private static readonly IntPtr NativeMethodInfoPtr_CurrentRound_Public_Int32_0;

		// Token: 0x0400036D RID: 877
		private static readonly IntPtr NativeMethodInfoPtr_CurrentPhase_Public_Int32_0;

		// Token: 0x0400036E RID: 878
		private static readonly IntPtr NativeMethodInfoPtr_SetCurrentPhase_Public_Action_Int32_0;

		// Token: 0x0400036F RID: 879
		private static readonly IntPtr NativeMethodInfoPtr_GetUsablePrePlayerTurnAbilities_Public_IEnumerable_1_AbilityDefinitionForGame_1_WormMatch_WormPlayer_0;

		// Token: 0x04000370 RID: 880
		private static readonly IntPtr NativeMethodInfoPtr_GetAllDeferredAbilities_Public_IEnumerable_1_AbilityDefinitionForGame_1_WormMatch_WormPlayer_PlayerTurnTypes_0;

		// Token: 0x04000371 RID: 881
		private static readonly IntPtr NativeMethodInfoPtr_GetUsableDeferredAbilities_Public_IEnumerable_1_AbilityDefinitionForGame_1_WormMatch_WormPlayer_PlayerTurnTypes_0;

		// Token: 0x04000372 RID: 882
		private static readonly IntPtr NativeMethodInfoPtr_GetUsableUnloadAbilities_Public_IEnumerable_1_AbilityDefinitionForGame_1_WormMatch_WormPlayer_0;

		// Token: 0x04000373 RID: 883
		private static readonly IntPtr NativeMethodInfoPtr_GetHagalAbilities_Public_IEnumerable_1_AbilityDefinitionForGame_1_WormMatch_WormPlayer_0;

		// Token: 0x04000374 RID: 884
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomTimingAbilities_Private_IEnumerable_1_AbilityDefinitionForGame_1_WormMatch_WormPlayer_Boolean_0;

		// Token: 0x04000375 RID: 885
		private static readonly IntPtr NativeMethodInfoPtr_GetUsableDelayedAbilities_Public_IEnumerable_1_DeferredAbility_WormPlayer_PlayerTurnTypes_0;

		// Token: 0x04000376 RID: 886
		private static readonly IntPtr NativeMethodInfoPtr_GetUsableIntrigueAbilities_Public_IEnumerable_1_PlayAbility_WormPlayer_IntrigueTypes_Context_0;

		// Token: 0x04000377 RID: 887
		private static readonly IntPtr NativeMethodInfoPtr_IsDoneWithActiveAgentArea_Public_Boolean_WormPlayer_PlayerTurnTypes_0;

		// Token: 0x04000378 RID: 888
		private static readonly IntPtr NativeMethodInfoPtr_UpdateConditionaEndgameVP_Public_IEnumerable_1_Action_0;

		// Token: 0x020005BD RID: 1469
		[ObfuscatedName("worm.canis.entities.WormPlaymat+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x060046C1 RID: 18113 RVA: 0x00189698 File Offset: 0x00187898
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr);
				WormPlaymat.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, "<>9");
				WormPlaymat.__c.NativeFieldInfoPtr___9__62_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, "<>9__62_3");
				WormPlaymat.__c.NativeFieldInfoPtr___9__77_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, "<>9__77_0");
				WormPlaymat.__c.NativeFieldInfoPtr___9__77_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, "<>9__77_4");
				WormPlaymat.__c.NativeFieldInfoPtr___9__77_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, "<>9__77_6");
				WormPlaymat.__c.NativeFieldInfoPtr___9__78_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, "<>9__78_0");
				WormPlaymat.__c.NativeFieldInfoPtr___9__78_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, "<>9__78_5");
				WormPlaymat.__c.NativeFieldInfoPtr___9__78_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, "<>9__78_7");
				WormPlaymat.__c.NativeFieldInfoPtr___9__78_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, "<>9__78_8");
				WormPlaymat.__c.NativeFieldInfoPtr___9__79_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, "<>9__79_0");
				WormPlaymat.__c.NativeFieldInfoPtr___9__79_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, "<>9__79_10");
				WormPlaymat.__c.NativeFieldInfoPtr___9__79_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, "<>9__79_5");
				WormPlaymat.__c.NativeFieldInfoPtr___9__79_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, "<>9__79_7");
				WormPlaymat.__c.NativeFieldInfoPtr___9__82_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, "<>9__82_1");
				WormPlaymat.__c.NativeFieldInfoPtr___9__82_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, "<>9__82_5");
				WormPlaymat.__c.NativeFieldInfoPtr___9__82_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, "<>9__82_3");
				WormPlaymat.__c.NativeFieldInfoPtr___9__83_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, "<>9__83_0");
				WormPlaymat.__c.NativeFieldInfoPtr___9__84_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, "<>9__84_1");
				WormPlaymat.__c.NativeFieldInfoPtr___9__85_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, "<>9__85_0");
				WormPlaymat.__c.NativeFieldInfoPtr___9__86_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, "<>9__86_0");
				WormPlaymat.__c.NativeFieldInfoPtr___9__86_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, "<>9__86_1");
				WormPlaymat.__c.NativeFieldInfoPtr___9__86_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, "<>9__86_2");
				WormPlaymat.__c.NativeFieldInfoPtr___9__86_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, "<>9__86_3");
				WormPlaymat.__c.NativeFieldInfoPtr___9__86_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, "<>9__86_4");
				WormPlaymat.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, 100664460);
				WormPlaymat.__c.NativeMethodInfoPtr___ctor_b__62_3_Internal_ArchetypeID_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, 100664461);
				WormPlaymat.__c.NativeMethodInfoPtr__GetUsablePrePlayerTurnAbilities_b__77_0_Internal_IEnumerable_1_AgentAbility_WormPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, 100664462);
				WormPlaymat.__c.NativeMethodInfoPtr__GetUsablePrePlayerTurnAbilities_b__77_4_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, 100664463);
				WormPlaymat.__c.NativeMethodInfoPtr__GetUsablePrePlayerTurnAbilities_b__77_6_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, 100664464);
				WormPlaymat.__c.NativeMethodInfoPtr__GetAllDeferredAbilities_b__78_0_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, 100664465);
				WormPlaymat.__c.NativeMethodInfoPtr__GetAllDeferredAbilities_b__78_5_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, 100664466);
				WormPlaymat.__c.NativeMethodInfoPtr__GetAllDeferredAbilities_b__78_7_Internal_Boolean_WormTechTilePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, 100664467);
				WormPlaymat.__c.NativeMethodInfoPtr__GetAllDeferredAbilities_b__78_8_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, 100664468);
				WormPlaymat.__c.NativeMethodInfoPtr__GetUsableDeferredAbilities_b__79_0_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, 100664469);
				WormPlaymat.__c.NativeMethodInfoPtr__GetUsableDeferredAbilities_b__79_10_Internal_IEnumerable_1_AcquireAbility_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, 100664470);
				WormPlaymat.__c.NativeMethodInfoPtr__GetUsableDeferredAbilities_b__79_5_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, 100664471);
				WormPlaymat.__c.NativeMethodInfoPtr__GetUsableDeferredAbilities_b__79_7_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, 100664472);
				WormPlaymat.__c.NativeMethodInfoPtr__GetCustomTimingAbilities_b__82_1_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, 100664473);
				WormPlaymat.__c.NativeMethodInfoPtr__GetCustomTimingAbilities_b__82_5_Internal_Boolean_WormTechTilePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, 100664474);
				WormPlaymat.__c.NativeMethodInfoPtr__GetCustomTimingAbilities_b__82_3_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, 100664475);
				WormPlaymat.__c.NativeMethodInfoPtr__GetUsableDelayedAbilities_b__83_0_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, 100664476);
				WormPlaymat.__c.NativeMethodInfoPtr__GetUsableIntrigueAbilities_b__84_1_Internal_IEnumerable_1_PlayAbility_WormPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, 100664477);
				WormPlaymat.__c.NativeMethodInfoPtr__IsDoneWithActiveAgentArea_b__85_0_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, 100664478);
				WormPlaymat.__c.NativeMethodInfoPtr__UpdateConditionaEndgameVP_b__86_0_Internal_IEnumerable_1_Entity_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, 100664479);
				WormPlaymat.__c.NativeMethodInfoPtr__UpdateConditionaEndgameVP_b__86_1_Internal_Boolean_WormPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, 100664480);
				WormPlaymat.__c.NativeMethodInfoPtr__UpdateConditionaEndgameVP_b__86_2_Internal_IEnumerable_1_Entity_WormTechTileStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, 100664481);
				WormPlaymat.__c.NativeMethodInfoPtr__UpdateConditionaEndgameVP_b__86_3_Internal_Boolean_WormPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, 100664482);
				WormPlaymat.__c.NativeMethodInfoPtr__UpdateConditionaEndgameVP_b__86_4_Internal_Boolean_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr, 100664483);
			}

			// Token: 0x060046C2 RID: 18114 RVA: 0x00189A84 File Offset: 0x00187C84
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlaymat.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060046C3 RID: 18115 RVA: 0x00189AC0 File Offset: 0x00187CC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43504, XrefRangeEnd = 43505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ArchetypeID __ctor_b__62_3(WormImperiumPlayable card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c.NativeMethodInfoPtr___ctor_b__62_3_Internal_ArchetypeID_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
				}
			}

			// Token: 0x060046C4 RID: 18116 RVA: 0x00189B10 File Offset: 0x00187D10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43505, XrefRangeEnd = 43508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<AgentAbility> _GetUsablePrePlayerTurnAbilities_b__77_0(WormPlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c.NativeMethodInfoPtr__GetUsablePrePlayerTurnAbilities_b__77_0_Internal_IEnumerable_1_AgentAbility_WormPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AgentAbility>>(intPtr3) : null;
				}
			}

			// Token: 0x060046C5 RID: 18117 RVA: 0x00189B60 File Offset: 0x00187D60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43508, XrefRangeEnd = 43511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<DeferredAbility> _GetUsablePrePlayerTurnAbilities_b__77_4(IHasAbilities<WormMatch, WormAbilityDefinition> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c.NativeMethodInfoPtr__GetUsablePrePlayerTurnAbilities_b__77_4_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<DeferredAbility>>(intPtr3) : null;
				}
			}

			// Token: 0x060046C6 RID: 18118 RVA: 0x00189BB0 File Offset: 0x00187DB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43511, XrefRangeEnd = 43514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<DeferredAbility> _GetUsablePrePlayerTurnAbilities_b__77_6(IHasAbilities<WormMatch, WormAbilityDefinition> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c.NativeMethodInfoPtr__GetUsablePrePlayerTurnAbilities_b__77_6_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<DeferredAbility>>(intPtr3) : null;
				}
			}

			// Token: 0x060046C7 RID: 18119 RVA: 0x00189C00 File Offset: 0x00187E00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43514, XrefRangeEnd = 43517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<DeferredAbility> _GetAllDeferredAbilities_b__78_0(IHasAbilities<WormMatch, WormAbilityDefinition> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c.NativeMethodInfoPtr__GetAllDeferredAbilities_b__78_0_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<DeferredAbility>>(intPtr3) : null;
				}
			}

			// Token: 0x060046C8 RID: 18120 RVA: 0x00189C50 File Offset: 0x00187E50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43517, XrefRangeEnd = 43520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<DeferredAbility> _GetAllDeferredAbilities_b__78_5(IHasAbilities<WormMatch, WormAbilityDefinition> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c.NativeMethodInfoPtr__GetAllDeferredAbilities_b__78_5_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<DeferredAbility>>(intPtr3) : null;
				}
			}

			// Token: 0x060046C9 RID: 18121 RVA: 0x00189CA0 File Offset: 0x00187EA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43520, XrefRangeEnd = 43522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAllDeferredAbilities_b__78_7(WormTechTilePlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c.NativeMethodInfoPtr__GetAllDeferredAbilities_b__78_7_Internal_Boolean_WormTechTilePlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060046CA RID: 18122 RVA: 0x00189CF0 File Offset: 0x00187EF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43522, XrefRangeEnd = 43525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<DeferredAbility> _GetAllDeferredAbilities_b__78_8(IHasAbilities<WormMatch, WormAbilityDefinition> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c.NativeMethodInfoPtr__GetAllDeferredAbilities_b__78_8_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<DeferredAbility>>(intPtr3) : null;
				}
			}

			// Token: 0x060046CB RID: 18123 RVA: 0x00189D40 File Offset: 0x00187F40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43525, XrefRangeEnd = 43528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<DeferredAbility> _GetUsableDeferredAbilities_b__79_0(IHasAbilities<WormMatch, WormAbilityDefinition> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c.NativeMethodInfoPtr__GetUsableDeferredAbilities_b__79_0_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<DeferredAbility>>(intPtr3) : null;
				}
			}

			// Token: 0x060046CC RID: 18124 RVA: 0x00189D90 File Offset: 0x00187F90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43528, XrefRangeEnd = 43531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<AcquireAbility> _GetUsableDeferredAbilities_b__79_10(WormImperiumPlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c.NativeMethodInfoPtr__GetUsableDeferredAbilities_b__79_10_Internal_IEnumerable_1_AcquireAbility_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AcquireAbility>>(intPtr3) : null;
				}
			}

			// Token: 0x060046CD RID: 18125 RVA: 0x00189DE0 File Offset: 0x00187FE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43531, XrefRangeEnd = 43534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<DeferredAbility> _GetUsableDeferredAbilities_b__79_5(IHasAbilities<WormMatch, WormAbilityDefinition> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c.NativeMethodInfoPtr__GetUsableDeferredAbilities_b__79_5_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<DeferredAbility>>(intPtr3) : null;
				}
			}

			// Token: 0x060046CE RID: 18126 RVA: 0x00189E30 File Offset: 0x00188030
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43534, XrefRangeEnd = 43537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<DeferredAbility> _GetUsableDeferredAbilities_b__79_7(IHasAbilities<WormMatch, WormAbilityDefinition> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c.NativeMethodInfoPtr__GetUsableDeferredAbilities_b__79_7_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<DeferredAbility>>(intPtr3) : null;
				}
			}

			// Token: 0x060046CF RID: 18127 RVA: 0x00189E80 File Offset: 0x00188080
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43537, XrefRangeEnd = 43540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<DeferredAbility> _GetCustomTimingAbilities_b__82_1(IHasAbilities<WormMatch, WormAbilityDefinition> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c.NativeMethodInfoPtr__GetCustomTimingAbilities_b__82_1_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<DeferredAbility>>(intPtr3) : null;
				}
			}

			// Token: 0x060046D0 RID: 18128 RVA: 0x00189ED0 File Offset: 0x001880D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43540, XrefRangeEnd = 43549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetCustomTimingAbilities_b__82_5(WormTechTilePlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c.NativeMethodInfoPtr__GetCustomTimingAbilities_b__82_5_Internal_Boolean_WormTechTilePlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060046D1 RID: 18129 RVA: 0x00189F20 File Offset: 0x00188120
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43549, XrefRangeEnd = 43552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<DeferredAbility> _GetCustomTimingAbilities_b__82_3(IHasAbilities<WormMatch, WormAbilityDefinition> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c.NativeMethodInfoPtr__GetCustomTimingAbilities_b__82_3_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<DeferredAbility>>(intPtr3) : null;
				}
			}

			// Token: 0x060046D2 RID: 18130 RVA: 0x00189F70 File Offset: 0x00188170
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43552, XrefRangeEnd = 43555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<DeferredAbility> _GetUsableDelayedAbilities_b__83_0(IHasAbilities<WormMatch, WormAbilityDefinition> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c.NativeMethodInfoPtr__GetUsableDelayedAbilities_b__83_0_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<DeferredAbility>>(intPtr3) : null;
				}
			}

			// Token: 0x060046D3 RID: 18131 RVA: 0x00189FC0 File Offset: 0x001881C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43555, XrefRangeEnd = 43558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<PlayAbility> _GetUsableIntrigueAbilities_b__84_1(WormPlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c.NativeMethodInfoPtr__GetUsableIntrigueAbilities_b__84_1_Internal_IEnumerable_1_PlayAbility_WormPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayAbility>>(intPtr3) : null;
				}
			}

			// Token: 0x060046D4 RID: 18132 RVA: 0x0018A010 File Offset: 0x00188210
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43558, XrefRangeEnd = 43561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<DeferredAbility> _IsDoneWithActiveAgentArea_b__85_0(IHasAbilities<WormMatch, WormAbilityDefinition> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c.NativeMethodInfoPtr__IsDoneWithActiveAgentArea_b__85_0_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<DeferredAbility>>(intPtr3) : null;
				}
			}

			// Token: 0x060046D5 RID: 18133 RVA: 0x0018A060 File Offset: 0x00188260
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43561, XrefRangeEnd = 43565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<Entity> _UpdateConditionaEndgameVP_b__86_0(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c.NativeMethodInfoPtr__UpdateConditionaEndgameVP_b__86_0_Internal_IEnumerable_1_Entity_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x060046D6 RID: 18134 RVA: 0x0018A0B0 File Offset: 0x001882B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43565, XrefRangeEnd = 43582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateConditionaEndgameVP_b__86_1(WormPlayable wp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(wp);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c.NativeMethodInfoPtr__UpdateConditionaEndgameVP_b__86_1_Internal_Boolean_WormPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060046D7 RID: 18135 RVA: 0x0018A100 File Offset: 0x00188300
			[CallerCount(0)]
			public unsafe IEnumerable<Entity> _UpdateConditionaEndgameVP_b__86_2(WormTechTileStack _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c.NativeMethodInfoPtr__UpdateConditionaEndgameVP_b__86_2_Internal_IEnumerable_1_Entity_WormTechTileStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x060046D8 RID: 18136 RVA: 0x0018A150 File Offset: 0x00188350
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43582, XrefRangeEnd = 43599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateConditionaEndgameVP_b__86_3(WormPlayable wp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(wp);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c.NativeMethodInfoPtr__UpdateConditionaEndgameVP_b__86_3_Internal_Boolean_WormPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060046D9 RID: 18137 RVA: 0x0018A1A0 File Offset: 0x001883A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43599, XrefRangeEnd = 43606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateConditionaEndgameVP_b__86_4(WormAbilityDefinition ab)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ab);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c.NativeMethodInfoPtr__UpdateConditionaEndgameVP_b__86_4_Internal_Boolean_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060046DA RID: 18138 RVA: 0x00017A74 File Offset: 0x00015C74
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010FC RID: 4348
			// (get) Token: 0x060046DB RID: 18139 RVA: 0x0018A1F0 File Offset: 0x001883F0
			// (set) Token: 0x060046DC RID: 18140 RVA: 0x00017A7D File Offset: 0x00015C7D
			public unsafe static WormPlaymat.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlaymat.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlaymat.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlaymat.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010FD RID: 4349
			// (get) Token: 0x060046DD RID: 18141 RVA: 0x0018A218 File Offset: 0x00188418
			// (set) Token: 0x060046DE RID: 18142 RVA: 0x00017A8F File Offset: 0x00015C8F
			public unsafe static Func<WormImperiumPlayable, ArchetypeID> __9__62_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlaymat.__c.NativeFieldInfoPtr___9__62_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormImperiumPlayable, ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlaymat.__c.NativeFieldInfoPtr___9__62_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010FE RID: 4350
			// (get) Token: 0x060046DF RID: 18143 RVA: 0x0018A240 File Offset: 0x00188440
			// (set) Token: 0x060046E0 RID: 18144 RVA: 0x00017AA1 File Offset: 0x00015CA1
			public unsafe static Func<WormPlayable, IEnumerable<AgentAbility>> __9__77_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlaymat.__c.NativeFieldInfoPtr___9__77_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayable, IEnumerable<AgentAbility>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlaymat.__c.NativeFieldInfoPtr___9__77_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010FF RID: 4351
			// (get) Token: 0x060046E1 RID: 18145 RVA: 0x0018A268 File Offset: 0x00188468
			// (set) Token: 0x060046E2 RID: 18146 RVA: 0x00017AB3 File Offset: 0x00015CB3
			public unsafe static Func<IHasAbilities<WormMatch, WormAbilityDefinition>, IEnumerable<DeferredAbility>> __9__77_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlaymat.__c.NativeFieldInfoPtr___9__77_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IHasAbilities<WormMatch, WormAbilityDefinition>, IEnumerable<DeferredAbility>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlaymat.__c.NativeFieldInfoPtr___9__77_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001100 RID: 4352
			// (get) Token: 0x060046E3 RID: 18147 RVA: 0x0018A290 File Offset: 0x00188490
			// (set) Token: 0x060046E4 RID: 18148 RVA: 0x00017AC5 File Offset: 0x00015CC5
			public unsafe static Func<IHasAbilities<WormMatch, WormAbilityDefinition>, IEnumerable<DeferredAbility>> __9__77_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlaymat.__c.NativeFieldInfoPtr___9__77_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IHasAbilities<WormMatch, WormAbilityDefinition>, IEnumerable<DeferredAbility>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlaymat.__c.NativeFieldInfoPtr___9__77_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001101 RID: 4353
			// (get) Token: 0x060046E5 RID: 18149 RVA: 0x0018A2B8 File Offset: 0x001884B8
			// (set) Token: 0x060046E6 RID: 18150 RVA: 0x00017AD7 File Offset: 0x00015CD7
			public unsafe static Func<IHasAbilities<WormMatch, WormAbilityDefinition>, IEnumerable<DeferredAbility>> __9__78_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlaymat.__c.NativeFieldInfoPtr___9__78_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IHasAbilities<WormMatch, WormAbilityDefinition>, IEnumerable<DeferredAbility>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlaymat.__c.NativeFieldInfoPtr___9__78_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001102 RID: 4354
			// (get) Token: 0x060046E7 RID: 18151 RVA: 0x0018A2E0 File Offset: 0x001884E0
			// (set) Token: 0x060046E8 RID: 18152 RVA: 0x00017AE9 File Offset: 0x00015CE9
			public unsafe static Func<IHasAbilities<WormMatch, WormAbilityDefinition>, IEnumerable<DeferredAbility>> __9__78_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlaymat.__c.NativeFieldInfoPtr___9__78_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IHasAbilities<WormMatch, WormAbilityDefinition>, IEnumerable<DeferredAbility>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlaymat.__c.NativeFieldInfoPtr___9__78_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001103 RID: 4355
			// (get) Token: 0x060046E9 RID: 18153 RVA: 0x0018A308 File Offset: 0x00188508
			// (set) Token: 0x060046EA RID: 18154 RVA: 0x00017AFB File Offset: 0x00015CFB
			public unsafe static Func<WormTechTilePlayable, bool> __9__78_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlaymat.__c.NativeFieldInfoPtr___9__78_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormTechTilePlayable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlaymat.__c.NativeFieldInfoPtr___9__78_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001104 RID: 4356
			// (get) Token: 0x060046EB RID: 18155 RVA: 0x0018A330 File Offset: 0x00188530
			// (set) Token: 0x060046EC RID: 18156 RVA: 0x00017B0D File Offset: 0x00015D0D
			public unsafe static Func<IHasAbilities<WormMatch, WormAbilityDefinition>, IEnumerable<DeferredAbility>> __9__78_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlaymat.__c.NativeFieldInfoPtr___9__78_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IHasAbilities<WormMatch, WormAbilityDefinition>, IEnumerable<DeferredAbility>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlaymat.__c.NativeFieldInfoPtr___9__78_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001105 RID: 4357
			// (get) Token: 0x060046ED RID: 18157 RVA: 0x0018A358 File Offset: 0x00188558
			// (set) Token: 0x060046EE RID: 18158 RVA: 0x00017B1F File Offset: 0x00015D1F
			public unsafe static Func<IHasAbilities<WormMatch, WormAbilityDefinition>, IEnumerable<DeferredAbility>> __9__79_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlaymat.__c.NativeFieldInfoPtr___9__79_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IHasAbilities<WormMatch, WormAbilityDefinition>, IEnumerable<DeferredAbility>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlaymat.__c.NativeFieldInfoPtr___9__79_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001106 RID: 4358
			// (get) Token: 0x060046EF RID: 18159 RVA: 0x0018A380 File Offset: 0x00188580
			// (set) Token: 0x060046F0 RID: 18160 RVA: 0x00017B31 File Offset: 0x00015D31
			public unsafe static Func<WormImperiumPlayable, IEnumerable<AcquireAbility>> __9__79_10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlaymat.__c.NativeFieldInfoPtr___9__79_10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormImperiumPlayable, IEnumerable<AcquireAbility>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlaymat.__c.NativeFieldInfoPtr___9__79_10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001107 RID: 4359
			// (get) Token: 0x060046F1 RID: 18161 RVA: 0x0018A3A8 File Offset: 0x001885A8
			// (set) Token: 0x060046F2 RID: 18162 RVA: 0x00017B43 File Offset: 0x00015D43
			public unsafe static Func<IHasAbilities<WormMatch, WormAbilityDefinition>, IEnumerable<DeferredAbility>> __9__79_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlaymat.__c.NativeFieldInfoPtr___9__79_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IHasAbilities<WormMatch, WormAbilityDefinition>, IEnumerable<DeferredAbility>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlaymat.__c.NativeFieldInfoPtr___9__79_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001108 RID: 4360
			// (get) Token: 0x060046F3 RID: 18163 RVA: 0x0018A3D0 File Offset: 0x001885D0
			// (set) Token: 0x060046F4 RID: 18164 RVA: 0x00017B55 File Offset: 0x00015D55
			public unsafe static Func<IHasAbilities<WormMatch, WormAbilityDefinition>, IEnumerable<DeferredAbility>> __9__79_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlaymat.__c.NativeFieldInfoPtr___9__79_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IHasAbilities<WormMatch, WormAbilityDefinition>, IEnumerable<DeferredAbility>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlaymat.__c.NativeFieldInfoPtr___9__79_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001109 RID: 4361
			// (get) Token: 0x060046F5 RID: 18165 RVA: 0x0018A3F8 File Offset: 0x001885F8
			// (set) Token: 0x060046F6 RID: 18166 RVA: 0x00017B67 File Offset: 0x00015D67
			public unsafe static Func<IHasAbilities<WormMatch, WormAbilityDefinition>, IEnumerable<DeferredAbility>> __9__82_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlaymat.__c.NativeFieldInfoPtr___9__82_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IHasAbilities<WormMatch, WormAbilityDefinition>, IEnumerable<DeferredAbility>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlaymat.__c.NativeFieldInfoPtr___9__82_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700110A RID: 4362
			// (get) Token: 0x060046F7 RID: 18167 RVA: 0x0018A420 File Offset: 0x00188620
			// (set) Token: 0x060046F8 RID: 18168 RVA: 0x00017B79 File Offset: 0x00015D79
			public unsafe static Func<WormTechTilePlayable, bool> __9__82_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlaymat.__c.NativeFieldInfoPtr___9__82_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormTechTilePlayable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlaymat.__c.NativeFieldInfoPtr___9__82_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700110B RID: 4363
			// (get) Token: 0x060046F9 RID: 18169 RVA: 0x0018A448 File Offset: 0x00188648
			// (set) Token: 0x060046FA RID: 18170 RVA: 0x00017B8B File Offset: 0x00015D8B
			public unsafe static Func<IHasAbilities<WormMatch, WormAbilityDefinition>, IEnumerable<DeferredAbility>> __9__82_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlaymat.__c.NativeFieldInfoPtr___9__82_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IHasAbilities<WormMatch, WormAbilityDefinition>, IEnumerable<DeferredAbility>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlaymat.__c.NativeFieldInfoPtr___9__82_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700110C RID: 4364
			// (get) Token: 0x060046FB RID: 18171 RVA: 0x0018A470 File Offset: 0x00188670
			// (set) Token: 0x060046FC RID: 18172 RVA: 0x00017B9D File Offset: 0x00015D9D
			public unsafe static Func<IHasAbilities<WormMatch, WormAbilityDefinition>, IEnumerable<DeferredAbility>> __9__83_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlaymat.__c.NativeFieldInfoPtr___9__83_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IHasAbilities<WormMatch, WormAbilityDefinition>, IEnumerable<DeferredAbility>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlaymat.__c.NativeFieldInfoPtr___9__83_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700110D RID: 4365
			// (get) Token: 0x060046FD RID: 18173 RVA: 0x0018A498 File Offset: 0x00188698
			// (set) Token: 0x060046FE RID: 18174 RVA: 0x00017BAF File Offset: 0x00015DAF
			public unsafe static Func<WormPlayable, IEnumerable<PlayAbility>> __9__84_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlaymat.__c.NativeFieldInfoPtr___9__84_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayable, IEnumerable<PlayAbility>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlaymat.__c.NativeFieldInfoPtr___9__84_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700110E RID: 4366
			// (get) Token: 0x060046FF RID: 18175 RVA: 0x0018A4C0 File Offset: 0x001886C0
			// (set) Token: 0x06004700 RID: 18176 RVA: 0x00017BC1 File Offset: 0x00015DC1
			public unsafe static Func<IHasAbilities<WormMatch, WormAbilityDefinition>, IEnumerable<DeferredAbility>> __9__85_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlaymat.__c.NativeFieldInfoPtr___9__85_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IHasAbilities<WormMatch, WormAbilityDefinition>, IEnumerable<DeferredAbility>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlaymat.__c.NativeFieldInfoPtr___9__85_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700110F RID: 4367
			// (get) Token: 0x06004701 RID: 18177 RVA: 0x0018A4E8 File Offset: 0x001886E8
			// (set) Token: 0x06004702 RID: 18178 RVA: 0x00017BD3 File Offset: 0x00015DD3
			public unsafe static Func<WormPlayer, IEnumerable<Entity>> __9__86_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlaymat.__c.NativeFieldInfoPtr___9__86_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, IEnumerable<Entity>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlaymat.__c.NativeFieldInfoPtr___9__86_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001110 RID: 4368
			// (get) Token: 0x06004703 RID: 18179 RVA: 0x0018A510 File Offset: 0x00188710
			// (set) Token: 0x06004704 RID: 18180 RVA: 0x00017BE5 File Offset: 0x00015DE5
			public unsafe static Func<WormPlayable, bool> __9__86_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlaymat.__c.NativeFieldInfoPtr___9__86_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlaymat.__c.NativeFieldInfoPtr___9__86_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001111 RID: 4369
			// (get) Token: 0x06004705 RID: 18181 RVA: 0x0018A538 File Offset: 0x00188738
			// (set) Token: 0x06004706 RID: 18182 RVA: 0x00017BF7 File Offset: 0x00015DF7
			public unsafe static Func<WormTechTileStack, IEnumerable<Entity>> __9__86_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlaymat.__c.NativeFieldInfoPtr___9__86_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormTechTileStack, IEnumerable<Entity>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlaymat.__c.NativeFieldInfoPtr___9__86_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001112 RID: 4370
			// (get) Token: 0x06004707 RID: 18183 RVA: 0x0018A560 File Offset: 0x00188760
			// (set) Token: 0x06004708 RID: 18184 RVA: 0x00017C09 File Offset: 0x00015E09
			public unsafe static Func<WormPlayable, bool> __9__86_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlaymat.__c.NativeFieldInfoPtr___9__86_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlaymat.__c.NativeFieldInfoPtr___9__86_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001113 RID: 4371
			// (get) Token: 0x06004709 RID: 18185 RVA: 0x0018A588 File Offset: 0x00188788
			// (set) Token: 0x0600470A RID: 18186 RVA: 0x00017C1B File Offset: 0x00015E1B
			public unsafe static Func<WormAbilityDefinition, bool> __9__86_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlaymat.__c.NativeFieldInfoPtr___9__86_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormAbilityDefinition, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlaymat.__c.NativeFieldInfoPtr___9__86_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002E98 RID: 11928
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002E99 RID: 11929
			private static readonly IntPtr NativeFieldInfoPtr___9__62_3;

			// Token: 0x04002E9A RID: 11930
			private static readonly IntPtr NativeFieldInfoPtr___9__77_0;

			// Token: 0x04002E9B RID: 11931
			private static readonly IntPtr NativeFieldInfoPtr___9__77_4;

			// Token: 0x04002E9C RID: 11932
			private static readonly IntPtr NativeFieldInfoPtr___9__77_6;

			// Token: 0x04002E9D RID: 11933
			private static readonly IntPtr NativeFieldInfoPtr___9__78_0;

			// Token: 0x04002E9E RID: 11934
			private static readonly IntPtr NativeFieldInfoPtr___9__78_5;

			// Token: 0x04002E9F RID: 11935
			private static readonly IntPtr NativeFieldInfoPtr___9__78_7;

			// Token: 0x04002EA0 RID: 11936
			private static readonly IntPtr NativeFieldInfoPtr___9__78_8;

			// Token: 0x04002EA1 RID: 11937
			private static readonly IntPtr NativeFieldInfoPtr___9__79_0;

			// Token: 0x04002EA2 RID: 11938
			private static readonly IntPtr NativeFieldInfoPtr___9__79_10;

			// Token: 0x04002EA3 RID: 11939
			private static readonly IntPtr NativeFieldInfoPtr___9__79_5;

			// Token: 0x04002EA4 RID: 11940
			private static readonly IntPtr NativeFieldInfoPtr___9__79_7;

			// Token: 0x04002EA5 RID: 11941
			private static readonly IntPtr NativeFieldInfoPtr___9__82_1;

			// Token: 0x04002EA6 RID: 11942
			private static readonly IntPtr NativeFieldInfoPtr___9__82_5;

			// Token: 0x04002EA7 RID: 11943
			private static readonly IntPtr NativeFieldInfoPtr___9__82_3;

			// Token: 0x04002EA8 RID: 11944
			private static readonly IntPtr NativeFieldInfoPtr___9__83_0;

			// Token: 0x04002EA9 RID: 11945
			private static readonly IntPtr NativeFieldInfoPtr___9__84_1;

			// Token: 0x04002EAA RID: 11946
			private static readonly IntPtr NativeFieldInfoPtr___9__85_0;

			// Token: 0x04002EAB RID: 11947
			private static readonly IntPtr NativeFieldInfoPtr___9__86_0;

			// Token: 0x04002EAC RID: 11948
			private static readonly IntPtr NativeFieldInfoPtr___9__86_1;

			// Token: 0x04002EAD RID: 11949
			private static readonly IntPtr NativeFieldInfoPtr___9__86_2;

			// Token: 0x04002EAE RID: 11950
			private static readonly IntPtr NativeFieldInfoPtr___9__86_3;

			// Token: 0x04002EAF RID: 11951
			private static readonly IntPtr NativeFieldInfoPtr___9__86_4;

			// Token: 0x04002EB0 RID: 11952
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002EB1 RID: 11953
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__62_3_Internal_ArchetypeID_WormImperiumPlayable_0;

			// Token: 0x04002EB2 RID: 11954
			private static readonly IntPtr NativeMethodInfoPtr__GetUsablePrePlayerTurnAbilities_b__77_0_Internal_IEnumerable_1_AgentAbility_WormPlayable_0;

			// Token: 0x04002EB3 RID: 11955
			private static readonly IntPtr NativeMethodInfoPtr__GetUsablePrePlayerTurnAbilities_b__77_4_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0;

			// Token: 0x04002EB4 RID: 11956
			private static readonly IntPtr NativeMethodInfoPtr__GetUsablePrePlayerTurnAbilities_b__77_6_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0;

			// Token: 0x04002EB5 RID: 11957
			private static readonly IntPtr NativeMethodInfoPtr__GetAllDeferredAbilities_b__78_0_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0;

			// Token: 0x04002EB6 RID: 11958
			private static readonly IntPtr NativeMethodInfoPtr__GetAllDeferredAbilities_b__78_5_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0;

			// Token: 0x04002EB7 RID: 11959
			private static readonly IntPtr NativeMethodInfoPtr__GetAllDeferredAbilities_b__78_7_Internal_Boolean_WormTechTilePlayable_0;

			// Token: 0x04002EB8 RID: 11960
			private static readonly IntPtr NativeMethodInfoPtr__GetAllDeferredAbilities_b__78_8_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0;

			// Token: 0x04002EB9 RID: 11961
			private static readonly IntPtr NativeMethodInfoPtr__GetUsableDeferredAbilities_b__79_0_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0;

			// Token: 0x04002EBA RID: 11962
			private static readonly IntPtr NativeMethodInfoPtr__GetUsableDeferredAbilities_b__79_10_Internal_IEnumerable_1_AcquireAbility_WormImperiumPlayable_0;

			// Token: 0x04002EBB RID: 11963
			private static readonly IntPtr NativeMethodInfoPtr__GetUsableDeferredAbilities_b__79_5_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0;

			// Token: 0x04002EBC RID: 11964
			private static readonly IntPtr NativeMethodInfoPtr__GetUsableDeferredAbilities_b__79_7_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0;

			// Token: 0x04002EBD RID: 11965
			private static readonly IntPtr NativeMethodInfoPtr__GetCustomTimingAbilities_b__82_1_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0;

			// Token: 0x04002EBE RID: 11966
			private static readonly IntPtr NativeMethodInfoPtr__GetCustomTimingAbilities_b__82_5_Internal_Boolean_WormTechTilePlayable_0;

			// Token: 0x04002EBF RID: 11967
			private static readonly IntPtr NativeMethodInfoPtr__GetCustomTimingAbilities_b__82_3_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0;

			// Token: 0x04002EC0 RID: 11968
			private static readonly IntPtr NativeMethodInfoPtr__GetUsableDelayedAbilities_b__83_0_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0;

			// Token: 0x04002EC1 RID: 11969
			private static readonly IntPtr NativeMethodInfoPtr__GetUsableIntrigueAbilities_b__84_1_Internal_IEnumerable_1_PlayAbility_WormPlayable_0;

			// Token: 0x04002EC2 RID: 11970
			private static readonly IntPtr NativeMethodInfoPtr__IsDoneWithActiveAgentArea_b__85_0_Internal_IEnumerable_1_DeferredAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0;

			// Token: 0x04002EC3 RID: 11971
			private static readonly IntPtr NativeMethodInfoPtr__UpdateConditionaEndgameVP_b__86_0_Internal_IEnumerable_1_Entity_WormPlayer_0;

			// Token: 0x04002EC4 RID: 11972
			private static readonly IntPtr NativeMethodInfoPtr__UpdateConditionaEndgameVP_b__86_1_Internal_Boolean_WormPlayable_0;

			// Token: 0x04002EC5 RID: 11973
			private static readonly IntPtr NativeMethodInfoPtr__UpdateConditionaEndgameVP_b__86_2_Internal_IEnumerable_1_Entity_WormTechTileStack_0;

			// Token: 0x04002EC6 RID: 11974
			private static readonly IntPtr NativeMethodInfoPtr__UpdateConditionaEndgameVP_b__86_3_Internal_Boolean_WormPlayable_0;

			// Token: 0x04002EC7 RID: 11975
			private static readonly IntPtr NativeMethodInfoPtr__UpdateConditionaEndgameVP_b__86_4_Internal_Boolean_WormAbilityDefinition_0;
		}

		// Token: 0x020005BE RID: 1470
		[ObfuscatedName("worm.canis.entities.WormPlaymat+<>c__DisplayClass62_0")]
		public sealed class __c__DisplayClass62_0 : Object
		{
			// Token: 0x0600470B RID: 18187 RVA: 0x0018A5B0 File Offset: 0x001887B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass62_0()
			{
				Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass62_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, "<>c__DisplayClass62_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass62_0>.NativeClassPtr);
				WormPlaymat.__c__DisplayClass62_0.NativeFieldInfoPtr_reserveTuple = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass62_0>.NativeClassPtr, "reserveTuple");
				WormPlaymat.__c__DisplayClass62_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass62_0>.NativeClassPtr, 100664484);
				WormPlaymat.__c__DisplayClass62_0.NativeMethodInfoPtr___ctor_b__0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass62_0>.NativeClassPtr, 100664485);
				WormPlaymat.__c__DisplayClass62_0.NativeMethodInfoPtr___ctor_b__1_Internal_Boolean_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass62_0>.NativeClassPtr, 100664486);
			}

			// Token: 0x0600470C RID: 18188 RVA: 0x0018A62C File Offset: 0x0018882C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass62_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass62_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c__DisplayClass62_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600470D RID: 18189 RVA: 0x0018A668 File Offset: 0x00188868
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43606, XrefRangeEnd = 43611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool __ctor_b__0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c__DisplayClass62_0.NativeMethodInfoPtr___ctor_b__0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600470E RID: 18190 RVA: 0x0018A6B8 File Offset: 0x001888B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43611, XrefRangeEnd = 43616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool __ctor_b__1(WormImperiumPlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c__DisplayClass62_0.NativeMethodInfoPtr___ctor_b__1_Internal_Boolean_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600470F RID: 18191 RVA: 0x00017C2D File Offset: 0x00015E2D
			public __c__DisplayClass62_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001114 RID: 4372
			// (get) Token: 0x06004710 RID: 18192 RVA: 0x0018A708 File Offset: 0x00188908
			// (set) Token: 0x06004711 RID: 18193 RVA: 0x00017C36 File Offset: 0x00015E36
			public ValueTuple<ArchetypeID, int> reserveTuple
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass62_0.NativeFieldInfoPtr_reserveTuple);
					return new ValueTuple<ArchetypeID, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<ArchetypeID, int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass62_0.NativeFieldInfoPtr_reserveTuple), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<ArchetypeID, int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002EC8 RID: 11976
			private static readonly IntPtr NativeFieldInfoPtr_reserveTuple;

			// Token: 0x04002EC9 RID: 11977
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002ECA RID: 11978
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__0_Internal_Boolean_Entity_0;

			// Token: 0x04002ECB RID: 11979
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__1_Internal_Boolean_WormImperiumPlayable_0;
		}

		// Token: 0x020005BF RID: 1471
		[ObfuscatedName("worm.canis.entities.WormPlaymat+<>c__DisplayClass62_1")]
		public sealed class __c__DisplayClass62_1 : Object
		{
			// Token: 0x06004712 RID: 18194 RVA: 0x0018A738 File Offset: 0x00188938
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass62_1()
			{
				Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass62_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, "<>c__DisplayClass62_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass62_1>.NativeClassPtr);
				WormPlaymat.__c__DisplayClass62_1.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass62_1>.NativeClassPtr, "player");
				WormPlaymat.__c__DisplayClass62_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass62_1>.NativeClassPtr, 100664487);
				WormPlaymat.__c__DisplayClass62_1.NativeMethodInfoPtr___ctor_b__2_Internal_Boolean_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass62_1>.NativeClassPtr, 100664488);
			}

			// Token: 0x06004713 RID: 18195 RVA: 0x0018A7A0 File Offset: 0x001889A0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass62_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass62_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c__DisplayClass62_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004714 RID: 18196 RVA: 0x0018A7DC File Offset: 0x001889DC
			[CallerCount(0)]
			public unsafe bool __ctor_b__2(WormImperiumPlayable card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c__DisplayClass62_1.NativeMethodInfoPtr___ctor_b__2_Internal_Boolean_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004715 RID: 18197 RVA: 0x00017C64 File Offset: 0x00015E64
			public __c__DisplayClass62_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001115 RID: 4373
			// (get) Token: 0x06004716 RID: 18198 RVA: 0x0018A82C File Offset: 0x00188A2C
			// (set) Token: 0x06004717 RID: 18199 RVA: 0x00017C6D File Offset: 0x00015E6D
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass62_1.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass62_1.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002ECC RID: 11980
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04002ECD RID: 11981
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002ECE RID: 11982
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__2_Internal_Boolean_WormImperiumPlayable_0;
		}

		// Token: 0x020005C0 RID: 1472
		[ObfuscatedName("worm.canis.entities.WormPlaymat+<>c__DisplayClass77_0")]
		public sealed class __c__DisplayClass77_0 : Object
		{
			// Token: 0x06004718 RID: 18200 RVA: 0x0018A85C File Offset: 0x00188A5C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass77_0()
			{
				Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass77_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, "<>c__DisplayClass77_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass77_0>.NativeClassPtr);
				WormPlaymat.__c__DisplayClass77_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass77_0>.NativeClassPtr, "<>4__this");
				WormPlaymat.__c__DisplayClass77_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass77_0>.NativeClassPtr, "player");
				WormPlaymat.__c__DisplayClass77_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass77_0>.NativeClassPtr, 100664489);
				WormPlaymat.__c__DisplayClass77_0.NativeMethodInfoPtr__GetUsablePrePlayerTurnAbilities_b__1_Internal_Boolean_AgentAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass77_0>.NativeClassPtr, 100664490);
				WormPlaymat.__c__DisplayClass77_0.NativeMethodInfoPtr__GetUsablePrePlayerTurnAbilities_b__2_Internal_Boolean_ActivatedAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass77_0>.NativeClassPtr, 100664491);
				WormPlaymat.__c__DisplayClass77_0.NativeMethodInfoPtr__GetUsablePrePlayerTurnAbilities_b__3_Internal_Boolean_ActivatedAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass77_0>.NativeClassPtr, 100664492);
				WormPlaymat.__c__DisplayClass77_0.NativeMethodInfoPtr__GetUsablePrePlayerTurnAbilities_b__5_Internal_Boolean_DeferredAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass77_0>.NativeClassPtr, 100664493);
				WormPlaymat.__c__DisplayClass77_0.NativeMethodInfoPtr__GetUsablePrePlayerTurnAbilities_b__7_Internal_Boolean_DeferredAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass77_0>.NativeClassPtr, 100664494);
			}

			// Token: 0x06004719 RID: 18201 RVA: 0x0018A928 File Offset: 0x00188B28
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass77_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass77_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c__DisplayClass77_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600471A RID: 18202 RVA: 0x0018A964 File Offset: 0x00188B64
			[CallerCount(0)]
			public unsafe bool _GetUsablePrePlayerTurnAbilities_b__1(AgentAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c__DisplayClass77_0.NativeMethodInfoPtr__GetUsablePrePlayerTurnAbilities_b__1_Internal_Boolean_AgentAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600471B RID: 18203 RVA: 0x0018A9B4 File Offset: 0x00188BB4
			[CallerCount(0)]
			public unsafe bool _GetUsablePrePlayerTurnAbilities_b__2(ActivatedAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c__DisplayClass77_0.NativeMethodInfoPtr__GetUsablePrePlayerTurnAbilities_b__2_Internal_Boolean_ActivatedAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600471C RID: 18204 RVA: 0x0018AA04 File Offset: 0x00188C04
			[CallerCount(0)]
			public unsafe bool _GetUsablePrePlayerTurnAbilities_b__3(ActivatedAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c__DisplayClass77_0.NativeMethodInfoPtr__GetUsablePrePlayerTurnAbilities_b__3_Internal_Boolean_ActivatedAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600471D RID: 18205 RVA: 0x0018AA54 File Offset: 0x00188C54
			[CallerCount(0)]
			public unsafe bool _GetUsablePrePlayerTurnAbilities_b__5(DeferredAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c__DisplayClass77_0.NativeMethodInfoPtr__GetUsablePrePlayerTurnAbilities_b__5_Internal_Boolean_DeferredAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600471E RID: 18206 RVA: 0x0018AAA4 File Offset: 0x00188CA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43616, XrefRangeEnd = 43623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetUsablePrePlayerTurnAbilities_b__7(DeferredAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c__DisplayClass77_0.NativeMethodInfoPtr__GetUsablePrePlayerTurnAbilities_b__7_Internal_Boolean_DeferredAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600471F RID: 18207 RVA: 0x00017C8C File Offset: 0x00015E8C
			public __c__DisplayClass77_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001116 RID: 4374
			// (get) Token: 0x06004720 RID: 18208 RVA: 0x0018AAF4 File Offset: 0x00188CF4
			// (set) Token: 0x06004721 RID: 18209 RVA: 0x00017C95 File Offset: 0x00015E95
			public unsafe WormPlaymat __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass77_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlaymat>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass77_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001117 RID: 4375
			// (get) Token: 0x06004722 RID: 18210 RVA: 0x0018AB24 File Offset: 0x00188D24
			// (set) Token: 0x06004723 RID: 18211 RVA: 0x00017CB4 File Offset: 0x00015EB4
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass77_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass77_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002ECF RID: 11983
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002ED0 RID: 11984
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04002ED1 RID: 11985
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002ED2 RID: 11986
			private static readonly IntPtr NativeMethodInfoPtr__GetUsablePrePlayerTurnAbilities_b__1_Internal_Boolean_AgentAbility_0;

			// Token: 0x04002ED3 RID: 11987
			private static readonly IntPtr NativeMethodInfoPtr__GetUsablePrePlayerTurnAbilities_b__2_Internal_Boolean_ActivatedAbility_0;

			// Token: 0x04002ED4 RID: 11988
			private static readonly IntPtr NativeMethodInfoPtr__GetUsablePrePlayerTurnAbilities_b__3_Internal_Boolean_ActivatedAbility_0;

			// Token: 0x04002ED5 RID: 11989
			private static readonly IntPtr NativeMethodInfoPtr__GetUsablePrePlayerTurnAbilities_b__5_Internal_Boolean_DeferredAbility_0;

			// Token: 0x04002ED6 RID: 11990
			private static readonly IntPtr NativeMethodInfoPtr__GetUsablePrePlayerTurnAbilities_b__7_Internal_Boolean_DeferredAbility_0;
		}

		// Token: 0x020005C1 RID: 1473
		[ObfuscatedName("worm.canis.entities.WormPlaymat+<>c__DisplayClass78_0")]
		public sealed class __c__DisplayClass78_0 : Object
		{
			// Token: 0x06004724 RID: 18212 RVA: 0x0018AB54 File Offset: 0x00188D54
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass78_0()
			{
				Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass78_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, "<>c__DisplayClass78_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass78_0>.NativeClassPtr);
				WormPlaymat.__c__DisplayClass78_0.NativeFieldInfoPtr_turnType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass78_0>.NativeClassPtr, "turnType");
				WormPlaymat.__c__DisplayClass78_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass78_0>.NativeClassPtr, "player");
				WormPlaymat.__c__DisplayClass78_0.NativeFieldInfoPtr_hasSignet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass78_0>.NativeClassPtr, "hasSignet");
				WormPlaymat.__c__DisplayClass78_0.NativeFieldInfoPtr_customAbilityIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass78_0>.NativeClassPtr, "customAbilityIDs");
				WormPlaymat.__c__DisplayClass78_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass78_0>.NativeClassPtr, 100664495);
				WormPlaymat.__c__DisplayClass78_0.NativeMethodInfoPtr__GetAllDeferredAbilities_b__1_Internal_Boolean_DeferredAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass78_0>.NativeClassPtr, 100664496);
				WormPlaymat.__c__DisplayClass78_0.NativeMethodInfoPtr__GetAllDeferredAbilities_b__2_Internal_Boolean_PlayAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass78_0>.NativeClassPtr, 100664497);
				WormPlaymat.__c__DisplayClass78_0.NativeMethodInfoPtr__GetAllDeferredAbilities_b__3_Internal_Boolean_ActivatedAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass78_0>.NativeClassPtr, 100664498);
				WormPlaymat.__c__DisplayClass78_0.NativeMethodInfoPtr__GetAllDeferredAbilities_b__4_Internal_Boolean_DeferredAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass78_0>.NativeClassPtr, 100664499);
				WormPlaymat.__c__DisplayClass78_0.NativeMethodInfoPtr__GetAllDeferredAbilities_b__6_Internal_Boolean_DeferredAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass78_0>.NativeClassPtr, 100664500);
				WormPlaymat.__c__DisplayClass78_0.NativeMethodInfoPtr__GetAllDeferredAbilities_b__9_Internal_Boolean_DeferredAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass78_0>.NativeClassPtr, 100664501);
			}

			// Token: 0x06004725 RID: 18213 RVA: 0x0018AC5C File Offset: 0x00188E5C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass78_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass78_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c__DisplayClass78_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004726 RID: 18214 RVA: 0x0018AC98 File Offset: 0x00188E98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43623, XrefRangeEnd = 43636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAllDeferredAbilities_b__1(DeferredAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c__DisplayClass78_0.NativeMethodInfoPtr__GetAllDeferredAbilities_b__1_Internal_Boolean_DeferredAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004727 RID: 18215 RVA: 0x0018ACE8 File Offset: 0x00188EE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43636, XrefRangeEnd = 43637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAllDeferredAbilities_b__2(PlayAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c__DisplayClass78_0.NativeMethodInfoPtr__GetAllDeferredAbilities_b__2_Internal_Boolean_PlayAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004728 RID: 18216 RVA: 0x0018AD38 File Offset: 0x00188F38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43637, XrefRangeEnd = 43648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAllDeferredAbilities_b__3(ActivatedAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c__DisplayClass78_0.NativeMethodInfoPtr__GetAllDeferredAbilities_b__3_Internal_Boolean_ActivatedAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004729 RID: 18217 RVA: 0x0018AD88 File Offset: 0x00188F88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43648, XrefRangeEnd = 43664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAllDeferredAbilities_b__4(DeferredAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c__DisplayClass78_0.NativeMethodInfoPtr__GetAllDeferredAbilities_b__4_Internal_Boolean_DeferredAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600472A RID: 18218 RVA: 0x0018ADD8 File Offset: 0x00188FD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43664, XrefRangeEnd = 43666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAllDeferredAbilities_b__6(DeferredAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c__DisplayClass78_0.NativeMethodInfoPtr__GetAllDeferredAbilities_b__6_Internal_Boolean_DeferredAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600472B RID: 18219 RVA: 0x0018AE28 File Offset: 0x00189028
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43666, XrefRangeEnd = 43669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAllDeferredAbilities_b__9(DeferredAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c__DisplayClass78_0.NativeMethodInfoPtr__GetAllDeferredAbilities_b__9_Internal_Boolean_DeferredAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600472C RID: 18220 RVA: 0x00017CD3 File Offset: 0x00015ED3
			public __c__DisplayClass78_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001118 RID: 4376
			// (get) Token: 0x0600472D RID: 18221 RVA: 0x0018AE78 File Offset: 0x00189078
			// (set) Token: 0x0600472E RID: 18222 RVA: 0x00017CDC File Offset: 0x00015EDC
			public unsafe PlayerTurnTypes turnType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass78_0.NativeFieldInfoPtr_turnType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass78_0.NativeFieldInfoPtr_turnType)) = value;
				}
			}

			// Token: 0x17001119 RID: 4377
			// (get) Token: 0x0600472F RID: 18223 RVA: 0x0018AEA0 File Offset: 0x001890A0
			// (set) Token: 0x06004730 RID: 18224 RVA: 0x00017CF7 File Offset: 0x00015EF7
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass78_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass78_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700111A RID: 4378
			// (get) Token: 0x06004731 RID: 18225 RVA: 0x0018AED0 File Offset: 0x001890D0
			// (set) Token: 0x06004732 RID: 18226 RVA: 0x00017D16 File Offset: 0x00015F16
			public unsafe bool hasSignet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass78_0.NativeFieldInfoPtr_hasSignet);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass78_0.NativeFieldInfoPtr_hasSignet)) = value;
				}
			}

			// Token: 0x1700111B RID: 4379
			// (get) Token: 0x06004733 RID: 18227 RVA: 0x0018AEF8 File Offset: 0x001890F8
			// (set) Token: 0x06004734 RID: 18228 RVA: 0x00017D31 File Offset: 0x00015F31
			public unsafe List<AbilityID> customAbilityIDs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass78_0.NativeFieldInfoPtr_customAbilityIDs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AbilityID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass78_0.NativeFieldInfoPtr_customAbilityIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002ED7 RID: 11991
			private static readonly IntPtr NativeFieldInfoPtr_turnType;

			// Token: 0x04002ED8 RID: 11992
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04002ED9 RID: 11993
			private static readonly IntPtr NativeFieldInfoPtr_hasSignet;

			// Token: 0x04002EDA RID: 11994
			private static readonly IntPtr NativeFieldInfoPtr_customAbilityIDs;

			// Token: 0x04002EDB RID: 11995
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002EDC RID: 11996
			private static readonly IntPtr NativeMethodInfoPtr__GetAllDeferredAbilities_b__1_Internal_Boolean_DeferredAbility_0;

			// Token: 0x04002EDD RID: 11997
			private static readonly IntPtr NativeMethodInfoPtr__GetAllDeferredAbilities_b__2_Internal_Boolean_PlayAbility_0;

			// Token: 0x04002EDE RID: 11998
			private static readonly IntPtr NativeMethodInfoPtr__GetAllDeferredAbilities_b__3_Internal_Boolean_ActivatedAbility_0;

			// Token: 0x04002EDF RID: 11999
			private static readonly IntPtr NativeMethodInfoPtr__GetAllDeferredAbilities_b__4_Internal_Boolean_DeferredAbility_0;

			// Token: 0x04002EE0 RID: 12000
			private static readonly IntPtr NativeMethodInfoPtr__GetAllDeferredAbilities_b__6_Internal_Boolean_DeferredAbility_0;

			// Token: 0x04002EE1 RID: 12001
			private static readonly IntPtr NativeMethodInfoPtr__GetAllDeferredAbilities_b__9_Internal_Boolean_DeferredAbility_0;
		}

		// Token: 0x020005C2 RID: 1474
		[ObfuscatedName("worm.canis.entities.WormPlaymat+<>c__DisplayClass79_0")]
		public sealed class __c__DisplayClass79_0 : Object
		{
			// Token: 0x06004735 RID: 18229 RVA: 0x0018AF28 File Offset: 0x00189128
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass79_0()
			{
				Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass79_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, "<>c__DisplayClass79_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass79_0>.NativeClassPtr);
				WormPlaymat.__c__DisplayClass79_0.NativeFieldInfoPtr_turnType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass79_0>.NativeClassPtr, "turnType");
				WormPlaymat.__c__DisplayClass79_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass79_0>.NativeClassPtr, "<>4__this");
				WormPlaymat.__c__DisplayClass79_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass79_0>.NativeClassPtr, "player");
				WormPlaymat.__c__DisplayClass79_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass79_0>.NativeClassPtr, 100664502);
				WormPlaymat.__c__DisplayClass79_0.NativeMethodInfoPtr__GetUsableDeferredAbilities_b__1_Internal_Boolean_DeferredAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass79_0>.NativeClassPtr, 100664503);
				WormPlaymat.__c__DisplayClass79_0.NativeMethodInfoPtr__GetUsableDeferredAbilities_b__2_Internal_Boolean_PlayAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass79_0>.NativeClassPtr, 100664504);
				WormPlaymat.__c__DisplayClass79_0.NativeMethodInfoPtr__GetUsableDeferredAbilities_b__3_Internal_Boolean_ActivatedAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass79_0>.NativeClassPtr, 100664505);
				WormPlaymat.__c__DisplayClass79_0.NativeMethodInfoPtr__GetUsableDeferredAbilities_b__4_Internal_Boolean_DeferredAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass79_0>.NativeClassPtr, 100664506);
				WormPlaymat.__c__DisplayClass79_0.NativeMethodInfoPtr__GetUsableDeferredAbilities_b__9_Internal_Boolean_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass79_0>.NativeClassPtr, 100664507);
				WormPlaymat.__c__DisplayClass79_0.NativeMethodInfoPtr__GetUsableDeferredAbilities_b__11_Internal_Boolean_AcquireAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass79_0>.NativeClassPtr, 100664508);
				WormPlaymat.__c__DisplayClass79_0.NativeMethodInfoPtr__GetUsableDeferredAbilities_b__6_Internal_Boolean_DeferredAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass79_0>.NativeClassPtr, 100664509);
				WormPlaymat.__c__DisplayClass79_0.NativeMethodInfoPtr__GetUsableDeferredAbilities_b__8_Internal_Boolean_DeferredAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass79_0>.NativeClassPtr, 100664510);
			}

			// Token: 0x06004736 RID: 18230 RVA: 0x0018B044 File Offset: 0x00189244
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass79_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass79_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c__DisplayClass79_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004737 RID: 18231 RVA: 0x0018B080 File Offset: 0x00189280
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43669, XrefRangeEnd = 43674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetUsableDeferredAbilities_b__1(DeferredAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c__DisplayClass79_0.NativeMethodInfoPtr__GetUsableDeferredAbilities_b__1_Internal_Boolean_DeferredAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004738 RID: 18232 RVA: 0x0018B0D0 File Offset: 0x001892D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43674, XrefRangeEnd = 43676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetUsableDeferredAbilities_b__2(PlayAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c__DisplayClass79_0.NativeMethodInfoPtr__GetUsableDeferredAbilities_b__2_Internal_Boolean_PlayAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004739 RID: 18233 RVA: 0x0018B120 File Offset: 0x00189320
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43676, XrefRangeEnd = 43677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetUsableDeferredAbilities_b__3(ActivatedAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c__DisplayClass79_0.NativeMethodInfoPtr__GetUsableDeferredAbilities_b__3_Internal_Boolean_ActivatedAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600473A RID: 18234 RVA: 0x0018B170 File Offset: 0x00189370
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43677, XrefRangeEnd = 43682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetUsableDeferredAbilities_b__4(DeferredAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c__DisplayClass79_0.NativeMethodInfoPtr__GetUsableDeferredAbilities_b__4_Internal_Boolean_DeferredAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600473B RID: 18235 RVA: 0x0018B1C0 File Offset: 0x001893C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43682, XrefRangeEnd = 43710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetUsableDeferredAbilities_b__9(WormImperiumPlayable card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c__DisplayClass79_0.NativeMethodInfoPtr__GetUsableDeferredAbilities_b__9_Internal_Boolean_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600473C RID: 18236 RVA: 0x0018B210 File Offset: 0x00189410
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetUsableDeferredAbilities_b__11(AcquireAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c__DisplayClass79_0.NativeMethodInfoPtr__GetUsableDeferredAbilities_b__11_Internal_Boolean_AcquireAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600473D RID: 18237 RVA: 0x0018B260 File Offset: 0x00189460
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43710, XrefRangeEnd = 43715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetUsableDeferredAbilities_b__6(DeferredAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c__DisplayClass79_0.NativeMethodInfoPtr__GetUsableDeferredAbilities_b__6_Internal_Boolean_DeferredAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600473E RID: 18238 RVA: 0x0018B2B0 File Offset: 0x001894B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43715, XrefRangeEnd = 43720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetUsableDeferredAbilities_b__8(DeferredAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c__DisplayClass79_0.NativeMethodInfoPtr__GetUsableDeferredAbilities_b__8_Internal_Boolean_DeferredAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600473F RID: 18239 RVA: 0x00017D50 File Offset: 0x00015F50
			public __c__DisplayClass79_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700111C RID: 4380
			// (get) Token: 0x06004740 RID: 18240 RVA: 0x0018B300 File Offset: 0x00189500
			// (set) Token: 0x06004741 RID: 18241 RVA: 0x00017D59 File Offset: 0x00015F59
			public unsafe PlayerTurnTypes turnType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass79_0.NativeFieldInfoPtr_turnType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass79_0.NativeFieldInfoPtr_turnType)) = value;
				}
			}

			// Token: 0x1700111D RID: 4381
			// (get) Token: 0x06004742 RID: 18242 RVA: 0x0018B328 File Offset: 0x00189528
			// (set) Token: 0x06004743 RID: 18243 RVA: 0x00017D74 File Offset: 0x00015F74
			public unsafe WormPlaymat __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass79_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlaymat>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass79_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700111E RID: 4382
			// (get) Token: 0x06004744 RID: 18244 RVA: 0x0018B358 File Offset: 0x00189558
			// (set) Token: 0x06004745 RID: 18245 RVA: 0x00017D93 File Offset: 0x00015F93
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass79_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass79_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002EE2 RID: 12002
			private static readonly IntPtr NativeFieldInfoPtr_turnType;

			// Token: 0x04002EE3 RID: 12003
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002EE4 RID: 12004
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04002EE5 RID: 12005
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002EE6 RID: 12006
			private static readonly IntPtr NativeMethodInfoPtr__GetUsableDeferredAbilities_b__1_Internal_Boolean_DeferredAbility_0;

			// Token: 0x04002EE7 RID: 12007
			private static readonly IntPtr NativeMethodInfoPtr__GetUsableDeferredAbilities_b__2_Internal_Boolean_PlayAbility_0;

			// Token: 0x04002EE8 RID: 12008
			private static readonly IntPtr NativeMethodInfoPtr__GetUsableDeferredAbilities_b__3_Internal_Boolean_ActivatedAbility_0;

			// Token: 0x04002EE9 RID: 12009
			private static readonly IntPtr NativeMethodInfoPtr__GetUsableDeferredAbilities_b__4_Internal_Boolean_DeferredAbility_0;

			// Token: 0x04002EEA RID: 12010
			private static readonly IntPtr NativeMethodInfoPtr__GetUsableDeferredAbilities_b__9_Internal_Boolean_WormImperiumPlayable_0;

			// Token: 0x04002EEB RID: 12011
			private static readonly IntPtr NativeMethodInfoPtr__GetUsableDeferredAbilities_b__11_Internal_Boolean_AcquireAbility_0;

			// Token: 0x04002EEC RID: 12012
			private static readonly IntPtr NativeMethodInfoPtr__GetUsableDeferredAbilities_b__6_Internal_Boolean_DeferredAbility_0;

			// Token: 0x04002EED RID: 12013
			private static readonly IntPtr NativeMethodInfoPtr__GetUsableDeferredAbilities_b__8_Internal_Boolean_DeferredAbility_0;
		}

		// Token: 0x020005C3 RID: 1475
		[ObfuscatedName("worm.canis.entities.WormPlaymat+<>c__DisplayClass79_1")]
		public sealed class __c__DisplayClass79_1 : Object
		{
			// Token: 0x06004746 RID: 18246 RVA: 0x0018B388 File Offset: 0x00189588
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass79_1()
			{
				Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass79_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, "<>c__DisplayClass79_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass79_1>.NativeClassPtr);
				WormPlaymat.__c__DisplayClass79_1.NativeFieldInfoPtr_card = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass79_1>.NativeClassPtr, "card");
				WormPlaymat.__c__DisplayClass79_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass79_1>.NativeClassPtr, 100664511);
				WormPlaymat.__c__DisplayClass79_1.NativeMethodInfoPtr__GetUsableDeferredAbilities_b__12_Internal_Boolean_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass79_1>.NativeClassPtr, 100664512);
			}

			// Token: 0x06004747 RID: 18247 RVA: 0x0018B3F0 File Offset: 0x001895F0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass79_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass79_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c__DisplayClass79_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004748 RID: 18248 RVA: 0x0018B42C File Offset: 0x0018962C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43720, XrefRangeEnd = 43724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetUsableDeferredAbilities_b__12(Factions faction)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref faction;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c__DisplayClass79_1.NativeMethodInfoPtr__GetUsableDeferredAbilities_b__12_Internal_Boolean_Factions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004749 RID: 18249 RVA: 0x00017DB2 File Offset: 0x00015FB2
			public __c__DisplayClass79_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700111F RID: 4383
			// (get) Token: 0x0600474A RID: 18250 RVA: 0x0018B478 File Offset: 0x00189678
			// (set) Token: 0x0600474B RID: 18251 RVA: 0x00017DBB File Offset: 0x00015FBB
			public unsafe WormImperiumPlayable card
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass79_1.NativeFieldInfoPtr_card);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass79_1.NativeFieldInfoPtr_card), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002EEE RID: 12014
			private static readonly IntPtr NativeFieldInfoPtr_card;

			// Token: 0x04002EEF RID: 12015
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002EF0 RID: 12016
			private static readonly IntPtr NativeMethodInfoPtr__GetUsableDeferredAbilities_b__12_Internal_Boolean_Factions_0;
		}

		// Token: 0x020005C4 RID: 1476
		[ObfuscatedName("worm.canis.entities.WormPlaymat+<>c__DisplayClass82_0")]
		public sealed class __c__DisplayClass82_0 : Object
		{
			// Token: 0x0600474C RID: 18252 RVA: 0x0018B4A8 File Offset: 0x001896A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass82_0()
			{
				Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass82_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, "<>c__DisplayClass82_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass82_0>.NativeClassPtr);
				WormPlaymat.__c__DisplayClass82_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass82_0>.NativeClassPtr, "<>4__this");
				WormPlaymat.__c__DisplayClass82_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass82_0>.NativeClassPtr, "player");
				WormPlaymat.__c__DisplayClass82_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass82_0>.NativeClassPtr, 100664513);
				WormPlaymat.__c__DisplayClass82_0.NativeMethodInfoPtr__GetCustomTimingAbilities_b__0_Internal_Boolean_DeferredAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass82_0>.NativeClassPtr, 100664514);
				WormPlaymat.__c__DisplayClass82_0.NativeMethodInfoPtr__GetCustomTimingAbilities_b__2_Internal_Boolean_DeferredAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass82_0>.NativeClassPtr, 100664515);
				WormPlaymat.__c__DisplayClass82_0.NativeMethodInfoPtr__GetCustomTimingAbilities_b__6_Internal_Boolean_DeferredAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass82_0>.NativeClassPtr, 100664516);
				WormPlaymat.__c__DisplayClass82_0.NativeMethodInfoPtr__GetCustomTimingAbilities_b__4_Internal_Boolean_DeferredAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass82_0>.NativeClassPtr, 100664517);
			}

			// Token: 0x0600474D RID: 18253 RVA: 0x0018B560 File Offset: 0x00189760
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass82_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass82_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c__DisplayClass82_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600474E RID: 18254 RVA: 0x0018B59C File Offset: 0x0018979C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43724, XrefRangeEnd = 43725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetCustomTimingAbilities_b__0(DeferredAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c__DisplayClass82_0.NativeMethodInfoPtr__GetCustomTimingAbilities_b__0_Internal_Boolean_DeferredAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600474F RID: 18255 RVA: 0x0018B5EC File Offset: 0x001897EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43725, XrefRangeEnd = 43726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetCustomTimingAbilities_b__2(DeferredAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c__DisplayClass82_0.NativeMethodInfoPtr__GetCustomTimingAbilities_b__2_Internal_Boolean_DeferredAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004750 RID: 18256 RVA: 0x0018B63C File Offset: 0x0018983C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43726, XrefRangeEnd = 43727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetCustomTimingAbilities_b__6(DeferredAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c__DisplayClass82_0.NativeMethodInfoPtr__GetCustomTimingAbilities_b__6_Internal_Boolean_DeferredAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004751 RID: 18257 RVA: 0x0018B68C File Offset: 0x0018988C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43727, XrefRangeEnd = 43732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetCustomTimingAbilities_b__4(DeferredAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c__DisplayClass82_0.NativeMethodInfoPtr__GetCustomTimingAbilities_b__4_Internal_Boolean_DeferredAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004752 RID: 18258 RVA: 0x00017DDA File Offset: 0x00015FDA
			public __c__DisplayClass82_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001120 RID: 4384
			// (get) Token: 0x06004753 RID: 18259 RVA: 0x0018B6DC File Offset: 0x001898DC
			// (set) Token: 0x06004754 RID: 18260 RVA: 0x00017DE3 File Offset: 0x00015FE3
			public unsafe WormPlaymat __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass82_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlaymat>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass82_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001121 RID: 4385
			// (get) Token: 0x06004755 RID: 18261 RVA: 0x0018B70C File Offset: 0x0018990C
			// (set) Token: 0x06004756 RID: 18262 RVA: 0x00017E02 File Offset: 0x00016002
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass82_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass82_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002EF1 RID: 12017
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002EF2 RID: 12018
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04002EF3 RID: 12019
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002EF4 RID: 12020
			private static readonly IntPtr NativeMethodInfoPtr__GetCustomTimingAbilities_b__0_Internal_Boolean_DeferredAbility_0;

			// Token: 0x04002EF5 RID: 12021
			private static readonly IntPtr NativeMethodInfoPtr__GetCustomTimingAbilities_b__2_Internal_Boolean_DeferredAbility_0;

			// Token: 0x04002EF6 RID: 12022
			private static readonly IntPtr NativeMethodInfoPtr__GetCustomTimingAbilities_b__6_Internal_Boolean_DeferredAbility_0;

			// Token: 0x04002EF7 RID: 12023
			private static readonly IntPtr NativeMethodInfoPtr__GetCustomTimingAbilities_b__4_Internal_Boolean_DeferredAbility_0;
		}

		// Token: 0x020005C5 RID: 1477
		[ObfuscatedName("worm.canis.entities.WormPlaymat+<>c__DisplayClass83_0")]
		public sealed class __c__DisplayClass83_0 : Object
		{
			// Token: 0x06004757 RID: 18263 RVA: 0x0018B73C File Offset: 0x0018993C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass83_0()
			{
				Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass83_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, "<>c__DisplayClass83_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass83_0>.NativeClassPtr);
				WormPlaymat.__c__DisplayClass83_0.NativeFieldInfoPtr_turnType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass83_0>.NativeClassPtr, "turnType");
				WormPlaymat.__c__DisplayClass83_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass83_0>.NativeClassPtr, "<>4__this");
				WormPlaymat.__c__DisplayClass83_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass83_0>.NativeClassPtr, "player");
				WormPlaymat.__c__DisplayClass83_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass83_0>.NativeClassPtr, 100664518);
				WormPlaymat.__c__DisplayClass83_0.NativeMethodInfoPtr__GetUsableDelayedAbilities_b__1_Internal_Boolean_DeferredAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass83_0>.NativeClassPtr, 100664519);
			}

			// Token: 0x06004758 RID: 18264 RVA: 0x0018B7CC File Offset: 0x001899CC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass83_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass83_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c__DisplayClass83_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004759 RID: 18265 RVA: 0x0018B808 File Offset: 0x00189A08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43732, XrefRangeEnd = 43737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetUsableDelayedAbilities_b__1(DeferredAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c__DisplayClass83_0.NativeMethodInfoPtr__GetUsableDelayedAbilities_b__1_Internal_Boolean_DeferredAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600475A RID: 18266 RVA: 0x00017E21 File Offset: 0x00016021
			public __c__DisplayClass83_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001122 RID: 4386
			// (get) Token: 0x0600475B RID: 18267 RVA: 0x0018B858 File Offset: 0x00189A58
			// (set) Token: 0x0600475C RID: 18268 RVA: 0x00017E2A File Offset: 0x0001602A
			public unsafe PlayerTurnTypes turnType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass83_0.NativeFieldInfoPtr_turnType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass83_0.NativeFieldInfoPtr_turnType)) = value;
				}
			}

			// Token: 0x17001123 RID: 4387
			// (get) Token: 0x0600475D RID: 18269 RVA: 0x0018B880 File Offset: 0x00189A80
			// (set) Token: 0x0600475E RID: 18270 RVA: 0x00017E45 File Offset: 0x00016045
			public unsafe WormPlaymat __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass83_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlaymat>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass83_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001124 RID: 4388
			// (get) Token: 0x0600475F RID: 18271 RVA: 0x0018B8B0 File Offset: 0x00189AB0
			// (set) Token: 0x06004760 RID: 18272 RVA: 0x00017E64 File Offset: 0x00016064
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass83_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass83_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002EF8 RID: 12024
			private static readonly IntPtr NativeFieldInfoPtr_turnType;

			// Token: 0x04002EF9 RID: 12025
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002EFA RID: 12026
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04002EFB RID: 12027
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002EFC RID: 12028
			private static readonly IntPtr NativeMethodInfoPtr__GetUsableDelayedAbilities_b__1_Internal_Boolean_DeferredAbility_0;
		}

		// Token: 0x020005C6 RID: 1478
		[ObfuscatedName("worm.canis.entities.WormPlaymat+<>c__DisplayClass84_0")]
		public sealed class __c__DisplayClass84_0 : Object
		{
			// Token: 0x06004761 RID: 18273 RVA: 0x0018B8E0 File Offset: 0x00189AE0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass84_0()
			{
				Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass84_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, "<>c__DisplayClass84_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass84_0>.NativeClassPtr);
				WormPlaymat.__c__DisplayClass84_0.NativeFieldInfoPtr_intrigueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass84_0>.NativeClassPtr, "intrigueType");
				WormPlaymat.__c__DisplayClass84_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass84_0>.NativeClassPtr, "<>4__this");
				WormPlaymat.__c__DisplayClass84_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass84_0>.NativeClassPtr, "player");
				WormPlaymat.__c__DisplayClass84_0.NativeFieldInfoPtr_paramContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass84_0>.NativeClassPtr, "paramContext");
				WormPlaymat.__c__DisplayClass84_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass84_0>.NativeClassPtr, 100664520);
				WormPlaymat.__c__DisplayClass84_0.NativeMethodInfoPtr__GetUsableIntrigueAbilities_b__0_Internal_Boolean_WormPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass84_0>.NativeClassPtr, 100664521);
				WormPlaymat.__c__DisplayClass84_0.NativeMethodInfoPtr__GetUsableIntrigueAbilities_b__2_Internal_Boolean_PlayAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass84_0>.NativeClassPtr, 100664522);
			}

			// Token: 0x06004762 RID: 18274 RVA: 0x0018B998 File Offset: 0x00189B98
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass84_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass84_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c__DisplayClass84_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004763 RID: 18275 RVA: 0x0018B9D4 File Offset: 0x00189BD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43737, XrefRangeEnd = 43741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetUsableIntrigueAbilities_b__0(WormPlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c__DisplayClass84_0.NativeMethodInfoPtr__GetUsableIntrigueAbilities_b__0_Internal_Boolean_WormPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004764 RID: 18276 RVA: 0x0018BA24 File Offset: 0x00189C24
			[CallerCount(0)]
			public unsafe bool _GetUsableIntrigueAbilities_b__2(PlayAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c__DisplayClass84_0.NativeMethodInfoPtr__GetUsableIntrigueAbilities_b__2_Internal_Boolean_PlayAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004765 RID: 18277 RVA: 0x00017E83 File Offset: 0x00016083
			public __c__DisplayClass84_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001125 RID: 4389
			// (get) Token: 0x06004766 RID: 18278 RVA: 0x0018BA74 File Offset: 0x00189C74
			// (set) Token: 0x06004767 RID: 18279 RVA: 0x00017E8C File Offset: 0x0001608C
			public unsafe IntrigueTypes intrigueType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass84_0.NativeFieldInfoPtr_intrigueType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass84_0.NativeFieldInfoPtr_intrigueType)) = value;
				}
			}

			// Token: 0x17001126 RID: 4390
			// (get) Token: 0x06004768 RID: 18280 RVA: 0x0018BA9C File Offset: 0x00189C9C
			// (set) Token: 0x06004769 RID: 18281 RVA: 0x00017EA7 File Offset: 0x000160A7
			public unsafe WormPlaymat __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass84_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlaymat>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass84_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001127 RID: 4391
			// (get) Token: 0x0600476A RID: 18282 RVA: 0x0018BACC File Offset: 0x00189CCC
			// (set) Token: 0x0600476B RID: 18283 RVA: 0x00017EC6 File Offset: 0x000160C6
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass84_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass84_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001128 RID: 4392
			// (get) Token: 0x0600476C RID: 18284 RVA: 0x0018BAFC File Offset: 0x00189CFC
			// (set) Token: 0x0600476D RID: 18285 RVA: 0x00017EE5 File Offset: 0x000160E5
			public unsafe Context paramContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass84_0.NativeFieldInfoPtr_paramContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass84_0.NativeFieldInfoPtr_paramContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002EFD RID: 12029
			private static readonly IntPtr NativeFieldInfoPtr_intrigueType;

			// Token: 0x04002EFE RID: 12030
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002EFF RID: 12031
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04002F00 RID: 12032
			private static readonly IntPtr NativeFieldInfoPtr_paramContext;

			// Token: 0x04002F01 RID: 12033
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002F02 RID: 12034
			private static readonly IntPtr NativeMethodInfoPtr__GetUsableIntrigueAbilities_b__0_Internal_Boolean_WormPlayable_0;

			// Token: 0x04002F03 RID: 12035
			private static readonly IntPtr NativeMethodInfoPtr__GetUsableIntrigueAbilities_b__2_Internal_Boolean_PlayAbility_0;
		}

		// Token: 0x020005C7 RID: 1479
		[ObfuscatedName("worm.canis.entities.WormPlaymat+<>c__DisplayClass85_0")]
		public sealed class __c__DisplayClass85_0 : Object
		{
			// Token: 0x0600476E RID: 18286 RVA: 0x0018BB2C File Offset: 0x00189D2C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass85_0()
			{
				Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass85_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, "<>c__DisplayClass85_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass85_0>.NativeClassPtr);
				WormPlaymat.__c__DisplayClass85_0.NativeFieldInfoPtr_turnType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass85_0>.NativeClassPtr, "turnType");
				WormPlaymat.__c__DisplayClass85_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass85_0>.NativeClassPtr, "player");
				WormPlaymat.__c__DisplayClass85_0.NativeFieldInfoPtr_hasSignet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass85_0>.NativeClassPtr, "hasSignet");
				WormPlaymat.__c__DisplayClass85_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass85_0>.NativeClassPtr, 100664523);
				WormPlaymat.__c__DisplayClass85_0.NativeMethodInfoPtr__IsDoneWithActiveAgentArea_b__1_Internal_Boolean_DeferredAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass85_0>.NativeClassPtr, 100664524);
				WormPlaymat.__c__DisplayClass85_0.NativeMethodInfoPtr__IsDoneWithActiveAgentArea_b__2_Internal_Boolean_SignetAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass85_0>.NativeClassPtr, 100664525);
			}

			// Token: 0x0600476F RID: 18287 RVA: 0x0018BBD0 File Offset: 0x00189DD0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass85_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlaymat.__c__DisplayClass85_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c__DisplayClass85_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004770 RID: 18288 RVA: 0x0018BC0C File Offset: 0x00189E0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43741, XrefRangeEnd = 43747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _IsDoneWithActiveAgentArea_b__1(DeferredAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c__DisplayClass85_0.NativeMethodInfoPtr__IsDoneWithActiveAgentArea_b__1_Internal_Boolean_DeferredAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004771 RID: 18289 RVA: 0x0018BC5C File Offset: 0x00189E5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43747, XrefRangeEnd = 43748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _IsDoneWithActiveAgentArea_b__2(SignetAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat.__c__DisplayClass85_0.NativeMethodInfoPtr__IsDoneWithActiveAgentArea_b__2_Internal_Boolean_SignetAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004772 RID: 18290 RVA: 0x00017F04 File Offset: 0x00016104
			public __c__DisplayClass85_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001129 RID: 4393
			// (get) Token: 0x06004773 RID: 18291 RVA: 0x0018BCAC File Offset: 0x00189EAC
			// (set) Token: 0x06004774 RID: 18292 RVA: 0x00017F0D File Offset: 0x0001610D
			public unsafe PlayerTurnTypes turnType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass85_0.NativeFieldInfoPtr_turnType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass85_0.NativeFieldInfoPtr_turnType)) = value;
				}
			}

			// Token: 0x1700112A RID: 4394
			// (get) Token: 0x06004775 RID: 18293 RVA: 0x0018BCD4 File Offset: 0x00189ED4
			// (set) Token: 0x06004776 RID: 18294 RVA: 0x00017F28 File Offset: 0x00016128
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass85_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass85_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700112B RID: 4395
			// (get) Token: 0x06004777 RID: 18295 RVA: 0x0018BD04 File Offset: 0x00189F04
			// (set) Token: 0x06004778 RID: 18296 RVA: 0x00017F47 File Offset: 0x00016147
			public unsafe bool hasSignet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass85_0.NativeFieldInfoPtr_hasSignet);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat.__c__DisplayClass85_0.NativeFieldInfoPtr_hasSignet)) = value;
				}
			}

			// Token: 0x04002F04 RID: 12036
			private static readonly IntPtr NativeFieldInfoPtr_turnType;

			// Token: 0x04002F05 RID: 12037
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04002F06 RID: 12038
			private static readonly IntPtr NativeFieldInfoPtr_hasSignet;

			// Token: 0x04002F07 RID: 12039
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002F08 RID: 12040
			private static readonly IntPtr NativeMethodInfoPtr__IsDoneWithActiveAgentArea_b__1_Internal_Boolean_DeferredAbility_0;

			// Token: 0x04002F09 RID: 12041
			private static readonly IntPtr NativeMethodInfoPtr__IsDoneWithActiveAgentArea_b__2_Internal_Boolean_SignetAbility_0;
		}

		// Token: 0x020005C8 RID: 1480
		[ObfuscatedName("worm.canis.entities.WormPlaymat+<AddChildAbility>d__73")]
		public sealed class _AddChildAbility_d__73 : Object
		{
			// Token: 0x06004779 RID: 18297 RVA: 0x0018BD2C File Offset: 0x00189F2C
			// Note: this type is marked as 'beforefieldinit'.
			static _AddChildAbility_d__73()
			{
				Il2CppClassPointerStore<WormPlaymat._AddChildAbility_d__73>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, "<AddChildAbility>d__73");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlaymat._AddChildAbility_d__73>.NativeClassPtr);
				WormPlaymat._AddChildAbility_d__73.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat._AddChildAbility_d__73>.NativeClassPtr, "<>1__state");
				WormPlaymat._AddChildAbility_d__73.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat._AddChildAbility_d__73>.NativeClassPtr, "<>2__current");
				WormPlaymat._AddChildAbility_d__73.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat._AddChildAbility_d__73>.NativeClassPtr, "<>l__initialThreadId");
				WormPlaymat._AddChildAbility_d__73.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat._AddChildAbility_d__73>.NativeClassPtr, "<>4__this");
				WormPlaymat._AddChildAbility_d__73.NativeFieldInfoPtr_wormAbilityDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat._AddChildAbility_d__73>.NativeClassPtr, "wormAbilityDefinition");
				WormPlaymat._AddChildAbility_d__73.NativeFieldInfoPtr___3__wormAbilityDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat._AddChildAbility_d__73>.NativeClassPtr, "<>3__wormAbilityDefinition");
				WormPlaymat._AddChildAbility_d__73.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat._AddChildAbility_d__73>.NativeClassPtr, 100664526);
				WormPlaymat._AddChildAbility_d__73.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat._AddChildAbility_d__73>.NativeClassPtr, 100664527);
				WormPlaymat._AddChildAbility_d__73.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat._AddChildAbility_d__73>.NativeClassPtr, 100664528);
				WormPlaymat._AddChildAbility_d__73.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat._AddChildAbility_d__73>.NativeClassPtr, 100664529);
				WormPlaymat._AddChildAbility_d__73.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat._AddChildAbility_d__73>.NativeClassPtr, 100664530);
				WormPlaymat._AddChildAbility_d__73.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat._AddChildAbility_d__73>.NativeClassPtr, 100664531);
				WormPlaymat._AddChildAbility_d__73.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat._AddChildAbility_d__73>.NativeClassPtr, 100664532);
				WormPlaymat._AddChildAbility_d__73.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat._AddChildAbility_d__73>.NativeClassPtr, 100664533);
			}

			// Token: 0x0600477A RID: 18298 RVA: 0x0018BE70 File Offset: 0x0018A070
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AddChildAbility_d__73(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlaymat._AddChildAbility_d__73>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat._AddChildAbility_d__73.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600477B RID: 18299 RVA: 0x0018BEB8 File Offset: 0x0018A0B8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat._AddChildAbility_d__73.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600477C RID: 18300 RVA: 0x0018BEEC File Offset: 0x0018A0EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43748, XrefRangeEnd = 43761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat._AddChildAbility_d__73.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001132 RID: 4402
			// (get) Token: 0x0600477D RID: 18301 RVA: 0x0018BF28 File Offset: 0x0018A128
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat._AddChildAbility_d__73.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600477E RID: 18302 RVA: 0x0018BF68 File Offset: 0x0018A168
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43761, XrefRangeEnd = 43766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat._AddChildAbility_d__73.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001133 RID: 4403
			// (get) Token: 0x0600477F RID: 18303 RVA: 0x0018BF9C File Offset: 0x0018A19C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat._AddChildAbility_d__73.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004780 RID: 18304 RVA: 0x0018BFDC File Offset: 0x0018A1DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43766, XrefRangeEnd = 43775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat._AddChildAbility_d__73.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06004781 RID: 18305 RVA: 0x0018C01C File Offset: 0x0018A21C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat._AddChildAbility_d__73.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06004782 RID: 18306 RVA: 0x00017F62 File Offset: 0x00016162
			public _AddChildAbility_d__73(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700112C RID: 4396
			// (get) Token: 0x06004783 RID: 18307 RVA: 0x0018C05C File Offset: 0x0018A25C
			// (set) Token: 0x06004784 RID: 18308 RVA: 0x00017F6B File Offset: 0x0001616B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat._AddChildAbility_d__73.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat._AddChildAbility_d__73.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700112D RID: 4397
			// (get) Token: 0x06004785 RID: 18309 RVA: 0x0018C084 File Offset: 0x0018A284
			// (set) Token: 0x06004786 RID: 18310 RVA: 0x00017F86 File Offset: 0x00016186
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat._AddChildAbility_d__73.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat._AddChildAbility_d__73.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700112E RID: 4398
			// (get) Token: 0x06004787 RID: 18311 RVA: 0x0018C0B4 File Offset: 0x0018A2B4
			// (set) Token: 0x06004788 RID: 18312 RVA: 0x00017FA5 File Offset: 0x000161A5
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat._AddChildAbility_d__73.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat._AddChildAbility_d__73.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700112F RID: 4399
			// (get) Token: 0x06004789 RID: 18313 RVA: 0x0018C0DC File Offset: 0x0018A2DC
			// (set) Token: 0x0600478A RID: 18314 RVA: 0x00017FC0 File Offset: 0x000161C0
			public unsafe WormPlaymat __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat._AddChildAbility_d__73.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlaymat>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat._AddChildAbility_d__73.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001130 RID: 4400
			// (get) Token: 0x0600478B RID: 18315 RVA: 0x0018C10C File Offset: 0x0018A30C
			// (set) Token: 0x0600478C RID: 18316 RVA: 0x00017FDF File Offset: 0x000161DF
			public unsafe WormAbilityDefinition wormAbilityDefinition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat._AddChildAbility_d__73.NativeFieldInfoPtr_wormAbilityDefinition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAbilityDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat._AddChildAbility_d__73.NativeFieldInfoPtr_wormAbilityDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001131 RID: 4401
			// (get) Token: 0x0600478D RID: 18317 RVA: 0x0018C13C File Offset: 0x0018A33C
			// (set) Token: 0x0600478E RID: 18318 RVA: 0x00017FFE File Offset: 0x000161FE
			public unsafe WormAbilityDefinition __3__wormAbilityDefinition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat._AddChildAbility_d__73.NativeFieldInfoPtr___3__wormAbilityDefinition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAbilityDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat._AddChildAbility_d__73.NativeFieldInfoPtr___3__wormAbilityDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002F0A RID: 12042
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002F0B RID: 12043
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002F0C RID: 12044
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002F0D RID: 12045
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002F0E RID: 12046
			private static readonly IntPtr NativeFieldInfoPtr_wormAbilityDefinition;

			// Token: 0x04002F0F RID: 12047
			private static readonly IntPtr NativeFieldInfoPtr___3__wormAbilityDefinition;

			// Token: 0x04002F10 RID: 12048
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002F11 RID: 12049
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002F12 RID: 12050
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002F13 RID: 12051
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04002F14 RID: 12052
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002F15 RID: 12053
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002F16 RID: 12054
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04002F17 RID: 12055
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020005C9 RID: 1481
		[ObfuscatedName("worm.canis.entities.WormPlaymat+<UpdateConditionaEndgameVP>d__86")]
		public sealed class _UpdateConditionaEndgameVP_d__86 : Object
		{
			// Token: 0x0600478F RID: 18319 RVA: 0x0018C16C File Offset: 0x0018A36C
			// Note: this type is marked as 'beforefieldinit'.
			static _UpdateConditionaEndgameVP_d__86()
			{
				Il2CppClassPointerStore<WormPlaymat._UpdateConditionaEndgameVP_d__86>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlaymat>.NativeClassPtr, "<UpdateConditionaEndgameVP>d__86");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlaymat._UpdateConditionaEndgameVP_d__86>.NativeClassPtr);
				WormPlaymat._UpdateConditionaEndgameVP_d__86.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat._UpdateConditionaEndgameVP_d__86>.NativeClassPtr, "<>1__state");
				WormPlaymat._UpdateConditionaEndgameVP_d__86.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat._UpdateConditionaEndgameVP_d__86>.NativeClassPtr, "<>2__current");
				WormPlaymat._UpdateConditionaEndgameVP_d__86.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat._UpdateConditionaEndgameVP_d__86>.NativeClassPtr, "<>l__initialThreadId");
				WormPlaymat._UpdateConditionaEndgameVP_d__86.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat._UpdateConditionaEndgameVP_d__86>.NativeClassPtr, "<>4__this");
				WormPlaymat._UpdateConditionaEndgameVP_d__86.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymat._UpdateConditionaEndgameVP_d__86>.NativeClassPtr, "<>7__wrap1");
				WormPlaymat._UpdateConditionaEndgameVP_d__86.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat._UpdateConditionaEndgameVP_d__86>.NativeClassPtr, 100664534);
				WormPlaymat._UpdateConditionaEndgameVP_d__86.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat._UpdateConditionaEndgameVP_d__86>.NativeClassPtr, 100664535);
				WormPlaymat._UpdateConditionaEndgameVP_d__86.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat._UpdateConditionaEndgameVP_d__86>.NativeClassPtr, 100664536);
				WormPlaymat._UpdateConditionaEndgameVP_d__86.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat._UpdateConditionaEndgameVP_d__86>.NativeClassPtr, 100664537);
				WormPlaymat._UpdateConditionaEndgameVP_d__86.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat._UpdateConditionaEndgameVP_d__86>.NativeClassPtr, 100664538);
				WormPlaymat._UpdateConditionaEndgameVP_d__86.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat._UpdateConditionaEndgameVP_d__86>.NativeClassPtr, 100664539);
				WormPlaymat._UpdateConditionaEndgameVP_d__86.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat._UpdateConditionaEndgameVP_d__86>.NativeClassPtr, 100664540);
				WormPlaymat._UpdateConditionaEndgameVP_d__86.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat._UpdateConditionaEndgameVP_d__86>.NativeClassPtr, 100664541);
				WormPlaymat._UpdateConditionaEndgameVP_d__86.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymat._UpdateConditionaEndgameVP_d__86>.NativeClassPtr, 100664542);
			}

			// Token: 0x06004790 RID: 18320 RVA: 0x0018C2B0 File Offset: 0x0018A4B0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _UpdateConditionaEndgameVP_d__86(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlaymat._UpdateConditionaEndgameVP_d__86>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat._UpdateConditionaEndgameVP_d__86.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004791 RID: 18321 RVA: 0x0018C2F8 File Offset: 0x0018A4F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43775, XrefRangeEnd = 43780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat._UpdateConditionaEndgameVP_d__86.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004792 RID: 18322 RVA: 0x0018C32C File Offset: 0x0018A52C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43780, XrefRangeEnd = 43939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat._UpdateConditionaEndgameVP_d__86.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004793 RID: 18323 RVA: 0x0018C368 File Offset: 0x0018A568
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43939, XrefRangeEnd = 43942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat._UpdateConditionaEndgameVP_d__86.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001139 RID: 4409
			// (get) Token: 0x06004794 RID: 18324 RVA: 0x0018C39C File Offset: 0x0018A59C
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat._UpdateConditionaEndgameVP_d__86.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06004795 RID: 18325 RVA: 0x0018C3DC File Offset: 0x0018A5DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43942, XrefRangeEnd = 43947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat._UpdateConditionaEndgameVP_d__86.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700113A RID: 4410
			// (get) Token: 0x06004796 RID: 18326 RVA: 0x0018C410 File Offset: 0x0018A610
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat._UpdateConditionaEndgameVP_d__86.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004797 RID: 18327 RVA: 0x0018C450 File Offset: 0x0018A650
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43947, XrefRangeEnd = 43949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat._UpdateConditionaEndgameVP_d__86.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06004798 RID: 18328 RVA: 0x0018C490 File Offset: 0x0018A690
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymat._UpdateConditionaEndgameVP_d__86.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06004799 RID: 18329 RVA: 0x0001801D File Offset: 0x0001621D
			public _UpdateConditionaEndgameVP_d__86(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001134 RID: 4404
			// (get) Token: 0x0600479A RID: 18330 RVA: 0x0018C4D0 File Offset: 0x0018A6D0
			// (set) Token: 0x0600479B RID: 18331 RVA: 0x00018026 File Offset: 0x00016226
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat._UpdateConditionaEndgameVP_d__86.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat._UpdateConditionaEndgameVP_d__86.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001135 RID: 4405
			// (get) Token: 0x0600479C RID: 18332 RVA: 0x0018C4F8 File Offset: 0x0018A6F8
			// (set) Token: 0x0600479D RID: 18333 RVA: 0x00018041 File Offset: 0x00016241
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat._UpdateConditionaEndgameVP_d__86.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat._UpdateConditionaEndgameVP_d__86.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001136 RID: 4406
			// (get) Token: 0x0600479E RID: 18334 RVA: 0x0018C528 File Offset: 0x0018A728
			// (set) Token: 0x0600479F RID: 18335 RVA: 0x00018060 File Offset: 0x00016260
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat._UpdateConditionaEndgameVP_d__86.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat._UpdateConditionaEndgameVP_d__86.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001137 RID: 4407
			// (get) Token: 0x060047A0 RID: 18336 RVA: 0x0018C550 File Offset: 0x0018A750
			// (set) Token: 0x060047A1 RID: 18337 RVA: 0x0001807B File Offset: 0x0001627B
			public unsafe WormPlaymat __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat._UpdateConditionaEndgameVP_d__86.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlaymat>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat._UpdateConditionaEndgameVP_d__86.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001138 RID: 4408
			// (get) Token: 0x060047A2 RID: 18338 RVA: 0x0018C580 File Offset: 0x0018A780
			// (set) Token: 0x060047A3 RID: 18339 RVA: 0x0001809A File Offset: 0x0001629A
			public List<WormPlayable>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat._UpdateConditionaEndgameVP_d__86.NativeFieldInfoPtr___7__wrap1);
					return new List<WormPlayable>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<WormPlayable>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymat._UpdateConditionaEndgameVP_d__86.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<WormPlayable>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002F18 RID: 12056
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002F19 RID: 12057
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002F1A RID: 12058
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002F1B RID: 12059
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002F1C RID: 12060
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04002F1D RID: 12061
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002F1E RID: 12062
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002F1F RID: 12063
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002F20 RID: 12064
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04002F21 RID: 12065
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04002F22 RID: 12066
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002F23 RID: 12067
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002F24 RID: 12068
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04002F25 RID: 12069
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
