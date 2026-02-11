using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Canis.entities
{
	// Token: 0x020000CB RID: 203
	public class IHasStateBehaviorBindings<TMatch, TActiveAbility, TAbilityDefinition, TBehavior> : Il2CppObjectBase where TMatch : Match where TActiveAbility : ActiveAbility<TMatch, TAbilityDefinition> where TAbilityDefinition : AbilityDefinitionForGame<TMatch> where TBehavior : StateBehaviorV2<TMatch, TActiveAbility, TAbilityDefinition>
	{
		// Token: 0x0600092E RID: 2350 RVA: 0x0003F9C8 File Offset: 0x0003DBC8
		// Note: this type is marked as 'beforefieldinit'.
		static IHasStateBehaviorBindings()
		{
			Il2CppClassPointerStore<IHasStateBehaviorBindings<TMatch, TActiveAbility, TAbilityDefinition, TBehavior>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "IHasStateBehaviorBindings`4"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TActiveAbility>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAbilityDefinition>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TBehavior>.NativeClassPtr))
			})).TypeHandle.value);
			IHasStateBehaviorBindings<TMatch, TActiveAbility, TAbilityDefinition, TBehavior>.NativeMethodInfoPtr_AddBinding_Public_Abstract_Virtual_New_Void_Int32_StateAction_3_TMatch_TActiveAbility_TAbilityDefinition_Transition_1_TActiveAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasStateBehaviorBindings<TMatch, TActiveAbility, TAbilityDefinition, TBehavior>>.NativeClassPtr, 100665203);
			IHasStateBehaviorBindings<TMatch, TActiveAbility, TAbilityDefinition, TBehavior>.NativeMethodInfoPtr_AddBindingSequence_Public_Abstract_Virtual_New_Void_Int32_Transition_1_TActiveAbility_StateAction_3_TMatch_TActiveAbility_TAbilityDefinition_Il2CppReferenceArray_1_StateAction_3_TMatch_TActiveAbility_TAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasStateBehaviorBindings<TMatch, TActiveAbility, TAbilityDefinition, TBehavior>>.NativeClassPtr, 100665204);
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x0003FA88 File Offset: 0x0003DC88
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasStateBehaviorBindings<TMatch, TActiveAbility, TAbilityDefinition, TBehavior>.NativeMethodInfoPtr_AddBinding_Public_Abstract_Virtual_New_Void_Int32_StateAction_3_TMatch_TActiveAbility_TAbilityDefinition_Transition_1_TActiveAbility_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x0003FAF8 File Offset: 0x0003DCF8
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IHasStateBehaviorBindings<TMatch, TActiveAbility, TAbilityDefinition, TBehavior>.NativeMethodInfoPtr_AddBindingSequence_Public_Abstract_Virtual_New_Void_Int32_Transition_1_TActiveAbility_StateAction_3_TMatch_TActiveAbility_TAbilityDefinition_Il2CppReferenceArray_1_StateAction_3_TMatch_TActiveAbility_TAbilityDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x00005886 File Offset: 0x00003A86
		public virtual void AddBindingSequence(int state, Transition<TActiveAbility> transition, StateAction<TMatch, TActiveAbility, TAbilityDefinition> initialAction, params StateAction<TMatch, TActiveAbility, TAbilityDefinition>[] actions)
		{
			this.AddBindingSequence(state, transition, initialAction, new Il2CppReferenceArray<StateAction<TMatch, TActiveAbility, TAbilityDefinition>>(actions));
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x00005898 File Offset: 0x00003A98
		public IHasStateBehaviorBindings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000638 RID: 1592
		private static readonly IntPtr NativeMethodInfoPtr_AddBinding_Public_Abstract_Virtual_New_Void_Int32_StateAction_3_TMatch_TActiveAbility_TAbilityDefinition_Transition_1_TActiveAbility_0;

		// Token: 0x04000639 RID: 1593
		private static readonly IntPtr NativeMethodInfoPtr_AddBindingSequence_Public_Abstract_Virtual_New_Void_Int32_Transition_1_TActiveAbility_StateAction_3_TMatch_TActiveAbility_TAbilityDefinition_Il2CppReferenceArray_1_StateAction_3_TMatch_TActiveAbility_TAbilityDefinition_0;
	}
}
