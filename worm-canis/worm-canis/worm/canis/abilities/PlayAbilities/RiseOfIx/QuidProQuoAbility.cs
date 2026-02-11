using System;
using Canis;
using Canis.actions;
using Canis.context;
using Canis.entities;
using Canis.gameLogs;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.ai;
using worm.canis.ai.choices;
using worm.canis.data.enums;
using worm.canis.entities;

namespace worm.canis.abilities.PlayAbilities.RiseOfIx
{
	// Token: 0x02000442 RID: 1090
	public class QuidProQuoAbility : IntrigueAbility
	{
		// Token: 0x06002F84 RID: 12164 RVA: 0x0011FBF4 File Offset: 0x0011DDF4
		// Note: this type is marked as 'beforefieldinit'.
		static QuidProQuoAbility()
		{
			Il2CppClassPointerStore<QuidProQuoAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.PlayAbilities.RiseOfIx", "QuidProQuoAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuidProQuoAbility>.NativeClassPtr);
			QuidProQuoAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuidProQuoAbility>.NativeClassPtr, "AbilityName");
			QuidProQuoAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuidProQuoAbility>.NativeClassPtr, "AbilityID");
			QuidProQuoAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuidProQuoAbility>.NativeClassPtr, 100677763);
			QuidProQuoAbility.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuidProQuoAbility>.NativeClassPtr, 100677764);
			QuidProQuoAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuidProQuoAbility>.NativeClassPtr, 100677765);
			QuidProQuoAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuidProQuoAbility>.NativeClassPtr, 100677766);
			QuidProQuoAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuidProQuoAbility>.NativeClassPtr, 100677767);
			QuidProQuoAbility.NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuidProQuoAbility>.NativeClassPtr, 100677768);
			QuidProQuoAbility.NativeMethodInfoPtr_GetAgentSpaceFactions_Private_List_1_Factions_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuidProQuoAbility>.NativeClassPtr, 100677769);
			QuidProQuoAbility.NativeMethodInfoPtr_ShowHinting_Public_Virtual_Boolean_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuidProQuoAbility>.NativeClassPtr, 100677770);
			QuidProQuoAbility.NativeMethodInfoPtr_IsBadIntrigue_Public_Virtual_Boolean_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuidProQuoAbility>.NativeClassPtr, 100677771);
			QuidProQuoAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuidProQuoAbility>.NativeClassPtr, 100677772);
		}

		// Token: 0x06002F85 RID: 12165 RVA: 0x0011FD14 File Offset: 0x0011DF14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220917, XrefRangeEnd = 220921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuidProQuoAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06002F86 RID: 12166 RVA: 0x0011FD60 File Offset: 0x0011DF60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220921, XrefRangeEnd = 220927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override GameLogBuilder MakeGameLogBuilder(IHasGameLogs hasGameLogs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hasGameLogs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuidProQuoAbility.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x06002F87 RID: 12167 RVA: 0x0011FDBC File Offset: 0x0011DFBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220927, XrefRangeEnd = 220930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuidProQuoAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuidProQuoAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuidProQuoAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F88 RID: 12168 RVA: 0x0011FE08 File Offset: 0x0011E008
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 215283, RefRangeEnd = 215298, XrefRangeStart = 215283, XrefRangeEnd = 215298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuidProQuoAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuidProQuoAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuidProQuoAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F89 RID: 12169 RVA: 0x0011FE78 File Offset: 0x0011E078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220930, XrefRangeEnd = 220952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuidProQuoAbility.NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
		}

		// Token: 0x06002F8A RID: 12170 RVA: 0x0011FEE8 File Offset: 0x0011E0E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220952, XrefRangeEnd = 220960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuidProQuoAbility.NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06002F8B RID: 12171 RVA: 0x0011FF68 File Offset: 0x0011E168
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 221001, RefRangeEnd = 221005, XrefRangeStart = 220960, XrefRangeEnd = 221001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Factions> GetAgentSpaceFactions(WormMatch match, WormPlayer player)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuidProQuoAbility.NativeMethodInfoPtr_GetAgentSpaceFactions_Private_List_1_Factions_WormMatch_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Factions>>(intPtr3) : null;
		}

		// Token: 0x06002F8C RID: 12172 RVA: 0x0011FFCC File Offset: 0x0011E1CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221005, XrefRangeEnd = 221017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuidProQuoAbility.NativeMethodInfoPtr_ShowHinting_Public_Virtual_Boolean_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F8D RID: 12173 RVA: 0x00120038 File Offset: 0x0011E238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221017, XrefRangeEnd = 221018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuidProQuoAbility.NativeMethodInfoPtr_IsBadIntrigue_Public_Virtual_Boolean_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F8E RID: 12174 RVA: 0x001200A4 File Offset: 0x0011E2A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221018, XrefRangeEnd = 221070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WormAIChoice Evaluate(WormAIChoiceContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuidProQuoAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormAIChoice>(intPtr3) : null;
			}
		}

		// Token: 0x06002F8F RID: 12175 RVA: 0x00010EA2 File Offset: 0x0000F0A2
		public QuidProQuoAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x06002F90 RID: 12176 RVA: 0x00120100 File Offset: 0x0011E300
		// (set) Token: 0x06002F91 RID: 12177 RVA: 0x00010EAB File Offset: 0x0000F0AB
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(QuidProQuoAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(QuidProQuoAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x06002F92 RID: 12178 RVA: 0x00120120 File Offset: 0x0011E320
		// (set) Token: 0x06002F93 RID: 12179 RVA: 0x00010EBD File Offset: 0x0000F0BD
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(QuidProQuoAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(QuidProQuoAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001EA2 RID: 7842
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04001EA3 RID: 7843
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04001EA4 RID: 7844
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04001EA5 RID: 7845
		private static readonly IntPtr NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0;

		// Token: 0x04001EA6 RID: 7846
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x04001EA7 RID: 7847
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04001EA8 RID: 7848
		private static readonly IntPtr NativeMethodInfoPtr_Cost_Public_Virtual_CostAction_Match_Context_0;

		// Token: 0x04001EA9 RID: 7849
		private static readonly IntPtr NativeMethodInfoPtr_RunImmediateEffects_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x04001EAA RID: 7850
		private static readonly IntPtr NativeMethodInfoPtr_GetAgentSpaceFactions_Private_List_1_Factions_WormMatch_WormPlayer_0;

		// Token: 0x04001EAB RID: 7851
		private static readonly IntPtr NativeMethodInfoPtr_ShowHinting_Public_Virtual_Boolean_WormMatch_WormPlayer_0;

		// Token: 0x04001EAC RID: 7852
		private static readonly IntPtr NativeMethodInfoPtr_IsBadIntrigue_Public_Virtual_Boolean_WormMatch_WormPlayer_0;

		// Token: 0x04001EAD RID: 7853
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0;

		// Token: 0x02000A5A RID: 2650
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.RiseOfIx.QuidProQuoAbility+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600A5BF RID: 42431 RVA: 0x002A9624 File Offset: 0x002A7824
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<QuidProQuoAbility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<QuidProQuoAbility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuidProQuoAbility.__c>.NativeClassPtr);
				QuidProQuoAbility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuidProQuoAbility.__c>.NativeClassPtr, "<>9");
				QuidProQuoAbility.__c.NativeFieldInfoPtr___9__8_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuidProQuoAbility.__c>.NativeClassPtr, "<>9__8_1");
				QuidProQuoAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuidProQuoAbility.__c>.NativeClassPtr, 100677775);
				QuidProQuoAbility.__c.NativeMethodInfoPtr__GetAgentSpaceFactions_b__8_1_Internal_Factions_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuidProQuoAbility.__c>.NativeClassPtr, 100677776);
			}

			// Token: 0x0600A5C0 RID: 42432 RVA: 0x002A96A0 File Offset: 0x002A78A0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuidProQuoAbility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuidProQuoAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A5C1 RID: 42433 RVA: 0x002A96DC File Offset: 0x002A78DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Factions _GetAgentSpaceFactions_b__8_1(WormSpace _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuidProQuoAbility.__c.NativeMethodInfoPtr__GetAgentSpaceFactions_b__8_1_Internal_Factions_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600A5C2 RID: 42434 RVA: 0x0004ABB0 File Offset: 0x00048DB0
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700322A RID: 12842
			// (get) Token: 0x0600A5C3 RID: 42435 RVA: 0x002A972C File Offset: 0x002A792C
			// (set) Token: 0x0600A5C4 RID: 42436 RVA: 0x0004ABB9 File Offset: 0x00048DB9
			public unsafe static QuidProQuoAbility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(QuidProQuoAbility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuidProQuoAbility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(QuidProQuoAbility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700322B RID: 12843
			// (get) Token: 0x0600A5C5 RID: 42437 RVA: 0x002A9754 File Offset: 0x002A7954
			// (set) Token: 0x0600A5C6 RID: 42438 RVA: 0x0004ABCB File Offset: 0x00048DCB
			public unsafe static Func<WormSpace, Factions> __9__8_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(QuidProQuoAbility.__c.NativeFieldInfoPtr___9__8_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormSpace, Factions>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(QuidProQuoAbility.__c.NativeFieldInfoPtr___9__8_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006902 RID: 26882
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006903 RID: 26883
			private static readonly IntPtr NativeFieldInfoPtr___9__8_1;

			// Token: 0x04006904 RID: 26884
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006905 RID: 26885
			private static readonly IntPtr NativeMethodInfoPtr__GetAgentSpaceFactions_b__8_1_Internal_Factions_WormSpace_0;
		}

		// Token: 0x02000A5B RID: 2651
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.RiseOfIx.QuidProQuoAbility+<>c__DisplayClass11_0")]
		public new sealed class __c__DisplayClass11_0 : Object
		{
			// Token: 0x0600A5C7 RID: 42439 RVA: 0x002A977C File Offset: 0x002A797C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<QuidProQuoAbility.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<QuidProQuoAbility>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuidProQuoAbility.__c__DisplayClass11_0>.NativeClassPtr);
				QuidProQuoAbility.__c__DisplayClass11_0.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuidProQuoAbility.__c__DisplayClass11_0>.NativeClassPtr, "context");
				QuidProQuoAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuidProQuoAbility.__c__DisplayClass11_0>.NativeClassPtr, 100677777);
				QuidProQuoAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__Evaluate_b__0_Internal_Boolean_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuidProQuoAbility.__c__DisplayClass11_0>.NativeClassPtr, 100677778);
				QuidProQuoAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__Evaluate_b__1_Internal_Boolean_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuidProQuoAbility.__c__DisplayClass11_0>.NativeClassPtr, 100677779);
				QuidProQuoAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__Evaluate_b__2_Internal_Boolean_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuidProQuoAbility.__c__DisplayClass11_0>.NativeClassPtr, 100677780);
			}

			// Token: 0x0600A5C8 RID: 42440 RVA: 0x002A980C File Offset: 0x002A7A0C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuidProQuoAbility.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuidProQuoAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A5C9 RID: 42441 RVA: 0x002A9848 File Offset: 0x002A7A48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220795, XrefRangeEnd = 220812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Evaluate_b__0(Factions faction)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref faction;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuidProQuoAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__Evaluate_b__0_Internal_Boolean_Factions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600A5CA RID: 42442 RVA: 0x002A9894 File Offset: 0x002A7A94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220812, XrefRangeEnd = 220813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Evaluate_b__1(Factions _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref _;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuidProQuoAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__Evaluate_b__1_Internal_Boolean_Factions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600A5CB RID: 42443 RVA: 0x002A98E0 File Offset: 0x002A7AE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220813, XrefRangeEnd = 220815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Evaluate_b__2(Factions _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref _;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuidProQuoAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__Evaluate_b__2_Internal_Boolean_Factions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600A5CC RID: 42444 RVA: 0x0004ABDD File Offset: 0x00048DDD
			public __c__DisplayClass11_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700322C RID: 12844
			// (get) Token: 0x0600A5CD RID: 42445 RVA: 0x002A992C File Offset: 0x002A7B2C
			// (set) Token: 0x0600A5CE RID: 42446 RVA: 0x0004ABE6 File Offset: 0x00048DE6
			public unsafe WormAIChoiceContext context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuidProQuoAbility.__c__DisplayClass11_0.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAIChoiceContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuidProQuoAbility.__c__DisplayClass11_0.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006906 RID: 26886
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04006907 RID: 26887
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006908 RID: 26888
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__0_Internal_Boolean_Factions_0;

			// Token: 0x04006909 RID: 26889
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__1_Internal_Boolean_Factions_0;

			// Token: 0x0400690A RID: 26890
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__2_Internal_Boolean_Factions_0;
		}

		// Token: 0x02000A5C RID: 2652
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.RiseOfIx.QuidProQuoAbility+<>c__DisplayClass11_1")]
		public sealed class __c__DisplayClass11_1 : Object
		{
			// Token: 0x0600A5CF RID: 42447 RVA: 0x002A995C File Offset: 0x002A7B5C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_1()
			{
				Il2CppClassPointerStore<QuidProQuoAbility.__c__DisplayClass11_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<QuidProQuoAbility>.NativeClassPtr, "<>c__DisplayClass11_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuidProQuoAbility.__c__DisplayClass11_1>.NativeClassPtr);
				QuidProQuoAbility.__c__DisplayClass11_1.NativeFieldInfoPtr_faction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuidProQuoAbility.__c__DisplayClass11_1>.NativeClassPtr, "faction");
				QuidProQuoAbility.__c__DisplayClass11_1.NativeFieldInfoPtr_field_Public___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuidProQuoAbility.__c__DisplayClass11_1>.NativeClassPtr, "CS$<>8__locals1");
				QuidProQuoAbility.__c__DisplayClass11_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuidProQuoAbility.__c__DisplayClass11_1>.NativeClassPtr, 100677781);
				QuidProQuoAbility.__c__DisplayClass11_1.NativeMethodInfoPtr__Evaluate_b__3_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuidProQuoAbility.__c__DisplayClass11_1>.NativeClassPtr, 100677782);
			}

			// Token: 0x0600A5D0 RID: 42448 RVA: 0x002A99D8 File Offset: 0x002A7BD8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuidProQuoAbility.__c__DisplayClass11_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuidProQuoAbility.__c__DisplayClass11_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A5D1 RID: 42449 RVA: 0x002A9A14 File Offset: 0x002A7C14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220815, XrefRangeEnd = 220818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Evaluate_b__3(WormPlayer opp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(opp);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuidProQuoAbility.__c__DisplayClass11_1.NativeMethodInfoPtr__Evaluate_b__3_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600A5D2 RID: 42450 RVA: 0x0004AC05 File Offset: 0x00048E05
			public __c__DisplayClass11_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700322D RID: 12845
			// (get) Token: 0x0600A5D3 RID: 42451 RVA: 0x002A9A64 File Offset: 0x002A7C64
			// (set) Token: 0x0600A5D4 RID: 42452 RVA: 0x0004AC0E File Offset: 0x00048E0E
			public unsafe Factions faction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuidProQuoAbility.__c__DisplayClass11_1.NativeFieldInfoPtr_faction);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuidProQuoAbility.__c__DisplayClass11_1.NativeFieldInfoPtr_faction)) = value;
				}
			}

			// Token: 0x1700322E RID: 12846
			// (get) Token: 0x0600A5D5 RID: 42453 RVA: 0x002A9A8C File Offset: 0x002A7C8C
			// (set) Token: 0x0600A5D6 RID: 42454 RVA: 0x0004AC29 File Offset: 0x00048E29
			public unsafe QuidProQuoAbility.__c__DisplayClass11_0 field_Public___c__DisplayClass11_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuidProQuoAbility.__c__DisplayClass11_1.NativeFieldInfoPtr_field_Public___c__DisplayClass11_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuidProQuoAbility.__c__DisplayClass11_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuidProQuoAbility.__c__DisplayClass11_1.NativeFieldInfoPtr_field_Public___c__DisplayClass11_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400690B RID: 26891
			private static readonly IntPtr NativeFieldInfoPtr_faction;

			// Token: 0x0400690C RID: 26892
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass11_0_0;

			// Token: 0x0400690D RID: 26893
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400690E RID: 26894
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__3_Internal_Boolean_WormPlayer_0;
		}

		// Token: 0x02000A5D RID: 2653
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.RiseOfIx.QuidProQuoAbility+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x0600A5D7 RID: 42455 RVA: 0x002A9ABC File Offset: 0x002A7CBC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<QuidProQuoAbility.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<QuidProQuoAbility>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuidProQuoAbility.__c__DisplayClass7_0>.NativeClassPtr);
				QuidProQuoAbility.__c__DisplayClass7_0.NativeFieldInfoPtr_factionList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuidProQuoAbility.__c__DisplayClass7_0>.NativeClassPtr, "factionList");
				QuidProQuoAbility.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuidProQuoAbility.__c__DisplayClass7_0>.NativeClassPtr, 100677783);
				QuidProQuoAbility.__c__DisplayClass7_0.NativeMethodInfoPtr__RunImmediateEffects_b__0_Internal_GameLogBuilder_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuidProQuoAbility.__c__DisplayClass7_0>.NativeClassPtr, 100677784);
			}

			// Token: 0x0600A5D8 RID: 42456 RVA: 0x002A9B24 File Offset: 0x002A7D24
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuidProQuoAbility.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuidProQuoAbility.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A5D9 RID: 42457 RVA: 0x002A9B60 File Offset: 0x002A7D60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220818, XrefRangeEnd = 220822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GameLogBuilder _RunImmediateEffects_b__0(GameLogBuilder _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuidProQuoAbility.__c__DisplayClass7_0.NativeMethodInfoPtr__RunImmediateEffects_b__0_Internal_GameLogBuilder_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x0600A5DA RID: 42458 RVA: 0x0004AC48 File Offset: 0x00048E48
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700322F RID: 12847
			// (get) Token: 0x0600A5DB RID: 42459 RVA: 0x002A9BB0 File Offset: 0x002A7DB0
			// (set) Token: 0x0600A5DC RID: 42460 RVA: 0x0004AC51 File Offset: 0x00048E51
			public unsafe List<Factions> factionList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuidProQuoAbility.__c__DisplayClass7_0.NativeFieldInfoPtr_factionList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Factions>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuidProQuoAbility.__c__DisplayClass7_0.NativeFieldInfoPtr_factionList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400690F RID: 26895
			private static readonly IntPtr NativeFieldInfoPtr_factionList;

			// Token: 0x04006910 RID: 26896
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006911 RID: 26897
			private static readonly IntPtr NativeMethodInfoPtr__RunImmediateEffects_b__0_Internal_GameLogBuilder_GameLogBuilder_0;
		}

		// Token: 0x02000A5E RID: 2654
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.RiseOfIx.QuidProQuoAbility+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x0600A5DD RID: 42461 RVA: 0x002A9BE0 File Offset: 0x002A7DE0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<QuidProQuoAbility.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<QuidProQuoAbility>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuidProQuoAbility.__c__DisplayClass8_0>.NativeClassPtr);
				QuidProQuoAbility.__c__DisplayClass8_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuidProQuoAbility.__c__DisplayClass8_0>.NativeClassPtr, "player");
				QuidProQuoAbility.__c__DisplayClass8_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuidProQuoAbility.__c__DisplayClass8_0>.NativeClassPtr, "<>9__2");
				QuidProQuoAbility.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuidProQuoAbility.__c__DisplayClass8_0>.NativeClassPtr, 100677785);
				QuidProQuoAbility.__c__DisplayClass8_0.NativeMethodInfoPtr__GetAgentSpaceFactions_b__0_Internal_Boolean_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuidProQuoAbility.__c__DisplayClass8_0>.NativeClassPtr, 100677786);
				QuidProQuoAbility.__c__DisplayClass8_0.NativeMethodInfoPtr__GetAgentSpaceFactions_b__2_Internal_Boolean_WormAgent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuidProQuoAbility.__c__DisplayClass8_0>.NativeClassPtr, 100677787);
			}

			// Token: 0x0600A5DE RID: 42462 RVA: 0x002A9C70 File Offset: 0x002A7E70
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuidProQuoAbility.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuidProQuoAbility.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A5DF RID: 42463 RVA: 0x002A9CAC File Offset: 0x002A7EAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220822, XrefRangeEnd = 220827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAgentSpaceFactions_b__0(WormSpace space)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(space);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuidProQuoAbility.__c__DisplayClass8_0.NativeMethodInfoPtr__GetAgentSpaceFactions_b__0_Internal_Boolean_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600A5E0 RID: 42464 RVA: 0x002A9CFC File Offset: 0x002A7EFC
			[CallerCount(0)]
			public unsafe bool _GetAgentSpaceFactions_b__2(WormAgent agent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(agent);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuidProQuoAbility.__c__DisplayClass8_0.NativeMethodInfoPtr__GetAgentSpaceFactions_b__2_Internal_Boolean_WormAgent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600A5E1 RID: 42465 RVA: 0x0004AC70 File Offset: 0x00048E70
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003230 RID: 12848
			// (get) Token: 0x0600A5E2 RID: 42466 RVA: 0x002A9D4C File Offset: 0x002A7F4C
			// (set) Token: 0x0600A5E3 RID: 42467 RVA: 0x0004AC79 File Offset: 0x00048E79
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuidProQuoAbility.__c__DisplayClass8_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuidProQuoAbility.__c__DisplayClass8_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003231 RID: 12849
			// (get) Token: 0x0600A5E4 RID: 42468 RVA: 0x002A9D7C File Offset: 0x002A7F7C
			// (set) Token: 0x0600A5E5 RID: 42469 RVA: 0x0004AC98 File Offset: 0x00048E98
			public unsafe Func<WormAgent, bool> __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuidProQuoAbility.__c__DisplayClass8_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormAgent, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuidProQuoAbility.__c__DisplayClass8_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006912 RID: 26898
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04006913 RID: 26899
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x04006914 RID: 26900
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006915 RID: 26901
			private static readonly IntPtr NativeMethodInfoPtr__GetAgentSpaceFactions_b__0_Internal_Boolean_WormSpace_0;

			// Token: 0x04006916 RID: 26902
			private static readonly IntPtr NativeMethodInfoPtr__GetAgentSpaceFactions_b__2_Internal_Boolean_WormAgent_0;
		}

		// Token: 0x02000A5F RID: 2655
		[ObfuscatedName("worm.canis.abilities.PlayAbilities.RiseOfIx.QuidProQuoAbility+<RunImmediateEffects>d__7")]
		public sealed class _RunImmediateEffects_d__7 : Object
		{
			// Token: 0x0600A5E6 RID: 42470 RVA: 0x002A9DAC File Offset: 0x002A7FAC
			// Note: this type is marked as 'beforefieldinit'.
			static _RunImmediateEffects_d__7()
			{
				Il2CppClassPointerStore<QuidProQuoAbility._RunImmediateEffects_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<QuidProQuoAbility>.NativeClassPtr, "<RunImmediateEffects>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuidProQuoAbility._RunImmediateEffects_d__7>.NativeClassPtr);
				QuidProQuoAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuidProQuoAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<>1__state");
				QuidProQuoAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuidProQuoAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<>2__current");
				QuidProQuoAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuidProQuoAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<>l__initialThreadId");
				QuidProQuoAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuidProQuoAbility._RunImmediateEffects_d__7>.NativeClassPtr, "activeAbility");
				QuidProQuoAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuidProQuoAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<>3__activeAbility");
				QuidProQuoAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuidProQuoAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<>4__this");
				QuidProQuoAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuidProQuoAbility._RunImmediateEffects_d__7>.NativeClassPtr, "match");
				QuidProQuoAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuidProQuoAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<>3__match");
				QuidProQuoAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuidProQuoAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<>8__1");
				QuidProQuoAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuidProQuoAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<player>5__2");
				QuidProQuoAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuidProQuoAbility._RunImmediateEffects_d__7>.NativeClassPtr, "<>7__wrap2");
				QuidProQuoAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuidProQuoAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100677788);
				QuidProQuoAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuidProQuoAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100677789);
				QuidProQuoAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuidProQuoAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100677790);
				QuidProQuoAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuidProQuoAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100677791);
				QuidProQuoAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuidProQuoAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100677792);
				QuidProQuoAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuidProQuoAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100677793);
				QuidProQuoAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuidProQuoAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100677794);
				QuidProQuoAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuidProQuoAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100677795);
				QuidProQuoAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuidProQuoAbility._RunImmediateEffects_d__7>.NativeClassPtr, 100677796);
			}

			// Token: 0x0600A5E7 RID: 42471 RVA: 0x002A9F68 File Offset: 0x002A8168
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RunImmediateEffects_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuidProQuoAbility._RunImmediateEffects_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuidProQuoAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600A5E8 RID: 42472 RVA: 0x002A9FB0 File Offset: 0x002A81B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220827, XrefRangeEnd = 220832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuidProQuoAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A5E9 RID: 42473 RVA: 0x002A9FE4 File Offset: 0x002A81E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220832, XrefRangeEnd = 220899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuidProQuoAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A5EA RID: 42474 RVA: 0x002AA020 File Offset: 0x002A8220
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220899, XrefRangeEnd = 220902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuidProQuoAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700323D RID: 12861
			// (get) Token: 0x0600A5EB RID: 42475 RVA: 0x002AA054 File Offset: 0x002A8254
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuidProQuoAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600A5EC RID: 42476 RVA: 0x002AA094 File Offset: 0x002A8294
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220902, XrefRangeEnd = 220907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuidProQuoAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700323E RID: 12862
			// (get) Token: 0x0600A5ED RID: 42477 RVA: 0x002AA0C8 File Offset: 0x002A82C8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuidProQuoAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A5EE RID: 42478 RVA: 0x002AA108 File Offset: 0x002A8308
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220907, XrefRangeEnd = 220917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuidProQuoAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600A5EF RID: 42479 RVA: 0x002AA148 File Offset: 0x002A8348
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuidProQuoAbility._RunImmediateEffects_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600A5F0 RID: 42480 RVA: 0x0004ACB7 File Offset: 0x00048EB7
			public _RunImmediateEffects_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003232 RID: 12850
			// (get) Token: 0x0600A5F1 RID: 42481 RVA: 0x002AA188 File Offset: 0x002A8388
			// (set) Token: 0x0600A5F2 RID: 42482 RVA: 0x0004ACC0 File Offset: 0x00048EC0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuidProQuoAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuidProQuoAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003233 RID: 12851
			// (get) Token: 0x0600A5F3 RID: 42483 RVA: 0x002AA1B0 File Offset: 0x002A83B0
			// (set) Token: 0x0600A5F4 RID: 42484 RVA: 0x0004ACDB File Offset: 0x00048EDB
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuidProQuoAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuidProQuoAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003234 RID: 12852
			// (get) Token: 0x0600A5F5 RID: 42485 RVA: 0x002AA1E0 File Offset: 0x002A83E0
			// (set) Token: 0x0600A5F6 RID: 42486 RVA: 0x0004ACFA File Offset: 0x00048EFA
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuidProQuoAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuidProQuoAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17003235 RID: 12853
			// (get) Token: 0x0600A5F7 RID: 42487 RVA: 0x002AA208 File Offset: 0x002A8408
			// (set) Token: 0x0600A5F8 RID: 42488 RVA: 0x0004AD15 File Offset: 0x00048F15
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuidProQuoAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuidProQuoAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003236 RID: 12854
			// (get) Token: 0x0600A5F9 RID: 42489 RVA: 0x002AA238 File Offset: 0x002A8438
			// (set) Token: 0x0600A5FA RID: 42490 RVA: 0x0004AD34 File Offset: 0x00048F34
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuidProQuoAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuidProQuoAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003237 RID: 12855
			// (get) Token: 0x0600A5FB RID: 42491 RVA: 0x002AA268 File Offset: 0x002A8468
			// (set) Token: 0x0600A5FC RID: 42492 RVA: 0x0004AD53 File Offset: 0x00048F53
			public unsafe QuidProQuoAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuidProQuoAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuidProQuoAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuidProQuoAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003238 RID: 12856
			// (get) Token: 0x0600A5FD RID: 42493 RVA: 0x002AA298 File Offset: 0x002A8498
			// (set) Token: 0x0600A5FE RID: 42494 RVA: 0x0004AD72 File Offset: 0x00048F72
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuidProQuoAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuidProQuoAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003239 RID: 12857
			// (get) Token: 0x0600A5FF RID: 42495 RVA: 0x002AA2C8 File Offset: 0x002A84C8
			// (set) Token: 0x0600A600 RID: 42496 RVA: 0x0004AD91 File Offset: 0x00048F91
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuidProQuoAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuidProQuoAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700323A RID: 12858
			// (get) Token: 0x0600A601 RID: 42497 RVA: 0x002AA2F8 File Offset: 0x002A84F8
			// (set) Token: 0x0600A602 RID: 42498 RVA: 0x0004ADB0 File Offset: 0x00048FB0
			public unsafe QuidProQuoAbility.__c__DisplayClass7_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuidProQuoAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuidProQuoAbility.__c__DisplayClass7_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuidProQuoAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700323B RID: 12859
			// (get) Token: 0x0600A603 RID: 42499 RVA: 0x002AA328 File Offset: 0x002A8528
			// (set) Token: 0x0600A604 RID: 42500 RVA: 0x0004ADCF File Offset: 0x00048FCF
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuidProQuoAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuidProQuoAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700323C RID: 12860
			// (get) Token: 0x0600A605 RID: 42501 RVA: 0x002AA358 File Offset: 0x002A8558
			// (set) Token: 0x0600A606 RID: 42502 RVA: 0x0004ADEE File Offset: 0x00048FEE
			public List<Factions>.Enumerator __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuidProQuoAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___7__wrap2);
					return new List<Factions>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<Factions>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuidProQuoAbility._RunImmediateEffects_d__7.NativeFieldInfoPtr___7__wrap2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<Factions>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04006917 RID: 26903
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006918 RID: 26904
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006919 RID: 26905
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400691A RID: 26906
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x0400691B RID: 26907
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x0400691C RID: 26908
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400691D RID: 26909
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x0400691E RID: 26910
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x0400691F RID: 26911
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04006920 RID: 26912
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x04006921 RID: 26913
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04006922 RID: 26914
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006923 RID: 26915
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006924 RID: 26916
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006925 RID: 26917
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04006926 RID: 26918
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04006927 RID: 26919
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006928 RID: 26920
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006929 RID: 26921
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x0400692A RID: 26922
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
