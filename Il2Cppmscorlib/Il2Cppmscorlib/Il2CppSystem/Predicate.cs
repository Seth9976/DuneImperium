using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem
{
	// Token: 0x0200006E RID: 110
	public sealed class Predicate<T> : MulticastDelegate
	{
		// Token: 0x0600062D RID: 1581 RVA: 0x00041824 File Offset: 0x0003FA24
		// Note: this type is marked as 'beforefieldinit'.
		static Predicate()
		{
			Il2CppClassPointerStore<Predicate<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Predicate`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			Predicate<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Predicate<T>>.NativeClassPtr, 100664319);
			Predicate<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Predicate<T>>.NativeClassPtr, 100664320);
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x000418B0 File Offset: 0x0003FAB0
		[CallerCount(64)]
		[CachedScanResults(RefRangeStart = 1296857, RefRangeEnd = 1296921, XrefRangeStart = 1296854, XrefRangeEnd = 1296857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Predicate(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Predicate<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Predicate<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x0004190C File Offset: 0x0003FB0C
		[CallerCount(0)]
		public unsafe bool Invoke(T obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = obj;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref obj;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Predicate<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x00003EAB File Offset: 0x000020AB
		public Predicate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00003EB4 File Offset: 0x000020B4
		public static implicit operator Predicate<T>(Func<T, bool> A_0)
		{
			return DelegateSupport.ConvertDelegate<Predicate<T>>(A_0);
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00003EBC File Offset: 0x000020BC
		public static Predicate<T>operator +(Predicate<T> A_0, Predicate<T> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<Predicate<T>>();
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00003ECA File Offset: 0x000020CA
		public static Predicate<T>operator -(Predicate<T> A_0, Predicate<T> A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<Predicate<T>>();
			}
			return delegate2;
		}

		// Token: 0x04000483 RID: 1155
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000484 RID: 1156
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_T_0;
	}
}
