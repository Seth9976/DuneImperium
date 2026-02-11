using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020001A7 RID: 423
	public sealed class AuthenticationSchemeSelector : MulticastDelegate
	{
		// Token: 0x06001A8F RID: 6799 RVA: 0x00084800 File Offset: 0x00082A00
		// Note: this type is marked as 'beforefieldinit'.
		static AuthenticationSchemeSelector()
		{
			Il2CppClassPointerStore<AuthenticationSchemeSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "AuthenticationSchemeSelector");
			AuthenticationSchemeSelector.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticationSchemeSelector>.NativeClassPtr, 100667437);
			AuthenticationSchemeSelector.NativeMethodInfoPtr_Invoke_Public_Virtual_New_AuthenticationSchemes_HttpListenerRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticationSchemeSelector>.NativeClassPtr, 100667438);
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x00084850 File Offset: 0x00082A50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 430642, RefRangeEnd = 430643, XrefRangeStart = 430642, XrefRangeEnd = 430643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AuthenticationSchemeSelector(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthenticationSchemeSelector>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticationSchemeSelector.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x000848AC File Offset: 0x00082AAC
		[CallerCount(0)]
		public unsafe AuthenticationSchemes Invoke(HttpListenerRequest httpRequest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(httpRequest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticationSchemeSelector.NativeMethodInfoPtr_Invoke_Public_Virtual_New_AuthenticationSchemes_HttpListenerRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x0000B606 File Offset: 0x00009806
		public AuthenticationSchemeSelector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x0000B60F File Offset: 0x0000980F
		public static implicit operator AuthenticationSchemeSelector(Func<HttpListenerRequest, AuthenticationSchemes> A_0)
		{
			return DelegateSupport.ConvertDelegate<AuthenticationSchemeSelector>(A_0);
		}

		// Token: 0x06001A94 RID: 6804 RVA: 0x0000B617 File Offset: 0x00009817
		public static AuthenticationSchemeSelector operator +(AuthenticationSchemeSelector A_0, AuthenticationSchemeSelector A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<AuthenticationSchemeSelector>();
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x0000B625 File Offset: 0x00009825
		public static AuthenticationSchemeSelector operator -(AuthenticationSchemeSelector A_0, AuthenticationSchemeSelector A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<AuthenticationSchemeSelector>();
			}
			return delegate2;
		}

		// Token: 0x040014F4 RID: 5364
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040014F5 RID: 5365
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_AuthenticationSchemes_HttpListenerRequest_0;
	}
}
