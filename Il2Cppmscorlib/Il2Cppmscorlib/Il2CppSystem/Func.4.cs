using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem
{
	// Token: 0x02000066 RID: 102
	public sealed class Func<T1, T2, T3, TResult> : MulticastDelegate
	{
		// Token: 0x060005F5 RID: 1525 RVA: 0x0004028C File Offset: 0x0003E48C
		// Note: this type is marked as 'beforefieldinit'.
		static Func()
		{
			Il2CppClassPointerStore<Func<T1, T2, T3, TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Func`4"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
			})).TypeHandle.value);
			Func<T1, T2, T3, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Func<T1, T2, T3, TResult>>.NativeClassPtr, 100664303);
			Func<T1, T2, T3, TResult>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_T1_T2_T3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Func<T1, T2, T3, TResult>>.NativeClassPtr, 100664304);
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x0004034C File Offset: 0x0003E54C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1296795, RefRangeEnd = 1296796, XrefRangeStart = 1296786, XrefRangeEnd = 1296795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Func(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Func<T1, T2, T3, TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Func<T1, T2, T3, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x000403A8 File Offset: 0x0003E5A8
		[CallerCount(0)]
		public unsafe TResult Invoke(T1 arg1, T2 arg2, T3 arg3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
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
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(Func<T1, T2, T3, TResult>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_T1_T2_T3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			return IL2CPP.PointerToValueGeneric<TResult>(intPtr4, false, true);
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00003D2B File Offset: 0x00001F2B
		public Func(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00003D34 File Offset: 0x00001F34
		public static implicit operator Func<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> A_0)
		{
			return DelegateSupport.ConvertDelegate<Func<T1, T2, T3, TResult>>(A_0);
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00003D3C File Offset: 0x00001F3C
		public static Func<T1, T2, T3, TResult>operator +(Func<T1, T2, T3, TResult> A_0, Func<T1, T2, T3, TResult> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<Func<T1, T2, T3, TResult>>();
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00003D4A File Offset: 0x00001F4A
		public static Func<T1, T2, T3, TResult>operator -(Func<T1, T2, T3, TResult> A_0, Func<T1, T2, T3, TResult> A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<Func<T1, T2, T3, TResult>>();
			}
			return delegate2;
		}

		// Token: 0x04000473 RID: 1139
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000474 RID: 1140
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_T1_T2_T3_0;
	}
}
