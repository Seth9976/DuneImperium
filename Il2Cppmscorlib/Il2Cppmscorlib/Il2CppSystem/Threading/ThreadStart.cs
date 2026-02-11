using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200018F RID: 399
	public sealed class ThreadStart : MulticastDelegate
	{
		// Token: 0x06001A1C RID: 6684 RVA: 0x000A0A28 File Offset: 0x0009EC28
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadStart()
		{
			Il2CppClassPointerStore<ThreadStart>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "ThreadStart");
			ThreadStart.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadStart>.NativeClassPtr, 100667852);
			ThreadStart.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadStart>.NativeClassPtr, 100667853);
		}

		// Token: 0x06001A1D RID: 6685 RVA: 0x000A0A78 File Offset: 0x0009EC78
		[CallerCount(288)]
		[CachedScanResults(RefRangeStart = 320972, RefRangeEnd = 321260, XrefRangeStart = 320972, XrefRangeEnd = 321260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThreadStart(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadStart>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadStart.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A1E RID: 6686 RVA: 0x000A0AD4 File Offset: 0x0009ECD4
		[CallerCount(0)]
		public unsafe void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadStart.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A1F RID: 6687 RVA: 0x00008522 File Offset: 0x00006722
		public ThreadStart(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001A20 RID: 6688 RVA: 0x0000852B File Offset: 0x0000672B
		public static implicit operator ThreadStart(Action A_0)
		{
			return DelegateSupport.ConvertDelegate<ThreadStart>(A_0);
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x00008533 File Offset: 0x00006733
		public static ThreadStart operator +(ThreadStart A_0, ThreadStart A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<ThreadStart>();
		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x00008541 File Offset: 0x00006741
		public static ThreadStart operator -(ThreadStart A_0, ThreadStart A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<ThreadStart>();
			}
			return delegate2;
		}

		// Token: 0x04001825 RID: 6181
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001826 RID: 6182
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;
	}
}
