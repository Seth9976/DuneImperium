using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Auth
{
	// Token: 0x02000005 RID: 5
	public class JsonWebSignature : Object
	{
		// Token: 0x0600002C RID: 44 RVA: 0x00002136 File Offset: 0x00000336
		// Note: this type is marked as 'beforefieldinit'.
		static JsonWebSignature()
		{
			Il2CppClassPointerStore<JsonWebSignature>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth", "JsonWebSignature");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonWebSignature>.NativeClassPtr);
			JsonWebSignature.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebSignature>.NativeClassPtr, 100663358);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00007C64 File Offset: 0x00005E64
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonWebSignature()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonWebSignature>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebSignature.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000216F File Offset: 0x0000036F
		public JsonWebSignature(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000038 RID: 56
		public class Header : JsonWebToken.Header
		{
			// Token: 0x0600038A RID: 906 RVA: 0x000134A0 File Offset: 0x000116A0
			// Note: this type is marked as 'beforefieldinit'.
			static Header()
			{
				Il2CppClassPointerStore<JsonWebSignature.Header>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonWebSignature>.NativeClassPtr, "Header");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonWebSignature.Header>.NativeClassPtr);
				JsonWebSignature.Header.NativeFieldInfoPtr__Algorithm_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWebSignature.Header>.NativeClassPtr, "<Algorithm>k__BackingField");
				JsonWebSignature.Header.NativeFieldInfoPtr__JwkUrl_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWebSignature.Header>.NativeClassPtr, "<JwkUrl>k__BackingField");
				JsonWebSignature.Header.NativeFieldInfoPtr__Jwk_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWebSignature.Header>.NativeClassPtr, "<Jwk>k__BackingField");
				JsonWebSignature.Header.NativeFieldInfoPtr__KeyId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWebSignature.Header>.NativeClassPtr, "<KeyId>k__BackingField");
				JsonWebSignature.Header.NativeFieldInfoPtr__X509Url_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWebSignature.Header>.NativeClassPtr, "<X509Url>k__BackingField");
				JsonWebSignature.Header.NativeFieldInfoPtr__X509Thumbprint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWebSignature.Header>.NativeClassPtr, "<X509Thumbprint>k__BackingField");
				JsonWebSignature.Header.NativeFieldInfoPtr__X509Certificate_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWebSignature.Header>.NativeClassPtr, "<X509Certificate>k__BackingField");
				JsonWebSignature.Header.NativeFieldInfoPtr__critical_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWebSignature.Header>.NativeClassPtr, "<critical>k__BackingField");
				JsonWebSignature.Header.NativeMethodInfoPtr_get_Algorithm_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebSignature.Header>.NativeClassPtr, 100663359);
				JsonWebSignature.Header.NativeMethodInfoPtr_set_Algorithm_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebSignature.Header>.NativeClassPtr, 100663360);
				JsonWebSignature.Header.NativeMethodInfoPtr_get_JwkUrl_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebSignature.Header>.NativeClassPtr, 100663361);
				JsonWebSignature.Header.NativeMethodInfoPtr_set_JwkUrl_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebSignature.Header>.NativeClassPtr, 100663362);
				JsonWebSignature.Header.NativeMethodInfoPtr_get_Jwk_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebSignature.Header>.NativeClassPtr, 100663363);
				JsonWebSignature.Header.NativeMethodInfoPtr_set_Jwk_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebSignature.Header>.NativeClassPtr, 100663364);
				JsonWebSignature.Header.NativeMethodInfoPtr_get_KeyId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebSignature.Header>.NativeClassPtr, 100663365);
				JsonWebSignature.Header.NativeMethodInfoPtr_set_KeyId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebSignature.Header>.NativeClassPtr, 100663366);
				JsonWebSignature.Header.NativeMethodInfoPtr_get_X509Url_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebSignature.Header>.NativeClassPtr, 100663367);
				JsonWebSignature.Header.NativeMethodInfoPtr_set_X509Url_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebSignature.Header>.NativeClassPtr, 100663368);
				JsonWebSignature.Header.NativeMethodInfoPtr_get_X509Thumbprint_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebSignature.Header>.NativeClassPtr, 100663369);
				JsonWebSignature.Header.NativeMethodInfoPtr_set_X509Thumbprint_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebSignature.Header>.NativeClassPtr, 100663370);
				JsonWebSignature.Header.NativeMethodInfoPtr_get_X509Certificate_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebSignature.Header>.NativeClassPtr, 100663371);
				JsonWebSignature.Header.NativeMethodInfoPtr_set_X509Certificate_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebSignature.Header>.NativeClassPtr, 100663372);
				JsonWebSignature.Header.NativeMethodInfoPtr_get_critical_Public_get_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebSignature.Header>.NativeClassPtr, 100663373);
				JsonWebSignature.Header.NativeMethodInfoPtr_set_critical_Public_set_Void_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebSignature.Header>.NativeClassPtr, 100663374);
				JsonWebSignature.Header.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebSignature.Header>.NativeClassPtr, 100663375);
			}

			// Token: 0x17000154 RID: 340
			// (get) Token: 0x0600038B RID: 907 RVA: 0x000136C0 File Offset: 0x000118C0
			// (set) Token: 0x0600038C RID: 908 RVA: 0x000136F8 File Offset: 0x000118F8
			public unsafe string Algorithm
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebSignature.Header.NativeMethodInfoPtr_get_Algorithm_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebSignature.Header.NativeMethodInfoPtr_set_Algorithm_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000155 RID: 341
			// (get) Token: 0x0600038D RID: 909 RVA: 0x0001373C File Offset: 0x0001193C
			// (set) Token: 0x0600038E RID: 910 RVA: 0x00013774 File Offset: 0x00011974
			public unsafe string JwkUrl
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebSignature.Header.NativeMethodInfoPtr_get_JwkUrl_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebSignature.Header.NativeMethodInfoPtr_set_JwkUrl_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000156 RID: 342
			// (get) Token: 0x0600038F RID: 911 RVA: 0x000137B8 File Offset: 0x000119B8
			// (set) Token: 0x06000390 RID: 912 RVA: 0x000137F0 File Offset: 0x000119F0
			public unsafe string Jwk
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebSignature.Header.NativeMethodInfoPtr_get_Jwk_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebSignature.Header.NativeMethodInfoPtr_set_Jwk_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000157 RID: 343
			// (get) Token: 0x06000391 RID: 913 RVA: 0x00013834 File Offset: 0x00011A34
			// (set) Token: 0x06000392 RID: 914 RVA: 0x0001386C File Offset: 0x00011A6C
			public unsafe string KeyId
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebSignature.Header.NativeMethodInfoPtr_get_KeyId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebSignature.Header.NativeMethodInfoPtr_set_KeyId_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000158 RID: 344
			// (get) Token: 0x06000393 RID: 915 RVA: 0x000138B0 File Offset: 0x00011AB0
			// (set) Token: 0x06000394 RID: 916 RVA: 0x000138E8 File Offset: 0x00011AE8
			public unsafe string X509Url
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebSignature.Header.NativeMethodInfoPtr_get_X509Url_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebSignature.Header.NativeMethodInfoPtr_set_X509Url_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000159 RID: 345
			// (get) Token: 0x06000395 RID: 917 RVA: 0x0001392C File Offset: 0x00011B2C
			// (set) Token: 0x06000396 RID: 918 RVA: 0x00013964 File Offset: 0x00011B64
			public unsafe string X509Thumbprint
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebSignature.Header.NativeMethodInfoPtr_get_X509Thumbprint_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebSignature.Header.NativeMethodInfoPtr_set_X509Thumbprint_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700015A RID: 346
			// (get) Token: 0x06000397 RID: 919 RVA: 0x000139A8 File Offset: 0x00011BA8
			// (set) Token: 0x06000398 RID: 920 RVA: 0x000139E0 File Offset: 0x00011BE0
			public unsafe string X509Certificate
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebSignature.Header.NativeMethodInfoPtr_get_X509Certificate_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebSignature.Header.NativeMethodInfoPtr_set_X509Certificate_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700015B RID: 347
			// (get) Token: 0x06000399 RID: 921 RVA: 0x00013A24 File Offset: 0x00011C24
			// (set) Token: 0x0600039A RID: 922 RVA: 0x00013A64 File Offset: 0x00011C64
			public unsafe IList<string> critical
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebSignature.Header.NativeMethodInfoPtr_get_critical_Public_get_IList_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<string>>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebSignature.Header.NativeMethodInfoPtr_set_critical_Public_set_Void_IList_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x0600039B RID: 923 RVA: 0x00013AA8 File Offset: 0x00011CA8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Header()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonWebSignature.Header>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebSignature.Header.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600039C RID: 924 RVA: 0x00003A3F File Offset: 0x00001C3F
			public Header(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700014C RID: 332
			// (get) Token: 0x0600039D RID: 925 RVA: 0x00013AE4 File Offset: 0x00011CE4
			// (set) Token: 0x0600039E RID: 926 RVA: 0x00003A48 File Offset: 0x00001C48
			public unsafe string _Algorithm_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWebSignature.Header.NativeFieldInfoPtr__Algorithm_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWebSignature.Header.NativeFieldInfoPtr__Algorithm_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700014D RID: 333
			// (get) Token: 0x0600039F RID: 927 RVA: 0x00013B0C File Offset: 0x00011D0C
			// (set) Token: 0x060003A0 RID: 928 RVA: 0x00003A67 File Offset: 0x00001C67
			public unsafe string _JwkUrl_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWebSignature.Header.NativeFieldInfoPtr__JwkUrl_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWebSignature.Header.NativeFieldInfoPtr__JwkUrl_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700014E RID: 334
			// (get) Token: 0x060003A1 RID: 929 RVA: 0x00013B34 File Offset: 0x00011D34
			// (set) Token: 0x060003A2 RID: 930 RVA: 0x00003A86 File Offset: 0x00001C86
			public unsafe string _Jwk_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWebSignature.Header.NativeFieldInfoPtr__Jwk_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWebSignature.Header.NativeFieldInfoPtr__Jwk_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700014F RID: 335
			// (get) Token: 0x060003A3 RID: 931 RVA: 0x00013B5C File Offset: 0x00011D5C
			// (set) Token: 0x060003A4 RID: 932 RVA: 0x00003AA5 File Offset: 0x00001CA5
			public unsafe string _KeyId_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWebSignature.Header.NativeFieldInfoPtr__KeyId_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWebSignature.Header.NativeFieldInfoPtr__KeyId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000150 RID: 336
			// (get) Token: 0x060003A5 RID: 933 RVA: 0x00013B84 File Offset: 0x00011D84
			// (set) Token: 0x060003A6 RID: 934 RVA: 0x00003AC4 File Offset: 0x00001CC4
			public unsafe string _X509Url_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWebSignature.Header.NativeFieldInfoPtr__X509Url_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWebSignature.Header.NativeFieldInfoPtr__X509Url_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000151 RID: 337
			// (get) Token: 0x060003A7 RID: 935 RVA: 0x00013BAC File Offset: 0x00011DAC
			// (set) Token: 0x060003A8 RID: 936 RVA: 0x00003AE3 File Offset: 0x00001CE3
			public unsafe string _X509Thumbprint_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWebSignature.Header.NativeFieldInfoPtr__X509Thumbprint_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWebSignature.Header.NativeFieldInfoPtr__X509Thumbprint_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000152 RID: 338
			// (get) Token: 0x060003A9 RID: 937 RVA: 0x00013BD4 File Offset: 0x00011DD4
			// (set) Token: 0x060003AA RID: 938 RVA: 0x00003B02 File Offset: 0x00001D02
			public unsafe string _X509Certificate_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWebSignature.Header.NativeFieldInfoPtr__X509Certificate_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWebSignature.Header.NativeFieldInfoPtr__X509Certificate_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000153 RID: 339
			// (get) Token: 0x060003AB RID: 939 RVA: 0x00013BFC File Offset: 0x00011DFC
			// (set) Token: 0x060003AC RID: 940 RVA: 0x00003B21 File Offset: 0x00001D21
			public unsafe IList<string> _critical_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWebSignature.Header.NativeFieldInfoPtr__critical_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWebSignature.Header.NativeFieldInfoPtr__critical_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400024A RID: 586
			private static readonly IntPtr NativeFieldInfoPtr__Algorithm_k__BackingField;

			// Token: 0x0400024B RID: 587
			private static readonly IntPtr NativeFieldInfoPtr__JwkUrl_k__BackingField;

			// Token: 0x0400024C RID: 588
			private static readonly IntPtr NativeFieldInfoPtr__Jwk_k__BackingField;

			// Token: 0x0400024D RID: 589
			private static readonly IntPtr NativeFieldInfoPtr__KeyId_k__BackingField;

			// Token: 0x0400024E RID: 590
			private static readonly IntPtr NativeFieldInfoPtr__X509Url_k__BackingField;

			// Token: 0x0400024F RID: 591
			private static readonly IntPtr NativeFieldInfoPtr__X509Thumbprint_k__BackingField;

			// Token: 0x04000250 RID: 592
			private static readonly IntPtr NativeFieldInfoPtr__X509Certificate_k__BackingField;

			// Token: 0x04000251 RID: 593
			private static readonly IntPtr NativeFieldInfoPtr__critical_k__BackingField;

			// Token: 0x04000252 RID: 594
			private static readonly IntPtr NativeMethodInfoPtr_get_Algorithm_Public_get_String_0;

			// Token: 0x04000253 RID: 595
			private static readonly IntPtr NativeMethodInfoPtr_set_Algorithm_Public_set_Void_String_0;

			// Token: 0x04000254 RID: 596
			private static readonly IntPtr NativeMethodInfoPtr_get_JwkUrl_Public_get_String_0;

			// Token: 0x04000255 RID: 597
			private static readonly IntPtr NativeMethodInfoPtr_set_JwkUrl_Public_set_Void_String_0;

			// Token: 0x04000256 RID: 598
			private static readonly IntPtr NativeMethodInfoPtr_get_Jwk_Public_get_String_0;

			// Token: 0x04000257 RID: 599
			private static readonly IntPtr NativeMethodInfoPtr_set_Jwk_Public_set_Void_String_0;

			// Token: 0x04000258 RID: 600
			private static readonly IntPtr NativeMethodInfoPtr_get_KeyId_Public_get_String_0;

			// Token: 0x04000259 RID: 601
			private static readonly IntPtr NativeMethodInfoPtr_set_KeyId_Public_set_Void_String_0;

			// Token: 0x0400025A RID: 602
			private static readonly IntPtr NativeMethodInfoPtr_get_X509Url_Public_get_String_0;

			// Token: 0x0400025B RID: 603
			private static readonly IntPtr NativeMethodInfoPtr_set_X509Url_Public_set_Void_String_0;

			// Token: 0x0400025C RID: 604
			private static readonly IntPtr NativeMethodInfoPtr_get_X509Thumbprint_Public_get_String_0;

			// Token: 0x0400025D RID: 605
			private static readonly IntPtr NativeMethodInfoPtr_set_X509Thumbprint_Public_set_Void_String_0;

			// Token: 0x0400025E RID: 606
			private static readonly IntPtr NativeMethodInfoPtr_get_X509Certificate_Public_get_String_0;

			// Token: 0x0400025F RID: 607
			private static readonly IntPtr NativeMethodInfoPtr_set_X509Certificate_Public_set_Void_String_0;

			// Token: 0x04000260 RID: 608
			private static readonly IntPtr NativeMethodInfoPtr_get_critical_Public_get_IList_1_String_0;

			// Token: 0x04000261 RID: 609
			private static readonly IntPtr NativeMethodInfoPtr_set_critical_Public_set_Void_IList_1_String_0;

			// Token: 0x04000262 RID: 610
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000039 RID: 57
		public class Payload : JsonWebToken.Payload
		{
			// Token: 0x060003AD RID: 941 RVA: 0x00003B40 File Offset: 0x00001D40
			// Note: this type is marked as 'beforefieldinit'.
			static Payload()
			{
				Il2CppClassPointerStore<JsonWebSignature.Payload>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonWebSignature>.NativeClassPtr, "Payload");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonWebSignature.Payload>.NativeClassPtr);
				JsonWebSignature.Payload.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebSignature.Payload>.NativeClassPtr, 100663376);
			}

			// Token: 0x060003AE RID: 942 RVA: 0x00013C2C File Offset: 0x00011E2C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Payload()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonWebSignature.Payload>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebSignature.Payload.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003AF RID: 943 RVA: 0x00003B74 File Offset: 0x00001D74
			public Payload(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000263 RID: 611
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
