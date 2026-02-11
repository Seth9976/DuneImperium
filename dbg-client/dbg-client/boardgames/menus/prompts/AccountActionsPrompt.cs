using System;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.menus.prompts
{
	// Token: 0x020001C2 RID: 450
	public class AccountActionsPrompt : BasePrompt
	{
		// Token: 0x0600143C RID: 5180 RVA: 0x0005EDE0 File Offset: 0x0005CFE0
		// Note: this type is marked as 'beforefieldinit'.
		static AccountActionsPrompt()
		{
			Il2CppClassPointerStore<AccountActionsPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "AccountActionsPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AccountActionsPrompt>.NativeClassPtr);
			AccountActionsPrompt.NativeFieldInfoPtr__Result_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountActionsPrompt>.NativeClassPtr, "<Result>k__BackingField");
			AccountActionsPrompt.NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_AccountActionsPromptResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountActionsPrompt>.NativeClassPtr, 100666258);
			AccountActionsPrompt.NativeMethodInfoPtr_set_Result_Private_set_Void_AccountActionsPromptResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountActionsPrompt>.NativeClassPtr, 100666259);
			AccountActionsPrompt.NativeMethodInfoPtr_Dismiss_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountActionsPrompt>.NativeClassPtr, 100666260);
			AccountActionsPrompt.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_AccountActionsPromptResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountActionsPrompt>.NativeClassPtr, 100666261);
			AccountActionsPrompt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountActionsPrompt>.NativeClassPtr, 100666262);
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x0600143D RID: 5181 RVA: 0x0005EE88 File Offset: 0x0005D088
		// (set) Token: 0x0600143E RID: 5182 RVA: 0x0005EEC4 File Offset: 0x0005D0C4
		public unsafe virtual AccountActionsPromptResult Result
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountActionsPrompt.NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_AccountActionsPromptResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 287294, RefRangeEnd = 287297, XrefRangeStart = 287294, XrefRangeEnd = 287297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountActionsPrompt.NativeMethodInfoPtr_set_Result_Private_set_Void_AccountActionsPromptResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x0005EF04 File Offset: 0x0005D104
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 520196, RefRangeEnd = 520197, XrefRangeStart = 520196, XrefRangeEnd = 520196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dismiss()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountActionsPrompt.NativeMethodInfoPtr_Dismiss_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x0005EF38 File Offset: 0x0005D138
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 520197, RefRangeEnd = 520200, XrefRangeStart = 520197, XrefRangeEnd = 520197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Resolve(AccountActionsPromptResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountActionsPrompt.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_AccountActionsPromptResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x0005EF78 File Offset: 0x0005D178
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 520201, RefRangeEnd = 520229, XrefRangeStart = 520200, XrefRangeEnd = 520201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AccountActionsPrompt()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AccountActionsPrompt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountActionsPrompt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x0000B88D File Offset: 0x00009A8D
		public AccountActionsPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06001443 RID: 5187 RVA: 0x0005EFB4 File Offset: 0x0005D1B4
		// (set) Token: 0x06001444 RID: 5188 RVA: 0x0000B896 File Offset: 0x00009A96
		public unsafe AccountActionsPromptResult _Result_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountActionsPrompt.NativeFieldInfoPtr__Result_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccountActionsPrompt.NativeFieldInfoPtr__Result_k__BackingField)) = value;
			}
		}

		// Token: 0x04000C7F RID: 3199
		private static readonly IntPtr NativeFieldInfoPtr__Result_k__BackingField;

		// Token: 0x04000C80 RID: 3200
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_AccountActionsPromptResult_0;

		// Token: 0x04000C81 RID: 3201
		private static readonly IntPtr NativeMethodInfoPtr_set_Result_Private_set_Void_AccountActionsPromptResult_0;

		// Token: 0x04000C82 RID: 3202
		private static readonly IntPtr NativeMethodInfoPtr_Dismiss_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000C83 RID: 3203
		private static readonly IntPtr NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_AccountActionsPromptResult_0;

		// Token: 0x04000C84 RID: 3204
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
