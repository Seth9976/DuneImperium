using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;

namespace dwd.core.ui.ugui.inputfield
{
	// Token: 0x0200009D RID: 157
	public class Utf16BmpValidator : MonoBehaviour
	{
		// Token: 0x0600079F RID: 1951 RVA: 0x00028FDC File Offset: 0x000271DC
		// Note: this type is marked as 'beforefieldinit'.
		static Utf16BmpValidator()
		{
			Il2CppClassPointerStore<Utf16BmpValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "dwd.core.ui.ugui.inputfield", "Utf16BmpValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Utf16BmpValidator>.NativeClassPtr);
			Utf16BmpValidator.NativeFieldInfoPtr_input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utf16BmpValidator>.NativeClassPtr, "input");
			Utf16BmpValidator.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utf16BmpValidator>.NativeClassPtr, 100664508);
			Utf16BmpValidator.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utf16BmpValidator>.NativeClassPtr, 100664509);
			Utf16BmpValidator.NativeMethodInfoPtr_validate_Private_Char_String_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utf16BmpValidator>.NativeClassPtr, 100664510);
			Utf16BmpValidator.NativeMethodInfoPtr_IsValidChar_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utf16BmpValidator>.NativeClassPtr, 100664511);
			Utf16BmpValidator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utf16BmpValidator>.NativeClassPtr, 100664512);
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00029084 File Offset: 0x00027284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990907, XrefRangeEnd = 990921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utf16BmpValidator.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x000290B8 File Offset: 0x000272B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990921, XrefRangeEnd = 990933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utf16BmpValidator.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x000290EC File Offset: 0x000272EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990933, XrefRangeEnd = 990938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char validate(string text, int charIndex, char addedChar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref addedChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utf16BmpValidator.NativeMethodInfoPtr_validate_Private_Char_String_Int32_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00029158 File Offset: 0x00027358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990938, XrefRangeEnd = 990942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidChar(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utf16BmpValidator.NativeMethodInfoPtr_IsValidChar_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x00029198 File Offset: 0x00027398
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Utf16BmpValidator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Utf16BmpValidator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utf16BmpValidator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x0000571F File Offset: 0x0000391F
		public Utf16BmpValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x060007A6 RID: 1958 RVA: 0x000291D4 File Offset: 0x000273D4
		// (set) Token: 0x060007A7 RID: 1959 RVA: 0x00005728 File Offset: 0x00003928
		public unsafe TMP_InputField input
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Utf16BmpValidator.NativeFieldInfoPtr_input);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Utf16BmpValidator.NativeFieldInfoPtr_input), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004A7 RID: 1191
		private static readonly IntPtr NativeFieldInfoPtr_input;

		// Token: 0x040004A8 RID: 1192
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040004A9 RID: 1193
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040004AA RID: 1194
		private static readonly IntPtr NativeMethodInfoPtr_validate_Private_Char_String_Int32_Char_0;

		// Token: 0x040004AB RID: 1195
		private static readonly IntPtr NativeMethodInfoPtr_IsValidChar_Public_Static_Boolean_Char_0;

		// Token: 0x040004AC RID: 1196
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
