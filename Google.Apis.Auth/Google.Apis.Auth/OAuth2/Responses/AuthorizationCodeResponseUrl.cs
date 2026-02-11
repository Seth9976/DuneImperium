using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Auth.OAuth2.Responses
{
	// Token: 0x02000022 RID: 34
	public class AuthorizationCodeResponseUrl : Object
	{
		// Token: 0x060001D3 RID: 467 RVA: 0x0000D524 File Offset: 0x0000B724
		// Note: this type is marked as 'beforefieldinit'.
		static AuthorizationCodeResponseUrl()
		{
			Il2CppClassPointerStore<AuthorizationCodeResponseUrl>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth.OAuth2.Responses", "AuthorizationCodeResponseUrl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthorizationCodeResponseUrl>.NativeClassPtr);
			AuthorizationCodeResponseUrl.NativeFieldInfoPtr__Code_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeResponseUrl>.NativeClassPtr, "<Code>k__BackingField");
			AuthorizationCodeResponseUrl.NativeFieldInfoPtr__State_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeResponseUrl>.NativeClassPtr, "<State>k__BackingField");
			AuthorizationCodeResponseUrl.NativeFieldInfoPtr__Error_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeResponseUrl>.NativeClassPtr, "<Error>k__BackingField");
			AuthorizationCodeResponseUrl.NativeFieldInfoPtr__ErrorDescription_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeResponseUrl>.NativeClassPtr, "<ErrorDescription>k__BackingField");
			AuthorizationCodeResponseUrl.NativeFieldInfoPtr__ErrorUri_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthorizationCodeResponseUrl>.NativeClassPtr, "<ErrorUri>k__BackingField");
			AuthorizationCodeResponseUrl.NativeMethodInfoPtr_get_Code_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeResponseUrl>.NativeClassPtr, 100663745);
			AuthorizationCodeResponseUrl.NativeMethodInfoPtr_set_Code_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeResponseUrl>.NativeClassPtr, 100663746);
			AuthorizationCodeResponseUrl.NativeMethodInfoPtr_get_State_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeResponseUrl>.NativeClassPtr, 100663747);
			AuthorizationCodeResponseUrl.NativeMethodInfoPtr_set_State_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeResponseUrl>.NativeClassPtr, 100663748);
			AuthorizationCodeResponseUrl.NativeMethodInfoPtr_get_Error_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeResponseUrl>.NativeClassPtr, 100663749);
			AuthorizationCodeResponseUrl.NativeMethodInfoPtr_set_Error_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeResponseUrl>.NativeClassPtr, 100663750);
			AuthorizationCodeResponseUrl.NativeMethodInfoPtr_get_ErrorDescription_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeResponseUrl>.NativeClassPtr, 100663751);
			AuthorizationCodeResponseUrl.NativeMethodInfoPtr_set_ErrorDescription_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeResponseUrl>.NativeClassPtr, 100663752);
			AuthorizationCodeResponseUrl.NativeMethodInfoPtr_get_ErrorUri_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeResponseUrl>.NativeClassPtr, 100663753);
			AuthorizationCodeResponseUrl.NativeMethodInfoPtr_set_ErrorUri_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeResponseUrl>.NativeClassPtr, 100663754);
			AuthorizationCodeResponseUrl.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeResponseUrl>.NativeClassPtr, 100663755);
			AuthorizationCodeResponseUrl.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeResponseUrl>.NativeClassPtr, 100663756);
			AuthorizationCodeResponseUrl.NativeMethodInfoPtr_InitFromDictionary_Private_Void_IDictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeResponseUrl>.NativeClassPtr, 100663757);
			AuthorizationCodeResponseUrl.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeResponseUrl>.NativeClassPtr, 100663758);
			AuthorizationCodeResponseUrl.NativeMethodInfoPtr__InitFromDictionary_b__22_0_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeResponseUrl>.NativeClassPtr, 100663759);
			AuthorizationCodeResponseUrl.NativeMethodInfoPtr__InitFromDictionary_b__22_1_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeResponseUrl>.NativeClassPtr, 100663760);
			AuthorizationCodeResponseUrl.NativeMethodInfoPtr__InitFromDictionary_b__22_2_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeResponseUrl>.NativeClassPtr, 100663761);
			AuthorizationCodeResponseUrl.NativeMethodInfoPtr__InitFromDictionary_b__22_3_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeResponseUrl>.NativeClassPtr, 100663762);
			AuthorizationCodeResponseUrl.NativeMethodInfoPtr__InitFromDictionary_b__22_4_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthorizationCodeResponseUrl>.NativeClassPtr, 100663763);
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x0000D734 File Offset: 0x0000B934
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x0000D76C File Offset: 0x0000B96C
		public unsafe string Code
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeResponseUrl.NativeMethodInfoPtr_get_Code_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeResponseUrl.NativeMethodInfoPtr_set_Code_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x0000D7B0 File Offset: 0x0000B9B0
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x0000D7E8 File Offset: 0x0000B9E8
		public unsafe string State
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeResponseUrl.NativeMethodInfoPtr_get_State_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeResponseUrl.NativeMethodInfoPtr_set_State_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x0000D82C File Offset: 0x0000BA2C
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x0000D864 File Offset: 0x0000BA64
		public unsafe string Error
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeResponseUrl.NativeMethodInfoPtr_get_Error_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeResponseUrl.NativeMethodInfoPtr_set_Error_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060001DA RID: 474 RVA: 0x0000D8A8 File Offset: 0x0000BAA8
		// (set) Token: 0x060001DB RID: 475 RVA: 0x0000D8E0 File Offset: 0x0000BAE0
		public unsafe string ErrorDescription
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeResponseUrl.NativeMethodInfoPtr_get_ErrorDescription_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeResponseUrl.NativeMethodInfoPtr_set_ErrorDescription_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060001DC RID: 476 RVA: 0x0000D924 File Offset: 0x0000BB24
		// (set) Token: 0x060001DD RID: 477 RVA: 0x0000D95C File Offset: 0x0000BB5C
		public unsafe string ErrorUri
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeResponseUrl.NativeMethodInfoPtr_get_ErrorUri_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeResponseUrl.NativeMethodInfoPtr_set_ErrorUri_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000D9A0 File Offset: 0x0000BBA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156707, XrefRangeEnd = 1156709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AuthorizationCodeResponseUrl(IDictionary<string, string> queryString)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthorizationCodeResponseUrl>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(queryString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeResponseUrl.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0000D9EC File Offset: 0x0000BBEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1156709, XrefRangeEnd = 1156730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AuthorizationCodeResponseUrl(string query)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthorizationCodeResponseUrl>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(query);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeResponseUrl.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000DA38 File Offset: 0x0000BC38
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1156805, RefRangeEnd = 1156808, XrefRangeStart = 1156730, XrefRangeEnd = 1156805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitFromDictionary(IDictionary<string, string> queryString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(queryString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeResponseUrl.NativeMethodInfoPtr_InitFromDictionary_Private_Void_IDictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000DA7C File Offset: 0x0000BC7C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AuthorizationCodeResponseUrl()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthorizationCodeResponseUrl>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeResponseUrl.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000DAB8 File Offset: 0x0000BCB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _InitFromDictionary_b__22_0(string v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(v);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeResponseUrl.NativeMethodInfoPtr__InitFromDictionary_b__22_0_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0000DAFC File Offset: 0x0000BCFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _InitFromDictionary_b__22_1(string v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(v);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeResponseUrl.NativeMethodInfoPtr__InitFromDictionary_b__22_1_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000DB40 File Offset: 0x0000BD40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _InitFromDictionary_b__22_2(string v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(v);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeResponseUrl.NativeMethodInfoPtr__InitFromDictionary_b__22_2_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000DB84 File Offset: 0x0000BD84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _InitFromDictionary_b__22_3(string v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(v);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeResponseUrl.NativeMethodInfoPtr__InitFromDictionary_b__22_3_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000DBC8 File Offset: 0x0000BDC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _InitFromDictionary_b__22_4(string v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(v);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthorizationCodeResponseUrl.NativeMethodInfoPtr__InitFromDictionary_b__22_4_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00002CF5 File Offset: 0x00000EF5
		public AuthorizationCodeResponseUrl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x0000DC0C File Offset: 0x0000BE0C
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x00002CFE File Offset: 0x00000EFE
		public unsafe string _Code_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeResponseUrl.NativeFieldInfoPtr__Code_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeResponseUrl.NativeFieldInfoPtr__Code_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001EA RID: 490 RVA: 0x0000DC34 File Offset: 0x0000BE34
		// (set) Token: 0x060001EB RID: 491 RVA: 0x00002D1D File Offset: 0x00000F1D
		public unsafe string _State_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeResponseUrl.NativeFieldInfoPtr__State_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeResponseUrl.NativeFieldInfoPtr__State_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060001EC RID: 492 RVA: 0x0000DC5C File Offset: 0x0000BE5C
		// (set) Token: 0x060001ED RID: 493 RVA: 0x00002D3C File Offset: 0x00000F3C
		public unsafe string _Error_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeResponseUrl.NativeFieldInfoPtr__Error_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeResponseUrl.NativeFieldInfoPtr__Error_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060001EE RID: 494 RVA: 0x0000DC84 File Offset: 0x0000BE84
		// (set) Token: 0x060001EF RID: 495 RVA: 0x00002D5B File Offset: 0x00000F5B
		public unsafe string _ErrorDescription_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeResponseUrl.NativeFieldInfoPtr__ErrorDescription_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeResponseUrl.NativeFieldInfoPtr__ErrorDescription_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x0000DCAC File Offset: 0x0000BEAC
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x00002D7A File Offset: 0x00000F7A
		public unsafe string _ErrorUri_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeResponseUrl.NativeFieldInfoPtr__ErrorUri_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthorizationCodeResponseUrl.NativeFieldInfoPtr__ErrorUri_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeFieldInfoPtr__Code_k__BackingField;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeFieldInfoPtr__State_k__BackingField;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeFieldInfoPtr__Error_k__BackingField;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeFieldInfoPtr__ErrorDescription_k__BackingField;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeFieldInfoPtr__ErrorUri_k__BackingField;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_get_Code_Public_get_String_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_set_Code_Public_set_Void_String_0;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_String_0;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr_set_State_Public_set_Void_String_0;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr_get_Error_Public_get_String_0;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr_set_Error_Public_set_Void_String_0;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr_get_ErrorDescription_Public_get_String_0;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeMethodInfoPtr_set_ErrorDescription_Public_set_Void_String_0;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr_get_ErrorUri_Public_get_String_0;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeMethodInfoPtr_set_ErrorUri_Public_set_Void_String_0;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_String_String_0;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeMethodInfoPtr_InitFromDictionary_Private_Void_IDictionary_2_String_String_0;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeMethodInfoPtr__InitFromDictionary_b__22_0_Private_Void_String_0;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeMethodInfoPtr__InitFromDictionary_b__22_1_Private_Void_String_0;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeMethodInfoPtr__InitFromDictionary_b__22_2_Private_Void_String_0;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeMethodInfoPtr__InitFromDictionary_b__22_3_Private_Void_String_0;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeMethodInfoPtr__InitFromDictionary_b__22_4_Private_Void_String_0;
	}
}
