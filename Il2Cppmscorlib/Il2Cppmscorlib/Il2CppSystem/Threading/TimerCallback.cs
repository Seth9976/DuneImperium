using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x020001C4 RID: 452
	public sealed class TimerCallback : MulticastDelegate
	{
		// Token: 0x06001DBF RID: 7615 RVA: 0x000AD740 File Offset: 0x000AB940
		// Note: this type is marked as 'beforefieldinit'.
		static TimerCallback()
		{
			Il2CppClassPointerStore<TimerCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "TimerCallback");
			TimerCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerCallback>.NativeClassPtr, 100668347);
			TimerCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerCallback>.NativeClassPtr, 100668348);
		}

		// Token: 0x06001DC0 RID: 7616 RVA: 0x000AD790 File Offset: 0x000AB990
		[CallerCount(144)]
		[CachedScanResults(RefRangeStart = 387041, RefRangeEnd = 387185, XrefRangeStart = 387041, XrefRangeEnd = 387185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimerCallback(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimerCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DC1 RID: 7617 RVA: 0x000AD7EC File Offset: 0x000AB9EC
		[CallerCount(0)]
		public unsafe void Invoke(Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DC2 RID: 7618 RVA: 0x00009C32 File Offset: 0x00007E32
		public TimerCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001DC3 RID: 7619 RVA: 0x00009C3B File Offset: 0x00007E3B
		public static implicit operator TimerCallback(Action<Object> A_0)
		{
			return DelegateSupport.ConvertDelegate<TimerCallback>(A_0);
		}

		// Token: 0x06001DC4 RID: 7620 RVA: 0x00009C43 File Offset: 0x00007E43
		public static TimerCallback operator +(TimerCallback A_0, TimerCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<TimerCallback>();
		}

		// Token: 0x06001DC5 RID: 7621 RVA: 0x00009C51 File Offset: 0x00007E51
		public static TimerCallback operator -(TimerCallback A_0, TimerCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<TimerCallback>();
			}
			return delegate2;
		}

		// Token: 0x04001AAA RID: 6826
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001AAB RID: 6827
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0;
	}
}
