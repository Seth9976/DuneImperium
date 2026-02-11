using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Security.Interface
{
	// Token: 0x02000028 RID: 40
	public sealed class MonoRemoteCertificateValidationCallback : MulticastDelegate
	{
		// Token: 0x06000239 RID: 569 RVA: 0x0000C914 File Offset: 0x0000AB14
		// Note: this type is marked as 'beforefieldinit'.
		static MonoRemoteCertificateValidationCallback()
		{
			Il2CppClassPointerStore<MonoRemoteCertificateValidationCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Interface", "MonoRemoteCertificateValidationCallback");
			MonoRemoteCertificateValidationCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoRemoteCertificateValidationCallback>.NativeClassPtr, 100663630);
			MonoRemoteCertificateValidationCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_String_X509Certificate_X509Chain_MonoSslPolicyErrors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoRemoteCertificateValidationCallback>.NativeClassPtr, 100663631);
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0000C964 File Offset: 0x0000AB64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1149377, RefRangeEnd = 1149379, XrefRangeStart = 1149373, XrefRangeEnd = 1149377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoRemoteCertificateValidationCallback(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoRemoteCertificateValidationCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoRemoteCertificateValidationCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0000C9C0 File Offset: 0x0000ABC0
		[CallerCount(0)]
		public unsafe bool Invoke(string targetHost, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(targetHost);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(certificate);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chain);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sslPolicyErrors;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoRemoteCertificateValidationCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_String_X509Certificate_X509Chain_MonoSslPolicyErrors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00002F25 File Offset: 0x00001125
		public MonoRemoteCertificateValidationCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00002F2E File Offset: 0x0000112E
		public static implicit operator MonoRemoteCertificateValidationCallback(Func<string, X509Certificate, X509Chain, MonoSslPolicyErrors, bool> A_0)
		{
			return DelegateSupport.ConvertDelegate<MonoRemoteCertificateValidationCallback>(A_0);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00002F36 File Offset: 0x00001136
		public static MonoRemoteCertificateValidationCallback operator +(MonoRemoteCertificateValidationCallback A_0, MonoRemoteCertificateValidationCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<MonoRemoteCertificateValidationCallback>();
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00002F44 File Offset: 0x00001144
		public static MonoRemoteCertificateValidationCallback operator -(MonoRemoteCertificateValidationCallback A_0, MonoRemoteCertificateValidationCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<MonoRemoteCertificateValidationCallback>();
			}
			return delegate2;
		}

		// Token: 0x040002C1 RID: 705
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040002C2 RID: 706
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_String_X509Certificate_X509Chain_MonoSslPolicyErrors_0;
	}
}
