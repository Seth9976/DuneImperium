using System;
using Canis;
using Canis.actions;
using Canis.attributes;
using Canis.context;
using Canis.context.targetpickers;
using Canis.entities;
using Canis.entities.ai;
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
using worm.canis.data.enums;
using worm.canis.entities;

namespace worm.canis.abilities.PlayAbilities.BaseSet
{
	// Token: 0x02000473 RID: 1139
	public class BypassProtocolAbility : IntrigueAbility
	{
		// Token: 0x06003271 RID: 12913 RVA: 0x0012E5E8 File Offset: 0x0012C7E8
		// Note: this type is marked as 'beforefieldinit'.
		static BypassProtocolAbility()
		{
			Il2CppClassPointerStore<BypassProtocolAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.PlayAbilities.BaseSet", "BypassProtocolAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BypassProtocolAbility>.NativeClassPtr);
			BypassProtocolAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BypassProtocolAbility>.NativeClassPtr, "AbilityName");
			BypassProtocolAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BypassProtocolAbility>.NativeClassPtr, "AbilityID");
			BypassProtocolAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility>.NativeClassPtr, 100678940);
			BypassProtocolAbility.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility>.NativeClassPtr, 100678941);
			BypassProtocolAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility>.NativeClassPtr, 100678942);
			BypassProtocolAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility>.NativeClassPtr, 100678943);
			BypassProtocolAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility>.NativeClassPtr, 100678944);
			BypassProtocolAbility.NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility>.NativeClassPtr, 100678945);
			BypassProtocolAbility.NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility>.NativeClassPtr, 100678946);
			BypassProtocolAbility.NativeMethodInfoPtr_ShowHinting_Public_Virtual_Boolean_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility>.NativeClassPtr, 100678947);
			BypassProtocolAbility.NativeMethodInfoPtr_IsBadIntrigue_Public_Virtual_Boolean_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility>.NativeClassPtr, 100678948);
			BypassProtocolAbility.NativeMethodInfoPtr_GetBypassProtocolTargets_Private_List_1_Entity_WormMatch_WormPlayer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility>.NativeClassPtr, 100678949);
			BypassProtocolAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility>.NativeClassPtr, 100678950);
		}

		// Token: 0x06003272 RID: 12914 RVA: 0x0012E71C File Offset: 0x0012C91C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231385, XrefRangeEnd = 231389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BypassProtocolAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06003273 RID: 12915 RVA: 0x0012E768 File Offset: 0x0012C968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231389, XrefRangeEnd = 231395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override GameLogBuilder MakeGameLogBuilder(IHasGameLogs hasGameLogs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hasGameLogs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BypassProtocolAbility.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x06003274 RID: 12916 RVA: 0x0012E7C4 File Offset: 0x0012C9C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231395, XrefRangeEnd = 231398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BypassProtocolAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BypassProtocolAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BypassProtocolAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003275 RID: 12917 RVA: 0x0012E810 File Offset: 0x0012CA10
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 215283, RefRangeEnd = 215298, XrefRangeStart = 215283, XrefRangeEnd = 215298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BypassProtocolAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BypassProtocolAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BypassProtocolAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003276 RID: 12918 RVA: 0x0012E880 File Offset: 0x0012CA80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231398, XrefRangeEnd = 231433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BypassProtocolAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x06003277 RID: 12919 RVA: 0x0012E8F0 File Offset: 0x0012CAF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231433, XrefRangeEnd = 231440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BypassProtocolAbility.NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TargetInformation>>(intPtr3) : null;
		}

		// Token: 0x06003278 RID: 12920 RVA: 0x0012E960 File Offset: 0x0012CB60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231440, XrefRangeEnd = 231448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BypassProtocolAbility.NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06003279 RID: 12921 RVA: 0x0012E9E0 File Offset: 0x0012CBE0
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BypassProtocolAbility.NativeMethodInfoPtr_ShowHinting_Public_Virtual_Boolean_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600327A RID: 12922 RVA: 0x0012EA4C File Offset: 0x0012CC4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231448, XrefRangeEnd = 231449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BypassProtocolAbility.NativeMethodInfoPtr_IsBadIntrigue_Public_Virtual_Boolean_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600327B RID: 12923 RVA: 0x0012EAB8 File Offset: 0x0012CCB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 231510, RefRangeEnd = 231512, XrefRangeStart = 231449, XrefRangeEnd = 231510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Entity> GetBypassProtocolTargets(WormMatch match, WormPlayer player, int maxCost)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxCost;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BypassProtocolAbility.NativeMethodInfoPtr_GetBypassProtocolTargets_Private_List_1_Entity_WormMatch_WormPlayer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Entity>>(intPtr3) : null;
		}

		// Token: 0x0600327C RID: 12924 RVA: 0x0012EB28 File Offset: 0x0012CD28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231512, XrefRangeEnd = 231695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WormAIChoice Evaluate(WormAIChoiceContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BypassProtocolAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormAIChoice>(intPtr3) : null;
			}
		}

		// Token: 0x0600327D RID: 12925 RVA: 0x000118BB File Offset: 0x0000FABB
		public BypassProtocolAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x0600327E RID: 12926 RVA: 0x0012EB84 File Offset: 0x0012CD84
		// (set) Token: 0x0600327F RID: 12927 RVA: 0x000118C4 File Offset: 0x0000FAC4
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BypassProtocolAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BypassProtocolAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x06003280 RID: 12928 RVA: 0x0012EBA4 File Offset: 0x0012CDA4
		// (set) Token: 0x06003281 RID: 12929 RVA: 0x000118D6 File Offset: 0x0000FAD6
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BypassProtocolAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BypassProtocolAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040020B8 RID: 8376
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x040020B9 RID: 8377
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x040020BA RID: 8378
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x040020BB RID: 8379
		private static readonly IntPtr NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0;

		// Token: 0x040020BC RID: 8380
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x040020BD RID: 8381
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x040020BE RID: 8382
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0;

		// Token: 0x040020BF RID: 8383
		private static readonly IntPtr NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0;

		// Token: 0x040020C0 RID: 8384
		private static readonly IntPtr NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x040020C1 RID: 8385
		private static readonly IntPtr NativeMethodInfoPtr_ShowHinting_Public_Virtual_Boolean_WormMatch_WormPlayer_0;

		// Token: 0x040020C2 RID: 8386
		private static readonly IntPtr NativeMethodInfoPtr_IsBadIntrigue_Public_Virtual_Boolean_WormMatch_WormPlayer_0;

		// Token: 0x040020C3 RID: 8387
		private static readonly IntPtr NativeMethodInfoPtr_GetBypassProtocolTargets_Private_List_1_Entity_WormMatch_WormPlayer_Int32_0;

		// Token: 0x040020C4 RID: 8388
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0;

		// Token: 0x02000AD7 RID: 2775
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.BypassProtocolAbility+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600AEEE RID: 44782 RVA: 0x002C3F48 File Offset: 0x002C2148
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<BypassProtocolAbility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BypassProtocolAbility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BypassProtocolAbility.__c>.NativeClassPtr);
				BypassProtocolAbility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BypassProtocolAbility.__c>.NativeClassPtr, "<>9");
				BypassProtocolAbility.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BypassProtocolAbility.__c>.NativeClassPtr, "<>9__7_0");
				BypassProtocolAbility.__c.NativeFieldInfoPtr___9__7_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BypassProtocolAbility.__c>.NativeClassPtr, "<>9__7_1");
				BypassProtocolAbility.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BypassProtocolAbility.__c>.NativeClassPtr, "<>9__8_0");
				BypassProtocolAbility.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BypassProtocolAbility.__c>.NativeClassPtr, "<>9__12_0");
				BypassProtocolAbility.__c.NativeFieldInfoPtr___9__12_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BypassProtocolAbility.__c>.NativeClassPtr, "<>9__12_1");
				BypassProtocolAbility.__c.NativeFieldInfoPtr___9__12_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BypassProtocolAbility.__c>.NativeClassPtr, "<>9__12_3");
				BypassProtocolAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility.__c>.NativeClassPtr, 100678953);
				BypassProtocolAbility.__c.NativeMethodInfoPtr__Targets_b__7_0_Internal_EntityID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility.__c>.NativeClassPtr, 100678954);
				BypassProtocolAbility.__c.NativeMethodInfoPtr__Targets_b__7_1_Internal_ReadOnlyAttributes_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility.__c>.NativeClassPtr, 100678955);
				BypassProtocolAbility.__c.NativeMethodInfoPtr__RunImmediateEffects_b__8_0_Internal_GameLogBuilder_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility.__c>.NativeClassPtr, 100678956);
				BypassProtocolAbility.__c.NativeMethodInfoPtr__Evaluate_b__12_0_Internal_Boolean_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility.__c>.NativeClassPtr, 100678957);
				BypassProtocolAbility.__c.NativeMethodInfoPtr__Evaluate_b__12_1_Internal_WormImperiumPlayable_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility.__c>.NativeClassPtr, 100678958);
				BypassProtocolAbility.__c.NativeMethodInfoPtr__Evaluate_b__12_3_Internal_WormImperiumPlayable_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility.__c>.NativeClassPtr, 100678959);
			}

			// Token: 0x0600AEEF RID: 44783 RVA: 0x002C408C File Offset: 0x002C228C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BypassProtocolAbility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BypassProtocolAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AEF0 RID: 44784 RVA: 0x002C40C8 File Offset: 0x002C22C8
			[CallerCount(0)]
			public unsafe EntityID _Targets_b__7_0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BypassProtocolAbility.__c.NativeMethodInfoPtr__Targets_b__7_0_Internal_EntityID_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x0600AEF1 RID: 44785 RVA: 0x002C4118 File Offset: 0x002C2318
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231023, XrefRangeEnd = 231043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReadOnlyAttributes _Targets_b__7_1(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BypassProtocolAbility.__c.NativeMethodInfoPtr__Targets_b__7_1_Internal_ReadOnlyAttributes_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr3) : null;
				}
			}

			// Token: 0x0600AEF2 RID: 44786 RVA: 0x002C4168 File Offset: 0x002C2368
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231043, XrefRangeEnd = 231049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GameLogBuilder _RunImmediateEffects_b__8_0(GameLogBuilder gameLogBuilder)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameLogBuilder);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BypassProtocolAbility.__c.NativeMethodInfoPtr__RunImmediateEffects_b__8_0_Internal_GameLogBuilder_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x0600AEF3 RID: 44787 RVA: 0x002C41B8 File Offset: 0x002C23B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231049, XrefRangeEnd = 231050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Evaluate_b__12_0(TargetInformation _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BypassProtocolAbility.__c.NativeMethodInfoPtr__Evaluate_b__12_0_Internal_Boolean_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600AEF4 RID: 44788 RVA: 0x002C4208 File Offset: 0x002C2408
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WormImperiumPlayable _Evaluate_b__12_1(WormImperiumPlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BypassProtocolAbility.__c.NativeMethodInfoPtr__Evaluate_b__12_1_Internal_WormImperiumPlayable_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr3) : null;
				}
			}

			// Token: 0x0600AEF5 RID: 44789 RVA: 0x002C4258 File Offset: 0x002C2458
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WormImperiumPlayable _Evaluate_b__12_3(WormImperiumPlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BypassProtocolAbility.__c.NativeMethodInfoPtr__Evaluate_b__12_3_Internal_WormImperiumPlayable_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr3) : null;
				}
			}

			// Token: 0x0600AEF6 RID: 44790 RVA: 0x00050023 File Offset: 0x0004E223
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003570 RID: 13680
			// (get) Token: 0x0600AEF7 RID: 44791 RVA: 0x002C42A8 File Offset: 0x002C24A8
			// (set) Token: 0x0600AEF8 RID: 44792 RVA: 0x0005002C File Offset: 0x0004E22C
			public unsafe static BypassProtocolAbility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BypassProtocolAbility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BypassProtocolAbility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BypassProtocolAbility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003571 RID: 13681
			// (get) Token: 0x0600AEF9 RID: 44793 RVA: 0x002C42D0 File Offset: 0x002C24D0
			// (set) Token: 0x0600AEFA RID: 44794 RVA: 0x0005003E File Offset: 0x0004E23E
			public unsafe static Func<Entity, EntityID> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BypassProtocolAbility.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BypassProtocolAbility.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003572 RID: 13682
			// (get) Token: 0x0600AEFB RID: 44795 RVA: 0x002C42F8 File Offset: 0x002C24F8
			// (set) Token: 0x0600AEFC RID: 44796 RVA: 0x00050050 File Offset: 0x0004E250
			public unsafe static Func<Entity, ReadOnlyAttributes> __9__7_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BypassProtocolAbility.__c.NativeFieldInfoPtr___9__7_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, ReadOnlyAttributes>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BypassProtocolAbility.__c.NativeFieldInfoPtr___9__7_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003573 RID: 13683
			// (get) Token: 0x0600AEFD RID: 44797 RVA: 0x002C4320 File Offset: 0x002C2520
			// (set) Token: 0x0600AEFE RID: 44798 RVA: 0x00050062 File Offset: 0x0004E262
			public unsafe static Func<GameLogBuilder, GameLogBuilder> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BypassProtocolAbility.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GameLogBuilder, GameLogBuilder>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BypassProtocolAbility.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003574 RID: 13684
			// (get) Token: 0x0600AEFF RID: 44799 RVA: 0x002C4348 File Offset: 0x002C2548
			// (set) Token: 0x0600AF00 RID: 44800 RVA: 0x00050074 File Offset: 0x0004E274
			public unsafe static Func<TargetInformation, bool> __9__12_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BypassProtocolAbility.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TargetInformation, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BypassProtocolAbility.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003575 RID: 13685
			// (get) Token: 0x0600AF01 RID: 44801 RVA: 0x002C4370 File Offset: 0x002C2570
			// (set) Token: 0x0600AF02 RID: 44802 RVA: 0x00050086 File Offset: 0x0004E286
			public unsafe static Func<WormImperiumPlayable, WormImperiumPlayable> __9__12_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BypassProtocolAbility.__c.NativeFieldInfoPtr___9__12_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormImperiumPlayable, WormImperiumPlayable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BypassProtocolAbility.__c.NativeFieldInfoPtr___9__12_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003576 RID: 13686
			// (get) Token: 0x0600AF03 RID: 44803 RVA: 0x002C4398 File Offset: 0x002C2598
			// (set) Token: 0x0600AF04 RID: 44804 RVA: 0x00050098 File Offset: 0x0004E298
			public unsafe static Func<WormImperiumPlayable, WormImperiumPlayable> __9__12_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BypassProtocolAbility.__c.NativeFieldInfoPtr___9__12_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormImperiumPlayable, WormImperiumPlayable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BypassProtocolAbility.__c.NativeFieldInfoPtr___9__12_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006E6F RID: 28271
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006E70 RID: 28272
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x04006E71 RID: 28273
			private static readonly IntPtr NativeFieldInfoPtr___9__7_1;

			// Token: 0x04006E72 RID: 28274
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04006E73 RID: 28275
			private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x04006E74 RID: 28276
			private static readonly IntPtr NativeFieldInfoPtr___9__12_1;

			// Token: 0x04006E75 RID: 28277
			private static readonly IntPtr NativeFieldInfoPtr___9__12_3;

			// Token: 0x04006E76 RID: 28278
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006E77 RID: 28279
			private static readonly IntPtr NativeMethodInfoPtr__Targets_b__7_0_Internal_EntityID_Entity_0;

			// Token: 0x04006E78 RID: 28280
			private static readonly IntPtr NativeMethodInfoPtr__Targets_b__7_1_Internal_ReadOnlyAttributes_Entity_0;

			// Token: 0x04006E79 RID: 28281
			private static readonly IntPtr NativeMethodInfoPtr__RunImmediateEffects_b__8_0_Internal_GameLogBuilder_GameLogBuilder_0;

			// Token: 0x04006E7A RID: 28282
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__12_0_Internal_Boolean_TargetInformation_0;

			// Token: 0x04006E7B RID: 28283
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__12_1_Internal_WormImperiumPlayable_WormImperiumPlayable_0;

			// Token: 0x04006E7C RID: 28284
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__12_3_Internal_WormImperiumPlayable_WormImperiumPlayable_0;
		}

		// Token: 0x02000AD8 RID: 2776
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.BypassProtocolAbility+<>c__DisplayClass11_0")]
		public new sealed class __c__DisplayClass11_0 : Object
		{
			// Token: 0x0600AF05 RID: 44805 RVA: 0x002C43C0 File Offset: 0x002C25C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<BypassProtocolAbility.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BypassProtocolAbility>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BypassProtocolAbility.__c__DisplayClass11_0>.NativeClassPtr);
				BypassProtocolAbility.__c__DisplayClass11_0.NativeFieldInfoPtr_maxCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BypassProtocolAbility.__c__DisplayClass11_0>.NativeClassPtr, "maxCost");
				BypassProtocolAbility.__c__DisplayClass11_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BypassProtocolAbility.__c__DisplayClass11_0>.NativeClassPtr, "player");
				BypassProtocolAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility.__c__DisplayClass11_0>.NativeClassPtr, 100678960);
				BypassProtocolAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__GetBypassProtocolTargets_b__0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility.__c__DisplayClass11_0>.NativeClassPtr, 100678961);
				BypassProtocolAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__GetBypassProtocolTargets_b__1_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility.__c__DisplayClass11_0>.NativeClassPtr, 100678962);
				BypassProtocolAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__GetBypassProtocolTargets_b__2_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility.__c__DisplayClass11_0>.NativeClassPtr, 100678963);
			}

			// Token: 0x0600AF06 RID: 44806 RVA: 0x002C4464 File Offset: 0x002C2664
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BypassProtocolAbility.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BypassProtocolAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AF07 RID: 44807 RVA: 0x002C44A0 File Offset: 0x002C26A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231050, XrefRangeEnd = 231061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetBypassProtocolTargets_b__0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BypassProtocolAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__GetBypassProtocolTargets_b__0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600AF08 RID: 44808 RVA: 0x002C44F0 File Offset: 0x002C26F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231061, XrefRangeEnd = 231068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetBypassProtocolTargets_b__1(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BypassProtocolAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__GetBypassProtocolTargets_b__1_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600AF09 RID: 44809 RVA: 0x002C4540 File Offset: 0x002C2740
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231068, XrefRangeEnd = 231096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetBypassProtocolTargets_b__2(Entity card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BypassProtocolAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__GetBypassProtocolTargets_b__2_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600AF0A RID: 44810 RVA: 0x000500AA File Offset: 0x0004E2AA
			public __c__DisplayClass11_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003577 RID: 13687
			// (get) Token: 0x0600AF0B RID: 44811 RVA: 0x002C4590 File Offset: 0x002C2790
			// (set) Token: 0x0600AF0C RID: 44812 RVA: 0x000500B3 File Offset: 0x0004E2B3
			public unsafe int maxCost
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility.__c__DisplayClass11_0.NativeFieldInfoPtr_maxCost);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility.__c__DisplayClass11_0.NativeFieldInfoPtr_maxCost)) = value;
				}
			}

			// Token: 0x17003578 RID: 13688
			// (get) Token: 0x0600AF0D RID: 44813 RVA: 0x002C45B8 File Offset: 0x002C27B8
			// (set) Token: 0x0600AF0E RID: 44814 RVA: 0x000500CE File Offset: 0x0004E2CE
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility.__c__DisplayClass11_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility.__c__DisplayClass11_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006E7D RID: 28285
			private static readonly IntPtr NativeFieldInfoPtr_maxCost;

			// Token: 0x04006E7E RID: 28286
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04006E7F RID: 28287
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006E80 RID: 28288
			private static readonly IntPtr NativeMethodInfoPtr__GetBypassProtocolTargets_b__0_Internal_Boolean_Entity_0;

			// Token: 0x04006E81 RID: 28289
			private static readonly IntPtr NativeMethodInfoPtr__GetBypassProtocolTargets_b__1_Internal_Boolean_Entity_0;

			// Token: 0x04006E82 RID: 28290
			private static readonly IntPtr NativeMethodInfoPtr__GetBypassProtocolTargets_b__2_Internal_Boolean_Entity_0;
		}

		// Token: 0x02000AD9 RID: 2777
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.BypassProtocolAbility+<>c__DisplayClass11_1")]
		public sealed class __c__DisplayClass11_1 : Object
		{
			// Token: 0x0600AF0F RID: 44815 RVA: 0x002C45E8 File Offset: 0x002C27E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_1()
			{
				Il2CppClassPointerStore<BypassProtocolAbility.__c__DisplayClass11_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BypassProtocolAbility>.NativeClassPtr, "<>c__DisplayClass11_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BypassProtocolAbility.__c__DisplayClass11_1>.NativeClassPtr);
				BypassProtocolAbility.__c__DisplayClass11_1.NativeFieldInfoPtr_card = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BypassProtocolAbility.__c__DisplayClass11_1>.NativeClassPtr, "card");
				BypassProtocolAbility.__c__DisplayClass11_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility.__c__DisplayClass11_1>.NativeClassPtr, 100678964);
				BypassProtocolAbility.__c__DisplayClass11_1.NativeMethodInfoPtr__GetBypassProtocolTargets_b__3_Internal_Boolean_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility.__c__DisplayClass11_1>.NativeClassPtr, 100678965);
			}

			// Token: 0x0600AF10 RID: 44816 RVA: 0x002C4650 File Offset: 0x002C2850
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BypassProtocolAbility.__c__DisplayClass11_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BypassProtocolAbility.__c__DisplayClass11_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AF11 RID: 44817 RVA: 0x002C468C File Offset: 0x002C288C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231096, XrefRangeEnd = 231100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetBypassProtocolTargets_b__3(Factions faction)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref faction;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BypassProtocolAbility.__c__DisplayClass11_1.NativeMethodInfoPtr__GetBypassProtocolTargets_b__3_Internal_Boolean_Factions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600AF12 RID: 44818 RVA: 0x000500ED File Offset: 0x0004E2ED
			public __c__DisplayClass11_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003579 RID: 13689
			// (get) Token: 0x0600AF13 RID: 44819 RVA: 0x002C46D8 File Offset: 0x002C28D8
			// (set) Token: 0x0600AF14 RID: 44820 RVA: 0x000500F6 File Offset: 0x0004E2F6
			public unsafe Entity card
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility.__c__DisplayClass11_1.NativeFieldInfoPtr_card);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility.__c__DisplayClass11_1.NativeFieldInfoPtr_card), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006E83 RID: 28291
			private static readonly IntPtr NativeFieldInfoPtr_card;

			// Token: 0x04006E84 RID: 28292
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006E85 RID: 28293
			private static readonly IntPtr NativeMethodInfoPtr__GetBypassProtocolTargets_b__3_Internal_Boolean_Factions_0;
		}

		// Token: 0x02000ADA RID: 2778
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.BypassProtocolAbility+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Object
		{
			// Token: 0x0600AF15 RID: 44821 RVA: 0x002C4708 File Offset: 0x002C2908
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<BypassProtocolAbility.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BypassProtocolAbility>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BypassProtocolAbility.__c__DisplayClass12_0>.NativeClassPtr);
				BypassProtocolAbility.__c__DisplayClass12_0.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BypassProtocolAbility.__c__DisplayClass12_0>.NativeClassPtr, "context");
				BypassProtocolAbility.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility.__c__DisplayClass12_0>.NativeClassPtr, 100678966);
				BypassProtocolAbility.__c__DisplayClass12_0.NativeMethodInfoPtr__Evaluate_b__2_Internal_AIValueSummer_1_Double_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility.__c__DisplayClass12_0>.NativeClassPtr, 100678967);
				BypassProtocolAbility.__c__DisplayClass12_0.NativeMethodInfoPtr__Evaluate_b__4_Internal_AIValueSummer_1_Double_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility.__c__DisplayClass12_0>.NativeClassPtr, 100678968);
				BypassProtocolAbility.__c__DisplayClass12_0.NativeMethodInfoPtr__Evaluate_b__5_Internal_Double_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility.__c__DisplayClass12_0>.NativeClassPtr, 100678969);
				BypassProtocolAbility.__c__DisplayClass12_0.NativeMethodInfoPtr__Evaluate_b__6_Internal_Double_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility.__c__DisplayClass12_0>.NativeClassPtr, 100678970);
			}

			// Token: 0x0600AF16 RID: 44822 RVA: 0x002C47AC File Offset: 0x002C29AC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BypassProtocolAbility.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BypassProtocolAbility.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AF17 RID: 44823 RVA: 0x002C47E8 File Offset: 0x002C29E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231100, XrefRangeEnd = 231102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AIValueSummer<double> _Evaluate_b__2(WormImperiumPlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BypassProtocolAbility.__c__DisplayClass12_0.NativeMethodInfoPtr__Evaluate_b__2_Internal_AIValueSummer_1_Double_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
				}
			}

			// Token: 0x0600AF18 RID: 44824 RVA: 0x002C4838 File Offset: 0x002C2A38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AIValueSummer<double> _Evaluate_b__4(WormImperiumPlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BypassProtocolAbility.__c__DisplayClass12_0.NativeMethodInfoPtr__Evaluate_b__4_Internal_AIValueSummer_1_Double_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
				}
			}

			// Token: 0x0600AF19 RID: 44825 RVA: 0x002C4888 File Offset: 0x002C2A88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231102, XrefRangeEnd = 231107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double _Evaluate_b__5(WormImperiumPlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BypassProtocolAbility.__c__DisplayClass12_0.NativeMethodInfoPtr__Evaluate_b__5_Internal_Double_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600AF1A RID: 44826 RVA: 0x002C48D8 File Offset: 0x002C2AD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231107, XrefRangeEnd = 231112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double _Evaluate_b__6(WormImperiumPlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BypassProtocolAbility.__c__DisplayClass12_0.NativeMethodInfoPtr__Evaluate_b__6_Internal_Double_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600AF1B RID: 44827 RVA: 0x00050115 File Offset: 0x0004E315
			public __c__DisplayClass12_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700357A RID: 13690
			// (get) Token: 0x0600AF1C RID: 44828 RVA: 0x002C4928 File Offset: 0x002C2B28
			// (set) Token: 0x0600AF1D RID: 44829 RVA: 0x0005011E File Offset: 0x0004E31E
			public unsafe WormAIChoiceContext context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility.__c__DisplayClass12_0.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAIChoiceContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility.__c__DisplayClass12_0.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006E86 RID: 28294
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04006E87 RID: 28295
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006E88 RID: 28296
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__2_Internal_AIValueSummer_1_Double_WormImperiumPlayable_0;

			// Token: 0x04006E89 RID: 28297
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__4_Internal_AIValueSummer_1_Double_WormImperiumPlayable_0;

			// Token: 0x04006E8A RID: 28298
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__5_Internal_Double_WormImperiumPlayable_0;

			// Token: 0x04006E8B RID: 28299
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__6_Internal_Double_WormImperiumPlayable_0;
		}

		// Token: 0x02000ADB RID: 2779
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.BypassProtocolAbility+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x0600AF1E RID: 44830 RVA: 0x002C4958 File Offset: 0x002C2B58
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<BypassProtocolAbility.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BypassProtocolAbility>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BypassProtocolAbility.__c__DisplayClass8_0>.NativeClassPtr);
				BypassProtocolAbility.__c__DisplayClass8_0.NativeFieldInfoPtr_wip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BypassProtocolAbility.__c__DisplayClass8_0>.NativeClassPtr, "wip");
				BypassProtocolAbility.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility.__c__DisplayClass8_0>.NativeClassPtr, 100678971);
				BypassProtocolAbility.__c__DisplayClass8_0.NativeMethodInfoPtr__RunImmediateEffects_b__1_Internal_GameLogBuilder_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility.__c__DisplayClass8_0>.NativeClassPtr, 100678972);
			}

			// Token: 0x0600AF1F RID: 44831 RVA: 0x002C49C0 File Offset: 0x002C2BC0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BypassProtocolAbility.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BypassProtocolAbility.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AF20 RID: 44832 RVA: 0x002C49FC File Offset: 0x002C2BFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231112, XrefRangeEnd = 231221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GameLogBuilder _RunImmediateEffects_b__1(GameLogBuilder _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BypassProtocolAbility.__c__DisplayClass8_0.NativeMethodInfoPtr__RunImmediateEffects_b__1_Internal_GameLogBuilder_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x0600AF21 RID: 44833 RVA: 0x0005013D File Offset: 0x0004E33D
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700357B RID: 13691
			// (get) Token: 0x0600AF22 RID: 44834 RVA: 0x002C4A4C File Offset: 0x002C2C4C
			// (set) Token: 0x0600AF23 RID: 44835 RVA: 0x00050146 File Offset: 0x0004E346
			public unsafe WormImperiumPlayable wip
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility.__c__DisplayClass8_0.NativeFieldInfoPtr_wip);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility.__c__DisplayClass8_0.NativeFieldInfoPtr_wip), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006E8C RID: 28300
			private static readonly IntPtr NativeFieldInfoPtr_wip;

			// Token: 0x04006E8D RID: 28301
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006E8E RID: 28302
			private static readonly IntPtr NativeMethodInfoPtr__RunImmediateEffects_b__1_Internal_GameLogBuilder_GameLogBuilder_0;
		}

		// Token: 0x02000ADC RID: 2780
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.BypassProtocolAbility+<RunImmediateEffects>d__8")]
		public sealed class _RunImmediateEffects_d__8 : Object
		{
			// Token: 0x0600AF24 RID: 44836 RVA: 0x002C4A7C File Offset: 0x002C2C7C
			// Note: this type is marked as 'beforefieldinit'.
			static _RunImmediateEffects_d__8()
			{
				Il2CppClassPointerStore<BypassProtocolAbility._RunImmediateEffects_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BypassProtocolAbility>.NativeClassPtr, "<RunImmediateEffects>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BypassProtocolAbility._RunImmediateEffects_d__8>.NativeClassPtr);
				BypassProtocolAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BypassProtocolAbility._RunImmediateEffects_d__8>.NativeClassPtr, "<>1__state");
				BypassProtocolAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BypassProtocolAbility._RunImmediateEffects_d__8>.NativeClassPtr, "<>2__current");
				BypassProtocolAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BypassProtocolAbility._RunImmediateEffects_d__8>.NativeClassPtr, "<>l__initialThreadId");
				BypassProtocolAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BypassProtocolAbility._RunImmediateEffects_d__8>.NativeClassPtr, "activeAbility");
				BypassProtocolAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BypassProtocolAbility._RunImmediateEffects_d__8>.NativeClassPtr, "<>3__activeAbility");
				BypassProtocolAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BypassProtocolAbility._RunImmediateEffects_d__8>.NativeClassPtr, "context");
				BypassProtocolAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BypassProtocolAbility._RunImmediateEffects_d__8>.NativeClassPtr, "<>3__context");
				BypassProtocolAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BypassProtocolAbility._RunImmediateEffects_d__8>.NativeClassPtr, "match");
				BypassProtocolAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BypassProtocolAbility._RunImmediateEffects_d__8>.NativeClassPtr, "<>3__match");
				BypassProtocolAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BypassProtocolAbility._RunImmediateEffects_d__8>.NativeClassPtr, "<>8__1");
				BypassProtocolAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BypassProtocolAbility._RunImmediateEffects_d__8>.NativeClassPtr, "<player>5__2");
				BypassProtocolAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr__trq_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BypassProtocolAbility._RunImmediateEffects_d__8>.NativeClassPtr, "<trq>5__3");
				BypassProtocolAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr__toArea_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BypassProtocolAbility._RunImmediateEffects_d__8>.NativeClassPtr, "<toArea>5__4");
				BypassProtocolAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility._RunImmediateEffects_d__8>.NativeClassPtr, 100678973);
				BypassProtocolAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility._RunImmediateEffects_d__8>.NativeClassPtr, 100678974);
				BypassProtocolAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility._RunImmediateEffects_d__8>.NativeClassPtr, 100678975);
				BypassProtocolAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility._RunImmediateEffects_d__8>.NativeClassPtr, 100678976);
				BypassProtocolAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility._RunImmediateEffects_d__8>.NativeClassPtr, 100678977);
				BypassProtocolAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility._RunImmediateEffects_d__8>.NativeClassPtr, 100678978);
				BypassProtocolAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility._RunImmediateEffects_d__8>.NativeClassPtr, 100678979);
				BypassProtocolAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility._RunImmediateEffects_d__8>.NativeClassPtr, 100678980);
			}

			// Token: 0x0600AF25 RID: 44837 RVA: 0x002C4C4C File Offset: 0x002C2E4C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RunImmediateEffects_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BypassProtocolAbility._RunImmediateEffects_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BypassProtocolAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600AF26 RID: 44838 RVA: 0x002C4C94 File Offset: 0x002C2E94
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BypassProtocolAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AF27 RID: 44839 RVA: 0x002C4CC8 File Offset: 0x002C2EC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231221, XrefRangeEnd = 231256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BypassProtocolAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003589 RID: 13705
			// (get) Token: 0x0600AF28 RID: 44840 RVA: 0x002C4D04 File Offset: 0x002C2F04
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BypassProtocolAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600AF29 RID: 44841 RVA: 0x002C4D44 File Offset: 0x002C2F44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231256, XrefRangeEnd = 231261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BypassProtocolAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700358A RID: 13706
			// (get) Token: 0x0600AF2A RID: 44842 RVA: 0x002C4D78 File Offset: 0x002C2F78
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BypassProtocolAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600AF2B RID: 44843 RVA: 0x002C4DB8 File Offset: 0x002C2FB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231261, XrefRangeEnd = 231271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BypassProtocolAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600AF2C RID: 44844 RVA: 0x002C4DF8 File Offset: 0x002C2FF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BypassProtocolAbility._RunImmediateEffects_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600AF2D RID: 44845 RVA: 0x00050165 File Offset: 0x0004E365
			public _RunImmediateEffects_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700357C RID: 13692
			// (get) Token: 0x0600AF2E RID: 44846 RVA: 0x002C4E38 File Offset: 0x002C3038
			// (set) Token: 0x0600AF2F RID: 44847 RVA: 0x0005016E File Offset: 0x0004E36E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700357D RID: 13693
			// (get) Token: 0x0600AF30 RID: 44848 RVA: 0x002C4E60 File Offset: 0x002C3060
			// (set) Token: 0x0600AF31 RID: 44849 RVA: 0x00050189 File Offset: 0x0004E389
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700357E RID: 13694
			// (get) Token: 0x0600AF32 RID: 44850 RVA: 0x002C4E90 File Offset: 0x002C3090
			// (set) Token: 0x0600AF33 RID: 44851 RVA: 0x000501A8 File Offset: 0x0004E3A8
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700357F RID: 13695
			// (get) Token: 0x0600AF34 RID: 44852 RVA: 0x002C4EB8 File Offset: 0x002C30B8
			// (set) Token: 0x0600AF35 RID: 44853 RVA: 0x000501C3 File Offset: 0x0004E3C3
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003580 RID: 13696
			// (get) Token: 0x0600AF36 RID: 44854 RVA: 0x002C4EE8 File Offset: 0x002C30E8
			// (set) Token: 0x0600AF37 RID: 44855 RVA: 0x000501E2 File Offset: 0x0004E3E2
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003581 RID: 13697
			// (get) Token: 0x0600AF38 RID: 44856 RVA: 0x002C4F18 File Offset: 0x002C3118
			// (set) Token: 0x0600AF39 RID: 44857 RVA: 0x00050201 File Offset: 0x0004E401
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003582 RID: 13698
			// (get) Token: 0x0600AF3A RID: 44858 RVA: 0x002C4F48 File Offset: 0x002C3148
			// (set) Token: 0x0600AF3B RID: 44859 RVA: 0x00050220 File Offset: 0x0004E420
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003583 RID: 13699
			// (get) Token: 0x0600AF3C RID: 44860 RVA: 0x002C4F78 File Offset: 0x002C3178
			// (set) Token: 0x0600AF3D RID: 44861 RVA: 0x0005023F File Offset: 0x0004E43F
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003584 RID: 13700
			// (get) Token: 0x0600AF3E RID: 44862 RVA: 0x002C4FA8 File Offset: 0x002C31A8
			// (set) Token: 0x0600AF3F RID: 44863 RVA: 0x0005025E File Offset: 0x0004E45E
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003585 RID: 13701
			// (get) Token: 0x0600AF40 RID: 44864 RVA: 0x002C4FD8 File Offset: 0x002C31D8
			// (set) Token: 0x0600AF41 RID: 44865 RVA: 0x0005027D File Offset: 0x0004E47D
			public unsafe BypassProtocolAbility.__c__DisplayClass8_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BypassProtocolAbility.__c__DisplayClass8_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003586 RID: 13702
			// (get) Token: 0x0600AF42 RID: 44866 RVA: 0x002C5008 File Offset: 0x002C3208
			// (set) Token: 0x0600AF43 RID: 44867 RVA: 0x0005029C File Offset: 0x0004E49C
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003587 RID: 13703
			// (get) Token: 0x0600AF44 RID: 44868 RVA: 0x002C5038 File Offset: 0x002C3238
			// (set) Token: 0x0600AF45 RID: 44869 RVA: 0x000502BB File Offset: 0x0004E4BB
			public unsafe TargetResponseQueue _trq_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr__trq_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TargetResponseQueue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr__trq_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003588 RID: 13704
			// (get) Token: 0x0600AF46 RID: 44870 RVA: 0x002C5068 File Offset: 0x002C3268
			// (set) Token: 0x0600AF47 RID: 44871 RVA: 0x000502DA File Offset: 0x0004E4DA
			public unsafe CardToAreas _toArea_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr__toArea_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility._RunImmediateEffects_d__8.NativeFieldInfoPtr__toArea_5__4)) = value;
				}
			}

			// Token: 0x04006E8F RID: 28303
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006E90 RID: 28304
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006E91 RID: 28305
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04006E92 RID: 28306
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04006E93 RID: 28307
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x04006E94 RID: 28308
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04006E95 RID: 28309
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x04006E96 RID: 28310
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04006E97 RID: 28311
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04006E98 RID: 28312
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04006E99 RID: 28313
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x04006E9A RID: 28314
			private static readonly IntPtr NativeFieldInfoPtr__trq_5__3;

			// Token: 0x04006E9B RID: 28315
			private static readonly IntPtr NativeFieldInfoPtr__toArea_5__4;

			// Token: 0x04006E9C RID: 28316
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006E9D RID: 28317
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006E9E RID: 28318
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006E9F RID: 28319
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04006EA0 RID: 28320
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006EA1 RID: 28321
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006EA2 RID: 28322
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04006EA3 RID: 28323
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000ADD RID: 2781
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.BaseSet.BypassProtocolAbility+<Targets>d__7")]
		public sealed class _Targets_d__7 : Object
		{
			// Token: 0x0600AF48 RID: 44872 RVA: 0x002C5090 File Offset: 0x002C3290
			// Note: this type is marked as 'beforefieldinit'.
			static _Targets_d__7()
			{
				Il2CppClassPointerStore<BypassProtocolAbility._Targets_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BypassProtocolAbility>.NativeClassPtr, "<Targets>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BypassProtocolAbility._Targets_d__7>.NativeClassPtr);
				BypassProtocolAbility._Targets_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BypassProtocolAbility._Targets_d__7>.NativeClassPtr, "<>1__state");
				BypassProtocolAbility._Targets_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BypassProtocolAbility._Targets_d__7>.NativeClassPtr, "<>2__current");
				BypassProtocolAbility._Targets_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BypassProtocolAbility._Targets_d__7>.NativeClassPtr, "<>l__initialThreadId");
				BypassProtocolAbility._Targets_d__7.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BypassProtocolAbility._Targets_d__7>.NativeClassPtr, "context");
				BypassProtocolAbility._Targets_d__7.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BypassProtocolAbility._Targets_d__7>.NativeClassPtr, "<>3__context");
				BypassProtocolAbility._Targets_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BypassProtocolAbility._Targets_d__7>.NativeClassPtr, "<>4__this");
				BypassProtocolAbility._Targets_d__7.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BypassProtocolAbility._Targets_d__7>.NativeClassPtr, "<player>5__2");
				BypassProtocolAbility._Targets_d__7.NativeFieldInfoPtr__wp_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BypassProtocolAbility._Targets_d__7>.NativeClassPtr, "<wp>5__3");
				BypassProtocolAbility._Targets_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility._Targets_d__7>.NativeClassPtr, 100678981);
				BypassProtocolAbility._Targets_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility._Targets_d__7>.NativeClassPtr, 100678982);
				BypassProtocolAbility._Targets_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility._Targets_d__7>.NativeClassPtr, 100678983);
				BypassProtocolAbility._Targets_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility._Targets_d__7>.NativeClassPtr, 100678984);
				BypassProtocolAbility._Targets_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility._Targets_d__7>.NativeClassPtr, 100678985);
				BypassProtocolAbility._Targets_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility._Targets_d__7>.NativeClassPtr, 100678986);
				BypassProtocolAbility._Targets_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility._Targets_d__7>.NativeClassPtr, 100678987);
				BypassProtocolAbility._Targets_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassProtocolAbility._Targets_d__7>.NativeClassPtr, 100678988);
			}

			// Token: 0x0600AF49 RID: 44873 RVA: 0x002C51FC File Offset: 0x002C33FC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Targets_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BypassProtocolAbility._Targets_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BypassProtocolAbility._Targets_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600AF4A RID: 44874 RVA: 0x002C5244 File Offset: 0x002C3444
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BypassProtocolAbility._Targets_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600AF4B RID: 44875 RVA: 0x002C5278 File Offset: 0x002C3478
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231271, XrefRangeEnd = 231371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BypassProtocolAbility._Targets_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003593 RID: 13715
			// (get) Token: 0x0600AF4C RID: 44876 RVA: 0x002C52B4 File Offset: 0x002C34B4
			public unsafe TargetInformation System.Collections.Generic.IEnumerator<Networking.selection.targetinformation.TargetInformation>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BypassProtocolAbility._Targets_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetInformation>(intPtr3) : null;
				}
			}

			// Token: 0x0600AF4D RID: 44877 RVA: 0x002C52F4 File Offset: 0x002C34F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231371, XrefRangeEnd = 231376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BypassProtocolAbility._Targets_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003594 RID: 13716
			// (get) Token: 0x0600AF4E RID: 44878 RVA: 0x002C5328 File Offset: 0x002C3528
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BypassProtocolAbility._Targets_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600AF4F RID: 44879 RVA: 0x002C5368 File Offset: 0x002C3568
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231376, XrefRangeEnd = 231385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TargetInformation> System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BypassProtocolAbility._Targets_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TargetInformation>>(intPtr3) : null;
			}

			// Token: 0x0600AF50 RID: 44880 RVA: 0x002C53A8 File Offset: 0x002C35A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BypassProtocolAbility._Targets_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600AF51 RID: 44881 RVA: 0x000502F5 File Offset: 0x0004E4F5
			public _Targets_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700358B RID: 13707
			// (get) Token: 0x0600AF52 RID: 44882 RVA: 0x002C53E8 File Offset: 0x002C35E8
			// (set) Token: 0x0600AF53 RID: 44883 RVA: 0x000502FE File Offset: 0x0004E4FE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility._Targets_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility._Targets_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700358C RID: 13708
			// (get) Token: 0x0600AF54 RID: 44884 RVA: 0x002C5410 File Offset: 0x002C3610
			// (set) Token: 0x0600AF55 RID: 44885 RVA: 0x00050319 File Offset: 0x0004E519
			public unsafe TargetInformation __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility._Targets_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TargetInformation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility._Targets_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700358D RID: 13709
			// (get) Token: 0x0600AF56 RID: 44886 RVA: 0x002C5440 File Offset: 0x002C3640
			// (set) Token: 0x0600AF57 RID: 44887 RVA: 0x00050338 File Offset: 0x0004E538
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility._Targets_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility._Targets_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700358E RID: 13710
			// (get) Token: 0x0600AF58 RID: 44888 RVA: 0x002C5468 File Offset: 0x002C3668
			// (set) Token: 0x0600AF59 RID: 44889 RVA: 0x00050353 File Offset: 0x0004E553
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility._Targets_d__7.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility._Targets_d__7.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700358F RID: 13711
			// (get) Token: 0x0600AF5A RID: 44890 RVA: 0x002C5498 File Offset: 0x002C3698
			// (set) Token: 0x0600AF5B RID: 44891 RVA: 0x00050372 File Offset: 0x0004E572
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility._Targets_d__7.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility._Targets_d__7.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003590 RID: 13712
			// (get) Token: 0x0600AF5C RID: 44892 RVA: 0x002C54C8 File Offset: 0x002C36C8
			// (set) Token: 0x0600AF5D RID: 44893 RVA: 0x00050391 File Offset: 0x0004E591
			public unsafe BypassProtocolAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility._Targets_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BypassProtocolAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility._Targets_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003591 RID: 13713
			// (get) Token: 0x0600AF5E RID: 44894 RVA: 0x002C54F8 File Offset: 0x002C36F8
			// (set) Token: 0x0600AF5F RID: 44895 RVA: 0x000503B0 File Offset: 0x0004E5B0
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility._Targets_d__7.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility._Targets_d__7.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003592 RID: 13714
			// (get) Token: 0x0600AF60 RID: 44896 RVA: 0x002C5528 File Offset: 0x002C3728
			// (set) Token: 0x0600AF61 RID: 44897 RVA: 0x000503CF File Offset: 0x0004E5CF
			public unsafe WormPlaymat _wp_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility._Targets_d__7.NativeFieldInfoPtr__wp_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlaymat>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BypassProtocolAbility._Targets_d__7.NativeFieldInfoPtr__wp_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006EA4 RID: 28324
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006EA5 RID: 28325
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006EA6 RID: 28326
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04006EA7 RID: 28327
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04006EA8 RID: 28328
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x04006EA9 RID: 28329
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006EAA RID: 28330
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x04006EAB RID: 28331
			private static readonly IntPtr NativeFieldInfoPtr__wp_5__3;

			// Token: 0x04006EAC RID: 28332
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006EAD RID: 28333
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006EAE RID: 28334
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006EAF RID: 28335
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0;

			// Token: 0x04006EB0 RID: 28336
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006EB1 RID: 28337
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006EB2 RID: 28338
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0;

			// Token: 0x04006EB3 RID: 28339
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
