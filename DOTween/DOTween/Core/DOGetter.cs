using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace DG.Tweening.Core
{
	// Token: 0x02000047 RID: 71
	public sealed class DOGetter<T> : MulticastDelegate
	{
		// Token: 0x06000432 RID: 1074 RVA: 0x000197C4 File Offset: 0x000179C4
		// Note: this type is marked as 'beforefieldinit'.
		static DOGetter()
		{
			Il2CppClassPointerStore<DOGetter<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Core", "DOGetter`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			DOGetter<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOGetter<T>>.NativeClassPtr, 100664152);
			DOGetter<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOGetter<T>>.NativeClassPtr, 100664153);
			DOGetter<T>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOGetter<T>>.NativeClassPtr, 100664154);
			DOGetter<T>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_T_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOGetter<T>>.NativeClassPtr, 100664155);
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00019878 File Offset: 0x00017A78
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 426953, RefRangeEnd = 426980, XrefRangeStart = 426953, XrefRangeEnd = 426980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DOGetter(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOGetter<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOGetter<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x000198D4 File Offset: 0x00017AD4
		[CallerCount(0)]
		public unsafe T Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOGetter<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00019910 File Offset: 0x00017B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOGetter<T>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00019974 File Offset: 0x00017B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1133106, XrefRangeEnd = 1133108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOGetter<T>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_T_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00003568 File Offset: 0x00001768
		public DOGetter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00003571 File Offset: 0x00001771
		public static implicit operator DOGetter<T>(Func<T> A_0)
		{
			return DelegateSupport.ConvertDelegate<DOGetter<T>>(A_0);
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00003579 File Offset: 0x00001779
		public static DOGetter<T>operator +(DOGetter<T> A_0, DOGetter<T> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<DOGetter<T>>();
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00003587 File Offset: 0x00001787
		public static DOGetter<T>operator -(DOGetter<T> A_0, DOGetter<T> A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<DOGetter<T>>();
			}
			return delegate2;
		}

		// Token: 0x04000374 RID: 884
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000375 RID: 885
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_T_0;

		// Token: 0x04000376 RID: 886
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

		// Token: 0x04000377 RID: 887
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_T_IAsyncResult_0;
	}
}
