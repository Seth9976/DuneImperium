using System;
using Canis;
using Canis.actions;
using Canis.context;
using Canis.entities;
using Canis.events;
using Canis.gameLogs;
using Canis.messages;
using Canis.utils.ids;
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

namespace worm.canis.abilities.TriggeredAbilities.RiseOfIx
{
	// Token: 0x02000368 RID: 872
	public class OneStepAheadRoundAbility : TriggeredAbility
	{
		// Token: 0x060023FA RID: 9210 RVA: 0x000E8950 File Offset: 0x000E6B50
		// Note: this type is marked as 'beforefieldinit'.
		static OneStepAheadRoundAbility()
		{
			Il2CppClassPointerStore<OneStepAheadRoundAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.TriggeredAbilities.RiseOfIx", "OneStepAheadRoundAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OneStepAheadRoundAbility>.NativeClassPtr);
			OneStepAheadRoundAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneStepAheadRoundAbility>.NativeClassPtr, "AbilityName");
			OneStepAheadRoundAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneStepAheadRoundAbility>.NativeClassPtr, "AbilityID");
			OneStepAheadRoundAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneStepAheadRoundAbility>.NativeClassPtr, 100672941);
			OneStepAheadRoundAbility.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneStepAheadRoundAbility>.NativeClassPtr, 100672942);
			OneStepAheadRoundAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneStepAheadRoundAbility>.NativeClassPtr, 100672943);
			OneStepAheadRoundAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneStepAheadRoundAbility>.NativeClassPtr, 100672944);
			OneStepAheadRoundAbility.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneStepAheadRoundAbility>.NativeClassPtr, 100672945);
			OneStepAheadRoundAbility.NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneStepAheadRoundAbility>.NativeClassPtr, 100672946);
			OneStepAheadRoundAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneStepAheadRoundAbility>.NativeClassPtr, 100672947);
			OneStepAheadRoundAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneStepAheadRoundAbility>.NativeClassPtr, 100672948);
			OneStepAheadRoundAbility.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneStepAheadRoundAbility>.NativeClassPtr, 100672949);
			OneStepAheadRoundAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneStepAheadRoundAbility>.NativeClassPtr, 100672950);
		}

		// Token: 0x060023FB RID: 9211 RVA: 0x000E8A70 File Offset: 0x000E6C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185834, XrefRangeEnd = 185838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OneStepAheadRoundAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x060023FC RID: 9212 RVA: 0x000E8ABC File Offset: 0x000E6CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185838, XrefRangeEnd = 185844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override GameLogBuilder MakeGameLogBuilder(IHasGameLogs hasGameLogs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hasGameLogs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OneStepAheadRoundAbility.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x060023FD RID: 9213 RVA: 0x000E8B18 File Offset: 0x000E6D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185844, XrefRangeEnd = 185847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OneStepAheadRoundAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OneStepAheadRoundAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneStepAheadRoundAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060023FE RID: 9214 RVA: 0x000E8B64 File Offset: 0x000E6D64
		[CallerCount(314)]
		[CachedScanResults(RefRangeStart = 176275, RefRangeEnd = 176589, XrefRangeStart = 176275, XrefRangeEnd = 176589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OneStepAheadRoundAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OneStepAheadRoundAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneStepAheadRoundAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023FF RID: 9215 RVA: 0x000E8BD4 File Offset: 0x000E6DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185847, XrefRangeEnd = 185854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<PlayerEntity> IsValidFor(SerializableEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OneStepAheadRoundAbility.NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayerEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x06002400 RID: 9216 RVA: 0x000E8C30 File Offset: 0x000E6E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185854, XrefRangeEnd = 185861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OneStepAheadRoundAbility.NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TargetInformation>>(intPtr3) : null;
		}

		// Token: 0x06002401 RID: 9217 RVA: 0x000E8CA0 File Offset: 0x000E6EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185861, XrefRangeEnd = 185865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OneStepAheadRoundAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x06002402 RID: 9218 RVA: 0x000E8D10 File Offset: 0x000E6F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185865, XrefRangeEnd = 185873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OneStepAheadRoundAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06002403 RID: 9219 RVA: 0x000E8D90 File Offset: 0x000E6F90
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OneStepAheadRoundAbility.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002404 RID: 9220 RVA: 0x000E8E0C File Offset: 0x000E700C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185873, XrefRangeEnd = 185943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WormAIChoice Evaluate(WormAIChoiceContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OneStepAheadRoundAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormAIChoice>(intPtr3) : null;
			}
		}

		// Token: 0x06002405 RID: 9221 RVA: 0x0000E311 File Offset: 0x0000C511
		public OneStepAheadRoundAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x06002406 RID: 9222 RVA: 0x000E8E68 File Offset: 0x000E7068
		// (set) Token: 0x06002407 RID: 9223 RVA: 0x0000E31A File Offset: 0x0000C51A
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OneStepAheadRoundAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OneStepAheadRoundAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x06002408 RID: 9224 RVA: 0x000E8E88 File Offset: 0x000E7088
		// (set) Token: 0x06002409 RID: 9225 RVA: 0x0000E32C File Offset: 0x0000C52C
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OneStepAheadRoundAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OneStepAheadRoundAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040016DB RID: 5851
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x040016DC RID: 5852
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x040016DD RID: 5853
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x040016DE RID: 5854
		private static readonly IntPtr NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0;

		// Token: 0x040016DF RID: 5855
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x040016E0 RID: 5856
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x040016E1 RID: 5857
		private static readonly IntPtr NativeMethodInfoPtr_IsValidFor_Public_Virtual_IEnumerable_1_PlayerEntity_SerializableEvent_0;

		// Token: 0x040016E2 RID: 5858
		private static readonly IntPtr NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0;

		// Token: 0x040016E3 RID: 5859
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0;

		// Token: 0x040016E4 RID: 5860
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x040016E5 RID: 5861
		private static readonly IntPtr NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0;

		// Token: 0x040016E6 RID: 5862
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0;

		// Token: 0x0200088F RID: 2191
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.RiseOfIx.OneStepAheadRoundAbility+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06007F9D RID: 32669 RVA: 0x002394B8 File Offset: 0x002376B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<OneStepAheadRoundAbility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OneStepAheadRoundAbility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OneStepAheadRoundAbility.__c>.NativeClassPtr);
				OneStepAheadRoundAbility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneStepAheadRoundAbility.__c>.NativeClassPtr, "<>9");
				OneStepAheadRoundAbility.__c.NativeFieldInfoPtr___9__11_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneStepAheadRoundAbility.__c>.NativeClassPtr, "<>9__11_1");
				OneStepAheadRoundAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneStepAheadRoundAbility.__c>.NativeClassPtr, 100672953);
				OneStepAheadRoundAbility.__c.NativeMethodInfoPtr__Evaluate_b__11_1_Internal_Boolean_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneStepAheadRoundAbility.__c>.NativeClassPtr, 100672954);
			}

			// Token: 0x06007F9E RID: 32670 RVA: 0x00239534 File Offset: 0x00237734
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OneStepAheadRoundAbility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneStepAheadRoundAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007F9F RID: 32671 RVA: 0x00239570 File Offset: 0x00237770
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185701, XrefRangeEnd = 185703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Evaluate_b__11_1(WormImperiumPlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneStepAheadRoundAbility.__c.NativeMethodInfoPtr__Evaluate_b__11_1_Internal_Boolean_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06007FA0 RID: 32672 RVA: 0x00034E4D File Offset: 0x0003304D
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002442 RID: 9282
			// (get) Token: 0x06007FA1 RID: 32673 RVA: 0x002395C0 File Offset: 0x002377C0
			// (set) Token: 0x06007FA2 RID: 32674 RVA: 0x00034E56 File Offset: 0x00033056
			public unsafe static OneStepAheadRoundAbility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OneStepAheadRoundAbility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OneStepAheadRoundAbility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OneStepAheadRoundAbility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002443 RID: 9283
			// (get) Token: 0x06007FA3 RID: 32675 RVA: 0x002395E8 File Offset: 0x002377E8
			// (set) Token: 0x06007FA4 RID: 32676 RVA: 0x00034E68 File Offset: 0x00033068
			public unsafe static Func<WormImperiumPlayable, bool> __9__11_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OneStepAheadRoundAbility.__c.NativeFieldInfoPtr___9__11_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormImperiumPlayable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OneStepAheadRoundAbility.__c.NativeFieldInfoPtr___9__11_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040051EA RID: 20970
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040051EB RID: 20971
			private static readonly IntPtr NativeFieldInfoPtr___9__11_1;

			// Token: 0x040051EC RID: 20972
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040051ED RID: 20973
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__11_1_Internal_Boolean_WormImperiumPlayable_0;
		}

		// Token: 0x02000890 RID: 2192
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.RiseOfIx.OneStepAheadRoundAbility+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Object
		{
			// Token: 0x06007FA5 RID: 32677 RVA: 0x00239610 File Offset: 0x00237810
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<OneStepAheadRoundAbility.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OneStepAheadRoundAbility>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OneStepAheadRoundAbility.__c__DisplayClass11_0>.NativeClassPtr);
				OneStepAheadRoundAbility.__c__DisplayClass11_0.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneStepAheadRoundAbility.__c__DisplayClass11_0>.NativeClassPtr, "context");
				OneStepAheadRoundAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneStepAheadRoundAbility.__c__DisplayClass11_0>.NativeClassPtr, 100672955);
				OneStepAheadRoundAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__Evaluate_b__0_Internal_Double_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneStepAheadRoundAbility.__c__DisplayClass11_0>.NativeClassPtr, 100672956);
			}

			// Token: 0x06007FA6 RID: 32678 RVA: 0x00239678 File Offset: 0x00237878
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OneStepAheadRoundAbility.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneStepAheadRoundAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007FA7 RID: 32679 RVA: 0x002396B4 File Offset: 0x002378B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185703, XrefRangeEnd = 185716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double _Evaluate_b__0(WormImperiumPlayable card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneStepAheadRoundAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__Evaluate_b__0_Internal_Double_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06007FA8 RID: 32680 RVA: 0x00034E7A File Offset: 0x0003307A
			public __c__DisplayClass11_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002444 RID: 9284
			// (get) Token: 0x06007FA9 RID: 32681 RVA: 0x00239704 File Offset: 0x00237904
			// (set) Token: 0x06007FAA RID: 32682 RVA: 0x00034E83 File Offset: 0x00033083
			public unsafe WormAIChoiceContext context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility.__c__DisplayClass11_0.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAIChoiceContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility.__c__DisplayClass11_0.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040051EE RID: 20974
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x040051EF RID: 20975
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040051F0 RID: 20976
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__0_Internal_Double_WormImperiumPlayable_0;
		}

		// Token: 0x02000891 RID: 2193
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.RiseOfIx.OneStepAheadRoundAbility+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Object
		{
			// Token: 0x06007FAB RID: 32683 RVA: 0x00239734 File Offset: 0x00237934
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<OneStepAheadRoundAbility.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OneStepAheadRoundAbility>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OneStepAheadRoundAbility.__c__DisplayClass9_0>.NativeClassPtr);
				OneStepAheadRoundAbility.__c__DisplayClass9_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneStepAheadRoundAbility.__c__DisplayClass9_0>.NativeClassPtr, "player");
				OneStepAheadRoundAbility.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneStepAheadRoundAbility.__c__DisplayClass9_0>.NativeClassPtr, 100672957);
				OneStepAheadRoundAbility.__c__DisplayClass9_0.NativeMethodInfoPtr__BeginExecution_b__0_Internal_GameLogBuilder_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneStepAheadRoundAbility.__c__DisplayClass9_0>.NativeClassPtr, 100672958);
			}

			// Token: 0x06007FAC RID: 32684 RVA: 0x0023979C File Offset: 0x0023799C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OneStepAheadRoundAbility.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneStepAheadRoundAbility.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007FAD RID: 32685 RVA: 0x002397D8 File Offset: 0x002379D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185716, XrefRangeEnd = 185720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GameLogBuilder _BeginExecution_b__0(GameLogBuilder _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneStepAheadRoundAbility.__c__DisplayClass9_0.NativeMethodInfoPtr__BeginExecution_b__0_Internal_GameLogBuilder_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x06007FAE RID: 32686 RVA: 0x00034EA2 File Offset: 0x000330A2
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002445 RID: 9285
			// (get) Token: 0x06007FAF RID: 32687 RVA: 0x00239828 File Offset: 0x00237A28
			// (set) Token: 0x06007FB0 RID: 32688 RVA: 0x00034EAB File Offset: 0x000330AB
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility.__c__DisplayClass9_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility.__c__DisplayClass9_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040051F1 RID: 20977
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x040051F2 RID: 20978
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040051F3 RID: 20979
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__0_Internal_GameLogBuilder_GameLogBuilder_0;
		}

		// Token: 0x02000892 RID: 2194
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.RiseOfIx.OneStepAheadRoundAbility+<BeginExecution>d__9")]
		public sealed class _BeginExecution_d__9 : Object
		{
			// Token: 0x06007FB1 RID: 32689 RVA: 0x00239858 File Offset: 0x00237A58
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginExecution_d__9()
			{
				Il2CppClassPointerStore<OneStepAheadRoundAbility._BeginExecution_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OneStepAheadRoundAbility>.NativeClassPtr, "<BeginExecution>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OneStepAheadRoundAbility._BeginExecution_d__9>.NativeClassPtr);
				OneStepAheadRoundAbility._BeginExecution_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneStepAheadRoundAbility._BeginExecution_d__9>.NativeClassPtr, "<>1__state");
				OneStepAheadRoundAbility._BeginExecution_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneStepAheadRoundAbility._BeginExecution_d__9>.NativeClassPtr, "<>2__current");
				OneStepAheadRoundAbility._BeginExecution_d__9.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneStepAheadRoundAbility._BeginExecution_d__9>.NativeClassPtr, "<>l__initialThreadId");
				OneStepAheadRoundAbility._BeginExecution_d__9.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneStepAheadRoundAbility._BeginExecution_d__9>.NativeClassPtr, "activeAbility");
				OneStepAheadRoundAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneStepAheadRoundAbility._BeginExecution_d__9>.NativeClassPtr, "<>3__activeAbility");
				OneStepAheadRoundAbility._BeginExecution_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneStepAheadRoundAbility._BeginExecution_d__9>.NativeClassPtr, "<>4__this");
				OneStepAheadRoundAbility._BeginExecution_d__9.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneStepAheadRoundAbility._BeginExecution_d__9>.NativeClassPtr, "match");
				OneStepAheadRoundAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneStepAheadRoundAbility._BeginExecution_d__9>.NativeClassPtr, "<>3__match");
				OneStepAheadRoundAbility._BeginExecution_d__9.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneStepAheadRoundAbility._BeginExecution_d__9>.NativeClassPtr, "<>8__1");
				OneStepAheadRoundAbility._BeginExecution_d__9.NativeFieldInfoPtr__chosenCard_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneStepAheadRoundAbility._BeginExecution_d__9>.NativeClassPtr, "<chosenCard>5__2");
				OneStepAheadRoundAbility._BeginExecution_d__9.NativeFieldInfoPtr__sequenceHelper_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneStepAheadRoundAbility._BeginExecution_d__9>.NativeClassPtr, "<sequenceHelper>5__3");
				OneStepAheadRoundAbility._BeginExecution_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneStepAheadRoundAbility._BeginExecution_d__9>.NativeClassPtr, 100672959);
				OneStepAheadRoundAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneStepAheadRoundAbility._BeginExecution_d__9>.NativeClassPtr, 100672960);
				OneStepAheadRoundAbility._BeginExecution_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneStepAheadRoundAbility._BeginExecution_d__9>.NativeClassPtr, 100672961);
				OneStepAheadRoundAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneStepAheadRoundAbility._BeginExecution_d__9>.NativeClassPtr, 100672962);
				OneStepAheadRoundAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneStepAheadRoundAbility._BeginExecution_d__9>.NativeClassPtr, 100672963);
				OneStepAheadRoundAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneStepAheadRoundAbility._BeginExecution_d__9>.NativeClassPtr, 100672964);
				OneStepAheadRoundAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneStepAheadRoundAbility._BeginExecution_d__9>.NativeClassPtr, 100672965);
				OneStepAheadRoundAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneStepAheadRoundAbility._BeginExecution_d__9>.NativeClassPtr, 100672966);
			}

			// Token: 0x06007FB2 RID: 32690 RVA: 0x00239A00 File Offset: 0x00237C00
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginExecution_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OneStepAheadRoundAbility._BeginExecution_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneStepAheadRoundAbility._BeginExecution_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06007FB3 RID: 32691 RVA: 0x00239A48 File Offset: 0x00237C48
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneStepAheadRoundAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007FB4 RID: 32692 RVA: 0x00239A7C File Offset: 0x00237C7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185720, XrefRangeEnd = 185748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneStepAheadRoundAbility._BeginExecution_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002451 RID: 9297
			// (get) Token: 0x06007FB5 RID: 32693 RVA: 0x00239AB8 File Offset: 0x00237CB8
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneStepAheadRoundAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06007FB6 RID: 32694 RVA: 0x00239AF8 File Offset: 0x00237CF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185748, XrefRangeEnd = 185753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneStepAheadRoundAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002452 RID: 9298
			// (get) Token: 0x06007FB7 RID: 32695 RVA: 0x00239B2C File Offset: 0x00237D2C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneStepAheadRoundAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06007FB8 RID: 32696 RVA: 0x00239B6C File Offset: 0x00237D6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185753, XrefRangeEnd = 185763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneStepAheadRoundAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06007FB9 RID: 32697 RVA: 0x00239BAC File Offset: 0x00237DAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneStepAheadRoundAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06007FBA RID: 32698 RVA: 0x00034ECA File Offset: 0x000330CA
			public _BeginExecution_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002446 RID: 9286
			// (get) Token: 0x06007FBB RID: 32699 RVA: 0x00239BEC File Offset: 0x00237DEC
			// (set) Token: 0x06007FBC RID: 32700 RVA: 0x00034ED3 File Offset: 0x000330D3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._BeginExecution_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._BeginExecution_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002447 RID: 9287
			// (get) Token: 0x06007FBD RID: 32701 RVA: 0x00239C14 File Offset: 0x00237E14
			// (set) Token: 0x06007FBE RID: 32702 RVA: 0x00034EEE File Offset: 0x000330EE
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._BeginExecution_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._BeginExecution_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002448 RID: 9288
			// (get) Token: 0x06007FBF RID: 32703 RVA: 0x00239C44 File Offset: 0x00237E44
			// (set) Token: 0x06007FC0 RID: 32704 RVA: 0x00034F0D File Offset: 0x0003310D
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._BeginExecution_d__9.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._BeginExecution_d__9.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17002449 RID: 9289
			// (get) Token: 0x06007FC1 RID: 32705 RVA: 0x00239C6C File Offset: 0x00237E6C
			// (set) Token: 0x06007FC2 RID: 32706 RVA: 0x00034F28 File Offset: 0x00033128
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._BeginExecution_d__9.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._BeginExecution_d__9.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700244A RID: 9290
			// (get) Token: 0x06007FC3 RID: 32707 RVA: 0x00239C9C File Offset: 0x00237E9C
			// (set) Token: 0x06007FC4 RID: 32708 RVA: 0x00034F47 File Offset: 0x00033147
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700244B RID: 9291
			// (get) Token: 0x06007FC5 RID: 32709 RVA: 0x00239CCC File Offset: 0x00237ECC
			// (set) Token: 0x06007FC6 RID: 32710 RVA: 0x00034F66 File Offset: 0x00033166
			public unsafe OneStepAheadRoundAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._BeginExecution_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OneStepAheadRoundAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._BeginExecution_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700244C RID: 9292
			// (get) Token: 0x06007FC7 RID: 32711 RVA: 0x00239CFC File Offset: 0x00237EFC
			// (set) Token: 0x06007FC8 RID: 32712 RVA: 0x00034F85 File Offset: 0x00033185
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._BeginExecution_d__9.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._BeginExecution_d__9.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700244D RID: 9293
			// (get) Token: 0x06007FC9 RID: 32713 RVA: 0x00239D2C File Offset: 0x00237F2C
			// (set) Token: 0x06007FCA RID: 32714 RVA: 0x00034FA4 File Offset: 0x000331A4
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700244E RID: 9294
			// (get) Token: 0x06007FCB RID: 32715 RVA: 0x00239D5C File Offset: 0x00237F5C
			// (set) Token: 0x06007FCC RID: 32716 RVA: 0x00034FC3 File Offset: 0x000331C3
			public unsafe OneStepAheadRoundAbility.__c__DisplayClass9_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._BeginExecution_d__9.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OneStepAheadRoundAbility.__c__DisplayClass9_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._BeginExecution_d__9.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700244F RID: 9295
			// (get) Token: 0x06007FCD RID: 32717 RVA: 0x00239D8C File Offset: 0x00237F8C
			// (set) Token: 0x06007FCE RID: 32718 RVA: 0x00034FE2 File Offset: 0x000331E2
			public unsafe WormImperiumPlayable _chosenCard_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._BeginExecution_d__9.NativeFieldInfoPtr__chosenCard_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._BeginExecution_d__9.NativeFieldInfoPtr__chosenCard_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002450 RID: 9296
			// (get) Token: 0x06007FCF RID: 32719 RVA: 0x00239DBC File Offset: 0x00237FBC
			// (set) Token: 0x06007FD0 RID: 32720 RVA: 0x00035001 File Offset: 0x00033201
			public unsafe SequenceHelper _sequenceHelper_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._BeginExecution_d__9.NativeFieldInfoPtr__sequenceHelper_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._BeginExecution_d__9.NativeFieldInfoPtr__sequenceHelper_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040051F4 RID: 20980
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040051F5 RID: 20981
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040051F6 RID: 20982
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040051F7 RID: 20983
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x040051F8 RID: 20984
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x040051F9 RID: 20985
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040051FA RID: 20986
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x040051FB RID: 20987
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x040051FC RID: 20988
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040051FD RID: 20989
			private static readonly IntPtr NativeFieldInfoPtr__chosenCard_5__2;

			// Token: 0x040051FE RID: 20990
			private static readonly IntPtr NativeFieldInfoPtr__sequenceHelper_5__3;

			// Token: 0x040051FF RID: 20991
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005200 RID: 20992
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005201 RID: 20993
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005202 RID: 20994
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04005203 RID: 20995
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005204 RID: 20996
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005205 RID: 20997
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04005206 RID: 20998
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000893 RID: 2195
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.RiseOfIx.OneStepAheadRoundAbility+<IsValidFor>d__6")]
		public sealed class _IsValidFor_d__6 : Object
		{
			// Token: 0x06007FD1 RID: 32721 RVA: 0x00239DEC File Offset: 0x00237FEC
			// Note: this type is marked as 'beforefieldinit'.
			static _IsValidFor_d__6()
			{
				Il2CppClassPointerStore<OneStepAheadRoundAbility._IsValidFor_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OneStepAheadRoundAbility>.NativeClassPtr, "<IsValidFor>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OneStepAheadRoundAbility._IsValidFor_d__6>.NativeClassPtr);
				OneStepAheadRoundAbility._IsValidFor_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneStepAheadRoundAbility._IsValidFor_d__6>.NativeClassPtr, "<>1__state");
				OneStepAheadRoundAbility._IsValidFor_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneStepAheadRoundAbility._IsValidFor_d__6>.NativeClassPtr, "<>2__current");
				OneStepAheadRoundAbility._IsValidFor_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneStepAheadRoundAbility._IsValidFor_d__6>.NativeClassPtr, "<>l__initialThreadId");
				OneStepAheadRoundAbility._IsValidFor_d__6.NativeFieldInfoPtr_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneStepAheadRoundAbility._IsValidFor_d__6>.NativeClassPtr, "evt");
				OneStepAheadRoundAbility._IsValidFor_d__6.NativeFieldInfoPtr___3__evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneStepAheadRoundAbility._IsValidFor_d__6>.NativeClassPtr, "<>3__evt");
				OneStepAheadRoundAbility._IsValidFor_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneStepAheadRoundAbility._IsValidFor_d__6>.NativeClassPtr, "<>4__this");
				OneStepAheadRoundAbility._IsValidFor_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneStepAheadRoundAbility._IsValidFor_d__6>.NativeClassPtr, 100672967);
				OneStepAheadRoundAbility._IsValidFor_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneStepAheadRoundAbility._IsValidFor_d__6>.NativeClassPtr, 100672968);
				OneStepAheadRoundAbility._IsValidFor_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneStepAheadRoundAbility._IsValidFor_d__6>.NativeClassPtr, 100672969);
				OneStepAheadRoundAbility._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneStepAheadRoundAbility._IsValidFor_d__6>.NativeClassPtr, 100672970);
				OneStepAheadRoundAbility._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneStepAheadRoundAbility._IsValidFor_d__6>.NativeClassPtr, 100672971);
				OneStepAheadRoundAbility._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneStepAheadRoundAbility._IsValidFor_d__6>.NativeClassPtr, 100672972);
				OneStepAheadRoundAbility._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneStepAheadRoundAbility._IsValidFor_d__6>.NativeClassPtr, 100672973);
				OneStepAheadRoundAbility._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneStepAheadRoundAbility._IsValidFor_d__6>.NativeClassPtr, 100672974);
			}

			// Token: 0x06007FD2 RID: 32722 RVA: 0x00239F30 File Offset: 0x00238130
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _IsValidFor_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OneStepAheadRoundAbility._IsValidFor_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneStepAheadRoundAbility._IsValidFor_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06007FD3 RID: 32723 RVA: 0x00239F78 File Offset: 0x00238178
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneStepAheadRoundAbility._IsValidFor_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007FD4 RID: 32724 RVA: 0x00239FAC File Offset: 0x002381AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185763, XrefRangeEnd = 185773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneStepAheadRoundAbility._IsValidFor_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002459 RID: 9305
			// (get) Token: 0x06007FD5 RID: 32725 RVA: 0x00239FE8 File Offset: 0x002381E8
			public unsafe PlayerEntity System.Collections.Generic.IEnumerator<Canis.entities.PlayerEntity>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneStepAheadRoundAbility._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr3) : null;
				}
			}

			// Token: 0x06007FD6 RID: 32726 RVA: 0x0023A028 File Offset: 0x00238228
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185773, XrefRangeEnd = 185778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneStepAheadRoundAbility._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700245A RID: 9306
			// (get) Token: 0x06007FD7 RID: 32727 RVA: 0x0023A05C File Offset: 0x0023825C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneStepAheadRoundAbility._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06007FD8 RID: 32728 RVA: 0x0023A09C File Offset: 0x0023829C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185778, XrefRangeEnd = 185787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<PlayerEntity> System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneStepAheadRoundAbility._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<PlayerEntity>>(intPtr3) : null;
			}

			// Token: 0x06007FD9 RID: 32729 RVA: 0x0023A0DC File Offset: 0x002382DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneStepAheadRoundAbility._IsValidFor_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06007FDA RID: 32730 RVA: 0x00035020 File Offset: 0x00033220
			public _IsValidFor_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002453 RID: 9299
			// (get) Token: 0x06007FDB RID: 32731 RVA: 0x0023A11C File Offset: 0x0023831C
			// (set) Token: 0x06007FDC RID: 32732 RVA: 0x00035029 File Offset: 0x00033229
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._IsValidFor_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._IsValidFor_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002454 RID: 9300
			// (get) Token: 0x06007FDD RID: 32733 RVA: 0x0023A144 File Offset: 0x00238344
			// (set) Token: 0x06007FDE RID: 32734 RVA: 0x00035044 File Offset: 0x00033244
			public unsafe PlayerEntity __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._IsValidFor_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._IsValidFor_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002455 RID: 9301
			// (get) Token: 0x06007FDF RID: 32735 RVA: 0x0023A174 File Offset: 0x00238374
			// (set) Token: 0x06007FE0 RID: 32736 RVA: 0x00035063 File Offset: 0x00033263
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._IsValidFor_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._IsValidFor_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17002456 RID: 9302
			// (get) Token: 0x06007FE1 RID: 32737 RVA: 0x0023A19C File Offset: 0x0023839C
			// (set) Token: 0x06007FE2 RID: 32738 RVA: 0x0003507E File Offset: 0x0003327E
			public unsafe SerializableEvent evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._IsValidFor_d__6.NativeFieldInfoPtr_evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._IsValidFor_d__6.NativeFieldInfoPtr_evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002457 RID: 9303
			// (get) Token: 0x06007FE3 RID: 32739 RVA: 0x0023A1CC File Offset: 0x002383CC
			// (set) Token: 0x06007FE4 RID: 32740 RVA: 0x0003509D File Offset: 0x0003329D
			public unsafe SerializableEvent __3__evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._IsValidFor_d__6.NativeFieldInfoPtr___3__evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._IsValidFor_d__6.NativeFieldInfoPtr___3__evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002458 RID: 9304
			// (get) Token: 0x06007FE5 RID: 32741 RVA: 0x0023A1FC File Offset: 0x002383FC
			// (set) Token: 0x06007FE6 RID: 32742 RVA: 0x000350BC File Offset: 0x000332BC
			public unsafe OneStepAheadRoundAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._IsValidFor_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OneStepAheadRoundAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._IsValidFor_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005207 RID: 20999
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005208 RID: 21000
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005209 RID: 21001
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400520A RID: 21002
			private static readonly IntPtr NativeFieldInfoPtr_evt;

			// Token: 0x0400520B RID: 21003
			private static readonly IntPtr NativeFieldInfoPtr___3__evt;

			// Token: 0x0400520C RID: 21004
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400520D RID: 21005
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400520E RID: 21006
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400520F RID: 21007
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005210 RID: 21008
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0;

			// Token: 0x04005211 RID: 21009
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005212 RID: 21010
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005213 RID: 21011
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0;

			// Token: 0x04005214 RID: 21012
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000894 RID: 2196
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.RiseOfIx.OneStepAheadRoundAbility+<Targets>d__7")]
		public sealed class _Targets_d__7 : Object
		{
			// Token: 0x06007FE7 RID: 32743 RVA: 0x0023A22C File Offset: 0x0023842C
			// Note: this type is marked as 'beforefieldinit'.
			static _Targets_d__7()
			{
				Il2CppClassPointerStore<OneStepAheadRoundAbility._Targets_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OneStepAheadRoundAbility>.NativeClassPtr, "<Targets>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OneStepAheadRoundAbility._Targets_d__7>.NativeClassPtr);
				OneStepAheadRoundAbility._Targets_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneStepAheadRoundAbility._Targets_d__7>.NativeClassPtr, "<>1__state");
				OneStepAheadRoundAbility._Targets_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneStepAheadRoundAbility._Targets_d__7>.NativeClassPtr, "<>2__current");
				OneStepAheadRoundAbility._Targets_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneStepAheadRoundAbility._Targets_d__7>.NativeClassPtr, "<>l__initialThreadId");
				OneStepAheadRoundAbility._Targets_d__7.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneStepAheadRoundAbility._Targets_d__7>.NativeClassPtr, "context");
				OneStepAheadRoundAbility._Targets_d__7.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneStepAheadRoundAbility._Targets_d__7>.NativeClassPtr, "<>3__context");
				OneStepAheadRoundAbility._Targets_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OneStepAheadRoundAbility._Targets_d__7>.NativeClassPtr, "<>4__this");
				OneStepAheadRoundAbility._Targets_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneStepAheadRoundAbility._Targets_d__7>.NativeClassPtr, 100672975);
				OneStepAheadRoundAbility._Targets_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneStepAheadRoundAbility._Targets_d__7>.NativeClassPtr, 100672976);
				OneStepAheadRoundAbility._Targets_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneStepAheadRoundAbility._Targets_d__7>.NativeClassPtr, 100672977);
				OneStepAheadRoundAbility._Targets_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneStepAheadRoundAbility._Targets_d__7>.NativeClassPtr, 100672978);
				OneStepAheadRoundAbility._Targets_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneStepAheadRoundAbility._Targets_d__7>.NativeClassPtr, 100672979);
				OneStepAheadRoundAbility._Targets_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneStepAheadRoundAbility._Targets_d__7>.NativeClassPtr, 100672980);
				OneStepAheadRoundAbility._Targets_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneStepAheadRoundAbility._Targets_d__7>.NativeClassPtr, 100672981);
				OneStepAheadRoundAbility._Targets_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OneStepAheadRoundAbility._Targets_d__7>.NativeClassPtr, 100672982);
			}

			// Token: 0x06007FE8 RID: 32744 RVA: 0x0023A370 File Offset: 0x00238570
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Targets_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OneStepAheadRoundAbility._Targets_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneStepAheadRoundAbility._Targets_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06007FE9 RID: 32745 RVA: 0x0023A3B8 File Offset: 0x002385B8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneStepAheadRoundAbility._Targets_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007FEA RID: 32746 RVA: 0x0023A3EC File Offset: 0x002385EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185787, XrefRangeEnd = 185820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneStepAheadRoundAbility._Targets_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002461 RID: 9313
			// (get) Token: 0x06007FEB RID: 32747 RVA: 0x0023A428 File Offset: 0x00238628
			public unsafe TargetInformation System.Collections.Generic.IEnumerator<Networking.selection.targetinformation.TargetInformation>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneStepAheadRoundAbility._Targets_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetInformation>(intPtr3) : null;
				}
			}

			// Token: 0x06007FEC RID: 32748 RVA: 0x0023A468 File Offset: 0x00238668
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185820, XrefRangeEnd = 185825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneStepAheadRoundAbility._Targets_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002462 RID: 9314
			// (get) Token: 0x06007FED RID: 32749 RVA: 0x0023A49C File Offset: 0x0023869C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneStepAheadRoundAbility._Targets_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06007FEE RID: 32750 RVA: 0x0023A4DC File Offset: 0x002386DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185825, XrefRangeEnd = 185834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TargetInformation> System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneStepAheadRoundAbility._Targets_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TargetInformation>>(intPtr3) : null;
			}

			// Token: 0x06007FEF RID: 32751 RVA: 0x0023A51C File Offset: 0x0023871C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OneStepAheadRoundAbility._Targets_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06007FF0 RID: 32752 RVA: 0x000350DB File Offset: 0x000332DB
			public _Targets_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700245B RID: 9307
			// (get) Token: 0x06007FF1 RID: 32753 RVA: 0x0023A55C File Offset: 0x0023875C
			// (set) Token: 0x06007FF2 RID: 32754 RVA: 0x000350E4 File Offset: 0x000332E4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._Targets_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._Targets_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700245C RID: 9308
			// (get) Token: 0x06007FF3 RID: 32755 RVA: 0x0023A584 File Offset: 0x00238784
			// (set) Token: 0x06007FF4 RID: 32756 RVA: 0x000350FF File Offset: 0x000332FF
			public unsafe TargetInformation __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._Targets_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TargetInformation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._Targets_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700245D RID: 9309
			// (get) Token: 0x06007FF5 RID: 32757 RVA: 0x0023A5B4 File Offset: 0x002387B4
			// (set) Token: 0x06007FF6 RID: 32758 RVA: 0x0003511E File Offset: 0x0003331E
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._Targets_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._Targets_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700245E RID: 9310
			// (get) Token: 0x06007FF7 RID: 32759 RVA: 0x0023A5DC File Offset: 0x002387DC
			// (set) Token: 0x06007FF8 RID: 32760 RVA: 0x00035139 File Offset: 0x00033339
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._Targets_d__7.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._Targets_d__7.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700245F RID: 9311
			// (get) Token: 0x06007FF9 RID: 32761 RVA: 0x0023A60C File Offset: 0x0023880C
			// (set) Token: 0x06007FFA RID: 32762 RVA: 0x00035158 File Offset: 0x00033358
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._Targets_d__7.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._Targets_d__7.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002460 RID: 9312
			// (get) Token: 0x06007FFB RID: 32763 RVA: 0x0023A63C File Offset: 0x0023883C
			// (set) Token: 0x06007FFC RID: 32764 RVA: 0x00035177 File Offset: 0x00033377
			public unsafe OneStepAheadRoundAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._Targets_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OneStepAheadRoundAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OneStepAheadRoundAbility._Targets_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005215 RID: 21013
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005216 RID: 21014
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005217 RID: 21015
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04005218 RID: 21016
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04005219 RID: 21017
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x0400521A RID: 21018
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400521B RID: 21019
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400521C RID: 21020
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400521D RID: 21021
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400521E RID: 21022
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0;

			// Token: 0x0400521F RID: 21023
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005220 RID: 21024
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005221 RID: 21025
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0;

			// Token: 0x04005222 RID: 21026
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
