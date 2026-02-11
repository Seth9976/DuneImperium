using System;
using Google.Apis.Auth.OAuth2.Responses;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Security.Cryptography;
using Il2CppSystem.Security.Cryptography.X509Certificates;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Auth.OAuth2
{
	// Token: 0x0200001C RID: 28
	public class ServiceAccountCredential : ServiceCredential
	{
		// Token: 0x0600013C RID: 316 RVA: 0x0000B2DC File Offset: 0x000094DC
		// Note: this type is marked as 'beforefieldinit'.
		static ServiceAccountCredential()
		{
			Il2CppClassPointerStore<ServiceAccountCredential>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth.OAuth2", "ServiceAccountCredential");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServiceAccountCredential>.NativeClassPtr);
			ServiceAccountCredential.NativeFieldInfoPtr_Sha256Oid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceAccountCredential>.NativeClassPtr, "Sha256Oid");
			ServiceAccountCredential.NativeFieldInfoPtr_UnixEpoch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceAccountCredential>.NativeClassPtr, "UnixEpoch");
			ServiceAccountCredential.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceAccountCredential>.NativeClassPtr, "id");
			ServiceAccountCredential.NativeFieldInfoPtr_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceAccountCredential>.NativeClassPtr, "user");
			ServiceAccountCredential.NativeFieldInfoPtr_scopes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceAccountCredential>.NativeClassPtr, "scopes");
			ServiceAccountCredential.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceAccountCredential>.NativeClassPtr, "key");
			ServiceAccountCredential.NativeFieldInfoPtr__ProjectId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceAccountCredential>.NativeClassPtr, "<ProjectId>k__BackingField");
			ServiceAccountCredential.NativeFieldInfoPtr_JwtLifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceAccountCredential>.NativeClassPtr, "JwtLifetime");
			ServiceAccountCredential.NativeFieldInfoPtr_JwtCacheExpiryWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceAccountCredential>.NativeClassPtr, "JwtCacheExpiryWindow");
			ServiceAccountCredential.NativeFieldInfoPtr_JwtCacheMaxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceAccountCredential>.NativeClassPtr, "JwtCacheMaxSize");
			ServiceAccountCredential.NativeFieldInfoPtr__jwtLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceAccountCredential>.NativeClassPtr, "_jwtLock");
			ServiceAccountCredential.NativeFieldInfoPtr__jwts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceAccountCredential>.NativeClassPtr, "_jwts");
			ServiceAccountCredential.NativeFieldInfoPtr__jwtCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceAccountCredential>.NativeClassPtr, "_jwtCache");
			ServiceAccountCredential.NativeMethodInfoPtr_get_Id_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential>.NativeClassPtr, 100663608);
			ServiceAccountCredential.NativeMethodInfoPtr_get_ProjectId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential>.NativeClassPtr, 100663609);
			ServiceAccountCredential.NativeMethodInfoPtr_set_ProjectId_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential>.NativeClassPtr, 100663610);
			ServiceAccountCredential.NativeMethodInfoPtr_get_User_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential>.NativeClassPtr, 100663611);
			ServiceAccountCredential.NativeMethodInfoPtr_get_Scopes_Public_get_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential>.NativeClassPtr, 100663612);
			ServiceAccountCredential.NativeMethodInfoPtr_get_Key_Public_get_RSACryptoServiceProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential>.NativeClassPtr, 100663613);
			ServiceAccountCredential.NativeMethodInfoPtr_get_HasScopes_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential>.NativeClassPtr, 100663614);
			ServiceAccountCredential.NativeMethodInfoPtr__ctor_Public_Void_Initializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential>.NativeClassPtr, 100663615);
			ServiceAccountCredential.NativeMethodInfoPtr_FromServiceAccountData_Public_Static_ServiceAccountCredential_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential>.NativeClassPtr, 100663616);
			ServiceAccountCredential.NativeMethodInfoPtr_RequestAccessTokenAsync_Public_Virtual_Task_1_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential>.NativeClassPtr, 100663617);
			ServiceAccountCredential.NativeMethodInfoPtr_GetAccessTokenForRequestAsync_Public_Virtual_Task_1_String_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential>.NativeClassPtr, 100663618);
			ServiceAccountCredential.NativeMethodInfoPtr_GetOrCreateJwtAccessTokenAsync_Private_Task_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential>.NativeClassPtr, 100663619);
			ServiceAccountCredential.NativeMethodInfoPtr_CreateJwtAccessToken_Private_String_String_DateTime_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential>.NativeClassPtr, 100663620);
			ServiceAccountCredential.NativeMethodInfoPtr_CreateAssertionFromPayload_Private_String_Payload_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential>.NativeClassPtr, 100663621);
			ServiceAccountCredential.NativeMethodInfoPtr_CreateSignature_Public_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential>.NativeClassPtr, 100663622);
			ServiceAccountCredential.NativeMethodInfoPtr_CreateSerializedHeader_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential>.NativeClassPtr, 100663623);
			ServiceAccountCredential.NativeMethodInfoPtr_CreatePayload_Private_Payload_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential>.NativeClassPtr, 100663624);
			ServiceAccountCredential.NativeMethodInfoPtr_UrlSafeBase64Encode_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential>.NativeClassPtr, 100663625);
			ServiceAccountCredential.NativeMethodInfoPtr_UrlSafeBase64Encode_Private_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential>.NativeClassPtr, 100663626);
			ServiceAccountCredential.NativeMethodInfoPtr_UrlSafeEncode_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential>.NativeClassPtr, 100663627);
			ServiceAccountCredential.NativeMethodInfoPtr___n__0_Private_Task_1_String_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential>.NativeClassPtr, 100663629);
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600013D RID: 317 RVA: 0x0000B5B4 File Offset: 0x000097B4
		public unsafe string Id
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential.NativeMethodInfoPtr_get_Id_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600013E RID: 318 RVA: 0x0000B5EC File Offset: 0x000097EC
		// (set) Token: 0x0600013F RID: 319 RVA: 0x0000B624 File Offset: 0x00009824
		public unsafe string ProjectId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential.NativeMethodInfoPtr_get_ProjectId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential.NativeMethodInfoPtr_set_ProjectId_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000140 RID: 320 RVA: 0x0000B668 File Offset: 0x00009868
		public unsafe string User
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential.NativeMethodInfoPtr_get_User_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000141 RID: 321 RVA: 0x0000B6A0 File Offset: 0x000098A0
		public unsafe IEnumerable<string> Scopes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential.NativeMethodInfoPtr_get_Scopes_Public_get_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000142 RID: 322 RVA: 0x0000B6E0 File Offset: 0x000098E0
		public unsafe RSACryptoServiceProvider Key
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential.NativeMethodInfoPtr_get_Key_Public_get_RSACryptoServiceProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RSACryptoServiceProvider>(intPtr3) : null;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000143 RID: 323 RVA: 0x0000B720 File Offset: 0x00009920
		public unsafe bool HasScopes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155395, XrefRangeEnd = 1155396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential.NativeMethodInfoPtr_get_HasScopes_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0000B75C File Offset: 0x0000995C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1155419, RefRangeEnd = 1155422, XrefRangeStart = 1155396, XrefRangeEnd = 1155419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServiceAccountCredential(ServiceAccountCredential.Initializer initializer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServiceAccountCredential>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(initializer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential.NativeMethodInfoPtr__ctor_Public_Void_Initializer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0000B7A8 File Offset: 0x000099A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1155433, RefRangeEnd = 1155434, XrefRangeStart = 1155422, XrefRangeEnd = 1155433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ServiceAccountCredential FromServiceAccountData(Stream credentialData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(credentialData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential.NativeMethodInfoPtr_FromServiceAccountData_Public_Static_ServiceAccountCredential_Stream_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServiceAccountCredential>(intPtr3) : null;
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0000B7EC File Offset: 0x000099EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155434, XrefRangeEnd = 1155449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task<bool> RequestAccessTokenAsync(CancellationToken taskCancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(taskCancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ServiceAccountCredential.NativeMethodInfoPtr_RequestAccessTokenAsync_Public_Virtual_Task_1_Boolean_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0000B84C File Offset: 0x00009A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155449, XrefRangeEnd = 1155465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task<string> GetAccessTokenForRequestAsync(string authUri = null, CancellationToken cancellationToken = null)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ServiceAccountCredential.NativeMethodInfoPtr_GetAccessTokenForRequestAsync_Public_Virtual_Task_1_String_String_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<string>>(intPtr3) : null;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0000B8C0 File Offset: 0x00009AC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1155554, RefRangeEnd = 1155555, XrefRangeStart = 1155465, XrefRangeEnd = 1155554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<string> GetOrCreateJwtAccessTokenAsync(string authUri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(authUri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential.NativeMethodInfoPtr_GetOrCreateJwtAccessTokenAsync_Private_Task_1_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<string>>(intPtr3) : null;
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0000B910 File Offset: 0x00009B10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1155583, RefRangeEnd = 1155584, XrefRangeStart = 1155555, XrefRangeEnd = 1155583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CreateJwtAccessToken(string authUri, DateTime issueUtc, DateTime expiryUtc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(authUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref issueUtc;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expiryUtc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential.NativeMethodInfoPtr_CreateJwtAccessToken_Private_String_String_DateTime_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0000B974 File Offset: 0x00009B74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1155634, RefRangeEnd = 1155636, XrefRangeStart = 1155584, XrefRangeEnd = 1155634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CreateAssertionFromPayload(JsonWebSignature.Payload payload)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(payload);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential.NativeMethodInfoPtr_CreateAssertionFromPayload_Private_String_Payload_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000B9BC File Offset: 0x00009BBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1155656, RefRangeEnd = 1155657, XrefRangeStart = 1155636, XrefRangeEnd = 1155656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CreateSignature(Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential.NativeMethodInfoPtr_CreateSignature_Public_String_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000BA04 File Offset: 0x00009C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155657, XrefRangeEnd = 1155676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CreateSerializedHeader()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential.NativeMethodInfoPtr_CreateSerializedHeader_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000BA30 File Offset: 0x00009C30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1155707, RefRangeEnd = 1155708, XrefRangeStart = 1155676, XrefRangeEnd = 1155707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GoogleJsonWebSignature.Payload CreatePayload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential.NativeMethodInfoPtr_CreatePayload_Private_Payload_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GoogleJsonWebSignature.Payload>(intPtr3) : null;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0000BA70 File Offset: 0x00009C70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1155721, RefRangeEnd = 1155723, XrefRangeStart = 1155708, XrefRangeEnd = 1155721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string UrlSafeBase64Encode(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential.NativeMethodInfoPtr_UrlSafeBase64Encode_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0000BAB8 File Offset: 0x00009CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155723, XrefRangeEnd = 1155735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string UrlSafeBase64Encode(Il2CppStructArray<byte> bytes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential.NativeMethodInfoPtr_UrlSafeBase64Encode_Private_String_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0000BB00 File Offset: 0x00009D00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155735, XrefRangeEnd = 1155753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string UrlSafeEncode(string base64Value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(base64Value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential.NativeMethodInfoPtr_UrlSafeEncode_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000BB48 File Offset: 0x00009D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155753, XrefRangeEnd = 1155755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<string> __n__0(string authUri, CancellationToken cancellationToken)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential.NativeMethodInfoPtr___n__0_Private_Task_1_String_String_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<string>>(intPtr3) : null;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x000028BF File Offset: 0x00000ABF
		public ServiceAccountCredential(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000153 RID: 339 RVA: 0x0000BBB0 File Offset: 0x00009DB0
		// (set) Token: 0x06000154 RID: 340 RVA: 0x000028C8 File Offset: 0x00000AC8
		public unsafe static string Sha256Oid
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ServiceAccountCredential.NativeFieldInfoPtr_Sha256Oid, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServiceAccountCredential.NativeFieldInfoPtr_Sha256Oid, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000155 RID: 341 RVA: 0x0000BBD0 File Offset: 0x00009DD0
		// (set) Token: 0x06000156 RID: 342 RVA: 0x000028DA File Offset: 0x00000ADA
		public unsafe static DateTime UnixEpoch
		{
			get
			{
				DateTime dateTime;
				IL2CPP.il2cpp_field_static_get_value(ServiceAccountCredential.NativeFieldInfoPtr_UnixEpoch, (void*)(&dateTime));
				return dateTime;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServiceAccountCredential.NativeFieldInfoPtr_UnixEpoch, (void*)(&value));
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000157 RID: 343 RVA: 0x0000BBEC File Offset: 0x00009DEC
		// (set) Token: 0x06000158 RID: 344 RVA: 0x000028E8 File Offset: 0x00000AE8
		public unsafe string id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential.NativeFieldInfoPtr_id);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000159 RID: 345 RVA: 0x0000BC14 File Offset: 0x00009E14
		// (set) Token: 0x0600015A RID: 346 RVA: 0x00002907 File Offset: 0x00000B07
		public unsafe string user
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential.NativeFieldInfoPtr_user);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential.NativeFieldInfoPtr_user), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600015B RID: 347 RVA: 0x0000BC3C File Offset: 0x00009E3C
		// (set) Token: 0x0600015C RID: 348 RVA: 0x00002926 File Offset: 0x00000B26
		public unsafe IEnumerable<string> scopes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential.NativeFieldInfoPtr_scopes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential.NativeFieldInfoPtr_scopes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600015D RID: 349 RVA: 0x0000BC6C File Offset: 0x00009E6C
		// (set) Token: 0x0600015E RID: 350 RVA: 0x00002945 File Offset: 0x00000B45
		public unsafe RSACryptoServiceProvider key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential.NativeFieldInfoPtr_key);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RSACryptoServiceProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential.NativeFieldInfoPtr_key), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600015F RID: 351 RVA: 0x0000BC9C File Offset: 0x00009E9C
		// (set) Token: 0x06000160 RID: 352 RVA: 0x00002964 File Offset: 0x00000B64
		public unsafe string _ProjectId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential.NativeFieldInfoPtr__ProjectId_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential.NativeFieldInfoPtr__ProjectId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000161 RID: 353 RVA: 0x0000BCC4 File Offset: 0x00009EC4
		// (set) Token: 0x06000162 RID: 354 RVA: 0x00002983 File Offset: 0x00000B83
		public unsafe static TimeSpan JwtLifetime
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(ServiceAccountCredential.NativeFieldInfoPtr_JwtLifetime, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServiceAccountCredential.NativeFieldInfoPtr_JwtLifetime, (void*)(&value));
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000163 RID: 355 RVA: 0x0000BCE0 File Offset: 0x00009EE0
		// (set) Token: 0x06000164 RID: 356 RVA: 0x00002991 File Offset: 0x00000B91
		public unsafe static TimeSpan JwtCacheExpiryWindow
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(ServiceAccountCredential.NativeFieldInfoPtr_JwtCacheExpiryWindow, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServiceAccountCredential.NativeFieldInfoPtr_JwtCacheExpiryWindow, (void*)(&value));
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000165 RID: 357 RVA: 0x0000BCFC File Offset: 0x00009EFC
		// (set) Token: 0x06000166 RID: 358 RVA: 0x0000299F File Offset: 0x00000B9F
		public unsafe static int JwtCacheMaxSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ServiceAccountCredential.NativeFieldInfoPtr_JwtCacheMaxSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServiceAccountCredential.NativeFieldInfoPtr_JwtCacheMaxSize, (void*)(&value));
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000167 RID: 359 RVA: 0x0000BD18 File Offset: 0x00009F18
		// (set) Token: 0x06000168 RID: 360 RVA: 0x000029AD File Offset: 0x00000BAD
		public unsafe Object _jwtLock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential.NativeFieldInfoPtr__jwtLock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential.NativeFieldInfoPtr__jwtLock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000169 RID: 361 RVA: 0x0000BD48 File Offset: 0x00009F48
		// (set) Token: 0x0600016A RID: 362 RVA: 0x000029CC File Offset: 0x00000BCC
		public unsafe LinkedList<ServiceAccountCredential.JwtCacheEntry> _jwts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential.NativeFieldInfoPtr__jwts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedList<ServiceAccountCredential.JwtCacheEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential.NativeFieldInfoPtr__jwts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600016B RID: 363 RVA: 0x0000BD78 File Offset: 0x00009F78
		// (set) Token: 0x0600016C RID: 364 RVA: 0x000029EB File Offset: 0x00000BEB
		public unsafe Dictionary<string, LinkedListNode<ServiceAccountCredential.JwtCacheEntry>> _jwtCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential.NativeFieldInfoPtr__jwtCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, LinkedListNode<ServiceAccountCredential.JwtCacheEntry>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential.NativeFieldInfoPtr__jwtCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeFieldInfoPtr_Sha256Oid;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeFieldInfoPtr_UnixEpoch;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeFieldInfoPtr_user;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeFieldInfoPtr_scopes;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeFieldInfoPtr__ProjectId_k__BackingField;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeFieldInfoPtr_JwtLifetime;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeFieldInfoPtr_JwtCacheExpiryWindow;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeFieldInfoPtr_JwtCacheMaxSize;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeFieldInfoPtr__jwtLock;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeFieldInfoPtr__jwts;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeFieldInfoPtr__jwtCache;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_String_0;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr_get_ProjectId_Public_get_String_0;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr_set_ProjectId_Private_set_Void_String_0;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeMethodInfoPtr_get_User_Public_get_String_0;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeMethodInfoPtr_get_Scopes_Public_get_IEnumerable_1_String_0;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_get_RSACryptoServiceProvider_0;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeMethodInfoPtr_get_HasScopes_Internal_get_Boolean_0;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Initializer_0;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr_FromServiceAccountData_Public_Static_ServiceAccountCredential_Stream_0;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeMethodInfoPtr_RequestAccessTokenAsync_Public_Virtual_Task_1_Boolean_CancellationToken_0;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr_GetAccessTokenForRequestAsync_Public_Virtual_Task_1_String_String_CancellationToken_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_GetOrCreateJwtAccessTokenAsync_Private_Task_1_String_String_0;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_CreateJwtAccessToken_Private_String_String_DateTime_DateTime_0;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr_CreateAssertionFromPayload_Private_String_Payload_0;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr_CreateSignature_Public_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr_CreateSerializedHeader_Private_Static_String_0;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr_CreatePayload_Private_Payload_0;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeMethodInfoPtr_UrlSafeBase64Encode_Private_String_String_0;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeMethodInfoPtr_UrlSafeBase64Encode_Private_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeMethodInfoPtr_UrlSafeEncode_Private_String_String_0;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeMethodInfoPtr___n__0_Private_Task_1_String_String_CancellationToken_0;

		// Token: 0x02000053 RID: 83
		public new class Initializer : ServiceCredential.Initializer
		{
			// Token: 0x0600051D RID: 1309 RVA: 0x000179C0 File Offset: 0x00015BC0
			// Note: this type is marked as 'beforefieldinit'.
			static Initializer()
			{
				Il2CppClassPointerStore<ServiceAccountCredential.Initializer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServiceAccountCredential>.NativeClassPtr, "Initializer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServiceAccountCredential.Initializer>.NativeClassPtr);
				ServiceAccountCredential.Initializer.NativeFieldInfoPtr__Id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceAccountCredential.Initializer>.NativeClassPtr, "<Id>k__BackingField");
				ServiceAccountCredential.Initializer.NativeFieldInfoPtr__ProjectId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceAccountCredential.Initializer>.NativeClassPtr, "<ProjectId>k__BackingField");
				ServiceAccountCredential.Initializer.NativeFieldInfoPtr__User_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceAccountCredential.Initializer>.NativeClassPtr, "<User>k__BackingField");
				ServiceAccountCredential.Initializer.NativeFieldInfoPtr__Scopes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceAccountCredential.Initializer>.NativeClassPtr, "<Scopes>k__BackingField");
				ServiceAccountCredential.Initializer.NativeFieldInfoPtr__Key_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceAccountCredential.Initializer>.NativeClassPtr, "<Key>k__BackingField");
				ServiceAccountCredential.Initializer.NativeMethodInfoPtr_get_Id_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential.Initializer>.NativeClassPtr, 100663630);
				ServiceAccountCredential.Initializer.NativeMethodInfoPtr_set_Id_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential.Initializer>.NativeClassPtr, 100663631);
				ServiceAccountCredential.Initializer.NativeMethodInfoPtr_get_ProjectId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential.Initializer>.NativeClassPtr, 100663632);
				ServiceAccountCredential.Initializer.NativeMethodInfoPtr_set_ProjectId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential.Initializer>.NativeClassPtr, 100663633);
				ServiceAccountCredential.Initializer.NativeMethodInfoPtr_get_User_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential.Initializer>.NativeClassPtr, 100663634);
				ServiceAccountCredential.Initializer.NativeMethodInfoPtr_set_User_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential.Initializer>.NativeClassPtr, 100663635);
				ServiceAccountCredential.Initializer.NativeMethodInfoPtr_get_Scopes_Public_get_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential.Initializer>.NativeClassPtr, 100663636);
				ServiceAccountCredential.Initializer.NativeMethodInfoPtr_set_Scopes_Public_set_Void_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential.Initializer>.NativeClassPtr, 100663637);
				ServiceAccountCredential.Initializer.NativeMethodInfoPtr_get_Key_Public_get_RSACryptoServiceProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential.Initializer>.NativeClassPtr, 100663638);
				ServiceAccountCredential.Initializer.NativeMethodInfoPtr_set_Key_Public_set_Void_RSACryptoServiceProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential.Initializer>.NativeClassPtr, 100663639);
				ServiceAccountCredential.Initializer.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential.Initializer>.NativeClassPtr, 100663640);
				ServiceAccountCredential.Initializer.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential.Initializer>.NativeClassPtr, 100663641);
				ServiceAccountCredential.Initializer.NativeMethodInfoPtr__ctor_Internal_Void_ServiceAccountCredential_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential.Initializer>.NativeClassPtr, 100663642);
				ServiceAccountCredential.Initializer.NativeMethodInfoPtr_FromPrivateKey_Public_Initializer_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential.Initializer>.NativeClassPtr, 100663643);
				ServiceAccountCredential.Initializer.NativeMethodInfoPtr_FromCertificate_Public_Initializer_X509Certificate2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential.Initializer>.NativeClassPtr, 100663644);
			}

			// Token: 0x170001DE RID: 478
			// (get) Token: 0x0600051E RID: 1310 RVA: 0x00017B7C File Offset: 0x00015D7C
			// (set) Token: 0x0600051F RID: 1311 RVA: 0x00017BB4 File Offset: 0x00015DB4
			public unsafe string Id
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential.Initializer.NativeMethodInfoPtr_get_Id_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential.Initializer.NativeMethodInfoPtr_set_Id_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170001DF RID: 479
			// (get) Token: 0x06000520 RID: 1312 RVA: 0x00017BF8 File Offset: 0x00015DF8
			// (set) Token: 0x06000521 RID: 1313 RVA: 0x00017C30 File Offset: 0x00015E30
			public unsafe string ProjectId
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential.Initializer.NativeMethodInfoPtr_get_ProjectId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential.Initializer.NativeMethodInfoPtr_set_ProjectId_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170001E0 RID: 480
			// (get) Token: 0x06000522 RID: 1314 RVA: 0x00017C74 File Offset: 0x00015E74
			// (set) Token: 0x06000523 RID: 1315 RVA: 0x00017CAC File Offset: 0x00015EAC
			public unsafe string User
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential.Initializer.NativeMethodInfoPtr_get_User_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential.Initializer.NativeMethodInfoPtr_set_User_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170001E1 RID: 481
			// (get) Token: 0x06000524 RID: 1316 RVA: 0x00017CF0 File Offset: 0x00015EF0
			// (set) Token: 0x06000525 RID: 1317 RVA: 0x00017D30 File Offset: 0x00015F30
			public unsafe IEnumerable<string> Scopes
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential.Initializer.NativeMethodInfoPtr_get_Scopes_Public_get_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential.Initializer.NativeMethodInfoPtr_set_Scopes_Public_set_Void_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170001E2 RID: 482
			// (get) Token: 0x06000526 RID: 1318 RVA: 0x00017D74 File Offset: 0x00015F74
			// (set) Token: 0x06000527 RID: 1319 RVA: 0x00017DB4 File Offset: 0x00015FB4
			public unsafe RSACryptoServiceProvider Key
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential.Initializer.NativeMethodInfoPtr_get_Key_Public_get_RSACryptoServiceProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<RSACryptoServiceProvider>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential.Initializer.NativeMethodInfoPtr_set_Key_Public_set_Void_RSACryptoServiceProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06000528 RID: 1320 RVA: 0x00017DF8 File Offset: 0x00015FF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155235, XrefRangeEnd = 1155246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Initializer(string id)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServiceAccountCredential.Initializer>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential.Initializer.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000529 RID: 1321 RVA: 0x00017E44 File Offset: 0x00016044
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155246, XrefRangeEnd = 1155255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Initializer(string id, string tokenServerUrl)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServiceAccountCredential.Initializer>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tokenServerUrl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential.Initializer.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600052A RID: 1322 RVA: 0x00017EA4 File Offset: 0x000160A4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1155266, RefRangeEnd = 1155268, XrefRangeStart = 1155255, XrefRangeEnd = 1155266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Initializer(ServiceAccountCredential other)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServiceAccountCredential.Initializer>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential.Initializer.NativeMethodInfoPtr__ctor_Internal_Void_ServiceAccountCredential_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600052B RID: 1323 RVA: 0x00017EF0 File Offset: 0x000160F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155268, XrefRangeEnd = 1155273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ServiceAccountCredential.Initializer FromPrivateKey(string privateKey)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(privateKey);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential.Initializer.NativeMethodInfoPtr_FromPrivateKey_Public_Initializer_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServiceAccountCredential.Initializer>(intPtr3) : null;
				}
			}

			// Token: 0x0600052C RID: 1324 RVA: 0x00017F40 File Offset: 0x00016140
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155273, XrefRangeEnd = 1155282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ServiceAccountCredential.Initializer FromCertificate(X509Certificate2 certificate)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificate);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential.Initializer.NativeMethodInfoPtr_FromCertificate_Public_Initializer_X509Certificate2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServiceAccountCredential.Initializer>(intPtr3) : null;
				}
			}

			// Token: 0x0600052D RID: 1325 RVA: 0x00004C15 File Offset: 0x00002E15
			public Initializer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001D9 RID: 473
			// (get) Token: 0x0600052E RID: 1326 RVA: 0x00017F90 File Offset: 0x00016190
			// (set) Token: 0x0600052F RID: 1327 RVA: 0x00004C1E File Offset: 0x00002E1E
			public unsafe string _Id_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential.Initializer.NativeFieldInfoPtr__Id_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential.Initializer.NativeFieldInfoPtr__Id_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170001DA RID: 474
			// (get) Token: 0x06000530 RID: 1328 RVA: 0x00017FB8 File Offset: 0x000161B8
			// (set) Token: 0x06000531 RID: 1329 RVA: 0x00004C3D File Offset: 0x00002E3D
			public unsafe string _ProjectId_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential.Initializer.NativeFieldInfoPtr__ProjectId_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential.Initializer.NativeFieldInfoPtr__ProjectId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170001DB RID: 475
			// (get) Token: 0x06000532 RID: 1330 RVA: 0x00017FE0 File Offset: 0x000161E0
			// (set) Token: 0x06000533 RID: 1331 RVA: 0x00004C5C File Offset: 0x00002E5C
			public unsafe string _User_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential.Initializer.NativeFieldInfoPtr__User_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential.Initializer.NativeFieldInfoPtr__User_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170001DC RID: 476
			// (get) Token: 0x06000534 RID: 1332 RVA: 0x00018008 File Offset: 0x00016208
			// (set) Token: 0x06000535 RID: 1333 RVA: 0x00004C7B File Offset: 0x00002E7B
			public unsafe IEnumerable<string> _Scopes_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential.Initializer.NativeFieldInfoPtr__Scopes_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential.Initializer.NativeFieldInfoPtr__Scopes_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001DD RID: 477
			// (get) Token: 0x06000536 RID: 1334 RVA: 0x00018038 File Offset: 0x00016238
			// (set) Token: 0x06000537 RID: 1335 RVA: 0x00004C9A File Offset: 0x00002E9A
			public unsafe RSACryptoServiceProvider _Key_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential.Initializer.NativeFieldInfoPtr__Key_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RSACryptoServiceProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential.Initializer.NativeFieldInfoPtr__Key_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000327 RID: 807
			private static readonly IntPtr NativeFieldInfoPtr__Id_k__BackingField;

			// Token: 0x04000328 RID: 808
			private static readonly IntPtr NativeFieldInfoPtr__ProjectId_k__BackingField;

			// Token: 0x04000329 RID: 809
			private static readonly IntPtr NativeFieldInfoPtr__User_k__BackingField;

			// Token: 0x0400032A RID: 810
			private static readonly IntPtr NativeFieldInfoPtr__Scopes_k__BackingField;

			// Token: 0x0400032B RID: 811
			private static readonly IntPtr NativeFieldInfoPtr__Key_k__BackingField;

			// Token: 0x0400032C RID: 812
			private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_String_0;

			// Token: 0x0400032D RID: 813
			private static readonly IntPtr NativeMethodInfoPtr_set_Id_Private_set_Void_String_0;

			// Token: 0x0400032E RID: 814
			private static readonly IntPtr NativeMethodInfoPtr_get_ProjectId_Public_get_String_0;

			// Token: 0x0400032F RID: 815
			private static readonly IntPtr NativeMethodInfoPtr_set_ProjectId_Public_set_Void_String_0;

			// Token: 0x04000330 RID: 816
			private static readonly IntPtr NativeMethodInfoPtr_get_User_Public_get_String_0;

			// Token: 0x04000331 RID: 817
			private static readonly IntPtr NativeMethodInfoPtr_set_User_Public_set_Void_String_0;

			// Token: 0x04000332 RID: 818
			private static readonly IntPtr NativeMethodInfoPtr_get_Scopes_Public_get_IEnumerable_1_String_0;

			// Token: 0x04000333 RID: 819
			private static readonly IntPtr NativeMethodInfoPtr_set_Scopes_Public_set_Void_IEnumerable_1_String_0;

			// Token: 0x04000334 RID: 820
			private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_get_RSACryptoServiceProvider_0;

			// Token: 0x04000335 RID: 821
			private static readonly IntPtr NativeMethodInfoPtr_set_Key_Public_set_Void_RSACryptoServiceProvider_0;

			// Token: 0x04000336 RID: 822
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

			// Token: 0x04000337 RID: 823
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

			// Token: 0x04000338 RID: 824
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ServiceAccountCredential_0;

			// Token: 0x04000339 RID: 825
			private static readonly IntPtr NativeMethodInfoPtr_FromPrivateKey_Public_Initializer_String_0;

			// Token: 0x0400033A RID: 826
			private static readonly IntPtr NativeMethodInfoPtr_FromCertificate_Public_Initializer_X509Certificate2_0;
		}

		// Token: 0x02000054 RID: 84
		public class JwtCacheEntry : Object
		{
			// Token: 0x06000538 RID: 1336 RVA: 0x00018068 File Offset: 0x00016268
			// Note: this type is marked as 'beforefieldinit'.
			static JwtCacheEntry()
			{
				Il2CppClassPointerStore<ServiceAccountCredential.JwtCacheEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServiceAccountCredential>.NativeClassPtr, "JwtCacheEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServiceAccountCredential.JwtCacheEntry>.NativeClassPtr);
				ServiceAccountCredential.JwtCacheEntry.NativeFieldInfoPtr__JwtTask_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceAccountCredential.JwtCacheEntry>.NativeClassPtr, "<JwtTask>k__BackingField");
				ServiceAccountCredential.JwtCacheEntry.NativeFieldInfoPtr__Uri_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceAccountCredential.JwtCacheEntry>.NativeClassPtr, "<Uri>k__BackingField");
				ServiceAccountCredential.JwtCacheEntry.NativeFieldInfoPtr__ExpiryUtc_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceAccountCredential.JwtCacheEntry>.NativeClassPtr, "<ExpiryUtc>k__BackingField");
				ServiceAccountCredential.JwtCacheEntry.NativeMethodInfoPtr__ctor_Public_Void_Task_1_String_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential.JwtCacheEntry>.NativeClassPtr, 100663645);
				ServiceAccountCredential.JwtCacheEntry.NativeMethodInfoPtr_get_JwtTask_Public_get_Task_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential.JwtCacheEntry>.NativeClassPtr, 100663646);
				ServiceAccountCredential.JwtCacheEntry.NativeMethodInfoPtr_get_Uri_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential.JwtCacheEntry>.NativeClassPtr, 100663647);
				ServiceAccountCredential.JwtCacheEntry.NativeMethodInfoPtr_get_ExpiryUtc_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential.JwtCacheEntry>.NativeClassPtr, 100663648);
			}

			// Token: 0x06000539 RID: 1337 RVA: 0x00018120 File Offset: 0x00016320
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155282, XrefRangeEnd = 1155285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe JwtCacheEntry(Task<string> jwtTask, string uri, DateTime expiryUtc)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServiceAccountCredential.JwtCacheEntry>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(jwtTask);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(uri);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expiryUtc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential.JwtCacheEntry.NativeMethodInfoPtr__ctor_Public_Void_Task_1_String_String_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170001E6 RID: 486
			// (get) Token: 0x0600053A RID: 1338 RVA: 0x0001818C File Offset: 0x0001638C
			public unsafe Task<string> JwtTask
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential.JwtCacheEntry.NativeMethodInfoPtr_get_JwtTask_Public_get_Task_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<string>>(intPtr3) : null;
				}
			}

			// Token: 0x170001E7 RID: 487
			// (get) Token: 0x0600053B RID: 1339 RVA: 0x000181CC File Offset: 0x000163CC
			public unsafe string Uri
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential.JwtCacheEntry.NativeMethodInfoPtr_get_Uri_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170001E8 RID: 488
			// (get) Token: 0x0600053C RID: 1340 RVA: 0x00018204 File Offset: 0x00016404
			public unsafe DateTime ExpiryUtc
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential.JwtCacheEntry.NativeMethodInfoPtr_get_ExpiryUtc_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600053D RID: 1341 RVA: 0x00004CB9 File Offset: 0x00002EB9
			public JwtCacheEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001E3 RID: 483
			// (get) Token: 0x0600053E RID: 1342 RVA: 0x00018240 File Offset: 0x00016440
			// (set) Token: 0x0600053F RID: 1343 RVA: 0x00004CC2 File Offset: 0x00002EC2
			public unsafe Task<string> _JwtTask_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential.JwtCacheEntry.NativeFieldInfoPtr__JwtTask_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential.JwtCacheEntry.NativeFieldInfoPtr__JwtTask_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001E4 RID: 484
			// (get) Token: 0x06000540 RID: 1344 RVA: 0x00018270 File Offset: 0x00016470
			// (set) Token: 0x06000541 RID: 1345 RVA: 0x00004CE1 File Offset: 0x00002EE1
			public unsafe string _Uri_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential.JwtCacheEntry.NativeFieldInfoPtr__Uri_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential.JwtCacheEntry.NativeFieldInfoPtr__Uri_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170001E5 RID: 485
			// (get) Token: 0x06000542 RID: 1346 RVA: 0x00018298 File Offset: 0x00016498
			// (set) Token: 0x06000543 RID: 1347 RVA: 0x00004D00 File Offset: 0x00002F00
			public unsafe DateTime _ExpiryUtc_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential.JwtCacheEntry.NativeFieldInfoPtr__ExpiryUtc_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential.JwtCacheEntry.NativeFieldInfoPtr__ExpiryUtc_k__BackingField)) = value;
				}
			}

			// Token: 0x0400033B RID: 827
			private static readonly IntPtr NativeFieldInfoPtr__JwtTask_k__BackingField;

			// Token: 0x0400033C RID: 828
			private static readonly IntPtr NativeFieldInfoPtr__Uri_k__BackingField;

			// Token: 0x0400033D RID: 829
			private static readonly IntPtr NativeFieldInfoPtr__ExpiryUtc_k__BackingField;

			// Token: 0x0400033E RID: 830
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Task_1_String_String_DateTime_0;

			// Token: 0x0400033F RID: 831
			private static readonly IntPtr NativeMethodInfoPtr_get_JwtTask_Public_get_Task_1_String_0;

			// Token: 0x04000340 RID: 832
			private static readonly IntPtr NativeMethodInfoPtr_get_Uri_Public_get_String_0;

			// Token: 0x04000341 RID: 833
			private static readonly IntPtr NativeMethodInfoPtr_get_ExpiryUtc_Public_get_DateTime_0;
		}

		// Token: 0x02000055 RID: 85
		[ObfuscatedName("Google.Apis.Auth.OAuth2.ServiceAccountCredential+<RequestAccessTokenAsync>d__23")]
		public sealed class _RequestAccessTokenAsync_d__23 : ValueType
		{
			// Token: 0x06000544 RID: 1348 RVA: 0x000182C0 File Offset: 0x000164C0
			// Note: this type is marked as 'beforefieldinit'.
			static _RequestAccessTokenAsync_d__23()
			{
				Il2CppClassPointerStore<ServiceAccountCredential._RequestAccessTokenAsync_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServiceAccountCredential>.NativeClassPtr, "<RequestAccessTokenAsync>d__23");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServiceAccountCredential._RequestAccessTokenAsync_d__23>.NativeClassPtr);
				ServiceAccountCredential._RequestAccessTokenAsync_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceAccountCredential._RequestAccessTokenAsync_d__23>.NativeClassPtr, "<>1__state");
				ServiceAccountCredential._RequestAccessTokenAsync_d__23.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceAccountCredential._RequestAccessTokenAsync_d__23>.NativeClassPtr, "<>t__builder");
				ServiceAccountCredential._RequestAccessTokenAsync_d__23.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceAccountCredential._RequestAccessTokenAsync_d__23>.NativeClassPtr, "<>4__this");
				ServiceAccountCredential._RequestAccessTokenAsync_d__23.NativeFieldInfoPtr_taskCancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceAccountCredential._RequestAccessTokenAsync_d__23>.NativeClassPtr, "taskCancellationToken");
				ServiceAccountCredential._RequestAccessTokenAsync_d__23.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceAccountCredential._RequestAccessTokenAsync_d__23>.NativeClassPtr, "<>u__1");
				ServiceAccountCredential._RequestAccessTokenAsync_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential._RequestAccessTokenAsync_d__23>.NativeClassPtr, 100663649);
				ServiceAccountCredential._RequestAccessTokenAsync_d__23.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential._RequestAccessTokenAsync_d__23>.NativeClassPtr, 100663650);
			}

			// Token: 0x06000545 RID: 1349 RVA: 0x00018378 File Offset: 0x00016578
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155285, XrefRangeEnd = 1155345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential._RequestAccessTokenAsync_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000546 RID: 1350 RVA: 0x000183B0 File Offset: 0x000165B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155345, XrefRangeEnd = 1155351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential._RequestAccessTokenAsync_d__23.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000547 RID: 1351 RVA: 0x00004D1B File Offset: 0x00002F1B
			public _RequestAccessTokenAsync_d__23(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000548 RID: 1352 RVA: 0x00004D24 File Offset: 0x00002F24
			public _RequestAccessTokenAsync_d__23()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServiceAccountCredential._RequestAccessTokenAsync_d__23>.NativeClassPtr))
			{
			}

			// Token: 0x170001E9 RID: 489
			// (get) Token: 0x06000549 RID: 1353 RVA: 0x000183F8 File Offset: 0x000165F8
			// (set) Token: 0x0600054A RID: 1354 RVA: 0x00004D36 File Offset: 0x00002F36
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential._RequestAccessTokenAsync_d__23.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential._RequestAccessTokenAsync_d__23.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170001EA RID: 490
			// (get) Token: 0x0600054B RID: 1355 RVA: 0x00018420 File Offset: 0x00016620
			// (set) Token: 0x0600054C RID: 1356 RVA: 0x00004D51 File Offset: 0x00002F51
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential._RequestAccessTokenAsync_d__23.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential._RequestAccessTokenAsync_d__23.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170001EB RID: 491
			// (get) Token: 0x0600054D RID: 1357 RVA: 0x00018450 File Offset: 0x00016650
			// (set) Token: 0x0600054E RID: 1358 RVA: 0x00004D7F File Offset: 0x00002F7F
			public unsafe ServiceAccountCredential __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential._RequestAccessTokenAsync_d__23.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServiceAccountCredential>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential._RequestAccessTokenAsync_d__23.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001EC RID: 492
			// (get) Token: 0x0600054F RID: 1359 RVA: 0x00018480 File Offset: 0x00016680
			// (set) Token: 0x06000550 RID: 1360 RVA: 0x00004D9E File Offset: 0x00002F9E
			public CancellationToken taskCancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential._RequestAccessTokenAsync_d__23.NativeFieldInfoPtr_taskCancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential._RequestAccessTokenAsync_d__23.NativeFieldInfoPtr_taskCancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170001ED RID: 493
			// (get) Token: 0x06000551 RID: 1361 RVA: 0x000184B0 File Offset: 0x000166B0
			// (set) Token: 0x06000552 RID: 1362 RVA: 0x00004DCC File Offset: 0x00002FCC
			public ConfiguredTaskAwaitable<TokenResponse>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential._RequestAccessTokenAsync_d__23.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<TokenResponse>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TokenResponse>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential._RequestAccessTokenAsync_d__23.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TokenResponse>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000342 RID: 834
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000343 RID: 835
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000344 RID: 836
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000345 RID: 837
			private static readonly IntPtr NativeFieldInfoPtr_taskCancellationToken;

			// Token: 0x04000346 RID: 838
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000347 RID: 839
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000348 RID: 840
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000056 RID: 86
		[ObfuscatedName("Google.Apis.Auth.OAuth2.ServiceAccountCredential+<GetAccessTokenForRequestAsync>d__24")]
		public sealed class _GetAccessTokenForRequestAsync_d__24 : ValueType
		{
			// Token: 0x06000553 RID: 1363 RVA: 0x000184E0 File Offset: 0x000166E0
			// Note: this type is marked as 'beforefieldinit'.
			static _GetAccessTokenForRequestAsync_d__24()
			{
				Il2CppClassPointerStore<ServiceAccountCredential._GetAccessTokenForRequestAsync_d__24>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServiceAccountCredential>.NativeClassPtr, "<GetAccessTokenForRequestAsync>d__24");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServiceAccountCredential._GetAccessTokenForRequestAsync_d__24>.NativeClassPtr);
				ServiceAccountCredential._GetAccessTokenForRequestAsync_d__24.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceAccountCredential._GetAccessTokenForRequestAsync_d__24>.NativeClassPtr, "<>1__state");
				ServiceAccountCredential._GetAccessTokenForRequestAsync_d__24.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceAccountCredential._GetAccessTokenForRequestAsync_d__24>.NativeClassPtr, "<>t__builder");
				ServiceAccountCredential._GetAccessTokenForRequestAsync_d__24.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceAccountCredential._GetAccessTokenForRequestAsync_d__24>.NativeClassPtr, "<>4__this");
				ServiceAccountCredential._GetAccessTokenForRequestAsync_d__24.NativeFieldInfoPtr_authUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceAccountCredential._GetAccessTokenForRequestAsync_d__24>.NativeClassPtr, "authUri");
				ServiceAccountCredential._GetAccessTokenForRequestAsync_d__24.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceAccountCredential._GetAccessTokenForRequestAsync_d__24>.NativeClassPtr, "cancellationToken");
				ServiceAccountCredential._GetAccessTokenForRequestAsync_d__24.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceAccountCredential._GetAccessTokenForRequestAsync_d__24>.NativeClassPtr, "<>u__1");
				ServiceAccountCredential._GetAccessTokenForRequestAsync_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential._GetAccessTokenForRequestAsync_d__24>.NativeClassPtr, 100663651);
				ServiceAccountCredential._GetAccessTokenForRequestAsync_d__24.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential._GetAccessTokenForRequestAsync_d__24>.NativeClassPtr, 100663652);
			}

			// Token: 0x06000554 RID: 1364 RVA: 0x000185AC File Offset: 0x000167AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155351, XrefRangeEnd = 1155388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential._GetAccessTokenForRequestAsync_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000555 RID: 1365 RVA: 0x000185E4 File Offset: 0x000167E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155388, XrefRangeEnd = 1155394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential._GetAccessTokenForRequestAsync_d__24.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000556 RID: 1366 RVA: 0x00004DFA File Offset: 0x00002FFA
			public _GetAccessTokenForRequestAsync_d__24(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000557 RID: 1367 RVA: 0x00004E03 File Offset: 0x00003003
			public _GetAccessTokenForRequestAsync_d__24()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServiceAccountCredential._GetAccessTokenForRequestAsync_d__24>.NativeClassPtr))
			{
			}

			// Token: 0x170001EE RID: 494
			// (get) Token: 0x06000558 RID: 1368 RVA: 0x0001862C File Offset: 0x0001682C
			// (set) Token: 0x06000559 RID: 1369 RVA: 0x00004E15 File Offset: 0x00003015
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential._GetAccessTokenForRequestAsync_d__24.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential._GetAccessTokenForRequestAsync_d__24.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170001EF RID: 495
			// (get) Token: 0x0600055A RID: 1370 RVA: 0x00018654 File Offset: 0x00016854
			// (set) Token: 0x0600055B RID: 1371 RVA: 0x00004E30 File Offset: 0x00003030
			public AsyncTaskMethodBuilder<string> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential._GetAccessTokenForRequestAsync_d__24.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<string>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<string>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential._GetAccessTokenForRequestAsync_d__24.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<string>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170001F0 RID: 496
			// (get) Token: 0x0600055C RID: 1372 RVA: 0x00018684 File Offset: 0x00016884
			// (set) Token: 0x0600055D RID: 1373 RVA: 0x00004E5E File Offset: 0x0000305E
			public unsafe ServiceAccountCredential __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential._GetAccessTokenForRequestAsync_d__24.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServiceAccountCredential>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential._GetAccessTokenForRequestAsync_d__24.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001F1 RID: 497
			// (get) Token: 0x0600055E RID: 1374 RVA: 0x000186B4 File Offset: 0x000168B4
			// (set) Token: 0x0600055F RID: 1375 RVA: 0x00004E7D File Offset: 0x0000307D
			public unsafe string authUri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential._GetAccessTokenForRequestAsync_d__24.NativeFieldInfoPtr_authUri);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential._GetAccessTokenForRequestAsync_d__24.NativeFieldInfoPtr_authUri), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170001F2 RID: 498
			// (get) Token: 0x06000560 RID: 1376 RVA: 0x000186DC File Offset: 0x000168DC
			// (set) Token: 0x06000561 RID: 1377 RVA: 0x00004E9C File Offset: 0x0000309C
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential._GetAccessTokenForRequestAsync_d__24.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential._GetAccessTokenForRequestAsync_d__24.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170001F3 RID: 499
			// (get) Token: 0x06000562 RID: 1378 RVA: 0x0001870C File Offset: 0x0001690C
			// (set) Token: 0x06000563 RID: 1379 RVA: 0x00004ECA File Offset: 0x000030CA
			public ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential._GetAccessTokenForRequestAsync_d__24.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential._GetAccessTokenForRequestAsync_d__24.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000349 RID: 841
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400034A RID: 842
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400034B RID: 843
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400034C RID: 844
			private static readonly IntPtr NativeFieldInfoPtr_authUri;

			// Token: 0x0400034D RID: 845
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400034E RID: 846
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400034F RID: 847
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000350 RID: 848
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000057 RID: 87
		[ObfuscatedName("Google.Apis.Auth.OAuth2.ServiceAccountCredential+<>c__DisplayClass32_0")]
		public sealed class __c__DisplayClass32_0 : Object
		{
			// Token: 0x06000564 RID: 1380 RVA: 0x0001873C File Offset: 0x0001693C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass32_0()
			{
				Il2CppClassPointerStore<ServiceAccountCredential.__c__DisplayClass32_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServiceAccountCredential>.NativeClassPtr, "<>c__DisplayClass32_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServiceAccountCredential.__c__DisplayClass32_0>.NativeClassPtr);
				ServiceAccountCredential.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceAccountCredential.__c__DisplayClass32_0>.NativeClassPtr, "<>4__this");
				ServiceAccountCredential.__c__DisplayClass32_0.NativeFieldInfoPtr_authUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceAccountCredential.__c__DisplayClass32_0>.NativeClassPtr, "authUri");
				ServiceAccountCredential.__c__DisplayClass32_0.NativeFieldInfoPtr_nowUtc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceAccountCredential.__c__DisplayClass32_0>.NativeClassPtr, "nowUtc");
				ServiceAccountCredential.__c__DisplayClass32_0.NativeFieldInfoPtr_expiryUtc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceAccountCredential.__c__DisplayClass32_0>.NativeClassPtr, "expiryUtc");
				ServiceAccountCredential.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential.__c__DisplayClass32_0>.NativeClassPtr, 100663653);
				ServiceAccountCredential.__c__DisplayClass32_0.NativeMethodInfoPtr__GetOrCreateJwtAccessTokenAsync_b__0_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceAccountCredential.__c__DisplayClass32_0>.NativeClassPtr, 100663654);
			}

			// Token: 0x06000565 RID: 1381 RVA: 0x000187E0 File Offset: 0x000169E0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass32_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServiceAccountCredential.__c__DisplayClass32_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000566 RID: 1382 RVA: 0x0001881C File Offset: 0x00016A1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155394, XrefRangeEnd = 1155395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetOrCreateJwtAccessTokenAsync_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceAccountCredential.__c__DisplayClass32_0.NativeMethodInfoPtr__GetOrCreateJwtAccessTokenAsync_b__0_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06000567 RID: 1383 RVA: 0x00004EF8 File Offset: 0x000030F8
			public __c__DisplayClass32_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001F4 RID: 500
			// (get) Token: 0x06000568 RID: 1384 RVA: 0x00018854 File Offset: 0x00016A54
			// (set) Token: 0x06000569 RID: 1385 RVA: 0x00004F01 File Offset: 0x00003101
			public unsafe ServiceAccountCredential __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServiceAccountCredential>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001F5 RID: 501
			// (get) Token: 0x0600056A RID: 1386 RVA: 0x00018884 File Offset: 0x00016A84
			// (set) Token: 0x0600056B RID: 1387 RVA: 0x00004F20 File Offset: 0x00003120
			public unsafe string authUri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential.__c__DisplayClass32_0.NativeFieldInfoPtr_authUri);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential.__c__DisplayClass32_0.NativeFieldInfoPtr_authUri), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170001F6 RID: 502
			// (get) Token: 0x0600056C RID: 1388 RVA: 0x000188AC File Offset: 0x00016AAC
			// (set) Token: 0x0600056D RID: 1389 RVA: 0x00004F3F File Offset: 0x0000313F
			public unsafe DateTime nowUtc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential.__c__DisplayClass32_0.NativeFieldInfoPtr_nowUtc);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential.__c__DisplayClass32_0.NativeFieldInfoPtr_nowUtc)) = value;
				}
			}

			// Token: 0x170001F7 RID: 503
			// (get) Token: 0x0600056E RID: 1390 RVA: 0x000188D4 File Offset: 0x00016AD4
			// (set) Token: 0x0600056F RID: 1391 RVA: 0x00004F5A File Offset: 0x0000315A
			public unsafe DateTime expiryUtc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential.__c__DisplayClass32_0.NativeFieldInfoPtr_expiryUtc);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceAccountCredential.__c__DisplayClass32_0.NativeFieldInfoPtr_expiryUtc)) = value;
				}
			}

			// Token: 0x04000351 RID: 849
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000352 RID: 850
			private static readonly IntPtr NativeFieldInfoPtr_authUri;

			// Token: 0x04000353 RID: 851
			private static readonly IntPtr NativeFieldInfoPtr_nowUtc;

			// Token: 0x04000354 RID: 852
			private static readonly IntPtr NativeFieldInfoPtr_expiryUtc;

			// Token: 0x04000355 RID: 853
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000356 RID: 854
			private static readonly IntPtr NativeMethodInfoPtr__GetOrCreateJwtAccessTokenAsync_b__0_Internal_String_0;
		}
	}
}
