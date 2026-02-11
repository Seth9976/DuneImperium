using System;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.menus.prompts
{
	// Token: 0x020001EF RID: 495
	public class ForgotPasswordPrompt : BasePrompt
	{
		// Token: 0x06001722 RID: 5922 RVA: 0x000689F0 File Offset: 0x00066BF0
		// Note: this type is marked as 'beforefieldinit'.
		static ForgotPasswordPrompt()
		{
			Il2CppClassPointerStore<ForgotPasswordPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "ForgotPasswordPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForgotPasswordPrompt>.NativeClassPtr);
			ForgotPasswordPrompt.NativeFieldInfoPtr__Result_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgotPasswordPrompt>.NativeClassPtr, "<Result>k__BackingField");
			ForgotPasswordPrompt.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgotPasswordPrompt>.NativeClassPtr, 100666688);
			ForgotPasswordPrompt.NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgotPasswordPrompt>.NativeClassPtr, 100666689);
			ForgotPasswordPrompt.NativeMethodInfoPtr_set_Result_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgotPasswordPrompt>.NativeClassPtr, 100666690);
			ForgotPasswordPrompt.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgotPasswordPrompt>.NativeClassPtr, 100666691);
			ForgotPasswordPrompt.NativeMethodInfoPtr_Dismiss_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgotPasswordPrompt>.NativeClassPtr, 100666692);
		}

		// Token: 0x06001723 RID: 5923 RVA: 0x00068A98 File Offset: 0x00066C98
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 524963, RefRangeEnd = 524967, XrefRangeStart = 524963, XrefRangeEnd = 524967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ForgotPasswordPrompt(string emailAddress)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForgotPasswordPrompt>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(emailAddress);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForgotPasswordPrompt.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06001724 RID: 5924 RVA: 0x00068AE4 File Offset: 0x00066CE4
		// (set) Token: 0x06001725 RID: 5925 RVA: 0x00068B1C File Offset: 0x00066D1C
		public unsafe virtual string Result
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForgotPasswordPrompt.NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForgotPasswordPrompt.NativeMethodInfoPtr_set_Result_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001726 RID: 5926 RVA: 0x00068B60 File Offset: 0x00066D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Resolve(string result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForgotPasswordPrompt.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001727 RID: 5927 RVA: 0x00068BA4 File Offset: 0x00066DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dismiss()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForgotPasswordPrompt.NativeMethodInfoPtr_Dismiss_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001728 RID: 5928 RVA: 0x0000CF3C File Offset: 0x0000B13C
		public ForgotPasswordPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06001729 RID: 5929 RVA: 0x00068BD8 File Offset: 0x00066DD8
		// (set) Token: 0x0600172A RID: 5930 RVA: 0x0000CF45 File Offset: 0x0000B145
		public unsafe string _Result_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForgotPasswordPrompt.NativeFieldInfoPtr__Result_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForgotPasswordPrompt.NativeFieldInfoPtr__Result_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000E67 RID: 3687
		private static readonly IntPtr NativeFieldInfoPtr__Result_k__BackingField;

		// Token: 0x04000E68 RID: 3688
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000E69 RID: 3689
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000E6A RID: 3690
		private static readonly IntPtr NativeMethodInfoPtr_set_Result_Private_set_Void_String_0;

		// Token: 0x04000E6B RID: 3691
		private static readonly IntPtr NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x04000E6C RID: 3692
		private static readonly IntPtr NativeMethodInfoPtr_Dismiss_Public_Virtual_Final_New_Void_0;
	}
}
