using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppMono.Security.Interface;
using Il2CppSystem;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Net.Security
{
	// Token: 0x02000023 RID: 35
	public static class SystemCertificateValidator : Object
	{
		// Token: 0x0600022F RID: 559 RVA: 0x00023698 File Offset: 0x00021898
		// Note: this type is marked as 'beforefieldinit'.
		static SystemCertificateValidator()
		{
			Il2CppClassPointerStore<SystemCertificateValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security", "SystemCertificateValidator");
			SystemCertificateValidator.NativeFieldInfoPtr_is_macosx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemCertificateValidator>.NativeClassPtr, "is_macosx");
			SystemCertificateValidator.NativeFieldInfoPtr_s_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemCertificateValidator>.NativeClassPtr, "s_flags");
			SystemCertificateValidator.NativeMethodInfoPtr_NeedsChain_Internal_Static_Boolean_MonoTlsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemCertificateValidator>.NativeClassPtr, 100663684);
		}

		// Token: 0x06000230 RID: 560 RVA: 0x000236FC File Offset: 0x000218FC
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool NeedsChain(MonoTlsSettings settings)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemCertificateValidator.NativeMethodInfoPtr_NeedsChain_Internal_Static_Boolean_MonoTlsSettings_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00002D12 File Offset: 0x00000F12
		public SystemCertificateValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000232 RID: 562 RVA: 0x00023740 File Offset: 0x00021940
		// (set) Token: 0x06000233 RID: 563 RVA: 0x00002D1B File Offset: 0x00000F1B
		public unsafe static bool is_macosx
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(SystemCertificateValidator.NativeFieldInfoPtr_is_macosx, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SystemCertificateValidator.NativeFieldInfoPtr_is_macosx, (void*)(&value));
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000234 RID: 564 RVA: 0x0002375C File Offset: 0x0002195C
		// (set) Token: 0x06000235 RID: 565 RVA: 0x00002D29 File Offset: 0x00000F29
		public unsafe static X509KeyUsageFlags s_flags
		{
			get
			{
				X509KeyUsageFlags x509KeyUsageFlags;
				IL2CPP.il2cpp_field_static_get_value(SystemCertificateValidator.NativeFieldInfoPtr_s_flags, (void*)(&x509KeyUsageFlags));
				return x509KeyUsageFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SystemCertificateValidator.NativeFieldInfoPtr_s_flags, (void*)(&value));
			}
		}

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeFieldInfoPtr_is_macosx;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeFieldInfoPtr_s_flags;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeMethodInfoPtr_NeedsChain_Internal_Static_Boolean_MonoTlsSettings_0;
	}
}
