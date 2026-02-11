using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Google.Apis.Auth.OAuth2.Responses
{
	// Token: 0x02000023 RID: 35
	public class TokenErrorResponse : Object
	{
		// Token: 0x060001F2 RID: 498 RVA: 0x0000DCD4 File Offset: 0x0000BED4
		// Note: this type is marked as 'beforefieldinit'.
		static TokenErrorResponse()
		{
			Il2CppClassPointerStore<TokenErrorResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth.OAuth2.Responses", "TokenErrorResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TokenErrorResponse>.NativeClassPtr);
			TokenErrorResponse.NativeFieldInfoPtr__Error_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenErrorResponse>.NativeClassPtr, "<Error>k__BackingField");
			TokenErrorResponse.NativeFieldInfoPtr__ErrorDescription_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenErrorResponse>.NativeClassPtr, "<ErrorDescription>k__BackingField");
			TokenErrorResponse.NativeFieldInfoPtr__ErrorUri_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenErrorResponse>.NativeClassPtr, "<ErrorUri>k__BackingField");
			TokenErrorResponse.NativeMethodInfoPtr_get_Error_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenErrorResponse>.NativeClassPtr, 100663764);
			TokenErrorResponse.NativeMethodInfoPtr_set_Error_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenErrorResponse>.NativeClassPtr, 100663765);
			TokenErrorResponse.NativeMethodInfoPtr_get_ErrorDescription_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenErrorResponse>.NativeClassPtr, 100663766);
			TokenErrorResponse.NativeMethodInfoPtr_set_ErrorDescription_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenErrorResponse>.NativeClassPtr, 100663767);
			TokenErrorResponse.NativeMethodInfoPtr_get_ErrorUri_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenErrorResponse>.NativeClassPtr, 100663768);
			TokenErrorResponse.NativeMethodInfoPtr_set_ErrorUri_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenErrorResponse>.NativeClassPtr, 100663769);
			TokenErrorResponse.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenErrorResponse>.NativeClassPtr, 100663770);
			TokenErrorResponse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenErrorResponse>.NativeClassPtr, 100663771);
			TokenErrorResponse.NativeMethodInfoPtr__ctor_Public_Void_AuthorizationCodeResponseUrl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenErrorResponse>.NativeClassPtr, 100663772);
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x0000DDF4 File Offset: 0x0000BFF4
		// (set) Token: 0x060001F4 RID: 500 RVA: 0x0000DE2C File Offset: 0x0000C02C
		public unsafe string Error
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenErrorResponse.NativeMethodInfoPtr_get_Error_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenErrorResponse.NativeMethodInfoPtr_set_Error_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x0000DE70 File Offset: 0x0000C070
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x0000DEA8 File Offset: 0x0000C0A8
		public unsafe string ErrorDescription
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenErrorResponse.NativeMethodInfoPtr_get_ErrorDescription_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenErrorResponse.NativeMethodInfoPtr_set_ErrorDescription_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x0000DEEC File Offset: 0x0000C0EC
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x0000DF24 File Offset: 0x0000C124
		public unsafe string ErrorUri
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenErrorResponse.NativeMethodInfoPtr_get_ErrorUri_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenErrorResponse.NativeMethodInfoPtr_set_ErrorUri_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0000DF68 File Offset: 0x0000C168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156808, XrefRangeEnd = 1156811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TokenErrorResponse.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0000DFAC File Offset: 0x0000C1AC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TokenErrorResponse()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TokenErrorResponse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenErrorResponse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000DFE8 File Offset: 0x0000C1E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156811, XrefRangeEnd = 1156816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TokenErrorResponse(AuthorizationCodeResponseUrl authorizationCode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TokenErrorResponse>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(authorizationCode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenErrorResponse.NativeMethodInfoPtr__ctor_Public_Void_AuthorizationCodeResponseUrl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00002D99 File Offset: 0x00000F99
		public TokenErrorResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060001FD RID: 509 RVA: 0x0000E034 File Offset: 0x0000C234
		// (set) Token: 0x060001FE RID: 510 RVA: 0x00002DA2 File Offset: 0x00000FA2
		public unsafe string _Error_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenErrorResponse.NativeFieldInfoPtr__Error_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenErrorResponse.NativeFieldInfoPtr__Error_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060001FF RID: 511 RVA: 0x0000E05C File Offset: 0x0000C25C
		// (set) Token: 0x06000200 RID: 512 RVA: 0x00002DC1 File Offset: 0x00000FC1
		public unsafe string _ErrorDescription_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenErrorResponse.NativeFieldInfoPtr__ErrorDescription_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenErrorResponse.NativeFieldInfoPtr__ErrorDescription_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000201 RID: 513 RVA: 0x0000E084 File Offset: 0x0000C284
		// (set) Token: 0x06000202 RID: 514 RVA: 0x00002DE0 File Offset: 0x00000FE0
		public unsafe string _ErrorUri_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenErrorResponse.NativeFieldInfoPtr__ErrorUri_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenErrorResponse.NativeFieldInfoPtr__ErrorUri_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeFieldInfoPtr__Error_k__BackingField;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeFieldInfoPtr__ErrorDescription_k__BackingField;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeFieldInfoPtr__ErrorUri_k__BackingField;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr_get_Error_Public_get_String_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_set_Error_Public_set_Void_String_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_get_ErrorDescription_Public_get_String_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_set_ErrorDescription_Public_set_Void_String_0;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr_get_ErrorUri_Public_get_String_0;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr_set_ErrorUri_Public_set_Void_String_0;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AuthorizationCodeResponseUrl_0;
	}
}
