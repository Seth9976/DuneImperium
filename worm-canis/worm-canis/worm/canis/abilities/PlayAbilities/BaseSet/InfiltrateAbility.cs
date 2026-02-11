using System;
using Canis;
using Canis.actions;
using Canis.context;
using Canis.entities;
using Canis.entities.ai;
using Canis.gameLogs;
using Canis.messages;
using Canis.utils.ids;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.actions.cost;
using worm.canis.ai;
using worm.canis.ai.choices;
using worm.canis.data.enums;
using worm.canis.entities;

namespace worm.canis.abilities.PlayAbilities.BaseSet
{
	// Token: 0x02000485 RID: 1157
	public class InfiltrateAbility : IntrigueAbility
	{
		// Token: 0x06003378 RID: 13176 RVA: 0x001338B0 File Offset: 0x00131AB0
		// Note: this type is marked as 'beforefieldinit'.
		static InfiltrateAbility()
		{
			Il2CppClassPointerStore<InfiltrateAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.PlayAbilities.BaseSet", "InfiltrateAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InfiltrateAbility>.NativeClassPtr);
			InfiltrateAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfiltrateAbility>.NativeClassPtr, "AbilityName");
			InfiltrateAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfiltrateAbility>.NativeClassPtr, "AbilityID");
			InfiltrateAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiltrateAbility>.NativeClassPtr, 100679373);
			InfiltrateAbility.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiltrateAbility>.NativeClassPtr, 100679374);
			InfiltrateAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiltrateAbility>.NativeClassPtr, 100679375);
			InfiltrateAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiltrateAbility>.NativeClassPtr, 100679376);
			InfiltrateAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiltrateAbility>.NativeClassPtr, 100679377);
			InfiltrateAbility.NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiltrateAbility>.NativeClassPtr, 100679378);
			InfiltrateAbility.NativeMethodInfoPtr_Undo_Public_Virtual_IEnumerable_1_Action_UndoNode_PlayerEntity_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiltrateAbility>.NativeClassPtr, 100679379);
			InfiltrateAbility.NativeMethodInfoPtr_GetUnusualSelections_Public_Virtual_List_1_ValueTuple_2_LocalizableTextVariables_List_1_EntityID_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiltrateAbility>.NativeClassPtr, 100679380);
			InfiltrateAbility.NativeMethodInfoPtr_ShowHinting_Public_Virtual_Boolean_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiltrateAbility>.NativeClassPtr, 100679381);
			InfiltrateAbility.NativeMethodInfoPtr_IsBadIntrigue_Public_Virtual_Boolean_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiltrateAbility>.NativeClassPtr, 100679382);
			InfiltrateAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiltrateAbility>.NativeClassPtr, 100679383);
		}

		// Token: 0x06003379 RID: 13177 RVA: 0x001339E4 File Offset: 0x00131BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235188, XrefRangeEnd = 235192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InfiltrateAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x0600337A RID: 13178 RVA: 0x00133A30 File Offset: 0x00131C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235192, XrefRangeEnd = 235198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override GameLogBuilder MakeGameLogBuilder(IHasGameLogs hasGameLogs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hasGameLogs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InfiltrateAbility.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x0600337B RID: 13179 RVA: 0x00133A8C File Offset: 0x00131C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235198, XrefRangeEnd = 235201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InfiltrateAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InfiltrateAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InfiltrateAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600337C RID: 13180 RVA: 0x00133AD8 File Offset: 0x00131CD8
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 215283, RefRangeEnd = 215298, XrefRangeStart = 215283, XrefRangeEnd = 215298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InfiltrateAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InfiltrateAbility>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InfiltrateAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600337D RID: 13181 RVA: 0x00133B48 File Offset: 0x00131D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235201, XrefRangeEnd = 235205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override CostAction Cost(Match match, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InfiltrateAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x0600337E RID: 13182 RVA: 0x00133BB8 File Offset: 0x00131DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235205, XrefRangeEnd = 235213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> RunImmediateEffects(WormActiveAbility activeAbility, WormMatch match, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activeAbility);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InfiltrateAbility.NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x0600337F RID: 13183 RVA: 0x00133C38 File Offset: 0x00131E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235213, XrefRangeEnd = 235220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> Undo(UndoNode node, PlayerEntity player, Match match, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InfiltrateAbility.NativeMethodInfoPtr_Undo_Public_Virtual_IEnumerable_1_Action_UndoNode_PlayerEntity_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06003380 RID: 13184 RVA: 0x00133CCC File Offset: 0x00131ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235220, XrefRangeEnd = 235254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override List<ValueTuple<LocalizableTextVariables, List<EntityID>>> GetUnusualSelections(WormMatch match, WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InfiltrateAbility.NativeMethodInfoPtr_GetUnusualSelections_Public_Virtual_List_1_ValueTuple_2_LocalizableTextVariables_List_1_EntityID_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<LocalizableTextVariables, List<EntityID>>>>(intPtr3) : null;
		}

		// Token: 0x06003381 RID: 13185 RVA: 0x00133D3C File Offset: 0x00131F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235254, XrefRangeEnd = 235275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShowHinting(WormMatch match, WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InfiltrateAbility.NativeMethodInfoPtr_ShowHinting_Public_Virtual_Boolean_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003382 RID: 13186 RVA: 0x00133DA8 File Offset: 0x00131FA8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsBadIntrigue(WormMatch match, WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InfiltrateAbility.NativeMethodInfoPtr_IsBadIntrigue_Public_Virtual_Boolean_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003383 RID: 13187 RVA: 0x00133E14 File Offset: 0x00132014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235275, XrefRangeEnd = 235469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WormAIChoice Evaluate(WormAIChoiceContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InfiltrateAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormAIChoice>(intPtr3) : null;
			}
		}

		// Token: 0x06003384 RID: 13188 RVA: 0x00011C21 File Offset: 0x0000FE21
		public InfiltrateAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x06003385 RID: 13189 RVA: 0x00133E70 File Offset: 0x00132070
		// (set) Token: 0x06003386 RID: 13190 RVA: 0x00011C2A File Offset: 0x0000FE2A
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InfiltrateAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InfiltrateAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x06003387 RID: 13191 RVA: 0x00133E90 File Offset: 0x00132090
		// (set) Token: 0x06003388 RID: 13192 RVA: 0x00011C3C File Offset: 0x0000FE3C
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InfiltrateAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InfiltrateAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002173 RID: 8563
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04002174 RID: 8564
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04002175 RID: 8565
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04002176 RID: 8566
		private static readonly IntPtr NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0;

		// Token: 0x04002177 RID: 8567
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04002178 RID: 8568
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04002179 RID: 8569
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0;

		// Token: 0x0400217A RID: 8570
		private static readonly IntPtr NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x0400217B RID: 8571
		private static readonly IntPtr NativeMethodInfoPtr_Undo_Public_Virtual_IEnumerable_1_Action_UndoNode_PlayerEntity_Match_Context_0;

		// Token: 0x0400217C RID: 8572
		private static readonly IntPtr NativeMethodInfoPtr_GetUnusualSelections_Public_Virtual_List_1_ValueTuple_2_LocalizableTextVariables_List_1_EntityID_WormMatch_WormPlayer_0;

		// Token: 0x0400217D RID: 8573
		private static readonly IntPtr NativeMethodInfoPtr_ShowHinting_Public_Virtual_Boolean_WormMatch_WormPlayer_0;

		// Token: 0x0400217E RID: 8574
		private static readonly IntPtr NativeMethodInfoPtr_IsBadIntrigue_Public_Virtual_Boolean_WormMatch_WormPlayer_0;

		// Token: 0x0400217F RID: 8575
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0;

		// Token: 0x02000B05 RID: 2821
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.InfiltrateAbility+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600B25F RID: 45663 RVA: 0x002CE020 File Offset: 0x002CC220
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<InfiltrateAbility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InfiltrateAbility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InfiltrateAbility.__c>.NativeClassPtr);
				InfiltrateAbility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfiltrateAbility.__c>.NativeClassPtr, "<>9");
				InfiltrateAbility.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfiltrateAbility.__c>.NativeClassPtr, "<>9__12_0");
				InfiltrateAbility.__c.NativeFieldInfoPtr___9__12_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfiltrateAbility.__c>.NativeClassPtr, "<>9__12_3");
				InfiltrateAbility.__c.NativeFieldInfoPtr___9__12_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfiltrateAbility.__c>.NativeClassPtr, "<>9__12_5");
				InfiltrateAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiltrateAbility.__c>.NativeClassPtr, 100679386);
				InfiltrateAbility.__c.NativeMethodInfoPtr__Evaluate_b__12_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiltrateAbility.__c>.NativeClassPtr, 100679387);
				InfiltrateAbility.__c.NativeMethodInfoPtr__Evaluate_b__12_3_Internal_AIValueSummer_1_Double_AIValueSummer_1_Double_AIValueSummer_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiltrateAbility.__c>.NativeClassPtr, 100679388);
				InfiltrateAbility.__c.NativeMethodInfoPtr__Evaluate_b__12_5_Internal_AIValueSummer_1_Double_AIValueSummer_1_Double_AIValueSummer_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiltrateAbility.__c>.NativeClassPtr, 100679389);
			}

			// Token: 0x0600B260 RID: 45664 RVA: 0x002CE0EC File Offset: 0x002CC2EC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InfiltrateAbility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InfiltrateAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B261 RID: 45665 RVA: 0x002CE128 File Offset: 0x002CC328
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235067, XrefRangeEnd = 235076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Evaluate_b__12_0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InfiltrateAbility.__c.NativeMethodInfoPtr__Evaluate_b__12_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600B262 RID: 45666 RVA: 0x002CE178 File Offset: 0x002CC378
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235076, XrefRangeEnd = 235079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AIValueSummer<double> _Evaluate_b__12_3(AIValueSummer<double> a, AIValueSummer<double> b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InfiltrateAbility.__c.NativeMethodInfoPtr__Evaluate_b__12_3_Internal_AIValueSummer_1_Double_AIValueSummer_1_Double_AIValueSummer_1_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
			}

			// Token: 0x0600B263 RID: 45667 RVA: 0x002CE1DC File Offset: 0x002CC3DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235079, XrefRangeEnd = 235082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AIValueSummer<double> _Evaluate_b__12_5(AIValueSummer<double> a, AIValueSummer<double> b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InfiltrateAbility.__c.NativeMethodInfoPtr__Evaluate_b__12_5_Internal_AIValueSummer_1_Double_AIValueSummer_1_Double_AIValueSummer_1_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
			}

			// Token: 0x0600B264 RID: 45668 RVA: 0x00051F6D File Offset: 0x0005016D
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170036A5 RID: 13989
			// (get) Token: 0x0600B265 RID: 45669 RVA: 0x002CE240 File Offset: 0x002CC440
			// (set) Token: 0x0600B266 RID: 45670 RVA: 0x00051F76 File Offset: 0x00050176
			public unsafe static InfiltrateAbility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InfiltrateAbility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InfiltrateAbility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InfiltrateAbility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036A6 RID: 13990
			// (get) Token: 0x0600B267 RID: 45671 RVA: 0x002CE268 File Offset: 0x002CC468
			// (set) Token: 0x0600B268 RID: 45672 RVA: 0x00051F88 File Offset: 0x00050188
			public unsafe static Func<Entity, bool> __9__12_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InfiltrateAbility.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InfiltrateAbility.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036A7 RID: 13991
			// (get) Token: 0x0600B269 RID: 45673 RVA: 0x002CE290 File Offset: 0x002CC490
			// (set) Token: 0x0600B26A RID: 45674 RVA: 0x00051F9A File Offset: 0x0005019A
			public unsafe static Func<AIValueSummer<double>, AIValueSummer<double>, AIValueSummer<double>> __9__12_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InfiltrateAbility.__c.NativeFieldInfoPtr___9__12_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AIValueSummer<double>, AIValueSummer<double>, AIValueSummer<double>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InfiltrateAbility.__c.NativeFieldInfoPtr___9__12_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036A8 RID: 13992
			// (get) Token: 0x0600B26B RID: 45675 RVA: 0x002CE2B8 File Offset: 0x002CC4B8
			// (set) Token: 0x0600B26C RID: 45676 RVA: 0x00051FAC File Offset: 0x000501AC
			public unsafe static Func<AIValueSummer<double>, AIValueSummer<double>, AIValueSummer<double>> __9__12_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InfiltrateAbility.__c.NativeFieldInfoPtr___9__12_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AIValueSummer<double>, AIValueSummer<double>, AIValueSummer<double>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InfiltrateAbility.__c.NativeFieldInfoPtr___9__12_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007079 RID: 28793
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400707A RID: 28794
			private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x0400707B RID: 28795
			private static readonly IntPtr NativeFieldInfoPtr___9__12_3;

			// Token: 0x0400707C RID: 28796
			private static readonly IntPtr NativeFieldInfoPtr___9__12_5;

			// Token: 0x0400707D RID: 28797
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400707E RID: 28798
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__12_0_Internal_Boolean_Entity_0;

			// Token: 0x0400707F RID: 28799
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__12_3_Internal_AIValueSummer_1_Double_AIValueSummer_1_Double_AIValueSummer_1_Double_0;

			// Token: 0x04007080 RID: 28800
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__12_5_Internal_AIValueSummer_1_Double_AIValueSummer_1_Double_AIValueSummer_1_Double_0;
		}

		// Token: 0x02000B06 RID: 2822
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.InfiltrateAbility+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Object
		{
			// Token: 0x0600B26D RID: 45677 RVA: 0x002CE2E0 File Offset: 0x002CC4E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<InfiltrateAbility.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InfiltrateAbility>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InfiltrateAbility.__c__DisplayClass10_0>.NativeClassPtr);
				InfiltrateAbility.__c__DisplayClass10_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfiltrateAbility.__c__DisplayClass10_0>.NativeClassPtr, "player");
				InfiltrateAbility.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiltrateAbility.__c__DisplayClass10_0>.NativeClassPtr, 100679390);
				InfiltrateAbility.__c__DisplayClass10_0.NativeMethodInfoPtr__ShowHinting_b__0_Internal_Boolean_WormAgent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiltrateAbility.__c__DisplayClass10_0>.NativeClassPtr, 100679391);
			}

			// Token: 0x0600B26E RID: 45678 RVA: 0x002CE348 File Offset: 0x002CC548
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InfiltrateAbility.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InfiltrateAbility.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B26F RID: 45679 RVA: 0x002CE384 File Offset: 0x002CC584
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235082, XrefRangeEnd = 235084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ShowHinting_b__0(WormAgent _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InfiltrateAbility.__c__DisplayClass10_0.NativeMethodInfoPtr__ShowHinting_b__0_Internal_Boolean_WormAgent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600B270 RID: 45680 RVA: 0x00051FBE File Offset: 0x000501BE
			public __c__DisplayClass10_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170036A9 RID: 13993
			// (get) Token: 0x0600B271 RID: 45681 RVA: 0x002CE3D4 File Offset: 0x002CC5D4
			// (set) Token: 0x0600B272 RID: 45682 RVA: 0x00051FC7 File Offset: 0x000501C7
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility.__c__DisplayClass10_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility.__c__DisplayClass10_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007081 RID: 28801
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04007082 RID: 28802
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007083 RID: 28803
			private static readonly IntPtr NativeMethodInfoPtr__ShowHinting_b__0_Internal_Boolean_WormAgent_0;
		}

		// Token: 0x02000B07 RID: 2823
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.InfiltrateAbility+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Object
		{
			// Token: 0x0600B273 RID: 45683 RVA: 0x002CE404 File Offset: 0x002CC604
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<InfiltrateAbility.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InfiltrateAbility>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InfiltrateAbility.__c__DisplayClass12_0>.NativeClassPtr);
				InfiltrateAbility.__c__DisplayClass12_0.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfiltrateAbility.__c__DisplayClass12_0>.NativeClassPtr, "context");
				InfiltrateAbility.__c__DisplayClass12_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfiltrateAbility.__c__DisplayClass12_0>.NativeClassPtr, "<>9__2");
				InfiltrateAbility.__c__DisplayClass12_0.NativeFieldInfoPtr___9__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfiltrateAbility.__c__DisplayClass12_0>.NativeClassPtr, "<>9__4");
				InfiltrateAbility.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiltrateAbility.__c__DisplayClass12_0>.NativeClassPtr, 100679392);
				InfiltrateAbility.__c__DisplayClass12_0.NativeMethodInfoPtr__Evaluate_b__2_Internal_AIValueSummer_1_Double_AgentAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiltrateAbility.__c__DisplayClass12_0>.NativeClassPtr, 100679393);
				InfiltrateAbility.__c__DisplayClass12_0.NativeMethodInfoPtr__Evaluate_b__4_Internal_AIValueSummer_1_Double_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiltrateAbility.__c__DisplayClass12_0>.NativeClassPtr, 100679394);
			}

			// Token: 0x0600B274 RID: 45684 RVA: 0x002CE4A8 File Offset: 0x002CC6A8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InfiltrateAbility.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InfiltrateAbility.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B275 RID: 45685 RVA: 0x002CE4E4 File Offset: 0x002CC6E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235084, XrefRangeEnd = 235088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AIValueSummer<double> _Evaluate_b__2(AgentAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InfiltrateAbility.__c__DisplayClass12_0.NativeMethodInfoPtr__Evaluate_b__2_Internal_AIValueSummer_1_Double_AgentAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
				}
			}

			// Token: 0x0600B276 RID: 45686 RVA: 0x002CE534 File Offset: 0x002CC734
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235088, XrefRangeEnd = 235092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AIValueSummer<double> _Evaluate_b__4(WormAbilityDefinition _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InfiltrateAbility.__c__DisplayClass12_0.NativeMethodInfoPtr__Evaluate_b__4_Internal_AIValueSummer_1_Double_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
				}
			}

			// Token: 0x0600B277 RID: 45687 RVA: 0x00051FE6 File Offset: 0x000501E6
			public __c__DisplayClass12_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170036AA RID: 13994
			// (get) Token: 0x0600B278 RID: 45688 RVA: 0x002CE584 File Offset: 0x002CC784
			// (set) Token: 0x0600B279 RID: 45689 RVA: 0x00051FEF File Offset: 0x000501EF
			public unsafe WormAIChoiceContext context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility.__c__DisplayClass12_0.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAIChoiceContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility.__c__DisplayClass12_0.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036AB RID: 13995
			// (get) Token: 0x0600B27A RID: 45690 RVA: 0x002CE5B4 File Offset: 0x002CC7B4
			// (set) Token: 0x0600B27B RID: 45691 RVA: 0x0005200E File Offset: 0x0005020E
			public unsafe Func<AgentAbility, AIValueSummer<double>> __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility.__c__DisplayClass12_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AgentAbility, AIValueSummer<double>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility.__c__DisplayClass12_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036AC RID: 13996
			// (get) Token: 0x0600B27C RID: 45692 RVA: 0x002CE5E4 File Offset: 0x002CC7E4
			// (set) Token: 0x0600B27D RID: 45693 RVA: 0x0005202D File Offset: 0x0005022D
			public unsafe Func<WormAbilityDefinition, AIValueSummer<double>> __9__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility.__c__DisplayClass12_0.NativeFieldInfoPtr___9__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormAbilityDefinition, AIValueSummer<double>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility.__c__DisplayClass12_0.NativeFieldInfoPtr___9__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007084 RID: 28804
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04007085 RID: 28805
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x04007086 RID: 28806
			private static readonly IntPtr NativeFieldInfoPtr___9__4;

			// Token: 0x04007087 RID: 28807
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007088 RID: 28808
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__2_Internal_AIValueSummer_1_Double_AgentAbility_0;

			// Token: 0x04007089 RID: 28809
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__4_Internal_AIValueSummer_1_Double_WormAbilityDefinition_0;
		}

		// Token: 0x02000B08 RID: 2824
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.InfiltrateAbility+<>c__DisplayClass12_1")]
		public sealed class __c__DisplayClass12_1 : Object
		{
			// Token: 0x0600B27E RID: 45694 RVA: 0x002CE614 File Offset: 0x002CC814
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_1()
			{
				Il2CppClassPointerStore<InfiltrateAbility.__c__DisplayClass12_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InfiltrateAbility>.NativeClassPtr, "<>c__DisplayClass12_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InfiltrateAbility.__c__DisplayClass12_1>.NativeClassPtr);
				InfiltrateAbility.__c__DisplayClass12_1.NativeFieldInfoPtr_hasResourceCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfiltrateAbility.__c__DisplayClass12_1>.NativeClassPtr, "hasResourceCost");
				InfiltrateAbility.__c__DisplayClass12_1.NativeFieldInfoPtr_field_Public___c__DisplayClass12_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfiltrateAbility.__c__DisplayClass12_1>.NativeClassPtr, "CS$<>8__locals1");
				InfiltrateAbility.__c__DisplayClass12_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiltrateAbility.__c__DisplayClass12_1>.NativeClassPtr, 100679395);
			}

			// Token: 0x0600B27F RID: 45695 RVA: 0x002CE67C File Offset: 0x002CC87C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InfiltrateAbility.__c__DisplayClass12_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InfiltrateAbility.__c__DisplayClass12_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B280 RID: 45696 RVA: 0x0005204C File Offset: 0x0005024C
			public __c__DisplayClass12_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170036AD RID: 13997
			// (get) Token: 0x0600B281 RID: 45697 RVA: 0x002CE6B8 File Offset: 0x002CC8B8
			// (set) Token: 0x0600B282 RID: 45698 RVA: 0x00052055 File Offset: 0x00050255
			public unsafe HasResourceCost hasResourceCost
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility.__c__DisplayClass12_1.NativeFieldInfoPtr_hasResourceCost);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HasResourceCost>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility.__c__DisplayClass12_1.NativeFieldInfoPtr_hasResourceCost), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036AE RID: 13998
			// (get) Token: 0x0600B283 RID: 45699 RVA: 0x002CE6E8 File Offset: 0x002CC8E8
			// (set) Token: 0x0600B284 RID: 45700 RVA: 0x00052074 File Offset: 0x00050274
			public unsafe InfiltrateAbility.__c__DisplayClass12_0 field_Public___c__DisplayClass12_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility.__c__DisplayClass12_1.NativeFieldInfoPtr_field_Public___c__DisplayClass12_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InfiltrateAbility.__c__DisplayClass12_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility.__c__DisplayClass12_1.NativeFieldInfoPtr_field_Public___c__DisplayClass12_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400708A RID: 28810
			private static readonly IntPtr NativeFieldInfoPtr_hasResourceCost;

			// Token: 0x0400708B RID: 28811
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass12_0_0;

			// Token: 0x0400708C RID: 28812
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000B09 RID: 2825
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.InfiltrateAbility+<>c__DisplayClass12_2")]
		public sealed class __c__DisplayClass12_2 : Object
		{
			// Token: 0x0600B285 RID: 45701 RVA: 0x002CE718 File Offset: 0x002CC918
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_2()
			{
				Il2CppClassPointerStore<InfiltrateAbility.__c__DisplayClass12_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InfiltrateAbility>.NativeClassPtr, "<>c__DisplayClass12_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InfiltrateAbility.__c__DisplayClass12_2>.NativeClassPtr);
				InfiltrateAbility.__c__DisplayClass12_2.NativeFieldInfoPtr_validSpaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfiltrateAbility.__c__DisplayClass12_2>.NativeClassPtr, "validSpaces");
				InfiltrateAbility.__c__DisplayClass12_2.NativeFieldInfoPtr_cardIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfiltrateAbility.__c__DisplayClass12_2>.NativeClassPtr, "cardIcons");
				InfiltrateAbility.__c__DisplayClass12_2.NativeFieldInfoPtr_field_Public___c__DisplayClass12_1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfiltrateAbility.__c__DisplayClass12_2>.NativeClassPtr, "CS$<>8__locals2");
				InfiltrateAbility.__c__DisplayClass12_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiltrateAbility.__c__DisplayClass12_2>.NativeClassPtr, 100679396);
				InfiltrateAbility.__c__DisplayClass12_2.NativeMethodInfoPtr__Evaluate_b__1_Internal_Boolean_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiltrateAbility.__c__DisplayClass12_2>.NativeClassPtr, 100679397);
			}

			// Token: 0x0600B286 RID: 45702 RVA: 0x002CE7A8 File Offset: 0x002CC9A8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_2()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InfiltrateAbility.__c__DisplayClass12_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InfiltrateAbility.__c__DisplayClass12_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B287 RID: 45703 RVA: 0x002CE7E4 File Offset: 0x002CC9E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235092, XrefRangeEnd = 235105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Evaluate_b__1(WormSpace space)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(space);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InfiltrateAbility.__c__DisplayClass12_2.NativeMethodInfoPtr__Evaluate_b__1_Internal_Boolean_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600B288 RID: 45704 RVA: 0x00052093 File Offset: 0x00050293
			public __c__DisplayClass12_2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170036AF RID: 13999
			// (get) Token: 0x0600B289 RID: 45705 RVA: 0x002CE834 File Offset: 0x002CCA34
			// (set) Token: 0x0600B28A RID: 45706 RVA: 0x0005209C File Offset: 0x0005029C
			public unsafe List<WormSpace> validSpaces
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility.__c__DisplayClass12_2.NativeFieldInfoPtr_validSpaces);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormSpace>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility.__c__DisplayClass12_2.NativeFieldInfoPtr_validSpaces), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036B0 RID: 14000
			// (get) Token: 0x0600B28B RID: 45707 RVA: 0x002CE864 File Offset: 0x002CCA64
			// (set) Token: 0x0600B28C RID: 45708 RVA: 0x000520BB File Offset: 0x000502BB
			public unsafe List<AgentIcons> cardIcons
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility.__c__DisplayClass12_2.NativeFieldInfoPtr_cardIcons);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AgentIcons>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility.__c__DisplayClass12_2.NativeFieldInfoPtr_cardIcons), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036B1 RID: 14001
			// (get) Token: 0x0600B28D RID: 45709 RVA: 0x002CE894 File Offset: 0x002CCA94
			// (set) Token: 0x0600B28E RID: 45710 RVA: 0x000520DA File Offset: 0x000502DA
			public unsafe InfiltrateAbility.__c__DisplayClass12_1 field_Public___c__DisplayClass12_1_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility.__c__DisplayClass12_2.NativeFieldInfoPtr_field_Public___c__DisplayClass12_1_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InfiltrateAbility.__c__DisplayClass12_1>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility.__c__DisplayClass12_2.NativeFieldInfoPtr_field_Public___c__DisplayClass12_1_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400708D RID: 28813
			private static readonly IntPtr NativeFieldInfoPtr_validSpaces;

			// Token: 0x0400708E RID: 28814
			private static readonly IntPtr NativeFieldInfoPtr_cardIcons;

			// Token: 0x0400708F RID: 28815
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass12_1_0;

			// Token: 0x04007090 RID: 28816
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007091 RID: 28817
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__1_Internal_Boolean_WormSpace_0;
		}

		// Token: 0x02000B0A RID: 2826
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.InfiltrateAbility+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x0600B28F RID: 45711 RVA: 0x002CE8C4 File Offset: 0x002CCAC4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<InfiltrateAbility.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InfiltrateAbility>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InfiltrateAbility.__c__DisplayClass7_0>.NativeClassPtr);
				InfiltrateAbility.__c__DisplayClass7_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfiltrateAbility.__c__DisplayClass7_0>.NativeClassPtr, "player");
				InfiltrateAbility.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiltrateAbility.__c__DisplayClass7_0>.NativeClassPtr, 100679398);
				InfiltrateAbility.__c__DisplayClass7_0.NativeMethodInfoPtr__RunImmediateEffects_b__0_Internal_GameLogBuilder_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiltrateAbility.__c__DisplayClass7_0>.NativeClassPtr, 100679399);
			}

			// Token: 0x0600B290 RID: 45712 RVA: 0x002CE92C File Offset: 0x002CCB2C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InfiltrateAbility.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InfiltrateAbility.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B291 RID: 45713 RVA: 0x002CE968 File Offset: 0x002CCB68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235105, XrefRangeEnd = 235110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GameLogBuilder _RunImmediateEffects_b__0(GameLogBuilder _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InfiltrateAbility.__c__DisplayClass7_0.NativeMethodInfoPtr__RunImmediateEffects_b__0_Internal_GameLogBuilder_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x0600B292 RID: 45714 RVA: 0x000520F9 File Offset: 0x000502F9
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170036B2 RID: 14002
			// (get) Token: 0x0600B293 RID: 45715 RVA: 0x002CE9B8 File Offset: 0x002CCBB8
			// (set) Token: 0x0600B294 RID: 45716 RVA: 0x00052102 File Offset: 0x00050302
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility.__c__DisplayClass7_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility.__c__DisplayClass7_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007092 RID: 28818
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04007093 RID: 28819
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007094 RID: 28820
			private static readonly IntPtr NativeMethodInfoPtr__RunImmediateEffects_b__0_Internal_GameLogBuilder_GameLogBuilder_0;
		}

		// Token: 0x02000B0B RID: 2827
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.InfiltrateAbility+<RunImmediateEffects>d__7")]
		public sealed class _RunImmediateEffects_d__7 : Object
		{
			// Token: 0x0600B295 RID: 45717 RVA: 0x002CE9E8 File Offset: 0x002CCBE8
			// Note: this type is marked as 'beforefieldinit'.
			static _RunImmediateEffects_d__7()
			{
				Il2CppClassPointerStore<InfiltrateAbility._RunImmediateEffects_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InfiltrateAbility>.NativeClassPtr, "<RunImmediateEffects>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InfiltrateAbility._RunImmediateEffects_d__7>.NativeClassPtr);
				InfiltrateAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfiltrateAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<>1__state");
				InfiltrateAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfiltrateAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<>2__current");
				InfiltrateAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfiltrateAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<>l__initialThreadId");
				InfiltrateAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfiltrateAbility._RunImmediateEffects_d__7>.NativeClassPtr, "activeAbility");
				InfiltrateAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfiltrateAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<>3__activeAbility");
				InfiltrateAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfiltrateAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<>4__this");
				InfiltrateAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfiltrateAbility._RunImmediateEffects_d__7>.NativeClassPtr, "match");
				InfiltrateAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfiltrateAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<>3__match");
				InfiltrateAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfiltrateAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<>8__1");
				InfiltrateAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiltrateAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100679400);
				InfiltrateAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiltrateAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100679401);
				InfiltrateAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiltrateAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100679402);
				InfiltrateAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiltrateAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100679403);
				InfiltrateAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiltrateAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100679404);
				InfiltrateAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiltrateAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100679405);
				InfiltrateAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiltrateAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100679406);
				InfiltrateAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiltrateAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100679407);
			}

			// Token: 0x0600B296 RID: 45718 RVA: 0x002CEB68 File Offset: 0x002CCD68
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RunImmediateEffects_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InfiltrateAbility._RunImmediateEffects_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InfiltrateAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600B297 RID: 45719 RVA: 0x002CEBB0 File Offset: 0x002CCDB0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InfiltrateAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B298 RID: 45720 RVA: 0x002CEBE4 File Offset: 0x002CCDE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235110, XrefRangeEnd = 235140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InfiltrateAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170036BC RID: 14012
			// (get) Token: 0x0600B299 RID: 45721 RVA: 0x002CEC20 File Offset: 0x002CCE20
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InfiltrateAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600B29A RID: 45722 RVA: 0x002CEC60 File Offset: 0x002CCE60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235140, XrefRangeEnd = 235145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InfiltrateAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170036BD RID: 14013
			// (get) Token: 0x0600B29B RID: 45723 RVA: 0x002CEC94 File Offset: 0x002CCE94
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InfiltrateAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B29C RID: 45724 RVA: 0x002CECD4 File Offset: 0x002CCED4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235145, XrefRangeEnd = 235155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InfiltrateAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600B29D RID: 45725 RVA: 0x002CED14 File Offset: 0x002CCF14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InfiltrateAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600B29E RID: 45726 RVA: 0x00052121 File Offset: 0x00050321
			public _RunImmediateEffects_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170036B3 RID: 14003
			// (get) Token: 0x0600B29F RID: 45727 RVA: 0x002CED54 File Offset: 0x002CCF54
			// (set) Token: 0x0600B2A0 RID: 45728 RVA: 0x0005212A File Offset: 0x0005032A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170036B4 RID: 14004
			// (get) Token: 0x0600B2A1 RID: 45729 RVA: 0x002CED7C File Offset: 0x002CCF7C
			// (set) Token: 0x0600B2A2 RID: 45730 RVA: 0x00052145 File Offset: 0x00050345
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036B5 RID: 14005
			// (get) Token: 0x0600B2A3 RID: 45731 RVA: 0x002CEDAC File Offset: 0x002CCFAC
			// (set) Token: 0x0600B2A4 RID: 45732 RVA: 0x00052164 File Offset: 0x00050364
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170036B6 RID: 14006
			// (get) Token: 0x0600B2A5 RID: 45733 RVA: 0x002CEDD4 File Offset: 0x002CCFD4
			// (set) Token: 0x0600B2A6 RID: 45734 RVA: 0x0005217F File Offset: 0x0005037F
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036B7 RID: 14007
			// (get) Token: 0x0600B2A7 RID: 45735 RVA: 0x002CEE04 File Offset: 0x002CD004
			// (set) Token: 0x0600B2A8 RID: 45736 RVA: 0x0005219E File Offset: 0x0005039E
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036B8 RID: 14008
			// (get) Token: 0x0600B2A9 RID: 45737 RVA: 0x002CEE34 File Offset: 0x002CD034
			// (set) Token: 0x0600B2AA RID: 45738 RVA: 0x000521BD File Offset: 0x000503BD
			public unsafe InfiltrateAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InfiltrateAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036B9 RID: 14009
			// (get) Token: 0x0600B2AB RID: 45739 RVA: 0x002CEE64 File Offset: 0x002CD064
			// (set) Token: 0x0600B2AC RID: 45740 RVA: 0x000521DC File Offset: 0x000503DC
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036BA RID: 14010
			// (get) Token: 0x0600B2AD RID: 45741 RVA: 0x002CEE94 File Offset: 0x002CD094
			// (set) Token: 0x0600B2AE RID: 45742 RVA: 0x000521FB File Offset: 0x000503FB
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036BB RID: 14011
			// (get) Token: 0x0600B2AF RID: 45743 RVA: 0x002CEEC4 File Offset: 0x002CD0C4
			// (set) Token: 0x0600B2B0 RID: 45744 RVA: 0x0005221A File Offset: 0x0005041A
			public unsafe InfiltrateAbility.__c__DisplayClass7_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InfiltrateAbility.__c__DisplayClass7_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007095 RID: 28821
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007096 RID: 28822
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007097 RID: 28823
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04007098 RID: 28824
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04007099 RID: 28825
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x0400709A RID: 28826
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400709B RID: 28827
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x0400709C RID: 28828
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x0400709D RID: 28829
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400709E RID: 28830
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400709F RID: 28831
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040070A0 RID: 28832
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040070A1 RID: 28833
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040070A2 RID: 28834
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040070A3 RID: 28835
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040070A4 RID: 28836
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040070A5 RID: 28837
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000B0C RID: 2828
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.InfiltrateAbility+<Undo>d__8")]
		public sealed class _Undo_d__8 : Object
		{
			// Token: 0x0600B2B1 RID: 45745 RVA: 0x002CEEF4 File Offset: 0x002CD0F4
			// Note: this type is marked as 'beforefieldinit'.
			static _Undo_d__8()
			{
				Il2CppClassPointerStore<InfiltrateAbility._Undo_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InfiltrateAbility>.NativeClassPtr, "<Undo>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InfiltrateAbility._Undo_d__8>.NativeClassPtr);
				InfiltrateAbility._Undo_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfiltrateAbility._Undo_d__8>.NativeClassPtr, "<>1__state");
				InfiltrateAbility._Undo_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfiltrateAbility._Undo_d__8>.NativeClassPtr, "<>2__current");
				InfiltrateAbility._Undo_d__8.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfiltrateAbility._Undo_d__8>.NativeClassPtr, "<>l__initialThreadId");
				InfiltrateAbility._Undo_d__8.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfiltrateAbility._Undo_d__8>.NativeClassPtr, "match");
				InfiltrateAbility._Undo_d__8.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfiltrateAbility._Undo_d__8>.NativeClassPtr, "<>3__match");
				InfiltrateAbility._Undo_d__8.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfiltrateAbility._Undo_d__8>.NativeClassPtr, "player");
				InfiltrateAbility._Undo_d__8.NativeFieldInfoPtr___3__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfiltrateAbility._Undo_d__8>.NativeClassPtr, "<>3__player");
				InfiltrateAbility._Undo_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiltrateAbility._Undo_d__8>.NativeClassPtr, 100679408);
				InfiltrateAbility._Undo_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiltrateAbility._Undo_d__8>.NativeClassPtr, 100679409);
				InfiltrateAbility._Undo_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiltrateAbility._Undo_d__8>.NativeClassPtr, 100679410);
				InfiltrateAbility._Undo_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiltrateAbility._Undo_d__8>.NativeClassPtr, 100679411);
				InfiltrateAbility._Undo_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiltrateAbility._Undo_d__8>.NativeClassPtr, 100679412);
				InfiltrateAbility._Undo_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiltrateAbility._Undo_d__8>.NativeClassPtr, 100679413);
				InfiltrateAbility._Undo_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiltrateAbility._Undo_d__8>.NativeClassPtr, 100679414);
				InfiltrateAbility._Undo_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfiltrateAbility._Undo_d__8>.NativeClassPtr, 100679415);
			}

			// Token: 0x0600B2B2 RID: 45746 RVA: 0x002CF04C File Offset: 0x002CD24C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Undo_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InfiltrateAbility._Undo_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InfiltrateAbility._Undo_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600B2B3 RID: 45747 RVA: 0x002CF094 File Offset: 0x002CD294
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InfiltrateAbility._Undo_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B2B4 RID: 45748 RVA: 0x002CF0C8 File Offset: 0x002CD2C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235155, XrefRangeEnd = 235174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InfiltrateAbility._Undo_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170036C5 RID: 14021
			// (get) Token: 0x0600B2B5 RID: 45749 RVA: 0x002CF104 File Offset: 0x002CD304
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InfiltrateAbility._Undo_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600B2B6 RID: 45750 RVA: 0x002CF144 File Offset: 0x002CD344
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235174, XrefRangeEnd = 235179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InfiltrateAbility._Undo_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170036C6 RID: 14022
			// (get) Token: 0x0600B2B7 RID: 45751 RVA: 0x002CF178 File Offset: 0x002CD378
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InfiltrateAbility._Undo_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B2B8 RID: 45752 RVA: 0x002CF1B8 File Offset: 0x002CD3B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235179, XrefRangeEnd = 235188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InfiltrateAbility._Undo_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600B2B9 RID: 45753 RVA: 0x002CF1F8 File Offset: 0x002CD3F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InfiltrateAbility._Undo_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600B2BA RID: 45754 RVA: 0x00052239 File Offset: 0x00050439
			public _Undo_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170036BE RID: 14014
			// (get) Token: 0x0600B2BB RID: 45755 RVA: 0x002CF238 File Offset: 0x002CD438
			// (set) Token: 0x0600B2BC RID: 45756 RVA: 0x00052242 File Offset: 0x00050442
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility._Undo_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility._Undo_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170036BF RID: 14015
			// (get) Token: 0x0600B2BD RID: 45757 RVA: 0x002CF260 File Offset: 0x002CD460
			// (set) Token: 0x0600B2BE RID: 45758 RVA: 0x0005225D File Offset: 0x0005045D
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility._Undo_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility._Undo_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036C0 RID: 14016
			// (get) Token: 0x0600B2BF RID: 45759 RVA: 0x002CF290 File Offset: 0x002CD490
			// (set) Token: 0x0600B2C0 RID: 45760 RVA: 0x0005227C File Offset: 0x0005047C
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility._Undo_d__8.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility._Undo_d__8.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170036C1 RID: 14017
			// (get) Token: 0x0600B2C1 RID: 45761 RVA: 0x002CF2B8 File Offset: 0x002CD4B8
			// (set) Token: 0x0600B2C2 RID: 45762 RVA: 0x00052297 File Offset: 0x00050497
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility._Undo_d__8.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility._Undo_d__8.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036C2 RID: 14018
			// (get) Token: 0x0600B2C3 RID: 45763 RVA: 0x002CF2E8 File Offset: 0x002CD4E8
			// (set) Token: 0x0600B2C4 RID: 45764 RVA: 0x000522B6 File Offset: 0x000504B6
			public unsafe Match __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility._Undo_d__8.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility._Undo_d__8.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036C3 RID: 14019
			// (get) Token: 0x0600B2C5 RID: 45765 RVA: 0x002CF318 File Offset: 0x002CD518
			// (set) Token: 0x0600B2C6 RID: 45766 RVA: 0x000522D5 File Offset: 0x000504D5
			public unsafe PlayerEntity player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility._Undo_d__8.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility._Undo_d__8.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036C4 RID: 14020
			// (get) Token: 0x0600B2C7 RID: 45767 RVA: 0x002CF348 File Offset: 0x002CD548
			// (set) Token: 0x0600B2C8 RID: 45768 RVA: 0x000522F4 File Offset: 0x000504F4
			public unsafe PlayerEntity __3__player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility._Undo_d__8.NativeFieldInfoPtr___3__player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InfiltrateAbility._Undo_d__8.NativeFieldInfoPtr___3__player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040070A6 RID: 28838
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040070A7 RID: 28839
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040070A8 RID: 28840
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040070A9 RID: 28841
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x040070AA RID: 28842
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x040070AB RID: 28843
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x040070AC RID: 28844
			private static readonly IntPtr NativeFieldInfoPtr___3__player;

			// Token: 0x040070AD RID: 28845
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040070AE RID: 28846
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040070AF RID: 28847
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040070B0 RID: 28848
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040070B1 RID: 28849
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040070B2 RID: 28850
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040070B3 RID: 28851
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040070B4 RID: 28852
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
