using System;
using System.Runtime.InteropServices;
using Canis;
using Canis.actions;
using Canis.context;
using Canis.entities;
using Canis.entities.ai;
using Canis.gameLogs;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lib.canis.data.enums;
using Networking.selection.targetinformation;
using worm.canis.ai;
using worm.canis.ai.choices;
using worm.canis.entities;

namespace worm.canis.abilities.ActivatedAbilities.RiseOfIx
{
	// Token: 0x020004D3 RID: 1235
	public class DesertAmbushAbility : DeferredAbility
	{
		// Token: 0x060037E3 RID: 14307 RVA: 0x00149EB8 File Offset: 0x001480B8
		// Note: this type is marked as 'beforefieldinit'.
		static DesertAmbushAbility()
		{
			Il2CppClassPointerStore<DesertAmbushAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.ActivatedAbilities.RiseOfIx", "DesertAmbushAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DesertAmbushAbility>.NativeClassPtr);
			DesertAmbushAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility>.NativeClassPtr, "AbilityName");
			DesertAmbushAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility>.NativeClassPtr, "AbilityID");
			DesertAmbushAbility.NativeFieldInfoPtr_DefaultLogToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility>.NativeClassPtr, "DefaultLogToken");
			DesertAmbushAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility>.NativeClassPtr, 100681063);
			DesertAmbushAbility.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility>.NativeClassPtr, 100681064);
			DesertAmbushAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility>.NativeClassPtr, 100681065);
			DesertAmbushAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility>.NativeClassPtr, 100681066);
			DesertAmbushAbility.NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility>.NativeClassPtr, 100681067);
			DesertAmbushAbility.NativeMethodInfoPtr_GetRemainingAmbushCount_Public_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility>.NativeClassPtr, 100681068);
			DesertAmbushAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility>.NativeClassPtr, 100681069);
			DesertAmbushAbility.NativeMethodInfoPtr_SelectionMode_Public_Virtual_DeferredSelectionMode_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility>.NativeClassPtr, 100681070);
			DesertAmbushAbility.NativeMethodInfoPtr_CanRunImmediately_Public_Virtual_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility>.NativeClassPtr, 100681071);
			DesertAmbushAbility.NativeMethodInfoPtr_IsUnexhausted_Protected_Virtual_Boolean_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility>.NativeClassPtr, 100681072);
			DesertAmbushAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility>.NativeClassPtr, 100681073);
			DesertAmbushAbility.NativeMethodInfoPtr_Undo_Public_Virtual_IEnumerable_1_Action_UndoNode_PlayerEntity_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility>.NativeClassPtr, 100681074);
			DesertAmbushAbility.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility>.NativeClassPtr, 100681075);
			DesertAmbushAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility>.NativeClassPtr, 100681076);
			DesertAmbushAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility>.NativeClassPtr, 100681077);
		}

		// Token: 0x060037E4 RID: 14308 RVA: 0x0014A050 File Offset: 0x00148250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249430, XrefRangeEnd = 249434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DesertAmbushAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x060037E5 RID: 14309 RVA: 0x0014A09C File Offset: 0x0014829C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249434, XrefRangeEnd = 249444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override GameLogBuilder MakeGameLogBuilder(IHasGameLogs hasGameLogs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hasGameLogs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DesertAmbushAbility.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x060037E6 RID: 14310 RVA: 0x0014A0F8 File Offset: 0x001482F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249444, XrefRangeEnd = 249457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DesertAmbushAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DesertAmbushAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037E7 RID: 14311 RVA: 0x0014A144 File Offset: 0x00148344
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 24983, RefRangeEnd = 24988, XrefRangeStart = 24983, XrefRangeEnd = 24988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DesertAmbushAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DesertAmbushAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037E8 RID: 14312 RVA: 0x0014A1B4 File Offset: 0x001483B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249457, XrefRangeEnd = 249464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DesertAmbushAbility.NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TargetInformation>>(intPtr3) : null;
		}

		// Token: 0x060037E9 RID: 14313 RVA: 0x0014A224 File Offset: 0x00148424
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 249489, RefRangeEnd = 249491, XrefRangeStart = 249464, XrefRangeEnd = 249489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetRemainingAmbushCount(WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility.NativeMethodInfoPtr_GetRemainingAmbushCount_Public_Int32_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060037EA RID: 14314 RVA: 0x0014A274 File Offset: 0x00148474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249491, XrefRangeEnd = 249507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DesertAmbushAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x060037EB RID: 14315 RVA: 0x0014A2E4 File Offset: 0x001484E4
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DeferredSelectionMode SelectionMode(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DesertAmbushAbility.NativeMethodInfoPtr_SelectionMode_Public_Virtual_DeferredSelectionMode_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060037EC RID: 14316 RVA: 0x0014A33C File Offset: 0x0014853C
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanRunImmediately(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DesertAmbushAbility.NativeMethodInfoPtr_CanRunImmediately_Public_Virtual_Boolean_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060037ED RID: 14317 RVA: 0x0014A394 File Offset: 0x00148594
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsUnexhausted(PlayerEntity player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DesertAmbushAbility.NativeMethodInfoPtr_IsUnexhausted_Protected_Virtual_Boolean_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060037EE RID: 14318 RVA: 0x0014A3EC File Offset: 0x001485EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249507, XrefRangeEnd = 249516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> BeginExecution(WormActiveAbility activeAbility, WormMatch match, Context context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DesertAmbushAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060037EF RID: 14319 RVA: 0x0014A46C File Offset: 0x0014866C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249516, XrefRangeEnd = 249524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DesertAmbushAbility.NativeMethodInfoPtr_Undo_Public_Virtual_IEnumerable_1_Action_UndoNode_PlayerEntity_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060037F0 RID: 14320 RVA: 0x0014A500 File Offset: 0x00148700
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25007, RefRangeEnd = 25008, XrefRangeStart = 25007, XrefRangeEnd = 25008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ResumeExecution(WormActiveAbility activeAbility, global::Canis.actions.Action returningAction, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activeAbility);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(returningAction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DesertAmbushAbility.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060037F1 RID: 14321 RVA: 0x0014A57C File Offset: 0x0014877C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249524, XrefRangeEnd = 249564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AIValueSummer<double> ValueForPlayer(WormPlayer player, [Optional] Il2CppReferenceArray<WormEntity> withEntities)
		{
			if (withEntities == null)
			{
				withEntities = new Il2CppReferenceArray<WormEntity>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(withEntities);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DesertAmbushAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
		}

		// Token: 0x060037F2 RID: 14322 RVA: 0x0014A5F8 File Offset: 0x001487F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249564, XrefRangeEnd = 249766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WormAIChoice Evaluate(WormAIChoiceContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DesertAmbushAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormAIChoice>(intPtr3) : null;
			}
		}

		// Token: 0x060037F3 RID: 14323 RVA: 0x00012A3F File Offset: 0x00010C3F
		public override AIValueSummer<double> ValueForPlayer(WormPlayer player, params WormEntity[] withEntities)
		{
			return this.ValueForPlayer(player, new Il2CppReferenceArray<WormEntity>(withEntities));
		}

		// Token: 0x060037F4 RID: 14324 RVA: 0x00012A4E File Offset: 0x00010C4E
		public DesertAmbushAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DF2 RID: 3570
		// (get) Token: 0x060037F5 RID: 14325 RVA: 0x0014A654 File Offset: 0x00148854
		// (set) Token: 0x060037F6 RID: 14326 RVA: 0x00012A57 File Offset: 0x00010C57
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DesertAmbushAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DesertAmbushAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DF3 RID: 3571
		// (get) Token: 0x060037F7 RID: 14327 RVA: 0x0014A674 File Offset: 0x00148874
		// (set) Token: 0x060037F8 RID: 14328 RVA: 0x00012A69 File Offset: 0x00010C69
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DesertAmbushAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DesertAmbushAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DF4 RID: 3572
		// (get) Token: 0x060037F9 RID: 14329 RVA: 0x0014A69C File Offset: 0x0014889C
		// (set) Token: 0x060037FA RID: 14330 RVA: 0x00012A7B File Offset: 0x00010C7B
		public unsafe static string DefaultLogToken
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DesertAmbushAbility.NativeFieldInfoPtr_DefaultLogToken, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DesertAmbushAbility.NativeFieldInfoPtr_DefaultLogToken, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400249C RID: 9372
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x0400249D RID: 9373
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x0400249E RID: 9374
		private static readonly IntPtr NativeFieldInfoPtr_DefaultLogToken;

		// Token: 0x0400249F RID: 9375
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x040024A0 RID: 9376
		private static readonly IntPtr NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0;

		// Token: 0x040024A1 RID: 9377
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x040024A2 RID: 9378
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x040024A3 RID: 9379
		private static readonly IntPtr NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0;

		// Token: 0x040024A4 RID: 9380
		private static readonly IntPtr NativeMethodInfoPtr_GetRemainingAmbushCount_Public_Int32_WormPlayer_0;

		// Token: 0x040024A5 RID: 9381
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0;

		// Token: 0x040024A6 RID: 9382
		private static readonly IntPtr NativeMethodInfoPtr_SelectionMode_Public_Virtual_DeferredSelectionMode_Context_0;

		// Token: 0x040024A7 RID: 9383
		private static readonly IntPtr NativeMethodInfoPtr_CanRunImmediately_Public_Virtual_Boolean_Context_0;

		// Token: 0x040024A8 RID: 9384
		private static readonly IntPtr NativeMethodInfoPtr_IsUnexhausted_Protected_Virtual_Boolean_PlayerEntity_0;

		// Token: 0x040024A9 RID: 9385
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x040024AA RID: 9386
		private static readonly IntPtr NativeMethodInfoPtr_Undo_Public_Virtual_IEnumerable_1_Action_UndoNode_PlayerEntity_Match_Context_0;

		// Token: 0x040024AB RID: 9387
		private static readonly IntPtr NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0;

		// Token: 0x040024AC RID: 9388
		private static readonly IntPtr NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0;

		// Token: 0x040024AD RID: 9389
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0;

		// Token: 0x02000BAE RID: 2990
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.RiseOfIx.DesertAmbushAbility+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600BED8 RID: 48856 RVA: 0x002F22A4 File Offset: 0x002F04A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DesertAmbushAbility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DesertAmbushAbility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DesertAmbushAbility.__c>.NativeClassPtr);
				DesertAmbushAbility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility.__c>.NativeClassPtr, "<>9");
				DesertAmbushAbility.__c.NativeFieldInfoPtr___9__7_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility.__c>.NativeClassPtr, "<>9__7_1");
				DesertAmbushAbility.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility.__c>.NativeClassPtr, "<>9__13_0");
				DesertAmbushAbility.__c.NativeFieldInfoPtr___9__13_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility.__c>.NativeClassPtr, "<>9__13_3");
				DesertAmbushAbility.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility.__c>.NativeClassPtr, "<>9__16_0");
				DesertAmbushAbility.__c.NativeFieldInfoPtr___9__17_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility.__c>.NativeClassPtr, "<>9__17_6");
				DesertAmbushAbility.__c.NativeFieldInfoPtr___9__17_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility.__c>.NativeClassPtr, "<>9__17_7");
				DesertAmbushAbility.__c.NativeFieldInfoPtr___9__17_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility.__c>.NativeClassPtr, "<>9__17_3");
				DesertAmbushAbility.__c.NativeFieldInfoPtr___9__17_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility.__c>.NativeClassPtr, "<>9__17_1");
				DesertAmbushAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility.__c>.NativeClassPtr, 100681080);
				DesertAmbushAbility.__c.NativeMethodInfoPtr__Targets_b__7_1_Internal_IEnumerable_1_Entity_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility.__c>.NativeClassPtr, 100681081);
				DesertAmbushAbility.__c.NativeMethodInfoPtr__BeginExecution_b__13_0_Internal_PlayerEntity_WormUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility.__c>.NativeClassPtr, 100681082);
				DesertAmbushAbility.__c.NativeMethodInfoPtr__BeginExecution_b__13_3_Internal_GameLogBuilder_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility.__c>.NativeClassPtr, 100681083);
				DesertAmbushAbility.__c.NativeMethodInfoPtr__ValueForPlayer_b__16_0_Internal_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility.__c>.NativeClassPtr, 100681084);
				DesertAmbushAbility.__c.NativeMethodInfoPtr__Evaluate_b__17_6_Internal_Int32_WormUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility.__c>.NativeClassPtr, 100681085);
				DesertAmbushAbility.__c.NativeMethodInfoPtr__Evaluate_b__17_7_Internal_Int32_WormUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility.__c>.NativeClassPtr, 100681086);
				DesertAmbushAbility.__c.NativeMethodInfoPtr__Evaluate_b__17_3_Internal_Int32_WormUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility.__c>.NativeClassPtr, 100681087);
				DesertAmbushAbility.__c.NativeMethodInfoPtr__Evaluate_b__17_1_Internal_EntityID_WormUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility.__c>.NativeClassPtr, 100681088);
			}

			// Token: 0x0600BED9 RID: 48857 RVA: 0x002F2438 File Offset: 0x002F0638
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DesertAmbushAbility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BEDA RID: 48858 RVA: 0x002F2474 File Offset: 0x002F0674
			[CallerCount(0)]
			public unsafe IEnumerable<Entity> _Targets_b__7_1(WormPlayArea _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility.__c.NativeMethodInfoPtr__Targets_b__7_1_Internal_IEnumerable_1_Entity_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x0600BEDB RID: 48859 RVA: 0x002F24C4 File Offset: 0x002F06C4
			[CallerCount(0)]
			public unsafe PlayerEntity _BeginExecution_b__13_0(WormUnit _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility.__c.NativeMethodInfoPtr__BeginExecution_b__13_0_Internal_PlayerEntity_WormUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr3) : null;
				}
			}

			// Token: 0x0600BEDC RID: 48860 RVA: 0x002F2514 File Offset: 0x002F0714
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249016, XrefRangeEnd = 249020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GameLogBuilder _BeginExecution_b__13_3(GameLogBuilder _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility.__c.NativeMethodInfoPtr__BeginExecution_b__13_3_Internal_GameLogBuilder_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x0600BEDD RID: 48861 RVA: 0x002F2564 File Offset: 0x002F0764
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249020, XrefRangeEnd = 249022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _ValueForPlayer_b__16_0(WormPlayer opponent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(opponent);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility.__c.NativeMethodInfoPtr__ValueForPlayer_b__16_0_Internal_Int32_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BEDE RID: 48862 RVA: 0x002F25B4 File Offset: 0x002F07B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Evaluate_b__17_6(WormUnit _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility.__c.NativeMethodInfoPtr__Evaluate_b__17_6_Internal_Int32_WormUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BEDF RID: 48863 RVA: 0x002F2604 File Offset: 0x002F0804
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Evaluate_b__17_7(WormUnit _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility.__c.NativeMethodInfoPtr__Evaluate_b__17_7_Internal_Int32_WormUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BEE0 RID: 48864 RVA: 0x002F2654 File Offset: 0x002F0854
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Evaluate_b__17_3(WormUnit _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility.__c.NativeMethodInfoPtr__Evaluate_b__17_3_Internal_Int32_WormUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BEE1 RID: 48865 RVA: 0x002F26A4 File Offset: 0x002F08A4
			[CallerCount(0)]
			public unsafe EntityID _Evaluate_b__17_1(WormUnit _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility.__c.NativeMethodInfoPtr__Evaluate_b__17_1_Internal_EntityID_WormUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x0600BEE2 RID: 48866 RVA: 0x000592EE File Offset: 0x000574EE
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003B1C RID: 15132
			// (get) Token: 0x0600BEE3 RID: 48867 RVA: 0x002F26F4 File Offset: 0x002F08F4
			// (set) Token: 0x0600BEE4 RID: 48868 RVA: 0x000592F7 File Offset: 0x000574F7
			public unsafe static DesertAmbushAbility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DesertAmbushAbility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DesertAmbushAbility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DesertAmbushAbility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B1D RID: 15133
			// (get) Token: 0x0600BEE5 RID: 48869 RVA: 0x002F271C File Offset: 0x002F091C
			// (set) Token: 0x0600BEE6 RID: 48870 RVA: 0x00059309 File Offset: 0x00057509
			public unsafe static Func<WormPlayArea, IEnumerable<Entity>> __9__7_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DesertAmbushAbility.__c.NativeFieldInfoPtr___9__7_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayArea, IEnumerable<Entity>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DesertAmbushAbility.__c.NativeFieldInfoPtr___9__7_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B1E RID: 15134
			// (get) Token: 0x0600BEE7 RID: 48871 RVA: 0x002F2744 File Offset: 0x002F0944
			// (set) Token: 0x0600BEE8 RID: 48872 RVA: 0x0005931B File Offset: 0x0005751B
			public unsafe static Func<WormUnit, PlayerEntity> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DesertAmbushAbility.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormUnit, PlayerEntity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DesertAmbushAbility.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B1F RID: 15135
			// (get) Token: 0x0600BEE9 RID: 48873 RVA: 0x002F276C File Offset: 0x002F096C
			// (set) Token: 0x0600BEEA RID: 48874 RVA: 0x0005932D File Offset: 0x0005752D
			public unsafe static Func<GameLogBuilder, GameLogBuilder> __9__13_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DesertAmbushAbility.__c.NativeFieldInfoPtr___9__13_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GameLogBuilder, GameLogBuilder>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DesertAmbushAbility.__c.NativeFieldInfoPtr___9__13_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B20 RID: 15136
			// (get) Token: 0x0600BEEB RID: 48875 RVA: 0x002F2794 File Offset: 0x002F0994
			// (set) Token: 0x0600BEEC RID: 48876 RVA: 0x0005933F File Offset: 0x0005753F
			public unsafe static Func<WormPlayer, int> __9__16_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DesertAmbushAbility.__c.NativeFieldInfoPtr___9__16_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DesertAmbushAbility.__c.NativeFieldInfoPtr___9__16_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B21 RID: 15137
			// (get) Token: 0x0600BEED RID: 48877 RVA: 0x002F27BC File Offset: 0x002F09BC
			// (set) Token: 0x0600BEEE RID: 48878 RVA: 0x00059351 File Offset: 0x00057551
			public unsafe static Func<WormUnit, int> __9__17_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DesertAmbushAbility.__c.NativeFieldInfoPtr___9__17_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormUnit, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DesertAmbushAbility.__c.NativeFieldInfoPtr___9__17_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B22 RID: 15138
			// (get) Token: 0x0600BEEF RID: 48879 RVA: 0x002F27E4 File Offset: 0x002F09E4
			// (set) Token: 0x0600BEF0 RID: 48880 RVA: 0x00059363 File Offset: 0x00057563
			public unsafe static Func<WormUnit, int> __9__17_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DesertAmbushAbility.__c.NativeFieldInfoPtr___9__17_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormUnit, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DesertAmbushAbility.__c.NativeFieldInfoPtr___9__17_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B23 RID: 15139
			// (get) Token: 0x0600BEF1 RID: 48881 RVA: 0x002F280C File Offset: 0x002F0A0C
			// (set) Token: 0x0600BEF2 RID: 48882 RVA: 0x00059375 File Offset: 0x00057575
			public unsafe static Func<WormUnit, int> __9__17_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DesertAmbushAbility.__c.NativeFieldInfoPtr___9__17_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormUnit, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DesertAmbushAbility.__c.NativeFieldInfoPtr___9__17_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B24 RID: 15140
			// (get) Token: 0x0600BEF3 RID: 48883 RVA: 0x002F2834 File Offset: 0x002F0A34
			// (set) Token: 0x0600BEF4 RID: 48884 RVA: 0x00059387 File Offset: 0x00057587
			public unsafe static Func<WormUnit, EntityID> __9__17_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DesertAmbushAbility.__c.NativeFieldInfoPtr___9__17_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormUnit, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DesertAmbushAbility.__c.NativeFieldInfoPtr___9__17_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040077DB RID: 30683
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040077DC RID: 30684
			private static readonly IntPtr NativeFieldInfoPtr___9__7_1;

			// Token: 0x040077DD RID: 30685
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x040077DE RID: 30686
			private static readonly IntPtr NativeFieldInfoPtr___9__13_3;

			// Token: 0x040077DF RID: 30687
			private static readonly IntPtr NativeFieldInfoPtr___9__16_0;

			// Token: 0x040077E0 RID: 30688
			private static readonly IntPtr NativeFieldInfoPtr___9__17_6;

			// Token: 0x040077E1 RID: 30689
			private static readonly IntPtr NativeFieldInfoPtr___9__17_7;

			// Token: 0x040077E2 RID: 30690
			private static readonly IntPtr NativeFieldInfoPtr___9__17_3;

			// Token: 0x040077E3 RID: 30691
			private static readonly IntPtr NativeFieldInfoPtr___9__17_1;

			// Token: 0x040077E4 RID: 30692
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040077E5 RID: 30693
			private static readonly IntPtr NativeMethodInfoPtr__Targets_b__7_1_Internal_IEnumerable_1_Entity_WormPlayArea_0;

			// Token: 0x040077E6 RID: 30694
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__13_0_Internal_PlayerEntity_WormUnit_0;

			// Token: 0x040077E7 RID: 30695
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__13_3_Internal_GameLogBuilder_GameLogBuilder_0;

			// Token: 0x040077E8 RID: 30696
			private static readonly IntPtr NativeMethodInfoPtr__ValueForPlayer_b__16_0_Internal_Int32_WormPlayer_0;

			// Token: 0x040077E9 RID: 30697
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__17_6_Internal_Int32_WormUnit_0;

			// Token: 0x040077EA RID: 30698
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__17_7_Internal_Int32_WormUnit_0;

			// Token: 0x040077EB RID: 30699
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__17_3_Internal_Int32_WormUnit_0;

			// Token: 0x040077EC RID: 30700
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__17_1_Internal_EntityID_WormUnit_0;
		}

		// Token: 0x02000BAF RID: 2991
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.RiseOfIx.DesertAmbushAbility+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Object
		{
			// Token: 0x0600BEF5 RID: 48885 RVA: 0x002F285C File Offset: 0x002F0A5C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<DesertAmbushAbility.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DesertAmbushAbility>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DesertAmbushAbility.__c__DisplayClass13_0>.NativeClassPtr);
				DesertAmbushAbility.__c__DisplayClass13_0.NativeFieldInfoPtr_opponentEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility.__c__DisplayClass13_0>.NativeClassPtr, "opponentEntity");
				DesertAmbushAbility.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
				DesertAmbushAbility.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility.__c__DisplayClass13_0>.NativeClassPtr, 100681089);
				DesertAmbushAbility.__c__DisplayClass13_0.NativeMethodInfoPtr__BeginExecution_b__1_Internal_Boolean_WormUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility.__c__DisplayClass13_0>.NativeClassPtr, 100681090);
			}

			// Token: 0x0600BEF6 RID: 48886 RVA: 0x002F28D8 File Offset: 0x002F0AD8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DesertAmbushAbility.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BEF7 RID: 48887 RVA: 0x002F2914 File Offset: 0x002F0B14
			[CallerCount(0)]
			public unsafe bool _BeginExecution_b__1(WormUnit _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility.__c__DisplayClass13_0.NativeMethodInfoPtr__BeginExecution_b__1_Internal_Boolean_WormUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BEF8 RID: 48888 RVA: 0x00059399 File Offset: 0x00057599
			public __c__DisplayClass13_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003B25 RID: 15141
			// (get) Token: 0x0600BEF9 RID: 48889 RVA: 0x002F2964 File Offset: 0x002F0B64
			// (set) Token: 0x0600BEFA RID: 48890 RVA: 0x000593A2 File Offset: 0x000575A2
			public unsafe PlayerEntity opponentEntity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility.__c__DisplayClass13_0.NativeFieldInfoPtr_opponentEntity);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility.__c__DisplayClass13_0.NativeFieldInfoPtr_opponentEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B26 RID: 15142
			// (get) Token: 0x0600BEFB RID: 48891 RVA: 0x002F2994 File Offset: 0x002F0B94
			// (set) Token: 0x0600BEFC RID: 48892 RVA: 0x000593C1 File Offset: 0x000575C1
			public unsafe DesertAmbushAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DesertAmbushAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040077ED RID: 30701
			private static readonly IntPtr NativeFieldInfoPtr_opponentEntity;

			// Token: 0x040077EE RID: 30702
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040077EF RID: 30703
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040077F0 RID: 30704
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__1_Internal_Boolean_WormUnit_0;
		}

		// Token: 0x02000BB0 RID: 2992
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.RiseOfIx.DesertAmbushAbility+<>c__DisplayClass13_1")]
		public sealed class __c__DisplayClass13_1 : Object
		{
			// Token: 0x0600BEFD RID: 48893 RVA: 0x002F29C4 File Offset: 0x002F0BC4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_1()
			{
				Il2CppClassPointerStore<DesertAmbushAbility.__c__DisplayClass13_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DesertAmbushAbility>.NativeClassPtr, "<>c__DisplayClass13_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DesertAmbushAbility.__c__DisplayClass13_1>.NativeClassPtr);
				DesertAmbushAbility.__c__DisplayClass13_1.NativeFieldInfoPtr_opponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility.__c__DisplayClass13_1>.NativeClassPtr, "opponent");
				DesertAmbushAbility.__c__DisplayClass13_1.NativeFieldInfoPtr_opponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility.__c__DisplayClass13_1>.NativeClassPtr, "opponentCount");
				DesertAmbushAbility.__c__DisplayClass13_1.NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility.__c__DisplayClass13_1>.NativeClassPtr, "CS$<>8__locals1");
				DesertAmbushAbility.__c__DisplayClass13_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility.__c__DisplayClass13_1>.NativeClassPtr, 100681091);
				DesertAmbushAbility.__c__DisplayClass13_1.NativeMethodInfoPtr__BeginExecution_b__2_Internal_GameLogBuilder_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility.__c__DisplayClass13_1>.NativeClassPtr, 100681092);
			}

			// Token: 0x0600BEFE RID: 48894 RVA: 0x002F2A54 File Offset: 0x002F0C54
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DesertAmbushAbility.__c__DisplayClass13_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility.__c__DisplayClass13_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BEFF RID: 48895 RVA: 0x002F2A90 File Offset: 0x002F0C90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249022, XrefRangeEnd = 249033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GameLogBuilder _BeginExecution_b__2(GameLogBuilder _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility.__c__DisplayClass13_1.NativeMethodInfoPtr__BeginExecution_b__2_Internal_GameLogBuilder_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x0600BF00 RID: 48896 RVA: 0x000593E0 File Offset: 0x000575E0
			public __c__DisplayClass13_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003B27 RID: 15143
			// (get) Token: 0x0600BF01 RID: 48897 RVA: 0x002F2AE0 File Offset: 0x002F0CE0
			// (set) Token: 0x0600BF02 RID: 48898 RVA: 0x000593E9 File Offset: 0x000575E9
			public unsafe WormPlayer opponent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility.__c__DisplayClass13_1.NativeFieldInfoPtr_opponent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility.__c__DisplayClass13_1.NativeFieldInfoPtr_opponent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B28 RID: 15144
			// (get) Token: 0x0600BF03 RID: 48899 RVA: 0x002F2B10 File Offset: 0x002F0D10
			// (set) Token: 0x0600BF04 RID: 48900 RVA: 0x00059408 File Offset: 0x00057608
			public unsafe int opponentCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility.__c__DisplayClass13_1.NativeFieldInfoPtr_opponentCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility.__c__DisplayClass13_1.NativeFieldInfoPtr_opponentCount)) = value;
				}
			}

			// Token: 0x17003B29 RID: 15145
			// (get) Token: 0x0600BF05 RID: 48901 RVA: 0x002F2B38 File Offset: 0x002F0D38
			// (set) Token: 0x0600BF06 RID: 48902 RVA: 0x00059423 File Offset: 0x00057623
			public unsafe DesertAmbushAbility.__c__DisplayClass13_0 field_Public___c__DisplayClass13_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility.__c__DisplayClass13_1.NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DesertAmbushAbility.__c__DisplayClass13_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility.__c__DisplayClass13_1.NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040077F1 RID: 30705
			private static readonly IntPtr NativeFieldInfoPtr_opponent;

			// Token: 0x040077F2 RID: 30706
			private static readonly IntPtr NativeFieldInfoPtr_opponentCount;

			// Token: 0x040077F3 RID: 30707
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0;

			// Token: 0x040077F4 RID: 30708
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040077F5 RID: 30709
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__2_Internal_GameLogBuilder_GameLogBuilder_0;
		}

		// Token: 0x02000BB1 RID: 2993
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.RiseOfIx.DesertAmbushAbility+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Object
		{
			// Token: 0x0600BF07 RID: 48903 RVA: 0x002F2B68 File Offset: 0x002F0D68
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<DesertAmbushAbility.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DesertAmbushAbility>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DesertAmbushAbility.__c__DisplayClass17_0>.NativeClassPtr);
				DesertAmbushAbility.__c__DisplayClass17_0.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility.__c__DisplayClass17_0>.NativeClassPtr, "context");
				DesertAmbushAbility.__c__DisplayClass17_0.NativeFieldInfoPtr_unitTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility.__c__DisplayClass17_0>.NativeClassPtr, "unitTargets");
				DesertAmbushAbility.__c__DisplayClass17_0.NativeFieldInfoPtr_numberToSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility.__c__DisplayClass17_0>.NativeClassPtr, "numberToSelect");
				DesertAmbushAbility.__c__DisplayClass17_0.NativeFieldInfoPtr_estStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility.__c__DisplayClass17_0>.NativeClassPtr, "estStrength");
				DesertAmbushAbility.__c__DisplayClass17_0.NativeFieldInfoPtr_opponentTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility.__c__DisplayClass17_0>.NativeClassPtr, "opponentTarget");
				DesertAmbushAbility.__c__DisplayClass17_0.NativeFieldInfoPtr___9__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility.__c__DisplayClass17_0>.NativeClassPtr, "<>9__4");
				DesertAmbushAbility.__c__DisplayClass17_0.NativeFieldInfoPtr___9__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility.__c__DisplayClass17_0>.NativeClassPtr, "<>9__8");
				DesertAmbushAbility.__c__DisplayClass17_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility.__c__DisplayClass17_0>.NativeClassPtr, "<>9__2");
				DesertAmbushAbility.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility.__c__DisplayClass17_0>.NativeClassPtr, 100681093);
				DesertAmbushAbility.__c__DisplayClass17_0.NativeMethodInfoPtr__Evaluate_b__0_Internal_Boolean_Tuple_2_WormPlayer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility.__c__DisplayClass17_0>.NativeClassPtr, 100681094);
				DesertAmbushAbility.__c__DisplayClass17_0.NativeMethodInfoPtr__Evaluate_b__4_Internal_Boolean_Tuple_2_WormPlayer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility.__c__DisplayClass17_0>.NativeClassPtr, 100681095);
				DesertAmbushAbility.__c__DisplayClass17_0.NativeMethodInfoPtr__Evaluate_b__8_Internal_Boolean_Tuple_2_WormPlayer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility.__c__DisplayClass17_0>.NativeClassPtr, 100681096);
				DesertAmbushAbility.__c__DisplayClass17_0.NativeMethodInfoPtr__Evaluate_b__2_Internal_Boolean_WormUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility.__c__DisplayClass17_0>.NativeClassPtr, 100681097);
			}

			// Token: 0x0600BF08 RID: 48904 RVA: 0x002F2C98 File Offset: 0x002F0E98
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DesertAmbushAbility.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BF09 RID: 48905 RVA: 0x002F2CD4 File Offset: 0x002F0ED4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249033, XrefRangeEnd = 249034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Evaluate_b__0(Tuple<WormPlayer, int> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility.__c__DisplayClass17_0.NativeMethodInfoPtr__Evaluate_b__0_Internal_Boolean_Tuple_2_WormPlayer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BF0A RID: 48906 RVA: 0x002F2D24 File Offset: 0x002F0F24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249034, XrefRangeEnd = 249086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Evaluate_b__4(Tuple<WormPlayer, int> opp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(opp);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility.__c__DisplayClass17_0.NativeMethodInfoPtr__Evaluate_b__4_Internal_Boolean_Tuple_2_WormPlayer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BF0B RID: 48907 RVA: 0x002F2D74 File Offset: 0x002F0F74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249086, XrefRangeEnd = 249092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Evaluate_b__8(Tuple<WormPlayer, int> opp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(opp);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility.__c__DisplayClass17_0.NativeMethodInfoPtr__Evaluate_b__8_Internal_Boolean_Tuple_2_WormPlayer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BF0C RID: 48908 RVA: 0x002F2DC4 File Offset: 0x002F0FC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249092, XrefRangeEnd = 249093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Evaluate_b__2(WormUnit unit)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(unit);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility.__c__DisplayClass17_0.NativeMethodInfoPtr__Evaluate_b__2_Internal_Boolean_WormUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BF0D RID: 48909 RVA: 0x00059442 File Offset: 0x00057642
			public __c__DisplayClass17_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003B2A RID: 15146
			// (get) Token: 0x0600BF0E RID: 48910 RVA: 0x002F2E14 File Offset: 0x002F1014
			// (set) Token: 0x0600BF0F RID: 48911 RVA: 0x0005944B File Offset: 0x0005764B
			public unsafe WormAIChoiceContext context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility.__c__DisplayClass17_0.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAIChoiceContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility.__c__DisplayClass17_0.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B2B RID: 15147
			// (get) Token: 0x0600BF10 RID: 48912 RVA: 0x002F2E44 File Offset: 0x002F1044
			// (set) Token: 0x0600BF11 RID: 48913 RVA: 0x0005946A File Offset: 0x0005766A
			public unsafe List<WormUnit> unitTargets
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility.__c__DisplayClass17_0.NativeFieldInfoPtr_unitTargets);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormUnit>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility.__c__DisplayClass17_0.NativeFieldInfoPtr_unitTargets), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B2C RID: 15148
			// (get) Token: 0x0600BF12 RID: 48914 RVA: 0x002F2E74 File Offset: 0x002F1074
			// (set) Token: 0x0600BF13 RID: 48915 RVA: 0x00059489 File Offset: 0x00057689
			public unsafe int numberToSelect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility.__c__DisplayClass17_0.NativeFieldInfoPtr_numberToSelect);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility.__c__DisplayClass17_0.NativeFieldInfoPtr_numberToSelect)) = value;
				}
			}

			// Token: 0x17003B2D RID: 15149
			// (get) Token: 0x0600BF14 RID: 48916 RVA: 0x002F2E9C File Offset: 0x002F109C
			// (set) Token: 0x0600BF15 RID: 48917 RVA: 0x000594A4 File Offset: 0x000576A4
			public unsafe int estStrength
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility.__c__DisplayClass17_0.NativeFieldInfoPtr_estStrength);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility.__c__DisplayClass17_0.NativeFieldInfoPtr_estStrength)) = value;
				}
			}

			// Token: 0x17003B2E RID: 15150
			// (get) Token: 0x0600BF16 RID: 48918 RVA: 0x002F2EC4 File Offset: 0x002F10C4
			// (set) Token: 0x0600BF17 RID: 48919 RVA: 0x000594BF File Offset: 0x000576BF
			public unsafe Tuple<WormPlayer, int> opponentTarget
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility.__c__DisplayClass17_0.NativeFieldInfoPtr_opponentTarget);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tuple<WormPlayer, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility.__c__DisplayClass17_0.NativeFieldInfoPtr_opponentTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B2F RID: 15151
			// (get) Token: 0x0600BF18 RID: 48920 RVA: 0x002F2EF4 File Offset: 0x002F10F4
			// (set) Token: 0x0600BF19 RID: 48921 RVA: 0x000594DE File Offset: 0x000576DE
			public unsafe Func<Tuple<WormPlayer, int>, bool> __9__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility.__c__DisplayClass17_0.NativeFieldInfoPtr___9__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Tuple<WormPlayer, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility.__c__DisplayClass17_0.NativeFieldInfoPtr___9__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B30 RID: 15152
			// (get) Token: 0x0600BF1A RID: 48922 RVA: 0x002F2F24 File Offset: 0x002F1124
			// (set) Token: 0x0600BF1B RID: 48923 RVA: 0x000594FD File Offset: 0x000576FD
			public unsafe Func<Tuple<WormPlayer, int>, bool> __9__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility.__c__DisplayClass17_0.NativeFieldInfoPtr___9__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Tuple<WormPlayer, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility.__c__DisplayClass17_0.NativeFieldInfoPtr___9__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B31 RID: 15153
			// (get) Token: 0x0600BF1C RID: 48924 RVA: 0x002F2F54 File Offset: 0x002F1154
			// (set) Token: 0x0600BF1D RID: 48925 RVA: 0x0005951C File Offset: 0x0005771C
			public unsafe Func<WormUnit, bool> __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility.__c__DisplayClass17_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormUnit, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility.__c__DisplayClass17_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040077F6 RID: 30710
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x040077F7 RID: 30711
			private static readonly IntPtr NativeFieldInfoPtr_unitTargets;

			// Token: 0x040077F8 RID: 30712
			private static readonly IntPtr NativeFieldInfoPtr_numberToSelect;

			// Token: 0x040077F9 RID: 30713
			private static readonly IntPtr NativeFieldInfoPtr_estStrength;

			// Token: 0x040077FA RID: 30714
			private static readonly IntPtr NativeFieldInfoPtr_opponentTarget;

			// Token: 0x040077FB RID: 30715
			private static readonly IntPtr NativeFieldInfoPtr___9__4;

			// Token: 0x040077FC RID: 30716
			private static readonly IntPtr NativeFieldInfoPtr___9__8;

			// Token: 0x040077FD RID: 30717
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x040077FE RID: 30718
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040077FF RID: 30719
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__0_Internal_Boolean_Tuple_2_WormPlayer_Int32_0;

			// Token: 0x04007800 RID: 30720
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__4_Internal_Boolean_Tuple_2_WormPlayer_Int32_0;

			// Token: 0x04007801 RID: 30721
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__8_Internal_Boolean_Tuple_2_WormPlayer_Int32_0;

			// Token: 0x04007802 RID: 30722
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__2_Internal_Boolean_WormUnit_0;
		}

		// Token: 0x02000BB2 RID: 2994
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.RiseOfIx.DesertAmbushAbility+<>c__DisplayClass17_1")]
		public sealed class __c__DisplayClass17_1 : Object
		{
			// Token: 0x0600BF1E RID: 48926 RVA: 0x002F2F84 File Offset: 0x002F1184
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_1()
			{
				Il2CppClassPointerStore<DesertAmbushAbility.__c__DisplayClass17_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DesertAmbushAbility>.NativeClassPtr, "<>c__DisplayClass17_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DesertAmbushAbility.__c__DisplayClass17_1>.NativeClassPtr);
				DesertAmbushAbility.__c__DisplayClass17_1.NativeFieldInfoPtr_opp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility.__c__DisplayClass17_1>.NativeClassPtr, "opp");
				DesertAmbushAbility.__c__DisplayClass17_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility.__c__DisplayClass17_1>.NativeClassPtr, 100681098);
				DesertAmbushAbility.__c__DisplayClass17_1.NativeMethodInfoPtr__Evaluate_b__5_Internal_Boolean_WormUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility.__c__DisplayClass17_1>.NativeClassPtr, 100681099);
			}

			// Token: 0x0600BF1F RID: 48927 RVA: 0x002F2FEC File Offset: 0x002F11EC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DesertAmbushAbility.__c__DisplayClass17_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility.__c__DisplayClass17_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BF20 RID: 48928 RVA: 0x002F3028 File Offset: 0x002F1228
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249093, XrefRangeEnd = 249094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Evaluate_b__5(WormUnit unit)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(unit);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility.__c__DisplayClass17_1.NativeMethodInfoPtr__Evaluate_b__5_Internal_Boolean_WormUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BF21 RID: 48929 RVA: 0x0005953B File Offset: 0x0005773B
			public __c__DisplayClass17_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003B32 RID: 15154
			// (get) Token: 0x0600BF22 RID: 48930 RVA: 0x002F3078 File Offset: 0x002F1278
			// (set) Token: 0x0600BF23 RID: 48931 RVA: 0x00059544 File Offset: 0x00057744
			public unsafe Tuple<WormPlayer, int> opp
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility.__c__DisplayClass17_1.NativeFieldInfoPtr_opp);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tuple<WormPlayer, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility.__c__DisplayClass17_1.NativeFieldInfoPtr_opp), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007803 RID: 30723
			private static readonly IntPtr NativeFieldInfoPtr_opp;

			// Token: 0x04007804 RID: 30724
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007805 RID: 30725
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__5_Internal_Boolean_WormUnit_0;
		}

		// Token: 0x02000BB3 RID: 2995
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.RiseOfIx.DesertAmbushAbility+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x0600BF24 RID: 48932 RVA: 0x002F30A8 File Offset: 0x002F12A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<DesertAmbushAbility.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DesertAmbushAbility>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DesertAmbushAbility.__c__DisplayClass7_0>.NativeClassPtr);
				DesertAmbushAbility.__c__DisplayClass7_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility.__c__DisplayClass7_0>.NativeClassPtr, "player");
				DesertAmbushAbility.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility.__c__DisplayClass7_0>.NativeClassPtr, 100681100);
				DesertAmbushAbility.__c__DisplayClass7_0.NativeMethodInfoPtr__Targets_b__0_Internal_Boolean_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility.__c__DisplayClass7_0>.NativeClassPtr, 100681101);
			}

			// Token: 0x0600BF25 RID: 48933 RVA: 0x002F3110 File Offset: 0x002F1310
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DesertAmbushAbility.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BF26 RID: 48934 RVA: 0x002F314C File Offset: 0x002F134C
			[CallerCount(0)]
			public unsafe bool _Targets_b__0(WormPlayArea _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility.__c__DisplayClass7_0.NativeMethodInfoPtr__Targets_b__0_Internal_Boolean_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BF27 RID: 48935 RVA: 0x00059563 File Offset: 0x00057763
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003B33 RID: 15155
			// (get) Token: 0x0600BF28 RID: 48936 RVA: 0x002F319C File Offset: 0x002F139C
			// (set) Token: 0x0600BF29 RID: 48937 RVA: 0x0005956C File Offset: 0x0005776C
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility.__c__DisplayClass7_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility.__c__DisplayClass7_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007806 RID: 30726
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04007807 RID: 30727
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007808 RID: 30728
			private static readonly IntPtr NativeMethodInfoPtr__Targets_b__0_Internal_Boolean_WormPlayArea_0;
		}

		// Token: 0x02000BB4 RID: 2996
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.RiseOfIx.DesertAmbushAbility+<BeginExecution>d__13")]
		public sealed class _BeginExecution_d__13 : Object
		{
			// Token: 0x0600BF2A RID: 48938 RVA: 0x002F31CC File Offset: 0x002F13CC
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginExecution_d__13()
			{
				Il2CppClassPointerStore<DesertAmbushAbility._BeginExecution_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DesertAmbushAbility>.NativeClassPtr, "<BeginExecution>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DesertAmbushAbility._BeginExecution_d__13>.NativeClassPtr);
				DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility._BeginExecution_d__13>.NativeClassPtr, "<>1__state");
				DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility._BeginExecution_d__13>.NativeClassPtr, "<>2__current");
				DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility._BeginExecution_d__13>.NativeClassPtr, "<>l__initialThreadId");
				DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility._BeginExecution_d__13>.NativeClassPtr, "activeAbility");
				DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility._BeginExecution_d__13>.NativeClassPtr, "<>3__activeAbility");
				DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility._BeginExecution_d__13>.NativeClassPtr, "<>4__this");
				DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility._BeginExecution_d__13>.NativeClassPtr, "match");
				DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility._BeginExecution_d__13>.NativeClassPtr, "<>3__match");
				DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility._BeginExecution_d__13>.NativeClassPtr, "context");
				DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility._BeginExecution_d__13>.NativeClassPtr, "<>3__context");
				DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility._BeginExecution_d__13>.NativeClassPtr, "<player>5__2");
				DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr__unitCount_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility._BeginExecution_d__13>.NativeClassPtr, "<unitCount>5__3");
				DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr__oldValue_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility._BeginExecution_d__13>.NativeClassPtr, "<oldValue>5__4");
				DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr__unitList_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility._BeginExecution_d__13>.NativeClassPtr, "<unitList>5__5");
				DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr__sequenceHelper_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility._BeginExecution_d__13>.NativeClassPtr, "<sequenceHelper>5__6");
				DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr___7__wrap6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility._BeginExecution_d__13>.NativeClassPtr, "<>7__wrap6");
				DesertAmbushAbility._BeginExecution_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility._BeginExecution_d__13>.NativeClassPtr, 100681102);
				DesertAmbushAbility._BeginExecution_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility._BeginExecution_d__13>.NativeClassPtr, 100681103);
				DesertAmbushAbility._BeginExecution_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility._BeginExecution_d__13>.NativeClassPtr, 100681104);
				DesertAmbushAbility._BeginExecution_d__13.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility._BeginExecution_d__13>.NativeClassPtr, 100681105);
				DesertAmbushAbility._BeginExecution_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility._BeginExecution_d__13>.NativeClassPtr, 100681106);
				DesertAmbushAbility._BeginExecution_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility._BeginExecution_d__13>.NativeClassPtr, 100681107);
				DesertAmbushAbility._BeginExecution_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility._BeginExecution_d__13>.NativeClassPtr, 100681108);
				DesertAmbushAbility._BeginExecution_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility._BeginExecution_d__13>.NativeClassPtr, 100681109);
				DesertAmbushAbility._BeginExecution_d__13.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility._BeginExecution_d__13>.NativeClassPtr, 100681110);
			}

			// Token: 0x0600BF2B RID: 48939 RVA: 0x002F33EC File Offset: 0x002F15EC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginExecution_d__13(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DesertAmbushAbility._BeginExecution_d__13>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility._BeginExecution_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600BF2C RID: 48940 RVA: 0x002F3434 File Offset: 0x002F1634
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 249097, RefRangeEnd = 249098, XrefRangeStart = 249094, XrefRangeEnd = 249097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility._BeginExecution_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BF2D RID: 48941 RVA: 0x002F3468 File Offset: 0x002F1668
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249098, XrefRangeEnd = 249278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility._BeginExecution_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BF2E RID: 48942 RVA: 0x002F34A4 File Offset: 0x002F16A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249278, XrefRangeEnd = 249281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility._BeginExecution_d__13.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003B44 RID: 15172
			// (get) Token: 0x0600BF2F RID: 48943 RVA: 0x002F34D8 File Offset: 0x002F16D8
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility._BeginExecution_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600BF30 RID: 48944 RVA: 0x002F3518 File Offset: 0x002F1718
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249281, XrefRangeEnd = 249286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility._BeginExecution_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003B45 RID: 15173
			// (get) Token: 0x0600BF31 RID: 48945 RVA: 0x002F354C File Offset: 0x002F174C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility._BeginExecution_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BF32 RID: 48946 RVA: 0x002F358C File Offset: 0x002F178C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249286, XrefRangeEnd = 249297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility._BeginExecution_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600BF33 RID: 48947 RVA: 0x002F35CC File Offset: 0x002F17CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility._BeginExecution_d__13.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600BF34 RID: 48948 RVA: 0x0005958B File Offset: 0x0005778B
			public _BeginExecution_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003B34 RID: 15156
			// (get) Token: 0x0600BF35 RID: 48949 RVA: 0x002F360C File Offset: 0x002F180C
			// (set) Token: 0x0600BF36 RID: 48950 RVA: 0x00059594 File Offset: 0x00057794
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003B35 RID: 15157
			// (get) Token: 0x0600BF37 RID: 48951 RVA: 0x002F3634 File Offset: 0x002F1834
			// (set) Token: 0x0600BF38 RID: 48952 RVA: 0x000595AF File Offset: 0x000577AF
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B36 RID: 15158
			// (get) Token: 0x0600BF39 RID: 48953 RVA: 0x002F3664 File Offset: 0x002F1864
			// (set) Token: 0x0600BF3A RID: 48954 RVA: 0x000595CE File Offset: 0x000577CE
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17003B37 RID: 15159
			// (get) Token: 0x0600BF3B RID: 48955 RVA: 0x002F368C File Offset: 0x002F188C
			// (set) Token: 0x0600BF3C RID: 48956 RVA: 0x000595E9 File Offset: 0x000577E9
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B38 RID: 15160
			// (get) Token: 0x0600BF3D RID: 48957 RVA: 0x002F36BC File Offset: 0x002F18BC
			// (set) Token: 0x0600BF3E RID: 48958 RVA: 0x00059608 File Offset: 0x00057808
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B39 RID: 15161
			// (get) Token: 0x0600BF3F RID: 48959 RVA: 0x002F36EC File Offset: 0x002F18EC
			// (set) Token: 0x0600BF40 RID: 48960 RVA: 0x00059627 File Offset: 0x00057827
			public unsafe DesertAmbushAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DesertAmbushAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B3A RID: 15162
			// (get) Token: 0x0600BF41 RID: 48961 RVA: 0x002F371C File Offset: 0x002F191C
			// (set) Token: 0x0600BF42 RID: 48962 RVA: 0x00059646 File Offset: 0x00057846
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B3B RID: 15163
			// (get) Token: 0x0600BF43 RID: 48963 RVA: 0x002F374C File Offset: 0x002F194C
			// (set) Token: 0x0600BF44 RID: 48964 RVA: 0x00059665 File Offset: 0x00057865
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B3C RID: 15164
			// (get) Token: 0x0600BF45 RID: 48965 RVA: 0x002F377C File Offset: 0x002F197C
			// (set) Token: 0x0600BF46 RID: 48966 RVA: 0x00059684 File Offset: 0x00057884
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B3D RID: 15165
			// (get) Token: 0x0600BF47 RID: 48967 RVA: 0x002F37AC File Offset: 0x002F19AC
			// (set) Token: 0x0600BF48 RID: 48968 RVA: 0x000596A3 File Offset: 0x000578A3
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B3E RID: 15166
			// (get) Token: 0x0600BF49 RID: 48969 RVA: 0x002F37DC File Offset: 0x002F19DC
			// (set) Token: 0x0600BF4A RID: 48970 RVA: 0x000596C2 File Offset: 0x000578C2
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B3F RID: 15167
			// (get) Token: 0x0600BF4B RID: 48971 RVA: 0x002F380C File Offset: 0x002F1A0C
			// (set) Token: 0x0600BF4C RID: 48972 RVA: 0x000596E1 File Offset: 0x000578E1
			public unsafe int _unitCount_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr__unitCount_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr__unitCount_5__3)) = value;
				}
			}

			// Token: 0x17003B40 RID: 15168
			// (get) Token: 0x0600BF4D RID: 48973 RVA: 0x002F3834 File Offset: 0x002F1A34
			// (set) Token: 0x0600BF4E RID: 48974 RVA: 0x000596FC File Offset: 0x000578FC
			public unsafe int _oldValue_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr__oldValue_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr__oldValue_5__4)) = value;
				}
			}

			// Token: 0x17003B41 RID: 15169
			// (get) Token: 0x0600BF4F RID: 48975 RVA: 0x002F385C File Offset: 0x002F1A5C
			// (set) Token: 0x0600BF50 RID: 48976 RVA: 0x00059717 File Offset: 0x00057917
			public unsafe List<WormUnit> _unitList_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr__unitList_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormUnit>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr__unitList_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B42 RID: 15170
			// (get) Token: 0x0600BF51 RID: 48977 RVA: 0x002F388C File Offset: 0x002F1A8C
			// (set) Token: 0x0600BF52 RID: 48978 RVA: 0x00059736 File Offset: 0x00057936
			public unsafe SequenceHelper _sequenceHelper_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr__sequenceHelper_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr__sequenceHelper_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B43 RID: 15171
			// (get) Token: 0x0600BF53 RID: 48979 RVA: 0x002F38BC File Offset: 0x002F1ABC
			// (set) Token: 0x0600BF54 RID: 48980 RVA: 0x00059755 File Offset: 0x00057955
			public unsafe IEnumerator<PlayerEntity> __7__wrap6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr___7__wrap6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<PlayerEntity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._BeginExecution_d__13.NativeFieldInfoPtr___7__wrap6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007809 RID: 30729
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400780A RID: 30730
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400780B RID: 30731
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400780C RID: 30732
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x0400780D RID: 30733
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x0400780E RID: 30734
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400780F RID: 30735
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04007810 RID: 30736
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04007811 RID: 30737
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04007812 RID: 30738
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x04007813 RID: 30739
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x04007814 RID: 30740
			private static readonly IntPtr NativeFieldInfoPtr__unitCount_5__3;

			// Token: 0x04007815 RID: 30741
			private static readonly IntPtr NativeFieldInfoPtr__oldValue_5__4;

			// Token: 0x04007816 RID: 30742
			private static readonly IntPtr NativeFieldInfoPtr__unitList_5__5;

			// Token: 0x04007817 RID: 30743
			private static readonly IntPtr NativeFieldInfoPtr__sequenceHelper_5__6;

			// Token: 0x04007818 RID: 30744
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap6;

			// Token: 0x04007819 RID: 30745
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400781A RID: 30746
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400781B RID: 30747
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400781C RID: 30748
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400781D RID: 30749
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400781E RID: 30750
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400781F RID: 30751
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04007820 RID: 30752
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04007821 RID: 30753
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000BB5 RID: 2997
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.RiseOfIx.DesertAmbushAbility+<Targets>d__7")]
		public sealed class _Targets_d__7 : Object
		{
			// Token: 0x0600BF55 RID: 48981 RVA: 0x002F38EC File Offset: 0x002F1AEC
			// Note: this type is marked as 'beforefieldinit'.
			static _Targets_d__7()
			{
				Il2CppClassPointerStore<DesertAmbushAbility._Targets_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DesertAmbushAbility>.NativeClassPtr, "<Targets>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DesertAmbushAbility._Targets_d__7>.NativeClassPtr);
				DesertAmbushAbility._Targets_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility._Targets_d__7>.NativeClassPtr, "<>1__state");
				DesertAmbushAbility._Targets_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility._Targets_d__7>.NativeClassPtr, "<>2__current");
				DesertAmbushAbility._Targets_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility._Targets_d__7>.NativeClassPtr, "<>l__initialThreadId");
				DesertAmbushAbility._Targets_d__7.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility._Targets_d__7>.NativeClassPtr, "context");
				DesertAmbushAbility._Targets_d__7.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility._Targets_d__7>.NativeClassPtr, "<>3__context");
				DesertAmbushAbility._Targets_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility._Targets_d__7>.NativeClassPtr, "<>4__this");
				DesertAmbushAbility._Targets_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility._Targets_d__7>.NativeClassPtr, 100681111);
				DesertAmbushAbility._Targets_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility._Targets_d__7>.NativeClassPtr, 100681112);
				DesertAmbushAbility._Targets_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility._Targets_d__7>.NativeClassPtr, 100681113);
				DesertAmbushAbility._Targets_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility._Targets_d__7>.NativeClassPtr, 100681114);
				DesertAmbushAbility._Targets_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility._Targets_d__7>.NativeClassPtr, 100681115);
				DesertAmbushAbility._Targets_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility._Targets_d__7>.NativeClassPtr, 100681116);
				DesertAmbushAbility._Targets_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility._Targets_d__7>.NativeClassPtr, 100681117);
				DesertAmbushAbility._Targets_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility._Targets_d__7>.NativeClassPtr, 100681118);
			}

			// Token: 0x0600BF56 RID: 48982 RVA: 0x002F3A30 File Offset: 0x002F1C30
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Targets_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DesertAmbushAbility._Targets_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility._Targets_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600BF57 RID: 48983 RVA: 0x002F3A78 File Offset: 0x002F1C78
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility._Targets_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BF58 RID: 48984 RVA: 0x002F3AAC File Offset: 0x002F1CAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249297, XrefRangeEnd = 249373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility._Targets_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003B4C RID: 15180
			// (get) Token: 0x0600BF59 RID: 48985 RVA: 0x002F3AE8 File Offset: 0x002F1CE8
			public unsafe TargetInformation System.Collections.Generic.IEnumerator<Networking.selection.targetinformation.TargetInformation>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility._Targets_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetInformation>(intPtr3) : null;
				}
			}

			// Token: 0x0600BF5A RID: 48986 RVA: 0x002F3B28 File Offset: 0x002F1D28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249373, XrefRangeEnd = 249378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility._Targets_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003B4D RID: 15181
			// (get) Token: 0x0600BF5B RID: 48987 RVA: 0x002F3B5C File Offset: 0x002F1D5C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility._Targets_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BF5C RID: 48988 RVA: 0x002F3B9C File Offset: 0x002F1D9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249378, XrefRangeEnd = 249387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TargetInformation> System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility._Targets_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TargetInformation>>(intPtr3) : null;
			}

			// Token: 0x0600BF5D RID: 48989 RVA: 0x002F3BDC File Offset: 0x002F1DDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility._Targets_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600BF5E RID: 48990 RVA: 0x00059774 File Offset: 0x00057974
			public _Targets_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003B46 RID: 15174
			// (get) Token: 0x0600BF5F RID: 48991 RVA: 0x002F3C1C File Offset: 0x002F1E1C
			// (set) Token: 0x0600BF60 RID: 48992 RVA: 0x0005977D File Offset: 0x0005797D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._Targets_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._Targets_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003B47 RID: 15175
			// (get) Token: 0x0600BF61 RID: 48993 RVA: 0x002F3C44 File Offset: 0x002F1E44
			// (set) Token: 0x0600BF62 RID: 48994 RVA: 0x00059798 File Offset: 0x00057998
			public unsafe TargetInformation __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._Targets_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TargetInformation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._Targets_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B48 RID: 15176
			// (get) Token: 0x0600BF63 RID: 48995 RVA: 0x002F3C74 File Offset: 0x002F1E74
			// (set) Token: 0x0600BF64 RID: 48996 RVA: 0x000597B7 File Offset: 0x000579B7
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._Targets_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._Targets_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17003B49 RID: 15177
			// (get) Token: 0x0600BF65 RID: 48997 RVA: 0x002F3C9C File Offset: 0x002F1E9C
			// (set) Token: 0x0600BF66 RID: 48998 RVA: 0x000597D2 File Offset: 0x000579D2
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._Targets_d__7.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._Targets_d__7.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B4A RID: 15178
			// (get) Token: 0x0600BF67 RID: 48999 RVA: 0x002F3CCC File Offset: 0x002F1ECC
			// (set) Token: 0x0600BF68 RID: 49000 RVA: 0x000597F1 File Offset: 0x000579F1
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._Targets_d__7.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._Targets_d__7.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B4B RID: 15179
			// (get) Token: 0x0600BF69 RID: 49001 RVA: 0x002F3CFC File Offset: 0x002F1EFC
			// (set) Token: 0x0600BF6A RID: 49002 RVA: 0x00059810 File Offset: 0x00057A10
			public unsafe DesertAmbushAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._Targets_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DesertAmbushAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._Targets_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007822 RID: 30754
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007823 RID: 30755
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007824 RID: 30756
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04007825 RID: 30757
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04007826 RID: 30758
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x04007827 RID: 30759
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007828 RID: 30760
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04007829 RID: 30761
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400782A RID: 30762
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400782B RID: 30763
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0;

			// Token: 0x0400782C RID: 30764
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400782D RID: 30765
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400782E RID: 30766
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0;

			// Token: 0x0400782F RID: 30767
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000BB6 RID: 2998
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.RiseOfIx.DesertAmbushAbility+<Undo>d__14")]
		public sealed class _Undo_d__14 : Object
		{
			// Token: 0x0600BF6B RID: 49003 RVA: 0x002F3D2C File Offset: 0x002F1F2C
			// Note: this type is marked as 'beforefieldinit'.
			static _Undo_d__14()
			{
				Il2CppClassPointerStore<DesertAmbushAbility._Undo_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DesertAmbushAbility>.NativeClassPtr, "<Undo>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DesertAmbushAbility._Undo_d__14>.NativeClassPtr);
				DesertAmbushAbility._Undo_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility._Undo_d__14>.NativeClassPtr, "<>1__state");
				DesertAmbushAbility._Undo_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility._Undo_d__14>.NativeClassPtr, "<>2__current");
				DesertAmbushAbility._Undo_d__14.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility._Undo_d__14>.NativeClassPtr, "<>l__initialThreadId");
				DesertAmbushAbility._Undo_d__14.NativeFieldInfoPtr_node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility._Undo_d__14>.NativeClassPtr, "node");
				DesertAmbushAbility._Undo_d__14.NativeFieldInfoPtr___3__node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility._Undo_d__14>.NativeClassPtr, "<>3__node");
				DesertAmbushAbility._Undo_d__14.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility._Undo_d__14>.NativeClassPtr, "match");
				DesertAmbushAbility._Undo_d__14.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility._Undo_d__14>.NativeClassPtr, "<>3__match");
				DesertAmbushAbility._Undo_d__14.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility._Undo_d__14>.NativeClassPtr, "player");
				DesertAmbushAbility._Undo_d__14.NativeFieldInfoPtr___3__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesertAmbushAbility._Undo_d__14>.NativeClassPtr, "<>3__player");
				DesertAmbushAbility._Undo_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility._Undo_d__14>.NativeClassPtr, 100681119);
				DesertAmbushAbility._Undo_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility._Undo_d__14>.NativeClassPtr, 100681120);
				DesertAmbushAbility._Undo_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility._Undo_d__14>.NativeClassPtr, 100681121);
				DesertAmbushAbility._Undo_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility._Undo_d__14>.NativeClassPtr, 100681122);
				DesertAmbushAbility._Undo_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility._Undo_d__14>.NativeClassPtr, 100681123);
				DesertAmbushAbility._Undo_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility._Undo_d__14>.NativeClassPtr, 100681124);
				DesertAmbushAbility._Undo_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility._Undo_d__14>.NativeClassPtr, 100681125);
				DesertAmbushAbility._Undo_d__14.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesertAmbushAbility._Undo_d__14>.NativeClassPtr, 100681126);
			}

			// Token: 0x0600BF6C RID: 49004 RVA: 0x002F3EAC File Offset: 0x002F20AC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Undo_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DesertAmbushAbility._Undo_d__14>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility._Undo_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600BF6D RID: 49005 RVA: 0x002F3EF4 File Offset: 0x002F20F4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility._Undo_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BF6E RID: 49006 RVA: 0x002F3F28 File Offset: 0x002F2128
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249387, XrefRangeEnd = 249415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility._Undo_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003B57 RID: 15191
			// (get) Token: 0x0600BF6F RID: 49007 RVA: 0x002F3F64 File Offset: 0x002F2164
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility._Undo_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600BF70 RID: 49008 RVA: 0x002F3FA4 File Offset: 0x002F21A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249415, XrefRangeEnd = 249420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility._Undo_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003B58 RID: 15192
			// (get) Token: 0x0600BF71 RID: 49009 RVA: 0x002F3FD8 File Offset: 0x002F21D8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility._Undo_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BF72 RID: 49010 RVA: 0x002F4018 File Offset: 0x002F2218
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249420, XrefRangeEnd = 249430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility._Undo_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600BF73 RID: 49011 RVA: 0x002F4058 File Offset: 0x002F2258
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesertAmbushAbility._Undo_d__14.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600BF74 RID: 49012 RVA: 0x0005982F File Offset: 0x00057A2F
			public _Undo_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003B4E RID: 15182
			// (get) Token: 0x0600BF75 RID: 49013 RVA: 0x002F4098 File Offset: 0x002F2298
			// (set) Token: 0x0600BF76 RID: 49014 RVA: 0x00059838 File Offset: 0x00057A38
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._Undo_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._Undo_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003B4F RID: 15183
			// (get) Token: 0x0600BF77 RID: 49015 RVA: 0x002F40C0 File Offset: 0x002F22C0
			// (set) Token: 0x0600BF78 RID: 49016 RVA: 0x00059853 File Offset: 0x00057A53
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._Undo_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._Undo_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B50 RID: 15184
			// (get) Token: 0x0600BF79 RID: 49017 RVA: 0x002F40F0 File Offset: 0x002F22F0
			// (set) Token: 0x0600BF7A RID: 49018 RVA: 0x00059872 File Offset: 0x00057A72
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._Undo_d__14.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._Undo_d__14.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17003B51 RID: 15185
			// (get) Token: 0x0600BF7B RID: 49019 RVA: 0x002F4118 File Offset: 0x002F2318
			// (set) Token: 0x0600BF7C RID: 49020 RVA: 0x0005988D File Offset: 0x00057A8D
			public unsafe UndoNode node
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._Undo_d__14.NativeFieldInfoPtr_node);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._Undo_d__14.NativeFieldInfoPtr_node), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B52 RID: 15186
			// (get) Token: 0x0600BF7D RID: 49021 RVA: 0x002F4148 File Offset: 0x002F2348
			// (set) Token: 0x0600BF7E RID: 49022 RVA: 0x000598AC File Offset: 0x00057AAC
			public unsafe UndoNode __3__node
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._Undo_d__14.NativeFieldInfoPtr___3__node);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._Undo_d__14.NativeFieldInfoPtr___3__node), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B53 RID: 15187
			// (get) Token: 0x0600BF7F RID: 49023 RVA: 0x002F4178 File Offset: 0x002F2378
			// (set) Token: 0x0600BF80 RID: 49024 RVA: 0x000598CB File Offset: 0x00057ACB
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._Undo_d__14.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._Undo_d__14.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B54 RID: 15188
			// (get) Token: 0x0600BF81 RID: 49025 RVA: 0x002F41A8 File Offset: 0x002F23A8
			// (set) Token: 0x0600BF82 RID: 49026 RVA: 0x000598EA File Offset: 0x00057AEA
			public unsafe Match __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._Undo_d__14.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._Undo_d__14.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B55 RID: 15189
			// (get) Token: 0x0600BF83 RID: 49027 RVA: 0x002F41D8 File Offset: 0x002F23D8
			// (set) Token: 0x0600BF84 RID: 49028 RVA: 0x00059909 File Offset: 0x00057B09
			public unsafe PlayerEntity player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._Undo_d__14.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._Undo_d__14.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003B56 RID: 15190
			// (get) Token: 0x0600BF85 RID: 49029 RVA: 0x002F4208 File Offset: 0x002F2408
			// (set) Token: 0x0600BF86 RID: 49030 RVA: 0x00059928 File Offset: 0x00057B28
			public unsafe PlayerEntity __3__player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._Undo_d__14.NativeFieldInfoPtr___3__player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesertAmbushAbility._Undo_d__14.NativeFieldInfoPtr___3__player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007830 RID: 30768
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007831 RID: 30769
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007832 RID: 30770
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04007833 RID: 30771
			private static readonly IntPtr NativeFieldInfoPtr_node;

			// Token: 0x04007834 RID: 30772
			private static readonly IntPtr NativeFieldInfoPtr___3__node;

			// Token: 0x04007835 RID: 30773
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04007836 RID: 30774
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04007837 RID: 30775
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04007838 RID: 30776
			private static readonly IntPtr NativeFieldInfoPtr___3__player;

			// Token: 0x04007839 RID: 30777
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400783A RID: 30778
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400783B RID: 30779
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400783C RID: 30780
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400783D RID: 30781
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400783E RID: 30782
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400783F RID: 30783
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04007840 RID: 30784
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
