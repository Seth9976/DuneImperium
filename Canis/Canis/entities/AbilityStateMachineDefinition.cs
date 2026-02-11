using System;
using Canis.actions;
using Canis.attributes;
using Canis.context;
using Canis.context.targetpickers;
using Canis.entities.ai;
using Canis.messages;
using Canis.utils.ids;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Networking.selection.targetinformation;

namespace Canis.entities
{
	// Token: 0x020000C6 RID: 198
	public class AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition> : AbilityDefinitionForGame<TMatch> where TMatch : Match where TActiveAbility : ActiveAbility<TMatch, TAbilityDefinition> where TAbilityDefinition : AbilityDefinitionForGame<TMatch>
	{
		// Token: 0x060008F6 RID: 2294 RVA: 0x0003E580 File Offset: 0x0003C780
		// Note: this type is marked as 'beforefieldinit'.
		static AbilityStateMachineDefinition()
		{
			Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "AbilityStateMachineDefinition`3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TActiveAbility>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAbilityDefinition>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr);
			AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.NativeFieldInfoPtr_stateMachine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, "stateMachine");
			AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.NativeFieldInfoPtr_BeginExecutionState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, "BeginExecutionState");
			AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.NativeFieldInfoPtr_CompletedExecutionState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, "CompletedExecutionState");
			AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.NativeFieldInfoPtr_CanceledExecutionState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, "CanceledExecutionState");
			AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr__ctor_Protected_Void_TMatch_String_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665155);
			AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr__ctor_Protected_Void_SerializedEntity_TMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665156);
			AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_AddBinding_Public_Virtual_Final_New_Void_Int32_StateBehavior_3_TMatch_TActiveAbility_TAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665157);
			AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_Action_Public_Virtual_Final_IEnumerable_1_Action_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665158);
			AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_RunStateMachineBase_Public_Virtual_Final_New_IEnumerable_1_Action_ActiveAbility_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665159);
			AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_BeginExecution_Protected_Abstract_Virtual_New_IEnumerable_1_Action_TActiveAbility_TMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665160);
			AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_CompletedExecution_Protected_Virtual_New_IEnumerable_1_Action_TActiveAbility_TMatch_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665161);
			AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_ResumeExecutionBase_Public_Virtual_Final_New_Int32_ActiveAbility_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665162);
			AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_ResumeExecution_Public_Abstract_Virtual_New_Int32_TActiveAbility_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665163);
			AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_get_Ordering_Public_Virtual_New_get_IComparer_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665164);
			AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_GetTargetsFromQueue_Public_IEnumerable_1_TargetType_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665165);
			AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_GetTargetsFromQueue_Public_IEnumerable_1_TargetType_TargetResponseQueue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665166);
			AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_GetTargetFromQueue_Public_TargetType_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665167);
			AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_GetTargetFromQueue_Public_TargetType_TargetResponseQueue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665168);
			AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_MakeEvaluatorAttribute_Protected_MutableAttribute_1_AIEvaluator_AIEvaluateSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665169);
			AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_MakeEntityListTargetInformation_Protected_Virtual_New_EntityListTargetInformation_IEnumerable_1_Entity_PlayerEntity_LocalizableTextVariables_AIEvaluateSelection_String_Boolean_Boolean_Int32_Int32_IEnumerable_1_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665170);
			AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_MakeArchetypeCustomChoiceTargetInformation_Protected_Virtual_New_ArchetypeCustomChoiceTargetInformation_IEnumerable_1_SerializableAttributes_PlayerEntity_LocalizableTextVariables_AIEvaluateSelection_String_Boolean_Boolean_Int32_Int32_IEnumerable_1_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665171);
			AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr__GetTargetsFromQueue_b__16_0_Private_IEnumerable_1_TargetType_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, 100665172);
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x0003E7C8 File Offset: 0x0003C9C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 561745, RefRangeEnd = 561747, XrefRangeStart = 561730, XrefRangeEnd = 561745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AbilityStateMachineDefinition(TMatch m, string name = "", PlayerEntity owningPlayer = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr))
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr__ctor_Protected_Void_TMatch_String_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x0003E870 File Offset: 0x0003CA70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 561762, RefRangeEnd = 561764, XrefRangeStart = 561747, XrefRangeEnd = 561762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AbilityStateMachineDefinition(SerializedEntity se, TMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr))
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr__ctor_Protected_Void_SerializedEntity_TMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x0003E918 File Offset: 0x0003CB18
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 561766, RefRangeEnd = 561784, XrefRangeStart = 561764, XrefRangeEnd = 561766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddBinding(int state, StateBehavior<TMatch, TActiveAbility, TAbilityDefinition> behavior)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_AddBinding_Public_Virtual_Final_New_Void_Int32_StateBehavior_3_TMatch_TActiveAbility_TAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x0003E968 File Offset: 0x0003CB68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 561784, XrefRangeEnd = 561790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_Action_Public_Virtual_Final_IEnumerable_1_Action_Match_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x0003E9CC File Offset: 0x0003CBCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 561791, RefRangeEnd = 561792, XrefRangeStart = 561790, XrefRangeEnd = 561791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_RunStateMachineBase_Public_Virtual_Final_New_IEnumerable_1_Action_ActiveAbility_Match_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x0003EA40 File Offset: 0x0003CC40
		[CallerCount(0)]
		public unsafe virtual IEnumerable<Canis.actions.Action> BeginExecution(TActiveAbility activeAbility, TMatch match, Context context)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_BeginExecution_Protected_Abstract_Virtual_New_IEnumerable_1_Action_TActiveAbility_TMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr3;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr5) : null;
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x0003EB2C File Offset: 0x0003CD2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 561792, XrefRangeEnd = 561795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<Canis.actions.Action> CompletedExecution(TActiveAbility activeAbility, TMatch match, Context context)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_CompletedExecution_Protected_Virtual_New_IEnumerable_1_Action_TActiveAbility_TMatch_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr3;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr5) : null;
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x0003EC18 File Offset: 0x0003CE18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 561795, XrefRangeEnd = 561799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_ResumeExecutionBase_Public_Virtual_Final_New_Int32_ActiveAbility_Action_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x0003EC8C File Offset: 0x0003CE8C
		[CallerCount(0)]
		public unsafe virtual int ResumeExecution(TActiveAbility activeAbility, Canis.actions.Action returningAction, Context context)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_ResumeExecution_Public_Abstract_Virtual_New_Int32_TActiveAbility_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000900 RID: 2304 RVA: 0x0003ED40 File Offset: 0x0003CF40
		public unsafe virtual IComparer<int> Ordering
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 561799, XrefRangeEnd = 561802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_get_Ordering_Public_Virtual_New_get_IComparer_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IComparer<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x0003ED8C File Offset: 0x0003CF8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 561802, XrefRangeEnd = 561810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public IEnumerable<TargetType> GetTargetsFromQueue<TargetType>(Context context) where TargetType : Entity
		{
			/*
An exception occurred when decompiling this method (06000901)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Il2CppSystem.Collections.Generic.IEnumerable`1<TargetType> Canis.entities.AbilityStateMachineDefinition`3::GetTargetsFromQueue<TargetType>(Canis.context.Context)

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'count')
   at System.Collections.Generic.List`1.GetRange(Int32 index, Int32 count)
   at ICSharpCode.Decompiler.Ast.AstBuilder.ApplyTypeArgumentsTo(AstType baseType, List`1 typeArguments) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 947
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(TypeSig type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 712
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 874
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 268
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 252
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 150
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1686
*/;
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x0003EDDC File Offset: 0x0003CFDC
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 561825, RefRangeEnd = 561842, XrefRangeStart = 561810, XrefRangeEnd = 561825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public IEnumerable<TargetType> GetTargetsFromQueue<TargetType>(TargetResponseQueue trq) where TargetType : Entity
		{
			/*
An exception occurred when decompiling this method (06000902)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Il2CppSystem.Collections.Generic.IEnumerable`1<TargetType> Canis.entities.AbilityStateMachineDefinition`3::GetTargetsFromQueue<TargetType>(Canis.context.targetpickers.TargetResponseQueue)

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'count')
   at System.Collections.Generic.List`1.GetRange(Int32 index, Int32 count)
   at ICSharpCode.Decompiler.Ast.AstBuilder.ApplyTypeArgumentsTo(AstType baseType, List`1 typeArguments) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 947
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(TypeSig type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 712
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 874
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node)
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 252
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 150
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1686
*/;
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x0003EE2C File Offset: 0x0003D02C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 561842, XrefRangeEnd = 561852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public TargetType GetTargetFromQueue<TargetType>(Context context) where TargetType : Entity
		{
			/*
An exception occurred when decompiling this method (06000903)

ICSharpCode.Decompiler.DecompilerException: Error decompiling TargetType Canis.entities.AbilityStateMachineDefinition`3::GetTargetFromQueue<TargetType>(Canis.context.Context)

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'count')
   at System.Collections.Generic.List`1.GetRange(Int32 index, Int32 count)
   at ICSharpCode.Decompiler.Ast.AstBuilder.ApplyTypeArgumentsTo(AstType baseType, List`1 typeArguments) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 947
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(TypeSig type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 712
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 874
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node)
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 252
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 150
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1686
*/;
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x0003EE78 File Offset: 0x0003D078
		[CallerCount(46)]
		[CachedScanResults(RefRangeStart = 561855, RefRangeEnd = 561901, XrefRangeStart = 561852, XrefRangeEnd = 561855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public TargetType GetTargetFromQueue<TargetType>(TargetResponseQueue trq) where TargetType : Entity
		{
			/*
An exception occurred when decompiling this method (06000904)

ICSharpCode.Decompiler.DecompilerException: Error decompiling TargetType Canis.entities.AbilityStateMachineDefinition`3::GetTargetFromQueue<TargetType>(Canis.context.targetpickers.TargetResponseQueue)

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'count')
   at System.Collections.Generic.List`1.GetRange(Int32 index, Int32 count)
   at ICSharpCode.Decompiler.Ast.AstBuilder.ApplyTypeArgumentsTo(AstType baseType, List`1 typeArguments) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 947
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(TypeSig type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 712
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 874
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node)
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 252
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 150
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1686
*/;
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x0003EEC4 File Offset: 0x0003D0C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 561901, XrefRangeEnd = 561919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MutableAttribute<AIEvaluator> MakeEvaluatorAttribute(AIEvaluateSelection abilityEvaluator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(abilityEvaluator);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_MakeEvaluatorAttribute_Protected_MutableAttribute_1_AIEvaluator_AIEvaluateSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MutableAttribute<AIEvaluator>>(intPtr3) : null;
			}
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x0003EF14 File Offset: 0x0003D114
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 561977, RefRangeEnd = 561978, XrefRangeStart = 561919, XrefRangeEnd = 561977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual EntityListTargetInformation MakeEntityListTargetInformation(IEnumerable<Entity> targets, PlayerEntity player, LocalizableTextVariables prompt, AIEvaluateSelection evaluator = null, string kind = null, bool forced = true, bool deferDrag = false, int max = 1, int min = -1, IEnumerable<IAttribute> attributes = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targets);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(prompt);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(evaluator);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(kind);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forced;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deferDrag;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_MakeEntityListTargetInformation_Protected_Virtual_New_EntityListTargetInformation_IEnumerable_1_Entity_PlayerEntity_LocalizableTextVariables_AIEvaluateSelection_String_Boolean_Boolean_Int32_Int32_IEnumerable_1_IAttribute_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityListTargetInformation>(intPtr3) : null;
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x0003F008 File Offset: 0x0003D208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 561978, XrefRangeEnd = 562020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ArchetypeCustomChoiceTargetInformation MakeArchetypeCustomChoiceTargetInformation(IEnumerable<SerializableAttributes> choices, PlayerEntity player, LocalizableTextVariables prompt, AIEvaluateSelection evaluator = null, string kind = null, bool forced = true, bool deferDrag = false, int max = 1, int min = -1, IEnumerable<IAttribute> attributes = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(choices);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(prompt);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(evaluator);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(kind);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forced;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deferDrag;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.NativeMethodInfoPtr_MakeArchetypeCustomChoiceTargetInformation_Protected_Virtual_New_ArchetypeCustomChoiceTargetInformation_IEnumerable_1_SerializableAttributes_PlayerEntity_LocalizableTextVariables_AIEvaluateSelection_String_Boolean_Boolean_Int32_Int32_IEnumerable_1_IAttribute_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeCustomChoiceTargetInformation>(intPtr3) : null;
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x0003F0FC File Offset: 0x0003D2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 562020, XrefRangeEnd = 562036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public IEnumerable<TargetType> _GetTargetsFromQueue_b__16_0<TargetType>(EntityID id) where TargetType : Entity
		{
			/*
An exception occurred when decompiling this method (06000908)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Il2CppSystem.Collections.Generic.IEnumerable`1<TargetType> Canis.entities.AbilityStateMachineDefinition`3::_GetTargetsFromQueue_b__16_0<TargetType>(Canis.utils.ids.EntityID)

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'count')
   at System.Collections.Generic.List`1.GetRange(Int32 index, Int32 count)
   at ICSharpCode.Decompiler.Ast.AstBuilder.ApplyTypeArgumentsTo(AstType baseType, List`1 typeArguments) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 947
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(TypeSig type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 712
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 874
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node)
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 252
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 150
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1686
*/;
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x0000574B File Offset: 0x0000394B
		public AbilityStateMachineDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x0600090A RID: 2314 RVA: 0x0003F14C File Offset: 0x0003D34C
		// (set) Token: 0x0600090B RID: 2315 RVA: 0x00005754 File Offset: 0x00003954
		public unsafe AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition> stateMachine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.NativeFieldInfoPtr_stateMachine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityStateMachine<TMatch, TActiveAbility, TAbilityDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.NativeFieldInfoPtr_stateMachine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x0003F17C File Offset: 0x0003D37C
		// (set) Token: 0x0600090D RID: 2317 RVA: 0x00005773 File Offset: 0x00003973
		public unsafe static int BeginExecutionState
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.NativeFieldInfoPtr_BeginExecutionState, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.NativeFieldInfoPtr_BeginExecutionState, (void*)(&value));
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x0600090E RID: 2318 RVA: 0x0003F198 File Offset: 0x0003D398
		// (set) Token: 0x0600090F RID: 2319 RVA: 0x00005781 File Offset: 0x00003981
		public unsafe static int CompletedExecutionState
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.NativeFieldInfoPtr_CompletedExecutionState, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.NativeFieldInfoPtr_CompletedExecutionState, (void*)(&value));
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000910 RID: 2320 RVA: 0x0003F1B4 File Offset: 0x0003D3B4
		// (set) Token: 0x06000911 RID: 2321 RVA: 0x0000578F File Offset: 0x0000398F
		public unsafe static int CanceledExecutionState
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.NativeFieldInfoPtr_CanceledExecutionState, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.NativeFieldInfoPtr_CanceledExecutionState, (void*)(&value));
			}
		}

		// Token: 0x04000616 RID: 1558
		private static readonly IntPtr NativeFieldInfoPtr_stateMachine;

		// Token: 0x04000617 RID: 1559
		private static readonly IntPtr NativeFieldInfoPtr_BeginExecutionState;

		// Token: 0x04000618 RID: 1560
		private static readonly IntPtr NativeFieldInfoPtr_CompletedExecutionState;

		// Token: 0x04000619 RID: 1561
		private static readonly IntPtr NativeFieldInfoPtr_CanceledExecutionState;

		// Token: 0x0400061A RID: 1562
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_TMatch_String_PlayerEntity_0;

		// Token: 0x0400061B RID: 1563
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializedEntity_TMatch_Entity_0;

		// Token: 0x0400061C RID: 1564
		private static readonly IntPtr NativeMethodInfoPtr_AddBinding_Public_Virtual_Final_New_Void_Int32_StateBehavior_3_TMatch_TActiveAbility_TAbilityDefinition_0;

		// Token: 0x0400061D RID: 1565
		private static readonly IntPtr NativeMethodInfoPtr_Action_Public_Virtual_Final_IEnumerable_1_Action_Match_Context_0;

		// Token: 0x0400061E RID: 1566
		private static readonly IntPtr NativeMethodInfoPtr_RunStateMachineBase_Public_Virtual_Final_New_IEnumerable_1_Action_ActiveAbility_Match_Context_0;

		// Token: 0x0400061F RID: 1567
		private static readonly IntPtr NativeMethodInfoPtr_BeginExecution_Protected_Abstract_Virtual_New_IEnumerable_1_Action_TActiveAbility_TMatch_Context_0;

		// Token: 0x04000620 RID: 1568
		private static readonly IntPtr NativeMethodInfoPtr_CompletedExecution_Protected_Virtual_New_IEnumerable_1_Action_TActiveAbility_TMatch_Context_0;

		// Token: 0x04000621 RID: 1569
		private static readonly IntPtr NativeMethodInfoPtr_ResumeExecutionBase_Public_Virtual_Final_New_Int32_ActiveAbility_Action_Context_0;

		// Token: 0x04000622 RID: 1570
		private static readonly IntPtr NativeMethodInfoPtr_ResumeExecution_Public_Abstract_Virtual_New_Int32_TActiveAbility_Action_Context_0;

		// Token: 0x04000623 RID: 1571
		private static readonly IntPtr NativeMethodInfoPtr_get_Ordering_Public_Virtual_New_get_IComparer_1_Int32_0;

		// Token: 0x04000624 RID: 1572
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetsFromQueue_Public_IEnumerable_1_TargetType_Context_0;

		// Token: 0x04000625 RID: 1573
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetsFromQueue_Public_IEnumerable_1_TargetType_TargetResponseQueue_0;

		// Token: 0x04000626 RID: 1574
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetFromQueue_Public_TargetType_Context_0;

		// Token: 0x04000627 RID: 1575
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetFromQueue_Public_TargetType_TargetResponseQueue_0;

		// Token: 0x04000628 RID: 1576
		private static readonly IntPtr NativeMethodInfoPtr_MakeEvaluatorAttribute_Protected_MutableAttribute_1_AIEvaluator_AIEvaluateSelection_0;

		// Token: 0x04000629 RID: 1577
		private static readonly IntPtr NativeMethodInfoPtr_MakeEntityListTargetInformation_Protected_Virtual_New_EntityListTargetInformation_IEnumerable_1_Entity_PlayerEntity_LocalizableTextVariables_AIEvaluateSelection_String_Boolean_Boolean_Int32_Int32_IEnumerable_1_IAttribute_0;

		// Token: 0x0400062A RID: 1578
		private static readonly IntPtr NativeMethodInfoPtr_MakeArchetypeCustomChoiceTargetInformation_Protected_Virtual_New_ArchetypeCustomChoiceTargetInformation_IEnumerable_1_SerializableAttributes_PlayerEntity_LocalizableTextVariables_AIEvaluateSelection_String_Boolean_Boolean_Int32_Int32_IEnumerable_1_IAttribute_0;

		// Token: 0x0400062B RID: 1579
		private static readonly IntPtr NativeMethodInfoPtr__GetTargetsFromQueue_b__16_0_Private_IEnumerable_1_TargetType_EntityID_0;

		// Token: 0x02000305 RID: 773
		[ObfuscatedName("Canis.entities.AbilityStateMachineDefinition`3+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06002017 RID: 8215 RVA: 0x00093020 File Offset: 0x00091220
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TActiveAbility>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAbilityDefinition>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.__c>.NativeClassPtr);
				AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.__c>.NativeClassPtr, "<>9");
				AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.__c.NativeFieldInfoPtr___9__20_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.__c>.NativeClassPtr, "<>9__20_0");
				AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.__c>.NativeClassPtr, 100665174);
				AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.__c.NativeMethodInfoPtr__MakeEntityListTargetInformation_b__20_0_Internal_EntityID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.__c>.NativeClassPtr, 100665175);
			}

			// Token: 0x06002018 RID: 8216 RVA: 0x000930FC File Offset: 0x000912FC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002019 RID: 8217 RVA: 0x00093138 File Offset: 0x00091338
			[CallerCount(0)]
			public unsafe EntityID _MakeEntityListTargetInformation_b__20_0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.__c.NativeMethodInfoPtr__MakeEntityListTargetInformation_b__20_0_Internal_EntityID_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x0600201A RID: 8218 RVA: 0x0000F6AA File Offset: 0x0000D8AA
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700079B RID: 1947
			// (get) Token: 0x0600201B RID: 8219 RVA: 0x00093188 File Offset: 0x00091388
			// (set) Token: 0x0600201C RID: 8220 RVA: 0x0000F6B3 File Offset: 0x0000D8B3
			public unsafe static AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700079C RID: 1948
			// (get) Token: 0x0600201D RID: 8221 RVA: 0x000931B0 File Offset: 0x000913B0
			// (set) Token: 0x0600201E RID: 8222 RVA: 0x0000F6C5 File Offset: 0x0000D8C5
			public unsafe static Func<Entity, EntityID> __9__20_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.__c.NativeFieldInfoPtr___9__20_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>.__c.NativeFieldInfoPtr___9__20_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001438 RID: 5176
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001439 RID: 5177
			private static readonly IntPtr NativeFieldInfoPtr___9__20_0;

			// Token: 0x0400143A RID: 5178
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400143B RID: 5179
			private static readonly IntPtr NativeMethodInfoPtr__MakeEntityListTargetInformation_b__20_0_Internal_EntityID_Entity_0;
		}

		// Token: 0x02000306 RID: 774
		[ObfuscatedName("Canis.entities.AbilityStateMachineDefinition`3+<Action>d__7")]
		public sealed class _Action_d__7 : Object
		{
			// Token: 0x0600201F RID: 8223 RVA: 0x000931D8 File Offset: 0x000913D8
			// Note: this type is marked as 'beforefieldinit'.
			static _Action_d__7()
			{
				Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, "<Action>d__7"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TActiveAbility>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAbilityDefinition>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7>.NativeClassPtr);
				AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7>.NativeClassPtr, "<>1__state");
				AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7>.NativeClassPtr, "<>2__current");
				AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7>.NativeClassPtr, "<>l__initialThreadId");
				AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7>.NativeClassPtr, "match");
				AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeFieldInfoPtr___3__match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7>.NativeClassPtr, "<>3__match");
				AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7>.NativeClassPtr, "<>4__this");
				AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7>.NativeClassPtr, "context");
				AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7>.NativeClassPtr, "<>3__context");
				AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7>.NativeClassPtr, "<>7__wrap1");
				AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7>.NativeClassPtr, 100665176);
				AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7>.NativeClassPtr, 100665177);
				AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7>.NativeClassPtr, 100665178);
				AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7>.NativeClassPtr, 100665179);
				AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7>.NativeClassPtr, 100665180);
				AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7>.NativeClassPtr, 100665181);
				AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7>.NativeClassPtr, 100665182);
				AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7>.NativeClassPtr, 100665183);
				AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7>.NativeClassPtr, 100665184);
			}

			// Token: 0x06002020 RID: 8224 RVA: 0x000933CC File Offset: 0x000915CC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Action_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002021 RID: 8225 RVA: 0x00093414 File Offset: 0x00091614
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 561671, XrefRangeEnd = 561676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002022 RID: 8226 RVA: 0x00093448 File Offset: 0x00091648
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 561676, XrefRangeEnd = 561709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002023 RID: 8227 RVA: 0x00093484 File Offset: 0x00091684
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 561709, XrefRangeEnd = 561712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170007A6 RID: 1958
			// (get) Token: 0x06002024 RID: 8228 RVA: 0x000934B8 File Offset: 0x000916B8
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06002025 RID: 8229 RVA: 0x000934F8 File Offset: 0x000916F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170007A7 RID: 1959
			// (get) Token: 0x06002026 RID: 8230 RVA: 0x0009352C File Offset: 0x0009172C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002027 RID: 8231 RVA: 0x0009356C File Offset: 0x0009176C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 561712, XrefRangeEnd = 561721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06002028 RID: 8232 RVA: 0x000935AC File Offset: 0x000917AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 561721, XrefRangeEnd = 561730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002029 RID: 8233 RVA: 0x0000F6D7 File Offset: 0x0000D8D7
			public _Action_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700079D RID: 1949
			// (get) Token: 0x0600202A RID: 8234 RVA: 0x000935EC File Offset: 0x000917EC
			// (set) Token: 0x0600202B RID: 8235 RVA: 0x0000F6E0 File Offset: 0x0000D8E0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700079E RID: 1950
			// (get) Token: 0x0600202C RID: 8236 RVA: 0x00093614 File Offset: 0x00091814
			// (set) Token: 0x0600202D RID: 8237 RVA: 0x0000F6FB File Offset: 0x0000D8FB
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700079F RID: 1951
			// (get) Token: 0x0600202E RID: 8238 RVA: 0x00093644 File Offset: 0x00091844
			// (set) Token: 0x0600202F RID: 8239 RVA: 0x0000F71A File Offset: 0x0000D91A
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170007A0 RID: 1952
			// (get) Token: 0x06002030 RID: 8240 RVA: 0x0009366C File Offset: 0x0009186C
			// (set) Token: 0x06002031 RID: 8241 RVA: 0x0000F735 File Offset: 0x0000D935
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007A1 RID: 1953
			// (get) Token: 0x06002032 RID: 8242 RVA: 0x0009369C File Offset: 0x0009189C
			// (set) Token: 0x06002033 RID: 8243 RVA: 0x0000F754 File Offset: 0x0000D954
			public unsafe Match __3__match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeFieldInfoPtr___3__match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeFieldInfoPtr___3__match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007A2 RID: 1954
			// (get) Token: 0x06002034 RID: 8244 RVA: 0x000936CC File Offset: 0x000918CC
			// (set) Token: 0x06002035 RID: 8245 RVA: 0x0000F773 File Offset: 0x0000D973
			public unsafe AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007A3 RID: 1955
			// (get) Token: 0x06002036 RID: 8246 RVA: 0x000936FC File Offset: 0x000918FC
			// (set) Token: 0x06002037 RID: 8247 RVA: 0x0000F792 File Offset: 0x0000D992
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007A4 RID: 1956
			// (get) Token: 0x06002038 RID: 8248 RVA: 0x0009372C File Offset: 0x0009192C
			// (set) Token: 0x06002039 RID: 8249 RVA: 0x0000F7B1 File Offset: 0x0000D9B1
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007A5 RID: 1957
			// (get) Token: 0x0600203A RID: 8250 RVA: 0x0009375C File Offset: 0x0009195C
			// (set) Token: 0x0600203B RID: 8251 RVA: 0x0000F7D0 File Offset: 0x0000D9D0
			public unsafe IEnumerator<Canis.actions.Action> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._Action_d__7.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400143C RID: 5180
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400143D RID: 5181
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400143E RID: 5182
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400143F RID: 5183
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04001440 RID: 5184
			private static readonly IntPtr NativeFieldInfoPtr___3__match;

			// Token: 0x04001441 RID: 5185
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001442 RID: 5186
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04001443 RID: 5187
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x04001444 RID: 5188
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001445 RID: 5189
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001446 RID: 5190
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001447 RID: 5191
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001448 RID: 5192
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001449 RID: 5193
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400144A RID: 5194
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400144B RID: 5195
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400144C RID: 5196
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x0400144D RID: 5197
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000307 RID: 775
		[ObfuscatedName("Canis.entities.AbilityStateMachineDefinition`3+<CompletedExecution>d__10")]
		public sealed class _CompletedExecution_d__10 : Object
		{
			// Token: 0x0600203C RID: 8252 RVA: 0x0009378C File Offset: 0x0009198C
			// Note: this type is marked as 'beforefieldinit'.
			static _CompletedExecution_d__10()
			{
				Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._CompletedExecution_d__10>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>>.NativeClassPtr, "<CompletedExecution>d__10"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TActiveAbility>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAbilityDefinition>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._CompletedExecution_d__10>.NativeClassPtr);
				AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._CompletedExecution_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._CompletedExecution_d__10>.NativeClassPtr, "<>1__state");
				AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._CompletedExecution_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._CompletedExecution_d__10>.NativeClassPtr, "<>2__current");
				AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._CompletedExecution_d__10.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._CompletedExecution_d__10>.NativeClassPtr, "<>l__initialThreadId");
				AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._CompletedExecution_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._CompletedExecution_d__10>.NativeClassPtr, 100665185);
				AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._CompletedExecution_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._CompletedExecution_d__10>.NativeClassPtr, 100665186);
				AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._CompletedExecution_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._CompletedExecution_d__10>.NativeClassPtr, 100665187);
				AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._CompletedExecution_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._CompletedExecution_d__10>.NativeClassPtr, 100665188);
				AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._CompletedExecution_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._CompletedExecution_d__10>.NativeClassPtr, 100665189);
				AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._CompletedExecution_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._CompletedExecution_d__10>.NativeClassPtr, 100665190);
				AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._CompletedExecution_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._CompletedExecution_d__10>.NativeClassPtr, 100665191);
				AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._CompletedExecution_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._CompletedExecution_d__10>.NativeClassPtr, 100665192);
			}

			// Token: 0x0600203D RID: 8253 RVA: 0x000938F4 File Offset: 0x00091AF4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CompletedExecution_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._CompletedExecution_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._CompletedExecution_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600203E RID: 8254 RVA: 0x0009393C File Offset: 0x00091B3C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._CompletedExecution_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600203F RID: 8255 RVA: 0x00093970 File Offset: 0x00091B70
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._CompletedExecution_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170007AB RID: 1963
			// (get) Token: 0x06002040 RID: 8256 RVA: 0x000939AC File Offset: 0x00091BAC
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._CompletedExecution_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06002041 RID: 8257 RVA: 0x000939EC File Offset: 0x00091BEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._CompletedExecution_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170007AC RID: 1964
			// (get) Token: 0x06002042 RID: 8258 RVA: 0x00093A20 File Offset: 0x00091C20
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._CompletedExecution_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002043 RID: 8259 RVA: 0x00093A60 File Offset: 0x00091C60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._CompletedExecution_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06002044 RID: 8260 RVA: 0x00093AA0 File Offset: 0x00091CA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._CompletedExecution_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002045 RID: 8261 RVA: 0x0000F7EF File Offset: 0x0000D9EF
			public _CompletedExecution_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007A8 RID: 1960
			// (get) Token: 0x06002046 RID: 8262 RVA: 0x00093AE0 File Offset: 0x00091CE0
			// (set) Token: 0x06002047 RID: 8263 RVA: 0x0000F7F8 File Offset: 0x0000D9F8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._CompletedExecution_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._CompletedExecution_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007A9 RID: 1961
			// (get) Token: 0x06002048 RID: 8264 RVA: 0x00093B08 File Offset: 0x00091D08
			// (set) Token: 0x06002049 RID: 8265 RVA: 0x0000F813 File Offset: 0x0000DA13
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._CompletedExecution_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._CompletedExecution_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007AA RID: 1962
			// (get) Token: 0x0600204A RID: 8266 RVA: 0x00093B38 File Offset: 0x00091D38
			// (set) Token: 0x0600204B RID: 8267 RVA: 0x0000F832 File Offset: 0x0000DA32
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._CompletedExecution_d__10.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateMachineDefinition<TMatch, TActiveAbility, TAbilityDefinition>._CompletedExecution_d__10.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x0400144E RID: 5198
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400144F RID: 5199
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001450 RID: 5200
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001451 RID: 5201
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001452 RID: 5202
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001453 RID: 5203
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001454 RID: 5204
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001455 RID: 5205
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001456 RID: 5206
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001457 RID: 5207
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001458 RID: 5208
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000308 RID: 776
		private sealed class MethodInfoStoreGeneric_GetTargetsFromQueue_Public_IEnumerable_1_TargetType_Context_0
		{
			// Token: 0x0600204C RID: 8268 RVA: 0x00093B60 File Offset: 0x00091D60
			// Note: this type is marked as 'beforefieldinit'.
			static MethodInfoStoreGeneric_GetTargetsFromQueue_Public_IEnumerable_1_TargetType_Context_0()
			{
				/*
An exception occurred when decompiling this method (0600204C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Canis.entities.AbilityStateMachineDefinition`3/MethodInfoStoreGeneric_GetTargetsFromQueue_Public_IEnumerable_1_TargetType_Context_0`1::.cctor()

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'count')
   at System.Collections.Generic.List`1.GetRange(Int32 index, Int32 count)
   at ICSharpCode.Decompiler.Ast.AstBuilder.ApplyTypeArgumentsTo(AstType baseType, List`1 typeArguments) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 947
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(TypeSig type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 712
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 881
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node)
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 252
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 150
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1686
*/;
			}

			// Token: 0x04001459 RID: 5209
			internal static IntPtr Pointer;
		}

		// Token: 0x02000309 RID: 777
		private sealed class MethodInfoStoreGeneric_GetTargetsFromQueue_Public_IEnumerable_1_TargetType_TargetResponseQueue_0
		{
			// Token: 0x0600204D RID: 8269 RVA: 0x00093BB4 File Offset: 0x00091DB4
			// Note: this type is marked as 'beforefieldinit'.
			static MethodInfoStoreGeneric_GetTargetsFromQueue_Public_IEnumerable_1_TargetType_TargetResponseQueue_0()
			{
				/*
An exception occurred when decompiling this method (0600204D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Canis.entities.AbilityStateMachineDefinition`3/MethodInfoStoreGeneric_GetTargetsFromQueue_Public_IEnumerable_1_TargetType_TargetResponseQueue_0`1::.cctor()

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'count')
   at System.Collections.Generic.List`1.GetRange(Int32 index, Int32 count)
   at ICSharpCode.Decompiler.Ast.AstBuilder.ApplyTypeArgumentsTo(AstType baseType, List`1 typeArguments) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 947
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(TypeSig type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 712
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 881
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node)
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 252
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 150
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1686
*/;
			}

			// Token: 0x0400145A RID: 5210
			internal static IntPtr Pointer;
		}

		// Token: 0x0200030A RID: 778
		private sealed class MethodInfoStoreGeneric_GetTargetFromQueue_Public_TargetType_Context_0
		{
			// Token: 0x0600204E RID: 8270 RVA: 0x00093C08 File Offset: 0x00091E08
			// Note: this type is marked as 'beforefieldinit'.
			static MethodInfoStoreGeneric_GetTargetFromQueue_Public_TargetType_Context_0()
			{
				/*
An exception occurred when decompiling this method (0600204E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Canis.entities.AbilityStateMachineDefinition`3/MethodInfoStoreGeneric_GetTargetFromQueue_Public_TargetType_Context_0`1::.cctor()

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'count')
   at System.Collections.Generic.List`1.GetRange(Int32 index, Int32 count)
   at ICSharpCode.Decompiler.Ast.AstBuilder.ApplyTypeArgumentsTo(AstType baseType, List`1 typeArguments) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 947
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(TypeSig type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 712
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 881
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node)
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 252
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 150
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1686
*/;
			}

			// Token: 0x0400145B RID: 5211
			internal static IntPtr Pointer;
		}

		// Token: 0x0200030B RID: 779
		private sealed class MethodInfoStoreGeneric_GetTargetFromQueue_Public_TargetType_TargetResponseQueue_0
		{
			// Token: 0x0600204F RID: 8271 RVA: 0x00093C5C File Offset: 0x00091E5C
			// Note: this type is marked as 'beforefieldinit'.
			static MethodInfoStoreGeneric_GetTargetFromQueue_Public_TargetType_TargetResponseQueue_0()
			{
				/*
An exception occurred when decompiling this method (0600204F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Canis.entities.AbilityStateMachineDefinition`3/MethodInfoStoreGeneric_GetTargetFromQueue_Public_TargetType_TargetResponseQueue_0`1::.cctor()

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'count')
   at System.Collections.Generic.List`1.GetRange(Int32 index, Int32 count)
   at ICSharpCode.Decompiler.Ast.AstBuilder.ApplyTypeArgumentsTo(AstType baseType, List`1 typeArguments) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 947
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(TypeSig type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 712
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 881
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node)
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 252
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 150
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1686
*/;
			}

			// Token: 0x0400145C RID: 5212
			internal static IntPtr Pointer;
		}

		// Token: 0x0200030C RID: 780
		private sealed class MethodInfoStoreGeneric__GetTargetsFromQueue_b__16_0_Private_IEnumerable_1_TargetType_EntityID_0
		{
			// Token: 0x06002050 RID: 8272 RVA: 0x00093CB0 File Offset: 0x00091EB0
			// Note: this type is marked as 'beforefieldinit'.
			static MethodInfoStoreGeneric__GetTargetsFromQueue_b__16_0_Private_IEnumerable_1_TargetType_EntityID_0()
			{
				/*
An exception occurred when decompiling this method (06002050)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Canis.entities.AbilityStateMachineDefinition`3/MethodInfoStoreGeneric__GetTargetsFromQueue_b__16_0_Private_IEnumerable_1_TargetType_EntityID_0`1::.cctor()

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'count')
   at System.Collections.Generic.List`1.GetRange(Int32 index, Int32 count)
   at ICSharpCode.Decompiler.Ast.AstBuilder.ApplyTypeArgumentsTo(AstType baseType, List`1 typeArguments) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 947
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(TypeSig type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 712
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 881
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node)
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 252
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 150
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1686
*/;
			}

			// Token: 0x0400145D RID: 5213
			internal static IntPtr Pointer;
		}
	}
}
