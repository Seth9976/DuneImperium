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
using worm.canis.abilities.ConflictAbilities;
using worm.canis.ai;
using worm.canis.ai.choices;
using worm.canis.entities;

namespace worm.canis.abilities.TriggeredAbilities.Challenge.Immortality
{
	// Token: 0x020003AE RID: 942
	public class ShowOfStrengthWinConflict : ConflictAbility
	{
		// Token: 0x06002760 RID: 10080 RVA: 0x000F855C File Offset: 0x000F675C
		// Note: this type is marked as 'beforefieldinit'.
		static ShowOfStrengthWinConflict()
		{
			Il2CppClassPointerStore<ShowOfStrengthWinConflict>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.TriggeredAbilities.Challenge.Immortality", "ShowOfStrengthWinConflict");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowOfStrengthWinConflict>.NativeClassPtr);
			ShowOfStrengthWinConflict.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowOfStrengthWinConflict>.NativeClassPtr, "AbilityName");
			ShowOfStrengthWinConflict.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowOfStrengthWinConflict>.NativeClassPtr, "AbilityID");
			ShowOfStrengthWinConflict.NativeFieldInfoPtr_cost1Cards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowOfStrengthWinConflict>.NativeClassPtr, "cost1Cards");
			ShowOfStrengthWinConflict.NativeFieldInfoPtr_cost2Cards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowOfStrengthWinConflict>.NativeClassPtr, "cost2Cards");
			ShowOfStrengthWinConflict.NativeFieldInfoPtr_cost3Cards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowOfStrengthWinConflict>.NativeClassPtr, "cost3Cards");
			ShowOfStrengthWinConflict.NativeFieldInfoPtr_cost4Cards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowOfStrengthWinConflict>.NativeClassPtr, "cost4Cards");
			ShowOfStrengthWinConflict.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowOfStrengthWinConflict>.NativeClassPtr, 100674602);
			ShowOfStrengthWinConflict.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowOfStrengthWinConflict>.NativeClassPtr, 100674603);
			ShowOfStrengthWinConflict.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowOfStrengthWinConflict>.NativeClassPtr, 100674604);
			ShowOfStrengthWinConflict.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowOfStrengthWinConflict>.NativeClassPtr, 100674605);
			ShowOfStrengthWinConflict.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowOfStrengthWinConflict>.NativeClassPtr, 100674606);
			ShowOfStrengthWinConflict.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowOfStrengthWinConflict>.NativeClassPtr, 100674607);
			ShowOfStrengthWinConflict.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowOfStrengthWinConflict>.NativeClassPtr, 100674608);
		}

		// Token: 0x06002761 RID: 10081 RVA: 0x000F8690 File Offset: 0x000F6890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196264, XrefRangeEnd = 196268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShowOfStrengthWinConflict.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06002762 RID: 10082 RVA: 0x000F86DC File Offset: 0x000F68DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196268, XrefRangeEnd = 196281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShowOfStrengthWinConflict(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowOfStrengthWinConflict>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowOfStrengthWinConflict.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002763 RID: 10083 RVA: 0x000F8728 File Offset: 0x000F6928
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 24983, RefRangeEnd = 24988, XrefRangeStart = 24983, XrefRangeEnd = 24988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShowOfStrengthWinConflict(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowOfStrengthWinConflict>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowOfStrengthWinConflict.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002764 RID: 10084 RVA: 0x000F8798 File Offset: 0x000F6998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196281, XrefRangeEnd = 196285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShowOfStrengthWinConflict.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x06002765 RID: 10085 RVA: 0x000F8808 File Offset: 0x000F6A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196285, XrefRangeEnd = 196293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShowOfStrengthWinConflict.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06002766 RID: 10086 RVA: 0x000F8888 File Offset: 0x000F6A88
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShowOfStrengthWinConflict.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002767 RID: 10087 RVA: 0x000F8904 File Offset: 0x000F6B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196293, XrefRangeEnd = 196304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WormAIChoice Evaluate(WormAIChoiceContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShowOfStrengthWinConflict.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormAIChoice>(intPtr3) : null;
			}
		}

		// Token: 0x06002768 RID: 10088 RVA: 0x0000EF52 File Offset: 0x0000D152
		public ShowOfStrengthWinConflict(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x06002769 RID: 10089 RVA: 0x000F8960 File Offset: 0x000F6B60
		// (set) Token: 0x0600276A RID: 10090 RVA: 0x0000EF5B File Offset: 0x0000D15B
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShowOfStrengthWinConflict.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShowOfStrengthWinConflict.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x0600276B RID: 10091 RVA: 0x000F8980 File Offset: 0x000F6B80
		// (set) Token: 0x0600276C RID: 10092 RVA: 0x0000EF6D File Offset: 0x0000D16D
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShowOfStrengthWinConflict.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShowOfStrengthWinConflict.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x0600276D RID: 10093 RVA: 0x000F89A8 File Offset: 0x000F6BA8
		// (set) Token: 0x0600276E RID: 10094 RVA: 0x0000EF7F File Offset: 0x0000D17F
		public unsafe static List<ArchetypeID> cost1Cards
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShowOfStrengthWinConflict.NativeFieldInfoPtr_cost1Cards, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShowOfStrengthWinConflict.NativeFieldInfoPtr_cost1Cards, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x0600276F RID: 10095 RVA: 0x000F89D0 File Offset: 0x000F6BD0
		// (set) Token: 0x06002770 RID: 10096 RVA: 0x0000EF91 File Offset: 0x0000D191
		public unsafe static List<ArchetypeID> cost2Cards
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShowOfStrengthWinConflict.NativeFieldInfoPtr_cost2Cards, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShowOfStrengthWinConflict.NativeFieldInfoPtr_cost2Cards, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x06002771 RID: 10097 RVA: 0x000F89F8 File Offset: 0x000F6BF8
		// (set) Token: 0x06002772 RID: 10098 RVA: 0x0000EFA3 File Offset: 0x0000D1A3
		public unsafe static List<ArchetypeID> cost3Cards
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShowOfStrengthWinConflict.NativeFieldInfoPtr_cost3Cards, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShowOfStrengthWinConflict.NativeFieldInfoPtr_cost3Cards, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x06002773 RID: 10099 RVA: 0x000F8A20 File Offset: 0x000F6C20
		// (set) Token: 0x06002774 RID: 10100 RVA: 0x0000EFB5 File Offset: 0x0000D1B5
		public unsafe static List<ArchetypeID> cost4Cards
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShowOfStrengthWinConflict.NativeFieldInfoPtr_cost4Cards, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShowOfStrengthWinConflict.NativeFieldInfoPtr_cost4Cards, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001928 RID: 6440
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04001929 RID: 6441
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x0400192A RID: 6442
		private static readonly IntPtr NativeFieldInfoPtr_cost1Cards;

		// Token: 0x0400192B RID: 6443
		private static readonly IntPtr NativeFieldInfoPtr_cost2Cards;

		// Token: 0x0400192C RID: 6444
		private static readonly IntPtr NativeFieldInfoPtr_cost3Cards;

		// Token: 0x0400192D RID: 6445
		private static readonly IntPtr NativeFieldInfoPtr_cost4Cards;

		// Token: 0x0400192E RID: 6446
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x0400192F RID: 6447
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04001930 RID: 6448
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04001931 RID: 6449
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0;

		// Token: 0x04001932 RID: 6450
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x04001933 RID: 6451
		private static readonly IntPtr NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0;

		// Token: 0x04001934 RID: 6452
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0;

		// Token: 0x0200093B RID: 2363
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Challenge.Immortality.ShowOfStrengthWinConflict+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06008D7D RID: 36221 RVA: 0x00262378 File Offset: 0x00260578
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ShowOfStrengthWinConflict.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowOfStrengthWinConflict>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowOfStrengthWinConflict.__c>.NativeClassPtr);
				ShowOfStrengthWinConflict.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowOfStrengthWinConflict.__c>.NativeClassPtr, "<>9");
				ShowOfStrengthWinConflict.__c.NativeFieldInfoPtr___9__10_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowOfStrengthWinConflict.__c>.NativeClassPtr, "<>9__10_1");
				ShowOfStrengthWinConflict.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowOfStrengthWinConflict.__c>.NativeClassPtr, 100674611);
				ShowOfStrengthWinConflict.__c.NativeMethodInfoPtr__BeginExecution_b__10_1_Internal_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowOfStrengthWinConflict.__c>.NativeClassPtr, 100674612);
			}

			// Token: 0x06008D7E RID: 36222 RVA: 0x002623F4 File Offset: 0x002605F4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowOfStrengthWinConflict.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowOfStrengthWinConflict.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008D7F RID: 36223 RVA: 0x00262430 File Offset: 0x00260630
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _BeginExecution_b__10_1(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowOfStrengthWinConflict.__c.NativeMethodInfoPtr__BeginExecution_b__10_1_Internal_Int32_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06008D80 RID: 36224 RVA: 0x0003CB85 File Offset: 0x0003AD85
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17002948 RID: 10568
			// (get) Token: 0x06008D81 RID: 36225 RVA: 0x00262480 File Offset: 0x00260680
			// (set) Token: 0x06008D82 RID: 36226 RVA: 0x0003CB8E File Offset: 0x0003AD8E
			public unsafe static ShowOfStrengthWinConflict.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShowOfStrengthWinConflict.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShowOfStrengthWinConflict.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShowOfStrengthWinConflict.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002949 RID: 10569
			// (get) Token: 0x06008D83 RID: 36227 RVA: 0x002624A8 File Offset: 0x002606A8
			// (set) Token: 0x06008D84 RID: 36228 RVA: 0x0003CBA0 File Offset: 0x0003ADA0
			public unsafe static Func<WormPlayer, int> __9__10_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShowOfStrengthWinConflict.__c.NativeFieldInfoPtr___9__10_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShowOfStrengthWinConflict.__c.NativeFieldInfoPtr___9__10_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005A56 RID: 23126
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005A57 RID: 23127
			private static readonly IntPtr NativeFieldInfoPtr___9__10_1;

			// Token: 0x04005A58 RID: 23128
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005A59 RID: 23129
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__10_1_Internal_Int32_WormPlayer_0;
		}

		// Token: 0x0200093C RID: 2364
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Challenge.Immortality.ShowOfStrengthWinConflict+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Object
		{
			// Token: 0x06008D85 RID: 36229 RVA: 0x002624D0 File Offset: 0x002606D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<ShowOfStrengthWinConflict.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowOfStrengthWinConflict>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowOfStrengthWinConflict.__c__DisplayClass10_0>.NativeClassPtr);
				ShowOfStrengthWinConflict.__c__DisplayClass10_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowOfStrengthWinConflict.__c__DisplayClass10_0>.NativeClassPtr, "player");
				ShowOfStrengthWinConflict.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowOfStrengthWinConflict.__c__DisplayClass10_0>.NativeClassPtr, 100674613);
				ShowOfStrengthWinConflict.__c__DisplayClass10_0.NativeMethodInfoPtr__BeginExecution_b__0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowOfStrengthWinConflict.__c__DisplayClass10_0>.NativeClassPtr, 100674614);
			}

			// Token: 0x06008D86 RID: 36230 RVA: 0x00262538 File Offset: 0x00260738
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowOfStrengthWinConflict.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowOfStrengthWinConflict.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008D87 RID: 36231 RVA: 0x00262574 File Offset: 0x00260774
			[CallerCount(0)]
			public unsafe bool _BeginExecution_b__0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowOfStrengthWinConflict.__c__DisplayClass10_0.NativeMethodInfoPtr__BeginExecution_b__0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06008D88 RID: 36232 RVA: 0x0003CBB2 File Offset: 0x0003ADB2
			public __c__DisplayClass10_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700294A RID: 10570
			// (get) Token: 0x06008D89 RID: 36233 RVA: 0x002625C4 File Offset: 0x002607C4
			// (set) Token: 0x06008D8A RID: 36234 RVA: 0x0003CBBB File Offset: 0x0003ADBB
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowOfStrengthWinConflict.__c__DisplayClass10_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowOfStrengthWinConflict.__c__DisplayClass10_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005A5A RID: 23130
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04005A5B RID: 23131
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005A5C RID: 23132
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__0_Internal_Boolean_WormPlayer_0;
		}

		// Token: 0x0200093D RID: 2365
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Challenge.Immortality.ShowOfStrengthWinConflict+<>c__DisplayClass10_1")]
		public sealed class __c__DisplayClass10_1 : Object
		{
			// Token: 0x06008D8B RID: 36235 RVA: 0x002625F4 File Offset: 0x002607F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_1()
			{
				Il2CppClassPointerStore<ShowOfStrengthWinConflict.__c__DisplayClass10_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowOfStrengthWinConflict>.NativeClassPtr, "<>c__DisplayClass10_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowOfStrengthWinConflict.__c__DisplayClass10_1>.NativeClassPtr);
				ShowOfStrengthWinConflict.__c__DisplayClass10_1.NativeFieldInfoPtr_usedArchIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowOfStrengthWinConflict.__c__DisplayClass10_1>.NativeClassPtr, "usedArchIDs");
				ShowOfStrengthWinConflict.__c__DisplayClass10_1.NativeFieldInfoPtr_chosenArchIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowOfStrengthWinConflict.__c__DisplayClass10_1>.NativeClassPtr, "chosenArchIDs");
				ShowOfStrengthWinConflict.__c__DisplayClass10_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowOfStrengthWinConflict.__c__DisplayClass10_1>.NativeClassPtr, 100674615);
				ShowOfStrengthWinConflict.__c__DisplayClass10_1.NativeMethodInfoPtr__BeginExecution_b__2_Internal_Boolean_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowOfStrengthWinConflict.__c__DisplayClass10_1>.NativeClassPtr, 100674616);
				ShowOfStrengthWinConflict.__c__DisplayClass10_1.NativeMethodInfoPtr__BeginExecution_b__3_Internal_Boolean_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowOfStrengthWinConflict.__c__DisplayClass10_1>.NativeClassPtr, 100674617);
			}

			// Token: 0x06008D8C RID: 36236 RVA: 0x00262684 File Offset: 0x00260884
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowOfStrengthWinConflict.__c__DisplayClass10_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowOfStrengthWinConflict.__c__DisplayClass10_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008D8D RID: 36237 RVA: 0x002626C0 File Offset: 0x002608C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195986, XrefRangeEnd = 195989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginExecution_b__2(ArchetypeID id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowOfStrengthWinConflict.__c__DisplayClass10_1.NativeMethodInfoPtr__BeginExecution_b__2_Internal_Boolean_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06008D8E RID: 36238 RVA: 0x00262710 File Offset: 0x00260910
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195989, XrefRangeEnd = 195992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginExecution_b__3(ArchetypeID id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowOfStrengthWinConflict.__c__DisplayClass10_1.NativeMethodInfoPtr__BeginExecution_b__3_Internal_Boolean_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06008D8F RID: 36239 RVA: 0x0003CBDA File Offset: 0x0003ADDA
			public __c__DisplayClass10_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700294B RID: 10571
			// (get) Token: 0x06008D90 RID: 36240 RVA: 0x00262760 File Offset: 0x00260960
			// (set) Token: 0x06008D91 RID: 36241 RVA: 0x0003CBE3 File Offset: 0x0003ADE3
			public unsafe List<ArchetypeID> usedArchIDs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowOfStrengthWinConflict.__c__DisplayClass10_1.NativeFieldInfoPtr_usedArchIDs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowOfStrengthWinConflict.__c__DisplayClass10_1.NativeFieldInfoPtr_usedArchIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700294C RID: 10572
			// (get) Token: 0x06008D92 RID: 36242 RVA: 0x00262790 File Offset: 0x00260990
			// (set) Token: 0x06008D93 RID: 36243 RVA: 0x0003CC02 File Offset: 0x0003AE02
			public unsafe List<ArchetypeID> chosenArchIDs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowOfStrengthWinConflict.__c__DisplayClass10_1.NativeFieldInfoPtr_chosenArchIDs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowOfStrengthWinConflict.__c__DisplayClass10_1.NativeFieldInfoPtr_chosenArchIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005A5D RID: 23133
			private static readonly IntPtr NativeFieldInfoPtr_usedArchIDs;

			// Token: 0x04005A5E RID: 23134
			private static readonly IntPtr NativeFieldInfoPtr_chosenArchIDs;

			// Token: 0x04005A5F RID: 23135
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005A60 RID: 23136
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__2_Internal_Boolean_ArchetypeID_0;

			// Token: 0x04005A61 RID: 23137
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__3_Internal_Boolean_ArchetypeID_0;
		}

		// Token: 0x0200093E RID: 2366
		[ObfuscatedName("worm.canis.abilities.TriggeredAbilities.Challenge.Immortality.ShowOfStrengthWinConflict+<BeginExecution>d__10")]
		public sealed class _BeginExecution_d__10 : Object
		{
			// Token: 0x06008D94 RID: 36244 RVA: 0x002627C0 File Offset: 0x002609C0
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginExecution_d__10()
			{
				Il2CppClassPointerStore<ShowOfStrengthWinConflict._BeginExecution_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowOfStrengthWinConflict>.NativeClassPtr, "<BeginExecution>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowOfStrengthWinConflict._BeginExecution_d__10>.NativeClassPtr);
				ShowOfStrengthWinConflict._BeginExecution_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowOfStrengthWinConflict._BeginExecution_d__10>.NativeClassPtr, "<>1__state");
				ShowOfStrengthWinConflict._BeginExecution_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowOfStrengthWinConflict._BeginExecution_d__10>.NativeClassPtr, "<>2__current");
				ShowOfStrengthWinConflict._BeginExecution_d__10.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowOfStrengthWinConflict._BeginExecution_d__10>.NativeClassPtr, "<>l__initialThreadId");
				ShowOfStrengthWinConflict._BeginExecution_d__10.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowOfStrengthWinConflict._BeginExecution_d__10>.NativeClassPtr, "activeAbility");
				ShowOfStrengthWinConflict._BeginExecution_d__10.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowOfStrengthWinConflict._BeginExecution_d__10>.NativeClassPtr, "<>3__activeAbility");
				ShowOfStrengthWinConflict._BeginExecution_d__10.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowOfStrengthWinConflict._BeginExecution_d__10>.NativeClassPtr, "match");
				ShowOfStrengthWinConflict._BeginExecution_d__10.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowOfStrengthWinConflict._BeginExecution_d__10>.NativeClassPtr, "<>3__match");
				ShowOfStrengthWinConflict._BeginExecution_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowOfStrengthWinConflict._BeginExecution_d__10>.NativeClassPtr, "<>4__this");
				ShowOfStrengthWinConflict._BeginExecution_d__10.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowOfStrengthWinConflict._BeginExecution_d__10>.NativeClassPtr, "<>8__1");
				ShowOfStrengthWinConflict._BeginExecution_d__10.NativeFieldInfoPtr___8__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowOfStrengthWinConflict._BeginExecution_d__10>.NativeClassPtr, "<>8__2");
				ShowOfStrengthWinConflict._BeginExecution_d__10.NativeFieldInfoPtr__filteredArchIDs_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowOfStrengthWinConflict._BeginExecution_d__10>.NativeClassPtr, "<filteredArchIDs>5__2");
				ShowOfStrengthWinConflict._BeginExecution_d__10.NativeFieldInfoPtr__chosenID_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowOfStrengthWinConflict._BeginExecution_d__10>.NativeClassPtr, "<chosenID>5__3");
				ShowOfStrengthWinConflict._BeginExecution_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowOfStrengthWinConflict._BeginExecution_d__10>.NativeClassPtr, 100674618);
				ShowOfStrengthWinConflict._BeginExecution_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowOfStrengthWinConflict._BeginExecution_d__10>.NativeClassPtr, 100674619);
				ShowOfStrengthWinConflict._BeginExecution_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowOfStrengthWinConflict._BeginExecution_d__10>.NativeClassPtr, 100674620);
				ShowOfStrengthWinConflict._BeginExecution_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowOfStrengthWinConflict._BeginExecution_d__10>.NativeClassPtr, 100674621);
				ShowOfStrengthWinConflict._BeginExecution_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowOfStrengthWinConflict._BeginExecution_d__10>.NativeClassPtr, 100674622);
				ShowOfStrengthWinConflict._BeginExecution_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowOfStrengthWinConflict._BeginExecution_d__10>.NativeClassPtr, 100674623);
				ShowOfStrengthWinConflict._BeginExecution_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowOfStrengthWinConflict._BeginExecution_d__10>.NativeClassPtr, 100674624);
				ShowOfStrengthWinConflict._BeginExecution_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowOfStrengthWinConflict._BeginExecution_d__10>.NativeClassPtr, 100674625);
			}

			// Token: 0x06008D95 RID: 36245 RVA: 0x0026297C File Offset: 0x00260B7C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginExecution_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowOfStrengthWinConflict._BeginExecution_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowOfStrengthWinConflict._BeginExecution_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06008D96 RID: 36246 RVA: 0x002629C4 File Offset: 0x00260BC4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowOfStrengthWinConflict._BeginExecution_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008D97 RID: 36247 RVA: 0x002629F8 File Offset: 0x00260BF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195992, XrefRangeEnd = 196249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowOfStrengthWinConflict._BeginExecution_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002959 RID: 10585
			// (get) Token: 0x06008D98 RID: 36248 RVA: 0x00262A34 File Offset: 0x00260C34
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowOfStrengthWinConflict._BeginExecution_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06008D99 RID: 36249 RVA: 0x00262A74 File Offset: 0x00260C74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196249, XrefRangeEnd = 196254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowOfStrengthWinConflict._BeginExecution_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700295A RID: 10586
			// (get) Token: 0x06008D9A RID: 36250 RVA: 0x00262AA8 File Offset: 0x00260CA8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowOfStrengthWinConflict._BeginExecution_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06008D9B RID: 36251 RVA: 0x00262AE8 File Offset: 0x00260CE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196254, XrefRangeEnd = 196264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowOfStrengthWinConflict._BeginExecution_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06008D9C RID: 36252 RVA: 0x00262B28 File Offset: 0x00260D28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowOfStrengthWinConflict._BeginExecution_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06008D9D RID: 36253 RVA: 0x0003CC21 File Offset: 0x0003AE21
			public _BeginExecution_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700294D RID: 10573
			// (get) Token: 0x06008D9E RID: 36254 RVA: 0x00262B68 File Offset: 0x00260D68
			// (set) Token: 0x06008D9F RID: 36255 RVA: 0x0003CC2A File Offset: 0x0003AE2A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowOfStrengthWinConflict._BeginExecution_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowOfStrengthWinConflict._BeginExecution_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700294E RID: 10574
			// (get) Token: 0x06008DA0 RID: 36256 RVA: 0x00262B90 File Offset: 0x00260D90
			// (set) Token: 0x06008DA1 RID: 36257 RVA: 0x0003CC45 File Offset: 0x0003AE45
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowOfStrengthWinConflict._BeginExecution_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowOfStrengthWinConflict._BeginExecution_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700294F RID: 10575
			// (get) Token: 0x06008DA2 RID: 36258 RVA: 0x00262BC0 File Offset: 0x00260DC0
			// (set) Token: 0x06008DA3 RID: 36259 RVA: 0x0003CC64 File Offset: 0x0003AE64
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowOfStrengthWinConflict._BeginExecution_d__10.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowOfStrengthWinConflict._BeginExecution_d__10.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17002950 RID: 10576
			// (get) Token: 0x06008DA4 RID: 36260 RVA: 0x00262BE8 File Offset: 0x00260DE8
			// (set) Token: 0x06008DA5 RID: 36261 RVA: 0x0003CC7F File Offset: 0x0003AE7F
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowOfStrengthWinConflict._BeginExecution_d__10.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowOfStrengthWinConflict._BeginExecution_d__10.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002951 RID: 10577
			// (get) Token: 0x06008DA6 RID: 36262 RVA: 0x00262C18 File Offset: 0x00260E18
			// (set) Token: 0x06008DA7 RID: 36263 RVA: 0x0003CC9E File Offset: 0x0003AE9E
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowOfStrengthWinConflict._BeginExecution_d__10.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowOfStrengthWinConflict._BeginExecution_d__10.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002952 RID: 10578
			// (get) Token: 0x06008DA8 RID: 36264 RVA: 0x00262C48 File Offset: 0x00260E48
			// (set) Token: 0x06008DA9 RID: 36265 RVA: 0x0003CCBD File Offset: 0x0003AEBD
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowOfStrengthWinConflict._BeginExecution_d__10.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowOfStrengthWinConflict._BeginExecution_d__10.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002953 RID: 10579
			// (get) Token: 0x06008DAA RID: 36266 RVA: 0x00262C78 File Offset: 0x00260E78
			// (set) Token: 0x06008DAB RID: 36267 RVA: 0x0003CCDC File Offset: 0x0003AEDC
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowOfStrengthWinConflict._BeginExecution_d__10.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowOfStrengthWinConflict._BeginExecution_d__10.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002954 RID: 10580
			// (get) Token: 0x06008DAC RID: 36268 RVA: 0x00262CA8 File Offset: 0x00260EA8
			// (set) Token: 0x06008DAD RID: 36269 RVA: 0x0003CCFB File Offset: 0x0003AEFB
			public unsafe ShowOfStrengthWinConflict __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowOfStrengthWinConflict._BeginExecution_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShowOfStrengthWinConflict>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowOfStrengthWinConflict._BeginExecution_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002955 RID: 10581
			// (get) Token: 0x06008DAE RID: 36270 RVA: 0x00262CD8 File Offset: 0x00260ED8
			// (set) Token: 0x06008DAF RID: 36271 RVA: 0x0003CD1A File Offset: 0x0003AF1A
			public unsafe ShowOfStrengthWinConflict.__c__DisplayClass10_1 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowOfStrengthWinConflict._BeginExecution_d__10.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShowOfStrengthWinConflict.__c__DisplayClass10_1>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowOfStrengthWinConflict._BeginExecution_d__10.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002956 RID: 10582
			// (get) Token: 0x06008DB0 RID: 36272 RVA: 0x00262D08 File Offset: 0x00260F08
			// (set) Token: 0x06008DB1 RID: 36273 RVA: 0x0003CD39 File Offset: 0x0003AF39
			public unsafe ShowOfStrengthWinConflict.__c__DisplayClass10_0 __8__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowOfStrengthWinConflict._BeginExecution_d__10.NativeFieldInfoPtr___8__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShowOfStrengthWinConflict.__c__DisplayClass10_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowOfStrengthWinConflict._BeginExecution_d__10.NativeFieldInfoPtr___8__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002957 RID: 10583
			// (get) Token: 0x06008DB2 RID: 36274 RVA: 0x00262D38 File Offset: 0x00260F38
			// (set) Token: 0x06008DB3 RID: 36275 RVA: 0x0003CD58 File Offset: 0x0003AF58
			public unsafe List<ArchetypeID> _filteredArchIDs_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowOfStrengthWinConflict._BeginExecution_d__10.NativeFieldInfoPtr__filteredArchIDs_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowOfStrengthWinConflict._BeginExecution_d__10.NativeFieldInfoPtr__filteredArchIDs_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002958 RID: 10584
			// (get) Token: 0x06008DB4 RID: 36276 RVA: 0x00262D68 File Offset: 0x00260F68
			// (set) Token: 0x06008DB5 RID: 36277 RVA: 0x0003CD77 File Offset: 0x0003AF77
			public unsafe ArchetypeID _chosenID_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowOfStrengthWinConflict._BeginExecution_d__10.NativeFieldInfoPtr__chosenID_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowOfStrengthWinConflict._BeginExecution_d__10.NativeFieldInfoPtr__chosenID_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005A62 RID: 23138
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005A63 RID: 23139
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005A64 RID: 23140
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04005A65 RID: 23141
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04005A66 RID: 23142
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x04005A67 RID: 23143
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04005A68 RID: 23144
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04005A69 RID: 23145
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005A6A RID: 23146
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04005A6B RID: 23147
			private static readonly IntPtr NativeFieldInfoPtr___8__2;

			// Token: 0x04005A6C RID: 23148
			private static readonly IntPtr NativeFieldInfoPtr__filteredArchIDs_5__2;

			// Token: 0x04005A6D RID: 23149
			private static readonly IntPtr NativeFieldInfoPtr__chosenID_5__3;

			// Token: 0x04005A6E RID: 23150
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005A6F RID: 23151
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005A70 RID: 23152
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005A71 RID: 23153
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04005A72 RID: 23154
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005A73 RID: 23155
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005A74 RID: 23156
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04005A75 RID: 23157
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
