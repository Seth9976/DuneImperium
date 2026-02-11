using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Google.Apis.Auth.OAuth2.Requests
{
	// Token: 0x0200002D RID: 45
	public class TokenRequest : Object
	{
		// Token: 0x06000296 RID: 662 RVA: 0x00010058 File Offset: 0x0000E258
		// Note: this type is marked as 'beforefieldinit'.
		static TokenRequest()
		{
			Il2CppClassPointerStore<TokenRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth.OAuth2.Requests", "TokenRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TokenRequest>.NativeClassPtr);
			TokenRequest.NativeFieldInfoPtr__Scope_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRequest>.NativeClassPtr, "<Scope>k__BackingField");
			TokenRequest.NativeFieldInfoPtr__GrantType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRequest>.NativeClassPtr, "<GrantType>k__BackingField");
			TokenRequest.NativeFieldInfoPtr__ClientId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRequest>.NativeClassPtr, "<ClientId>k__BackingField");
			TokenRequest.NativeFieldInfoPtr__ClientSecret_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRequest>.NativeClassPtr, "<ClientSecret>k__BackingField");
			TokenRequest.NativeMethodInfoPtr_get_Scope_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRequest>.NativeClassPtr, 100663844);
			TokenRequest.NativeMethodInfoPtr_set_Scope_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRequest>.NativeClassPtr, 100663845);
			TokenRequest.NativeMethodInfoPtr_get_GrantType_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRequest>.NativeClassPtr, 100663846);
			TokenRequest.NativeMethodInfoPtr_set_GrantType_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRequest>.NativeClassPtr, 100663847);
			TokenRequest.NativeMethodInfoPtr_get_ClientId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRequest>.NativeClassPtr, 100663848);
			TokenRequest.NativeMethodInfoPtr_set_ClientId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRequest>.NativeClassPtr, 100663849);
			TokenRequest.NativeMethodInfoPtr_get_ClientSecret_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRequest>.NativeClassPtr, 100663850);
			TokenRequest.NativeMethodInfoPtr_set_ClientSecret_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRequest>.NativeClassPtr, 100663851);
			TokenRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRequest>.NativeClassPtr, 100663852);
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000297 RID: 663 RVA: 0x0001018C File Offset: 0x0000E38C
		// (set) Token: 0x06000298 RID: 664 RVA: 0x000101C4 File Offset: 0x0000E3C4
		public unsafe string Scope
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenRequest.NativeMethodInfoPtr_get_Scope_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenRequest.NativeMethodInfoPtr_set_Scope_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000299 RID: 665 RVA: 0x00010208 File Offset: 0x0000E408
		// (set) Token: 0x0600029A RID: 666 RVA: 0x00010240 File Offset: 0x0000E440
		public unsafe string GrantType
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenRequest.NativeMethodInfoPtr_get_GrantType_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenRequest.NativeMethodInfoPtr_set_GrantType_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600029B RID: 667 RVA: 0x00010284 File Offset: 0x0000E484
		// (set) Token: 0x0600029C RID: 668 RVA: 0x000102BC File Offset: 0x0000E4BC
		public unsafe string ClientId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenRequest.NativeMethodInfoPtr_get_ClientId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenRequest.NativeMethodInfoPtr_set_ClientId_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600029D RID: 669 RVA: 0x00010300 File Offset: 0x0000E500
		// (set) Token: 0x0600029E RID: 670 RVA: 0x00010338 File Offset: 0x0000E538
		public unsafe string ClientSecret
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenRequest.NativeMethodInfoPtr_get_ClientSecret_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenRequest.NativeMethodInfoPtr_set_ClientSecret_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0001037C File Offset: 0x0000E57C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TokenRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TokenRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x000031EA File Offset: 0x000013EA
		public TokenRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x000103B8 File Offset: 0x0000E5B8
		// (set) Token: 0x060002A2 RID: 674 RVA: 0x000031F3 File Offset: 0x000013F3
		public unsafe string _Scope_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRequest.NativeFieldInfoPtr__Scope_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRequest.NativeFieldInfoPtr__Scope_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x000103E0 File Offset: 0x0000E5E0
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x00003212 File Offset: 0x00001412
		public unsafe string _GrantType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRequest.NativeFieldInfoPtr__GrantType_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRequest.NativeFieldInfoPtr__GrantType_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x00010408 File Offset: 0x0000E608
		// (set) Token: 0x060002A6 RID: 678 RVA: 0x00003231 File Offset: 0x00001431
		public unsafe string _ClientId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRequest.NativeFieldInfoPtr__ClientId_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRequest.NativeFieldInfoPtr__ClientId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x00010430 File Offset: 0x0000E630
		// (set) Token: 0x060002A8 RID: 680 RVA: 0x00003250 File Offset: 0x00001450
		public unsafe string _ClientSecret_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRequest.NativeFieldInfoPtr__ClientSecret_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenRequest.NativeFieldInfoPtr__ClientSecret_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeFieldInfoPtr__Scope_k__BackingField;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeFieldInfoPtr__GrantType_k__BackingField;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeFieldInfoPtr__ClientId_k__BackingField;

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeFieldInfoPtr__ClientSecret_k__BackingField;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeMethodInfoPtr_get_Scope_Public_get_String_0;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeMethodInfoPtr_set_Scope_Public_set_Void_String_0;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeMethodInfoPtr_get_GrantType_Public_get_String_0;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeMethodInfoPtr_set_GrantType_Public_set_Void_String_0;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeMethodInfoPtr_get_ClientId_Public_get_String_0;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeMethodInfoPtr_set_ClientId_Public_set_Void_String_0;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeMethodInfoPtr_get_ClientSecret_Public_get_String_0;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeMethodInfoPtr_set_ClientSecret_Public_set_Void_String_0;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
