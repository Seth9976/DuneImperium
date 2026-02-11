using System;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.ui.prompt.prompts
{
	// Token: 0x0200001A RID: 26
	public class DismissableTextPrompt : TextPrompt
	{
		// Token: 0x06000133 RID: 307 RVA: 0x000078F4 File Offset: 0x00005AF4
		// Note: this type is marked as 'beforefieldinit'.
		static DismissableTextPrompt()
		{
			Il2CppClassPointerStore<DismissableTextPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.prompts", "DismissableTextPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DismissableTextPrompt>.NativeClassPtr);
			DismissableTextPrompt.NativeFieldInfoPtr_CancelLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DismissableTextPrompt>.NativeClassPtr, "CancelLabel");
			DismissableTextPrompt.NativeMethodInfoPtr_get_WasDismissed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DismissableTextPrompt>.NativeClassPtr, 100663406);
			DismissableTextPrompt.NativeMethodInfoPtr__ctor_Public_Void_LocalizedString_LocalizedString_LocalizedString_LocalizedString_LocalizedString_Func_2_String_Boolean_LocalizedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DismissableTextPrompt>.NativeClassPtr, 100663407);
			DismissableTextPrompt.NativeMethodInfoPtr_Dismiss_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DismissableTextPrompt>.NativeClassPtr, 100663408);
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00007974 File Offset: 0x00005B74
		public unsafe bool WasDismissed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DismissableTextPrompt.NativeMethodInfoPtr_get_WasDismissed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000135 RID: 309 RVA: 0x000079B0 File Offset: 0x00005BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1213716, XrefRangeEnd = 1213725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DismissableTextPrompt(LocalizedString message, LocalizedString cancelLabel, LocalizedString submitLabel, LocalizedString placeholderInput = null, LocalizedString title = null, Func<string, bool> textValidateFunc = null, LocalizedString initialInput = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DismissableTextPrompt>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cancelLabel);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(submitLabel);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(placeholderInput);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(title);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(textValidateFunc);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(initialInput);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DismissableTextPrompt.NativeMethodInfoPtr__ctor_Public_Void_LocalizedString_LocalizedString_LocalizedString_LocalizedString_LocalizedString_Func_2_String_Boolean_LocalizedString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00007A6C File Offset: 0x00005C6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 478427, RefRangeEnd = 478428, XrefRangeStart = 478427, XrefRangeEnd = 478428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dismiss()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DismissableTextPrompt.NativeMethodInfoPtr_Dismiss_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0000298D File Offset: 0x00000B8D
		public DismissableTextPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000138 RID: 312 RVA: 0x00007AA0 File Offset: 0x00005CA0
		// (set) Token: 0x06000139 RID: 313 RVA: 0x00002996 File Offset: 0x00000B96
		public unsafe LocalizedString CancelLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DismissableTextPrompt.NativeFieldInfoPtr_CancelLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DismissableTextPrompt.NativeFieldInfoPtr_CancelLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeFieldInfoPtr_CancelLabel;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_get_WasDismissed_Public_get_Boolean_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LocalizedString_LocalizedString_LocalizedString_LocalizedString_LocalizedString_Func_2_String_Boolean_LocalizedString_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_Dismiss_Public_Virtual_Final_New_Void_0;
	}
}
