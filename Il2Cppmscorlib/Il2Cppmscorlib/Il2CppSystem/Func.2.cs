using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem
{
	// Token: 0x02000064 RID: 100
	public sealed class Func<T, TResult> : MulticastDelegate
	{
		// Token: 0x060005E7 RID: 1511 RVA: 0x0003FF40 File Offset: 0x0003E140
		// Note: this type is marked as 'beforefieldinit'.
		static Func()
		{
			Il2CppClassPointerStore<Func<T, TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Func`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
			})).TypeHandle.value);
			Func<T, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Func<T, TResult>>.NativeClassPtr, 100664299);
			Func<T, TResult>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Func<T, TResult>>.NativeClassPtr, 100664300);
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x0003FFDC File Offset: 0x0003E1DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1296781, RefRangeEnd = 1296782, XrefRangeStart = 1296778, XrefRangeEnd = 1296781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Func(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Func<T, TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Func<T, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00040038 File Offset: 0x0003E238
		[CallerCount(0)]
		public unsafe TResult Invoke(T arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = arg;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref arg;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Func<T, TResult>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<TResult>(intPtr2, false, true);
			}
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00003CCB File Offset: 0x00001ECB
		public Func(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00003CD4 File Offset: 0x00001ED4
		public static implicit operator Func<T, TResult>(Func<T, TResult> A_0)
		{
			return DelegateSupport.ConvertDelegate<Func<T, TResult>>(A_0);
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00003CDC File Offset: 0x00001EDC
		public static Func<T, TResult>operator +(Func<T, TResult> A_0, Func<T, TResult> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<Func<T, TResult>>();
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00003CEA File Offset: 0x00001EEA
		public static Func<T, TResult>operator -(Func<T, TResult> A_0, Func<T, TResult> A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<Func<T, TResult>>();
			}
			return delegate2;
		}

		// Token: 0x0400046F RID: 1135
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000470 RID: 1136
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_T_0;
	}
}
