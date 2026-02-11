using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Net;

namespace Google.Apis.Auth.OAuth2.Responses
{
	// Token: 0x02000025 RID: 37
	public class TokenResponseException : Exception
	{
		// Token: 0x0600022B RID: 555 RVA: 0x0000E9A0 File Offset: 0x0000CBA0
		// Note: this type is marked as 'beforefieldinit'.
		static TokenResponseException()
		{
			Il2CppClassPointerStore<TokenResponseException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth.OAuth2.Responses", "TokenResponseException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TokenResponseException>.NativeClassPtr);
			TokenResponseException.NativeFieldInfoPtr__Error_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenResponseException>.NativeClassPtr, "<Error>k__BackingField");
			TokenResponseException.NativeFieldInfoPtr__StatusCode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenResponseException>.NativeClassPtr, "<StatusCode>k__BackingField");
			TokenResponseException.NativeMethodInfoPtr_get_Error_Public_get_TokenErrorResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenResponseException>.NativeClassPtr, 100663795);
			TokenResponseException.NativeMethodInfoPtr_get_StatusCode_Public_get_Nullable_1_HttpStatusCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenResponseException>.NativeClassPtr, 100663796);
			TokenResponseException.NativeMethodInfoPtr__ctor_Public_Void_TokenErrorResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenResponseException>.NativeClassPtr, 100663797);
			TokenResponseException.NativeMethodInfoPtr__ctor_Public_Void_TokenErrorResponse_Nullable_1_HttpStatusCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenResponseException>.NativeClassPtr, 100663798);
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600022C RID: 556 RVA: 0x0000EA48 File Offset: 0x0000CC48
		public unsafe TokenErrorResponse Error
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenResponseException.NativeMethodInfoPtr_get_Error_Public_get_TokenErrorResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TokenErrorResponse>(intPtr3) : null;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600022D RID: 557 RVA: 0x0000EA88 File Offset: 0x0000CC88
		public unsafe Nullable<HttpStatusCode> StatusCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenResponseException.NativeMethodInfoPtr_get_StatusCode_Public_get_Nullable_1_HttpStatusCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<HttpStatusCode>(intPtr);
			}
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000EAC0 File Offset: 0x0000CCC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156910, XrefRangeEnd = 1156915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TokenResponseException(TokenErrorResponse error)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TokenResponseException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(error);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenResponseException.NativeMethodInfoPtr__ctor_Public_Void_TokenErrorResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0000EB0C File Offset: 0x0000CD0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156915, XrefRangeEnd = 1156920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TokenResponseException(TokenErrorResponse error, Nullable<HttpStatusCode> statusCode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TokenResponseException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(error);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(statusCode));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenResponseException.NativeMethodInfoPtr__ctor_Public_Void_TokenErrorResponse_Nullable_1_HttpStatusCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00002F08 File Offset: 0x00001108
		public TokenResponseException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000231 RID: 561 RVA: 0x0000EB70 File Offset: 0x0000CD70
		// (set) Token: 0x06000232 RID: 562 RVA: 0x00002F11 File Offset: 0x00001111
		public unsafe TokenErrorResponse _Error_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenResponseException.NativeFieldInfoPtr__Error_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TokenErrorResponse>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenResponseException.NativeFieldInfoPtr__Error_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000233 RID: 563 RVA: 0x0000EBA0 File Offset: 0x0000CDA0
		// (set) Token: 0x06000234 RID: 564 RVA: 0x00002F30 File Offset: 0x00001130
		public Nullable<HttpStatusCode> _StatusCode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenResponseException.NativeFieldInfoPtr__StatusCode_k__BackingField);
				return new Nullable<HttpStatusCode>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<HttpStatusCode>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenResponseException.NativeFieldInfoPtr__StatusCode_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<HttpStatusCode>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeFieldInfoPtr__Error_k__BackingField;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeFieldInfoPtr__StatusCode_k__BackingField;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeMethodInfoPtr_get_Error_Public_get_TokenErrorResponse_0;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeMethodInfoPtr_get_StatusCode_Public_get_Nullable_1_HttpStatusCode_0;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TokenErrorResponse_0;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TokenErrorResponse_Nullable_1_HttpStatusCode_0;
	}
}
