using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Auth
{
	// Token: 0x02000006 RID: 6
	public class JsonWebToken : Object
	{
		// Token: 0x0600002F RID: 47 RVA: 0x00002178 File Offset: 0x00000378
		// Note: this type is marked as 'beforefieldinit'.
		static JsonWebToken()
		{
			Il2CppClassPointerStore<JsonWebToken>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth", "JsonWebToken");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonWebToken>.NativeClassPtr);
			JsonWebToken.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebToken>.NativeClassPtr, 100663377);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00007CA0 File Offset: 0x00005EA0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonWebToken()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonWebToken>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebToken.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000021B1 File Offset: 0x000003B1
		public JsonWebToken(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200003A RID: 58
		public class Header : Object
		{
			// Token: 0x060003B0 RID: 944 RVA: 0x00013C68 File Offset: 0x00011E68
			// Note: this type is marked as 'beforefieldinit'.
			static Header()
			{
				Il2CppClassPointerStore<JsonWebToken.Header>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonWebToken>.NativeClassPtr, "Header");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonWebToken.Header>.NativeClassPtr);
				JsonWebToken.Header.NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWebToken.Header>.NativeClassPtr, "<Type>k__BackingField");
				JsonWebToken.Header.NativeFieldInfoPtr__ContentType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWebToken.Header>.NativeClassPtr, "<ContentType>k__BackingField");
				JsonWebToken.Header.NativeMethodInfoPtr_get_Type_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebToken.Header>.NativeClassPtr, 100663378);
				JsonWebToken.Header.NativeMethodInfoPtr_set_Type_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebToken.Header>.NativeClassPtr, 100663379);
				JsonWebToken.Header.NativeMethodInfoPtr_get_ContentType_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebToken.Header>.NativeClassPtr, 100663380);
				JsonWebToken.Header.NativeMethodInfoPtr_set_ContentType_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebToken.Header>.NativeClassPtr, 100663381);
				JsonWebToken.Header.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebToken.Header>.NativeClassPtr, 100663382);
			}

			// Token: 0x1700015E RID: 350
			// (get) Token: 0x060003B1 RID: 945 RVA: 0x00013D20 File Offset: 0x00011F20
			// (set) Token: 0x060003B2 RID: 946 RVA: 0x00013D58 File Offset: 0x00011F58
			public unsafe string Type
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebToken.Header.NativeMethodInfoPtr_get_Type_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebToken.Header.NativeMethodInfoPtr_set_Type_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700015F RID: 351
			// (get) Token: 0x060003B3 RID: 947 RVA: 0x00013D9C File Offset: 0x00011F9C
			// (set) Token: 0x060003B4 RID: 948 RVA: 0x00013DD4 File Offset: 0x00011FD4
			public unsafe string ContentType
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebToken.Header.NativeMethodInfoPtr_get_ContentType_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebToken.Header.NativeMethodInfoPtr_set_ContentType_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060003B5 RID: 949 RVA: 0x00013E18 File Offset: 0x00012018
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Header()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonWebToken.Header>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebToken.Header.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003B6 RID: 950 RVA: 0x00003B7D File Offset: 0x00001D7D
			public Header(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700015C RID: 348
			// (get) Token: 0x060003B7 RID: 951 RVA: 0x00013E54 File Offset: 0x00012054
			// (set) Token: 0x060003B8 RID: 952 RVA: 0x00003B86 File Offset: 0x00001D86
			public unsafe string _Type_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWebToken.Header.NativeFieldInfoPtr__Type_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWebToken.Header.NativeFieldInfoPtr__Type_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700015D RID: 349
			// (get) Token: 0x060003B9 RID: 953 RVA: 0x00013E7C File Offset: 0x0001207C
			// (set) Token: 0x060003BA RID: 954 RVA: 0x00003BA5 File Offset: 0x00001DA5
			public unsafe string _ContentType_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWebToken.Header.NativeFieldInfoPtr__ContentType_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWebToken.Header.NativeFieldInfoPtr__ContentType_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04000264 RID: 612
			private static readonly IntPtr NativeFieldInfoPtr__Type_k__BackingField;

			// Token: 0x04000265 RID: 613
			private static readonly IntPtr NativeFieldInfoPtr__ContentType_k__BackingField;

			// Token: 0x04000266 RID: 614
			private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_String_0;

			// Token: 0x04000267 RID: 615
			private static readonly IntPtr NativeMethodInfoPtr_set_Type_Public_set_Void_String_0;

			// Token: 0x04000268 RID: 616
			private static readonly IntPtr NativeMethodInfoPtr_get_ContentType_Public_get_String_0;

			// Token: 0x04000269 RID: 617
			private static readonly IntPtr NativeMethodInfoPtr_set_ContentType_Public_set_Void_String_0;

			// Token: 0x0400026A RID: 618
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200003B RID: 59
		public class Payload : Object
		{
			// Token: 0x060003BB RID: 955 RVA: 0x00013EA4 File Offset: 0x000120A4
			// Note: this type is marked as 'beforefieldinit'.
			static Payload()
			{
				Il2CppClassPointerStore<JsonWebToken.Payload>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonWebToken>.NativeClassPtr, "Payload");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonWebToken.Payload>.NativeClassPtr);
				JsonWebToken.Payload.NativeFieldInfoPtr__Issuer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWebToken.Payload>.NativeClassPtr, "<Issuer>k__BackingField");
				JsonWebToken.Payload.NativeFieldInfoPtr__Subject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWebToken.Payload>.NativeClassPtr, "<Subject>k__BackingField");
				JsonWebToken.Payload.NativeFieldInfoPtr__Audience_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWebToken.Payload>.NativeClassPtr, "<Audience>k__BackingField");
				JsonWebToken.Payload.NativeFieldInfoPtr__ExpirationTimeSeconds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWebToken.Payload>.NativeClassPtr, "<ExpirationTimeSeconds>k__BackingField");
				JsonWebToken.Payload.NativeFieldInfoPtr__NotBeforeTimeSeconds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWebToken.Payload>.NativeClassPtr, "<NotBeforeTimeSeconds>k__BackingField");
				JsonWebToken.Payload.NativeFieldInfoPtr__IssuedAtTimeSeconds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWebToken.Payload>.NativeClassPtr, "<IssuedAtTimeSeconds>k__BackingField");
				JsonWebToken.Payload.NativeFieldInfoPtr__JwtId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWebToken.Payload>.NativeClassPtr, "<JwtId>k__BackingField");
				JsonWebToken.Payload.NativeFieldInfoPtr__Nonce_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWebToken.Payload>.NativeClassPtr, "<Nonce>k__BackingField");
				JsonWebToken.Payload.NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonWebToken.Payload>.NativeClassPtr, "<Type>k__BackingField");
				JsonWebToken.Payload.NativeMethodInfoPtr_get_Issuer_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebToken.Payload>.NativeClassPtr, 100663383);
				JsonWebToken.Payload.NativeMethodInfoPtr_set_Issuer_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebToken.Payload>.NativeClassPtr, 100663384);
				JsonWebToken.Payload.NativeMethodInfoPtr_get_Subject_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebToken.Payload>.NativeClassPtr, 100663385);
				JsonWebToken.Payload.NativeMethodInfoPtr_set_Subject_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebToken.Payload>.NativeClassPtr, 100663386);
				JsonWebToken.Payload.NativeMethodInfoPtr_get_Audience_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebToken.Payload>.NativeClassPtr, 100663387);
				JsonWebToken.Payload.NativeMethodInfoPtr_set_Audience_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebToken.Payload>.NativeClassPtr, 100663388);
				JsonWebToken.Payload.NativeMethodInfoPtr_get_ExpirationTimeSeconds_Public_get_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebToken.Payload>.NativeClassPtr, 100663389);
				JsonWebToken.Payload.NativeMethodInfoPtr_set_ExpirationTimeSeconds_Public_set_Void_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebToken.Payload>.NativeClassPtr, 100663390);
				JsonWebToken.Payload.NativeMethodInfoPtr_get_NotBeforeTimeSeconds_Public_get_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebToken.Payload>.NativeClassPtr, 100663391);
				JsonWebToken.Payload.NativeMethodInfoPtr_set_NotBeforeTimeSeconds_Public_set_Void_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebToken.Payload>.NativeClassPtr, 100663392);
				JsonWebToken.Payload.NativeMethodInfoPtr_get_IssuedAtTimeSeconds_Public_get_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebToken.Payload>.NativeClassPtr, 100663393);
				JsonWebToken.Payload.NativeMethodInfoPtr_set_IssuedAtTimeSeconds_Public_set_Void_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebToken.Payload>.NativeClassPtr, 100663394);
				JsonWebToken.Payload.NativeMethodInfoPtr_get_JwtId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebToken.Payload>.NativeClassPtr, 100663395);
				JsonWebToken.Payload.NativeMethodInfoPtr_set_JwtId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebToken.Payload>.NativeClassPtr, 100663396);
				JsonWebToken.Payload.NativeMethodInfoPtr_get_Nonce_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebToken.Payload>.NativeClassPtr, 100663397);
				JsonWebToken.Payload.NativeMethodInfoPtr_set_Nonce_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebToken.Payload>.NativeClassPtr, 100663398);
				JsonWebToken.Payload.NativeMethodInfoPtr_get_Type_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebToken.Payload>.NativeClassPtr, 100663399);
				JsonWebToken.Payload.NativeMethodInfoPtr_set_Type_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebToken.Payload>.NativeClassPtr, 100663400);
				JsonWebToken.Payload.NativeMethodInfoPtr_get_AudienceAsList_Public_get_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebToken.Payload>.NativeClassPtr, 100663401);
				JsonWebToken.Payload.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWebToken.Payload>.NativeClassPtr, 100663402);
			}

			// Token: 0x17000169 RID: 361
			// (get) Token: 0x060003BC RID: 956 RVA: 0x00014114 File Offset: 0x00012314
			// (set) Token: 0x060003BD RID: 957 RVA: 0x0001414C File Offset: 0x0001234C
			public unsafe string Issuer
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebToken.Payload.NativeMethodInfoPtr_get_Issuer_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebToken.Payload.NativeMethodInfoPtr_set_Issuer_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700016A RID: 362
			// (get) Token: 0x060003BE RID: 958 RVA: 0x00014190 File Offset: 0x00012390
			// (set) Token: 0x060003BF RID: 959 RVA: 0x000141C8 File Offset: 0x000123C8
			public unsafe string Subject
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebToken.Payload.NativeMethodInfoPtr_get_Subject_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebToken.Payload.NativeMethodInfoPtr_set_Subject_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700016B RID: 363
			// (get) Token: 0x060003C0 RID: 960 RVA: 0x0001420C File Offset: 0x0001240C
			// (set) Token: 0x060003C1 RID: 961 RVA: 0x0001424C File Offset: 0x0001244C
			public unsafe Object Audience
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebToken.Payload.NativeMethodInfoPtr_get_Audience_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebToken.Payload.NativeMethodInfoPtr_set_Audience_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700016C RID: 364
			// (get) Token: 0x060003C2 RID: 962 RVA: 0x00014290 File Offset: 0x00012490
			// (set) Token: 0x060003C3 RID: 963 RVA: 0x000142C8 File Offset: 0x000124C8
			public unsafe Nullable<long> ExpirationTimeSeconds
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebToken.Payload.NativeMethodInfoPtr_get_ExpirationTimeSeconds_Public_get_Nullable_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new Nullable<long>(intPtr);
				}
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 755145, RefRangeEnd = 755149, XrefRangeStart = 755145, XrefRangeEnd = 755149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebToken.Payload.NativeMethodInfoPtr_set_ExpirationTimeSeconds_Public_set_Void_Nullable_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700016D RID: 365
			// (get) Token: 0x060003C4 RID: 964 RVA: 0x00014310 File Offset: 0x00012510
			// (set) Token: 0x060003C5 RID: 965 RVA: 0x00014348 File Offset: 0x00012548
			public unsafe Nullable<long> NotBeforeTimeSeconds
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebToken.Payload.NativeMethodInfoPtr_get_NotBeforeTimeSeconds_Public_get_Nullable_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new Nullable<long>(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebToken.Payload.NativeMethodInfoPtr_set_NotBeforeTimeSeconds_Public_set_Void_Nullable_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700016E RID: 366
			// (get) Token: 0x060003C6 RID: 966 RVA: 0x00014390 File Offset: 0x00012590
			// (set) Token: 0x060003C7 RID: 967 RVA: 0x000143C8 File Offset: 0x000125C8
			public unsafe Nullable<long> IssuedAtTimeSeconds
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebToken.Payload.NativeMethodInfoPtr_get_IssuedAtTimeSeconds_Public_get_Nullable_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new Nullable<long>(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebToken.Payload.NativeMethodInfoPtr_set_IssuedAtTimeSeconds_Public_set_Void_Nullable_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700016F RID: 367
			// (get) Token: 0x060003C8 RID: 968 RVA: 0x00014410 File Offset: 0x00012610
			// (set) Token: 0x060003C9 RID: 969 RVA: 0x00014448 File Offset: 0x00012648
			public unsafe string JwtId
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebToken.Payload.NativeMethodInfoPtr_get_JwtId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebToken.Payload.NativeMethodInfoPtr_set_JwtId_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000170 RID: 368
			// (get) Token: 0x060003CA RID: 970 RVA: 0x0001448C File Offset: 0x0001268C
			// (set) Token: 0x060003CB RID: 971 RVA: 0x000144C4 File Offset: 0x000126C4
			public unsafe string Nonce
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebToken.Payload.NativeMethodInfoPtr_get_Nonce_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebToken.Payload.NativeMethodInfoPtr_set_Nonce_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000171 RID: 369
			// (get) Token: 0x060003CC RID: 972 RVA: 0x00014508 File Offset: 0x00012708
			// (set) Token: 0x060003CD RID: 973 RVA: 0x00014540 File Offset: 0x00012740
			public unsafe string Type
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebToken.Payload.NativeMethodInfoPtr_get_Type_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebToken.Payload.NativeMethodInfoPtr_set_Type_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000172 RID: 370
			// (get) Token: 0x060003CE RID: 974 RVA: 0x00014584 File Offset: 0x00012784
			public unsafe IEnumerable<string> AudienceAsList
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1152678, XrefRangeEnd = 1152690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebToken.Payload.NativeMethodInfoPtr_get_AudienceAsList_Public_get_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
				}
			}

			// Token: 0x060003CF RID: 975 RVA: 0x000145C4 File Offset: 0x000127C4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Payload()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonWebToken.Payload>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWebToken.Payload.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003D0 RID: 976 RVA: 0x00003BC4 File Offset: 0x00001DC4
			public Payload(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000160 RID: 352
			// (get) Token: 0x060003D1 RID: 977 RVA: 0x00014600 File Offset: 0x00012800
			// (set) Token: 0x060003D2 RID: 978 RVA: 0x00003BCD File Offset: 0x00001DCD
			public unsafe string _Issuer_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWebToken.Payload.NativeFieldInfoPtr__Issuer_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWebToken.Payload.NativeFieldInfoPtr__Issuer_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000161 RID: 353
			// (get) Token: 0x060003D3 RID: 979 RVA: 0x00014628 File Offset: 0x00012828
			// (set) Token: 0x060003D4 RID: 980 RVA: 0x00003BEC File Offset: 0x00001DEC
			public unsafe string _Subject_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWebToken.Payload.NativeFieldInfoPtr__Subject_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWebToken.Payload.NativeFieldInfoPtr__Subject_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000162 RID: 354
			// (get) Token: 0x060003D5 RID: 981 RVA: 0x00014650 File Offset: 0x00012850
			// (set) Token: 0x060003D6 RID: 982 RVA: 0x00003C0B File Offset: 0x00001E0B
			public unsafe Object _Audience_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWebToken.Payload.NativeFieldInfoPtr__Audience_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWebToken.Payload.NativeFieldInfoPtr__Audience_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000163 RID: 355
			// (get) Token: 0x060003D7 RID: 983 RVA: 0x00014680 File Offset: 0x00012880
			// (set) Token: 0x060003D8 RID: 984 RVA: 0x00003C2A File Offset: 0x00001E2A
			public Nullable<long> _ExpirationTimeSeconds_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWebToken.Payload.NativeFieldInfoPtr__ExpirationTimeSeconds_k__BackingField);
					return new Nullable<long>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<long>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWebToken.Payload.NativeFieldInfoPtr__ExpirationTimeSeconds_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<long>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000164 RID: 356
			// (get) Token: 0x060003D9 RID: 985 RVA: 0x000146B0 File Offset: 0x000128B0
			// (set) Token: 0x060003DA RID: 986 RVA: 0x00003C58 File Offset: 0x00001E58
			public Nullable<long> _NotBeforeTimeSeconds_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWebToken.Payload.NativeFieldInfoPtr__NotBeforeTimeSeconds_k__BackingField);
					return new Nullable<long>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<long>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWebToken.Payload.NativeFieldInfoPtr__NotBeforeTimeSeconds_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<long>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000165 RID: 357
			// (get) Token: 0x060003DB RID: 987 RVA: 0x000146E0 File Offset: 0x000128E0
			// (set) Token: 0x060003DC RID: 988 RVA: 0x00003C86 File Offset: 0x00001E86
			public Nullable<long> _IssuedAtTimeSeconds_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWebToken.Payload.NativeFieldInfoPtr__IssuedAtTimeSeconds_k__BackingField);
					return new Nullable<long>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<long>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWebToken.Payload.NativeFieldInfoPtr__IssuedAtTimeSeconds_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<long>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000166 RID: 358
			// (get) Token: 0x060003DD RID: 989 RVA: 0x00014710 File Offset: 0x00012910
			// (set) Token: 0x060003DE RID: 990 RVA: 0x00003CB4 File Offset: 0x00001EB4
			public unsafe string _JwtId_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWebToken.Payload.NativeFieldInfoPtr__JwtId_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWebToken.Payload.NativeFieldInfoPtr__JwtId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000167 RID: 359
			// (get) Token: 0x060003DF RID: 991 RVA: 0x00014738 File Offset: 0x00012938
			// (set) Token: 0x060003E0 RID: 992 RVA: 0x00003CD3 File Offset: 0x00001ED3
			public unsafe string _Nonce_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWebToken.Payload.NativeFieldInfoPtr__Nonce_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWebToken.Payload.NativeFieldInfoPtr__Nonce_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000168 RID: 360
			// (get) Token: 0x060003E1 RID: 993 RVA: 0x00014760 File Offset: 0x00012960
			// (set) Token: 0x060003E2 RID: 994 RVA: 0x00003CF2 File Offset: 0x00001EF2
			public unsafe string _Type_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWebToken.Payload.NativeFieldInfoPtr__Type_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonWebToken.Payload.NativeFieldInfoPtr__Type_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400026B RID: 619
			private static readonly IntPtr NativeFieldInfoPtr__Issuer_k__BackingField;

			// Token: 0x0400026C RID: 620
			private static readonly IntPtr NativeFieldInfoPtr__Subject_k__BackingField;

			// Token: 0x0400026D RID: 621
			private static readonly IntPtr NativeFieldInfoPtr__Audience_k__BackingField;

			// Token: 0x0400026E RID: 622
			private static readonly IntPtr NativeFieldInfoPtr__ExpirationTimeSeconds_k__BackingField;

			// Token: 0x0400026F RID: 623
			private static readonly IntPtr NativeFieldInfoPtr__NotBeforeTimeSeconds_k__BackingField;

			// Token: 0x04000270 RID: 624
			private static readonly IntPtr NativeFieldInfoPtr__IssuedAtTimeSeconds_k__BackingField;

			// Token: 0x04000271 RID: 625
			private static readonly IntPtr NativeFieldInfoPtr__JwtId_k__BackingField;

			// Token: 0x04000272 RID: 626
			private static readonly IntPtr NativeFieldInfoPtr__Nonce_k__BackingField;

			// Token: 0x04000273 RID: 627
			private static readonly IntPtr NativeFieldInfoPtr__Type_k__BackingField;

			// Token: 0x04000274 RID: 628
			private static readonly IntPtr NativeMethodInfoPtr_get_Issuer_Public_get_String_0;

			// Token: 0x04000275 RID: 629
			private static readonly IntPtr NativeMethodInfoPtr_set_Issuer_Public_set_Void_String_0;

			// Token: 0x04000276 RID: 630
			private static readonly IntPtr NativeMethodInfoPtr_get_Subject_Public_get_String_0;

			// Token: 0x04000277 RID: 631
			private static readonly IntPtr NativeMethodInfoPtr_set_Subject_Public_set_Void_String_0;

			// Token: 0x04000278 RID: 632
			private static readonly IntPtr NativeMethodInfoPtr_get_Audience_Public_get_Object_0;

			// Token: 0x04000279 RID: 633
			private static readonly IntPtr NativeMethodInfoPtr_set_Audience_Public_set_Void_Object_0;

			// Token: 0x0400027A RID: 634
			private static readonly IntPtr NativeMethodInfoPtr_get_ExpirationTimeSeconds_Public_get_Nullable_1_Int64_0;

			// Token: 0x0400027B RID: 635
			private static readonly IntPtr NativeMethodInfoPtr_set_ExpirationTimeSeconds_Public_set_Void_Nullable_1_Int64_0;

			// Token: 0x0400027C RID: 636
			private static readonly IntPtr NativeMethodInfoPtr_get_NotBeforeTimeSeconds_Public_get_Nullable_1_Int64_0;

			// Token: 0x0400027D RID: 637
			private static readonly IntPtr NativeMethodInfoPtr_set_NotBeforeTimeSeconds_Public_set_Void_Nullable_1_Int64_0;

			// Token: 0x0400027E RID: 638
			private static readonly IntPtr NativeMethodInfoPtr_get_IssuedAtTimeSeconds_Public_get_Nullable_1_Int64_0;

			// Token: 0x0400027F RID: 639
			private static readonly IntPtr NativeMethodInfoPtr_set_IssuedAtTimeSeconds_Public_set_Void_Nullable_1_Int64_0;

			// Token: 0x04000280 RID: 640
			private static readonly IntPtr NativeMethodInfoPtr_get_JwtId_Public_get_String_0;

			// Token: 0x04000281 RID: 641
			private static readonly IntPtr NativeMethodInfoPtr_set_JwtId_Public_set_Void_String_0;

			// Token: 0x04000282 RID: 642
			private static readonly IntPtr NativeMethodInfoPtr_get_Nonce_Public_get_String_0;

			// Token: 0x04000283 RID: 643
			private static readonly IntPtr NativeMethodInfoPtr_set_Nonce_Public_set_Void_String_0;

			// Token: 0x04000284 RID: 644
			private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_String_0;

			// Token: 0x04000285 RID: 645
			private static readonly IntPtr NativeMethodInfoPtr_set_Type_Public_set_Void_String_0;

			// Token: 0x04000286 RID: 646
			private static readonly IntPtr NativeMethodInfoPtr_get_AudienceAsList_Public_get_IEnumerable_1_String_0;

			// Token: 0x04000287 RID: 647
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
