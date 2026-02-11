using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem
{
	// Token: 0x0200005C RID: 92
	public sealed class Action<T1, T2> : MulticastDelegate
	{
		// Token: 0x060005AF RID: 1455 RVA: 0x0003EA94 File Offset: 0x0003CC94
		// Note: this type is marked as 'beforefieldinit'.
		static Action()
		{
			Il2CppClassPointerStore<Action<T1, T2>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Action`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
			})).TypeHandle.value);
			Action<T1, T2>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Action<T1, T2>>.NativeClassPtr, 100664283);
			Action<T1, T2>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Action<T1, T2>>.NativeClassPtr, 100664284);
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x0003EB30 File Offset: 0x0003CD30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1296739, XrefRangeEnd = 1296742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Action(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Action<T1, T2>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Action<T1, T2>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x0003EB8C File Offset: 0x0003CD8C
		[CallerCount(0)]
		public unsafe void Invoke(T1 arg1, T2 arg2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
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
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Action<T1, T2>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T1_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00003B4B File Offset: 0x00001D4B
		public Action(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00003B54 File Offset: 0x00001D54
		public static implicit operator Action<T1, T2>(Action<T1, T2> A_0)
		{
			return DelegateSupport.ConvertDelegate<Action<T1, T2>>(A_0);
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00003B5C File Offset: 0x00001D5C
		public static Action<T1, T2>operator +(Action<T1, T2> A_0, Action<T1, T2> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<Action<T1, T2>>();
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00003B6A File Offset: 0x00001D6A
		public static Action<T1, T2>operator -(Action<T1, T2> A_0, Action<T1, T2> A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<Action<T1, T2>>();
			}
			return delegate2;
		}

		// Token: 0x0400045F RID: 1119
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000460 RID: 1120
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T1_T2_0;
	}
}
