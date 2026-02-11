using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.actions
{
	// Token: 0x020001EF RID: 495
	public class StateMachineAction<T> : StateMachineAction where T : new()
	{
		// Token: 0x060014EC RID: 5356 RVA: 0x0006D9D4 File Offset: 0x0006BBD4
		// Note: this type is marked as 'beforefieldinit'.
		static StateMachineAction()
		{
			Il2CppClassPointerStore<StateMachineAction<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "StateMachineAction`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateMachineAction<T>>.NativeClassPtr);
			StateMachineAction<T>.NativeFieldInfoPtr_FormatProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateMachineAction<T>>.NativeClassPtr, "FormatProvider");
			StateMachineAction<T>.NativeMethodInfoPtr_ToInt_Private_Static_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction<T>>.NativeClassPtr, 100667953);
			StateMachineAction<T>.NativeMethodInfoPtr_get_TypedCurrentState_Protected_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction<T>>.NativeClassPtr, 100667954);
			StateMachineAction<T>.NativeMethodInfoPtr_set_TypedCurrentState_Protected_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction<T>>.NativeClassPtr, 100667955);
			StateMachineAction<T>.NativeMethodInfoPtr__ctor_Protected_Void_Match_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction<T>>.NativeClassPtr, 100667956);
			StateMachineAction<T>.NativeMethodInfoPtr__ctor_Protected_Void_Match_SerializedStateMachineAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction<T>>.NativeClassPtr, 100667957);
			StateMachineAction<T>.NativeMethodInfoPtr_DetermineNextState_Protected_Virtual_Final_Nullable_1_Int32_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction<T>>.NativeClassPtr, 100667958);
			StateMachineAction<T>.NativeMethodInfoPtr_DetermineNextTypedState_Protected_Abstract_Virtual_New_Nullable_1_T_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction<T>>.NativeClassPtr, 100667959);
			StateMachineAction<T>.NativeMethodInfoPtr_FromInt_Protected_Virtual_New_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction<T>>.NativeClassPtr, 100667960);
			StateMachineAction<T>.NativeMethodInfoPtr_BehaviorFor_Protected_Virtual_Final_StateBehavior_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction<T>>.NativeClassPtr, 100667961);
			StateMachineAction<T>.NativeMethodInfoPtr_TypedBehaviorFor_Protected_Abstract_Virtual_New_StateBehavior_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction<T>>.NativeClassPtr, 100667962);
			StateMachineAction<T>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateMachineAction<T>>.NativeClassPtr, 100667963);
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x0006DB30 File Offset: 0x0006BD30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590184, XrefRangeEnd = 590192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt(T value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StateMachineAction<T>.NativeMethodInfoPtr_ToInt_Private_Static_Int32_T_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x060014EE RID: 5358 RVA: 0x0006DBA8 File Offset: 0x0006BDA8
		// (set) Token: 0x060014EF RID: 5359 RVA: 0x0006DBE4 File Offset: 0x0006BDE4
		public unsafe T TypedCurrentState
		{
			[CallerCount(80)]
			[CachedScanResults(RefRangeStart = 590193, RefRangeEnd = 590273, XrefRangeStart = 590192, XrefRangeEnd = 590193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAction<T>.NativeMethodInfoPtr_get_TypedCurrentState_Protected_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590273, XrefRangeEnd = 590281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = value;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StateMachineAction<T>.NativeMethodInfoPtr_set_TypedCurrentState_Protected_set_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x0006DC5C File Offset: 0x0006BE5C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 590290, RefRangeEnd = 590304, XrefRangeStart = 590281, XrefRangeEnd = 590290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StateMachineAction(Match m, T initialState)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateMachineAction<T>>.NativeClassPtr))
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StateMachineAction<T>.NativeMethodInfoPtr__ctor_Protected_Void_Match_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x0006DCF0 File Offset: 0x0006BEF0
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 590305, RefRangeEnd = 590323, XrefRangeStart = 590304, XrefRangeEnd = 590305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StateMachineAction(Match m, SerializedStateMachineAction serialized)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateMachineAction<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAction<T>.NativeMethodInfoPtr__ctor_Protected_Void_Match_SerializedStateMachineAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x0006DD50 File Offset: 0x0006BF50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590323, XrefRangeEnd = 590324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Nullable<int> DetermineNextState(Action lastAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lastAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAction<T>.NativeMethodInfoPtr_DetermineNextState_Protected_Virtual_Final_Nullable_1_Int32_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x0006DD98 File Offset: 0x0006BF98
		[CallerCount(0)]
		public unsafe virtual Nullable<T> DetermineNextTypedState(Action lastAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lastAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StateMachineAction<T>.NativeMethodInfoPtr_DetermineNextTypedState_Protected_Abstract_Virtual_New_Nullable_1_T_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<T>(intPtr);
			}
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x0006DDEC File Offset: 0x0006BFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590324, XrefRangeEnd = 590333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual T FromInt(int state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StateMachineAction<T>.NativeMethodInfoPtr_FromInt_Protected_Virtual_New_T_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x0006DE40 File Offset: 0x0006C040
		[CallerCount(0)]
		public unsafe override StateMachineAction.StateBehavior BehaviorFor(int state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StateMachineAction<T>.NativeMethodInfoPtr_BehaviorFor_Protected_Virtual_Final_StateBehavior_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StateMachineAction.StateBehavior>(intPtr3) : null;
			}
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x0006DE8C File Offset: 0x0006C08C
		[CallerCount(0)]
		public unsafe virtual StateMachineAction.StateBehavior TypedBehaviorFor(T state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
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
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StateMachineAction<T>.NativeMethodInfoPtr_TypedBehaviorFor_Protected_Abstract_Virtual_New_StateBehavior_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<StateMachineAction.StateBehavior>(intPtr4) : null;
			}
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x0006DF20 File Offset: 0x0006C120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 590333, XrefRangeEnd = 590341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StateMachineAction<T>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x0000A288 File Offset: 0x00008488
		public StateMachineAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x060014F9 RID: 5369 RVA: 0x0006DF64 File Offset: 0x0006C164
		// (set) Token: 0x060014FA RID: 5370 RVA: 0x0000A291 File Offset: 0x00008491
		public unsafe static IFormatProvider FormatProvider
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StateMachineAction<T>.NativeFieldInfoPtr_FormatProvider, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFormatProvider>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StateMachineAction<T>.NativeFieldInfoPtr_FormatProvider, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D84 RID: 3460
		private static readonly IntPtr NativeFieldInfoPtr_FormatProvider;

		// Token: 0x04000D85 RID: 3461
		private static readonly IntPtr NativeMethodInfoPtr_ToInt_Private_Static_Int32_T_0;

		// Token: 0x04000D86 RID: 3462
		private static readonly IntPtr NativeMethodInfoPtr_get_TypedCurrentState_Protected_get_T_0;

		// Token: 0x04000D87 RID: 3463
		private static readonly IntPtr NativeMethodInfoPtr_set_TypedCurrentState_Protected_set_Void_T_0;

		// Token: 0x04000D88 RID: 3464
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Match_T_0;

		// Token: 0x04000D89 RID: 3465
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Match_SerializedStateMachineAction_0;

		// Token: 0x04000D8A RID: 3466
		private static readonly IntPtr NativeMethodInfoPtr_DetermineNextState_Protected_Virtual_Final_Nullable_1_Int32_Action_0;

		// Token: 0x04000D8B RID: 3467
		private static readonly IntPtr NativeMethodInfoPtr_DetermineNextTypedState_Protected_Abstract_Virtual_New_Nullable_1_T_Action_0;

		// Token: 0x04000D8C RID: 3468
		private static readonly IntPtr NativeMethodInfoPtr_FromInt_Protected_Virtual_New_T_Int32_0;

		// Token: 0x04000D8D RID: 3469
		private static readonly IntPtr NativeMethodInfoPtr_BehaviorFor_Protected_Virtual_Final_StateBehavior_Int32_0;

		// Token: 0x04000D8E RID: 3470
		private static readonly IntPtr NativeMethodInfoPtr_TypedBehaviorFor_Protected_Abstract_Virtual_New_StateBehavior_T_0;

		// Token: 0x04000D8F RID: 3471
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
