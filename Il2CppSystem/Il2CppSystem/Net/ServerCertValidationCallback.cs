using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Net.Security;
using Il2CppSystem.Security.Cryptography.X509Certificates;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Net
{
	// Token: 0x020001E9 RID: 489
	public class ServerCertValidationCallback : Object
	{
		// Token: 0x06001E7B RID: 7803 RVA: 0x000927A8 File Offset: 0x000909A8
		// Note: this type is marked as 'beforefieldinit'.
		static ServerCertValidationCallback()
		{
			Il2CppClassPointerStore<ServerCertValidationCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "ServerCertValidationCallback");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerCertValidationCallback>.NativeClassPtr);
			ServerCertValidationCallback.NativeFieldInfoPtr_m_ValidationCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerCertValidationCallback>.NativeClassPtr, "m_ValidationCallback");
			ServerCertValidationCallback.NativeFieldInfoPtr_m_Context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerCertValidationCallback>.NativeClassPtr, "m_Context");
			ServerCertValidationCallback.NativeMethodInfoPtr__ctor_Internal_Void_RemoteCertificateValidationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerCertValidationCallback>.NativeClassPtr, 100667940);
			ServerCertValidationCallback.NativeMethodInfoPtr_get_ValidationCallback_Internal_get_RemoteCertificateValidationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerCertValidationCallback>.NativeClassPtr, 100667941);
			ServerCertValidationCallback.NativeMethodInfoPtr_Callback_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerCertValidationCallback>.NativeClassPtr, 100667942);
			ServerCertValidationCallback.NativeMethodInfoPtr_Invoke_Internal_Boolean_Object_X509Certificate_X509Chain_SslPolicyErrors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerCertValidationCallback>.NativeClassPtr, 100667943);
		}

		// Token: 0x06001E7C RID: 7804 RVA: 0x00092850 File Offset: 0x00090A50
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 478528, RefRangeEnd = 478531, XrefRangeStart = 478521, XrefRangeEnd = 478528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServerCertValidationCallback(RemoteCertificateValidationCallback validationCallback)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerCertValidationCallback>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(validationCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerCertValidationCallback.NativeMethodInfoPtr__ctor_Internal_Void_RemoteCertificateValidationCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x06001E7D RID: 7805 RVA: 0x0009289C File Offset: 0x00090A9C
		public unsafe RemoteCertificateValidationCallback ValidationCallback
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerCertValidationCallback.NativeMethodInfoPtr_get_ValidationCallback_Internal_get_RemoteCertificateValidationCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RemoteCertificateValidationCallback>(intPtr3) : null;
			}
		}

		// Token: 0x06001E7E RID: 7806 RVA: 0x000928DC File Offset: 0x00090ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478531, XrefRangeEnd = 478533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Callback(Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerCertValidationCallback.NativeMethodInfoPtr_Callback_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E7F RID: 7807 RVA: 0x00092920 File Offset: 0x00090B20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 478551, RefRangeEnd = 478552, XrefRangeStart = 478533, XrefRangeEnd = 478551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Invoke(Object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(certificate);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chain);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sslPolicyErrors;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerCertValidationCallback.NativeMethodInfoPtr_Invoke_Internal_Boolean_Object_X509Certificate_X509Chain_SslPolicyErrors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001E80 RID: 7808 RVA: 0x0000CF94 File Offset: 0x0000B194
		public ServerCertValidationCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06001E81 RID: 7809 RVA: 0x000929A0 File Offset: 0x00090BA0
		// (set) Token: 0x06001E82 RID: 7810 RVA: 0x0000CF9D File Offset: 0x0000B19D
		public unsafe RemoteCertificateValidationCallback m_ValidationCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerCertValidationCallback.NativeFieldInfoPtr_m_ValidationCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RemoteCertificateValidationCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerCertValidationCallback.NativeFieldInfoPtr_m_ValidationCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x06001E83 RID: 7811 RVA: 0x000929D0 File Offset: 0x00090BD0
		// (set) Token: 0x06001E84 RID: 7812 RVA: 0x0000CFBC File Offset: 0x0000B1BC
		public unsafe ExecutionContext m_Context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerCertValidationCallback.NativeFieldInfoPtr_m_Context);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerCertValidationCallback.NativeFieldInfoPtr_m_Context), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400181E RID: 6174
		private static readonly IntPtr NativeFieldInfoPtr_m_ValidationCallback;

		// Token: 0x0400181F RID: 6175
		private static readonly IntPtr NativeFieldInfoPtr_m_Context;

		// Token: 0x04001820 RID: 6176
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_RemoteCertificateValidationCallback_0;

		// Token: 0x04001821 RID: 6177
		private static readonly IntPtr NativeMethodInfoPtr_get_ValidationCallback_Internal_get_RemoteCertificateValidationCallback_0;

		// Token: 0x04001822 RID: 6178
		private static readonly IntPtr NativeMethodInfoPtr_Callback_Internal_Void_Object_0;

		// Token: 0x04001823 RID: 6179
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Internal_Boolean_Object_X509Certificate_X509Chain_SslPolicyErrors_0;

		// Token: 0x02000331 RID: 817
		public class CallbackContext : Object
		{
			// Token: 0x06002F55 RID: 12117 RVA: 0x000CE500 File Offset: 0x000CC700
			// Note: this type is marked as 'beforefieldinit'.
			static CallbackContext()
			{
				Il2CppClassPointerStore<ServerCertValidationCallback.CallbackContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerCertValidationCallback>.NativeClassPtr, "CallbackContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerCertValidationCallback.CallbackContext>.NativeClassPtr);
				ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerCertValidationCallback.CallbackContext>.NativeClassPtr, "request");
				ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_certificate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerCertValidationCallback.CallbackContext>.NativeClassPtr, "certificate");
				ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_chain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerCertValidationCallback.CallbackContext>.NativeClassPtr, "chain");
				ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_sslPolicyErrors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerCertValidationCallback.CallbackContext>.NativeClassPtr, "sslPolicyErrors");
				ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerCertValidationCallback.CallbackContext>.NativeClassPtr, "result");
				ServerCertValidationCallback.CallbackContext.NativeMethodInfoPtr__ctor_Internal_Void_Object_X509Certificate_X509Chain_SslPolicyErrors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerCertValidationCallback.CallbackContext>.NativeClassPtr, 100667944);
			}

			// Token: 0x06002F56 RID: 12118 RVA: 0x000CE5A4 File Offset: 0x000CC7A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478517, XrefRangeEnd = 478521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CallbackContext(Object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerCertValidationCallback.CallbackContext>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(certificate);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chain);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sslPolicyErrors;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerCertValidationCallback.CallbackContext.NativeMethodInfoPtr__ctor_Internal_Void_Object_X509Certificate_X509Chain_SslPolicyErrors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F57 RID: 12119 RVA: 0x00015364 File Offset: 0x00013564
			public CallbackContext(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000ECA RID: 3786
			// (get) Token: 0x06002F58 RID: 12120 RVA: 0x000CE624 File Offset: 0x000CC824
			// (set) Token: 0x06002F59 RID: 12121 RVA: 0x0001536D File Offset: 0x0001356D
			public unsafe Object request
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_request);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000ECB RID: 3787
			// (get) Token: 0x06002F5A RID: 12122 RVA: 0x000CE654 File Offset: 0x000CC854
			// (set) Token: 0x06002F5B RID: 12123 RVA: 0x0001538C File Offset: 0x0001358C
			public unsafe X509Certificate certificate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_certificate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_certificate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000ECC RID: 3788
			// (get) Token: 0x06002F5C RID: 12124 RVA: 0x000CE684 File Offset: 0x000CC884
			// (set) Token: 0x06002F5D RID: 12125 RVA: 0x000153AB File Offset: 0x000135AB
			public unsafe X509Chain chain
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_chain);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Chain>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_chain), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000ECD RID: 3789
			// (get) Token: 0x06002F5E RID: 12126 RVA: 0x000CE6B4 File Offset: 0x000CC8B4
			// (set) Token: 0x06002F5F RID: 12127 RVA: 0x000153CA File Offset: 0x000135CA
			public unsafe SslPolicyErrors sslPolicyErrors
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_sslPolicyErrors);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_sslPolicyErrors)) = value;
				}
			}

			// Token: 0x17000ECE RID: 3790
			// (get) Token: 0x06002F60 RID: 12128 RVA: 0x000CE6DC File Offset: 0x000CC8DC
			// (set) Token: 0x06002F61 RID: 12129 RVA: 0x000153E5 File Offset: 0x000135E5
			public unsafe bool result
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_result);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerCertValidationCallback.CallbackContext.NativeFieldInfoPtr_result)) = value;
				}
			}

			// Token: 0x04002516 RID: 9494
			private static readonly IntPtr NativeFieldInfoPtr_request;

			// Token: 0x04002517 RID: 9495
			private static readonly IntPtr NativeFieldInfoPtr_certificate;

			// Token: 0x04002518 RID: 9496
			private static readonly IntPtr NativeFieldInfoPtr_chain;

			// Token: 0x04002519 RID: 9497
			private static readonly IntPtr NativeFieldInfoPtr_sslPolicyErrors;

			// Token: 0x0400251A RID: 9498
			private static readonly IntPtr NativeFieldInfoPtr_result;

			// Token: 0x0400251B RID: 9499
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Object_X509Certificate_X509Chain_SslPolicyErrors_0;
		}
	}
}
