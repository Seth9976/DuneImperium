using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000083 RID: 131
	public static class Convert : Object
	{
		// Token: 0x0600079E RID: 1950 RVA: 0x00047F1C File Offset: 0x0004611C
		// Note: this type is marked as 'beforefieldinit'.
		static Convert()
		{
			Il2CppClassPointerStore<Convert>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Convert");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Convert>.NativeClassPtr);
			Convert.NativeFieldInfoPtr_s_decodingMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Convert>.NativeClassPtr, "s_decodingMap");
			Convert.NativeFieldInfoPtr_ConvertTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Convert>.NativeClassPtr, "ConvertTypes");
			Convert.NativeFieldInfoPtr_EnumType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Convert>.NativeClassPtr, "EnumType");
			Convert.NativeFieldInfoPtr_base64Table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Convert>.NativeClassPtr, "base64Table");
			Convert.NativeFieldInfoPtr_DBNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Convert>.NativeClassPtr, "DBNull");
			Convert.NativeMethodInfoPtr_TryDecodeFromUtf16_Private_Static_Boolean_ReadOnlySpan_1_Char_Span_1_Byte_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664580);
			Convert.NativeMethodInfoPtr_Decode_Private_Static_Int32_byref_Char_byref_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664581);
			Convert.NativeMethodInfoPtr_WriteThreeLowOrderBytes_Private_Static_Void_byref_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664582);
			Convert.NativeMethodInfoPtr_GetTypeCode_Public_Static_TypeCode_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664583);
			Convert.NativeMethodInfoPtr_ChangeType_Public_Static_Object_Object_TypeCode_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664584);
			Convert.NativeMethodInfoPtr_DefaultToType_Internal_Static_Object_IConvertible_Type_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664585);
			Convert.NativeMethodInfoPtr_ChangeType_Public_Static_Object_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664586);
			Convert.NativeMethodInfoPtr_ChangeType_Public_Static_Object_Object_Type_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664587);
			Convert.NativeMethodInfoPtr_ThrowCharOverflowException_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664588);
			Convert.NativeMethodInfoPtr_ThrowByteOverflowException_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664589);
			Convert.NativeMethodInfoPtr_ThrowSByteOverflowException_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664590);
			Convert.NativeMethodInfoPtr_ThrowInt16OverflowException_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664591);
			Convert.NativeMethodInfoPtr_ThrowUInt16OverflowException_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664592);
			Convert.NativeMethodInfoPtr_ThrowInt32OverflowException_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664593);
			Convert.NativeMethodInfoPtr_ThrowUInt32OverflowException_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664594);
			Convert.NativeMethodInfoPtr_ThrowInt64OverflowException_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664595);
			Convert.NativeMethodInfoPtr_ThrowUInt64OverflowException_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664596);
			Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664597);
			Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664598);
			Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664599);
			Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664600);
			Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664601);
			Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664602);
			Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664603);
			Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664604);
			Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664605);
			Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664606);
			Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664607);
			Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664608);
			Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664609);
			Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664610);
			Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664611);
			Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664612);
			Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664613);
			Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664614);
			Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664615);
			Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664616);
			Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664617);
			Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664618);
			Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664619);
			Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664620);
			Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664621);
			Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664622);
			Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664623);
			Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664624);
			Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664625);
			Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664626);
			Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664627);
			Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664628);
			Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664629);
			Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664630);
			Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664631);
			Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664632);
			Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664633);
			Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664634);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664635);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664636);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664637);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664638);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664639);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664640);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664641);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664642);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664643);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664644);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664645);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664646);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664647);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664648);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664649);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664650);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664651);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664652);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664653);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664654);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664655);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664656);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664657);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664658);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664659);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664660);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664661);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664662);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664663);
			Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664664);
			Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664665);
			Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664666);
			Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664667);
			Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664668);
			Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664669);
			Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664670);
			Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664671);
			Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664672);
			Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664673);
			Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664674);
			Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664675);
			Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664676);
			Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664677);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664678);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664679);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664680);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664681);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664682);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664683);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664684);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664685);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664686);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664687);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664688);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664689);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664690);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664691);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664692);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664693);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664694);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664695);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664696);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664697);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664698);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664699);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664700);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664701);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664702);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664703);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664704);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664705);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664706);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664707);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664708);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664709);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664710);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664711);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664712);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664713);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664714);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664715);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664716);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664717);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664718);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664719);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664720);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664721);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664722);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664723);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664724);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664725);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664726);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664727);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664728);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664729);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664730);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664731);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664732);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664733);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664734);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664735);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664736);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664737);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664738);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664739);
			Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664740);
			Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664741);
			Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664742);
			Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664743);
			Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664744);
			Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664745);
			Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664746);
			Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664747);
			Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664748);
			Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664749);
			Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664750);
			Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664751);
			Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664752);
			Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664753);
			Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664754);
			Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664755);
			Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664756);
			Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664757);
			Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664758);
			Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664759);
			Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664760);
			Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664761);
			Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664762);
			Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664763);
			Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664764);
			Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664765);
			Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664766);
			Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664767);
			Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664768);
			Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664769);
			Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664770);
			Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664771);
			Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664772);
			Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664773);
			Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664774);
			Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664775);
			Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664776);
			Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664777);
			Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664778);
			Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664779);
			Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664780);
			Convert.NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664781);
			Convert.NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664782);
			Convert.NativeMethodInfoPtr_ToString_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664783);
			Convert.NativeMethodInfoPtr_ToString_Public_Static_String_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664784);
			Convert.NativeMethodInfoPtr_ToString_Public_Static_String_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664785);
			Convert.NativeMethodInfoPtr_ToString_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664786);
			Convert.NativeMethodInfoPtr_ToString_Public_Static_String_Int32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664787);
			Convert.NativeMethodInfoPtr_ToString_Public_Static_String_Double_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664788);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664789);
			Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664790);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664791);
			Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664792);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664793);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664794);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664795);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664796);
			Convert.NativeMethodInfoPtr_ToString_Public_Static_String_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664797);
			Convert.NativeMethodInfoPtr_ToString_Public_Static_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664798);
			Convert.NativeMethodInfoPtr_ToString_Public_Static_String_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664799);
			Convert.NativeMethodInfoPtr_ToBase64String_Public_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664800);
			Convert.NativeMethodInfoPtr_ToBase64String_Public_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664801);
			Convert.NativeMethodInfoPtr_ToBase64String_Public_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_Base64FormattingOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664802);
			Convert.NativeMethodInfoPtr_ToBase64String_Public_Static_String_ReadOnlySpan_1_Byte_Base64FormattingOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664803);
			Convert.NativeMethodInfoPtr_ToBase64CharArray_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664804);
			Convert.NativeMethodInfoPtr_ToBase64CharArray_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_Base64FormattingOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664805);
			Convert.NativeMethodInfoPtr_ConvertToBase64Array_Private_Static_Int32_ptr_Char_ptr_Byte_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664806);
			Convert.NativeMethodInfoPtr_ToBase64_CalculateAndValidateOutputLength_Private_Static_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664807);
			Convert.NativeMethodInfoPtr_FromBase64String_Public_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664808);
			Convert.NativeMethodInfoPtr_TryFromBase64Chars_Public_Static_Boolean_ReadOnlySpan_1_Char_Span_1_Byte_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664809);
			Convert.NativeMethodInfoPtr_CopyToTempBufferWithoutWhiteSpace_Private_Static_Void_ReadOnlySpan_1_Char_Span_1_Char_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664810);
			Convert.NativeMethodInfoPtr_IsSpace_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664811);
			Convert.NativeMethodInfoPtr_FromBase64CharArray_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664812);
			Convert.NativeMethodInfoPtr_FromBase64CharPtr_Private_Static_Il2CppStructArray_1_Byte_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664813);
			Convert.NativeMethodInfoPtr_FromBase64_ComputeResultLength_Private_Static_Int32_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664814);
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x0004920C File Offset: 0x0004740C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1300251, RefRangeEnd = 1300253, XrefRangeStart = 1300230, XrefRangeEnd = 1300251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryDecodeFromUtf16(ReadOnlySpan<char> utf16, Span<byte> bytes, out int consumed, out int written)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(utf16));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(bytes));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &consumed;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &written;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_TryDecodeFromUtf16_Private_Static_Boolean_ReadOnlySpan_1_Char_Span_1_Byte_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00049288 File Offset: 0x00047488
		[CallerCount(0)]
		public unsafe static int Decode(ref char encodedChars, ref sbyte decodingMap)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &encodedChars;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &decodingMap;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_Decode_Private_Static_Int32_byref_Char_byref_SByte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x000492D4 File Offset: 0x000474D4
		[CallerCount(0)]
		public unsafe static void WriteThreeLowOrderBytes(ref byte destination, int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &destination;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_WriteThreeLowOrderBytes_Private_Static_Void_byref_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00049314 File Offset: 0x00047514
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1300256, RefRangeEnd = 1300259, XrefRangeStart = 1300253, XrefRangeEnd = 1300256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeCode GetTypeCode(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_GetTypeCode_Public_Static_TypeCode_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00049358 File Offset: 0x00047558
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300282, RefRangeEnd = 1300283, XrefRangeStart = 1300259, XrefRangeEnd = 1300282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ChangeType(Object value, TypeCode typeCode, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref typeCode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ChangeType_Public_Static_Object_Object_TypeCode_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x000493BC File Offset: 0x000475BC
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 1300356, RefRangeEnd = 1300373, XrefRangeStart = 1300283, XrefRangeEnd = 1300356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object DefaultToType(IConvertible value, Type targetType, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_DefaultToType_Internal_Static_Object_IConvertible_Type_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x00049424 File Offset: 0x00047624
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1300381, RefRangeEnd = 1300384, XrefRangeStart = 1300373, XrefRangeEnd = 1300381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ChangeType(Object value, Type conversionType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conversionType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ChangeType_Public_Static_Object_Object_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x0004947C File Offset: 0x0004767C
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 1300447, RefRangeEnd = 1300469, XrefRangeStart = 1300384, XrefRangeEnd = 1300447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ChangeType(Object value, Type conversionType, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conversionType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ChangeType_Public_Static_Object_Object_Type_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x000494E4 File Offset: 0x000476E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300469, XrefRangeEnd = 1300475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowCharOverflowException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ThrowCharOverflowException_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x0004950C File Offset: 0x0004770C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300475, XrefRangeEnd = 1300481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowByteOverflowException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ThrowByteOverflowException_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x00049534 File Offset: 0x00047734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300481, XrefRangeEnd = 1300487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowSByteOverflowException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ThrowSByteOverflowException_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x0004955C File Offset: 0x0004775C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300487, XrefRangeEnd = 1300493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowInt16OverflowException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ThrowInt16OverflowException_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00049584 File Offset: 0x00047784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300493, XrefRangeEnd = 1300499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowUInt16OverflowException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ThrowUInt16OverflowException_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x000495AC File Offset: 0x000477AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300499, XrefRangeEnd = 1300505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowInt32OverflowException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ThrowInt32OverflowException_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x000495D4 File Offset: 0x000477D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300505, XrefRangeEnd = 1300511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowUInt32OverflowException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ThrowUInt32OverflowException_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x000495FC File Offset: 0x000477FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300511, XrefRangeEnd = 1300517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowInt64OverflowException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ThrowInt64OverflowException_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x00049624 File Offset: 0x00047824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300517, XrefRangeEnd = 1300523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowUInt64OverflowException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ThrowUInt64OverflowException_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x0004964C File Offset: 0x0004784C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1300524, RefRangeEnd = 1300537, XrefRangeStart = 1300523, XrefRangeEnd = 1300524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ToBoolean(Object value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Object_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x000496A0 File Offset: 0x000478A0
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1300537, RefRangeEnd = 1300552, XrefRangeStart = 1300537, XrefRangeEnd = 1300537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ToBoolean(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x000496E0 File Offset: 0x000478E0
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1300537, RefRangeEnd = 1300552, XrefRangeStart = 1300537, XrefRangeEnd = 1300552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ToBoolean(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00049720 File Offset: 0x00047920
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1300552, RefRangeEnd = 1300554, XrefRangeStart = 1300552, XrefRangeEnd = 1300552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ToBoolean(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00049760 File Offset: 0x00047960
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1300552, RefRangeEnd = 1300554, XrefRangeStart = 1300552, XrefRangeEnd = 1300554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ToBoolean(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x000497A0 File Offset: 0x000479A0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1300554, RefRangeEnd = 1300560, XrefRangeStart = 1300554, XrefRangeEnd = 1300554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ToBoolean(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x000497E0 File Offset: 0x000479E0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1300554, RefRangeEnd = 1300560, XrefRangeStart = 1300554, XrefRangeEnd = 1300560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ToBoolean(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x00049820 File Offset: 0x00047A20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 493514, RefRangeEnd = 493516, XrefRangeStart = 493514, XrefRangeEnd = 493516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ToBoolean(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00049860 File Offset: 0x00047A60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 493514, RefRangeEnd = 493516, XrefRangeStart = 493514, XrefRangeEnd = 493516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ToBoolean(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x000498A0 File Offset: 0x00047AA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300572, RefRangeEnd = 1300573, XrefRangeStart = 1300560, XrefRangeEnd = 1300572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ToBoolean(string value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x000498F4 File Offset: 0x00047AF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300573, RefRangeEnd = 1300574, XrefRangeStart = 1300573, XrefRangeEnd = 1300573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ToBoolean(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x00049934 File Offset: 0x00047B34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300574, RefRangeEnd = 1300575, XrefRangeStart = 1300574, XrefRangeEnd = 1300574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ToBoolean(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x00049974 File Offset: 0x00047B74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300580, RefRangeEnd = 1300581, XrefRangeStart = 1300575, XrefRangeEnd = 1300580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ToBoolean(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x000499B4 File Offset: 0x00047BB4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1300582, RefRangeEnd = 1300588, XrefRangeStart = 1300581, XrefRangeEnd = 1300582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToChar(Object value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_Object_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00049A08 File Offset: 0x00047C08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300589, RefRangeEnd = 1300590, XrefRangeStart = 1300588, XrefRangeEnd = 1300589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToChar(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x00049A48 File Offset: 0x00047C48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1064852, RefRangeEnd = 1064854, XrefRangeStart = 1064852, XrefRangeEnd = 1064854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToChar(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x00049A88 File Offset: 0x00047C88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300591, RefRangeEnd = 1300592, XrefRangeStart = 1300590, XrefRangeEnd = 1300591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToChar(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x00049AC8 File Offset: 0x00047CC8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 630996, RefRangeEnd = 631003, XrefRangeStart = 630996, XrefRangeEnd = 631003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToChar(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x00049B08 File Offset: 0x00047D08
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1300593, RefRangeEnd = 1300604, XrefRangeStart = 1300592, XrefRangeEnd = 1300593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToChar(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x00049B48 File Offset: 0x00047D48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300605, RefRangeEnd = 1300606, XrefRangeStart = 1300604, XrefRangeEnd = 1300605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToChar(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x00049B88 File Offset: 0x00047D88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300607, RefRangeEnd = 1300608, XrefRangeStart = 1300606, XrefRangeEnd = 1300607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToChar(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x00049BC8 File Offset: 0x00047DC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300609, RefRangeEnd = 1300610, XrefRangeStart = 1300608, XrefRangeEnd = 1300609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToChar(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x00049C08 File Offset: 0x00047E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300610, XrefRangeEnd = 1300626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToChar(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00049C4C File Offset: 0x00047E4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300639, RefRangeEnd = 1300640, XrefRangeStart = 1300626, XrefRangeEnd = 1300639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToChar(string value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x00049CA0 File Offset: 0x00047EA0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1300641, RefRangeEnd = 1300646, XrefRangeStart = 1300640, XrefRangeEnd = 1300641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte ToSByte(Object value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Object_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x00049CF4 File Offset: 0x00047EF4
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1300537, RefRangeEnd = 1300552, XrefRangeStart = 1300537, XrefRangeEnd = 1300552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte ToSByte(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00049D34 File Offset: 0x00047F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300646, XrefRangeEnd = 1300647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte ToSByte(char value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x00049D74 File Offset: 0x00047F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300647, XrefRangeEnd = 1300648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte ToSByte(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x00049DB4 File Offset: 0x00047FB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300649, RefRangeEnd = 1300650, XrefRangeStart = 1300648, XrefRangeEnd = 1300649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte ToSByte(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x00049DF4 File Offset: 0x00047FF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300651, RefRangeEnd = 1300652, XrefRangeStart = 1300650, XrefRangeEnd = 1300651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte ToSByte(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x00049E34 File Offset: 0x00048034
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300653, RefRangeEnd = 1300654, XrefRangeStart = 1300652, XrefRangeEnd = 1300653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte ToSByte(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x00049E74 File Offset: 0x00048074
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300655, RefRangeEnd = 1300656, XrefRangeStart = 1300654, XrefRangeEnd = 1300655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte ToSByte(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x00049EB4 File Offset: 0x000480B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300657, RefRangeEnd = 1300658, XrefRangeStart = 1300656, XrefRangeEnd = 1300657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte ToSByte(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x00049EF4 File Offset: 0x000480F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300659, RefRangeEnd = 1300660, XrefRangeStart = 1300658, XrefRangeEnd = 1300659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte ToSByte(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00049F34 File Offset: 0x00048134
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300668, RefRangeEnd = 1300669, XrefRangeStart = 1300660, XrefRangeEnd = 1300668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte ToSByte(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x00049F74 File Offset: 0x00048174
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300674, RefRangeEnd = 1300675, XrefRangeStart = 1300669, XrefRangeEnd = 1300674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte ToSByte(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x00049FB4 File Offset: 0x000481B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300680, RefRangeEnd = 1300681, XrefRangeStart = 1300675, XrefRangeEnd = 1300680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte ToSByte(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00049FF4 File Offset: 0x000481F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300682, RefRangeEnd = 1300683, XrefRangeStart = 1300681, XrefRangeEnd = 1300682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte ToSByte(string value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x0004A048 File Offset: 0x00048248
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1300684, RefRangeEnd = 1300692, XrefRangeStart = 1300683, XrefRangeEnd = 1300684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ToByte(Object value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Object_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x0004A09C File Offset: 0x0004829C
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1300537, RefRangeEnd = 1300552, XrefRangeStart = 1300537, XrefRangeEnd = 1300552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ToByte(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x0004A0DC File Offset: 0x000482DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1300693, RefRangeEnd = 1300696, XrefRangeStart = 1300692, XrefRangeEnd = 1300693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ToByte(char value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x0004A11C File Offset: 0x0004831C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300697, RefRangeEnd = 1300698, XrefRangeStart = 1300696, XrefRangeEnd = 1300697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ToByte(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x0004A15C File Offset: 0x0004835C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300699, RefRangeEnd = 1300700, XrefRangeStart = 1300698, XrefRangeEnd = 1300699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ToByte(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x0004A19C File Offset: 0x0004839C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300701, RefRangeEnd = 1300702, XrefRangeStart = 1300700, XrefRangeEnd = 1300701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ToByte(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x0004A1DC File Offset: 0x000483DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1300703, RefRangeEnd = 1300706, XrefRangeStart = 1300702, XrefRangeEnd = 1300703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ToByte(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x0004A21C File Offset: 0x0004841C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300707, RefRangeEnd = 1300708, XrefRangeStart = 1300706, XrefRangeEnd = 1300707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ToByte(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x0004A25C File Offset: 0x0004845C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1300709, RefRangeEnd = 1300712, XrefRangeStart = 1300708, XrefRangeEnd = 1300709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ToByte(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x0004A29C File Offset: 0x0004849C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300713, RefRangeEnd = 1300714, XrefRangeStart = 1300712, XrefRangeEnd = 1300713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ToByte(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x0004A2DC File Offset: 0x000484DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300722, RefRangeEnd = 1300723, XrefRangeStart = 1300714, XrefRangeEnd = 1300722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ToByte(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x0004A31C File Offset: 0x0004851C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300728, RefRangeEnd = 1300729, XrefRangeStart = 1300723, XrefRangeEnd = 1300728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ToByte(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x0004A35C File Offset: 0x0004855C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300734, RefRangeEnd = 1300735, XrefRangeStart = 1300729, XrefRangeEnd = 1300734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ToByte(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x0004A39C File Offset: 0x0004859C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1300743, RefRangeEnd = 1300745, XrefRangeStart = 1300735, XrefRangeEnd = 1300743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ToByte(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x0004A3E0 File Offset: 0x000485E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1300750, RefRangeEnd = 1300753, XrefRangeStart = 1300745, XrefRangeEnd = 1300750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ToByte(string value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x0004A434 File Offset: 0x00048634
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1300754, RefRangeEnd = 1300759, XrefRangeStart = 1300753, XrefRangeEnd = 1300754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ToInt16(Object value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Object_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x0004A488 File Offset: 0x00048688
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1300759, RefRangeEnd = 1300773, XrefRangeStart = 1300759, XrefRangeEnd = 1300759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ToInt16(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x0004A4C8 File Offset: 0x000486C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1300773, XrefRangeEnd = 1300774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ToInt16(char value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x0004A508 File Offset: 0x00048708
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300774, RefRangeEnd = 1300775, XrefRangeStart = 1300774, XrefRangeEnd = 1300774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ToInt16(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x0004A548 File Offset: 0x00048748
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1064852, RefRangeEnd = 1064854, XrefRangeStart = 1064852, XrefRangeEnd = 1064854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ToInt16(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x0004A588 File Offset: 0x00048788
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300776, RefRangeEnd = 1300777, XrefRangeStart = 1300775, XrefRangeEnd = 1300776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ToInt16(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x0004A5C8 File Offset: 0x000487C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300778, RefRangeEnd = 1300779, XrefRangeStart = 1300777, XrefRangeEnd = 1300778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ToInt16(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x0004A608 File Offset: 0x00048808
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300780, RefRangeEnd = 1300781, XrefRangeStart = 1300779, XrefRangeEnd = 1300780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ToInt16(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x0004A648 File Offset: 0x00048848
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300782, RefRangeEnd = 1300783, XrefRangeStart = 1300781, XrefRangeEnd = 1300782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ToInt16(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x0004A688 File Offset: 0x00048888
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300784, RefRangeEnd = 1300785, XrefRangeStart = 1300783, XrefRangeEnd = 1300784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ToInt16(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x0004A6C8 File Offset: 0x000488C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300793, RefRangeEnd = 1300794, XrefRangeStart = 1300785, XrefRangeEnd = 1300793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ToInt16(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x0004A708 File Offset: 0x00048908
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300799, RefRangeEnd = 1300800, XrefRangeStart = 1300794, XrefRangeEnd = 1300799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ToInt16(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x0004A748 File Offset: 0x00048948
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300805, RefRangeEnd = 1300806, XrefRangeStart = 1300800, XrefRangeEnd = 1300805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ToInt16(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x0004A788 File Offset: 0x00048988
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1300807, RefRangeEnd = 1300815, XrefRangeStart = 1300806, XrefRangeEnd = 1300807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ToInt16(string value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x0004A7DC File Offset: 0x000489DC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1300816, RefRangeEnd = 1300821, XrefRangeStart = 1300815, XrefRangeEnd = 1300816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ToUInt16(Object value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Object_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x0004A830 File Offset: 0x00048A30
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1300759, RefRangeEnd = 1300773, XrefRangeStart = 1300759, XrefRangeEnd = 1300773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ToUInt16(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x0004A870 File Offset: 0x00048A70
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 630996, RefRangeEnd = 631003, XrefRangeStart = 630996, XrefRangeEnd = 631003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ToUInt16(char value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x0004A8B0 File Offset: 0x00048AB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300822, RefRangeEnd = 1300823, XrefRangeStart = 1300821, XrefRangeEnd = 1300822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ToUInt16(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x0004A8F0 File Offset: 0x00048AF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1064852, RefRangeEnd = 1064854, XrefRangeStart = 1064852, XrefRangeEnd = 1064854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ToUInt16(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x0004A930 File Offset: 0x00048B30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300824, RefRangeEnd = 1300825, XrefRangeStart = 1300823, XrefRangeEnd = 1300824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ToUInt16(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x0004A970 File Offset: 0x00048B70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300826, RefRangeEnd = 1300827, XrefRangeStart = 1300825, XrefRangeEnd = 1300826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ToUInt16(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x0004A9B0 File Offset: 0x00048BB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300828, RefRangeEnd = 1300829, XrefRangeStart = 1300827, XrefRangeEnd = 1300828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ToUInt16(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x0004A9F0 File Offset: 0x00048BF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300830, RefRangeEnd = 1300831, XrefRangeStart = 1300829, XrefRangeEnd = 1300830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ToUInt16(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x0004AA30 File Offset: 0x00048C30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300832, RefRangeEnd = 1300833, XrefRangeStart = 1300831, XrefRangeEnd = 1300832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ToUInt16(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x0004AA70 File Offset: 0x00048C70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300841, RefRangeEnd = 1300842, XrefRangeStart = 1300833, XrefRangeEnd = 1300841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ToUInt16(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x0004AAB0 File Offset: 0x00048CB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300847, RefRangeEnd = 1300848, XrefRangeStart = 1300842, XrefRangeEnd = 1300847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ToUInt16(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x0004AAF0 File Offset: 0x00048CF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300853, RefRangeEnd = 1300854, XrefRangeStart = 1300848, XrefRangeEnd = 1300853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ToUInt16(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x0004AB30 File Offset: 0x00048D30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300855, RefRangeEnd = 1300856, XrefRangeStart = 1300854, XrefRangeEnd = 1300855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ToUInt16(string value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x0004AB84 File Offset: 0x00048D84
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1300857, RefRangeEnd = 1300865, XrefRangeStart = 1300856, XrefRangeEnd = 1300857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x0004ABC8 File Offset: 0x00048DC8
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1300866, RefRangeEnd = 1300882, XrefRangeStart = 1300865, XrefRangeEnd = 1300866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(Object value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Object_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x0004AC1C File Offset: 0x00048E1C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1300759, RefRangeEnd = 1300773, XrefRangeStart = 1300759, XrefRangeEnd = 1300773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x0004AC5C File Offset: 0x00048E5C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 630996, RefRangeEnd = 631003, XrefRangeStart = 630996, XrefRangeEnd = 631003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(char value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x0004AC9C File Offset: 0x00048E9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1064852, RefRangeEnd = 1064854, XrefRangeStart = 1064852, XrefRangeEnd = 1064854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x0004ACDC File Offset: 0x00048EDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300882, RefRangeEnd = 1300883, XrefRangeStart = 1300882, XrefRangeEnd = 1300882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x0004AD1C File Offset: 0x00048F1C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 630996, RefRangeEnd = 631003, XrefRangeStart = 630996, XrefRangeEnd = 631003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x0004AD5C File Offset: 0x00048F5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1300884, RefRangeEnd = 1300886, XrefRangeStart = 1300883, XrefRangeEnd = 1300884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x0004AD9C File Offset: 0x00048F9C
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x0004ADDC File Offset: 0x00048FDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300887, RefRangeEnd = 1300888, XrefRangeStart = 1300886, XrefRangeEnd = 1300887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x0004AE1C File Offset: 0x0004901C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300889, RefRangeEnd = 1300890, XrefRangeStart = 1300888, XrefRangeEnd = 1300889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x0004AE5C File Offset: 0x0004905C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1300894, RefRangeEnd = 1300896, XrefRangeStart = 1300890, XrefRangeEnd = 1300894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x0004AE9C File Offset: 0x0004909C
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 1300896, RefRangeEnd = 1300919, XrefRangeStart = 1300896, XrefRangeEnd = 1300896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x0004AEDC File Offset: 0x000490DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300924, RefRangeEnd = 1300925, XrefRangeStart = 1300919, XrefRangeEnd = 1300924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x0004AF1C File Offset: 0x0004911C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1300930, RefRangeEnd = 1300935, XrefRangeStart = 1300925, XrefRangeEnd = 1300930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x0004AF60 File Offset: 0x00049160
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1300936, RefRangeEnd = 1300945, XrefRangeStart = 1300935, XrefRangeEnd = 1300936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(string value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x0004AFB4 File Offset: 0x000491B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1300946, RefRangeEnd = 1300949, XrefRangeStart = 1300945, XrefRangeEnd = 1300946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x0004AFF8 File Offset: 0x000491F8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1300950, RefRangeEnd = 1300955, XrefRangeStart = 1300949, XrefRangeEnd = 1300950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(Object value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Object_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x0004B04C File Offset: 0x0004924C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1300759, RefRangeEnd = 1300773, XrefRangeStart = 1300759, XrefRangeEnd = 1300773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x0004B08C File Offset: 0x0004928C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 630996, RefRangeEnd = 631003, XrefRangeStart = 630996, XrefRangeEnd = 631003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(char value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x0004B0CC File Offset: 0x000492CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300956, RefRangeEnd = 1300957, XrefRangeStart = 1300955, XrefRangeEnd = 1300956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x0004B10C File Offset: 0x0004930C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1064852, RefRangeEnd = 1064854, XrefRangeStart = 1064852, XrefRangeEnd = 1064854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x0004B14C File Offset: 0x0004934C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300958, RefRangeEnd = 1300959, XrefRangeStart = 1300957, XrefRangeEnd = 1300958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x0004B18C File Offset: 0x0004938C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 630996, RefRangeEnd = 631003, XrefRangeStart = 630996, XrefRangeEnd = 631003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x0004B1CC File Offset: 0x000493CC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1300960, RefRangeEnd = 1300965, XrefRangeStart = 1300959, XrefRangeEnd = 1300960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x0004B20C File Offset: 0x0004940C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300966, RefRangeEnd = 1300967, XrefRangeStart = 1300965, XrefRangeEnd = 1300966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x0004B24C File Offset: 0x0004944C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300968, RefRangeEnd = 1300969, XrefRangeStart = 1300967, XrefRangeEnd = 1300968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x0004B28C File Offset: 0x0004948C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300973, RefRangeEnd = 1300974, XrefRangeStart = 1300969, XrefRangeEnd = 1300973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x0004B2CC File Offset: 0x000494CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300975, RefRangeEnd = 1300976, XrefRangeStart = 1300974, XrefRangeEnd = 1300975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x0004B30C File Offset: 0x0004950C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300981, RefRangeEnd = 1300982, XrefRangeStart = 1300976, XrefRangeEnd = 1300981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x0004B34C File Offset: 0x0004954C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300983, RefRangeEnd = 1300984, XrefRangeStart = 1300982, XrefRangeEnd = 1300983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(string value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x0004B3A0 File Offset: 0x000495A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1300985, RefRangeEnd = 1300986, XrefRangeStart = 1300984, XrefRangeEnd = 1300985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToInt64(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x0004B3E4 File Offset: 0x000495E4
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1300987, RefRangeEnd = 1301001, XrefRangeStart = 1300986, XrefRangeEnd = 1300987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToInt64(Object value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Object_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x0004B438 File Offset: 0x00049638
		[CallerCount(0)]
		public unsafe static long ToInt64(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x0004B478 File Offset: 0x00049678
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 630996, RefRangeEnd = 631003, XrefRangeStart = 630996, XrefRangeEnd = 631003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToInt64(char value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x0004B4B8 File Offset: 0x000496B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301001, RefRangeEnd = 1301002, XrefRangeStart = 1301001, XrefRangeEnd = 1301001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToInt64(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x0004B4F8 File Offset: 0x000496F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1064852, RefRangeEnd = 1064854, XrefRangeStart = 1064852, XrefRangeEnd = 1064854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToInt64(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x0004B538 File Offset: 0x00049738
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301002, RefRangeEnd = 1301003, XrefRangeStart = 1301002, XrefRangeEnd = 1301002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToInt64(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x0004B578 File Offset: 0x00049778
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 630996, RefRangeEnd = 631003, XrefRangeStart = 630996, XrefRangeEnd = 631003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToInt64(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x0004B5B8 File Offset: 0x000497B8
		[CallerCount(38)]
		[CachedScanResults(RefRangeStart = 1301003, RefRangeEnd = 1301041, XrefRangeStart = 1301003, XrefRangeEnd = 1301003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToInt64(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x0004B5F8 File Offset: 0x000497F8
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToInt64(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x0004B638 File Offset: 0x00049838
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301042, RefRangeEnd = 1301043, XrefRangeStart = 1301041, XrefRangeEnd = 1301042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToInt64(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x0004B678 File Offset: 0x00049878
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301051, RefRangeEnd = 1301052, XrefRangeStart = 1301043, XrefRangeEnd = 1301051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToInt64(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x0004B6B8 File Offset: 0x000498B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301057, RefRangeEnd = 1301058, XrefRangeStart = 1301052, XrefRangeEnd = 1301057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToInt64(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x0004B6F8 File Offset: 0x000498F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301063, RefRangeEnd = 1301064, XrefRangeStart = 1301058, XrefRangeEnd = 1301063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToInt64(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x0004B738 File Offset: 0x00049938
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301069, RefRangeEnd = 1301070, XrefRangeStart = 1301064, XrefRangeEnd = 1301069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToInt64(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x0004B77C File Offset: 0x0004997C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1301071, RefRangeEnd = 1301074, XrefRangeStart = 1301070, XrefRangeEnd = 1301071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToInt64(string value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x0004B7D0 File Offset: 0x000499D0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1301075, RefRangeEnd = 1301079, XrefRangeStart = 1301074, XrefRangeEnd = 1301075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ToUInt64(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x0004B814 File Offset: 0x00049A14
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1301080, RefRangeEnd = 1301087, XrefRangeStart = 1301079, XrefRangeEnd = 1301080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ToUInt64(Object value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Object_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x0004B868 File Offset: 0x00049A68
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1300759, RefRangeEnd = 1300773, XrefRangeStart = 1300759, XrefRangeEnd = 1300773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ToUInt64(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x0004B8A8 File Offset: 0x00049AA8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 630996, RefRangeEnd = 631003, XrefRangeStart = 630996, XrefRangeEnd = 631003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ToUInt64(char value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x0004B8E8 File Offset: 0x00049AE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301088, RefRangeEnd = 1301089, XrefRangeStart = 1301087, XrefRangeEnd = 1301088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ToUInt64(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x0004B928 File Offset: 0x00049B28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1064852, RefRangeEnd = 1064854, XrefRangeStart = 1064852, XrefRangeEnd = 1064854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ToUInt64(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x0004B968 File Offset: 0x00049B68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301090, RefRangeEnd = 1301091, XrefRangeStart = 1301089, XrefRangeEnd = 1301090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ToUInt64(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x0004B9A8 File Offset: 0x00049BA8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 630996, RefRangeEnd = 631003, XrefRangeStart = 630996, XrefRangeEnd = 631003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ToUInt64(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x0004B9E8 File Offset: 0x00049BE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301092, RefRangeEnd = 1301093, XrefRangeStart = 1301091, XrefRangeEnd = 1301092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ToUInt64(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x0004BA28 File Offset: 0x00049C28
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ToUInt64(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x0004BA68 File Offset: 0x00049C68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301094, RefRangeEnd = 1301095, XrefRangeStart = 1301093, XrefRangeEnd = 1301094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ToUInt64(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x0004BAA8 File Offset: 0x00049CA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301103, RefRangeEnd = 1301104, XrefRangeStart = 1301095, XrefRangeEnd = 1301103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ToUInt64(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x0004BAE8 File Offset: 0x00049CE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301109, RefRangeEnd = 1301110, XrefRangeStart = 1301104, XrefRangeEnd = 1301109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ToUInt64(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x0004BB28 File Offset: 0x00049D28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301115, RefRangeEnd = 1301116, XrefRangeStart = 1301110, XrefRangeEnd = 1301115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ToUInt64(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x0004BB68 File Offset: 0x00049D68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301117, RefRangeEnd = 1301118, XrefRangeStart = 1301116, XrefRangeEnd = 1301117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ToUInt64(string value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x0004BBBC File Offset: 0x00049DBC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1301119, RefRangeEnd = 1301127, XrefRangeStart = 1301118, XrefRangeEnd = 1301119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToSingle(Object value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Object_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x0004BC10 File Offset: 0x00049E10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301127, RefRangeEnd = 1301128, XrefRangeStart = 1301127, XrefRangeEnd = 1301127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToSingle(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x0004BC50 File Offset: 0x00049E50
		[CallerCount(0)]
		public unsafe static float ToSingle(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x0004BC90 File Offset: 0x00049E90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301128, RefRangeEnd = 1301129, XrefRangeStart = 1301128, XrefRangeEnd = 1301128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToSingle(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x0004BCD0 File Offset: 0x00049ED0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301129, RefRangeEnd = 1301130, XrefRangeStart = 1301129, XrefRangeEnd = 1301129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToSingle(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x0004BD10 File Offset: 0x00049F10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301130, RefRangeEnd = 1301131, XrefRangeStart = 1301130, XrefRangeEnd = 1301130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToSingle(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x0004BD50 File Offset: 0x00049F50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301131, RefRangeEnd = 1301132, XrefRangeStart = 1301131, XrefRangeEnd = 1301131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToSingle(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x0004BD90 File Offset: 0x00049F90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301132, RefRangeEnd = 1301133, XrefRangeStart = 1301132, XrefRangeEnd = 1301132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToSingle(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x0004BDD0 File Offset: 0x00049FD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301133, RefRangeEnd = 1301134, XrefRangeStart = 1301133, XrefRangeEnd = 1301133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToSingle(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x0004BE10 File Offset: 0x0004A010
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301134, RefRangeEnd = 1301135, XrefRangeStart = 1301134, XrefRangeEnd = 1301134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToSingle(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x0004BE50 File Offset: 0x0004A050
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301139, RefRangeEnd = 1301140, XrefRangeStart = 1301135, XrefRangeEnd = 1301139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToSingle(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x0004BE90 File Offset: 0x0004A090
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1301141, RefRangeEnd = 1301143, XrefRangeStart = 1301140, XrefRangeEnd = 1301141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToSingle(string value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x0004BEE4 File Offset: 0x0004A0E4
		[CallerCount(0)]
		public unsafe static float ToSingle(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x0004BF24 File Offset: 0x0004A124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1301143, XrefRangeEnd = 1301144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ToDouble(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x0004BF68 File Offset: 0x0004A168
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1301145, RefRangeEnd = 1301160, XrefRangeStart = 1301144, XrefRangeEnd = 1301145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ToDouble(Object value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Object_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x0004BFBC File Offset: 0x0004A1BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301160, RefRangeEnd = 1301161, XrefRangeStart = 1301160, XrefRangeEnd = 1301160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ToDouble(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x0004BFFC File Offset: 0x0004A1FC
		[CallerCount(0)]
		public unsafe static double ToDouble(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x0004C03C File Offset: 0x0004A23C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301161, RefRangeEnd = 1301162, XrefRangeStart = 1301161, XrefRangeEnd = 1301161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ToDouble(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x0004C07C File Offset: 0x0004A27C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301162, RefRangeEnd = 1301163, XrefRangeStart = 1301162, XrefRangeEnd = 1301162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ToDouble(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x0004C0BC File Offset: 0x0004A2BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301163, RefRangeEnd = 1301164, XrefRangeStart = 1301163, XrefRangeEnd = 1301163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ToDouble(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x0004C0FC File Offset: 0x0004A2FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301164, RefRangeEnd = 1301165, XrefRangeStart = 1301164, XrefRangeEnd = 1301164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ToDouble(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x0004C13C File Offset: 0x0004A33C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1301165, RefRangeEnd = 1301167, XrefRangeStart = 1301165, XrefRangeEnd = 1301165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ToDouble(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x0004C17C File Offset: 0x0004A37C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301167, RefRangeEnd = 1301168, XrefRangeStart = 1301167, XrefRangeEnd = 1301167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ToDouble(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x0004C1BC File Offset: 0x0004A3BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301168, RefRangeEnd = 1301169, XrefRangeStart = 1301168, XrefRangeEnd = 1301168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ToDouble(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x0004C1FC File Offset: 0x0004A3FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301173, RefRangeEnd = 1301174, XrefRangeStart = 1301169, XrefRangeEnd = 1301173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ToDouble(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x0004C23C File Offset: 0x0004A43C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1301175, RefRangeEnd = 1301177, XrefRangeStart = 1301174, XrefRangeEnd = 1301175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ToDouble(string value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x0004C290 File Offset: 0x0004A490
		[CallerCount(0)]
		public unsafe static double ToDouble(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x0004C2D0 File Offset: 0x0004A4D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1301182, RefRangeEnd = 1301184, XrefRangeStart = 1301177, XrefRangeEnd = 1301182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x0004C314 File Offset: 0x0004A514
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1301189, RefRangeEnd = 1301199, XrefRangeStart = 1301184, XrefRangeEnd = 1301189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(Object value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Object_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x0004C368 File Offset: 0x0004A568
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301203, RefRangeEnd = 1301204, XrefRangeStart = 1301199, XrefRangeEnd = 1301203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x0004C3A8 File Offset: 0x0004A5A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1301204, XrefRangeEnd = 1301208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x0004C3E8 File Offset: 0x0004A5E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301212, RefRangeEnd = 1301213, XrefRangeStart = 1301208, XrefRangeEnd = 1301212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x0004C428 File Offset: 0x0004A628
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301217, RefRangeEnd = 1301218, XrefRangeStart = 1301213, XrefRangeEnd = 1301217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x0004C468 File Offset: 0x0004A668
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301222, RefRangeEnd = 1301223, XrefRangeStart = 1301218, XrefRangeEnd = 1301222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x0004C4A8 File Offset: 0x0004A6A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301227, RefRangeEnd = 1301228, XrefRangeStart = 1301223, XrefRangeEnd = 1301227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x0004C4E8 File Offset: 0x0004A6E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1301232, RefRangeEnd = 1301234, XrefRangeStart = 1301228, XrefRangeEnd = 1301232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x0004C528 File Offset: 0x0004A728
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301238, RefRangeEnd = 1301239, XrefRangeStart = 1301234, XrefRangeEnd = 1301238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x0004C568 File Offset: 0x0004A768
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301243, RefRangeEnd = 1301244, XrefRangeStart = 1301239, XrefRangeEnd = 1301243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x0004C5A8 File Offset: 0x0004A7A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301248, RefRangeEnd = 1301249, XrefRangeStart = 1301244, XrefRangeEnd = 1301248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x0004C5E8 File Offset: 0x0004A7E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1301257, RefRangeEnd = 1301259, XrefRangeStart = 1301249, XrefRangeEnd = 1301257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(string value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x0004C63C File Offset: 0x0004A83C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1301259, XrefRangeEnd = 1301263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x0004C67C File Offset: 0x0004A87C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1301268, RefRangeEnd = 1301275, XrefRangeStart = 1301263, XrefRangeEnd = 1301268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ToDateTime(Object value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_Object_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x0004C6D0 File Offset: 0x0004A8D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301280, RefRangeEnd = 1301281, XrefRangeStart = 1301275, XrefRangeEnd = 1301280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ToDateTime(string value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x0004C724 File Offset: 0x0004A924
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1301292, RefRangeEnd = 1301294, XrefRangeStart = 1301281, XrefRangeEnd = 1301292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToString_Public_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x0004C760 File Offset: 0x0004A960
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1301302, RefRangeEnd = 1301318, XrefRangeStart = 1301294, XrefRangeEnd = 1301302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(Object value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToString_Public_Static_String_Object_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x0004C7B0 File Offset: 0x0004A9B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301325, RefRangeEnd = 1301326, XrefRangeStart = 1301318, XrefRangeEnd = 1301325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(char value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToString_Public_Static_String_Char_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x0004C7FC File Offset: 0x0004A9FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1301331, RefRangeEnd = 1301333, XrefRangeStart = 1301326, XrefRangeEnd = 1301331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToString_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x0004C834 File Offset: 0x0004AA34
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1301334, RefRangeEnd = 1301337, XrefRangeStart = 1301333, XrefRangeEnd = 1301334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(int value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToString_Public_Static_String_Int32_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x0004C880 File Offset: 0x0004AA80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301338, RefRangeEnd = 1301339, XrefRangeStart = 1301337, XrefRangeEnd = 1301338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(double value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToString_Public_Static_String_Double_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x0004C8CC File Offset: 0x0004AACC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301344, RefRangeEnd = 1301345, XrefRangeStart = 1301339, XrefRangeEnd = 1301344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ToByte(string value, int fromBase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromBase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x0004C91C File Offset: 0x0004AB1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301349, RefRangeEnd = 1301350, XrefRangeStart = 1301345, XrefRangeEnd = 1301349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte ToSByte(string value, int fromBase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromBase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x0004C96C File Offset: 0x0004AB6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301355, RefRangeEnd = 1301356, XrefRangeStart = 1301350, XrefRangeEnd = 1301355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ToInt16(string value, int fromBase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromBase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x0004C9BC File Offset: 0x0004ABBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301361, RefRangeEnd = 1301362, XrefRangeStart = 1301356, XrefRangeEnd = 1301361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ToUInt16(string value, int fromBase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromBase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x0004CA0C File Offset: 0x0004AC0C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1301365, RefRangeEnd = 1301369, XrefRangeStart = 1301362, XrefRangeEnd = 1301365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(string value, int fromBase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromBase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x0004CA5C File Offset: 0x0004AC5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301372, RefRangeEnd = 1301373, XrefRangeStart = 1301369, XrefRangeEnd = 1301372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(string value, int fromBase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromBase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x0004CAAC File Offset: 0x0004ACAC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1301376, RefRangeEnd = 1301385, XrefRangeStart = 1301373, XrefRangeEnd = 1301376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToInt64(string value, int fromBase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromBase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x0004CAFC File Offset: 0x0004ACFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301388, RefRangeEnd = 1301389, XrefRangeStart = 1301385, XrefRangeEnd = 1301388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ToUInt64(string value, int fromBase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromBase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x0004CB4C File Offset: 0x0004AD4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301390, RefRangeEnd = 1301391, XrefRangeStart = 1301389, XrefRangeEnd = 1301390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(byte value, int toBase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toBase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToString_Public_Static_String_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x0004CB94 File Offset: 0x0004AD94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301392, RefRangeEnd = 1301393, XrefRangeStart = 1301391, XrefRangeEnd = 1301392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(int value, int toBase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toBase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToString_Public_Static_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x0004CBDC File Offset: 0x0004ADDC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1301394, RefRangeEnd = 1301404, XrefRangeStart = 1301393, XrefRangeEnd = 1301394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(long value, int toBase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toBase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToString_Public_Static_String_Int64_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x0004CC24 File Offset: 0x0004AE24
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 1301409, RefRangeEnd = 1301457, XrefRangeStart = 1301404, XrefRangeEnd = 1301409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToBase64String(Il2CppStructArray<byte> inArray)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inArray);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBase64String_Public_Static_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x0004CC60 File Offset: 0x0004AE60
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1301461, RefRangeEnd = 1301469, XrefRangeStart = 1301457, XrefRangeEnd = 1301461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToBase64String(Il2CppStructArray<byte> inArray, int offset, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inArray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBase64String_Public_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x0004CCB8 File Offset: 0x0004AEB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301475, RefRangeEnd = 1301476, XrefRangeStart = 1301469, XrefRangeEnd = 1301475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToBase64String(Il2CppStructArray<byte> inArray, int offset, int length, Base64FormattingOptions options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inArray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBase64String_Public_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_Base64FormattingOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x0004CD20 File Offset: 0x0004AF20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1301490, RefRangeEnd = 1301492, XrefRangeStart = 1301476, XrefRangeEnd = 1301490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToBase64String(ReadOnlySpan<byte> bytes, Base64FormattingOptions options = Base64FormattingOptions.None)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(bytes));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBase64String_Public_Static_String_ReadOnlySpan_1_Byte_Base64FormattingOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x0004CD70 File Offset: 0x0004AF70
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1301496, RefRangeEnd = 1301500, XrefRangeStart = 1301492, XrefRangeEnd = 1301496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToBase64CharArray(Il2CppStructArray<byte> inArray, int offsetIn, int length, Il2CppStructArray<char> outArray, int offsetOut)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inArray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetIn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outArray);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBase64CharArray_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x0004CDF0 File Offset: 0x0004AFF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301507, RefRangeEnd = 1301508, XrefRangeStart = 1301500, XrefRangeEnd = 1301507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToBase64CharArray(Il2CppStructArray<byte> inArray, int offsetIn, int length, Il2CppStructArray<char> outArray, int offsetOut, Base64FormattingOptions options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inArray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetIn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outArray);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offsetOut;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBase64CharArray_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_Base64FormattingOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x0004CE7C File Offset: 0x0004B07C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1301514, RefRangeEnd = 1301516, XrefRangeStart = 1301508, XrefRangeEnd = 1301514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ConvertToBase64Array(char* outChars, byte* inData, int offset, int length, bool insertLineBreaks)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = outChars;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = inData;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref insertLineBreaks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ConvertToBase64Array_Private_Static_Int32_ptr_Char_ptr_Byte_Int32_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x0004CEF0 File Offset: 0x0004B0F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1301516, RefRangeEnd = 1301518, XrefRangeStart = 1301516, XrefRangeEnd = 1301516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToBase64_CalculateAndValidateOutputLength(int inputLength, bool insertLineBreaks)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputLength;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref insertLineBreaks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBase64_CalculateAndValidateOutputLength_Private_Static_Int32_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x0004CF3C File Offset: 0x0004B13C
		[CallerCount(47)]
		[CachedScanResults(RefRangeStart = 1301529, RefRangeEnd = 1301576, XrefRangeStart = 1301518, XrefRangeEnd = 1301529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> FromBase64String(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_FromBase64String_Public_Static_Il2CppStructArray_1_Byte_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x0004CF80 File Offset: 0x0004B180
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301618, RefRangeEnd = 1301619, XrefRangeStart = 1301576, XrefRangeEnd = 1301618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryFromBase64Chars(ReadOnlySpan<char> chars, Span<byte> bytes, out int bytesWritten)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(chars));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(bytes));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bytesWritten;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_TryFromBase64Chars_Public_Static_Boolean_ReadOnlySpan_1_Char_Span_1_Byte_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x0004CFEC File Offset: 0x0004B1EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1301619, XrefRangeEnd = 1301624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyToTempBufferWithoutWhiteSpace(ReadOnlySpan<char> chars, Span<char> tempBuffer, out int consumed, out int charsWritten)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(chars));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tempBuffer));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &consumed;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charsWritten;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_CopyToTempBufferWithoutWhiteSpace_Private_Static_Void_ReadOnlySpan_1_Char_Span_1_Char_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x0004D05C File Offset: 0x0004B25C
		[CallerCount(0)]
		public unsafe static bool IsSpace(this char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_IsSpace_Private_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x0004D09C File Offset: 0x0004B29C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1301634, RefRangeEnd = 1301635, XrefRangeStart = 1301624, XrefRangeEnd = 1301634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> FromBase64CharArray(Il2CppStructArray<char> inArray, int offset, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inArray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_FromBase64CharArray_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Char_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x0004D0FC File Offset: 0x0004B2FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1301649, RefRangeEnd = 1301651, XrefRangeStart = 1301635, XrefRangeEnd = 1301649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> FromBase64CharPtr(char* inputPtr, int inputLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = inputPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_FromBase64CharPtr_Private_Static_Il2CppStructArray_1_Byte_ptr_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x0004D14C File Offset: 0x0004B34C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1301651, XrefRangeEnd = 1301653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FromBase64_ComputeResultLength(char* inputPtr, int inputLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = inputPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_FromBase64_ComputeResultLength_Private_Static_Int32_ptr_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x00004319 File Offset: 0x00002519
		public Convert(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x0600088B RID: 2187 RVA: 0x0004D198 File Offset: 0x0004B398
		// (set) Token: 0x0600088C RID: 2188 RVA: 0x00004322 File Offset: 0x00002522
		public unsafe static Il2CppStructArray<sbyte> s_decodingMap
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Convert.NativeFieldInfoPtr_s_decodingMap, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Convert.NativeFieldInfoPtr_s_decodingMap, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x0600088D RID: 2189 RVA: 0x0004D1C0 File Offset: 0x0004B3C0
		// (set) Token: 0x0600088E RID: 2190 RVA: 0x00004334 File Offset: 0x00002534
		public unsafe static Il2CppReferenceArray<Type> ConvertTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Convert.NativeFieldInfoPtr_ConvertTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Convert.NativeFieldInfoPtr_ConvertTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x0600088F RID: 2191 RVA: 0x0004D1E8 File Offset: 0x0004B3E8
		// (set) Token: 0x06000890 RID: 2192 RVA: 0x00004346 File Offset: 0x00002546
		public unsafe static Type EnumType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Convert.NativeFieldInfoPtr_EnumType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Convert.NativeFieldInfoPtr_EnumType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000891 RID: 2193 RVA: 0x0004D210 File Offset: 0x0004B410
		// (set) Token: 0x06000892 RID: 2194 RVA: 0x00004358 File Offset: 0x00002558
		public unsafe static Il2CppStructArray<char> base64Table
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Convert.NativeFieldInfoPtr_base64Table, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Convert.NativeFieldInfoPtr_base64Table, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000893 RID: 2195 RVA: 0x0004D238 File Offset: 0x0004B438
		// (set) Token: 0x06000894 RID: 2196 RVA: 0x0000436A File Offset: 0x0000256A
		public unsafe static Object DBNull
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Convert.NativeFieldInfoPtr_DBNull, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Convert.NativeFieldInfoPtr_DBNull, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005B4 RID: 1460
		private static readonly IntPtr NativeFieldInfoPtr_s_decodingMap;

		// Token: 0x040005B5 RID: 1461
		private static readonly IntPtr NativeFieldInfoPtr_ConvertTypes;

		// Token: 0x040005B6 RID: 1462
		private static readonly IntPtr NativeFieldInfoPtr_EnumType;

		// Token: 0x040005B7 RID: 1463
		private static readonly IntPtr NativeFieldInfoPtr_base64Table;

		// Token: 0x040005B8 RID: 1464
		private static readonly IntPtr NativeFieldInfoPtr_DBNull;

		// Token: 0x040005B9 RID: 1465
		private static readonly IntPtr NativeMethodInfoPtr_TryDecodeFromUtf16_Private_Static_Boolean_ReadOnlySpan_1_Char_Span_1_Byte_byref_Int32_byref_Int32_0;

		// Token: 0x040005BA RID: 1466
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Private_Static_Int32_byref_Char_byref_SByte_0;

		// Token: 0x040005BB RID: 1467
		private static readonly IntPtr NativeMethodInfoPtr_WriteThreeLowOrderBytes_Private_Static_Void_byref_Byte_Int32_0;

		// Token: 0x040005BC RID: 1468
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeCode_Public_Static_TypeCode_Object_0;

		// Token: 0x040005BD RID: 1469
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Static_Object_Object_TypeCode_IFormatProvider_0;

		// Token: 0x040005BE RID: 1470
		private static readonly IntPtr NativeMethodInfoPtr_DefaultToType_Internal_Static_Object_IConvertible_Type_IFormatProvider_0;

		// Token: 0x040005BF RID: 1471
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Static_Object_Object_Type_0;

		// Token: 0x040005C0 RID: 1472
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Static_Object_Object_Type_IFormatProvider_0;

		// Token: 0x040005C1 RID: 1473
		private static readonly IntPtr NativeMethodInfoPtr_ThrowCharOverflowException_Private_Static_Void_0;

		// Token: 0x040005C2 RID: 1474
		private static readonly IntPtr NativeMethodInfoPtr_ThrowByteOverflowException_Private_Static_Void_0;

		// Token: 0x040005C3 RID: 1475
		private static readonly IntPtr NativeMethodInfoPtr_ThrowSByteOverflowException_Private_Static_Void_0;

		// Token: 0x040005C4 RID: 1476
		private static readonly IntPtr NativeMethodInfoPtr_ThrowInt16OverflowException_Private_Static_Void_0;

		// Token: 0x040005C5 RID: 1477
		private static readonly IntPtr NativeMethodInfoPtr_ThrowUInt16OverflowException_Private_Static_Void_0;

		// Token: 0x040005C6 RID: 1478
		private static readonly IntPtr NativeMethodInfoPtr_ThrowInt32OverflowException_Private_Static_Void_0;

		// Token: 0x040005C7 RID: 1479
		private static readonly IntPtr NativeMethodInfoPtr_ThrowUInt32OverflowException_Private_Static_Void_0;

		// Token: 0x040005C8 RID: 1480
		private static readonly IntPtr NativeMethodInfoPtr_ThrowInt64OverflowException_Private_Static_Void_0;

		// Token: 0x040005C9 RID: 1481
		private static readonly IntPtr NativeMethodInfoPtr_ThrowUInt64OverflowException_Private_Static_Void_0;

		// Token: 0x040005CA RID: 1482
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Object_IFormatProvider_0;

		// Token: 0x040005CB RID: 1483
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_SByte_0;

		// Token: 0x040005CC RID: 1484
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Byte_0;

		// Token: 0x040005CD RID: 1485
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Int16_0;

		// Token: 0x040005CE RID: 1486
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_UInt16_0;

		// Token: 0x040005CF RID: 1487
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Int32_0;

		// Token: 0x040005D0 RID: 1488
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_UInt32_0;

		// Token: 0x040005D1 RID: 1489
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Int64_0;

		// Token: 0x040005D2 RID: 1490
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_UInt64_0;

		// Token: 0x040005D3 RID: 1491
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_String_IFormatProvider_0;

		// Token: 0x040005D4 RID: 1492
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Single_0;

		// Token: 0x040005D5 RID: 1493
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Double_0;

		// Token: 0x040005D6 RID: 1494
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Decimal_0;

		// Token: 0x040005D7 RID: 1495
		private static readonly IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_Object_IFormatProvider_0;

		// Token: 0x040005D8 RID: 1496
		private static readonly IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_SByte_0;

		// Token: 0x040005D9 RID: 1497
		private static readonly IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_Byte_0;

		// Token: 0x040005DA RID: 1498
		private static readonly IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_Int16_0;

		// Token: 0x040005DB RID: 1499
		private static readonly IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_UInt16_0;

		// Token: 0x040005DC RID: 1500
		private static readonly IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_Int32_0;

		// Token: 0x040005DD RID: 1501
		private static readonly IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_UInt32_0;

		// Token: 0x040005DE RID: 1502
		private static readonly IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_Int64_0;

		// Token: 0x040005DF RID: 1503
		private static readonly IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_UInt64_0;

		// Token: 0x040005E0 RID: 1504
		private static readonly IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_String_0;

		// Token: 0x040005E1 RID: 1505
		private static readonly IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_String_IFormatProvider_0;

		// Token: 0x040005E2 RID: 1506
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Object_IFormatProvider_0;

		// Token: 0x040005E3 RID: 1507
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Boolean_0;

		// Token: 0x040005E4 RID: 1508
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Char_0;

		// Token: 0x040005E5 RID: 1509
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Byte_0;

		// Token: 0x040005E6 RID: 1510
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Int16_0;

		// Token: 0x040005E7 RID: 1511
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_UInt16_0;

		// Token: 0x040005E8 RID: 1512
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Int32_0;

		// Token: 0x040005E9 RID: 1513
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_UInt32_0;

		// Token: 0x040005EA RID: 1514
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Int64_0;

		// Token: 0x040005EB RID: 1515
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_UInt64_0;

		// Token: 0x040005EC RID: 1516
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Single_0;

		// Token: 0x040005ED RID: 1517
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Double_0;

		// Token: 0x040005EE RID: 1518
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Decimal_0;

		// Token: 0x040005EF RID: 1519
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_String_IFormatProvider_0;

		// Token: 0x040005F0 RID: 1520
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_Object_IFormatProvider_0;

		// Token: 0x040005F1 RID: 1521
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_Boolean_0;

		// Token: 0x040005F2 RID: 1522
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_Char_0;

		// Token: 0x040005F3 RID: 1523
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_SByte_0;

		// Token: 0x040005F4 RID: 1524
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_Int16_0;

		// Token: 0x040005F5 RID: 1525
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_UInt16_0;

		// Token: 0x040005F6 RID: 1526
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_Int32_0;

		// Token: 0x040005F7 RID: 1527
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_UInt32_0;

		// Token: 0x040005F8 RID: 1528
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_Int64_0;

		// Token: 0x040005F9 RID: 1529
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_UInt64_0;

		// Token: 0x040005FA RID: 1530
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_Single_0;

		// Token: 0x040005FB RID: 1531
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_Double_0;

		// Token: 0x040005FC RID: 1532
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_Decimal_0;

		// Token: 0x040005FD RID: 1533
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_String_0;

		// Token: 0x040005FE RID: 1534
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_String_IFormatProvider_0;

		// Token: 0x040005FF RID: 1535
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Object_IFormatProvider_0;

		// Token: 0x04000600 RID: 1536
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Boolean_0;

		// Token: 0x04000601 RID: 1537
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Char_0;

		// Token: 0x04000602 RID: 1538
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_SByte_0;

		// Token: 0x04000603 RID: 1539
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Byte_0;

		// Token: 0x04000604 RID: 1540
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_UInt16_0;

		// Token: 0x04000605 RID: 1541
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Int32_0;

		// Token: 0x04000606 RID: 1542
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_UInt32_0;

		// Token: 0x04000607 RID: 1543
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Int64_0;

		// Token: 0x04000608 RID: 1544
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_UInt64_0;

		// Token: 0x04000609 RID: 1545
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Single_0;

		// Token: 0x0400060A RID: 1546
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Double_0;

		// Token: 0x0400060B RID: 1547
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Decimal_0;

		// Token: 0x0400060C RID: 1548
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_String_IFormatProvider_0;

		// Token: 0x0400060D RID: 1549
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Object_IFormatProvider_0;

		// Token: 0x0400060E RID: 1550
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Boolean_0;

		// Token: 0x0400060F RID: 1551
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Char_0;

		// Token: 0x04000610 RID: 1552
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_SByte_0;

		// Token: 0x04000611 RID: 1553
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Byte_0;

		// Token: 0x04000612 RID: 1554
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Int16_0;

		// Token: 0x04000613 RID: 1555
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Int32_0;

		// Token: 0x04000614 RID: 1556
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_UInt32_0;

		// Token: 0x04000615 RID: 1557
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Int64_0;

		// Token: 0x04000616 RID: 1558
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_UInt64_0;

		// Token: 0x04000617 RID: 1559
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Single_0;

		// Token: 0x04000618 RID: 1560
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Double_0;

		// Token: 0x04000619 RID: 1561
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Decimal_0;

		// Token: 0x0400061A RID: 1562
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_String_IFormatProvider_0;

		// Token: 0x0400061B RID: 1563
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Object_0;

		// Token: 0x0400061C RID: 1564
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Object_IFormatProvider_0;

		// Token: 0x0400061D RID: 1565
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Boolean_0;

		// Token: 0x0400061E RID: 1566
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Char_0;

		// Token: 0x0400061F RID: 1567
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Byte_0;

		// Token: 0x04000620 RID: 1568
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Int16_0;

		// Token: 0x04000621 RID: 1569
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_UInt16_0;

		// Token: 0x04000622 RID: 1570
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_UInt32_0;

		// Token: 0x04000623 RID: 1571
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Int32_0;

		// Token: 0x04000624 RID: 1572
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Int64_0;

		// Token: 0x04000625 RID: 1573
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_UInt64_0;

		// Token: 0x04000626 RID: 1574
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Single_0;

		// Token: 0x04000627 RID: 1575
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Double_0;

		// Token: 0x04000628 RID: 1576
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Decimal_0;

		// Token: 0x04000629 RID: 1577
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_0;

		// Token: 0x0400062A RID: 1578
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_IFormatProvider_0;

		// Token: 0x0400062B RID: 1579
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Object_0;

		// Token: 0x0400062C RID: 1580
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Object_IFormatProvider_0;

		// Token: 0x0400062D RID: 1581
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Boolean_0;

		// Token: 0x0400062E RID: 1582
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Char_0;

		// Token: 0x0400062F RID: 1583
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_SByte_0;

		// Token: 0x04000630 RID: 1584
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Byte_0;

		// Token: 0x04000631 RID: 1585
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Int16_0;

		// Token: 0x04000632 RID: 1586
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_UInt16_0;

		// Token: 0x04000633 RID: 1587
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Int32_0;

		// Token: 0x04000634 RID: 1588
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Int64_0;

		// Token: 0x04000635 RID: 1589
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_UInt64_0;

		// Token: 0x04000636 RID: 1590
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Single_0;

		// Token: 0x04000637 RID: 1591
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Double_0;

		// Token: 0x04000638 RID: 1592
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Decimal_0;

		// Token: 0x04000639 RID: 1593
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_String_IFormatProvider_0;

		// Token: 0x0400063A RID: 1594
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Object_0;

		// Token: 0x0400063B RID: 1595
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Object_IFormatProvider_0;

		// Token: 0x0400063C RID: 1596
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Boolean_0;

		// Token: 0x0400063D RID: 1597
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Char_0;

		// Token: 0x0400063E RID: 1598
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_SByte_0;

		// Token: 0x0400063F RID: 1599
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Byte_0;

		// Token: 0x04000640 RID: 1600
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Int16_0;

		// Token: 0x04000641 RID: 1601
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_UInt16_0;

		// Token: 0x04000642 RID: 1602
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Int32_0;

		// Token: 0x04000643 RID: 1603
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_UInt32_0;

		// Token: 0x04000644 RID: 1604
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_UInt64_0;

		// Token: 0x04000645 RID: 1605
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Single_0;

		// Token: 0x04000646 RID: 1606
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Double_0;

		// Token: 0x04000647 RID: 1607
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Decimal_0;

		// Token: 0x04000648 RID: 1608
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_String_0;

		// Token: 0x04000649 RID: 1609
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_String_IFormatProvider_0;

		// Token: 0x0400064A RID: 1610
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Object_0;

		// Token: 0x0400064B RID: 1611
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Object_IFormatProvider_0;

		// Token: 0x0400064C RID: 1612
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Boolean_0;

		// Token: 0x0400064D RID: 1613
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Char_0;

		// Token: 0x0400064E RID: 1614
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_SByte_0;

		// Token: 0x0400064F RID: 1615
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Byte_0;

		// Token: 0x04000650 RID: 1616
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Int16_0;

		// Token: 0x04000651 RID: 1617
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_UInt16_0;

		// Token: 0x04000652 RID: 1618
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Int32_0;

		// Token: 0x04000653 RID: 1619
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_UInt32_0;

		// Token: 0x04000654 RID: 1620
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Int64_0;

		// Token: 0x04000655 RID: 1621
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Single_0;

		// Token: 0x04000656 RID: 1622
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Double_0;

		// Token: 0x04000657 RID: 1623
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Decimal_0;

		// Token: 0x04000658 RID: 1624
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_String_IFormatProvider_0;

		// Token: 0x04000659 RID: 1625
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_Object_IFormatProvider_0;

		// Token: 0x0400065A RID: 1626
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_SByte_0;

		// Token: 0x0400065B RID: 1627
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_Byte_0;

		// Token: 0x0400065C RID: 1628
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_Int16_0;

		// Token: 0x0400065D RID: 1629
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_UInt16_0;

		// Token: 0x0400065E RID: 1630
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_Int32_0;

		// Token: 0x0400065F RID: 1631
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_UInt32_0;

		// Token: 0x04000660 RID: 1632
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_Int64_0;

		// Token: 0x04000661 RID: 1633
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_UInt64_0;

		// Token: 0x04000662 RID: 1634
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_Double_0;

		// Token: 0x04000663 RID: 1635
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_Decimal_0;

		// Token: 0x04000664 RID: 1636
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_String_IFormatProvider_0;

		// Token: 0x04000665 RID: 1637
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_Boolean_0;

		// Token: 0x04000666 RID: 1638
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_Object_0;

		// Token: 0x04000667 RID: 1639
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_Object_IFormatProvider_0;

		// Token: 0x04000668 RID: 1640
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_SByte_0;

		// Token: 0x04000669 RID: 1641
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_Byte_0;

		// Token: 0x0400066A RID: 1642
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_Int16_0;

		// Token: 0x0400066B RID: 1643
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_UInt16_0;

		// Token: 0x0400066C RID: 1644
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_Int32_0;

		// Token: 0x0400066D RID: 1645
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_UInt32_0;

		// Token: 0x0400066E RID: 1646
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_Int64_0;

		// Token: 0x0400066F RID: 1647
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_UInt64_0;

		// Token: 0x04000670 RID: 1648
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_Single_0;

		// Token: 0x04000671 RID: 1649
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_Decimal_0;

		// Token: 0x04000672 RID: 1650
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_String_IFormatProvider_0;

		// Token: 0x04000673 RID: 1651
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_Boolean_0;

		// Token: 0x04000674 RID: 1652
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Object_0;

		// Token: 0x04000675 RID: 1653
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Object_IFormatProvider_0;

		// Token: 0x04000676 RID: 1654
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_SByte_0;

		// Token: 0x04000677 RID: 1655
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Byte_0;

		// Token: 0x04000678 RID: 1656
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Int16_0;

		// Token: 0x04000679 RID: 1657
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_UInt16_0;

		// Token: 0x0400067A RID: 1658
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Int32_0;

		// Token: 0x0400067B RID: 1659
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_UInt32_0;

		// Token: 0x0400067C RID: 1660
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Int64_0;

		// Token: 0x0400067D RID: 1661
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_UInt64_0;

		// Token: 0x0400067E RID: 1662
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Single_0;

		// Token: 0x0400067F RID: 1663
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Double_0;

		// Token: 0x04000680 RID: 1664
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_String_IFormatProvider_0;

		// Token: 0x04000681 RID: 1665
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Boolean_0;

		// Token: 0x04000682 RID: 1666
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_Object_IFormatProvider_0;

		// Token: 0x04000683 RID: 1667
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_String_IFormatProvider_0;

		// Token: 0x04000684 RID: 1668
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Object_0;

		// Token: 0x04000685 RID: 1669
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Object_IFormatProvider_0;

		// Token: 0x04000686 RID: 1670
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Char_IFormatProvider_0;

		// Token: 0x04000687 RID: 1671
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Int32_0;

		// Token: 0x04000688 RID: 1672
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Int32_IFormatProvider_0;

		// Token: 0x04000689 RID: 1673
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Double_IFormatProvider_0;

		// Token: 0x0400068A RID: 1674
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_String_Int32_0;

		// Token: 0x0400068B RID: 1675
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_String_Int32_0;

		// Token: 0x0400068C RID: 1676
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_String_Int32_0;

		// Token: 0x0400068D RID: 1677
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_String_Int32_0;

		// Token: 0x0400068E RID: 1678
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_Int32_0;

		// Token: 0x0400068F RID: 1679
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_String_Int32_0;

		// Token: 0x04000690 RID: 1680
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_String_Int32_0;

		// Token: 0x04000691 RID: 1681
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_String_Int32_0;

		// Token: 0x04000692 RID: 1682
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Byte_Int32_0;

		// Token: 0x04000693 RID: 1683
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Int32_Int32_0;

		// Token: 0x04000694 RID: 1684
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Int64_Int32_0;

		// Token: 0x04000695 RID: 1685
		private static readonly IntPtr NativeMethodInfoPtr_ToBase64String_Public_Static_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000696 RID: 1686
		private static readonly IntPtr NativeMethodInfoPtr_ToBase64String_Public_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000697 RID: 1687
		private static readonly IntPtr NativeMethodInfoPtr_ToBase64String_Public_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_Base64FormattingOptions_0;

		// Token: 0x04000698 RID: 1688
		private static readonly IntPtr NativeMethodInfoPtr_ToBase64String_Public_Static_String_ReadOnlySpan_1_Byte_Base64FormattingOptions_0;

		// Token: 0x04000699 RID: 1689
		private static readonly IntPtr NativeMethodInfoPtr_ToBase64CharArray_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x0400069A RID: 1690
		private static readonly IntPtr NativeMethodInfoPtr_ToBase64CharArray_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_Base64FormattingOptions_0;

		// Token: 0x0400069B RID: 1691
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToBase64Array_Private_Static_Int32_ptr_Char_ptr_Byte_Int32_Int32_Boolean_0;

		// Token: 0x0400069C RID: 1692
		private static readonly IntPtr NativeMethodInfoPtr_ToBase64_CalculateAndValidateOutputLength_Private_Static_Int32_Int32_Boolean_0;

		// Token: 0x0400069D RID: 1693
		private static readonly IntPtr NativeMethodInfoPtr_FromBase64String_Public_Static_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x0400069E RID: 1694
		private static readonly IntPtr NativeMethodInfoPtr_TryFromBase64Chars_Public_Static_Boolean_ReadOnlySpan_1_Char_Span_1_Byte_byref_Int32_0;

		// Token: 0x0400069F RID: 1695
		private static readonly IntPtr NativeMethodInfoPtr_CopyToTempBufferWithoutWhiteSpace_Private_Static_Void_ReadOnlySpan_1_Char_Span_1_Char_byref_Int32_byref_Int32_0;

		// Token: 0x040006A0 RID: 1696
		private static readonly IntPtr NativeMethodInfoPtr_IsSpace_Private_Static_Boolean_Char_0;

		// Token: 0x040006A1 RID: 1697
		private static readonly IntPtr NativeMethodInfoPtr_FromBase64CharArray_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040006A2 RID: 1698
		private static readonly IntPtr NativeMethodInfoPtr_FromBase64CharPtr_Private_Static_Il2CppStructArray_1_Byte_ptr_Char_Int32_0;

		// Token: 0x040006A3 RID: 1699
		private static readonly IntPtr NativeMethodInfoPtr_FromBase64_ComputeResultLength_Private_Static_Int32_ptr_Char_Int32_0;
	}
}
