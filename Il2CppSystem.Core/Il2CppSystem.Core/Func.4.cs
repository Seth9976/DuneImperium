using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem
{
	// Token: 0x0200000E RID: 14
	public sealed class Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> : MulticastDelegate
	{
		// Token: 0x06000035 RID: 53 RVA: 0x0000ED4C File Offset: 0x0000CF4C
		// Note: this type is marked as 'beforefieldinit'.
		static Func()
		{
			Il2CppClassPointerStore<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System", "Func`13"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T6>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T7>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T8>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T9>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T10>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T11>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T12>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
			})).TypeHandle.value);
			Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>>.NativeClassPtr, 100663324);
			Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_T11_T12_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>>.NativeClassPtr, 100663325);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000EEB4 File Offset: 0x0000D0B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002174, XrefRangeEnd = 1002183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Func(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000EF10 File Offset: 0x0000D110
		[CallerCount(0)]
		public unsafe TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T1).IsValueType)
				{
					T1 t = arg1;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref arg1;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T2).IsValueType)
			{
				T2 t2 = arg2;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg2;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T3).IsValueType)
			{
				T3 t3 = arg3;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref arg3;
			}
			ptr4 = intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4;
			if (!typeof(T4).IsValueType)
			{
				T4 t4 = arg4;
				intPtr4 = ((t4 is string) ? IL2CPP.ManagedStringToIl2Cpp(t4 as string) : IL2CPP.Il2CppObjectBaseToPtr(t4 as Il2CppObjectBase));
			}
			else
			{
				intPtr4 = ref arg4;
			}
			ptr5 = intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5;
			if (!typeof(T5).IsValueType)
			{
				T5 t5 = arg5;
				intPtr5 = ((t5 is string) ? IL2CPP.ManagedStringToIl2Cpp(t5 as string) : IL2CPP.Il2CppObjectBaseToPtr(t5 as Il2CppObjectBase));
			}
			else
			{
				intPtr5 = ref arg5;
			}
			ptr6 = intPtr5;
			ref IntPtr ptr7 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr6;
			if (!typeof(T6).IsValueType)
			{
				T6 t6 = arg6;
				intPtr6 = ((t6 is string) ? IL2CPP.ManagedStringToIl2Cpp(t6 as string) : IL2CPP.Il2CppObjectBaseToPtr(t6 as Il2CppObjectBase));
			}
			else
			{
				intPtr6 = ref arg6;
			}
			ptr7 = intPtr6;
			ref IntPtr ptr8 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr7;
			if (!typeof(T7).IsValueType)
			{
				T7 t7 = arg7;
				intPtr7 = ((t7 is string) ? IL2CPP.ManagedStringToIl2Cpp(t7 as string) : IL2CPP.Il2CppObjectBaseToPtr(t7 as Il2CppObjectBase));
			}
			else
			{
				intPtr7 = ref arg7;
			}
			ptr8 = intPtr7;
			ref IntPtr ptr9 = ref ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr8;
			if (!typeof(T8).IsValueType)
			{
				T8 t8 = arg8;
				intPtr8 = ((t8 is string) ? IL2CPP.ManagedStringToIl2Cpp(t8 as string) : IL2CPP.Il2CppObjectBaseToPtr(t8 as Il2CppObjectBase));
			}
			else
			{
				intPtr8 = ref arg8;
			}
			ptr9 = intPtr8;
			ref IntPtr ptr10 = ref ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr9;
			if (!typeof(T9).IsValueType)
			{
				T9 t9 = arg9;
				intPtr9 = ((t9 is string) ? IL2CPP.ManagedStringToIl2Cpp(t9 as string) : IL2CPP.Il2CppObjectBaseToPtr(t9 as Il2CppObjectBase));
			}
			else
			{
				intPtr9 = ref arg9;
			}
			ptr10 = intPtr9;
			ref IntPtr ptr11 = ref ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr10;
			if (!typeof(T10).IsValueType)
			{
				T10 t10 = arg10;
				intPtr10 = ((t10 is string) ? IL2CPP.ManagedStringToIl2Cpp(t10 as string) : IL2CPP.Il2CppObjectBaseToPtr(t10 as Il2CppObjectBase));
			}
			else
			{
				intPtr10 = ref arg10;
			}
			ptr11 = intPtr10;
			ref IntPtr ptr12 = ref ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr11;
			if (!typeof(T11).IsValueType)
			{
				T11 t11 = arg11;
				intPtr11 = ((t11 is string) ? IL2CPP.ManagedStringToIl2Cpp(t11 as string) : IL2CPP.Il2CppObjectBaseToPtr(t11 as Il2CppObjectBase));
			}
			else
			{
				intPtr11 = ref arg11;
			}
			ptr12 = intPtr11;
			ref IntPtr ptr13 = ref ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr12;
			if (!typeof(T12).IsValueType)
			{
				T12 t12 = arg12;
				intPtr12 = ((t12 is string) ? IL2CPP.ManagedStringToIl2Cpp(t12 as string) : IL2CPP.Il2CppObjectBaseToPtr(t12 as Il2CppObjectBase));
			}
			else
			{
				intPtr12 = ref arg12;
			}
			ptr13 = intPtr12;
			IntPtr intPtr14;
			IntPtr intPtr13 = IL2CPP.il2cpp_runtime_invoke(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_T11_T12_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr14);
			Il2CppException.RaiseExceptionIfNecessary(intPtr14);
			return IL2CPP.PointerToValueGeneric<TResult>(intPtr13, false, true);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000020CA File Offset: 0x000002CA
		public Func(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_T11_T12_0;
	}
}
