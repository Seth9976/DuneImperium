using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem
{
	// Token: 0x0200006C RID: 108
	public sealed class Comparison<T> : MulticastDelegate
	{
		// Token: 0x0600061F RID: 1567 RVA: 0x000414F8 File Offset: 0x0003F6F8
		// Note: this type is marked as 'beforefieldinit'.
		static Comparison()
		{
			Il2CppClassPointerStore<Comparison<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Comparison`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			Comparison<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Comparison<T>>.NativeClassPtr, 100664315);
			Comparison<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Comparison<T>>.NativeClassPtr, 100664316);
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00041584 File Offset: 0x0003F784
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1296846, RefRangeEnd = 1296854, XrefRangeStart = 1296843, XrefRangeEnd = 1296846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Comparison(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Comparison<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Comparison<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x000415E0 File Offset: 0x0003F7E0
		[CallerCount(0)]
		public unsafe int Invoke(T x, T y)
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
					T t = x;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref x;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				T t2 = y;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref y;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Comparison<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00003E4B File Offset: 0x0000204B
		public Comparison(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00003E54 File Offset: 0x00002054
		public static implicit operator Comparison<T>(Func<T, T, int> A_0)
		{
			return DelegateSupport.ConvertDelegate<Comparison<T>>(A_0);
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00003E5C File Offset: 0x0000205C
		public static Comparison<T>operator +(Comparison<T> A_0, Comparison<T> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<Comparison<T>>();
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00003E6A File Offset: 0x0000206A
		public static Comparison<T>operator -(Comparison<T> A_0, Comparison<T> A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<Comparison<T>>();
			}
			return delegate2;
		}

		// Token: 0x0400047F RID: 1151
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000480 RID: 1152
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_T_T_0;
	}
}
