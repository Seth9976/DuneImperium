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
using Networking.selection.targetinformation;
using worm.canis.ai;
using worm.canis.ai.choices;
using worm.canis.entities;

namespace worm.canis.abilities.PlayAbilities.BaseSet
{
	// Token: 0x0200048E RID: 1166
	public class RapidMobilizationAbility : IntrigueAbility
	{
		// Token: 0x06003402 RID: 13314 RVA: 0x001364D4 File Offset: 0x001346D4
		// Note: this type is marked as 'beforefieldinit'.
		static RapidMobilizationAbility()
		{
			Il2CppClassPointerStore<RapidMobilizationAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.PlayAbilities.BaseSet", "RapidMobilizationAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RapidMobilizationAbility>.NativeClassPtr);
			RapidMobilizationAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RapidMobilizationAbility>.NativeClassPtr, "AbilityName");
			RapidMobilizationAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RapidMobilizationAbility>.NativeClassPtr, "AbilityID");
			RapidMobilizationAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RapidMobilizationAbility>.NativeClassPtr, 100679638);
			RapidMobilizationAbility.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RapidMobilizationAbility>.NativeClassPtr, 100679639);
			RapidMobilizationAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RapidMobilizationAbility>.NativeClassPtr, 100679640);
			RapidMobilizationAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RapidMobilizationAbility>.NativeClassPtr, 100679641);
			RapidMobilizationAbility.NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RapidMobilizationAbility>.NativeClassPtr, 100679642);
			RapidMobilizationAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RapidMobilizationAbility>.NativeClassPtr, 100679643);
			RapidMobilizationAbility.NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RapidMobilizationAbility>.NativeClassPtr, 100679644);
			RapidMobilizationAbility.NativeMethodInfoPtr_ShowHinting_Public_Virtual_Boolean_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RapidMobilizationAbility>.NativeClassPtr, 100679645);
			RapidMobilizationAbility.NativeMethodInfoPtr_IsBadIntrigue_Public_Virtual_Boolean_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RapidMobilizationAbility>.NativeClassPtr, 100679646);
			RapidMobilizationAbility.NativeMethodInfoPtr_GetUnusualSelections_Public_Virtual_List_1_ValueTuple_2_LocalizableTextVariables_List_1_EntityID_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RapidMobilizationAbility>.NativeClassPtr, 100679647);
			RapidMobilizationAbility.NativeMethodInfoPtr_TroopValue_Public_Virtual_Int32_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RapidMobilizationAbility>.NativeClassPtr, 100679648);
			RapidMobilizationAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RapidMobilizationAbility>.NativeClassPtr, 100679649);
		}

		// Token: 0x06003403 RID: 13315 RVA: 0x0013661C File Offset: 0x0013481C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237689, XrefRangeEnd = 237693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RapidMobilizationAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06003404 RID: 13316 RVA: 0x00136668 File Offset: 0x00134868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237693, XrefRangeEnd = 237699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override GameLogBuilder MakeGameLogBuilder(IHasGameLogs hasGameLogs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hasGameLogs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RapidMobilizationAbility.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x06003405 RID: 13317 RVA: 0x001366C4 File Offset: 0x001348C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237699, XrefRangeEnd = 237702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RapidMobilizationAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RapidMobilizationAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RapidMobilizationAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003406 RID: 13318 RVA: 0x00136710 File Offset: 0x00134910
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 215283, RefRangeEnd = 215298, XrefRangeStart = 215283, XrefRangeEnd = 215298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RapidMobilizationAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RapidMobilizationAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RapidMobilizationAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003407 RID: 13319 RVA: 0x00136780 File Offset: 0x00134980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237702, XrefRangeEnd = 237709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<TargetInformation> Targets(Match match, Context context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RapidMobilizationAbility.NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TargetInformation>>(intPtr3) : null;
		}

		// Token: 0x06003408 RID: 13320 RVA: 0x001367F0 File Offset: 0x001349F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237709, XrefRangeEnd = 237713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RapidMobilizationAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x06003409 RID: 13321 RVA: 0x00136860 File Offset: 0x00134A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237713, XrefRangeEnd = 237721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RapidMobilizationAbility.NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x0600340A RID: 13322 RVA: 0x001368E0 File Offset: 0x00134AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237721, XrefRangeEnd = 237730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RapidMobilizationAbility.NativeMethodInfoPtr_ShowHinting_Public_Virtual_Boolean_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600340B RID: 13323 RVA: 0x0013694C File Offset: 0x00134B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237730, XrefRangeEnd = 237731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RapidMobilizationAbility.NativeMethodInfoPtr_IsBadIntrigue_Public_Virtual_Boolean_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600340C RID: 13324 RVA: 0x001369B8 File Offset: 0x00134BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237731, XrefRangeEnd = 237768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RapidMobilizationAbility.NativeMethodInfoPtr_GetUnusualSelections_Public_Virtual_List_1_ValueTuple_2_LocalizableTextVariables_List_1_EntityID_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<LocalizableTextVariables, List<EntityID>>>>(intPtr3) : null;
		}

		// Token: 0x0600340D RID: 13325 RVA: 0x00136A28 File Offset: 0x00134C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237768, XrefRangeEnd = 237779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int TroopValue(WormMatch match, WormPlayer player)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RapidMobilizationAbility.NativeMethodInfoPtr_TroopValue_Public_Virtual_Int32_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600340E RID: 13326 RVA: 0x00136A94 File Offset: 0x00134C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237779, XrefRangeEnd = 237971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WormAIChoice Evaluate(WormAIChoiceContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RapidMobilizationAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormAIChoice>(intPtr3) : null;
			}
		}

		// Token: 0x0600340F RID: 13327 RVA: 0x00011DE3 File Offset: 0x0000FFE3
		public RapidMobilizationAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x06003410 RID: 13328 RVA: 0x00136AF0 File Offset: 0x00134CF0
		// (set) Token: 0x06003411 RID: 13329 RVA: 0x00011DEC File Offset: 0x0000FFEC
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RapidMobilizationAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RapidMobilizationAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x06003412 RID: 13330 RVA: 0x00136B10 File Offset: 0x00134D10
		// (set) Token: 0x06003413 RID: 13331 RVA: 0x00011DFE File Offset: 0x0000FFFE
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RapidMobilizationAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RapidMobilizationAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040021D6 RID: 8662
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x040021D7 RID: 8663
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x040021D8 RID: 8664
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x040021D9 RID: 8665
		private static readonly IntPtr NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0;

		// Token: 0x040021DA RID: 8666
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x040021DB RID: 8667
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x040021DC RID: 8668
		private static readonly IntPtr NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0;

		// Token: 0x040021DD RID: 8669
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0;

		// Token: 0x040021DE RID: 8670
		private static readonly IntPtr NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x040021DF RID: 8671
		private static readonly IntPtr NativeMethodInfoPtr_ShowHinting_Public_Virtual_Boolean_WormMatch_WormPlayer_0;

		// Token: 0x040021E0 RID: 8672
		private static readonly IntPtr NativeMethodInfoPtr_IsBadIntrigue_Public_Virtual_Boolean_WormMatch_WormPlayer_0;

		// Token: 0x040021E1 RID: 8673
		private static readonly IntPtr NativeMethodInfoPtr_GetUnusualSelections_Public_Virtual_List_1_ValueTuple_2_LocalizableTextVariables_List_1_EntityID_WormMatch_WormPlayer_0;

		// Token: 0x040021E2 RID: 8674
		private static readonly IntPtr NativeMethodInfoPtr_TroopValue_Public_Virtual_Int32_WormMatch_WormPlayer_0;

		// Token: 0x040021E3 RID: 8675
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0;

		// Token: 0x02000B2A RID: 2858
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.RapidMobilizationAbility+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600B4AD RID: 46253 RVA: 0x002D4BA0 File Offset: 0x002D2DA0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RapidMobilizationAbility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RapidMobilizationAbility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RapidMobilizationAbility.__c>.NativeClassPtr);
				RapidMobilizationAbility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RapidMobilizationAbility.__c>.NativeClassPtr, "<>9");
				RapidMobilizationAbility.__c.NativeFieldInfoPtr___9__13_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RapidMobilizationAbility.__c>.NativeClassPtr, "<>9__13_3");
				RapidMobilizationAbility.__c.NativeFieldInfoPtr___9__13_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RapidMobilizationAbility.__c>.NativeClassPtr, "<>9__13_5");
				RapidMobilizationAbility.__c.NativeFieldInfoPtr___9__13_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RapidMobilizationAbility.__c>.NativeClassPtr, "<>9__13_1");
				RapidMobilizationAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RapidMobilizationAbility.__c>.NativeClassPtr, 100679652);
				RapidMobilizationAbility.__c.NativeMethodInfoPtr__Evaluate_b__13_3_Internal_AIValueSummer_1_Int32_AIValueSummer_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RapidMobilizationAbility.__c>.NativeClassPtr, 100679653);
				RapidMobilizationAbility.__c.NativeMethodInfoPtr__Evaluate_b__13_5_Internal_EntityID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RapidMobilizationAbility.__c>.NativeClassPtr, 100679654);
				RapidMobilizationAbility.__c.NativeMethodInfoPtr__Evaluate_b__13_1_Internal_EntityID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RapidMobilizationAbility.__c>.NativeClassPtr, 100679655);
			}

			// Token: 0x0600B4AE RID: 46254 RVA: 0x002D4C6C File Offset: 0x002D2E6C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RapidMobilizationAbility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RapidMobilizationAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B4AF RID: 46255 RVA: 0x002D4CA8 File Offset: 0x002D2EA8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AIValueSummer<int> _Evaluate_b__13_3(AIValueSummer<int> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RapidMobilizationAbility.__c.NativeMethodInfoPtr__Evaluate_b__13_3_Internal_AIValueSummer_1_Int32_AIValueSummer_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<int>>(intPtr3) : null;
				}
			}

			// Token: 0x0600B4B0 RID: 46256 RVA: 0x002D4CF8 File Offset: 0x002D2EF8
			[CallerCount(0)]
			public unsafe EntityID _Evaluate_b__13_5(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RapidMobilizationAbility.__c.NativeMethodInfoPtr__Evaluate_b__13_5_Internal_EntityID_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x0600B4B1 RID: 46257 RVA: 0x002D4D48 File Offset: 0x002D2F48
			[CallerCount(0)]
			public unsafe EntityID _Evaluate_b__13_1(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RapidMobilizationAbility.__c.NativeMethodInfoPtr__Evaluate_b__13_1_Internal_EntityID_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x0600B4B2 RID: 46258 RVA: 0x0005343E File Offset: 0x0005163E
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700376C RID: 14188
			// (get) Token: 0x0600B4B3 RID: 46259 RVA: 0x002D4D98 File Offset: 0x002D2F98
			// (set) Token: 0x0600B4B4 RID: 46260 RVA: 0x00053447 File Offset: 0x00051647
			public unsafe static RapidMobilizationAbility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RapidMobilizationAbility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RapidMobilizationAbility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RapidMobilizationAbility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700376D RID: 14189
			// (get) Token: 0x0600B4B5 RID: 46261 RVA: 0x002D4DC0 File Offset: 0x002D2FC0
			// (set) Token: 0x0600B4B6 RID: 46262 RVA: 0x00053459 File Offset: 0x00051659
			public unsafe static Func<AIValueSummer<int>, AIValueSummer<int>> __9__13_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RapidMobilizationAbility.__c.NativeFieldInfoPtr___9__13_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AIValueSummer<int>, AIValueSummer<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RapidMobilizationAbility.__c.NativeFieldInfoPtr___9__13_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700376E RID: 14190
			// (get) Token: 0x0600B4B7 RID: 46263 RVA: 0x002D4DE8 File Offset: 0x002D2FE8
			// (set) Token: 0x0600B4B8 RID: 46264 RVA: 0x0005346B File Offset: 0x0005166B
			public unsafe static Func<Entity, EntityID> __9__13_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RapidMobilizationAbility.__c.NativeFieldInfoPtr___9__13_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RapidMobilizationAbility.__c.NativeFieldInfoPtr___9__13_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700376F RID: 14191
			// (get) Token: 0x0600B4B9 RID: 46265 RVA: 0x002D4E10 File Offset: 0x002D3010
			// (set) Token: 0x0600B4BA RID: 46266 RVA: 0x0005347D File Offset: 0x0005167D
			public unsafe static Func<Entity, EntityID> __9__13_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RapidMobilizationAbility.__c.NativeFieldInfoPtr___9__13_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RapidMobilizationAbility.__c.NativeFieldInfoPtr___9__13_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040071D0 RID: 29136
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040071D1 RID: 29137
			private static readonly IntPtr NativeFieldInfoPtr___9__13_3;

			// Token: 0x040071D2 RID: 29138
			private static readonly IntPtr NativeFieldInfoPtr___9__13_5;

			// Token: 0x040071D3 RID: 29139
			private static readonly IntPtr NativeFieldInfoPtr___9__13_1;

			// Token: 0x040071D4 RID: 29140
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040071D5 RID: 29141
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__13_3_Internal_AIValueSummer_1_Int32_AIValueSummer_1_Int32_0;

			// Token: 0x040071D6 RID: 29142
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__13_5_Internal_EntityID_Entity_0;

			// Token: 0x040071D7 RID: 29143
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__13_1_Internal_EntityID_Entity_0;
		}

		// Token: 0x02000B2B RID: 2859
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.RapidMobilizationAbility+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Object
		{
			// Token: 0x0600B4BB RID: 46267 RVA: 0x002D4E38 File Offset: 0x002D3038
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<RapidMobilizationAbility.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RapidMobilizationAbility>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RapidMobilizationAbility.__c__DisplayClass13_0>.NativeClassPtr);
				RapidMobilizationAbility.__c__DisplayClass13_0.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RapidMobilizationAbility.__c__DisplayClass13_0>.NativeClassPtr, "context");
				RapidMobilizationAbility.__c__DisplayClass13_0.NativeFieldInfoPtr_expectedStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RapidMobilizationAbility.__c__DisplayClass13_0>.NativeClassPtr, "expectedStrength");
				RapidMobilizationAbility.__c__DisplayClass13_0.NativeFieldInfoPtr_garrisonTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RapidMobilizationAbility.__c__DisplayClass13_0>.NativeClassPtr, "garrisonTargets");
				RapidMobilizationAbility.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RapidMobilizationAbility.__c__DisplayClass13_0>.NativeClassPtr, 100679656);
				RapidMobilizationAbility.__c__DisplayClass13_0.NativeMethodInfoPtr__Evaluate_b__0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RapidMobilizationAbility.__c__DisplayClass13_0>.NativeClassPtr, 100679657);
				RapidMobilizationAbility.__c__DisplayClass13_0.NativeMethodInfoPtr__Evaluate_b__2_Internal_AIValueSummer_1_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RapidMobilizationAbility.__c__DisplayClass13_0>.NativeClassPtr, 100679658);
				RapidMobilizationAbility.__c__DisplayClass13_0.NativeMethodInfoPtr__Evaluate_b__4_Internal_Boolean_AIValueSummer_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RapidMobilizationAbility.__c__DisplayClass13_0>.NativeClassPtr, 100679659);
			}

			// Token: 0x0600B4BC RID: 46268 RVA: 0x002D4EF0 File Offset: 0x002D30F0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RapidMobilizationAbility.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RapidMobilizationAbility.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B4BD RID: 46269 RVA: 0x002D4F2C File Offset: 0x002D312C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237536, XrefRangeEnd = 237554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Evaluate_b__0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RapidMobilizationAbility.__c__DisplayClass13_0.NativeMethodInfoPtr__Evaluate_b__0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600B4BE RID: 46270 RVA: 0x002D4F7C File Offset: 0x002D317C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237554, XrefRangeEnd = 237557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AIValueSummer<int> _Evaluate_b__2(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RapidMobilizationAbility.__c__DisplayClass13_0.NativeMethodInfoPtr__Evaluate_b__2_Internal_AIValueSummer_1_Int32_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<int>>(intPtr3) : null;
				}
			}

			// Token: 0x0600B4BF RID: 46271 RVA: 0x002D4FCC File Offset: 0x002D31CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237557, XrefRangeEnd = 237563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Evaluate_b__4(AIValueSummer<int> s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RapidMobilizationAbility.__c__DisplayClass13_0.NativeMethodInfoPtr__Evaluate_b__4_Internal_Boolean_AIValueSummer_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600B4C0 RID: 46272 RVA: 0x0005348F File Offset: 0x0005168F
			public __c__DisplayClass13_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003770 RID: 14192
			// (get) Token: 0x0600B4C1 RID: 46273 RVA: 0x002D501C File Offset: 0x002D321C
			// (set) Token: 0x0600B4C2 RID: 46274 RVA: 0x00053498 File Offset: 0x00051698
			public unsafe WormAIChoiceContext context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RapidMobilizationAbility.__c__DisplayClass13_0.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAIChoiceContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RapidMobilizationAbility.__c__DisplayClass13_0.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003771 RID: 14193
			// (get) Token: 0x0600B4C3 RID: 46275 RVA: 0x002D504C File Offset: 0x002D324C
			// (set) Token: 0x0600B4C4 RID: 46276 RVA: 0x000534B7 File Offset: 0x000516B7
			public unsafe int expectedStrength
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RapidMobilizationAbility.__c__DisplayClass13_0.NativeFieldInfoPtr_expectedStrength);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RapidMobilizationAbility.__c__DisplayClass13_0.NativeFieldInfoPtr_expectedStrength)) = value;
				}
			}

			// Token: 0x17003772 RID: 14194
			// (get) Token: 0x0600B4C5 RID: 46277 RVA: 0x002D5074 File Offset: 0x002D3274
			// (set) Token: 0x0600B4C6 RID: 46278 RVA: 0x000534D2 File Offset: 0x000516D2
			public unsafe List<Entity> garrisonTargets
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RapidMobilizationAbility.__c__DisplayClass13_0.NativeFieldInfoPtr_garrisonTargets);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RapidMobilizationAbility.__c__DisplayClass13_0.NativeFieldInfoPtr_garrisonTargets), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040071D8 RID: 29144
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x040071D9 RID: 29145
			private static readonly IntPtr NativeFieldInfoPtr_expectedStrength;

			// Token: 0x040071DA RID: 29146
			private static readonly IntPtr NativeFieldInfoPtr_garrisonTargets;

			// Token: 0x040071DB RID: 29147
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040071DC RID: 29148
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__0_Internal_Boolean_WormPlayer_0;

			// Token: 0x040071DD RID: 29149
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__2_Internal_AIValueSummer_1_Int32_WormPlayer_0;

			// Token: 0x040071DE RID: 29150
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__4_Internal_Boolean_AIValueSummer_1_Int32_0;
		}

		// Token: 0x02000B2C RID: 2860
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.RapidMobilizationAbility+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x0600B4C7 RID: 46279 RVA: 0x002D50A4 File Offset: 0x002D32A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<RapidMobilizationAbility.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RapidMobilizationAbility>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RapidMobilizationAbility.__c__DisplayClass8_0>.NativeClassPtr);
				RapidMobilizationAbility.__c__DisplayClass8_0.NativeFieldInfoPtr_troopsToDeploy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RapidMobilizationAbility.__c__DisplayClass8_0>.NativeClassPtr, "troopsToDeploy");
				RapidMobilizationAbility.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RapidMobilizationAbility.__c__DisplayClass8_0>.NativeClassPtr, 100679660);
				RapidMobilizationAbility.__c__DisplayClass8_0.NativeMethodInfoPtr__RunImmediateEffects_b__0_Internal_GameLogBuilder_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RapidMobilizationAbility.__c__DisplayClass8_0>.NativeClassPtr, 100679661);
			}

			// Token: 0x0600B4C8 RID: 46280 RVA: 0x002D510C File Offset: 0x002D330C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RapidMobilizationAbility.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RapidMobilizationAbility.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B4C9 RID: 46281 RVA: 0x002D5148 File Offset: 0x002D3348
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237563, XrefRangeEnd = 237570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GameLogBuilder _RunImmediateEffects_b__0(GameLogBuilder _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RapidMobilizationAbility.__c__DisplayClass8_0.NativeMethodInfoPtr__RunImmediateEffects_b__0_Internal_GameLogBuilder_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x0600B4CA RID: 46282 RVA: 0x000534F1 File Offset: 0x000516F1
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003773 RID: 14195
			// (get) Token: 0x0600B4CB RID: 46283 RVA: 0x002D5198 File Offset: 0x002D3398
			// (set) Token: 0x0600B4CC RID: 46284 RVA: 0x000534FA File Offset: 0x000516FA
			public unsafe IEnumerable<WormTroop> troopsToDeploy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RapidMobilizationAbility.__c__DisplayClass8_0.NativeFieldInfoPtr_troopsToDeploy);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormTroop>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RapidMobilizationAbility.__c__DisplayClass8_0.NativeFieldInfoPtr_troopsToDeploy), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040071DF RID: 29151
			private static readonly IntPtr NativeFieldInfoPtr_troopsToDeploy;

			// Token: 0x040071E0 RID: 29152
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040071E1 RID: 29153
			private static readonly IntPtr NativeMethodInfoPtr__RunImmediateEffects_b__0_Internal_GameLogBuilder_GameLogBuilder_0;
		}

		// Token: 0x02000B2D RID: 2861
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.RapidMobilizationAbility+<RunImmediateEffects>d__8")]
		public sealed class _RunImmediateEffects_d__8 : Object
		{
			// Token: 0x0600B4CD RID: 46285 RVA: 0x002D51C8 File Offset: 0x002D33C8
			// Note: this type is marked as 'beforefieldinit'.
			static _RunImmediateEffects_d__8()
			{
				Il2CppClassPointerStore<RapidMobilizationAbility._RunImmediateEffects_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RapidMobilizationAbility>.NativeClassPtr, "<RunImmediateEffects>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RapidMobilizationAbility._RunImmediateEffects_d__8>.NativeClassPtr);
				RapidMobilizationAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RapidMobilizationAbility._RunImmediateEffects_d__8>.NativeClassPtr, "<>1__state");
				RapidMobilizationAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RapidMobilizationAbility._RunImmediateEffects_d__8>.NativeClassPtr, "<>2__current");
				RapidMobilizationAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RapidMobilizationAbility._RunImmediateEffects_d__8>.NativeClassPtr, "<>l__initialThreadId");
				RapidMobilizationAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RapidMobilizationAbility._RunImmediateEffects_d__8>.NativeClassPtr, "<>4__this");
				RapidMobilizationAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RapidMobilizationAbility._RunImmediateEffects_d__8>.NativeClassPtr, "activeAbility");
				RapidMobilizationAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RapidMobilizationAbility._RunImmediateEffects_d__8>.NativeClassPtr, "<>3__activeAbility");
				RapidMobilizationAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RapidMobilizationAbility._RunImmediateEffects_d__8>.NativeClassPtr, "match");
				RapidMobilizationAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RapidMobilizationAbility._RunImmediateEffects_d__8>.NativeClassPtr, "<>3__match");
				RapidMobilizationAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RapidMobilizationAbility._RunImmediateEffects_d__8>.NativeClassPtr, "<>8__1");
				RapidMobilizationAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RapidMobilizationAbility._RunImmediateEffects_d__8>.NativeClassPtr, "<player>5__2");
				RapidMobilizationAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RapidMobilizationAbility._RunImmediateEffects_d__8>.NativeClassPtr, 100679662);
				RapidMobilizationAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RapidMobilizationAbility._RunImmediateEffects_d__8>.NativeClassPtr, 100679663);
				RapidMobilizationAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RapidMobilizationAbility._RunImmediateEffects_d__8>.NativeClassPtr, 100679664);
				RapidMobilizationAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RapidMobilizationAbility._RunImmediateEffects_d__8>.NativeClassPtr, 100679665);
				RapidMobilizationAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RapidMobilizationAbility._RunImmediateEffects_d__8>.NativeClassPtr, 100679666);
				RapidMobilizationAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RapidMobilizationAbility._RunImmediateEffects_d__8>.NativeClassPtr, 100679667);
				RapidMobilizationAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RapidMobilizationAbility._RunImmediateEffects_d__8>.NativeClassPtr, 100679668);
				RapidMobilizationAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RapidMobilizationAbility._RunImmediateEffects_d__8>.NativeClassPtr, 100679669);
			}

			// Token: 0x0600B4CE RID: 46286 RVA: 0x002D535C File Offset: 0x002D355C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RunImmediateEffects_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RapidMobilizationAbility._RunImmediateEffects_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RapidMobilizationAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600B4CF RID: 46287 RVA: 0x002D53A4 File Offset: 0x002D35A4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RapidMobilizationAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B4D0 RID: 46288 RVA: 0x002D53D8 File Offset: 0x002D35D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237570, XrefRangeEnd = 237585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RapidMobilizationAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700377E RID: 14206
			// (get) Token: 0x0600B4D1 RID: 46289 RVA: 0x002D5414 File Offset: 0x002D3614
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RapidMobilizationAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600B4D2 RID: 46290 RVA: 0x002D5454 File Offset: 0x002D3654
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237585, XrefRangeEnd = 237590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RapidMobilizationAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700377F RID: 14207
			// (get) Token: 0x0600B4D3 RID: 46291 RVA: 0x002D5488 File Offset: 0x002D3688
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RapidMobilizationAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B4D4 RID: 46292 RVA: 0x002D54C8 File Offset: 0x002D36C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237590, XrefRangeEnd = 237600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RapidMobilizationAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600B4D5 RID: 46293 RVA: 0x002D5508 File Offset: 0x002D3708
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RapidMobilizationAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600B4D6 RID: 46294 RVA: 0x00053519 File Offset: 0x00051719
			public _RunImmediateEffects_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003774 RID: 14196
			// (get) Token: 0x0600B4D7 RID: 46295 RVA: 0x002D5548 File Offset: 0x002D3748
			// (set) Token: 0x0600B4D8 RID: 46296 RVA: 0x00053522 File Offset: 0x00051722
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RapidMobilizationAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RapidMobilizationAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003775 RID: 14197
			// (get) Token: 0x0600B4D9 RID: 46297 RVA: 0x002D5570 File Offset: 0x002D3770
			// (set) Token: 0x0600B4DA RID: 46298 RVA: 0x0005353D File Offset: 0x0005173D
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RapidMobilizationAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RapidMobilizationAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003776 RID: 14198
			// (get) Token: 0x0600B4DB RID: 46299 RVA: 0x002D55A0 File Offset: 0x002D37A0
			// (set) Token: 0x0600B4DC RID: 46300 RVA: 0x0005355C File Offset: 0x0005175C
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RapidMobilizationAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RapidMobilizationAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17003777 RID: 14199
			// (get) Token: 0x0600B4DD RID: 46301 RVA: 0x002D55C8 File Offset: 0x002D37C8
			// (set) Token: 0x0600B4DE RID: 46302 RVA: 0x00053577 File Offset: 0x00051777
			public unsafe RapidMobilizationAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RapidMobilizationAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RapidMobilizationAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RapidMobilizationAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003778 RID: 14200
			// (get) Token: 0x0600B4DF RID: 46303 RVA: 0x002D55F8 File Offset: 0x002D37F8
			// (set) Token: 0x0600B4E0 RID: 46304 RVA: 0x00053596 File Offset: 0x00051796
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RapidMobilizationAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RapidMobilizationAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003779 RID: 14201
			// (get) Token: 0x0600B4E1 RID: 46305 RVA: 0x002D5628 File Offset: 0x002D3828
			// (set) Token: 0x0600B4E2 RID: 46306 RVA: 0x000535B5 File Offset: 0x000517B5
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RapidMobilizationAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RapidMobilizationAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700377A RID: 14202
			// (get) Token: 0x0600B4E3 RID: 46307 RVA: 0x002D5658 File Offset: 0x002D3858
			// (set) Token: 0x0600B4E4 RID: 46308 RVA: 0x000535D4 File Offset: 0x000517D4
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RapidMobilizationAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RapidMobilizationAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700377B RID: 14203
			// (get) Token: 0x0600B4E5 RID: 46309 RVA: 0x002D5688 File Offset: 0x002D3888
			// (set) Token: 0x0600B4E6 RID: 46310 RVA: 0x000535F3 File Offset: 0x000517F3
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RapidMobilizationAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RapidMobilizationAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700377C RID: 14204
			// (get) Token: 0x0600B4E7 RID: 46311 RVA: 0x002D56B8 File Offset: 0x002D38B8
			// (set) Token: 0x0600B4E8 RID: 46312 RVA: 0x00053612 File Offset: 0x00051812
			public unsafe RapidMobilizationAbility.__c__DisplayClass8_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RapidMobilizationAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RapidMobilizationAbility.__c__DisplayClass8_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RapidMobilizationAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700377D RID: 14205
			// (get) Token: 0x0600B4E9 RID: 46313 RVA: 0x002D56E8 File Offset: 0x002D38E8
			// (set) Token: 0x0600B4EA RID: 46314 RVA: 0x00053631 File Offset: 0x00051831
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RapidMobilizationAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RapidMobilizationAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040071E2 RID: 29154
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040071E3 RID: 29155
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040071E4 RID: 29156
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040071E5 RID: 29157
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040071E6 RID: 29158
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x040071E7 RID: 29159
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x040071E8 RID: 29160
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x040071E9 RID: 29161
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x040071EA RID: 29162
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040071EB RID: 29163
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x040071EC RID: 29164
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040071ED RID: 29165
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040071EE RID: 29166
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040071EF RID: 29167
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040071F0 RID: 29168
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040071F1 RID: 29169
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040071F2 RID: 29170
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040071F3 RID: 29171
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000B2E RID: 2862
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.RapidMobilizationAbility+<Targets>d__6")]
		public sealed class _Targets_d__6 : Object
		{
			// Token: 0x0600B4EB RID: 46315 RVA: 0x002D5718 File Offset: 0x002D3918
			// Note: this type is marked as 'beforefieldinit'.
			static _Targets_d__6()
			{
				Il2CppClassPointerStore<RapidMobilizationAbility._Targets_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RapidMobilizationAbility>.NativeClassPtr, "<Targets>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RapidMobilizationAbility._Targets_d__6>.NativeClassPtr);
				RapidMobilizationAbility._Targets_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RapidMobilizationAbility._Targets_d__6>.NativeClassPtr, "<>1__state");
				RapidMobilizationAbility._Targets_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RapidMobilizationAbility._Targets_d__6>.NativeClassPtr, "<>2__current");
				RapidMobilizationAbility._Targets_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RapidMobilizationAbility._Targets_d__6>.NativeClassPtr, "<>l__initialThreadId");
				RapidMobilizationAbility._Targets_d__6.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RapidMobilizationAbility._Targets_d__6>.NativeClassPtr, "context");
				RapidMobilizationAbility._Targets_d__6.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RapidMobilizationAbility._Targets_d__6>.NativeClassPtr, "<>3__context");
				RapidMobilizationAbility._Targets_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RapidMobilizationAbility._Targets_d__6>.NativeClassPtr, "<>4__this");
				RapidMobilizationAbility._Targets_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RapidMobilizationAbility._Targets_d__6>.NativeClassPtr, 100679670);
				RapidMobilizationAbility._Targets_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RapidMobilizationAbility._Targets_d__6>.NativeClassPtr, 100679671);
				RapidMobilizationAbility._Targets_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RapidMobilizationAbility._Targets_d__6>.NativeClassPtr, 100679672);
				RapidMobilizationAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RapidMobilizationAbility._Targets_d__6>.NativeClassPtr, 100679673);
				RapidMobilizationAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RapidMobilizationAbility._Targets_d__6>.NativeClassPtr, 100679674);
				RapidMobilizationAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RapidMobilizationAbility._Targets_d__6>.NativeClassPtr, 100679675);
				RapidMobilizationAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RapidMobilizationAbility._Targets_d__6>.NativeClassPtr, 100679676);
				RapidMobilizationAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RapidMobilizationAbility._Targets_d__6>.NativeClassPtr, 100679677);
			}

			// Token: 0x0600B4EC RID: 46316 RVA: 0x002D585C File Offset: 0x002D3A5C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Targets_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RapidMobilizationAbility._Targets_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RapidMobilizationAbility._Targets_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600B4ED RID: 46317 RVA: 0x002D58A4 File Offset: 0x002D3AA4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RapidMobilizationAbility._Targets_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B4EE RID: 46318 RVA: 0x002D58D8 File Offset: 0x002D3AD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237600, XrefRangeEnd = 237675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RapidMobilizationAbility._Targets_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003786 RID: 14214
			// (get) Token: 0x0600B4EF RID: 46319 RVA: 0x002D5914 File Offset: 0x002D3B14
			public unsafe TargetInformation System.Collections.Generic.IEnumerator<Networking.selection.targetinformation.TargetInformation>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RapidMobilizationAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetInformation>(intPtr3) : null;
				}
			}

			// Token: 0x0600B4F0 RID: 46320 RVA: 0x002D5954 File Offset: 0x002D3B54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237675, XrefRangeEnd = 237680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RapidMobilizationAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003787 RID: 14215
			// (get) Token: 0x0600B4F1 RID: 46321 RVA: 0x002D5988 File Offset: 0x002D3B88
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RapidMobilizationAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600B4F2 RID: 46322 RVA: 0x002D59C8 File Offset: 0x002D3BC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237680, XrefRangeEnd = 237689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TargetInformation> System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RapidMobilizationAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TargetInformation>>(intPtr3) : null;
			}

			// Token: 0x0600B4F3 RID: 46323 RVA: 0x002D5A08 File Offset: 0x002D3C08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RapidMobilizationAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600B4F4 RID: 46324 RVA: 0x00053650 File Offset: 0x00051850
			public _Targets_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003780 RID: 14208
			// (get) Token: 0x0600B4F5 RID: 46325 RVA: 0x002D5A48 File Offset: 0x002D3C48
			// (set) Token: 0x0600B4F6 RID: 46326 RVA: 0x00053659 File Offset: 0x00051859
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RapidMobilizationAbility._Targets_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RapidMobilizationAbility._Targets_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003781 RID: 14209
			// (get) Token: 0x0600B4F7 RID: 46327 RVA: 0x002D5A70 File Offset: 0x002D3C70
			// (set) Token: 0x0600B4F8 RID: 46328 RVA: 0x00053674 File Offset: 0x00051874
			public unsafe TargetInformation __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RapidMobilizationAbility._Targets_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TargetInformation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RapidMobilizationAbility._Targets_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003782 RID: 14210
			// (get) Token: 0x0600B4F9 RID: 46329 RVA: 0x002D5AA0 File Offset: 0x002D3CA0
			// (set) Token: 0x0600B4FA RID: 46330 RVA: 0x00053693 File Offset: 0x00051893
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RapidMobilizationAbility._Targets_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RapidMobilizationAbility._Targets_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17003783 RID: 14211
			// (get) Token: 0x0600B4FB RID: 46331 RVA: 0x002D5AC8 File Offset: 0x002D3CC8
			// (set) Token: 0x0600B4FC RID: 46332 RVA: 0x000536AE File Offset: 0x000518AE
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RapidMobilizationAbility._Targets_d__6.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RapidMobilizationAbility._Targets_d__6.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003784 RID: 14212
			// (get) Token: 0x0600B4FD RID: 46333 RVA: 0x002D5AF8 File Offset: 0x002D3CF8
			// (set) Token: 0x0600B4FE RID: 46334 RVA: 0x000536CD File Offset: 0x000518CD
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RapidMobilizationAbility._Targets_d__6.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RapidMobilizationAbility._Targets_d__6.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003785 RID: 14213
			// (get) Token: 0x0600B4FF RID: 46335 RVA: 0x002D5B28 File Offset: 0x002D3D28
			// (set) Token: 0x0600B500 RID: 46336 RVA: 0x000536EC File Offset: 0x000518EC
			public unsafe RapidMobilizationAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RapidMobilizationAbility._Targets_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RapidMobilizationAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RapidMobilizationAbility._Targets_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040071F4 RID: 29172
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040071F5 RID: 29173
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040071F6 RID: 29174
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040071F7 RID: 29175
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x040071F8 RID: 29176
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x040071F9 RID: 29177
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040071FA RID: 29178
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040071FB RID: 29179
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040071FC RID: 29180
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040071FD RID: 29181
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0;

			// Token: 0x040071FE RID: 29182
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040071FF RID: 29183
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04007200 RID: 29184
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0;

			// Token: 0x04007201 RID: 29185
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
