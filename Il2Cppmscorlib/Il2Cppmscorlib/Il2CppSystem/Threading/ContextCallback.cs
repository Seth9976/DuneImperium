using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x020001A6 RID: 422
	public sealed class ContextCallback : MulticastDelegate
	{
		// Token: 0x06001B66 RID: 7014 RVA: 0x000A51A4 File Offset: 0x000A33A4
		// Note: this type is marked as 'beforefieldinit'.
		static ContextCallback()
		{
			Il2CppClassPointerStore<ContextCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "ContextCallback");
			ContextCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextCallback>.NativeClassPtr, 100668024);
			ContextCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextCallback>.NativeClassPtr, 100668025);
		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x000A51F4 File Offset: 0x000A33F4
		[CallerCount(144)]
		[CachedScanResults(RefRangeStart = 387041, RefRangeEnd = 387185, XrefRangeStart = 387041, XrefRangeEnd = 387185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContextCallback(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B68 RID: 7016 RVA: 0x000A5250 File Offset: 0x000A3450
		[CallerCount(0)]
		public unsafe void Invoke(Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B69 RID: 7017 RVA: 0x00008CD5 File Offset: 0x00006ED5
		public ContextCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001B6A RID: 7018 RVA: 0x00008CDE File Offset: 0x00006EDE
		public static implicit operator ContextCallback(Action<Object> A_0)
		{
			return DelegateSupport.ConvertDelegate<ContextCallback>(A_0);
		}

		// Token: 0x06001B6B RID: 7019 RVA: 0x00008CE6 File Offset: 0x00006EE6
		public static ContextCallback operator +(ContextCallback A_0, ContextCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<ContextCallback>();
		}

		// Token: 0x06001B6C RID: 7020 RVA: 0x00008CF4 File Offset: 0x00006EF4
		public static ContextCallback operator -(ContextCallback A_0, ContextCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<ContextCallback>();
			}
			return delegate2;
		}

		// Token: 0x04001911 RID: 6417
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001912 RID: 6418
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0;
	}
}
