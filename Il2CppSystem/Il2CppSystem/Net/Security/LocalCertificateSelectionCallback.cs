using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppSystem.Net.Security
{
	// Token: 0x02000264 RID: 612
	public sealed class LocalCertificateSelectionCallback : MulticastDelegate
	{
		// Token: 0x060028CF RID: 10447 RVA: 0x000B9AEC File Offset: 0x000B7CEC
		// Note: this type is marked as 'beforefieldinit'.
		static LocalCertificateSelectionCallback()
		{
			Il2CppClassPointerStore<LocalCertificateSelectionCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Security", "LocalCertificateSelectionCallback");
			LocalCertificateSelectionCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalCertificateSelectionCallback>.NativeClassPtr, 100669387);
			LocalCertificateSelectionCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_X509Certificate_Object_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalCertificateSelectionCallback>.NativeClassPtr, 100669388);
		}

		// Token: 0x060028D0 RID: 10448 RVA: 0x000B9B3C File Offset: 0x000B7D3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 493913, RefRangeEnd = 493915, XrefRangeStart = 493904, XrefRangeEnd = 493913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalCertificateSelectionCallback(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalCertificateSelectionCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalCertificateSelectionCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028D1 RID: 10449 RVA: 0x000B9B98 File Offset: 0x000B7D98
		[CallerCount(0)]
		public unsafe X509Certificate Invoke(Object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, Il2CppStringArray acceptableIssuers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetHost);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(localCertificates);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remoteCertificate);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(acceptableIssuers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalCertificateSelectionCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_X509Certificate_Object_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
		}

		// Token: 0x060028D2 RID: 10450 RVA: 0x0001193A File Offset: 0x0000FB3A
		public LocalCertificateSelectionCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060028D3 RID: 10451 RVA: 0x00011943 File Offset: 0x0000FB43
		public static implicit operator LocalCertificateSelectionCallback(Func<Object, string, X509CertificateCollection, X509Certificate, Il2CppStringArray, X509Certificate> A_0)
		{
			return DelegateSupport.ConvertDelegate<LocalCertificateSelectionCallback>(A_0);
		}

		// Token: 0x060028D4 RID: 10452 RVA: 0x0001194B File Offset: 0x0000FB4B
		public static LocalCertificateSelectionCallback operator +(LocalCertificateSelectionCallback A_0, LocalCertificateSelectionCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<LocalCertificateSelectionCallback>();
		}

		// Token: 0x060028D5 RID: 10453 RVA: 0x00011959 File Offset: 0x0000FB59
		public static LocalCertificateSelectionCallback operator -(LocalCertificateSelectionCallback A_0, LocalCertificateSelectionCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<LocalCertificateSelectionCallback>();
			}
			return delegate2;
		}

		// Token: 0x0400207A RID: 8314
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400207B RID: 8315
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_X509Certificate_Object_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_0;
	}
}
