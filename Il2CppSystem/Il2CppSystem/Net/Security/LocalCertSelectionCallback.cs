using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppSystem.Net.Security
{
	// Token: 0x02000267 RID: 615
	public sealed class LocalCertSelectionCallback : MulticastDelegate
	{
		// Token: 0x060028DD RID: 10461 RVA: 0x000B9D60 File Offset: 0x000B7F60
		// Note: this type is marked as 'beforefieldinit'.
		static LocalCertSelectionCallback()
		{
			Il2CppClassPointerStore<LocalCertSelectionCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Security", "LocalCertSelectionCallback");
			LocalCertSelectionCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalCertSelectionCallback>.NativeClassPtr, 100669391);
			LocalCertSelectionCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_X509Certificate_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalCertSelectionCallback>.NativeClassPtr, 100669392);
		}

		// Token: 0x060028DE RID: 10462 RVA: 0x000B9DB0 File Offset: 0x000B7FB0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 426933, RefRangeEnd = 426938, XrefRangeStart = 426933, XrefRangeEnd = 426938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalCertSelectionCallback(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalCertSelectionCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalCertSelectionCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028DF RID: 10463 RVA: 0x000B9E0C File Offset: 0x000B800C
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalCertSelectionCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_X509Certificate_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
		}

		// Token: 0x060028E0 RID: 10464 RVA: 0x0001199A File Offset: 0x0000FB9A
		public LocalCertSelectionCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060028E1 RID: 10465 RVA: 0x000119A3 File Offset: 0x0000FBA3
		public static implicit operator LocalCertSelectionCallback(Func<string, X509CertificateCollection, X509Certificate, Il2CppStringArray, X509Certificate> A_0)
		{
			return DelegateSupport.ConvertDelegate<LocalCertSelectionCallback>(A_0);
		}

		// Token: 0x060028E2 RID: 10466 RVA: 0x000119AB File Offset: 0x0000FBAB
		public static LocalCertSelectionCallback operator +(LocalCertSelectionCallback A_0, LocalCertSelectionCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<LocalCertSelectionCallback>();
		}

		// Token: 0x060028E3 RID: 10467 RVA: 0x000119B9 File Offset: 0x0000FBB9
		public static LocalCertSelectionCallback operator -(LocalCertSelectionCallback A_0, LocalCertSelectionCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<LocalCertSelectionCallback>();
			}
			return delegate2;
		}

		// Token: 0x04002083 RID: 8323
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04002084 RID: 8324
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_X509Certificate_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_0;
	}
}
