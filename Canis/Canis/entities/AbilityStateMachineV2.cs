using System;
using Canis.actions;
using Canis.context;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.entities
{
	// Token: 0x020000CD RID: 205
	public class AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition> : AbilityStateBindingsV2<TMatch, TActiveAbility, TAbilityDefinition, StateBehaviorV2<TMatch, TActiveAbility, TAbilityDefinition>> where TMatch : Match where TActiveAbility : ActiveAbility<TMatch, TAbilityDefinition> where TAbilityDefinition : AbilityDefinitionForGame<TMatch>
	{
		// Token: 0x0600093B RID: 2363 RVA: 0x0003FEA8 File Offset: 0x0003E0A8
		// Note: this type is marked as 'beforefieldinit'.
		static AbilityStateMachineV2()
		{
			Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "AbilityStateMachineV2`3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TActiveAbility>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAbilityDefinition>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr);
			AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeFieldInfoPtr_stateComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, "stateComparer");
			AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_RunStateMachine_Private_IEnumerable_1_Action_TActiveAbility_TMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665212);
			AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_RunStateMachineBase_Public_Virtual_Final_New_IEnumerable_1_Action_ActiveAbility_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665213);
			AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_ExecuteState_Private_IEnumerable_1_Action_Int32_TActiveAbility_TMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665214);
			AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_ResumeExecutionBase_Public_Virtual_Final_New_Int32_ActiveAbility_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665215);
			AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_ResumeExecution_Private_Int32_TActiveAbility_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665216);
			AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_get_Ordering_Public_Virtual_Final_New_get_IComparer_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665217);
			AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665218);
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x0003FFD8 File Offset: 0x0003E1D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Canis.actions.Action> RunStateMachine(TActiveAbility activeAbility, TMatch match, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TActiveAbility).IsValueType)
				{
					TActiveAbility tactiveAbility = activeAbility;
					intPtr = ((tactiveAbility is string) ? IL2CPP.ManagedStringToIl2Cpp(tactiveAbility as string) : IL2CPP.Il2CppObjectBaseToPtr(tactiveAbility as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref activeAbility;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(TMatch).IsValueType)
			{
				TMatch tmatch = match;
				intPtr2 = ((tmatch is string) ? IL2CPP.ManagedStringToIl2Cpp(tmatch as string) : IL2CPP.Il2CppObjectBaseToPtr(tmatch as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref match;
			}
			ptr3 = intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_RunStateMachine_Private_IEnumerable_1_Action_TActiveAbility_TMatch_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr3;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr5) : null;
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x000400B8 File Offset: 0x0003E2B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 561644, RefRangeEnd = 561646, XrefRangeStart = 561644, XrefRangeEnd = 561646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<Canis.actions.Action> RunStateMachineBase(ActiveAbility activeAbility, Match match, Context context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_RunStateMachineBase_Public_Virtual_Final_New_IEnumerable_1_Action_ActiveAbility_Match_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x0004012C File Offset: 0x0003E32C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 561653, RefRangeEnd = 561655, XrefRangeStart = 561653, XrefRangeEnd = 561655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Canis.actions.Action> ExecuteState(int state, TActiveAbility activeAbility, TMatch match, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TActiveAbility).IsValueType)
			{
				TActiveAbility tactiveAbility = activeAbility;
				intPtr = ((tactiveAbility is string) ? IL2CPP.ManagedStringToIl2Cpp(tactiveAbility as string) : IL2CPP.Il2CppObjectBaseToPtr(tactiveAbility as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref activeAbility;
			}
			ptr2 = intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(TMatch).IsValueType)
			{
				TMatch tmatch = match;
				intPtr2 = ((tmatch is string) ? IL2CPP.ManagedStringToIl2Cpp(tmatch as string) : IL2CPP.Il2CppObjectBaseToPtr(tmatch as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref match;
			}
			ptr3 = intPtr2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_ExecuteState_Private_IEnumerable_1_Action_Int32_TActiveAbility_TMatch_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr3;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr5) : null;
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x0004021C File Offset: 0x0003E41C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 562159, XrefRangeEnd = 562163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int ResumeExecutionBase(ActiveAbility activeAbility, Canis.actions.Action returningAction, Context context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_ResumeExecutionBase_Public_Virtual_Final_New_Int32_ActiveAbility_Action_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x00040290 File Offset: 0x0003E490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 562163, XrefRangeEnd = 562165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ResumeExecution(TActiveAbility activeAbility, Canis.actions.Action returningAction, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TActiveAbility).IsValueType)
				{
					TActiveAbility tactiveAbility = activeAbility;
					intPtr = ((tactiveAbility is string) ? IL2CPP.ManagedStringToIl2Cpp(tactiveAbility as string) : IL2CPP.Il2CppObjectBaseToPtr(tactiveAbility as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref activeAbility;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(returningAction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_ResumeExecution_Private_Int32_TActiveAbility_Action_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x00040338 File Offset: 0x0003E538
		public unsafe virtual IComparer<int> Ordering
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 562165, XrefRangeEnd = 562167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_get_Ordering_Public_Virtual_Final_New_get_IComparer_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IComparer<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x00040378 File Offset: 0x0003E578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 562167, XrefRangeEnd = 562168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AbilityStateMachineV2()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x000058BC File Offset: 0x00003ABC
		public AbilityStateMachineV2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000944 RID: 2372 RVA: 0x000403B4 File Offset: 0x0003E5B4
		// (set) Token: 0x06000945 RID: 2373 RVA: 0x000058C5 File Offset: 0x00003AC5
		public unsafe static IComparer<int> stateComparer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeFieldInfoPtr_stateComparer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IComparer<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeFieldInfoPtr_stateComparer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400063F RID: 1599
		private static readonly IntPtr NativeFieldInfoPtr_stateComparer;

		// Token: 0x04000640 RID: 1600
		private static readonly IntPtr NativeMethodInfoPtr_RunStateMachine_Private_IEnumerable_1_Action_TActiveAbility_TMatch_Context_0;

		// Token: 0x04000641 RID: 1601
		private static readonly IntPtr NativeMethodInfoPtr_RunStateMachineBase_Public_Virtual_Final_New_IEnumerable_1_Action_ActiveAbility_Match_Context_0;

		// Token: 0x04000642 RID: 1602
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteState_Private_IEnumerable_1_Action_Int32_TActiveAbility_TMatch_Context_0;

		// Token: 0x04000643 RID: 1603
		private static readonly IntPtr NativeMethodInfoPtr_ResumeExecutionBase_Public_Virtual_Final_New_Int32_ActiveAbility_Action_Context_0;

		// Token: 0x04000644 RID: 1604
		private static readonly IntPtr NativeMethodInfoPtr_ResumeExecution_Private_Int32_TActiveAbility_Action_Context_0;

		// Token: 0x04000645 RID: 1605
		private static readonly IntPtr NativeMethodInfoPtr_get_Ordering_Public_Virtual_Final_New_get_IComparer_1_Int32_0;

		// Token: 0x04000646 RID: 1606
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200030E RID: 782
		[ObfuscatedName("Canis.entities.AbilityStateMachineV2`3+<ExecuteState>d__2")]
		public sealed class _ExecuteState_d__2 : Object
		{
			// Token: 0x06002057 RID: 8279 RVA: 0x00093EE8 File Offset: 0x000920E8
			// Note: this type is marked as 'beforefieldinit'.
			static _ExecuteState_d__2()
			{
				Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, "<ExecuteState>d__2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TActiveAbility>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAbilityDefinition>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr);
				AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr, "<>1__state");
				AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr, "<>2__current");
				AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr, "<>l__initialThreadId");
				AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr, "<>4__this");
				AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr, "state");
				AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___3__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr, "<>3__state");
				AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr, "activeAbility");
				AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr, "<>3__activeAbility");
				AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr, "match");
				AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr, "<>3__match");
				AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr, "context");
				AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr, "<>3__context");
				AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr, 100665220);
				AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr, 100665221);
				AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr, 100665222);
				AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr, 100665223);
				AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr, 100665224);
				AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr, 100665225);
				AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr, 100665226);
				AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr, 100665227);
			}

			// Token: 0x06002058 RID: 8280 RVA: 0x00094104 File Offset: 0x00092304
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ExecuteState_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002059 RID: 8281 RVA: 0x0009414C File Offset: 0x0009234C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600205A RID: 8282 RVA: 0x00094180 File Offset: 0x00092380
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 562117, XrefRangeEnd = 562120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170007BA RID: 1978
			// (get) Token: 0x0600205B RID: 8283 RVA: 0x000941BC File Offset: 0x000923BC
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600205C RID: 8284 RVA: 0x000941FC File Offset: 0x000923FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170007BB RID: 1979
			// (get) Token: 0x0600205D RID: 8285 RVA: 0x00094230 File Offset: 0x00092430
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600205E RID: 8286 RVA: 0x00094270 File Offset: 0x00092470
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600205F RID: 8287 RVA: 0x000942B0 File Offset: 0x000924B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 562120, XrefRangeEnd = 562130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002060 RID: 8288 RVA: 0x0000F871 File Offset: 0x0000DA71
			public _ExecuteState_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007AE RID: 1966
			// (get) Token: 0x06002061 RID: 8289 RVA: 0x000942F0 File Offset: 0x000924F0
			// (set) Token: 0x06002062 RID: 8290 RVA: 0x0000F87A File Offset: 0x0000DA7A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007AF RID: 1967
			// (get) Token: 0x06002063 RID: 8291 RVA: 0x00094318 File Offset: 0x00092518
			// (set) Token: 0x06002064 RID: 8292 RVA: 0x0000F895 File Offset: 0x0000DA95
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007B0 RID: 1968
			// (get) Token: 0x06002065 RID: 8293 RVA: 0x00094348 File Offset: 0x00092548
			// (set) Token: 0x06002066 RID: 8294 RVA: 0x0000F8B4 File Offset: 0x0000DAB4
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170007B1 RID: 1969
			// (get) Token: 0x06002067 RID: 8295 RVA: 0x00094370 File Offset: 0x00092570
			// (set) Token: 0x06002068 RID: 8296 RVA: 0x0000F8CF File Offset: 0x0000DACF
			public unsafe AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007B2 RID: 1970
			// (get) Token: 0x06002069 RID: 8297 RVA: 0x000943A0 File Offset: 0x000925A0
			// (set) Token: 0x0600206A RID: 8298 RVA: 0x0000F8EE File Offset: 0x0000DAEE
			public unsafe int state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr_state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr_state)) = value;
				}
			}

			// Token: 0x170007B3 RID: 1971
			// (get) Token: 0x0600206B RID: 8299 RVA: 0x000943C8 File Offset: 0x000925C8
			// (set) Token: 0x0600206C RID: 8300 RVA: 0x0000F909 File Offset: 0x0000DB09
			public unsafe int __3__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___3__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___3__state)) = value;
				}
			}

			// Token: 0x170007B4 RID: 1972
			// (get) Token: 0x0600206D RID: 8301 RVA: 0x000943F0 File Offset: 0x000925F0
			// (set) Token: 0x0600206E RID: 8302 RVA: 0x00094418 File Offset: 0x00092618
			public unsafe TActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr_activeAbility);
					return IL2CPP.PointerToValueGeneric<TActiveAbility>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr_activeAbility);
					Type typeFromHandle = typeof(TActiveAbility);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x170007B5 RID: 1973
			// (get) Token: 0x0600206F RID: 8303 RVA: 0x000944C0 File Offset: 0x000926C0
			// (set) Token: 0x06002070 RID: 8304 RVA: 0x000944E8 File Offset: 0x000926E8
			public unsafe TActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___3__activeAbility);
					return IL2CPP.PointerToValueGeneric<TActiveAbility>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___3__activeAbility);
					Type typeFromHandle = typeof(TActiveAbility);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x170007B6 RID: 1974
			// (get) Token: 0x06002071 RID: 8305 RVA: 0x00094590 File Offset: 0x00092790
			// (set) Token: 0x06002072 RID: 8306 RVA: 0x000945B8 File Offset: 0x000927B8
			public unsafe TMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr_match);
					return IL2CPP.PointerToValueGeneric<TMatch>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr_match);
					Type typeFromHandle = typeof(TMatch);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x170007B7 RID: 1975
			// (get) Token: 0x06002073 RID: 8307 RVA: 0x00094660 File Offset: 0x00092860
			// (set) Token: 0x06002074 RID: 8308 RVA: 0x00094688 File Offset: 0x00092888
			public unsafe TMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___3__match);
					return IL2CPP.PointerToValueGeneric<TMatch>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___3__match);
					Type typeFromHandle = typeof(TMatch);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x170007B8 RID: 1976
			// (get) Token: 0x06002075 RID: 8309 RVA: 0x00094730 File Offset: 0x00092930
			// (set) Token: 0x06002076 RID: 8310 RVA: 0x0000F924 File Offset: 0x0000DB24
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007B9 RID: 1977
			// (get) Token: 0x06002077 RID: 8311 RVA: 0x00094760 File Offset: 0x00092960
			// (set) Token: 0x06002078 RID: 8312 RVA: 0x0000F943 File Offset: 0x0000DB43
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001461 RID: 5217
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001462 RID: 5218
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001463 RID: 5219
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001464 RID: 5220
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001465 RID: 5221
			private static readonly IntPtr NativeFieldInfoPtr_state;

			// Token: 0x04001466 RID: 5222
			private static readonly IntPtr NativeFieldInfoPtr___3__state;

			// Token: 0x04001467 RID: 5223
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04001468 RID: 5224
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x04001469 RID: 5225
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x0400146A RID: 5226
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x0400146B RID: 5227
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x0400146C RID: 5228
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x0400146D RID: 5229
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400146E RID: 5230
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400146F RID: 5231
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001470 RID: 5232
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001471 RID: 5233
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001472 RID: 5234
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001473 RID: 5235
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001474 RID: 5236
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200030F RID: 783
		[ObfuscatedName("Canis.entities.AbilityStateMachineV2`3+<RunStateMachine>d__0")]
		public sealed class _RunStateMachine_d__0 : Object
		{
			// Token: 0x06002079 RID: 8313 RVA: 0x00094790 File Offset: 0x00092990
			// Note: this type is marked as 'beforefieldinit'.
			static _RunStateMachine_d__0()
			{
				Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, "<RunStateMachine>d__0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TActiveAbility>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAbilityDefinition>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr);
				AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr, "<>1__state");
				AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr, "<>2__current");
				AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr, "<>l__initialThreadId");
				AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr, "<>4__this");
				AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr, "activeAbility");
				AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr, "<>3__activeAbility");
				AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr, "match");
				AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr, "<>3__match");
				AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr, "context");
				AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr, "<>3__context");
				AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr, "<>7__wrap1");
				AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr, 100665228);
				AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr, 100665229);
				AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr, 100665230);
				AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr, 100665231);
				AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr, 100665232);
				AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr, 100665233);
				AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr, 100665234);
				AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr, 100665235);
				AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr, 100665236);
			}

			// Token: 0x0600207A RID: 8314 RVA: 0x000949AC File Offset: 0x00092BAC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RunStateMachine_d__0(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600207B RID: 8315 RVA: 0x000949F4 File Offset: 0x00092BF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 562130, XrefRangeEnd = 562135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600207C RID: 8316 RVA: 0x00094A28 File Offset: 0x00092C28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 562135, XrefRangeEnd = 562156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600207D RID: 8317 RVA: 0x00094A64 File Offset: 0x00092C64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 562156, XrefRangeEnd = 562159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170007C7 RID: 1991
			// (get) Token: 0x0600207E RID: 8318 RVA: 0x00094A98 File Offset: 0x00092C98
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600207F RID: 8319 RVA: 0x00094AD8 File Offset: 0x00092CD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170007C8 RID: 1992
			// (get) Token: 0x06002080 RID: 8320 RVA: 0x00094B0C File Offset: 0x00092D0C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002081 RID: 8321 RVA: 0x00094B4C File Offset: 0x00092D4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06002082 RID: 8322 RVA: 0x00094B8C File Offset: 0x00092D8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002083 RID: 8323 RVA: 0x0000F962 File Offset: 0x0000DB62
			public _RunStateMachine_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007BC RID: 1980
			// (get) Token: 0x06002084 RID: 8324 RVA: 0x00094BCC File Offset: 0x00092DCC
			// (set) Token: 0x06002085 RID: 8325 RVA: 0x0000F96B File Offset: 0x0000DB6B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007BD RID: 1981
			// (get) Token: 0x06002086 RID: 8326 RVA: 0x00094BF4 File Offset: 0x00092DF4
			// (set) Token: 0x06002087 RID: 8327 RVA: 0x0000F986 File Offset: 0x0000DB86
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007BE RID: 1982
			// (get) Token: 0x06002088 RID: 8328 RVA: 0x00094C24 File Offset: 0x00092E24
			// (set) Token: 0x06002089 RID: 8329 RVA: 0x0000F9A5 File Offset: 0x0000DBA5
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170007BF RID: 1983
			// (get) Token: 0x0600208A RID: 8330 RVA: 0x00094C4C File Offset: 0x00092E4C
			// (set) Token: 0x0600208B RID: 8331 RVA: 0x0000F9C0 File Offset: 0x0000DBC0
			public unsafe AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007C0 RID: 1984
			// (get) Token: 0x0600208C RID: 8332 RVA: 0x00094C7C File Offset: 0x00092E7C
			// (set) Token: 0x0600208D RID: 8333 RVA: 0x00094CA4 File Offset: 0x00092EA4
			public unsafe TActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr_activeAbility);
					return IL2CPP.PointerToValueGeneric<TActiveAbility>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr_activeAbility);
					Type typeFromHandle = typeof(TActiveAbility);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x170007C1 RID: 1985
			// (get) Token: 0x0600208E RID: 8334 RVA: 0x00094D4C File Offset: 0x00092F4C
			// (set) Token: 0x0600208F RID: 8335 RVA: 0x00094D74 File Offset: 0x00092F74
			public unsafe TActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___3__activeAbility);
					return IL2CPP.PointerToValueGeneric<TActiveAbility>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___3__activeAbility);
					Type typeFromHandle = typeof(TActiveAbility);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x170007C2 RID: 1986
			// (get) Token: 0x06002090 RID: 8336 RVA: 0x00094E1C File Offset: 0x0009301C
			// (set) Token: 0x06002091 RID: 8337 RVA: 0x00094E44 File Offset: 0x00093044
			public unsafe TMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr_match);
					return IL2CPP.PointerToValueGeneric<TMatch>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr_match);
					Type typeFromHandle = typeof(TMatch);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x170007C3 RID: 1987
			// (get) Token: 0x06002092 RID: 8338 RVA: 0x00094EEC File Offset: 0x000930EC
			// (set) Token: 0x06002093 RID: 8339 RVA: 0x00094F14 File Offset: 0x00093114
			public unsafe TMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___3__match);
					return IL2CPP.PointerToValueGeneric<TMatch>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___3__match);
					Type typeFromHandle = typeof(TMatch);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x170007C4 RID: 1988
			// (get) Token: 0x06002094 RID: 8340 RVA: 0x00094FBC File Offset: 0x000931BC
			// (set) Token: 0x06002095 RID: 8341 RVA: 0x0000F9DF File Offset: 0x0000DBDF
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007C5 RID: 1989
			// (get) Token: 0x06002096 RID: 8342 RVA: 0x00094FEC File Offset: 0x000931EC
			// (set) Token: 0x06002097 RID: 8343 RVA: 0x0000F9FE File Offset: 0x0000DBFE
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007C6 RID: 1990
			// (get) Token: 0x06002098 RID: 8344 RVA: 0x0009501C File Offset: 0x0009321C
			// (set) Token: 0x06002099 RID: 8345 RVA: 0x0000FA1D File Offset: 0x0000DC1D
			public unsafe IEnumerator<Canis.actions.Action> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001475 RID: 5237
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001476 RID: 5238
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001477 RID: 5239
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001478 RID: 5240
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001479 RID: 5241
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x0400147A RID: 5242
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x0400147B RID: 5243
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x0400147C RID: 5244
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x0400147D RID: 5245
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x0400147E RID: 5246
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x0400147F RID: 5247
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001480 RID: 5248
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001481 RID: 5249
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001482 RID: 5250
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001483 RID: 5251
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001484 RID: 5252
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001485 RID: 5253
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001486 RID: 5254
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001487 RID: 5255
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001488 RID: 5256
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
