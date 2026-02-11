using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200018D RID: 397
	public sealed class SendOrPostCallback : MulticastDelegate
	{
		// Token: 0x06001A10 RID: 6672 RVA: 0x000A07E0 File Offset: 0x0009E9E0
		// Note: this type is marked as 'beforefieldinit'.
		static SendOrPostCallback()
		{
			Il2CppClassPointerStore<SendOrPostCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "SendOrPostCallback");
			SendOrPostCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendOrPostCallback>.NativeClassPtr, 100667847);
			SendOrPostCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendOrPostCallback>.NativeClassPtr, 100667848);
		}

		// Token: 0x06001A11 RID: 6673 RVA: 0x000A0830 File Offset: 0x0009EA30
		[CallerCount(144)]
		[CachedScanResults(RefRangeStart = 387041, RefRangeEnd = 387185, XrefRangeStart = 387041, XrefRangeEnd = 387185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SendOrPostCallback(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SendOrPostCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendOrPostCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x000A088C File Offset: 0x0009EA8C
		[CallerCount(0)]
		public unsafe void Invoke(Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendOrPostCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x000084E9 File Offset: 0x000066E9
		public SendOrPostCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x000084F2 File Offset: 0x000066F2
		public static implicit operator SendOrPostCallback(Action<Object> A_0)
		{
			return DelegateSupport.ConvertDelegate<SendOrPostCallback>(A_0);
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x000084FA File Offset: 0x000066FA
		public static SendOrPostCallback operator +(SendOrPostCallback A_0, SendOrPostCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<SendOrPostCallback>();
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x00008508 File Offset: 0x00006708
		public static SendOrPostCallback operator -(SendOrPostCallback A_0, SendOrPostCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<SendOrPostCallback>();
			}
			return delegate2;
		}

		// Token: 0x04001820 RID: 6176
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001821 RID: 6177
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0;
	}
}
