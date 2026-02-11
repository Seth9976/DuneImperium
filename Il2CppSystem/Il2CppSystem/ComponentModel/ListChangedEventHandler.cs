using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x0200011B RID: 283
	public sealed class ListChangedEventHandler : MulticastDelegate
	{
		// Token: 0x06001162 RID: 4450 RVA: 0x0005E658 File Offset: 0x0005C858
		// Note: this type is marked as 'beforefieldinit'.
		static ListChangedEventHandler()
		{
			Il2CppClassPointerStore<ListChangedEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "ListChangedEventHandler");
			ListChangedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListChangedEventHandler>.NativeClassPtr, 100665822);
			ListChangedEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_ListChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListChangedEventHandler>.NativeClassPtr, 100665823);
		}

		// Token: 0x06001163 RID: 4451 RVA: 0x0005E6A8 File Offset: 0x0005C8A8
		[CallerCount(83)]
		[CachedScanResults(RefRangeStart = 367534, RefRangeEnd = 367617, XrefRangeStart = 367534, XrefRangeEnd = 367617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListChangedEventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListChangedEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListChangedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x0005E704 File Offset: 0x0005C904
		[CallerCount(0)]
		public unsafe void Invoke(Object sender, ListChangedEventArgs e)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListChangedEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_ListChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001165 RID: 4453 RVA: 0x00008241 File Offset: 0x00006441
		public ListChangedEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001166 RID: 4454 RVA: 0x0000824A File Offset: 0x0000644A
		public static implicit operator ListChangedEventHandler(Action<Object, ListChangedEventArgs> A_0)
		{
			return DelegateSupport.ConvertDelegate<ListChangedEventHandler>(A_0);
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x00008252 File Offset: 0x00006452
		public static ListChangedEventHandler operator +(ListChangedEventHandler A_0, ListChangedEventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<ListChangedEventHandler>();
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x00008260 File Offset: 0x00006460
		public static ListChangedEventHandler operator -(ListChangedEventHandler A_0, ListChangedEventHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<ListChangedEventHandler>();
			}
			return delegate2;
		}

		// Token: 0x04000DE3 RID: 3555
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000DE4 RID: 3556
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_ListChangedEventArgs_0;
	}
}
