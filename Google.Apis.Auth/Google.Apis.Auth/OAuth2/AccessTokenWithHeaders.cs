using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Google.Apis.Auth.OAuth2
{
	// Token: 0x02000007 RID: 7
	public sealed class AccessTokenWithHeaders : Object
	{
		// Token: 0x06000032 RID: 50 RVA: 0x00007CDC File Offset: 0x00005EDC
		// Note: this type is marked as 'beforefieldinit'.
		static AccessTokenWithHeaders()
		{
			Il2CppClassPointerStore<AccessTokenWithHeaders>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Auth.dll", "Google.Apis.Auth.OAuth2", "AccessTokenWithHeaders");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AccessTokenWithHeaders>.NativeClassPtr);
			AccessTokenWithHeaders.NativeFieldInfoPtr_QuotaProjectHeaderName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessTokenWithHeaders>.NativeClassPtr, "QuotaProjectHeaderName");
			AccessTokenWithHeaders.NativeFieldInfoPtr_s_emptyHeaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessTokenWithHeaders>.NativeClassPtr, "s_emptyHeaders");
			AccessTokenWithHeaders.NativeFieldInfoPtr__AccessToken_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessTokenWithHeaders>.NativeClassPtr, "<AccessToken>k__BackingField");
			AccessTokenWithHeaders.NativeFieldInfoPtr__Headers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessTokenWithHeaders>.NativeClassPtr, "<Headers>k__BackingField");
			AccessTokenWithHeaders.NativeMethodInfoPtr__ctor_Internal_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessTokenWithHeaders>.NativeClassPtr, 100663403);
			AccessTokenWithHeaders.NativeMethodInfoPtr_get_AccessToken_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessTokenWithHeaders>.NativeClassPtr, 100663404);
			AccessTokenWithHeaders.NativeMethodInfoPtr_get_Headers_Public_get_IReadOnlyDictionary_2_String_IReadOnlyList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessTokenWithHeaders>.NativeClassPtr, 100663405);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00007D98 File Offset: 0x00005F98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1152728, RefRangeEnd = 1152730, XrefRangeStart = 1152690, XrefRangeEnd = 1152728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AccessTokenWithHeaders(string token, string quotaProject = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AccessTokenWithHeaders>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(quotaProject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccessTokenWithHeaders.NativeMethodInfoPtr__ctor_Internal_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00007DF8 File Offset: 0x00005FF8
		public unsafe string AccessToken
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccessTokenWithHeaders.NativeMethodInfoPtr_get_AccessToken_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00007E30 File Offset: 0x00006030
		public unsafe IReadOnlyDictionary<string, IReadOnlyList<string>> Headers
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccessTokenWithHeaders.NativeMethodInfoPtr_get_Headers_Public_get_IReadOnlyDictionary_2_String_IReadOnlyList_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyDictionary<string, IReadOnlyList<string>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000021BA File Offset: 0x000003BA
		public AccessTokenWithHeaders(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00007E70 File Offset: 0x00006070
		// (set) Token: 0x06000038 RID: 56 RVA: 0x000021C3 File Offset: 0x000003C3
		public unsafe static string QuotaProjectHeaderName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AccessTokenWithHeaders.NativeFieldInfoPtr_QuotaProjectHeaderName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AccessTokenWithHeaders.NativeFieldInfoPtr_QuotaProjectHeaderName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00007E90 File Offset: 0x00006090
		// (set) Token: 0x0600003A RID: 58 RVA: 0x000021D5 File Offset: 0x000003D5
		public unsafe static IReadOnlyDictionary<string, IReadOnlyList<string>> s_emptyHeaders
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AccessTokenWithHeaders.NativeFieldInfoPtr_s_emptyHeaders, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyDictionary<string, IReadOnlyList<string>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AccessTokenWithHeaders.NativeFieldInfoPtr_s_emptyHeaders, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00007EB8 File Offset: 0x000060B8
		// (set) Token: 0x0600003C RID: 60 RVA: 0x000021E7 File Offset: 0x000003E7
		public unsafe string _AccessToken_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessTokenWithHeaders.NativeFieldInfoPtr__AccessToken_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessTokenWithHeaders.NativeFieldInfoPtr__AccessToken_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00007EE0 File Offset: 0x000060E0
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00002206 File Offset: 0x00000406
		public unsafe IReadOnlyDictionary<string, IReadOnlyList<string>> _Headers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessTokenWithHeaders.NativeFieldInfoPtr__Headers_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyDictionary<string, IReadOnlyList<string>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessTokenWithHeaders.NativeFieldInfoPtr__Headers_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeFieldInfoPtr_QuotaProjectHeaderName;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeFieldInfoPtr_s_emptyHeaders;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeFieldInfoPtr__AccessToken_k__BackingField;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeFieldInfoPtr__Headers_k__BackingField;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_get_AccessToken_Public_get_String_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_get_Headers_Public_get_IReadOnlyDictionary_2_String_IReadOnlyList_1_String_0;
	}
}
