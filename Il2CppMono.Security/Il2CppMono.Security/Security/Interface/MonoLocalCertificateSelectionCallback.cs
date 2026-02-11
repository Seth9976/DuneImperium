using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Security.Interface
{
	// Token: 0x02000029 RID: 41
	public sealed class MonoLocalCertificateSelectionCallback : MulticastDelegate
	{
		// Token: 0x06000240 RID: 576 RVA: 0x0000CA40 File Offset: 0x0000AC40
		// Note: this type is marked as 'beforefieldinit'.
		static MonoLocalCertificateSelectionCallback()
		{
			Il2CppClassPointerStore<MonoLocalCertificateSelectionCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Interface", "MonoLocalCertificateSelectionCallback");
			MonoLocalCertificateSelectionCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoLocalCertificateSelectionCallback>.NativeClassPtr, 100663632);
			MonoLocalCertificateSelectionCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_X509Certificate_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoLocalCertificateSelectionCallback>.NativeClassPtr, 100663633);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0000CA90 File Offset: 0x0000AC90
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 426933, RefRangeEnd = 426938, XrefRangeStart = 426933, XrefRangeEnd = 426938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoLocalCertificateSelectionCallback(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoLocalCertificateSelectionCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoLocalCertificateSelectionCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0000CAEC File Offset: 0x0000ACEC
		[CallerCount(0)]
		public unsafe X509Certificate Invoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, Il2CppStringArray acceptableIssuers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(targetHost);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(localCertificates);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remoteCertificate);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(acceptableIssuers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoLocalCertificateSelectionCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_X509Certificate_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00002F55 File Offset: 0x00001155
		public MonoLocalCertificateSelectionCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00002F5E File Offset: 0x0000115E
		public static implicit operator MonoLocalCertificateSelectionCallback(Func<string, X509CertificateCollection, X509Certificate, Il2CppStringArray, X509Certificate> A_0)
		{
			return DelegateSupport.ConvertDelegate<MonoLocalCertificateSelectionCallback>(A_0);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00002F66 File Offset: 0x00001166
		public static MonoLocalCertificateSelectionCallback operator +(MonoLocalCertificateSelectionCallback A_0, MonoLocalCertificateSelectionCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<MonoLocalCertificateSelectionCallback>();
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00002F74 File Offset: 0x00001174
		public static MonoLocalCertificateSelectionCallback operator -(MonoLocalCertificateSelectionCallback A_0, MonoLocalCertificateSelectionCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<MonoLocalCertificateSelectionCallback>();
			}
			return delegate2;
		}

		// Token: 0x040002C3 RID: 707
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040002C4 RID: 708
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_X509Certificate_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_0;
	}
}
