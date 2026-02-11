using System;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace boardgames.menus.prompts
{
	// Token: 0x020001F8 RID: 504
	public class LoginPrompt : BasePrompt
	{
		// Token: 0x0600175C RID: 5980 RVA: 0x00069654 File Offset: 0x00067854
		// Note: this type is marked as 'beforefieldinit'.
		static LoginPrompt()
		{
			Il2CppClassPointerStore<LoginPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "LoginPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoginPrompt>.NativeClassPtr);
			LoginPrompt.NativeFieldInfoPtr__Result_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginPrompt>.NativeClassPtr, "<Result>k__BackingField");
			LoginPrompt.NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_ValueTuple_3_LoginPromptResult_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginPrompt>.NativeClassPtr, 100666717);
			LoginPrompt.NativeMethodInfoPtr_set_Result_Private_set_Void_ValueTuple_3_LoginPromptResult_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginPrompt>.NativeClassPtr, 100666718);
			LoginPrompt.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_ValueTuple_3_LoginPromptResult_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginPrompt>.NativeClassPtr, 100666719);
			LoginPrompt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginPrompt>.NativeClassPtr, 100666720);
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x0600175D RID: 5981 RVA: 0x000696E8 File Offset: 0x000678E8
		// (set) Token: 0x0600175E RID: 5982 RVA: 0x00069720 File Offset: 0x00067920
		public unsafe virtual ValueTuple<LoginPromptResult, string, string> Result
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoginPrompt.NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_ValueTuple_3_LoginPromptResult_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTuple<LoginPromptResult, string, string>(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525217, XrefRangeEnd = 525218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoginPrompt.NativeMethodInfoPtr_set_Result_Private_set_Void_ValueTuple_3_LoginPromptResult_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600175F RID: 5983 RVA: 0x00069768 File Offset: 0x00067968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525218, XrefRangeEnd = 525219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Resolve(ValueTuple<LoginPromptResult, string, string> userAndPass)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(userAndPass));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoginPrompt.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_ValueTuple_3_LoginPromptResult_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x000697B0 File Offset: 0x000679B0
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 520201, RefRangeEnd = 520229, XrefRangeStart = 520201, XrefRangeEnd = 520229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoginPrompt()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoginPrompt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoginPrompt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001761 RID: 5985 RVA: 0x0000D0C2 File Offset: 0x0000B2C2
		public LoginPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06001762 RID: 5986 RVA: 0x000697EC File Offset: 0x000679EC
		// (set) Token: 0x06001763 RID: 5987 RVA: 0x0000D0CB File Offset: 0x0000B2CB
		public ValueTuple<LoginPromptResult, string, string> _Result_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginPrompt.NativeFieldInfoPtr__Result_k__BackingField);
				return new ValueTuple<LoginPromptResult, string, string>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<LoginPromptResult, string, string>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginPrompt.NativeFieldInfoPtr__Result_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<LoginPromptResult, string, string>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000E95 RID: 3733
		private static readonly IntPtr NativeFieldInfoPtr__Result_k__BackingField;

		// Token: 0x04000E96 RID: 3734
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_ValueTuple_3_LoginPromptResult_String_String_0;

		// Token: 0x04000E97 RID: 3735
		private static readonly IntPtr NativeMethodInfoPtr_set_Result_Private_set_Void_ValueTuple_3_LoginPromptResult_String_String_0;

		// Token: 0x04000E98 RID: 3736
		private static readonly IntPtr NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_ValueTuple_3_LoginPromptResult_String_String_0;

		// Token: 0x04000E99 RID: 3737
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
