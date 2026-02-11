using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Threading;

namespace Il2CppSystem
{
	// Token: 0x02000137 RID: 311
	[Serializable]
	public class RuntimeType : TypeInfo
	{
		// Token: 0x060014DC RID: 5340 RVA: 0x0008ABE8 File Offset: 0x00088DE8
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeType()
		{
			Il2CppClassPointerStore<RuntimeType>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "RuntimeType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr);
			RuntimeType.NativeFieldInfoPtr_ValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, "ValueType");
			RuntimeType.NativeFieldInfoPtr_EnumType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, "EnumType");
			RuntimeType.NativeFieldInfoPtr_ObjectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, "ObjectType");
			RuntimeType.NativeFieldInfoPtr_StringType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, "StringType");
			RuntimeType.NativeFieldInfoPtr_DelegateType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, "DelegateType");
			RuntimeType.NativeFieldInfoPtr_s_SICtorParamTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, "s_SICtorParamTypes");
			RuntimeType.NativeFieldInfoPtr_MakeTypeBuilderInstantiation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, "MakeTypeBuilderInstantiation");
			RuntimeType.NativeFieldInfoPtr_MemberBindingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, "MemberBindingMask");
			RuntimeType.NativeFieldInfoPtr_InvocationMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, "InvocationMask");
			RuntimeType.NativeFieldInfoPtr_BinderNonCreateInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, "BinderNonCreateInstance");
			RuntimeType.NativeFieldInfoPtr_BinderGetSetProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, "BinderGetSetProperty");
			RuntimeType.NativeFieldInfoPtr_BinderSetInvokeProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, "BinderSetInvokeProperty");
			RuntimeType.NativeFieldInfoPtr_BinderGetSetField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, "BinderGetSetField");
			RuntimeType.NativeFieldInfoPtr_BinderSetInvokeField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, "BinderSetInvokeField");
			RuntimeType.NativeFieldInfoPtr_BinderNonFieldGetSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, "BinderNonFieldGetSet");
			RuntimeType.NativeFieldInfoPtr_ClassicBindingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, "ClassicBindingMask");
			RuntimeType.NativeFieldInfoPtr_s_typedRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, "s_typedRef");
			RuntimeType.NativeFieldInfoPtr_type_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, "type_info");
			RuntimeType.NativeFieldInfoPtr_GenericCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, "GenericCache");
			RuntimeType.NativeFieldInfoPtr_m_serializationCtor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, "m_serializationCtor");
			RuntimeType.NativeFieldInfoPtr_GenericParameterCountAny = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, "GenericParameterCountAny");
			RuntimeType.NativeMethodInfoPtr_GetType_Internal_Static_RuntimeType_String_Boolean_Boolean_Boolean_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667009);
			RuntimeType.NativeMethodInfoPtr_ThrowIfTypeNeverValidGenericArgument_Private_Static_Void_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667010);
			RuntimeType.NativeMethodInfoPtr_SanityCheckGenericArguments_Internal_Static_Void_Il2CppReferenceArray_1_RuntimeType_Il2CppReferenceArray_1_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667011);
			RuntimeType.NativeMethodInfoPtr_SplitName_Private_Static_Void_String_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667012);
			RuntimeType.NativeMethodInfoPtr_FilterPreCalculate_Internal_Static_BindingFlags_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667013);
			RuntimeType.NativeMethodInfoPtr_FilterHelper_Private_Static_Void_BindingFlags_byref_String_Boolean_byref_Boolean_byref_Boolean_byref_MemberListType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667014);
			RuntimeType.NativeMethodInfoPtr_FilterHelper_Private_Static_Void_BindingFlags_byref_String_byref_Boolean_byref_MemberListType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667015);
			RuntimeType.NativeMethodInfoPtr_FilterApplyPrefixLookup_Private_Static_Boolean_MemberInfo_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667016);
			RuntimeType.NativeMethodInfoPtr_FilterApplyBase_Private_Static_Boolean_MemberInfo_BindingFlags_Boolean_Boolean_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667017);
			RuntimeType.NativeMethodInfoPtr_FilterApplyType_Private_Static_Boolean_Type_BindingFlags_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667018);
			RuntimeType.NativeMethodInfoPtr_FilterApplyMethodInfo_Private_Static_Boolean_RuntimeMethodInfo_BindingFlags_CallingConventions_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667019);
			RuntimeType.NativeMethodInfoPtr_FilterApplyConstructorInfo_Private_Static_Boolean_RuntimeConstructorInfo_BindingFlags_CallingConventions_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667020);
			RuntimeType.NativeMethodInfoPtr_FilterApplyMethodBase_Private_Static_Boolean_MethodBase_BindingFlags_BindingFlags_CallingConventions_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667021);
			RuntimeType.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667022);
			RuntimeType.NativeMethodInfoPtr_GetMethodCandidates_Private_ListBuilder_1_MethodInfo_String_BindingFlags_CallingConventions_Il2CppReferenceArray_1_Type_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667023);
			RuntimeType.NativeMethodInfoPtr_GetConstructorCandidates_Private_ListBuilder_1_ConstructorInfo_String_BindingFlags_CallingConventions_Il2CppReferenceArray_1_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667024);
			RuntimeType.NativeMethodInfoPtr_GetPropertyCandidates_Private_ListBuilder_1_PropertyInfo_String_BindingFlags_Il2CppReferenceArray_1_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667025);
			RuntimeType.NativeMethodInfoPtr_GetEventCandidates_Private_ListBuilder_1_EventInfo_String_BindingFlags_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667026);
			RuntimeType.NativeMethodInfoPtr_GetFieldCandidates_Private_ListBuilder_1_FieldInfo_String_BindingFlags_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667027);
			RuntimeType.NativeMethodInfoPtr_GetNestedTypeCandidates_Private_ListBuilder_1_Type_String_BindingFlags_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667028);
			RuntimeType.NativeMethodInfoPtr_GetMethods_Public_Virtual_Il2CppReferenceArray_1_MethodInfo_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667029);
			RuntimeType.NativeMethodInfoPtr_GetConstructors_Public_Virtual_Il2CppReferenceArray_1_ConstructorInfo_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667030);
			RuntimeType.NativeMethodInfoPtr_GetProperties_Public_Virtual_Il2CppReferenceArray_1_PropertyInfo_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667031);
			RuntimeType.NativeMethodInfoPtr_GetEvents_Public_Virtual_Il2CppReferenceArray_1_EventInfo_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667032);
			RuntimeType.NativeMethodInfoPtr_GetFields_Public_Virtual_Il2CppReferenceArray_1_FieldInfo_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667033);
			RuntimeType.NativeMethodInfoPtr_GetMembers_Public_Virtual_Il2CppReferenceArray_1_MemberInfo_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667034);
			RuntimeType.NativeMethodInfoPtr_GetConstructorImpl_Protected_Virtual_ConstructorInfo_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667035);
			RuntimeType.NativeMethodInfoPtr_GetPropertyImpl_Protected_Virtual_PropertyInfo_String_BindingFlags_Binder_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667036);
			RuntimeType.NativeMethodInfoPtr_GetEvent_Public_Virtual_EventInfo_String_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667037);
			RuntimeType.NativeMethodInfoPtr_GetField_Public_Virtual_FieldInfo_String_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667038);
			RuntimeType.NativeMethodInfoPtr_GetInterface_Public_Virtual_Type_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667039);
			RuntimeType.NativeMethodInfoPtr_GetNestedType_Public_Virtual_Type_String_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667040);
			RuntimeType.NativeMethodInfoPtr_GetMember_Public_Virtual_Il2CppReferenceArray_1_MemberInfo_String_MemberTypes_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667041);
			RuntimeType.NativeMethodInfoPtr_get_Module_Public_Virtual_get_Module_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667042);
			RuntimeType.NativeMethodInfoPtr_GetRuntimeModule_Internal_RuntimeModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667043);
			RuntimeType.NativeMethodInfoPtr_get_Assembly_Public_Virtual_get_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667044);
			RuntimeType.NativeMethodInfoPtr_GetRuntimeAssembly_Internal_RuntimeAssembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667045);
			RuntimeType.NativeMethodInfoPtr_get_TypeHandle_Public_Virtual_get_RuntimeTypeHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667046);
			RuntimeType.NativeMethodInfoPtr_IsInstanceOfType_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667047);
			RuntimeType.NativeMethodInfoPtr_IsAssignableFrom_Public_Virtual_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667048);
			RuntimeType.NativeMethodInfoPtr_IsEquivalentTo_Public_Virtual_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667049);
			RuntimeType.NativeMethodInfoPtr_get_BaseType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667050);
			RuntimeType.NativeMethodInfoPtr_GetBaseType_Private_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667051);
			RuntimeType.NativeMethodInfoPtr_get_UnderlyingSystemType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667052);
			RuntimeType.NativeMethodInfoPtr_GetAttributeFlagsImpl_Protected_Virtual_TypeAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667053);
			RuntimeType.NativeMethodInfoPtr_IsContextfulImpl_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667054);
			RuntimeType.NativeMethodInfoPtr_IsByRefImpl_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667055);
			RuntimeType.NativeMethodInfoPtr_IsPrimitiveImpl_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667056);
			RuntimeType.NativeMethodInfoPtr_IsPointerImpl_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667057);
			RuntimeType.NativeMethodInfoPtr_IsCOMObjectImpl_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667058);
			RuntimeType.NativeMethodInfoPtr_IsValueTypeImpl_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667059);
			RuntimeType.NativeMethodInfoPtr_get_IsEnum_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667060);
			RuntimeType.NativeMethodInfoPtr_HasElementTypeImpl_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667061);
			RuntimeType.NativeMethodInfoPtr_get_GenericParameterAttributes_Public_Virtual_get_GenericParameterAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667062);
			RuntimeType.NativeMethodInfoPtr_get_IsSzArray_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667063);
			RuntimeType.NativeMethodInfoPtr_IsArrayImpl_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667064);
			RuntimeType.NativeMethodInfoPtr_GetArrayRank_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667065);
			RuntimeType.NativeMethodInfoPtr_GetElementType_Public_Virtual_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667066);
			RuntimeType.NativeMethodInfoPtr_GetEnumNames_Public_Virtual_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667067);
			RuntimeType.NativeMethodInfoPtr_GetEnumValues_Public_Virtual_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667068);
			RuntimeType.NativeMethodInfoPtr_GetEnumUnderlyingType_Public_Virtual_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667069);
			RuntimeType.NativeMethodInfoPtr_IsEnumDefined_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667070);
			RuntimeType.NativeMethodInfoPtr_GetEnumName_Public_Virtual_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667071);
			RuntimeType.NativeMethodInfoPtr_GetGenericArgumentsInternal_Internal_Il2CppReferenceArray_1_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667072);
			RuntimeType.NativeMethodInfoPtr_GetGenericArguments_Public_Virtual_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667073);
			RuntimeType.NativeMethodInfoPtr_MakeGenericType_Public_Virtual_Type_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667074);
			RuntimeType.NativeMethodInfoPtr_get_IsGenericTypeDefinition_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667075);
			RuntimeType.NativeMethodInfoPtr_get_IsGenericParameter_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667076);
			RuntimeType.NativeMethodInfoPtr_get_GenericParameterPosition_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667077);
			RuntimeType.NativeMethodInfoPtr_GetGenericTypeDefinition_Public_Virtual_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667078);
			RuntimeType.NativeMethodInfoPtr_get_IsGenericType_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667079);
			RuntimeType.NativeMethodInfoPtr_get_IsConstructedGenericType_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667080);
			RuntimeType.NativeMethodInfoPtr_InvokeMember_Public_Virtual_Object_String_BindingFlags_Binder_Object_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_ParameterModifier_CultureInfo_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667081);
			RuntimeType.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667082);
			RuntimeType.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RuntimeType_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667083);
			RuntimeType.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_RuntimeType_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667084);
			RuntimeType.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667085);
			RuntimeType.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667086);
			RuntimeType.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667087);
			RuntimeType.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667088);
			RuntimeType.NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667089);
			RuntimeType.NativeMethodInfoPtr_GetCustomAttributesData_Public_Virtual_IList_1_CustomAttributeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667090);
			RuntimeType.NativeMethodInfoPtr_FormatTypeName_Internal_Virtual_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667091);
			RuntimeType.NativeMethodInfoPtr_get_MemberType_Public_Virtual_get_MemberTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667092);
			RuntimeType.NativeMethodInfoPtr_get_ReflectedType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667093);
			RuntimeType.NativeMethodInfoPtr_get_MetadataToken_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667094);
			RuntimeType.NativeMethodInfoPtr_CreateInstanceCheckThis_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667095);
			RuntimeType.NativeMethodInfoPtr_CreateInstanceImpl_Internal_Object_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_Il2CppReferenceArray_1_Object_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667096);
			RuntimeType.NativeMethodInfoPtr_CreateInstanceDefaultCtor_Internal_Object_Boolean_Boolean_Boolean_Boolean_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667097);
			RuntimeType.NativeMethodInfoPtr_GetDefaultConstructor_Internal_RuntimeConstructorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667098);
			RuntimeType.NativeMethodInfoPtr_GetDefaultMemberName_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667099);
			RuntimeType.NativeMethodInfoPtr_GetSerializationCtor_Internal_RuntimeConstructorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667100);
			RuntimeType.NativeMethodInfoPtr_CreateInstanceSlow_Internal_Object_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667101);
			RuntimeType.NativeMethodInfoPtr_CreateInstanceMono_Private_Object_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667102);
			RuntimeType.NativeMethodInfoPtr_CheckValue_Internal_Object_Object_Binder_CultureInfo_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667103);
			RuntimeType.NativeMethodInfoPtr_TryConvertToType_Private_Object_Object_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667104);
			RuntimeType.NativeMethodInfoPtr_IsConvertibleToPrimitiveType_Private_Static_Object_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667105);
			RuntimeType.NativeMethodInfoPtr_GetCachedName_Private_String_TypeNameKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667106);
			RuntimeType.NativeMethodInfoPtr_make_array_type_Private_Type_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667107);
			RuntimeType.NativeMethodInfoPtr_MakeArrayType_Public_Virtual_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667108);
			RuntimeType.NativeMethodInfoPtr_MakeArrayType_Public_Virtual_Type_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667109);
			RuntimeType.NativeMethodInfoPtr_make_byref_type_Private_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667110);
			RuntimeType.NativeMethodInfoPtr_MakeByRefType_Public_Virtual_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667111);
			RuntimeType.NativeMethodInfoPtr_MakePointerType_Private_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667112);
			RuntimeType.NativeMethodInfoPtr_MakePointerType_Public_Virtual_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667113);
			RuntimeType.NativeMethodInfoPtr_get_ContainsGenericParameters_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667114);
			RuntimeType.NativeMethodInfoPtr_GetGenericParameterConstraints_Public_Virtual_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667115);
			RuntimeType.NativeMethodInfoPtr_CreateInstanceForAnotherGenericParameter_Internal_Static_Object_Type_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667116);
			RuntimeType.NativeMethodInfoPtr_MakeGenericType_Private_Static_Type_Type_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667117);
			RuntimeType.NativeMethodInfoPtr_GetMethodsByName_native_Internal_IntPtr_IntPtr_BindingFlags_MemberListType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667118);
			RuntimeType.NativeMethodInfoPtr_GetMethodsByName_Internal_Il2CppReferenceArray_1_RuntimeMethodInfo_String_BindingFlags_MemberListType_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667119);
			RuntimeType.NativeMethodInfoPtr_GetPropertiesByName_native_Private_IntPtr_IntPtr_BindingFlags_MemberListType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667120);
			RuntimeType.NativeMethodInfoPtr_GetConstructors_native_Private_IntPtr_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667121);
			RuntimeType.NativeMethodInfoPtr_GetConstructors_internal_Private_Il2CppReferenceArray_1_RuntimeConstructorInfo_BindingFlags_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667122);
			RuntimeType.NativeMethodInfoPtr_GetPropertiesByName_Private_Il2CppReferenceArray_1_RuntimePropertyInfo_String_BindingFlags_MemberListType_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667123);
			RuntimeType.NativeMethodInfoPtr_GetGUID_Private_Static_Void_Type_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667124);
			RuntimeType.NativeMethodInfoPtr_get_GUID_Public_Virtual_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667125);
			RuntimeType.NativeMethodInfoPtr_GetTypeFromCLSIDImpl_Internal_Static_Type_Guid_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667126);
			RuntimeType.NativeMethodInfoPtr_GetTypeCodeImpl_Protected_Virtual_TypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667127);
			RuntimeType.NativeMethodInfoPtr_GetTypeCodeImplInternal_Private_Static_TypeCode_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667128);
			RuntimeType.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667129);
			RuntimeType.NativeMethodInfoPtr_IsGenericCOMObjectImpl_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667130);
			RuntimeType.NativeMethodInfoPtr_CreateInstanceInternal_Private_Static_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667131);
			RuntimeType.NativeMethodInfoPtr_get_DeclaringMethod_Public_Virtual_get_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667132);
			RuntimeType.NativeMethodInfoPtr_getFullName_Internal_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667133);
			RuntimeType.NativeMethodInfoPtr_GetGenericArgumentsInternal_Private_Il2CppReferenceArray_1_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667134);
			RuntimeType.NativeMethodInfoPtr_GetGenericParameterAttributes_Private_GenericParameterAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667135);
			RuntimeType.NativeMethodInfoPtr_GetGenericParameterPosition_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667136);
			RuntimeType.NativeMethodInfoPtr_GetEvents_native_Private_IntPtr_IntPtr_MemberListType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667137);
			RuntimeType.NativeMethodInfoPtr_GetFields_native_Private_IntPtr_IntPtr_BindingFlags_MemberListType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667138);
			RuntimeType.NativeMethodInfoPtr_GetFields_internal_Private_Il2CppReferenceArray_1_RuntimeFieldInfo_String_BindingFlags_MemberListType_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667139);
			RuntimeType.NativeMethodInfoPtr_GetEvents_internal_Private_Il2CppReferenceArray_1_RuntimeEventInfo_String_BindingFlags_MemberListType_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667140);
			RuntimeType.NativeMethodInfoPtr_GetInterfaces_Public_Virtual_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667141);
			RuntimeType.NativeMethodInfoPtr_GetNestedTypes_native_Private_IntPtr_IntPtr_BindingFlags_MemberListType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667142);
			RuntimeType.NativeMethodInfoPtr_GetNestedTypes_internal_Private_Il2CppReferenceArray_1_RuntimeType_String_BindingFlags_MemberListType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667143);
			RuntimeType.NativeMethodInfoPtr_get_AssemblyQualifiedName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667144);
			RuntimeType.NativeMethodInfoPtr_get_DeclaringType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667145);
			RuntimeType.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667146);
			RuntimeType.NativeMethodInfoPtr_get_Namespace_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667147);
			RuntimeType.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667148);
			RuntimeType.NativeMethodInfoPtr_get_FullName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667149);
			RuntimeType.NativeMethodInfoPtr_get_IsSZArray_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667150);
			RuntimeType.NativeMethodInfoPtr_IsSubclassOf_Public_Virtual_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667151);
			RuntimeType.NativeMethodInfoPtr_GetMethodImpl_Protected_Virtual_MethodInfo_String_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667152);
			RuntimeType.NativeMethodInfoPtr_GetMethodImplCommon_Private_MethodInfo_String_Int32_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667153);
			RuntimeType.NativeMethodInfoPtr_GetMethodCandidates_Private_ListBuilder_1_MethodInfo_String_Int32_BindingFlags_CallingConventions_Il2CppReferenceArray_1_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, 100667154);
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x0008B924 File Offset: 0x00089B24
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1341980, RefRangeEnd = 1341984, XrefRangeStart = 1341979, XrefRangeEnd = 1341980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RuntimeType GetType(string typeName, bool throwOnError, bool ignoreCase, bool reflectionOnly, ref StackCrawlMark stackMark)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnError;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reflectionOnly;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetType_Internal_Static_RuntimeType_String_Boolean_Boolean_Boolean_byref_StackCrawlMark_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr3) : null;
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x0008B9A4 File Offset: 0x00089BA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1341993, RefRangeEnd = 1341994, XrefRangeStart = 1341984, XrefRangeEnd = 1341993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowIfTypeNeverValidGenericArgument(RuntimeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_ThrowIfTypeNeverValidGenericArgument_Private_Static_Void_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x0008B9DC File Offset: 0x00089BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1341994, XrefRangeEnd = 1342001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SanityCheckGenericArguments(Il2CppReferenceArray<RuntimeType> genericArguments, Il2CppReferenceArray<RuntimeType> genericParamters)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(genericArguments);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(genericParamters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_SanityCheckGenericArguments_Internal_Static_Void_Il2CppReferenceArray_1_RuntimeType_Il2CppReferenceArray_1_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x0008BA24 File Offset: 0x00089C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342001, XrefRangeEnd = 1342008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SplitName(string fullname, out string name, out string ns)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fullname);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_SplitName_Private_Static_Void_String_byref_String_byref_String_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			name = IL2CPP.Il2CppStringToManaged(intPtr);
			ns = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x0008BA90 File Offset: 0x00089C90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1342008, RefRangeEnd = 1342010, XrefRangeStart = 1342008, XrefRangeEnd = 1342008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BindingFlags FilterPreCalculate(bool isPublic, bool isInherited, bool isStatic)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isPublic;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isInherited;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isStatic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_FilterPreCalculate_Internal_Static_BindingFlags_Boolean_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x0008BAEC File Offset: 0x00089CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342010, XrefRangeEnd = 1342012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FilterHelper(BindingFlags bindingFlags, ref string name, bool allowPrefixLookup, out bool prefixLookup, out bool ignoreCase, out RuntimeType.MemberListType listType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingFlags;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowPrefixLookup;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &prefixLookup;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ignoreCase;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &listType;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_FilterHelper_Private_Static_Void_BindingFlags_byref_String_Boolean_byref_Boolean_byref_Boolean_byref_MemberListType_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			name = IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x0008BB78 File Offset: 0x00089D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342012, XrefRangeEnd = 1342017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FilterHelper(BindingFlags bindingFlags, ref string name, out bool ignoreCase, out RuntimeType.MemberListType listType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingFlags;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ignoreCase;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &listType;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_FilterHelper_Private_Static_Void_BindingFlags_byref_String_byref_Boolean_byref_MemberListType_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			name = IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x0008BBE8 File Offset: 0x00089DE8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1342018, RefRangeEnd = 1342024, XrefRangeStart = 1342017, XrefRangeEnd = 1342018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FilterApplyPrefixLookup(MemberInfo memberInfo, string name, bool ignoreCase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_FilterApplyPrefixLookup_Private_Static_Boolean_MemberInfo_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x0008BC4C File Offset: 0x00089E4C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1342037, RefRangeEnd = 1342041, XrefRangeStart = 1342024, XrefRangeEnd = 1342037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FilterApplyBase(MemberInfo memberInfo, BindingFlags bindingFlags, bool isPublic, bool isNonProtectedInternal, bool isStatic, string name, bool prefixLookup)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingFlags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPublic;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNonProtectedInternal;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isStatic;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prefixLookup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_FilterApplyBase_Private_Static_Boolean_MemberInfo_BindingFlags_Boolean_Boolean_Boolean_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x0008BCE8 File Offset: 0x00089EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342041, XrefRangeEnd = 1342050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FilterApplyType(Type type, BindingFlags bindingFlags, string name, bool prefixLookup, string ns)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingFlags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prefixLookup;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_FilterApplyType_Private_Static_Boolean_Type_BindingFlags_String_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x0008BD6C File Offset: 0x00089F6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1342055, RefRangeEnd = 1342057, XrefRangeStart = 1342050, XrefRangeEnd = 1342055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FilterApplyMethodInfo(RuntimeMethodInfo method, BindingFlags bindingFlags, CallingConventions callConv, Il2CppReferenceArray<Type> argumentTypes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingFlags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callConv;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argumentTypes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_FilterApplyMethodInfo_Private_Static_Boolean_RuntimeMethodInfo_BindingFlags_CallingConventions_Il2CppReferenceArray_1_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x0008BDDC File Offset: 0x00089FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342057, XrefRangeEnd = 1342062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FilterApplyConstructorInfo(RuntimeConstructorInfo constructor, BindingFlags bindingFlags, CallingConventions callConv, Il2CppReferenceArray<Type> argumentTypes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(constructor);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingFlags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callConv;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argumentTypes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_FilterApplyConstructorInfo_Private_Static_Boolean_RuntimeConstructorInfo_BindingFlags_CallingConventions_Il2CppReferenceArray_1_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x0008BE4C File Offset: 0x0008A04C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1342074, RefRangeEnd = 1342077, XrefRangeStart = 1342062, XrefRangeEnd = 1342074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FilterApplyMethodBase(MethodBase methodBase, BindingFlags methodFlags, BindingFlags bindingFlags, CallingConventions callConv, Il2CppReferenceArray<Type> argumentTypes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(methodBase);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodFlags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingFlags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callConv;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argumentTypes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_FilterApplyMethodBase_Private_Static_Boolean_MethodBase_BindingFlags_BindingFlags_CallingConventions_Il2CppReferenceArray_1_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x0008BECC File Offset: 0x0008A0CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1342083, RefRangeEnd = 1342084, XrefRangeStart = 1342077, XrefRangeEnd = 1342083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeType()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x0008BF08 File Offset: 0x0008A108
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1342113, RefRangeEnd = 1342116, XrefRangeStart = 1342084, XrefRangeEnd = 1342113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeType.ListBuilder<MethodInfo> GetMethodCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Il2CppReferenceArray<Type> types, int genericParamCount, bool allowPrefixLookup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callConv;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref genericParamCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowPrefixLookup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetMethodCandidates_Private_ListBuilder_1_MethodInfo_String_BindingFlags_CallingConventions_Il2CppReferenceArray_1_Type_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new RuntimeType.ListBuilder<MethodInfo>(intPtr);
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x0008BF9C File Offset: 0x0008A19C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1342145, RefRangeEnd = 1342149, XrefRangeStart = 1342116, XrefRangeEnd = 1342145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeType.ListBuilder<ConstructorInfo> GetConstructorCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Il2CppReferenceArray<Type> types, bool allowPrefixLookup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callConv;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowPrefixLookup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetConstructorCandidates_Private_ListBuilder_1_ConstructorInfo_String_BindingFlags_CallingConventions_Il2CppReferenceArray_1_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new RuntimeType.ListBuilder<ConstructorInfo>(intPtr);
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x0008C024 File Offset: 0x0008A224
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1342177, RefRangeEnd = 1342181, XrefRangeStart = 1342149, XrefRangeEnd = 1342177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeType.ListBuilder<PropertyInfo> GetPropertyCandidates(string name, BindingFlags bindingAttr, Il2CppReferenceArray<Type> types, bool allowPrefixLookup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowPrefixLookup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetPropertyCandidates_Private_ListBuilder_1_PropertyInfo_String_BindingFlags_Il2CppReferenceArray_1_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new RuntimeType.ListBuilder<PropertyInfo>(intPtr);
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x0008C09C File Offset: 0x0008A29C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1342209, RefRangeEnd = 1342212, XrefRangeStart = 1342181, XrefRangeEnd = 1342209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeType.ListBuilder<EventInfo> GetEventCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowPrefixLookup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetEventCandidates_Private_ListBuilder_1_EventInfo_String_BindingFlags_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new RuntimeType.ListBuilder<EventInfo>(intPtr);
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x0008C100 File Offset: 0x0008A300
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1342240, RefRangeEnd = 1342243, XrefRangeStart = 1342212, XrefRangeEnd = 1342240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeType.ListBuilder<FieldInfo> GetFieldCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowPrefixLookup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetFieldCandidates_Private_ListBuilder_1_FieldInfo_String_BindingFlags_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new RuntimeType.ListBuilder<FieldInfo>(intPtr);
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x0008C164 File Offset: 0x0008A364
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1342292, RefRangeEnd = 1342294, XrefRangeStart = 1342243, XrefRangeEnd = 1342292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeType.ListBuilder<Type> GetNestedTypeCandidates(string fullname, BindingFlags bindingAttr, bool allowPrefixLookup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fullname);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowPrefixLookup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetNestedTypeCandidates_Private_ListBuilder_1_Type_String_BindingFlags_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new RuntimeType.ListBuilder<Type>(intPtr);
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x0008C1C8 File Offset: 0x0008A3C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342294, XrefRangeEnd = 1342298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<MethodInfo> GetMethods(BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetMethods_Public_Virtual_Il2CppReferenceArray_1_MethodInfo_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MethodInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x0008C220 File Offset: 0x0008A420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342298, XrefRangeEnd = 1342302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<ConstructorInfo> GetConstructors(BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetConstructors_Public_Virtual_Il2CppReferenceArray_1_ConstructorInfo_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ConstructorInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x0008C278 File Offset: 0x0008A478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342302, XrefRangeEnd = 1342306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<PropertyInfo> GetProperties(BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetProperties_Public_Virtual_Il2CppReferenceArray_1_PropertyInfo_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PropertyInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x0008C2D0 File Offset: 0x0008A4D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342306, XrefRangeEnd = 1342310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<EventInfo> GetEvents(BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetEvents_Public_Virtual_Il2CppReferenceArray_1_EventInfo_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EventInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x0008C328 File Offset: 0x0008A528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342310, XrefRangeEnd = 1342314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<FieldInfo> GetFields(BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetFields_Public_Virtual_Il2CppReferenceArray_1_FieldInfo_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FieldInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x0008C380 File Offset: 0x0008A580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342314, XrefRangeEnd = 1342347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<MemberInfo> GetMembers(BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetMembers_Public_Virtual_Il2CppReferenceArray_1_MemberInfo_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MemberInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x0008C3D8 File Offset: 0x0008A5D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342347, XrefRangeEnd = 1342373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Il2CppReferenceArray<Type> types, Il2CppReferenceArray<ParameterModifier> modifiers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callConvention;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(modifiers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetConstructorImpl_Protected_Virtual_ConstructorInfo_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConstructorInfo>(intPtr3) : null;
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x0008C478 File Offset: 0x0008A678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342373, XrefRangeEnd = 1342384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Il2CppReferenceArray<Type> types, Il2CppReferenceArray<ParameterModifier> modifiers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(returnType);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(modifiers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetPropertyImpl_Protected_Virtual_PropertyInfo_String_BindingFlags_Binder_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr3) : null;
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x0008C52C File Offset: 0x0008A72C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342384, XrefRangeEnd = 1342404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override EventInfo GetEvent(string name, BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetEvent_Public_Virtual_EventInfo_String_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventInfo>(intPtr3) : null;
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x0008C598 File Offset: 0x0008A798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342404, XrefRangeEnd = 1342429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override FieldInfo GetField(string name, BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetField_Public_Virtual_FieldInfo_String_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr3) : null;
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x0008C604 File Offset: 0x0008A804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342429, XrefRangeEnd = 1342484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetInterface(string fullname, bool ignoreCase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fullname);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetInterface_Public_Virtual_Type_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x0008C670 File Offset: 0x0008A870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342484, XrefRangeEnd = 1342527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetNestedType(string fullname, BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fullname);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetNestedType_Public_Virtual_Type_String_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x0008C6DC File Offset: 0x0008A8DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342527, XrefRangeEnd = 1342571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<MemberInfo> GetMember(string name, MemberTypes type, BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetMember_Public_Virtual_Il2CppReferenceArray_1_MemberInfo_String_MemberTypes_BindingFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MemberInfo>>(intPtr3) : null;
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x060014FE RID: 5374 RVA: 0x0008C754 File Offset: 0x0008A954
		public unsafe override Module Module
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1342572, RefRangeEnd = 1342580, XrefRangeStart = 1342571, XrefRangeEnd = 1342572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_Module_Public_Virtual_get_Module_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Module>(intPtr3) : null;
			}
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x0008C7A0 File Offset: 0x0008A9A0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1342572, RefRangeEnd = 1342580, XrefRangeStart = 1342572, XrefRangeEnd = 1342580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeModule GetRuntimeModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetRuntimeModule_Internal_RuntimeModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeModule>(intPtr3) : null;
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06001500 RID: 5376 RVA: 0x0008C7E0 File Offset: 0x0008A9E0
		public unsafe override Assembly Assembly
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1342581, RefRangeEnd = 1342582, XrefRangeStart = 1342580, XrefRangeEnd = 1342581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_Assembly_Public_Virtual_get_Assembly_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
			}
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x0008C82C File Offset: 0x0008AA2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1342581, RefRangeEnd = 1342582, XrefRangeStart = 1342581, XrefRangeEnd = 1342582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeAssembly GetRuntimeAssembly()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetRuntimeAssembly_Internal_RuntimeAssembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeAssembly>(intPtr3) : null;
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06001502 RID: 5378 RVA: 0x0008C86C File Offset: 0x0008AA6C
		public unsafe override RuntimeTypeHandle TypeHandle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342582, XrefRangeEnd = 1342583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_TypeHandle_Public_Virtual_get_RuntimeTypeHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x0008C8B4 File Offset: 0x0008AAB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342583, XrefRangeEnd = 1342584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsInstanceOfType(Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_IsInstanceOfType_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001504 RID: 5380 RVA: 0x0008C90C File Offset: 0x0008AB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342584, XrefRangeEnd = 1342590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsAssignableFrom(Type c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_IsAssignableFrom_Public_Virtual_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001505 RID: 5381 RVA: 0x0008C964 File Offset: 0x0008AB64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342590, XrefRangeEnd = 1342595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsEquivalentTo(Type other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_IsEquivalentTo_Public_Virtual_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06001506 RID: 5382 RVA: 0x0008C9BC File Offset: 0x0008ABBC
		public unsafe override Type BaseType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342595, XrefRangeEnd = 1342596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_BaseType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06001507 RID: 5383 RVA: 0x0008CA08 File Offset: 0x0008AC08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1342611, RefRangeEnd = 1342613, XrefRangeStart = 1342596, XrefRangeEnd = 1342611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeType GetBaseType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetBaseType_Private_RuntimeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr3) : null;
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06001508 RID: 5384 RVA: 0x0008CA48 File Offset: 0x0008AC48
		public unsafe override Type UnderlyingSystemType
		{
			[CallerCount(1295)]
			[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_UnderlyingSystemType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x0008CA94 File Offset: 0x0008AC94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342613, XrefRangeEnd = 1342614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override TypeAttributes GetAttributeFlagsImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetAttributeFlagsImpl_Protected_Virtual_TypeAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600150A RID: 5386 RVA: 0x0008CADC File Offset: 0x0008ACDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342614, XrefRangeEnd = 1342615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsContextfulImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_IsContextfulImpl_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600150B RID: 5387 RVA: 0x0008CB24 File Offset: 0x0008AD24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342615, XrefRangeEnd = 1342616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsByRefImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_IsByRefImpl_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x0008CB6C File Offset: 0x0008AD6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342616, XrefRangeEnd = 1342617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsPrimitiveImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_IsPrimitiveImpl_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x0008CBB4 File Offset: 0x0008ADB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342617, XrefRangeEnd = 1342618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsPointerImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_IsPointerImpl_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x0008CBFC File Offset: 0x0008ADFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342618, XrefRangeEnd = 1342619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsCOMObjectImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_IsCOMObjectImpl_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x0008CC44 File Offset: 0x0008AE44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342619, XrefRangeEnd = 1342636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsValueTypeImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_IsValueTypeImpl_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06001510 RID: 5392 RVA: 0x0008CC8C File Offset: 0x0008AE8C
		public unsafe override bool IsEnum
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342636, XrefRangeEnd = 1342641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_IsEnum_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x0008CCD4 File Offset: 0x0008AED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342641, XrefRangeEnd = 1342642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool HasElementTypeImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_HasElementTypeImpl_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06001512 RID: 5394 RVA: 0x0008CD1C File Offset: 0x0008AF1C
		public unsafe override GenericParameterAttributes GenericParameterAttributes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342642, XrefRangeEnd = 1342645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_GenericParameterAttributes_Public_Virtual_get_GenericParameterAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06001513 RID: 5395 RVA: 0x0008CD64 File Offset: 0x0008AF64
		public unsafe override bool IsSzArray
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342645, XrefRangeEnd = 1342646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_IsSzArray_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x0008CDAC File Offset: 0x0008AFAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342646, XrefRangeEnd = 1342647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsArrayImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_IsArrayImpl_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x0008CDF4 File Offset: 0x0008AFF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342647, XrefRangeEnd = 1342655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetArrayRank()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetArrayRank_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001516 RID: 5398 RVA: 0x0008CE3C File Offset: 0x0008B03C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342655, XrefRangeEnd = 1342656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetElementType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetElementType_Public_Virtual_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x0008CE88 File Offset: 0x0008B088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342656, XrefRangeEnd = 1342667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStringArray GetEnumNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetEnumNames_Public_Virtual_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06001518 RID: 5400 RVA: 0x0008CED4 File Offset: 0x0008B0D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342667, XrefRangeEnd = 1342680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Array GetEnumValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetEnumValues_Public_Virtual_Array_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x0008CF20 File Offset: 0x0008B120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342680, XrefRangeEnd = 1342692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetEnumUnderlyingType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetEnumUnderlyingType_Public_Virtual_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x0008CF6C File Offset: 0x0008B16C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342692, XrefRangeEnd = 1342720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsEnumDefined(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_IsEnumDefined_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x0008CFC4 File Offset: 0x0008B1C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342720, XrefRangeEnd = 1342736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetEnumName(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetEnumName_Public_Virtual_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x0008D018 File Offset: 0x0008B218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342736, XrefRangeEnd = 1342739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<RuntimeType> GetGenericArgumentsInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetGenericArgumentsInternal_Internal_Il2CppReferenceArray_1_RuntimeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RuntimeType>>(intPtr3) : null;
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x0008D058 File Offset: 0x0008B258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342739, XrefRangeEnd = 1342743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Type> GetGenericArguments()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetGenericArguments_Public_Virtual_Il2CppReferenceArray_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x0008D0A4 File Offset: 0x0008B2A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342743, XrefRangeEnd = 1342768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type MakeGenericType([Optional] Il2CppReferenceArray<Type> instantiation)
		{
			if (instantiation == null)
			{
				instantiation = new Il2CppReferenceArray<Type>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instantiation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_MakeGenericType_Public_Virtual_Type_Il2CppReferenceArray_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x0600151F RID: 5407 RVA: 0x0008D10C File Offset: 0x0008B30C
		public unsafe override bool IsGenericTypeDefinition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342768, XrefRangeEnd = 1342769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_IsGenericTypeDefinition_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06001520 RID: 5408 RVA: 0x0008D154 File Offset: 0x0008B354
		public unsafe override bool IsGenericParameter
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342769, XrefRangeEnd = 1342770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_IsGenericParameter_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06001521 RID: 5409 RVA: 0x0008D19C File Offset: 0x0008B39C
		public unsafe override int GenericParameterPosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342770, XrefRangeEnd = 1342778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_GenericParameterPosition_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x0008D1E4 File Offset: 0x0008B3E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342778, XrefRangeEnd = 1342786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetGenericTypeDefinition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetGenericTypeDefinition_Public_Virtual_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06001523 RID: 5411 RVA: 0x0008D230 File Offset: 0x0008B430
		public unsafe override bool IsGenericType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342786, XrefRangeEnd = 1342787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_IsGenericType_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06001524 RID: 5412 RVA: 0x0008D278 File Offset: 0x0008B478
		public unsafe override bool IsConstructedGenericType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_IsConstructedGenericType_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x0008D2C0 File Offset: 0x0008B4C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342787, XrefRangeEnd = 1342846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object InvokeMember(string name, BindingFlags bindingFlags, Binder binder, Object target, Il2CppReferenceArray<Object> providedArgs, Il2CppReferenceArray<ParameterModifier> modifiers, CultureInfo culture, Il2CppStringArray namedParams)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingFlags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(providedArgs);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(modifiers);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(namedParams);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_InvokeMember_Public_Virtual_Object_String_BindingFlags_Binder_Object_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_ParameterModifier_CultureInfo_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x0008D39C File Offset: 0x0008B59C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 951436, RefRangeEnd = 951444, XrefRangeStart = 951436, XrefRangeEnd = 951444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x0008D3F4 File Offset: 0x0008B5F4
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 376359, RefRangeEnd = 378270, XrefRangeStart = 376359, XrefRangeEnd = 378270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(RuntimeType left, RuntimeType right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RuntimeType_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x0008D448 File Offset: 0x0008B648
		[CallerCount(736)]
		[CachedScanResults(RefRangeStart = 974210, RefRangeEnd = 974946, XrefRangeStart = 974210, XrefRangeEnd = 974946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(RuntimeType left, RuntimeType right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_RuntimeType_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x0008D49C File Offset: 0x0008B69C
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x0008D4DC File Offset: 0x0008B6DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342846, XrefRangeEnd = 1342853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x0008D538 File Offset: 0x0008B738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342853, XrefRangeEnd = 1342861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Object> GetCustomAttributes(bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inherit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x0008D590 File Offset: 0x0008B790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342861, XrefRangeEnd = 1342884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Object> GetCustomAttributes(Type attributeType, bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x0008D5FC File Offset: 0x0008B7FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342884, XrefRangeEnd = 1342907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsDefined(Type attributeType, bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x0008D664 File Offset: 0x0008B864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342907, XrefRangeEnd = 1342908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IList<CustomAttributeData> GetCustomAttributesData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetCustomAttributesData_Public_Virtual_IList_1_CustomAttributeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<CustomAttributeData>>(intPtr3) : null;
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x0008D6B0 File Offset: 0x0008B8B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342908, XrefRangeEnd = 1342927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string FormatTypeName(bool serialization)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref serialization;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_FormatTypeName_Internal_Virtual_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06001530 RID: 5424 RVA: 0x0008D700 File Offset: 0x0008B900
		public unsafe override MemberTypes MemberType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342927, XrefRangeEnd = 1342929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_MemberType_Public_Virtual_get_MemberTypes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06001531 RID: 5425 RVA: 0x0008D748 File Offset: 0x0008B948
		public unsafe override Type ReflectedType
		{
			[CallerCount(41)]
			[CachedScanResults(RefRangeStart = 285957, RefRangeEnd = 285998, XrefRangeStart = 285957, XrefRangeEnd = 285998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_ReflectedType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06001532 RID: 5426 RVA: 0x0008D794 File Offset: 0x0008B994
		public unsafe override int MetadataToken
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342929, XrefRangeEnd = 1342930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_MetadataToken_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x0008D7DC File Offset: 0x0008B9DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1342944, RefRangeEnd = 1342947, XrefRangeStart = 1342930, XrefRangeEnd = 1342944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateInstanceCheckThis()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_CreateInstanceCheckThis_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x0008D810 File Offset: 0x0008BA10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1342999, RefRangeEnd = 1343000, XrefRangeStart = 1342947, XrefRangeEnd = 1342999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object CreateInstanceImpl(BindingFlags bindingAttr, Binder binder, Il2CppReferenceArray<Object> args, CultureInfo culture, Il2CppReferenceArray<Object> activationAttributes, ref StackCrawlMark stackMark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activationAttributes);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_CreateInstanceImpl_Internal_Object_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_Il2CppReferenceArray_1_Object_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x0008D8B8 File Offset: 0x0008BAB8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1343017, RefRangeEnd = 1343020, XrefRangeStart = 1343000, XrefRangeEnd = 1343017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object CreateInstanceDefaultCtor(bool publicOnly, bool skipCheckThis, bool fillCache, bool wrapExceptions, ref StackCrawlMark stackMark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref publicOnly;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipCheckThis;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fillCache;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wrapExceptions;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_CreateInstanceDefaultCtor_Internal_Object_Boolean_Boolean_Boolean_Boolean_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x0008D940 File Offset: 0x0008BB40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1343034, RefRangeEnd = 1343036, XrefRangeStart = 1343020, XrefRangeEnd = 1343034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeConstructorInfo GetDefaultConstructor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetDefaultConstructor_Internal_RuntimeConstructorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeConstructorInfo>(intPtr3) : null;
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x0008D980 File Offset: 0x0008BB80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343036, XrefRangeEnd = 1343044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetDefaultMemberName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetDefaultMemberName_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x0008D9B8 File Offset: 0x0008BBB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1343072, RefRangeEnd = 1343074, XrefRangeStart = 1343044, XrefRangeEnd = 1343072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeConstructorInfo GetSerializationCtor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetSerializationCtor_Internal_RuntimeConstructorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeConstructorInfo>(intPtr3) : null;
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x0008D9F8 File Offset: 0x0008BBF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343074, XrefRangeEnd = 1343076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object CreateInstanceSlow(bool publicOnly, bool wrapExceptions, bool skipCheckThis, bool fillCache)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref publicOnly;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wrapExceptions;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipCheckThis;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fillCache;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_CreateInstanceSlow_Internal_Object_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x0008DA70 File Offset: 0x0008BC70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1343091, RefRangeEnd = 1343093, XrefRangeStart = 1343076, XrefRangeEnd = 1343091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object CreateInstanceMono(bool nonPublic, bool wrapExceptions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nonPublic;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wrapExceptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_CreateInstanceMono_Private_Object_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x0008DACC File Offset: 0x0008BCCC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1343098, RefRangeEnd = 1343100, XrefRangeStart = 1343093, XrefRangeEnd = 1343098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object CheckValue(Object value, Binder binder, CultureInfo culture, BindingFlags invokeAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invokeAttr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_CheckValue_Internal_Object_Object_Binder_CultureInfo_BindingFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x0008DB50 File Offset: 0x0008BD50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1343119, RefRangeEnd = 1343120, XrefRangeStart = 1343100, XrefRangeEnd = 1343119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object TryConvertToType(Object value, ref bool failed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &failed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_TryConvertToType_Private_Object_Object_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x0008DBB0 File Offset: 0x0008BDB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343120, XrefRangeEnd = 1343153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object IsConvertibleToPrimitiveType(Object value, Type targetType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_IsConvertibleToPrimitiveType_Private_Static_Object_Object_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600153E RID: 5438 RVA: 0x0008DC08 File Offset: 0x0008BE08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343153, XrefRangeEnd = 1343158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetCachedName(TypeNameKind kind)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref kind;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetCachedName_Private_String_TypeNameKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600153F RID: 5439 RVA: 0x0008DC4C File Offset: 0x0008BE4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343158, XrefRangeEnd = 1343159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type make_array_type(int rank)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rank;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_make_array_type_Private_Type_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06001540 RID: 5440 RVA: 0x0008DC98 File Offset: 0x0008BE98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343159, XrefRangeEnd = 1343160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type MakeArrayType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_MakeArrayType_Public_Virtual_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06001541 RID: 5441 RVA: 0x0008DCE4 File Offset: 0x0008BEE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343160, XrefRangeEnd = 1343166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type MakeArrayType(int rank)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rank;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_MakeArrayType_Public_Virtual_Type_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06001542 RID: 5442 RVA: 0x0008DD3C File Offset: 0x0008BF3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343166, XrefRangeEnd = 1343167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type make_byref_type()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_make_byref_type_Private_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x0008DD7C File Offset: 0x0008BF7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343167, XrefRangeEnd = 1343175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type MakeByRefType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_MakeByRefType_Public_Virtual_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x0008DDC8 File Offset: 0x0008BFC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343175, XrefRangeEnd = 1343176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type MakePointerType(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_MakePointerType_Private_Static_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x0008DE0C File Offset: 0x0008C00C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343176, XrefRangeEnd = 1343190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type MakePointerType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_MakePointerType_Public_Virtual_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06001546 RID: 5446 RVA: 0x0008DE58 File Offset: 0x0008C058
		public unsafe override bool ContainsGenericParameters
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343190, XrefRangeEnd = 1343192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_ContainsGenericParameters_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x0008DEA0 File Offset: 0x0008C0A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343192, XrefRangeEnd = 1343199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Type> GetGenericParameterConstraints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetGenericParameterConstraints_Public_Virtual_Il2CppReferenceArray_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x0008DEEC File Offset: 0x0008C0EC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1343211, RefRangeEnd = 1343217, XrefRangeStart = 1343199, XrefRangeEnd = 1343211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateInstanceForAnotherGenericParameter(Type genericType, RuntimeType genericArgument)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(genericType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(genericArgument);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_CreateInstanceForAnotherGenericParameter_Internal_Static_Object_Type_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x0008DF44 File Offset: 0x0008C144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343217, XrefRangeEnd = 1343218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type MakeGenericType(Type gt, Il2CppReferenceArray<Type> types)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_MakeGenericType_Private_Static_Type_Type_Il2CppReferenceArray_1_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x0008DF9C File Offset: 0x0008C19C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343218, XrefRangeEnd = 1343219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetMethodsByName_native(IntPtr namePtr, BindingFlags bindingAttr, RuntimeType.MemberListType listType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref namePtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref listType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetMethodsByName_native_Internal_IntPtr_IntPtr_BindingFlags_MemberListType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600154B RID: 5451 RVA: 0x0008E004 File Offset: 0x0008C204
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1343242, RefRangeEnd = 1343244, XrefRangeStart = 1343219, XrefRangeEnd = 1343242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<RuntimeMethodInfo> GetMethodsByName(string name, BindingFlags bindingAttr, RuntimeType.MemberListType listType, RuntimeType reflectedType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref listType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reflectedType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetMethodsByName_Internal_Il2CppReferenceArray_1_RuntimeMethodInfo_String_BindingFlags_MemberListType_RuntimeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RuntimeMethodInfo>>(intPtr3) : null;
		}

		// Token: 0x0600154C RID: 5452 RVA: 0x0008E084 File Offset: 0x0008C284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343244, XrefRangeEnd = 1343245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetPropertiesByName_native(IntPtr name, BindingFlags bindingAttr, RuntimeType.MemberListType listType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref listType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetPropertiesByName_native_Private_IntPtr_IntPtr_BindingFlags_MemberListType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600154D RID: 5453 RVA: 0x0008E0EC File Offset: 0x0008C2EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343245, XrefRangeEnd = 1343246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetConstructors_native(BindingFlags bindingAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetConstructors_native_Private_IntPtr_BindingFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600154E RID: 5454 RVA: 0x0008E138 File Offset: 0x0008C338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343246, XrefRangeEnd = 1343265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<RuntimeConstructorInfo> GetConstructors_internal(BindingFlags bindingAttr, RuntimeType reflectedType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bindingAttr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reflectedType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetConstructors_internal_Private_Il2CppReferenceArray_1_RuntimeConstructorInfo_BindingFlags_RuntimeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RuntimeConstructorInfo>>(intPtr3) : null;
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x0008E198 File Offset: 0x0008C398
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1343288, RefRangeEnd = 1343289, XrefRangeStart = 1343265, XrefRangeEnd = 1343288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<RuntimePropertyInfo> GetPropertiesByName(string name, BindingFlags bindingAttr, RuntimeType.MemberListType listType, RuntimeType reflectedType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref listType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reflectedType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetPropertiesByName_Private_Il2CppReferenceArray_1_RuntimePropertyInfo_String_BindingFlags_MemberListType_RuntimeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RuntimePropertyInfo>>(intPtr3) : null;
		}

		// Token: 0x06001550 RID: 5456 RVA: 0x0008E218 File Offset: 0x0008C418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343289, XrefRangeEnd = 1343290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetGUID(Type type, Il2CppStructArray<byte> guid)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetGUID_Private_Static_Void_Type_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06001551 RID: 5457 RVA: 0x0008E260 File Offset: 0x0008C460
		public unsafe override Guid GUID
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343290, XrefRangeEnd = 1343298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_GUID_Public_Virtual_get_Guid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x0008E2A8 File Offset: 0x0008C4A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1343304, RefRangeEnd = 1343306, XrefRangeStart = 1343298, XrefRangeEnd = 1343304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetTypeFromCLSIDImpl(Guid clsid, string server, bool throwOnError)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clsid;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(server);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnError;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetTypeFromCLSIDImpl_Internal_Static_Type_Guid_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x0008E308 File Offset: 0x0008C508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343306, XrefRangeEnd = 1343310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override TypeCode GetTypeCodeImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetTypeCodeImpl_Protected_Virtual_TypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001554 RID: 5460 RVA: 0x0008E350 File Offset: 0x0008C550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343310, XrefRangeEnd = 1343311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeCode GetTypeCodeImplInternal(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetTypeCodeImplInternal_Private_Static_TypeCode_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x0008E394 File Offset: 0x0008C594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343311, XrefRangeEnd = 1343312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x0008E3D8 File Offset: 0x0008C5D8
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsGenericCOMObjectImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_IsGenericCOMObjectImpl_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x0008E414 File Offset: 0x0008C614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343312, XrefRangeEnd = 1343313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateInstanceInternal(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_CreateInstanceInternal_Private_Static_Object_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06001558 RID: 5464 RVA: 0x0008E458 File Offset: 0x0008C658
		public unsafe override MethodBase DeclaringMethod
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343313, XrefRangeEnd = 1343314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_DeclaringMethod_Public_Virtual_get_MethodBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
			}
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x0008E4A4 File Offset: 0x0008C6A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343314, XrefRangeEnd = 1343315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string getFullName(bool full_name, bool assembly_qualified)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref full_name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref assembly_qualified;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_getFullName_Internal_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x0008E4F8 File Offset: 0x0008C6F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343315, XrefRangeEnd = 1343316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Type> GetGenericArgumentsInternal(bool runtimeArray)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref runtimeArray;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetGenericArgumentsInternal_Private_Il2CppReferenceArray_1_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x0008E544 File Offset: 0x0008C744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343316, XrefRangeEnd = 1343319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericParameterAttributes GetGenericParameterAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetGenericParameterAttributes_Private_GenericParameterAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x0008E580 File Offset: 0x0008C780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343319, XrefRangeEnd = 1343320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetGenericParameterPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetGenericParameterPosition_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x0008E5BC File Offset: 0x0008C7BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343320, XrefRangeEnd = 1343321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetEvents_native(IntPtr name, RuntimeType.MemberListType listType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref listType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetEvents_native_Private_IntPtr_IntPtr_MemberListType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x0008E614 File Offset: 0x0008C814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343321, XrefRangeEnd = 1343322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetFields_native(IntPtr name, BindingFlags bindingAttr, RuntimeType.MemberListType listType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref listType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetFields_native_Private_IntPtr_IntPtr_BindingFlags_MemberListType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x0008E67C File Offset: 0x0008C87C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1343345, RefRangeEnd = 1343347, XrefRangeStart = 1343322, XrefRangeEnd = 1343345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<RuntimeFieldInfo> GetFields_internal(string name, BindingFlags bindingAttr, RuntimeType.MemberListType listType, RuntimeType reflectedType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref listType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reflectedType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetFields_internal_Private_Il2CppReferenceArray_1_RuntimeFieldInfo_String_BindingFlags_MemberListType_RuntimeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RuntimeFieldInfo>>(intPtr3) : null;
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x0008E6FC File Offset: 0x0008C8FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1343367, RefRangeEnd = 1343369, XrefRangeStart = 1343347, XrefRangeEnd = 1343367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<RuntimeEventInfo> GetEvents_internal(string name, BindingFlags bindingAttr, RuntimeType.MemberListType listType, RuntimeType reflectedType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref listType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reflectedType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetEvents_internal_Private_Il2CppReferenceArray_1_RuntimeEventInfo_String_BindingFlags_MemberListType_RuntimeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RuntimeEventInfo>>(intPtr3) : null;
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x0008E77C File Offset: 0x0008C97C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343369, XrefRangeEnd = 1343370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Type> GetInterfaces()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetInterfaces_Public_Virtual_Il2CppReferenceArray_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x0008E7C8 File Offset: 0x0008C9C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343370, XrefRangeEnd = 1343371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetNestedTypes_native(IntPtr name, BindingFlags bindingAttr, RuntimeType.MemberListType listType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref name;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref listType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetNestedTypes_native_Private_IntPtr_IntPtr_BindingFlags_MemberListType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x0008E830 File Offset: 0x0008CA30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1343401, RefRangeEnd = 1343403, XrefRangeStart = 1343371, XrefRangeEnd = 1343401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<RuntimeType> GetNestedTypes_internal(string displayName, BindingFlags bindingAttr, RuntimeType.MemberListType listType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(displayName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref listType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetNestedTypes_internal_Private_Il2CppReferenceArray_1_RuntimeType_String_BindingFlags_MemberListType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RuntimeType>>(intPtr3) : null;
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06001564 RID: 5476 RVA: 0x0008E89C File Offset: 0x0008CA9C
		public unsafe override string AssemblyQualifiedName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343403, XrefRangeEnd = 1343404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_AssemblyQualifiedName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06001565 RID: 5477 RVA: 0x0008E8E0 File Offset: 0x0008CAE0
		public unsafe override Type DeclaringType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343404, XrefRangeEnd = 1343405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_DeclaringType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06001566 RID: 5478 RVA: 0x0008E92C File Offset: 0x0008CB2C
		public unsafe override string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343405, XrefRangeEnd = 1343406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06001567 RID: 5479 RVA: 0x0008E970 File Offset: 0x0008CB70
		public unsafe override string Namespace
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343406, XrefRangeEnd = 1343407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_Namespace_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x0008E9B4 File Offset: 0x0008CBB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343407, XrefRangeEnd = 1343416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06001569 RID: 5481 RVA: 0x0008E9FC File Offset: 0x0008CBFC
		public unsafe override string FullName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343416, XrefRangeEnd = 1343418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_FullName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x0600156A RID: 5482 RVA: 0x0008EA40 File Offset: 0x0008CC40
		public unsafe override bool IsSZArray
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343418, XrefRangeEnd = 1343419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_get_IsSZArray_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600156B RID: 5483 RVA: 0x0008EA88 File Offset: 0x0008CC88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343419, XrefRangeEnd = 1343424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsSubclassOf(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_IsSubclassOf_Public_Virtual_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x0008EAE0 File Offset: 0x0008CCE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1343424, XrefRangeEnd = 1343425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConv, Il2CppReferenceArray<Type> types, Il2CppReferenceArray<ParameterModifier> modifiers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callConv;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(modifiers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeType.NativeMethodInfoPtr_GetMethodImpl_Protected_Virtual_MethodInfo_String_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x0008EB90 File Offset: 0x0008CD90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1343441, RefRangeEnd = 1343442, XrefRangeStart = 1343425, XrefRangeEnd = 1343441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodInfo GetMethodImplCommon(string name, int genericParameterCount, BindingFlags bindingAttr, Binder binder, CallingConventions callConv, Il2CppReferenceArray<Type> types, Il2CppReferenceArray<ParameterModifier> modifiers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref genericParameterCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callConv;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(modifiers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetMethodImplCommon_Private_MethodInfo_String_Int32_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x0008EC44 File Offset: 0x0008CE44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1343471, RefRangeEnd = 1343472, XrefRangeStart = 1343442, XrefRangeEnd = 1343471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeType.ListBuilder<MethodInfo> GetMethodCandidates(string name, int genericParameterCount, BindingFlags bindingAttr, CallingConventions callConv, Il2CppReferenceArray<Type> types, bool allowPrefixLookup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref genericParameterCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingAttr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callConv;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowPrefixLookup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.NativeMethodInfoPtr_GetMethodCandidates_Private_ListBuilder_1_MethodInfo_String_Int32_BindingFlags_CallingConventions_Il2CppReferenceArray_1_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new RuntimeType.ListBuilder<MethodInfo>(intPtr);
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x00006916 File Offset: 0x00004B16
		public override Type MakeGenericType(params Type[] instantiation)
		{
			return this.MakeGenericType(new Il2CppReferenceArray<Type>(instantiation));
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x00006924 File Offset: 0x00004B24
		public RuntimeType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06001571 RID: 5489 RVA: 0x0008ECD8 File Offset: 0x0008CED8
		// (set) Token: 0x06001572 RID: 5490 RVA: 0x0000692D File Offset: 0x00004B2D
		public unsafe static RuntimeType ValueType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeType.NativeFieldInfoPtr_ValueType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeType.NativeFieldInfoPtr_ValueType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06001573 RID: 5491 RVA: 0x0008ED00 File Offset: 0x0008CF00
		// (set) Token: 0x06001574 RID: 5492 RVA: 0x0000693F File Offset: 0x00004B3F
		public unsafe static RuntimeType EnumType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeType.NativeFieldInfoPtr_EnumType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeType.NativeFieldInfoPtr_EnumType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06001575 RID: 5493 RVA: 0x0008ED28 File Offset: 0x0008CF28
		// (set) Token: 0x06001576 RID: 5494 RVA: 0x00006951 File Offset: 0x00004B51
		public unsafe static RuntimeType ObjectType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeType.NativeFieldInfoPtr_ObjectType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeType.NativeFieldInfoPtr_ObjectType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06001577 RID: 5495 RVA: 0x0008ED50 File Offset: 0x0008CF50
		// (set) Token: 0x06001578 RID: 5496 RVA: 0x00006963 File Offset: 0x00004B63
		public unsafe static RuntimeType StringType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeType.NativeFieldInfoPtr_StringType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeType.NativeFieldInfoPtr_StringType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06001579 RID: 5497 RVA: 0x0008ED78 File Offset: 0x0008CF78
		// (set) Token: 0x0600157A RID: 5498 RVA: 0x00006975 File Offset: 0x00004B75
		public unsafe static RuntimeType DelegateType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeType.NativeFieldInfoPtr_DelegateType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeType.NativeFieldInfoPtr_DelegateType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x0600157B RID: 5499 RVA: 0x0008EDA0 File Offset: 0x0008CFA0
		// (set) Token: 0x0600157C RID: 5500 RVA: 0x00006987 File Offset: 0x00004B87
		public unsafe static Il2CppReferenceArray<Type> s_SICtorParamTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeType.NativeFieldInfoPtr_s_SICtorParamTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeType.NativeFieldInfoPtr_s_SICtorParamTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x0600157D RID: 5501 RVA: 0x0008EDC8 File Offset: 0x0008CFC8
		// (set) Token: 0x0600157E RID: 5502 RVA: 0x00006999 File Offset: 0x00004B99
		public unsafe static Func<Type, Il2CppReferenceArray<Type>, Type> MakeTypeBuilderInstantiation
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeType.NativeFieldInfoPtr_MakeTypeBuilderInstantiation, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Type, Il2CppReferenceArray<Type>, Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeType.NativeFieldInfoPtr_MakeTypeBuilderInstantiation, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x0600157F RID: 5503 RVA: 0x0008EDF0 File Offset: 0x0008CFF0
		// (set) Token: 0x06001580 RID: 5504 RVA: 0x000069AB File Offset: 0x00004BAB
		public unsafe static BindingFlags MemberBindingMask
		{
			get
			{
				BindingFlags bindingFlags;
				IL2CPP.il2cpp_field_static_get_value(RuntimeType.NativeFieldInfoPtr_MemberBindingMask, (void*)(&bindingFlags));
				return bindingFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeType.NativeFieldInfoPtr_MemberBindingMask, (void*)(&value));
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06001581 RID: 5505 RVA: 0x0008EE0C File Offset: 0x0008D00C
		// (set) Token: 0x06001582 RID: 5506 RVA: 0x000069B9 File Offset: 0x00004BB9
		public unsafe static BindingFlags InvocationMask
		{
			get
			{
				BindingFlags bindingFlags;
				IL2CPP.il2cpp_field_static_get_value(RuntimeType.NativeFieldInfoPtr_InvocationMask, (void*)(&bindingFlags));
				return bindingFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeType.NativeFieldInfoPtr_InvocationMask, (void*)(&value));
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06001583 RID: 5507 RVA: 0x0008EE28 File Offset: 0x0008D028
		// (set) Token: 0x06001584 RID: 5508 RVA: 0x000069C7 File Offset: 0x00004BC7
		public unsafe static BindingFlags BinderNonCreateInstance
		{
			get
			{
				BindingFlags bindingFlags;
				IL2CPP.il2cpp_field_static_get_value(RuntimeType.NativeFieldInfoPtr_BinderNonCreateInstance, (void*)(&bindingFlags));
				return bindingFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeType.NativeFieldInfoPtr_BinderNonCreateInstance, (void*)(&value));
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06001585 RID: 5509 RVA: 0x0008EE44 File Offset: 0x0008D044
		// (set) Token: 0x06001586 RID: 5510 RVA: 0x000069D5 File Offset: 0x00004BD5
		public unsafe static BindingFlags BinderGetSetProperty
		{
			get
			{
				BindingFlags bindingFlags;
				IL2CPP.il2cpp_field_static_get_value(RuntimeType.NativeFieldInfoPtr_BinderGetSetProperty, (void*)(&bindingFlags));
				return bindingFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeType.NativeFieldInfoPtr_BinderGetSetProperty, (void*)(&value));
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06001587 RID: 5511 RVA: 0x0008EE60 File Offset: 0x0008D060
		// (set) Token: 0x06001588 RID: 5512 RVA: 0x000069E3 File Offset: 0x00004BE3
		public unsafe static BindingFlags BinderSetInvokeProperty
		{
			get
			{
				BindingFlags bindingFlags;
				IL2CPP.il2cpp_field_static_get_value(RuntimeType.NativeFieldInfoPtr_BinderSetInvokeProperty, (void*)(&bindingFlags));
				return bindingFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeType.NativeFieldInfoPtr_BinderSetInvokeProperty, (void*)(&value));
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06001589 RID: 5513 RVA: 0x0008EE7C File Offset: 0x0008D07C
		// (set) Token: 0x0600158A RID: 5514 RVA: 0x000069F1 File Offset: 0x00004BF1
		public unsafe static BindingFlags BinderGetSetField
		{
			get
			{
				BindingFlags bindingFlags;
				IL2CPP.il2cpp_field_static_get_value(RuntimeType.NativeFieldInfoPtr_BinderGetSetField, (void*)(&bindingFlags));
				return bindingFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeType.NativeFieldInfoPtr_BinderGetSetField, (void*)(&value));
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x0600158B RID: 5515 RVA: 0x0008EE98 File Offset: 0x0008D098
		// (set) Token: 0x0600158C RID: 5516 RVA: 0x000069FF File Offset: 0x00004BFF
		public unsafe static BindingFlags BinderSetInvokeField
		{
			get
			{
				BindingFlags bindingFlags;
				IL2CPP.il2cpp_field_static_get_value(RuntimeType.NativeFieldInfoPtr_BinderSetInvokeField, (void*)(&bindingFlags));
				return bindingFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeType.NativeFieldInfoPtr_BinderSetInvokeField, (void*)(&value));
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x0600158D RID: 5517 RVA: 0x0008EEB4 File Offset: 0x0008D0B4
		// (set) Token: 0x0600158E RID: 5518 RVA: 0x00006A0D File Offset: 0x00004C0D
		public unsafe static BindingFlags BinderNonFieldGetSet
		{
			get
			{
				BindingFlags bindingFlags;
				IL2CPP.il2cpp_field_static_get_value(RuntimeType.NativeFieldInfoPtr_BinderNonFieldGetSet, (void*)(&bindingFlags));
				return bindingFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeType.NativeFieldInfoPtr_BinderNonFieldGetSet, (void*)(&value));
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x0600158F RID: 5519 RVA: 0x0008EED0 File Offset: 0x0008D0D0
		// (set) Token: 0x06001590 RID: 5520 RVA: 0x00006A1B File Offset: 0x00004C1B
		public unsafe static BindingFlags ClassicBindingMask
		{
			get
			{
				BindingFlags bindingFlags;
				IL2CPP.il2cpp_field_static_get_value(RuntimeType.NativeFieldInfoPtr_ClassicBindingMask, (void*)(&bindingFlags));
				return bindingFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeType.NativeFieldInfoPtr_ClassicBindingMask, (void*)(&value));
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06001591 RID: 5521 RVA: 0x0008EEEC File Offset: 0x0008D0EC
		// (set) Token: 0x06001592 RID: 5522 RVA: 0x00006A29 File Offset: 0x00004C29
		public unsafe static RuntimeType s_typedRef
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeType.NativeFieldInfoPtr_s_typedRef, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeType.NativeFieldInfoPtr_s_typedRef, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06001593 RID: 5523 RVA: 0x0008EF14 File Offset: 0x0008D114
		// (set) Token: 0x06001594 RID: 5524 RVA: 0x00006A3B File Offset: 0x00004C3B
		public unsafe MonoTypeInfo type_info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeType.NativeFieldInfoPtr_type_info);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoTypeInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeType.NativeFieldInfoPtr_type_info), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06001595 RID: 5525 RVA: 0x0008EF44 File Offset: 0x0008D144
		// (set) Token: 0x06001596 RID: 5526 RVA: 0x00006A5A File Offset: 0x00004C5A
		public unsafe Object GenericCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeType.NativeFieldInfoPtr_GenericCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeType.NativeFieldInfoPtr_GenericCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06001597 RID: 5527 RVA: 0x0008EF74 File Offset: 0x0008D174
		// (set) Token: 0x06001598 RID: 5528 RVA: 0x00006A79 File Offset: 0x00004C79
		public unsafe RuntimeConstructorInfo m_serializationCtor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeType.NativeFieldInfoPtr_m_serializationCtor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeConstructorInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeType.NativeFieldInfoPtr_m_serializationCtor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06001599 RID: 5529 RVA: 0x0008EFA4 File Offset: 0x0008D1A4
		// (set) Token: 0x0600159A RID: 5530 RVA: 0x00006A98 File Offset: 0x00004C98
		public unsafe static int GenericParameterCountAny
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RuntimeType.NativeFieldInfoPtr_GenericParameterCountAny, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeType.NativeFieldInfoPtr_GenericParameterCountAny, (void*)(&value));
			}
		}

		// Token: 0x040011BF RID: 4543
		private static readonly IntPtr NativeFieldInfoPtr_ValueType;

		// Token: 0x040011C0 RID: 4544
		private static readonly IntPtr NativeFieldInfoPtr_EnumType;

		// Token: 0x040011C1 RID: 4545
		private static readonly IntPtr NativeFieldInfoPtr_ObjectType;

		// Token: 0x040011C2 RID: 4546
		private static readonly IntPtr NativeFieldInfoPtr_StringType;

		// Token: 0x040011C3 RID: 4547
		private static readonly IntPtr NativeFieldInfoPtr_DelegateType;

		// Token: 0x040011C4 RID: 4548
		private static readonly IntPtr NativeFieldInfoPtr_s_SICtorParamTypes;

		// Token: 0x040011C5 RID: 4549
		private static readonly IntPtr NativeFieldInfoPtr_MakeTypeBuilderInstantiation;

		// Token: 0x040011C6 RID: 4550
		private static readonly IntPtr NativeFieldInfoPtr_MemberBindingMask;

		// Token: 0x040011C7 RID: 4551
		private static readonly IntPtr NativeFieldInfoPtr_InvocationMask;

		// Token: 0x040011C8 RID: 4552
		private static readonly IntPtr NativeFieldInfoPtr_BinderNonCreateInstance;

		// Token: 0x040011C9 RID: 4553
		private static readonly IntPtr NativeFieldInfoPtr_BinderGetSetProperty;

		// Token: 0x040011CA RID: 4554
		private static readonly IntPtr NativeFieldInfoPtr_BinderSetInvokeProperty;

		// Token: 0x040011CB RID: 4555
		private static readonly IntPtr NativeFieldInfoPtr_BinderGetSetField;

		// Token: 0x040011CC RID: 4556
		private static readonly IntPtr NativeFieldInfoPtr_BinderSetInvokeField;

		// Token: 0x040011CD RID: 4557
		private static readonly IntPtr NativeFieldInfoPtr_BinderNonFieldGetSet;

		// Token: 0x040011CE RID: 4558
		private static readonly IntPtr NativeFieldInfoPtr_ClassicBindingMask;

		// Token: 0x040011CF RID: 4559
		private static readonly IntPtr NativeFieldInfoPtr_s_typedRef;

		// Token: 0x040011D0 RID: 4560
		private static readonly IntPtr NativeFieldInfoPtr_type_info;

		// Token: 0x040011D1 RID: 4561
		private static readonly IntPtr NativeFieldInfoPtr_GenericCache;

		// Token: 0x040011D2 RID: 4562
		private static readonly IntPtr NativeFieldInfoPtr_m_serializationCtor;

		// Token: 0x040011D3 RID: 4563
		private static readonly IntPtr NativeFieldInfoPtr_GenericParameterCountAny;

		// Token: 0x040011D4 RID: 4564
		private static readonly IntPtr NativeMethodInfoPtr_GetType_Internal_Static_RuntimeType_String_Boolean_Boolean_Boolean_byref_StackCrawlMark_0;

		// Token: 0x040011D5 RID: 4565
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfTypeNeverValidGenericArgument_Private_Static_Void_RuntimeType_0;

		// Token: 0x040011D6 RID: 4566
		private static readonly IntPtr NativeMethodInfoPtr_SanityCheckGenericArguments_Internal_Static_Void_Il2CppReferenceArray_1_RuntimeType_Il2CppReferenceArray_1_RuntimeType_0;

		// Token: 0x040011D7 RID: 4567
		private static readonly IntPtr NativeMethodInfoPtr_SplitName_Private_Static_Void_String_byref_String_byref_String_0;

		// Token: 0x040011D8 RID: 4568
		private static readonly IntPtr NativeMethodInfoPtr_FilterPreCalculate_Internal_Static_BindingFlags_Boolean_Boolean_Boolean_0;

		// Token: 0x040011D9 RID: 4569
		private static readonly IntPtr NativeMethodInfoPtr_FilterHelper_Private_Static_Void_BindingFlags_byref_String_Boolean_byref_Boolean_byref_Boolean_byref_MemberListType_0;

		// Token: 0x040011DA RID: 4570
		private static readonly IntPtr NativeMethodInfoPtr_FilterHelper_Private_Static_Void_BindingFlags_byref_String_byref_Boolean_byref_MemberListType_0;

		// Token: 0x040011DB RID: 4571
		private static readonly IntPtr NativeMethodInfoPtr_FilterApplyPrefixLookup_Private_Static_Boolean_MemberInfo_String_Boolean_0;

		// Token: 0x040011DC RID: 4572
		private static readonly IntPtr NativeMethodInfoPtr_FilterApplyBase_Private_Static_Boolean_MemberInfo_BindingFlags_Boolean_Boolean_Boolean_String_Boolean_0;

		// Token: 0x040011DD RID: 4573
		private static readonly IntPtr NativeMethodInfoPtr_FilterApplyType_Private_Static_Boolean_Type_BindingFlags_String_Boolean_String_0;

		// Token: 0x040011DE RID: 4574
		private static readonly IntPtr NativeMethodInfoPtr_FilterApplyMethodInfo_Private_Static_Boolean_RuntimeMethodInfo_BindingFlags_CallingConventions_Il2CppReferenceArray_1_Type_0;

		// Token: 0x040011DF RID: 4575
		private static readonly IntPtr NativeMethodInfoPtr_FilterApplyConstructorInfo_Private_Static_Boolean_RuntimeConstructorInfo_BindingFlags_CallingConventions_Il2CppReferenceArray_1_Type_0;

		// Token: 0x040011E0 RID: 4576
		private static readonly IntPtr NativeMethodInfoPtr_FilterApplyMethodBase_Private_Static_Boolean_MethodBase_BindingFlags_BindingFlags_CallingConventions_Il2CppReferenceArray_1_Type_0;

		// Token: 0x040011E1 RID: 4577
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040011E2 RID: 4578
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodCandidates_Private_ListBuilder_1_MethodInfo_String_BindingFlags_CallingConventions_Il2CppReferenceArray_1_Type_Int32_Boolean_0;

		// Token: 0x040011E3 RID: 4579
		private static readonly IntPtr NativeMethodInfoPtr_GetConstructorCandidates_Private_ListBuilder_1_ConstructorInfo_String_BindingFlags_CallingConventions_Il2CppReferenceArray_1_Type_Boolean_0;

		// Token: 0x040011E4 RID: 4580
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyCandidates_Private_ListBuilder_1_PropertyInfo_String_BindingFlags_Il2CppReferenceArray_1_Type_Boolean_0;

		// Token: 0x040011E5 RID: 4581
		private static readonly IntPtr NativeMethodInfoPtr_GetEventCandidates_Private_ListBuilder_1_EventInfo_String_BindingFlags_Boolean_0;

		// Token: 0x040011E6 RID: 4582
		private static readonly IntPtr NativeMethodInfoPtr_GetFieldCandidates_Private_ListBuilder_1_FieldInfo_String_BindingFlags_Boolean_0;

		// Token: 0x040011E7 RID: 4583
		private static readonly IntPtr NativeMethodInfoPtr_GetNestedTypeCandidates_Private_ListBuilder_1_Type_String_BindingFlags_Boolean_0;

		// Token: 0x040011E8 RID: 4584
		private static readonly IntPtr NativeMethodInfoPtr_GetMethods_Public_Virtual_Il2CppReferenceArray_1_MethodInfo_BindingFlags_0;

		// Token: 0x040011E9 RID: 4585
		private static readonly IntPtr NativeMethodInfoPtr_GetConstructors_Public_Virtual_Il2CppReferenceArray_1_ConstructorInfo_BindingFlags_0;

		// Token: 0x040011EA RID: 4586
		private static readonly IntPtr NativeMethodInfoPtr_GetProperties_Public_Virtual_Il2CppReferenceArray_1_PropertyInfo_BindingFlags_0;

		// Token: 0x040011EB RID: 4587
		private static readonly IntPtr NativeMethodInfoPtr_GetEvents_Public_Virtual_Il2CppReferenceArray_1_EventInfo_BindingFlags_0;

		// Token: 0x040011EC RID: 4588
		private static readonly IntPtr NativeMethodInfoPtr_GetFields_Public_Virtual_Il2CppReferenceArray_1_FieldInfo_BindingFlags_0;

		// Token: 0x040011ED RID: 4589
		private static readonly IntPtr NativeMethodInfoPtr_GetMembers_Public_Virtual_Il2CppReferenceArray_1_MemberInfo_BindingFlags_0;

		// Token: 0x040011EE RID: 4590
		private static readonly IntPtr NativeMethodInfoPtr_GetConstructorImpl_Protected_Virtual_ConstructorInfo_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0;

		// Token: 0x040011EF RID: 4591
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyImpl_Protected_Virtual_PropertyInfo_String_BindingFlags_Binder_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0;

		// Token: 0x040011F0 RID: 4592
		private static readonly IntPtr NativeMethodInfoPtr_GetEvent_Public_Virtual_EventInfo_String_BindingFlags_0;

		// Token: 0x040011F1 RID: 4593
		private static readonly IntPtr NativeMethodInfoPtr_GetField_Public_Virtual_FieldInfo_String_BindingFlags_0;

		// Token: 0x040011F2 RID: 4594
		private static readonly IntPtr NativeMethodInfoPtr_GetInterface_Public_Virtual_Type_String_Boolean_0;

		// Token: 0x040011F3 RID: 4595
		private static readonly IntPtr NativeMethodInfoPtr_GetNestedType_Public_Virtual_Type_String_BindingFlags_0;

		// Token: 0x040011F4 RID: 4596
		private static readonly IntPtr NativeMethodInfoPtr_GetMember_Public_Virtual_Il2CppReferenceArray_1_MemberInfo_String_MemberTypes_BindingFlags_0;

		// Token: 0x040011F5 RID: 4597
		private static readonly IntPtr NativeMethodInfoPtr_get_Module_Public_Virtual_get_Module_0;

		// Token: 0x040011F6 RID: 4598
		private static readonly IntPtr NativeMethodInfoPtr_GetRuntimeModule_Internal_RuntimeModule_0;

		// Token: 0x040011F7 RID: 4599
		private static readonly IntPtr NativeMethodInfoPtr_get_Assembly_Public_Virtual_get_Assembly_0;

		// Token: 0x040011F8 RID: 4600
		private static readonly IntPtr NativeMethodInfoPtr_GetRuntimeAssembly_Internal_RuntimeAssembly_0;

		// Token: 0x040011F9 RID: 4601
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeHandle_Public_Virtual_get_RuntimeTypeHandle_0;

		// Token: 0x040011FA RID: 4602
		private static readonly IntPtr NativeMethodInfoPtr_IsInstanceOfType_Public_Virtual_Boolean_Object_0;

		// Token: 0x040011FB RID: 4603
		private static readonly IntPtr NativeMethodInfoPtr_IsAssignableFrom_Public_Virtual_Boolean_Type_0;

		// Token: 0x040011FC RID: 4604
		private static readonly IntPtr NativeMethodInfoPtr_IsEquivalentTo_Public_Virtual_Boolean_Type_0;

		// Token: 0x040011FD RID: 4605
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseType_Public_Virtual_get_Type_0;

		// Token: 0x040011FE RID: 4606
		private static readonly IntPtr NativeMethodInfoPtr_GetBaseType_Private_RuntimeType_0;

		// Token: 0x040011FF RID: 4607
		private static readonly IntPtr NativeMethodInfoPtr_get_UnderlyingSystemType_Public_Virtual_get_Type_0;

		// Token: 0x04001200 RID: 4608
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributeFlagsImpl_Protected_Virtual_TypeAttributes_0;

		// Token: 0x04001201 RID: 4609
		private static readonly IntPtr NativeMethodInfoPtr_IsContextfulImpl_Protected_Virtual_Boolean_0;

		// Token: 0x04001202 RID: 4610
		private static readonly IntPtr NativeMethodInfoPtr_IsByRefImpl_Protected_Virtual_Boolean_0;

		// Token: 0x04001203 RID: 4611
		private static readonly IntPtr NativeMethodInfoPtr_IsPrimitiveImpl_Protected_Virtual_Boolean_0;

		// Token: 0x04001204 RID: 4612
		private static readonly IntPtr NativeMethodInfoPtr_IsPointerImpl_Protected_Virtual_Boolean_0;

		// Token: 0x04001205 RID: 4613
		private static readonly IntPtr NativeMethodInfoPtr_IsCOMObjectImpl_Protected_Virtual_Boolean_0;

		// Token: 0x04001206 RID: 4614
		private static readonly IntPtr NativeMethodInfoPtr_IsValueTypeImpl_Protected_Virtual_Boolean_0;

		// Token: 0x04001207 RID: 4615
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEnum_Public_Virtual_get_Boolean_0;

		// Token: 0x04001208 RID: 4616
		private static readonly IntPtr NativeMethodInfoPtr_HasElementTypeImpl_Protected_Virtual_Boolean_0;

		// Token: 0x04001209 RID: 4617
		private static readonly IntPtr NativeMethodInfoPtr_get_GenericParameterAttributes_Public_Virtual_get_GenericParameterAttributes_0;

		// Token: 0x0400120A RID: 4618
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSzArray_Internal_Virtual_get_Boolean_0;

		// Token: 0x0400120B RID: 4619
		private static readonly IntPtr NativeMethodInfoPtr_IsArrayImpl_Protected_Virtual_Boolean_0;

		// Token: 0x0400120C RID: 4620
		private static readonly IntPtr NativeMethodInfoPtr_GetArrayRank_Public_Virtual_Int32_0;

		// Token: 0x0400120D RID: 4621
		private static readonly IntPtr NativeMethodInfoPtr_GetElementType_Public_Virtual_Type_0;

		// Token: 0x0400120E RID: 4622
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumNames_Public_Virtual_Il2CppStringArray_0;

		// Token: 0x0400120F RID: 4623
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumValues_Public_Virtual_Array_0;

		// Token: 0x04001210 RID: 4624
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumUnderlyingType_Public_Virtual_Type_0;

		// Token: 0x04001211 RID: 4625
		private static readonly IntPtr NativeMethodInfoPtr_IsEnumDefined_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001212 RID: 4626
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumName_Public_Virtual_String_Object_0;

		// Token: 0x04001213 RID: 4627
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericArgumentsInternal_Internal_Il2CppReferenceArray_1_RuntimeType_0;

		// Token: 0x04001214 RID: 4628
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericArguments_Public_Virtual_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04001215 RID: 4629
		private static readonly IntPtr NativeMethodInfoPtr_MakeGenericType_Public_Virtual_Type_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04001216 RID: 4630
		private static readonly IntPtr NativeMethodInfoPtr_get_IsGenericTypeDefinition_Public_Virtual_get_Boolean_0;

		// Token: 0x04001217 RID: 4631
		private static readonly IntPtr NativeMethodInfoPtr_get_IsGenericParameter_Public_Virtual_get_Boolean_0;

		// Token: 0x04001218 RID: 4632
		private static readonly IntPtr NativeMethodInfoPtr_get_GenericParameterPosition_Public_Virtual_get_Int32_0;

		// Token: 0x04001219 RID: 4633
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericTypeDefinition_Public_Virtual_Type_0;

		// Token: 0x0400121A RID: 4634
		private static readonly IntPtr NativeMethodInfoPtr_get_IsGenericType_Public_Virtual_get_Boolean_0;

		// Token: 0x0400121B RID: 4635
		private static readonly IntPtr NativeMethodInfoPtr_get_IsConstructedGenericType_Public_Virtual_get_Boolean_0;

		// Token: 0x0400121C RID: 4636
		private static readonly IntPtr NativeMethodInfoPtr_InvokeMember_Public_Virtual_Object_String_BindingFlags_Binder_Object_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_ParameterModifier_CultureInfo_Il2CppStringArray_0;

		// Token: 0x0400121D RID: 4637
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400121E RID: 4638
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RuntimeType_RuntimeType_0;

		// Token: 0x0400121F RID: 4639
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_RuntimeType_RuntimeType_0;

		// Token: 0x04001220 RID: 4640
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x04001221 RID: 4641
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001222 RID: 4642
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Boolean_0;

		// Token: 0x04001223 RID: 4643
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0;

		// Token: 0x04001224 RID: 4644
		private static readonly IntPtr NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0;

		// Token: 0x04001225 RID: 4645
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributesData_Public_Virtual_IList_1_CustomAttributeData_0;

		// Token: 0x04001226 RID: 4646
		private static readonly IntPtr NativeMethodInfoPtr_FormatTypeName_Internal_Virtual_String_Boolean_0;

		// Token: 0x04001227 RID: 4647
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberType_Public_Virtual_get_MemberTypes_0;

		// Token: 0x04001228 RID: 4648
		private static readonly IntPtr NativeMethodInfoPtr_get_ReflectedType_Public_Virtual_get_Type_0;

		// Token: 0x04001229 RID: 4649
		private static readonly IntPtr NativeMethodInfoPtr_get_MetadataToken_Public_Virtual_get_Int32_0;

		// Token: 0x0400122A RID: 4650
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstanceCheckThis_Private_Void_0;

		// Token: 0x0400122B RID: 4651
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstanceImpl_Internal_Object_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_Il2CppReferenceArray_1_Object_byref_StackCrawlMark_0;

		// Token: 0x0400122C RID: 4652
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstanceDefaultCtor_Internal_Object_Boolean_Boolean_Boolean_Boolean_byref_StackCrawlMark_0;

		// Token: 0x0400122D RID: 4653
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultConstructor_Internal_RuntimeConstructorInfo_0;

		// Token: 0x0400122E RID: 4654
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultMemberName_Private_String_0;

		// Token: 0x0400122F RID: 4655
		private static readonly IntPtr NativeMethodInfoPtr_GetSerializationCtor_Internal_RuntimeConstructorInfo_0;

		// Token: 0x04001230 RID: 4656
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstanceSlow_Internal_Object_Boolean_Boolean_Boolean_Boolean_0;

		// Token: 0x04001231 RID: 4657
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstanceMono_Private_Object_Boolean_Boolean_0;

		// Token: 0x04001232 RID: 4658
		private static readonly IntPtr NativeMethodInfoPtr_CheckValue_Internal_Object_Object_Binder_CultureInfo_BindingFlags_0;

		// Token: 0x04001233 RID: 4659
		private static readonly IntPtr NativeMethodInfoPtr_TryConvertToType_Private_Object_Object_byref_Boolean_0;

		// Token: 0x04001234 RID: 4660
		private static readonly IntPtr NativeMethodInfoPtr_IsConvertibleToPrimitiveType_Private_Static_Object_Object_Type_0;

		// Token: 0x04001235 RID: 4661
		private static readonly IntPtr NativeMethodInfoPtr_GetCachedName_Private_String_TypeNameKind_0;

		// Token: 0x04001236 RID: 4662
		private static readonly IntPtr NativeMethodInfoPtr_make_array_type_Private_Type_Int32_0;

		// Token: 0x04001237 RID: 4663
		private static readonly IntPtr NativeMethodInfoPtr_MakeArrayType_Public_Virtual_Type_0;

		// Token: 0x04001238 RID: 4664
		private static readonly IntPtr NativeMethodInfoPtr_MakeArrayType_Public_Virtual_Type_Int32_0;

		// Token: 0x04001239 RID: 4665
		private static readonly IntPtr NativeMethodInfoPtr_make_byref_type_Private_Type_0;

		// Token: 0x0400123A RID: 4666
		private static readonly IntPtr NativeMethodInfoPtr_MakeByRefType_Public_Virtual_Type_0;

		// Token: 0x0400123B RID: 4667
		private static readonly IntPtr NativeMethodInfoPtr_MakePointerType_Private_Static_Type_Type_0;

		// Token: 0x0400123C RID: 4668
		private static readonly IntPtr NativeMethodInfoPtr_MakePointerType_Public_Virtual_Type_0;

		// Token: 0x0400123D RID: 4669
		private static readonly IntPtr NativeMethodInfoPtr_get_ContainsGenericParameters_Public_Virtual_get_Boolean_0;

		// Token: 0x0400123E RID: 4670
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericParameterConstraints_Public_Virtual_Il2CppReferenceArray_1_Type_0;

		// Token: 0x0400123F RID: 4671
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstanceForAnotherGenericParameter_Internal_Static_Object_Type_RuntimeType_0;

		// Token: 0x04001240 RID: 4672
		private static readonly IntPtr NativeMethodInfoPtr_MakeGenericType_Private_Static_Type_Type_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04001241 RID: 4673
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodsByName_native_Internal_IntPtr_IntPtr_BindingFlags_MemberListType_0;

		// Token: 0x04001242 RID: 4674
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodsByName_Internal_Il2CppReferenceArray_1_RuntimeMethodInfo_String_BindingFlags_MemberListType_RuntimeType_0;

		// Token: 0x04001243 RID: 4675
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertiesByName_native_Private_IntPtr_IntPtr_BindingFlags_MemberListType_0;

		// Token: 0x04001244 RID: 4676
		private static readonly IntPtr NativeMethodInfoPtr_GetConstructors_native_Private_IntPtr_BindingFlags_0;

		// Token: 0x04001245 RID: 4677
		private static readonly IntPtr NativeMethodInfoPtr_GetConstructors_internal_Private_Il2CppReferenceArray_1_RuntimeConstructorInfo_BindingFlags_RuntimeType_0;

		// Token: 0x04001246 RID: 4678
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertiesByName_Private_Il2CppReferenceArray_1_RuntimePropertyInfo_String_BindingFlags_MemberListType_RuntimeType_0;

		// Token: 0x04001247 RID: 4679
		private static readonly IntPtr NativeMethodInfoPtr_GetGUID_Private_Static_Void_Type_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001248 RID: 4680
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_get_Guid_0;

		// Token: 0x04001249 RID: 4681
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeFromCLSIDImpl_Internal_Static_Type_Guid_String_Boolean_0;

		// Token: 0x0400124A RID: 4682
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeCodeImpl_Protected_Virtual_TypeCode_0;

		// Token: 0x0400124B RID: 4683
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeCodeImplInternal_Private_Static_TypeCode_Type_0;

		// Token: 0x0400124C RID: 4684
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400124D RID: 4685
		private static readonly IntPtr NativeMethodInfoPtr_IsGenericCOMObjectImpl_Private_Boolean_0;

		// Token: 0x0400124E RID: 4686
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstanceInternal_Private_Static_Object_Type_0;

		// Token: 0x0400124F RID: 4687
		private static readonly IntPtr NativeMethodInfoPtr_get_DeclaringMethod_Public_Virtual_get_MethodBase_0;

		// Token: 0x04001250 RID: 4688
		private static readonly IntPtr NativeMethodInfoPtr_getFullName_Internal_String_Boolean_Boolean_0;

		// Token: 0x04001251 RID: 4689
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericArgumentsInternal_Private_Il2CppReferenceArray_1_Type_Boolean_0;

		// Token: 0x04001252 RID: 4690
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericParameterAttributes_Private_GenericParameterAttributes_0;

		// Token: 0x04001253 RID: 4691
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericParameterPosition_Private_Int32_0;

		// Token: 0x04001254 RID: 4692
		private static readonly IntPtr NativeMethodInfoPtr_GetEvents_native_Private_IntPtr_IntPtr_MemberListType_0;

		// Token: 0x04001255 RID: 4693
		private static readonly IntPtr NativeMethodInfoPtr_GetFields_native_Private_IntPtr_IntPtr_BindingFlags_MemberListType_0;

		// Token: 0x04001256 RID: 4694
		private static readonly IntPtr NativeMethodInfoPtr_GetFields_internal_Private_Il2CppReferenceArray_1_RuntimeFieldInfo_String_BindingFlags_MemberListType_RuntimeType_0;

		// Token: 0x04001257 RID: 4695
		private static readonly IntPtr NativeMethodInfoPtr_GetEvents_internal_Private_Il2CppReferenceArray_1_RuntimeEventInfo_String_BindingFlags_MemberListType_RuntimeType_0;

		// Token: 0x04001258 RID: 4696
		private static readonly IntPtr NativeMethodInfoPtr_GetInterfaces_Public_Virtual_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04001259 RID: 4697
		private static readonly IntPtr NativeMethodInfoPtr_GetNestedTypes_native_Private_IntPtr_IntPtr_BindingFlags_MemberListType_0;

		// Token: 0x0400125A RID: 4698
		private static readonly IntPtr NativeMethodInfoPtr_GetNestedTypes_internal_Private_Il2CppReferenceArray_1_RuntimeType_String_BindingFlags_MemberListType_0;

		// Token: 0x0400125B RID: 4699
		private static readonly IntPtr NativeMethodInfoPtr_get_AssemblyQualifiedName_Public_Virtual_get_String_0;

		// Token: 0x0400125C RID: 4700
		private static readonly IntPtr NativeMethodInfoPtr_get_DeclaringType_Public_Virtual_get_Type_0;

		// Token: 0x0400125D RID: 4701
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x0400125E RID: 4702
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespace_Public_Virtual_get_String_0;

		// Token: 0x0400125F RID: 4703
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001260 RID: 4704
		private static readonly IntPtr NativeMethodInfoPtr_get_FullName_Public_Virtual_get_String_0;

		// Token: 0x04001261 RID: 4705
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSZArray_Public_Virtual_get_Boolean_0;

		// Token: 0x04001262 RID: 4706
		private static readonly IntPtr NativeMethodInfoPtr_IsSubclassOf_Public_Virtual_Boolean_Type_0;

		// Token: 0x04001263 RID: 4707
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodImpl_Protected_Virtual_MethodInfo_String_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0;

		// Token: 0x04001264 RID: 4708
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodImplCommon_Private_MethodInfo_String_Int32_BindingFlags_Binder_CallingConventions_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_ParameterModifier_0;

		// Token: 0x04001265 RID: 4709
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodCandidates_Private_ListBuilder_1_MethodInfo_String_Int32_BindingFlags_CallingConventions_Il2CppReferenceArray_1_Type_Boolean_0;

		// Token: 0x020005EF RID: 1519
		public enum MemberListType
		{
			// Token: 0x040047D8 RID: 18392
			All,
			// Token: 0x040047D9 RID: 18393
			CaseSensitive,
			// Token: 0x040047DA RID: 18394
			CaseInsensitive,
			// Token: 0x040047DB RID: 18395
			HandleToInfo
		}

		// Token: 0x020005F0 RID: 1520
		public sealed class ListBuilder<T> : ValueType where T : class
		{
			// Token: 0x06005783 RID: 22403 RVA: 0x00193568 File Offset: 0x00191768
			// Note: this type is marked as 'beforefieldinit'.
			static ListBuilder()
			{
				Il2CppClassPointerStore<RuntimeType.ListBuilder<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RuntimeType>.NativeClassPtr, "ListBuilder`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeType.ListBuilder<T>>.NativeClassPtr);
				RuntimeType.ListBuilder<T>.NativeFieldInfoPtr__items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType.ListBuilder<T>>.NativeClassPtr, "_items");
				RuntimeType.ListBuilder<T>.NativeFieldInfoPtr__item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType.ListBuilder<T>>.NativeClassPtr, "_item");
				RuntimeType.ListBuilder<T>.NativeFieldInfoPtr__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType.ListBuilder<T>>.NativeClassPtr, "_count");
				RuntimeType.ListBuilder<T>.NativeFieldInfoPtr__capacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeType.ListBuilder<T>>.NativeClassPtr, "_capacity");
				RuntimeType.ListBuilder<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType.ListBuilder<T>>.NativeClassPtr, 100667156);
				RuntimeType.ListBuilder<T>.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType.ListBuilder<T>>.NativeClassPtr, 100667157);
				RuntimeType.ListBuilder<T>.NativeMethodInfoPtr_ToArray_Public_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType.ListBuilder<T>>.NativeClassPtr, 100667158);
				RuntimeType.ListBuilder<T>.NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppReferenceArray_1_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType.ListBuilder<T>>.NativeClassPtr, 100667159);
				RuntimeType.ListBuilder<T>.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType.ListBuilder<T>>.NativeClassPtr, 100667160);
				RuntimeType.ListBuilder<T>.NativeMethodInfoPtr_Add_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeType.ListBuilder<T>>.NativeClassPtr, 100667161);
			}

			// Token: 0x06005784 RID: 22404 RVA: 0x00193698 File Offset: 0x00191898
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1341929, RefRangeEnd = 1341936, XrefRangeStart = 1341928, XrefRangeEnd = 1341929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ListBuilder(int capacity)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeType.ListBuilder<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref capacity;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.ListBuilder<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17001651 RID: 5713
			public unsafe T this[int index]
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 1341936, RefRangeEnd = 1341938, XrefRangeStart = 1341936, XrefRangeEnd = 1341936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.ListBuilder<T>.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
					}
				}
			}

			// Token: 0x06005786 RID: 22406 RVA: 0x00193730 File Offset: 0x00191930
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 1341940, RefRangeEnd = 1341950, XrefRangeStart = 1341938, XrefRangeEnd = 1341940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppArrayBase<T> ToArray()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.ListBuilder<T>.NativeMethodInfoPtr_ToArray_Public_Il2CppArrayBase_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}

			// Token: 0x06005787 RID: 22407 RVA: 0x0019376C File Offset: 0x0019196C
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 1341951, RefRangeEnd = 1341963, XrefRangeStart = 1341950, XrefRangeEnd = 1341951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CopyTo(Il2CppReferenceArray<Object> array, int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.ListBuilder<T>.NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppReferenceArray_1_Object_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001652 RID: 5714
			// (get) Token: 0x06005788 RID: 22408 RVA: 0x001937C4 File Offset: 0x001919C4
			public unsafe int Count
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeType.ListBuilder<T>.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005789 RID: 22409 RVA: 0x00193808 File Offset: 0x00191A08
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1341973, RefRangeEnd = 1341979, XrefRangeStart = 1341963, XrefRangeEnd = 1341973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Add(T item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = item;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref item;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RuntimeType.ListBuilder<T>.NativeMethodInfoPtr_Add_Public_Void_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}

			// Token: 0x0600578A RID: 22410 RVA: 0x0001F1A4 File Offset: 0x0001D3A4
			public ListBuilder(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600578B RID: 22411 RVA: 0x0001F1AD File Offset: 0x0001D3AD
			public ListBuilder()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeType.ListBuilder<T>>.NativeClassPtr))
			{
			}

			// Token: 0x1700164D RID: 5709
			// (get) Token: 0x0600578C RID: 22412 RVA: 0x00193888 File Offset: 0x00191A88
			// (set) Token: 0x0600578D RID: 22413 RVA: 0x0001F1BF File Offset: 0x0001D3BF
			public unsafe Il2CppArrayBase<T> _items
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeType.ListBuilder<T>.NativeFieldInfoPtr__items);
					return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeType.ListBuilder<T>.NativeFieldInfoPtr__items), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700164E RID: 5710
			// (get) Token: 0x0600578E RID: 22414 RVA: 0x001938B0 File Offset: 0x00191AB0
			// (set) Token: 0x0600578F RID: 22415 RVA: 0x001938D8 File Offset: 0x00191AD8
			public unsafe T _item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeType.ListBuilder<T>.NativeFieldInfoPtr__item);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeType.ListBuilder<T>.NativeFieldInfoPtr__item);
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

			// Token: 0x1700164F RID: 5711
			// (get) Token: 0x06005790 RID: 22416 RVA: 0x00193980 File Offset: 0x00191B80
			// (set) Token: 0x06005791 RID: 22417 RVA: 0x0001F1DE File Offset: 0x0001D3DE
			public unsafe int _count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeType.ListBuilder<T>.NativeFieldInfoPtr__count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeType.ListBuilder<T>.NativeFieldInfoPtr__count)) = value;
				}
			}

			// Token: 0x17001650 RID: 5712
			// (get) Token: 0x06005792 RID: 22418 RVA: 0x001939A8 File Offset: 0x00191BA8
			// (set) Token: 0x06005793 RID: 22419 RVA: 0x0001F1F9 File Offset: 0x0001D3F9
			public unsafe int _capacity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeType.ListBuilder<T>.NativeFieldInfoPtr__capacity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeType.ListBuilder<T>.NativeFieldInfoPtr__capacity)) = value;
				}
			}

			// Token: 0x040047DC RID: 18396
			private static readonly IntPtr NativeFieldInfoPtr__items;

			// Token: 0x040047DD RID: 18397
			private static readonly IntPtr NativeFieldInfoPtr__item;

			// Token: 0x040047DE RID: 18398
			private static readonly IntPtr NativeFieldInfoPtr__count;

			// Token: 0x040047DF RID: 18399
			private static readonly IntPtr NativeFieldInfoPtr__capacity;

			// Token: 0x040047E0 RID: 18400
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040047E1 RID: 18401
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0;

			// Token: 0x040047E2 RID: 18402
			private static readonly IntPtr NativeMethodInfoPtr_ToArray_Public_Il2CppArrayBase_1_T_0;

			// Token: 0x040047E3 RID: 18403
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppReferenceArray_1_Object_Int32_0;

			// Token: 0x040047E4 RID: 18404
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

			// Token: 0x040047E5 RID: 18405
			private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_T_0;
		}
	}
}
