using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Collections.Specialized
{
	// Token: 0x02000161 RID: 353
	public sealed class NotifyCollectionChangedEventHandler : MulticastDelegate
	{
		// Token: 0x0600154E RID: 5454 RVA: 0x0006F0A8 File Offset: 0x0006D2A8
		// Note: this type is marked as 'beforefieldinit'.
		static NotifyCollectionChangedEventHandler()
		{
			Il2CppClassPointerStore<NotifyCollectionChangedEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Collections.Specialized", "NotifyCollectionChangedEventHandler");
			NotifyCollectionChangedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotifyCollectionChangedEventHandler>.NativeClassPtr, 100666539);
			NotifyCollectionChangedEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_NotifyCollectionChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotifyCollectionChangedEventHandler>.NativeClassPtr, 100666540);
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x0006F0F8 File Offset: 0x0006D2F8
		[CallerCount(83)]
		[CachedScanResults(RefRangeStart = 367534, RefRangeEnd = 367617, XrefRangeStart = 367534, XrefRangeEnd = 367617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotifyCollectionChangedEventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotifyCollectionChangedEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotifyCollectionChangedEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001550 RID: 5456 RVA: 0x0006F154 File Offset: 0x0006D354
		[CallerCount(0)]
		public unsafe void Invoke(Object sender, NotifyCollectionChangedEventArgs e)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotifyCollectionChangedEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_NotifyCollectionChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x00009622 File Offset: 0x00007822
		public NotifyCollectionChangedEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x0000962B File Offset: 0x0000782B
		public static implicit operator NotifyCollectionChangedEventHandler(Action<Object, NotifyCollectionChangedEventArgs> A_0)
		{
			return DelegateSupport.ConvertDelegate<NotifyCollectionChangedEventHandler>(A_0);
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x00009633 File Offset: 0x00007833
		public static NotifyCollectionChangedEventHandler operator +(NotifyCollectionChangedEventHandler A_0, NotifyCollectionChangedEventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<NotifyCollectionChangedEventHandler>();
		}

		// Token: 0x06001554 RID: 5460 RVA: 0x00009641 File Offset: 0x00007841
		public static NotifyCollectionChangedEventHandler operator -(NotifyCollectionChangedEventHandler A_0, NotifyCollectionChangedEventHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<NotifyCollectionChangedEventHandler>();
			}
			return delegate2;
		}

		// Token: 0x040010B9 RID: 4281
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040010BA RID: 4282
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_NotifyCollectionChangedEventArgs_0;
	}
}
