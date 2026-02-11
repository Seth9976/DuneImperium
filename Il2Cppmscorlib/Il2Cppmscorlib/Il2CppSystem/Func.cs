using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem
{
	// Token: 0x02000063 RID: 99
	public sealed class Func<TResult> : MulticastDelegate
	{
		// Token: 0x060005E0 RID: 1504 RVA: 0x0003FE1C File Offset: 0x0003E01C
		// Note: this type is marked as 'beforefieldinit'.
		static Func()
		{
			Il2CppClassPointerStore<Func<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Func`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
			Func<TResult>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Func<TResult>>.NativeClassPtr, 100664297);
			Func<TResult>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Func<TResult>>.NativeClassPtr, 100664298);
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x0003FEA8 File Offset: 0x0003E0A8
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 426953, RefRangeEnd = 426980, XrefRangeStart = 426953, XrefRangeEnd = 426980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Func(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Func<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Func<TResult>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x0003FF04 File Offset: 0x0003E104
		[CallerCount(0)]
		public unsafe TResult Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Func<TResult>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00003C9B File Offset: 0x00001E9B
		public Func(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00003CA4 File Offset: 0x00001EA4
		public static implicit operator Func<TResult>(Func<TResult> A_0)
		{
			return DelegateSupport.ConvertDelegate<Func<TResult>>(A_0);
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00003CAC File Offset: 0x00001EAC
		public static Func<TResult>operator +(Func<TResult> A_0, Func<TResult> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<Func<TResult>>();
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00003CBA File Offset: 0x00001EBA
		public static Func<TResult>operator -(Func<TResult> A_0, Func<TResult> A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<Func<TResult>>();
			}
			return delegate2;
		}

		// Token: 0x0400046D RID: 1133
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400046E RID: 1134
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_0;
	}
}
