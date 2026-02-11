using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200009A RID: 154
	public sealed class ObjectConstructor<T> : MulticastDelegate
	{
		// Token: 0x06000D61 RID: 3425 RVA: 0x0004FB48 File Offset: 0x0004DD48
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectConstructor()
		{
			Il2CppClassPointerStore<ObjectConstructor<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "ObjectConstructor`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			ObjectConstructor<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectConstructor<T>>.NativeClassPtr, 100665737);
			ObjectConstructor<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectConstructor<T>>.NativeClassPtr, 100665738);
			ObjectConstructor<T>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Il2CppReferenceArray_1_Object_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectConstructor<T>>.NativeClassPtr, 100665739);
			ObjectConstructor<T>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Object_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectConstructor<T>>.NativeClassPtr, 100665740);
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x0004FBFC File Offset: 0x0004DDFC
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 742264, RefRangeEnd = 742289, XrefRangeStart = 742264, XrefRangeEnd = 742289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectConstructor(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectConstructor<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectConstructor<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x0004FC58 File Offset: 0x0004DE58
		[CallerCount(0)]
		public unsafe Object Invoke([Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectConstructor<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Object_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x0004FCB8 File Offset: 0x0004DEB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 479320, RefRangeEnd = 479322, XrefRangeStart = 479320, XrefRangeEnd = 479322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(Il2CppReferenceArray<Object> args, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectConstructor<T>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Il2CppReferenceArray_1_Object_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x0004FD2C File Offset: 0x0004DF2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectConstructor<T>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Object_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x00006582 File Offset: 0x00004782
		public ObjectConstructor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x0000658B File Offset: 0x0000478B
		public static implicit operator ObjectConstructor<T>(Func<Il2CppReferenceArray<Object>, Object> A_0)
		{
			return DelegateSupport.ConvertDelegate<ObjectConstructor<T>>(A_0);
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x00006593 File Offset: 0x00004793
		public static ObjectConstructor<T>operator +(ObjectConstructor<T> A_0, ObjectConstructor<T> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<ObjectConstructor<T>>();
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x000065A1 File Offset: 0x000047A1
		public static ObjectConstructor<T>operator -(ObjectConstructor<T> A_0, ObjectConstructor<T> A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<ObjectConstructor<T>>();
			}
			return delegate2;
		}

		// Token: 0x04000AD6 RID: 2774
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000AD7 RID: 2775
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Object_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000AD8 RID: 2776
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Il2CppReferenceArray_1_Object_AsyncCallback_Object_0;

		// Token: 0x04000AD9 RID: 2777
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Object_IAsyncResult_0;
	}
}
