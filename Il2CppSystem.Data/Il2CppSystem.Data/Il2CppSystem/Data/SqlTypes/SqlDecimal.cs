using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Data.SqlTypes
{
	// Token: 0x02000093 RID: 147
	[Serializable]
	[StructLayout(2)]
	public struct SqlDecimal
	{
		// Token: 0x06000E6C RID: 3692 RVA: 0x00046D10 File Offset: 0x00044F10
		// Note: this type is marked as 'beforefieldinit'.
		static SqlDecimal()
		{
			Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data.SqlTypes", "SqlDecimal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr);
			SqlDecimal.NativeFieldInfoPtr__bStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "_bStatus");
			SqlDecimal.NativeFieldInfoPtr__bLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "_bLen");
			SqlDecimal.NativeFieldInfoPtr__bPrec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "_bPrec");
			SqlDecimal.NativeFieldInfoPtr__bScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "_bScale");
			SqlDecimal.NativeFieldInfoPtr__data1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "_data1");
			SqlDecimal.NativeFieldInfoPtr__data2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "_data2");
			SqlDecimal.NativeFieldInfoPtr__data3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "_data3");
			SqlDecimal.NativeFieldInfoPtr__data4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "_data4");
			SqlDecimal.NativeFieldInfoPtr_s_NUMERIC_MAX_PRECISION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_NUMERIC_MAX_PRECISION");
			SqlDecimal.NativeFieldInfoPtr_MaxPrecision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "MaxPrecision");
			SqlDecimal.NativeFieldInfoPtr_MaxScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "MaxScale");
			SqlDecimal.NativeFieldInfoPtr_s_bNullMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_bNullMask");
			SqlDecimal.NativeFieldInfoPtr_s_bIsNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_bIsNull");
			SqlDecimal.NativeFieldInfoPtr_s_bNotNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_bNotNull");
			SqlDecimal.NativeFieldInfoPtr_s_bReverseNullMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_bReverseNullMask");
			SqlDecimal.NativeFieldInfoPtr_s_bSignMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_bSignMask");
			SqlDecimal.NativeFieldInfoPtr_s_bPositive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_bPositive");
			SqlDecimal.NativeFieldInfoPtr_s_bNegative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_bNegative");
			SqlDecimal.NativeFieldInfoPtr_s_bReverseSignMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_bReverseSignMask");
			SqlDecimal.NativeFieldInfoPtr_s_uiZero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_uiZero");
			SqlDecimal.NativeFieldInfoPtr_s_cNumeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_cNumeMax");
			SqlDecimal.NativeFieldInfoPtr_s_lInt32Base = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_lInt32Base");
			SqlDecimal.NativeFieldInfoPtr_s_ulInt32Base = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_ulInt32Base");
			SqlDecimal.NativeFieldInfoPtr_s_ulInt32BaseForMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_ulInt32BaseForMod");
			SqlDecimal.NativeFieldInfoPtr_s_llMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_llMax");
			SqlDecimal.NativeFieldInfoPtr_s_ulBase10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_ulBase10");
			SqlDecimal.NativeFieldInfoPtr_s_DUINT_BASE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_DUINT_BASE");
			SqlDecimal.NativeFieldInfoPtr_s_DUINT_BASE2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_DUINT_BASE2");
			SqlDecimal.NativeFieldInfoPtr_s_DUINT_BASE3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_DUINT_BASE3");
			SqlDecimal.NativeFieldInfoPtr_s_DMAX_NUME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_DMAX_NUME");
			SqlDecimal.NativeFieldInfoPtr_s_DBL_DIG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_DBL_DIG");
			SqlDecimal.NativeFieldInfoPtr_s_cNumeDivScaleMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_cNumeDivScaleMin");
			SqlDecimal.NativeFieldInfoPtr_s_rgulShiftBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_rgulShiftBase");
			SqlDecimal.NativeFieldInfoPtr_s_decimalHelpersLo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_decimalHelpersLo");
			SqlDecimal.NativeFieldInfoPtr_s_decimalHelpersMid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_decimalHelpersMid");
			SqlDecimal.NativeFieldInfoPtr_s_decimalHelpersHi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_decimalHelpersHi");
			SqlDecimal.NativeFieldInfoPtr_s_decimalHelpersHiHi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_decimalHelpersHiHi");
			SqlDecimal.NativeFieldInfoPtr_s_rgCLenFromPrec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_rgCLenFromPrec");
			SqlDecimal.NativeFieldInfoPtr_s_ulT1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_ulT1");
			SqlDecimal.NativeFieldInfoPtr_s_ulT2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_ulT2");
			SqlDecimal.NativeFieldInfoPtr_s_ulT3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_ulT3");
			SqlDecimal.NativeFieldInfoPtr_s_ulT4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_ulT4");
			SqlDecimal.NativeFieldInfoPtr_s_ulT5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_ulT5");
			SqlDecimal.NativeFieldInfoPtr_s_ulT6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_ulT6");
			SqlDecimal.NativeFieldInfoPtr_s_ulT7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_ulT7");
			SqlDecimal.NativeFieldInfoPtr_s_ulT8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_ulT8");
			SqlDecimal.NativeFieldInfoPtr_s_ulT9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_ulT9");
			SqlDecimal.NativeFieldInfoPtr_s_dwlT10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_dwlT10");
			SqlDecimal.NativeFieldInfoPtr_s_dwlT11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_dwlT11");
			SqlDecimal.NativeFieldInfoPtr_s_dwlT12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_dwlT12");
			SqlDecimal.NativeFieldInfoPtr_s_dwlT13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_dwlT13");
			SqlDecimal.NativeFieldInfoPtr_s_dwlT14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_dwlT14");
			SqlDecimal.NativeFieldInfoPtr_s_dwlT15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_dwlT15");
			SqlDecimal.NativeFieldInfoPtr_s_dwlT16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_dwlT16");
			SqlDecimal.NativeFieldInfoPtr_s_dwlT17 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_dwlT17");
			SqlDecimal.NativeFieldInfoPtr_s_dwlT18 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_dwlT18");
			SqlDecimal.NativeFieldInfoPtr_s_dwlT19 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "s_dwlT19");
			SqlDecimal.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "Null");
			SqlDecimal.NativeFieldInfoPtr_MinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "MinValue");
			SqlDecimal.NativeFieldInfoPtr_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, "MaxValue");
			SqlDecimal.NativeMethodInfoPtr_CalculatePrecision_Private_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665636);
			SqlDecimal.NativeMethodInfoPtr_VerifyPrecision_Private_Boolean_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665637);
			SqlDecimal.NativeMethodInfoPtr__ctor_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665638);
			SqlDecimal.NativeMethodInfoPtr__ctor_Public_Void_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665639);
			SqlDecimal.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665640);
			SqlDecimal.NativeMethodInfoPtr__ctor_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665641);
			SqlDecimal.NativeMethodInfoPtr__ctor_Private_Void_Il2CppStructArray_1_UInt32_Byte_Byte_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665642);
			SqlDecimal.NativeMethodInfoPtr_get_IsNull_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665643);
			SqlDecimal.NativeMethodInfoPtr_get_Value_Public_get_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665644);
			SqlDecimal.NativeMethodInfoPtr_get_IsPositive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665645);
			SqlDecimal.NativeMethodInfoPtr_SetPositive_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665646);
			SqlDecimal.NativeMethodInfoPtr_SetSignBit_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665647);
			SqlDecimal.NativeMethodInfoPtr_get_Scale_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665648);
			SqlDecimal.NativeMethodInfoPtr_get_Data_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665649);
			SqlDecimal.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665650);
			SqlDecimal.NativeMethodInfoPtr_Parse_Public_Static_SqlDecimal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665651);
			SqlDecimal.NativeMethodInfoPtr_ToDouble_Public_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665652);
			SqlDecimal.NativeMethodInfoPtr_ToDecimal_Private_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665653);
			SqlDecimal.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDecimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665654);
			SqlDecimal.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDecimal_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665655);
			SqlDecimal.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_SqlDecimal_SqlDecimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665656);
			SqlDecimal.NativeMethodInfoPtr_op_Addition_Public_Static_SqlDecimal_SqlDecimal_SqlDecimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665657);
			SqlDecimal.NativeMethodInfoPtr_op_Subtraction_Public_Static_SqlDecimal_SqlDecimal_SqlDecimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665658);
			SqlDecimal.NativeMethodInfoPtr_op_Multiply_Public_Static_SqlDecimal_SqlDecimal_SqlDecimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665659);
			SqlDecimal.NativeMethodInfoPtr_op_Division_Public_Static_SqlDecimal_SqlDecimal_SqlDecimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665660);
			SqlDecimal.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDecimal_SqlByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665661);
			SqlDecimal.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDecimal_SqlInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665662);
			SqlDecimal.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDecimal_SqlInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665663);
			SqlDecimal.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDecimal_SqlInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665664);
			SqlDecimal.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDecimal_SqlMoney_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665665);
			SqlDecimal.NativeMethodInfoPtr_ZeroToMaxLen_Private_Static_Void_Il2CppStructArray_1_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665666);
			SqlDecimal.NativeMethodInfoPtr_FZero_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665667);
			SqlDecimal.NativeMethodInfoPtr_FGt10_38_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665668);
			SqlDecimal.NativeMethodInfoPtr_FGt10_38_Private_Boolean_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665669);
			SqlDecimal.NativeMethodInfoPtr_BGetPrecUI4_Private_Static_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665670);
			SqlDecimal.NativeMethodInfoPtr_BGetPrecUI8_Private_Static_Byte_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665671);
			SqlDecimal.NativeMethodInfoPtr_AddULong_Private_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665672);
			SqlDecimal.NativeMethodInfoPtr_MultByULong_Private_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665673);
			SqlDecimal.NativeMethodInfoPtr_DivByULong_Private_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665674);
			SqlDecimal.NativeMethodInfoPtr_AdjustScale_Internal_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665675);
			SqlDecimal.NativeMethodInfoPtr_LAbsCmp_Private_Int32_SqlDecimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665676);
			SqlDecimal.NativeMethodInfoPtr_MpMove_Private_Static_Void_Il2CppStructArray_1_UInt32_Int32_Il2CppStructArray_1_UInt32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665677);
			SqlDecimal.NativeMethodInfoPtr_MpSet_Private_Static_Void_Il2CppStructArray_1_UInt32_byref_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665678);
			SqlDecimal.NativeMethodInfoPtr_MpNormalize_Private_Static_Void_Il2CppStructArray_1_UInt32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665679);
			SqlDecimal.NativeMethodInfoPtr_MpMul1_Private_Static_Void_Il2CppStructArray_1_UInt32_byref_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665680);
			SqlDecimal.NativeMethodInfoPtr_MpDiv1_Private_Static_Void_Il2CppStructArray_1_UInt32_byref_Int32_UInt32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665681);
			SqlDecimal.NativeMethodInfoPtr_DWL_Internal_Static_UInt64_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665682);
			SqlDecimal.NativeMethodInfoPtr_HI_Private_Static_UInt32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665683);
			SqlDecimal.NativeMethodInfoPtr_LO_Private_Static_UInt32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665684);
			SqlDecimal.NativeMethodInfoPtr_MpDiv_Private_Static_Void_Il2CppStructArray_1_UInt32_Int32_Il2CppStructArray_1_UInt32_Int32_Il2CppStructArray_1_UInt32_byref_Int32_Il2CppStructArray_1_UInt32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665685);
			SqlDecimal.NativeMethodInfoPtr_CompareNm_Private_EComparison_SqlDecimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665686);
			SqlDecimal.NativeMethodInfoPtr_CheckValidPrecScale_Private_Static_Void_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665687);
			SqlDecimal.NativeMethodInfoPtr_op_Equality_Public_Static_SqlBoolean_SqlDecimal_SqlDecimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665688);
			SqlDecimal.NativeMethodInfoPtr_op_LessThan_Public_Static_SqlBoolean_SqlDecimal_SqlDecimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665689);
			SqlDecimal.NativeMethodInfoPtr_op_GreaterThan_Public_Static_SqlBoolean_SqlDecimal_SqlDecimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665690);
			SqlDecimal.NativeMethodInfoPtr_LessThan_Public_Static_SqlBoolean_SqlDecimal_SqlDecimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665691);
			SqlDecimal.NativeMethodInfoPtr_GreaterThan_Public_Static_SqlBoolean_SqlDecimal_SqlDecimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665692);
			SqlDecimal.NativeMethodInfoPtr_ToSqlDouble_Public_SqlDouble_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665693);
			SqlDecimal.NativeMethodInfoPtr_ToSqlInt64_Public_SqlInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665694);
			SqlDecimal.NativeMethodInfoPtr_ToSqlMoney_Public_SqlMoney_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665695);
			SqlDecimal.NativeMethodInfoPtr_ChFromDigit_Private_Static_Char_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665696);
			SqlDecimal.NativeMethodInfoPtr_StoreFromWorkingArray_Private_Void_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665697);
			SqlDecimal.NativeMethodInfoPtr_SetToZero_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665698);
			SqlDecimal.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665699);
			SqlDecimal.NativeMethodInfoPtr_CompareTo_Public_Int32_SqlDecimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665700);
			SqlDecimal.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665701);
			SqlDecimal.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665702);
			SqlDecimal.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665703);
			SqlDecimal.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665704);
			SqlDecimal.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665705);
			SqlDecimal.NativeMethodInfoPtr_GetXsdType_Public_Static_XmlQualifiedName_XmlSchemaSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, 100665706);
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x0004777C File Offset: 0x0004597C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 916739, RefRangeEnd = 916742, XrefRangeStart = 916714, XrefRangeEnd = 916739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe byte CalculatePrecision()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_CalculatePrecision_Private_Byte_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x000477AC File Offset: 0x000459AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 916759, RefRangeEnd = 916760, XrefRangeStart = 916742, XrefRangeEnd = 916759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool VerifyPrecision(byte precision)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref precision;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_VerifyPrecision_Private_Boolean_Byte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x000477EC File Offset: 0x000459EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916760, XrefRangeEnd = 916764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlDecimal(bool fNull)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fNull;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr__ctor_Private_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x00047820 File Offset: 0x00045A20
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 916781, RefRangeEnd = 916785, XrefRangeStart = 916764, XrefRangeEnd = 916781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlDecimal(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr__ctor_Public_Void_Decimal_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x00047854 File Offset: 0x00045A54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916785, XrefRangeEnd = 916819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlDecimal(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x00047888 File Offset: 0x00045A88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 916829, RefRangeEnd = 916830, XrefRangeStart = 916819, XrefRangeEnd = 916829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlDecimal(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr__ctor_Public_Void_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x000478BC File Offset: 0x00045ABC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 916852, RefRangeEnd = 916856, XrefRangeStart = 916830, XrefRangeEnd = 916852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlDecimal(Il2CppStructArray<uint> rglData, byte bLen, byte bPrec, byte bScale, bool fPositive)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rglData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bLen;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bPrec;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bScale;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fPositive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr__ctor_Private_Void_Il2CppStructArray_1_UInt32_Byte_Byte_Byte_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000E74 RID: 3700 RVA: 0x0004792C File Offset: 0x00045B2C
		public unsafe bool IsNull
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 916860, RefRangeEnd = 916862, XrefRangeStart = 916856, XrefRangeEnd = 916860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_get_IsNull_Public_Virtual_Final_New_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000E75 RID: 3701 RVA: 0x0004795C File Offset: 0x00045B5C
		public unsafe Decimal Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916862, XrefRangeEnd = 916866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_get_Value_Public_get_Decimal_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000E76 RID: 3702 RVA: 0x0004798C File Offset: 0x00045B8C
		public unsafe bool IsPositive
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 916876, RefRangeEnd = 916891, XrefRangeStart = 916866, XrefRangeEnd = 916876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_get_IsPositive_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x000479BC File Offset: 0x00045BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916891, XrefRangeEnd = 916895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPositive()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_SetPositive_Private_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x000479E4 File Offset: 0x00045BE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 916899, RefRangeEnd = 916900, XrefRangeStart = 916895, XrefRangeEnd = 916899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSignBit(bool fPositive)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fPositive;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_SetSignBit_Private_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000E79 RID: 3705 RVA: 0x00047A18 File Offset: 0x00045C18
		public unsafe byte Scale
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 916908, RefRangeEnd = 916909, XrefRangeStart = 916900, XrefRangeEnd = 916908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_get_Scale_Public_get_Byte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000E7A RID: 3706 RVA: 0x00047A48 File Offset: 0x00045C48
		public unsafe Il2CppStructArray<int> Data
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 916920, RefRangeEnd = 916921, XrefRangeStart = 916909, XrefRangeEnd = 916920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_get_Data_Public_get_Il2CppStructArray_1_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x00047A7C File Offset: 0x00045C7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 916958, RefRangeEnd = 916959, XrefRangeStart = 916921, XrefRangeEnd = 916958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x00047AA8 File Offset: 0x00045CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916959, XrefRangeEnd = 917006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlDecimal Parse(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_Parse_Public_Static_SqlDecimal_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x00047AEC File Offset: 0x00045CEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 917021, RefRangeEnd = 917022, XrefRangeStart = 917006, XrefRangeEnd = 917021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double ToDouble()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_ToDouble_Public_Double_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x00047B1C File Offset: 0x00045D1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 917033, RefRangeEnd = 917034, XrefRangeStart = 917022, XrefRangeEnd = 917033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Decimal ToDecimal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_ToDecimal_Private_Decimal_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x00047B4C File Offset: 0x00045D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 917034, XrefRangeEnd = 917035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SqlDecimal(Decimal x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDecimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x00047B8C File Offset: 0x00045D8C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 917037, RefRangeEnd = 917047, XrefRangeStart = 917035, XrefRangeEnd = 917037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SqlDecimal(long x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDecimal_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x00047BCC File Offset: 0x00045DCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 917063, RefRangeEnd = 917064, XrefRangeStart = 917047, XrefRangeEnd = 917063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlDecimal operator -(SqlDecimal x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_SqlDecimal_SqlDecimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x00047C0C File Offset: 0x00045E0C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 917132, RefRangeEnd = 917138, XrefRangeStart = 917064, XrefRangeEnd = 917132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlDecimal operator +(SqlDecimal x, SqlDecimal y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_op_Addition_Public_Static_SqlDecimal_SqlDecimal_SqlDecimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x00047C58 File Offset: 0x00045E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 917138, XrefRangeEnd = 917166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlDecimal operator -(SqlDecimal x, SqlDecimal y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_op_Subtraction_Public_Static_SqlDecimal_SqlDecimal_SqlDecimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x00047CA4 File Offset: 0x00045EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 917166, XrefRangeEnd = 917240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlDecimal operator *(SqlDecimal x, SqlDecimal y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_op_Multiply_Public_Static_SqlDecimal_SqlDecimal_SqlDecimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x00047CF0 File Offset: 0x00045EF0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 917299, RefRangeEnd = 917302, XrefRangeStart = 917240, XrefRangeEnd = 917299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlDecimal operator /(SqlDecimal x, SqlDecimal y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_op_Division_Public_Static_SqlDecimal_SqlDecimal_SqlDecimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x00047D3C File Offset: 0x00045F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 917302, XrefRangeEnd = 917310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SqlDecimal(SqlByte x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDecimal_SqlByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x00047D7C File Offset: 0x00045F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 917310, XrefRangeEnd = 917318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SqlDecimal(SqlInt16 x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDecimal_SqlInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x00047DBC File Offset: 0x00045FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 917318, XrefRangeEnd = 917325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SqlDecimal(SqlInt32 x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDecimal_SqlInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x00047DFC File Offset: 0x00045FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 917325, XrefRangeEnd = 917333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SqlDecimal(SqlInt64 x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDecimal_SqlInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x00047E3C File Offset: 0x0004603C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 917341, RefRangeEnd = 917342, XrefRangeStart = 917333, XrefRangeEnd = 917341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SqlDecimal(SqlMoney x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDecimal_SqlMoney_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x00047E7C File Offset: 0x0004607C
		[CallerCount(0)]
		public unsafe static void ZeroToMaxLen(Il2CppStructArray<uint> rgulData, int cUI4sCur)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgulData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cUI4sCur;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_ZeroToMaxLen_Private_Static_Void_Il2CppStructArray_1_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x00047EC0 File Offset: 0x000460C0
		[CallerCount(0)]
		public unsafe bool FZero()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_FZero_Private_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x00047EF0 File Offset: 0x000460F0
		[CallerCount(0)]
		public unsafe bool FGt10_38()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_FGt10_38_Private_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x00047F20 File Offset: 0x00046120
		[CallerCount(0)]
		public unsafe bool FGt10_38(Il2CppStructArray<uint> rglData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rglData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_FGt10_38_Private_Boolean_Il2CppStructArray_1_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x00047F64 File Offset: 0x00046164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 917342, XrefRangeEnd = 917350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte BGetPrecUI4(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_BGetPrecUI4_Private_Static_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x00047FA4 File Offset: 0x000461A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 917360, RefRangeEnd = 917361, XrefRangeStart = 917350, XrefRangeEnd = 917360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte BGetPrecUI8(ulong dwlVal)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dwlVal;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_BGetPrecUI8_Private_Static_Byte_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x00047FE4 File Offset: 0x000461E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 917374, RefRangeEnd = 917375, XrefRangeStart = 917361, XrefRangeEnd = 917374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddULong(uint ulAdd)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ulAdd;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_AddULong_Private_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x00048018 File Offset: 0x00046218
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 917390, RefRangeEnd = 917392, XrefRangeStart = 917375, XrefRangeEnd = 917390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MultByULong(uint uiMultiplier)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uiMultiplier;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_MultByULong_Private_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x0004804C File Offset: 0x0004624C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 917399, RefRangeEnd = 917400, XrefRangeStart = 917392, XrefRangeEnd = 917399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint DivByULong(uint iDivisor)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iDivisor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_DivByULong_Private_UInt32_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x0004808C File Offset: 0x0004628C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 917436, RefRangeEnd = 917445, XrefRangeStart = 917400, XrefRangeEnd = 917436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AdjustScale(int digits, bool fRound)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref digits;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fRound;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_AdjustScale_Internal_Void_Int32_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x000480CC File Offset: 0x000462CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 917450, RefRangeEnd = 917452, XrefRangeStart = 917445, XrefRangeEnd = 917450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LAbsCmp(SqlDecimal snumOp)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snumOp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_LAbsCmp_Private_Int32_SqlDecimal_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x0004810C File Offset: 0x0004630C
		[CallerCount(0)]
		public unsafe static void MpMove(Il2CppStructArray<uint> rgulS, int ciulS, Il2CppStructArray<uint> rgulD, out int ciulD)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgulS);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ciulS;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rgulD);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ciulD;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_MpMove_Private_Static_Void_Il2CppStructArray_1_UInt32_Int32_Il2CppStructArray_1_UInt32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x00048170 File Offset: 0x00046370
		[CallerCount(0)]
		public unsafe static void MpSet(Il2CppStructArray<uint> rgulD, out int ciulD, uint iulN)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgulD);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ciulD;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iulN;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_MpSet_Private_Static_Void_Il2CppStructArray_1_UInt32_byref_Int32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x000481C4 File Offset: 0x000463C4
		[CallerCount(0)]
		public unsafe static void MpNormalize(Il2CppStructArray<uint> rgulU, ref int ciulU)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgulU);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ciulU;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_MpNormalize_Private_Static_Void_Il2CppStructArray_1_UInt32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x00048208 File Offset: 0x00046408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 917452, XrefRangeEnd = 917455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MpMul1(Il2CppStructArray<uint> piulD, ref int ciulD, uint iulX)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(piulD);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ciulD;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iulX;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_MpMul1_Private_Static_Void_Il2CppStructArray_1_UInt32_byref_Int32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x0004825C File Offset: 0x0004645C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 917455, XrefRangeEnd = 917458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MpDiv1(Il2CppStructArray<uint> rgulU, ref int ciulU, uint iulD, out uint iulR)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgulU);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ciulU;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iulD;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &iulR;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_MpDiv1_Private_Static_Void_Il2CppStructArray_1_UInt32_byref_Int32_UInt32_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x000482BC File Offset: 0x000464BC
		[CallerCount(0)]
		public unsafe static ulong DWL(uint lo, uint hi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lo;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_DWL_Internal_Static_UInt64_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x00048308 File Offset: 0x00046508
		[CallerCount(0)]
		public unsafe static uint HI(ulong x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_HI_Private_Static_UInt32_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x00048348 File Offset: 0x00046548
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint LO(ulong x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_LO_Private_Static_UInt32_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x00048388 File Offset: 0x00046588
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 917459, RefRangeEnd = 917460, XrefRangeStart = 917458, XrefRangeEnd = 917459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MpDiv(Il2CppStructArray<uint> rgulU, int ciulU, Il2CppStructArray<uint> rgulD, int ciulD, Il2CppStructArray<uint> rgulQ, out int ciulQ, Il2CppStructArray<uint> rgulR, out int ciulR)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgulU);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ciulU;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rgulD);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ciulD;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rgulQ);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ciulQ;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rgulR);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ciulR;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_MpDiv_Private_Static_Void_Il2CppStructArray_1_UInt32_Int32_Il2CppStructArray_1_UInt32_Int32_Il2CppStructArray_1_UInt32_byref_Int32_Il2CppStructArray_1_UInt32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x00048430 File Offset: 0x00046630
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 917482, RefRangeEnd = 917486, XrefRangeStart = 917460, XrefRangeEnd = 917482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EComparison CompareNm(SqlDecimal snumOp)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snumOp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_CompareNm_Private_EComparison_SqlDecimal_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x00048470 File Offset: 0x00046670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 917486, XrefRangeEnd = 917492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckValidPrecScale(byte bPrec, byte bScale)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bPrec;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_CheckValidPrecScale_Private_Static_Void_Byte_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x000484B0 File Offset: 0x000466B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 917492, XrefRangeEnd = 917510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean operator ==(SqlDecimal x, SqlDecimal y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_op_Equality_Public_Static_SqlBoolean_SqlDecimal_SqlDecimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x000484FC File Offset: 0x000466FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 917528, RefRangeEnd = 917530, XrefRangeStart = 917510, XrefRangeEnd = 917528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean operator <(SqlDecimal x, SqlDecimal y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_op_LessThan_Public_Static_SqlBoolean_SqlDecimal_SqlDecimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x00048548 File Offset: 0x00046748
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 917548, RefRangeEnd = 917550, XrefRangeStart = 917530, XrefRangeEnd = 917548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean operator >(SqlDecimal x, SqlDecimal y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_op_GreaterThan_Public_Static_SqlBoolean_SqlDecimal_SqlDecimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x00048594 File Offset: 0x00046794
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 917554, RefRangeEnd = 917555, XrefRangeStart = 917550, XrefRangeEnd = 917554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean LessThan(SqlDecimal x, SqlDecimal y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_LessThan_Public_Static_SqlBoolean_SqlDecimal_SqlDecimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x000485E0 File Offset: 0x000467E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 917559, RefRangeEnd = 917560, XrefRangeStart = 917555, XrefRangeEnd = 917559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SqlBoolean GreaterThan(SqlDecimal x, SqlDecimal y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_GreaterThan_Public_Static_SqlBoolean_SqlDecimal_SqlDecimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x0004862C File Offset: 0x0004682C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 917578, RefRangeEnd = 917581, XrefRangeStart = 917560, XrefRangeEnd = 917578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlDouble ToSqlDouble()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_ToSqlDouble_Public_SqlDouble_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x0004865C File Offset: 0x0004685C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 917585, RefRangeEnd = 917586, XrefRangeStart = 917581, XrefRangeEnd = 917585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlInt64 ToSqlInt64()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_ToSqlInt64_Public_SqlInt64_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x0004868C File Offset: 0x0004688C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 917601, RefRangeEnd = 917602, XrefRangeStart = 917586, XrefRangeEnd = 917601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SqlMoney ToSqlMoney()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_ToSqlMoney_Public_SqlMoney_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x000486BC File Offset: 0x000468BC
		[CallerCount(0)]
		public unsafe static char ChFromDigit(uint uiDigit)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uiDigit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_ChFromDigit_Private_Static_Char_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x000486FC File Offset: 0x000468FC
		[CallerCount(0)]
		public unsafe void StoreFromWorkingArray(Il2CppStructArray<uint> rguiData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rguiData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_StoreFromWorkingArray_Private_Void_Il2CppStructArray_1_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x00048734 File Offset: 0x00046934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 917602, XrefRangeEnd = 917606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetToZero()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_SetToZero_Private_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x0004875C File Offset: 0x0004695C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 917606, XrefRangeEnd = 917612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x000487A0 File Offset: 0x000469A0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 917638, RefRangeEnd = 917642, XrefRangeStart = 917612, XrefRangeEnd = 917638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(SqlDecimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_CompareTo_Public_Int32_SqlDecimal_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x000487E0 File Offset: 0x000469E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 917642, XrefRangeEnd = 917683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x00048824 File Offset: 0x00046A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 917683, XrefRangeEnd = 917696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x00048854 File Offset: 0x00046A54
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchema System_Xml_Serialization_IXmlSerializable_GetSchema()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x00048888 File Offset: 0x00046A88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 917696, XrefRangeEnd = 917708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Xml_Serialization_IXmlSerializable_ReadXml(XmlReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x000488C0 File Offset: 0x00046AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 917708, XrefRangeEnd = 917727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Xml_Serialization_IXmlSerializable_WriteXml(XmlWriter writer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x000488F8 File Offset: 0x00046AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 917727, XrefRangeEnd = 917735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaSet);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SqlDecimal.NativeMethodInfoPtr_GetXsdType_Public_Static_XmlQualifiedName_XmlSchemaSet_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x000067CE File Offset: 0x000049CE
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SqlDecimal>.NativeClassPtr, ref this));
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000EB5 RID: 3765 RVA: 0x0004893C File Offset: 0x00046B3C
		// (set) Token: 0x06000EB6 RID: 3766 RVA: 0x000067E0 File Offset: 0x000049E0
		public unsafe static byte s_NUMERIC_MAX_PRECISION
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_NUMERIC_MAX_PRECISION, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_NUMERIC_MAX_PRECISION, (void*)(&value));
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000EB7 RID: 3767 RVA: 0x00048958 File Offset: 0x00046B58
		// (set) Token: 0x06000EB8 RID: 3768 RVA: 0x000067EE File Offset: 0x000049EE
		public unsafe static byte MaxPrecision
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_MaxPrecision, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_MaxPrecision, (void*)(&value));
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000EB9 RID: 3769 RVA: 0x00048974 File Offset: 0x00046B74
		// (set) Token: 0x06000EBA RID: 3770 RVA: 0x000067FC File Offset: 0x000049FC
		public unsafe static byte MaxScale
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_MaxScale, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_MaxScale, (void*)(&value));
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000EBB RID: 3771 RVA: 0x00048990 File Offset: 0x00046B90
		// (set) Token: 0x06000EBC RID: 3772 RVA: 0x0000680A File Offset: 0x00004A0A
		public unsafe static byte s_bNullMask
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_bNullMask, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_bNullMask, (void*)(&value));
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000EBD RID: 3773 RVA: 0x000489AC File Offset: 0x00046BAC
		// (set) Token: 0x06000EBE RID: 3774 RVA: 0x00006818 File Offset: 0x00004A18
		public unsafe static byte s_bIsNull
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_bIsNull, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_bIsNull, (void*)(&value));
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000EBF RID: 3775 RVA: 0x000489C8 File Offset: 0x00046BC8
		// (set) Token: 0x06000EC0 RID: 3776 RVA: 0x00006826 File Offset: 0x00004A26
		public unsafe static byte s_bNotNull
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_bNotNull, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_bNotNull, (void*)(&value));
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000EC1 RID: 3777 RVA: 0x000489E4 File Offset: 0x00046BE4
		// (set) Token: 0x06000EC2 RID: 3778 RVA: 0x00006834 File Offset: 0x00004A34
		public unsafe static byte s_bReverseNullMask
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_bReverseNullMask, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_bReverseNullMask, (void*)(&value));
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000EC3 RID: 3779 RVA: 0x00048A00 File Offset: 0x00046C00
		// (set) Token: 0x06000EC4 RID: 3780 RVA: 0x00006842 File Offset: 0x00004A42
		public unsafe static byte s_bSignMask
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_bSignMask, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_bSignMask, (void*)(&value));
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000EC5 RID: 3781 RVA: 0x00048A1C File Offset: 0x00046C1C
		// (set) Token: 0x06000EC6 RID: 3782 RVA: 0x00006850 File Offset: 0x00004A50
		public unsafe static byte s_bPositive
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_bPositive, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_bPositive, (void*)(&value));
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000EC7 RID: 3783 RVA: 0x00048A38 File Offset: 0x00046C38
		// (set) Token: 0x06000EC8 RID: 3784 RVA: 0x0000685E File Offset: 0x00004A5E
		public unsafe static byte s_bNegative
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_bNegative, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_bNegative, (void*)(&value));
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000EC9 RID: 3785 RVA: 0x00048A54 File Offset: 0x00046C54
		// (set) Token: 0x06000ECA RID: 3786 RVA: 0x0000686C File Offset: 0x00004A6C
		public unsafe static byte s_bReverseSignMask
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_bReverseSignMask, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_bReverseSignMask, (void*)(&value));
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000ECB RID: 3787 RVA: 0x00048A70 File Offset: 0x00046C70
		// (set) Token: 0x06000ECC RID: 3788 RVA: 0x0000687A File Offset: 0x00004A7A
		public unsafe static uint s_uiZero
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_uiZero, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_uiZero, (void*)(&value));
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000ECD RID: 3789 RVA: 0x00048A8C File Offset: 0x00046C8C
		// (set) Token: 0x06000ECE RID: 3790 RVA: 0x00006888 File Offset: 0x00004A88
		public unsafe static int s_cNumeMax
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_cNumeMax, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_cNumeMax, (void*)(&value));
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000ECF RID: 3791 RVA: 0x00048AA8 File Offset: 0x00046CA8
		// (set) Token: 0x06000ED0 RID: 3792 RVA: 0x00006896 File Offset: 0x00004A96
		public unsafe static long s_lInt32Base
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_lInt32Base, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_lInt32Base, (void*)(&value));
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000ED1 RID: 3793 RVA: 0x00048AC4 File Offset: 0x00046CC4
		// (set) Token: 0x06000ED2 RID: 3794 RVA: 0x000068A4 File Offset: 0x00004AA4
		public unsafe static ulong s_ulInt32Base
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_ulInt32Base, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_ulInt32Base, (void*)(&value));
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000ED3 RID: 3795 RVA: 0x00048AE0 File Offset: 0x00046CE0
		// (set) Token: 0x06000ED4 RID: 3796 RVA: 0x000068B2 File Offset: 0x00004AB2
		public unsafe static ulong s_ulInt32BaseForMod
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_ulInt32BaseForMod, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_ulInt32BaseForMod, (void*)(&value));
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000ED5 RID: 3797 RVA: 0x00048AFC File Offset: 0x00046CFC
		// (set) Token: 0x06000ED6 RID: 3798 RVA: 0x000068C0 File Offset: 0x00004AC0
		public unsafe static ulong s_llMax
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_llMax, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_llMax, (void*)(&value));
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000ED7 RID: 3799 RVA: 0x00048B18 File Offset: 0x00046D18
		// (set) Token: 0x06000ED8 RID: 3800 RVA: 0x000068CE File Offset: 0x00004ACE
		public unsafe static uint s_ulBase10
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_ulBase10, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_ulBase10, (void*)(&value));
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000ED9 RID: 3801 RVA: 0x00048B34 File Offset: 0x00046D34
		// (set) Token: 0x06000EDA RID: 3802 RVA: 0x000068DC File Offset: 0x00004ADC
		public unsafe static double s_DUINT_BASE
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_DUINT_BASE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_DUINT_BASE, (void*)(&value));
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000EDB RID: 3803 RVA: 0x00048B50 File Offset: 0x00046D50
		// (set) Token: 0x06000EDC RID: 3804 RVA: 0x000068EA File Offset: 0x00004AEA
		public unsafe static double s_DUINT_BASE2
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_DUINT_BASE2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_DUINT_BASE2, (void*)(&value));
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000EDD RID: 3805 RVA: 0x00048B6C File Offset: 0x00046D6C
		// (set) Token: 0x06000EDE RID: 3806 RVA: 0x000068F8 File Offset: 0x00004AF8
		public unsafe static double s_DUINT_BASE3
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_DUINT_BASE3, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_DUINT_BASE3, (void*)(&value));
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000EDF RID: 3807 RVA: 0x00048B88 File Offset: 0x00046D88
		// (set) Token: 0x06000EE0 RID: 3808 RVA: 0x00006906 File Offset: 0x00004B06
		public unsafe static double s_DMAX_NUME
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_DMAX_NUME, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_DMAX_NUME, (void*)(&value));
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000EE1 RID: 3809 RVA: 0x00048BA4 File Offset: 0x00046DA4
		// (set) Token: 0x06000EE2 RID: 3810 RVA: 0x00006914 File Offset: 0x00004B14
		public unsafe static uint s_DBL_DIG
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_DBL_DIG, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_DBL_DIG, (void*)(&value));
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000EE3 RID: 3811 RVA: 0x00048BC0 File Offset: 0x00046DC0
		// (set) Token: 0x06000EE4 RID: 3812 RVA: 0x00006922 File Offset: 0x00004B22
		public unsafe static byte s_cNumeDivScaleMin
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_cNumeDivScaleMin, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_cNumeDivScaleMin, (void*)(&value));
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000EE5 RID: 3813 RVA: 0x00048BDC File Offset: 0x00046DDC
		// (set) Token: 0x06000EE6 RID: 3814 RVA: 0x00006930 File Offset: 0x00004B30
		public unsafe static Il2CppStructArray<uint> s_rgulShiftBase
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_rgulShiftBase, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_rgulShiftBase, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000EE7 RID: 3815 RVA: 0x00048C04 File Offset: 0x00046E04
		// (set) Token: 0x06000EE8 RID: 3816 RVA: 0x00006942 File Offset: 0x00004B42
		public unsafe static Il2CppStructArray<uint> s_decimalHelpersLo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_decimalHelpersLo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_decimalHelpersLo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000EE9 RID: 3817 RVA: 0x00048C2C File Offset: 0x00046E2C
		// (set) Token: 0x06000EEA RID: 3818 RVA: 0x00006954 File Offset: 0x00004B54
		public unsafe static Il2CppStructArray<uint> s_decimalHelpersMid
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_decimalHelpersMid, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_decimalHelpersMid, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000EEB RID: 3819 RVA: 0x00048C54 File Offset: 0x00046E54
		// (set) Token: 0x06000EEC RID: 3820 RVA: 0x00006966 File Offset: 0x00004B66
		public unsafe static Il2CppStructArray<uint> s_decimalHelpersHi
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_decimalHelpersHi, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_decimalHelpersHi, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000EED RID: 3821 RVA: 0x00048C7C File Offset: 0x00046E7C
		// (set) Token: 0x06000EEE RID: 3822 RVA: 0x00006978 File Offset: 0x00004B78
		public unsafe static Il2CppStructArray<uint> s_decimalHelpersHiHi
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_decimalHelpersHiHi, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_decimalHelpersHiHi, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000EEF RID: 3823 RVA: 0x00048CA4 File Offset: 0x00046EA4
		// (set) Token: 0x06000EF0 RID: 3824 RVA: 0x0000698A File Offset: 0x00004B8A
		public unsafe static Il2CppStructArray<byte> s_rgCLenFromPrec
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_rgCLenFromPrec, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_rgCLenFromPrec, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000EF1 RID: 3825 RVA: 0x00048CCC File Offset: 0x00046ECC
		// (set) Token: 0x06000EF2 RID: 3826 RVA: 0x0000699C File Offset: 0x00004B9C
		public unsafe static uint s_ulT1
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_ulT1, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_ulT1, (void*)(&value));
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000EF3 RID: 3827 RVA: 0x00048CE8 File Offset: 0x00046EE8
		// (set) Token: 0x06000EF4 RID: 3828 RVA: 0x000069AA File Offset: 0x00004BAA
		public unsafe static uint s_ulT2
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_ulT2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_ulT2, (void*)(&value));
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000EF5 RID: 3829 RVA: 0x00048D04 File Offset: 0x00046F04
		// (set) Token: 0x06000EF6 RID: 3830 RVA: 0x000069B8 File Offset: 0x00004BB8
		public unsafe static uint s_ulT3
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_ulT3, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_ulT3, (void*)(&value));
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000EF7 RID: 3831 RVA: 0x00048D20 File Offset: 0x00046F20
		// (set) Token: 0x06000EF8 RID: 3832 RVA: 0x000069C6 File Offset: 0x00004BC6
		public unsafe static uint s_ulT4
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_ulT4, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_ulT4, (void*)(&value));
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000EF9 RID: 3833 RVA: 0x00048D3C File Offset: 0x00046F3C
		// (set) Token: 0x06000EFA RID: 3834 RVA: 0x000069D4 File Offset: 0x00004BD4
		public unsafe static uint s_ulT5
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_ulT5, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_ulT5, (void*)(&value));
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000EFB RID: 3835 RVA: 0x00048D58 File Offset: 0x00046F58
		// (set) Token: 0x06000EFC RID: 3836 RVA: 0x000069E2 File Offset: 0x00004BE2
		public unsafe static uint s_ulT6
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_ulT6, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_ulT6, (void*)(&value));
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000EFD RID: 3837 RVA: 0x00048D74 File Offset: 0x00046F74
		// (set) Token: 0x06000EFE RID: 3838 RVA: 0x000069F0 File Offset: 0x00004BF0
		public unsafe static uint s_ulT7
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_ulT7, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_ulT7, (void*)(&value));
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000EFF RID: 3839 RVA: 0x00048D90 File Offset: 0x00046F90
		// (set) Token: 0x06000F00 RID: 3840 RVA: 0x000069FE File Offset: 0x00004BFE
		public unsafe static uint s_ulT8
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_ulT8, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_ulT8, (void*)(&value));
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000F01 RID: 3841 RVA: 0x00048DAC File Offset: 0x00046FAC
		// (set) Token: 0x06000F02 RID: 3842 RVA: 0x00006A0C File Offset: 0x00004C0C
		public unsafe static uint s_ulT9
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_ulT9, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_ulT9, (void*)(&value));
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000F03 RID: 3843 RVA: 0x00048DC8 File Offset: 0x00046FC8
		// (set) Token: 0x06000F04 RID: 3844 RVA: 0x00006A1A File Offset: 0x00004C1A
		public unsafe static ulong s_dwlT10
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_dwlT10, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_dwlT10, (void*)(&value));
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000F05 RID: 3845 RVA: 0x00048DE4 File Offset: 0x00046FE4
		// (set) Token: 0x06000F06 RID: 3846 RVA: 0x00006A28 File Offset: 0x00004C28
		public unsafe static ulong s_dwlT11
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_dwlT11, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_dwlT11, (void*)(&value));
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000F07 RID: 3847 RVA: 0x00048E00 File Offset: 0x00047000
		// (set) Token: 0x06000F08 RID: 3848 RVA: 0x00006A36 File Offset: 0x00004C36
		public unsafe static ulong s_dwlT12
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_dwlT12, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_dwlT12, (void*)(&value));
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000F09 RID: 3849 RVA: 0x00048E1C File Offset: 0x0004701C
		// (set) Token: 0x06000F0A RID: 3850 RVA: 0x00006A44 File Offset: 0x00004C44
		public unsafe static ulong s_dwlT13
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_dwlT13, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_dwlT13, (void*)(&value));
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000F0B RID: 3851 RVA: 0x00048E38 File Offset: 0x00047038
		// (set) Token: 0x06000F0C RID: 3852 RVA: 0x00006A52 File Offset: 0x00004C52
		public unsafe static ulong s_dwlT14
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_dwlT14, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_dwlT14, (void*)(&value));
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000F0D RID: 3853 RVA: 0x00048E54 File Offset: 0x00047054
		// (set) Token: 0x06000F0E RID: 3854 RVA: 0x00006A60 File Offset: 0x00004C60
		public unsafe static ulong s_dwlT15
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_dwlT15, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_dwlT15, (void*)(&value));
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000F0F RID: 3855 RVA: 0x00048E70 File Offset: 0x00047070
		// (set) Token: 0x06000F10 RID: 3856 RVA: 0x00006A6E File Offset: 0x00004C6E
		public unsafe static ulong s_dwlT16
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_dwlT16, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_dwlT16, (void*)(&value));
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000F11 RID: 3857 RVA: 0x00048E8C File Offset: 0x0004708C
		// (set) Token: 0x06000F12 RID: 3858 RVA: 0x00006A7C File Offset: 0x00004C7C
		public unsafe static ulong s_dwlT17
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_dwlT17, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_dwlT17, (void*)(&value));
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000F13 RID: 3859 RVA: 0x00048EA8 File Offset: 0x000470A8
		// (set) Token: 0x06000F14 RID: 3860 RVA: 0x00006A8A File Offset: 0x00004C8A
		public unsafe static ulong s_dwlT18
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_dwlT18, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_dwlT18, (void*)(&value));
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000F15 RID: 3861 RVA: 0x00048EC4 File Offset: 0x000470C4
		// (set) Token: 0x06000F16 RID: 3862 RVA: 0x00006A98 File Offset: 0x00004C98
		public unsafe static ulong s_dwlT19
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_s_dwlT19, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_s_dwlT19, (void*)(&value));
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000F17 RID: 3863 RVA: 0x00048EE0 File Offset: 0x000470E0
		// (set) Token: 0x06000F18 RID: 3864 RVA: 0x00006AA6 File Offset: 0x00004CA6
		public unsafe static SqlDecimal Null
		{
			get
			{
				SqlDecimal sqlDecimal;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_Null, (void*)(&sqlDecimal));
				return sqlDecimal;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_Null, (void*)(&value));
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000F19 RID: 3865 RVA: 0x00048EFC File Offset: 0x000470FC
		// (set) Token: 0x06000F1A RID: 3866 RVA: 0x00006AB4 File Offset: 0x00004CB4
		public unsafe static SqlDecimal MinValue
		{
			get
			{
				SqlDecimal sqlDecimal;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_MinValue, (void*)(&sqlDecimal));
				return sqlDecimal;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_MinValue, (void*)(&value));
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000F1B RID: 3867 RVA: 0x00048F18 File Offset: 0x00047118
		// (set) Token: 0x06000F1C RID: 3868 RVA: 0x00006AC2 File Offset: 0x00004CC2
		public unsafe static SqlDecimal MaxValue
		{
			get
			{
				SqlDecimal sqlDecimal;
				IL2CPP.il2cpp_field_static_get_value(SqlDecimal.NativeFieldInfoPtr_MaxValue, (void*)(&sqlDecimal));
				return sqlDecimal;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SqlDecimal.NativeFieldInfoPtr_MaxValue, (void*)(&value));
			}
		}

		// Token: 0x04000BEC RID: 3052
		private static readonly IntPtr NativeFieldInfoPtr__bStatus;

		// Token: 0x04000BED RID: 3053
		private static readonly IntPtr NativeFieldInfoPtr__bLen;

		// Token: 0x04000BEE RID: 3054
		private static readonly IntPtr NativeFieldInfoPtr__bPrec;

		// Token: 0x04000BEF RID: 3055
		private static readonly IntPtr NativeFieldInfoPtr__bScale;

		// Token: 0x04000BF0 RID: 3056
		private static readonly IntPtr NativeFieldInfoPtr__data1;

		// Token: 0x04000BF1 RID: 3057
		private static readonly IntPtr NativeFieldInfoPtr__data2;

		// Token: 0x04000BF2 RID: 3058
		private static readonly IntPtr NativeFieldInfoPtr__data3;

		// Token: 0x04000BF3 RID: 3059
		private static readonly IntPtr NativeFieldInfoPtr__data4;

		// Token: 0x04000BF4 RID: 3060
		private static readonly IntPtr NativeFieldInfoPtr_s_NUMERIC_MAX_PRECISION;

		// Token: 0x04000BF5 RID: 3061
		private static readonly IntPtr NativeFieldInfoPtr_MaxPrecision;

		// Token: 0x04000BF6 RID: 3062
		private static readonly IntPtr NativeFieldInfoPtr_MaxScale;

		// Token: 0x04000BF7 RID: 3063
		private static readonly IntPtr NativeFieldInfoPtr_s_bNullMask;

		// Token: 0x04000BF8 RID: 3064
		private static readonly IntPtr NativeFieldInfoPtr_s_bIsNull;

		// Token: 0x04000BF9 RID: 3065
		private static readonly IntPtr NativeFieldInfoPtr_s_bNotNull;

		// Token: 0x04000BFA RID: 3066
		private static readonly IntPtr NativeFieldInfoPtr_s_bReverseNullMask;

		// Token: 0x04000BFB RID: 3067
		private static readonly IntPtr NativeFieldInfoPtr_s_bSignMask;

		// Token: 0x04000BFC RID: 3068
		private static readonly IntPtr NativeFieldInfoPtr_s_bPositive;

		// Token: 0x04000BFD RID: 3069
		private static readonly IntPtr NativeFieldInfoPtr_s_bNegative;

		// Token: 0x04000BFE RID: 3070
		private static readonly IntPtr NativeFieldInfoPtr_s_bReverseSignMask;

		// Token: 0x04000BFF RID: 3071
		private static readonly IntPtr NativeFieldInfoPtr_s_uiZero;

		// Token: 0x04000C00 RID: 3072
		private static readonly IntPtr NativeFieldInfoPtr_s_cNumeMax;

		// Token: 0x04000C01 RID: 3073
		private static readonly IntPtr NativeFieldInfoPtr_s_lInt32Base;

		// Token: 0x04000C02 RID: 3074
		private static readonly IntPtr NativeFieldInfoPtr_s_ulInt32Base;

		// Token: 0x04000C03 RID: 3075
		private static readonly IntPtr NativeFieldInfoPtr_s_ulInt32BaseForMod;

		// Token: 0x04000C04 RID: 3076
		private static readonly IntPtr NativeFieldInfoPtr_s_llMax;

		// Token: 0x04000C05 RID: 3077
		private static readonly IntPtr NativeFieldInfoPtr_s_ulBase10;

		// Token: 0x04000C06 RID: 3078
		private static readonly IntPtr NativeFieldInfoPtr_s_DUINT_BASE;

		// Token: 0x04000C07 RID: 3079
		private static readonly IntPtr NativeFieldInfoPtr_s_DUINT_BASE2;

		// Token: 0x04000C08 RID: 3080
		private static readonly IntPtr NativeFieldInfoPtr_s_DUINT_BASE3;

		// Token: 0x04000C09 RID: 3081
		private static readonly IntPtr NativeFieldInfoPtr_s_DMAX_NUME;

		// Token: 0x04000C0A RID: 3082
		private static readonly IntPtr NativeFieldInfoPtr_s_DBL_DIG;

		// Token: 0x04000C0B RID: 3083
		private static readonly IntPtr NativeFieldInfoPtr_s_cNumeDivScaleMin;

		// Token: 0x04000C0C RID: 3084
		private static readonly IntPtr NativeFieldInfoPtr_s_rgulShiftBase;

		// Token: 0x04000C0D RID: 3085
		private static readonly IntPtr NativeFieldInfoPtr_s_decimalHelpersLo;

		// Token: 0x04000C0E RID: 3086
		private static readonly IntPtr NativeFieldInfoPtr_s_decimalHelpersMid;

		// Token: 0x04000C0F RID: 3087
		private static readonly IntPtr NativeFieldInfoPtr_s_decimalHelpersHi;

		// Token: 0x04000C10 RID: 3088
		private static readonly IntPtr NativeFieldInfoPtr_s_decimalHelpersHiHi;

		// Token: 0x04000C11 RID: 3089
		private static readonly IntPtr NativeFieldInfoPtr_s_rgCLenFromPrec;

		// Token: 0x04000C12 RID: 3090
		private static readonly IntPtr NativeFieldInfoPtr_s_ulT1;

		// Token: 0x04000C13 RID: 3091
		private static readonly IntPtr NativeFieldInfoPtr_s_ulT2;

		// Token: 0x04000C14 RID: 3092
		private static readonly IntPtr NativeFieldInfoPtr_s_ulT3;

		// Token: 0x04000C15 RID: 3093
		private static readonly IntPtr NativeFieldInfoPtr_s_ulT4;

		// Token: 0x04000C16 RID: 3094
		private static readonly IntPtr NativeFieldInfoPtr_s_ulT5;

		// Token: 0x04000C17 RID: 3095
		private static readonly IntPtr NativeFieldInfoPtr_s_ulT6;

		// Token: 0x04000C18 RID: 3096
		private static readonly IntPtr NativeFieldInfoPtr_s_ulT7;

		// Token: 0x04000C19 RID: 3097
		private static readonly IntPtr NativeFieldInfoPtr_s_ulT8;

		// Token: 0x04000C1A RID: 3098
		private static readonly IntPtr NativeFieldInfoPtr_s_ulT9;

		// Token: 0x04000C1B RID: 3099
		private static readonly IntPtr NativeFieldInfoPtr_s_dwlT10;

		// Token: 0x04000C1C RID: 3100
		private static readonly IntPtr NativeFieldInfoPtr_s_dwlT11;

		// Token: 0x04000C1D RID: 3101
		private static readonly IntPtr NativeFieldInfoPtr_s_dwlT12;

		// Token: 0x04000C1E RID: 3102
		private static readonly IntPtr NativeFieldInfoPtr_s_dwlT13;

		// Token: 0x04000C1F RID: 3103
		private static readonly IntPtr NativeFieldInfoPtr_s_dwlT14;

		// Token: 0x04000C20 RID: 3104
		private static readonly IntPtr NativeFieldInfoPtr_s_dwlT15;

		// Token: 0x04000C21 RID: 3105
		private static readonly IntPtr NativeFieldInfoPtr_s_dwlT16;

		// Token: 0x04000C22 RID: 3106
		private static readonly IntPtr NativeFieldInfoPtr_s_dwlT17;

		// Token: 0x04000C23 RID: 3107
		private static readonly IntPtr NativeFieldInfoPtr_s_dwlT18;

		// Token: 0x04000C24 RID: 3108
		private static readonly IntPtr NativeFieldInfoPtr_s_dwlT19;

		// Token: 0x04000C25 RID: 3109
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x04000C26 RID: 3110
		private static readonly IntPtr NativeFieldInfoPtr_MinValue;

		// Token: 0x04000C27 RID: 3111
		private static readonly IntPtr NativeFieldInfoPtr_MaxValue;

		// Token: 0x04000C28 RID: 3112
		private static readonly IntPtr NativeMethodInfoPtr_CalculatePrecision_Private_Byte_0;

		// Token: 0x04000C29 RID: 3113
		private static readonly IntPtr NativeMethodInfoPtr_VerifyPrecision_Private_Boolean_Byte_0;

		// Token: 0x04000C2A RID: 3114
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Boolean_0;

		// Token: 0x04000C2B RID: 3115
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Decimal_0;

		// Token: 0x04000C2C RID: 3116
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000C2D RID: 3117
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_0;

		// Token: 0x04000C2E RID: 3118
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Il2CppStructArray_1_UInt32_Byte_Byte_Byte_Boolean_0;

		// Token: 0x04000C2F RID: 3119
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNull_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000C30 RID: 3120
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Decimal_0;

		// Token: 0x04000C31 RID: 3121
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPositive_Public_get_Boolean_0;

		// Token: 0x04000C32 RID: 3122
		private static readonly IntPtr NativeMethodInfoPtr_SetPositive_Private_Void_0;

		// Token: 0x04000C33 RID: 3123
		private static readonly IntPtr NativeMethodInfoPtr_SetSignBit_Private_Void_Boolean_0;

		// Token: 0x04000C34 RID: 3124
		private static readonly IntPtr NativeMethodInfoPtr_get_Scale_Public_get_Byte_0;

		// Token: 0x04000C35 RID: 3125
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04000C36 RID: 3126
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000C37 RID: 3127
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_SqlDecimal_String_0;

		// Token: 0x04000C38 RID: 3128
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Double_0;

		// Token: 0x04000C39 RID: 3129
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Private_Decimal_0;

		// Token: 0x04000C3A RID: 3130
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDecimal_Decimal_0;

		// Token: 0x04000C3B RID: 3131
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDecimal_Int64_0;

		// Token: 0x04000C3C RID: 3132
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_SqlDecimal_SqlDecimal_0;

		// Token: 0x04000C3D RID: 3133
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_SqlDecimal_SqlDecimal_SqlDecimal_0;

		// Token: 0x04000C3E RID: 3134
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_SqlDecimal_SqlDecimal_SqlDecimal_0;

		// Token: 0x04000C3F RID: 3135
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_SqlDecimal_SqlDecimal_SqlDecimal_0;

		// Token: 0x04000C40 RID: 3136
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_SqlDecimal_SqlDecimal_SqlDecimal_0;

		// Token: 0x04000C41 RID: 3137
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDecimal_SqlByte_0;

		// Token: 0x04000C42 RID: 3138
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDecimal_SqlInt16_0;

		// Token: 0x04000C43 RID: 3139
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDecimal_SqlInt32_0;

		// Token: 0x04000C44 RID: 3140
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDecimal_SqlInt64_0;

		// Token: 0x04000C45 RID: 3141
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SqlDecimal_SqlMoney_0;

		// Token: 0x04000C46 RID: 3142
		private static readonly IntPtr NativeMethodInfoPtr_ZeroToMaxLen_Private_Static_Void_Il2CppStructArray_1_UInt32_Int32_0;

		// Token: 0x04000C47 RID: 3143
		private static readonly IntPtr NativeMethodInfoPtr_FZero_Private_Boolean_0;

		// Token: 0x04000C48 RID: 3144
		private static readonly IntPtr NativeMethodInfoPtr_FGt10_38_Private_Boolean_0;

		// Token: 0x04000C49 RID: 3145
		private static readonly IntPtr NativeMethodInfoPtr_FGt10_38_Private_Boolean_Il2CppStructArray_1_UInt32_0;

		// Token: 0x04000C4A RID: 3146
		private static readonly IntPtr NativeMethodInfoPtr_BGetPrecUI4_Private_Static_Byte_UInt32_0;

		// Token: 0x04000C4B RID: 3147
		private static readonly IntPtr NativeMethodInfoPtr_BGetPrecUI8_Private_Static_Byte_UInt64_0;

		// Token: 0x04000C4C RID: 3148
		private static readonly IntPtr NativeMethodInfoPtr_AddULong_Private_Void_UInt32_0;

		// Token: 0x04000C4D RID: 3149
		private static readonly IntPtr NativeMethodInfoPtr_MultByULong_Private_Void_UInt32_0;

		// Token: 0x04000C4E RID: 3150
		private static readonly IntPtr NativeMethodInfoPtr_DivByULong_Private_UInt32_UInt32_0;

		// Token: 0x04000C4F RID: 3151
		private static readonly IntPtr NativeMethodInfoPtr_AdjustScale_Internal_Void_Int32_Boolean_0;

		// Token: 0x04000C50 RID: 3152
		private static readonly IntPtr NativeMethodInfoPtr_LAbsCmp_Private_Int32_SqlDecimal_0;

		// Token: 0x04000C51 RID: 3153
		private static readonly IntPtr NativeMethodInfoPtr_MpMove_Private_Static_Void_Il2CppStructArray_1_UInt32_Int32_Il2CppStructArray_1_UInt32_byref_Int32_0;

		// Token: 0x04000C52 RID: 3154
		private static readonly IntPtr NativeMethodInfoPtr_MpSet_Private_Static_Void_Il2CppStructArray_1_UInt32_byref_Int32_UInt32_0;

		// Token: 0x04000C53 RID: 3155
		private static readonly IntPtr NativeMethodInfoPtr_MpNormalize_Private_Static_Void_Il2CppStructArray_1_UInt32_byref_Int32_0;

		// Token: 0x04000C54 RID: 3156
		private static readonly IntPtr NativeMethodInfoPtr_MpMul1_Private_Static_Void_Il2CppStructArray_1_UInt32_byref_Int32_UInt32_0;

		// Token: 0x04000C55 RID: 3157
		private static readonly IntPtr NativeMethodInfoPtr_MpDiv1_Private_Static_Void_Il2CppStructArray_1_UInt32_byref_Int32_UInt32_byref_UInt32_0;

		// Token: 0x04000C56 RID: 3158
		private static readonly IntPtr NativeMethodInfoPtr_DWL_Internal_Static_UInt64_UInt32_UInt32_0;

		// Token: 0x04000C57 RID: 3159
		private static readonly IntPtr NativeMethodInfoPtr_HI_Private_Static_UInt32_UInt64_0;

		// Token: 0x04000C58 RID: 3160
		private static readonly IntPtr NativeMethodInfoPtr_LO_Private_Static_UInt32_UInt64_0;

		// Token: 0x04000C59 RID: 3161
		private static readonly IntPtr NativeMethodInfoPtr_MpDiv_Private_Static_Void_Il2CppStructArray_1_UInt32_Int32_Il2CppStructArray_1_UInt32_Int32_Il2CppStructArray_1_UInt32_byref_Int32_Il2CppStructArray_1_UInt32_byref_Int32_0;

		// Token: 0x04000C5A RID: 3162
		private static readonly IntPtr NativeMethodInfoPtr_CompareNm_Private_EComparison_SqlDecimal_0;

		// Token: 0x04000C5B RID: 3163
		private static readonly IntPtr NativeMethodInfoPtr_CheckValidPrecScale_Private_Static_Void_Byte_Byte_0;

		// Token: 0x04000C5C RID: 3164
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_SqlBoolean_SqlDecimal_SqlDecimal_0;

		// Token: 0x04000C5D RID: 3165
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_SqlBoolean_SqlDecimal_SqlDecimal_0;

		// Token: 0x04000C5E RID: 3166
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_SqlBoolean_SqlDecimal_SqlDecimal_0;

		// Token: 0x04000C5F RID: 3167
		private static readonly IntPtr NativeMethodInfoPtr_LessThan_Public_Static_SqlBoolean_SqlDecimal_SqlDecimal_0;

		// Token: 0x04000C60 RID: 3168
		private static readonly IntPtr NativeMethodInfoPtr_GreaterThan_Public_Static_SqlBoolean_SqlDecimal_SqlDecimal_0;

		// Token: 0x04000C61 RID: 3169
		private static readonly IntPtr NativeMethodInfoPtr_ToSqlDouble_Public_SqlDouble_0;

		// Token: 0x04000C62 RID: 3170
		private static readonly IntPtr NativeMethodInfoPtr_ToSqlInt64_Public_SqlInt64_0;

		// Token: 0x04000C63 RID: 3171
		private static readonly IntPtr NativeMethodInfoPtr_ToSqlMoney_Public_SqlMoney_0;

		// Token: 0x04000C64 RID: 3172
		private static readonly IntPtr NativeMethodInfoPtr_ChFromDigit_Private_Static_Char_UInt32_0;

		// Token: 0x04000C65 RID: 3173
		private static readonly IntPtr NativeMethodInfoPtr_StoreFromWorkingArray_Private_Void_Il2CppStructArray_1_UInt32_0;

		// Token: 0x04000C66 RID: 3174
		private static readonly IntPtr NativeMethodInfoPtr_SetToZero_Private_Void_0;

		// Token: 0x04000C67 RID: 3175
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000C68 RID: 3176
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Int32_SqlDecimal_0;

		// Token: 0x04000C69 RID: 3177
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000C6A RID: 3178
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000C6B RID: 3179
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_GetSchema_Private_Virtual_Final_New_XmlSchema_0;

		// Token: 0x04000C6C RID: 3180
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_ReadXml_Private_Virtual_Final_New_Void_XmlReader_0;

		// Token: 0x04000C6D RID: 3181
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_Serialization_IXmlSerializable_WriteXml_Private_Virtual_Final_New_Void_XmlWriter_0;

		// Token: 0x04000C6E RID: 3182
		private static readonly IntPtr NativeMethodInfoPtr_GetXsdType_Public_Static_XmlQualifiedName_XmlSchemaSet_0;

		// Token: 0x04000C6F RID: 3183
		[FieldOffset(0)]
		public byte _bStatus;

		// Token: 0x04000C70 RID: 3184
		[FieldOffset(1)]
		public byte _bLen;

		// Token: 0x04000C71 RID: 3185
		[FieldOffset(2)]
		public byte _bPrec;

		// Token: 0x04000C72 RID: 3186
		[FieldOffset(3)]
		public byte _bScale;

		// Token: 0x04000C73 RID: 3187
		[FieldOffset(4)]
		public uint _data1;

		// Token: 0x04000C74 RID: 3188
		[FieldOffset(8)]
		public uint _data2;

		// Token: 0x04000C75 RID: 3189
		[FieldOffset(12)]
		public uint _data3;

		// Token: 0x04000C76 RID: 3190
		[FieldOffset(16)]
		public uint _data4;
	}
}
