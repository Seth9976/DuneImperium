using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x0200007E RID: 126
	public sealed class RegexCharClass : Object
	{
		// Token: 0x06000843 RID: 2115 RVA: 0x0003C8B0 File Offset: 0x0003AAB0
		// Note: this type is marked as 'beforefieldinit'.
		static RegexCharClass()
		{
			Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexCharClass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr);
			RegexCharClass.NativeFieldInfoPtr_s_internalRegexIgnoreCase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "s_internalRegexIgnoreCase");
			RegexCharClass.NativeFieldInfoPtr_s_space = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "s_space");
			RegexCharClass.NativeFieldInfoPtr_s_notSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "s_notSpace");
			RegexCharClass.NativeFieldInfoPtr_s_word = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "s_word");
			RegexCharClass.NativeFieldInfoPtr_s_notWord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "s_notWord");
			RegexCharClass.NativeFieldInfoPtr_SpaceClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "SpaceClass");
			RegexCharClass.NativeFieldInfoPtr_NotSpaceClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "NotSpaceClass");
			RegexCharClass.NativeFieldInfoPtr_WordClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "WordClass");
			RegexCharClass.NativeFieldInfoPtr_NotWordClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "NotWordClass");
			RegexCharClass.NativeFieldInfoPtr_DigitClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "DigitClass");
			RegexCharClass.NativeFieldInfoPtr_NotDigitClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "NotDigitClass");
			RegexCharClass.NativeFieldInfoPtr_s_definedCategories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "s_definedCategories");
			RegexCharClass.NativeFieldInfoPtr_s_propTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "s_propTable");
			RegexCharClass.NativeFieldInfoPtr_s_lcTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "s_lcTable");
			RegexCharClass.NativeFieldInfoPtr__rangelist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "_rangelist");
			RegexCharClass.NativeFieldInfoPtr__categories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "_categories");
			RegexCharClass.NativeFieldInfoPtr__canonical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "_canonical");
			RegexCharClass.NativeFieldInfoPtr__negate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "_negate");
			RegexCharClass.NativeFieldInfoPtr__subtractor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "_subtractor");
			RegexCharClass.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664641);
			RegexCharClass.NativeMethodInfoPtr__ctor_Private_Void_Boolean_List_1_SingleRange_StringBuilder_RegexCharClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664642);
			RegexCharClass.NativeMethodInfoPtr_get_CanMerge_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664643);
			RegexCharClass.NativeMethodInfoPtr_set_Negate_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664644);
			RegexCharClass.NativeMethodInfoPtr_AddChar_Public_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664645);
			RegexCharClass.NativeMethodInfoPtr_AddCharClass_Public_Void_RegexCharClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664646);
			RegexCharClass.NativeMethodInfoPtr_AddSet_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664647);
			RegexCharClass.NativeMethodInfoPtr_AddSubtraction_Public_Void_RegexCharClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664648);
			RegexCharClass.NativeMethodInfoPtr_AddRange_Public_Void_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664649);
			RegexCharClass.NativeMethodInfoPtr_AddCategoryFromName_Public_Void_String_Boolean_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664650);
			RegexCharClass.NativeMethodInfoPtr_AddCategory_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664651);
			RegexCharClass.NativeMethodInfoPtr_AddLowercase_Public_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664652);
			RegexCharClass.NativeMethodInfoPtr_AddLowercaseRange_Private_Void_Char_Char_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664653);
			RegexCharClass.NativeMethodInfoPtr_AddWord_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664654);
			RegexCharClass.NativeMethodInfoPtr_AddSpace_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664655);
			RegexCharClass.NativeMethodInfoPtr_AddDigit_Public_Void_Boolean_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664656);
			RegexCharClass.NativeMethodInfoPtr_SingletonChar_Public_Static_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664657);
			RegexCharClass.NativeMethodInfoPtr_IsMergeable_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664658);
			RegexCharClass.NativeMethodInfoPtr_IsEmpty_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664659);
			RegexCharClass.NativeMethodInfoPtr_IsSingleton_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664660);
			RegexCharClass.NativeMethodInfoPtr_IsSingletonInverse_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664661);
			RegexCharClass.NativeMethodInfoPtr_IsSubtraction_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664662);
			RegexCharClass.NativeMethodInfoPtr_IsNegated_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664663);
			RegexCharClass.NativeMethodInfoPtr_IsECMAWordChar_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664664);
			RegexCharClass.NativeMethodInfoPtr_IsWordChar_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664665);
			RegexCharClass.NativeMethodInfoPtr_CharInClass_Public_Static_Boolean_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664666);
			RegexCharClass.NativeMethodInfoPtr_CharInClassRecursive_Private_Static_Boolean_Char_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664667);
			RegexCharClass.NativeMethodInfoPtr_CharInClassInternal_Private_Static_Boolean_Char_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664668);
			RegexCharClass.NativeMethodInfoPtr_CharInCategory_Private_Static_Boolean_Char_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664669);
			RegexCharClass.NativeMethodInfoPtr_CharInCategoryGroup_Private_Static_Boolean_Char_UnicodeCategory_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664670);
			RegexCharClass.NativeMethodInfoPtr_NegateCategory_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664671);
			RegexCharClass.NativeMethodInfoPtr_Parse_Public_Static_RegexCharClass_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664672);
			RegexCharClass.NativeMethodInfoPtr_ParseRecursive_Private_Static_RegexCharClass_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664673);
			RegexCharClass.NativeMethodInfoPtr_RangeCount_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664674);
			RegexCharClass.NativeMethodInfoPtr_ToStringClass_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664675);
			RegexCharClass.NativeMethodInfoPtr_GetRangeAt_Private_SingleRange_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664676);
			RegexCharClass.NativeMethodInfoPtr_Canonicalize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664677);
			RegexCharClass.NativeMethodInfoPtr_SetFromProperty_Private_Static_String_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664678);
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x0003CD54 File Offset: 0x0003AF54
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 438709, RefRangeEnd = 438715, XrefRangeStart = 438696, XrefRangeEnd = 438709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexCharClass()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x0003CD90 File Offset: 0x0003AF90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438715, XrefRangeEnd = 438719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexCharClass(bool negate, List<RegexCharClass.SingleRange> ranges, StringBuilder categories, RegexCharClass subtraction)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref negate;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ranges);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(categories);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subtraction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr__ctor_Private_Void_Boolean_List_1_SingleRange_StringBuilder_RegexCharClass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000846 RID: 2118 RVA: 0x0003CE10 File Offset: 0x0003B010
		public unsafe bool CanMerge
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_get_CanMerge_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000271 RID: 625
		// (set) Token: 0x06000847 RID: 2119 RVA: 0x0003CE4C File Offset: 0x0003B04C
		public unsafe bool Negate
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_set_Negate_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x0003CE8C File Offset: 0x0003B08C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 438720, RefRangeEnd = 438723, XrefRangeStart = 438719, XrefRangeEnd = 438720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddChar(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_AddChar_Public_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x0003CECC File Offset: 0x0003B0CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 438740, RefRangeEnd = 438742, XrefRangeStart = 438723, XrefRangeEnd = 438740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCharClass(RegexCharClass cc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_AddCharClass_Public_Void_RegexCharClass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x0003CF10 File Offset: 0x0003B110
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 438757, RefRangeEnd = 438760, XrefRangeStart = 438742, XrefRangeEnd = 438757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSet(string set)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(set);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_AddSet_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x0003CF54 File Offset: 0x0003B154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSubtraction(RegexCharClass sub)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sub);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_AddSubtraction_Public_Void_RegexCharClass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x0003CF98 File Offset: 0x0003B198
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 438768, RefRangeEnd = 438774, XrefRangeStart = 438760, XrefRangeEnd = 438768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRange(char first, char last)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref first;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref last;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_AddRange_Public_Void_Char_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x0003CFE4 File Offset: 0x0003B1E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 438810, RefRangeEnd = 438812, XrefRangeStart = 438774, XrefRangeEnd = 438810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCategoryFromName(string categoryName, bool invert, bool caseInsensitive, string pattern)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(categoryName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invert;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref caseInsensitive;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_AddCategoryFromName_Public_Void_String_Boolean_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x0003D058 File Offset: 0x0003B258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438812, XrefRangeEnd = 438814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCategory(string category)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(category);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_AddCategory_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x0003D09C File Offset: 0x0003B29C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 438823, RefRangeEnd = 438824, XrefRangeStart = 438814, XrefRangeEnd = 438823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddLowercase(CultureInfo culture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_AddLowercase_Public_Void_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x0003D0E0 File Offset: 0x0003B2E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 438842, RefRangeEnd = 438845, XrefRangeStart = 438824, XrefRangeEnd = 438842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddLowercaseRange(char chMin, char chMax, CultureInfo culture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref chMin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref chMax;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_AddLowercaseRange_Private_Void_Char_Char_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x0003D140 File Offset: 0x0003B340
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 438861, RefRangeEnd = 438862, XrefRangeStart = 438845, XrefRangeEnd = 438861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddWord(bool ecma, bool negate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ecma;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref negate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_AddWord_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x0003D18C File Offset: 0x0003B38C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 438878, RefRangeEnd = 438879, XrefRangeStart = 438862, XrefRangeEnd = 438878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSpace(bool ecma, bool negate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ecma;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref negate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_AddSpace_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x0003D1D8 File Offset: 0x0003B3D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 438888, RefRangeEnd = 438889, XrefRangeStart = 438879, XrefRangeEnd = 438888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDigit(bool ecma, bool negate, string pattern)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ecma;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref negate;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_AddDigit_Public_Void_Boolean_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x0003D238 File Offset: 0x0003B438
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 438891, RefRangeEnd = 438893, XrefRangeStart = 438889, XrefRangeEnd = 438891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char SingletonChar(string set)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(set);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_SingletonChar_Public_Static_Char_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x0003D27C File Offset: 0x0003B47C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 438897, RefRangeEnd = 438899, XrefRangeStart = 438893, XrefRangeEnd = 438897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsMergeable(string charClass)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(charClass);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_IsMergeable_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x0003D2C0 File Offset: 0x0003B4C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 438907, RefRangeEnd = 438909, XrefRangeStart = 438899, XrefRangeEnd = 438907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsEmpty(string charClass)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(charClass);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_IsEmpty_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x0003D304 File Offset: 0x0003B504
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 438920, RefRangeEnd = 438922, XrefRangeStart = 438909, XrefRangeEnd = 438920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSingleton(string set)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(set);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_IsSingleton_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x0003D348 File Offset: 0x0003B548
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 438933, RefRangeEnd = 438935, XrefRangeStart = 438922, XrefRangeEnd = 438933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSingletonInverse(string set)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(set);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_IsSingletonInverse_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x0003D38C File Offset: 0x0003B58C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438935, XrefRangeEnd = 438937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSubtraction(string charClass)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(charClass);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_IsSubtraction_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x0003D3D0 File Offset: 0x0003B5D0
		[CallerCount(0)]
		public unsafe static bool IsNegated(string set)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(set);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_IsNegated_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x0003D414 File Offset: 0x0003B614
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 438946, RefRangeEnd = 438948, XrefRangeStart = 438937, XrefRangeEnd = 438946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsECMAWordChar(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_IsECMAWordChar_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x0003D454 File Offset: 0x0003B654
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 438956, RefRangeEnd = 438962, XrefRangeStart = 438948, XrefRangeEnd = 438956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsWordChar(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_IsWordChar_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x0003D494 File Offset: 0x0003B694
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 438966, RefRangeEnd = 438970, XrefRangeStart = 438962, XrefRangeEnd = 438966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CharInClass(char ch, string set)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(set);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_CharInClass_Public_Static_Boolean_Char_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x0003D4E4 File Offset: 0x0003B6E4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 438980, RefRangeEnd = 438984, XrefRangeStart = 438970, XrefRangeEnd = 438980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CharInClassRecursive(char ch, string set, int start)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(set);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_CharInClassRecursive_Private_Static_Boolean_Char_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x0003D544 File Offset: 0x0003B744
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 438992, RefRangeEnd = 438993, XrefRangeStart = 438984, XrefRangeEnd = 438992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CharInClassInternal(char ch, string set, int start, int mySetLength, int myCategoryLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(set);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mySetLength;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref myCategoryLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_CharInClassInternal_Private_Static_Boolean_Char_String_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x0003D5C0 File Offset: 0x0003B7C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438993, XrefRangeEnd = 439010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CharInCategory(char ch, string set, int start, int mySetLength, int myCategoryLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(set);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mySetLength;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref myCategoryLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_CharInCategory_Private_Static_Boolean_Char_String_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x0003D63C File Offset: 0x0003B83C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 439012, RefRangeEnd = 439013, XrefRangeStart = 439010, XrefRangeEnd = 439012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CharInCategoryGroup(char ch, UnicodeCategory chcategory, string category, ref int i)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref chcategory;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(category);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_CharInCategoryGroup_Private_Static_Boolean_Char_UnicodeCategory_String_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x0003D6A8 File Offset: 0x0003B8A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439013, XrefRangeEnd = 439018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string NegateCategory(string category)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(category);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_NegateCategory_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x0003D6E4 File Offset: 0x0003B8E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 439022, RefRangeEnd = 439024, XrefRangeStart = 439018, XrefRangeEnd = 439022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RegexCharClass Parse(string charClass)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(charClass);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_Parse_Public_Static_RegexCharClass_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexCharClass>(intPtr3) : null;
			}
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x0003D728 File Offset: 0x0003B928
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 439054, RefRangeEnd = 439057, XrefRangeStart = 439024, XrefRangeEnd = 439054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RegexCharClass ParseRecursive(string charClass, int start)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(charClass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_ParseRecursive_Private_Static_RegexCharClass_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexCharClass>(intPtr3) : null;
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x0003D77C File Offset: 0x0003B97C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 439058, RefRangeEnd = 439059, XrefRangeStart = 439057, XrefRangeEnd = 439058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int RangeCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_RangeCount_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x0003D7B8 File Offset: 0x0003B9B8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 440404, RefRangeEnd = 440409, XrefRangeStart = 439059, XrefRangeEnd = 440404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToStringClass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_ToStringClass_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x0003D7F0 File Offset: 0x0003B9F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 440413, RefRangeEnd = 440416, XrefRangeStart = 440409, XrefRangeEnd = 440413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexCharClass.SingleRange GetRangeAt(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_GetRangeAt_Private_SingleRange_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x0003D83C File Offset: 0x0003BA3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 440443, RefRangeEnd = 440444, XrefRangeStart = 440416, XrefRangeEnd = 440443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Canonicalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_Canonicalize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x0003D870 File Offset: 0x0003BA70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440444, XrefRangeEnd = 440458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SetFromProperty(string capname, bool invert, string pattern)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(capname);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invert;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_SetFromProperty_Private_Static_String_String_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x00004B9B File Offset: 0x00002D9B
		public RegexCharClass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x0600086B RID: 2155 RVA: 0x0003D8CC File Offset: 0x0003BACC
		// (set) Token: 0x0600086C RID: 2156 RVA: 0x00004BA4 File Offset: 0x00002DA4
		public unsafe static string s_internalRegexIgnoreCase
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexCharClass.NativeFieldInfoPtr_s_internalRegexIgnoreCase, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCharClass.NativeFieldInfoPtr_s_internalRegexIgnoreCase, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x0600086D RID: 2157 RVA: 0x0003D8EC File Offset: 0x0003BAEC
		// (set) Token: 0x0600086E RID: 2158 RVA: 0x00004BB6 File Offset: 0x00002DB6
		public unsafe static string s_space
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexCharClass.NativeFieldInfoPtr_s_space, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCharClass.NativeFieldInfoPtr_s_space, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x0600086F RID: 2159 RVA: 0x0003D90C File Offset: 0x0003BB0C
		// (set) Token: 0x06000870 RID: 2160 RVA: 0x00004BC8 File Offset: 0x00002DC8
		public unsafe static string s_notSpace
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexCharClass.NativeFieldInfoPtr_s_notSpace, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCharClass.NativeFieldInfoPtr_s_notSpace, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x0003D92C File Offset: 0x0003BB2C
		// (set) Token: 0x06000872 RID: 2162 RVA: 0x00004BDA File Offset: 0x00002DDA
		public unsafe static string s_word
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexCharClass.NativeFieldInfoPtr_s_word, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCharClass.NativeFieldInfoPtr_s_word, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000873 RID: 2163 RVA: 0x0003D94C File Offset: 0x0003BB4C
		// (set) Token: 0x06000874 RID: 2164 RVA: 0x00004BEC File Offset: 0x00002DEC
		public unsafe static string s_notWord
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexCharClass.NativeFieldInfoPtr_s_notWord, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCharClass.NativeFieldInfoPtr_s_notWord, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x0003D96C File Offset: 0x0003BB6C
		// (set) Token: 0x06000876 RID: 2166 RVA: 0x00004BFE File Offset: 0x00002DFE
		public unsafe static string SpaceClass
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexCharClass.NativeFieldInfoPtr_SpaceClass, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCharClass.NativeFieldInfoPtr_SpaceClass, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x0003D98C File Offset: 0x0003BB8C
		// (set) Token: 0x06000878 RID: 2168 RVA: 0x00004C10 File Offset: 0x00002E10
		public unsafe static string NotSpaceClass
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexCharClass.NativeFieldInfoPtr_NotSpaceClass, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCharClass.NativeFieldInfoPtr_NotSpaceClass, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000879 RID: 2169 RVA: 0x0003D9AC File Offset: 0x0003BBAC
		// (set) Token: 0x0600087A RID: 2170 RVA: 0x00004C22 File Offset: 0x00002E22
		public unsafe static string WordClass
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexCharClass.NativeFieldInfoPtr_WordClass, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCharClass.NativeFieldInfoPtr_WordClass, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x0600087B RID: 2171 RVA: 0x0003D9CC File Offset: 0x0003BBCC
		// (set) Token: 0x0600087C RID: 2172 RVA: 0x00004C34 File Offset: 0x00002E34
		public unsafe static string NotWordClass
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexCharClass.NativeFieldInfoPtr_NotWordClass, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCharClass.NativeFieldInfoPtr_NotWordClass, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x0600087D RID: 2173 RVA: 0x0003D9EC File Offset: 0x0003BBEC
		// (set) Token: 0x0600087E RID: 2174 RVA: 0x00004C46 File Offset: 0x00002E46
		public unsafe static string DigitClass
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexCharClass.NativeFieldInfoPtr_DigitClass, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCharClass.NativeFieldInfoPtr_DigitClass, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x0600087F RID: 2175 RVA: 0x0003DA0C File Offset: 0x0003BC0C
		// (set) Token: 0x06000880 RID: 2176 RVA: 0x00004C58 File Offset: 0x00002E58
		public unsafe static string NotDigitClass
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexCharClass.NativeFieldInfoPtr_NotDigitClass, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCharClass.NativeFieldInfoPtr_NotDigitClass, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000881 RID: 2177 RVA: 0x0003DA2C File Offset: 0x0003BC2C
		// (set) Token: 0x06000882 RID: 2178 RVA: 0x00004C6A File Offset: 0x00002E6A
		public unsafe static Dictionary<string, string> s_definedCategories
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexCharClass.NativeFieldInfoPtr_s_definedCategories, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCharClass.NativeFieldInfoPtr_s_definedCategories, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000883 RID: 2179 RVA: 0x0003DA54 File Offset: 0x0003BC54
		// (set) Token: 0x06000884 RID: 2180 RVA: 0x00004C7C File Offset: 0x00002E7C
		public unsafe static Il2CppReferenceArray<Il2CppStringArray> s_propTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexCharClass.NativeFieldInfoPtr_s_propTable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStringArray>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCharClass.NativeFieldInfoPtr_s_propTable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000885 RID: 2181 RVA: 0x0003DA7C File Offset: 0x0003BC7C
		// (set) Token: 0x06000886 RID: 2182 RVA: 0x00004C8E File Offset: 0x00002E8E
		public unsafe static Il2CppStructArray<RegexCharClass.LowerCaseMapping> s_lcTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexCharClass.NativeFieldInfoPtr_s_lcTable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RegexCharClass.LowerCaseMapping>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCharClass.NativeFieldInfoPtr_s_lcTable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000887 RID: 2183 RVA: 0x0003DAA4 File Offset: 0x0003BCA4
		// (set) Token: 0x06000888 RID: 2184 RVA: 0x00004CA0 File Offset: 0x00002EA0
		public unsafe List<RegexCharClass.SingleRange> _rangelist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCharClass.NativeFieldInfoPtr__rangelist);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RegexCharClass.SingleRange>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCharClass.NativeFieldInfoPtr__rangelist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000889 RID: 2185 RVA: 0x0003DAD4 File Offset: 0x0003BCD4
		// (set) Token: 0x0600088A RID: 2186 RVA: 0x00004CBF File Offset: 0x00002EBF
		public unsafe StringBuilder _categories
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCharClass.NativeFieldInfoPtr__categories);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCharClass.NativeFieldInfoPtr__categories), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x0600088B RID: 2187 RVA: 0x0003DB04 File Offset: 0x0003BD04
		// (set) Token: 0x0600088C RID: 2188 RVA: 0x00004CDE File Offset: 0x00002EDE
		public unsafe bool _canonical
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCharClass.NativeFieldInfoPtr__canonical);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCharClass.NativeFieldInfoPtr__canonical)) = value;
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x0600088D RID: 2189 RVA: 0x0003DB2C File Offset: 0x0003BD2C
		// (set) Token: 0x0600088E RID: 2190 RVA: 0x00004CF9 File Offset: 0x00002EF9
		public unsafe bool _negate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCharClass.NativeFieldInfoPtr__negate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCharClass.NativeFieldInfoPtr__negate)) = value;
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x0600088F RID: 2191 RVA: 0x0003DB54 File Offset: 0x0003BD54
		// (set) Token: 0x06000890 RID: 2192 RVA: 0x00004D14 File Offset: 0x00002F14
		public unsafe RegexCharClass _subtractor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCharClass.NativeFieldInfoPtr__subtractor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexCharClass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCharClass.NativeFieldInfoPtr__subtractor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006DB RID: 1755
		private static readonly IntPtr NativeFieldInfoPtr_s_internalRegexIgnoreCase;

		// Token: 0x040006DC RID: 1756
		private static readonly IntPtr NativeFieldInfoPtr_s_space;

		// Token: 0x040006DD RID: 1757
		private static readonly IntPtr NativeFieldInfoPtr_s_notSpace;

		// Token: 0x040006DE RID: 1758
		private static readonly IntPtr NativeFieldInfoPtr_s_word;

		// Token: 0x040006DF RID: 1759
		private static readonly IntPtr NativeFieldInfoPtr_s_notWord;

		// Token: 0x040006E0 RID: 1760
		private static readonly IntPtr NativeFieldInfoPtr_SpaceClass;

		// Token: 0x040006E1 RID: 1761
		private static readonly IntPtr NativeFieldInfoPtr_NotSpaceClass;

		// Token: 0x040006E2 RID: 1762
		private static readonly IntPtr NativeFieldInfoPtr_WordClass;

		// Token: 0x040006E3 RID: 1763
		private static readonly IntPtr NativeFieldInfoPtr_NotWordClass;

		// Token: 0x040006E4 RID: 1764
		private static readonly IntPtr NativeFieldInfoPtr_DigitClass;

		// Token: 0x040006E5 RID: 1765
		private static readonly IntPtr NativeFieldInfoPtr_NotDigitClass;

		// Token: 0x040006E6 RID: 1766
		private static readonly IntPtr NativeFieldInfoPtr_s_definedCategories;

		// Token: 0x040006E7 RID: 1767
		private static readonly IntPtr NativeFieldInfoPtr_s_propTable;

		// Token: 0x040006E8 RID: 1768
		private static readonly IntPtr NativeFieldInfoPtr_s_lcTable;

		// Token: 0x040006E9 RID: 1769
		private static readonly IntPtr NativeFieldInfoPtr__rangelist;

		// Token: 0x040006EA RID: 1770
		private static readonly IntPtr NativeFieldInfoPtr__categories;

		// Token: 0x040006EB RID: 1771
		private static readonly IntPtr NativeFieldInfoPtr__canonical;

		// Token: 0x040006EC RID: 1772
		private static readonly IntPtr NativeFieldInfoPtr__negate;

		// Token: 0x040006ED RID: 1773
		private static readonly IntPtr NativeFieldInfoPtr__subtractor;

		// Token: 0x040006EE RID: 1774
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040006EF RID: 1775
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Boolean_List_1_SingleRange_StringBuilder_RegexCharClass_0;

		// Token: 0x040006F0 RID: 1776
		private static readonly IntPtr NativeMethodInfoPtr_get_CanMerge_Public_get_Boolean_0;

		// Token: 0x040006F1 RID: 1777
		private static readonly IntPtr NativeMethodInfoPtr_set_Negate_Public_set_Void_Boolean_0;

		// Token: 0x040006F2 RID: 1778
		private static readonly IntPtr NativeMethodInfoPtr_AddChar_Public_Void_Char_0;

		// Token: 0x040006F3 RID: 1779
		private static readonly IntPtr NativeMethodInfoPtr_AddCharClass_Public_Void_RegexCharClass_0;

		// Token: 0x040006F4 RID: 1780
		private static readonly IntPtr NativeMethodInfoPtr_AddSet_Private_Void_String_0;

		// Token: 0x040006F5 RID: 1781
		private static readonly IntPtr NativeMethodInfoPtr_AddSubtraction_Public_Void_RegexCharClass_0;

		// Token: 0x040006F6 RID: 1782
		private static readonly IntPtr NativeMethodInfoPtr_AddRange_Public_Void_Char_Char_0;

		// Token: 0x040006F7 RID: 1783
		private static readonly IntPtr NativeMethodInfoPtr_AddCategoryFromName_Public_Void_String_Boolean_Boolean_String_0;

		// Token: 0x040006F8 RID: 1784
		private static readonly IntPtr NativeMethodInfoPtr_AddCategory_Private_Void_String_0;

		// Token: 0x040006F9 RID: 1785
		private static readonly IntPtr NativeMethodInfoPtr_AddLowercase_Public_Void_CultureInfo_0;

		// Token: 0x040006FA RID: 1786
		private static readonly IntPtr NativeMethodInfoPtr_AddLowercaseRange_Private_Void_Char_Char_CultureInfo_0;

		// Token: 0x040006FB RID: 1787
		private static readonly IntPtr NativeMethodInfoPtr_AddWord_Public_Void_Boolean_Boolean_0;

		// Token: 0x040006FC RID: 1788
		private static readonly IntPtr NativeMethodInfoPtr_AddSpace_Public_Void_Boolean_Boolean_0;

		// Token: 0x040006FD RID: 1789
		private static readonly IntPtr NativeMethodInfoPtr_AddDigit_Public_Void_Boolean_Boolean_String_0;

		// Token: 0x040006FE RID: 1790
		private static readonly IntPtr NativeMethodInfoPtr_SingletonChar_Public_Static_Char_String_0;

		// Token: 0x040006FF RID: 1791
		private static readonly IntPtr NativeMethodInfoPtr_IsMergeable_Public_Static_Boolean_String_0;

		// Token: 0x04000700 RID: 1792
		private static readonly IntPtr NativeMethodInfoPtr_IsEmpty_Public_Static_Boolean_String_0;

		// Token: 0x04000701 RID: 1793
		private static readonly IntPtr NativeMethodInfoPtr_IsSingleton_Public_Static_Boolean_String_0;

		// Token: 0x04000702 RID: 1794
		private static readonly IntPtr NativeMethodInfoPtr_IsSingletonInverse_Public_Static_Boolean_String_0;

		// Token: 0x04000703 RID: 1795
		private static readonly IntPtr NativeMethodInfoPtr_IsSubtraction_Private_Static_Boolean_String_0;

		// Token: 0x04000704 RID: 1796
		private static readonly IntPtr NativeMethodInfoPtr_IsNegated_Private_Static_Boolean_String_0;

		// Token: 0x04000705 RID: 1797
		private static readonly IntPtr NativeMethodInfoPtr_IsECMAWordChar_Public_Static_Boolean_Char_0;

		// Token: 0x04000706 RID: 1798
		private static readonly IntPtr NativeMethodInfoPtr_IsWordChar_Public_Static_Boolean_Char_0;

		// Token: 0x04000707 RID: 1799
		private static readonly IntPtr NativeMethodInfoPtr_CharInClass_Public_Static_Boolean_Char_String_0;

		// Token: 0x04000708 RID: 1800
		private static readonly IntPtr NativeMethodInfoPtr_CharInClassRecursive_Private_Static_Boolean_Char_String_Int32_0;

		// Token: 0x04000709 RID: 1801
		private static readonly IntPtr NativeMethodInfoPtr_CharInClassInternal_Private_Static_Boolean_Char_String_Int32_Int32_Int32_0;

		// Token: 0x0400070A RID: 1802
		private static readonly IntPtr NativeMethodInfoPtr_CharInCategory_Private_Static_Boolean_Char_String_Int32_Int32_Int32_0;

		// Token: 0x0400070B RID: 1803
		private static readonly IntPtr NativeMethodInfoPtr_CharInCategoryGroup_Private_Static_Boolean_Char_UnicodeCategory_String_byref_Int32_0;

		// Token: 0x0400070C RID: 1804
		private static readonly IntPtr NativeMethodInfoPtr_NegateCategory_Private_Static_String_String_0;

		// Token: 0x0400070D RID: 1805
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_RegexCharClass_String_0;

		// Token: 0x0400070E RID: 1806
		private static readonly IntPtr NativeMethodInfoPtr_ParseRecursive_Private_Static_RegexCharClass_String_Int32_0;

		// Token: 0x0400070F RID: 1807
		private static readonly IntPtr NativeMethodInfoPtr_RangeCount_Private_Int32_0;

		// Token: 0x04000710 RID: 1808
		private static readonly IntPtr NativeMethodInfoPtr_ToStringClass_Public_String_0;

		// Token: 0x04000711 RID: 1809
		private static readonly IntPtr NativeMethodInfoPtr_GetRangeAt_Private_SingleRange_Int32_0;

		// Token: 0x04000712 RID: 1810
		private static readonly IntPtr NativeMethodInfoPtr_Canonicalize_Private_Void_0;

		// Token: 0x04000713 RID: 1811
		private static readonly IntPtr NativeMethodInfoPtr_SetFromProperty_Private_Static_String_String_Boolean_String_0;

		// Token: 0x020002CD RID: 717
		[StructLayout(2)]
		public struct LowerCaseMapping
		{
			// Token: 0x06002BC2 RID: 11202 RVA: 0x000C1810 File Offset: 0x000BFA10
			// Note: this type is marked as 'beforefieldinit'.
			static LowerCaseMapping()
			{
				Il2CppClassPointerStore<RegexCharClass.LowerCaseMapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "LowerCaseMapping");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexCharClass.LowerCaseMapping>.NativeClassPtr);
				RegexCharClass.LowerCaseMapping.NativeFieldInfoPtr_ChMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass.LowerCaseMapping>.NativeClassPtr, "ChMin");
				RegexCharClass.LowerCaseMapping.NativeFieldInfoPtr_ChMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass.LowerCaseMapping>.NativeClassPtr, "ChMax");
				RegexCharClass.LowerCaseMapping.NativeFieldInfoPtr_LcOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass.LowerCaseMapping>.NativeClassPtr, "LcOp");
				RegexCharClass.LowerCaseMapping.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass.LowerCaseMapping>.NativeClassPtr, "Data");
				RegexCharClass.LowerCaseMapping.NativeMethodInfoPtr__ctor_Internal_Void_Char_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass.LowerCaseMapping>.NativeClassPtr, 100664680);
			}

			// Token: 0x06002BC3 RID: 11203 RVA: 0x000C18A0 File Offset: 0x000BFAA0
			[CallerCount(0)]
			public unsafe LowerCaseMapping(char chMin, char chMax, int lcOp, int data)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref chMin;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref chMax;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lcOp;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.LowerCaseMapping.NativeMethodInfoPtr__ctor_Internal_Void_Char_Char_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002BC4 RID: 11204 RVA: 0x00013B33 File Offset: 0x00011D33
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RegexCharClass.LowerCaseMapping>.NativeClassPtr, ref this));
			}

			// Token: 0x04002288 RID: 8840
			private static readonly IntPtr NativeFieldInfoPtr_ChMin;

			// Token: 0x04002289 RID: 8841
			private static readonly IntPtr NativeFieldInfoPtr_ChMax;

			// Token: 0x0400228A RID: 8842
			private static readonly IntPtr NativeFieldInfoPtr_LcOp;

			// Token: 0x0400228B RID: 8843
			private static readonly IntPtr NativeFieldInfoPtr_Data;

			// Token: 0x0400228C RID: 8844
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Char_Char_Int32_Int32_0;

			// Token: 0x0400228D RID: 8845
			[FieldOffset(0)]
			public readonly char ChMin;

			// Token: 0x0400228E RID: 8846
			[FieldOffset(2)]
			public readonly char ChMax;

			// Token: 0x0400228F RID: 8847
			[FieldOffset(4)]
			public readonly int LcOp;

			// Token: 0x04002290 RID: 8848
			[FieldOffset(8)]
			public readonly int Data;
		}

		// Token: 0x020002CE RID: 718
		public sealed class SingleRangeComparer : Object
		{
			// Token: 0x06002BC5 RID: 11205 RVA: 0x000C18FC File Offset: 0x000BFAFC
			// Note: this type is marked as 'beforefieldinit'.
			static SingleRangeComparer()
			{
				Il2CppClassPointerStore<RegexCharClass.SingleRangeComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "SingleRangeComparer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexCharClass.SingleRangeComparer>.NativeClassPtr);
				RegexCharClass.SingleRangeComparer.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass.SingleRangeComparer>.NativeClassPtr, "Instance");
				RegexCharClass.SingleRangeComparer.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass.SingleRangeComparer>.NativeClassPtr, 100664681);
				RegexCharClass.SingleRangeComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_SingleRange_SingleRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass.SingleRangeComparer>.NativeClassPtr, 100664682);
			}

			// Token: 0x06002BC6 RID: 11206 RVA: 0x000C1964 File Offset: 0x000BFB64
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SingleRangeComparer()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexCharClass.SingleRangeComparer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.SingleRangeComparer.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002BC7 RID: 11207 RVA: 0x000C19A0 File Offset: 0x000BFBA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438687, XrefRangeEnd = 438691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int Compare(RegexCharClass.SingleRange x, RegexCharClass.SingleRange y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.SingleRangeComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_SingleRange_SingleRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002BC8 RID: 11208 RVA: 0x00013B45 File Offset: 0x00011D45
			public SingleRangeComparer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DBF RID: 3519
			// (get) Token: 0x06002BC9 RID: 11209 RVA: 0x000C19F8 File Offset: 0x000BFBF8
			// (set) Token: 0x06002BCA RID: 11210 RVA: 0x00013B4E File Offset: 0x00011D4E
			public unsafe static RegexCharClass.SingleRangeComparer Instance
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RegexCharClass.SingleRangeComparer.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexCharClass.SingleRangeComparer>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RegexCharClass.SingleRangeComparer.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002291 RID: 8849
			private static readonly IntPtr NativeFieldInfoPtr_Instance;

			// Token: 0x04002292 RID: 8850
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

			// Token: 0x04002293 RID: 8851
			private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_SingleRange_SingleRange_0;
		}

		// Token: 0x020002CF RID: 719
		[StructLayout(2)]
		public struct SingleRange
		{
			// Token: 0x06002BCB RID: 11211 RVA: 0x000C1A20 File Offset: 0x000BFC20
			// Note: this type is marked as 'beforefieldinit'.
			static SingleRange()
			{
				Il2CppClassPointerStore<RegexCharClass.SingleRange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "SingleRange");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexCharClass.SingleRange>.NativeClassPtr);
				RegexCharClass.SingleRange.NativeFieldInfoPtr_First = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass.SingleRange>.NativeClassPtr, "First");
				RegexCharClass.SingleRange.NativeFieldInfoPtr_Last = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass.SingleRange>.NativeClassPtr, "Last");
				RegexCharClass.SingleRange.NativeMethodInfoPtr__ctor_Internal_Void_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass.SingleRange>.NativeClassPtr, 100664684);
			}

			// Token: 0x06002BCC RID: 11212 RVA: 0x000C1A88 File Offset: 0x000BFC88
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 438691, RefRangeEnd = 438696, XrefRangeStart = 438691, XrefRangeEnd = 438691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SingleRange(char first, char last)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref first;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref last;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.SingleRange.NativeMethodInfoPtr__ctor_Internal_Void_Char_Char_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002BCD RID: 11213 RVA: 0x00013B60 File Offset: 0x00011D60
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RegexCharClass.SingleRange>.NativeClassPtr, ref this));
			}

			// Token: 0x04002294 RID: 8852
			private static readonly IntPtr NativeFieldInfoPtr_First;

			// Token: 0x04002295 RID: 8853
			private static readonly IntPtr NativeFieldInfoPtr_Last;

			// Token: 0x04002296 RID: 8854
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Char_Char_0;

			// Token: 0x04002297 RID: 8855
			[FieldOffset(0)]
			public readonly char First;

			// Token: 0x04002298 RID: 8856
			[FieldOffset(2)]
			public readonly char Last;
		}
	}
}
