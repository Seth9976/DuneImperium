using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.actions
{
	// Token: 0x020001F2 RID: 498
	public class StateMachineActionV2<T> : StateMachineActionV2 where T : new()
	{
		// Token: 0x0600151D RID: 5405 RVA: 0x0006E7B4 File Offset: 0x0006C9B4
		// Note: this type is marked as 'beforefieldinit'.
		static StateMachineActionV2()
		{
			Il2CppClassPointerStore<StateMachineActionV2<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "StateMachineActionV2`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateMachineActionV2<T>>.NativeClassPtr);
			StateMachineActionV2<T>.NativeFieldInfoPtr_FormatProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineActionV2<T>>.NativeClassPtr, "FormatProvider");
			StateMachineActionV2<T>.NativeMethodInfoPtr_get_TypedCurrentState_Protected_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2<T>>.NativeClassPtr, 100668018);
			StateMachineActionV2<T>.NativeMethodInfoPtr__ctor_Protected_Void_Match_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2<T>>.NativeClassPtr, 100668019);
			StateMachineActionV2<T>.NativeMethodInfoPtr__ctor_Protected_Void_Match_SerializedStateMachineActionV2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2<T>>.NativeClassPtr, 100668020);
			StateMachineActionV2<T>.NativeMethodInfoPtr_AddTypedBinding_Protected_Void_T_TypedStateBehavior_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2<T>>.NativeClassPtr, 100668021);
			StateMachineActionV2<T>.NativeMethodInfoPtr_AddTypedBinding_Protected_Void_T_StateAction_TypedTransition_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2<T>>.NativeClassPtr, 100668022);
			StateMachineActionV2<T>.NativeMethodInfoPtr_AddTypedBindingSequence_Protected_Void_T_TypedTransition_T_StateAction_Il2CppReferenceArray_1_StateAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2<T>>.NativeClassPtr, 100668023);
			StateMachineActionV2<T>.NativeMethodInfoPtr_SequenceTransition_Protected_Transition_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2<T>>.NativeClassPtr, 100668024);
			StateMachineActionV2<T>.NativeMethodInfoPtr_FromInt_Protected_Virtual_New_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2<T>>.NativeClassPtr, 100668025);
			StateMachineActionV2<T>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2<T>>.NativeClassPtr, 100668026);
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x0600151E RID: 5406 RVA: 0x0006E8E8 File Offset: 0x0006CAE8
		public unsafe T TypedCurrentState
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590565, XrefRangeEnd = 590567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2<T>.NativeMethodInfoPtr_get_TypedCurrentState_Protected_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x0006E924 File Offset: 0x0006CB24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590567, XrefRangeEnd = 590575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StateMachineActionV2(Match m, T initialState)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateMachineActionV2<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = initialState;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref initialState;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2<T>.NativeMethodInfoPtr__ctor_Protected_Void_Match_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x0006E9B8 File Offset: 0x0006CBB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590575, XrefRangeEnd = 590576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StateMachineActionV2(Match m, SerializedStateMachineActionV2 serialized)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateMachineActionV2<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2<T>.NativeMethodInfoPtr__ctor_Protected_Void_Match_SerializedStateMachineActionV2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x0006EA18 File Offset: 0x0006CC18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590576, XrefRangeEnd = 590584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTypedBinding(T state, StateMachineActionV2<T>.TypedStateBehavior behavior)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = state;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref state;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(behavior);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2<T>.NativeMethodInfoPtr_AddTypedBinding_Protected_Void_T_TypedStateBehavior_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x0006EAA4 File Offset: 0x0006CCA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590584, XrefRangeEnd = 590590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTypedBinding(T state, StateMachineActionV2.StateAction action, StateMachineActionV2<T>.TypedTransition transition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = state;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref state;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transition);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2<T>.NativeMethodInfoPtr_AddTypedBinding_Protected_Void_T_StateAction_TypedTransition_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x0006EB40 File Offset: 0x0006CD40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590590, XrefRangeEnd = 590633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTypedBindingSequence(T state, StateMachineActionV2<T>.TypedTransition transition, StateMachineActionV2.StateAction initialAction, [Optional] Il2CppReferenceArray<StateMachineActionV2.StateAction> actions)
		{
			if (actions == null)
			{
				actions = new Il2CppReferenceArray<StateMachineActionV2.StateAction>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = state;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref state;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transition);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(initialAction);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actions);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2<T>.NativeMethodInfoPtr_AddTypedBindingSequence_Protected_Void_T_TypedTransition_T_StateAction_Il2CppReferenceArray_1_StateAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x0006EC00 File Offset: 0x0006CE00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590633, XrefRangeEnd = 590640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StateMachineActionV2.Transition SequenceTransition(int state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2<T>.NativeMethodInfoPtr_SequenceTransition_Protected_Transition_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StateMachineActionV2.Transition>(intPtr3) : null;
			}
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x0006EC4C File Offset: 0x0006CE4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590640, XrefRangeEnd = 590645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual T FromInt(int state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StateMachineActionV2<T>.NativeMethodInfoPtr_FromInt_Protected_Virtual_New_T_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x0006ECA0 File Offset: 0x0006CEA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590645, XrefRangeEnd = 590659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StateMachineActionV2<T>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x0000A37E File Offset: 0x0000857E
		public void AddTypedBindingSequence(T state, StateMachineActionV2<T>.TypedTransition transition, StateMachineActionV2.StateAction initialAction, params StateMachineActionV2.StateAction[] actions)
		{
			this.AddTypedBindingSequence(state, transition, initialAction, new Il2CppReferenceArray<StateMachineActionV2.StateAction>(actions));
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x0000A390 File Offset: 0x00008590
		public StateMachineActionV2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06001529 RID: 5417 RVA: 0x0006ECE4 File Offset: 0x0006CEE4
		// (set) Token: 0x0600152A RID: 5418 RVA: 0x0000A399 File Offset: 0x00008599
		public unsafe static IFormatProvider FormatProvider
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StateMachineActionV2<T>.NativeFieldInfoPtr_FormatProvider, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFormatProvider>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StateMachineActionV2<T>.NativeFieldInfoPtr_FormatProvider, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DA7 RID: 3495
		private static readonly IntPtr NativeFieldInfoPtr_FormatProvider;

		// Token: 0x04000DA8 RID: 3496
		private static readonly IntPtr NativeMethodInfoPtr_get_TypedCurrentState_Protected_get_T_0;

		// Token: 0x04000DA9 RID: 3497
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Match_T_0;

		// Token: 0x04000DAA RID: 3498
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Match_SerializedStateMachineActionV2_0;

		// Token: 0x04000DAB RID: 3499
		private static readonly IntPtr NativeMethodInfoPtr_AddTypedBinding_Protected_Void_T_TypedStateBehavior_T_0;

		// Token: 0x04000DAC RID: 3500
		private static readonly IntPtr NativeMethodInfoPtr_AddTypedBinding_Protected_Void_T_StateAction_TypedTransition_T_0;

		// Token: 0x04000DAD RID: 3501
		private static readonly IntPtr NativeMethodInfoPtr_AddTypedBindingSequence_Protected_Void_T_TypedTransition_T_StateAction_Il2CppReferenceArray_1_StateAction_0;

		// Token: 0x04000DAE RID: 3502
		private static readonly IntPtr NativeMethodInfoPtr_SequenceTransition_Protected_Transition_Int32_0;

		// Token: 0x04000DAF RID: 3503
		private static readonly IntPtr NativeMethodInfoPtr_FromInt_Protected_Virtual_New_T_Int32_0;

		// Token: 0x04000DB0 RID: 3504
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x02000435 RID: 1077
		public class TypedStateBehavior : StateMachineActionV2.StateBehavior
		{
			// Token: 0x06002F67 RID: 12135 RVA: 0x000C5E34 File Offset: 0x000C4034
			// Note: this type is marked as 'beforefieldinit'.
			static TypedStateBehavior()
			{
				Il2CppClassPointerStore<StateMachineActionV2<T>.TypedStateBehavior>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateMachineActionV2<T>>.NativeClassPtr, "TypedStateBehavior"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateMachineActionV2<T>.TypedStateBehavior>.NativeClassPtr);
				StateMachineActionV2<T>.TypedStateBehavior.NativeFieldInfoPtr_TypedTransition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineActionV2<T>.TypedStateBehavior>.NativeClassPtr, "TypedTransition");
				StateMachineActionV2<T>.TypedStateBehavior.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2<T>.TypedStateBehavior>.NativeClassPtr, 100668028);
				StateMachineActionV2<T>.TypedStateBehavior.NativeMethodInfoPtr___ctor_b__1_0_Private_Nullable_1_Int32_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2<T>.TypedStateBehavior>.NativeClassPtr, 100668029);
			}

			// Token: 0x06002F68 RID: 12136 RVA: 0x000C5ED8 File Offset: 0x000C40D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590500, XrefRangeEnd = 590506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TypedStateBehavior()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateMachineActionV2<T>.TypedStateBehavior>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2<T>.TypedStateBehavior.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F69 RID: 12137 RVA: 0x000C5F14 File Offset: 0x000C4114
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590506, XrefRangeEnd = 590533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Nullable<int> __ctor_b__1_0(Action lastAction)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(lastAction);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2<T>.TypedStateBehavior.NativeMethodInfoPtr___ctor_b__1_0_Private_Nullable_1_Int32_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new Nullable<int>(intPtr);
				}
			}

			// Token: 0x06002F6A RID: 12138 RVA: 0x00016A8D File Offset: 0x00014C8D
			public TypedStateBehavior(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C60 RID: 3168
			// (get) Token: 0x06002F6B RID: 12139 RVA: 0x000C5F5C File Offset: 0x000C415C
			// (set) Token: 0x06002F6C RID: 12140 RVA: 0x00016A96 File Offset: 0x00014C96
			public unsafe StateMachineActionV2<T>.TypedTransition TypedTransition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2<T>.TypedStateBehavior.NativeFieldInfoPtr_TypedTransition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StateMachineActionV2<T>.TypedTransition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2<T>.TypedStateBehavior.NativeFieldInfoPtr_TypedTransition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001DAE RID: 7598
			private static readonly IntPtr NativeFieldInfoPtr_TypedTransition;

			// Token: 0x04001DAF RID: 7599
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001DB0 RID: 7600
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__1_0_Private_Nullable_1_Int32_Action_0;
		}

		// Token: 0x02000436 RID: 1078
		public sealed class TypedTransition : MulticastDelegate
		{
			// Token: 0x06002F6D RID: 12141 RVA: 0x000C5F8C File Offset: 0x000C418C
			// Note: this type is marked as 'beforefieldinit'.
			static TypedTransition()
			{
				Il2CppClassPointerStore<StateMachineActionV2<T>.TypedTransition>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateMachineActionV2<T>>.NativeClassPtr, "TypedTransition"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				StateMachineActionV2<T>.TypedTransition.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2<T>.TypedTransition>.NativeClassPtr, 100668030);
				StateMachineActionV2<T>.TypedTransition.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Nullable_1_T_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2<T>.TypedTransition>.NativeClassPtr, 100668031);
				StateMachineActionV2<T>.TypedTransition.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Action_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2<T>.TypedTransition>.NativeClassPtr, 100668032);
				StateMachineActionV2<T>.TypedTransition.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Nullable_1_T_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2<T>.TypedTransition>.NativeClassPtr, 100668033);
			}

			// Token: 0x06002F6E RID: 12142 RVA: 0x000C6038 File Offset: 0x000C4238
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590533, XrefRangeEnd = 590542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TypedTransition(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateMachineActionV2<T>.TypedTransition>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2<T>.TypedTransition.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F6F RID: 12143 RVA: 0x000C6094 File Offset: 0x000C4294
			[CallerCount(0)]
			public unsafe Nullable<T> Invoke(Action lastAction)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(lastAction);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2<T>.TypedTransition.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Nullable_1_T_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new Nullable<T>(intPtr);
				}
			}

			// Token: 0x06002F70 RID: 12144 RVA: 0x000C60DC File Offset: 0x000C42DC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 479320, RefRangeEnd = 479322, XrefRangeStart = 479320, XrefRangeEnd = 479322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Action lastAction, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(lastAction);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2<T>.TypedTransition.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Action_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002F71 RID: 12145 RVA: 0x000C6150 File Offset: 0x000C4350
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590542, XrefRangeEnd = 590548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Nullable<T> EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2<T>.TypedTransition.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Nullable_1_T_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new Nullable<T>(intPtr);
				}
			}

			// Token: 0x06002F72 RID: 12146 RVA: 0x00016AB5 File Offset: 0x00014CB5
			public TypedTransition(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002F73 RID: 12147 RVA: 0x00016ABE File Offset: 0x00014CBE
			public static implicit operator StateMachineActionV2<T>.TypedTransition(Func<Action, Nullable<T>> A_0)
			{
				return DelegateSupport.ConvertDelegate<StateMachineActionV2<T>.TypedTransition>(A_0);
			}

			// Token: 0x06002F74 RID: 12148 RVA: 0x00016AC6 File Offset: 0x00014CC6
			public static StateMachineActionV2<T>.TypedTransition operator +(StateMachineActionV2<T>.TypedTransition A_0, StateMachineActionV2<T>.TypedTransition A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<StateMachineActionV2<T>.TypedTransition>();
			}

			// Token: 0x06002F75 RID: 12149 RVA: 0x00016AD4 File Offset: 0x00014CD4
			public static StateMachineActionV2<T>.TypedTransition operator -(StateMachineActionV2<T>.TypedTransition A_0, StateMachineActionV2<T>.TypedTransition A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<StateMachineActionV2<T>.TypedTransition>();
				}
				return delegate2;
			}

			// Token: 0x04001DB1 RID: 7601
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001DB2 RID: 7602
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Nullable_1_T_Action_0;

			// Token: 0x04001DB3 RID: 7603
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Action_AsyncCallback_Object_0;

			// Token: 0x04001DB4 RID: 7604
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Nullable_1_T_IAsyncResult_0;
		}

		// Token: 0x02000437 RID: 1079
		[ObfuscatedName("Canis.actions.StateMachineActionV2`1+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Object
		{
			// Token: 0x06002F76 RID: 12150 RVA: 0x000C6198 File Offset: 0x000C4398
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<StateMachineActionV2<T>.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateMachineActionV2<T>>.NativeClassPtr, "<>c__DisplayClass10_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateMachineActionV2<T>.__c__DisplayClass10_0>.NativeClassPtr);
				StateMachineActionV2<T>.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineActionV2<T>.__c__DisplayClass10_0>.NativeClassPtr, "<>4__this");
				StateMachineActionV2<T>.__c__DisplayClass10_0.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineActionV2<T>.__c__DisplayClass10_0>.NativeClassPtr, "state");
				StateMachineActionV2<T>.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2<T>.__c__DisplayClass10_0>.NativeClassPtr, 100668034);
				StateMachineActionV2<T>.__c__DisplayClass10_0.NativeMethodInfoPtr__SequenceTransition_b__0_Internal_Nullable_1_Int32_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineActionV2<T>.__c__DisplayClass10_0>.NativeClassPtr, 100668035);
			}

			// Token: 0x06002F77 RID: 12151 RVA: 0x000C6250 File Offset: 0x000C4450
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateMachineActionV2<T>.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2<T>.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F78 RID: 12152 RVA: 0x000C628C File Offset: 0x000C448C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590548, XrefRangeEnd = 590565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Nullable<int> _SequenceTransition_b__0(Action lastAction)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(lastAction);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineActionV2<T>.__c__DisplayClass10_0.NativeMethodInfoPtr__SequenceTransition_b__0_Internal_Nullable_1_Int32_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new Nullable<int>(intPtr);
				}
			}

			// Token: 0x06002F79 RID: 12153 RVA: 0x00016AE5 File Offset: 0x00014CE5
			public __c__DisplayClass10_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C61 RID: 3169
			// (get) Token: 0x06002F7A RID: 12154 RVA: 0x000C62D4 File Offset: 0x000C44D4
			// (set) Token: 0x06002F7B RID: 12155 RVA: 0x00016AEE File Offset: 0x00014CEE
			public unsafe StateMachineActionV2<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2<T>.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StateMachineActionV2<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2<T>.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C62 RID: 3170
			// (get) Token: 0x06002F7C RID: 12156 RVA: 0x000C6304 File Offset: 0x000C4504
			// (set) Token: 0x06002F7D RID: 12157 RVA: 0x00016B0D File Offset: 0x00014D0D
			public unsafe int state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2<T>.__c__DisplayClass10_0.NativeFieldInfoPtr_state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StateMachineActionV2<T>.__c__DisplayClass10_0.NativeFieldInfoPtr_state)) = value;
				}
			}

			// Token: 0x04001DB5 RID: 7605
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001DB6 RID: 7606
			private static readonly IntPtr NativeFieldInfoPtr_state;

			// Token: 0x04001DB7 RID: 7607
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001DB8 RID: 7608
			private static readonly IntPtr NativeMethodInfoPtr__SequenceTransition_b__0_Internal_Nullable_1_Int32_Action_0;
		}
	}
}
