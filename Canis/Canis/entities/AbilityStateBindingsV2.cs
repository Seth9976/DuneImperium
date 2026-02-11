using System;
using System.Runtime.InteropServices;
using Canis.actions;
using Canis.context;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.entities
{
	// Token: 0x020000CC RID: 204
	public class AbilityStateBindingsV2<TMatch, TActiveAbility, TAbilityDefinition, TBehavior> : AbilityStateBindings<TBehavior> where TMatch : Match where TActiveAbility : ActiveAbility<TMatch, TAbilityDefinition> where TAbilityDefinition : AbilityDefinitionForGame<TMatch> where TBehavior : StateBehaviorV2<TMatch, TActiveAbility, TAbilityDefinition>, new()
	{
		// Token: 0x06000933 RID: 2355 RVA: 0x0003FB88 File Offset: 0x0003DD88
		// Note: this type is marked as 'beforefieldinit'.
		static AbilityStateBindingsV2()
		{
			Il2CppClassPointerStore<AbilityStateBindingsV2<TMatch, TActiveAbility, TAbilityDefinition, TBehavior>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "AbilityStateBindingsV2`4"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TActiveAbility>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAbilityDefinition>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TBehavior>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityStateBindingsV2<TMatch, TActiveAbility, TAbilityDefinition, TBehavior>>.NativeClassPtr);
			AbilityStateBindingsV2<TMatch, TActiveAbility, TAbilityDefinition, TBehavior>.NativeMethodInfoPtr_Recurse_Public_Int32_TActiveAbility_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateBindingsV2<TMatch, TActiveAbility, TAbilityDefinition, TBehavior>>.NativeClassPtr, 100665205);
			AbilityStateBindingsV2<TMatch, TActiveAbility, TAbilityDefinition, TBehavior>.NativeMethodInfoPtr_SequenceTransition_Public_Transition_1_TActiveAbility_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateBindingsV2<TMatch, TActiveAbility, TAbilityDefinition, TBehavior>>.NativeClassPtr, 100665206);
			AbilityStateBindingsV2<TMatch, TActiveAbility, TAbilityDefinition, TBehavior>.NativeMethodInfoPtr_AddBinding_Public_Virtual_Final_New_Void_Int32_StateAction_3_TMatch_TActiveAbility_TAbilityDefinition_Transition_1_TActiveAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateBindingsV2<TMatch, TActiveAbility, TAbilityDefinition, TBehavior>>.NativeClassPtr, 100665207);
			AbilityStateBindingsV2<TMatch, TActiveAbility, TAbilityDefinition, TBehavior>.NativeMethodInfoPtr_AddBindingSequence_Public_Virtual_Final_New_Void_Int32_Transition_1_TActiveAbility_StateAction_3_TMatch_TActiveAbility_TAbilityDefinition_Il2CppReferenceArray_1_StateAction_3_TMatch_TActiveAbility_TAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateBindingsV2<TMatch, TActiveAbility, TAbilityDefinition, TBehavior>>.NativeClassPtr, 100665208);
			AbilityStateBindingsV2<TMatch, TActiveAbility, TAbilityDefinition, TBehavior>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateBindingsV2<TMatch, TActiveAbility, TAbilityDefinition, TBehavior>>.NativeClassPtr, 100665209);
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x0003FC90 File Offset: 0x0003DE90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25007, RefRangeEnd = 25008, XrefRangeStart = 25007, XrefRangeEnd = 25008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Recurse(TActiveAbility activeAbility, Canis.actions.Action lastAction, Context context)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AbilityStateBindingsV2<TMatch, TActiveAbility, TAbilityDefinition, TBehavior>.NativeMethodInfoPtr_Recurse_Public_Int32_TActiveAbility_Action_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x0003FD38 File Offset: 0x0003DF38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 562080, XrefRangeEnd = 562086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transition<TActiveAbility> SequenceTransition(int state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateBindingsV2<TMatch, TActiveAbility, TAbilityDefinition, TBehavior>.NativeMethodInfoPtr_SequenceTransition_Public_Transition_1_TActiveAbility_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transition<TActiveAbility>>(intPtr3) : null;
			}
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x0003FD84 File Offset: 0x0003DF84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 562091, RefRangeEnd = 562092, XrefRangeStart = 562086, XrefRangeEnd = 562091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateBindingsV2<TMatch, TActiveAbility, TAbilityDefinition, TBehavior>.NativeMethodInfoPtr_AddBinding_Public_Virtual_Final_New_Void_Int32_StateAction_3_TMatch_TActiveAbility_TAbilityDefinition_Transition_1_TActiveAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x0003FDE8 File Offset: 0x0003DFE8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 562111, RefRangeEnd = 562116, XrefRangeStart = 562092, XrefRangeEnd = 562111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateBindingsV2<TMatch, TActiveAbility, TAbilityDefinition, TBehavior>.NativeMethodInfoPtr_AddBindingSequence_Public_Virtual_Final_New_Void_Int32_Transition_1_TActiveAbility_StateAction_3_TMatch_TActiveAbility_TAbilityDefinition_Il2CppReferenceArray_1_StateAction_3_TMatch_TActiveAbility_TAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x0003FE6C File Offset: 0x0003E06C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 562116, XrefRangeEnd = 562117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AbilityStateBindingsV2()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityStateBindingsV2<TMatch, TActiveAbility, TAbilityDefinition, TBehavior>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateBindingsV2<TMatch, TActiveAbility, TAbilityDefinition, TBehavior>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x000058A1 File Offset: 0x00003AA1
		public virtual void AddBindingSequence(int state, Transition<TActiveAbility> transition, StateAction<TMatch, TActiveAbility, TAbilityDefinition> initialAction, params StateAction<TMatch, TActiveAbility, TAbilityDefinition>[] actions)
		{
			this.AddBindingSequence(state, transition, initialAction, new Il2CppReferenceArray<StateAction<TMatch, TActiveAbility, TAbilityDefinition>>(actions));
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x000058B3 File Offset: 0x00003AB3
		public AbilityStateBindingsV2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400063A RID: 1594
		private static readonly IntPtr NativeMethodInfoPtr_Recurse_Public_Int32_TActiveAbility_Action_Context_0;

		// Token: 0x0400063B RID: 1595
		private static readonly IntPtr NativeMethodInfoPtr_SequenceTransition_Public_Transition_1_TActiveAbility_Int32_0;

		// Token: 0x0400063C RID: 1596
		private static readonly IntPtr NativeMethodInfoPtr_AddBinding_Public_Virtual_Final_New_Void_Int32_StateAction_3_TMatch_TActiveAbility_TAbilityDefinition_Transition_1_TActiveAbility_0;

		// Token: 0x0400063D RID: 1597
		private static readonly IntPtr NativeMethodInfoPtr_AddBindingSequence_Public_Virtual_Final_New_Void_Int32_Transition_1_TActiveAbility_StateAction_3_TMatch_TActiveAbility_TAbilityDefinition_Il2CppReferenceArray_1_StateAction_3_TMatch_TActiveAbility_TAbilityDefinition_0;

		// Token: 0x0400063E RID: 1598
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0200030D RID: 781
		[ObfuscatedName("Canis.entities.AbilityStateBindingsV2`4+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x06002051 RID: 8273 RVA: 0x00093D04 File Offset: 0x00091F04
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<AbilityStateBindingsV2<TMatch, TActiveAbility, TAbilityDefinition, TBehavior>.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityStateBindingsV2<TMatch, TActiveAbility, TAbilityDefinition, TBehavior>>.NativeClassPtr, "<>c__DisplayClass1_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TActiveAbility>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAbilityDefinition>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TBehavior>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityStateBindingsV2<TMatch, TActiveAbility, TAbilityDefinition, TBehavior>.__c__DisplayClass1_0>.NativeClassPtr);
				AbilityStateBindingsV2<TMatch, TActiveAbility, TAbilityDefinition, TBehavior>.__c__DisplayClass1_0.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStateBindingsV2<TMatch, TActiveAbility, TAbilityDefinition, TBehavior>.__c__DisplayClass1_0>.NativeClassPtr, "state");
				AbilityStateBindingsV2<TMatch, TActiveAbility, TAbilityDefinition, TBehavior>.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateBindingsV2<TMatch, TActiveAbility, TAbilityDefinition, TBehavior>.__c__DisplayClass1_0>.NativeClassPtr, 100665210);
				AbilityStateBindingsV2<TMatch, TActiveAbility, TAbilityDefinition, TBehavior>.__c__DisplayClass1_0.NativeMethodInfoPtr__SequenceTransition_b__0_Internal_Int32_TActiveAbility_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStateBindingsV2<TMatch, TActiveAbility, TAbilityDefinition, TBehavior>.__c__DisplayClass1_0>.NativeClassPtr, 100665211);
			}

			// Token: 0x06002052 RID: 8274 RVA: 0x00093DDC File Offset: 0x00091FDC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityStateBindingsV2<TMatch, TActiveAbility, TAbilityDefinition, TBehavior>.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityStateBindingsV2<TMatch, TActiveAbility, TAbilityDefinition, TBehavior>.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002053 RID: 8275 RVA: 0x00093E18 File Offset: 0x00092018
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 562064, XrefRangeEnd = 562080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _SequenceTransition_b__0(TActiveAbility activeAbility, Canis.actions.Action lastAction, Context context)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AbilityStateBindingsV2<TMatch, TActiveAbility, TAbilityDefinition, TBehavior>.__c__DisplayClass1_0.NativeMethodInfoPtr__SequenceTransition_b__0_Internal_Int32_TActiveAbility_Action_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x06002054 RID: 8276 RVA: 0x0000F84D File Offset: 0x0000DA4D
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007AD RID: 1965
			// (get) Token: 0x06002055 RID: 8277 RVA: 0x00093EC0 File Offset: 0x000920C0
			// (set) Token: 0x06002056 RID: 8278 RVA: 0x0000F856 File Offset: 0x0000DA56
			public unsafe int state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateBindingsV2<TMatch, TActiveAbility, TAbilityDefinition, TBehavior>.__c__DisplayClass1_0.NativeFieldInfoPtr_state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityStateBindingsV2<TMatch, TActiveAbility, TAbilityDefinition, TBehavior>.__c__DisplayClass1_0.NativeFieldInfoPtr_state)) = value;
				}
			}

			// Token: 0x0400145E RID: 5214
			private static readonly IntPtr NativeFieldInfoPtr_state;

			// Token: 0x0400145F RID: 5215
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001460 RID: 5216
			private static readonly IntPtr NativeMethodInfoPtr__SequenceTransition_b__0_Internal_Int32_TActiveAbility_Action_Context_0;
		}
	}
}
