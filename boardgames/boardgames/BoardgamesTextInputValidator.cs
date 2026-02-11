using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;

namespace boardgames
{
	// Token: 0x020000FD RID: 253
	public class BoardgamesTextInputValidator : TMP_InputValidator
	{
		// Token: 0x06000C1C RID: 3100 RVA: 0x00037980 File Offset: 0x00035B80
		// Note: this type is marked as 'beforefieldinit'.
		static BoardgamesTextInputValidator()
		{
			Il2CppClassPointerStore<BoardgamesTextInputValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames", "BoardgamesTextInputValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoardgamesTextInputValidator>.NativeClassPtr);
			BoardgamesTextInputValidator.NativeFieldInfoPtr_validCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoardgamesTextInputValidator>.NativeClassPtr, "validCharacters");
			BoardgamesTextInputValidator.NativeMethodInfoPtr_Validate_Public_Virtual_Char_byref_String_byref_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoardgamesTextInputValidator>.NativeClassPtr, 100665231);
			BoardgamesTextInputValidator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoardgamesTextInputValidator>.NativeClassPtr, 100665232);
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x000379EC File Offset: 0x00035BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995344, XrefRangeEnd = 995363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override char Validate(ref string text, ref int pos, char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.ManagedStringToIl2Cpp(text);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ch;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoardgamesTextInputValidator.NativeMethodInfoPtr_Validate_Public_Virtual_Char_byref_String_byref_Int32_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			text = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x00037A70 File Offset: 0x00035C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoardgamesTextInputValidator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoardgamesTextInputValidator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoardgamesTextInputValidator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x00007926 File Offset: 0x00005B26
		public BoardgamesTextInputValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000C20 RID: 3104 RVA: 0x00037AAC File Offset: 0x00035CAC
		// (set) Token: 0x06000C21 RID: 3105 RVA: 0x0000792F File Offset: 0x00005B2F
		public unsafe TextAsset validCharacters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoardgamesTextInputValidator.NativeFieldInfoPtr_validCharacters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoardgamesTextInputValidator.NativeFieldInfoPtr_validCharacters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000775 RID: 1909
		private static readonly IntPtr NativeFieldInfoPtr_validCharacters;

		// Token: 0x04000776 RID: 1910
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Public_Virtual_Char_byref_String_byref_Int32_Char_0;

		// Token: 0x04000777 RID: 1911
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
