using System;
using Google.Apis.Util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Net.Http;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Security.Cryptography;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Google.Apis.Auth
{
	// Token: 0x02000003 RID: 3
	public class GoogleJsonWebSignature : Object
	{
		// Token: 0x0600000D RID: 13 RVA: 0x000076D4 File Offset: 0x000058D4
		// Note: this type is marked as 'beforefieldinit'.
		static GoogleJsonWebSignature()
		{
			Il2CppClassPointerStore<GoogleJsonWebSignature>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth", "GoogleJsonWebSignature");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleJsonWebSignature>.NativeClassPtr);
			GoogleJsonWebSignature.NativeFieldInfoPtr_MaxJwtLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature>.NativeClassPtr, "MaxJwtLength");
			GoogleJsonWebSignature.NativeFieldInfoPtr_CertCacheRefreshInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature>.NativeClassPtr, "CertCacheRefreshInterval");
			GoogleJsonWebSignature.NativeFieldInfoPtr_Sha256Oid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature>.NativeClassPtr, "Sha256Oid");
			GoogleJsonWebSignature.NativeFieldInfoPtr_SupportedJwtAlgorithm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature>.NativeClassPtr, "SupportedJwtAlgorithm");
			GoogleJsonWebSignature.NativeFieldInfoPtr_ValidJwtIssuers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature>.NativeClassPtr, "ValidJwtIssuers");
			GoogleJsonWebSignature.NativeFieldInfoPtr_UnixEpoch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature>.NativeClassPtr, "UnixEpoch");
			GoogleJsonWebSignature.NativeFieldInfoPtr__certCacheLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature>.NativeClassPtr, "_certCacheLock");
			GoogleJsonWebSignature.NativeFieldInfoPtr__certCacheDownloadTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature>.NativeClassPtr, "_certCacheDownloadTime");
			GoogleJsonWebSignature.NativeFieldInfoPtr__certCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature>.NativeClassPtr, "_certCache");
			GoogleJsonWebSignature.NativeMethodInfoPtr_ValidateAsync_Public_Static_Task_1_Payload_String_IClock_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature>.NativeClassPtr, 100663303);
			GoogleJsonWebSignature.NativeMethodInfoPtr_ValidateAsync_Public_Static_Task_1_Payload_String_ValidationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature>.NativeClassPtr, 100663304);
			GoogleJsonWebSignature.NativeMethodInfoPtr_ValidateInternalAsync_Internal_Static_Task_1_Payload_String_ValidationSettings_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature>.NativeClassPtr, 100663305);
			GoogleJsonWebSignature.NativeMethodInfoPtr_Base64UrlToString_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature>.NativeClassPtr, 100663306);
			GoogleJsonWebSignature.NativeMethodInfoPtr_Base64UrlDecode_Private_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature>.NativeClassPtr, 100663307);
			GoogleJsonWebSignature.NativeMethodInfoPtr_GetGoogleCertsAsync_Internal_Static_Task_1_List_1_RSA_IClock_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature>.NativeClassPtr, 100663308);
			GoogleJsonWebSignature.NativeMethodInfoPtr_GetGoogleCertsFromJson_Private_Static_List_1_RSA_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature>.NativeClassPtr, 100663309);
			GoogleJsonWebSignature.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature>.NativeClassPtr, 100663310);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00007858 File Offset: 0x00005A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1152536, XrefRangeEnd = 1152568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<GoogleJsonWebSignature.Payload> ValidateAsync(string jwt, IClock clock = null, bool forceGoogleCertRefresh = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(jwt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clock);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceGoogleCertRefresh;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.NativeMethodInfoPtr_ValidateAsync_Public_Static_Task_1_Payload_String_IClock_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<GoogleJsonWebSignature.Payload>>(intPtr3) : null;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000078BC File Offset: 0x00005ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1152568, XrefRangeEnd = 1152587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<GoogleJsonWebSignature.Payload> ValidateAsync(string jwt, GoogleJsonWebSignature.ValidationSettings validationSettings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(jwt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(validationSettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.NativeMethodInfoPtr_ValidateAsync_Public_Static_Task_1_Payload_String_ValidationSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<GoogleJsonWebSignature.Payload>>(intPtr3) : null;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00007914 File Offset: 0x00005B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1152587, XrefRangeEnd = 1152603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<GoogleJsonWebSignature.Payload> ValidateInternalAsync(string jwt, GoogleJsonWebSignature.ValidationSettings validationSettings, string certsJson, bool ignoreCertCheck)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(jwt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(validationSettings);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(certsJson);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCertCheck;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.NativeMethodInfoPtr_ValidateInternalAsync_Internal_Static_Task_1_Payload_String_ValidationSettings_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<GoogleJsonWebSignature.Payload>>(intPtr3) : null;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000798C File Offset: 0x00005B8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1152609, RefRangeEnd = 1152611, XrefRangeStart = 1152603, XrefRangeEnd = 1152609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Base64UrlToString(string base64Url)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(base64Url);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.NativeMethodInfoPtr_Base64UrlToString_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000079C8 File Offset: 0x00005BC8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1152624, RefRangeEnd = 1152628, XrefRangeStart = 1152611, XrefRangeEnd = 1152624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> Base64UrlDecode(string base64Url)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(base64Url);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.NativeMethodInfoPtr_Base64UrlDecode_Private_Static_Il2CppStructArray_1_Byte_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00007A0C File Offset: 0x00005C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1152628, XrefRangeEnd = 1152643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<List<RSA>> GetGoogleCertsAsync(IClock clock, bool forceGoogleCertRefresh, string certsJson)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clock);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceGoogleCertRefresh;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(certsJson);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.NativeMethodInfoPtr_GetGoogleCertsAsync_Internal_Static_Task_1_List_1_RSA_IClock_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<List<RSA>>>(intPtr3) : null;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00007A70 File Offset: 0x00005C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1152643, XrefRangeEnd = 1152674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<RSA> GetGoogleCertsFromJson(string json)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.NativeMethodInfoPtr_GetGoogleCertsFromJson_Private_Static_List_1_RSA_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<RSA>>(intPtr3) : null;
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00007AB4 File Offset: 0x00005CB4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GoogleJsonWebSignature()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleJsonWebSignature>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002059 File Offset: 0x00000259
		public GoogleJsonWebSignature(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00007AF0 File Offset: 0x00005CF0
		// (set) Token: 0x06000018 RID: 24 RVA: 0x00002062 File Offset: 0x00000262
		public unsafe static int MaxJwtLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GoogleJsonWebSignature.NativeFieldInfoPtr_MaxJwtLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GoogleJsonWebSignature.NativeFieldInfoPtr_MaxJwtLength, (void*)(&value));
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00007B0C File Offset: 0x00005D0C
		// (set) Token: 0x0600001A RID: 26 RVA: 0x00002070 File Offset: 0x00000270
		public unsafe static TimeSpan CertCacheRefreshInterval
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(GoogleJsonWebSignature.NativeFieldInfoPtr_CertCacheRefreshInterval, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GoogleJsonWebSignature.NativeFieldInfoPtr_CertCacheRefreshInterval, (void*)(&value));
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00007B28 File Offset: 0x00005D28
		// (set) Token: 0x0600001C RID: 28 RVA: 0x0000207E File Offset: 0x0000027E
		public unsafe static string Sha256Oid
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GoogleJsonWebSignature.NativeFieldInfoPtr_Sha256Oid, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GoogleJsonWebSignature.NativeFieldInfoPtr_Sha256Oid, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00007B48 File Offset: 0x00005D48
		// (set) Token: 0x0600001E RID: 30 RVA: 0x00002090 File Offset: 0x00000290
		public unsafe static string SupportedJwtAlgorithm
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GoogleJsonWebSignature.NativeFieldInfoPtr_SupportedJwtAlgorithm, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GoogleJsonWebSignature.NativeFieldInfoPtr_SupportedJwtAlgorithm, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00007B68 File Offset: 0x00005D68
		// (set) Token: 0x06000020 RID: 32 RVA: 0x000020A2 File Offset: 0x000002A2
		public unsafe static IEnumerable<string> ValidJwtIssuers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GoogleJsonWebSignature.NativeFieldInfoPtr_ValidJwtIssuers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GoogleJsonWebSignature.NativeFieldInfoPtr_ValidJwtIssuers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00007B90 File Offset: 0x00005D90
		// (set) Token: 0x06000022 RID: 34 RVA: 0x000020B4 File Offset: 0x000002B4
		public unsafe static DateTime UnixEpoch
		{
			get
			{
				DateTime dateTime;
				IL2CPP.il2cpp_field_static_get_value(GoogleJsonWebSignature.NativeFieldInfoPtr_UnixEpoch, (void*)(&dateTime));
				return dateTime;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GoogleJsonWebSignature.NativeFieldInfoPtr_UnixEpoch, (void*)(&value));
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00007BAC File Offset: 0x00005DAC
		// (set) Token: 0x06000024 RID: 36 RVA: 0x000020C2 File Offset: 0x000002C2
		public unsafe static SemaphoreSlim _certCacheLock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GoogleJsonWebSignature.NativeFieldInfoPtr__certCacheLock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GoogleJsonWebSignature.NativeFieldInfoPtr__certCacheLock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00007BD4 File Offset: 0x00005DD4
		// (set) Token: 0x06000026 RID: 38 RVA: 0x000020D4 File Offset: 0x000002D4
		public unsafe static DateTime _certCacheDownloadTime
		{
			get
			{
				DateTime dateTime;
				IL2CPP.il2cpp_field_static_get_value(GoogleJsonWebSignature.NativeFieldInfoPtr__certCacheDownloadTime, (void*)(&dateTime));
				return dateTime;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GoogleJsonWebSignature.NativeFieldInfoPtr__certCacheDownloadTime, (void*)(&value));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00007BF0 File Offset: 0x00005DF0
		// (set) Token: 0x06000028 RID: 40 RVA: 0x000020E2 File Offset: 0x000002E2
		public unsafe static List<RSA> _certCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GoogleJsonWebSignature.NativeFieldInfoPtr__certCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RSA>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GoogleJsonWebSignature.NativeFieldInfoPtr__certCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeFieldInfoPtr_MaxJwtLength;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeFieldInfoPtr_CertCacheRefreshInterval;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeFieldInfoPtr_Sha256Oid;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeFieldInfoPtr_SupportedJwtAlgorithm;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeFieldInfoPtr_ValidJwtIssuers;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeFieldInfoPtr_UnixEpoch;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeFieldInfoPtr__certCacheLock;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeFieldInfoPtr__certCacheDownloadTime;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeFieldInfoPtr__certCache;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_ValidateAsync_Public_Static_Task_1_Payload_String_IClock_Boolean_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_ValidateAsync_Public_Static_Task_1_Payload_String_ValidationSettings_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_ValidateInternalAsync_Internal_Static_Task_1_Payload_String_ValidationSettings_String_Boolean_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_Base64UrlToString_Private_Static_String_String_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_Base64UrlDecode_Private_Static_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_GetGoogleCertsAsync_Internal_Static_Task_1_List_1_RSA_IClock_Boolean_String_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_GetGoogleCertsFromJson_Private_Static_List_1_RSA_String_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000032 RID: 50
		public sealed class ValidationSettings : Object
		{
			// Token: 0x060002FE RID: 766 RVA: 0x00011B70 File Offset: 0x0000FD70
			// Note: this type is marked as 'beforefieldinit'.
			static ValidationSettings()
			{
				Il2CppClassPointerStore<GoogleJsonWebSignature.ValidationSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GoogleJsonWebSignature>.NativeClassPtr, "ValidationSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleJsonWebSignature.ValidationSettings>.NativeClassPtr);
				GoogleJsonWebSignature.ValidationSettings.NativeFieldInfoPtr__Audience_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature.ValidationSettings>.NativeClassPtr, "<Audience>k__BackingField");
				GoogleJsonWebSignature.ValidationSettings.NativeFieldInfoPtr__HostedDomain_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature.ValidationSettings>.NativeClassPtr, "<HostedDomain>k__BackingField");
				GoogleJsonWebSignature.ValidationSettings.NativeFieldInfoPtr__Clock_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature.ValidationSettings>.NativeClassPtr, "<Clock>k__BackingField");
				GoogleJsonWebSignature.ValidationSettings.NativeFieldInfoPtr__ForceGoogleCertRefresh_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature.ValidationSettings>.NativeClassPtr, "<ForceGoogleCertRefresh>k__BackingField");
				GoogleJsonWebSignature.ValidationSettings.NativeFieldInfoPtr__IssuedAtClockTolerance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature.ValidationSettings>.NativeClassPtr, "<IssuedAtClockTolerance>k__BackingField");
				GoogleJsonWebSignature.ValidationSettings.NativeFieldInfoPtr__ExpirationTimeClockTolerance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature.ValidationSettings>.NativeClassPtr, "<ExpirationTimeClockTolerance>k__BackingField");
				GoogleJsonWebSignature.ValidationSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature.ValidationSettings>.NativeClassPtr, 100663312);
				GoogleJsonWebSignature.ValidationSettings.NativeMethodInfoPtr__ctor_Private_Void_ValidationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature.ValidationSettings>.NativeClassPtr, 100663313);
				GoogleJsonWebSignature.ValidationSettings.NativeMethodInfoPtr_get_Audience_Public_get_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature.ValidationSettings>.NativeClassPtr, 100663314);
				GoogleJsonWebSignature.ValidationSettings.NativeMethodInfoPtr_set_Audience_Public_set_Void_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature.ValidationSettings>.NativeClassPtr, 100663315);
				GoogleJsonWebSignature.ValidationSettings.NativeMethodInfoPtr_get_HostedDomain_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature.ValidationSettings>.NativeClassPtr, 100663316);
				GoogleJsonWebSignature.ValidationSettings.NativeMethodInfoPtr_set_HostedDomain_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature.ValidationSettings>.NativeClassPtr, 100663317);
				GoogleJsonWebSignature.ValidationSettings.NativeMethodInfoPtr_get_Clock_Public_get_IClock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature.ValidationSettings>.NativeClassPtr, 100663318);
				GoogleJsonWebSignature.ValidationSettings.NativeMethodInfoPtr_set_Clock_Public_set_Void_IClock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature.ValidationSettings>.NativeClassPtr, 100663319);
				GoogleJsonWebSignature.ValidationSettings.NativeMethodInfoPtr_get_ForceGoogleCertRefresh_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature.ValidationSettings>.NativeClassPtr, 100663320);
				GoogleJsonWebSignature.ValidationSettings.NativeMethodInfoPtr_set_ForceGoogleCertRefresh_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature.ValidationSettings>.NativeClassPtr, 100663321);
				GoogleJsonWebSignature.ValidationSettings.NativeMethodInfoPtr_get_IssuedAtClockTolerance_Public_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature.ValidationSettings>.NativeClassPtr, 100663322);
				GoogleJsonWebSignature.ValidationSettings.NativeMethodInfoPtr_set_IssuedAtClockTolerance_Public_set_Void_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature.ValidationSettings>.NativeClassPtr, 100663323);
				GoogleJsonWebSignature.ValidationSettings.NativeMethodInfoPtr_get_ExpirationTimeClockTolerance_Public_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature.ValidationSettings>.NativeClassPtr, 100663324);
				GoogleJsonWebSignature.ValidationSettings.NativeMethodInfoPtr_set_ExpirationTimeClockTolerance_Public_set_Void_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature.ValidationSettings>.NativeClassPtr, 100663325);
				GoogleJsonWebSignature.ValidationSettings.NativeMethodInfoPtr_Clone_Internal_ValidationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature.ValidationSettings>.NativeClassPtr, 100663326);
			}

			// Token: 0x060002FF RID: 767 RVA: 0x00011D40 File Offset: 0x0000FF40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1152185, XrefRangeEnd = 1152191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValidationSettings()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleJsonWebSignature.ValidationSettings>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.ValidationSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000300 RID: 768 RVA: 0x00011D7C File Offset: 0x0000FF7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1152191, XrefRangeEnd = 1152204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValidationSettings(GoogleJsonWebSignature.ValidationSettings other)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleJsonWebSignature.ValidationSettings>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.ValidationSettings.NativeMethodInfoPtr__ctor_Private_Void_ValidationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000119 RID: 281
			// (get) Token: 0x06000301 RID: 769 RVA: 0x00011DC8 File Offset: 0x0000FFC8
			// (set) Token: 0x06000302 RID: 770 RVA: 0x00011E08 File Offset: 0x00010008
			public unsafe IEnumerable<string> Audience
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.ValidationSettings.NativeMethodInfoPtr_get_Audience_Public_get_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
				}
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.ValidationSettings.NativeMethodInfoPtr_set_Audience_Public_set_Void_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700011A RID: 282
			// (get) Token: 0x06000303 RID: 771 RVA: 0x00011E4C File Offset: 0x0001004C
			// (set) Token: 0x06000304 RID: 772 RVA: 0x00011E84 File Offset: 0x00010084
			public unsafe string HostedDomain
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.ValidationSettings.NativeMethodInfoPtr_get_HostedDomain_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.ValidationSettings.NativeMethodInfoPtr_set_HostedDomain_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700011B RID: 283
			// (get) Token: 0x06000305 RID: 773 RVA: 0x00011EC8 File Offset: 0x000100C8
			// (set) Token: 0x06000306 RID: 774 RVA: 0x00011F08 File Offset: 0x00010108
			public unsafe IClock Clock
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.ValidationSettings.NativeMethodInfoPtr_get_Clock_Public_get_IClock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IClock>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.ValidationSettings.NativeMethodInfoPtr_set_Clock_Public_set_Void_IClock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700011C RID: 284
			// (get) Token: 0x06000307 RID: 775 RVA: 0x00011F4C File Offset: 0x0001014C
			// (set) Token: 0x06000308 RID: 776 RVA: 0x00011F88 File Offset: 0x00010188
			public unsafe bool ForceGoogleCertRefresh
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.ValidationSettings.NativeMethodInfoPtr_get_ForceGoogleCertRefresh_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(19)]
				[CachedScanResults(RefRangeStart = 287297, RefRangeEnd = 287316, XrefRangeStart = 287297, XrefRangeEnd = 287316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.ValidationSettings.NativeMethodInfoPtr_set_ForceGoogleCertRefresh_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700011D RID: 285
			// (get) Token: 0x06000309 RID: 777 RVA: 0x00011FC8 File Offset: 0x000101C8
			// (set) Token: 0x0600030A RID: 778 RVA: 0x00012004 File Offset: 0x00010204
			public unsafe TimeSpan IssuedAtClockTolerance
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.ValidationSettings.NativeMethodInfoPtr_get_IssuedAtClockTolerance_Public_get_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.ValidationSettings.NativeMethodInfoPtr_set_IssuedAtClockTolerance_Public_set_Void_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700011E RID: 286
			// (get) Token: 0x0600030B RID: 779 RVA: 0x00012044 File Offset: 0x00010244
			// (set) Token: 0x0600030C RID: 780 RVA: 0x00012080 File Offset: 0x00010280
			public unsafe TimeSpan ExpirationTimeClockTolerance
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.ValidationSettings.NativeMethodInfoPtr_get_ExpirationTimeClockTolerance_Public_get_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.ValidationSettings.NativeMethodInfoPtr_set_ExpirationTimeClockTolerance_Public_set_Void_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x0600030D RID: 781 RVA: 0x000120C0 File Offset: 0x000102C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1152204, XrefRangeEnd = 1152220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GoogleJsonWebSignature.ValidationSettings Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.ValidationSettings.NativeMethodInfoPtr_Clone_Internal_ValidationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GoogleJsonWebSignature.ValidationSettings>(intPtr3) : null;
			}

			// Token: 0x0600030E RID: 782 RVA: 0x000034BE File Offset: 0x000016BE
			public ValidationSettings(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000113 RID: 275
			// (get) Token: 0x0600030F RID: 783 RVA: 0x00012100 File Offset: 0x00010300
			// (set) Token: 0x06000310 RID: 784 RVA: 0x000034C7 File Offset: 0x000016C7
			public unsafe IEnumerable<string> _Audience_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature.ValidationSettings.NativeFieldInfoPtr__Audience_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature.ValidationSettings.NativeFieldInfoPtr__Audience_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000114 RID: 276
			// (get) Token: 0x06000311 RID: 785 RVA: 0x00012130 File Offset: 0x00010330
			// (set) Token: 0x06000312 RID: 786 RVA: 0x000034E6 File Offset: 0x000016E6
			public unsafe string _HostedDomain_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature.ValidationSettings.NativeFieldInfoPtr__HostedDomain_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature.ValidationSettings.NativeFieldInfoPtr__HostedDomain_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000115 RID: 277
			// (get) Token: 0x06000313 RID: 787 RVA: 0x00012158 File Offset: 0x00010358
			// (set) Token: 0x06000314 RID: 788 RVA: 0x00003505 File Offset: 0x00001705
			public unsafe IClock _Clock_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature.ValidationSettings.NativeFieldInfoPtr__Clock_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IClock>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature.ValidationSettings.NativeFieldInfoPtr__Clock_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000116 RID: 278
			// (get) Token: 0x06000315 RID: 789 RVA: 0x00012188 File Offset: 0x00010388
			// (set) Token: 0x06000316 RID: 790 RVA: 0x00003524 File Offset: 0x00001724
			public unsafe bool _ForceGoogleCertRefresh_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature.ValidationSettings.NativeFieldInfoPtr__ForceGoogleCertRefresh_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature.ValidationSettings.NativeFieldInfoPtr__ForceGoogleCertRefresh_k__BackingField)) = value;
				}
			}

			// Token: 0x17000117 RID: 279
			// (get) Token: 0x06000317 RID: 791 RVA: 0x000121B0 File Offset: 0x000103B0
			// (set) Token: 0x06000318 RID: 792 RVA: 0x0000353F File Offset: 0x0000173F
			public unsafe TimeSpan _IssuedAtClockTolerance_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature.ValidationSettings.NativeFieldInfoPtr__IssuedAtClockTolerance_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature.ValidationSettings.NativeFieldInfoPtr__IssuedAtClockTolerance_k__BackingField)) = value;
				}
			}

			// Token: 0x17000118 RID: 280
			// (get) Token: 0x06000319 RID: 793 RVA: 0x000121D8 File Offset: 0x000103D8
			// (set) Token: 0x0600031A RID: 794 RVA: 0x0000355A File Offset: 0x0000175A
			public unsafe TimeSpan _ExpirationTimeClockTolerance_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature.ValidationSettings.NativeFieldInfoPtr__ExpirationTimeClockTolerance_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature.ValidationSettings.NativeFieldInfoPtr__ExpirationTimeClockTolerance_k__BackingField)) = value;
				}
			}

			// Token: 0x040001F5 RID: 501
			private static readonly IntPtr NativeFieldInfoPtr__Audience_k__BackingField;

			// Token: 0x040001F6 RID: 502
			private static readonly IntPtr NativeFieldInfoPtr__HostedDomain_k__BackingField;

			// Token: 0x040001F7 RID: 503
			private static readonly IntPtr NativeFieldInfoPtr__Clock_k__BackingField;

			// Token: 0x040001F8 RID: 504
			private static readonly IntPtr NativeFieldInfoPtr__ForceGoogleCertRefresh_k__BackingField;

			// Token: 0x040001F9 RID: 505
			private static readonly IntPtr NativeFieldInfoPtr__IssuedAtClockTolerance_k__BackingField;

			// Token: 0x040001FA RID: 506
			private static readonly IntPtr NativeFieldInfoPtr__ExpirationTimeClockTolerance_k__BackingField;

			// Token: 0x040001FB RID: 507
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040001FC RID: 508
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_ValidationSettings_0;

			// Token: 0x040001FD RID: 509
			private static readonly IntPtr NativeMethodInfoPtr_get_Audience_Public_get_IEnumerable_1_String_0;

			// Token: 0x040001FE RID: 510
			private static readonly IntPtr NativeMethodInfoPtr_set_Audience_Public_set_Void_IEnumerable_1_String_0;

			// Token: 0x040001FF RID: 511
			private static readonly IntPtr NativeMethodInfoPtr_get_HostedDomain_Public_get_String_0;

			// Token: 0x04000200 RID: 512
			private static readonly IntPtr NativeMethodInfoPtr_set_HostedDomain_Public_set_Void_String_0;

			// Token: 0x04000201 RID: 513
			private static readonly IntPtr NativeMethodInfoPtr_get_Clock_Public_get_IClock_0;

			// Token: 0x04000202 RID: 514
			private static readonly IntPtr NativeMethodInfoPtr_set_Clock_Public_set_Void_IClock_0;

			// Token: 0x04000203 RID: 515
			private static readonly IntPtr NativeMethodInfoPtr_get_ForceGoogleCertRefresh_Public_get_Boolean_0;

			// Token: 0x04000204 RID: 516
			private static readonly IntPtr NativeMethodInfoPtr_set_ForceGoogleCertRefresh_Public_set_Void_Boolean_0;

			// Token: 0x04000205 RID: 517
			private static readonly IntPtr NativeMethodInfoPtr_get_IssuedAtClockTolerance_Public_get_TimeSpan_0;

			// Token: 0x04000206 RID: 518
			private static readonly IntPtr NativeMethodInfoPtr_set_IssuedAtClockTolerance_Public_set_Void_TimeSpan_0;

			// Token: 0x04000207 RID: 519
			private static readonly IntPtr NativeMethodInfoPtr_get_ExpirationTimeClockTolerance_Public_get_TimeSpan_0;

			// Token: 0x04000208 RID: 520
			private static readonly IntPtr NativeMethodInfoPtr_set_ExpirationTimeClockTolerance_Public_set_Void_TimeSpan_0;

			// Token: 0x04000209 RID: 521
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Internal_ValidationSettings_0;
		}

		// Token: 0x02000033 RID: 51
		public class Header : JsonWebSignature.Header
		{
			// Token: 0x0600031B RID: 795 RVA: 0x00003575 File Offset: 0x00001775
			// Note: this type is marked as 'beforefieldinit'.
			static Header()
			{
				Il2CppClassPointerStore<GoogleJsonWebSignature.Header>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GoogleJsonWebSignature>.NativeClassPtr, "Header");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleJsonWebSignature.Header>.NativeClassPtr);
				GoogleJsonWebSignature.Header.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature.Header>.NativeClassPtr, 100663327);
			}

			// Token: 0x0600031C RID: 796 RVA: 0x00012200 File Offset: 0x00010400
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Header()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleJsonWebSignature.Header>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.Header.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600031D RID: 797 RVA: 0x000035A9 File Offset: 0x000017A9
			public Header(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400020A RID: 522
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000034 RID: 52
		public class Payload : JsonWebSignature.Payload
		{
			// Token: 0x0600031E RID: 798 RVA: 0x0001223C File Offset: 0x0001043C
			// Note: this type is marked as 'beforefieldinit'.
			static Payload()
			{
				Il2CppClassPointerStore<GoogleJsonWebSignature.Payload>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GoogleJsonWebSignature>.NativeClassPtr, "Payload");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleJsonWebSignature.Payload>.NativeClassPtr);
				GoogleJsonWebSignature.Payload.NativeFieldInfoPtr__Scope_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature.Payload>.NativeClassPtr, "<Scope>k__BackingField");
				GoogleJsonWebSignature.Payload.NativeFieldInfoPtr__Prn_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature.Payload>.NativeClassPtr, "<Prn>k__BackingField");
				GoogleJsonWebSignature.Payload.NativeFieldInfoPtr__HostedDomain_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature.Payload>.NativeClassPtr, "<HostedDomain>k__BackingField");
				GoogleJsonWebSignature.Payload.NativeFieldInfoPtr__Email_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature.Payload>.NativeClassPtr, "<Email>k__BackingField");
				GoogleJsonWebSignature.Payload.NativeFieldInfoPtr__EmailVerified_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature.Payload>.NativeClassPtr, "<EmailVerified>k__BackingField");
				GoogleJsonWebSignature.Payload.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature.Payload>.NativeClassPtr, "<Name>k__BackingField");
				GoogleJsonWebSignature.Payload.NativeFieldInfoPtr__GivenName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature.Payload>.NativeClassPtr, "<GivenName>k__BackingField");
				GoogleJsonWebSignature.Payload.NativeFieldInfoPtr__FamilyName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature.Payload>.NativeClassPtr, "<FamilyName>k__BackingField");
				GoogleJsonWebSignature.Payload.NativeFieldInfoPtr__Picture_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature.Payload>.NativeClassPtr, "<Picture>k__BackingField");
				GoogleJsonWebSignature.Payload.NativeFieldInfoPtr__Locale_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature.Payload>.NativeClassPtr, "<Locale>k__BackingField");
				GoogleJsonWebSignature.Payload.NativeMethodInfoPtr_get_Scope_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature.Payload>.NativeClassPtr, 100663328);
				GoogleJsonWebSignature.Payload.NativeMethodInfoPtr_set_Scope_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature.Payload>.NativeClassPtr, 100663329);
				GoogleJsonWebSignature.Payload.NativeMethodInfoPtr_get_Prn_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature.Payload>.NativeClassPtr, 100663330);
				GoogleJsonWebSignature.Payload.NativeMethodInfoPtr_set_Prn_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature.Payload>.NativeClassPtr, 100663331);
				GoogleJsonWebSignature.Payload.NativeMethodInfoPtr_get_HostedDomain_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature.Payload>.NativeClassPtr, 100663332);
				GoogleJsonWebSignature.Payload.NativeMethodInfoPtr_set_HostedDomain_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature.Payload>.NativeClassPtr, 100663333);
				GoogleJsonWebSignature.Payload.NativeMethodInfoPtr_get_Email_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature.Payload>.NativeClassPtr, 100663334);
				GoogleJsonWebSignature.Payload.NativeMethodInfoPtr_set_Email_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature.Payload>.NativeClassPtr, 100663335);
				GoogleJsonWebSignature.Payload.NativeMethodInfoPtr_get_EmailVerified_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature.Payload>.NativeClassPtr, 100663336);
				GoogleJsonWebSignature.Payload.NativeMethodInfoPtr_set_EmailVerified_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature.Payload>.NativeClassPtr, 100663337);
				GoogleJsonWebSignature.Payload.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature.Payload>.NativeClassPtr, 100663338);
				GoogleJsonWebSignature.Payload.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature.Payload>.NativeClassPtr, 100663339);
				GoogleJsonWebSignature.Payload.NativeMethodInfoPtr_get_GivenName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature.Payload>.NativeClassPtr, 100663340);
				GoogleJsonWebSignature.Payload.NativeMethodInfoPtr_set_GivenName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature.Payload>.NativeClassPtr, 100663341);
				GoogleJsonWebSignature.Payload.NativeMethodInfoPtr_get_FamilyName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature.Payload>.NativeClassPtr, 100663342);
				GoogleJsonWebSignature.Payload.NativeMethodInfoPtr_set_FamilyName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature.Payload>.NativeClassPtr, 100663343);
				GoogleJsonWebSignature.Payload.NativeMethodInfoPtr_get_Picture_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature.Payload>.NativeClassPtr, 100663344);
				GoogleJsonWebSignature.Payload.NativeMethodInfoPtr_set_Picture_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature.Payload>.NativeClassPtr, 100663345);
				GoogleJsonWebSignature.Payload.NativeMethodInfoPtr_get_Locale_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature.Payload>.NativeClassPtr, 100663346);
				GoogleJsonWebSignature.Payload.NativeMethodInfoPtr_set_Locale_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature.Payload>.NativeClassPtr, 100663347);
				GoogleJsonWebSignature.Payload.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature.Payload>.NativeClassPtr, 100663348);
			}

			// Token: 0x17000129 RID: 297
			// (get) Token: 0x0600031F RID: 799 RVA: 0x000124D4 File Offset: 0x000106D4
			// (set) Token: 0x06000320 RID: 800 RVA: 0x0001250C File Offset: 0x0001070C
			public unsafe string Scope
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.Payload.NativeMethodInfoPtr_get_Scope_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.Payload.NativeMethodInfoPtr_set_Scope_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700012A RID: 298
			// (get) Token: 0x06000321 RID: 801 RVA: 0x00012550 File Offset: 0x00010750
			// (set) Token: 0x06000322 RID: 802 RVA: 0x00012588 File Offset: 0x00010788
			public unsafe string Prn
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.Payload.NativeMethodInfoPtr_get_Prn_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.Payload.NativeMethodInfoPtr_set_Prn_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700012B RID: 299
			// (get) Token: 0x06000323 RID: 803 RVA: 0x000125CC File Offset: 0x000107CC
			// (set) Token: 0x06000324 RID: 804 RVA: 0x00012604 File Offset: 0x00010804
			public unsafe string HostedDomain
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.Payload.NativeMethodInfoPtr_get_HostedDomain_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.Payload.NativeMethodInfoPtr_set_HostedDomain_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700012C RID: 300
			// (get) Token: 0x06000325 RID: 805 RVA: 0x00012648 File Offset: 0x00010848
			// (set) Token: 0x06000326 RID: 806 RVA: 0x00012680 File Offset: 0x00010880
			public unsafe string Email
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.Payload.NativeMethodInfoPtr_get_Email_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.Payload.NativeMethodInfoPtr_set_Email_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700012D RID: 301
			// (get) Token: 0x06000327 RID: 807 RVA: 0x000126C4 File Offset: 0x000108C4
			// (set) Token: 0x06000328 RID: 808 RVA: 0x00012700 File Offset: 0x00010900
			public unsafe bool EmailVerified
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.Payload.NativeMethodInfoPtr_get_EmailVerified_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.Payload.NativeMethodInfoPtr_set_EmailVerified_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700012E RID: 302
			// (get) Token: 0x06000329 RID: 809 RVA: 0x00012740 File Offset: 0x00010940
			// (set) Token: 0x0600032A RID: 810 RVA: 0x00012778 File Offset: 0x00010978
			public unsafe string Name
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.Payload.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.Payload.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700012F RID: 303
			// (get) Token: 0x0600032B RID: 811 RVA: 0x000127BC File Offset: 0x000109BC
			// (set) Token: 0x0600032C RID: 812 RVA: 0x000127F4 File Offset: 0x000109F4
			public unsafe string GivenName
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.Payload.NativeMethodInfoPtr_get_GivenName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.Payload.NativeMethodInfoPtr_set_GivenName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000130 RID: 304
			// (get) Token: 0x0600032D RID: 813 RVA: 0x00012838 File Offset: 0x00010A38
			// (set) Token: 0x0600032E RID: 814 RVA: 0x00012870 File Offset: 0x00010A70
			public unsafe string FamilyName
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.Payload.NativeMethodInfoPtr_get_FamilyName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.Payload.NativeMethodInfoPtr_set_FamilyName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000131 RID: 305
			// (get) Token: 0x0600032F RID: 815 RVA: 0x000128B4 File Offset: 0x00010AB4
			// (set) Token: 0x06000330 RID: 816 RVA: 0x000128EC File Offset: 0x00010AEC
			public unsafe string Picture
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.Payload.NativeMethodInfoPtr_get_Picture_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.Payload.NativeMethodInfoPtr_set_Picture_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000132 RID: 306
			// (get) Token: 0x06000331 RID: 817 RVA: 0x00012930 File Offset: 0x00010B30
			// (set) Token: 0x06000332 RID: 818 RVA: 0x00012968 File Offset: 0x00010B68
			public unsafe string Locale
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.Payload.NativeMethodInfoPtr_get_Locale_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.Payload.NativeMethodInfoPtr_set_Locale_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06000333 RID: 819 RVA: 0x000129AC File Offset: 0x00010BAC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Payload()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleJsonWebSignature.Payload>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.Payload.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000334 RID: 820 RVA: 0x000035B2 File Offset: 0x000017B2
			public Payload(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700011F RID: 287
			// (get) Token: 0x06000335 RID: 821 RVA: 0x000129E8 File Offset: 0x00010BE8
			// (set) Token: 0x06000336 RID: 822 RVA: 0x000035BB File Offset: 0x000017BB
			public unsafe string _Scope_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature.Payload.NativeFieldInfoPtr__Scope_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature.Payload.NativeFieldInfoPtr__Scope_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000120 RID: 288
			// (get) Token: 0x06000337 RID: 823 RVA: 0x00012A10 File Offset: 0x00010C10
			// (set) Token: 0x06000338 RID: 824 RVA: 0x000035DA File Offset: 0x000017DA
			public unsafe string _Prn_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature.Payload.NativeFieldInfoPtr__Prn_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature.Payload.NativeFieldInfoPtr__Prn_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000121 RID: 289
			// (get) Token: 0x06000339 RID: 825 RVA: 0x00012A38 File Offset: 0x00010C38
			// (set) Token: 0x0600033A RID: 826 RVA: 0x000035F9 File Offset: 0x000017F9
			public unsafe string _HostedDomain_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature.Payload.NativeFieldInfoPtr__HostedDomain_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature.Payload.NativeFieldInfoPtr__HostedDomain_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000122 RID: 290
			// (get) Token: 0x0600033B RID: 827 RVA: 0x00012A60 File Offset: 0x00010C60
			// (set) Token: 0x0600033C RID: 828 RVA: 0x00003618 File Offset: 0x00001818
			public unsafe string _Email_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature.Payload.NativeFieldInfoPtr__Email_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature.Payload.NativeFieldInfoPtr__Email_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000123 RID: 291
			// (get) Token: 0x0600033D RID: 829 RVA: 0x00012A88 File Offset: 0x00010C88
			// (set) Token: 0x0600033E RID: 830 RVA: 0x00003637 File Offset: 0x00001837
			public unsafe bool _EmailVerified_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature.Payload.NativeFieldInfoPtr__EmailVerified_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature.Payload.NativeFieldInfoPtr__EmailVerified_k__BackingField)) = value;
				}
			}

			// Token: 0x17000124 RID: 292
			// (get) Token: 0x0600033F RID: 831 RVA: 0x00012AB0 File Offset: 0x00010CB0
			// (set) Token: 0x06000340 RID: 832 RVA: 0x00003652 File Offset: 0x00001852
			public unsafe string _Name_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature.Payload.NativeFieldInfoPtr__Name_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature.Payload.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000125 RID: 293
			// (get) Token: 0x06000341 RID: 833 RVA: 0x00012AD8 File Offset: 0x00010CD8
			// (set) Token: 0x06000342 RID: 834 RVA: 0x00003671 File Offset: 0x00001871
			public unsafe string _GivenName_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature.Payload.NativeFieldInfoPtr__GivenName_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature.Payload.NativeFieldInfoPtr__GivenName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000126 RID: 294
			// (get) Token: 0x06000343 RID: 835 RVA: 0x00012B00 File Offset: 0x00010D00
			// (set) Token: 0x06000344 RID: 836 RVA: 0x00003690 File Offset: 0x00001890
			public unsafe string _FamilyName_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature.Payload.NativeFieldInfoPtr__FamilyName_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature.Payload.NativeFieldInfoPtr__FamilyName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000127 RID: 295
			// (get) Token: 0x06000345 RID: 837 RVA: 0x00012B28 File Offset: 0x00010D28
			// (set) Token: 0x06000346 RID: 838 RVA: 0x000036AF File Offset: 0x000018AF
			public unsafe string _Picture_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature.Payload.NativeFieldInfoPtr__Picture_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature.Payload.NativeFieldInfoPtr__Picture_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000128 RID: 296
			// (get) Token: 0x06000347 RID: 839 RVA: 0x00012B50 File Offset: 0x00010D50
			// (set) Token: 0x06000348 RID: 840 RVA: 0x000036CE File Offset: 0x000018CE
			public unsafe string _Locale_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature.Payload.NativeFieldInfoPtr__Locale_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature.Payload.NativeFieldInfoPtr__Locale_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400020B RID: 523
			private static readonly IntPtr NativeFieldInfoPtr__Scope_k__BackingField;

			// Token: 0x0400020C RID: 524
			private static readonly IntPtr NativeFieldInfoPtr__Prn_k__BackingField;

			// Token: 0x0400020D RID: 525
			private static readonly IntPtr NativeFieldInfoPtr__HostedDomain_k__BackingField;

			// Token: 0x0400020E RID: 526
			private static readonly IntPtr NativeFieldInfoPtr__Email_k__BackingField;

			// Token: 0x0400020F RID: 527
			private static readonly IntPtr NativeFieldInfoPtr__EmailVerified_k__BackingField;

			// Token: 0x04000210 RID: 528
			private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

			// Token: 0x04000211 RID: 529
			private static readonly IntPtr NativeFieldInfoPtr__GivenName_k__BackingField;

			// Token: 0x04000212 RID: 530
			private static readonly IntPtr NativeFieldInfoPtr__FamilyName_k__BackingField;

			// Token: 0x04000213 RID: 531
			private static readonly IntPtr NativeFieldInfoPtr__Picture_k__BackingField;

			// Token: 0x04000214 RID: 532
			private static readonly IntPtr NativeFieldInfoPtr__Locale_k__BackingField;

			// Token: 0x04000215 RID: 533
			private static readonly IntPtr NativeMethodInfoPtr_get_Scope_Public_get_String_0;

			// Token: 0x04000216 RID: 534
			private static readonly IntPtr NativeMethodInfoPtr_set_Scope_Public_set_Void_String_0;

			// Token: 0x04000217 RID: 535
			private static readonly IntPtr NativeMethodInfoPtr_get_Prn_Public_get_String_0;

			// Token: 0x04000218 RID: 536
			private static readonly IntPtr NativeMethodInfoPtr_set_Prn_Public_set_Void_String_0;

			// Token: 0x04000219 RID: 537
			private static readonly IntPtr NativeMethodInfoPtr_get_HostedDomain_Public_get_String_0;

			// Token: 0x0400021A RID: 538
			private static readonly IntPtr NativeMethodInfoPtr_set_HostedDomain_Public_set_Void_String_0;

			// Token: 0x0400021B RID: 539
			private static readonly IntPtr NativeMethodInfoPtr_get_Email_Public_get_String_0;

			// Token: 0x0400021C RID: 540
			private static readonly IntPtr NativeMethodInfoPtr_set_Email_Public_set_Void_String_0;

			// Token: 0x0400021D RID: 541
			private static readonly IntPtr NativeMethodInfoPtr_get_EmailVerified_Public_get_Boolean_0;

			// Token: 0x0400021E RID: 542
			private static readonly IntPtr NativeMethodInfoPtr_set_EmailVerified_Public_set_Void_Boolean_0;

			// Token: 0x0400021F RID: 543
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

			// Token: 0x04000220 RID: 544
			private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

			// Token: 0x04000221 RID: 545
			private static readonly IntPtr NativeMethodInfoPtr_get_GivenName_Public_get_String_0;

			// Token: 0x04000222 RID: 546
			private static readonly IntPtr NativeMethodInfoPtr_set_GivenName_Public_set_Void_String_0;

			// Token: 0x04000223 RID: 547
			private static readonly IntPtr NativeMethodInfoPtr_get_FamilyName_Public_get_String_0;

			// Token: 0x04000224 RID: 548
			private static readonly IntPtr NativeMethodInfoPtr_set_FamilyName_Public_set_Void_String_0;

			// Token: 0x04000225 RID: 549
			private static readonly IntPtr NativeMethodInfoPtr_get_Picture_Public_get_String_0;

			// Token: 0x04000226 RID: 550
			private static readonly IntPtr NativeMethodInfoPtr_set_Picture_Public_set_Void_String_0;

			// Token: 0x04000227 RID: 551
			private static readonly IntPtr NativeMethodInfoPtr_get_Locale_Public_get_String_0;

			// Token: 0x04000228 RID: 552
			private static readonly IntPtr NativeMethodInfoPtr_set_Locale_Public_set_Void_String_0;

			// Token: 0x04000229 RID: 553
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000035 RID: 53
		[ObfuscatedName("Google.Apis.Auth.GoogleJsonWebSignature+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000349 RID: 841 RVA: 0x00012B78 File Offset: 0x00010D78
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GoogleJsonWebSignature.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GoogleJsonWebSignature>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleJsonWebSignature.__c>.NativeClassPtr);
				GoogleJsonWebSignature.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature.__c>.NativeClassPtr, "<>9");
				GoogleJsonWebSignature.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature.__c>.NativeClassPtr, "<>9__9_0");
				GoogleJsonWebSignature.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature.__c>.NativeClassPtr, "<>9__16_0");
				GoogleJsonWebSignature.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature.__c>.NativeClassPtr, 100663350);
				GoogleJsonWebSignature.__c.NativeMethodInfoPtr__ValidateInternalAsync_b__9_0_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature.__c>.NativeClassPtr, 100663351);
				GoogleJsonWebSignature.__c.NativeMethodInfoPtr__GetGoogleCertsFromJson_b__16_0_Internal_RSA_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature.__c>.NativeClassPtr, 100663352);
			}

			// Token: 0x0600034A RID: 842 RVA: 0x00012C1C File Offset: 0x00010E1C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleJsonWebSignature.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600034B RID: 843 RVA: 0x00012C58 File Offset: 0x00010E58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1152220, XrefRangeEnd = 1152223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ValidateInternalAsync_b__9_0(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.__c.NativeMethodInfoPtr__ValidateInternalAsync_b__9_0_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600034C RID: 844 RVA: 0x00012CA0 File Offset: 0x00010EA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1152223, XrefRangeEnd = 1152240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RSA _GetGoogleCertsFromJson_b__16_0(JToken key)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature.__c.NativeMethodInfoPtr__GetGoogleCertsFromJson_b__16_0_Internal_RSA_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<RSA>(intPtr3) : null;
				}
			}

			// Token: 0x0600034D RID: 845 RVA: 0x000036ED File Offset: 0x000018ED
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000133 RID: 307
			// (get) Token: 0x0600034E RID: 846 RVA: 0x00012CF0 File Offset: 0x00010EF0
			// (set) Token: 0x0600034F RID: 847 RVA: 0x000036F6 File Offset: 0x000018F6
			public unsafe static GoogleJsonWebSignature.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GoogleJsonWebSignature.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GoogleJsonWebSignature.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GoogleJsonWebSignature.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000134 RID: 308
			// (get) Token: 0x06000350 RID: 848 RVA: 0x00012D18 File Offset: 0x00010F18
			// (set) Token: 0x06000351 RID: 849 RVA: 0x00003708 File Offset: 0x00001908
			public unsafe static Func<string, string> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GoogleJsonWebSignature.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GoogleJsonWebSignature.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000135 RID: 309
			// (get) Token: 0x06000352 RID: 850 RVA: 0x00012D40 File Offset: 0x00010F40
			// (set) Token: 0x06000353 RID: 851 RVA: 0x0000371A File Offset: 0x0000191A
			public unsafe static Func<JToken, RSA> __9__16_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GoogleJsonWebSignature.__c.NativeFieldInfoPtr___9__16_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<JToken, RSA>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GoogleJsonWebSignature.__c.NativeFieldInfoPtr___9__16_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400022A RID: 554
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400022B RID: 555
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x0400022C RID: 556
			private static readonly IntPtr NativeFieldInfoPtr___9__16_0;

			// Token: 0x0400022D RID: 557
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400022E RID: 558
			private static readonly IntPtr NativeMethodInfoPtr__ValidateInternalAsync_b__9_0_Internal_String_String_0;

			// Token: 0x0400022F RID: 559
			private static readonly IntPtr NativeMethodInfoPtr__GetGoogleCertsFromJson_b__16_0_Internal_RSA_JToken_0;
		}

		// Token: 0x02000036 RID: 54
		[ObfuscatedName("Google.Apis.Auth.GoogleJsonWebSignature+<ValidateInternalAsync>d__9")]
		public sealed class _ValidateInternalAsync_d__9 : ValueType
		{
			// Token: 0x06000354 RID: 852 RVA: 0x00012D68 File Offset: 0x00010F68
			// Note: this type is marked as 'beforefieldinit'.
			static _ValidateInternalAsync_d__9()
			{
				Il2CppClassPointerStore<GoogleJsonWebSignature._ValidateInternalAsync_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GoogleJsonWebSignature>.NativeClassPtr, "<ValidateInternalAsync>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleJsonWebSignature._ValidateInternalAsync_d__9>.NativeClassPtr);
				GoogleJsonWebSignature._ValidateInternalAsync_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature._ValidateInternalAsync_d__9>.NativeClassPtr, "<>1__state");
				GoogleJsonWebSignature._ValidateInternalAsync_d__9.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature._ValidateInternalAsync_d__9>.NativeClassPtr, "<>t__builder");
				GoogleJsonWebSignature._ValidateInternalAsync_d__9.NativeFieldInfoPtr_jwt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature._ValidateInternalAsync_d__9>.NativeClassPtr, "jwt");
				GoogleJsonWebSignature._ValidateInternalAsync_d__9.NativeFieldInfoPtr_validationSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature._ValidateInternalAsync_d__9>.NativeClassPtr, "validationSettings");
				GoogleJsonWebSignature._ValidateInternalAsync_d__9.NativeFieldInfoPtr_ignoreCertCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature._ValidateInternalAsync_d__9>.NativeClassPtr, "ignoreCertCheck");
				GoogleJsonWebSignature._ValidateInternalAsync_d__9.NativeFieldInfoPtr_certsJson = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature._ValidateInternalAsync_d__9>.NativeClassPtr, "certsJson");
				GoogleJsonWebSignature._ValidateInternalAsync_d__9.NativeFieldInfoPtr__settings_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature._ValidateInternalAsync_d__9>.NativeClassPtr, "<settings>5__2");
				GoogleJsonWebSignature._ValidateInternalAsync_d__9.NativeFieldInfoPtr__clock_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature._ValidateInternalAsync_d__9>.NativeClassPtr, "<clock>5__3");
				GoogleJsonWebSignature._ValidateInternalAsync_d__9.NativeFieldInfoPtr__payload_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature._ValidateInternalAsync_d__9>.NativeClassPtr, "<payload>5__4");
				GoogleJsonWebSignature._ValidateInternalAsync_d__9.NativeFieldInfoPtr__signature_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature._ValidateInternalAsync_d__9>.NativeClassPtr, "<signature>5__5");
				GoogleJsonWebSignature._ValidateInternalAsync_d__9.NativeFieldInfoPtr__hash_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature._ValidateInternalAsync_d__9>.NativeClassPtr, "<hash>5__6");
				GoogleJsonWebSignature._ValidateInternalAsync_d__9.NativeFieldInfoPtr__verifiedOk_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature._ValidateInternalAsync_d__9>.NativeClassPtr, "<verifiedOk>5__7");
				GoogleJsonWebSignature._ValidateInternalAsync_d__9.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature._ValidateInternalAsync_d__9>.NativeClassPtr, "<>u__1");
				GoogleJsonWebSignature._ValidateInternalAsync_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature._ValidateInternalAsync_d__9>.NativeClassPtr, 100663353);
				GoogleJsonWebSignature._ValidateInternalAsync_d__9.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature._ValidateInternalAsync_d__9>.NativeClassPtr, 100663354);
			}

			// Token: 0x06000355 RID: 853 RVA: 0x00012EC0 File Offset: 0x000110C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1152240, XrefRangeEnd = 1152422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature._ValidateInternalAsync_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000356 RID: 854 RVA: 0x00012EF8 File Offset: 0x000110F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1152422, XrefRangeEnd = 1152428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature._ValidateInternalAsync_d__9.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000357 RID: 855 RVA: 0x0000372C File Offset: 0x0000192C
			public _ValidateInternalAsync_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000358 RID: 856 RVA: 0x00003735 File Offset: 0x00001935
			public _ValidateInternalAsync_d__9()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleJsonWebSignature._ValidateInternalAsync_d__9>.NativeClassPtr))
			{
			}

			// Token: 0x17000136 RID: 310
			// (get) Token: 0x06000359 RID: 857 RVA: 0x00012F40 File Offset: 0x00011140
			// (set) Token: 0x0600035A RID: 858 RVA: 0x00003747 File Offset: 0x00001947
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._ValidateInternalAsync_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._ValidateInternalAsync_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000137 RID: 311
			// (get) Token: 0x0600035B RID: 859 RVA: 0x00012F68 File Offset: 0x00011168
			// (set) Token: 0x0600035C RID: 860 RVA: 0x00003762 File Offset: 0x00001962
			public AsyncTaskMethodBuilder<GoogleJsonWebSignature.Payload> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._ValidateInternalAsync_d__9.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<GoogleJsonWebSignature.Payload>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<GoogleJsonWebSignature.Payload>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._ValidateInternalAsync_d__9.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<GoogleJsonWebSignature.Payload>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000138 RID: 312
			// (get) Token: 0x0600035D RID: 861 RVA: 0x00012F98 File Offset: 0x00011198
			// (set) Token: 0x0600035E RID: 862 RVA: 0x00003790 File Offset: 0x00001990
			public unsafe string jwt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._ValidateInternalAsync_d__9.NativeFieldInfoPtr_jwt);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._ValidateInternalAsync_d__9.NativeFieldInfoPtr_jwt), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000139 RID: 313
			// (get) Token: 0x0600035F RID: 863 RVA: 0x00012FC0 File Offset: 0x000111C0
			// (set) Token: 0x06000360 RID: 864 RVA: 0x000037AF File Offset: 0x000019AF
			public unsafe GoogleJsonWebSignature.ValidationSettings validationSettings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._ValidateInternalAsync_d__9.NativeFieldInfoPtr_validationSettings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GoogleJsonWebSignature.ValidationSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._ValidateInternalAsync_d__9.NativeFieldInfoPtr_validationSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700013A RID: 314
			// (get) Token: 0x06000361 RID: 865 RVA: 0x00012FF0 File Offset: 0x000111F0
			// (set) Token: 0x06000362 RID: 866 RVA: 0x000037CE File Offset: 0x000019CE
			public unsafe bool ignoreCertCheck
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._ValidateInternalAsync_d__9.NativeFieldInfoPtr_ignoreCertCheck);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._ValidateInternalAsync_d__9.NativeFieldInfoPtr_ignoreCertCheck)) = value;
				}
			}

			// Token: 0x1700013B RID: 315
			// (get) Token: 0x06000363 RID: 867 RVA: 0x00013018 File Offset: 0x00011218
			// (set) Token: 0x06000364 RID: 868 RVA: 0x000037E9 File Offset: 0x000019E9
			public unsafe string certsJson
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._ValidateInternalAsync_d__9.NativeFieldInfoPtr_certsJson);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._ValidateInternalAsync_d__9.NativeFieldInfoPtr_certsJson), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700013C RID: 316
			// (get) Token: 0x06000365 RID: 869 RVA: 0x00013040 File Offset: 0x00011240
			// (set) Token: 0x06000366 RID: 870 RVA: 0x00003808 File Offset: 0x00001A08
			public unsafe GoogleJsonWebSignature.ValidationSettings _settings_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._ValidateInternalAsync_d__9.NativeFieldInfoPtr__settings_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GoogleJsonWebSignature.ValidationSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._ValidateInternalAsync_d__9.NativeFieldInfoPtr__settings_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700013D RID: 317
			// (get) Token: 0x06000367 RID: 871 RVA: 0x00013070 File Offset: 0x00011270
			// (set) Token: 0x06000368 RID: 872 RVA: 0x00003827 File Offset: 0x00001A27
			public unsafe IClock _clock_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._ValidateInternalAsync_d__9.NativeFieldInfoPtr__clock_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IClock>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._ValidateInternalAsync_d__9.NativeFieldInfoPtr__clock_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700013E RID: 318
			// (get) Token: 0x06000369 RID: 873 RVA: 0x000130A0 File Offset: 0x000112A0
			// (set) Token: 0x0600036A RID: 874 RVA: 0x00003846 File Offset: 0x00001A46
			public unsafe GoogleJsonWebSignature.Payload _payload_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._ValidateInternalAsync_d__9.NativeFieldInfoPtr__payload_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GoogleJsonWebSignature.Payload>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._ValidateInternalAsync_d__9.NativeFieldInfoPtr__payload_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700013F RID: 319
			// (get) Token: 0x0600036B RID: 875 RVA: 0x000130D0 File Offset: 0x000112D0
			// (set) Token: 0x0600036C RID: 876 RVA: 0x00003865 File Offset: 0x00001A65
			public unsafe Il2CppStructArray<byte> _signature_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._ValidateInternalAsync_d__9.NativeFieldInfoPtr__signature_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._ValidateInternalAsync_d__9.NativeFieldInfoPtr__signature_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000140 RID: 320
			// (get) Token: 0x0600036D RID: 877 RVA: 0x00013100 File Offset: 0x00011300
			// (set) Token: 0x0600036E RID: 878 RVA: 0x00003884 File Offset: 0x00001A84
			public unsafe Il2CppStructArray<byte> _hash_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._ValidateInternalAsync_d__9.NativeFieldInfoPtr__hash_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._ValidateInternalAsync_d__9.NativeFieldInfoPtr__hash_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000141 RID: 321
			// (get) Token: 0x0600036F RID: 879 RVA: 0x00013130 File Offset: 0x00011330
			// (set) Token: 0x06000370 RID: 880 RVA: 0x000038A3 File Offset: 0x00001AA3
			public unsafe bool _verifiedOk_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._ValidateInternalAsync_d__9.NativeFieldInfoPtr__verifiedOk_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._ValidateInternalAsync_d__9.NativeFieldInfoPtr__verifiedOk_5__7)) = value;
				}
			}

			// Token: 0x17000142 RID: 322
			// (get) Token: 0x06000371 RID: 881 RVA: 0x00013158 File Offset: 0x00011358
			// (set) Token: 0x06000372 RID: 882 RVA: 0x000038BE File Offset: 0x00001ABE
			public ConfiguredTaskAwaitable<List<RSA>>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._ValidateInternalAsync_d__9.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<List<RSA>>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<List<RSA>>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._ValidateInternalAsync_d__9.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<List<RSA>>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000230 RID: 560
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000231 RID: 561
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000232 RID: 562
			private static readonly IntPtr NativeFieldInfoPtr_jwt;

			// Token: 0x04000233 RID: 563
			private static readonly IntPtr NativeFieldInfoPtr_validationSettings;

			// Token: 0x04000234 RID: 564
			private static readonly IntPtr NativeFieldInfoPtr_ignoreCertCheck;

			// Token: 0x04000235 RID: 565
			private static readonly IntPtr NativeFieldInfoPtr_certsJson;

			// Token: 0x04000236 RID: 566
			private static readonly IntPtr NativeFieldInfoPtr__settings_5__2;

			// Token: 0x04000237 RID: 567
			private static readonly IntPtr NativeFieldInfoPtr__clock_5__3;

			// Token: 0x04000238 RID: 568
			private static readonly IntPtr NativeFieldInfoPtr__payload_5__4;

			// Token: 0x04000239 RID: 569
			private static readonly IntPtr NativeFieldInfoPtr__signature_5__5;

			// Token: 0x0400023A RID: 570
			private static readonly IntPtr NativeFieldInfoPtr__hash_5__6;

			// Token: 0x0400023B RID: 571
			private static readonly IntPtr NativeFieldInfoPtr__verifiedOk_5__7;

			// Token: 0x0400023C RID: 572
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400023D RID: 573
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400023E RID: 574
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000037 RID: 55
		[ObfuscatedName("Google.Apis.Auth.GoogleJsonWebSignature+<GetGoogleCertsAsync>d__15")]
		public sealed class _GetGoogleCertsAsync_d__15 : ValueType
		{
			// Token: 0x06000373 RID: 883 RVA: 0x00013188 File Offset: 0x00011388
			// Note: this type is marked as 'beforefieldinit'.
			static _GetGoogleCertsAsync_d__15()
			{
				Il2CppClassPointerStore<GoogleJsonWebSignature._GetGoogleCertsAsync_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GoogleJsonWebSignature>.NativeClassPtr, "<GetGoogleCertsAsync>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleJsonWebSignature._GetGoogleCertsAsync_d__15>.NativeClassPtr);
				GoogleJsonWebSignature._GetGoogleCertsAsync_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature._GetGoogleCertsAsync_d__15>.NativeClassPtr, "<>1__state");
				GoogleJsonWebSignature._GetGoogleCertsAsync_d__15.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature._GetGoogleCertsAsync_d__15>.NativeClassPtr, "<>t__builder");
				GoogleJsonWebSignature._GetGoogleCertsAsync_d__15.NativeFieldInfoPtr_clock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature._GetGoogleCertsAsync_d__15>.NativeClassPtr, "clock");
				GoogleJsonWebSignature._GetGoogleCertsAsync_d__15.NativeFieldInfoPtr_forceGoogleCertRefresh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature._GetGoogleCertsAsync_d__15>.NativeClassPtr, "forceGoogleCertRefresh");
				GoogleJsonWebSignature._GetGoogleCertsAsync_d__15.NativeFieldInfoPtr_certsJson = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature._GetGoogleCertsAsync_d__15>.NativeClassPtr, "certsJson");
				GoogleJsonWebSignature._GetGoogleCertsAsync_d__15.NativeFieldInfoPtr__now_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature._GetGoogleCertsAsync_d__15>.NativeClassPtr, "<now>5__2");
				GoogleJsonWebSignature._GetGoogleCertsAsync_d__15.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature._GetGoogleCertsAsync_d__15>.NativeClassPtr, "<>u__1");
				GoogleJsonWebSignature._GetGoogleCertsAsync_d__15.NativeFieldInfoPtr__httpClient_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature._GetGoogleCertsAsync_d__15>.NativeClassPtr, "<httpClient>5__3");
				GoogleJsonWebSignature._GetGoogleCertsAsync_d__15.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleJsonWebSignature._GetGoogleCertsAsync_d__15>.NativeClassPtr, "<>u__2");
				GoogleJsonWebSignature._GetGoogleCertsAsync_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature._GetGoogleCertsAsync_d__15>.NativeClassPtr, 100663355);
				GoogleJsonWebSignature._GetGoogleCertsAsync_d__15.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleJsonWebSignature._GetGoogleCertsAsync_d__15>.NativeClassPtr, 100663356);
			}

			// Token: 0x06000374 RID: 884 RVA: 0x00013290 File Offset: 0x00011490
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1152428, XrefRangeEnd = 1152530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature._GetGoogleCertsAsync_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000375 RID: 885 RVA: 0x000132C8 File Offset: 0x000114C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1152530, XrefRangeEnd = 1152536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleJsonWebSignature._GetGoogleCertsAsync_d__15.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000376 RID: 886 RVA: 0x000038EC File Offset: 0x00001AEC
			public _GetGoogleCertsAsync_d__15(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000377 RID: 887 RVA: 0x000038F5 File Offset: 0x00001AF5
			public _GetGoogleCertsAsync_d__15()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleJsonWebSignature._GetGoogleCertsAsync_d__15>.NativeClassPtr))
			{
			}

			// Token: 0x17000143 RID: 323
			// (get) Token: 0x06000378 RID: 888 RVA: 0x00013310 File Offset: 0x00011510
			// (set) Token: 0x06000379 RID: 889 RVA: 0x00003907 File Offset: 0x00001B07
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._GetGoogleCertsAsync_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._GetGoogleCertsAsync_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000144 RID: 324
			// (get) Token: 0x0600037A RID: 890 RVA: 0x00013338 File Offset: 0x00011538
			// (set) Token: 0x0600037B RID: 891 RVA: 0x00003922 File Offset: 0x00001B22
			public AsyncTaskMethodBuilder<List<RSA>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._GetGoogleCertsAsync_d__15.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<List<RSA>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<List<RSA>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._GetGoogleCertsAsync_d__15.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<List<RSA>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000145 RID: 325
			// (get) Token: 0x0600037C RID: 892 RVA: 0x00013368 File Offset: 0x00011568
			// (set) Token: 0x0600037D RID: 893 RVA: 0x00003950 File Offset: 0x00001B50
			public unsafe IClock clock
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._GetGoogleCertsAsync_d__15.NativeFieldInfoPtr_clock);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IClock>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._GetGoogleCertsAsync_d__15.NativeFieldInfoPtr_clock), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000146 RID: 326
			// (get) Token: 0x0600037E RID: 894 RVA: 0x00013398 File Offset: 0x00011598
			// (set) Token: 0x0600037F RID: 895 RVA: 0x0000396F File Offset: 0x00001B6F
			public unsafe bool forceGoogleCertRefresh
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._GetGoogleCertsAsync_d__15.NativeFieldInfoPtr_forceGoogleCertRefresh);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._GetGoogleCertsAsync_d__15.NativeFieldInfoPtr_forceGoogleCertRefresh)) = value;
				}
			}

			// Token: 0x17000147 RID: 327
			// (get) Token: 0x06000380 RID: 896 RVA: 0x000133C0 File Offset: 0x000115C0
			// (set) Token: 0x06000381 RID: 897 RVA: 0x0000398A File Offset: 0x00001B8A
			public unsafe string certsJson
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._GetGoogleCertsAsync_d__15.NativeFieldInfoPtr_certsJson);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._GetGoogleCertsAsync_d__15.NativeFieldInfoPtr_certsJson), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000148 RID: 328
			// (get) Token: 0x06000382 RID: 898 RVA: 0x000133E8 File Offset: 0x000115E8
			// (set) Token: 0x06000383 RID: 899 RVA: 0x000039A9 File Offset: 0x00001BA9
			public unsafe DateTime _now_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._GetGoogleCertsAsync_d__15.NativeFieldInfoPtr__now_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._GetGoogleCertsAsync_d__15.NativeFieldInfoPtr__now_5__2)) = value;
				}
			}

			// Token: 0x17000149 RID: 329
			// (get) Token: 0x06000384 RID: 900 RVA: 0x00013410 File Offset: 0x00011610
			// (set) Token: 0x06000385 RID: 901 RVA: 0x000039C4 File Offset: 0x00001BC4
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._GetGoogleCertsAsync_d__15.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._GetGoogleCertsAsync_d__15.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700014A RID: 330
			// (get) Token: 0x06000386 RID: 902 RVA: 0x00013440 File Offset: 0x00011640
			// (set) Token: 0x06000387 RID: 903 RVA: 0x000039F2 File Offset: 0x00001BF2
			public unsafe HttpClient _httpClient_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._GetGoogleCertsAsync_d__15.NativeFieldInfoPtr__httpClient_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpClient>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._GetGoogleCertsAsync_d__15.NativeFieldInfoPtr__httpClient_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700014B RID: 331
			// (get) Token: 0x06000388 RID: 904 RVA: 0x00013470 File Offset: 0x00011670
			// (set) Token: 0x06000389 RID: 905 RVA: 0x00003A11 File Offset: 0x00001C11
			public ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._GetGoogleCertsAsync_d__15.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleJsonWebSignature._GetGoogleCertsAsync_d__15.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400023F RID: 575
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000240 RID: 576
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04000241 RID: 577
			private static readonly IntPtr NativeFieldInfoPtr_clock;

			// Token: 0x04000242 RID: 578
			private static readonly IntPtr NativeFieldInfoPtr_forceGoogleCertRefresh;

			// Token: 0x04000243 RID: 579
			private static readonly IntPtr NativeFieldInfoPtr_certsJson;

			// Token: 0x04000244 RID: 580
			private static readonly IntPtr NativeFieldInfoPtr__now_5__2;

			// Token: 0x04000245 RID: 581
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04000246 RID: 582
			private static readonly IntPtr NativeFieldInfoPtr__httpClient_5__3;

			// Token: 0x04000247 RID: 583
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04000248 RID: 584
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000249 RID: 585
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
