using System;
using System.Runtime.InteropServices;
using Canis.actions;
using Canis.context;
using Canis.messages;
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
	// Token: 0x020000CE RID: 206
	public class AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition> : AbilityDefinitionForGame<TMatch> where TMatch : Match where TActiveAbility : ActiveAbility<TMatch, TAbilityDefinition> where TAbilityDefinition : AbilityDefinitionForGame<TMatch>
	{
		// Token: 0x06000946 RID: 2374 RVA: 0x000403DC File Offset: 0x0003E5DC
		// Note: this type is marked as 'beforefieldinit'.
		static AbilityStateMachineDefinitionV2()
		{
			Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "AbilityStateMachineDefinitionV2`3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TActiveAbility>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAbilityDefinition>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr);
			AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeFieldInfoPtr_stateMachine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, "stateMachine");
			AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeFieldInfoPtr_BeginExecutionState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, "BeginExecutionState");
			AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeFieldInfoPtr_CompletedExecutionState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, "CompletedExecutionState");
			AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeFieldInfoPtr_CanceledExecutionState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, "CanceledExecutionState");
			AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr__ctor_Protected_Void_TMatch_String_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665237);
			AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr__ctor_Protected_Void_SerializedEntity_TMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665238);
			AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_AddBinding_Public_Virtual_Final_New_Void_Int32_StateBehaviorV2_3_TMatch_TActiveAbility_TAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665239);
			AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_AddBinding_Public_Virtual_Final_New_Void_Int32_StateAction_3_TMatch_TActiveAbility_TAbilityDefinition_Transition_1_TActiveAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665240);
			AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_AddBindingSequence_Public_Virtual_Final_New_Void_Int32_Transition_1_TActiveAbility_StateAction_3_TMatch_TActiveAbility_TAbilityDefinition_Il2CppReferenceArray_1_StateAction_3_TMatch_TActiveAbility_TAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665241);
			AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_Action_Public_Virtual_Final_IEnumerable_1_Action_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665242);
			AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_RunStateMachineBase_Public_Virtual_Final_New_IEnumerable_1_Action_ActiveAbility_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665243);
			AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_BeginExecution_Protected_Abstract_Virtual_New_Action_TActiveAbility_TMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665244);
			AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_BeginExecutionTransition_Protected_Abstract_Virtual_New_Int32_TActiveAbility_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665245);
			AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_get_BeginExecutionSequence_Protected_Virtual_New_get_Il2CppReferenceArray_1_StateAction_3_TMatch_TActiveAbility_TAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665246);
			AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_CompletedExecution_Protected_Virtual_New_Action_TActiveAbility_TMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665247);
			AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_get_CompletedExecutionSequence_Protected_Virtual_New_get_Il2CppReferenceArray_1_StateAction_3_TMatch_TActiveAbility_TAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665248);
			AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_ResumeExecutionBase_Public_Virtual_Final_New_Int32_ActiveAbility_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665249);
			AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_get_Ordering_Public_Virtual_Final_New_get_IComparer_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665250);
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x000405D4 File Offset: 0x0003E7D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 562209, XrefRangeEnd = 562229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AbilityStateMachineDefinitionV2(TMatch m, string name = "", PlayerEntity owningPlayer = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TMatch).IsValueType)
				{
					TMatch tmatch = m;
					intPtr = ((tmatch is string) ? IL2CPP.ManagedStringToIl2Cpp(tmatch as string) : IL2CPP.Il2CppObjectBaseToPtr(tmatch as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref m;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owningPlayer);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr__ctor_Protected_Void_TMatch_String_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x0004067C File Offset: 0x0003E87C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 562229, XrefRangeEnd = 562249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AbilityStateMachineDefinitionV2(SerializedEntity se, TMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TMatch).IsValueType)
			{
				TMatch tmatch = m;
				intPtr = ((tmatch is string) ? IL2CPP.ManagedStringToIl2Cpp(tmatch as string) : IL2CPP.Il2CppObjectBaseToPtr(tmatch as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref m;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr__ctor_Protected_Void_SerializedEntity_TMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x00040724 File Offset: 0x0003E924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 562249, XrefRangeEnd = 562251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddBinding(int state, StateBehaviorV2<TMatch, TActiveAbility, TAbilityDefinition> behavior)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(behavior);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_AddBinding_Public_Virtual_Final_New_Void_Int32_StateBehaviorV2_3_TMatch_TActiveAbility_TAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00040774 File Offset: 0x0003E974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 562251, XrefRangeEnd = 562253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddBinding(int state, StateAction<TMatch, TActiveAbility, TAbilityDefinition> action, Transition<TActiveAbility> transition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_AddBinding_Public_Virtual_Final_New_Void_Int32_StateAction_3_TMatch_TActiveAbility_TAbilityDefinition_Transition_1_TActiveAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x000407D8 File Offset: 0x0003E9D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 562253, XrefRangeEnd = 562255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddBindingSequence(int state, Transition<TActiveAbility> transition, StateAction<TMatch, TActiveAbility, TAbilityDefinition> initialAction, [Optional] Il2CppReferenceArray<StateAction<TMatch, TActiveAbility, TAbilityDefinition>> actions)
		{
			if (actions == null)
			{
				actions = new Il2CppReferenceArray<StateAction<TMatch, TActiveAbility, TAbilityDefinition>>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transition);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(initialAction);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_AddBindingSequence_Public_Virtual_Final_New_Void_Int32_Transition_1_TActiveAbility_StateAction_3_TMatch_TActiveAbility_TAbilityDefinition_Il2CppReferenceArray_1_StateAction_3_TMatch_TActiveAbility_TAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x0004085C File Offset: 0x0003EA5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 562255, XrefRangeEnd = 562261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Canis.actions.Action> Action(Match match, Context context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_Action_Public_Virtual_Final_IEnumerable_1_Action_Match_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x000408C0 File Offset: 0x0003EAC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 562262, RefRangeEnd = 562263, XrefRangeStart = 562261, XrefRangeEnd = 562262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_RunStateMachineBase_Public_Virtual_Final_New_IEnumerable_1_Action_ActiveAbility_Match_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x00040934 File Offset: 0x0003EB34
		[CallerCount(0)]
		public unsafe virtual Canis.actions.Action BeginExecution(TActiveAbility activeAbility, TMatch match, Context context)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_BeginExecution_Protected_Abstract_Virtual_New_Action_TActiveAbility_TMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr3;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr5) : null;
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x00040A20 File Offset: 0x0003EC20
		[CallerCount(0)]
		public unsafe virtual int BeginExecutionTransition(TActiveAbility activeAbility, Canis.actions.Action lastAction, Context context)
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
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lastAction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_BeginExecutionTransition_Protected_Abstract_Virtual_New_Int32_TActiveAbility_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000950 RID: 2384 RVA: 0x00040AD4 File Offset: 0x0003ECD4
		public unsafe virtual Il2CppReferenceArray<StateAction<TMatch, TActiveAbility, TAbilityDefinition>> BeginExecutionSequence
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_get_BeginExecutionSequence_Protected_Virtual_New_get_Il2CppReferenceArray_1_StateAction_3_TMatch_TActiveAbility_TAbilityDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StateAction<TMatch, TActiveAbility, TAbilityDefinition>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00040B20 File Offset: 0x0003ED20
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Canis.actions.Action CompletedExecution(TActiveAbility activeAbility, TMatch match, Context context)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_CompletedExecution_Protected_Virtual_New_Action_TActiveAbility_TMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr3;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr5) : null;
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000952 RID: 2386 RVA: 0x00040C0C File Offset: 0x0003EE0C
		public unsafe virtual Il2CppReferenceArray<StateAction<TMatch, TActiveAbility, TAbilityDefinition>> CompletedExecutionSequence
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_get_CompletedExecutionSequence_Protected_Virtual_New_get_Il2CppReferenceArray_1_StateAction_3_TMatch_TActiveAbility_TAbilityDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StateAction<TMatch, TActiveAbility, TAbilityDefinition>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x00040C58 File Offset: 0x0003EE58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 562263, XrefRangeEnd = 562270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_ResumeExecutionBase_Public_Virtual_Final_New_Int32_ActiveAbility_Action_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000954 RID: 2388 RVA: 0x00040CCC File Offset: 0x0003EECC
		public unsafe virtual IComparer<int> Ordering
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 562270, XrefRangeEnd = 562273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_get_Ordering_Public_Virtual_Final_New_get_IComparer_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IComparer<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x000058D7 File Offset: 0x00003AD7
		public virtual void AddBindingSequence(int state, Transition<TActiveAbility> transition, StateAction<TMatch, TActiveAbility, TAbilityDefinition> initialAction, params StateAction<TMatch, TActiveAbility, TAbilityDefinition>[] actions)
		{
			this.AddBindingSequence(state, transition, initialAction, new Il2CppReferenceArray<StateAction<TMatch, TActiveAbility, TAbilityDefinition>>(actions));
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x000058E9 File Offset: 0x00003AE9
		public AbilityStateMachineDefinitionV2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000957 RID: 2391 RVA: 0x00040D0C File Offset: 0x0003EF0C
		// (set) Token: 0x06000958 RID: 2392 RVA: 0x000058F2 File Offset: 0x00003AF2
		public unsafe AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition> stateMachine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeFieldInfoPtr_stateMachine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityStateMachineV2<TMatch, TActiveAbility, TAbilityDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeFieldInfoPtr_stateMachine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000959 RID: 2393 RVA: 0x00040D3C File Offset: 0x0003EF3C
		// (set) Token: 0x0600095A RID: 2394 RVA: 0x00005911 File Offset: 0x00003B11
		public unsafe static int BeginExecutionState
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeFieldInfoPtr_BeginExecutionState, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeFieldInfoPtr_BeginExecutionState, (void*)(&value));
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x0600095B RID: 2395 RVA: 0x00040D58 File Offset: 0x0003EF58
		// (set) Token: 0x0600095C RID: 2396 RVA: 0x0000591F File Offset: 0x00003B1F
		public unsafe static int CompletedExecutionState
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeFieldInfoPtr_CompletedExecutionState, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeFieldInfoPtr_CompletedExecutionState, (void*)(&value));
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x0600095D RID: 2397 RVA: 0x00040D74 File Offset: 0x0003EF74
		// (set) Token: 0x0600095E RID: 2398 RVA: 0x0000592D File Offset: 0x00003B2D
		public unsafe static int CanceledExecutionState
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeFieldInfoPtr_CanceledExecutionState, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>.NativeFieldInfoPtr_CanceledExecutionState, (void*)(&value));
			}
		}

		// Token: 0x04000647 RID: 1607
		private static readonly IntPtr NativeFieldInfoPtr_stateMachine;

		// Token: 0x04000648 RID: 1608
		private static readonly IntPtr NativeFieldInfoPtr_BeginExecutionState;

		// Token: 0x04000649 RID: 1609
		private static readonly IntPtr NativeFieldInfoPtr_CompletedExecutionState;

		// Token: 0x0400064A RID: 1610
		private static readonly IntPtr NativeFieldInfoPtr_CanceledExecutionState;

		// Token: 0x0400064B RID: 1611
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_TMatch_String_PlayerEntity_0;

		// Token: 0x0400064C RID: 1612
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializedEntity_TMatch_Entity_0;

		// Token: 0x0400064D RID: 1613
		private static readonly IntPtr NativeMethodInfoPtr_AddBinding_Public_Virtual_Final_New_Void_Int32_StateBehaviorV2_3_TMatch_TActiveAbility_TAbilityDefinition_0;

		// Token: 0x0400064E RID: 1614
		private static readonly IntPtr NativeMethodInfoPtr_AddBinding_Public_Virtual_Final_New_Void_Int32_StateAction_3_TMatch_TActiveAbility_TAbilityDefinition_Transition_1_TActiveAbility_0;

		// Token: 0x0400064F RID: 1615
		private static readonly IntPtr NativeMethodInfoPtr_AddBindingSequence_Public_Virtual_Final_New_Void_Int32_Transition_1_TActiveAbility_StateAction_3_TMatch_TActiveAbility_TAbilityDefinition_Il2CppReferenceArray_1_StateAction_3_TMatch_TActiveAbility_TAbilityDefinition_0;

		// Token: 0x04000650 RID: 1616
		private static readonly IntPtr NativeMethodInfoPtr_Action_Public_Virtual_Final_IEnumerable_1_Action_Match_Context_0;

		// Token: 0x04000651 RID: 1617
		private static readonly IntPtr NativeMethodInfoPtr_RunStateMachineBase_Public_Virtual_Final_New_IEnumerable_1_Action_ActiveAbility_Match_Context_0;

		// Token: 0x04000652 RID: 1618
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Abstract_Virtual_New_Action_TActiveAbility_TMatch_Context_0;

		// Token: 0x04000653 RID: 1619
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecutionTransition_Protected_Abstract_Virtual_New_Int32_TActiveAbility_Action_Context_0;

		// Token: 0x04000654 RID: 1620
		private static readonly IntPtr NativeMethodInfoPtr_get_BeginExecutionSequence_Protected_Virtual_New_get_Il2CppReferenceArray_1_StateAction_3_TMatch_TActiveAbility_TAbilityDefinition_0;

		// Token: 0x04000655 RID: 1621
		private static readonly IntPtr NativeMethodInfoPtr_CompletedExecution_Protected_Virtual_New_Action_TActiveAbility_TMatch_Context_0;

		// Token: 0x04000656 RID: 1622
		private static readonly IntPtr NativeMethodInfoPtr_get_CompletedExecutionSequence_Protected_Virtual_New_get_Il2CppReferenceArray_1_StateAction_3_TMatch_TActiveAbility_TAbilityDefinition_0;

		// Token: 0x04000657 RID: 1623
		private static readonly IntPtr NativeMethodInfoPtr_ResumeExecutionBase_Public_Virtual_Final_New_Int32_ActiveAbility_Action_Context_0;

		// Token: 0x04000658 RID: 1624
		private static readonly IntPtr NativeMethodInfoPtr_get_Ordering_Public_Virtual_Final_New_get_IComparer_1_Int32_0;

		// Token: 0x02000310 RID: 784
		[ObfuscatedName("Canis.entities.AbilityStateMachineDefinitionV2`3+<Action>d__9")]
		public sealed class _Action_d__9 : Object
		{
			// Token: 0x0600209A RID: 8346 RVA: 0x0009504C File Offset: 0x0009324C
			// Note: this type is marked as 'beforefieldinit'.
			static _Action_d__9()
			{
				Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, "<Action>d__9"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TActiveAbility>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAbilityDefinition>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9>.NativeClassPtr);
				AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9>.NativeClassPtr, "<>1__state");
				AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9>.NativeClassPtr, "<>2__current");
				AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9>.NativeClassPtr, "<>l__initialThreadId");
				AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9>.NativeClassPtr, "match");
				AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9>.NativeClassPtr, "<>3__match");
				AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9>.NativeClassPtr, "<>4__this");
				AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9>.NativeClassPtr, "context");
				AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9>.NativeClassPtr, "<>3__context");
				AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9>.NativeClassPtr, "<>7__wrap1");
				AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9>.NativeClassPtr, 100665251);
				AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9>.NativeClassPtr, 100665252);
				AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9>.NativeClassPtr, 100665253);
				AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9>.NativeClassPtr, 100665254);
				AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9>.NativeClassPtr, 100665255);
				AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9>.NativeClassPtr, 100665256);
				AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9>.NativeClassPtr, 100665257);
				AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9>.NativeClassPtr, 100665258);
				AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9>.NativeClassPtr, 100665259);
			}

			// Token: 0x0600209B RID: 8347 RVA: 0x00095240 File Offset: 0x00093440
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Action_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600209C RID: 8348 RVA: 0x00095288 File Offset: 0x00093488
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 562168, XrefRangeEnd = 562173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600209D RID: 8349 RVA: 0x000952BC File Offset: 0x000934BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 562173, XrefRangeEnd = 562206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600209E RID: 8350 RVA: 0x000952F8 File Offset: 0x000934F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 562206, XrefRangeEnd = 562209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170007D2 RID: 2002
			// (get) Token: 0x0600209F RID: 8351 RVA: 0x0009532C File Offset: 0x0009352C
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060020A0 RID: 8352 RVA: 0x0009536C File Offset: 0x0009356C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170007D3 RID: 2003
			// (get) Token: 0x060020A1 RID: 8353 RVA: 0x000953A0 File Offset: 0x000935A0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060020A2 RID: 8354 RVA: 0x000953E0 File Offset: 0x000935E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060020A3 RID: 8355 RVA: 0x00095420 File Offset: 0x00093620
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060020A4 RID: 8356 RVA: 0x0000FA3C File Offset: 0x0000DC3C
			public _Action_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007C9 RID: 1993
			// (get) Token: 0x060020A5 RID: 8357 RVA: 0x00095460 File Offset: 0x00093660
			// (set) Token: 0x060020A6 RID: 8358 RVA: 0x0000FA45 File Offset: 0x0000DC45
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007CA RID: 1994
			// (get) Token: 0x060020A7 RID: 8359 RVA: 0x00095488 File Offset: 0x00093688
			// (set) Token: 0x060020A8 RID: 8360 RVA: 0x0000FA60 File Offset: 0x0000DC60
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007CB RID: 1995
			// (get) Token: 0x060020A9 RID: 8361 RVA: 0x000954B8 File Offset: 0x000936B8
			// (set) Token: 0x060020AA RID: 8362 RVA: 0x0000FA7F File Offset: 0x0000DC7F
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170007CC RID: 1996
			// (get) Token: 0x060020AB RID: 8363 RVA: 0x000954E0 File Offset: 0x000936E0
			// (set) Token: 0x060020AC RID: 8364 RVA: 0x0000FA9A File Offset: 0x0000DC9A
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007CD RID: 1997
			// (get) Token: 0x060020AD RID: 8365 RVA: 0x00095510 File Offset: 0x00093710
			// (set) Token: 0x060020AE RID: 8366 RVA: 0x0000FAB9 File Offset: 0x0000DCB9
			public unsafe Match __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007CE RID: 1998
			// (get) Token: 0x060020AF RID: 8367 RVA: 0x00095540 File Offset: 0x00093740
			// (set) Token: 0x060020B0 RID: 8368 RVA: 0x0000FAD8 File Offset: 0x0000DCD8
			public unsafe AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007CF RID: 1999
			// (get) Token: 0x060020B1 RID: 8369 RVA: 0x00095570 File Offset: 0x00093770
			// (set) Token: 0x060020B2 RID: 8370 RVA: 0x0000FAF7 File Offset: 0x0000DCF7
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007D0 RID: 2000
			// (get) Token: 0x060020B3 RID: 8371 RVA: 0x000955A0 File Offset: 0x000937A0
			// (set) Token: 0x060020B4 RID: 8372 RVA: 0x0000FB16 File Offset: 0x0000DD16
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007D1 RID: 2001
			// (get) Token: 0x060020B5 RID: 8373 RVA: 0x000955D0 File Offset: 0x000937D0
			// (set) Token: 0x060020B6 RID: 8374 RVA: 0x0000FB35 File Offset: 0x0000DD35
			public unsafe IEnumerator<Canis.actions.Action> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinitionV2<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__9.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001489 RID: 5257
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400148A RID: 5258
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400148B RID: 5259
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400148C RID: 5260
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x0400148D RID: 5261
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x0400148E RID: 5262
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400148F RID: 5263
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04001490 RID: 5264
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x04001491 RID: 5265
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001492 RID: 5266
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001493 RID: 5267
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001494 RID: 5268
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001495 RID: 5269
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001496 RID: 5270
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001497 RID: 5271
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001498 RID: 5272
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001499 RID: 5273
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x0400149A RID: 5274
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
