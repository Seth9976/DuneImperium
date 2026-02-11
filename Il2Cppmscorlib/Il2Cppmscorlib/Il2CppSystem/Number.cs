using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;
using Il2CppSystem.Text;

namespace Il2CppSystem
{
	// Token: 0x020000D0 RID: 208
	public static class Number : Object
	{
		// Token: 0x06000D33 RID: 3379 RVA: 0x00062F94 File Offset: 0x00061194
		// Note: this type is marked as 'beforefieldinit'.
		static Number()
		{
			Il2CppClassPointerStore<Number>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Number");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Number>.NativeClassPtr);
			Number.NativeFieldInfoPtr_s_posCurrencyFormats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Number>.NativeClassPtr, "s_posCurrencyFormats");
			Number.NativeFieldInfoPtr_s_negCurrencyFormats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Number>.NativeClassPtr, "s_negCurrencyFormats");
			Number.NativeFieldInfoPtr_s_posPercentFormats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Number>.NativeClassPtr, "s_posPercentFormats");
			Number.NativeFieldInfoPtr_s_negPercentFormats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Number>.NativeClassPtr, "s_negPercentFormats");
			Number.NativeFieldInfoPtr_s_negNumberFormats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Number>.NativeClassPtr, "s_negNumberFormats");
			Number.NativeFieldInfoPtr_s_charToHexLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Number>.NativeClassPtr, "s_charToHexLookup");
			Number.NativeFieldInfoPtr_s_rgval64Power10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Number>.NativeClassPtr, "s_rgval64Power10");
			Number.NativeFieldInfoPtr_s_rgexp64Power10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Number>.NativeClassPtr, "s_rgexp64Power10");
			Number.NativeFieldInfoPtr_s_rgval64Power10By16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Number>.NativeClassPtr, "s_rgval64Power10By16");
			Number.NativeFieldInfoPtr_s_rgexp64Power10By16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Number>.NativeClassPtr, "s_rgexp64Power10By16");
			Number.NativeMethodInfoPtr_FormatDecimal_Public_Static_String_Decimal_ReadOnlySpan_1_Char_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665607);
			Number.NativeMethodInfoPtr_TryFormatDecimal_Public_Static_Boolean_Decimal_ReadOnlySpan_1_Char_NumberFormatInfo_Span_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665608);
			Number.NativeMethodInfoPtr_DecimalToNumber_Private_Static_Void_Decimal_byref_NumberBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665609);
			Number.NativeMethodInfoPtr_FormatDouble_Public_Static_String_Double_String_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665610);
			Number.NativeMethodInfoPtr_TryFormatDouble_Public_Static_Boolean_Double_ReadOnlySpan_1_Char_NumberFormatInfo_Span_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665611);
			Number.NativeMethodInfoPtr_FormatDouble_Private_Static_String_byref_ValueStringBuilder_Double_ReadOnlySpan_1_Char_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665612);
			Number.NativeMethodInfoPtr_FormatSingle_Public_Static_String_Single_String_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665613);
			Number.NativeMethodInfoPtr_TryFormatSingle_Public_Static_Boolean_Single_ReadOnlySpan_1_Char_NumberFormatInfo_Span_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665614);
			Number.NativeMethodInfoPtr_FormatSingle_Private_Static_String_byref_ValueStringBuilder_Single_ReadOnlySpan_1_Char_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665615);
			Number.NativeMethodInfoPtr_TryCopyTo_Private_Static_Boolean_String_Span_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665616);
			Number.NativeMethodInfoPtr_FormatInt32_Public_Static_String_Int32_ReadOnlySpan_1_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665617);
			Number.NativeMethodInfoPtr_TryFormatInt32_Public_Static_Boolean_Int32_ReadOnlySpan_1_Char_IFormatProvider_Span_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665618);
			Number.NativeMethodInfoPtr_FormatUInt32_Public_Static_String_UInt32_ReadOnlySpan_1_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665619);
			Number.NativeMethodInfoPtr_TryFormatUInt32_Public_Static_Boolean_UInt32_ReadOnlySpan_1_Char_IFormatProvider_Span_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665620);
			Number.NativeMethodInfoPtr_FormatInt64_Public_Static_String_Int64_ReadOnlySpan_1_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665621);
			Number.NativeMethodInfoPtr_TryFormatInt64_Public_Static_Boolean_Int64_ReadOnlySpan_1_Char_IFormatProvider_Span_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665622);
			Number.NativeMethodInfoPtr_FormatUInt64_Public_Static_String_UInt64_ReadOnlySpan_1_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665623);
			Number.NativeMethodInfoPtr_TryFormatUInt64_Public_Static_Boolean_UInt64_ReadOnlySpan_1_Char_IFormatProvider_Span_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665624);
			Number.NativeMethodInfoPtr_Int32ToNumber_Private_Static_Void_Int32_byref_NumberBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665625);
			Number.NativeMethodInfoPtr_NegativeInt32ToDecStr_Private_Static_String_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665626);
			Number.NativeMethodInfoPtr_TryNegativeInt32ToDecStr_Private_Static_Boolean_Int32_Int32_String_Span_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665627);
			Number.NativeMethodInfoPtr_Int32ToHexStr_Private_Static_String_Int32_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665628);
			Number.NativeMethodInfoPtr_TryInt32ToHexStr_Private_Static_Boolean_Int32_Char_Int32_Span_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665629);
			Number.NativeMethodInfoPtr_Int32ToHexChars_Private_Static_ptr_Char_ptr_Char_UInt32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665630);
			Number.NativeMethodInfoPtr_UInt32ToNumber_Private_Static_Void_UInt32_byref_NumberBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665631);
			Number.NativeMethodInfoPtr_UInt32ToDecChars_Internal_Static_ptr_Char_ptr_Char_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665632);
			Number.NativeMethodInfoPtr_UInt32ToDecStr_Private_Static_String_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665633);
			Number.NativeMethodInfoPtr_TryUInt32ToDecStr_Private_Static_Boolean_UInt32_Int32_Span_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665634);
			Number.NativeMethodInfoPtr_Int64ToNumber_Private_Static_Void_Int64_byref_NumberBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665635);
			Number.NativeMethodInfoPtr_NegativeInt64ToDecStr_Private_Static_String_Int64_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665636);
			Number.NativeMethodInfoPtr_TryNegativeInt64ToDecStr_Private_Static_Boolean_Int64_Int32_String_Span_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665637);
			Number.NativeMethodInfoPtr_Int64ToHexStr_Private_Static_String_Int64_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665638);
			Number.NativeMethodInfoPtr_TryInt64ToHexStr_Private_Static_Boolean_Int64_Char_Int32_Span_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665639);
			Number.NativeMethodInfoPtr_UInt64ToNumber_Private_Static_Void_UInt64_byref_NumberBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665640);
			Number.NativeMethodInfoPtr_UInt64ToDecStr_Private_Static_String_UInt64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665641);
			Number.NativeMethodInfoPtr_TryUInt64ToDecStr_Private_Static_Boolean_UInt64_Int32_Span_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665642);
			Number.NativeMethodInfoPtr_ParseFormatSpecifier_Internal_Static_Char_ReadOnlySpan_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665643);
			Number.NativeMethodInfoPtr_NumberToString_Internal_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Char_Int32_NumberFormatInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665644);
			Number.NativeMethodInfoPtr_NumberToStringFormat_Internal_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_ReadOnlySpan_1_Char_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665645);
			Number.NativeMethodInfoPtr_FormatCurrency_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665646);
			Number.NativeMethodInfoPtr_FormatFixed_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_Il2CppStructArray_1_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665647);
			Number.NativeMethodInfoPtr_FormatNumber_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665648);
			Number.NativeMethodInfoPtr_FormatScientific_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665649);
			Number.NativeMethodInfoPtr_FormatExponent_Private_Static_Void_byref_ValueStringBuilder_NumberFormatInfo_Int32_Char_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665650);
			Number.NativeMethodInfoPtr_FormatGeneral_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665651);
			Number.NativeMethodInfoPtr_FormatPercent_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665652);
			Number.NativeMethodInfoPtr_RoundNumber_Private_Static_Void_byref_NumberBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665653);
			Number.NativeMethodInfoPtr_FindSection_Private_Static_Int32_ReadOnlySpan_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665654);
			Number.NativeMethodInfoPtr_Low32_Private_Static_UInt32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665655);
			Number.NativeMethodInfoPtr_High32_Private_Static_UInt32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665656);
			Number.NativeMethodInfoPtr_Int64DivMod1E9_Private_Static_UInt32_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665657);
			Number.NativeMethodInfoPtr_NumberToInt32_Private_Static_Boolean_byref_NumberBuffer_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665658);
			Number.NativeMethodInfoPtr_NumberToInt64_Private_Static_Boolean_byref_NumberBuffer_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665659);
			Number.NativeMethodInfoPtr_NumberToUInt32_Private_Static_Boolean_byref_NumberBuffer_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665660);
			Number.NativeMethodInfoPtr_NumberToUInt64_Private_Static_Boolean_byref_NumberBuffer_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665661);
			Number.NativeMethodInfoPtr_ParseInt32_Internal_Static_Int32_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665662);
			Number.NativeMethodInfoPtr_ParseInt64_Internal_Static_Int64_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665663);
			Number.NativeMethodInfoPtr_ParseUInt32_Internal_Static_UInt32_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665664);
			Number.NativeMethodInfoPtr_ParseUInt64_Internal_Static_UInt64_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665665);
			Number.NativeMethodInfoPtr_ParseNumber_Private_Static_Boolean_byref_ptr_Char_ptr_Char_NumberStyles_byref_NumberBuffer_NumberFormatInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665666);
			Number.NativeMethodInfoPtr_TryParseInt32_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665667);
			Number.NativeMethodInfoPtr_TryParseInt32IntegerStyle_Private_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665668);
			Number.NativeMethodInfoPtr_TryParseInt64IntegerStyle_Private_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_Int64_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665669);
			Number.NativeMethodInfoPtr_TryParseInt64_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665670);
			Number.NativeMethodInfoPtr_TryParseUInt32_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665671);
			Number.NativeMethodInfoPtr_TryParseUInt32IntegerStyle_Private_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_UInt32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665672);
			Number.NativeMethodInfoPtr_TryParseUInt32HexNumberStyle_Private_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_UInt32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665673);
			Number.NativeMethodInfoPtr_TryParseUInt64_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665674);
			Number.NativeMethodInfoPtr_TryParseUInt64IntegerStyle_Private_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_UInt64_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665675);
			Number.NativeMethodInfoPtr_TryParseUInt64HexNumberStyle_Private_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_UInt64_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665676);
			Number.NativeMethodInfoPtr_ParseDecimal_Internal_Static_Decimal_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665677);
			Number.NativeMethodInfoPtr_NumberBufferToDecimal_Private_Static_Boolean_byref_NumberBuffer_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665678);
			Number.NativeMethodInfoPtr_ParseDouble_Internal_Static_Double_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665679);
			Number.NativeMethodInfoPtr_ParseSingle_Internal_Static_Single_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665680);
			Number.NativeMethodInfoPtr_TryParseDecimal_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665681);
			Number.NativeMethodInfoPtr_TryParseDouble_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665682);
			Number.NativeMethodInfoPtr_TryParseSingle_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665683);
			Number.NativeMethodInfoPtr_StringToNumber_Private_Static_Void_ReadOnlySpan_1_Char_NumberStyles_byref_NumberBuffer_NumberFormatInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665684);
			Number.NativeMethodInfoPtr_TryStringToNumber_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_byref_NumberBuffer_NumberFormatInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665685);
			Number.NativeMethodInfoPtr_TrailingZeros_Private_Static_Boolean_ReadOnlySpan_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665686);
			Number.NativeMethodInfoPtr_MatchChars_Private_Static_ptr_Char_ptr_Char_ptr_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665687);
			Number.NativeMethodInfoPtr_IsWhite_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665688);
			Number.NativeMethodInfoPtr_IsDigit_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665689);
			Number.NativeMethodInfoPtr_ThrowOverflowOrFormatException_Private_Static_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665690);
			Number.NativeMethodInfoPtr_NumberBufferToDouble_Private_Static_Boolean_byref_NumberBuffer_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665691);
			Number.NativeMethodInfoPtr_DigitsToInt_Private_Static_UInt32_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665692);
			Number.NativeMethodInfoPtr_Mul32x32To64_Private_Static_UInt64_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665693);
			Number.NativeMethodInfoPtr_Mul64Lossy_Private_Static_UInt64_UInt64_UInt64_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665694);
			Number.NativeMethodInfoPtr_abs_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665695);
			Number.NativeMethodInfoPtr_NumberToDouble_Private_Static_Double_byref_NumberBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665696);
			Number.NativeMethodInfoPtr_DoubleToNumber_Private_Static_Void_Double_Int32_byref_NumberBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665697);
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x000637A8 File Offset: 0x000619A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1316506, RefRangeEnd = 1316509, XrefRangeStart = 1316492, XrefRangeEnd = 1316506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatDecimal(Decimal value, ReadOnlySpan<char> format, NumberFormatInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_FormatDecimal_Public_Static_String_Decimal_ReadOnlySpan_1_Char_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x0006380C File Offset: 0x00061A0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1316523, RefRangeEnd = 1316524, XrefRangeStart = 1316509, XrefRangeEnd = 1316523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryFormatDecimal(Decimal value, ReadOnlySpan<char> format, NumberFormatInfo info, Span<char> destination, out int charsWritten)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charsWritten;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryFormatDecimal_Public_Static_Boolean_Decimal_ReadOnlySpan_1_Char_NumberFormatInfo_Span_1_Char_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x00063898 File Offset: 0x00061A98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1316545, RefRangeEnd = 1316547, XrefRangeStart = 1316524, XrefRangeEnd = 1316545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DecimalToNumber(Decimal value, ref Number.NumberBuffer number)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_DecimalToNumber_Private_Static_Void_Decimal_byref_NumberBuffer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x000638D8 File Offset: 0x00061AD8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1316557, RefRangeEnd = 1316561, XrefRangeStart = 1316547, XrefRangeEnd = 1316557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatDouble(double value, string format, NumberFormatInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_FormatDouble_Public_Static_String_Double_String_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x00063934 File Offset: 0x00061B34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1316576, RefRangeEnd = 1316577, XrefRangeStart = 1316561, XrefRangeEnd = 1316576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryFormatDouble(double value, ReadOnlySpan<char> format, NumberFormatInfo info, Span<char> destination, out int charsWritten)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charsWritten;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryFormatDouble_Public_Static_Boolean_Double_ReadOnlySpan_1_Char_NumberFormatInfo_Span_1_Char_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x000639C0 File Offset: 0x00061BC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1316603, RefRangeEnd = 1316605, XrefRangeStart = 1316577, XrefRangeEnd = 1316603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatDouble(ref ValueStringBuilder sb, double value, ReadOnlySpan<char> format, NumberFormatInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_FormatDouble_Private_Static_String_byref_ValueStringBuilder_Double_ReadOnlySpan_1_Char_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x00063A34 File Offset: 0x00061C34
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1316615, RefRangeEnd = 1316619, XrefRangeStart = 1316605, XrefRangeEnd = 1316615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatSingle(float value, string format, NumberFormatInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_FormatSingle_Public_Static_String_Single_String_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x00063A90 File Offset: 0x00061C90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1316634, RefRangeEnd = 1316635, XrefRangeStart = 1316619, XrefRangeEnd = 1316634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryFormatSingle(float value, ReadOnlySpan<char> format, NumberFormatInfo info, Span<char> destination, out int charsWritten)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charsWritten;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryFormatSingle_Public_Static_Boolean_Single_ReadOnlySpan_1_Char_NumberFormatInfo_Span_1_Char_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x00063B1C File Offset: 0x00061D1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1316661, RefRangeEnd = 1316663, XrefRangeStart = 1316635, XrefRangeEnd = 1316661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatSingle(ref ValueStringBuilder sb, float value, ReadOnlySpan<char> format, NumberFormatInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_FormatSingle_Private_Static_String_byref_ValueStringBuilder_Single_ReadOnlySpan_1_Char_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x00063B90 File Offset: 0x00061D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1316663, XrefRangeEnd = 1316669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryCopyTo(string source, Span<char> destination, out int charsWritten)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charsWritten;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryCopyTo_Private_Static_Boolean_String_Span_1_Char_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D3E RID: 3390 RVA: 0x00063BF8 File Offset: 0x00061DF8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1316675, RefRangeEnd = 1316687, XrefRangeStart = 1316669, XrefRangeEnd = 1316675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatInt32(int value, ReadOnlySpan<char> format, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_FormatInt32_Public_Static_String_Int32_ReadOnlySpan_1_Char_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x00063C5C File Offset: 0x00061E5C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1316693, RefRangeEnd = 1316697, XrefRangeStart = 1316687, XrefRangeEnd = 1316693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryFormatInt32(int value, ReadOnlySpan<char> format, IFormatProvider provider, Span<char> destination, out int charsWritten)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charsWritten;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryFormatInt32_Public_Static_Boolean_Int32_ReadOnlySpan_1_Char_IFormatProvider_Span_1_Char_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x00063CE8 File Offset: 0x00061EE8
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1316726, RefRangeEnd = 1316735, XrefRangeStart = 1316697, XrefRangeEnd = 1316726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatUInt32(uint value, ReadOnlySpan<char> format, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_FormatUInt32_Public_Static_String_UInt32_ReadOnlySpan_1_Char_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x00063D4C File Offset: 0x00061F4C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1316763, RefRangeEnd = 1316767, XrefRangeStart = 1316735, XrefRangeEnd = 1316763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryFormatUInt32(uint value, ReadOnlySpan<char> format, IFormatProvider provider, Span<char> destination, out int charsWritten)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charsWritten;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryFormatUInt32_Public_Static_Boolean_UInt32_ReadOnlySpan_1_Char_IFormatProvider_Span_1_Char_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x00063DD8 File Offset: 0x00061FD8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1316773, RefRangeEnd = 1316777, XrefRangeStart = 1316767, XrefRangeEnd = 1316773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatInt64(long value, ReadOnlySpan<char> format, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_FormatInt64_Public_Static_String_Int64_ReadOnlySpan_1_Char_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x00063E3C File Offset: 0x0006203C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1316783, RefRangeEnd = 1316784, XrefRangeStart = 1316777, XrefRangeEnd = 1316783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryFormatInt64(long value, ReadOnlySpan<char> format, IFormatProvider provider, Span<char> destination, out int charsWritten)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charsWritten;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryFormatInt64_Public_Static_Boolean_Int64_ReadOnlySpan_1_Char_IFormatProvider_Span_1_Char_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x00063EC8 File Offset: 0x000620C8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1316813, RefRangeEnd = 1316817, XrefRangeStart = 1316784, XrefRangeEnd = 1316813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatUInt64(ulong value, ReadOnlySpan<char> format, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_FormatUInt64_Public_Static_String_UInt64_ReadOnlySpan_1_Char_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x00063F2C File Offset: 0x0006212C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1316845, RefRangeEnd = 1316846, XrefRangeStart = 1316817, XrefRangeEnd = 1316845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryFormatUInt64(ulong value, ReadOnlySpan<char> format, IFormatProvider provider, Span<char> destination, out int charsWritten)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charsWritten;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryFormatUInt64_Public_Static_Boolean_UInt64_ReadOnlySpan_1_Char_IFormatProvider_Span_1_Char_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x00063FB8 File Offset: 0x000621B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1316846, XrefRangeEnd = 1316853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Int32ToNumber(int value, ref Number.NumberBuffer number)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_Int32ToNumber_Private_Static_Void_Int32_byref_NumberBuffer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x00063FF8 File Offset: 0x000621F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1316853, XrefRangeEnd = 1316866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string NegativeInt32ToDecStr(int value, int digits, string sNegative)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sNegative);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_NegativeInt32ToDecStr_Private_Static_String_Int32_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x00064050 File Offset: 0x00062250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1316866, XrefRangeEnd = 1316881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryNegativeInt32ToDecStr(int value, int digits, string sNegative, Span<char> destination, out int charsWritten)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sNegative);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charsWritten;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryNegativeInt32ToDecStr_Private_Static_Boolean_Int32_Int32_String_Span_1_Char_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x000640D4 File Offset: 0x000622D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1316890, RefRangeEnd = 1316891, XrefRangeStart = 1316881, XrefRangeEnd = 1316890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Int32ToHexStr(int value, char hexBase, int digits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hexBase;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_Int32ToHexStr_Private_Static_String_Int32_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x00064128 File Offset: 0x00062328
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1316903, RefRangeEnd = 1316904, XrefRangeStart = 1316891, XrefRangeEnd = 1316903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryInt32ToHexStr(int value, char hexBase, int digits, Span<char> destination, out int charsWritten)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hexBase;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charsWritten;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryInt32ToHexStr_Private_Static_Boolean_Int32_Char_Int32_Span_1_Char_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x000641A8 File Offset: 0x000623A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1316904, XrefRangeEnd = 1316905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char* Int32ToHexChars(char* buffer, uint value, int hexBase, int digits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hexBase;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_Int32ToHexChars_Private_Static_ptr_Char_ptr_Char_UInt32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x00064204 File Offset: 0x00062404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1316905, XrefRangeEnd = 1316912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UInt32ToNumber(uint value, ref Number.NumberBuffer number)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_UInt32ToNumber_Private_Static_Void_UInt32_byref_NumberBuffer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x00064244 File Offset: 0x00062444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1316912, XrefRangeEnd = 1316913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char* UInt32ToDecChars(char* bufferEnd, uint value, int digits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = bufferEnd;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_UInt32ToDecChars_Internal_Static_ptr_Char_ptr_Char_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x00064294 File Offset: 0x00062494
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1316925, RefRangeEnd = 1316927, XrefRangeStart = 1316913, XrefRangeEnd = 1316925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string UInt32ToDecStr(uint value, int digits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_UInt32ToDecStr_Private_Static_String_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x000642DC File Offset: 0x000624DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1316942, RefRangeEnd = 1316944, XrefRangeStart = 1316927, XrefRangeEnd = 1316942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryUInt32ToDecStr(uint value, int digits, Span<char> destination, out int charsWritten)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charsWritten;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryUInt32ToDecStr_Private_Static_Boolean_UInt32_Int32_Span_1_Char_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x0006434C File Offset: 0x0006254C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1316944, XrefRangeEnd = 1316956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Int64ToNumber(long input, ref Number.NumberBuffer number)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_Int64ToNumber_Private_Static_Void_Int64_byref_NumberBuffer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x0006438C File Offset: 0x0006258C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1316956, XrefRangeEnd = 1316972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string NegativeInt64ToDecStr(long input, int digits, string sNegative)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sNegative);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_NegativeInt64ToDecStr_Private_Static_String_Int64_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x000643E4 File Offset: 0x000625E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1316972, XrefRangeEnd = 1316990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryNegativeInt64ToDecStr(long input, int digits, string sNegative, Span<char> destination, out int charsWritten)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sNegative);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charsWritten;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryNegativeInt64ToDecStr_Private_Static_Boolean_Int64_Int32_String_Span_1_Char_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x00064468 File Offset: 0x00062668
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1317006, RefRangeEnd = 1317007, XrefRangeStart = 1316990, XrefRangeEnd = 1317006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Int64ToHexStr(long value, char hexBase, int digits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hexBase;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_Int64ToHexStr_Private_Static_String_Int64_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x000644BC File Offset: 0x000626BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1317026, RefRangeEnd = 1317027, XrefRangeStart = 1317007, XrefRangeEnd = 1317026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryInt64ToHexStr(long value, char hexBase, int digits, Span<char> destination, out int charsWritten)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hexBase;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charsWritten;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryInt64ToHexStr_Private_Static_Boolean_Int64_Char_Int32_Span_1_Char_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x0006453C File Offset: 0x0006273C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1317038, RefRangeEnd = 1317040, XrefRangeStart = 1317027, XrefRangeEnd = 1317038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UInt64ToNumber(ulong value, ref Number.NumberBuffer number)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_UInt64ToNumber_Private_Static_Void_UInt64_byref_NumberBuffer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x0006457C File Offset: 0x0006277C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1317055, RefRangeEnd = 1317057, XrefRangeStart = 1317040, XrefRangeEnd = 1317055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string UInt64ToDecStr(ulong value, int digits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_UInt64ToDecStr_Private_Static_String_UInt64_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x000645C4 File Offset: 0x000627C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1317075, RefRangeEnd = 1317077, XrefRangeStart = 1317057, XrefRangeEnd = 1317075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryUInt64ToDecStr(ulong value, int digits, Span<char> destination, out int charsWritten)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charsWritten;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryUInt64ToDecStr_Private_Static_Boolean_UInt64_Int32_Span_1_Char_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x00064634 File Offset: 0x00062834
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1317082, RefRangeEnd = 1317090, XrefRangeStart = 1317077, XrefRangeEnd = 1317082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ParseFormatSpecifier(ReadOnlySpan<char> format, out int digits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &digits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_ParseFormatSpecifier_Internal_Static_Char_ReadOnlySpan_1_Char_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x00064688 File Offset: 0x00062888
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1317116, RefRangeEnd = 1317124, XrefRangeStart = 1317090, XrefRangeEnd = 1317116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NumberToString(ref ValueStringBuilder sb, ref Number.NumberBuffer number, char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMaxDigits;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDecimal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_NumberToString_Internal_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Char_Int32_NumberFormatInfo_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x0006470C File Offset: 0x0006290C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1317211, RefRangeEnd = 1317219, XrefRangeStart = 1317124, XrefRangeEnd = 1317211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NumberToStringFormat(ref ValueStringBuilder sb, ref Number.NumberBuffer number, ReadOnlySpan<char> format, NumberFormatInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_NumberToStringFormat_Internal_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_ReadOnlySpan_1_Char_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x0006477C File Offset: 0x0006297C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1317219, XrefRangeEnd = 1317238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FormatCurrency(ref ValueStringBuilder sb, ref Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMinDigits;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMaxDigits;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_FormatCurrency_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x000647F0 File Offset: 0x000629F0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1317272, RefRangeEnd = 1317276, XrefRangeStart = 1317238, XrefRangeEnd = 1317272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FormatFixed(ref ValueStringBuilder sb, ref Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, Il2CppStructArray<int> groupDigits, string sDecimal, string sGroup)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMinDigits;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMaxDigits;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(groupDigits);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sDecimal);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sGroup);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_FormatFixed_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_Il2CppStructArray_1_Int32_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x000648A0 File Offset: 0x00062AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1317276, XrefRangeEnd = 1317293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FormatNumber(ref ValueStringBuilder sb, ref Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMinDigits;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMaxDigits;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_FormatNumber_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x00064914 File Offset: 0x00062B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1317293, XrefRangeEnd = 1317309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FormatScientific(ref ValueStringBuilder sb, ref Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMinDigits;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMaxDigits;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_FormatScientific_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x00064998 File Offset: 0x00062B98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1317320, RefRangeEnd = 1317323, XrefRangeStart = 1317309, XrefRangeEnd = 1317320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FormatExponent(ref ValueStringBuilder sb, NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expChar;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minDigits;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref positiveSign;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_FormatExponent_Private_Static_Void_byref_ValueStringBuilder_NumberFormatInfo_Int32_Char_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x00064A1C File Offset: 0x00062C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1317323, XrefRangeEnd = 1317347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FormatGeneral(ref ValueStringBuilder sb, ref Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar, bool bSuppressScientific)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMinDigits;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMaxDigits;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expChar;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bSuppressScientific;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_FormatGeneral_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_Char_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x00064AAC File Offset: 0x00062CAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1317366, RefRangeEnd = 1317367, XrefRangeStart = 1317347, XrefRangeEnd = 1317366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FormatPercent(ref ValueStringBuilder sb, ref Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMinDigits;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMaxDigits;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_FormatPercent_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x00064B20 File Offset: 0x00062D20
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1317371, RefRangeEnd = 1317374, XrefRangeStart = 1317367, XrefRangeEnd = 1317371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RoundNumber(ref Number.NumberBuffer number, int pos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &number;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_RoundNumber_Private_Static_Void_byref_NumberBuffer_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x00064B60 File Offset: 0x00062D60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1317378, RefRangeEnd = 1317380, XrefRangeStart = 1317374, XrefRangeEnd = 1317378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindSection(ReadOnlySpan<char> format, int section)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref section;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_FindSection_Private_Static_Int32_ReadOnlySpan_1_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x00064BB4 File Offset: 0x00062DB4
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint Low32(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_Low32_Private_Static_UInt32_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x00064BF4 File Offset: 0x00062DF4
		[CallerCount(0)]
		public unsafe static uint High32(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_High32_Private_Static_UInt32_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x00064C34 File Offset: 0x00062E34
		[CallerCount(0)]
		public unsafe static uint Int64DivMod1E9(ref ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_Int64DivMod1E9_Private_Static_UInt32_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x00064C74 File Offset: 0x00062E74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1317382, RefRangeEnd = 1317383, XrefRangeStart = 1317380, XrefRangeEnd = 1317382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool NumberToInt32(ref Number.NumberBuffer number, ref int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &number;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_NumberToInt32_Private_Static_Boolean_byref_NumberBuffer_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x00064CC0 File Offset: 0x00062EC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1317385, RefRangeEnd = 1317386, XrefRangeStart = 1317383, XrefRangeEnd = 1317385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool NumberToInt64(ref Number.NumberBuffer number, ref long value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &number;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_NumberToInt64_Private_Static_Boolean_byref_NumberBuffer_byref_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x00064D0C File Offset: 0x00062F0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1317388, RefRangeEnd = 1317389, XrefRangeStart = 1317386, XrefRangeEnd = 1317388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool NumberToUInt32(ref Number.NumberBuffer number, ref uint value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &number;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_NumberToUInt32_Private_Static_Boolean_byref_NumberBuffer_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x00064D58 File Offset: 0x00062F58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1317391, RefRangeEnd = 1317392, XrefRangeStart = 1317389, XrefRangeEnd = 1317391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool NumberToUInt64(ref Number.NumberBuffer number, ref ulong value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &number;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_NumberToUInt64_Private_Static_Boolean_byref_NumberBuffer_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x00064DA4 File Offset: 0x00062FA4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1317400, RefRangeEnd = 1317408, XrefRangeStart = 1317392, XrefRangeEnd = 1317400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ParseInt32(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_ParseInt32_Internal_Static_Int32_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x00064E0C File Offset: 0x0006300C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1317416, RefRangeEnd = 1317419, XrefRangeStart = 1317408, XrefRangeEnd = 1317416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ParseInt64(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_ParseInt64_Internal_Static_Int64_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x00064E74 File Offset: 0x00063074
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1317426, RefRangeEnd = 1317430, XrefRangeStart = 1317419, XrefRangeEnd = 1317426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ParseUInt32(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_ParseUInt32_Internal_Static_UInt32_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x00064EDC File Offset: 0x000630DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1317437, RefRangeEnd = 1317440, XrefRangeStart = 1317430, XrefRangeEnd = 1317437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ParseUInt64(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_ParseUInt64_Internal_Static_UInt64_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x00064F44 File Offset: 0x00063144
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1317530, RefRangeEnd = 1317532, XrefRangeStart = 1317440, XrefRangeEnd = 1317530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ParseNumber(ref char* str, char* strEnd, NumberStyles styles, ref Number.NumberBuffer number, NumberFormatInfo info, bool parseDecimal)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(str);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = strEnd;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parseDecimal;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_ParseNumber_Private_Static_Boolean_byref_ptr_Char_ptr_Char_NumberStyles_byref_NumberBuffer_NumberFormatInfo_Boolean_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			str = ((intPtr4 == 0) ? null : new char*(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x00064FE8 File Offset: 0x000631E8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1317547, RefRangeEnd = 1317555, XrefRangeStart = 1317532, XrefRangeEnd = 1317547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseInt32(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out int result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryParseInt32_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x0006505C File Offset: 0x0006325C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1317605, RefRangeEnd = 1317607, XrefRangeStart = 1317555, XrefRangeEnd = 1317605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseInt32IntegerStyle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out int result, ref bool failureIsOverflow)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &failureIsOverflow;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryParseInt32IntegerStyle_Private_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_Int32_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x000650E0 File Offset: 0x000632E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1317657, RefRangeEnd = 1317659, XrefRangeStart = 1317607, XrefRangeEnd = 1317657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseInt64IntegerStyle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out long result, ref bool failureIsOverflow)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &failureIsOverflow;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryParseInt64IntegerStyle_Private_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_Int64_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x00065164 File Offset: 0x00063364
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1317674, RefRangeEnd = 1317675, XrefRangeStart = 1317659, XrefRangeEnd = 1317674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseInt64(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out long result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryParseInt64_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x000651D8 File Offset: 0x000633D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1317691, RefRangeEnd = 1317695, XrefRangeStart = 1317675, XrefRangeEnd = 1317691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseUInt32(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out uint result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryParseUInt32_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x0006524C File Offset: 0x0006344C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1317745, RefRangeEnd = 1317746, XrefRangeStart = 1317695, XrefRangeEnd = 1317745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseUInt32IntegerStyle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out uint result, ref bool failureIsOverflow)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &failureIsOverflow;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryParseUInt32IntegerStyle_Private_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_UInt32_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x000652D0 File Offset: 0x000634D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1317762, RefRangeEnd = 1317764, XrefRangeStart = 1317746, XrefRangeEnd = 1317762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseUInt32HexNumberStyle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out uint result, ref bool failureIsOverflow)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &failureIsOverflow;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryParseUInt32HexNumberStyle_Private_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_UInt32_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x00065354 File Offset: 0x00063554
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1317780, RefRangeEnd = 1317782, XrefRangeStart = 1317764, XrefRangeEnd = 1317780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseUInt64(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out ulong result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryParseUInt64_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x000653C8 File Offset: 0x000635C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1317832, RefRangeEnd = 1317833, XrefRangeStart = 1317782, XrefRangeEnd = 1317832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseUInt64IntegerStyle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out ulong result, ref bool failureIsOverflow)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &failureIsOverflow;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryParseUInt64IntegerStyle_Private_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_UInt64_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x0006544C File Offset: 0x0006364C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1317849, RefRangeEnd = 1317851, XrefRangeStart = 1317833, XrefRangeEnd = 1317849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseUInt64HexNumberStyle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out ulong result, ref bool failureIsOverflow)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &failureIsOverflow;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryParseUInt64HexNumberStyle_Private_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_UInt64_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x000654D0 File Offset: 0x000636D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1317857, RefRangeEnd = 1317860, XrefRangeStart = 1317851, XrefRangeEnd = 1317857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ParseDecimal(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_ParseDecimal_Internal_Static_Decimal_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x00065538 File Offset: 0x00063738
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1317866, RefRangeEnd = 1317868, XrefRangeStart = 1317860, XrefRangeEnd = 1317866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool NumberBufferToDecimal(ref Number.NumberBuffer number, ref Decimal value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &number;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_NumberBufferToDecimal_Private_Static_Boolean_byref_NumberBuffer_byref_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x00065584 File Offset: 0x00063784
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1317888, RefRangeEnd = 1317891, XrefRangeStart = 1317868, XrefRangeEnd = 1317888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ParseDouble(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_ParseDouble_Internal_Static_Double_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x000655EC File Offset: 0x000637EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1317911, RefRangeEnd = 1317913, XrefRangeStart = 1317891, XrefRangeEnd = 1317911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ParseSingle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_ParseSingle_Internal_Static_Single_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x00065654 File Offset: 0x00063854
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1317921, RefRangeEnd = 1317922, XrefRangeStart = 1317913, XrefRangeEnd = 1317921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseDecimal(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out Decimal result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryParseDecimal_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x000656C8 File Offset: 0x000638C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1317933, RefRangeEnd = 1317934, XrefRangeStart = 1317922, XrefRangeEnd = 1317933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseDouble(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out double result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryParseDouble_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x0006573C File Offset: 0x0006393C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1317945, RefRangeEnd = 1317946, XrefRangeStart = 1317934, XrefRangeEnd = 1317945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseSingle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out float result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryParseSingle_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x000657B0 File Offset: 0x000639B0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1317957, RefRangeEnd = 1317962, XrefRangeStart = 1317946, XrefRangeEnd = 1317957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StringToNumber(ReadOnlySpan<char> value, NumberStyles styles, ref Number.NumberBuffer number, NumberFormatInfo info, bool parseDecimal)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parseDecimal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_StringToNumber_Private_Static_Void_ReadOnlySpan_1_Char_NumberStyles_byref_NumberBuffer_NumberFormatInfo_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x00065828 File Offset: 0x00063A28
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1317974, RefRangeEnd = 1317983, XrefRangeStart = 1317962, XrefRangeEnd = 1317974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryStringToNumber(ReadOnlySpan<char> value, NumberStyles styles, ref Number.NumberBuffer number, NumberFormatInfo info, bool parseDecimal)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parseDecimal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryStringToNumber_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_byref_NumberBuffer_NumberFormatInfo_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x000658AC File Offset: 0x00063AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1317983, XrefRangeEnd = 1317984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TrailingZeros(ReadOnlySpan<char> value, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TrailingZeros_Private_Static_Boolean_ReadOnlySpan_1_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x00065900 File Offset: 0x00063B00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1317986, RefRangeEnd = 1317988, XrefRangeStart = 1317984, XrefRangeEnd = 1317986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char* MatchChars(char* p, char* pEnd, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = p;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pEnd;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_MatchChars_Private_Static_ptr_Char_ptr_Char_ptr_Char_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x00065954 File Offset: 0x00063B54
		[CallerCount(0)]
		public unsafe static bool IsWhite(int ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_IsWhite_Private_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x00065994 File Offset: 0x00063B94
		[CallerCount(0)]
		public unsafe static bool IsDigit(int ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_IsDigit_Private_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x000659D4 File Offset: 0x00063BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1317988, XrefRangeEnd = 1317999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowOverflowOrFormatException(bool overflow, string overflowResourceKey)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref overflow;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(overflowResourceKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_ThrowOverflowOrFormatException_Private_Static_Void_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x00065A18 File Offset: 0x00063C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1317999, XrefRangeEnd = 1318003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool NumberBufferToDouble(ref Number.NumberBuffer number, ref double value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &number;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_NumberBufferToDouble_Private_Static_Boolean_byref_NumberBuffer_byref_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x00065A64 File Offset: 0x00063C64
		[CallerCount(0)]
		public unsafe static uint DigitsToInt(char* p, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = p;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_DigitsToInt_Private_Static_UInt32_ptr_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x00065AB0 File Offset: 0x00063CB0
		[CallerCount(0)]
		public unsafe static ulong Mul32x32To64(uint a, uint b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_Mul32x32To64_Private_Static_UInt64_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x00065AFC File Offset: 0x00063CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1318003, XrefRangeEnd = 1318006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong Mul64Lossy(ulong a, ulong b, ref int pexp)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pexp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_Mul64Lossy_Private_Static_UInt64_UInt64_UInt64_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x00065B58 File Offset: 0x00063D58
		[CallerCount(0)]
		public unsafe static int abs(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_abs_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x00065B98 File Offset: 0x00063D98
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1318046, RefRangeEnd = 1318053, XrefRangeStart = 1318006, XrefRangeEnd = 1318046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double NumberToDouble(ref Number.NumberBuffer number)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &number;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_NumberToDouble_Private_Static_Double_byref_NumberBuffer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x00065BD8 File Offset: 0x00063DD8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1318060, RefRangeEnd = 1318066, XrefRangeStart = 1318053, XrefRangeEnd = 1318060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DoubleToNumber(double value, int precision, ref Number.NumberBuffer number)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref precision;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_DoubleToNumber_Private_Static_Void_Double_Int32_byref_NumberBuffer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x00005379 File Offset: 0x00003579
		public Number(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000D90 RID: 3472 RVA: 0x00065C28 File Offset: 0x00063E28
		// (set) Token: 0x06000D91 RID: 3473 RVA: 0x00005382 File Offset: 0x00003582
		public unsafe static Il2CppStringArray s_posCurrencyFormats
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Number.NativeFieldInfoPtr_s_posCurrencyFormats, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Number.NativeFieldInfoPtr_s_posCurrencyFormats, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000D92 RID: 3474 RVA: 0x00065C50 File Offset: 0x00063E50
		// (set) Token: 0x06000D93 RID: 3475 RVA: 0x00005394 File Offset: 0x00003594
		public unsafe static Il2CppStringArray s_negCurrencyFormats
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Number.NativeFieldInfoPtr_s_negCurrencyFormats, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Number.NativeFieldInfoPtr_s_negCurrencyFormats, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000D94 RID: 3476 RVA: 0x00065C78 File Offset: 0x00063E78
		// (set) Token: 0x06000D95 RID: 3477 RVA: 0x000053A6 File Offset: 0x000035A6
		public unsafe static Il2CppStringArray s_posPercentFormats
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Number.NativeFieldInfoPtr_s_posPercentFormats, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Number.NativeFieldInfoPtr_s_posPercentFormats, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000D96 RID: 3478 RVA: 0x00065CA0 File Offset: 0x00063EA0
		// (set) Token: 0x06000D97 RID: 3479 RVA: 0x000053B8 File Offset: 0x000035B8
		public unsafe static Il2CppStringArray s_negPercentFormats
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Number.NativeFieldInfoPtr_s_negPercentFormats, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Number.NativeFieldInfoPtr_s_negPercentFormats, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000D98 RID: 3480 RVA: 0x00065CC8 File Offset: 0x00063EC8
		// (set) Token: 0x06000D99 RID: 3481 RVA: 0x000053CA File Offset: 0x000035CA
		public unsafe static Il2CppStringArray s_negNumberFormats
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Number.NativeFieldInfoPtr_s_negNumberFormats, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Number.NativeFieldInfoPtr_s_negNumberFormats, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000D9A RID: 3482 RVA: 0x00065CF0 File Offset: 0x00063EF0
		// (set) Token: 0x06000D9B RID: 3483 RVA: 0x000053DC File Offset: 0x000035DC
		public unsafe static Il2CppStructArray<int> s_charToHexLookup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Number.NativeFieldInfoPtr_s_charToHexLookup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Number.NativeFieldInfoPtr_s_charToHexLookup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000D9C RID: 3484 RVA: 0x00065D18 File Offset: 0x00063F18
		// (set) Token: 0x06000D9D RID: 3485 RVA: 0x000053EE File Offset: 0x000035EE
		public unsafe static Il2CppStructArray<ulong> s_rgval64Power10
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Number.NativeFieldInfoPtr_s_rgval64Power10, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ulong>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Number.NativeFieldInfoPtr_s_rgval64Power10, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000D9E RID: 3486 RVA: 0x00065D40 File Offset: 0x00063F40
		// (set) Token: 0x06000D9F RID: 3487 RVA: 0x00005400 File Offset: 0x00003600
		public unsafe static Il2CppStructArray<sbyte> s_rgexp64Power10
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Number.NativeFieldInfoPtr_s_rgexp64Power10, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Number.NativeFieldInfoPtr_s_rgexp64Power10, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000DA0 RID: 3488 RVA: 0x00065D68 File Offset: 0x00063F68
		// (set) Token: 0x06000DA1 RID: 3489 RVA: 0x00005412 File Offset: 0x00003612
		public unsafe static Il2CppStructArray<ulong> s_rgval64Power10By16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Number.NativeFieldInfoPtr_s_rgval64Power10By16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ulong>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Number.NativeFieldInfoPtr_s_rgval64Power10By16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000DA2 RID: 3490 RVA: 0x00065D90 File Offset: 0x00063F90
		// (set) Token: 0x06000DA3 RID: 3491 RVA: 0x00005424 File Offset: 0x00003624
		public unsafe static Il2CppStructArray<short> s_rgexp64Power10By16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Number.NativeFieldInfoPtr_s_rgexp64Power10By16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Number.NativeFieldInfoPtr_s_rgexp64Power10By16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AD3 RID: 2771
		private static readonly IntPtr NativeFieldInfoPtr_s_posCurrencyFormats;

		// Token: 0x04000AD4 RID: 2772
		private static readonly IntPtr NativeFieldInfoPtr_s_negCurrencyFormats;

		// Token: 0x04000AD5 RID: 2773
		private static readonly IntPtr NativeFieldInfoPtr_s_posPercentFormats;

		// Token: 0x04000AD6 RID: 2774
		private static readonly IntPtr NativeFieldInfoPtr_s_negPercentFormats;

		// Token: 0x04000AD7 RID: 2775
		private static readonly IntPtr NativeFieldInfoPtr_s_negNumberFormats;

		// Token: 0x04000AD8 RID: 2776
		private static readonly IntPtr NativeFieldInfoPtr_s_charToHexLookup;

		// Token: 0x04000AD9 RID: 2777
		private static readonly IntPtr NativeFieldInfoPtr_s_rgval64Power10;

		// Token: 0x04000ADA RID: 2778
		private static readonly IntPtr NativeFieldInfoPtr_s_rgexp64Power10;

		// Token: 0x04000ADB RID: 2779
		private static readonly IntPtr NativeFieldInfoPtr_s_rgval64Power10By16;

		// Token: 0x04000ADC RID: 2780
		private static readonly IntPtr NativeFieldInfoPtr_s_rgexp64Power10By16;

		// Token: 0x04000ADD RID: 2781
		private static readonly IntPtr NativeMethodInfoPtr_FormatDecimal_Public_Static_String_Decimal_ReadOnlySpan_1_Char_NumberFormatInfo_0;

		// Token: 0x04000ADE RID: 2782
		private static readonly IntPtr NativeMethodInfoPtr_TryFormatDecimal_Public_Static_Boolean_Decimal_ReadOnlySpan_1_Char_NumberFormatInfo_Span_1_Char_byref_Int32_0;

		// Token: 0x04000ADF RID: 2783
		private static readonly IntPtr NativeMethodInfoPtr_DecimalToNumber_Private_Static_Void_Decimal_byref_NumberBuffer_0;

		// Token: 0x04000AE0 RID: 2784
		private static readonly IntPtr NativeMethodInfoPtr_FormatDouble_Public_Static_String_Double_String_NumberFormatInfo_0;

		// Token: 0x04000AE1 RID: 2785
		private static readonly IntPtr NativeMethodInfoPtr_TryFormatDouble_Public_Static_Boolean_Double_ReadOnlySpan_1_Char_NumberFormatInfo_Span_1_Char_byref_Int32_0;

		// Token: 0x04000AE2 RID: 2786
		private static readonly IntPtr NativeMethodInfoPtr_FormatDouble_Private_Static_String_byref_ValueStringBuilder_Double_ReadOnlySpan_1_Char_NumberFormatInfo_0;

		// Token: 0x04000AE3 RID: 2787
		private static readonly IntPtr NativeMethodInfoPtr_FormatSingle_Public_Static_String_Single_String_NumberFormatInfo_0;

		// Token: 0x04000AE4 RID: 2788
		private static readonly IntPtr NativeMethodInfoPtr_TryFormatSingle_Public_Static_Boolean_Single_ReadOnlySpan_1_Char_NumberFormatInfo_Span_1_Char_byref_Int32_0;

		// Token: 0x04000AE5 RID: 2789
		private static readonly IntPtr NativeMethodInfoPtr_FormatSingle_Private_Static_String_byref_ValueStringBuilder_Single_ReadOnlySpan_1_Char_NumberFormatInfo_0;

		// Token: 0x04000AE6 RID: 2790
		private static readonly IntPtr NativeMethodInfoPtr_TryCopyTo_Private_Static_Boolean_String_Span_1_Char_byref_Int32_0;

		// Token: 0x04000AE7 RID: 2791
		private static readonly IntPtr NativeMethodInfoPtr_FormatInt32_Public_Static_String_Int32_ReadOnlySpan_1_Char_IFormatProvider_0;

		// Token: 0x04000AE8 RID: 2792
		private static readonly IntPtr NativeMethodInfoPtr_TryFormatInt32_Public_Static_Boolean_Int32_ReadOnlySpan_1_Char_IFormatProvider_Span_1_Char_byref_Int32_0;

		// Token: 0x04000AE9 RID: 2793
		private static readonly IntPtr NativeMethodInfoPtr_FormatUInt32_Public_Static_String_UInt32_ReadOnlySpan_1_Char_IFormatProvider_0;

		// Token: 0x04000AEA RID: 2794
		private static readonly IntPtr NativeMethodInfoPtr_TryFormatUInt32_Public_Static_Boolean_UInt32_ReadOnlySpan_1_Char_IFormatProvider_Span_1_Char_byref_Int32_0;

		// Token: 0x04000AEB RID: 2795
		private static readonly IntPtr NativeMethodInfoPtr_FormatInt64_Public_Static_String_Int64_ReadOnlySpan_1_Char_IFormatProvider_0;

		// Token: 0x04000AEC RID: 2796
		private static readonly IntPtr NativeMethodInfoPtr_TryFormatInt64_Public_Static_Boolean_Int64_ReadOnlySpan_1_Char_IFormatProvider_Span_1_Char_byref_Int32_0;

		// Token: 0x04000AED RID: 2797
		private static readonly IntPtr NativeMethodInfoPtr_FormatUInt64_Public_Static_String_UInt64_ReadOnlySpan_1_Char_IFormatProvider_0;

		// Token: 0x04000AEE RID: 2798
		private static readonly IntPtr NativeMethodInfoPtr_TryFormatUInt64_Public_Static_Boolean_UInt64_ReadOnlySpan_1_Char_IFormatProvider_Span_1_Char_byref_Int32_0;

		// Token: 0x04000AEF RID: 2799
		private static readonly IntPtr NativeMethodInfoPtr_Int32ToNumber_Private_Static_Void_Int32_byref_NumberBuffer_0;

		// Token: 0x04000AF0 RID: 2800
		private static readonly IntPtr NativeMethodInfoPtr_NegativeInt32ToDecStr_Private_Static_String_Int32_Int32_String_0;

		// Token: 0x04000AF1 RID: 2801
		private static readonly IntPtr NativeMethodInfoPtr_TryNegativeInt32ToDecStr_Private_Static_Boolean_Int32_Int32_String_Span_1_Char_byref_Int32_0;

		// Token: 0x04000AF2 RID: 2802
		private static readonly IntPtr NativeMethodInfoPtr_Int32ToHexStr_Private_Static_String_Int32_Char_Int32_0;

		// Token: 0x04000AF3 RID: 2803
		private static readonly IntPtr NativeMethodInfoPtr_TryInt32ToHexStr_Private_Static_Boolean_Int32_Char_Int32_Span_1_Char_byref_Int32_0;

		// Token: 0x04000AF4 RID: 2804
		private static readonly IntPtr NativeMethodInfoPtr_Int32ToHexChars_Private_Static_ptr_Char_ptr_Char_UInt32_Int32_Int32_0;

		// Token: 0x04000AF5 RID: 2805
		private static readonly IntPtr NativeMethodInfoPtr_UInt32ToNumber_Private_Static_Void_UInt32_byref_NumberBuffer_0;

		// Token: 0x04000AF6 RID: 2806
		private static readonly IntPtr NativeMethodInfoPtr_UInt32ToDecChars_Internal_Static_ptr_Char_ptr_Char_UInt32_Int32_0;

		// Token: 0x04000AF7 RID: 2807
		private static readonly IntPtr NativeMethodInfoPtr_UInt32ToDecStr_Private_Static_String_UInt32_Int32_0;

		// Token: 0x04000AF8 RID: 2808
		private static readonly IntPtr NativeMethodInfoPtr_TryUInt32ToDecStr_Private_Static_Boolean_UInt32_Int32_Span_1_Char_byref_Int32_0;

		// Token: 0x04000AF9 RID: 2809
		private static readonly IntPtr NativeMethodInfoPtr_Int64ToNumber_Private_Static_Void_Int64_byref_NumberBuffer_0;

		// Token: 0x04000AFA RID: 2810
		private static readonly IntPtr NativeMethodInfoPtr_NegativeInt64ToDecStr_Private_Static_String_Int64_Int32_String_0;

		// Token: 0x04000AFB RID: 2811
		private static readonly IntPtr NativeMethodInfoPtr_TryNegativeInt64ToDecStr_Private_Static_Boolean_Int64_Int32_String_Span_1_Char_byref_Int32_0;

		// Token: 0x04000AFC RID: 2812
		private static readonly IntPtr NativeMethodInfoPtr_Int64ToHexStr_Private_Static_String_Int64_Char_Int32_0;

		// Token: 0x04000AFD RID: 2813
		private static readonly IntPtr NativeMethodInfoPtr_TryInt64ToHexStr_Private_Static_Boolean_Int64_Char_Int32_Span_1_Char_byref_Int32_0;

		// Token: 0x04000AFE RID: 2814
		private static readonly IntPtr NativeMethodInfoPtr_UInt64ToNumber_Private_Static_Void_UInt64_byref_NumberBuffer_0;

		// Token: 0x04000AFF RID: 2815
		private static readonly IntPtr NativeMethodInfoPtr_UInt64ToDecStr_Private_Static_String_UInt64_Int32_0;

		// Token: 0x04000B00 RID: 2816
		private static readonly IntPtr NativeMethodInfoPtr_TryUInt64ToDecStr_Private_Static_Boolean_UInt64_Int32_Span_1_Char_byref_Int32_0;

		// Token: 0x04000B01 RID: 2817
		private static readonly IntPtr NativeMethodInfoPtr_ParseFormatSpecifier_Internal_Static_Char_ReadOnlySpan_1_Char_byref_Int32_0;

		// Token: 0x04000B02 RID: 2818
		private static readonly IntPtr NativeMethodInfoPtr_NumberToString_Internal_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Char_Int32_NumberFormatInfo_Boolean_0;

		// Token: 0x04000B03 RID: 2819
		private static readonly IntPtr NativeMethodInfoPtr_NumberToStringFormat_Internal_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_ReadOnlySpan_1_Char_NumberFormatInfo_0;

		// Token: 0x04000B04 RID: 2820
		private static readonly IntPtr NativeMethodInfoPtr_FormatCurrency_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_0;

		// Token: 0x04000B05 RID: 2821
		private static readonly IntPtr NativeMethodInfoPtr_FormatFixed_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_Il2CppStructArray_1_Int32_String_String_0;

		// Token: 0x04000B06 RID: 2822
		private static readonly IntPtr NativeMethodInfoPtr_FormatNumber_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_0;

		// Token: 0x04000B07 RID: 2823
		private static readonly IntPtr NativeMethodInfoPtr_FormatScientific_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_Char_0;

		// Token: 0x04000B08 RID: 2824
		private static readonly IntPtr NativeMethodInfoPtr_FormatExponent_Private_Static_Void_byref_ValueStringBuilder_NumberFormatInfo_Int32_Char_Int32_Boolean_0;

		// Token: 0x04000B09 RID: 2825
		private static readonly IntPtr NativeMethodInfoPtr_FormatGeneral_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_Char_Boolean_0;

		// Token: 0x04000B0A RID: 2826
		private static readonly IntPtr NativeMethodInfoPtr_FormatPercent_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_0;

		// Token: 0x04000B0B RID: 2827
		private static readonly IntPtr NativeMethodInfoPtr_RoundNumber_Private_Static_Void_byref_NumberBuffer_Int32_0;

		// Token: 0x04000B0C RID: 2828
		private static readonly IntPtr NativeMethodInfoPtr_FindSection_Private_Static_Int32_ReadOnlySpan_1_Char_Int32_0;

		// Token: 0x04000B0D RID: 2829
		private static readonly IntPtr NativeMethodInfoPtr_Low32_Private_Static_UInt32_UInt64_0;

		// Token: 0x04000B0E RID: 2830
		private static readonly IntPtr NativeMethodInfoPtr_High32_Private_Static_UInt32_UInt64_0;

		// Token: 0x04000B0F RID: 2831
		private static readonly IntPtr NativeMethodInfoPtr_Int64DivMod1E9_Private_Static_UInt32_byref_UInt64_0;

		// Token: 0x04000B10 RID: 2832
		private static readonly IntPtr NativeMethodInfoPtr_NumberToInt32_Private_Static_Boolean_byref_NumberBuffer_byref_Int32_0;

		// Token: 0x04000B11 RID: 2833
		private static readonly IntPtr NativeMethodInfoPtr_NumberToInt64_Private_Static_Boolean_byref_NumberBuffer_byref_Int64_0;

		// Token: 0x04000B12 RID: 2834
		private static readonly IntPtr NativeMethodInfoPtr_NumberToUInt32_Private_Static_Boolean_byref_NumberBuffer_byref_UInt32_0;

		// Token: 0x04000B13 RID: 2835
		private static readonly IntPtr NativeMethodInfoPtr_NumberToUInt64_Private_Static_Boolean_byref_NumberBuffer_byref_UInt64_0;

		// Token: 0x04000B14 RID: 2836
		private static readonly IntPtr NativeMethodInfoPtr_ParseInt32_Internal_Static_Int32_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0;

		// Token: 0x04000B15 RID: 2837
		private static readonly IntPtr NativeMethodInfoPtr_ParseInt64_Internal_Static_Int64_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0;

		// Token: 0x04000B16 RID: 2838
		private static readonly IntPtr NativeMethodInfoPtr_ParseUInt32_Internal_Static_UInt32_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0;

		// Token: 0x04000B17 RID: 2839
		private static readonly IntPtr NativeMethodInfoPtr_ParseUInt64_Internal_Static_UInt64_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0;

		// Token: 0x04000B18 RID: 2840
		private static readonly IntPtr NativeMethodInfoPtr_ParseNumber_Private_Static_Boolean_byref_ptr_Char_ptr_Char_NumberStyles_byref_NumberBuffer_NumberFormatInfo_Boolean_0;

		// Token: 0x04000B19 RID: 2841
		private static readonly IntPtr NativeMethodInfoPtr_TryParseInt32_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_Int32_0;

		// Token: 0x04000B1A RID: 2842
		private static readonly IntPtr NativeMethodInfoPtr_TryParseInt32IntegerStyle_Private_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_Int32_byref_Boolean_0;

		// Token: 0x04000B1B RID: 2843
		private static readonly IntPtr NativeMethodInfoPtr_TryParseInt64IntegerStyle_Private_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_Int64_byref_Boolean_0;

		// Token: 0x04000B1C RID: 2844
		private static readonly IntPtr NativeMethodInfoPtr_TryParseInt64_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_Int64_0;

		// Token: 0x04000B1D RID: 2845
		private static readonly IntPtr NativeMethodInfoPtr_TryParseUInt32_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_UInt32_0;

		// Token: 0x04000B1E RID: 2846
		private static readonly IntPtr NativeMethodInfoPtr_TryParseUInt32IntegerStyle_Private_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_UInt32_byref_Boolean_0;

		// Token: 0x04000B1F RID: 2847
		private static readonly IntPtr NativeMethodInfoPtr_TryParseUInt32HexNumberStyle_Private_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_UInt32_byref_Boolean_0;

		// Token: 0x04000B20 RID: 2848
		private static readonly IntPtr NativeMethodInfoPtr_TryParseUInt64_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_UInt64_0;

		// Token: 0x04000B21 RID: 2849
		private static readonly IntPtr NativeMethodInfoPtr_TryParseUInt64IntegerStyle_Private_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_UInt64_byref_Boolean_0;

		// Token: 0x04000B22 RID: 2850
		private static readonly IntPtr NativeMethodInfoPtr_TryParseUInt64HexNumberStyle_Private_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_UInt64_byref_Boolean_0;

		// Token: 0x04000B23 RID: 2851
		private static readonly IntPtr NativeMethodInfoPtr_ParseDecimal_Internal_Static_Decimal_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0;

		// Token: 0x04000B24 RID: 2852
		private static readonly IntPtr NativeMethodInfoPtr_NumberBufferToDecimal_Private_Static_Boolean_byref_NumberBuffer_byref_Decimal_0;

		// Token: 0x04000B25 RID: 2853
		private static readonly IntPtr NativeMethodInfoPtr_ParseDouble_Internal_Static_Double_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0;

		// Token: 0x04000B26 RID: 2854
		private static readonly IntPtr NativeMethodInfoPtr_ParseSingle_Internal_Static_Single_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_0;

		// Token: 0x04000B27 RID: 2855
		private static readonly IntPtr NativeMethodInfoPtr_TryParseDecimal_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_Decimal_0;

		// Token: 0x04000B28 RID: 2856
		private static readonly IntPtr NativeMethodInfoPtr_TryParseDouble_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_Double_0;

		// Token: 0x04000B29 RID: 2857
		private static readonly IntPtr NativeMethodInfoPtr_TryParseSingle_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_NumberFormatInfo_byref_Single_0;

		// Token: 0x04000B2A RID: 2858
		private static readonly IntPtr NativeMethodInfoPtr_StringToNumber_Private_Static_Void_ReadOnlySpan_1_Char_NumberStyles_byref_NumberBuffer_NumberFormatInfo_Boolean_0;

		// Token: 0x04000B2B RID: 2859
		private static readonly IntPtr NativeMethodInfoPtr_TryStringToNumber_Internal_Static_Boolean_ReadOnlySpan_1_Char_NumberStyles_byref_NumberBuffer_NumberFormatInfo_Boolean_0;

		// Token: 0x04000B2C RID: 2860
		private static readonly IntPtr NativeMethodInfoPtr_TrailingZeros_Private_Static_Boolean_ReadOnlySpan_1_Char_Int32_0;

		// Token: 0x04000B2D RID: 2861
		private static readonly IntPtr NativeMethodInfoPtr_MatchChars_Private_Static_ptr_Char_ptr_Char_ptr_Char_String_0;

		// Token: 0x04000B2E RID: 2862
		private static readonly IntPtr NativeMethodInfoPtr_IsWhite_Private_Static_Boolean_Int32_0;

		// Token: 0x04000B2F RID: 2863
		private static readonly IntPtr NativeMethodInfoPtr_IsDigit_Private_Static_Boolean_Int32_0;

		// Token: 0x04000B30 RID: 2864
		private static readonly IntPtr NativeMethodInfoPtr_ThrowOverflowOrFormatException_Private_Static_Void_Boolean_String_0;

		// Token: 0x04000B31 RID: 2865
		private static readonly IntPtr NativeMethodInfoPtr_NumberBufferToDouble_Private_Static_Boolean_byref_NumberBuffer_byref_Double_0;

		// Token: 0x04000B32 RID: 2866
		private static readonly IntPtr NativeMethodInfoPtr_DigitsToInt_Private_Static_UInt32_ptr_Char_Int32_0;

		// Token: 0x04000B33 RID: 2867
		private static readonly IntPtr NativeMethodInfoPtr_Mul32x32To64_Private_Static_UInt64_UInt32_UInt32_0;

		// Token: 0x04000B34 RID: 2868
		private static readonly IntPtr NativeMethodInfoPtr_Mul64Lossy_Private_Static_UInt64_UInt64_UInt64_byref_Int32_0;

		// Token: 0x04000B35 RID: 2869
		private static readonly IntPtr NativeMethodInfoPtr_abs_Private_Static_Int32_Int32_0;

		// Token: 0x04000B36 RID: 2870
		private static readonly IntPtr NativeMethodInfoPtr_NumberToDouble_Private_Static_Double_byref_NumberBuffer_0;

		// Token: 0x04000B37 RID: 2871
		private static readonly IntPtr NativeMethodInfoPtr_DoubleToNumber_Private_Static_Void_Double_Int32_byref_NumberBuffer_0;

		// Token: 0x0200059D RID: 1437
		[StructLayout(2)]
		public struct NumberBuffer
		{
			// Token: 0x060056BB RID: 22203 RVA: 0x00190258 File Offset: 0x0018E458
			// Note: this type is marked as 'beforefieldinit'.
			static NumberBuffer()
			{
				Il2CppClassPointerStore<Number.NumberBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Number>.NativeClassPtr, "NumberBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Number.NumberBuffer>.NativeClassPtr);
				Number.NumberBuffer.NativeFieldInfoPtr_precision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Number.NumberBuffer>.NativeClassPtr, "precision");
				Number.NumberBuffer.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Number.NumberBuffer>.NativeClassPtr, "scale");
				Number.NumberBuffer.NativeFieldInfoPtr__sign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Number.NumberBuffer>.NativeClassPtr, "_sign");
				Number.NumberBuffer.NativeFieldInfoPtr__digits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Number.NumberBuffer>.NativeClassPtr, "_digits");
				Number.NumberBuffer.NativeFieldInfoPtr__allDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Number.NumberBuffer>.NativeClassPtr, "_allDigits");
				Number.NumberBuffer.NativeMethodInfoPtr_get_sign_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number.NumberBuffer>.NativeClassPtr, 100665699);
				Number.NumberBuffer.NativeMethodInfoPtr_set_sign_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number.NumberBuffer>.NativeClassPtr, 100665700);
				Number.NumberBuffer.NativeMethodInfoPtr_get_digits_Public_get_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number.NumberBuffer>.NativeClassPtr, 100665701);
			}

			// Token: 0x17001629 RID: 5673
			// (get) Token: 0x060056BC RID: 22204 RVA: 0x00190324 File Offset: 0x0018E524
			// (set) Token: 0x060056BD RID: 22205 RVA: 0x00190354 File Offset: 0x0018E554
			public unsafe bool sign
			{
				[CallerCount(17)]
				[CachedScanResults(RefRangeStart = 1316430, RefRangeEnd = 1316447, XrefRangeStart = 1316430, XrefRangeEnd = 1316430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NumberBuffer.NativeMethodInfoPtr_get_sign_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 1316447, RefRangeEnd = 1316461, XrefRangeStart = 1316447, XrefRangeEnd = 1316447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NumberBuffer.NativeMethodInfoPtr_set_sign_Public_set_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700162A RID: 5674
			// (get) Token: 0x060056BE RID: 22206 RVA: 0x00190388 File Offset: 0x0018E588
			public unsafe char* digits
			{
				[CallerCount(31)]
				[CachedScanResults(RefRangeStart = 1316461, RefRangeEnd = 1316492, XrefRangeStart = 1316461, XrefRangeEnd = 1316461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NumberBuffer.NativeMethodInfoPtr_get_digits_Public_get_ptr_Char_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}

			// Token: 0x060056BF RID: 22207 RVA: 0x0001EDBC File Offset: 0x0001CFBC
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Number.NumberBuffer>.NativeClassPtr, ref this));
			}

			// Token: 0x0400471D RID: 18205
			private static readonly IntPtr NativeFieldInfoPtr_precision;

			// Token: 0x0400471E RID: 18206
			private static readonly IntPtr NativeFieldInfoPtr_scale;

			// Token: 0x0400471F RID: 18207
			private static readonly IntPtr NativeFieldInfoPtr__sign;

			// Token: 0x04004720 RID: 18208
			private static readonly IntPtr NativeFieldInfoPtr__digits;

			// Token: 0x04004721 RID: 18209
			private static readonly IntPtr NativeFieldInfoPtr__allDigits;

			// Token: 0x04004722 RID: 18210
			private static readonly IntPtr NativeMethodInfoPtr_get_sign_Public_get_Boolean_0;

			// Token: 0x04004723 RID: 18211
			private static readonly IntPtr NativeMethodInfoPtr_set_sign_Public_set_Void_Boolean_0;

			// Token: 0x04004724 RID: 18212
			private static readonly IntPtr NativeMethodInfoPtr_get_digits_Public_get_ptr_Char_0;

			// Token: 0x04004725 RID: 18213
			[FieldOffset(0)]
			public int precision;

			// Token: 0x04004726 RID: 18214
			[FieldOffset(4)]
			public int scale;

			// Token: 0x04004727 RID: 18215
			[FieldOffset(8)]
			public int _sign;

			// Token: 0x04004728 RID: 18216
			[FieldOffset(12)]
			public Number.NumberBuffer.DigitsAndNullTerminator _digits;

			// Token: 0x04004729 RID: 18217
			[FieldOffset(114)]
			public IntPtr _allDigits;

			// Token: 0x02000786 RID: 1926
			[StructLayout(2)]
			public struct DigitsAndNullTerminator
			{
				// Token: 0x060062F3 RID: 25331 RVA: 0x000250AC File Offset: 0x000232AC
				// Note: this type is marked as 'beforefieldinit'.
				static DigitsAndNullTerminator()
				{
					Il2CppClassPointerStore<Number.NumberBuffer.DigitsAndNullTerminator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Number.NumberBuffer>.NativeClassPtr, "DigitsAndNullTerminator");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Number.NumberBuffer.DigitsAndNullTerminator>.NativeClassPtr);
				}

				// Token: 0x060062F4 RID: 25332 RVA: 0x000250CC File Offset: 0x000232CC
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Number.NumberBuffer.DigitsAndNullTerminator>.NativeClassPtr, ref this));
				}
			}
		}
	}
}
