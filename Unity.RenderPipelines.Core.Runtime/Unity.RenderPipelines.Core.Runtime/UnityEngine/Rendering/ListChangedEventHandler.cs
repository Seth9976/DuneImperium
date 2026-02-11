using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000053 RID: 83
	public sealed class ListChangedEventHandler<T> : MulticastDelegate
	{
		// Token: 0x060005E5 RID: 1509 RVA: 0x00023808 File Offset: 0x00021A08
		// Note: this type is marked as 'beforefieldinit'.
		static ListChangedEventHandler()
		{
			Il2CppClassPointerStore<ListChangedEventHandler<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ListChangedEventHandler`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			ListChangedEventHandler<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListChangedEventHandler<T>>.NativeClassPtr, 100664056);
			ListChangedEventHandler<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ObservableList_1_T_ListChangedEventArgs_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListChangedEventHandler<T>>.NativeClassPtr, 100664057);
			ListChangedEventHandler<T>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ObservableList_1_T_ListChangedEventArgs_1_T_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListChangedEventHandler<T>>.NativeClassPtr, 100664058);
			ListChangedEventHandler<T>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListChangedEventHandler<T>>.NativeClassPtr, 100664059);
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x000238BC File Offset: 0x00021ABC
		[CallerCount(83)]
		[CachedScanResults(RefRangeStart = 367534, RefRangeEnd = 367617, XrefRangeStart = 367534, XrefRangeEnd = 367617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListChangedEventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListChangedEventHandler<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListChangedEventHandler<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00023918 File Offset: 0x00021B18
		[CallerCount(0)]
		public unsafe void Invoke(ObservableList<T> sender, ListChangedEventArgs<T> e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListChangedEventHandler<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ObservableList_1_T_ListChangedEventArgs_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x0002396C File Offset: 0x00021B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(ObservableList<T> sender, ListChangedEventArgs<T> e, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListChangedEventHandler<T>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ObservableList_1_T_ListChangedEventArgs_1_T_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x000239F4 File Offset: 0x00021BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListChangedEventHandler<T>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00004638 File Offset: 0x00002838
		public ListChangedEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00004641 File Offset: 0x00002841
		public static implicit operator ListChangedEventHandler<T>(Action<ObservableList<T>, ListChangedEventArgs<T>> A_0)
		{
			return DelegateSupport.ConvertDelegate<ListChangedEventHandler<T>>(A_0);
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00004649 File Offset: 0x00002849
		public static ListChangedEventHandler<T>operator +(ListChangedEventHandler<T> A_0, ListChangedEventHandler<T> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<ListChangedEventHandler<T>>();
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00004657 File Offset: 0x00002857
		public static ListChangedEventHandler<T>operator -(ListChangedEventHandler<T> A_0, ListChangedEventHandler<T> A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<ListChangedEventHandler<T>>();
			}
			return delegate2;
		}

		// Token: 0x04000456 RID: 1110
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000457 RID: 1111
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ObservableList_1_T_ListChangedEventArgs_1_T_0;

		// Token: 0x04000458 RID: 1112
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ObservableList_1_T_ListChangedEventArgs_1_T_AsyncCallback_Object_0;

		// Token: 0x04000459 RID: 1113
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
