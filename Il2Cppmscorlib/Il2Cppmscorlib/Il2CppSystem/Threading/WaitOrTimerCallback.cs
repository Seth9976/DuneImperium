using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x020001B4 RID: 436
	public sealed class WaitOrTimerCallback : MulticastDelegate
	{
		// Token: 0x06001C6C RID: 7276 RVA: 0x000A9144 File Offset: 0x000A7344
		// Note: this type is marked as 'beforefieldinit'.
		static WaitOrTimerCallback()
		{
			Il2CppClassPointerStore<WaitOrTimerCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "WaitOrTimerCallback");
			WaitOrTimerCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitOrTimerCallback>.NativeClassPtr, 100668194);
			WaitOrTimerCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitOrTimerCallback>.NativeClassPtr, 100668195);
		}

		// Token: 0x06001C6D RID: 7277 RVA: 0x000A9194 File Offset: 0x000A7394
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 679788, RefRangeEnd = 679794, XrefRangeStart = 679788, XrefRangeEnd = 679794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaitOrTimerCallback(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitOrTimerCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitOrTimerCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C6E RID: 7278 RVA: 0x000A91F0 File Offset: 0x000A73F0
		[CallerCount(0)]
		public unsafe void Invoke(Object state, bool timedOut)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timedOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitOrTimerCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C6F RID: 7279 RVA: 0x000091A4 File Offset: 0x000073A4
		public WaitOrTimerCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001C70 RID: 7280 RVA: 0x000091AD File Offset: 0x000073AD
		public static implicit operator WaitOrTimerCallback(Action<Object, bool> A_0)
		{
			return DelegateSupport.ConvertDelegate<WaitOrTimerCallback>(A_0);
		}

		// Token: 0x06001C71 RID: 7281 RVA: 0x000091B5 File Offset: 0x000073B5
		public static WaitOrTimerCallback operator +(WaitOrTimerCallback A_0, WaitOrTimerCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<WaitOrTimerCallback>();
		}

		// Token: 0x06001C72 RID: 7282 RVA: 0x000091C3 File Offset: 0x000073C3
		public static WaitOrTimerCallback operator -(WaitOrTimerCallback A_0, WaitOrTimerCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<WaitOrTimerCallback>();
			}
			return delegate2;
		}

		// Token: 0x040019D8 RID: 6616
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040019D9 RID: 6617
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Boolean_0;
	}
}
