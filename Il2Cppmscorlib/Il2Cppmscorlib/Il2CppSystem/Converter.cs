using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem
{
	// Token: 0x0200006D RID: 109
	public sealed class Converter<TInput, TOutput> : MulticastDelegate
	{
		// Token: 0x06000626 RID: 1574 RVA: 0x000416AC File Offset: 0x0003F8AC
		// Note: this type is marked as 'beforefieldinit'.
		static Converter()
		{
			Il2CppClassPointerStore<Converter<TInput, TOutput>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Converter`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TInput>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOutput>.NativeClassPtr))
			})).TypeHandle.value);
			Converter<TInput, TOutput>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter<TInput, TOutput>>.NativeClassPtr, 100664317);
			Converter<TInput, TOutput>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TOutput_TInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter<TInput, TOutput>>.NativeClassPtr, 100664318);
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00041748 File Offset: 0x0003F948
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 742264, RefRangeEnd = 742289, XrefRangeStart = 742264, XrefRangeEnd = 742289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Converter(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Converter<TInput, TOutput>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter<TInput, TOutput>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x000417A4 File Offset: 0x0003F9A4
		[CallerCount(0)]
		public unsafe TOutput Invoke(TInput input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TInput).IsValueType)
				{
					TInput tinput = input;
					intPtr = ((tinput is string) ? IL2CPP.ManagedStringToIl2Cpp(tinput as string) : IL2CPP.Il2CppObjectBaseToPtr(tinput as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref input;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Converter<TInput, TOutput>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TOutput_TInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<TOutput>(intPtr2, false, true);
			}
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00003E7B File Offset: 0x0000207B
		public Converter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00003E84 File Offset: 0x00002084
		public static implicit operator Converter<TInput, TOutput>(Func<TInput, TOutput> A_0)
		{
			return DelegateSupport.ConvertDelegate<Converter<TInput, TOutput>>(A_0);
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00003E8C File Offset: 0x0000208C
		public static Converter<TInput, TOutput>operator +(Converter<TInput, TOutput> A_0, Converter<TInput, TOutput> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<Converter<TInput, TOutput>>();
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00003E9A File Offset: 0x0000209A
		public static Converter<TInput, TOutput>operator -(Converter<TInput, TOutput> A_0, Converter<TInput, TOutput> A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<Converter<TInput, TOutput>>();
			}
			return delegate2;
		}

		// Token: 0x04000481 RID: 1153
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000482 RID: 1154
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_TOutput_TInput_0;
	}
}
