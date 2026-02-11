using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000061 RID: 97
	public sealed class MethodCall<T, TResult> : MulticastDelegate
	{
		// Token: 0x060008AA RID: 2218 RVA: 0x0003A598 File Offset: 0x00038798
		// Note: this type is marked as 'beforefieldinit'.
		static MethodCall()
		{
			Il2CppClassPointerStore<MethodCall<T, TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Utilities", "MethodCall`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
			})).TypeHandle.value);
			MethodCall<T, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall<T, TResult>>.NativeClassPtr, 100664959);
			MethodCall<T, TResult>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_T_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall<T, TResult>>.NativeClassPtr, 100664960);
			MethodCall<T, TResult>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_Il2CppReferenceArray_1_Object_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall<T, TResult>>.NativeClassPtr, 100664961);
			MethodCall<T, TResult>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_TResult_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall<T, TResult>>.NativeClassPtr, 100664962);
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x0003A65C File Offset: 0x0003885C
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 744653, RefRangeEnd = 744684, XrefRangeStart = 744644, XrefRangeEnd = 744653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodCall(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethodCall<T, TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall<T, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x0003A6B8 File Offset: 0x000388B8
		[CallerCount(0)]
		public unsafe TResult Invoke(T target, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = target;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref target;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodCall<T, TResult>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_T_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<TResult>(intPtr2, false, true);
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x0003A758 File Offset: 0x00038958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(T target, Il2CppReferenceArray<Object> args, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = target;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref target;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodCall<T, TResult>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_Il2CppReferenceArray_1_Object_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr4) : null;
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x0003A818 File Offset: 0x00038A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TResult EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall<T, TResult>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_TResult_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
			}
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00004BC0 File Offset: 0x00002DC0
		public MethodCall(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x00004BC9 File Offset: 0x00002DC9
		public static implicit operator MethodCall<T, TResult>(Func<T, Il2CppReferenceArray<Object>, TResult> A_0)
		{
			return DelegateSupport.ConvertDelegate<MethodCall<T, TResult>>(A_0);
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x00004BD1 File Offset: 0x00002DD1
		public static MethodCall<T, TResult>operator +(MethodCall<T, TResult> A_0, MethodCall<T, TResult> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<MethodCall<T, TResult>>();
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x00004BDF File Offset: 0x00002DDF
		public static MethodCall<T, TResult>operator -(MethodCall<T, TResult> A_0, MethodCall<T, TResult> A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<MethodCall<T, TResult>>();
			}
			return delegate2;
		}

		// Token: 0x0400075A RID: 1882
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400075B RID: 1883
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_TResult_T_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400075C RID: 1884
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_Il2CppReferenceArray_1_Object_AsyncCallback_Object_0;

		// Token: 0x0400075D RID: 1885
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_TResult_IAsyncResult_0;
	}
}
