using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Security.Interface
{
	// Token: 0x02000023 RID: 35
	public class ValidationResult : Object
	{
		// Token: 0x0600021B RID: 539 RVA: 0x0000C390 File Offset: 0x0000A590
		// Note: this type is marked as 'beforefieldinit'.
		static ValidationResult()
		{
			Il2CppClassPointerStore<ValidationResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Interface", "ValidationResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidationResult>.NativeClassPtr);
			ValidationResult.NativeFieldInfoPtr_trusted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationResult>.NativeClassPtr, "trusted");
			ValidationResult.NativeFieldInfoPtr_user_denied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationResult>.NativeClassPtr, "user_denied");
			ValidationResult.NativeFieldInfoPtr_error_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationResult>.NativeClassPtr, "error_code");
			ValidationResult.NativeFieldInfoPtr_policy_errors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationResult>.NativeClassPtr, "policy_errors");
			ValidationResult.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Int32_Nullable_1_MonoSslPolicyErrors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationResult>.NativeClassPtr, 100663620);
			ValidationResult.NativeMethodInfoPtr_get_Trusted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationResult>.NativeClassPtr, 100663621);
			ValidationResult.NativeMethodInfoPtr_get_UserDenied_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationResult>.NativeClassPtr, 100663622);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0000C44C File Offset: 0x0000A64C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1149362, RefRangeEnd = 1149364, XrefRangeStart = 1149361, XrefRangeEnd = 1149362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidationResult(bool trusted, bool user_denied, int error_code, Nullable<MonoSslPolicyErrors> policy_errors)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValidationResult>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref trusted;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref user_denied;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref error_code;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(policy_errors));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidationResult.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Int32_Nullable_1_MonoSslPolicyErrors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600021D RID: 541 RVA: 0x0000C4C8 File Offset: 0x0000A6C8
		public unsafe bool Trusted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidationResult.NativeMethodInfoPtr_get_Trusted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600021E RID: 542 RVA: 0x0000C504 File Offset: 0x0000A704
		public unsafe bool UserDenied
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidationResult.NativeMethodInfoPtr_get_UserDenied_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00002E1B File Offset: 0x0000101B
		public ValidationResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000220 RID: 544 RVA: 0x0000C540 File Offset: 0x0000A740
		// (set) Token: 0x06000221 RID: 545 RVA: 0x00002E24 File Offset: 0x00001024
		public unsafe bool trusted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationResult.NativeFieldInfoPtr_trusted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationResult.NativeFieldInfoPtr_trusted)) = value;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000222 RID: 546 RVA: 0x0000C568 File Offset: 0x0000A768
		// (set) Token: 0x06000223 RID: 547 RVA: 0x00002E3F File Offset: 0x0000103F
		public unsafe bool user_denied
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationResult.NativeFieldInfoPtr_user_denied);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationResult.NativeFieldInfoPtr_user_denied)) = value;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000224 RID: 548 RVA: 0x0000C590 File Offset: 0x0000A790
		// (set) Token: 0x06000225 RID: 549 RVA: 0x00002E5A File Offset: 0x0000105A
		public unsafe int error_code
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationResult.NativeFieldInfoPtr_error_code);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationResult.NativeFieldInfoPtr_error_code)) = value;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000226 RID: 550 RVA: 0x0000C5B8 File Offset: 0x0000A7B8
		// (set) Token: 0x06000227 RID: 551 RVA: 0x00002E75 File Offset: 0x00001075
		public Nullable<MonoSslPolicyErrors> policy_errors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationResult.NativeFieldInfoPtr_policy_errors);
				return new Nullable<MonoSslPolicyErrors>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<MonoSslPolicyErrors>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationResult.NativeFieldInfoPtr_policy_errors), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<MonoSslPolicyErrors>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeFieldInfoPtr_trusted;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeFieldInfoPtr_user_denied;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeFieldInfoPtr_error_code;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeFieldInfoPtr_policy_errors;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Int32_Nullable_1_MonoSslPolicyErrors_0;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeMethodInfoPtr_get_Trusted_Public_get_Boolean_0;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeMethodInfoPtr_get_UserDenied_Public_get_Boolean_0;
	}
}
