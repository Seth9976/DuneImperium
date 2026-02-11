using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppMono.Security.Interface;
using Il2CppSystem;

namespace Il2CppMono.Unity
{
	// Token: 0x02000009 RID: 9
	public static class Debug : Object
	{
		// Token: 0x06000040 RID: 64 RVA: 0x0001B6FC File Offset: 0x000198FC
		// Note: this type is marked as 'beforefieldinit'.
		static Debug()
		{
			Il2CppClassPointerStore<Debug>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Unity", "Debug");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Debug>.NativeClassPtr);
			Debug.NativeMethodInfoPtr_CheckAndThrow_Public_Static_Void_unitytls_errorstate_String_AlertDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663333);
			Debug.NativeMethodInfoPtr_CheckAndThrow_Public_Static_Void_unitytls_errorstate_unitytls_x509verify_result_String_AlertDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663334);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0001B754 File Offset: 0x00019954
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 426922, RefRangeEnd = 426923, XrefRangeStart = 426922, XrefRangeEnd = 426922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckAndThrow(UnityTls.unitytls_errorstate errorState, string context, AlertDescription defaultAlert = AlertDescription.InternalError)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref errorState;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(context);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultAlert;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_CheckAndThrow_Public_Static_Void_unitytls_errorstate_String_AlertDescription_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0001B7A8 File Offset: 0x000199A8
		[CallerCount(0)]
		public unsafe static void CheckAndThrow(UnityTls.unitytls_errorstate errorState, UnityTls.unitytls_x509verify_result verifyResult, string context, AlertDescription defaultAlert = AlertDescription.InternalError)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref errorState;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref verifyResult;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(context);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultAlert;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_CheckAndThrow_Public_Static_Void_unitytls_errorstate_unitytls_x509verify_result_String_AlertDescription_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000219A File Offset: 0x0000039A
		public Debug(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_CheckAndThrow_Public_Static_Void_unitytls_errorstate_String_AlertDescription_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_CheckAndThrow_Public_Static_Void_unitytls_errorstate_unitytls_x509verify_result_String_AlertDescription_0;
	}
}
