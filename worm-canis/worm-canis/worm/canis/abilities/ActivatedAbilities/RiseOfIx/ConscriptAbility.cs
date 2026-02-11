using System;
using System.Runtime.InteropServices;
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
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lib.canis.data.enums;
using Networking.selection.targetinformation;
using worm.canis.ai;
using worm.canis.ai.choices;
using worm.canis.data.enums;
using worm.canis.entities;

namespace worm.canis.abilities.ActivatedAbilities.RiseOfIx
{
	// Token: 0x020004CE RID: 1230
	public class ConscriptAbility : SignetAbility
	{
		// Token: 0x06003784 RID: 14212 RVA: 0x00147EA0 File Offset: 0x001460A0
		// Note: this type is marked as 'beforefieldinit'.
		static ConscriptAbility()
		{
			Il2CppClassPointerStore<ConscriptAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities.ActivatedAbilities.RiseOfIx", "ConscriptAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConscriptAbility>.NativeClassPtr);
			ConscriptAbility.NativeFieldInfoPtr_AbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConscriptAbility>.NativeClassPtr, "AbilityName");
			ConscriptAbility.NativeFieldInfoPtr_AbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConscriptAbility>.NativeClassPtr, "AbilityID");
			ConscriptAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConscriptAbility>.NativeClassPtr, 100680889);
			ConscriptAbility.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConscriptAbility>.NativeClassPtr, 100680890);
			ConscriptAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConscriptAbility>.NativeClassPtr, 100680891);
			ConscriptAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConscriptAbility>.NativeClassPtr, 100680892);
			ConscriptAbility.NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConscriptAbility>.NativeClassPtr, 100680893);
			ConscriptAbility.NativeMethodInfoPtr_SelectionMode_Public_Virtual_DeferredSelectionMode_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConscriptAbility>.NativeClassPtr, 100680894);
			ConscriptAbility.NativeMethodInfoPtr_CanRunImmediately_Public_Virtual_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConscriptAbility>.NativeClassPtr, 100680895);
			ConscriptAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConscriptAbility>.NativeClassPtr, 100680896);
			ConscriptAbility.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConscriptAbility>.NativeClassPtr, 100680897);
			ConscriptAbility.NativeMethodInfoPtr_GetConscriptTargets_Private_List_1_WormImperiumPlayable_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConscriptAbility>.NativeClassPtr, 100680898);
			ConscriptAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConscriptAbility>.NativeClassPtr, 100680899);
			ConscriptAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConscriptAbility>.NativeClassPtr, 100680900);
		}

		// Token: 0x06003785 RID: 14213 RVA: 0x00147FE8 File Offset: 0x001461E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247741, XrefRangeEnd = 247745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AbilityID GetAbilityID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConscriptAbility.NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
		}

		// Token: 0x06003786 RID: 14214 RVA: 0x00148034 File Offset: 0x00146234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247745, XrefRangeEnd = 247755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override GameLogBuilder MakeGameLogBuilder(IHasGameLogs hasGameLogs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hasGameLogs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConscriptAbility.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x06003787 RID: 14215 RVA: 0x00148090 File Offset: 0x00146290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247755, XrefRangeEnd = 247768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConscriptAbility(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConscriptAbility>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConscriptAbility.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003788 RID: 14216 RVA: 0x001480DC File Offset: 0x001462DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247768, XrefRangeEnd = 247769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConscriptAbility(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConscriptAbility>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConscriptAbility.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003789 RID: 14217 RVA: 0x0014814C File Offset: 0x0014634C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247769, XrefRangeEnd = 247777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConscriptAbility.NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TargetInformation>>(intPtr3) : null;
		}

		// Token: 0x0600378A RID: 14218 RVA: 0x001481BC File Offset: 0x001463BC
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConscriptAbility.NativeMethodInfoPtr_SelectionMode_Public_Virtual_DeferredSelectionMode_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600378B RID: 14219 RVA: 0x00148214 File Offset: 0x00146414
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConscriptAbility.NativeMethodInfoPtr_CanRunImmediately_Public_Virtual_Boolean_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600378C RID: 14220 RVA: 0x0014826C File Offset: 0x0014646C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247777, XrefRangeEnd = 247786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConscriptAbility.NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x0600378D RID: 14221 RVA: 0x001482EC File Offset: 0x001464EC
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConscriptAbility.NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600378E RID: 14222 RVA: 0x00148368 File Offset: 0x00146568
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 247831, RefRangeEnd = 247832, XrefRangeStart = 247786, XrefRangeEnd = 247831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<WormImperiumPlayable> GetConscriptTargets(WormMatch match, WormPlayer player)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConscriptAbility.NativeMethodInfoPtr_GetConscriptTargets_Private_List_1_WormImperiumPlayable_WormMatch_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<WormImperiumPlayable>>(intPtr3) : null;
		}

		// Token: 0x0600378F RID: 14223 RVA: 0x001483CC File Offset: 0x001465CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247832, XrefRangeEnd = 247868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConscriptAbility.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
		}

		// Token: 0x06003790 RID: 14224 RVA: 0x00148448 File Offset: 0x00146648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247868, XrefRangeEnd = 247939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override WormAIChoice Evaluate(WormAIChoiceContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConscriptAbility.NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormAIChoice>(intPtr3) : null;
			}
		}

		// Token: 0x06003791 RID: 14225 RVA: 0x00012922 File Offset: 0x00010B22
		public override AIValueSummer<double> ValueForPlayer(WormPlayer player, params WormEntity[] withEntities)
		{
			return this.ValueForPlayer(player, new Il2CppReferenceArray<WormEntity>(withEntities));
		}

		// Token: 0x06003792 RID: 14226 RVA: 0x00012931 File Offset: 0x00010B31
		public ConscriptAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DE8 RID: 3560
		// (get) Token: 0x06003793 RID: 14227 RVA: 0x001484A4 File Offset: 0x001466A4
		// (set) Token: 0x06003794 RID: 14228 RVA: 0x0001293A File Offset: 0x00010B3A
		public unsafe static string AbilityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ConscriptAbility.NativeFieldInfoPtr_AbilityName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConscriptAbility.NativeFieldInfoPtr_AbilityName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DE9 RID: 3561
		// (get) Token: 0x06003795 RID: 14229 RVA: 0x001484C4 File Offset: 0x001466C4
		// (set) Token: 0x06003796 RID: 14230 RVA: 0x0001294C File Offset: 0x00010B4C
		public unsafe static AbilityID AbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ConscriptAbility.NativeFieldInfoPtr_AbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConscriptAbility.NativeFieldInfoPtr_AbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002455 RID: 9301
		private static readonly IntPtr NativeFieldInfoPtr_AbilityName;

		// Token: 0x04002456 RID: 9302
		private static readonly IntPtr NativeFieldInfoPtr_AbilityID;

		// Token: 0x04002457 RID: 9303
		private static readonly IntPtr NativeMethodInfoPtr_GetAbilityID_Public_Virtual_AbilityID_0;

		// Token: 0x04002458 RID: 9304
		private static readonly IntPtr NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_GameLogBuilder_IHasGameLogs_0;

		// Token: 0x04002459 RID: 9305
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x0400245A RID: 9306
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x0400245B RID: 9307
		private static readonly IntPtr NativeMethodInfoPtr_Targets_Public_Virtual_IEnumerable_1_TargetInformation_Match_Context_0;

		// Token: 0x0400245C RID: 9308
		private static readonly IntPtr NativeMethodInfoPtr_SelectionMode_Public_Virtual_DeferredSelectionMode_Context_0;

		// Token: 0x0400245D RID: 9309
		private static readonly IntPtr NativeMethodInfoPtr_CanRunImmediately_Public_Virtual_Boolean_Context_0;

		// Token: 0x0400245E RID: 9310
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Virtual_IEnumerable_1_Action_WormActiveAbility_WormMatch_Context_0;

		// Token: 0x0400245F RID: 9311
		private static readonly IntPtr NativeMethodInfoPtr_ResumeExecution_Public_Virtual_Int32_WormActiveAbility_Action_Context_0;

		// Token: 0x04002460 RID: 9312
		private static readonly IntPtr NativeMethodInfoPtr_GetConscriptTargets_Private_List_1_WormImperiumPlayable_WormMatch_WormPlayer_0;

		// Token: 0x04002461 RID: 9313
		private static readonly IntPtr NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0;

		// Token: 0x04002462 RID: 9314
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_WormAIChoice_WormAIChoiceContext_0;

		// Token: 0x02000B99 RID: 2969
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.RiseOfIx.ConscriptAbility+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600BD63 RID: 48483 RVA: 0x002EDFA8 File Offset: 0x002EC1A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ConscriptAbility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConscriptAbility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConscriptAbility.__c>.NativeClassPtr);
				ConscriptAbility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConscriptAbility.__c>.NativeClassPtr, "<>9");
				ConscriptAbility.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConscriptAbility.__c>.NativeClassPtr, "<>9__6_0");
				ConscriptAbility.__c.NativeFieldInfoPtr___9__6_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConscriptAbility.__c>.NativeClassPtr, "<>9__6_1");
				ConscriptAbility.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConscriptAbility.__c>.NativeClassPtr, "<>9__11_0");
				ConscriptAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConscriptAbility.__c>.NativeClassPtr, 100680903);
				ConscriptAbility.__c.NativeMethodInfoPtr__Targets_b__6_0_Internal_EntityID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConscriptAbility.__c>.NativeClassPtr, 100680904);
				ConscriptAbility.__c.NativeMethodInfoPtr__Targets_b__6_1_Internal_ReadOnlyAttributes_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConscriptAbility.__c>.NativeClassPtr, 100680905);
				ConscriptAbility.__c.NativeMethodInfoPtr__GetConscriptTargets_b__11_0_Internal_Boolean_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConscriptAbility.__c>.NativeClassPtr, 100680906);
			}

			// Token: 0x0600BD64 RID: 48484 RVA: 0x002EE074 File Offset: 0x002EC274
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConscriptAbility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConscriptAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BD65 RID: 48485 RVA: 0x002EE0B0 File Offset: 0x002EC2B0
			[CallerCount(0)]
			public unsafe EntityID _Targets_b__6_0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConscriptAbility.__c.NativeMethodInfoPtr__Targets_b__6_0_Internal_EntityID_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x0600BD66 RID: 48486 RVA: 0x002EE100 File Offset: 0x002EC300
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247520, XrefRangeEnd = 247540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReadOnlyAttributes _Targets_b__6_1(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConscriptAbility.__c.NativeMethodInfoPtr__Targets_b__6_1_Internal_ReadOnlyAttributes_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr3) : null;
				}
			}

			// Token: 0x0600BD67 RID: 48487 RVA: 0x002EE150 File Offset: 0x002EC350
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247540, XrefRangeEnd = 247549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetConscriptTargets_b__11_0(WormImperiumPlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConscriptAbility.__c.NativeMethodInfoPtr__GetConscriptTargets_b__11_0_Internal_Boolean_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BD68 RID: 48488 RVA: 0x0005854A File Offset: 0x0005674A
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003A97 RID: 14999
			// (get) Token: 0x0600BD69 RID: 48489 RVA: 0x002EE1A0 File Offset: 0x002EC3A0
			// (set) Token: 0x0600BD6A RID: 48490 RVA: 0x00058553 File Offset: 0x00056753
			public unsafe static ConscriptAbility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConscriptAbility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConscriptAbility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConscriptAbility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A98 RID: 15000
			// (get) Token: 0x0600BD6B RID: 48491 RVA: 0x002EE1C8 File Offset: 0x002EC3C8
			// (set) Token: 0x0600BD6C RID: 48492 RVA: 0x00058565 File Offset: 0x00056765
			public unsafe static Func<Entity, EntityID> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConscriptAbility.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConscriptAbility.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A99 RID: 15001
			// (get) Token: 0x0600BD6D RID: 48493 RVA: 0x002EE1F0 File Offset: 0x002EC3F0
			// (set) Token: 0x0600BD6E RID: 48494 RVA: 0x00058577 File Offset: 0x00056777
			public unsafe static Func<Entity, ReadOnlyAttributes> __9__6_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConscriptAbility.__c.NativeFieldInfoPtr___9__6_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, ReadOnlyAttributes>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConscriptAbility.__c.NativeFieldInfoPtr___9__6_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003A9A RID: 15002
			// (get) Token: 0x0600BD6F RID: 48495 RVA: 0x002EE218 File Offset: 0x002EC418
			// (set) Token: 0x0600BD70 RID: 48496 RVA: 0x00058589 File Offset: 0x00056789
			public unsafe static Func<WormImperiumPlayable, bool> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConscriptAbility.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormImperiumPlayable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConscriptAbility.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007701 RID: 30465
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04007702 RID: 30466
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x04007703 RID: 30467
			private static readonly IntPtr NativeFieldInfoPtr___9__6_1;

			// Token: 0x04007704 RID: 30468
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x04007705 RID: 30469
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007706 RID: 30470
			private static readonly IntPtr NativeMethodInfoPtr__Targets_b__6_0_Internal_EntityID_Entity_0;

			// Token: 0x04007707 RID: 30471
			private static readonly IntPtr NativeMethodInfoPtr__Targets_b__6_1_Internal_ReadOnlyAttributes_Entity_0;

			// Token: 0x04007708 RID: 30472
			private static readonly IntPtr NativeMethodInfoPtr__GetConscriptTargets_b__11_0_Internal_Boolean_WormImperiumPlayable_0;
		}

		// Token: 0x02000B9A RID: 2970
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.RiseOfIx.ConscriptAbility+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Object
		{
			// Token: 0x0600BD71 RID: 48497 RVA: 0x002EE240 File Offset: 0x002EC440
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<ConscriptAbility.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConscriptAbility>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConscriptAbility.__c__DisplayClass11_0>.NativeClassPtr);
				ConscriptAbility.__c__DisplayClass11_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConscriptAbility.__c__DisplayClass11_0>.NativeClassPtr, "player");
				ConscriptAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConscriptAbility.__c__DisplayClass11_0>.NativeClassPtr, 100680907);
				ConscriptAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__GetConscriptTargets_b__1_Internal_Boolean_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConscriptAbility.__c__DisplayClass11_0>.NativeClassPtr, 100680908);
			}

			// Token: 0x0600BD72 RID: 48498 RVA: 0x002EE2A8 File Offset: 0x002EC4A8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConscriptAbility.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConscriptAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BD73 RID: 48499 RVA: 0x002EE2E4 File Offset: 0x002EC4E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247549, XrefRangeEnd = 247582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetConscriptTargets_b__1(WormImperiumPlayable card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConscriptAbility.__c__DisplayClass11_0.NativeMethodInfoPtr__GetConscriptTargets_b__1_Internal_Boolean_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BD74 RID: 48500 RVA: 0x0005859B File Offset: 0x0005679B
			public __c__DisplayClass11_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003A9B RID: 15003
			// (get) Token: 0x0600BD75 RID: 48501 RVA: 0x002EE334 File Offset: 0x002EC534
			// (set) Token: 0x0600BD76 RID: 48502 RVA: 0x000585A4 File Offset: 0x000567A4
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility.__c__DisplayClass11_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility.__c__DisplayClass11_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007709 RID: 30473
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x0400770A RID: 30474
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400770B RID: 30475
			private static readonly IntPtr NativeMethodInfoPtr__GetConscriptTargets_b__1_Internal_Boolean_WormImperiumPlayable_0;
		}

		// Token: 0x02000B9B RID: 2971
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.RiseOfIx.ConscriptAbility+<>c__DisplayClass11_1")]
		public sealed class __c__DisplayClass11_1 : Object
		{
			// Token: 0x0600BD77 RID: 48503 RVA: 0x002EE364 File Offset: 0x002EC564
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_1()
			{
				Il2CppClassPointerStore<ConscriptAbility.__c__DisplayClass11_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConscriptAbility>.NativeClassPtr, "<>c__DisplayClass11_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConscriptAbility.__c__DisplayClass11_1>.NativeClassPtr);
				ConscriptAbility.__c__DisplayClass11_1.NativeFieldInfoPtr_card = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConscriptAbility.__c__DisplayClass11_1>.NativeClassPtr, "card");
				ConscriptAbility.__c__DisplayClass11_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConscriptAbility.__c__DisplayClass11_1>.NativeClassPtr, 100680909);
				ConscriptAbility.__c__DisplayClass11_1.NativeMethodInfoPtr__GetConscriptTargets_b__2_Internal_Boolean_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConscriptAbility.__c__DisplayClass11_1>.NativeClassPtr, 100680910);
			}

			// Token: 0x0600BD78 RID: 48504 RVA: 0x002EE3CC File Offset: 0x002EC5CC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConscriptAbility.__c__DisplayClass11_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConscriptAbility.__c__DisplayClass11_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BD79 RID: 48505 RVA: 0x002EE408 File Offset: 0x002EC608
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247582, XrefRangeEnd = 247586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetConscriptTargets_b__2(Factions faction)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref faction;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConscriptAbility.__c__DisplayClass11_1.NativeMethodInfoPtr__GetConscriptTargets_b__2_Internal_Boolean_Factions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BD7A RID: 48506 RVA: 0x000585C3 File Offset: 0x000567C3
			public __c__DisplayClass11_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003A9C RID: 15004
			// (get) Token: 0x0600BD7B RID: 48507 RVA: 0x002EE454 File Offset: 0x002EC654
			// (set) Token: 0x0600BD7C RID: 48508 RVA: 0x000585CC File Offset: 0x000567CC
			public unsafe WormImperiumPlayable card
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility.__c__DisplayClass11_1.NativeFieldInfoPtr_card);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility.__c__DisplayClass11_1.NativeFieldInfoPtr_card), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400770C RID: 30476
			private static readonly IntPtr NativeFieldInfoPtr_card;

			// Token: 0x0400770D RID: 30477
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400770E RID: 30478
			private static readonly IntPtr NativeMethodInfoPtr__GetConscriptTargets_b__2_Internal_Boolean_Factions_0;
		}

		// Token: 0x02000B9C RID: 2972
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.RiseOfIx.ConscriptAbility+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Object
		{
			// Token: 0x0600BD7D RID: 48509 RVA: 0x002EE484 File Offset: 0x002EC684
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<ConscriptAbility.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConscriptAbility>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConscriptAbility.__c__DisplayClass12_0>.NativeClassPtr);
				ConscriptAbility.__c__DisplayClass12_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConscriptAbility.__c__DisplayClass12_0>.NativeClassPtr, "player");
				ConscriptAbility.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConscriptAbility.__c__DisplayClass12_0>.NativeClassPtr, 100680911);
				ConscriptAbility.__c__DisplayClass12_0.NativeMethodInfoPtr__ValueForPlayer_b__0_Internal_AIValueSummer_1_Double_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConscriptAbility.__c__DisplayClass12_0>.NativeClassPtr, 100680912);
			}

			// Token: 0x0600BD7E RID: 48510 RVA: 0x002EE4EC File Offset: 0x002EC6EC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConscriptAbility.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConscriptAbility.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BD7F RID: 48511 RVA: 0x002EE528 File Offset: 0x002EC728
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AIValueSummer<double> _ValueForPlayer_b__0(WormImperiumPlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConscriptAbility.__c__DisplayClass12_0.NativeMethodInfoPtr__ValueForPlayer_b__0_Internal_AIValueSummer_1_Double_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
				}
			}

			// Token: 0x0600BD80 RID: 48512 RVA: 0x000585EB File Offset: 0x000567EB
			public __c__DisplayClass12_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003A9D RID: 15005
			// (get) Token: 0x0600BD81 RID: 48513 RVA: 0x002EE578 File Offset: 0x002EC778
			// (set) Token: 0x0600BD82 RID: 48514 RVA: 0x000585F4 File Offset: 0x000567F4
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility.__c__DisplayClass12_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility.__c__DisplayClass12_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400770F RID: 30479
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04007710 RID: 30480
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007711 RID: 30481
			private static readonly IntPtr NativeMethodInfoPtr__ValueForPlayer_b__0_Internal_AIValueSummer_1_Double_WormImperiumPlayable_0;
		}

		// Token: 0x02000B9D RID: 2973
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.RiseOfIx.ConscriptAbility+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Object
		{
			// Token: 0x0600BD83 RID: 48515 RVA: 0x002EE5A8 File Offset: 0x002EC7A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<ConscriptAbility.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConscriptAbility>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConscriptAbility.__c__DisplayClass9_0>.NativeClassPtr);
				ConscriptAbility.__c__DisplayClass9_0.NativeFieldInfoPtr_chosenCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConscriptAbility.__c__DisplayClass9_0>.NativeClassPtr, "chosenCard");
				ConscriptAbility.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConscriptAbility.__c__DisplayClass9_0>.NativeClassPtr, 100680913);
				ConscriptAbility.__c__DisplayClass9_0.NativeMethodInfoPtr__BeginExecution_b__0_Internal_GameLogBuilder_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConscriptAbility.__c__DisplayClass9_0>.NativeClassPtr, 100680914);
			}

			// Token: 0x0600BD84 RID: 48516 RVA: 0x002EE610 File Offset: 0x002EC810
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConscriptAbility.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConscriptAbility.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BD85 RID: 48517 RVA: 0x002EE64C File Offset: 0x002EC84C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247586, XrefRangeEnd = 247591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GameLogBuilder _BeginExecution_b__0(GameLogBuilder _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConscriptAbility.__c__DisplayClass9_0.NativeMethodInfoPtr__BeginExecution_b__0_Internal_GameLogBuilder_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x0600BD86 RID: 48518 RVA: 0x00058613 File Offset: 0x00056813
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003A9E RID: 15006
			// (get) Token: 0x0600BD87 RID: 48519 RVA: 0x002EE69C File Offset: 0x002EC89C
			// (set) Token: 0x0600BD88 RID: 48520 RVA: 0x0005861C File Offset: 0x0005681C
			public unsafe WormImperiumPlayable chosenCard
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility.__c__DisplayClass9_0.NativeFieldInfoPtr_chosenCard);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility.__c__DisplayClass9_0.NativeFieldInfoPtr_chosenCard), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007712 RID: 30482
			private static readonly IntPtr NativeFieldInfoPtr_chosenCard;

			// Token: 0x04007713 RID: 30483
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007714 RID: 30484
			private static readonly IntPtr NativeMethodInfoPtr__BeginExecution_b__0_Internal_GameLogBuilder_GameLogBuilder_0;
		}

		// Token: 0x02000B9E RID: 2974
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.RiseOfIx.ConscriptAbility+<BeginExecution>d__9")]
		public sealed class _BeginExecution_d__9 : Object
		{
			// Token: 0x0600BD89 RID: 48521 RVA: 0x002EE6CC File Offset: 0x002EC8CC
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginExecution_d__9()
			{
				Il2CppClassPointerStore<ConscriptAbility._BeginExecution_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConscriptAbility>.NativeClassPtr, "<BeginExecution>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConscriptAbility._BeginExecution_d__9>.NativeClassPtr);
				ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConscriptAbility._BeginExecution_d__9>.NativeClassPtr, "<>1__state");
				ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConscriptAbility._BeginExecution_d__9>.NativeClassPtr, "<>2__current");
				ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConscriptAbility._BeginExecution_d__9>.NativeClassPtr, "<>l__initialThreadId");
				ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConscriptAbility._BeginExecution_d__9>.NativeClassPtr, "activeAbility");
				ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConscriptAbility._BeginExecution_d__9>.NativeClassPtr, "<>3__activeAbility");
				ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConscriptAbility._BeginExecution_d__9>.NativeClassPtr, "context");
				ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConscriptAbility._BeginExecution_d__9>.NativeClassPtr, "<>3__context");
				ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConscriptAbility._BeginExecution_d__9>.NativeClassPtr, "match");
				ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConscriptAbility._BeginExecution_d__9>.NativeClassPtr, "<>3__match");
				ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConscriptAbility._BeginExecution_d__9>.NativeClassPtr, "<>4__this");
				ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConscriptAbility._BeginExecution_d__9>.NativeClassPtr, "<>8__1");
				ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConscriptAbility._BeginExecution_d__9>.NativeClassPtr, "<player>5__2");
				ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr__trq_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConscriptAbility._BeginExecution_d__9>.NativeClassPtr, "<trq>5__3");
				ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr__sequenceHelper_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConscriptAbility._BeginExecution_d__9>.NativeClassPtr, "<sequenceHelper>5__4");
				ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr__toArea_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConscriptAbility._BeginExecution_d__9>.NativeClassPtr, "<toArea>5__5");
				ConscriptAbility._BeginExecution_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConscriptAbility._BeginExecution_d__9>.NativeClassPtr, 100680915);
				ConscriptAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConscriptAbility._BeginExecution_d__9>.NativeClassPtr, 100680916);
				ConscriptAbility._BeginExecution_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConscriptAbility._BeginExecution_d__9>.NativeClassPtr, 100680917);
				ConscriptAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConscriptAbility._BeginExecution_d__9>.NativeClassPtr, 100680918);
				ConscriptAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConscriptAbility._BeginExecution_d__9>.NativeClassPtr, 100680919);
				ConscriptAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConscriptAbility._BeginExecution_d__9>.NativeClassPtr, 100680920);
				ConscriptAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConscriptAbility._BeginExecution_d__9>.NativeClassPtr, 100680921);
				ConscriptAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConscriptAbility._BeginExecution_d__9>.NativeClassPtr, 100680922);
			}

			// Token: 0x0600BD8A RID: 48522 RVA: 0x002EE8C4 File Offset: 0x002ECAC4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginExecution_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConscriptAbility._BeginExecution_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConscriptAbility._BeginExecution_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600BD8B RID: 48523 RVA: 0x002EE90C File Offset: 0x002ECB0C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConscriptAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BD8C RID: 48524 RVA: 0x002EE940 File Offset: 0x002ECB40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247591, XrefRangeEnd = 247623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConscriptAbility._BeginExecution_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003AAE RID: 15022
			// (get) Token: 0x0600BD8D RID: 48525 RVA: 0x002EE97C File Offset: 0x002ECB7C
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConscriptAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600BD8E RID: 48526 RVA: 0x002EE9BC File Offset: 0x002ECBBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247623, XrefRangeEnd = 247628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConscriptAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003AAF RID: 15023
			// (get) Token: 0x0600BD8F RID: 48527 RVA: 0x002EE9F0 File Offset: 0x002ECBF0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConscriptAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BD90 RID: 48528 RVA: 0x002EEA30 File Offset: 0x002ECC30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247628, XrefRangeEnd = 247639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConscriptAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600BD91 RID: 48529 RVA: 0x002EEA70 File Offset: 0x002ECC70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConscriptAbility._BeginExecution_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600BD92 RID: 48530 RVA: 0x0005863B File Offset: 0x0005683B
			public _BeginExecution_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003A9F RID: 15007
			// (get) Token: 0x0600BD93 RID: 48531 RVA: 0x002EEAB0 File Offset: 0x002ECCB0
			// (set) Token: 0x0600BD94 RID: 48532 RVA: 0x00058644 File Offset: 0x00056844
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003AA0 RID: 15008
			// (get) Token: 0x0600BD95 RID: 48533 RVA: 0x002EEAD8 File Offset: 0x002ECCD8
			// (set) Token: 0x0600BD96 RID: 48534 RVA: 0x0005865F File Offset: 0x0005685F
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003AA1 RID: 15009
			// (get) Token: 0x0600BD97 RID: 48535 RVA: 0x002EEB08 File Offset: 0x002ECD08
			// (set) Token: 0x0600BD98 RID: 48536 RVA: 0x0005867E File Offset: 0x0005687E
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17003AA2 RID: 15010
			// (get) Token: 0x0600BD99 RID: 48537 RVA: 0x002EEB30 File Offset: 0x002ECD30
			// (set) Token: 0x0600BD9A RID: 48538 RVA: 0x00058699 File Offset: 0x00056899
			public unsafe WormActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr_activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr_activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003AA3 RID: 15011
			// (get) Token: 0x0600BD9B RID: 48539 RVA: 0x002EEB60 File Offset: 0x002ECD60
			// (set) Token: 0x0600BD9C RID: 48540 RVA: 0x000586B8 File Offset: 0x000568B8
			public unsafe WormActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__activeAbility);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__activeAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003AA4 RID: 15012
			// (get) Token: 0x0600BD9D RID: 48541 RVA: 0x002EEB90 File Offset: 0x002ECD90
			// (set) Token: 0x0600BD9E RID: 48542 RVA: 0x000586D7 File Offset: 0x000568D7
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003AA5 RID: 15013
			// (get) Token: 0x0600BD9F RID: 48543 RVA: 0x002EEBC0 File Offset: 0x002ECDC0
			// (set) Token: 0x0600BDA0 RID: 48544 RVA: 0x000586F6 File Offset: 0x000568F6
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003AA6 RID: 15014
			// (get) Token: 0x0600BDA1 RID: 48545 RVA: 0x002EEBF0 File Offset: 0x002ECDF0
			// (set) Token: 0x0600BDA2 RID: 48546 RVA: 0x00058715 File Offset: 0x00056915
			public unsafe WormMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003AA7 RID: 15015
			// (get) Token: 0x0600BDA3 RID: 48547 RVA: 0x002EEC20 File Offset: 0x002ECE20
			// (set) Token: 0x0600BDA4 RID: 48548 RVA: 0x00058734 File Offset: 0x00056934
			public unsafe WormMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003AA8 RID: 15016
			// (get) Token: 0x0600BDA5 RID: 48549 RVA: 0x002EEC50 File Offset: 0x002ECE50
			// (set) Token: 0x0600BDA6 RID: 48550 RVA: 0x00058753 File Offset: 0x00056953
			public unsafe ConscriptAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConscriptAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003AA9 RID: 15017
			// (get) Token: 0x0600BDA7 RID: 48551 RVA: 0x002EEC80 File Offset: 0x002ECE80
			// (set) Token: 0x0600BDA8 RID: 48552 RVA: 0x00058772 File Offset: 0x00056972
			public unsafe ConscriptAbility.__c__DisplayClass9_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConscriptAbility.__c__DisplayClass9_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003AAA RID: 15018
			// (get) Token: 0x0600BDA9 RID: 48553 RVA: 0x002EECB0 File Offset: 0x002ECEB0
			// (set) Token: 0x0600BDAA RID: 48554 RVA: 0x00058791 File Offset: 0x00056991
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003AAB RID: 15019
			// (get) Token: 0x0600BDAB RID: 48555 RVA: 0x002EECE0 File Offset: 0x002ECEE0
			// (set) Token: 0x0600BDAC RID: 48556 RVA: 0x000587B0 File Offset: 0x000569B0
			public unsafe TargetResponseQueue _trq_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr__trq_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TargetResponseQueue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr__trq_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003AAC RID: 15020
			// (get) Token: 0x0600BDAD RID: 48557 RVA: 0x002EED10 File Offset: 0x002ECF10
			// (set) Token: 0x0600BDAE RID: 48558 RVA: 0x000587CF File Offset: 0x000569CF
			public unsafe SequenceHelper _sequenceHelper_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr__sequenceHelper_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr__sequenceHelper_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003AAD RID: 15021
			// (get) Token: 0x0600BDAF RID: 48559 RVA: 0x002EED40 File Offset: 0x002ECF40
			// (set) Token: 0x0600BDB0 RID: 48560 RVA: 0x000587EE File Offset: 0x000569EE
			public unsafe CardToAreas _toArea_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr__toArea_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._BeginExecution_d__9.NativeFieldInfoPtr__toArea_5__5)) = value;
				}
			}

			// Token: 0x04007715 RID: 30485
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007716 RID: 30486
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007717 RID: 30487
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04007718 RID: 30488
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04007719 RID: 30489
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x0400771A RID: 30490
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x0400771B RID: 30491
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x0400771C RID: 30492
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x0400771D RID: 30493
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x0400771E RID: 30494
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400771F RID: 30495
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04007720 RID: 30496
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x04007721 RID: 30497
			private static readonly IntPtr NativeFieldInfoPtr__trq_5__3;

			// Token: 0x04007722 RID: 30498
			private static readonly IntPtr NativeFieldInfoPtr__sequenceHelper_5__4;

			// Token: 0x04007723 RID: 30499
			private static readonly IntPtr NativeFieldInfoPtr__toArea_5__5;

			// Token: 0x04007724 RID: 30500
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04007725 RID: 30501
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007726 RID: 30502
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04007727 RID: 30503
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04007728 RID: 30504
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007729 RID: 30505
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400772A RID: 30506
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x0400772B RID: 30507
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000B9F RID: 2975
		[ObfuscatedName("worm.canis.abilities.ActivatedAbilities.RiseOfIx.ConscriptAbility+<Targets>d__6")]
		public sealed class _Targets_d__6 : Object
		{
			// Token: 0x0600BDB1 RID: 48561 RVA: 0x002EED68 File Offset: 0x002ECF68
			// Note: this type is marked as 'beforefieldinit'.
			static _Targets_d__6()
			{
				Il2CppClassPointerStore<ConscriptAbility._Targets_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConscriptAbility>.NativeClassPtr, "<Targets>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConscriptAbility._Targets_d__6>.NativeClassPtr);
				ConscriptAbility._Targets_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConscriptAbility._Targets_d__6>.NativeClassPtr, "<>1__state");
				ConscriptAbility._Targets_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConscriptAbility._Targets_d__6>.NativeClassPtr, "<>2__current");
				ConscriptAbility._Targets_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConscriptAbility._Targets_d__6>.NativeClassPtr, "<>l__initialThreadId");
				ConscriptAbility._Targets_d__6.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConscriptAbility._Targets_d__6>.NativeClassPtr, "context");
				ConscriptAbility._Targets_d__6.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConscriptAbility._Targets_d__6>.NativeClassPtr, "<>3__context");
				ConscriptAbility._Targets_d__6.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConscriptAbility._Targets_d__6>.NativeClassPtr, "match");
				ConscriptAbility._Targets_d__6.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConscriptAbility._Targets_d__6>.NativeClassPtr, "<>3__match");
				ConscriptAbility._Targets_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConscriptAbility._Targets_d__6>.NativeClassPtr, "<>4__this");
				ConscriptAbility._Targets_d__6.NativeFieldInfoPtr__player_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConscriptAbility._Targets_d__6>.NativeClassPtr, "<player>5__2");
				ConscriptAbility._Targets_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConscriptAbility._Targets_d__6>.NativeClassPtr, 100680923);
				ConscriptAbility._Targets_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConscriptAbility._Targets_d__6>.NativeClassPtr, 100680924);
				ConscriptAbility._Targets_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConscriptAbility._Targets_d__6>.NativeClassPtr, 100680925);
				ConscriptAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConscriptAbility._Targets_d__6>.NativeClassPtr, 100680926);
				ConscriptAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConscriptAbility._Targets_d__6>.NativeClassPtr, 100680927);
				ConscriptAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConscriptAbility._Targets_d__6>.NativeClassPtr, 100680928);
				ConscriptAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConscriptAbility._Targets_d__6>.NativeClassPtr, 100680929);
				ConscriptAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConscriptAbility._Targets_d__6>.NativeClassPtr, 100680930);
			}

			// Token: 0x0600BDB2 RID: 48562 RVA: 0x002EEEE8 File Offset: 0x002ED0E8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Targets_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConscriptAbility._Targets_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConscriptAbility._Targets_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600BDB3 RID: 48563 RVA: 0x002EEF30 File Offset: 0x002ED130
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConscriptAbility._Targets_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BDB4 RID: 48564 RVA: 0x002EEF64 File Offset: 0x002ED164
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247639, XrefRangeEnd = 247726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConscriptAbility._Targets_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003AB9 RID: 15033
			// (get) Token: 0x0600BDB5 RID: 48565 RVA: 0x002EEFA0 File Offset: 0x002ED1A0
			public unsafe TargetInformation System.Collections.Generic.IEnumerator<Networking.selection.targetinformation.TargetInformation>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConscriptAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetInformation>(intPtr3) : null;
				}
			}

			// Token: 0x0600BDB6 RID: 48566 RVA: 0x002EEFE0 File Offset: 0x002ED1E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247726, XrefRangeEnd = 247731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConscriptAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003ABA RID: 15034
			// (get) Token: 0x0600BDB7 RID: 48567 RVA: 0x002EF014 File Offset: 0x002ED214
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConscriptAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BDB8 RID: 48568 RVA: 0x002EF054 File Offset: 0x002ED254
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247731, XrefRangeEnd = 247741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TargetInformation> System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConscriptAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TargetInformation>>(intPtr3) : null;
			}

			// Token: 0x0600BDB9 RID: 48569 RVA: 0x002EF094 File Offset: 0x002ED294
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConscriptAbility._Targets_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600BDBA RID: 48570 RVA: 0x00058809 File Offset: 0x00056A09
			public _Targets_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17003AB0 RID: 15024
			// (get) Token: 0x0600BDBB RID: 48571 RVA: 0x002EF0D4 File Offset: 0x002ED2D4
			// (set) Token: 0x0600BDBC RID: 48572 RVA: 0x00058812 File Offset: 0x00056A12
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._Targets_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._Targets_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003AB1 RID: 15025
			// (get) Token: 0x0600BDBD RID: 48573 RVA: 0x002EF0FC File Offset: 0x002ED2FC
			// (set) Token: 0x0600BDBE RID: 48574 RVA: 0x0005882D File Offset: 0x00056A2D
			public unsafe TargetInformation __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._Targets_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TargetInformation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._Targets_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003AB2 RID: 15026
			// (get) Token: 0x0600BDBF RID: 48575 RVA: 0x002EF12C File Offset: 0x002ED32C
			// (set) Token: 0x0600BDC0 RID: 48576 RVA: 0x0005884C File Offset: 0x00056A4C
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._Targets_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._Targets_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17003AB3 RID: 15027
			// (get) Token: 0x0600BDC1 RID: 48577 RVA: 0x002EF154 File Offset: 0x002ED354
			// (set) Token: 0x0600BDC2 RID: 48578 RVA: 0x00058867 File Offset: 0x00056A67
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._Targets_d__6.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._Targets_d__6.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003AB4 RID: 15028
			// (get) Token: 0x0600BDC3 RID: 48579 RVA: 0x002EF184 File Offset: 0x002ED384
			// (set) Token: 0x0600BDC4 RID: 48580 RVA: 0x00058886 File Offset: 0x00056A86
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._Targets_d__6.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._Targets_d__6.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003AB5 RID: 15029
			// (get) Token: 0x0600BDC5 RID: 48581 RVA: 0x002EF1B4 File Offset: 0x002ED3B4
			// (set) Token: 0x0600BDC6 RID: 48582 RVA: 0x000588A5 File Offset: 0x00056AA5
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._Targets_d__6.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._Targets_d__6.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003AB6 RID: 15030
			// (get) Token: 0x0600BDC7 RID: 48583 RVA: 0x002EF1E4 File Offset: 0x002ED3E4
			// (set) Token: 0x0600BDC8 RID: 48584 RVA: 0x000588C4 File Offset: 0x00056AC4
			public unsafe Match __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._Targets_d__6.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._Targets_d__6.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003AB7 RID: 15031
			// (get) Token: 0x0600BDC9 RID: 48585 RVA: 0x002EF214 File Offset: 0x002ED414
			// (set) Token: 0x0600BDCA RID: 48586 RVA: 0x000588E3 File Offset: 0x00056AE3
			public unsafe ConscriptAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._Targets_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConscriptAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._Targets_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003AB8 RID: 15032
			// (get) Token: 0x0600BDCB RID: 48587 RVA: 0x002EF244 File Offset: 0x002ED444
			// (set) Token: 0x0600BDCC RID: 48588 RVA: 0x00058902 File Offset: 0x00056B02
			public unsafe WormPlayer _player_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._Targets_d__6.NativeFieldInfoPtr__player_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConscriptAbility._Targets_d__6.NativeFieldInfoPtr__player_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400772C RID: 30508
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400772D RID: 30509
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400772E RID: 30510
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400772F RID: 30511
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04007730 RID: 30512
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x04007731 RID: 30513
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04007732 RID: 30514
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04007733 RID: 30515
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007734 RID: 30516
			private static readonly IntPtr NativeFieldInfoPtr__player_5__2;

			// Token: 0x04007735 RID: 30517
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04007736 RID: 30518
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007737 RID: 30519
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04007738 RID: 30520
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetinformation_TargetInformation__get_Current_Private_Virtual_Final_New_get_TargetInformation_0;

			// Token: 0x04007739 RID: 30521
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400773A RID: 30522
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400773B RID: 30523
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetinformation_TargetInformation__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetInformation_0;

			// Token: 0x0400773C RID: 30524
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
