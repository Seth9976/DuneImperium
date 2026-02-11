using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text.RegularExpressions;
using UnityEngine;

namespace dwd.core.ui.ugui.inputfield
{
	// Token: 0x0200000F RID: 15
	public class FilterInputWithRegex : MonoBehaviour
	{
		// Token: 0x060000C2 RID: 194 RVA: 0x00004DD8 File Offset: 0x00002FD8
		// Note: this type is marked as 'beforefieldinit'.
		static FilterInputWithRegex()
		{
			Il2CppClassPointerStore<FilterInputWithRegex>.NativeClassPtr = IL2CPP.GetIl2CppClass("console.dll", "dwd.core.ui.ugui.inputfield", "FilterInputWithRegex");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterInputWithRegex>.NativeClassPtr);
			FilterInputWithRegex.NativeFieldInfoPtr_regexValidation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterInputWithRegex>.NativeClassPtr, "regexValidation");
			FilterInputWithRegex.NativeFieldInfoPtr_pattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterInputWithRegex>.NativeClassPtr, "pattern");
			FilterInputWithRegex.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterInputWithRegex>.NativeClassPtr, 100663361);
			FilterInputWithRegex.NativeMethodInfoPtr_validate_Private_Char_String_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterInputWithRegex>.NativeClassPtr, 100663362);
			FilterInputWithRegex.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterInputWithRegex>.NativeClassPtr, 100663363);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00004E6C File Offset: 0x0000306C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255988, XrefRangeEnd = 1256007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterInputWithRegex.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00004EA0 File Offset: 0x000030A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256007, XrefRangeEnd = 1256015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char validate(string input, int index, char newCharacter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newCharacter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterInputWithRegex.NativeMethodInfoPtr_validate_Private_Char_String_Int32_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00004F0C File Offset: 0x0000310C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256015, XrefRangeEnd = 1256020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FilterInputWithRegex()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterInputWithRegex>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterInputWithRegex.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000276F File Offset: 0x0000096F
		public FilterInputWithRegex(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x00004F48 File Offset: 0x00003148
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x00002778 File Offset: 0x00000978
		public unsafe string regexValidation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterInputWithRegex.NativeFieldInfoPtr_regexValidation);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterInputWithRegex.NativeFieldInfoPtr_regexValidation), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00004F70 File Offset: 0x00003170
		// (set) Token: 0x060000CA RID: 202 RVA: 0x00002797 File Offset: 0x00000997
		public unsafe Regex pattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterInputWithRegex.NativeFieldInfoPtr_pattern);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Regex>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterInputWithRegex.NativeFieldInfoPtr_pattern), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeFieldInfoPtr_regexValidation;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeFieldInfoPtr_pattern;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_validate_Private_Char_String_Int32_Char_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
