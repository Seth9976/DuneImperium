using System;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.menus.prompts
{
	// Token: 0x020001E2 RID: 482
	public class ChangePasswordPrompt : BasePrompt
	{
		// Token: 0x0600168D RID: 5773 RVA: 0x0006664C File Offset: 0x0006484C
		// Note: this type is marked as 'beforefieldinit'.
		static ChangePasswordPrompt()
		{
			Il2CppClassPointerStore<ChangePasswordPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "ChangePasswordPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChangePasswordPrompt>.NativeClassPtr);
			ChangePasswordPrompt.NativeFieldInfoPtr__Result_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangePasswordPrompt>.NativeClassPtr, "<Result>k__BackingField");
			ChangePasswordPrompt.NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangePasswordPrompt>.NativeClassPtr, 100666601);
			ChangePasswordPrompt.NativeMethodInfoPtr_set_Result_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangePasswordPrompt>.NativeClassPtr, 100666602);
			ChangePasswordPrompt.NativeMethodInfoPtr_Dismiss_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangePasswordPrompt>.NativeClassPtr, 100666603);
			ChangePasswordPrompt.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangePasswordPrompt>.NativeClassPtr, 100666604);
			ChangePasswordPrompt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangePasswordPrompt>.NativeClassPtr, 100666605);
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x0600168E RID: 5774 RVA: 0x000666F4 File Offset: 0x000648F4
		// (set) Token: 0x0600168F RID: 5775 RVA: 0x0006672C File Offset: 0x0006492C
		public unsafe virtual string Result
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangePasswordPrompt.NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangePasswordPrompt.NativeMethodInfoPtr_set_Result_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x00066770 File Offset: 0x00064970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dismiss()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangePasswordPrompt.NativeMethodInfoPtr_Dismiss_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001691 RID: 5777 RVA: 0x000667A4 File Offset: 0x000649A4
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangePasswordPrompt.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x000667E8 File Offset: 0x000649E8
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 520201, RefRangeEnd = 520229, XrefRangeStart = 520201, XrefRangeEnd = 520229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChangePasswordPrompt()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChangePasswordPrompt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChangePasswordPrompt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x0000CBD2 File Offset: 0x0000ADD2
		public ChangePasswordPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06001694 RID: 5780 RVA: 0x00066824 File Offset: 0x00064A24
		// (set) Token: 0x06001695 RID: 5781 RVA: 0x0000CBDB File Offset: 0x0000ADDB
		public unsafe string _Result_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangePasswordPrompt.NativeFieldInfoPtr__Result_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChangePasswordPrompt.NativeFieldInfoPtr__Result_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000DFD RID: 3581
		private static readonly IntPtr NativeFieldInfoPtr__Result_k__BackingField;

		// Token: 0x04000DFE RID: 3582
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000DFF RID: 3583
		private static readonly IntPtr NativeMethodInfoPtr_set_Result_Private_set_Void_String_0;

		// Token: 0x04000E00 RID: 3584
		private static readonly IntPtr NativeMethodInfoPtr_Dismiss_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000E01 RID: 3585
		private static readonly IntPtr NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x04000E02 RID: 3586
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
