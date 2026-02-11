using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Dynamic;
using Il2CppSystem.Linq.Expressions;
using Il2CppSystem.Numerics;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000C3 RID: 195
	public class JToken : Object
	{
		// Token: 0x06001192 RID: 4498 RVA: 0x000621F8 File Offset: 0x000603F8
		// Note: this type is marked as 'beforefieldinit'.
		static JToken()
		{
			Il2CppClassPointerStore<JToken>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Linq", "JToken");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JToken>.NativeClassPtr);
			JToken.NativeFieldInfoPtr__equalityComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken>.NativeClassPtr, "_equalityComparer");
			JToken.NativeFieldInfoPtr__parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken>.NativeClassPtr, "_parent");
			JToken.NativeFieldInfoPtr__previous = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken>.NativeClassPtr, "_previous");
			JToken.NativeFieldInfoPtr__next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken>.NativeClassPtr, "_next");
			JToken.NativeFieldInfoPtr__annotations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken>.NativeClassPtr, "_annotations");
			JToken.NativeFieldInfoPtr_BooleanTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken>.NativeClassPtr, "BooleanTypes");
			JToken.NativeFieldInfoPtr_NumberTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken>.NativeClassPtr, "NumberTypes");
			JToken.NativeFieldInfoPtr_BigIntegerTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken>.NativeClassPtr, "BigIntegerTypes");
			JToken.NativeFieldInfoPtr_StringTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken>.NativeClassPtr, "StringTypes");
			JToken.NativeFieldInfoPtr_GuidTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken>.NativeClassPtr, "GuidTypes");
			JToken.NativeFieldInfoPtr_TimeSpanTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken>.NativeClassPtr, "TimeSpanTypes");
			JToken.NativeFieldInfoPtr_UriTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken>.NativeClassPtr, "UriTypes");
			JToken.NativeFieldInfoPtr_CharTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken>.NativeClassPtr, "CharTypes");
			JToken.NativeFieldInfoPtr_DateTimeTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken>.NativeClassPtr, "DateTimeTypes");
			JToken.NativeFieldInfoPtr_BytesTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken>.NativeClassPtr, "BytesTypes");
			JToken.NativeMethodInfoPtr_WriteToAsync_Public_Virtual_New_Task_JsonWriter_CancellationToken_Il2CppReferenceArray_1_JsonConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666537);
			JToken.NativeMethodInfoPtr_WriteToAsync_Public_Task_JsonWriter_Il2CppReferenceArray_1_JsonConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666538);
			JToken.NativeMethodInfoPtr_ReadFromAsync_Public_Static_Task_1_JToken_JsonReader_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666539);
			JToken.NativeMethodInfoPtr_ReadFromAsync_Public_Static_Task_1_JToken_JsonReader_JsonLoadSettings_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666540);
			JToken.NativeMethodInfoPtr_LoadAsync_Public_Static_Task_1_JToken_JsonReader_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666541);
			JToken.NativeMethodInfoPtr_LoadAsync_Public_Static_Task_1_JToken_JsonReader_JsonLoadSettings_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666542);
			JToken.NativeMethodInfoPtr_get_EqualityComparer_Public_Static_get_JTokenEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666543);
			JToken.NativeMethodInfoPtr_get_Parent_Public_get_JContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666544);
			JToken.NativeMethodInfoPtr_set_Parent_Internal_set_Void_JContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666545);
			JToken.NativeMethodInfoPtr_get_Root_Public_get_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666546);
			JToken.NativeMethodInfoPtr_CloneToken_Internal_Abstract_Virtual_New_JToken_JsonCloneSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666547);
			JToken.NativeMethodInfoPtr_DeepEquals_Internal_Abstract_Virtual_New_Boolean_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666548);
			JToken.NativeMethodInfoPtr_get_Type_Public_Abstract_Virtual_New_get_JTokenType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666549);
			JToken.NativeMethodInfoPtr_get_HasValues_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666550);
			JToken.NativeMethodInfoPtr_DeepEquals_Public_Static_Boolean_JToken_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666551);
			JToken.NativeMethodInfoPtr_get_Next_Public_get_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666552);
			JToken.NativeMethodInfoPtr_set_Next_Internal_set_Void_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666553);
			JToken.NativeMethodInfoPtr_get_Previous_Public_get_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666554);
			JToken.NativeMethodInfoPtr_set_Previous_Internal_set_Void_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666555);
			JToken.NativeMethodInfoPtr_get_Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666556);
			JToken.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666557);
			JToken.NativeMethodInfoPtr_AddAfterSelf_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666558);
			JToken.NativeMethodInfoPtr_AddBeforeSelf_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666559);
			JToken.NativeMethodInfoPtr_Ancestors_Public_IEnumerable_1_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666560);
			JToken.NativeMethodInfoPtr_AncestorsAndSelf_Public_IEnumerable_1_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666561);
			JToken.NativeMethodInfoPtr_GetAncestors_Internal_IEnumerable_1_JToken_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666562);
			JToken.NativeMethodInfoPtr_AfterSelf_Public_IEnumerable_1_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666563);
			JToken.NativeMethodInfoPtr_BeforeSelf_Public_IEnumerable_1_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666564);
			JToken.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_JToken_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666565);
			JToken.NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Object_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666566);
			JToken.NativeMethodInfoPtr_Value_Public_Virtual_New_T_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666567);
			JToken.NativeMethodInfoPtr_get_First_Public_Virtual_New_get_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666568);
			JToken.NativeMethodInfoPtr_get_Last_Public_Virtual_New_get_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666569);
			JToken.NativeMethodInfoPtr_Children_Public_Virtual_New_JEnumerable_1_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666570);
			JToken.NativeMethodInfoPtr_Children_Public_JEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666571);
			JToken.NativeMethodInfoPtr_Values_Public_Virtual_New_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666572);
			JToken.NativeMethodInfoPtr_Remove_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666573);
			JToken.NativeMethodInfoPtr_Replace_Public_Void_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666574);
			JToken.NativeMethodInfoPtr_WriteTo_Public_Abstract_Virtual_New_Void_JsonWriter_Il2CppReferenceArray_1_JsonConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666575);
			JToken.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666576);
			JToken.NativeMethodInfoPtr_ToString_Public_String_Formatting_Il2CppReferenceArray_1_JsonConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666577);
			JToken.NativeMethodInfoPtr_EnsureValue_Private_Static_JValue_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666578);
			JToken.NativeMethodInfoPtr_GetType_Private_Static_String_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666579);
			JToken.NativeMethodInfoPtr_ValidateToken_Private_Static_Boolean_JToken_Il2CppStructArray_1_JTokenType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666580);
			JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Boolean_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666581);
			JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_DateTimeOffset_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666582);
			JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_Boolean_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666583);
			JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Int64_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666584);
			JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_DateTime_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666585);
			JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_DateTimeOffset_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666586);
			JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_Decimal_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666587);
			JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_Double_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666588);
			JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_Char_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666589);
			JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666590);
			JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Int16_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666591);
			JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt16_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666592);
			JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Char_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666593);
			JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Byte_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666594);
			JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_SByte_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666595);
			JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_Int32_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666596);
			JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_Int16_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666597);
			JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_UInt16_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666598);
			JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_Byte_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666599);
			JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_SByte_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666600);
			JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_DateTime_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666601);
			JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_Int64_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666602);
			JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_Single_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666603);
			JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Decimal_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666604);
			JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_UInt32_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666605);
			JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_UInt64_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666606);
			JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Double_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666607);
			JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Single_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666608);
			JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_String_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666609);
			JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666610);
			JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666611);
			JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Il2CppStructArray_1_Byte_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666612);
			JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Guid_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666613);
			JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_Guid_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666614);
			JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_TimeSpan_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666615);
			JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_TimeSpan_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666616);
			JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Uri_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666617);
			JToken.NativeMethodInfoPtr_ToBigInteger_Private_Static_BigInteger_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666618);
			JToken.NativeMethodInfoPtr_ToBigIntegerNullable_Private_Static_Nullable_1_BigInteger_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666619);
			JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666620);
			JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666621);
			JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666622);
			JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666623);
			JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666624);
			JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666625);
			JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666626);
			JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666627);
			JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666628);
			JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666629);
			JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666630);
			JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666631);
			JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666632);
			JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666633);
			JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666634);
			JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666635);
			JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666636);
			JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666637);
			JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666638);
			JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666639);
			JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666640);
			JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666641);
			JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666642);
			JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666643);
			JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666644);
			JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666645);
			JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666646);
			JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666647);
			JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666648);
			JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666649);
			JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666650);
			JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666651);
			JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666652);
			JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666653);
			JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666654);
			JToken.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666655);
			JToken.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666656);
			JToken.NativeMethodInfoPtr_GetDeepHashCode_Internal_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666657);
			JToken.NativeMethodInfoPtr_Newtonsoft_Json_Linq_IJEnumerable_Newtonsoft_Json_Linq_JToken__get_Item_Private_Virtual_Final_New_get_IJEnumerable_1_JToken_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666658);
			JToken.NativeMethodInfoPtr_CreateReader_Public_JsonReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666659);
			JToken.NativeMethodInfoPtr_FromObjectInternal_Internal_Static_JToken_Object_JsonSerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666660);
			JToken.NativeMethodInfoPtr_FromObject_Public_Static_JToken_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666661);
			JToken.NativeMethodInfoPtr_FromObject_Public_Static_JToken_Object_JsonSerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666662);
			JToken.NativeMethodInfoPtr_ToObject_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666663);
			JToken.NativeMethodInfoPtr_ToObject_Public_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666664);
			JToken.NativeMethodInfoPtr_ToObject_Public_T_JsonSerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666665);
			JToken.NativeMethodInfoPtr_ToObject_Public_Object_Type_JsonSerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666666);
			JToken.NativeMethodInfoPtr_ReadFrom_Public_Static_JToken_JsonReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666667);
			JToken.NativeMethodInfoPtr_ReadFrom_Public_Static_JToken_JsonReader_JsonLoadSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666668);
			JToken.NativeMethodInfoPtr_Parse_Public_Static_JToken_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666669);
			JToken.NativeMethodInfoPtr_Parse_Public_Static_JToken_String_JsonLoadSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666670);
			JToken.NativeMethodInfoPtr_Load_Public_Static_JToken_JsonReader_JsonLoadSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666671);
			JToken.NativeMethodInfoPtr_Load_Public_Static_JToken_JsonReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666672);
			JToken.NativeMethodInfoPtr_SetLineInfo_Internal_Void_IJsonLineInfo_JsonLoadSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666673);
			JToken.NativeMethodInfoPtr_SetLineInfo_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666674);
			JToken.NativeMethodInfoPtr_Newtonsoft_Json_IJsonLineInfo_HasLineInfo_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666675);
			JToken.NativeMethodInfoPtr_Newtonsoft_Json_IJsonLineInfo_get_LineNumber_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666676);
			JToken.NativeMethodInfoPtr_Newtonsoft_Json_IJsonLineInfo_get_LinePosition_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666677);
			JToken.NativeMethodInfoPtr_SelectToken_Public_JToken_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666678);
			JToken.NativeMethodInfoPtr_SelectToken_Public_JToken_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666679);
			JToken.NativeMethodInfoPtr_SelectToken_Public_JToken_String_JsonSelectSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666680);
			JToken.NativeMethodInfoPtr_SelectTokens_Public_IEnumerable_1_JToken_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666681);
			JToken.NativeMethodInfoPtr_SelectTokens_Public_IEnumerable_1_JToken_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666682);
			JToken.NativeMethodInfoPtr_SelectTokens_Public_IEnumerable_1_JToken_String_JsonSelectSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666683);
			JToken.NativeMethodInfoPtr_GetMetaObject_Protected_Virtual_New_DynamicMetaObject_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666684);
			JToken.NativeMethodInfoPtr_System_Dynamic_IDynamicMetaObjectProvider_GetMetaObject_Private_Virtual_Final_New_DynamicMetaObject_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666685);
			JToken.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666686);
			JToken.NativeMethodInfoPtr_DeepClone_Public_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666687);
			JToken.NativeMethodInfoPtr_DeepClone_Public_JToken_JsonCloneSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666688);
			JToken.NativeMethodInfoPtr_AddAnnotation_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666689);
			JToken.NativeMethodInfoPtr_Annotation_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666690);
			JToken.NativeMethodInfoPtr_Annotation_Public_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666691);
			JToken.NativeMethodInfoPtr_Annotations_Public_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666692);
			JToken.NativeMethodInfoPtr_Annotations_Public_IEnumerable_1_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666693);
			JToken.NativeMethodInfoPtr_RemoveAnnotations_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666694);
			JToken.NativeMethodInfoPtr_RemoveAnnotations_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666695);
			JToken.NativeMethodInfoPtr_CopyAnnotations_Internal_Void_JToken_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken>.NativeClassPtr, 100666696);
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x00062FD4 File Offset: 0x000611D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759459, XrefRangeEnd = 759464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, [Optional] Il2CppReferenceArray<JsonConverter> converters)
		{
			if (converters == null)
			{
				converters = new Il2CppReferenceArray<JsonConverter>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JToken.NativeMethodInfoPtr_WriteToAsync_Public_Virtual_New_Task_JsonWriter_CancellationToken_Il2CppReferenceArray_1_JsonConverter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06001194 RID: 4500 RVA: 0x00063068 File Offset: 0x00061268
		[CallerCount(0)]
		public unsafe Task WriteToAsync(JsonWriter writer, [Optional] Il2CppReferenceArray<JsonConverter> converters)
		{
			if (converters == null)
			{
				converters = new Il2CppReferenceArray<JsonConverter>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_WriteToAsync_Public_Task_JsonWriter_Il2CppReferenceArray_1_JsonConverter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06001195 RID: 4501 RVA: 0x000630D8 File Offset: 0x000612D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759464, XrefRangeEnd = 759468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<JToken> ReadFromAsync(JsonReader reader, CancellationToken cancellationToken = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_ReadFromAsync_Public_Static_Task_1_JToken_JsonReader_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<JToken>>(intPtr3) : null;
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x00063134 File Offset: 0x00061334
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 759484, RefRangeEnd = 759487, XrefRangeStart = 759468, XrefRangeEnd = 759484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<JToken> ReadFromAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_ReadFromAsync_Public_Static_Task_1_JToken_JsonReader_JsonLoadSettings_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<JToken>>(intPtr3) : null;
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x000631A4 File Offset: 0x000613A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759487, XrefRangeEnd = 759494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<JToken> LoadAsync(JsonReader reader, CancellationToken cancellationToken = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_LoadAsync_Public_Static_Task_1_JToken_JsonReader_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<JToken>>(intPtr3) : null;
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x00063200 File Offset: 0x00061400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759494, XrefRangeEnd = 759498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<JToken> LoadAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_LoadAsync_Public_Static_Task_1_JToken_JsonReader_JsonLoadSettings_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<JToken>>(intPtr3) : null;
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06001199 RID: 4505 RVA: 0x00063270 File Offset: 0x00061470
		public unsafe static JTokenEqualityComparer EqualityComparer
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 759514, RefRangeEnd = 759517, XrefRangeStart = 759498, XrefRangeEnd = 759514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_get_EqualityComparer_Public_Static_get_JTokenEqualityComparer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JTokenEqualityComparer>(intPtr3) : null;
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x0600119A RID: 4506 RVA: 0x000632A4 File Offset: 0x000614A4
		// (set) Token: 0x0600119B RID: 4507 RVA: 0x000632E4 File Offset: 0x000614E4
		public unsafe JContainer Parent
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_get_Parent_Public_get_JContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JContainer>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_set_Parent_Internal_set_Void_JContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x0600119C RID: 4508 RVA: 0x00063328 File Offset: 0x00061528
		public unsafe JToken Root
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759517, XrefRangeEnd = 759518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_get_Root_Public_get_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x00063368 File Offset: 0x00061568
		[CallerCount(0)]
		public unsafe virtual JToken CloneToken(JsonCloneSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JToken.NativeMethodInfoPtr_CloneToken_Internal_Abstract_Virtual_New_JToken_JsonCloneSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x000633C4 File Offset: 0x000615C4
		[CallerCount(0)]
		public unsafe virtual bool DeepEquals(JToken node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JToken.NativeMethodInfoPtr_DeepEquals_Internal_Abstract_Virtual_New_Boolean_JToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x0600119F RID: 4511 RVA: 0x0006341C File Offset: 0x0006161C
		public unsafe virtual JTokenType Type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JToken.NativeMethodInfoPtr_get_Type_Public_Abstract_Virtual_New_get_JTokenType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x060011A0 RID: 4512 RVA: 0x00063464 File Offset: 0x00061664
		public unsafe virtual bool HasValues
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JToken.NativeMethodInfoPtr_get_HasValues_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x000634AC File Offset: 0x000616AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 759518, RefRangeEnd = 759519, XrefRangeStart = 759518, XrefRangeEnd = 759518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DeepEquals(JToken t1, JToken t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_DeepEquals_Public_Static_Boolean_JToken_JToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x060011A2 RID: 4514 RVA: 0x00063500 File Offset: 0x00061700
		// (set) Token: 0x060011A3 RID: 4515 RVA: 0x00063540 File Offset: 0x00061740
		public unsafe JToken Next
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_get_Next_Public_get_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_set_Next_Internal_set_Void_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x060011A4 RID: 4516 RVA: 0x00063584 File Offset: 0x00061784
		// (set) Token: 0x060011A5 RID: 4517 RVA: 0x000635C4 File Offset: 0x000617C4
		public unsafe JToken Previous
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_get_Previous_Public_get_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_set_Previous_Internal_set_Void_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x060011A6 RID: 4518 RVA: 0x00063608 File Offset: 0x00061808
		public unsafe string Path
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 759553, RefRangeEnd = 759555, XrefRangeStart = 759519, XrefRangeEnd = 759553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_get_Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x00063640 File Offset: 0x00061840
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JToken()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JToken>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x0006367C File Offset: 0x0006187C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759555, XrefRangeEnd = 759556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddAfterSelf(Object content)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_AddAfterSelf_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x000636C0 File Offset: 0x000618C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759556, XrefRangeEnd = 759557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddBeforeSelf(Object content)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_AddBeforeSelf_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x00063704 File Offset: 0x00061904
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 759558, RefRangeEnd = 759559, XrefRangeStart = 759557, XrefRangeEnd = 759558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<JToken> Ancestors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_Ancestors_Public_IEnumerable_1_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<JToken>>(intPtr3) : null;
		}

		// Token: 0x060011AB RID: 4523 RVA: 0x00063744 File Offset: 0x00061944
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 759560, RefRangeEnd = 759561, XrefRangeStart = 759559, XrefRangeEnd = 759560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<JToken> AncestorsAndSelf()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_AncestorsAndSelf_Public_IEnumerable_1_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<JToken>>(intPtr3) : null;
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x00063784 File Offset: 0x00061984
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 759567, RefRangeEnd = 759569, XrefRangeStart = 759561, XrefRangeEnd = 759567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<JToken> GetAncestors(bool self)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_GetAncestors_Internal_IEnumerable_1_JToken_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<JToken>>(intPtr3) : null;
			}
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x000637D0 File Offset: 0x000619D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759569, XrefRangeEnd = 759575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<JToken> AfterSelf()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_AfterSelf_Public_IEnumerable_1_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<JToken>>(intPtr3) : null;
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x00063810 File Offset: 0x00061A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759575, XrefRangeEnd = 759581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<JToken> BeforeSelf()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_BeforeSelf_Public_IEnumerable_1_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<JToken>>(intPtr3) : null;
		}

		// Token: 0x170004CC RID: 1228
		public unsafe virtual JToken this[Object key]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759581, XrefRangeEnd = 759592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JToken.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_JToken_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759592, XrefRangeEnd = 759610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JToken.NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Object_JToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x0006390C File Offset: 0x00061B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759610, XrefRangeEnd = 759618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual T Value<T>(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JToken.MethodInfoStoreGeneric_Value_Public_Virtual_New_T_Object_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x060011B2 RID: 4530 RVA: 0x00063964 File Offset: 0x00061B64
		public unsafe virtual JToken First
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759618, XrefRangeEnd = 759629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JToken.NativeMethodInfoPtr_get_First_Public_Virtual_New_get_JToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x060011B3 RID: 4531 RVA: 0x000639B0 File Offset: 0x00061BB0
		public unsafe virtual JToken Last
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759629, XrefRangeEnd = 759640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JToken.NativeMethodInfoPtr_get_Last_Public_Virtual_New_get_JToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x000639FC File Offset: 0x00061BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759640, XrefRangeEnd = 759644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual JEnumerable<JToken> Children()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JToken.NativeMethodInfoPtr_Children_Public_Virtual_New_JEnumerable_1_JToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new JEnumerable<JToken>(intPtr);
		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x00063A40 File Offset: 0x00061C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759644, XrefRangeEnd = 759650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JEnumerable<T> Children<T>() where T : JToken
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.MethodInfoStoreGeneric_Children_Public_JEnumerable_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new JEnumerable<T>(intPtr);
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x00063A78 File Offset: 0x00061C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759650, XrefRangeEnd = 759661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<T> Values<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JToken.MethodInfoStoreGeneric_Values_Public_Virtual_New_IEnumerable_1_T_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x00063AC4 File Offset: 0x00061CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759661, XrefRangeEnd = 759667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_Remove_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x00063AF8 File Offset: 0x00061CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759667, XrefRangeEnd = 759673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Replace(JToken value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_Replace_Public_Void_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x00063B3C File Offset: 0x00061D3C
		[CallerCount(0)]
		public unsafe virtual void WriteTo(JsonWriter writer, [Optional] Il2CppReferenceArray<JsonConverter> converters)
		{
			if (converters == null)
			{
				converters = new Il2CppReferenceArray<JsonConverter>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JToken.NativeMethodInfoPtr_WriteTo_Public_Abstract_Virtual_New_Void_JsonWriter_Il2CppReferenceArray_1_JsonConverter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x00063BA8 File Offset: 0x00061DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759673, XrefRangeEnd = 759680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JToken.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x00063BEC File Offset: 0x00061DEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 759699, RefRangeEnd = 759700, XrefRangeStart = 759680, XrefRangeEnd = 759699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(Formatting formatting, [Optional] Il2CppReferenceArray<JsonConverter> converters)
		{
			if (converters == null)
			{
				converters = new Il2CppReferenceArray<JsonConverter>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref formatting;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_ToString_Public_String_Formatting_Il2CppReferenceArray_1_JsonConverter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x00063C50 File Offset: 0x00061E50
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 759703, RefRangeEnd = 759742, XrefRangeStart = 759700, XrefRangeEnd = 759703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JValue EnsureValue(JToken value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_EnsureValue_Private_Static_JValue_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JValue>(intPtr3) : null;
			}
		}

		// Token: 0x060011BD RID: 4541 RVA: 0x00063C94 File Offset: 0x00061E94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 759751, RefRangeEnd = 759752, XrefRangeStart = 759742, XrefRangeEnd = 759751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetType(JToken token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(token);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_GetType_Private_Static_String_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060011BE RID: 4542 RVA: 0x00063CD0 File Offset: 0x00061ED0
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 759755, RefRangeEnd = 759774, XrefRangeStart = 759752, XrefRangeEnd = 759755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ValidateToken(JToken o, Il2CppStructArray<JTokenType> validTypes, bool nullable)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(validTypes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nullable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_ValidateToken_Private_Static_Boolean_JToken_Il2CppStructArray_1_JTokenType_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011BF RID: 4543 RVA: 0x00063D34 File Offset: 0x00061F34
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 759815, RefRangeEnd = 759824, XrefRangeStart = 759774, XrefRangeEnd = 759815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator bool(JToken value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Boolean_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x00063D78 File Offset: 0x00061F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759824, XrefRangeEnd = 759846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator DateTimeOffset(JToken value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_DateTimeOffset_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x00063DBC File Offset: 0x00061FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759846, XrefRangeEnd = 759867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator Nullable<bool>(JToken value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_Boolean_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<bool>(intPtr);
			}
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x00063DF8 File Offset: 0x00061FF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 759885, RefRangeEnd = 759886, XrefRangeStart = 759867, XrefRangeEnd = 759885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator long(JToken value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Int64_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x00063E3C File Offset: 0x0006203C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759886, XrefRangeEnd = 759913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator Nullable<DateTime>(JToken value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_DateTime_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<DateTime>(intPtr);
			}
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x00063E78 File Offset: 0x00062078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759913, XrefRangeEnd = 759949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator Nullable<DateTimeOffset>(JToken value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_DateTimeOffset_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<DateTimeOffset>(intPtr);
			}
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x00063EB4 File Offset: 0x000620B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759949, XrefRangeEnd = 759978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator Nullable<Decimal>(JToken value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_Decimal_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<Decimal>(intPtr);
			}
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x00063EF0 File Offset: 0x000620F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759978, XrefRangeEnd = 760007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator Nullable<double>(JToken value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_Double_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<double>(intPtr);
			}
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x00063F2C File Offset: 0x0006212C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760007, XrefRangeEnd = 760028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator Nullable<char>(JToken value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_Char_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<char>(intPtr);
			}
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x00063F68 File Offset: 0x00062168
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 760046, RefRangeEnd = 760051, XrefRangeStart = 760028, XrefRangeEnd = 760046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator int(JToken value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x00063FAC File Offset: 0x000621AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 760069, RefRangeEnd = 760070, XrefRangeStart = 760051, XrefRangeEnd = 760069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator short(JToken value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Int16_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x00063FF0 File Offset: 0x000621F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 760088, RefRangeEnd = 760089, XrefRangeStart = 760070, XrefRangeEnd = 760088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ushort(JToken value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt16_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x00064034 File Offset: 0x00062234
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 760107, RefRangeEnd = 760108, XrefRangeStart = 760089, XrefRangeEnd = 760107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator char(JToken value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Char_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x00064078 File Offset: 0x00062278
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 760126, RefRangeEnd = 760127, XrefRangeStart = 760108, XrefRangeEnd = 760126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator byte(JToken value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Byte_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x000640BC File Offset: 0x000622BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 760145, RefRangeEnd = 760146, XrefRangeStart = 760127, XrefRangeEnd = 760145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator sbyte(JToken value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_SByte_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x00064100 File Offset: 0x00062300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760146, XrefRangeEnd = 760167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator Nullable<int>(JToken value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_Int32_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x0006413C File Offset: 0x0006233C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760167, XrefRangeEnd = 760188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator Nullable<short>(JToken value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_Int16_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<short>(intPtr);
			}
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x00064178 File Offset: 0x00062378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760188, XrefRangeEnd = 760209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator Nullable<ushort>(JToken value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_UInt16_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<ushort>(intPtr);
			}
		}

		// Token: 0x060011D1 RID: 4561 RVA: 0x000641B4 File Offset: 0x000623B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760209, XrefRangeEnd = 760230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator Nullable<byte>(JToken value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_Byte_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<byte>(intPtr);
			}
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x000641F0 File Offset: 0x000623F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760230, XrefRangeEnd = 760251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator Nullable<sbyte>(JToken value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_SByte_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<sbyte>(intPtr);
			}
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x0006422C File Offset: 0x0006242C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 760269, RefRangeEnd = 760270, XrefRangeStart = 760251, XrefRangeEnd = 760269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator DateTime(JToken value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_DateTime_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x00064270 File Offset: 0x00062470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760270, XrefRangeEnd = 760299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator Nullable<long>(JToken value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_Int64_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<long>(intPtr);
			}
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x000642AC File Offset: 0x000624AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760299, XrefRangeEnd = 760320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator Nullable<float>(JToken value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_Single_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<float>(intPtr);
			}
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x000642E8 File Offset: 0x000624E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 760338, RefRangeEnd = 760339, XrefRangeStart = 760320, XrefRangeEnd = 760338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator Decimal(JToken value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Decimal_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x0006432C File Offset: 0x0006252C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760339, XrefRangeEnd = 760360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator Nullable<uint>(JToken value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_UInt32_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<uint>(intPtr);
			}
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x00064368 File Offset: 0x00062568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760360, XrefRangeEnd = 760389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator Nullable<ulong>(JToken value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_UInt64_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<ulong>(intPtr);
			}
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x000643A4 File Offset: 0x000625A4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 760407, RefRangeEnd = 760411, XrefRangeStart = 760389, XrefRangeEnd = 760407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator double(JToken value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Double_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x000643E8 File Offset: 0x000625E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 760429, RefRangeEnd = 760430, XrefRangeStart = 760411, XrefRangeEnd = 760429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator float(JToken value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Single_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x0006442C File Offset: 0x0006262C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 760452, RefRangeEnd = 760462, XrefRangeStart = 760430, XrefRangeEnd = 760452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator string(JToken value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_String_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x00064468 File Offset: 0x00062668
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 760480, RefRangeEnd = 760481, XrefRangeStart = 760462, XrefRangeEnd = 760480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint(JToken value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x000644AC File Offset: 0x000626AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 760499, RefRangeEnd = 760500, XrefRangeStart = 760481, XrefRangeEnd = 760499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ulong(JToken value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x000644F0 File Offset: 0x000626F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760500, XrefRangeEnd = 760521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator Il2CppStructArray<byte>(JToken value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Il2CppStructArray_1_Byte_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x00064534 File Offset: 0x00062734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760521, XrefRangeEnd = 760547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator Guid(JToken value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Guid_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011E0 RID: 4576 RVA: 0x00064578 File Offset: 0x00062778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760547, XrefRangeEnd = 760579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator Nullable<Guid>(JToken value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_Guid_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<Guid>(intPtr);
			}
		}

		// Token: 0x060011E1 RID: 4577 RVA: 0x000645B4 File Offset: 0x000627B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760579, XrefRangeEnd = 760595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator TimeSpan(JToken value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_TimeSpan_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x000645F8 File Offset: 0x000627F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760595, XrefRangeEnd = 760623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator Nullable<TimeSpan>(JToken value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_TimeSpan_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<TimeSpan>(intPtr);
			}
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x00064634 File Offset: 0x00062834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760623, XrefRangeEnd = 760645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator Uri(JToken value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Explicit_Public_Static_Uri_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x00064678 File Offset: 0x00062878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760645, XrefRangeEnd = 760659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BigInteger ToBigInteger(JToken value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_ToBigInteger_Private_Static_BigInteger_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new BigInteger(intPtr);
			}
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x000646B4 File Offset: 0x000628B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760659, XrefRangeEnd = 760676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Nullable<BigInteger> ToBigIntegerNullable(JToken value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_ToBigIntegerNullable_Private_Static_Nullable_1_BigInteger_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<BigInteger>(intPtr);
			}
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x000646F0 File Offset: 0x000628F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760676, XrefRangeEnd = 760680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator JToken(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x060011E7 RID: 4583 RVA: 0x00064730 File Offset: 0x00062930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760680, XrefRangeEnd = 760684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator JToken(DateTimeOffset value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x00064770 File Offset: 0x00062970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760684, XrefRangeEnd = 760688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator JToken(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x000647B0 File Offset: 0x000629B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760688, XrefRangeEnd = 760695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator JToken(Nullable<byte> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x000647FC File Offset: 0x000629FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760695, XrefRangeEnd = 760699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator JToken(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x0006483C File Offset: 0x00062A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760699, XrefRangeEnd = 760706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator JToken(Nullable<sbyte> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x00064888 File Offset: 0x00062A88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760706, XrefRangeEnd = 760713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator JToken(Nullable<bool> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x000648D4 File Offset: 0x00062AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760713, XrefRangeEnd = 760717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator JToken(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x00064914 File Offset: 0x00062B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760717, XrefRangeEnd = 760724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator JToken(Nullable<DateTime> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x00064960 File Offset: 0x00062B60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760724, XrefRangeEnd = 760731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator JToken(Nullable<DateTimeOffset> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x000649AC File Offset: 0x00062BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760731, XrefRangeEnd = 760738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator JToken(Nullable<Decimal> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x000649F8 File Offset: 0x00062BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760738, XrefRangeEnd = 760745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator JToken(Nullable<double> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x00064A44 File Offset: 0x00062C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760745, XrefRangeEnd = 760749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator JToken(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x060011F3 RID: 4595 RVA: 0x00064A84 File Offset: 0x00062C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760749, XrefRangeEnd = 760753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator JToken(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x00064AC4 File Offset: 0x00062CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760753, XrefRangeEnd = 760757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator JToken(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x00064B04 File Offset: 0x00062D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760757, XrefRangeEnd = 760764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator JToken(Nullable<int> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x00064B50 File Offset: 0x00062D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760764, XrefRangeEnd = 760768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator JToken(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x00064B90 File Offset: 0x00062D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760768, XrefRangeEnd = 760775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator JToken(Nullable<long> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x00064BDC File Offset: 0x00062DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760775, XrefRangeEnd = 760782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator JToken(Nullable<float> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x00064C28 File Offset: 0x00062E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760782, XrefRangeEnd = 760786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator JToken(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x00064C68 File Offset: 0x00062E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760786, XrefRangeEnd = 760793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator JToken(Nullable<short> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x00064CB4 File Offset: 0x00062EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760793, XrefRangeEnd = 760800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator JToken(Nullable<ushort> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x00064D00 File Offset: 0x00062F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760800, XrefRangeEnd = 760807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator JToken(Nullable<uint> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x00064D4C File Offset: 0x00062F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760807, XrefRangeEnd = 760814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator JToken(Nullable<ulong> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x00064D98 File Offset: 0x00062F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760814, XrefRangeEnd = 760818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator JToken(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x00064DD8 File Offset: 0x00062FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760818, XrefRangeEnd = 760822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator JToken(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x00064E18 File Offset: 0x00063018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760822, XrefRangeEnd = 760826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator JToken(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x00064E5C File Offset: 0x0006305C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760826, XrefRangeEnd = 760830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator JToken(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x00064E9C File Offset: 0x0006309C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760830, XrefRangeEnd = 760834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator JToken(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x00064EDC File Offset: 0x000630DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760834, XrefRangeEnd = 760838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator JToken(Il2CppStructArray<byte> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x00064F20 File Offset: 0x00063120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760838, XrefRangeEnd = 760842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator JToken(Uri value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Uri_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x00064F64 File Offset: 0x00063164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760842, XrefRangeEnd = 760846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator JToken(TimeSpan value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x00064FA4 File Offset: 0x000631A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760846, XrefRangeEnd = 760853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator JToken(Nullable<TimeSpan> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x00064FF0 File Offset: 0x000631F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760853, XrefRangeEnd = 760857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator JToken(Guid value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Guid_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x00065030 File Offset: 0x00063230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760857, XrefRangeEnd = 760864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator JToken(Nullable<Guid> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_Guid_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x0006507C File Offset: 0x0006327C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760864, XrefRangeEnd = 760867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600120A RID: 4618 RVA: 0x000650BC File Offset: 0x000632BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760867, XrefRangeEnd = 760873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<JToken> System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<JToken>>(intPtr3) : null;
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x000650FC File Offset: 0x000632FC
		[CallerCount(0)]
		public unsafe virtual int GetDeepHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JToken.NativeMethodInfoPtr_GetDeepHashCode_Internal_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x0600120C RID: 4620 RVA: 0x00065144 File Offset: 0x00063344
		public unsafe virtual IJEnumerable<JToken> Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken>.Item
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_Newtonsoft_Json_Linq_IJEnumerable_Newtonsoft_Json_Linq_JToken__get_Item_Private_Virtual_Final_New_get_IJEnumerable_1_JToken_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IJEnumerable<JToken>>(intPtr3) : null;
				}
			}
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x00065194 File Offset: 0x00063394
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 760877, RefRangeEnd = 760879, XrefRangeStart = 760873, XrefRangeEnd = 760877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonReader CreateReader()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_CreateReader_Public_JsonReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonReader>(intPtr3) : null;
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x000651D4 File Offset: 0x000633D4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 760897, RefRangeEnd = 760903, XrefRangeStart = 760879, XrefRangeEnd = 760897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JToken FromObjectInternal(Object o, JsonSerializer jsonSerializer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(jsonSerializer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_FromObjectInternal_Internal_Static_JToken_Object_JsonSerializer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
		}

		// Token: 0x0600120F RID: 4623 RVA: 0x0006522C File Offset: 0x0006342C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 760908, RefRangeEnd = 760909, XrefRangeStart = 760903, XrefRangeEnd = 760908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JToken FromObject(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_FromObject_Public_Static_JToken_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x00065270 File Offset: 0x00063470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760909, XrefRangeEnd = 760913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JToken FromObject(Object o, JsonSerializer jsonSerializer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(jsonSerializer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_FromObject_Public_Static_JToken_Object_JsonSerializer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x000652C8 File Offset: 0x000634C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760913, XrefRangeEnd = 760923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T ToObject<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.MethodInfoStoreGeneric_ToObject_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x00065304 File Offset: 0x00063504
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 760979, RefRangeEnd = 760981, XrefRangeStart = 760923, XrefRangeEnd = 760979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ToObject(Type objectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_ToObject_Public_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x00065354 File Offset: 0x00063554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760981, XrefRangeEnd = 760991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T ToObject<T>(JsonSerializer jsonSerializer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(jsonSerializer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.MethodInfoStoreGeneric_ToObject_Public_T_JsonSerializer_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x000653A0 File Offset: 0x000635A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 761009, RefRangeEnd = 761011, XrefRangeStart = 760991, XrefRangeEnd = 761009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ToObject(Type objectType, JsonSerializer jsonSerializer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(jsonSerializer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_ToObject_Public_Object_Type_JsonSerializer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x00065404 File Offset: 0x00063604
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 761015, RefRangeEnd = 761020, XrefRangeStart = 761011, XrefRangeEnd = 761015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JToken ReadFrom(JsonReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_ReadFrom_Public_Static_JToken_JsonReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x00065448 File Offset: 0x00063648
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 761032, RefRangeEnd = 761036, XrefRangeStart = 761020, XrefRangeEnd = 761032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JToken ReadFrom(JsonReader reader, JsonLoadSettings settings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_ReadFrom_Public_Static_JToken_JsonReader_JsonLoadSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x000654A0 File Offset: 0x000636A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 761040, RefRangeEnd = 761042, XrefRangeStart = 761036, XrefRangeEnd = 761040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JToken Parse(string json)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_Parse_Public_Static_JToken_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x000654E4 File Offset: 0x000636E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 761063, RefRangeEnd = 761064, XrefRangeStart = 761042, XrefRangeEnd = 761063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JToken Parse(string json, JsonLoadSettings settings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_Parse_Public_Static_JToken_String_JsonLoadSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x0006553C File Offset: 0x0006373C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 761064, XrefRangeEnd = 761068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JToken Load(JsonReader reader, JsonLoadSettings settings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_Load_Public_Static_JToken_JsonReader_JsonLoadSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x00065594 File Offset: 0x00063794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 761068, XrefRangeEnd = 761075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JToken Load(JsonReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_Load_Public_Static_JToken_JsonReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x000655D8 File Offset: 0x000637D8
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 761087, RefRangeEnd = 761109, XrefRangeStart = 761075, XrefRangeEnd = 761087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLineInfo(IJsonLineInfo lineInfo, JsonLoadSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lineInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_SetLineInfo_Internal_Void_IJsonLineInfo_JsonLoadSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600121C RID: 4636 RVA: 0x0006562C File Offset: 0x0006382C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 761109, XrefRangeEnd = 761114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLineInfo(int lineNumber, int linePosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lineNumber;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_SetLineInfo_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x00065678 File Offset: 0x00063878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 761114, XrefRangeEnd = 761117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Newtonsoft_Json_IJsonLineInfo_HasLineInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_Newtonsoft_Json_IJsonLineInfo_HasLineInfo_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x0600121E RID: 4638 RVA: 0x000656B4 File Offset: 0x000638B4
		public unsafe virtual int Newtonsoft.Json.IJsonLineInfo.LineNumber
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 761117, XrefRangeEnd = 761120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_Newtonsoft_Json_IJsonLineInfo_get_LineNumber_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x0600121F RID: 4639 RVA: 0x000656F0 File Offset: 0x000638F0
		public unsafe virtual int Newtonsoft.Json.IJsonLineInfo.LinePosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 761120, XrefRangeEnd = 761123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_Newtonsoft_Json_IJsonLineInfo_get_LinePosition_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x0006572C File Offset: 0x0006392C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 761123, XrefRangeEnd = 761124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JToken SelectToken(string path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_SelectToken_Public_JToken_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x0006577C File Offset: 0x0006397C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 761124, XrefRangeEnd = 761131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JToken SelectToken(string path, bool errorWhenNoMatch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref errorWhenNoMatch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_SelectToken_Public_JToken_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
		}

		// Token: 0x06001222 RID: 4642 RVA: 0x000657DC File Offset: 0x000639DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 761152, RefRangeEnd = 761154, XrefRangeStart = 761131, XrefRangeEnd = 761152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JToken SelectToken(string path, JsonSelectSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_SelectToken_Public_JToken_String_JsonSelectSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
		}

		// Token: 0x06001223 RID: 4643 RVA: 0x00065840 File Offset: 0x00063A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 761154, XrefRangeEnd = 761155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<JToken> SelectTokens(string path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_SelectTokens_Public_IEnumerable_1_JToken_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<JToken>>(intPtr3) : null;
			}
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x00065890 File Offset: 0x00063A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 761155, XrefRangeEnd = 761162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<JToken> SelectTokens(string path, bool errorWhenNoMatch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref errorWhenNoMatch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_SelectTokens_Public_IEnumerable_1_JToken_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<JToken>>(intPtr3) : null;
		}

		// Token: 0x06001225 RID: 4645 RVA: 0x000658F0 File Offset: 0x00063AF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 761167, RefRangeEnd = 761169, XrefRangeStart = 761162, XrefRangeEnd = 761167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<JToken> SelectTokens(string path, JsonSelectSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_SelectTokens_Public_IEnumerable_1_JToken_String_JsonSelectSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<JToken>>(intPtr3) : null;
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x00065954 File Offset: 0x00063B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 761169, XrefRangeEnd = 761181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DynamicMetaObject GetMetaObject(Expression parameter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JToken.NativeMethodInfoPtr_GetMetaObject_Protected_Virtual_New_DynamicMetaObject_Expression_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
			}
		}

		// Token: 0x06001227 RID: 4647 RVA: 0x000659B0 File Offset: 0x00063BB0
		[CallerCount(0)]
		public unsafe virtual DynamicMetaObject System_Dynamic_IDynamicMetaObjectProvider_GetMetaObject(Expression parameter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_System_Dynamic_IDynamicMetaObjectProvider_GetMetaObject_Private_Virtual_Final_New_DynamicMetaObject_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
			}
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x00065A00 File Offset: 0x00063C00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 463996, RefRangeEnd = 463998, XrefRangeStart = 463996, XrefRangeEnd = 463998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object System_ICloneable_Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x00065A40 File Offset: 0x00063C40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 463996, RefRangeEnd = 463998, XrefRangeStart = 463996, XrefRangeEnd = 463998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JToken DeepClone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_DeepClone_Public_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x00065A80 File Offset: 0x00063C80
		[CallerCount(0)]
		public unsafe JToken DeepClone(JsonCloneSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_DeepClone_Public_JToken_JsonCloneSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x00065AD0 File Offset: 0x00063CD0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 761205, RefRangeEnd = 761208, XrefRangeStart = 761181, XrefRangeEnd = 761205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddAnnotation(Object annotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(annotation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_AddAnnotation_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x00065B14 File Offset: 0x00063D14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 761224, RefRangeEnd = 761227, XrefRangeStart = 761208, XrefRangeEnd = 761224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Annotation<T>() where T : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.MethodInfoStoreGeneric_Annotation_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x00065B50 File Offset: 0x00063D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 761227, XrefRangeEnd = 761235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Annotation(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_Annotation_Public_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x00065BA0 File Offset: 0x00063DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 761235, XrefRangeEnd = 761240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<T> Annotations<T>() where T : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.MethodInfoStoreGeneric_Annotations_Public_IEnumerable_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x00065BE0 File Offset: 0x00063DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 761240, XrefRangeEnd = 761247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Object> Annotations(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_Annotations_Public_IEnumerable_1_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x00065C30 File Offset: 0x00063E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 761247, XrefRangeEnd = 761257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAnnotations<T>() where T : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.MethodInfoStoreGeneric_RemoveAnnotations_Public_Void_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x00065C64 File Offset: 0x00063E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 761257, XrefRangeEnd = 761268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAnnotations(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_RemoveAnnotations_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x00065CA8 File Offset: 0x00063EA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 761277, RefRangeEnd = 761279, XrefRangeStart = 761268, XrefRangeEnd = 761277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyAnnotations(JToken target, JToken source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.NativeMethodInfoPtr_CopyAnnotations_Internal_Void_JToken_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x00007A36 File Offset: 0x00005C36
		public virtual Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, params JsonConverter[] converters)
		{
			return this.WriteToAsync(writer, cancellationToken, new Il2CppReferenceArray<JsonConverter>(converters));
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x00007A46 File Offset: 0x00005C46
		public Task WriteToAsync(JsonWriter writer, params JsonConverter[] converters)
		{
			return this.WriteToAsync(writer, new Il2CppReferenceArray<JsonConverter>(converters));
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x00007A55 File Offset: 0x00005C55
		public virtual void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
			this.WriteTo(writer, new Il2CppReferenceArray<JsonConverter>(converters));
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x00007A64 File Offset: 0x00005C64
		public string ToString(Formatting formatting, params JsonConverter[] converters)
		{
			return this.ToString(formatting, new Il2CppReferenceArray<JsonConverter>(converters));
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x00007A73 File Offset: 0x00005C73
		public JToken(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06001238 RID: 4664 RVA: 0x00065CFC File Offset: 0x00063EFC
		// (set) Token: 0x06001239 RID: 4665 RVA: 0x00007A7C File Offset: 0x00005C7C
		public unsafe static JTokenEqualityComparer _equalityComparer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JToken.NativeFieldInfoPtr__equalityComparer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JTokenEqualityComparer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JToken.NativeFieldInfoPtr__equalityComparer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x0600123A RID: 4666 RVA: 0x00065D24 File Offset: 0x00063F24
		// (set) Token: 0x0600123B RID: 4667 RVA: 0x00007A8E File Offset: 0x00005C8E
		public unsafe JContainer _parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken.NativeFieldInfoPtr__parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken.NativeFieldInfoPtr__parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x0600123C RID: 4668 RVA: 0x00065D54 File Offset: 0x00063F54
		// (set) Token: 0x0600123D RID: 4669 RVA: 0x00007AAD File Offset: 0x00005CAD
		public unsafe JToken _previous
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken.NativeFieldInfoPtr__previous);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken.NativeFieldInfoPtr__previous), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x0600123E RID: 4670 RVA: 0x00065D84 File Offset: 0x00063F84
		// (set) Token: 0x0600123F RID: 4671 RVA: 0x00007ACC File Offset: 0x00005CCC
		public unsafe JToken _next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken.NativeFieldInfoPtr__next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken.NativeFieldInfoPtr__next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06001240 RID: 4672 RVA: 0x00065DB4 File Offset: 0x00063FB4
		// (set) Token: 0x06001241 RID: 4673 RVA: 0x00007AEB File Offset: 0x00005CEB
		public unsafe Object _annotations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken.NativeFieldInfoPtr__annotations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken.NativeFieldInfoPtr__annotations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06001242 RID: 4674 RVA: 0x00065DE4 File Offset: 0x00063FE4
		// (set) Token: 0x06001243 RID: 4675 RVA: 0x00007B0A File Offset: 0x00005D0A
		public unsafe static Il2CppStructArray<JTokenType> BooleanTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JToken.NativeFieldInfoPtr_BooleanTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<JTokenType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JToken.NativeFieldInfoPtr_BooleanTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06001244 RID: 4676 RVA: 0x00065E0C File Offset: 0x0006400C
		// (set) Token: 0x06001245 RID: 4677 RVA: 0x00007B1C File Offset: 0x00005D1C
		public unsafe static Il2CppStructArray<JTokenType> NumberTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JToken.NativeFieldInfoPtr_NumberTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<JTokenType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JToken.NativeFieldInfoPtr_NumberTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06001246 RID: 4678 RVA: 0x00065E34 File Offset: 0x00064034
		// (set) Token: 0x06001247 RID: 4679 RVA: 0x00007B2E File Offset: 0x00005D2E
		public unsafe static Il2CppStructArray<JTokenType> BigIntegerTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JToken.NativeFieldInfoPtr_BigIntegerTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<JTokenType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JToken.NativeFieldInfoPtr_BigIntegerTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06001248 RID: 4680 RVA: 0x00065E5C File Offset: 0x0006405C
		// (set) Token: 0x06001249 RID: 4681 RVA: 0x00007B40 File Offset: 0x00005D40
		public unsafe static Il2CppStructArray<JTokenType> StringTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JToken.NativeFieldInfoPtr_StringTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<JTokenType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JToken.NativeFieldInfoPtr_StringTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x0600124A RID: 4682 RVA: 0x00065E84 File Offset: 0x00064084
		// (set) Token: 0x0600124B RID: 4683 RVA: 0x00007B52 File Offset: 0x00005D52
		public unsafe static Il2CppStructArray<JTokenType> GuidTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JToken.NativeFieldInfoPtr_GuidTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<JTokenType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JToken.NativeFieldInfoPtr_GuidTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x0600124C RID: 4684 RVA: 0x00065EAC File Offset: 0x000640AC
		// (set) Token: 0x0600124D RID: 4685 RVA: 0x00007B64 File Offset: 0x00005D64
		public unsafe static Il2CppStructArray<JTokenType> TimeSpanTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JToken.NativeFieldInfoPtr_TimeSpanTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<JTokenType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JToken.NativeFieldInfoPtr_TimeSpanTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x0600124E RID: 4686 RVA: 0x00065ED4 File Offset: 0x000640D4
		// (set) Token: 0x0600124F RID: 4687 RVA: 0x00007B76 File Offset: 0x00005D76
		public unsafe static Il2CppStructArray<JTokenType> UriTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JToken.NativeFieldInfoPtr_UriTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<JTokenType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JToken.NativeFieldInfoPtr_UriTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06001250 RID: 4688 RVA: 0x00065EFC File Offset: 0x000640FC
		// (set) Token: 0x06001251 RID: 4689 RVA: 0x00007B88 File Offset: 0x00005D88
		public unsafe static Il2CppStructArray<JTokenType> CharTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JToken.NativeFieldInfoPtr_CharTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<JTokenType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JToken.NativeFieldInfoPtr_CharTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06001252 RID: 4690 RVA: 0x00065F24 File Offset: 0x00064124
		// (set) Token: 0x06001253 RID: 4691 RVA: 0x00007B9A File Offset: 0x00005D9A
		public unsafe static Il2CppStructArray<JTokenType> DateTimeTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JToken.NativeFieldInfoPtr_DateTimeTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<JTokenType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JToken.NativeFieldInfoPtr_DateTimeTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06001254 RID: 4692 RVA: 0x00065F4C File Offset: 0x0006414C
		// (set) Token: 0x06001255 RID: 4693 RVA: 0x00007BAC File Offset: 0x00005DAC
		public unsafe static Il2CppStructArray<JTokenType> BytesTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JToken.NativeFieldInfoPtr_BytesTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<JTokenType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JToken.NativeFieldInfoPtr_BytesTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E22 RID: 3618
		private static readonly IntPtr NativeFieldInfoPtr__equalityComparer;

		// Token: 0x04000E23 RID: 3619
		private static readonly IntPtr NativeFieldInfoPtr__parent;

		// Token: 0x04000E24 RID: 3620
		private static readonly IntPtr NativeFieldInfoPtr__previous;

		// Token: 0x04000E25 RID: 3621
		private static readonly IntPtr NativeFieldInfoPtr__next;

		// Token: 0x04000E26 RID: 3622
		private static readonly IntPtr NativeFieldInfoPtr__annotations;

		// Token: 0x04000E27 RID: 3623
		private static readonly IntPtr NativeFieldInfoPtr_BooleanTypes;

		// Token: 0x04000E28 RID: 3624
		private static readonly IntPtr NativeFieldInfoPtr_NumberTypes;

		// Token: 0x04000E29 RID: 3625
		private static readonly IntPtr NativeFieldInfoPtr_BigIntegerTypes;

		// Token: 0x04000E2A RID: 3626
		private static readonly IntPtr NativeFieldInfoPtr_StringTypes;

		// Token: 0x04000E2B RID: 3627
		private static readonly IntPtr NativeFieldInfoPtr_GuidTypes;

		// Token: 0x04000E2C RID: 3628
		private static readonly IntPtr NativeFieldInfoPtr_TimeSpanTypes;

		// Token: 0x04000E2D RID: 3629
		private static readonly IntPtr NativeFieldInfoPtr_UriTypes;

		// Token: 0x04000E2E RID: 3630
		private static readonly IntPtr NativeFieldInfoPtr_CharTypes;

		// Token: 0x04000E2F RID: 3631
		private static readonly IntPtr NativeFieldInfoPtr_DateTimeTypes;

		// Token: 0x04000E30 RID: 3632
		private static readonly IntPtr NativeFieldInfoPtr_BytesTypes;

		// Token: 0x04000E31 RID: 3633
		private static readonly IntPtr NativeMethodInfoPtr_WriteToAsync_Public_Virtual_New_Task_JsonWriter_CancellationToken_Il2CppReferenceArray_1_JsonConverter_0;

		// Token: 0x04000E32 RID: 3634
		private static readonly IntPtr NativeMethodInfoPtr_WriteToAsync_Public_Task_JsonWriter_Il2CppReferenceArray_1_JsonConverter_0;

		// Token: 0x04000E33 RID: 3635
		private static readonly IntPtr NativeMethodInfoPtr_ReadFromAsync_Public_Static_Task_1_JToken_JsonReader_CancellationToken_0;

		// Token: 0x04000E34 RID: 3636
		private static readonly IntPtr NativeMethodInfoPtr_ReadFromAsync_Public_Static_Task_1_JToken_JsonReader_JsonLoadSettings_CancellationToken_0;

		// Token: 0x04000E35 RID: 3637
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsync_Public_Static_Task_1_JToken_JsonReader_CancellationToken_0;

		// Token: 0x04000E36 RID: 3638
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsync_Public_Static_Task_1_JToken_JsonReader_JsonLoadSettings_CancellationToken_0;

		// Token: 0x04000E37 RID: 3639
		private static readonly IntPtr NativeMethodInfoPtr_get_EqualityComparer_Public_Static_get_JTokenEqualityComparer_0;

		// Token: 0x04000E38 RID: 3640
		private static readonly IntPtr NativeMethodInfoPtr_get_Parent_Public_get_JContainer_0;

		// Token: 0x04000E39 RID: 3641
		private static readonly IntPtr NativeMethodInfoPtr_set_Parent_Internal_set_Void_JContainer_0;

		// Token: 0x04000E3A RID: 3642
		private static readonly IntPtr NativeMethodInfoPtr_get_Root_Public_get_JToken_0;

		// Token: 0x04000E3B RID: 3643
		private static readonly IntPtr NativeMethodInfoPtr_CloneToken_Internal_Abstract_Virtual_New_JToken_JsonCloneSettings_0;

		// Token: 0x04000E3C RID: 3644
		private static readonly IntPtr NativeMethodInfoPtr_DeepEquals_Internal_Abstract_Virtual_New_Boolean_JToken_0;

		// Token: 0x04000E3D RID: 3645
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Abstract_Virtual_New_get_JTokenType_0;

		// Token: 0x04000E3E RID: 3646
		private static readonly IntPtr NativeMethodInfoPtr_get_HasValues_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000E3F RID: 3647
		private static readonly IntPtr NativeMethodInfoPtr_DeepEquals_Public_Static_Boolean_JToken_JToken_0;

		// Token: 0x04000E40 RID: 3648
		private static readonly IntPtr NativeMethodInfoPtr_get_Next_Public_get_JToken_0;

		// Token: 0x04000E41 RID: 3649
		private static readonly IntPtr NativeMethodInfoPtr_set_Next_Internal_set_Void_JToken_0;

		// Token: 0x04000E42 RID: 3650
		private static readonly IntPtr NativeMethodInfoPtr_get_Previous_Public_get_JToken_0;

		// Token: 0x04000E43 RID: 3651
		private static readonly IntPtr NativeMethodInfoPtr_set_Previous_Internal_set_Void_JToken_0;

		// Token: 0x04000E44 RID: 3652
		private static readonly IntPtr NativeMethodInfoPtr_get_Path_Public_get_String_0;

		// Token: 0x04000E45 RID: 3653
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000E46 RID: 3654
		private static readonly IntPtr NativeMethodInfoPtr_AddAfterSelf_Public_Void_Object_0;

		// Token: 0x04000E47 RID: 3655
		private static readonly IntPtr NativeMethodInfoPtr_AddBeforeSelf_Public_Void_Object_0;

		// Token: 0x04000E48 RID: 3656
		private static readonly IntPtr NativeMethodInfoPtr_Ancestors_Public_IEnumerable_1_JToken_0;

		// Token: 0x04000E49 RID: 3657
		private static readonly IntPtr NativeMethodInfoPtr_AncestorsAndSelf_Public_IEnumerable_1_JToken_0;

		// Token: 0x04000E4A RID: 3658
		private static readonly IntPtr NativeMethodInfoPtr_GetAncestors_Internal_IEnumerable_1_JToken_Boolean_0;

		// Token: 0x04000E4B RID: 3659
		private static readonly IntPtr NativeMethodInfoPtr_AfterSelf_Public_IEnumerable_1_JToken_0;

		// Token: 0x04000E4C RID: 3660
		private static readonly IntPtr NativeMethodInfoPtr_BeforeSelf_Public_IEnumerable_1_JToken_0;

		// Token: 0x04000E4D RID: 3661
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_JToken_Object_0;

		// Token: 0x04000E4E RID: 3662
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Object_JToken_0;

		// Token: 0x04000E4F RID: 3663
		private static readonly IntPtr NativeMethodInfoPtr_Value_Public_Virtual_New_T_Object_0;

		// Token: 0x04000E50 RID: 3664
		private static readonly IntPtr NativeMethodInfoPtr_get_First_Public_Virtual_New_get_JToken_0;

		// Token: 0x04000E51 RID: 3665
		private static readonly IntPtr NativeMethodInfoPtr_get_Last_Public_Virtual_New_get_JToken_0;

		// Token: 0x04000E52 RID: 3666
		private static readonly IntPtr NativeMethodInfoPtr_Children_Public_Virtual_New_JEnumerable_1_JToken_0;

		// Token: 0x04000E53 RID: 3667
		private static readonly IntPtr NativeMethodInfoPtr_Children_Public_JEnumerable_1_T_0;

		// Token: 0x04000E54 RID: 3668
		private static readonly IntPtr NativeMethodInfoPtr_Values_Public_Virtual_New_IEnumerable_1_T_0;

		// Token: 0x04000E55 RID: 3669
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_0;

		// Token: 0x04000E56 RID: 3670
		private static readonly IntPtr NativeMethodInfoPtr_Replace_Public_Void_JToken_0;

		// Token: 0x04000E57 RID: 3671
		private static readonly IntPtr NativeMethodInfoPtr_WriteTo_Public_Abstract_Virtual_New_Void_JsonWriter_Il2CppReferenceArray_1_JsonConverter_0;

		// Token: 0x04000E58 RID: 3672
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000E59 RID: 3673
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_Formatting_Il2CppReferenceArray_1_JsonConverter_0;

		// Token: 0x04000E5A RID: 3674
		private static readonly IntPtr NativeMethodInfoPtr_EnsureValue_Private_Static_JValue_JToken_0;

		// Token: 0x04000E5B RID: 3675
		private static readonly IntPtr NativeMethodInfoPtr_GetType_Private_Static_String_JToken_0;

		// Token: 0x04000E5C RID: 3676
		private static readonly IntPtr NativeMethodInfoPtr_ValidateToken_Private_Static_Boolean_JToken_Il2CppStructArray_1_JTokenType_Boolean_0;

		// Token: 0x04000E5D RID: 3677
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Boolean_JToken_0;

		// Token: 0x04000E5E RID: 3678
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_DateTimeOffset_JToken_0;

		// Token: 0x04000E5F RID: 3679
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_Boolean_JToken_0;

		// Token: 0x04000E60 RID: 3680
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Int64_JToken_0;

		// Token: 0x04000E61 RID: 3681
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_DateTime_JToken_0;

		// Token: 0x04000E62 RID: 3682
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_DateTimeOffset_JToken_0;

		// Token: 0x04000E63 RID: 3683
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_Decimal_JToken_0;

		// Token: 0x04000E64 RID: 3684
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_Double_JToken_0;

		// Token: 0x04000E65 RID: 3685
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_Char_JToken_0;

		// Token: 0x04000E66 RID: 3686
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_JToken_0;

		// Token: 0x04000E67 RID: 3687
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Int16_JToken_0;

		// Token: 0x04000E68 RID: 3688
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt16_JToken_0;

		// Token: 0x04000E69 RID: 3689
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Char_JToken_0;

		// Token: 0x04000E6A RID: 3690
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Byte_JToken_0;

		// Token: 0x04000E6B RID: 3691
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_SByte_JToken_0;

		// Token: 0x04000E6C RID: 3692
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_Int32_JToken_0;

		// Token: 0x04000E6D RID: 3693
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_Int16_JToken_0;

		// Token: 0x04000E6E RID: 3694
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_UInt16_JToken_0;

		// Token: 0x04000E6F RID: 3695
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_Byte_JToken_0;

		// Token: 0x04000E70 RID: 3696
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_SByte_JToken_0;

		// Token: 0x04000E71 RID: 3697
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_DateTime_JToken_0;

		// Token: 0x04000E72 RID: 3698
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_Int64_JToken_0;

		// Token: 0x04000E73 RID: 3699
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_Single_JToken_0;

		// Token: 0x04000E74 RID: 3700
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Decimal_JToken_0;

		// Token: 0x04000E75 RID: 3701
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_UInt32_JToken_0;

		// Token: 0x04000E76 RID: 3702
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_UInt64_JToken_0;

		// Token: 0x04000E77 RID: 3703
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Double_JToken_0;

		// Token: 0x04000E78 RID: 3704
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Single_JToken_0;

		// Token: 0x04000E79 RID: 3705
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_String_JToken_0;

		// Token: 0x04000E7A RID: 3706
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_JToken_0;

		// Token: 0x04000E7B RID: 3707
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_JToken_0;

		// Token: 0x04000E7C RID: 3708
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Il2CppStructArray_1_Byte_JToken_0;

		// Token: 0x04000E7D RID: 3709
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Guid_JToken_0;

		// Token: 0x04000E7E RID: 3710
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_Guid_JToken_0;

		// Token: 0x04000E7F RID: 3711
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_TimeSpan_JToken_0;

		// Token: 0x04000E80 RID: 3712
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Nullable_1_TimeSpan_JToken_0;

		// Token: 0x04000E81 RID: 3713
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Uri_JToken_0;

		// Token: 0x04000E82 RID: 3714
		private static readonly IntPtr NativeMethodInfoPtr_ToBigInteger_Private_Static_BigInteger_JToken_0;

		// Token: 0x04000E83 RID: 3715
		private static readonly IntPtr NativeMethodInfoPtr_ToBigIntegerNullable_Private_Static_Nullable_1_BigInteger_JToken_0;

		// Token: 0x04000E84 RID: 3716
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Boolean_0;

		// Token: 0x04000E85 RID: 3717
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_DateTimeOffset_0;

		// Token: 0x04000E86 RID: 3718
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Byte_0;

		// Token: 0x04000E87 RID: 3719
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_Byte_0;

		// Token: 0x04000E88 RID: 3720
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_SByte_0;

		// Token: 0x04000E89 RID: 3721
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_SByte_0;

		// Token: 0x04000E8A RID: 3722
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_Boolean_0;

		// Token: 0x04000E8B RID: 3723
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Int64_0;

		// Token: 0x04000E8C RID: 3724
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_DateTime_0;

		// Token: 0x04000E8D RID: 3725
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_DateTimeOffset_0;

		// Token: 0x04000E8E RID: 3726
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_Decimal_0;

		// Token: 0x04000E8F RID: 3727
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_Double_0;

		// Token: 0x04000E90 RID: 3728
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Int16_0;

		// Token: 0x04000E91 RID: 3729
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_UInt16_0;

		// Token: 0x04000E92 RID: 3730
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Int32_0;

		// Token: 0x04000E93 RID: 3731
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_Int32_0;

		// Token: 0x04000E94 RID: 3732
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_DateTime_0;

		// Token: 0x04000E95 RID: 3733
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_Int64_0;

		// Token: 0x04000E96 RID: 3734
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_Single_0;

		// Token: 0x04000E97 RID: 3735
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Decimal_0;

		// Token: 0x04000E98 RID: 3736
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_Int16_0;

		// Token: 0x04000E99 RID: 3737
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_UInt16_0;

		// Token: 0x04000E9A RID: 3738
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_UInt32_0;

		// Token: 0x04000E9B RID: 3739
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_UInt64_0;

		// Token: 0x04000E9C RID: 3740
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Double_0;

		// Token: 0x04000E9D RID: 3741
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Single_0;

		// Token: 0x04000E9E RID: 3742
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_String_0;

		// Token: 0x04000E9F RID: 3743
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_UInt32_0;

		// Token: 0x04000EA0 RID: 3744
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_UInt64_0;

		// Token: 0x04000EA1 RID: 3745
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000EA2 RID: 3746
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Uri_0;

		// Token: 0x04000EA3 RID: 3747
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_TimeSpan_0;

		// Token: 0x04000EA4 RID: 3748
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_TimeSpan_0;

		// Token: 0x04000EA5 RID: 3749
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Guid_0;

		// Token: 0x04000EA6 RID: 3750
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_JToken_Nullable_1_Guid_0;

		// Token: 0x04000EA7 RID: 3751
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04000EA8 RID: 3752
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JToken_0;

		// Token: 0x04000EA9 RID: 3753
		private static readonly IntPtr NativeMethodInfoPtr_GetDeepHashCode_Internal_Abstract_Virtual_New_Int32_0;

		// Token: 0x04000EAA RID: 3754
		private static readonly IntPtr NativeMethodInfoPtr_Newtonsoft_Json_Linq_IJEnumerable_Newtonsoft_Json_Linq_JToken__get_Item_Private_Virtual_Final_New_get_IJEnumerable_1_JToken_Object_0;

		// Token: 0x04000EAB RID: 3755
		private static readonly IntPtr NativeMethodInfoPtr_CreateReader_Public_JsonReader_0;

		// Token: 0x04000EAC RID: 3756
		private static readonly IntPtr NativeMethodInfoPtr_FromObjectInternal_Internal_Static_JToken_Object_JsonSerializer_0;

		// Token: 0x04000EAD RID: 3757
		private static readonly IntPtr NativeMethodInfoPtr_FromObject_Public_Static_JToken_Object_0;

		// Token: 0x04000EAE RID: 3758
		private static readonly IntPtr NativeMethodInfoPtr_FromObject_Public_Static_JToken_Object_JsonSerializer_0;

		// Token: 0x04000EAF RID: 3759
		private static readonly IntPtr NativeMethodInfoPtr_ToObject_Public_T_0;

		// Token: 0x04000EB0 RID: 3760
		private static readonly IntPtr NativeMethodInfoPtr_ToObject_Public_Object_Type_0;

		// Token: 0x04000EB1 RID: 3761
		private static readonly IntPtr NativeMethodInfoPtr_ToObject_Public_T_JsonSerializer_0;

		// Token: 0x04000EB2 RID: 3762
		private static readonly IntPtr NativeMethodInfoPtr_ToObject_Public_Object_Type_JsonSerializer_0;

		// Token: 0x04000EB3 RID: 3763
		private static readonly IntPtr NativeMethodInfoPtr_ReadFrom_Public_Static_JToken_JsonReader_0;

		// Token: 0x04000EB4 RID: 3764
		private static readonly IntPtr NativeMethodInfoPtr_ReadFrom_Public_Static_JToken_JsonReader_JsonLoadSettings_0;

		// Token: 0x04000EB5 RID: 3765
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_JToken_String_0;

		// Token: 0x04000EB6 RID: 3766
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_JToken_String_JsonLoadSettings_0;

		// Token: 0x04000EB7 RID: 3767
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Static_JToken_JsonReader_JsonLoadSettings_0;

		// Token: 0x04000EB8 RID: 3768
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Static_JToken_JsonReader_0;

		// Token: 0x04000EB9 RID: 3769
		private static readonly IntPtr NativeMethodInfoPtr_SetLineInfo_Internal_Void_IJsonLineInfo_JsonLoadSettings_0;

		// Token: 0x04000EBA RID: 3770
		private static readonly IntPtr NativeMethodInfoPtr_SetLineInfo_Internal_Void_Int32_Int32_0;

		// Token: 0x04000EBB RID: 3771
		private static readonly IntPtr NativeMethodInfoPtr_Newtonsoft_Json_IJsonLineInfo_HasLineInfo_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04000EBC RID: 3772
		private static readonly IntPtr NativeMethodInfoPtr_Newtonsoft_Json_IJsonLineInfo_get_LineNumber_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000EBD RID: 3773
		private static readonly IntPtr NativeMethodInfoPtr_Newtonsoft_Json_IJsonLineInfo_get_LinePosition_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000EBE RID: 3774
		private static readonly IntPtr NativeMethodInfoPtr_SelectToken_Public_JToken_String_0;

		// Token: 0x04000EBF RID: 3775
		private static readonly IntPtr NativeMethodInfoPtr_SelectToken_Public_JToken_String_Boolean_0;

		// Token: 0x04000EC0 RID: 3776
		private static readonly IntPtr NativeMethodInfoPtr_SelectToken_Public_JToken_String_JsonSelectSettings_0;

		// Token: 0x04000EC1 RID: 3777
		private static readonly IntPtr NativeMethodInfoPtr_SelectTokens_Public_IEnumerable_1_JToken_String_0;

		// Token: 0x04000EC2 RID: 3778
		private static readonly IntPtr NativeMethodInfoPtr_SelectTokens_Public_IEnumerable_1_JToken_String_Boolean_0;

		// Token: 0x04000EC3 RID: 3779
		private static readonly IntPtr NativeMethodInfoPtr_SelectTokens_Public_IEnumerable_1_JToken_String_JsonSelectSettings_0;

		// Token: 0x04000EC4 RID: 3780
		private static readonly IntPtr NativeMethodInfoPtr_GetMetaObject_Protected_Virtual_New_DynamicMetaObject_Expression_0;

		// Token: 0x04000EC5 RID: 3781
		private static readonly IntPtr NativeMethodInfoPtr_System_Dynamic_IDynamicMetaObjectProvider_GetMetaObject_Private_Virtual_Final_New_DynamicMetaObject_Expression_0;

		// Token: 0x04000EC6 RID: 3782
		private static readonly IntPtr NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0;

		// Token: 0x04000EC7 RID: 3783
		private static readonly IntPtr NativeMethodInfoPtr_DeepClone_Public_JToken_0;

		// Token: 0x04000EC8 RID: 3784
		private static readonly IntPtr NativeMethodInfoPtr_DeepClone_Public_JToken_JsonCloneSettings_0;

		// Token: 0x04000EC9 RID: 3785
		private static readonly IntPtr NativeMethodInfoPtr_AddAnnotation_Public_Void_Object_0;

		// Token: 0x04000ECA RID: 3786
		private static readonly IntPtr NativeMethodInfoPtr_Annotation_Public_T_0;

		// Token: 0x04000ECB RID: 3787
		private static readonly IntPtr NativeMethodInfoPtr_Annotation_Public_Object_Type_0;

		// Token: 0x04000ECC RID: 3788
		private static readonly IntPtr NativeMethodInfoPtr_Annotations_Public_IEnumerable_1_T_0;

		// Token: 0x04000ECD RID: 3789
		private static readonly IntPtr NativeMethodInfoPtr_Annotations_Public_IEnumerable_1_Object_Type_0;

		// Token: 0x04000ECE RID: 3790
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAnnotations_Public_Void_0;

		// Token: 0x04000ECF RID: 3791
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAnnotations_Public_Void_Type_0;

		// Token: 0x04000ED0 RID: 3792
		private static readonly IntPtr NativeMethodInfoPtr_CopyAnnotations_Internal_Void_JToken_JToken_0;

		// Token: 0x02000209 RID: 521
		public class LineInfoAnnotation : Object
		{
			// Token: 0x060020BF RID: 8383 RVA: 0x00093498 File Offset: 0x00091698
			// Note: this type is marked as 'beforefieldinit'.
			static LineInfoAnnotation()
			{
				Il2CppClassPointerStore<JToken.LineInfoAnnotation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JToken>.NativeClassPtr, "LineInfoAnnotation");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JToken.LineInfoAnnotation>.NativeClassPtr);
				JToken.LineInfoAnnotation.NativeFieldInfoPtr_LineNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken.LineInfoAnnotation>.NativeClassPtr, "LineNumber");
				JToken.LineInfoAnnotation.NativeFieldInfoPtr_LinePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken.LineInfoAnnotation>.NativeClassPtr, "LinePosition");
				JToken.LineInfoAnnotation.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken.LineInfoAnnotation>.NativeClassPtr, 100666698);
			}

			// Token: 0x060020C0 RID: 8384 RVA: 0x00093500 File Offset: 0x00091700
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 313224, RefRangeEnd = 313226, XrefRangeStart = 313224, XrefRangeEnd = 313226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LineInfoAnnotation(int lineNumber, int linePosition)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JToken.LineInfoAnnotation>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref lineNumber;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken.LineInfoAnnotation.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020C1 RID: 8385 RVA: 0x000107D4 File Offset: 0x0000E9D4
			public LineInfoAnnotation(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000943 RID: 2371
			// (get) Token: 0x060020C2 RID: 8386 RVA: 0x00093558 File Offset: 0x00091758
			// (set) Token: 0x060020C3 RID: 8387 RVA: 0x000107DD File Offset: 0x0000E9DD
			public unsafe int LineNumber
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken.LineInfoAnnotation.NativeFieldInfoPtr_LineNumber);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken.LineInfoAnnotation.NativeFieldInfoPtr_LineNumber)) = value;
				}
			}

			// Token: 0x17000944 RID: 2372
			// (get) Token: 0x060020C4 RID: 8388 RVA: 0x00093580 File Offset: 0x00091780
			// (set) Token: 0x060020C5 RID: 8389 RVA: 0x000107F8 File Offset: 0x0000E9F8
			public unsafe int LinePosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken.LineInfoAnnotation.NativeFieldInfoPtr_LinePosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken.LineInfoAnnotation.NativeFieldInfoPtr_LinePosition)) = value;
				}
			}

			// Token: 0x04001786 RID: 6022
			private static readonly IntPtr NativeFieldInfoPtr_LineNumber;

			// Token: 0x04001787 RID: 6023
			private static readonly IntPtr NativeFieldInfoPtr_LinePosition;

			// Token: 0x04001788 RID: 6024
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;
		}

		// Token: 0x0200020A RID: 522
		[ObfuscatedName("Newtonsoft.Json.Linq.JToken+<AfterSelf>d__49")]
		public sealed class _AfterSelf_d__49 : Object
		{
			// Token: 0x060020C6 RID: 8390 RVA: 0x000935A8 File Offset: 0x000917A8
			// Note: this type is marked as 'beforefieldinit'.
			static _AfterSelf_d__49()
			{
				Il2CppClassPointerStore<JToken._AfterSelf_d__49>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JToken>.NativeClassPtr, "<AfterSelf>d__49");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JToken._AfterSelf_d__49>.NativeClassPtr);
				JToken._AfterSelf_d__49.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken._AfterSelf_d__49>.NativeClassPtr, "<>1__state");
				JToken._AfterSelf_d__49.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken._AfterSelf_d__49>.NativeClassPtr, "<>2__current");
				JToken._AfterSelf_d__49.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken._AfterSelf_d__49>.NativeClassPtr, "<>l__initialThreadId");
				JToken._AfterSelf_d__49.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken._AfterSelf_d__49>.NativeClassPtr, "<>4__this");
				JToken._AfterSelf_d__49.NativeFieldInfoPtr__o_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken._AfterSelf_d__49>.NativeClassPtr, "<o>5__2");
				JToken._AfterSelf_d__49.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken._AfterSelf_d__49>.NativeClassPtr, 100666699);
				JToken._AfterSelf_d__49.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken._AfterSelf_d__49>.NativeClassPtr, 100666700);
				JToken._AfterSelf_d__49.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken._AfterSelf_d__49>.NativeClassPtr, 100666701);
				JToken._AfterSelf_d__49.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Newtonsoft_Json_Linq_JToken__get_Current_Private_Virtual_Final_New_get_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken._AfterSelf_d__49>.NativeClassPtr, 100666702);
				JToken._AfterSelf_d__49.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken._AfterSelf_d__49>.NativeClassPtr, 100666703);
				JToken._AfterSelf_d__49.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken._AfterSelf_d__49>.NativeClassPtr, 100666704);
				JToken._AfterSelf_d__49.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken._AfterSelf_d__49>.NativeClassPtr, 100666705);
				JToken._AfterSelf_d__49.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken._AfterSelf_d__49>.NativeClassPtr, 100666706);
			}

			// Token: 0x060020C7 RID: 8391 RVA: 0x000936D8 File Offset: 0x000918D8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AfterSelf_d__49(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JToken._AfterSelf_d__49>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken._AfterSelf_d__49.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060020C8 RID: 8392 RVA: 0x00093720 File Offset: 0x00091920
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken._AfterSelf_d__49.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020C9 RID: 8393 RVA: 0x00093754 File Offset: 0x00091954
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759263, XrefRangeEnd = 759266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken._AfterSelf_d__49.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700094A RID: 2378
			// (get) Token: 0x060020CA RID: 8394 RVA: 0x00093790 File Offset: 0x00091990
			public unsafe JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken._AfterSelf_d__49.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Newtonsoft_Json_Linq_JToken__get_Current_Private_Virtual_Final_New_get_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
				}
			}

			// Token: 0x060020CB RID: 8395 RVA: 0x000937D0 File Offset: 0x000919D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759266, XrefRangeEnd = 759271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken._AfterSelf_d__49.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700094B RID: 2379
			// (get) Token: 0x060020CC RID: 8396 RVA: 0x00093804 File Offset: 0x00091A04
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken._AfterSelf_d__49.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060020CD RID: 8397 RVA: 0x00093844 File Offset: 0x00091A44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759271, XrefRangeEnd = 759273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<JToken> System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken._AfterSelf_d__49.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<JToken>>(intPtr3) : null;
			}

			// Token: 0x060020CE RID: 8398 RVA: 0x00093884 File Offset: 0x00091A84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken._AfterSelf_d__49.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060020CF RID: 8399 RVA: 0x00010813 File Offset: 0x0000EA13
			public _AfterSelf_d__49(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000945 RID: 2373
			// (get) Token: 0x060020D0 RID: 8400 RVA: 0x000938C4 File Offset: 0x00091AC4
			// (set) Token: 0x060020D1 RID: 8401 RVA: 0x0001081C File Offset: 0x0000EA1C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._AfterSelf_d__49.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._AfterSelf_d__49.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000946 RID: 2374
			// (get) Token: 0x060020D2 RID: 8402 RVA: 0x000938EC File Offset: 0x00091AEC
			// (set) Token: 0x060020D3 RID: 8403 RVA: 0x00010837 File Offset: 0x0000EA37
			public unsafe JToken __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._AfterSelf_d__49.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._AfterSelf_d__49.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000947 RID: 2375
			// (get) Token: 0x060020D4 RID: 8404 RVA: 0x0009391C File Offset: 0x00091B1C
			// (set) Token: 0x060020D5 RID: 8405 RVA: 0x00010856 File Offset: 0x0000EA56
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._AfterSelf_d__49.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._AfterSelf_d__49.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000948 RID: 2376
			// (get) Token: 0x060020D6 RID: 8406 RVA: 0x00093944 File Offset: 0x00091B44
			// (set) Token: 0x060020D7 RID: 8407 RVA: 0x00010871 File Offset: 0x0000EA71
			public unsafe JToken __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._AfterSelf_d__49.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._AfterSelf_d__49.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000949 RID: 2377
			// (get) Token: 0x060020D8 RID: 8408 RVA: 0x00093974 File Offset: 0x00091B74
			// (set) Token: 0x060020D9 RID: 8409 RVA: 0x00010890 File Offset: 0x0000EA90
			public unsafe JToken _o_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._AfterSelf_d__49.NativeFieldInfoPtr__o_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._AfterSelf_d__49.NativeFieldInfoPtr__o_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001789 RID: 6025
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400178A RID: 6026
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400178B RID: 6027
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400178C RID: 6028
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400178D RID: 6029
			private static readonly IntPtr NativeFieldInfoPtr__o_5__2;

			// Token: 0x0400178E RID: 6030
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400178F RID: 6031
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001790 RID: 6032
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001791 RID: 6033
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Newtonsoft_Json_Linq_JToken__get_Current_Private_Virtual_Final_New_get_JToken_0;

			// Token: 0x04001792 RID: 6034
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001793 RID: 6035
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001794 RID: 6036
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JToken_0;

			// Token: 0x04001795 RID: 6037
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200020B RID: 523
		[ObfuscatedName("Newtonsoft.Json.Linq.JToken+<Annotations>d__185`1")]
		public sealed class _Annotations_d__185<T> : Object where T : class
		{
			// Token: 0x060020DA RID: 8410 RVA: 0x000939A4 File Offset: 0x00091BA4
			// Note: this type is marked as 'beforefieldinit'.
			static _Annotations_d__185()
			{
				Il2CppClassPointerStore<JToken._Annotations_d__185<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(global::Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JToken>.NativeClassPtr, "<Annotations>d__185`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { global::Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JToken._Annotations_d__185<T>>.NativeClassPtr);
				JToken._Annotations_d__185<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken._Annotations_d__185<T>>.NativeClassPtr, "<>1__state");
				JToken._Annotations_d__185<T>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken._Annotations_d__185<T>>.NativeClassPtr, "<>2__current");
				JToken._Annotations_d__185<T>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken._Annotations_d__185<T>>.NativeClassPtr, "<>l__initialThreadId");
				JToken._Annotations_d__185<T>.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken._Annotations_d__185<T>>.NativeClassPtr, "<>4__this");
				JToken._Annotations_d__185<T>.NativeFieldInfoPtr__annotations_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken._Annotations_d__185<T>>.NativeClassPtr, "<annotations>5__2");
				JToken._Annotations_d__185<T>.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken._Annotations_d__185<T>>.NativeClassPtr, "<i>5__3");
				JToken._Annotations_d__185<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken._Annotations_d__185<T>>.NativeClassPtr, 100666707);
				JToken._Annotations_d__185<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken._Annotations_d__185<T>>.NativeClassPtr, 100666708);
				JToken._Annotations_d__185<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken._Annotations_d__185<T>>.NativeClassPtr, 100666709);
				JToken._Annotations_d__185<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken._Annotations_d__185<T>>.NativeClassPtr, 100666710);
				JToken._Annotations_d__185<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken._Annotations_d__185<T>>.NativeClassPtr, 100666711);
				JToken._Annotations_d__185<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken._Annotations_d__185<T>>.NativeClassPtr, 100666712);
				JToken._Annotations_d__185<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken._Annotations_d__185<T>>.NativeClassPtr, 100666713);
				JToken._Annotations_d__185<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken._Annotations_d__185<T>>.NativeClassPtr, 100666714);
			}

			// Token: 0x060020DB RID: 8411 RVA: 0x00093B24 File Offset: 0x00091D24
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Annotations_d__185(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JToken._Annotations_d__185<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken._Annotations_d__185<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060020DC RID: 8412 RVA: 0x00093B6C File Offset: 0x00091D6C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken._Annotations_d__185<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020DD RID: 8413 RVA: 0x00093BA0 File Offset: 0x00091DA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759273, XrefRangeEnd = 759286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken._Annotations_d__185<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000952 RID: 2386
			// (get) Token: 0x060020DE RID: 8414 RVA: 0x00093BDC File Offset: 0x00091DDC
			public unsafe T System.Collections.Generic.IEnumerator<T>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken._Annotations_d__185<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x060020DF RID: 8415 RVA: 0x00093C18 File Offset: 0x00091E18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken._Annotations_d__185<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000953 RID: 2387
			// (get) Token: 0x060020E0 RID: 8416 RVA: 0x00093C4C File Offset: 0x00091E4C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken._Annotations_d__185<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060020E1 RID: 8417 RVA: 0x00093C8C File Offset: 0x00091E8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken._Annotations_d__185<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
			}

			// Token: 0x060020E2 RID: 8418 RVA: 0x00093CCC File Offset: 0x00091ECC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken._Annotations_d__185<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060020E3 RID: 8419 RVA: 0x000108AF File Offset: 0x0000EAAF
			public _Annotations_d__185(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700094C RID: 2380
			// (get) Token: 0x060020E4 RID: 8420 RVA: 0x00093D0C File Offset: 0x00091F0C
			// (set) Token: 0x060020E5 RID: 8421 RVA: 0x000108B8 File Offset: 0x0000EAB8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._Annotations_d__185<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._Annotations_d__185<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700094D RID: 2381
			// (get) Token: 0x060020E6 RID: 8422 RVA: 0x00093D34 File Offset: 0x00091F34
			// (set) Token: 0x060020E7 RID: 8423 RVA: 0x00093D5C File Offset: 0x00091F5C
			public unsafe T __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._Annotations_d__185<T>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._Annotations_d__185<T>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x1700094E RID: 2382
			// (get) Token: 0x060020E8 RID: 8424 RVA: 0x00093E04 File Offset: 0x00092004
			// (set) Token: 0x060020E9 RID: 8425 RVA: 0x000108D3 File Offset: 0x0000EAD3
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._Annotations_d__185<T>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._Annotations_d__185<T>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700094F RID: 2383
			// (get) Token: 0x060020EA RID: 8426 RVA: 0x00093E2C File Offset: 0x0009202C
			// (set) Token: 0x060020EB RID: 8427 RVA: 0x000108EE File Offset: 0x0000EAEE
			public unsafe JToken __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._Annotations_d__185<T>.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._Annotations_d__185<T>.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000950 RID: 2384
			// (get) Token: 0x060020EC RID: 8428 RVA: 0x00093E5C File Offset: 0x0009205C
			// (set) Token: 0x060020ED RID: 8429 RVA: 0x0001090D File Offset: 0x0000EB0D
			public unsafe Il2CppReferenceArray<Object> _annotations_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._Annotations_d__185<T>.NativeFieldInfoPtr__annotations_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._Annotations_d__185<T>.NativeFieldInfoPtr__annotations_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000951 RID: 2385
			// (get) Token: 0x060020EE RID: 8430 RVA: 0x00093E8C File Offset: 0x0009208C
			// (set) Token: 0x060020EF RID: 8431 RVA: 0x0001092C File Offset: 0x0000EB2C
			public unsafe int _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._Annotations_d__185<T>.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._Annotations_d__185<T>.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x04001796 RID: 6038
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001797 RID: 6039
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001798 RID: 6040
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001799 RID: 6041
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400179A RID: 6042
			private static readonly IntPtr NativeFieldInfoPtr__annotations_5__2;

			// Token: 0x0400179B RID: 6043
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x0400179C RID: 6044
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400179D RID: 6045
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400179E RID: 6046
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400179F RID: 6047
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0;

			// Token: 0x040017A0 RID: 6048
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017A1 RID: 6049
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040017A2 RID: 6050
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

			// Token: 0x040017A3 RID: 6051
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200020C RID: 524
		[ObfuscatedName("Newtonsoft.Json.Linq.JToken+<Annotations>d__186")]
		public sealed class _Annotations_d__186 : Object
		{
			// Token: 0x060020F0 RID: 8432 RVA: 0x00093EB4 File Offset: 0x000920B4
			// Note: this type is marked as 'beforefieldinit'.
			static _Annotations_d__186()
			{
				Il2CppClassPointerStore<JToken._Annotations_d__186>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JToken>.NativeClassPtr, "<Annotations>d__186");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JToken._Annotations_d__186>.NativeClassPtr);
				JToken._Annotations_d__186.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken._Annotations_d__186>.NativeClassPtr, "<>1__state");
				JToken._Annotations_d__186.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken._Annotations_d__186>.NativeClassPtr, "<>2__current");
				JToken._Annotations_d__186.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken._Annotations_d__186>.NativeClassPtr, "<>l__initialThreadId");
				JToken._Annotations_d__186.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken._Annotations_d__186>.NativeClassPtr, "type");
				JToken._Annotations_d__186.NativeFieldInfoPtr___3__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken._Annotations_d__186>.NativeClassPtr, "<>3__type");
				JToken._Annotations_d__186.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken._Annotations_d__186>.NativeClassPtr, "<>4__this");
				JToken._Annotations_d__186.NativeFieldInfoPtr__annotations_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken._Annotations_d__186>.NativeClassPtr, "<annotations>5__2");
				JToken._Annotations_d__186.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken._Annotations_d__186>.NativeClassPtr, "<i>5__3");
				JToken._Annotations_d__186.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken._Annotations_d__186>.NativeClassPtr, 100666715);
				JToken._Annotations_d__186.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken._Annotations_d__186>.NativeClassPtr, 100666716);
				JToken._Annotations_d__186.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken._Annotations_d__186>.NativeClassPtr, 100666717);
				JToken._Annotations_d__186.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken._Annotations_d__186>.NativeClassPtr, 100666718);
				JToken._Annotations_d__186.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken._Annotations_d__186>.NativeClassPtr, 100666719);
				JToken._Annotations_d__186.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken._Annotations_d__186>.NativeClassPtr, 100666720);
				JToken._Annotations_d__186.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Object__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken._Annotations_d__186>.NativeClassPtr, 100666721);
				JToken._Annotations_d__186.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken._Annotations_d__186>.NativeClassPtr, 100666722);
			}

			// Token: 0x060020F1 RID: 8433 RVA: 0x00094020 File Offset: 0x00092220
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Annotations_d__186(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JToken._Annotations_d__186>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken._Annotations_d__186.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060020F2 RID: 8434 RVA: 0x00094068 File Offset: 0x00092268
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken._Annotations_d__186.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020F3 RID: 8435 RVA: 0x0009409C File Offset: 0x0009229C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759286, XrefRangeEnd = 759288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken._Annotations_d__186.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700095C RID: 2396
			// (get) Token: 0x060020F4 RID: 8436 RVA: 0x000940D8 File Offset: 0x000922D8
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken._Annotations_d__186.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060020F5 RID: 8437 RVA: 0x00094118 File Offset: 0x00092318
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759288, XrefRangeEnd = 759293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken._Annotations_d__186.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700095D RID: 2397
			// (get) Token: 0x060020F6 RID: 8438 RVA: 0x0009414C File Offset: 0x0009234C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken._Annotations_d__186.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060020F7 RID: 8439 RVA: 0x0009418C File Offset: 0x0009238C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759293, XrefRangeEnd = 759302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Object> System_Collections_Generic_IEnumerable_System_Object__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken._Annotations_d__186.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Object__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Object>>(intPtr3) : null;
			}

			// Token: 0x060020F8 RID: 8440 RVA: 0x000941CC File Offset: 0x000923CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken._Annotations_d__186.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060020F9 RID: 8441 RVA: 0x00010947 File Offset: 0x0000EB47
			public _Annotations_d__186(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000954 RID: 2388
			// (get) Token: 0x060020FA RID: 8442 RVA: 0x0009420C File Offset: 0x0009240C
			// (set) Token: 0x060020FB RID: 8443 RVA: 0x00010950 File Offset: 0x0000EB50
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._Annotations_d__186.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._Annotations_d__186.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000955 RID: 2389
			// (get) Token: 0x060020FC RID: 8444 RVA: 0x00094234 File Offset: 0x00092434
			// (set) Token: 0x060020FD RID: 8445 RVA: 0x0001096B File Offset: 0x0000EB6B
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._Annotations_d__186.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._Annotations_d__186.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000956 RID: 2390
			// (get) Token: 0x060020FE RID: 8446 RVA: 0x00094264 File Offset: 0x00092464
			// (set) Token: 0x060020FF RID: 8447 RVA: 0x0001098A File Offset: 0x0000EB8A
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._Annotations_d__186.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._Annotations_d__186.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000957 RID: 2391
			// (get) Token: 0x06002100 RID: 8448 RVA: 0x0009428C File Offset: 0x0009248C
			// (set) Token: 0x06002101 RID: 8449 RVA: 0x000109A5 File Offset: 0x0000EBA5
			public unsafe Type type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._Annotations_d__186.NativeFieldInfoPtr_type);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._Annotations_d__186.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000958 RID: 2392
			// (get) Token: 0x06002102 RID: 8450 RVA: 0x000942BC File Offset: 0x000924BC
			// (set) Token: 0x06002103 RID: 8451 RVA: 0x000109C4 File Offset: 0x0000EBC4
			public unsafe Type __3__type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._Annotations_d__186.NativeFieldInfoPtr___3__type);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._Annotations_d__186.NativeFieldInfoPtr___3__type), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000959 RID: 2393
			// (get) Token: 0x06002104 RID: 8452 RVA: 0x000942EC File Offset: 0x000924EC
			// (set) Token: 0x06002105 RID: 8453 RVA: 0x000109E3 File Offset: 0x0000EBE3
			public unsafe JToken __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._Annotations_d__186.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._Annotations_d__186.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700095A RID: 2394
			// (get) Token: 0x06002106 RID: 8454 RVA: 0x0009431C File Offset: 0x0009251C
			// (set) Token: 0x06002107 RID: 8455 RVA: 0x00010A02 File Offset: 0x0000EC02
			public unsafe Il2CppReferenceArray<Object> _annotations_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._Annotations_d__186.NativeFieldInfoPtr__annotations_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._Annotations_d__186.NativeFieldInfoPtr__annotations_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700095B RID: 2395
			// (get) Token: 0x06002108 RID: 8456 RVA: 0x0009434C File Offset: 0x0009254C
			// (set) Token: 0x06002109 RID: 8457 RVA: 0x00010A21 File Offset: 0x0000EC21
			public unsafe int _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._Annotations_d__186.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._Annotations_d__186.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x040017A4 RID: 6052
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040017A5 RID: 6053
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040017A6 RID: 6054
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040017A7 RID: 6055
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x040017A8 RID: 6056
			private static readonly IntPtr NativeFieldInfoPtr___3__type;

			// Token: 0x040017A9 RID: 6057
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040017AA RID: 6058
			private static readonly IntPtr NativeFieldInfoPtr__annotations_5__2;

			// Token: 0x040017AB RID: 6059
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x040017AC RID: 6060
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040017AD RID: 6061
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017AE RID: 6062
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040017AF RID: 6063
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040017B0 RID: 6064
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017B1 RID: 6065
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040017B2 RID: 6066
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Object__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Object_0;

			// Token: 0x040017B3 RID: 6067
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200020D RID: 525
		[ObfuscatedName("Newtonsoft.Json.Linq.JToken+<BeforeSelf>d__50")]
		public sealed class _BeforeSelf_d__50 : Object
		{
			// Token: 0x0600210A RID: 8458 RVA: 0x00094374 File Offset: 0x00092574
			// Note: this type is marked as 'beforefieldinit'.
			static _BeforeSelf_d__50()
			{
				Il2CppClassPointerStore<JToken._BeforeSelf_d__50>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JToken>.NativeClassPtr, "<BeforeSelf>d__50");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JToken._BeforeSelf_d__50>.NativeClassPtr);
				JToken._BeforeSelf_d__50.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken._BeforeSelf_d__50>.NativeClassPtr, "<>1__state");
				JToken._BeforeSelf_d__50.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken._BeforeSelf_d__50>.NativeClassPtr, "<>2__current");
				JToken._BeforeSelf_d__50.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken._BeforeSelf_d__50>.NativeClassPtr, "<>l__initialThreadId");
				JToken._BeforeSelf_d__50.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken._BeforeSelf_d__50>.NativeClassPtr, "<>4__this");
				JToken._BeforeSelf_d__50.NativeFieldInfoPtr__o_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken._BeforeSelf_d__50>.NativeClassPtr, "<o>5__2");
				JToken._BeforeSelf_d__50.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken._BeforeSelf_d__50>.NativeClassPtr, 100666723);
				JToken._BeforeSelf_d__50.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken._BeforeSelf_d__50>.NativeClassPtr, 100666724);
				JToken._BeforeSelf_d__50.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken._BeforeSelf_d__50>.NativeClassPtr, 100666725);
				JToken._BeforeSelf_d__50.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Newtonsoft_Json_Linq_JToken__get_Current_Private_Virtual_Final_New_get_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken._BeforeSelf_d__50>.NativeClassPtr, 100666726);
				JToken._BeforeSelf_d__50.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken._BeforeSelf_d__50>.NativeClassPtr, 100666727);
				JToken._BeforeSelf_d__50.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken._BeforeSelf_d__50>.NativeClassPtr, 100666728);
				JToken._BeforeSelf_d__50.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken._BeforeSelf_d__50>.NativeClassPtr, 100666729);
				JToken._BeforeSelf_d__50.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken._BeforeSelf_d__50>.NativeClassPtr, 100666730);
			}

			// Token: 0x0600210B RID: 8459 RVA: 0x000944A4 File Offset: 0x000926A4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeforeSelf_d__50(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JToken._BeforeSelf_d__50>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken._BeforeSelf_d__50.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600210C RID: 8460 RVA: 0x000944EC File Offset: 0x000926EC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken._BeforeSelf_d__50.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600210D RID: 8461 RVA: 0x00094520 File Offset: 0x00092720
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759302, XrefRangeEnd = 759305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken._BeforeSelf_d__50.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000963 RID: 2403
			// (get) Token: 0x0600210E RID: 8462 RVA: 0x0009455C File Offset: 0x0009275C
			public unsafe JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken._BeforeSelf_d__50.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Newtonsoft_Json_Linq_JToken__get_Current_Private_Virtual_Final_New_get_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
				}
			}

			// Token: 0x0600210F RID: 8463 RVA: 0x0009459C File Offset: 0x0009279C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759305, XrefRangeEnd = 759310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken._BeforeSelf_d__50.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000964 RID: 2404
			// (get) Token: 0x06002110 RID: 8464 RVA: 0x000945D0 File Offset: 0x000927D0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken._BeforeSelf_d__50.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002111 RID: 8465 RVA: 0x00094610 File Offset: 0x00092810
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759310, XrefRangeEnd = 759312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<JToken> System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken._BeforeSelf_d__50.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<JToken>>(intPtr3) : null;
			}

			// Token: 0x06002112 RID: 8466 RVA: 0x00094650 File Offset: 0x00092850
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken._BeforeSelf_d__50.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002113 RID: 8467 RVA: 0x00010A3C File Offset: 0x0000EC3C
			public _BeforeSelf_d__50(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700095E RID: 2398
			// (get) Token: 0x06002114 RID: 8468 RVA: 0x00094690 File Offset: 0x00092890
			// (set) Token: 0x06002115 RID: 8469 RVA: 0x00010A45 File Offset: 0x0000EC45
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._BeforeSelf_d__50.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._BeforeSelf_d__50.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700095F RID: 2399
			// (get) Token: 0x06002116 RID: 8470 RVA: 0x000946B8 File Offset: 0x000928B8
			// (set) Token: 0x06002117 RID: 8471 RVA: 0x00010A60 File Offset: 0x0000EC60
			public unsafe JToken __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._BeforeSelf_d__50.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._BeforeSelf_d__50.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000960 RID: 2400
			// (get) Token: 0x06002118 RID: 8472 RVA: 0x000946E8 File Offset: 0x000928E8
			// (set) Token: 0x06002119 RID: 8473 RVA: 0x00010A7F File Offset: 0x0000EC7F
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._BeforeSelf_d__50.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._BeforeSelf_d__50.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000961 RID: 2401
			// (get) Token: 0x0600211A RID: 8474 RVA: 0x00094710 File Offset: 0x00092910
			// (set) Token: 0x0600211B RID: 8475 RVA: 0x00010A9A File Offset: 0x0000EC9A
			public unsafe JToken __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._BeforeSelf_d__50.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._BeforeSelf_d__50.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000962 RID: 2402
			// (get) Token: 0x0600211C RID: 8476 RVA: 0x00094740 File Offset: 0x00092940
			// (set) Token: 0x0600211D RID: 8477 RVA: 0x00010AB9 File Offset: 0x0000ECB9
			public unsafe JToken _o_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._BeforeSelf_d__50.NativeFieldInfoPtr__o_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._BeforeSelf_d__50.NativeFieldInfoPtr__o_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017B4 RID: 6068
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040017B5 RID: 6069
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040017B6 RID: 6070
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040017B7 RID: 6071
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040017B8 RID: 6072
			private static readonly IntPtr NativeFieldInfoPtr__o_5__2;

			// Token: 0x040017B9 RID: 6073
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040017BA RID: 6074
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017BB RID: 6075
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040017BC RID: 6076
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Newtonsoft_Json_Linq_JToken__get_Current_Private_Virtual_Final_New_get_JToken_0;

			// Token: 0x040017BD RID: 6077
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017BE RID: 6078
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040017BF RID: 6079
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JToken_0;

			// Token: 0x040017C0 RID: 6080
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200020E RID: 526
		[ObfuscatedName("Newtonsoft.Json.Linq.JToken+<GetAncestors>d__48")]
		public sealed class _GetAncestors_d__48 : Object
		{
			// Token: 0x0600211E RID: 8478 RVA: 0x00094770 File Offset: 0x00092970
			// Note: this type is marked as 'beforefieldinit'.
			static _GetAncestors_d__48()
			{
				Il2CppClassPointerStore<JToken._GetAncestors_d__48>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JToken>.NativeClassPtr, "<GetAncestors>d__48");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JToken._GetAncestors_d__48>.NativeClassPtr);
				JToken._GetAncestors_d__48.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken._GetAncestors_d__48>.NativeClassPtr, "<>1__state");
				JToken._GetAncestors_d__48.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken._GetAncestors_d__48>.NativeClassPtr, "<>2__current");
				JToken._GetAncestors_d__48.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken._GetAncestors_d__48>.NativeClassPtr, "<>l__initialThreadId");
				JToken._GetAncestors_d__48.NativeFieldInfoPtr_self = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken._GetAncestors_d__48>.NativeClassPtr, "self");
				JToken._GetAncestors_d__48.NativeFieldInfoPtr___3__self = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken._GetAncestors_d__48>.NativeClassPtr, "<>3__self");
				JToken._GetAncestors_d__48.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken._GetAncestors_d__48>.NativeClassPtr, "<>4__this");
				JToken._GetAncestors_d__48.NativeFieldInfoPtr__current_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken._GetAncestors_d__48>.NativeClassPtr, "<current>5__2");
				JToken._GetAncestors_d__48.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken._GetAncestors_d__48>.NativeClassPtr, 100666731);
				JToken._GetAncestors_d__48.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken._GetAncestors_d__48>.NativeClassPtr, 100666732);
				JToken._GetAncestors_d__48.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken._GetAncestors_d__48>.NativeClassPtr, 100666733);
				JToken._GetAncestors_d__48.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Newtonsoft_Json_Linq_JToken__get_Current_Private_Virtual_Final_New_get_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken._GetAncestors_d__48>.NativeClassPtr, 100666734);
				JToken._GetAncestors_d__48.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken._GetAncestors_d__48>.NativeClassPtr, 100666735);
				JToken._GetAncestors_d__48.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken._GetAncestors_d__48>.NativeClassPtr, 100666736);
				JToken._GetAncestors_d__48.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken._GetAncestors_d__48>.NativeClassPtr, 100666737);
				JToken._GetAncestors_d__48.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken._GetAncestors_d__48>.NativeClassPtr, 100666738);
			}

			// Token: 0x0600211F RID: 8479 RVA: 0x000948C8 File Offset: 0x00092AC8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetAncestors_d__48(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JToken._GetAncestors_d__48>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken._GetAncestors_d__48.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002120 RID: 8480 RVA: 0x00094910 File Offset: 0x00092B10
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken._GetAncestors_d__48.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002121 RID: 8481 RVA: 0x00094944 File Offset: 0x00092B44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759312, XrefRangeEnd = 759315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken._GetAncestors_d__48.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700096C RID: 2412
			// (get) Token: 0x06002122 RID: 8482 RVA: 0x00094980 File Offset: 0x00092B80
			public unsafe JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken._GetAncestors_d__48.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Newtonsoft_Json_Linq_JToken__get_Current_Private_Virtual_Final_New_get_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
				}
			}

			// Token: 0x06002123 RID: 8483 RVA: 0x000949C0 File Offset: 0x00092BC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759315, XrefRangeEnd = 759320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken._GetAncestors_d__48.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700096D RID: 2413
			// (get) Token: 0x06002124 RID: 8484 RVA: 0x000949F4 File Offset: 0x00092BF4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken._GetAncestors_d__48.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002125 RID: 8485 RVA: 0x00094A34 File Offset: 0x00092C34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759320, XrefRangeEnd = 759328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<JToken> System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken._GetAncestors_d__48.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<JToken>>(intPtr3) : null;
			}

			// Token: 0x06002126 RID: 8486 RVA: 0x00094A74 File Offset: 0x00092C74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken._GetAncestors_d__48.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002127 RID: 8487 RVA: 0x00010AD8 File Offset: 0x0000ECD8
			public _GetAncestors_d__48(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000965 RID: 2405
			// (get) Token: 0x06002128 RID: 8488 RVA: 0x00094AB4 File Offset: 0x00092CB4
			// (set) Token: 0x06002129 RID: 8489 RVA: 0x00010AE1 File Offset: 0x0000ECE1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._GetAncestors_d__48.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._GetAncestors_d__48.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000966 RID: 2406
			// (get) Token: 0x0600212A RID: 8490 RVA: 0x00094ADC File Offset: 0x00092CDC
			// (set) Token: 0x0600212B RID: 8491 RVA: 0x00010AFC File Offset: 0x0000ECFC
			public unsafe JToken __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._GetAncestors_d__48.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._GetAncestors_d__48.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000967 RID: 2407
			// (get) Token: 0x0600212C RID: 8492 RVA: 0x00094B0C File Offset: 0x00092D0C
			// (set) Token: 0x0600212D RID: 8493 RVA: 0x00010B1B File Offset: 0x0000ED1B
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._GetAncestors_d__48.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._GetAncestors_d__48.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000968 RID: 2408
			// (get) Token: 0x0600212E RID: 8494 RVA: 0x00094B34 File Offset: 0x00092D34
			// (set) Token: 0x0600212F RID: 8495 RVA: 0x00010B36 File Offset: 0x0000ED36
			public unsafe bool self
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._GetAncestors_d__48.NativeFieldInfoPtr_self);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._GetAncestors_d__48.NativeFieldInfoPtr_self)) = value;
				}
			}

			// Token: 0x17000969 RID: 2409
			// (get) Token: 0x06002130 RID: 8496 RVA: 0x00094B5C File Offset: 0x00092D5C
			// (set) Token: 0x06002131 RID: 8497 RVA: 0x00010B51 File Offset: 0x0000ED51
			public unsafe bool __3__self
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._GetAncestors_d__48.NativeFieldInfoPtr___3__self);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._GetAncestors_d__48.NativeFieldInfoPtr___3__self)) = value;
				}
			}

			// Token: 0x1700096A RID: 2410
			// (get) Token: 0x06002132 RID: 8498 RVA: 0x00094B84 File Offset: 0x00092D84
			// (set) Token: 0x06002133 RID: 8499 RVA: 0x00010B6C File Offset: 0x0000ED6C
			public unsafe JToken __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._GetAncestors_d__48.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._GetAncestors_d__48.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700096B RID: 2411
			// (get) Token: 0x06002134 RID: 8500 RVA: 0x00094BB4 File Offset: 0x00092DB4
			// (set) Token: 0x06002135 RID: 8501 RVA: 0x00010B8B File Offset: 0x0000ED8B
			public unsafe JToken _current_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._GetAncestors_d__48.NativeFieldInfoPtr__current_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._GetAncestors_d__48.NativeFieldInfoPtr__current_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017C1 RID: 6081
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040017C2 RID: 6082
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040017C3 RID: 6083
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040017C4 RID: 6084
			private static readonly IntPtr NativeFieldInfoPtr_self;

			// Token: 0x040017C5 RID: 6085
			private static readonly IntPtr NativeFieldInfoPtr___3__self;

			// Token: 0x040017C6 RID: 6086
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040017C7 RID: 6087
			private static readonly IntPtr NativeFieldInfoPtr__current_5__2;

			// Token: 0x040017C8 RID: 6088
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040017C9 RID: 6089
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017CA RID: 6090
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040017CB RID: 6091
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Newtonsoft_Json_Linq_JToken__get_Current_Private_Virtual_Final_New_get_JToken_0;

			// Token: 0x040017CC RID: 6092
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017CD RID: 6093
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040017CE RID: 6094
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JToken_0;

			// Token: 0x040017CF RID: 6095
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200020F RID: 527
		[ObfuscatedName("Newtonsoft.Json.Linq.JToken+<ReadFromAsync>d__3")]
		public sealed class _ReadFromAsync_d__3 : ValueType
		{
			// Token: 0x06002136 RID: 8502 RVA: 0x00094BE4 File Offset: 0x00092DE4
			// Note: this type is marked as 'beforefieldinit'.
			static _ReadFromAsync_d__3()
			{
				Il2CppClassPointerStore<JToken._ReadFromAsync_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JToken>.NativeClassPtr, "<ReadFromAsync>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JToken._ReadFromAsync_d__3>.NativeClassPtr);
				JToken._ReadFromAsync_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken._ReadFromAsync_d__3>.NativeClassPtr, "<>1__state");
				JToken._ReadFromAsync_d__3.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken._ReadFromAsync_d__3>.NativeClassPtr, "<>t__builder");
				JToken._ReadFromAsync_d__3.NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken._ReadFromAsync_d__3>.NativeClassPtr, "reader");
				JToken._ReadFromAsync_d__3.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken._ReadFromAsync_d__3>.NativeClassPtr, "settings");
				JToken._ReadFromAsync_d__3.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken._ReadFromAsync_d__3>.NativeClassPtr, "cancellationToken");
				JToken._ReadFromAsync_d__3.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken._ReadFromAsync_d__3>.NativeClassPtr, "<>u__1");
				JToken._ReadFromAsync_d__3.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken._ReadFromAsync_d__3>.NativeClassPtr, "<>u__2");
				JToken._ReadFromAsync_d__3.NativeFieldInfoPtr___u__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken._ReadFromAsync_d__3>.NativeClassPtr, "<>u__3");
				JToken._ReadFromAsync_d__3.NativeFieldInfoPtr___u__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken._ReadFromAsync_d__3>.NativeClassPtr, "<>u__4");
				JToken._ReadFromAsync_d__3.NativeFieldInfoPtr___u__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JToken._ReadFromAsync_d__3>.NativeClassPtr, "<>u__5");
				JToken._ReadFromAsync_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken._ReadFromAsync_d__3>.NativeClassPtr, 100666739);
				JToken._ReadFromAsync_d__3.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JToken._ReadFromAsync_d__3>.NativeClassPtr, 100666740);
			}

			// Token: 0x06002137 RID: 8503 RVA: 0x00094D00 File Offset: 0x00092F00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759328, XrefRangeEnd = 759453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken._ReadFromAsync_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002138 RID: 8504 RVA: 0x00094D38 File Offset: 0x00092F38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759453, XrefRangeEnd = 759459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JToken._ReadFromAsync_d__3.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002139 RID: 8505 RVA: 0x00010BAA File Offset: 0x0000EDAA
			public _ReadFromAsync_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600213A RID: 8506 RVA: 0x00010BB3 File Offset: 0x0000EDB3
			public _ReadFromAsync_d__3()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JToken._ReadFromAsync_d__3>.NativeClassPtr))
			{
			}

			// Token: 0x1700096E RID: 2414
			// (get) Token: 0x0600213B RID: 8507 RVA: 0x00094D80 File Offset: 0x00092F80
			// (set) Token: 0x0600213C RID: 8508 RVA: 0x00010BC5 File Offset: 0x0000EDC5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._ReadFromAsync_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._ReadFromAsync_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700096F RID: 2415
			// (get) Token: 0x0600213D RID: 8509 RVA: 0x00094DA8 File Offset: 0x00092FA8
			// (set) Token: 0x0600213E RID: 8510 RVA: 0x00010BE0 File Offset: 0x0000EDE0
			public AsyncTaskMethodBuilder<JToken> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._ReadFromAsync_d__3.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<JToken>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<JToken>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._ReadFromAsync_d__3.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<JToken>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000970 RID: 2416
			// (get) Token: 0x0600213F RID: 8511 RVA: 0x00094DD8 File Offset: 0x00092FD8
			// (set) Token: 0x06002140 RID: 8512 RVA: 0x00010C0E File Offset: 0x0000EE0E
			public unsafe JsonReader reader
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._ReadFromAsync_d__3.NativeFieldInfoPtr_reader);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._ReadFromAsync_d__3.NativeFieldInfoPtr_reader), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000971 RID: 2417
			// (get) Token: 0x06002141 RID: 8513 RVA: 0x00094E08 File Offset: 0x00093008
			// (set) Token: 0x06002142 RID: 8514 RVA: 0x00010C2D File Offset: 0x0000EE2D
			public unsafe JsonLoadSettings settings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._ReadFromAsync_d__3.NativeFieldInfoPtr_settings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonLoadSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._ReadFromAsync_d__3.NativeFieldInfoPtr_settings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000972 RID: 2418
			// (get) Token: 0x06002143 RID: 8515 RVA: 0x00094E38 File Offset: 0x00093038
			// (set) Token: 0x06002144 RID: 8516 RVA: 0x00010C4C File Offset: 0x0000EE4C
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._ReadFromAsync_d__3.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._ReadFromAsync_d__3.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000973 RID: 2419
			// (get) Token: 0x06002145 RID: 8517 RVA: 0x00094E68 File Offset: 0x00093068
			// (set) Token: 0x06002146 RID: 8518 RVA: 0x00010C7A File Offset: 0x0000EE7A
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._ReadFromAsync_d__3.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._ReadFromAsync_d__3.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000974 RID: 2420
			// (get) Token: 0x06002147 RID: 8519 RVA: 0x00094E98 File Offset: 0x00093098
			// (set) Token: 0x06002148 RID: 8520 RVA: 0x00010CA8 File Offset: 0x0000EEA8
			public ConfiguredTaskAwaitable<JObject>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._ReadFromAsync_d__3.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<JObject>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<JObject>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._ReadFromAsync_d__3.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<JObject>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000975 RID: 2421
			// (get) Token: 0x06002149 RID: 8521 RVA: 0x00094EC8 File Offset: 0x000930C8
			// (set) Token: 0x0600214A RID: 8522 RVA: 0x00010CD6 File Offset: 0x0000EED6
			public ConfiguredTaskAwaitable<JArray>.ConfiguredTaskAwaiter __u__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._ReadFromAsync_d__3.NativeFieldInfoPtr___u__3);
					return new ConfiguredTaskAwaitable<JArray>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<JArray>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._ReadFromAsync_d__3.NativeFieldInfoPtr___u__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<JArray>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000976 RID: 2422
			// (get) Token: 0x0600214B RID: 8523 RVA: 0x00094EF8 File Offset: 0x000930F8
			// (set) Token: 0x0600214C RID: 8524 RVA: 0x00010D04 File Offset: 0x0000EF04
			public ConfiguredTaskAwaitable<JConstructor>.ConfiguredTaskAwaiter __u__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._ReadFromAsync_d__3.NativeFieldInfoPtr___u__4);
					return new ConfiguredTaskAwaitable<JConstructor>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<JConstructor>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._ReadFromAsync_d__3.NativeFieldInfoPtr___u__4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<JConstructor>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000977 RID: 2423
			// (get) Token: 0x0600214D RID: 8525 RVA: 0x00094F28 File Offset: 0x00093128
			// (set) Token: 0x0600214E RID: 8526 RVA: 0x00010D32 File Offset: 0x0000EF32
			public ConfiguredTaskAwaitable<JProperty>.ConfiguredTaskAwaiter __u__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._ReadFromAsync_d__3.NativeFieldInfoPtr___u__5);
					return new ConfiguredTaskAwaitable<JProperty>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<JProperty>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JToken._ReadFromAsync_d__3.NativeFieldInfoPtr___u__5), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<JProperty>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040017D0 RID: 6096
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040017D1 RID: 6097
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040017D2 RID: 6098
			private static readonly IntPtr NativeFieldInfoPtr_reader;

			// Token: 0x040017D3 RID: 6099
			private static readonly IntPtr NativeFieldInfoPtr_settings;

			// Token: 0x040017D4 RID: 6100
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040017D5 RID: 6101
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040017D6 RID: 6102
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040017D7 RID: 6103
			private static readonly IntPtr NativeFieldInfoPtr___u__3;

			// Token: 0x040017D8 RID: 6104
			private static readonly IntPtr NativeFieldInfoPtr___u__4;

			// Token: 0x040017D9 RID: 6105
			private static readonly IntPtr NativeFieldInfoPtr___u__5;

			// Token: 0x040017DA RID: 6106
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017DB RID: 6107
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000210 RID: 528
		private sealed class MethodInfoStoreGeneric_Value_Public_Virtual_New_T_Object_0<T>
		{
			// Token: 0x040017DC RID: 6108
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JToken.NativeMethodInfoPtr_Value_Public_Virtual_New_T_Object_0, Il2CppClassPointerStore<JToken>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { global::Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000211 RID: 529
		private sealed class MethodInfoStoreGeneric_Children_Public_JEnumerable_1_T_0<T>
		{
			// Token: 0x040017DD RID: 6109
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JToken.NativeMethodInfoPtr_Children_Public_JEnumerable_1_T_0, Il2CppClassPointerStore<JToken>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { global::Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000212 RID: 530
		private sealed class MethodInfoStoreGeneric_Values_Public_Virtual_New_IEnumerable_1_T_0<T>
		{
			// Token: 0x040017DE RID: 6110
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JToken.NativeMethodInfoPtr_Values_Public_Virtual_New_IEnumerable_1_T_0, Il2CppClassPointerStore<JToken>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { global::Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000213 RID: 531
		private sealed class MethodInfoStoreGeneric_ToObject_Public_T_0<T>
		{
			// Token: 0x040017DF RID: 6111
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JToken.NativeMethodInfoPtr_ToObject_Public_T_0, Il2CppClassPointerStore<JToken>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { global::Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000214 RID: 532
		private sealed class MethodInfoStoreGeneric_ToObject_Public_T_JsonSerializer_0<T>
		{
			// Token: 0x040017E0 RID: 6112
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JToken.NativeMethodInfoPtr_ToObject_Public_T_JsonSerializer_0, Il2CppClassPointerStore<JToken>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { global::Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000215 RID: 533
		private sealed class MethodInfoStoreGeneric_Annotation_Public_T_0<T>
		{
			// Token: 0x040017E1 RID: 6113
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JToken.NativeMethodInfoPtr_Annotation_Public_T_0, Il2CppClassPointerStore<JToken>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { global::Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000216 RID: 534
		private sealed class MethodInfoStoreGeneric_Annotations_Public_IEnumerable_1_T_0<T>
		{
			// Token: 0x040017E2 RID: 6114
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JToken.NativeMethodInfoPtr_Annotations_Public_IEnumerable_1_T_0, Il2CppClassPointerStore<JToken>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { global::Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000217 RID: 535
		private sealed class MethodInfoStoreGeneric_RemoveAnnotations_Public_Void_0<T>
		{
			// Token: 0x040017E3 RID: 6115
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JToken.NativeMethodInfoPtr_RemoveAnnotations_Public_Void_0, Il2CppClassPointerStore<JToken>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { global::Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
