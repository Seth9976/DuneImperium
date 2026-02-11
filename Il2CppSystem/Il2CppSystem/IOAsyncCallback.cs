using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200006D RID: 109
	public sealed class IOAsyncCallback : MulticastDelegate
	{
		// Token: 0x060006A7 RID: 1703 RVA: 0x0003603C File Offset: 0x0003423C
		// Note: this type is marked as 'beforefieldinit'.
		static IOAsyncCallback()
		{
			Il2CppClassPointerStore<IOAsyncCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "IOAsyncCallback");
			IOAsyncCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOAsyncCallback>.NativeClassPtr, 100664399);
			IOAsyncCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOAsyncCallback>.NativeClassPtr, 100664400);
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x0003608C File Offset: 0x0003428C
		[CallerCount(431)]
		[CachedScanResults(RefRangeStart = 436687, RefRangeEnd = 437118, XrefRangeStart = 436678, XrefRangeEnd = 436687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IOAsyncCallback(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IOAsyncCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOAsyncCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x000360E8 File Offset: 0x000342E8
		[CallerCount(0)]
		public unsafe void Invoke(IOAsyncResult ioares)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ioares);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOAsyncCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x0000421F File Offset: 0x0000241F
		public IOAsyncCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00004228 File Offset: 0x00002428
		public static implicit operator IOAsyncCallback(Action<IOAsyncResult> A_0)
		{
			return DelegateSupport.ConvertDelegate<IOAsyncCallback>(A_0);
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x00004230 File Offset: 0x00002430
		public static IOAsyncCallback operator +(IOAsyncCallback A_0, IOAsyncCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<IOAsyncCallback>();
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x0000423E File Offset: 0x0000243E
		public static IOAsyncCallback operator -(IOAsyncCallback A_0, IOAsyncCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<IOAsyncCallback>();
			}
			return delegate2;
		}

		// Token: 0x040005B4 RID: 1460
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040005B5 RID: 1461
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IOAsyncResult_0;
	}
}
