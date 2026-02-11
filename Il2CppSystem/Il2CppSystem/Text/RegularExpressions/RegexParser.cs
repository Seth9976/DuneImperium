using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000086 RID: 134
	public sealed class RegexParser : Object
	{
		// Token: 0x0600099E RID: 2462 RVA: 0x00040F3C File Offset: 0x0003F13C
		// Note: this type is marked as 'beforefieldinit'.
		static RegexParser()
		{
			Il2CppClassPointerStore<RegexParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexParser>.NativeClassPtr);
			RegexParser.NativeFieldInfoPtr__stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_stack");
			RegexParser.NativeFieldInfoPtr__group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_group");
			RegexParser.NativeFieldInfoPtr__alternation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_alternation");
			RegexParser.NativeFieldInfoPtr__concatenation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_concatenation");
			RegexParser.NativeFieldInfoPtr__unit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_unit");
			RegexParser.NativeFieldInfoPtr__pattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_pattern");
			RegexParser.NativeFieldInfoPtr__currentPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_currentPos");
			RegexParser.NativeFieldInfoPtr__culture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_culture");
			RegexParser.NativeFieldInfoPtr__autocap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_autocap");
			RegexParser.NativeFieldInfoPtr__capcount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_capcount");
			RegexParser.NativeFieldInfoPtr__captop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_captop");
			RegexParser.NativeFieldInfoPtr__capsize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_capsize");
			RegexParser.NativeFieldInfoPtr__caps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_caps");
			RegexParser.NativeFieldInfoPtr__capnames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_capnames");
			RegexParser.NativeFieldInfoPtr__capnumlist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_capnumlist");
			RegexParser.NativeFieldInfoPtr__capnamelist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_capnamelist");
			RegexParser.NativeFieldInfoPtr__options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_options");
			RegexParser.NativeFieldInfoPtr__optionsStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_optionsStack");
			RegexParser.NativeFieldInfoPtr__ignoreNextParen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_ignoreNextParen");
			RegexParser.NativeFieldInfoPtr_s_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "s_category");
			RegexParser.NativeMethodInfoPtr_Parse_Public_Static_RegexTree_String_RegexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664777);
			RegexParser.NativeMethodInfoPtr_ParseReplacement_Public_Static_RegexReplacement_String_Hashtable_Int32_Hashtable_RegexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664778);
			RegexParser.NativeMethodInfoPtr__ctor_Private_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664779);
			RegexParser.NativeMethodInfoPtr_SetPattern_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664780);
			RegexParser.NativeMethodInfoPtr_Reset_Private_Void_RegexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664781);
			RegexParser.NativeMethodInfoPtr_ScanRegex_Private_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664782);
			RegexParser.NativeMethodInfoPtr_ScanReplacement_Private_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664783);
			RegexParser.NativeMethodInfoPtr_ScanCharClass_Private_RegexCharClass_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664784);
			RegexParser.NativeMethodInfoPtr_ScanGroupOpen_Private_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664785);
			RegexParser.NativeMethodInfoPtr_ScanBlank_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664786);
			RegexParser.NativeMethodInfoPtr_ScanBackslash_Private_RegexNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664787);
			RegexParser.NativeMethodInfoPtr_ScanBasicBackslash_Private_RegexNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664788);
			RegexParser.NativeMethodInfoPtr_ScanDollar_Private_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664789);
			RegexParser.NativeMethodInfoPtr_ScanCapname_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664790);
			RegexParser.NativeMethodInfoPtr_ScanOctal_Private_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664791);
			RegexParser.NativeMethodInfoPtr_ScanDecimal_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664792);
			RegexParser.NativeMethodInfoPtr_ScanHex_Private_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664793);
			RegexParser.NativeMethodInfoPtr_HexDigit_Private_Static_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664794);
			RegexParser.NativeMethodInfoPtr_ScanControl_Private_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664795);
			RegexParser.NativeMethodInfoPtr_IsOnlyTopOption_Private_Boolean_RegexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664796);
			RegexParser.NativeMethodInfoPtr_ScanOptions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664797);
			RegexParser.NativeMethodInfoPtr_ScanCharEscape_Private_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664798);
			RegexParser.NativeMethodInfoPtr_ParseProperty_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664799);
			RegexParser.NativeMethodInfoPtr_TypeFromCode_Private_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664800);
			RegexParser.NativeMethodInfoPtr_OptionFromCode_Private_Static_RegexOptions_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664801);
			RegexParser.NativeMethodInfoPtr_CountCaptures_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664802);
			RegexParser.NativeMethodInfoPtr_NoteCaptureSlot_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664803);
			RegexParser.NativeMethodInfoPtr_NoteCaptureName_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664804);
			RegexParser.NativeMethodInfoPtr_NoteCaptures_Private_Void_Hashtable_Int32_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664805);
			RegexParser.NativeMethodInfoPtr_AssignNameSlots_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664806);
			RegexParser.NativeMethodInfoPtr_CaptureSlotFromName_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664807);
			RegexParser.NativeMethodInfoPtr_IsCaptureSlot_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664808);
			RegexParser.NativeMethodInfoPtr_IsCaptureName_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664809);
			RegexParser.NativeMethodInfoPtr_UseOptionN_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664810);
			RegexParser.NativeMethodInfoPtr_UseOptionI_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664811);
			RegexParser.NativeMethodInfoPtr_UseOptionM_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664812);
			RegexParser.NativeMethodInfoPtr_UseOptionS_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664813);
			RegexParser.NativeMethodInfoPtr_UseOptionX_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664814);
			RegexParser.NativeMethodInfoPtr_UseOptionE_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664815);
			RegexParser.NativeMethodInfoPtr_IsSpecial_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664816);
			RegexParser.NativeMethodInfoPtr_IsStopperX_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664817);
			RegexParser.NativeMethodInfoPtr_IsQuantifier_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664818);
			RegexParser.NativeMethodInfoPtr_IsTrueQuantifier_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664819);
			RegexParser.NativeMethodInfoPtr_IsSpace_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664820);
			RegexParser.NativeMethodInfoPtr_AddConcatenate_Private_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664821);
			RegexParser.NativeMethodInfoPtr_PushGroup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664822);
			RegexParser.NativeMethodInfoPtr_PopGroup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664823);
			RegexParser.NativeMethodInfoPtr_EmptyStack_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664824);
			RegexParser.NativeMethodInfoPtr_StartGroup_Private_Void_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664825);
			RegexParser.NativeMethodInfoPtr_AddAlternate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664826);
			RegexParser.NativeMethodInfoPtr_AddConcatenate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664827);
			RegexParser.NativeMethodInfoPtr_AddConcatenate_Private_Void_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664828);
			RegexParser.NativeMethodInfoPtr_Unit_Private_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664829);
			RegexParser.NativeMethodInfoPtr_AddUnitOne_Private_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664830);
			RegexParser.NativeMethodInfoPtr_AddUnitNotone_Private_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664831);
			RegexParser.NativeMethodInfoPtr_AddUnitSet_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664832);
			RegexParser.NativeMethodInfoPtr_AddUnitNode_Private_Void_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664833);
			RegexParser.NativeMethodInfoPtr_AddUnitType_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664834);
			RegexParser.NativeMethodInfoPtr_AddGroup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664835);
			RegexParser.NativeMethodInfoPtr_PushOptions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664836);
			RegexParser.NativeMethodInfoPtr_PopOptions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664837);
			RegexParser.NativeMethodInfoPtr_EmptyOptionsStack_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664838);
			RegexParser.NativeMethodInfoPtr_PopKeepOptions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664839);
			RegexParser.NativeMethodInfoPtr_MakeException_Private_ArgumentException_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664840);
			RegexParser.NativeMethodInfoPtr_Textpos_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664841);
			RegexParser.NativeMethodInfoPtr_Textto_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664842);
			RegexParser.NativeMethodInfoPtr_RightCharMoveRight_Private_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664843);
			RegexParser.NativeMethodInfoPtr_MoveRight_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664844);
			RegexParser.NativeMethodInfoPtr_MoveRight_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664845);
			RegexParser.NativeMethodInfoPtr_MoveLeft_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664846);
			RegexParser.NativeMethodInfoPtr_CharAt_Private_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664847);
			RegexParser.NativeMethodInfoPtr_RightChar_Internal_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664848);
			RegexParser.NativeMethodInfoPtr_RightChar_Private_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664849);
			RegexParser.NativeMethodInfoPtr_CharsRight_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664850);
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x000416C4 File Offset: 0x0003F8C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441210, XrefRangeEnd = 441243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RegexTree Parse(string re, RegexOptions op)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(re);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref op;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_Parse_Public_Static_RegexTree_String_RegexOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexTree>(intPtr3) : null;
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x00041718 File Offset: 0x0003F918
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 441276, RefRangeEnd = 441277, XrefRangeStart = 441243, XrefRangeEnd = 441276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RegexReplacement ParseReplacement(string rep, Hashtable caps, int capsize, Hashtable capnames, RegexOptions op)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(rep);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(caps);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capsize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(capnames);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref op;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ParseReplacement_Public_Static_RegexReplacement_String_Hashtable_Int32_Hashtable_RegexOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexReplacement>(intPtr3) : null;
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x0004179C File Offset: 0x0003F99C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 441298, RefRangeEnd = 441300, XrefRangeStart = 441277, XrefRangeEnd = 441298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexParser(CultureInfo culture)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexParser>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr__ctor_Private_Void_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x000417E8 File Offset: 0x0003F9E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441300, XrefRangeEnd = 441303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPattern(string Re)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Re);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_SetPattern_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x0004182C File Offset: 0x0003FA2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441303, XrefRangeEnd = 441309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset(RegexOptions topopts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref topopts;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_Reset_Private_Void_RegexOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x0004186C File Offset: 0x0003FA6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 441392, RefRangeEnd = 441393, XrefRangeStart = 441309, XrefRangeEnd = 441392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode ScanRegex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanRegex_Private_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x000418AC File Offset: 0x0003FAAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441393, XrefRangeEnd = 441406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode ScanReplacement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanReplacement_Private_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x000418EC File Offset: 0x0003FAEC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 441455, RefRangeEnd = 441460, XrefRangeStart = 441406, XrefRangeEnd = 441455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexCharClass ScanCharClass(bool caseInsensitive, bool scanOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref caseInsensitive;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scanOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanCharClass_Private_RegexCharClass_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexCharClass>(intPtr3) : null;
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x00041948 File Offset: 0x0003FB48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 441483, RefRangeEnd = 441484, XrefRangeStart = 441460, XrefRangeEnd = 441483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode ScanGroupOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanGroupOpen_Private_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x00041988 File Offset: 0x0003FB88
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 441507, RefRangeEnd = 441513, XrefRangeStart = 441484, XrefRangeEnd = 441507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScanBlank()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanBlank_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x000419BC File Offset: 0x0003FBBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 441541, RefRangeEnd = 441542, XrefRangeStart = 441513, XrefRangeEnd = 441541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode ScanBackslash(bool scanOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scanOnly;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanBackslash_Private_RegexNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
			}
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x00041A08 File Offset: 0x0003FC08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 441561, RefRangeEnd = 441562, XrefRangeStart = 441542, XrefRangeEnd = 441561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode ScanBasicBackslash(bool scanOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scanOnly;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanBasicBackslash_Private_RegexNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
			}
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x00041A54 File Offset: 0x0003FC54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 441574, RefRangeEnd = 441576, XrefRangeStart = 441562, XrefRangeEnd = 441574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode ScanDollar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanDollar_Private_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x00041A94 File Offset: 0x0003FC94
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 441583, RefRangeEnd = 441586, XrefRangeStart = 441576, XrefRangeEnd = 441583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ScanCapname()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanCapname_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x00041ACC File Offset: 0x0003FCCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441586, XrefRangeEnd = 441587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char ScanOctal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanOctal_Private_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x00041B08 File Offset: 0x0003FD08
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 441589, RefRangeEnd = 441594, XrefRangeStart = 441587, XrefRangeEnd = 441589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ScanDecimal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanDecimal_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x00041B44 File Offset: 0x0003FD44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441594, XrefRangeEnd = 441599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char ScanHex(int c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanHex_Private_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x00041B90 File Offset: 0x0003FD90
		[CallerCount(0)]
		public unsafe static int HexDigit(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_HexDigit_Private_Static_Int32_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x00041BD0 File Offset: 0x0003FDD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441599, XrefRangeEnd = 441600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char ScanControl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanControl_Private_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x00041C0C File Offset: 0x0003FE0C
		[CallerCount(0)]
		public unsafe bool IsOnlyTopOption(RegexOptions option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref option;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_IsOnlyTopOption_Private_Boolean_RegexOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x00041C58 File Offset: 0x0003FE58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 441609, RefRangeEnd = 441610, XrefRangeStart = 441600, XrefRangeEnd = 441609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScanOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanOptions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x00041C8C File Offset: 0x0003FE8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 441613, RefRangeEnd = 441614, XrefRangeStart = 441610, XrefRangeEnd = 441613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char ScanCharEscape()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanCharEscape_Private_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x00041CC8 File Offset: 0x0003FEC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 441622, RefRangeEnd = 441624, XrefRangeStart = 441614, XrefRangeEnd = 441622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ParseProperty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ParseProperty_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x00041D00 File Offset: 0x0003FF00
		[CallerCount(0)]
		public unsafe int TypeFromCode(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_TypeFromCode_Private_Int32_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x00041D4C File Offset: 0x0003FF4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 441624, RefRangeEnd = 441625, XrefRangeStart = 441624, XrefRangeEnd = 441624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RegexOptions OptionFromCode(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_OptionFromCode_Private_Static_RegexOptions_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x00041D8C File Offset: 0x0003FF8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 441685, RefRangeEnd = 441686, XrefRangeStart = 441625, XrefRangeEnd = 441685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CountCaptures()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_CountCaptures_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x00041DC0 File Offset: 0x0003FFC0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 441693, RefRangeEnd = 441696, XrefRangeStart = 441686, XrefRangeEnd = 441693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NoteCaptureSlot(int i, int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_NoteCaptureSlot_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x00041E0C File Offset: 0x0004000C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 441714, RefRangeEnd = 441715, XrefRangeStart = 441696, XrefRangeEnd = 441714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NoteCaptureName(string name, int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_NoteCaptureName_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x00041E5C File Offset: 0x0004005C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441715, XrefRangeEnd = 441717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NoteCaptures(Hashtable caps, int capsize, Hashtable capnames)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(caps);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capsize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(capnames);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_NoteCaptures_Private_Void_Hashtable_Int32_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x00041EC0 File Offset: 0x000400C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 441793, RefRangeEnd = 441794, XrefRangeStart = 441717, XrefRangeEnd = 441793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignNameSlots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_AssignNameSlots_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x00041EF4 File Offset: 0x000400F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 441797, RefRangeEnd = 441798, XrefRangeStart = 441794, XrefRangeEnd = 441797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CaptureSlotFromName(string capname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(capname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_CaptureSlotFromName_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x00041F44 File Offset: 0x00040144
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 441799, RefRangeEnd = 441806, XrefRangeStart = 441798, XrefRangeEnd = 441799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCaptureSlot(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_IsCaptureSlot_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x00041F90 File Offset: 0x00040190
		[CallerCount(0)]
		public unsafe bool IsCaptureName(string capname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(capname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_IsCaptureName_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x00041FE0 File Offset: 0x000401E0
		[CallerCount(0)]
		public unsafe bool UseOptionN()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_UseOptionN_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x0004201C File Offset: 0x0004021C
		[CallerCount(0)]
		public unsafe bool UseOptionI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_UseOptionI_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x00042058 File Offset: 0x00040258
		[CallerCount(0)]
		public unsafe bool UseOptionM()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_UseOptionM_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x00042094 File Offset: 0x00040294
		[CallerCount(0)]
		public unsafe bool UseOptionS()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_UseOptionS_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x000420D0 File Offset: 0x000402D0
		[CallerCount(0)]
		public unsafe bool UseOptionX()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_UseOptionX_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x0004210C File Offset: 0x0004030C
		[CallerCount(0)]
		public unsafe bool UseOptionE()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_UseOptionE_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x00042148 File Offset: 0x00040348
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 441807, RefRangeEnd = 441809, XrefRangeStart = 441806, XrefRangeEnd = 441807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSpecial(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_IsSpecial_Private_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x00042188 File Offset: 0x00040388
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 441810, RefRangeEnd = 441811, XrefRangeStart = 441809, XrefRangeEnd = 441810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsStopperX(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_IsStopperX_Private_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x000421C8 File Offset: 0x000403C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 441812, RefRangeEnd = 441813, XrefRangeStart = 441811, XrefRangeEnd = 441812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsQuantifier(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_IsQuantifier_Private_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x00042208 File Offset: 0x00040408
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 441818, RefRangeEnd = 441821, XrefRangeStart = 441813, XrefRangeEnd = 441818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTrueQuantifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_IsTrueQuantifier_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x00042244 File Offset: 0x00040444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441821, XrefRangeEnd = 441822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSpace(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_IsSpace_Private_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x00042284 File Offset: 0x00040484
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 441839, RefRangeEnd = 441842, XrefRangeStart = 441822, XrefRangeEnd = 441839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddConcatenate(int pos, int cch, bool isReplacement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cch;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isReplacement;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_AddConcatenate_Private_Void_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x000422E0 File Offset: 0x000404E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 441847, RefRangeEnd = 441848, XrefRangeStart = 441842, XrefRangeEnd = 441847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushGroup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_PushGroup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x00042314 File Offset: 0x00040514
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 441855, RefRangeEnd = 441856, XrefRangeStart = 441848, XrefRangeEnd = 441855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopGroup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_PopGroup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x00042348 File Offset: 0x00040548
		[CallerCount(0)]
		public unsafe bool EmptyStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_EmptyStack_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x00042384 File Offset: 0x00040584
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 441866, RefRangeEnd = 441868, XrefRangeStart = 441856, XrefRangeEnd = 441866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartGroup(RegexNode openGroup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(openGroup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_StartGroup_Private_Void_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x000423C8 File Offset: 0x000405C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 441881, RefRangeEnd = 441882, XrefRangeStart = 441868, XrefRangeEnd = 441881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddAlternate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_AddAlternate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x000423FC File Offset: 0x000405FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 441885, RefRangeEnd = 441887, XrefRangeStart = 441882, XrefRangeEnd = 441885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddConcatenate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_AddConcatenate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x00042430 File Offset: 0x00040630
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 441900, RefRangeEnd = 441901, XrefRangeStart = 441887, XrefRangeEnd = 441900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddConcatenate(bool lazy, int min, int max)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lazy;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_AddConcatenate_Private_Void_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x0004248C File Offset: 0x0004068C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode Unit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_Unit_Private_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x000424CC File Offset: 0x000406CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 441907, RefRangeEnd = 441908, XrefRangeStart = 441901, XrefRangeEnd = 441907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddUnitOne(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_AddUnitOne_Private_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x0004250C File Offset: 0x0004070C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 441914, RefRangeEnd = 441915, XrefRangeStart = 441908, XrefRangeEnd = 441914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddUnitNotone(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_AddUnitNotone_Private_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x0004254C File Offset: 0x0004074C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 441921, RefRangeEnd = 441923, XrefRangeStart = 441915, XrefRangeEnd = 441921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddUnitSet(string cc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(cc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_AddUnitSet_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x00042590 File Offset: 0x00040790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddUnitNode(RegexNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_AddUnitNode_Private_Void_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x000425D4 File Offset: 0x000407D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 441928, RefRangeEnd = 441930, XrefRangeStart = 441923, XrefRangeEnd = 441928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddUnitType(int type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_AddUnitType_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x00042614 File Offset: 0x00040814
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 441947, RefRangeEnd = 441949, XrefRangeStart = 441930, XrefRangeEnd = 441947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddGroup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_AddGroup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x00042648 File Offset: 0x00040848
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 441952, RefRangeEnd = 441954, XrefRangeStart = 441949, XrefRangeEnd = 441952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_PushOptions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x0004267C File Offset: 0x0004087C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 441962, RefRangeEnd = 441964, XrefRangeStart = 441954, XrefRangeEnd = 441962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_PopOptions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x000426B0 File Offset: 0x000408B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 441965, RefRangeEnd = 441966, XrefRangeStart = 441964, XrefRangeEnd = 441965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool EmptyOptionsStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_EmptyOptionsStack_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x000426EC File Offset: 0x000408EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 441971, RefRangeEnd = 441973, XrefRangeStart = 441966, XrefRangeEnd = 441971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopKeepOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_PopKeepOptions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x00042720 File Offset: 0x00040920
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 441980, RefRangeEnd = 441982, XrefRangeStart = 441973, XrefRangeEnd = 441980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArgumentException MakeException(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_MakeException_Private_ArgumentException_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArgumentException>(intPtr3) : null;
			}
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x00042770 File Offset: 0x00040970
		[CallerCount(0)]
		public unsafe int Textpos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_Textpos_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x000427AC File Offset: 0x000409AC
		[CallerCount(0)]
		public unsafe void Textto(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_Textto_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x000427EC File Offset: 0x000409EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441982, XrefRangeEnd = 441984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char RightCharMoveRight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_RightCharMoveRight_Private_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x00042828 File Offset: 0x00040A28
		[CallerCount(0)]
		public unsafe void MoveRight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_MoveRight_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x0004285C File Offset: 0x00040A5C
		[CallerCount(0)]
		public unsafe void MoveRight(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_MoveRight_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x0004289C File Offset: 0x00040A9C
		[CallerCount(0)]
		public unsafe void MoveLeft()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_MoveLeft_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x000428D0 File Offset: 0x00040AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441984, XrefRangeEnd = 441986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char CharAt(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_CharAt_Private_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x0004291C File Offset: 0x00040B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441986, XrefRangeEnd = 441988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char RightChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_RightChar_Internal_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x00042958 File Offset: 0x00040B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441988, XrefRangeEnd = 441990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char RightChar(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_RightChar_Private_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x000429A4 File Offset: 0x00040BA4
		[CallerCount(0)]
		public unsafe int CharsRight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_CharsRight_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x0000540B File Offset: 0x0000360B
		public RegexParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x060009EA RID: 2538 RVA: 0x000429E0 File Offset: 0x00040BE0
		// (set) Token: 0x060009EB RID: 2539 RVA: 0x00005414 File Offset: 0x00003614
		public unsafe RegexNode _stack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__stack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__stack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x060009EC RID: 2540 RVA: 0x00042A10 File Offset: 0x00040C10
		// (set) Token: 0x060009ED RID: 2541 RVA: 0x00005433 File Offset: 0x00003633
		public unsafe RegexNode _group
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__group);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__group), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x060009EE RID: 2542 RVA: 0x00042A40 File Offset: 0x00040C40
		// (set) Token: 0x060009EF RID: 2543 RVA: 0x00005452 File Offset: 0x00003652
		public unsafe RegexNode _alternation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__alternation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__alternation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x060009F0 RID: 2544 RVA: 0x00042A70 File Offset: 0x00040C70
		// (set) Token: 0x060009F1 RID: 2545 RVA: 0x00005471 File Offset: 0x00003671
		public unsafe RegexNode _concatenation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__concatenation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__concatenation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x060009F2 RID: 2546 RVA: 0x00042AA0 File Offset: 0x00040CA0
		// (set) Token: 0x060009F3 RID: 2547 RVA: 0x00005490 File Offset: 0x00003690
		public unsafe RegexNode _unit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__unit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__unit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x060009F4 RID: 2548 RVA: 0x00042AD0 File Offset: 0x00040CD0
		// (set) Token: 0x060009F5 RID: 2549 RVA: 0x000054AF File Offset: 0x000036AF
		public unsafe string _pattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__pattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__pattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x060009F6 RID: 2550 RVA: 0x00042AF8 File Offset: 0x00040CF8
		// (set) Token: 0x060009F7 RID: 2551 RVA: 0x000054CE File Offset: 0x000036CE
		public unsafe int _currentPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__currentPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__currentPos)) = value;
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x060009F8 RID: 2552 RVA: 0x00042B20 File Offset: 0x00040D20
		// (set) Token: 0x060009F9 RID: 2553 RVA: 0x000054E9 File Offset: 0x000036E9
		public unsafe CultureInfo _culture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__culture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__culture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x060009FA RID: 2554 RVA: 0x00042B50 File Offset: 0x00040D50
		// (set) Token: 0x060009FB RID: 2555 RVA: 0x00005508 File Offset: 0x00003708
		public unsafe int _autocap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__autocap);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__autocap)) = value;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x060009FC RID: 2556 RVA: 0x00042B78 File Offset: 0x00040D78
		// (set) Token: 0x060009FD RID: 2557 RVA: 0x00005523 File Offset: 0x00003723
		public unsafe int _capcount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__capcount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__capcount)) = value;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x060009FE RID: 2558 RVA: 0x00042BA0 File Offset: 0x00040DA0
		// (set) Token: 0x060009FF RID: 2559 RVA: 0x0000553E File Offset: 0x0000373E
		public unsafe int _captop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__captop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__captop)) = value;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000A00 RID: 2560 RVA: 0x00042BC8 File Offset: 0x00040DC8
		// (set) Token: 0x06000A01 RID: 2561 RVA: 0x00005559 File Offset: 0x00003759
		public unsafe int _capsize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__capsize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__capsize)) = value;
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000A02 RID: 2562 RVA: 0x00042BF0 File Offset: 0x00040DF0
		// (set) Token: 0x06000A03 RID: 2563 RVA: 0x00005574 File Offset: 0x00003774
		public unsafe Hashtable _caps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__caps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__caps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000A04 RID: 2564 RVA: 0x00042C20 File Offset: 0x00040E20
		// (set) Token: 0x06000A05 RID: 2565 RVA: 0x00005593 File Offset: 0x00003793
		public unsafe Hashtable _capnames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__capnames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__capnames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000A06 RID: 2566 RVA: 0x00042C50 File Offset: 0x00040E50
		// (set) Token: 0x06000A07 RID: 2567 RVA: 0x000055B2 File Offset: 0x000037B2
		public unsafe Il2CppStructArray<int> _capnumlist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__capnumlist);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__capnumlist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x00042C80 File Offset: 0x00040E80
		// (set) Token: 0x06000A09 RID: 2569 RVA: 0x000055D1 File Offset: 0x000037D1
		public unsafe List<string> _capnamelist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__capnamelist);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__capnamelist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000A0A RID: 2570 RVA: 0x00042CB0 File Offset: 0x00040EB0
		// (set) Token: 0x06000A0B RID: 2571 RVA: 0x000055F0 File Offset: 0x000037F0
		public unsafe RegexOptions _options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__options);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__options)) = value;
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000A0C RID: 2572 RVA: 0x00042CD8 File Offset: 0x00040ED8
		// (set) Token: 0x06000A0D RID: 2573 RVA: 0x0000560B File Offset: 0x0000380B
		public unsafe List<RegexOptions> _optionsStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__optionsStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RegexOptions>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__optionsStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000A0E RID: 2574 RVA: 0x00042D08 File Offset: 0x00040F08
		// (set) Token: 0x06000A0F RID: 2575 RVA: 0x0000562A File Offset: 0x0000382A
		public unsafe bool _ignoreNextParen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__ignoreNextParen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__ignoreNextParen)) = value;
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000A10 RID: 2576 RVA: 0x00042D30 File Offset: 0x00040F30
		// (set) Token: 0x06000A11 RID: 2577 RVA: 0x00005645 File Offset: 0x00003845
		public unsafe static Il2CppStructArray<byte> s_category
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexParser.NativeFieldInfoPtr_s_category, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexParser.NativeFieldInfoPtr_s_category, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007CD RID: 1997
		private static readonly IntPtr NativeFieldInfoPtr__stack;

		// Token: 0x040007CE RID: 1998
		private static readonly IntPtr NativeFieldInfoPtr__group;

		// Token: 0x040007CF RID: 1999
		private static readonly IntPtr NativeFieldInfoPtr__alternation;

		// Token: 0x040007D0 RID: 2000
		private static readonly IntPtr NativeFieldInfoPtr__concatenation;

		// Token: 0x040007D1 RID: 2001
		private static readonly IntPtr NativeFieldInfoPtr__unit;

		// Token: 0x040007D2 RID: 2002
		private static readonly IntPtr NativeFieldInfoPtr__pattern;

		// Token: 0x040007D3 RID: 2003
		private static readonly IntPtr NativeFieldInfoPtr__currentPos;

		// Token: 0x040007D4 RID: 2004
		private static readonly IntPtr NativeFieldInfoPtr__culture;

		// Token: 0x040007D5 RID: 2005
		private static readonly IntPtr NativeFieldInfoPtr__autocap;

		// Token: 0x040007D6 RID: 2006
		private static readonly IntPtr NativeFieldInfoPtr__capcount;

		// Token: 0x040007D7 RID: 2007
		private static readonly IntPtr NativeFieldInfoPtr__captop;

		// Token: 0x040007D8 RID: 2008
		private static readonly IntPtr NativeFieldInfoPtr__capsize;

		// Token: 0x040007D9 RID: 2009
		private static readonly IntPtr NativeFieldInfoPtr__caps;

		// Token: 0x040007DA RID: 2010
		private static readonly IntPtr NativeFieldInfoPtr__capnames;

		// Token: 0x040007DB RID: 2011
		private static readonly IntPtr NativeFieldInfoPtr__capnumlist;

		// Token: 0x040007DC RID: 2012
		private static readonly IntPtr NativeFieldInfoPtr__capnamelist;

		// Token: 0x040007DD RID: 2013
		private static readonly IntPtr NativeFieldInfoPtr__options;

		// Token: 0x040007DE RID: 2014
		private static readonly IntPtr NativeFieldInfoPtr__optionsStack;

		// Token: 0x040007DF RID: 2015
		private static readonly IntPtr NativeFieldInfoPtr__ignoreNextParen;

		// Token: 0x040007E0 RID: 2016
		private static readonly IntPtr NativeFieldInfoPtr_s_category;

		// Token: 0x040007E1 RID: 2017
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_RegexTree_String_RegexOptions_0;

		// Token: 0x040007E2 RID: 2018
		private static readonly IntPtr NativeMethodInfoPtr_ParseReplacement_Public_Static_RegexReplacement_String_Hashtable_Int32_Hashtable_RegexOptions_0;

		// Token: 0x040007E3 RID: 2019
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_CultureInfo_0;

		// Token: 0x040007E4 RID: 2020
		private static readonly IntPtr NativeMethodInfoPtr_SetPattern_Private_Void_String_0;

		// Token: 0x040007E5 RID: 2021
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_RegexOptions_0;

		// Token: 0x040007E6 RID: 2022
		private static readonly IntPtr NativeMethodInfoPtr_ScanRegex_Private_RegexNode_0;

		// Token: 0x040007E7 RID: 2023
		private static readonly IntPtr NativeMethodInfoPtr_ScanReplacement_Private_RegexNode_0;

		// Token: 0x040007E8 RID: 2024
		private static readonly IntPtr NativeMethodInfoPtr_ScanCharClass_Private_RegexCharClass_Boolean_Boolean_0;

		// Token: 0x040007E9 RID: 2025
		private static readonly IntPtr NativeMethodInfoPtr_ScanGroupOpen_Private_RegexNode_0;

		// Token: 0x040007EA RID: 2026
		private static readonly IntPtr NativeMethodInfoPtr_ScanBlank_Private_Void_0;

		// Token: 0x040007EB RID: 2027
		private static readonly IntPtr NativeMethodInfoPtr_ScanBackslash_Private_RegexNode_Boolean_0;

		// Token: 0x040007EC RID: 2028
		private static readonly IntPtr NativeMethodInfoPtr_ScanBasicBackslash_Private_RegexNode_Boolean_0;

		// Token: 0x040007ED RID: 2029
		private static readonly IntPtr NativeMethodInfoPtr_ScanDollar_Private_RegexNode_0;

		// Token: 0x040007EE RID: 2030
		private static readonly IntPtr NativeMethodInfoPtr_ScanCapname_Private_String_0;

		// Token: 0x040007EF RID: 2031
		private static readonly IntPtr NativeMethodInfoPtr_ScanOctal_Private_Char_0;

		// Token: 0x040007F0 RID: 2032
		private static readonly IntPtr NativeMethodInfoPtr_ScanDecimal_Private_Int32_0;

		// Token: 0x040007F1 RID: 2033
		private static readonly IntPtr NativeMethodInfoPtr_ScanHex_Private_Char_Int32_0;

		// Token: 0x040007F2 RID: 2034
		private static readonly IntPtr NativeMethodInfoPtr_HexDigit_Private_Static_Int32_Char_0;

		// Token: 0x040007F3 RID: 2035
		private static readonly IntPtr NativeMethodInfoPtr_ScanControl_Private_Char_0;

		// Token: 0x040007F4 RID: 2036
		private static readonly IntPtr NativeMethodInfoPtr_IsOnlyTopOption_Private_Boolean_RegexOptions_0;

		// Token: 0x040007F5 RID: 2037
		private static readonly IntPtr NativeMethodInfoPtr_ScanOptions_Private_Void_0;

		// Token: 0x040007F6 RID: 2038
		private static readonly IntPtr NativeMethodInfoPtr_ScanCharEscape_Private_Char_0;

		// Token: 0x040007F7 RID: 2039
		private static readonly IntPtr NativeMethodInfoPtr_ParseProperty_Private_String_0;

		// Token: 0x040007F8 RID: 2040
		private static readonly IntPtr NativeMethodInfoPtr_TypeFromCode_Private_Int32_Char_0;

		// Token: 0x040007F9 RID: 2041
		private static readonly IntPtr NativeMethodInfoPtr_OptionFromCode_Private_Static_RegexOptions_Char_0;

		// Token: 0x040007FA RID: 2042
		private static readonly IntPtr NativeMethodInfoPtr_CountCaptures_Private_Void_0;

		// Token: 0x040007FB RID: 2043
		private static readonly IntPtr NativeMethodInfoPtr_NoteCaptureSlot_Private_Void_Int32_Int32_0;

		// Token: 0x040007FC RID: 2044
		private static readonly IntPtr NativeMethodInfoPtr_NoteCaptureName_Private_Void_String_Int32_0;

		// Token: 0x040007FD RID: 2045
		private static readonly IntPtr NativeMethodInfoPtr_NoteCaptures_Private_Void_Hashtable_Int32_Hashtable_0;

		// Token: 0x040007FE RID: 2046
		private static readonly IntPtr NativeMethodInfoPtr_AssignNameSlots_Private_Void_0;

		// Token: 0x040007FF RID: 2047
		private static readonly IntPtr NativeMethodInfoPtr_CaptureSlotFromName_Private_Int32_String_0;

		// Token: 0x04000800 RID: 2048
		private static readonly IntPtr NativeMethodInfoPtr_IsCaptureSlot_Private_Boolean_Int32_0;

		// Token: 0x04000801 RID: 2049
		private static readonly IntPtr NativeMethodInfoPtr_IsCaptureName_Private_Boolean_String_0;

		// Token: 0x04000802 RID: 2050
		private static readonly IntPtr NativeMethodInfoPtr_UseOptionN_Private_Boolean_0;

		// Token: 0x04000803 RID: 2051
		private static readonly IntPtr NativeMethodInfoPtr_UseOptionI_Private_Boolean_0;

		// Token: 0x04000804 RID: 2052
		private static readonly IntPtr NativeMethodInfoPtr_UseOptionM_Private_Boolean_0;

		// Token: 0x04000805 RID: 2053
		private static readonly IntPtr NativeMethodInfoPtr_UseOptionS_Private_Boolean_0;

		// Token: 0x04000806 RID: 2054
		private static readonly IntPtr NativeMethodInfoPtr_UseOptionX_Private_Boolean_0;

		// Token: 0x04000807 RID: 2055
		private static readonly IntPtr NativeMethodInfoPtr_UseOptionE_Private_Boolean_0;

		// Token: 0x04000808 RID: 2056
		private static readonly IntPtr NativeMethodInfoPtr_IsSpecial_Private_Static_Boolean_Char_0;

		// Token: 0x04000809 RID: 2057
		private static readonly IntPtr NativeMethodInfoPtr_IsStopperX_Private_Static_Boolean_Char_0;

		// Token: 0x0400080A RID: 2058
		private static readonly IntPtr NativeMethodInfoPtr_IsQuantifier_Private_Static_Boolean_Char_0;

		// Token: 0x0400080B RID: 2059
		private static readonly IntPtr NativeMethodInfoPtr_IsTrueQuantifier_Private_Boolean_0;

		// Token: 0x0400080C RID: 2060
		private static readonly IntPtr NativeMethodInfoPtr_IsSpace_Private_Static_Boolean_Char_0;

		// Token: 0x0400080D RID: 2061
		private static readonly IntPtr NativeMethodInfoPtr_AddConcatenate_Private_Void_Int32_Int32_Boolean_0;

		// Token: 0x0400080E RID: 2062
		private static readonly IntPtr NativeMethodInfoPtr_PushGroup_Private_Void_0;

		// Token: 0x0400080F RID: 2063
		private static readonly IntPtr NativeMethodInfoPtr_PopGroup_Private_Void_0;

		// Token: 0x04000810 RID: 2064
		private static readonly IntPtr NativeMethodInfoPtr_EmptyStack_Private_Boolean_0;

		// Token: 0x04000811 RID: 2065
		private static readonly IntPtr NativeMethodInfoPtr_StartGroup_Private_Void_RegexNode_0;

		// Token: 0x04000812 RID: 2066
		private static readonly IntPtr NativeMethodInfoPtr_AddAlternate_Private_Void_0;

		// Token: 0x04000813 RID: 2067
		private static readonly IntPtr NativeMethodInfoPtr_AddConcatenate_Private_Void_0;

		// Token: 0x04000814 RID: 2068
		private static readonly IntPtr NativeMethodInfoPtr_AddConcatenate_Private_Void_Boolean_Int32_Int32_0;

		// Token: 0x04000815 RID: 2069
		private static readonly IntPtr NativeMethodInfoPtr_Unit_Private_RegexNode_0;

		// Token: 0x04000816 RID: 2070
		private static readonly IntPtr NativeMethodInfoPtr_AddUnitOne_Private_Void_Char_0;

		// Token: 0x04000817 RID: 2071
		private static readonly IntPtr NativeMethodInfoPtr_AddUnitNotone_Private_Void_Char_0;

		// Token: 0x04000818 RID: 2072
		private static readonly IntPtr NativeMethodInfoPtr_AddUnitSet_Private_Void_String_0;

		// Token: 0x04000819 RID: 2073
		private static readonly IntPtr NativeMethodInfoPtr_AddUnitNode_Private_Void_RegexNode_0;

		// Token: 0x0400081A RID: 2074
		private static readonly IntPtr NativeMethodInfoPtr_AddUnitType_Private_Void_Int32_0;

		// Token: 0x0400081B RID: 2075
		private static readonly IntPtr NativeMethodInfoPtr_AddGroup_Private_Void_0;

		// Token: 0x0400081C RID: 2076
		private static readonly IntPtr NativeMethodInfoPtr_PushOptions_Private_Void_0;

		// Token: 0x0400081D RID: 2077
		private static readonly IntPtr NativeMethodInfoPtr_PopOptions_Private_Void_0;

		// Token: 0x0400081E RID: 2078
		private static readonly IntPtr NativeMethodInfoPtr_EmptyOptionsStack_Private_Boolean_0;

		// Token: 0x0400081F RID: 2079
		private static readonly IntPtr NativeMethodInfoPtr_PopKeepOptions_Private_Void_0;

		// Token: 0x04000820 RID: 2080
		private static readonly IntPtr NativeMethodInfoPtr_MakeException_Private_ArgumentException_String_0;

		// Token: 0x04000821 RID: 2081
		private static readonly IntPtr NativeMethodInfoPtr_Textpos_Private_Int32_0;

		// Token: 0x04000822 RID: 2082
		private static readonly IntPtr NativeMethodInfoPtr_Textto_Private_Void_Int32_0;

		// Token: 0x04000823 RID: 2083
		private static readonly IntPtr NativeMethodInfoPtr_RightCharMoveRight_Private_Char_0;

		// Token: 0x04000824 RID: 2084
		private static readonly IntPtr NativeMethodInfoPtr_MoveRight_Private_Void_0;

		// Token: 0x04000825 RID: 2085
		private static readonly IntPtr NativeMethodInfoPtr_MoveRight_Private_Void_Int32_0;

		// Token: 0x04000826 RID: 2086
		private static readonly IntPtr NativeMethodInfoPtr_MoveLeft_Private_Void_0;

		// Token: 0x04000827 RID: 2087
		private static readonly IntPtr NativeMethodInfoPtr_CharAt_Private_Char_Int32_0;

		// Token: 0x04000828 RID: 2088
		private static readonly IntPtr NativeMethodInfoPtr_RightChar_Internal_Char_0;

		// Token: 0x04000829 RID: 2089
		private static readonly IntPtr NativeMethodInfoPtr_RightChar_Private_Char_Int32_0;

		// Token: 0x0400082A RID: 2090
		private static readonly IntPtr NativeMethodInfoPtr_CharsRight_Private_Int32_0;
	}
}
