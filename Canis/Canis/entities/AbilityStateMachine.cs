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
	// Token: 0x020000C5 RID: 197
	public class AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition> : AbilityStateBindings<StateBehavior<TMatch, TActiveAbility, TAbilityDefinition>> where TMatch : Match where TActiveAbility : ActiveAbility<TMatch, TAbilityDefinition> where TAbilityDefinition : AbilityDefinitionForGame<TMatch>
	{
		// Token: 0x060008EC RID: 2284 RVA: 0x0003E108 File Offset: 0x0003C308
		// Note: this type is marked as 'beforefieldinit'.
		static AbilityStateMachine()
		{
			Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "AbilityStateMachine`3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TActiveAbility>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAbilityDefinition>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr);
			AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>.NativeFieldInfoPtr_stateComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, "stateComparer");
			AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_RunStateMachine_Private_IEnumerable_1_Action_TActiveAbility_TMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665130);
			AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_RunStateMachineBase_Public_Virtual_Final_New_IEnumerable_1_Action_ActiveAbility_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665131);
			AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_ExecuteState_Private_IEnumerable_1_Action_Int32_TActiveAbility_TMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665132);
			AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_ResumeExecutionBase_Public_Virtual_Final_New_Int32_ActiveAbility_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665133);
			AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_get_Ordering_Public_Virtual_Final_New_get_IComparer_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665134);
			AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665135);
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x0003E224 File Offset: 0x0003C424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 561625, XrefRangeEnd = 561632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_RunStateMachine_Private_IEnumerable_1_Action_TActiveAbility_TMatch_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr3;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr5) : null;
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x0003E304 File Offset: 0x0003C504
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 561644, RefRangeEnd = 561646, XrefRangeStart = 561632, XrefRangeEnd = 561644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_RunStateMachineBase_Public_Virtual_Final_New_IEnumerable_1_Action_ActiveAbility_Match_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x0003E378 File Offset: 0x0003C578
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 561653, RefRangeEnd = 561655, XrefRangeStart = 561646, XrefRangeEnd = 561653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_ExecuteState_Private_IEnumerable_1_Action_Int32_TActiveAbility_TMatch_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr3;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr5) : null;
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x0003E468 File Offset: 0x0003C668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 561655, XrefRangeEnd = 561668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_ResumeExecutionBase_Public_Virtual_Final_New_Int32_ActiveAbility_Action_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060008F1 RID: 2289 RVA: 0x0003E4DC File Offset: 0x0003C6DC
		public unsafe virtual IComparer<int> Ordering
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 561668, XrefRangeEnd = 561670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_get_Ordering_Public_Virtual_Final_New_get_IComparer_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IComparer<int>>(intPtr3) : null;
			}
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x0003E51C File Offset: 0x0003C71C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 561670, XrefRangeEnd = 561671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AbilityStateMachine()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00005730 File Offset: 0x00003930
		public AbilityStateMachine(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060008F4 RID: 2292 RVA: 0x0003E558 File Offset: 0x0003C758
		// (set) Token: 0x060008F5 RID: 2293 RVA: 0x00005739 File Offset: 0x00003939
		public unsafe static IComparer<int> stateComparer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>.NativeFieldInfoPtr_stateComparer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IComparer<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>.NativeFieldInfoPtr_stateComparer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400060F RID: 1551
		private static readonly IntPtr NativeFieldInfoPtr_stateComparer;

		// Token: 0x04000610 RID: 1552
		private static readonly IntPtr NativeMethodInfoPtr_RunStateMachine_Private_IEnumerable_1_Action_TActiveAbility_TMatch_Context_0;

		// Token: 0x04000611 RID: 1553
		private static readonly IntPtr NativeMethodInfoPtr_RunStateMachineBase_Public_Virtual_Final_New_IEnumerable_1_Action_ActiveAbility_Match_Context_0;

		// Token: 0x04000612 RID: 1554
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteState_Private_IEnumerable_1_Action_Int32_TActiveAbility_TMatch_Context_0;

		// Token: 0x04000613 RID: 1555
		private static readonly IntPtr NativeMethodInfoPtr_ResumeExecutionBase_Public_Virtual_Final_New_Int32_ActiveAbility_Action_Context_0;

		// Token: 0x04000614 RID: 1556
		private static readonly IntPtr NativeMethodInfoPtr_get_Ordering_Public_Virtual_Final_New_get_IComparer_1_Int32_0;

		// Token: 0x04000615 RID: 1557
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000303 RID: 771
		[ObfuscatedName("Canis.entities.AbilityStateMachine`3+<ExecuteState>d__2")]
		public sealed class _ExecuteState_d__2 : Object
		{
			// Token: 0x06001FD1 RID: 8145 RVA: 0x00091E30 File Offset: 0x00090030
			// Note: this type is marked as 'beforefieldinit'.
			static _ExecuteState_d__2()
			{
				Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, "<ExecuteState>d__2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TActiveAbility>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAbilityDefinition>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr);
				AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr, "<>1__state");
				AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr, "<>2__current");
				AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr, "<>l__initialThreadId");
				AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr, "<>4__this");
				AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr, "state");
				AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___3__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr, "<>3__state");
				AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr, "activeAbility");
				AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr, "<>3__activeAbility");
				AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr, "match");
				AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr, "<>3__match");
				AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr, "context");
				AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr, "<>3__context");
				AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr, "<>7__wrap1");
				AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr, 100665137);
				AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr, 100665138);
				AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr, 100665139);
				AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr, 100665140);
				AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr, 100665141);
				AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr, 100665142);
				AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr, 100665143);
				AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr, 100665144);
				AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr, 100665145);
			}

			// Token: 0x06001FD2 RID: 8146 RVA: 0x00092074 File Offset: 0x00090274
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ExecuteState_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001FD3 RID: 8147 RVA: 0x000920BC File Offset: 0x000902BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 561528, XrefRangeEnd = 561533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FD4 RID: 8148 RVA: 0x000920F0 File Offset: 0x000902F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 561533, XrefRangeEnd = 561553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001FD5 RID: 8149 RVA: 0x0009212C File Offset: 0x0009032C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 561553, XrefRangeEnd = 561556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700078C RID: 1932
			// (get) Token: 0x06001FD6 RID: 8150 RVA: 0x00092160 File Offset: 0x00090360
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06001FD7 RID: 8151 RVA: 0x000921A0 File Offset: 0x000903A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700078D RID: 1933
			// (get) Token: 0x06001FD8 RID: 8152 RVA: 0x000921D4 File Offset: 0x000903D4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001FD9 RID: 8153 RVA: 0x00092214 File Offset: 0x00090414
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 561556, XrefRangeEnd = 561566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06001FDA RID: 8154 RVA: 0x00092254 File Offset: 0x00090454
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 561566, XrefRangeEnd = 561576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001FDB RID: 8155 RVA: 0x0000F4C0 File Offset: 0x0000D6C0
			public _ExecuteState_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700077F RID: 1919
			// (get) Token: 0x06001FDC RID: 8156 RVA: 0x00092294 File Offset: 0x00090494
			// (set) Token: 0x06001FDD RID: 8157 RVA: 0x0000F4C9 File Offset: 0x0000D6C9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000780 RID: 1920
			// (get) Token: 0x06001FDE RID: 8158 RVA: 0x000922BC File Offset: 0x000904BC
			// (set) Token: 0x06001FDF RID: 8159 RVA: 0x0000F4E4 File Offset: 0x0000D6E4
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000781 RID: 1921
			// (get) Token: 0x06001FE0 RID: 8160 RVA: 0x000922EC File Offset: 0x000904EC
			// (set) Token: 0x06001FE1 RID: 8161 RVA: 0x0000F503 File Offset: 0x0000D703
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000782 RID: 1922
			// (get) Token: 0x06001FE2 RID: 8162 RVA: 0x00092314 File Offset: 0x00090514
			// (set) Token: 0x06001FE3 RID: 8163 RVA: 0x0000F51E File Offset: 0x0000D71E
			public unsafe AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000783 RID: 1923
			// (get) Token: 0x06001FE4 RID: 8164 RVA: 0x00092344 File Offset: 0x00090544
			// (set) Token: 0x06001FE5 RID: 8165 RVA: 0x0000F53D File Offset: 0x0000D73D
			public unsafe int state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr_state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr_state)) = value;
				}
			}

			// Token: 0x17000784 RID: 1924
			// (get) Token: 0x06001FE6 RID: 8166 RVA: 0x0009236C File Offset: 0x0009056C
			// (set) Token: 0x06001FE7 RID: 8167 RVA: 0x0000F558 File Offset: 0x0000D758
			public unsafe int __3__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___3__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___3__state)) = value;
				}
			}

			// Token: 0x17000785 RID: 1925
			// (get) Token: 0x06001FE8 RID: 8168 RVA: 0x00092394 File Offset: 0x00090594
			// (set) Token: 0x06001FE9 RID: 8169 RVA: 0x000923BC File Offset: 0x000905BC
			public unsafe TActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr_activeAbility);
					return IL2CPP.PointerToValueGeneric<TActiveAbility>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr_activeAbility);
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

			// Token: 0x17000786 RID: 1926
			// (get) Token: 0x06001FEA RID: 8170 RVA: 0x00092464 File Offset: 0x00090664
			// (set) Token: 0x06001FEB RID: 8171 RVA: 0x0009248C File Offset: 0x0009068C
			public unsafe TActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___3__activeAbility);
					return IL2CPP.PointerToValueGeneric<TActiveAbility>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___3__activeAbility);
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

			// Token: 0x17000787 RID: 1927
			// (get) Token: 0x06001FEC RID: 8172 RVA: 0x00092534 File Offset: 0x00090734
			// (set) Token: 0x06001FED RID: 8173 RVA: 0x0009255C File Offset: 0x0009075C
			public unsafe TMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr_match);
					return IL2CPP.PointerToValueGeneric<TMatch>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr_match);
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

			// Token: 0x17000788 RID: 1928
			// (get) Token: 0x06001FEE RID: 8174 RVA: 0x00092604 File Offset: 0x00090804
			// (set) Token: 0x06001FEF RID: 8175 RVA: 0x0009262C File Offset: 0x0009082C
			public unsafe TMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___3__match);
					return IL2CPP.PointerToValueGeneric<TMatch>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___3__match);
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

			// Token: 0x17000789 RID: 1929
			// (get) Token: 0x06001FF0 RID: 8176 RVA: 0x000926D4 File Offset: 0x000908D4
			// (set) Token: 0x06001FF1 RID: 8177 RVA: 0x0000F573 File Offset: 0x0000D773
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700078A RID: 1930
			// (get) Token: 0x06001FF2 RID: 8178 RVA: 0x00092704 File Offset: 0x00090904
			// (set) Token: 0x06001FF3 RID: 8179 RVA: 0x0000F592 File Offset: 0x0000D792
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700078B RID: 1931
			// (get) Token: 0x06001FF4 RID: 8180 RVA: 0x00092734 File Offset: 0x00090934
			// (set) Token: 0x06001FF5 RID: 8181 RVA: 0x0000F5B1 File Offset: 0x0000D7B1
			public unsafe IEnumerator<Canis.actions.Action> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._ExecuteState_d__2.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400140E RID: 5134
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400140F RID: 5135
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001410 RID: 5136
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001411 RID: 5137
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001412 RID: 5138
			private static readonly IntPtr NativeFieldInfoPtr_state;

			// Token: 0x04001413 RID: 5139
			private static readonly IntPtr NativeFieldInfoPtr___3__state;

			// Token: 0x04001414 RID: 5140
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04001415 RID: 5141
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x04001416 RID: 5142
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04001417 RID: 5143
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04001418 RID: 5144
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04001419 RID: 5145
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x0400141A RID: 5146
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400141B RID: 5147
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400141C RID: 5148
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400141D RID: 5149
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400141E RID: 5150
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400141F RID: 5151
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001420 RID: 5152
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001421 RID: 5153
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001422 RID: 5154
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001423 RID: 5155
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000304 RID: 772
		[ObfuscatedName("Canis.entities.AbilityStateMachine`3+<RunStateMachine>d__0")]
		public sealed class _RunStateMachine_d__0 : Object
		{
			// Token: 0x06001FF6 RID: 8182 RVA: 0x00092764 File Offset: 0x00090964
			// Note: this type is marked as 'beforefieldinit'.
			static _RunStateMachine_d__0()
			{
				Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, "<RunStateMachine>d__0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TActiveAbility>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAbilityDefinition>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr);
				AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr, "<>1__state");
				AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr, "<>2__current");
				AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr, "<>l__initialThreadId");
				AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr, "<>4__this");
				AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr_activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr, "activeAbility");
				AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___3__activeAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr, "<>3__activeAbility");
				AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr, "match");
				AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr, "<>3__match");
				AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr, "context");
				AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr, "<>3__context");
				AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr, "<>7__wrap1");
				AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr, 100665146);
				AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr, 100665147);
				AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr, 100665148);
				AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr, 100665149);
				AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr, 100665150);
				AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr, 100665151);
				AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr, 100665152);
				AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr, 100665153);
				AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr, 100665154);
			}

			// Token: 0x06001FF7 RID: 8183 RVA: 0x00092980 File Offset: 0x00090B80
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RunStateMachine_d__0(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001FF8 RID: 8184 RVA: 0x000929C8 File Offset: 0x00090BC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 561576, XrefRangeEnd = 561581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FF9 RID: 8185 RVA: 0x000929FC File Offset: 0x00090BFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 561581, XrefRangeEnd = 561602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001FFA RID: 8186 RVA: 0x00092A38 File Offset: 0x00090C38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 561602, XrefRangeEnd = 561605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000799 RID: 1945
			// (get) Token: 0x06001FFB RID: 8187 RVA: 0x00092A6C File Offset: 0x00090C6C
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06001FFC RID: 8188 RVA: 0x00092AAC File Offset: 0x00090CAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700079A RID: 1946
			// (get) Token: 0x06001FFD RID: 8189 RVA: 0x00092AE0 File Offset: 0x00090CE0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001FFE RID: 8190 RVA: 0x00092B20 File Offset: 0x00090D20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 561605, XrefRangeEnd = 561615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06001FFF RID: 8191 RVA: 0x00092B60 File Offset: 0x00090D60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 561615, XrefRangeEnd = 561625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002000 RID: 8192 RVA: 0x0000F5D0 File Offset: 0x0000D7D0
			public _RunStateMachine_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700078E RID: 1934
			// (get) Token: 0x06002001 RID: 8193 RVA: 0x00092BA0 File Offset: 0x00090DA0
			// (set) Token: 0x06002002 RID: 8194 RVA: 0x0000F5D9 File Offset: 0x0000D7D9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700078F RID: 1935
			// (get) Token: 0x06002003 RID: 8195 RVA: 0x00092BC8 File Offset: 0x00090DC8
			// (set) Token: 0x06002004 RID: 8196 RVA: 0x0000F5F4 File Offset: 0x0000D7F4
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000790 RID: 1936
			// (get) Token: 0x06002005 RID: 8197 RVA: 0x00092BF8 File Offset: 0x00090DF8
			// (set) Token: 0x06002006 RID: 8198 RVA: 0x0000F613 File Offset: 0x0000D813
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000791 RID: 1937
			// (get) Token: 0x06002007 RID: 8199 RVA: 0x00092C20 File Offset: 0x00090E20
			// (set) Token: 0x06002008 RID: 8200 RVA: 0x0000F62E File Offset: 0x0000D82E
			public unsafe AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000792 RID: 1938
			// (get) Token: 0x06002009 RID: 8201 RVA: 0x00092C50 File Offset: 0x00090E50
			// (set) Token: 0x0600200A RID: 8202 RVA: 0x00092C78 File Offset: 0x00090E78
			public unsafe TActiveAbility activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr_activeAbility);
					return IL2CPP.PointerToValueGeneric<TActiveAbility>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr_activeAbility);
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

			// Token: 0x17000793 RID: 1939
			// (get) Token: 0x0600200B RID: 8203 RVA: 0x00092D20 File Offset: 0x00090F20
			// (set) Token: 0x0600200C RID: 8204 RVA: 0x00092D48 File Offset: 0x00090F48
			public unsafe TActiveAbility __3__activeAbility
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___3__activeAbility);
					return IL2CPP.PointerToValueGeneric<TActiveAbility>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___3__activeAbility);
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

			// Token: 0x17000794 RID: 1940
			// (get) Token: 0x0600200D RID: 8205 RVA: 0x00092DF0 File Offset: 0x00090FF0
			// (set) Token: 0x0600200E RID: 8206 RVA: 0x00092E18 File Offset: 0x00091018
			public unsafe TMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr_match);
					return IL2CPP.PointerToValueGeneric<TMatch>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr_match);
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

			// Token: 0x17000795 RID: 1941
			// (get) Token: 0x0600200F RID: 8207 RVA: 0x00092EC0 File Offset: 0x000910C0
			// (set) Token: 0x06002010 RID: 8208 RVA: 0x00092EE8 File Offset: 0x000910E8
			public unsafe TMatch __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___3__match);
					return IL2CPP.PointerToValueGeneric<TMatch>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___3__match);
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

			// Token: 0x17000796 RID: 1942
			// (get) Token: 0x06002011 RID: 8209 RVA: 0x00092F90 File Offset: 0x00091190
			// (set) Token: 0x06002012 RID: 8210 RVA: 0x0000F64D File Offset: 0x0000D84D
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000797 RID: 1943
			// (get) Token: 0x06002013 RID: 8211 RVA: 0x00092FC0 File Offset: 0x000911C0
			// (set) Token: 0x06002014 RID: 8212 RVA: 0x0000F66C File Offset: 0x0000D86C
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000798 RID: 1944
			// (get) Token: 0x06002015 RID: 8213 RVA: 0x00092FF0 File Offset: 0x000911F0
			// (set) Token: 0x06002016 RID: 8214 RVA: 0x0000F68B File Offset: 0x0000D88B
			public unsafe IEnumerator<Canis.actions.Action> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>._RunStateMachine_d__0.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001424 RID: 5156
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001425 RID: 5157
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001426 RID: 5158
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001427 RID: 5159
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001428 RID: 5160
			private static readonly IntPtr NativeFieldInfoPtr_activeAbility;

			// Token: 0x04001429 RID: 5161
			private static readonly IntPtr NativeFieldInfoPtr___3__activeAbility;

			// Token: 0x0400142A RID: 5162
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x0400142B RID: 5163
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x0400142C RID: 5164
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x0400142D RID: 5165
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x0400142E RID: 5166
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400142F RID: 5167
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001430 RID: 5168
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001431 RID: 5169
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001432 RID: 5170
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001433 RID: 5171
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001434 RID: 5172
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001435 RID: 5173
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001436 RID: 5174
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001437 RID: 5175
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
