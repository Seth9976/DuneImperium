using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020001BA RID: 442
	public sealed class HttpContinueDelegate : MulticastDelegate
	{
		// Token: 0x06001B2D RID: 6957 RVA: 0x000867E0 File Offset: 0x000849E0
		// Note: this type is marked as 'beforefieldinit'.
		static HttpContinueDelegate()
		{
			Il2CppClassPointerStore<HttpContinueDelegate>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "HttpContinueDelegate");
			HttpContinueDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContinueDelegate>.NativeClassPtr, 100667502);
			HttpContinueDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpContinueDelegate>.NativeClassPtr, 100667503);
		}

		// Token: 0x06001B2E RID: 6958 RVA: 0x00086830 File Offset: 0x00084A30
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 474619, RefRangeEnd = 474622, XrefRangeStart = 474616, XrefRangeEnd = 474619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpContinueDelegate(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpContinueDelegate>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContinueDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B2F RID: 6959 RVA: 0x0008688C File Offset: 0x00084A8C
		[CallerCount(0)]
		public unsafe void Invoke(int StatusCode, WebHeaderCollection httpHeaders)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref StatusCode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(httpHeaders);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpContinueDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_WebHeaderCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B30 RID: 6960 RVA: 0x0000BA91 File Offset: 0x00009C91
		public HttpContinueDelegate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001B31 RID: 6961 RVA: 0x0000BA9A File Offset: 0x00009C9A
		public static implicit operator HttpContinueDelegate(Action<int, WebHeaderCollection> A_0)
		{
			return DelegateSupport.ConvertDelegate<HttpContinueDelegate>(A_0);
		}

		// Token: 0x06001B32 RID: 6962 RVA: 0x0000BAA2 File Offset: 0x00009CA2
		public static HttpContinueDelegate operator +(HttpContinueDelegate A_0, HttpContinueDelegate A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<HttpContinueDelegate>();
		}

		// Token: 0x06001B33 RID: 6963 RVA: 0x0000BAB0 File Offset: 0x00009CB0
		public static HttpContinueDelegate operator -(HttpContinueDelegate A_0, HttpContinueDelegate A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<HttpContinueDelegate>();
			}
			return delegate2;
		}

		// Token: 0x0400159F RID: 5535
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040015A0 RID: 5536
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_WebHeaderCollection_0;
	}
}
