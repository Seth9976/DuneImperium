using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppSystem.Net.Security
{
	// Token: 0x02000265 RID: 613
	public sealed class RemoteCertificateValidationCallback : MulticastDelegate
	{
		// Token: 0x060028D6 RID: 10454 RVA: 0x000B9C34 File Offset: 0x000B7E34
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteCertificateValidationCallback()
		{
			Il2CppClassPointerStore<RemoteCertificateValidationCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Security", "RemoteCertificateValidationCallback");
			RemoteCertificateValidationCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteCertificateValidationCallback>.NativeClassPtr, 100669389);
			RemoteCertificateValidationCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Object_X509Certificate_X509Chain_SslPolicyErrors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteCertificateValidationCallback>.NativeClassPtr, 100669390);
		}

		// Token: 0x060028D7 RID: 10455 RVA: 0x000B9C84 File Offset: 0x000B7E84
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 493924, RefRangeEnd = 493928, XrefRangeStart = 493915, XrefRangeEnd = 493924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RemoteCertificateValidationCallback(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoteCertificateValidationCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteCertificateValidationCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028D8 RID: 10456 RVA: 0x000B9CE0 File Offset: 0x000B7EE0
		[CallerCount(0)]
		public unsafe bool Invoke(Object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(certificate);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chain);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sslPolicyErrors;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteCertificateValidationCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Object_X509Certificate_X509Chain_SslPolicyErrors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028D9 RID: 10457 RVA: 0x0001196A File Offset: 0x0000FB6A
		public RemoteCertificateValidationCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060028DA RID: 10458 RVA: 0x00011973 File Offset: 0x0000FB73
		public static implicit operator RemoteCertificateValidationCallback(Func<Object, X509Certificate, X509Chain, SslPolicyErrors, bool> A_0)
		{
			return DelegateSupport.ConvertDelegate<RemoteCertificateValidationCallback>(A_0);
		}

		// Token: 0x060028DB RID: 10459 RVA: 0x0001197B File Offset: 0x0000FB7B
		public static RemoteCertificateValidationCallback operator +(RemoteCertificateValidationCallback A_0, RemoteCertificateValidationCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<RemoteCertificateValidationCallback>();
		}

		// Token: 0x060028DC RID: 10460 RVA: 0x00011989 File Offset: 0x0000FB89
		public static RemoteCertificateValidationCallback operator -(RemoteCertificateValidationCallback A_0, RemoteCertificateValidationCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<RemoteCertificateValidationCallback>();
			}
			return delegate2;
		}

		// Token: 0x0400207C RID: 8316
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400207D RID: 8317
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Object_X509Certificate_X509Chain_SslPolicyErrors_0;
	}
}
