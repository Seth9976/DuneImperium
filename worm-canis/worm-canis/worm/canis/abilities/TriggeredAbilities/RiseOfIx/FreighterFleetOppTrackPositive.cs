using System;
using Canis;
using Canis.actions;
using Canis.context;
using Canis.entities;
using Canis.events;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.entities;

namespace worm.canis.abilities.TriggeredAbilities.RiseOfIx
{
	// Token: 0x0200035C RID: 860
	public class FreighterFleetOppTrackPositive : TriggeredAbility
	{
		// Token: 0x0600233A RID: 9018 RVA: 0x000E4BFC File Offset: 0x000E2DFC
		// Note: this type is marked as 'beforefieldinit'.
		static FreighterFleetOppTrackPositive()
		{
			Il2CppClassPointerStore<FreighterFleetOppTrackPositive>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.TriggeredAbilities.RiseOfIx", "FreighterFleetOppTrackPositive");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FreighterFleetOppTrackPositive>.NativeClassPtr);
			FreighterFleetOppTrackPositive.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterFleetOppTrackPositive>.NativeClassPtr, "AbilityName");
			FreighterFleetOppTrackPositive.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterFleetOppTrackPositive>.NativeClassPtr, "AbilityID");
			FreighterFleetOppTrackPositive.NativeFieldInfoPtr_ResolveFreighterAbilitiesState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterFleetOppTrackPositive>.NativeClassPtr, "ResolveFreighterAbilitiesState");
			FreighterFleetOppTrackPositive.NativeFieldInfoPtr_CleanupState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterFleetOppTrackPositive>.NativeClassPtr, "CleanupState");
			FreighterFleetOppTrackPositive.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive>.NativeClassPtr, 100672556);
			FreighterFleetOppTrackPositive.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive>.NativeClassPtr, 100672557);
			FreighterFleetOppTrackPositive.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive>.NativeClassPtr, 100672558);
			FreighterFleetOppTrackPositive.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive>.NativeClassPtr, 100672559);
			FreighterFleetOppTrackPositive.NativeMethodInfoPtr_get_ShouldExhaust_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive>.NativeClassPtr, 100672560);
			FreighterFleetOppTrackPositive.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive>.NativeClassPtr, 100672561);
			FreighterFleetOppTrackPositive.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive>.NativeClassPtr, 100672562);
			FreighterFleetOppTrackPositive.NativeMethodInfoPtr_ResolveFreighterAbilities_Private_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive>.NativeClassPtr, 100672563);
			FreighterFleetOppTrackPositive.NativeMethodInfoPtr_Cleanup_Private_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive>.NativeClassPtr, 100672564);
			FreighterFleetOppTrackPositive.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive>.NativeClassPtr, 100672565);
			FreighterFleetOppTrackPositive.NativeMethodInfoPtr__IsValidFor_b__7_0_Private_Boolean_WormPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive>.NativeClassPtr, 100672567);
		}

		// Token: 0x0600233B RID: 9019 RVA: 0x000E4D58 File Offset: 0x000E2F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183857, XrefRangeEnd = 183861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FreighterFleetOppTrackPositive.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x0600233C RID: 9020 RVA: 0x000E4DA4 File Offset: 0x000E2FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183861, XrefRangeEnd = 183880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FreighterFleetOppTrackPositive(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FreighterFleetOppTrackPositive>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterFleetOppTrackPositive.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600233D RID: 9021 RVA: 0x000E4DF0 File Offset: 0x000E2FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183880, XrefRangeEnd = 183897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FreighterFleetOppTrackPositive(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FreighterFleetOppTrackPositive>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterFleetOppTrackPositive.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600233E RID: 9022 RVA: 0x000E4E60 File Offset: 0x000E3060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183897, XrefRangeEnd = 183904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<PlayerEntity> IsValidFor(SerializableEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FreighterFleetOppTrackPositive.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayerEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x0600233F RID: 9023 RVA: 0x000E4EBC File Offset: 0x000E30BC
		public unsafe override bool ShouldExhaust
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FreighterFleetOppTrackPositive.NativeMethodInfoPtr_get_ShouldExhaust_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002340 RID: 9024 RVA: 0x000E4F04 File Offset: 0x000E3104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183904, XrefRangeEnd = 183908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FreighterFleetOppTrackPositive.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x06002341 RID: 9025 RVA: 0x000E4F74 File Offset: 0x000E3174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183908, XrefRangeEnd = 183917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FreighterFleetOppTrackPositive.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06002342 RID: 9026 RVA: 0x000E4FF4 File Offset: 0x000E31F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183917, XrefRangeEnd = 183924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> ResolveFreighterAbilities(WormActiveAbility activeAbility, WormMatch match, Context context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterFleetOppTrackPositive.NativeMethodInfoPtr_ResolveFreighterAbilities_Private_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06002343 RID: 9027 RVA: 0x000E5068 File Offset: 0x000E3268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183924, XrefRangeEnd = 183931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> Cleanup(WormActiveAbility activeAbility, WormMatch match, Context context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterFleetOppTrackPositive.NativeMethodInfoPtr_Cleanup_Private_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06002344 RID: 9028 RVA: 0x000E50DC File Offset: 0x000E32DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183931, XrefRangeEnd = 183939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FreighterFleetOppTrackPositive.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002345 RID: 9029 RVA: 0x000E5158 File Offset: 0x000E3358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183939, XrefRangeEnd = 183940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _IsValidFor_b__7_0(WormPlayable _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterFleetOppTrackPositive.NativeMethodInfoPtr__IsValidFor_b__7_0_Private_Boolean_WormPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002346 RID: 9030 RVA: 0x0000E0BB File Offset: 0x0000C2BB
		public FreighterFleetOppTrackPositive(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x06002347 RID: 9031 RVA: 0x000E51A8 File Offset: 0x000E33A8
		// (set) Token: 0x06002348 RID: 9032 RVA: 0x0000E0C4 File Offset: 0x0000C2C4
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FreighterFleetOppTrackPositive.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FreighterFleetOppTrackPositive.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x06002349 RID: 9033 RVA: 0x000E51C8 File Offset: 0x000E33C8
		// (set) Token: 0x0600234A RID: 9034 RVA: 0x0000E0D6 File Offset: 0x0000C2D6
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FreighterFleetOppTrackPositive.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FreighterFleetOppTrackPositive.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x0600234B RID: 9035 RVA: 0x000E51F0 File Offset: 0x000E33F0
		// (set) Token: 0x0600234C RID: 9036 RVA: 0x0000E0E8 File Offset: 0x0000C2E8
		public unsafe static int ResolveFreighterAbilitiesState
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FreighterFleetOppTrackPositive.NativeFieldInfoPtr_ResolveFreighterAbilitiesState, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FreighterFleetOppTrackPositive.NativeFieldInfoPtr_ResolveFreighterAbilitiesState, (void*)(&value));
			}
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x0600234D RID: 9037 RVA: 0x000E520C File Offset: 0x000E340C
		// (set) Token: 0x0600234E RID: 9038 RVA: 0x0000E0F6 File Offset: 0x0000C2F6
		public unsafe static int CleanupState
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FreighterFleetOppTrackPositive.NativeFieldInfoPtr_CleanupState, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FreighterFleetOppTrackPositive.NativeFieldInfoPtr_CleanupState, (void*)(&value));
			}
		}

		// Token: 0x0400164F RID: 5711
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04001650 RID: 5712
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04001651 RID: 5713
		private static readonly IntPtr NativeFieldInfoPtr_ResolveFreighterAbilitiesState;

		// Token: 0x04001652 RID: 5714
		private static readonly IntPtr NativeFieldInfoPtr_CleanupState;

		// Token: 0x04001653 RID: 5715
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04001654 RID: 5716
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04001655 RID: 5717
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04001656 RID: 5718
		private static readonly IntPtr NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0;

		// Token: 0x04001657 RID: 5719
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldExhaust_Public_Virtual_get_Boolean_0;

		// Token: 0x04001658 RID: 5720
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0;

		// Token: 0x04001659 RID: 5721
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x0400165A RID: 5722
		private static readonly IntPtr NativeMethodInfoPtr_ResolveFreighterAbilities_Private_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x0400165B RID: 5723
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Private_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x0400165C RID: 5724
		private static readonly IntPtr NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0;

		// Token: 0x0400165D RID: 5725
		private static readonly IntPtr NativeMethodInfoPtr__IsValidFor_b__7_0_Private_Boolean_WormPlayable_0;

		// Token: 0x02000869 RID: 2153
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.RiseOfIx.FreighterFleetOppTrackPositive+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06007C6F RID: 31855 RVA: 0x0022FE7C File Offset: 0x0022E07C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FreighterFleetOppTrackPositive.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FreighterFleetOppTrackPositive>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FreighterFleetOppTrackPositive.__c>.NativeClassPtr);
				FreighterFleetOppTrackPositive.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterFleetOppTrackPositive.__c>.NativeClassPtr, "<>9");
				FreighterFleetOppTrackPositive.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterFleetOppTrackPositive.__c>.NativeClassPtr, "<>9__11_0");
				FreighterFleetOppTrackPositive.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterFleetOppTrackPositive.__c>.NativeClassPtr, "<>9__12_0");
				FreighterFleetOppTrackPositive.__c.NativeFieldInfoPtr___9__12_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterFleetOppTrackPositive.__c>.NativeClassPtr, "<>9__12_1");
				FreighterFleetOppTrackPositive.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive.__c>.NativeClassPtr, 100672569);
				FreighterFleetOppTrackPositive.__c.NativeMethodInfoPtr__BeginExecution_b__11_0_Internal_Boolean_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive.__c>.NativeClassPtr, 100672570);
				FreighterFleetOppTrackPositive.__c.NativeMethodInfoPtr__ResolveFreighterAbilities_b__12_0_Internal_Boolean_AbilityDefinitionForGame_1_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive.__c>.NativeClassPtr, 100672571);
				FreighterFleetOppTrackPositive.__c.NativeMethodInfoPtr__ResolveFreighterAbilities_b__12_1_Internal_Boolean_AbilityDefinitionForGame_1_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive.__c>.NativeClassPtr, 100672572);
			}

			// Token: 0x06007C70 RID: 31856 RVA: 0x0022FF48 File Offset: 0x0022E148
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FreighterFleetOppTrackPositive.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterFleetOppTrackPositive.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007C71 RID: 31857 RVA: 0x0022FF84 File Offset: 0x0022E184
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183599, XrefRangeEnd = 183600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginExecution_b__11_0(WormAbilityDefinition _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterFleetOppTrackPositive.__c.NativeMethodInfoPtr__BeginExecution_b__11_0_Internal_Boolean_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06007C72 RID: 31858 RVA: 0x0022FFD4 File Offset: 0x0022E1D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183600, XrefRangeEnd = 183601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ResolveFreighterAbilities_b__12_0(AbilityDefinitionForGame<WormMatch> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterFleetOppTrackPositive.__c.NativeMethodInfoPtr__ResolveFreighterAbilities_b__12_0_Internal_Boolean_AbilityDefinitionForGame_1_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06007C73 RID: 31859 RVA: 0x00230024 File Offset: 0x0022E224
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183601, XrefRangeEnd = 183608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ResolveFreighterAbilities_b__12_1(AbilityDefinitionForGame<WormMatch> a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterFleetOppTrackPositive.__c.NativeMethodInfoPtr__ResolveFreighterAbilities_b__12_1_Internal_Boolean_AbilityDefinitionForGame_1_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06007C74 RID: 31860 RVA: 0x0003313A File Offset: 0x0003133A
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002316 RID: 8982
			// (get) Token: 0x06007C75 RID: 31861 RVA: 0x00230074 File Offset: 0x0022E274
			// (set) Token: 0x06007C76 RID: 31862 RVA: 0x00033143 File Offset: 0x00031343
			public unsafe static FreighterFleetOppTrackPositive.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FreighterFleetOppTrackPositive.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FreighterFleetOppTrackPositive.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FreighterFleetOppTrackPositive.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002317 RID: 8983
			// (get) Token: 0x06007C77 RID: 31863 RVA: 0x0023009C File Offset: 0x0022E29C
			// (set) Token: 0x06007C78 RID: 31864 RVA: 0x00033155 File Offset: 0x00031355
			public unsafe static Func<WormAbilityDefinition, bool> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FreighterFleetOppTrackPositive.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormAbilityDefinition, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FreighterFleetOppTrackPositive.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002318 RID: 8984
			// (get) Token: 0x06007C79 RID: 31865 RVA: 0x002300C4 File Offset: 0x0022E2C4
			// (set) Token: 0x06007C7A RID: 31866 RVA: 0x00033167 File Offset: 0x00031367
			public unsafe static Predicate<AbilityDefinitionForGame<WormMatch>> __9__12_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FreighterFleetOppTrackPositive.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<AbilityDefinitionForGame<WormMatch>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FreighterFleetOppTrackPositive.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002319 RID: 8985
			// (get) Token: 0x06007C7B RID: 31867 RVA: 0x002300EC File Offset: 0x0022E2EC
			// (set) Token: 0x06007C7C RID: 31868 RVA: 0x00033179 File Offset: 0x00031379
			public unsafe static Func<AbilityDefinitionForGame<WormMatch>, bool> __9__12_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FreighterFleetOppTrackPositive.__c.NativeFieldInfoPtr___9__12_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AbilityDefinitionForGame<WormMatch>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FreighterFleetOppTrackPositive.__c.NativeFieldInfoPtr___9__12_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004FFA RID: 20474
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04004FFB RID: 20475
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x04004FFC RID: 20476
			private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x04004FFD RID: 20477
			private static readonly IntPtr NativeFieldInfoPtr___9__12_1;

			// Token: 0x04004FFE RID: 20478
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004FFF RID: 20479
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__11_0_Internal_Boolean_WormAbilityDefinition_0;

			// Token: 0x04005000 RID: 20480
			private static readonly IntPtr NativeMethodInfoPtr__ResolveFreighterAbilities_b__12_0_Internal_Boolean_AbilityDefinitionForGame_1_WormMatch_0;

			// Token: 0x04005001 RID: 20481
			private static readonly IntPtr NativeMethodInfoPtr__ResolveFreighterAbilities_b__12_1_Internal_Boolean_AbilityDefinitionForGame_1_WormMatch_0;
		}

		// Token: 0x0200086A RID: 2154
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.RiseOfIx.FreighterFleetOppTrackPositive+<BeginExecution>d__11")]
		public sealed class _BeginExecution_d__11 : Object
		{
			// Token: 0x06007C7D RID: 31869 RVA: 0x00230114 File Offset: 0x0022E314
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginExecution_d__11()
			{
				Il2CppClassPointerStore<FreighterFleetOppTrackPositive._BeginExecution_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FreighterFleetOppTrackPositive>.NativeClassPtr, "<BeginExecution>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._BeginExecution_d__11>.NativeClassPtr);
				FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._BeginExecution_d__11>.NativeClassPtr, "<>1__state");
				FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._BeginExecution_d__11>.NativeClassPtr, "<>2__current");
				FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._BeginExecution_d__11>.NativeClassPtr, "<>l__initialThreadId");
				FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._BeginExecution_d__11>.NativeClassPtr, "activeAbility");
				FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._BeginExecution_d__11>.NativeClassPtr, "<>3__activeAbility");
				FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._BeginExecution_d__11>.NativeClassPtr, "<>4__this");
				FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._BeginExecution_d__11>.NativeClassPtr, "match");
				FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._BeginExecution_d__11>.NativeClassPtr, "<>3__match");
				FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._BeginExecution_d__11>.NativeClassPtr, "context");
				FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._BeginExecution_d__11>.NativeClassPtr, "<>3__context");
				FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._BeginExecution_d__11>.NativeClassPtr, "<player>5__2");
				FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._BeginExecution_d__11>.NativeClassPtr, 100672573);
				FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._BeginExecution_d__11>.NativeClassPtr, 100672574);
				FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._BeginExecution_d__11>.NativeClassPtr, 100672575);
				FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._BeginExecution_d__11>.NativeClassPtr, 100672576);
				FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._BeginExecution_d__11>.NativeClassPtr, 100672577);
				FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._BeginExecution_d__11>.NativeClassPtr, 100672578);
				FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._BeginExecution_d__11>.NativeClassPtr, 100672579);
				FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._BeginExecution_d__11>.NativeClassPtr, 100672580);
			}

			// Token: 0x06007C7E RID: 31870 RVA: 0x002302BC File Offset: 0x0022E4BC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginExecution_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._BeginExecution_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06007C7F RID: 31871 RVA: 0x00230304 File Offset: 0x0022E504
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007C80 RID: 31872 RVA: 0x00230338 File Offset: 0x0022E538
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183608, XrefRangeEnd = 183654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002325 RID: 8997
			// (get) Token: 0x06007C81 RID: 31873 RVA: 0x00230374 File Offset: 0x0022E574
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06007C82 RID: 31874 RVA: 0x002303B4 File Offset: 0x0022E5B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183654, XrefRangeEnd = 183659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002326 RID: 8998
			// (get) Token: 0x06007C83 RID: 31875 RVA: 0x002303E8 File Offset: 0x0022E5E8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06007C84 RID: 31876 RVA: 0x00230428 File Offset: 0x0022E628
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183659, XrefRangeEnd = 183670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06007C85 RID: 31877 RVA: 0x00230468 File Offset: 0x0022E668
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06007C86 RID: 31878 RVA: 0x0003318B File Offset: 0x0003138B
			public _BeginExecution_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700231A RID: 8986
			// (get) Token: 0x06007C87 RID: 31879 RVA: 0x002304A8 File Offset: 0x0022E6A8
			// (set) Token: 0x06007C88 RID: 31880 RVA: 0x00033194 File Offset: 0x00031394
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700231B RID: 8987
			// (get) Token: 0x06007C89 RID: 31881 RVA: 0x002304D0 File Offset: 0x0022E6D0
			// (set) Token: 0x06007C8A RID: 31882 RVA: 0x000331AF File Offset: 0x000313AF
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700231C RID: 8988
			// (get) Token: 0x06007C8B RID: 31883 RVA: 0x00230500 File Offset: 0x0022E700
			// (set) Token: 0x06007C8C RID: 31884 RVA: 0x000331CE File Offset: 0x000313CE
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700231D RID: 8989
			// (get) Token: 0x06007C8D RID: 31885 RVA: 0x00230528 File Offset: 0x0022E728
			// (set) Token: 0x06007C8E RID: 31886 RVA: 0x000331E9 File Offset: 0x000313E9
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700231E RID: 8990
			// (get) Token: 0x06007C8F RID: 31887 RVA: 0x00230558 File Offset: 0x0022E758
			// (set) Token: 0x06007C90 RID: 31888 RVA: 0x00033208 File Offset: 0x00031408
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700231F RID: 8991
			// (get) Token: 0x06007C91 RID: 31889 RVA: 0x00230588 File Offset: 0x0022E788
			// (set) Token: 0x06007C92 RID: 31890 RVA: 0x00033227 File Offset: 0x00031427
			public unsafe FreighterFleetOppTrackPositive __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FreighterFleetOppTrackPositive>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002320 RID: 8992
			// (get) Token: 0x06007C93 RID: 31891 RVA: 0x002305B8 File Offset: 0x0022E7B8
			// (set) Token: 0x06007C94 RID: 31892 RVA: 0x00033246 File Offset: 0x00031446
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002321 RID: 8993
			// (get) Token: 0x06007C95 RID: 31893 RVA: 0x002305E8 File Offset: 0x0022E7E8
			// (set) Token: 0x06007C96 RID: 31894 RVA: 0x00033265 File Offset: 0x00031465
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002322 RID: 8994
			// (get) Token: 0x06007C97 RID: 31895 RVA: 0x00230618 File Offset: 0x0022E818
			// (set) Token: 0x06007C98 RID: 31896 RVA: 0x00033284 File Offset: 0x00031484
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002323 RID: 8995
			// (get) Token: 0x06007C99 RID: 31897 RVA: 0x00230648 File Offset: 0x0022E848
			// (set) Token: 0x06007C9A RID: 31898 RVA: 0x000332A3 File Offset: 0x000314A3
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002324 RID: 8996
			// (get) Token: 0x06007C9B RID: 31899 RVA: 0x00230678 File Offset: 0x0022E878
			// (set) Token: 0x06007C9C RID: 31900 RVA: 0x000332C2 File Offset: 0x000314C2
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._BeginExecution_d__11.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005002 RID: 20482
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005003 RID: 20483
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005004 RID: 20484
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04005005 RID: 20485
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04005006 RID: 20486
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x04005007 RID: 20487
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005008 RID: 20488
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04005009 RID: 20489
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x0400500A RID: 20490
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x0400500B RID: 20491
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x0400500C RID: 20492
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x0400500D RID: 20493
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400500E RID: 20494
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400500F RID: 20495
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005010 RID: 20496
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04005011 RID: 20497
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005012 RID: 20498
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005013 RID: 20499
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04005014 RID: 20500
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200086B RID: 2155
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.RiseOfIx.FreighterFleetOppTrackPositive+<Cleanup>d__13")]
		public sealed class _Cleanup_d__13 : Object
		{
			// Token: 0x06007C9D RID: 31901 RVA: 0x002306A8 File Offset: 0x0022E8A8
			// Note: this type is marked as 'beforefieldinit'.
			static _Cleanup_d__13()
			{
				Il2CppClassPointerStore<FreighterFleetOppTrackPositive._Cleanup_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FreighterFleetOppTrackPositive>.NativeClassPtr, "<Cleanup>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._Cleanup_d__13>.NativeClassPtr);
				FreighterFleetOppTrackPositive._Cleanup_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._Cleanup_d__13>.NativeClassPtr, "<>1__state");
				FreighterFleetOppTrackPositive._Cleanup_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._Cleanup_d__13>.NativeClassPtr, "<>2__current");
				FreighterFleetOppTrackPositive._Cleanup_d__13.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._Cleanup_d__13>.NativeClassPtr, "<>l__initialThreadId");
				FreighterFleetOppTrackPositive._Cleanup_d__13.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._Cleanup_d__13>.NativeClassPtr, "activeAbility");
				FreighterFleetOppTrackPositive._Cleanup_d__13.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._Cleanup_d__13>.NativeClassPtr, "<>3__activeAbility");
				FreighterFleetOppTrackPositive._Cleanup_d__13.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._Cleanup_d__13>.NativeClassPtr, "match");
				FreighterFleetOppTrackPositive._Cleanup_d__13.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._Cleanup_d__13>.NativeClassPtr, "<>3__match");
				FreighterFleetOppTrackPositive._Cleanup_d__13.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._Cleanup_d__13>.NativeClassPtr, "<player>5__2");
				FreighterFleetOppTrackPositive._Cleanup_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._Cleanup_d__13>.NativeClassPtr, 100672581);
				FreighterFleetOppTrackPositive._Cleanup_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._Cleanup_d__13>.NativeClassPtr, 100672582);
				FreighterFleetOppTrackPositive._Cleanup_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._Cleanup_d__13>.NativeClassPtr, 100672583);
				FreighterFleetOppTrackPositive._Cleanup_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._Cleanup_d__13>.NativeClassPtr, 100672584);
				FreighterFleetOppTrackPositive._Cleanup_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._Cleanup_d__13>.NativeClassPtr, 100672585);
				FreighterFleetOppTrackPositive._Cleanup_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._Cleanup_d__13>.NativeClassPtr, 100672586);
				FreighterFleetOppTrackPositive._Cleanup_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._Cleanup_d__13>.NativeClassPtr, 100672587);
				FreighterFleetOppTrackPositive._Cleanup_d__13.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._Cleanup_d__13>.NativeClassPtr, 100672588);
			}

			// Token: 0x06007C9E RID: 31902 RVA: 0x00230814 File Offset: 0x0022EA14
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Cleanup_d__13(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._Cleanup_d__13>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterFleetOppTrackPositive._Cleanup_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06007C9F RID: 31903 RVA: 0x0023085C File Offset: 0x0022EA5C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterFleetOppTrackPositive._Cleanup_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007CA0 RID: 31904 RVA: 0x00230890 File Offset: 0x0022EA90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183670, XrefRangeEnd = 183696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterFleetOppTrackPositive._Cleanup_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700232F RID: 9007
			// (get) Token: 0x06007CA1 RID: 31905 RVA: 0x002308CC File Offset: 0x0022EACC
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterFleetOppTrackPositive._Cleanup_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06007CA2 RID: 31906 RVA: 0x0023090C File Offset: 0x0022EB0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183696, XrefRangeEnd = 183701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterFleetOppTrackPositive._Cleanup_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002330 RID: 9008
			// (get) Token: 0x06007CA3 RID: 31907 RVA: 0x00230940 File Offset: 0x0022EB40
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterFleetOppTrackPositive._Cleanup_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06007CA4 RID: 31908 RVA: 0x00230980 File Offset: 0x0022EB80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183701, XrefRangeEnd = 183710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterFleetOppTrackPositive._Cleanup_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06007CA5 RID: 31909 RVA: 0x002309C0 File Offset: 0x0022EBC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterFleetOppTrackPositive._Cleanup_d__13.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06007CA6 RID: 31910 RVA: 0x000332E1 File Offset: 0x000314E1
			public _Cleanup_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002327 RID: 8999
			// (get) Token: 0x06007CA7 RID: 31911 RVA: 0x00230A00 File Offset: 0x0022EC00
			// (set) Token: 0x06007CA8 RID: 31912 RVA: 0x000332EA File Offset: 0x000314EA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._Cleanup_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._Cleanup_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002328 RID: 9000
			// (get) Token: 0x06007CA9 RID: 31913 RVA: 0x00230A28 File Offset: 0x0022EC28
			// (set) Token: 0x06007CAA RID: 31914 RVA: 0x00033305 File Offset: 0x00031505
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._Cleanup_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._Cleanup_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002329 RID: 9001
			// (get) Token: 0x06007CAB RID: 31915 RVA: 0x00230A58 File Offset: 0x0022EC58
			// (set) Token: 0x06007CAC RID: 31916 RVA: 0x00033324 File Offset: 0x00031524
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._Cleanup_d__13.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._Cleanup_d__13.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700232A RID: 9002
			// (get) Token: 0x06007CAD RID: 31917 RVA: 0x00230A80 File Offset: 0x0022EC80
			// (set) Token: 0x06007CAE RID: 31918 RVA: 0x0003333F File Offset: 0x0003153F
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._Cleanup_d__13.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._Cleanup_d__13.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700232B RID: 9003
			// (get) Token: 0x06007CAF RID: 31919 RVA: 0x00230AB0 File Offset: 0x0022ECB0
			// (set) Token: 0x06007CB0 RID: 31920 RVA: 0x0003335E File Offset: 0x0003155E
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._Cleanup_d__13.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._Cleanup_d__13.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700232C RID: 9004
			// (get) Token: 0x06007CB1 RID: 31921 RVA: 0x00230AE0 File Offset: 0x0022ECE0
			// (set) Token: 0x06007CB2 RID: 31922 RVA: 0x0003337D File Offset: 0x0003157D
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._Cleanup_d__13.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._Cleanup_d__13.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700232D RID: 9005
			// (get) Token: 0x06007CB3 RID: 31923 RVA: 0x00230B10 File Offset: 0x0022ED10
			// (set) Token: 0x06007CB4 RID: 31924 RVA: 0x0003339C File Offset: 0x0003159C
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._Cleanup_d__13.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._Cleanup_d__13.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700232E RID: 9006
			// (get) Token: 0x06007CB5 RID: 31925 RVA: 0x00230B40 File Offset: 0x0022ED40
			// (set) Token: 0x06007CB6 RID: 31926 RVA: 0x000333BB File Offset: 0x000315BB
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._Cleanup_d__13.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._Cleanup_d__13.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005015 RID: 20501
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005016 RID: 20502
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005017 RID: 20503
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04005018 RID: 20504
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04005019 RID: 20505
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x0400501A RID: 20506
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x0400501B RID: 20507
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x0400501C RID: 20508
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x0400501D RID: 20509
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400501E RID: 20510
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400501F RID: 20511
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005020 RID: 20512
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04005021 RID: 20513
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005022 RID: 20514
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005023 RID: 20515
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04005024 RID: 20516
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200086C RID: 2156
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.RiseOfIx.FreighterFleetOppTrackPositive+<IsValidFor>d__7")]
		public sealed class _IsValidFor_d__7 : Object
		{
			// Token: 0x06007CB7 RID: 31927 RVA: 0x00230B70 File Offset: 0x0022ED70
			// Note: this type is marked as 'beforefieldinit'.
			static _IsValidFor_d__7()
			{
				Il2CppClassPointerStore<FreighterFleetOppTrackPositive._IsValidFor_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FreighterFleetOppTrackPositive>.NativeClassPtr, "<IsValidFor>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._IsValidFor_d__7>.NativeClassPtr);
				FreighterFleetOppTrackPositive._IsValidFor_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._IsValidFor_d__7>.NativeClassPtr, "<>1__state");
				FreighterFleetOppTrackPositive._IsValidFor_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._IsValidFor_d__7>.NativeClassPtr, "<>2__current");
				FreighterFleetOppTrackPositive._IsValidFor_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._IsValidFor_d__7>.NativeClassPtr, "<>l__initialThreadId");
				FreighterFleetOppTrackPositive._IsValidFor_d__7.NativeFieldInfoPtr_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._IsValidFor_d__7>.NativeClassPtr, "evt");
				FreighterFleetOppTrackPositive._IsValidFor_d__7.NativeFieldInfoPtr___3__evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._IsValidFor_d__7>.NativeClassPtr, "<>3__evt");
				FreighterFleetOppTrackPositive._IsValidFor_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._IsValidFor_d__7>.NativeClassPtr, "<>4__this");
				FreighterFleetOppTrackPositive._IsValidFor_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._IsValidFor_d__7>.NativeClassPtr, 100672589);
				FreighterFleetOppTrackPositive._IsValidFor_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._IsValidFor_d__7>.NativeClassPtr, 100672590);
				FreighterFleetOppTrackPositive._IsValidFor_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._IsValidFor_d__7>.NativeClassPtr, 100672591);
				FreighterFleetOppTrackPositive._IsValidFor_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._IsValidFor_d__7>.NativeClassPtr, 100672592);
				FreighterFleetOppTrackPositive._IsValidFor_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._IsValidFor_d__7>.NativeClassPtr, 100672593);
				FreighterFleetOppTrackPositive._IsValidFor_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._IsValidFor_d__7>.NativeClassPtr, 100672594);
				FreighterFleetOppTrackPositive._IsValidFor_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._IsValidFor_d__7>.NativeClassPtr, 100672595);
				FreighterFleetOppTrackPositive._IsValidFor_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._IsValidFor_d__7>.NativeClassPtr, 100672596);
			}

			// Token: 0x06007CB8 RID: 31928 RVA: 0x00230CB4 File Offset: 0x0022EEB4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _IsValidFor_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._IsValidFor_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterFleetOppTrackPositive._IsValidFor_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06007CB9 RID: 31929 RVA: 0x00230CFC File Offset: 0x0022EEFC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterFleetOppTrackPositive._IsValidFor_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007CBA RID: 31930 RVA: 0x00230D30 File Offset: 0x0022EF30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183710, XrefRangeEnd = 183748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterFleetOppTrackPositive._IsValidFor_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002337 RID: 9015
			// (get) Token: 0x06007CBB RID: 31931 RVA: 0x00230D6C File Offset: 0x0022EF6C
			public unsafe PlayerEntity System.Collections.Generic.IEnumerator<Canis.entities.PlayerEntity>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterFleetOppTrackPositive._IsValidFor_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr3) : null;
				}
			}

			// Token: 0x06007CBC RID: 31932 RVA: 0x00230DAC File Offset: 0x0022EFAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183748, XrefRangeEnd = 183753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterFleetOppTrackPositive._IsValidFor_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002338 RID: 9016
			// (get) Token: 0x06007CBD RID: 31933 RVA: 0x00230DE0 File Offset: 0x0022EFE0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterFleetOppTrackPositive._IsValidFor_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06007CBE RID: 31934 RVA: 0x00230E20 File Offset: 0x0022F020
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183753, XrefRangeEnd = 183762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<PlayerEntity> System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterFleetOppTrackPositive._IsValidFor_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<PlayerEntity>>(intPtr3) : null;
			}

			// Token: 0x06007CBF RID: 31935 RVA: 0x00230E60 File Offset: 0x0022F060
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterFleetOppTrackPositive._IsValidFor_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06007CC0 RID: 31936 RVA: 0x000333DA File Offset: 0x000315DA
			public _IsValidFor_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002331 RID: 9009
			// (get) Token: 0x06007CC1 RID: 31937 RVA: 0x00230EA0 File Offset: 0x0022F0A0
			// (set) Token: 0x06007CC2 RID: 31938 RVA: 0x000333E3 File Offset: 0x000315E3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._IsValidFor_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._IsValidFor_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002332 RID: 9010
			// (get) Token: 0x06007CC3 RID: 31939 RVA: 0x00230EC8 File Offset: 0x0022F0C8
			// (set) Token: 0x06007CC4 RID: 31940 RVA: 0x000333FE File Offset: 0x000315FE
			public unsafe PlayerEntity __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._IsValidFor_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._IsValidFor_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002333 RID: 9011
			// (get) Token: 0x06007CC5 RID: 31941 RVA: 0x00230EF8 File Offset: 0x0022F0F8
			// (set) Token: 0x06007CC6 RID: 31942 RVA: 0x0003341D File Offset: 0x0003161D
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._IsValidFor_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._IsValidFor_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17002334 RID: 9012
			// (get) Token: 0x06007CC7 RID: 31943 RVA: 0x00230F20 File Offset: 0x0022F120
			// (set) Token: 0x06007CC8 RID: 31944 RVA: 0x00033438 File Offset: 0x00031638
			public unsafe SerializableEvent evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._IsValidFor_d__7.NativeFieldInfoPtr_evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._IsValidFor_d__7.NativeFieldInfoPtr_evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002335 RID: 9013
			// (get) Token: 0x06007CC9 RID: 31945 RVA: 0x00230F50 File Offset: 0x0022F150
			// (set) Token: 0x06007CCA RID: 31946 RVA: 0x00033457 File Offset: 0x00031657
			public unsafe SerializableEvent __3__evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._IsValidFor_d__7.NativeFieldInfoPtr___3__evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._IsValidFor_d__7.NativeFieldInfoPtr___3__evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002336 RID: 9014
			// (get) Token: 0x06007CCB RID: 31947 RVA: 0x00230F80 File Offset: 0x0022F180
			// (set) Token: 0x06007CCC RID: 31948 RVA: 0x00033476 File Offset: 0x00031676
			public unsafe FreighterFleetOppTrackPositive __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._IsValidFor_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FreighterFleetOppTrackPositive>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._IsValidFor_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005025 RID: 20517
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005026 RID: 20518
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005027 RID: 20519
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04005028 RID: 20520
			private static readonly IntPtr NativeFieldInfoPtr_evt;

			// Token: 0x04005029 RID: 20521
			private static readonly IntPtr NativeFieldInfoPtr___3__evt;

			// Token: 0x0400502A RID: 20522
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400502B RID: 20523
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400502C RID: 20524
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400502D RID: 20525
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400502E RID: 20526
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0;

			// Token: 0x0400502F RID: 20527
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005030 RID: 20528
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005031 RID: 20529
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0;

			// Token: 0x04005032 RID: 20530
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200086D RID: 2157
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.RiseOfIx.FreighterFleetOppTrackPositive+<ResolveFreighterAbilities>d__12")]
		public sealed class _ResolveFreighterAbilities_d__12 : Object
		{
			// Token: 0x06007CCD RID: 31949 RVA: 0x00230FB0 File Offset: 0x0022F1B0
			// Note: this type is marked as 'beforefieldinit'.
			static _ResolveFreighterAbilities_d__12()
			{
				Il2CppClassPointerStore<FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FreighterFleetOppTrackPositive>.NativeClassPtr, "<ResolveFreighterAbilities>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12>.NativeClassPtr);
				FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12>.NativeClassPtr, "<>1__state");
				FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12>.NativeClassPtr, "<>2__current");
				FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12>.NativeClassPtr, "<>l__initialThreadId");
				FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12>.NativeClassPtr, "activeAbility");
				FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12>.NativeClassPtr, "<>3__activeAbility");
				FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12>.NativeClassPtr, "match");
				FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12>.NativeClassPtr, "<>3__match");
				FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12>.NativeClassPtr, 100672597);
				FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12>.NativeClassPtr, 100672598);
				FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12>.NativeClassPtr, 100672599);
				FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12>.NativeClassPtr, 100672600);
				FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12>.NativeClassPtr, 100672601);
				FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12>.NativeClassPtr, 100672602);
				FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12>.NativeClassPtr, 100672603);
				FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12>.NativeClassPtr, 100672604);
			}

			// Token: 0x06007CCE RID: 31950 RVA: 0x00231108 File Offset: 0x0022F308
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ResolveFreighterAbilities_d__12(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06007CCF RID: 31951 RVA: 0x00231150 File Offset: 0x0022F350
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007CD0 RID: 31952 RVA: 0x00231184 File Offset: 0x0022F384
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183762, XrefRangeEnd = 183843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002340 RID: 9024
			// (get) Token: 0x06007CD1 RID: 31953 RVA: 0x002311C0 File Offset: 0x0022F3C0
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06007CD2 RID: 31954 RVA: 0x00231200 File Offset: 0x0022F400
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183843, XrefRangeEnd = 183848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002341 RID: 9025
			// (get) Token: 0x06007CD3 RID: 31955 RVA: 0x00231234 File Offset: 0x0022F434
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06007CD4 RID: 31956 RVA: 0x00231274 File Offset: 0x0022F474
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183848, XrefRangeEnd = 183857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06007CD5 RID: 31957 RVA: 0x002312B4 File Offset: 0x0022F4B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06007CD6 RID: 31958 RVA: 0x00033495 File Offset: 0x00031695
			public _ResolveFreighterAbilities_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002339 RID: 9017
			// (get) Token: 0x06007CD7 RID: 31959 RVA: 0x002312F4 File Offset: 0x0022F4F4
			// (set) Token: 0x06007CD8 RID: 31960 RVA: 0x0003349E File Offset: 0x0003169E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700233A RID: 9018
			// (get) Token: 0x06007CD9 RID: 31961 RVA: 0x0023131C File Offset: 0x0022F51C
			// (set) Token: 0x06007CDA RID: 31962 RVA: 0x000334B9 File Offset: 0x000316B9
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700233B RID: 9019
			// (get) Token: 0x06007CDB RID: 31963 RVA: 0x0023134C File Offset: 0x0022F54C
			// (set) Token: 0x06007CDC RID: 31964 RVA: 0x000334D8 File Offset: 0x000316D8
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700233C RID: 9020
			// (get) Token: 0x06007CDD RID: 31965 RVA: 0x00231374 File Offset: 0x0022F574
			// (set) Token: 0x06007CDE RID: 31966 RVA: 0x000334F3 File Offset: 0x000316F3
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700233D RID: 9021
			// (get) Token: 0x06007CDF RID: 31967 RVA: 0x002313A4 File Offset: 0x0022F5A4
			// (set) Token: 0x06007CE0 RID: 31968 RVA: 0x00033512 File Offset: 0x00031712
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700233E RID: 9022
			// (get) Token: 0x06007CE1 RID: 31969 RVA: 0x002313D4 File Offset: 0x0022F5D4
			// (set) Token: 0x06007CE2 RID: 31970 RVA: 0x00033531 File Offset: 0x00031731
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700233F RID: 9023
			// (get) Token: 0x06007CE3 RID: 31971 RVA: 0x00231404 File Offset: 0x0022F604
			// (set) Token: 0x06007CE4 RID: 31972 RVA: 0x00033550 File Offset: 0x00031750
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreighterFleetOppTrackPositive._ResolveFreighterAbilities_d__12.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005033 RID: 20531
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005034 RID: 20532
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005035 RID: 20533
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04005036 RID: 20534
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04005037 RID: 20535
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x04005038 RID: 20536
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04005039 RID: 20537
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x0400503A RID: 20538
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400503B RID: 20539
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400503C RID: 20540
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400503D RID: 20541
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400503E RID: 20542
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400503F RID: 20543
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005040 RID: 20544
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04005041 RID: 20545
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
