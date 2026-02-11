using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x020001B3 RID: 435
	public sealed class WaitCallback : MulticastDelegate
	{
		// Token: 0x06001C65 RID: 7269 RVA: 0x000A9054 File Offset: 0x000A7254
		// Note: this type is marked as 'beforefieldinit'.
		static WaitCallback()
		{
			Il2CppClassPointerStore<WaitCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "WaitCallback");
			WaitCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitCallback>.NativeClassPtr, 100668192);
			WaitCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitCallback>.NativeClassPtr, 100668193);
		}

		// Token: 0x06001C66 RID: 7270 RVA: 0x000A90A4 File Offset: 0x000A72A4
		[CallerCount(144)]
		[CachedScanResults(RefRangeStart = 387041, RefRangeEnd = 387185, XrefRangeStart = 387041, XrefRangeEnd = 387185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaitCallback(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C67 RID: 7271 RVA: 0x000A9100 File Offset: 0x000A7300
		[CallerCount(0)]
		public unsafe void Invoke(Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C68 RID: 7272 RVA: 0x00009174 File Offset: 0x00007374
		public WaitCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001C69 RID: 7273 RVA: 0x0000917D File Offset: 0x0000737D
		public static implicit operator WaitCallback(Action<Object> A_0)
		{
			return DelegateSupport.ConvertDelegate<WaitCallback>(A_0);
		}

		// Token: 0x06001C6A RID: 7274 RVA: 0x00009185 File Offset: 0x00007385
		public static WaitCallback operator +(WaitCallback A_0, WaitCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<WaitCallback>();
		}

		// Token: 0x06001C6B RID: 7275 RVA: 0x00009193 File Offset: 0x00007393
		public static WaitCallback operator -(WaitCallback A_0, WaitCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<WaitCallback>();
			}
			return delegate2;
		}

		// Token: 0x040019D6 RID: 6614
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040019D7 RID: 6615
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0;
	}
}
