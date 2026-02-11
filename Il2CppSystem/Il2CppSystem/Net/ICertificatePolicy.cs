using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppSystem.Net
{
	// Token: 0x020001B1 RID: 433
	public class ICertificatePolicy : Il2CppObjectBase
	{
		// Token: 0x06001AE7 RID: 6887 RVA: 0x0000B839 File Offset: 0x00009A39
		// Note: this type is marked as 'beforefieldinit'.
		static ICertificatePolicy()
		{
			Il2CppClassPointerStore<ICertificatePolicy>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "ICertificatePolicy");
			ICertificatePolicy.NativeMethodInfoPtr_CheckValidationResult_Public_Abstract_Virtual_New_Boolean_ServicePoint_X509Certificate_WebRequest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICertificatePolicy>.NativeClassPtr, 100667475);
		}

		// Token: 0x06001AE8 RID: 6888 RVA: 0x00085B34 File Offset: 0x00083D34
		[CallerCount(0)]
		public unsafe virtual bool CheckValidationResult(ServicePoint srvPoint, X509Certificate certificate, WebRequest request, int certificateProblem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(srvPoint);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(certificate);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(request);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref certificateProblem;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICertificatePolicy.NativeMethodInfoPtr_CheckValidationResult_Public_Abstract_Virtual_New_Boolean_ServicePoint_X509Certificate_WebRequest_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AE9 RID: 6889 RVA: 0x0000B868 File Offset: 0x00009A68
		public ICertificatePolicy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001578 RID: 5496
		private static readonly IntPtr NativeMethodInfoPtr_CheckValidationResult_Public_Abstract_Virtual_New_Boolean_ServicePoint_X509Certificate_WebRequest_Int32_0;
	}
}
