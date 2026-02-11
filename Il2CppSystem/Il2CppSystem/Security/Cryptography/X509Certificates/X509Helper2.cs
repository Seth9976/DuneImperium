using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.X509;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000DD RID: 221
	public static class X509Helper2 : Object
	{
		// Token: 0x06000EBF RID: 3775 RVA: 0x00053C74 File Offset: 0x00051E74
		// Note: this type is marked as 'beforefieldinit'.
		static X509Helper2()
		{
			Il2CppClassPointerStore<X509Helper2>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509Helper2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Helper2>.NativeClassPtr);
			X509Helper2.NativeMethodInfoPtr_GetMonoCertificate_Internal_Static_X509Certificate_X509Certificate2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper2>.NativeClassPtr, 100665442);
			X509Helper2.NativeMethodInfoPtr_CreateChainImpl_Internal_Static_X509ChainImpl_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper2>.NativeClassPtr, 100665443);
			X509Helper2.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_X509ChainImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper2>.NativeClassPtr, 100665444);
			X509Helper2.NativeMethodInfoPtr_ThrowIfContextInvalid_Internal_Static_Void_X509ChainImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper2>.NativeClassPtr, 100665445);
			X509Helper2.NativeMethodInfoPtr_GetInvalidChainContextException_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper2>.NativeClassPtr, 100665446);
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x00053D08 File Offset: 0x00051F08
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 455630, RefRangeEnd = 455636, XrefRangeStart = 455625, XrefRangeEnd = 455630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static X509Certificate GetMonoCertificate(X509Certificate2 certificate)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper2.NativeMethodInfoPtr_GetMonoCertificate_Internal_Static_X509Certificate_X509Certificate2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
			}
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x00053D4C File Offset: 0x00051F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 455636, XrefRangeEnd = 455640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static X509ChainImpl CreateChainImpl(bool useMachineContext)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref useMachineContext;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper2.NativeMethodInfoPtr_CreateChainImpl_Internal_Static_X509ChainImpl_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509ChainImpl>(intPtr3) : null;
			}
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x00053D8C File Offset: 0x00051F8C
		[CallerCount(0)]
		public unsafe static bool IsValid(X509ChainImpl impl)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(impl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper2.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_X509ChainImpl_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x00053DD0 File Offset: 0x00051FD0
		[CallerCount(0)]
		public unsafe static void ThrowIfContextInvalid(X509ChainImpl impl)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(impl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper2.NativeMethodInfoPtr_ThrowIfContextInvalid_Internal_Static_Void_X509ChainImpl_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x00053E08 File Offset: 0x00052008
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 455647, RefRangeEnd = 455653, XrefRangeStart = 455640, XrefRangeEnd = 455647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception GetInvalidChainContextException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper2.NativeMethodInfoPtr_GetInvalidChainContextException_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x00007559 File Offset: 0x00005759
		public X509Helper2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C13 RID: 3091
		private static readonly IntPtr NativeMethodInfoPtr_GetMonoCertificate_Internal_Static_X509Certificate_X509Certificate2_0;

		// Token: 0x04000C14 RID: 3092
		private static readonly IntPtr NativeMethodInfoPtr_CreateChainImpl_Internal_Static_X509ChainImpl_Boolean_0;

		// Token: 0x04000C15 RID: 3093
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Static_Boolean_X509ChainImpl_0;

		// Token: 0x04000C16 RID: 3094
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfContextInvalid_Internal_Static_Void_X509ChainImpl_0;

		// Token: 0x04000C17 RID: 3095
		private static readonly IntPtr NativeMethodInfoPtr_GetInvalidChainContextException_Internal_Static_Exception_0;
	}
}
