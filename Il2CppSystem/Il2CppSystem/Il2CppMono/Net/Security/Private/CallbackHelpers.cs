using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Interface;
using Il2CppSystem;
using Il2CppSystem.Net.Security;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Net.Security.Private
{
	// Token: 0x02000024 RID: 36
	public static class CallbackHelpers : Object
	{
		// Token: 0x06000236 RID: 566 RVA: 0x00023778 File Offset: 0x00021978
		// Note: this type is marked as 'beforefieldinit'.
		static CallbackHelpers()
		{
			Il2CppClassPointerStore<CallbackHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security.Private", "CallbackHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallbackHelpers>.NativeClassPtr);
			CallbackHelpers.NativeMethodInfoPtr_PublicToMono_Internal_Static_MonoRemoteCertificateValidationCallback_RemoteCertificateValidationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackHelpers>.NativeClassPtr, 100663685);
			CallbackHelpers.NativeMethodInfoPtr_MonoToInternal_Internal_Static_LocalCertSelectionCallback_MonoLocalCertificateSelectionCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackHelpers>.NativeClassPtr, 100663686);
		}

		// Token: 0x06000237 RID: 567 RVA: 0x000237D0 File Offset: 0x000219D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 429226, RefRangeEnd = 429229, XrefRangeStart = 429215, XrefRangeEnd = 429226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoRemoteCertificateValidationCallback PublicToMono(RemoteCertificateValidationCallback callback)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackHelpers.NativeMethodInfoPtr_PublicToMono_Internal_Static_MonoRemoteCertificateValidationCallback_RemoteCertificateValidationCallback_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoRemoteCertificateValidationCallback>(intPtr3) : null;
			}
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00023814 File Offset: 0x00021A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429229, XrefRangeEnd = 429240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LocalCertSelectionCallback MonoToInternal(MonoLocalCertificateSelectionCallback callback)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackHelpers.NativeMethodInfoPtr_MonoToInternal_Internal_Static_LocalCertSelectionCallback_MonoLocalCertificateSelectionCallback_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalCertSelectionCallback>(intPtr3) : null;
			}
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00002D37 File Offset: 0x00000F37
		public CallbackHelpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeMethodInfoPtr_PublicToMono_Internal_Static_MonoRemoteCertificateValidationCallback_RemoteCertificateValidationCallback_0;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeMethodInfoPtr_MonoToInternal_Internal_Static_LocalCertSelectionCallback_MonoLocalCertificateSelectionCallback_0;

		// Token: 0x020002A3 RID: 675
		[ObfuscatedName("Mono.Net.Security.Private.CallbackHelpers+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : Object
		{
			// Token: 0x06002AB7 RID: 10935 RVA: 0x000BEC80 File Offset: 0x000BCE80
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<CallbackHelpers.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CallbackHelpers>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallbackHelpers.__c__DisplayClass0_0>.NativeClassPtr);
				CallbackHelpers.__c__DisplayClass0_0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackHelpers.__c__DisplayClass0_0>.NativeClassPtr, "callback");
				CallbackHelpers.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackHelpers.__c__DisplayClass0_0>.NativeClassPtr, 100663687);
				CallbackHelpers.__c__DisplayClass0_0.NativeMethodInfoPtr__PublicToMono_b__0_Internal_Boolean_String_X509Certificate_X509Chain_MonoSslPolicyErrors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackHelpers.__c__DisplayClass0_0>.NativeClassPtr, 100663688);
			}

			// Token: 0x06002AB8 RID: 10936 RVA: 0x000BECE8 File Offset: 0x000BCEE8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallbackHelpers.__c__DisplayClass0_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackHelpers.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002AB9 RID: 10937 RVA: 0x000BED24 File Offset: 0x000BCF24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429214, XrefRangeEnd = 429215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PublicToMono_b__0(string h, X509Certificate c, X509Chain ch, MonoSslPolicyErrors e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(h);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ch);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref e;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackHelpers.__c__DisplayClass0_0.NativeMethodInfoPtr__PublicToMono_b__0_Internal_Boolean_String_X509Certificate_X509Chain_MonoSslPolicyErrors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002ABA RID: 10938 RVA: 0x00012F27 File Offset: 0x00011127
			public __c__DisplayClass0_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D87 RID: 3463
			// (get) Token: 0x06002ABB RID: 10939 RVA: 0x000BEDA4 File Offset: 0x000BCFA4
			// (set) Token: 0x06002ABC RID: 10940 RVA: 0x00012F30 File Offset: 0x00011130
			public unsafe RemoteCertificateValidationCallback callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackHelpers.__c__DisplayClass0_0.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RemoteCertificateValidationCallback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackHelpers.__c__DisplayClass0_0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040021B3 RID: 8627
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x040021B4 RID: 8628
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040021B5 RID: 8629
			private static readonly IntPtr NativeMethodInfoPtr__PublicToMono_b__0_Internal_Boolean_String_X509Certificate_X509Chain_MonoSslPolicyErrors_0;
		}

		// Token: 0x020002A4 RID: 676
		[ObfuscatedName("Mono.Net.Security.Private.CallbackHelpers+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x06002ABD RID: 10941 RVA: 0x000BEDD4 File Offset: 0x000BCFD4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<CallbackHelpers.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CallbackHelpers>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallbackHelpers.__c__DisplayClass6_0>.NativeClassPtr);
				CallbackHelpers.__c__DisplayClass6_0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackHelpers.__c__DisplayClass6_0>.NativeClassPtr, "callback");
				CallbackHelpers.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackHelpers.__c__DisplayClass6_0>.NativeClassPtr, 100663689);
				CallbackHelpers.__c__DisplayClass6_0.NativeMethodInfoPtr__MonoToInternal_b__0_Internal_X509Certificate_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackHelpers.__c__DisplayClass6_0>.NativeClassPtr, 100663690);
			}

			// Token: 0x06002ABE RID: 10942 RVA: 0x000BEE3C File Offset: 0x000BD03C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallbackHelpers.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackHelpers.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002ABF RID: 10943 RVA: 0x000BEE78 File Offset: 0x000BD078
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe X509Certificate _MonoToInternal_b__0(string t, X509CertificateCollection lc, X509Certificate rc, Il2CppStringArray ai)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(t);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lc);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rc);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ai);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackHelpers.__c__DisplayClass6_0.NativeMethodInfoPtr__MonoToInternal_b__0_Internal_X509Certificate_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
			}

			// Token: 0x06002AC0 RID: 10944 RVA: 0x00012F4F File Offset: 0x0001114F
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D88 RID: 3464
			// (get) Token: 0x06002AC1 RID: 10945 RVA: 0x000BEF00 File Offset: 0x000BD100
			// (set) Token: 0x06002AC2 RID: 10946 RVA: 0x00012F58 File Offset: 0x00011158
			public unsafe MonoLocalCertificateSelectionCallback callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackHelpers.__c__DisplayClass6_0.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoLocalCertificateSelectionCallback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackHelpers.__c__DisplayClass6_0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040021B6 RID: 8630
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x040021B7 RID: 8631
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040021B8 RID: 8632
			private static readonly IntPtr NativeMethodInfoPtr__MonoToInternal_b__0_Internal_X509Certificate_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_0;
		}
	}
}
