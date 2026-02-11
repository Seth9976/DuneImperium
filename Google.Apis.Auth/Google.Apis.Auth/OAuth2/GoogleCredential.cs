using System;
using System.Runtime.InteropServices;
using Google.Apis.Http;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Net.Http;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2
{
	// Token: 0x0200000F RID: 15
	public class GoogleCredential : Object
	{
		// Token: 0x060000B0 RID: 176 RVA: 0x00009348 File Offset: 0x00007548
		// Note: this type is marked as 'beforefieldinit'.
		static GoogleCredential()
		{
			Il2CppClassPointerStore<GoogleCredential>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth.OAuth2", "GoogleCredential");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleCredential>.NativeClassPtr);
			GoogleCredential.NativeFieldInfoPtr_defaultCredentialProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleCredential>.NativeClassPtr, "defaultCredentialProvider");
			GoogleCredential.NativeFieldInfoPtr_credential = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleCredential>.NativeClassPtr, "credential");
			GoogleCredential.NativeMethodInfoPtr__ctor_Internal_Void_ICredential_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCredential>.NativeClassPtr, 100663464);
			GoogleCredential.NativeMethodInfoPtr_GetApplicationDefaultAsync_Public_Static_Task_1_GoogleCredential_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCredential>.NativeClassPtr, 100663465);
			GoogleCredential.NativeMethodInfoPtr_GetApplicationDefault_Public_Static_GoogleCredential_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCredential>.NativeClassPtr, 100663466);
			GoogleCredential.NativeMethodInfoPtr_FromStream_Public_Static_GoogleCredential_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCredential>.NativeClassPtr, 100663467);
			GoogleCredential.NativeMethodInfoPtr_FromFile_Public_Static_GoogleCredential_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCredential>.NativeClassPtr, 100663468);
			GoogleCredential.NativeMethodInfoPtr_FromJson_Public_Static_GoogleCredential_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCredential>.NativeClassPtr, 100663469);
			GoogleCredential.NativeMethodInfoPtr_FromAccessToken_Public_Static_GoogleCredential_String_IAccessMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCredential>.NativeClassPtr, 100663470);
			GoogleCredential.NativeMethodInfoPtr_FromComputeCredential_Public_Static_GoogleCredential_ComputeCredential_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCredential>.NativeClassPtr, 100663471);
			GoogleCredential.NativeMethodInfoPtr_get_IsCreateScopedRequired_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCredential>.NativeClassPtr, 100663472);
			GoogleCredential.NativeMethodInfoPtr_CreateScoped_Public_Virtual_New_GoogleCredential_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCredential>.NativeClassPtr, 100663473);
			GoogleCredential.NativeMethodInfoPtr_CreateWithUser_Public_Virtual_New_GoogleCredential_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCredential>.NativeClassPtr, 100663474);
			GoogleCredential.NativeMethodInfoPtr_CreateScoped_Public_GoogleCredential_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCredential>.NativeClassPtr, 100663475);
			GoogleCredential.NativeMethodInfoPtr_Google_Apis_Http_IConfigurableHttpClientInitializer_Initialize_Private_Virtual_Final_New_Void_ConfigurableHttpClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCredential>.NativeClassPtr, 100663476);
			GoogleCredential.NativeMethodInfoPtr_Google_Apis_Auth_OAuth2_ITokenAccess_GetAccessTokenForRequestAsync_Private_Virtual_Final_New_Task_1_String_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCredential>.NativeClassPtr, 100663477);
			GoogleCredential.NativeMethodInfoPtr_Google_Apis_Auth_OAuth2_ITokenAccessWithHeaders_GetAccessTokenWithHeadersForRequestAsync_Private_Virtual_Final_New_Task_1_AccessTokenWithHeaders_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCredential>.NativeClassPtr, 100663478);
			GoogleCredential.NativeMethodInfoPtr_get_UnderlyingCredential_Public_get_ICredential_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCredential>.NativeClassPtr, 100663479);
			GoogleCredential.NativeMethodInfoPtr_FromServiceAccountCredential_Public_Static_GoogleCredential_ServiceAccountCredential_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCredential>.NativeClassPtr, 100663480);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000094F4 File Offset: 0x000076F4
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GoogleCredential(ICredential credential)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleCredential>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(credential);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCredential.NativeMethodInfoPtr__ctor_Internal_Void_ICredential_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00009540 File Offset: 0x00007740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153712, XrefRangeEnd = 1153720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<GoogleCredential> GetApplicationDefaultAsync()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCredential.NativeMethodInfoPtr_GetApplicationDefaultAsync_Public_Static_Task_1_GoogleCredential_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<GoogleCredential>>(intPtr3) : null;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00009574 File Offset: 0x00007774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153720, XrefRangeEnd = 1153745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GoogleCredential GetApplicationDefault()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCredential.NativeMethodInfoPtr_GetApplicationDefault_Public_Static_GoogleCredential_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GoogleCredential>(intPtr3) : null;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000095A8 File Offset: 0x000077A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153745, XrefRangeEnd = 1153751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GoogleCredential FromStream(Stream stream)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCredential.NativeMethodInfoPtr_FromStream_Public_Static_GoogleCredential_Stream_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GoogleCredential>(intPtr3) : null;
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000095EC File Offset: 0x000077EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153751, XrefRangeEnd = 1153766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GoogleCredential FromFile(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCredential.NativeMethodInfoPtr_FromFile_Public_Static_GoogleCredential_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GoogleCredential>(intPtr3) : null;
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00009630 File Offset: 0x00007830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153766, XrefRangeEnd = 1153772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GoogleCredential FromJson(string json)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCredential.NativeMethodInfoPtr_FromJson_Public_Static_GoogleCredential_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GoogleCredential>(intPtr3) : null;
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00009674 File Offset: 0x00007874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153772, XrefRangeEnd = 1153787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GoogleCredential FromAccessToken(string accessToken, IAccessMethod accessMethod = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(accessToken);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accessMethod);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCredential.NativeMethodInfoPtr_FromAccessToken_Public_Static_GoogleCredential_String_IAccessMethod_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GoogleCredential>(intPtr3) : null;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000096CC File Offset: 0x000078CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153787, XrefRangeEnd = 1153796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GoogleCredential FromComputeCredential(ComputeCredential computeCredential = null)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(computeCredential);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCredential.NativeMethodInfoPtr_FromComputeCredential_Public_Static_GoogleCredential_ComputeCredential_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GoogleCredential>(intPtr3) : null;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00009710 File Offset: 0x00007910
		public unsafe virtual bool IsCreateScopedRequired
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleCredential.NativeMethodInfoPtr_get_IsCreateScopedRequired_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00009758 File Offset: 0x00007958
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual GoogleCredential CreateScoped(IEnumerable<string> scopes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scopes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleCredential.NativeMethodInfoPtr_CreateScoped_Public_Virtual_New_GoogleCredential_IEnumerable_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GoogleCredential>(intPtr3) : null;
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000097B4 File Offset: 0x000079B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153796, XrefRangeEnd = 1153801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual GoogleCredential CreateWithUser(string user)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(user);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleCredential.NativeMethodInfoPtr_CreateWithUser_Public_Virtual_New_GoogleCredential_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GoogleCredential>(intPtr3) : null;
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00009810 File Offset: 0x00007A10
		[CallerCount(0)]
		public unsafe GoogleCredential CreateScoped([Optional] Il2CppStringArray scopes)
		{
			if (scopes == null)
			{
				scopes = new Il2CppStringArray(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scopes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCredential.NativeMethodInfoPtr_CreateScoped_Public_GoogleCredential_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GoogleCredential>(intPtr3) : null;
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00009870 File Offset: 0x00007A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153801, XrefRangeEnd = 1153827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Google_Apis_Http_IConfigurableHttpClientInitializer_Initialize(ConfigurableHttpClient httpClient)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(httpClient);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCredential.NativeMethodInfoPtr_Google_Apis_Http_IConfigurableHttpClientInitializer_Initialize_Private_Virtual_Final_New_Void_ConfigurableHttpClient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000098B4 File Offset: 0x00007AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153827, XrefRangeEnd = 1153830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<string> Google_Apis_Auth_OAuth2_ITokenAccess_GetAccessTokenForRequestAsync(string authUri, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(authUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCredential.NativeMethodInfoPtr_Google_Apis_Auth_OAuth2_ITokenAccess_GetAccessTokenForRequestAsync_Private_Virtual_Final_New_Task_1_String_String_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<string>>(intPtr3) : null;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000991C File Offset: 0x00007B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153830, XrefRangeEnd = 1153846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<AccessTokenWithHeaders> Google_Apis_Auth_OAuth2_ITokenAccessWithHeaders_GetAccessTokenWithHeadersForRequestAsync(string authUri, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(authUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCredential.NativeMethodInfoPtr_Google_Apis_Auth_OAuth2_ITokenAccessWithHeaders_GetAccessTokenWithHeadersForRequestAsync_Private_Virtual_Final_New_Task_1_AccessTokenWithHeaders_String_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<AccessTokenWithHeaders>>(intPtr3) : null;
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00009984 File Offset: 0x00007B84
		public unsafe ICredential UnderlyingCredential
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCredential.NativeMethodInfoPtr_get_UnderlyingCredential_Public_get_ICredential_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICredential>(intPtr3) : null;
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000099C4 File Offset: 0x00007BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153846, XrefRangeEnd = 1153854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GoogleCredential FromServiceAccountCredential(ServiceAccountCredential credential)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(credential);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCredential.NativeMethodInfoPtr_FromServiceAccountCredential_Public_Static_GoogleCredential_ServiceAccountCredential_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GoogleCredential>(intPtr3) : null;
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002530 File Offset: 0x00000730
		public GoogleCredential CreateScoped(params string[] scopes)
		{
			return this.CreateScoped(new Il2CppStringArray(scopes));
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000253E File Offset: 0x0000073E
		public GoogleCredential(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00009A08 File Offset: 0x00007C08
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x00002547 File Offset: 0x00000747
		public unsafe static DefaultCredentialProvider defaultCredentialProvider
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GoogleCredential.NativeFieldInfoPtr_defaultCredentialProvider, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DefaultCredentialProvider>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GoogleCredential.NativeFieldInfoPtr_defaultCredentialProvider, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00009A30 File Offset: 0x00007C30
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x00002559 File Offset: 0x00000759
		public unsafe ICredential credential
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleCredential.NativeFieldInfoPtr_credential);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICredential>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleCredential.NativeFieldInfoPtr_credential), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeFieldInfoPtr_defaultCredentialProvider;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeFieldInfoPtr_credential;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ICredential_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_GetApplicationDefaultAsync_Public_Static_Task_1_GoogleCredential_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_GetApplicationDefault_Public_Static_GoogleCredential_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_FromStream_Public_Static_GoogleCredential_Stream_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_FromFile_Public_Static_GoogleCredential_String_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_FromJson_Public_Static_GoogleCredential_String_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_FromAccessToken_Public_Static_GoogleCredential_String_IAccessMethod_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_FromComputeCredential_Public_Static_GoogleCredential_ComputeCredential_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCreateScopedRequired_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_CreateScoped_Public_Virtual_New_GoogleCredential_IEnumerable_1_String_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_CreateWithUser_Public_Virtual_New_GoogleCredential_String_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_CreateScoped_Public_GoogleCredential_Il2CppStringArray_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_Google_Apis_Http_IConfigurableHttpClientInitializer_Initialize_Private_Virtual_Final_New_Void_ConfigurableHttpClient_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_Google_Apis_Auth_OAuth2_ITokenAccess_GetAccessTokenForRequestAsync_Private_Virtual_Final_New_Task_1_String_String_CancellationToken_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_Google_Apis_Auth_OAuth2_ITokenAccessWithHeaders_GetAccessTokenWithHeadersForRequestAsync_Private_Virtual_Final_New_Task_1_AccessTokenWithHeaders_String_CancellationToken_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_get_UnderlyingCredential_Public_get_ICredential_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_FromServiceAccountCredential_Public_Static_GoogleCredential_ServiceAccountCredential_0;

		// Token: 0x02000044 RID: 68
		public class AccessTokenCredential : Object
		{
			// Token: 0x0600043D RID: 1085 RVA: 0x0001558C File Offset: 0x0001378C
			// Note: this type is marked as 'beforefieldinit'.
			static AccessTokenCredential()
			{
				Il2CppClassPointerStore<GoogleCredential.AccessTokenCredential>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GoogleCredential>.NativeClassPtr, "AccessTokenCredential");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleCredential.AccessTokenCredential>.NativeClassPtr);
				GoogleCredential.AccessTokenCredential.NativeFieldInfoPtr__accessToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleCredential.AccessTokenCredential>.NativeClassPtr, "_accessToken");
				GoogleCredential.AccessTokenCredential.NativeFieldInfoPtr__accessMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleCredential.AccessTokenCredential>.NativeClassPtr, "_accessMethod");
				GoogleCredential.AccessTokenCredential.NativeMethodInfoPtr__ctor_Public_Void_String_IAccessMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCredential.AccessTokenCredential>.NativeClassPtr, 100663482);
				GoogleCredential.AccessTokenCredential.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_ConfigurableHttpClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCredential.AccessTokenCredential>.NativeClassPtr, 100663483);
				GoogleCredential.AccessTokenCredential.NativeMethodInfoPtr_GetAccessTokenForRequestAsync_Public_Virtual_Final_New_Task_1_String_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCredential.AccessTokenCredential>.NativeClassPtr, 100663484);
				GoogleCredential.AccessTokenCredential.NativeMethodInfoPtr_InterceptAsync_Public_Virtual_Final_New_Task_HttpRequestMessage_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCredential.AccessTokenCredential>.NativeClassPtr, 100663485);
			}

			// Token: 0x0600043E RID: 1086 RVA: 0x00015630 File Offset: 0x00013830
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AccessTokenCredential(string accessToken, IAccessMethod accessMethod)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleCredential.AccessTokenCredential>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(accessToken);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accessMethod);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCredential.AccessTokenCredential.NativeMethodInfoPtr__ctor_Public_Void_String_IAccessMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600043F RID: 1087 RVA: 0x00015690 File Offset: 0x00013890
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153564, XrefRangeEnd = 1153566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Initialize(ConfigurableHttpClient httpClient)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(httpClient);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCredential.AccessTokenCredential.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_ConfigurableHttpClient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000440 RID: 1088 RVA: 0x000156D4 File Offset: 0x000138D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153566, XrefRangeEnd = 1153572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual Task<string> GetAccessTokenForRequestAsync(string authUri = null, CancellationToken cancellationToken = null)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(authUri);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCredential.AccessTokenCredential.NativeMethodInfoPtr_GetAccessTokenForRequestAsync_Public_Virtual_Final_New_Task_1_String_String_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<string>>(intPtr3) : null;
			}

			// Token: 0x06000441 RID: 1089 RVA: 0x0001573C File Offset: 0x0001393C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153572, XrefRangeEnd = 1153598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual Task InterceptAsync(HttpRequestMessage request, CancellationToken taskCancellationToken)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(taskCancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCredential.AccessTokenCredential.NativeMethodInfoPtr_InterceptAsync_Public_Virtual_Final_New_Task_HttpRequestMessage_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}

			// Token: 0x06000442 RID: 1090 RVA: 0x00004140 File Offset: 0x00002340
			public AccessTokenCredential(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700018D RID: 397
			// (get) Token: 0x06000443 RID: 1091 RVA: 0x000157A4 File Offset: 0x000139A4
			// (set) Token: 0x06000444 RID: 1092 RVA: 0x00004149 File Offset: 0x00002349
			public unsafe string _accessToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleCredential.AccessTokenCredential.NativeFieldInfoPtr__accessToken);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleCredential.AccessTokenCredential.NativeFieldInfoPtr__accessToken), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700018E RID: 398
			// (get) Token: 0x06000445 RID: 1093 RVA: 0x000157CC File Offset: 0x000139CC
			// (set) Token: 0x06000446 RID: 1094 RVA: 0x00004168 File Offset: 0x00002368
			public unsafe IAccessMethod _accessMethod
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleCredential.AccessTokenCredential.NativeFieldInfoPtr__accessMethod);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAccessMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleCredential.AccessTokenCredential.NativeFieldInfoPtr__accessMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040002B4 RID: 692
			private static readonly IntPtr NativeFieldInfoPtr__accessToken;

			// Token: 0x040002B5 RID: 693
			private static readonly IntPtr NativeFieldInfoPtr__accessMethod;

			// Token: 0x040002B6 RID: 694
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_IAccessMethod_0;

			// Token: 0x040002B7 RID: 695
			private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_ConfigurableHttpClient_0;

			// Token: 0x040002B8 RID: 696
			private static readonly IntPtr NativeMethodInfoPtr_GetAccessTokenForRequestAsync_Public_Virtual_Final_New_Task_1_String_String_CancellationToken_0;

			// Token: 0x040002B9 RID: 697
			private static readonly IntPtr NativeMethodInfoPtr_InterceptAsync_Public_Virtual_Final_New_Task_HttpRequestMessage_CancellationToken_0;
		}

		// Token: 0x02000045 RID: 69
		public class ServiceAccountGoogleCredential : GoogleCredential
		{
			// Token: 0x06000447 RID: 1095 RVA: 0x000157FC File Offset: 0x000139FC
			// Note: this type is marked as 'beforefieldinit'.
			static ServiceAccountGoogleCredential()
			{
				Il2CppClassPointerStore<GoogleCredential.ServiceAccountGoogleCredential>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GoogleCredential>.NativeClassPtr, "ServiceAccountGoogleCredential");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleCredential.ServiceAccountGoogleCredential>.NativeClassPtr);
				GoogleCredential.ServiceAccountGoogleCredential.NativeMethodInfoPtr__ctor_Public_Void_ServiceAccountCredential_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCredential.ServiceAccountGoogleCredential>.NativeClassPtr, 100663486);
				GoogleCredential.ServiceAccountGoogleCredential.NativeMethodInfoPtr_get_IsCreateScopedRequired_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCredential.ServiceAccountGoogleCredential>.NativeClassPtr, 100663487);
				GoogleCredential.ServiceAccountGoogleCredential.NativeMethodInfoPtr_CreateScoped_Public_Virtual_GoogleCredential_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCredential.ServiceAccountGoogleCredential>.NativeClassPtr, 100663488);
				GoogleCredential.ServiceAccountGoogleCredential.NativeMethodInfoPtr_CreateWithUser_Public_Virtual_GoogleCredential_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCredential.ServiceAccountGoogleCredential>.NativeClassPtr, 100663489);
			}

			// Token: 0x06000448 RID: 1096 RVA: 0x00015878 File Offset: 0x00013A78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153598, XrefRangeEnd = 1153603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ServiceAccountGoogleCredential(ServiceAccountCredential credential)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleCredential.ServiceAccountGoogleCredential>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(credential);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCredential.ServiceAccountGoogleCredential.NativeMethodInfoPtr__ctor_Public_Void_ServiceAccountCredential_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x1700018F RID: 399
			// (get) Token: 0x06000449 RID: 1097 RVA: 0x000158C4 File Offset: 0x00013AC4
			public unsafe override bool IsCreateScopedRequired
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153603, XrefRangeEnd = 1153606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleCredential.ServiceAccountGoogleCredential.NativeMethodInfoPtr_get_IsCreateScopedRequired_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600044A RID: 1098 RVA: 0x0001590C File Offset: 0x00013B0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153606, XrefRangeEnd = 1153626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override GoogleCredential CreateScoped(IEnumerable<string> scopes)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(scopes);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleCredential.ServiceAccountGoogleCredential.NativeMethodInfoPtr_CreateScoped_Public_Virtual_GoogleCredential_IEnumerable_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GoogleCredential>(intPtr3) : null;
				}
			}

			// Token: 0x0600044B RID: 1099 RVA: 0x00015968 File Offset: 0x00013B68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153626, XrefRangeEnd = 1153646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override GoogleCredential CreateWithUser(string user)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(user);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleCredential.ServiceAccountGoogleCredential.NativeMethodInfoPtr_CreateWithUser_Public_Virtual_GoogleCredential_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GoogleCredential>(intPtr3) : null;
				}
			}

			// Token: 0x0600044C RID: 1100 RVA: 0x00004187 File Offset: 0x00002387
			public ServiceAccountGoogleCredential(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040002BA RID: 698
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ServiceAccountCredential_0;

			// Token: 0x040002BB RID: 699
			private static readonly IntPtr NativeMethodInfoPtr_get_IsCreateScopedRequired_Public_Virtual_get_Boolean_0;

			// Token: 0x040002BC RID: 700
			private static readonly IntPtr NativeMethodInfoPtr_CreateScoped_Public_Virtual_GoogleCredential_IEnumerable_1_String_0;

			// Token: 0x040002BD RID: 701
			private static readonly IntPtr NativeMethodInfoPtr_CreateWithUser_Public_Virtual_GoogleCredential_String_0;
		}

		// Token: 0x02000046 RID: 70
		[ObfuscatedName("Google.Apis.Auth.OAuth2.GoogleCredential+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600044D RID: 1101 RVA: 0x000159C4 File Offset: 0x00013BC4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GoogleCredential.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GoogleCredential>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleCredential.__c>.NativeClassPtr);
				GoogleCredential.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleCredential.__c>.NativeClassPtr, "<>9");
				GoogleCredential.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleCredential.__c>.NativeClassPtr, "<>9__4_0");
				GoogleCredential.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCredential.__c>.NativeClassPtr, 100663491);
				GoogleCredential.__c.NativeMethodInfoPtr__GetApplicationDefault_b__4_0_Internal_Task_1_GoogleCredential_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCredential.__c>.NativeClassPtr, 100663492);
			}

			// Token: 0x0600044E RID: 1102 RVA: 0x00015A40 File Offset: 0x00013C40
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleCredential.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCredential.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600044F RID: 1103 RVA: 0x00015A7C File Offset: 0x00013C7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153646, XrefRangeEnd = 1153657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Task<GoogleCredential> _GetApplicationDefault_b__4_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCredential.__c.NativeMethodInfoPtr__GetApplicationDefault_b__4_0_Internal_Task_1_GoogleCredential_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<GoogleCredential>>(intPtr3) : null;
			}

			// Token: 0x06000450 RID: 1104 RVA: 0x00004190 File Offset: 0x00002390
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000190 RID: 400
			// (get) Token: 0x06000451 RID: 1105 RVA: 0x00015ABC File Offset: 0x00013CBC
			// (set) Token: 0x06000452 RID: 1106 RVA: 0x00004199 File Offset: 0x00002399
			public unsafe static GoogleCredential.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GoogleCredential.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GoogleCredential.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GoogleCredential.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000191 RID: 401
			// (get) Token: 0x06000453 RID: 1107 RVA: 0x00015AE4 File Offset: 0x00013CE4
			// (set) Token: 0x06000454 RID: 1108 RVA: 0x000041AB File Offset: 0x000023AB
			public unsafe static Func<Task<GoogleCredential>> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GoogleCredential.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Task<GoogleCredential>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GoogleCredential.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040002BE RID: 702
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040002BF RID: 703
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x040002C0 RID: 704
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040002C1 RID: 705
			private static readonly IntPtr NativeMethodInfoPtr__GetApplicationDefault_b__4_0_Internal_Task_1_GoogleCredential_0;
		}

		// Token: 0x02000047 RID: 71
		[ObfuscatedName("Google.Apis.Auth.OAuth2.GoogleCredential+<Google-Apis-Auth-OAuth2-ITokenAccessWithHeaders-GetAccessTokenWithHeadersForRequestAsync>d__18")]
		public sealed class ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1AcGoStauCacaCoUnique : ValueType
		{
			// Token: 0x06000455 RID: 1109 RVA: 0x00015B0C File Offset: 0x00013D0C
			// Note: this type is marked as 'beforefieldinit'.
			static ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1AcGoStauCacaCoUnique()
			{
				Il2CppClassPointerStore<GoogleCredential.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1AcGoStauCacaCoUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GoogleCredential>.NativeClassPtr, "<Google-Apis-Auth-OAuth2-ITokenAccessWithHeaders-GetAccessTokenWithHeadersForRequestAsync>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleCredential.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1AcGoStauCacaCoUnique>.NativeClassPtr);
				GoogleCredential.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1AcGoStauCacaCoUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleCredential.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1AcGoStauCacaCoUnique>.NativeClassPtr, "<>1__state");
				GoogleCredential.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1AcGoStauCacaCoUnique.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleCredential.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1AcGoStauCacaCoUnique>.NativeClassPtr, "<>t__builder");
				GoogleCredential.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1AcGoStauCacaCoUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleCredential.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1AcGoStauCacaCoUnique>.NativeClassPtr, "<>4__this");
				GoogleCredential.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1AcGoStauCacaCoUnique.NativeFieldInfoPtr_authUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleCredential.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1AcGoStauCacaCoUnique>.NativeClassPtr, "authUri");
				GoogleCredential.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1AcGoStauCacaCoUnique.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleCredential.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1AcGoStauCacaCoUnique>.NativeClassPtr, "cancellationToken");
				GoogleCredential.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1AcGoStauCacaCoUnique.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleCredential.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1AcGoStauCacaCoUnique>.NativeClassPtr, "<>u__1");
				GoogleCredential.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1AcGoStauCacaCoUnique.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleCredential.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1AcGoStauCacaCoUnique>.NativeClassPtr, "<>u__2");
				GoogleCredential.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1AcGoStauCacaCoUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCredential.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1AcGoStauCacaCoUnique>.NativeClassPtr, 100663493);
				GoogleCredential.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1AcGoStauCacaCoUnique.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCredential.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1AcGoStauCacaCoUnique>.NativeClassPtr, 100663494);
			}

			// Token: 0x06000456 RID: 1110 RVA: 0x00015BEC File Offset: 0x00013DEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153657, XrefRangeEnd = 1153706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCredential.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1AcGoStauCacaCoUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000457 RID: 1111 RVA: 0x00015C24 File Offset: 0x00013E24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153706, XrefRangeEnd = 1153712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCredential.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1AcGoStauCacaCoUnique.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000458 RID: 1112 RVA: 0x000041BD File Offset: 0x000023BD
			public ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1AcGoStauCacaCoUnique(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000459 RID: 1113 RVA: 0x000041C6 File Offset: 0x000023C6
			public ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1AcGoStauCacaCoUnique()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleCredential.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1AcGoStauCacaCoUnique>.NativeClassPtr))
			{
			}

			// Token: 0x17000192 RID: 402
			// (get) Token: 0x0600045A RID: 1114 RVA: 0x00015C6C File Offset: 0x00013E6C
			// (set) Token: 0x0600045B RID: 1115 RVA: 0x000041D8 File Offset: 0x000023D8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleCredential.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1AcGoStauCacaCoUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleCredential.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1AcGoStauCacaCoUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000193 RID: 403
			// (get) Token: 0x0600045C RID: 1116 RVA: 0x00015C94 File Offset: 0x00013E94
			// (set) Token: 0x0600045D RID: 1117 RVA: 0x000041F3 File Offset: 0x000023F3
			public AsyncTaskMethodBuilder<AccessTokenWithHeaders> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleCredential.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1AcGoStauCacaCoUnique.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<AccessTokenWithHeaders>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<AccessTokenWithHeaders>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleCredential.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1AcGoStauCacaCoUnique.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<AccessTokenWithHeaders>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000194 RID: 404
			// (get) Token: 0x0600045E RID: 1118 RVA: 0x00015CC4 File Offset: 0x00013EC4
			// (set) Token: 0x0600045F RID: 1119 RVA: 0x00004221 File Offset: 0x00002421
			public unsafe GoogleCredential __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleCredential.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1AcGoStauCacaCoUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GoogleCredential>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleCredential.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1AcGoStauCacaCoUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000195 RID: 405
			// (get) Token: 0x06000460 RID: 1120 RVA: 0x00015CF4 File Offset: 0x00013EF4
			// (set) Token: 0x06000461 RID: 1121 RVA: 0x00004240 File Offset: 0x00002440
			public unsafe string authUri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleCredential.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1AcGoStauCacaCoUnique.NativeFieldInfoPtr_authUri);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleCredential.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1AcGoStauCacaCoUnique.NativeFieldInfoPtr_authUri), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000196 RID: 406
			// (get) Token: 0x06000462 RID: 1122 RVA: 0x00015D1C File Offset: 0x00013F1C
			// (set) Token: 0x06000463 RID: 1123 RVA: 0x0000425F File Offset: 0x0000245F
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleCredential.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1AcGoStauCacaCoUnique.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleCredential.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1AcGoStauCacaCoUnique.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000197 RID: 407
			// (get) Token: 0x06000464 RID: 1124 RVA: 0x00015D4C File Offset: 0x00013F4C
			// (set) Token: 0x06000465 RID: 1125 RVA: 0x0000428D File Offset: 0x0000248D
			public ConfiguredTaskAwaitable<AccessTokenWithHeaders>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleCredential.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1AcGoStauCacaCoUnique.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<AccessTokenWithHeaders>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<AccessTokenWithHeaders>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleCredential.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1AcGoStauCacaCoUnique.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<AccessTokenWithHeaders>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000198 RID: 408
			// (get) Token: 0x06000466 RID: 1126 RVA: 0x00015D7C File Offset: 0x00013F7C
			// (set) Token: 0x06000467 RID: 1127 RVA: 0x000042BB File Offset: 0x000024BB
			public ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleCredential.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1AcGoStauCacaCoUnique.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleCredential.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAs1AcGoStauCacaCoUnique.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040002C2 RID: 706
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040002C3 RID: 707
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040002C4 RID: 708
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040002C5 RID: 709
			private static readonly IntPtr NativeFieldInfoPtr_authUri;

			// Token: 0x040002C6 RID: 710
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040002C7 RID: 711
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040002C8 RID: 712
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040002C9 RID: 713
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002CA RID: 714
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
