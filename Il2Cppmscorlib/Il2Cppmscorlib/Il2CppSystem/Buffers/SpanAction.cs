using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Buffers
{
	// Token: 0x02000510 RID: 1296
	public sealed class SpanAction<T, TArg> : MulticastDelegate
	{
		// Token: 0x06004F6D RID: 20333 RVA: 0x00171E14 File Offset: 0x00170014
		// Note: this type is marked as 'beforefieldinit'.
		static SpanAction()
		{
			Il2CppClassPointerStore<SpanAction<T, TArg>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Buffers", "SpanAction`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArg>.NativeClassPtr))
			})).TypeHandle.value);
			SpanAction<T, TArg>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpanAction<T, TArg>>.NativeClassPtr, 100675281);
			SpanAction<T, TArg>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Span_1_T_TArg_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpanAction<T, TArg>>.NativeClassPtr, 100675282);
		}

		// Token: 0x06004F6E RID: 20334 RVA: 0x00171EB0 File Offset: 0x001700B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1426494, RefRangeEnd = 1426495, XrefRangeStart = 1426491, XrefRangeEnd = 1426494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpanAction(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpanAction<T, TArg>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpanAction<T, TArg>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F6F RID: 20335 RVA: 0x00171F0C File Offset: 0x0017010C
		[CallerCount(0)]
		public unsafe void Invoke(Span<T> span, TArg arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(span));
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TArg).IsValueType)
			{
				TArg targ = arg;
				intPtr = ((targ is string) ? IL2CPP.ManagedStringToIl2Cpp(targ as string) : IL2CPP.Il2CppObjectBaseToPtr(targ as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref arg;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SpanAction<T, TArg>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Span_1_T_TArg_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06004F70 RID: 20336 RVA: 0x0001C80B File Offset: 0x0001AA0B
		public SpanAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06004F71 RID: 20337 RVA: 0x0001C814 File Offset: 0x0001AA14
		public static implicit operator SpanAction<T, TArg>(Action<Span<T>, TArg> A_0)
		{
			return DelegateSupport.ConvertDelegate<SpanAction<T, TArg>>(A_0);
		}

		// Token: 0x06004F72 RID: 20338 RVA: 0x0001C81C File Offset: 0x0001AA1C
		public static SpanAction<T, TArg>operator +(SpanAction<T, TArg> A_0, SpanAction<T, TArg> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<SpanAction<T, TArg>>();
		}

		// Token: 0x06004F73 RID: 20339 RVA: 0x0001C82A File Offset: 0x0001AA2A
		public static SpanAction<T, TArg>operator -(SpanAction<T, TArg> A_0, SpanAction<T, TArg> A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<SpanAction<T, TArg>>();
			}
			return delegate2;
		}

		// Token: 0x040040C9 RID: 16585
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040040CA RID: 16586
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Span_1_T_TArg_0;
	}
}
