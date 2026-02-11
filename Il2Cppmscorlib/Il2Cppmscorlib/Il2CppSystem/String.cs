using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Buffers;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;

namespace Il2CppSystem
{
	// Token: 0x02000056 RID: 86
	[Serializable]
	public sealed class String : Object
	{
		// Token: 0x0600043F RID: 1087 RVA: 0x00036738 File Offset: 0x00034938
		// Note: this type is marked as 'beforefieldinit'.
		static String()
		{
			Il2CppClassPointerStore<string>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "String");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<string>.NativeClassPtr);
			String.NativeFieldInfoPtr_StackallocIntBufferSizeLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<string>.NativeClassPtr, "StackallocIntBufferSizeLimit");
			String.NativeFieldInfoPtr_PROBABILISTICMAP_BLOCK_INDEX_MASK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<string>.NativeClassPtr, "PROBABILISTICMAP_BLOCK_INDEX_MASK");
			String.NativeFieldInfoPtr_PROBABILISTICMAP_BLOCK_INDEX_SHIFT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<string>.NativeClassPtr, "PROBABILISTICMAP_BLOCK_INDEX_SHIFT");
			String.NativeFieldInfoPtr_PROBABILISTICMAP_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<string>.NativeClassPtr, "PROBABILISTICMAP_SIZE");
			String.NativeFieldInfoPtr__stringLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<string>.NativeClassPtr, "_stringLength");
			String.NativeFieldInfoPtr__firstChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<string>.NativeClassPtr, "_firstChar");
			String.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<string>.NativeClassPtr, "Empty");
			String.NativeMethodInfoPtr_EqualsHelper_Private_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663937);
			String.NativeMethodInfoPtr_CompareOrdinalHelper_Private_Static_Int32_String_Int32_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663938);
			String.NativeMethodInfoPtr_CompareOrdinalHelper_Private_Static_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663939);
			String.NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663940);
			String.NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663941);
			String.NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663942);
			String.NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_CultureInfo_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663943);
			String.NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_Boolean_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663944);
			String.NativeMethodInfoPtr_Compare_Public_Static_Int32_String_Int32_String_Int32_Int32_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663945);
			String.NativeMethodInfoPtr_CompareOrdinal_Public_Static_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663946);
			String.NativeMethodInfoPtr_CompareOrdinal_Internal_Static_Int32_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663947);
			String.NativeMethodInfoPtr_CompareOrdinal_Public_Static_Int32_String_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663948);
			String.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663949);
			String.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663950);
			String.NativeMethodInfoPtr_EndsWith_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663951);
			String.NativeMethodInfoPtr_EndsWith_Public_Boolean_String_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663952);
			String.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663953);
			String.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663954);
			String.NativeMethodInfoPtr_Equals_Public_Boolean_String_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663955);
			String.NativeMethodInfoPtr_Equals_Public_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663956);
			String.NativeMethodInfoPtr_Equals_Public_Static_Boolean_String_String_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663957);
			String.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663958);
			String.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663959);
			String.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663960);
			String.NativeMethodInfoPtr_GetLegacyNonRandomizedHashCode_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663961);
			String.NativeMethodInfoPtr_StartsWith_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663962);
			String.NativeMethodInfoPtr_StartsWith_Public_Boolean_String_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663963);
			String.NativeMethodInfoPtr_StartsWith_Public_Boolean_String_Boolean_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663964);
			String.NativeMethodInfoPtr_StartsWith_Public_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663965);
			String.NativeMethodInfoPtr_CheckStringComparison_Internal_Static_Void_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663966);
			String.NativeMethodInfoPtr_FillStringChecked_Private_Static_Void_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663967);
			String.NativeMethodInfoPtr_Concat_Public_Static_String_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663968);
			String.NativeMethodInfoPtr_Concat_Public_Static_String_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663969);
			String.NativeMethodInfoPtr_Concat_Public_Static_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663970);
			String.NativeMethodInfoPtr_Concat_Public_Static_String_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663971);
			String.NativeMethodInfoPtr_Concat_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663972);
			String.NativeMethodInfoPtr_Concat_Public_Static_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663973);
			String.NativeMethodInfoPtr_Concat_Public_Static_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663974);
			String.NativeMethodInfoPtr_Concat_Public_Static_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663975);
			String.NativeMethodInfoPtr_Format_Public_Static_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663976);
			String.NativeMethodInfoPtr_Format_Public_Static_String_String_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663977);
			String.NativeMethodInfoPtr_Format_Public_Static_String_String_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663978);
			String.NativeMethodInfoPtr_Format_Public_Static_String_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663979);
			String.NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663980);
			String.NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663981);
			String.NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663982);
			String.NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663983);
			String.NativeMethodInfoPtr_FormatHelper_Private_Static_String_IFormatProvider_String_ParamsArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663984);
			String.NativeMethodInfoPtr_Insert_Public_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663985);
			String.NativeMethodInfoPtr_Join_Public_Static_String_Char_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663986);
			String.NativeMethodInfoPtr_Join_Public_Static_String_Char_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663987);
			String.NativeMethodInfoPtr_Join_Public_Static_String_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663988);
			String.NativeMethodInfoPtr_Join_Public_Static_String_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663989);
			String.NativeMethodInfoPtr_Join_Public_Static_String_String_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663990);
			String.NativeMethodInfoPtr_Join_Public_Static_String_String_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663991);
			String.NativeMethodInfoPtr_Join_Public_Static_String_String_Il2CppStringArray_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663992);
			String.NativeMethodInfoPtr_JoinCore_Private_Static_String_ptr_Char_Int32_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663993);
			String.NativeMethodInfoPtr_JoinCore_Private_Static_String_ptr_Char_Int32_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663994);
			String.NativeMethodInfoPtr_JoinCore_Private_Static_String_ptr_Char_Int32_Il2CppStringArray_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663995);
			String.NativeMethodInfoPtr_PadLeft_Public_String_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663996);
			String.NativeMethodInfoPtr_PadRight_Public_String_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663997);
			String.NativeMethodInfoPtr_Remove_Public_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663998);
			String.NativeMethodInfoPtr_Remove_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100663999);
			String.NativeMethodInfoPtr_Replace_Public_String_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664000);
			String.NativeMethodInfoPtr_Replace_Public_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664001);
			String.NativeMethodInfoPtr_ReplaceHelper_Private_String_Int32_String_ReadOnlySpan_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664002);
			String.NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Char_StringSplitOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664003);
			String.NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Char_Int32_StringSplitOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664004);
			String.NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664005);
			String.NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664006);
			String.NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStructArray_1_Char_StringSplitOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664007);
			String.NativeMethodInfoPtr_SplitInternal_Private_Il2CppStringArray_ReadOnlySpan_1_Char_Int32_StringSplitOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664008);
			String.NativeMethodInfoPtr_Split_Public_Il2CppStringArray_String_StringSplitOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664009);
			String.NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStringArray_StringSplitOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664010);
			String.NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStringArray_Int32_StringSplitOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664011);
			String.NativeMethodInfoPtr_SplitInternal_Private_Il2CppStringArray_String_Il2CppStringArray_Int32_StringSplitOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664012);
			String.NativeMethodInfoPtr_SplitInternal_Private_Il2CppStringArray_String_Int32_StringSplitOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664013);
			String.NativeMethodInfoPtr_SplitKeepEmptyEntries_Private_Il2CppStringArray_ReadOnlySpan_1_Int32_ReadOnlySpan_1_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664014);
			String.NativeMethodInfoPtr_SplitOmitEmptyEntries_Private_Il2CppStringArray_ReadOnlySpan_1_Int32_ReadOnlySpan_1_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664015);
			String.NativeMethodInfoPtr_MakeSeparatorList_Private_Void_ReadOnlySpan_1_Char_byref_ValueListBuilder_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664016);
			String.NativeMethodInfoPtr_MakeSeparatorList_Private_Void_String_byref_ValueListBuilder_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664017);
			String.NativeMethodInfoPtr_MakeSeparatorList_Private_Void_Il2CppStringArray_byref_ValueListBuilder_1_Int32_byref_ValueListBuilder_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664018);
			String.NativeMethodInfoPtr_Substring_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664019);
			String.NativeMethodInfoPtr_Substring_Public_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664020);
			String.NativeMethodInfoPtr_InternalSubString_Private_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664021);
			String.NativeMethodInfoPtr_ToLower_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664022);
			String.NativeMethodInfoPtr_ToLower_Public_String_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664023);
			String.NativeMethodInfoPtr_ToLowerInvariant_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664024);
			String.NativeMethodInfoPtr_ToUpper_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664025);
			String.NativeMethodInfoPtr_ToUpper_Public_String_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664026);
			String.NativeMethodInfoPtr_ToUpperInvariant_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664027);
			String.NativeMethodInfoPtr_Trim_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664028);
			String.NativeMethodInfoPtr_Trim_Public_String_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664029);
			String.NativeMethodInfoPtr_Trim_Public_String_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664030);
			String.NativeMethodInfoPtr_TrimStart_Public_String_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664031);
			String.NativeMethodInfoPtr_TrimStart_Public_String_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664032);
			String.NativeMethodInfoPtr_TrimEnd_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664033);
			String.NativeMethodInfoPtr_TrimEnd_Public_String_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664034);
			String.NativeMethodInfoPtr_TrimEnd_Public_String_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664035);
			String.NativeMethodInfoPtr_TrimWhiteSpaceHelper_Private_String_TrimType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664036);
			String.NativeMethodInfoPtr_TrimHelper_Private_String_ptr_Char_Int32_TrimType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664037);
			String.NativeMethodInfoPtr_CreateTrimmedString_Private_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664038);
			String.NativeMethodInfoPtr_Contains_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664039);
			String.NativeMethodInfoPtr_Contains_Public_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664040);
			String.NativeMethodInfoPtr_IndexOf_Public_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664041);
			String.NativeMethodInfoPtr_IndexOf_Public_Int32_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664042);
			String.NativeMethodInfoPtr_IndexOf_Public_Int32_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664043);
			String.NativeMethodInfoPtr_IndexOfAny_Public_Int32_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664044);
			String.NativeMethodInfoPtr_IndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664045);
			String.NativeMethodInfoPtr_IndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664046);
			String.NativeMethodInfoPtr_IndexOfAny_Private_Int32_Char_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664047);
			String.NativeMethodInfoPtr_IndexOfAny_Private_Int32_Char_Char_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664048);
			String.NativeMethodInfoPtr_IndexOfCharArray_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664049);
			String.NativeMethodInfoPtr_InitializeProbabilisticMap_Private_Static_Void_ptr_UInt32_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664050);
			String.NativeMethodInfoPtr_ArrayContains_Private_Static_Boolean_Char_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664051);
			String.NativeMethodInfoPtr_IsCharBitSet_Private_Static_Boolean_ptr_UInt32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664052);
			String.NativeMethodInfoPtr_SetCharBit_Private_Static_Void_ptr_UInt32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664053);
			String.NativeMethodInfoPtr_IndexOf_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664054);
			String.NativeMethodInfoPtr_IndexOf_Public_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664055);
			String.NativeMethodInfoPtr_IndexOf_Public_Int32_String_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664056);
			String.NativeMethodInfoPtr_IndexOf_Public_Int32_String_Int32_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664057);
			String.NativeMethodInfoPtr_IndexOf_Public_Int32_String_Int32_Int32_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664058);
			String.NativeMethodInfoPtr_LastIndexOf_Public_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664059);
			String.NativeMethodInfoPtr_LastIndexOf_Public_Int32_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664060);
			String.NativeMethodInfoPtr_LastIndexOf_Public_Int32_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664061);
			String.NativeMethodInfoPtr_LastIndexOfAny_Public_Int32_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664062);
			String.NativeMethodInfoPtr_LastIndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664063);
			String.NativeMethodInfoPtr_LastIndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664064);
			String.NativeMethodInfoPtr_LastIndexOfCharArray_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664065);
			String.NativeMethodInfoPtr_LastIndexOf_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664066);
			String.NativeMethodInfoPtr_LastIndexOf_Public_Int32_String_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664067);
			String.NativeMethodInfoPtr_LastIndexOf_Public_Int32_String_Int32_Int32_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664068);
			String.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664069);
			String.NativeMethodInfoPtr_Ctor_Private_Static_String_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664070);
			String.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664071);
			String.NativeMethodInfoPtr_Ctor_Private_Static_String_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664072);
			String.NativeMethodInfoPtr__ctor_Public_Void_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664073);
			String.NativeMethodInfoPtr_Ctor_Private_Static_String_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664074);
			String.NativeMethodInfoPtr__ctor_Public_Void_ptr_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664075);
			String.NativeMethodInfoPtr_Ctor_Private_Static_String_ptr_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664076);
			String.NativeMethodInfoPtr__ctor_Public_Void_ptr_SByte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664077);
			String.NativeMethodInfoPtr_Ctor_Private_Static_String_ptr_SByte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664078);
			String.NativeMethodInfoPtr_CreateStringForSByteConstructor_Private_Static_String_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664079);
			String.NativeMethodInfoPtr__ctor_Public_Void_ptr_SByte_Int32_Int32_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664080);
			String.NativeMethodInfoPtr_Ctor_Private_Static_String_ptr_SByte_Int32_Int32_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664081);
			String.NativeMethodInfoPtr__ctor_Public_Void_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664082);
			String.NativeMethodInfoPtr_Ctor_Private_Static_String_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664083);
			String.NativeMethodInfoPtr__ctor_Public_Void_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664084);
			String.NativeMethodInfoPtr_Ctor_Private_Static_String_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664085);
			String.NativeMethodInfoPtr_Create_Public_Static_String_Int32_TState_SpanAction_2_Char_TState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664086);
			String.NativeMethodInfoPtr_op_Implicit_Public_Static_ReadOnlySpan_1_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664087);
			String.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664088);
			String.NativeMethodInfoPtr_Copy_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664089);
			String.NativeMethodInfoPtr_CopyTo_Public_Void_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664090);
			String.NativeMethodInfoPtr_ToCharArray_Public_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664091);
			String.NativeMethodInfoPtr_IsNullOrEmpty_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664092);
			String.NativeMethodInfoPtr_IsNullOrWhiteSpace_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664093);
			String.NativeMethodInfoPtr_GetRawStringData_Internal_byref_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664094);
			String.NativeMethodInfoPtr_CreateStringFromEncoding_Internal_Static_String_ptr_Byte_Int32_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664095);
			String.NativeMethodInfoPtr_CreateFromChar_Internal_Static_String_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664096);
			String.NativeMethodInfoPtr_wstrcpy_Internal_Static_Void_ptr_Char_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664097);
			String.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664098);
			String.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664099);
			String.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Char__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664100);
			String.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664101);
			String.NativeMethodInfoPtr_wcslen_Internal_Static_Int32_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664102);
			String.NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664103);
			String.NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664104);
			String.NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664105);
			String.NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664106);
			String.NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664107);
			String.NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664108);
			String.NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664109);
			String.NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664110);
			String.NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664111);
			String.NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664112);
			String.NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664113);
			String.NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664114);
			String.NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664115);
			String.NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664116);
			String.NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664117);
			String.NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664118);
			String.NativeMethodInfoPtr_Normalize_Public_String_NormalizationForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664119);
			String.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664120);
			String.NativeMethodInfoPtr_IndexOfUnchecked_Internal_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664121);
			String.NativeMethodInfoPtr_IndexOfUncheckedIgnoreCase_Internal_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664122);
			String.NativeMethodInfoPtr_LastIndexOfUnchecked_Internal_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664123);
			String.NativeMethodInfoPtr_LastIndexOfUncheckedIgnoreCase_Internal_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664124);
			String.NativeMethodInfoPtr_StartsWithOrdinalUnchecked_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664125);
			String.NativeMethodInfoPtr_FastAllocateString_Internal_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664126);
			String.NativeMethodInfoPtr_memset_Private_Static_Void_ptr_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664127);
			String.NativeMethodInfoPtr_memcpy_Private_Static_Void_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664128);
			String.NativeMethodInfoPtr_bzero_Internal_Static_Void_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664129);
			String.NativeMethodInfoPtr_bzero_aligned_1_Internal_Static_Void_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664130);
			String.NativeMethodInfoPtr_bzero_aligned_2_Internal_Static_Void_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664131);
			String.NativeMethodInfoPtr_bzero_aligned_4_Internal_Static_Void_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664132);
			String.NativeMethodInfoPtr_bzero_aligned_8_Internal_Static_Void_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664133);
			String.NativeMethodInfoPtr_memcpy_aligned_1_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664134);
			String.NativeMethodInfoPtr_memcpy_aligned_2_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664135);
			String.NativeMethodInfoPtr_memcpy_aligned_4_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664136);
			String.NativeMethodInfoPtr_memcpy_aligned_8_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664137);
			String.NativeMethodInfoPtr_CreateString_Private_String_ptr_SByte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664138);
			String.NativeMethodInfoPtr_CreateString_Private_String_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664139);
			String.NativeMethodInfoPtr_CreateString_Private_String_ptr_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664140);
			String.NativeMethodInfoPtr_CreateString_Private_String_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664141);
			String.NativeMethodInfoPtr_CreateString_Private_String_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664142);
			String.NativeMethodInfoPtr_CreateString_Private_String_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664143);
			String.NativeMethodInfoPtr_CreateString_Private_String_ptr_SByte_Int32_Int32_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664144);
			String.NativeMethodInfoPtr_CreateString_Private_String_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664145);
			String.NativeMethodInfoPtr_get_Chars_Public_get_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100664146);
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x0003785C File Offset: 0x00035A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281228, XrefRangeEnd = 1281230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EqualsHelper(string strA, string strB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_EqualsHelper_Private_Static_Boolean_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x000378B0 File Offset: 0x00035AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281230, XrefRangeEnd = 1281232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompareOrdinalHelper(string strA, int indexA, int countA, string strB, int indexB, int countB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexA;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref countA;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexB;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref countB;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CompareOrdinalHelper_Private_Static_Int32_String_Int32_Int32_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x0003793C File Offset: 0x00035B3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1281236, RefRangeEnd = 1281237, XrefRangeStart = 1281232, XrefRangeEnd = 1281236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompareOrdinalHelper(string strA, string strB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CompareOrdinalHelper_Private_Static_Int32_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00037990 File Offset: 0x00035B90
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1281243, RefRangeEnd = 1281249, XrefRangeStart = 1281237, XrefRangeEnd = 1281243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Compare(string strA, string strB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x000379E4 File Offset: 0x00035BE4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1281250, RefRangeEnd = 1281256, XrefRangeStart = 1281249, XrefRangeEnd = 1281250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Compare(string strA, string strB, bool ignoreCase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00037A48 File Offset: 0x00035C48
		[CallerCount(55)]
		[CachedScanResults(RefRangeStart = 1281262, RefRangeEnd = 1281317, XrefRangeStart = 1281256, XrefRangeEnd = 1281262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Compare(string strA, string strB, StringComparison comparisonType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_StringComparison_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00037AAC File Offset: 0x00035CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281317, XrefRangeEnd = 1281324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Compare(string strA, string strB, CultureInfo culture, CompareOptions options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_CultureInfo_CompareOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00037B20 File Offset: 0x00035D20
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 1281331, RefRangeEnd = 1281368, XrefRangeStart = 1281324, XrefRangeEnd = 1281331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Compare(string strA, string strB, bool ignoreCase, CultureInfo culture)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_Boolean_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00037B94 File Offset: 0x00035D94
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 1281392, RefRangeEnd = 1281411, XrefRangeStart = 1281368, XrefRangeEnd = 1281392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexA;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexB;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Compare_Public_Static_Int32_String_Int32_String_Int32_Int32_StringComparison_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00037C20 File Offset: 0x00035E20
		[CallerCount(45)]
		[CachedScanResults(RefRangeStart = 1281412, RefRangeEnd = 1281457, XrefRangeStart = 1281411, XrefRangeEnd = 1281412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompareOrdinal(string strA, string strB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CompareOrdinal_Public_Static_Int32_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00037C74 File Offset: 0x00035E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281457, XrefRangeEnd = 1281464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompareOrdinal(ReadOnlySpan<char> strA, ReadOnlySpan<char> strB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(strA));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(strB));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CompareOrdinal_Internal_Static_Int32_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00037CD4 File Offset: 0x00035ED4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1281473, RefRangeEnd = 1281477, XrefRangeStart = 1281464, XrefRangeEnd = 1281473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexA;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexB;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CompareOrdinal_Public_Static_Int32_String_Int32_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00037D54 File Offset: 0x00035F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281477, XrefRangeEnd = 1281486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00037DA4 File Offset: 0x00035FA4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1281243, RefRangeEnd = 1281249, XrefRangeStart = 1281243, XrefRangeEnd = 1281249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(string strB)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strB);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00037DF4 File Offset: 0x00035FF4
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 1281492, RefRangeEnd = 1281513, XrefRangeStart = 1281486, XrefRangeEnd = 1281492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool EndsWith(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_EndsWith_Public_Boolean_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00037E44 File Offset: 0x00036044
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 1281519, RefRangeEnd = 1281536, XrefRangeStart = 1281513, XrefRangeEnd = 1281519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool EndsWith(string value, StringComparison comparisonType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_EndsWith_Public_Boolean_String_StringComparison_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00037EA0 File Offset: 0x000360A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281536, XrefRangeEnd = 1281539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00037EF0 File Offset: 0x000360F0
		[CallerCount(151)]
		[CachedScanResults(RefRangeStart = 1281540, RefRangeEnd = 1281691, XrefRangeStart = 1281539, XrefRangeEnd = 1281540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00037F40 File Offset: 0x00036140
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1281697, RefRangeEnd = 1281711, XrefRangeStart = 1281691, XrefRangeEnd = 1281697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(string value, StringComparison comparisonType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Equals_Public_Boolean_String_StringComparison_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00037F9C File Offset: 0x0003619C
		[CallerCount(2347)]
		[CachedScanResults(RefRangeStart = 1281712, RefRangeEnd = 1284059, XrefRangeStart = 1281711, XrefRangeEnd = 1281712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Equals(string a, string b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Equals_Public_Static_Boolean_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00037FF0 File Offset: 0x000361F0
		[CallerCount(214)]
		[CachedScanResults(RefRangeStart = 1284065, RefRangeEnd = 1284279, XrefRangeStart = 1284059, XrefRangeEnd = 1284065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Equals(string a, string b, StringComparison comparisonType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(b);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Equals_Public_Static_Boolean_String_String_StringComparison_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00038054 File Offset: 0x00036254
		[CallerCount(2347)]
		[CachedScanResults(RefRangeStart = 1281712, RefRangeEnd = 1284059, XrefRangeStart = 1281712, XrefRangeEnd = 1284059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(string a, string b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x000380A8 File Offset: 0x000362A8
		[CallerCount(398)]
		[CachedScanResults(RefRangeStart = 1284280, RefRangeEnd = 1284678, XrefRangeStart = 1284279, XrefRangeEnd = 1284280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(string a, string b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x000380FC File Offset: 0x000362FC
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00038138 File Offset: 0x00036338
		[CallerCount(0)]
		public unsafe int GetLegacyNonRandomizedHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_GetLegacyNonRandomizedHashCode_Internal_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00038174 File Offset: 0x00036374
		[CallerCount(91)]
		[CachedScanResults(RefRangeStart = 1284684, RefRangeEnd = 1284775, XrefRangeStart = 1284678, XrefRangeEnd = 1284684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StartsWith(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_StartsWith_Public_Boolean_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x000381C4 File Offset: 0x000363C4
		[CallerCount(72)]
		[CachedScanResults(RefRangeStart = 1284781, RefRangeEnd = 1284853, XrefRangeStart = 1284775, XrefRangeEnd = 1284781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StartsWith(string value, StringComparison comparisonType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_StartsWith_Public_Boolean_String_StringComparison_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00038220 File Offset: 0x00036420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284853, XrefRangeEnd = 1284857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StartsWith(string value, bool ignoreCase, CultureInfo culture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_StartsWith_Public_Boolean_String_Boolean_CultureInfo_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00038290 File Offset: 0x00036490
		[CallerCount(0)]
		public unsafe bool StartsWith(char value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_StartsWith_Public_Boolean_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x000382DC File Offset: 0x000364DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1284858, RefRangeEnd = 1284859, XrefRangeStart = 1284857, XrefRangeEnd = 1284858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckStringComparison(StringComparison comparisonType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref comparisonType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CheckStringComparison_Internal_Static_Void_StringComparison_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00038310 File Offset: 0x00036510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284859, XrefRangeEnd = 1284866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FillStringChecked(string dest, int destPos, string src)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(dest);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(src);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_FillStringChecked_Private_Static_Void_String_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00038368 File Offset: 0x00036568
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1284870, RefRangeEnd = 1284880, XrefRangeStart = 1284866, XrefRangeEnd = 1284870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Concat(Object arg0, Object arg1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Concat_Public_Static_String_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x000383B8 File Offset: 0x000365B8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1284884, RefRangeEnd = 1284892, XrefRangeStart = 1284880, XrefRangeEnd = 1284884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Concat(Object arg0, Object arg1, Object arg2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Concat_Public_Static_String_Object_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00038418 File Offset: 0x00036618
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1284902, RefRangeEnd = 1284910, XrefRangeStart = 1284892, XrefRangeEnd = 1284902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Concat([Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Concat_Public_Static_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00038464 File Offset: 0x00036664
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1284989, RefRangeEnd = 1284990, XrefRangeStart = 1284910, XrefRangeEnd = 1284989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Concat<T>(IEnumerable<T> values)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.MethodInfoStoreGeneric_Concat_Public_Static_String_IEnumerable_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x000384A0 File Offset: 0x000366A0
		[CallerCount(1202)]
		[CachedScanResults(RefRangeStart = 1284994, RefRangeEnd = 1286196, XrefRangeStart = 1284990, XrefRangeEnd = 1284994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Concat(string str0, string str1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Concat_Public_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x000384F0 File Offset: 0x000366F0
		[CallerCount(623)]
		[CachedScanResults(RefRangeStart = 1286200, RefRangeEnd = 1286823, XrefRangeStart = 1286196, XrefRangeEnd = 1286200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Concat(string str0, string str1, string str2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Concat_Public_Static_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00038550 File Offset: 0x00036750
		[CallerCount(177)]
		[CachedScanResults(RefRangeStart = 1286828, RefRangeEnd = 1287005, XrefRangeStart = 1286823, XrefRangeEnd = 1286828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Concat(string str0, string str1, string str2, string str3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str2);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str3);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Concat_Public_Static_String_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x000385C4 File Offset: 0x000367C4
		[CallerCount(189)]
		[CachedScanResults(RefRangeStart = 1287011, RefRangeEnd = 1287200, XrefRangeStart = 1287005, XrefRangeEnd = 1287011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Concat([Optional] Il2CppStringArray values)
		{
			if (values == null)
			{
				values = new Il2CppStringArray(0L);
			}
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Concat_Public_Static_String_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00038610 File Offset: 0x00036810
		[CallerCount(677)]
		[CachedScanResults(RefRangeStart = 1287208, RefRangeEnd = 1287885, XrefRangeStart = 1287200, XrefRangeEnd = 1287208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(string format, Object arg0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Format_Public_Static_String_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00038660 File Offset: 0x00036860
		[CallerCount(470)]
		[CachedScanResults(RefRangeStart = 1287893, RefRangeEnd = 1288363, XrefRangeStart = 1287885, XrefRangeEnd = 1287893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(string format, Object arg0, Object arg1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Format_Public_Static_String_String_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x000386C0 File Offset: 0x000368C0
		[CallerCount(189)]
		[CachedScanResults(RefRangeStart = 1288371, RefRangeEnd = 1288560, XrefRangeStart = 1288363, XrefRangeEnd = 1288371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(string format, Object arg0, Object arg1, Object arg2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Format_Public_Static_String_String_Object_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00038734 File Offset: 0x00036934
		[CallerCount(211)]
		[CachedScanResults(RefRangeStart = 1288568, RefRangeEnd = 1288779, XrefRangeStart = 1288560, XrefRangeEnd = 1288568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Format_Public_Static_String_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00038790 File Offset: 0x00036990
		[CallerCount(169)]
		[CachedScanResults(RefRangeStart = 1288787, RefRangeEnd = 1288956, XrefRangeStart = 1288779, XrefRangeEnd = 1288787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(IFormatProvider provider, string format, Object arg0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x000387F0 File Offset: 0x000369F0
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1288964, RefRangeEnd = 1288980, XrefRangeStart = 1288956, XrefRangeEnd = 1288964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(IFormatProvider provider, string format, Object arg0, Object arg1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00038864 File Offset: 0x00036A64
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1288988, RefRangeEnd = 1289000, XrefRangeStart = 1288980, XrefRangeEnd = 1288988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(IFormatProvider provider, string format, Object arg0, Object arg1, Object arg2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Object_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x000388EC File Offset: 0x00036AEC
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 1289008, RefRangeEnd = 1289030, XrefRangeStart = 1289000, XrefRangeEnd = 1289008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(IFormatProvider provider, string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x0003895C File Offset: 0x00036B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1289030, XrefRangeEnd = 1289037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatHelper(IFormatProvider provider, string format, ParamsArray args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_FormatHelper_Private_Static_String_IFormatProvider_String_ParamsArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x000389C4 File Offset: 0x00036BC4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1289041, RefRangeEnd = 1289047, XrefRangeStart = 1289037, XrefRangeEnd = 1289041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Insert(int startIndex, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Insert_Public_String_Int32_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00038A1C File Offset: 0x00036C1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1289048, RefRangeEnd = 1289049, XrefRangeStart = 1289047, XrefRangeEnd = 1289048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Join(char separator, [Optional] Il2CppReferenceArray<Object> values)
		{
			if (values == null)
			{
				values = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref separator;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Join_Public_Static_String_Char_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00038A74 File Offset: 0x00036C74
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1289051, RefRangeEnd = 1289055, XrefRangeStart = 1289049, XrefRangeEnd = 1289051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Join<T>(char separator, IEnumerable<T> values)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref separator;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.MethodInfoStoreGeneric_Join_Public_Static_String_Char_IEnumerable_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00038AC0 File Offset: 0x00036CC0
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 1289058, RefRangeEnd = 1289084, XrefRangeStart = 1289055, XrefRangeEnd = 1289058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Join(string separator, [Optional] Il2CppStringArray value)
		{
			if (value == null)
			{
				value = new Il2CppStringArray(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(separator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Join_Public_Static_String_String_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00038B1C File Offset: 0x00036D1C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1289088, RefRangeEnd = 1289094, XrefRangeStart = 1289084, XrefRangeEnd = 1289088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Join(string separator, [Optional] Il2CppReferenceArray<Object> values)
		{
			if (values == null)
			{
				values = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(separator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Join_Public_Static_String_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00038B78 File Offset: 0x00036D78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1289099, RefRangeEnd = 1289101, XrefRangeStart = 1289094, XrefRangeEnd = 1289099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Join<T>(string separator, IEnumerable<T> values)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(separator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.MethodInfoStoreGeneric_Join_Public_Static_String_String_IEnumerable_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00038BC8 File Offset: 0x00036DC8
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 1289139, RefRangeEnd = 1289164, XrefRangeStart = 1289101, XrefRangeEnd = 1289139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Join(string separator, IEnumerable<string> values)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(separator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Join_Public_Static_String_String_IEnumerable_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00038C18 File Offset: 0x00036E18
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1289167, RefRangeEnd = 1289170, XrefRangeStart = 1289164, XrefRangeEnd = 1289167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Join(string separator, Il2CppStringArray value, int startIndex, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(separator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Join_Public_Static_String_String_Il2CppStringArray_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00038C84 File Offset: 0x00036E84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1289178, RefRangeEnd = 1289180, XrefRangeStart = 1289170, XrefRangeEnd = 1289178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string JoinCore(char* separator, int separatorLength, Il2CppReferenceArray<Object> values)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = separator;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref separatorLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_JoinCore_Private_Static_String_ptr_Char_Int32_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00038CDC File Offset: 0x00036EDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1289218, RefRangeEnd = 1289219, XrefRangeStart = 1289180, XrefRangeEnd = 1289218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string JoinCore<T>(char* separator, int separatorLength, IEnumerable<T> values)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = separator;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref separatorLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.MethodInfoStoreGeneric_JoinCore_Private_Static_String_ptr_Char_Int32_IEnumerable_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00038D34 File Offset: 0x00036F34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1289225, RefRangeEnd = 1289227, XrefRangeStart = 1289219, XrefRangeEnd = 1289225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string JoinCore(char* separator, int separatorLength, Il2CppStringArray value, int startIndex, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = separator;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref separatorLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_JoinCore_Private_Static_String_ptr_Char_Int32_Il2CppStringArray_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00038DA8 File Offset: 0x00036FA8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1289229, RefRangeEnd = 1289232, XrefRangeStart = 1289227, XrefRangeEnd = 1289229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string PadLeft(int totalWidth, char paddingChar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref totalWidth;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paddingChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_PadLeft_Public_String_Int32_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00038DFC File Offset: 0x00036FFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1289234, RefRangeEnd = 1289236, XrefRangeStart = 1289232, XrefRangeEnd = 1289234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string PadRight(int totalWidth, char paddingChar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref totalWidth;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paddingChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_PadRight_Public_String_Int32_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00038E50 File Offset: 0x00037050
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1289240, RefRangeEnd = 1289254, XrefRangeStart = 1289236, XrefRangeEnd = 1289240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Remove(int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Remove_Public_String_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00038EA4 File Offset: 0x000370A4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1289269, RefRangeEnd = 1289275, XrefRangeStart = 1289254, XrefRangeEnd = 1289269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Remove(int startIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Remove_Public_String_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00038EE8 File Offset: 0x000370E8
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 1289277, RefRangeEnd = 1289325, XrefRangeStart = 1289275, XrefRangeEnd = 1289277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Replace(char oldChar, char newChar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldChar;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Replace_Public_String_Char_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00038F3C File Offset: 0x0003713C
		[CallerCount(84)]
		[CachedScanResults(RefRangeStart = 1289346, RefRangeEnd = 1289430, XrefRangeStart = 1289325, XrefRangeEnd = 1289346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Replace(string oldValue, string newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oldValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Replace_Public_String_String_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00038F98 File Offset: 0x00037198
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1289455, RefRangeEnd = 1289456, XrefRangeStart = 1289430, XrefRangeEnd = 1289455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReplaceHelper(int oldValueLength, string newValue, ReadOnlySpan<int> indices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldValueLength;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(indices));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_ReplaceHelper_Private_String_Int32_String_ReadOnlySpan_1_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00039008 File Offset: 0x00037208
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 1289458, RefRangeEnd = 1289506, XrefRangeStart = 1289456, XrefRangeEnd = 1289458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray Split(char separator, StringSplitOptions options = StringSplitOptions.None)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref separator;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Char_StringSplitOptions_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00039064 File Offset: 0x00037264
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1289508, RefRangeEnd = 1289509, XrefRangeStart = 1289506, XrefRangeEnd = 1289508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray Split(char separator, int count, StringSplitOptions options = StringSplitOptions.None)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref separator;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Char_Int32_StringSplitOptions_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x000390CC File Offset: 0x000372CC
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 1289513, RefRangeEnd = 1289549, XrefRangeStart = 1289509, XrefRangeEnd = 1289513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray Split([Optional] Il2CppStructArray<char> separator)
		{
			if (separator == null)
			{
				separator = new Il2CppStructArray<char>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(separator);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStructArray_1_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x0003912C File Offset: 0x0003732C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1289553, RefRangeEnd = 1289557, XrefRangeStart = 1289549, XrefRangeEnd = 1289553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray Split(Il2CppStructArray<char> separator, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(separator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStructArray_1_Char_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x0003918C File Offset: 0x0003738C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1289561, RefRangeEnd = 1289572, XrefRangeStart = 1289557, XrefRangeEnd = 1289561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray Split(Il2CppStructArray<char> separator, StringSplitOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(separator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStructArray_1_Char_StringSplitOptions_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x000391EC File Offset: 0x000373EC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1289590, RefRangeEnd = 1289596, XrefRangeStart = 1289572, XrefRangeEnd = 1289590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray SplitInternal(ReadOnlySpan<char> separators, int count, StringSplitOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(separators));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_SplitInternal_Private_Il2CppStringArray_ReadOnlySpan_1_Char_Int32_StringSplitOptions_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00039260 File Offset: 0x00037460
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1289599, RefRangeEnd = 1289604, XrefRangeStart = 1289596, XrefRangeEnd = 1289599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray Split(string separator, StringSplitOptions options = StringSplitOptions.None)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(separator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Split_Public_Il2CppStringArray_String_StringSplitOptions_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x000392C0 File Offset: 0x000374C0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1289605, RefRangeEnd = 1289612, XrefRangeStart = 1289604, XrefRangeEnd = 1289605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray Split(Il2CppStringArray separator, StringSplitOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(separator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStringArray_StringSplitOptions_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00039320 File Offset: 0x00037520
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1289613, RefRangeEnd = 1289614, XrefRangeStart = 1289612, XrefRangeEnd = 1289613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray Split(Il2CppStringArray separator, int count, StringSplitOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(separator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStringArray_Int32_StringSplitOptions_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x0003938C File Offset: 0x0003758C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1289659, RefRangeEnd = 1289662, XrefRangeStart = 1289614, XrefRangeEnd = 1289659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray SplitInternal(string separator, Il2CppStringArray separators, int count, StringSplitOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(separator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(separators);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_SplitInternal_Private_Il2CppStringArray_String_Il2CppStringArray_Int32_StringSplitOptions_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x0003940C File Offset: 0x0003760C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1289689, RefRangeEnd = 1289690, XrefRangeStart = 1289662, XrefRangeEnd = 1289689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray SplitInternal(string separator, int count, StringSplitOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(separator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_SplitInternal_Private_Il2CppStringArray_String_Int32_StringSplitOptions_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00039478 File Offset: 0x00037678
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1289703, RefRangeEnd = 1289706, XrefRangeStart = 1289690, XrefRangeEnd = 1289703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray SplitKeepEmptyEntries(ReadOnlySpan<int> sepList, ReadOnlySpan<int> lengthList, int defaultLength, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sepList));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lengthList));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_SplitKeepEmptyEntries_Private_Il2CppStringArray_ReadOnlySpan_1_Int32_ReadOnlySpan_1_Int32_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00039500 File Offset: 0x00037700
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1289725, RefRangeEnd = 1289728, XrefRangeStart = 1289706, XrefRangeEnd = 1289725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray SplitOmitEmptyEntries(ReadOnlySpan<int> sepList, ReadOnlySpan<int> lengthList, int defaultLength, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sepList));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lengthList));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_SplitOmitEmptyEntries_Private_Il2CppStringArray_ReadOnlySpan_1_Int32_ReadOnlySpan_1_Int32_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00039588 File Offset: 0x00037788
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1289740, RefRangeEnd = 1289741, XrefRangeStart = 1289728, XrefRangeEnd = 1289740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MakeSeparatorList(ReadOnlySpan<char> separators, ref ValueListBuilder<int> sepListBuilder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(separators));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(sepListBuilder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_MakeSeparatorList_Private_Void_ReadOnlySpan_1_Char_byref_ValueListBuilder_1_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x000395E4 File Offset: 0x000377E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1289741, XrefRangeEnd = 1289752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MakeSeparatorList(string separator, ref ValueListBuilder<int> sepListBuilder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(separator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(sepListBuilder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_MakeSeparatorList_Private_Void_String_byref_ValueListBuilder_1_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x0003963C File Offset: 0x0003783C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1289752, XrefRangeEnd = 1289766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MakeSeparatorList(Il2CppStringArray separators, ref ValueListBuilder<int> sepListBuilder, ref ValueListBuilder<int> lengthListBuilder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(separators);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(sepListBuilder);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(lengthListBuilder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_MakeSeparatorList_Private_Void_Il2CppStringArray_byref_ValueListBuilder_1_Int32_byref_ValueListBuilder_1_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x000396A4 File Offset: 0x000378A4
		[CallerCount(144)]
		[CachedScanResults(RefRangeStart = 1289767, RefRangeEnd = 1289911, XrefRangeStart = 1289766, XrefRangeEnd = 1289767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Substring(int startIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Substring_Public_String_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x000396E8 File Offset: 0x000378E8
		[CallerCount(376)]
		[CachedScanResults(RefRangeStart = 1289912, RefRangeEnd = 1290288, XrefRangeStart = 1289911, XrefRangeEnd = 1289912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Substring(int startIndex, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Substring_Public_String_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x0003973C File Offset: 0x0003793C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290288, XrefRangeEnd = 1290290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string InternalSubString(int startIndex, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_InternalSubString_Private_String_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00039790 File Offset: 0x00037990
		[CallerCount(51)]
		[CachedScanResults(RefRangeStart = 1290295, RefRangeEnd = 1290346, XrefRangeStart = 1290290, XrefRangeEnd = 1290295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToLower()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_ToLower_Public_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x000397C8 File Offset: 0x000379C8
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 1290353, RefRangeEnd = 1290375, XrefRangeStart = 1290346, XrefRangeEnd = 1290353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToLower(CultureInfo culture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_ToLower_Public_String_CultureInfo_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00039810 File Offset: 0x00037A10
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 1290380, RefRangeEnd = 1290432, XrefRangeStart = 1290375, XrefRangeEnd = 1290380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToLowerInvariant()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_ToLowerInvariant_Public_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00039848 File Offset: 0x00037A48
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1290437, RefRangeEnd = 1290444, XrefRangeStart = 1290432, XrefRangeEnd = 1290437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToUpper()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_ToUpper_Public_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00039880 File Offset: 0x00037A80
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1290451, RefRangeEnd = 1290461, XrefRangeStart = 1290444, XrefRangeEnd = 1290451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToUpper(CultureInfo culture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_ToUpper_Public_String_CultureInfo_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x000398C8 File Offset: 0x00037AC8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1290466, RefRangeEnd = 1290474, XrefRangeStart = 1290461, XrefRangeEnd = 1290466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToUpperInvariant()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_ToUpperInvariant_Public_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00039900 File Offset: 0x00037B00
		[CallerCount(105)]
		[CachedScanResults(RefRangeStart = 1290475, RefRangeEnd = 1290580, XrefRangeStart = 1290474, XrefRangeEnd = 1290475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Trim()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Trim_Public_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00039938 File Offset: 0x00037B38
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1290581, RefRangeEnd = 1290588, XrefRangeStart = 1290580, XrefRangeEnd = 1290581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Trim(char trimChar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref trimChar;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Trim_Public_String_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x0003997C File Offset: 0x00037B7C
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 1290589, RefRangeEnd = 1290611, XrefRangeStart = 1290588, XrefRangeEnd = 1290589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Trim([Optional] Il2CppStructArray<char> trimChars)
		{
			if (trimChars == null)
			{
				trimChars = new Il2CppStructArray<char>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(trimChars);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Trim_Public_String_Il2CppStructArray_1_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x000399D4 File Offset: 0x00037BD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1290612, RefRangeEnd = 1290614, XrefRangeStart = 1290611, XrefRangeEnd = 1290612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string TrimStart(char trimChar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref trimChar;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_TrimStart_Public_String_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00039A18 File Offset: 0x00037C18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1290615, RefRangeEnd = 1290617, XrefRangeStart = 1290614, XrefRangeEnd = 1290615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string TrimStart([Optional] Il2CppStructArray<char> trimChars)
		{
			if (trimChars == null)
			{
				trimChars = new Il2CppStructArray<char>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(trimChars);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_TrimStart_Public_String_Il2CppStructArray_1_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00039A70 File Offset: 0x00037C70
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1290618, RefRangeEnd = 1290624, XrefRangeStart = 1290617, XrefRangeEnd = 1290618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string TrimEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_TrimEnd_Public_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00039AA8 File Offset: 0x00037CA8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1290625, RefRangeEnd = 1290633, XrefRangeStart = 1290624, XrefRangeEnd = 1290625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string TrimEnd(char trimChar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref trimChar;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_TrimEnd_Public_String_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00039AEC File Offset: 0x00037CEC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1290634, RefRangeEnd = 1290642, XrefRangeStart = 1290633, XrefRangeEnd = 1290634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string TrimEnd([Optional] Il2CppStructArray<char> trimChars)
		{
			if (trimChars == null)
			{
				trimChars = new Il2CppStructArray<char>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(trimChars);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_TrimEnd_Public_String_Il2CppStructArray_1_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00039B44 File Offset: 0x00037D44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1290652, RefRangeEnd = 1290654, XrefRangeStart = 1290642, XrefRangeEnd = 1290652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string TrimWhiteSpaceHelper(String.TrimType trimType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref trimType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_TrimWhiteSpaceHelper_Private_String_TrimType_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00039B88 File Offset: 0x00037D88
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1290657, RefRangeEnd = 1290663, XrefRangeStart = 1290654, XrefRangeEnd = 1290657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string TrimHelper(char* trimChars, int trimCharsLength, String.TrimType trimType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = trimChars;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trimCharsLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trimType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_TrimHelper_Private_String_ptr_Char_Int32_TrimType_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00039BE8 File Offset: 0x00037DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290663, XrefRangeEnd = 1290664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CreateTrimmedString(int start, int end)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CreateTrimmedString_Private_String_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00039C3C File Offset: 0x00037E3C
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 1290670, RefRangeEnd = 1290747, XrefRangeStart = 1290664, XrefRangeEnd = 1290670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Contains_Public_Boolean_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00039C8C File Offset: 0x00037E8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1290748, RefRangeEnd = 1290750, XrefRangeStart = 1290747, XrefRangeEnd = 1290748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(char value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Contains_Public_Boolean_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00039CD8 File Offset: 0x00037ED8
		[CallerCount(120)]
		[CachedScanResults(RefRangeStart = 1290751, RefRangeEnd = 1290871, XrefRangeStart = 1290750, XrefRangeEnd = 1290751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(char value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOf_Public_Int32_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00039D24 File Offset: 0x00037F24
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 1290872, RefRangeEnd = 1290893, XrefRangeStart = 1290871, XrefRangeEnd = 1290872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(char value, int startIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOf_Public_Int32_Char_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00039D7C File Offset: 0x00037F7C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1290894, RefRangeEnd = 1290902, XrefRangeStart = 1290893, XrefRangeEnd = 1290894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(char value, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOf_Public_Int32_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00039DE4 File Offset: 0x00037FE4
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 1290903, RefRangeEnd = 1290936, XrefRangeStart = 1290902, XrefRangeEnd = 1290903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOfAny(Il2CppStructArray<char> anyOf)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(anyOf);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOfAny_Public_Int32_Il2CppStructArray_1_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00039E34 File Offset: 0x00038034
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1290937, RefRangeEnd = 1290944, XrefRangeStart = 1290936, XrefRangeEnd = 1290937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOfAny(Il2CppStructArray<char> anyOf, int startIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(anyOf);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00039E90 File Offset: 0x00038090
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1290952, RefRangeEnd = 1290958, XrefRangeStart = 1290944, XrefRangeEnd = 1290952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOfAny(Il2CppStructArray<char> anyOf, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(anyOf);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00039EFC File Offset: 0x000380FC
		[CallerCount(0)]
		public unsafe int IndexOfAny(char value1, char value2, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOfAny_Private_Int32_Char_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00039F70 File Offset: 0x00038170
		[CallerCount(0)]
		public unsafe int IndexOfAny(char value1, char value2, char value3, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value3;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOfAny_Private_Int32_Char_Char_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00039FF4 File Offset: 0x000381F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290958, XrefRangeEnd = 1290963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOfCharArray(Il2CppStructArray<char> anyOf, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(anyOf);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOfCharArray_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x0003A060 File Offset: 0x00038260
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1290965, RefRangeEnd = 1290969, XrefRangeStart = 1290963, XrefRangeEnd = 1290965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeProbabilisticMap(uint* charMap, ReadOnlySpan<char> anyOf)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = charMap;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(anyOf));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_InitializeProbabilisticMap_Private_Static_Void_ptr_UInt32_ReadOnlySpan_1_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x0003A0A8 File Offset: 0x000382A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290969, XrefRangeEnd = 1290970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ArrayContains(char searchChar, Il2CppStructArray<char> anyOf)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref searchChar;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(anyOf);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_ArrayContains_Private_Static_Boolean_Char_Il2CppStructArray_1_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x0003A0F8 File Offset: 0x000382F8
		[CallerCount(0)]
		public unsafe static bool IsCharBitSet(uint* charMap, byte value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = charMap;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IsCharBitSet_Private_Static_Boolean_ptr_UInt32_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x0003A144 File Offset: 0x00038344
		[CallerCount(0)]
		public unsafe static void SetCharBit(uint* charMap, byte value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = charMap;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_SetCharBit_Private_Static_Void_ptr_UInt32_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x0003A184 File Offset: 0x00038384
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 1290971, RefRangeEnd = 1291010, XrefRangeStart = 1290970, XrefRangeEnd = 1290971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOf_Public_Int32_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x0003A1D4 File Offset: 0x000383D4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1291011, RefRangeEnd = 1291019, XrefRangeStart = 1291010, XrefRangeEnd = 1291011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(string value, int startIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOf_Public_Int32_String_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x0003A230 File Offset: 0x00038430
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 1291020, RefRangeEnd = 1291043, XrefRangeStart = 1291019, XrefRangeEnd = 1291020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(string value, StringComparison comparisonType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOf_Public_Int32_String_StringComparison_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x0003A28C File Offset: 0x0003848C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1291044, RefRangeEnd = 1291047, XrefRangeStart = 1291043, XrefRangeEnd = 1291044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(string value, int startIndex, StringComparison comparisonType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOf_Public_Int32_String_Int32_StringComparison_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x0003A2F8 File Offset: 0x000384F8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1291053, RefRangeEnd = 1291057, XrefRangeStart = 1291047, XrefRangeEnd = 1291053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(string value, int startIndex, int count, StringComparison comparisonType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOf_Public_Int32_String_Int32_Int32_StringComparison_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x0003A370 File Offset: 0x00038570
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 1291058, RefRangeEnd = 1291093, XrefRangeStart = 1291057, XrefRangeEnd = 1291058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOf(char value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_LastIndexOf_Public_Int32_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x0003A3BC File Offset: 0x000385BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1291094, RefRangeEnd = 1291097, XrefRangeStart = 1291093, XrefRangeEnd = 1291094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOf(char value, int startIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_LastIndexOf_Public_Int32_Char_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x0003A414 File Offset: 0x00038614
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1291098, RefRangeEnd = 1291100, XrefRangeStart = 1291097, XrefRangeEnd = 1291098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOf(char value, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_LastIndexOf_Public_Int32_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x0003A47C File Offset: 0x0003867C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1291101, RefRangeEnd = 1291105, XrefRangeStart = 1291100, XrefRangeEnd = 1291101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOfAny(Il2CppStructArray<char> anyOf)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(anyOf);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_LastIndexOfAny_Public_Int32_Il2CppStructArray_1_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x0003A4CC File Offset: 0x000386CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1291106, RefRangeEnd = 1291109, XrefRangeStart = 1291105, XrefRangeEnd = 1291106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOfAny(Il2CppStructArray<char> anyOf, int startIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(anyOf);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_LastIndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x0003A528 File Offset: 0x00038728
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1291110, RefRangeEnd = 1291112, XrefRangeStart = 1291109, XrefRangeEnd = 1291110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOfAny(Il2CppStructArray<char> anyOf, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(anyOf);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_LastIndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x0003A594 File Offset: 0x00038794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291112, XrefRangeEnd = 1291117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOfCharArray(Il2CppStructArray<char> anyOf, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(anyOf);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_LastIndexOfCharArray_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x0003A600 File Offset: 0x00038800
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1291118, RefRangeEnd = 1291122, XrefRangeStart = 1291117, XrefRangeEnd = 1291118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOf(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_LastIndexOf_Public_Int32_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x0003A650 File Offset: 0x00038850
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1291123, RefRangeEnd = 1291127, XrefRangeStart = 1291122, XrefRangeEnd = 1291123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOf(string value, StringComparison comparisonType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_LastIndexOf_Public_Int32_String_StringComparison_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x0003A6AC File Offset: 0x000388AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1291129, RefRangeEnd = 1291131, XrefRangeStart = 1291127, XrefRangeEnd = 1291129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_LastIndexOf_Public_Int32_String_Int32_Int32_StringComparison_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x0003A724 File Offset: 0x00038924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291131, XrefRangeEnd = 1291132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe String(Il2CppStructArray<char> value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<string>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x0003A770 File Offset: 0x00038970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291132, XrefRangeEnd = 1291136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Ctor(Il2CppStructArray<char> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Ctor_Private_Static_String_Il2CppStructArray_1_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x0003A7AC File Offset: 0x000389AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe String(Il2CppStructArray<char> value, int startIndex, int length)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<string>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x0003A814 File Offset: 0x00038A14
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1291140, RefRangeEnd = 1291145, XrefRangeStart = 1291136, XrefRangeEnd = 1291140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Ctor(Il2CppStructArray<char> value, int startIndex, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Ctor_Private_Static_String_Il2CppStructArray_1_Char_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x0003A86C File Offset: 0x00038A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe String(char* value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<string>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr__ctor_Public_Void_ptr_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x0003A8B4 File Offset: 0x00038AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291145, XrefRangeEnd = 1291150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Ctor(char* ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Ctor_Private_Static_String_ptr_Char_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x0003A8EC File Offset: 0x00038AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe String(char* value, int startIndex, int length)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<string>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr__ctor_Public_Void_ptr_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x0003A950 File Offset: 0x00038B50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1291153, RefRangeEnd = 1291154, XrefRangeStart = 1291150, XrefRangeEnd = 1291153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Ctor(char* ptr, int startIndex, int length)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Ctor_Private_Static_String_ptr_Char_Int32_Int32_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x0003A9A4 File Offset: 0x00038BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe String(sbyte* value, int startIndex, int length)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<string>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr__ctor_Public_Void_ptr_SByte_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x0003AA08 File Offset: 0x00038C08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1291159, RefRangeEnd = 1291161, XrefRangeStart = 1291154, XrefRangeEnd = 1291159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Ctor(sbyte* value, int startIndex, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Ctor_Private_Static_String_ptr_SByte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x0003AA5C File Offset: 0x00038C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291161, XrefRangeEnd = 1291165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CreateStringForSByteConstructor(byte* pb, int numBytes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pb;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numBytes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CreateStringForSByteConstructor_Private_Static_String_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x0003AAA4 File Offset: 0x00038CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe String(sbyte* value, int startIndex, int length, Encoding enc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<string>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr__ctor_Public_Void_ptr_SByte_Int32_Int32_Encoding_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x0003AB1C File Offset: 0x00038D1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1291172, RefRangeEnd = 1291173, XrefRangeStart = 1291165, XrefRangeEnd = 1291172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Ctor(sbyte* value, int startIndex, int length, Encoding enc)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Ctor_Private_Static_String_ptr_SByte_Int32_Int32_Encoding_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x0003AB84 File Offset: 0x00038D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe String(char c, int count)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<string>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr__ctor_Public_Void_Char_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x0003ABDC File Offset: 0x00038DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291173, XrefRangeEnd = 1291175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Ctor(char c, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Ctor_Private_Static_String_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x0003AC24 File Offset: 0x00038E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291175, XrefRangeEnd = 1291176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe String(ReadOnlySpan<char> value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<string>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr__ctor_Public_Void_ReadOnlySpan_1_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x0003AC74 File Offset: 0x00038E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291176, XrefRangeEnd = 1291183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Ctor(ReadOnlySpan<char> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Ctor_Private_Static_String_ReadOnlySpan_1_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x0003ACB8 File Offset: 0x00038EB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1291188, RefRangeEnd = 1291189, XrefRangeStart = 1291183, XrefRangeEnd = 1291188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Create<TState>(int length, TState state, SpanAction<char, TState> action)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref length;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TState).IsValueType)
			{
				TState tstate = state;
				intPtr = ((tstate is string) ? IL2CPP.ManagedStringToIl2Cpp(tstate as string) : IL2CPP.Il2CppObjectBaseToPtr(tstate as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref state;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(String.MethodInfoStoreGeneric_Create_Public_Static_String_Int32_TState_SpanAction_2_Char_TState_0<TState>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x0003AD4C File Offset: 0x00038F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291189, XrefRangeEnd = 1291190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator ReadOnlySpan<char>(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_op_Implicit_Public_Static_ReadOnlySpan_1_Char_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ReadOnlySpan<char>(intPtr);
			}
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x0003AD88 File Offset: 0x00038F88
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x0003ADC8 File Offset: 0x00038FC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1291192, RefRangeEnd = 1291194, XrefRangeStart = 1291190, XrefRangeEnd = 1291192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Copy(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Copy_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x0003AE04 File Offset: 0x00039004
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 1291231, RefRangeEnd = 1291259, XrefRangeStart = 1291194, XrefRangeEnd = 1291231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyTo(int sourceIndex, Il2CppStructArray<char> destination, int destinationIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sourceIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CopyTo_Public_Void_Int32_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x0003AE70 File Offset: 0x00039070
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 1291264, RefRangeEnd = 1291281, XrefRangeStart = 1291259, XrefRangeEnd = 1291264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<char> ToCharArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_ToCharArray_Public_Il2CppStructArray_1_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x0003AEB0 File Offset: 0x000390B0
		[CallerCount(880)]
		[CachedScanResults(RefRangeStart = 1291281, RefRangeEnd = 1292161, XrefRangeStart = 1291281, XrefRangeEnd = 1291281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNullOrEmpty(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IsNullOrEmpty_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x0003AEF4 File Offset: 0x000390F4
		[CallerCount(45)]
		[CachedScanResults(RefRangeStart = 1292168, RefRangeEnd = 1292213, XrefRangeStart = 1292161, XrefRangeEnd = 1292168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNullOrWhiteSpace(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IsNullOrWhiteSpace_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x0003AF38 File Offset: 0x00039138
		[CallerCount(279)]
		[CachedScanResults(RefRangeStart = 1292213, RefRangeEnd = 1292492, XrefRangeStart = 1292213, XrefRangeEnd = 1292213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ref char GetRawStringData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_GetRawStringData_Internal_byref_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x0003AF6C File Offset: 0x0003916C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1292494, RefRangeEnd = 1292502, XrefRangeStart = 1292492, XrefRangeEnd = 1292494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CreateStringFromEncoding(byte* bytes, int byteLength, Encoding encoding)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = bytes;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CreateStringFromEncoding_Internal_Static_String_ptr_Byte_Int32_Encoding_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x0003AFC4 File Offset: 0x000391C4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1292503, RefRangeEnd = 1292508, XrefRangeStart = 1292502, XrefRangeEnd = 1292503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CreateFromChar(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CreateFromChar_Internal_Static_String_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x0003AFFC File Offset: 0x000391FC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1292518, RefRangeEnd = 1292525, XrefRangeStart = 1292508, XrefRangeEnd = 1292518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void wstrcpy(char* dmem, char* smem, int charCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dmem;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = smem;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_wstrcpy_Internal_Static_Void_ptr_Char_ptr_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x0003B048 File Offset: 0x00039248
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x0003B080 File Offset: 0x00039280
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x0003B0C8 File Offset: 0x000392C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292525, XrefRangeEnd = 1292529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator<char> System_Collections_Generic_IEnumerable_System_Char__GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Char__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<char>>(intPtr3) : null;
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x0003B108 File Offset: 0x00039308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292529, XrefRangeEnd = 1292533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x0003B148 File Offset: 0x00039348
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1292535, RefRangeEnd = 1292537, XrefRangeStart = 1292533, XrefRangeEnd = 1292535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int wcslen(char* ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_wcslen_Internal_Static_Int32_ptr_Char_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x0003B184 File Offset: 0x00039384
		[CallerCount(0)]
		public unsafe TypeCode GetTypeCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x0003B1C0 File Offset: 0x000393C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292537, XrefRangeEnd = 1292541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool System_IConvertible_ToBoolean(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x0003B210 File Offset: 0x00039410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292541, XrefRangeEnd = 1292545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char System_IConvertible_ToChar(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x0003B260 File Offset: 0x00039460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292545, XrefRangeEnd = 1292549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe sbyte System_IConvertible_ToSByte(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x0003B2B0 File Offset: 0x000394B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292549, XrefRangeEnd = 1292553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe byte System_IConvertible_ToByte(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x0003B300 File Offset: 0x00039500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292553, XrefRangeEnd = 1292557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe short System_IConvertible_ToInt16(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x0003B350 File Offset: 0x00039550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292557, XrefRangeEnd = 1292561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ushort System_IConvertible_ToUInt16(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x0003B3A0 File Offset: 0x000395A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292561, XrefRangeEnd = 1292565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int System_IConvertible_ToInt32(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x0003B3F0 File Offset: 0x000395F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292565, XrefRangeEnd = 1292569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint System_IConvertible_ToUInt32(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x0003B440 File Offset: 0x00039640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292569, XrefRangeEnd = 1292573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long System_IConvertible_ToInt64(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x0003B490 File Offset: 0x00039690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292573, XrefRangeEnd = 1292577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ulong System_IConvertible_ToUInt64(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x0003B4E0 File Offset: 0x000396E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292577, XrefRangeEnd = 1292581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float System_IConvertible_ToSingle(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x0003B530 File Offset: 0x00039730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292581, XrefRangeEnd = 1292585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double System_IConvertible_ToDouble(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x0003B580 File Offset: 0x00039780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292585, XrefRangeEnd = 1292589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Decimal System_IConvertible_ToDecimal(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x0003B5D0 File Offset: 0x000397D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292589, XrefRangeEnd = 1292593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime System_IConvertible_ToDateTime(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x0003B620 File Offset: 0x00039820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292593, XrefRangeEnd = 1292597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object System_IConvertible_ToType(Type type, IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x0003B684 File Offset: 0x00039884
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1292601, RefRangeEnd = 1292611, XrefRangeStart = 1292597, XrefRangeEnd = 1292601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Normalize(NormalizationForm normalizationForm)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref normalizationForm;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Normalize_Public_String_NormalizationForm_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x0003B6C8 File Offset: 0x000398C8
		public unsafe int Length
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0003B704 File Offset: 0x00039904
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1292613, RefRangeEnd = 1292614, XrefRangeStart = 1292611, XrefRangeEnd = 1292613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOfUnchecked(string value, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOfUnchecked_Internal_Int32_String_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x0003B770 File Offset: 0x00039970
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1292620, RefRangeEnd = 1292622, XrefRangeStart = 1292614, XrefRangeEnd = 1292620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOfUncheckedIgnoreCase(string value, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOfUncheckedIgnoreCase_Internal_Int32_String_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x0003B7DC File Offset: 0x000399DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1292623, RefRangeEnd = 1292624, XrefRangeStart = 1292622, XrefRangeEnd = 1292623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOfUnchecked(string value, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_LastIndexOfUnchecked_Internal_Int32_String_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x0003B848 File Offset: 0x00039A48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1292629, RefRangeEnd = 1292631, XrefRangeStart = 1292624, XrefRangeEnd = 1292629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOfUncheckedIgnoreCase(string value, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_LastIndexOfUncheckedIgnoreCase_Internal_Int32_String_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0003B8B4 File Offset: 0x00039AB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1292631, RefRangeEnd = 1292633, XrefRangeStart = 1292631, XrefRangeEnd = 1292631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StartsWithOrdinalUnchecked(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_StartsWithOrdinalUnchecked_Internal_Boolean_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x0003B904 File Offset: 0x00039B04
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 1292634, RefRangeEnd = 1292652, XrefRangeStart = 1292633, XrefRangeEnd = 1292634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FastAllocateString(int length)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_FastAllocateString_Internal_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x0003B93C File Offset: 0x00039B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292652, XrefRangeEnd = 1292653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void memset(byte* dest, int val, int len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_memset_Private_Static_Void_ptr_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0003B98C File Offset: 0x00039B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292653, XrefRangeEnd = 1292654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void memcpy(byte* dest, byte* src, int size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = src;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_memcpy_Private_Static_Void_ptr_Byte_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0003B9D8 File Offset: 0x00039BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292654, XrefRangeEnd = 1292656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void bzero(byte* dest, int len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_bzero_Internal_Static_Void_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x0003BA18 File Offset: 0x00039C18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1050818, RefRangeEnd = 1050819, XrefRangeStart = 1050818, XrefRangeEnd = 1050819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void bzero_aligned_1(byte* dest, int len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_bzero_aligned_1_Internal_Static_Void_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x0003BA58 File Offset: 0x00039C58
		[CallerCount(0)]
		public unsafe static void bzero_aligned_2(byte* dest, int len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_bzero_aligned_2_Internal_Static_Void_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0003BA98 File Offset: 0x00039C98
		[CallerCount(0)]
		public unsafe static void bzero_aligned_4(byte* dest, int len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_bzero_aligned_4_Internal_Static_Void_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x0003BAD8 File Offset: 0x00039CD8
		[CallerCount(0)]
		public unsafe static void bzero_aligned_8(byte* dest, int len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_bzero_aligned_8_Internal_Static_Void_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x0003BB18 File Offset: 0x00039D18
		[CallerCount(0)]
		public unsafe static void memcpy_aligned_1(byte* dest, byte* src, int size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = src;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_memcpy_aligned_1_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x0003BB64 File Offset: 0x00039D64
		[CallerCount(0)]
		public unsafe static void memcpy_aligned_2(byte* dest, byte* src, int size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = src;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_memcpy_aligned_2_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x0003BBB0 File Offset: 0x00039DB0
		[CallerCount(0)]
		public unsafe static void memcpy_aligned_4(byte* dest, byte* src, int size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = src;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_memcpy_aligned_4_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x0003BBFC File Offset: 0x00039DFC
		[CallerCount(0)]
		public unsafe static void memcpy_aligned_8(byte* dest, byte* src, int size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = src;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_memcpy_aligned_8_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x0003BC48 File Offset: 0x00039E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292656, XrefRangeEnd = 1292657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CreateString(sbyte* value, int startIndex, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CreateString_Private_String_ptr_SByte_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x0003BCA8 File Offset: 0x00039EA8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1292662, RefRangeEnd = 1292667, XrefRangeStart = 1292657, XrefRangeEnd = 1292662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CreateString(char* value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CreateString_Private_String_ptr_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x0003BCEC File Offset: 0x00039EEC
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1292668, RefRangeEnd = 1292684, XrefRangeStart = 1292667, XrefRangeEnd = 1292668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CreateString(char* value, int startIndex, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CreateString_Private_String_ptr_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x0003BD4C File Offset: 0x00039F4C
		[CallerCount(60)]
		[CachedScanResults(RefRangeStart = 1292685, RefRangeEnd = 1292745, XrefRangeStart = 1292684, XrefRangeEnd = 1292685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CreateString(Il2CppStructArray<char> val, int startIndex, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(val);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CreateString_Private_String_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x0003BDB0 File Offset: 0x00039FB0
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 1292748, RefRangeEnd = 1292777, XrefRangeStart = 1292745, XrefRangeEnd = 1292748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CreateString(Il2CppStructArray<char> val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(val);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CreateString_Private_String_Il2CppStructArray_1_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x0003BDF8 File Offset: 0x00039FF8
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 1292779, RefRangeEnd = 1292800, XrefRangeStart = 1292777, XrefRangeEnd = 1292779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CreateString(char c, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CreateString_Private_String_Char_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x0003BE4C File Offset: 0x0003A04C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1292801, RefRangeEnd = 1292804, XrefRangeStart = 1292800, XrefRangeEnd = 1292801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CreateString(sbyte* value, int startIndex, int length, Encoding enc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CreateString_Private_String_ptr_SByte_Int32_Int32_Encoding_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x0003BEC0 File Offset: 0x0003A0C0
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 1292811, RefRangeEnd = 1292838, XrefRangeStart = 1292804, XrefRangeEnd = 1292811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CreateString(ReadOnlySpan<char> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CreateString_Private_String_ReadOnlySpan_1_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700010D RID: 269
		[IndexerName("Chars")]
		public unsafe char this[int index]
		{
			[CallerCount(1550)]
			[CachedScanResults(RefRangeStart = 1292839, RefRangeEnd = 1294389, XrefRangeStart = 1292838, XrefRangeEnd = 1292839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_get_Chars_Public_get_Char_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00003852 File Offset: 0x00001A52
		public static string Concat(params Object[] args)
		{
			return String.Concat(new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x0000385F File Offset: 0x00001A5F
		public static string Concat(params string[] values)
		{
			return String.Concat(new Il2CppStringArray(values));
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x0000386C File Offset: 0x00001A6C
		public static string Format(string format, params Object[] args)
		{
			return String.Format(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x0000387A File Offset: 0x00001A7A
		public static string Format(IFormatProvider provider, string format, params Object[] args)
		{
			return String.Format(provider, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00003889 File Offset: 0x00001A89
		public static string Join(char separator, params Object[] values)
		{
			return String.Join(separator, new Il2CppReferenceArray<Object>(values));
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00003897 File Offset: 0x00001A97
		public static string Join(string separator, params string[] value)
		{
			return String.Join(separator, new Il2CppStringArray(value));
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x000038A5 File Offset: 0x00001AA5
		public static string Join(string separator, params Object[] values)
		{
			return String.Join(separator, new Il2CppReferenceArray<Object>(values));
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x000038B3 File Offset: 0x00001AB3
		public Il2CppStringArray Split(params char[] separator)
		{
			return this.Split(new Il2CppStructArray<char>(separator));
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x000038C1 File Offset: 0x00001AC1
		public string Trim(params char[] trimChars)
		{
			return this.Trim(new Il2CppStructArray<char>(trimChars));
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x000038CF File Offset: 0x00001ACF
		public string TrimStart(params char[] trimChars)
		{
			return this.TrimStart(new Il2CppStructArray<char>(trimChars));
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x000038DD File Offset: 0x00001ADD
		public string TrimEnd(params char[] trimChars)
		{
			return this.TrimEnd(new Il2CppStructArray<char>(trimChars));
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x000038EB File Offset: 0x00001AEB
		public String(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x0600051E RID: 1310 RVA: 0x0003BF5C File Offset: 0x0003A15C
		// (set) Token: 0x0600051F RID: 1311 RVA: 0x000038F4 File Offset: 0x00001AF4
		public unsafe static int StackallocIntBufferSizeLimit
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(String.NativeFieldInfoPtr_StackallocIntBufferSizeLimit, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(String.NativeFieldInfoPtr_StackallocIntBufferSizeLimit, (void*)(&value));
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x0003BF78 File Offset: 0x0003A178
		// (set) Token: 0x06000521 RID: 1313 RVA: 0x00003902 File Offset: 0x00001B02
		public unsafe static int PROBABILISTICMAP_BLOCK_INDEX_MASK
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(String.NativeFieldInfoPtr_PROBABILISTICMAP_BLOCK_INDEX_MASK, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(String.NativeFieldInfoPtr_PROBABILISTICMAP_BLOCK_INDEX_MASK, (void*)(&value));
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000522 RID: 1314 RVA: 0x0003BF94 File Offset: 0x0003A194
		// (set) Token: 0x06000523 RID: 1315 RVA: 0x00003910 File Offset: 0x00001B10
		public unsafe static int PROBABILISTICMAP_BLOCK_INDEX_SHIFT
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(String.NativeFieldInfoPtr_PROBABILISTICMAP_BLOCK_INDEX_SHIFT, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(String.NativeFieldInfoPtr_PROBABILISTICMAP_BLOCK_INDEX_SHIFT, (void*)(&value));
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x0003BFB0 File Offset: 0x0003A1B0
		// (set) Token: 0x06000525 RID: 1317 RVA: 0x0000391E File Offset: 0x00001B1E
		public unsafe static int PROBABILISTICMAP_SIZE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(String.NativeFieldInfoPtr_PROBABILISTICMAP_SIZE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(String.NativeFieldInfoPtr_PROBABILISTICMAP_SIZE, (void*)(&value));
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x0003BFCC File Offset: 0x0003A1CC
		// (set) Token: 0x06000527 RID: 1319 RVA: 0x0000392C File Offset: 0x00001B2C
		public unsafe int _stringLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(String.NativeFieldInfoPtr__stringLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.ManagedStringToIl2Cpp(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(String.NativeFieldInfoPtr__stringLength)) = value;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x0003BFF4 File Offset: 0x0003A1F4
		// (set) Token: 0x06000529 RID: 1321 RVA: 0x00003947 File Offset: 0x00001B47
		public unsafe char _firstChar
		{
			get
			{
				IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(String.NativeFieldInfoPtr__firstChar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.ManagedStringToIl2Cpp(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(String.NativeFieldInfoPtr__firstChar)) = value;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x0003C01C File Offset: 0x0003A21C
		// (set) Token: 0x0600052B RID: 1323 RVA: 0x00003962 File Offset: 0x00001B62
		public unsafe static string Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(String.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(String.NativeFieldInfoPtr_Empty, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00003974 File Offset: 0x00001B74
		public new static implicit operator String(string A_0)
		{
			if (A_0 == null)
			{
				return A_0;
			}
			return new String(IL2CPP.ManagedStringToIl2Cpp(A_0));
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00003986 File Offset: 0x00001B86
		public static implicit operator string(String A_0)
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			if (intPtr == 0)
			{
				return null;
			}
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0400031E RID: 798
		private static readonly IntPtr NativeFieldInfoPtr_StackallocIntBufferSizeLimit;

		// Token: 0x0400031F RID: 799
		private static readonly IntPtr NativeFieldInfoPtr_PROBABILISTICMAP_BLOCK_INDEX_MASK;

		// Token: 0x04000320 RID: 800
		private static readonly IntPtr NativeFieldInfoPtr_PROBABILISTICMAP_BLOCK_INDEX_SHIFT;

		// Token: 0x04000321 RID: 801
		private static readonly IntPtr NativeFieldInfoPtr_PROBABILISTICMAP_SIZE;

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeFieldInfoPtr__stringLength;

		// Token: 0x04000323 RID: 803
		private static readonly IntPtr NativeFieldInfoPtr__firstChar;

		// Token: 0x04000324 RID: 804
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x04000325 RID: 805
		private static readonly IntPtr NativeMethodInfoPtr_EqualsHelper_Private_Static_Boolean_String_String_0;

		// Token: 0x04000326 RID: 806
		private static readonly IntPtr NativeMethodInfoPtr_CompareOrdinalHelper_Private_Static_Int32_String_Int32_Int32_String_Int32_Int32_0;

		// Token: 0x04000327 RID: 807
		private static readonly IntPtr NativeMethodInfoPtr_CompareOrdinalHelper_Private_Static_Int32_String_String_0;

		// Token: 0x04000328 RID: 808
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_0;

		// Token: 0x04000329 RID: 809
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_Boolean_0;

		// Token: 0x0400032A RID: 810
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_StringComparison_0;

		// Token: 0x0400032B RID: 811
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_CultureInfo_CompareOptions_0;

		// Token: 0x0400032C RID: 812
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_Boolean_CultureInfo_0;

		// Token: 0x0400032D RID: 813
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Int32_String_Int32_String_Int32_Int32_StringComparison_0;

		// Token: 0x0400032E RID: 814
		private static readonly IntPtr NativeMethodInfoPtr_CompareOrdinal_Public_Static_Int32_String_String_0;

		// Token: 0x0400032F RID: 815
		private static readonly IntPtr NativeMethodInfoPtr_CompareOrdinal_Internal_Static_Int32_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0;

		// Token: 0x04000330 RID: 816
		private static readonly IntPtr NativeMethodInfoPtr_CompareOrdinal_Public_Static_Int32_String_Int32_String_Int32_Int32_0;

		// Token: 0x04000331 RID: 817
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000332 RID: 818
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_String_0;

		// Token: 0x04000333 RID: 819
		private static readonly IntPtr NativeMethodInfoPtr_EndsWith_Public_Boolean_String_0;

		// Token: 0x04000334 RID: 820
		private static readonly IntPtr NativeMethodInfoPtr_EndsWith_Public_Boolean_String_StringComparison_0;

		// Token: 0x04000335 RID: 821
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000336 RID: 822
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_String_0;

		// Token: 0x04000337 RID: 823
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_String_StringComparison_0;

		// Token: 0x04000338 RID: 824
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Static_Boolean_String_String_0;

		// Token: 0x04000339 RID: 825
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Static_Boolean_String_String_StringComparison_0;

		// Token: 0x0400033A RID: 826
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_String_String_0;

		// Token: 0x0400033B RID: 827
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_String_String_0;

		// Token: 0x0400033C RID: 828
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400033D RID: 829
		private static readonly IntPtr NativeMethodInfoPtr_GetLegacyNonRandomizedHashCode_Internal_Int32_0;

		// Token: 0x0400033E RID: 830
		private static readonly IntPtr NativeMethodInfoPtr_StartsWith_Public_Boolean_String_0;

		// Token: 0x0400033F RID: 831
		private static readonly IntPtr NativeMethodInfoPtr_StartsWith_Public_Boolean_String_StringComparison_0;

		// Token: 0x04000340 RID: 832
		private static readonly IntPtr NativeMethodInfoPtr_StartsWith_Public_Boolean_String_Boolean_CultureInfo_0;

		// Token: 0x04000341 RID: 833
		private static readonly IntPtr NativeMethodInfoPtr_StartsWith_Public_Boolean_Char_0;

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeMethodInfoPtr_CheckStringComparison_Internal_Static_Void_StringComparison_0;

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeMethodInfoPtr_FillStringChecked_Private_Static_Void_String_Int32_String_0;

		// Token: 0x04000344 RID: 836
		private static readonly IntPtr NativeMethodInfoPtr_Concat_Public_Static_String_Object_Object_0;

		// Token: 0x04000345 RID: 837
		private static readonly IntPtr NativeMethodInfoPtr_Concat_Public_Static_String_Object_Object_Object_0;

		// Token: 0x04000346 RID: 838
		private static readonly IntPtr NativeMethodInfoPtr_Concat_Public_Static_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000347 RID: 839
		private static readonly IntPtr NativeMethodInfoPtr_Concat_Public_Static_String_IEnumerable_1_T_0;

		// Token: 0x04000348 RID: 840
		private static readonly IntPtr NativeMethodInfoPtr_Concat_Public_Static_String_String_String_0;

		// Token: 0x04000349 RID: 841
		private static readonly IntPtr NativeMethodInfoPtr_Concat_Public_Static_String_String_String_String_0;

		// Token: 0x0400034A RID: 842
		private static readonly IntPtr NativeMethodInfoPtr_Concat_Public_Static_String_String_String_String_String_0;

		// Token: 0x0400034B RID: 843
		private static readonly IntPtr NativeMethodInfoPtr_Concat_Public_Static_String_Il2CppStringArray_0;

		// Token: 0x0400034C RID: 844
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_String_String_Object_0;

		// Token: 0x0400034D RID: 845
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_String_String_Object_Object_0;

		// Token: 0x0400034E RID: 846
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_String_String_Object_Object_Object_0;

		// Token: 0x0400034F RID: 847
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_String_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000350 RID: 848
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Object_0;

		// Token: 0x04000351 RID: 849
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Object_Object_0;

		// Token: 0x04000352 RID: 850
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Object_Object_Object_0;

		// Token: 0x04000353 RID: 851
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000354 RID: 852
		private static readonly IntPtr NativeMethodInfoPtr_FormatHelper_Private_Static_String_IFormatProvider_String_ParamsArray_0;

		// Token: 0x04000355 RID: 853
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_String_Int32_String_0;

		// Token: 0x04000356 RID: 854
		private static readonly IntPtr NativeMethodInfoPtr_Join_Public_Static_String_Char_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000357 RID: 855
		private static readonly IntPtr NativeMethodInfoPtr_Join_Public_Static_String_Char_IEnumerable_1_T_0;

		// Token: 0x04000358 RID: 856
		private static readonly IntPtr NativeMethodInfoPtr_Join_Public_Static_String_String_Il2CppStringArray_0;

		// Token: 0x04000359 RID: 857
		private static readonly IntPtr NativeMethodInfoPtr_Join_Public_Static_String_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400035A RID: 858
		private static readonly IntPtr NativeMethodInfoPtr_Join_Public_Static_String_String_IEnumerable_1_T_0;

		// Token: 0x0400035B RID: 859
		private static readonly IntPtr NativeMethodInfoPtr_Join_Public_Static_String_String_IEnumerable_1_String_0;

		// Token: 0x0400035C RID: 860
		private static readonly IntPtr NativeMethodInfoPtr_Join_Public_Static_String_String_Il2CppStringArray_Int32_Int32_0;

		// Token: 0x0400035D RID: 861
		private static readonly IntPtr NativeMethodInfoPtr_JoinCore_Private_Static_String_ptr_Char_Int32_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400035E RID: 862
		private static readonly IntPtr NativeMethodInfoPtr_JoinCore_Private_Static_String_ptr_Char_Int32_IEnumerable_1_T_0;

		// Token: 0x0400035F RID: 863
		private static readonly IntPtr NativeMethodInfoPtr_JoinCore_Private_Static_String_ptr_Char_Int32_Il2CppStringArray_Int32_Int32_0;

		// Token: 0x04000360 RID: 864
		private static readonly IntPtr NativeMethodInfoPtr_PadLeft_Public_String_Int32_Char_0;

		// Token: 0x04000361 RID: 865
		private static readonly IntPtr NativeMethodInfoPtr_PadRight_Public_String_Int32_Char_0;

		// Token: 0x04000362 RID: 866
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_String_Int32_Int32_0;

		// Token: 0x04000363 RID: 867
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_String_Int32_0;

		// Token: 0x04000364 RID: 868
		private static readonly IntPtr NativeMethodInfoPtr_Replace_Public_String_Char_Char_0;

		// Token: 0x04000365 RID: 869
		private static readonly IntPtr NativeMethodInfoPtr_Replace_Public_String_String_String_0;

		// Token: 0x04000366 RID: 870
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceHelper_Private_String_Int32_String_ReadOnlySpan_1_Int32_0;

		// Token: 0x04000367 RID: 871
		private static readonly IntPtr NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Char_StringSplitOptions_0;

		// Token: 0x04000368 RID: 872
		private static readonly IntPtr NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Char_Int32_StringSplitOptions_0;

		// Token: 0x04000369 RID: 873
		private static readonly IntPtr NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStructArray_1_Char_0;

		// Token: 0x0400036A RID: 874
		private static readonly IntPtr NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x0400036B RID: 875
		private static readonly IntPtr NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStructArray_1_Char_StringSplitOptions_0;

		// Token: 0x0400036C RID: 876
		private static readonly IntPtr NativeMethodInfoPtr_SplitInternal_Private_Il2CppStringArray_ReadOnlySpan_1_Char_Int32_StringSplitOptions_0;

		// Token: 0x0400036D RID: 877
		private static readonly IntPtr NativeMethodInfoPtr_Split_Public_Il2CppStringArray_String_StringSplitOptions_0;

		// Token: 0x0400036E RID: 878
		private static readonly IntPtr NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStringArray_StringSplitOptions_0;

		// Token: 0x0400036F RID: 879
		private static readonly IntPtr NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStringArray_Int32_StringSplitOptions_0;

		// Token: 0x04000370 RID: 880
		private static readonly IntPtr NativeMethodInfoPtr_SplitInternal_Private_Il2CppStringArray_String_Il2CppStringArray_Int32_StringSplitOptions_0;

		// Token: 0x04000371 RID: 881
		private static readonly IntPtr NativeMethodInfoPtr_SplitInternal_Private_Il2CppStringArray_String_Int32_StringSplitOptions_0;

		// Token: 0x04000372 RID: 882
		private static readonly IntPtr NativeMethodInfoPtr_SplitKeepEmptyEntries_Private_Il2CppStringArray_ReadOnlySpan_1_Int32_ReadOnlySpan_1_Int32_Int32_Int32_0;

		// Token: 0x04000373 RID: 883
		private static readonly IntPtr NativeMethodInfoPtr_SplitOmitEmptyEntries_Private_Il2CppStringArray_ReadOnlySpan_1_Int32_ReadOnlySpan_1_Int32_Int32_Int32_0;

		// Token: 0x04000374 RID: 884
		private static readonly IntPtr NativeMethodInfoPtr_MakeSeparatorList_Private_Void_ReadOnlySpan_1_Char_byref_ValueListBuilder_1_Int32_0;

		// Token: 0x04000375 RID: 885
		private static readonly IntPtr NativeMethodInfoPtr_MakeSeparatorList_Private_Void_String_byref_ValueListBuilder_1_Int32_0;

		// Token: 0x04000376 RID: 886
		private static readonly IntPtr NativeMethodInfoPtr_MakeSeparatorList_Private_Void_Il2CppStringArray_byref_ValueListBuilder_1_Int32_byref_ValueListBuilder_1_Int32_0;

		// Token: 0x04000377 RID: 887
		private static readonly IntPtr NativeMethodInfoPtr_Substring_Public_String_Int32_0;

		// Token: 0x04000378 RID: 888
		private static readonly IntPtr NativeMethodInfoPtr_Substring_Public_String_Int32_Int32_0;

		// Token: 0x04000379 RID: 889
		private static readonly IntPtr NativeMethodInfoPtr_InternalSubString_Private_String_Int32_Int32_0;

		// Token: 0x0400037A RID: 890
		private static readonly IntPtr NativeMethodInfoPtr_ToLower_Public_String_0;

		// Token: 0x0400037B RID: 891
		private static readonly IntPtr NativeMethodInfoPtr_ToLower_Public_String_CultureInfo_0;

		// Token: 0x0400037C RID: 892
		private static readonly IntPtr NativeMethodInfoPtr_ToLowerInvariant_Public_String_0;

		// Token: 0x0400037D RID: 893
		private static readonly IntPtr NativeMethodInfoPtr_ToUpper_Public_String_0;

		// Token: 0x0400037E RID: 894
		private static readonly IntPtr NativeMethodInfoPtr_ToUpper_Public_String_CultureInfo_0;

		// Token: 0x0400037F RID: 895
		private static readonly IntPtr NativeMethodInfoPtr_ToUpperInvariant_Public_String_0;

		// Token: 0x04000380 RID: 896
		private static readonly IntPtr NativeMethodInfoPtr_Trim_Public_String_0;

		// Token: 0x04000381 RID: 897
		private static readonly IntPtr NativeMethodInfoPtr_Trim_Public_String_Char_0;

		// Token: 0x04000382 RID: 898
		private static readonly IntPtr NativeMethodInfoPtr_Trim_Public_String_Il2CppStructArray_1_Char_0;

		// Token: 0x04000383 RID: 899
		private static readonly IntPtr NativeMethodInfoPtr_TrimStart_Public_String_Char_0;

		// Token: 0x04000384 RID: 900
		private static readonly IntPtr NativeMethodInfoPtr_TrimStart_Public_String_Il2CppStructArray_1_Char_0;

		// Token: 0x04000385 RID: 901
		private static readonly IntPtr NativeMethodInfoPtr_TrimEnd_Public_String_0;

		// Token: 0x04000386 RID: 902
		private static readonly IntPtr NativeMethodInfoPtr_TrimEnd_Public_String_Char_0;

		// Token: 0x04000387 RID: 903
		private static readonly IntPtr NativeMethodInfoPtr_TrimEnd_Public_String_Il2CppStructArray_1_Char_0;

		// Token: 0x04000388 RID: 904
		private static readonly IntPtr NativeMethodInfoPtr_TrimWhiteSpaceHelper_Private_String_TrimType_0;

		// Token: 0x04000389 RID: 905
		private static readonly IntPtr NativeMethodInfoPtr_TrimHelper_Private_String_ptr_Char_Int32_TrimType_0;

		// Token: 0x0400038A RID: 906
		private static readonly IntPtr NativeMethodInfoPtr_CreateTrimmedString_Private_String_Int32_Int32_0;

		// Token: 0x0400038B RID: 907
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_String_0;

		// Token: 0x0400038C RID: 908
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_Char_0;

		// Token: 0x0400038D RID: 909
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_Char_0;

		// Token: 0x0400038E RID: 910
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_Char_Int32_0;

		// Token: 0x0400038F RID: 911
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_Char_Int32_Int32_0;

		// Token: 0x04000390 RID: 912
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfAny_Public_Int32_Il2CppStructArray_1_Char_0;

		// Token: 0x04000391 RID: 913
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x04000392 RID: 914
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000393 RID: 915
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfAny_Private_Int32_Char_Char_Int32_Int32_0;

		// Token: 0x04000394 RID: 916
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfAny_Private_Int32_Char_Char_Char_Int32_Int32_0;

		// Token: 0x04000395 RID: 917
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfCharArray_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000396 RID: 918
		private static readonly IntPtr NativeMethodInfoPtr_InitializeProbabilisticMap_Private_Static_Void_ptr_UInt32_ReadOnlySpan_1_Char_0;

		// Token: 0x04000397 RID: 919
		private static readonly IntPtr NativeMethodInfoPtr_ArrayContains_Private_Static_Boolean_Char_Il2CppStructArray_1_Char_0;

		// Token: 0x04000398 RID: 920
		private static readonly IntPtr NativeMethodInfoPtr_IsCharBitSet_Private_Static_Boolean_ptr_UInt32_Byte_0;

		// Token: 0x04000399 RID: 921
		private static readonly IntPtr NativeMethodInfoPtr_SetCharBit_Private_Static_Void_ptr_UInt32_Byte_0;

		// Token: 0x0400039A RID: 922
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_String_0;

		// Token: 0x0400039B RID: 923
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_String_Int32_0;

		// Token: 0x0400039C RID: 924
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_String_StringComparison_0;

		// Token: 0x0400039D RID: 925
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_String_Int32_StringComparison_0;

		// Token: 0x0400039E RID: 926
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_String_Int32_Int32_StringComparison_0;

		// Token: 0x0400039F RID: 927
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Int32_Char_0;

		// Token: 0x040003A0 RID: 928
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Int32_Char_Int32_0;

		// Token: 0x040003A1 RID: 929
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Int32_Char_Int32_Int32_0;

		// Token: 0x040003A2 RID: 930
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOfAny_Public_Int32_Il2CppStructArray_1_Char_0;

		// Token: 0x040003A3 RID: 931
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x040003A4 RID: 932
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040003A5 RID: 933
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOfCharArray_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040003A6 RID: 934
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Int32_String_0;

		// Token: 0x040003A7 RID: 935
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Int32_String_StringComparison_0;

		// Token: 0x040003A8 RID: 936
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Int32_String_Int32_Int32_StringComparison_0;

		// Token: 0x040003A9 RID: 937
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Char_0;

		// Token: 0x040003AA RID: 938
		private static readonly IntPtr NativeMethodInfoPtr_Ctor_Private_Static_String_Il2CppStructArray_1_Char_0;

		// Token: 0x040003AB RID: 939
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040003AC RID: 940
		private static readonly IntPtr NativeMethodInfoPtr_Ctor_Private_Static_String_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040003AD RID: 941
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_Char_0;

		// Token: 0x040003AE RID: 942
		private static readonly IntPtr NativeMethodInfoPtr_Ctor_Private_Static_String_ptr_Char_0;

		// Token: 0x040003AF RID: 943
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_Char_Int32_Int32_0;

		// Token: 0x040003B0 RID: 944
		private static readonly IntPtr NativeMethodInfoPtr_Ctor_Private_Static_String_ptr_Char_Int32_Int32_0;

		// Token: 0x040003B1 RID: 945
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_SByte_Int32_Int32_0;

		// Token: 0x040003B2 RID: 946
		private static readonly IntPtr NativeMethodInfoPtr_Ctor_Private_Static_String_ptr_SByte_Int32_Int32_0;

		// Token: 0x040003B3 RID: 947
		private static readonly IntPtr NativeMethodInfoPtr_CreateStringForSByteConstructor_Private_Static_String_ptr_Byte_Int32_0;

		// Token: 0x040003B4 RID: 948
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_SByte_Int32_Int32_Encoding_0;

		// Token: 0x040003B5 RID: 949
		private static readonly IntPtr NativeMethodInfoPtr_Ctor_Private_Static_String_ptr_SByte_Int32_Int32_Encoding_0;

		// Token: 0x040003B6 RID: 950
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Char_Int32_0;

		// Token: 0x040003B7 RID: 951
		private static readonly IntPtr NativeMethodInfoPtr_Ctor_Private_Static_String_Char_Int32_0;

		// Token: 0x040003B8 RID: 952
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ReadOnlySpan_1_Char_0;

		// Token: 0x040003B9 RID: 953
		private static readonly IntPtr NativeMethodInfoPtr_Ctor_Private_Static_String_ReadOnlySpan_1_Char_0;

		// Token: 0x040003BA RID: 954
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_String_Int32_TState_SpanAction_2_Char_TState_0;

		// Token: 0x040003BB RID: 955
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ReadOnlySpan_1_Char_String_0;

		// Token: 0x040003BC RID: 956
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x040003BD RID: 957
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_String_String_0;

		// Token: 0x040003BE RID: 958
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Void_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040003BF RID: 959
		private static readonly IntPtr NativeMethodInfoPtr_ToCharArray_Public_Il2CppStructArray_1_Char_0;

		// Token: 0x040003C0 RID: 960
		private static readonly IntPtr NativeMethodInfoPtr_IsNullOrEmpty_Public_Static_Boolean_String_0;

		// Token: 0x040003C1 RID: 961
		private static readonly IntPtr NativeMethodInfoPtr_IsNullOrWhiteSpace_Public_Static_Boolean_String_0;

		// Token: 0x040003C2 RID: 962
		private static readonly IntPtr NativeMethodInfoPtr_GetRawStringData_Internal_byref_Char_0;

		// Token: 0x040003C3 RID: 963
		private static readonly IntPtr NativeMethodInfoPtr_CreateStringFromEncoding_Internal_Static_String_ptr_Byte_Int32_Encoding_0;

		// Token: 0x040003C4 RID: 964
		private static readonly IntPtr NativeMethodInfoPtr_CreateFromChar_Internal_Static_String_Char_0;

		// Token: 0x040003C5 RID: 965
		private static readonly IntPtr NativeMethodInfoPtr_wstrcpy_Internal_Static_Void_ptr_Char_ptr_Char_Int32_0;

		// Token: 0x040003C6 RID: 966
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040003C7 RID: 967
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0;

		// Token: 0x040003C8 RID: 968
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Char__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Char_0;

		// Token: 0x040003C9 RID: 969
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x040003CA RID: 970
		private static readonly IntPtr NativeMethodInfoPtr_wcslen_Internal_Static_Int32_ptr_Char_0;

		// Token: 0x040003CB RID: 971
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0;

		// Token: 0x040003CC RID: 972
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0;

		// Token: 0x040003CD RID: 973
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0;

		// Token: 0x040003CE RID: 974
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0;

		// Token: 0x040003CF RID: 975
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0;

		// Token: 0x040003D0 RID: 976
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0;

		// Token: 0x040003D1 RID: 977
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0;

		// Token: 0x040003D2 RID: 978
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0;

		// Token: 0x040003D3 RID: 979
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0;

		// Token: 0x040003D4 RID: 980
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0;

		// Token: 0x040003D5 RID: 981
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0;

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0;

		// Token: 0x040003D7 RID: 983
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0;

		// Token: 0x040003D8 RID: 984
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0;

		// Token: 0x040003D9 RID: 985
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0;

		// Token: 0x040003DA RID: 986
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0;

		// Token: 0x040003DB RID: 987
		private static readonly IntPtr NativeMethodInfoPtr_Normalize_Public_String_NormalizationForm_0;

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

		// Token: 0x040003DD RID: 989
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfUnchecked_Internal_Int32_String_Int32_Int32_0;

		// Token: 0x040003DE RID: 990
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfUncheckedIgnoreCase_Internal_Int32_String_Int32_Int32_0;

		// Token: 0x040003DF RID: 991
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOfUnchecked_Internal_Int32_String_Int32_Int32_0;

		// Token: 0x040003E0 RID: 992
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOfUncheckedIgnoreCase_Internal_Int32_String_Int32_Int32_0;

		// Token: 0x040003E1 RID: 993
		private static readonly IntPtr NativeMethodInfoPtr_StartsWithOrdinalUnchecked_Internal_Boolean_String_0;

		// Token: 0x040003E2 RID: 994
		private static readonly IntPtr NativeMethodInfoPtr_FastAllocateString_Internal_Static_String_Int32_0;

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeMethodInfoPtr_memset_Private_Static_Void_ptr_Byte_Int32_Int32_0;

		// Token: 0x040003E4 RID: 996
		private static readonly IntPtr NativeMethodInfoPtr_memcpy_Private_Static_Void_ptr_Byte_ptr_Byte_Int32_0;

		// Token: 0x040003E5 RID: 997
		private static readonly IntPtr NativeMethodInfoPtr_bzero_Internal_Static_Void_ptr_Byte_Int32_0;

		// Token: 0x040003E6 RID: 998
		private static readonly IntPtr NativeMethodInfoPtr_bzero_aligned_1_Internal_Static_Void_ptr_Byte_Int32_0;

		// Token: 0x040003E7 RID: 999
		private static readonly IntPtr NativeMethodInfoPtr_bzero_aligned_2_Internal_Static_Void_ptr_Byte_Int32_0;

		// Token: 0x040003E8 RID: 1000
		private static readonly IntPtr NativeMethodInfoPtr_bzero_aligned_4_Internal_Static_Void_ptr_Byte_Int32_0;

		// Token: 0x040003E9 RID: 1001
		private static readonly IntPtr NativeMethodInfoPtr_bzero_aligned_8_Internal_Static_Void_ptr_Byte_Int32_0;

		// Token: 0x040003EA RID: 1002
		private static readonly IntPtr NativeMethodInfoPtr_memcpy_aligned_1_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0;

		// Token: 0x040003EB RID: 1003
		private static readonly IntPtr NativeMethodInfoPtr_memcpy_aligned_2_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0;

		// Token: 0x040003EC RID: 1004
		private static readonly IntPtr NativeMethodInfoPtr_memcpy_aligned_4_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0;

		// Token: 0x040003ED RID: 1005
		private static readonly IntPtr NativeMethodInfoPtr_memcpy_aligned_8_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0;

		// Token: 0x040003EE RID: 1006
		private static readonly IntPtr NativeMethodInfoPtr_CreateString_Private_String_ptr_SByte_Int32_Int32_0;

		// Token: 0x040003EF RID: 1007
		private static readonly IntPtr NativeMethodInfoPtr_CreateString_Private_String_ptr_Char_0;

		// Token: 0x040003F0 RID: 1008
		private static readonly IntPtr NativeMethodInfoPtr_CreateString_Private_String_ptr_Char_Int32_Int32_0;

		// Token: 0x040003F1 RID: 1009
		private static readonly IntPtr NativeMethodInfoPtr_CreateString_Private_String_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040003F2 RID: 1010
		private static readonly IntPtr NativeMethodInfoPtr_CreateString_Private_String_Il2CppStructArray_1_Char_0;

		// Token: 0x040003F3 RID: 1011
		private static readonly IntPtr NativeMethodInfoPtr_CreateString_Private_String_Char_Int32_0;

		// Token: 0x040003F4 RID: 1012
		private static readonly IntPtr NativeMethodInfoPtr_CreateString_Private_String_ptr_SByte_Int32_Int32_Encoding_0;

		// Token: 0x040003F5 RID: 1013
		private static readonly IntPtr NativeMethodInfoPtr_CreateString_Private_String_ReadOnlySpan_1_Char_0;

		// Token: 0x040003F6 RID: 1014
		private static readonly IntPtr NativeMethodInfoPtr_get_Chars_Public_get_Char_Int32_0;

		// Token: 0x02000574 RID: 1396
		public enum TrimType
		{
			// Token: 0x04004632 RID: 17970
			Head,
			// Token: 0x04004633 RID: 17971
			Tail,
			// Token: 0x04004634 RID: 17972
			Both
		}

		// Token: 0x02000575 RID: 1397
		[StructLayout(2)]
		public struct ProbabilisticMap
		{
			// Token: 0x06005602 RID: 22018 RVA: 0x0001E8F1 File Offset: 0x0001CAF1
			// Note: this type is marked as 'beforefieldinit'.
			static ProbabilisticMap()
			{
				Il2CppClassPointerStore<String.ProbabilisticMap>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<string>.NativeClassPtr, "ProbabilisticMap");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<String.ProbabilisticMap>.NativeClassPtr);
			}

			// Token: 0x06005603 RID: 22019 RVA: 0x0001E911 File Offset: 0x0001CB11
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<String.ProbabilisticMap>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000576 RID: 1398
		private sealed class MethodInfoStoreGeneric_Concat_Public_Static_String_IEnumerable_1_T_0<T>
		{
			// Token: 0x04004635 RID: 17973
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(String.NativeMethodInfoPtr_Concat_Public_Static_String_IEnumerable_1_T_0, Il2CppClassPointerStore<string>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000577 RID: 1399
		private sealed class MethodInfoStoreGeneric_Join_Public_Static_String_Char_IEnumerable_1_T_0<T>
		{
			// Token: 0x04004636 RID: 17974
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(String.NativeMethodInfoPtr_Join_Public_Static_String_Char_IEnumerable_1_T_0, Il2CppClassPointerStore<string>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000578 RID: 1400
		private sealed class MethodInfoStoreGeneric_Join_Public_Static_String_String_IEnumerable_1_T_0<T>
		{
			// Token: 0x04004637 RID: 17975
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(String.NativeMethodInfoPtr_Join_Public_Static_String_String_IEnumerable_1_T_0, Il2CppClassPointerStore<string>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000579 RID: 1401
		private sealed class MethodInfoStoreGeneric_JoinCore_Private_Static_String_ptr_Char_Int32_IEnumerable_1_T_0<T>
		{
			// Token: 0x04004638 RID: 17976
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(String.NativeMethodInfoPtr_JoinCore_Private_Static_String_ptr_Char_Int32_IEnumerable_1_T_0, Il2CppClassPointerStore<string>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200057A RID: 1402
		private sealed class MethodInfoStoreGeneric_Create_Public_Static_String_Int32_TState_SpanAction_2_Char_TState_0<TState>
		{
			// Token: 0x04004639 RID: 17977
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(String.NativeMethodInfoPtr_Create_Public_Static_String_Int32_TState_SpanAction_2_Char_TState_0, Il2CppClassPointerStore<string>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TState>.NativeClassPtr)) }))));
		}
	}
}
