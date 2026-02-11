using System;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.ui.prompt.prompts
{
	// Token: 0x02000029 RID: 41
	public class TextPrompt : Object
	{
		// Token: 0x0600018A RID: 394 RVA: 0x00008A40 File Offset: 0x00006C40
		// Note: this type is marked as 'beforefieldinit'.
		static TextPrompt()
		{
			Il2CppClassPointerStore<TextPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.prompts", "TextPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextPrompt>.NativeClassPtr);
			TextPrompt.NativeFieldInfoPtr__Resolved_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextPrompt>.NativeClassPtr, "<Resolved>k__BackingField");
			TextPrompt.NativeFieldInfoPtr__Result_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextPrompt>.NativeClassPtr, "<Result>k__BackingField");
			TextPrompt.NativeFieldInfoPtr_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextPrompt>.NativeClassPtr, "Message");
			TextPrompt.NativeFieldInfoPtr_SubmitLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextPrompt>.NativeClassPtr, "SubmitLabel");
			TextPrompt.NativeFieldInfoPtr_PlaceholderInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextPrompt>.NativeClassPtr, "PlaceholderInput");
			TextPrompt.NativeFieldInfoPtr_InitialInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextPrompt>.NativeClassPtr, "InitialInput");
			TextPrompt.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextPrompt>.NativeClassPtr, "Title");
			TextPrompt.NativeFieldInfoPtr_TextValidateFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextPrompt>.NativeClassPtr, "TextValidateFunc");
			TextPrompt.NativeMethodInfoPtr_get_Resolved_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextPrompt>.NativeClassPtr, 100663442);
			TextPrompt.NativeMethodInfoPtr_set_Resolved_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextPrompt>.NativeClassPtr, 100663443);
			TextPrompt.NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextPrompt>.NativeClassPtr, 100663444);
			TextPrompt.NativeMethodInfoPtr_set_Result_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextPrompt>.NativeClassPtr, 100663445);
			TextPrompt.NativeMethodInfoPtr__ctor_Public_Void_LocalizedString_LocalizedString_LocalizedString_LocalizedString_Func_2_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextPrompt>.NativeClassPtr, 100663446);
			TextPrompt.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextPrompt>.NativeClassPtr, 100663447);
			TextPrompt.NativeMethodInfoPtr_IsTextValid_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextPrompt>.NativeClassPtr, 100663448);
			TextPrompt.NativeMethodInfoPtr_isTextValid_Protected_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextPrompt>.NativeClassPtr, 100663449);
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600018B RID: 395 RVA: 0x00008BB0 File Offset: 0x00006DB0
		// (set) Token: 0x0600018C RID: 396 RVA: 0x00008BEC File Offset: 0x00006DEC
		public unsafe virtual bool Resolved
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextPrompt.NativeMethodInfoPtr_get_Resolved_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288083, RefRangeEnd = 288084, XrefRangeStart = 288083, XrefRangeEnd = 288084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextPrompt.NativeMethodInfoPtr_set_Resolved_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00008C2C File Offset: 0x00006E2C
		// (set) Token: 0x0600018E RID: 398 RVA: 0x00008C64 File Offset: 0x00006E64
		public unsafe virtual string Result
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextPrompt.NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextPrompt.NativeMethodInfoPtr_set_Result_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00008CA8 File Offset: 0x00006EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1213847, XrefRangeEnd = 1213854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextPrompt(LocalizedString message, LocalizedString submitLabel, LocalizedString placeholderInput = null, LocalizedString title = null, Func<string, bool> textValidateFunc = null, string initialInput = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextPrompt>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(submitLabel);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(placeholderInput);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(title);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(textValidateFunc);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(initialInput);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextPrompt.NativeMethodInfoPtr__ctor_Public_Void_LocalizedString_LocalizedString_LocalizedString_LocalizedString_Func_2_String_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00008D50 File Offset: 0x00006F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1213854, XrefRangeEnd = 1213857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Resolve(string result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextPrompt.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00008D94 File Offset: 0x00006F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1213857, XrefRangeEnd = 1213858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTextValid(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextPrompt.NativeMethodInfoPtr_IsTextValid_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00008DE4 File Offset: 0x00006FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool isTextValid(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextPrompt.NativeMethodInfoPtr_isTextValid_Protected_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00002C7D File Offset: 0x00000E7D
		public TextPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000194 RID: 404 RVA: 0x00008E34 File Offset: 0x00007034
		// (set) Token: 0x06000195 RID: 405 RVA: 0x00002C86 File Offset: 0x00000E86
		public unsafe bool _Resolved_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextPrompt.NativeFieldInfoPtr__Resolved_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextPrompt.NativeFieldInfoPtr__Resolved_k__BackingField)) = value;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000196 RID: 406 RVA: 0x00008E5C File Offset: 0x0000705C
		// (set) Token: 0x06000197 RID: 407 RVA: 0x00002CA1 File Offset: 0x00000EA1
		public unsafe string _Result_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextPrompt.NativeFieldInfoPtr__Result_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextPrompt.NativeFieldInfoPtr__Result_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000198 RID: 408 RVA: 0x00008E84 File Offset: 0x00007084
		// (set) Token: 0x06000199 RID: 409 RVA: 0x00002CC0 File Offset: 0x00000EC0
		public unsafe LocalizedString Message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextPrompt.NativeFieldInfoPtr_Message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextPrompt.NativeFieldInfoPtr_Message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00008EB4 File Offset: 0x000070B4
		// (set) Token: 0x0600019B RID: 411 RVA: 0x00002CDF File Offset: 0x00000EDF
		public unsafe LocalizedString SubmitLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextPrompt.NativeFieldInfoPtr_SubmitLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextPrompt.NativeFieldInfoPtr_SubmitLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600019C RID: 412 RVA: 0x00008EE4 File Offset: 0x000070E4
		// (set) Token: 0x0600019D RID: 413 RVA: 0x00002CFE File Offset: 0x00000EFE
		public unsafe LocalizedString PlaceholderInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextPrompt.NativeFieldInfoPtr_PlaceholderInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextPrompt.NativeFieldInfoPtr_PlaceholderInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600019E RID: 414 RVA: 0x00008F14 File Offset: 0x00007114
		// (set) Token: 0x0600019F RID: 415 RVA: 0x00002D1D File Offset: 0x00000F1D
		public unsafe string InitialInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextPrompt.NativeFieldInfoPtr_InitialInput);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextPrompt.NativeFieldInfoPtr_InitialInput), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x00008F3C File Offset: 0x0000713C
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x00002D3C File Offset: 0x00000F3C
		public unsafe LocalizedString Title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextPrompt.NativeFieldInfoPtr_Title);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextPrompt.NativeFieldInfoPtr_Title), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x00008F6C File Offset: 0x0000716C
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x00002D5B File Offset: 0x00000F5B
		public unsafe Func<string, bool> TextValidateFunc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextPrompt.NativeFieldInfoPtr_TextValidateFunc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextPrompt.NativeFieldInfoPtr_TextValidateFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeFieldInfoPtr__Resolved_k__BackingField;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeFieldInfoPtr__Result_k__BackingField;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeFieldInfoPtr_Message;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeFieldInfoPtr_SubmitLabel;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeFieldInfoPtr_PlaceholderInput;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeFieldInfoPtr_InitialInput;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeFieldInfoPtr_Title;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeFieldInfoPtr_TextValidateFunc;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeMethodInfoPtr_get_Resolved_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeMethodInfoPtr_set_Resolved_Protected_set_Void_Boolean_0;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr_set_Result_Protected_set_Void_String_0;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LocalizedString_LocalizedString_LocalizedString_LocalizedString_Func_2_String_Boolean_String_0;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr_IsTextValid_Public_Boolean_String_0;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr_isTextValid_Protected_Boolean_String_0;
	}
}
