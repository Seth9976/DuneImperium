using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem
{
	// Token: 0x02000180 RID: 384
	[Serializable]
	[StructLayout(2)]
	public struct Decimal
	{
		// Token: 0x06001959 RID: 6489 RVA: 0x0009D218 File Offset: 0x0009B418
		// Note: this type is marked as 'beforefieldinit'.
		static Decimal()
		{
			Il2CppClassPointerStore<Decimal>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Decimal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Decimal>.NativeClassPtr);
			Decimal.NativeFieldInfoPtr_SignMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal>.NativeClassPtr, "SignMask");
			Decimal.NativeFieldInfoPtr_ScaleMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal>.NativeClassPtr, "ScaleMask");
			Decimal.NativeFieldInfoPtr_ScaleShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal>.NativeClassPtr, "ScaleShift");
			Decimal.NativeFieldInfoPtr_Zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal>.NativeClassPtr, "Zero");
			Decimal.NativeFieldInfoPtr_One = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal>.NativeClassPtr, "One");
			Decimal.NativeFieldInfoPtr_MinusOne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal>.NativeClassPtr, "MinusOne");
			Decimal.NativeFieldInfoPtr_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal>.NativeClassPtr, "MaxValue");
			Decimal.NativeFieldInfoPtr_MinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal>.NativeClassPtr, "MinValue");
			Decimal.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal>.NativeClassPtr, "flags");
			Decimal.NativeFieldInfoPtr_hi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal>.NativeClassPtr, "hi");
			Decimal.NativeFieldInfoPtr_lo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal>.NativeClassPtr, "lo");
			Decimal.NativeFieldInfoPtr_mid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal>.NativeClassPtr, "mid");
			Decimal.NativeFieldInfoPtr_ulomidLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal>.NativeClassPtr, "ulomidLE");
			Decimal.NativeMethodInfoPtr_get_High_Internal_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667663);
			Decimal.NativeMethodInfoPtr_get_Low_Internal_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667664);
			Decimal.NativeMethodInfoPtr_get_Mid_Internal_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667665);
			Decimal.NativeMethodInfoPtr_get_IsNegative_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667666);
			Decimal.NativeMethodInfoPtr_get_Scale_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667667);
			Decimal.NativeMethodInfoPtr_get_Low64_Private_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667668);
			Decimal.NativeMethodInfoPtr_AsMutable_Private_Static_byref_DecCalc_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667669);
			Decimal.NativeMethodInfoPtr_DecDivMod1E9_Internal_Static_UInt32_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667670);
			Decimal.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667671);
			Decimal.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667672);
			Decimal.NativeMethodInfoPtr__ctor_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667673);
			Decimal.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667674);
			Decimal.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667675);
			Decimal.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667676);
			Decimal.NativeMethodInfoPtr_IsValid_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667677);
			Decimal.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667678);
			Decimal.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Boolean_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667679);
			Decimal.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667680);
			Decimal.NativeMethodInfoPtr__ctor_Private_Void_byref_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667681);
			Decimal.NativeMethodInfoPtr_Abs_Internal_Static_Decimal_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667682);
			Decimal.NativeMethodInfoPtr_Add_Public_Static_Decimal_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667683);
			Decimal.NativeMethodInfoPtr_Ceiling_Public_Static_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667684);
			Decimal.NativeMethodInfoPtr_Compare_Public_Static_Int32_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667685);
			Decimal.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667686);
			Decimal.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667687);
			Decimal.NativeMethodInfoPtr_Divide_Public_Static_Decimal_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667688);
			Decimal.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667689);
			Decimal.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667690);
			Decimal.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667691);
			Decimal.NativeMethodInfoPtr_Floor_Public_Static_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667692);
			Decimal.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667693);
			Decimal.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667694);
			Decimal.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667695);
			Decimal.NativeMethodInfoPtr_TryFormat_Public_Virtual_Final_New_Boolean_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667696);
			Decimal.NativeMethodInfoPtr_Parse_Public_Static_Decimal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667697);
			Decimal.NativeMethodInfoPtr_Parse_Public_Static_Decimal_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667698);
			Decimal.NativeMethodInfoPtr_Parse_Public_Static_Decimal_String_NumberStyles_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667699);
			Decimal.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_NumberStyles_IFormatProvider_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667700);
			Decimal.NativeMethodInfoPtr_GetBits_Public_Static_Il2CppStructArray_1_Int32_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667701);
			Decimal.NativeMethodInfoPtr_Max_Internal_Static_byref_Decimal_byref_Decimal_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667702);
			Decimal.NativeMethodInfoPtr_Min_Internal_Static_byref_Decimal_byref_Decimal_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667703);
			Decimal.NativeMethodInfoPtr_Multiply_Public_Static_Decimal_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667704);
			Decimal.NativeMethodInfoPtr_Negate_Public_Static_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667705);
			Decimal.NativeMethodInfoPtr_Round_Public_Static_Decimal_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667706);
			Decimal.NativeMethodInfoPtr_Round_Private_Static_Decimal_byref_Decimal_Int32_MidpointRounding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667707);
			Decimal.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667708);
			Decimal.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667709);
			Decimal.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667710);
			Decimal.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667711);
			Decimal.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667712);
			Decimal.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667713);
			Decimal.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667714);
			Decimal.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667715);
			Decimal.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667716);
			Decimal.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667717);
			Decimal.NativeMethodInfoPtr_Truncate_Public_Static_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667718);
			Decimal.NativeMethodInfoPtr_Truncate_Private_Static_Void_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667719);
			Decimal.NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667720);
			Decimal.NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667721);
			Decimal.NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667722);
			Decimal.NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667723);
			Decimal.NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667724);
			Decimal.NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667725);
			Decimal.NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667726);
			Decimal.NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667727);
			Decimal.NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667728);
			Decimal.NativeMethodInfoPtr_op_Explicit_Public_Static_Decimal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667729);
			Decimal.NativeMethodInfoPtr_op_Explicit_Public_Static_Decimal_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667730);
			Decimal.NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667731);
			Decimal.NativeMethodInfoPtr_op_Explicit_Public_Static_Int64_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667732);
			Decimal.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667733);
			Decimal.NativeMethodInfoPtr_op_Explicit_Public_Static_Single_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667734);
			Decimal.NativeMethodInfoPtr_op_Explicit_Public_Static_Double_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667735);
			Decimal.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667736);
			Decimal.NativeMethodInfoPtr_op_Increment_Public_Static_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667737);
			Decimal.NativeMethodInfoPtr_op_Addition_Public_Static_Decimal_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667738);
			Decimal.NativeMethodInfoPtr_op_Subtraction_Public_Static_Decimal_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667739);
			Decimal.NativeMethodInfoPtr_op_Multiply_Public_Static_Decimal_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667740);
			Decimal.NativeMethodInfoPtr_op_Division_Public_Static_Decimal_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667741);
			Decimal.NativeMethodInfoPtr_op_Modulus_Public_Static_Decimal_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667742);
			Decimal.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667743);
			Decimal.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667744);
			Decimal.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667745);
			Decimal.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667746);
			Decimal.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667747);
			Decimal.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667748);
			Decimal.NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667749);
			Decimal.NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667750);
			Decimal.NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667751);
			Decimal.NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667752);
			Decimal.NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667753);
			Decimal.NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667754);
			Decimal.NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667755);
			Decimal.NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667756);
			Decimal.NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667757);
			Decimal.NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667758);
			Decimal.NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667759);
			Decimal.NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667760);
			Decimal.NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667761);
			Decimal.NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667762);
			Decimal.NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667763);
			Decimal.NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100667764);
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x0600195A RID: 6490 RVA: 0x0009DB44 File Offset: 0x0009BD44
		public unsafe uint High
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_get_High_Internal_get_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x0600195B RID: 6491 RVA: 0x0009DB74 File Offset: 0x0009BD74
		public unsafe uint Low
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_get_Low_Internal_get_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x0600195C RID: 6492 RVA: 0x0009DBA4 File Offset: 0x0009BDA4
		public unsafe uint Mid
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_get_Mid_Internal_get_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x0600195D RID: 6493 RVA: 0x0009DBD4 File Offset: 0x0009BDD4
		public unsafe bool IsNegative
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1350100, RefRangeEnd = 1350101, XrefRangeStart = 1350100, XrefRangeEnd = 1350101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_get_IsNegative_Internal_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x0600195E RID: 6494 RVA: 0x0009DC04 File Offset: 0x0009BE04
		public unsafe int Scale
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1185388, RefRangeEnd = 1185389, XrefRangeStart = 1185388, XrefRangeEnd = 1185389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_get_Scale_Internal_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x0600195F RID: 6495 RVA: 0x0009DC34 File Offset: 0x0009BE34
		public unsafe ulong Low64
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1350532, XrefRangeEnd = 1350533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_get_Low64_Private_get_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001960 RID: 6496 RVA: 0x0009DC64 File Offset: 0x0009BE64
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ref Decimal.DecCalc AsMutable(ref Decimal d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_AsMutable_Private_Static_byref_DecCalc_byref_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x06001961 RID: 6497 RVA: 0x0009DC98 File Offset: 0x0009BE98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1350539, RefRangeEnd = 1350540, XrefRangeStart = 1350533, XrefRangeEnd = 1350539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint DecDivMod1E9(ref Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_DecDivMod1E9_Internal_Static_UInt32_byref_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001962 RID: 6498 RVA: 0x0009DCD8 File Offset: 0x0009BED8
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 1350540, RefRangeEnd = 1350572, XrefRangeStart = 1350540, XrefRangeEnd = 1350540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Decimal(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001963 RID: 6499 RVA: 0x0009DD0C File Offset: 0x0009BF0C
		[CallerCount(0)]
		public unsafe Decimal(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001964 RID: 6500 RVA: 0x0009DD40 File Offset: 0x0009BF40
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1350572, RefRangeEnd = 1350576, XrefRangeStart = 1350572, XrefRangeEnd = 1350572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Decimal(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr__ctor_Public_Void_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001965 RID: 6501 RVA: 0x0009DD74 File Offset: 0x0009BF74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1350576, RefRangeEnd = 1350577, XrefRangeStart = 1350576, XrefRangeEnd = 1350576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Decimal(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001966 RID: 6502 RVA: 0x0009DDA8 File Offset: 0x0009BFA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1350584, RefRangeEnd = 1350586, XrefRangeStart = 1350577, XrefRangeEnd = 1350584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Decimal(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001967 RID: 6503 RVA: 0x0009DDDC File Offset: 0x0009BFDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1350593, RefRangeEnd = 1350594, XrefRangeStart = 1350586, XrefRangeEnd = 1350593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Decimal(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001968 RID: 6504 RVA: 0x0009DE10 File Offset: 0x0009C010
		[CallerCount(0)]
		public unsafe static bool IsValid(int flags)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_IsValid_Private_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001969 RID: 6505 RVA: 0x0009DE50 File Offset: 0x0009C050
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1350597, RefRangeEnd = 1350599, XrefRangeStart = 1350594, XrefRangeEnd = 1350597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Decimal(Il2CppStructArray<int> bits)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bits);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600196A RID: 6506 RVA: 0x0009DE88 File Offset: 0x0009C088
		[CallerCount(49)]
		[CachedScanResults(RefRangeStart = 1350599, RefRangeEnd = 1350648, XrefRangeStart = 1350599, XrefRangeEnd = 1350599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Decimal(int lo, int mid, int hi, bool isNegative, byte scale)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lo;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mid;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNegative;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Boolean_Byte_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600196B RID: 6507 RVA: 0x0009DEF4 File Offset: 0x0009C0F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1350648, XrefRangeEnd = 1350651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Runtime_Serialization_IDeserializationCallback_OnDeserialization(Object sender)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600196C RID: 6508 RVA: 0x0009DF2C File Offset: 0x0009C12C
		[CallerCount(0)]
		public unsafe Decimal([In] ref Decimal d, int flags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &d;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr__ctor_Private_Void_byref_Decimal_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600196D RID: 6509 RVA: 0x0009DF6C File Offset: 0x0009C16C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1350651, RefRangeEnd = 1350652, XrefRangeStart = 1350651, XrefRangeEnd = 1350651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal Abs(ref Decimal d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_Abs_Internal_Static_Decimal_byref_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600196E RID: 6510 RVA: 0x0009DFAC File Offset: 0x0009C1AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1350652, XrefRangeEnd = 1350659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal Add(Decimal d1, Decimal d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_Add_Public_Static_Decimal_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600196F RID: 6511 RVA: 0x0009DFF8 File Offset: 0x0009C1F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1350666, RefRangeEnd = 1350669, XrefRangeStart = 1350659, XrefRangeEnd = 1350666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal Ceiling(Decimal d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_Ceiling_Public_Static_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001970 RID: 6512 RVA: 0x0009E038 File Offset: 0x0009C238
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1350673, RefRangeEnd = 1350675, XrefRangeStart = 1350669, XrefRangeEnd = 1350673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Compare(Decimal d1, Decimal d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_Compare_Public_Static_Int32_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001971 RID: 6513 RVA: 0x0009E084 File Offset: 0x0009C284
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1350682, RefRangeEnd = 1350683, XrefRangeStart = 1350675, XrefRangeEnd = 1350682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001972 RID: 6514 RVA: 0x0009E0C8 File Offset: 0x0009C2C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1350683, XrefRangeEnd = 1350687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Decimal_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001973 RID: 6515 RVA: 0x0009E108 File Offset: 0x0009C308
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1350694, RefRangeEnd = 1350695, XrefRangeStart = 1350687, XrefRangeEnd = 1350694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal Divide(Decimal d1, Decimal d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_Divide_Public_Static_Decimal_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001974 RID: 6516 RVA: 0x0009E154 File Offset: 0x0009C354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1350695, XrefRangeEnd = 1350702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001975 RID: 6517 RVA: 0x0009E198 File Offset: 0x0009C398
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1350706, RefRangeEnd = 1350707, XrefRangeStart = 1350702, XrefRangeEnd = 1350706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Decimal_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001976 RID: 6518 RVA: 0x0009E1D8 File Offset: 0x0009C3D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1350721, RefRangeEnd = 1350722, XrefRangeStart = 1350707, XrefRangeEnd = 1350721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001977 RID: 6519 RVA: 0x0009E208 File Offset: 0x0009C408
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1350729, RefRangeEnd = 1350730, XrefRangeStart = 1350722, XrefRangeEnd = 1350729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal Floor(Decimal d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_Floor_Public_Static_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x0009E248 File Offset: 0x0009C448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1350730, XrefRangeEnd = 1350738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x0009E274 File Offset: 0x0009C474
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1350746, RefRangeEnd = 1350750, XrefRangeStart = 1350738, XrefRangeEnd = 1350746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600197A RID: 6522 RVA: 0x0009E2B0 File Offset: 0x0009C4B0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1350758, RefRangeEnd = 1350763, XrefRangeStart = 1350750, XrefRangeEnd = 1350758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600197B RID: 6523 RVA: 0x0009E300 File Offset: 0x0009C500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1350763, XrefRangeEnd = 1350768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = null, IFormatProvider provider = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(destination));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charsWritten;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(format));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_TryFormat_Public_Virtual_Final_New_Boolean_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600197C RID: 6524 RVA: 0x0009E380 File Offset: 0x0009C580
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1350777, RefRangeEnd = 1350778, XrefRangeStart = 1350768, XrefRangeEnd = 1350777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal Parse(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_Parse_Public_Static_Decimal_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x0009E3C4 File Offset: 0x0009C5C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1350787, RefRangeEnd = 1350789, XrefRangeStart = 1350778, XrefRangeEnd = 1350787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal Parse(string s, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_Parse_Public_Static_Decimal_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x0009E418 File Offset: 0x0009C618
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1350799, RefRangeEnd = 1350803, XrefRangeStart = 1350789, XrefRangeEnd = 1350799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal Parse(string s, NumberStyles style, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_Parse_Public_Static_Decimal_String_NumberStyles_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x0009E47C File Offset: 0x0009C67C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1350812, RefRangeEnd = 1350816, XrefRangeStart = 1350803, XrefRangeEnd = 1350812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out Decimal result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_NumberStyles_IFormatProvider_byref_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x0009E4EC File Offset: 0x0009C6EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1350819, RefRangeEnd = 1350822, XrefRangeStart = 1350816, XrefRangeEnd = 1350819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<int> GetBits(Decimal d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_GetBits_Public_Static_Il2CppStructArray_1_Int32_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06001981 RID: 6529 RVA: 0x0009E52C File Offset: 0x0009C72C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1350826, RefRangeEnd = 1350827, XrefRangeStart = 1350822, XrefRangeEnd = 1350826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ref Decimal Max(ref Decimal d1, ref Decimal d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &d1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &d2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_Max_Internal_Static_byref_Decimal_byref_Decimal_byref_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x06001982 RID: 6530 RVA: 0x0009E570 File Offset: 0x0009C770
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1350831, RefRangeEnd = 1350833, XrefRangeStart = 1350827, XrefRangeEnd = 1350831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ref Decimal Min(ref Decimal d1, ref Decimal d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &d1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &d2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_Min_Internal_Static_byref_Decimal_byref_Decimal_byref_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x06001983 RID: 6531 RVA: 0x0009E5B4 File Offset: 0x0009C7B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1350840, RefRangeEnd = 1350841, XrefRangeStart = 1350833, XrefRangeEnd = 1350840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal Multiply(Decimal d1, Decimal d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_Multiply_Public_Static_Decimal_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x0009E600 File Offset: 0x0009C800
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1350841, RefRangeEnd = 1350843, XrefRangeStart = 1350841, XrefRangeEnd = 1350841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal Negate(Decimal d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_Negate_Public_Static_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x0009E640 File Offset: 0x0009C840
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1350855, RefRangeEnd = 1350866, XrefRangeStart = 1350843, XrefRangeEnd = 1350855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal Round(Decimal d, int decimals)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref decimals;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_Round_Public_Static_Decimal_Decimal_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001986 RID: 6534 RVA: 0x0009E68C File Offset: 0x0009C88C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1350866, XrefRangeEnd = 1350875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal Round(ref Decimal d, int decimals, MidpointRounding mode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &d;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref decimals;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_Round_Private_Static_Decimal_byref_Decimal_Int32_MidpointRounding_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001987 RID: 6535 RVA: 0x0009E6E8 File Offset: 0x0009C8E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1350879, RefRangeEnd = 1350880, XrefRangeStart = 1350875, XrefRangeEnd = 1350879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ToByte(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001988 RID: 6536 RVA: 0x0009E728 File Offset: 0x0009C928
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1350884, RefRangeEnd = 1350885, XrefRangeStart = 1350880, XrefRangeEnd = 1350884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte ToSByte(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001989 RID: 6537 RVA: 0x0009E768 File Offset: 0x0009C968
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1350889, RefRangeEnd = 1350890, XrefRangeStart = 1350885, XrefRangeEnd = 1350889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ToInt16(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600198A RID: 6538 RVA: 0x0009E7A8 File Offset: 0x0009C9A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1350894, RefRangeEnd = 1350897, XrefRangeStart = 1350890, XrefRangeEnd = 1350894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ToDouble(Decimal d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600198B RID: 6539 RVA: 0x0009E7E8 File Offset: 0x0009C9E8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1350903, RefRangeEnd = 1350907, XrefRangeStart = 1350897, XrefRangeEnd = 1350903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(Decimal d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600198C RID: 6540 RVA: 0x0009E828 File Offset: 0x0009CA28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1350914, RefRangeEnd = 1350915, XrefRangeStart = 1350907, XrefRangeEnd = 1350914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToInt64(Decimal d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600198D RID: 6541 RVA: 0x0009E868 File Offset: 0x0009CA68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1350919, RefRangeEnd = 1350920, XrefRangeStart = 1350915, XrefRangeEnd = 1350919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ToUInt16(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600198E RID: 6542 RVA: 0x0009E8A8 File Offset: 0x0009CAA8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1350926, RefRangeEnd = 1350929, XrefRangeStart = 1350920, XrefRangeEnd = 1350926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(Decimal d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600198F RID: 6543 RVA: 0x0009E8E8 File Offset: 0x0009CAE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1350936, RefRangeEnd = 1350937, XrefRangeStart = 1350929, XrefRangeEnd = 1350936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ToUInt64(Decimal d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001990 RID: 6544 RVA: 0x0009E928 File Offset: 0x0009CB28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1350937, XrefRangeEnd = 1350944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToSingle(Decimal d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001991 RID: 6545 RVA: 0x0009E968 File Offset: 0x0009CB68
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1350948, RefRangeEnd = 1350954, XrefRangeStart = 1350944, XrefRangeEnd = 1350948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal Truncate(Decimal d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_Truncate_Public_Static_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001992 RID: 6546 RVA: 0x0009E9A8 File Offset: 0x0009CBA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1350954, XrefRangeEnd = 1350961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Truncate(ref Decimal d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_Truncate_Private_Static_Void_byref_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001993 RID: 6547 RVA: 0x0009E9DC File Offset: 0x0009CBDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1350961, RefRangeEnd = 1350963, XrefRangeStart = 1350961, XrefRangeEnd = 1350961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Decimal(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001994 RID: 6548 RVA: 0x0009EA1C File Offset: 0x0009CC1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1350963, RefRangeEnd = 1350964, XrefRangeStart = 1350963, XrefRangeEnd = 1350963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Decimal(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001995 RID: 6549 RVA: 0x0009EA5C File Offset: 0x0009CC5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1350964, RefRangeEnd = 1350966, XrefRangeStart = 1350964, XrefRangeEnd = 1350964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Decimal(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001996 RID: 6550 RVA: 0x0009EA9C File Offset: 0x0009CC9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1350966, RefRangeEnd = 1350968, XrefRangeStart = 1350966, XrefRangeEnd = 1350966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Decimal(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001997 RID: 6551 RVA: 0x0009EADC File Offset: 0x0009CCDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1350966, RefRangeEnd = 1350968, XrefRangeStart = 1350966, XrefRangeEnd = 1350968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Decimal(char value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x0009EB1C File Offset: 0x0009CD1C
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 1350968, RefRangeEnd = 1350988, XrefRangeStart = 1350968, XrefRangeEnd = 1350968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Decimal(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x0009EB5C File Offset: 0x0009CD5C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1350988, RefRangeEnd = 1350995, XrefRangeStart = 1350988, XrefRangeEnd = 1350988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Decimal(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x0009EB9C File Offset: 0x0009CD9C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1350995, RefRangeEnd = 1351005, XrefRangeStart = 1350995, XrefRangeEnd = 1350995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Decimal(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600199B RID: 6555 RVA: 0x0009EBDC File Offset: 0x0009CDDC
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1351005, RefRangeEnd = 1351016, XrefRangeStart = 1351005, XrefRangeEnd = 1351005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Decimal(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600199C RID: 6556 RVA: 0x0009EC1C File Offset: 0x0009CE1C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1351017, RefRangeEnd = 1351020, XrefRangeStart = 1351016, XrefRangeEnd = 1351017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator Decimal(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Explicit_Public_Static_Decimal_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600199D RID: 6557 RVA: 0x0009EC5C File Offset: 0x0009CE5C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1351021, RefRangeEnd = 1351024, XrefRangeStart = 1351020, XrefRangeEnd = 1351021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator Decimal(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Explicit_Public_Static_Decimal_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600199E RID: 6558 RVA: 0x0009EC9C File Offset: 0x0009CE9C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1351028, RefRangeEnd = 1351031, XrefRangeStart = 1351024, XrefRangeEnd = 1351028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator int(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600199F RID: 6559 RVA: 0x0009ECDC File Offset: 0x0009CEDC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1351047, RefRangeEnd = 1351054, XrefRangeStart = 1351031, XrefRangeEnd = 1351047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator long(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Explicit_Public_Static_Int64_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019A0 RID: 6560 RVA: 0x0009ED1C File Offset: 0x0009CF1C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1351070, RefRangeEnd = 1351073, XrefRangeStart = 1351054, XrefRangeEnd = 1351070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ulong(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019A1 RID: 6561 RVA: 0x0009ED5C File Offset: 0x0009CF5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1351083, RefRangeEnd = 1351084, XrefRangeStart = 1351073, XrefRangeEnd = 1351083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator float(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Explicit_Public_Static_Single_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019A2 RID: 6562 RVA: 0x0009ED9C File Offset: 0x0009CF9C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1351091, RefRangeEnd = 1351100, XrefRangeStart = 1351084, XrefRangeEnd = 1351091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator double(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Explicit_Public_Static_Double_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019A3 RID: 6563 RVA: 0x0009EDDC File Offset: 0x0009CFDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1350841, RefRangeEnd = 1350843, XrefRangeStart = 1350841, XrefRangeEnd = 1350843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal operator -(Decimal d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019A4 RID: 6564 RVA: 0x0009EE1C File Offset: 0x0009D01C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1351111, RefRangeEnd = 1351113, XrefRangeStart = 1351100, XrefRangeEnd = 1351111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal operator ++(Decimal d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Increment_Public_Static_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x0009EE5C File Offset: 0x0009D05C
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1351120, RefRangeEnd = 1351135, XrefRangeStart = 1351113, XrefRangeEnd = 1351120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal operator +(Decimal d1, Decimal d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Addition_Public_Static_Decimal_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019A6 RID: 6566 RVA: 0x0009EEA8 File Offset: 0x0009D0A8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1351142, RefRangeEnd = 1351148, XrefRangeStart = 1351135, XrefRangeEnd = 1351142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal operator -(Decimal d1, Decimal d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Subtraction_Public_Static_Decimal_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019A7 RID: 6567 RVA: 0x0009EEF4 File Offset: 0x0009D0F4
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1351155, RefRangeEnd = 1351168, XrefRangeStart = 1351148, XrefRangeEnd = 1351155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal operator *(Decimal d1, Decimal d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Multiply_Public_Static_Decimal_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019A8 RID: 6568 RVA: 0x0009EF40 File Offset: 0x0009D140
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1351175, RefRangeEnd = 1351182, XrefRangeStart = 1351168, XrefRangeEnd = 1351175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal operator /(Decimal d1, Decimal d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Division_Public_Static_Decimal_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019A9 RID: 6569 RVA: 0x0009EF8C File Offset: 0x0009D18C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1351189, RefRangeEnd = 1351202, XrefRangeStart = 1351182, XrefRangeEnd = 1351189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal operator %(Decimal d1, Decimal d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Modulus_Public_Static_Decimal_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019AA RID: 6570 RVA: 0x0009EFD8 File Offset: 0x0009D1D8
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 1351206, RefRangeEnd = 1351283, XrefRangeStart = 1351202, XrefRangeEnd = 1351206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(Decimal d1, Decimal d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019AB RID: 6571 RVA: 0x0009F024 File Offset: 0x0009D224
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 1351287, RefRangeEnd = 1351335, XrefRangeStart = 1351283, XrefRangeEnd = 1351287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(Decimal d1, Decimal d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019AC RID: 6572 RVA: 0x0009F070 File Offset: 0x0009D270
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1351339, RefRangeEnd = 1351351, XrefRangeStart = 1351335, XrefRangeEnd = 1351339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator <(Decimal d1, Decimal d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019AD RID: 6573 RVA: 0x0009F0BC File Offset: 0x0009D2BC
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1351355, RefRangeEnd = 1351370, XrefRangeStart = 1351351, XrefRangeEnd = 1351355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator <=(Decimal d1, Decimal d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019AE RID: 6574 RVA: 0x0009F108 File Offset: 0x0009D308
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 1351374, RefRangeEnd = 1351394, XrefRangeStart = 1351370, XrefRangeEnd = 1351374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator >(Decimal d1, Decimal d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019AF RID: 6575 RVA: 0x0009F154 File Offset: 0x0009D354
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1351398, RefRangeEnd = 1351401, XrefRangeStart = 1351394, XrefRangeEnd = 1351398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator >=(Decimal d1, Decimal d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x0009F1A0 File Offset: 0x0009D3A0
		[CallerCount(0)]
		public unsafe TypeCode GetTypeCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019B1 RID: 6577 RVA: 0x0009F1D0 File Offset: 0x0009D3D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1351401, XrefRangeEnd = 1351405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool System_IConvertible_ToBoolean(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x0009F214 File Offset: 0x0009D414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1351405, XrefRangeEnd = 1351414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char System_IConvertible_ToChar(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019B3 RID: 6579 RVA: 0x0009F258 File Offset: 0x0009D458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1351414, XrefRangeEnd = 1351418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe sbyte System_IConvertible_ToSByte(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019B4 RID: 6580 RVA: 0x0009F29C File Offset: 0x0009D49C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1351418, XrefRangeEnd = 1351422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe byte System_IConvertible_ToByte(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019B5 RID: 6581 RVA: 0x0009F2E0 File Offset: 0x0009D4E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1351422, XrefRangeEnd = 1351426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe short System_IConvertible_ToInt16(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019B6 RID: 6582 RVA: 0x0009F324 File Offset: 0x0009D524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1351426, XrefRangeEnd = 1351430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ushort System_IConvertible_ToUInt16(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019B7 RID: 6583 RVA: 0x0009F368 File Offset: 0x0009D568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1351430, XrefRangeEnd = 1351434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int System_IConvertible_ToInt32(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019B8 RID: 6584 RVA: 0x0009F3AC File Offset: 0x0009D5AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1351434, XrefRangeEnd = 1351438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint System_IConvertible_ToUInt32(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019B9 RID: 6585 RVA: 0x0009F3F0 File Offset: 0x0009D5F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1351438, XrefRangeEnd = 1351442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long System_IConvertible_ToInt64(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019BA RID: 6586 RVA: 0x0009F434 File Offset: 0x0009D634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1351442, XrefRangeEnd = 1351446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ulong System_IConvertible_ToUInt64(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019BB RID: 6587 RVA: 0x0009F478 File Offset: 0x0009D678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1351446, XrefRangeEnd = 1351450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float System_IConvertible_ToSingle(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x0009F4BC File Offset: 0x0009D6BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1351450, XrefRangeEnd = 1351454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double System_IConvertible_ToDouble(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x0009F500 File Offset: 0x0009D700
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 599686, RefRangeEnd = 599697, XrefRangeStart = 599686, XrefRangeEnd = 599697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Decimal System_IConvertible_ToDecimal(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019BE RID: 6590 RVA: 0x0009F544 File Offset: 0x0009D744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1351454, XrefRangeEnd = 1351463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime System_IConvertible_ToDateTime(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019BF RID: 6591 RVA: 0x0009F588 File Offset: 0x0009D788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1351463, XrefRangeEnd = 1351470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object System_IConvertible_ToType(Type type, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060019C0 RID: 6592 RVA: 0x000082BF File Offset: 0x000064BF
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Decimal>.NativeClassPtr, ref this));
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x060019C1 RID: 6593 RVA: 0x0009F5E0 File Offset: 0x0009D7E0
		// (set) Token: 0x060019C2 RID: 6594 RVA: 0x000082D1 File Offset: 0x000064D1
		public unsafe static int SignMask
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Decimal.NativeFieldInfoPtr_SignMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Decimal.NativeFieldInfoPtr_SignMask, (void*)(&value));
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x060019C3 RID: 6595 RVA: 0x0009F5FC File Offset: 0x0009D7FC
		// (set) Token: 0x060019C4 RID: 6596 RVA: 0x000082DF File Offset: 0x000064DF
		public unsafe static int ScaleMask
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Decimal.NativeFieldInfoPtr_ScaleMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Decimal.NativeFieldInfoPtr_ScaleMask, (void*)(&value));
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x060019C5 RID: 6597 RVA: 0x0009F618 File Offset: 0x0009D818
		// (set) Token: 0x060019C6 RID: 6598 RVA: 0x000082ED File Offset: 0x000064ED
		public unsafe static int ScaleShift
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Decimal.NativeFieldInfoPtr_ScaleShift, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Decimal.NativeFieldInfoPtr_ScaleShift, (void*)(&value));
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x060019C7 RID: 6599 RVA: 0x0009F634 File Offset: 0x0009D834
		// (set) Token: 0x060019C8 RID: 6600 RVA: 0x000082FB File Offset: 0x000064FB
		public unsafe static Decimal Zero
		{
			get
			{
				Decimal @decimal;
				IL2CPP.il2cpp_field_static_get_value(Decimal.NativeFieldInfoPtr_Zero, (void*)(&@decimal));
				return @decimal;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Decimal.NativeFieldInfoPtr_Zero, (void*)(&value));
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x060019C9 RID: 6601 RVA: 0x0009F650 File Offset: 0x0009D850
		// (set) Token: 0x060019CA RID: 6602 RVA: 0x00008309 File Offset: 0x00006509
		public unsafe static Decimal One
		{
			get
			{
				Decimal @decimal;
				IL2CPP.il2cpp_field_static_get_value(Decimal.NativeFieldInfoPtr_One, (void*)(&@decimal));
				return @decimal;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Decimal.NativeFieldInfoPtr_One, (void*)(&value));
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x060019CB RID: 6603 RVA: 0x0009F66C File Offset: 0x0009D86C
		// (set) Token: 0x060019CC RID: 6604 RVA: 0x00008317 File Offset: 0x00006517
		public unsafe static Decimal MinusOne
		{
			get
			{
				Decimal @decimal;
				IL2CPP.il2cpp_field_static_get_value(Decimal.NativeFieldInfoPtr_MinusOne, (void*)(&@decimal));
				return @decimal;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Decimal.NativeFieldInfoPtr_MinusOne, (void*)(&value));
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x060019CD RID: 6605 RVA: 0x0009F688 File Offset: 0x0009D888
		// (set) Token: 0x060019CE RID: 6606 RVA: 0x00008325 File Offset: 0x00006525
		public unsafe static Decimal MaxValue
		{
			get
			{
				Decimal @decimal;
				IL2CPP.il2cpp_field_static_get_value(Decimal.NativeFieldInfoPtr_MaxValue, (void*)(&@decimal));
				return @decimal;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Decimal.NativeFieldInfoPtr_MaxValue, (void*)(&value));
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x060019CF RID: 6607 RVA: 0x0009F6A4 File Offset: 0x0009D8A4
		// (set) Token: 0x060019D0 RID: 6608 RVA: 0x00008333 File Offset: 0x00006533
		public unsafe static Decimal MinValue
		{
			get
			{
				Decimal @decimal;
				IL2CPP.il2cpp_field_static_get_value(Decimal.NativeFieldInfoPtr_MinValue, (void*)(&@decimal));
				return @decimal;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Decimal.NativeFieldInfoPtr_MinValue, (void*)(&value));
			}
		}

		// Token: 0x04001780 RID: 6016
		private static readonly IntPtr NativeFieldInfoPtr_SignMask;

		// Token: 0x04001781 RID: 6017
		private static readonly IntPtr NativeFieldInfoPtr_ScaleMask;

		// Token: 0x04001782 RID: 6018
		private static readonly IntPtr NativeFieldInfoPtr_ScaleShift;

		// Token: 0x04001783 RID: 6019
		private static readonly IntPtr NativeFieldInfoPtr_Zero;

		// Token: 0x04001784 RID: 6020
		private static readonly IntPtr NativeFieldInfoPtr_One;

		// Token: 0x04001785 RID: 6021
		private static readonly IntPtr NativeFieldInfoPtr_MinusOne;

		// Token: 0x04001786 RID: 6022
		private static readonly IntPtr NativeFieldInfoPtr_MaxValue;

		// Token: 0x04001787 RID: 6023
		private static readonly IntPtr NativeFieldInfoPtr_MinValue;

		// Token: 0x04001788 RID: 6024
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x04001789 RID: 6025
		private static readonly IntPtr NativeFieldInfoPtr_hi;

		// Token: 0x0400178A RID: 6026
		private static readonly IntPtr NativeFieldInfoPtr_lo;

		// Token: 0x0400178B RID: 6027
		private static readonly IntPtr NativeFieldInfoPtr_mid;

		// Token: 0x0400178C RID: 6028
		private static readonly IntPtr NativeFieldInfoPtr_ulomidLE;

		// Token: 0x0400178D RID: 6029
		private static readonly IntPtr NativeMethodInfoPtr_get_High_Internal_get_UInt32_0;

		// Token: 0x0400178E RID: 6030
		private static readonly IntPtr NativeMethodInfoPtr_get_Low_Internal_get_UInt32_0;

		// Token: 0x0400178F RID: 6031
		private static readonly IntPtr NativeMethodInfoPtr_get_Mid_Internal_get_UInt32_0;

		// Token: 0x04001790 RID: 6032
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNegative_Internal_get_Boolean_0;

		// Token: 0x04001791 RID: 6033
		private static readonly IntPtr NativeMethodInfoPtr_get_Scale_Internal_get_Int32_0;

		// Token: 0x04001792 RID: 6034
		private static readonly IntPtr NativeMethodInfoPtr_get_Low64_Private_get_UInt64_0;

		// Token: 0x04001793 RID: 6035
		private static readonly IntPtr NativeMethodInfoPtr_AsMutable_Private_Static_byref_DecCalc_byref_Decimal_0;

		// Token: 0x04001794 RID: 6036
		private static readonly IntPtr NativeMethodInfoPtr_DecDivMod1E9_Internal_Static_UInt32_byref_Decimal_0;

		// Token: 0x04001795 RID: 6037
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001796 RID: 6038
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04001797 RID: 6039
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_0;

		// Token: 0x04001798 RID: 6040
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x04001799 RID: 6041
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x0400179A RID: 6042
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x0400179B RID: 6043
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Private_Static_Boolean_Int32_0;

		// Token: 0x0400179C RID: 6044
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Int32_0;

		// Token: 0x0400179D RID: 6045
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Boolean_Byte_0;

		// Token: 0x0400179E RID: 6046
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x0400179F RID: 6047
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_byref_Decimal_Int32_0;

		// Token: 0x040017A0 RID: 6048
		private static readonly IntPtr NativeMethodInfoPtr_Abs_Internal_Static_Decimal_byref_Decimal_0;

		// Token: 0x040017A1 RID: 6049
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Static_Decimal_Decimal_Decimal_0;

		// Token: 0x040017A2 RID: 6050
		private static readonly IntPtr NativeMethodInfoPtr_Ceiling_Public_Static_Decimal_Decimal_0;

		// Token: 0x040017A3 RID: 6051
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Int32_Decimal_Decimal_0;

		// Token: 0x040017A4 RID: 6052
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x040017A5 RID: 6053
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Decimal_0;

		// Token: 0x040017A6 RID: 6054
		private static readonly IntPtr NativeMethodInfoPtr_Divide_Public_Static_Decimal_Decimal_Decimal_0;

		// Token: 0x040017A7 RID: 6055
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040017A8 RID: 6056
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Decimal_0;

		// Token: 0x040017A9 RID: 6057
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040017AA RID: 6058
		private static readonly IntPtr NativeMethodInfoPtr_Floor_Public_Static_Decimal_Decimal_0;

		// Token: 0x040017AB RID: 6059
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040017AC RID: 6060
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0;

		// Token: 0x040017AD RID: 6061
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x040017AE RID: 6062
		private static readonly IntPtr NativeMethodInfoPtr_TryFormat_Public_Virtual_Final_New_Boolean_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_IFormatProvider_0;

		// Token: 0x040017AF RID: 6063
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_Decimal_String_0;

		// Token: 0x040017B0 RID: 6064
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_Decimal_String_IFormatProvider_0;

		// Token: 0x040017B1 RID: 6065
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_Decimal_String_NumberStyles_IFormatProvider_0;

		// Token: 0x040017B2 RID: 6066
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_NumberStyles_IFormatProvider_byref_Decimal_0;

		// Token: 0x040017B3 RID: 6067
		private static readonly IntPtr NativeMethodInfoPtr_GetBits_Public_Static_Il2CppStructArray_1_Int32_Decimal_0;

		// Token: 0x040017B4 RID: 6068
		private static readonly IntPtr NativeMethodInfoPtr_Max_Internal_Static_byref_Decimal_byref_Decimal_byref_Decimal_0;

		// Token: 0x040017B5 RID: 6069
		private static readonly IntPtr NativeMethodInfoPtr_Min_Internal_Static_byref_Decimal_byref_Decimal_byref_Decimal_0;

		// Token: 0x040017B6 RID: 6070
		private static readonly IntPtr NativeMethodInfoPtr_Multiply_Public_Static_Decimal_Decimal_Decimal_0;

		// Token: 0x040017B7 RID: 6071
		private static readonly IntPtr NativeMethodInfoPtr_Negate_Public_Static_Decimal_Decimal_0;

		// Token: 0x040017B8 RID: 6072
		private static readonly IntPtr NativeMethodInfoPtr_Round_Public_Static_Decimal_Decimal_Int32_0;

		// Token: 0x040017B9 RID: 6073
		private static readonly IntPtr NativeMethodInfoPtr_Round_Private_Static_Decimal_byref_Decimal_Int32_MidpointRounding_0;

		// Token: 0x040017BA RID: 6074
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_Decimal_0;

		// Token: 0x040017BB RID: 6075
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Decimal_0;

		// Token: 0x040017BC RID: 6076
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Decimal_0;

		// Token: 0x040017BD RID: 6077
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_Decimal_0;

		// Token: 0x040017BE RID: 6078
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Decimal_0;

		// Token: 0x040017BF RID: 6079
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Decimal_0;

		// Token: 0x040017C0 RID: 6080
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Decimal_0;

		// Token: 0x040017C1 RID: 6081
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Decimal_0;

		// Token: 0x040017C2 RID: 6082
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Decimal_0;

		// Token: 0x040017C3 RID: 6083
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_Decimal_0;

		// Token: 0x040017C4 RID: 6084
		private static readonly IntPtr NativeMethodInfoPtr_Truncate_Public_Static_Decimal_Decimal_0;

		// Token: 0x040017C5 RID: 6085
		private static readonly IntPtr NativeMethodInfoPtr_Truncate_Private_Static_Void_byref_Decimal_0;

		// Token: 0x040017C6 RID: 6086
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_Byte_0;

		// Token: 0x040017C7 RID: 6087
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_SByte_0;

		// Token: 0x040017C8 RID: 6088
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_Int16_0;

		// Token: 0x040017C9 RID: 6089
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_UInt16_0;

		// Token: 0x040017CA RID: 6090
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_Char_0;

		// Token: 0x040017CB RID: 6091
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_Int32_0;

		// Token: 0x040017CC RID: 6092
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_UInt32_0;

		// Token: 0x040017CD RID: 6093
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_Int64_0;

		// Token: 0x040017CE RID: 6094
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_UInt64_0;

		// Token: 0x040017CF RID: 6095
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Decimal_Single_0;

		// Token: 0x040017D0 RID: 6096
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Decimal_Double_0;

		// Token: 0x040017D1 RID: 6097
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_Decimal_0;

		// Token: 0x040017D2 RID: 6098
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Int64_Decimal_0;

		// Token: 0x040017D3 RID: 6099
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_Decimal_0;

		// Token: 0x040017D4 RID: 6100
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Single_Decimal_0;

		// Token: 0x040017D5 RID: 6101
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Double_Decimal_0;

		// Token: 0x040017D6 RID: 6102
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Decimal_Decimal_0;

		// Token: 0x040017D7 RID: 6103
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_Decimal_Decimal_0;

		// Token: 0x040017D8 RID: 6104
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Decimal_Decimal_Decimal_0;

		// Token: 0x040017D9 RID: 6105
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Decimal_Decimal_Decimal_0;

		// Token: 0x040017DA RID: 6106
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Decimal_Decimal_Decimal_0;

		// Token: 0x040017DB RID: 6107
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_Decimal_Decimal_Decimal_0;

		// Token: 0x040017DC RID: 6108
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_Decimal_Decimal_Decimal_0;

		// Token: 0x040017DD RID: 6109
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Decimal_Decimal_0;

		// Token: 0x040017DE RID: 6110
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Decimal_Decimal_0;

		// Token: 0x040017DF RID: 6111
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Decimal_Decimal_0;

		// Token: 0x040017E0 RID: 6112
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_Decimal_Decimal_0;

		// Token: 0x040017E1 RID: 6113
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_Decimal_Decimal_0;

		// Token: 0x040017E2 RID: 6114
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_Decimal_Decimal_0;

		// Token: 0x040017E3 RID: 6115
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0;

		// Token: 0x040017E4 RID: 6116
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0;

		// Token: 0x040017E5 RID: 6117
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0;

		// Token: 0x040017E6 RID: 6118
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0;

		// Token: 0x040017E7 RID: 6119
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0;

		// Token: 0x040017E8 RID: 6120
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0;

		// Token: 0x040017E9 RID: 6121
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0;

		// Token: 0x040017EA RID: 6122
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0;

		// Token: 0x040017EB RID: 6123
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0;

		// Token: 0x040017EC RID: 6124
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0;

		// Token: 0x040017ED RID: 6125
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0;

		// Token: 0x040017EE RID: 6126
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0;

		// Token: 0x040017EF RID: 6127
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0;

		// Token: 0x040017F0 RID: 6128
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0;

		// Token: 0x040017F1 RID: 6129
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0;

		// Token: 0x040017F2 RID: 6130
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0;

		// Token: 0x040017F3 RID: 6131
		[FieldOffset(0)]
		public readonly int flags;

		// Token: 0x040017F4 RID: 6132
		[FieldOffset(4)]
		public readonly int hi;

		// Token: 0x040017F5 RID: 6133
		[FieldOffset(8)]
		public readonly int lo;

		// Token: 0x040017F6 RID: 6134
		[FieldOffset(12)]
		public readonly int mid;

		// Token: 0x040017F7 RID: 6135
		[NonSerialized]
		[FieldOffset(8)]
		public readonly ulong ulomidLE;

		// Token: 0x020005FB RID: 1531
		[StructLayout(2)]
		public struct DecCalc
		{
			// Token: 0x060057E2 RID: 22498 RVA: 0x001948F8 File Offset: 0x00192AF8
			// Note: this type is marked as 'beforefieldinit'.
			static DecCalc()
			{
				Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Decimal>.NativeClassPtr, "DecCalc");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr);
				Decimal.DecCalc.NativeFieldInfoPtr_uflags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, "uflags");
				Decimal.DecCalc.NativeFieldInfoPtr_uhi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, "uhi");
				Decimal.DecCalc.NativeFieldInfoPtr_ulo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, "ulo");
				Decimal.DecCalc.NativeFieldInfoPtr_umid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, "umid");
				Decimal.DecCalc.NativeFieldInfoPtr_ulomidLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, "ulomidLE");
				Decimal.DecCalc.NativeFieldInfoPtr_s_powers10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, "s_powers10");
				Decimal.DecCalc.NativeFieldInfoPtr_s_ulongPowers10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, "s_ulongPowers10");
				Decimal.DecCalc.NativeFieldInfoPtr_s_doublePowers10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, "s_doublePowers10");
				Decimal.DecCalc.NativeFieldInfoPtr_PowerOvflValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, "PowerOvflValues");
				Decimal.DecCalc.NativeMethodInfoPtr_get_High_Private_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, 100667766);
				Decimal.DecCalc.NativeMethodInfoPtr_set_High_Private_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, 100667767);
				Decimal.DecCalc.NativeMethodInfoPtr_get_Low_Private_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, 100667768);
				Decimal.DecCalc.NativeMethodInfoPtr_set_Low_Private_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, 100667769);
				Decimal.DecCalc.NativeMethodInfoPtr_get_Mid_Private_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, 100667770);
				Decimal.DecCalc.NativeMethodInfoPtr_set_Mid_Private_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, 100667771);
				Decimal.DecCalc.NativeMethodInfoPtr_get_IsNegative_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, 100667772);
				Decimal.DecCalc.NativeMethodInfoPtr_get_Low64_Private_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, 100667773);
				Decimal.DecCalc.NativeMethodInfoPtr_set_Low64_Private_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, 100667774);
				Decimal.DecCalc.NativeMethodInfoPtr_GetExponent_Private_Static_UInt32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, 100667775);
				Decimal.DecCalc.NativeMethodInfoPtr_GetExponent_Private_Static_UInt32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, 100667776);
				Decimal.DecCalc.NativeMethodInfoPtr_UInt32x32To64_Private_Static_UInt64_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, 100667777);
				Decimal.DecCalc.NativeMethodInfoPtr_UInt64x64To128_Private_Static_Void_UInt64_UInt64_byref_DecCalc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, 100667778);
				Decimal.DecCalc.NativeMethodInfoPtr_Div96By32_Private_Static_UInt32_byref_Buf12_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, 100667779);
				Decimal.DecCalc.NativeMethodInfoPtr_Div96ByConst_Private_Static_Boolean_byref_UInt64_byref_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, 100667780);
				Decimal.DecCalc.NativeMethodInfoPtr_Unscale_Private_Static_Void_byref_UInt32_byref_UInt64_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, 100667781);
				Decimal.DecCalc.NativeMethodInfoPtr_Div96By64_Private_Static_UInt32_byref_Buf12_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, 100667782);
				Decimal.DecCalc.NativeMethodInfoPtr_Div128By96_Private_Static_UInt32_byref_Buf16_byref_Buf12_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, 100667783);
				Decimal.DecCalc.NativeMethodInfoPtr_IncreaseScale_Private_Static_UInt32_byref_Buf12_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, 100667784);
				Decimal.DecCalc.NativeMethodInfoPtr_IncreaseScale64_Private_Static_Void_byref_Buf12_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, 100667785);
				Decimal.DecCalc.NativeMethodInfoPtr_ScaleResult_Private_Static_Int32_ptr_Buf24_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, 100667786);
				Decimal.DecCalc.NativeMethodInfoPtr_DivByConst_Private_Static_UInt32_ptr_UInt32_UInt32_byref_UInt32_byref_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, 100667787);
				Decimal.DecCalc.NativeMethodInfoPtr_LeadingZeroCount_Private_Static_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, 100667788);
				Decimal.DecCalc.NativeMethodInfoPtr_OverflowUnscale_Private_Static_Int32_byref_Buf12_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, 100667789);
				Decimal.DecCalc.NativeMethodInfoPtr_SearchScale_Private_Static_Int32_byref_Buf12_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, 100667790);
				Decimal.DecCalc.NativeMethodInfoPtr_Add32To96_Private_Static_Boolean_byref_Buf12_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, 100667791);
				Decimal.DecCalc.NativeMethodInfoPtr_DecAddSub_Internal_Static_Void_byref_DecCalc_byref_DecCalc_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, 100667792);
				Decimal.DecCalc.NativeMethodInfoPtr_VarDecCmp_Internal_Static_Int32_byref_Decimal_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, 100667793);
				Decimal.DecCalc.NativeMethodInfoPtr_VarDecCmpSub_Private_Static_Int32_byref_Decimal_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, 100667794);
				Decimal.DecCalc.NativeMethodInfoPtr_VarDecMul_Internal_Static_Void_byref_DecCalc_byref_DecCalc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, 100667795);
				Decimal.DecCalc.NativeMethodInfoPtr_VarDecFromR4_Internal_Static_Void_Single_byref_DecCalc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, 100667796);
				Decimal.DecCalc.NativeMethodInfoPtr_VarDecFromR8_Internal_Static_Void_Double_byref_DecCalc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, 100667797);
				Decimal.DecCalc.NativeMethodInfoPtr_VarR4FromDec_Internal_Static_Single_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, 100667798);
				Decimal.DecCalc.NativeMethodInfoPtr_VarR8FromDec_Internal_Static_Double_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, 100667799);
				Decimal.DecCalc.NativeMethodInfoPtr_GetHashCode_Internal_Static_Int32_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, 100667800);
				Decimal.DecCalc.NativeMethodInfoPtr_VarDecDiv_Internal_Static_Void_byref_DecCalc_byref_DecCalc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, 100667801);
				Decimal.DecCalc.NativeMethodInfoPtr_VarDecMod_Internal_Static_Void_byref_DecCalc_byref_DecCalc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, 100667802);
				Decimal.DecCalc.NativeMethodInfoPtr_VarDecModFull_Private_Static_Void_byref_DecCalc_byref_DecCalc_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, 100667803);
				Decimal.DecCalc.NativeMethodInfoPtr_InternalRound_Internal_Static_Void_byref_DecCalc_UInt32_RoundingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, 100667804);
				Decimal.DecCalc.NativeMethodInfoPtr_DecDivMod1E9_Internal_Static_UInt32_byref_DecCalc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, 100667805);
			}

			// Token: 0x17001670 RID: 5744
			// (get) Token: 0x060057E3 RID: 22499 RVA: 0x00194CF8 File Offset: 0x00192EF8
			// (set) Token: 0x060057E4 RID: 22500 RVA: 0x00194D28 File Offset: 0x00192F28
			public unsafe uint High
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.NativeMethodInfoPtr_get_High_Private_get_UInt32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(6)]
				[CachedScanResults(RefRangeStart = 320170, RefRangeEnd = 320176, XrefRangeStart = 320170, XrefRangeEnd = 320176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.NativeMethodInfoPtr_set_High_Private_set_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001671 RID: 5745
			// (get) Token: 0x060057E5 RID: 22501 RVA: 0x00194D5C File Offset: 0x00192F5C
			// (set) Token: 0x060057E6 RID: 22502 RVA: 0x00194D8C File Offset: 0x00192F8C
			public unsafe uint Low
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.NativeMethodInfoPtr_get_Low_Private_get_UInt32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(8)]
				[CachedScanResults(RefRangeStart = 310301, RefRangeEnd = 310309, XrefRangeStart = 310301, XrefRangeEnd = 310309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.NativeMethodInfoPtr_set_Low_Private_set_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001672 RID: 5746
			// (get) Token: 0x060057E7 RID: 22503 RVA: 0x00194DC0 File Offset: 0x00192FC0
			// (set) Token: 0x060057E8 RID: 22504 RVA: 0x00194DF0 File Offset: 0x00192FF0
			public unsafe uint Mid
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.NativeMethodInfoPtr_get_Mid_Private_get_UInt32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 310309, RefRangeEnd = 310312, XrefRangeStart = 310309, XrefRangeEnd = 310312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.NativeMethodInfoPtr_set_Mid_Private_set_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001673 RID: 5747
			// (get) Token: 0x060057E9 RID: 22505 RVA: 0x00194E24 File Offset: 0x00193024
			public unsafe bool IsNegative
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 1350100, RefRangeEnd = 1350101, XrefRangeStart = 1350100, XrefRangeEnd = 1350100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.NativeMethodInfoPtr_get_IsNegative_Private_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001674 RID: 5748
			// (get) Token: 0x060057EA RID: 22506 RVA: 0x00194E54 File Offset: 0x00193054
			// (set) Token: 0x060057EB RID: 22507 RVA: 0x00194E84 File Offset: 0x00193084
			public unsafe ulong Low64
			{
				[CallerCount(13)]
				[CachedScanResults(RefRangeStart = 323759, RefRangeEnd = 323772, XrefRangeStart = 323759, XrefRangeEnd = 323772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.NativeMethodInfoPtr_get_Low64_Private_get_UInt64_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.NativeMethodInfoPtr_set_Low64_Private_set_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060057EC RID: 22508 RVA: 0x00194EB8 File Offset: 0x001930B8
			[CallerCount(0)]
			public unsafe static uint GetExponent(float f)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref f;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.NativeMethodInfoPtr_GetExponent_Private_Static_UInt32_Single_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060057ED RID: 22509 RVA: 0x00194EF8 File Offset: 0x001930F8
			[CallerCount(0)]
			public unsafe static uint GetExponent(double d)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref d;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.NativeMethodInfoPtr_GetExponent_Private_Static_UInt32_Double_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060057EE RID: 22510 RVA: 0x00194F38 File Offset: 0x00193138
			[CallerCount(0)]
			public unsafe static ulong UInt32x32To64(uint a, uint b)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.NativeMethodInfoPtr_UInt32x32To64_Private_Static_UInt64_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060057EF RID: 22511 RVA: 0x00194F84 File Offset: 0x00193184
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1350108, RefRangeEnd = 1350110, XrefRangeStart = 1350101, XrefRangeEnd = 1350108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void UInt64x64To128(ulong a, ulong b, ref Decimal.DecCalc result)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.NativeMethodInfoPtr_UInt64x64To128_Private_Static_Void_UInt64_UInt64_byref_DecCalc_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060057F0 RID: 22512 RVA: 0x00194FD4 File Offset: 0x001931D4
			[CallerCount(0)]
			public unsafe static uint Div96By32(ref Decimal.DecCalc.Buf12 bufNum, uint den)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &bufNum;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref den;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.NativeMethodInfoPtr_Div96By32_Private_Static_UInt32_byref_Buf12_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060057F1 RID: 22513 RVA: 0x00195020 File Offset: 0x00193220
			[CallerCount(0)]
			public unsafe static bool Div96ByConst(ref ulong high64, ref uint low, uint pow)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &high64;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &low;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pow;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.NativeMethodInfoPtr_Div96ByConst_Private_Static_Boolean_byref_UInt64_byref_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060057F2 RID: 22514 RVA: 0x0019507C File Offset: 0x0019327C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1350110, XrefRangeEnd = 1350119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Unscale(ref uint low, ref ulong high64, ref int scale)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &low;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &high64;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &scale;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.NativeMethodInfoPtr_Unscale_Private_Static_Void_byref_UInt32_byref_UInt64_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060057F3 RID: 22515 RVA: 0x001950CC File Offset: 0x001932CC
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1350122, RefRangeEnd = 1350129, XrefRangeStart = 1350119, XrefRangeEnd = 1350122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static uint Div96By64(ref Decimal.DecCalc.Buf12 bufNum, ulong den)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &bufNum;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref den;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.NativeMethodInfoPtr_Div96By64_Private_Static_UInt32_byref_Buf12_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060057F4 RID: 22516 RVA: 0x00195118 File Offset: 0x00193318
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1350133, RefRangeEnd = 1350138, XrefRangeStart = 1350129, XrefRangeEnd = 1350133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static uint Div128By96(ref Decimal.DecCalc.Buf16 bufNum, ref Decimal.DecCalc.Buf12 bufDen)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &bufNum;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bufDen;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.NativeMethodInfoPtr_Div128By96_Private_Static_UInt32_byref_Buf16_byref_Buf12_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060057F5 RID: 22517 RVA: 0x00195164 File Offset: 0x00193364
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1350138, XrefRangeEnd = 1350141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static uint IncreaseScale(ref Decimal.DecCalc.Buf12 bufNum, uint power)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &bufNum;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref power;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.NativeMethodInfoPtr_IncreaseScale_Private_Static_UInt32_byref_Buf12_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060057F6 RID: 22518 RVA: 0x001951B0 File Offset: 0x001933B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1350141, XrefRangeEnd = 1350144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void IncreaseScale64(ref Decimal.DecCalc.Buf12 bufNum, uint power)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &bufNum;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref power;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.NativeMethodInfoPtr_IncreaseScale64_Private_Static_Void_byref_Buf12_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060057F7 RID: 22519 RVA: 0x001951F0 File Offset: 0x001933F0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1350169, RefRangeEnd = 1350171, XrefRangeStart = 1350144, XrefRangeEnd = 1350169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int ScaleResult(Decimal.DecCalc.Buf24* bufRes, uint hiRes, int scale)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = bufRes;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hiRes;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.NativeMethodInfoPtr_ScaleResult_Private_Static_Int32_ptr_Buf24_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060057F8 RID: 22520 RVA: 0x00195248 File Offset: 0x00193448
			[CallerCount(0)]
			public unsafe static uint DivByConst(uint* result, uint hiRes, out uint quotient, out uint remainder, uint power)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = result;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hiRes;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &quotient;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &remainder;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref power;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.NativeMethodInfoPtr_DivByConst_Private_Static_UInt32_ptr_UInt32_UInt32_byref_UInt32_byref_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060057F9 RID: 22521 RVA: 0x001952BC File Offset: 0x001934BC
			[CallerCount(0)]
			public unsafe static int LeadingZeroCount(uint value)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.NativeMethodInfoPtr_LeadingZeroCount_Private_Static_Int32_UInt32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060057FA RID: 22522 RVA: 0x001952FC File Offset: 0x001934FC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1350174, RefRangeEnd = 1350175, XrefRangeStart = 1350171, XrefRangeEnd = 1350174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int OverflowUnscale(ref Decimal.DecCalc.Buf12 bufQuo, int scale, bool sticky)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &bufQuo;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sticky;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.NativeMethodInfoPtr_OverflowUnscale_Private_Static_Int32_byref_Buf12_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060057FB RID: 22523 RVA: 0x00195358 File Offset: 0x00193558
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1350179, RefRangeEnd = 1350182, XrefRangeStart = 1350175, XrefRangeEnd = 1350179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int SearchScale(ref Decimal.DecCalc.Buf12 bufQuo, int scale)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &bufQuo;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.NativeMethodInfoPtr_SearchScale_Private_Static_Int32_byref_Buf12_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060057FC RID: 22524 RVA: 0x001953A4 File Offset: 0x001935A4
			[CallerCount(0)]
			public unsafe static bool Add32To96(ref Decimal.DecCalc.Buf12 bufNum, uint value)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &bufNum;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.NativeMethodInfoPtr_Add32To96_Private_Static_Boolean_byref_Buf12_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060057FD RID: 22525 RVA: 0x001953F0 File Offset: 0x001935F0
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1350219, RefRangeEnd = 1350223, XrefRangeStart = 1350182, XrefRangeEnd = 1350219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void DecAddSub(ref Decimal.DecCalc d1, ref Decimal.DecCalc d2, bool sign)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &d1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &d2;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sign;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.NativeMethodInfoPtr_DecAddSub_Internal_Static_Void_byref_DecCalc_byref_DecCalc_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060057FE RID: 22526 RVA: 0x00195440 File Offset: 0x00193640
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 1350232, RefRangeEnd = 1350245, XrefRangeStart = 1350223, XrefRangeEnd = 1350232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int VarDecCmp([In] ref Decimal d1, [In] ref Decimal d2)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &d1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &d2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.NativeMethodInfoPtr_VarDecCmp_Internal_Static_Int32_byref_Decimal_byref_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060057FF RID: 22527 RVA: 0x0019548C File Offset: 0x0019368C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1350259, RefRangeEnd = 1350261, XrefRangeStart = 1350245, XrefRangeEnd = 1350259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int VarDecCmpSub([In] ref Decimal d1, [In] ref Decimal d2)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &d1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &d2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.NativeMethodInfoPtr_VarDecCmpSub_Private_Static_Int32_byref_Decimal_byref_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005800 RID: 22528 RVA: 0x001954D8 File Offset: 0x001936D8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1350307, RefRangeEnd = 1350309, XrefRangeStart = 1350261, XrefRangeEnd = 1350307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void VarDecMul(ref Decimal.DecCalc d1, ref Decimal.DecCalc d2)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &d1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &d2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.NativeMethodInfoPtr_VarDecMul_Internal_Static_Void_byref_DecCalc_byref_DecCalc_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005801 RID: 22529 RVA: 0x00195518 File Offset: 0x00193718
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1350330, RefRangeEnd = 1350331, XrefRangeStart = 1350309, XrefRangeEnd = 1350330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void VarDecFromR4(float input, out Decimal.DecCalc result)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref input;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.NativeMethodInfoPtr_VarDecFromR4_Internal_Static_Void_Single_byref_DecCalc_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005802 RID: 22530 RVA: 0x00195558 File Offset: 0x00193758
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1350349, RefRangeEnd = 1350350, XrefRangeStart = 1350331, XrefRangeEnd = 1350349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void VarDecFromR8(double input, out Decimal.DecCalc result)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref input;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.NativeMethodInfoPtr_VarDecFromR8_Internal_Static_Void_Double_byref_DecCalc_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005803 RID: 22531 RVA: 0x00195598 File Offset: 0x00193798
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1350350, XrefRangeEnd = 1350354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static float VarR4FromDec([In] ref Decimal value)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.NativeMethodInfoPtr_VarR4FromDec_Internal_Static_Single_byref_Decimal_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005804 RID: 22532 RVA: 0x001955D8 File Offset: 0x001937D8
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1350363, RefRangeEnd = 1350368, XrefRangeStart = 1350354, XrefRangeEnd = 1350363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static double VarR8FromDec([In] ref Decimal value)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.NativeMethodInfoPtr_VarR8FromDec_Internal_Static_Double_byref_Decimal_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005805 RID: 22533 RVA: 0x00195618 File Offset: 0x00193818
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1350368, XrefRangeEnd = 1350379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int GetHashCode([In] ref Decimal d)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &d;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.NativeMethodInfoPtr_GetHashCode_Internal_Static_Int32_byref_Decimal_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005806 RID: 22534 RVA: 0x00195658 File Offset: 0x00193858
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1350431, RefRangeEnd = 1350433, XrefRangeStart = 1350379, XrefRangeEnd = 1350431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void VarDecDiv(ref Decimal.DecCalc d1, ref Decimal.DecCalc d2)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &d1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &d2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.NativeMethodInfoPtr_VarDecDiv_Internal_Static_Void_byref_DecCalc_byref_DecCalc_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005807 RID: 22535 RVA: 0x00195698 File Offset: 0x00193898
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1350461, RefRangeEnd = 1350462, XrefRangeStart = 1350433, XrefRangeEnd = 1350461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void VarDecMod(ref Decimal.DecCalc d1, ref Decimal.DecCalc d2)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &d1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &d2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.NativeMethodInfoPtr_VarDecMod_Internal_Static_Void_byref_DecCalc_byref_DecCalc_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005808 RID: 22536 RVA: 0x001956D8 File Offset: 0x001938D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1350462, XrefRangeEnd = 1350508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void VarDecModFull(ref Decimal.DecCalc d1, ref Decimal.DecCalc d2, int scale)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &d1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &d2;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.NativeMethodInfoPtr_VarDecModFull_Private_Static_Void_byref_DecCalc_byref_DecCalc_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005809 RID: 22537 RVA: 0x00195728 File Offset: 0x00193928
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1350525, RefRangeEnd = 1350532, XrefRangeStart = 1350508, XrefRangeEnd = 1350525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void InternalRound(ref Decimal.DecCalc d, uint scale, Decimal.DecCalc.RoundingMode mode)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &d;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.NativeMethodInfoPtr_InternalRound_Internal_Static_Void_byref_DecCalc_UInt32_RoundingMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600580A RID: 22538 RVA: 0x00195778 File Offset: 0x00193978
			[CallerCount(0)]
			public unsafe static uint DecDivMod1E9(ref Decimal.DecCalc value)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.NativeMethodInfoPtr_DecDivMod1E9_Internal_Static_UInt32_byref_DecCalc_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600580B RID: 22539 RVA: 0x0001F44A File Offset: 0x0001D64A
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, ref this));
			}

			// Token: 0x1700166C RID: 5740
			// (get) Token: 0x0600580C RID: 22540 RVA: 0x001957B8 File Offset: 0x001939B8
			// (set) Token: 0x0600580D RID: 22541 RVA: 0x0001F45C File Offset: 0x0001D65C
			public unsafe static Il2CppStructArray<uint> s_powers10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Decimal.DecCalc.NativeFieldInfoPtr_s_powers10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Decimal.DecCalc.NativeFieldInfoPtr_s_powers10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700166D RID: 5741
			// (get) Token: 0x0600580E RID: 22542 RVA: 0x001957E0 File Offset: 0x001939E0
			// (set) Token: 0x0600580F RID: 22543 RVA: 0x0001F46E File Offset: 0x0001D66E
			public unsafe static Il2CppStructArray<ulong> s_ulongPowers10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Decimal.DecCalc.NativeFieldInfoPtr_s_ulongPowers10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ulong>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Decimal.DecCalc.NativeFieldInfoPtr_s_ulongPowers10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700166E RID: 5742
			// (get) Token: 0x06005810 RID: 22544 RVA: 0x00195808 File Offset: 0x00193A08
			// (set) Token: 0x06005811 RID: 22545 RVA: 0x0001F480 File Offset: 0x0001D680
			public unsafe static Il2CppStructArray<double> s_doublePowers10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Decimal.DecCalc.NativeFieldInfoPtr_s_doublePowers10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<double>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Decimal.DecCalc.NativeFieldInfoPtr_s_doublePowers10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700166F RID: 5743
			// (get) Token: 0x06005812 RID: 22546 RVA: 0x00195830 File Offset: 0x00193A30
			// (set) Token: 0x06005813 RID: 22547 RVA: 0x0001F492 File Offset: 0x0001D692
			public unsafe static Il2CppStructArray<Decimal.DecCalc.PowerOvfl> PowerOvflValues
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Decimal.DecCalc.NativeFieldInfoPtr_PowerOvflValues, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Decimal.DecCalc.PowerOvfl>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Decimal.DecCalc.NativeFieldInfoPtr_PowerOvflValues, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400484C RID: 18508
			private static readonly IntPtr NativeFieldInfoPtr_uflags;

			// Token: 0x0400484D RID: 18509
			private static readonly IntPtr NativeFieldInfoPtr_uhi;

			// Token: 0x0400484E RID: 18510
			private static readonly IntPtr NativeFieldInfoPtr_ulo;

			// Token: 0x0400484F RID: 18511
			private static readonly IntPtr NativeFieldInfoPtr_umid;

			// Token: 0x04004850 RID: 18512
			private static readonly IntPtr NativeFieldInfoPtr_ulomidLE;

			// Token: 0x04004851 RID: 18513
			private static readonly IntPtr NativeFieldInfoPtr_s_powers10;

			// Token: 0x04004852 RID: 18514
			private static readonly IntPtr NativeFieldInfoPtr_s_ulongPowers10;

			// Token: 0x04004853 RID: 18515
			private static readonly IntPtr NativeFieldInfoPtr_s_doublePowers10;

			// Token: 0x04004854 RID: 18516
			private static readonly IntPtr NativeFieldInfoPtr_PowerOvflValues;

			// Token: 0x04004855 RID: 18517
			private static readonly IntPtr NativeMethodInfoPtr_get_High_Private_get_UInt32_0;

			// Token: 0x04004856 RID: 18518
			private static readonly IntPtr NativeMethodInfoPtr_set_High_Private_set_Void_UInt32_0;

			// Token: 0x04004857 RID: 18519
			private static readonly IntPtr NativeMethodInfoPtr_get_Low_Private_get_UInt32_0;

			// Token: 0x04004858 RID: 18520
			private static readonly IntPtr NativeMethodInfoPtr_set_Low_Private_set_Void_UInt32_0;

			// Token: 0x04004859 RID: 18521
			private static readonly IntPtr NativeMethodInfoPtr_get_Mid_Private_get_UInt32_0;

			// Token: 0x0400485A RID: 18522
			private static readonly IntPtr NativeMethodInfoPtr_set_Mid_Private_set_Void_UInt32_0;

			// Token: 0x0400485B RID: 18523
			private static readonly IntPtr NativeMethodInfoPtr_get_IsNegative_Private_get_Boolean_0;

			// Token: 0x0400485C RID: 18524
			private static readonly IntPtr NativeMethodInfoPtr_get_Low64_Private_get_UInt64_0;

			// Token: 0x0400485D RID: 18525
			private static readonly IntPtr NativeMethodInfoPtr_set_Low64_Private_set_Void_UInt64_0;

			// Token: 0x0400485E RID: 18526
			private static readonly IntPtr NativeMethodInfoPtr_GetExponent_Private_Static_UInt32_Single_0;

			// Token: 0x0400485F RID: 18527
			private static readonly IntPtr NativeMethodInfoPtr_GetExponent_Private_Static_UInt32_Double_0;

			// Token: 0x04004860 RID: 18528
			private static readonly IntPtr NativeMethodInfoPtr_UInt32x32To64_Private_Static_UInt64_UInt32_UInt32_0;

			// Token: 0x04004861 RID: 18529
			private static readonly IntPtr NativeMethodInfoPtr_UInt64x64To128_Private_Static_Void_UInt64_UInt64_byref_DecCalc_0;

			// Token: 0x04004862 RID: 18530
			private static readonly IntPtr NativeMethodInfoPtr_Div96By32_Private_Static_UInt32_byref_Buf12_UInt32_0;

			// Token: 0x04004863 RID: 18531
			private static readonly IntPtr NativeMethodInfoPtr_Div96ByConst_Private_Static_Boolean_byref_UInt64_byref_UInt32_UInt32_0;

			// Token: 0x04004864 RID: 18532
			private static readonly IntPtr NativeMethodInfoPtr_Unscale_Private_Static_Void_byref_UInt32_byref_UInt64_byref_Int32_0;

			// Token: 0x04004865 RID: 18533
			private static readonly IntPtr NativeMethodInfoPtr_Div96By64_Private_Static_UInt32_byref_Buf12_UInt64_0;

			// Token: 0x04004866 RID: 18534
			private static readonly IntPtr NativeMethodInfoPtr_Div128By96_Private_Static_UInt32_byref_Buf16_byref_Buf12_0;

			// Token: 0x04004867 RID: 18535
			private static readonly IntPtr NativeMethodInfoPtr_IncreaseScale_Private_Static_UInt32_byref_Buf12_UInt32_0;

			// Token: 0x04004868 RID: 18536
			private static readonly IntPtr NativeMethodInfoPtr_IncreaseScale64_Private_Static_Void_byref_Buf12_UInt32_0;

			// Token: 0x04004869 RID: 18537
			private static readonly IntPtr NativeMethodInfoPtr_ScaleResult_Private_Static_Int32_ptr_Buf24_UInt32_Int32_0;

			// Token: 0x0400486A RID: 18538
			private static readonly IntPtr NativeMethodInfoPtr_DivByConst_Private_Static_UInt32_ptr_UInt32_UInt32_byref_UInt32_byref_UInt32_UInt32_0;

			// Token: 0x0400486B RID: 18539
			private static readonly IntPtr NativeMethodInfoPtr_LeadingZeroCount_Private_Static_Int32_UInt32_0;

			// Token: 0x0400486C RID: 18540
			private static readonly IntPtr NativeMethodInfoPtr_OverflowUnscale_Private_Static_Int32_byref_Buf12_Int32_Boolean_0;

			// Token: 0x0400486D RID: 18541
			private static readonly IntPtr NativeMethodInfoPtr_SearchScale_Private_Static_Int32_byref_Buf12_Int32_0;

			// Token: 0x0400486E RID: 18542
			private static readonly IntPtr NativeMethodInfoPtr_Add32To96_Private_Static_Boolean_byref_Buf12_UInt32_0;

			// Token: 0x0400486F RID: 18543
			private static readonly IntPtr NativeMethodInfoPtr_DecAddSub_Internal_Static_Void_byref_DecCalc_byref_DecCalc_Boolean_0;

			// Token: 0x04004870 RID: 18544
			private static readonly IntPtr NativeMethodInfoPtr_VarDecCmp_Internal_Static_Int32_byref_Decimal_byref_Decimal_0;

			// Token: 0x04004871 RID: 18545
			private static readonly IntPtr NativeMethodInfoPtr_VarDecCmpSub_Private_Static_Int32_byref_Decimal_byref_Decimal_0;

			// Token: 0x04004872 RID: 18546
			private static readonly IntPtr NativeMethodInfoPtr_VarDecMul_Internal_Static_Void_byref_DecCalc_byref_DecCalc_0;

			// Token: 0x04004873 RID: 18547
			private static readonly IntPtr NativeMethodInfoPtr_VarDecFromR4_Internal_Static_Void_Single_byref_DecCalc_0;

			// Token: 0x04004874 RID: 18548
			private static readonly IntPtr NativeMethodInfoPtr_VarDecFromR8_Internal_Static_Void_Double_byref_DecCalc_0;

			// Token: 0x04004875 RID: 18549
			private static readonly IntPtr NativeMethodInfoPtr_VarR4FromDec_Internal_Static_Single_byref_Decimal_0;

			// Token: 0x04004876 RID: 18550
			private static readonly IntPtr NativeMethodInfoPtr_VarR8FromDec_Internal_Static_Double_byref_Decimal_0;

			// Token: 0x04004877 RID: 18551
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Internal_Static_Int32_byref_Decimal_0;

			// Token: 0x04004878 RID: 18552
			private static readonly IntPtr NativeMethodInfoPtr_VarDecDiv_Internal_Static_Void_byref_DecCalc_byref_DecCalc_0;

			// Token: 0x04004879 RID: 18553
			private static readonly IntPtr NativeMethodInfoPtr_VarDecMod_Internal_Static_Void_byref_DecCalc_byref_DecCalc_0;

			// Token: 0x0400487A RID: 18554
			private static readonly IntPtr NativeMethodInfoPtr_VarDecModFull_Private_Static_Void_byref_DecCalc_byref_DecCalc_Int32_0;

			// Token: 0x0400487B RID: 18555
			private static readonly IntPtr NativeMethodInfoPtr_InternalRound_Internal_Static_Void_byref_DecCalc_UInt32_RoundingMode_0;

			// Token: 0x0400487C RID: 18556
			private static readonly IntPtr NativeMethodInfoPtr_DecDivMod1E9_Internal_Static_UInt32_byref_DecCalc_0;

			// Token: 0x0400487D RID: 18557
			[FieldOffset(0)]
			public uint uflags;

			// Token: 0x0400487E RID: 18558
			[FieldOffset(4)]
			public uint uhi;

			// Token: 0x0400487F RID: 18559
			[FieldOffset(8)]
			public uint ulo;

			// Token: 0x04004880 RID: 18560
			[FieldOffset(12)]
			public uint umid;

			// Token: 0x04004881 RID: 18561
			[FieldOffset(8)]
			public ulong ulomidLE;

			// Token: 0x02000788 RID: 1928
			public enum RoundingMode
			{
				// Token: 0x040050AA RID: 20650
				ToEven,
				// Token: 0x040050AB RID: 20651
				AwayFromZero,
				// Token: 0x040050AC RID: 20652
				Truncate,
				// Token: 0x040050AD RID: 20653
				Floor,
				// Token: 0x040050AE RID: 20654
				Ceiling
			}

			// Token: 0x02000789 RID: 1929
			[StructLayout(2)]
			public struct PowerOvfl
			{
				// Token: 0x060062FC RID: 25340 RVA: 0x001B98FC File Offset: 0x001B7AFC
				// Note: this type is marked as 'beforefieldinit'.
				static PowerOvfl()
				{
					Il2CppClassPointerStore<Decimal.DecCalc.PowerOvfl>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, "PowerOvfl");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Decimal.DecCalc.PowerOvfl>.NativeClassPtr);
					Decimal.DecCalc.PowerOvfl.NativeFieldInfoPtr_Hi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal.DecCalc.PowerOvfl>.NativeClassPtr, "Hi");
					Decimal.DecCalc.PowerOvfl.NativeFieldInfoPtr_MidLo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal.DecCalc.PowerOvfl>.NativeClassPtr, "MidLo");
					Decimal.DecCalc.PowerOvfl.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc.PowerOvfl>.NativeClassPtr, 100667807);
				}

				// Token: 0x060062FD RID: 25341 RVA: 0x001B9964 File Offset: 0x001B7B64
				[CallerCount(0)]
				public unsafe PowerOvfl(uint hi, uint mid, uint lo)
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref hi;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mid;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lo;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.PowerOvfl.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060062FE RID: 25342 RVA: 0x0002514C File Offset: 0x0002334C
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Decimal.DecCalc.PowerOvfl>.NativeClassPtr, ref this));
				}

				// Token: 0x040050AF RID: 20655
				private static readonly IntPtr NativeFieldInfoPtr_Hi;

				// Token: 0x040050B0 RID: 20656
				private static readonly IntPtr NativeFieldInfoPtr_MidLo;

				// Token: 0x040050B1 RID: 20657
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_0;

				// Token: 0x040050B2 RID: 20658
				[FieldOffset(0)]
				public readonly uint Hi;

				// Token: 0x040050B3 RID: 20659
				[FieldOffset(8)]
				public readonly ulong MidLo;
			}

			// Token: 0x0200078A RID: 1930
			[StructLayout(2)]
			public struct Buf12
			{
				// Token: 0x060062FF RID: 25343 RVA: 0x001B99B4 File Offset: 0x001B7BB4
				// Note: this type is marked as 'beforefieldinit'.
				static Buf12()
				{
					Il2CppClassPointerStore<Decimal.DecCalc.Buf12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, "Buf12");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Decimal.DecCalc.Buf12>.NativeClassPtr);
					Decimal.DecCalc.Buf12.NativeFieldInfoPtr_U0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal.DecCalc.Buf12>.NativeClassPtr, "U0");
					Decimal.DecCalc.Buf12.NativeFieldInfoPtr_U1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal.DecCalc.Buf12>.NativeClassPtr, "U1");
					Decimal.DecCalc.Buf12.NativeFieldInfoPtr_U2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal.DecCalc.Buf12>.NativeClassPtr, "U2");
					Decimal.DecCalc.Buf12.NativeFieldInfoPtr_ulo64LE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal.DecCalc.Buf12>.NativeClassPtr, "ulo64LE");
					Decimal.DecCalc.Buf12.NativeFieldInfoPtr_uhigh64LE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal.DecCalc.Buf12>.NativeClassPtr, "uhigh64LE");
					Decimal.DecCalc.Buf12.NativeMethodInfoPtr_get_Low64_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc.Buf12>.NativeClassPtr, 100667808);
					Decimal.DecCalc.Buf12.NativeMethodInfoPtr_set_Low64_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc.Buf12>.NativeClassPtr, 100667809);
					Decimal.DecCalc.Buf12.NativeMethodInfoPtr_get_High64_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc.Buf12>.NativeClassPtr, 100667810);
					Decimal.DecCalc.Buf12.NativeMethodInfoPtr_set_High64_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc.Buf12>.NativeClassPtr, 100667811);
				}

				// Token: 0x1700198E RID: 6542
				// (get) Token: 0x06006300 RID: 25344 RVA: 0x001B9A94 File Offset: 0x001B7C94
				// (set) Token: 0x06006301 RID: 25345 RVA: 0x001B9AC4 File Offset: 0x001B7CC4
				public unsafe ulong Low64
				{
					[CallerCount(128)]
					[CachedScanResults(RefRangeStart = 323623, RefRangeEnd = 323751, XrefRangeStart = 323623, XrefRangeEnd = 323751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.Buf12.NativeMethodInfoPtr_get_Low64_Public_get_UInt64_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
					[CallerCount(44)]
					[CachedScanResults(RefRangeStart = 315640, RefRangeEnd = 315684, XrefRangeStart = 315640, XrefRangeEnd = 315684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					set
					{
						checked
						{
							IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
							*ptr = ref value;
							IntPtr intPtr2;
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.Buf12.NativeMethodInfoPtr_set_Low64_Public_set_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x1700198F RID: 6543
				// (get) Token: 0x06006302 RID: 25346 RVA: 0x001B9AF8 File Offset: 0x001B7CF8
				// (set) Token: 0x06006303 RID: 25347 RVA: 0x001B9B28 File Offset: 0x001B7D28
				public unsafe ulong High64
				{
					[CallerCount(20)]
					[CachedScanResults(RefRangeStart = 283873, RefRangeEnd = 283893, XrefRangeStart = 283873, XrefRangeEnd = 283893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.Buf12.NativeMethodInfoPtr_get_High64_Public_get_UInt64_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
					[CallerCount(2)]
					[CachedScanResults(RefRangeStart = 1266722, RefRangeEnd = 1266724, XrefRangeStart = 1266722, XrefRangeEnd = 1266724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					set
					{
						checked
						{
							IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
							*ptr = ref value;
							IntPtr intPtr2;
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.Buf12.NativeMethodInfoPtr_set_High64_Public_set_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x06006304 RID: 25348 RVA: 0x0002515E File Offset: 0x0002335E
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Decimal.DecCalc.Buf12>.NativeClassPtr, ref this));
				}

				// Token: 0x040050B4 RID: 20660
				private static readonly IntPtr NativeFieldInfoPtr_U0;

				// Token: 0x040050B5 RID: 20661
				private static readonly IntPtr NativeFieldInfoPtr_U1;

				// Token: 0x040050B6 RID: 20662
				private static readonly IntPtr NativeFieldInfoPtr_U2;

				// Token: 0x040050B7 RID: 20663
				private static readonly IntPtr NativeFieldInfoPtr_ulo64LE;

				// Token: 0x040050B8 RID: 20664
				private static readonly IntPtr NativeFieldInfoPtr_uhigh64LE;

				// Token: 0x040050B9 RID: 20665
				private static readonly IntPtr NativeMethodInfoPtr_get_Low64_Public_get_UInt64_0;

				// Token: 0x040050BA RID: 20666
				private static readonly IntPtr NativeMethodInfoPtr_set_Low64_Public_set_Void_UInt64_0;

				// Token: 0x040050BB RID: 20667
				private static readonly IntPtr NativeMethodInfoPtr_get_High64_Public_get_UInt64_0;

				// Token: 0x040050BC RID: 20668
				private static readonly IntPtr NativeMethodInfoPtr_set_High64_Public_set_Void_UInt64_0;

				// Token: 0x040050BD RID: 20669
				[FieldOffset(0)]
				public uint U0;

				// Token: 0x040050BE RID: 20670
				[FieldOffset(4)]
				public uint U1;

				// Token: 0x040050BF RID: 20671
				[FieldOffset(8)]
				public uint U2;

				// Token: 0x040050C0 RID: 20672
				[FieldOffset(0)]
				public ulong ulo64LE;

				// Token: 0x040050C1 RID: 20673
				[FieldOffset(4)]
				public ulong uhigh64LE;
			}

			// Token: 0x0200078B RID: 1931
			[StructLayout(2)]
			public struct Buf16
			{
				// Token: 0x06006305 RID: 25349 RVA: 0x001B9B5C File Offset: 0x001B7D5C
				// Note: this type is marked as 'beforefieldinit'.
				static Buf16()
				{
					Il2CppClassPointerStore<Decimal.DecCalc.Buf16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, "Buf16");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Decimal.DecCalc.Buf16>.NativeClassPtr);
					Decimal.DecCalc.Buf16.NativeFieldInfoPtr_U0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal.DecCalc.Buf16>.NativeClassPtr, "U0");
					Decimal.DecCalc.Buf16.NativeFieldInfoPtr_U1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal.DecCalc.Buf16>.NativeClassPtr, "U1");
					Decimal.DecCalc.Buf16.NativeFieldInfoPtr_U2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal.DecCalc.Buf16>.NativeClassPtr, "U2");
					Decimal.DecCalc.Buf16.NativeFieldInfoPtr_U3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal.DecCalc.Buf16>.NativeClassPtr, "U3");
					Decimal.DecCalc.Buf16.NativeFieldInfoPtr_ulo64LE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal.DecCalc.Buf16>.NativeClassPtr, "ulo64LE");
					Decimal.DecCalc.Buf16.NativeFieldInfoPtr_uhigh64LE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal.DecCalc.Buf16>.NativeClassPtr, "uhigh64LE");
					Decimal.DecCalc.Buf16.NativeMethodInfoPtr_get_Low64_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc.Buf16>.NativeClassPtr, 100667812);
					Decimal.DecCalc.Buf16.NativeMethodInfoPtr_set_Low64_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc.Buf16>.NativeClassPtr, 100667813);
					Decimal.DecCalc.Buf16.NativeMethodInfoPtr_get_High64_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc.Buf16>.NativeClassPtr, 100667814);
					Decimal.DecCalc.Buf16.NativeMethodInfoPtr_set_High64_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc.Buf16>.NativeClassPtr, 100667815);
				}

				// Token: 0x17001990 RID: 6544
				// (get) Token: 0x06006306 RID: 25350 RVA: 0x001B9C50 File Offset: 0x001B7E50
				// (set) Token: 0x06006307 RID: 25351 RVA: 0x001B9C80 File Offset: 0x001B7E80
				public unsafe ulong Low64
				{
					[CallerCount(128)]
					[CachedScanResults(RefRangeStart = 323623, RefRangeEnd = 323751, XrefRangeStart = 323623, XrefRangeEnd = 323751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.Buf16.NativeMethodInfoPtr_get_Low64_Public_get_UInt64_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
					[CallerCount(44)]
					[CachedScanResults(RefRangeStart = 315640, RefRangeEnd = 315684, XrefRangeStart = 315640, XrefRangeEnd = 315684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					set
					{
						checked
						{
							IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
							*ptr = ref value;
							IntPtr intPtr2;
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.Buf16.NativeMethodInfoPtr_set_Low64_Public_set_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x17001991 RID: 6545
				// (get) Token: 0x06006308 RID: 25352 RVA: 0x001B9CB4 File Offset: 0x001B7EB4
				// (set) Token: 0x06006309 RID: 25353 RVA: 0x001B9CE4 File Offset: 0x001B7EE4
				public unsafe ulong High64
				{
					[CallerCount(13)]
					[CachedScanResults(RefRangeStart = 323759, RefRangeEnd = 323772, XrefRangeStart = 323759, XrefRangeEnd = 323772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.Buf16.NativeMethodInfoPtr_get_High64_Public_get_UInt64_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
					[CallerCount(0)]
					set
					{
						checked
						{
							IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
							*ptr = ref value;
							IntPtr intPtr2;
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.Buf16.NativeMethodInfoPtr_set_High64_Public_set_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x0600630A RID: 25354 RVA: 0x00025170 File Offset: 0x00023370
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Decimal.DecCalc.Buf16>.NativeClassPtr, ref this));
				}

				// Token: 0x040050C2 RID: 20674
				private static readonly IntPtr NativeFieldInfoPtr_U0;

				// Token: 0x040050C3 RID: 20675
				private static readonly IntPtr NativeFieldInfoPtr_U1;

				// Token: 0x040050C4 RID: 20676
				private static readonly IntPtr NativeFieldInfoPtr_U2;

				// Token: 0x040050C5 RID: 20677
				private static readonly IntPtr NativeFieldInfoPtr_U3;

				// Token: 0x040050C6 RID: 20678
				private static readonly IntPtr NativeFieldInfoPtr_ulo64LE;

				// Token: 0x040050C7 RID: 20679
				private static readonly IntPtr NativeFieldInfoPtr_uhigh64LE;

				// Token: 0x040050C8 RID: 20680
				private static readonly IntPtr NativeMethodInfoPtr_get_Low64_Public_get_UInt64_0;

				// Token: 0x040050C9 RID: 20681
				private static readonly IntPtr NativeMethodInfoPtr_set_Low64_Public_set_Void_UInt64_0;

				// Token: 0x040050CA RID: 20682
				private static readonly IntPtr NativeMethodInfoPtr_get_High64_Public_get_UInt64_0;

				// Token: 0x040050CB RID: 20683
				private static readonly IntPtr NativeMethodInfoPtr_set_High64_Public_set_Void_UInt64_0;

				// Token: 0x040050CC RID: 20684
				[FieldOffset(0)]
				public uint U0;

				// Token: 0x040050CD RID: 20685
				[FieldOffset(4)]
				public uint U1;

				// Token: 0x040050CE RID: 20686
				[FieldOffset(8)]
				public uint U2;

				// Token: 0x040050CF RID: 20687
				[FieldOffset(12)]
				public uint U3;

				// Token: 0x040050D0 RID: 20688
				[FieldOffset(0)]
				public ulong ulo64LE;

				// Token: 0x040050D1 RID: 20689
				[FieldOffset(8)]
				public ulong uhigh64LE;
			}

			// Token: 0x0200078C RID: 1932
			[StructLayout(2)]
			public struct Buf24
			{
				// Token: 0x0600630B RID: 25355 RVA: 0x001B9D18 File Offset: 0x001B7F18
				// Note: this type is marked as 'beforefieldinit'.
				static Buf24()
				{
					Il2CppClassPointerStore<Decimal.DecCalc.Buf24>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, "Buf24");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Decimal.DecCalc.Buf24>.NativeClassPtr);
					Decimal.DecCalc.Buf24.NativeFieldInfoPtr_U0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal.DecCalc.Buf24>.NativeClassPtr, "U0");
					Decimal.DecCalc.Buf24.NativeFieldInfoPtr_U1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal.DecCalc.Buf24>.NativeClassPtr, "U1");
					Decimal.DecCalc.Buf24.NativeFieldInfoPtr_U2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal.DecCalc.Buf24>.NativeClassPtr, "U2");
					Decimal.DecCalc.Buf24.NativeFieldInfoPtr_U3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal.DecCalc.Buf24>.NativeClassPtr, "U3");
					Decimal.DecCalc.Buf24.NativeFieldInfoPtr_U4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal.DecCalc.Buf24>.NativeClassPtr, "U4");
					Decimal.DecCalc.Buf24.NativeFieldInfoPtr_U5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal.DecCalc.Buf24>.NativeClassPtr, "U5");
					Decimal.DecCalc.Buf24.NativeFieldInfoPtr_ulo64LE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal.DecCalc.Buf24>.NativeClassPtr, "ulo64LE");
					Decimal.DecCalc.Buf24.NativeFieldInfoPtr_umid64LE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal.DecCalc.Buf24>.NativeClassPtr, "umid64LE");
					Decimal.DecCalc.Buf24.NativeFieldInfoPtr_uhigh64LE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal.DecCalc.Buf24>.NativeClassPtr, "uhigh64LE");
					Decimal.DecCalc.Buf24.NativeMethodInfoPtr_get_Low64_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc.Buf24>.NativeClassPtr, 100667816);
					Decimal.DecCalc.Buf24.NativeMethodInfoPtr_set_Low64_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc.Buf24>.NativeClassPtr, 100667817);
					Decimal.DecCalc.Buf24.NativeMethodInfoPtr_set_Mid64_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc.Buf24>.NativeClassPtr, 100667818);
					Decimal.DecCalc.Buf24.NativeMethodInfoPtr_set_High64_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal.DecCalc.Buf24>.NativeClassPtr, 100667819);
				}

				// Token: 0x17001992 RID: 6546
				// (get) Token: 0x0600630C RID: 25356 RVA: 0x001B9E48 File Offset: 0x001B8048
				// (set) Token: 0x0600630D RID: 25357 RVA: 0x001B9E78 File Offset: 0x001B8078
				public unsafe ulong Low64
				{
					[CallerCount(128)]
					[CachedScanResults(RefRangeStart = 323623, RefRangeEnd = 323751, XrefRangeStart = 323623, XrefRangeEnd = 323751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.Buf24.NativeMethodInfoPtr_get_Low64_Public_get_UInt64_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
					[CallerCount(44)]
					[CachedScanResults(RefRangeStart = 315640, RefRangeEnd = 315684, XrefRangeStart = 315640, XrefRangeEnd = 315684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					set
					{
						checked
						{
							IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
							*ptr = ref value;
							IntPtr intPtr2;
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.Buf24.NativeMethodInfoPtr_set_Low64_Public_set_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x17001993 RID: 6547
				// (set) Token: 0x0600630E RID: 25358 RVA: 0x001B9EAC File Offset: 0x001B80AC
				public unsafe ulong Mid64
				{
					[CallerCount(0)]
					set
					{
						checked
						{
							IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
							*ptr = ref value;
							IntPtr intPtr2;
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.Buf24.NativeMethodInfoPtr_set_Mid64_Public_set_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x17001994 RID: 6548
				// (set) Token: 0x0600630F RID: 25359 RVA: 0x001B9EE0 File Offset: 0x001B80E0
				public unsafe ulong High64
				{
					[CallerCount(0)]
					set
					{
						checked
						{
							IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
							*ptr = ref value;
							IntPtr intPtr2;
							IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.DecCalc.Buf24.NativeMethodInfoPtr_set_High64_Public_set_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
							Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						}
					}
				}

				// Token: 0x06006310 RID: 25360 RVA: 0x00025182 File Offset: 0x00023382
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Decimal.DecCalc.Buf24>.NativeClassPtr, ref this));
				}

				// Token: 0x040050D2 RID: 20690
				private static readonly IntPtr NativeFieldInfoPtr_U0;

				// Token: 0x040050D3 RID: 20691
				private static readonly IntPtr NativeFieldInfoPtr_U1;

				// Token: 0x040050D4 RID: 20692
				private static readonly IntPtr NativeFieldInfoPtr_U2;

				// Token: 0x040050D5 RID: 20693
				private static readonly IntPtr NativeFieldInfoPtr_U3;

				// Token: 0x040050D6 RID: 20694
				private static readonly IntPtr NativeFieldInfoPtr_U4;

				// Token: 0x040050D7 RID: 20695
				private static readonly IntPtr NativeFieldInfoPtr_U5;

				// Token: 0x040050D8 RID: 20696
				private static readonly IntPtr NativeFieldInfoPtr_ulo64LE;

				// Token: 0x040050D9 RID: 20697
				private static readonly IntPtr NativeFieldInfoPtr_umid64LE;

				// Token: 0x040050DA RID: 20698
				private static readonly IntPtr NativeFieldInfoPtr_uhigh64LE;

				// Token: 0x040050DB RID: 20699
				private static readonly IntPtr NativeMethodInfoPtr_get_Low64_Public_get_UInt64_0;

				// Token: 0x040050DC RID: 20700
				private static readonly IntPtr NativeMethodInfoPtr_set_Low64_Public_set_Void_UInt64_0;

				// Token: 0x040050DD RID: 20701
				private static readonly IntPtr NativeMethodInfoPtr_set_Mid64_Public_set_Void_UInt64_0;

				// Token: 0x040050DE RID: 20702
				private static readonly IntPtr NativeMethodInfoPtr_set_High64_Public_set_Void_UInt64_0;

				// Token: 0x040050DF RID: 20703
				[FieldOffset(0)]
				public uint U0;

				// Token: 0x040050E0 RID: 20704
				[FieldOffset(4)]
				public uint U1;

				// Token: 0x040050E1 RID: 20705
				[FieldOffset(8)]
				public uint U2;

				// Token: 0x040050E2 RID: 20706
				[FieldOffset(12)]
				public uint U3;

				// Token: 0x040050E3 RID: 20707
				[FieldOffset(16)]
				public uint U4;

				// Token: 0x040050E4 RID: 20708
				[FieldOffset(20)]
				public uint U5;

				// Token: 0x040050E5 RID: 20709
				[FieldOffset(0)]
				public ulong ulo64LE;

				// Token: 0x040050E6 RID: 20710
				[FieldOffset(8)]
				public ulong umid64LE;

				// Token: 0x040050E7 RID: 20711
				[FieldOffset(16)]
				public ulong uhigh64LE;
			}

			// Token: 0x0200078D RID: 1933
			[StructLayout(2)]
			public struct Buf28
			{
				// Token: 0x06006311 RID: 25361 RVA: 0x001B9F14 File Offset: 0x001B8114
				// Note: this type is marked as 'beforefieldinit'.
				static Buf28()
				{
					Il2CppClassPointerStore<Decimal.DecCalc.Buf28>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Decimal.DecCalc>.NativeClassPtr, "Buf28");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Decimal.DecCalc.Buf28>.NativeClassPtr);
					Decimal.DecCalc.Buf28.NativeFieldInfoPtr_Buf24 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal.DecCalc.Buf28>.NativeClassPtr, "Buf24");
					Decimal.DecCalc.Buf28.NativeFieldInfoPtr_U6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal.DecCalc.Buf28>.NativeClassPtr, "U6");
				}

				// Token: 0x06006312 RID: 25362 RVA: 0x00025194 File Offset: 0x00023394
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Decimal.DecCalc.Buf28>.NativeClassPtr, ref this));
				}

				// Token: 0x040050E8 RID: 20712
				private static readonly IntPtr NativeFieldInfoPtr_Buf24;

				// Token: 0x040050E9 RID: 20713
				private static readonly IntPtr NativeFieldInfoPtr_U6;

				// Token: 0x040050EA RID: 20714
				[FieldOffset(0)]
				public Decimal.DecCalc.Buf24 Buf24;

				// Token: 0x040050EB RID: 20715
				[FieldOffset(24)]
				public uint U6;
			}
		}
	}
}
